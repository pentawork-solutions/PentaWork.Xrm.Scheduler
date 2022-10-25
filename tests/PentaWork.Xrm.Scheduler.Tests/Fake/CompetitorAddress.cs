using Bogus;
using System;
using FakeXrmEasy;
using System.Collections.Generic;
using PentaWork.Xrm.Scheduler.Proxies.Entities;

namespace PentaWork.Xrm.Scheduler.Tests.Fake
{
	public static class FakeCompetitorAddress
	{	
		#region FakeRelationships
		public static class Relationships 
		{
			/// <summary>1:N competitoraddress_AsyncOperations</summary>
			public static readonly XrmFakedRelationship CompetitoraddressAsyncOperations = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "competitoraddressid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "competitoraddress",
					Entity2LogicalName = "asyncoperation",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N competitoraddress_BulkDeleteFailures</summary>
			public static readonly XrmFakedRelationship CompetitoraddressBulkDeleteFailures = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "competitoraddressid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "competitoraddress",
					Entity2LogicalName = "bulkdeletefailure",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N competitoraddress_MailboxTrackingFolders</summary>
			public static readonly XrmFakedRelationship CompetitoraddressMailboxTrackingFolders = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "competitoraddressid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "competitoraddress",
					Entity2LogicalName = "mailboxtrackingfolder",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N competitoraddress_PrincipalObjectAttributeAccesses</summary>
			public static readonly XrmFakedRelationship CompetitoraddressPrincipalObjectAttributeAccesses = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "competitoraddressid",
					Entity2Attribute = "objectid",
					Entity1LogicalName = "competitoraddress",
					Entity2LogicalName = "principalobjectattributeaccess",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N CompetitorAddress_SyncErrors</summary>
			public static readonly XrmFakedRelationship CompetitorAddressSyncErrors = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "competitoraddressid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "competitoraddress",
					Entity2LogicalName = "syncerror",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

		}
		#endregion

		#region Fake
		public static CompetitorAddress Create()
		{
			var faker = new Faker<CompetitorAddress>()
			.RuleFor(e => e.AddressNumber, fake => fake.Random.Int())
			.RuleFor(e => e.AddressType, fake => fake.PickRandom<CompetitorAddress.eCompetitoraddressAddresstypecode>())
			.RuleFor(e => e.City, fake => fake.Lorem.Word())
			.RuleFor(e => e.Id, fake => Guid.NewGuid())
			.RuleFor(e => e.Address, fake => fake.Lorem.Word())
			.RuleFor(e => e.CountryRegion, fake => fake.Lorem.Word())
			.RuleFor(e => e.County, fake => fake.Lorem.Word())
			.RuleFor(e => e.Createdbyname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Createdbyyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.CreatedOn, fake => fake.Date.Soon())
			.RuleFor(e => e.Createdonbehalfbyname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Createdonbehalfbyyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.Fax, fake => fake.Lorem.Word())
			.RuleFor(e => e.ImportSequenceNumber, fake => fake.Random.Int())
			.RuleFor(e => e.Latitude, fake => fake.Random.Double())
			.RuleFor(e => e.Street1, fake => fake.Lorem.Word())
			.RuleFor(e => e.Street2, fake => fake.Lorem.Word())
			.RuleFor(e => e.Street3, fake => fake.Lorem.Word())
			.RuleFor(e => e.Longitude, fake => fake.Random.Double())
			.RuleFor(e => e.Modifiedbyname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Modifiedbyyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.ModifiedOn, fake => fake.Date.Soon())
			.RuleFor(e => e.Modifiedonbehalfbyname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Modifiedonbehalfbyyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.AddressName, fake => fake.Lorem.Word())
			.RuleFor(e => e.RecordCreatedOn, fake => fake.Date.Soon())
			.RuleFor(e => e.Parentidname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Parentidyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.ZIPPostalCode, fake => fake.Lorem.Word())
			.RuleFor(e => e.PostOfficeBox, fake => fake.Lorem.Word())
			.RuleFor(e => e.ShippingMethod, fake => fake.PickRandom<CompetitorAddress.eCompetitoraddressShippingmethodcode>())
			.RuleFor(e => e.StateProvince, fake => fake.Lorem.Word())
			.RuleFor(e => e.MainPhone, fake => fake.Lorem.Word())
			.RuleFor(e => e.Phone2, fake => fake.Lorem.Word())
			.RuleFor(e => e.Phone3, fake => fake.Lorem.Word())
			.RuleFor(e => e.TimeZoneRuleVersionNumber, fake => fake.Random.Int())
			.RuleFor(e => e.UPSZone, fake => fake.Lorem.Word())
			.RuleFor(e => e.UTCConversionTimeZoneCode, fake => fake.Random.Int())
			.RuleFor(e => e.UTCOffset, fake => fake.Random.Int())
			.RuleFor(e => e.VersionNumber, fake => fake.Random.Int());
			return faker.Generate();
		}
		#endregion
	}
}

