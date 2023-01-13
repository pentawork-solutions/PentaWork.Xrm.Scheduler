using Microsoft.AspNet.OData;
using Microsoft.AspNet.OData.Routing;
using Microsoft.Xrm.Sdk;
using Microsoft.Xrm.Sdk.Client;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using NLog;
using PentaWork.Xrm.Scheduler;
using PentaWork.Xrm.Scheduler.Proxies.Entities;
using PentaWork.Xrm.SchedulerService.Contracts;
using PentaWork.Xrm.SchedulerService.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Net;
using System.Reflection;
using System.Threading.Tasks;
using System.Web.Http;
using Task = System.Threading.Tasks.Task;

namespace PentaWork.Xrm.SchedulerService.Controllers
{
    public class SchedulePluginsController : ODataController
    {
        private Dictionary<string, Task> _runningTasks = new Dictionary<string, Task>();

        private readonly SchedulerPlugin[] _plugins;
        private readonly ILogger _logger = LogManager.GetCurrentClassLogger();

        public SchedulePluginsController(SchedulerPlugin[] plugins)
        {
            _plugins = plugins;
        }

        [EnableQuery]
        public IQueryable<PluginDto> Get()
        {
            return _plugins.Select(p => new PluginDto { Id = p.Id, Name = p.Name }).AsQueryable();
        }

        [EnableQuery]
        public SingleResult<PluginDto> Get([FromODataUri] Guid key)
        {
            var result = _plugins.AsQueryable().Where(p => p.Id == key);
            return SingleResult.Create(result.Select(p => new PluginDto { Id = p.Id, Name = p.Name }));
        }

        [HttpPost]
        [ODataRoute("SchedulePlugins/ExecuteSchedule")]
        public async Task<IHttpActionResult> ExecuteSchedule([FromODataUri] string code)
        {
            var requestBody = await Request.Content.ReadAsStringAsync();
            var parameters = (JObject)JsonConvert.DeserializeObject(requestBody);

            var (isValid, message) = CheckExecuteRequest(code, parameters);
            if (!isValid) return BadRequest(message);

            var orgName = parameters["OrganizationName"].ToString();
            var entityName = parameters["PrimaryEntityName"].ToString();
            var entityId = new Guid(parameters["PrimaryEntityId"].ToString());

            var crmSystem = new CrmSystem(orgName, Assembly.GetAssembly(typeof(PentaSchedule)));
            var serviceContext = new OrganizationServiceContext(crmSystem.GetService());

            var scheduleRun = serviceContext.CreateQuery<PentaScheduleRun>().Single(s => s.Id == entityId);
            var schedule = serviceContext.CreateQuery<PentaSchedule>().Single(s => s.Id == scheduleRun.PentaSchedule.Id);

            var servicePluginRef = schedule.SchedulePlugin;
            var servicePluginType = _plugins.Single(p => p.Name == servicePluginRef.Name);
            var servicePlugin = (SchedulerPlugin)Activator.CreateInstance(servicePluginType.GetType());
            var pluginLogger = new SchedulePluginLogger(schedule.Name, scheduleRun, serviceContext);

            if (!_runningTasks.ContainsKey(servicePluginRef.Name))
            {
                var task = Task.Run(() =>
                {
                    try
                    {
                        scheduleRun.StatusReason = PentaScheduleRun.eStatusReason.InProgress_Active;
                        UpdateAndSave(serviceContext, scheduleRun);

                        // If the plugin comes with custom proxy classes, we can't use the above defined service context,
                        // because it already includes the proxy classes shipped by the scheduler dll.
                        // We pass a fresh service context with enabled proxies from the service plugin assembly.
                        var pluginCrmSystem = new CrmSystem(orgName, Assembly.GetAssembly(servicePluginType.GetType()));
                        var pluginServiceContext = new OrganizationServiceContext(pluginCrmSystem.GetService());

                        servicePlugin.Execute(pluginServiceContext, pluginLogger, schedule.SchedulePluginConfig);

                        scheduleRun.Status = PentaScheduleRun.eStatus.Inactive;
                        scheduleRun.StatusReason = PentaScheduleRun.eStatusReason.Ended_Inactive;
                        UpdateAndSave(serviceContext, scheduleRun);
                    }
                    catch (Exception ex)
                    {
                        try
                        {
                            scheduleRun.Status = PentaScheduleRun.eStatus.Inactive;
                            scheduleRun.StatusReason = PentaScheduleRun.eStatusReason.Error_Inactive;
                            UpdateAndSave(serviceContext, scheduleRun);

                            pluginLogger.Error(ex.ToString());
                        }
                        catch (Exception e)
                        {
                            _logger.Error(e.ToString());
                        }
                    }
                    finally
                    {
                        _runningTasks.Remove(servicePluginRef.Name);
                    }
                });
                _runningTasks.Add(servicePluginRef.Name, task);
            }
            else
            {
                pluginLogger.Info($"Task for Plugin '{servicePluginRef.Name}' already running ...");
            }
            return StatusCode(HttpStatusCode.OK);
        }

        private (bool, string) CheckExecuteRequest(string code, JObject parameters)
        {
            var isValid = true;
            var message = string.Empty;

            if (!ModelState.IsValid || !parameters.ContainsKey("OrganizationName") || !parameters.ContainsKey("PrimaryEntityName") || !parameters.ContainsKey("PrimaryEntityId"))
            {
                message = "Request for 'ExecuteSchedule' is invalid!";
                message += string.Join(Environment.NewLine, ModelState.SelectMany(m => m.Value.Errors.Select(e => e.Exception?.Message))) + Environment.NewLine;
                message += $"OrganizationName: {parameters.ContainsKey("OrganizationName")}{Environment.NewLine}";
                message += $"PrimaryEntityName: {parameters.ContainsKey("PrimaryEntityName")}{Environment.NewLine}";
                message += $"PrimaryEntityId: {parameters.ContainsKey("PrimaryEntityId")}{Environment.NewLine}";

                _logger.Warn(message);
                isValid = false;
            }

            if (code != ConfigurationManager.AppSettings["ApiKey"])
            {
                message = "Invalid api key!";
                _logger.Warn(message);
                isValid = false;
            }

            var orgName = parameters["OrganizationName"].ToString();
            var entityName = parameters["PrimaryEntityName"].ToString();

            if (!CrmSystem.SystemAvailable(orgName))
            {
                message = $"Org '{orgName}' not configured!";
                _logger.Warn(message);
                isValid = false;
            }

            if (entityName != PentaScheduleRun.LogicalName)
            {
                message = $"PrimaryEntityName is not {PentaScheduleRun.LogicalName}! ({entityName})";
                _logger.Warn(message);
                isValid = false;
            }

            return (isValid, message);
        }

        private void UpdateAndSave(OrganizationServiceContext serviceContext, Entity entity)
        {
            if (!serviceContext.IsAttached(entity))
            {
                serviceContext.Attach(entity);
            }
            serviceContext.UpdateObject(entity);
            serviceContext.SaveChanges();
        }
    }
}
