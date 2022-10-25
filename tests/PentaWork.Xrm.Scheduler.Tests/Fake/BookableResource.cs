using Bogus;
using System;
using FakeXrmEasy;
using System.Collections.Generic;
using PentaWork.Xrm.Scheduler.Proxies.Entities;

namespace PentaWork.Xrm.Scheduler.Tests.Fake
{
	public static class FakeBookableResource
	{	
		#region FakeRelationships
		public static class Relationships 
		{
			/// <summary>1:N bookableresource_Annotations</summary>
			public static readonly XrmFakedRelationship BookableresourceAnnotations = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "bookableresourceid",
					Entity2Attribute = "objectid",
					Entity1LogicalName = "bookableresource",
					Entity2LogicalName = "annotation",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N bookableresource_AsyncOperations</summary>
			public static readonly XrmFakedRelationship BookableresourceAsyncOperations = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "bookableresourceid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "bookableresource",
					Entity2LogicalName = "asyncoperation",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N bookableresource_bookableresourcebooking_Resource</summary>
			public static readonly XrmFakedRelationship BookableresourceBookableresourcebookingResource = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "bookableresourceid",
					Entity2Attribute = "resource",
					Entity1LogicalName = "bookableresource",
					Entity2LogicalName = "bookableresourcebooking",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N bookableresource_bookableresourcecategoryassn_Resource</summary>
			public static readonly XrmFakedRelationship BookableresourceBookableresourcecategoryassnResource = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "bookableresourceid",
					Entity2Attribute = "resource",
					Entity1LogicalName = "bookableresource",
					Entity2LogicalName = "bookableresourcecategoryassn",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N bookableresource_bookableresourcecharacteristic_Resource</summary>
			public static readonly XrmFakedRelationship BookableresourceBookableresourcecharacteristicResource = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "bookableresourceid",
					Entity2Attribute = "resource",
					Entity1LogicalName = "bookableresource",
					Entity2LogicalName = "bookableresourcecharacteristic",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N bookableresource_bookableresourcegroup_ChildResource</summary>
			public static readonly XrmFakedRelationship BookableresourceBookableresourcegroupChildResource = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "bookableresourceid",
					Entity2Attribute = "childresource",
					Entity1LogicalName = "bookableresource",
					Entity2LogicalName = "bookableresourcegroup",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N bookableresource_bookableresourcegroup_ParentResource</summary>
			public static readonly XrmFakedRelationship BookableresourceBookableresourcegroupParentResource = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "bookableresourceid",
					Entity2Attribute = "parentresource",
					Entity1LogicalName = "bookableresource",
					Entity2LogicalName = "bookableresourcegroup",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N bookableresource_BulkDeleteFailures</summary>
			public static readonly XrmFakedRelationship BookableresourceBulkDeleteFailures = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "bookableresourceid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "bookableresource",
					Entity2LogicalName = "bulkdeletefailure",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N bookableresource_DuplicateBaseRecord</summary>
			public static readonly XrmFakedRelationship BookableresourceDuplicateBaseRecord = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "bookableresourceid",
					Entity2Attribute = "baserecordid",
					Entity1LogicalName = "bookableresource",
					Entity2LogicalName = "duplicaterecord",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N bookableresource_DuplicateMatchingRecord</summary>
			public static readonly XrmFakedRelationship BookableresourceDuplicateMatchingRecord = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "bookableresourceid",
					Entity2Attribute = "duplicaterecordid",
					Entity1LogicalName = "bookableresource",
					Entity2LogicalName = "duplicaterecord",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N bookableresource_MailboxTrackingFolders</summary>
			public static readonly XrmFakedRelationship BookableresourceMailboxTrackingFolders = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "bookableresourceid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "bookableresource",
					Entity2LogicalName = "mailboxtrackingfolder",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N bookableresource_PrincipalObjectAttributeAccess</summary>
			public static readonly XrmFakedRelationship BookableresourcePrincipalObjectAttributeAccess = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "bookableresourceid",
					Entity2Attribute = "objectid",
					Entity1LogicalName = "bookableresource",
					Entity2LogicalName = "principalobjectattributeaccess",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N bookableresource_ProcessSession</summary>
			public static readonly XrmFakedRelationship BookableresourceProcessSession = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "bookableresourceid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "bookableresource",
					Entity2LogicalName = "processsession",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N BookableResource_SyncErrors</summary>
			public static readonly XrmFakedRelationship BookableResourceSyncErrors = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "bookableresourceid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "bookableresource",
					Entity2LogicalName = "syncerror",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

		}
		#endregion

		#region Fake
		public static BookableResource Create()
		{
			var faker = new Faker<BookableResource>()
			.RuleFor(e => e.Accountidname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Accountidyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.Id, fake => Guid.NewGuid())
			.RuleFor(e => e.Calendaridname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Contactidname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Contactidyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.Createdbyname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Createdbyyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.CreatedOn, fake => fake.Date.Soon())
			.RuleFor(e => e.Createdonbehalfbyname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Createdonbehalfbyyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.ExchangeRate, fake => fake.Finance.Amount())
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
			.RuleFor(e => e.ProcessId, fake => Guid.NewGuid())
			.RuleFor(e => e.ResourceType, fake => fake.PickRandom<BookableResource.eTypeOfTheResource>())
			.RuleFor(e => e.DeprecatedStageId, fake => Guid.NewGuid())
			.RuleFor(e => e.Status, fake => fake.PickRandom<BookableResource.eStatus>())
			.RuleFor(e => e.StatusReason, fake => fake.PickRandom<BookableResource.eStatusReason>())
			.RuleFor(e => e.TimeZone, fake => fake.Random.Int())
			.RuleFor(e => e.TimeZoneRuleVersionNumber, fake => fake.Random.Int())
			.RuleFor(e => e.Transactioncurrencyidname, fake => fake.Lorem.Word())
			.RuleFor(e => e.DeprecatedTraversedPath, fake => fake.Lorem.Word())
			.RuleFor(e => e.Useridname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Useridyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.UTCConversionTimeZoneCode, fake => fake.Random.Int())
			.RuleFor(e => e.VersionNumber, fake => fake.Random.Int());
			return faker.Generate();
		}
		#endregion
	}
}

