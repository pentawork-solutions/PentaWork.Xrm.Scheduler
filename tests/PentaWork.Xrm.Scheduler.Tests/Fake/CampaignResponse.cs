using Bogus;
using System;
using FakeXrmEasy;
using System.Collections.Generic;
using PentaWork.Xrm.Scheduler.Proxies.Entities;

namespace PentaWork.Xrm.Scheduler.Tests.Fake
{
	public static class FakeCampaignResponse
	{	
		#region FakeRelationships
		public static class Relationships 
		{
			/// <summary>1:N campaignresponse_activity_parties</summary>
			public static readonly XrmFakedRelationship CampaignresponseActivityParties = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "activityid",
					Entity2Attribute = "activityid",
					Entity1LogicalName = "campaignresponse",
					Entity2LogicalName = "activityparty",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N CampaignResponse_Annotation</summary>
			public static readonly XrmFakedRelationship CampaignResponseAnnotation = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "activityid",
					Entity2Attribute = "objectid",
					Entity1LogicalName = "campaignresponse",
					Entity2LogicalName = "annotation",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N CampaignResponse_AsyncOperations</summary>
			public static readonly XrmFakedRelationship CampaignResponseAsyncOperations = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "activityid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "campaignresponse",
					Entity2LogicalName = "asyncoperation",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N CampaignResponse_BulkDeleteFailures</summary>
			public static readonly XrmFakedRelationship CampaignResponseBulkDeleteFailures = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "activityid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "campaignresponse",
					Entity2LogicalName = "bulkdeletefailure",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N CampaignResponse_DuplicateBaseRecord</summary>
			public static readonly XrmFakedRelationship CampaignResponseDuplicateBaseRecord = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "activityid",
					Entity2Attribute = "baserecordid",
					Entity1LogicalName = "campaignresponse",
					Entity2LogicalName = "duplicaterecord",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N CampaignResponse_DuplicateMatchingRecord</summary>
			public static readonly XrmFakedRelationship CampaignResponseDuplicateMatchingRecord = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "activityid",
					Entity2Attribute = "duplicaterecordid",
					Entity1LogicalName = "campaignresponse",
					Entity2LogicalName = "duplicaterecord",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N CampaignResponse_Lead</summary>
			public static readonly XrmFakedRelationship CampaignResponseLead = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "activityid",
					Entity2Attribute = "relatedobjectid",
					Entity1LogicalName = "campaignresponse",
					Entity2LogicalName = "lead",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N campaignresponse_MailboxTrackingFolders</summary>
			public static readonly XrmFakedRelationship CampaignresponseMailboxTrackingFolders = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "activityid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "campaignresponse",
					Entity2LogicalName = "mailboxtrackingfolder",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N campaignresponse_principalobjectattributeaccess</summary>
			public static readonly XrmFakedRelationship CampaignresponsePrincipalobjectattributeaccess = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "activityid",
					Entity2Attribute = "objectid",
					Entity1LogicalName = "campaignresponse",
					Entity2LogicalName = "principalobjectattributeaccess",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N CampaignResponse_ProcessSessions</summary>
			public static readonly XrmFakedRelationship CampaignResponseProcessSessions = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "activityid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "campaignresponse",
					Entity2LogicalName = "processsession",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N CampaignResponse_QueueItem</summary>
			public static readonly XrmFakedRelationship CampaignResponseQueueItem = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "activityid",
					Entity2Attribute = "objectid",
					Entity1LogicalName = "campaignresponse",
					Entity2LogicalName = "queueitem",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N CampaignResponse_SyncErrors</summary>
			public static readonly XrmFakedRelationship CampaignResponseSyncErrors = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "activityid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "campaignresponse",
					Entity2LogicalName = "syncerror",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

		}
		#endregion

