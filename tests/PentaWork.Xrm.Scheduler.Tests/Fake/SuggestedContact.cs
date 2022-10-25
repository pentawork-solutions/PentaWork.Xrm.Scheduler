using Bogus;
using System;
using FakeXrmEasy;
using System.Collections.Generic;
using PentaWork.Xrm.Scheduler.Proxies.Entities;

namespace PentaWork.Xrm.Scheduler.Tests.Fake
{
	public static class FakeSuggestedContact
	{	
		#region FakeRelationships
		public static class Relationships 
		{
		}
		#endregion

		#region Fake
		public static SuggestedContact Create()
		{
			var faker = new Faker<SuggestedContact>()
			.RuleFor(e => e.AccountName2, fake => fake.Lorem.Word())
			.RuleFor(e => e.AccountName3, fake => fake.Lorem.Word())
			.RuleFor(e => e.AddressCity, fake => fake.Lorem.Word())
			.RuleFor(e => e.AddressLine1, fake => fake.Lorem.Word())
			.RuleFor(e => e.AddressLine2, fake => fake.Lorem.Word())
			.RuleFor(e => e.AddressPostalCode, fake => fake.Lorem.Word())
			.RuleFor(e => e.CompanyName, fake => fake.Lorem.Word())
			.RuleFor(e => e.Date, fake => fake.Date.Soon())
			.RuleFor(e => e.Description, fake => fake.Lorem.Word())
			.RuleFor(e => e.Email, fake => fake.Lorem.Word())
			.RuleFor(e => e.FirstName, fake => fake.Lorem.Word())
			.RuleFor(e => e.FullName, fake => fake.Lorem.Word())
			.RuleFor(e => e.JobTitle, fake => fake.Lorem.Word())
			.RuleFor(e => e.LastName, fake => fake.Lorem.Word())
			.RuleFor(e => e.MobilePhone, fake => fake.Lorem.Word())
			.RuleFor(e => e.PreferredContactMethodCode, fake => fake.Lorem.Word())
			.RuleFor(e => e.Id, fake => Guid.NewGuid())
			.RuleFor(e => e.Telephone, fake => fake.Lorem.Word());
			return faker.Generate();
		}
		#endregion
	}
}

