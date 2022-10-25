using Bogus;
using System;
using FakeXrmEasy;
using System.Collections.Generic;
using PentaWork.Xrm.Scheduler.Proxies.Entities;

namespace PentaWork.Xrm.Scheduler.Tests.Fake
{
	public static class FakeRichTextAttachment
	{	
		#region FakeRelationships
		public static class Relationships 
		{
			/// <summary>1:N msdyn_richtextfile_AsyncOperations</summary>
			public static readonly XrmFakedRelationship MsdynRichtextfileAsyncOperations = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "msdyn_richtextfileid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "msdyn_richtextfile",
					Entity2LogicalName = "asyncoperation",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N msdyn_richtextfile_BulkDeleteFailures</summary>
			public static readonly XrmFakedRelationship MsdynRichtextfileBulkDeleteFailures = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "msdyn_richtextfileid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "msdyn_richtextfile",
					Entity2LogicalName = "bulkdeletefailure",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N msdyn_richtextfile_FileAttachments</summary>
			public static readonly XrmFakedRelationship MsdynRichtextfileFileAttachments = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "msdyn_richtextfileid",
					Entity2Attribute = "objectid",
					Entity1LogicalName = "msdyn_richtextfile",
					Entity2LogicalName = "fileattachment",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N msdyn_richtextfile_MailboxTrackingFolders</summary>
			public static readonly XrmFakedRelationship MsdynRichtextfileMailboxTrackingFolders = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "msdyn_richtextfileid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "msdyn_richtextfile",
					Entity2LogicalName = "mailboxtrackingfolder",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N msdyn_richtextfile_PrincipalObjectAttributeAccesses</summary>
			public static readonly XrmFakedRelationship MsdynRichtextfilePrincipalObjectAttributeAccesses = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "msdyn_richtextfileid",
					Entity2Attribute = "objectid",
					Entity1LogicalName = "msdyn_richtextfile",
					Entity2LogicalName = "principalobjectattributeaccess",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N msdyn_richtextfile_ProcessSession</summary>
			public static readonly XrmFakedRelationship MsdynRichtextfileProcessSession = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "msdyn_richtextfileid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "msdyn_richtextfile",
					Entity2LogicalName = "processsession",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N msdyn_richtextfile_SyncErrors</summary>
			public static readonly XrmFakedRelationship MsdynRichtextfileSyncErrors = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "msdyn_richtextfileid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "msdyn_richtextfile",
					Entity2LogicalName = "syncerror",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

		}
		#endregion

		#region Fake
		public static RichTextAttachment Create()
		{
			var faker = new Faker<RichTextAttachment>()
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
			.RuleFor(e => e.MsdynFileblobName, fake => fake.Lorem.Word())
			.RuleFor(e => e.MsdynImageblobTimestamp, fake => fake.Random.Int())
			.RuleFor(e => e.MsdynImageblobUrl, fake => fake.Lorem.Word())
			.RuleFor(e => e.MsdynImageblobId, fake => Guid.NewGuid())
			.RuleFor(e => e.Name, fake => fake.Lorem.Word())
			.RuleFor(e => e.ParentEntityFieldName, fake => fake.Lorem.Word())
			.RuleFor(e => e.ParentEntityName, fake => fake.Lorem.Word())
			.RuleFor(e => e.ParentID, fake => fake.Lorem.Word())
			.RuleFor(e => e.Id, fake => Guid.NewGuid())
			.RuleFor(e => e.RecordCreatedOn, fake => fake.Date.Soon())
			.RuleFor(e => e.Owneridname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Owneridtype, fake => fake.Lorem.Word())
			.RuleFor(e => e.Owneridyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.Status, fake => fake.PickRandom<RichTextAttachment.eStatus>())
			.RuleFor(e => e.StatusReason, fake => fake.PickRandom<RichTextAttachment.eStatusReason>())
			.RuleFor(e => e.TimeZoneRuleVersionNumber, fake => fake.Random.Int())
			.RuleFor(e => e.UTCConversionTimeZoneCode, fake => fake.Random.Int())
			.RuleFor(e => e.VersionNumber, fake => fake.Random.Int());
			return faker.Generate();
		}
		#endregion
	}
}

