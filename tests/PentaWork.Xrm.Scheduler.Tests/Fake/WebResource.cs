using Bogus;
using System;
using FakeXrmEasy;
using System.Collections.Generic;
using PentaWork.Xrm.Scheduler.Proxies.Entities;

namespace PentaWork.Xrm.Scheduler.Tests.Fake
{
	public static class FakeWebResource
	{	
		#region FakeRelationships
		public static class Relationships 
		{
			/// <summary>1:N lk_theme_logoid</summary>
			public static readonly XrmFakedRelationship LkThemeLogoid = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "webresourceid",
					Entity2Attribute = "logoid",
					Entity1LogicalName = "webresource",
					Entity2LogicalName = "theme",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N solution_configuration_webresource</summary>
			public static readonly XrmFakedRelationship SolutionConfigurationWebresource = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "webresourceid",
					Entity2Attribute = "configurationpageid",
					Entity1LogicalName = "webresource",
					Entity2LogicalName = "solution",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N webresource_savedqueryvisualizations</summary>
			public static readonly XrmFakedRelationship WebresourceSavedqueryvisualizations = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "webresourceid",
					Entity2Attribute = "webresourceid",
					Entity1LogicalName = "webresource",
					Entity2LogicalName = "savedqueryvisualization",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N webresource_userqueryvisualizations</summary>
			public static readonly XrmFakedRelationship WebresourceUserqueryvisualizations = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "webresourceid",
					Entity2Attribute = "webresourceid",
					Entity1LogicalName = "webresource",
					Entity2LogicalName = "userqueryvisualization",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

		}
		#endregion

		#region Fake
		public static WebResource Create()
		{
			var faker = new Faker<WebResource>()
			.RuleFor(e => e.ComponentState, fake => fake.PickRandom<WebResource.egComponentState>())
			.RuleFor(e => e.Content, fake => fake.Lorem.Word())
			.RuleFor(e => e.Contentjson, fake => fake.Lorem.Word())
			.RuleFor(e => e.CreatedOn, fake => fake.Date.Soon())
			.RuleFor(e => e.Createdonbehalfbyname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Createdonbehalfbyyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.DependencyXML, fake => fake.Lorem.Word())
			.RuleFor(e => e.Description, fake => fake.Lorem.Word())
			.RuleFor(e => e.DisplayName, fake => fake.Lorem.Word())
			.RuleFor(e => e.IntroducedVersion, fake => fake.Lorem.Word())
			.RuleFor(e => e.IsAvailableForMobileOffline, fake => fake.Random.Bool())
			.RuleFor(e => e.IsEnabledForMobileClient, fake => fake.Random.Bool())
			.RuleFor(e => e.Ismanaged, fake => fake.Random.Bool())
			.RuleFor(e => e.Language, fake => fake.Random.Int())
			.RuleFor(e => e.ModifiedOn, fake => fake.Date.Soon())
			.RuleFor(e => e.Modifiedonbehalfbyname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Modifiedonbehalfbyyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.Name, fake => fake.Lorem.Word())
			.RuleFor(e => e.Organizationidname, fake => fake.Lorem.Word())
			.RuleFor(e => e.RecordOverwriteTime, fake => fake.Date.Soon())
			.RuleFor(e => e.SilverlightVersion, fake => fake.Lorem.Word())
			.RuleFor(e => e.SolutionId, fake => Guid.NewGuid())
			.RuleFor(e => e.SolutionId2, fake => Guid.NewGuid())
			.RuleFor(e => e.Versionnumber, fake => fake.Random.Int())
			.RuleFor(e => e.Id, fake => Guid.NewGuid())
			.RuleFor(e => e.WebresourceiduniqueId, fake => Guid.NewGuid())
			.RuleFor(e => e.Type, fake => fake.PickRandom<WebResource.eType>());
			return faker.Generate();
		}
		#endregion
	}
}

