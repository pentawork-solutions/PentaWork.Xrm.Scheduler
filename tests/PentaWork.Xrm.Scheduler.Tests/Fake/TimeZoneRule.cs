using Bogus;
using System;
using FakeXrmEasy;
using System.Collections.Generic;
using PentaWork.Xrm.Scheduler.Proxies.Entities;

namespace PentaWork.Xrm.Scheduler.Tests.Fake
{
	public static class FakeTimeZoneRule
	{	
		#region FakeRelationships
		public static class Relationships 
		{
		}
		#endregion

		#region Fake
		public static TimeZoneRule Create()
		{
			var faker = new Faker<TimeZoneRule>()
			.RuleFor(e => e.Bias, fake => fake.Random.Int())
			.RuleFor(e => e.CreatedOn, fake => fake.Date.Soon())
			.RuleFor(e => e.Createdonbehalfbyname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Createdonbehalfbyyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.DaylightBias, fake => fake.Random.Int())
			.RuleFor(e => e.DaylightDay, fake => fake.Random.Int())
			.RuleFor(e => e.DaylightDayOfWeek, fake => fake.Random.Int())
			.RuleFor(e => e.DaylightHour, fake => fake.Random.Int())
			.RuleFor(e => e.DaylightMinute, fake => fake.Random.Int())
			.RuleFor(e => e.DaylightMonth, fake => fake.Random.Int())
			.RuleFor(e => e.DaylightSecond, fake => fake.Random.Int())
			.RuleFor(e => e.DaylightYear, fake => fake.Random.Int())
			.RuleFor(e => e.EffectiveDateTime, fake => fake.Date.Soon())
			.RuleFor(e => e.ModifiedOn, fake => fake.Date.Soon())
			.RuleFor(e => e.Modifiedonbehalfbyname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Modifiedonbehalfbyyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.StandardBias, fake => fake.Random.Int())
			.RuleFor(e => e.StandardDay, fake => fake.Random.Int())
			.RuleFor(e => e.StandardDayOfWeek, fake => fake.Random.Int())
			.RuleFor(e => e.StandardHour, fake => fake.Random.Int())
			.RuleFor(e => e.StandardMinute, fake => fake.Random.Int())
			.RuleFor(e => e.StandardMonth, fake => fake.Random.Int())
			.RuleFor(e => e.StandardSecond, fake => fake.Random.Int())
			.RuleFor(e => e.StandardYear, fake => fake.Random.Int())
			.RuleFor(e => e.Id, fake => Guid.NewGuid())
			.RuleFor(e => e.TimeZoneRuleVersionNumber, fake => fake.Random.Int())
			.RuleFor(e => e.Versionnumber, fake => fake.Random.Int());
			return faker.Generate();
		}
		#endregion
	}
}

