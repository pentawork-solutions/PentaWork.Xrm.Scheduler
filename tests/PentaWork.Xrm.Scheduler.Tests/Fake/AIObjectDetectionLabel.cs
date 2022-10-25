using Bogus;
using System;
using FakeXrmEasy;
using System.Collections.Generic;
using PentaWork.Xrm.Scheduler.Proxies.Entities;

namespace PentaWork.Xrm.Scheduler.Tests.Fake
{
	public static class FakeAIObjectDetectionLabel
	{	
		#region FakeRelationships
		public static class Relationships 
		{
			/// <summary>1:N msdyn_aiodlabel_AsyncOperations</summary>
			public static readonly XrmFakedRelationship MsdynAiodlabelAsyncOperations = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "msdyn_aiodlabelid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "msdyn_aiodlabel",
					Entity2LogicalName = "asyncoperation",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N msdyn_aiodlabel_BulkDeleteFailures</summary>
			public static readonly XrmFakedRelationship MsdynAiodlabelBulkDeleteFailures = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "msdyn_aiodlabelid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "msdyn_aiodlabel",
					Entity2LogicalName = "bulkdeletefailure",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N msdyn_aiodlabel_DuplicateBaseRecord</summary>
			public static readonly XrmFakedRelationship MsdynAiodlabelDuplicateBaseRecord = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "msdyn_aiodlabelid",
					Entity2Attribute = "baserecordid",
					Entity1LogicalName = "msdyn_aiodlabel",
					Entity2LogicalName = "duplicaterecord",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N msdyn_aiodlabel_DuplicateMatchingRecord</summary>
			public static readonly XrmFakedRelationship MsdynAiodlabelDuplicateMatchingRecord = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "msdyn_aiodlabelid",
					Entity2Attribute = "duplicaterecordid",
					Entity1LogicalName = "msdyn_aiodlabel",
					Entity2LogicalName = "duplicaterecord",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N msdyn_aiodlabel_MailboxTrackingFolders</summary>
			public static readonly XrmFakedRelationship MsdynAiodlabelMailboxTrackingFolders = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "msdyn_aiodlabelid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "msdyn_aiodlabel",
					Entity2LogicalName = "mailboxtrackingfolder",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N msdyn_aiodlabel_msdyn_aiodtrainingboundingbox</summary>
			public static readonly XrmFakedRelationship MsdynAiodlabelMsdynAiodtrainingboundingbox = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "msdyn_aiodlabelid",
					Entity2Attribute = "msdyn_aiodlabelid",
					Entity1LogicalName = "msdyn_aiodlabel",
					Entity2LogicalName = "msdyn_aiodtrainingboundingbox",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N msdyn_aiodlabel_PrincipalObjectAttributeAccesses</summary>
			public static readonly XrmFakedRelationship MsdynAiodlabelPrincipalObjectAttributeAccesses = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "msdyn_aiodlabelid",
					Entity2Attribute = "objectid",
					Entity1LogicalName = "msdyn_aiodlabel",
					Entity2LogicalName = "principalobjectattributeaccess",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N msdyn_aiodlabel_ProcessSession</summary>
			public static readonly XrmFakedRelationship MsdynAiodlabelProcessSession = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "msdyn_aiodlabelid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "msdyn_aiodlabel",
					Entity2LogicalName = "processsession",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N msdyn_aiodlabel_SyncErrors</summary>
			public static readonly XrmFakedRelationship MsdynAiodlabelSyncErrors = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "msdyn_aiodlabelid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "msdyn_aiodlabel",
					Entity2LogicalName = "syncerror",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>N:N msdyn_aiodlabel_msdyn_aiconfiguration</summary>
			public static readonly XrmFakedRelationship MsdynAiodlabelMsdynAiconfiguration = 
				new XrmFakedRelationship
				{
					IntersectEntity = "msdyn_aiodlabel_msdyn_aiconfiguration",
					Entity1Attribute = "msdyn_aiodlabelid",
					Entity2Attribute = "msdyn_aiconfigurationid",
					Entity1LogicalName = "msdyn_aiodlabel",
					Entity2LogicalName = "msdyn_aiconfiguration",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.ManyToMany
				};

		}
		#endregion

		#region Fake
		public static AIObjectDetectionLabel Create()
		{
			var faker = new Faker<AIObjectDetectionLabel>()
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
			.RuleFor(e => e.LabelString, fake => fake.Lorem.Word())
			.RuleFor(e => e.Name, fake => fake.Lorem.Word())
			.RuleFor(e => e.SourceAttributeLogicalName, fake => fake.Lorem.Word())
			.RuleFor(e => e.SourceEntityLogicalCollectionName, fake => fake.Lorem.Word())
			.RuleFor(e => e.SourceRecordId, fake => fake.Lorem.Word())
			.RuleFor(e => e.RecordCreatedOn, fake => fake.Date.Soon())
			.RuleFor(e => e.Owneridname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Owneridtype, fake => fake.Lorem.Word())
			.RuleFor(e => e.Owneridyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.Status, fake => fake.PickRandom<AIObjectDetectionLabel.eStatus>())
			.RuleFor(e => e.StatusReason, fake => fake.PickRandom<AIObjectDetectionLabel.eStatusReason>())
			.RuleFor(e => e.TimeZoneRuleVersionNumber, fake => fake.Random.Int())
			.RuleFor(e => e.UTCConversionTimeZoneCode, fake => fake.Random.Int())
			.RuleFor(e => e.VersionNumber, fake => fake.Random.Int());
			return faker.Generate();
		}
		#endregion
	}
}

