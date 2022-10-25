using Bogus;
using System;
using FakeXrmEasy;
using System.Collections.Generic;
using PentaWork.Xrm.Scheduler.Proxies.Entities;

namespace PentaWork.Xrm.Scheduler.Tests.Fake
{
	public static class FakeFieldPermission
	{	
		#region FakeRelationships
		public static class Relationships 
		{
			/// <summary>1:N FieldPermission_SyncErrors</summary>
			public static readonly XrmFakedRelationship FieldPermissionSyncErrors = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "fieldpermissionid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "fieldpermission",
					Entity2LogicalName = "syncerror",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

		}
		#endregion

		#region Fake
		public static FieldPermission Create()
		{
			var faker = new Faker<FieldPermission>()
			.RuleFor(e => e.NameOfTheAttributeForWhichThisPrivilegeIsDefined, fake => fake.Lorem.Word())
			.RuleFor(e => e.CanCreateTheAttribute, fake => fake.PickRandom<FieldPermission.egAYesOrNoBoolean>())
			.RuleFor(e => e.CanReadTheAttribute, fake => fake.PickRandom<FieldPermission.egAYesOrNoBoolean>())
			.RuleFor(e => e.CanUpdateTheAttribute, fake => fake.PickRandom<FieldPermission.egAYesOrNoBoolean>())
			.RuleFor(e => e.ComponentState, fake => fake.PickRandom<FieldPermission.egComponentState>())
			.RuleFor(e => e.NameOfTheEntityForWhichThisPrivilegeIsDefined, fake => fake.Lorem.Word())
			.RuleFor(e => e.Id, fake => Guid.NewGuid())
			.RuleFor(e => e.FieldPermissionId2, fake => Guid.NewGuid())
			.RuleFor(e => e.IsManaged, fake => fake.Random.Bool())
			.RuleFor(e => e.RecordOverwriteTime, fake => fake.Date.Soon())
			.RuleFor(e => e.SolutionId, fake => Guid.NewGuid())
			.RuleFor(e => e.SolutionId2, fake => Guid.NewGuid())
			.RuleFor(e => e.Versionnumber, fake => fake.Random.Int());
			return faker.Generate();
		}
		#endregion
	}
}

