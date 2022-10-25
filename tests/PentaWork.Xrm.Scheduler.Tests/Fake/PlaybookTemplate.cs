using Bogus;
using System;
using FakeXrmEasy;
using System.Collections.Generic;
using PentaWork.Xrm.Scheduler.Proxies.Entities;

namespace PentaWork.Xrm.Scheduler.Tests.Fake
{
	public static class FakePlaybookTemplate
	{	
		#region FakeRelationships
		public static class Relationships 
		{
			/// <summary>1:N msdyn_playbooktemplate_Annotations</summary>
			public static readonly XrmFakedRelationship MsdynPlaybooktemplateAnnotations = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "msdyn_playbooktemplateid",
					Entity2Attribute = "objectid",
					Entity1LogicalName = "msdyn_playbooktemplate",
					Entity2LogicalName = "annotation",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N msdyn_playbooktemplate_AsyncOperations</summary>
			public static readonly XrmFakedRelationship MsdynPlaybooktemplateAsyncOperations = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "msdyn_playbooktemplateid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "msdyn_playbooktemplate",
					Entity2LogicalName = "asyncoperation",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N msdyn_playbooktemplate_BulkDeleteFailures</summary>
			public static readonly XrmFakedRelationship MsdynPlaybooktemplateBulkDeleteFailures = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "msdyn_playbooktemplateid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "msdyn_playbooktemplate",
					Entity2LogicalName = "bulkdeletefailure",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N msdyn_playbooktemplate_DuplicateBaseRecord</summary>
			public static readonly XrmFakedRelationship MsdynPlaybooktemplateDuplicateBaseRecord = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "msdyn_playbooktemplateid",
					Entity2Attribute = "baserecordid",
					Entity1LogicalName = "msdyn_playbooktemplate",
					Entity2LogicalName = "duplicaterecord",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N msdyn_playbooktemplate_DuplicateMatchingRecord</summary>
			public static readonly XrmFakedRelationship MsdynPlaybooktemplateDuplicateMatchingRecord = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "msdyn_playbooktemplateid",
					Entity2Attribute = "duplicaterecordid",
					Entity1LogicalName = "msdyn_playbooktemplate",
					Entity2LogicalName = "duplicaterecord",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N msdyn_playbooktemplate_MailboxTrackingFolders</summary>
			public static readonly XrmFakedRelationship MsdynPlaybooktemplateMailboxTrackingFolders = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "msdyn_playbooktemplateid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "msdyn_playbooktemplate",
					Entity2LogicalName = "mailboxtrackingfolder",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N msdyn_playbooktemplate_msdyn_playbookactivity</summary>
			public static readonly XrmFakedRelationship MsdynPlaybooktemplateMsdynPlaybookactivity = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "msdyn_playbooktemplateid",
					Entity2Attribute = "msdyn_playbooktemplateid",
					Entity1LogicalName = "msdyn_playbooktemplate",
					Entity2LogicalName = "msdyn_playbookactivity",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N msdyn_playbooktemplate_msdyn_playbookinstance</summary>
			public static readonly XrmFakedRelationship MsdynPlaybooktemplateMsdynPlaybookinstance = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "msdyn_playbooktemplateid",
					Entity2Attribute = "msdyn_playbooktemplateid",
					Entity1LogicalName = "msdyn_playbooktemplate",
					Entity2LogicalName = "msdyn_playbookinstance",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N msdyn_playbooktemplate_PrincipalObjectAttributeAccesses</summary>
			public static readonly XrmFakedRelationship MsdynPlaybooktemplatePrincipalObjectAttributeAccesses = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "msdyn_playbooktemplateid",
					Entity2Attribute = "objectid",
					Entity1LogicalName = "msdyn_playbooktemplate",
					Entity2LogicalName = "principalobjectattributeaccess",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N msdyn_playbooktemplate_ProcessSession</summary>
			public static readonly XrmFakedRelationship MsdynPlaybooktemplateProcessSession = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "msdyn_playbooktemplateid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "msdyn_playbooktemplate",
					Entity2LogicalName = "processsession",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N msdyn_playbooktemplate_SyncErrors</summary>
			public static readonly XrmFakedRelationship MsdynPlaybooktemplateSyncErrors = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "msdyn_playbooktemplateid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "msdyn_playbooktemplate",
					Entity2LogicalName = "syncerror",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>N:N msdyn_callablecontext_msdyn_playbooktemplate</summary>
			public static readonly XrmFakedRelationship MsdynCallablecontextMsdynPlaybooktemplate = 
				new XrmFakedRelationship
				{
					IntersectEntity = "msdyn_callablecontext_msdyn_playbooktemplate",
					Entity1Attribute = "msdyn_callablecontextid",
					Entity2Attribute = "msdyn_playbooktemplateid",
					Entity1LogicalName = "msdyn_callablecontext",
					Entity2LogicalName = "msdyn_playbooktemplate",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.ManyToMany
				};

		}
		#endregion

		#region Fake
		public static PlaybookTemplate Create()
		{
			var faker = new Faker<PlaybookTemplate>()
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
			.RuleFor(e => e.MsdynCategoryidname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Description, fake => fake.Lorem.Word())
			.RuleFor(e => e.EstimatedDurationdays, fake => fake.Random.Int())
			.RuleFor(e => e.EntitiesEnabledForPlaybook, fake => fake.Lorem.Word())
			.RuleFor(e => e.Name, fake => fake.Lorem.Word())
			.RuleFor(e => e.Id, fake => Guid.NewGuid())
			.RuleFor(e => e.EntitiesToWhichAPlaybookApplies, fake => fake.Lorem.Word())
			.RuleFor(e => e.TrackProgress, fake => fake.Random.Bool())
			.RuleFor(e => e.RecordCreatedOn, fake => fake.Date.Soon())
			.RuleFor(e => e.Owneridname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Owneridtype, fake => fake.Lorem.Word())
			.RuleFor(e => e.Owneridyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.Status, fake => fake.PickRandom<PlaybookTemplate.eStatus>())
			.RuleFor(e => e.StatusReason, fake => fake.PickRandom<PlaybookTemplate.eStatusReason>())
			.RuleFor(e => e.TimeZoneRuleVersionNumber, fake => fake.Random.Int())
			.RuleFor(e => e.UTCConversionTimeZoneCode, fake => fake.Random.Int())
			.RuleFor(e => e.VersionNumber, fake => fake.Random.Int());
			return faker.Generate();
		}
		#endregion
	}
}

