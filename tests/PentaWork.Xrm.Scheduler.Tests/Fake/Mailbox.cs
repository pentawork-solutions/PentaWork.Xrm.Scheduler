using Bogus;
using System;
using FakeXrmEasy;
using System.Collections.Generic;
using PentaWork.Xrm.Scheduler.Proxies.Entities;

namespace PentaWork.Xrm.Scheduler.Tests.Fake
{
	public static class FakeMailbox
	{	
		#region FakeRelationships
		public static class Relationships 
		{
			/// <summary>1:N activitypointer_sendermailboxid_mailbox</summary>
			public static readonly XrmFakedRelationship ActivitypointerSendermailboxidMailbox = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "mailboxid",
					Entity2Attribute = "sendermailboxid",
					Entity1LogicalName = "mailbox",
					Entity2LogicalName = "activitypointer",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N bulkoperation_mailbox_sendermailboxid</summary>
			public static readonly XrmFakedRelationship BulkoperationMailboxSendermailboxid = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "mailboxid",
					Entity2Attribute = "sendermailboxid",
					Entity1LogicalName = "mailbox",
					Entity2LogicalName = "bulkoperation",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N campaignactivity_mailbox_sendermailboxid</summary>
			public static readonly XrmFakedRelationship CampaignactivityMailboxSendermailboxid = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "mailboxid",
					Entity2Attribute = "sendermailboxid",
					Entity1LogicalName = "mailbox",
					Entity2LogicalName = "campaignactivity",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N campaignresponse_mailbox_sendermailboxid</summary>
			public static readonly XrmFakedRelationship CampaignresponseMailboxSendermailboxid = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "mailboxid",
					Entity2Attribute = "sendermailboxid",
					Entity1LogicalName = "mailbox",
					Entity2LogicalName = "campaignresponse",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N email_sendermailboxid_mailbox</summary>
			public static readonly XrmFakedRelationship EmailSendermailboxidMailbox = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "mailboxid",
					Entity2Attribute = "sendermailboxid",
					Entity1LogicalName = "mailbox",
					Entity2LogicalName = "email",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N incidentresolution_mailbox_sendermailboxid</summary>
			public static readonly XrmFakedRelationship IncidentresolutionMailboxSendermailboxid = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "mailboxid",
					Entity2Attribute = "sendermailboxid",
					Entity1LogicalName = "mailbox",
					Entity2LogicalName = "incidentresolution",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N Mailbox_Annotation</summary>
			public static readonly XrmFakedRelationship MailboxAnnotation = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "mailboxid",
					Entity2Attribute = "objectid",
					Entity1LogicalName = "mailbox",
					Entity2LogicalName = "annotation",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N mailbox_asyncoperations</summary>
			public static readonly XrmFakedRelationship MailboxAsyncoperations = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "mailboxid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "mailbox",
					Entity2LogicalName = "asyncoperation",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N mailbox_FileAttachments</summary>
			public static readonly XrmFakedRelationship MailboxFileAttachments = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "mailboxid",
					Entity2Attribute = "objectid",
					Entity1LogicalName = "mailbox",
					Entity2LogicalName = "fileattachment",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N Mailbox_MailboxTrackingFolder</summary>
			public static readonly XrmFakedRelationship MailboxMailboxTrackingFolder = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "mailboxid",
					Entity2Attribute = "mailboxid",
					Entity1LogicalName = "mailbox",
					Entity2LogicalName = "mailboxtrackingfolder",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N mailbox_processsessions</summary>
			public static readonly XrmFakedRelationship MailboxProcesssessions = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "mailboxid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "mailbox",
					Entity2LogicalName = "processsession",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N Mailbox_SyncErrors</summary>
			public static readonly XrmFakedRelationship MailboxSyncErrors = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "mailboxid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "mailbox",
					Entity2LogicalName = "syncerror",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N opportunityclose_mailbox_sendermailboxid</summary>
			public static readonly XrmFakedRelationship OpportunitycloseMailboxSendermailboxid = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "mailboxid",
					Entity2Attribute = "sendermailboxid",
					Entity1LogicalName = "mailbox",
					Entity2LogicalName = "opportunityclose",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N orderclose_mailbox_sendermailboxid</summary>
			public static readonly XrmFakedRelationship OrdercloseMailboxSendermailboxid = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "mailboxid",
					Entity2Attribute = "sendermailboxid",
					Entity1LogicalName = "mailbox",
					Entity2LogicalName = "orderclose",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N queue_defaultmailbox_mailbox</summary>
			public static readonly XrmFakedRelationship QueueDefaultmailboxMailbox = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "mailboxid",
					Entity2Attribute = "defaultmailbox",
					Entity1LogicalName = "mailbox",
					Entity2LogicalName = "queue",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N quoteclose_mailbox_sendermailboxid</summary>
			public static readonly XrmFakedRelationship QuotecloseMailboxSendermailboxid = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "mailboxid",
					Entity2Attribute = "sendermailboxid",
					Entity1LogicalName = "mailbox",
					Entity2LogicalName = "quoteclose",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N serviceappointment_mailbox_sendermailboxid</summary>
			public static readonly XrmFakedRelationship ServiceappointmentMailboxSendermailboxid = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "mailboxid",
					Entity2Attribute = "sendermailboxid",
					Entity1LogicalName = "mailbox",
					Entity2LogicalName = "serviceappointment",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N systemuser_defaultmailbox_mailbox</summary>
			public static readonly XrmFakedRelationship SystemuserDefaultmailboxMailbox = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "mailboxid",
					Entity2Attribute = "defaultmailbox",
					Entity1LogicalName = "mailbox",
					Entity2LogicalName = "systemuser",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N tracelog_Mailbox</summary>
			public static readonly XrmFakedRelationship TracelogMailbox = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "mailboxid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "mailbox",
					Entity2LogicalName = "tracelog",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

		}
		#endregion

