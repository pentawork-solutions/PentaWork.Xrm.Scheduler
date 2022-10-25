using Bogus;
using System;
using FakeXrmEasy;
using System.Collections.Generic;
using PentaWork.Xrm.Scheduler.Proxies.Entities;

namespace PentaWork.Xrm.Scheduler.Tests.Fake
{
	public static class FakeUpgradeVersion
	{	
		#region FakeRelationships
		public static class Relationships 
		{
			/// <summary>1:N msdyn_msdyn_upgradeversion_msdyn_upgradestep_UpgradeVersion</summary>
			public static readonly XrmFakedRelationship MsdynMsdynUpgradeversionMsdynUpgradestepUpgradeVersion = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "msdyn_upgradeversionid",
					Entity2Attribute = "msdyn_upgradeversion",
					Entity1LogicalName = "msdyn_upgradeversion",
					Entity2LogicalName = "msdyn_upgradestep",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N msdyn_upgradeversion_AsyncOperations</summary>
			public static readonly XrmFakedRelationship MsdynUpgradeversionAsyncOperations = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "msdyn_upgradeversionid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "msdyn_upgradeversion",
					Entity2LogicalName = "asyncoperation",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N msdyn_upgradeversion_BulkDeleteFailures</summary>
			public static readonly XrmFakedRelationship MsdynUpgradeversionBulkDeleteFailures = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "msdyn_upgradeversionid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "msdyn_upgradeversion",
					Entity2LogicalName = "bulkdeletefailure",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N msdyn_upgradeversion_MailboxTrackingFolders</summary>
			public static readonly XrmFakedRelationship MsdynUpgradeversionMailboxTrackingFolders = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "msdyn_upgradeversionid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "msdyn_upgradeversion",
					Entity2LogicalName = "mailboxtrackingfolder",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N msdyn_upgradeversion_PrincipalObjectAttributeAccesses</summary>
			public static readonly XrmFakedRelationship MsdynUpgradeversionPrincipalObjectAttributeAccesses = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "msdyn_upgradeversionid",
					Entity2Attribute = "objectid",
					Entity1LogicalName = "msdyn_upgradeversion",
					Entity2LogicalName = "principalobjectattributeaccess",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N msdyn_upgradeversion_ProcessSession</summary>
			public static readonly XrmFakedRelationship MsdynUpgradeversionProcessSession = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "msdyn_upgradeversionid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "msdyn_upgradeversion",
					Entity2LogicalName = "processsession",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N msdyn_upgradeversion_SyncErrors</summary>
			public static readonly XrmFakedRelationship MsdynUpgradeversionSyncErrors = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "msdyn_upgradeversionid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "msdyn_upgradeversion",
					Entity2LogicalName = "syncerror",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

		}
		#endregion

		#region Fake
		public static UpgradeVersion Create()
		{
			var faker = new Faker<UpgradeVersion>()
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
			.RuleFor(e => e.Finished, fake => fake.Date.Soon())
			.RuleFor(e => e.StartingVersion, fake => fake.Lorem.Word())
			.RuleFor(e => e.UpgradeStatus, fake => fake.PickRandom<UpgradeVersion.egUpgradeStatus>())
			.RuleFor(e => e.Summary, fake => fake.Lorem.Word())
			.RuleFor(e => e.TargetVersion, fake => fake.Lorem.Word())
			.RuleFor(e => e.MsdynUpgraderunname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Id, fake => Guid.NewGuid())
			.RuleFor(e => e.Organizationidname, fake => fake.Lorem.Word())
			.RuleFor(e => e.RecordCreatedOn, fake => fake.Date.Soon())
			.RuleFor(e => e.Status, fake => fake.PickRandom<UpgradeVersion.eStatus>())
			.RuleFor(e => e.StatusReason, fake => fake.PickRandom<UpgradeVersion.eStatusReason>())
			.RuleFor(e => e.TimeZoneRuleVersionNumber, fake => fake.Random.Int())
			.RuleFor(e => e.UTCConversionTimeZoneCode, fake => fake.Random.Int())
			.RuleFor(e => e.VersionNumber, fake => fake.Random.Int());
			return faker.Generate();
		}
		#endregion
	}
}

