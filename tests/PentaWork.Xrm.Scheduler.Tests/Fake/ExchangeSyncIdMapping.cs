using Bogus;
using System;
using FakeXrmEasy;
using System.Collections.Generic;
using PentaWork.Xrm.Scheduler.Proxies.Entities;

namespace PentaWork.Xrm.Scheduler.Tests.Fake
{
	public static class FakeExchangeSyncIdMapping
	{	
		#region FakeRelationships
		public static class Relationships 
		{
		}
		#endregion

		#region Fake
		public static ExchangeSyncIdMapping Create()
		{
			var faker = new Faker<ExchangeSyncIdMapping>()
			.RuleFor(e => e.CreatedOn, fake => fake.Date.Soon())
			.RuleFor(e => e.ExchangeId, fake => fake.Lorem.Word())
			.RuleFor(e => e.Id, fake => Guid.NewGuid())
			.RuleFor(e => e.Fromcrmchangetype, fake => fake.Random.Int())
			.RuleFor(e => e.Isdeletedinexchange, fake => fake.Random.Bool())
			.RuleFor(e => e.Isunlinkedincrm, fake => fake.Random.Bool())
			.RuleFor(e => e.ItemSubject, fake => fake.Lorem.Word())
			.RuleFor(e => e.SyncError, fake => fake.Lorem.Word())
			.RuleFor(e => e.Lastsyncerrorcode, fake => fake.Random.Int())
			.RuleFor(e => e.LastSyncErrorTime, fake => fake.Date.Soon())
			.RuleFor(e => e.ModifiedOn, fake => fake.Date.Soon())
			.RuleFor(e => e.CrmId, fake => Guid.NewGuid())
			.RuleFor(e => e.ObjectTypeCode, fake => fake.Random.Int())
			.RuleFor(e => e.Owneridname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Owneridtype, fake => fake.Lorem.Word())
			.RuleFor(e => e.Owneridyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.Retries, fake => fake.Random.Int())
			.RuleFor(e => e.Tocrmchangetype, fake => fake.Random.Int())
			.RuleFor(e => e.Userdecision, fake => fake.Random.Int())
			.RuleFor(e => e.Versionnumber, fake => fake.Random.Int());
			return faker.Generate();
		}
		#endregion
	}
}

