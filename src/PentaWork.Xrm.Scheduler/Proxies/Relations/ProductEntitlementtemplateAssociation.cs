using System;
using Microsoft.Xrm.Sdk; 
using Microsoft.Xrm.Sdk.Client;

namespace PentaWork.Xrm.Scheduler.Proxies.Relations
{
	/// <summary> 
	/// product_entitlementtemplate_association 
	/// </summary>
	[Relation]
	[EntityLogicalName("product_entitlementtemplate_association")]
	public sealed class ProductEntitlementtemplateAssociation : Entity
	{	
		public const string SchemaName = "product_entitlementtemplate_association";
	
		public ProductEntitlementtemplateAssociation() : base("product_entitlementtemplate_association") { }

		[AttributeLogicalName("productid")]
		public Guid ProductId
		{	
			get { return GetAttributeValue<Guid>("productid"); }
			set { SetAttributeValue("productid", value); }
		}

		[AttributeLogicalName("entitlementtemplateid")]
		public Guid EntitlementtemplateId
		{	
			get { return GetAttributeValue<Guid>("entitlementtemplateid"); }
			set { SetAttributeValue("entitlementtemplateid", value); }
		}
	}
}

