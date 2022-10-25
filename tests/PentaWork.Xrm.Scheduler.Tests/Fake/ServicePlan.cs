using Bogus;
using System;
using FakeXrmEasy;
using System.Collections.Generic;
using PentaWork.Xrm.Scheduler.Proxies.Entities;

namespace PentaWork.Xrm.Scheduler.Tests.Fake
{
	public static class FakeServicePlan
	{	
		#region FakeRelationships
		public static class Relationships 
		{
			/// <summary>1:N serviceplan_AsyncOperations</summary>
			public static readonly XrmFakedRelationship ServiceplanAsyncOperations = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "serviceplanid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "serviceplan",
					Entity2LogicalName = "asyncoperation",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N serviceplan_BulkDeleteFailures</summary>
			public static readonly XrmFakedRelationship ServiceplanBulkDeleteFailures = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "serviceplanid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "serviceplan",
					Entity2LogicalName = "bulkdeletefailure",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N serviceplan_DuplicateBaseRecord</summary>
			public static readonly XrmFakedRelationship ServiceplanDuplicateBaseRecord = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "serviceplanid",
					Entity2Attribute = "baserecordid",
					Entity1LogicalName = "serviceplan",
					Entity2LogicalName = "duplicaterecord",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N serviceplan_DuplicateMatchingRecord</summary>
			public static readonly XrmFakedRelationship ServiceplanDuplicateMatchingRecord = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "serviceplanid",
					Entity2Attribute = "duplicaterecordid",
					Entity1LogicalName = "serviceplan",
					Entity2LogicalName = "duplicaterecord",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N serviceplan_MailboxTrackingFolders</summary>
			public static readonly XrmFakedRelationship ServiceplanMailboxTrackingFolders = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "serviceplanid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "serviceplan",
					Entity2LogicalName = "mailboxtrackingfolder",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N serviceplan_PrincipalObjectAttributeAccesses</summary>
			public static readonly XrmFakedRelationship ServiceplanPrincipalObjectAttributeAccesses = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "serviceplanid",
					Entity2Attribute = "objectid",
					Entity1LogicalName = "serviceplan",
					Entity2LogicalName = "principalobjectattributeaccess",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N serviceplan_ProcessSession</summary>
			public static readonly XrmFakedRelationship ServiceplanProcessSession = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "serviceplanid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "serviceplan",
					Entity2LogicalName = "processsession",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N serviceplan_SyncErrors</summary>
			public static readonly XrmFakedRelationship ServiceplanSyncErrors = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "serviceplanid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "serviceplan",
					Entity2LogicalName = "syncerror",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>N:N serviceplan_appmodule</summary>
			public static readonly XrmFakedRelationship ServiceplanAppmodule = 
				new XrmFakedRelationship
				{
					IntersectEntity = "serviceplan_appmodule",
					Entity1Attribute = "serviceplanid",
					Entity2Attribute = "appmoduleid",
					Entity1LogicalName = "serviceplan",
					Entity2LogicalName = "appmodule",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.ManyToMany
				};

		}
		#endregion

		#region Fake
		public static ServicePlan Create()
		{
			var faker = new Faker<ServicePlan>()
			.RuleFor(e => e.AccessMode, fake => fake.PickRandom<ServicePlan.eAccessMode>())
			.RuleFor(e => e.RowIdUniqueId, fake => Guid.NewGuid())
			.RuleFor(e => e.ComponentState, fake => fake.PickRandom<ServicePlan.egComponentState>())
			.RuleFor(e => e.Createdbyname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Createdbyyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.CreatedOn, fake => fake.Date.Soon())
			.RuleFor(e => e.Createdonbehalfbyname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Createdonbehalfbyyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.DisplayName, fake => fake.Lorem.Word())
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
			.RuleFor(e => e.Id, fake => Guid.NewGuid())
			.RuleFor(e => e.SolutionId, fake => Guid.NewGuid())
			.RuleFor(e => e.SolutionId2, fake => Guid.NewGuid())
			.RuleFor(e => e.TimeZoneRuleVersionNumber, fake => fake.Random.Int())
			.RuleFor(e => e.UTCConversionTimeZoneCode, fake => fake.Random.Int())
			.RuleFor(e => e.VersionNumber, fake => fake.Random.Int());
			return faker.Generate();
		}
		#endregion
	}
}

