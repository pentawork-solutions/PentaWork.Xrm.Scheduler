using Bogus;
using System;
using FakeXrmEasy;
using System.Collections.Generic;
using PentaWork.Xrm.Scheduler.Proxies.Entities;

namespace PentaWork.Xrm.Scheduler.Tests.Fake
{
	public static class FakeMicrosoftTeamsGraphResourceEntity
	{	
		#region FakeRelationships
		public static class Relationships 
		{
			/// <summary>1:N msdyn_collabgraphresource_AsyncOperations</summary>
			public static readonly XrmFakedRelationship MsdynCollabgraphresourceAsyncOperations = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "msdyn_collabgraphresourceid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "msdyn_collabgraphresource",
					Entity2LogicalName = "asyncoperation",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N msdyn_collabgraphresource_BulkDeleteFailures</summary>
			public static readonly XrmFakedRelationship MsdynCollabgraphresourceBulkDeleteFailures = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "msdyn_collabgraphresourceid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "msdyn_collabgraphresource",
					Entity2LogicalName = "bulkdeletefailure",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N msdyn_collabgraphresource_MailboxTrackingFolders</summary>
			public static readonly XrmFakedRelationship MsdynCollabgraphresourceMailboxTrackingFolders = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "msdyn_collabgraphresourceid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "msdyn_collabgraphresource",
					Entity2LogicalName = "mailboxtrackingfolder",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N msdyn_collabgraphresource_PrincipalObjectAttributeAccesses</summary>
			public static readonly XrmFakedRelationship MsdynCollabgraphresourcePrincipalObjectAttributeAccesses = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "msdyn_collabgraphresourceid",
					Entity2Attribute = "objectid",
					Entity1LogicalName = "msdyn_collabgraphresource",
					Entity2LogicalName = "principalobjectattributeaccess",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N msdyn_collabgraphresource_ProcessSession</summary>
			public static readonly XrmFakedRelationship MsdynCollabgraphresourceProcessSession = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "msdyn_collabgraphresourceid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "msdyn_collabgraphresource",
					Entity2LogicalName = "processsession",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N msdyn_collabgraphresource_SyncErrors</summary>
			public static readonly XrmFakedRelationship MsdynCollabgraphresourceSyncErrors = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "msdyn_collabgraphresourceid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "msdyn_collabgraphresource",
					Entity2LogicalName = "syncerror",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

		}
		#endregion

		#region Fake
		public static MicrosoftTeamsGraphResourceEntity Create()
		{
			var faker = new Faker<MicrosoftTeamsGraphResourceEntity>()
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
			.RuleFor(e => e.MicrosoftTeamsGraphResourceIdentifierId, fake => Guid.NewGuid())
			.RuleFor(e => e.CollaborationGraphResourceName, fake => fake.Lorem.Word())
			.RuleFor(e => e.RecordCreatedOn, fake => fake.Date.Soon())
			.RuleFor(e => e.Status, fake => fake.PickRandom<MicrosoftTeamsGraphResourceEntity.eStatus>())
			.RuleFor(e => e.StatusReason, fake => fake.PickRandom<MicrosoftTeamsGraphResourceEntity.eStatusReason>())
			.RuleFor(e => e.TimeZoneRuleVersionNumber, fake => fake.Random.Int())
			.RuleFor(e => e.UTCConversionTimeZoneCode, fake => fake.Random.Int())
			.RuleFor(e => e.VersionNumber, fake => fake.Random.Int());
			return faker.Generate();
		}
		#endregion
	}
}

