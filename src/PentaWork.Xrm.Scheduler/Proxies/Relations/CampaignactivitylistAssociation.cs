using System;
using Microsoft.Xrm.Sdk; 
using Microsoft.Xrm.Sdk.Client;

namespace PentaWork.Xrm.Scheduler.Proxies.Relations
{
	/// <summary> 
	/// campaignactivitylist_association 
	/// </summary>
	[Relation]
	[EntityLogicalName("campaignactivitylist_association")]
	public sealed class CampaignactivitylistAssociation : Entity
	{	
		public const string SchemaName = "campaignactivitylist_association";
	
		public CampaignactivitylistAssociation() : base("campaignactivitylist_association") { }

		[AttributeLogicalName("campaignactivityid")]
		public Guid CampaignactivityId
		{	
			get { return GetAttributeValue<Guid>("campaignactivityid"); }
			set { SetAttributeValue("campaignactivityid", value); }
		}

		[AttributeLogicalName("itemid")]
		public Guid ItemId
		{	
			get { return GetAttributeValue<Guid>("itemid"); }
			set { SetAttributeValue("itemid", value); }
		}
	}
}

