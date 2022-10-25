using Bogus;
using System;
using FakeXrmEasy;
using System.Collections.Generic;
using PentaWork.Xrm.Scheduler.Proxies.Entities;

namespace PentaWork.Xrm.Scheduler.Tests.Fake
{
	public static class FakeCalendar
	{	
		#region FakeRelationships
		public static class Relationships 
		{
			/// <summary>1:N BusinessUnit_Calendar</summary>
			public static readonly XrmFakedRelationship BusinessUnitCalendar = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "calendarid",
					Entity2Attribute = "calendarid",
					Entity1LogicalName = "calendar",
					Entity2LogicalName = "businessunit",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N Calendar_Annotation</summary>
			public static readonly XrmFakedRelationship CalendarAnnotation = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "calendarid",
					Entity2Attribute = "objectid",
					Entity1LogicalName = "calendar",
					Entity2LogicalName = "annotation",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N Calendar_AsyncOperations</summary>
			public static readonly XrmFakedRelationship CalendarAsyncOperations = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "calendarid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "calendar",
					Entity2LogicalName = "asyncoperation",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N calendar_bookableresources</summary>
			public static readonly XrmFakedRelationship CalendarBookableresources = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "calendarid",
					Entity2Attribute = "calendarid",
					Entity1LogicalName = "calendar",
					Entity2LogicalName = "bookableresource",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N Calendar_BulkDeleteFailures</summary>
			public static readonly XrmFakedRelationship CalendarBulkDeleteFailures = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "calendarid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "calendar",
					Entity2LogicalName = "bulkdeletefailure",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N calendar_customercalendar_holidaycalendar</summary>
			public static readonly XrmFakedRelationship CalendarCustomercalendarHolidaycalendar = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "calendarid",
					Entity2Attribute = "holidayschedulecalendarid",
					Entity1LogicalName = "calendar",
					Entity2LogicalName = "calendar",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N calendar_equipment</summary>
			public static readonly XrmFakedRelationship CalendarEquipment = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "calendarid",
					Entity2Attribute = "calendarid",
					Entity1LogicalName = "calendar",
					Entity2LogicalName = "equipment",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N calendar_organization</summary>
			public static readonly XrmFakedRelationship CalendarOrganization = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "calendarid",
					Entity2Attribute = "businessclosurecalendarid",
					Entity1LogicalName = "calendar",
					Entity2LogicalName = "organization",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N calendar_services</summary>
			public static readonly XrmFakedRelationship CalendarServices = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "calendarid",
					Entity2Attribute = "calendarid",
					Entity1LogicalName = "calendar",
					Entity2LogicalName = "service",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N calendar_slaitem</summary>
			public static readonly XrmFakedRelationship CalendarSlaitem = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "calendarid",
					Entity2Attribute = "businesshoursid",
					Entity1LogicalName = "calendar",
					Entity2LogicalName = "slaitem",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N calendar_system_users</summary>
			public static readonly XrmFakedRelationship CalendarSystemUsers = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "calendarid",
					Entity2Attribute = "calendarid",
					Entity1LogicalName = "calendar",
					Entity2LogicalName = "systemuser",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N slabase_businesshoursid</summary>
			public static readonly XrmFakedRelationship SlabaseBusinesshoursid = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "calendarid",
					Entity2Attribute = "businesshoursid",
					Entity1LogicalName = "calendar",
					Entity2LogicalName = "sla",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

		}
		#endregion

		#region Fake
		public static Calendar Create()
		{
			var faker = new Faker<Calendar>()
			.RuleFor(e => e.Businessunitidname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Id, fake => Guid.NewGuid())
			.RuleFor(e => e.Createdbyname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Createdbyyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.CreatedOn, fake => fake.Date.Soon())
			.RuleFor(e => e.Createdonbehalfbyname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Createdonbehalfbyyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.Description, fake => fake.Lorem.Word())
			.RuleFor(e => e.Holidayschedulecalendaridname, fake => fake.Lorem.Word())
			.RuleFor(e => e.IsShared, fake => fake.Random.Bool())
			.RuleFor(e => e.Modifiedbyname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Modifiedbyyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.ModifiedOn, fake => fake.Date.Soon())
			.RuleFor(e => e.Modifiedonbehalfbyname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Modifiedonbehalfbyyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.Name, fake => fake.Lorem.Word())
			.RuleFor(e => e.Organizationidname, fake => fake.Lorem.Word())
			.RuleFor(e => e.PrimaryUserId, fake => Guid.NewGuid())
			.RuleFor(e => e.CalendarType, fake => fake.PickRandom<Calendar.eCalendarType>())
			.RuleFor(e => e.Versionnumber, fake => fake.Random.Int());
			return faker.Generate();
		}
		#endregion
	}
}

