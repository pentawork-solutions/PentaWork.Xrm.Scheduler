using Microsoft.Crm.Sdk.Messages;
using Microsoft.Xrm.Sdk;
using Microsoft.Xrm.Sdk.Messages;
using Microsoft.Xrm.Sdk.Query;
using PentaWork.Xrm.Scheduler.Proxies.Entities;
using System;
using System.Linq;

namespace PentaWork.Xrm.Scheduler.Plugins.PentaScheduleRuns
{
    [Event(Stage.PreOperation, MessageName.Create, PluginMode.Synchronous, -1, nameof(OnCreate))]
    public class SetPageInfoOnCreation : CrmPlugin<PentaScheduleRun>
    {
        public void OnCreate(PentaScheduleRun target, PentaScheduleRun preTarget)
        {
            var schedule = Context.CreateQuery<PentaSchedule>().Single(p => p.Id == target.PentaSchedule.Id);

            if(schedule.ScheduleType == PentaSchedule.egScheduleType.GlobalAction || schedule.ScheduleType == PentaSchedule.egScheduleType.SchedulePlugin)
            {
                target.CurrentPage = 0;
                target.TotalPages = 0;
                target.PageSize = 0;
            }
            else
            {
                try
                {
                    // The query option ReturnTotalRecordCount only returns a maximum count of 5000
                    // Therefore the page count will be wrong and we have to do a recursive retrieve
                    // to get the actual page count

                    var conversionRequest = new FetchXmlToQueryExpressionRequest { FetchXml = schedule.FetchXML };
                    var conversionResponse = Context.Execute(conversionRequest) as FetchXmlToQueryExpressionResponse;

                    conversionResponse.Query.ColumnSet = new ColumnSet();
                    conversionResponse.Query.PageInfo.PageNumber = 0;

                    var pageCount = 0;
                    var moreRecords = true;
                    var retrieveMultipleRequest = new RetrieveMultipleRequest { Query = conversionResponse.Query };

                    while(moreRecords)
                    {
                        var query = (QueryExpression) retrieveMultipleRequest.Query;
                        query.PageInfo.PageNumber++;
                        pageCount++;

                        var response = Context.Execute(retrieveMultipleRequest) as RetrieveMultipleResponse;
                        moreRecords = response.EntityCollection.MoreRecords;
                    }

                    target.CurrentPage = 1;
                    target.TotalPages = pageCount;
                    target.PageSize = conversionResponse.Query.PageInfo.Count;
                }
                catch (Exception ex)
                {
                    throw new InvalidPluginExecutionException("Error during Fetch XML Execution!", ex);
                }
            }
        }
    }
}
