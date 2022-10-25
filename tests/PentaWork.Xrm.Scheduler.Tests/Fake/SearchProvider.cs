using Bogus;
using System;
using FakeXrmEasy;
using System.Collections.Generic;
using PentaWork.Xrm.Scheduler.Proxies.Entities;

namespace PentaWork.Xrm.Scheduler.Tests.Fake
{
	public static class FakeSearchProvider
	{	
		#region FakeRelationships
		public static class Relationships 
		{
			/// <summary>1:N IK_msdyn_kmfederatedsearchconfig_msdyn_federatedarticle_searchproviderid</summary>
			public static readonly XrmFakedRelationship IKMsdynKmfederatedsearchconfigMsdynFederatedarticleSearchproviderid = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "msdyn_kmfederatedsearchconfigid",
					Entity2Attribute = "msdyn_searchproviderid",
					Entity1LogicalName = "msdyn_kmfederatedsearchconfig",
					Entity2LogicalName = "msdyn_federatedarticle",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N msdyn_kmfederatedsearchconfig_AsyncOperations</summary>
			public static readonly XrmFakedRelationship MsdynKmfederatedsearchconfigAsyncOperations = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "msdyn_kmfederatedsearchconfigid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "msdyn_kmfederatedsearchconfig",
					Entity2LogicalName = "asyncoperation",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N msdyn_kmfederatedsearchconfig_BulkDeleteFailures</summary>
			public static readonly XrmFakedRelationship MsdynKmfederatedsearchconfigBulkDeleteFailures = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "msdyn_kmfederatedsearchconfigid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "msdyn_kmfederatedsearchconfig",
					Entity2LogicalName = "bulkdeletefailure",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N msdyn_kmfederatedsearchconfig_DuplicateBaseRecord</summary>
			public static readonly XrmFakedRelationship MsdynKmfederatedsearchconfigDuplicateBaseRecord = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "msdyn_kmfederatedsearchconfigid",
					Entity2Attribute = "baserecordid",
					Entity1LogicalName = "msdyn_kmfederatedsearchconfig",
					Entity2LogicalName = "duplicaterecord",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N msdyn_kmfederatedsearchconfig_DuplicateMatchingRecord</summary>
			public static readonly XrmFakedRelationship MsdynKmfederatedsearchconfigDuplicateMatchingRecord = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "msdyn_kmfederatedsearchconfigid",
					Entity2Attribute = "duplicaterecordid",
					Entity1LogicalName = "msdyn_kmfederatedsearchconfig",
					Entity2LogicalName = "duplicaterecord",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N msdyn_kmfederatedsearchconfig_MailboxTrackingFolders</summary>
			public static readonly XrmFakedRelationship MsdynKmfederatedsearchconfigMailboxTrackingFolders = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "msdyn_kmfederatedsearchconfigid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "msdyn_kmfederatedsearchconfig",
					Entity2LogicalName = "mailboxtrackingfolder",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N msdyn_kmfederatedsearchconfig_PrincipalObjectAttributeAccesses</summary>
			public static readonly XrmFakedRelationship MsdynKmfederatedsearchconfigPrincipalObjectAttributeAccesses = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "msdyn_kmfederatedsearchconfigid",
					Entity2Attribute = "objectid",
					Entity1LogicalName = "msdyn_kmfederatedsearchconfig",
					Entity2LogicalName = "principalobjectattributeaccess",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N msdyn_kmfederatedsearchconfig_ProcessSession</summary>
			public static readonly XrmFakedRelationship MsdynKmfederatedsearchconfigProcessSession = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "msdyn_kmfederatedsearchconfigid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "msdyn_kmfederatedsearchconfig",
					Entity2LogicalName = "processsession",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N msdyn_kmfederatedsearchconfig_SyncErrors</summary>
			public static readonly XrmFakedRelationship MsdynKmfederatedsearchconfigSyncErrors = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "msdyn_kmfederatedsearchconfigid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "msdyn_kmfederatedsearchconfig",
					Entity2LogicalName = "syncerror",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

		}
		#endregion

		#region Fake
		public static SearchProvider Create()
		{
			var faker = new Faker<SearchProvider>()
			.RuleFor(e => e.ConnectionId, fake => fake.Lorem.Word())
			.RuleFor(e => e.Createdbyname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Createdbyyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.CreatedOn, fake => fake.Date.Soon())
			.RuleFor(e => e.Createdonbehalfbyname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Createdonbehalfbyyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.ImportSequenceNumber, fake => fake.Random.Int())
			.RuleFor(e => e.IsDefault, fake => fake.Random.Bool())
			.RuleFor(e => e.Modifiedbyname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Modifiedbyyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.ModifiedOn, fake => fake.Date.Soon())
			.RuleFor(e => e.Modifiedonbehalfbyname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Modifiedonbehalfbyyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.Description, fake => fake.Lorem.Word())
			.RuleFor(e => e.Id, fake => Guid.NewGuid())
			.RuleFor(e => e.Name, fake => fake.Lorem.Word())
			.RuleFor(e => e.Organization, fake => fake.Lorem.Word())
			.RuleFor(e => e.RecordCreatedOn, fake => fake.Date.Soon())
			.RuleFor(e => e.Owneridname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Owneridtype, fake => fake.Lorem.Word())
			.RuleFor(e => e.Owneridyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.SearchType, fake => fake.PickRandom<SearchProvider.eSearchType>())
			.RuleFor(e => e.SharepointURL, fake => fake.Lorem.Word())
			.RuleFor(e => e.Status, fake => fake.PickRandom<SearchProvider.eStatus>())
			.RuleFor(e => e.StatusReason, fake => fake.PickRandom<SearchProvider.eStatusReason>())
			.RuleFor(e => e.TimeZoneRuleVersionNumber, fake => fake.Random.Int())
			.RuleFor(e => e.UTCConversionTimeZoneCode, fake => fake.Random.Int())
			.RuleFor(e => e.VersionNumber, fake => fake.Random.Int());
			return faker.Generate();
		}
		#endregion
	}
}

