using Bogus;
using System;
using FakeXrmEasy;
using System.Collections.Generic;
using PentaWork.Xrm.Scheduler.Proxies.Entities;

namespace PentaWork.Xrm.Scheduler.Tests.Fake
{
	public static class FakeAnnualFiscalCalendar
	{	
		#region FakeRelationships
		public static class Relationships 
		{
			/// <summary>1:N AnnualFiscalCalendar_AsyncOperations</summary>
			public static readonly XrmFakedRelationship AnnualFiscalCalendarAsyncOperations = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "userfiscalcalendarid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "annualfiscalcalendar",
					Entity2LogicalName = "asyncoperation",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N AnnualFiscalCalendar_BulkDeleteFailures</summary>
			public static readonly XrmFakedRelationship AnnualFiscalCalendarBulkDeleteFailures = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "userfiscalcalendarid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "annualfiscalcalendar",
					Entity2LogicalName = "bulkdeletefailure",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

		}
		#endregion

		#region Fake
		public static AnnualFiscalCalendar Create()
		{
			var faker = new Faker<AnnualFiscalCalendar>()
			.RuleFor(e => e.Annual, fake => fake.Finance.Amount())
			.RuleFor(e => e.Businessunitidname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Createdbyname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Createdbyyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.Createdon, fake => fake.Date.Soon())
			.RuleFor(e => e.Createdonbehalfbyname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Createdonbehalfbyyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.Effectiveon, fake => fake.Date.Soon())
			.RuleFor(e => e.ExchangeRate, fake => fake.Finance.Amount())
			.RuleFor(e => e.Fiscalperiodtype, fake => fake.Random.Int())
			.RuleFor(e => e.Modifiedbyname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Modifiedbyyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.Modifiedon, fake => fake.Date.Soon())
			.RuleFor(e => e.Modifiedonbehalfbyname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Modifiedonbehalfbyyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.Salespersonidname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Salespersonidyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.Timezoneruleversionnumber, fake => fake.Random.Int())
			.RuleFor(e => e.Transactioncurrencyidname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Id, fake => Guid.NewGuid())
			.RuleFor(e => e.Utcconversiontimezonecode, fake => fake.Random.Int());
			return faker.Generate();
		}
		#endregion
	}
}

