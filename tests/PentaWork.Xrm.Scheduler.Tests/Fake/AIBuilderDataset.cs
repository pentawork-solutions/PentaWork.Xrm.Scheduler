using Bogus;
using System;
using FakeXrmEasy;
using System.Collections.Generic;
using PentaWork.Xrm.Scheduler.Proxies.Entities;

namespace PentaWork.Xrm.Scheduler.Tests.Fake
{
	public static class FakeAIBuilderDataset
	{	
		#region FakeRelationships
		public static class Relationships 
		{
			/// <summary>1:N msdyn_aibdataset_AsyncOperations</summary>
			public static readonly XrmFakedRelationship MsdynAibdatasetAsyncOperations = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "msdyn_aibdatasetid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "msdyn_aibdataset",
					Entity2LogicalName = "asyncoperation",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N msdyn_aibdataset_BulkDeleteFailures</summary>
			public static readonly XrmFakedRelationship MsdynAibdatasetBulkDeleteFailures = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "msdyn_aibdatasetid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "msdyn_aibdataset",
					Entity2LogicalName = "bulkdeletefailure",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N msdyn_aibdataset_DuplicateBaseRecord</summary>
			public static readonly XrmFakedRelationship MsdynAibdatasetDuplicateBaseRecord = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "msdyn_aibdatasetid",
					Entity2Attribute = "baserecordid",
					Entity1LogicalName = "msdyn_aibdataset",
					Entity2LogicalName = "duplicaterecord",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N msdyn_aibdataset_DuplicateMatchingRecord</summary>
			public static readonly XrmFakedRelationship MsdynAibdatasetDuplicateMatchingRecord = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "msdyn_aibdatasetid",
					Entity2Attribute = "duplicaterecordid",
					Entity1LogicalName = "msdyn_aibdataset",
					Entity2LogicalName = "duplicaterecord",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N msdyn_aibdataset_MailboxTrackingFolders</summary>
			public static readonly XrmFakedRelationship MsdynAibdatasetMailboxTrackingFolders = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "msdyn_aibdatasetid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "msdyn_aibdataset",
					Entity2LogicalName = "mailboxtrackingfolder",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N msdyn_aibdataset_PrincipalObjectAttributeAccesses</summary>
			public static readonly XrmFakedRelationship MsdynAibdatasetPrincipalObjectAttributeAccesses = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "msdyn_aibdatasetid",
					Entity2Attribute = "objectid",
					Entity1LogicalName = "msdyn_aibdataset",
					Entity2LogicalName = "principalobjectattributeaccess",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N msdyn_aibdataset_ProcessSession</summary>
			public static readonly XrmFakedRelationship MsdynAibdatasetProcessSession = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "msdyn_aibdatasetid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "msdyn_aibdataset",
					Entity2LogicalName = "processsession",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N msdyn_aibdataset_SyncErrors</summary>
			public static readonly XrmFakedRelationship MsdynAibdatasetSyncErrors = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "msdyn_aibdatasetid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "msdyn_aibdataset",
					Entity2LogicalName = "syncerror",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N msdyn_AIBDatasetFile_msdyn_AIBDatas</summary>
			public static readonly XrmFakedRelationship MsdynAIBDatasetFileMsdynAIBDatas = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "msdyn_aibdatasetid",
					Entity2Attribute = "msdyn_aibdatasetid",
					Entity1LogicalName = "msdyn_aibdataset",
					Entity2LogicalName = "msdyn_aibdatasetfile",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N msdyn_AIBDatasetRecord_msdyn_AIBDataset</summary>
			public static readonly XrmFakedRelationship MsdynAIBDatasetRecordMsdynAIBDataset = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "msdyn_aibdatasetid",
					Entity2Attribute = "msdyn_aibdatasetsid",
					Entity1LogicalName = "msdyn_aibdataset",
					Entity2LogicalName = "msdyn_aibdatasetrecord",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

		}
		#endregion

		#region Fake
		public static AIBuilderDataset Create()
		{
			var faker = new Faker<AIBuilderDataset>()
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
			.RuleFor(e => e.MsdynAibdatasetscontaineridname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Metadata, fake => fake.Lorem.Word())
			.RuleFor(e => e.Name, fake => fake.Lorem.Word())
			.RuleFor(e => e.RecordCreatedOn, fake => fake.Date.Soon())
			.RuleFor(e => e.Owneridname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Owneridtype, fake => fake.Lorem.Word())
			.RuleFor(e => e.Owneridyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.Status, fake => fake.PickRandom<AIBuilderDataset.eStatus>())
			.RuleFor(e => e.StatusReason, fake => fake.PickRandom<AIBuilderDataset.eStatusReason>())
			.RuleFor(e => e.TimeZoneRuleVersionNumber, fake => fake.Random.Int())
			.RuleFor(e => e.UTCConversionTimeZoneCode, fake => fake.Random.Int())
			.RuleFor(e => e.VersionNumber, fake => fake.Random.Int());
			return faker.Generate();
		}
		#endregion
	}
}

