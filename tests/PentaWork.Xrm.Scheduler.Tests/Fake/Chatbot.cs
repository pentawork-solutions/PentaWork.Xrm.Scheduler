using Bogus;
using System;
using FakeXrmEasy;
using System.Collections.Generic;
using PentaWork.Xrm.Scheduler.Proxies.Entities;

namespace PentaWork.Xrm.Scheduler.Tests.Fake
{
	public static class FakeChatbot
	{	
		#region FakeRelationships
		public static class Relationships 
		{
			/// <summary>1:N bot_AsyncOperations</summary>
			public static readonly XrmFakedRelationship BotAsyncOperations = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "botid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "bot",
					Entity2LogicalName = "asyncoperation",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N bot_BulkDeleteFailures</summary>
			public static readonly XrmFakedRelationship BotBulkDeleteFailures = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "botid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "bot",
					Entity2LogicalName = "bulkdeletefailure",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N bot_conversationtranscript</summary>
			public static readonly XrmFakedRelationship BotConversationtranscript = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "botid",
					Entity2Attribute = "bot_conversationtranscriptid",
					Entity1LogicalName = "bot",
					Entity2LogicalName = "conversationtranscript",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N bot_MailboxTrackingFolders</summary>
			public static readonly XrmFakedRelationship BotMailboxTrackingFolders = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "botid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "bot",
					Entity2LogicalName = "mailboxtrackingfolder",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N bot_PrincipalObjectAttributeAccesses</summary>
			public static readonly XrmFakedRelationship BotPrincipalObjectAttributeAccesses = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "botid",
					Entity2Attribute = "objectid",
					Entity1LogicalName = "bot",
					Entity2LogicalName = "principalobjectattributeaccess",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N bot_ProcessSession</summary>
			public static readonly XrmFakedRelationship BotProcessSession = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "botid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "bot",
					Entity2LogicalName = "processsession",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N bot_SyncErrors</summary>
			public static readonly XrmFakedRelationship BotSyncErrors = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "botid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "bot",
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

		}
		#endregion

		#region Fake
		public static Chatbot Create()
		{
			var faker = new Faker<Chatbot>()
			.RuleFor(e => e.AccessControlPolicy, fake => fake.PickRandom<Chatbot.eAccessControlPolicy>())
			.RuleFor(e => e.ApplicationManifestInformation, fake => fake.Lorem.Word())
			.RuleFor(e => e.AuthenticationMode, fake => fake.PickRandom<Chatbot.eAuthenticationMode>())
			.RuleFor(e => e.AuthenticationTrigger, fake => fake.PickRandom<Chatbot.eAuthenticationTrigger>())
			.RuleFor(e => e.AuthorizedSecurityGroups, fake => fake.Lorem.Word())
			.RuleFor(e => e.Id, fake => Guid.NewGuid())
			.RuleFor(e => e.RowIdUniqueId, fake => Guid.NewGuid())
			.RuleFor(e => e.ComponentState, fake => fake.PickRandom<Chatbot.egComponentState>())
			.RuleFor(e => e.Configuration, fake => fake.Lorem.Word())
			.RuleFor(e => e.Createdbyname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Createdbyyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.CreatedOn, fake => fake.Date.Soon())
			.RuleFor(e => e.Createdonbehalfbyname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Createdonbehalfbyyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.IconBase64, fake => fake.Lorem.Word())
			.RuleFor(e => e.ImportSequenceNumber, fake => fake.Random.Int())
			.RuleFor(e => e.IsManaged, fake => fake.Random.Bool())
			.RuleFor(e => e.Language, fake => fake.PickRandom<Chatbot.eLanguage>())
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
			.RuleFor(e => e.Publishedbyname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Publishedbyyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.PublishedOn, fake => fake.Date.Soon())
			.RuleFor(e => e.SchemaName, fake => fake.Lorem.Word())
			.RuleFor(e => e.SolutionId, fake => Guid.NewGuid())
			.RuleFor(e => e.Status, fake => fake.PickRandom<Chatbot.eStatus>())
			.RuleFor(e => e.StatusReason, fake => fake.PickRandom<Chatbot.eStatusReason>())
			.RuleFor(e => e.SolutionId2, fake => Guid.NewGuid())
			.RuleFor(e => e.TimeZoneRuleVersionNumber, fake => fake.Random.Int())
			.RuleFor(e => e.UTCConversionTimeZoneCode, fake => fake.Random.Int())
			.RuleFor(e => e.VersionNumber, fake => fake.Random.Int());
			return faker.Generate();
		}
		#endregion
	}
}

