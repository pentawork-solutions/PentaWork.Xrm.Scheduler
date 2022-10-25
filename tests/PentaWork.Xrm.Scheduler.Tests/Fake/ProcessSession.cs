using Bogus;
using System;
using FakeXrmEasy;
using System.Collections.Generic;
using PentaWork.Xrm.Scheduler.Proxies.Entities;

namespace PentaWork.Xrm.Scheduler.Tests.Fake
{
	public static class FakeProcessSession
	{	
		#region FakeRelationships
		public static class Relationships 
		{
			/// <summary>1:N lk_processsession_nextlinkedsessionid</summary>
			public static readonly XrmFakedRelationship LkProcesssessionNextlinkedsessionid = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "processsessionid",
					Entity2Attribute = "nextlinkedsessionid",
					Entity1LogicalName = "processsession",
					Entity2LogicalName = "processsession",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_processsession_originatingsessionid</summary>
			public static readonly XrmFakedRelationship LkProcesssessionOriginatingsessionid = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "processsessionid",
					Entity2Attribute = "originatingsessionid",
					Entity1LogicalName = "processsession",
					Entity2LogicalName = "processsession",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_processsession_previouslinkedsessionid</summary>
			public static readonly XrmFakedRelationship LkProcesssessionPreviouslinkedsessionid = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "processsessionid",
					Entity2Attribute = "previouslinkedsessionid",
					Entity1LogicalName = "processsession",
					Entity2LogicalName = "processsession",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_workflowlog_processsession</summary>
			public static readonly XrmFakedRelationship LkWorkflowlogProcesssession = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "processsessionid",
					Entity2Attribute = "asyncoperationid",
					Entity1LogicalName = "processsession",
					Entity2LogicalName = "workflowlog",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_workflowlog_processsession_childworkflow</summary>
			public static readonly XrmFakedRelationship LkWorkflowlogProcesssessionChildworkflow = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "processsessionid",
					Entity2Attribute = "childworkflowinstanceid",
					Entity1LogicalName = "processsession",
					Entity2LogicalName = "workflowlog",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N processsession_connections1</summary>
			public static readonly XrmFakedRelationship ProcesssessionConnections1 = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "processsessionid",
					Entity2Attribute = "record1id",
					Entity1LogicalName = "processsession",
					Entity2LogicalName = "connection",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N processsession_connections2</summary>
			public static readonly XrmFakedRelationship ProcesssessionConnections2 = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "processsessionid",
					Entity2Attribute = "record2id",
					Entity1LogicalName = "processsession",
					Entity2LogicalName = "connection",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N processsession_PostFollows</summary>
			public static readonly XrmFakedRelationship ProcesssessionPostFollows = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "processsessionid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "processsession",
					Entity2LogicalName = "postfollow",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N ProcessSession_SyncErrors</summary>
			public static readonly XrmFakedRelationship ProcessSessionSyncErrors = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "processsessionid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "processsession",
					Entity2LogicalName = "syncerror",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

		}
		#endregion

		#region Fake
		public static ProcessSession Create()
		{
			var faker = new Faker<ProcessSession>()
			.RuleFor(e => e.ActivityName, fake => fake.Lorem.Word())
			.RuleFor(e => e.Canceledbyname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Canceledbyyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.CanceledOn, fake => fake.Date.Soon())
			.RuleFor(e => e.Comments, fake => fake.Lorem.Word())
			.RuleFor(e => e.Completedbyname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Completedbyyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.CompletedOn, fake => fake.Date.Soon())
			.RuleFor(e => e.Createdbyname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Createdbyyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.CreatedOn, fake => fake.Date.Soon())
			.RuleFor(e => e.Createdonbehalfbyname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Createdonbehalfbyyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.ErrorCode, fake => fake.Random.Int())
			.RuleFor(e => e.Executedbyname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Executedbyyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.ExecutedOn, fake => fake.Date.Soon())
			.RuleFor(e => e.InputArguments, fake => fake.Lorem.Word())
			.RuleFor(e => e.Modifiedbyname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Modifiedbyyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.ModifiedOn, fake => fake.Date.Soon())
			.RuleFor(e => e.Modifiedonbehalfbyname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Modifiedonbehalfbyyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.Name, fake => fake.Lorem.Word())
			.RuleFor(e => e.Nextlinkedsessionidname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Originatingsessionidname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Owneridname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Owneridtype, fake => fake.Lorem.Word())
			.RuleFor(e => e.Owneridyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.Previouslinkedsessionidname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Processidname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Id, fake => Guid.NewGuid())
			.RuleFor(e => e.DialogStage, fake => fake.Lorem.Word())
			.RuleFor(e => e.ProcessState, fake => fake.Lorem.Word())
			.RuleFor(e => e.ProtectionKey, fake => fake.Lorem.Word())
			.RuleFor(e => e.Regardingobjectidname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Regardingobjectidyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.Regardingobjecttypecode, fake => fake.Lorem.Word())
			.RuleFor(e => e.Startedbyname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Startedbyyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.StartedOn, fake => fake.Date.Soon())
			.RuleFor(e => e.Status, fake => fake.PickRandom<ProcessSession.eStatus>())
			.RuleFor(e => e.StatusReason, fake => fake.PickRandom<ProcessSession.eStatusReason>())
			.RuleFor(e => e.StepName, fake => fake.Lorem.Word());
			return faker.Generate();
		}
		#endregion
	}
}

