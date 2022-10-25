using System;
using Microsoft.Xrm.Sdk; 
using Microsoft.Xrm.Sdk.Client;

namespace PentaWork.Xrm.Scheduler.Proxies.Relations
{
	/// <summary> 
	/// roleprivileges_association 
	/// </summary>
	[Relation]
	[EntityLogicalName("roleprivileges_association")]
	public sealed class RoleprivilegesAssociation : Entity
	{	
		public const string SchemaName = "roleprivileges_association";
	
		public RoleprivilegesAssociation() : base("roleprivileges_association") { }

		[AttributeLogicalName("privilegeid")]
		public Guid PrivilegeId
		{	
			get { return GetAttributeValue<Guid>("privilegeid"); }
			set { SetAttributeValue("privilegeid", value); }
		}

		[AttributeLogicalName("roleid")]
		public Guid RoleId
		{	
			get { return GetAttributeValue<Guid>("roleid"); }
			set { SetAttributeValue("roleid", value); }
		}
	}
}

