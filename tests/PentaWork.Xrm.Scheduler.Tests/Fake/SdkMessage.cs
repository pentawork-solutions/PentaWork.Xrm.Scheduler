using Bogus;
using System;
using FakeXrmEasy;
using System.Collections.Generic;
using PentaWork.Xrm.Scheduler.Proxies.Entities;

namespace PentaWork.Xrm.Scheduler.Tests.Fake
{
	public static class FakeSdkMessage
	{	
		#region FakeRelationships
		public static class Relationships 
		{
			/// <summary>1:N sdkmessage_customapi</summary>
			public static readonly XrmFakedRelationship SdkmessageCustomapi = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "sdkmessageid",
					Entity2Attribute = "sdkmessageid",
					Entity1LogicalName = "sdkmessage",
					Entity2LogicalName = "customapi",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N sdkmessageid_sdkmessagefilter</summary>
			public static readonly XrmFakedRelationship SdkmessageidSdkmessagefilter = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "sdkmessageid",
					Entity2Attribute = "sdkmessageid",
					Entity1LogicalName = "sdkmessage",
					Entity2LogicalName = "sdkmessagefilter",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N sdkmessageid_sdkmessageprocessingstep</summary>
			public static readonly XrmFakedRelationship SdkmessageidSdkmessageprocessingstep = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "sdkmessageid",
					Entity2Attribute = "sdkmessageid",
					Entity1LogicalName = "sdkmessage",
					Entity2LogicalName = "sdkmessageprocessingstep",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

		}
		#endregion

		#region Fake
		public static SdkMessage Create()
		{
			var faker = new Faker<SdkMessage>()
			.RuleFor(e => e.AutoTransact, fake => fake.Random.Bool())
			.RuleFor(e => e.Availability, fake => fake.Random.Int())
			.RuleFor(e => e.CategoryName, fake => fake.Lorem.Word())
			.RuleFor(e => e.ComponentState, fake => fake.PickRandom<SdkMessage.egComponentState>())
			.RuleFor(e => e.Createdbyname, fake => fake.Lorem.Word())
			.RuleFor(e => e.CreatedOn, fake => fake.Date.Soon())
			.RuleFor(e => e.Createdonbehalfbyname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Createdonbehalfbyyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.Customizationlevel, fake => fake.Random.Int())
			.RuleFor(e => e.ExecutePrivilegeName, fake => fake.Lorem.Word())
			.RuleFor(e => e.Expand, fake => fake.Random.Bool())
			.RuleFor(e => e.IntroducedVersion, fake => fake.Lorem.Word())
			.RuleFor(e => e.IsActive, fake => fake.Random.Bool())
			.RuleFor(e => e.State, fake => fake.Random.Bool())
			.RuleFor(e => e.IsPrivate, fake => fake.Random.Bool())
			.RuleFor(e => e.Intent, fake => fake.Random.Bool())
			.RuleFor(e => e.IsValidForExecuteAsync, fake => fake.Random.Bool())
			.RuleFor(e => e.Modifiedbyname, fake => fake.Lorem.Word())
			.RuleFor(e => e.ModifiedOn, fake => fake.Date.Soon())
			.RuleFor(e => e.Modifiedonbehalfbyname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Modifiedonbehalfbyyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.Name, fake => fake.Lorem.Word())
			.RuleFor(e => e.RecordOverwriteTime, fake => fake.Date.Soon())
			.RuleFor(e => e.Id, fake => Guid.NewGuid())
			.RuleFor(e => e.SdkmessageiduniqueId, fake => Guid.NewGuid())
			.RuleFor(e => e.SolutionId, fake => Guid.NewGuid())
			.RuleFor(e => e.SolutionId2, fake => Guid.NewGuid())
			.RuleFor(e => e.Template, fake => fake.Random.Bool())
			.RuleFor(e => e.ThrottleSettings, fake => fake.Lorem.Word())
			.RuleFor(e => e.Versionnumber, fake => fake.Random.Int())
			.RuleFor(e => e.WorkflowSdkStepEnabled, fake => fake.Random.Bool());
			return faker.Generate();
		}
		#endregion
	}
}

