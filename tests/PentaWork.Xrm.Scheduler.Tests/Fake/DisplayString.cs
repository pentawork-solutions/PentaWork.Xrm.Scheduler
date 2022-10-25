using Bogus;
using System;
using FakeXrmEasy;
using System.Collections.Generic;
using PentaWork.Xrm.Scheduler.Proxies.Entities;

namespace PentaWork.Xrm.Scheduler.Tests.Fake
{
	public static class FakeDisplayString
	{	
		#region FakeRelationships
		public static class Relationships 
		{
			/// <summary>1:N DisplayString_AsyncOperations</summary>
			public static readonly XrmFakedRelationship DisplayStringAsyncOperations = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "displaystringid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "displaystring",
					Entity2LogicalName = "asyncoperation",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N DisplayString_BulkDeleteFailures</summary>
			public static readonly XrmFakedRelationship DisplayStringBulkDeleteFailures = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "displaystringid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "displaystring",
					Entity2LogicalName = "bulkdeletefailure",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

		}
		#endregion

		#region Fake
		public static DisplayString Create()
		{
			var faker = new Faker<DisplayString>()
			.RuleFor(e => e.ComponentState, fake => fake.PickRandom<DisplayString.egComponentState>())
			.RuleFor(e => e.Createdbyname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Createdbyyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.CreatedOn, fake => fake.Date.Soon())
			.RuleFor(e => e.Createdonbehalfbyname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Createdonbehalfbyyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.Comment, fake => fake.Lorem.Word())
			.RuleFor(e => e.CustomDisplayString, fake => fake.Lorem.Word())
			.RuleFor(e => e.Id, fake => Guid.NewGuid())
			.RuleFor(e => e.DisplaystringiduniqueId, fake => Guid.NewGuid())
			.RuleFor(e => e.ResourceKey, fake => fake.Lorem.Word())
			.RuleFor(e => e.FormatParameters, fake => fake.Random.Int())
			.RuleFor(e => e.Ismanaged, fake => fake.Random.Bool())
			.RuleFor(e => e.LanguageCode, fake => fake.Random.Int())
			.RuleFor(e => e.Modifiedbyname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Modifiedbyyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.ModifiedOn, fake => fake.Date.Soon())
			.RuleFor(e => e.Modifiedonbehalfbyname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Modifiedonbehalfbyyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.Organizationidname, fake => fake.Lorem.Word())
			.RuleFor(e => e.RecordOverwriteTime, fake => fake.Date.Soon())
			.RuleFor(e => e.PublishedDisplayString, fake => fake.Lorem.Word())
			.RuleFor(e => e.SolutionId, fake => Guid.NewGuid())
			.RuleFor(e => e.SolutionId2, fake => Guid.NewGuid())
			.RuleFor(e => e.Versionnumber, fake => fake.Random.Int());
			return faker.Generate();
		}
		#endregion
	}
}

