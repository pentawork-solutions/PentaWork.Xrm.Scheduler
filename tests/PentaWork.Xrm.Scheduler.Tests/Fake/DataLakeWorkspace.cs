using Bogus;
using System;
using FakeXrmEasy;
using System.Collections.Generic;
using PentaWork.Xrm.Scheduler.Proxies.Entities;

namespace PentaWork.Xrm.Scheduler.Tests.Fake
{
	public static class FakeDataLakeWorkspace
	{	
		#region FakeRelationships
		public static class Relationships 
		{
			/// <summary>1:N datalakeworkspace_AsyncOperations</summary>
			public static readonly XrmFakedRelationship DatalakeworkspaceAsyncOperations = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "datalakeworkspaceid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "datalakeworkspace",
					Entity2LogicalName = "asyncoperation",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N datalakeworkspace_BulkDeleteFailures</summary>
			public static readonly XrmFakedRelationship DatalakeworkspaceBulkDeleteFailures = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "datalakeworkspaceid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "datalakeworkspace",
					Entity2LogicalName = "bulkdeletefailure",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N datalakeworkspace_DuplicateBaseRecord</summary>
			public static readonly XrmFakedRelationship DatalakeworkspaceDuplicateBaseRecord = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "datalakeworkspaceid",
					Entity2Attribute = "baserecordid",
					Entity1LogicalName = "datalakeworkspace",
					Entity2LogicalName = "duplicaterecord",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N datalakeworkspace_DuplicateMatchingRecord</summary>
			public static readonly XrmFakedRelationship DatalakeworkspaceDuplicateMatchingRecord = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "datalakeworkspaceid",
					Entity2Attribute = "duplicaterecordid",
					Entity1LogicalName = "datalakeworkspace",
					Entity2LogicalName = "duplicaterecord",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N datalakeworkspace_MailboxTrackingFolders</summary>
			public static readonly XrmFakedRelationship DatalakeworkspaceMailboxTrackingFolders = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "datalakeworkspaceid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "datalakeworkspace",
					Entity2LogicalName = "mailboxtrackingfolder",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N datalakeworkspace_PrincipalObjectAttributeAccesses</summary>
			public static readonly XrmFakedRelationship DatalakeworkspacePrincipalObjectAttributeAccesses = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "datalakeworkspaceid",
					Entity2Attribute = "objectid",
					Entity1LogicalName = "datalakeworkspace",
					Entity2LogicalName = "principalobjectattributeaccess",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N datalakeworkspace_ProcessSession</summary>
			public static readonly XrmFakedRelationship DatalakeworkspaceProcessSession = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "datalakeworkspaceid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "datalakeworkspace",
					Entity2LogicalName = "processsession",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N datalakeworkspace_SyncErrors</summary>
			public static readonly XrmFakedRelationship DatalakeworkspaceSyncErrors = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "datalakeworkspaceid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "datalakeworkspace",
					Entity2LogicalName = "syncerror",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N datalakeworkspace_workspacepermission</summary>
			public static readonly XrmFakedRelationship DatalakeworkspaceWorkspacepermission = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "datalakeworkspaceid",
					Entity2Attribute = "workspaceid",
					Entity1LogicalName = "datalakeworkspace",
					Entity2LogicalName = "datalakeworkspacepermission",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

		}
		#endregion

		#region Fake
		public static DataLakeWorkspace Create()
		{
			var faker = new Faker<DataLakeWorkspace>()
			.RuleFor(e => e.RowIdUniqueId, fake => Guid.NewGuid())
			.RuleFor(e => e.ComponentState, fake => fake.PickRandom<DataLakeWorkspace.egComponentState>())
			.RuleFor(e => e.ContainerEndpoint, fake => fake.Lorem.Word())
			.RuleFor(e => e.Createdbyname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Createdbyyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.CreatedOn, fake => fake.Date.Soon())
			.RuleFor(e => e.Createdonbehalfbyname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Createdonbehalfbyyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.UniqueName, fake => fake.Lorem.Word())
			.RuleFor(e => e.Id, fake => Guid.NewGuid())
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
			.RuleFor(e => e.Organizationidname, fake => fake.Lorem.Word())
			.RuleFor(e => e.RecordCreatedOn, fake => fake.Date.Soon())
			.RuleFor(e => e.RecordOverwriteTime, fake => fake.Date.Soon())
			.RuleFor(e => e.OwningAppId, fake => Guid.NewGuid())
			.RuleFor(e => e.Path, fake => fake.Lorem.Word())
			.RuleFor(e => e.SolutionId, fake => Guid.NewGuid())
			.RuleFor(e => e.Status, fake => fake.PickRandom<DataLakeWorkspace.eStatus>())
			.RuleFor(e => e.StatusReason, fake => fake.PickRandom<DataLakeWorkspace.eStatusReason>())
			.RuleFor(e => e.SolutionId2, fake => Guid.NewGuid())
			.RuleFor(e => e.TenantId, fake => Guid.NewGuid())
			.RuleFor(e => e.TimeZoneRuleVersionNumber, fake => fake.Random.Int())
			.RuleFor(e => e.UTCConversionTimeZoneCode, fake => fake.Random.Int())
			.RuleFor(e => e.VersionNumber, fake => fake.Random.Int())
			.RuleFor(e => e.WhitelistedAppId, fake => Guid.NewGuid());
			return faker.Generate();
		}
		#endregion
	}
}

