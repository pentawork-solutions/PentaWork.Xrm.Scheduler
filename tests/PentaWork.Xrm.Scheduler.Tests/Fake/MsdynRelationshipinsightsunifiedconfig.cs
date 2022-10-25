using Bogus;
using System;
using FakeXrmEasy;
using System.Collections.Generic;
using PentaWork.Xrm.Scheduler.Proxies.Entities;

namespace PentaWork.Xrm.Scheduler.Tests.Fake
{
	public static class FakeMsdynRelationshipinsightsunifiedconfig
	{	
		#region FakeRelationships
		public static class Relationships 
		{
			/// <summary>1:N msdyn_relationshipinsightsunifiedconfig_AsyncOperations</summary>
			public static readonly XrmFakedRelationship MsdynRelationshipinsightsunifiedconfigAsyncOperations = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "msdyn_relationshipinsightsunifiedconfigid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "msdyn_relationshipinsightsunifiedconfig",
					Entity2LogicalName = "asyncoperation",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N msdyn_relationshipinsightsunifiedconfig_BulkDeleteFailures</summary>
			public static readonly XrmFakedRelationship MsdynRelationshipinsightsunifiedconfigBulkDeleteFailures = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "msdyn_relationshipinsightsunifiedconfigid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "msdyn_relationshipinsightsunifiedconfig",
					Entity2LogicalName = "bulkdeletefailure",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N msdyn_relationshipinsightsunifiedconfig_DuplicateBaseRecord</summary>
			public static readonly XrmFakedRelationship MsdynRelationshipinsightsunifiedconfigDuplicateBaseRecord = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "msdyn_relationshipinsightsunifiedconfigid",
					Entity2Attribute = "baserecordid",
					Entity1LogicalName = "msdyn_relationshipinsightsunifiedconfig",
					Entity2LogicalName = "duplicaterecord",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N msdyn_relationshipinsightsunifiedconfig_DuplicateMatchingRecord</summary>
			public static readonly XrmFakedRelationship MsdynRelationshipinsightsunifiedconfigDuplicateMatchingRecord = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "msdyn_relationshipinsightsunifiedconfigid",
					Entity2Attribute = "duplicaterecordid",
					Entity1LogicalName = "msdyn_relationshipinsightsunifiedconfig",
					Entity2LogicalName = "duplicaterecord",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N msdyn_relationshipinsightsunifiedconfig_MailboxTrackingFolders</summary>
			public static readonly XrmFakedRelationship MsdynRelationshipinsightsunifiedconfigMailboxTrackingFolders = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "msdyn_relationshipinsightsunifiedconfigid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "msdyn_relationshipinsightsunifiedconfig",
					Entity2LogicalName = "mailboxtrackingfolder",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N msdyn_relationshipinsightsunifiedconfig_PrincipalObjectAttributeAccesses</summary>
			public static readonly XrmFakedRelationship MsdynRelationshipinsightsunifiedconfigPrincipalObjectAttributeAccesses = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "msdyn_relationshipinsightsunifiedconfigid",
					Entity2Attribute = "objectid",
					Entity1LogicalName = "msdyn_relationshipinsightsunifiedconfig",
					Entity2LogicalName = "principalobjectattributeaccess",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N msdyn_relationshipinsightsunifiedconfig_ProcessSession</summary>
			public static readonly XrmFakedRelationship MsdynRelationshipinsightsunifiedconfigProcessSession = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "msdyn_relationshipinsightsunifiedconfigid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "msdyn_relationshipinsightsunifiedconfig",
					Entity2LogicalName = "processsession",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N msdyn_relationshipinsightsunifiedconfig_SyncErrors</summary>
			public static readonly XrmFakedRelationship MsdynRelationshipinsightsunifiedconfigSyncErrors = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "msdyn_relationshipinsightsunifiedconfigid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "msdyn_relationshipinsightsunifiedconfig",
					Entity2LogicalName = "syncerror",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

		}
		#endregion

		#region Fake
		public static MsdynRelationshipinsightsunifiedconfig Create()
		{
			var faker = new Faker<MsdynRelationshipinsightsunifiedconfig>()
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
			.RuleFor(e => e.MsdynUsenewconfigexperience, fake => fake.Random.Bool())
			.RuleFor(e => e.Name, fake => fake.Lorem.Word())
			.RuleFor(e => e.RecordCreatedOn, fake => fake.Date.Soon())
			.RuleFor(e => e.Owneridname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Owneridtype, fake => fake.Lorem.Word())
			.RuleFor(e => e.Owneridyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.Status, fake => fake.PickRandom<MsdynRelationshipinsightsunifiedconfig.eStatus>())
			.RuleFor(e => e.StatusReason, fake => fake.PickRandom<MsdynRelationshipinsightsunifiedconfig.eStatusReason>())
			.RuleFor(e => e.TimeZoneRuleVersionNumber, fake => fake.Random.Int())
			.RuleFor(e => e.UTCConversionTimeZoneCode, fake => fake.Random.Int())
			.RuleFor(e => e.VersionNumber, fake => fake.Random.Int());
			return faker.Generate();
		}
		#endregion
	}
}

