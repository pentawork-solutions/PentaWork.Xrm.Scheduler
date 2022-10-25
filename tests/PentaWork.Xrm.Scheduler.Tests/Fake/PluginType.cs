using Bogus;
using System;
using FakeXrmEasy;
using System.Collections.Generic;
using PentaWork.Xrm.Scheduler.Proxies.Entities;

namespace PentaWork.Xrm.Scheduler.Tests.Fake
{
	public static class FakePluginType
	{	
		#region FakeRelationships
		public static class Relationships 
		{
			/// <summary>1:N plugin_type_service</summary>
			public static readonly XrmFakedRelationship PluginTypeService = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "plugintypeid",
					Entity2Attribute = "strategyid",
					Entity1LogicalName = "plugintype",
					Entity2LogicalName = "service",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N plugintype_customapi</summary>
			public static readonly XrmFakedRelationship PlugintypeCustomapi = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "plugintypeid",
					Entity2Attribute = "plugintypeid",
					Entity1LogicalName = "plugintype",
					Entity2LogicalName = "customapi",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N plugintype_plugintypestatistic</summary>
			public static readonly XrmFakedRelationship PlugintypePlugintypestatistic = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "plugintypeid",
					Entity2Attribute = "plugintypeid",
					Entity1LogicalName = "plugintype",
					Entity2LogicalName = "plugintypestatistic",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N plugintype_sdkmessageprocessingstep</summary>
			public static readonly XrmFakedRelationship PlugintypeSdkmessageprocessingstep = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "plugintypeid",
					Entity2Attribute = "eventhandler",
					Entity1LogicalName = "plugintype",
					Entity2LogicalName = "sdkmessageprocessingstep",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N plugintypeid_sdkmessageprocessingstep</summary>
			public static readonly XrmFakedRelationship PlugintypeidSdkmessageprocessingstep = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "plugintypeid",
					Entity2Attribute = "plugintypeid",
					Entity1LogicalName = "plugintype",
					Entity2LogicalName = "sdkmessageprocessingstep",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

		}
		#endregion

		#region Fake
		public static PluginType Create()
		{
			var faker = new Faker<PluginType>()
			.RuleFor(e => e.AssemblyName, fake => fake.Lorem.Word())
			.RuleFor(e => e.ComponentState, fake => fake.PickRandom<PluginType.egComponentState>())
			.RuleFor(e => e.Createdbyname, fake => fake.Lorem.Word())
			.RuleFor(e => e.CreatedOn, fake => fake.Date.Soon())
			.RuleFor(e => e.Createdonbehalfbyname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Createdonbehalfbyyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.Culture, fake => fake.Lorem.Word())
			.RuleFor(e => e.Customizationlevel, fake => fake.Random.Int())
			.RuleFor(e => e.CustomWorkflowActivityInfo, fake => fake.Lorem.Word())
			.RuleFor(e => e.Description, fake => fake.Lorem.Word())
			.RuleFor(e => e.DisplayName, fake => fake.Lorem.Word())
			.RuleFor(e => e.Ismanaged, fake => fake.Random.Bool())
			.RuleFor(e => e.IsWorkflowActivity, fake => fake.Random.Bool())
			.RuleFor(e => e.VersionMajor, fake => fake.Random.Int())
			.RuleFor(e => e.VersionMinor, fake => fake.Random.Int())
			.RuleFor(e => e.Modifiedbyname, fake => fake.Lorem.Word())
			.RuleFor(e => e.ModifiedOn, fake => fake.Date.Soon())
			.RuleFor(e => e.Modifiedonbehalfbyname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Modifiedonbehalfbyyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.Name, fake => fake.Lorem.Word())
			.RuleFor(e => e.RecordOverwriteTime, fake => fake.Date.Soon())
			.RuleFor(e => e.Pluginassemblyidname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Id, fake => Guid.NewGuid())
			.RuleFor(e => e.PlugintypeiduniqueId, fake => Guid.NewGuid())
			.RuleFor(e => e.PublicKeyToken, fake => fake.Lorem.Word())
			.RuleFor(e => e.SolutionId, fake => Guid.NewGuid())
			.RuleFor(e => e.SolutionId2, fake => Guid.NewGuid())
			.RuleFor(e => e.TypeName, fake => fake.Lorem.Word())
			.RuleFor(e => e.Version, fake => fake.Lorem.Word())
			.RuleFor(e => e.Versionnumber, fake => fake.Random.Int())
			.RuleFor(e => e.WorkflowActivityGroupName, fake => fake.Lorem.Word());
			return faker.Generate();
		}
		#endregion
	}
}

