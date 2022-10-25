using Bogus;
using System;
using FakeXrmEasy;
using System.Collections.Generic;
using PentaWork.Xrm.Scheduler.Proxies.Entities;

namespace PentaWork.Xrm.Scheduler.Tests.Fake
{
	public static class FakeOpportunityClose
	{	
		#region FakeRelationships
		public static class Relationships 
		{
			/// <summary>1:N CampaignResponse_OpportunityCloses</summary>
			public static readonly XrmFakedRelationship CampaignResponseOpportunityCloses = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "activityid",
					Entity2Attribute = "originatingactivityid",
					Entity1LogicalName = "opportunityclose",
					Entity2LogicalName = "campaignresponse",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N opportunityclose_activity_parties</summary>
			public static readonly XrmFakedRelationship OpportunitycloseActivityParties = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "activityid",
					Entity2Attribute = "activityid",
					Entity1LogicalName = "opportunityclose",
					Entity2LogicalName = "activityparty",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N OpportunityClose_Annotation</summary>
			public static readonly XrmFakedRelationship OpportunityCloseAnnotation = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "activityid",
					Entity2Attribute = "objectid",
					Entity1LogicalName = "opportunityclose",
					Entity2LogicalName = "annotation",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N OpportunityClose_AsyncOperations</summary>
			public static readonly XrmFakedRelationship OpportunityCloseAsyncOperations = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "activityid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "opportunityclose",
					Entity2LogicalName = "asyncoperation",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N OpportunityClose_BulkDeleteFailures</summary>
			public static readonly XrmFakedRelationship OpportunityCloseBulkDeleteFailures = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "activityid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "opportunityclose",
					Entity2LogicalName = "bulkdeletefailure",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N opportunityclose_MailboxTrackingFolders</summary>
			public static readonly XrmFakedRelationship OpportunitycloseMailboxTrackingFolders = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "activityid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "opportunityclose",
					Entity2LogicalName = "mailboxtrackingfolder",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N opportunityclose_PrincipalObjectAttributeAccesses</summary>
			public static readonly XrmFakedRelationship OpportunityclosePrincipalObjectAttributeAccesses = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "activityid",
					Entity2Attribute = "objectid",
					Entity1LogicalName = "opportunityclose",
					Entity2LogicalName = "principalobjectattributeaccess",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N OpportunityClose_SyncErrors</summary>
			public static readonly XrmFakedRelationship OpportunityCloseSyncErrors = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "activityid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "opportunityclose",
					Entity2LogicalName = "syncerror",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

		}
		#endregion

		#region Fake
		public static OpportunityClose Create()
		{
			var faker = new Faker<OpportunityClose>()
			.RuleFor(e => e.ActivityAdditionalParameters, fake => fake.Lorem.Word())
			.RuleFor(e => e.Id, fake => Guid.NewGuid())
			.RuleFor(e => e.ActivityType, fake => fake.Lorem.Word())
			.RuleFor(e => e.ActualDuration, fake => fake.Random.Int())
			.RuleFor(e => e.ClosedOn, fake => fake.Date.Soon())
			.RuleFor(e => e.ActualRevenue, fake => fake.Finance.Amount())
			.RuleFor(e => e.ActualStart, fake => fake.Date.Soon())
			.RuleFor(e => e.Category, fake => fake.Lorem.Word())
			.RuleFor(e => e.SocialChannel, fake => fake.PickRandom<OpportunityClose.egSocialChannel>())
			.RuleFor(e => e.Competitoridname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Competitoridyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.Createdbyexternalpartyname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Createdbyexternalpartyyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.Createdbyname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Createdbyyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.CreatedOn, fake => fake.Date.Soon())
			.RuleFor(e => e.Createdonbehalfbyname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Createdonbehalfbyyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.DateDeliveryLastAttempted, fake => fake.Date.Soon())
			.RuleFor(e => e.DeliveryPriority, fake => fake.PickRandom<OpportunityClose.egDeliveryPriority>())
			.RuleFor(e => e.Description, fake => fake.Lorem.Word())
			.RuleFor(e => e.ExchangeItemID, fake => fake.Lorem.Word())
			.RuleFor(e => e.ExchangeRate, fake => fake.Finance.Amount())
			.RuleFor(e => e.ExchangeWebLink, fake => fake.Lorem.Word())
			.RuleFor(e => e.ImportSequenceNumber, fake => fake.Random.Int())
			.RuleFor(e => e.RecurringInstanceType, fake => fake.PickRandom<OpportunityClose.eAppointmentType>())
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
			.RuleFor(e => e.Opportunityidname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Opportunityidtype, fake => fake.Lorem.Word())
			.RuleFor(e => e.Status, fake => fake.PickRandom<OpportunityClose.eStatus>())
			.RuleFor(e => e.StatusReason, fake => fake.PickRandom<OpportunityClose.eStatusReason>())
			.RuleFor(e => e.RecordCreatedOn, fake => fake.Date.Soon())
			.RuleFor(e => e.Owneridname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Owneridtype, fake => fake.Lorem.Word())
			.RuleFor(e => e.Owneridyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.DelayActivityProcessingUntil, fake => fake.Date.Soon())
			.RuleFor(e => e.Priority, fake => fake.PickRandom<OpportunityClose.ePriority>())
			.RuleFor(e => e.ProcessId, fake => Guid.NewGuid())
			.RuleFor(e => e.Regardingobjectidname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Regardingobjectidyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.Regardingobjecttypecode, fake => fake.Lorem.Word())
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
			.RuleFor(e => e.Status2, fake => fake.PickRandom<OpportunityClose.eActivityStatus>())
			.RuleFor(e => e.StatusReason2, fake => fake.PickRandom<OpportunityClose.eStatusReason2>())
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

