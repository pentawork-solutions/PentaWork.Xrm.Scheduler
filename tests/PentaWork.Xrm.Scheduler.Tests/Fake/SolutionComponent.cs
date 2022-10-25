using Bogus;
using System;
using FakeXrmEasy;
using System.Collections.Generic;
using PentaWork.Xrm.Scheduler.Proxies.Entities;

namespace PentaWork.Xrm.Scheduler.Tests.Fake
{
	public static class FakeSolutionComponent
	{	
		#region FakeRelationships
		public static class Relationships 
		{
			/// <summary>1:N solutioncomponent_parent_solutioncomponent</summary>
			public static readonly XrmFakedRelationship SolutioncomponentParentSolutioncomponent = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "solutioncomponentid",
					Entity2Attribute = "rootsolutioncomponentid",
					Entity1LogicalName = "solutioncomponent",
					Entity2LogicalName = "solutioncomponent",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

		}
		#endregion

		#region Fake
		public static SolutionComponent Create()
		{
			var faker = new Faker<SolutionComponent>()
			.RuleFor(e => e.ObjectTypeCode, fake => fake.PickRandom<SolutionComponent.egComponentType>())
			.RuleFor(e => e.CreatedOn, fake => fake.Date.Soon())
			.RuleFor(e => e.Createdonbehalfbyname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Createdonbehalfbyyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.IsThisComponentMetadata, fake => fake.Random.Bool())
			.RuleFor(e => e.ModifiedOn, fake => fake.Date.Soon())
			.RuleFor(e => e.Modifiedonbehalfbyname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Modifiedonbehalfbyyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.RegardingId, fake => Guid.NewGuid())
			.RuleFor(e => e.RootComponentBehavior, fake => fake.PickRandom<SolutionComponent.eIncludeBehavior>())
			.RuleFor(e => e.RootSolutionComponentId, fake => Guid.NewGuid())
			.RuleFor(e => e.Id, fake => Guid.NewGuid())
			.RuleFor(e => e.Solutionidname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Versionnumber, fake => fake.Random.Int());
			return faker.Generate();
		}
		#endregion
	}
}

