using Bogus;
using System;
using FakeXrmEasy;
using System.Collections.Generic;
using PentaWork.Xrm.Scheduler.Proxies.Entities;

namespace PentaWork.Xrm.Scheduler.Tests.Fake
{
	public static class FakeUpgradeStep
	{	
		#region FakeRelationships
		public static class Relationships 
		{
			/// <summary>1:N msdyn_upgradestep_AsyncOperations</summary>
			public static readonly XrmFakedRelationship MsdynUpgradestepAsyncOperations = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "msdyn_upgradestepid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "msdyn_upgradestep",
					Entity2LogicalName = "asyncoperation",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N msdyn_upgradestep_BulkDeleteFailures</summary>
			public static readonly XrmFakedRelationship MsdynUpgradestepBulkDeleteFailures = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "msdyn_upgradestepid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "msdyn_upgradestep",
					Entity2LogicalName = "bulkdeletefailure",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N msdyn_upgradestep_MailboxTrackingFolders</summary>
			public static readonly XrmFakedRelationship MsdynUpgradestepMailboxTrackingFolders = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "msdyn_upgradestepid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "msdyn_upgradestep",
					Entity2LogicalName = "mailboxtrackingfolder",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N msdyn_upgradestep_PrincipalObjectAttributeAccesses</summary>
			public static readonly XrmFakedRelationship MsdynUpgradestepPrincipalObjectAttributeAccesses = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "msdyn_upgradestepid",
					Entity2Attribute = "objectid",
					Entity1LogicalName = "msdyn_upgradestep",
					Entity2LogicalName = "principalobjectattributeaccess",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N msdyn_upgradestep_ProcessSession</summary>
			public static readonly XrmFakedRelationship MsdynUpgradestepProcessSession = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "msdyn_upgradestepid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "msdyn_upgradestep",
					Entity2LogicalName = "processsession",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N msdyn_upgradestep_SyncErrors</summary>
			public static readonly XrmFakedRelationship MsdynUpgradestepSyncErrors = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "msdyn_upgradestepid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "msdyn_upgradestep",
					Entity2LogicalName = "syncerror",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

		}
		#endregion

		#region Fake
		public static UpgradeStep Create()
		{
			var faker = new Faker<UpgradeStep>()
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
			.RuleFor(e => e.DatabaseVersion, fake => fake.Random.Int())
			.RuleFor(e => e.Details, fake => fake.Lorem.Word())
			.RuleFor(e => e.Errors, fake => fake.Lorem.Word())
			.RuleFor(e => e.FinishedDate, fake => fake.Date.Soon())
			.RuleFor(e => e.Name, fake => fake.Lorem.Word())
			.RuleFor(e => e.StepStatus, fake => fake.PickRandom<UpgradeStep.egUpgradeStatus>())
			.RuleFor(e => e.StepId, fake => Guid.NewGuid())
			.RuleFor(e => e.Id, fake => Guid.NewGuid())
			.RuleFor(e => e.MsdynUpgradeversionname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Organizationidname, fake => fake.Lorem.Word())
			.RuleFor(e => e.RecordCreatedOn, fake => fake.Date.Soon())
			.RuleFor(e => e.Status, fake => fake.PickRandom<UpgradeStep.eStatus>())
			.RuleFor(e => e.StatusReason, fake => fake.PickRandom<UpgradeStep.eStatusReason>())
			.RuleFor(e => e.TimeZoneRuleVersionNumber, fake => fake.Random.Int())
			.RuleFor(e => e.UTCConversionTimeZoneCode, fake => fake.Random.Int())
			.RuleFor(e => e.VersionNumber, fake => fake.Random.Int());
			return faker.Generate();
		}
		#endregion
	}
}

