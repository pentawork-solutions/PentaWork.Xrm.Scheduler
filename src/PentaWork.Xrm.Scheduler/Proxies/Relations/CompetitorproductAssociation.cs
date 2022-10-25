using System;
using Microsoft.Xrm.Sdk; 
using Microsoft.Xrm.Sdk.Client;

namespace PentaWork.Xrm.Scheduler.Proxies.Relations
{
	/// <summary> 
	/// competitorproduct_association 
	/// </summary>
	[Relation]
	[EntityLogicalName("competitorproduct_association")]
	public sealed class CompetitorproductAssociation : Entity
	{	
		public const string SchemaName = "competitorproduct_association";
	
		public CompetitorproductAssociation() : base("competitorproduct_association") { }

		[AttributeLogicalName("competitorid")]
		public Guid CompetitorId
		{	
			get { return GetAttributeValue<Guid>("competitorid"); }
			set { SetAttributeValue("competitorid", value); }
		}

		[AttributeLogicalName("productid")]
		public Guid ProductId
		{	
			get { return GetAttributeValue<Guid>("productid"); }
			set { SetAttributeValue("productid", value); }
		}
	}
}

