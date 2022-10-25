using Bogus;
using System;
using FakeXrmEasy;
using System.Collections.Generic;
using PentaWork.Xrm.Scheduler.Proxies.Entities;

namespace PentaWork.Xrm.Scheduler.Tests.Fake
{
	public static class FakeAnnouncement
	{	
		#region FakeRelationships
		public static class Relationships 
		{
			/// <summary>1:N BusinessUnitNewsArticle_AsyncOperations</summary>
			public static readonly XrmFakedRelationship BusinessUnitNewsArticleAsyncOperations = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "businessunitnewsarticleid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "businessunitnewsarticle",
					Entity2LogicalName = "asyncoperation",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N BusinessUnitNewsArticle_BulkDeleteFailures</summary>
			public static readonly XrmFakedRelationship BusinessUnitNewsArticleBulkDeleteFailures = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "businessunitnewsarticleid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "businessunitnewsarticle",
					Entity2LogicalName = "bulkdeletefailure",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N BusinessUnitNewsArticle_ProcessSessions</summary>
			public static readonly XrmFakedRelationship BusinessUnitNewsArticleProcessSessions = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "businessunitnewsarticleid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "businessunitnewsarticle",
					Entity2LogicalName = "processsession",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

		}
		#endregion

		#region Fake
		public static Announcement Create()
		{
			var faker = new Faker<Announcement>()
			.RuleFor(e => e.ActiveOn, fake => fake.Date.Soon())
			.RuleFor(e => e.ExpirationDate, fake => fake.Date.Soon())
			.RuleFor(e => e.Title, fake => fake.Lorem.Word())
			.RuleFor(e => e.VisibleTo, fake => fake.PickRandom<Announcement.eVisibleTo>())
			.RuleFor(e => e.MoreInformationURL, fake => fake.Lorem.Word())
			.RuleFor(e => e.Id, fake => Guid.NewGuid())
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
			.RuleFor(e => e.Description, fake => fake.Lorem.Word())
			.RuleFor(e => e.Organizationidname, fake => fake.Lorem.Word())
			.RuleFor(e => e.RecordCreatedOn, fake => fake.Date.Soon())
			.RuleFor(e => e.ShowInWorkplace, fake => fake.Random.Bool())
			.RuleFor(e => e.Timezoneruleversionnumber, fake => fake.Random.Int())
			.RuleFor(e => e.Utcconversiontimezonecode, fake => fake.Random.Int())
			.RuleFor(e => e.Versionnumber, fake => fake.Random.Int());
			return faker.Generate();
		}
		#endregion
	}
}

