using Bogus;
using System;
using FakeXrmEasy;
using System.Collections.Generic;
using PentaWork.Xrm.Scheduler.Proxies.Entities;

namespace PentaWork.Xrm.Scheduler.Tests.Fake
{
	public static class FakeEntityRankingRule
	{	
		#region FakeRelationships
		public static class Relationships 
		{
			/// <summary>1:N msdyn_entityrankingrule_AsyncOperations</summary>
			public static readonly XrmFakedRelationship MsdynEntityrankingruleAsyncOperations = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "msdyn_entityrankingruleid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "msdyn_entityrankingrule",
					Entity2LogicalName = "asyncoperation",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N msdyn_entityrankingrule_BulkDeleteFailures</summary>
			public static readonly XrmFakedRelationship MsdynEntityrankingruleBulkDeleteFailures = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "msdyn_entityrankingruleid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "msdyn_entityrankingrule",
					Entity2LogicalName = "bulkdeletefailure",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N msdyn_entityrankingrule_MailboxTrackingFolders</summary>
			public static readonly XrmFakedRelationship MsdynEntityrankingruleMailboxTrackingFolders = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "msdyn_entityrankingruleid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "msdyn_entityrankingrule",
					Entity2LogicalName = "mailboxtrackingfolder",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N msdyn_entityrankingrule_PrincipalObjectAttributeAccesses</summary>
			public static readonly XrmFakedRelationship MsdynEntityrankingrulePrincipalObjectAttributeAccesses = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "msdyn_entityrankingruleid",
					Entity2Attribute = "objectid",
					Entity1LogicalName = "msdyn_entityrankingrule",
					Entity2LogicalName = "principalobjectattributeaccess",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N msdyn_entityrankingrule_ProcessSession</summary>
			public static readonly XrmFakedRelationship MsdynEntityrankingruleProcessSession = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "msdyn_entityrankingruleid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "msdyn_entityrankingrule",
					Entity2LogicalName = "processsession",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N msdyn_entityrankingrule_SyncErrors</summary>
			public static readonly XrmFakedRelationship MsdynEntityrankingruleSyncErrors = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "msdyn_entityrankingruleid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "msdyn_entityrankingrule",
					Entity2LogicalName = "syncerror",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

		}
		#endregion

		#region Fake
		public static EntityRankingRule Create()
		{
			var faker = new Faker<EntityRankingRule>()
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
			.RuleFor(e => e.Enabled, fake => fake.Random.Bool())
			.RuleFor(e => e.Entityname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Id, fake => Guid.NewGuid())
			.RuleFor(e => e.FetchXmlRule, fake => fake.Lorem.Word())
			.RuleFor(e => e.Name, fake => fake.Lorem.Word())
			.RuleFor(e => e.ObjectTypeCode, fake => fake.Random.Int())
			.RuleFor(e => e.OOBRule, fake => fake.Random.Bool())
			.RuleFor(e => e.Overriddenrank, fake => fake.Random.Int())
			.RuleFor(e => e.RulePriority, fake => fake.Random.Int())
			.RuleFor(e => e.RecordCreatedOn, fake => fake.Date.Soon())
			.RuleFor(e => e.Owneridname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Owneridtype, fake => fake.Lorem.Word())
			.RuleFor(e => e.Owneridyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.Status, fake => fake.PickRandom<EntityRankingRule.eStatus>())
			.RuleFor(e => e.StatusReason, fake => fake.PickRandom<EntityRankingRule.eStatusReason>())
			.RuleFor(e => e.TimeZoneRuleVersionNumber, fake => fake.Random.Int())
			.RuleFor(e => e.UTCConversionTimeZoneCode, fake => fake.Random.Int())
			.RuleFor(e => e.VersionNumber, fake => fake.Random.Int());
			return faker.Generate();
		}
		#endregion
	}
}

