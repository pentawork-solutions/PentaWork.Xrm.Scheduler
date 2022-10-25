using Bogus;
using System;
using FakeXrmEasy;
using System.Collections.Generic;
using PentaWork.Xrm.Scheduler.Proxies.Entities;

namespace PentaWork.Xrm.Scheduler.Tests.Fake
{
	public static class FakeAppConfigMaster
	{	
		#region FakeRelationships
		public static class Relationships 
		{
			/// <summary>1:N appconfigmaster_appconfiginstance</summary>
			public static readonly XrmFakedRelationship AppconfigmasterAppconfiginstance = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "appconfigmasterid",
					Entity2Attribute = "appconfigmasterid",
					Entity1LogicalName = "appconfigmaster",
					Entity2LogicalName = "appconfiginstance",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

		}
		#endregion

		#region Fake
		public static AppConfigMaster Create()
		{
			var faker = new Faker<AppConfigMaster>()
			.RuleFor(e => e.Id, fake => Guid.NewGuid())
			.RuleFor(e => e.ConfigType, fake => fake.Lorem.Word())
			.RuleFor(e => e.Createdbyname, fake => fake.Lorem.Word())
			.RuleFor(e => e.CreatedOn, fake => fake.Date.Soon())
			.RuleFor(e => e.Createdonbehalfbyname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Createdonbehalfbyyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.DefaultValue, fake => fake.Lorem.Word())
			.RuleFor(e => e.ImportSequenceNumber, fake => fake.Random.Int())
			.RuleFor(e => e.IsNagivationSetting, fake => fake.Random.Int())
			.RuleFor(e => e.Modifiedbyname, fake => fake.Lorem.Word())
			.RuleFor(e => e.ModifiedOn, fake => fake.Date.Soon())
			.RuleFor(e => e.Modifiedonbehalfbyname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Modifiedonbehalfbyyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.Name, fake => fake.Lorem.Word())
			.RuleFor(e => e.Organizationidname, fake => fake.Lorem.Word())
			.RuleFor(e => e.RecordCreatedOn, fake => fake.Date.Soon())
			.RuleFor(e => e.EnterTheParentOfAppConfigurationCustomizationProperty, fake => fake.Lorem.Word())
			.RuleFor(e => e.EnterTheValidatorConfigurationXmlWhichWillValidateAgainstItsValueWhenCreatingAppConfigInstance, fake => fake.Lorem.Word())
			.RuleFor(e => e.Versionnumber, fake => fake.Random.Int());
			return faker.Generate();
		}
		#endregion
	}
}

