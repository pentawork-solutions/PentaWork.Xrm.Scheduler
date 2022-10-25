using Bogus;
using System;
using FakeXrmEasy;
using System.Collections.Generic;
using PentaWork.Xrm.Scheduler.Proxies.Entities;

namespace PentaWork.Xrm.Scheduler.Tests.Fake
{
	public static class FakePlaybookCategory
	{	
		#region FakeRelationships
		public static class Relationships 
		{
			/// <summary>1:N category_playbooktemplate</summary>
			public static readonly XrmFakedRelationship CategoryPlaybooktemplate = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "msdyn_playbookcategoryid",
					Entity2Attribute = "msdyn_categoryid",
					Entity1LogicalName = "msdyn_playbookcategory",
					Entity2LogicalName = "msdyn_playbooktemplate",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N msdyn_playbookcategory_AsyncOperations</summary>
			public static readonly XrmFakedRelationship MsdynPlaybookcategoryAsyncOperations = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "msdyn_playbookcategoryid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "msdyn_playbookcategory",
					Entity2LogicalName = "asyncoperation",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N msdyn_playbookcategory_BulkDeleteFailures</summary>
			public static readonly XrmFakedRelationship MsdynPlaybookcategoryBulkDeleteFailures = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "msdyn_playbookcategoryid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "msdyn_playbookcategory",
					Entity2LogicalName = "bulkdeletefailure",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N msdyn_playbookcategory_DuplicateBaseRecord</summary>
			public static readonly XrmFakedRelationship MsdynPlaybookcategoryDuplicateBaseRecord = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "msdyn_playbookcategoryid",
					Entity2Attribute = "baserecordid",
					Entity1LogicalName = "msdyn_playbookcategory",
					Entity2LogicalName = "duplicaterecord",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N msdyn_playbookcategory_DuplicateMatchingRecord</summary>
			public static readonly XrmFakedRelationship MsdynPlaybookcategoryDuplicateMatchingRecord = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "msdyn_playbookcategoryid",
					Entity2Attribute = "duplicaterecordid",
					Entity1LogicalName = "msdyn_playbookcategory",
					Entity2LogicalName = "duplicaterecord",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N msdyn_playbookcategory_MailboxTrackingFolders</summary>
			public static readonly XrmFakedRelationship MsdynPlaybookcategoryMailboxTrackingFolders = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "msdyn_playbookcategoryid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "msdyn_playbookcategory",
					Entity2LogicalName = "mailboxtrackingfolder",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N msdyn_playbookcategory_msdyn_playbookinstance</summary>
			public static readonly XrmFakedRelationship MsdynPlaybookcategoryMsdynPlaybookinstance = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "msdyn_playbookcategoryid",
					Entity2Attribute = "msdyn_categoryid",
					Entity1LogicalName = "msdyn_playbookcategory",
					Entity2LogicalName = "msdyn_playbookinstance",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N msdyn_playbookcategory_PrincipalObjectAttributeAccesses</summary>
			public static readonly XrmFakedRelationship MsdynPlaybookcategoryPrincipalObjectAttributeAccesses = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "msdyn_playbookcategoryid",
					Entity2Attribute = "objectid",
					Entity1LogicalName = "msdyn_playbookcategory",
					Entity2LogicalName = "principalobjectattributeaccess",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N msdyn_playbookcategory_ProcessSession</summary>
			public static readonly XrmFakedRelationship MsdynPlaybookcategoryProcessSession = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "msdyn_playbookcategoryid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "msdyn_playbookcategory",
					Entity2LogicalName = "processsession",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N msdyn_playbookcategory_SyncErrors</summary>
			public static readonly XrmFakedRelationship MsdynPlaybookcategorySyncErrors = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "msdyn_playbookcategoryid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "msdyn_playbookcategory",
					Entity2LogicalName = "syncerror",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

		}
		#endregion

		#region Fake
		public static PlaybookCategory Create()
		{
			var faker = new Faker<PlaybookCategory>()
			.RuleFor(e => e.Createdbyname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Createdbyyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.CreatedOn, fake => fake.Date.Soon())
			.RuleFor(e => e.Createdonbehalfbyname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Createdonbehalfbyyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.ImportSequenceNumber, fake => fake.Random.Int())
			.RuleFor(e => e.Modifiedbyname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Modifiedbyyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.ModifiedOn, fake => fake.Date.Soon())
			.RuleFor(e => e.Modifiedonbehalfbyname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Modifiedonbehalfbyyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.Description, fake => fake.Lorem.Word())
			.RuleFor(e => e.Name, fake => fake.Lorem.Word())
			.RuleFor(e => e.Id, fake => Guid.NewGuid())
			.RuleFor(e => e.RecordCreatedOn, fake => fake.Date.Soon())
			.RuleFor(e => e.Owneridname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Owneridtype, fake => fake.Lorem.Word())
			.RuleFor(e => e.Owneridyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.Status, fake => fake.PickRandom<PlaybookCategory.eStatus>())
			.RuleFor(e => e.StatusReason, fake => fake.PickRandom<PlaybookCategory.eStatusReason>())
			.RuleFor(e => e.TimeZoneRuleVersionNumber, fake => fake.Random.Int())
			.RuleFor(e => e.UTCConversionTimeZoneCode, fake => fake.Random.Int())
			.RuleFor(e => e.VersionNumber, fake => fake.Random.Int());
			return faker.Generate();
		}
		#endregion
	}
}

