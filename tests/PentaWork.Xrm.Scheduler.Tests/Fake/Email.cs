using Bogus;
using System;
using FakeXrmEasy;
using System.Collections.Generic;
using PentaWork.Xrm.Scheduler.Proxies.Entities;

namespace PentaWork.Xrm.Scheduler.Tests.Fake
{
	public static class FakeEmail
	{	
		#region FakeRelationships
		public static class Relationships 
		{
			/// <summary>1:N email_activity_parties</summary>
			public static readonly XrmFakedRelationship EmailActivityParties = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "activityid",
					Entity2Attribute = "activityid",
					Entity1LogicalName = "email",
					Entity2LogicalName = "activityparty",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N Email_AsyncOperations</summary>
			public static readonly XrmFakedRelationship EmailAsyncOperations = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "activityid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "email",
					Entity2LogicalName = "asyncoperation",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N email_email_CorrelatedActivityId</summary>
			public static readonly XrmFakedRelationship EmailEmailCorrelatedActivityId = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "activityid",
					Entity2Attribute = "correlatedactivityid",
					Entity1LogicalName = "email",
					Entity2LogicalName = "email",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N email_email_parentactivityid</summary>
			public static readonly XrmFakedRelationship EmailEmailParentactivityid = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "activityid",
					Entity2Attribute = "parentactivityid",
					Entity1LogicalName = "email",
					Entity2LogicalName = "email",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

		}
		#endregion

