using Microsoft.Crm.Sdk.Messages;
using Microsoft.Xrm.Sdk;
using Microsoft.Xrm.Sdk.Client;
using Microsoft.Xrm.Sdk.Messages;
using Microsoft.Xrm.Sdk.Workflow;
using PentaWork.Xrm.Scheduler.Extensions;
using PentaWork.Xrm.Scheduler.Proxies.Entities;
using System;
using System.Activities;
using System.Collections.Generic;
using System.Linq;

namespace PentaWork.Xrm.Scheduler.CodeActivities
{
    public class RunSchedule : CodeActivity
    {
        private PentaScheduleRun _scheduleRun;
        private PentaSchedule _schedule;
        private ScheduleRunLogger _logger;
        private OrganizationServiceContext _serviceContext;

        protected override void Execute(CodeActivityContext context)
        {
            var workflowContext = context.GetExtension<IWorkflowContext>();
            var serviceFactory = context.GetExtension<IOrganizationServiceFactory>();
            var organizationService = serviceFactory.CreateOrganizationService(workflowContext.InitiatingUserId);

            if (workflowContext.PrimaryEntityName != PentaScheduleRun.LogicalName)
                throw new InvalidWorkflowException("Workflow Entity is not a PentaScheduleRun! Skipping ...");

            _serviceContext = new OrganizationServiceContext(organizationService);
            _scheduleRun = _serviceContext.CreateQuery<PentaScheduleRun>().Single(c => c.Id == workflowContext.PrimaryEntityId);
            _schedule = _serviceContext.CreateQuery<PentaSchedule>().Single(c => c.Id == _scheduleRun.PentaSchedule.Id);
            _logger = new ScheduleRunLogger(_scheduleRun, _serviceContext, context.GetExtension<ITracingService>());

            var endpointService = context.GetExtension<IServiceEndpointNotificationService>();
            Action serviceAction = () => endpointService.Execute(WebhookId.Get(context), workflowContext);

            try
            {
                _scheduleRun.StatusReason = PentaScheduleRun.eStatusReason.InProgress_Active;
                UpdateAndSave(_scheduleRun);

                if (_schedule.ScheduleType == PentaSchedule.egScheduleType.SchedulePlugin)
                {
                    _logger.Trace("Triggering Service Webhook ...");
                    serviceAction();
                }
                else if (_schedule.ScheduleType == PentaSchedule.egScheduleType.GlobalAction)
                {
                    ExecuteGlobalActionSchedule();

                    _scheduleRun.Status = PentaScheduleRun.eStatus.Inactive;
                    _scheduleRun.StatusReason = PentaScheduleRun.eStatusReason.Ended_Inactive;
                    UpdateAndSave(_scheduleRun);
                }
                else
                {
                    var (moreRecords, relevantEntities) = GetAndHandleEntityPage();
                    switch (_schedule.ScheduleType)
                    {
                        case PentaSchedule.egScheduleType.Action:
                            ExecuteActionSchedule(relevantEntities);
                            break;
                        case PentaSchedule.egScheduleType.Workflow:
                            ExecuteWorkflowSchedule(relevantEntities);
                            break;
                    }

                    if (moreRecords && _scheduleRun.CurrentPage != _scheduleRun.TotalPages)
                    {
                        if (_scheduleRun.CurrentPage < _scheduleRun.TotalPages)
                        {
                            _scheduleRun.CurrentPage++;
                            UpdateAndSave(_scheduleRun);
                        }

                        if (_scheduleRun.CurrentPage % 5 == 0 && _scheduleRun.TotalPages >= 5)
                        {
                            _logger.Trace("Triggering next entity page, but wait one hour to reset depth ...");

                            var workflow = _serviceContext.CreateQuery<Process>().Single(p => p.ProcessName == "Execute Schedule Run (Wait an hour)" && p.ParentProcessID == null);
                            workflow.Trigger(_serviceContext, _scheduleRun.Id);

                            _scheduleRun.StatusReason = PentaScheduleRun.eStatusReason.WaitingDepthReset_Active;
                            UpdateAndSave(_scheduleRun);
                        }
                        else
                        {
                            _logger.Trace("Triggering next entity page ...");
                            var workflow = _serviceContext.CreateQuery<Process>().Single(p => p.ProcessName == "Execute Schedule Run" && p.ParentProcessID == null);
                            workflow.Trigger(_serviceContext, _scheduleRun.Id);
                        }
                    }
                    else
                    {
                        _scheduleRun.Status = PentaScheduleRun.eStatus.Inactive;
                        _scheduleRun.StatusReason = PentaScheduleRun.eStatusReason.Ended_Inactive;
                        UpdateAndSave(_scheduleRun);
                    }
                }
            }
            catch (Exception ex)
            {
                _logger.Trace("Error!");
                _logger.Trace(ex.ToString());

                _scheduleRun.Status = PentaScheduleRun.eStatus.Inactive;
                _scheduleRun.StatusReason = PentaScheduleRun.eStatusReason.Error_Inactive;
                UpdateAndSave(_scheduleRun);

                // The executed workflow should be in error state. By catching everything it will be in
                // success state and it will be hard to see, that there was actually a problem during the execution.
                throw ex;
            }
        }

