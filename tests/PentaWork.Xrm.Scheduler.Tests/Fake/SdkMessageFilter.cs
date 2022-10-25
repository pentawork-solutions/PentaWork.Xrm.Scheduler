using Bogus;
using System;
using FakeXrmEasy;
using System.Collections.Generic;
using PentaWork.Xrm.Scheduler.Proxies.Entities;

namespace PentaWork.Xrm.Scheduler.Tests.Fake
{
	public static class FakeSdkMessageFilter
	{	
		#region FakeRelationships
		public static class Relationships 
		{
			/// <summary>1:N sdkmessagefilterid_sdkmessageprocessingstep</summary>
			public static readonly XrmFakedRelationship SdkmessagefilteridSdkmessageprocessingstep = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "sdkmessagefilterid",
					Entity2Attribute = "sdkmessagefilterid",
					Entity1LogicalName = "sdkmessagefilter",
					Entity2LogicalName = "sdkmessageprocessingstep",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

		}
		#endregion

		#region Fake
		public static SdkMessageFilter Create()
		{
			var faker = new Faker<SdkMessageFilter>()
			.RuleFor(e => e.Availability, fake => fake.Random.Int())
			.RuleFor(e => e.ComponentState, fake => fake.PickRandom<SdkMessageFilter.egComponentState>())
			.RuleFor(e => e.Createdbyname, fake => fake.Lorem.Word())
			.RuleFor(e => e.CreatedOn, fake => fake.Date.Soon())
			.RuleFor(e => e.Createdonbehalfbyname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Createdonbehalfbyyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.Customizationlevel, fake => fake.Random.Int())
			.RuleFor(e => e.IntroducedVersion, fake => fake.Lorem.Word())
			.RuleFor(e => e.CustomProcessingStepAllowed, fake => fake.Random.Bool())
			.RuleFor(e => e.State, fake => fake.Random.Bool())
			.RuleFor(e => e.Isvisible, fake => fake.Random.Bool())
			.RuleFor(e => e.Modifiedbyname, fake => fake.Lorem.Word())
			.RuleFor(e => e.ModifiedOn, fake => fake.Date.Soon())
			.RuleFor(e => e.Modifiedonbehalfbyname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Modifiedonbehalfbyyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.Name, fake => fake.Lorem.Word())
			.RuleFor(e => e.RecordOverwriteTime, fake => fake.Date.Soon())
			.RuleFor(e => e.PrimaryObjectTypeCode, fake => fake.Lorem.Word())
			.RuleFor(e => e.Restrictionlevel, fake => fake.Random.Int())
			.RuleFor(e => e.Id, fake => Guid.NewGuid())
			.RuleFor(e => e.SdkmessagefilteriduniqueId, fake => Guid.NewGuid())
			.RuleFor(e => e.Sdkmessageidname, fake => fake.Lorem.Word())
			.RuleFor(e => e.SecondaryObjectTypeCode, fake => fake.Lorem.Word())
			.RuleFor(e => e.SolutionId, fake => Guid.NewGuid())
			.RuleFor(e => e.SolutionId2, fake => Guid.NewGuid())
			.RuleFor(e => e.Versionnumber, fake => fake.Random.Int())
			.RuleFor(e => e.WorkflowSdkStepEnabled, fake => fake.Random.Bool());
			return faker.Generate();
		}
		#endregion
	}
}

