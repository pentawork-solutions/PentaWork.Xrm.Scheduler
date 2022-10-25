using Microsoft.Xrm.Sdk;
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
                SetDatetimes(target, target.StartDateTime?.ToUniversalTime());
                Context.SaveChanges();
            }
        }

        public void OnUpdate(PentaSchedule target, PentaSchedule preTarget)
        {
            var schedule = Context.CreateQuery<PentaSchedule>().Single(s => s.Id == target.Id);
            if (schedule.StatusReason == PentaSchedule.eStatusReason.Active_Active && preTarget.StatusReason != PentaSchedule.eStatusReason.Active_Active)
            {
                SetDatetimes(schedule, schedule.StartDateTime?.ToUniversalTime());
            }
            else if (schedule.StatusReason != PentaSchedule.eStatusReason.Active_Active)
            {
                DeleteOpenRuns(schedule);
            }
            Context.SaveChanges();
        }

        private void SetDatetimes(PentaSchedule target, DateTime? startDateTimeUTC)
        {
            if (startDateTimeUTC < DateTime.UtcNow) target.StartDateTime = DateTime.UtcNow;
            target.NextRun = CreateNewRun(target, target.StartDateTime);

            if(!Context.IsAttached(target)) Context.Attach(target);
            Context.UpdateObject(target);
        }

        private void DeleteOpenRuns(PentaSchedule target)
        {
            var openRuns = Context.CreateQuery<PentaScheduleRun>().Where(r => r.PentaSchedule != null && r.PentaSchedule.Id == target.Id && r.Status == PentaScheduleRun.eStatus.Active);
            foreach (var run in openRuns)
            {
                Context.DeleteObject(run);
            }
            target.NextRun = null;

            if (!Context.IsAttached(target)) Context.Attach(target);
            Context.UpdateObject(target);
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