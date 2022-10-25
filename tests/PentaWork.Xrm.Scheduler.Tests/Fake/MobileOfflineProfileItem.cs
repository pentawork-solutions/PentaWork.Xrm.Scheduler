using Bogus;
using System;
using FakeXrmEasy;
using System.Collections.Generic;
using PentaWork.Xrm.Scheduler.Proxies.Entities;

namespace PentaWork.Xrm.Scheduler.Tests.Fake
{
	public static class FakeMobileOfflineProfileItem
	{	
		#region FakeRelationships
		public static class Relationships 
		{
			/// <summary>1:N MobileOfflineProfileItem_MobileOfflineProfileItemAssociation</summary>
			public static readonly XrmFakedRelationship MobileOfflineProfileItemMobileOfflineProfileItemAssociation = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "mobileofflineprofileitemid",
					Entity2Attribute = "mobileofflineprofileitemid",
					Entity1LogicalName = "mobileofflineprofileitem",
					Entity2LogicalName = "mobileofflineprofileitemassociation",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

		}
		#endregion

		#region Fake
		public static MobileOfflineProfileItem Create()
		{
			var faker = new Faker<MobileOfflineProfileItem>()
			.RuleFor(e => e.AllowEntityToFollowRelationship, fake => fake.Random.Bool())
			.RuleFor(e => e.ComponentState, fake => fake.PickRandom<MobileOfflineProfileItem.egComponentState>())
			.RuleFor(e => e.Createdbyname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Createdbyyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.CreatedOn, fake => fake.Date.Soon())
			.RuleFor(e => e.Createdonbehalfbyname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Createdonbehalfbyyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.InternalUseOnly, fake => fake.Random.Int())
			.RuleFor(e => e.GetRelatedEntities, fake => fake.Random.Bool())
			.RuleFor(e => e.IntroducedVersion, fake => fake.Lorem.Word())
			.RuleFor(e => e.IsManaged, fake => fake.Random.Bool())
			.RuleFor(e => e.IsValidForMobileOffline, fake => fake.Random.Bool())
			.RuleFor(e => e.IsVisibleInGrid, fake => fake.Random.Bool())
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
			.RuleFor(e => e.ProfileItemEntityFilter, fake => fake.Lorem.Word())
			.RuleFor(e => e.Profileitemrulename, fake => fake.Lorem.Word())
			.RuleFor(e => e.PublishedOn, fake => fake.Date.Soon())
			.RuleFor(e => e.DataDownloadFilter, fake => fake.PickRandom<MobileOfflineProfileItem.eTheRulesForRecordDownloadInOffline>())
			.RuleFor(e => e.DownloadMyRecords, fake => fake.Random.Bool())
			.RuleFor(e => e.DownloadMyBusinessUnitsRecords, fake => fake.Random.Bool())
			.RuleFor(e => e.DownloadMyTeamsRecords, fake => fake.Random.Bool())
			.RuleFor(e => e.Regardingobjectidname, fake => fake.Lorem.Word())
			.RuleFor(e => e.InternalUseOnly2, fake => fake.Lorem.Word())
			.RuleFor(e => e.InternalUseOnly3, fake => fake.Lorem.Word())
			.RuleFor(e => e.Entity, fake => fake.Lorem.Word())
			.RuleFor(e => e.SolutionId, fake => Guid.NewGuid())
			.RuleFor(e => e.DeprecatedProcessStageId, fake => Guid.NewGuid())
			.RuleFor(e => e.SolutionId2, fake => Guid.NewGuid())
			.RuleFor(e => e.DeprecatedTraversedPath, fake => fake.Lorem.Word())
			.RuleFor(e => e.VersionNumber, fake => fake.Random.Int())
			.RuleFor(e => e.ViewQuery, fake => fake.Lorem.Word());
			return faker.Generate();
		}
		#endregion
	}
}

