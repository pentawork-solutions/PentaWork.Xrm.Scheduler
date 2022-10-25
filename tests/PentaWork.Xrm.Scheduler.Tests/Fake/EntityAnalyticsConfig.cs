using Bogus;
using System;
using FakeXrmEasy;
using System.Collections.Generic;
using PentaWork.Xrm.Scheduler.Proxies.Entities;

namespace PentaWork.Xrm.Scheduler.Tests.Fake
{
	public static class FakeEntityAnalyticsConfig
	{	
		#region FakeRelationships
		public static class Relationships 
		{
			/// <summary>1:N entityanalyticsconfig_AsyncOperations</summary>
			public static readonly XrmFakedRelationship EntityanalyticsconfigAsyncOperations = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "entityanalyticsconfigid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "entityanalyticsconfig",
					Entity2LogicalName = "asyncoperation",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N entityanalyticsconfig_BulkDeleteFailures</summary>
			public static readonly XrmFakedRelationship EntityanalyticsconfigBulkDeleteFailures = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "entityanalyticsconfigid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "entityanalyticsconfig",
					Entity2LogicalName = "bulkdeletefailure",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N entityanalyticsconfig_MailboxTrackingFolders</summary>
			public static readonly XrmFakedRelationship EntityanalyticsconfigMailboxTrackingFolders = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "entityanalyticsconfigid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "entityanalyticsconfig",
					Entity2LogicalName = "mailboxtrackingfolder",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N entityanalyticsconfig_PrincipalObjectAttributeAccesses</summary>
			public static readonly XrmFakedRelationship EntityanalyticsconfigPrincipalObjectAttributeAccesses = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "entityanalyticsconfigid",
					Entity2Attribute = "objectid",
					Entity1LogicalName = "entityanalyticsconfig",
					Entity2LogicalName = "principalobjectattributeaccess",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N entityanalyticsconfig_SyncErrors</summary>
			public static readonly XrmFakedRelationship EntityanalyticsconfigSyncErrors = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "entityanalyticsconfigid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "entityanalyticsconfig",
					Entity2LogicalName = "syncerror",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

		}
		#endregion

		#region Fake
		public static EntityAnalyticsConfig Create()
		{
			var faker = new Faker<EntityAnalyticsConfig>()
			.RuleFor(e => e.RowIdUniqueId, fake => Guid.NewGuid())
			.RuleFor(e => e.ComponentState, fake => fake.PickRandom<EntityAnalyticsConfig.egComponentState>())
			.RuleFor(e => e.Id, fake => Guid.NewGuid())
			.RuleFor(e => e.IsEnabledForADLS, fake => fake.Random.Bool())
			.RuleFor(e => e.IsEnabledForTimeSeries, fake => fake.Random.Bool())
			.RuleFor(e => e.IsManaged, fake => fake.Random.Bool())
			.RuleFor(e => e.Organizationidname, fake => fake.Lorem.Word())
			.RuleFor(e => e.RecordOverwriteTime, fake => fake.Date.Soon())
			.RuleFor(e => e.Parententityidname, fake => fake.Lorem.Word())
			.RuleFor(e => e.EntityLogicalNameForAnalytics, fake => fake.Lorem.Word())
			.RuleFor(e => e.SolutionId, fake => Guid.NewGuid())
			.RuleFor(e => e.SolutionId2, fake => Guid.NewGuid())
			.RuleFor(e => e.VersionNumber, fake => fake.Random.Int());
			return faker.Generate();
		}
		#endregion
	}
}

