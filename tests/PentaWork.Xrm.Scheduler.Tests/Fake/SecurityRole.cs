using Bogus;
using System;
using FakeXrmEasy;
using System.Collections.Generic;
using PentaWork.Xrm.Scheduler.Proxies.Entities;

namespace PentaWork.Xrm.Scheduler.Tests.Fake
{
	public static class FakeSecurityRole
	{	
		#region FakeRelationships
		public static class Relationships 
		{
			/// <summary>1:N lk_msdyn_roleid</summary>
			public static readonly XrmFakedRelationship LkMsdynRoleid = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "roleid",
					Entity2Attribute = "msdyn_roleid",
					Entity1LogicalName = "role",
					Entity2LogicalName = "msdyn_actioncardrolesetting",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N Role_AsyncOperations</summary>
			public static readonly XrmFakedRelationship RoleAsyncOperations = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "roleid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "role",
					Entity2LogicalName = "asyncoperation",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N Role_BulkDeleteFailures</summary>
			public static readonly XrmFakedRelationship RoleBulkDeleteFailures = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "roleid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "role",
					Entity2LogicalName = "bulkdeletefailure",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N role_parent_role</summary>
			public static readonly XrmFakedRelationship RoleParentRole = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "roleid",
					Entity2Attribute = "parentroleid",
					Entity1LogicalName = "role",
					Entity2LogicalName = "role",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N role_parent_root_role</summary>
			public static readonly XrmFakedRelationship RoleParentRootRole = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "roleid",
					Entity2Attribute = "parentrootroleid",
					Entity1LogicalName = "role",
					Entity2LogicalName = "role",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N Role_SyncErrors</summary>
			public static readonly XrmFakedRelationship RoleSyncErrors = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "roleid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "role",
					Entity2LogicalName = "syncerror",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>N:N appmoduleroles_association</summary>
			public static readonly XrmFakedRelationship AppmodulerolesAssociation = 
				new XrmFakedRelationship
				{
					IntersectEntity = "appmoduleroles_association",
					Entity1Attribute = "appmoduleid",
					Entity2Attribute = "roleid",
					Entity1LogicalName = "appmodule",
					Entity2LogicalName = "role",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.ManyToMany
				};

			/// <summary>N:N roleprivileges_association</summary>
			public static readonly XrmFakedRelationship RoleprivilegesAssociation = 
				new XrmFakedRelationship
				{
					IntersectEntity = "roleprivileges_association",
					Entity1Attribute = "privilegeid",
					Entity2Attribute = "roleid",
					Entity1LogicalName = "privilege",
					Entity2LogicalName = "role",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.ManyToMany
				};

			/// <summary>N:N systemuserroles_association</summary>
			public static readonly XrmFakedRelationship SystemuserrolesAssociation = 
				new XrmFakedRelationship
				{
					IntersectEntity = "systemuserroles_association",
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "roleid",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "role",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.ManyToMany
				};

			/// <summary>N:N teamroles_association</summary>
			public static readonly XrmFakedRelationship TeamrolesAssociation = 
				new XrmFakedRelationship
				{
					IntersectEntity = "teamroles_association",
					Entity1Attribute = "teamid",
					Entity2Attribute = "roleid",
					Entity1LogicalName = "team",
					Entity2LogicalName = "role",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.ManyToMany
				};

		}
		#endregion

		#region Fake
		public static SecurityRole Create()
		{
			var faker = new Faker<SecurityRole>()
			.RuleFor(e => e.Businessunitidname, fake => fake.Lorem.Word())
			.RuleFor(e => e.ComponentState, fake => fake.PickRandom<SecurityRole.egComponentState>())
			.RuleFor(e => e.Createdbyname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Createdbyyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.CreatedOn, fake => fake.Date.Soon())
			.RuleFor(e => e.Createdonbehalfbyname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Createdonbehalfbyyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.ImportSequenceNumber, fake => fake.Random.Int())
			.RuleFor(e => e.IsInherited, fake => fake.PickRandom<SecurityRole.egIsInherited>())
			.RuleFor(e => e.State, fake => fake.Random.Bool())
			.RuleFor(e => e.Modifiedbyname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Modifiedbyyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.ModifiedOn, fake => fake.Date.Soon())
			.RuleFor(e => e.Modifiedonbehalfbyname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Modifiedonbehalfbyyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.Name, fake => fake.Lorem.Word())
			.RuleFor(e => e.OrganizationId, fake => Guid.NewGuid())
			.RuleFor(e => e.Organizationidname, fake => fake.Lorem.Word())
			.RuleFor(e => e.RecordCreatedOn, fake => fake.Date.Soon())
			.RuleFor(e => e.RecordOverwriteTime, fake => fake.Date.Soon())
			.RuleFor(e => e.Parentroleidname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Parentrootroleidname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Id, fake => Guid.NewGuid())
			.RuleFor(e => e.UniqueId, fake => Guid.NewGuid())
			.RuleFor(e => e.SolutionId, fake => Guid.NewGuid())
			.RuleFor(e => e.SolutionId2, fake => Guid.NewGuid())
			.RuleFor(e => e.VersionNumber, fake => fake.Random.Int());
			return faker.Generate();
		}
		#endregion
	}
}

