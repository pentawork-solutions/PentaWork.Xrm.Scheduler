using Bogus;
using System;
using FakeXrmEasy;
using System.Collections.Generic;
using PentaWork.Xrm.Scheduler.Proxies.Entities;

namespace PentaWork.Xrm.Scheduler.Tests.Fake
{
	public static class FakeProduct
	{	
		#region FakeRelationships
		public static class Relationships 
		{
			/// <summary>1:N opportunity_products</summary>
			public static readonly XrmFakedRelationship OpportunityProducts = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "productid",
					Entity2Attribute = "productid",
					Entity1LogicalName = "product",
					Entity2LogicalName = "opportunityproduct",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N Product_Annotation</summary>
			public static readonly XrmFakedRelationship ProductAnnotation = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "productid",
					Entity2Attribute = "objectid",
					Entity1LogicalName = "product",
					Entity2LogicalName = "annotation",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N Product_AsyncOperations</summary>
			public static readonly XrmFakedRelationship ProductAsyncOperations = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "productid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "product",
					Entity2LogicalName = "asyncoperation",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N Product_BulkDeleteFailures</summary>
			public static readonly XrmFakedRelationship ProductBulkDeleteFailures = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "productid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "product",
					Entity2LogicalName = "bulkdeletefailure",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N product_connections1</summary>
			public static readonly XrmFakedRelationship ProductConnections1 = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "productid",
					Entity2Attribute = "record1id",
					Entity1LogicalName = "product",
					Entity2LogicalName = "connection",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N product_connections2</summary>
			public static readonly XrmFakedRelationship ProductConnections2 = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "productid",
					Entity2Attribute = "record2id",
					Entity1LogicalName = "product",
					Entity2LogicalName = "connection",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N product_contract_line_items</summary>
			public static readonly XrmFakedRelationship ProductContractLineItems = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "productid",
					Entity2Attribute = "productid",
					Entity1LogicalName = "product",
					Entity2LogicalName = "contractdetail",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N Product_DynamicProperty</summary>
			public static readonly XrmFakedRelationship ProductDynamicProperty = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "productid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "product",
					Entity2LogicalName = "dynamicproperty",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N Product_DynamicPropertyAssociation</summary>
			public static readonly XrmFakedRelationship ProductDynamicPropertyAssociation = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "productid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "product",
					Entity2LogicalName = "dynamicpropertyassociation",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N product_incidents</summary>
			public static readonly XrmFakedRelationship ProductIncidents = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "productid",
					Entity2Attribute = "productid",
					Entity1LogicalName = "product",
					Entity2LogicalName = "incident",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N product_invoice_details</summary>
			public static readonly XrmFakedRelationship ProductInvoiceDetails = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "productid",
					Entity2Attribute = "productid",
					Entity1LogicalName = "product",
					Entity2LogicalName = "invoicedetail",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N product_MailboxTrackingFolders</summary>
			public static readonly XrmFakedRelationship ProductMailboxTrackingFolders = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "productid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "product",
					Entity2LogicalName = "mailboxtrackingfolder",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N product_order_details</summary>
			public static readonly XrmFakedRelationship ProductOrderDetails = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "productid",
					Entity2Attribute = "productid",
					Entity1LogicalName = "product",
					Entity2LogicalName = "salesorderdetail",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N product_parent_product</summary>
			public static readonly XrmFakedRelationship ProductParentProduct = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "productid",
					Entity2Attribute = "parentproductid",
					Entity1LogicalName = "product",
					Entity2LogicalName = "product",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N product_price_levels</summary>
			public static readonly XrmFakedRelationship ProductPriceLevels = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "productid",
					Entity2Attribute = "productid",
					Entity1LogicalName = "product",
					Entity2LogicalName = "productpricelevel",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N product_principalobjectattributeaccess</summary>
			public static readonly XrmFakedRelationship ProductPrincipalobjectattributeaccess = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "productid",
					Entity2Attribute = "objectid",
					Entity1LogicalName = "product",
					Entity2LogicalName = "principalobjectattributeaccess",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N Product_ProcessSessions</summary>
			public static readonly XrmFakedRelationship ProductProcessSessions = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "productid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "product",
					Entity2LogicalName = "processsession",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N Product_ProductAssociation_AssocProd</summary>
			public static readonly XrmFakedRelationship ProductProductAssociationAssocProd = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "productid",
					Entity2Attribute = "associatedproduct",
					Entity1LogicalName = "product",
					Entity2LogicalName = "productassociation",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N Product_ProductAssociation_Prod</summary>
			public static readonly XrmFakedRelationship ProductProductAssociationProd = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "productid",
					Entity2Attribute = "productid",
					Entity1LogicalName = "product",
					Entity2LogicalName = "productassociation",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N product_ProductSubstitute_productid</summary>
			public static readonly XrmFakedRelationship ProductProductSubstituteProductid = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "productid",
					Entity2Attribute = "productid",
					Entity1LogicalName = "product",
					Entity2LogicalName = "productsubstitute",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N product_ProductSubstitute_substitutedproductid</summary>
			public static readonly XrmFakedRelationship ProductProductSubstituteSubstitutedproductid = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "productid",
					Entity2Attribute = "substitutedproductid",
					Entity1LogicalName = "product",
					Entity2LogicalName = "productsubstitute",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N product_quote_details</summary>
			public static readonly XrmFakedRelationship ProductQuoteDetails = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "productid",
					Entity2Attribute = "productid",
					Entity1LogicalName = "product",
					Entity2LogicalName = "quotedetail",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N Product_SharepointDocumentLocation</summary>
			public static readonly XrmFakedRelationship ProductSharepointDocumentLocation = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "productid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "product",
					Entity2LogicalName = "sharepointdocumentlocation",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N Product_SyncErrors</summary>
			public static readonly XrmFakedRelationship ProductSyncErrors = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "productid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "product",
					Entity2LogicalName = "syncerror",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>N:N campaignproduct_association</summary>
			public static readonly XrmFakedRelationship CampaignproductAssociation = 
				new XrmFakedRelationship
				{
					IntersectEntity = "campaignproduct_association",
					Entity1Attribute = "campaignid",
					Entity2Attribute = "entityid",
					Entity1LogicalName = "campaign",
					Entity2LogicalName = "product",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.ManyToMany
				};

