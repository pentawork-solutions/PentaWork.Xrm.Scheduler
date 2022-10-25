using Bogus;
using System;
using FakeXrmEasy;
using System.Collections.Generic;
using PentaWork.Xrm.Scheduler.Proxies.Entities;

namespace PentaWork.Xrm.Scheduler.Tests.Fake
{
	public static class FakeIcebreakersconfig
	{	
		#region FakeRelationships
		public static class Relationships 
		{
			/// <summary>1:N msdyn_icebreakersconfig_AsyncOperations</summary>
			public static readonly XrmFakedRelationship MsdynIcebreakersconfigAsyncOperations = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "msdyn_icebreakersconfigid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "msdyn_icebreakersconfig",
					Entity2LogicalName = "asyncoperation",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N msdyn_icebreakersconfig_BulkDeleteFailures</summary>
			public static readonly XrmFakedRelationship MsdynIcebreakersconfigBulkDeleteFailures = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "msdyn_icebreakersconfigid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "msdyn_icebreakersconfig",
					Entity2LogicalName = "bulkdeletefailure",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N msdyn_icebreakersconfig_DuplicateBaseRecord</summary>
			public static readonly XrmFakedRelationship MsdynIcebreakersconfigDuplicateBaseRecord = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "msdyn_icebreakersconfigid",
					Entity2Attribute = "baserecordid",
					Entity1LogicalName = "msdyn_icebreakersconfig",
					Entity2LogicalName = "duplicaterecord",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N msdyn_icebreakersconfig_DuplicateMatchingRecord</summary>
			public static readonly XrmFakedRelationship MsdynIcebreakersconfigDuplicateMatchingRecord = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "msdyn_icebreakersconfigid",
					Entity2Attribute = "duplicaterecordid",
					Entity1LogicalName = "msdyn_icebreakersconfig",
					Entity2LogicalName = "duplicaterecord",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N msdyn_icebreakersconfig_MailboxTrackingFolders</summary>
			public static readonly XrmFakedRelationship MsdynIcebreakersconfigMailboxTrackingFolders = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "msdyn_icebreakersconfigid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "msdyn_icebreakersconfig",
					Entity2LogicalName = "mailboxtrackingfolder",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N msdyn_icebreakersconfig_PrincipalObjectAttributeAccesses</summary>
			public static readonly XrmFakedRelationship MsdynIcebreakersconfigPrincipalObjectAttributeAccesses = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "msdyn_icebreakersconfigid",
					Entity2Attribute = "objectid",
					Entity1LogicalName = "msdyn_icebreakersconfig",
					Entity2LogicalName = "principalobjectattributeaccess",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N msdyn_icebreakersconfig_ProcessSession</summary>
			public static readonly XrmFakedRelationship MsdynIcebreakersconfigProcessSession = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "msdyn_icebreakersconfigid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "msdyn_icebreakersconfig",
					Entity2LogicalName = "processsession",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N msdyn_icebreakersconfig_SyncErrors</summary>
			public static readonly XrmFakedRelationship MsdynIcebreakersconfigSyncErrors = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "msdyn_icebreakersconfigid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "msdyn_icebreakersconfig",
					Entity2LogicalName = "syncerror",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

		}
		#endregion

		#region Fake
		public static Icebreakersconfig Create()
		{
			var faker = new Faker<Icebreakersconfig>()
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
			.RuleFor(e => e.AreTermsAndConditionsAcceptedToConfigureIcebreakers, fake => fake.Random.Bool())
			.RuleFor(e => e.Id, fake => Guid.NewGuid())
			.RuleFor(e => e.Isadminsettingenabled, fake => fake.Random.Bool())
			.RuleFor(e => e.Isentertainmentcategoryenabled, fake => fake.Random.Bool())
			.RuleFor(e => e.Isfamilycategoryenabled, fake => fake.Random.Bool())
			.RuleFor(e => e.Ishealthcategoryenabled, fake => fake.Random.Bool())
			.RuleFor(e => e.Issportscategoryenabled, fake => fake.Random.Bool())
			.RuleFor(e => e.Name, fake => fake.Lorem.Word())
			.RuleFor(e => e.RecordCreatedOn, fake => fake.Date.Soon())
			.RuleFor(e => e.Owneridname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Owneridtype, fake => fake.Lorem.Word())
			.RuleFor(e => e.Owneridyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.Status, fake => fake.PickRandom<Icebreakersconfig.eStatus>())
			.RuleFor(e => e.StatusReason, fake => fake.PickRandom<Icebreakersconfig.eStatusReason>())
			.RuleFor(e => e.TimeZoneRuleVersionNumber, fake => fake.Random.Int())
			.RuleFor(e => e.UTCConversionTimeZoneCode, fake => fake.Random.Int())
			.RuleFor(e => e.VersionNumber, fake => fake.Random.Int());
			return faker.Generate();
		}
		#endregion
	}
}

