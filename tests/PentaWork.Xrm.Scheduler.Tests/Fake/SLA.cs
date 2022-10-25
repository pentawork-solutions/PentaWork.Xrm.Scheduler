using Bogus;
using System;
using FakeXrmEasy;
using System.Collections.Generic;
using PentaWork.Xrm.Scheduler.Proxies.Entities;

namespace PentaWork.Xrm.Scheduler.Tests.Fake
{
	public static class FakeSLA
	{	
		#region FakeRelationships
		public static class Relationships 
		{
			/// <summary>1:N bulkoperation_sla_slaid</summary>
			public static readonly XrmFakedRelationship BulkoperationSlaSlaid = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "slaid",
					Entity2Attribute = "slaid",
					Entity1LogicalName = "sla",
					Entity2LogicalName = "bulkoperation",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N bulkoperation_sla_slainvokedid</summary>
			public static readonly XrmFakedRelationship BulkoperationSlaSlainvokedid = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "slaid",
					Entity2Attribute = "slainvokedid",
					Entity1LogicalName = "sla",
					Entity2LogicalName = "bulkoperation",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N campaignactivity_sla_slaid</summary>
			public static readonly XrmFakedRelationship CampaignactivitySlaSlaid = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "slaid",
					Entity2Attribute = "slaid",
					Entity1LogicalName = "sla",
					Entity2LogicalName = "campaignactivity",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N campaignactivity_sla_slainvokedid</summary>
			public static readonly XrmFakedRelationship CampaignactivitySlaSlainvokedid = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "slaid",
					Entity2Attribute = "slainvokedid",
					Entity1LogicalName = "sla",
					Entity2LogicalName = "campaignactivity",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N campaignresponse_sla_slaid</summary>
			public static readonly XrmFakedRelationship CampaignresponseSlaSlaid = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "slaid",
					Entity2Attribute = "slaid",
					Entity1LogicalName = "sla",
					Entity2LogicalName = "campaignresponse",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N campaignresponse_sla_slainvokedid</summary>
			public static readonly XrmFakedRelationship CampaignresponseSlaSlainvokedid = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "slaid",
					Entity2Attribute = "slainvokedid",
					Entity1LogicalName = "sla",
					Entity2LogicalName = "campaignresponse",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N incidentresolution_sla_slaid</summary>
			public static readonly XrmFakedRelationship IncidentresolutionSlaSlaid = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "slaid",
					Entity2Attribute = "slaid",
					Entity1LogicalName = "sla",
					Entity2LogicalName = "incidentresolution",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N incidentresolution_sla_slainvokedid</summary>
			public static readonly XrmFakedRelationship IncidentresolutionSlaSlainvokedid = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "slaid",
					Entity2Attribute = "slainvokedid",
					Entity1LogicalName = "sla",
					Entity2LogicalName = "incidentresolution",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N manualsla_account</summary>
			public static readonly XrmFakedRelationship ManualslaAccount = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "slaid",
					Entity2Attribute = "slaid",
					Entity1LogicalName = "sla",
					Entity2LogicalName = "account",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N manualsla_activitypointer</summary>
			public static readonly XrmFakedRelationship ManualslaActivitypointer = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "slaid",
					Entity2Attribute = "slaid",
					Entity1LogicalName = "sla",
					Entity2LogicalName = "activitypointer",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N manualsla_appointment</summary>
			public static readonly XrmFakedRelationship ManualslaAppointment = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "slaid",
					Entity2Attribute = "slaid",
					Entity1LogicalName = "sla",
					Entity2LogicalName = "appointment",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N manualsla_cases</summary>
			public static readonly XrmFakedRelationship ManualslaCases = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "slaid",
					Entity2Attribute = "slaid",
					Entity1LogicalName = "sla",
					Entity2LogicalName = "incident",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N manualsla_contact</summary>
			public static readonly XrmFakedRelationship ManualslaContact = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "slaid",
					Entity2Attribute = "slaid",
					Entity1LogicalName = "sla",
					Entity2LogicalName = "contact",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N manualsla_email</summary>
			public static readonly XrmFakedRelationship ManualslaEmail = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "slaid",
					Entity2Attribute = "slaid",
					Entity1LogicalName = "sla",
					Entity2LogicalName = "email",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N manualsla_fax</summary>
			public static readonly XrmFakedRelationship ManualslaFax = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "slaid",
					Entity2Attribute = "slaid",
					Entity1LogicalName = "sla",
					Entity2LogicalName = "fax",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N manualsla_invoice</summary>
			public static readonly XrmFakedRelationship ManualslaInvoice = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "slaid",
					Entity2Attribute = "slaid",
					Entity1LogicalName = "sla",
					Entity2LogicalName = "invoice",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N manualsla_lead</summary>
			public static readonly XrmFakedRelationship ManualslaLead = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "slaid",
					Entity2Attribute = "slaid",
					Entity1LogicalName = "sla",
					Entity2LogicalName = "lead",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N manualsla_letter</summary>
			public static readonly XrmFakedRelationship ManualslaLetter = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "slaid",
					Entity2Attribute = "slaid",
					Entity1LogicalName = "sla",
					Entity2LogicalName = "letter",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N manualsla_opportunity</summary>
			public static readonly XrmFakedRelationship ManualslaOpportunity = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "slaid",
					Entity2Attribute = "slaid",
					Entity1LogicalName = "sla",
					Entity2LogicalName = "opportunity",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N manualsla_phonecall</summary>
			public static readonly XrmFakedRelationship ManualslaPhonecall = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "slaid",
					Entity2Attribute = "slaid",
					Entity1LogicalName = "sla",
					Entity2LogicalName = "phonecall",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N manualsla_quote</summary>
			public static readonly XrmFakedRelationship ManualslaQuote = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "slaid",
					Entity2Attribute = "slaid",
					Entity1LogicalName = "sla",
					Entity2LogicalName = "quote",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N manualsla_salesorder</summary>
			public static readonly XrmFakedRelationship ManualslaSalesorder = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "slaid",
					Entity2Attribute = "slaid",
					Entity1LogicalName = "sla",
					Entity2LogicalName = "salesorder",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N manualsla_serviceappointment</summary>
			public static readonly XrmFakedRelationship ManualslaServiceappointment = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "slaid",
					Entity2Attribute = "slaid",
					Entity1LogicalName = "sla",
					Entity2LogicalName = "serviceappointment",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N manualsla_socialactivity</summary>
			public static readonly XrmFakedRelationship ManualslaSocialactivity = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "slaid",
					Entity2Attribute = "slaid",
					Entity1LogicalName = "sla",
					Entity2LogicalName = "socialactivity",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N manualsla_task</summary>
			public static readonly XrmFakedRelationship ManualslaTask = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "slaid",
					Entity2Attribute = "slaid",
					Entity1LogicalName = "sla",
					Entity2LogicalName = "task",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N opportunityclose_sla_slaid</summary>
			public static readonly XrmFakedRelationship OpportunitycloseSlaSlaid = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "slaid",
					Entity2Attribute = "slaid",
					Entity1LogicalName = "sla",
					Entity2LogicalName = "opportunityclose",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N opportunityclose_sla_slainvokedid</summary>
			public static readonly XrmFakedRelationship OpportunitycloseSlaSlainvokedid = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "slaid",
					Entity2Attribute = "slainvokedid",
					Entity1LogicalName = "sla",
					Entity2LogicalName = "opportunityclose",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N orderclose_sla_slaid</summary>
			public static readonly XrmFakedRelationship OrdercloseSlaSlaid = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "slaid",
					Entity2Attribute = "slaid",
					Entity1LogicalName = "sla",
					Entity2LogicalName = "orderclose",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N orderclose_sla_slainvokedid</summary>
			public static readonly XrmFakedRelationship OrdercloseSlaSlainvokedid = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "slaid",
					Entity2Attribute = "slainvokedid",
					Entity1LogicalName = "sla",
					Entity2LogicalName = "orderclose",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N quoteclose_sla_slaid</summary>
			public static readonly XrmFakedRelationship QuotecloseSlaSlaid = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "slaid",
					Entity2Attribute = "slaid",
					Entity1LogicalName = "sla",
					Entity2LogicalName = "quoteclose",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N quoteclose_sla_slainvokedid</summary>
			public static readonly XrmFakedRelationship QuotecloseSlaSlainvokedid = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "slaid",
					Entity2Attribute = "slainvokedid",
					Entity1LogicalName = "sla",
					Entity2LogicalName = "quoteclose",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N sla_account</summary>
			public static readonly XrmFakedRelationship SlaAccount = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "slaid",
					Entity2Attribute = "slainvokedid",
					Entity1LogicalName = "sla",
					Entity2LogicalName = "account",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N sla_activitypointer</summary>
			public static readonly XrmFakedRelationship SlaActivitypointer = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "slaid",
					Entity2Attribute = "slainvokedid",
					Entity1LogicalName = "sla",
					Entity2LogicalName = "activitypointer",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N sla_Annotation</summary>
			public static readonly XrmFakedRelationship SlaAnnotation = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "slaid",
					Entity2Attribute = "objectid",
					Entity1LogicalName = "sla",
					Entity2LogicalName = "annotation",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N sla_appointment</summary>
			public static readonly XrmFakedRelationship SlaAppointment = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "slaid",
					Entity2Attribute = "slainvokedid",
					Entity1LogicalName = "sla",
					Entity2LogicalName = "appointment",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N sla_cases</summary>
			public static readonly XrmFakedRelationship SlaCases = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "slaid",
					Entity2Attribute = "slainvokedid",
					Entity1LogicalName = "sla",
					Entity2LogicalName = "incident",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N sla_contact</summary>
			public static readonly XrmFakedRelationship SlaContact = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "slaid",
					Entity2Attribute = "slainvokedid",
					Entity1LogicalName = "sla",
					Entity2LogicalName = "contact",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N sla_email</summary>
			public static readonly XrmFakedRelationship SlaEmail = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "slaid",
					Entity2Attribute = "slainvokedid",
					Entity1LogicalName = "sla",
					Entity2LogicalName = "email",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N sla_entitlement</summary>
			public static readonly XrmFakedRelationship SlaEntitlement = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "slaid",
					Entity2Attribute = "slaid",
					Entity1LogicalName = "sla",
					Entity2LogicalName = "entitlement",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N sla_entitlementtemplate</summary>
			public static readonly XrmFakedRelationship SlaEntitlementtemplate = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "slaid",
					Entity2Attribute = "slaid",
					Entity1LogicalName = "sla",
					Entity2LogicalName = "entitlementtemplate",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N sla_fax</summary>
			public static readonly XrmFakedRelationship SlaFax = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "slaid",
					Entity2Attribute = "slainvokedid",
					Entity1LogicalName = "sla",
					Entity2LogicalName = "fax",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N sla_invoice</summary>
			public static readonly XrmFakedRelationship SlaInvoice = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "slaid",
					Entity2Attribute = "slainvokedid",
					Entity1LogicalName = "sla",
					Entity2LogicalName = "invoice",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N sla_lead</summary>
			public static readonly XrmFakedRelationship SlaLead = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "slaid",
					Entity2Attribute = "slainvokedid",
					Entity1LogicalName = "sla",
					Entity2LogicalName = "lead",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N sla_letter</summary>
			public static readonly XrmFakedRelationship SlaLetter = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "slaid",
					Entity2Attribute = "slainvokedid",
					Entity1LogicalName = "sla",
					Entity2LogicalName = "letter",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N sla_opportunity</summary>
			public static readonly XrmFakedRelationship SlaOpportunity = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "slaid",
					Entity2Attribute = "slainvokedid",
					Entity1LogicalName = "sla",
					Entity2LogicalName = "opportunity",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N sla_phonecall</summary>
			public static readonly XrmFakedRelationship SlaPhonecall = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "slaid",
					Entity2Attribute = "slainvokedid",
					Entity1LogicalName = "sla",
					Entity2LogicalName = "phonecall",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N sla_quote</summary>
			public static readonly XrmFakedRelationship SlaQuote = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "slaid",
					Entity2Attribute = "slainvokedid",
					Entity1LogicalName = "sla",
					Entity2LogicalName = "quote",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N sla_salesorder</summary>
			public static readonly XrmFakedRelationship SlaSalesorder = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "slaid",
					Entity2Attribute = "slainvokedid",
					Entity1LogicalName = "sla",
					Entity2LogicalName = "salesorder",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N sla_serviceappointment</summary>
			public static readonly XrmFakedRelationship SlaServiceappointment = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "slaid",
					Entity2Attribute = "slainvokedid",
					Entity1LogicalName = "sla",
					Entity2LogicalName = "serviceappointment",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N sla_slaitem_slaId</summary>
			public static readonly XrmFakedRelationship SlaSlaitemSlaId = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "slaid",
					Entity2Attribute = "slaid",
					Entity1LogicalName = "sla",
					Entity2LogicalName = "slaitem",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N sla_socialactivity</summary>
			public static readonly XrmFakedRelationship SlaSocialactivity = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "slaid",
					Entity2Attribute = "slainvokedid",
					Entity1LogicalName = "sla",
					Entity2LogicalName = "socialactivity",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N SLA_SyncErrors</summary>
			public static readonly XrmFakedRelationship SLASyncErrors = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "slaid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "sla",
					Entity2LogicalName = "syncerror",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N sla_task</summary>
			public static readonly XrmFakedRelationship SlaTask = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "slaid",
					Entity2Attribute = "slainvokedid",
					Entity1LogicalName = "sla",
					Entity2LogicalName = "task",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N slabase_AsyncOperations</summary>
			public static readonly XrmFakedRelationship SlabaseAsyncOperations = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "slaid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "sla",
					Entity2LogicalName = "asyncoperation",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N slabase_BulkDeleteFailures</summary>
			public static readonly XrmFakedRelationship SlabaseBulkDeleteFailures = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "slaid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "sla",
					Entity2LogicalName = "bulkdeletefailure",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N slabase_ProcessSessions</summary>
			public static readonly XrmFakedRelationship SlabaseProcessSessions = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "slaid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "sla",
					Entity2LogicalName = "processsession",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

		}
		#endregion

