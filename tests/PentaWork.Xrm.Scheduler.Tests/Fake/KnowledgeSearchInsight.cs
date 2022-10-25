using Bogus;
using System;
using FakeXrmEasy;
using System.Collections.Generic;
using PentaWork.Xrm.Scheduler.Proxies.Entities;

namespace PentaWork.Xrm.Scheduler.Tests.Fake
{
	public static class FakeKnowledgeSearchInsight
	{	
		#region FakeRelationships
		public static class Relationships 
		{
			/// <summary>1:N msdyn_knowledgesearchinsight_AsyncOperations</summary>
			public static readonly XrmFakedRelationship MsdynKnowledgesearchinsightAsyncOperations = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "msdyn_knowledgesearchinsightid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "msdyn_knowledgesearchinsight",
					Entity2LogicalName = "asyncoperation",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N msdyn_knowledgesearchinsight_BulkDeleteFailures</summary>
			public static readonly XrmFakedRelationship MsdynKnowledgesearchinsightBulkDeleteFailures = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "msdyn_knowledgesearchinsightid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "msdyn_knowledgesearchinsight",
					Entity2LogicalName = "bulkdeletefailure",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N msdyn_knowledgesearchinsight_DuplicateBaseRecord</summary>
			public static readonly XrmFakedRelationship MsdynKnowledgesearchinsightDuplicateBaseRecord = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "msdyn_knowledgesearchinsightid",
					Entity2Attribute = "baserecordid",
					Entity1LogicalName = "msdyn_knowledgesearchinsight",
					Entity2LogicalName = "duplicaterecord",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N msdyn_knowledgesearchinsight_DuplicateMatchingRecord</summary>
			public static readonly XrmFakedRelationship MsdynKnowledgesearchinsightDuplicateMatchingRecord = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "msdyn_knowledgesearchinsightid",
					Entity2Attribute = "duplicaterecordid",
					Entity1LogicalName = "msdyn_knowledgesearchinsight",
					Entity2LogicalName = "duplicaterecord",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N msdyn_knowledgesearchinsight_MailboxTrackingFolders</summary>
			public static readonly XrmFakedRelationship MsdynKnowledgesearchinsightMailboxTrackingFolders = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "msdyn_knowledgesearchinsightid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "msdyn_knowledgesearchinsight",
					Entity2LogicalName = "mailboxtrackingfolder",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N msdyn_knowledgesearchinsight_PrincipalObjectAttributeAccesses</summary>
			public static readonly XrmFakedRelationship MsdynKnowledgesearchinsightPrincipalObjectAttributeAccesses = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "msdyn_knowledgesearchinsightid",
					Entity2Attribute = "objectid",
					Entity1LogicalName = "msdyn_knowledgesearchinsight",
					Entity2LogicalName = "principalobjectattributeaccess",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N msdyn_knowledgesearchinsight_ProcessSession</summary>
			public static readonly XrmFakedRelationship MsdynKnowledgesearchinsightProcessSession = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "msdyn_knowledgesearchinsightid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "msdyn_knowledgesearchinsight",
					Entity2LogicalName = "processsession",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N msdyn_knowledgesearchinsight_SyncErrors</summary>
			public static readonly XrmFakedRelationship MsdynKnowledgesearchinsightSyncErrors = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "msdyn_knowledgesearchinsightid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "msdyn_knowledgesearchinsight",
					Entity2LogicalName = "syncerror",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

		}
		#endregion

		#region Fake
		public static KnowledgeSearchInsight Create()
		{
			var faker = new Faker<KnowledgeSearchInsight>()
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
			.RuleFor(e => e.ApplicationName, fake => fake.Lorem.Word())
			.RuleFor(e => e.CorrelationID, fake => fake.Lorem.Word())
			.RuleFor(e => e.CustomControlID, fake => fake.Lorem.Word())
			.RuleFor(e => e.EntityRecordID, fake => fake.Lorem.Word())
			.RuleFor(e => e.EntityType, fake => fake.Lorem.Word())
			.RuleFor(e => e.Filters, fake => fake.Lorem.Word())
			.RuleFor(e => e.InitiatedBy, fake => fake.Lorem.Word())
			.RuleFor(e => e.Id, fake => Guid.NewGuid())
			.RuleFor(e => e.ResponseTime, fake => fake.Random.Int())
			.RuleFor(e => e.ResultCount, fake => fake.Random.Int())
			.RuleFor(e => e.SearchProviderID, fake => fake.Lorem.Word())
			.RuleFor(e => e.SearchProviderName, fake => fake.Lorem.Word())
			.RuleFor(e => e.SearchTerm, fake => fake.Lorem.Word())
			.RuleFor(e => e.SearchType, fake => fake.Lorem.Word())
			.RuleFor(e => e.SortBy, fake => fake.Lorem.Word())
			.RuleFor(e => e.TimeStamp, fake => fake.Date.Soon())
			.RuleFor(e => e.RecordCreatedOn, fake => fake.Date.Soon())
			.RuleFor(e => e.Owneridname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Owneridtype, fake => fake.Lorem.Word())
			.RuleFor(e => e.Owneridyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.Status, fake => fake.PickRandom<KnowledgeSearchInsight.eStatus>())
			.RuleFor(e => e.StatusReason, fake => fake.PickRandom<KnowledgeSearchInsight.eStatusReason>())
			.RuleFor(e => e.TimeZoneRuleVersionNumber, fake => fake.Random.Int())
			.RuleFor(e => e.UTCConversionTimeZoneCode, fake => fake.Random.Int())
			.RuleFor(e => e.VersionNumber, fake => fake.Random.Int());
			return faker.Generate();
		}
		#endregion
	}
}

