using Bogus;
using System;
using FakeXrmEasy;
using System.Collections.Generic;
using PentaWork.Xrm.Scheduler.Proxies.Entities;

namespace PentaWork.Xrm.Scheduler.Tests.Fake
{
	public static class FakeOpportunity
	{	
		#region FakeRelationships
		public static class Relationships 
		{
			/// <summary>1:N lead_qualifying_opportunity</summary>
			public static readonly XrmFakedRelationship LeadQualifyingOpportunity = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "opportunityid",
					Entity2Attribute = "qualifyingopportunityid",
					Entity1LogicalName = "opportunity",
					Entity2LogicalName = "lead",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_leadtoopportunitysalesprocess_opportunityid</summary>
			public static readonly XrmFakedRelationship LkLeadtoopportunitysalesprocessOpportunityid = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "opportunityid",
					Entity2Attribute = "opportunityid",
					Entity1LogicalName = "opportunity",
					Entity2LogicalName = "leadtoopportunitysalesprocess",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_opportunitysalesprocess_opportunityid</summary>
			public static readonly XrmFakedRelationship LkOpportunitysalesprocessOpportunityid = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "opportunityid",
					Entity2Attribute = "opportunityid",
					Entity1LogicalName = "opportunity",
					Entity2LogicalName = "opportunitysalesprocess",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N msdyn_playbookinstance_opportunity</summary>
			public static readonly XrmFakedRelationship MsdynPlaybookinstanceOpportunity = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "opportunityid",
					Entity2Attribute = "regarding",
					Entity1LogicalName = "opportunity",
					Entity2LogicalName = "msdyn_playbookinstance",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N opportunity_actioncard</summary>
			public static readonly XrmFakedRelationship OpportunityActioncard = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "opportunityid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "opportunity",
					Entity2LogicalName = "actioncard",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N opportunity_activity_parties</summary>
			public static readonly XrmFakedRelationship OpportunityActivityParties = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "opportunityid",
					Entity2Attribute = "partyid",
					Entity1LogicalName = "opportunity",
					Entity2LogicalName = "activityparty",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N Opportunity_ActivityPointers</summary>
			public static readonly XrmFakedRelationship OpportunityActivityPointers = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "opportunityid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "opportunity",
					Entity2LogicalName = "activitypointer",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N Opportunity_Annotation</summary>
			public static readonly XrmFakedRelationship OpportunityAnnotation = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "opportunityid",
					Entity2Attribute = "objectid",
					Entity1LogicalName = "opportunity",
					Entity2LogicalName = "annotation",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N Opportunity_Appointments</summary>
			public static readonly XrmFakedRelationship OpportunityAppointments = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "opportunityid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "opportunity",
					Entity2LogicalName = "appointment",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N Opportunity_AsyncOperations</summary>
			public static readonly XrmFakedRelationship OpportunityAsyncOperations = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "opportunityid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "opportunity",
					Entity2LogicalName = "asyncoperation",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N Opportunity_BulkDeleteFailures</summary>
			public static readonly XrmFakedRelationship OpportunityBulkDeleteFailures = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "opportunityid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "opportunity",
					Entity2LogicalName = "bulkdeletefailure",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N opportunity_connections1</summary>
			public static readonly XrmFakedRelationship OpportunityConnections1 = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "opportunityid",
					Entity2Attribute = "record1id",
					Entity1LogicalName = "opportunity",
					Entity2LogicalName = "connection",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N opportunity_connections2</summary>
			public static readonly XrmFakedRelationship OpportunityConnections2 = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "opportunityid",
					Entity2Attribute = "record2id",
					Entity1LogicalName = "opportunity",
					Entity2LogicalName = "connection",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N Opportunity_DuplicateBaseRecord</summary>
			public static readonly XrmFakedRelationship OpportunityDuplicateBaseRecord = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "opportunityid",
					Entity2Attribute = "baserecordid",
					Entity1LogicalName = "opportunity",
					Entity2LogicalName = "duplicaterecord",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N Opportunity_DuplicateMatchingRecord</summary>
			public static readonly XrmFakedRelationship OpportunityDuplicateMatchingRecord = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "opportunityid",
					Entity2Attribute = "duplicaterecordid",
					Entity1LogicalName = "opportunity",
					Entity2LogicalName = "duplicaterecord",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N Opportunity_Emails</summary>
			public static readonly XrmFakedRelationship OpportunityEmails = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "opportunityid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "opportunity",
					Entity2LogicalName = "email",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N Opportunity_Faxes</summary>
			public static readonly XrmFakedRelationship OpportunityFaxes = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "opportunityid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "opportunity",
					Entity2LogicalName = "fax",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N opportunity_invoices</summary>
			public static readonly XrmFakedRelationship OpportunityInvoices = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "opportunityid",
					Entity2Attribute = "opportunityid",
					Entity1LogicalName = "opportunity",
					Entity2LogicalName = "invoice",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N Opportunity_Letters</summary>
			public static readonly XrmFakedRelationship OpportunityLetters = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "opportunityid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "opportunity",
					Entity2LogicalName = "letter",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N Opportunity_MailboxTrackingFolder</summary>
			public static readonly XrmFakedRelationship OpportunityMailboxTrackingFolder = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "opportunityid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "opportunity",
					Entity2LogicalName = "mailboxtrackingfolder",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N Opportunity_OpportunityClose</summary>
			public static readonly XrmFakedRelationship OpportunityOpportunityClose = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "opportunityid",
					Entity2Attribute = "opportunityid",
					Entity1LogicalName = "opportunity",
					Entity2LogicalName = "opportunityclose",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N opportunity_OpportunityCloses</summary>
			public static readonly XrmFakedRelationship OpportunityOpportunityCloses = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "opportunityid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "opportunity",
					Entity2LogicalName = "opportunityclose",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N opportunity_OrderCloses</summary>
			public static readonly XrmFakedRelationship OpportunityOrderCloses = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "opportunityid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "opportunity",
					Entity2LogicalName = "orderclose",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N Opportunity_Phonecalls</summary>
			public static readonly XrmFakedRelationship OpportunityPhonecalls = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "opportunityid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "opportunity",
					Entity2LogicalName = "phonecall",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N opportunity_PostFollows</summary>
			public static readonly XrmFakedRelationship OpportunityPostFollows = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "opportunityid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "opportunity",
					Entity2LogicalName = "postfollow",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N opportunity_principalobjectattributeaccess</summary>
			public static readonly XrmFakedRelationship OpportunityPrincipalobjectattributeaccess = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "opportunityid",
					Entity2Attribute = "objectid",
					Entity1LogicalName = "opportunity",
					Entity2LogicalName = "principalobjectattributeaccess",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N Opportunity_ProcessSessions</summary>
			public static readonly XrmFakedRelationship OpportunityProcessSessions = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "opportunityid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "opportunity",
					Entity2LogicalName = "processsession",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N opportunity_QuoteCloses</summary>
			public static readonly XrmFakedRelationship OpportunityQuoteCloses = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "opportunityid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "opportunity",
					Entity2LogicalName = "quoteclose",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N opportunity_quotes</summary>
			public static readonly XrmFakedRelationship OpportunityQuotes = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "opportunityid",
					Entity2Attribute = "opportunityid",
					Entity1LogicalName = "opportunity",
					Entity2LogicalName = "quote",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N Opportunity_RecurringAppointmentMasters</summary>
			public static readonly XrmFakedRelationship OpportunityRecurringAppointmentMasters = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "opportunityid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "opportunity",
					Entity2LogicalName = "recurringappointmentmaster",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N opportunity_sales_orders</summary>
			public static readonly XrmFakedRelationship OpportunitySalesOrders = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "opportunityid",
					Entity2Attribute = "opportunityid",
					Entity1LogicalName = "opportunity",
					Entity2LogicalName = "salesorder",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N Opportunity_ServiceAppointments</summary>
			public static readonly XrmFakedRelationship OpportunityServiceAppointments = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "opportunityid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "opportunity",
					Entity2LogicalName = "serviceappointment",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N Opportunity_SharepointDocumentLocation</summary>
			public static readonly XrmFakedRelationship OpportunitySharepointDocumentLocation = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "opportunityid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "opportunity",
					Entity2LogicalName = "sharepointdocumentlocation",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N Opportunity_SocialActivities</summary>
			public static readonly XrmFakedRelationship OpportunitySocialActivities = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "opportunityid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "opportunity",
					Entity2LogicalName = "socialactivity",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N Opportunity_SyncErrors</summary>
			public static readonly XrmFakedRelationship OpportunitySyncErrors = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "opportunityid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "opportunity",
					Entity2LogicalName = "syncerror",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N Opportunity_Tasks</summary>
			public static readonly XrmFakedRelationship OpportunityTasks = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "opportunityid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "opportunity",
					Entity2LogicalName = "task",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N opportunity_Teams</summary>
			public static readonly XrmFakedRelationship OpportunityTeams = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "opportunityid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "opportunity",
					Entity2LogicalName = "team",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N product_opportunities</summary>
			public static readonly XrmFakedRelationship ProductOpportunities = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "opportunityid",
					Entity2Attribute = "opportunityid",
					Entity1LogicalName = "opportunity",
					Entity2LogicalName = "opportunityproduct",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N slakpiinstance_opportunity</summary>
			public static readonly XrmFakedRelationship SlakpiinstanceOpportunity = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "opportunityid",
					Entity2Attribute = "regarding",
					Entity1LogicalName = "opportunity",
					Entity2LogicalName = "slakpiinstance",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>N:N opportunitycompetitors_association</summary>
			public static readonly XrmFakedRelationship OpportunitycompetitorsAssociation = 
				new XrmFakedRelationship
				{
					IntersectEntity = "opportunitycompetitors_association",
					Entity1Attribute = "opportunityid",
					Entity2Attribute = "competitorid",
					Entity1LogicalName = "opportunity",
					Entity2LogicalName = "competitor",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.ManyToMany
				};

		}
		#endregion

