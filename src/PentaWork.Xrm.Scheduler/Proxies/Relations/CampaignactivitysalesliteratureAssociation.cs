using System;
using Microsoft.Xrm.Sdk; 
using Microsoft.Xrm.Sdk.Client;

namespace PentaWork.Xrm.Scheduler.Proxies.Relations
{
	/// <summary> 
	/// campaignactivitysalesliterature_association 
	/// </summary>
	[Relation]
	[EntityLogicalName("campaignactivitysalesliterature_association")]
	public sealed class CampaignactivitysalesliteratureAssociation : Entity
	{	
		public const string SchemaName = "campaignactivitysalesliterature_association";
	
		public CampaignactivitysalesliteratureAssociation() : base("campaignactivitysalesliterature_association") { }

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

