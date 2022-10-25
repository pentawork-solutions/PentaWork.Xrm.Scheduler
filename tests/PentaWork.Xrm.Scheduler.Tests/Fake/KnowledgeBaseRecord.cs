using Bogus;
using System;
using FakeXrmEasy;
using System.Collections.Generic;
using PentaWork.Xrm.Scheduler.Proxies.Entities;

namespace PentaWork.Xrm.Scheduler.Tests.Fake
{
	public static class FakeKnowledgeBaseRecord
	{	
		#region FakeRelationships
		public static class Relationships 
		{
			/// <summary>1:N KnowledgeBaseRecord_ActivityPointers</summary>
			public static readonly XrmFakedRelationship KnowledgeBaseRecordActivityPointers = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "knowledgebaserecordid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "knowledgebaserecord",
					Entity2LogicalName = "activitypointer",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N KnowledgeBaseRecord_Annotations</summary>
			public static readonly XrmFakedRelationship KnowledgeBaseRecordAnnotations = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "knowledgebaserecordid",
					Entity2Attribute = "objectid",
					Entity1LogicalName = "knowledgebaserecord",
					Entity2LogicalName = "annotation",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N KnowledgeBaseRecord_Appointments</summary>
			public static readonly XrmFakedRelationship KnowledgeBaseRecordAppointments = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "knowledgebaserecordid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "knowledgebaserecord",
					Entity2LogicalName = "appointment",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N KnowledgeBaseRecord_AsyncOperations</summary>
			public static readonly XrmFakedRelationship KnowledgeBaseRecordAsyncOperations = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "knowledgebaserecordid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "knowledgebaserecord",
					Entity2LogicalName = "asyncoperation",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N KnowledgeBaseRecord_BulkDeleteFailures</summary>
			public static readonly XrmFakedRelationship KnowledgeBaseRecordBulkDeleteFailures = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "knowledgebaserecordid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "knowledgebaserecord",
					Entity2LogicalName = "bulkdeletefailure",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N knowledgebaserecord_BulkOperations</summary>
			public static readonly XrmFakedRelationship KnowledgebaserecordBulkOperations = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "knowledgebaserecordid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "knowledgebaserecord",
					Entity2LogicalName = "bulkoperation",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N knowledgebaserecord_CampaignResponses</summary>
			public static readonly XrmFakedRelationship KnowledgebaserecordCampaignResponses = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "knowledgebaserecordid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "knowledgebaserecord",
					Entity2LogicalName = "campaignresponse",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N KnowledgeBaseRecord_connections1</summary>
			public static readonly XrmFakedRelationship KnowledgeBaseRecordConnections1 = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "knowledgebaserecordid",
					Entity2Attribute = "record1id",
					Entity1LogicalName = "knowledgebaserecord",
					Entity2LogicalName = "connection",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N KnowledgeBaseRecord_connections2</summary>
			public static readonly XrmFakedRelationship KnowledgeBaseRecordConnections2 = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "knowledgebaserecordid",
					Entity2Attribute = "record2id",
					Entity1LogicalName = "knowledgebaserecord",
					Entity2LogicalName = "connection",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N KnowledgeBaseRecord_DuplicateBaseRecord</summary>
			public static readonly XrmFakedRelationship KnowledgeBaseRecordDuplicateBaseRecord = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "knowledgebaserecordid",
					Entity2Attribute = "baserecordid",
					Entity1LogicalName = "knowledgebaserecord",
					Entity2LogicalName = "duplicaterecord",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N KnowledgeBaseRecord_DuplicateMatchingRecord</summary>
			public static readonly XrmFakedRelationship KnowledgeBaseRecordDuplicateMatchingRecord = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "knowledgebaserecordid",
					Entity2Attribute = "duplicaterecordid",
					Entity1LogicalName = "knowledgebaserecord",
					Entity2LogicalName = "duplicaterecord",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N KnowledgeBaseRecord_Emails</summary>
			public static readonly XrmFakedRelationship KnowledgeBaseRecordEmails = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "knowledgebaserecordid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "knowledgebaserecord",
					Entity2LogicalName = "email",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N KnowledgeBaseRecord_Faxes</summary>
			public static readonly XrmFakedRelationship KnowledgeBaseRecordFaxes = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "knowledgebaserecordid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "knowledgebaserecord",
					Entity2LogicalName = "fax",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N knowledgebaserecord_IncidentResolutions</summary>
			public static readonly XrmFakedRelationship KnowledgebaserecordIncidentResolutions = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "knowledgebaserecordid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "knowledgebaserecord",
					Entity2LogicalName = "incidentresolution",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N KnowledgeBaseRecord_Letters</summary>
			public static readonly XrmFakedRelationship KnowledgeBaseRecordLetters = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "knowledgebaserecordid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "knowledgebaserecord",
					Entity2LogicalName = "letter",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N knowledgebaserecord_OpportunityCloses</summary>
			public static readonly XrmFakedRelationship KnowledgebaserecordOpportunityCloses = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "knowledgebaserecordid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "knowledgebaserecord",
					Entity2LogicalName = "opportunityclose",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N knowledgebaserecord_OrderCloses</summary>
			public static readonly XrmFakedRelationship KnowledgebaserecordOrderCloses = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "knowledgebaserecordid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "knowledgebaserecord",
					Entity2LogicalName = "orderclose",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N KnowledgeBaseRecord_PhoneCalls</summary>
			public static readonly XrmFakedRelationship KnowledgeBaseRecordPhoneCalls = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "knowledgebaserecordid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "knowledgebaserecord",
					Entity2LogicalName = "phonecall",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N KnowledgeBaseRecord_PrincipalObjectAttributeAccess</summary>
			public static readonly XrmFakedRelationship KnowledgeBaseRecordPrincipalObjectAttributeAccess = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "knowledgebaserecordid",
					Entity2Attribute = "objectid",
					Entity1LogicalName = "knowledgebaserecord",
					Entity2LogicalName = "principalobjectattributeaccess",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N KnowledgeBaseRecord_ProcessSession</summary>
			public static readonly XrmFakedRelationship KnowledgeBaseRecordProcessSession = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "knowledgebaserecordid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "knowledgebaserecord",
					Entity2LogicalName = "processsession",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N knowledgebaserecord_QuoteCloses</summary>
			public static readonly XrmFakedRelationship KnowledgebaserecordQuoteCloses = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "knowledgebaserecordid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "knowledgebaserecord",
					Entity2LogicalName = "quoteclose",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N KnowledgeBaseRecord_RecurringAppointmentMasters</summary>
			public static readonly XrmFakedRelationship KnowledgeBaseRecordRecurringAppointmentMasters = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "knowledgebaserecordid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "knowledgebaserecord",
					Entity2LogicalName = "recurringappointmentmaster",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N KnowledgeBaseRecord_ServiceAppointments</summary>
			public static readonly XrmFakedRelationship KnowledgeBaseRecordServiceAppointments = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "knowledgebaserecordid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "knowledgebaserecord",
					Entity2LogicalName = "serviceappointment",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N KnowledgeBaseRecord_SocialActivities</summary>
			public static readonly XrmFakedRelationship KnowledgeBaseRecordSocialActivities = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "knowledgebaserecordid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "knowledgebaserecord",
					Entity2LogicalName = "socialactivity",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N KnowledgeBaseRecord_SyncErrors</summary>
			public static readonly XrmFakedRelationship KnowledgeBaseRecordSyncErrors = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "knowledgebaserecordid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "knowledgebaserecord",
					Entity2LogicalName = "syncerror",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N KnowledgeBaseRecord_Tasks</summary>
			public static readonly XrmFakedRelationship KnowledgeBaseRecordTasks = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "knowledgebaserecordid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "knowledgebaserecord",
					Entity2LogicalName = "task",
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
		public static KnowledgeBaseRecord Create()
		{
			var faker = new Faker<KnowledgeBaseRecord>()
			.RuleFor(e => e.Createdbyname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Createdbyyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.CreatedOn, fake => fake.Date.Soon())
			.RuleFor(e => e.Createdonbehalfbyname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Createdonbehalfbyyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.ExchangeRate, fake => fake.Finance.Amount())
			.RuleFor(e => e.Id, fake => Guid.NewGuid())
			.RuleFor(e => e.Modifiedbyname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Modifiedbyyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.ModifiedOn, fake => fake.Date.Soon())
			.RuleFor(e => e.Modifiedonbehalfbyname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Modifiedonbehalfbyyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.Organizationidname, fake => fake.Lorem.Word())
			.RuleFor(e => e.PrivateURL, fake => fake.Lorem.Word())
			.RuleFor(e => e.PublicURL, fake => fake.Lorem.Word())
			.RuleFor(e => e.TimeZoneRuleVersionNumber, fake => fake.Random.Int())
			.RuleFor(e => e.KBRecordTitle, fake => fake.Lorem.Word())
			.RuleFor(e => e.Transactioncurrencyidname, fake => fake.Lorem.Word())
			.RuleFor(e => e.UniqueID, fake => fake.Lorem.Word())
			.RuleFor(e => e.Versionnumber, fake => fake.Random.Int());
			return faker.Generate();
		}
		#endregion
	}
}

