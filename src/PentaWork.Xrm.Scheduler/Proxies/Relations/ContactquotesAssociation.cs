using System;
using Microsoft.Xrm.Sdk; 
using Microsoft.Xrm.Sdk.Client;

namespace PentaWork.Xrm.Scheduler.Proxies.Relations
{
	/// <summary> 
	/// contactquotes_association 
	/// </summary>
	[Relation]
	[EntityLogicalName("contactquotes_association")]
	public sealed class ContactquotesAssociation : Entity
	{	
		public const string SchemaName = "contactquotes_association";
	
		public ContactquotesAssociation() : base("contactquotes_association") { }

		[AttributeLogicalName("quoteid")]
		public Guid QuoteId
		{	
			get { return GetAttributeValue<Guid>("quoteid"); }
			set { SetAttributeValue("quoteid", value); }
		}

		[AttributeLogicalName("contactid")]
		public Guid ContactId
		{	
			get { return GetAttributeValue<Guid>("contactid"); }
			set { SetAttributeValue("contactid", value); }
		}
	}
}

