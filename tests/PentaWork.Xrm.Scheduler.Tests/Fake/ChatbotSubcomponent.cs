using Bogus;
using System;
using FakeXrmEasy;
using System.Collections.Generic;
using PentaWork.Xrm.Scheduler.Proxies.Entities;

namespace PentaWork.Xrm.Scheduler.Tests.Fake
{
	public static class FakeChatbotSubcomponent
	{	
		#region FakeRelationships
		public static class Relationships 
		{
			/// <summary>1:N botcomponent_AsyncOperations</summary>
			public static readonly XrmFakedRelationship BotcomponentAsyncOperations = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "botcomponentid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "botcomponent",
					Entity2LogicalName = "asyncoperation",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N botcomponent_BulkDeleteFailures</summary>
			public static readonly XrmFakedRelationship BotcomponentBulkDeleteFailures = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "botcomponentid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "botcomponent",
					Entity2LogicalName = "bulkdeletefailure",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N botcomponent_MailboxTrackingFolders</summary>
			public static readonly XrmFakedRelationship BotcomponentMailboxTrackingFolders = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "botcomponentid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "botcomponent",
					Entity2LogicalName = "mailboxtrackingfolder",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N botcomponent_parent_botcomponent</summary>
			public static readonly XrmFakedRelationship BotcomponentParentBotcomponent = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "botcomponentid",
					Entity2Attribute = "parentbotcomponentid",
					Entity1LogicalName = "botcomponent",
					Entity2LogicalName = "botcomponent",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N botcomponent_PrincipalObjectAttributeAccesses</summary>
			public static readonly XrmFakedRelationship BotcomponentPrincipalObjectAttributeAccesses = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "botcomponentid",
					Entity2Attribute = "objectid",
					Entity1LogicalName = "botcomponent",
					Entity2LogicalName = "principalobjectattributeaccess",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N botcomponent_ProcessSession</summary>
			public static readonly XrmFakedRelationship BotcomponentProcessSession = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "botcomponentid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "botcomponent",
					Entity2LogicalName = "processsession",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N botcomponent_SyncErrors</summary>
			public static readonly XrmFakedRelationship BotcomponentSyncErrors = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "botcomponentid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "botcomponent",
					Entity2LogicalName = "syncerror",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>N:N bot_botcomponent</summary>
			public static readonly XrmFakedRelationship BotBotcomponent = 
				new XrmFakedRelationship
				{
					IntersectEntity = "bot_botcomponent",
					Entity1Attribute = "botid",
					Entity2Attribute = "botcomponentid",
					Entity1LogicalName = "bot",
					Entity2LogicalName = "botcomponent",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.ManyToMany
				};

			/// <summary>N:N botcomponent_botcomponent</summary>
			public static readonly XrmFakedRelationship BotcomponentBotcomponent = 
				new XrmFakedRelationship
				{
					IntersectEntity = "botcomponent_botcomponent",
					Entity1Attribute = "botcomponentidone",
					Entity2Attribute = "botcomponentidtwo",
					Entity1LogicalName = "botcomponent",
					Entity2LogicalName = "botcomponent",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.ManyToMany
				};

			/// <summary>N:N botcomponent_workflow</summary>
			public static readonly XrmFakedRelationship BotcomponentWorkflow = 
				new XrmFakedRelationship
				{
					IntersectEntity = "botcomponent_workflow",
					Entity1Attribute = "botcomponentid",
					Entity2Attribute = "workflowid",
					Entity1LogicalName = "botcomponent",
					Entity2LogicalName = "workflow",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.ManyToMany
				};

		}
		#endregion

		#region Fake
		public static ChatbotSubcomponent Create()
		{
			var faker = new Faker<ChatbotSubcomponent>()
			.RuleFor(e => e.Id, fake => Guid.NewGuid())
			.RuleFor(e => e.Category, fake => fake.Lorem.Word())
			.RuleFor(e => e.RowIdUniqueId, fake => Guid.NewGuid())
			.RuleFor(e => e.ComponentState, fake => fake.PickRandom<ChatbotSubcomponent.egComponentState>())
			.RuleFor(e => e.ComponentType, fake => fake.PickRandom<ChatbotSubcomponent.eComponentType>())
			.RuleFor(e => e.Content, fake => fake.Lorem.Word())
			.RuleFor(e => e.Createdbyname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Createdbyyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.CreatedOn, fake => fake.Date.Soon())
			.RuleFor(e => e.Createdonbehalfbyname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Createdonbehalfbyyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.ObiData, fake => fake.Lorem.Word())
			.RuleFor(e => e.Description, fake => fake.Lorem.Word())
			.RuleFor(e => e.ImportSequenceNumber, fake => fake.Random.Int())
			.RuleFor(e => e.IsManaged, fake => fake.Random.Bool())
			.RuleFor(e => e.Language, fake => fake.PickRandom<ChatbotSubcomponent.egChatbotLanguage>())
			.RuleFor(e => e.Modifiedbyname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Modifiedbyyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.ModifiedOn, fake => fake.Date.Soon())
			.RuleFor(e => e.Modifiedonbehalfbyname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Modifiedonbehalfbyyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.Name, fake => fake.Lorem.Word())
			.RuleFor(e => e.RecordCreatedOn, fake => fake.Date.Soon())
			.RuleFor(e => e.RecordOverwriteTime, fake => fake.Date.Soon())
			.RuleFor(e => e.Owneridname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Owneridtype, fake => fake.Lorem.Word())
			.RuleFor(e => e.Owneridyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.Parentbotcomponentidname, fake => fake.Lorem.Word())
			.RuleFor(e => e.SchemaName, fake => fake.Lorem.Word())
			.RuleFor(e => e.SolutionId, fake => Guid.NewGuid())
			.RuleFor(e => e.Status, fake => fake.PickRandom<ChatbotSubcomponent.eStatus>())
			.RuleFor(e => e.StatusReason, fake => fake.PickRandom<ChatbotSubcomponent.eStatusReason>())
			.RuleFor(e => e.SolutionId2, fake => Guid.NewGuid())
			.RuleFor(e => e.TimeZoneRuleVersionNumber, fake => fake.Random.Int())
			.RuleFor(e => e.UTCConversionTimeZoneCode, fake => fake.Random.Int())
			.RuleFor(e => e.VersionNumber, fake => fake.Random.Int());
			return faker.Generate();
		}
		#endregion
	}
}

