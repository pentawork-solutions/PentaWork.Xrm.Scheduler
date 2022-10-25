using Bogus;
using System;
using FakeXrmEasy;
using System.Collections.Generic;
using PentaWork.Xrm.Scheduler.Proxies.Entities;

namespace PentaWork.Xrm.Scheduler.Tests.Fake
{
	public static class FakeComponentLayer
	{	
		#region FakeRelationships
		public static class Relationships 
		{
		}
		#endregion

		#region Fake
		public static ComponentLayer Create()
		{
			var faker = new Faker<ComponentLayer>()
			.RuleFor(e => e.Changes, fake => fake.Lorem.Word())
			.RuleFor(e => e.Children, fake => fake.Lorem.Word())
			.RuleFor(e => e.ComponentId, fake => fake.Lorem.Word())
			.RuleFor(e => e.ComponentJson, fake => fake.Lorem.Word())
			.RuleFor(e => e.Id, fake => Guid.NewGuid())
			.RuleFor(e => e.Name, fake => fake.Lorem.Word())
			.RuleFor(e => e.Order, fake => fake.Random.Int())
			.RuleFor(e => e.OverwriteTime, fake => fake.Date.Soon())
			.RuleFor(e => e.PublisherName, fake => fake.Lorem.Word())
			.RuleFor(e => e.SolutionComponentName, fake => fake.Lorem.Word())
			.RuleFor(e => e.SolutionName, fake => fake.Lorem.Word());
			return faker.Generate();
		}
		#endregion
	}
}

