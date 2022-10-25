using Bogus;
using System;
using FakeXrmEasy;
using System.Collections.Generic;
using PentaWork.Xrm.Scheduler.Proxies.Entities;

namespace PentaWork.Xrm.Scheduler.Tests.Fake
{
	public static class FakeFlowSession
	{	
		#region FakeRelationships
		public static class Relationships 
		{
			/// <summary>1:N flowsession_AsyncOperations</summary>
			public static readonly XrmFakedRelationship FlowsessionAsyncOperations = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "flowsessionid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "flowsession",
					Entity2LogicalName = "asyncoperation",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N flowsession_BulkDeleteFailures</summary>
			public static readonly XrmFakedRelationship FlowsessionBulkDeleteFailures = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "flowsessionid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "flowsession",
					Entity2LogicalName = "bulkdeletefailure",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N flowsession_FileAttachments</summary>
			public static readonly XrmFakedRelationship FlowsessionFileAttachments = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "flowsessionid",
					Entity2Attribute = "objectid",
					Entity1LogicalName = "flowsession",
					Entity2LogicalName = "fileattachment",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N flowsession_MailboxTrackingFolders</summary>
			public static readonly XrmFakedRelationship FlowsessionMailboxTrackingFolders = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "flowsessionid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "flowsession",
					Entity2LogicalName = "mailboxtrackingfolder",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N flowsession_PrincipalObjectAttributeAccesses</summary>
			public static readonly XrmFakedRelationship FlowsessionPrincipalObjectAttributeAccesses = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "flowsessionid",
					Entity2Attribute = "objectid",
					Entity1LogicalName = "flowsession",
					Entity2LogicalName = "principalobjectattributeaccess",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N flowsession_SyncErrors</summary>
			public static readonly XrmFakedRelationship FlowsessionSyncErrors = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "flowsessionid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "flowsession",
					Entity2LogicalName = "syncerror",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N flowsession_workflowbinary_FlowSessionId</summary>
			public static readonly XrmFakedRelationship FlowsessionWorkflowbinaryFlowSessionId = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "flowsessionid",
					Entity2Attribute = "flowsessionid",
					Entity1LogicalName = "flowsession",
					Entity2LogicalName = "workflowbinary",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

		}
		#endregion

		#region Fake
		public static FlowSession Create()
		{
			var faker = new Faker<FlowSession>()
			.RuleFor(e => e.AdditionalcontextName, fake => fake.Lorem.Word())
			.RuleFor(e => e.CompletedOn, fake => fake.Date.Soon())
			.RuleFor(e => e.Context, fake => fake.Lorem.Word())
			.RuleFor(e => e.CorrelationId, fake => fake.Lorem.Word())
			.RuleFor(e => e.Createdbyname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Createdbyyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.CreatedOn, fake => fake.Date.Soon())
			.RuleFor(e => e.Createdonbehalfbyname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Createdonbehalfbyyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.ErrorCode, fake => fake.Lorem.Word())
			.RuleFor(e => e.ErrorMessage, fake => fake.Lorem.Word())
			.RuleFor(e => e.Id, fake => Guid.NewGuid())
			.RuleFor(e => e.Gateway, fake => fake.Lorem.Word())
			.RuleFor(e => e.ImportSequenceNumber, fake => fake.Random.Int())
			.RuleFor(e => e.Modifiedbyname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Modifiedbyyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.ModifiedOn, fake => fake.Date.Soon())
			.RuleFor(e => e.Modifiedonbehalfbyname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Modifiedonbehalfbyyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.Name, fake => fake.Lorem.Word())
			.RuleFor(e => e.OutputsName, fake => fake.Lorem.Word())
			.RuleFor(e => e.RecordCreatedOn, fake => fake.Date.Soon())
			.RuleFor(e => e.Owneridname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Owneridtype, fake => fake.Lorem.Word())
			.RuleFor(e => e.Owneridyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.ProcessVersion, fake => fake.Lorem.Word())
			.RuleFor(e => e.Regardingobjectidname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Regardingobjectidyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.Regardingobjecttypecode, fake => fake.Lorem.Word())
			.RuleFor(e => e.StartedOn, fake => fake.Date.Soon())
			.RuleFor(e => e.Status, fake => fake.PickRandom<FlowSession.eStatus>())
			.RuleFor(e => e.StatusReason, fake => fake.PickRandom<FlowSession.eStatusReason>())
			.RuleFor(e => e.TimeZoneRuleVersionNumber, fake => fake.Random.Int())
			.RuleFor(e => e.UTCConversionTimeZoneCode, fake => fake.Random.Int())
			.RuleFor(e => e.VersionNumber, fake => fake.Random.Int());
			return faker.Generate();
		}
		#endregion
	}
}

