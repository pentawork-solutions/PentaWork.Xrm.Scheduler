using Bogus;
using System;
using FakeXrmEasy;
using System.Collections.Generic;
using PentaWork.Xrm.Scheduler.Proxies.Entities;

namespace PentaWork.Xrm.Scheduler.Tests.Fake
{
	public static class FakeAIModel
	{	
		#region FakeRelationships
		public static class Relationships 
		{
			/// <summary>1:N msdyn_AIBDatasetsContainer_msdyn_AIModelI</summary>
			public static readonly XrmFakedRelationship MsdynAIBDatasetsContainerMsdynAIModelI = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "msdyn_aimodelid",
					Entity2Attribute = "msdyn_aimodelid",
					Entity1LogicalName = "msdyn_aimodel",
					Entity2LogicalName = "msdyn_aibdatasetscontainer",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N msdyn_aimodel_Annotations</summary>
			public static readonly XrmFakedRelationship MsdynAimodelAnnotations = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "msdyn_aimodelid",
					Entity2Attribute = "objectid",
					Entity1LogicalName = "msdyn_aimodel",
					Entity2LogicalName = "annotation",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N msdyn_aimodel_AsyncOperations</summary>
			public static readonly XrmFakedRelationship MsdynAimodelAsyncOperations = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "msdyn_aimodelid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "msdyn_aimodel",
					Entity2LogicalName = "asyncoperation",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N msdyn_aimodel_BulkDeleteFailures</summary>
			public static readonly XrmFakedRelationship MsdynAimodelBulkDeleteFailures = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "msdyn_aimodelid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "msdyn_aimodel",
					Entity2LogicalName = "bulkdeletefailure",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N msdyn_aimodel_MailboxTrackingFolders</summary>
			public static readonly XrmFakedRelationship MsdynAimodelMailboxTrackingFolders = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "msdyn_aimodelid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "msdyn_aimodel",
					Entity2LogicalName = "mailboxtrackingfolder",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N msdyn_aimodel_msdyn_aiconfiguration</summary>
			public static readonly XrmFakedRelationship MsdynAimodelMsdynAiconfiguration = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "msdyn_aimodelid",
					Entity2Attribute = "msdyn_aimodelid",
					Entity1LogicalName = "msdyn_aimodel",
					Entity2LogicalName = "msdyn_aiconfiguration",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N msdyn_aimodel_PrincipalObjectAttributeAccesses</summary>
			public static readonly XrmFakedRelationship MsdynAimodelPrincipalObjectAttributeAccesses = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "msdyn_aimodelid",
					Entity2Attribute = "objectid",
					Entity1LogicalName = "msdyn_aimodel",
					Entity2LogicalName = "principalobjectattributeaccess",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N msdyn_aimodel_ProcessSession</summary>
			public static readonly XrmFakedRelationship MsdynAimodelProcessSession = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "msdyn_aimodelid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "msdyn_aimodel",
					Entity2LogicalName = "processsession",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N msdyn_aimodel_SyncErrors</summary>
			public static readonly XrmFakedRelationship MsdynAimodelSyncErrors = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "msdyn_aimodelid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "msdyn_aimodel",
					Entity2LogicalName = "syncerror",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

		}
		#endregion

		#region Fake
		public static AIModel Create()
		{
			var faker = new Faker<AIModel>()
			.RuleFor(e => e.ComponentState, fake => fake.PickRandom<AIModel.egComponentState>())
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
			.RuleFor(e => e.MsdynAimodeliduniqueId, fake => Guid.NewGuid())
			.RuleFor(e => e.ModelCreationContext, fake => fake.Lorem.Word())
			.RuleFor(e => e.Name, fake => fake.Lorem.Word())
			.RuleFor(e => e.MsdynRetrainworkflowidname, fake => fake.Lorem.Word())
			.RuleFor(e => e.MsdynScheduleinferenceworkflowidname, fake => fake.Lorem.Word())
			.RuleFor(e => e.ShareWithOrganizationOnCreate, fake => fake.Random.Bool())
			.RuleFor(e => e.MsdynTemplateidname, fake => fake.Lorem.Word())
			.RuleFor(e => e.RecordCreatedOn, fake => fake.Date.Soon())
			.RuleFor(e => e.RecordOverwriteTime, fake => fake.Date.Soon())
			.RuleFor(e => e.Owneridname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Owneridtype, fake => fake.Lorem.Word())
			.RuleFor(e => e.Owneridyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.SolutionId, fake => Guid.NewGuid())
			.RuleFor(e => e.Status, fake => fake.PickRandom<AIModel.eStatus>())
			.RuleFor(e => e.StatusReason, fake => fake.PickRandom<AIModel.eStatusReason>())
			.RuleFor(e => e.SolutionId2, fake => Guid.NewGuid())
			.RuleFor(e => e.TimeZoneRuleVersionNumber, fake => fake.Random.Int())
			.RuleFor(e => e.UTCConversionTimeZoneCode, fake => fake.Random.Int())
			.RuleFor(e => e.VersionNumber, fake => fake.Random.Int());
			return faker.Generate();
		}
		#endregion
	}
}

