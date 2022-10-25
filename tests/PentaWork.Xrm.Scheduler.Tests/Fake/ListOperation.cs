using Bogus;
using System;
using FakeXrmEasy;
using System.Collections.Generic;
using PentaWork.Xrm.Scheduler.Proxies.Entities;

namespace PentaWork.Xrm.Scheduler.Tests.Fake
{
	public static class FakeListOperation
	{	
		#region FakeRelationships
		public static class Relationships 
		{
			/// <summary>1:N listoperation_AsyncOperations</summary>
			public static readonly XrmFakedRelationship ListoperationAsyncOperations = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "listoperationid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "listoperation",
					Entity2LogicalName = "asyncoperation",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N listoperation_BulkDeleteFailures</summary>
			public static readonly XrmFakedRelationship ListoperationBulkDeleteFailures = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "listoperationid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "listoperation",
					Entity2LogicalName = "bulkdeletefailure",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N listoperation_MailboxTrackingFolders</summary>
			public static readonly XrmFakedRelationship ListoperationMailboxTrackingFolders = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "listoperationid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "listoperation",
					Entity2LogicalName = "mailboxtrackingfolder",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N listoperation_PrincipalObjectAttributeAccesses</summary>
			public static readonly XrmFakedRelationship ListoperationPrincipalObjectAttributeAccesses = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "listoperationid",
					Entity2Attribute = "objectid",
					Entity1LogicalName = "listoperation",
					Entity2LogicalName = "principalobjectattributeaccess",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N listoperation_ProcessSession</summary>
			public static readonly XrmFakedRelationship ListoperationProcessSession = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "listoperationid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "listoperation",
					Entity2LogicalName = "processsession",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N listoperation_SyncErrors</summary>
			public static readonly XrmFakedRelationship ListoperationSyncErrors = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "listoperationid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "listoperation",
					Entity2LogicalName = "syncerror",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

		}
		#endregion

		#region Fake
		public static ListOperation Create()
		{
			var faker = new Faker<ListOperation>()
			.RuleFor(e => e.Added, fake => fake.Random.Int())
			.RuleFor(e => e.BatchInput, fake => fake.Lorem.Word())
			.RuleFor(e => e.Createdbyname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Createdbyyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.CreatedOn, fake => fake.Date.Soon())
			.RuleFor(e => e.Createdonbehalfbyname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Createdonbehalfbyyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.ErrorCode, fake => fake.Random.Int())
			.RuleFor(e => e.ErrorDescription, fake => fake.Lorem.Word())
			.RuleFor(e => e.ImportSequenceNumber, fake => fake.Random.Int())
			.RuleFor(e => e.Input, fake => fake.Lorem.Word())
			.RuleFor(e => e.Listidname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Id, fake => Guid.NewGuid())
			.RuleFor(e => e.ListOperationName, fake => fake.Lorem.Word())
			.RuleFor(e => e.ListOperationPrimaryName, fake => fake.Lorem.Word())
			.RuleFor(e => e.Log, fake => fake.Lorem.Word())
			.RuleFor(e => e.Modifiedbyname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Modifiedbyyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.ModifiedOn, fake => fake.Date.Soon())
			.RuleFor(e => e.Modifiedonbehalfbyname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Modifiedonbehalfbyyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.RecordCreatedOn, fake => fake.Date.Soon())
			.RuleFor(e => e.Owneridname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Owneridtype, fake => fake.Lorem.Word())
			.RuleFor(e => e.Owneridyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.Processed, fake => fake.Random.Int())
			.RuleFor(e => e.Status, fake => fake.PickRandom<ListOperation.eStatus>())
			.RuleFor(e => e.StatusReason, fake => fake.PickRandom<ListOperation.eStatusReason>())
			.RuleFor(e => e.TimeZoneRuleVersionNumber, fake => fake.Random.Int())
			.RuleFor(e => e.Type, fake => fake.PickRandom<ListOperation.eType>())
			.RuleFor(e => e.UTCConversionTimeZoneCode, fake => fake.Random.Int())
			.RuleFor(e => e.VersionNumber, fake => fake.Random.Int());
			return faker.Generate();
		}
		#endregion
	}
}

