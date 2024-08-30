using Microsoft.Crm.Sdk.Messages;
using Microsoft.Xrm.Sdk;
using Microsoft.Xrm.Sdk.Client;
using PentaWork.Xrm.Scheduler.Extensions;
using PentaWork.Xrm.Scheduler.Proxies.Entities;
using PentaWork.Xrm.Scheduler.Templates;
using System;
using System.Linq;

namespace PentaWork.Xrm.Scheduler.Plugins.PentaScheduleRuns
{
    [Event(Stage.PostOperation, MessageName.Update, PluginMode.Synchronous, nameof(OnUpdate), preImage: true,
        eventFieldNames: new string[] { PentaScheduleRun.Properties.StatusReason })]
    public class HandleRunEnd : CrmPlugin<PentaScheduleRun>
    {
        private readonly OrganizationServiceContext _context;

        public HandleRunEnd(CrmServices services) : base(services)
        {
            _context = services.Context;
        }

        public void OnUpdate(PentaScheduleRun target, PentaScheduleRun preTarget)
        {
            if (preTarget.StatusReason != PentaScheduleRun.eStatusReason.InProgress_Active) return;

            var scheduleRun = _context.CreateQuery<PentaScheduleRun>().Single(p => p.Id == target.Id);
            var schedule = _context.CreateQuery<PentaSchedule>().Single(p => p.Id == scheduleRun.PentaSchedule.Id);

            switch(target.StatusReason)
            {
                case PentaScheduleRun.eStatusReason.Error_Inactive:
                    HandleErrorState(schedule);
                    HandleErrorEmail(schedule, scheduleRun);
                    break;
                case PentaScheduleRun.eStatusReason.Ended_Inactive:
                    CreateNextRun(schedule);
                    break;
            }
        }

        private void HandleErrorState(PentaSchedule schedule)
        {
            schedule.SuccessiveErrors = schedule.SuccessiveErrors == null ? 1 : schedule.SuccessiveErrors + 1;
            var retry = schedule.SuccessiveErrors < schedule.ErrorThreshold && schedule.RetryOnError == true;

            if (retry && schedule.RetryImmediately == true) // nullables
            {
                var nextRun = DateTime.Now.AddMinutes(5);
                var newScheduleRun = new PentaScheduleRun();
                newScheduleRun.Name = $"{schedule.Name} - {nextRun.ToShortDateString()}";
                newScheduleRun.RunDateTime = nextRun;
                newScheduleRun.PentaSchedule = schedule.ToEntityReference();
                newScheduleRun.StatusReason = PentaScheduleRun.eStatusReason.Waiting_Active;
                _context.AddObject(newScheduleRun);
                _context.SaveChanges();

                schedule.LastRunDateTime = nextRun.AddMinutes(-5);
                schedule.NextRun = newScheduleRun.ToEntityReference();
                _context.AttachUpdate(schedule);
            }
            else if (retry)
            {
                CreateNextRun(schedule);
            }
            else
            {
                schedule.StatusReason = PentaSchedule.eStatusReason.Error_Active;
                _context.AttachUpdate(schedule);
            }
            _context.SaveChanges();
        }

        private void HandleErrorEmail(PentaSchedule schedule, PentaScheduleRun scheduleRun)
        {
            var retry = schedule.SuccessiveErrors < schedule.ErrorThreshold && schedule.RetryOnError == true;
            if (schedule.EmailOnError != true || retry) return;  // nullables

            var recipients = new EntityCollection();
            recipients.Entities.Add(new ActivityParty() { Address = schedule.ErrorEmailAddress });

            var emailTemplate = new EmailScheduleError { Schedule = schedule, OrgName = PluginContext.OrganizationName, Log = scheduleRun.Log.Replace(Environment.NewLine, "<br/>") };
            var email = new Email
            {
                Regarding = schedule.ToEntityReference(),
                Subject = $"Scheduler Error on '{PluginContext.OrganizationName}' for '{schedule.Name}'",
                Description = emailTemplate.TransformText(),
                To = recipients
            };
            _context.AddObject(email);
            _context.SaveChanges();

            var requestEmail = new SendEmailRequest
            {
                EmailId = email.Id,
                IssueSend = true
            };
            _context.Execute(requestEmail);
        }

