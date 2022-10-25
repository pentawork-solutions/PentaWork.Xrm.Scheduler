using Microsoft.Xrm.Sdk.Client;
using System;

namespace PentaWork.Xrm.SchedulerService.Contracts
{
    public abstract class SchedulerPlugin
    {
        public abstract void Execute(OrganizationServiceContext context, ISchedulePluginLogger logger, string pluginConfigString);

        public abstract string Name { get; }
        public abstract Guid Id { get; }
    }
}
