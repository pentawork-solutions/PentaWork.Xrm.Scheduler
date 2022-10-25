using Microsoft.Xrm.Sdk;
using Microsoft.Xrm.Sdk.Client;
using Microsoft.Xrm.Sdk.Query;
using Microsoft.Xrm.Tooling.Connector;
using NLog;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.Common;
using System.Linq;
using System.Reflection;

namespace PentaWork.Xrm.SchedulerService.Models
{
    public class CrmSystem
    {
        public CrmSystem(string crmSystemName, Assembly proxyTypes, TimeSpan? timeout = null)
        {
            CrmSystemName = crmSystemName;

            // Its not possible to use the CrmServiceClient directly with connection strings at this point.
            // It seems like the registration of the proxy types works a bit different.
            // To get the proxy classes of plugins working we have to use a service proxy and register the types at it.
            // As soon as we try to use the service client and register the proxy types on it, it does not work for plugin proxy types.

            var dbConnectionStringBuilder = new DbConnectionStringBuilder();
            dbConnectionStringBuilder.ConnectionString = ConfigurationManager.ConnectionStrings[crmSystemName].ConnectionString;
            var uri = new Uri($"{(string)dbConnectionStringBuilder["Url"]}/XRMServices/2011/Organization.svc");

            var serviceProxy = new OrganizationServiceProxy(uri, null, null, null);
            serviceProxy.Timeout = timeout ?? new TimeSpan(0, 30, 0);
            serviceProxy.EnableProxyTypes(proxyTypes);

            Client = new CrmServiceClient(serviceProxy);

            if (!string.IsNullOrEmpty(Client.LastCrmError)) LogManager.GetCurrentClassLogger().Error(Client.LastCrmError);
        }

        public IOrganizationService GetService()
        {
            return Client.OrganizationServiceProxy;
        }

        /// <summary>
        /// Retrieves all entities by given conditions.
        /// </summary>
        /// <param name="logicalName">The logical name of the entity type to retrieve entities from.</param>
        /// <param name="conditions">The conditions to test.</param>
        /// <returns>A list of all matching entities.</returns>
        public IEnumerable<Entity> GetAllByConditions(string logicalName, params ConditionExpression[] conditions)
        {
            var query = new QueryExpression(logicalName);
            conditions.ToList().ForEach(c => query.Criteria.AddCondition(c));
            query.ColumnSet = new ColumnSet(true);

            return GetService().RetrieveMultiple(query).Entities.ToList();
        }

        public static bool SystemAvailable(string system)
        {
            var availableConnections = (ConnectionStringsSection)ConfigurationManager.GetSection("connectionStrings");
            var availableSystems = new List<string>();
            foreach (ConnectionStringSettings connection in availableConnections.ConnectionStrings)
            {
                if (connection.ProviderName.ToUpper() == "CRM")
                {
                    availableSystems.Add(connection.Name);
                }
            }
            return availableSystems.Contains(system);
        }

        public bool HasErrors() => !string.IsNullOrEmpty(Client.LastCrmError);
        public string CrmSystemName { get; }
        public CrmServiceClient Client { get; }
    }
}