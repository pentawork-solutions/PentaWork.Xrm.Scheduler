using Bogus;
using System;
using FakeXrmEasy;
using System.Collections.Generic;
using PentaWork.Xrm.Scheduler.Proxies.Entities;

namespace PentaWork.Xrm.Scheduler.Tests.Fake
{
	public static class FakeProcessTrigger
	{	
		#region FakeRelationships
		public static class Relationships 
		{
			/// <summary>1:N ProcessTrigger_SyncErrors</summary>
			public static readonly XrmFakedRelationship ProcessTriggerSyncErrors = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "processtriggerid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "processtrigger",
					Entity2LogicalName = "syncerror",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

		}
		#endregion

		#region Fake
		public static ProcessTrigger Create()
		{
			var faker = new Faker<ProcessTrigger>()
			.RuleFor(e => e.ComponentState, fake => fake.PickRandom<ProcessTrigger.egComponentState>())
			.RuleFor(e => e.ControlName, fake => fake.Lorem.Word())
			.RuleFor(e => e.ControlType, fake => fake.PickRandom<ProcessTrigger.eControlType>())
			.RuleFor(e => e.Createdbyname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Createdbyyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.CreatedOn, fake => fake.Date.Soon())
			.RuleFor(e => e.Createdonbehalfbyname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Createdonbehalfbyyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.Event, fake => fake.Lorem.Word())
			.RuleFor(e => e.FormName, fake => fake.Lorem.Word())
			.RuleFor(e => e.IsManaged, fake => fake.Random.Bool())
			.RuleFor(e => e.MethodId, fake => Guid.NewGuid())
			.RuleFor(e => e.Modifiedbyname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Modifiedbyyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.ModifiedOn, fake => fake.Date.Soon())
			.RuleFor(e => e.Modifiedonbehalfbyname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Modifiedonbehalfbyyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.RecordOverwriteTime, fake => fake.Date.Soon())
			.RuleFor(e => e.Owneridtype, fake => fake.Lorem.Word())
			.RuleFor(e => e.OwningBusinessUnitId, fake => Guid.NewGuid())
			.RuleFor(e => e.OwningUserId, fake => Guid.NewGuid())
			.RuleFor(e => e.PipelineStage, fake => fake.PickRandom<ProcessTrigger.eProcesstriggerPipelinestage>())
			.RuleFor(e => e.PrimaryEntity, fake => fake.Lorem.Word())
			.RuleFor(e => e.Processidname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Id, fake => Guid.NewGuid())
			.RuleFor(e => e.ProcessId, fake => Guid.NewGuid())
			.RuleFor(e => e.Scope, fake => fake.PickRandom<ProcessTrigger.ePblScope>())
			.RuleFor(e => e.SolutionId, fake => Guid.NewGuid())
			.RuleFor(e => e.SolutionId2, fake => Guid.NewGuid())
			.RuleFor(e => e.Versionnumber, fake => fake.Random.Int());
			return faker.Generate();
		}
		#endregion
	}
}

