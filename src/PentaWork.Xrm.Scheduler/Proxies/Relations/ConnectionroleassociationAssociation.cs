using System;
using Microsoft.Xrm.Sdk; 
using Microsoft.Xrm.Sdk.Client;

namespace PentaWork.Xrm.Scheduler.Proxies.Relations
{
	/// <summary> 
	/// connectionroleassociation_association 
	/// </summary>
	[Relation]
	[EntityLogicalName("connectionroleassociation_association")]
	public sealed class ConnectionroleassociationAssociation : Entity
	{	
		public const string SchemaName = "connectionroleassociation_association";
	
		public ConnectionroleassociationAssociation() : base("connectionroleassociation_association") { }

		[AttributeLogicalName("connectionroleid")]
		public Guid ConnectionroleId
		{	
			get { return GetAttributeValue<Guid>("connectionroleid"); }
			set { SetAttributeValue("connectionroleid", value); }
		}

		[AttributeLogicalName("associatedconnectionroleid")]
		public Guid AssociatedconnectionroleId
		{	
			get { return GetAttributeValue<Guid>("associatedconnectionroleid"); }
			set { SetAttributeValue("associatedconnectionroleid", value); }
		}
	}
}

