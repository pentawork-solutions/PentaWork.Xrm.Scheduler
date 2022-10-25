using System;
using Microsoft.Xrm.Sdk; 
using Microsoft.Xrm.Sdk.Client;

namespace PentaWork.Xrm.Scheduler.Proxies.Relations
{
	/// <summary> 
	/// CampaignActivity_Leads 
	/// </summary>
	[Relation]
	[EntityLogicalName("CampaignActivity_Leads")]
	public sealed class CampaignActivityLeads : Entity
	{	
		public const string SchemaName = "CampaignActivity_Leads";
	
		public CampaignActivityLeads() : base("CampaignActivity_Leads") { }

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