		#region Fake
		public static CampaignResponse Create()
		{
			var faker = new Faker<CampaignResponse>()
			.RuleFor(e => e.AdditionalParameters, fake => fake.Lorem.Word())
			.RuleFor(e => e.Id, fake => Guid.NewGuid())
			.RuleFor(e => e.ActivityType, fake => fake.Lorem.Word())
			.RuleFor(e => e.ActualDuration, fake => fake.Random.Int())
			.RuleFor(e => e.ActualEnd, fake => fake.Date.Soon())
			.RuleFor(e => e.ActualStart, fake => fake.Date.Soon())
			.RuleFor(e => e.Category, fake => fake.Lorem.Word())
			.RuleFor(e => e.Channel, fake => fake.PickRandom<CampaignResponse.eChannel>())
			.RuleFor(e => e.SocialChannel, fake => fake.PickRandom<CampaignResponse.egSocialChannel>())
			.RuleFor(e => e.CompanyName, fake => fake.Lorem.Word())
			.RuleFor(e => e.Createdbyname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Createdbyyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.DateCreated, fake => fake.Date.Soon())
			.RuleFor(e => e.Createdonbehalfbyname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Createdonbehalfbyyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.DateDeliveryLastAttempted, fake => fake.Date.Soon())
			.RuleFor(e => e.DeliveryPriority, fake => fake.PickRandom<CampaignResponse.egDeliveryPriority>())
			.RuleFor(e => e.Description, fake => fake.Lorem.Word())
			.RuleFor(e => e.Email, fake => fake.Lorem.Word())
			.RuleFor(e => e.ExchangeItemID, fake => fake.Lorem.Word())
			.RuleFor(e => e.ExchangeRate, fake => fake.Finance.Amount())
			.RuleFor(e => e.ExchangeWebLink, fake => fake.Lorem.Word())
			.RuleFor(e => e.Fax, fake => fake.Lorem.Word())
			.RuleFor(e => e.FirstName, fake => fake.Lorem.Word())
			.RuleFor(e => e.ImportSequenceNumber, fake => fake.Random.Int())
			.RuleFor(e => e.RecurringInstanceType, fake => fake.PickRandom<CampaignResponse.eAppointmentType>())
			.RuleFor(e => e.IsBilled, fake => fake.Random.Bool())
			.RuleFor(e => e.IsPrivate, fake => fake.Random.Bool())
			.RuleFor(e => e.IsRegularActivity, fake => fake.Random.Bool())
			.RuleFor(e => e.IsWorkflowCreated, fake => fake.Random.Bool())
			.RuleFor(e => e.LastName, fake => fake.Lorem.Word())
			.RuleFor(e => e.LastOnHoldTime, fake => fake.Date.Soon())
			.RuleFor(e => e.LeftVoiceMail, fake => fake.Random.Bool())
			.RuleFor(e => e.Modifiedbyname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Modifiedbyyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.LastUpdated, fake => fake.Date.Soon())
			.RuleFor(e => e.Modifiedonbehalfbyname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Modifiedonbehalfbyyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.OnHoldTimeMinutes, fake => fake.Random.Int())
			.RuleFor(e => e.Originatingactivityidtypecode, fake => fake.Lorem.Word())
			.RuleFor(e => e.Originatingactivityidyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.Originatingactivityname, fake => fake.Lorem.Word())
			.RuleFor(e => e.RecordCreatedOn, fake => fake.Date.Soon())
			.RuleFor(e => e.Owneridname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Owneridtype, fake => fake.Lorem.Word())
			.RuleFor(e => e.Owneridyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.DelayActivityProcessingUntil, fake => fake.Date.Soon())
			.RuleFor(e => e.Priority, fake => fake.PickRandom<CampaignResponse.ePriority>())
			.RuleFor(e => e.ProcessId, fake => Guid.NewGuid())
			.RuleFor(e => e.PromotionCode, fake => fake.Lorem.Word())
			.RuleFor(e => e.ReceivedOn, fake => fake.Date.Soon())
			.RuleFor(e => e.Regardingobjectidname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Regardingobjectidyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.Regardingobjecttypecode, fake => fake.Lorem.Word())
			.RuleFor(e => e.ResponseCode, fake => fake.PickRandom<CampaignResponse.eResponseCode>())
			.RuleFor(e => e.ScheduledDuration, fake => fake.Random.Int())
			.RuleFor(e => e.CloseBy, fake => fake.Date.Soon())
			.RuleFor(e => e.ScheduledStart, fake => fake.Date.Soon())
			.RuleFor(e => e.Sendermailboxidname, fake => fake.Lorem.Word())
			.RuleFor(e => e.DateSent, fake => fake.Date.Soon())
			.RuleFor(e => e.SeriesId, fake => Guid.NewGuid())
			.RuleFor(e => e.Slainvokedidname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Slaname, fake => fake.Lorem.Word())
			.RuleFor(e => e.SortDate, fake => fake.Date.Soon())
			.RuleFor(e => e.DeprecatedProcessStageId, fake => Guid.NewGuid())
			.RuleFor(e => e.Status, fake => fake.PickRandom<CampaignResponse.eActivityStatus>())
			.RuleFor(e => e.StatusReason, fake => fake.PickRandom<CampaignResponse.eStatusReason>())
			.RuleFor(e => e.SubCategory, fake => fake.Lorem.Word())
			.RuleFor(e => e.Subject, fake => fake.Lorem.Word())
			.RuleFor(e => e.Phone, fake => fake.Lorem.Word())
			.RuleFor(e => e.TimeZoneRuleVersionNumber, fake => fake.Random.Int())
			.RuleFor(e => e.Transactioncurrencyidname, fake => fake.Lorem.Word())
			.RuleFor(e => e.DeprecatedTraversedPath, fake => fake.Lorem.Word())
			.RuleFor(e => e.UTCConversionTimeZoneCode, fake => fake.Random.Int())
			.RuleFor(e => e.VersionNumber, fake => fake.Random.Int())
			.RuleFor(e => e.YomiCompanyName, fake => fake.Lorem.Word())
			.RuleFor(e => e.YomiFirstName, fake => fake.Lorem.Word())
			.RuleFor(e => e.YomiLastName, fake => fake.Lorem.Word());
			return faker.Generate();
		}
		#endregion
	}
}

