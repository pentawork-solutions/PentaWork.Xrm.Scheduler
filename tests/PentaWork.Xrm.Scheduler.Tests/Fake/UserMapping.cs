using Bogus;
using System;
using FakeXrmEasy;
using System.Collections.Generic;
using PentaWork.Xrm.Scheduler.Proxies.Entities;

namespace PentaWork.Xrm.Scheduler.Tests.Fake
{
	public static class FakeUserMapping
	{	
		#region FakeRelationships
		public static class Relationships 
		{
			/// <summary>1:N usermapping_AsyncOperations</summary>
			public static readonly XrmFakedRelationship UsermappingAsyncOperations = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "usermappingid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "usermapping",
					Entity2LogicalName = "asyncoperation",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N usermapping_BulkDeleteFailures</summary>
			public static readonly XrmFakedRelationship UsermappingBulkDeleteFailures = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "usermappingid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "usermapping",
					Entity2LogicalName = "bulkdeletefailure",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N usermapping_ProcessSession</summary>
			public static readonly XrmFakedRelationship UsermappingProcessSession = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "usermappingid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "usermapping",
					Entity2LogicalName = "processsession",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

		}
		#endregion

		#region Fake
		public static UserMapping Create()
		{
			var faker = new Faker<UserMapping>()
			.RuleFor(e => e.ClaimType, fake => fake.Lorem.Word())
			.RuleFor(e => e.Createdbyname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Createdbyyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.CreatedOn, fake => fake.Date.Soon())
			.RuleFor(e => e.Createdonbehalfbyname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Createdonbehalfbyyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.ExchangeRate, fake => fake.Finance.Amount())
			.RuleFor(e => e.Modifiedbyname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Modifiedbyyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.ModifiedOn, fake => fake.Date.Soon())
			.RuleFor(e => e.Modifiedonbehalfbyname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Modifiedonbehalfbyyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.Organizationidname, fake => fake.Lorem.Word())
			.RuleFor(e => e.ChooseThePartnerApplicationType, fake => fake.PickRandom<UserMapping.eUsermappingPartnerapplicationtype>())
			.RuleFor(e => e.TheSystemUserAttribute, fake => fake.Lorem.Word())
			.RuleFor(e => e.TimeZoneRuleVersionNumber, fake => fake.Random.Int())
			.RuleFor(e => e.Transactioncurrencyidname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Id, fake => Guid.NewGuid())
			.RuleFor(e => e.UTCConversionTimeZoneCode, fake => fake.Random.Int())
			.RuleFor(e => e.Versionnumber, fake => fake.Random.Int());
			return faker.Generate();
		}
		#endregion
	}
}

