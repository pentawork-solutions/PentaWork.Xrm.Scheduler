using Bogus;
using System;
using FakeXrmEasy;
using System.Collections.Generic;
using PentaWork.Xrm.Scheduler.Proxies.Entities;

namespace PentaWork.Xrm.Scheduler.Tests.Fake
{
	public static class FakeAIObjectDetectionBoundingBox
	{	
		#region FakeRelationships
		public static class Relationships 
		{
			/// <summary>1:N msdyn_aiodtrainingboundingbox_AsyncOperations</summary>
			public static readonly XrmFakedRelationship MsdynAiodtrainingboundingboxAsyncOperations = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "msdyn_aiodtrainingboundingboxid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "msdyn_aiodtrainingboundingbox",
					Entity2LogicalName = "asyncoperation",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N msdyn_aiodtrainingboundingbox_BulkDeleteFailures</summary>
			public static readonly XrmFakedRelationship MsdynAiodtrainingboundingboxBulkDeleteFailures = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "msdyn_aiodtrainingboundingboxid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "msdyn_aiodtrainingboundingbox",
					Entity2LogicalName = "bulkdeletefailure",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N msdyn_aiodtrainingboundingbox_DuplicateBaseRecord</summary>
			public static readonly XrmFakedRelationship MsdynAiodtrainingboundingboxDuplicateBaseRecord = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "msdyn_aiodtrainingboundingboxid",
					Entity2Attribute = "baserecordid",
					Entity1LogicalName = "msdyn_aiodtrainingboundingbox",
					Entity2LogicalName = "duplicaterecord",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N msdyn_aiodtrainingboundingbox_DuplicateMatchingRecord</summary>
			public static readonly XrmFakedRelationship MsdynAiodtrainingboundingboxDuplicateMatchingRecord = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "msdyn_aiodtrainingboundingboxid",
					Entity2Attribute = "duplicaterecordid",
					Entity1LogicalName = "msdyn_aiodtrainingboundingbox",
					Entity2LogicalName = "duplicaterecord",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N msdyn_aiodtrainingboundingbox_MailboxTrackingFolders</summary>
			public static readonly XrmFakedRelationship MsdynAiodtrainingboundingboxMailboxTrackingFolders = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "msdyn_aiodtrainingboundingboxid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "msdyn_aiodtrainingboundingbox",
					Entity2LogicalName = "mailboxtrackingfolder",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N msdyn_aiodtrainingboundingbox_PrincipalObjectAttributeAccesses</summary>
			public static readonly XrmFakedRelationship MsdynAiodtrainingboundingboxPrincipalObjectAttributeAccesses = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "msdyn_aiodtrainingboundingboxid",
					Entity2Attribute = "objectid",
					Entity1LogicalName = "msdyn_aiodtrainingboundingbox",
					Entity2LogicalName = "principalobjectattributeaccess",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N msdyn_aiodtrainingboundingbox_ProcessSession</summary>
			public static readonly XrmFakedRelationship MsdynAiodtrainingboundingboxProcessSession = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "msdyn_aiodtrainingboundingboxid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "msdyn_aiodtrainingboundingbox",
					Entity2LogicalName = "processsession",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N msdyn_aiodtrainingboundingbox_SyncErrors</summary>
			public static readonly XrmFakedRelationship MsdynAiodtrainingboundingboxSyncErrors = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "msdyn_aiodtrainingboundingboxid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "msdyn_aiodtrainingboundingbox",
					Entity2LogicalName = "syncerror",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

		}
		#endregion

		#region Fake
		public static AIObjectDetectionBoundingBox Create()
		{
			var faker = new Faker<AIObjectDetectionBoundingBox>()
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
			.RuleFor(e => e.MsdynAiodlabelidname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Id, fake => Guid.NewGuid())
			.RuleFor(e => e.MsdynAiodtrainingimageidname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Height, fake => fake.Random.Double())
			.RuleFor(e => e.Left, fake => fake.Random.Double())
			.RuleFor(e => e.Name, fake => fake.Lorem.Word())
			.RuleFor(e => e.Top, fake => fake.Random.Double())
			.RuleFor(e => e.Width, fake => fake.Random.Double())
			.RuleFor(e => e.RecordCreatedOn, fake => fake.Date.Soon())
			.RuleFor(e => e.Owneridname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Owneridtype, fake => fake.Lorem.Word())
			.RuleFor(e => e.Owneridyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.Status, fake => fake.PickRandom<AIObjectDetectionBoundingBox.eStatus>())
			.RuleFor(e => e.StatusReason, fake => fake.PickRandom<AIObjectDetectionBoundingBox.eStatusReason>())
			.RuleFor(e => e.TimeZoneRuleVersionNumber, fake => fake.Random.Int())
			.RuleFor(e => e.UTCConversionTimeZoneCode, fake => fake.Random.Int())
			.RuleFor(e => e.VersionNumber, fake => fake.Random.Int());
			return faker.Generate();
		}
		#endregion
	}
}

