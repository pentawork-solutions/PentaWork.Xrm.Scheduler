using Bogus;
using System;
using FakeXrmEasy;
using System.Collections.Generic;
using PentaWork.Xrm.Scheduler.Proxies.Entities;

namespace PentaWork.Xrm.Scheduler.Tests.Fake
{
	public static class FakeBookableResourceBookingHeader
	{	
		#region FakeRelationships
		public static class Relationships 
		{
			/// <summary>1:N bookableresourcebookingheader_ActivityPointers</summary>
			public static readonly XrmFakedRelationship BookableresourcebookingheaderActivityPointers = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "bookableresourcebookingheaderid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "bookableresourcebookingheader",
					Entity2LogicalName = "activitypointer",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N bookableresourcebookingheader_Annotations</summary>
			public static readonly XrmFakedRelationship BookableresourcebookingheaderAnnotations = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "bookableresourcebookingheaderid",
					Entity2Attribute = "objectid",
					Entity1LogicalName = "bookableresourcebookingheader",
					Entity2LogicalName = "annotation",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N bookableresourcebookingheader_Appointments</summary>
			public static readonly XrmFakedRelationship BookableresourcebookingheaderAppointments = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "bookableresourcebookingheaderid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "bookableresourcebookingheader",
					Entity2LogicalName = "appointment",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N bookableresourcebookingheader_AsyncOperations</summary>
			public static readonly XrmFakedRelationship BookableresourcebookingheaderAsyncOperations = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "bookableresourcebookingheaderid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "bookableresourcebookingheader",
					Entity2LogicalName = "asyncoperation",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N bookableresourcebookingheader_bookableresourcebooking_Header</summary>
			public static readonly XrmFakedRelationship BookableresourcebookingheaderBookableresourcebookingHeader = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "bookableresourcebookingheaderid",
					Entity2Attribute = "header",
					Entity1LogicalName = "bookableresourcebookingheader",
					Entity2LogicalName = "bookableresourcebooking",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N bookableresourcebookingheader_BulkDeleteFailures</summary>
			public static readonly XrmFakedRelationship BookableresourcebookingheaderBulkDeleteFailures = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "bookableresourcebookingheaderid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "bookableresourcebookingheader",
					Entity2LogicalName = "bulkdeletefailure",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N bookableresourcebookingheader_BulkOperations</summary>
			public static readonly XrmFakedRelationship BookableresourcebookingheaderBulkOperations = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "bookableresourcebookingheaderid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "bookableresourcebookingheader",
					Entity2LogicalName = "bulkoperation",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N bookableresourcebookingheader_CampaignActivities</summary>
			public static readonly XrmFakedRelationship BookableresourcebookingheaderCampaignActivities = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "bookableresourcebookingheaderid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "bookableresourcebookingheader",
					Entity2LogicalName = "campaignactivity",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N bookableresourcebookingheader_CampaignResponses</summary>
			public static readonly XrmFakedRelationship BookableresourcebookingheaderCampaignResponses = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "bookableresourcebookingheaderid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "bookableresourcebookingheader",
					Entity2LogicalName = "campaignresponse",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N bookableresourcebookingheader_DuplicateBaseRecord</summary>
			public static readonly XrmFakedRelationship BookableresourcebookingheaderDuplicateBaseRecord = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "bookableresourcebookingheaderid",
					Entity2Attribute = "baserecordid",
					Entity1LogicalName = "bookableresourcebookingheader",
					Entity2LogicalName = "duplicaterecord",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N bookableresourcebookingheader_DuplicateMatchingRecord</summary>
			public static readonly XrmFakedRelationship BookableresourcebookingheaderDuplicateMatchingRecord = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "bookableresourcebookingheaderid",
					Entity2Attribute = "duplicaterecordid",
					Entity1LogicalName = "bookableresourcebookingheader",
					Entity2LogicalName = "duplicaterecord",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N bookableresourcebookingheader_Emails</summary>
			public static readonly XrmFakedRelationship BookableresourcebookingheaderEmails = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "bookableresourcebookingheaderid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "bookableresourcebookingheader",
					Entity2LogicalName = "email",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N bookableresourcebookingheader_Faxes</summary>
			public static readonly XrmFakedRelationship BookableresourcebookingheaderFaxes = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "bookableresourcebookingheaderid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "bookableresourcebookingheader",
					Entity2LogicalName = "fax",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N bookableresourcebookingheader_IncidentResolutions</summary>
			public static readonly XrmFakedRelationship BookableresourcebookingheaderIncidentResolutions = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "bookableresourcebookingheaderid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "bookableresourcebookingheader",
					Entity2LogicalName = "incidentresolution",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N bookableresourcebookingheader_Letters</summary>
			public static readonly XrmFakedRelationship BookableresourcebookingheaderLetters = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "bookableresourcebookingheaderid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "bookableresourcebookingheader",
					Entity2LogicalName = "letter",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N bookableresourcebookingheader_MailboxTrackingFolders</summary>
			public static readonly XrmFakedRelationship BookableresourcebookingheaderMailboxTrackingFolders = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "bookableresourcebookingheaderid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "bookableresourcebookingheader",
					Entity2LogicalName = "mailboxtrackingfolder",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N bookableresourcebookingheader_OpportunityCloses</summary>
			public static readonly XrmFakedRelationship BookableresourcebookingheaderOpportunityCloses = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "bookableresourcebookingheaderid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "bookableresourcebookingheader",
					Entity2LogicalName = "opportunityclose",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N bookableresourcebookingheader_OrderCloses</summary>
			public static readonly XrmFakedRelationship BookableresourcebookingheaderOrderCloses = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "bookableresourcebookingheaderid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "bookableresourcebookingheader",
					Entity2LogicalName = "orderclose",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N bookableresourcebookingheader_PhoneCalls</summary>
			public static readonly XrmFakedRelationship BookableresourcebookingheaderPhoneCalls = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "bookableresourcebookingheaderid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "bookableresourcebookingheader",
					Entity2LogicalName = "phonecall",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N bookableresourcebookingheader_PrincipalObjectAttributeAccess</summary>
			public static readonly XrmFakedRelationship BookableresourcebookingheaderPrincipalObjectAttributeAccess = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "bookableresourcebookingheaderid",
					Entity2Attribute = "objectid",
					Entity1LogicalName = "bookableresourcebookingheader",
					Entity2LogicalName = "principalobjectattributeaccess",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N bookableresourcebookingheader_ProcessSession</summary>
			public static readonly XrmFakedRelationship BookableresourcebookingheaderProcessSession = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "bookableresourcebookingheaderid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "bookableresourcebookingheader",
					Entity2LogicalName = "processsession",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N bookableresourcebookingheader_QuoteCloses</summary>
			public static readonly XrmFakedRelationship BookableresourcebookingheaderQuoteCloses = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "bookableresourcebookingheaderid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "bookableresourcebookingheader",
					Entity2LogicalName = "quoteclose",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N bookableresourcebookingheader_RecurringAppointmentMasters</summary>
			public static readonly XrmFakedRelationship BookableresourcebookingheaderRecurringAppointmentMasters = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "bookableresourcebookingheaderid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "bookableresourcebookingheader",
					Entity2LogicalName = "recurringappointmentmaster",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N bookableresourcebookingheader_ServiceAppointments</summary>
			public static readonly XrmFakedRelationship BookableresourcebookingheaderServiceAppointments = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "bookableresourcebookingheaderid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "bookableresourcebookingheader",
					Entity2LogicalName = "serviceappointment",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N bookableresourcebookingheader_SocialActivities</summary>
			public static readonly XrmFakedRelationship BookableresourcebookingheaderSocialActivities = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "bookableresourcebookingheaderid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "bookableresourcebookingheader",
					Entity2LogicalName = "socialactivity",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N BookableResourceBookingHeader_SyncErrors</summary>
			public static readonly XrmFakedRelationship BookableResourceBookingHeaderSyncErrors = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "bookableresourcebookingheaderid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "bookableresourcebookingheader",
					Entity2LogicalName = "syncerror",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N bookableresourcebookingheader_Tasks</summary>
			public static readonly XrmFakedRelationship BookableresourcebookingheaderTasks = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "bookableresourcebookingheaderid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "bookableresourcebookingheader",
					Entity2LogicalName = "task",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

		}
		#endregion

		#region Fake
		public static BookableResourceBookingHeader Create()
		{
			var faker = new Faker<BookableResourceBookingHeader>()
			.RuleFor(e => e.Id, fake => Guid.NewGuid())
			.RuleFor(e => e.Createdbyname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Createdbyyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.CreatedOn, fake => fake.Date.Soon())
			.RuleFor(e => e.Createdonbehalfbyname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Createdonbehalfbyyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.Duration, fake => fake.Random.Int())
			.RuleFor(e => e.EndTime, fake => fake.Date.Soon())
			.RuleFor(e => e.ExchangeRate, fake => fake.Finance.Amount())
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
			.RuleFor(e => e.DeprecatedStageId, fake => Guid.NewGuid())
			.RuleFor(e => e.StartTime, fake => fake.Date.Soon())
			.RuleFor(e => e.Status, fake => fake.PickRandom<BookableResourceBookingHeader.eStatus>())
			.RuleFor(e => e.StatusReason, fake => fake.PickRandom<BookableResourceBookingHeader.eStatusReason>())
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

