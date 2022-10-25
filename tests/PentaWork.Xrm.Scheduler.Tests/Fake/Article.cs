using Bogus;
using System;
using FakeXrmEasy;
using System.Collections.Generic;
using PentaWork.Xrm.Scheduler.Proxies.Entities;

namespace PentaWork.Xrm.Scheduler.Tests.Fake
{
	public static class FakeArticle
	{	
		#region FakeRelationships
		public static class Relationships 
		{
			/// <summary>1:N KbArticle_Annotation</summary>
			public static readonly XrmFakedRelationship KbArticleAnnotation = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "kbarticleid",
					Entity2Attribute = "objectid",
					Entity1LogicalName = "kbarticle",
					Entity2LogicalName = "annotation",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N KbArticle_AsyncOperations</summary>
			public static readonly XrmFakedRelationship KbArticleAsyncOperations = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "kbarticleid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "kbarticle",
					Entity2LogicalName = "asyncoperation",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N KbArticle_BulkDeleteFailures</summary>
			public static readonly XrmFakedRelationship KbArticleBulkDeleteFailures = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "kbarticleid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "kbarticle",
					Entity2LogicalName = "bulkdeletefailure",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N kbarticle_comments</summary>
			public static readonly XrmFakedRelationship KbarticleComments = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "kbarticleid",
					Entity2Attribute = "kbarticleid",
					Entity1LogicalName = "kbarticle",
					Entity2LogicalName = "kbarticlecomment",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N KbArticle_DuplicateBaseRecord</summary>
			public static readonly XrmFakedRelationship KbArticleDuplicateBaseRecord = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "kbarticleid",
					Entity2Attribute = "baserecordid",
					Entity1LogicalName = "kbarticle",
					Entity2LogicalName = "duplicaterecord",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N KbArticle_DuplicateMatchingRecord</summary>
			public static readonly XrmFakedRelationship KbArticleDuplicateMatchingRecord = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "kbarticleid",
					Entity2Attribute = "duplicaterecordid",
					Entity1LogicalName = "kbarticle",
					Entity2LogicalName = "duplicaterecord",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N kbarticle_incidents</summary>
			public static readonly XrmFakedRelationship KbarticleIncidents = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "kbarticleid",
					Entity2Attribute = "kbarticleid",
					Entity1LogicalName = "kbarticle",
					Entity2LogicalName = "incident",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N kbarticle_principalobjectattributeaccess</summary>
			public static readonly XrmFakedRelationship KbarticlePrincipalobjectattributeaccess = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "kbarticleid",
					Entity2Attribute = "objectid",
					Entity1LogicalName = "kbarticle",
					Entity2LogicalName = "principalobjectattributeaccess",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N KbArticle_ProcessSessions</summary>
			public static readonly XrmFakedRelationship KbArticleProcessSessions = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "kbarticleid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "kbarticle",
					Entity2LogicalName = "processsession",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N KbArticle_SharepointDocumentLocation</summary>
			public static readonly XrmFakedRelationship KbArticleSharepointDocumentLocation = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "kbarticleid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "kbarticle",
					Entity2LogicalName = "sharepointdocumentlocation",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N KbArticle_SyncErrors</summary>
			public static readonly XrmFakedRelationship KbArticleSyncErrors = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "kbarticleid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "kbarticle",
					Entity2LogicalName = "syncerror",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

		}
		#endregion

		#region Fake
		public static Article Create()
		{
			var faker = new Faker<Article>()
			.RuleFor(e => e.ArticleXML, fake => fake.Lorem.Word())
			.RuleFor(e => e.Comments, fake => fake.Lorem.Word())
			.RuleFor(e => e.Content, fake => fake.Lorem.Word())
			.RuleFor(e => e.Createdbyname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Createdbyyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.CreatedOn, fake => fake.Date.Soon())
			.RuleFor(e => e.Createdonbehalfbyname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Createdonbehalfbyyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.Description, fake => fake.Lorem.Word())
			.RuleFor(e => e.EntityimageTimestamp, fake => fake.Random.Int())
			.RuleFor(e => e.EntityimageUrl, fake => fake.Lorem.Word())
			.RuleFor(e => e.EntityImageId, fake => Guid.NewGuid())
			.RuleFor(e => e.ExchangeRate, fake => fake.Finance.Amount())
			.RuleFor(e => e.ImportSequenceNumber, fake => fake.Random.Int())
			.RuleFor(e => e.Id, fake => Guid.NewGuid())
			.RuleFor(e => e.Kbarticletemplateidtitle, fake => fake.Lorem.Word())
			.RuleFor(e => e.KeyWords, fake => fake.Lorem.Word())
			.RuleFor(e => e.Language, fake => fake.Random.Int())
			.RuleFor(e => e.Modifiedbyname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Modifiedbyyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.ModifiedOn, fake => fake.Date.Soon())
			.RuleFor(e => e.Modifiedonbehalfbyname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Modifiedonbehalfbyyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.Number, fake => fake.Lorem.Word())
			.RuleFor(e => e.Organizationidname, fake => fake.Lorem.Word())
			.RuleFor(e => e.RecordCreatedOn, fake => fake.Date.Soon())
			.RuleFor(e => e.Status, fake => fake.PickRandom<Article.eStatus>())
			.RuleFor(e => e.StatusReason, fake => fake.PickRandom<Article.eStatusReason>())
			.RuleFor(e => e.Subjectidname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Title, fake => fake.Lorem.Word())
			.RuleFor(e => e.Transactioncurrencyidname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Title2, fake => fake.Random.Int());
			return faker.Generate();
		}
		#endregion
	}
}

