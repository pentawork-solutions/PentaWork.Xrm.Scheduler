using System;
using Microsoft.Xrm.Sdk; 
using Microsoft.Xrm.Sdk.Client;

namespace PentaWork.Xrm.Scheduler.Proxies.Relations
{
	/// <summary> 
	/// BulkOperation_Contacts 
	/// </summary>
	[Relation]
	[EntityLogicalName("BulkOperation_Contacts")]
	public sealed class BulkOperationContacts : Entity
	{	
		public const string SchemaName = "BulkOperation_Contacts";
	
		public BulkOperationContacts() : base("BulkOperation_Contacts") { }

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

