using Bogus;
using System;
using FakeXrmEasy;
using System.Collections.Generic;
using PentaWork.Xrm.Scheduler.Proxies.Entities;

namespace PentaWork.Xrm.Scheduler.Tests.Fake
{
	public static class FakeKnowledgeArticle
	{	
		#region FakeRelationships
		public static class Relationships 
		{
			/// <summary>1:N incident_knowledgearticles</summary>
			public static readonly XrmFakedRelationship IncidentKnowledgearticles = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "knowledgearticleid",
					Entity2Attribute = "knowledgearticleid",
					Entity1LogicalName = "knowledgearticle",
					Entity2LogicalName = "knowledgearticleincident",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N knowledgearticle_activity_parties</summary>
			public static readonly XrmFakedRelationship KnowledgearticleActivityParties = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "knowledgearticleid",
					Entity2Attribute = "partyid",
					Entity1LogicalName = "knowledgearticle",
					Entity2LogicalName = "activityparty",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N KnowledgeArticle_ActivityPointers</summary>
			public static readonly XrmFakedRelationship KnowledgeArticleActivityPointers = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "knowledgearticleid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "knowledgearticle",
					Entity2LogicalName = "activitypointer",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N knowledgearticle_Annotations</summary>
			public static readonly XrmFakedRelationship KnowledgearticleAnnotations = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "knowledgearticleid",
					Entity2Attribute = "objectid",
					Entity1LogicalName = "knowledgearticle",
					Entity2LogicalName = "annotation",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N KnowledgeArticle_Appointments</summary>
			public static readonly XrmFakedRelationship KnowledgeArticleAppointments = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "knowledgearticleid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "knowledgearticle",
					Entity2LogicalName = "appointment",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N knowledgearticle_AsyncOperations</summary>
			public static readonly XrmFakedRelationship KnowledgearticleAsyncOperations = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "knowledgearticleid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "knowledgearticle",
					Entity2LogicalName = "asyncoperation",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N knowledgearticle_BulkDeleteFailures</summary>
			public static readonly XrmFakedRelationship KnowledgearticleBulkDeleteFailures = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "knowledgearticleid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "knowledgearticle",
					Entity2LogicalName = "bulkdeletefailure",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N knowledgearticle_BulkOperations</summary>
			public static readonly XrmFakedRelationship KnowledgearticleBulkOperations = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "knowledgearticleid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "knowledgearticle",
					Entity2LogicalName = "bulkoperation",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N knowledgearticle_CampaignResponses</summary>
			public static readonly XrmFakedRelationship KnowledgearticleCampaignResponses = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "knowledgearticleid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "knowledgearticle",
					Entity2LogicalName = "campaignresponse",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N knowledgearticle_connections1</summary>
			public static readonly XrmFakedRelationship KnowledgearticleConnections1 = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "knowledgearticleid",
					Entity2Attribute = "record1id",
					Entity1LogicalName = "knowledgearticle",
					Entity2LogicalName = "connection",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N knowledgearticle_connections2</summary>
			public static readonly XrmFakedRelationship KnowledgearticleConnections2 = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "knowledgearticleid",
					Entity2Attribute = "record2id",
					Entity1LogicalName = "knowledgearticle",
					Entity2LogicalName = "connection",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N knowledgearticle_DuplicateBaseRecord</summary>
			public static readonly XrmFakedRelationship KnowledgearticleDuplicateBaseRecord = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "knowledgearticleid",
					Entity2Attribute = "baserecordid",
					Entity1LogicalName = "knowledgearticle",
					Entity2LogicalName = "duplicaterecord",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N knowledgearticle_DuplicateMatchingRecord</summary>
			public static readonly XrmFakedRelationship KnowledgearticleDuplicateMatchingRecord = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "knowledgearticleid",
					Entity2Attribute = "duplicaterecordid",
					Entity1LogicalName = "knowledgearticle",
					Entity2LogicalName = "duplicaterecord",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N KnowledgeArticle_Emails</summary>
			public static readonly XrmFakedRelationship KnowledgeArticleEmails = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "knowledgearticleid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "knowledgearticle",
					Entity2LogicalName = "email",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N KnowledgeArticle_Faxes</summary>
			public static readonly XrmFakedRelationship KnowledgeArticleFaxes = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "knowledgearticleid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "knowledgearticle",
					Entity2LogicalName = "fax",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N KnowledgeArticle_Feedback</summary>
			public static readonly XrmFakedRelationship KnowledgeArticleFeedback = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "knowledgearticleid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "knowledgearticle",
					Entity2LogicalName = "feedback",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N knowledgearticle_IncidentResolutions</summary>
			public static readonly XrmFakedRelationship KnowledgearticleIncidentResolutions = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "knowledgearticleid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "knowledgearticle",
					Entity2LogicalName = "incidentresolution",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N KnowledgeArticle_Letters</summary>
			public static readonly XrmFakedRelationship KnowledgeArticleLetters = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "knowledgearticleid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "knowledgearticle",
					Entity2LogicalName = "letter",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N knowledgearticle_OpportunityCloses</summary>
			public static readonly XrmFakedRelationship KnowledgearticleOpportunityCloses = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "knowledgearticleid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "knowledgearticle",
					Entity2LogicalName = "opportunityclose",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N knowledgearticle_OrderCloses</summary>
			public static readonly XrmFakedRelationship KnowledgearticleOrderCloses = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "knowledgearticleid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "knowledgearticle",
					Entity2LogicalName = "orderclose",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N knowledgearticle_parentarticle_contentid</summary>
			public static readonly XrmFakedRelationship KnowledgearticleParentarticleContentid = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "knowledgearticleid",
					Entity2Attribute = "parentarticlecontentid",
					Entity1LogicalName = "knowledgearticle",
					Entity2LogicalName = "knowledgearticle",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N KnowledgeArticle_Phonecalls</summary>
			public static readonly XrmFakedRelationship KnowledgeArticlePhonecalls = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "knowledgearticleid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "knowledgearticle",
					Entity2LogicalName = "phonecall",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N knowledgearticle_PostFollows</summary>
			public static readonly XrmFakedRelationship KnowledgearticlePostFollows = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "knowledgearticleid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "knowledgearticle",
					Entity2LogicalName = "postfollow",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N knowledgearticle_previousarticle_contentid</summary>
			public static readonly XrmFakedRelationship KnowledgearticlePreviousarticleContentid = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "knowledgearticleid",
					Entity2Attribute = "previousarticlecontentid",
					Entity1LogicalName = "knowledgearticle",
					Entity2LogicalName = "knowledgearticle",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N knowledgearticle_PrincipalObjectAttributeAccess</summary>
			public static readonly XrmFakedRelationship KnowledgearticlePrincipalObjectAttributeAccess = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "knowledgearticleid",
					Entity2Attribute = "objectid",
					Entity1LogicalName = "knowledgearticle",
					Entity2LogicalName = "principalobjectattributeaccess",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N knowledgearticle_ProcessSession</summary>
			public static readonly XrmFakedRelationship KnowledgearticleProcessSession = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "knowledgearticleid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "knowledgearticle",
					Entity2LogicalName = "processsession",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N knowledgearticle_QueueItems</summary>
			public static readonly XrmFakedRelationship KnowledgearticleQueueItems = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "knowledgearticleid",
					Entity2Attribute = "objectid",
					Entity1LogicalName = "knowledgearticle",
					Entity2LogicalName = "queueitem",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N knowledgearticle_QuoteCloses</summary>
			public static readonly XrmFakedRelationship KnowledgearticleQuoteCloses = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "knowledgearticleid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "knowledgearticle",
					Entity2LogicalName = "quoteclose",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N KnowledgeArticle_RecurringAppointmentMasters</summary>
			public static readonly XrmFakedRelationship KnowledgeArticleRecurringAppointmentMasters = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "knowledgearticleid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "knowledgearticle",
					Entity2LogicalName = "recurringappointmentmaster",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N knowledgearticle_rootarticle_id</summary>
			public static readonly XrmFakedRelationship KnowledgearticleRootarticleId = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "knowledgearticleid",
					Entity2Attribute = "rootarticleid",
					Entity1LogicalName = "knowledgearticle",
					Entity2LogicalName = "knowledgearticle",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N KnowledgeArticle_ServiceAppointments</summary>
			public static readonly XrmFakedRelationship KnowledgeArticleServiceAppointments = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "knowledgearticleid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "knowledgearticle",
					Entity2LogicalName = "serviceappointment",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N knowledgearticle_SharePointDocumentLocations</summary>
			public static readonly XrmFakedRelationship KnowledgearticleSharePointDocumentLocations = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "knowledgearticleid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "knowledgearticle",
					Entity2LogicalName = "sharepointdocumentlocation",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N KnowledgeArticle_SocialActivities</summary>
			public static readonly XrmFakedRelationship KnowledgeArticleSocialActivities = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "knowledgearticleid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "knowledgearticle",
					Entity2LogicalName = "socialactivity",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N KnowledgeArticle_SyncErrors</summary>
			public static readonly XrmFakedRelationship KnowledgeArticleSyncErrors = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "knowledgearticleid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "knowledgearticle",
					Entity2LogicalName = "syncerror",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N KnowledgeArticle_Tasks</summary>
			public static readonly XrmFakedRelationship KnowledgeArticleTasks = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "knowledgearticleid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "knowledgearticle",
					Entity2LogicalName = "task",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N knowledgearticle_Teams</summary>
			public static readonly XrmFakedRelationship KnowledgearticleTeams = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "knowledgearticleid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "knowledgearticle",
					Entity2LogicalName = "team",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N knowledgearticle_views</summary>
			public static readonly XrmFakedRelationship KnowledgearticleViews = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "knowledgearticleid",
					Entity2Attribute = "knowledgearticleid",
					Entity1LogicalName = "knowledgearticle",
					Entity2LogicalName = "knowledgearticleviews",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_expiredprocess_knowledgearticleid</summary>
			public static readonly XrmFakedRelationship LkExpiredprocessKnowledgearticleid = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "knowledgearticleid",
					Entity2Attribute = "knowledgearticleid",
					Entity1LogicalName = "knowledgearticle",
					Entity2LogicalName = "expiredprocess",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_newprocess_knowledgearticleid</summary>
			public static readonly XrmFakedRelationship LkNewprocessKnowledgearticleid = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "knowledgearticleid",
					Entity2Attribute = "knowledgearticleid",
					Entity1LogicalName = "knowledgearticle",
					Entity2LogicalName = "newprocess",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_translationprocess_knowledgearticleid</summary>
			public static readonly XrmFakedRelationship LkTranslationprocessKnowledgearticleid = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "knowledgearticleid",
					Entity2Attribute = "knowledgearticleid",
					Entity1LogicalName = "knowledgearticle",
					Entity2LogicalName = "translationprocess",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N msdyn_knowledgearticle_feedback_context</summary>
			public static readonly XrmFakedRelationship MsdynKnowledgearticleFeedbackContext = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "knowledgearticleid",
					Entity2Attribute = "msdyn_contextobjectid",
					Entity1LogicalName = "knowledgearticle",
					Entity2LogicalName = "feedback",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>N:N knowledgearticle_category</summary>
			public static readonly XrmFakedRelationship KnowledgearticleCategory = 
				new XrmFakedRelationship
				{
					IntersectEntity = "knowledgearticle_category",
					Entity1Attribute = "knowledgearticleid",
					Entity2Attribute = "categoryid",
					Entity1LogicalName = "knowledgearticle",
					Entity2LogicalName = "category",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.ManyToMany
				};

		}
		#endregion

