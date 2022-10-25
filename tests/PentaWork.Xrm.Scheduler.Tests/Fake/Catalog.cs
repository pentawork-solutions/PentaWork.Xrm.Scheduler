using Bogus;
using System;
using FakeXrmEasy;
using System.Collections.Generic;
using PentaWork.Xrm.Scheduler.Proxies.Entities;

namespace PentaWork.Xrm.Scheduler.Tests.Fake
{
	public static class FakeCatalog
	{	
		#region FakeRelationships
		public static class Relationships 
		{
			/// <summary>1:N catalog_AsyncOperations</summary>
			public static readonly XrmFakedRelationship CatalogAsyncOperations = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "catalogid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "catalog",
					Entity2LogicalName = "asyncoperation",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N catalog_BulkDeleteFailures</summary>
			public static readonly XrmFakedRelationship CatalogBulkDeleteFailures = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "catalogid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "catalog",
					Entity2LogicalName = "bulkdeletefailure",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N catalog_catalogassignment</summary>
			public static readonly XrmFakedRelationship CatalogCatalogassignment = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "catalogid",
					Entity2Attribute = "catalogid",
					Entity1LogicalName = "catalog",
					Entity2LogicalName = "catalogassignment",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N catalog_MailboxTrackingFolders</summary>
			public static readonly XrmFakedRelationship CatalogMailboxTrackingFolders = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "catalogid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "catalog",
					Entity2LogicalName = "mailboxtrackingfolder",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N catalog_PrincipalObjectAttributeAccesses</summary>
			public static readonly XrmFakedRelationship CatalogPrincipalObjectAttributeAccesses = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "catalogid",
					Entity2Attribute = "objectid",
					Entity1LogicalName = "catalog",
					Entity2LogicalName = "principalobjectattributeaccess",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N catalog_ProcessSession</summary>
			public static readonly XrmFakedRelationship CatalogProcessSession = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "catalogid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "catalog",
					Entity2LogicalName = "processsession",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N catalog_SyncErrors</summary>
			public static readonly XrmFakedRelationship CatalogSyncErrors = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "catalogid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "catalog",
					Entity2LogicalName = "syncerror",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N parentcatalog_catalog</summary>
			public static readonly XrmFakedRelationship ParentcatalogCatalog = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "catalogid",
					Entity2Attribute = "parentcatalogid",
					Entity1LogicalName = "catalog",
					Entity2LogicalName = "catalog",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

		}
		#endregion

		#region Fake
		public static Catalog Create()
		{
			var faker = new Faker<Catalog>()
			.RuleFor(e => e.Id, fake => Guid.NewGuid())
			.RuleFor(e => e.RowIdUniqueId, fake => Guid.NewGuid())
			.RuleFor(e => e.ComponentState, fake => fake.PickRandom<Catalog.egComponentState>())
			.RuleFor(e => e.Createdbyname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Createdbyyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.CreatedOn, fake => fake.Date.Soon())
			.RuleFor(e => e.Createdonbehalfbyname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Createdonbehalfbyyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.Description, fake => fake.Lorem.Word())
			.RuleFor(e => e.DisplayName, fake => fake.Lorem.Word())
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
			.RuleFor(e => e.Parentcatalogidname, fake => fake.Lorem.Word())
			.RuleFor(e => e.SolutionId, fake => Guid.NewGuid())
			.RuleFor(e => e.Status, fake => fake.PickRandom<Catalog.eStatus>())
			.RuleFor(e => e.StatusReason, fake => fake.PickRandom<Catalog.eStatusReason>())
			.RuleFor(e => e.SolutionId2, fake => Guid.NewGuid())
			.RuleFor(e => e.TimeZoneRuleVersionNumber, fake => fake.Random.Int())
			.RuleFor(e => e.UniqueName, fake => fake.Lorem.Word())
			.RuleFor(e => e.UTCConversionTimeZoneCode, fake => fake.Random.Int())
			.RuleFor(e => e.VersionNumber, fake => fake.Random.Int());
			return faker.Generate();
		}
		#endregion
	}
}

