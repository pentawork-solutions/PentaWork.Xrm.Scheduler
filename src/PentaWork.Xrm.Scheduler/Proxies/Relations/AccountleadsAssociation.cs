using System;
using Microsoft.Xrm.Sdk; 
using Microsoft.Xrm.Sdk.Client;

namespace PentaWork.Xrm.Scheduler.Proxies.Relations
{
	/// <summary> 
	/// accountleads_association 
	/// </summary>
	[Relation]
	[EntityLogicalName("accountleads_association")]
	public sealed class AccountleadsAssociation : Entity
	{	
		public const string SchemaName = "accountleads_association";
	
		public AccountleadsAssociation() : base("accountleads_association") { }

		[AttributeLogicalName("leadid")]
		public Guid LeadId
		{	
			get { return GetAttributeValue<Guid>("leadid"); }
			set { SetAttributeValue("leadid", value); }
		}

		[AttributeLogicalName("accountid")]
		public Guid AccountId
		{	
			get { return GetAttributeValue<Guid>("accountid"); }
			set { SetAttributeValue("accountid", value); }
		}
	}
}

