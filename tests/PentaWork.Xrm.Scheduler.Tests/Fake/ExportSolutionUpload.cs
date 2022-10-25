using Bogus;
using System;
using FakeXrmEasy;
using System.Collections.Generic;
using PentaWork.Xrm.Scheduler.Proxies.Entities;

namespace PentaWork.Xrm.Scheduler.Tests.Fake
{
	public static class FakeExportSolutionUpload
	{	
		#region FakeRelationships
		public static class Relationships 
		{
			/// <summary>1:N exportsolutionupload_AsyncOperations</summary>
			public static readonly XrmFakedRelationship ExportsolutionuploadAsyncOperations = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "exportsolutionuploadid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "exportsolutionupload",
					Entity2LogicalName = "asyncoperation",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N exportsolutionupload_BulkDeleteFailures</summary>
			public static readonly XrmFakedRelationship ExportsolutionuploadBulkDeleteFailures = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "exportsolutionuploadid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "exportsolutionupload",
					Entity2LogicalName = "bulkdeletefailure",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N exportsolutionupload_DuplicateBaseRecord</summary>
			public static readonly XrmFakedRelationship ExportsolutionuploadDuplicateBaseRecord = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "exportsolutionuploadid",
					Entity2Attribute = "baserecordid",
					Entity1LogicalName = "exportsolutionupload",
					Entity2LogicalName = "duplicaterecord",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N exportsolutionupload_DuplicateMatchingRecord</summary>
			public static readonly XrmFakedRelationship ExportsolutionuploadDuplicateMatchingRecord = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "exportsolutionuploadid",
					Entity2Attribute = "duplicaterecordid",
					Entity1LogicalName = "exportsolutionupload",
					Entity2LogicalName = "duplicaterecord",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N exportsolutionupload_FileAttachments</summary>
			public static readonly XrmFakedRelationship ExportsolutionuploadFileAttachments = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "exportsolutionuploadid",
					Entity2Attribute = "objectid",
					Entity1LogicalName = "exportsolutionupload",
					Entity2LogicalName = "fileattachment",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N exportsolutionupload_MailboxTrackingFolders</summary>
			public static readonly XrmFakedRelationship ExportsolutionuploadMailboxTrackingFolders = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "exportsolutionuploadid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "exportsolutionupload",
					Entity2LogicalName = "mailboxtrackingfolder",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N exportsolutionupload_PrincipalObjectAttributeAccesses</summary>
			public static readonly XrmFakedRelationship ExportsolutionuploadPrincipalObjectAttributeAccesses = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "exportsolutionuploadid",
					Entity2Attribute = "objectid",
					Entity1LogicalName = "exportsolutionupload",
					Entity2LogicalName = "principalobjectattributeaccess",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N exportsolutionupload_ProcessSession</summary>
			public static readonly XrmFakedRelationship ExportsolutionuploadProcessSession = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "exportsolutionuploadid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "exportsolutionupload",
					Entity2LogicalName = "processsession",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N exportsolutionupload_SyncErrors</summary>
			public static readonly XrmFakedRelationship ExportsolutionuploadSyncErrors = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "exportsolutionuploadid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "exportsolutionupload",
					Entity2LogicalName = "syncerror",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

		}
		#endregion

		#region Fake
		public static ExportSolutionUpload Create()
		{
			var faker = new Faker<ExportSolutionUpload>()
			.RuleFor(e => e.Createdbyname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Createdbyyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.CreatedOn, fake => fake.Date.Soon())
			.RuleFor(e => e.Createdonbehalfbyname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Createdonbehalfbyyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.Id, fake => Guid.NewGuid())
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
			.RuleFor(e => e.Status, fake => fake.PickRandom<ExportSolutionUpload.eStatus>())
			.RuleFor(e => e.StatusReason, fake => fake.PickRandom<ExportSolutionUpload.eStatusReason>())
			.RuleFor(e => e.TimeZoneRuleVersionNumber, fake => fake.Random.Int())
			.RuleFor(e => e.UTCConversionTimeZoneCode, fake => fake.Random.Int())
			.RuleFor(e => e.VersionNumber, fake => fake.Random.Int());
			return faker.Generate();
		}
		#endregion
	}
}

