using System;
using Microsoft.Xrm.Sdk; 
using Microsoft.Xrm.Sdk.Client;

namespace PentaWork.Xrm.Scheduler.Proxies.Relations
{
	/// <summary> 
	/// msdyn_aiodlabel_msdyn_aiconfiguration 
	/// </summary>
	[Relation]
	[EntityLogicalName("msdyn_aiodlabel_msdyn_aiconfiguration")]
	public sealed class MsdynAiodlabelMsdynAiconfiguration : Entity
	{	
		public const string SchemaName = "msdyn_aiodlabel_msdyn_aiconfiguration";
	
		public MsdynAiodlabelMsdynAiconfiguration() : base("msdyn_aiodlabel_msdyn_aiconfiguration") { }

		[AttributeLogicalName("msdyn_aiodlabelid")]
		public Guid MsdynAiodlabelId
		{	
			get { return GetAttributeValue<Guid>("msdyn_aiodlabelid"); }
			set { SetAttributeValue("msdyn_aiodlabelid", value); }
		}

		[AttributeLogicalName("msdyn_aiconfigurationid")]
		public Guid MsdynAiconfigurationId
		{	
			get { return GetAttributeValue<Guid>("msdyn_aiconfigurationid"); }
			set { SetAttributeValue("msdyn_aiconfigurationid", value); }
		}
	}
}

