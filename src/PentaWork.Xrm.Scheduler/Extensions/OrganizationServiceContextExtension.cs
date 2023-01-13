using Microsoft.Crm.Sdk.Messages;
using Microsoft.Xrm.Sdk;
using Microsoft.Xrm.Sdk.Client;
using Microsoft.Xrm.Sdk.Messages;
using Microsoft.Xrm.Sdk.Query;
using System.Collections.Generic;

namespace PentaWork.Xrm.Scheduler.Extensions
{
    internal static class OrganizationServiceContextExtension
    {
        public static List<Entity> ExecuteFetchXml(this OrganizationServiceContext context, string fetchXml)
        {
            var conversionRequest = new FetchXmlToQueryExpressionRequest { FetchXml = fetchXml };
            var conversionResponse = context.Execute(conversionRequest) as FetchXmlToQueryExpressionResponse;
            return context.ExecuteQuery(conversionResponse.Query);
        }

        public static List<Entity> ExecuteQuery(this OrganizationServiceContext context, QueryExpression query, int page = 1, int count = 2500, bool recursive = true)
        {
            var entities = new List<Entity>();
            if (query.PageInfo.Count == 0 && query.PageInfo.PageNumber == 0)
            {
                query.PageInfo = new PagingInfo { Count = 2500, PageNumber = 1 };
            }

            var retrieveMultipleRequest = new RetrieveMultipleRequest { Query = query };
            var response = context.Execute(retrieveMultipleRequest) as RetrieveMultipleResponse;
            entities.AddRange(response.EntityCollection.Entities);

            if(response.EntityCollection.MoreRecords && recursive)
            {
                query.PageInfo.PageNumber++;
                entities.AddRange(context.ExecuteQuery(query));
            }
            return entities;
        }

        public static void AttachUpdate(this OrganizationServiceContext context, Entity entity)
        {
            if (!context.IsAttached(entity))
            {
                context.Attach(entity);
            }
            context.UpdateObject(entity);
        }
    }
}
