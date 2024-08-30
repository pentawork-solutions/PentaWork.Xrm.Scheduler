using Microsoft.Xrm.Sdk;
using Microsoft.Xrm.Sdk.Client;

namespace PentaWork.Xrm.Scheduler.Plugins
{
    public interface ICrmPlugin
    {
        Entity ToEntity(Entity entity);

        ITracingService Tracer { get; set; }
        IPluginExecutionContext PluginContext { get; set; }
    }

    public abstract class CrmPlugin<T> : ICrmPlugin where T : Entity, new()
    {
        public CrmPlugin(CrmServices services)
        {
            Tracer = services.Tracer;
            PluginContext = services.PluginContext;
        }

        public Entity ToEntity(Entity entity)
        {
            return entity?.ToEntity<T>();
        }

        public ITracingService Tracer { get; set; }
        public IPluginExecutionContext PluginContext { get; set; }
    }

    public class CrmServices
    {
        public CrmServices(ITracingService tracer, IPluginExecutionContext pluginContext, OrganizationServiceContext context, IOrganizationService service, IOrganizationServiceFactory organizationServiceFactory)
        {
            Tracer = tracer;
            PluginContext = pluginContext;
            Context = context;
            Service = service;
            OrganizationServiceFactory = organizationServiceFactory;
        }

        public ITracingService Tracer { get; set; }
        public IPluginExecutionContext PluginContext { get; set; }
        public OrganizationServiceContext Context { get; set; }
        public IOrganizationService Service { get; set; }
        public IOrganizationServiceFactory OrganizationServiceFactory { get; set; }
    }
}
