using Bogus;
using System;
using FakeXrmEasy;
using System.Collections.Generic;
using PentaWork.Xrm.Scheduler.Proxies.Entities;

namespace PentaWork.Xrm.Scheduler.Tests.Fake
{
	public static class FakeCase
	{	
		#region FakeRelationships
		public static class Relationships 
		{
			/// <summary>1:N incident_actioncard</summary>
			public static readonly XrmFakedRelationship IncidentActioncard = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "incidentid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "incident",
					Entity2LogicalName = "actioncard",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N incident_activity_parties</summary>
			public static readonly XrmFakedRelationship IncidentActivityParties = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "incidentid",
					Entity2Attribute = "partyid",
					Entity1LogicalName = "incident",
					Entity2LogicalName = "activityparty",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N Incident_ActivityPointers</summary>
			public static readonly XrmFakedRelationship IncidentActivityPointers = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "incidentid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "incident",
					Entity2LogicalName = "activitypointer",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N Incident_Annotation</summary>
			public static readonly XrmFakedRelationship IncidentAnnotation = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "incidentid",
					Entity2Attribute = "objectid",
					Entity1LogicalName = "incident",
					Entity2LogicalName = "annotation",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N Incident_Appointments</summary>
			public static readonly XrmFakedRelationship IncidentAppointments = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "incidentid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "incident",
					Entity2LogicalName = "appointment",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N Incident_AsyncOperations</summary>
			public static readonly XrmFakedRelationship IncidentAsyncOperations = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "incidentid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "incident",
					Entity2LogicalName = "asyncoperation",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N Incident_BulkDeleteFailures</summary>
			public static readonly XrmFakedRelationship IncidentBulkDeleteFailures = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "incidentid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "incident",
					Entity2LogicalName = "bulkdeletefailure",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N incident_connections1</summary>
			public static readonly XrmFakedRelationship IncidentConnections1 = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "incidentid",
					Entity2Attribute = "record1id",
					Entity1LogicalName = "incident",
					Entity2LogicalName = "connection",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N incident_connections2</summary>
			public static readonly XrmFakedRelationship IncidentConnections2 = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "incidentid",
					Entity2Attribute = "record2id",
					Entity1LogicalName = "incident",
					Entity2LogicalName = "connection",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N Incident_DuplicateBaseRecord</summary>
			public static readonly XrmFakedRelationship IncidentDuplicateBaseRecord = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "incidentid",
					Entity2Attribute = "baserecordid",
					Entity1LogicalName = "incident",
					Entity2LogicalName = "duplicaterecord",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N Incident_DuplicateMatchingRecord</summary>
			public static readonly XrmFakedRelationship IncidentDuplicateMatchingRecord = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "incidentid",
					Entity2Attribute = "duplicaterecordid",
					Entity1LogicalName = "incident",
					Entity2LogicalName = "duplicaterecord",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N Incident_Emails</summary>
			public static readonly XrmFakedRelationship IncidentEmails = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "incidentid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "incident",
					Entity2LogicalName = "email",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N incident_existingcase</summary>
			public static readonly XrmFakedRelationship IncidentExistingcase = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "incidentid",
					Entity2Attribute = "existingcase",
					Entity1LogicalName = "incident",
					Entity2LogicalName = "incident",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N Incident_Faxes</summary>
			public static readonly XrmFakedRelationship IncidentFaxes = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "incidentid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "incident",
					Entity2LogicalName = "fax",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N Incident_IncidentResolutions</summary>
			public static readonly XrmFakedRelationship IncidentIncidentResolutions = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "incidentid",
					Entity2Attribute = "incidentid",
					Entity1LogicalName = "incident",
					Entity2LogicalName = "incidentresolution",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N Incident_Letters</summary>
			public static readonly XrmFakedRelationship IncidentLetters = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "incidentid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "incident",
					Entity2LogicalName = "letter",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N Incident_MailboxTrackingFolder</summary>
			public static readonly XrmFakedRelationship IncidentMailboxTrackingFolder = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "incidentid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "incident",
					Entity2LogicalName = "mailboxtrackingfolder",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N incident_master_incident</summary>
			public static readonly XrmFakedRelationship IncidentMasterIncident = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "incidentid",
					Entity2Attribute = "masterid",
					Entity1LogicalName = "incident",
					Entity2LogicalName = "incident",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N incident_OpportunityCloses</summary>
			public static readonly XrmFakedRelationship IncidentOpportunityCloses = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "incidentid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "incident",
					Entity2LogicalName = "opportunityclose",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N incident_OrderCloses</summary>
			public static readonly XrmFakedRelationship IncidentOrderCloses = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "incidentid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "incident",
					Entity2LogicalName = "orderclose",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N incident_parent_incident</summary>
			public static readonly XrmFakedRelationship IncidentParentIncident = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "incidentid",
					Entity2Attribute = "parentcaseid",
					Entity1LogicalName = "incident",
					Entity2LogicalName = "incident",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N Incident_Phonecalls</summary>
			public static readonly XrmFakedRelationship IncidentPhonecalls = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "incidentid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "incident",
					Entity2LogicalName = "phonecall",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N incident_PostFollows</summary>
			public static readonly XrmFakedRelationship IncidentPostFollows = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "incidentid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "incident",
					Entity2LogicalName = "postfollow",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N incident_principalobjectattributeaccess</summary>
			public static readonly XrmFakedRelationship IncidentPrincipalobjectattributeaccess = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "incidentid",
					Entity2Attribute = "objectid",
					Entity1LogicalName = "incident",
					Entity2LogicalName = "principalobjectattributeaccess",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N Incident_ProcessSessions</summary>
			public static readonly XrmFakedRelationship IncidentProcessSessions = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "incidentid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "incident",
					Entity2LogicalName = "processsession",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N Incident_QueueItem</summary>
			public static readonly XrmFakedRelationship IncidentQueueItem = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "incidentid",
					Entity2Attribute = "objectid",
					Entity1LogicalName = "incident",
					Entity2LogicalName = "queueitem",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N incident_QuoteCloses</summary>
			public static readonly XrmFakedRelationship IncidentQuoteCloses = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "incidentid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "incident",
					Entity2LogicalName = "quoteclose",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N Incident_RecurringAppointmentMasters</summary>
			public static readonly XrmFakedRelationship IncidentRecurringAppointmentMasters = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "incidentid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "incident",
					Entity2LogicalName = "recurringappointmentmaster",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N Incident_ServiceAppointments</summary>
			public static readonly XrmFakedRelationship IncidentServiceAppointments = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "incidentid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "incident",
					Entity2LogicalName = "serviceappointment",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N Incident_SocialActivities</summary>
			public static readonly XrmFakedRelationship IncidentSocialActivities = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "incidentid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "incident",
					Entity2LogicalName = "socialactivity",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N Incident_SyncErrors</summary>
			public static readonly XrmFakedRelationship IncidentSyncErrors = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "incidentid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "incident",
					Entity2LogicalName = "syncerror",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N Incident_Tasks</summary>
			public static readonly XrmFakedRelationship IncidentTasks = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "incidentid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "incident",
					Entity2LogicalName = "task",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N knowledgearticle_incidents</summary>
			public static readonly XrmFakedRelationship KnowledgearticleIncidents = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "incidentid",
					Entity2Attribute = "incidentid",
					Entity1LogicalName = "incident",
					Entity2LogicalName = "knowledgearticleincident",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_phonetocaseprocess_incidentid</summary>
			public static readonly XrmFakedRelationship LkPhonetocaseprocessIncidentid = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "incidentid",
					Entity2Attribute = "incidentid",
					Entity1LogicalName = "incident",
					Entity2LogicalName = "phonetocaseprocess",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N OriginatingCase_Lead</summary>
			public static readonly XrmFakedRelationship OriginatingCaseLead = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "incidentid",
					Entity2Attribute = "originatingcaseid",
					Entity1LogicalName = "incident",
					Entity2LogicalName = "lead",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N slakpiinstance_incident</summary>
			public static readonly XrmFakedRelationship SlakpiinstanceIncident = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "incidentid",
					Entity2Attribute = "regarding",
					Entity1LogicalName = "incident",
					Entity2LogicalName = "slakpiinstance",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>N:N KnowledgeBaseRecord_Incident</summary>
			public static readonly XrmFakedRelationship KnowledgeBaseRecordIncident = 
				new XrmFakedRelationship
				{
					IntersectEntity = "KnowledgeBaseRecord_Incident",
					Entity1Attribute = "knowledgebaserecordid",
					Entity2Attribute = "incidentid",
					Entity1LogicalName = "knowledgebaserecord",
					Entity2LogicalName = "incident",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.ManyToMany
				};

		}
		#endregion

