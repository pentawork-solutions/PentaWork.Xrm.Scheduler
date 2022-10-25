using Bogus;
using System;
using FakeXrmEasy;
using System.Collections.Generic;
using PentaWork.Xrm.Scheduler.Proxies.Entities;

namespace PentaWork.Xrm.Scheduler.Tests.Fake
{
	public static class FakeAIBuilderDatasetFile
	{	
		#region FakeRelationships
		public static class Relationships 
		{
			/// <summary>1:N msdyn_aibdatasetfile_AsyncOperations</summary>
			public static readonly XrmFakedRelationship MsdynAibdatasetfileAsyncOperations = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "msdyn_aibdatasetfileid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "msdyn_aibdatasetfile",
					Entity2LogicalName = "asyncoperation",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N msdyn_aibdatasetfile_BulkDeleteFailures</summary>
			public static readonly XrmFakedRelationship MsdynAibdatasetfileBulkDeleteFailures = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "msdyn_aibdatasetfileid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "msdyn_aibdatasetfile",
					Entity2LogicalName = "bulkdeletefailure",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N msdyn_aibdatasetfile_DuplicateBaseRecord</summary>
			public static readonly XrmFakedRelationship MsdynAibdatasetfileDuplicateBaseRecord = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "msdyn_aibdatasetfileid",
					Entity2Attribute = "baserecordid",
					Entity1LogicalName = "msdyn_aibdatasetfile",
					Entity2LogicalName = "duplicaterecord",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N msdyn_aibdatasetfile_DuplicateMatchingRecord</summary>
			public static readonly XrmFakedRelationship MsdynAibdatasetfileDuplicateMatchingRecord = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "msdyn_aibdatasetfileid",
					Entity2Attribute = "duplicaterecordid",
					Entity1LogicalName = "msdyn_aibdatasetfile",
					Entity2LogicalName = "duplicaterecord",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N msdyn_aibdatasetfile_MailboxTrackingFolders</summary>
			public static readonly XrmFakedRelationship MsdynAibdatasetfileMailboxTrackingFolders = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "msdyn_aibdatasetfileid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "msdyn_aibdatasetfile",
					Entity2LogicalName = "mailboxtrackingfolder",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N msdyn_aibdatasetfile_PrincipalObjectAttributeAccesses</summary>
			public static readonly XrmFakedRelationship MsdynAibdatasetfilePrincipalObjectAttributeAccesses = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "msdyn_aibdatasetfileid",
					Entity2Attribute = "objectid",
					Entity1LogicalName = "msdyn_aibdatasetfile",
					Entity2LogicalName = "principalobjectattributeaccess",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N msdyn_aibdatasetfile_ProcessSession</summary>
			public static readonly XrmFakedRelationship MsdynAibdatasetfileProcessSession = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "msdyn_aibdatasetfileid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "msdyn_aibdatasetfile",
					Entity2LogicalName = "processsession",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N msdyn_aibdatasetfile_SyncErrors</summary>
			public static readonly XrmFakedRelationship MsdynAibdatasetfileSyncErrors = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "msdyn_aibdatasetfileid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "msdyn_aibdatasetfile",
					Entity2LogicalName = "syncerror",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N msdyn_AIBFileAttachedData_msdyn_AIB</summary>
			public static readonly XrmFakedRelationship MsdynAIBFileAttachedDataMsdynAIB = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "msdyn_aibdatasetfileid",
					Entity2Attribute = "msdyn_aibdatasetfileid",
					Entity1LogicalName = "msdyn_aibdatasetfile",
					Entity2LogicalName = "msdyn_aibfileattacheddata",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

		}
		#endregion

		#region Fake
		public static AIBuilderDatasetFile Create()
		{
			var faker = new Faker<AIBuilderDatasetFile>()
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
			.RuleFor(e => e.MsdynAibdatasetidname, fake => fake.Lorem.Word())
			.RuleFor(e => e.MsdynAibfileidname, fake => fake.Lorem.Word())
			.RuleFor(e => e.LastModifiedDate, fake => fake.Date.Soon())
			.RuleFor(e => e.Name, fake => fake.Lorem.Word())
			.RuleFor(e => e.RecordCreatedOn, fake => fake.Date.Soon())
			.RuleFor(e => e.Owneridname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Owneridtype, fake => fake.Lorem.Word())
			.RuleFor(e => e.Owneridyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.Status, fake => fake.PickRandom<AIBuilderDatasetFile.eStatus>())
			.RuleFor(e => e.StatusReason, fake => fake.PickRandom<AIBuilderDatasetFile.eStatusReason>())
			.RuleFor(e => e.TimeZoneRuleVersionNumber, fake => fake.Random.Int())
			.RuleFor(e => e.UTCConversionTimeZoneCode, fake => fake.Random.Int())
			.RuleFor(e => e.VersionNumber, fake => fake.Random.Int());
			return faker.Generate();
		}
		#endregion
	}
}

