using Bogus;
using System;
using FakeXrmEasy;
using System.Collections.Generic;
using PentaWork.Xrm.Scheduler.Proxies.Entities;

namespace PentaWork.Xrm.Scheduler.Tests.Fake
{
	public static class FakeInvoiceProduct
	{	
		#region FakeRelationships
		public static class Relationships 
		{
			/// <summary>1:N InvoiceDetail_AsyncOperations</summary>
			public static readonly XrmFakedRelationship InvoiceDetailAsyncOperations = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "invoicedetailid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "invoicedetail",
					Entity2LogicalName = "asyncoperation",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N InvoiceDetail_BulkDeleteFailures</summary>
			public static readonly XrmFakedRelationship InvoiceDetailBulkDeleteFailures = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "invoicedetailid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "invoicedetail",
					Entity2LogicalName = "bulkdeletefailure",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N InvoiceDetail_Dynamicpropertyinstance</summary>
			public static readonly XrmFakedRelationship InvoiceDetailDynamicpropertyinstance = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "invoicedetailid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "invoicedetail",
					Entity2LogicalName = "dynamicpropertyinstance",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N invoicedetail_MailboxTrackingFolders</summary>
			public static readonly XrmFakedRelationship InvoicedetailMailboxTrackingFolders = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "invoicedetailid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "invoicedetail",
					Entity2LogicalName = "mailboxtrackingfolder",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N invoicedetail_parent_invoicedetail</summary>
			public static readonly XrmFakedRelationship InvoicedetailParentInvoicedetail = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "invoicedetailid",
					Entity2Attribute = "parentbundleid",
					Entity1LogicalName = "invoicedetail",
					Entity2LogicalName = "invoicedetail",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N invoicedetail_parentref_invoicedetail</summary>
			public static readonly XrmFakedRelationship InvoicedetailParentrefInvoicedetail = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "invoicedetailid",
					Entity2Attribute = "parentbundleidref",
					Entity1LogicalName = "invoicedetail",
					Entity2LogicalName = "invoicedetail",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N invoicedetail_principalobjectattributeaccess</summary>
			public static readonly XrmFakedRelationship InvoicedetailPrincipalobjectattributeaccess = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "invoicedetailid",
					Entity2Attribute = "objectid",
					Entity1LogicalName = "invoicedetail",
					Entity2LogicalName = "principalobjectattributeaccess",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N InvoiceDetail_ProcessSessions</summary>
			public static readonly XrmFakedRelationship InvoiceDetailProcessSessions = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "invoicedetailid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "invoicedetail",
					Entity2LogicalName = "processsession",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N InvoiceDetail_SyncErrors</summary>
			public static readonly XrmFakedRelationship InvoiceDetailSyncErrors = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "invoicedetailid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "invoicedetail",
					Entity2LogicalName = "syncerror",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

		}
		#endregion