		#region Fake
		public static Case Create()
		{
			var faker = new Faker<Case>()
			.RuleFor(e => e.Accountidname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Accountidyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.ActivitiesComplete, fake => fake.Random.Bool())
			.RuleFor(e => e.ActualServiceUnits, fake => fake.Random.Int())
			.RuleFor(e => e.BilledServiceUnits, fake => fake.Random.Int())
			.RuleFor(e => e.BlockedProfile, fake => fake.Random.Bool())
			.RuleFor(e => e.Origin, fake => fake.PickRandom<Case.egCaseOrigin>())
			.RuleFor(e => e.CaseType, fake => fake.PickRandom<Case.eCaseType>())
			.RuleFor(e => e.CheckEmail, fake => fake.Random.Bool())
			.RuleFor(e => e.Contactidname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Contactidyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.Contractdetailidname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Contractidname, fake => fake.Lorem.Word())
			.RuleFor(e => e.ServiceLevel, fake => fake.PickRandom<Case.eServiceLevel>())
			.RuleFor(e => e.Createdbyexternalpartyname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Createdbyexternalpartyyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.Createdbyname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Createdbyyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.CreatedOn, fake => fake.Date.Soon())
			.RuleFor(e => e.Createdonbehalfbyname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Createdonbehalfbyyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.CustomerContacted, fake => fake.Random.Bool())
			.RuleFor(e => e.Customeridname, fake => fake.Lorem.Word())
			.RuleFor(e => e.CustomerType, fake => fake.Lorem.Word())
			.RuleFor(e => e.Customeridyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.Satisfaction, fake => fake.PickRandom<Case.eSatisfaction>())
			.RuleFor(e => e.DecrementEntitlementTerms, fake => fake.Random.Bool())
			.RuleFor(e => e.Description, fake => fake.Lorem.Word())
			.RuleFor(e => e.EmailAddress, fake => fake.Lorem.Word())
			.RuleFor(e => e.Entitlementidname, fake => fake.Lorem.Word())
			.RuleFor(e => e.EntityimageTimestamp, fake => fake.Random.Int())
			.RuleFor(e => e.EntityimageUrl, fake => fake.Lorem.Word())
			.RuleFor(e => e.EntityimageId, fake => Guid.NewGuid())
			.RuleFor(e => e.EscalatedOn, fake => fake.Date.Soon())
			.RuleFor(e => e.ExchangeRate, fake => fake.Finance.Amount())
			.RuleFor(e => e.Firstresponsebykpiidname, fake => fake.Lorem.Word())
			.RuleFor(e => e.FirstResponseSent, fake => fake.Random.Bool())
			.RuleFor(e => e.FirstResponseSLAStatus, fake => fake.PickRandom<Case.eFirstResponseSLAStatus>())
			.RuleFor(e => e.FollowUpBy, fake => fake.Date.Soon())
			.RuleFor(e => e.FollowUpTaskCreated, fake => fake.Random.Bool())
			.RuleFor(e => e.ImportSequenceNumber, fake => fake.Random.Int())
			.RuleFor(e => e.Id, fake => Guid.NewGuid())
			.RuleFor(e => e.CaseStage, fake => fake.PickRandom<Case.eCaseStage>())
			.RuleFor(e => e.InfluenceScore, fake => fake.Random.Double())
			.RuleFor(e => e.Decrementing, fake => fake.Random.Bool())
			.RuleFor(e => e.IsEscalated, fake => fake.Random.Bool())
			.RuleFor(e => e.Kbarticleidname, fake => fake.Lorem.Word())
			.RuleFor(e => e.LastOnHoldTime, fake => fake.Date.Soon())
			.RuleFor(e => e.Masteridname, fake => fake.Lorem.Word())
			.RuleFor(e => e.InternalUseOnly, fake => fake.Random.Bool())
			.RuleFor(e => e.ReceivedAs, fake => fake.PickRandom<Case.egPostMessageType>())
			.RuleFor(e => e.Modifiedbyexternalpartyname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Modifiedbyexternalpartyyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.Modifiedbyname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Modifiedbyyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.ModifiedOn, fake => fake.Date.Soon())
			.RuleFor(e => e.Modifiedonbehalfbyname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Modifiedonbehalfbyyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.ChildCases, fake => fake.Random.Int())
			.RuleFor(e => e.OnHoldTimeMinutes, fake => fake.Random.Int())
			.RuleFor(e => e.RecordCreatedOn, fake => fake.Date.Soon())
			.RuleFor(e => e.Owneridname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Owneridtype, fake => fake.Lorem.Word())
			.RuleFor(e => e.Owneridyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.Parentcaseidname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Primarycontactidname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Primarycontactidyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.Priority, fake => fake.PickRandom<Case.ePriority>())
			.RuleFor(e => e.ProcessId, fake => Guid.NewGuid())
			.RuleFor(e => e.Productidname, fake => fake.Lorem.Word())
			.RuleFor(e => e.SerialNumber, fake => fake.Lorem.Word())
			.RuleFor(e => e.ResolveBy, fake => fake.Date.Soon())
			.RuleFor(e => e.Resolvebykpiidname, fake => fake.Lorem.Word())
			.RuleFor(e => e.ResolveBySLAStatus, fake => fake.PickRandom<Case.eResolveBySLAStatus>())
			.RuleFor(e => e.FirstResponseBy, fake => fake.Date.Soon())
			.RuleFor(e => e.Responsiblecontactidname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Responsiblecontactidyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.RouteCase, fake => fake.Random.Bool())
			.RuleFor(e => e.SentimentValue, fake => fake.Random.Double())
			.RuleFor(e => e.ServiceStage, fake => fake.PickRandom<Case.egServiceStage>())
			.RuleFor(e => e.Severity, fake => fake.PickRandom<Case.eSeverity>())
			.RuleFor(e => e.Slainvokedidname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Slaname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Socialprofileidname, fake => fake.Lorem.Word())
			.RuleFor(e => e.DeprecatedStageId, fake => Guid.NewGuid())
			.RuleFor(e => e.Status, fake => fake.PickRandom<Case.eStatus>())
			.RuleFor(e => e.StatusReason, fake => fake.PickRandom<Case.eStatusReason>())
			.RuleFor(e => e.Subjectidname, fake => fake.Lorem.Word())
			.RuleFor(e => e.CaseNumber, fake => fake.Lorem.Word())
			.RuleFor(e => e.TimeZoneRuleVersionNumber, fake => fake.Random.Int())
			.RuleFor(e => e.CaseTitle, fake => fake.Lorem.Word())
			.RuleFor(e => e.Transactioncurrencyidname, fake => fake.Lorem.Word())
			.RuleFor(e => e.DeprecatedTraversedPath, fake => fake.Lorem.Word())
			.RuleFor(e => e.UTCConversionTimeZoneCode, fake => fake.Random.Int())
			.RuleFor(e => e.VersionNumber, fake => fake.Random.Int());
			return faker.Generate();
		}
		#endregion
	}
}

