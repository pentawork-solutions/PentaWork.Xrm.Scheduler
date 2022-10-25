using Bogus;
using System;
using FakeXrmEasy;
using System.Collections.Generic;
using PentaWork.Xrm.Scheduler.Proxies.Entities;

namespace PentaWork.Xrm.Scheduler.Tests.Fake
{
	public static class FakeSolutionHistoryData
	{	
		#region FakeRelationships
		public static class Relationships 
		{
		}
		#endregion

		#region Fake
		public static SolutionHistoryData Create()
		{
			var faker = new Faker<SolutionHistoryData>()
			.RuleFor(e => e.TheActivityId, fake => Guid.NewGuid())
			.RuleFor(e => e.TheCorrelationId, fake => Guid.NewGuid())
			.RuleFor(e => e.EndTime, fake => fake.Date.Soon())
			.RuleFor(e => e.ErrorCode, fake => fake.Random.Int())
			.RuleFor(e => e.ExceptionMessage, fake => fake.Lorem.Word())
			.RuleFor(e => e.ExceptionStack, fake => fake.Lorem.Word())
			.RuleFor(e => e.IsSolutionManaged, fake => fake.Random.Bool())
			.RuleFor(e => e.IsPublishedByMicrosoft, fake => fake.Random.Bool())
			.RuleFor(e => e.IsOverwriteCustomizations, fake => fake.Random.Bool())
			.RuleFor(e => e.IsSolutionPatch, fake => fake.Random.Bool())
			.RuleFor(e => e.Operation, fake => fake.PickRandom<SolutionHistoryData.eOperation>())
			.RuleFor(e => e.PackageName, fake => fake.Lorem.Word())
			.RuleFor(e => e.PackageVersion, fake => fake.Lorem.Word())
			.RuleFor(e => e.PublisherName, fake => fake.Lorem.Word())
			.RuleFor(e => e.Result, fake => fake.Random.Int())
			.RuleFor(e => e.Id, fake => Guid.NewGuid())
			.RuleFor(e => e.TheSolutionId, fake => Guid.NewGuid())
			.RuleFor(e => e.SolutionName, fake => fake.Lorem.Word())
			.RuleFor(e => e.SolutionVersion, fake => fake.Lorem.Word())
			.RuleFor(e => e.StartTime, fake => fake.Date.Soon())
			.RuleFor(e => e.Status, fake => fake.PickRandom<SolutionHistoryData.eStatus>())
			.RuleFor(e => e.SubOperation, fake => fake.PickRandom<SolutionHistoryData.eSubOperation>());
			return faker.Generate();
		}
		#endregion
	}
}

