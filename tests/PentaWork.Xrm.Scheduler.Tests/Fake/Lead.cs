using Bogus;
using System;
using FakeXrmEasy;
using System.Collections.Generic;
using PentaWork.Xrm.Scheduler.Proxies.Entities;

namespace PentaWork.Xrm.Scheduler.Tests.Fake
{
	public static class FakeLead
	{	
		#region FakeRelationships
		public static class Relationships 
		{
			/// <summary>1:N account_originating_lead</summary>
			public static readonly XrmFakedRelationship AccountOriginatingLead = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "leadid",
					Entity2Attribute = "originatingleadid",
					Entity1LogicalName = "lead",
					Entity2LogicalName = "account",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N contact_originating_lead</summary>
			public static readonly XrmFakedRelationship ContactOriginatingLead = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "leadid",
					Entity2Attribute = "originatingleadid",
					Entity1LogicalName = "lead",
					Entity2LogicalName = "contact",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N Lead_actioncard</summary>
			public static readonly XrmFakedRelationship LeadActioncard = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "leadid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "lead",
					Entity2LogicalName = "actioncard",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lead_activity_parties</summary>
			public static readonly XrmFakedRelationship LeadActivityParties = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "leadid",
					Entity2Attribute = "partyid",
					Entity1LogicalName = "lead",
					Entity2LogicalName = "activityparty",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N Lead_ActivityPointers</summary>
			public static readonly XrmFakedRelationship LeadActivityPointers = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "leadid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "lead",
					Entity2LogicalName = "activitypointer",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lead_addresses</summary>
			public static readonly XrmFakedRelationship LeadAddresses = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "leadid",
					Entity2Attribute = "parentid",
					Entity1LogicalName = "lead",
					Entity2LogicalName = "leadaddress",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N Lead_Annotation</summary>
			public static readonly XrmFakedRelationship LeadAnnotation = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "leadid",
					Entity2Attribute = "objectid",
					Entity1LogicalName = "lead",
					Entity2LogicalName = "annotation",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N Lead_Appointments</summary>
			public static readonly XrmFakedRelationship LeadAppointments = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "leadid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "lead",
					Entity2LogicalName = "appointment",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N Lead_AsyncOperations</summary>
			public static readonly XrmFakedRelationship LeadAsyncOperations = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "leadid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "lead",
					Entity2LogicalName = "asyncoperation",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N Lead_BulkDeleteFailures</summary>
			public static readonly XrmFakedRelationship LeadBulkDeleteFailures = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "leadid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "lead",
					Entity2LogicalName = "bulkdeletefailure",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lead_BulkOperations</summary>
			public static readonly XrmFakedRelationship LeadBulkOperations = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "leadid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "lead",
					Entity2LogicalName = "bulkoperation",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lead_CampaignResponses</summary>
			public static readonly XrmFakedRelationship LeadCampaignResponses = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "leadid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "lead",
					Entity2LogicalName = "campaignresponse",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lead_connections1</summary>
			public static readonly XrmFakedRelationship LeadConnections1 = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "leadid",
					Entity2Attribute = "record1id",
					Entity1LogicalName = "lead",
					Entity2LogicalName = "connection",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lead_connections2</summary>
			public static readonly XrmFakedRelationship LeadConnections2 = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "leadid",
					Entity2Attribute = "record2id",
					Entity1LogicalName = "lead",
					Entity2LogicalName = "connection",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N Lead_DuplicateBaseRecord</summary>
			public static readonly XrmFakedRelationship LeadDuplicateBaseRecord = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "leadid",
					Entity2Attribute = "baserecordid",
					Entity1LogicalName = "lead",
					Entity2LogicalName = "duplicaterecord",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N Lead_DuplicateMatchingRecord</summary>
			public static readonly XrmFakedRelationship LeadDuplicateMatchingRecord = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "leadid",
					Entity2Attribute = "duplicaterecordid",
					Entity1LogicalName = "lead",
					Entity2LogicalName = "duplicaterecord",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N Lead_Email_EmailSender</summary>
			public static readonly XrmFakedRelationship LeadEmailEmailSender = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "leadid",
					Entity2Attribute = "emailsender",
					Entity1LogicalName = "lead",
					Entity2LogicalName = "email",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N Lead_Emails</summary>
			public static readonly XrmFakedRelationship LeadEmails = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "leadid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "lead",
					Entity2LogicalName = "email",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N Lead_Faxes</summary>
			public static readonly XrmFakedRelationship LeadFaxes = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "leadid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "lead",
					Entity2LogicalName = "fax",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lead_IncidentResolutions</summary>
			public static readonly XrmFakedRelationship LeadIncidentResolutions = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "leadid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "lead",
					Entity2LogicalName = "incidentresolution",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N Lead_Letters</summary>
			public static readonly XrmFakedRelationship LeadLetters = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "leadid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "lead",
					Entity2LogicalName = "letter",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N Lead_MailboxTrackingFolder</summary>
			public static readonly XrmFakedRelationship LeadMailboxTrackingFolder = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "leadid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "lead",
					Entity2LogicalName = "mailboxtrackingfolder",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lead_master_lead</summary>
			public static readonly XrmFakedRelationship LeadMasterLead = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "leadid",
					Entity2Attribute = "masterid",
					Entity1LogicalName = "lead",
					Entity2LogicalName = "lead",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lead_OpportunityCloses</summary>
			public static readonly XrmFakedRelationship LeadOpportunityCloses = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "leadid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "lead",
					Entity2LogicalName = "opportunityclose",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lead_OrderCloses</summary>
			public static readonly XrmFakedRelationship LeadOrderCloses = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "leadid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "lead",
					Entity2LogicalName = "orderclose",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N Lead_Phonecalls</summary>
			public static readonly XrmFakedRelationship LeadPhonecalls = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "leadid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "lead",
					Entity2LogicalName = "phonecall",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lead_PostFollows</summary>
			public static readonly XrmFakedRelationship LeadPostFollows = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "leadid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "lead",
					Entity2LogicalName = "postfollow",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lead_principalobjectattributeaccess</summary>
			public static readonly XrmFakedRelationship LeadPrincipalobjectattributeaccess = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "leadid",
					Entity2Attribute = "objectid",
					Entity1LogicalName = "lead",
					Entity2LogicalName = "principalobjectattributeaccess",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N Lead_ProcessSessions</summary>
			public static readonly XrmFakedRelationship LeadProcessSessions = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "leadid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "lead",
					Entity2LogicalName = "processsession",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lead_QuoteCloses</summary>
			public static readonly XrmFakedRelationship LeadQuoteCloses = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "leadid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "lead",
					Entity2LogicalName = "quoteclose",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N Lead_RecurringAppointmentMasters</summary>
			public static readonly XrmFakedRelationship LeadRecurringAppointmentMasters = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "leadid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "lead",
					Entity2LogicalName = "recurringappointmentmaster",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N Lead_ServiceAppointments</summary>
			public static readonly XrmFakedRelationship LeadServiceAppointments = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "leadid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "lead",
					Entity2LogicalName = "serviceappointment",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N Lead_SharepointDocumentLocation</summary>
			public static readonly XrmFakedRelationship LeadSharepointDocumentLocation = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "leadid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "lead",
					Entity2LogicalName = "sharepointdocumentlocation",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N Lead_SocialActivities</summary>
			public static readonly XrmFakedRelationship LeadSocialActivities = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "leadid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "lead",
					Entity2LogicalName = "socialactivity",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N Lead_SyncErrors</summary>
			public static readonly XrmFakedRelationship LeadSyncErrors = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "leadid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "lead",
					Entity2LogicalName = "syncerror",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N Lead_Tasks</summary>
			public static readonly XrmFakedRelationship LeadTasks = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "leadid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "lead",
					Entity2LogicalName = "task",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_leadtoopportunitysalesprocess_leadid</summary>
			public static readonly XrmFakedRelationship LkLeadtoopportunitysalesprocessLeadid = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "leadid",
					Entity2Attribute = "leadid",
					Entity1LogicalName = "lead",
					Entity2LogicalName = "leadtoopportunitysalesprocess",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N msdyn_playbookinstance_lead</summary>
			public static readonly XrmFakedRelationship MsdynPlaybookinstanceLead = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "leadid",
					Entity2Attribute = "regarding",
					Entity1LogicalName = "lead",
					Entity2LogicalName = "msdyn_playbookinstance",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N opportunity_originating_lead</summary>
			public static readonly XrmFakedRelationship OpportunityOriginatingLead = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "leadid",
					Entity2Attribute = "originatingleadid",
					Entity1LogicalName = "lead",
					Entity2LogicalName = "opportunity",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N slakpiinstance_lead</summary>
			public static readonly XrmFakedRelationship SlakpiinstanceLead = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "leadid",
					Entity2Attribute = "regarding",
					Entity1LogicalName = "lead",
					Entity2LogicalName = "slakpiinstance",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>N:N accountleads_association</summary>
			public static readonly XrmFakedRelationship AccountleadsAssociation = 
				new XrmFakedRelationship
				{
					IntersectEntity = "accountleads_association",
					Entity1Attribute = "leadid",
					Entity2Attribute = "accountid",
					Entity1LogicalName = "account",
					Entity2LogicalName = "lead",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.ManyToMany
				};