        private void CreateNextRun(PentaSchedule schedule)
        {
            var now = DateTime.UtcNow;
            if (schedule.EndDateTime <= now || schedule.Frequency == PentaSchedule.egFrequency.Once)
            {
                schedule.LastRunDateTime = now;
                schedule.NextRun = null;
                schedule.StatusReason = PentaSchedule.eStatusReason.Ended_Active;
                _context.AttachUpdate(schedule);
            }
            else
            {
                var startDate = schedule.StartDateTime.Value;
                DateTime? nextRun = null;
                switch (schedule.Frequency)
                {
                    case PentaSchedule.egFrequency.Once:
                        break;
                    case PentaSchedule.egFrequency.Hourly:
                        {
                            var addedTime = now.AddHours(1);
                            nextRun = addedTime.Date + new TimeSpan(addedTime.Hour, startDate.Minute, startDate.Second);
                            break;
                        }
                    case PentaSchedule.egFrequency.Daily:
                        nextRun = now.AddDays(1).Date + new TimeSpan(startDate.Hour, startDate.Minute, startDate.Second);
                        break;
                    case PentaSchedule.egFrequency.Weekly:
                        nextRun = now.AddDays(7).Date + new TimeSpan(startDate.Hour, startDate.Minute, startDate.Second);
                        break;
                    case PentaSchedule.egFrequency.Monthly:
                        nextRun = now.AddMonths(1).Date + new TimeSpan(startDate.Hour, startDate.Minute, startDate.Second);
                        break;
                    case PentaSchedule.egFrequency.Quarterly:
                        nextRun = now.AddMonths(3).Date + new TimeSpan(startDate.Hour, startDate.Minute, startDate.Second);
                        break;
                    case PentaSchedule.egFrequency.Yearly:
                        nextRun = now.AddYears(1).Date + new TimeSpan(startDate.Hour, startDate.Minute, startDate.Second);
                        break;
                    case PentaSchedule.egFrequency.EveryXMinutes:
                        {
                            var addedTime = now.AddMinutes(schedule.FrequencyValue.GetValueOrDefault());
                            nextRun = addedTime.Date + new TimeSpan(addedTime.Hour, addedTime.Minute, startDate.Second);
                            break;
                        }
                    case PentaSchedule.egFrequency.EveryXHours:
                        {
                            var addedTime = now.AddHours(schedule.FrequencyValue.GetValueOrDefault());
                            nextRun = addedTime.Date + new TimeSpan(addedTime.Hour, startDate.Minute, startDate.Second);
                            break;
                        }
                    case PentaSchedule.egFrequency.EveryXDays:
                        nextRun = now.AddDays(schedule.FrequencyValue.GetValueOrDefault()).Date + new TimeSpan(startDate.Hour, startDate.Minute, startDate.Second);
                        break;
                    case PentaSchedule.egFrequency.EveryXWeeks:
                        nextRun = now.AddDays(7 * schedule.FrequencyValue.GetValueOrDefault()).Date + new TimeSpan(startDate.Hour, startDate.Minute, startDate.Second);
                        break;
                    case PentaSchedule.egFrequency.EveryXMonths:
                        nextRun = now.AddMonths(schedule.FrequencyValue.GetValueOrDefault()).Date + new TimeSpan(startDate.Hour, startDate.Minute, startDate.Second);
                        break;
                }

                var newScheduleRun = new PentaScheduleRun();
                newScheduleRun.Name = $"{schedule.Name} - {nextRun.Value.ToShortDateString()}";
                newScheduleRun.RunDateTime = nextRun;
                newScheduleRun.PentaSchedule = schedule.ToEntityReference();
                newScheduleRun.StatusReason = PentaScheduleRun.eStatusReason.Waiting_Active;
                _context.AddObject(newScheduleRun);
                _context.SaveChanges();

                schedule.LastRunDateTime = now;
                schedule.NextRun = newScheduleRun.ToEntityReference();
                schedule.SuccessiveErrors = 0;
                _context.AttachUpdate(schedule);
            }
            _context.SaveChanges();
        }
    }
}
