using Bogus;
using System;
using FakeXrmEasy;
using System.Collections.Generic;
using PentaWork.Xrm.Scheduler.Proxies.Entities;

namespace PentaWork.Xrm.Scheduler.Tests.Fake
{
	public static class FakeAutoCaptureRule
	{	
		#region FakeRelationships
		public static class Relationships 
		{
			/// <summary>1:N msdyn_autocapturerule_AsyncOperations</summary>
			public static readonly XrmFakedRelationship MsdynAutocaptureruleAsyncOperations = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "msdyn_autocaptureruleid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "msdyn_autocapturerule",
					Entity2LogicalName = "asyncoperation",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N msdyn_autocapturerule_BulkDeleteFailures</summary>
			public static readonly XrmFakedRelationship MsdynAutocaptureruleBulkDeleteFailures = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "msdyn_autocaptureruleid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "msdyn_autocapturerule",
					Entity2LogicalName = "bulkdeletefailure",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N msdyn_autocapturerule_DuplicateBaseRecord</summary>
			public static readonly XrmFakedRelationship MsdynAutocaptureruleDuplicateBaseRecord = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "msdyn_autocaptureruleid",
					Entity2Attribute = "baserecordid",
					Entity1LogicalName = "msdyn_autocapturerule",
					Entity2LogicalName = "duplicaterecord",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N msdyn_autocapturerule_DuplicateMatchingRecord</summary>
			public static readonly XrmFakedRelationship MsdynAutocaptureruleDuplicateMatchingRecord = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "msdyn_autocaptureruleid",
					Entity2Attribute = "duplicaterecordid",
					Entity1LogicalName = "msdyn_autocapturerule",
					Entity2LogicalName = "duplicaterecord",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N msdyn_autocapturerule_MailboxTrackingFolders</summary>
			public static readonly XrmFakedRelationship MsdynAutocaptureruleMailboxTrackingFolders = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "msdyn_autocaptureruleid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "msdyn_autocapturerule",
					Entity2LogicalName = "mailboxtrackingfolder",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N msdyn_autocapturerule_PrincipalObjectAttributeAccesses</summary>
			public static readonly XrmFakedRelationship MsdynAutocapturerulePrincipalObjectAttributeAccesses = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "msdyn_autocaptureruleid",
					Entity2Attribute = "objectid",
					Entity1LogicalName = "msdyn_autocapturerule",
					Entity2LogicalName = "principalobjectattributeaccess",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N msdyn_autocapturerule_ProcessSession</summary>
			public static readonly XrmFakedRelationship MsdynAutocaptureruleProcessSession = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "msdyn_autocaptureruleid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "msdyn_autocapturerule",
					Entity2LogicalName = "processsession",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N msdyn_autocapturerule_SyncErrors</summary>
			public static readonly XrmFakedRelationship MsdynAutocaptureruleSyncErrors = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "msdyn_autocaptureruleid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "msdyn_autocapturerule",
					Entity2LogicalName = "syncerror",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

		}
		#endregion

		#region Fake
		public static AutoCaptureRule Create()
		{
			var faker = new Faker<AutoCaptureRule>()
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
			.RuleFor(e => e.Id, fake => Guid.NewGuid())
			.RuleFor(e => e.Name, fake => fake.Lorem.Word())
			.RuleFor(e => e.RuleDataSource, fake => fake.Lorem.Word())
			.RuleFor(e => e.RuleName, fake => fake.Lorem.Word())
			.RuleFor(e => e.RuleValue, fake => fake.Lorem.Word())
			.RuleFor(e => e.RecordCreatedOn, fake => fake.Date.Soon())
			.RuleFor(e => e.Owneridname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Owneridtype, fake => fake.Lorem.Word())
			.RuleFor(e => e.Owneridyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.Status, fake => fake.PickRandom<AutoCaptureRule.eStatus>())
			.RuleFor(e => e.StatusReason, fake => fake.PickRandom<AutoCaptureRule.eStatusReason>())
			.RuleFor(e => e.TimeZoneRuleVersionNumber, fake => fake.Random.Int())
			.RuleFor(e => e.UTCConversionTimeZoneCode, fake => fake.Random.Int())
			.RuleFor(e => e.VersionNumber, fake => fake.Random.Int());
			return faker.Generate();
		}
		#endregion
	}
}

