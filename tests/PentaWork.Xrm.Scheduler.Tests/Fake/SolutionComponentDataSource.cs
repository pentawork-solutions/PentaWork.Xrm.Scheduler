using Bogus;
using System;
using FakeXrmEasy;
using System.Collections.Generic;
using PentaWork.Xrm.Scheduler.Proxies.Entities;

namespace PentaWork.Xrm.Scheduler.Tests.Fake
{
	public static class FakeSolutionComponentDataSource
	{	
		#region FakeRelationships
		public static class Relationships 
		{
		}
		#endregion

		#region Fake
		public static SolutionComponentDataSource Create()
		{
			var faker = new Faker<SolutionComponentDataSource>()
			.RuleFor(e => e.MsdynName, fake => fake.Lorem.Word())
			.RuleFor(e => e.Id, fake => Guid.NewGuid())
			.RuleFor(e => e.OrganizationId, fake => Guid.NewGuid());
			return faker.Generate();
		}
		#endregion
	}
}

