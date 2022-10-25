using Bogus;
using System;
using FakeXrmEasy;
using System.Collections.Generic;
using PentaWork.Xrm.Scheduler.Proxies.Entities;

namespace PentaWork.Xrm.Scheduler.Tests.Fake
{
	public static class FakeBookableResourceBooking
	{	
		#region FakeRelationships
		public static class Relationships 
		{
			/// <summary>1:N bookableresourcebooking_ActivityPointers</summary>
			public static readonly XrmFakedRelationship BookableresourcebookingActivityPointers = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "bookableresourcebookingid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "bookableresourcebooking",
					Entity2LogicalName = "activitypointer",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N bookableresourcebooking_Annotations</summary>
			public static readonly XrmFakedRelationship BookableresourcebookingAnnotations = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "bookableresourcebookingid",
					Entity2Attribute = "objectid",
					Entity1LogicalName = "bookableresourcebooking",
					Entity2LogicalName = "annotation",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N bookableresourcebooking_Appointments</summary>
			public static readonly XrmFakedRelationship BookableresourcebookingAppointments = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "bookableresourcebookingid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "bookableresourcebooking",
					Entity2LogicalName = "appointment",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N bookableresourcebooking_AsyncOperations</summary>
			public static readonly XrmFakedRelationship BookableresourcebookingAsyncOperations = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "bookableresourcebookingid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "bookableresourcebooking",
					Entity2LogicalName = "asyncoperation",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N bookableresourcebooking_BulkDeleteFailures</summary>
			public static readonly XrmFakedRelationship BookableresourcebookingBulkDeleteFailures = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "bookableresourcebookingid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "bookableresourcebooking",
					Entity2LogicalName = "bulkdeletefailure",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N bookableresourcebooking_BulkOperations</summary>
			public static readonly XrmFakedRelationship BookableresourcebookingBulkOperations = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "bookableresourcebookingid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "bookableresourcebooking",
					Entity2LogicalName = "bulkoperation",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N bookableresourcebooking_CampaignActivities</summary>
			public static readonly XrmFakedRelationship BookableresourcebookingCampaignActivities = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "bookableresourcebookingid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "bookableresourcebooking",
					Entity2LogicalName = "campaignactivity",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N bookableresourcebooking_CampaignResponses</summary>
			public static readonly XrmFakedRelationship BookableresourcebookingCampaignResponses = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "bookableresourcebookingid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "bookableresourcebooking",
					Entity2LogicalName = "campaignresponse",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N bookableresourcebooking_DuplicateBaseRecord</summary>
			public static readonly XrmFakedRelationship BookableresourcebookingDuplicateBaseRecord = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "bookableresourcebookingid",
					Entity2Attribute = "baserecordid",
					Entity1LogicalName = "bookableresourcebooking",
					Entity2LogicalName = "duplicaterecord",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N bookableresourcebooking_DuplicateMatchingRecord</summary>
			public static readonly XrmFakedRelationship BookableresourcebookingDuplicateMatchingRecord = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "bookableresourcebookingid",
					Entity2Attribute = "duplicaterecordid",
					Entity1LogicalName = "bookableresourcebooking",
					Entity2LogicalName = "duplicaterecord",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N bookableresourcebooking_Emails</summary>
			public static readonly XrmFakedRelationship BookableresourcebookingEmails = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "bookableresourcebookingid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "bookableresourcebooking",
					Entity2LogicalName = "email",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N bookableresourcebooking_Faxes</summary>
			public static readonly XrmFakedRelationship BookableresourcebookingFaxes = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "bookableresourcebookingid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "bookableresourcebooking",
					Entity2LogicalName = "fax",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N bookableresourcebooking_IncidentResolutions</summary>
			public static readonly XrmFakedRelationship BookableresourcebookingIncidentResolutions = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "bookableresourcebookingid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "bookableresourcebooking",
					Entity2LogicalName = "incidentresolution",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N bookableresourcebooking_Letters</summary>
			public static readonly XrmFakedRelationship BookableresourcebookingLetters = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "bookableresourcebookingid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "bookableresourcebooking",
					Entity2LogicalName = "letter",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N bookableresourcebooking_MailboxTrackingFolders</summary>
			public static readonly XrmFakedRelationship BookableresourcebookingMailboxTrackingFolders = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "bookableresourcebookingid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "bookableresourcebooking",
					Entity2LogicalName = "mailboxtrackingfolder",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N bookableresourcebooking_OpportunityCloses</summary>
			public static readonly XrmFakedRelationship BookableresourcebookingOpportunityCloses = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "bookableresourcebookingid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "bookableresourcebooking",
					Entity2LogicalName = "opportunityclose",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N bookableresourcebooking_OrderCloses</summary>
			public static readonly XrmFakedRelationship BookableresourcebookingOrderCloses = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "bookableresourcebookingid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "bookableresourcebooking",
					Entity2LogicalName = "orderclose",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N bookableresourcebooking_PhoneCalls</summary>
			public static readonly XrmFakedRelationship BookableresourcebookingPhoneCalls = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "bookableresourcebookingid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "bookableresourcebooking",
					Entity2LogicalName = "phonecall",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N bookableresourcebooking_PrincipalObjectAttributeAccess</summary>
			public static readonly XrmFakedRelationship BookableresourcebookingPrincipalObjectAttributeAccess = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "bookableresourcebookingid",
					Entity2Attribute = "objectid",
					Entity1LogicalName = "bookableresourcebooking",
					Entity2LogicalName = "principalobjectattributeaccess",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N bookableresourcebooking_ProcessSession</summary>
			public static readonly XrmFakedRelationship BookableresourcebookingProcessSession = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "bookableresourcebookingid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "bookableresourcebooking",
					Entity2LogicalName = "processsession",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N bookableresourcebooking_QuoteCloses</summary>
			public static readonly XrmFakedRelationship BookableresourcebookingQuoteCloses = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "bookableresourcebookingid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "bookableresourcebooking",
					Entity2LogicalName = "quoteclose",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N bookableresourcebooking_RecurringAppointmentMasters</summary>
			public static readonly XrmFakedRelationship BookableresourcebookingRecurringAppointmentMasters = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "bookableresourcebookingid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "bookableresourcebooking",
					Entity2LogicalName = "recurringappointmentmaster",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N bookableresourcebooking_ServiceAppointments</summary>
			public static readonly XrmFakedRelationship BookableresourcebookingServiceAppointments = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "bookableresourcebookingid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "bookableresourcebooking",
					Entity2LogicalName = "serviceappointment",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N bookableresourcebooking_SocialActivities</summary>
			public static readonly XrmFakedRelationship BookableresourcebookingSocialActivities = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "bookableresourcebookingid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "bookableresourcebooking",
					Entity2LogicalName = "socialactivity",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N BookableResourceBooking_SyncErrors</summary>
			public static readonly XrmFakedRelationship BookableResourceBookingSyncErrors = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "bookableresourcebookingid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "bookableresourcebooking",
					Entity2LogicalName = "syncerror",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N bookableresourcebooking_Tasks</summary>
			public static readonly XrmFakedRelationship BookableresourcebookingTasks = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "bookableresourcebookingid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "bookableresourcebooking",
					Entity2LogicalName = "task",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

		}
		#endregion

