using Bogus;
using System;
using FakeXrmEasy;
using System.Collections.Generic;
using PentaWork.Xrm.Scheduler.Proxies.Entities;

namespace PentaWork.Xrm.Scheduler.Tests.Fake
{
	public static class FakeEntitlementTemplate
	{	
		#region FakeRelationships
		public static class Relationships 
		{
			/// <summary>1:N entitlementtemplate_ActivityPointers</summary>
			public static readonly XrmFakedRelationship EntitlementtemplateActivityPointers = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "entitlementtemplateid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "entitlementtemplate",
					Entity2LogicalName = "activitypointer",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N entitlementtemplate_Annotations</summary>
			public static readonly XrmFakedRelationship EntitlementtemplateAnnotations = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "entitlementtemplateid",
					Entity2Attribute = "objectid",
					Entity1LogicalName = "entitlementtemplate",
					Entity2LogicalName = "annotation",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N entitlementtemplate_Appointments</summary>
			public static readonly XrmFakedRelationship EntitlementtemplateAppointments = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "entitlementtemplateid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "entitlementtemplate",
					Entity2LogicalName = "appointment",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N entitlementtemplate_AsyncOperations</summary>
			public static readonly XrmFakedRelationship EntitlementtemplateAsyncOperations = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "entitlementtemplateid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "entitlementtemplate",
					Entity2LogicalName = "asyncoperation",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N entitlementtemplate_BulkDeleteFailures</summary>
			public static readonly XrmFakedRelationship EntitlementtemplateBulkDeleteFailures = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "entitlementtemplateid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "entitlementtemplate",
					Entity2LogicalName = "bulkdeletefailure",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N entitlementtemplate_DuplicateBaseRecord</summary>
			public static readonly XrmFakedRelationship EntitlementtemplateDuplicateBaseRecord = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "entitlementtemplateid",
					Entity2Attribute = "baserecordid",
					Entity1LogicalName = "entitlementtemplate",
					Entity2LogicalName = "duplicaterecord",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N entitlementtemplate_DuplicateMatchingRecord</summary>
			public static readonly XrmFakedRelationship EntitlementtemplateDuplicateMatchingRecord = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "entitlementtemplateid",
					Entity2Attribute = "duplicaterecordid",
					Entity1LogicalName = "entitlementtemplate",
					Entity2LogicalName = "duplicaterecord",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N entitlementtemplate_Emails</summary>
			public static readonly XrmFakedRelationship EntitlementtemplateEmails = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "entitlementtemplateid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "entitlementtemplate",
					Entity2LogicalName = "email",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N entitlementtemplate_entitlementchannel_entitlementtemplateid</summary>
			public static readonly XrmFakedRelationship EntitlementtemplateEntitlementchannelEntitlementtemplateid = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "entitlementtemplateid",
					Entity2Attribute = "entitlementtemplateid",
					Entity1LogicalName = "entitlementtemplate",
					Entity2LogicalName = "entitlementtemplatechannel",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N entitlementtemplate_Faxes</summary>
			public static readonly XrmFakedRelationship EntitlementtemplateFaxes = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "entitlementtemplateid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "entitlementtemplate",
					Entity2LogicalName = "fax",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N entitlementtemplate_IncidentResolutions</summary>
			public static readonly XrmFakedRelationship EntitlementtemplateIncidentResolutions = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "entitlementtemplateid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "entitlementtemplate",
					Entity2LogicalName = "incidentresolution",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N entitlementtemplate_Letters</summary>
			public static readonly XrmFakedRelationship EntitlementtemplateLetters = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "entitlementtemplateid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "entitlementtemplate",
					Entity2LogicalName = "letter",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N EntitlementTemplate_MailboxTrackingFolder</summary>
			public static readonly XrmFakedRelationship EntitlementTemplateMailboxTrackingFolder = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "entitlementtemplateid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "entitlementtemplate",
					Entity2LogicalName = "mailboxtrackingfolder",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N entitlementtemplate_OpportunityCloses</summary>
			public static readonly XrmFakedRelationship EntitlementtemplateOpportunityCloses = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "entitlementtemplateid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "entitlementtemplate",
					Entity2LogicalName = "opportunityclose",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N entitlementtemplate_OrderCloses</summary>
			public static readonly XrmFakedRelationship EntitlementtemplateOrderCloses = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "entitlementtemplateid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "entitlementtemplate",
					Entity2LogicalName = "orderclose",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N entitlementtemplate_PhoneCalls</summary>
			public static readonly XrmFakedRelationship EntitlementtemplatePhoneCalls = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "entitlementtemplateid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "entitlementtemplate",
					Entity2LogicalName = "phonecall",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N entitlementtemplate_PrincipalObjectAttributeAccesses</summary>
			public static readonly XrmFakedRelationship EntitlementtemplatePrincipalObjectAttributeAccesses = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "entitlementtemplateid",
					Entity2Attribute = "objectid",
					Entity1LogicalName = "entitlementtemplate",
					Entity2LogicalName = "principalobjectattributeaccess",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N entitlementtemplate_ProcessSession</summary>
			public static readonly XrmFakedRelationship EntitlementtemplateProcessSession = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "entitlementtemplateid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "entitlementtemplate",
					Entity2LogicalName = "processsession",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N entitlementtemplate_QuoteCloses</summary>
			public static readonly XrmFakedRelationship EntitlementtemplateQuoteCloses = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "entitlementtemplateid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "entitlementtemplate",
					Entity2LogicalName = "quoteclose",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N entitlementtemplate_RecurringAppointmentMasters</summary>
			public static readonly XrmFakedRelationship EntitlementtemplateRecurringAppointmentMasters = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "entitlementtemplateid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "entitlementtemplate",
					Entity2LogicalName = "recurringappointmentmaster",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N entitlementtemplate_ServiceAppointments</summary>
			public static readonly XrmFakedRelationship EntitlementtemplateServiceAppointments = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "entitlementtemplateid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "entitlementtemplate",
					Entity2LogicalName = "serviceappointment",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N entitlementtemplate_SocialActivities</summary>
			public static readonly XrmFakedRelationship EntitlementtemplateSocialActivities = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "entitlementtemplateid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "entitlementtemplate",
					Entity2LogicalName = "socialactivity",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N EntitlementTemplate_SyncErrors</summary>
			public static readonly XrmFakedRelationship EntitlementTemplateSyncErrors = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "entitlementtemplateid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "entitlementtemplate",
					Entity2LogicalName = "syncerror",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N entitlementtemplate_Tasks</summary>
			public static readonly XrmFakedRelationship EntitlementtemplateTasks = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "entitlementtemplateid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "entitlementtemplate",
					Entity2LogicalName = "task",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N entitlementtemplateid_RelationShip</summary>
			public static readonly XrmFakedRelationship EntitlementtemplateidRelationShip = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "entitlementtemplateid",
					Entity2Attribute = "entitlementtemplateid",
					Entity1LogicalName = "entitlementtemplate",
					Entity2LogicalName = "entitlement",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>N:N product_entitlementtemplate_association</summary>
			public static readonly XrmFakedRelationship ProductEntitlementtemplateAssociation = 
				new XrmFakedRelationship
				{
					IntersectEntity = "product_entitlementtemplate_association",
					Entity1Attribute = "productid",
					Entity2Attribute = "entitlementtemplateid",
					Entity1LogicalName = "product",
					Entity2LogicalName = "entitlementtemplate",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.ManyToMany
				};

		}
		#endregion

