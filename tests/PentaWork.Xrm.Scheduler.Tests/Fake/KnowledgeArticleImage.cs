using Bogus;
using System;
using FakeXrmEasy;
using System.Collections.Generic;
using PentaWork.Xrm.Scheduler.Proxies.Entities;

namespace PentaWork.Xrm.Scheduler.Tests.Fake
{
	public static class FakeKnowledgeArticleImage
	{	
		#region FakeRelationships
		public static class Relationships 
		{
			/// <summary>1:N msdyn_knowledgearticleimage_AsyncOperations</summary>
			public static readonly XrmFakedRelationship MsdynKnowledgearticleimageAsyncOperations = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "msdyn_knowledgearticleimageid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "msdyn_knowledgearticleimage",
					Entity2LogicalName = "asyncoperation",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N msdyn_knowledgearticleimage_BulkDeleteFailures</summary>
			public static readonly XrmFakedRelationship MsdynKnowledgearticleimageBulkDeleteFailures = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "msdyn_knowledgearticleimageid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "msdyn_knowledgearticleimage",
					Entity2LogicalName = "bulkdeletefailure",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N msdyn_knowledgearticleimage_DuplicateBaseRecord</summary>
			public static readonly XrmFakedRelationship MsdynKnowledgearticleimageDuplicateBaseRecord = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "msdyn_knowledgearticleimageid",
					Entity2Attribute = "baserecordid",
					Entity1LogicalName = "msdyn_knowledgearticleimage",
					Entity2LogicalName = "duplicaterecord",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N msdyn_knowledgearticleimage_DuplicateMatchingRecord</summary>
			public static readonly XrmFakedRelationship MsdynKnowledgearticleimageDuplicateMatchingRecord = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "msdyn_knowledgearticleimageid",
					Entity2Attribute = "duplicaterecordid",
					Entity1LogicalName = "msdyn_knowledgearticleimage",
					Entity2LogicalName = "duplicaterecord",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N msdyn_knowledgearticleimage_FileAttachments</summary>
			public static readonly XrmFakedRelationship MsdynKnowledgearticleimageFileAttachments = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "msdyn_knowledgearticleimageid",
					Entity2Attribute = "objectid",
					Entity1LogicalName = "msdyn_knowledgearticleimage",
					Entity2LogicalName = "fileattachment",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N msdyn_knowledgearticleimage_MailboxTrackingFolders</summary>
			public static readonly XrmFakedRelationship MsdynKnowledgearticleimageMailboxTrackingFolders = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "msdyn_knowledgearticleimageid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "msdyn_knowledgearticleimage",
					Entity2LogicalName = "mailboxtrackingfolder",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N msdyn_knowledgearticleimage_PrincipalObjectAttributeAccesses</summary>
			public static readonly XrmFakedRelationship MsdynKnowledgearticleimagePrincipalObjectAttributeAccesses = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "msdyn_knowledgearticleimageid",
					Entity2Attribute = "objectid",
					Entity1LogicalName = "msdyn_knowledgearticleimage",
					Entity2LogicalName = "principalobjectattributeaccess",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N msdyn_knowledgearticleimage_ProcessSession</summary>
			public static readonly XrmFakedRelationship MsdynKnowledgearticleimageProcessSession = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "msdyn_knowledgearticleimageid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "msdyn_knowledgearticleimage",
					Entity2LogicalName = "processsession",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N msdyn_knowledgearticleimage_SyncErrors</summary>
			public static readonly XrmFakedRelationship MsdynKnowledgearticleimageSyncErrors = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "msdyn_knowledgearticleimageid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "msdyn_knowledgearticleimage",
					Entity2LogicalName = "syncerror",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

		}
		#endregion

		#region Fake
		public static KnowledgeArticleImage Create()
		{
			var faker = new Faker<KnowledgeArticleImage>()
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
			.RuleFor(e => e.MsdynBlobfileName, fake => fake.Lorem.Word())
			.RuleFor(e => e.FileName, fake => fake.Lorem.Word())
			.RuleFor(e => e.Id, fake => Guid.NewGuid())
			.RuleFor(e => e.RecordCreatedOn, fake => fake.Date.Soon())
			.RuleFor(e => e.Owneridname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Owneridtype, fake => fake.Lorem.Word())
			.RuleFor(e => e.Owneridyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.Status, fake => fake.PickRandom<KnowledgeArticleImage.eStatus>())
			.RuleFor(e => e.StatusReason, fake => fake.PickRandom<KnowledgeArticleImage.eStatusReason>())
			.RuleFor(e => e.TimeZoneRuleVersionNumber, fake => fake.Random.Int())
			.RuleFor(e => e.UTCConversionTimeZoneCode, fake => fake.Random.Int())
			.RuleFor(e => e.VersionNumber, fake => fake.Random.Int());
			return faker.Generate();
		}
		#endregion
	}
}

