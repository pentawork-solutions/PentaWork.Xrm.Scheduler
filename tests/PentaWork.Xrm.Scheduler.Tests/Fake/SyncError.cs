using Bogus;
using System;
using FakeXrmEasy;
using System.Collections.Generic;
using PentaWork.Xrm.Scheduler.Proxies.Entities;

namespace PentaWork.Xrm.Scheduler.Tests.Fake
{
	public static class FakeSyncError
	{	
		#region FakeRelationships
		public static class Relationships 
		{
			/// <summary>1:N SyncError_SyncErrors</summary>
			public static readonly XrmFakedRelationship SyncErrorSyncErrors = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "syncerrorid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "syncerror",
					Entity2LogicalName = "syncerror",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

		}
		#endregion

		#region Fake
		public static SyncError Create()
		{
			var faker = new Faker<SyncError>()
			.RuleFor(e => e.Action, fake => fake.Lorem.Word())
			.RuleFor(e => e.ActionData, fake => fake.Lorem.Word())
			.RuleFor(e => e.Createdbyname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Createdbyyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.CreatedOn, fake => fake.Date.Soon())
			.RuleFor(e => e.Createdonbehalfbyname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Createdonbehalfbyyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.Description, fake => fake.Lorem.Word())
			.RuleFor(e => e.ErrorCode, fake => fake.Lorem.Word())
			.RuleFor(e => e.ErrorDetail, fake => fake.Lorem.Word())
			.RuleFor(e => e.ErrorMessage, fake => fake.Lorem.Word())
			.RuleFor(e => e.ErrorTime, fake => fake.Date.Soon())
			.RuleFor(e => e.ErrorType, fake => fake.PickRandom<SyncError.eErrorType>())
			.RuleFor(e => e.Modifiedbyname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Modifiedbyyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.ModifiedOn, fake => fake.Date.Soon())
			.RuleFor(e => e.Modifiedonbehalfbyname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Modifiedonbehalfbyyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.Entity, fake => fake.Lorem.Word())
			.RuleFor(e => e.Owneridname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Owneridtype, fake => fake.Lorem.Word())
			.RuleFor(e => e.Owneridyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.Regardingobjectidname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Regardingobjectidyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.Regardingobjecttypecode, fake => fake.Lorem.Word())
			.RuleFor(e => e.RequestData, fake => fake.Lorem.Word())
			.RuleFor(e => e.State, fake => fake.PickRandom<SyncError.eStatus>())
			.RuleFor(e => e.StatusReason, fake => fake.PickRandom<SyncError.eStatusReason>())
			.RuleFor(e => e.Id, fake => Guid.NewGuid())
			.RuleFor(e => e.VersionNumber, fake => fake.Random.Int());
			return faker.Generate();
		}
		#endregion
	}
}

