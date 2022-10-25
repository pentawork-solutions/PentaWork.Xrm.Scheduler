using Bogus;
using System;
using FakeXrmEasy;
using System.Collections.Generic;
using PentaWork.Xrm.Scheduler.Proxies.Entities;

namespace PentaWork.Xrm.Scheduler.Tests.Fake
{
	public static class FakeAIBuilderDatasetRecord
	{	
		#region FakeRelationships
		public static class Relationships 
		{
			/// <summary>1:N msdyn_aibdatasetrecord_AsyncOperations</summary>
			public static readonly XrmFakedRelationship MsdynAibdatasetrecordAsyncOperations = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "msdyn_aibdatasetrecordid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "msdyn_aibdatasetrecord",
					Entity2LogicalName = "asyncoperation",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N msdyn_aibdatasetrecord_BulkDeleteFailures</summary>
			public static readonly XrmFakedRelationship MsdynAibdatasetrecordBulkDeleteFailures = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "msdyn_aibdatasetrecordid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "msdyn_aibdatasetrecord",
					Entity2LogicalName = "bulkdeletefailure",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N msdyn_aibdatasetrecord_DuplicateBaseRecord</summary>
			public static readonly XrmFakedRelationship MsdynAibdatasetrecordDuplicateBaseRecord = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "msdyn_aibdatasetrecordid",
					Entity2Attribute = "baserecordid",
					Entity1LogicalName = "msdyn_aibdatasetrecord",
					Entity2LogicalName = "duplicaterecord",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N msdyn_aibdatasetrecord_DuplicateMatchingRecord</summary>
			public static readonly XrmFakedRelationship MsdynAibdatasetrecordDuplicateMatchingRecord = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "msdyn_aibdatasetrecordid",
					Entity2Attribute = "duplicaterecordid",
					Entity1LogicalName = "msdyn_aibdatasetrecord",
					Entity2LogicalName = "duplicaterecord",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N msdyn_aibdatasetrecord_MailboxTrackingFolders</summary>
			public static readonly XrmFakedRelationship MsdynAibdatasetrecordMailboxTrackingFolders = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "msdyn_aibdatasetrecordid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "msdyn_aibdatasetrecord",
					Entity2LogicalName = "mailboxtrackingfolder",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N msdyn_aibdatasetrecord_PrincipalObjectAttributeAccesses</summary>
			public static readonly XrmFakedRelationship MsdynAibdatasetrecordPrincipalObjectAttributeAccesses = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "msdyn_aibdatasetrecordid",
					Entity2Attribute = "objectid",
					Entity1LogicalName = "msdyn_aibdatasetrecord",
					Entity2LogicalName = "principalobjectattributeaccess",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N msdyn_aibdatasetrecord_ProcessSession</summary>
			public static readonly XrmFakedRelationship MsdynAibdatasetrecordProcessSession = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "msdyn_aibdatasetrecordid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "msdyn_aibdatasetrecord",
					Entity2LogicalName = "processsession",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N msdyn_aibdatasetrecord_SyncErrors</summary>
			public static readonly XrmFakedRelationship MsdynAibdatasetrecordSyncErrors = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "msdyn_aibdatasetrecordid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "msdyn_aibdatasetrecord",
					Entity2LogicalName = "syncerror",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

		}
		#endregion

		#region Fake
		public static AIBuilderDatasetRecord Create()
		{
			var faker = new Faker<AIBuilderDatasetRecord>()
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
			.RuleFor(e => e.MsdynAibdatasetsidname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Data, fake => fake.Lorem.Word())
			.RuleFor(e => e.Name, fake => fake.Lorem.Word())
			.RuleFor(e => e.RecordType, fake => fake.PickRandom<AIBuilderDatasetRecord.eRecordType>())
			.RuleFor(e => e.RecordCreatedOn, fake => fake.Date.Soon())
			.RuleFor(e => e.Owneridname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Owneridtype, fake => fake.Lorem.Word())
			.RuleFor(e => e.Owneridyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.Status, fake => fake.PickRandom<AIBuilderDatasetRecord.eStatus>())
			.RuleFor(e => e.StatusReason, fake => fake.PickRandom<AIBuilderDatasetRecord.eStatusReason>())
			.RuleFor(e => e.TimeZoneRuleVersionNumber, fake => fake.Random.Int())
			.RuleFor(e => e.UTCConversionTimeZoneCode, fake => fake.Random.Int())
			.RuleFor(e => e.VersionNumber, fake => fake.Random.Int());
			return faker.Generate();
		}
		#endregion
	}
}

