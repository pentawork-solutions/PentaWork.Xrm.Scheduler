using System;
using Microsoft.Xrm.Sdk; 
using Microsoft.Xrm.Sdk.Client;

namespace PentaWork.Xrm.Scheduler.Proxies.Relations
{
	/// <summary> 
	/// botcomponent_workflow 
	/// </summary>
	[Relation]
	[EntityLogicalName("botcomponent_workflow")]
	public sealed class BotcomponentWorkflow : Entity
	{	
		public const string SchemaName = "botcomponent_workflow";
	
		public BotcomponentWorkflow() : base("botcomponent_workflow") { }

		[AttributeLogicalName("botcomponentid")]
		public Guid BotcomponentId
		{	
			get { return GetAttributeValue<Guid>("botcomponentid"); }
			set { SetAttributeValue("botcomponentid", value); }
		}

		[AttributeLogicalName("workflowid")]
		public Guid WorkflowId
		{	
			get { return GetAttributeValue<Guid>("workflowid"); }
			set { SetAttributeValue("workflowid", value); }
		}
	}
}

