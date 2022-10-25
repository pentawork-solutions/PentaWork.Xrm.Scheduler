using System;
using Microsoft.Xrm.Sdk; 
using Microsoft.Xrm.Sdk.Client;

namespace PentaWork.Xrm.Scheduler.Proxies.Relations
{
	/// <summary> 
	/// roletemplateprivileges_association 
	/// </summary>
	[Relation]
	[EntityLogicalName("roletemplateprivileges_association")]
	public sealed class RoletemplateprivilegesAssociation : Entity
	{	
		public const string SchemaName = "roletemplateprivileges_association";
	
		public RoletemplateprivilegesAssociation() : base("roletemplateprivileges_association") { }

		[AttributeLogicalName("roletemplateid")]
		public Guid RoletemplateId
		{	
			get { return GetAttributeValue<Guid>("roletemplateid"); }
			set { SetAttributeValue("roletemplateid", value); }
		}

		[AttributeLogicalName("privilegeid")]
		public Guid PrivilegeId
		{	
			get { return GetAttributeValue<Guid>("privilegeid"); }
			set { SetAttributeValue("privilegeid", value); }
		}
	}
}

