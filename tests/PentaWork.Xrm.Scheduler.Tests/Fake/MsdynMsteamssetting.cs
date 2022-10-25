using Bogus;
using System;
using FakeXrmEasy;
using System.Collections.Generic;
using PentaWork.Xrm.Scheduler.Proxies.Entities;

namespace PentaWork.Xrm.Scheduler.Tests.Fake
{
	public static class FakeMsdynMsteamssetting
	{	
		#region FakeRelationships
		public static class Relationships 
		{
			/// <summary>1:N msdyn_msteamssetting_AsyncOperations</summary>
			public static readonly XrmFakedRelationship MsdynMsteamssettingAsyncOperations = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "msdyn_msteamssettingid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "msdyn_msteamssetting",
					Entity2LogicalName = "asyncoperation",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N msdyn_msteamssetting_BulkDeleteFailures</summary>
			public static readonly XrmFakedRelationship MsdynMsteamssettingBulkDeleteFailures = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "msdyn_msteamssettingid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "msdyn_msteamssetting",
					Entity2LogicalName = "bulkdeletefailure",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N msdyn_msteamssetting_MailboxTrackingFolders</summary>
			public static readonly XrmFakedRelationship MsdynMsteamssettingMailboxTrackingFolders = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "msdyn_msteamssettingid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "msdyn_msteamssetting",
					Entity2LogicalName = "mailboxtrackingfolder",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N msdyn_msteamssetting_PrincipalObjectAttributeAccesses</summary>
			public static readonly XrmFakedRelationship MsdynMsteamssettingPrincipalObjectAttributeAccesses = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "msdyn_msteamssettingid",
					Entity2Attribute = "objectid",
					Entity1LogicalName = "msdyn_msteamssetting",
					Entity2LogicalName = "principalobjectattributeaccess",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N msdyn_msteamssetting_ProcessSession</summary>
			public static readonly XrmFakedRelationship MsdynMsteamssettingProcessSession = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "msdyn_msteamssettingid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "msdyn_msteamssetting",
					Entity2LogicalName = "processsession",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N msdyn_msteamssetting_SyncErrors</summary>
			public static readonly XrmFakedRelationship MsdynMsteamssettingSyncErrors = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "msdyn_msteamssettingid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "msdyn_msteamssetting",
					Entity2LogicalName = "syncerror",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

		}
		#endregion

		#region Fake
		public static MsdynMsteamssetting Create()
		{
			var faker = new Faker<MsdynMsteamssetting>()
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
			.RuleFor(e => e.MsdynMsteamssettingsId, fake => Guid.NewGuid())
			.RuleFor(e => e.MSTeamsSettingsName, fake => fake.Lorem.Word())
			.RuleFor(e => e.MsdynTabServiceUrl, fake => fake.Lorem.Word())
			.RuleFor(e => e.RecordCreatedOn, fake => fake.Date.Soon())
			.RuleFor(e => e.Owneridname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Owneridtype, fake => fake.Lorem.Word())
			.RuleFor(e => e.Owneridyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.Status, fake => fake.PickRandom<MsdynMsteamssetting.eStatus>())
			.RuleFor(e => e.StatusReason, fake => fake.PickRandom<MsdynMsteamssetting.eStatusReason>())
			.RuleFor(e => e.TimeZoneRuleVersionNumber, fake => fake.Random.Int())
			.RuleFor(e => e.UTCConversionTimeZoneCode, fake => fake.Random.Int())
			.RuleFor(e => e.VersionNumber, fake => fake.Random.Int());
			return faker.Generate();
		}
		#endregion
	}
}

