using Bogus;
using System;
using FakeXrmEasy;
using System.Collections.Generic;
using PentaWork.Xrm.Scheduler.Proxies.Entities;

namespace PentaWork.Xrm.Scheduler.Tests.Fake
{
	public static class FakeActionCardRegarding
	{	
		#region FakeRelationships
		public static class Relationships 
		{
			/// <summary>1:N msdyn_actioncardregarding_AsyncOperations</summary>
			public static readonly XrmFakedRelationship MsdynActioncardregardingAsyncOperations = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "msdyn_actioncardregardingid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "msdyn_actioncardregarding",
					Entity2LogicalName = "asyncoperation",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N msdyn_actioncardregarding_BulkDeleteFailures</summary>
			public static readonly XrmFakedRelationship MsdynActioncardregardingBulkDeleteFailures = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "msdyn_actioncardregardingid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "msdyn_actioncardregarding",
					Entity2LogicalName = "bulkdeletefailure",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N msdyn_actioncardregarding_DuplicateBaseRecord</summary>
			public static readonly XrmFakedRelationship MsdynActioncardregardingDuplicateBaseRecord = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "msdyn_actioncardregardingid",
					Entity2Attribute = "baserecordid",
					Entity1LogicalName = "msdyn_actioncardregarding",
					Entity2LogicalName = "duplicaterecord",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N msdyn_actioncardregarding_DuplicateMatchingRecord</summary>
			public static readonly XrmFakedRelationship MsdynActioncardregardingDuplicateMatchingRecord = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "msdyn_actioncardregardingid",
					Entity2Attribute = "duplicaterecordid",
					Entity1LogicalName = "msdyn_actioncardregarding",
					Entity2LogicalName = "duplicaterecord",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N msdyn_actioncardregarding_MailboxTrackingFolders</summary>
			public static readonly XrmFakedRelationship MsdynActioncardregardingMailboxTrackingFolders = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "msdyn_actioncardregardingid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "msdyn_actioncardregarding",
					Entity2LogicalName = "mailboxtrackingfolder",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N msdyn_actioncardregarding_PrincipalObjectAttributeAccesses</summary>
			public static readonly XrmFakedRelationship MsdynActioncardregardingPrincipalObjectAttributeAccesses = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "msdyn_actioncardregardingid",
					Entity2Attribute = "objectid",
					Entity1LogicalName = "msdyn_actioncardregarding",
					Entity2LogicalName = "principalobjectattributeaccess",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N msdyn_actioncardregarding_ProcessSession</summary>
			public static readonly XrmFakedRelationship MsdynActioncardregardingProcessSession = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "msdyn_actioncardregardingid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "msdyn_actioncardregarding",
					Entity2LogicalName = "processsession",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N msdyn_actioncardregarding_SyncErrors</summary>
			public static readonly XrmFakedRelationship MsdynActioncardregardingSyncErrors = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "msdyn_actioncardregardingid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "msdyn_actioncardregarding",
					Entity2LogicalName = "syncerror",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

		}
		#endregion

		#region Fake
		public static ActionCardRegarding Create()
		{
			var faker = new Faker<ActionCardRegarding>()
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
			.RuleFor(e => e.Actioncardid, fake => fake.Lorem.Word())
			.RuleFor(e => e.Id, fake => Guid.NewGuid())
			.RuleFor(e => e.Name, fake => fake.Lorem.Word())
			.RuleFor(e => e.RecordCreatedOn, fake => fake.Date.Soon())
			.RuleFor(e => e.Owneridname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Owneridtype, fake => fake.Lorem.Word())
			.RuleFor(e => e.Owneridyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.Status, fake => fake.PickRandom<ActionCardRegarding.eStatus>())
			.RuleFor(e => e.StatusReason, fake => fake.PickRandom<ActionCardRegarding.eStatusReason>())
			.RuleFor(e => e.TimeZoneRuleVersionNumber, fake => fake.Random.Int())
			.RuleFor(e => e.UTCConversionTimeZoneCode, fake => fake.Random.Int())
			.RuleFor(e => e.VersionNumber, fake => fake.Random.Int());
			return faker.Generate();
		}
		#endregion
	}
}

