using System;
using Microsoft.Xrm.Sdk; 
using Microsoft.Xrm.Sdk.Client;

namespace PentaWork.Xrm.Scheduler.Proxies.Relations
{
	/// <summary> 
	/// msdyn_callablecontext_msdyn_playbooktemplate 
	/// </summary>
	[Relation]
	[EntityLogicalName("msdyn_callablecontext_msdyn_playbooktemplate")]
	public sealed class MsdynCallablecontextMsdynPlaybooktemplate : Entity
	{	
		public const string SchemaName = "msdyn_callablecontext_msdyn_playbooktemplate";
	
		public MsdynCallablecontextMsdynPlaybooktemplate() : base("msdyn_callablecontext_msdyn_playbooktemplate") { }

		[AttributeLogicalName("msdyn_callablecontextid")]
		public Guid MsdynCallablecontextId
		{	
			get { return GetAttributeValue<Guid>("msdyn_callablecontextid"); }
			set { SetAttributeValue("msdyn_callablecontextid", value); }
		}

		[AttributeLogicalName("msdyn_playbooktemplateid")]
		public Guid MsdynPlaybooktemplateId
		{	
			get { return GetAttributeValue<Guid>("msdyn_playbooktemplateid"); }
			set { SetAttributeValue("msdyn_playbooktemplateid", value); }
		}
	}
}

