using Microsoft.Crm.Sdk.Messages;
using Microsoft.Xrm.Sdk.Client;
using PentaWork.Xrm.Scheduler.Proxies.Entities;
using System;

namespace PentaWork.Xrm.Scheduler.Extensions
{
    internal static class ProcessExtensions
    {
        public static ExecuteWorkflowResponse Trigger(this Process process, OrganizationServiceContext serviceContext, Guid targetId)
        {
            var request = new ExecuteWorkflowRequest()
            {
                WorkflowId = process.Id,
                EntityId = targetId
            };
            return (ExecuteWorkflowResponse) serviceContext.Execute(request);
        }
    }
}
