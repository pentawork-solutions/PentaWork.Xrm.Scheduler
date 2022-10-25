using Microsoft.Xrm.Sdk.Client;
using System;

namespace PentaWork.Xrm.SchedulerService.Contracts
{
    public abstract class ServicePlugin
    {
        public abstract void Execute(OrganizationServiceContext context, ServicePluginContext pluginContext);

        public abstract string Name { get; }
        public abstract Guid Id { get; }
    }
}
