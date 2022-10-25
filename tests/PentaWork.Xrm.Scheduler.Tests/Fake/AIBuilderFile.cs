using Bogus;
using System;
using FakeXrmEasy;
using System.Collections.Generic;
using PentaWork.Xrm.Scheduler.Proxies.Entities;

namespace PentaWork.Xrm.Scheduler.Tests.Fake
{
	public static class FakeAIBuilderFile
	{	
		#region FakeRelationships
		public static class Relationships 
		{
			/// <summary>1:N msdyn_AIBDatasetFile_msdyn_AIBuilde</summary>
			public static readonly XrmFakedRelationship MsdynAIBDatasetFileMsdynAIBuilde = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "msdyn_aibfileid",
					Entity2Attribute = "msdyn_aibfileid",
					Entity1LogicalName = "msdyn_aibfile",
					Entity2LogicalName = "msdyn_aibdatasetfile",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N msdyn_aibfile_AsyncOperations</summary>
			public static readonly XrmFakedRelationship MsdynAibfileAsyncOperations = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "msdyn_aibfileid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "msdyn_aibfile",
					Entity2LogicalName = "asyncoperation",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N msdyn_aibfile_BulkDeleteFailures</summary>
			public static readonly XrmFakedRelationship MsdynAibfileBulkDeleteFailures = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "msdyn_aibfileid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "msdyn_aibfile",
					Entity2LogicalName = "bulkdeletefailure",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N msdyn_aibfile_DuplicateBaseRecord</summary>
			public static readonly XrmFakedRelationship MsdynAibfileDuplicateBaseRecord = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "msdyn_aibfileid",
					Entity2Attribute = "baserecordid",
					Entity1LogicalName = "msdyn_aibfile",
					Entity2LogicalName = "duplicaterecord",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N msdyn_aibfile_DuplicateMatchingRecord</summary>
			public static readonly XrmFakedRelationship MsdynAibfileDuplicateMatchingRecord = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "msdyn_aibfileid",
					Entity2Attribute = "duplicaterecordid",
					Entity1LogicalName = "msdyn_aibfile",
					Entity2LogicalName = "duplicaterecord",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N msdyn_aibfile_FileAttachments</summary>
			public static readonly XrmFakedRelationship MsdynAibfileFileAttachments = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "msdyn_aibfileid",
					Entity2Attribute = "objectid",
					Entity1LogicalName = "msdyn_aibfile",
					Entity2LogicalName = "fileattachment",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N msdyn_aibfile_MailboxTrackingFolders</summary>
			public static readonly XrmFakedRelationship MsdynAibfileMailboxTrackingFolders = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "msdyn_aibfileid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "msdyn_aibfile",
					Entity2LogicalName = "mailboxtrackingfolder",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N msdyn_aibfile_PrincipalObjectAttributeAccesses</summary>
			public static readonly XrmFakedRelationship MsdynAibfilePrincipalObjectAttributeAccesses = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "msdyn_aibfileid",
					Entity2Attribute = "objectid",
					Entity1LogicalName = "msdyn_aibfile",
					Entity2LogicalName = "principalobjectattributeaccess",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N msdyn_aibfile_ProcessSession</summary>
			public static readonly XrmFakedRelationship MsdynAibfileProcessSession = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "msdyn_aibfileid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "msdyn_aibfile",
					Entity2LogicalName = "processsession",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N msdyn_aibfile_SyncErrors</summary>
			public static readonly XrmFakedRelationship MsdynAibfileSyncErrors = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "msdyn_aibfileid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "msdyn_aibfile",
					Entity2LogicalName = "syncerror",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

		}
		#endregion

		#region Fake
		public static AIBuilderFile Create()
		{
			var faker = new Faker<AIBuilderFile>()
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
			.RuleFor(e => e.MsdynAibdatasetscontaineridname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Id, fake => Guid.NewGuid())
			.RuleFor(e => e.Checksum, fake => fake.Lorem.Word())
			.RuleFor(e => e.MsdynFileName, fake => fake.Lorem.Word())
			.RuleFor(e => e.MsdynImageTimestamp, fake => fake.Random.Int())
			.RuleFor(e => e.MsdynImageUrl, fake => fake.Lorem.Word())
			.RuleFor(e => e.MsdynImageId, fake => Guid.NewGuid())
			.RuleFor(e => e.ImportMetadata, fake => fake.Lorem.Word())
			.RuleFor(e => e.MimeType, fake => fake.Lorem.Word())
			.RuleFor(e => e.Name, fake => fake.Lorem.Word())
			.RuleFor(e => e.Size, fake => fake.Random.Int())
			.RuleFor(e => e.RecordCreatedOn, fake => fake.Date.Soon())
			.RuleFor(e => e.Owneridname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Owneridtype, fake => fake.Lorem.Word())
			.RuleFor(e => e.Owneridyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.Status, fake => fake.PickRandom<AIBuilderFile.eStatus>())
			.RuleFor(e => e.StatusReason, fake => fake.PickRandom<AIBuilderFile.eStatusReason>())
			.RuleFor(e => e.TimeZoneRuleVersionNumber, fake => fake.Random.Int())
			.RuleFor(e => e.UTCConversionTimeZoneCode, fake => fake.Random.Int())
			.RuleFor(e => e.VersionNumber, fake => fake.Random.Int());
			return faker.Generate();
		}
		#endregion
	}
}

