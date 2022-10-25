using Bogus;
using System;
using FakeXrmEasy;
using System.Collections.Generic;
using PentaWork.Xrm.Scheduler.Proxies.Entities;

namespace PentaWork.Xrm.Scheduler.Tests.Fake
{
	public static class FakeAuditing
	{	
		#region FakeRelationships
		public static class Relationships 
		{
		}
		#endregion

		#region Fake
		public static Auditing Create()
		{
			var faker = new Faker<Auditing>()
			.RuleFor(e => e.Event, fake => fake.PickRandom<Auditing.eAction>())
			.RuleFor(e => e.ChangedField, fake => fake.Lorem.Word())
			.RuleFor(e => e.Id, fake => Guid.NewGuid())
			.RuleFor(e => e.Callinguseridname, fake => fake.Lorem.Word())
			.RuleFor(e => e.ChangeData, fake => fake.Lorem.Word())
			.RuleFor(e => e.ChangedDate, fake => fake.Date.Soon())
			.RuleFor(e => e.Objectidname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Entity, fake => fake.Lorem.Word())
			.RuleFor(e => e.Operation, fake => fake.PickRandom<Auditing.eOperation>())
			.RuleFor(e => e.Regardingobjectidname, fake => fake.Lorem.Word())
			.RuleFor(e => e.TransactionId, fake => Guid.NewGuid())
			.RuleFor(e => e.UserInfo, fake => fake.Lorem.Word())
			.RuleFor(e => e.Useridname, fake => fake.Lorem.Word());
			return faker.Generate();
		}
		#endregion
	}
}

