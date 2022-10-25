using System;
using Microsoft.Xrm.Sdk; 
using Microsoft.Xrm.Sdk.Client;

namespace PentaWork.Xrm.Scheduler.Proxies.Relations
{
	/// <summary> 
	/// listlead_association 
	/// </summary>
	[Relation]
	[EntityLogicalName("listlead_association")]
	public sealed class ListleadAssociation : Entity
	{	
		public const string SchemaName = "listlead_association";
	
		public ListleadAssociation() : base("listlead_association") { }

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