		#region Fake
		public static SLA Create()
		{
			var faker = new Faker<SLA>()
			.RuleFor(e => e.AllowPauseAndResume, fake => fake.Random.Bool())
			.RuleFor(e => e.ApplicableFrom, fake => fake.Lorem.Word())
			.RuleFor(e => e.ApplicableFrom2, fake => fake.PickRandom<SLA.eDateAttributesOfCase>())
			.RuleFor(e => e.Businesshoursidname, fake => fake.Lorem.Word())
			.RuleFor(e => e.ChangedAttributeList, fake => fake.Lorem.Word())
			.RuleFor(e => e.ComponentState, fake => fake.PickRandom<SLA.egComponentState>())
			.RuleFor(e => e.Createdbyname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Createdbyyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.CreatedOn, fake => fake.Date.Soon())
			.RuleFor(e => e.Createdonbehalfbyname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Createdonbehalfbyyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.Description, fake => fake.Lorem.Word())
			.RuleFor(e => e.ExchangeRate, fake => fake.Finance.Amount())
			.RuleFor(e => e.IsDefault, fake => fake.Random.Bool())
			.RuleFor(e => e.IsManaged, fake => fake.Random.Bool())
			.RuleFor(e => e.Modifiedbyname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Modifiedbyyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.ModifiedOn, fake => fake.Date.Soon())
			.RuleFor(e => e.Modifiedonbehalfbyname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Modifiedonbehalfbyyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.Name, fake => fake.Lorem.Word())
			.RuleFor(e => e.ObjectTypeCode, fake => fake.PickRandom<SLA.eObjectTypeCode>())
			.RuleFor(e => e.RecordOverwriteTime, fake => fake.Date.Soon())
			.RuleFor(e => e.Owneridname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Owneridtype, fake => fake.Lorem.Word())
			.RuleFor(e => e.Owneridyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.PrimaryEntity, fake => fake.Random.Int())
			.RuleFor(e => e.Id, fake => Guid.NewGuid())
			.RuleFor(e => e.UniqueId, fake => Guid.NewGuid())
			.RuleFor(e => e.SLAType, fake => fake.PickRandom<SLA.eSLAType>())
			.RuleFor(e => e.RecordVersion, fake => fake.PickRandom<SLA.eRecordVersion>())
			.RuleFor(e => e.SolutionId, fake => Guid.NewGuid())
			.RuleFor(e => e.Status, fake => fake.PickRandom<SLA.eState>())
			.RuleFor(e => e.StatusReason, fake => fake.PickRandom<SLA.eStatusOfSLA>())
			.RuleFor(e => e.SolutionId2, fake => Guid.NewGuid())
			.RuleFor(e => e.Transactioncurrencyidname, fake => fake.Lorem.Word())
			.RuleFor(e => e.VersionNumber, fake => fake.Random.Int())
			.RuleFor(e => e.Workflowidname, fake => fake.Lorem.Word());
			return faker.Generate();
		}
		#endregion
	}
}