		#region Fake
		public static BookableResourceBooking Create()
		{
			var faker = new Faker<BookableResourceBooking>()
			.RuleFor(e => e.Id, fake => Guid.NewGuid())
			.RuleFor(e => e.Bookingstatusname, fake => fake.Lorem.Word())
			.RuleFor(e => e.BookingType, fake => fake.PickRandom<BookableResourceBooking.eBookingType>())
			.RuleFor(e => e.Createdbyname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Createdbyyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.CreatedOn, fake => fake.Date.Soon())
			.RuleFor(e => e.Createdonbehalfbyname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Createdonbehalfbyyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.Duration, fake => fake.Random.Int())
			.RuleFor(e => e.EndTime, fake => fake.Date.Soon())
			.RuleFor(e => e.ExchangeRate, fake => fake.Finance.Amount())
			.RuleFor(e => e.Headername, fake => fake.Lorem.Word())
			.RuleFor(e => e.ImportSequenceNumber, fake => fake.Random.Int())
			.RuleFor(e => e.Modifiedbyname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Modifiedbyyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.ModifiedOn, fake => fake.Date.Soon())
			.RuleFor(e => e.Modifiedonbehalfbyname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Modifiedonbehalfbyyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.Name, fake => fake.Lorem.Word())
			.RuleFor(e => e.RecordCreatedOn, fake => fake.Date.Soon())
			.RuleFor(e => e.Owneridname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Owneridtype, fake => fake.Lorem.Word())
			.RuleFor(e => e.Owneridyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.ProcessId, fake => Guid.NewGuid())
			.RuleFor(e => e.Resourcename, fake => fake.Lorem.Word())
			.RuleFor(e => e.DeprecatedStageId, fake => Guid.NewGuid())
			.RuleFor(e => e.StartTime, fake => fake.Date.Soon())
			.RuleFor(e => e.Status, fake => fake.PickRandom<BookableResourceBooking.eStatus>())
			.RuleFor(e => e.StatusReason, fake => fake.PickRandom<BookableResourceBooking.eStatusReason>())
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

