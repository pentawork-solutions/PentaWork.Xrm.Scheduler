using System;
using Microsoft.Xrm.Sdk; 
using Microsoft.Xrm.Sdk.Client;

namespace PentaWork.Xrm.Scheduler.Proxies.Relations
{
	/// <summary> 
	/// leadcompetitors_association 
	/// </summary>
	[Relation]
	[EntityLogicalName("leadcompetitors_association")]
	public sealed class LeadcompetitorsAssociation : Entity
	{	
		public const string SchemaName = "leadcompetitors_association";
	
		public LeadcompetitorsAssociation() : base("leadcompetitors_association") { }

		[AttributeLogicalName("leadid")]
		public Guid LeadId
		{	
			get { return GetAttributeValue<Guid>("leadid"); }
			set { SetAttributeValue("leadid", value); }
		}

		[AttributeLogicalName("competitorid")]
		public Guid CompetitorId
		{	
			get { return GetAttributeValue<Guid>("competitorid"); }
			set { SetAttributeValue("competitorid", value); }
		}
	}
}

