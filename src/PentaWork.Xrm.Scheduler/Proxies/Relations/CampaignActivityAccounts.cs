using System;
using Microsoft.Xrm.Sdk; 
using Microsoft.Xrm.Sdk.Client;

namespace PentaWork.Xrm.Scheduler.Proxies.Relations
{
	/// <summary> 
	/// CampaignActivity_Accounts 
	/// </summary>
	[Relation]
	[EntityLogicalName("CampaignActivity_Accounts")]
	public sealed class CampaignActivityAccounts : Entity
	{	
		public const string SchemaName = "CampaignActivity_Accounts";
	
		public CampaignActivityAccounts() : base("CampaignActivity_Accounts") { }

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

