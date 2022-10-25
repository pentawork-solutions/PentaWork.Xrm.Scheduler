using Bogus;
using System;
using FakeXrmEasy;
using System.Collections.Generic;
using PentaWork.Xrm.Scheduler.Proxies.Entities;

namespace PentaWork.Xrm.Scheduler.Tests.Fake
{
	public static class FakeDataLakeWorkspacePermission
	{	
		#region FakeRelationships
		public static class Relationships 
		{
			/// <summary>1:N datalakeworkspacepermission_AsyncOperations</summary>
			public static readonly XrmFakedRelationship DatalakeworkspacepermissionAsyncOperations = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "datalakeworkspacepermissionid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "datalakeworkspacepermission",
					Entity2LogicalName = "asyncoperation",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N datalakeworkspacepermission_BulkDeleteFailures</summary>
			public static readonly XrmFakedRelationship DatalakeworkspacepermissionBulkDeleteFailures = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "datalakeworkspacepermissionid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "datalakeworkspacepermission",
					Entity2LogicalName = "bulkdeletefailure",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N datalakeworkspacepermission_DuplicateBaseRecord</summary>
			public static readonly XrmFakedRelationship DatalakeworkspacepermissionDuplicateBaseRecord = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "datalakeworkspacepermissionid",
					Entity2Attribute = "baserecordid",
					Entity1LogicalName = "datalakeworkspacepermission",
					Entity2LogicalName = "duplicaterecord",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N datalakeworkspacepermission_DuplicateMatchingRecord</summary>
			public static readonly XrmFakedRelationship DatalakeworkspacepermissionDuplicateMatchingRecord = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "datalakeworkspacepermissionid",
					Entity2Attribute = "duplicaterecordid",
					Entity1LogicalName = "datalakeworkspacepermission",
					Entity2LogicalName = "duplicaterecord",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N datalakeworkspacepermission_MailboxTrackingFolders</summary>
			public static readonly XrmFakedRelationship DatalakeworkspacepermissionMailboxTrackingFolders = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "datalakeworkspacepermissionid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "datalakeworkspacepermission",
					Entity2LogicalName = "mailboxtrackingfolder",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N datalakeworkspacepermission_PrincipalObjectAttributeAccesses</summary>
			public static readonly XrmFakedRelationship DatalakeworkspacepermissionPrincipalObjectAttributeAccesses = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "datalakeworkspacepermissionid",
					Entity2Attribute = "objectid",
					Entity1LogicalName = "datalakeworkspacepermission",
					Entity2LogicalName = "principalobjectattributeaccess",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N datalakeworkspacepermission_ProcessSession</summary>
			public static readonly XrmFakedRelationship DatalakeworkspacepermissionProcessSession = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "datalakeworkspacepermissionid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "datalakeworkspacepermission",
					Entity2LogicalName = "processsession",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N datalakeworkspacepermission_SyncErrors</summary>
			public static readonly XrmFakedRelationship DatalakeworkspacepermissionSyncErrors = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "datalakeworkspacepermissionid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "datalakeworkspacepermission",
					Entity2LogicalName = "syncerror",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

		}
		#endregion

		#region Fake
		public static DataLakeWorkspacePermission Create()
		{
			var faker = new Faker<DataLakeWorkspacePermission>()
			.RuleFor(e => e.AppId, fake => Guid.NewGuid())
			.RuleFor(e => e.CanExecute, fake => fake.Random.Bool())
			.RuleFor(e => e.CanRead, fake => fake.Random.Bool())
			.RuleFor(e => e.CanWrite, fake => fake.Random.Bool())
			.RuleFor(e => e.RowIdUniqueId, fake => Guid.NewGuid())
			.RuleFor(e => e.ComponentState, fake => fake.PickRandom<DataLakeWorkspacePermission.egComponentState>())
			.RuleFor(e => e.Createdbyname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Createdbyyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.CreatedOn, fake => fake.Date.Soon())
			.RuleFor(e => e.Createdonbehalfbyname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Createdonbehalfbyyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.UniqueName, fake => fake.Lorem.Word())
			.RuleFor(e => e.Id, fake => Guid.NewGuid())
			.RuleFor(e => e.ImportSequenceNumber, fake => fake.Random.Int())
			.RuleFor(e => e.IsManaged, fake => fake.Random.Bool())
			.RuleFor(e => e.Modifiedbyname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Modifiedbyyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.ModifiedOn, fake => fake.Date.Soon())
			.RuleFor(e => e.Modifiedonbehalfbyname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Modifiedonbehalfbyyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.Name, fake => fake.Lorem.Word())
			.RuleFor(e => e.Organizationidname, fake => fake.Lorem.Word())
			.RuleFor(e => e.RecordCreatedOn, fake => fake.Date.Soon())
			.RuleFor(e => e.RecordOverwriteTime, fake => fake.Date.Soon())
			.RuleFor(e => e.SolutionId, fake => Guid.NewGuid())
			.RuleFor(e => e.Status, fake => fake.PickRandom<DataLakeWorkspacePermission.eStatus>())
			.RuleFor(e => e.StatusReason, fake => fake.PickRandom<DataLakeWorkspacePermission.eStatusReason>())
			.RuleFor(e => e.SolutionId2, fake => Guid.NewGuid())
			.RuleFor(e => e.TenantId, fake => Guid.NewGuid())
			.RuleFor(e => e.TimeZoneRuleVersionNumber, fake => fake.Random.Int())
			.RuleFor(e => e.UTCConversionTimeZoneCode, fake => fake.Random.Int())
			.RuleFor(e => e.VersionNumber, fake => fake.Random.Int())
			.RuleFor(e => e.WhitelistedAppId, fake => Guid.NewGuid())
			.RuleFor(e => e.Workspaceidname, fake => fake.Lorem.Word());
			return faker.Generate();
		}
		#endregion
	}
}

