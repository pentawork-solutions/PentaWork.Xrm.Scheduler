using Microsoft.Xrm.Sdk;
using Microsoft.Xrm.Sdk.Client;
using PentaWork.Xrm.Scheduler.Proxies.Entities;
using System;

namespace PentaWork.Xrm.Scheduler
{
    internal class ScheduleRunLogger
    {
        private readonly PentaScheduleRun _scheduleRun;
        private readonly OrganizationServiceContext _serviceContext;
        private readonly ITracingService _trace;

        public ScheduleRunLogger(PentaScheduleRun scheduleRun, OrganizationServiceContext serviceContext, ITracingService trace)
        {
            _scheduleRun = scheduleRun;
            _serviceContext = serviceContext;
            _trace = trace;
        }

        public void Trace(string message)
        {
            _trace.Trace(message);
            _scheduleRun.Log = RollingLog($"{DateTime.Now.ToLongTimeString()} | TRACE | {message}{Environment.NewLine}{_scheduleRun.Log}");
            UpdateAndSave(_scheduleRun);
        }

        private string RollingLog(string log)
        {
            return log.Length > 100000
                ? log.Substring(0, 100000)
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
