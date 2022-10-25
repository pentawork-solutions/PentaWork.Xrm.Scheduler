using System;
using Microsoft.Xrm.Sdk; 
using Microsoft.Xrm.Sdk.Client;

namespace PentaWork.Xrm.Scheduler.Proxies.Relations
{
	/// <summary> 
	/// product_entitlement_association 
	/// </summary>
	[Relation]
	[EntityLogicalName("product_entitlement_association")]
	public sealed class ProductEntitlementAssociation : Entity
	{	
		public const string SchemaName = "product_entitlement_association";
	
		public ProductEntitlementAssociation() : base("product_entitlement_association") { }

		[AttributeLogicalName("productid")]
		public Guid ProductId
		{	
			get { return GetAttributeValue<Guid>("productid"); }
			set { SetAttributeValue("productid", value); }
		}

		[AttributeLogicalName("entitlementid")]
		public Guid EntitlementId
		{	
			get { return GetAttributeValue<Guid>("entitlementid"); }
			set { SetAttributeValue("entitlementid", value); }
		}
	}
}

