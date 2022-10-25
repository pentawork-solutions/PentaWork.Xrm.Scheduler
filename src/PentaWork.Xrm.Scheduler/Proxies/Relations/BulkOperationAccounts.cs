using System;
using Microsoft.Xrm.Sdk; 
using Microsoft.Xrm.Sdk.Client;

namespace PentaWork.Xrm.Scheduler.Proxies.Relations
{
	/// <summary> 
	/// BulkOperation_Accounts 
	/// </summary>
	[Relation]
	[EntityLogicalName("BulkOperation_Accounts")]
	public sealed class BulkOperationAccounts : Entity
	{	
		public const string SchemaName = "BulkOperation_Accounts";
	
		public BulkOperationAccounts() : base("BulkOperation_Accounts") { }

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

