using Bogus;
using System;
using FakeXrmEasy;
using System.Collections.Generic;
using PentaWork.Xrm.Scheduler.Proxies.Entities;

namespace PentaWork.Xrm.Scheduler.Tests.Fake
{
	public static class FakeCampaign
	{	
		#region FakeRelationships
		public static class Relationships 
		{
			/// <summary>1:N campaign_activity_parties</summary>
			public static readonly XrmFakedRelationship CampaignActivityParties = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "campaignid",
					Entity2Attribute = "partyid",
					Entity1LogicalName = "campaign",
					Entity2LogicalName = "activityparty",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N Campaign_ActivityPointers</summary>
			public static readonly XrmFakedRelationship CampaignActivityPointers = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "campaignid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "campaign",
					Entity2LogicalName = "activitypointer",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N Campaign_Annotation</summary>
			public static readonly XrmFakedRelationship CampaignAnnotation = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "campaignid",
					Entity2Attribute = "objectid",
					Entity1LogicalName = "campaign",
					Entity2LogicalName = "annotation",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N Campaign_Appointments</summary>
			public static readonly XrmFakedRelationship CampaignAppointments = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "campaignid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "campaign",
					Entity2LogicalName = "appointment",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N Campaign_AsyncOperations</summary>
			public static readonly XrmFakedRelationship CampaignAsyncOperations = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "campaignid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "campaign",
					Entity2LogicalName = "asyncoperation",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N Campaign_BulkDeleteFailures</summary>
			public static readonly XrmFakedRelationship CampaignBulkDeleteFailures = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "campaignid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "campaign",
					Entity2LogicalName = "bulkdeletefailure",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N Campaign_CampaignActivities</summary>
			public static readonly XrmFakedRelationship CampaignCampaignActivities = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "campaignid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "campaign",
					Entity2LogicalName = "campaignactivity",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N Campaign_CampaignResponses</summary>
			public static readonly XrmFakedRelationship CampaignCampaignResponses = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "campaignid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "campaign",
					Entity2LogicalName = "campaignresponse",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N campaign_connections1</summary>
			public static readonly XrmFakedRelationship CampaignConnections1 = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "campaignid",
					Entity2Attribute = "record1id",
					Entity1LogicalName = "campaign",
					Entity2LogicalName = "connection",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N campaign_connections2</summary>
			public static readonly XrmFakedRelationship CampaignConnections2 = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "campaignid",
					Entity2Attribute = "record2id",
					Entity1LogicalName = "campaign",
					Entity2LogicalName = "connection",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N Campaign_DuplicateBaseRecord</summary>
			public static readonly XrmFakedRelationship CampaignDuplicateBaseRecord = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "campaignid",
					Entity2Attribute = "baserecordid",
					Entity1LogicalName = "campaign",
					Entity2LogicalName = "duplicaterecord",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N Campaign_DuplicateMatchingRecord</summary>
			public static readonly XrmFakedRelationship CampaignDuplicateMatchingRecord = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "campaignid",
					Entity2Attribute = "duplicaterecordid",
					Entity1LogicalName = "campaign",
					Entity2LogicalName = "duplicaterecord",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N Campaign_Emails</summary>
			public static readonly XrmFakedRelationship CampaignEmails = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "campaignid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "campaign",
					Entity2LogicalName = "email",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N Campaign_Faxes</summary>
			public static readonly XrmFakedRelationship CampaignFaxes = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "campaignid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "campaign",
					Entity2LogicalName = "fax",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N campaign_IncidentResolutions</summary>
			public static readonly XrmFakedRelationship CampaignIncidentResolutions = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "campaignid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "campaign",
					Entity2LogicalName = "incidentresolution",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N campaign_leads</summary>
			public static readonly XrmFakedRelationship CampaignLeads = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "campaignid",
					Entity2Attribute = "campaignid",
					Entity1LogicalName = "campaign",
					Entity2LogicalName = "lead",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N Campaign_Letters</summary>
			public static readonly XrmFakedRelationship CampaignLetters = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "campaignid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "campaign",
					Entity2LogicalName = "letter",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N Campaign_MailboxTrackingFolder</summary>
			public static readonly XrmFakedRelationship CampaignMailboxTrackingFolder = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "campaignid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "campaign",
					Entity2LogicalName = "mailboxtrackingfolder",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N campaign_opportunities</summary>
			public static readonly XrmFakedRelationship CampaignOpportunities = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "campaignid",
					Entity2Attribute = "campaignid",
					Entity1LogicalName = "campaign",
					Entity2LogicalName = "opportunity",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N campaign_OpportunityCloses</summary>
			public static readonly XrmFakedRelationship CampaignOpportunityCloses = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "campaignid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "campaign",
					Entity2LogicalName = "opportunityclose",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N campaign_OrderCloses</summary>
			public static readonly XrmFakedRelationship CampaignOrderCloses = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "campaignid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "campaign",
					Entity2LogicalName = "orderclose",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N campaign_orders</summary>
			public static readonly XrmFakedRelationship CampaignOrders = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "campaignid",
					Entity2Attribute = "campaignid",
					Entity1LogicalName = "campaign",
					Entity2LogicalName = "salesorder",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N Campaign_Phonecalls</summary>
			public static readonly XrmFakedRelationship CampaignPhonecalls = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "campaignid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "campaign",
					Entity2LogicalName = "phonecall",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N campaign_principalobjectattributeaccess</summary>
			public static readonly XrmFakedRelationship CampaignPrincipalobjectattributeaccess = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "campaignid",
					Entity2Attribute = "objectid",
					Entity1LogicalName = "campaign",
					Entity2LogicalName = "principalobjectattributeaccess",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N Campaign_ProcessSessions</summary>
			public static readonly XrmFakedRelationship CampaignProcessSessions = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "campaignid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "campaign",
					Entity2LogicalName = "processsession",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N campaign_QuoteCloses</summary>
			public static readonly XrmFakedRelationship CampaignQuoteCloses = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "campaignid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "campaign",
					Entity2LogicalName = "quoteclose",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N campaign_quotes</summary>
			public static readonly XrmFakedRelationship CampaignQuotes = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "campaignid",
					Entity2Attribute = "campaignid",
					Entity1LogicalName = "campaign",
					Entity2LogicalName = "quote",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N Campaign_RecurringAppointmentMasters</summary>
			public static readonly XrmFakedRelationship CampaignRecurringAppointmentMasters = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "campaignid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "campaign",
					Entity2LogicalName = "recurringappointmentmaster",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N Campaign_ServiceAppointments</summary>
			public static readonly XrmFakedRelationship CampaignServiceAppointments = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "campaignid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "campaign",
					Entity2LogicalName = "serviceappointment",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N campaign_SocialActivities</summary>
			public static readonly XrmFakedRelationship CampaignSocialActivities = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "campaignid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "campaign",
					Entity2LogicalName = "socialactivity",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N Campaign_SyncErrors</summary>
			public static readonly XrmFakedRelationship CampaignSyncErrors = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "campaignid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "campaign",
					Entity2LogicalName = "syncerror",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N Campaign_Tasks</summary>
			public static readonly XrmFakedRelationship CampaignTasks = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "campaignid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "campaign",
					Entity2LogicalName = "task",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>N:N campaigncampaign_association</summary>
			public static readonly XrmFakedRelationship CampaigncampaignAssociation = 
				new XrmFakedRelationship
				{
					IntersectEntity = "campaigncampaign_association",
					Entity1Attribute = "campaignid",
					Entity2Attribute = "entityid",
					Entity1LogicalName = "campaign",
					Entity2LogicalName = "campaign",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.ManyToMany
				};

