using Bogus;
using System;
using FakeXrmEasy;
using System.Collections.Generic;
using PentaWork.Xrm.Scheduler.Proxies.Entities;

namespace PentaWork.Xrm.Scheduler.Tests.Fake
{
	public static class FakeImportEntityMapping
	{	
		#region FakeRelationships
		public static class Relationships 
		{
		}
		#endregion

		#region Fake
		public static ImportEntityMapping Create()
		{
			var faker = new Faker<ImportEntityMapping>()
			.RuleFor(e => e.ComponentState, fake => fake.PickRandom<ImportEntityMapping.egComponentState>())
			.RuleFor(e => e.Createdbyname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Createdbyyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.Createdon, fake => fake.Date.Soon())
			.RuleFor(e => e.Createdonbehalfbyname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Createdonbehalfbyyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.RemoveDuplicates, fake => fake.PickRandom<ImportEntityMapping.eDetectDuplicates>())
			.RuleFor(e => e.Id, fake => Guid.NewGuid())
			.RuleFor(e => e.ImportentitymappingiduniqueId, fake => Guid.NewGuid())
			.RuleFor(e => e.DataMap, fake => fake.Lorem.Word())
			.RuleFor(e => e.IntroducedVersion, fake => fake.Lorem.Word())
			.RuleFor(e => e.State, fake => fake.Random.Bool())
			.RuleFor(e => e.Modifiedbyname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Modifiedbyyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.ModifiedOn, fake => fake.Date.Soon())
			.RuleFor(e => e.Modifiedonbehalfbyname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Modifiedonbehalfbyyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.RecordOverwriteTime, fake => fake.Date.Soon())
			.RuleFor(e => e.ProcessCode, fake => fake.PickRandom<ImportEntityMapping.eProcessCode>())
			.RuleFor(e => e.SolutionId, fake => Guid.NewGuid())
			.RuleFor(e => e.SourceEntityName, fake => fake.Lorem.Word())
			.RuleFor(e => e.Status, fake => fake.PickRandom<ImportEntityMapping.eStatus>())
			.RuleFor(e => e.StatusReason, fake => fake.PickRandom<ImportEntityMapping.eStatusReason>())
			.RuleFor(e => e.SolutionId2, fake => Guid.NewGuid())
			.RuleFor(e => e.TargetEntity, fake => fake.Lorem.Word());
			return faker.Generate();
		}
		#endregion
	}
}