		#region Fake
		public static InvoiceProduct Create()
		{
			var faker = new Faker<InvoiceProduct>()
			.RuleFor(e => e.DeliveredOn, fake => fake.Date.Soon())
			.RuleFor(e => e.Amount, fake => fake.Finance.Amount())
			.RuleFor(e => e.Createdbyname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Createdbyyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.CreatedOn, fake => fake.Date.Soon())
			.RuleFor(e => e.Createdonbehalfbyname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Createdonbehalfbyyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.Description, fake => fake.Lorem.Word())
			.RuleFor(e => e.ExchangeRate, fake => fake.Finance.Amount())
			.RuleFor(e => e.ExtendedAmount, fake => fake.Finance.Amount())
			.RuleFor(e => e.ImportSequenceNumber, fake => fake.Random.Int())
			.RuleFor(e => e.Id, fake => Guid.NewGuid())
			.RuleFor(e => e.Name, fake => fake.Lorem.Word())
			.RuleFor(e => e.Invoiceidname, fake => fake.Lorem.Word())
			.RuleFor(e => e.InvoiceIsPriceLocked, fake => fake.Random.Bool())
			.RuleFor(e => e.InvoiceStatus, fake => fake.PickRandom<InvoiceProduct.eInvoiceStatus>())
			.RuleFor(e => e.Copied, fake => fake.Random.Bool())
			.RuleFor(e => e.Pricing, fake => fake.Random.Bool())
			.RuleFor(e => e.SelectProduct, fake => fake.Random.Bool())
			.RuleFor(e => e.LineItemNumber, fake => fake.Random.Int())
			.RuleFor(e => e.ManualDiscount, fake => fake.Finance.Amount())
			.RuleFor(e => e.Modifiedbyname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Modifiedbyyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.ModifiedOn, fake => fake.Date.Soon())
			.RuleFor(e => e.Modifiedonbehalfbyname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Modifiedonbehalfbyyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.RecordCreatedOn, fake => fake.Date.Soon())
			.RuleFor(e => e.Owneridname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Owneridtype, fake => fake.Lorem.Word())
			.RuleFor(e => e.Owneridyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.ParentBundleId, fake => Guid.NewGuid())
			.RuleFor(e => e.PricePerUnit, fake => fake.Finance.Amount())
			.RuleFor(e => e.PricingError, fake => fake.PickRandom<InvoiceProduct.egPricingError>())
			.RuleFor(e => e.BundleItemAssociationId, fake => Guid.NewGuid())
			.RuleFor(e => e.WriteInProduct, fake => fake.Lorem.Word())
			.RuleFor(e => e.Productidname, fake => fake.Lorem.Word())
			.RuleFor(e => e.ProductName, fake => fake.Lorem.Word())
			.RuleFor(e => e.ProductNumber, fake => fake.Lorem.Word())
			.RuleFor(e => e.ProductType, fake => fake.PickRandom<InvoiceProduct.egProductType>())
			.RuleFor(e => e.PropertyConfiguration, fake => fake.PickRandom<InvoiceProduct.egPropertiesConfiguration>())
			.RuleFor(e => e.Quantity, fake => fake.Finance.Amount())
			.RuleFor(e => e.QuantityBackOrdered, fake => fake.Finance.Amount())
			.RuleFor(e => e.QuantityCanceled, fake => fake.Finance.Amount())
			.RuleFor(e => e.QuantityShipped, fake => fake.Finance.Amount())
			.RuleFor(e => e.Salesorderdetailidname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Salesrepidname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Salesrepidyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.SequenceNumber, fake => fake.Random.Int())
			.RuleFor(e => e.ShipmentTrackingNumber, fake => fake.Lorem.Word())
			.RuleFor(e => e.ShipToCity, fake => fake.Lorem.Word())
			.RuleFor(e => e.ShipToCountryRegion, fake => fake.Lorem.Word())
			.RuleFor(e => e.ShipToFax, fake => fake.Lorem.Word())
			.RuleFor(e => e.FreightTerms, fake => fake.PickRandom<InvoiceProduct.eFreightTerms>())
			.RuleFor(e => e.ShipToStreet1, fake => fake.Lorem.Word())
			.RuleFor(e => e.ShipToStreet2, fake => fake.Lorem.Word())
			.RuleFor(e => e.ShipToStreet3, fake => fake.Lorem.Word())
			.RuleFor(e => e.ShipToName, fake => fake.Lorem.Word())
			.RuleFor(e => e.ShipToZIPPostalCode, fake => fake.Lorem.Word())
			.RuleFor(e => e.ShipToStateProvince, fake => fake.Lorem.Word())
			.RuleFor(e => e.ShipToPhone, fake => fake.Lorem.Word())
			.RuleFor(e => e.SkipPriceCalculation, fake => fake.PickRandom<InvoiceProduct.egSkipPriceCalculationOptionSet>())
			.RuleFor(e => e.Tax, fake => fake.Finance.Amount())
			.RuleFor(e => e.TimeZoneRuleVersionNumber, fake => fake.Random.Int())
			.RuleFor(e => e.Transactioncurrencyidname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Uomidname, fake => fake.Lorem.Word())
			.RuleFor(e => e.UTCConversionTimeZoneCode, fake => fake.Random.Int())
			.RuleFor(e => e.VersionNumber, fake => fake.Random.Int())
			.RuleFor(e => e.VolumeDiscount, fake => fake.Finance.Amount())
			.RuleFor(e => e.ShipTo, fake => fake.Random.Bool());
			return faker.Generate();
		}
		#endregion
	}
}