		#region Fake
		public static Opportunity Create()
		{
			var faker = new Faker<Opportunity>()
			.RuleFor(e => e.Accountidname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Accountidyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.ActualCloseDate, fake => fake.Date.Soon())
			.RuleFor(e => e.ActualRevenue, fake => fake.Finance.Amount())
			.RuleFor(e => e.BudgetAmount, fake => fake.Finance.Amount())
			.RuleFor(e => e.Budget, fake => fake.PickRandom<Opportunity.egBudget>())
			.RuleFor(e => e.Campaignidname, fake => fake.Lorem.Word())
			.RuleFor(e => e.ProposalFeedbackCaptured, fake => fake.Random.Bool())
			.RuleFor(e => e.Probability, fake => fake.Random.Int())
			.RuleFor(e => e.FinalProposalReady, fake => fake.Random.Bool())
			.RuleFor(e => e.CompleteInternalReview, fake => fake.Random.Bool())
			.RuleFor(e => e.ConfirmInterest, fake => fake.Random.Bool())
			.RuleFor(e => e.Contactidname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Contactidyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.Createdbyname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Createdbyyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.CreatedOn, fake => fake.Date.Soon())
			.RuleFor(e => e.Createdonbehalfbyname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Createdonbehalfbyyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.CurrentSituation, fake => fake.Lorem.Word())
			.RuleFor(e => e.Customeridname, fake => fake.Lorem.Word())
			.RuleFor(e => e.PotentialCustomerType, fake => fake.Lorem.Word())
			.RuleFor(e => e.Customeridyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.CustomerNeed, fake => fake.Lorem.Word())
			.RuleFor(e => e.CustomerPainPoints, fake => fake.Lorem.Word())
			.RuleFor(e => e.DecisionMaker, fake => fake.Random.Bool())
			.RuleFor(e => e.Description, fake => fake.Lorem.Word())
			.RuleFor(e => e.DevelopProposal, fake => fake.Random.Bool())
			.RuleFor(e => e.OpportunityDiscountAmount, fake => fake.Finance.Amount())
			.RuleFor(e => e.OpportunityDiscount, fake => fake.Finance.Amount())
			.RuleFor(e => e.EmailAddress, fake => fake.Lorem.Word())
			.RuleFor(e => e.EstCloseDate, fake => fake.Date.Soon())
			.RuleFor(e => e.EstRevenue, fake => fake.Finance.Amount())
			.RuleFor(e => e.EvaluateFit, fake => fake.Random.Bool())
			.RuleFor(e => e.ExchangeRate, fake => fake.Finance.Amount())
			.RuleFor(e => e.FileDebrief, fake => fake.Random.Bool())
			.RuleFor(e => e.FinalDecisionDate, fake => fake.Date.Soon())
			.RuleFor(e => e.FreightAmount, fake => fake.Finance.Amount())
			.RuleFor(e => e.IdentifyCompetitors, fake => fake.Random.Bool())
			.RuleFor(e => e.IdentifyCustomerContacts, fake => fake.Random.Bool())
			.RuleFor(e => e.IdentifySalesTeam, fake => fake.Random.Bool())
			.RuleFor(e => e.ImportSequenceNumber, fake => fake.Random.Int())
			.RuleFor(e => e.InitialCommunication, fake => fake.PickRandom<Opportunity.egInitialCommunication>())
			.RuleFor(e => e.IsPrivate, fake => fake.Random.Bool())
			.RuleFor(e => e.Revenue, fake => fake.Random.Bool())
			.RuleFor(e => e.LastOnHoldTime, fake => fake.Date.Soon())
			.RuleFor(e => e.Modifiedbyname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Modifiedbyyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.ModifiedOn, fake => fake.Date.Soon())
			.RuleFor(e => e.Modifiedonbehalfbyname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Modifiedonbehalfbyyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.Topic, fake => fake.Lorem.Word())
			.RuleFor(e => e.Need, fake => fake.PickRandom<Opportunity.egNeed>())
			.RuleFor(e => e.OnHoldTimeMinutes, fake => fake.Random.Int())
			.RuleFor(e => e.Id, fake => Guid.NewGuid())
			.RuleFor(e => e.Rating, fake => fake.PickRandom<Opportunity.eRating>())
			.RuleFor(e => e.Originatingleadidname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Originatingleadidyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.RecordCreatedOn, fake => fake.Date.Soon())
			.RuleFor(e => e.Owneridname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Owneridtype, fake => fake.Lorem.Word())
			.RuleFor(e => e.Owneridyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.Parentaccountidname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Parentaccountidyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.Parentcontactidname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Parentcontactidyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.ParticipatesInWorkflow, fake => fake.Random.Bool())
			.RuleFor(e => e.PresentFinalProposal, fake => fake.Random.Bool())
			.RuleFor(e => e.PresentedProposal, fake => fake.Random.Bool())
			.RuleFor(e => e.Pricelevelidname, fake => fake.Lorem.Word())
			.RuleFor(e => e.PricingError, fake => fake.PickRandom<Opportunity.egPricingError>())
			.RuleFor(e => e.Priority, fake => fake.PickRandom<Opportunity.ePriority>())
			.RuleFor(e => e.ProcessId, fake => Guid.NewGuid())
			.RuleFor(e => e.ProposedSolution, fake => fake.Lorem.Word())
			.RuleFor(e => e.PurchaseProcess, fake => fake.PickRandom<Opportunity.egPurchaseProcess>())
			.RuleFor(e => e.PurchaseTimeframe, fake => fake.PickRandom<Opportunity.egPurchaseTimeframe>())
			.RuleFor(e => e.DecideGoNoGo, fake => fake.Random.Bool())
			.RuleFor(e => e.QualificationComments, fake => fake.Lorem.Word())
			.RuleFor(e => e.QuoteComments, fake => fake.Lorem.Word())
			.RuleFor(e => e.FeedbackResolved, fake => fake.Random.Bool())
			.RuleFor(e => e.SalesStage, fake => fake.PickRandom<Opportunity.egOpportunitySalesstage>())
			.RuleFor(e => e.ProcessCode, fake => fake.PickRandom<Opportunity.eProcessCode>())
			.RuleFor(e => e.ScheduledFollowUpProspect, fake => fake.Date.Soon())
			.RuleFor(e => e.ScheduledFollowUpQualify, fake => fake.Date.Soon())
			.RuleFor(e => e.ScheduleProposalMeeting, fake => fake.Date.Soon())
			.RuleFor(e => e.SendThankYouNote, fake => fake.Random.Bool())
			.RuleFor(e => e.SkipPriceCalculation, fake => fake.PickRandom<Opportunity.egSkipPriceCalculationOptionSet>())
			.RuleFor(e => e.Slainvokedidname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Slaname, fake => fake.Lorem.Word())
			.RuleFor(e => e.DeprecatedStageId, fake => Guid.NewGuid())
			.RuleFor(e => e.Status, fake => fake.PickRandom<Opportunity.eStatus>())
			.RuleFor(e => e.StatusReason, fake => fake.PickRandom<Opportunity.eStatusReason>())
			.RuleFor(e => e.StepId, fake => Guid.NewGuid())
			.RuleFor(e => e.PipelinePhase, fake => fake.Lorem.Word())
			.RuleFor(e => e.TeamsFollowed, fake => fake.Random.Int())
			.RuleFor(e => e.Timeline, fake => fake.PickRandom<Opportunity.eTimeline>())
			.RuleFor(e => e.TimeSpentByMe, fake => fake.Lorem.Word())
			.RuleFor(e => e.TimeZoneRuleVersionNumber, fake => fake.Random.Int())
			.RuleFor(e => e.TotalAmount, fake => fake.Finance.Amount())
			.RuleFor(e => e.TotalPreFreightAmount, fake => fake.Finance.Amount())
			.RuleFor(e => e.TotalDiscountAmount, fake => fake.Finance.Amount())
			.RuleFor(e => e.TotalDetailAmount, fake => fake.Finance.Amount())
			.RuleFor(e => e.TotalLineItemDiscountAmount, fake => fake.Finance.Amount())
			.RuleFor(e => e.TotalTax, fake => fake.Finance.Amount())
			.RuleFor(e => e.Transactioncurrencyidname, fake => fake.Lorem.Word())
			.RuleFor(e => e.DeprecatedTraversedPath, fake => fake.Lorem.Word())
			.RuleFor(e => e.UTCConversionTimeZoneCode, fake => fake.Random.Int())
			.RuleFor(e => e.VersionNumber, fake => fake.Random.Int());
			return faker.Generate();
		}
		#endregion
	}
}

