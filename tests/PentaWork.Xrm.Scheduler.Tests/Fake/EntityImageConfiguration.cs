using Bogus;
using System;
using FakeXrmEasy;
using System.Collections.Generic;
using PentaWork.Xrm.Scheduler.Proxies.Entities;

namespace PentaWork.Xrm.Scheduler.Tests.Fake
{
	public static class FakeEntityImageConfiguration
	{	
		#region FakeRelationships
		public static class Relationships 
		{
			/// <summary>1:N entityimageconfig_AsyncOperations</summary>
			public static readonly XrmFakedRelationship EntityimageconfigAsyncOperations = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "entityimageconfigid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "entityimageconfig",
					Entity2LogicalName = "asyncoperation",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N entityimageconfig_BulkDeleteFailures</summary>
			public static readonly XrmFakedRelationship EntityimageconfigBulkDeleteFailures = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "entityimageconfigid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "entityimageconfig",
					Entity2LogicalName = "bulkdeletefailure",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N entityimageconfig_MailboxTrackingFolders</summary>
			public static readonly XrmFakedRelationship EntityimageconfigMailboxTrackingFolders = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "entityimageconfigid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "entityimageconfig",
					Entity2LogicalName = "mailboxtrackingfolder",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N entityimageconfig_PrincipalObjectAttributeAccesses</summary>
			public static readonly XrmFakedRelationship EntityimageconfigPrincipalObjectAttributeAccesses = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "entityimageconfigid",
					Entity2Attribute = "objectid",
					Entity1LogicalName = "entityimageconfig",
					Entity2LogicalName = "principalobjectattributeaccess",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N entityimageconfig_SyncErrors</summary>
			public static readonly XrmFakedRelationship EntityimageconfigSyncErrors = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "entityimageconfigid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "entityimageconfig",
					Entity2LogicalName = "syncerror",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

		}
		#endregion

		#region Fake
		public static EntityImageConfiguration Create()
		{
			var faker = new Faker<EntityImageConfiguration>()
			.RuleFor(e => e.RowIdUniqueId, fake => Guid.NewGuid())
			.RuleFor(e => e.ComponentState, fake => fake.PickRandom<EntityImageConfiguration.egComponentState>())
			.RuleFor(e => e.Id, fake => Guid.NewGuid())
			.RuleFor(e => e.IsManaged, fake => fake.Random.Bool())
			.RuleFor(e => e.RecordOverwriteTime, fake => fake.Date.Soon())
			.RuleFor(e => e.ParentEntityLogicalName, fake => fake.Lorem.Word())
			.RuleFor(e => e.PrimaryImageAttribute, fake => fake.Lorem.Word())
			.RuleFor(e => e.SolutionId, fake => Guid.NewGuid())
			.RuleFor(e => e.SolutionId2, fake => Guid.NewGuid())
			.RuleFor(e => e.VersionNumber, fake => fake.Random.Int());
			return faker.Generate();
		}
		#endregion
	}
}

