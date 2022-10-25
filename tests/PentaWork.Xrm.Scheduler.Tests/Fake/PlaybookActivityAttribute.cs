using Bogus;
using System;
using FakeXrmEasy;
using System.Collections.Generic;
using PentaWork.Xrm.Scheduler.Proxies.Entities;

namespace PentaWork.Xrm.Scheduler.Tests.Fake
{
	public static class FakePlaybookActivityAttribute
	{	
		#region FakeRelationships
		public static class Relationships 
		{
			/// <summary>1:N msdyn_playbookactivityattribute_AsyncOperations</summary>
			public static readonly XrmFakedRelationship MsdynPlaybookactivityattributeAsyncOperations = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "msdyn_playbookactivityattributeid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "msdyn_playbookactivityattribute",
					Entity2LogicalName = "asyncoperation",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N msdyn_playbookactivityattribute_BulkDeleteFailures</summary>
			public static readonly XrmFakedRelationship MsdynPlaybookactivityattributeBulkDeleteFailures = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "msdyn_playbookactivityattributeid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "msdyn_playbookactivityattribute",
					Entity2LogicalName = "bulkdeletefailure",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N msdyn_playbookactivityattribute_DuplicateBaseRecord</summary>
			public static readonly XrmFakedRelationship MsdynPlaybookactivityattributeDuplicateBaseRecord = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "msdyn_playbookactivityattributeid",
					Entity2Attribute = "baserecordid",
					Entity1LogicalName = "msdyn_playbookactivityattribute",
					Entity2LogicalName = "duplicaterecord",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N msdyn_playbookactivityattribute_DuplicateMatchingRecord</summary>
			public static readonly XrmFakedRelationship MsdynPlaybookactivityattributeDuplicateMatchingRecord = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "msdyn_playbookactivityattributeid",
					Entity2Attribute = "duplicaterecordid",
					Entity1LogicalName = "msdyn_playbookactivityattribute",
					Entity2LogicalName = "duplicaterecord",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N msdyn_playbookactivityattribute_MailboxTrackingFolders</summary>
			public static readonly XrmFakedRelationship MsdynPlaybookactivityattributeMailboxTrackingFolders = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "msdyn_playbookactivityattributeid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "msdyn_playbookactivityattribute",
					Entity2LogicalName = "mailboxtrackingfolder",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N msdyn_playbookactivityattribute_PrincipalObjectAttributeAccesses</summary>
			public static readonly XrmFakedRelationship MsdynPlaybookactivityattributePrincipalObjectAttributeAccesses = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "msdyn_playbookactivityattributeid",
					Entity2Attribute = "objectid",
					Entity1LogicalName = "msdyn_playbookactivityattribute",
					Entity2LogicalName = "principalobjectattributeaccess",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N msdyn_playbookactivityattribute_ProcessSession</summary>
			public static readonly XrmFakedRelationship MsdynPlaybookactivityattributeProcessSession = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "msdyn_playbookactivityattributeid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "msdyn_playbookactivityattribute",
					Entity2LogicalName = "processsession",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N msdyn_playbookactivityattribute_SyncErrors</summary>
			public static readonly XrmFakedRelationship MsdynPlaybookactivityattributeSyncErrors = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "msdyn_playbookactivityattributeid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "msdyn_playbookactivityattribute",
					Entity2LogicalName = "syncerror",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

		}
		#endregion

		#region Fake
		public static PlaybookActivityAttribute Create()
		{
			var faker = new Faker<PlaybookActivityAttribute>()
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
			.RuleFor(e => e.AttributeName, fake => fake.Lorem.Word())
			.RuleFor(e => e.AttributeType, fake => fake.PickRandom<PlaybookActivityAttribute.eAttributeTypes>())
			.RuleFor(e => e.AttributeValue, fake => fake.Lorem.Word())
			.RuleFor(e => e.Id, fake => Guid.NewGuid())
			.RuleFor(e => e.MsdynPlaybookactivityidname, fake => fake.Lorem.Word())
			.RuleFor(e => e.RecordCreatedOn, fake => fake.Date.Soon())
			.RuleFor(e => e.Owneridname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Owneridtype, fake => fake.Lorem.Word())
			.RuleFor(e => e.Owneridyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.Status, fake => fake.PickRandom<PlaybookActivityAttribute.eStatus>())
			.RuleFor(e => e.StatusReason, fake => fake.PickRandom<PlaybookActivityAttribute.eStatusReason>())
			.RuleFor(e => e.TimeZoneRuleVersionNumber, fake => fake.Random.Int())
			.RuleFor(e => e.UTCConversionTimeZoneCode, fake => fake.Random.Int())
			.RuleFor(e => e.VersionNumber, fake => fake.Random.Int());
			return faker.Generate();
		}
		#endregion
	}
}

