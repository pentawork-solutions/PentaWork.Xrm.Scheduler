using Bogus;
using System;
using FakeXrmEasy;
using System.Collections.Generic;
using PentaWork.Xrm.Scheduler.Proxies.Entities;

namespace PentaWork.Xrm.Scheduler.Tests.Fake
{
	public static class FakeSite
	{	
		#region FakeRelationships
		public static class Relationships 
		{
			/// <summary>1:N site_ActivityPointers</summary>
			public static readonly XrmFakedRelationship SiteActivityPointers = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "siteid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "site",
					Entity2LogicalName = "activitypointer",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N site_Appointments</summary>
			public static readonly XrmFakedRelationship SiteAppointments = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "siteid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "site",
					Entity2LogicalName = "appointment",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N Site_AsyncOperations</summary>
			public static readonly XrmFakedRelationship SiteAsyncOperations = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "siteid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "site",
					Entity2LogicalName = "asyncoperation",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N Site_BulkDeleteFailures</summary>
			public static readonly XrmFakedRelationship SiteBulkDeleteFailures = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "siteid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "site",
					Entity2LogicalName = "bulkdeletefailure",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N site_Emails</summary>
			public static readonly XrmFakedRelationship SiteEmails = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "siteid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "site",
					Entity2LogicalName = "email",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N site_equipment</summary>
			public static readonly XrmFakedRelationship SiteEquipment = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "siteid",
					Entity2Attribute = "siteid",
					Entity1LogicalName = "site",
					Entity2LogicalName = "equipment",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N site_Faxes</summary>
			public static readonly XrmFakedRelationship SiteFaxes = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "siteid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "site",
					Entity2LogicalName = "fax",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N site_Letters</summary>
			public static readonly XrmFakedRelationship SiteLetters = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "siteid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "site",
					Entity2LogicalName = "letter",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N site_MailboxTrackingFolders</summary>
			public static readonly XrmFakedRelationship SiteMailboxTrackingFolders = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "siteid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "site",
					Entity2LogicalName = "mailboxtrackingfolder",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N site_OpportunityCloses</summary>
			public static readonly XrmFakedRelationship SiteOpportunityCloses = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "siteid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "site",
					Entity2LogicalName = "opportunityclose",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N site_OrderCloses</summary>
			public static readonly XrmFakedRelationship SiteOrderCloses = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "siteid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "site",
					Entity2LogicalName = "orderclose",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N site_PhoneCalls</summary>
			public static readonly XrmFakedRelationship SitePhoneCalls = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "siteid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "site",
					Entity2LogicalName = "phonecall",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N site_PrincipalObjectAttributeAccesses</summary>
			public static readonly XrmFakedRelationship SitePrincipalObjectAttributeAccesses = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "siteid",
					Entity2Attribute = "objectid",
					Entity1LogicalName = "site",
					Entity2LogicalName = "principalobjectattributeaccess",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N Site_ProcessSessions</summary>
			public static readonly XrmFakedRelationship SiteProcessSessions = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "siteid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "site",
					Entity2LogicalName = "processsession",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N site_QuoteCloses</summary>
			public static readonly XrmFakedRelationship SiteQuoteCloses = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "siteid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "site",
					Entity2LogicalName = "quoteclose",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N site_RecurringAppointmentMasters</summary>
			public static readonly XrmFakedRelationship SiteRecurringAppointmentMasters = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "siteid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "site",
					Entity2LogicalName = "recurringappointmentmaster",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N site_resources</summary>
			public static readonly XrmFakedRelationship SiteResources = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "siteid",
					Entity2Attribute = "siteid",
					Entity1LogicalName = "site",
					Entity2LogicalName = "resource",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N site_service_appointments</summary>
			public static readonly XrmFakedRelationship SiteServiceAppointments = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "siteid",
					Entity2Attribute = "siteid",
					Entity1LogicalName = "site",
					Entity2LogicalName = "serviceappointment",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N site_ServiceAppointments</summary>
			public static readonly XrmFakedRelationship SiteServiceAppointments2 = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "siteid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "site",
					Entity2LogicalName = "serviceappointment",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N site_SocialActivities</summary>
			public static readonly XrmFakedRelationship SiteSocialActivities = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "siteid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "site",
					Entity2LogicalName = "socialactivity",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N Site_SyncErrors</summary>
			public static readonly XrmFakedRelationship SiteSyncErrors = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "siteid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "site",
					Entity2LogicalName = "syncerror",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N site_system_users</summary>
			public static readonly XrmFakedRelationship SiteSystemUsers = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "siteid",
					Entity2Attribute = "siteid",
					Entity1LogicalName = "site",
					Entity2LogicalName = "systemuser",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N site_Tasks</summary>
			public static readonly XrmFakedRelationship SiteTasks = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "siteid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "site",
					Entity2LogicalName = "task",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

		}
		#endregion

