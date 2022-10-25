using Bogus;
using System;
using FakeXrmEasy;
using System.Collections.Generic;
using PentaWork.Xrm.Scheduler.Proxies.Entities;

namespace PentaWork.Xrm.Scheduler.Tests.Fake
{
	public static class FakeUnit
	{	
		#region FakeRelationships
		public static class Relationships 
		{
			/// <summary>1:N unit_of_measurement_base_unit</summary>
			public static readonly XrmFakedRelationship UnitOfMeasurementBaseUnit = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "uomid",
					Entity2Attribute = "baseuom",
					Entity1LogicalName = "uom",
					Entity2LogicalName = "uom",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N unit_of_measurement_contract_line_items</summary>
			public static readonly XrmFakedRelationship UnitOfMeasurementContractLineItems = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "uomid",
					Entity2Attribute = "uomid",
					Entity1LogicalName = "uom",
					Entity2LogicalName = "contractdetail",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N unit_of_measurement_invoice_details</summary>
			public static readonly XrmFakedRelationship UnitOfMeasurementInvoiceDetails = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "uomid",
					Entity2Attribute = "uomid",
					Entity1LogicalName = "uom",
					Entity2LogicalName = "invoicedetail",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N unit_of_measurement_opportunity_products</summary>
			public static readonly XrmFakedRelationship UnitOfMeasurementOpportunityProducts = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "uomid",
					Entity2Attribute = "uomid",
					Entity1LogicalName = "uom",
					Entity2LogicalName = "opportunityproduct",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N unit_of_measurement_order_details</summary>
			public static readonly XrmFakedRelationship UnitOfMeasurementOrderDetails = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "uomid",
					Entity2Attribute = "uomid",
					Entity1LogicalName = "uom",
					Entity2LogicalName = "salesorderdetail",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N unit_of_measurement_product_price_levels</summary>
			public static readonly XrmFakedRelationship UnitOfMeasurementProductPriceLevels = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "uomid",
					Entity2Attribute = "uomid",
					Entity1LogicalName = "uom",
					Entity2LogicalName = "productpricelevel",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N unit_of_measurement_productassociation</summary>
			public static readonly XrmFakedRelationship UnitOfMeasurementProductassociation = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "uomid",
					Entity2Attribute = "uomid",
					Entity1LogicalName = "uom",
					Entity2LogicalName = "productassociation",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N unit_of_measurement_products</summary>
			public static readonly XrmFakedRelationship UnitOfMeasurementProducts = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "uomid",
					Entity2Attribute = "defaultuomid",
					Entity1LogicalName = "uom",
					Entity2LogicalName = "product",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N unit_of_measurement_quote_details</summary>
			public static readonly XrmFakedRelationship UnitOfMeasurementQuoteDetails = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "uomid",
					Entity2Attribute = "uomid",
					Entity1LogicalName = "uom",
					Entity2LogicalName = "quotedetail",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N UoM_AsyncOperations</summary>
			public static readonly XrmFakedRelationship UoMAsyncOperations = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "uomid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "uom",
					Entity2LogicalName = "asyncoperation",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N UoM_BulkDeleteFailures</summary>
			public static readonly XrmFakedRelationship UoMBulkDeleteFailures = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "uomid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "uom",
					Entity2LogicalName = "bulkdeletefailure",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N uom_MailboxTrackingFolders</summary>
			public static readonly XrmFakedRelationship UomMailboxTrackingFolders = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "uomid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "uom",
					Entity2LogicalName = "mailboxtrackingfolder",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N uom_PrincipalObjectAttributeAccesses</summary>
			public static readonly XrmFakedRelationship UomPrincipalObjectAttributeAccesses = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "uomid",
					Entity2Attribute = "objectid",
					Entity1LogicalName = "uom",
					Entity2LogicalName = "principalobjectattributeaccess",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N UoM_SyncErrors</summary>
			public static readonly XrmFakedRelationship UoMSyncErrors = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "uomid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "uom",
					Entity2LogicalName = "syncerror",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

		}
		#endregion

		#region Fake
		public static Unit Create()
		{
			var faker = new Faker<Unit>()
			.RuleFor(e => e.Baseuomname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Createdbyexternalpartyname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Createdbyexternalpartyyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.Createdbyname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Createdbyyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.CreatedOn, fake => fake.Date.Soon())
			.RuleFor(e => e.Createdonbehalfbyname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Createdonbehalfbyyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.ImportSequenceNumber, fake => fake.Random.Int())
			.RuleFor(e => e.IsScheduleBaseUnit, fake => fake.Random.Bool())
			.RuleFor(e => e.Modifiedbyexternalpartyname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Modifiedbyexternalpartyyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.Modifiedbyname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Modifiedbyyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.ModifiedOn, fake => fake.Date.Soon())
			.RuleFor(e => e.Modifiedonbehalfbyname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Modifiedonbehalfbyyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.Name, fake => fake.Lorem.Word())
			.RuleFor(e => e.OrganizationId, fake => Guid.NewGuid())
			.RuleFor(e => e.RecordCreatedOn, fake => fake.Date.Soon())
			.RuleFor(e => e.Quantity, fake => fake.Finance.Amount())
			.RuleFor(e => e.TimeZoneRuleVersionNumber, fake => fake.Random.Int())
			.RuleFor(e => e.Id, fake => Guid.NewGuid())
			.RuleFor(e => e.Uomscheduleidname, fake => fake.Lorem.Word())
			.RuleFor(e => e.UTCConversionTimeZoneCode, fake => fake.Random.Int())
			.RuleFor(e => e.VersionNumber, fake => fake.Random.Int());
			return faker.Generate();
		}
		#endregion
	}
}

