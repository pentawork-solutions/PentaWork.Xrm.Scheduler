using System;
using Microsoft.Xrm.Sdk; 
using Microsoft.Xrm.Sdk.Client;

namespace PentaWork.Xrm.Scheduler.Proxies.Relations
{
	/// <summary> 
	/// KnowledgeBaseRecord_Incident 
	/// </summary>
	[Relation]
	[EntityLogicalName("KnowledgeBaseRecord_Incident")]
	public sealed class KnowledgeBaseRecordIncident : Entity
	{	
		public const string SchemaName = "KnowledgeBaseRecord_Incident";
	
		public KnowledgeBaseRecordIncident() : base("KnowledgeBaseRecord_Incident") { }

		[AttributeLogicalName("knowledgebaserecordid")]
		public Guid KnowledgebaserecordId
		{	
			get { return GetAttributeValue<Guid>("knowledgebaserecordid"); }
			set { SetAttributeValue("knowledgebaserecordid", value); }
		}

		[AttributeLogicalName("incidentid")]
		public Guid IncidentId
		{	
			get { return GetAttributeValue<Guid>("incidentid"); }
			set { SetAttributeValue("incidentid", value); }
		}
	}
}

