using Bogus;
using System;
using FakeXrmEasy;
using System.Collections.Generic;
using PentaWork.Xrm.Scheduler.Proxies.Entities;

namespace PentaWork.Xrm.Scheduler.Tests.Fake
{
	public static class FakeTransformationMapping
	{	
		#region FakeRelationships
		public static class Relationships 
		{
			/// <summary>1:N TransformationParameterMapping_TransformationMapping</summary>
			public static readonly XrmFakedRelationship TransformationParameterMappingTransformationMapping = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "transformationmappingid",
					Entity2Attribute = "transformationmappingid",
					Entity1LogicalName = "transformationmapping",
					Entity2LogicalName = "transformationparametermapping",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

		}
		#endregion

		#region Fake
		public static TransformationMapping Create()
		{
			var faker = new Faker<TransformationMapping>()
			.RuleFor(e => e.ComponentState, fake => fake.PickRandom<TransformationMapping.egComponentState>())
			.RuleFor(e => e.Createdbyname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Createdbyyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.CreatedOn, fake => fake.Date.Soon())
			.RuleFor(e => e.Createdonbehalfbyname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Createdonbehalfbyyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.Importmapidname, fake => fake.Lorem.Word())
			.RuleFor(e => e.IntroducedVersion, fake => fake.Lorem.Word())
			.RuleFor(e => e.State, fake => fake.Random.Bool())
			.RuleFor(e => e.Modifiedbyname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Modifiedbyyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.ModifiedOn, fake => fake.Date.Soon())
			.RuleFor(e => e.Modifiedonbehalfbyname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Modifiedonbehalfbyyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.RecordOverwriteTime, fake => fake.Date.Soon())
			.RuleFor(e => e.ProcessCode, fake => fake.PickRandom<TransformationMapping.eProcessCode>())
			.RuleFor(e => e.SolutionId, fake => Guid.NewGuid())
			.RuleFor(e => e.SourceEntityName, fake => fake.Lorem.Word())
			.RuleFor(e => e.Status, fake => fake.PickRandom<TransformationMapping.eStatus>())
			.RuleFor(e => e.StatusReason, fake => fake.PickRandom<TransformationMapping.eStatusReason>())
			.RuleFor(e => e.SolutionId2, fake => Guid.NewGuid())
			.RuleFor(e => e.TargetEntityName, fake => fake.Lorem.Word())
			.RuleFor(e => e.Id, fake => Guid.NewGuid())
			.RuleFor(e => e.TransformationmappingiduniqueId, fake => Guid.NewGuid())
			.RuleFor(e => e.TransformationTypeName, fake => fake.Lorem.Word());
			return faker.Generate();
		}
		#endregion
	}
}

