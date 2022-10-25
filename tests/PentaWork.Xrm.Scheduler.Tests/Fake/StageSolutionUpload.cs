using Bogus;
using System;
using FakeXrmEasy;
using System.Collections.Generic;
using PentaWork.Xrm.Scheduler.Proxies.Entities;

namespace PentaWork.Xrm.Scheduler.Tests.Fake
{
	public static class FakeStageSolutionUpload
	{	
		#region FakeRelationships
		public static class Relationships 
		{
			/// <summary>1:N stagesolutionupload_AsyncOperations</summary>
			public static readonly XrmFakedRelationship StagesolutionuploadAsyncOperations = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "stagesolutionuploadid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "stagesolutionupload",
					Entity2LogicalName = "asyncoperation",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N stagesolutionupload_BulkDeleteFailures</summary>
			public static readonly XrmFakedRelationship StagesolutionuploadBulkDeleteFailures = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "stagesolutionuploadid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "stagesolutionupload",
					Entity2LogicalName = "bulkdeletefailure",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N stagesolutionupload_DuplicateBaseRecord</summary>
			public static readonly XrmFakedRelationship StagesolutionuploadDuplicateBaseRecord = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "stagesolutionuploadid",
					Entity2Attribute = "baserecordid",
					Entity1LogicalName = "stagesolutionupload",
					Entity2LogicalName = "duplicaterecord",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N stagesolutionupload_DuplicateMatchingRecord</summary>
			public static readonly XrmFakedRelationship StagesolutionuploadDuplicateMatchingRecord = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "stagesolutionuploadid",
					Entity2Attribute = "duplicaterecordid",
					Entity1LogicalName = "stagesolutionupload",
					Entity2LogicalName = "duplicaterecord",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N stagesolutionupload_FileAttachments</summary>
			public static readonly XrmFakedRelationship StagesolutionuploadFileAttachments = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "stagesolutionuploadid",
					Entity2Attribute = "objectid",
					Entity1LogicalName = "stagesolutionupload",
					Entity2LogicalName = "fileattachment",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N stagesolutionupload_MailboxTrackingFolders</summary>
			public static readonly XrmFakedRelationship StagesolutionuploadMailboxTrackingFolders = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "stagesolutionuploadid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "stagesolutionupload",
					Entity2LogicalName = "mailboxtrackingfolder",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N stagesolutionupload_PrincipalObjectAttributeAccesses</summary>
			public static readonly XrmFakedRelationship StagesolutionuploadPrincipalObjectAttributeAccesses = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "stagesolutionuploadid",
					Entity2Attribute = "objectid",
					Entity1LogicalName = "stagesolutionupload",
					Entity2LogicalName = "principalobjectattributeaccess",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N stagesolutionupload_ProcessSession</summary>
			public static readonly XrmFakedRelationship StagesolutionuploadProcessSession = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "stagesolutionuploadid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "stagesolutionupload",
					Entity2LogicalName = "processsession",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N stagesolutionupload_SyncErrors</summary>
			public static readonly XrmFakedRelationship StagesolutionuploadSyncErrors = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "stagesolutionuploadid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "stagesolutionupload",
					Entity2LogicalName = "syncerror",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

		}
		#endregion

		#region Fake
		public static StageSolutionUpload Create()
		{
			var faker = new Faker<StageSolutionUpload>()
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
			.RuleFor(e => e.Name, fake => fake.Lorem.Word())
			.RuleFor(e => e.RecordCreatedOn, fake => fake.Date.Soon())
			.RuleFor(e => e.Owneridname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Owneridtype, fake => fake.Lorem.Word())
			.RuleFor(e => e.Owneridyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.SolutionfileName, fake => fake.Lorem.Word())
			.RuleFor(e => e.SolutionFileName, fake => fake.Lorem.Word())
			.RuleFor(e => e.SolutionUniqueName, fake => fake.Lorem.Word())
			.RuleFor(e => e.Id, fake => Guid.NewGuid())
			.RuleFor(e => e.Status, fake => fake.PickRandom<StageSolutionUpload.eStatus>())
			.RuleFor(e => e.StatusReason, fake => fake.PickRandom<StageSolutionUpload.eStatusReason>())
			.RuleFor(e => e.TimeZoneRuleVersionNumber, fake => fake.Random.Int())
			.RuleFor(e => e.UTCConversionTimeZoneCode, fake => fake.Random.Int())
			.RuleFor(e => e.VersionNumber, fake => fake.Random.Int());
			return faker.Generate();
		}
		#endregion
	}
}

