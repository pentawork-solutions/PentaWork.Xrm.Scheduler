using Bogus;
using System;
using FakeXrmEasy;
using System.Collections.Generic;
using PentaWork.Xrm.Scheduler.Proxies.Entities;

namespace PentaWork.Xrm.Scheduler.Tests.Fake
{
	public static class FakeSiconfig
	{	
		#region FakeRelationships
		public static class Relationships 
		{
			/// <summary>1:N msdyn_siconfig_AsyncOperations</summary>
			public static readonly XrmFakedRelationship MsdynSiconfigAsyncOperations = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "msdyn_siconfigid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "msdyn_siconfig",
					Entity2LogicalName = "asyncoperation",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N msdyn_siconfig_BulkDeleteFailures</summary>
			public static readonly XrmFakedRelationship MsdynSiconfigBulkDeleteFailures = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "msdyn_siconfigid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "msdyn_siconfig",
					Entity2LogicalName = "bulkdeletefailure",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N msdyn_siconfig_DuplicateBaseRecord</summary>
			public static readonly XrmFakedRelationship MsdynSiconfigDuplicateBaseRecord = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "msdyn_siconfigid",
					Entity2Attribute = "baserecordid",
					Entity1LogicalName = "msdyn_siconfig",
					Entity2LogicalName = "duplicaterecord",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N msdyn_siconfig_DuplicateMatchingRecord</summary>
			public static readonly XrmFakedRelationship MsdynSiconfigDuplicateMatchingRecord = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "msdyn_siconfigid",
					Entity2Attribute = "duplicaterecordid",
					Entity1LogicalName = "msdyn_siconfig",
					Entity2LogicalName = "duplicaterecord",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N msdyn_siconfig_MailboxTrackingFolders</summary>
			public static readonly XrmFakedRelationship MsdynSiconfigMailboxTrackingFolders = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "msdyn_siconfigid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "msdyn_siconfig",
					Entity2LogicalName = "mailboxtrackingfolder",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N msdyn_siconfig_PrincipalObjectAttributeAccesses</summary>
			public static readonly XrmFakedRelationship MsdynSiconfigPrincipalObjectAttributeAccesses = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "msdyn_siconfigid",
					Entity2Attribute = "objectid",
					Entity1LogicalName = "msdyn_siconfig",
					Entity2LogicalName = "principalobjectattributeaccess",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N msdyn_siconfig_ProcessSession</summary>
			public static readonly XrmFakedRelationship MsdynSiconfigProcessSession = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "msdyn_siconfigid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "msdyn_siconfig",
					Entity2LogicalName = "processsession",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N msdyn_siconfig_SyncErrors</summary>
			public static readonly XrmFakedRelationship MsdynSiconfigSyncErrors = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "msdyn_siconfigid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "msdyn_siconfig",
					Entity2LogicalName = "syncerror",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

		}
		#endregion

		#region Fake
		public static Siconfig Create()
		{
			var faker = new Faker<Siconfig>()
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
			.RuleFor(e => e.Version, fake => fake.Lorem.Word())
			.RuleFor(e => e.RecordCreatedOn, fake => fake.Date.Soon())
			.RuleFor(e => e.Owneridname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Owneridtype, fake => fake.Lorem.Word())
			.RuleFor(e => e.Owneridyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.Status, fake => fake.PickRandom<Siconfig.eStatus>())
			.RuleFor(e => e.StatusReason, fake => fake.PickRandom<Siconfig.eStatusReason>())
			.RuleFor(e => e.TimeZoneRuleVersionNumber, fake => fake.Random.Int())
			.RuleFor(e => e.UTCConversionTimeZoneCode, fake => fake.Random.Int())
			.RuleFor(e => e.VersionNumber, fake => fake.Random.Int());
			return faker.Generate();
		}
		#endregion
	}
}

