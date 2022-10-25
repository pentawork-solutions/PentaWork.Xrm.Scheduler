using Bogus;
using System;
using FakeXrmEasy;
using System.Collections.Generic;
using PentaWork.Xrm.Scheduler.Proxies.Entities;

namespace PentaWork.Xrm.Scheduler.Tests.Fake
{
	public static class FakeOrderProduct
	{	
		#region FakeRelationships
		public static class Relationships 
		{
			/// <summary>1:N msdyn_salesorderdetail_invoicedetail</summary>
			public static readonly XrmFakedRelationship MsdynSalesorderdetailInvoicedetail = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "salesorderdetailid",
					Entity2Attribute = "salesorderdetailid",
					Entity1LogicalName = "salesorderdetail",
					Entity2LogicalName = "invoicedetail",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N SalesOrderDetail_AsyncOperations</summary>
			public static readonly XrmFakedRelationship SalesOrderDetailAsyncOperations = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "salesorderdetailid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "salesorderdetail",
					Entity2LogicalName = "asyncoperation",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N SalesOrderDetail_BulkDeleteFailures</summary>
			public static readonly XrmFakedRelationship SalesOrderDetailBulkDeleteFailures = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "salesorderdetailid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "salesorderdetail",
					Entity2LogicalName = "bulkdeletefailure",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N SalesOrderDetail_Dynamicpropertyinstance</summary>
			public static readonly XrmFakedRelationship SalesOrderDetailDynamicpropertyinstance = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "salesorderdetailid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "salesorderdetail",
					Entity2LogicalName = "dynamicpropertyinstance",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N salesorderdetail_MailboxTrackingFolders</summary>
			public static readonly XrmFakedRelationship SalesorderdetailMailboxTrackingFolders = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "salesorderdetailid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "salesorderdetail",
					Entity2LogicalName = "mailboxtrackingfolder",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N salesorderdetail_parent_salesorderdetail</summary>
			public static readonly XrmFakedRelationship SalesorderdetailParentSalesorderdetail = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "salesorderdetailid",
					Entity2Attribute = "parentbundleid",
					Entity1LogicalName = "salesorderdetail",
					Entity2LogicalName = "salesorderdetail",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N salesorderdetail_parentref_salesorderdetail</summary>
			public static readonly XrmFakedRelationship SalesorderdetailParentrefSalesorderdetail = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "salesorderdetailid",
					Entity2Attribute = "parentbundleidref",
					Entity1LogicalName = "salesorderdetail",
					Entity2LogicalName = "salesorderdetail",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N salesorderdetail_principalobjectattributeaccess</summary>
			public static readonly XrmFakedRelationship SalesorderdetailPrincipalobjectattributeaccess = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "salesorderdetailid",
					Entity2Attribute = "objectid",
					Entity1LogicalName = "salesorderdetail",
					Entity2LogicalName = "principalobjectattributeaccess",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N SalesOrderDetail_ProcessSessions</summary>
			public static readonly XrmFakedRelationship SalesOrderDetailProcessSessions = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "salesorderdetailid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "salesorderdetail",
					Entity2LogicalName = "processsession",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N SalesOrderDetail_SyncErrors</summary>
			public static readonly XrmFakedRelationship SalesOrderDetailSyncErrors = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "salesorderdetailid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "salesorderdetail",
					Entity2LogicalName = "syncerror",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

		}
		#endregion

		#region Fake
		public static OrderProduct Create()
		{
			var faker = new Faker<OrderProduct>()
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
			.RuleFor(e => e.PricingError, fake => fake.PickRandom<OrderProduct.egPricingError>())
			.RuleFor(e => e.BundleItemAssociationId, fake => Guid.NewGuid())
			.RuleFor(e => e.WriteInProduct, fake => fake.Lorem.Word())
			.RuleFor(e => e.Productidname, fake => fake.Lorem.Word())
			.RuleFor(e => e.ProductName, fake => fake.Lorem.Word())
			.RuleFor(e => e.ProductNumber, fake => fake.Lorem.Word())
			.RuleFor(e => e.ProductType, fake => fake.PickRandom<OrderProduct.egProductType>())
			.RuleFor(e => e.PropertyConfiguration, fake => fake.PickRandom<OrderProduct.egPropertiesConfiguration>())
			.RuleFor(e => e.Quantity, fake => fake.Finance.Amount())
			.RuleFor(e => e.QuantityBackOrdered, fake => fake.Finance.Amount())
			.RuleFor(e => e.QuantityCanceled, fake => fake.Finance.Amount())
			.RuleFor(e => e.QuantityShipped, fake => fake.Finance.Amount())
			.RuleFor(e => e.Quotedetailidname, fake => fake.Lorem.Word())
			.RuleFor(e => e.RequestedDeliveryDate, fake => fake.Date.Soon())
			.RuleFor(e => e.Id, fake => Guid.NewGuid())
			.RuleFor(e => e.Name, fake => fake.Lorem.Word())
			.RuleFor(e => e.Salesorderidname, fake => fake.Lorem.Word())
			.RuleFor(e => e.OrderIsPriceLocked, fake => fake.Random.Bool())
			.RuleFor(e => e.OrderStatus, fake => fake.PickRandom<OrderProduct.eOrderStatus>())
			.RuleFor(e => e.Salesrepidname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Salesrepidyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.SequenceNumber, fake => fake.Random.Int())
			.RuleFor(e => e.ShipToAddressId, fake => Guid.NewGuid())
			.RuleFor(e => e.ShipToCity, fake => fake.Lorem.Word())
			.RuleFor(e => e.ShipToContactName, fake => fake.Lorem.Word())
			.RuleFor(e => e.ShipToCountryRegion, fake => fake.Lorem.Word())
			.RuleFor(e => e.ShipToFax, fake => fake.Lorem.Word())
			.RuleFor(e => e.FreightTerms, fake => fake.PickRandom<OrderProduct.eFreightTerms>())
			.RuleFor(e => e.ShipToStreet1, fake => fake.Lorem.Word())
			.RuleFor(e => e.ShipToStreet2, fake => fake.Lorem.Word())
			.RuleFor(e => e.ShipToStreet3, fake => fake.Lorem.Word())
			.RuleFor(e => e.ShipToName, fake => fake.Lorem.Word())
			.RuleFor(e => e.ShipToZIPPostalCode, fake => fake.Lorem.Word())
			.RuleFor(e => e.ShipToStateProvince, fake => fake.Lorem.Word())
			.RuleFor(e => e.ShipToPhone, fake => fake.Lorem.Word())
			.RuleFor(e => e.SkipPriceCalculation, fake => fake.PickRandom<OrderProduct.egSkipPriceCalculationOptionSet>())
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

