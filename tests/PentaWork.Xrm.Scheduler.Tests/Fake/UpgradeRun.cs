using Bogus;
using System;
using FakeXrmEasy;
using System.Collections.Generic;
using PentaWork.Xrm.Scheduler.Proxies.Entities;

namespace PentaWork.Xrm.Scheduler.Tests.Fake
{
	public static class FakeUpgradeRun
	{	
		#region FakeRelationships
		public static class Relationships 
		{
			/// <summary>1:N msdyn_msdyn_upgraderun_msdyn_upgradeversion_UpgradeRun</summary>
			public static readonly XrmFakedRelationship MsdynMsdynUpgraderunMsdynUpgradeversionUpgradeRun = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "msdyn_upgraderunid",
					Entity2Attribute = "msdyn_upgraderun",
					Entity1LogicalName = "msdyn_upgraderun",
					Entity2LogicalName = "msdyn_upgradeversion",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N msdyn_upgraderun_AsyncOperations</summary>
			public static readonly XrmFakedRelationship MsdynUpgraderunAsyncOperations = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "msdyn_upgraderunid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "msdyn_upgraderun",
					Entity2LogicalName = "asyncoperation",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N msdyn_upgraderun_BulkDeleteFailures</summary>
			public static readonly XrmFakedRelationship MsdynUpgraderunBulkDeleteFailures = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "msdyn_upgraderunid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "msdyn_upgraderun",
					Entity2LogicalName = "bulkdeletefailure",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N msdyn_upgraderun_MailboxTrackingFolders</summary>
			public static readonly XrmFakedRelationship MsdynUpgraderunMailboxTrackingFolders = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "msdyn_upgraderunid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "msdyn_upgraderun",
					Entity2LogicalName = "mailboxtrackingfolder",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N msdyn_upgraderun_PrincipalObjectAttributeAccesses</summary>
			public static readonly XrmFakedRelationship MsdynUpgraderunPrincipalObjectAttributeAccesses = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "msdyn_upgraderunid",
					Entity2Attribute = "objectid",
					Entity1LogicalName = "msdyn_upgraderun",
					Entity2LogicalName = "principalobjectattributeaccess",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N msdyn_upgraderun_ProcessSession</summary>
			public static readonly XrmFakedRelationship MsdynUpgraderunProcessSession = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "msdyn_upgraderunid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "msdyn_upgraderun",
					Entity2LogicalName = "processsession",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N msdyn_upgraderun_SyncErrors</summary>
			public static readonly XrmFakedRelationship MsdynUpgraderunSyncErrors = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "msdyn_upgraderunid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "msdyn_upgraderun",
					Entity2LogicalName = "syncerror",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

		}
		#endregion

		#region Fake
		public static UpgradeRun Create()
		{
			var faker = new Faker<UpgradeRun>()
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
			.RuleFor(e => e.Error, fake => fake.Lorem.Word())
			.RuleFor(e => e.FinishedDate, fake => fake.Date.Soon())
			.RuleFor(e => e.PackageName, fake => fake.Lorem.Word())
			.RuleFor(e => e.SolutionName, fake => fake.Lorem.Word())
			.RuleFor(e => e.StartingVersion, fake => fake.Lorem.Word())
			.RuleFor(e => e.RunStatus, fake => fake.PickRandom<UpgradeRun.egUpgradeStatus>())
			.RuleFor(e => e.Summary, fake => fake.Lorem.Word())
			.RuleFor(e => e.TargetVersion, fake => fake.Lorem.Word())
			.RuleFor(e => e.Id, fake => Guid.NewGuid())
			.RuleFor(e => e.Organizationidname, fake => fake.Lorem.Word())
			.RuleFor(e => e.RecordCreatedOn, fake => fake.Date.Soon())
			.RuleFor(e => e.Status, fake => fake.PickRandom<UpgradeRun.eStatus>())
			.RuleFor(e => e.StatusReason, fake => fake.PickRandom<UpgradeRun.eStatusReason>())
			.RuleFor(e => e.TimeZoneRuleVersionNumber, fake => fake.Random.Int())
			.RuleFor(e => e.UTCConversionTimeZoneCode, fake => fake.Random.Int())
			.RuleFor(e => e.VersionNumber, fake => fake.Random.Int());
			return faker.Generate();
		}
		#endregion
	}
}

