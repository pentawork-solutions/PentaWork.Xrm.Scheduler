using Bogus;
using System;
using FakeXrmEasy;
using System.Collections.Generic;
using PentaWork.Xrm.Scheduler.Proxies.Entities;

namespace PentaWork.Xrm.Scheduler.Tests.Fake
{
	public static class FakeActivityMonitor
	{	
		#region FakeRelationships
		public static class Relationships 
		{
			/// <summary>1:N activitymonitor_AsyncOperations</summary>
			public static readonly XrmFakedRelationship ActivitymonitorAsyncOperations = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "activitymonitorid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "activitymonitor",
					Entity2LogicalName = "asyncoperation",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N activitymonitor_BulkDeleteFailures</summary>
			public static readonly XrmFakedRelationship ActivitymonitorBulkDeleteFailures = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "activitymonitorid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "activitymonitor",
					Entity2LogicalName = "bulkdeletefailure",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N activitymonitor_DuplicateBaseRecord</summary>
			public static readonly XrmFakedRelationship ActivitymonitorDuplicateBaseRecord = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "activitymonitorid",
					Entity2Attribute = "baserecordid",
					Entity1LogicalName = "activitymonitor",
					Entity2LogicalName = "duplicaterecord",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N activitymonitor_DuplicateMatchingRecord</summary>
			public static readonly XrmFakedRelationship ActivitymonitorDuplicateMatchingRecord = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "activitymonitorid",
					Entity2Attribute = "duplicaterecordid",
					Entity1LogicalName = "activitymonitor",
					Entity2LogicalName = "duplicaterecord",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N activitymonitor_MailboxTrackingFolders</summary>
			public static readonly XrmFakedRelationship ActivitymonitorMailboxTrackingFolders = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "activitymonitorid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "activitymonitor",
					Entity2LogicalName = "mailboxtrackingfolder",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N activitymonitor_PrincipalObjectAttributeAccesses</summary>
			public static readonly XrmFakedRelationship ActivitymonitorPrincipalObjectAttributeAccesses = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "activitymonitorid",
					Entity2Attribute = "objectid",
					Entity1LogicalName = "activitymonitor",
					Entity2LogicalName = "principalobjectattributeaccess",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N activitymonitor_ProcessSession</summary>
			public static readonly XrmFakedRelationship ActivitymonitorProcessSession = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "activitymonitorid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "activitymonitor",
					Entity2LogicalName = "processsession",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N activitymonitor_SyncErrors</summary>
			public static readonly XrmFakedRelationship ActivitymonitorSyncErrors = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "activitymonitorid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "activitymonitor",
					Entity2LogicalName = "syncerror",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

		}
		#endregion

		#region Fake
		public static ActivityMonitor Create()
		{
			var faker = new Faker<ActivityMonitor>()
			.RuleFor(e => e.Id, fake => Guid.NewGuid())
			.RuleFor(e => e.AdvancedSettings, fake => fake.Lorem.Word())
			.RuleFor(e => e.Conditionidname, fake => fake.Lorem.Word())
			.RuleFor(e => e.ContactCreatedByRule, fake => fake.Random.Bool())
			.RuleFor(e => e.Createdbyname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Createdbyyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.EvaluatedOn, fake => fake.Date.Soon())
			.RuleFor(e => e.Createdonbehalfbyname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Createdonbehalfbyyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.CurrentState, fake => fake.PickRandom<ActivityMonitor.eCurrentState>())
			.RuleFor(e => e.EntitlementCheck, fake => fake.Random.Bool())
			.RuleFor(e => e.ImportSequenceNumber, fake => fake.Random.Int())
			.RuleFor(e => e.Modifiedbyname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Modifiedbyyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.ModifiedOn, fake => fake.Date.Soon())
			.RuleFor(e => e.Modifiedonbehalfbyname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Modifiedonbehalfbyyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.Monitoredactivityitemidname, fake => fake.Lorem.Word())
			.RuleFor(e => e.MonitoredActivityType, fake => fake.Lorem.Word())
			.RuleFor(e => e.Name, fake => fake.Lorem.Word())
			.RuleFor(e => e.RecordCreatedOn, fake => fake.Date.Soon())
			.RuleFor(e => e.Owneridname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Owneridtype, fake => fake.Lorem.Word())
			.RuleFor(e => e.Owneridyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.Reason, fake => fake.PickRandom<ActivityMonitor.eReason>())
			.RuleFor(e => e.Ruleidname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Status, fake => fake.PickRandom<ActivityMonitor.eStatus>())
			.RuleFor(e => e.StatusReason, fake => fake.PickRandom<ActivityMonitor.eStatusReason>())
			.RuleFor(e => e.TimeZoneRuleVersionNumber, fake => fake.Random.Int())
			.RuleFor(e => e.UTCConversionTimeZoneCode, fake => fake.Random.Int())
			.RuleFor(e => e.VersionNumber, fake => fake.Random.Int());
			return faker.Generate();
		}
		#endregion
	}
}

