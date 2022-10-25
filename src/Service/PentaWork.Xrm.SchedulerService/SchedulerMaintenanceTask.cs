using Microsoft.Xrm.Sdk.Client;
using NLog;
using PentaWork.Xrm.Scheduler.Proxies.Entities;
using PentaWork.Xrm.SchedulerService.Models;
using System;
using System.Configuration;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using System.Timers;
using System.Web.Hosting;
using Task = System.Threading.Tasks.Task;

namespace PentaWork.Xrm.SchedulerService
{
    public class SchedulerMaintenanceTask : IProcessHostPreloadClient
    {
        const double dailyInterval = 24 * 60 * 60 * 1000;
        private readonly Timer _timer = new Timer(dailyInterval);
        private readonly ILogger _logger = LogManager.GetCurrentClassLogger();

        public void Preload(string[] parameters)
        {
            Task.Run(() => StartMaintenance());
            StartRecurringMaintenance();
        }

        public void StartRecurringMaintenance()
        {
            _timer.Elapsed += new ElapsedEventHandler((o, e) => StartMaintenance());
            _timer.Enabled = true;
            _timer.AutoReset = true;
        }

        public void StartMaintenance()
        {
            try
            {
                _logger.Info("Starting maintenance ...");
                foreach (ConnectionStringSettings connection in ConfigurationManager.ConnectionStrings)
                {
                    if (connection.ProviderName.ToUpper() != "CRM") continue;

                    _logger.Info($"Maintenance for {connection.Name} ...");
                    var crmSystem = new CrmSystem(connection.Name, Assembly.GetAssembly(typeof(PentaSchedule)));
                    var serviceContext = new OrganizationServiceContext(crmSystem.GetService());

                    RestartHangingSchedules(serviceContext);
                    CleanUpOldRuns(serviceContext);
                }
                _logger.Info("Maintenance done!");
            }
            catch (Exception ex)
            {
                _logger.Error(ex.ToString());
            }
        }

        // If a CRM server restarts, it is possible that the schedule goes to an error state.
        // This method is responsible to restart these hanging schedules.
        private void RestartHangingSchedules(OrganizationServiceContext serviceContext)
        {
            var activeRuns = serviceContext.CreateQuery<PentaScheduleRun>().Where(r => r.StatusReason == PentaScheduleRun.eStatusReason.Waiting_Active && r.PentaSchedule != null).ToList();
            _logger.Info($"Found {activeRuns.Count} active runs. Checking for hanging ones ...");

            foreach (var run in activeRuns)
            {
                // If there are processes in WAITING status and the postponed until field equals DateTime.Max, it is a hanging system job
                var processList = serviceContext.CreateQuery<SystemJob>().Where(j => j.PostponeUntil != null && j.StatusReason == SystemJob.eStatusReason.Waiting_Inactive && j.Regarding == run.ToEntityReference()).ToList();
                var schedule = serviceContext.CreateQuery<PentaSchedule>().Single(s => s.Id == run.PentaSchedule.Id);
                if (processList.Any(p => p.PostponeUntil.Value.Year == DateTime.MaxValue.Year))
                {
                    _logger.Info($"Restarting schedule {schedule.Name} ...");

                    var newRun = new PentaScheduleRun();
                    newRun.PentaSchedule = run.PentaSchedule;
                    newRun.RunDateTime = run.RunDateTime;
                    newRun.StatusReason = PentaScheduleRun.eStatusReason.Waiting_Active;

                    serviceContext.AddObject(newRun);
                    serviceContext.DeleteObject(run);
                }
            }
            serviceContext.SaveChanges();            
        }

        private void CleanUpOldRuns(OrganizationServiceContext serviceContext)
        {
            var retainDuration = 30;
            if (ConfigurationManager.AppSettings["RunRetainDuration"] == null)
            {
                _logger.Warn($"App Setting 'RunRetainDuration' not found! Falling back to 30 days ..");
            }
            else
            {
                retainDuration = int.Parse(ConfigurationManager.AppSettings["RunRetainDuration"]);
            }

            _logger.Info($"Clearing old runs (Retain Duration: {retainDuration}) ...");
            serviceContext.CreateQuery<PentaScheduleRun>()
                .Where(r => r.RunDateTime < DateTime.Now.AddDays(-retainDuration))
                .ToList()
                .ForEach(r => serviceContext.DeleteObject(r));
            serviceContext.SaveChanges();
        }
    }
}