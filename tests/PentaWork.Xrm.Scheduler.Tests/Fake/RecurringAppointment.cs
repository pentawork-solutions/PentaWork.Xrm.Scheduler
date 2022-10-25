using Bogus;
using System;
using FakeXrmEasy;
using System.Collections.Generic;
using PentaWork.Xrm.Scheduler.Proxies.Entities;

namespace PentaWork.Xrm.Scheduler.Tests.Fake
{
	public static class FakeRecurringAppointment
	{	
		#region FakeRelationships
		public static class Relationships 
		{
			/// <summary>1:N recurringappointmentmaster_actioncard</summary>
			public static readonly XrmFakedRelationship RecurringappointmentmasterActioncard = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "activityid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "recurringappointmentmaster",
					Entity2LogicalName = "actioncard",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N recurringappointmentmaster_activity_parties</summary>
			public static readonly XrmFakedRelationship RecurringappointmentmasterActivityParties = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "activityid",
					Entity2Attribute = "activityid",
					Entity1LogicalName = "recurringappointmentmaster",
					Entity2LogicalName = "activityparty",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N RecurringAppointmentMaster_Annotation</summary>
			public static readonly XrmFakedRelationship RecurringAppointmentMasterAnnotation = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "activityid",
					Entity2Attribute = "objectid",
					Entity1LogicalName = "recurringappointmentmaster",
					Entity2LogicalName = "annotation",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N recurringappointmentmaster_appointment</summary>
			public static readonly XrmFakedRelationship RecurringappointmentmasterAppointment = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "activityid",
					Entity2Attribute = "seriesid",
					Entity1LogicalName = "recurringappointmentmaster",
					Entity2LogicalName = "appointment",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N RecurringAppointmentMaster_AsyncOperations</summary>
			public static readonly XrmFakedRelationship RecurringAppointmentMasterAsyncOperations = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "activityid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "recurringappointmentmaster",
					Entity2LogicalName = "asyncoperation",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N RecurringAppointmentMaster_BulkDeleteFailures</summary>
			public static readonly XrmFakedRelationship RecurringAppointmentMasterBulkDeleteFailures = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "activityid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "recurringappointmentmaster",
					Entity2LogicalName = "bulkdeletefailure",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N recurringappointmentmaster_campaignresponse</summary>
			public static readonly XrmFakedRelationship RecurringappointmentmasterCampaignresponse = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "activityid",
					Entity2Attribute = "originatingactivityid",
					Entity1LogicalName = "recurringappointmentmaster",
					Entity2LogicalName = "campaignresponse",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N recurringappointmentmaster_connections1</summary>
			public static readonly XrmFakedRelationship RecurringappointmentmasterConnections1 = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "activityid",
					Entity2Attribute = "record1id",
					Entity1LogicalName = "recurringappointmentmaster",
					Entity2LogicalName = "connection",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N recurringappointmentmaster_connections2</summary>
			public static readonly XrmFakedRelationship RecurringappointmentmasterConnections2 = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "activityid",
					Entity2Attribute = "record2id",
					Entity1LogicalName = "recurringappointmentmaster",
					Entity2LogicalName = "connection",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N RecurringAppointmentMaster_DuplicateBaseRecord</summary>
			public static readonly XrmFakedRelationship RecurringAppointmentMasterDuplicateBaseRecord = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "activityid",
					Entity2Attribute = "baserecordid",
					Entity1LogicalName = "recurringappointmentmaster",
					Entity2LogicalName = "duplicaterecord",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N RecurringAppointmentMaster_DuplicateMatchingRecord</summary>
			public static readonly XrmFakedRelationship RecurringAppointmentMasterDuplicateMatchingRecord = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "activityid",
					Entity2Attribute = "duplicaterecordid",
					Entity1LogicalName = "recurringappointmentmaster",
					Entity2LogicalName = "duplicaterecord",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N recurringappointmentmaster_PostFollows</summary>
			public static readonly XrmFakedRelationship RecurringappointmentmasterPostFollows = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "activityid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "recurringappointmentmaster",
					Entity2LogicalName = "postfollow",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N recurringappointmentmaster_principalobjectattributeaccess</summary>
			public static readonly XrmFakedRelationship RecurringappointmentmasterPrincipalobjectattributeaccess = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "activityid",
					Entity2Attribute = "objectid",
					Entity1LogicalName = "recurringappointmentmaster",
					Entity2LogicalName = "principalobjectattributeaccess",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N RecurringAppointmentMaster_ProcessSessions</summary>
			public static readonly XrmFakedRelationship RecurringAppointmentMasterProcessSessions = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "activityid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "recurringappointmentmaster",
					Entity2LogicalName = "processsession",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N RecurringAppointmentMaster_QueueItem</summary>
			public static readonly XrmFakedRelationship RecurringAppointmentMasterQueueItem = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "activityid",
					Entity2Attribute = "objectid",
					Entity1LogicalName = "recurringappointmentmaster",
					Entity2LogicalName = "queueitem",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N RecurringAppointmentMaster_SyncErrors</summary>
			public static readonly XrmFakedRelationship RecurringAppointmentMasterSyncErrors = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "activityid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "recurringappointmentmaster",
					Entity2LogicalName = "syncerror",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

		}
		#endregion

