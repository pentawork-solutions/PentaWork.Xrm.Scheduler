using Bogus;
using System;
using FakeXrmEasy;
using System.Collections.Generic;
using PentaWork.Xrm.Scheduler.Proxies.Entities;

namespace PentaWork.Xrm.Scheduler.Tests.Fake
{
	public static class FakeDataLakeFolder
	{	
		#region FakeRelationships
		public static class Relationships 
		{
			/// <summary>1:N datalakefolder_AsyncOperations</summary>
			public static readonly XrmFakedRelationship DatalakefolderAsyncOperations = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "datalakefolderid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "datalakefolder",
					Entity2LogicalName = "asyncoperation",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N datalakefolder_BulkDeleteFailures</summary>
			public static readonly XrmFakedRelationship DatalakefolderBulkDeleteFailures = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "datalakefolderid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "datalakefolder",
					Entity2LogicalName = "bulkdeletefailure",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N datalakefolder_datalakefolderpermission</summary>
			public static readonly XrmFakedRelationship DatalakefolderDatalakefolderpermission = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "datalakefolderid",
					Entity2Attribute = "folderid",
					Entity1LogicalName = "datalakefolder",
					Entity2LogicalName = "datalakefolderpermission",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N datalakefolder_DuplicateBaseRecord</summary>
			public static readonly XrmFakedRelationship DatalakefolderDuplicateBaseRecord = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "datalakefolderid",
					Entity2Attribute = "baserecordid",
					Entity1LogicalName = "datalakefolder",
					Entity2LogicalName = "duplicaterecord",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N datalakefolder_DuplicateMatchingRecord</summary>
			public static readonly XrmFakedRelationship DatalakefolderDuplicateMatchingRecord = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "datalakefolderid",
					Entity2Attribute = "duplicaterecordid",
					Entity1LogicalName = "datalakefolder",
					Entity2LogicalName = "duplicaterecord",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N datalakefolder_MailboxTrackingFolders</summary>
			public static readonly XrmFakedRelationship DatalakefolderMailboxTrackingFolders = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "datalakefolderid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "datalakefolder",
					Entity2LogicalName = "mailboxtrackingfolder",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N datalakefolder_PrincipalObjectAttributeAccesses</summary>
			public static readonly XrmFakedRelationship DatalakefolderPrincipalObjectAttributeAccesses = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "datalakefolderid",
					Entity2Attribute = "objectid",
					Entity1LogicalName = "datalakefolder",
					Entity2LogicalName = "principalobjectattributeaccess",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N datalakefolder_ProcessSession</summary>
			public static readonly XrmFakedRelationship DatalakefolderProcessSession = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "datalakefolderid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "datalakefolder",
					Entity2LogicalName = "processsession",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N datalakefolder_SyncErrors</summary>
			public static readonly XrmFakedRelationship DatalakefolderSyncErrors = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "datalakefolderid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "datalakefolder",
					Entity2LogicalName = "syncerror",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

		}
		#endregion

		#region Fake
		public static DataLakeFolder Create()
		{
			var faker = new Faker<DataLakeFolder>()
			.RuleFor(e => e.RowIdUniqueId, fake => Guid.NewGuid())
			.RuleFor(e => e.ComponentState, fake => fake.PickRandom<DataLakeFolder.egComponentState>())
			.RuleFor(e => e.ContainerEndpoint, fake => fake.Lorem.Word())
			.RuleFor(e => e.Createdbyname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Createdbyyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.CreatedOn, fake => fake.Date.Soon())
			.RuleFor(e => e.Createdonbehalfbyname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Createdonbehalfbyyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.UniqueName, fake => fake.Lorem.Word())
			.RuleFor(e => e.Id, fake => Guid.NewGuid())
			.RuleFor(e => e.ExtendedProperties, fake => fake.Lorem.Word())
			.RuleFor(e => e.ImportSequenceNumber, fake => fake.Random.Int())
			.RuleFor(e => e.IsCustomerCapacity, fake => fake.Random.Bool())
			.RuleFor(e => e.IsDeepCopyEnabled, fake => fake.Random.Bool())
			.RuleFor(e => e.IsManaged, fake => fake.Random.Bool())
			.RuleFor(e => e.IsPrivate, fake => fake.Random.Bool())
			.RuleFor(e => e.Modifiedbyname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Modifiedbyyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.ModifiedOn, fake => fake.Date.Soon())
			.RuleFor(e => e.Modifiedonbehalfbyname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Modifiedonbehalfbyyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.Name, fake => fake.Lorem.Word())
			.RuleFor(e => e.RecordCreatedOn, fake => fake.Date.Soon())
			.RuleFor(e => e.RecordOverwriteTime, fake => fake.Date.Soon())
			.RuleFor(e => e.Owneridname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Owneridtype, fake => fake.Lorem.Word())
			.RuleFor(e => e.Owneridyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.OwningAppId, fake => Guid.NewGuid())
			.RuleFor(e => e.Path, fake => fake.Lorem.Word())
			.RuleFor(e => e.SolutionId, fake => Guid.NewGuid())
			.RuleFor(e => e.Status, fake => fake.PickRandom<DataLakeFolder.eStatus>())
			.RuleFor(e => e.StatusReason, fake => fake.PickRandom<DataLakeFolder.eStatusReason>())
			.RuleFor(e => e.SolutionId2, fake => Guid.NewGuid())
			.RuleFor(e => e.TimeZoneRuleVersionNumber, fake => fake.Random.Int())
			.RuleFor(e => e.UTCConversionTimeZoneCode, fake => fake.Random.Int())
			.RuleFor(e => e.VersionNumber, fake => fake.Random.Int());
			return faker.Generate();
		}
		#endregion
	}
}

