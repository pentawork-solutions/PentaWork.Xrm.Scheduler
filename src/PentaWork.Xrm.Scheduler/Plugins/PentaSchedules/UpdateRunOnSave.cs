using Microsoft.Xrm.Sdk;
using Microsoft.Xrm.Sdk.Client;
using PentaWork.Xrm.Scheduler.Proxies.Entities;
using System;
using System.Linq;

namespace PentaWork.Xrm.Scheduler.Plugins.PentaSchedules
{
    [Event(Stage.PostOperation, MessageName.Create, PluginMode.Synchronous, nameof(OnCreate), executionDepth: 1)]
    [Event(Stage.PostOperation, MessageName.Update, PluginMode.Synchronous, nameof(OnUpdate), preImage: true,
        eventFieldNames: new string[] { PentaSchedule.Properties.StatusReason })]
    public class UpdateRunOnSave : CrmPlugin<PentaSchedule>
    {
        private readonly IOrganizationService _service;
        private readonly OrganizationServiceContext _context;

        public UpdateRunOnSave(CrmServices services) : base(services) 
        {
            _service = services.Service;
            _context = services.Context;
        }

        public void OnCreate(PentaSchedule target)
        {
            if (target.StatusReason == PentaSchedule.eStatusReason.Active_Active)
            {
                CreateRun(target, target.StartDateTime?.ToUniversalTime());
            }
        }

        public void OnUpdate(PentaSchedule target, PentaSchedule preTarget)
        {
            var schedule = _context.CreateQuery<PentaSchedule>().Single(s => s.Id == target.Id);
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
            var update = new PentaSchedule
            {
                Id = target.Id,
                StartDateTime = startDateTimeUTC < DateTime.UtcNow ? DateTime.UtcNow : target.StartDateTime,
                NextRun = CreateNewRun(target, target.StartDateTime),
                SuccessiveErrors = 0
            };
            _service.Update(update);
        }

        private void DeleteOpenRuns(PentaSchedule target)
        {
            var openRuns = _context.CreateQuery<PentaScheduleRun>().Where(r => r.PentaSchedule != null && r.PentaSchedule.Id == target.Id && r.Status == PentaScheduleRun.eStatus.Active);
            foreach (var run in openRuns)
            {
                _context.DeleteObject(run);
            }
            _context.SaveChanges();

            var update = new PentaSchedule { 
                Id = target.Id,
                NextRun = null
            };
            _service.Update(update);
        }

        private EntityReference CreateNewRun(PentaSchedule schedule, DateTime? runDateTime)
        {
            var scheduleRun = new PentaScheduleRun();
            scheduleRun.Name = $"{schedule.Name} - {runDateTime.Value.ToShortDateString()}";
            scheduleRun.PentaSchedule = schedule.ToEntityReference();
            scheduleRun.RunDateTime = runDateTime;
            scheduleRun.StatusReason = PentaScheduleRun.eStatusReason.Waiting_Active;

            _context.AddObject(scheduleRun);
            _context.SaveChanges();

            return scheduleRun.ToEntityReference();
        }
    }
} 