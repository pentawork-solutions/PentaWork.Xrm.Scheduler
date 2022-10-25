using Bogus;
using System;
using FakeXrmEasy;
using System.Collections.Generic;
using PentaWork.Xrm.Scheduler.Proxies.Entities;

namespace PentaWork.Xrm.Scheduler.Tests.Fake
{
	public static class FakeDuplicateRecord
	{	
		#region FakeRelationships
		public static class Relationships 
		{
		}
		#endregion

		#region Fake
		public static DuplicateRecord Create()
		{
			var faker = new Faker<DuplicateRecord>()
			.RuleFor(e => e.Baserecordidname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Baserecordidtypecode, fake => fake.Lorem.Word())
			.RuleFor(e => e.Baserecordidyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.Createdon, fake => fake.Date.Soon())
			.RuleFor(e => e.Id, fake => Guid.NewGuid())
			.RuleFor(e => e.Duplicaterecordidname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Duplicaterecordidtypecode, fake => fake.Lorem.Word())
			.RuleFor(e => e.Duplicaterecordidyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.Owneridtype, fake => fake.Lorem.Word())
			.RuleFor(e => e.OwningBusinessUnitId, fake => Guid.NewGuid())
			.RuleFor(e => e.OwningUserId, fake => Guid.NewGuid());
			return faker.Generate();
		}
		#endregion
	}
}

