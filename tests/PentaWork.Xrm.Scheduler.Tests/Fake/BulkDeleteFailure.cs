using Bogus;
using System;
using FakeXrmEasy;
using System.Collections.Generic;
using PentaWork.Xrm.Scheduler.Proxies.Entities;

namespace PentaWork.Xrm.Scheduler.Tests.Fake
{
	public static class FakeBulkDeleteFailure
	{	
		#region FakeRelationships
		public static class Relationships 
		{
		}
		#endregion

		#region Fake
		public static BulkDeleteFailure Create()
		{
			var faker = new Faker<BulkDeleteFailure>()
			.RuleFor(e => e.Id, fake => Guid.NewGuid())
			.RuleFor(e => e.ErrorDescription, fake => fake.Lorem.Word())
			.RuleFor(e => e.ErrorCode, fake => fake.Random.Int())
			.RuleFor(e => e.Index, fake => fake.Random.Int())
			.RuleFor(e => e.Owneridtype, fake => fake.Lorem.Word())
			.RuleFor(e => e.OwningBusinessUnitId, fake => Guid.NewGuid())
			.RuleFor(e => e.OwningUserId, fake => Guid.NewGuid())
			.RuleFor(e => e.Regardingobjectidname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Regardingobjectidyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.Regardingobjecttypecode, fake => fake.Lorem.Word());
			return faker.Generate();
		}
		#endregion
	}
}

