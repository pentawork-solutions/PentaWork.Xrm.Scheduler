using Bogus;
using System;
using FakeXrmEasy;
using System.Collections.Generic;
using PentaWork.Xrm.Scheduler.Proxies.Entities;

namespace PentaWork.Xrm.Scheduler.Tests.Fake
{
	public static class FakeKnowledgeInteractionInsight
	{	
		#region FakeRelationships
		public static class Relationships 
		{
			/// <summary>1:N msdyn_knowledgeinteractioninsight_AsyncOperations</summary>
			public static readonly XrmFakedRelationship MsdynKnowledgeinteractioninsightAsyncOperations = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "msdyn_knowledgeinteractioninsightid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "msdyn_knowledgeinteractioninsight",
					Entity2LogicalName = "asyncoperation",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N msdyn_knowledgeinteractioninsight_BulkDeleteFailures</summary>
			public static readonly XrmFakedRelationship MsdynKnowledgeinteractioninsightBulkDeleteFailures = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "msdyn_knowledgeinteractioninsightid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "msdyn_knowledgeinteractioninsight",
					Entity2LogicalName = "bulkdeletefailure",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N msdyn_knowledgeinteractioninsight_DuplicateBaseRecord</summary>
			public static readonly XrmFakedRelationship MsdynKnowledgeinteractioninsightDuplicateBaseRecord = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "msdyn_knowledgeinteractioninsightid",
					Entity2Attribute = "baserecordid",
					Entity1LogicalName = "msdyn_knowledgeinteractioninsight",
					Entity2LogicalName = "duplicaterecord",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N msdyn_knowledgeinteractioninsight_DuplicateMatchingRecord</summary>
			public static readonly XrmFakedRelationship MsdynKnowledgeinteractioninsightDuplicateMatchingRecord = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "msdyn_knowledgeinteractioninsightid",
					Entity2Attribute = "duplicaterecordid",
					Entity1LogicalName = "msdyn_knowledgeinteractioninsight",
					Entity2LogicalName = "duplicaterecord",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N msdyn_knowledgeinteractioninsight_MailboxTrackingFolders</summary>
			public static readonly XrmFakedRelationship MsdynKnowledgeinteractioninsightMailboxTrackingFolders = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "msdyn_knowledgeinteractioninsightid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "msdyn_knowledgeinteractioninsight",
					Entity2LogicalName = "mailboxtrackingfolder",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N msdyn_knowledgeinteractioninsight_PrincipalObjectAttributeAccesses</summary>
			public static readonly XrmFakedRelationship MsdynKnowledgeinteractioninsightPrincipalObjectAttributeAccesses = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "msdyn_knowledgeinteractioninsightid",
					Entity2Attribute = "objectid",
					Entity1LogicalName = "msdyn_knowledgeinteractioninsight",
					Entity2LogicalName = "principalobjectattributeaccess",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N msdyn_knowledgeinteractioninsight_ProcessSession</summary>
			public static readonly XrmFakedRelationship MsdynKnowledgeinteractioninsightProcessSession = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "msdyn_knowledgeinteractioninsightid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "msdyn_knowledgeinteractioninsight",
					Entity2LogicalName = "processsession",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N msdyn_knowledgeinteractioninsight_SyncErrors</summary>
			public static readonly XrmFakedRelationship MsdynKnowledgeinteractioninsightSyncErrors = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "msdyn_knowledgeinteractioninsightid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "msdyn_knowledgeinteractioninsight",
					Entity2LogicalName = "syncerror",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

		}
		#endregion

		#region Fake
		public static KnowledgeInteractionInsight Create()
		{
			var faker = new Faker<KnowledgeInteractionInsight>()
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
			.RuleFor(e => e.ArticleRank, fake => fake.Random.Int())
			.RuleFor(e => e.ArticleRecordID, fake => fake.Lorem.Word())
			.RuleFor(e => e.ArticleRelevance, fake => fake.Random.Double())
			.RuleFor(e => e.InteractionContext, fake => fake.Lorem.Word())
			.RuleFor(e => e.InteractionType, fake => fake.Lorem.Word())
			.RuleFor(e => e.Id, fake => Guid.NewGuid())
			.RuleFor(e => e.KnowledgeOperationID, fake => fake.Lorem.Word())
			.RuleFor(e => e.KnowledgeOperationType, fake => fake.Lorem.Word())
			.RuleFor(e => e.TimeStamp, fake => fake.Date.Soon())
			.RuleFor(e => e.RecordCreatedOn, fake => fake.Date.Soon())
			.RuleFor(e => e.Owneridname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Owneridtype, fake => fake.Lorem.Word())
			.RuleFor(e => e.Owneridyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.Status, fake => fake.PickRandom<KnowledgeInteractionInsight.eStatus>())
			.RuleFor(e => e.StatusReason, fake => fake.PickRandom<KnowledgeInteractionInsight.eStatusReason>())
			.RuleFor(e => e.TimeZoneRuleVersionNumber, fake => fake.Random.Int())
			.RuleFor(e => e.UTCConversionTimeZoneCode, fake => fake.Random.Int())
			.RuleFor(e => e.VersionNumber, fake => fake.Random.Int());
			return faker.Generate();
		}
		#endregion
	}
}

