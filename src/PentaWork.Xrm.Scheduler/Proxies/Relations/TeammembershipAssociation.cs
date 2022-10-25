using System;
using Microsoft.Xrm.Sdk; 
using Microsoft.Xrm.Sdk.Client;

namespace PentaWork.Xrm.Scheduler.Proxies.Relations
{
	/// <summary> 
	/// teammembership_association 
	/// </summary>
	[Relation]
	[EntityLogicalName("teammembership_association")]
	public sealed class TeammembershipAssociation : Entity
	{	
		public const string SchemaName = "teammembership_association";
	
		public TeammembershipAssociation() : base("teammembership_association") { }

		[AttributeLogicalName("teamid")]
		public Guid TeamId
		{	
			get { return GetAttributeValue<Guid>("teamid"); }
			set { SetAttributeValue("teamid", value); }
		}

		[AttributeLogicalName("systemuserid")]
		public Guid SystemuserId
		{	
			get { return GetAttributeValue<Guid>("systemuserid"); }
			set { SetAttributeValue("systemuserid", value); }
		}
	}
}

