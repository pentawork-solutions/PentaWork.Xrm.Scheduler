using Bogus;
using System;
using FakeXrmEasy;
using System.Collections.Generic;
using PentaWork.Xrm.Scheduler.Proxies.Entities;

namespace PentaWork.Xrm.Scheduler.Tests.Fake
{
	public static class FakeTeamTemplate
	{	
		#region FakeRelationships
		public static class Relationships 
		{
			/// <summary>1:N TeamTemplate_SyncErrors</summary>
			public static readonly XrmFakedRelationship TeamTemplateSyncErrors = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "teamtemplateid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "teamtemplate",
					Entity2LogicalName = "syncerror",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N teamtemplate_Teams</summary>
			public static readonly XrmFakedRelationship TeamtemplateTeams = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "teamtemplateid",
					Entity2Attribute = "teamtemplateid",
					Entity1LogicalName = "teamtemplate",
					Entity2LogicalName = "team",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

		}
		#endregion

		#region Fake
		public static TeamTemplate Create()
		{
			var faker = new Faker<TeamTemplate>()
			.RuleFor(e => e.Createdbyname, fake => fake.Lorem.Word())
			.RuleFor(e => e.CreatedOn, fake => fake.Date.Soon())
			.RuleFor(e => e.Createdonbehalfbyname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Createdonbehalfbyyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.AccessRights, fake => fake.Random.Int())
			.RuleFor(e => e.Description, fake => fake.Lorem.Word())
			.RuleFor(e => e.IsSystem, fake => fake.Random.Bool())
			.RuleFor(e => e.Modifiedbyname, fake => fake.Lorem.Word())
			.RuleFor(e => e.ModifiedOn, fake => fake.Date.Soon())
			.RuleFor(e => e.Modifiedonbehalfbyname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Modifiedonbehalfbyyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.Entity, fake => fake.Random.Int())
			.RuleFor(e => e.Id, fake => Guid.NewGuid())
			.RuleFor(e => e.Name, fake => fake.Lorem.Word())
			.RuleFor(e => e.VersionNumber, fake => fake.Random.Int());
			return faker.Generate();
		}
		#endregion
	}
}

