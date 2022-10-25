using Bogus;
using System;
using FakeXrmEasy;
using System.Collections.Generic;
using PentaWork.Xrm.Scheduler.Proxies.Entities;

namespace PentaWork.Xrm.Scheduler.Tests.Fake
{
	public static class FakeAppConfiguration
	{	
		#region FakeRelationships
		public static class Relationships 
		{
			/// <summary>1:N appconfig_appconfiginstance</summary>
			public static readonly XrmFakedRelationship AppconfigAppconfiginstance = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "appconfigid",
					Entity2Attribute = "appconfigid",
					Entity1LogicalName = "appconfig",
					Entity2LogicalName = "appconfiginstance",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N navigationsetting_appconfig</summary>
			public static readonly XrmFakedRelationship NavigationsettingAppconfig = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "appconfigid",
					Entity2Attribute = "appconfigid",
					Entity1LogicalName = "appconfig",
					Entity2LogicalName = "navigationsetting",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

		}
		#endregion

		#region Fake
		public static AppConfiguration Create()
		{
			var faker = new Faker<AppConfiguration>()
			.RuleFor(e => e.Id, fake => Guid.NewGuid())
			.RuleFor(e => e.AppConfigIDUniqueId, fake => Guid.NewGuid())
			.RuleFor(e => e.Appconfigimportxml, fake => fake.Lorem.Word())
			.RuleFor(e => e.ComponentState, fake => fake.PickRandom<AppConfiguration.egComponentState>())
			.RuleFor(e => e.Createdbyname, fake => fake.Lorem.Word())
			.RuleFor(e => e.CreatedOn, fake => fake.Date.Soon())
			.RuleFor(e => e.Createdonbehalfbyname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Createdonbehalfbyyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.ImportSequenceNumber, fake => fake.Random.Int())
			.RuleFor(e => e.IntroducedVersion, fake => fake.Lorem.Word())
			.RuleFor(e => e.IndicatesWhetherThisIsPartOfAManagedSolution, fake => fake.Random.Bool())
			.RuleFor(e => e.Modifiedbyname, fake => fake.Lorem.Word())
			.RuleFor(e => e.ModifiedOn, fake => fake.Date.Soon())
			.RuleFor(e => e.Modifiedonbehalfbyname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Modifiedonbehalfbyyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.Organizationidname, fake => fake.Lorem.Word())
			.RuleFor(e => e.RecordCreatedOn, fake => fake.Date.Soon())
			.RuleFor(e => e.OverwriteTime, fake => fake.Date.Soon())
			.RuleFor(e => e.SolutionId, fake => Guid.NewGuid())
			.RuleFor(e => e.Status, fake => fake.PickRandom<AppConfiguration.eStatus>())
			.RuleFor(e => e.StatusReason, fake => fake.PickRandom<AppConfiguration.eStatusReason>())
			.RuleFor(e => e.SupportingSolutionId, fake => Guid.NewGuid())
			.RuleFor(e => e.Versionnumber, fake => fake.Random.Int());
			return faker.Generate();
		}
		#endregion
	}
}

