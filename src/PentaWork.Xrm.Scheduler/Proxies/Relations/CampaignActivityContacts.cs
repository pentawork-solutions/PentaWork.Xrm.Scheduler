using System;
using Microsoft.Xrm.Sdk; 
using Microsoft.Xrm.Sdk.Client;

namespace PentaWork.Xrm.Scheduler.Proxies.Relations
{
	/// <summary> 
	/// CampaignActivity_Contacts 
	/// </summary>
	[Relation]
	[EntityLogicalName("CampaignActivity_Contacts")]
	public sealed class CampaignActivityContacts : Entity
	{	
		public const string SchemaName = "CampaignActivity_Contacts";
	
		public CampaignActivityContacts() : base("CampaignActivity_Contacts") { }

		[AttributeLogicalName("campaignactivityid")]
		public Guid CampaignactivityId
		{	
			get { return GetAttributeValue<Guid>("campaignactivityid"); }
			set { SetAttributeValue("campaignactivityid", value); }
		}

		[AttributeLogicalName("regardingobjectid")]
		public Guid RegardingobjectId
		{	
			get { return GetAttributeValue<Guid>("regardingobjectid"); }
			set { SetAttributeValue("regardingobjectid", value); }
		}
	}
}

