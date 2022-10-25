using Bogus;
using System;
using FakeXrmEasy;
using System.Collections.Generic;
using PentaWork.Xrm.Scheduler.Proxies.Entities;

namespace PentaWork.Xrm.Scheduler.Tests.Fake
{
	public static class FakeExpiredProcess
	{	
		#region FakeRelationships
		public static class Relationships 
		{
			/// <summary>1:N ExpiredProcess_ProcessSessions</summary>
			public static readonly XrmFakedRelationship ExpiredProcessProcessSessions = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "businessprocessflowinstanceid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "expiredprocess",
					Entity2LogicalName = "processsession",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N ExpiredProcess_SyncErrors</summary>
			public static readonly XrmFakedRelationship ExpiredProcessSyncErrors = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "businessprocessflowinstanceid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "expiredprocess",
					Entity2LogicalName = "syncerror",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_expiredprocess_workflowlogs</summary>
			public static readonly XrmFakedRelationship LkExpiredprocessWorkflowlogs = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "businessprocessflowinstanceid",
					Entity2Attribute = "asyncoperationid",
					Entity1LogicalName = "expiredprocess",
					Entity2LogicalName = "workflowlog",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

		}
		#endregion

		#region Fake
		public static ExpiredProcess Create()
		{
			var faker = new Faker<ExpiredProcess>()
			.RuleFor(e => e.Activestageidname, fake => fake.Lorem.Word())
			.RuleFor(e => e.ActiveStageStartedOn, fake => fake.Date.Soon())
			.RuleFor(e => e.Id, fake => Guid.NewGuid())
			.RuleFor(e => e.CompletedOn, fake => fake.Date.Soon())
			.RuleFor(e => e.Createdbyname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Createdbyyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.CreatedOn, fake => fake.Date.Soon())
			.RuleFor(e => e.Createdonbehalfbyname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Createdonbehalfbyyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.Duration, fake => fake.Random.Int())
			.RuleFor(e => e.ExchangeRate, fake => fake.Finance.Amount())
			.RuleFor(e => e.ImportSequenceNumber, fake => fake.Random.Int())
			.RuleFor(e => e.Knowledgearticleidname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Modifiedbyname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Modifiedbyyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.ModifiedOn, fake => fake.Date.Soon())
			.RuleFor(e => e.Modifiedonbehalfbyname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Modifiedonbehalfbyyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.ProcessName, fake => fake.Lorem.Word())
			.RuleFor(e => e.Organizationidname, fake => fake.Lorem.Word())
			.RuleFor(e => e.RecordCreatedOn, fake => fake.Date.Soon())
			.RuleFor(e => e.Processidname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Status, fake => fake.PickRandom<ExpiredProcess.eStatus>())
			.RuleFor(e => e.StatusReason, fake => fake.PickRandom<ExpiredProcess.eStatusReason>())
			.RuleFor(e => e.Transactioncurrencyidname, fake => fake.Lorem.Word())
			.RuleFor(e => e.CommaDelimitedStringOfProcessStageIdsThatRepresentVisitedStagesOfTheBusinessProcessFlowInstance, fake => fake.Lorem.Word())
			.RuleFor(e => e.VersionNumber, fake => fake.Random.Int());
			return faker.Generate();
		}
		#endregion
	}
}

