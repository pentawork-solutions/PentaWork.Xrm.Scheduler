using Bogus;
using System;
using FakeXrmEasy;
using System.Collections.Generic;
using PentaWork.Xrm.Scheduler.Proxies.Entities;

namespace PentaWork.Xrm.Scheduler.Tests.Fake
{
	public static class FakeCharacteristic
	{	
		#region FakeRelationships
		public static class Relationships 
		{
			/// <summary>1:N characteristic_AsyncOperations</summary>
			public static readonly XrmFakedRelationship CharacteristicAsyncOperations = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "characteristicid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "characteristic",
					Entity2LogicalName = "asyncoperation",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N characteristic_bookableresourcecharacteristic_Characteristic</summary>
			public static readonly XrmFakedRelationship CharacteristicBookableresourcecharacteristicCharacteristic = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "characteristicid",
					Entity2Attribute = "characteristic",
					Entity1LogicalName = "characteristic",
					Entity2LogicalName = "bookableresourcecharacteristic",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N characteristic_BulkDeleteFailures</summary>
			public static readonly XrmFakedRelationship CharacteristicBulkDeleteFailures = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "characteristicid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "characteristic",
					Entity2LogicalName = "bulkdeletefailure",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N characteristic_DuplicateBaseRecord</summary>
			public static readonly XrmFakedRelationship CharacteristicDuplicateBaseRecord = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "characteristicid",
					Entity2Attribute = "baserecordid",
					Entity1LogicalName = "characteristic",
					Entity2LogicalName = "duplicaterecord",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N characteristic_DuplicateMatchingRecord</summary>
			public static readonly XrmFakedRelationship CharacteristicDuplicateMatchingRecord = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "characteristicid",
					Entity2Attribute = "duplicaterecordid",
					Entity1LogicalName = "characteristic",
					Entity2LogicalName = "duplicaterecord",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N characteristic_MailboxTrackingFolders</summary>
			public static readonly XrmFakedRelationship CharacteristicMailboxTrackingFolders = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "characteristicid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "characteristic",
					Entity2LogicalName = "mailboxtrackingfolder",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N characteristic_PrincipalObjectAttributeAccess</summary>
			public static readonly XrmFakedRelationship CharacteristicPrincipalObjectAttributeAccess = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "characteristicid",
					Entity2Attribute = "objectid",
					Entity1LogicalName = "characteristic",
					Entity2LogicalName = "principalobjectattributeaccess",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N characteristic_ProcessSession</summary>
			public static readonly XrmFakedRelationship CharacteristicProcessSession = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "characteristicid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "characteristic",
					Entity2LogicalName = "processsession",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N Characteristic_SyncErrors</summary>
			public static readonly XrmFakedRelationship CharacteristicSyncErrors = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "characteristicid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "characteristic",
					Entity2LogicalName = "syncerror",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

		}
		#endregion

		#region Fake
		public static Characteristic Create()
		{
			var faker = new Faker<Characteristic>()
			.RuleFor(e => e.Id, fake => Guid.NewGuid())
			.RuleFor(e => e.CharacteristicType, fake => fake.PickRandom<Characteristic.egBookableResourceCharacteristicType>())
			.RuleFor(e => e.Createdbyname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Createdbyyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.CreatedOn, fake => fake.Date.Soon())
			.RuleFor(e => e.Createdonbehalfbyname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Createdonbehalfbyyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.Description, fake => fake.Lorem.Word())
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
			.RuleFor(e => e.Status, fake => fake.PickRandom<Characteristic.eStatus>())
			.RuleFor(e => e.StatusReason, fake => fake.PickRandom<Characteristic.eStatusReason>())
			.RuleFor(e => e.TimeZoneRuleVersionNumber, fake => fake.Random.Int())
			.RuleFor(e => e.Transactioncurrencyidname, fake => fake.Lorem.Word())
			.RuleFor(e => e.UTCConversionTimeZoneCode, fake => fake.Random.Int())
			.RuleFor(e => e.VersionNumber, fake => fake.Random.Int());
			return faker.Generate();
		}
		#endregion
	}
}

