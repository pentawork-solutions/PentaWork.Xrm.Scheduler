using Bogus;
using System;
using FakeXrmEasy;
using System.Collections.Generic;
using PentaWork.Xrm.Scheduler.Proxies.Entities;

namespace PentaWork.Xrm.Scheduler.Tests.Fake
{
	public static class FakeColumnMapping
	{	
		#region FakeRelationships
		public static class Relationships 
		{
			/// <summary>1:N LookUpMapping_ColumnMapping</summary>
			public static readonly XrmFakedRelationship LookUpMappingColumnMapping = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "columnmappingid",
					Entity2Attribute = "columnmappingid",
					Entity1LogicalName = "columnmapping",
					Entity2LogicalName = "lookupmapping",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N PickListMapping_ColumnMapping</summary>
			public static readonly XrmFakedRelationship PickListMappingColumnMapping = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "columnmappingid",
					Entity2Attribute = "columnmappingid",
					Entity1LogicalName = "columnmapping",
					Entity2LogicalName = "picklistmapping",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

		}
		#endregion

		#region Fake
		public static ColumnMapping Create()
		{
			var faker = new Faker<ColumnMapping>()
			.RuleFor(e => e.Id, fake => Guid.NewGuid())
			.RuleFor(e => e.ColumnmappingiduniqueId, fake => Guid.NewGuid())
			.RuleFor(e => e.ComponentState, fake => fake.PickRandom<ColumnMapping.egComponentState>())
			.RuleFor(e => e.Createdbyname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Createdbyyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.Createdon, fake => fake.Date.Soon())
			.RuleFor(e => e.Createdonbehalfbyname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Createdonbehalfbyyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.DataMap, fake => fake.Lorem.Word())
			.RuleFor(e => e.IntroducedVersion, fake => fake.Lorem.Word())
			.RuleFor(e => e.State, fake => fake.Random.Bool())
			.RuleFor(e => e.Modifiedbyname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Modifiedbyyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.ModifiedOn, fake => fake.Date.Soon())
			.RuleFor(e => e.Modifiedonbehalfbyname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Modifiedonbehalfbyyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.RecordOverwriteTime, fake => fake.Date.Soon())
			.RuleFor(e => e.ProcessCode, fake => fake.PickRandom<ColumnMapping.eProcessCode>())
			.RuleFor(e => e.SolutionId, fake => Guid.NewGuid())
			.RuleFor(e => e.SourceAttribute, fake => fake.Lorem.Word())
			.RuleFor(e => e.SourceEntityName, fake => fake.Lorem.Word())
			.RuleFor(e => e.Status, fake => fake.PickRandom<ColumnMapping.eStatus>())
			.RuleFor(e => e.StatusReason, fake => fake.PickRandom<ColumnMapping.eStatusReason>())
			.RuleFor(e => e.SolutionId2, fake => Guid.NewGuid())
			.RuleFor(e => e.TargetAttribute, fake => fake.Lorem.Word())
			.RuleFor(e => e.TargetEntity, fake => fake.Lorem.Word());
			return faker.Generate();
		}
		#endregion
	}
}

