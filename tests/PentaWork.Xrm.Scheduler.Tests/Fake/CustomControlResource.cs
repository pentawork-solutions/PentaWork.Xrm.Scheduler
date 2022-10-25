using Bogus;
using System;
using FakeXrmEasy;
using System.Collections.Generic;
using PentaWork.Xrm.Scheduler.Proxies.Entities;

namespace PentaWork.Xrm.Scheduler.Tests.Fake
{
	public static class FakeCustomControlResource
	{	
		#region FakeRelationships
		public static class Relationships 
		{
		}
		#endregion

		#region Fake
		public static CustomControlResource Create()
		{
			var faker = new Faker<CustomControlResource>()
			.RuleFor(e => e.ComponentState, fake => fake.PickRandom<CustomControlResource.egComponentState>())
			.RuleFor(e => e.Createdbyname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Createdbyyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.CreatedOn, fake => fake.Date.Soon())
			.RuleFor(e => e.Createdonbehalfbyname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Createdonbehalfbyyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.CustomControlIdentifierId, fake => Guid.NewGuid())
			.RuleFor(e => e.Id, fake => Guid.NewGuid())
			.RuleFor(e => e.CustomcontrolresourceiduniqueId, fake => Guid.NewGuid())
			.RuleFor(e => e.IntroducedVersion, fake => fake.Lorem.Word())
			.RuleFor(e => e.Ismanaged, fake => fake.Random.Bool())
			.RuleFor(e => e.Modifiedbyname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Modifiedbyyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.ModifiedOn, fake => fake.Date.Soon())
			.RuleFor(e => e.Modifiedonbehalfbyname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Modifiedonbehalfbyyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.Name, fake => fake.Lorem.Word())
			.RuleFor(e => e.Organizationidname, fake => fake.Lorem.Word())
			.RuleFor(e => e.RecordOverwriteTime, fake => fake.Date.Soon())
			.RuleFor(e => e.SolutionId, fake => Guid.NewGuid())
			.RuleFor(e => e.SolutionId2, fake => Guid.NewGuid())
			.RuleFor(e => e.CustomControlResourceVersion, fake => fake.Lorem.Word())
			.RuleFor(e => e.VersionNumber, fake => fake.Random.Int())
			.RuleFor(e => e.CustomControlResourceVersionRequirement, fake => fake.Lorem.Word())
			.RuleFor(e => e.WebResourceId, fake => Guid.NewGuid());
			return faker.Generate();
		}
		#endregion
	}
}

