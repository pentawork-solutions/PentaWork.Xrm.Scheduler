using Bogus;
using System;
using FakeXrmEasy;
using System.Collections.Generic;
using PentaWork.Xrm.Scheduler.Proxies.Entities;

namespace PentaWork.Xrm.Scheduler.Tests.Fake
{
	public static class FakeImageAttributeConfiguration
	{	
		#region FakeRelationships
		public static class Relationships 
		{
			/// <summary>1:N attributeimageconfig_AsyncOperations</summary>
			public static readonly XrmFakedRelationship AttributeimageconfigAsyncOperations = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "attributeimageconfigid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "attributeimageconfig",
					Entity2LogicalName = "asyncoperation",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N attributeimageconfig_BulkDeleteFailures</summary>
			public static readonly XrmFakedRelationship AttributeimageconfigBulkDeleteFailures = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "attributeimageconfigid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "attributeimageconfig",
					Entity2LogicalName = "bulkdeletefailure",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N attributeimageconfig_MailboxTrackingFolders</summary>
			public static readonly XrmFakedRelationship AttributeimageconfigMailboxTrackingFolders = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "attributeimageconfigid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "attributeimageconfig",
					Entity2LogicalName = "mailboxtrackingfolder",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N attributeimageconfig_PrincipalObjectAttributeAccesses</summary>
			public static readonly XrmFakedRelationship AttributeimageconfigPrincipalObjectAttributeAccesses = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "attributeimageconfigid",
					Entity2Attribute = "objectid",
					Entity1LogicalName = "attributeimageconfig",
					Entity2LogicalName = "principalobjectattributeaccess",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N attributeimageconfig_SyncErrors</summary>
			public static readonly XrmFakedRelationship AttributeimageconfigSyncErrors = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "attributeimageconfigid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "attributeimageconfig",
					Entity2LogicalName = "syncerror",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

		}
		#endregion

		#region Fake
		public static ImageAttributeConfiguration Create()
		{
			var faker = new Faker<ImageAttributeConfiguration>()
			.RuleFor(e => e.Id, fake => Guid.NewGuid())
			.RuleFor(e => e.LogicalNameOfImageAttribute, fake => fake.Lorem.Word())
			.RuleFor(e => e.CanStoreFullImage, fake => fake.Random.Bool())
			.RuleFor(e => e.RowIdUniqueId, fake => Guid.NewGuid())
			.RuleFor(e => e.ComponentState, fake => fake.PickRandom<ImageAttributeConfiguration.egComponentState>())
			.RuleFor(e => e.IsManaged, fake => fake.Random.Bool())
			.RuleFor(e => e.RecordOverwriteTime, fake => fake.Date.Soon())
			.RuleFor(e => e.ParentEntityLogicalName, fake => fake.Lorem.Word())
			.RuleFor(e => e.SolutionId, fake => Guid.NewGuid())
			.RuleFor(e => e.SolutionId2, fake => Guid.NewGuid())
			.RuleFor(e => e.VersionNumber, fake => fake.Random.Int());
			return faker.Generate();
		}
		#endregion
	}
}

