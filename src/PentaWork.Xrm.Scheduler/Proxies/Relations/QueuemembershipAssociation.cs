using System;
using Microsoft.Xrm.Sdk; 
using Microsoft.Xrm.Sdk.Client;

namespace PentaWork.Xrm.Scheduler.Proxies.Relations
{
	/// <summary> 
	/// queuemembership_association 
	/// </summary>
	[Relation]
	[EntityLogicalName("queuemembership_association")]
	public sealed class QueuemembershipAssociation : Entity
	{	
		public const string SchemaName = "queuemembership_association";
	
		public QueuemembershipAssociation() : base("queuemembership_association") { }

		[AttributeLogicalName("queueid")]
		public Guid QueueId
		{	
			get { return GetAttributeValue<Guid>("queueid"); }
			set { SetAttributeValue("queueid", value); }
		}

		[AttributeLogicalName("systemuserid")]
		public Guid SystemuserId
		{	
			get { return GetAttributeValue<Guid>("systemuserid"); }
			set { SetAttributeValue("systemuserid", value); }
		}
	}
}

