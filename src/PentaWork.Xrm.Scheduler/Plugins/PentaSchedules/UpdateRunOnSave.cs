using Microsoft.Xrm.Sdk;
using PentaWork.Xrm.Scheduler.Extensions;
using PentaWork.Xrm.Scheduler.Proxies.Entities;
using System;
using System.Linq;

namespace PentaWork.Xrm.Scheduler.Plugins.PentaSchedules
{
    [Event(Stage.PostOperation, MessageName.Create, PluginMode.Synchronous, 1, nameof(OnCreate))]
    [Event(Stage.PostOperation, MessageName.Update, PluginMode.Synchronous, 1, nameof(OnUpdate), PentaSchedule.Properties.StatusReason)]
    public class UpdateRunOnSave : CrmPlugin<PentaSchedule>
    {
        public void OnCreate(PentaSchedule target, PentaSchedule preTarget)
        {
            if (target.StatusReason == PentaSchedule.eStatusReason.Active_Active)
            {
                CreateRun(target, target.StartDateTime?.ToUniversalTime());
            }
        }

        public void OnUpdate(PentaSchedule target, PentaSchedule preTarget)
        {
            var schedule = Context.CreateQuery<PentaSchedule>().Single(s => s.Id == target.Id);
            if (schedule.StatusReason == PentaSchedule.eStatusReason.Active_Active && preTarget.StatusReason != PentaSchedule.eStatusReason.Active_Active)
            {
                CreateRun(schedule, schedule.StartDateTime?.ToUniversalTime());
            }
            else if (schedule.StatusReason != PentaSchedule.eStatusReason.Active_Active)
            {
                DeleteOpenRuns(schedule);
            }
        }

        private void CreateRun(PentaSchedule target, DateTime? startDateTimeUTC)
        {
            target.StartDateTime = startDateTimeUTC < DateTime.UtcNow ? DateTime.UtcNow : target.StartDateTime;
            target.NextRun = CreateNewRun(target, target.StartDateTime);
            target.SuccessiveErrors = 0;

            Context.AttachUpdate(target);
            Context.SaveChanges();
        }

        private void DeleteOpenRuns(PentaSchedule target)
        {
            var openRuns = Context.CreateQuery<PentaScheduleRun>().Where(r => r.PentaSchedule != null && r.PentaSchedule.Id == target.Id && r.Status == PentaScheduleRun.eStatus.Active);
            foreach (var run in openRuns)
            {
                Context.DeleteObject(run);
            }
            target.NextRun = null;

            Context.AttachUpdate(target);
            Context.SaveChanges();
        }

        private EntityReference CreateNewRun(PentaSchedule schedule, DateTime? runDateTime)
        {
            var scheduleRun = new PentaScheduleRun();
            scheduleRun.Name = $"{schedule.Name} - {runDateTime.Value.ToShortDateString()}";
            scheduleRun.PentaSchedule = schedule.ToEntityReference();
            scheduleRun.RunDateTime = runDateTime;
            scheduleRun.StatusReason = PentaScheduleRun.eStatusReason.Waiting_Active;

            Context.AddObject(scheduleRun);
            Context.SaveChanges();

            return scheduleRun.ToEntityReference();
        }
    }
} 