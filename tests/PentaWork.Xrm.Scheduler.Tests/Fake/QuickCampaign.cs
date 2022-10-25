using Bogus;
using System;
using FakeXrmEasy;
using System.Collections.Generic;
using PentaWork.Xrm.Scheduler.Proxies.Entities;

namespace PentaWork.Xrm.Scheduler.Tests.Fake
{
	public static class FakeQuickCampaign
	{	
		#region FakeRelationships
		public static class Relationships 
		{
			/// <summary>1:N bulkoperation_activity_parties</summary>
			public static readonly XrmFakedRelationship BulkoperationActivityParties = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "activityid",
					Entity2Attribute = "partyid",
					Entity1LogicalName = "bulkoperation",
					Entity2LogicalName = "activityparty",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N BulkOperation_ActivityPointers</summary>
			public static readonly XrmFakedRelationship BulkOperationActivityPointers = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "activityid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "bulkoperation",
					Entity2LogicalName = "activitypointer",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N bulkoperation_Annotations</summary>
			public static readonly XrmFakedRelationship BulkoperationAnnotations = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "activityid",
					Entity2Attribute = "objectid",
					Entity1LogicalName = "bulkoperation",
					Entity2LogicalName = "annotation",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N BulkOperation_Appointment</summary>
			public static readonly XrmFakedRelationship BulkOperationAppointment = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "activityid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "bulkoperation",
					Entity2LogicalName = "appointment",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N BulkOperation_AsyncOperations</summary>
			public static readonly XrmFakedRelationship BulkOperationAsyncOperations = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "activityid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "bulkoperation",
					Entity2LogicalName = "asyncoperation",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N BulkOperation_BulkDeleteFailures</summary>
			public static readonly XrmFakedRelationship BulkOperationBulkDeleteFailures = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "activityid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "bulkoperation",
					Entity2LogicalName = "bulkdeletefailure",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N BulkOperation_CampaignResponse</summary>
			public static readonly XrmFakedRelationship BulkOperationCampaignResponse = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "activityid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "bulkoperation",
					Entity2LogicalName = "campaignresponse",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N BulkOperation_Email</summary>
			public static readonly XrmFakedRelationship BulkOperationEmail = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "activityid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "bulkoperation",
					Entity2LogicalName = "email",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N BulkOperation_Faxes</summary>
			public static readonly XrmFakedRelationship BulkOperationFaxes = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "activityid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "bulkoperation",
					Entity2LogicalName = "fax",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N bulkoperation_IncidentResolutions</summary>
			public static readonly XrmFakedRelationship BulkoperationIncidentResolutions = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "activityid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "bulkoperation",
					Entity2LogicalName = "incidentresolution",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N BulkOperation_Letter</summary>
			public static readonly XrmFakedRelationship BulkOperationLetter = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "activityid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "bulkoperation",
					Entity2LogicalName = "letter",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N BulkOperation_MailboxTrackingFolder</summary>
			public static readonly XrmFakedRelationship BulkOperationMailboxTrackingFolder = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "activityid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "bulkoperation",
					Entity2LogicalName = "mailboxtrackingfolder",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N bulkoperation_OpportunityCloses</summary>
			public static readonly XrmFakedRelationship BulkoperationOpportunityCloses = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "activityid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "bulkoperation",
					Entity2LogicalName = "opportunityclose",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N bulkoperation_OrderCloses</summary>
			public static readonly XrmFakedRelationship BulkoperationOrderCloses = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "activityid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "bulkoperation",
					Entity2LogicalName = "orderclose",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N BulkOperation_Phonecall</summary>
			public static readonly XrmFakedRelationship BulkOperationPhonecall = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "activityid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "bulkoperation",
					Entity2LogicalName = "phonecall",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N bulkoperation_PrincipalObjectAttributeAccesses</summary>
			public static readonly XrmFakedRelationship BulkoperationPrincipalObjectAttributeAccesses = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "activityid",
					Entity2Attribute = "objectid",
					Entity1LogicalName = "bulkoperation",
					Entity2LogicalName = "principalobjectattributeaccess",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N BulkOperation_QueueItem</summary>
			public static readonly XrmFakedRelationship BulkOperationQueueItem = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "activityid",
					Entity2Attribute = "objectid",
					Entity1LogicalName = "bulkoperation",
					Entity2LogicalName = "queueitem",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N bulkoperation_QuoteCloses</summary>
			public static readonly XrmFakedRelationship BulkoperationQuoteCloses = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "activityid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "bulkoperation",
					Entity2LogicalName = "quoteclose",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N BulkOperation_RecurringAppointmentMaster</summary>
			public static readonly XrmFakedRelationship BulkOperationRecurringAppointmentMaster = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "activityid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "bulkoperation",
					Entity2LogicalName = "recurringappointmentmaster",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N bulkoperation_ServiceAppointments</summary>
			public static readonly XrmFakedRelationship BulkoperationServiceAppointments = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "activityid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "bulkoperation",
					Entity2LogicalName = "serviceappointment",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N BulkOperation_SocialActivity</summary>
			public static readonly XrmFakedRelationship BulkOperationSocialActivity = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "activityid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "bulkoperation",
					Entity2LogicalName = "socialactivity",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N BulkOperation_SyncErrors</summary>
			public static readonly XrmFakedRelationship BulkOperationSyncErrors = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "activityid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "bulkoperation",
					Entity2LogicalName = "syncerror",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N bulkoperation_Tasks</summary>
			public static readonly XrmFakedRelationship BulkoperationTasks = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "activityid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "bulkoperation",
					Entity2LogicalName = "task",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>N:N BulkOperation_Accounts</summary>
			public static readonly XrmFakedRelationship BulkOperationAccounts = 
				new XrmFakedRelationship
				{
					IntersectEntity = "BulkOperation_Accounts",
					Entity1Attribute = "bulkoperationid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "bulkoperation",
					Entity2LogicalName = "account",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.ManyToMany
				};

