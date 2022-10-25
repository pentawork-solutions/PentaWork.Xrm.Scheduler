using Bogus;
using System;
using FakeXrmEasy;
using System.Collections.Generic;
using PentaWork.Xrm.Scheduler.Proxies.Entities;

namespace PentaWork.Xrm.Scheduler.Tests.Fake
{
	public static class FakeDependency
	{	
		#region FakeRelationships
		public static class Relationships 
		{
		}
		#endregion

		#region Fake
		public static Dependency Create()
		{
			var faker = new Faker<Dependency>()
			.RuleFor(e => e.Id, fake => Guid.NewGuid())
			.RuleFor(e => e.DependencyType, fake => fake.PickRandom<Dependency.egDependencyType>())
			.RuleFor(e => e.DependentcomponentbasesolutionId, fake => Guid.NewGuid())
			.RuleFor(e => e.DependentcomponentobjectId, fake => Guid.NewGuid())
			.RuleFor(e => e.DependentcomponentparentId, fake => Guid.NewGuid())
			.RuleFor(e => e.Dependentcomponenttype, fake => fake.PickRandom<Dependency.egComponentType>())
			.RuleFor(e => e.RequiredcomponentbasesolutionId, fake => Guid.NewGuid())
			.RuleFor(e => e.Requiredcomponentintroducedversion, fake => fake.Random.Double())
			.RuleFor(e => e.RequiredcomponentobjectId, fake => Guid.NewGuid())
			.RuleFor(e => e.RequiredcomponentparentId, fake => Guid.NewGuid())
			.RuleFor(e => e.Requiredcomponenttype, fake => fake.PickRandom<Dependency.egComponentType>())
			.RuleFor(e => e.Versionnumber, fake => fake.Random.Int());
			return faker.Generate();
		}
		#endregion
	}
}

