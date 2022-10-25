using Bogus;
using System;
using FakeXrmEasy;
using System.Collections.Generic;
using PentaWork.Xrm.Scheduler.Proxies.Entities;

namespace PentaWork.Xrm.Scheduler.Tests.Fake
{
	public static class FakeFacilityEquipment
	{	
		#region FakeRelationships
		public static class Relationships 
		{
			/// <summary>1:N equipment_accounts</summary>
			public static readonly XrmFakedRelationship EquipmentAccounts = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "equipmentid",
					Entity2Attribute = "preferredequipmentid",
					Entity1LogicalName = "equipment",
					Entity2LogicalName = "account",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N equipment_activity_parties</summary>
			public static readonly XrmFakedRelationship EquipmentActivityParties = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "equipmentid",
					Entity2Attribute = "partyid",
					Entity1LogicalName = "equipment",
					Entity2LogicalName = "activityparty",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N Equipment_Annotation</summary>
			public static readonly XrmFakedRelationship EquipmentAnnotation = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "equipmentid",
					Entity2Attribute = "objectid",
					Entity1LogicalName = "equipment",
					Entity2LogicalName = "annotation",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N Equipment_AsyncOperations</summary>
			public static readonly XrmFakedRelationship EquipmentAsyncOperations = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "equipmentid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "equipment",
					Entity2LogicalName = "asyncoperation",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N Equipment_BulkDeleteFailures</summary>
			public static readonly XrmFakedRelationship EquipmentBulkDeleteFailures = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "equipmentid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "equipment",
					Entity2LogicalName = "bulkdeletefailure",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N equipment_connections1</summary>
			public static readonly XrmFakedRelationship EquipmentConnections1 = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "equipmentid",
					Entity2Attribute = "record1id",
					Entity1LogicalName = "equipment",
					Entity2LogicalName = "connection",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N equipment_connections2</summary>
			public static readonly XrmFakedRelationship EquipmentConnections2 = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "equipmentid",
					Entity2Attribute = "record2id",
					Entity1LogicalName = "equipment",
					Entity2LogicalName = "connection",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N equipment_contacts</summary>
			public static readonly XrmFakedRelationship EquipmentContacts = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "equipmentid",
					Entity2Attribute = "preferredequipmentid",
					Entity1LogicalName = "equipment",
					Entity2LogicalName = "contact",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N Equipment_DuplicateBaseRecord</summary>
			public static readonly XrmFakedRelationship EquipmentDuplicateBaseRecord = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "equipmentid",
					Entity2Attribute = "baserecordid",
					Entity1LogicalName = "equipment",
					Entity2LogicalName = "duplicaterecord",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N Equipment_DuplicateMatchingRecord</summary>
			public static readonly XrmFakedRelationship EquipmentDuplicateMatchingRecord = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "equipmentid",
					Entity2Attribute = "duplicaterecordid",
					Entity1LogicalName = "equipment",
					Entity2LogicalName = "duplicaterecord",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N Equipment_Email_EmailSender</summary>
			public static readonly XrmFakedRelationship EquipmentEmailEmailSender = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "equipmentid",
					Entity2Attribute = "emailsender",
					Entity1LogicalName = "equipment",
					Entity2LogicalName = "email",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N equipment_MailboxTrackingFolders</summary>
			public static readonly XrmFakedRelationship EquipmentMailboxTrackingFolders = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "equipmentid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "equipment",
					Entity2LogicalName = "mailboxtrackingfolder",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N equipment_principalobjectattributeaccess</summary>
			public static readonly XrmFakedRelationship EquipmentPrincipalobjectattributeaccess = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "equipmentid",
					Entity2Attribute = "objectid",
					Entity1LogicalName = "equipment",
					Entity2LogicalName = "principalobjectattributeaccess",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N Equipment_ProcessSessions</summary>
			public static readonly XrmFakedRelationship EquipmentProcessSessions = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "equipmentid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "equipment",
					Entity2LogicalName = "processsession",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N equipment_resources</summary>
			public static readonly XrmFakedRelationship EquipmentResources = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "equipmentid",
					Entity2Attribute = "resourceid",
					Entity1LogicalName = "equipment",
					Entity2LogicalName = "resource",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N Equipment_SyncErrors</summary>
			public static readonly XrmFakedRelationship EquipmentSyncErrors = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "equipmentid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "equipment",
					Entity2LogicalName = "syncerror",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

		}
		#endregion

		#region Fake
		public static FacilityEquipment Create()
		{
			var faker = new Faker<FacilityEquipment>()
			.RuleFor(e => e.Businessunitidname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Createdbyname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Createdbyyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.CreatedOn, fake => fake.Date.Soon())
			.RuleFor(e => e.Createdonbehalfbyname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Createdonbehalfbyyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.Description, fake => fake.Lorem.Word())
			.RuleFor(e => e.DisplayInServiceViews, fake => fake.Random.Bool())
			.RuleFor(e => e.PrimaryEmail, fake => fake.Lorem.Word())
			.RuleFor(e => e.Id, fake => Guid.NewGuid())
			.RuleFor(e => e.ExchangeRate, fake => fake.Finance.Amount())
			.RuleFor(e => e.ImportSequenceNumber, fake => fake.Random.Int())
			.RuleFor(e => e.IsDisabled, fake => fake.Random.Bool())
			.RuleFor(e => e.Modifiedbyname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Modifiedbyyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.ModifiedOn, fake => fake.Date.Soon())
			.RuleFor(e => e.Modifiedonbehalfbyname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Modifiedonbehalfbyyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.Name, fake => fake.Lorem.Word())
			.RuleFor(e => e.Organizationidname, fake => fake.Lorem.Word())
			.RuleFor(e => e.RecordCreatedOn, fake => fake.Date.Soon())
			.RuleFor(e => e.Siteidname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Skills, fake => fake.Lorem.Word())
			.RuleFor(e => e.TimeZone, fake => fake.Random.Int())
			.RuleFor(e => e.TimeZoneRuleVersionNumber, fake => fake.Random.Int())
			.RuleFor(e => e.Transactioncurrencyidname, fake => fake.Lorem.Word())
			.RuleFor(e => e.UTCConversionTimeZoneCode, fake => fake.Random.Int())
			.RuleFor(e => e.VersionNumber, fake => fake.Random.Int());
			return faker.Generate();
		}
		#endregion
	}
}

