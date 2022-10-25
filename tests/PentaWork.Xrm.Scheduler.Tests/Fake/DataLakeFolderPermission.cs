using Bogus;
using System;
using FakeXrmEasy;
using System.Collections.Generic;
using PentaWork.Xrm.Scheduler.Proxies.Entities;

namespace PentaWork.Xrm.Scheduler.Tests.Fake
{
	public static class FakeDataLakeFolderPermission
	{	
		#region FakeRelationships
		public static class Relationships 
		{
			/// <summary>1:N datalakefolderpermission_AsyncOperations</summary>
			public static readonly XrmFakedRelationship DatalakefolderpermissionAsyncOperations = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "datalakefolderpermissionid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "datalakefolderpermission",
					Entity2LogicalName = "asyncoperation",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N datalakefolderpermission_BulkDeleteFailures</summary>
			public static readonly XrmFakedRelationship DatalakefolderpermissionBulkDeleteFailures = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "datalakefolderpermissionid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "datalakefolderpermission",
					Entity2LogicalName = "bulkdeletefailure",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N datalakefolderpermission_DuplicateBaseRecord</summary>
			public static readonly XrmFakedRelationship DatalakefolderpermissionDuplicateBaseRecord = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "datalakefolderpermissionid",
					Entity2Attribute = "baserecordid",
					Entity1LogicalName = "datalakefolderpermission",
					Entity2LogicalName = "duplicaterecord",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N datalakefolderpermission_DuplicateMatchingRecord</summary>
			public static readonly XrmFakedRelationship DatalakefolderpermissionDuplicateMatchingRecord = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "datalakefolderpermissionid",
					Entity2Attribute = "duplicaterecordid",
					Entity1LogicalName = "datalakefolderpermission",
					Entity2LogicalName = "duplicaterecord",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N datalakefolderpermission_MailboxTrackingFolders</summary>
			public static readonly XrmFakedRelationship DatalakefolderpermissionMailboxTrackingFolders = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "datalakefolderpermissionid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "datalakefolderpermission",
					Entity2LogicalName = "mailboxtrackingfolder",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N datalakefolderpermission_PrincipalObjectAttributeAccesses</summary>
			public static readonly XrmFakedRelationship DatalakefolderpermissionPrincipalObjectAttributeAccesses = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "datalakefolderpermissionid",
					Entity2Attribute = "objectid",
					Entity1LogicalName = "datalakefolderpermission",
					Entity2LogicalName = "principalobjectattributeaccess",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N datalakefolderpermission_ProcessSession</summary>
			public static readonly XrmFakedRelationship DatalakefolderpermissionProcessSession = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "datalakefolderpermissionid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "datalakefolderpermission",
					Entity2LogicalName = "processsession",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N datalakefolderpermission_SyncErrors</summary>
			public static readonly XrmFakedRelationship DatalakefolderpermissionSyncErrors = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "datalakefolderpermissionid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "datalakefolderpermission",
					Entity2LogicalName = "syncerror",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

		}
		#endregion

		#region Fake
		public static DataLakeFolderPermission Create()
		{
			var faker = new Faker<DataLakeFolderPermission>()
			.RuleFor(e => e.AppId, fake => Guid.NewGuid())
			.RuleFor(e => e.CanExecute, fake => fake.Random.Bool())
			.RuleFor(e => e.CanRead, fake => fake.Random.Bool())
			.RuleFor(e => e.CanWrite, fake => fake.Random.Bool())
			.RuleFor(e => e.RowIdUniqueId, fake => Guid.NewGuid())
			.RuleFor(e => e.ComponentState, fake => fake.PickRandom<DataLakeFolderPermission.egComponentState>())
			.RuleFor(e => e.Createdbyname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Createdbyyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.CreatedOn, fake => fake.Date.Soon())
			.RuleFor(e => e.Createdonbehalfbyname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Createdonbehalfbyyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.UniqueName, fake => fake.Lorem.Word())
			.RuleFor(e => e.Id, fake => Guid.NewGuid())
			.RuleFor(e => e.Folderidname, fake => fake.Lorem.Word())
			.RuleFor(e => e.ImportSequenceNumber, fake => fake.Random.Int())
			.RuleFor(e => e.IsManaged, fake => fake.Random.Bool())
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
			.RuleFor(e => e.SolutionId, fake => Guid.NewGuid())
			.RuleFor(e => e.Status, fake => fake.PickRandom<DataLakeFolderPermission.eStatus>())
			.RuleFor(e => e.StatusReason, fake => fake.PickRandom<DataLakeFolderPermission.eStatusReason>())
			.RuleFor(e => e.SolutionId2, fake => Guid.NewGuid())
			.RuleFor(e => e.TimeZoneRuleVersionNumber, fake => fake.Random.Int())
			.RuleFor(e => e.UTCConversionTimeZoneCode, fake => fake.Random.Int())
			.RuleFor(e => e.VersionNumber, fake => fake.Random.Int());
			return faker.Generate();
		}
		#endregion
	}
}

