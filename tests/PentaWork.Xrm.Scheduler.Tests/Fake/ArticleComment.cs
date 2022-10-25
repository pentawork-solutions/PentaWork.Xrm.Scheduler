using Bogus;
using System;
using FakeXrmEasy;
using System.Collections.Generic;
using PentaWork.Xrm.Scheduler.Proxies.Entities;

namespace PentaWork.Xrm.Scheduler.Tests.Fake
{
	public static class FakeArticleComment
	{	
		#region FakeRelationships
		public static class Relationships 
		{
			/// <summary>1:N KbArticleComment_AsyncOperations</summary>
			public static readonly XrmFakedRelationship KbArticleCommentAsyncOperations = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "kbarticlecommentid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "kbarticlecomment",
					Entity2LogicalName = "asyncoperation",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N KbArticleComment_BulkDeleteFailures</summary>
			public static readonly XrmFakedRelationship KbArticleCommentBulkDeleteFailures = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "kbarticlecommentid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "kbarticlecomment",
					Entity2LogicalName = "bulkdeletefailure",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N KbArticleComment_ProcessSessions</summary>
			public static readonly XrmFakedRelationship KbArticleCommentProcessSessions = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "kbarticlecommentid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "kbarticlecomment",
					Entity2LogicalName = "processsession",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

		}
		#endregion

		#region Fake
		public static ArticleComment Create()
		{
			var faker = new Faker<ArticleComment>()
			.RuleFor(e => e.CommentText, fake => fake.Lorem.Word())
			.RuleFor(e => e.Createdbyname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Createdbyyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.CreatedOn, fake => fake.Date.Soon())
			.RuleFor(e => e.Createdonbehalfbyname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Createdonbehalfbyyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.Id, fake => Guid.NewGuid())
			.RuleFor(e => e.Modifiedbyname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Modifiedbyyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.ModifiedOn, fake => fake.Date.Soon())
			.RuleFor(e => e.Modifiedonbehalfbyname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Modifiedonbehalfbyyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.OrganizationId, fake => Guid.NewGuid())
			.RuleFor(e => e.Title, fake => fake.Lorem.Word())
			.RuleFor(e => e.Versionnumber, fake => fake.Random.Int());
			return faker.Generate();
		}
		#endregion
	}
}

