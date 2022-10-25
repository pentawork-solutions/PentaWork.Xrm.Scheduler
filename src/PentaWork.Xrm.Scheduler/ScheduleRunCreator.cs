using Microsoft.Xrm.Sdk;
using Microsoft.Xrm.Sdk.Client;
using PentaWork.Xrm.Scheduler.Proxies.Entities;
using System;

namespace PentaWork.Xrm.Scheduler
{
    public class ScheduleRunCreator
    {
        private readonly OrganizationServiceContext _serviceContext;

        public ScheduleRunCreator(OrganizationServiceContext serviceContext)
        {
            _serviceContext = serviceContext;
        }

        public void CreateNextRun(PentaSchedule schedule, PentaScheduleRun scheduleRun)
        {
            var now = DateTime.UtcNow;
            scheduleRun.Status = PentaScheduleRun.eStatus.Inactive;
            scheduleRun.StatusReason = PentaScheduleRun.eStatusReason.Ended_Inactive;
            UpdateAndSave(scheduleRun);

            if (schedule.EndDateTime <= now || schedule.Frequency == PentaSchedule.egFrequency.Once)
            {
                schedule.LastRunDateTime = now;
                schedule.NextRun = null;
                schedule.StatusReason = PentaSchedule.eStatusReason.Ended_Active;
                UpdateAndSave(schedule);
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
                _serviceContext.AddObject(newScheduleRun);
                _serviceContext.SaveChanges();

                schedule.LastRunDateTime = now;
                schedule.NextRun = newScheduleRun.ToEntityReference();
                UpdateAndSave(schedule);
            }
        }

        private void UpdateAndSave(Entity entity)
        {
            if (!_serviceContext.IsAttached(entity))
            {
                _serviceContext.Attach(entity);
            }
            _serviceContext.UpdateObject(entity);
            _serviceContext.SaveChanges();
        }
    }
}