		#region Fake
		public static KnowledgeArticle Create()
		{
			var faker = new Faker<KnowledgeArticle>()
			.RuleFor(e => e.ArticlePublicNumber, fake => fake.Lorem.Word())
			.RuleFor(e => e.Content, fake => fake.Lorem.Word())
			.RuleFor(e => e.Createdbyname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Createdbyyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.CreatedOn, fake => fake.Date.Soon())
			.RuleFor(e => e.Createdonbehalfbyname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Createdonbehalfbyyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.Description, fake => fake.Lorem.Word())
			.RuleFor(e => e.ExchangeRate, fake => fake.Finance.Amount())
			.RuleFor(e => e.ExpirationDate, fake => fake.Date.Soon())
			.RuleFor(e => e.ExpirationStateId, fake => fake.Random.Int())
			.RuleFor(e => e.ExpiredStatus, fake => fake.Random.Int())
			.RuleFor(e => e.ExpiredReviewOptions, fake => fake.PickRandom<KnowledgeArticle.eExpiredReviewOptions>())
			.RuleFor(e => e.ImportSequenceNumber, fake => fake.Random.Int())
			.RuleFor(e => e.Internal, fake => fake.Random.Bool())
			.RuleFor(e => e.IsLatestVersion, fake => fake.Random.Bool())
			.RuleFor(e => e.PrimaryArticle, fake => fake.Random.Bool())
			.RuleFor(e => e.RootArticle, fake => fake.Random.Bool())
			.RuleFor(e => e.Keywords, fake => fake.Lorem.Word())
			.RuleFor(e => e.Id, fake => Guid.NewGuid())
			.RuleFor(e => e.KnowledgeArticleViews, fake => fake.Random.Int())
			.RuleFor(e => e.KnowledgeArticleViewLastUpdatedTime, fake => fake.Date.Soon())
			.RuleFor(e => e.KnowledgeArticleViewState, fake => fake.Random.Int())
			.RuleFor(e => e.Languagelocaleidlocaleid, fake => fake.Random.Int())
			.RuleFor(e => e.Languagelocaleidname, fake => fake.Lorem.Word())
			.RuleFor(e => e.MajorVersionNumber, fake => fake.Random.Int())
			.RuleFor(e => e.MinorVersionNumber, fake => fake.Random.Int())
			.RuleFor(e => e.Modifiedbyname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Modifiedbyyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.ModifiedOn, fake => fake.Date.Soon())
			.RuleFor(e => e.Modifiedonbehalfbyname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Modifiedonbehalfbyyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.RecordCreatedOn, fake => fake.Date.Soon())
			.RuleFor(e => e.Owneridname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Owneridtype, fake => fake.Lorem.Word())
			.RuleFor(e => e.Owneridyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.Parentarticlecontentidname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Previousarticlecontentidname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Primaryauthoridname, fake => fake.Lorem.Word())
			.RuleFor(e => e.ProcessId, fake => Guid.NewGuid())
			.RuleFor(e => e.PublishOn, fake => fake.Date.Soon())
			.RuleFor(e => e.PublishedStatus, fake => fake.Random.Int())
			.RuleFor(e => e.Rating, fake => fake.Finance.Amount())
			.RuleFor(e => e.RatingCount, fake => fake.Random.Int())
			.RuleFor(e => e.RatingLastUpdatedTime, fake => fake.Date.Soon())
			.RuleFor(e => e.RatingState, fake => fake.Random.Int())
			.RuleFor(e => e.Ratingsum, fake => fake.Finance.Amount())
			.RuleFor(e => e.ReadyForReview, fake => fake.Random.Bool())
			.RuleFor(e => e.Review, fake => fake.PickRandom<KnowledgeArticle.eReview>())
			.RuleFor(e => e.Rootarticleidname, fake => fake.Lorem.Word())
			.RuleFor(e => e.ScheduledStatus, fake => fake.Random.Int())
			.RuleFor(e => e.SetCategoryAssociations, fake => fake.Random.Bool())
			.RuleFor(e => e.SetProductAssociations, fake => fake.Random.Bool())
			.RuleFor(e => e.StageId, fake => Guid.NewGuid())
			.RuleFor(e => e.Status, fake => fake.PickRandom<KnowledgeArticle.eStatus>())
			.RuleFor(e => e.StatusReason, fake => fake.PickRandom<KnowledgeArticle.eStatusReason>())
			.RuleFor(e => e.Subjectiddsc, fake => fake.Random.Int())
			.RuleFor(e => e.Subjectidname, fake => fake.Lorem.Word())
			.RuleFor(e => e.TimeZoneRuleVersionNumber, fake => fake.Random.Int())
			.RuleFor(e => e.Title, fake => fake.Lorem.Word())
			.RuleFor(e => e.Transactioncurrencyidname, fake => fake.Lorem.Word())
			.RuleFor(e => e.DeprecatedTraversedPath, fake => fake.Lorem.Word())
			.RuleFor(e => e.UpdateContent, fake => fake.Random.Bool())
			.RuleFor(e => e.UTCConversionTimeZoneCode, fake => fake.Random.Int())
			.RuleFor(e => e.Versionnumber, fake => fake.Random.Int());
			return faker.Generate();
		}
		#endregion
	}
}

