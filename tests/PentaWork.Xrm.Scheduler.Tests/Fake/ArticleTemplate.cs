using Bogus;
using System;
using FakeXrmEasy;
using System.Collections.Generic;
using PentaWork.Xrm.Scheduler.Proxies.Entities;

namespace PentaWork.Xrm.Scheduler.Tests.Fake
{
	public static class FakeArticleTemplate
	{	
		#region FakeRelationships
		public static class Relationships 
		{
			/// <summary>1:N kb_article_template_kb_articles</summary>
			public static readonly XrmFakedRelationship KbArticleTemplateKbArticles = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "kbarticletemplateid",
					Entity2Attribute = "kbarticletemplateid",
					Entity1LogicalName = "kbarticletemplate",
					Entity2LogicalName = "kbarticle",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N KbArticleTemplate_AsyncOperations</summary>
			public static readonly XrmFakedRelationship KbArticleTemplateAsyncOperations = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "kbarticletemplateid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "kbarticletemplate",
					Entity2LogicalName = "asyncoperation",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N KbArticleTemplate_BulkDeleteFailures</summary>
			public static readonly XrmFakedRelationship KbArticleTemplateBulkDeleteFailures = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "kbarticletemplateid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "kbarticletemplate",
					Entity2LogicalName = "bulkdeletefailure",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N KbArticleTemplate_ProcessSessions</summary>
			public static readonly XrmFakedRelationship KbArticleTemplateProcessSessions = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "kbarticletemplateid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "kbarticletemplate",
					Entity2LogicalName = "processsession",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N KbArticleTemplate_SyncErrors</summary>
			public static readonly XrmFakedRelationship KbArticleTemplateSyncErrors = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "kbarticletemplateid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "kbarticletemplate",
					Entity2LogicalName = "syncerror",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

		}
		#endregion

		#region Fake
		public static ArticleTemplate Create()
		{
			var faker = new Faker<ArticleTemplate>()
			.RuleFor(e => e.ComponentState, fake => fake.PickRandom<ArticleTemplate.egComponentState>())
			.RuleFor(e => e.Createdbyname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Createdbyyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.CreatedOn, fake => fake.Date.Soon())
			.RuleFor(e => e.Createdonbehalfbyname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Createdonbehalfbyyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.Description, fake => fake.Lorem.Word())
			.RuleFor(e => e.FormatXML, fake => fake.Lorem.Word())
			.RuleFor(e => e.ImportSequenceNumber, fake => fake.Random.Int())
			.RuleFor(e => e.IntroducedVersion, fake => fake.Lorem.Word())
			.RuleFor(e => e.Status, fake => fake.Random.Bool())
			.RuleFor(e => e.Ismanaged, fake => fake.Random.Bool())
			.RuleFor(e => e.Id, fake => Guid.NewGuid())
			.RuleFor(e => e.KbarticletemplateiduniqueId, fake => Guid.NewGuid())
			.RuleFor(e => e.Language, fake => fake.Random.Int())
			.RuleFor(e => e.Modifiedbyname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Modifiedbyyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.ModifiedOn, fake => fake.Date.Soon())
			.RuleFor(e => e.Modifiedonbehalfbyname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Modifiedonbehalfbyyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.Organizationidname, fake => fake.Lorem.Word())
			.RuleFor(e => e.RecordCreatedOn, fake => fake.Date.Soon())
			.RuleFor(e => e.RecordOverwriteTime, fake => fake.Date.Soon())
			.RuleFor(e => e.SolutionId, fake => Guid.NewGuid())
			.RuleFor(e => e.StructureXML, fake => fake.Lorem.Word())
			.RuleFor(e => e.SolutionId2, fake => Guid.NewGuid())
			.RuleFor(e => e.Title, fake => fake.Lorem.Word())
			.RuleFor(e => e.Versionnumber, fake => fake.Random.Int());
			return faker.Generate();
		}
		#endregion
	}
}

