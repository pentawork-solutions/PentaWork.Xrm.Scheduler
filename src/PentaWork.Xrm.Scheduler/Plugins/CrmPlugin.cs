using Microsoft.Xrm.Sdk;
using Microsoft.Xrm.Sdk.Client;

namespace PentaWork.Xrm.Scheduler.Plugins
{
    public interface ICrmPlugin
    {
        Entity ToEntity(Entity entity);

        ITracingService Tracer { get; set; }
        IPluginExecutionContext PluginContext { get; set; }
        OrganizationServiceContext Context { get; set; }
    }

    public abstract class CrmPlugin : ICrmPlugin
    {
        public Entity ToEntity(Entity entity)
        {
            return entity;
        }

        public ITracingService Tracer { get; set; }
        public IPluginExecutionContext PluginContext { get; set; }
        public OrganizationServiceContext Context { get; set; }
    }

    public abstract class CrmPlugin<T> : ICrmPlugin where T : Entity, new()
    {
        public Entity ToEntity(Entity entity)
        {
            return entity?.ToEntity<T>();
        }

        public ITracingService Tracer { get; set; }
        public IPluginExecutionContext PluginContext { get; set; }
        public OrganizationServiceContext Context { get; set; }
    }
}
