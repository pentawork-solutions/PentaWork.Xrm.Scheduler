using Bogus;
using System;
using FakeXrmEasy;
using System.Collections.Generic;
using PentaWork.Xrm.Scheduler.Proxies.Entities;

namespace PentaWork.Xrm.Scheduler.Tests.Fake
{
	public static class FakeTheme
	{	
		#region FakeRelationships
		public static class Relationships 
		{
			/// <summary>1:N theme_AsyncOperations</summary>
			public static readonly XrmFakedRelationship ThemeAsyncOperations = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "themeid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "theme",
					Entity2LogicalName = "asyncoperation",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N theme_BulkDeleteFailures</summary>
			public static readonly XrmFakedRelationship ThemeBulkDeleteFailures = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "themeid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "theme",
					Entity2LogicalName = "bulkdeletefailure",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N theme_ProcessSession</summary>
			public static readonly XrmFakedRelationship ThemeProcessSession = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "themeid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "theme",
					Entity2LogicalName = "processsession",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

		}
		#endregion

		#region Fake
		public static Theme Create()
		{
			var faker = new Faker<Theme>()
			.RuleFor(e => e.AccentColor, fake => fake.Lorem.Word())
			.RuleFor(e => e.BackgroundColor, fake => fake.Lorem.Word())
			.RuleFor(e => e.ControlHoverBorderColor, fake => fake.Lorem.Word())
			.RuleFor(e => e.ControlHoverFillColor, fake => fake.Lorem.Word())
			.RuleFor(e => e.Createdbyname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Createdbyyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.CreatedOn, fake => fake.Date.Soon())
			.RuleFor(e => e.Createdonbehalfbyname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Createdonbehalfbyyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.DefaultCustomEntityColor, fake => fake.Lorem.Word())
			.RuleFor(e => e.DefaultEntityColor, fake => fake.Lorem.Word())
			.RuleFor(e => e.ExchangeRate, fake => fake.Finance.Amount())
			.RuleFor(e => e.LinkAndButtonTextColor, fake => fake.Lorem.Word())
			.RuleFor(e => e.TitleTextColor, fake => fake.Lorem.Word())
			.RuleFor(e => e.HoverLinkColor, fake => fake.Lorem.Word())
			.RuleFor(e => e.ImportSequenceNumber, fake => fake.Random.Int())
			.RuleFor(e => e.DefaultTheme, fake => fake.Random.Bool())
			.RuleFor(e => e.Logoidname, fake => fake.Lorem.Word())
			.RuleFor(e => e.LogoTooltip, fake => fake.Lorem.Word())
			.RuleFor(e => e.MainColor, fake => fake.Lorem.Word())
			.RuleFor(e => e.Modifiedbyname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Modifiedbyyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.ModifiedOn, fake => fake.Date.Soon())
			.RuleFor(e => e.Modifiedonbehalfbyname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Modifiedonbehalfbyyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.ThemeName, fake => fake.Lorem.Word())
			.RuleFor(e => e.NavigationBarFillColor, fake => fake.Lorem.Word())
			.RuleFor(e => e.NavigationBarShelfFillColor, fake => fake.Lorem.Word())
			.RuleFor(e => e.Organizationidname, fake => fake.Lorem.Word())
			.RuleFor(e => e.RecordCreatedOn, fake => fake.Date.Soon())
			.RuleFor(e => e.PageHeaderFillColor, fake => fake.Lorem.Word())
			.RuleFor(e => e.PanelHeaderFillColor, fake => fake.Lorem.Word())
			.RuleFor(e => e.LegacyAccentColor, fake => fake.Lorem.Word())
			.RuleFor(e => e.SelectedLinkColor, fake => fake.Lorem.Word())
			.RuleFor(e => e.Status, fake => fake.PickRandom<Theme.eStatus>())
			.RuleFor(e => e.StatusReason, fake => fake.PickRandom<Theme.eStatusReason>())
			.RuleFor(e => e.Id, fake => Guid.NewGuid())
			.RuleFor(e => e.TimeZoneRuleVersionNumber, fake => fake.Random.Int())
			.RuleFor(e => e.Transactioncurrencyidname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Type, fake => fake.Random.Bool())
			.RuleFor(e => e.UTCConversionTimeZoneCode, fake => fake.Random.Int())
			.RuleFor(e => e.Versionnumber, fake => fake.Random.Int());
			return faker.Generate();
		}
		#endregion
	}
}

