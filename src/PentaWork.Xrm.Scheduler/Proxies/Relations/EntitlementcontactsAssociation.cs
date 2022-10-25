using System;
using Microsoft.Xrm.Sdk; 
using Microsoft.Xrm.Sdk.Client;

namespace PentaWork.Xrm.Scheduler.Proxies.Relations
{
	/// <summary> 
	/// entitlementcontacts_association 
	/// </summary>
	[Relation]
	[EntityLogicalName("entitlementcontacts_association")]
	public sealed class EntitlementcontactsAssociation : Entity
	{	
		public const string SchemaName = "entitlementcontacts_association";
	
		public EntitlementcontactsAssociation() : base("entitlementcontacts_association") { }

		[AttributeLogicalName("contactid")]
		public Guid ContactId
		{	
			get { return GetAttributeValue<Guid>("contactid"); }
			set { SetAttributeValue("contactid", value); }
		}

		[AttributeLogicalName("entitlementid")]
		public Guid EntitlementId
		{	
			get { return GetAttributeValue<Guid>("entitlementid"); }
			set { SetAttributeValue("entitlementid", value); }
		}
	}
}

