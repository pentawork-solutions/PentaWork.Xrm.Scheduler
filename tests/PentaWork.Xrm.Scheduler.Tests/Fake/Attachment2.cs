using Bogus;
using System;
using FakeXrmEasy;
using System.Collections.Generic;
using PentaWork.Xrm.Scheduler.Proxies.Entities;

namespace PentaWork.Xrm.Scheduler.Tests.Fake
{
	public static class FakeAttachment2
	{	
		#region FakeRelationships
		public static class Relationships 
		{
			/// <summary>1:N attachment_activity_mime_attachments</summary>
			public static readonly XrmFakedRelationship AttachmentActivityMimeAttachments = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "attachmentid",
					Entity2Attribute = "attachmentid",
					Entity1LogicalName = "attachment",
					Entity2LogicalName = "activitymimeattachment",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N Attachment_SyncErrors</summary>
			public static readonly XrmFakedRelationship AttachmentSyncErrors = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "attachmentid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "attachment",
					Entity2LogicalName = "syncerror",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

		}
		#endregion

		#region Fake
		public static Attachment2 Create()
		{
			var faker = new Faker<Attachment2>()
			.RuleFor(e => e.Id, fake => Guid.NewGuid())
			.RuleFor(e => e.Body, fake => fake.Lorem.Word())
			.RuleFor(e => e.FileName, fake => fake.Lorem.Word())
			.RuleFor(e => e.FilePointer, fake => fake.Lorem.Word())
			.RuleFor(e => e.FileSizeBytes, fake => fake.Random.Int())
			.RuleFor(e => e.MIMEType, fake => fake.Lorem.Word())
			.RuleFor(e => e.Prefix, fake => fake.Lorem.Word())
			.RuleFor(e => e.StoragePointer, fake => fake.Lorem.Word())
			.RuleFor(e => e.Subject, fake => fake.Lorem.Word())
			.RuleFor(e => e.VersionNumber, fake => fake.Random.Int());
			return faker.Generate();
		}
		#endregion
	}
}