			/// <summary>N:N competitorproduct_association</summary>
			public static readonly XrmFakedRelationship CompetitorproductAssociation = 
				new XrmFakedRelationship
				{
					IntersectEntity = "competitorproduct_association",
					Entity1Attribute = "competitorid",
					Entity2Attribute = "productid",
					Entity1LogicalName = "competitor",
					Entity2LogicalName = "product",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.ManyToMany
				};

			/// <summary>N:N leadproduct_association</summary>
			public static readonly XrmFakedRelationship LeadproductAssociation = 
				new XrmFakedRelationship
				{
					IntersectEntity = "leadproduct_association",
					Entity1Attribute = "leadid",
					Entity2Attribute = "productid",
					Entity1LogicalName = "lead",
					Entity2LogicalName = "product",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.ManyToMany
				};

			/// <summary>N:N product_entitlement_association</summary>
			public static readonly XrmFakedRelationship ProductEntitlementAssociation = 
				new XrmFakedRelationship
				{
					IntersectEntity = "product_entitlement_association",
					Entity1Attribute = "productid",
					Entity2Attribute = "entitlementid",
					Entity1LogicalName = "product",
					Entity2LogicalName = "entitlement",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.ManyToMany
				};

			/// <summary>N:N product_entitlementtemplate_association</summary>
			public static readonly XrmFakedRelationship ProductEntitlementtemplateAssociation = 
				new XrmFakedRelationship
				{
					IntersectEntity = "product_entitlementtemplate_association",
					Entity1Attribute = "productid",
					Entity2Attribute = "entitlementtemplateid",
					Entity1LogicalName = "product",
					Entity2LogicalName = "entitlementtemplate",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.ManyToMany
				};

			/// <summary>N:N productsalesliterature_association</summary>
			public static readonly XrmFakedRelationship ProductsalesliteratureAssociation = 
				new XrmFakedRelationship
				{
					IntersectEntity = "productsalesliterature_association",
					Entity1Attribute = "productid",
					Entity2Attribute = "salesliteratureid",
					Entity1LogicalName = "product",
					Entity2LogicalName = "salesliterature",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.ManyToMany
				};

		}
		#endregion

