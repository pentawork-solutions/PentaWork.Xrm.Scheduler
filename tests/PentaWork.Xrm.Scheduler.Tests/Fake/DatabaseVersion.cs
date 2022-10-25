using Bogus;
using System;
using FakeXrmEasy;
using System.Collections.Generic;
using PentaWork.Xrm.Scheduler.Proxies.Entities;

namespace PentaWork.Xrm.Scheduler.Tests.Fake
{
	public static class FakeDatabaseVersion
	{	
		#region FakeRelationships
		public static class Relationships 
		{
			/// <summary>1:N msdyn_databaseversion_AsyncOperations</summary>
			public static readonly XrmFakedRelationship MsdynDatabaseversionAsyncOperations = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "msdyn_databaseversionid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "msdyn_databaseversion",
					Entity2LogicalName = "asyncoperation",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N msdyn_databaseversion_BulkDeleteFailures</summary>
			public static readonly XrmFakedRelationship MsdynDatabaseversionBulkDeleteFailures = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "msdyn_databaseversionid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "msdyn_databaseversion",
					Entity2LogicalName = "bulkdeletefailure",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N msdyn_databaseversion_MailboxTrackingFolders</summary>
			public static readonly XrmFakedRelationship MsdynDatabaseversionMailboxTrackingFolders = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "msdyn_databaseversionid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "msdyn_databaseversion",
					Entity2LogicalName = "mailboxtrackingfolder",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N msdyn_databaseversion_PrincipalObjectAttributeAccesses</summary>
			public static readonly XrmFakedRelationship MsdynDatabaseversionPrincipalObjectAttributeAccesses = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "msdyn_databaseversionid",
					Entity2Attribute = "objectid",
					Entity1LogicalName = "msdyn_databaseversion",
					Entity2LogicalName = "principalobjectattributeaccess",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N msdyn_databaseversion_ProcessSession</summary>
			public static readonly XrmFakedRelationship MsdynDatabaseversionProcessSession = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "msdyn_databaseversionid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "msdyn_databaseversion",
					Entity2LogicalName = "processsession",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N msdyn_databaseversion_SyncErrors</summary>
			public static readonly XrmFakedRelationship MsdynDatabaseversionSyncErrors = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "msdyn_databaseversionid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "msdyn_databaseversion",
					Entity2LogicalName = "syncerror",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

		}
		#endregion

		#region Fake
		public static DatabaseVersion Create()
		{
			var faker = new Faker<DatabaseVersion>()
			.RuleFor(e => e.Createdbyname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Createdbyyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.Started, fake => fake.Date.Soon())
			.RuleFor(e => e.Createdonbehalfbyname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Createdonbehalfbyyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.ImportSequenceNumber, fake => fake.Random.Int())
			.RuleFor(e => e.Modifiedbyname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Modifiedbyyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.ModifiedOn, fake => fake.Date.Soon())
			.RuleFor(e => e.Modifiedonbehalfbyname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Modifiedonbehalfbyyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.Id, fake => Guid.NewGuid())
			.RuleFor(e => e.DatabaseVersion2, fake => fake.Random.Int())
			.RuleFor(e => e.SolutionName, fake => fake.Lorem.Word())
			.RuleFor(e => e.Organizationidname, fake => fake.Lorem.Word())
			.RuleFor(e => e.RecordCreatedOn, fake => fake.Date.Soon())
			.RuleFor(e => e.Status, fake => fake.PickRandom<DatabaseVersion.eStatus>())
			.RuleFor(e => e.StatusReason, fake => fake.PickRandom<DatabaseVersion.eStatusReason>())
			.RuleFor(e => e.TimeZoneRuleVersionNumber, fake => fake.Random.Int())
			.RuleFor(e => e.UTCConversionTimeZoneCode, fake => fake.Random.Int())
			.RuleFor(e => e.VersionNumber, fake => fake.Random.Int());
			return faker.Generate();
		}
		#endregion
	}
}

