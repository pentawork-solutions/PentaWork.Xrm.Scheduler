using Autofac;
using Autofac.Integration.WebApi;
using Microsoft.AspNet.OData.Builder;
using Microsoft.AspNet.OData.Extensions;
using NLog;
using PentaWork.Xrm.SchedulerService.Contracts;
using PentaWork.Xrm.SchedulerService.Models;
using System;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Web.Hosting;
using System.Web.Http;

namespace PentaWork.Xrm.SchedulerService
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            config.EnableSystemDiagnosticsTracing();
            config.MapHttpAttributeRoutes();
            config.Select().Filter().OrderBy().MaxTop(null).Count();

            var builder = new ODataConventionModelBuilder();
            builder.Action("DownloadLogs");

            var schedulePlugins = builder.EntitySet<PluginDto>("SchedulePlugins");
            var executeAction = schedulePlugins.EntityType.Collection.Action("ExecuteSchedule");
            executeAction.Parameter<string>("code");

            var servicePlugins = builder.EntitySet<PluginDto>("ServicePlugins");
            executeAction = servicePlugins.EntityType.Collection.Action("ExecutePlugin");
            executeAction.Parameter<string>("code");

            config.MapODataServiceRoute(
                routeName: "ODataRoute",
                routePrefix: null,
                model: builder.GetEdmModel());

            RegisterAutofac(config);
        }

        private static void RegisterAutofac(HttpConfiguration config)
        {
            var containerBuilder = new ContainerBuilder();
            containerBuilder.RegisterApiControllers(Assembly.GetExecutingAssembly());

            var logger = LogManager.GetCurrentClassLogger();
            var possiblePluginPathes = Directory.EnumerateFiles(HostingEnvironment.MapPath("~\\bin\\plugins"), "*.SchedulerServicePlugin.dll", SearchOption.AllDirectories);
            foreach (var path in possiblePluginPathes)
            {
                logger.Info($"Scanning {path} ...");
                try
                {
                    var possiblePlugin = Assembly.LoadFrom(path);
                    var schedulerPlugins = possiblePlugin.GetTypes().Where(t => typeof(SchedulerPlugin).IsAssignableFrom(t)).ToList();
                    if (schedulerPlugins.Count > 0)
                    {
                        logger.Info($"Found scheduler plugins: {string.Join(", ", schedulerPlugins.Select(p => p.Name).ToArray())} ...");
                        schedulerPlugins.ForEach(t => containerBuilder.RegisterType(t).As<SchedulerPlugin>());
                    }

                    var servicePlugins = possiblePlugin.GetTypes().Where(t => typeof(ServicePlugin).IsAssignableFrom(t)).ToList();
                    if (servicePlugins.Count > 0)
                    {
                        logger.Info($"Found service plugins: {string.Join(", ", servicePlugins.Select(p => p.Name).ToArray())} ...");
                        servicePlugins.ForEach(t => containerBuilder.RegisterType(t).As<ServicePlugin>());
                    }
                }
                catch (ReflectionTypeLoadException ex)
                {
                    logger.Error(ex.ToString());
                    var Exceptions = ex.LoaderExceptions;
                    foreach (Exception curEx in Exceptions)
                    {
                        logger.Error(curEx.Message);
                        logger.Error(curEx.GetType().ToString());
                    }
                }                    
            }
            config.DependencyResolver = new AutofacWebApiDependencyResolver(containerBuilder.Build());
        }
    }
}
