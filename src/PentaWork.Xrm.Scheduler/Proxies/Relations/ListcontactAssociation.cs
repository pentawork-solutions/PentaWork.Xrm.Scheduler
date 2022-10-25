using System;
using Microsoft.Xrm.Sdk; 
using Microsoft.Xrm.Sdk.Client;

namespace PentaWork.Xrm.Scheduler.Proxies.Relations
{
	/// <summary> 
	/// listcontact_association 
	/// </summary>
	[Relation]
	[EntityLogicalName("listcontact_association")]
	public sealed class ListcontactAssociation : Entity
	{	
		public const string SchemaName = "listcontact_association";
	
		public ListcontactAssociation() : base("listcontact_association") { }

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

