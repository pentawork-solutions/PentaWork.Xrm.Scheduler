using Bogus;
using System;
using FakeXrmEasy;
using System.Collections.Generic;
using PentaWork.Xrm.Scheduler.Proxies.Entities;

namespace PentaWork.Xrm.Scheduler.Tests.Fake
{
	public static class FakeVirtualResourceGroupResource
	{	
		#region FakeRelationships
		public static class Relationships 
		{
		}
		#endregion

		#region Fake
		public static VirtualResourceGroupResource Create()
		{
			var faker = new Faker<VirtualResourceGroupResource>()
			.RuleFor(e => e.BusinessUnit, fake => fake.Lorem.Word())
			.RuleFor(e => e.Constraintbasedgroupid, fake => fake.Lorem.Word())
			.RuleFor(e => e.Name, fake => fake.Lorem.Word())
			.RuleFor(e => e.EntityTypeLogicalName, fake => fake.Lorem.Word())
			.RuleFor(e => e.EntityType, fake => fake.Lorem.Word())
			.RuleFor(e => e.Resourcegroupidname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Id, fake => Guid.NewGuid());
			return faker.Generate();
		}
		#endregion
	}
}

