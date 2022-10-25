using Bogus;
using System;
using FakeXrmEasy;
using System.Collections.Generic;
using PentaWork.Xrm.Scheduler.Proxies.Entities;

namespace PentaWork.Xrm.Scheduler.Tests.Fake
{
	public static class FakeProcessStage
	{	
		#region FakeRelationships
		public static class Relationships 
		{
			/// <summary>1:N lk_expiredprocess_activestageid</summary>
			public static readonly XrmFakedRelationship LkExpiredprocessActivestageid = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "processstageid",
					Entity2Attribute = "activestageid",
					Entity1LogicalName = "processstage",
					Entity2LogicalName = "expiredprocess",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_leadtoopportunitysalesprocess_activestageid</summary>
			public static readonly XrmFakedRelationship LkLeadtoopportunitysalesprocessActivestageid = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "processstageid",
					Entity2Attribute = "activestageid",
					Entity1LogicalName = "processstage",
					Entity2LogicalName = "leadtoopportunitysalesprocess",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_newprocess_activestageid</summary>
			public static readonly XrmFakedRelationship LkNewprocessActivestageid = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "processstageid",
					Entity2Attribute = "activestageid",
					Entity1LogicalName = "processstage",
					Entity2LogicalName = "newprocess",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_opportunitysalesprocess_activestageid</summary>
			public static readonly XrmFakedRelationship LkOpportunitysalesprocessActivestageid = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "processstageid",
					Entity2Attribute = "activestageid",
					Entity1LogicalName = "processstage",
					Entity2LogicalName = "opportunitysalesprocess",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_phonetocaseprocess_activestageid</summary>
			public static readonly XrmFakedRelationship LkPhonetocaseprocessActivestageid = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "processstageid",
					Entity2Attribute = "activestageid",
					Entity1LogicalName = "processstage",
					Entity2LogicalName = "phonetocaseprocess",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_translationprocess_activestageid</summary>
			public static readonly XrmFakedRelationship LkTranslationprocessActivestageid = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "processstageid",
					Entity2Attribute = "activestageid",
					Entity1LogicalName = "processstage",
					Entity2LogicalName = "translationprocess",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N processstage_account</summary>
			public static readonly XrmFakedRelationship ProcessstageAccount = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "processstageid",
					Entity2Attribute = "stageid",
					Entity1LogicalName = "processstage",
					Entity2LogicalName = "account",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N processstage_appointments</summary>
			public static readonly XrmFakedRelationship ProcessstageAppointments = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "processstageid",
					Entity2Attribute = "stageid",
					Entity1LogicalName = "processstage",
					Entity2LogicalName = "appointment",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N processstage_BookableResource</summary>
			public static readonly XrmFakedRelationship ProcessstageBookableResource = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "processstageid",
					Entity2Attribute = "stageid",
					Entity1LogicalName = "processstage",
					Entity2LogicalName = "bookableresource",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N processstage_BookableResourceBooking</summary>
			public static readonly XrmFakedRelationship ProcessstageBookableResourceBooking = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "processstageid",
					Entity2Attribute = "stageid",
					Entity1LogicalName = "processstage",
					Entity2LogicalName = "bookableresourcebooking",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N processstage_BookableResourceBookingHeader</summary>
			public static readonly XrmFakedRelationship ProcessstageBookableResourceBookingHeader = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "processstageid",
					Entity2Attribute = "stageid",
					Entity1LogicalName = "processstage",
					Entity2LogicalName = "bookableresourcebookingheader",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N processstage_BookableResourceCharacteristic</summary>
			public static readonly XrmFakedRelationship ProcessstageBookableResourceCharacteristic = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "processstageid",
					Entity2Attribute = "stageid",
					Entity1LogicalName = "processstage",
					Entity2LogicalName = "bookableresourcecharacteristic",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N processstage_campaignactivities</summary>
			public static readonly XrmFakedRelationship ProcessstageCampaignactivities = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "processstageid",
					Entity2Attribute = "stageid",
					Entity1LogicalName = "processstage",
					Entity2LogicalName = "campaignactivity",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N processstage_campaignresponses</summary>
			public static readonly XrmFakedRelationship ProcessstageCampaignresponses = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "processstageid",
					Entity2Attribute = "stageid",
					Entity1LogicalName = "processstage",
					Entity2LogicalName = "campaignresponse",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N processstage_campaigns</summary>
			public static readonly XrmFakedRelationship ProcessstageCampaigns = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "processstageid",
					Entity2Attribute = "stageid",
					Entity1LogicalName = "processstage",
					Entity2LogicalName = "campaign",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N processstage_competitors</summary>
			public static readonly XrmFakedRelationship ProcessstageCompetitors = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "processstageid",
					Entity2Attribute = "stageid",
					Entity1LogicalName = "processstage",
					Entity2LogicalName = "competitor",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N processstage_contact</summary>
			public static readonly XrmFakedRelationship ProcessstageContact = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "processstageid",
					Entity2Attribute = "stageid",
					Entity1LogicalName = "processstage",
					Entity2LogicalName = "contact",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N processstage_emails</summary>
			public static readonly XrmFakedRelationship ProcessstageEmails = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "processstageid",
					Entity2Attribute = "stageid",
					Entity1LogicalName = "processstage",
					Entity2LogicalName = "email",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N processstage_Entitlement</summary>
			public static readonly XrmFakedRelationship ProcessstageEntitlement = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "processstageid",
					Entity2Attribute = "stageid",
					Entity1LogicalName = "processstage",
					Entity2LogicalName = "entitlement",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N processstage_faxes</summary>
			public static readonly XrmFakedRelationship ProcessstageFaxes = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "processstageid",
					Entity2Attribute = "stageid",
					Entity1LogicalName = "processstage",
					Entity2LogicalName = "fax",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N processstage_incident</summary>
			public static readonly XrmFakedRelationship ProcessstageIncident = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "processstageid",
					Entity2Attribute = "stageid",
					Entity1LogicalName = "processstage",
					Entity2LogicalName = "incident",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N processstage_invoices</summary>
			public static readonly XrmFakedRelationship ProcessstageInvoices = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "processstageid",
					Entity2Attribute = "stageid",
					Entity1LogicalName = "processstage",
					Entity2LogicalName = "invoice",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N processstage_knowledgearticle</summary>
			public static readonly XrmFakedRelationship ProcessstageKnowledgearticle = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "processstageid",
					Entity2Attribute = "stageid",
					Entity1LogicalName = "processstage",
					Entity2LogicalName = "knowledgearticle",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N processstage_lead</summary>
			public static readonly XrmFakedRelationship ProcessstageLead = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "processstageid",
					Entity2Attribute = "stageid",
					Entity1LogicalName = "processstage",
					Entity2LogicalName = "lead",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N processstage_letters</summary>
			public static readonly XrmFakedRelationship ProcessstageLetters = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "processstageid",
					Entity2Attribute = "stageid",
					Entity1LogicalName = "processstage",
					Entity2LogicalName = "letter",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N processstage_lists</summary>
			public static readonly XrmFakedRelationship ProcessstageLists = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "processstageid",
					Entity2Attribute = "stageid",
					Entity1LogicalName = "processstage",
					Entity2LogicalName = "list",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N processstage_opportunity</summary>
			public static readonly XrmFakedRelationship ProcessstageOpportunity = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "processstageid",
					Entity2Attribute = "stageid",
					Entity1LogicalName = "processstage",
					Entity2LogicalName = "opportunity",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N processstage_phonecalls</summary>
			public static readonly XrmFakedRelationship ProcessstagePhonecalls = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "processstageid",
					Entity2Attribute = "stageid",
					Entity1LogicalName = "processstage",
					Entity2LogicalName = "phonecall",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N processstage_processstageparameter</summary>
			public static readonly XrmFakedRelationship ProcessstageProcessstageparameter = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "processstageid",
					Entity2Attribute = "processstageid",
					Entity1LogicalName = "processstage",
					Entity2LogicalName = "processstageparameter",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N processstage_productpricelevels</summary>
			public static readonly XrmFakedRelationship ProcessstageProductpricelevels = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "processstageid",
					Entity2Attribute = "stageid",
					Entity1LogicalName = "processstage",
					Entity2LogicalName = "productpricelevel",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N processstage_products</summary>
			public static readonly XrmFakedRelationship ProcessstageProducts = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "processstageid",
					Entity2Attribute = "stageid",
					Entity1LogicalName = "processstage",
					Entity2LogicalName = "product",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N processstage_quotes</summary>
			public static readonly XrmFakedRelationship ProcessstageQuotes = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "processstageid",
					Entity2Attribute = "stageid",
					Entity1LogicalName = "processstage",
					Entity2LogicalName = "quote",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N processstage_recurringappointmentmasters</summary>
			public static readonly XrmFakedRelationship ProcessstageRecurringappointmentmasters = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "processstageid",
					Entity2Attribute = "stageid",
					Entity1LogicalName = "processstage",
					Entity2LogicalName = "recurringappointmentmaster",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N processstage_salesliteratures</summary>
			public static readonly XrmFakedRelationship ProcessstageSalesliteratures = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "processstageid",
					Entity2Attribute = "stageid",
					Entity1LogicalName = "processstage",
					Entity2LogicalName = "salesliterature",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N processstage_salesorders</summary>
			public static readonly XrmFakedRelationship ProcessstageSalesorders = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "processstageid",
					Entity2Attribute = "stageid",
					Entity1LogicalName = "processstage",
					Entity2LogicalName = "salesorder",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N ProcessStage_SyncErrors</summary>
			public static readonly XrmFakedRelationship ProcessStageSyncErrors = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "processstageid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "processstage",
					Entity2LogicalName = "syncerror",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N processstage_systemusers</summary>
			public static readonly XrmFakedRelationship ProcessstageSystemusers = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "processstageid",
					Entity2Attribute = "stageid",
					Entity1LogicalName = "processstage",
					Entity2LogicalName = "systemuser",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N processstage_tasks</summary>
			public static readonly XrmFakedRelationship ProcessstageTasks = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "processstageid",
					Entity2Attribute = "stageid",
					Entity1LogicalName = "processstage",
					Entity2LogicalName = "task",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N processstage_teams</summary>
			public static readonly XrmFakedRelationship ProcessstageTeams = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "processstageid",
					Entity2Attribute = "stageid",
					Entity1LogicalName = "processstage",
					Entity2LogicalName = "team",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

		}
		#endregion

