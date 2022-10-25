using Bogus;
using System;
using FakeXrmEasy;
using System.Collections.Generic;
using PentaWork.Xrm.Scheduler.Proxies.Entities;

namespace PentaWork.Xrm.Scheduler.Tests.Fake
{
	public static class FakeLanguage
	{	
		#region FakeRelationships
		public static class Relationships 
		{
			/// <summary>1:N knowledgearticle_languagelocaleid</summary>
			public static readonly XrmFakedRelationship KnowledgearticleLanguagelocaleid = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "languagelocaleid",
					Entity2Attribute = "languagelocaleid",
					Entity1LogicalName = "languagelocale",
					Entity2LogicalName = "knowledgearticle",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

		}
		#endregion

		#region Fake
		public static Language Create()
		{
			var faker = new Faker<Language>()
			.RuleFor(e => e.Code, fake => fake.Lorem.Word())
			.RuleFor(e => e.Language2, fake => fake.Lorem.Word())
			.RuleFor(e => e.Id, fake => Guid.NewGuid())
			.RuleFor(e => e.LocaleID, fake => fake.Random.Int())
			.RuleFor(e => e.Name, fake => fake.Lorem.Word())
			.RuleFor(e => e.Region, fake => fake.Lorem.Word())
			.RuleFor(e => e.StateCode, fake => fake.PickRandom<Language.eStatus>())
			.RuleFor(e => e.LanguageStatusCode, fake => fake.PickRandom<Language.eStatus2>())
			.RuleFor(e => e.Versionnumber, fake => fake.Random.Int());
			return faker.Generate();
		}
		#endregion
	}
}

