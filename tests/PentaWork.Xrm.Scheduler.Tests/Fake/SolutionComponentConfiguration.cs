using Bogus;
using System;
using FakeXrmEasy;
using System.Collections.Generic;
using PentaWork.Xrm.Scheduler.Proxies.Entities;

namespace PentaWork.Xrm.Scheduler.Tests.Fake
{
	public static class FakeSolutionComponentConfiguration
	{	
		#region FakeRelationships
		public static class Relationships 
		{
			/// <summary>1:N solutioncomponentconfig_solutioncomponentattrconfig</summary>
			public static readonly XrmFakedRelationship SolutioncomponentconfigSolutioncomponentattrconfig = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "solutioncomponentconfigurationid",
					Entity2Attribute = "solutioncomponentconfigurationid",
					Entity1LogicalName = "solutioncomponentconfiguration",
					Entity2LogicalName = "solutioncomponentattributeconfiguration",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N solutioncomponentconfiguration_AsyncOperations</summary>
			public static readonly XrmFakedRelationship SolutioncomponentconfigurationAsyncOperations = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "solutioncomponentconfigurationid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "solutioncomponentconfiguration",
					Entity2LogicalName = "asyncoperation",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N solutioncomponentconfiguration_BulkDeleteFailures</summary>
			public static readonly XrmFakedRelationship SolutioncomponentconfigurationBulkDeleteFailures = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "solutioncomponentconfigurationid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "solutioncomponentconfiguration",
					Entity2LogicalName = "bulkdeletefailure",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N solutioncomponentconfiguration_DuplicateBaseRecord</summary>
			public static readonly XrmFakedRelationship SolutioncomponentconfigurationDuplicateBaseRecord = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "solutioncomponentconfigurationid",
					Entity2Attribute = "baserecordid",
					Entity1LogicalName = "solutioncomponentconfiguration",
					Entity2LogicalName = "duplicaterecord",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N solutioncomponentconfiguration_DuplicateMatchingRecord</summary>
			public static readonly XrmFakedRelationship SolutioncomponentconfigurationDuplicateMatchingRecord = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "solutioncomponentconfigurationid",
					Entity2Attribute = "duplicaterecordid",
					Entity1LogicalName = "solutioncomponentconfiguration",
					Entity2LogicalName = "duplicaterecord",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N solutioncomponentconfiguration_MailboxTrackingFolders</summary>
			public static readonly XrmFakedRelationship SolutioncomponentconfigurationMailboxTrackingFolders = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "solutioncomponentconfigurationid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "solutioncomponentconfiguration",
					Entity2LogicalName = "mailboxtrackingfolder",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N solutioncomponentconfiguration_PrincipalObjectAttributeAccesses</summary>
			public static readonly XrmFakedRelationship SolutioncomponentconfigurationPrincipalObjectAttributeAccesses = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "solutioncomponentconfigurationid",
					Entity2Attribute = "objectid",
					Entity1LogicalName = "solutioncomponentconfiguration",
					Entity2LogicalName = "principalobjectattributeaccess",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N solutioncomponentconfiguration_ProcessSession</summary>
			public static readonly XrmFakedRelationship SolutioncomponentconfigurationProcessSession = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "solutioncomponentconfigurationid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "solutioncomponentconfiguration",
					Entity2LogicalName = "processsession",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N solutioncomponentconfiguration_SyncErrors</summary>
			public static readonly XrmFakedRelationship SolutioncomponentconfigurationSyncErrors = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "solutioncomponentconfigurationid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "solutioncomponentconfiguration",
					Entity2LogicalName = "syncerror",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

		}
		#endregion

		#region Fake
		public static SolutionComponentConfiguration Create()
		{
			var faker = new Faker<SolutionComponentConfiguration>()
			.RuleFor(e => e.RowIdUniqueId, fake => Guid.NewGuid())
			.RuleFor(e => e.ComponentState, fake => fake.PickRandom<SolutionComponentConfiguration.egComponentState>())
			.RuleFor(e => e.Createdbyname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Createdbyyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.CreatedOn, fake => fake.Date.Soon())
			.RuleFor(e => e.Createdonbehalfbyname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Createdonbehalfbyyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.Entityidname, fake => fake.Lorem.Word())
			.RuleFor(e => e.FileFormat, fake => fake.PickRandom<SolutionComponentConfiguration.eFileFormat>())
			.RuleFor(e => e.FileScope, fake => fake.PickRandom<SolutionComponentConfiguration.eFileScope>())
			.RuleFor(e => e.ImportSequenceNumber, fake => fake.Random.Int())
			.RuleFor(e => e.Displayable, fake => fake.Random.Bool())
			.RuleFor(e => e.IsManaged, fake => fake.Random.Bool())
			.RuleFor(e => e.IsSoftDeleteEnabled, fake => fake.Random.Bool())
			.RuleFor(e => e.Modifiedbyname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Modifiedbyyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.ModifiedOn, fake => fake.Date.Soon())
			.RuleFor(e => e.Modifiedonbehalfbyname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Modifiedonbehalfbyyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.Name, fake => fake.Lorem.Word())
			.RuleFor(e => e.Organizationidname, fake => fake.Lorem.Word())
			.RuleFor(e => e.RecordCreatedOn, fake => fake.Date.Soon())
			.RuleFor(e => e.RecordOverwriteTime, fake => fake.Date.Soon())
			.RuleFor(e => e.Id, fake => Guid.NewGuid())
			.RuleFor(e => e.SolutionId, fake => Guid.NewGuid())
			.RuleFor(e => e.Status, fake => fake.PickRandom<SolutionComponentConfiguration.eStatus>())
			.RuleFor(e => e.StatusReason, fake => fake.PickRandom<SolutionComponentConfiguration.eStatusReason>())
			.RuleFor(e => e.SolutionId2, fake => Guid.NewGuid())
			.RuleFor(e => e.TimeZoneRuleVersionNumber, fake => fake.Random.Int())
			.RuleFor(e => e.UTCConversionTimeZoneCode, fake => fake.Random.Int())
			.RuleFor(e => e.VersionNumber, fake => fake.Random.Int());
			return faker.Generate();
		}
		#endregion
	}
}

