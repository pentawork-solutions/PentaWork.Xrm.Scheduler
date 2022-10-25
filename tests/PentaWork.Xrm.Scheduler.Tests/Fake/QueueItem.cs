using Bogus;
using System;
using FakeXrmEasy;
using System.Collections.Generic;
using PentaWork.Xrm.Scheduler.Proxies.Entities;

namespace PentaWork.Xrm.Scheduler.Tests.Fake
{
	public static class FakeQueueItem
	{	
		#region FakeRelationships
		public static class Relationships 
		{
			/// <summary>1:N QueueItem_AsyncOperations</summary>
			public static readonly XrmFakedRelationship QueueItemAsyncOperations = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "queueitemid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "queueitem",
					Entity2LogicalName = "asyncoperation",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N QueueItem_BulkDeleteFailures</summary>
			public static readonly XrmFakedRelationship QueueItemBulkDeleteFailures = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "queueitemid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "queueitem",
					Entity2LogicalName = "bulkdeletefailure",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N queueitem_principalobjectattributeaccess</summary>
			public static readonly XrmFakedRelationship QueueitemPrincipalobjectattributeaccess = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "queueitemid",
					Entity2Attribute = "objectid",
					Entity1LogicalName = "queueitem",
					Entity2LogicalName = "principalobjectattributeaccess",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N QueueItem_ProcessSessions</summary>
			public static readonly XrmFakedRelationship QueueItemProcessSessions = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "queueitemid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "queueitem",
					Entity2LogicalName = "processsession",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N QueueItem_SyncErrors</summary>
			public static readonly XrmFakedRelationship QueueItemSyncErrors = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "queueitemid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "queueitem",
					Entity2LogicalName = "syncerror",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

		}
		#endregion

		#region Fake
		public static QueueItem Create()
		{
			var faker = new Faker<QueueItem>()
			.RuleFor(e => e.Createdbyname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Createdbyyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.CreatedOn, fake => fake.Date.Soon())
			.RuleFor(e => e.Createdonbehalfbyname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Createdonbehalfbyyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.EnteredQueue, fake => fake.Date.Soon())
			.RuleFor(e => e.ExchangeRate, fake => fake.Finance.Amount())
			.RuleFor(e => e.ImportSequenceNumber, fake => fake.Random.Int())
			.RuleFor(e => e.Modifiedbyname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Modifiedbyyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.ModifiedOn, fake => fake.Date.Soon())
			.RuleFor(e => e.Modifiedonbehalfbyname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Modifiedonbehalfbyyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.Objectidname, fake => fake.Lorem.Word())
			.RuleFor(e => e.RegardingObjectType, fake => fake.Lorem.Word())
			.RuleFor(e => e.Type, fake => fake.PickRandom<QueueItem.eType>())
			.RuleFor(e => e.Organizationidname, fake => fake.Lorem.Word())
			.RuleFor(e => e.RecordCreatedOn, fake => fake.Date.Soon())
			.RuleFor(e => e.Owneridtype, fake => fake.Lorem.Word())
			.RuleFor(e => e.Priority, fake => fake.Random.Int())
			.RuleFor(e => e.Queueidname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Id, fake => Guid.NewGuid())
			.RuleFor(e => e.From, fake => fake.Lorem.Word())
			.RuleFor(e => e.Statusdeprecated, fake => fake.Random.Int())
			.RuleFor(e => e.Status, fake => fake.PickRandom<QueueItem.eStatus>())
			.RuleFor(e => e.StatusReasondeprecated, fake => fake.Random.Int())
			.RuleFor(e => e.StatusReason, fake => fake.PickRandom<QueueItem.eStatusReason>())
			.RuleFor(e => e.TimeZoneRuleVersionNumber, fake => fake.Random.Int())
			.RuleFor(e => e.Title, fake => fake.Lorem.Word())
			.RuleFor(e => e.To, fake => fake.Lorem.Word())
			.RuleFor(e => e.Transactioncurrencyidname, fake => fake.Lorem.Word())
			.RuleFor(e => e.UTCConversionTimeZoneCode, fake => fake.Random.Int())
			.RuleFor(e => e.VersionNumber, fake => fake.Random.Int())
			.RuleFor(e => e.WorkedOn, fake => fake.Date.Soon())
			.RuleFor(e => e.Workeridname, fake => fake.Lorem.Word())
			.RuleFor(e => e.WorkerType, fake => fake.Lorem.Word())
			.RuleFor(e => e.Workeridyominame, fake => fake.Lorem.Word());
			return faker.Generate();
		}
		#endregion
	}
}

