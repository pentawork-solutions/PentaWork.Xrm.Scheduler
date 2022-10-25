using Bogus;
using System;
using FakeXrmEasy;
using System.Collections.Generic;
using PentaWork.Xrm.Scheduler.Proxies.Entities;

namespace PentaWork.Xrm.Scheduler.Tests.Fake
{
	public static class FakeAttachment
	{	
		#region FakeRelationships
		public static class Relationships 
		{
			/// <summary>1:N ActivityMimeAttachment_AsyncOperations</summary>
			public static readonly XrmFakedRelationship ActivityMimeAttachmentAsyncOperations = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "activitymimeattachmentid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "activitymimeattachment",
					Entity2LogicalName = "asyncoperation",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N ActivityMimeAttachment_BulkDeleteFailures</summary>
			public static readonly XrmFakedRelationship ActivityMimeAttachmentBulkDeleteFailures = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "activitymimeattachmentid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "activitymimeattachment",
					Entity2LogicalName = "bulkdeletefailure",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N ActivityMimeAttachment_SyncErrors</summary>
			public static readonly XrmFakedRelationship ActivityMimeAttachmentSyncErrors = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "activitymimeattachmentid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "activitymimeattachment",
					Entity2LogicalName = "syncerror",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

		}
		#endregion

		#region Fake
		public static Attachment Create()
		{
			var faker = new Faker<Attachment>()
			.RuleFor(e => e.Id, fake => Guid.NewGuid())
			.RuleFor(e => e.ActivitymimeattachmentiduniqueId, fake => Guid.NewGuid())
			.RuleFor(e => e.ActivitySubject, fake => fake.Lorem.Word())
			.RuleFor(e => e.ForInternalUseOnly, fake => fake.Lorem.Word())
			.RuleFor(e => e.ContentId, fake => fake.Lorem.Word())
			.RuleFor(e => e.AttachmentNumber, fake => fake.Random.Int())
			.RuleFor(e => e.Body, fake => fake.Lorem.Word())
			.RuleFor(e => e.ComponentState, fake => fake.PickRandom<Attachment.egComponentState>())
			.RuleFor(e => e.FileName, fake => fake.Lorem.Word())
			.RuleFor(e => e.FileSizeBytes, fake => fake.Random.Int())
			.RuleFor(e => e.Followed, fake => fake.Random.Bool())
			.RuleFor(e => e.IsManaged, fake => fake.Random.Bool())
			.RuleFor(e => e.MimeType, fake => fake.Lorem.Word())
			.RuleFor(e => e.Entity, fake => fake.Lorem.Word())
			.RuleFor(e => e.RecordOverwriteTime, fake => fake.Date.Soon())
			.RuleFor(e => e.Owneridname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Owneridtype, fake => fake.Lorem.Word())
			.RuleFor(e => e.SolutionId, fake => Guid.NewGuid())
			.RuleFor(e => e.Subject, fake => fake.Lorem.Word())
			.RuleFor(e => e.SolutionId2, fake => Guid.NewGuid())
			.RuleFor(e => e.VersionNumber, fake => fake.Random.Int());
			return faker.Generate();
		}
		#endregion
	}
}

