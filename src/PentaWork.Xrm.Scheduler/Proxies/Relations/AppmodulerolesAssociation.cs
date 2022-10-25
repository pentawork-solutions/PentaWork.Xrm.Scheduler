using System;
using Microsoft.Xrm.Sdk; 
using Microsoft.Xrm.Sdk.Client;

namespace PentaWork.Xrm.Scheduler.Proxies.Relations
{
	/// <summary> 
	/// appmoduleroles_association 
	/// </summary>
	[Relation]
	[EntityLogicalName("appmoduleroles_association")]
	public sealed class AppmodulerolesAssociation : Entity
	{	
		public const string SchemaName = "appmoduleroles_association";
	
		public AppmodulerolesAssociation() : base("appmoduleroles_association") { }

		[AttributeLogicalName("appmoduleid")]
		public Guid AppmoduleId
		{	
			get { return GetAttributeValue<Guid>("appmoduleid"); }
			set { SetAttributeValue("appmoduleid", value); }
		}

		[AttributeLogicalName("roleid")]
		public Guid RoleId
		{	
			get { return GetAttributeValue<Guid>("roleid"); }
			set { SetAttributeValue("roleid", value); }
		}
	}
}

