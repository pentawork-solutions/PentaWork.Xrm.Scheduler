using Bogus;
using System;
using FakeXrmEasy;
using System.Collections.Generic;
using PentaWork.Xrm.Scheduler.Proxies.Entities;

namespace PentaWork.Xrm.Scheduler.Tests.Fake
{
	public static class FakeActionCardRoleSetting
	{	
		#region FakeRelationships
		public static class Relationships 
		{
			/// <summary>1:N msdyn_actioncardrolesetting_AsyncOperations</summary>
			public static readonly XrmFakedRelationship MsdynActioncardrolesettingAsyncOperations = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "msdyn_actioncardrolesettingid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "msdyn_actioncardrolesetting",
					Entity2LogicalName = "asyncoperation",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N msdyn_actioncardrolesetting_BulkDeleteFailures</summary>
			public static readonly XrmFakedRelationship MsdynActioncardrolesettingBulkDeleteFailures = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "msdyn_actioncardrolesettingid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "msdyn_actioncardrolesetting",
					Entity2LogicalName = "bulkdeletefailure",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N msdyn_actioncardrolesetting_MailboxTrackingFolders</summary>
			public static readonly XrmFakedRelationship MsdynActioncardrolesettingMailboxTrackingFolders = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "msdyn_actioncardrolesettingid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "msdyn_actioncardrolesetting",
					Entity2LogicalName = "mailboxtrackingfolder",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N msdyn_actioncardrolesetting_PrincipalObjectAttributeAccesses</summary>
			public static readonly XrmFakedRelationship MsdynActioncardrolesettingPrincipalObjectAttributeAccesses = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "msdyn_actioncardrolesettingid",
					Entity2Attribute = "objectid",
					Entity1LogicalName = "msdyn_actioncardrolesetting",
					Entity2LogicalName = "principalobjectattributeaccess",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N msdyn_actioncardrolesetting_ProcessSession</summary>
			public static readonly XrmFakedRelationship MsdynActioncardrolesettingProcessSession = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "msdyn_actioncardrolesettingid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "msdyn_actioncardrolesetting",
					Entity2LogicalName = "processsession",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N msdyn_actioncardrolesetting_SyncErrors</summary>
			public static readonly XrmFakedRelationship MsdynActioncardrolesettingSyncErrors = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "msdyn_actioncardrolesettingid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "msdyn_actioncardrolesetting",
					Entity2LogicalName = "syncerror",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

		}
		#endregion

		#region Fake
		public static ActionCardRoleSetting Create()
		{
			var faker = new Faker<ActionCardRoleSetting>()
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
			.RuleFor(e => e.Id, fake => Guid.NewGuid())
			.RuleFor(e => e.MsdynCardtypeidname, fake => fake.Lorem.Word())
			.RuleFor(e => e.IsDisabled, fake => fake.Random.Bool())
			.RuleFor(e => e.Name, fake => fake.Lorem.Word())
			.RuleFor(e => e.MsdynRoleidname, fake => fake.Lorem.Word())
			.RuleFor(e => e.RecordCreatedOn, fake => fake.Date.Soon())
			.RuleFor(e => e.Owneridname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Owneridtype, fake => fake.Lorem.Word())
			.RuleFor(e => e.Owneridyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.Status, fake => fake.PickRandom<ActionCardRoleSetting.eStatus>())
			.RuleFor(e => e.StatusReason, fake => fake.PickRandom<ActionCardRoleSetting.eStatusReason>())
			.RuleFor(e => e.TimeZoneRuleVersionNumber, fake => fake.Random.Int())
			.RuleFor(e => e.UTCConversionTimeZoneCode, fake => fake.Random.Int())
			.RuleFor(e => e.VersionNumber, fake => fake.Random.Int());
			return faker.Generate();
		}
		#endregion
	}
}