		#region Fake
		public static ProcessStage Create()
		{
			var faker = new Faker<ProcessStage>()
			.RuleFor(e => e.ClientData, fake => fake.Lorem.Word())
			.RuleFor(e => e.Connector, fake => fake.Lorem.Word())
			.RuleFor(e => e.IsTrigger, fake => fake.Random.Bool())
			.RuleFor(e => e.OperationId, fake => fake.Lorem.Word())
			.RuleFor(e => e.OperationKind, fake => fake.PickRandom<ProcessStage.eOperationKind>())
			.RuleFor(e => e.OperationType, fake => fake.PickRandom<ProcessStage.eOperationType>())
			.RuleFor(e => e.Owneridtype, fake => fake.Lorem.Word())
			.RuleFor(e => e.OwningBusinessUnitId, fake => Guid.NewGuid())
			.RuleFor(e => e.PrimaryEntity, fake => fake.Lorem.Word())
			.RuleFor(e => e.Processidname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Id, fake => Guid.NewGuid())
			.RuleFor(e => e.StageCategory, fake => fake.PickRandom<ProcessStage.egStageCategory>())
			.RuleFor(e => e.ProcessStageName, fake => fake.Lorem.Word())
			.RuleFor(e => e.VersionNumber, fake => fake.Random.Int());
			return faker.Generate();
		}
		#endregion
	}
}

