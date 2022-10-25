using Bogus;
using System;
using FakeXrmEasy;
using System.Collections.Generic;
using PentaWork.Xrm.Scheduler.Proxies.Entities;

namespace PentaWork.Xrm.Scheduler.Tests.Fake
{
	public static class FakeEntitlementTemplateChannel
	{	
		#region FakeRelationships
		public static class Relationships 
		{
			/// <summary>1:N entitlementtemplatechannel_AsyncOperations</summary>
			public static readonly XrmFakedRelationship EntitlementtemplatechannelAsyncOperations = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "entitlementtemplatechannelid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "entitlementtemplatechannel",
					Entity2LogicalName = "asyncoperation",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N entitlementtemplatechannel_BulkDeleteFailures</summary>
			public static readonly XrmFakedRelationship EntitlementtemplatechannelBulkDeleteFailures = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "entitlementtemplatechannelid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "entitlementtemplatechannel",
					Entity2LogicalName = "bulkdeletefailure",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N entitlementtemplatechannel_connections1</summary>
			public static readonly XrmFakedRelationship EntitlementtemplatechannelConnections1 = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "entitlementtemplatechannelid",
					Entity2Attribute = "record1id",
					Entity1LogicalName = "entitlementtemplatechannel",
					Entity2LogicalName = "connection",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N entitlementtemplatechannel_connections2</summary>
			public static readonly XrmFakedRelationship EntitlementtemplatechannelConnections2 = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "entitlementtemplatechannelid",
					Entity2Attribute = "record2id",
					Entity1LogicalName = "entitlementtemplatechannel",
					Entity2LogicalName = "connection",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N entitlementtemplatechannel_MailboxTrackingFolders</summary>
			public static readonly XrmFakedRelationship EntitlementtemplatechannelMailboxTrackingFolders = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "entitlementtemplatechannelid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "entitlementtemplatechannel",
					Entity2LogicalName = "mailboxtrackingfolder",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N entitlementtemplatechannel_PrincipalObjectAttributeAccesses</summary>
			public static readonly XrmFakedRelationship EntitlementtemplatechannelPrincipalObjectAttributeAccesses = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "entitlementtemplatechannelid",
					Entity2Attribute = "objectid",
					Entity1LogicalName = "entitlementtemplatechannel",
					Entity2LogicalName = "principalobjectattributeaccess",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N entitlementtemplatechannel_SyncErrors</summary>
			public static readonly XrmFakedRelationship EntitlementtemplatechannelSyncErrors = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "entitlementtemplatechannelid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "entitlementtemplatechannel",
					Entity2LogicalName = "syncerror",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

		}
		#endregion

		#region Fake
		public static EntitlementTemplateChannel Create()
		{
			var faker = new Faker<EntitlementTemplateChannel>()
			.RuleFor(e => e.Name, fake => fake.PickRandom<EntitlementTemplateChannel.egCaseOrigin>())
			.RuleFor(e => e.Createdbyname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Createdbyyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.CreatedOn, fake => fake.Date.Soon())
			.RuleFor(e => e.Createdonbehalfbyname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Createdonbehalfbyyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.Id, fake => Guid.NewGuid())
			.RuleFor(e => e.Entitlementtemplateidname, fake => fake.Lorem.Word())
			.RuleFor(e => e.ExchangeRate, fake => fake.Finance.Amount())
			.RuleFor(e => e.ImportSequenceNumber, fake => fake.Random.Int())
			.RuleFor(e => e.Modifiedbyname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Modifiedbyyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.ModifiedOn, fake => fake.Date.Soon())
			.RuleFor(e => e.Modifiedonbehalfbyname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Modifiedonbehalfbyyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.EntitlementTemplateChannelName, fake => fake.Lorem.Word())
			.RuleFor(e => e.Organizationidname, fake => fake.Lorem.Word())
			.RuleFor(e => e.RecordCreatedOn, fake => fake.Date.Soon())
			.RuleFor(e => e.TimeZoneRuleVersionNumber, fake => fake.Random.Int())
			.RuleFor(e => e.TotalTerms, fake => fake.Finance.Amount())
			.RuleFor(e => e.Transactioncurrencyidname, fake => fake.Lorem.Word())
			.RuleFor(e => e.UTCConversionTimeZoneCode, fake => fake.Random.Int())
			.RuleFor(e => e.VersionNumber, fake => fake.Random.Int());
			return faker.Generate();
		}
		#endregion
	}
}

