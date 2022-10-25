using Microsoft.Xrm.Sdk;
using Microsoft.Xrm.Sdk.Client;
using Microsoft.Xrm.Sdk.Query;
using PentaWork.Xrm.Scheduler.Plugins;
using PentaWork.Xrm.Scheduler.Proxies.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace PentaWork.Xrm.Scheduler
{
    public class PluginController : IPlugin
    {
        public void Execute(IServiceProvider serviceProvider)
        {
            if (serviceProvider == null) throw new ArgumentNullException(nameof(serviceProvider));

            var pluginExecutionContext = (IPluginExecutionContext)serviceProvider.GetService(typeof(IPluginExecutionContext));
            var organizationServiceFactory = (IOrganizationServiceFactory)serviceProvider.GetService(typeof(IOrganizationServiceFactory));
            var organizationService = organizationServiceFactory.CreateOrganizationService(pluginExecutionContext.UserId);
            var serviceContext = new OrganizationServiceContext(organizationService);
            var tracingService = (ITracingService)serviceProvider.GetService(typeof(ITracingService));
            var targetAndPreEntity = GetTargetAndPreTarget(pluginExecutionContext, organizationService);

            var relevantPlugins = GetPlugins(pluginExecutionContext.InputParameters, pluginExecutionContext.PrimaryEntityName);
            var tuplesToExecute = relevantPlugins.SelectMany(r =>
            {
                var plugin = (ICrmPlugin)Activator.CreateInstance(r);
                return GetTuplesToExecute(plugin, pluginExecutionContext, targetAndPreEntity.Item1.Attributes.Select(a => a.Key).ToList());
            });

            foreach (var tuple in tuplesToExecute)
            {
                tracingService.Trace($"Executing: {tuple.Item1.GetType().Name}");
                tuple.Item1.Tracer = tracingService;
                tuple.Item1.PluginContext = pluginExecutionContext;
                tuple.Item1.Context = serviceContext;

                var parameters = new object[] { tuple.Item1.ToEntity(targetAndPreEntity.Item1), null };

                var message = (MessageName)Enum.Parse(typeof(MessageName), pluginExecutionContext.MessageName);
                if (message == MessageName.Associate || message == MessageName.Disassociate)
                {
                    parameters[1] = pluginExecutionContext.InputParameters["RelatedEntities"] as EntityReferenceCollection;
                }
                else
                {
                    parameters[1] = tuple.Item1.ToEntity(targetAndPreEntity.Item2);
                }

                tuple.Item2.Invoke(tuple.Item1, parameters);
                tracingService.Trace($"Finished: {tuple.Item1.GetType().Name}");
            }
        }

        public (Entity, Entity) GetTargetAndPreTarget(IPluginExecutionContext pluginExecutionContext, IOrganizationService organizationService)
        {
            Entity target = null;
            Entity preTarget = null;

            // On Win Message, the target is not set, but the OpportunityClose containing the regarding opportunityid
            if (pluginExecutionContext.InputParameters.ContainsKey("OpportunityClose"))
            {
                var oppClose = pluginExecutionContext.InputParameters["OpportunityClose"];
                target = organizationService.Retrieve(Opportunity.LogicalName, ((EntityReference)((Entity)oppClose).Attributes["opportunityid"]).Id, new ColumnSet(true));
            }
            else if (pluginExecutionContext.InputParameters.ContainsKey("EntityMoniker"))
            {
                var entity = pluginExecutionContext.InputParameters["EntityMoniker"] as EntityReference;
                target = organizationService.Retrieve(entity.LogicalName, entity.Id, new ColumnSet(true));
            }
            else if (pluginExecutionContext.InputParameters.ContainsKey("Target"))
            {
                if (pluginExecutionContext.InputParameters["Target"] is EntityReference entityRef)
                {
                    target = organizationService.Retrieve(entityRef.LogicalName, entityRef.Id, new ColumnSet(true));
                }
                else
                {
                    target = pluginExecutionContext.InputParameters["Target"] as Entity;
                }
            }
            else
            {
                throw new InvalidPluginExecutionException("General-Error: CRM-Event not handled");
            }

            if (pluginExecutionContext.PreEntityImages.ContainsKey("PreImage"))
            {
                preTarget = pluginExecutionContext.PreEntityImages["PreImage"];
            }

            return (target, preTarget);
        }

        public List<Type> GetPlugins(ParameterCollection inputParamters, string logicalName)
        {
            var possiblePlugins = GetType().Assembly.GetTypes().Where(t => t.GetInterface("ICrmPlugin") != null).ToList();
            var pluginList = possiblePlugins
                .Where(p =>
                        !p.IsAbstract
                        && ((p.BaseType.GenericTypeArguments.FirstOrDefault()?.BaseType == typeof(Entity) && ((Entity)Activator.CreateInstance(p.BaseType.GenericTypeArguments.First())).LogicalName == logicalName)
                            || logicalName.Equals("none", StringComparison.OrdinalIgnoreCase))
                ).ToList();

            if (inputParamters.ContainsKey("TestPlugin"))
            {
                pluginList = new List<Type> { (Type)inputParamters["TestPlugin"] };
            }

            return pluginList;
        }

        public List<Tuple<ICrmPlugin, MethodInfo>> GetTuplesToExecute(ICrmPlugin plugin, IPluginExecutionContext pluginExecutionContext, IList<string> changedFields)
        {
            var relevantEvents = new List<CrmEventAttribute>();
            var depth = pluginExecutionContext.Depth;
            var stage = (Stage)pluginExecutionContext.Stage;
            var message = (MessageName)Enum.Parse(typeof(MessageName), pluginExecutionContext.MessageName);
            var mode = (PluginMode)pluginExecutionContext.Mode;

            var pluginType = plugin.GetType();
            var eventAttributeArray = pluginType.GetCustomAttributes<CrmEventAttribute>();
            relevantEvents.AddRange(eventAttributeArray.Where(
                e => e.Stage == stage &&
                     e.MessageName == message &&
                     e.PluginMode == mode &&
                     (depth <= e.ExecutionDepth || e.ExecutionDepth == -1)
            ).ToList());

            if (message == MessageName.Associate || message == MessageName.Disassociate)
            {
                relevantEvents = relevantEvents
                    .Where(e => e is RelateEventAttribute relateEvent && pluginExecutionContext.InputParameters["Relationship"].ToString().StartsWith(relateEvent.SchemaName + "."))
                    .ToList();
            }
            else
            {
                relevantEvents = relevantEvents
                    .Where(e => e is EventAttribute eventAttr && (!eventAttr.EventFieldNames.Any() || eventAttr.EventFieldNames.Any(f => changedFields.Any(c => c == f))))
                    .ToList();
            }

            return relevantEvents
                .Select(e => new Tuple<ICrmPlugin, MethodInfo>(plugin, pluginType.GetMethod(e.MethodName)))
                .ToList();
        }
    }
}
