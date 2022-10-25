using Bogus;
using System;
using FakeXrmEasy;
using System.Collections.Generic;
using PentaWork.Xrm.Scheduler.Proxies.Entities;

namespace PentaWork.Xrm.Scheduler.Tests.Fake
{
	public static class FakeEntitlement
	{	
		#region FakeRelationships
		public static class Relationships 
		{
			/// <summary>1:N entitlement_ActivityParties</summary>
			public static readonly XrmFakedRelationship EntitlementActivityParties = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "entitlementid",
					Entity2Attribute = "partyid",
					Entity1LogicalName = "entitlement",
					Entity2LogicalName = "activityparty",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N entitlement_ActivityPointers</summary>
			public static readonly XrmFakedRelationship EntitlementActivityPointers = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "entitlementid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "entitlement",
					Entity2LogicalName = "activitypointer",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N entitlement_Annotations</summary>
			public static readonly XrmFakedRelationship EntitlementAnnotations = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "entitlementid",
					Entity2Attribute = "objectid",
					Entity1LogicalName = "entitlement",
					Entity2LogicalName = "annotation",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N entitlement_Appointments</summary>
			public static readonly XrmFakedRelationship EntitlementAppointments = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "entitlementid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "entitlement",
					Entity2LogicalName = "appointment",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N entitlement_AsyncOperations</summary>
			public static readonly XrmFakedRelationship EntitlementAsyncOperations = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "entitlementid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "entitlement",
					Entity2LogicalName = "asyncoperation",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N entitlement_BulkDeleteFailures</summary>
			public static readonly XrmFakedRelationship EntitlementBulkDeleteFailures = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "entitlementid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "entitlement",
					Entity2LogicalName = "bulkdeletefailure",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N entitlement_cases</summary>
			public static readonly XrmFakedRelationship EntitlementCases = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "entitlementid",
					Entity2Attribute = "entitlementid",
					Entity1LogicalName = "entitlement",
					Entity2LogicalName = "incident",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N entitlement_connections1</summary>
			public static readonly XrmFakedRelationship EntitlementConnections1 = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "entitlementid",
					Entity2Attribute = "record1id",
					Entity1LogicalName = "entitlement",
					Entity2LogicalName = "connection",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N entitlement_connections2</summary>
			public static readonly XrmFakedRelationship EntitlementConnections2 = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "entitlementid",
					Entity2Attribute = "record2id",
					Entity1LogicalName = "entitlement",
					Entity2LogicalName = "connection",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N entitlement_DuplicateBaseRecord</summary>
			public static readonly XrmFakedRelationship EntitlementDuplicateBaseRecord = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "entitlementid",
					Entity2Attribute = "baserecordid",
					Entity1LogicalName = "entitlement",
					Entity2LogicalName = "duplicaterecord",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N entitlement_DuplicateMatchingRecord</summary>
			public static readonly XrmFakedRelationship EntitlementDuplicateMatchingRecord = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "entitlementid",
					Entity2Attribute = "duplicaterecordid",
					Entity1LogicalName = "entitlement",
					Entity2LogicalName = "duplicaterecord",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N entitlement_Emails</summary>
			public static readonly XrmFakedRelationship EntitlementEmails = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "entitlementid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "entitlement",
					Entity2LogicalName = "email",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N entitlement_entitlementchannel_EntitlementId</summary>
			public static readonly XrmFakedRelationship EntitlementEntitlementchannelEntitlementId = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "entitlementid",
					Entity2Attribute = "entitlementid",
					Entity1LogicalName = "entitlement",
					Entity2LogicalName = "entitlementchannel",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N entitlement_Faxes</summary>
			public static readonly XrmFakedRelationship EntitlementFaxes = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "entitlementid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "entitlement",
					Entity2LogicalName = "fax",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N entitlement_IncidentResolutions</summary>
			public static readonly XrmFakedRelationship EntitlementIncidentResolutions = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "entitlementid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "entitlement",
					Entity2LogicalName = "incidentresolution",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N entitlement_Letters</summary>
			public static readonly XrmFakedRelationship EntitlementLetters = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "entitlementid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "entitlement",
					Entity2LogicalName = "letter",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N Entitlement_MailboxTrackingFolder</summary>
			public static readonly XrmFakedRelationship EntitlementMailboxTrackingFolder = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "entitlementid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "entitlement",
					Entity2LogicalName = "mailboxtrackingfolder",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N entitlement_OpportunityCloses</summary>
			public static readonly XrmFakedRelationship EntitlementOpportunityCloses = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "entitlementid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "entitlement",
					Entity2LogicalName = "opportunityclose",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N entitlement_OrderCloses</summary>
			public static readonly XrmFakedRelationship EntitlementOrderCloses = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "entitlementid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "entitlement",
					Entity2LogicalName = "orderclose",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N entitlement_PhoneCalls</summary>
			public static readonly XrmFakedRelationship EntitlementPhoneCalls = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "entitlementid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "entitlement",
					Entity2LogicalName = "phonecall",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N entitlement_PrincipalObjectAttributeAccesses</summary>
			public static readonly XrmFakedRelationship EntitlementPrincipalObjectAttributeAccesses = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "entitlementid",
					Entity2Attribute = "objectid",
					Entity1LogicalName = "entitlement",
					Entity2LogicalName = "principalobjectattributeaccess",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N entitlement_ProcessSession</summary>
			public static readonly XrmFakedRelationship EntitlementProcessSession = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "entitlementid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "entitlement",
					Entity2LogicalName = "processsession",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N entitlement_QuoteCloses</summary>
			public static readonly XrmFakedRelationship EntitlementQuoteCloses = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "entitlementid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "entitlement",
					Entity2LogicalName = "quoteclose",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N entitlement_RecurringAppointmentMasters</summary>
			public static readonly XrmFakedRelationship EntitlementRecurringAppointmentMasters = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "entitlementid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "entitlement",
					Entity2LogicalName = "recurringappointmentmaster",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N entitlement_ServiceAppointments</summary>
			public static readonly XrmFakedRelationship EntitlementServiceAppointments = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "entitlementid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "entitlement",
					Entity2LogicalName = "serviceappointment",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N entitlement_SocialActivities</summary>
			public static readonly XrmFakedRelationship EntitlementSocialActivities = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "entitlementid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "entitlement",
					Entity2LogicalName = "socialactivity",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N Entitlement_SyncErrors</summary>
			public static readonly XrmFakedRelationship EntitlementSyncErrors = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "entitlementid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "entitlement",
					Entity2LogicalName = "syncerror",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N entitlement_Tasks</summary>
			public static readonly XrmFakedRelationship EntitlementTasks = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "entitlementid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "entitlement",
					Entity2LogicalName = "task",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>N:N entitlementcontacts_association</summary>
			public static readonly XrmFakedRelationship EntitlementcontactsAssociation = 
				new XrmFakedRelationship
				{
					IntersectEntity = "entitlementcontacts_association",
					Entity1Attribute = "contactid",
					Entity2Attribute = "entitlementid",
					Entity1LogicalName = "contact",
					Entity2LogicalName = "entitlement",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.ManyToMany
				};

