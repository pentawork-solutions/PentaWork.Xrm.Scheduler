using Bogus;
using System;
using FakeXrmEasy;
using System.Collections.Generic;
using PentaWork.Xrm.Scheduler.Proxies.Entities;

namespace PentaWork.Xrm.Scheduler.Tests.Fake
{
	public static class FakePluginAssembly
	{	
		#region FakeRelationships
		public static class Relationships 
		{
			/// <summary>1:N pluginassembly_plugintype</summary>
			public static readonly XrmFakedRelationship PluginassemblyPlugintype = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "pluginassemblyid",
					Entity2Attribute = "pluginassemblyid",
					Entity1LogicalName = "pluginassembly",
					Entity2LogicalName = "plugintype",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

		}
		#endregion

		#region Fake
		public static PluginAssembly Create()
		{
			var faker = new Faker<PluginAssembly>()
			.RuleFor(e => e.SpecifiesModeOfAuthenticationWithWebSources, fake => fake.PickRandom<PluginAssembly.eAuthType>())
			.RuleFor(e => e.ComponentState, fake => fake.PickRandom<PluginAssembly.egComponentState>())
			.RuleFor(e => e.Content, fake => fake.Lorem.Word())
			.RuleFor(e => e.Createdbyname, fake => fake.Lorem.Word())
			.RuleFor(e => e.CreatedOn, fake => fake.Date.Soon())
			.RuleFor(e => e.Createdonbehalfbyname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Createdonbehalfbyyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.Culture, fake => fake.Lorem.Word())
			.RuleFor(e => e.Customizationlevel, fake => fake.Random.Int())
			.RuleFor(e => e.Description, fake => fake.Lorem.Word())
			.RuleFor(e => e.IntroducedVersion, fake => fake.Lorem.Word())
			.RuleFor(e => e.State, fake => fake.Random.Bool())
			.RuleFor(e => e.IsolationMode, fake => fake.PickRandom<PluginAssembly.eIsolationMode>())
			.RuleFor(e => e.Ispasswordset, fake => fake.Random.Bool())
			.RuleFor(e => e.Major, fake => fake.Random.Int())
			.RuleFor(e => e.Minor, fake => fake.Random.Int())
			.RuleFor(e => e.Modifiedbyname, fake => fake.Lorem.Word())
			.RuleFor(e => e.ModifiedOn, fake => fake.Date.Soon())
			.RuleFor(e => e.Modifiedonbehalfbyname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Modifiedonbehalfbyyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.Name, fake => fake.Lorem.Word())
			.RuleFor(e => e.RecordOverwriteTime, fake => fake.Date.Soon())
			.RuleFor(e => e.UserPassword, fake => fake.Lorem.Word())
			.RuleFor(e => e.Path, fake => fake.Lorem.Word())
			.RuleFor(e => e.Id, fake => Guid.NewGuid())
			.RuleFor(e => e.PluginassemblyiduniqueId, fake => Guid.NewGuid())
			.RuleFor(e => e.PublicKeyToken, fake => fake.Lorem.Word())
			.RuleFor(e => e.SolutionId, fake => Guid.NewGuid())
			.RuleFor(e => e.Sourcehash, fake => fake.Lorem.Word())
			.RuleFor(e => e.SourceType, fake => fake.PickRandom<PluginAssembly.eSourceType>())
			.RuleFor(e => e.SolutionId2, fake => Guid.NewGuid())
			.RuleFor(e => e.WebUrl, fake => fake.Lorem.Word())
			.RuleFor(e => e.UserName, fake => fake.Lorem.Word())
			.RuleFor(e => e.Version, fake => fake.Lorem.Word())
			.RuleFor(e => e.Versionnumber, fake => fake.Random.Int());
			return faker.Generate();
		}
		#endregion
	}
}

