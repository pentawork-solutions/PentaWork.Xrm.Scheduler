using Bogus;
using System;
using FakeXrmEasy;
using System.Collections.Generic;
using PentaWork.Xrm.Scheduler.Proxies.Entities;

namespace PentaWork.Xrm.Scheduler.Tests.Fake
{
	public static class FakeSdkMessageProcessingStepSecureConfiguration
	{	
		#region FakeRelationships
		public static class Relationships 
		{
			/// <summary>1:N sdkmessageprocessingstepsecureconfigid_sdkmessageprocessingstep</summary>
			public static readonly XrmFakedRelationship SdkmessageprocessingstepsecureconfigidSdkmessageprocessingstep = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "sdkmessageprocessingstepsecureconfigid",
					Entity2Attribute = "sdkmessageprocessingstepsecureconfigid",
					Entity1LogicalName = "sdkmessageprocessingstepsecureconfig",
					Entity2LogicalName = "sdkmessageprocessingstep",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

		}
		#endregion

		#region Fake
		public static SdkMessageProcessingStepSecureConfiguration Create()
		{
			var faker = new Faker<SdkMessageProcessingStepSecureConfiguration>()
			.RuleFor(e => e.Createdbyname, fake => fake.Lorem.Word())
			.RuleFor(e => e.CreatedOn, fake => fake.Date.Soon())
			.RuleFor(e => e.Createdonbehalfbyname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Createdonbehalfbyyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.Customizationlevel, fake => fake.Random.Int())
			.RuleFor(e => e.Modifiedbyname, fake => fake.Lorem.Word())
			.RuleFor(e => e.ModifiedOn, fake => fake.Date.Soon())
			.RuleFor(e => e.Modifiedonbehalfbyname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Modifiedonbehalfbyyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.Id, fake => Guid.NewGuid())
			.RuleFor(e => e.SdkmessageprocessingstepsecureconfigiduniqueId, fake => Guid.NewGuid())
			.RuleFor(e => e.SecureConfiguration, fake => fake.Lorem.Word());
			return faker.Generate();
		}
		#endregion
	}
}

