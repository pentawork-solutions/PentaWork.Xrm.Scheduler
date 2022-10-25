using System;
using Microsoft.Xrm.Sdk; 
using Microsoft.Xrm.Sdk.Client;

namespace PentaWork.Xrm.Scheduler.Proxies.Relations
{
	/// <summary> 
	/// contactinvoices_association 
	/// </summary>
	[Relation]
	[EntityLogicalName("contactinvoices_association")]
	public sealed class ContactinvoicesAssociation : Entity
	{	
		public const string SchemaName = "contactinvoices_association";
	
		public ContactinvoicesAssociation() : base("contactinvoices_association") { }

		[AttributeLogicalName("invoiceid")]
		public Guid InvoiceId
		{	
			get { return GetAttributeValue<Guid>("invoiceid"); }
			set { SetAttributeValue("invoiceid", value); }
		}

		[AttributeLogicalName("contactid")]
		public Guid ContactId
		{	
			get { return GetAttributeValue<Guid>("contactid"); }
			set { SetAttributeValue("contactid", value); }
		}
	}
}

