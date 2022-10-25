using Bogus;
using System;
using FakeXrmEasy;
using System.Collections.Generic;
using PentaWork.Xrm.Scheduler.Proxies.Entities;

namespace PentaWork.Xrm.Scheduler.Tests.Fake
{
	public static class FakeEmailTemplate
	{	
		#region FakeRelationships
		public static class Relationships 
		{
			/// <summary>1:N Email_EmailTemplate</summary>
			public static readonly XrmFakedRelationship EmailEmailTemplate = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "templateid",
					Entity2Attribute = "templateid",
					Entity1LogicalName = "template",
					Entity2LogicalName = "email",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N template_activity_mime_attachments</summary>
			public static readonly XrmFakedRelationship TemplateActivityMimeAttachments = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "templateid",
					Entity2Attribute = "objectid",
					Entity1LogicalName = "template",
					Entity2LogicalName = "activitymimeattachment",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N Template_AsyncOperations</summary>
			public static readonly XrmFakedRelationship TemplateAsyncOperations = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "templateid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "template",
					Entity2LogicalName = "asyncoperation",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N Template_BulkDeleteFailures</summary>
			public static readonly XrmFakedRelationship TemplateBulkDeleteFailures = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "templateid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "template",
					Entity2LogicalName = "bulkdeletefailure",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N Template_Organization</summary>
			public static readonly XrmFakedRelationship TemplateOrganization = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "templateid",
					Entity2Attribute = "acknowledgementtemplateid",
					Entity1LogicalName = "template",
					Entity2LogicalName = "organization",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N Template_ProcessSessions</summary>
			public static readonly XrmFakedRelationship TemplateProcessSessions = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "templateid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "template",
					Entity2LogicalName = "processsession",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N Template_SyncErrors</summary>
			public static readonly XrmFakedRelationship TemplateSyncErrors = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "templateid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "template",
					Entity2LogicalName = "syncerror",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

		}
		#endregion

		#region Fake
		public static EmailTemplate Create()
		{
			var faker = new Faker<EmailTemplate>()
			.RuleFor(e => e.Body, fake => fake.Lorem.Word())
			.RuleFor(e => e.ComponentState, fake => fake.PickRandom<EmailTemplate.egComponentState>())
			.RuleFor(e => e.Createdbyname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Createdbyyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.CreatedOn, fake => fake.Date.Soon())
			.RuleFor(e => e.Createdonbehalfbyname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Createdonbehalfbyyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.Description, fake => fake.Lorem.Word())
			.RuleFor(e => e.EntityimageTimestamp, fake => fake.Random.Int())
			.RuleFor(e => e.EntityimageUrl, fake => fake.Lorem.Word())
			.RuleFor(e => e.EntityimageId, fake => Guid.NewGuid())
			.RuleFor(e => e.GenerationTypeCode, fake => fake.Random.Int())
			.RuleFor(e => e.ImportSequenceNumber, fake => fake.Random.Int())
			.RuleFor(e => e.IntroducedVersion, fake => fake.Lorem.Word())
			.RuleFor(e => e.IsManaged, fake => fake.Random.Bool())
			.RuleFor(e => e.ViewableBy, fake => fake.Random.Bool())
			.RuleFor(e => e.Recommended, fake => fake.Random.Bool())
			.RuleFor(e => e.Language, fake => fake.Random.Int())
			.RuleFor(e => e.MimeType, fake => fake.Lorem.Word())
			.RuleFor(e => e.Modifiedbyname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Modifiedbyyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.ModifiedOn, fake => fake.Date.Soon())
			.RuleFor(e => e.Modifiedonbehalfbyname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Modifiedonbehalfbyyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.OpenCount, fake => fake.Random.Int())
			.RuleFor(e => e.OpenRate, fake => fake.Random.Int())
			.RuleFor(e => e.RecordOverwriteTime, fake => fake.Date.Soon())
			.RuleFor(e => e.Owneridname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Owneridtype, fake => fake.Lorem.Word())
			.RuleFor(e => e.Owneridyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.PresentationXML, fake => fake.Lorem.Word())
			.RuleFor(e => e.ReplyCount, fake => fake.Random.Int())
			.RuleFor(e => e.ReplyRate, fake => fake.Random.Int())
			.RuleFor(e => e.SafeHTMLOfEmailTemplate, fake => fake.Lorem.Word())
			.RuleFor(e => e.SolutionId, fake => Guid.NewGuid())
			.RuleFor(e => e.Subject, fake => fake.Lorem.Word())
			.RuleFor(e => e.SubjectXML, fake => fake.Lorem.Word())
			.RuleFor(e => e.SafeHTMLOfEmailTemplateSubject, fake => fake.Lorem.Word())
			.RuleFor(e => e.SolutionId2, fake => Guid.NewGuid())
			.RuleFor(e => e.Id, fake => Guid.NewGuid())
			.RuleFor(e => e.TemplateiduniqueId, fake => Guid.NewGuid())
			.RuleFor(e => e.TemplateType, fake => fake.Lorem.Word())
			.RuleFor(e => e.Title, fake => fake.Lorem.Word())
			.RuleFor(e => e.SentEmailCount, fake => fake.Random.Int())
			.RuleFor(e => e.VersionNumber, fake => fake.Random.Int());
			return faker.Generate();
		}
		#endregion
	}
}

