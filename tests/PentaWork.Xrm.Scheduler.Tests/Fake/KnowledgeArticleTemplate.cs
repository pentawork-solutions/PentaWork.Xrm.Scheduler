using Bogus;
using System;
using FakeXrmEasy;
using System.Collections.Generic;
using PentaWork.Xrm.Scheduler.Proxies.Entities;

namespace PentaWork.Xrm.Scheduler.Tests.Fake
{
	public static class FakeKnowledgeArticleTemplate
	{	
		#region FakeRelationships
		public static class Relationships 
		{
			/// <summary>1:N msdyn_knowledgearticletemplate_AsyncOperations</summary>
			public static readonly XrmFakedRelationship MsdynKnowledgearticletemplateAsyncOperations = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "msdyn_knowledgearticletemplateid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "msdyn_knowledgearticletemplate",
					Entity2LogicalName = "asyncoperation",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N msdyn_knowledgearticletemplate_BulkDeleteFailures</summary>
			public static readonly XrmFakedRelationship MsdynKnowledgearticletemplateBulkDeleteFailures = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "msdyn_knowledgearticletemplateid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "msdyn_knowledgearticletemplate",
					Entity2LogicalName = "bulkdeletefailure",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N msdyn_knowledgearticletemplate_DuplicateBaseRecord</summary>
			public static readonly XrmFakedRelationship MsdynKnowledgearticletemplateDuplicateBaseRecord = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "msdyn_knowledgearticletemplateid",
					Entity2Attribute = "baserecordid",
					Entity1LogicalName = "msdyn_knowledgearticletemplate",
					Entity2LogicalName = "duplicaterecord",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N msdyn_knowledgearticletemplate_DuplicateMatchingRecord</summary>
			public static readonly XrmFakedRelationship MsdynKnowledgearticletemplateDuplicateMatchingRecord = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "msdyn_knowledgearticletemplateid",
					Entity2Attribute = "duplicaterecordid",
					Entity1LogicalName = "msdyn_knowledgearticletemplate",
					Entity2LogicalName = "duplicaterecord",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N msdyn_knowledgearticletemplate_MailboxTrackingFolders</summary>
			public static readonly XrmFakedRelationship MsdynKnowledgearticletemplateMailboxTrackingFolders = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "msdyn_knowledgearticletemplateid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "msdyn_knowledgearticletemplate",
					Entity2LogicalName = "mailboxtrackingfolder",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N msdyn_knowledgearticletemplate_PrincipalObjectAttributeAccesses</summary>
			public static readonly XrmFakedRelationship MsdynKnowledgearticletemplatePrincipalObjectAttributeAccesses = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "msdyn_knowledgearticletemplateid",
					Entity2Attribute = "objectid",
					Entity1LogicalName = "msdyn_knowledgearticletemplate",
					Entity2LogicalName = "principalobjectattributeaccess",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N msdyn_knowledgearticletemplate_ProcessSession</summary>
			public static readonly XrmFakedRelationship MsdynKnowledgearticletemplateProcessSession = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "msdyn_knowledgearticletemplateid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "msdyn_knowledgearticletemplate",
					Entity2LogicalName = "processsession",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N msdyn_knowledgearticletemplate_QueueItems</summary>
			public static readonly XrmFakedRelationship MsdynKnowledgearticletemplateQueueItems = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "msdyn_knowledgearticletemplateid",
					Entity2Attribute = "objectid",
					Entity1LogicalName = "msdyn_knowledgearticletemplate",
					Entity2LogicalName = "queueitem",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N msdyn_knowledgearticletemplate_SharePointDocumentLocations</summary>
			public static readonly XrmFakedRelationship MsdynKnowledgearticletemplateSharePointDocumentLocations = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "msdyn_knowledgearticletemplateid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "msdyn_knowledgearticletemplate",
					Entity2LogicalName = "sharepointdocumentlocation",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N msdyn_knowledgearticletemplate_SyncErrors</summary>
			public static readonly XrmFakedRelationship MsdynKnowledgearticletemplateSyncErrors = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "msdyn_knowledgearticletemplateid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "msdyn_knowledgearticletemplate",
					Entity2LogicalName = "syncerror",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

		}
		#endregion

		#region Fake
		public static KnowledgeArticleTemplate Create()
		{
			var faker = new Faker<KnowledgeArticleTemplate>()
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
			.RuleFor(e => e.Content, fake => fake.Lorem.Word())
			.RuleFor(e => e.Description, fake => fake.Lorem.Word())
			.RuleFor(e => e.Internal, fake => fake.Random.Bool())
			.RuleFor(e => e.Keywords, fake => fake.Lorem.Word())
			.RuleFor(e => e.Id, fake => Guid.NewGuid())
			.RuleFor(e => e.ArticleTemplateLanguageId, fake => fake.Lorem.Word())
			.RuleFor(e => e.ArticleLanguageName, fake => fake.Lorem.Word())
			.RuleFor(e => e.Name, fake => fake.Lorem.Word())
			.RuleFor(e => e.MsdynSubjectidname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Title, fake => fake.Lorem.Word())
			.RuleFor(e => e.RecordCreatedOn, fake => fake.Date.Soon())
			.RuleFor(e => e.Owneridname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Owneridtype, fake => fake.Lorem.Word())
			.RuleFor(e => e.Owneridyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.Status, fake => fake.PickRandom<KnowledgeArticleTemplate.eStatus>())
			.RuleFor(e => e.StatusReason, fake => fake.PickRandom<KnowledgeArticleTemplate.eStatusReason>())
			.RuleFor(e => e.TimeZoneRuleVersionNumber, fake => fake.Random.Int())
			.RuleFor(e => e.UTCConversionTimeZoneCode, fake => fake.Random.Int())
			.RuleFor(e => e.VersionNumber, fake => fake.Random.Int());
			return faker.Generate();
		}
		#endregion
	}
}

