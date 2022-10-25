using System;
using Microsoft.Xrm.Sdk; 
using Microsoft.Xrm.Sdk.Client;

namespace PentaWork.Xrm.Scheduler.Proxies.Relations
{
	/// <summary> 
	/// campaignproduct_association 
	/// </summary>
	[Relation]
	[EntityLogicalName("campaignproduct_association")]
	public sealed class CampaignproductAssociation : Entity
	{	
		public const string SchemaName = "campaignproduct_association";
	
		public CampaignproductAssociation() : base("campaignproduct_association") { }

		[AttributeLogicalName("campaignid")]
		public Guid CampaignId
		{	
			get { return GetAttributeValue<Guid>("campaignid"); }
			set { SetAttributeValue("campaignid", value); }
		}

		[AttributeLogicalName("entityid")]
		public Guid EntityId
		{	
			get { return GetAttributeValue<Guid>("entityid"); }
			set { SetAttributeValue("entityid", value); }
		}
	}
}