		#region Fake
		public static Site Create()
		{
			var faker = new Faker<Site>()
			.RuleFor(e => e.Address1Id, fake => Guid.NewGuid())
			.RuleFor(e => e.Address1AddressType, fake => fake.PickRandom<Site.eAddress1AddressType>())
			.RuleFor(e => e.City, fake => fake.Lorem.Word())
			.RuleFor(e => e.CountryRegion, fake => fake.Lorem.Word())
			.RuleFor(e => e.Address1County, fake => fake.Lorem.Word())
			.RuleFor(e => e.Fax, fake => fake.Lorem.Word())
			.RuleFor(e => e.Address1Latitude, fake => fake.Random.Double())
			.RuleFor(e => e.Street1, fake => fake.Lorem.Word())
			.RuleFor(e => e.Street2, fake => fake.Lorem.Word())
			.RuleFor(e => e.Street3, fake => fake.Lorem.Word())
			.RuleFor(e => e.Address1Longitude, fake => fake.Random.Double())
			.RuleFor(e => e.Address1Name, fake => fake.Lorem.Word())
			.RuleFor(e => e.ZIPPostalCode, fake => fake.Lorem.Word())
			.RuleFor(e => e.Address1PostOfficeBox, fake => fake.Lorem.Word())
			.RuleFor(e => e.Address1ShippingMethod, fake => fake.PickRandom<Site.eAddress1ShippingMethod>())
			.RuleFor(e => e.StateProvince, fake => fake.Lorem.Word())
			.RuleFor(e => e.MainPhone, fake => fake.Lorem.Word())
			.RuleFor(e => e.OtherPhone, fake => fake.Lorem.Word())
			.RuleFor(e => e.Address1Telephone3, fake => fake.Lorem.Word())
			.RuleFor(e => e.Address1UPSZone, fake => fake.Lorem.Word())
			.RuleFor(e => e.Address1UTCOffset, fake => fake.Random.Int())
			.RuleFor(e => e.Address2Id, fake => Guid.NewGuid())
			.RuleFor(e => e.Address2AddressType, fake => fake.PickRandom<Site.eAddress2AddressType>())
			.RuleFor(e => e.Address2City, fake => fake.Lorem.Word())
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
			.RuleFor(e => e.Address2ShippingMethod, fake => fake.PickRandom<Site.eAddress2ShippingMethod>())
			.RuleFor(e => e.Address2StateProvince, fake => fake.Lorem.Word())
			.RuleFor(e => e.Address2Telephone1, fake => fake.Lorem.Word())
			.RuleFor(e => e.Address2Telephone2, fake => fake.Lorem.Word())
			.RuleFor(e => e.Address2Telephone3, fake => fake.Lorem.Word())
			.RuleFor(e => e.Address2UPSZone, fake => fake.Lorem.Word())
			.RuleFor(e => e.Address2UTCOffset, fake => fake.Random.Int())
			.RuleFor(e => e.Createdbyname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Createdbyyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.CreatedOn, fake => fake.Date.Soon())
			.RuleFor(e => e.Createdonbehalfbyname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Createdonbehalfbyyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.Email, fake => fake.Lorem.Word())
			.RuleFor(e => e.ImportSequenceNumber, fake => fake.Random.Int())
			.RuleFor(e => e.Modifiedbyname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Modifiedbyyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.ModifiedOn, fake => fake.Date.Soon())
			.RuleFor(e => e.Modifiedonbehalfbyname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Modifiedonbehalfbyyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.Name, fake => fake.Lorem.Word())
			.RuleFor(e => e.Organizationidname, fake => fake.Lorem.Word())
			.RuleFor(e => e.RecordCreatedOn, fake => fake.Date.Soon())
			.RuleFor(e => e.Id, fake => Guid.NewGuid())
			.RuleFor(e => e.TimeZone, fake => fake.Random.Int())
			.RuleFor(e => e.TimeZoneRuleVersionNumber, fake => fake.Random.Int())
			.RuleFor(e => e.UTCConversionTimeZoneCode, fake => fake.Random.Int())
			.RuleFor(e => e.VersionNumber, fake => fake.Random.Int());
			return faker.Generate();
		}
		#endregion
	}
}

