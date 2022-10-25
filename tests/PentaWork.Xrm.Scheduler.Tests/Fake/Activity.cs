using Bogus;
using System;
using FakeXrmEasy;
using System.Collections.Generic;
using PentaWork.Xrm.Scheduler.Proxies.Entities;

namespace PentaWork.Xrm.Scheduler.Tests.Fake
{
	public static class FakeActivity
	{	
		#region FakeRelationships
		public static class Relationships 
		{
			/// <summary>1:N activity_campaignresponse</summary>
			public static readonly XrmFakedRelationship ActivityCampaignresponse = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "activityid",
					Entity2Attribute = "originatingactivityid",
					Entity1LogicalName = "activitypointer",
					Entity2LogicalName = "campaignresponse",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N activity_pointer_activity_mime_attachment</summary>
			public static readonly XrmFakedRelationship ActivityPointerActivityMimeAttachment = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "activityid",
					Entity2Attribute = "objectid",
					Entity1LogicalName = "activitypointer",
					Entity2LogicalName = "activitymimeattachment",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N activity_pointer_appointment</summary>
			public static readonly XrmFakedRelationship ActivityPointerAppointment = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "activityid",
					Entity2Attribute = "activityid",
					Entity1LogicalName = "activitypointer",
					Entity2LogicalName = "appointment",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N activity_pointer_BulkOperation</summary>
			public static readonly XrmFakedRelationship ActivityPointerBulkOperation = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "activityid",
					Entity2Attribute = "activityid",
					Entity1LogicalName = "activitypointer",
					Entity2LogicalName = "bulkoperation",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N activity_pointer_campaignactivity</summary>
			public static readonly XrmFakedRelationship ActivityPointerCampaignactivity = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "activityid",
					Entity2Attribute = "activityid",
					Entity1LogicalName = "activitypointer",
					Entity2LogicalName = "campaignactivity",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N activity_pointer_campaignresponse</summary>
			public static readonly XrmFakedRelationship ActivityPointerCampaignresponse = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "activityid",
					Entity2Attribute = "activityid",
					Entity1LogicalName = "activitypointer",
					Entity2LogicalName = "campaignresponse",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N activity_pointer_email</summary>
			public static readonly XrmFakedRelationship ActivityPointerEmail = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "activityid",
					Entity2Attribute = "activityid",
					Entity1LogicalName = "activitypointer",
					Entity2LogicalName = "email",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N activity_pointer_fax</summary>
			public static readonly XrmFakedRelationship ActivityPointerFax = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "activityid",
					Entity2Attribute = "activityid",
					Entity1LogicalName = "activitypointer",
					Entity2LogicalName = "fax",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N activity_pointer_incident_resolution</summary>
			public static readonly XrmFakedRelationship ActivityPointerIncidentResolution = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "activityid",
					Entity2Attribute = "activityid",
					Entity1LogicalName = "activitypointer",
					Entity2LogicalName = "incidentresolution",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N activity_pointer_letter</summary>
			public static readonly XrmFakedRelationship ActivityPointerLetter = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "activityid",
					Entity2Attribute = "activityid",
					Entity1LogicalName = "activitypointer",
					Entity2LogicalName = "letter",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N activity_pointer_opportunity_close</summary>
			public static readonly XrmFakedRelationship ActivityPointerOpportunityClose = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "activityid",
					Entity2Attribute = "activityid",
					Entity1LogicalName = "activitypointer",
					Entity2LogicalName = "opportunityclose",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N activity_pointer_order_close</summary>
			public static readonly XrmFakedRelationship ActivityPointerOrderClose = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "activityid",
					Entity2Attribute = "activityid",
					Entity1LogicalName = "activitypointer",
					Entity2LogicalName = "orderclose",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N activity_pointer_phonecall</summary>
			public static readonly XrmFakedRelationship ActivityPointerPhonecall = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "activityid",
					Entity2Attribute = "activityid",
					Entity1LogicalName = "activitypointer",
					Entity2LogicalName = "phonecall",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N activity_pointer_quote_close</summary>
			public static readonly XrmFakedRelationship ActivityPointerQuoteClose = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "activityid",
					Entity2Attribute = "activityid",
					Entity1LogicalName = "activitypointer",
					Entity2LogicalName = "quoteclose",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N activity_pointer_recurrencerule</summary>
			public static readonly XrmFakedRelationship ActivityPointerRecurrencerule = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "activityid",
					Entity2Attribute = "objectid",
					Entity1LogicalName = "activitypointer",
					Entity2LogicalName = "recurrencerule",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N activity_pointer_recurringappointmentmaster</summary>
			public static readonly XrmFakedRelationship ActivityPointerRecurringappointmentmaster = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "activityid",
					Entity2Attribute = "activityid",
					Entity1LogicalName = "activitypointer",
					Entity2LogicalName = "recurringappointmentmaster",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N activity_pointer_service_appointment</summary>
			public static readonly XrmFakedRelationship ActivityPointerServiceAppointment = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "activityid",
					Entity2Attribute = "activityid",
					Entity1LogicalName = "activitypointer",
					Entity2LogicalName = "serviceappointment",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N activity_pointer_socialactivity</summary>
			public static readonly XrmFakedRelationship ActivityPointerSocialactivity = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "activityid",
					Entity2Attribute = "activityid",
					Entity1LogicalName = "activitypointer",
					Entity2LogicalName = "socialactivity",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N activity_pointer_task</summary>
			public static readonly XrmFakedRelationship ActivityPointerTask = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "activityid",
					Entity2Attribute = "activityid",
					Entity1LogicalName = "activitypointer",
					Entity2LogicalName = "task",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N activitypointer_activity_parties</summary>
			public static readonly XrmFakedRelationship ActivitypointerActivityParties = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "activityid",
					Entity2Attribute = "activityid",
					Entity1LogicalName = "activitypointer",
					Entity2LogicalName = "activityparty",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N ActivityPointer_AsyncOperations</summary>
			public static readonly XrmFakedRelationship ActivityPointerAsyncOperations = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "activityid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "activitypointer",
					Entity2LogicalName = "asyncoperation",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N ActivityPointer_BulkDeleteFailures</summary>
			public static readonly XrmFakedRelationship ActivityPointerBulkDeleteFailures = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "activityid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "activitypointer",
					Entity2LogicalName = "bulkdeletefailure",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N activitypointer_connections1</summary>
			public static readonly XrmFakedRelationship ActivitypointerConnections1 = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "activityid",
					Entity2Attribute = "record1id",
					Entity1LogicalName = "activitypointer",
					Entity2LogicalName = "connection",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N activitypointer_connections2</summary>
			public static readonly XrmFakedRelationship ActivitypointerConnections2 = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "activityid",
					Entity2Attribute = "record2id",
					Entity1LogicalName = "activitypointer",
					Entity2LogicalName = "connection",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N ActivityPointer_QueueItem</summary>
			public static readonly XrmFakedRelationship ActivityPointerQueueItem = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "activityid",
					Entity2Attribute = "objectid",
					Entity1LogicalName = "activitypointer",
					Entity2LogicalName = "queueitem",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N slakpiinstance_activitypointer</summary>
			public static readonly XrmFakedRelationship SlakpiinstanceActivitypointer = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "activityid",
					Entity2Attribute = "regarding",
					Entity1LogicalName = "activitypointer",
					Entity2LogicalName = "slakpiinstance",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

		}
		#endregion