		#region Fake
		public static EntitlementTemplate Create()
		{
			var faker = new Faker<EntitlementTemplate>()
			.RuleFor(e => e.AllocationType, fake => fake.PickRandom<EntitlementTemplate.eAllocationType>())
			.RuleFor(e => e.Createdbyname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Createdbyyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.CreatedOn, fake => fake.Date.Soon())
			.RuleFor(e => e.Createdonbehalfbyname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Createdonbehalfbyyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.DecreaseRemainingOn, fake => fake.PickRandom<EntitlementTemplate.eDecreaseRemainingOn>())
			.RuleFor(e => e.Description, fake => fake.Lorem.Word())
			.RuleFor(e => e.EndDate, fake => fake.Date.Soon())
			.RuleFor(e => e.Id, fake => Guid.NewGuid())
			.RuleFor(e => e.EntityType, fake => fake.PickRandom<EntitlementTemplate.egEntityType>())
			.RuleFor(e => e.ExchangeRate, fake => fake.Finance.Amount())
			.RuleFor(e => e.ImportSequenceNumber, fake => fake.Random.Int())
			.RuleFor(e => e.KBAccessLevel, fake => fake.PickRandom<EntitlementTemplate.eKBAccessLevel>())
			.RuleFor(e => e.Modifiedbyname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Modifiedbyyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.ModifiedOn, fake => fake.Date.Soon())
			.RuleFor(e => e.Modifiedonbehalfbyname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Modifiedonbehalfbyyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.EntitlementTemplateName, fake => fake.Lorem.Word())
			.RuleFor(e => e.Organizationidname, fake => fake.Lorem.Word())
			.RuleFor(e => e.RecordCreatedOn, fake => fake.Date.Soon())
			.RuleFor(e => e.RestrictByEntitlementTerms, fake => fake.Random.Bool())
			.RuleFor(e => e.Slaidname, fake => fake.Lorem.Word())
			.RuleFor(e => e.StartDate, fake => fake.Date.Soon())
			.RuleFor(e => e.TimeZoneRuleVersionNumber, fake => fake.Random.Int())
			.RuleFor(e => e.TotalTerms, fake => fake.Finance.Amount())
			.RuleFor(e => e.Transactioncurrencyidname, fake => fake.Lorem.Word())
			.RuleFor(e => e.UTCConversionTimeZoneCode, fake => fake.Random.Int())
			.RuleFor(e => e.VersionNumber, fake => fake.Random.Int());
			return faker.Generate();
		}
		#endregion
	}
}

