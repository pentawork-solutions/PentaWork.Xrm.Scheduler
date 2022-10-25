using System;
using Microsoft.Xrm.Sdk; 
using Microsoft.Xrm.Sdk.Client;

namespace PentaWork.Xrm.Scheduler.Proxies.Relations
{
	/// <summary> 
	/// contactleads_association 
	/// </summary>
	[Relation]
	[EntityLogicalName("contactleads_association")]
	public sealed class ContactleadsAssociation : Entity
	{	
		public const string SchemaName = "contactleads_association";
	
		public ContactleadsAssociation() : base("contactleads_association") { }

		[AttributeLogicalName("contactid")]
		public Guid ContactId
		{	
			get { return GetAttributeValue<Guid>("contactid"); }
			set { SetAttributeValue("contactid", value); }
		}

		[AttributeLogicalName("leadid")]
		public Guid LeadId
		{	
			get { return GetAttributeValue<Guid>("leadid"); }
			set { SetAttributeValue("leadid", value); }
		}
	}
}