		#region Fake
		public static RecurringAppointment Create()
		{
			var faker = new Faker<RecurringAppointment>()
			.RuleFor(e => e.Id, fake => Guid.NewGuid())
			.RuleFor(e => e.ActivityType, fake => fake.Lorem.Word())
			.RuleFor(e => e.Category, fake => fake.Lorem.Word())
			.RuleFor(e => e.Createdbyname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Createdbyyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.CreatedOn, fake => fake.Date.Soon())
			.RuleFor(e => e.Createdonbehalfbyname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Createdonbehalfbyyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.DayOfMonth, fake => fake.Random.Int())
			.RuleFor(e => e.DaysOfWeekMask, fake => fake.Random.Int())
			.RuleFor(e => e.DeletedAppointments, fake => fake.Lorem.Word())
			.RuleFor(e => e.Description, fake => fake.Lorem.Word())
			.RuleFor(e => e.Duration, fake => fake.Random.Int())
			.RuleFor(e => e.EffectiveEndDate, fake => fake.Date.Soon())
			.RuleFor(e => e.EffectiveStartDate, fake => fake.Date.Soon())
			.RuleFor(e => e.PatternEndTime, fake => fake.Date.Soon())
			.RuleFor(e => e.ExchangeRate, fake => fake.Finance.Amount())
			.RuleFor(e => e.ExpansionStateCode, fake => fake.PickRandom<RecurringAppointment.eExpansionStateCode>())
			.RuleFor(e => e.FirstDayOfWeek, fake => fake.Random.Int())
			.RuleFor(e => e.OutlookRecurringAppointmentMaster, fake => fake.Lorem.Word())
			.RuleFor(e => e.ImportSequenceNumber, fake => fake.Random.Int())
			.RuleFor(e => e.Instance, fake => fake.PickRandom<RecurringAppointment.eInstance>())
			.RuleFor(e => e.AppointmentType, fake => fake.PickRandom<RecurringAppointment.eAppointmentType>())
			.RuleFor(e => e.Interval, fake => fake.Random.Int())
			.RuleFor(e => e.AllDayEvent, fake => fake.Random.Bool())
			.RuleFor(e => e.IsBilled, fake => fake.Random.Bool())
			.RuleFor(e => e.IsPrivate, fake => fake.Random.Bool())
			.RuleFor(e => e.NthMonthly, fake => fake.Random.Bool())
			.RuleFor(e => e.NthYearly, fake => fake.Random.Bool())
			.RuleFor(e => e.Regenerate, fake => fake.Random.Bool())
			.RuleFor(e => e.IsRegularActivity, fake => fake.Random.Bool())
			.RuleFor(e => e.IsUnsafe, fake => fake.Random.Int())
			.RuleFor(e => e.EveryWeekday, fake => fake.Random.Bool())
			.RuleFor(e => e.IsWorkflowCreated, fake => fake.Random.Bool())
			.RuleFor(e => e.LastExpandedInstanceDate, fake => fake.Date.Soon())
			.RuleFor(e => e.Location, fake => fake.Lorem.Word())
			.RuleFor(e => e.Modifiedbyname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Modifiedbyyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.ModifiedOn, fake => fake.Date.Soon())
			.RuleFor(e => e.Modifiedonbehalfbyname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Modifiedonbehalfbyyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.MonthOfYear, fake => fake.PickRandom<RecurringAppointment.egMonthOfYear>())
			.RuleFor(e => e.NextExpandedInstanceDate, fake => fake.Date.Soon())
			.RuleFor(e => e.Occurrences, fake => fake.Random.Int())
			.RuleFor(e => e.OutlookRecurringAppointmentMasterOwner, fake => fake.Random.Int())
			.RuleFor(e => e.RecordCreatedOn, fake => fake.Date.Soon())
			.RuleFor(e => e.Owneridname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Owneridtype, fake => fake.Lorem.Word())
			.RuleFor(e => e.Owneridyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.RecurrenceRangeEnd, fake => fake.Date.Soon())
			.RuleFor(e => e.PatternEndType, fake => fake.PickRandom<RecurringAppointment.ePatternEndType>())
			.RuleFor(e => e.RecurrenceRangeStart, fake => fake.Date.Soon())
			.RuleFor(e => e.Priority, fake => fake.PickRandom<RecurringAppointment.ePriority>())
			.RuleFor(e => e.ProcessId, fake => Guid.NewGuid())
			.RuleFor(e => e.RecurrenceFrequency, fake => fake.PickRandom<RecurringAppointment.eRecurrencePattern>())
			.RuleFor(e => e.Regardingobjectidname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Regardingobjectidyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.Regardingobjecttypecode, fake => fake.Lorem.Word())
			.RuleFor(e => e.SafeDescription, fake => fake.Lorem.Word())
			.RuleFor(e => e.EndTime, fake => fake.Date.Soon())
			.RuleFor(e => e.StartTime, fake => fake.Date.Soon())
			.RuleFor(e => e.SeriesStatus, fake => fake.Random.Bool())
			.RuleFor(e => e.Serviceidname, fake => fake.Lorem.Word())
			.RuleFor(e => e.SortDate, fake => fake.Date.Soon())
			.RuleFor(e => e.DeprecatedProcessStageId, fake => Guid.NewGuid())
			.RuleFor(e => e.PatternStartTime, fake => fake.Date.Soon())
			.RuleFor(e => e.Status, fake => fake.PickRandom<RecurringAppointment.eStatus>())
			.RuleFor(e => e.StatusReason, fake => fake.PickRandom<RecurringAppointment.eStatusReason>())
			.RuleFor(e => e.SubCategory, fake => fake.Lorem.Word())
			.RuleFor(e => e.Subject, fake => fake.Lorem.Word())
			.RuleFor(e => e.SubscriptionId, fake => Guid.NewGuid())
			.RuleFor(e => e.Timezoneruleversionnumber, fake => fake.Random.Int())
			.RuleFor(e => e.Transactioncurrencyidname, fake => fake.Lorem.Word())
			.RuleFor(e => e.DeprecatedTraversedPath, fake => fake.Lorem.Word())
			.RuleFor(e => e.UTCConversionTimeZoneCode, fake => fake.Random.Int())
			.RuleFor(e => e.Versionnumber, fake => fake.Random.Int());
			return faker.Generate();
		}
		#endregion
	}
}

