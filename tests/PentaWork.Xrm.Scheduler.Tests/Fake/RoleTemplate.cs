using Bogus;
using System;
using FakeXrmEasy;
using System.Collections.Generic;
using PentaWork.Xrm.Scheduler.Proxies.Entities;

namespace PentaWork.Xrm.Scheduler.Tests.Fake
{
	public static class FakeRoleTemplate
	{	
		#region FakeRelationships
		public static class Relationships 
		{
			/// <summary>1:N role_template_roles</summary>
			public static readonly XrmFakedRelationship RoleTemplateRoles = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "roletemplateid",
					Entity2Attribute = "roletemplateid",
					Entity1LogicalName = "roletemplate",
					Entity2LogicalName = "role",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
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
		public static RoleTemplate Create()
		{
			var faker = new Faker<RoleTemplate>()
			.RuleFor(e => e.Name, fake => fake.Lorem.Word())
			.RuleFor(e => e.Id, fake => Guid.NewGuid())
			.RuleFor(e => e.Upgrading, fake => fake.Random.Bool());
			return faker.Generate();
		}
		#endregion
	}
}

