using Bogus;
using System;
using FakeXrmEasy;
using System.Collections.Generic;
using PentaWork.Xrm.Scheduler.Proxies.Entities;

namespace PentaWork.Xrm.Scheduler.Tests.Fake
{
	public static class FakeConnectionReference
	{	
		#region FakeRelationships
		public static class Relationships 
		{
			/// <summary>1:N connectionreference_AsyncOperations</summary>
			public static readonly XrmFakedRelationship ConnectionreferenceAsyncOperations = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "connectionreferenceid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "connectionreference",
					Entity2LogicalName = "asyncoperation",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N connectionreference_BulkDeleteFailures</summary>
			public static readonly XrmFakedRelationship ConnectionreferenceBulkDeleteFailures = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "connectionreferenceid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "connectionreference",
					Entity2LogicalName = "bulkdeletefailure",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N connectionreference_MailboxTrackingFolders</summary>
			public static readonly XrmFakedRelationship ConnectionreferenceMailboxTrackingFolders = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "connectionreferenceid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "connectionreference",
					Entity2LogicalName = "mailboxtrackingfolder",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N connectionreference_PrincipalObjectAttributeAccesses</summary>
			public static readonly XrmFakedRelationship ConnectionreferencePrincipalObjectAttributeAccesses = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "connectionreferenceid",
					Entity2Attribute = "objectid",
					Entity1LogicalName = "connectionreference",
					Entity2LogicalName = "principalobjectattributeaccess",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N connectionreference_ProcessSession</summary>
			public static readonly XrmFakedRelationship ConnectionreferenceProcessSession = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "connectionreferenceid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "connectionreference",
					Entity2LogicalName = "processsession",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N connectionreference_SyncErrors</summary>
			public static readonly XrmFakedRelationship ConnectionreferenceSyncErrors = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "connectionreferenceid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "connectionreference",
					Entity2LogicalName = "syncerror",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

		}
		#endregion

		#region Fake
		public static ConnectionReference Create()
		{
			var faker = new Faker<ConnectionReference>()
			.RuleFor(e => e.RowIdUniqueId, fake => Guid.NewGuid())
			.RuleFor(e => e.ComponentState, fake => fake.PickRandom<ConnectionReference.egComponentState>())
			.RuleFor(e => e.ConnectionId, fake => fake.Lorem.Word())
			.RuleFor(e => e.ConnectionReferenceDisplayName, fake => fake.Lorem.Word())
			.RuleFor(e => e.Id, fake => Guid.NewGuid())
			.RuleFor(e => e.ConnectionReferenceLogicalName, fake => fake.Lorem.Word())
			.RuleFor(e => e.ConnectorId, fake => fake.Lorem.Word())
			.RuleFor(e => e.Createdbyname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Createdbyyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.CreatedOn, fake => fake.Date.Soon())
			.RuleFor(e => e.Createdonbehalfbyname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Createdonbehalfbyyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.Customconnectoridname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Description, fake => fake.Lorem.Word())
			.RuleFor(e => e.ImportSequenceNumber, fake => fake.Random.Int())
			.RuleFor(e => e.IsManaged, fake => fake.Random.Bool())
			.RuleFor(e => e.Modifiedbyname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Modifiedbyyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.ModifiedOn, fake => fake.Date.Soon())
			.RuleFor(e => e.Modifiedonbehalfbyname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Modifiedonbehalfbyyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.RecordCreatedOn, fake => fake.Date.Soon())
			.RuleFor(e => e.RecordOverwriteTime, fake => fake.Date.Soon())
			.RuleFor(e => e.Owneridname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Owneridtype, fake => fake.Lorem.Word())
			.RuleFor(e => e.Owneridyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.SolutionId, fake => Guid.NewGuid())
			.RuleFor(e => e.Status, fake => fake.PickRandom<ConnectionReference.eStatus>())
			.RuleFor(e => e.StatusReason, fake => fake.PickRandom<ConnectionReference.eStatusReason>())
			.RuleFor(e => e.SolutionId2, fake => Guid.NewGuid())
			.RuleFor(e => e.TimeZoneRuleVersionNumber, fake => fake.Random.Int())
			.RuleFor(e => e.UTCConversionTimeZoneCode, fake => fake.Random.Int())
			.RuleFor(e => e.VersionNumber, fake => fake.Random.Int());
			return faker.Generate();
		}
		#endregion
	}
}

