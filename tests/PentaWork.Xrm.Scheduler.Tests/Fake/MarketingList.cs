using Bogus;
using System;
using FakeXrmEasy;
using System.Collections.Generic;
using PentaWork.Xrm.Scheduler.Proxies.Entities;

namespace PentaWork.Xrm.Scheduler.Tests.Fake
{
	public static class FakeMarketingList
	{	
		#region FakeRelationships
		public static class Relationships 
		{
			/// <summary>1:N List_Annotation</summary>
			public static readonly XrmFakedRelationship ListAnnotation = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "listid",
					Entity2Attribute = "objectid",
					Entity1LogicalName = "list",
					Entity2LogicalName = "annotation",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N List_AsyncOperations</summary>
			public static readonly XrmFakedRelationship ListAsyncOperations = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "listid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "list",
					Entity2LogicalName = "asyncoperation",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N List_BulkDeleteFailures</summary>
			public static readonly XrmFakedRelationship ListBulkDeleteFailures = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "listid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "list",
					Entity2LogicalName = "bulkdeletefailure",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N List_BulkOperations</summary>
			public static readonly XrmFakedRelationship ListBulkOperations = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "listid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "list",
					Entity2LogicalName = "bulkoperation",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N list_connections1</summary>
			public static readonly XrmFakedRelationship ListConnections1 = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "listid",
					Entity2Attribute = "record1id",
					Entity1LogicalName = "list",
					Entity2LogicalName = "connection",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N list_connections2</summary>
			public static readonly XrmFakedRelationship ListConnections2 = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "listid",
					Entity2Attribute = "record2id",
					Entity1LogicalName = "list",
					Entity2LogicalName = "connection",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N List_DuplicateBaseRecord</summary>
			public static readonly XrmFakedRelationship ListDuplicateBaseRecord = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "listid",
					Entity2Attribute = "baserecordid",
					Entity1LogicalName = "list",
					Entity2LogicalName = "duplicaterecord",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N List_DuplicateMatchingRecord</summary>
			public static readonly XrmFakedRelationship ListDuplicateMatchingRecord = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "listid",
					Entity2Attribute = "duplicaterecordid",
					Entity1LogicalName = "list",
					Entity2LogicalName = "duplicaterecord",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N list_listoperation_ListId</summary>
			public static readonly XrmFakedRelationship ListListoperationListId = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "listid",
					Entity2Attribute = "listid",
					Entity1LogicalName = "list",
					Entity2LogicalName = "listoperation",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N list_MailboxTrackingFolders</summary>
			public static readonly XrmFakedRelationship ListMailboxTrackingFolders = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "listid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "list",
					Entity2LogicalName = "mailboxtrackingfolder",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N list_principalobjectattributeaccess</summary>
			public static readonly XrmFakedRelationship ListPrincipalobjectattributeaccess = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "listid",
					Entity2Attribute = "objectid",
					Entity1LogicalName = "list",
					Entity2LogicalName = "principalobjectattributeaccess",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N List_ProcessSessions</summary>
			public static readonly XrmFakedRelationship ListProcessSessions = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "listid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "list",
					Entity2LogicalName = "processsession",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N List_SyncErrors</summary>
			public static readonly XrmFakedRelationship ListSyncErrors = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "listid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "list",
					Entity2LogicalName = "syncerror",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>N:N campaignactivitylist_association</summary>
			public static readonly XrmFakedRelationship CampaignactivitylistAssociation = 
				new XrmFakedRelationship
				{
					IntersectEntity = "campaignactivitylist_association",
					Entity1Attribute = "campaignactivityid",
					Entity2Attribute = "itemid",
					Entity1LogicalName = "campaignactivity",
					Entity2LogicalName = "list",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.ManyToMany
				};

			/// <summary>N:N campaignlist_association</summary>
			public static readonly XrmFakedRelationship CampaignlistAssociation = 
				new XrmFakedRelationship
				{
					IntersectEntity = "campaignlist_association",
					Entity1Attribute = "campaignid",
					Entity2Attribute = "entityid",
					Entity1LogicalName = "campaign",
					Entity2LogicalName = "list",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.ManyToMany
				};

