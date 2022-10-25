using Bogus;
using System;
using FakeXrmEasy;
using System.Collections.Generic;
using PentaWork.Xrm.Scheduler.Proxies.Entities;

namespace PentaWork.Xrm.Scheduler.Tests.Fake
{
	public static class FakeWallView
	{	
		#region FakeRelationships
		public static class Relationships 
		{
			/// <summary>1:N msdyn_wallsavedquery_AsyncOperations</summary>
			public static readonly XrmFakedRelationship MsdynWallsavedqueryAsyncOperations = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "msdyn_wallsavedqueryid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "msdyn_wallsavedquery",
					Entity2LogicalName = "asyncoperation",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N msdyn_wallsavedquery_BulkDeleteFailures</summary>
			public static readonly XrmFakedRelationship MsdynWallsavedqueryBulkDeleteFailures = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "msdyn_wallsavedqueryid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "msdyn_wallsavedquery",
					Entity2LogicalName = "bulkdeletefailure",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N msdyn_wallsavedquery_MailboxTrackingFolders</summary>
			public static readonly XrmFakedRelationship MsdynWallsavedqueryMailboxTrackingFolders = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "msdyn_wallsavedqueryid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "msdyn_wallsavedquery",
					Entity2LogicalName = "mailboxtrackingfolder",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N msdyn_wallsavedquery_PrincipalObjectAttributeAccesses</summary>
			public static readonly XrmFakedRelationship MsdynWallsavedqueryPrincipalObjectAttributeAccesses = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "msdyn_wallsavedqueryid",
					Entity2Attribute = "objectid",
					Entity1LogicalName = "msdyn_wallsavedquery",
					Entity2LogicalName = "principalobjectattributeaccess",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N msdyn_wallsavedquery_ProcessSession</summary>
			public static readonly XrmFakedRelationship MsdynWallsavedqueryProcessSession = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "msdyn_wallsavedqueryid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "msdyn_wallsavedquery",
					Entity2LogicalName = "processsession",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N msdyn_wallsavedquery_SyncErrors</summary>
			public static readonly XrmFakedRelationship MsdynWallsavedquerySyncErrors = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "msdyn_wallsavedqueryid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "msdyn_wallsavedquery",
					Entity2LogicalName = "syncerror",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N msdyn_wallsavedquery_wallsavedqueryusersettings</summary>
			public static readonly XrmFakedRelationship MsdynWallsavedqueryWallsavedqueryusersettings = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "msdyn_wallsavedqueryid",
					Entity2Attribute = "msdyn_wallsavedqueryid",
					Entity1LogicalName = "msdyn_wallsavedquery",
					Entity2LogicalName = "msdyn_wallsavedqueryusersettings",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

		}
		#endregion

		#region Fake
		public static WallView Create()
		{
			var faker = new Faker<WallView>()
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
			.RuleFor(e => e.EntityDisplayName, fake => fake.Lorem.Word())
			.RuleFor(e => e.EntityName, fake => fake.Lorem.Word())
			.RuleFor(e => e.IsVirtual, fake => fake.Random.Bool())
			.RuleFor(e => e.Status, fake => fake.Random.Bool())
			.RuleFor(e => e.IsVisibleBit, fake => fake.Random.Int())
			.RuleFor(e => e.EntityType, fake => fake.Random.Int())
			.RuleFor(e => e.MsdynPostconfigurationidname, fake => fake.Lorem.Word())
			.RuleFor(e => e.ViewId, fake => fake.Lorem.Word())
			.RuleFor(e => e.Name, fake => fake.Lorem.Word())
			.RuleFor(e => e.Id, fake => Guid.NewGuid())
			.RuleFor(e => e.Organizationidname, fake => fake.Lorem.Word())
			.RuleFor(e => e.RecordCreatedOn, fake => fake.Date.Soon())
			.RuleFor(e => e.Status2, fake => fake.PickRandom<WallView.eStatus>())
			.RuleFor(e => e.StatusReason, fake => fake.PickRandom<WallView.eStatusReason>())
			.RuleFor(e => e.TimeZoneRuleVersionNumber, fake => fake.Random.Int())
			.RuleFor(e => e.UTCConversionTimeZoneCode, fake => fake.Random.Int())
			.RuleFor(e => e.VersionNumber, fake => fake.Random.Int());
			return faker.Generate();
		}
		#endregion
	}
}

