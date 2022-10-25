using Bogus;
using System;
using FakeXrmEasy;
using System.Collections.Generic;
using PentaWork.Xrm.Scheduler.Proxies.Entities;

namespace PentaWork.Xrm.Scheduler.Tests.Fake
{
	public static class FakeAIConfiguration
	{	
		#region FakeRelationships
		public static class Relationships 
		{
			/// <summary>1:N msdyn_aiconfiguration_AsyncOperations</summary>
			public static readonly XrmFakedRelationship MsdynAiconfigurationAsyncOperations = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "msdyn_aiconfigurationid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "msdyn_aiconfiguration",
					Entity2LogicalName = "asyncoperation",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N msdyn_aiconfiguration_BulkDeleteFailures</summary>
			public static readonly XrmFakedRelationship MsdynAiconfigurationBulkDeleteFailures = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "msdyn_aiconfigurationid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "msdyn_aiconfiguration",
					Entity2LogicalName = "bulkdeletefailure",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N msdyn_aiconfiguration_FileAttachments</summary>
			public static readonly XrmFakedRelationship MsdynAiconfigurationFileAttachments = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "msdyn_aiconfigurationid",
					Entity2Attribute = "objectid",
					Entity1LogicalName = "msdyn_aiconfiguration",
					Entity2LogicalName = "fileattachment",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N msdyn_aiconfiguration_MailboxTrackingFolders</summary>
			public static readonly XrmFakedRelationship MsdynAiconfigurationMailboxTrackingFolders = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "msdyn_aiconfigurationid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "msdyn_aiconfiguration",
					Entity2LogicalName = "mailboxtrackingfolder",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N msdyn_aiconfiguration_msdyn_aiconfiguration</summary>
			public static readonly XrmFakedRelationship MsdynAiconfigurationMsdynAiconfiguration = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "msdyn_aiconfigurationid",
					Entity2Attribute = "msdyn_trainedmodelaiconfigurationpareid",
					Entity1LogicalName = "msdyn_aiconfiguration",
					Entity2LogicalName = "msdyn_aiconfiguration",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N msdyn_aiconfiguration_msdyn_aiodtrainingimage</summary>
			public static readonly XrmFakedRelationship MsdynAiconfigurationMsdynAiodtrainingimage = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "msdyn_aiconfigurationid",
					Entity2Attribute = "msdyn_aiconfigurationid",
					Entity1LogicalName = "msdyn_aiconfiguration",
					Entity2LogicalName = "msdyn_aiodtrainingimage",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N msdyn_aiconfiguration_PrincipalObjectAttributeAccesses</summary>
			public static readonly XrmFakedRelationship MsdynAiconfigurationPrincipalObjectAttributeAccesses = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "msdyn_aiconfigurationid",
					Entity2Attribute = "objectid",
					Entity1LogicalName = "msdyn_aiconfiguration",
					Entity2LogicalName = "principalobjectattributeaccess",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N msdyn_aiconfiguration_ProcessSession</summary>
			public static readonly XrmFakedRelationship MsdynAiconfigurationProcessSession = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "msdyn_aiconfigurationid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "msdyn_aiconfiguration",
					Entity2LogicalName = "processsession",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N msdyn_aiconfiguration_SyncErrors</summary>
			public static readonly XrmFakedRelationship MsdynAiconfigurationSyncErrors = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "msdyn_aiconfigurationid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "msdyn_aiconfiguration",
					Entity2LogicalName = "syncerror",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N msdyn_createdfromconfiguration_msdyn_toconfiguration</summary>
			public static readonly XrmFakedRelationship MsdynCreatedfromconfigurationMsdynToconfiguration = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "msdyn_aiconfigurationid",
					Entity2Attribute = "msdyn_createdfromconfigurationid",
					Entity1LogicalName = "msdyn_aiconfiguration",
					Entity2LogicalName = "msdyn_aiconfiguration",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N msdyn_msdyn_aiconfiguration_msdyn_aifptrainingdocument_AIConfigurationId</summary>
			public static readonly XrmFakedRelationship MsdynMsdynAiconfigurationMsdynAifptrainingdocumentAIConfigurationId = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "msdyn_aiconfigurationid",
					Entity2Attribute = "msdyn_aiconfigurationid",
					Entity1LogicalName = "msdyn_aiconfiguration",
					Entity2LogicalName = "msdyn_aifptrainingdocument",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>N:N msdyn_aiodlabel_msdyn_aiconfiguration</summary>
			public static readonly XrmFakedRelationship MsdynAiodlabelMsdynAiconfiguration = 
				new XrmFakedRelationship
				{
					IntersectEntity = "msdyn_aiodlabel_msdyn_aiconfiguration",
					Entity1Attribute = "msdyn_aiodlabelid",
					Entity2Attribute = "msdyn_aiconfigurationid",
					Entity1LogicalName = "msdyn_aiodlabel",
					Entity2LogicalName = "msdyn_aiconfiguration",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.ManyToMany
				};

		}
		#endregion

