using System;
using Microsoft.Xrm.Sdk; 
using Microsoft.Xrm.Sdk.Client;

namespace PentaWork.Xrm.Scheduler.Proxies.Relations
{
	/// <summary> 
	/// campaignsalesliterature_association 
	/// </summary>
	[Relation]
	[EntityLogicalName("campaignsalesliterature_association")]
	public sealed class CampaignsalesliteratureAssociation : Entity
	{	
		public const string SchemaName = "campaignsalesliterature_association";
	
		public CampaignsalesliteratureAssociation() : base("campaignsalesliterature_association") { }

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

