using Bogus;
using System;
using FakeXrmEasy;
using System.Collections.Generic;
using PentaWork.Xrm.Scheduler.Proxies.Entities;

namespace PentaWork.Xrm.Scheduler.Tests.Fake
{
	public static class FakeSalesinsightssettings
	{	
		#region FakeRelationships
		public static class Relationships 
		{
			/// <summary>1:N msdyn_salesinsightssettings_AsyncOperations</summary>
			public static readonly XrmFakedRelationship MsdynSalesinsightssettingsAsyncOperations = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "msdyn_salesinsightssettingsid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "msdyn_salesinsightssettings",
					Entity2LogicalName = "asyncoperation",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N msdyn_salesinsightssettings_BulkDeleteFailures</summary>
			public static readonly XrmFakedRelationship MsdynSalesinsightssettingsBulkDeleteFailures = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "msdyn_salesinsightssettingsid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "msdyn_salesinsightssettings",
					Entity2LogicalName = "bulkdeletefailure",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N msdyn_salesinsightssettings_DuplicateBaseRecord</summary>
			public static readonly XrmFakedRelationship MsdynSalesinsightssettingsDuplicateBaseRecord = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "msdyn_salesinsightssettingsid",
					Entity2Attribute = "baserecordid",
					Entity1LogicalName = "msdyn_salesinsightssettings",
					Entity2LogicalName = "duplicaterecord",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N msdyn_salesinsightssettings_DuplicateMatchingRecord</summary>
			public static readonly XrmFakedRelationship MsdynSalesinsightssettingsDuplicateMatchingRecord = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "msdyn_salesinsightssettingsid",
					Entity2Attribute = "duplicaterecordid",
					Entity1LogicalName = "msdyn_salesinsightssettings",
					Entity2LogicalName = "duplicaterecord",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N msdyn_salesinsightssettings_MailboxTrackingFolders</summary>
			public static readonly XrmFakedRelationship MsdynSalesinsightssettingsMailboxTrackingFolders = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "msdyn_salesinsightssettingsid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "msdyn_salesinsightssettings",
					Entity2LogicalName = "mailboxtrackingfolder",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N msdyn_salesinsightssettings_PrincipalObjectAttributeAccesses</summary>
			public static readonly XrmFakedRelationship MsdynSalesinsightssettingsPrincipalObjectAttributeAccesses = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "msdyn_salesinsightssettingsid",
					Entity2Attribute = "objectid",
					Entity1LogicalName = "msdyn_salesinsightssettings",
					Entity2LogicalName = "principalobjectattributeaccess",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N msdyn_salesinsightssettings_ProcessSession</summary>
			public static readonly XrmFakedRelationship MsdynSalesinsightssettingsProcessSession = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "msdyn_salesinsightssettingsid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "msdyn_salesinsightssettings",
					Entity2LogicalName = "processsession",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N msdyn_salesinsightssettings_SyncErrors</summary>
			public static readonly XrmFakedRelationship MsdynSalesinsightssettingsSyncErrors = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "msdyn_salesinsightssettingsid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "msdyn_salesinsightssettings",
					Entity2LogicalName = "syncerror",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

		}
		#endregion

		#region Fake
		public static Salesinsightssettings Create()
		{
			var faker = new Faker<Salesinsightssettings>()
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
			.RuleFor(e => e.Islicensepurchased, fake => fake.Random.Bool())
			.RuleFor(e => e.Isoctpreviewenabled, fake => fake.Random.Bool())
			.RuleFor(e => e.Ispreviewenabled, fake => fake.Random.Bool())
			.RuleFor(e => e.Name, fake => fake.Lorem.Word())
			.RuleFor(e => e.Id, fake => Guid.NewGuid())
			.RuleFor(e => e.RecordCreatedOn, fake => fake.Date.Soon())
			.RuleFor(e => e.Owneridname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Owneridtype, fake => fake.Lorem.Word())
			.RuleFor(e => e.Owneridyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.Status, fake => fake.PickRandom<Salesinsightssettings.eStatus>())
			.RuleFor(e => e.StatusReason, fake => fake.PickRandom<Salesinsightssettings.eStatusReason>())
			.RuleFor(e => e.TimeZoneRuleVersionNumber, fake => fake.Random.Int())
			.RuleFor(e => e.UTCConversionTimeZoneCode, fake => fake.Random.Int())
			.RuleFor(e => e.VersionNumber, fake => fake.Random.Int());
			return faker.Generate();
		}
		#endregion
	}
}

