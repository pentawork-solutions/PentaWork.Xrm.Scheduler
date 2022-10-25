using Microsoft.Xrm.Sdk.Client;
using PentaWork.Xrm.SchedulerService.Contracts;
using System;

namespace PentaWork.Xrm.TestPlugin.SchedulerServicePlugin
{
    public class ScheduleServiceTestPlugin : SchedulerPlugin
    {
        public override void Execute(OrganizationServiceContext context, ISchedulePluginLogger logger, string pluginConfigString)
        {
            throw new NotImplementedException();
        }

        public override string Name => "ScheduleServiceTestPlugin";
        public override Guid Id => new Guid("9a960683-28c6-4324-aafe-1574181eca8d");
    }
}
