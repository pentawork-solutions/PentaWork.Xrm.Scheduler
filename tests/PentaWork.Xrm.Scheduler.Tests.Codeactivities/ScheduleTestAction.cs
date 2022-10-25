using Microsoft.Xrm.Sdk;
using Microsoft.Xrm.Sdk.Client;
using Microsoft.Xrm.Sdk.Workflow;
using PentaWork.Xrm.Scheduler.Tests.Codeactivities.Proxies.Entities;
using System;
using System.Activities;
using System.Linq;

namespace PentaWork.Xrm.Scheduler.Tests.Codeactivities
{
    public class ScheduleTestAction : CodeActivity
    {
        private ITracingService _trace;
        private OrganizationServiceContext _serviceContext; 
        
        protected override void Execute(CodeActivityContext context)
        {
            var workflowContext = context.GetExtension<IWorkflowContext>();
            var serviceFactory = context.GetExtension<IOrganizationServiceFactory>();
            var organizationService = serviceFactory.CreateOrganizationService(workflowContext.InitiatingUserId);

            _trace = context.GetExtension<ITracingService>();
            _serviceContext = new OrganizationServiceContext(organizationService);
            if (workflowContext.PrimaryEntityName != Account.LogicalName)
            {
                _trace.Trace("Workflow Entity is not an Account! Skipping ...");
                return;
            }

            var account = _serviceContext.CreateQuery<Account>().Single(c => c.Id == workflowContext.PrimaryEntityId);
            account.StockExchange = DateTime.Now.ToShortTimeString();

            _serviceContext.UpdateObject(account);
            _serviceContext.SaveChanges();
        }
    }
}
