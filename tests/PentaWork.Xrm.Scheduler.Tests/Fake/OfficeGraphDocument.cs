using Bogus;
using System;
using FakeXrmEasy;
using System.Collections.Generic;
using PentaWork.Xrm.Scheduler.Proxies.Entities;

namespace PentaWork.Xrm.Scheduler.Tests.Fake
{
	public static class FakeOfficeGraphDocument
	{	
		#region FakeRelationships
		public static class Relationships 
		{
		}
		#endregion

		#region Fake
		public static OfficeGraphDocument Create()
		{
			var faker = new Faker<OfficeGraphDocument>()
			.RuleFor(e => e.AuthorNames, fake => fake.Lorem.Word())
			.RuleFor(e => e.CreatedBy, fake => fake.Lorem.Word())
			.RuleFor(e => e.Createdonbehalfbyname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Createdonbehalfbyyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.CreatedTime, fake => fake.Date.Soon())
			.RuleFor(e => e.DocumentId, fake => fake.Lorem.Word())
			.RuleFor(e => e.DocumentLastModifiedBy, fake => fake.Lorem.Word())
			.RuleFor(e => e.DocumentLastModifiedOn, fake => fake.Date.Soon())
			.RuleFor(e => e.DocumentPreviewMetadata, fake => fake.Lorem.Word())
			.RuleFor(e => e.ExchangeRate, fake => fake.Finance.Amount())
			.RuleFor(e => e.FileExtension, fake => fake.Lorem.Word())
			.RuleFor(e => e.FileType, fake => fake.Lorem.Word())
			.RuleFor(e => e.ModifiedBy, fake => fake.Lorem.Word())
			.RuleFor(e => e.Modifiedonbehalfbyname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Modifiedonbehalfbyyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.ModifiedTime, fake => fake.Date.Soon())
			.RuleFor(e => e.Id, fake => Guid.NewGuid())
			.RuleFor(e => e.Organizationidname, fake => fake.Lorem.Word())
			.RuleFor(e => e.PreviewImageUrl, fake => fake.Lorem.Word())
			.RuleFor(e => e.QueryType, fake => fake.Random.Int())
			.RuleFor(e => e.RelevancyRankOfTheDocument, fake => fake.Random.Int())
			.RuleFor(e => e.ReadUrl, fake => fake.Lorem.Word())
			.RuleFor(e => e.SecondaryFileExtension, fake => fake.Lorem.Word())
			.RuleFor(e => e.ParentSiteTitle, fake => fake.Lorem.Word())
			.RuleFor(e => e.SiteUrl, fake => fake.Lorem.Word())
			.RuleFor(e => e.TimeZoneRuleVersionNumber, fake => fake.Random.Int())
			.RuleFor(e => e.Title, fake => fake.Lorem.Word())
			.RuleFor(e => e.Transactioncurrencyidname, fake => fake.Lorem.Word())
			.RuleFor(e => e.UTCConversionTimeZoneCode, fake => fake.Random.Int())
			.RuleFor(e => e.Versionnumber, fake => fake.Random.Int())
			.RuleFor(e => e.ViewCount, fake => fake.Random.Int())
			.RuleFor(e => e.WebLocationUrl, fake => fake.Lorem.Word());
			return faker.Generate();
		}
		#endregion
	}
}

