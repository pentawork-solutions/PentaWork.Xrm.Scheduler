using Bogus;
using System;
using FakeXrmEasy;
using System.Collections.Generic;
using PentaWork.Xrm.Scheduler.Proxies.Entities;

namespace PentaWork.Xrm.Scheduler.Tests.Fake
{
	public static class FakeSolutionComponentAttributeConfiguration
	{	
		#region FakeRelationships
		public static class Relationships 
		{
			/// <summary>1:N solutioncomponentattributeconfiguration_AsyncOperations</summary>
			public static readonly XrmFakedRelationship SolutioncomponentattributeconfigurationAsyncOperations = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "solutioncomponentattributeconfigurationid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "solutioncomponentattributeconfiguration",
					Entity2LogicalName = "asyncoperation",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N solutioncomponentattributeconfiguration_BulkDeleteFailures</summary>
			public static readonly XrmFakedRelationship SolutioncomponentattributeconfigurationBulkDeleteFailures = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "solutioncomponentattributeconfigurationid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "solutioncomponentattributeconfiguration",
					Entity2LogicalName = "bulkdeletefailure",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N solutioncomponentattributeconfiguration_DuplicateBaseRecord</summary>
			public static readonly XrmFakedRelationship SolutioncomponentattributeconfigurationDuplicateBaseRecord = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "solutioncomponentattributeconfigurationid",
					Entity2Attribute = "baserecordid",
					Entity1LogicalName = "solutioncomponentattributeconfiguration",
					Entity2LogicalName = "duplicaterecord",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N solutioncomponentattributeconfiguration_DuplicateMatchingRecord</summary>
			public static readonly XrmFakedRelationship SolutioncomponentattributeconfigurationDuplicateMatchingRecord = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "solutioncomponentattributeconfigurationid",
					Entity2Attribute = "duplicaterecordid",
					Entity1LogicalName = "solutioncomponentattributeconfiguration",
					Entity2LogicalName = "duplicaterecord",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N solutioncomponentattributeconfiguration_MailboxTrackingFolders</summary>
			public static readonly XrmFakedRelationship SolutioncomponentattributeconfigurationMailboxTrackingFolders = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "solutioncomponentattributeconfigurationid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "solutioncomponentattributeconfiguration",
					Entity2LogicalName = "mailboxtrackingfolder",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N solutioncomponentattributeconfiguration_PrincipalObjectAttributeAccesses</summary>
			public static readonly XrmFakedRelationship SolutioncomponentattributeconfigurationPrincipalObjectAttributeAccesses = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "solutioncomponentattributeconfigurationid",
					Entity2Attribute = "objectid",
					Entity1LogicalName = "solutioncomponentattributeconfiguration",
					Entity2LogicalName = "principalobjectattributeaccess",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N solutioncomponentattributeconfiguration_ProcessSession</summary>
			public static readonly XrmFakedRelationship SolutioncomponentattributeconfigurationProcessSession = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "solutioncomponentattributeconfigurationid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "solutioncomponentattributeconfiguration",
					Entity2LogicalName = "processsession",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N solutioncomponentattributeconfiguration_SyncErrors</summary>
			public static readonly XrmFakedRelationship SolutioncomponentattributeconfigurationSyncErrors = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "solutioncomponentattributeconfigurationid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "solutioncomponentattributeconfiguration",
					Entity2LogicalName = "syncerror",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

		}
		#endregion

		#region Fake
		public static SolutionComponentAttributeConfiguration Create()
		{
			var faker = new Faker<SolutionComponentAttributeConfiguration>()
			.RuleFor(e => e.Attributeidname, fake => fake.Lorem.Word())
			.RuleFor(e => e.RowIdUniqueId, fake => Guid.NewGuid())
			.RuleFor(e => e.ComponentState, fake => fake.PickRandom<SolutionComponentAttributeConfiguration.egComponentState>())
			.RuleFor(e => e.Createdbyname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Createdbyyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.CreatedOn, fake => fake.Date.Soon())
			.RuleFor(e => e.Createdonbehalfbyname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Createdonbehalfbyyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.EncodingFormat, fake => fake.PickRandom<SolutionComponentAttributeConfiguration.eEncodingFormat>())
			.RuleFor(e => e.FileExtension, fake => fake.Lorem.Word())
			.RuleFor(e => e.ImportSequenceNumber, fake => fake.Random.Int())
			.RuleFor(e => e.ExportDisabled, fake => fake.Random.Bool())
			.RuleFor(e => e.IsExportedAsFile, fake => fake.Random.Bool())
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
			.RuleFor(e => e.Id, fake => Guid.NewGuid())
			.RuleFor(e => e.Solutioncomponentconfigurationidname, fake => fake.Lorem.Word())
			.RuleFor(e => e.SolutionId, fake => Guid.NewGuid())
			.RuleFor(e => e.Status, fake => fake.PickRandom<SolutionComponentAttributeConfiguration.eStatus>())
			.RuleFor(e => e.StatusReason, fake => fake.PickRandom<SolutionComponentAttributeConfiguration.eStatusReason>())
			.RuleFor(e => e.SolutionId2, fake => Guid.NewGuid())
			.RuleFor(e => e.TimeZoneRuleVersionNumber, fake => fake.Random.Int())
			.RuleFor(e => e.UTCConversionTimeZoneCode, fake => fake.Random.Int())
			.RuleFor(e => e.VersionNumber, fake => fake.Random.Int());
			return faker.Generate();
		}
		#endregion
	}
}

