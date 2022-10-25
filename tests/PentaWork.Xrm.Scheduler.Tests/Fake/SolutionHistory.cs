using Bogus;
using System;
using FakeXrmEasy;
using System.Collections.Generic;
using PentaWork.Xrm.Scheduler.Proxies.Entities;

namespace PentaWork.Xrm.Scheduler.Tests.Fake
{
	public static class FakeSolutionHistory
	{	
		#region FakeRelationships
		public static class Relationships 
		{
		}
		#endregion

		#region Fake
		public static SolutionHistory Create()
		{
			var faker = new Faker<SolutionHistory>()
			.RuleFor(e => e.ActivityId, fake => fake.Lorem.Word())
			.RuleFor(e => e.CorrelationId, fake => fake.Lorem.Word())
			.RuleFor(e => e.EndTime, fake => fake.Date.Soon())
			.RuleFor(e => e.ErrorCode, fake => fake.Lorem.Word())
			.RuleFor(e => e.ExceptionMessage, fake => fake.Lorem.Word())
			.RuleFor(e => e.ExceptionStack, fake => fake.Lorem.Word())
			.RuleFor(e => e.Managed, fake => fake.Random.Bool())
			.RuleFor(e => e.OverwriteCustomizations, fake => fake.Random.Bool())
			.RuleFor(e => e.Patch, fake => fake.Random.Bool())
			.RuleFor(e => e.SolutionName, fake => fake.Lorem.Word())
			.RuleFor(e => e.Operation, fake => fake.PickRandom<SolutionHistory.eMsdynOperation>())
			.RuleFor(e => e.PackageName, fake => fake.Lorem.Word())
			.RuleFor(e => e.PackageVersion, fake => fake.Lorem.Word())
			.RuleFor(e => e.PublisherId, fake => fake.Lorem.Word())
			.RuleFor(e => e.PublisherName, fake => fake.Lorem.Word())
			.RuleFor(e => e.Result, fake => fake.Random.Bool())
			.RuleFor(e => e.Id, fake => Guid.NewGuid())
			.RuleFor(e => e.SolutionId, fake => fake.Lorem.Word())
			.RuleFor(e => e.SolutionVersion, fake => fake.Lorem.Word())
			.RuleFor(e => e.StartTime, fake => fake.Date.Soon())
			.RuleFor(e => e.Status, fake => fake.PickRandom<SolutionHistory.eMsdynStatus>())
			.RuleFor(e => e.Suboperation, fake => fake.PickRandom<SolutionHistory.eMsdynSuboperation>())
			.RuleFor(e => e.TotalTimeseconds, fake => fake.Random.Int());
			return faker.Generate();
		}
		#endregion
	}
}

