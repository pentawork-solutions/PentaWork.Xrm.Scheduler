using Bogus;
using System;
using FakeXrmEasy;
using System.Collections.Generic;
using PentaWork.Xrm.Scheduler.Proxies.Entities;

namespace PentaWork.Xrm.Scheduler.Tests.Fake
{
	public static class FakeSocialActivity
	{	
		#region FakeRelationships
		public static class Relationships 
		{
			/// <summary>1:N slakpiinstance_socialactivity</summary>
			public static readonly XrmFakedRelationship SlakpiinstanceSocialactivity = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "activityid",
					Entity2Attribute = "regarding",
					Entity1LogicalName = "socialactivity",
					Entity2LogicalName = "slakpiinstance",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N socialactivity_activity_parties</summary>
			public static readonly XrmFakedRelationship SocialactivityActivityParties = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "activityid",
					Entity2Attribute = "activityid",
					Entity1LogicalName = "socialactivity",
					Entity2LogicalName = "activityparty",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N SocialActivity_Annotation</summary>
			public static readonly XrmFakedRelationship SocialActivityAnnotation = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "activityid",
					Entity2Attribute = "objectid",
					Entity1LogicalName = "socialactivity",
					Entity2LogicalName = "annotation",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N SocialActivity_AsyncOperations</summary>
			public static readonly XrmFakedRelationship SocialActivityAsyncOperations = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "activityid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "socialactivity",
					Entity2LogicalName = "asyncoperation",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N SocialActivity_BulkDeleteFailures</summary>
			public static readonly XrmFakedRelationship SocialActivityBulkDeleteFailures = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "activityid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "socialactivity",
					Entity2LogicalName = "bulkdeletefailure",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N socialactivity_connections1</summary>
			public static readonly XrmFakedRelationship SocialactivityConnections1 = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "activityid",
					Entity2Attribute = "record1id",
					Entity1LogicalName = "socialactivity",
					Entity2LogicalName = "connection",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N socialactivity_connections2</summary>
			public static readonly XrmFakedRelationship SocialactivityConnections2 = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "activityid",
					Entity2Attribute = "record2id",
					Entity1LogicalName = "socialactivity",
					Entity2LogicalName = "connection",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N SocialActivity_DuplicateBaseRecord</summary>
			public static readonly XrmFakedRelationship SocialActivityDuplicateBaseRecord = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "activityid",
					Entity2Attribute = "baserecordid",
					Entity1LogicalName = "socialactivity",
					Entity2LogicalName = "duplicaterecord",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N SocialActivity_DuplicateMatchingRecord</summary>
			public static readonly XrmFakedRelationship SocialActivityDuplicateMatchingRecord = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "activityid",
					Entity2Attribute = "duplicaterecordid",
					Entity1LogicalName = "socialactivity",
					Entity2LogicalName = "duplicaterecord",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N socialactivity_principalobjectattributeaccess</summary>
			public static readonly XrmFakedRelationship SocialactivityPrincipalobjectattributeaccess = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "activityid",
					Entity2Attribute = "objectid",
					Entity1LogicalName = "socialactivity",
					Entity2LogicalName = "principalobjectattributeaccess",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N SocialActivity_ProcessSessions</summary>
			public static readonly XrmFakedRelationship SocialActivityProcessSessions = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "activityid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "socialactivity",
					Entity2LogicalName = "processsession",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N SocialActivity_QueueItem</summary>
			public static readonly XrmFakedRelationship SocialActivityQueueItem = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "activityid",
					Entity2Attribute = "objectid",
					Entity1LogicalName = "socialactivity",
					Entity2LogicalName = "queueitem",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N SocialActivity_SyncErrors</summary>
			public static readonly XrmFakedRelationship SocialActivitySyncErrors = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "activityid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "socialactivity",
					Entity2LogicalName = "syncerror",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

		}
		#endregion

