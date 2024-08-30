using Bogus;
using System;
using FakeXrmEasy;
using System.Collections.Generic;
using PentaWork.Xrm.Scheduler.Proxies.Entities;

namespace PentaWork.Xrm.Scheduler.Tests.Fake
{
	public static class FakeAccount
	{	
		#region FakeRelationships
		public static class Relationships 
		{
			/// <summary>1:N account_activity_parties</summary>
			public static readonly XrmFakedRelationship AccountActivityParties = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "accountid",
					Entity2Attribute = "partyid",
					Entity1LogicalName = "account",
					Entity2LogicalName = "activityparty",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N Account_AsyncOperations</summary>
			public static readonly XrmFakedRelationship AccountAsyncOperations = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "accountid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "account",
					Entity2LogicalName = "asyncoperation",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N Account_Email_EmailSender</summary>
			public static readonly XrmFakedRelationship AccountEmailEmailSender = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "accountid",
					Entity2Attribute = "emailsender",
					Entity1LogicalName = "account",
					Entity2LogicalName = "email",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N Account_Email_SendersAccount</summary>
			public static readonly XrmFakedRelationship AccountEmailSendersAccount = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "accountid",
					Entity2Attribute = "sendersaccount",
					Entity1LogicalName = "account",
					Entity2LogicalName = "email",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N Account_Emails</summary>
			public static readonly XrmFakedRelationship AccountEmails = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "accountid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "account",
					Entity2LogicalName = "email",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N account_master_account</summary>
			public static readonly XrmFakedRelationship AccountMasterAccount = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "accountid",
					Entity2Attribute = "masterid",
					Entity1LogicalName = "account",
					Entity2LogicalName = "account",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N account_parent_account</summary>
			public static readonly XrmFakedRelationship AccountParentAccount = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "accountid",
					Entity2Attribute = "parentaccountid",
					Entity1LogicalName = "account",
					Entity2LogicalName = "account",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N msa_account_managingpartner</summary>
			public static readonly XrmFakedRelationship MsaAccountManagingpartner = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "accountid",
					Entity2Attribute = "msa_managingpartnerid",
					Entity1LogicalName = "account",
					Entity2LogicalName = "account",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

		}
		#endregion

