using Bogus;
using System;
using FakeXrmEasy;
using System.Collections.Generic;
using PentaWork.Xrm.Scheduler.Proxies.Entities;

namespace PentaWork.Xrm.Scheduler.Tests.Fake
{
	public static class FakeNavigationSetting
	{	
		#region FakeRelationships
		public static class Relationships 
		{
		}
		#endregion

		#region Fake
		public static NavigationSetting Create()
		{
			var faker = new Faker<NavigationSetting>()
			.RuleFor(e => e.AdvancedOrder, fake => fake.Random.Int())
			.RuleFor(e => e.AppConfigIdUniqueId, fake => Guid.NewGuid())
			.RuleFor(e => e.ComponentState, fake => fake.PickRandom<NavigationSetting.egComponentState>())
			.RuleFor(e => e.Createdbyname, fake => fake.Lorem.Word())
			.RuleFor(e => e.CreatedOn, fake => fake.Date.Soon())
			.RuleFor(e => e.Createdonbehalfbyname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Createdonbehalfbyyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.Description, fake => fake.Lorem.Word())
			.RuleFor(e => e.GroupName, fake => fake.Lorem.Word())
			.RuleFor(e => e.IconResourceId, fake => Guid.NewGuid())
			.RuleFor(e => e.ImportSequenceNumber, fake => fake.Random.Int())
			.RuleFor(e => e.IntroducedVersion, fake => fake.Lorem.Word())
			.RuleFor(e => e.IsManaged, fake => fake.Random.Bool())
			.RuleFor(e => e.Modifiedbyname, fake => fake.Lorem.Word())
			.RuleFor(e => e.ModifiedOn, fake => fake.Date.Soon())
			.RuleFor(e => e.Modifiedonbehalfbyname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Modifiedonbehalfbyyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.Name, fake => fake.Lorem.Word())
			.RuleFor(e => e.Id, fake => Guid.NewGuid())
			.RuleFor(e => e.NavigationSettingIdUniqueId, fake => Guid.NewGuid())
			.RuleFor(e => e.EntityObjectTypeCode, fake => fake.Random.Int())
			.RuleFor(e => e.Organizationidname, fake => fake.Lorem.Word())
			.RuleFor(e => e.RecordCreatedOn, fake => fake.Date.Soon())
			.RuleFor(e => e.RecordOverwriteTime, fake => fake.Date.Soon())
			.RuleFor(e => e.PageUrl, fake => fake.Lorem.Word())
			.RuleFor(e => e.ParentNavigationSettingId, fake => Guid.NewGuid())
			.RuleFor(e => e.Privileges, fake => fake.Random.Int())
			.RuleFor(e => e.ProgressState, fake => fake.Random.Bool())
			.RuleFor(e => e.QuickOrder, fake => fake.Random.Int())
			.RuleFor(e => e.ResourceId, fake => Guid.NewGuid())
			.RuleFor(e => e.GroupType, fake => fake.PickRandom<NavigationSetting.eNavigationsettingSettingtype>())
			.RuleFor(e => e.SolutionId, fake => Guid.NewGuid())
			.RuleFor(e => e.SolutionId2, fake => Guid.NewGuid());
			return faker.Generate();
		}
		#endregion
	}
}