		#region Fake
		public static SocialActivity Create()
		{
			var faker = new Faker<SocialActivity>()
			.RuleFor(e => e.AdditionalParameters, fake => fake.Lorem.Word())
			.RuleFor(e => e.Id, fake => Guid.NewGuid())
			.RuleFor(e => e.ActivityType, fake => fake.Lorem.Word())
			.RuleFor(e => e.ActualDuration, fake => fake.Random.Int())
			.RuleFor(e => e.ActualEnd, fake => fake.Date.Soon())
			.RuleFor(e => e.ActualStart, fake => fake.Date.Soon())
			.RuleFor(e => e.SocialChannel, fake => fake.PickRandom<SocialActivity.egSocialChannel>())
			.RuleFor(e => e.CreatedDate, fake => fake.Date.Soon())
			.RuleFor(e => e.Createdonbehalfbyname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Createdonbehalfbyyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.PostDescription, fake => fake.Lorem.Word())
			.RuleFor(e => e.Direction, fake => fake.Random.Bool())
			.RuleFor(e => e.ExchangeRate, fake => fake.Finance.Amount())
			.RuleFor(e => e.ImportSequenceNumber, fake => fake.Random.Int())
			.RuleFor(e => e.InResponseTo, fake => fake.Lorem.Word())
			.RuleFor(e => e.IsBilled, fake => fake.Random.Bool())
			.RuleFor(e => e.IsRegularActivity, fake => fake.Random.Bool())
			.RuleFor(e => e.IsWorkflowCreated, fake => fake.Random.Bool())
			.RuleFor(e => e.LastOnHoldTime, fake => fake.Date.Soon())
			.RuleFor(e => e.LastUpdated, fake => fake.Date.Soon())
			.RuleFor(e => e.Modifiedonbehalfbyname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Modifiedonbehalfbyyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.OnHoldTimeMinutes, fake => fake.Random.Int())
			.RuleFor(e => e.RecordCreatedOn, fake => fake.Date.Soon())
			.RuleFor(e => e.Owneridname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Owneridtype, fake => fake.Lorem.Word())
			.RuleFor(e => e.Owneridyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.PostAuthorParent, fake => fake.Lorem.Word())
			.RuleFor(e => e.PostAuthorParent2, fake => fake.Lorem.Word())
			.RuleFor(e => e.PostAuthorParent3, fake => fake.Lorem.Word())
			.RuleFor(e => e.PostAuthorName, fake => fake.Lorem.Word())
			.RuleFor(e => e.PostAuthorType, fake => fake.Lorem.Word())
			.RuleFor(e => e.PostAuthorYomiName, fake => fake.Lorem.Word())
			.RuleFor(e => e.Postedbyname, fake => fake.Lorem.Word())
			.RuleFor(e => e.CreatedOn, fake => fake.Date.Soon())
			.RuleFor(e => e.PostID, fake => fake.Lorem.Word())
			.RuleFor(e => e.ReceivedAs, fake => fake.PickRandom<SocialActivity.egPostMessageType>())
			.RuleFor(e => e.PostedTo, fake => fake.Lorem.Word())
			.RuleFor(e => e.PostURL, fake => fake.Lorem.Word())
			.RuleFor(e => e.Priority, fake => fake.PickRandom<SocialActivity.ePriority>())
			.RuleFor(e => e.ProcessId, fake => Guid.NewGuid())
			.RuleFor(e => e.Regardingobjectidname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Regardingobjectidyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.Regardingobjecttypecode, fake => fake.Lorem.Word())
			.RuleFor(e => e.ScheduledDuration, fake => fake.Random.Int())
			.RuleFor(e => e.DueDate, fake => fake.Date.Soon())
			.RuleFor(e => e.StartDate, fake => fake.Date.Soon())
			.RuleFor(e => e.SentimentValue, fake => fake.Random.Double())
			.RuleFor(e => e.Serviceidname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Slainvokedidname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Slaname, fake => fake.Lorem.Word())
			.RuleFor(e => e.SocialAdditionalParameters, fake => fake.Lorem.Word())
			.RuleFor(e => e.SortDate, fake => fake.Date.Soon())
			.RuleFor(e => e.DeprecatedProcessStageId, fake => Guid.NewGuid())
			.RuleFor(e => e.Status, fake => fake.PickRandom<SocialActivity.eActivityStatus>())
			.RuleFor(e => e.StatusReason, fake => fake.PickRandom<SocialActivity.eStatusReason>())
			.RuleFor(e => e.Subject, fake => fake.Lorem.Word())
			.RuleFor(e => e.ThreadID, fake => fake.Lorem.Word())
			.RuleFor(e => e.TimeZoneRuleVersionNumber, fake => fake.Random.Int())
			.RuleFor(e => e.Transactioncurrencyidname, fake => fake.Lorem.Word())
			.RuleFor(e => e.DeprecatedTraversedPath, fake => fake.Lorem.Word())
			.RuleFor(e => e.UTCConversionTimeZoneCode, fake => fake.Random.Int())
			.RuleFor(e => e.VersionNumber, fake => fake.Random.Int());
			return faker.Generate();
		}
		#endregion
	}
}

