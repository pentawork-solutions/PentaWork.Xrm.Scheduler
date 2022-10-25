using Bogus;
using System;
using FakeXrmEasy;
using System.Collections.Generic;
using PentaWork.Xrm.Scheduler.Proxies.Entities;

namespace PentaWork.Xrm.Scheduler.Tests.Fake
{
	public static class FakeInvalidDependency
	{	
		#region FakeRelationships
		public static class Relationships 
		{
		}
		#endregion

		#region Fake
		public static InvalidDependency Create()
		{
			var faker = new Faker<InvalidDependency>()
			.RuleFor(e => e.ExistingObjectId, fake => Guid.NewGuid())
			.RuleFor(e => e.ExistingObjectsComponentType, fake => fake.PickRandom<InvalidDependency.egComponentType>())
			.RuleFor(e => e.Weight, fake => fake.PickRandom<InvalidDependency.egDependencyType>())
			.RuleFor(e => e.Id, fake => Guid.NewGuid())
			.RuleFor(e => e.IsThisNodeTheRequiredComponent, fake => fake.Random.Bool())
			.RuleFor(e => e.RegardingId, fake => Guid.NewGuid())
			.RuleFor(e => e.Missingcomponentinfo, fake => fake.Lorem.Word())
			.RuleFor(e => e.LookupType, fake => fake.Random.Int())
			.RuleFor(e => e.TypeCode, fake => fake.PickRandom<InvalidDependency.egComponentType>());
			return faker.Generate();
		}
		#endregion
	}
}

