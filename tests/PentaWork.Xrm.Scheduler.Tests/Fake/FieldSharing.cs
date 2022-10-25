using Bogus;
using System;
using FakeXrmEasy;
using System.Collections.Generic;
using PentaWork.Xrm.Scheduler.Proxies.Entities;

namespace PentaWork.Xrm.Scheduler.Tests.Fake
{
	public static class FakeFieldSharing
	{	
		#region FakeRelationships
		public static class Relationships 
		{
		}
		#endregion

		#region Fake
		public static FieldSharing Create()
		{
			var faker = new Faker<FieldSharing>()
			.RuleFor(e => e.SecuredFieldId, fake => Guid.NewGuid())
			.RuleFor(e => e.EntityObjectType, fake => fake.Lorem.Word())
			.RuleFor(e => e.Organizationidname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Principalidname, fake => fake.Lorem.Word())
			.RuleFor(e => e.PrincipalType, fake => fake.Lorem.Word())
			.RuleFor(e => e.Id, fake => Guid.NewGuid())
			.RuleFor(e => e.ReadPermission, fake => fake.Random.Bool())
			.RuleFor(e => e.UpdatePermission, fake => fake.Random.Bool())
			.RuleFor(e => e.Versionnumber, fake => fake.Random.Int());
			return faker.Generate();
		}
		#endregion
	}
}

