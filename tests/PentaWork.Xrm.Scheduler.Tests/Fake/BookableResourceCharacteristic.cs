using Bogus;
using System;
using FakeXrmEasy;
using System.Collections.Generic;
using PentaWork.Xrm.Scheduler.Proxies.Entities;

namespace PentaWork.Xrm.Scheduler.Tests.Fake
{
	public static class FakeBookableResourceCharacteristic
	{	
		#region FakeRelationships
		public static class Relationships 
		{
			/// <summary>1:N bookableresourcecharacteristic_Annotations</summary>
			public static readonly XrmFakedRelationship BookableresourcecharacteristicAnnotations = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "bookableresourcecharacteristicid",
					Entity2Attribute = "objectid",
					Entity1LogicalName = "bookableresourcecharacteristic",
					Entity2LogicalName = "annotation",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N bookableresourcecharacteristic_AsyncOperations</summary>
			public static readonly XrmFakedRelationship BookableresourcecharacteristicAsyncOperations = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "bookableresourcecharacteristicid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "bookableresourcecharacteristic",
					Entity2LogicalName = "asyncoperation",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N bookableresourcecharacteristic_BulkDeleteFailures</summary>
			public static readonly XrmFakedRelationship BookableresourcecharacteristicBulkDeleteFailures = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "bookableresourcecharacteristicid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "bookableresourcecharacteristic",
					Entity2LogicalName = "bulkdeletefailure",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N bookableresourcecharacteristic_DuplicateBaseRecord</summary>
			public static readonly XrmFakedRelationship BookableresourcecharacteristicDuplicateBaseRecord = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "bookableresourcecharacteristicid",
					Entity2Attribute = "baserecordid",
					Entity1LogicalName = "bookableresourcecharacteristic",
					Entity2LogicalName = "duplicaterecord",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N bookableresourcecharacteristic_DuplicateMatchingRecord</summary>
			public static readonly XrmFakedRelationship BookableresourcecharacteristicDuplicateMatchingRecord = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "bookableresourcecharacteristicid",
					Entity2Attribute = "duplicaterecordid",
					Entity1LogicalName = "bookableresourcecharacteristic",
					Entity2LogicalName = "duplicaterecord",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N bookableresourcecharacteristic_MailboxTrackingFolders</summary>
			public static readonly XrmFakedRelationship BookableresourcecharacteristicMailboxTrackingFolders = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "bookableresourcecharacteristicid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "bookableresourcecharacteristic",
					Entity2LogicalName = "mailboxtrackingfolder",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N bookableresourcecharacteristic_PrincipalObjectAttributeAccess</summary>
			public static readonly XrmFakedRelationship BookableresourcecharacteristicPrincipalObjectAttributeAccess = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "bookableresourcecharacteristicid",
					Entity2Attribute = "objectid",
					Entity1LogicalName = "bookableresourcecharacteristic",
					Entity2LogicalName = "principalobjectattributeaccess",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N bookableresourcecharacteristic_ProcessSession</summary>
			public static readonly XrmFakedRelationship BookableresourcecharacteristicProcessSession = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "bookableresourcecharacteristicid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "bookableresourcecharacteristic",
					Entity2LogicalName = "processsession",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N BookableResourceCharacteristic_SyncErrors</summary>
			public static readonly XrmFakedRelationship BookableResourceCharacteristicSyncErrors = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "bookableresourcecharacteristicid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "bookableresourcecharacteristic",
					Entity2LogicalName = "syncerror",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

		}
		#endregion

		#region Fake
		public static BookableResourceCharacteristic Create()
		{
			var faker = new Faker<BookableResourceCharacteristic>()
			.RuleFor(e => e.Id, fake => Guid.NewGuid())
			.RuleFor(e => e.Characteristicname, fake => fake.Lorem.Word())
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
			.RuleFor(e => e.Ratingvaluename, fake => fake.Lorem.Word())
			.RuleFor(e => e.Resourcename, fake => fake.Lorem.Word())
			.RuleFor(e => e.DeprecatedStageId, fake => Guid.NewGuid())
			.RuleFor(e => e.Status, fake => fake.PickRandom<BookableResourceCharacteristic.eStatus>())
			.RuleFor(e => e.StatusReason, fake => fake.PickRandom<BookableResourceCharacteristic.eStatusReason>())
			.RuleFor(e => e.TimeZoneRuleVersionNumber, fake => fake.Random.Int())
			.RuleFor(e => e.Transactioncurrencyidname, fake => fake.Lorem.Word())
			.RuleFor(e => e.DeprecatedTraversedPath, fake => fake.Lorem.Word())
			.RuleFor(e => e.UTCConversionTimeZoneCode, fake => fake.Random.Int())
			.RuleFor(e => e.VersionNumber, fake => fake.Random.Int());
			return faker.Generate();
		}
		#endregion
	}
}