			/// <summary>N:N BulkOperation_Contacts</summary>
			public static readonly XrmFakedRelationship BulkOperationContacts = 
				new XrmFakedRelationship
				{
					IntersectEntity = "BulkOperation_Contacts",
					Entity1Attribute = "bulkoperationid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "bulkoperation",
					Entity2LogicalName = "contact",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.ManyToMany
				};

			/// <summary>N:N BulkOperation_Leads</summary>
			public static readonly XrmFakedRelationship BulkOperationLeads = 
				new XrmFakedRelationship
				{
					IntersectEntity = "BulkOperation_Leads",
					Entity1Attribute = "bulkoperationid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "bulkoperation",
					Entity2LogicalName = "lead",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.ManyToMany
				};

		}
		#endregion

		#region Fake
		public static QuickCampaign Create()
		{
			var faker = new Faker<QuickCampaign>()
			.RuleFor(e => e.ActivityAdditionalParameters, fake => fake.Lorem.Word())
			.RuleFor(e => e.Id, fake => Guid.NewGuid())
			.RuleFor(e => e.ActivityType, fake => fake.Lorem.Word())
			.RuleFor(e => e.ActualDuration, fake => fake.Random.Int())
			.RuleFor(e => e.ActualEnd, fake => fake.Date.Soon())
			.RuleFor(e => e.ActualStart, fake => fake.Date.Soon())
			.RuleFor(e => e.BulkOperationNumber, fake => fake.Lorem.Word())
			.RuleFor(e => e.SocialChannel, fake => fake.PickRandom<QuickCampaign.egSocialChannel>())
			.RuleFor(e => e.Createdbyname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Createdbyyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.CreatedOn, fake => fake.Date.Soon())
			.RuleFor(e => e.Createdonbehalfbyname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Createdonbehalfbyyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.ActivityType2, fake => fake.PickRandom<QuickCampaign.eActivityType>())
			.RuleFor(e => e.DateDeliveryLastAttempted, fake => fake.Date.Soon())
			.RuleFor(e => e.DeliveryPriority, fake => fake.PickRandom<QuickCampaign.egDeliveryPriority>())
			.RuleFor(e => e.Description, fake => fake.Lorem.Word())
			.RuleFor(e => e.ErrorNumber, fake => fake.Random.Int())
			.RuleFor(e => e.ExchangeItemID, fake => fake.Lorem.Word())
			.RuleFor(e => e.ExchangeRate, fake => fake.Finance.Amount())
			.RuleFor(e => e.ExchangeWebLink, fake => fake.Lorem.Word())
			.RuleFor(e => e.NoOfFailures, fake => fake.Random.Int())
			.RuleFor(e => e.ImportSequenceNumber, fake => fake.Random.Int())
			.RuleFor(e => e.RecurringInstanceType, fake => fake.PickRandom<QuickCampaign.eAppointmentType>())
			.RuleFor(e => e.IsBilled, fake => fake.Random.Bool())
			.RuleFor(e => e.IsPrivate, fake => fake.Random.Bool())
			.RuleFor(e => e.IsRegularActivity, fake => fake.Random.Bool())
			.RuleFor(e => e.IsWorkflowCreated, fake => fake.Random.Bool())
			.RuleFor(e => e.LastOnHoldTime, fake => fake.Date.Soon())
			.RuleFor(e => e.LeftVoiceMail, fake => fake.Random.Bool())
			.RuleFor(e => e.Modifiedbyname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Modifiedbyyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.ModifiedOn, fake => fake.Date.Soon())
			.RuleFor(e => e.Modifiedonbehalfbyname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Modifiedonbehalfbyyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.OnHoldTimeMinutes, fake => fake.Random.Int())
			.RuleFor(e => e.Operation, fake => fake.PickRandom<QuickCampaign.eOperation>())
			.RuleFor(e => e.RecordCreatedOn, fake => fake.Date.Soon())
			.RuleFor(e => e.Owneridname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Owneridtype, fake => fake.Lorem.Word())
			.RuleFor(e => e.Owneridyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.Parameters, fake => fake.Lorem.Word())
			.RuleFor(e => e.DelayActivityProcessingUntil, fake => fake.Date.Soon())
			.RuleFor(e => e.Priority, fake => fake.PickRandom<QuickCampaign.ePriority>())
			.RuleFor(e => e.ProcessId, fake => Guid.NewGuid())
			.RuleFor(e => e.Regardingobjectidname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Regardingobjectidyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.Regardingobjecttypecode, fake => fake.Lorem.Word())
			.RuleFor(e => e.ScheduledDuration, fake => fake.Random.Int())
			.RuleFor(e => e.DueDate, fake => fake.Date.Soon())
			.RuleFor(e => e.StartDate, fake => fake.Date.Soon())
			.RuleFor(e => e.Sendermailboxidname, fake => fake.Lorem.Word())
			.RuleFor(e => e.DateSent, fake => fake.Date.Soon())
			.RuleFor(e => e.SeriesId, fake => Guid.NewGuid())
			.RuleFor(e => e.Slainvokedidname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Slaname, fake => fake.Lorem.Word())
			.RuleFor(e => e.SortDate, fake => fake.Date.Soon())
			.RuleFor(e => e.DeprecatedProcessStageId, fake => Guid.NewGuid())
			.RuleFor(e => e.Status, fake => fake.PickRandom<QuickCampaign.eActivityStatus>())
			.RuleFor(e => e.StatusReason, fake => fake.PickRandom<QuickCampaign.eStatusReason>())
			.RuleFor(e => e.Subject, fake => fake.Lorem.Word())
			.RuleFor(e => e.NoOfSuccesses, fake => fake.Random.Int())
			.RuleFor(e => e.MembersType, fake => fake.PickRandom<QuickCampaign.eMembersType>())
			.RuleFor(e => e.TotalMembers, fake => fake.Random.Int())
			.RuleFor(e => e.TimeZoneRuleVersionNumber, fake => fake.Random.Int())
			.RuleFor(e => e.Transactioncurrencyidname, fake => fake.Lorem.Word())
			.RuleFor(e => e.DeprecatedTraversedPath, fake => fake.Lorem.Word())
			.RuleFor(e => e.UTCConversionTimeZoneCode, fake => fake.Random.Int())
			.RuleFor(e => e.VersionNumber, fake => fake.Random.Int())
			.RuleFor(e => e.WorkflowInformation, fake => fake.Lorem.Word());
			return faker.Generate();
		}
		#endregion
	}
}

