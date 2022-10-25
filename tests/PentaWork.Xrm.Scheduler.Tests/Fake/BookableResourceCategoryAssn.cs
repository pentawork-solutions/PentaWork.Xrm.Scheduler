using Bogus;
using System;
using FakeXrmEasy;
using System.Collections.Generic;
using PentaWork.Xrm.Scheduler.Proxies.Entities;

namespace PentaWork.Xrm.Scheduler.Tests.Fake
{
	public static class FakeBookableResourceCategoryAssn
	{	
		#region FakeRelationships
		public static class Relationships 
		{
			/// <summary>1:N bookableresourcecategoryassn_Annotations</summary>
			public static readonly XrmFakedRelationship BookableresourcecategoryassnAnnotations = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "bookableresourcecategoryassnid",
					Entity2Attribute = "objectid",
					Entity1LogicalName = "bookableresourcecategoryassn",
					Entity2LogicalName = "annotation",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N bookableresourcecategoryassn_AsyncOperations</summary>
			public static readonly XrmFakedRelationship BookableresourcecategoryassnAsyncOperations = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "bookableresourcecategoryassnid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "bookableresourcecategoryassn",
					Entity2LogicalName = "asyncoperation",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N bookableresourcecategoryassn_BulkDeleteFailures</summary>
			public static readonly XrmFakedRelationship BookableresourcecategoryassnBulkDeleteFailures = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "bookableresourcecategoryassnid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "bookableresourcecategoryassn",
					Entity2LogicalName = "bulkdeletefailure",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N bookableresourcecategoryassn_DuplicateBaseRecord</summary>
			public static readonly XrmFakedRelationship BookableresourcecategoryassnDuplicateBaseRecord = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "bookableresourcecategoryassnid",
					Entity2Attribute = "baserecordid",
					Entity1LogicalName = "bookableresourcecategoryassn",
					Entity2LogicalName = "duplicaterecord",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N bookableresourcecategoryassn_DuplicateMatchingRecord</summary>
			public static readonly XrmFakedRelationship BookableresourcecategoryassnDuplicateMatchingRecord = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "bookableresourcecategoryassnid",
					Entity2Attribute = "duplicaterecordid",
					Entity1LogicalName = "bookableresourcecategoryassn",
					Entity2LogicalName = "duplicaterecord",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N bookableresourcecategoryassn_MailboxTrackingFolders</summary>
			public static readonly XrmFakedRelationship BookableresourcecategoryassnMailboxTrackingFolders = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "bookableresourcecategoryassnid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "bookableresourcecategoryassn",
					Entity2LogicalName = "mailboxtrackingfolder",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N bookableresourcecategoryassn_PrincipalObjectAttributeAccess</summary>
			public static readonly XrmFakedRelationship BookableresourcecategoryassnPrincipalObjectAttributeAccess = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "bookableresourcecategoryassnid",
					Entity2Attribute = "objectid",
					Entity1LogicalName = "bookableresourcecategoryassn",
					Entity2LogicalName = "principalobjectattributeaccess",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N bookableresourcecategoryassn_ProcessSession</summary>
			public static readonly XrmFakedRelationship BookableresourcecategoryassnProcessSession = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "bookableresourcecategoryassnid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "bookableresourcecategoryassn",
					Entity2LogicalName = "processsession",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N BookableResourceCategoryAssn_SyncErrors</summary>
			public static readonly XrmFakedRelationship BookableResourceCategoryAssnSyncErrors = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "bookableresourcecategoryassnid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "bookableresourcecategoryassn",
					Entity2LogicalName = "syncerror",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

		}
		#endregion

		#region Fake
		public static BookableResourceCategoryAssn Create()
		{
			var faker = new Faker<BookableResourceCategoryAssn>()
			.RuleFor(e => e.Id, fake => Guid.NewGuid())
			.RuleFor(e => e.Createdbyname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Createdbyyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.CreatedOn, fake => fake.Date.Soon())
			.RuleFor(e => e.Createdonbehalfbyname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Createdonbehalfbyyominame, fake => fake.Lorem.Word())
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
			.RuleFor(e => e.Resourcecategoryname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Resourcename, fake => fake.Lorem.Word())
			.RuleFor(e => e.Status, fake => fake.PickRandom<BookableResourceCategoryAssn.eStatus>())
			.RuleFor(e => e.StatusReason, fake => fake.PickRandom<BookableResourceCategoryAssn.eStatusReason>())
			.RuleFor(e => e.TimeZoneRuleVersionNumber, fake => fake.Random.Int())
			.RuleFor(e => e.Transactioncurrencyidname, fake => fake.Lorem.Word())
			.RuleFor(e => e.UTCConversionTimeZoneCode, fake => fake.Random.Int())
			.RuleFor(e => e.VersionNumber, fake => fake.Random.Int());
			return faker.Generate();
		}
		#endregion
	}
}

