using System;
using Microsoft.Xrm.Sdk; 
using Microsoft.Xrm.Sdk.Client;

namespace PentaWork.Xrm.Scheduler.Proxies.Relations
{
	/// <summary> 
	/// listaccount_association 
	/// </summary>
	[Relation]
	[EntityLogicalName("listaccount_association")]
	public sealed class ListaccountAssociation : Entity
	{	
		public const string SchemaName = "listaccount_association";
	
		public ListaccountAssociation() : base("listaccount_association") { }

		[AttributeLogicalName("listid")]
		public Guid ListId
		{	
			get { return GetAttributeValue<Guid>("listid"); }
			set { SetAttributeValue("listid", value); }
		}

		[AttributeLogicalName("entityid")]
		public Guid EntityId
		{	
			get { return GetAttributeValue<Guid>("entityid"); }
			set { SetAttributeValue("entityid", value); }
		}
	}
}

