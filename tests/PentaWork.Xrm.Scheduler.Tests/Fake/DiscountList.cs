using Bogus;
using System;
using FakeXrmEasy;
using System.Collections.Generic;
using PentaWork.Xrm.Scheduler.Proxies.Entities;

namespace PentaWork.Xrm.Scheduler.Tests.Fake
{
	public static class FakeDiscountList
	{	
		#region FakeRelationships
		public static class Relationships 
		{
			/// <summary>1:N discount_type_discounts</summary>
			public static readonly XrmFakedRelationship DiscountTypeDiscounts = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "discounttypeid",
					Entity2Attribute = "discounttypeid",
					Entity1LogicalName = "discounttype",
					Entity2LogicalName = "discount",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N discount_type_product_price_levels</summary>
			public static readonly XrmFakedRelationship DiscountTypeProductPriceLevels = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "discounttypeid",
					Entity2Attribute = "discounttypeid",
					Entity1LogicalName = "discounttype",
					Entity2LogicalName = "productpricelevel",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N DiscountType_AsyncOperations</summary>
			public static readonly XrmFakedRelationship DiscountTypeAsyncOperations = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "discounttypeid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "discounttype",
					Entity2LogicalName = "asyncoperation",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N DiscountType_BulkDeleteFailures</summary>
			public static readonly XrmFakedRelationship DiscountTypeBulkDeleteFailures = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "discounttypeid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "discounttype",
					Entity2LogicalName = "bulkdeletefailure",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N discounttype_MailboxTrackingFolders</summary>
			public static readonly XrmFakedRelationship DiscounttypeMailboxTrackingFolders = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "discounttypeid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "discounttype",
					Entity2LogicalName = "mailboxtrackingfolder",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N discounttype_PrincipalObjectAttributeAccesses</summary>
			public static readonly XrmFakedRelationship DiscounttypePrincipalObjectAttributeAccesses = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "discounttypeid",
					Entity2Attribute = "objectid",
					Entity1LogicalName = "discounttype",
					Entity2LogicalName = "principalobjectattributeaccess",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N DiscountType_ProcessSessions</summary>
			public static readonly XrmFakedRelationship DiscountTypeProcessSessions = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "discounttypeid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "discounttype",
					Entity2LogicalName = "processsession",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N DiscountType_SyncErrors</summary>
			public static readonly XrmFakedRelationship DiscountTypeSyncErrors = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "discounttypeid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "discounttype",
					Entity2LogicalName = "syncerror",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

		}
		#endregion

		#region Fake
		public static DiscountList Create()
		{
			var faker = new Faker<DiscountList>()
			.RuleFor(e => e.Createdbyname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Createdbyyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.CreatedOn, fake => fake.Date.Soon())
			.RuleFor(e => e.Createdonbehalfbyname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Createdonbehalfbyyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.Description, fake => fake.Lorem.Word())
			.RuleFor(e => e.Id, fake => Guid.NewGuid())
			.RuleFor(e => e.ImportSequenceNumber, fake => fake.Random.Int())
			.RuleFor(e => e.Type, fake => fake.Random.Bool())
			.RuleFor(e => e.Modifiedbyname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Modifiedbyyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.ModifiedOn, fake => fake.Date.Soon())
			.RuleFor(e => e.Modifiedonbehalfbyname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Modifiedonbehalfbyyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.Name, fake => fake.Lorem.Word())
			.RuleFor(e => e.Organizationidname, fake => fake.Lorem.Word())
			.RuleFor(e => e.RecordCreatedOn, fake => fake.Date.Soon())
			.RuleFor(e => e.Status, fake => fake.PickRandom<DiscountList.eStatus>())
			.RuleFor(e => e.StatusReason, fake => fake.PickRandom<DiscountList.eStatusReason>())
			.RuleFor(e => e.TimeZoneRuleVersionNumber, fake => fake.Random.Int())
			.RuleFor(e => e.Transactioncurrencyidname, fake => fake.Lorem.Word())
			.RuleFor(e => e.UTCConversionTimeZoneCode, fake => fake.Random.Int())
			.RuleFor(e => e.VersionNumber, fake => fake.Random.Int());
			return faker.Generate();
		}
		#endregion
	}
}

