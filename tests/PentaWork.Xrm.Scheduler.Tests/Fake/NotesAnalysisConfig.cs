using Bogus;
using System;
using FakeXrmEasy;
using System.Collections.Generic;
using PentaWork.Xrm.Scheduler.Proxies.Entities;

namespace PentaWork.Xrm.Scheduler.Tests.Fake
{
	public static class FakeNotesAnalysisConfig
	{	
		#region FakeRelationships
		public static class Relationships 
		{
			/// <summary>1:N msdyn_notesanalysisconfig_AsyncOperations</summary>
			public static readonly XrmFakedRelationship MsdynNotesanalysisconfigAsyncOperations = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "msdyn_notesanalysisconfigid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "msdyn_notesanalysisconfig",
					Entity2LogicalName = "asyncoperation",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N msdyn_notesanalysisconfig_BulkDeleteFailures</summary>
			public static readonly XrmFakedRelationship MsdynNotesanalysisconfigBulkDeleteFailures = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "msdyn_notesanalysisconfigid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "msdyn_notesanalysisconfig",
					Entity2LogicalName = "bulkdeletefailure",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N msdyn_notesanalysisconfig_MailboxTrackingFolders</summary>
			public static readonly XrmFakedRelationship MsdynNotesanalysisconfigMailboxTrackingFolders = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "msdyn_notesanalysisconfigid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "msdyn_notesanalysisconfig",
					Entity2LogicalName = "mailboxtrackingfolder",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N msdyn_notesanalysisconfig_PrincipalObjectAttributeAccesses</summary>
			public static readonly XrmFakedRelationship MsdynNotesanalysisconfigPrincipalObjectAttributeAccesses = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "msdyn_notesanalysisconfigid",
					Entity2Attribute = "objectid",
					Entity1LogicalName = "msdyn_notesanalysisconfig",
					Entity2LogicalName = "principalobjectattributeaccess",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N msdyn_notesanalysisconfig_ProcessSession</summary>
			public static readonly XrmFakedRelationship MsdynNotesanalysisconfigProcessSession = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "msdyn_notesanalysisconfigid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "msdyn_notesanalysisconfig",
					Entity2LogicalName = "processsession",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N msdyn_notesanalysisconfig_SyncErrors</summary>
			public static readonly XrmFakedRelationship MsdynNotesanalysisconfigSyncErrors = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "msdyn_notesanalysisconfigid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "msdyn_notesanalysisconfig",
					Entity2LogicalName = "syncerror",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

		}
		#endregion

		#region Fake
		public static NotesAnalysisConfig Create()
		{
			var faker = new Faker<NotesAnalysisConfig>()
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
			.RuleFor(e => e.AreTermsAndConditionsAcceptedToConfigureNotesAnalysis, fake => fake.Random.Bool())
			.RuleFor(e => e.IsAdminSettingEnabled, fake => fake.Random.Bool())
			.RuleFor(e => e.Name, fake => fake.Lorem.Word())
			.RuleFor(e => e.Id, fake => Guid.NewGuid())
			.RuleFor(e => e.ThrottleLimit, fake => fake.Random.Int())
			.RuleFor(e => e.RecordCreatedOn, fake => fake.Date.Soon())
			.RuleFor(e => e.Owneridname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Owneridtype, fake => fake.Lorem.Word())
			.RuleFor(e => e.Owneridyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.Status, fake => fake.PickRandom<NotesAnalysisConfig.eStatus>())
			.RuleFor(e => e.StatusReason, fake => fake.PickRandom<NotesAnalysisConfig.eStatusReason>())
			.RuleFor(e => e.TimeZoneRuleVersionNumber, fake => fake.Random.Int())
			.RuleFor(e => e.UTCConversionTimeZoneCode, fake => fake.Random.Int())
			.RuleFor(e => e.VersionNumber, fake => fake.Random.Int());
			return faker.Generate();
		}
		#endregion
	}
}

