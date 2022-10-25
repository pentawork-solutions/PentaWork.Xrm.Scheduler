using Bogus;
using System;
using FakeXrmEasy;
using System.Collections.Generic;
using PentaWork.Xrm.Scheduler.Proxies.Entities;

namespace PentaWork.Xrm.Scheduler.Tests.Fake
{
	public static class FakeODataV4DataSource
	{	
		#region FakeRelationships
		public static class Relationships 
		{
		}
		#endregion

		#region Fake
		public static ODataV4DataSource Create()
		{
			var faker = new Faker<ODataV4DataSource>()
			.RuleFor(e => e.Description, fake => fake.Lorem.Word())
			.RuleFor(e => e.Parameter10Type, fake => fake.Random.Bool())
			.RuleFor(e => e.Parameter1Type, fake => fake.Random.Bool())
			.RuleFor(e => e.Parameter2Type, fake => fake.Random.Bool())
			.RuleFor(e => e.Parameter3Type, fake => fake.Random.Bool())
			.RuleFor(e => e.Parameter4Type, fake => fake.Random.Bool())
			.RuleFor(e => e.Parameter5Type, fake => fake.Random.Bool())
			.RuleFor(e => e.Parameter6Type, fake => fake.Random.Bool())
			.RuleFor(e => e.Parameter7Type, fake => fake.Random.Bool())
			.RuleFor(e => e.Parameter8Type, fake => fake.Random.Bool())
			.RuleFor(e => e.Parameter9Type, fake => fake.Random.Bool())
			.RuleFor(e => e.Name, fake => fake.Lorem.Word())
			.RuleFor(e => e.Id, fake => Guid.NewGuid())
			.RuleFor(e => e.PaginationMode, fake => fake.Random.Bool())
			.RuleFor(e => e.PaginationMode2, fake => fake.PickRandom<ODataV4DataSource.ePaginationMode>())
			.RuleFor(e => e.Parameter10name, fake => fake.Lorem.Word())
			.RuleFor(e => e.Parameter10value, fake => fake.Lorem.Word())
			.RuleFor(e => e.Parameter1name, fake => fake.Lorem.Word())
			.RuleFor(e => e.Parameter1value, fake => fake.Lorem.Word())
			.RuleFor(e => e.Parameter2name, fake => fake.Lorem.Word())
			.RuleFor(e => e.Parameter2value, fake => fake.Lorem.Word())
			.RuleFor(e => e.Parameter3name, fake => fake.Lorem.Word())
			.RuleFor(e => e.Parameter3value, fake => fake.Lorem.Word())
			.RuleFor(e => e.Parameter4name, fake => fake.Lorem.Word())
			.RuleFor(e => e.Parameter4value, fake => fake.Lorem.Word())
			.RuleFor(e => e.Parameter5name, fake => fake.Lorem.Word())
			.RuleFor(e => e.Parameter5value, fake => fake.Lorem.Word())
			.RuleFor(e => e.Parameter6name, fake => fake.Lorem.Word())
			.RuleFor(e => e.Parameter6value, fake => fake.Lorem.Word())
			.RuleFor(e => e.Parameter7name, fake => fake.Lorem.Word())
			.RuleFor(e => e.Parameter7value, fake => fake.Lorem.Word())
			.RuleFor(e => e.Parameter8name, fake => fake.Lorem.Word())
			.RuleFor(e => e.Parameter8value, fake => fake.Lorem.Word())
			.RuleFor(e => e.Parameter9name, fake => fake.Lorem.Word())
			.RuleFor(e => e.Parameter9value, fake => fake.Lorem.Word())
			.RuleFor(e => e.ReturnInlineCount, fake => fake.Random.Bool())
			.RuleFor(e => e.Timeout, fake => fake.Random.Int())
			.RuleFor(e => e.URL, fake => fake.Lorem.Word());
			return faker.Generate();
		}
		#endregion
	}
}

