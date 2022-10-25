using System;
using Microsoft.Xrm.Sdk; 
using Microsoft.Xrm.Sdk.Client;

namespace PentaWork.Xrm.Scheduler.Proxies.Relations
{
	/// <summary> 
	/// productsalesliterature_association 
	/// </summary>
	[Relation]
	[EntityLogicalName("productsalesliterature_association")]
	public sealed class ProductsalesliteratureAssociation : Entity
	{	
		public const string SchemaName = "productsalesliterature_association";
	
		public ProductsalesliteratureAssociation() : base("productsalesliterature_association") { }

		[AttributeLogicalName("productid")]
		public Guid ProductId
		{	
			get { return GetAttributeValue<Guid>("productid"); }
			set { SetAttributeValue("productid", value); }
		}

		[AttributeLogicalName("salesliteratureid")]
		public Guid SalesliteratureId
		{	
			get { return GetAttributeValue<Guid>("salesliteratureid"); }
			set { SetAttributeValue("salesliteratureid", value); }
		}
	}
}

