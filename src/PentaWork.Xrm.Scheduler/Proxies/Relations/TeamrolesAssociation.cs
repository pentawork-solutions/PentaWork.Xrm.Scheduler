using System;
using Microsoft.Xrm.Sdk; 
using Microsoft.Xrm.Sdk.Client;

namespace PentaWork.Xrm.Scheduler.Proxies.Relations
{
	/// <summary> 
	/// teamroles_association 
	/// </summary>
	[Relation]
	[EntityLogicalName("teamroles_association")]
	public sealed class TeamrolesAssociation : Entity
	{	
		public const string SchemaName = "teamroles_association";
	
		public TeamrolesAssociation() : base("teamroles_association") { }

		[AttributeLogicalName("teamid")]
		public Guid TeamId
		{	
			get { return GetAttributeValue<Guid>("teamid"); }
			set { SetAttributeValue("teamid", value); }
		}

		[AttributeLogicalName("roleid")]
		public Guid RoleId
		{	
			get { return GetAttributeValue<Guid>("roleid"); }
			set { SetAttributeValue("roleid", value); }
		}
	}
}