        private void ExecuteGlobalActionSchedule()
        {
            var action = _serviceContext.CreateQuery<Process>().Single(p => p.Id == _schedule.GlobalAction.Id);
            var sdkMessage = _serviceContext.CreateQuery<SdkMessage>().Single(m => m.Id == action.SDKMessage.Id);
            _logger.Trace($"Executing global action '{sdkMessage.Name}' ...");

            var orgRequest = new OrganizationRequest(sdkMessage.Name);
            _serviceContext.Execute(orgRequest);

            _logger.Trace($"Triggered global action!");
        }

        private bool ExecuteActionSchedule(List<Entity> relevantEntities)
        {
            var action = _serviceContext.CreateQuery<Process>().Single(p => p.Id == _schedule.Action.Id);
            var sdkMessage = _serviceContext.CreateQuery<SdkMessage>().Single(m => m.Id == action.SDKMessage.Id);
            _logger.Trace($"Executing action '{sdkMessage.Name}' with {relevantEntities.Count} entities ...");

            var resultList = new List<OrganizationResponse>();
            var orgRequest = new OrganizationRequest(sdkMessage.Name);
            foreach (var entity in relevantEntities)
            {
                try
                {
                    orgRequest["Target"] = entity.ToEntityReference();
                    resultList.Add(_serviceContext.Execute(orgRequest));
                }
                catch (Exception ex)
                {
                    _logger.Trace($"ERROR during triggering action for '{entity.Id}'! {ex}");
                }
            }

            _logger.Trace($"Triggered {resultList.Count} actions!");
            return true;
        }

        private void ExecuteWorkflowSchedule(List<Entity> relevantEntities)
        {
            var workflow = _serviceContext.CreateQuery<Process>().Single(p => p.Id == _schedule.Workflow.Id);
            _logger.Trace($"Executing workflow '{workflow.ProcessName}' with {relevantEntities.Count} entities ...");

            var resultList = new List<ExecuteWorkflowResponse>();
            foreach (var entity in relevantEntities)
            {
                resultList.Add(workflow.Trigger(_serviceContext, entity.Id));
            }

            _logger.Trace($"Triggered {resultList.Count} workflows!");
        }

        private (bool, List<Entity>) GetAndHandleEntityPage()
        {
            var conversionRequest = new FetchXmlToQueryExpressionRequest { FetchXml = _schedule.FetchXML };
            var conversionResponse = _serviceContext.Execute(conversionRequest) as FetchXmlToQueryExpressionResponse;

            var query = conversionResponse.Query;
            query.PageInfo.PageNumber = _scheduleRun.CurrentPage.Value;

            var retrieveMultipleRequest = new RetrieveMultipleRequest { Query = query };
            var response = _serviceContext.Execute(retrieveMultipleRequest) as RetrieveMultipleResponse;

            return (response.EntityCollection.MoreRecords, response.EntityCollection.Entities.ToList());
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
