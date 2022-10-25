using Bogus;
using System;
using FakeXrmEasy;
using System.Collections.Generic;
using PentaWork.Xrm.Scheduler.Proxies.Entities;

namespace PentaWork.Xrm.Scheduler.Tests.Fake
{
	public static class FakePriceList
	{	
		#region FakeRelationships
		public static class Relationships 
		{
			/// <summary>1:N price_level_accounts</summary>
			public static readonly XrmFakedRelationship PriceLevelAccounts = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "pricelevelid",
					Entity2Attribute = "defaultpricelevelid",
					Entity1LogicalName = "pricelevel",
					Entity2LogicalName = "account",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N price_level_contacts</summary>
			public static readonly XrmFakedRelationship PriceLevelContacts = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "pricelevelid",
					Entity2Attribute = "defaultpricelevelid",
					Entity1LogicalName = "pricelevel",
					Entity2LogicalName = "contact",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N price_level_invoices</summary>
			public static readonly XrmFakedRelationship PriceLevelInvoices = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "pricelevelid",
					Entity2Attribute = "pricelevelid",
					Entity1LogicalName = "pricelevel",
					Entity2LogicalName = "invoice",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N price_level_opportunties</summary>
			public static readonly XrmFakedRelationship PriceLevelOpportunties = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "pricelevelid",
					Entity2Attribute = "pricelevelid",
					Entity1LogicalName = "pricelevel",
					Entity2LogicalName = "opportunity",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N price_level_orders</summary>
			public static readonly XrmFakedRelationship PriceLevelOrders = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "pricelevelid",
					Entity2Attribute = "pricelevelid",
					Entity1LogicalName = "pricelevel",
					Entity2LogicalName = "salesorder",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N price_level_product_price_levels</summary>
			public static readonly XrmFakedRelationship PriceLevelProductPriceLevels = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "pricelevelid",
					Entity2Attribute = "pricelevelid",
					Entity1LogicalName = "pricelevel",
					Entity2LogicalName = "productpricelevel",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N price_level_products</summary>
			public static readonly XrmFakedRelationship PriceLevelProducts = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "pricelevelid",
					Entity2Attribute = "pricelevelid",
					Entity1LogicalName = "pricelevel",
					Entity2LogicalName = "product",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N price_level_quotes</summary>
			public static readonly XrmFakedRelationship PriceLevelQuotes = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "pricelevelid",
					Entity2Attribute = "pricelevelid",
					Entity1LogicalName = "pricelevel",
					Entity2LogicalName = "quote",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N PriceLevel_AsyncOperations</summary>
			public static readonly XrmFakedRelationship PriceLevelAsyncOperations = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "pricelevelid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "pricelevel",
					Entity2LogicalName = "asyncoperation",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N PriceLevel_BulkDeleteFailures</summary>
			public static readonly XrmFakedRelationship PriceLevelBulkDeleteFailures = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "pricelevelid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "pricelevel",
					Entity2LogicalName = "bulkdeletefailure",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N pricelevel_connections1</summary>
			public static readonly XrmFakedRelationship PricelevelConnections1 = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "pricelevelid",
					Entity2Attribute = "record1id",
					Entity1LogicalName = "pricelevel",
					Entity2LogicalName = "connection",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N pricelevel_connections2</summary>
			public static readonly XrmFakedRelationship PricelevelConnections2 = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "pricelevelid",
					Entity2Attribute = "record2id",
					Entity1LogicalName = "pricelevel",
					Entity2LogicalName = "connection",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N pricelevel_MailboxTrackingFolders</summary>
			public static readonly XrmFakedRelationship PricelevelMailboxTrackingFolders = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "pricelevelid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "pricelevel",
					Entity2LogicalName = "mailboxtrackingfolder",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N pricelevel_principalobjectattributeaccess</summary>
			public static readonly XrmFakedRelationship PricelevelPrincipalobjectattributeaccess = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "pricelevelid",
					Entity2Attribute = "objectid",
					Entity1LogicalName = "pricelevel",
					Entity2LogicalName = "principalobjectattributeaccess",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N PriceLevel_ProcessSessions</summary>
			public static readonly XrmFakedRelationship PriceLevelProcessSessions = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "pricelevelid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "pricelevel",
					Entity2LogicalName = "processsession",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N PriceLevel_SyncErrors</summary>
			public static readonly XrmFakedRelationship PriceLevelSyncErrors = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "pricelevelid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "pricelevel",
					Entity2LogicalName = "syncerror",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N PriceList_Campaigns</summary>
			public static readonly XrmFakedRelationship PriceListCampaigns = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "pricelevelid",
					Entity2Attribute = "pricelistid",
					Entity1LogicalName = "pricelevel",
					Entity2LogicalName = "campaign",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

		}
		#endregion

		#region Fake
		public static PriceList Create()
		{
			var faker = new Faker<PriceList>()
			.RuleFor(e => e.StartDate, fake => fake.Date.Soon())
			.RuleFor(e => e.Createdbyname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Createdbyyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.CreatedOn, fake => fake.Date.Soon())
			.RuleFor(e => e.Createdonbehalfbyname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Createdonbehalfbyyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.Description, fake => fake.Lorem.Word())
			.RuleFor(e => e.EndDate, fake => fake.Date.Soon())
			.RuleFor(e => e.ExchangeRate, fake => fake.Finance.Amount())
			.RuleFor(e => e.FreightTerms, fake => fake.PickRandom<PriceList.eFreightTerms>())
			.RuleFor(e => e.ImportSequenceNumber, fake => fake.Random.Int())
			.RuleFor(e => e.Modifiedbyname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Modifiedbyyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.ModifiedOn, fake => fake.Date.Soon())
			.RuleFor(e => e.Modifiedonbehalfbyname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Modifiedonbehalfbyyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.Name, fake => fake.Lorem.Word())
			.RuleFor(e => e.Organizationidname, fake => fake.Lorem.Word())
			.RuleFor(e => e.RecordCreatedOn, fake => fake.Date.Soon())
			.RuleFor(e => e.PaymentMethod, fake => fake.PickRandom<PriceList.ePaymentMethod>())
			.RuleFor(e => e.Id, fake => Guid.NewGuid())
			.RuleFor(e => e.ShippingMethod, fake => fake.PickRandom<PriceList.eShippingMethod>())
			.RuleFor(e => e.Status, fake => fake.PickRandom<PriceList.eStatus>())
			.RuleFor(e => e.StatusReason, fake => fake.PickRandom<PriceList.eStatusReason>())
			.RuleFor(e => e.TimeZoneRuleVersionNumber, fake => fake.Random.Int())
			.RuleFor(e => e.Transactioncurrencyidname, fake => fake.Lorem.Word())
			.RuleFor(e => e.UTCConversionTimeZoneCode, fake => fake.Random.Int())
			.RuleFor(e => e.VersionNumber, fake => fake.Random.Int());
			return faker.Generate();
		}
		#endregion
	}
}

