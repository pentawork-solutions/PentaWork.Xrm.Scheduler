using Bogus;
using System;
using FakeXrmEasy;
using System.Collections.Generic;
using PentaWork.Xrm.Scheduler.Proxies.Entities;

namespace PentaWork.Xrm.Scheduler.Tests.Fake
{
	public static class FakeCanvasApp
	{	
		#region FakeRelationships
		public static class Relationships 
		{
			/// <summary>1:N canvasapp_FileAttachments</summary>
			public static readonly XrmFakedRelationship CanvasappFileAttachments = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "canvasappid",
					Entity2Attribute = "objectid",
					Entity1LogicalName = "canvasapp",
					Entity2LogicalName = "fileattachment",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

		}
		#endregion

		#region Fake
		public static CanvasApp Create()
		{
			var faker = new Faker<CanvasApp>()
			.RuleFor(e => e.CreatedBy, fake => fake.Lorem.Word())
			.RuleFor(e => e.LastModifiedBy, fake => fake.Lorem.Word())
			.RuleFor(e => e.LastPublishedBy, fake => fake.Lorem.Word())
			.RuleFor(e => e.AdminControlBypassConsent, fake => fake.Random.Bool())
			.RuleFor(e => e.Appcomponentdependencies, fake => fake.Lorem.Word())
			.RuleFor(e => e.Appcomponents, fake => fake.Lorem.Word())
			.RuleFor(e => e.Appopenuri, fake => fake.Lorem.Word())
			.RuleFor(e => e.Appversion, fake => fake.Lorem.Word())
			.RuleFor(e => e.AssetsName, fake => fake.Lorem.Word())
			.RuleFor(e => e.Authorizationreferences, fake => fake.Lorem.Word())
			.RuleFor(e => e.Backgroundcolor, fake => fake.Lorem.Word())
			.RuleFor(e => e.BackgroundimageName, fake => fake.Lorem.Word())
			.RuleFor(e => e.BypassConsent, fake => fake.Random.Bool())
			.RuleFor(e => e.CanConsumeAppPass, fake => fake.Random.Bool())
			.RuleFor(e => e.Id, fake => Guid.NewGuid())
			.RuleFor(e => e.CanvasapprowId, fake => Guid.NewGuid())
			.RuleFor(e => e.CanvasAppType, fake => fake.PickRandom<CanvasApp.eCanvasAppType>())
			.RuleFor(e => e.Cdsdependencies, fake => fake.Lorem.Word())
			.RuleFor(e => e.TheCommitMessage, fake => fake.Lorem.Word())
			.RuleFor(e => e.ComponentState, fake => fake.PickRandom<CanvasApp.egComponentState>())
			.RuleFor(e => e.Connectionreferences, fake => fake.Lorem.Word())
			.RuleFor(e => e.Createdbyclientversion, fake => fake.Lorem.Word())
			.RuleFor(e => e.CreatedTime, fake => fake.Date.Soon())
			.RuleFor(e => e.Databasereferences, fake => fake.Lorem.Word())
			.RuleFor(e => e.TheDescription, fake => fake.Lorem.Word())
			.RuleFor(e => e.Displayname, fake => fake.Lorem.Word())
			.RuleFor(e => e.DocumentName, fake => fake.Lorem.Word())
			.RuleFor(e => e.Embeddedapp, fake => fake.Lorem.Word())
			.RuleFor(e => e.TheGalleryItemIdentifier, fake => fake.Lorem.Word())
			.RuleFor(e => e.IntroducedVersion, fake => fake.Lorem.Word())
			.RuleFor(e => e.IsCDSUpgraded, fake => fake.Random.Bool())
			.RuleFor(e => e.IsFeaturedApp, fake => fake.Random.Bool())
			.RuleFor(e => e.IsHeroApp, fake => fake.Random.Bool())
			.RuleFor(e => e.IsHidden, fake => fake.Random.Bool())
			.RuleFor(e => e.IsManaged, fake => fake.Random.Bool())
			.RuleFor(e => e.LargeiconName, fake => fake.Lorem.Word())
			.RuleFor(e => e.LastModifiedTime, fake => fake.Date.Soon())
			.RuleFor(e => e.LastPublishTime, fake => fake.Date.Soon())
			.RuleFor(e => e.MediumiconName, fake => fake.Lorem.Word())
			.RuleFor(e => e.Minclientversion, fake => fake.Lorem.Word())
			.RuleFor(e => e.CanvasAppName, fake => fake.Lorem.Word())
			.RuleFor(e => e.RecordOverwriteTime, fake => fake.Date.Soon())
			.RuleFor(e => e.Owneridname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Owneridtype, fake => fake.Lorem.Word())
			.RuleFor(e => e.Owningbusinessunitname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Publisher, fake => fake.Lorem.Word())
			.RuleFor(e => e.SmalliconName, fake => fake.Lorem.Word())
			.RuleFor(e => e.SolutionId, fake => Guid.NewGuid())
			.RuleFor(e => e.Status, fake => fake.Lorem.Word())
			.RuleFor(e => e.SolutionId2, fake => Guid.NewGuid())
			.RuleFor(e => e.Tags, fake => fake.Lorem.Word())
			.RuleFor(e => e.TeamsiconName, fake => fake.Lorem.Word())
			.RuleFor(e => e.Versionnumber, fake => fake.Random.Int())
			.RuleFor(e => e.WideiconName, fake => fake.Lorem.Word());
			return faker.Generate();
		}
		#endregion
	}
}

