using Bogus;
using System;
using FakeXrmEasy;
using System.Collections.Generic;
using PentaWork.Xrm.Scheduler.Proxies.Entities;

namespace PentaWork.Xrm.Scheduler.Tests.Fake
{
	public static class FakeConnector
	{	
		#region FakeRelationships
		public static class Relationships 
		{
			/// <summary>1:N connector_AsyncOperations</summary>
			public static readonly XrmFakedRelationship ConnectorAsyncOperations = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "connectorid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "connector",
					Entity2LogicalName = "asyncoperation",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N connector_BulkDeleteFailures</summary>
			public static readonly XrmFakedRelationship ConnectorBulkDeleteFailures = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "connectorid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "connector",
					Entity2LogicalName = "bulkdeletefailure",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N connector_connectionreference</summary>
			public static readonly XrmFakedRelationship ConnectorConnectionreference = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "connectorid",
					Entity2Attribute = "customconnectorid",
					Entity1LogicalName = "connector",
					Entity2LogicalName = "connectionreference",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N connector_DuplicateBaseRecord</summary>
			public static readonly XrmFakedRelationship ConnectorDuplicateBaseRecord = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "connectorid",
					Entity2Attribute = "baserecordid",
					Entity1LogicalName = "connector",
					Entity2LogicalName = "duplicaterecord",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N connector_DuplicateMatchingRecord</summary>
			public static readonly XrmFakedRelationship ConnectorDuplicateMatchingRecord = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "connectorid",
					Entity2Attribute = "duplicaterecordid",
					Entity1LogicalName = "connector",
					Entity2LogicalName = "duplicaterecord",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N connector_MailboxTrackingFolders</summary>
			public static readonly XrmFakedRelationship ConnectorMailboxTrackingFolders = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "connectorid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "connector",
					Entity2LogicalName = "mailboxtrackingfolder",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N connector_PrincipalObjectAttributeAccesses</summary>
			public static readonly XrmFakedRelationship ConnectorPrincipalObjectAttributeAccesses = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "connectorid",
					Entity2Attribute = "objectid",
					Entity1LogicalName = "connector",
					Entity2LogicalName = "principalobjectattributeaccess",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N connector_ProcessSession</summary>
			public static readonly XrmFakedRelationship ConnectorProcessSession = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "connectorid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "connector",
					Entity2LogicalName = "processsession",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N connector_SyncErrors</summary>
			public static readonly XrmFakedRelationship ConnectorSyncErrors = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "connectorid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "connector",
					Entity2LogicalName = "syncerror",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

		}
		#endregion

		#region Fake
		public static Connector Create()
		{
			var faker = new Faker<Connector>()
			.RuleFor(e => e.ComponentState, fake => fake.PickRandom<Connector.egComponentState>())
			.RuleFor(e => e.ConnectionParameters, fake => fake.Lorem.Word())
			.RuleFor(e => e.Id, fake => Guid.NewGuid())
			.RuleFor(e => e.ConnectoriduniqueId, fake => Guid.NewGuid())
			.RuleFor(e => e.InternalConnectorId, fake => fake.Lorem.Word())
			.RuleFor(e => e.ConnectorType, fake => fake.PickRandom<Connector.egConnectorType>())
			.RuleFor(e => e.Createdbyname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Createdbyyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.CreatedOn, fake => fake.Date.Soon())
			.RuleFor(e => e.Createdonbehalfbyname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Createdonbehalfbyyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.Description, fake => fake.Lorem.Word())
			.RuleFor(e => e.DisplayName, fake => fake.Lorem.Word())
			.RuleFor(e => e.IconblobTimestamp, fake => fake.Random.Int())
			.RuleFor(e => e.IconblobUrl, fake => fake.Lorem.Word())
			.RuleFor(e => e.IconblobId, fake => Guid.NewGuid())
			.RuleFor(e => e.IconBrandColor, fake => fake.Lorem.Word())
			.RuleFor(e => e.ImportSequenceNumber, fake => fake.Random.Int())
			.RuleFor(e => e.IntroducedVersion, fake => fake.Lorem.Word())
			.RuleFor(e => e.IsManaged, fake => fake.Random.Bool())
			.RuleFor(e => e.Modifiedbyname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Modifiedbyyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.ModifiedOn, fake => fake.Date.Soon())
			.RuleFor(e => e.Modifiedonbehalfbyname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Modifiedonbehalfbyyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.LogicalNameOfTheConnector, fake => fake.Lorem.Word())
			.RuleFor(e => e.OpenApiDefinition, fake => fake.Lorem.Word())
			.RuleFor(e => e.RecordCreatedOn, fake => fake.Date.Soon())
			.RuleFor(e => e.RecordOverwriteTime, fake => fake.Date.Soon())
			.RuleFor(e => e.Owneridname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Owneridtype, fake => fake.Lorem.Word())
			.RuleFor(e => e.Owneridyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.PolicyTemplateInstances, fake => fake.Lorem.Word())
			.RuleFor(e => e.SolutionId, fake => Guid.NewGuid())
			.RuleFor(e => e.Status, fake => fake.PickRandom<Connector.eStatus>())
			.RuleFor(e => e.StatusReason, fake => fake.PickRandom<Connector.eStatusReason>())
			.RuleFor(e => e.SolutionId2, fake => Guid.NewGuid())
			.RuleFor(e => e.TimeZoneRuleVersionNumber, fake => fake.Random.Int())
			.RuleFor(e => e.UTCConversionTimeZoneCode, fake => fake.Random.Int())
			.RuleFor(e => e.VersionNumber, fake => fake.Random.Int());
			return faker.Generate();
		}
		#endregion
	}
}

