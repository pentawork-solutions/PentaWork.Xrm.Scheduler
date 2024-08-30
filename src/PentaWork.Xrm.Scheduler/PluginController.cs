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
            var proxyProvider = organizationServiceFactory as IProxyTypesAssemblyProvider;
            if (proxyProvider != null) proxyProvider.ProxyTypesAssembly = typeof(CustomAPI).Assembly;

            var organizationService = organizationServiceFactory.CreateOrganizationService(pluginExecutionContext.UserId);
            var serviceContext = new OrganizationServiceContext(organizationService);
            var tracingService = (ITracingService)serviceProvider.GetService(typeof(ITracingService));
            var target = GetTarget(pluginExecutionContext, organizationService);

            var relevantPlugins = GetPlugins(pluginExecutionContext.InputParameters, pluginExecutionContext.PrimaryEntityName);
            var tuplesToExecute = relevantPlugins.SelectMany(r =>
            {
                var plugin = (ICrmPlugin)Activator.CreateInstance(r, new CrmServices(tracingService, pluginExecutionContext, serviceContext, organizationService, organizationServiceFactory));
                return GetTuplesToExecute(plugin, pluginExecutionContext, target.Attributes.Select(a => a.Key).ToList());
            });

            foreach (var tuple in tuplesToExecute.OrderBy(t => t.Item3.Order))
            {
                tracingService.Trace($"Executing: {tuple.Item1.GetType().Name} (Order: {tuple.Item3.Order})");

                var parameters = new List<object> { tuple.Item1.ToEntity(target) };
                var message = (MessageName)Enum.Parse(typeof(MessageName), pluginExecutionContext.MessageName);

                if (message == MessageName.Associate || message == MessageName.Disassociate)
                {
                    parameters.Add(pluginExecutionContext.InputParameters["RelatedEntities"] as EntityReferenceCollection);
                }
                else if (tuple.Item3 is EventAttribute eventAttr && (eventAttr.PreImage || eventAttr.PostImage))
                {
                    if (eventAttr.PreImage && pluginExecutionContext.PreEntityImages.ContainsKey("Image"))
                    {
                        parameters.Add(tuple.Item1.ToEntity(pluginExecutionContext.PreEntityImages["Image"]));
                    }
                    else if (eventAttr.PreImage) throw new InvalidPluginExecutionException($"Plugin '{tuple.Item1.GetType().Name}' erwartet ein Image (pre), aber es wurde keins registriert!");

                    if (eventAttr.PostImage && pluginExecutionContext.PostEntityImages.ContainsKey("Image"))
                    {
                        parameters.Add(tuple.Item1.ToEntity(pluginExecutionContext.PostEntityImages["Image"]));
                    }
                    else if (eventAttr.PostImage) throw new InvalidPluginExecutionException($"Plugin '{tuple.Item1.GetType().Name}' erwartet ein Image (post), aber es wurde keins registriert!");
                }

                try
                {
                    tuple.Item2.Invoke(tuple.Item1, parameters.ToArray());
                }
                catch (Exception ex)
                {
                    tracingService.Trace(ex.ToString());

                    // We want to throw the inner InvalidPluginException raised by the plugins
                    // NOT the TargetInvocationException raised by invoking the plugin functions
                    if (ex.InnerException != null) throw ex.InnerException;
                    else throw ex;
                }
                tracingService.Trace($"Finished: {tuple.Item1.GetType().Name}");
            }
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

        public List<Tuple<ICrmPlugin, MethodInfo, CrmEventAttribute>> GetTuplesToExecute(ICrmPlugin plugin, IPluginExecutionContext pluginExecutionContext, IList<string> changedFields)
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
                .Select(e => new Tuple<ICrmPlugin, MethodInfo, CrmEventAttribute>(plugin, pluginType.GetMethod(e.MethodName), e))
                .ToList();
        }

        public Entity GetTarget(IPluginExecutionContext pluginExecutionContext, IOrganizationService organizationService)
        {
            Entity target;

            // On Win Message, the target is not set, but the OpportunityClose containing the regarding opportunityid
            if (pluginExecutionContext.InputParameters.ContainsKey("OpportunityClose"))
            {
                var projectClose = pluginExecutionContext.InputParameters["OpportunityClose"];
                target = organizationService.Retrieve("opportunity", ((EntityReference)((Entity)projectClose).Attributes["opportunityid"]).Id, new ColumnSet(true));
            }
            else if (pluginExecutionContext.InputParameters.ContainsKey("EntityMoniker"))
            {
                var entity = pluginExecutionContext.InputParameters["EntityMoniker"] as EntityReference;
                target = organizationService.Retrieve(entity.LogicalName, entity.Id, new ColumnSet(true));
            }
            else if (pluginExecutionContext.InputParameters.ContainsKey("Target"))
            {
                if (pluginExecutionContext.InputParameters["Target"] is EntityReference entityDeleteRef)
                {
                    target = new Entity(entityDeleteRef.LogicalName, entityDeleteRef.Id);
                }
                else
                {
                    target = pluginExecutionContext.InputParameters["Target"] as Entity;
                }
            }
            else
            {
                throw new InvalidPluginExecutionException("General Error: CRM-Event not handled");
            }

            return target;
        }
    }
}
