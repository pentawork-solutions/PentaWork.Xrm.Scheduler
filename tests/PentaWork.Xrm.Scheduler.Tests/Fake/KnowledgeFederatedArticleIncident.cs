using Bogus;
using System;
using FakeXrmEasy;
using System.Collections.Generic;
using PentaWork.Xrm.Scheduler.Proxies.Entities;

namespace PentaWork.Xrm.Scheduler.Tests.Fake
{
	public static class FakeKnowledgeFederatedArticleIncident
	{	
		#region FakeRelationships
		public static class Relationships 
		{
			/// <summary>1:N msdyn_federatedarticleincident_AsyncOperations</summary>
			public static readonly XrmFakedRelationship MsdynFederatedarticleincidentAsyncOperations = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "msdyn_federatedarticleincidentid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "msdyn_federatedarticleincident",
					Entity2LogicalName = "asyncoperation",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N msdyn_federatedarticleincident_BulkDeleteFailures</summary>
			public static readonly XrmFakedRelationship MsdynFederatedarticleincidentBulkDeleteFailures = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "msdyn_federatedarticleincidentid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "msdyn_federatedarticleincident",
					Entity2LogicalName = "bulkdeletefailure",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N msdyn_federatedarticleincident_DuplicateBaseRecord</summary>
			public static readonly XrmFakedRelationship MsdynFederatedarticleincidentDuplicateBaseRecord = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "msdyn_federatedarticleincidentid",
					Entity2Attribute = "baserecordid",
					Entity1LogicalName = "msdyn_federatedarticleincident",
					Entity2LogicalName = "duplicaterecord",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N msdyn_federatedarticleincident_DuplicateMatchingRecord</summary>
			public static readonly XrmFakedRelationship MsdynFederatedarticleincidentDuplicateMatchingRecord = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "msdyn_federatedarticleincidentid",
					Entity2Attribute = "duplicaterecordid",
					Entity1LogicalName = "msdyn_federatedarticleincident",
					Entity2LogicalName = "duplicaterecord",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N msdyn_federatedarticleincident_MailboxTrackingFolders</summary>
			public static readonly XrmFakedRelationship MsdynFederatedarticleincidentMailboxTrackingFolders = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "msdyn_federatedarticleincidentid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "msdyn_federatedarticleincident",
					Entity2LogicalName = "mailboxtrackingfolder",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N msdyn_federatedarticleincident_PrincipalObjectAttributeAccesses</summary>
			public static readonly XrmFakedRelationship MsdynFederatedarticleincidentPrincipalObjectAttributeAccesses = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "msdyn_federatedarticleincidentid",
					Entity2Attribute = "objectid",
					Entity1LogicalName = "msdyn_federatedarticleincident",
					Entity2LogicalName = "principalobjectattributeaccess",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N msdyn_federatedarticleincident_ProcessSession</summary>
			public static readonly XrmFakedRelationship MsdynFederatedarticleincidentProcessSession = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "msdyn_federatedarticleincidentid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "msdyn_federatedarticleincident",
					Entity2LogicalName = "processsession",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N msdyn_federatedarticleincident_SyncErrors</summary>
			public static readonly XrmFakedRelationship MsdynFederatedarticleincidentSyncErrors = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "msdyn_federatedarticleincidentid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "msdyn_federatedarticleincident",
					Entity2LogicalName = "syncerror",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

		}
		#endregion

		#region Fake
		public static KnowledgeFederatedArticleIncident Create()
		{
			var faker = new Faker<KnowledgeFederatedArticleIncident>()
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
			.RuleFor(e => e.MsdynFederatedarticleidname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Id, fake => Guid.NewGuid())
			.RuleFor(e => e.Name, fake => fake.Lorem.Word())
			.RuleFor(e => e.SearchProviderArticleId, fake => fake.Lorem.Word())
			.RuleFor(e => e.Organizationidname, fake => fake.Lorem.Word())
			.RuleFor(e => e.RecordCreatedOn, fake => fake.Date.Soon())
			.RuleFor(e => e.Status, fake => fake.PickRandom<KnowledgeFederatedArticleIncident.eStatus>())
			.RuleFor(e => e.StatusReason, fake => fake.PickRandom<KnowledgeFederatedArticleIncident.eStatusReason>())
			.RuleFor(e => e.TimeZoneRuleVersionNumber, fake => fake.Random.Int())
			.RuleFor(e => e.UTCConversionTimeZoneCode, fake => fake.Random.Int())
			.RuleFor(e => e.VersionNumber, fake => fake.Random.Int());
			return faker.Generate();
		}
		#endregion
	}
}

