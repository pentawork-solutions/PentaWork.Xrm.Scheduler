using Bogus;
using System;
using FakeXrmEasy;
using System.Collections.Generic;
using PentaWork.Xrm.Scheduler.Proxies.Entities;

namespace PentaWork.Xrm.Scheduler.Tests.Fake
{
	public static class FakeAIFormProcessingDocument
	{	
		#region FakeRelationships
		public static class Relationships 
		{
			/// <summary>1:N msdyn_aifptrainingdocument_Annotations</summary>
			public static readonly XrmFakedRelationship MsdynAifptrainingdocumentAnnotations = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "msdyn_aifptrainingdocumentid",
					Entity2Attribute = "objectid",
					Entity1LogicalName = "msdyn_aifptrainingdocument",
					Entity2LogicalName = "annotation",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N msdyn_aifptrainingdocument_AsyncOperations</summary>
			public static readonly XrmFakedRelationship MsdynAifptrainingdocumentAsyncOperations = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "msdyn_aifptrainingdocumentid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "msdyn_aifptrainingdocument",
					Entity2LogicalName = "asyncoperation",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N msdyn_aifptrainingdocument_BulkDeleteFailures</summary>
			public static readonly XrmFakedRelationship MsdynAifptrainingdocumentBulkDeleteFailures = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "msdyn_aifptrainingdocumentid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "msdyn_aifptrainingdocument",
					Entity2LogicalName = "bulkdeletefailure",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N msdyn_aifptrainingdocument_MailboxTrackingFolders</summary>
			public static readonly XrmFakedRelationship MsdynAifptrainingdocumentMailboxTrackingFolders = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "msdyn_aifptrainingdocumentid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "msdyn_aifptrainingdocument",
					Entity2LogicalName = "mailboxtrackingfolder",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N msdyn_aifptrainingdocument_PrincipalObjectAttributeAccesses</summary>
			public static readonly XrmFakedRelationship MsdynAifptrainingdocumentPrincipalObjectAttributeAccesses = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "msdyn_aifptrainingdocumentid",
					Entity2Attribute = "objectid",
					Entity1LogicalName = "msdyn_aifptrainingdocument",
					Entity2LogicalName = "principalobjectattributeaccess",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N msdyn_aifptrainingdocument_ProcessSession</summary>
			public static readonly XrmFakedRelationship MsdynAifptrainingdocumentProcessSession = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "msdyn_aifptrainingdocumentid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "msdyn_aifptrainingdocument",
					Entity2LogicalName = "processsession",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N msdyn_aifptrainingdocument_SyncErrors</summary>
			public static readonly XrmFakedRelationship MsdynAifptrainingdocumentSyncErrors = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "msdyn_aifptrainingdocumentid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "msdyn_aifptrainingdocument",
					Entity2LogicalName = "syncerror",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

		}
		#endregion

		#region Fake
		public static AIFormProcessingDocument Create()
		{
			var faker = new Faker<AIFormProcessingDocument>()
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
			.RuleFor(e => e.MsdynAiconfigurationidname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Id, fake => Guid.NewGuid())
			.RuleFor(e => e.Checksum, fake => fake.Lorem.Word())
			.RuleFor(e => e.Metadata, fake => fake.Lorem.Word())
			.RuleFor(e => e.Name, fake => fake.Lorem.Word())
			.RuleFor(e => e.SourceType, fake => fake.Lorem.Word())
			.RuleFor(e => e.RecordCreatedOn, fake => fake.Date.Soon())
			.RuleFor(e => e.Owneridname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Owneridtype, fake => fake.Lorem.Word())
			.RuleFor(e => e.Owneridyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.Status, fake => fake.PickRandom<AIFormProcessingDocument.eStatus>())
			.RuleFor(e => e.StatusReason, fake => fake.PickRandom<AIFormProcessingDocument.eStatusReason>())
			.RuleFor(e => e.TimeZoneRuleVersionNumber, fake => fake.Random.Int())
			.RuleFor(e => e.UTCConversionTimeZoneCode, fake => fake.Random.Int())
			.RuleFor(e => e.VersionNumber, fake => fake.Random.Int());
			return faker.Generate();
		}
		#endregion
	}
}

