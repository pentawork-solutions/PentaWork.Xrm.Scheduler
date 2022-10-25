using Bogus;
using System;
using FakeXrmEasy;
using System.Collections.Generic;
using PentaWork.Xrm.Scheduler.Proxies.Entities;

namespace PentaWork.Xrm.Scheduler.Tests.Fake
{
	public static class FakeLeadAddress
	{	
		#region FakeRelationships
		public static class Relationships 
		{
			/// <summary>1:N leadaddress_AsyncOperations</summary>
			public static readonly XrmFakedRelationship LeadaddressAsyncOperations = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "leadaddressid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "leadaddress",
					Entity2LogicalName = "asyncoperation",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N leadaddress_BulkDeleteFailures</summary>
			public static readonly XrmFakedRelationship LeadaddressBulkDeleteFailures = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "leadaddressid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "leadaddress",
					Entity2LogicalName = "bulkdeletefailure",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N leadaddress_MailboxTrackingFolders</summary>
			public static readonly XrmFakedRelationship LeadaddressMailboxTrackingFolders = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "leadaddressid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "leadaddress",
					Entity2LogicalName = "mailboxtrackingfolder",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N leadaddress_PrincipalObjectAttributeAccesses</summary>
			public static readonly XrmFakedRelationship LeadaddressPrincipalObjectAttributeAccesses = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "leadaddressid",
					Entity2Attribute = "objectid",
					Entity1LogicalName = "leadaddress",
					Entity2LogicalName = "principalobjectattributeaccess",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N LeadAddress_SyncErrors</summary>
			public static readonly XrmFakedRelationship LeadAddressSyncErrors = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "leadaddressid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "leadaddress",
					Entity2LogicalName = "syncerror",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

		}
		#endregion

		#region Fake
		public static LeadAddress Create()
		{
			var faker = new Faker<LeadAddress>()
			.RuleFor(e => e.AddressNumber, fake => fake.Random.Int())
			.RuleFor(e => e.AddressType, fake => fake.PickRandom<LeadAddress.eAddressType>())
			.RuleFor(e => e.City, fake => fake.Lorem.Word())
			.RuleFor(e => e.Address, fake => fake.Lorem.Word())
			.RuleFor(e => e.CountryRegion, fake => fake.Lorem.Word())
			.RuleFor(e => e.County, fake => fake.Lorem.Word())
			.RuleFor(e => e.Createdbyname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Createdbyyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.CreatedOn, fake => fake.Date.Soon())
			.RuleFor(e => e.Createdonbehalfbyname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Createdonbehalfbyyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.ExchangeRate, fake => fake.Finance.Amount())
			.RuleFor(e => e.Fax, fake => fake.Lorem.Word())
			.RuleFor(e => e.ImportSequenceNumber, fake => fake.Random.Int())
			.RuleFor(e => e.Latitude, fake => fake.Random.Double())
			.RuleFor(e => e.Id, fake => Guid.NewGuid())
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
			.RuleFor(e => e.OwnerId, fake => Guid.NewGuid())
			.RuleFor(e => e.OwningbusinessunitId, fake => Guid.NewGuid())
			.RuleFor(e => e.Parentidname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Parentidyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.ZIPPostalCode, fake => fake.Lorem.Word())
			.RuleFor(e => e.PostOfficeBox, fake => fake.Lorem.Word())
			.RuleFor(e => e.ShippingMethod, fake => fake.PickRandom<LeadAddress.eShippingMethod>())
			.RuleFor(e => e.StateProvince, fake => fake.Lorem.Word())
			.RuleFor(e => e.MainPhone, fake => fake.Lorem.Word())
			.RuleFor(e => e.Phone2, fake => fake.Lorem.Word())
			.RuleFor(e => e.Telephone3, fake => fake.Lorem.Word())
			.RuleFor(e => e.TimeZoneRuleVersionNumber, fake => fake.Random.Int())
			.RuleFor(e => e.Transactioncurrencyidname, fake => fake.Lorem.Word())
			.RuleFor(e => e.UPSZone, fake => fake.Lorem.Word())
			.RuleFor(e => e.UTCConversionTimeZoneCode, fake => fake.Random.Int())
			.RuleFor(e => e.UTCOffset, fake => fake.Random.Int())
			.RuleFor(e => e.VersionNumber, fake => fake.Random.Int());
			return faker.Generate();
		}
		#endregion
	}
}

