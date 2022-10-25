using Bogus;
using System;
using FakeXrmEasy;
using System.Collections.Generic;
using PentaWork.Xrm.Scheduler.Proxies.Entities;

namespace PentaWork.Xrm.Scheduler.Tests.Fake
{
	public static class FakeTimeZoneDefinition
	{	
		#region FakeRelationships
		public static class Relationships 
		{
			/// <summary>1:N lk_timezonelocalizedname_timezonedefinitionid</summary>
			public static readonly XrmFakedRelationship LkTimezonelocalizednameTimezonedefinitionid = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "timezonedefinitionid",
					Entity2Attribute = "timezonedefinitionid",
					Entity1LogicalName = "timezonedefinition",
					Entity2LogicalName = "timezonelocalizedname",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_timezonerule_timezonedefinitionid</summary>
			public static readonly XrmFakedRelationship LkTimezoneruleTimezonedefinitionid = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "timezonedefinitionid",
					Entity2Attribute = "timezonedefinitionid",
					Entity1LogicalName = "timezonedefinition",
					Entity2LogicalName = "timezonerule",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

		}
		#endregion

		#region Fake
		public static TimeZoneDefinition Create()
		{
			var faker = new Faker<TimeZoneDefinition>()
			.RuleFor(e => e.Bias, fake => fake.Random.Int())
			.RuleFor(e => e.CreatedOn, fake => fake.Date.Soon())
			.RuleFor(e => e.Createdonbehalfbyname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Createdonbehalfbyyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.DaylightName, fake => fake.Lorem.Word())
			.RuleFor(e => e.ModifiedOn, fake => fake.Date.Soon())
			.RuleFor(e => e.Modifiedonbehalfbyname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Modifiedonbehalfbyyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.RetiredOrder, fake => fake.Random.Int())
			.RuleFor(e => e.StandardName, fake => fake.Lorem.Word())
			.RuleFor(e => e.TimeZoneCode, fake => fake.Random.Int())
			.RuleFor(e => e.Id, fake => Guid.NewGuid())
			.RuleFor(e => e.UserInterfaceName, fake => fake.Lorem.Word())
			.RuleFor(e => e.Versionnumber, fake => fake.Random.Int());
			return faker.Generate();
		}
		#endregion
	}
}

