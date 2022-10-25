using Bogus;
using System;
using FakeXrmEasy;
using System.Collections.Generic;
using PentaWork.Xrm.Scheduler.Proxies.Entities;

namespace PentaWork.Xrm.Scheduler.Tests.Fake
{
	public static class FakePlaybookCallableContext
	{	
		#region FakeRelationships
		public static class Relationships 
		{
			/// <summary>1:N msdyn_callablecontext_AsyncOperations</summary>
			public static readonly XrmFakedRelationship MsdynCallablecontextAsyncOperations = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "msdyn_callablecontextid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "msdyn_callablecontext",
					Entity2LogicalName = "asyncoperation",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N msdyn_callablecontext_BulkDeleteFailures</summary>
			public static readonly XrmFakedRelationship MsdynCallablecontextBulkDeleteFailures = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "msdyn_callablecontextid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "msdyn_callablecontext",
					Entity2LogicalName = "bulkdeletefailure",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N msdyn_callablecontext_DuplicateBaseRecord</summary>
			public static readonly XrmFakedRelationship MsdynCallablecontextDuplicateBaseRecord = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "msdyn_callablecontextid",
					Entity2Attribute = "baserecordid",
					Entity1LogicalName = "msdyn_callablecontext",
					Entity2LogicalName = "duplicaterecord",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N msdyn_callablecontext_DuplicateMatchingRecord</summary>
			public static readonly XrmFakedRelationship MsdynCallablecontextDuplicateMatchingRecord = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "msdyn_callablecontextid",
					Entity2Attribute = "duplicaterecordid",
					Entity1LogicalName = "msdyn_callablecontext",
					Entity2LogicalName = "duplicaterecord",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N msdyn_callablecontext_MailboxTrackingFolders</summary>
			public static readonly XrmFakedRelationship MsdynCallablecontextMailboxTrackingFolders = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "msdyn_callablecontextid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "msdyn_callablecontext",
					Entity2LogicalName = "mailboxtrackingfolder",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N msdyn_callablecontext_PrincipalObjectAttributeAccesses</summary>
			public static readonly XrmFakedRelationship MsdynCallablecontextPrincipalObjectAttributeAccesses = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "msdyn_callablecontextid",
					Entity2Attribute = "objectid",
					Entity1LogicalName = "msdyn_callablecontext",
					Entity2LogicalName = "principalobjectattributeaccess",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N msdyn_callablecontext_ProcessSession</summary>
			public static readonly XrmFakedRelationship MsdynCallablecontextProcessSession = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "msdyn_callablecontextid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "msdyn_callablecontext",
					Entity2LogicalName = "processsession",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N msdyn_callablecontext_SyncErrors</summary>
			public static readonly XrmFakedRelationship MsdynCallablecontextSyncErrors = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "msdyn_callablecontextid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "msdyn_callablecontext",
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
		public static PlaybookCallableContext Create()
		{
			var faker = new Faker<PlaybookCallableContext>()
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
			.RuleFor(e => e.Name, fake => fake.Lorem.Word())
			.RuleFor(e => e.RecordType, fake => fake.PickRandom<PlaybookCallableContext.eEntity>())
			.RuleFor(e => e.RecordCreatedOn, fake => fake.Date.Soon())
			.RuleFor(e => e.Owneridname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Owneridtype, fake => fake.Lorem.Word())
			.RuleFor(e => e.Owneridyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.Status, fake => fake.PickRandom<PlaybookCallableContext.eStatus>())
			.RuleFor(e => e.StatusReason, fake => fake.PickRandom<PlaybookCallableContext.eStatusReason>())
			.RuleFor(e => e.TimeZoneRuleVersionNumber, fake => fake.Random.Int())
			.RuleFor(e => e.UTCConversionTimeZoneCode, fake => fake.Random.Int())
			.RuleFor(e => e.VersionNumber, fake => fake.Random.Int());
			return faker.Generate();
		}
		#endregion
	}
}

