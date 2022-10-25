using Bogus;
using System;
using FakeXrmEasy;
using System.Collections.Generic;
using PentaWork.Xrm.Scheduler.Proxies.Entities;

namespace PentaWork.Xrm.Scheduler.Tests.Fake
{
	public static class FakeFollow
	{	
		#region FakeRelationships
		public static class Relationships 
		{
			/// <summary>1:N PostFollow_AsyncOperations</summary>
			public static readonly XrmFakedRelationship PostFollowAsyncOperations = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "postfollowid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "postfollow",
					Entity2LogicalName = "asyncoperation",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N PostFollow_SyncErrors</summary>
			public static readonly XrmFakedRelationship PostFollowSyncErrors = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "postfollowid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "postfollow",
					Entity2LogicalName = "syncerror",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

		}
		#endregion

		#region Fake
		public static Follow Create()
		{
			var faker = new Faker<Follow>()
			.RuleFor(e => e.Createdbyname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Createdbyyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.CreatedOn, fake => fake.Date.Soon())
			.RuleFor(e => e.Createdonbehalfbyname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Createdonbehalfbyyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.Owneridname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Owneridtype, fake => fake.Lorem.Word())
			.RuleFor(e => e.Owneridyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.Id, fake => Guid.NewGuid())
			.RuleFor(e => e.InternalUseOnly, fake => fake.Random.Bool())
			.RuleFor(e => e.RegardingEntityName, fake => fake.Lorem.Word())
			.RuleFor(e => e.Regardingobjectidyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.RegardingObjectTypeCode, fake => fake.Lorem.Word())
			.RuleFor(e => e.TimeZoneRuleVersionNumber, fake => fake.Random.Int())
			.RuleFor(e => e.UTCConversionTimeZoneCode, fake => fake.Random.Int())
			.RuleFor(e => e.VersionNumber, fake => fake.Random.Int())
			.RuleFor(e => e.InternalUseOnly2, fake => fake.Random.Int())
			.RuleFor(e => e.InternalUseOnly3, fake => fake.Random.Int());
			return faker.Generate();
		}
		#endregion
	}
}

