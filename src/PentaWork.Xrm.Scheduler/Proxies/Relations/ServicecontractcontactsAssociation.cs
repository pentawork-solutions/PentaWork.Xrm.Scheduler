using System;
using Microsoft.Xrm.Sdk; 
using Microsoft.Xrm.Sdk.Client;

namespace PentaWork.Xrm.Scheduler.Proxies.Relations
{
	/// <summary> 
	/// servicecontractcontacts_association 
	/// </summary>
	[Relation]
	[EntityLogicalName("servicecontractcontacts_association")]
	public sealed class ServicecontractcontactsAssociation : Entity
	{	
		public const string SchemaName = "servicecontractcontacts_association";
	
		public ServicecontractcontactsAssociation() : base("servicecontractcontacts_association") { }

		[AttributeLogicalName("contactid")]
		public Guid ContactId
		{	
			get { return GetAttributeValue<Guid>("contactid"); }
			set { SetAttributeValue("contactid", value); }
		}

		[AttributeLogicalName("contractid")]
		public Guid ContractId
		{	
			get { return GetAttributeValue<Guid>("contractid"); }
			set { SetAttributeValue("contractid", value); }
		}
	}
}

