using Bogus;
using System;
using FakeXrmEasy;
using System.Collections.Generic;
using PentaWork.Xrm.Scheduler.Proxies.Entities;

namespace PentaWork.Xrm.Scheduler.Tests.Fake
{
	public static class FakeRecurrenceRule
	{	
		#region FakeRelationships
		public static class Relationships 
		{
			/// <summary>1:N recurrencerule_recurringappointmentmaster</summary>
			public static readonly XrmFakedRelationship RecurrenceruleRecurringappointmentmaster = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "ruleid",
					Entity2Attribute = "activityid",
					Entity1LogicalName = "recurrencerule",
					Entity2LogicalName = "recurringappointmentmaster",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

		}
		#endregion

		#region Fake
		public static RecurrenceRule Create()
		{
			var faker = new Faker<RecurrenceRule>()
			.RuleFor(e => e.Createdbyname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Createdbyyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.CreatedOn, fake => fake.Date.Soon())
			.RuleFor(e => e.Createdonbehalfbyname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Createdonbehalfbyyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.DayOfMonth, fake => fake.Random.Int())
			.RuleFor(e => e.DaysOfWeekMask, fake => fake.Random.Int())
			.RuleFor(e => e.Duration, fake => fake.Random.Int())
			.RuleFor(e => e.EffectiveEndDate, fake => fake.Date.Soon())
			.RuleFor(e => e.EffectiveStartDate, fake => fake.Date.Soon())
			.RuleFor(e => e.EndTime, fake => fake.Date.Soon())
			.RuleFor(e => e.FirstDayOfWeek, fake => fake.Random.Int())
			.RuleFor(e => e.Instance, fake => fake.PickRandom<RecurrenceRule.eInstance>())
			.RuleFor(e => e.Interval, fake => fake.Random.Int())
			.RuleFor(e => e.NthMonthly, fake => fake.Random.Bool())
			.RuleFor(e => e.NthYearly, fake => fake.Random.Bool())
			.RuleFor(e => e.Regenerate, fake => fake.Random.Bool())
			.RuleFor(e => e.EveryWeekday, fake => fake.Random.Bool())
			.RuleFor(e => e.Modifiedbyname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Modifiedbyyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.ModifiedOn, fake => fake.Date.Soon())
			.RuleFor(e => e.Modifiedonbehalfbyname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Modifiedonbehalfbyyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.MonthOfYear, fake => fake.PickRandom<RecurrenceRule.egMonthOfYear>())
			.RuleFor(e => e.ObjectType, fake => fake.Lorem.Word())
			.RuleFor(e => e.Occurrences, fake => fake.Random.Int())
			.RuleFor(e => e.Owneridname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Owneridtype, fake => fake.Lorem.Word())
			.RuleFor(e => e.Owneridyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.RecurrenceRangeEnd, fake => fake.Date.Soon())
			.RuleFor(e => e.PatternEndType, fake => fake.PickRandom<RecurrenceRule.ePatternEndType>())
			.RuleFor(e => e.RecurrenceRangeStart, fake => fake.Date.Soon())
			.RuleFor(e => e.RecurrencePattern, fake => fake.PickRandom<RecurrenceRule.eRecurrencePattern>())
			.RuleFor(e => e.Id, fake => Guid.NewGuid())
			.RuleFor(e => e.StartTime, fake => fake.Date.Soon())
			.RuleFor(e => e.Versionnumber, fake => fake.Random.Int());
			return faker.Generate();
		}
		#endregion
	}
}

