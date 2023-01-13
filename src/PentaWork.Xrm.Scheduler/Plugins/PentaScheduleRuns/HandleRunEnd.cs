using PentaWork.Xrm.Scheduler.Extensions;
using PentaWork.Xrm.Scheduler.Proxies.Entities;
using System;
using System.Linq;

namespace PentaWork.Xrm.Scheduler.Plugins.PentaScheduleRuns
{
    [Event(Stage.PostOperation, MessageName.Update, PluginMode.Synchronous, -1, nameof(OnUpdate), PentaScheduleRun.Properties.StatusReason)]
    public class HandleRunEnd : CrmPlugin<PentaScheduleRun>
    {
        public void OnUpdate(PentaScheduleRun target, PentaScheduleRun preTarget)
        {
            var scheduleRun = Context.CreateQuery<PentaScheduleRun>().Single(p => p.Id == target.Id);
            var schedule = Context.CreateQuery<PentaSchedule>().Single(p => p.Id == scheduleRun.PentaSchedule.Id);

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
            Context.SaveChanges();
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
                Context.AddObject(newScheduleRun);
                Context.SaveChanges();

                schedule.LastRunDateTime = nextRun.AddMinutes(-5);
                schedule.NextRun = newScheduleRun.ToEntityReference();
                Context.AttachUpdate(schedule);
            }
            else if (retry)
            {
                CreateNextRun(schedule);
            }
            else
            {
                schedule.StatusReason = PentaSchedule.eStatusReason.Error_Active;
                Context.AttachUpdate(schedule);
            }
        }

        private void HandleErrorEmail(PentaSchedule schedule, PentaScheduleRun scheduleRun)
        {
            if (schedule.EmailOnError != true) return;  // nullables

        }

        private void CreateNextRun(PentaSchedule schedule)
        {
            var now = DateTime.UtcNow;
            if (schedule.EndDateTime <= now || schedule.Frequency == PentaSchedule.egFrequency.Once)
            {
                schedule.LastRunDateTime = now;
                schedule.NextRun = null;
                schedule.StatusReason = PentaSchedule.eStatusReason.Ended_Active;
                Context.AttachUpdate(schedule);
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
                Context.AddObject(newScheduleRun);
                Context.SaveChanges();

                schedule.LastRunDateTime = now;
                schedule.NextRun = newScheduleRun.ToEntityReference();
                Context.AttachUpdate(schedule);
            }
        }
    }
}
