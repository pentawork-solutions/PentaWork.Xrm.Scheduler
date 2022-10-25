using System;

namespace PentaWork.Xrm.SchedulerService.Contracts
{
    public class ServicePluginContext
    {
        public Guid EntityId { get; set; }
        public string EntityName { get; set; }
        public Guid InitiatingUserId { get; set; }
    }
}
