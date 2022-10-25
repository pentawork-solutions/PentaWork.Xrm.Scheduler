using Microsoft.Xrm.Sdk;
using PentaWork.Xrm.Scheduler.Tests.Codeactivities.Proxies.Entities;
using System;

namespace PentaWork.Xrm.Scheduler.Tests.Codeactivities
{
    public class ScheduleTestPlugin : IPlugin
    {
        public void Execute(IServiceProvider serviceProvider)
        {
            if (serviceProvider == null) throw new ArgumentNullException(nameof(serviceProvider));

            var pluginExecutionContext = (IPluginExecutionContext)serviceProvider.GetService(typeof(IPluginExecutionContext));
            var account = pluginExecutionContext.InputParameters["Target"] as Entity;
            account.Attributes[Account.Properties.StockExchange] = DateTime.Now.ToLongTimeString();
        }
    }
}
