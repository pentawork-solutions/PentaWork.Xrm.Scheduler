using Bogus;
using System;
using FakeXrmEasy;
using System.Collections.Generic;
using PentaWork.Xrm.Scheduler.Proxies.Entities;

namespace PentaWork.Xrm.Scheduler.Tests.Fake
{
	public static class FakeSchedulingGroup
	{	
		#region FakeRelationships
		public static class Relationships 
		{
			/// <summary>1:N ResourceGroup_AsyncOperations</summary>
			public static readonly XrmFakedRelationship ResourceGroupAsyncOperations = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "resourcegroupid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "resourcegroup",
					Entity2LogicalName = "asyncoperation",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N ResourceGroup_BulkDeleteFailures</summary>
			public static readonly XrmFakedRelationship ResourceGroupBulkDeleteFailures = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "resourcegroupid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "resourcegroup",
					Entity2LogicalName = "bulkdeletefailure",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N resourcegroup_connections1</summary>
			public static readonly XrmFakedRelationship ResourcegroupConnections1 = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "resourcegroupid",
					Entity2Attribute = "record1id",
					Entity1LogicalName = "resourcegroup",
					Entity2LogicalName = "connection",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N resourcegroup_connections2</summary>
			public static readonly XrmFakedRelationship ResourcegroupConnections2 = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "resourcegroupid",
					Entity2Attribute = "record2id",
					Entity1LogicalName = "resourcegroup",
					Entity2LogicalName = "connection",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N ResourceGroup_DuplicateBaseRecord</summary>
			public static readonly XrmFakedRelationship ResourceGroupDuplicateBaseRecord = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "resourcegroupid",
					Entity2Attribute = "baserecordid",
					Entity1LogicalName = "resourcegroup",
					Entity2LogicalName = "duplicaterecord",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N ResourceGroup_DuplicateMatchingRecord</summary>
			public static readonly XrmFakedRelationship ResourceGroupDuplicateMatchingRecord = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "resourcegroupid",
					Entity2Attribute = "duplicaterecordid",
					Entity1LogicalName = "resourcegroup",
					Entity2LogicalName = "duplicaterecord",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N resourcegroup_MailboxTrackingFolders</summary>
			public static readonly XrmFakedRelationship ResourcegroupMailboxTrackingFolders = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "resourcegroupid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "resourcegroup",
					Entity2LogicalName = "mailboxtrackingfolder",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N resourcegroup_PrincipalObjectAttributeAccesses</summary>
			public static readonly XrmFakedRelationship ResourcegroupPrincipalObjectAttributeAccesses = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "resourcegroupid",
					Entity2Attribute = "objectid",
					Entity1LogicalName = "resourcegroup",
					Entity2LogicalName = "principalobjectattributeaccess",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N ResourceGroup_SyncErrors</summary>
			public static readonly XrmFakedRelationship ResourceGroupSyncErrors = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "resourcegroupid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "resourcegroup",
					Entity2LogicalName = "syncerror",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

		}
		#endregion

		#region Fake
		public static SchedulingGroup Create()
		{
			var faker = new Faker<SchedulingGroup>()
			.RuleFor(e => e.Businessunitidname, fake => fake.Lorem.Word())
			.RuleFor(e => e.GroupTypeCode, fake => fake.PickRandom<SchedulingGroup.eResourcegroupGrouptypecode>())
			.RuleFor(e => e.ImportSequenceNumber, fake => fake.Random.Int())
			.RuleFor(e => e.Name, fake => fake.Lorem.Word())
			.RuleFor(e => e.Entity, fake => fake.Lorem.Word())
			.RuleFor(e => e.Organizationidname, fake => fake.Lorem.Word())
			.RuleFor(e => e.RecordCreatedOn, fake => fake.Date.Soon())
			.RuleFor(e => e.Id, fake => Guid.NewGuid())
			.RuleFor(e => e.TimeZoneRuleVersionNumber, fake => fake.Random.Int())
			.RuleFor(e => e.UTCConversionTimeZoneCode, fake => fake.Random.Int())
			.RuleFor(e => e.VersionNumber, fake => fake.Random.Int());
			return faker.Generate();
		}
		#endregion
	}
}

