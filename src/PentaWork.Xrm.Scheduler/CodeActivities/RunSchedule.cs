using Microsoft.Xrm.Sdk;
using Microsoft.Xrm.Sdk.Client;
using Microsoft.Xrm.Sdk.Workflow;
using PentaWork.Xrm.Scheduler.Proxies.Entities;
using System;
using System.Activities;
using System.Linq;

namespace PentaWork.Xrm.Scheduler.CodeActivities
{
    public class RunSchedule : CodeActivity
    {
        private OrganizationServiceContext _serviceContext;

        protected override void Execute(CodeActivityContext context)
        {
            var workflowContext = context.GetExtension<IWorkflowContext>();
            var serviceFactory = context.GetExtension<IOrganizationServiceFactory>();
            var organizationService = serviceFactory.CreateOrganizationService(workflowContext.InitiatingUserId);

            if (workflowContext.PrimaryEntityName != PentaScheduleRun.LogicalName)
                throw new InvalidWorkflowException("Workflow Entity is not a PentaScheduleRun! Skipping ...");

            _serviceContext = new OrganizationServiceContext(organizationService);
            
            var scheduleRun = _serviceContext.CreateQuery<PentaScheduleRun>().Single(c => c.Id == workflowContext.PrimaryEntityId);
            var schedule = _serviceContext.CreateQuery<PentaSchedule>().Single(c => c.Id == scheduleRun.PentaSchedule.Id);
            var logger = new ScheduleRunLogger(scheduleRun, _serviceContext, context.GetExtension<ITracingService>());

            var endpointService = context.GetExtension<IServiceEndpointNotificationService>();
            var executor = new ScheduleExecutor(_serviceContext, logger, () => endpointService.Execute(WebhookId.Get(context), workflowContext));
            var creator = new ScheduleRunCreator(_serviceContext);

            try
            {
                scheduleRun.StatusReason = PentaScheduleRun.eStatusReason.InProgress_Active;
                UpdateAndSave(scheduleRun);

                if (executor.ExecuteSchedule(schedule, scheduleRun)) creator.CreateNextRun(schedule, scheduleRun);
            }
            catch (Exception ex)
            {
                logger.Trace("Error!");
                logger.Trace(ex.ToString());

                schedule.StatusReason = PentaSchedule.eStatusReason.Error_Active;
                UpdateAndSave(schedule);

                scheduleRun.Status = PentaScheduleRun.eStatus.Inactive;
                scheduleRun.StatusReason = PentaScheduleRun.eStatusReason.Error_Inactive;
                UpdateAndSave(scheduleRun);

                // The executed workflow should be in error state. By catching everything it will be in
                // success state and it will be hard to see, that there was actually a problem during the execution.
                throw ex;
            }
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

        [RequiredArgument]
        [Input("WebhookId")]
        [ReferenceTarget("serviceendpoint")]
        public InArgument<EntityReference> WebhookId { get; set; }
    }
}
