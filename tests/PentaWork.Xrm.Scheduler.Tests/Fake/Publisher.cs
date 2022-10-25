using Bogus;
using System;
using FakeXrmEasy;
using System.Collections.Generic;
using PentaWork.Xrm.Scheduler.Proxies.Entities;

namespace PentaWork.Xrm.Scheduler.Tests.Fake
{
	public static class FakePublisher
	{	
		#region FakeRelationships
		public static class Relationships 
		{
			/// <summary>1:N publisher_appmodule</summary>
			public static readonly XrmFakedRelationship PublisherAppmodule = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "publisherid",
					Entity2Attribute = "publisherid",
					Entity1LogicalName = "publisher",
					Entity2LogicalName = "appmodule",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N Publisher_DuplicateBaseRecord</summary>
			public static readonly XrmFakedRelationship PublisherDuplicateBaseRecord = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "publisherid",
					Entity2Attribute = "baserecordid",
					Entity1LogicalName = "publisher",
					Entity2LogicalName = "duplicaterecord",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N Publisher_DuplicateMatchingRecord</summary>
			public static readonly XrmFakedRelationship PublisherDuplicateMatchingRecord = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "publisherid",
					Entity2Attribute = "duplicaterecordid",
					Entity1LogicalName = "publisher",
					Entity2LogicalName = "duplicaterecord",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N Publisher_PublisherAddress</summary>
			public static readonly XrmFakedRelationship PublisherPublisherAddress = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "publisherid",
					Entity2Attribute = "parentid",
					Entity1LogicalName = "publisher",
					Entity2LogicalName = "publisheraddress",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N publisher_solution</summary>
			public static readonly XrmFakedRelationship PublisherSolution = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "publisherid",
					Entity2Attribute = "publisherid",
					Entity1LogicalName = "publisher",
					Entity2LogicalName = "solution",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N Publisher_SyncErrors</summary>
			public static readonly XrmFakedRelationship PublisherSyncErrors = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "publisherid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "publisher",
					Entity2LogicalName = "syncerror",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

		}
		#endregion

