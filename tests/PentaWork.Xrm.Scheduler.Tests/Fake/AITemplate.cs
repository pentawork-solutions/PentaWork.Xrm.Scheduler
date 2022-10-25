using Bogus;
using System;
using FakeXrmEasy;
using System.Collections.Generic;
using PentaWork.Xrm.Scheduler.Proxies.Entities;

namespace PentaWork.Xrm.Scheduler.Tests.Fake
{
	public static class FakeAITemplate
	{	
		#region FakeRelationships
		public static class Relationships 
		{
			/// <summary>1:N msdyn_aitemplate_AsyncOperations</summary>
			public static readonly XrmFakedRelationship MsdynAitemplateAsyncOperations = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "msdyn_aitemplateid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "msdyn_aitemplate",
					Entity2LogicalName = "asyncoperation",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N msdyn_aitemplate_BulkDeleteFailures</summary>
			public static readonly XrmFakedRelationship MsdynAitemplateBulkDeleteFailures = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "msdyn_aitemplateid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "msdyn_aitemplate",
					Entity2LogicalName = "bulkdeletefailure",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N msdyn_aitemplate_MailboxTrackingFolders</summary>
			public static readonly XrmFakedRelationship MsdynAitemplateMailboxTrackingFolders = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "msdyn_aitemplateid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "msdyn_aitemplate",
					Entity2LogicalName = "mailboxtrackingfolder",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N msdyn_aitemplate_msdyn_aimodel</summary>
			public static readonly XrmFakedRelationship MsdynAitemplateMsdynAimodel = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "msdyn_aitemplateid",
					Entity2Attribute = "msdyn_templateid",
					Entity1LogicalName = "msdyn_aitemplate",
					Entity2LogicalName = "msdyn_aimodel",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N msdyn_aitemplate_PrincipalObjectAttributeAccesses</summary>
			public static readonly XrmFakedRelationship MsdynAitemplatePrincipalObjectAttributeAccesses = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "msdyn_aitemplateid",
					Entity2Attribute = "objectid",
					Entity1LogicalName = "msdyn_aitemplate",
					Entity2LogicalName = "principalobjectattributeaccess",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N msdyn_aitemplate_ProcessSession</summary>
			public static readonly XrmFakedRelationship MsdynAitemplateProcessSession = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "msdyn_aitemplateid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "msdyn_aitemplate",
					Entity2LogicalName = "processsession",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N msdyn_aitemplate_SyncErrors</summary>
			public static readonly XrmFakedRelationship MsdynAitemplateSyncErrors = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "msdyn_aitemplateid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "msdyn_aitemplate",
					Entity2LogicalName = "syncerror",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

		}
		#endregion

		#region Fake
		public static AITemplate Create()
		{
			var faker = new Faker<AITemplate>()
			.RuleFor(e => e.ComponentState, fake => fake.PickRandom<AITemplate.egComponentState>())
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
			.RuleFor(e => e.MsdynAitemplateiduniqueId, fake => Guid.NewGuid())
			.RuleFor(e => e.DataBinding, fake => fake.Lorem.Word())
			.RuleFor(e => e.DefaultRunSchedulingOptions, fake => fake.Lorem.Word())
			.RuleFor(e => e.IsTrainable, fake => fake.Random.Bool())
			.RuleFor(e => e.ResourceInfo, fake => fake.Lorem.Word())
			.RuleFor(e => e.RunConfigSchema, fake => fake.Lorem.Word())
			.RuleFor(e => e.RunDataSpecification, fake => fake.Lorem.Word())
			.RuleFor(e => e.TemplateVersion, fake => fake.Random.Int())
			.RuleFor(e => e.TrainingConfigSchema, fake => fake.Lorem.Word())
			.RuleFor(e => e.TrainingDataSpecification, fake => fake.Lorem.Word())
			.RuleFor(e => e.UniqueName, fake => fake.Lorem.Word())
			.RuleFor(e => e.UXConfiguration, fake => fake.Lorem.Word())
			.RuleFor(e => e.RecordCreatedOn, fake => fake.Date.Soon())
			.RuleFor(e => e.RecordOverwriteTime, fake => fake.Date.Soon())
			.RuleFor(e => e.Owneridname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Owneridtype, fake => fake.Lorem.Word())
			.RuleFor(e => e.Owneridyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.SolutionId, fake => Guid.NewGuid())
			.RuleFor(e => e.Status, fake => fake.PickRandom<AITemplate.eStatus>())
			.RuleFor(e => e.StatusReason, fake => fake.PickRandom<AITemplate.eStatusReason>())
			.RuleFor(e => e.SolutionId2, fake => Guid.NewGuid())
			.RuleFor(e => e.TimeZoneRuleVersionNumber, fake => fake.Random.Int())
			.RuleFor(e => e.UTCConversionTimeZoneCode, fake => fake.Random.Int())
			.RuleFor(e => e.VersionNumber, fake => fake.Random.Int());
			return faker.Generate();
		}
		#endregion
	}
}

