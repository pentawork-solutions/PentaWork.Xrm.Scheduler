using Bogus;
using System;
using FakeXrmEasy;
using System.Collections.Generic;
using PentaWork.Xrm.Scheduler.Proxies.Entities;

namespace PentaWork.Xrm.Scheduler.Tests.Fake
{
	public static class FakeAIObjectDetectionImageMapping
	{	
		#region FakeRelationships
		public static class Relationships 
		{
			/// <summary>1:N msdyn_aiodtrainingimage_AsyncOperations</summary>
			public static readonly XrmFakedRelationship MsdynAiodtrainingimageAsyncOperations = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "msdyn_aiodtrainingimageid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "msdyn_aiodtrainingimage",
					Entity2LogicalName = "asyncoperation",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N msdyn_aiodtrainingimage_BulkDeleteFailures</summary>
			public static readonly XrmFakedRelationship MsdynAiodtrainingimageBulkDeleteFailures = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "msdyn_aiodtrainingimageid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "msdyn_aiodtrainingimage",
					Entity2LogicalName = "bulkdeletefailure",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N msdyn_aiodtrainingimage_DuplicateBaseRecord</summary>
			public static readonly XrmFakedRelationship MsdynAiodtrainingimageDuplicateBaseRecord = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "msdyn_aiodtrainingimageid",
					Entity2Attribute = "baserecordid",
					Entity1LogicalName = "msdyn_aiodtrainingimage",
					Entity2LogicalName = "duplicaterecord",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N msdyn_aiodtrainingimage_DuplicateMatchingRecord</summary>
			public static readonly XrmFakedRelationship MsdynAiodtrainingimageDuplicateMatchingRecord = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "msdyn_aiodtrainingimageid",
					Entity2Attribute = "duplicaterecordid",
					Entity1LogicalName = "msdyn_aiodtrainingimage",
					Entity2LogicalName = "duplicaterecord",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N msdyn_aiodtrainingimage_MailboxTrackingFolders</summary>
			public static readonly XrmFakedRelationship MsdynAiodtrainingimageMailboxTrackingFolders = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "msdyn_aiodtrainingimageid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "msdyn_aiodtrainingimage",
					Entity2LogicalName = "mailboxtrackingfolder",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N msdyn_aiodtrainingimage_msdyn_aiodtrainingboundingbox</summary>
			public static readonly XrmFakedRelationship MsdynAiodtrainingimageMsdynAiodtrainingboundingbox = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "msdyn_aiodtrainingimageid",
					Entity2Attribute = "msdyn_aiodtrainingimageid",
					Entity1LogicalName = "msdyn_aiodtrainingimage",
					Entity2LogicalName = "msdyn_aiodtrainingboundingbox",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N msdyn_aiodtrainingimage_PrincipalObjectAttributeAccesses</summary>
			public static readonly XrmFakedRelationship MsdynAiodtrainingimagePrincipalObjectAttributeAccesses = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "msdyn_aiodtrainingimageid",
					Entity2Attribute = "objectid",
					Entity1LogicalName = "msdyn_aiodtrainingimage",
					Entity2LogicalName = "principalobjectattributeaccess",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N msdyn_aiodtrainingimage_ProcessSession</summary>
			public static readonly XrmFakedRelationship MsdynAiodtrainingimageProcessSession = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "msdyn_aiodtrainingimageid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "msdyn_aiodtrainingimage",
					Entity2LogicalName = "processsession",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N msdyn_aiodtrainingimage_SyncErrors</summary>
			public static readonly XrmFakedRelationship MsdynAiodtrainingimageSyncErrors = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "msdyn_aiodtrainingimageid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "msdyn_aiodtrainingimage",
					Entity2LogicalName = "syncerror",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

		}
		#endregion

		#region Fake
		public static AIObjectDetectionImageMapping Create()
		{
			var faker = new Faker<AIObjectDetectionImageMapping>()
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
			.RuleFor(e => e.MsdynAiconfigurationidname, fake => fake.Lorem.Word())
			.RuleFor(e => e.MsdynAiodimageidname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Id, fake => Guid.NewGuid())
			.RuleFor(e => e.LastModifiedDate, fake => fake.Date.Soon())
			.RuleFor(e => e.Name, fake => fake.Lorem.Word())
			.RuleFor(e => e.SourceType, fake => fake.Lorem.Word())
			.RuleFor(e => e.RecordCreatedOn, fake => fake.Date.Soon())
			.RuleFor(e => e.Owneridname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Owneridtype, fake => fake.Lorem.Word())
			.RuleFor(e => e.Owneridyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.Status, fake => fake.PickRandom<AIObjectDetectionImageMapping.eStatus>())
			.RuleFor(e => e.StatusReason, fake => fake.PickRandom<AIObjectDetectionImageMapping.eStatusReason>())
			.RuleFor(e => e.TimeZoneRuleVersionNumber, fake => fake.Random.Int())
			.RuleFor(e => e.UTCConversionTimeZoneCode, fake => fake.Random.Int())
			.RuleFor(e => e.VersionNumber, fake => fake.Random.Int());
			return faker.Generate();
		}
		#endregion
	}
}

