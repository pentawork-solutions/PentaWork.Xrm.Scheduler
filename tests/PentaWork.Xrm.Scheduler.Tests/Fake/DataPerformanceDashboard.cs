using Bogus;
using System;
using FakeXrmEasy;
using System.Collections.Generic;
using PentaWork.Xrm.Scheduler.Proxies.Entities;

namespace PentaWork.Xrm.Scheduler.Tests.Fake
{
	public static class FakeDataPerformanceDashboard
	{	
		#region FakeRelationships
		public static class Relationships 
		{
		}
		#endregion

		#region Fake
		public static DataPerformanceDashboard Create()
		{
			var faker = new Faker<DataPerformanceDashboard>()
			.RuleFor(e => e.AnyOptimizationApplied, fake => fake.Random.Bool())
			.RuleFor(e => e.AnyOptimizationAvailable, fake => fake.Random.Bool())
			.RuleFor(e => e.Component, fake => fake.Lorem.Word())
			.RuleFor(e => e.Count, fake => fake.Random.Int())
			.RuleFor(e => e.Id, fake => Guid.NewGuid())
			.RuleFor(e => e.Entity, fake => fake.Lorem.Word())
			.RuleFor(e => e.EstimatedOptimizationImpact, fake => fake.Finance.Amount())
			.RuleFor(e => e.ExecutionPeriod, fake => fake.Lorem.Word())
			.RuleFor(e => e.LastActionResult, fake => fake.Lorem.Word())
			.RuleFor(e => e.LastOptimizationDate, fake => fake.Date.Soon())
			.RuleFor(e => e.MaxTime, fake => fake.Finance.Amount())
			.RuleFor(e => e.MedianTime, fake => fake.Finance.Amount())
			.RuleFor(e => e.MinTime, fake => fake.Finance.Amount())
			.RuleFor(e => e.Operation, fake => fake.Lorem.Word())
			.RuleFor(e => e.OptimizationStatus, fake => fake.Lorem.Word())
			.RuleFor(e => e.OptimizationStorage, fake => fake.Finance.Amount())
			.RuleFor(e => e.OptimizationImpact, fake => fake.Lorem.Word())
			.RuleFor(e => e.Solution, fake => fake.Lorem.Word())
			.RuleFor(e => e.Weight, fake => fake.Finance.Amount());
			return faker.Generate();
		}
		#endregion
	}
}

