using Bogus;
using System;
using FakeXrmEasy;
using System.Collections.Generic;
using PentaWork.Xrm.Scheduler.Proxies.Entities;

namespace PentaWork.Xrm.Scheduler.Tests.Fake
{
	public static class FakeDuplicateRuleCondition
	{	
		#region FakeRelationships
		public static class Relationships 
		{
			/// <summary>1:N DuplicateRuleCondition_SyncErrors</summary>
			public static readonly XrmFakedRelationship DuplicateRuleConditionSyncErrors = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "duplicateruleconditionid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "duplicaterulecondition",
					Entity2LogicalName = "syncerror",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

		}
		#endregion

		#region Fake
		public static DuplicateRuleCondition Create()
		{
			var faker = new Faker<DuplicateRuleCondition>()
			.RuleFor(e => e.BaseField, fake => fake.Lorem.Word())
			.RuleFor(e => e.Createdbyname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Createdbyyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.CreatedOn, fake => fake.Date.Soon())
			.RuleFor(e => e.Createdonbehalfbyname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Createdonbehalfbyyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.Id, fake => Guid.NewGuid())
			.RuleFor(e => e.IgnoreBlankValues, fake => fake.Random.Bool())
			.RuleFor(e => e.MatchingField, fake => fake.Lorem.Word())
			.RuleFor(e => e.Modifiedbyname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Modifiedbyyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.ModifiedOn, fake => fake.Date.Soon())
			.RuleFor(e => e.Modifiedonbehalfbyname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Modifiedonbehalfbyyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.OperatorCode, fake => fake.PickRandom<DuplicateRuleCondition.eOperatorCode>())
			.RuleFor(e => e.OperatorParameter, fake => fake.Random.Int())
			.RuleFor(e => e.Owneridtype, fake => fake.Lorem.Word())
			.RuleFor(e => e.OwningBusinessUnitId, fake => Guid.NewGuid())
			.RuleFor(e => e.OwningUserId, fake => Guid.NewGuid());
			return faker.Generate();
		}
		#endregion
	}
}

