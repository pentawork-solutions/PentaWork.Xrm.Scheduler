using Bogus;
using System;
using FakeXrmEasy;
using System.Collections.Generic;
using PentaWork.Xrm.Scheduler.Proxies.Entities;

namespace PentaWork.Xrm.Scheduler.Tests.Fake
{
	public static class FakeMobileOfflineProfileItemAssociation
	{	
		#region FakeRelationships
		public static class Relationships 
		{
		}
		#endregion

		#region Fake
		public static MobileOfflineProfileItemAssociation Create()
		{
			var faker = new Faker<MobileOfflineProfileItemAssociation>()
			.RuleFor(e => e.ComponentState, fake => fake.PickRandom<MobileOfflineProfileItemAssociation.egComponentState>())
			.RuleFor(e => e.Createdbyname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Createdbyyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.CreatedOn, fake => fake.Date.Soon())
			.RuleFor(e => e.Createdonbehalfbyname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Createdonbehalfbyyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.IntroducedVersion, fake => fake.Lorem.Word())
			.RuleFor(e => e.IsManaged, fake => fake.Random.Bool())
			.RuleFor(e => e.IsValidForMobileOffline, fake => fake.Random.Bool())
			.RuleFor(e => e.Id, fake => Guid.NewGuid())
			.RuleFor(e => e.UniqueId, fake => Guid.NewGuid())
			.RuleFor(e => e.Mobileofflineprofileitemidname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Modifiedbyname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Modifiedbyyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.ModifiedOn, fake => fake.Date.Soon())
			.RuleFor(e => e.Modifiedonbehalfbyname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Modifiedonbehalfbyyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.Name, fake => fake.Lorem.Word())
			.RuleFor(e => e.Organizationidname, fake => fake.Lorem.Word())
			.RuleFor(e => e.RecordOverwriteTime, fake => fake.Date.Soon())
			.RuleFor(e => e.ProcessId, fake => Guid.NewGuid())
			.RuleFor(e => e.ProfileItemAssociationEntityFilter, fake => fake.Lorem.Word())
			.RuleFor(e => e.PublishedOn, fake => fake.Date.Soon())
			.RuleFor(e => e.InternalUseOnly, fake => fake.Lorem.Word())
			.RuleFor(e => e.EntityRelationship, fake => fake.Lorem.Word())
			.RuleFor(e => e.ShowsTheRelationshipId, fake => Guid.NewGuid())
			.RuleFor(e => e.EntityRelationship2, fake => fake.Lorem.Word())
			.RuleFor(e => e.EntityRelationship3, fake => fake.PickRandom<MobileOfflineProfileItemAssociation.egSelectedMobileOfflineEnabledEntitiesRelationships>())
			.RuleFor(e => e.SolutionId, fake => Guid.NewGuid())
			.RuleFor(e => e.DeprecatedProcessStageId, fake => Guid.NewGuid())
			.RuleFor(e => e.SolutionId2, fake => Guid.NewGuid())
			.RuleFor(e => e.DeprecatedTraversedPath, fake => fake.Lorem.Word())
			.RuleFor(e => e.VersionNumber, fake => fake.Random.Int());
			return faker.Generate();
		}
		#endregion
	}
}

