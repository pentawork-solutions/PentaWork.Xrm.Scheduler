using Bogus;
using System;
using FakeXrmEasy;
using System.Collections.Generic;
using PentaWork.Xrm.Scheduler.Proxies.Entities;

namespace PentaWork.Xrm.Scheduler.Tests.Fake
{
	public static class FakeKnowledgeArticleViews
	{	
		#region FakeRelationships
		public static class Relationships 
		{
			/// <summary>1:N knowledgearticleview_principalobjectattributeaccess</summary>
			public static readonly XrmFakedRelationship KnowledgearticleviewPrincipalobjectattributeaccess = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "knowledgearticleviewsid",
					Entity2Attribute = "objectid",
					Entity1LogicalName = "knowledgearticleviews",
					Entity2LogicalName = "principalobjectattributeaccess",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N KnowledgeArticleViews_SyncErrors</summary>
			public static readonly XrmFakedRelationship KnowledgeArticleViewsSyncErrors = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "knowledgearticleviewsid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "knowledgearticleviews",
					Entity2LogicalName = "syncerror",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

		}
		#endregion

		#region Fake
		public static KnowledgeArticleViews Create()
		{
			var faker = new Faker<KnowledgeArticleViews>()
			.RuleFor(e => e.Createdbyname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Createdbyyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.CreatedOn, fake => fake.Date.Soon())
			.RuleFor(e => e.Createdonbehalfbyname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Createdonbehalfbyyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.ExchangeRate, fake => fake.Finance.Amount())
			.RuleFor(e => e.ImportSequenceNumber, fake => fake.Random.Int())
			.RuleFor(e => e.Knowledgearticleidname, fake => fake.Lorem.Word())
			.RuleFor(e => e.KnowledgeArticleView, fake => fake.Random.Int())
			.RuleFor(e => e.Id, fake => Guid.NewGuid())
			.RuleFor(e => e.Location, fake => fake.PickRandom<KnowledgeArticleViews.eKnowledgePublishingPoints>())
			.RuleFor(e => e.Modifiedbyname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Modifiedbyyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.ModifiedOn, fake => fake.Date.Soon())
			.RuleFor(e => e.Modifiedonbehalfbyname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Modifiedonbehalfbyyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.RecordCreatedOn, fake => fake.Date.Soon())
			.RuleFor(e => e.Owneridtype, fake => fake.Lorem.Word())
			.RuleFor(e => e.OwningBusinessUnitId, fake => Guid.NewGuid())
			.RuleFor(e => e.OwningUserId, fake => Guid.NewGuid())
			.RuleFor(e => e.Status, fake => fake.PickRandom<KnowledgeArticleViews.eStatus>())
			.RuleFor(e => e.StatusReason, fake => fake.PickRandom<KnowledgeArticleViews.eStatus2>())
			.RuleFor(e => e.TimeZoneRuleVersionNumber, fake => fake.Random.Int())
			.RuleFor(e => e.Transactioncurrencyidname, fake => fake.Lorem.Word())
			.RuleFor(e => e.UTCConversionTimeZoneCode, fake => fake.Random.Int())
			.RuleFor(e => e.Versionnumber, fake => fake.Random.Int())
			.RuleFor(e => e.Day, fake => fake.Date.Soon());
			return faker.Generate();
		}
		#endregion
	}
}