		#region Fake
		public static AIConfiguration Create()
		{
			var faker = new Faker<AIConfiguration>()
			.RuleFor(e => e.ComponentState, fake => fake.PickRandom<AIConfiguration.egComponentState>())
			.RuleFor(e => e.Createdbyname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Createdbyyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.CreatedOn, fake => fake.Date.Soon())
			.RuleFor(e => e.Createdonbehalfbyname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Createdonbehalfbyyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.ImportSequenceNumber, fake => fake.Random.Int())
			.RuleFor(e => e.IntroducedVersion, fake => fake.Lorem.Word())
			.RuleFor(e => e.IsManaged, fake => fake.Random.Bool())
			.RuleFor(e => e.Modifiedbyname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Modifiedbyyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.ModifiedOn, fake => fake.Date.Soon())
			.RuleFor(e => e.Modifiedonbehalfbyname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Modifiedonbehalfbyyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.Id, fake => Guid.NewGuid())
			.RuleFor(e => e.MsdynAiconfigurationiduniqueId, fake => Guid.NewGuid())
			.RuleFor(e => e.MsdynAimodelidname, fake => fake.Lorem.Word())
			.RuleFor(e => e.MsdynCreatedfromconfigurationidname, fake => fake.Lorem.Word())
			.RuleFor(e => e.CustomConfiguration, fake => fake.Lorem.Word())
			.RuleFor(e => e.DataBinding, fake => fake.Lorem.Word())
			.RuleFor(e => e.LastErrors, fake => fake.Lorem.Word())
			.RuleFor(e => e.LastTrainOrRunDate, fake => fake.Date.Soon())
			.RuleFor(e => e.MajorIterationNumber, fake => fake.Random.Int())
			.RuleFor(e => e.MinorIterationNumber, fake => fake.Random.Int())
			.RuleFor(e => e.MsdynModelName, fake => fake.Lorem.Word())
			.RuleFor(e => e.ModelData, fake => fake.Lorem.Word())
			.RuleFor(e => e.ModelGlobalExplainability, fake => fake.Lorem.Word())
			.RuleFor(e => e.ModelPerformance, fake => fake.Lorem.Word())
			.RuleFor(e => e.ModelProvisioningMetadata, fake => fake.Lorem.Word())
			.RuleFor(e => e.ModelProvisioningStatus, fake => fake.Lorem.Word())
			.RuleFor(e => e.ModelRunDataSpecification, fake => fake.Lorem.Word())
			.RuleFor(e => e.Name, fake => fake.Lorem.Word())
			.RuleFor(e => e.ResourceInfo, fake => fake.Lorem.Word())
			.RuleFor(e => e.RunConfiguration, fake => fake.Lorem.Word())
			.RuleFor(e => e.SchedulingOptions, fake => fake.Lorem.Word())
			.RuleFor(e => e.TemplateVersion, fake => fake.Random.Int())
			.RuleFor(e => e.MsdynTrainedmodelaiconfigurationpareidname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Type, fake => fake.PickRandom<AIConfiguration.eType>())
			.RuleFor(e => e.RecordCreatedOn, fake => fake.Date.Soon())
			.RuleFor(e => e.RecordOverwriteTime, fake => fake.Date.Soon())
			.RuleFor(e => e.Owneridname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Owneridtype, fake => fake.Lorem.Word())
			.RuleFor(e => e.Owneridyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.SolutionId, fake => Guid.NewGuid())
			.RuleFor(e => e.Status, fake => fake.PickRandom<AIConfiguration.eStatus>())
			.RuleFor(e => e.StatusReason, fake => fake.PickRandom<AIConfiguration.eStatusReason>())
			.RuleFor(e => e.SolutionId2, fake => Guid.NewGuid())
			.RuleFor(e => e.TimeZoneRuleVersionNumber, fake => fake.Random.Int())
			.RuleFor(e => e.UTCConversionTimeZoneCode, fake => fake.Random.Int())
			.RuleFor(e => e.VersionNumber, fake => fake.Random.Int());
			return faker.Generate();
		}
		#endregion
	}
}

