using Bogus;
using System;
using FakeXrmEasy;
using System.Collections.Generic;
using PentaWork.Xrm.Scheduler.Proxies.Entities;

namespace PentaWork.Xrm.Scheduler.Tests.Fake
{
	public static class FakeConnectionRole
	{	
		#region FakeRelationships
		public static class Relationships 
		{
			/// <summary>1:N Connection_Role_AsyncOperations</summary>
			public static readonly XrmFakedRelationship ConnectionRoleAsyncOperations = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "connectionroleid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "connectionrole",
					Entity2LogicalName = "asyncoperation",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N connection_role_connections1</summary>
			public static readonly XrmFakedRelationship ConnectionRoleConnections1 = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "connectionroleid",
					Entity2Attribute = "record1roleid",
					Entity1LogicalName = "connectionrole",
					Entity2LogicalName = "connection",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N connection_role_connections2</summary>
			public static readonly XrmFakedRelationship ConnectionRoleConnections2 = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "connectionroleid",
					Entity2Attribute = "record2roleid",
					Entity1LogicalName = "connectionrole",
					Entity2LogicalName = "connection",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N ConnectionRole_ProcessSessions</summary>
			public static readonly XrmFakedRelationship ConnectionRoleProcessSessions = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "connectionroleid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "connectionrole",
					Entity2LogicalName = "processsession",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N ConnectionRole_SyncErrors</summary>
			public static readonly XrmFakedRelationship ConnectionRoleSyncErrors = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "connectionroleid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "connectionrole",
					Entity2LogicalName = "syncerror",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>N:N connectionroleassociation_association</summary>
			public static readonly XrmFakedRelationship ConnectionroleassociationAssociation = 
				new XrmFakedRelationship
				{
					IntersectEntity = "connectionroleassociation_association",
					Entity1Attribute = "connectionroleid",
					Entity2Attribute = "associatedconnectionroleid",
					Entity1LogicalName = "connectionrole",
					Entity2LogicalName = "connectionrole",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.ManyToMany
				};

		}
		#endregion

		#region Fake
		public static ConnectionRole Create()
		{
			var faker = new Faker<ConnectionRole>()
			.RuleFor(e => e.ConnectionRoleCategory, fake => fake.PickRandom<ConnectionRole.egCategory>())
			.RuleFor(e => e.ComponentState, fake => fake.PickRandom<ConnectionRole.egComponentState>())
			.RuleFor(e => e.Id, fake => Guid.NewGuid())
			.RuleFor(e => e.UniqueId, fake => Guid.NewGuid())
			.RuleFor(e => e.Createdbyname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Createdbyyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.CreatedOn, fake => fake.Date.Soon())
			.RuleFor(e => e.Createdonbehalfbyname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Createdonbehalfbyyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.Description, fake => fake.Lorem.Word())
			.RuleFor(e => e.ImportSequenceNumber, fake => fake.Random.Int())
			.RuleFor(e => e.IntroducedVersion, fake => fake.Lorem.Word())
			.RuleFor(e => e.State, fake => fake.Random.Bool())
			.RuleFor(e => e.Modifiedbyname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Modifiedbyyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.ModifiedOn, fake => fake.Date.Soon())
			.RuleFor(e => e.Modifiedonbehalfbyname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Modifiedonbehalfbyyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.Name, fake => fake.Lorem.Word())
			.RuleFor(e => e.Organizationidname, fake => fake.Lorem.Word())
			.RuleFor(e => e.OverwrittenOn, fake => fake.Date.Soon())
			.RuleFor(e => e.SolutionId, fake => Guid.NewGuid())
			.RuleFor(e => e.Status, fake => fake.PickRandom<ConnectionRole.eStatus>())
			.RuleFor(e => e.StatusReason, fake => fake.PickRandom<ConnectionRole.eStatusReason>())
			.RuleFor(e => e.SolutionId2, fake => Guid.NewGuid())
			.RuleFor(e => e.VersionNumber, fake => fake.Random.Int());
			return faker.Generate();
		}
		#endregion
	}
}

