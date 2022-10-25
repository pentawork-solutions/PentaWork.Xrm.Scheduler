using Bogus;
using System;
using FakeXrmEasy;
using System.Collections.Generic;
using PentaWork.Xrm.Scheduler.Proxies.Entities;

namespace PentaWork.Xrm.Scheduler.Tests.Fake
{
	public static class FakeAddress
	{	
		#region FakeRelationships
		public static class Relationships 
		{
			/// <summary>1:N customer_address_contract_line_items</summary>
			public static readonly XrmFakedRelationship CustomerAddressContractLineItems = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "customeraddressid",
					Entity2Attribute = "serviceaddress",
					Entity1LogicalName = "customeraddress",
					Entity2LogicalName = "contractdetail",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N customer_address_contracts_as_billing_address</summary>
			public static readonly XrmFakedRelationship CustomerAddressContractsAsBillingAddress = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "customeraddressid",
					Entity2Attribute = "billtoaddress",
					Entity1LogicalName = "customeraddress",
					Entity2LogicalName = "contract",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N customer_address_contracts_as_service_address</summary>
			public static readonly XrmFakedRelationship CustomerAddressContractsAsServiceAddress = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "customeraddressid",
					Entity2Attribute = "serviceaddress",
					Entity1LogicalName = "customeraddress",
					Entity2LogicalName = "contract",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N CustomerAddress_AsyncOperations</summary>
			public static readonly XrmFakedRelationship CustomerAddressAsyncOperations = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "customeraddressid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "customeraddress",
					Entity2LogicalName = "asyncoperation",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N CustomerAddress_BulkDeleteFailures</summary>
			public static readonly XrmFakedRelationship CustomerAddressBulkDeleteFailures = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "customeraddressid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "customeraddress",
					Entity2LogicalName = "bulkdeletefailure",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N customeraddress_principalobjectattributeaccess</summary>
			public static readonly XrmFakedRelationship CustomeraddressPrincipalobjectattributeaccess = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "customeraddressid",
					Entity2Attribute = "objectid",
					Entity1LogicalName = "customeraddress",
					Entity2LogicalName = "principalobjectattributeaccess",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N CustomerAddress_ProcessSessions</summary>
			public static readonly XrmFakedRelationship CustomerAddressProcessSessions = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "customeraddressid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "customeraddress",
					Entity2LogicalName = "processsession",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N CustomerAddress_SyncErrors</summary>
			public static readonly XrmFakedRelationship CustomerAddressSyncErrors = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "customeraddressid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "customeraddress",
					Entity2LogicalName = "syncerror",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

		}
		#endregion

		#region Fake
		public static Address Create()
		{
			var faker = new Faker<Address>()
			.RuleFor(e => e.AddressNumber, fake => fake.Random.Int())
			.RuleFor(e => e.AddressType, fake => fake.PickRandom<Address.eAddressType>())
			.RuleFor(e => e.City, fake => fake.Lorem.Word())
			.RuleFor(e => e.Address2, fake => fake.Lorem.Word())
			.RuleFor(e => e.CountryRegion, fake => fake.Lorem.Word())
			.RuleFor(e => e.County, fake => fake.Lorem.Word())
			.RuleFor(e => e.Createdbyname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Createdbyyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.CreatedOn, fake => fake.Date.Soon())
			.RuleFor(e => e.Createdonbehalfbyname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Createdonbehalfbyyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.Id, fake => Guid.NewGuid())
			.RuleFor(e => e.ExchangeRate, fake => fake.Finance.Amount())
			.RuleFor(e => e.Fax, fake => fake.Lorem.Word())
			.RuleFor(e => e.FreightTerms, fake => fake.PickRandom<Address.eFreightTerms>())
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
			.RuleFor(e => e.ObjectType, fake => fake.Lorem.Word())
			.RuleFor(e => e.RecordCreatedOn, fake => fake.Date.Soon())
			.RuleFor(e => e.Owneridtype, fake => fake.Lorem.Word())
			.RuleFor(e => e.ParentObjectType, fake => fake.Lorem.Word())
			.RuleFor(e => e.ZIPPostalCode, fake => fake.Lorem.Word())
			.RuleFor(e => e.PostOfficeBox, fake => fake.Lorem.Word())
			.RuleFor(e => e.AddressContact, fake => fake.Lorem.Word())
			.RuleFor(e => e.ShippingMethod, fake => fake.PickRandom<Address.eShippingMethod>())
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

