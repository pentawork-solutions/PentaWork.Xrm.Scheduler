using Bogus;
using System;
using FakeXrmEasy;
using System.Collections.Generic;
using PentaWork.Xrm.Scheduler.Proxies.Entities;

namespace PentaWork.Xrm.Scheduler.Tests.Fake
{
	public static class FakeService
	{	
		#region FakeRelationships
		public static class Relationships 
		{
			/// <summary>1:N service_accounts</summary>
			public static readonly XrmFakedRelationship ServiceAccounts = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "serviceid",
					Entity2Attribute = "preferredserviceid",
					Entity1LogicalName = "service",
					Entity2LogicalName = "account",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N service_activity_pointers</summary>
			public static readonly XrmFakedRelationship ServiceActivityPointers = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "serviceid",
					Entity2Attribute = "serviceid",
					Entity1LogicalName = "service",
					Entity2LogicalName = "activitypointer",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N Service_Annotation</summary>
			public static readonly XrmFakedRelationship ServiceAnnotation = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "serviceid",
					Entity2Attribute = "objectid",
					Entity1LogicalName = "service",
					Entity2LogicalName = "annotation",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N service_appointments</summary>
			public static readonly XrmFakedRelationship ServiceAppointments = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "serviceid",
					Entity2Attribute = "serviceid",
					Entity1LogicalName = "service",
					Entity2LogicalName = "appointment",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N Service_AsyncOperations</summary>
			public static readonly XrmFakedRelationship ServiceAsyncOperations = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "serviceid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "service",
					Entity2LogicalName = "asyncoperation",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N Service_BulkDeleteFailures</summary>
			public static readonly XrmFakedRelationship ServiceBulkDeleteFailures = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "serviceid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "service",
					Entity2LogicalName = "bulkdeletefailure",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N service_contacts</summary>
			public static readonly XrmFakedRelationship ServiceContacts = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "serviceid",
					Entity2Attribute = "preferredserviceid",
					Entity1LogicalName = "service",
					Entity2LogicalName = "contact",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N Service_DuplicateBaseRecord</summary>
			public static readonly XrmFakedRelationship ServiceDuplicateBaseRecord = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "serviceid",
					Entity2Attribute = "baserecordid",
					Entity1LogicalName = "service",
					Entity2LogicalName = "duplicaterecord",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N Service_DuplicateMatchingRecord</summary>
			public static readonly XrmFakedRelationship ServiceDuplicateMatchingRecord = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "serviceid",
					Entity2Attribute = "duplicaterecordid",
					Entity1LogicalName = "service",
					Entity2LogicalName = "duplicaterecord",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N service_emails</summary>
			public static readonly XrmFakedRelationship ServiceEmails = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "serviceid",
					Entity2Attribute = "serviceid",
					Entity1LogicalName = "service",
					Entity2LogicalName = "email",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N service_faxes</summary>
			public static readonly XrmFakedRelationship ServiceFaxes = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "serviceid",
					Entity2Attribute = "serviceid",
					Entity1LogicalName = "service",
					Entity2LogicalName = "fax",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N service_incidentresolutions</summary>
			public static readonly XrmFakedRelationship ServiceIncidentresolutions = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "serviceid",
					Entity2Attribute = "serviceid",
					Entity1LogicalName = "service",
					Entity2LogicalName = "incidentresolution",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N service_letters</summary>
			public static readonly XrmFakedRelationship ServiceLetters = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "serviceid",
					Entity2Attribute = "serviceid",
					Entity1LogicalName = "service",
					Entity2LogicalName = "letter",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N service_MailboxTrackingFolders</summary>
			public static readonly XrmFakedRelationship ServiceMailboxTrackingFolders = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "serviceid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "service",
					Entity2LogicalName = "mailboxtrackingfolder",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N service_opportunityclose</summary>
			public static readonly XrmFakedRelationship ServiceOpportunityclose = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "serviceid",
					Entity2Attribute = "serviceid",
					Entity1LogicalName = "service",
					Entity2LogicalName = "opportunityclose",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N service_orderclose</summary>
			public static readonly XrmFakedRelationship ServiceOrderclose = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "serviceid",
					Entity2Attribute = "serviceid",
					Entity1LogicalName = "service",
					Entity2LogicalName = "orderclose",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N service_phonecalls</summary>
			public static readonly XrmFakedRelationship ServicePhonecalls = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "serviceid",
					Entity2Attribute = "serviceid",
					Entity1LogicalName = "service",
					Entity2LogicalName = "phonecall",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N service_PrincipalObjectAttributeAccesses</summary>
			public static readonly XrmFakedRelationship ServicePrincipalObjectAttributeAccesses = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "serviceid",
					Entity2Attribute = "objectid",
					Entity1LogicalName = "service",
					Entity2LogicalName = "principalobjectattributeaccess",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N Service_ProcessSessions</summary>
			public static readonly XrmFakedRelationship ServiceProcessSessions = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "serviceid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "service",
					Entity2LogicalName = "processsession",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N service_quoteclose</summary>
			public static readonly XrmFakedRelationship ServiceQuoteclose = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "serviceid",
					Entity2Attribute = "serviceid",
					Entity1LogicalName = "service",
					Entity2LogicalName = "quoteclose",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N service_recurringappointmentmasters</summary>
			public static readonly XrmFakedRelationship ServiceRecurringappointmentmasters = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "serviceid",
					Entity2Attribute = "serviceid",
					Entity1LogicalName = "service",
					Entity2LogicalName = "recurringappointmentmaster",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N service_service_appointments</summary>
			public static readonly XrmFakedRelationship ServiceServiceAppointments = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "serviceid",
					Entity2Attribute = "serviceid",
					Entity1LogicalName = "service",
					Entity2LogicalName = "serviceappointment",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N service_socialactivities</summary>
			public static readonly XrmFakedRelationship ServiceSocialactivities = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "serviceid",
					Entity2Attribute = "serviceid",
					Entity1LogicalName = "service",
					Entity2LogicalName = "socialactivity",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N Service_SyncErrors</summary>
			public static readonly XrmFakedRelationship ServiceSyncErrors = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "serviceid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "service",
					Entity2LogicalName = "syncerror",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N service_tasks</summary>
			public static readonly XrmFakedRelationship ServiceTasks = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "serviceid",
					Entity2Attribute = "serviceid",
					Entity1LogicalName = "service",
					Entity2LogicalName = "task",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

		}
		#endregion

