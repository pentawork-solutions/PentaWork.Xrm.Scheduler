using System;
using Microsoft.Xrm.Sdk; 
using Microsoft.Xrm.Sdk.Client;

namespace PentaWork.Xrm.Scheduler.Proxies.Relations
{
	/// <summary> 
	/// campaignlist_association 
	/// </summary>
	[Relation]
	[EntityLogicalName("campaignlist_association")]
	public sealed class CampaignlistAssociation : Entity
	{	
		public const string SchemaName = "campaignlist_association";
	
		public CampaignlistAssociation() : base("campaignlist_association") { }

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

