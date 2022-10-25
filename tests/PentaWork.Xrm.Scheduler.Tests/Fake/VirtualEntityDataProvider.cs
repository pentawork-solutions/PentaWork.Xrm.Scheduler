using Bogus;
using System;
using FakeXrmEasy;
using System.Collections.Generic;
using PentaWork.Xrm.Scheduler.Proxies.Entities;

namespace PentaWork.Xrm.Scheduler.Tests.Fake
{
	public static class FakeVirtualEntityDataProvider
	{	
		#region FakeRelationships
		public static class Relationships 
		{
		}
		#endregion

		#region Fake
		public static VirtualEntityDataProvider Create()
		{
			var faker = new Faker<VirtualEntityDataProvider>()
			.RuleFor(e => e.ComponentState, fake => fake.PickRandom<VirtualEntityDataProvider.egComponentState>())
			.RuleFor(e => e.ContainsTheCreatemultiplepluginIdThatShouldBeRunWhenCreateMultipleIsInvokedId, fake => Guid.NewGuid())
			.RuleFor(e => e.CreatePluginId, fake => Guid.NewGuid())
			.RuleFor(e => e.DataSourceEntityLogicalName, fake => fake.Lorem.Word())
			.RuleFor(e => e.DeletePluginId, fake => Guid.NewGuid())
			.RuleFor(e => e.Description, fake => fake.Lorem.Word())
			.RuleFor(e => e.Id, fake => Guid.NewGuid())
			.RuleFor(e => e.UniqueId, fake => Guid.NewGuid())
			.RuleFor(e => e.IntroducedVersion, fake => fake.Lorem.Word())
			.RuleFor(e => e.State, fake => fake.Random.Bool())
			.RuleFor(e => e.Name, fake => fake.Lorem.Word())
			.RuleFor(e => e.OrganizationId, fake => Guid.NewGuid())
			.RuleFor(e => e.RecordOverwriteTime, fake => fake.Date.Soon())
			.RuleFor(e => e.ContainsTheRetrieveentitychangespluginIdThatShouldBeRunWhenRetrieveEntityChangesIsInvokedId, fake => Guid.NewGuid())
			.RuleFor(e => e.MultipleRetrievePluginId, fake => Guid.NewGuid())
			.RuleFor(e => e.RetrievePluginId, fake => Guid.NewGuid())
			.RuleFor(e => e.SolutionId, fake => Guid.NewGuid())
			.RuleFor(e => e.SolutionId2, fake => Guid.NewGuid())
			.RuleFor(e => e.ContainsTheUpdatemultiplepluginIdThatShouldBeRunWhenUpdateMultipleIsInvokedId, fake => Guid.NewGuid())
			.RuleFor(e => e.UpdatePluginId, fake => Guid.NewGuid())
			.RuleFor(e => e.ContainsTheUpsertmultiplepluginIdThatShouldBeRunWhenUpsertMultipleIsInvokedId, fake => Guid.NewGuid())
			.RuleFor(e => e.ContainsTheUpsertpluginIdThatShouldBeRunWhenUpsertIsInvokedId, fake => Guid.NewGuid());
			return faker.Generate();
		}
		#endregion
	}
}