		#region Fake
		public static Activity Create()
		{
			var faker = new Faker<Activity>()
			.RuleFor(e => e.ActivityAdditionalParameters, fake => fake.Lorem.Word())
			.RuleFor(e => e.Id, fake => Guid.NewGuid())
			.RuleFor(e => e.ActivityType, fake => fake.Lorem.Word())
			.RuleFor(e => e.ActualDuration, fake => fake.Random.Int())
			.RuleFor(e => e.ActualEnd, fake => fake.Date.Soon())
			.RuleFor(e => e.ActualStart, fake => fake.Date.Soon())
			.RuleFor(e => e.SocialChannel, fake => fake.PickRandom<Activity.egSocialChannel>())
			.RuleFor(e => e.Createdbyname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Createdbyyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.DateCreated, fake => fake.Date.Soon())
			.RuleFor(e => e.Createdonbehalfbyname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Createdonbehalfbyyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.DateDeliveryLastAttempted, fake => fake.Date.Soon())
			.RuleFor(e => e.DeliveryPriority, fake => fake.PickRandom<Activity.egDeliveryPriority>())
			.RuleFor(e => e.Description, fake => fake.Lorem.Word())
			.RuleFor(e => e.ExchangeItemID, fake => fake.Lorem.Word())
			.RuleFor(e => e.ExchangeRate, fake => fake.Finance.Amount())
			.RuleFor(e => e.ExchangeWebLink, fake => fake.Lorem.Word())
			.RuleFor(e => e.RecurringInstanceType, fake => fake.PickRandom<Activity.eAppointmentType>())
			.RuleFor(e => e.IsBilled, fake => fake.Random.Bool())
			.RuleFor(e => e.IsPrivate, fake => fake.Random.Bool())
			.RuleFor(e => e.IsRegularActivity, fake => fake.Random.Bool())
			.RuleFor(e => e.IsWorkflowCreated, fake => fake.Random.Bool())
			.RuleFor(e => e.LastOnHoldTime, fake => fake.Date.Soon())
			.RuleFor(e => e.LeftVoiceMail, fake => fake.Random.Bool())
			.RuleFor(e => e.Modifiedbyname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Modifiedbyyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.LastUpdated, fake => fake.Date.Soon())
			.RuleFor(e => e.Modifiedonbehalfbyname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Modifiedonbehalfbyyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.OnHoldTimeMinutes, fake => fake.Random.Int())
			.RuleFor(e => e.Owneridname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Owneridtype, fake => fake.Lorem.Word())
			.RuleFor(e => e.Owneridyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.DelayActivityProcessingUntil, fake => fake.Date.Soon())
			.RuleFor(e => e.Priority, fake => fake.PickRandom<Activity.ePriority>())
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
			.RuleFor(e => e.Serviceidname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Slainvokedidname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Slaname, fake => fake.Lorem.Word())
			.RuleFor(e => e.SortDate, fake => fake.Date.Soon())
			.RuleFor(e => e.DeprecatedProcessStageId, fake => Guid.NewGuid())
			.RuleFor(e => e.ActivityStatus, fake => fake.PickRandom<Activity.eActivityStatus>())
			.RuleFor(e => e.StatusReason, fake => fake.PickRandom<Activity.eStatusReason>())
			.RuleFor(e => e.Subject, fake => fake.Lorem.Word())
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