			/// <summary>N:N campaignlist_association</summary>
			public static readonly XrmFakedRelationship CampaignlistAssociation = 
				new XrmFakedRelationship
				{
					IntersectEntity = "campaignlist_association",
					Entity1Attribute = "campaignid",
					Entity2Attribute = "entityid",
					Entity1LogicalName = "campaign",
					Entity2LogicalName = "list",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.ManyToMany
				};

			/// <summary>N:N campaignproduct_association</summary>
			public static readonly XrmFakedRelationship CampaignproductAssociation = 
				new XrmFakedRelationship
				{
					IntersectEntity = "campaignproduct_association",
					Entity1Attribute = "campaignid",
					Entity2Attribute = "entityid",
					Entity1LogicalName = "campaign",
					Entity2LogicalName = "product",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.ManyToMany
				};

			/// <summary>N:N campaignsalesliterature_association</summary>
			public static readonly XrmFakedRelationship CampaignsalesliteratureAssociation = 
				new XrmFakedRelationship
				{
					IntersectEntity = "campaignsalesliterature_association",
					Entity1Attribute = "campaignid",
					Entity2Attribute = "entityid",
					Entity1LogicalName = "campaign",
					Entity2LogicalName = "salesliterature",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.ManyToMany
				};

		}
		#endregion