		#region Fake
		public static Service Create()
		{
			var faker = new Faker<Service>()
			.RuleFor(e => e.AnchorOffset, fake => fake.Random.Int())
			.RuleFor(e => e.CalendarId, fake => Guid.NewGuid())
			.RuleFor(e => e.Createdbyname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Createdbyyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.CreatedOn, fake => fake.Date.Soon())
			.RuleFor(e => e.Createdonbehalfbyname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Createdonbehalfbyyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.Description, fake => fake.Lorem.Word())
			.RuleFor(e => e.Duration, fake => fake.Random.Int())
			.RuleFor(e => e.Granularity, fake => fake.Lorem.Word())
			.RuleFor(e => e.ImportSequenceNumber, fake => fake.Random.Int())
			.RuleFor(e => e.InitialStatusReason, fake => fake.PickRandom<Service.eInitialStatusReason>())
			.RuleFor(e => e.Status, fake => fake.Random.Bool())
			.RuleFor(e => e.IsVisible, fake => fake.Random.Bool())
			.RuleFor(e => e.Modifiedbyname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Modifiedbyyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.ModifiedOn, fake => fake.Date.Soon())
			.RuleFor(e => e.Modifiedonbehalfbyname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Modifiedonbehalfbyyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.Name, fake => fake.Lorem.Word())
			.RuleFor(e => e.Organizationidname, fake => fake.Lorem.Word())
			.RuleFor(e => e.RecordCreatedOn, fake => fake.Date.Soon())
			.RuleFor(e => e.Resourcespecidname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Id, fake => Guid.NewGuid())
			.RuleFor(e => e.ShowResources, fake => fake.Random.Bool())
			.RuleFor(e => e.TimeZoneRuleVersionNumber, fake => fake.Random.Int())
			.RuleFor(e => e.UTCConversionTimeZoneCode, fake => fake.Random.Int())
			.RuleFor(e => e.VersionNumber, fake => fake.Random.Int());
			return faker.Generate();
		}
		#endregion
	}
}

