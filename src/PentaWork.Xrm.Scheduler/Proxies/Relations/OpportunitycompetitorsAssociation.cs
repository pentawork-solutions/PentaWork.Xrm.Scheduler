using System;
using Microsoft.Xrm.Sdk; 
using Microsoft.Xrm.Sdk.Client;

namespace PentaWork.Xrm.Scheduler.Proxies.Relations
{
	/// <summary> 
	/// opportunitycompetitors_association 
	/// </summary>
	[Relation]
	[EntityLogicalName("opportunitycompetitors_association")]
	public sealed class OpportunitycompetitorsAssociation : Entity
	{	
		public const string SchemaName = "opportunitycompetitors_association";
	
		public OpportunitycompetitorsAssociation() : base("opportunitycompetitors_association") { }

		[AttributeLogicalName("opportunityid")]
		public Guid OpportunityId
		{	
			get { return GetAttributeValue<Guid>("opportunityid"); }
			set { SetAttributeValue("opportunityid", value); }
		}

		[AttributeLogicalName("competitorid")]
		public Guid CompetitorId
		{	
			get { return GetAttributeValue<Guid>("competitorid"); }
			set { SetAttributeValue("competitorid", value); }
		}
	}
}

