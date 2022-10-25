using Bogus;
using System;
using FakeXrmEasy;
using System.Collections.Generic;
using PentaWork.Xrm.Scheduler.Proxies.Entities;

namespace PentaWork.Xrm.Scheduler.Tests.Fake
{
	public static class FakeCategory
	{	
		#region FakeRelationships
		public static class Relationships 
		{
			/// <summary>1:N category_parent_category</summary>
			public static readonly XrmFakedRelationship CategoryParentCategory = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "categoryid",
					Entity2Attribute = "parentcategoryid",
					Entity1LogicalName = "category",
					Entity2LogicalName = "category",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N Category_SyncErrors</summary>
			public static readonly XrmFakedRelationship CategorySyncErrors = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "categoryid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "category",
					Entity2LogicalName = "syncerror",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>N:N knowledgearticle_category</summary>
			public static readonly XrmFakedRelationship KnowledgearticleCategory = 
				new XrmFakedRelationship
				{
					IntersectEntity = "knowledgearticle_category",
					Entity1Attribute = "knowledgearticleid",
					Entity2Attribute = "categoryid",
					Entity1LogicalName = "knowledgearticle",
					Entity2LogicalName = "category",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.ManyToMany
				};

		}
		#endregion

		#region Fake
		public static Category Create()
		{
			var faker = new Faker<Category>()
			.RuleFor(e => e.Id, fake => Guid.NewGuid())
			.RuleFor(e => e.CategoryNumber, fake => fake.Lorem.Word())
			.RuleFor(e => e.Createdbyname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Createdbyyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.RecordCreatedOn, fake => fake.Date.Soon())
			.RuleFor(e => e.Createdonbehalfbyname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Createdonbehalfbyyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.Description, fake => fake.Lorem.Word())
			.RuleFor(e => e.ExchangeRate, fake => fake.Finance.Amount())
			.RuleFor(e => e.ImportSequenceNumber, fake => fake.Random.Int())
			.RuleFor(e => e.Modifiedbyname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Modifiedbyyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.ModifiedOn, fake => fake.Date.Soon())
			.RuleFor(e => e.Modifiedonbehalfbyname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Modifiedonbehalfbyyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.RecordCreatedOn2, fake => fake.Date.Soon())
			.RuleFor(e => e.Owneridname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Owneridtype, fake => fake.Lorem.Word())
			.RuleFor(e => e.Parentcategoryidname, fake => fake.Lorem.Word())
			.RuleFor(e => e.DisplayOrder, fake => fake.Random.Int())
			.RuleFor(e => e.Title, fake => fake.Lorem.Word())
			.RuleFor(e => e.Transactioncurrencyidname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Versionnumber, fake => fake.Random.Int());
			return faker.Generate();
		}
		#endregion
	}
}

