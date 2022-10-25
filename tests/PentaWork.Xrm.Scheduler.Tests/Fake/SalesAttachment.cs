using Bogus;
using System;
using FakeXrmEasy;
using System.Collections.Generic;
using PentaWork.Xrm.Scheduler.Proxies.Entities;

namespace PentaWork.Xrm.Scheduler.Tests.Fake
{
	public static class FakeSalesAttachment
	{	
		#region FakeRelationships
		public static class Relationships 
		{
			/// <summary>1:N SalesLiteratureItem_AsyncOperations</summary>
			public static readonly XrmFakedRelationship SalesLiteratureItemAsyncOperations = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "salesliteratureitemid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "salesliteratureitem",
					Entity2LogicalName = "asyncoperation",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N SalesLiteratureItem_BulkDeleteFailures</summary>
			public static readonly XrmFakedRelationship SalesLiteratureItemBulkDeleteFailures = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "salesliteratureitemid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "salesliteratureitem",
					Entity2LogicalName = "bulkdeletefailure",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N salesliteratureitem_MailboxTrackingFolders</summary>
			public static readonly XrmFakedRelationship SalesliteratureitemMailboxTrackingFolders = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "salesliteratureitemid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "salesliteratureitem",
					Entity2LogicalName = "mailboxtrackingfolder",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N salesliteratureitem_PrincipalObjectAttributeAccesses</summary>
			public static readonly XrmFakedRelationship SalesliteratureitemPrincipalObjectAttributeAccesses = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "salesliteratureitemid",
					Entity2Attribute = "objectid",
					Entity1LogicalName = "salesliteratureitem",
					Entity2LogicalName = "principalobjectattributeaccess",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N SalesLiteratureItem_ProcessSessions</summary>
			public static readonly XrmFakedRelationship SalesLiteratureItemProcessSessions = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "salesliteratureitemid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "salesliteratureitem",
					Entity2LogicalName = "processsession",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N salesliteratureitem_SyncErrors</summary>
			public static readonly XrmFakedRelationship SalesliteratureitemSyncErrors = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "salesliteratureitemid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "salesliteratureitem",
					Entity2LogicalName = "syncerror",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

		}
		#endregion

		#region Fake
		public static SalesAttachment Create()
		{
			var faker = new Faker<SalesAttachment>()
			.RuleFor(e => e.Abstract, fake => fake.Lorem.Word())
			.RuleFor(e => e.AttachedDocumentURL, fake => fake.Lorem.Word())
			.RuleFor(e => e.AuthorName, fake => fake.Lorem.Word())
			.RuleFor(e => e.Createdbyname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Createdbyyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.CreatedOn, fake => fake.Date.Soon())
			.RuleFor(e => e.Createdonbehalfbyname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Createdonbehalfbyyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.Documentbody, fake => fake.Lorem.Word())
			.RuleFor(e => e.FileName, fake => fake.Lorem.Word())
			.RuleFor(e => e.FileSizeBytes, fake => fake.Random.Int())
			.RuleFor(e => e.Filetype, fake => fake.Random.Int())
			.RuleFor(e => e.FileType, fake => fake.PickRandom<SalesAttachment.eFileType>())
			.RuleFor(e => e.ImportSequenceNumber, fake => fake.Random.Int())
			.RuleFor(e => e.CustomerViewable, fake => fake.Random.Bool())
			.RuleFor(e => e.KeyWords, fake => fake.Lorem.Word())
			.RuleFor(e => e.MimeType, fake => fake.Lorem.Word())
			.RuleFor(e => e.Mode, fake => fake.Lorem.Word())
			.RuleFor(e => e.Modifiedbyname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Modifiedbyyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.ModifiedOn, fake => fake.Date.Soon())
			.RuleFor(e => e.Modifiedonbehalfbyname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Modifiedonbehalfbyyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.OrganizationId, fake => Guid.NewGuid())
			.RuleFor(e => e.RecordCreatedOn, fake => fake.Date.Soon())
			.RuleFor(e => e.Salesliteratureidname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Id, fake => Guid.NewGuid())
			.RuleFor(e => e.TimeZoneRuleVersionNumber, fake => fake.Random.Int())
			.RuleFor(e => e.Title, fake => fake.Lorem.Word())
			.RuleFor(e => e.UTCConversionTimeZoneCode, fake => fake.Random.Int())
			.RuleFor(e => e.VersionNumber, fake => fake.Random.Int());
			return faker.Generate();
		}
		#endregion
	}
}

