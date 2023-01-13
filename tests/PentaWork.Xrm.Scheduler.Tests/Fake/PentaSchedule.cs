using Bogus;
using System;
using FakeXrmEasy;
using System.Collections.Generic;
using PentaWork.Xrm.Scheduler.Proxies.Entities;

namespace PentaWork.Xrm.Scheduler.Tests.Fake
{
	public static class FakePentaSchedule
	{	
		#region FakeRelationships
		public static class Relationships 
		{
			/// <summary>1:N pw_pw_schedule_pw_penta_schedule_run_penta_schedule</summary>
			public static readonly XrmFakedRelationship PwPwSchedulePwPentaScheduleRunPentaSchedule = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "pw_scheduleid",
					Entity2Attribute = "pw_penta_schedule",
					Entity1LogicalName = "pw_schedule",
					Entity2LogicalName = "pw_penta_schedule_run",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N pw_schedule_AsyncOperations</summary>
			public static readonly XrmFakedRelationship PwScheduleAsyncOperations = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "pw_scheduleid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "pw_schedule",
					Entity2LogicalName = "asyncoperation",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N pw_schedule_BulkDeleteFailures</summary>
			public static readonly XrmFakedRelationship PwScheduleBulkDeleteFailures = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "pw_scheduleid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "pw_schedule",
					Entity2LogicalName = "bulkdeletefailure",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N pw_schedule_DuplicateBaseRecord</summary>
			public static readonly XrmFakedRelationship PwScheduleDuplicateBaseRecord = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "pw_scheduleid",
					Entity2Attribute = "baserecordid",
					Entity1LogicalName = "pw_schedule",
					Entity2LogicalName = "duplicaterecord",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N pw_schedule_DuplicateMatchingRecord</summary>
			public static readonly XrmFakedRelationship PwScheduleDuplicateMatchingRecord = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "pw_scheduleid",
					Entity2Attribute = "duplicaterecordid",
					Entity1LogicalName = "pw_schedule",
					Entity2LogicalName = "duplicaterecord",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N pw_schedule_MailboxTrackingFolders</summary>
			public static readonly XrmFakedRelationship PwScheduleMailboxTrackingFolders = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "pw_scheduleid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "pw_schedule",
					Entity2LogicalName = "mailboxtrackingfolder",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N pw_schedule_PrincipalObjectAttributeAccesses</summary>
			public static readonly XrmFakedRelationship PwSchedulePrincipalObjectAttributeAccesses = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "pw_scheduleid",
					Entity2Attribute = "objectid",
					Entity1LogicalName = "pw_schedule",
					Entity2LogicalName = "principalobjectattributeaccess",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N pw_schedule_ProcessSession</summary>
			public static readonly XrmFakedRelationship PwScheduleProcessSession = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "pw_scheduleid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "pw_schedule",
					Entity2LogicalName = "processsession",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N pw_schedule_SyncErrors</summary>
			public static readonly XrmFakedRelationship PwScheduleSyncErrors = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "pw_scheduleid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "pw_schedule",
					Entity2LogicalName = "syncerror",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

		}
		#endregion

		#region Fake
		public static PentaSchedule Create()
		{
			var faker = new Faker<PentaSchedule>()
			.RuleFor(e => e.Createdbyname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Createdbyyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.CreatedOn, fake => fake.Date.Soon())
			.RuleFor(e => e.Createdonbehalfbyname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Createdonbehalfbyyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.ImportSequenceNumber, fake => fake.Random.Int())
			.RuleFor(e => e.Modifiedbyname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Modifiedbyyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.ModifiedOn, fake => fake.Date.Soon())
			.RuleFor(e => e.Modifiedonbehalfbyname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Modifiedonbehalfbyyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.RecordCreatedOn, fake => fake.Date.Soon())
			.RuleFor(e => e.Owneridname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Owneridtype, fake => fake.Lorem.Word())
			.RuleFor(e => e.Owneridyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.PwActionname, fake => fake.Lorem.Word())
			.RuleFor(e => e.EmailOnError, fake => fake.Random.Bool())
			.RuleFor(e => e.EndDateTime, fake => fake.Date.Soon())
			.RuleFor(e => e.ErrorEmailAddress, fake => fake.Lorem.Word())
			.RuleFor(e => e.ErrorThreshold, fake => fake.Random.Int())
			.RuleFor(e => e.FetchXML, fake => fake.Lorem.Word())
			.RuleFor(e => e.Frequency, fake => fake.PickRandom<PentaSchedule.egFrequency>())
			.RuleFor(e => e.FrequencyValue, fake => fake.Random.Int())
			.RuleFor(e => e.PwGlobalActionname, fake => fake.Lorem.Word())
			.RuleFor(e => e.LastRunDateTime, fake => fake.Date.Soon())
			.RuleFor(e => e.Name, fake => fake.Lorem.Word())
			.RuleFor(e => e.PwNextRunname, fake => fake.Lorem.Word())
			.RuleFor(e => e.PageSize, fake => fake.Random.Int())
			.RuleFor(e => e.RetryImmediately, fake => fake.Random.Bool())
			.RuleFor(e => e.RetryOnError, fake => fake.Random.Bool())
			.RuleFor(e => e.ScheduleType, fake => fake.PickRandom<PentaSchedule.egScheduleType>())
			.RuleFor(e => e.Id, fake => Guid.NewGuid())
			.RuleFor(e => e.SchedulePluginConfig, fake => fake.Lorem.Word())
			.RuleFor(e => e.PwServicePluginname, fake => fake.Lorem.Word())
			.RuleFor(e => e.StartDateTime, fake => fake.Date.Soon())
			.RuleFor(e => e.SuccessiveErrors, fake => fake.Random.Int())
			.RuleFor(e => e.PwWorkflowname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Status, fake => fake.PickRandom<PentaSchedule.eStatus>())
			.RuleFor(e => e.StatusReason, fake => fake.PickRandom<PentaSchedule.eStatusReason>())
			.RuleFor(e => e.TimeZoneRuleVersionNumber, fake => fake.Random.Int())
			.RuleFor(e => e.UTCConversionTimeZoneCode, fake => fake.Random.Int())
			.RuleFor(e => e.VersionNumber, fake => fake.Random.Int());
			return faker.Generate();
		}
		#endregion
	}
}

