using System;
using Microsoft.Xrm.Sdk; 
using Microsoft.Xrm.Sdk.Client;

namespace PentaWork.Xrm.Scheduler.Proxies.Relations
{
	/// <summary> 
	/// knowledgearticle_category 
	/// </summary>
	[Relation]
	[EntityLogicalName("knowledgearticle_category")]
	public sealed class KnowledgearticleCategory : Entity
	{	
		public const string SchemaName = "knowledgearticle_category";
	
		public KnowledgearticleCategory() : base("knowledgearticle_category") { }

		[AttributeLogicalName("knowledgearticleid")]
		public Guid KnowledgearticleId
		{	
			get { return GetAttributeValue<Guid>("knowledgearticleid"); }
			set { SetAttributeValue("knowledgearticleid", value); }
		}

		[AttributeLogicalName("categoryid")]
		public Guid CategoryId
		{	
			get { return GetAttributeValue<Guid>("categoryid"); }
			set { SetAttributeValue("categoryid", value); }
		}
	}
}

