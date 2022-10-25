using Bogus;
using System;
using FakeXrmEasy;
using System.Collections.Generic;
using PentaWork.Xrm.Scheduler.Proxies.Entities;

namespace PentaWork.Xrm.Scheduler.Tests.Fake
{
	public static class FakeCallbackRegistration
	{	
		#region FakeRelationships
		public static class Relationships 
		{
		}
		#endregion

		#region Fake
		public static CallbackRegistration Create()
		{
			var faker = new Faker<CallbackRegistration>()
			.RuleFor(e => e.Id, fake => Guid.NewGuid())
			.RuleFor(e => e.Createdbyname, fake => fake.Lorem.Word())
			.RuleFor(e => e.CreatedOn, fake => fake.Date.Soon())
			.RuleFor(e => e.Createdonbehalfbyname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Createdonbehalfbyyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.EntityName, fake => fake.Lorem.Word())
			.RuleFor(e => e.FilterExpression, fake => fake.Lorem.Word())
			.RuleFor(e => e.FilteringAttributes, fake => fake.Lorem.Word())
			.RuleFor(e => e.SpecifiesTheMessageType, fake => fake.PickRandom<CallbackRegistration.eMessage>())
			.RuleFor(e => e.Modifiedbyname, fake => fake.Lorem.Word())
			.RuleFor(e => e.ModifiedOn, fake => fake.Date.Soon())
			.RuleFor(e => e.Modifiedonbehalfbyname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Modifiedonbehalfbyyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.Name, fake => fake.Lorem.Word())
			.RuleFor(e => e.Owneridname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Owneridtype, fake => fake.Lorem.Word())
			.RuleFor(e => e.Owningbusinessunitname, fake => fake.Lorem.Word())
			.RuleFor(e => e.PostponeUntil, fake => fake.Lorem.Word())
			.RuleFor(e => e.RunAs, fake => fake.PickRandom<CallbackRegistration.eRunAs>())
			.RuleFor(e => e.SpecifiesTheScopeType, fake => fake.PickRandom<CallbackRegistration.eScope>())
			.RuleFor(e => e.UrlAddress, fake => fake.Lorem.Word())
			.RuleFor(e => e.SpecifiesTheCallbackRegistrationVersionType, fake => fake.PickRandom<CallbackRegistration.eEndpointVersion>());
			return faker.Generate();
		}
		#endregion
	}
}

