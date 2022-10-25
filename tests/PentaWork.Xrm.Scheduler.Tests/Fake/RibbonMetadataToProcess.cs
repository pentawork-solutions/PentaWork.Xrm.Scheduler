using Bogus;
using System;
using FakeXrmEasy;
using System.Collections.Generic;
using PentaWork.Xrm.Scheduler.Proxies.Entities;

namespace PentaWork.Xrm.Scheduler.Tests.Fake
{
	public static class FakeRibbonMetadataToProcess
	{	
		#region FakeRelationships
		public static class Relationships 
		{
		}
		#endregion

		#region Fake
		public static RibbonMetadataToProcess Create()
		{
			var faker = new Faker<RibbonMetadataToProcess>()
			.RuleFor(e => e.CompletedOn, fake => fake.Date.Soon())
			.RuleFor(e => e.CreatedOn, fake => fake.Date.Soon())
			.RuleFor(e => e.EntityLogicalName, fake => fake.Lorem.Word())
			.RuleFor(e => e.ExceptionMessageWhichOccurredDuringRibbonEntityProcessing, fake => fake.Lorem.Word())
			.RuleFor(e => e.IsEntityCreatedViaDbUpdate, fake => fake.Random.Int())
			.RuleFor(e => e.ProcessedOn, fake => fake.Date.Soon())
			.RuleFor(e => e.RetryCount, fake => fake.Random.Int())
			.RuleFor(e => e.Id, fake => Guid.NewGuid())
			.RuleFor(e => e.SolutionId, fake => Guid.NewGuid())
			.RuleFor(e => e.SolutionNameOfTheRibbonEntity, fake => fake.Lorem.Word())
			.RuleFor(e => e.Status, fake => fake.Random.Int());
			return faker.Generate();
		}
		#endregion
	}
}

