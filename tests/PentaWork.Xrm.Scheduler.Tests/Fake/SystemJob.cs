using Bogus;
using System;
using FakeXrmEasy;
using System.Collections.Generic;
using PentaWork.Xrm.Scheduler.Proxies.Entities;

namespace PentaWork.Xrm.Scheduler.Tests.Fake
{
	public static class FakeSystemJob
	{	
		#region FakeRelationships
		public static class Relationships 
		{
			/// <summary>1:N AsyncOperation_BulkDeleteOperation</summary>
			public static readonly XrmFakedRelationship AsyncOperationBulkDeleteOperation = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "asyncoperationid",
					Entity2Attribute = "asyncoperationid",
					Entity1LogicalName = "asyncoperation",
					Entity2LogicalName = "bulkdeleteoperation",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N AsyncOperation_DuplicateBaseRecord</summary>
			public static readonly XrmFakedRelationship AsyncOperationDuplicateBaseRecord = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "asyncoperationid",
					Entity2Attribute = "asyncoperationid",
					Entity1LogicalName = "asyncoperation",
					Entity2LogicalName = "duplicaterecord",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N AsyncOperation_Emails</summary>
			public static readonly XrmFakedRelationship AsyncOperationEmails = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "asyncoperationid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "asyncoperation",
					Entity2LogicalName = "email",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N asyncoperation_FileAttachments</summary>
			public static readonly XrmFakedRelationship AsyncoperationFileAttachments = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "asyncoperationid",
					Entity2Attribute = "objectid",
					Entity1LogicalName = "asyncoperation",
					Entity2LogicalName = "fileattachment",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N AsyncOperation_MailboxTrackingFolder</summary>
			public static readonly XrmFakedRelationship AsyncOperationMailboxTrackingFolder = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "asyncoperationid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "asyncoperation",
					Entity2LogicalName = "mailboxtrackingfolder",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N AsyncOperation_SocialActivities</summary>
			public static readonly XrmFakedRelationship AsyncOperationSocialActivities = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "asyncoperationid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "asyncoperation",
					Entity2LogicalName = "socialactivity",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_workflowlog_asyncoperation_childworkflow</summary>
			public static readonly XrmFakedRelationship LkWorkflowlogAsyncoperationChildworkflow = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "asyncoperationid",
					Entity2Attribute = "childworkflowinstanceid",
					Entity1LogicalName = "asyncoperation",
					Entity2LogicalName = "workflowlog",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_workflowlog_asyncoperations</summary>
			public static readonly XrmFakedRelationship LkWorkflowlogAsyncoperations = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "asyncoperationid",
					Entity2Attribute = "asyncoperationid",
					Entity1LogicalName = "asyncoperation",
					Entity2LogicalName = "workflowlog",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

		}
		#endregion

		#region Fake
		public static SystemJob Create()
		{
			var faker = new Faker<SystemJob>()
			.RuleFor(e => e.Id, fake => Guid.NewGuid())
			.RuleFor(e => e.BreadcrumbId, fake => Guid.NewGuid())
			.RuleFor(e => e.CallerOrigin, fake => fake.Lorem.Word())
			.RuleFor(e => e.CompletedOn, fake => fake.Date.Soon())
			.RuleFor(e => e.CorrelationId, fake => Guid.NewGuid())
			.RuleFor(e => e.CorrelationUpdatedTime, fake => fake.Date.Soon())
			.RuleFor(e => e.Createdbyname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Createdbyyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.CreatedOn, fake => fake.Date.Soon())
			.RuleFor(e => e.Createdonbehalfbyname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Createdonbehalfbyyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.Data, fake => fake.Lorem.Word())
			.RuleFor(e => e.DatablobidName, fake => fake.Lorem.Word())
			.RuleFor(e => e.DependencyToken, fake => fake.Lorem.Word())
			.RuleFor(e => e.Depth, fake => fake.Random.Int())
			.RuleFor(e => e.ErrorCode, fake => fake.Random.Int())
			.RuleFor(e => e.ExecutionTimeSpan, fake => fake.Random.Double())
			.RuleFor(e => e.ExpanderStartTime, fake => fake.Date.Soon())
			.RuleFor(e => e.FriendlyMessage, fake => fake.Lorem.Word())
			.RuleFor(e => e.Host, fake => fake.Lorem.Word())
			.RuleFor(e => e.WaitingForEvent, fake => fake.Random.Bool())
			.RuleFor(e => e.Message, fake => fake.Lorem.Word())
			.RuleFor(e => e.MessageName, fake => fake.Lorem.Word())
			.RuleFor(e => e.Modifiedbyname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Modifiedbyyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.ModifiedOn, fake => fake.Date.Soon())
			.RuleFor(e => e.Modifiedonbehalfbyname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Modifiedonbehalfbyyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.SystemJobName, fake => fake.Lorem.Word())
			.RuleFor(e => e.SystemJobType, fake => fake.PickRandom<SystemJob.eSystemJobType>())
			.RuleFor(e => e.Owneridname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Owneridtype, fake => fake.Lorem.Word())
			.RuleFor(e => e.Owneridyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.Owningextensionidname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Owningextensiontypecode, fake => fake.Lorem.Word())
			.RuleFor(e => e.ParentpluginexecutionId, fake => Guid.NewGuid())
			.RuleFor(e => e.PostponeUntil, fake => fake.Date.Soon())
			.RuleFor(e => e.PrimaryEntityType, fake => fake.Lorem.Word())
			.RuleFor(e => e.RecurrencePattern, fake => fake.Lorem.Word())
			.RuleFor(e => e.RecurrenceStart, fake => fake.Date.Soon())
			.RuleFor(e => e.Regardingobjectidname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Regardingobjectidyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.Regardingobjecttypecode, fake => fake.Lorem.Word())
			.RuleFor(e => e.RequestId, fake => Guid.NewGuid())
			.RuleFor(e => e.RetainJobHistory, fake => fake.Random.Bool())
			.RuleFor(e => e.RetryCount, fake => fake.Random.Int())
			.RuleFor(e => e.RootExecutionContext, fake => fake.Lorem.Word())
			.RuleFor(e => e.Sequence, fake => fake.Random.Int())
			.RuleFor(e => e.StartedOn, fake => fake.Date.Soon())
			.RuleFor(e => e.Status, fake => fake.PickRandom<SystemJob.eStatus>())
			.RuleFor(e => e.StatusReason, fake => fake.PickRandom<SystemJob.eStatusReason>())
			.RuleFor(e => e.Subtype, fake => fake.Random.Int())
			.RuleFor(e => e.Timezoneruleversionnumber, fake => fake.Random.Int())
			.RuleFor(e => e.Utcconversiontimezonecode, fake => fake.Random.Int())
			.RuleFor(e => e.Workflowactivationidname, fake => fake.Lorem.Word())
			.RuleFor(e => e.WorkflowIsBlocked, fake => fake.Random.Bool())
			.RuleFor(e => e.WorkflowStage, fake => fake.Lorem.Word())
			.RuleFor(e => e.WorkflowState, fake => fake.Lorem.Word())
			.RuleFor(e => e.Workload, fake => fake.Lorem.Word());
			return faker.Generate();
		}
		#endregion
	}
}

