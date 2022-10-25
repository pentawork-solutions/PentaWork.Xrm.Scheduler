using Microsoft.Xrm.Sdk;
using Microsoft.Xrm.Sdk.Client;
using NLog;
using PentaWork.Xrm.Scheduler.Proxies.Entities;
using PentaWork.Xrm.SchedulerService.Contracts;
using System;

namespace PentaWork.Xrm.SchedulerService
{
    internal class SchedulePluginLogger : ISchedulePluginLogger
    {
        private readonly ILogger _logger;
        private readonly PentaScheduleRun _scheduleRun;
        private readonly OrganizationServiceContext _serviceContext;

        public SchedulePluginLogger(string scheduleName, PentaScheduleRun scheduleRun, OrganizationServiceContext serviceContext)
        {
            _scheduleRun = scheduleRun;
            _serviceContext = serviceContext;
            _logger = LogManager.GetLogger(scheduleName);

            // Clear Attributes to prevent false updates
            var currentLog = _scheduleRun.Log;
            _scheduleRun.Attributes.Clear();
            _scheduleRun.Attributes.Add(PentaScheduleRun.Properties.Log, currentLog);
        }

        public void Trace(string message)
        {
            _logger.Trace(message);
            _scheduleRun.Log = RollingLog($"{DateTime.Now.ToLongTimeString()} | TRACE | {message}{Environment.NewLine}{_scheduleRun.Log}");
            UpdateAndSave(_scheduleRun);
        }

        public void Info(string message)
        {
            _logger.Info(message);
            _scheduleRun.Log = RollingLog($"{DateTime.Now.ToLongTimeString()} |  INFO | {message}{Environment.NewLine}{_scheduleRun.Log}");
            UpdateAndSave(_scheduleRun);
        }

        public void Warn(string message)
        {
            _logger.Warn(message);
            _scheduleRun.Log = RollingLog($"{DateTime.Now.ToLongTimeString()} |  WARN | {message}{Environment.NewLine}{_scheduleRun.Log}");
            UpdateAndSave(_scheduleRun);
        }

        public void Error(string message)
        {
            _logger.Error(message);
            _scheduleRun.Log = RollingLog($"{DateTime.Now.ToLongTimeString()} | ERROR | {message}{Environment.NewLine}{_scheduleRun.Log}");
            UpdateAndSave(_scheduleRun);
        }

        private string RollingLog(string log)
        {
            return log.Length > 20000
                ? log.Substring(0, 20000)
                : log;
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