		#region Fake
		public static Account Create()
		{
			var faker = new Faker<Account>()
			.RuleFor(e => e.Category, fake => fake.PickRandom<Account.eCategory>())
			.RuleFor(e => e.Classification, fake => fake.PickRandom<Account.eClassification>())
			.RuleFor(e => e.Id, fake => Guid.NewGuid())
			.RuleFor(e => e.AccountNumber, fake => fake.Lorem.Word())
			.RuleFor(e => e.AccountRating, fake => fake.PickRandom<Account.eAccountRating>())
			.RuleFor(e => e.Address1Id, fake => Guid.NewGuid())
			.RuleFor(e => e.Address1AddressType, fake => fake.PickRandom<Account.eAddress1AddressType>())
			.RuleFor(e => e.Address1City, fake => fake.Lorem.Word())
			.RuleFor(e => e.Address1, fake => fake.Lorem.Word())
			.RuleFor(e => e.Address1CountryRegion, fake => fake.Lorem.Word())
			.RuleFor(e => e.Address1County, fake => fake.Lorem.Word())
			.RuleFor(e => e.Address1Fax, fake => fake.Lorem.Word())
			.RuleFor(e => e.Address1FreightTerms, fake => fake.PickRandom<Account.eAddress1FreightTerms>())
			.RuleFor(e => e.Address1Latitude, fake => fake.Random.Double())
			.RuleFor(e => e.Address1Street1, fake => fake.Lorem.Word())
			.RuleFor(e => e.Address1Street2, fake => fake.Lorem.Word())
			.RuleFor(e => e.Address1Street3, fake => fake.Lorem.Word())
			.RuleFor(e => e.Address1Longitude, fake => fake.Random.Double())
			.RuleFor(e => e.Address1Name, fake => fake.Lorem.Word())
			.RuleFor(e => e.Address1ZIPPostalCode, fake => fake.Lorem.Word())
			.RuleFor(e => e.Address1PostOfficeBox, fake => fake.Lorem.Word())
			.RuleFor(e => e.Address1PrimaryContactName, fake => fake.Lorem.Word())
			.RuleFor(e => e.Address1ShippingMethod, fake => fake.PickRandom<Account.eAddress1ShippingMethod>())
			.RuleFor(e => e.Address1StateProvince, fake => fake.Lorem.Word())
			.RuleFor(e => e.AddressPhone, fake => fake.Lorem.Word())
			.RuleFor(e => e.Address1Telephone2, fake => fake.Lorem.Word())
			.RuleFor(e => e.Address1Telephone3, fake => fake.Lorem.Word())
			.RuleFor(e => e.Address1UPSZone, fake => fake.Lorem.Word())
			.RuleFor(e => e.Address1UTCOffset, fake => fake.Random.Int())
			.RuleFor(e => e.Address2Id, fake => Guid.NewGuid())
			.RuleFor(e => e.Address2AddressType, fake => fake.PickRandom<Account.eAddress2AddressType>())
			.RuleFor(e => e.Address2City, fake => fake.Lorem.Word())
			.RuleFor(e => e.Address2, fake => fake.Lorem.Word())
			.RuleFor(e => e.Address2CountryRegion, fake => fake.Lorem.Word())
			.RuleFor(e => e.Address2County, fake => fake.Lorem.Word())
			.RuleFor(e => e.Address2Fax, fake => fake.Lorem.Word())
			.RuleFor(e => e.Address2FreightTerms, fake => fake.PickRandom<Account.eAddress2FreightTerms>())
			.RuleFor(e => e.Address2Latitude, fake => fake.Random.Double())
			.RuleFor(e => e.Address2Street1, fake => fake.Lorem.Word())
			.RuleFor(e => e.Address2Street2, fake => fake.Lorem.Word())
			.RuleFor(e => e.Address2Street3, fake => fake.Lorem.Word())
			.RuleFor(e => e.Address2Longitude, fake => fake.Random.Double())
			.RuleFor(e => e.Address2Name, fake => fake.Lorem.Word())
			.RuleFor(e => e.Address2ZIPPostalCode, fake => fake.Lorem.Word())
			.RuleFor(e => e.Address2PostOfficeBox, fake => fake.Lorem.Word())
			.RuleFor(e => e.Address2PrimaryContactName, fake => fake.Lorem.Word())
			.RuleFor(e => e.Address2ShippingMethod, fake => fake.PickRandom<Account.eAddress2ShippingMethod>())
			.RuleFor(e => e.Address2StateProvince, fake => fake.Lorem.Word())
			.RuleFor(e => e.Address2Telephone1, fake => fake.Lorem.Word())
			.RuleFor(e => e.Address2Telephone2, fake => fake.Lorem.Word())
			.RuleFor(e => e.Address2Telephone3, fake => fake.Lorem.Word())
			.RuleFor(e => e.Address2UPSZone, fake => fake.Lorem.Word())
			.RuleFor(e => e.Address2UTCOffset, fake => fake.Random.Int())
			.RuleFor(e => e.CreatedByIPAddress, fake => fake.Lorem.Word())
			.RuleFor(e => e.CreatedByUserName, fake => fake.Lorem.Word())
			.RuleFor(e => e.ModifiedByIPAddress, fake => fake.Lorem.Word())
			.RuleFor(e => e.ModifiedByUserName, fake => fake.Lorem.Word())
			.RuleFor(e => e.Aging30, fake => fake.Finance.Amount())
			.RuleFor(e => e.Aging60, fake => fake.Finance.Amount())
			.RuleFor(e => e.Aging90, fake => fake.Finance.Amount())
			.RuleFor(e => e.BusinessType, fake => fake.PickRandom<Account.eBusinessType>())
			.RuleFor(e => e.Createdbyexternalpartyname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Createdbyexternalpartyyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.Createdbyname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Createdbyyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.CreatedOn, fake => fake.Date.Soon())
			.RuleFor(e => e.Createdonbehalfbyname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Createdonbehalfbyyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.CreditLimit, fake => fake.Finance.Amount())
			.RuleFor(e => e.CreditHold, fake => fake.Random.Bool())
			.RuleFor(e => e.CustomerSize, fake => fake.PickRandom<Account.eCustomerSize>())
			.RuleFor(e => e.RelationshipType, fake => fake.PickRandom<Account.eRelationshipType>())
			.RuleFor(e => e.Description, fake => fake.Lorem.Word())
			.RuleFor(e => e.DoNotAllowBulkEmails, fake => fake.Random.Bool())
			.RuleFor(e => e.DoNotAllowBulkMails, fake => fake.Random.Bool())
			.RuleFor(e => e.DoNotAllowEmails, fake => fake.Random.Bool())
			.RuleFor(e => e.DoNotAllowFaxes, fake => fake.Random.Bool())
			.RuleFor(e => e.DoNotAllowPhoneCalls, fake => fake.Random.Bool())
			.RuleFor(e => e.DoNotAllowMails, fake => fake.Random.Bool())
			.RuleFor(e => e.SendMarketingMaterials, fake => fake.Random.Bool())
			.RuleFor(e => e.Email, fake => fake.Lorem.Word())
			.RuleFor(e => e.EmailAddress2, fake => fake.Lorem.Word())
			.RuleFor(e => e.EmailAddress3, fake => fake.Lorem.Word())
			.RuleFor(e => e.EntityimageTimestamp, fake => fake.Random.Int())
			.RuleFor(e => e.EntityimageUrl, fake => fake.Lorem.Word())
			.RuleFor(e => e.EntityImageId, fake => Guid.NewGuid())
			.RuleFor(e => e.ExchangeRate, fake => fake.Finance.Amount())
			.RuleFor(e => e.Fax, fake => fake.Lorem.Word())
			.RuleFor(e => e.FollowEmailActivity, fake => fake.Random.Bool())
			.RuleFor(e => e.FTPSite, fake => fake.Lorem.Word())
			.RuleFor(e => e.ImportSequenceNumber, fake => fake.Random.Int())
			.RuleFor(e => e.Industry, fake => fake.PickRandom<Account.eIndustry>())
			.RuleFor(e => e.Isprivate, fake => fake.Random.Bool())
			.RuleFor(e => e.LastOnHoldTime, fake => fake.Date.Soon())
			.RuleFor(e => e.LastDateIncludedInCampaign, fake => fake.Date.Soon())
			.RuleFor(e => e.MarketCapitalization, fake => fake.Finance.Amount())
			.RuleFor(e => e.MarketingOnly, fake => fake.Random.Bool())
			.RuleFor(e => e.Masteraccountidname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Masteraccountidyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.Merged, fake => fake.Random.Bool())
			.RuleFor(e => e.Modifiedbyexternalpartyname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Modifiedbyexternalpartyyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.Modifiedbyname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Modifiedbyyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.ModifiedOn, fake => fake.Date.Soon())
			.RuleFor(e => e.Modifiedonbehalfbyname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Modifiedonbehalfbyyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.MsaManagingpartneridname, fake => fake.Lorem.Word())
			.RuleFor(e => e.MsaManagingpartneridyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.AccountName, fake => fake.Lorem.Word())
			.RuleFor(e => e.NumberOfEmployees, fake => fake.Random.Int())
			.RuleFor(e => e.OnHoldTimeMinutes, fake => fake.Random.Int())
			.RuleFor(e => e.RecordCreatedOn, fake => fake.Date.Soon())
			.RuleFor(e => e.Owneridname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Owneridtype, fake => fake.Lorem.Word())
			.RuleFor(e => e.Owneridyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.Ownership, fake => fake.PickRandom<Account.eOwnership>())
			.RuleFor(e => e.Owningbusinessunitname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Parentaccountidname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Parentaccountidyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.ParticipatesInWorkflow, fake => fake.Random.Bool())
			.RuleFor(e => e.PaymentTerms, fake => fake.PickRandom<Account.ePaymentTerms>())
			.RuleFor(e => e.PreferredDay, fake => fake.PickRandom<Account.ePreferredDay>())
			.RuleFor(e => e.PreferredTime, fake => fake.PickRandom<Account.ePreferredTime>())
			.RuleFor(e => e.PreferredMethodOfContact, fake => fake.PickRandom<Account.ePreferredMethodOfContact>())
			.RuleFor(e => e.Preferredsystemuseridname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Preferredsystemuseridyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.Primarycontactidname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Primarycontactidyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.PrimarySatoriID, fake => fake.Lorem.Word())
			.RuleFor(e => e.PrimaryTwitterID, fake => fake.Lorem.Word())
			.RuleFor(e => e.ProcessId, fake => Guid.NewGuid())
			.RuleFor(e => e.AnnualRevenue, fake => fake.Finance.Amount())
			.RuleFor(e => e.SharesOutstanding, fake => fake.Random.Int())
			.RuleFor(e => e.ShippingMethod, fake => fake.PickRandom<Account.eShippingMethod>())
			.RuleFor(e => e.SICCode, fake => fake.Lorem.Word())
			.RuleFor(e => e.Slainvokedidname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Slaname, fake => fake.Lorem.Word())
			.RuleFor(e => e.DeprecatedProcessStageId, fake => Guid.NewGuid())
			.RuleFor(e => e.Status, fake => fake.PickRandom<Account.eStatus>())
			.RuleFor(e => e.StatusReason, fake => fake.PickRandom<Account.eStatusReason>())
			.RuleFor(e => e.StockExchange, fake => fake.Lorem.Word())
			.RuleFor(e => e.MainPhone, fake => fake.Lorem.Word())
			.RuleFor(e => e.OtherPhone, fake => fake.Lorem.Word())
			.RuleFor(e => e.Telephone3, fake => fake.Lorem.Word())
			.RuleFor(e => e.TerritoryCode, fake => fake.PickRandom<Account.eTerritoryCode>())
			.RuleFor(e => e.TickerSymbol, fake => fake.Lorem.Word())
			.RuleFor(e => e.TimeSpentByMe, fake => fake.Lorem.Word())
			.RuleFor(e => e.TimeZoneRuleVersionNumber, fake => fake.Random.Int())
			.RuleFor(e => e.Transactioncurrencyidname, fake => fake.Lorem.Word())
			.RuleFor(e => e.DeprecatedTraversedPath, fake => fake.Lorem.Word())
			.RuleFor(e => e.UTCConversionTimeZoneCode, fake => fake.Random.Int())
			.RuleFor(e => e.VersionNumber, fake => fake.Random.Int())
			.RuleFor(e => e.Website, fake => fake.Lorem.Word())
			.RuleFor(e => e.YomiAccountName, fake => fake.Lorem.Word());
			return faker.Generate();
		}
		#endregion
	}
}

