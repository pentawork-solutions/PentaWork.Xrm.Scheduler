using Bogus;
using System;
using FakeXrmEasy;
using System.Collections.Generic;
using PentaWork.Xrm.Scheduler.Proxies.Entities;

namespace PentaWork.Xrm.Scheduler.Tests.Fake
{
	public static class FakePriceListItem
	{	
		#region FakeRelationships
		public static class Relationships 
		{
			/// <summary>1:N ProductPriceLevel_AsyncOperations</summary>
			public static readonly XrmFakedRelationship ProductPriceLevelAsyncOperations = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "productpricelevelid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "productpricelevel",
					Entity2LogicalName = "asyncoperation",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N ProductPriceLevel_BulkDeleteFailures</summary>
			public static readonly XrmFakedRelationship ProductPriceLevelBulkDeleteFailures = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "productpricelevelid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "productpricelevel",
					Entity2LogicalName = "bulkdeletefailure",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N productpricelevel_MailboxTrackingFolders</summary>
			public static readonly XrmFakedRelationship ProductpricelevelMailboxTrackingFolders = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "productpricelevelid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "productpricelevel",
					Entity2LogicalName = "mailboxtrackingfolder",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N productpricelevel_PrincipalObjectAttributeAccesses</summary>
			public static readonly XrmFakedRelationship ProductpricelevelPrincipalObjectAttributeAccesses = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "productpricelevelid",
					Entity2Attribute = "objectid",
					Entity1LogicalName = "productpricelevel",
					Entity2LogicalName = "principalobjectattributeaccess",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N ProductPriceLevel_ProcessSessions</summary>
			public static readonly XrmFakedRelationship ProductPriceLevelProcessSessions = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "productpricelevelid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "productpricelevel",
					Entity2LogicalName = "processsession",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N ProductPriceLevel_SyncErrors</summary>
			public static readonly XrmFakedRelationship ProductPriceLevelSyncErrors = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "productpricelevelid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "productpricelevel",
					Entity2LogicalName = "syncerror",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

		}
		#endregion

		#region Fake
		public static PriceListItem Create()
		{
			var faker = new Faker<PriceListItem>()
			.RuleFor(e => e.Amount, fake => fake.Finance.Amount())
			.RuleFor(e => e.Createdbyname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Createdbyyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.CreatedOn, fake => fake.Date.Soon())
			.RuleFor(e => e.Createdonbehalfbyname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Createdonbehalfbyyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.Discounttypeidname, fake => fake.Lorem.Word())
			.RuleFor(e => e.ExchangeRate, fake => fake.Finance.Amount())
			.RuleFor(e => e.ImportSequenceNumber, fake => fake.Random.Int())
			.RuleFor(e => e.Modifiedbyname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Modifiedbyyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.ModifiedOn, fake => fake.Date.Soon())
			.RuleFor(e => e.Modifiedonbehalfbyname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Modifiedonbehalfbyyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.OrganizationId, fake => Guid.NewGuid())
			.RuleFor(e => e.RecordCreatedOn, fake => fake.Date.Soon())
			.RuleFor(e => e.Percentage, fake => fake.Finance.Amount())
			.RuleFor(e => e.Pricelevelidname, fake => fake.Lorem.Word())
			.RuleFor(e => e.PricingMethod, fake => fake.PickRandom<PriceListItem.ePricingMethod>())
			.RuleFor(e => e.ProcessId, fake => Guid.NewGuid())
			.RuleFor(e => e.Productidname, fake => fake.Lorem.Word())
			.RuleFor(e => e.ProductID, fake => fake.Lorem.Word())
			.RuleFor(e => e.Id, fake => Guid.NewGuid())
			.RuleFor(e => e.QuantitySellingOption, fake => fake.PickRandom<PriceListItem.eQuantitySellingOption>())
			.RuleFor(e => e.RoundingAmount, fake => fake.Finance.Amount())
			.RuleFor(e => e.RoundingOption, fake => fake.PickRandom<PriceListItem.eRoundingOption>())
			.RuleFor(e => e.RoundingPolicy, fake => fake.PickRandom<PriceListItem.eRoundingPolicy>())
			.RuleFor(e => e.DeprecatedStageId, fake => Guid.NewGuid())
			.RuleFor(e => e.TimeZoneRuleVersionNumber, fake => fake.Random.Int())
			.RuleFor(e => e.Transactioncurrencyidname, fake => fake.Lorem.Word())
			.RuleFor(e => e.DeprecatedTraversedPath, fake => fake.Lorem.Word())
			.RuleFor(e => e.Uomidname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Uomscheduleidname, fake => fake.Lorem.Word())
			.RuleFor(e => e.UTCConversionTimeZoneCode, fake => fake.Random.Int())
			.RuleFor(e => e.VersionNumber, fake => fake.Random.Int());
			return faker.Generate();
		}
		#endregion
	}
}

