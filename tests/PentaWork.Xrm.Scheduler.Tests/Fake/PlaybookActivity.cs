using Bogus;
using System;
using FakeXrmEasy;
using System.Collections.Generic;
using PentaWork.Xrm.Scheduler.Proxies.Entities;

namespace PentaWork.Xrm.Scheduler.Tests.Fake
{
	public static class FakePlaybookActivity
	{	
		#region FakeRelationships
		public static class Relationships 
		{
			/// <summary>1:N msdyn_playbookactivity_AsyncOperations</summary>
			public static readonly XrmFakedRelationship MsdynPlaybookactivityAsyncOperations = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "msdyn_playbookactivityid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "msdyn_playbookactivity",
					Entity2LogicalName = "asyncoperation",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N msdyn_playbookactivity_BulkDeleteFailures</summary>
			public static readonly XrmFakedRelationship MsdynPlaybookactivityBulkDeleteFailures = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "msdyn_playbookactivityid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "msdyn_playbookactivity",
					Entity2LogicalName = "bulkdeletefailure",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N msdyn_playbookactivity_DuplicateBaseRecord</summary>
			public static readonly XrmFakedRelationship MsdynPlaybookactivityDuplicateBaseRecord = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "msdyn_playbookactivityid",
					Entity2Attribute = "baserecordid",
					Entity1LogicalName = "msdyn_playbookactivity",
					Entity2LogicalName = "duplicaterecord",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N msdyn_playbookactivity_DuplicateMatchingRecord</summary>
			public static readonly XrmFakedRelationship MsdynPlaybookactivityDuplicateMatchingRecord = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "msdyn_playbookactivityid",
					Entity2Attribute = "duplicaterecordid",
					Entity1LogicalName = "msdyn_playbookactivity",
					Entity2LogicalName = "duplicaterecord",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N msdyn_playbookactivity_MailboxTrackingFolders</summary>
			public static readonly XrmFakedRelationship MsdynPlaybookactivityMailboxTrackingFolders = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "msdyn_playbookactivityid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "msdyn_playbookactivity",
					Entity2LogicalName = "mailboxtrackingfolder",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N msdyn_playbookactivity_msdyn_playbookactivityattribute</summary>
			public static readonly XrmFakedRelationship MsdynPlaybookactivityMsdynPlaybookactivityattribute = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "msdyn_playbookactivityid",
					Entity2Attribute = "msdyn_playbookactivityid",
					Entity1LogicalName = "msdyn_playbookactivity",
					Entity2LogicalName = "msdyn_playbookactivityattribute",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N msdyn_playbookactivity_PrincipalObjectAttributeAccesses</summary>
			public static readonly XrmFakedRelationship MsdynPlaybookactivityPrincipalObjectAttributeAccesses = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "msdyn_playbookactivityid",
					Entity2Attribute = "objectid",
					Entity1LogicalName = "msdyn_playbookactivity",
					Entity2LogicalName = "principalobjectattributeaccess",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N msdyn_playbookactivity_ProcessSession</summary>
			public static readonly XrmFakedRelationship MsdynPlaybookactivityProcessSession = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "msdyn_playbookactivityid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "msdyn_playbookactivity",
					Entity2LogicalName = "processsession",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N msdyn_playbookactivity_SharePointDocumentLocations</summary>
			public static readonly XrmFakedRelationship MsdynPlaybookactivitySharePointDocumentLocations = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "msdyn_playbookactivityid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "msdyn_playbookactivity",
					Entity2LogicalName = "sharepointdocumentlocation",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N msdyn_playbookactivity_SyncErrors</summary>
			public static readonly XrmFakedRelationship MsdynPlaybookactivitySyncErrors = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "msdyn_playbookactivityid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "msdyn_playbookactivity",
					Entity2LogicalName = "syncerror",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

		}
		#endregion

		#region Fake
		public static PlaybookActivity Create()
		{
			var faker = new Faker<PlaybookActivity>()
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
			.RuleFor(e => e.ActivityLogicalName, fake => fake.Lorem.Word())
			.RuleFor(e => e.ActivityType, fake => fake.PickRandom<PlaybookActivity.eEntities>())
			.RuleFor(e => e.PlaybookActivityJSON, fake => fake.Lorem.Word())
			.RuleFor(e => e.Id, fake => Guid.NewGuid())
			.RuleFor(e => e.MsdynPlaybooktemplateidname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Subject, fake => fake.Lorem.Word())
			.RuleFor(e => e.RecordCreatedOn, fake => fake.Date.Soon())
			.RuleFor(e => e.Owneridname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Owneridtype, fake => fake.Lorem.Word())
			.RuleFor(e => e.Owneridyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.Status, fake => fake.PickRandom<PlaybookActivity.eStatus>())
			.RuleFor(e => e.StatusReason, fake => fake.PickRandom<PlaybookActivity.eStatusReason>())
			.RuleFor(e => e.TimeZoneRuleVersionNumber, fake => fake.Random.Int())
			.RuleFor(e => e.UTCConversionTimeZoneCode, fake => fake.Random.Int())
			.RuleFor(e => e.VersionNumber, fake => fake.Random.Int());
			return faker.Generate();
		}
		#endregion
	}
}

