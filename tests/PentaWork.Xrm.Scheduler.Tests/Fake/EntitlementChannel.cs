using Bogus;
using System;
using FakeXrmEasy;
using System.Collections.Generic;
using PentaWork.Xrm.Scheduler.Proxies.Entities;

namespace PentaWork.Xrm.Scheduler.Tests.Fake
{
	public static class FakeEntitlementChannel
	{	
		#region FakeRelationships
		public static class Relationships 
		{
			/// <summary>1:N entitlementchannel_Annotations</summary>
			public static readonly XrmFakedRelationship EntitlementchannelAnnotations = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "entitlementchannelid",
					Entity2Attribute = "objectid",
					Entity1LogicalName = "entitlementchannel",
					Entity2LogicalName = "annotation",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N entitlementchannel_AsyncOperations</summary>
			public static readonly XrmFakedRelationship EntitlementchannelAsyncOperations = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "entitlementchannelid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "entitlementchannel",
					Entity2LogicalName = "asyncoperation",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N entitlementchannel_BulkDeleteFailures</summary>
			public static readonly XrmFakedRelationship EntitlementchannelBulkDeleteFailures = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "entitlementchannelid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "entitlementchannel",
					Entity2LogicalName = "bulkdeletefailure",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N entitlementchannel_connections1</summary>
			public static readonly XrmFakedRelationship EntitlementchannelConnections1 = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "entitlementchannelid",
					Entity2Attribute = "record1id",
					Entity1LogicalName = "entitlementchannel",
					Entity2LogicalName = "connection",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N entitlementchannel_connections2</summary>
			public static readonly XrmFakedRelationship EntitlementchannelConnections2 = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "entitlementchannelid",
					Entity2Attribute = "record2id",
					Entity1LogicalName = "entitlementchannel",
					Entity2LogicalName = "connection",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N entitlementchannel_DuplicateBaseRecord</summary>
			public static readonly XrmFakedRelationship EntitlementchannelDuplicateBaseRecord = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "entitlementchannelid",
					Entity2Attribute = "baserecordid",
					Entity1LogicalName = "entitlementchannel",
					Entity2LogicalName = "duplicaterecord",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N entitlementchannel_DuplicateMatchingRecord</summary>
			public static readonly XrmFakedRelationship EntitlementchannelDuplicateMatchingRecord = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "entitlementchannelid",
					Entity2Attribute = "duplicaterecordid",
					Entity1LogicalName = "entitlementchannel",
					Entity2LogicalName = "duplicaterecord",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N entitlementchannel_MailboxTrackingFolders</summary>
			public static readonly XrmFakedRelationship EntitlementchannelMailboxTrackingFolders = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "entitlementchannelid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "entitlementchannel",
					Entity2LogicalName = "mailboxtrackingfolder",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N entitlementchannel_PrincipalObjectAttributeAccesses</summary>
			public static readonly XrmFakedRelationship EntitlementchannelPrincipalObjectAttributeAccesses = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "entitlementchannelid",
					Entity2Attribute = "objectid",
					Entity1LogicalName = "entitlementchannel",
					Entity2LogicalName = "principalobjectattributeaccess",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N entitlementchannel_ProcessSession</summary>
			public static readonly XrmFakedRelationship EntitlementchannelProcessSession = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "entitlementchannelid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "entitlementchannel",
					Entity2LogicalName = "processsession",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N entitlementchannel_SyncErrors</summary>
			public static readonly XrmFakedRelationship EntitlementchannelSyncErrors = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "entitlementchannelid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "entitlementchannel",
					Entity2LogicalName = "syncerror",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

		}
		#endregion

		#region Fake
		public static EntitlementChannel Create()
		{
			var faker = new Faker<EntitlementChannel>()
			.RuleFor(e => e.Name, fake => fake.PickRandom<EntitlementChannel.egCaseOrigin>())
			.RuleFor(e => e.Createdbyname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Createdbyyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.CreatedOn, fake => fake.Date.Soon())
			.RuleFor(e => e.Createdonbehalfbyname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Createdonbehalfbyyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.Id, fake => Guid.NewGuid())
			.RuleFor(e => e.Entitlementidname, fake => fake.Lorem.Word())
			.RuleFor(e => e.ExchangeRate, fake => fake.Finance.Amount())
			.RuleFor(e => e.ImportSequenceNumber, fake => fake.Random.Int())
			.RuleFor(e => e.Modifiedbyname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Modifiedbyyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.ModifiedOn, fake => fake.Date.Soon())
			.RuleFor(e => e.Modifiedonbehalfbyname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Modifiedonbehalfbyyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.EntitlementChannelName, fake => fake.Lorem.Word())
			.RuleFor(e => e.Organizationidname, fake => fake.Lorem.Word())
			.RuleFor(e => e.RecordCreatedOn, fake => fake.Date.Soon())
			.RuleFor(e => e.Owneridname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Owneridtype, fake => fake.Lorem.Word())
			.RuleFor(e => e.Owneridyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.RemainingTerms, fake => fake.Finance.Amount())
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

