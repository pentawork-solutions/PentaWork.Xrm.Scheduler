using FakeXrmEasy;
using Microsoft.Crm.Sdk.Messages;
using Microsoft.Xrm.Sdk;
using PentaWork.Xrm.Scheduler.Plugins;
using PentaWork.Xrm.Scheduler.Proxies.Entities;
using PentaWork.Xrm.Scheduler.Proxies.Extensions;
using PentaWork.Xrm.Scheduler.Tests.Fake;
using System;
using System.Activities;
using System.Collections.Generic;

namespace PentaWork.Xrm.Scheduler.Tests
{
    internal static class FakeContext
    {
        public static XrmFakedContext ExecutePlugin<T, U>(MessageName message, Stage stage, PluginMode mode,
            Entity target, Entity preTarget = null, List<Entity> knownEntities = null, List<Tuple<string, XrmFakedRelationship>> knownRelationships = null, Guid? initiatingUserId = null
        )
            where T : IPlugin, new()
            where U : new()
        {
            var fakedContext = InitContext(target.GetType(), knownEntities, knownRelationships);
            var plugCtx = InitPluginContext<U>(target, preTarget, message, stage, mode, fakedContext);
            plugCtx.InitiatingUserId = initiatingUserId ?? plugCtx.InitiatingUserId;

            fakedContext.ExecutePluginWith<T>(plugCtx);

            return fakedContext;
        }

        public static XrmFakedContext ExecuteCodeActivity<T>(
            Entity primaryEntity,
            List<Entity> knownEntities = null,
            List<Tuple<string, XrmFakedRelationship>> knownRelationships = null,
            Dictionary<string, object> inputs = null,
            Guid? initiatingUserId = null
        )
            where T : CodeActivity, new()
        {
            var fakedContext = InitContext(primaryEntity.GetType(), knownEntities, knownRelationships);

            var workflowCtx = fakedContext.GetDefaultWorkflowContext();
            workflowCtx.PrimaryEntityId = primaryEntity.Id;
            workflowCtx.PrimaryEntityName = primaryEntity.LogicalName;
            workflowCtx.InitiatingUserId = initiatingUserId ?? workflowCtx.InitiatingUserId;

            fakedContext.ExecuteCodeActivity<T>(workflowCtx, inputs);
            return fakedContext;
        }


        private static XrmFakedContext InitContext(
            Type entityType,
            List<Entity> knownEntities = null,
            List<Tuple<string, XrmFakedRelationship>> knownRelationships = null)
        {
            var fakedContext = new XrmFakedContext();
            fakedContext.ProxyTypesAssembly = entityType.Assembly;

            if (knownRelationships != null)
            {
                foreach (var relationship in knownRelationships)
                {
                    fakedContext.AddRelationship(relationship.Item1, relationship.Item2);
                }
            }
            knownEntities = knownEntities ?? new List<Entity>();

            fakedContext.Initialize(knownEntities);
            AddWorkflowRequestMock(fakedContext);
            AddOrganizationRequestMock(fakedContext);

            return fakedContext;
        }

        private static XrmFakedPluginExecutionContext InitPluginContext<T>(
            Entity target, Entity preTarget, MessageName message, Stage stage,
            PluginMode mode, XrmFakedContext fakedContext) where T : new()
        {
            var inputParameters = new ParameterCollection();
            inputParameters.Add("Target", target);
            inputParameters.Add("TestPlugin", typeof(T));

            var plugCtx = fakedContext.GetDefaultPluginContext();
            plugCtx.MessageName = message.GetEnumDescription();
            plugCtx.Stage = (int)stage;
            plugCtx.Mode = (int)mode;
            plugCtx.InputParameters = inputParameters;
            if (preTarget != null) plugCtx.PreEntityImages.Add("PreImage", preTarget);

            return plugCtx;
        }

        private static void AddWorkflowRequestMock(XrmFakedContext fakedContext)
        {
            fakedContext.AddExecutionMock<ExecuteWorkflowRequest>(request => 
            {
                if (!fakedContext.Data.ContainsKey(SystemJob.LogicalName))
                {
                    fakedContext.Data.Add(SystemJob.LogicalName, new Dictionary<Guid, Entity>());
                }

                var systemJob = FakeSystemJob.Create();
                systemJob.Message = request.RequestName;

                fakedContext.Data[SystemJob.LogicalName].Add(systemJob.Id, systemJob);

                return new ExecuteWorkflowResponse(); 
            });
        }

        private static void AddOrganizationRequestMock(XrmFakedContext fakedContext)
        {
            fakedContext.AddExecutionMock<OrganizationRequest>(request =>
            {
                if (!fakedContext.Data.ContainsKey(SystemJob.LogicalName))
                {
                    fakedContext.Data.Add(SystemJob.LogicalName, new Dictionary<Guid, Entity>());
                }

                var systemJob = FakeSystemJob.Create();
                systemJob.Message = request.RequestName;

                fakedContext.Data[SystemJob.LogicalName].Add(systemJob.Id, systemJob);

                return new OrganizationResponse();
            });
        }
    }
}
