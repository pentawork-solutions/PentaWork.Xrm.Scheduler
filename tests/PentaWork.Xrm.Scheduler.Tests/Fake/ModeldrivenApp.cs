using Bogus;
using System;
using FakeXrmEasy;
using System.Collections.Generic;
using PentaWork.Xrm.Scheduler.Proxies.Entities;

namespace PentaWork.Xrm.Scheduler.Tests.Fake
{
	public static class FakeModeldrivenApp
	{	
		#region FakeRelationships
		public static class Relationships 
		{
			/// <summary>1:N appmodule_appconfig</summary>
			public static readonly XrmFakedRelationship AppmoduleAppconfig = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "appmoduleid",
					Entity2Attribute = "appmoduleid",
					Entity1LogicalName = "appmodule",
					Entity2LogicalName = "appconfig",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N appmodule_appmodulecomponent</summary>
			public static readonly XrmFakedRelationship AppmoduleAppmodulecomponent = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "appmoduleid",
					Entity2Attribute = "appmoduleidunique",
					Entity1LogicalName = "appmodule",
					Entity2LogicalName = "appmodulecomponent",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>N:N appmoduleroles_association</summary>
			public static readonly XrmFakedRelationship AppmodulerolesAssociation = 
				new XrmFakedRelationship
				{
					IntersectEntity = "appmoduleroles_association",
					Entity1Attribute = "appmoduleid",
					Entity2Attribute = "roleid",
					Entity1LogicalName = "appmodule",
					Entity2LogicalName = "role",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.ManyToMany
				};

			/// <summary>N:N serviceplan_appmodule</summary>
			public static readonly XrmFakedRelationship ServiceplanAppmodule = 
				new XrmFakedRelationship
				{
					IntersectEntity = "serviceplan_appmodule",
					Entity1Attribute = "serviceplanid",
					Entity2Attribute = "appmoduleid",
					Entity1LogicalName = "serviceplan",
					Entity2LogicalName = "appmodule",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.ManyToMany
				};

		}
		#endregion

		#region Fake
		public static ModeldrivenApp Create()
		{
			var faker = new Faker<ModeldrivenApp>()
			.RuleFor(e => e.Id, fake => Guid.NewGuid())
			.RuleFor(e => e.AppModuleUniqueId, fake => Guid.NewGuid())
			.RuleFor(e => e.AppModuleVersion, fake => fake.Lorem.Word())
			.RuleFor(e => e.Appmodulexmlmanaged, fake => fake.Lorem.Word())
			.RuleFor(e => e.ClientType, fake => fake.Random.Int())
			.RuleFor(e => e.ComponentState, fake => fake.PickRandom<ModeldrivenApp.egComponentState>())
			.RuleFor(e => e.Configxml, fake => fake.Lorem.Word())
			.RuleFor(e => e.Createdbyname, fake => fake.Lorem.Word())
			.RuleFor(e => e.CreatedOn, fake => fake.Date.Soon())
			.RuleFor(e => e.Createdonbehalfbyname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Createdonbehalfbyyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.Description, fake => fake.Lorem.Word())
			.RuleFor(e => e.Descriptor, fake => fake.Lorem.Word())
			.RuleFor(e => e.EventHandlers, fake => fake.Lorem.Word())
			.RuleFor(e => e.FormFactor, fake => fake.Random.Int())
			.RuleFor(e => e.ImportSequenceNumber, fake => fake.Random.Int())
			.RuleFor(e => e.IntroducedVersion, fake => fake.Lorem.Word())
			.RuleFor(e => e.IsDefault, fake => fake.Random.Bool())
			.RuleFor(e => e.IsFeatured, fake => fake.Random.Bool())
			.RuleFor(e => e.IsManaged, fake => fake.Random.Bool())
			.RuleFor(e => e.Modifiedbyname, fake => fake.Lorem.Word())
			.RuleFor(e => e.ModifiedOn, fake => fake.Date.Soon())
			.RuleFor(e => e.Modifiedonbehalfbyname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Modifiedonbehalfbyyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.Name, fake => fake.Lorem.Word())
			.RuleFor(e => e.NavigationType, fake => fake.PickRandom<ModeldrivenApp.eNavigationType>())
			.RuleFor(e => e.OptimizedClient, fake => fake.Lorem.Word())
			.RuleFor(e => e.Organizationidname, fake => fake.Lorem.Word())
			.RuleFor(e => e.RecordCreatedOn, fake => fake.Date.Soon())
			.RuleFor(e => e.OverwriteTime, fake => fake.Date.Soon())
			.RuleFor(e => e.PublishedOn, fake => fake.Date.Soon())
			.RuleFor(e => e.Publisher2, fake => fake.Lorem.Word())
			.RuleFor(e => e.SolutionId, fake => Guid.NewGuid())
			.RuleFor(e => e.Status, fake => fake.PickRandom<ModeldrivenApp.eStatus>())
			.RuleFor(e => e.StatusReason, fake => fake.PickRandom<ModeldrivenApp.eStatusReason>())
			.RuleFor(e => e.SolutionId2, fake => Guid.NewGuid())
			.RuleFor(e => e.UniqueName, fake => fake.Lorem.Word())
			.RuleFor(e => e.URL, fake => fake.Lorem.Word())
			.RuleFor(e => e.Versionnumber, fake => fake.Random.Int())
			.RuleFor(e => e.WebResourceId, fake => Guid.NewGuid())
			.RuleFor(e => e.WelcomePageId, fake => Guid.NewGuid());
			return faker.Generate();
		}
		#endregion
	}
}

