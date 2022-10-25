using Bogus;
using System;
using FakeXrmEasy;
using System.Collections.Generic;
using PentaWork.Xrm.Scheduler.Proxies.Entities;

namespace PentaWork.Xrm.Scheduler.Tests.Fake
{
	public static class FakeContractTemplate
	{	
		#region FakeRelationships
		public static class Relationships 
		{
			/// <summary>1:N contract_template_contracts</summary>
			public static readonly XrmFakedRelationship ContractTemplateContracts = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "contracttemplateid",
					Entity2Attribute = "contracttemplateid",
					Entity1LogicalName = "contracttemplate",
					Entity2LogicalName = "contract",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N ContractTemplate_AsyncOperations</summary>
			public static readonly XrmFakedRelationship ContractTemplateAsyncOperations = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "contracttemplateid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "contracttemplate",
					Entity2LogicalName = "asyncoperation",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N ContractTemplate_BulkDeleteFailures</summary>
			public static readonly XrmFakedRelationship ContractTemplateBulkDeleteFailures = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "contracttemplateid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "contracttemplate",
					Entity2LogicalName = "bulkdeletefailure",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N contracttemplate_MailboxTrackingFolders</summary>
			public static readonly XrmFakedRelationship ContracttemplateMailboxTrackingFolders = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "contracttemplateid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "contracttemplate",
					Entity2LogicalName = "mailboxtrackingfolder",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N contracttemplate_PrincipalObjectAttributeAccesses</summary>
			public static readonly XrmFakedRelationship ContracttemplatePrincipalObjectAttributeAccesses = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "contracttemplateid",
					Entity2Attribute = "objectid",
					Entity1LogicalName = "contracttemplate",
					Entity2LogicalName = "principalobjectattributeaccess",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N ContractTemplate_ProcessSessions</summary>
			public static readonly XrmFakedRelationship ContractTemplateProcessSessions = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "contracttemplateid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "contracttemplate",
					Entity2LogicalName = "processsession",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N ContractTemplate_SyncErrors</summary>
			public static readonly XrmFakedRelationship ContractTemplateSyncErrors = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "contracttemplateid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "contracttemplate",
					Entity2LogicalName = "syncerror",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

		}
		#endregion

		#region Fake
		public static ContractTemplate Create()
		{
			var faker = new Faker<ContractTemplate>()
			.RuleFor(e => e.Abbreviation, fake => fake.Lorem.Word())
			.RuleFor(e => e.AllotmentType, fake => fake.PickRandom<ContractTemplate.eAllotmentType>())
			.RuleFor(e => e.BillingFrequency, fake => fake.PickRandom<ContractTemplate.eBillingFrequency>())
			.RuleFor(e => e.ComponentState, fake => fake.PickRandom<ContractTemplate.egComponentState>())
			.RuleFor(e => e.ContractServiceLevel, fake => fake.PickRandom<ContractTemplate.eContractServiceLevel>())
			.RuleFor(e => e.Id, fake => Guid.NewGuid())
			.RuleFor(e => e.ContracttemplateiduniqueId, fake => Guid.NewGuid())
			.RuleFor(e => e.Createdbyname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Createdbyyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.CreatedOn, fake => fake.Date.Soon())
			.RuleFor(e => e.Createdonbehalfbyname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Createdonbehalfbyyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.Description, fake => fake.Lorem.Word())
			.RuleFor(e => e.SupportCalendar, fake => fake.Lorem.Word())
			.RuleFor(e => e.ImportSequenceNumber, fake => fake.Random.Int())
			.RuleFor(e => e.IntroducedVersion, fake => fake.Lorem.Word())
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
			.RuleFor(e => e.SolutionId, fake => Guid.NewGuid())
			.RuleFor(e => e.SolutionId2, fake => Guid.NewGuid())
			.RuleFor(e => e.TimeZoneRuleVersionNumber, fake => fake.Random.Int())
			.RuleFor(e => e.UseDiscountAsPercentage, fake => fake.Random.Bool())
			.RuleFor(e => e.UTCConversionTimeZoneCode, fake => fake.Random.Int())
			.RuleFor(e => e.VersionNumber, fake => fake.Random.Int());
			return faker.Generate();
		}
		#endregion
	}
}

