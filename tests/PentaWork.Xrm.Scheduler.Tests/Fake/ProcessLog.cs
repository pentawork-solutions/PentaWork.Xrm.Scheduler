using Bogus;
using System;
using FakeXrmEasy;
using System.Collections.Generic;
using PentaWork.Xrm.Scheduler.Proxies.Entities;

namespace PentaWork.Xrm.Scheduler.Tests.Fake
{
	public static class FakeProcessLog
	{	
		#region FakeRelationships
		public static class Relationships 
		{
			/// <summary>1:N workflowlog_FileAttachments</summary>
			public static readonly XrmFakedRelationship WorkflowlogFileAttachments = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "workflowlogid",
					Entity2Attribute = "objectid",
					Entity1LogicalName = "workflowlog",
					Entity2LogicalName = "fileattachment",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

		}
		#endregion

		#region Fake
		public static ProcessLog Create()
		{
			var faker = new Faker<ProcessLog>()
			.RuleFor(e => e.ActivityName, fake => fake.Lorem.Word())
			.RuleFor(e => e.ParentRecord2, fake => fake.Lorem.Word())
			.RuleFor(e => e.ChildAsyncOperationName, fake => fake.Lorem.Word())
			.RuleFor(e => e.Entity, fake => fake.Lorem.Word())
			.RuleFor(e => e.CompletedOn, fake => fake.Date.Soon())
			.RuleFor(e => e.CreatedByName, fake => fake.Lorem.Word())
			.RuleFor(e => e.CreatedByYomiName, fake => fake.Lorem.Word())
			.RuleFor(e => e.StartedOn, fake => fake.Date.Soon())
			.RuleFor(e => e.CreatedByDelegateName, fake => fake.Lorem.Word())
			.RuleFor(e => e.CreatedByDelegateYomiName, fake => fake.Lorem.Word())
			.RuleFor(e => e.StepDescription, fake => fake.Lorem.Word())
			.RuleFor(e => e.Duration, fake => fake.Random.Int())
			.RuleFor(e => e.ErrorMessage, fake => fake.Random.Int())
			.RuleFor(e => e.ErrorText, fake => fake.Lorem.Word())
			.RuleFor(e => e.InputsName, fake => fake.Lorem.Word())
			.RuleFor(e => e.InteractionActivityResult, fake => fake.Lorem.Word())
			.RuleFor(e => e.IterationCount, fake => fake.Random.Int())
			.RuleFor(e => e.Message, fake => fake.Lorem.Word())
			.RuleFor(e => e.ModifiedByName, fake => fake.Lorem.Word())
			.RuleFor(e => e.ModifiedByYomiName, fake => fake.Lorem.Word())
			.RuleFor(e => e.ModifiedOn, fake => fake.Date.Soon())
			.RuleFor(e => e.ModifiedOnBehalfByName, fake => fake.Lorem.Word())
			.RuleFor(e => e.ModifiedOnBehalfByYomiName, fake => fake.Lorem.Word())
			.RuleFor(e => e.Entity2, fake => fake.Lorem.Word())
			.RuleFor(e => e.OutputsName, fake => fake.Lorem.Word())
			.RuleFor(e => e.OwnerIdType, fake => fake.Lorem.Word())
			.RuleFor(e => e.RegardingObjectIdName, fake => fake.Lorem.Word())
			.RuleFor(e => e.RegardingObjectIdYomiName, fake => fake.Lorem.Word())
			.RuleFor(e => e.RegardingObjectTypeCode, fake => fake.Lorem.Word())
			.RuleFor(e => e.RepetitionCount, fake => fake.Random.Int())
			.RuleFor(e => e.RepetitionId, fake => fake.Lorem.Word())
			.RuleFor(e => e.ProcessStage, fake => fake.Lorem.Word())
			.RuleFor(e => e.StartedOn2, fake => fake.Date.Soon())
			.RuleFor(e => e.Status, fake => fake.PickRandom<ProcessLog.eStatus>())
			.RuleFor(e => e.StepName, fake => fake.Lorem.Word())
			.RuleFor(e => e.Id, fake => Guid.NewGuid());
			return faker.Generate();
		}
		#endregion
	}
}

