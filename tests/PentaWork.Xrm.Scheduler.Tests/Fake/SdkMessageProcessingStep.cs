using Bogus;
using System;
using FakeXrmEasy;
using System.Collections.Generic;
using PentaWork.Xrm.Scheduler.Proxies.Entities;

namespace PentaWork.Xrm.Scheduler.Tests.Fake
{
	public static class FakeSdkMessageProcessingStep
	{	
		#region FakeRelationships
		public static class Relationships 
		{
			/// <summary>1:N SdkMessageProcessingStep_AsyncOperations</summary>
			public static readonly XrmFakedRelationship SdkMessageProcessingStepAsyncOperations = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "sdkmessageprocessingstepid",
					Entity2Attribute = "owningextensionid",
					Entity1LogicalName = "sdkmessageprocessingstep",
					Entity2LogicalName = "asyncoperation",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N sdkmessageprocessingstepid_sdkmessageprocessingstepimage</summary>
			public static readonly XrmFakedRelationship SdkmessageprocessingstepidSdkmessageprocessingstepimage = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "sdkmessageprocessingstepid",
					Entity2Attribute = "sdkmessageprocessingstepid",
					Entity1LogicalName = "sdkmessageprocessingstep",
					Entity2LogicalName = "sdkmessageprocessingstepimage",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

		}
		#endregion

		#region Fake
		public static SdkMessageProcessingStep Create()
		{
			var faker = new Faker<SdkMessageProcessingStep>()
			.RuleFor(e => e.AsynchronousAutomaticDelete, fake => fake.Random.Bool())
			.RuleFor(e => e.Intent, fake => fake.Random.Bool())
			.RuleFor(e => e.ComponentState, fake => fake.PickRandom<SdkMessageProcessingStep.egComponentState>())
			.RuleFor(e => e.Configuration, fake => fake.Lorem.Word())
			.RuleFor(e => e.Createdbyname, fake => fake.Lorem.Word())
			.RuleFor(e => e.CreatedOn, fake => fake.Date.Soon())
			.RuleFor(e => e.Createdonbehalfbyname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Createdonbehalfbyyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.Customizationlevel, fake => fake.Random.Int())
			.RuleFor(e => e.Description, fake => fake.Lorem.Word())
			.RuleFor(e => e.EventExpander, fake => fake.Lorem.Word())
			.RuleFor(e => e.Eventhandlername, fake => fake.Lorem.Word())
			.RuleFor(e => e.Eventhandlertypecode, fake => fake.Lorem.Word())
			.RuleFor(e => e.FilteringAttributes, fake => fake.Lorem.Word())
			.RuleFor(e => e.Impersonatinguseridname, fake => fake.Lorem.Word())
			.RuleFor(e => e.IntroducedVersion, fake => fake.Lorem.Word())
			.RuleFor(e => e.InvocationSource, fake => fake.PickRandom<SdkMessageProcessingStep.eInvocationSource>())
			.RuleFor(e => e.State, fake => fake.Random.Bool())
			.RuleFor(e => e.ExecutionMode, fake => fake.PickRandom<SdkMessageProcessingStep.eMode>())
			.RuleFor(e => e.Modifiedbyname, fake => fake.Lorem.Word())
			.RuleFor(e => e.ModifiedOn, fake => fake.Date.Soon())
			.RuleFor(e => e.Modifiedonbehalfbyname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Modifiedonbehalfbyyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.Name, fake => fake.Lorem.Word())
			.RuleFor(e => e.RecordOverwriteTime, fake => fake.Date.Soon())
			.RuleFor(e => e.Plugintypeidname, fake => fake.Lorem.Word())
			.RuleFor(e => e.ExecutionOrder, fake => fake.Random.Int())
			.RuleFor(e => e.Sdkmessageidname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Id, fake => Guid.NewGuid())
			.RuleFor(e => e.SdkmessageprocessingstepiduniqueId, fake => Guid.NewGuid())
			.RuleFor(e => e.SolutionId, fake => Guid.NewGuid())
			.RuleFor(e => e.ExecutionStage, fake => fake.PickRandom<SdkMessageProcessingStep.eStage>())
			.RuleFor(e => e.Status, fake => fake.PickRandom<SdkMessageProcessingStep.eStatus>())
			.RuleFor(e => e.StatusReason, fake => fake.PickRandom<SdkMessageProcessingStep.eStatusReason>())
			.RuleFor(e => e.Deployment, fake => fake.PickRandom<SdkMessageProcessingStep.eSupportedDeployment>())
			.RuleFor(e => e.SolutionId2, fake => Guid.NewGuid())
			.RuleFor(e => e.Versionnumber, fake => fake.Random.Int());
			return faker.Generate();
		}
		#endregion
	}
}

