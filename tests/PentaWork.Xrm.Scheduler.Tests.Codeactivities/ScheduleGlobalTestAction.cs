using Microsoft.Xrm.Sdk;
using Microsoft.Xrm.Sdk.Client;
using Microsoft.Xrm.Sdk.Workflow;
using PentaWork.Xrm.Scheduler.Tests.Codeactivities.Proxies.Entities;
using System;
using System.Activities;
using System.Linq;

namespace PentaWork.Xrm.Scheduler.Tests.Codeactivities
{
    public class ScheduleGlobalTestAction : CodeActivity
    {
        private OrganizationServiceContext _serviceContext; 
        
        protected override void Execute(CodeActivityContext context)
        {
            var workflowContext = context.GetExtension<IWorkflowContext>();
            var serviceFactory = context.GetExtension<IOrganizationServiceFactory>();
            var organizationService = serviceFactory.CreateOrganizationService(workflowContext.InitiatingUserId);

            _serviceContext = new OrganizationServiceContext(organizationService);
           
            foreach(var account in _serviceContext.CreateQuery<Account>().ToList())
            {
                account.StockExchange = DateTime.Now.ToShortTimeString();
                _serviceContext.UpdateObject(account);
            }

            _serviceContext.SaveChanges();
        }
    }
}