		#region Fake
		public static Publisher Create()
		{
			var faker = new Faker<Publisher>()
			.RuleFor(e => e.Address1Id, fake => Guid.NewGuid())
			.RuleFor(e => e.Address1AddressType, fake => fake.PickRandom<Publisher.eAddress1AddressType>())
			.RuleFor(e => e.City, fake => fake.Lorem.Word())
			.RuleFor(e => e.CountryRegion, fake => fake.Lorem.Word())
			.RuleFor(e => e.Address1County, fake => fake.Lorem.Word())
			.RuleFor(e => e.Address1Fax, fake => fake.Lorem.Word())
			.RuleFor(e => e.Address1Latitude, fake => fake.Random.Double())
			.RuleFor(e => e.Street1, fake => fake.Lorem.Word())
			.RuleFor(e => e.Street2, fake => fake.Lorem.Word())
			.RuleFor(e => e.Street3, fake => fake.Lorem.Word())
			.RuleFor(e => e.Address1Longitude, fake => fake.Random.Double())
			.RuleFor(e => e.Address1Name, fake => fake.Lorem.Word())
			.RuleFor(e => e.ZIPPostalCode, fake => fake.Lorem.Word())
			.RuleFor(e => e.Address1PostOfficeBox, fake => fake.Lorem.Word())
			.RuleFor(e => e.Address1ShippingMethod, fake => fake.PickRandom<Publisher.eAddress1ShippingMethod>())
			.RuleFor(e => e.StateProvince, fake => fake.Lorem.Word())
			.RuleFor(e => e.Phone, fake => fake.Lorem.Word())
			.RuleFor(e => e.Address1Telephone2, fake => fake.Lorem.Word())
			.RuleFor(e => e.Address1Telephone3, fake => fake.Lorem.Word())
			.RuleFor(e => e.Address1UPSZone, fake => fake.Lorem.Word())
			.RuleFor(e => e.Address1UTCOffset, fake => fake.Random.Int())
			.RuleFor(e => e.Address2Id, fake => Guid.NewGuid())
			.RuleFor(e => e.Address2AddressType, fake => fake.PickRandom<Publisher.eAddress2AddressType>())
			.RuleFor(e => e.Address2City, fake => fake.Lorem.Word())
			.RuleFor(e => e.Address2CountryRegion, fake => fake.Lorem.Word())
			.RuleFor(e => e.Address2County, fake => fake.Lorem.Word())
			.RuleFor(e => e.Address2Fax, fake => fake.Lorem.Word())
			.RuleFor(e => e.Address2Latitude, fake => fake.Random.Double())
			.RuleFor(e => e.Address2Street1, fake => fake.Lorem.Word())
			.RuleFor(e => e.Address2Street2, fake => fake.Lorem.Word())
			.RuleFor(e => e.Address2Street3, fake => fake.Lorem.Word())
			.RuleFor(e => e.Address2Longitude, fake => fake.Random.Double())
			.RuleFor(e => e.Address2Name, fake => fake.Lorem.Word())
			.RuleFor(e => e.Address2ZIPPostalCode, fake => fake.Lorem.Word())
			.RuleFor(e => e.Address2PostOfficeBox, fake => fake.Lorem.Word())
			.RuleFor(e => e.Address2ShippingMethod, fake => fake.PickRandom<Publisher.eAddress2ShippingMethod>())
			.RuleFor(e => e.Address2StateProvince, fake => fake.Lorem.Word())
			.RuleFor(e => e.Address2Telephone1, fake => fake.Lorem.Word())
			.RuleFor(e => e.Address2Telephone2, fake => fake.Lorem.Word())
			.RuleFor(e => e.Address2Telephone3, fake => fake.Lorem.Word())
			.RuleFor(e => e.Address2UPSZone, fake => fake.Lorem.Word())
			.RuleFor(e => e.Address2UTCOffset, fake => fake.Random.Int())
			.RuleFor(e => e.Createdbyname, fake => fake.Lorem.Word())
			.RuleFor(e => e.CreatedOn, fake => fake.Date.Soon())
			.RuleFor(e => e.Createdonbehalfbyname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Createdonbehalfbyyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.OptionValuePrefix, fake => fake.Random.Int())
			.RuleFor(e => e.Prefix, fake => fake.Lorem.Word())
			.RuleFor(e => e.Description, fake => fake.Lorem.Word())
			.RuleFor(e => e.Email, fake => fake.Lorem.Word())
			.RuleFor(e => e.EntityimageTimestamp, fake => fake.Random.Int())
			.RuleFor(e => e.EntityimageUrl, fake => fake.Lorem.Word())
			.RuleFor(e => e.EntityImageId, fake => Guid.NewGuid())
			.RuleFor(e => e.DisplayName, fake => fake.Lorem.Word())
			.RuleFor(e => e.IsReadOnlyPublisher, fake => fake.Random.Bool())
			.RuleFor(e => e.Modifiedbyname, fake => fake.Lorem.Word())
			.RuleFor(e => e.ModifiedOn, fake => fake.Date.Soon())
			.RuleFor(e => e.Modifiedonbehalfbyname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Modifiedonbehalfbyyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.Organizationidname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Pinpointpublisherdefaultlocale, fake => fake.Lorem.Word())
			.RuleFor(e => e.Pinpointpublisherid, fake => fake.Random.Int())
			.RuleFor(e => e.Id, fake => Guid.NewGuid())
			.RuleFor(e => e.Website, fake => fake.Lorem.Word())
			.RuleFor(e => e.Name, fake => fake.Lorem.Word())
			.RuleFor(e => e.Versionnumber, fake => fake.Random.Int());
			return faker.Generate();
		}
		#endregion
	}
}

