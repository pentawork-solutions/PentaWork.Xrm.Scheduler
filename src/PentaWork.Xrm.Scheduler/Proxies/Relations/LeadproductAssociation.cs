using System;
using Microsoft.Xrm.Sdk; 
using Microsoft.Xrm.Sdk.Client;

namespace PentaWork.Xrm.Scheduler.Proxies.Relations
{
	/// <summary> 
	/// leadproduct_association 
	/// </summary>
	[Relation]
	[EntityLogicalName("leadproduct_association")]
	public sealed class LeadproductAssociation : Entity
	{	
		public const string SchemaName = "leadproduct_association";
	
		public LeadproductAssociation() : base("leadproduct_association") { }

		[AttributeLogicalName("leadid")]
		public Guid LeadId
		{	
			get { return GetAttributeValue<Guid>("leadid"); }
			set { SetAttributeValue("leadid", value); }
		}

		[AttributeLogicalName("productid")]
		public Guid ProductId
		{	
			get { return GetAttributeValue<Guid>("productid"); }
			set { SetAttributeValue("productid", value); }
		}
	}
}