			/// <summary>N:N listaccount_association</summary>
			public static readonly XrmFakedRelationship ListaccountAssociation = 
				new XrmFakedRelationship
				{
					IntersectEntity = "listaccount_association",
					Entity1Attribute = "listid",
					Entity2Attribute = "entityid",
					Entity1LogicalName = "list",
					Entity2LogicalName = "account",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.ManyToMany
				};

			/// <summary>N:N listcontact_association</summary>
			public static readonly XrmFakedRelationship ListcontactAssociation = 
				new XrmFakedRelationship
				{
					IntersectEntity = "listcontact_association",
					Entity1Attribute = "listid",
					Entity2Attribute = "entityid",
					Entity1LogicalName = "list",
					Entity2LogicalName = "contact",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.ManyToMany
				};

			/// <summary>N:N listlead_association</summary>
			public static readonly XrmFakedRelationship ListleadAssociation = 
				new XrmFakedRelationship
				{
					IntersectEntity = "listlead_association",
					Entity1Attribute = "listid",
					Entity2Attribute = "entityid",
					Entity1LogicalName = "list",
					Entity2LogicalName = "lead",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.ManyToMany
				};

		}
		#endregion

		#region Fake
		public static MarketingList Create()
		{
			var faker = new Faker<MarketingList>()
			.RuleFor(e => e.Cost, fake => fake.Finance.Amount())
			.RuleFor(e => e.Createdbyname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Createdbyyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.MarketingListMemberType, fake => fake.PickRandom<MarketingList.eMarketingListMemberType>())
			.RuleFor(e => e.CreatedOn, fake => fake.Date.Soon())
			.RuleFor(e => e.Createdonbehalfbyname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Createdonbehalfbyyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.Description, fake => fake.Lorem.Word())
			.RuleFor(e => e.ExcludeMembersWhoOptOut, fake => fake.Random.Bool())
			.RuleFor(e => e.ExchangeRate, fake => fake.Finance.Amount())
			.RuleFor(e => e.IgnoreInactiveListMembers, fake => fake.Random.Bool())
			.RuleFor(e => e.ImportSequenceNumber, fake => fake.Random.Int())
			.RuleFor(e => e.LastUsedOn, fake => fake.Date.Soon())
			.RuleFor(e => e.Id, fake => Guid.NewGuid())
			.RuleFor(e => e.Name, fake => fake.Lorem.Word())
			.RuleFor(e => e.Locked, fake => fake.Random.Bool())
			.RuleFor(e => e.MembersCount, fake => fake.Random.Int())
			.RuleFor(e => e.MemberType, fake => fake.Random.Int())
			.RuleFor(e => e.Modifiedbyname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Modifiedbyyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.ModifiedOn, fake => fake.Date.Soon())
			.RuleFor(e => e.Modifiedonbehalfbyname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Modifiedonbehalfbyyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.RecordCreatedOn, fake => fake.Date.Soon())
			.RuleFor(e => e.Owneridname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Owneridtype, fake => fake.Lorem.Word())
			.RuleFor(e => e.Owneridyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.ProcessedMemberCount, fake => fake.Random.Int())
			.RuleFor(e => e.ProcessFetchXML, fake => fake.Lorem.Word())
			.RuleFor(e => e.ProcessId, fake => Guid.NewGuid())
			.RuleFor(e => e.Purpose, fake => fake.Lorem.Word())
			.RuleFor(e => e.Query, fake => fake.Lorem.Word())
			.RuleFor(e => e.Source, fake => fake.Lorem.Word())
			.RuleFor(e => e.DeprecatedStageId, fake => Guid.NewGuid())
			.RuleFor(e => e.Status, fake => fake.PickRandom<MarketingList.eStatus>())
			.RuleFor(e => e.StatusReason, fake => fake.PickRandom<MarketingList.eStatusReason>())
			.RuleFor(e => e.TimeZoneRuleVersionNumber, fake => fake.Random.Int())
			.RuleFor(e => e.Transactioncurrencyidname, fake => fake.Lorem.Word())
			.RuleFor(e => e.DeprecatedTraversedPath, fake => fake.Lorem.Word())
			.RuleFor(e => e.Type, fake => fake.Random.Bool())
			.RuleFor(e => e.UTCConversionTimeZoneCode, fake => fake.Random.Int())
			.RuleFor(e => e.VersionNumber, fake => fake.Random.Int());
			return faker.Generate();
		}
		#endregion
	}
}