		#region Fake
		public static Campaign Create()
		{
			var faker = new Faker<Campaign>()
			.RuleFor(e => e.ActualEndDate, fake => fake.Date.Soon())
			.RuleFor(e => e.ActualStartDate, fake => fake.Date.Soon())
			.RuleFor(e => e.BudgetAllocated, fake => fake.Finance.Amount())
			.RuleFor(e => e.Id, fake => Guid.NewGuid())
			.RuleFor(e => e.CampaignCode, fake => fake.Lorem.Word())
			.RuleFor(e => e.Createdbyname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Createdbyyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.CreatedOn, fake => fake.Date.Soon())
			.RuleFor(e => e.Createdonbehalfbyname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Createdonbehalfbyyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.Description, fake => fake.Lorem.Word())
			.RuleFor(e => e.EmailAddress, fake => fake.Lorem.Word())
			.RuleFor(e => e.EntityimageTimestamp, fake => fake.Random.Int())
			.RuleFor(e => e.EntityimageUrl, fake => fake.Lorem.Word())
			.RuleFor(e => e.EntityimageId, fake => Guid.NewGuid())
			.RuleFor(e => e.ExchangeRate, fake => fake.Finance.Amount())
			.RuleFor(e => e.ExpectedResponsePercentage, fake => fake.Random.Int())
			.RuleFor(e => e.EstimatedRevenue, fake => fake.Finance.Amount())
			.RuleFor(e => e.ImportSequenceNumber, fake => fake.Random.Int())
			.RuleFor(e => e.Template, fake => fake.Random.Bool())
			.RuleFor(e => e.Message, fake => fake.Lorem.Word())
			.RuleFor(e => e.Modifiedbyname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Modifiedbyyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.ModifiedOn, fake => fake.Date.Soon())
			.RuleFor(e => e.Modifiedonbehalfbyname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Modifiedonbehalfbyyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.Name, fake => fake.Lorem.Word())
			.RuleFor(e => e.Offer, fake => fake.Lorem.Word())
			.RuleFor(e => e.MiscellaneousCosts, fake => fake.Finance.Amount())
			.RuleFor(e => e.RecordCreatedOn, fake => fake.Date.Soon())
			.RuleFor(e => e.Owneridname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Owneridtype, fake => fake.Lorem.Word())
			.RuleFor(e => e.Owneridyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.Pricelistname, fake => fake.Lorem.Word())
			.RuleFor(e => e.ProcessId, fake => Guid.NewGuid())
			.RuleFor(e => e.PromotionCode, fake => fake.Lorem.Word())
			.RuleFor(e => e.ProposedEndDate, fake => fake.Date.Soon())
			.RuleFor(e => e.ProposedStartDate, fake => fake.Date.Soon())
			.RuleFor(e => e.DeprecatedStageId, fake => Guid.NewGuid())
			.RuleFor(e => e.Status, fake => fake.PickRandom<Campaign.eStatus>())
			.RuleFor(e => e.StatusReason, fake => fake.PickRandom<Campaign.eStatusReason>())
			.RuleFor(e => e.TimeZoneRuleVersionNumber, fake => fake.Random.Int())
			.RuleFor(e => e.TmpRegardingObjectId, fake => fake.Lorem.Word())
			.RuleFor(e => e.TotalCostOfCampaign, fake => fake.Finance.Amount())
			.RuleFor(e => e.TotalCostOfCampaignActivities, fake => fake.Finance.Amount())
			.RuleFor(e => e.Transactioncurrencyidname, fake => fake.Lorem.Word())
			.RuleFor(e => e.DeprecatedTraversedPath, fake => fake.Lorem.Word())
			.RuleFor(e => e.CampaignType, fake => fake.PickRandom<Campaign.eCampaignType>())
			.RuleFor(e => e.UTCConversionTimeZoneCode, fake => fake.Random.Int())
			.RuleFor(e => e.VersionNumber, fake => fake.Random.Int());
			return faker.Generate();
		}
		#endregion
	}
}