			/// <summary>N:N BulkOperation_Leads</summary>
			public static readonly XrmFakedRelationship BulkOperationLeads = 
				new XrmFakedRelationship
				{
					IntersectEntity = "BulkOperation_Leads",
					Entity1Attribute = "bulkoperationid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "bulkoperation",
					Entity2LogicalName = "lead",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.ManyToMany
				};

			/// <summary>N:N CampaignActivity_Leads</summary>
			public static readonly XrmFakedRelationship CampaignActivityLeads = 
				new XrmFakedRelationship
				{
					IntersectEntity = "CampaignActivity_Leads",
					Entity1Attribute = "campaignactivityid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "campaignactivity",
					Entity2LogicalName = "lead",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.ManyToMany
				};

			/// <summary>N:N contactleads_association</summary>
			public static readonly XrmFakedRelationship ContactleadsAssociation = 
				new XrmFakedRelationship
				{
					IntersectEntity = "contactleads_association",
					Entity1Attribute = "contactid",
					Entity2Attribute = "leadid",
					Entity1LogicalName = "contact",
					Entity2LogicalName = "lead",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.ManyToMany
				};

			/// <summary>N:N leadcompetitors_association</summary>
			public static readonly XrmFakedRelationship LeadcompetitorsAssociation = 
				new XrmFakedRelationship
				{
					IntersectEntity = "leadcompetitors_association",
					Entity1Attribute = "leadid",
					Entity2Attribute = "competitorid",
					Entity1LogicalName = "lead",
					Entity2LogicalName = "competitor",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.ManyToMany
				};