			/// <summary>N:N product_entitlement_association</summary>
			public static readonly XrmFakedRelationship ProductEntitlementAssociation = 
				new XrmFakedRelationship
				{
					IntersectEntity = "product_entitlement_association",
					Entity1Attribute = "productid",
					Entity2Attribute = "entitlementid",
					Entity1LogicalName = "product",
					Entity2LogicalName = "entitlement",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.ManyToMany
				};

		}
		#endregion

		#region Fake
		public static Entitlement Create()
		{
			var faker = new Faker<Entitlement>()
			.RuleFor(e => e.Accountidname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Accountidyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.AllocationType, fake => fake.PickRandom<Entitlement.eAllocationType>())
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
			.RuleFor(e => e.DecreaseRemainingOn, fake => fake.PickRandom<Entitlement.eDecreaseRemainingOn>())
			.RuleFor(e => e.Description, fake => fake.Lorem.Word())
			.RuleFor(e => e.EmailAddress, fake => fake.Lorem.Word())
			.RuleFor(e => e.EndDate, fake => fake.Date.Soon())
			.RuleFor(e => e.Id, fake => Guid.NewGuid())
			.RuleFor(e => e.Entitlementtemplateidname, fake => fake.Lorem.Word())
			.RuleFor(e => e.EntityType, fake => fake.PickRandom<Entitlement.egEntityType>())
			.RuleFor(e => e.ExchangeRate, fake => fake.Finance.Amount())
			.RuleFor(e => e.ImportSequenceNumber, fake => fake.Random.Int())
			.RuleFor(e => e.IsDefault, fake => fake.Random.Bool())
			.RuleFor(e => e.KBAccessLevel, fake => fake.PickRandom<Entitlement.eKBAccessLevel>())
			.RuleFor(e => e.Modifiedbyname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Modifiedbyyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.ModifiedOn, fake => fake.Date.Soon())
			.RuleFor(e => e.Modifiedonbehalfbyname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Modifiedonbehalfbyyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.EntitlementName, fake => fake.Lorem.Word())
			.RuleFor(e => e.RecordCreatedOn, fake => fake.Date.Soon())
			.RuleFor(e => e.Owneridname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Owneridtype, fake => fake.Lorem.Word())
			.RuleFor(e => e.Owneridyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.ProcessId, fake => Guid.NewGuid())
			.RuleFor(e => e.RemainingTerms, fake => fake.Finance.Amount())
			.RuleFor(e => e.RestrictBasedOnEntitlementTerms, fake => fake.Random.Bool())
			.RuleFor(e => e.Slaidname, fake => fake.Lorem.Word())
			.RuleFor(e => e.DeprecatedStageId, fake => Guid.NewGuid())
			.RuleFor(e => e.StartDate, fake => fake.Date.Soon())
			.RuleFor(e => e.Status, fake => fake.PickRandom<Entitlement.eStateCode>())
			.RuleFor(e => e.StatusCode, fake => fake.PickRandom<Entitlement.eStatus>())
			.RuleFor(e => e.TimeZoneRuleVersionNumber, fake => fake.Random.Int())
			.RuleFor(e => e.TotalTerms, fake => fake.Finance.Amount())
			.RuleFor(e => e.Transactioncurrencyidname, fake => fake.Lorem.Word())
			.RuleFor(e => e.DeprecatedTraversedPath, fake => fake.Lorem.Word())
			.RuleFor(e => e.UTCConversionTimeZoneCode, fake => fake.Random.Int())
			.RuleFor(e => e.VersionNumber, fake => fake.Random.Int());
			return faker.Generate();
		}
		#endregion
	}
}

