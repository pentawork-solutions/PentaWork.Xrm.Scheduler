using Bogus;
using System;
using FakeXrmEasy;
using System.Collections.Generic;
using PentaWork.Xrm.Scheduler.Proxies.Entities;

namespace PentaWork.Xrm.Scheduler.Tests.Fake
{
	public static class FakeFilter
	{	
		#region FakeRelationships
		public static class Relationships 
		{
			/// <summary>1:N msdyn_wallsavedqueryusersettings_AsyncOperations</summary>
			public static readonly XrmFakedRelationship MsdynWallsavedqueryusersettingsAsyncOperations = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "msdyn_wallsavedqueryusersettingsid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "msdyn_wallsavedqueryusersettings",
					Entity2LogicalName = "asyncoperation",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N msdyn_wallsavedqueryusersettings_BulkDeleteFailures</summary>
			public static readonly XrmFakedRelationship MsdynWallsavedqueryusersettingsBulkDeleteFailures = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "msdyn_wallsavedqueryusersettingsid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "msdyn_wallsavedqueryusersettings",
					Entity2LogicalName = "bulkdeletefailure",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N msdyn_wallsavedqueryusersettings_MailboxTrackingFolders</summary>
			public static readonly XrmFakedRelationship MsdynWallsavedqueryusersettingsMailboxTrackingFolders = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "msdyn_wallsavedqueryusersettingsid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "msdyn_wallsavedqueryusersettings",
					Entity2LogicalName = "mailboxtrackingfolder",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N msdyn_wallsavedqueryusersettings_PrincipalObjectAttributeAccesses</summary>
			public static readonly XrmFakedRelationship MsdynWallsavedqueryusersettingsPrincipalObjectAttributeAccesses = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "msdyn_wallsavedqueryusersettingsid",
					Entity2Attribute = "objectid",
					Entity1LogicalName = "msdyn_wallsavedqueryusersettings",
					Entity2LogicalName = "principalobjectattributeaccess",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N msdyn_wallsavedqueryusersettings_ProcessSession</summary>
			public static readonly XrmFakedRelationship MsdynWallsavedqueryusersettingsProcessSession = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "msdyn_wallsavedqueryusersettingsid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "msdyn_wallsavedqueryusersettings",
					Entity2LogicalName = "processsession",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N msdyn_wallsavedqueryusersettings_SyncErrors</summary>
			public static readonly XrmFakedRelationship MsdynWallsavedqueryusersettingsSyncErrors = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "msdyn_wallsavedqueryusersettingsid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "msdyn_wallsavedqueryusersettings",
					Entity2LogicalName = "syncerror",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

		}
		#endregion

		#region Fake
		public static Filter Create()
		{
			var faker = new Faker<Filter>()
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
			.RuleFor(e => e.Data, fake => fake.Lorem.Word())
			.RuleFor(e => e.Default, fake => fake.Random.Int())
			.RuleFor(e => e.EntityDisplayName, fake => fake.Lorem.Word())
			.RuleFor(e => e.EntityName, fake => fake.Lorem.Word())
			.RuleFor(e => e.IncludeWallInResponse, fake => fake.Random.Bool())
			.RuleFor(e => e.IsFollowing, fake => fake.Random.Bool())
			.RuleFor(e => e.IsVirtual, fake => fake.Random.Bool())
			.RuleFor(e => e.DisplayOnTheWall, fake => fake.Random.Bool())
			.RuleFor(e => e.IsVisibleBit, fake => fake.Random.Int())
			.RuleFor(e => e.EntityType, fake => fake.Random.Int())
			.RuleFor(e => e.ViewName, fake => fake.Lorem.Word())
			.RuleFor(e => e.SortOrder, fake => fake.Random.Int())
			.RuleFor(e => e.Type, fake => fake.Random.Int())
			.RuleFor(e => e.MsdynUseridname, fake => fake.Lorem.Word())
			.RuleFor(e => e.MsdynUseridyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.MsdynWallsavedqueryidname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Id, fake => Guid.NewGuid())
			.RuleFor(e => e.RecordCreatedOn, fake => fake.Date.Soon())
			.RuleFor(e => e.Owneridname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Owneridtype, fake => fake.Lorem.Word())
			.RuleFor(e => e.Owneridyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.Status, fake => fake.PickRandom<Filter.eStatus>())
			.RuleFor(e => e.StatusReason, fake => fake.PickRandom<Filter.eStatusReason>())
			.RuleFor(e => e.TimeZoneRuleVersionNumber, fake => fake.Random.Int())
			.RuleFor(e => e.UTCConversionTimeZoneCode, fake => fake.Random.Int())
			.RuleFor(e => e.VersionNumber, fake => fake.Random.Int());
			return faker.Generate();
		}
		#endregion
	}
}

