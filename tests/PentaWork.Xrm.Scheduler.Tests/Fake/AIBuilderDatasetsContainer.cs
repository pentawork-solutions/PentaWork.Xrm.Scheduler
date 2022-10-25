using Bogus;
using System;
using FakeXrmEasy;
using System.Collections.Generic;
using PentaWork.Xrm.Scheduler.Proxies.Entities;

namespace PentaWork.Xrm.Scheduler.Tests.Fake
{
	public static class FakeAIBuilderDatasetsContainer
	{	
		#region FakeRelationships
		public static class Relationships 
		{
			/// <summary>1:N msdyn_AIBDataset_msdyn_AIBDatasetsContain</summary>
			public static readonly XrmFakedRelationship MsdynAIBDatasetMsdynAIBDatasetsContain = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "msdyn_aibdatasetscontainerid",
					Entity2Attribute = "msdyn_aibdatasetscontainerid",
					Entity1LogicalName = "msdyn_aibdatasetscontainer",
					Entity2LogicalName = "msdyn_aibdataset",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N msdyn_aibdatasetscontainer_AsyncOperations</summary>
			public static readonly XrmFakedRelationship MsdynAibdatasetscontainerAsyncOperations = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "msdyn_aibdatasetscontainerid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "msdyn_aibdatasetscontainer",
					Entity2LogicalName = "asyncoperation",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N msdyn_aibdatasetscontainer_BulkDeleteFailures</summary>
			public static readonly XrmFakedRelationship MsdynAibdatasetscontainerBulkDeleteFailures = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "msdyn_aibdatasetscontainerid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "msdyn_aibdatasetscontainer",
					Entity2LogicalName = "bulkdeletefailure",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N msdyn_aibdatasetscontainer_DuplicateBaseRecord</summary>
			public static readonly XrmFakedRelationship MsdynAibdatasetscontainerDuplicateBaseRecord = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "msdyn_aibdatasetscontainerid",
					Entity2Attribute = "baserecordid",
					Entity1LogicalName = "msdyn_aibdatasetscontainer",
					Entity2LogicalName = "duplicaterecord",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N msdyn_aibdatasetscontainer_DuplicateMatchingRecord</summary>
			public static readonly XrmFakedRelationship MsdynAibdatasetscontainerDuplicateMatchingRecord = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "msdyn_aibdatasetscontainerid",
					Entity2Attribute = "duplicaterecordid",
					Entity1LogicalName = "msdyn_aibdatasetscontainer",
					Entity2LogicalName = "duplicaterecord",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N msdyn_aibdatasetscontainer_MailboxTrackingFolders</summary>
			public static readonly XrmFakedRelationship MsdynAibdatasetscontainerMailboxTrackingFolders = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "msdyn_aibdatasetscontainerid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "msdyn_aibdatasetscontainer",
					Entity2LogicalName = "mailboxtrackingfolder",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N msdyn_aibdatasetscontainer_PrincipalObjectAttributeAccesses</summary>
			public static readonly XrmFakedRelationship MsdynAibdatasetscontainerPrincipalObjectAttributeAccesses = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "msdyn_aibdatasetscontainerid",
					Entity2Attribute = "objectid",
					Entity1LogicalName = "msdyn_aibdatasetscontainer",
					Entity2LogicalName = "principalobjectattributeaccess",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N msdyn_aibdatasetscontainer_ProcessSession</summary>
			public static readonly XrmFakedRelationship MsdynAibdatasetscontainerProcessSession = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "msdyn_aibdatasetscontainerid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "msdyn_aibdatasetscontainer",
					Entity2LogicalName = "processsession",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N msdyn_aibdatasetscontainer_SyncErrors</summary>
			public static readonly XrmFakedRelationship MsdynAibdatasetscontainerSyncErrors = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "msdyn_aibdatasetscontainerid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "msdyn_aibdatasetscontainer",
					Entity2LogicalName = "syncerror",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N msdyn_AIBFile_msdyn_AIBDatasetsCont</summary>
			public static readonly XrmFakedRelationship MsdynAIBFileMsdynAIBDatasetsCont = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "msdyn_aibdatasetscontainerid",
					Entity2Attribute = "msdyn_aibdatasetscontainerid",
					Entity1LogicalName = "msdyn_aibdatasetscontainer",
					Entity2LogicalName = "msdyn_aibfile",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

		}
		#endregion

		#region Fake
		public static AIBuilderDatasetsContainer Create()
		{
			var faker = new Faker<AIBuilderDatasetsContainer>()
			.RuleFor(e => e.Createdbyname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Createdbyyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.CreatedOn, fake => fake.Date.Soon())
			.RuleFor(e => e.Createdonbehalfbyname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Createdonbehalfbyyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.ImportSequenceNumber, fake => fake.Random.Int())
			.RuleFor(e => e.Modifiedbyname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Modifiedbyyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.ModifiedOn, fake => fake.Date.Soon())
			.RuleFor(e => e.Modifiedonbehalfbyname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Modifiedonbehalfbyyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.Id, fake => Guid.NewGuid())
			.RuleFor(e => e.MsdynAimodelidname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Name, fake => fake.Lorem.Word())
			.RuleFor(e => e.RecordCreatedOn, fake => fake.Date.Soon())
			.RuleFor(e => e.Owneridname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Owneridtype, fake => fake.Lorem.Word())
			.RuleFor(e => e.Owneridyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.Status, fake => fake.PickRandom<AIBuilderDatasetsContainer.eStatus>())
			.RuleFor(e => e.StatusReason, fake => fake.PickRandom<AIBuilderDatasetsContainer.eStatusReason>())
			.RuleFor(e => e.TimeZoneRuleVersionNumber, fake => fake.Random.Int())
			.RuleFor(e => e.UTCConversionTimeZoneCode, fake => fake.Random.Int())
			.RuleFor(e => e.VersionNumber, fake => fake.Random.Int());
			return faker.Generate();
		}
		#endregion
	}
}

