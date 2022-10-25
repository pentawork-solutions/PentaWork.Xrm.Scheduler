using Bogus;
using System;
using FakeXrmEasy;
using System.Collections.Generic;
using PentaWork.Xrm.Scheduler.Proxies.Entities;

namespace PentaWork.Xrm.Scheduler.Tests.Fake
{
	public static class FakeQuoteClose
	{	
		#region FakeRelationships
		public static class Relationships 
		{
			/// <summary>1:N CampaignResponse_QuoteCloses</summary>
			public static readonly XrmFakedRelationship CampaignResponseQuoteCloses = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "activityid",
					Entity2Attribute = "originatingactivityid",
					Entity1LogicalName = "quoteclose",
					Entity2LogicalName = "campaignresponse",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N quoteclose_activity_parties</summary>
			public static readonly XrmFakedRelationship QuotecloseActivityParties = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "activityid",
					Entity2Attribute = "activityid",
					Entity1LogicalName = "quoteclose",
					Entity2LogicalName = "activityparty",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N QuoteClose_Annotation</summary>
			public static readonly XrmFakedRelationship QuoteCloseAnnotation = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "activityid",
					Entity2Attribute = "objectid",
					Entity1LogicalName = "quoteclose",
					Entity2LogicalName = "annotation",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N QuoteClose_AsyncOperations</summary>
			public static readonly XrmFakedRelationship QuoteCloseAsyncOperations = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "activityid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "quoteclose",
					Entity2LogicalName = "asyncoperation",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N QuoteClose_BulkDeleteFailures</summary>
			public static readonly XrmFakedRelationship QuoteCloseBulkDeleteFailures = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "activityid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "quoteclose",
					Entity2LogicalName = "bulkdeletefailure",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N quoteclose_MailboxTrackingFolders</summary>
			public static readonly XrmFakedRelationship QuotecloseMailboxTrackingFolders = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "activityid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "quoteclose",
					Entity2LogicalName = "mailboxtrackingfolder",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N quoteclose_PrincipalObjectAttributeAccesses</summary>
			public static readonly XrmFakedRelationship QuoteclosePrincipalObjectAttributeAccesses = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "activityid",
					Entity2Attribute = "objectid",
					Entity1LogicalName = "quoteclose",
					Entity2LogicalName = "principalobjectattributeaccess",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N QuoteClose_SyncErrors</summary>
			public static readonly XrmFakedRelationship QuoteCloseSyncErrors = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "activityid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "quoteclose",
					Entity2LogicalName = "syncerror",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

		}
		#endregion

		#region Fake
		public static QuoteClose Create()
		{
			var faker = new Faker<QuoteClose>()
			.RuleFor(e => e.ActivityAdditionalParameters, fake => fake.Lorem.Word())
			.RuleFor(e => e.Id, fake => Guid.NewGuid())
			.RuleFor(e => e.ActivityType, fake => fake.Lorem.Word())
			.RuleFor(e => e.ActualDuration, fake => fake.Random.Int())
			.RuleFor(e => e.ClosedDate, fake => fake.Date.Soon())
			.RuleFor(e => e.ActualStart, fake => fake.Date.Soon())
			.RuleFor(e => e.Category, fake => fake.Lorem.Word())
			.RuleFor(e => e.SocialChannel, fake => fake.PickRandom<QuoteClose.egSocialChannel>())
			.RuleFor(e => e.Createdbyexternalpartyname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Createdbyexternalpartyyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.Createdbyname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Createdbyyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.CreatedOn, fake => fake.Date.Soon())
			.RuleFor(e => e.Createdonbehalfbyname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Createdonbehalfbyyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.DateDeliveryLastAttempted, fake => fake.Date.Soon())
			.RuleFor(e => e.DeliveryPriority, fake => fake.PickRandom<QuoteClose.egDeliveryPriority>())
			.RuleFor(e => e.Description, fake => fake.Lorem.Word())
			.RuleFor(e => e.ExchangeItemID, fake => fake.Lorem.Word())
			.RuleFor(e => e.ExchangeRate, fake => fake.Finance.Amount())
			.RuleFor(e => e.ExchangeWebLink, fake => fake.Lorem.Word())
			.RuleFor(e => e.ImportSequenceNumber, fake => fake.Random.Int())
			.RuleFor(e => e.RecurringInstanceType, fake => fake.PickRandom<QuoteClose.eAppointmentType>())
			.RuleFor(e => e.IsBilled, fake => fake.Random.Bool())
			.RuleFor(e => e.IsPrivate, fake => fake.Random.Bool())
			.RuleFor(e => e.IsRegularActivity, fake => fake.Random.Bool())
			.RuleFor(e => e.IsWorkflowCreated, fake => fake.Random.Bool())
			.RuleFor(e => e.LastOnHoldTime, fake => fake.Date.Soon())
			.RuleFor(e => e.LeftVoiceMail, fake => fake.Random.Bool())
			.RuleFor(e => e.Modifiedbyexternalpartyname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Modifiedbyexternalpartyyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.Modifiedbyname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Modifiedbyyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.ModifiedOn, fake => fake.Date.Soon())
			.RuleFor(e => e.Modifiedonbehalfbyname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Modifiedonbehalfbyyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.OnHoldTimeMinutes, fake => fake.Random.Int())
			.RuleFor(e => e.RecordCreatedOn, fake => fake.Date.Soon())
			.RuleFor(e => e.Owneridname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Owneridtype, fake => fake.Lorem.Word())
			.RuleFor(e => e.Owneridyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.DelayActivityProcessingUntil, fake => fake.Date.Soon())
			.RuleFor(e => e.Priority, fake => fake.PickRandom<QuoteClose.ePriority>())
			.RuleFor(e => e.ProcessId, fake => Guid.NewGuid())
			.RuleFor(e => e.Quoteidname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Quoteidtype, fake => fake.Lorem.Word())
			.RuleFor(e => e.QuoteNumber, fake => fake.Lorem.Word())
			.RuleFor(e => e.Regardingobjectidname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Regardingobjectidyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.Regardingobjecttypecode, fake => fake.Lorem.Word())
			.RuleFor(e => e.Revision, fake => fake.Random.Int())
			.RuleFor(e => e.ScheduledDuration, fake => fake.Random.Int())
			.RuleFor(e => e.ScheduledEnd, fake => fake.Date.Soon())
			.RuleFor(e => e.ScheduledStart, fake => fake.Date.Soon())
			.RuleFor(e => e.Sendermailboxidname, fake => fake.Lorem.Word())
			.RuleFor(e => e.DateSent, fake => fake.Date.Soon())
			.RuleFor(e => e.SeriesId, fake => Guid.NewGuid())
			.RuleFor(e => e.Serviceidname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Slainvokedidname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Slaname, fake => fake.Lorem.Word())
			.RuleFor(e => e.SortDate, fake => fake.Date.Soon())
			.RuleFor(e => e.DeprecatedProcessStageId, fake => Guid.NewGuid())
			.RuleFor(e => e.Status, fake => fake.PickRandom<QuoteClose.eActivityStatus>())
			.RuleFor(e => e.StatusReason, fake => fake.PickRandom<QuoteClose.eStatusReason>())
			.RuleFor(e => e.SubCategory, fake => fake.Lorem.Word())
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

