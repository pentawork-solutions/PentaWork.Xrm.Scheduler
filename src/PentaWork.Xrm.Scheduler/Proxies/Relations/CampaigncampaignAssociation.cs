using System;
using Microsoft.Xrm.Sdk; 
using Microsoft.Xrm.Sdk.Client;

namespace PentaWork.Xrm.Scheduler.Proxies.Relations
{
	/// <summary> 
	/// campaigncampaign_association 
	/// </summary>
	[Relation]
	[EntityLogicalName("campaigncampaign_association")]
	public sealed class CampaigncampaignAssociation : Entity
	{	
		public const string SchemaName = "campaigncampaign_association";
	
		public CampaigncampaignAssociation() : base("campaigncampaign_association") { }

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

