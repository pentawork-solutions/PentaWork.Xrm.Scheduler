using Bogus;
using System;
using FakeXrmEasy;
using System.Collections.Generic;
using PentaWork.Xrm.Scheduler.Proxies.Entities;

namespace PentaWork.Xrm.Scheduler.Tests.Fake
{
	public static class FakePosition
	{	
		#region FakeRelationships
		public static class Relationships 
		{
			/// <summary>1:N position_AsyncOperations</summary>
			public static readonly XrmFakedRelationship PositionAsyncOperations = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "positionid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "position",
					Entity2LogicalName = "asyncoperation",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N position_connection1</summary>
			public static readonly XrmFakedRelationship PositionConnection1 = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "positionid",
					Entity2Attribute = "record1id",
					Entity1LogicalName = "position",
					Entity2LogicalName = "connection",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N position_connection2</summary>
			public static readonly XrmFakedRelationship PositionConnection2 = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "positionid",
					Entity2Attribute = "record2id",
					Entity1LogicalName = "position",
					Entity2LogicalName = "connection",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N position_parent_position</summary>
			public static readonly XrmFakedRelationship PositionParentPosition = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "positionid",
					Entity2Attribute = "parentpositionid",
					Entity1LogicalName = "position",
					Entity2LogicalName = "position",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N position_principalobjectattributeaccess</summary>
			public static readonly XrmFakedRelationship PositionPrincipalobjectattributeaccess = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "positionid",
					Entity2Attribute = "objectid",
					Entity1LogicalName = "position",
					Entity2LogicalName = "principalobjectattributeaccess",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N position_ProcessSession</summary>
			public static readonly XrmFakedRelationship PositionProcessSession = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "positionid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "position",
					Entity2LogicalName = "processsession",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N Position_SyncErrors</summary>
			public static readonly XrmFakedRelationship PositionSyncErrors = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "positionid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "position",
					Entity2LogicalName = "syncerror",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N position_users</summary>
			public static readonly XrmFakedRelationship PositionUsers = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "positionid",
					Entity2Attribute = "positionid",
					Entity1LogicalName = "position",
					Entity2LogicalName = "systemuser",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

		}
		#endregion

		#region Fake
		public static Position Create()
		{
			var faker = new Faker<Position>()
			.RuleFor(e => e.Createdbyname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Createdbyyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.CreatedOn, fake => fake.Date.Soon())
			.RuleFor(e => e.Createdonbehalfbyname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Createdonbehalfbyyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.Description, fake => fake.Lorem.Word())
			.RuleFor(e => e.ExchangeRate, fake => fake.Finance.Amount())
			.RuleFor(e => e.ImportSequenceNumber, fake => fake.Random.Int())
			.RuleFor(e => e.Modifiedbyname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Modifiedbyyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.ModifiedOn, fake => fake.Date.Soon())
			.RuleFor(e => e.Modifiedonbehalfbyname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Modifiedonbehalfbyyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.Name, fake => fake.Lorem.Word())
			.RuleFor(e => e.Organizationidname, fake => fake.Lorem.Word())
			.RuleFor(e => e.RecordCreatedOn, fake => fake.Date.Soon())
			.RuleFor(e => e.Parentpositionidname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Id, fake => Guid.NewGuid())
			.RuleFor(e => e.Status, fake => fake.PickRandom<Position.eStatus>())
			.RuleFor(e => e.StatusReason, fake => fake.PickRandom<Position.eStatusReason>())
			.RuleFor(e => e.TimeZoneRuleVersionNumber, fake => fake.Random.Int())
			.RuleFor(e => e.Transactioncurrencyidname, fake => fake.Lorem.Word())
			.RuleFor(e => e.UTCConversionTimeZoneCode, fake => fake.Random.Int())
			.RuleFor(e => e.Versionnumber, fake => fake.Random.Int());
			return faker.Generate();
		}
		#endregion
	}
}

