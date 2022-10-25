using System;
using Microsoft.Xrm.Sdk; 
using Microsoft.Xrm.Sdk.Client;

namespace PentaWork.Xrm.Scheduler.Proxies.Relations
{
	/// <summary> 
	/// serviceplan_appmodule 
	/// </summary>
	[Relation]
	[EntityLogicalName("serviceplan_appmodule")]
	public sealed class ServiceplanAppmodule : Entity
	{	
		public const string SchemaName = "serviceplan_appmodule";
	
		public ServiceplanAppmodule() : base("serviceplan_appmodule") { }

		[AttributeLogicalName("serviceplanid")]
		public Guid ServiceplanId
		{	
			get { return GetAttributeValue<Guid>("serviceplanid"); }
			set { SetAttributeValue("serviceplanid", value); }
		}

		[AttributeLogicalName("appmoduleid")]
		public Guid AppmoduleId
		{	
			get { return GetAttributeValue<Guid>("appmoduleid"); }
			set { SetAttributeValue("appmoduleid", value); }
		}
	}
}

