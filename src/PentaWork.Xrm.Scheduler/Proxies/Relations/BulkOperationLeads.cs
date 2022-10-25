using System;
using Microsoft.Xrm.Sdk; 
using Microsoft.Xrm.Sdk.Client;

namespace PentaWork.Xrm.Scheduler.Proxies.Relations
{
	/// <summary> 
	/// BulkOperation_Leads 
	/// </summary>
	[Relation]
	[EntityLogicalName("BulkOperation_Leads")]
	public sealed class BulkOperationLeads : Entity
	{	
		public const string SchemaName = "BulkOperation_Leads";
	
		public BulkOperationLeads() : base("BulkOperation_Leads") { }

		[AttributeLogicalName("bulkoperationid")]
		public Guid BulkoperationId
		{	
			get { return GetAttributeValue<Guid>("bulkoperationid"); }
			set { SetAttributeValue("bulkoperationid", value); }
		}

		[AttributeLogicalName("regardingobjectid")]
		public Guid RegardingobjectId
		{	
			get { return GetAttributeValue<Guid>("regardingobjectid"); }
			set { SetAttributeValue("regardingobjectid", value); }
		}
	}
}

