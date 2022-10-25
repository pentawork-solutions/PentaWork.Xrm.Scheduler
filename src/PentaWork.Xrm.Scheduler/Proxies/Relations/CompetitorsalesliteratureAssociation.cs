using System;
using Microsoft.Xrm.Sdk; 
using Microsoft.Xrm.Sdk.Client;

namespace PentaWork.Xrm.Scheduler.Proxies.Relations
{
	/// <summary> 
	/// competitorsalesliterature_association 
	/// </summary>
	[Relation]
	[EntityLogicalName("competitorsalesliterature_association")]
	public sealed class CompetitorsalesliteratureAssociation : Entity
	{	
		public const string SchemaName = "competitorsalesliterature_association";
	
		public CompetitorsalesliteratureAssociation() : base("competitorsalesliterature_association") { }

		[AttributeLogicalName("salesliteratureid")]
		public Guid SalesliteratureId
		{	
			get { return GetAttributeValue<Guid>("salesliteratureid"); }
			set { SetAttributeValue("salesliteratureid", value); }
		}

		[AttributeLogicalName("competitorid")]
		public Guid CompetitorId
		{	
			get { return GetAttributeValue<Guid>("competitorid"); }
			set { SetAttributeValue("competitorid", value); }
		}
	}
}

