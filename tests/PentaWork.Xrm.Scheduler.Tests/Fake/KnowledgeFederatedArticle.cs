using Bogus;
using System;
using FakeXrmEasy;
using System.Collections.Generic;
using PentaWork.Xrm.Scheduler.Proxies.Entities;

namespace PentaWork.Xrm.Scheduler.Tests.Fake
{
	public static class FakeKnowledgeFederatedArticle
	{	
		#region FakeRelationships
		public static class Relationships 
		{
			/// <summary>1:N msdyn_federatedarticle_AsyncOperations</summary>
			public static readonly XrmFakedRelationship MsdynFederatedarticleAsyncOperations = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "msdyn_federatedarticleid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "msdyn_federatedarticle",
					Entity2LogicalName = "asyncoperation",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N msdyn_federatedarticle_BulkDeleteFailures</summary>
			public static readonly XrmFakedRelationship MsdynFederatedarticleBulkDeleteFailures = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "msdyn_federatedarticleid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "msdyn_federatedarticle",
					Entity2LogicalName = "bulkdeletefailure",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N msdyn_federatedarticle_DuplicateBaseRecord</summary>
			public static readonly XrmFakedRelationship MsdynFederatedarticleDuplicateBaseRecord = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "msdyn_federatedarticleid",
					Entity2Attribute = "baserecordid",
					Entity1LogicalName = "msdyn_federatedarticle",
					Entity2LogicalName = "duplicaterecord",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N msdyn_federatedarticle_DuplicateMatchingRecord</summary>
			public static readonly XrmFakedRelationship MsdynFederatedarticleDuplicateMatchingRecord = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "msdyn_federatedarticleid",
					Entity2Attribute = "duplicaterecordid",
					Entity1LogicalName = "msdyn_federatedarticle",
					Entity2LogicalName = "duplicaterecord",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N msdyn_federatedarticle_MailboxTrackingFolders</summary>
			public static readonly XrmFakedRelationship MsdynFederatedarticleMailboxTrackingFolders = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "msdyn_federatedarticleid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "msdyn_federatedarticle",
					Entity2LogicalName = "mailboxtrackingfolder",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N msdyn_federatedarticle_msdyn_federatedarticleincident_federatedarticleId</summary>
			public static readonly XrmFakedRelationship MsdynFederatedarticleMsdynFederatedarticleincidentFederatedarticleId = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "msdyn_federatedarticleid",
					Entity2Attribute = "msdyn_federatedarticleid",
					Entity1LogicalName = "msdyn_federatedarticle",
					Entity2LogicalName = "msdyn_federatedarticleincident",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N msdyn_federatedarticle_PrincipalObjectAttributeAccesses</summary>
			public static readonly XrmFakedRelationship MsdynFederatedarticlePrincipalObjectAttributeAccesses = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "msdyn_federatedarticleid",
					Entity2Attribute = "objectid",
					Entity1LogicalName = "msdyn_federatedarticle",
					Entity2LogicalName = "principalobjectattributeaccess",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N msdyn_federatedarticle_ProcessSession</summary>
			public static readonly XrmFakedRelationship MsdynFederatedarticleProcessSession = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "msdyn_federatedarticleid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "msdyn_federatedarticle",
					Entity2LogicalName = "processsession",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N msdyn_federatedarticle_SyncErrors</summary>
			public static readonly XrmFakedRelationship MsdynFederatedarticleSyncErrors = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "msdyn_federatedarticleid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "msdyn_federatedarticle",
					Entity2LogicalName = "syncerror",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

		}
		#endregion

		#region Fake
		public static KnowledgeFederatedArticle Create()
		{
			var faker = new Faker<KnowledgeFederatedArticle>()
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
			.RuleFor(e => e.FederatedSearchProviderArticleId, fake => fake.Lorem.Word())
			.RuleFor(e => e.MsdynSearchprovideridname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Title, fake => fake.Lorem.Word())
			.RuleFor(e => e.URL, fake => fake.Lorem.Word())
			.RuleFor(e => e.RecordCreatedOn, fake => fake.Date.Soon())
			.RuleFor(e => e.Owneridname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Owneridtype, fake => fake.Lorem.Word())
			.RuleFor(e => e.Owneridyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.Status, fake => fake.PickRandom<KnowledgeFederatedArticle.eStatus>())
			.RuleFor(e => e.StatusReason, fake => fake.PickRandom<KnowledgeFederatedArticle.eStatusReason>())
			.RuleFor(e => e.TimeZoneRuleVersionNumber, fake => fake.Random.Int())
			.RuleFor(e => e.UTCConversionTimeZoneCode, fake => fake.Random.Int())
			.RuleFor(e => e.VersionNumber, fake => fake.Random.Int());
			return faker.Generate();
		}
		#endregion
	}
}

