using Bogus;
using System;
using FakeXrmEasy;
using System.Collections.Generic;
using PentaWork.Xrm.Scheduler.Proxies.Entities;

namespace PentaWork.Xrm.Scheduler.Tests.Fake
{
	public static class FakePlaybook
	{	
		#region FakeRelationships
		public static class Relationships 
		{
			/// <summary>1:N msdyn_playbookinstance_ActivityPointers</summary>
			public static readonly XrmFakedRelationship MsdynPlaybookinstanceActivityPointers = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "msdyn_playbookinstanceid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "msdyn_playbookinstance",
					Entity2LogicalName = "activitypointer",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N msdyn_playbookinstance_Annotations</summary>
			public static readonly XrmFakedRelationship MsdynPlaybookinstanceAnnotations = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "msdyn_playbookinstanceid",
					Entity2Attribute = "objectid",
					Entity1LogicalName = "msdyn_playbookinstance",
					Entity2LogicalName = "annotation",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N msdyn_playbookinstance_Appointments</summary>
			public static readonly XrmFakedRelationship MsdynPlaybookinstanceAppointments = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "msdyn_playbookinstanceid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "msdyn_playbookinstance",
					Entity2LogicalName = "appointment",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N msdyn_playbookinstance_AsyncOperations</summary>
			public static readonly XrmFakedRelationship MsdynPlaybookinstanceAsyncOperations = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "msdyn_playbookinstanceid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "msdyn_playbookinstance",
					Entity2LogicalName = "asyncoperation",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N msdyn_playbookinstance_BulkDeleteFailures</summary>
			public static readonly XrmFakedRelationship MsdynPlaybookinstanceBulkDeleteFailures = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "msdyn_playbookinstanceid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "msdyn_playbookinstance",
					Entity2LogicalName = "bulkdeletefailure",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N msdyn_playbookinstance_DuplicateBaseRecord</summary>
			public static readonly XrmFakedRelationship MsdynPlaybookinstanceDuplicateBaseRecord = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "msdyn_playbookinstanceid",
					Entity2Attribute = "baserecordid",
					Entity1LogicalName = "msdyn_playbookinstance",
					Entity2LogicalName = "duplicaterecord",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N msdyn_playbookinstance_DuplicateMatchingRecord</summary>
			public static readonly XrmFakedRelationship MsdynPlaybookinstanceDuplicateMatchingRecord = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "msdyn_playbookinstanceid",
					Entity2Attribute = "duplicaterecordid",
					Entity1LogicalName = "msdyn_playbookinstance",
					Entity2LogicalName = "duplicaterecord",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N msdyn_playbookinstance_Emails</summary>
			public static readonly XrmFakedRelationship MsdynPlaybookinstanceEmails = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "msdyn_playbookinstanceid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "msdyn_playbookinstance",
					Entity2LogicalName = "email",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N msdyn_playbookinstance_Faxes</summary>
			public static readonly XrmFakedRelationship MsdynPlaybookinstanceFaxes = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "msdyn_playbookinstanceid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "msdyn_playbookinstance",
					Entity2LogicalName = "fax",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N msdyn_playbookinstance_Letters</summary>
			public static readonly XrmFakedRelationship MsdynPlaybookinstanceLetters = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "msdyn_playbookinstanceid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "msdyn_playbookinstance",
					Entity2LogicalName = "letter",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N msdyn_playbookinstance_MailboxTrackingFolders</summary>
			public static readonly XrmFakedRelationship MsdynPlaybookinstanceMailboxTrackingFolders = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "msdyn_playbookinstanceid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "msdyn_playbookinstance",
					Entity2LogicalName = "mailboxtrackingfolder",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N msdyn_playbookinstance_OpportunityCloses</summary>
			public static readonly XrmFakedRelationship MsdynPlaybookinstanceOpportunityCloses = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "msdyn_playbookinstanceid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "msdyn_playbookinstance",
					Entity2LogicalName = "opportunityclose",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N msdyn_playbookinstance_OrderCloses</summary>
			public static readonly XrmFakedRelationship MsdynPlaybookinstanceOrderCloses = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "msdyn_playbookinstanceid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "msdyn_playbookinstance",
					Entity2LogicalName = "orderclose",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N msdyn_playbookinstance_PhoneCalls</summary>
			public static readonly XrmFakedRelationship MsdynPlaybookinstancePhoneCalls = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "msdyn_playbookinstanceid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "msdyn_playbookinstance",
					Entity2LogicalName = "phonecall",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N msdyn_playbookinstance_PrincipalObjectAttributeAccesses</summary>
			public static readonly XrmFakedRelationship MsdynPlaybookinstancePrincipalObjectAttributeAccesses = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "msdyn_playbookinstanceid",
					Entity2Attribute = "objectid",
					Entity1LogicalName = "msdyn_playbookinstance",
					Entity2LogicalName = "principalobjectattributeaccess",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N msdyn_playbookinstance_ProcessSession</summary>
			public static readonly XrmFakedRelationship MsdynPlaybookinstanceProcessSession = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "msdyn_playbookinstanceid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "msdyn_playbookinstance",
					Entity2LogicalName = "processsession",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N msdyn_playbookinstance_QuoteCloses</summary>
			public static readonly XrmFakedRelationship MsdynPlaybookinstanceQuoteCloses = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "msdyn_playbookinstanceid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "msdyn_playbookinstance",
					Entity2LogicalName = "quoteclose",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N msdyn_playbookinstance_RecurringAppointmentMasters</summary>
			public static readonly XrmFakedRelationship MsdynPlaybookinstanceRecurringAppointmentMasters = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "msdyn_playbookinstanceid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "msdyn_playbookinstance",
					Entity2LogicalName = "recurringappointmentmaster",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N msdyn_playbookinstance_ServiceAppointments</summary>
			public static readonly XrmFakedRelationship MsdynPlaybookinstanceServiceAppointments = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "msdyn_playbookinstanceid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "msdyn_playbookinstance",
					Entity2LogicalName = "serviceappointment",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N msdyn_playbookinstance_SocialActivities</summary>
			public static readonly XrmFakedRelationship MsdynPlaybookinstanceSocialActivities = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "msdyn_playbookinstanceid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "msdyn_playbookinstance",
					Entity2LogicalName = "socialactivity",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N msdyn_playbookinstance_SyncErrors</summary>
			public static readonly XrmFakedRelationship MsdynPlaybookinstanceSyncErrors = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "msdyn_playbookinstanceid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "msdyn_playbookinstance",
					Entity2LogicalName = "syncerror",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N msdyn_playbookinstance_Tasks</summary>
			public static readonly XrmFakedRelationship MsdynPlaybookinstanceTasks = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "msdyn_playbookinstanceid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "msdyn_playbookinstance",
					Entity2LogicalName = "task",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

		}
		#endregion

