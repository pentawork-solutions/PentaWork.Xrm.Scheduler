using Bogus;
using System;
using FakeXrmEasy;
using System.Collections.Generic;
using PentaWork.Xrm.Scheduler.Proxies.Entities;

namespace PentaWork.Xrm.Scheduler.Tests.Fake
{
	public static class FakeTransformationParameterMapping
	{	
		#region FakeRelationships
		public static class Relationships 
		{
			/// <summary>1:N LookUpMapping_TransformationParameterMapping</summary>
			public static readonly XrmFakedRelationship LookUpMappingTransformationParameterMapping = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "transformationparametermappingid",
					Entity2Attribute = "transformationparametermappingid",
					Entity1LogicalName = "transformationparametermapping",
					Entity2LogicalName = "lookupmapping",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

		}
		#endregion

		#region Fake
		public static TransformationParameterMapping Create()
		{
			var faker = new Faker<TransformationParameterMapping>()
			.RuleFor(e => e.ComponentState, fake => fake.PickRandom<TransformationParameterMapping.egComponentState>())
			.RuleFor(e => e.Createdbyname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Createdbyyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.CreatedOn, fake => fake.Date.Soon())
			.RuleFor(e => e.Createdonbehalfbyname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Createdonbehalfbyyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.Data, fake => fake.Lorem.Word())
			.RuleFor(e => e.ParameterDataType, fake => fake.PickRandom<TransformationParameterMapping.eParameterDataType>())
			.RuleFor(e => e.IntroducedVersion, fake => fake.Lorem.Word())
			.RuleFor(e => e.State, fake => fake.Random.Bool())
			.RuleFor(e => e.Modifiedbyname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Modifiedbyyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.ModifiedOn, fake => fake.Date.Soon())
			.RuleFor(e => e.Modifiedonbehalfbyname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Modifiedonbehalfbyyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.RecordOverwriteTime, fake => fake.Date.Soon())
			.RuleFor(e => e.ParameterArrayIndex, fake => fake.Random.Int())
			.RuleFor(e => e.ParameterSequence, fake => fake.Random.Int())
			.RuleFor(e => e.ParameterType, fake => fake.PickRandom<TransformationParameterMapping.eParameterType>())
			.RuleFor(e => e.SolutionId, fake => Guid.NewGuid())
			.RuleFor(e => e.SolutionId2, fake => Guid.NewGuid())
			.RuleFor(e => e.Transformationmappingidname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Id, fake => Guid.NewGuid())
			.RuleFor(e => e.TransformationparametermappingiduniqueId, fake => Guid.NewGuid());
			return faker.Generate();
		}
		#endregion
	}
}

