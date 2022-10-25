using Bogus;
using System;
using FakeXrmEasy;
using System.Collections.Generic;
using PentaWork.Xrm.Scheduler.Proxies.Entities;

namespace PentaWork.Xrm.Scheduler.Tests.Fake
{
	public static class FakeMsdynMsteamssettingsv2
	{	
		#region FakeRelationships
		public static class Relationships 
		{
			/// <summary>1:N msdyn_msteamssettingsv2_AsyncOperations</summary>
			public static readonly XrmFakedRelationship MsdynMsteamssettingsv2AsyncOperations = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "msdyn_msteamssettingsv2id",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "msdyn_msteamssettingsv2",
					Entity2LogicalName = "asyncoperation",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N msdyn_msteamssettingsv2_BulkDeleteFailures</summary>
			public static readonly XrmFakedRelationship MsdynMsteamssettingsv2BulkDeleteFailures = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "msdyn_msteamssettingsv2id",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "msdyn_msteamssettingsv2",
					Entity2LogicalName = "bulkdeletefailure",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N msdyn_msteamssettingsv2_MailboxTrackingFolders</summary>
			public static readonly XrmFakedRelationship MsdynMsteamssettingsv2MailboxTrackingFolders = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "msdyn_msteamssettingsv2id",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "msdyn_msteamssettingsv2",
					Entity2LogicalName = "mailboxtrackingfolder",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N msdyn_msteamssettingsv2_PrincipalObjectAttributeAccesses</summary>
			public static readonly XrmFakedRelationship MsdynMsteamssettingsv2PrincipalObjectAttributeAccesses = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "msdyn_msteamssettingsv2id",
					Entity2Attribute = "objectid",
					Entity1LogicalName = "msdyn_msteamssettingsv2",
					Entity2LogicalName = "principalobjectattributeaccess",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N msdyn_msteamssettingsv2_ProcessSession</summary>
			public static readonly XrmFakedRelationship MsdynMsteamssettingsv2ProcessSession = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "msdyn_msteamssettingsv2id",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "msdyn_msteamssettingsv2",
					Entity2LogicalName = "processsession",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N msdyn_msteamssettingsv2_SyncErrors</summary>
			public static readonly XrmFakedRelationship MsdynMsteamssettingsv2SyncErrors = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "msdyn_msteamssettingsv2id",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "msdyn_msteamssettingsv2",
					Entity2LogicalName = "syncerror",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

		}
		#endregion

		#region Fake
		public static MsdynMsteamssettingsv2 Create()
		{
			var faker = new Faker<MsdynMsteamssettingsv2>()
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
			.RuleFor(e => e.MSTeamsSettingsv2Name, fake => fake.Lorem.Word())
			.RuleFor(e => e.Id, fake => Guid.NewGuid())
			.RuleFor(e => e.MsdynTabServiceUrl, fake => fake.Lorem.Word())
			.RuleFor(e => e.RecordCreatedOn, fake => fake.Date.Soon())
			.RuleFor(e => e.Status, fake => fake.PickRandom<MsdynMsteamssettingsv2.eStatus>())
			.RuleFor(e => e.StatusReason, fake => fake.PickRandom<MsdynMsteamssettingsv2.eStatusReason>())
			.RuleFor(e => e.TimeZoneRuleVersionNumber, fake => fake.Random.Int())
			.RuleFor(e => e.UTCConversionTimeZoneCode, fake => fake.Random.Int())
			.RuleFor(e => e.VersionNumber, fake => fake.Random.Int());
			return faker.Generate();
		}
		#endregion
	}
}