		#region Fake
		public static Playbook Create()
		{
			var faker = new Faker<Playbook>()
			.RuleFor(e => e.Createdbyname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Createdbyyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.StartedOn, fake => fake.Date.Soon())
			.RuleFor(e => e.Createdonbehalfbyname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Createdonbehalfbyyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.ImportSequenceNumber, fake => fake.Random.Int())
			.RuleFor(e => e.Modifiedbyname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Modifiedbyyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.ModifiedOn, fake => fake.Date.Soon())
			.RuleFor(e => e.Modifiedonbehalfbyname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Modifiedonbehalfbyyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.TotalActivities, fake => fake.Random.Int())
			.RuleFor(e => e.CompletedActivities, fake => fake.Random.Int())
			.RuleFor(e => e.MsdynCategoryidname, fake => fake.Lorem.Word())
			.RuleFor(e => e.EstimatedClose, fake => fake.Date.Soon())
			.RuleFor(e => e.EvaluateActivityClosure, fake => fake.Random.Bool())
			.RuleFor(e => e.Name, fake => fake.Lorem.Word())
			.RuleFor(e => e.Id, fake => Guid.NewGuid())
			.RuleFor(e => e.MsdynPlaybooktemplateidname, fake => fake.Lorem.Word())
			.RuleFor(e => e.TrackProgress, fake => fake.Random.Bool())
			.RuleFor(e => e.RecordCreatedOn, fake => fake.Date.Soon())
			.RuleFor(e => e.Owneridname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Owneridtype, fake => fake.Lorem.Word())
			.RuleFor(e => e.Owneridyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.Regardingidname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Regardingobjecttypecode, fake => fake.Lorem.Word())
			.RuleFor(e => e.Regardingyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.Status, fake => fake.PickRandom<Playbook.eStatus>())
			.RuleFor(e => e.Result, fake => fake.PickRandom<Playbook.eStatusReason>())
			.RuleFor(e => e.TimeZoneRuleVersionNumber, fake => fake.Random.Int())
			.RuleFor(e => e.UTCConversionTimeZoneCode, fake => fake.Random.Int())
			.RuleFor(e => e.VersionNumber, fake => fake.Random.Int());
			return faker.Generate();
		}
		#endregion
	}
}

