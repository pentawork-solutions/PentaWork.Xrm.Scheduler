using Bogus;
using System;
using FakeXrmEasy;
using System.Collections.Generic;
using PentaWork.Xrm.Scheduler.Proxies.Entities;

namespace PentaWork.Xrm.Scheduler.Tests.Fake
{
	public static class FakeSolutionComponentRelationshipConfiguration
	{	
		#region FakeRelationships
		public static class Relationships 
		{
			/// <summary>1:N solutioncomponentrelationshipconfiguration_AsyncOperations</summary>
			public static readonly XrmFakedRelationship SolutioncomponentrelationshipconfigurationAsyncOperations = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "solutioncomponentrelationshipconfigurationid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "solutioncomponentrelationshipconfiguration",
					Entity2LogicalName = "asyncoperation",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N solutioncomponentrelationshipconfiguration_BulkDeleteFailures</summary>
			public static readonly XrmFakedRelationship SolutioncomponentrelationshipconfigurationBulkDeleteFailures = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "solutioncomponentrelationshipconfigurationid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "solutioncomponentrelationshipconfiguration",
					Entity2LogicalName = "bulkdeletefailure",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N solutioncomponentrelationshipconfiguration_DuplicateBaseRecord</summary>
			public static readonly XrmFakedRelationship SolutioncomponentrelationshipconfigurationDuplicateBaseRecord = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "solutioncomponentrelationshipconfigurationid",
					Entity2Attribute = "baserecordid",
					Entity1LogicalName = "solutioncomponentrelationshipconfiguration",
					Entity2LogicalName = "duplicaterecord",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N solutioncomponentrelationshipconfiguration_DuplicateMatchingRecord</summary>
			public static readonly XrmFakedRelationship SolutioncomponentrelationshipconfigurationDuplicateMatchingRecord = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "solutioncomponentrelationshipconfigurationid",
					Entity2Attribute = "duplicaterecordid",
					Entity1LogicalName = "solutioncomponentrelationshipconfiguration",
					Entity2LogicalName = "duplicaterecord",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N solutioncomponentrelationshipconfiguration_MailboxTrackingFolders</summary>
			public static readonly XrmFakedRelationship SolutioncomponentrelationshipconfigurationMailboxTrackingFolders = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "solutioncomponentrelationshipconfigurationid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "solutioncomponentrelationshipconfiguration",
					Entity2LogicalName = "mailboxtrackingfolder",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N solutioncomponentrelationshipconfiguration_PrincipalObjectAttributeAccesses</summary>
			public static readonly XrmFakedRelationship SolutioncomponentrelationshipconfigurationPrincipalObjectAttributeAccesses = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "solutioncomponentrelationshipconfigurationid",
					Entity2Attribute = "objectid",
					Entity1LogicalName = "solutioncomponentrelationshipconfiguration",
					Entity2LogicalName = "principalobjectattributeaccess",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N solutioncomponentrelationshipconfiguration_ProcessSession</summary>
			public static readonly XrmFakedRelationship SolutioncomponentrelationshipconfigurationProcessSession = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "solutioncomponentrelationshipconfigurationid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "solutioncomponentrelationshipconfiguration",
					Entity2LogicalName = "processsession",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N solutioncomponentrelationshipconfiguration_SyncErrors</summary>
			public static readonly XrmFakedRelationship SolutioncomponentrelationshipconfigurationSyncErrors = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "solutioncomponentrelationshipconfigurationid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "solutioncomponentrelationshipconfiguration",
					Entity2LogicalName = "syncerror",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

		}
		#endregion

		#region Fake
		public static SolutionComponentRelationshipConfiguration Create()
		{
			var faker = new Faker<SolutionComponentRelationshipConfiguration>()
			.RuleFor(e => e.RowIdUniqueId, fake => Guid.NewGuid())
			.RuleFor(e => e.ComponentState, fake => fake.PickRandom<SolutionComponentRelationshipConfiguration.egComponentState>())
			.RuleFor(e => e.Createdbyname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Createdbyyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.CreatedOn, fake => fake.Date.Soon())
			.RuleFor(e => e.Createdonbehalfbyname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Createdonbehalfbyyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.Entityrelationshipidname, fake => fake.Lorem.Word())
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
			.RuleFor(e => e.PrimaryEntityDependencyType, fake => fake.PickRandom<SolutionComponentRelationshipConfiguration.ePrimaryEntityDependencyType>())
			.RuleFor(e => e.SecondaryEntityDependencyType, fake => fake.PickRandom<SolutionComponentRelationshipConfiguration.eSecondaryEntityDependencyType>())
			.RuleFor(e => e.Id, fake => Guid.NewGuid())
			.RuleFor(e => e.SolutionId, fake => Guid.NewGuid())
			.RuleFor(e => e.Status, fake => fake.PickRandom<SolutionComponentRelationshipConfiguration.eStatus>())
			.RuleFor(e => e.StatusReason, fake => fake.PickRandom<SolutionComponentRelationshipConfiguration.eStatusReason>())
			.RuleFor(e => e.SolutionId2, fake => Guid.NewGuid())
			.RuleFor(e => e.TimeZoneRuleVersionNumber, fake => fake.Random.Int())
			.RuleFor(e => e.UTCConversionTimeZoneCode, fake => fake.Random.Int())
			.RuleFor(e => e.VersionNumber, fake => fake.Random.Int());
			return faker.Generate();
		}
		#endregion
	}
}

