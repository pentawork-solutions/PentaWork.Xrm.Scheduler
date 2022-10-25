using Bogus;
using System;
using FakeXrmEasy;
using System.Collections.Generic;
using PentaWork.Xrm.Scheduler.Proxies.Entities;

namespace PentaWork.Xrm.Scheduler.Tests.Fake
{
	public static class FakeBookableResourceCategory
	{	
		#region FakeRelationships
		public static class Relationships 
		{
			/// <summary>1:N bookableresourcecategory_AsyncOperations</summary>
			public static readonly XrmFakedRelationship BookableresourcecategoryAsyncOperations = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "bookableresourcecategoryid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "bookableresourcecategory",
					Entity2LogicalName = "asyncoperation",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N bookableresourcecategory_bookableresourcecategoryassn_ResourceCategory</summary>
			public static readonly XrmFakedRelationship BookableresourcecategoryBookableresourcecategoryassnResourceCategory = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "bookableresourcecategoryid",
					Entity2Attribute = "resourcecategory",
					Entity1LogicalName = "bookableresourcecategory",
					Entity2LogicalName = "bookableresourcecategoryassn",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N bookableresourcecategory_BulkDeleteFailures</summary>
			public static readonly XrmFakedRelationship BookableresourcecategoryBulkDeleteFailures = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "bookableresourcecategoryid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "bookableresourcecategory",
					Entity2LogicalName = "bulkdeletefailure",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N bookableresourcecategory_DuplicateBaseRecord</summary>
			public static readonly XrmFakedRelationship BookableresourcecategoryDuplicateBaseRecord = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "bookableresourcecategoryid",
					Entity2Attribute = "baserecordid",
					Entity1LogicalName = "bookableresourcecategory",
					Entity2LogicalName = "duplicaterecord",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N bookableresourcecategory_DuplicateMatchingRecord</summary>
			public static readonly XrmFakedRelationship BookableresourcecategoryDuplicateMatchingRecord = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "bookableresourcecategoryid",
					Entity2Attribute = "duplicaterecordid",
					Entity1LogicalName = "bookableresourcecategory",
					Entity2LogicalName = "duplicaterecord",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N bookableresourcecategory_MailboxTrackingFolders</summary>
			public static readonly XrmFakedRelationship BookableresourcecategoryMailboxTrackingFolders = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "bookableresourcecategoryid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "bookableresourcecategory",
					Entity2LogicalName = "mailboxtrackingfolder",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N bookableresourcecategory_PrincipalObjectAttributeAccess</summary>
			public static readonly XrmFakedRelationship BookableresourcecategoryPrincipalObjectAttributeAccess = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "bookableresourcecategoryid",
					Entity2Attribute = "objectid",
					Entity1LogicalName = "bookableresourcecategory",
					Entity2LogicalName = "principalobjectattributeaccess",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N bookableresourcecategory_ProcessSession</summary>
			public static readonly XrmFakedRelationship BookableresourcecategoryProcessSession = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "bookableresourcecategoryid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "bookableresourcecategory",
					Entity2LogicalName = "processsession",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N BookableResourceCategory_SyncErrors</summary>
			public static readonly XrmFakedRelationship BookableResourceCategorySyncErrors = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "bookableresourcecategoryid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "bookableresourcecategory",
					Entity2LogicalName = "syncerror",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

		}
		#endregion

		#region Fake
		public static BookableResourceCategory Create()
		{
			var faker = new Faker<BookableResourceCategory>()
			.RuleFor(e => e.Id, fake => Guid.NewGuid())
			.RuleFor(e => e.Createdbyname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Createdbyyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.CreatedOn, fake => fake.Date.Soon())
			.RuleFor(e => e.Createdonbehalfbyname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Createdonbehalfbyyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.Description, fake => fake.Lorem.Word())
			.RuleFor(e => e.ExchangeRate, fake => fake.Finance.Amount())
			.RuleFor(e => e.ImportSequenceNumber, fake => fake.Random.Int())
			.RuleFor(e => e.Modifiedbyname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Modifiedbyyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.ModifiedOn, fake => fake.Date.Soon())
			.RuleFor(e => e.Modifiedonbehalfbyname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Modifiedonbehalfbyyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.Name, fake => fake.Lorem.Word())
			.RuleFor(e => e.RecordCreatedOn, fake => fake.Date.Soon())
			.RuleFor(e => e.Owneridname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Owneridtype, fake => fake.Lorem.Word())
			.RuleFor(e => e.Owneridyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.Status, fake => fake.PickRandom<BookableResourceCategory.eStatus>())
			.RuleFor(e => e.StatusReason, fake => fake.PickRandom<BookableResourceCategory.eStatusReason>())
			.RuleFor(e => e.TimeZoneRuleVersionNumber, fake => fake.Random.Int())
			.RuleFor(e => e.Transactioncurrencyidname, fake => fake.Lorem.Word())
			.RuleFor(e => e.UTCConversionTimeZoneCode, fake => fake.Random.Int())
			.RuleFor(e => e.VersionNumber, fake => fake.Random.Int());
			return faker.Generate();
		}
		#endregion
	}
}

