using Bogus;
using System;
using FakeXrmEasy;
using System.Collections.Generic;
using PentaWork.Xrm.Scheduler.Proxies.Entities;

namespace PentaWork.Xrm.Scheduler.Tests.Fake
{
	public static class FakePrincipalobjectaccess
	{	
		#region FakeRelationships
		public static class Relationships 
		{
		}
		#endregion

		#region Fake
		public static Principalobjectaccess Create()
		{
			var faker = new Faker<Principalobjectaccess>()
			.RuleFor(e => e.Accessrightsmask, fake => fake.Random.Int())
			.RuleFor(e => e.Changedon, fake => fake.Date.Soon())
			.RuleFor(e => e.Inheritedaccessrightsmask, fake => fake.Random.Int())
			.RuleFor(e => e.ObjectId, fake => Guid.NewGuid())
			.RuleFor(e => e.Objecttypecode, fake => fake.Lorem.Word())
			.RuleFor(e => e.PrincipalId, fake => Guid.NewGuid())
			.RuleFor(e => e.Id, fake => Guid.NewGuid())
			.RuleFor(e => e.Principaltypecode, fake => fake.Lorem.Word())
			.RuleFor(e => e.Timezoneruleversionnumber, fake => fake.Random.Int())
			.RuleFor(e => e.Utcconversiontimezonecode, fake => fake.Random.Int())
			.RuleFor(e => e.Versionnumber, fake => fake.Random.Int());
			return faker.Generate();
		}
		#endregion
	}
}

