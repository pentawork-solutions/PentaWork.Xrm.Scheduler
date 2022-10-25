using Bogus;
using System;
using FakeXrmEasy;
using System.Collections.Generic;
using PentaWork.Xrm.Scheduler.Proxies.Entities;

namespace PentaWork.Xrm.Scheduler.Tests.Fake
{
	public static class FakeMobileOfflineProfile
	{	
		#region FakeRelationships
		public static class Relationships 
		{
			/// <summary>1:N DefaultMobileOfflineProfile_Organization</summary>
			public static readonly XrmFakedRelationship DefaultMobileOfflineProfileOrganization = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "mobileofflineprofileid",
					Entity2Attribute = "defaultmobileofflineprofileid",
					Entity1LogicalName = "mobileofflineprofile",
					Entity2LogicalName = "organization",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N MobileOfflineProfile_MobileOfflineProfileItem</summary>
			public static readonly XrmFakedRelationship MobileOfflineProfileMobileOfflineProfileItem = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "mobileofflineprofileid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "mobileofflineprofile",
					Entity2LogicalName = "mobileofflineprofileitem",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N MobileOfflineProfile_SystemUser</summary>
			public static readonly XrmFakedRelationship MobileOfflineProfileSystemUser = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "mobileofflineprofileid",
					Entity2Attribute = "mobileofflineprofileid",
					Entity1LogicalName = "mobileofflineprofile",
					Entity2LogicalName = "systemuser",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

		}
		#endregion

		#region Fake
		public static MobileOfflineProfile Create()
		{
			var faker = new Faker<MobileOfflineProfile>()
			.RuleFor(e => e.ComponentState, fake => fake.PickRandom<MobileOfflineProfile.egComponentState>())
			.RuleFor(e => e.Createdbyname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Createdbyyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.CreatedOn, fake => fake.Date.Soon())
			.RuleFor(e => e.Createdonbehalfbyname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Createdonbehalfbyyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.Description, fake => fake.Lorem.Word())
			.RuleFor(e => e.IntroducedVersion, fake => fake.Lorem.Word())
			.RuleFor(e => e.IsManaged, fake => fake.Random.Bool())
			.RuleFor(e => e.IsValidated, fake => fake.Random.Bool())
			.RuleFor(e => e.Id, fake => Guid.NewGuid())
			.RuleFor(e => e.UniqueId, fake => Guid.NewGuid())
			.RuleFor(e => e.Modifiedbyname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Modifiedbyyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.ModifiedOn, fake => fake.Date.Soon())
			.RuleFor(e => e.Modifiedonbehalfbyname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Modifiedonbehalfbyyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.Name, fake => fake.Lorem.Word())
			.RuleFor(e => e.Organizationidname, fake => fake.Lorem.Word())
			.RuleFor(e => e.RecordOverwriteTime, fake => fake.Date.Soon())
			.RuleFor(e => e.ProcessId, fake => Guid.NewGuid())
			.RuleFor(e => e.PublishedOn, fake => fake.Date.Soon())
			.RuleFor(e => e.InternalUseOnly, fake => fake.Lorem.Word())
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

