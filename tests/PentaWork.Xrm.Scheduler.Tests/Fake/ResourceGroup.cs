using Bogus;
using System;
using FakeXrmEasy;
using System.Collections.Generic;
using PentaWork.Xrm.Scheduler.Proxies.Entities;

namespace PentaWork.Xrm.Scheduler.Tests.Fake
{
	public static class FakeResourceGroup
	{	
		#region FakeRelationships
		public static class Relationships 
		{
			/// <summary>1:N constraint_based_group_resource_specs</summary>
			public static readonly XrmFakedRelationship ConstraintBasedGroupResourceSpecs = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "constraintbasedgroupid",
					Entity2Attribute = "groupobjectid",
					Entity1LogicalName = "constraintbasedgroup",
					Entity2LogicalName = "resourcespec",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N ConstraintBasedGroup_AsyncOperations</summary>
			public static readonly XrmFakedRelationship ConstraintBasedGroupAsyncOperations = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "constraintbasedgroupid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "constraintbasedgroup",
					Entity2LogicalName = "asyncoperation",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N ConstraintBasedGroup_BulkDeleteFailures</summary>
			public static readonly XrmFakedRelationship ConstraintBasedGroupBulkDeleteFailures = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "constraintbasedgroupid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "constraintbasedgroup",
					Entity2LogicalName = "bulkdeletefailure",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N constraintbasedgroup_connections1</summary>
			public static readonly XrmFakedRelationship ConstraintbasedgroupConnections1 = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "constraintbasedgroupid",
					Entity2Attribute = "record1id",
					Entity1LogicalName = "constraintbasedgroup",
					Entity2LogicalName = "connection",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N constraintbasedgroup_connections2</summary>
			public static readonly XrmFakedRelationship ConstraintbasedgroupConnections2 = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "constraintbasedgroupid",
					Entity2Attribute = "record2id",
					Entity1LogicalName = "constraintbasedgroup",
					Entity2LogicalName = "connection",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N constraintbasedgroup_MailboxTrackingFolders</summary>
			public static readonly XrmFakedRelationship ConstraintbasedgroupMailboxTrackingFolders = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "constraintbasedgroupid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "constraintbasedgroup",
					Entity2LogicalName = "mailboxtrackingfolder",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N constraintbasedgroup_PrincipalObjectAttributeAccesses</summary>
			public static readonly XrmFakedRelationship ConstraintbasedgroupPrincipalObjectAttributeAccesses = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "constraintbasedgroupid",
					Entity2Attribute = "objectid",
					Entity1LogicalName = "constraintbasedgroup",
					Entity2LogicalName = "principalobjectattributeaccess",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N ConstraintBasedGroup_ProcessSessions</summary>
			public static readonly XrmFakedRelationship ConstraintBasedGroupProcessSessions = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "constraintbasedgroupid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "constraintbasedgroup",
					Entity2LogicalName = "processsession",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N constraintbasedgroup_resource_groups</summary>
			public static readonly XrmFakedRelationship ConstraintbasedgroupResourceGroups = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "constraintbasedgroupid",
					Entity2Attribute = "resourcegroupid",
					Entity1LogicalName = "constraintbasedgroup",
					Entity2LogicalName = "resourcegroup",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N constraintbasedgroup_SyncErrors</summary>
			public static readonly XrmFakedRelationship ConstraintbasedgroupSyncErrors = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "constraintbasedgroupid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "constraintbasedgroup",
					Entity2LogicalName = "syncerror",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N constraintbasedgroup_virtualresourceg</summary>
			public static readonly XrmFakedRelationship ConstraintbasedgroupVirtualresourceg = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "constraintbasedgroupid",
					Entity2Attribute = "resourcegroupid",
					Entity1LogicalName = "constraintbasedgroup",
					Entity2LogicalName = "virtualresourcegroupresource",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

		}
		#endregion

		#region Fake
		public static ResourceGroup Create()
		{
			var faker = new Faker<ResourceGroup>()
			.RuleFor(e => e.Businessunitidname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Id, fake => Guid.NewGuid())
			.RuleFor(e => e.Constraints, fake => fake.Lorem.Word())
			.RuleFor(e => e.Createdbyname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Createdbyyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.CreatedOn, fake => fake.Date.Soon())
			.RuleFor(e => e.Createdonbehalfbyname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Createdonbehalfbyyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.Description, fake => fake.Lorem.Word())
			.RuleFor(e => e.GroupType, fake => fake.PickRandom<ResourceGroup.eGroupType>())
			.RuleFor(e => e.ImportSequenceNumber, fake => fake.Random.Int())
			.RuleFor(e => e.Modifiedbyname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Modifiedbyyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.ModifiedOn, fake => fake.Date.Soon())
			.RuleFor(e => e.Modifiedonbehalfbyname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Modifiedonbehalfbyyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.Name, fake => fake.Lorem.Word())
			.RuleFor(e => e.Organizationidname, fake => fake.Lorem.Word())
			.RuleFor(e => e.RecordCreatedOn, fake => fake.Date.Soon())
			.RuleFor(e => e.TimeZoneRuleVersionNumber, fake => fake.Random.Int())
			.RuleFor(e => e.UTCConversionTimeZoneCode, fake => fake.Random.Int())
			.RuleFor(e => e.VersionNumber, fake => fake.Random.Int());
			return faker.Generate();
		}
		#endregion
	}
}

