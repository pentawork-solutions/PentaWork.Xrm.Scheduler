using Bogus;
using System;
using FakeXrmEasy;
using System.Collections.Generic;
using PentaWork.Xrm.Scheduler.Proxies.Entities;

namespace PentaWork.Xrm.Scheduler.Tests.Fake
{
	public static class FakeMicrosoftTeamsCollaborationEntity
	{	
		#region FakeRelationships
		public static class Relationships 
		{
			/// <summary>1:N msdyn_teamscollaboration_AsyncOperations</summary>
			public static readonly XrmFakedRelationship MsdynTeamscollaborationAsyncOperations = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "msdyn_teamscollaborationid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "msdyn_teamscollaboration",
					Entity2LogicalName = "asyncoperation",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N msdyn_teamscollaboration_BulkDeleteFailures</summary>
			public static readonly XrmFakedRelationship MsdynTeamscollaborationBulkDeleteFailures = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "msdyn_teamscollaborationid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "msdyn_teamscollaboration",
					Entity2LogicalName = "bulkdeletefailure",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N msdyn_teamscollaboration_MailboxTrackingFolders</summary>
			public static readonly XrmFakedRelationship MsdynTeamscollaborationMailboxTrackingFolders = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "msdyn_teamscollaborationid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "msdyn_teamscollaboration",
					Entity2LogicalName = "mailboxtrackingfolder",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N msdyn_teamscollaboration_PrincipalObjectAttributeAccesses</summary>
			public static readonly XrmFakedRelationship MsdynTeamscollaborationPrincipalObjectAttributeAccesses = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "msdyn_teamscollaborationid",
					Entity2Attribute = "objectid",
					Entity1LogicalName = "msdyn_teamscollaboration",
					Entity2LogicalName = "principalobjectattributeaccess",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N msdyn_teamscollaboration_ProcessSession</summary>
			public static readonly XrmFakedRelationship MsdynTeamscollaborationProcessSession = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "msdyn_teamscollaborationid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "msdyn_teamscollaboration",
					Entity2LogicalName = "processsession",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N msdyn_teamscollaboration_SyncErrors</summary>
			public static readonly XrmFakedRelationship MsdynTeamscollaborationSyncErrors = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "msdyn_teamscollaborationid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "msdyn_teamscollaboration",
					Entity2LogicalName = "syncerror",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

		}
		#endregion

		#region Fake
		public static MicrosoftTeamsCollaborationEntity Create()
		{
			var faker = new Faker<MicrosoftTeamsCollaborationEntity>()
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
			.RuleFor(e => e.CollaborationAppIdWhichWasUsedToPinTheRecord, fake => fake.Lorem.Word())
			.RuleFor(e => e.CollaborationChannelRelativeFolderURL, fake => fake.Lorem.Word())
			.RuleFor(e => e.CollaborationChannelID, fake => fake.Lorem.Word())
			.RuleFor(e => e.CollaborationChannelName, fake => fake.Lorem.Word())
			.RuleFor(e => e.CollaborationChannelTypePrivateEtc, fake => fake.Lorem.Word())
			.RuleFor(e => e.CollaborationTabContentUrl, fake => fake.Lorem.Word())
			.RuleFor(e => e.CollaborationGroupIdentifierId, fake => Guid.NewGuid())
			.RuleFor(e => e.CollaborationPipedEntityIdWhichWasUsedToPinTheRecord, fake => fake.Lorem.Word())
			.RuleFor(e => e.CollaborationTeamID, fake => fake.Lorem.Word())
			.RuleFor(e => e.CollaborationTeamName, fake => fake.Lorem.Word())
			.RuleFor(e => e.Id, fake => Guid.NewGuid())
			.RuleFor(e => e.TeamSiteURL, fake => fake.Lorem.Word())
			.RuleFor(e => e.CollaborationTenantIdentifierId, fake => Guid.NewGuid())
			.RuleFor(e => e.CollaborationTabWebUrl, fake => fake.Lorem.Word())
			.RuleFor(e => e.RecordCreatedOn, fake => fake.Date.Soon())
			.RuleFor(e => e.RelatedDynamics365RecordId, fake => Guid.NewGuid())
			.RuleFor(e => e.RelatedDynamics365RecordIDEntityCode, fake => fake.Random.Int())
			.RuleFor(e => e.RelatedDynamics365RecordTypeName, fake => fake.Lorem.Word())
			.RuleFor(e => e.Status, fake => fake.PickRandom<MicrosoftTeamsCollaborationEntity.eStatus>())
			.RuleFor(e => e.StatusReason, fake => fake.PickRandom<MicrosoftTeamsCollaborationEntity.eStatusReason>())
			.RuleFor(e => e.TimeZoneRuleVersionNumber, fake => fake.Random.Int())
			.RuleFor(e => e.UTCConversionTimeZoneCode, fake => fake.Random.Int())
			.RuleFor(e => e.VersionNumber, fake => fake.Random.Int());
			return faker.Generate();
		}
		#endregion
	}
}