			/// <summary>N:N leadproduct_association</summary>
			public static readonly XrmFakedRelationship LeadproductAssociation = 
				new XrmFakedRelationship
				{
					IntersectEntity = "leadproduct_association",
					Entity1Attribute = "leadid",
					Entity2Attribute = "productid",
					Entity1LogicalName = "lead",
					Entity2LogicalName = "product",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.ManyToMany
				};

			/// <summary>N:N listlead_association</summary>
			public static readonly XrmFakedRelationship ListleadAssociation = 
				new XrmFakedRelationship
				{
					IntersectEntity = "listlead_association",
					Entity1Attribute = "listid",
					Entity2Attribute = "entityid",
					Entity1LogicalName = "list",
					Entity2LogicalName = "lead",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.ManyToMany
				};

		}
		#endregion

		#region Fake
		public static Lead Create()
		{
			var faker = new Faker<Lead>()
			.RuleFor(e => e.Accountidname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Accountidyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.Address1Id, fake => Guid.NewGuid())
			.RuleFor(e => e.Address1AddressType, fake => fake.PickRandom<Lead.eAddress1AddressType>())
			.RuleFor(e => e.City, fake => fake.Lorem.Word())
			.RuleFor(e => e.Address1, fake => fake.Lorem.Word())
			.RuleFor(e => e.CountryRegion, fake => fake.Lorem.Word())
			.RuleFor(e => e.Address1County, fake => fake.Lorem.Word())
			.RuleFor(e => e.Address1Fax, fake => fake.Lorem.Word())
			.RuleFor(e => e.Address1Latitude, fake => fake.Random.Double())
			.RuleFor(e => e.Street1, fake => fake.Lorem.Word())
			.RuleFor(e => e.Street2, fake => fake.Lorem.Word())
			.RuleFor(e => e.Street3, fake => fake.Lorem.Word())
			.RuleFor(e => e.Address1Longitude, fake => fake.Random.Double())
			.RuleFor(e => e.Address1Name, fake => fake.Lorem.Word())
			.RuleFor(e => e.ZIPPostalCode, fake => fake.Lorem.Word())
			.RuleFor(e => e.Address1PostOfficeBox, fake => fake.Lorem.Word())
			.RuleFor(e => e.Address1ShippingMethod, fake => fake.PickRandom<Lead.eAddress1ShippingMethod>())
			.RuleFor(e => e.StateProvince, fake => fake.Lorem.Word())
			.RuleFor(e => e.Address1Telephone1, fake => fake.Lorem.Word())
			.RuleFor(e => e.Address1Telephone2, fake => fake.Lorem.Word())
			.RuleFor(e => e.Address1Telephone3, fake => fake.Lorem.Word())
			.RuleFor(e => e.Address1UPSZone, fake => fake.Lorem.Word())
			.RuleFor(e => e.Address1UTCOffset, fake => fake.Random.Int())
			.RuleFor(e => e.Address2Id, fake => Guid.NewGuid())
			.RuleFor(e => e.Address2AddressType, fake => fake.PickRandom<Lead.eAddress2AddressType>())
			.RuleFor(e => e.Address2City, fake => fake.Lorem.Word())
			.RuleFor(e => e.Address2, fake => fake.Lorem.Word())
			.RuleFor(e => e.Address2CountryRegion, fake => fake.Lorem.Word())
			.RuleFor(e => e.Address2County, fake => fake.Lorem.Word())
			.RuleFor(e => e.Address2Fax, fake => fake.Lorem.Word())
			.RuleFor(e => e.Address2Latitude, fake => fake.Random.Double())
			.RuleFor(e => e.Address2Street1, fake => fake.Lorem.Word())
			.RuleFor(e => e.Address2Street2, fake => fake.Lorem.Word())
			.RuleFor(e => e.Address2Street3, fake => fake.Lorem.Word())
			.RuleFor(e => e.Address2Longitude, fake => fake.Random.Double())
			.RuleFor(e => e.Address2Name, fake => fake.Lorem.Word())
			.RuleFor(e => e.Address2ZIPPostalCode, fake => fake.Lorem.Word())
			.RuleFor(e => e.Address2PostOfficeBox, fake => fake.Lorem.Word())
			.RuleFor(e => e.Address2ShippingMethod, fake => fake.PickRandom<Lead.eAddress2ShippingMethod>())
			.RuleFor(e => e.Address2StateProvince, fake => fake.Lorem.Word())
			.RuleFor(e => e.Address2Telephone1, fake => fake.Lorem.Word())
			.RuleFor(e => e.Address2Telephone2, fake => fake.Lorem.Word())
			.RuleFor(e => e.Address2Telephone3, fake => fake.Lorem.Word())
			.RuleFor(e => e.Address2UPSZone, fake => fake.Lorem.Word())
			.RuleFor(e => e.Address2UTCOffset, fake => fake.Random.Int())
			.RuleFor(e => e.BudgetAmount, fake => fake.Finance.Amount())
			.RuleFor(e => e.Budget, fake => fake.PickRandom<Lead.egBudget>())
			.RuleFor(e => e.BusinessCard, fake => fake.Lorem.Word())
			.RuleFor(e => e.BusinessCardAttributes, fake => fake.Lorem.Word())
			.RuleFor(e => e.Campaignidname, fake => fake.Lorem.Word())
			.RuleFor(e => e.CompanyName, fake => fake.Lorem.Word())
			.RuleFor(e => e.ConfirmInterest, fake => fake.Random.Bool())
			.RuleFor(e => e.Contactidname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Contactidyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.Createdbyname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Createdbyyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.CreatedOn, fake => fake.Date.Soon())
			.RuleFor(e => e.Createdonbehalfbyname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Createdonbehalfbyyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.Customeridname, fake => fake.Lorem.Word())
			.RuleFor(e => e.CustomerType, fake => fake.Lorem.Word())
			.RuleFor(e => e.Customeridyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.DecisionMaker, fake => fake.Random.Bool())
			.RuleFor(e => e.Description, fake => fake.Lorem.Word())
			.RuleFor(e => e.DoNotAllowBulkEmails, fake => fake.Random.Bool())
			.RuleFor(e => e.DoNotAllowEmails, fake => fake.Random.Bool())
			.RuleFor(e => e.DoNotAllowFaxes, fake => fake.Random.Bool())
			.RuleFor(e => e.DoNotAllowPhoneCalls, fake => fake.Random.Bool())
			.RuleFor(e => e.DoNotAllowMails, fake => fake.Random.Bool())
			.RuleFor(e => e.MarketingMaterial, fake => fake.Random.Bool())
			.RuleFor(e => e.Email, fake => fake.Lorem.Word())
			.RuleFor(e => e.EmailAddress2, fake => fake.Lorem.Word())
			.RuleFor(e => e.EmailAddress3, fake => fake.Lorem.Word())
			.RuleFor(e => e.EntityimageTimestamp, fake => fake.Random.Int())
			.RuleFor(e => e.EntityimageUrl, fake => fake.Lorem.Word())
			.RuleFor(e => e.EntityimageId, fake => Guid.NewGuid())
			.RuleFor(e => e.EstValue, fake => fake.Finance.Amount())
			.RuleFor(e => e.EstCloseDate, fake => fake.Date.Soon())
			.RuleFor(e => e.EstValuedeprecated, fake => fake.Random.Double())
			.RuleFor(e => e.EvaluateFit, fake => fake.Random.Bool())
			.RuleFor(e => e.ExchangeRate, fake => fake.Finance.Amount())
			.RuleFor(e => e.Fax, fake => fake.Lorem.Word())
			.RuleFor(e => e.FirstName, fake => fake.Lorem.Word())
			.RuleFor(e => e.FollowEmailActivity, fake => fake.Random.Bool())
			.RuleFor(e => e.Name, fake => fake.Lorem.Word())
			.RuleFor(e => e.ImportSequenceNumber, fake => fake.Random.Int())
			.RuleFor(e => e.Industry, fake => fake.PickRandom<Lead.eIndustry>())
			.RuleFor(e => e.InitialCommunication, fake => fake.PickRandom<Lead.egInitialCommunication>())
			.RuleFor(e => e.Autocreated, fake => fake.Random.Bool())
			.RuleFor(e => e.IsPrivate, fake => fake.Random.Bool())
			.RuleFor(e => e.JobTitle, fake => fake.Lorem.Word())
			.RuleFor(e => e.LastName, fake => fake.Lorem.Word())
			.RuleFor(e => e.LastOnHoldTime, fake => fake.Date.Soon())
			.RuleFor(e => e.LastCampaignDate, fake => fake.Date.Soon())
			.RuleFor(e => e.Id, fake => Guid.NewGuid())
			.RuleFor(e => e.Rating, fake => fake.PickRandom<Lead.eRating>())
			.RuleFor(e => e.LeadSource, fake => fake.PickRandom<Lead.eLeadSource>())
			.RuleFor(e => e.Masterleadidname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Masterleadidyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.Merged, fake => fake.Random.Bool())
			.RuleFor(e => e.MiddleName, fake => fake.Lorem.Word())
			.RuleFor(e => e.MobilePhone, fake => fake.Lorem.Word())
			.RuleFor(e => e.Modifiedbyname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Modifiedbyyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.ModifiedOn, fake => fake.Date.Soon())
			.RuleFor(e => e.Modifiedonbehalfbyname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Modifiedonbehalfbyyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.GDPROptout, fake => fake.Random.Bool())
			.RuleFor(e => e.Need, fake => fake.PickRandom<Lead.egNeed>())
			.RuleFor(e => e.NoOfEmployees, fake => fake.Random.Int())
			.RuleFor(e => e.OnHoldTimeMinutes, fake => fake.Random.Int())
			.RuleFor(e => e.Originatingcaseidname, fake => fake.Lorem.Word())
			.RuleFor(e => e.RecordCreatedOn, fake => fake.Date.Soon())
			.RuleFor(e => e.Owneridname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Owneridtype, fake => fake.Lorem.Word())
			.RuleFor(e => e.Owneridyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.Pager, fake => fake.Lorem.Word())
			.RuleFor(e => e.Parentaccountidname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Parentaccountidyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.Parentcontactidname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Parentcontactidyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.ParticipatesInWorkflow, fake => fake.Random.Bool())
			.RuleFor(e => e.PreferredMethodOfContact, fake => fake.PickRandom<Lead.ePreferredMethodOfContact>())
			.RuleFor(e => e.Priority, fake => fake.PickRandom<Lead.ePriority>())
			.RuleFor(e => e.ProcessId, fake => Guid.NewGuid())
			.RuleFor(e => e.PurchaseProcess, fake => fake.PickRandom<Lead.egPurchaseProcess>())
			.RuleFor(e => e.PurchaseTimeframe, fake => fake.PickRandom<Lead.egPurchaseTimeframe>())
			.RuleFor(e => e.QualificationComments, fake => fake.Lorem.Word())
			.RuleFor(e => e.Qualifyingopportunityidname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Relatedobjectidname, fake => fake.Lorem.Word())
			.RuleFor(e => e.AnnualRevenue, fake => fake.Finance.Amount())
			.RuleFor(e => e.SalesStage, fake => fake.PickRandom<Lead.egLeadSalesStage>())
			.RuleFor(e => e.SalesStageCode, fake => fake.PickRandom<Lead.eSalesStage>())
			.RuleFor(e => e.Salutation, fake => fake.Lorem.Word())
			.RuleFor(e => e.ScheduleFollowUpProspect, fake => fake.Date.Soon())
			.RuleFor(e => e.ScheduleFollowUpQualify, fake => fake.Date.Soon())
			.RuleFor(e => e.SICCode, fake => fake.Lorem.Word())
			.RuleFor(e => e.Slainvokedidname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Slaname, fake => fake.Lorem.Word())
			.RuleFor(e => e.DeprecatedStageId, fake => Guid.NewGuid())
			.RuleFor(e => e.Status, fake => fake.PickRandom<Lead.eStatus>())
			.RuleFor(e => e.StatusReason, fake => fake.PickRandom<Lead.eStatusReason>())
			.RuleFor(e => e.Topic, fake => fake.Lorem.Word())
			.RuleFor(e => e.TeamsFollowed, fake => fake.Random.Int())
			.RuleFor(e => e.BusinessPhone, fake => fake.Lorem.Word())
			.RuleFor(e => e.HomePhone, fake => fake.Lorem.Word())
			.RuleFor(e => e.OtherPhone, fake => fake.Lorem.Word())
			.RuleFor(e => e.TimeSpentByMe, fake => fake.Lorem.Word())
			.RuleFor(e => e.TimeZoneRuleVersionNumber, fake => fake.Random.Int())
			.RuleFor(e => e.Transactioncurrencyidname, fake => fake.Lorem.Word())
			.RuleFor(e => e.DeprecatedTraversedPath, fake => fake.Lorem.Word())
			.RuleFor(e => e.UTCConversionTimeZoneCode, fake => fake.Random.Int())
			.RuleFor(e => e.VersionNumber, fake => fake.Random.Int())
			.RuleFor(e => e.Website, fake => fake.Lorem.Word())
			.RuleFor(e => e.YomiCompanyName, fake => fake.Lorem.Word())
			.RuleFor(e => e.YomiFirstName, fake => fake.Lorem.Word())
			.RuleFor(e => e.YomiFullName, fake => fake.Lorem.Word())
			.RuleFor(e => e.YomiLastName, fake => fake.Lorem.Word())
			.RuleFor(e => e.YomiMiddleName, fake => fake.Lorem.Word());
			return faker.Generate();
		}
		#endregion
	}
}

