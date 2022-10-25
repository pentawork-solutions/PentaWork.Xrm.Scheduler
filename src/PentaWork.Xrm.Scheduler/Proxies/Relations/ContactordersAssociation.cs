using System;
using Microsoft.Xrm.Sdk; 
using Microsoft.Xrm.Sdk.Client;

namespace PentaWork.Xrm.Scheduler.Proxies.Relations
{
	/// <summary> 
	/// contactorders_association 
	/// </summary>
	[Relation]
	[EntityLogicalName("contactorders_association")]
	public sealed class ContactordersAssociation : Entity
	{	
		public const string SchemaName = "contactorders_association";
	
		public ContactordersAssociation() : base("contactorders_association") { }

		[AttributeLogicalName("salesorderid")]
		public Guid SalesorderId
		{	
			get { return GetAttributeValue<Guid>("salesorderid"); }
			set { SetAttributeValue("salesorderid", value); }
		}

		[AttributeLogicalName("contactid")]
		public Guid ContactId
		{	
			get { return GetAttributeValue<Guid>("contactid"); }
			set { SetAttributeValue("contactid", value); }
		}
	}
}