		#region Fake
		public static Mailbox Create()
		{
			var faker = new Faker<Mailbox>()
			.RuleFor(e => e.AppointmentsContactsAndTasks, fake => fake.PickRandom<Mailbox.eAppointmentsContactsAndTasks>())
			.RuleFor(e => e.AppointmentsContactsAndTasksStatus, fake => fake.PickRandom<Mailbox.eAppointmentsContactsAndTasksStatus>())
			.RuleFor(e => e.AllowToUseCredentialsForEmailProcessing, fake => fake.Random.Bool())
			.RuleFor(e => e.MonitorTotalPerformance, fake => fake.Random.Int())
			.RuleFor(e => e.Createdbyname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Createdbyyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.CreatedOn, fake => fake.Date.Soon())
			.RuleFor(e => e.Createdonbehalfbyname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Createdonbehalfbyyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.EmailAddress, fake => fake.Lorem.Word())
			.RuleFor(e => e.EmailAddressStatus, fake => fake.PickRandom<Mailbox.eShowsWhetherTheEmailAddressIsApprovedForEachMailboxForProcessingEmailThroughServersideSynchronizationOrTheEmailRouter>())
			.RuleFor(e => e.Emailserverprofilename, fake => fake.Lorem.Word())
			.RuleFor(e => e.EnabledForAppointmentsContactsAndTasks, fake => fake.Random.Bool())
			.RuleFor(e => e.EnabledForIncomingEmail, fake => fake.Random.Bool())
			.RuleFor(e => e.EnabledForOutgoingEmail, fake => fake.Random.Bool())
			.RuleFor(e => e.EntityimageTimestamp, fake => fake.Random.Int())
			.RuleFor(e => e.EntityimageUrl, fake => fake.Lorem.Word())
			.RuleFor(e => e.EntityImageId, fake => Guid.NewGuid())
			.RuleFor(e => e.ExchangeWebServicesURL, fake => fake.Lorem.Word())
			.RuleFor(e => e.ExchangeContactsImportCompletedOn, fake => fake.Date.Soon())
			.RuleFor(e => e.ExchangeContactsImportStatus, fake => fake.PickRandom<Mailbox.eExchangeContactsImportDeploymentStatus>())
			.RuleFor(e => e.ExchangeSyncState, fake => fake.Lorem.Word())
			.RuleFor(e => e.ExchangesyncstatexmlfilerefName, fake => fake.Lorem.Word())
			.RuleFor(e => e.FolderHierarchy, fake => fake.Lorem.Word())
			.RuleFor(e => e.CountOfTheNumberOfTimesAMailboxGetsForcedUnlocked, fake => fake.Random.Int())
			.RuleFor(e => e.Host, fake => fake.Lorem.Word())
			.RuleFor(e => e.IncomingEmail, fake => fake.PickRandom<Mailbox.eIncomingEmailDeliveryMethod>())
			.RuleFor(e => e.IncomingEmailStatus, fake => fake.PickRandom<Mailbox.eIncomingEmailStatus>())
			.RuleFor(e => e.SetCurrentOrganizationAsSynchronizationOrganization, fake => fake.Random.Bool())
			.RuleFor(e => e.EmailAddressO365AdminApprovalStatus, fake => fake.Random.Bool())
			.RuleFor(e => e.IsExchangeContactsImportScheduled, fake => fake.Random.Bool())
			.RuleFor(e => e.IsForwardMailbox, fake => fake.Random.Bool())
			.RuleFor(e => e.Isoauthaccesstokenset, fake => fake.Random.Bool())
			.RuleFor(e => e.Isoauthrefreshtokenset, fake => fake.Random.Bool())
			.RuleFor(e => e.Ispasswordset, fake => fake.Random.Bool())
			.RuleFor(e => e.IsServiceAccount, fake => fake.Random.Bool())
			.RuleFor(e => e.ItemsFailedForLastSync, fake => fake.Random.Int())
			.RuleFor(e => e.ItemsProcessedForLastSync, fake => fake.Random.Int())
			.RuleFor(e => e.LastActiveOn, fake => fake.Date.Soon())
			.RuleFor(e => e.LastAutoDiscoveredOn, fake => fake.Date.Soon())
			.RuleFor(e => e.MonitorLastDurationPerformance, fake => fake.Random.Int())
			.RuleFor(e => e.LastDateTimeWhenAMailboxGotForcedUnlocked, fake => fake.Date.Soon())
			.RuleFor(e => e.LastMessageID, fake => fake.Lorem.Word())
			.RuleFor(e => e.LastSuccessfulSyncTime, fake => fake.Date.Soon())
			.RuleFor(e => e.LastSyncErrorStack, fake => fake.Lorem.Word())
			.RuleFor(e => e.LastSyncErrorCode, fake => fake.Random.Int())
			.RuleFor(e => e.LastSyncErrorContinuousCount, fake => fake.Random.Int())
			.RuleFor(e => e.LastSyncErrorMachineName, fake => fake.Lorem.Word())
			.RuleFor(e => e.LastSyncErrorTime, fake => fake.Date.Soon())
			.RuleFor(e => e.LastSyncStartTime, fake => fake.Date.Soon())
			.RuleFor(e => e.Id, fake => Guid.NewGuid())
			.RuleFor(e => e.ProcessingContextOfTheMailbox, fake => fake.Random.Int())
			.RuleFor(e => e.MailboxStatus, fake => fake.PickRandom<Mailbox.eMailboxStatus>())
			.RuleFor(e => e.Modifiedbyname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Modifiedbyyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.ModifiedOn, fake => fake.Date.Soon())
			.RuleFor(e => e.Modifiedonbehalfbyname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Modifiedonbehalfbyyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.Name, fake => fake.Lorem.Word())
			.RuleFor(e => e.ZeroAppointmentContactTaskCountForMailbox, fake => fake.Random.Int())
			.RuleFor(e => e.ZeroEmailCountForMailbox, fake => fake.Random.Int())
			.RuleFor(e => e.OauthAccessToken, fake => fake.Lorem.Word())
			.RuleFor(e => e.OauthRefreshToken, fake => fake.Lorem.Word())
			.RuleFor(e => e.OauthTokenExpirationDatetime, fake => fake.Date.Soon())
			.RuleFor(e => e.OfficeAppsDeploymentCompletedOn, fake => fake.Date.Soon())
			.RuleFor(e => e.OfficeAppsDeploymentError, fake => fake.Lorem.Word())
			.RuleFor(e => e.OfficeAppsDeploymentScheduled, fake => fake.Random.Bool())
			.RuleFor(e => e.OfficeAppsDeploymentType, fake => fake.PickRandom<Mailbox.eOfficeAppsDeploymentType>())
			.RuleFor(e => e.Organizationidname, fake => fake.Lorem.Word())
			.RuleFor(e => e.CrmOrgMarkedAsPrimaryOrgForExchangeMailbox, fake => fake.Random.Bool())
			.RuleFor(e => e.OutgoingEmail, fake => fake.PickRandom<Mailbox.eOutgoingEmailDeliveryMethod>())
			.RuleFor(e => e.OutgoingEmailStatus, fake => fake.PickRandom<Mailbox.eOutgoingEmailStatus>())
			.RuleFor(e => e.Owneridname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Owneridtype, fake => fake.Lorem.Word())
			.RuleFor(e => e.Owneridyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.Owningbusinessunitname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Password, fake => fake.Lorem.Word())
			.RuleFor(e => e.PostponeMailboxProcessingUntil, fake => fake.Date.Soon())
			.RuleFor(e => e.PostponeOutlookMailAppInstallUntil, fake => fake.Date.Soon())
			.RuleFor(e => e.PostponeSendingUntil, fake => fake.Date.Soon())
			.RuleFor(e => e.PostponeTestEmailConfigurationUntil, fake => fake.Date.Soon())
			.RuleFor(e => e.DeleteEmailsAfterProcessing, fake => fake.Random.Bool())
			.RuleFor(e => e.MonitorPerformance, fake => fake.Random.Int())
			.RuleFor(e => e.ProcessEmailReceivedAfter, fake => fake.Date.Soon())
			.RuleFor(e => e.DateProcessingLastAttempted, fake => fake.Date.Soon())
			.RuleFor(e => e.MailboxProcessingState, fake => fake.Random.Int())
			.RuleFor(e => e.PostponeReceivingEmailsForTheMailboxUntilTheSpecifiedDataAndTime, fake => fake.Date.Soon())
			.RuleFor(e => e.PostponeProcessingAppointmentsContactsAndTasksForTheMailboxUntilTheSpecifiedDataAndTime, fake => fake.Date.Soon())
			.RuleFor(e => e.RegardingName, fake => fake.Lorem.Word())
			.RuleFor(e => e.RegardingObjectTypeCode, fake => fake.Lorem.Word())
			.RuleFor(e => e.Status, fake => fake.PickRandom<Mailbox.eStatus>())
			.RuleFor(e => e.StatusReason, fake => fake.PickRandom<Mailbox.eStatusReason>())
			.RuleFor(e => e.TestEmailConfigurationRetryCount, fake => fake.Random.Int())
			.RuleFor(e => e.TestEmailConfigurationScheduled, fake => fake.Random.Bool())
			.RuleFor(e => e.MailboxTestCompletedOn, fake => fake.Date.Soon())
			.RuleFor(e => e.TimeZoneRuleVersionNumber, fake => fake.Random.Int())
			.RuleFor(e => e.TransientFailureCount, fake => fake.Random.Int())
			.RuleFor(e => e.UndeliverableFolder, fake => fake.Lorem.Word())
			.RuleFor(e => e.UserName, fake => fake.Lorem.Word())
			.RuleFor(e => e.UTCConversionTimeZoneCode, fake => fake.Random.Int())
			.RuleFor(e => e.VerboseLogging, fake => fake.Random.Int())
			.RuleFor(e => e.VersionNumber, fake => fake.Random.Int());
			return faker.Generate();
		}
		#endregion
	}
}

