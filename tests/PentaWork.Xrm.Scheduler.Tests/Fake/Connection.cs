using Bogus;
using System;
using FakeXrmEasy;
using System.Collections.Generic;
using PentaWork.Xrm.Scheduler.Proxies.Entities;

namespace PentaWork.Xrm.Scheduler.Tests.Fake
{
	public static class FakeConnection
	{	
		#region FakeRelationships
		public static class Relationships 
		{
			/// <summary>1:N Connection_AsyncOperations</summary>
			public static readonly XrmFakedRelationship ConnectionAsyncOperations = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "connectionid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "connection",
					Entity2LogicalName = "asyncoperation",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N connection_principalobjectattributeaccess</summary>
			public static readonly XrmFakedRelationship ConnectionPrincipalobjectattributeaccess = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "connectionid",
					Entity2Attribute = "objectid",
					Entity1LogicalName = "connection",
					Entity2LogicalName = "principalobjectattributeaccess",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N Connection_ProcessSessions</summary>
			public static readonly XrmFakedRelationship ConnectionProcessSessions = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "connectionid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "connection",
					Entity2LogicalName = "processsession",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N connection_related_connection</summary>
			public static readonly XrmFakedRelationship ConnectionRelatedConnection = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "connectionid",
					Entity2Attribute = "relatedconnectionid",
					Entity1LogicalName = "connection",
					Entity2LogicalName = "connection",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N Connection_SyncErrors</summary>
			public static readonly XrmFakedRelationship ConnectionSyncErrors = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "connectionid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "connection",
					Entity2LogicalName = "syncerror",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

		}
		#endregion

		#region Fake
		public static Connection Create()
		{
			var faker = new Faker<Connection>()
			.RuleFor(e => e.Id, fake => Guid.NewGuid())
			.RuleFor(e => e.Createdbyname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Createdbyyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.CreatedOn, fake => fake.Date.Soon())
			.RuleFor(e => e.Createdonbehalfbyname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Createdonbehalfbyyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.Description, fake => fake.Lorem.Word())
			.RuleFor(e => e.Ending, fake => fake.Date.Soon())
			.RuleFor(e => e.Starting, fake => fake.Date.Soon())
			.RuleFor(e => e.EntityimageTimestamp, fake => fake.Random.Int())
			.RuleFor(e => e.EntityimageUrl, fake => fake.Lorem.Word())
			.RuleFor(e => e.EntityImageId, fake => Guid.NewGuid())
			.RuleFor(e => e.ExchangeRate, fake => fake.Finance.Amount())
			.RuleFor(e => e.ImportSequenceNumber, fake => fake.Random.Int())
			.RuleFor(e => e.IsMaster, fake => fake.Random.Bool())
			.RuleFor(e => e.Modifiedbyname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Modifiedbyyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.ModifiedOn, fake => fake.Date.Soon())
			.RuleFor(e => e.Modifiedonbehalfbyname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Modifiedonbehalfbyyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.ConnectionName, fake => fake.Lorem.Word())
			.RuleFor(e => e.RecordCreatedOn, fake => fake.Date.Soon())
			.RuleFor(e => e.Owneridname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Owneridtype, fake => fake.Lorem.Word())
			.RuleFor(e => e.Owneridyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.NameFrom, fake => fake.Lorem.Word())
			.RuleFor(e => e.Record1idobjecttypecode, fake => fake.Lorem.Word())
			.RuleFor(e => e.TypeFrom, fake => fake.PickRandom<Connection.eTypeFrom>())
			.RuleFor(e => e.Record1roleidname, fake => fake.Lorem.Word())
			.RuleFor(e => e.NameTo, fake => fake.Lorem.Word())
			.RuleFor(e => e.Record2idobjecttypecode, fake => fake.Lorem.Word())
			.RuleFor(e => e.TypeTo, fake => fake.PickRandom<Connection.eTypeTo>())
			.RuleFor(e => e.Record2roleidname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Status, fake => fake.PickRandom<Connection.eStatus>())
			.RuleFor(e => e.StatusReason, fake => fake.PickRandom<Connection.eStatusReason>())
			.RuleFor(e => e.Transactioncurrencyidname, fake => fake.Lorem.Word())
			.RuleFor(e => e.VersionNumber, fake => fake.Random.Int());
			return faker.Generate();
		}
		#endregion
	}
}

