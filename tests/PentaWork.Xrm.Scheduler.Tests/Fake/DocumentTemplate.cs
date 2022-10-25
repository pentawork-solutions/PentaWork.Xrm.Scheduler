using Bogus;
using System;
using FakeXrmEasy;
using System.Collections.Generic;
using PentaWork.Xrm.Scheduler.Proxies.Entities;

namespace PentaWork.Xrm.Scheduler.Tests.Fake
{
	public static class FakeDocumentTemplate
	{	
		#region FakeRelationships
		public static class Relationships 
		{
		}
		#endregion

		#region Fake
		public static DocumentTemplate Create()
		{
			var faker = new Faker<DocumentTemplate>()
			.RuleFor(e => e.AssociatedEntityTypeCode, fake => fake.Lorem.Word())
			.RuleFor(e => e.ClientData, fake => fake.Lorem.Word())
			.RuleFor(e => e.Content, fake => fake.Lorem.Word())
			.RuleFor(e => e.Createdbyname, fake => fake.Lorem.Word())
			.RuleFor(e => e.CreatedOn, fake => fake.Date.Soon())
			.RuleFor(e => e.Createdonbehalfbyname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Createdonbehalfbyyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.Description, fake => fake.Lorem.Word())
			.RuleFor(e => e.Id, fake => Guid.NewGuid())
			.RuleFor(e => e.Type, fake => fake.PickRandom<DocumentTemplate.egDocumentType>())
			.RuleFor(e => e.Language, fake => fake.Random.Int())
			.RuleFor(e => e.Modifiedbyname, fake => fake.Lorem.Word())
			.RuleFor(e => e.ModifiedOn, fake => fake.Date.Soon())
			.RuleFor(e => e.Modifiedonbehalfbyname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Modifiedonbehalfbyyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.Name, fake => fake.Lorem.Word())
			.RuleFor(e => e.Organizationidname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Status, fake => fake.Random.Bool())
			.RuleFor(e => e.Versionnumber, fake => fake.Random.Int());
			return faker.Generate();
		}
		#endregion
	}
}

