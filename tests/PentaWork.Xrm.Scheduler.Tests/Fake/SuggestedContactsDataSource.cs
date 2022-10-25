using Bogus;
using System;
using FakeXrmEasy;
using System.Collections.Generic;
using PentaWork.Xrm.Scheduler.Proxies.Entities;

namespace PentaWork.Xrm.Scheduler.Tests.Fake
{
	public static class FakeSuggestedContactsDataSource
	{	
		#region FakeRelationships
		public static class Relationships 
		{
		}
		#endregion

		#region Fake
		public static SuggestedContactsDataSource Create()
		{
			var faker = new Faker<SuggestedContactsDataSource>()
			.RuleFor(e => e.Name, fake => fake.Lorem.Word())
			.RuleFor(e => e.Id, fake => Guid.NewGuid());
			return faker.Generate();
		}
		#endregion
	}
}

