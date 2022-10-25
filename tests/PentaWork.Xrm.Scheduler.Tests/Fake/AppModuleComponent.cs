using Bogus;
using System;
using FakeXrmEasy;
using System.Collections.Generic;
using PentaWork.Xrm.Scheduler.Proxies.Entities;

namespace PentaWork.Xrm.Scheduler.Tests.Fake
{
	public static class FakeAppModuleComponent
	{	
		#region FakeRelationships
		public static class Relationships 
		{
		}
		#endregion

		#region Fake
		public static AppModuleComponent Create()
		{
			var faker = new Faker<AppModuleComponent>()
			.RuleFor(e => e.Id, fake => Guid.NewGuid())
			.RuleFor(e => e.ApplicationComponentUniqueId, fake => Guid.NewGuid())
			.RuleFor(e => e.Appmoduleidname, fake => fake.Lorem.Word())
			.RuleFor(e => e.ObjectTypeCode, fake => fake.PickRandom<AppModuleComponent.eComponentType>())
			.RuleFor(e => e.Createdbyname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Createdbyyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.CreatedOn, fake => fake.Date.Soon())
			.RuleFor(e => e.Createdonbehalfbyname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Createdonbehalfbyyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.ExchangeRate, fake => fake.Finance.Amount())
			.RuleFor(e => e.IntroducedVersion, fake => fake.Lorem.Word())
			.RuleFor(e => e.IsDefault, fake => fake.Random.Bool())
			.RuleFor(e => e.IsMetadata, fake => fake.Random.Bool())
			.RuleFor(e => e.Modifiedbyname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Modifiedbyyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.ModifiedOn, fake => fake.Date.Soon())
			.RuleFor(e => e.Modifiedonbehalfbyname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Modifiedonbehalfbyyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.ObjectId, fake => Guid.NewGuid())
			.RuleFor(e => e.CreatedOn2, fake => fake.Date.Soon())
			.RuleFor(e => e.RootAppModuleComponentId, fake => Guid.NewGuid())
			.RuleFor(e => e.RootComponentBehavior, fake => fake.PickRandom<AppModuleComponent.eIncludeBehavior>())
			.RuleFor(e => e.TimeZoneRuleVersionNumber, fake => fake.Random.Int())
			.RuleFor(e => e.UTCConversionTimeZoneCode, fake => fake.Random.Int())
			.RuleFor(e => e.Versionnumber, fake => fake.Random.Int());
			return faker.Generate();
		}
		#endregion
	}
}

