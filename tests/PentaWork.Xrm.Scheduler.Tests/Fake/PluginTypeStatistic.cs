using Bogus;
using System;
using FakeXrmEasy;
using System.Collections.Generic;
using PentaWork.Xrm.Scheduler.Proxies.Entities;

namespace PentaWork.Xrm.Scheduler.Tests.Fake
{
	public static class FakePluginTypeStatistic
	{	
		#region FakeRelationships
		public static class Relationships 
		{
		}
		#endregion

		#region Fake
		public static PluginTypeStatistic Create()
		{
			var faker = new Faker<PluginTypeStatistic>()
			.RuleFor(e => e.TheAverageExecutionTime, fake => fake.Random.Int())
			.RuleFor(e => e.PercentageContributionToCrashes, fake => fake.Random.Int())
			.RuleFor(e => e.NumberOfTimesCrashed, fake => fake.Random.Int())
			.RuleFor(e => e.PercentageOfCrashes, fake => fake.Random.Int())
			.RuleFor(e => e.Createdbyname, fake => fake.Lorem.Word())
			.RuleFor(e => e.CreatedOn, fake => fake.Date.Soon())
			.RuleFor(e => e.Createdonbehalfbyname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Createdonbehalfbyyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.ExecutionCount, fake => fake.Random.Int())
			.RuleFor(e => e.FailureCount, fake => fake.Random.Int())
			.RuleFor(e => e.FailurePercent, fake => fake.Random.Int())
			.RuleFor(e => e.Modifiedbyname, fake => fake.Lorem.Word())
			.RuleFor(e => e.ModifiedOn, fake => fake.Date.Soon())
			.RuleFor(e => e.Modifiedonbehalfbyname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Modifiedonbehalfbyyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.Plugintypeidname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Id, fake => Guid.NewGuid())
			.RuleFor(e => e.TerminateCPUContributionPercent, fake => fake.Random.Int())
			.RuleFor(e => e.TerminateHandlesContributionPercent, fake => fake.Random.Int())
			.RuleFor(e => e.TerminateMemoryContributionPercent, fake => fake.Random.Int())
			.RuleFor(e => e.TerminateOtherContributionPercent, fake => fake.Random.Int());
			return faker.Generate();
		}
		#endregion
	}
}

