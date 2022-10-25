using Bogus;
using System;
using FakeXrmEasy;
using System.Collections.Generic;
using PentaWork.Xrm.Scheduler.Proxies.Entities;

namespace PentaWork.Xrm.Scheduler.Tests.Fake
{
	public static class FakeAutoCaptureSettings
	{	
		#region FakeRelationships
		public static class Relationships 
		{
			/// <summary>1:N msdyn_autocapturesettings_AsyncOperations</summary>
			public static readonly XrmFakedRelationship MsdynAutocapturesettingsAsyncOperations = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "msdyn_autocapturesettingsid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "msdyn_autocapturesettings",
					Entity2LogicalName = "asyncoperation",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N msdyn_autocapturesettings_BulkDeleteFailures</summary>
			public static readonly XrmFakedRelationship MsdynAutocapturesettingsBulkDeleteFailures = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "msdyn_autocapturesettingsid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "msdyn_autocapturesettings",
					Entity2LogicalName = "bulkdeletefailure",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N msdyn_autocapturesettings_DuplicateBaseRecord</summary>
			public static readonly XrmFakedRelationship MsdynAutocapturesettingsDuplicateBaseRecord = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "msdyn_autocapturesettingsid",
					Entity2Attribute = "baserecordid",
					Entity1LogicalName = "msdyn_autocapturesettings",
					Entity2LogicalName = "duplicaterecord",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N msdyn_autocapturesettings_DuplicateMatchingRecord</summary>
			public static readonly XrmFakedRelationship MsdynAutocapturesettingsDuplicateMatchingRecord = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "msdyn_autocapturesettingsid",
					Entity2Attribute = "duplicaterecordid",
					Entity1LogicalName = "msdyn_autocapturesettings",
					Entity2LogicalName = "duplicaterecord",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N msdyn_autocapturesettings_MailboxTrackingFolders</summary>
			public static readonly XrmFakedRelationship MsdynAutocapturesettingsMailboxTrackingFolders = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "msdyn_autocapturesettingsid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "msdyn_autocapturesettings",
					Entity2LogicalName = "mailboxtrackingfolder",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N msdyn_autocapturesettings_PrincipalObjectAttributeAccesses</summary>
			public static readonly XrmFakedRelationship MsdynAutocapturesettingsPrincipalObjectAttributeAccesses = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "msdyn_autocapturesettingsid",
					Entity2Attribute = "objectid",
					Entity1LogicalName = "msdyn_autocapturesettings",
					Entity2LogicalName = "principalobjectattributeaccess",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N msdyn_autocapturesettings_ProcessSession</summary>
			public static readonly XrmFakedRelationship MsdynAutocapturesettingsProcessSession = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "msdyn_autocapturesettingsid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "msdyn_autocapturesettings",
					Entity2LogicalName = "processsession",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N msdyn_autocapturesettings_SyncErrors</summary>
			public static readonly XrmFakedRelationship MsdynAutocapturesettingsSyncErrors = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "msdyn_autocapturesettingsid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "msdyn_autocapturesettings",
					Entity2LogicalName = "syncerror",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

		}
		#endregion

		#region Fake
		public static AutoCaptureSettings Create()
		{
			var faker = new Faker<AutoCaptureSettings>()
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
			.RuleFor(e => e.AutoCapture, fake => fake.Random.Bool())
			.RuleFor(e => e.Id, fake => Guid.NewGuid())
			.RuleFor(e => e.AutoCaptureV1, fake => fake.Random.Bool())
			.RuleFor(e => e.AutomaticActivityUpdate, fake => fake.Random.Bool())
			.RuleFor(e => e.Calendar, fake => fake.Random.Bool())
			.RuleFor(e => e.Contacts, fake => fake.Random.Bool())
			.RuleFor(e => e.DefaultAssociation, fake => fake.Lorem.Word())
			.RuleFor(e => e.DontShowDialogSettingsForSuggestions, fake => fake.Lorem.Word())
			.RuleFor(e => e.Emails, fake => fake.Random.Bool())
			.RuleFor(e => e.Meetings, fake => fake.Random.Bool())
			.RuleFor(e => e.Name, fake => fake.Lorem.Word())
			.RuleFor(e => e.OrganizationId, fake => fake.Lorem.Word())
			.RuleFor(e => e.SettingsUIAction, fake => fake.Lorem.Word())
			.RuleFor(e => e.UserId, fake => fake.Lorem.Word())
			.RuleFor(e => e.V1TERMSANDCONDITIONSCOUNT, fake => fake.Lorem.Word())
			.RuleFor(e => e.V2TERMSANDCONDITIONSCOUNT, fake => fake.Lorem.Word())
			.RuleFor(e => e.RecordCreatedOn, fake => fake.Date.Soon())
			.RuleFor(e => e.Owneridname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Owneridtype, fake => fake.Lorem.Word())
			.RuleFor(e => e.Owneridyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.Status, fake => fake.PickRandom<AutoCaptureSettings.eStatus>())
			.RuleFor(e => e.StatusReason, fake => fake.PickRandom<AutoCaptureSettings.eStatusReason>())
			.RuleFor(e => e.TimeZoneRuleVersionNumber, fake => fake.Random.Int())
			.RuleFor(e => e.UTCConversionTimeZoneCode, fake => fake.Random.Int())
			.RuleFor(e => e.VersionNumber, fake => fake.Random.Int());
			return faker.Generate();
		}
		#endregion
	}
}

