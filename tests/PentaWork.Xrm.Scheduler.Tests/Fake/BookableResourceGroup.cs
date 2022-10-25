using Bogus;
using System;
using FakeXrmEasy;
using System.Collections.Generic;
using PentaWork.Xrm.Scheduler.Proxies.Entities;

namespace PentaWork.Xrm.Scheduler.Tests.Fake
{
	public static class FakeBookableResourceGroup
	{	
		#region FakeRelationships
		public static class Relationships 
		{
			/// <summary>1:N bookableresourcegroup_Annotations</summary>
			public static readonly XrmFakedRelationship BookableresourcegroupAnnotations = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "bookableresourcegroupid",
					Entity2Attribute = "objectid",
					Entity1LogicalName = "bookableresourcegroup",
					Entity2LogicalName = "annotation",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N bookableresourcegroup_AsyncOperations</summary>
			public static readonly XrmFakedRelationship BookableresourcegroupAsyncOperations = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "bookableresourcegroupid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "bookableresourcegroup",
					Entity2LogicalName = "asyncoperation",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N bookableresourcegroup_BulkDeleteFailures</summary>
			public static readonly XrmFakedRelationship BookableresourcegroupBulkDeleteFailures = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "bookableresourcegroupid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "bookableresourcegroup",
					Entity2LogicalName = "bulkdeletefailure",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N bookableresourcegroup_DuplicateBaseRecord</summary>
			public static readonly XrmFakedRelationship BookableresourcegroupDuplicateBaseRecord = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "bookableresourcegroupid",
					Entity2Attribute = "baserecordid",
					Entity1LogicalName = "bookableresourcegroup",
					Entity2LogicalName = "duplicaterecord",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N bookableresourcegroup_DuplicateMatchingRecord</summary>
			public static readonly XrmFakedRelationship BookableresourcegroupDuplicateMatchingRecord = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "bookableresourcegroupid",
					Entity2Attribute = "duplicaterecordid",
					Entity1LogicalName = "bookableresourcegroup",
					Entity2LogicalName = "duplicaterecord",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N bookableresourcegroup_MailboxTrackingFolders</summary>
			public static readonly XrmFakedRelationship BookableresourcegroupMailboxTrackingFolders = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "bookableresourcegroupid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "bookableresourcegroup",
					Entity2LogicalName = "mailboxtrackingfolder",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N bookableresourcegroup_PrincipalObjectAttributeAccess</summary>
			public static readonly XrmFakedRelationship BookableresourcegroupPrincipalObjectAttributeAccess = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "bookableresourcegroupid",
					Entity2Attribute = "objectid",
					Entity1LogicalName = "bookableresourcegroup",
					Entity2LogicalName = "principalobjectattributeaccess",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N bookableresourcegroup_ProcessSession</summary>
			public static readonly XrmFakedRelationship BookableresourcegroupProcessSession = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "bookableresourcegroupid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "bookableresourcegroup",
					Entity2LogicalName = "processsession",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N BookableResourceGroup_SyncErrors</summary>
			public static readonly XrmFakedRelationship BookableResourceGroupSyncErrors = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "bookableresourcegroupid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "bookableresourcegroup",
					Entity2LogicalName = "syncerror",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

		}
		#endregion

		#region Fake
		public static BookableResourceGroup Create()
		{
			var faker = new Faker<BookableResourceGroup>()
			.RuleFor(e => e.Id, fake => Guid.NewGuid())
			.RuleFor(e => e.Childresourcename, fake => fake.Lorem.Word())
			.RuleFor(e => e.Createdbyname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Createdbyyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.CreatedOn, fake => fake.Date.Soon())
			.RuleFor(e => e.Createdonbehalfbyname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Createdonbehalfbyyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.ExchangeRate, fake => fake.Finance.Amount())
			.RuleFor(e => e.FromDate, fake => fake.Date.Soon())
			.RuleFor(e => e.ImportSequenceNumber, fake => fake.Random.Int())
			.RuleFor(e => e.Modifiedbyname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Modifiedbyyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.ModifiedOn, fake => fake.Date.Soon())
			.RuleFor(e => e.Modifiedonbehalfbyname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Modifiedonbehalfbyyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.Name, fake => fake.Lorem.Word())
			.RuleFor(e => e.RecordCreatedOn, fake => fake.Date.Soon())
			.RuleFor(e => e.Owneridname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Owneridtype, fake => fake.Lorem.Word())
			.RuleFor(e => e.Owneridyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.Parentresourcename, fake => fake.Lorem.Word())
			.RuleFor(e => e.Status, fake => fake.PickRandom<BookableResourceGroup.eStatus>())
			.RuleFor(e => e.StatusReason, fake => fake.PickRandom<BookableResourceGroup.eStatusReason>())
			.RuleFor(e => e.TimeZoneRuleVersionNumber, fake => fake.Random.Int())
			.RuleFor(e => e.ToDate, fake => fake.Date.Soon())
			.RuleFor(e => e.Transactioncurrencyidname, fake => fake.Lorem.Word())
			.RuleFor(e => e.UTCConversionTimeZoneCode, fake => fake.Random.Int())
			.RuleFor(e => e.VersionNumber, fake => fake.Random.Int());
			return faker.Generate();
		}
		#endregion
	}
}

