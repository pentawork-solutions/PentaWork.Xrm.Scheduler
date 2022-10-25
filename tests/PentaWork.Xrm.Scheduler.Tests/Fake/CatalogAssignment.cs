using Bogus;
using System;
using FakeXrmEasy;
using System.Collections.Generic;
using PentaWork.Xrm.Scheduler.Proxies.Entities;

namespace PentaWork.Xrm.Scheduler.Tests.Fake
{
	public static class FakeCatalogAssignment
	{	
		#region FakeRelationships
		public static class Relationships 
		{
			/// <summary>1:N catalogassignment_AsyncOperations</summary>
			public static readonly XrmFakedRelationship CatalogassignmentAsyncOperations = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "catalogassignmentid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "catalogassignment",
					Entity2LogicalName = "asyncoperation",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N catalogassignment_BulkDeleteFailures</summary>
			public static readonly XrmFakedRelationship CatalogassignmentBulkDeleteFailures = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "catalogassignmentid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "catalogassignment",
					Entity2LogicalName = "bulkdeletefailure",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N catalogassignment_DuplicateBaseRecord</summary>
			public static readonly XrmFakedRelationship CatalogassignmentDuplicateBaseRecord = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "catalogassignmentid",
					Entity2Attribute = "baserecordid",
					Entity1LogicalName = "catalogassignment",
					Entity2LogicalName = "duplicaterecord",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N catalogassignment_DuplicateMatchingRecord</summary>
			public static readonly XrmFakedRelationship CatalogassignmentDuplicateMatchingRecord = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "catalogassignmentid",
					Entity2Attribute = "duplicaterecordid",
					Entity1LogicalName = "catalogassignment",
					Entity2LogicalName = "duplicaterecord",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N catalogassignment_MailboxTrackingFolders</summary>
			public static readonly XrmFakedRelationship CatalogassignmentMailboxTrackingFolders = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "catalogassignmentid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "catalogassignment",
					Entity2LogicalName = "mailboxtrackingfolder",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N catalogassignment_PrincipalObjectAttributeAccesses</summary>
			public static readonly XrmFakedRelationship CatalogassignmentPrincipalObjectAttributeAccesses = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "catalogassignmentid",
					Entity2Attribute = "objectid",
					Entity1LogicalName = "catalogassignment",
					Entity2LogicalName = "principalobjectattributeaccess",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N catalogassignment_ProcessSession</summary>
			public static readonly XrmFakedRelationship CatalogassignmentProcessSession = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "catalogassignmentid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "catalogassignment",
					Entity2LogicalName = "processsession",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N catalogassignment_SyncErrors</summary>
			public static readonly XrmFakedRelationship CatalogassignmentSyncErrors = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "catalogassignmentid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "catalogassignment",
					Entity2LogicalName = "syncerror",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

		}
		#endregion

		#region Fake
		public static CatalogAssignment Create()
		{
			var faker = new Faker<CatalogAssignment>()
			.RuleFor(e => e.Id, fake => Guid.NewGuid())
			.RuleFor(e => e.Catalogidname, fake => fake.Lorem.Word())
			.RuleFor(e => e.RowIdUniqueId, fake => Guid.NewGuid())
			.RuleFor(e => e.ComponentState, fake => fake.PickRandom<CatalogAssignment.egComponentState>())
			.RuleFor(e => e.Createdbyname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Createdbyyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.CreatedOn, fake => fake.Date.Soon())
			.RuleFor(e => e.Createdonbehalfbyname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Createdonbehalfbyyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.ImportSequenceNumber, fake => fake.Random.Int())
			.RuleFor(e => e.IsManaged, fake => fake.Random.Bool())
			.RuleFor(e => e.Modifiedbyname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Modifiedbyyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.ModifiedOn, fake => fake.Date.Soon())
			.RuleFor(e => e.Modifiedonbehalfbyname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Modifiedonbehalfbyyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.Name, fake => fake.Lorem.Word())
			.RuleFor(e => e.Objectidtype, fake => fake.Lorem.Word())
			.RuleFor(e => e.Objectname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Objectyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.Organizationidname, fake => fake.Lorem.Word())
			.RuleFor(e => e.RecordCreatedOn, fake => fake.Date.Soon())
			.RuleFor(e => e.RecordOverwriteTime, fake => fake.Date.Soon())
			.RuleFor(e => e.SolutionId, fake => Guid.NewGuid())
			.RuleFor(e => e.Status, fake => fake.PickRandom<CatalogAssignment.eStatus>())
			.RuleFor(e => e.StatusReason, fake => fake.PickRandom<CatalogAssignment.eStatusReason>())
			.RuleFor(e => e.SolutionId2, fake => Guid.NewGuid())
			.RuleFor(e => e.TimeZoneRuleVersionNumber, fake => fake.Random.Int())
			.RuleFor(e => e.UTCConversionTimeZoneCode, fake => fake.Random.Int())
			.RuleFor(e => e.VersionNumber, fake => fake.Random.Int());
			return faker.Generate();
		}
		#endregion
	}
}

