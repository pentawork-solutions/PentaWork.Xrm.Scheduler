using Bogus;
using System;
using FakeXrmEasy;
using System.Collections.Generic;
using PentaWork.Xrm.Scheduler.Proxies.Entities;

namespace PentaWork.Xrm.Scheduler.Tests.Fake
{
	public static class FakeSuggestedActivity
	{	
		#region FakeRelationships
		public static class Relationships 
		{
		}
		#endregion

		#region Fake
		public static SuggestedActivity Create()
		{
			var faker = new Faker<SuggestedActivity>()
			.RuleFor(e => e.Activity, fake => fake.Lorem.Word())
			.RuleFor(e => e.BodyPreview, fake => fake.Lorem.Word())
			.RuleFor(e => e.CreatedDate, fake => fake.Date.Soon())
			.RuleFor(e => e.Duration, fake => fake.Lorem.Word())
			.RuleFor(e => e.EndTime, fake => fake.Date.Soon())
			.RuleFor(e => e.ExchangeWebLink, fake => fake.Lorem.Word())
			.RuleFor(e => e.Importance, fake => fake.Lorem.Word())
			.RuleFor(e => e.Location, fake => fake.Lorem.Word())
			.RuleFor(e => e.RegardingEntity, fake => fake.Lorem.Word())
			.RuleFor(e => e.Sender, fake => fake.Lorem.Word())
			.RuleFor(e => e.SendersName, fake => fake.Lorem.Word())
			.RuleFor(e => e.StartTime, fake => fake.Date.Soon())
			.RuleFor(e => e.Subject, fake => fake.Lorem.Word())
			.RuleFor(e => e.Id, fake => Guid.NewGuid())
			.RuleFor(e => e.To, fake => fake.Lorem.Word());
			return faker.Generate();
		}
		#endregion
	}
}

