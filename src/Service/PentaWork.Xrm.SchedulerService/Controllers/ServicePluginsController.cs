using Microsoft.AspNet.OData;
using Microsoft.AspNet.OData.Routing;
using Microsoft.Xrm.Sdk.Client;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using NLog;
using PentaWork.Xrm.SchedulerService.Contracts;
using PentaWork.Xrm.SchedulerService.Models;
using System;
using System.Configuration;
using System.Linq;
using System.Net;
using System.Reflection;
using System.Threading.Tasks;
using System.Web.Http;

namespace PentaWork.Xrm.SchedulerService.Controllers
{
    public class ServicePluginsController : ODataController
    {
        private readonly ServicePlugin[] _servicePlugins;
        private readonly ILogger _logger = LogManager.GetCurrentClassLogger();

        public ServicePluginsController(ServicePlugin[] servicePlugins)
        {
            _servicePlugins = servicePlugins;
        }

        [EnableQuery]
        public IQueryable<PluginDto> Get()
        {
            return _servicePlugins.Select(p => new PluginDto { Id = p.Id, Name = p.Name }).AsQueryable();
        }

        [EnableQuery]
        public SingleResult<PluginDto> Get([FromODataUri] Guid key)
        {
            var result = _servicePlugins.AsQueryable().Where(p => p.Id == key);
            return SingleResult.Create(result.Select(p => new PluginDto { Id = p.Id, Name = p.Name }));
        }

        [HttpPost]
        [ODataRoute("ServicePlugins/ExecutePlugin")]
        public async Task<IHttpActionResult> ExecutePlugin([FromODataUri] string code)
        {
            var requestBody = await Request.Content.ReadAsStringAsync();
            var parameters = (JObject)JsonConvert.DeserializeObject(requestBody);

            var (isValid, message) = CheckRequest(code, parameters);
            if (!isValid) return BadRequest(message);

            var orgName = parameters["OrganizationName"].ToString();
            var entityName = parameters["PrimaryEntityName"].ToString();
            var entityId = new Guid(parameters["PrimaryEntityId"].ToString());
            var initiatingUserId = new Guid(parameters["InitiatingUserId"].ToString());
            var pluginName = GetInputParameter(parameters, "ServicePluginName").ToString();
            var executeAsync = (bool)GetInputParameter(parameters, "ExecuteAsync");

            var servicePluginType = _servicePlugins.Single(p => p.Name == pluginName);
            var servicePlugin = (ServicePlugin)Activator.CreateInstance(servicePluginType.GetType());

            var pluginCrmSystem = new CrmSystem(orgName, Assembly.GetAssembly(servicePluginType.GetType()));
            var pluginServiceContext = new OrganizationServiceContext(pluginCrmSystem.GetService());

            if(executeAsync)
            {
                _logger.Info($"Executing '{pluginName}' async ...");
                Task.Run(() => servicePlugin.Execute(pluginServiceContext, new ServicePluginContext { EntityId = entityId, EntityName = entityName, InitiatingUserId = initiatingUserId }));
            }
            else
            {
                servicePlugin.Execute(pluginServiceContext, new ServicePluginContext { EntityId = entityId, EntityName = entityName, InitiatingUserId = initiatingUserId });
            }

            return StatusCode(HttpStatusCode.OK);
        }

        private (bool, string) CheckRequest(string code, JObject parameters)
        {
            var isValid = true;
            var message = string.Empty;
            var pluginName = GetInputParameter(parameters, "ServicePluginName").ToString();

            if (!ModelState.IsValid || !parameters.ContainsKey("OrganizationName") || !parameters.ContainsKey("PrimaryEntityName")
                || !parameters.ContainsKey("PrimaryEntityId") || !parameters.ContainsKey("InitiatingUserId") 
                || !parameters.ContainsKey("InputParameters") || string.IsNullOrEmpty(pluginName))
            {
                message = "Request for 'ExecutePlugin' is invalid!";
                message += string.Join(Environment.NewLine, ModelState.SelectMany(m => m.Value.Errors.Select(e => e.Exception?.Message))) + Environment.NewLine;
                message += $"OrganizationName: {parameters.ContainsKey("OrganizationName")}{Environment.NewLine}";
                message += $"PrimaryEntityName: {parameters.ContainsKey("PrimaryEntityName")}{Environment.NewLine}";
                message += $"PrimaryEntityId: {parameters.ContainsKey("PrimaryEntityId")}{Environment.NewLine}";
                message += $"InitiatingUserId: {parameters.ContainsKey("InitiatingUserId")}{Environment.NewLine}";
                message += $"InputParameters: {parameters.ContainsKey("InputParameters")}{Environment.NewLine}";
                message += $"ServicePluginName: {string.IsNullOrEmpty(pluginName)}{Environment.NewLine}";
                message += $"ExecuteAsync: {(bool) GetInputParameter(parameters, "ExecuteAsync")}{Environment.NewLine}";

                _logger.Error(message);
                isValid = false;
            }

            if (code != ConfigurationManager.AppSettings["ApiKey"])
            {
                message = "Invalid api key!";
                _logger.Error(message);
                isValid = false;
            }

            var orgName = parameters["OrganizationName"].ToString();
            if (!CrmSystem.SystemAvailable(orgName))
            {
                message = $"Org '{orgName}' not configured!";
                _logger.Error(message);
                isValid = false;
            }

            return (isValid, message);
        }

        private JToken GetInputParameter(JObject parameters, string key)
        {
            JToken value = null;
            if(((JArray)parameters["InputParameters"]).Children<JObject>().Any(i => i["key"].ToString() == key))
            {
                value = ((JArray)parameters["InputParameters"]).Children<JObject>().Single(i => i["key"].ToString() == key)["value"];
            }
            return value;
        }
    }
}
