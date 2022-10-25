using Bogus;
using System;
using FakeXrmEasy;
using System.Collections.Generic;
using PentaWork.Xrm.Scheduler.Proxies.Entities;

namespace PentaWork.Xrm.Scheduler.Tests.Fake
{
	public static class FakePrivilege
	{	
		#region FakeRelationships
		public static class Relationships 
		{
			/// <summary>1:N Privilege_AsyncOperations</summary>
			public static readonly XrmFakedRelationship PrivilegeAsyncOperations = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "privilegeid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "privilege",
					Entity2LogicalName = "asyncoperation",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N Privilege_BulkDeleteFailures</summary>
			public static readonly XrmFakedRelationship PrivilegeBulkDeleteFailures = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "privilegeid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "privilege",
					Entity2LogicalName = "bulkdeletefailure",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
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

			/// <summary>N:N roletemplateprivileges_association</summary>
			public static readonly XrmFakedRelationship RoletemplateprivilegesAssociation = 
				new XrmFakedRelationship
				{
					IntersectEntity = "roletemplateprivileges_association",
					Entity1Attribute = "roletemplateid",
					Entity2Attribute = "privilegeid",
					Entity1LogicalName = "roletemplate",
					Entity2LogicalName = "privilege",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.ManyToMany
				};

		}
		#endregion

		#region Fake
		public static Privilege Create()
		{
			var faker = new Faker<Privilege>()
			.RuleFor(e => e.Accessright, fake => fake.Random.Int())
			.RuleFor(e => e.Canbebasic, fake => fake.Random.Bool())
			.RuleFor(e => e.Canbedeep, fake => fake.Random.Bool())
			.RuleFor(e => e.Canbeentityreference, fake => fake.Random.Bool())
			.RuleFor(e => e.Canbeglobal, fake => fake.Random.Bool())
			.RuleFor(e => e.Canbelocal, fake => fake.Random.Bool())
			.RuleFor(e => e.Canbeparententityreference, fake => fake.Random.Bool())
			.RuleFor(e => e.ComponentState, fake => fake.PickRandom<Privilege.egComponentState>())
			.RuleFor(e => e.IntroducedVersion, fake => fake.Lorem.Word())
			.RuleFor(e => e.Isdisabledwhenintegrated, fake => fake.Random.Bool())
			.RuleFor(e => e.State, fake => fake.Random.Bool())
			.RuleFor(e => e.Name, fake => fake.Lorem.Word())
			.RuleFor(e => e.RecordOverwriteTime, fake => fake.Date.Soon())
			.RuleFor(e => e.Id, fake => Guid.NewGuid())
			.RuleFor(e => e.AppModuleUniqueId, fake => Guid.NewGuid())
			.RuleFor(e => e.SolutionId, fake => Guid.NewGuid())
			.RuleFor(e => e.SolutionId2, fake => Guid.NewGuid())
			.RuleFor(e => e.Versionnumber, fake => fake.Random.Int());
			return faker.Generate();
		}
		#endregion
	}
}

