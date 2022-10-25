using Bogus;
using System;
using FakeXrmEasy;
using System.Collections.Generic;
using PentaWork.Xrm.Scheduler.Proxies.Entities;

namespace PentaWork.Xrm.Scheduler.Tests.Fake
{
	public static class FakeTerritory
	{	
		#region FakeRelationships
		public static class Relationships 
		{
			/// <summary>1:N territory_accounts</summary>
			public static readonly XrmFakedRelationship TerritoryAccounts = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "territoryid",
					Entity2Attribute = "territoryid",
					Entity1LogicalName = "territory",
					Entity2LogicalName = "account",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N Territory_AsyncOperations</summary>
			public static readonly XrmFakedRelationship TerritoryAsyncOperations = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "territoryid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "territory",
					Entity2LogicalName = "asyncoperation",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N Territory_BulkDeleteFailures</summary>
			public static readonly XrmFakedRelationship TerritoryBulkDeleteFailures = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "territoryid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "territory",
					Entity2LogicalName = "bulkdeletefailure",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N territory_connections1</summary>
			public static readonly XrmFakedRelationship TerritoryConnections1 = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "territoryid",
					Entity2Attribute = "record1id",
					Entity1LogicalName = "territory",
					Entity2LogicalName = "connection",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N territory_connections2</summary>
			public static readonly XrmFakedRelationship TerritoryConnections2 = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "territoryid",
					Entity2Attribute = "record2id",
					Entity1LogicalName = "territory",
					Entity2LogicalName = "connection",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N Territory_DuplicateBaseRecord</summary>
			public static readonly XrmFakedRelationship TerritoryDuplicateBaseRecord = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "territoryid",
					Entity2Attribute = "baserecordid",
					Entity1LogicalName = "territory",
					Entity2LogicalName = "duplicaterecord",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N Territory_DuplicateMatchingRecord</summary>
			public static readonly XrmFakedRelationship TerritoryDuplicateMatchingRecord = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "territoryid",
					Entity2Attribute = "duplicaterecordid",
					Entity1LogicalName = "territory",
					Entity2LogicalName = "duplicaterecord",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N territory_MailboxTrackingFolders</summary>
			public static readonly XrmFakedRelationship TerritoryMailboxTrackingFolders = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "territoryid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "territory",
					Entity2LogicalName = "mailboxtrackingfolder",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N territory_parent_territory</summary>
			public static readonly XrmFakedRelationship TerritoryParentTerritory = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "territoryid",
					Entity2Attribute = "parentterritoryid",
					Entity1LogicalName = "territory",
					Entity2LogicalName = "territory",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N territory_principalobjectattributeaccess</summary>
			public static readonly XrmFakedRelationship TerritoryPrincipalobjectattributeaccess = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "territoryid",
					Entity2Attribute = "objectid",
					Entity1LogicalName = "territory",
					Entity2LogicalName = "principalobjectattributeaccess",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N Territory_ProcessSessions</summary>
			public static readonly XrmFakedRelationship TerritoryProcessSessions = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "territoryid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "territory",
					Entity2LogicalName = "processsession",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N Territory_SyncErrors</summary>
			public static readonly XrmFakedRelationship TerritorySyncErrors = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "territoryid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "territory",
					Entity2LogicalName = "syncerror",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N territory_system_users</summary>
			public static readonly XrmFakedRelationship TerritorySystemUsers = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "territoryid",
					Entity2Attribute = "territoryid",
					Entity1LogicalName = "territory",
					Entity2LogicalName = "systemuser",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

		}
		#endregion

		#region Fake
		public static Territory Create()
		{
			var faker = new Faker<Territory>()
			.RuleFor(e => e.Createdbyname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Createdbyyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.CreatedOn, fake => fake.Date.Soon())
			.RuleFor(e => e.Createdonbehalfbyname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Createdonbehalfbyyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.Description, fake => fake.Lorem.Word())
			.RuleFor(e => e.EntityimageTimestamp, fake => fake.Random.Int())
			.RuleFor(e => e.EntityimageUrl, fake => fake.Lorem.Word())
			.RuleFor(e => e.EntityimageId, fake => Guid.NewGuid())
			.RuleFor(e => e.ExchangeRate, fake => fake.Finance.Amount())
			.RuleFor(e => e.ImportSequenceNumber, fake => fake.Random.Int())
			.RuleFor(e => e.Manageridname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Manageridyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.Modifiedbyname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Modifiedbyyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.ModifiedOn, fake => fake.Date.Soon())
			.RuleFor(e => e.Modifiedonbehalfbyname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Modifiedonbehalfbyyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.TerritoryName, fake => fake.Lorem.Word())
			.RuleFor(e => e.Organizationidname, fake => fake.Lorem.Word())
			.RuleFor(e => e.RecordCreatedOn, fake => fake.Date.Soon())
			.RuleFor(e => e.Parentterritoryidname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Id, fake => Guid.NewGuid())
			.RuleFor(e => e.TimeZoneRuleVersionNumber, fake => fake.Random.Int())
			.RuleFor(e => e.Transactioncurrencyidname, fake => fake.Lorem.Word())
			.RuleFor(e => e.UTCConversionTimeZoneCode, fake => fake.Random.Int())
			.RuleFor(e => e.VersionNumber, fake => fake.Random.Int());
			return faker.Generate();
		}
		#endregion
	}
}