		#region Fake
		public static Email Create()
		{
			var faker = new Faker<Email>()
			.RuleFor(e => e.AcceptingEntityName, fake => fake.Lorem.Word())
			.RuleFor(e => e.AcceptingUserOrQueueObjectType, fake => fake.Lorem.Word())
			.RuleFor(e => e.AdditionalParameters, fake => fake.Lorem.Word())
			.RuleFor(e => e.Id, fake => Guid.NewGuid())
			.RuleFor(e => e.ActivityType, fake => fake.Lorem.Word())
			.RuleFor(e => e.Duration, fake => fake.Random.Int())
			.RuleFor(e => e.ActualEnd, fake => fake.Date.Soon())
			.RuleFor(e => e.ActualStart, fake => fake.Date.Soon())
			.RuleFor(e => e.AttachmentCount, fake => fake.Random.Int())
			.RuleFor(e => e.AttachmentOpenCount, fake => fake.Random.Int())
			.RuleFor(e => e.ConversationIndexHash, fake => fake.Random.Int())
			.RuleFor(e => e.Category, fake => fake.Lorem.Word())
			.RuleFor(e => e.Compression, fake => fake.Random.Bool())
			.RuleFor(e => e.ConversationIndex, fake => fake.Lorem.Word())
			.RuleFor(e => e.ConversationTrackingId, fake => Guid.NewGuid())
			.RuleFor(e => e.Correlatedactivityidname, fake => fake.Lorem.Word())
			.RuleFor(e => e.CorrelatedSubjectChanged, fake => fake.Random.Bool())
			.RuleFor(e => e.CorrelationMethod, fake => fake.PickRandom<Email.eCorrelationMethod>())
			.RuleFor(e => e.Createdbyname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Createdbyyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.CreatedOn, fake => fake.Date.Soon())
			.RuleFor(e => e.Createdonbehalfbyname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Createdonbehalfbyyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.SendLater, fake => fake.Date.Soon())
			.RuleFor(e => e.NoOfDeliveryAttempts, fake => fake.Random.Int())
			.RuleFor(e => e.DeliveryPriority, fake => fake.PickRandom<Email.egDeliveryPriority>())
			.RuleFor(e => e.DeliveryReceiptRequested, fake => fake.Random.Bool())
			.RuleFor(e => e.Description, fake => fake.Lorem.Word())
			.RuleFor(e => e.DescriptionblobidName, fake => fake.Lorem.Word())
			.RuleFor(e => e.Direction, fake => fake.Random.Bool())
			.RuleFor(e => e.EmailReminderExpiryTime, fake => fake.Date.Soon())
			.RuleFor(e => e.EmailReminderStatus, fake => fake.PickRandom<Email.eEmailReminderStatus>())
			.RuleFor(e => e.EmailReminderText, fake => fake.Lorem.Word())
			.RuleFor(e => e.EmailReminderType, fake => fake.PickRandom<Email.eEmailReminderType>())
			.RuleFor(e => e.EmailSenderName, fake => fake.Lorem.Word())
			.RuleFor(e => e.EmailSenderType, fake => fake.Lorem.Word())
			.RuleFor(e => e.EmailSenderYomiName, fake => fake.Lorem.Word())
			.RuleFor(e => e.EmailTrackingId, fake => Guid.NewGuid())
			.RuleFor(e => e.ExchangeRate, fake => fake.Finance.Amount())
			.RuleFor(e => e.Following, fake => fake.Random.Bool())
			.RuleFor(e => e.ImportSequenceNumber, fake => fake.Random.Int())
			.RuleFor(e => e.InReplyToMessage, fake => fake.Lorem.Word())
			.RuleFor(e => e.InternetMessageHeaders, fake => fake.Lorem.Word())
			.RuleFor(e => e.IsBilled, fake => fake.Random.Bool())
			.RuleFor(e => e.IsDuplicateSenderUnresolved, fake => fake.Random.Bool())
			.RuleFor(e => e.Followed, fake => fake.Random.Bool())
			.RuleFor(e => e.ReminderSet, fake => fake.Random.Bool())
			.RuleFor(e => e.IsRegularActivity, fake => fake.Random.Bool())
			.RuleFor(e => e.IsSafeDescriptionTruncated, fake => fake.Random.Int())
			.RuleFor(e => e.IsUnsafe, fake => fake.Random.Int())
			.RuleFor(e => e.IsWorkflowCreated, fake => fake.Random.Bool())
			.RuleFor(e => e.LastOnHoldTime, fake => fake.Date.Soon())
			.RuleFor(e => e.LastOpenedTime, fake => fake.Date.Soon())
			.RuleFor(e => e.LinksClickedCount, fake => fake.Random.Int())
			.RuleFor(e => e.MessageID, fake => fake.Lorem.Word())
			.RuleFor(e => e.MessageIDDupCheckId, fake => Guid.NewGuid())
			.RuleFor(e => e.MimeType, fake => fake.Lorem.Word())
			.RuleFor(e => e.Modifiedbyname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Modifiedbyyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.ModifiedOn, fake => fake.Date.Soon())
			.RuleFor(e => e.Modifiedonbehalfbyname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Modifiedonbehalfbyyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.Notifications, fake => fake.PickRandom<Email.eNotifications>())
			.RuleFor(e => e.OnHoldTimeMinutes, fake => fake.Random.Int())
			.RuleFor(e => e.OpenCount, fake => fake.Random.Int())
			.RuleFor(e => e.RecordCreatedOn, fake => fake.Date.Soon())
			.RuleFor(e => e.Owneridname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Owneridtype, fake => fake.Lorem.Word())
			.RuleFor(e => e.Owneridyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.Owningbusinessunitname, fake => fake.Lorem.Word())
			.RuleFor(e => e.ParentActivityName, fake => fake.Lorem.Word())
			.RuleFor(e => e.DelayEmailProcessingUntil, fake => fake.Date.Soon())
			.RuleFor(e => e.Priority, fake => fake.PickRandom<Email.ePriority>())
			.RuleFor(e => e.ProcessId, fake => Guid.NewGuid())
			.RuleFor(e => e.ReadReceiptRequested, fake => fake.Random.Bool())
			.RuleFor(e => e.Receivingmailboxidname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Regardingobjectidname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Regardingobjectidyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.Regardingobjecttypecode, fake => fake.Lorem.Word())
			.RuleFor(e => e.ReminderActionCardId, fake => Guid.NewGuid())
			.RuleFor(e => e.ReplyCount, fake => fake.Random.Int())
			.RuleFor(e => e.ReservedForInternalUse, fake => fake.Lorem.Word())
			.RuleFor(e => e.SafeDescription, fake => fake.Lorem.Word())
			.RuleFor(e => e.ScheduledDuration, fake => fake.Random.Int())
			.RuleFor(e => e.DueDate, fake => fake.Date.Soon())
			.RuleFor(e => e.StartDate, fake => fake.Date.Soon())
			.RuleFor(e => e.From2, fake => fake.Lorem.Word())
			.RuleFor(e => e.Sendermailboxidname, fake => fake.Lorem.Word())
			.RuleFor(e => e.EmailSenderAccountName, fake => fake.Lorem.Word())
			.RuleFor(e => e.SendersAccountType, fake => fake.Lorem.Word())
			.RuleFor(e => e.EmailSenderAccountYomiName, fake => fake.Lorem.Word())
			.RuleFor(e => e.DateSent, fake => fake.Date.Soon())
			.RuleFor(e => e.Slainvokedidname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Slaname, fake => fake.Lorem.Word())
			.RuleFor(e => e.SortDate, fake => fake.Date.Soon())
			.RuleFor(e => e.DeprecatedProcessStageId, fake => Guid.NewGuid())
			.RuleFor(e => e.ActivityStatus, fake => fake.PickRandom<Email.eActivityStatus>())
			.RuleFor(e => e.StatusReason, fake => fake.PickRandom<Email.eStatusReason>())
			.RuleFor(e => e.SubCategory, fake => fake.Lorem.Word())
			.RuleFor(e => e.Subject, fake => fake.Lorem.Word())
			.RuleFor(e => e.SubmittedBy, fake => fake.Lorem.Word())
			.RuleFor(e => e.Templateidname, fake => fake.Lorem.Word())
			.RuleFor(e => e.TimeZoneRuleVersionNumber, fake => fake.Random.Int())
			.RuleFor(e => e.ToRecipients, fake => fake.Lorem.Word())
			.RuleFor(e => e.TrackingToken, fake => fake.Lorem.Word())
			.RuleFor(e => e.Transactioncurrencyidname, fake => fake.Lorem.Word())
			.RuleFor(e => e.DeprecatedTraversedPath, fake => fake.Lorem.Word())
			.RuleFor(e => e.UTCConversionTimeZoneCode, fake => fake.Random.Int())
			.RuleFor(e => e.VersionNumber, fake => fake.Random.Int());
			return faker.Generate();
		}
		#endregion
	}
}

