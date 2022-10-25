using Bogus;
using System;
using FakeXrmEasy;
using System.Collections.Generic;
using PentaWork.Xrm.Scheduler.Proxies.Entities;

namespace PentaWork.Xrm.Scheduler.Tests.Fake
{
	public static class FakeAvailableTimes
	{	
		#region FakeRelationships
		public static class Relationships 
		{
		}
		#endregion

		#region Fake
		public static AvailableTimes Create()
		{
			var faker = new Faker<AvailableTimes>()
			.RuleFor(e => e.Id, fake => Guid.NewGuid())
			.RuleFor(e => e.Name, fake => fake.Lorem.Word())
			.RuleFor(e => e.Resources, fake => fake.Lorem.Word())
			.RuleFor(e => e.ResourcesIDs, fake => fake.Lorem.Word())
			.RuleFor(e => e.ScheduledEndUTCTime, fake => fake.Date.Soon())
			.RuleFor(e => e.ScheduledEnd, fake => fake.Lorem.Word())
			.RuleFor(e => e.ScheduledStartUTCTime, fake => fake.Date.Soon())
			.RuleFor(e => e.ScheduledStart, fake => fake.Lorem.Word())
			.RuleFor(e => e.Site, fake => fake.Lorem.Word())
			.RuleFor(e => e.SiteIdentifierId, fake => Guid.NewGuid());
			return faker.Generate();
		}
		#endregion
	}
}

