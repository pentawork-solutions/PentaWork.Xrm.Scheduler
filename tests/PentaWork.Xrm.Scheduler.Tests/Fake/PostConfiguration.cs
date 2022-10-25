using Bogus;
using System;
using FakeXrmEasy;
using System.Collections.Generic;
using PentaWork.Xrm.Scheduler.Proxies.Entities;

namespace PentaWork.Xrm.Scheduler.Tests.Fake
{
	public static class FakePostConfiguration
	{	
		#region FakeRelationships
		public static class Relationships 
		{
			/// <summary>1:N msdyn_postconfig_AsyncOperations</summary>
			public static readonly XrmFakedRelationship MsdynPostconfigAsyncOperations = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "msdyn_postconfigid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "msdyn_postconfig",
					Entity2LogicalName = "asyncoperation",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N msdyn_postconfig_BulkDeleteFailures</summary>
			public static readonly XrmFakedRelationship MsdynPostconfigBulkDeleteFailures = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "msdyn_postconfigid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "msdyn_postconfig",
					Entity2LogicalName = "bulkdeletefailure",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N msdyn_postconfig_MailboxTrackingFolders</summary>
			public static readonly XrmFakedRelationship MsdynPostconfigMailboxTrackingFolders = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "msdyn_postconfigid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "msdyn_postconfig",
					Entity2LogicalName = "mailboxtrackingfolder",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N msdyn_postconfig_msdyn_postruleconfig</summary>
			public static readonly XrmFakedRelationship MsdynPostconfigMsdynPostruleconfig = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "msdyn_postconfigid",
					Entity2Attribute = "msdyn_postconfigid",
					Entity1LogicalName = "msdyn_postconfig",
					Entity2LogicalName = "msdyn_postruleconfig",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N msdyn_postconfig_PrincipalObjectAttributeAccesses</summary>
			public static readonly XrmFakedRelationship MsdynPostconfigPrincipalObjectAttributeAccesses = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "msdyn_postconfigid",
					Entity2Attribute = "objectid",
					Entity1LogicalName = "msdyn_postconfig",
					Entity2LogicalName = "principalobjectattributeaccess",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N msdyn_postconfig_ProcessSession</summary>
			public static readonly XrmFakedRelationship MsdynPostconfigProcessSession = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "msdyn_postconfigid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "msdyn_postconfig",
					Entity2LogicalName = "processsession",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N msdyn_postconfig_SyncErrors</summary>
			public static readonly XrmFakedRelationship MsdynPostconfigSyncErrors = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "msdyn_postconfigid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "msdyn_postconfig",
					Entity2LogicalName = "syncerror",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N msdyn_postconfig_wallsavedquery</summary>
			public static readonly XrmFakedRelationship MsdynPostconfigWallsavedquery = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "msdyn_postconfigid",
					Entity2Attribute = "msdyn_postconfigurationid",
					Entity1LogicalName = "msdyn_postconfig",
					Entity2LogicalName = "msdyn_wallsavedquery",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

		}
		#endregion

		#region Fake
		public static PostConfiguration Create()
		{
			var faker = new Faker<PostConfiguration>()
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
			.RuleFor(e => e.WallEnabled, fake => fake.Random.Bool())
			.RuleFor(e => e.EntityDisplayName, fake => fake.Lorem.Word())
			.RuleFor(e => e.EntityName, fake => fake.Lorem.Word())
			.RuleFor(e => e.FollowingViewId, fake => fake.Lorem.Word())
			.RuleFor(e => e.FollowingViewId2, fake => fake.Lorem.Word())
			.RuleFor(e => e.ObjectTypeCode, fake => fake.Random.Int())
			.RuleFor(e => e.Id, fake => Guid.NewGuid())
			.RuleFor(e => e.ConfigurationStatus, fake => fake.Lorem.Word())
			.RuleFor(e => e.Organizationidname, fake => fake.Lorem.Word())
			.RuleFor(e => e.RecordCreatedOn, fake => fake.Date.Soon())
			.RuleFor(e => e.Status, fake => fake.PickRandom<PostConfiguration.eStatus>())
			.RuleFor(e => e.StatusReason, fake => fake.PickRandom<PostConfiguration.eStatusReason>())
			.RuleFor(e => e.TimeZoneRuleVersionNumber, fake => fake.Random.Int())
			.RuleFor(e => e.UTCConversionTimeZoneCode, fake => fake.Random.Int())
			.RuleFor(e => e.VersionNumber, fake => fake.Random.Int());
			return faker.Generate();
		}
		#endregion
	}
}