		#region Fake
		public static Product Create()
		{
			var faker = new Faker<Product>()
			.RuleFor(e => e.Createdbyexternalpartyname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Createdbyexternalpartyyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.Createdbyname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Createdbyyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.CreatedOn, fake => fake.Date.Soon())
			.RuleFor(e => e.Createdonbehalfbyname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Createdonbehalfbyyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.CurrentCost, fake => fake.Finance.Amount())
			.RuleFor(e => e.Defaultuomidname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Defaultuomscheduleidname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Description, fake => fake.Lorem.Word())
			.RuleFor(e => e.InternalUseOnly, fake => fake.Random.Int())
			.RuleFor(e => e.EntityimageTimestamp, fake => fake.Random.Int())
			.RuleFor(e => e.EntityimageUrl, fake => fake.Lorem.Word())
			.RuleFor(e => e.EntityimageId, fake => Guid.NewGuid())
			.RuleFor(e => e.ExchangeRate, fake => fake.Finance.Amount())
			.RuleFor(e => e.HierarchyPath, fake => fake.Lorem.Word())
			.RuleFor(e => e.ImportSequenceNumber, fake => fake.Random.Int())
			.RuleFor(e => e.IsKit, fake => fake.Random.Bool())
			.RuleFor(e => e.IsReparented, fake => fake.Random.Bool())
			.RuleFor(e => e.StockItem, fake => fake.Random.Bool())
			.RuleFor(e => e.Modifiedbyexternalpartyname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Modifiedbyexternalpartyyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.Modifiedbyname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Modifiedbyyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.ModifiedOn, fake => fake.Date.Soon())
			.RuleFor(e => e.Modifiedonbehalfbyname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Modifiedonbehalfbyyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.Name, fake => fake.Lorem.Word())
			.RuleFor(e => e.Organizationidname, fake => fake.Lorem.Word())
			.RuleFor(e => e.RecordCreatedOn, fake => fake.Date.Soon())
			.RuleFor(e => e.Parentproductidname, fake => fake.Lorem.Word())
			.RuleFor(e => e.ListPrice, fake => fake.Finance.Amount())
			.RuleFor(e => e.Pricelevelidname, fake => fake.Lorem.Word())
			.RuleFor(e => e.ProcessId, fake => Guid.NewGuid())
			.RuleFor(e => e.Id, fake => Guid.NewGuid())
			.RuleFor(e => e.ProductID, fake => fake.Lorem.Word())
			.RuleFor(e => e.ProductStructure, fake => fake.PickRandom<Product.eProductClassification>())
			.RuleFor(e => e.ProductType, fake => fake.PickRandom<Product.eProductType>())
			.RuleFor(e => e.URL, fake => fake.Lorem.Word())
			.RuleFor(e => e.DecimalsSupported, fake => fake.Random.Int())
			.RuleFor(e => e.QuantityOnHand, fake => fake.Finance.Amount())
			.RuleFor(e => e.Size, fake => fake.Lorem.Word())
			.RuleFor(e => e.DeprecatedStageId, fake => Guid.NewGuid())
			.RuleFor(e => e.StandardCost, fake => fake.Finance.Amount())
			.RuleFor(e => e.Status, fake => fake.PickRandom<Product.eStatus>())
			.RuleFor(e => e.StatusReason, fake => fake.PickRandom<Product.eStatusReason>())
			.RuleFor(e => e.StockVolume, fake => fake.Finance.Amount())
			.RuleFor(e => e.StockWeight, fake => fake.Finance.Amount())
			.RuleFor(e => e.Subjectidname, fake => fake.Lorem.Word())
			.RuleFor(e => e.SupplierName, fake => fake.Lorem.Word())
			.RuleFor(e => e.TimeZoneRuleVersionNumber, fake => fake.Random.Int())
			.RuleFor(e => e.Transactioncurrencyidname, fake => fake.Lorem.Word())
			.RuleFor(e => e.DeprecatedTraversedPath, fake => fake.Lorem.Word())
			.RuleFor(e => e.UTCConversionTimeZoneCode, fake => fake.Random.Int())
			.RuleFor(e => e.ValidFrom, fake => fake.Date.Soon())
			.RuleFor(e => e.ValidTo, fake => fake.Date.Soon())
			.RuleFor(e => e.VendorID, fake => fake.Lorem.Word())
			.RuleFor(e => e.Vendor, fake => fake.Lorem.Word())
			.RuleFor(e => e.VendorName, fake => fake.Lorem.Word())
			.RuleFor(e => e.VersionNumber, fake => fake.Random.Int());
			return faker.Generate();
		}
		#endregion
	}
}

