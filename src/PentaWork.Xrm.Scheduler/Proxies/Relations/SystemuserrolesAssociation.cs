using System;
using Microsoft.Xrm.Sdk; 
using Microsoft.Xrm.Sdk.Client;

namespace PentaWork.Xrm.Scheduler.Proxies.Relations
{
	/// <summary> 
	/// systemuserroles_association 
	/// </summary>
	[Relation]
	[EntityLogicalName("systemuserroles_association")]
	public sealed class SystemuserrolesAssociation : Entity
	{	
		public const string SchemaName = "systemuserroles_association";
	
		public SystemuserrolesAssociation() : base("systemuserroles_association") { }

		[AttributeLogicalName("systemuserid")]
		public Guid SystemuserId
		{	
			get { return GetAttributeValue<Guid>("systemuserid"); }
			set { SetAttributeValue("systemuserid", value); }
		}

		[AttributeLogicalName("roleid")]
		public Guid RoleId
		{	
			get { return GetAttributeValue<Guid>("roleid"); }
			set { SetAttributeValue("roleid", value); }
		}
	}
}

