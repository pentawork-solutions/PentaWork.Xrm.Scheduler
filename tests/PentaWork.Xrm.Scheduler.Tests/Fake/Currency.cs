using Bogus;
using System;
using FakeXrmEasy;
using System.Collections.Generic;
using PentaWork.Xrm.Scheduler.Proxies.Entities;

namespace PentaWork.Xrm.Scheduler.Tests.Fake
{
	public static class FakeCurrency
	{	
		#region FakeRelationships
		public static class Relationships 
		{
			/// <summary>1:N basecurrency_organization</summary>
			public static readonly XrmFakedRelationship BasecurrencyOrganization = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "transactioncurrencyid",
					Entity2Attribute = "basecurrencyid",
					Entity1LogicalName = "transactioncurrency",
					Entity2LogicalName = "organization",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N bulkoperation_transactioncurrency_transactioncurrencyid</summary>
			public static readonly XrmFakedRelationship BulkoperationTransactioncurrencyTransactioncurrencyid = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "transactioncurrencyid",
					Entity2Attribute = "transactioncurrencyid",
					Entity1LogicalName = "transactioncurrency",
					Entity2LogicalName = "bulkoperation",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N DynamicPropertyAssociation_TransactionCurrency</summary>
			public static readonly XrmFakedRelationship DynamicPropertyAssociationTransactionCurrency = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "transactioncurrencyid",
					Entity2Attribute = "transactioncurrencyid",
					Entity1LogicalName = "transactioncurrency",
					Entity2LogicalName = "dynamicpropertyassociation",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N DynamicPropertyOptionSetItem_TransactionCurrency</summary>
			public static readonly XrmFakedRelationship DynamicPropertyOptionSetItemTransactionCurrency = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "transactioncurrencyid",
					Entity2Attribute = "transactioncurrencyid",
					Entity1LogicalName = "transactioncurrency",
					Entity2LogicalName = "dynamicpropertyoptionsetitem",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N incidentresolution_transactioncurrency_transactioncurrencyid</summary>
			public static readonly XrmFakedRelationship IncidentresolutionTransactioncurrencyTransactioncurrencyid = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "transactioncurrencyid",
					Entity2Attribute = "transactioncurrencyid",
					Entity1LogicalName = "transactioncurrency",
					Entity2LogicalName = "incidentresolution",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N orderclose_transactioncurrency_transactioncurrencyid</summary>
			public static readonly XrmFakedRelationship OrdercloseTransactioncurrencyTransactioncurrencyid = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "transactioncurrencyid",
					Entity2Attribute = "transactioncurrencyid",
					Entity1LogicalName = "transactioncurrency",
					Entity2LogicalName = "orderclose",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N quoteclose_transactioncurrency_transactioncurrencyid</summary>
			public static readonly XrmFakedRelationship QuotecloseTransactioncurrencyTransactioncurrencyid = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "transactioncurrencyid",
					Entity2Attribute = "transactioncurrencyid",
					Entity1LogicalName = "transactioncurrency",
					Entity2LogicalName = "quoteclose",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N transactioncurrency_account</summary>
			public static readonly XrmFakedRelationship TransactioncurrencyAccount = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "transactioncurrencyid",
					Entity2Attribute = "transactioncurrencyid",
					Entity1LogicalName = "transactioncurrency",
					Entity2LogicalName = "account",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N transactioncurrency_actioncard</summary>
			public static readonly XrmFakedRelationship TransactioncurrencyActioncard = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "transactioncurrencyid",
					Entity2Attribute = "transactioncurrencyid",
					Entity1LogicalName = "transactioncurrency",
					Entity2LogicalName = "actioncard",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N TransactionCurrency_ActionCardUserState</summary>
			public static readonly XrmFakedRelationship TransactionCurrencyActionCardUserState = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "transactioncurrencyid",
					Entity2Attribute = "transactioncurrencyid",
					Entity1LogicalName = "transactioncurrency",
					Entity2LogicalName = "actioncarduserstate",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N TransactionCurrency_ActivityPointer</summary>
			public static readonly XrmFakedRelationship TransactionCurrencyActivityPointer = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "transactioncurrencyid",
					Entity2Attribute = "transactioncurrencyid",
					Entity1LogicalName = "transactioncurrency",
					Entity2LogicalName = "activitypointer",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N transactioncurrency_annualfiscalcalendar</summary>
			public static readonly XrmFakedRelationship TransactioncurrencyAnnualfiscalcalendar = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "transactioncurrencyid",
					Entity2Attribute = "transactioncurrencyid",
					Entity1LogicalName = "transactioncurrency",
					Entity2LogicalName = "annualfiscalcalendar",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N TransactionCurrency_Appointment</summary>
			public static readonly XrmFakedRelationship TransactionCurrencyAppointment = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "transactioncurrencyid",
					Entity2Attribute = "transactioncurrencyid",
					Entity1LogicalName = "transactioncurrency",
					Entity2LogicalName = "appointment",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N TransactionCurrency_AsyncOperations</summary>
			public static readonly XrmFakedRelationship TransactionCurrencyAsyncOperations = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "transactioncurrencyid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "transactioncurrency",
					Entity2LogicalName = "asyncoperation",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N TransactionCurrency_bookableresource</summary>
			public static readonly XrmFakedRelationship TransactionCurrencyBookableresource = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "transactioncurrencyid",
					Entity2Attribute = "transactioncurrencyid",
					Entity1LogicalName = "transactioncurrency",
					Entity2LogicalName = "bookableresource",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N TransactionCurrency_bookableresourcebooking</summary>
			public static readonly XrmFakedRelationship TransactionCurrencyBookableresourcebooking = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "transactioncurrencyid",
					Entity2Attribute = "transactioncurrencyid",
					Entity1LogicalName = "transactioncurrency",
					Entity2LogicalName = "bookableresourcebooking",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N TransactionCurrency_bookableresourcebookingheader</summary>
			public static readonly XrmFakedRelationship TransactionCurrencyBookableresourcebookingheader = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "transactioncurrencyid",
					Entity2Attribute = "transactioncurrencyid",
					Entity1LogicalName = "transactioncurrency",
					Entity2LogicalName = "bookableresourcebookingheader",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N TransactionCurrency_bookableresourcecategory</summary>
			public static readonly XrmFakedRelationship TransactionCurrencyBookableresourcecategory = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "transactioncurrencyid",
					Entity2Attribute = "transactioncurrencyid",
					Entity1LogicalName = "transactioncurrency",
					Entity2LogicalName = "bookableresourcecategory",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N TransactionCurrency_bookableresourcecategoryassn</summary>
			public static readonly XrmFakedRelationship TransactionCurrencyBookableresourcecategoryassn = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "transactioncurrencyid",
					Entity2Attribute = "transactioncurrencyid",
					Entity1LogicalName = "transactioncurrency",
					Entity2LogicalName = "bookableresourcecategoryassn",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N TransactionCurrency_bookableresourcecharacteristic</summary>
			public static readonly XrmFakedRelationship TransactionCurrencyBookableresourcecharacteristic = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "transactioncurrencyid",
					Entity2Attribute = "transactioncurrencyid",
					Entity1LogicalName = "transactioncurrency",
					Entity2LogicalName = "bookableresourcecharacteristic",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N TransactionCurrency_bookableresourcegroup</summary>
			public static readonly XrmFakedRelationship TransactionCurrencyBookableresourcegroup = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "transactioncurrencyid",
					Entity2Attribute = "transactioncurrencyid",
					Entity1LogicalName = "transactioncurrency",
					Entity2LogicalName = "bookableresourcegroup",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N TransactionCurrency_bookingstatus</summary>
			public static readonly XrmFakedRelationship TransactionCurrencyBookingstatus = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "transactioncurrencyid",
					Entity2Attribute = "transactioncurrencyid",
					Entity1LogicalName = "transactioncurrency",
					Entity2LogicalName = "bookingstatus",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N TransactionCurrency_BusinessUnit</summary>
			public static readonly XrmFakedRelationship TransactionCurrencyBusinessUnit = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "transactioncurrencyid",
					Entity2Attribute = "transactioncurrencyid",
					Entity1LogicalName = "transactioncurrency",
					Entity2LogicalName = "businessunit",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N transactioncurrency_campaign</summary>
			public static readonly XrmFakedRelationship TransactioncurrencyCampaign = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "transactioncurrencyid",
					Entity2Attribute = "transactioncurrencyid",
					Entity1LogicalName = "transactioncurrency",
					Entity2LogicalName = "campaign",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N transactioncurrency_campaignactivity</summary>
			public static readonly XrmFakedRelationship TransactioncurrencyCampaignactivity = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "transactioncurrencyid",
					Entity2Attribute = "transactioncurrencyid",
					Entity1LogicalName = "transactioncurrency",
					Entity2LogicalName = "campaignactivity",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N TransactionCurrency_CampaignResponse</summary>
			public static readonly XrmFakedRelationship TransactionCurrencyCampaignResponse = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "transactioncurrencyid",
					Entity2Attribute = "transactioncurrencyid",
					Entity1LogicalName = "transactioncurrency",
					Entity2LogicalName = "campaignresponse",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N transactioncurrency_category</summary>
			public static readonly XrmFakedRelationship TransactioncurrencyCategory = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "transactioncurrencyid",
					Entity2Attribute = "transactioncurrencyid",
					Entity1LogicalName = "transactioncurrency",
					Entity2LogicalName = "category",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N TransactionCurrency_characteristic</summary>
			public static readonly XrmFakedRelationship TransactionCurrencyCharacteristic = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "transactioncurrencyid",
					Entity2Attribute = "transactioncurrencyid",
					Entity1LogicalName = "transactioncurrency",
					Entity2LogicalName = "characteristic",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N transactioncurrency_competitor</summary>
			public static readonly XrmFakedRelationship TransactioncurrencyCompetitor = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "transactioncurrencyid",
					Entity2Attribute = "transactioncurrencyid",
					Entity1LogicalName = "transactioncurrency",
					Entity2LogicalName = "competitor",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N TransactionCurrency_Connection</summary>
			public static readonly XrmFakedRelationship TransactionCurrencyConnection = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "transactioncurrencyid",
					Entity2Attribute = "transactioncurrencyid",
					Entity1LogicalName = "transactioncurrency",
					Entity2LogicalName = "connection",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N transactioncurrency_contact</summary>
			public static readonly XrmFakedRelationship TransactioncurrencyContact = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "transactioncurrencyid",
					Entity2Attribute = "transactioncurrencyid",
					Entity1LogicalName = "transactioncurrency",
					Entity2LogicalName = "contact",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N transactioncurrency_contract</summary>
			public static readonly XrmFakedRelationship TransactioncurrencyContract = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "transactioncurrencyid",
					Entity2Attribute = "transactioncurrencyid",
					Entity1LogicalName = "transactioncurrency",
					Entity2LogicalName = "contract",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N transactioncurrency_contractdetail</summary>
			public static readonly XrmFakedRelationship TransactioncurrencyContractdetail = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "transactioncurrencyid",
					Entity2Attribute = "transactioncurrencyid",
					Entity1LogicalName = "transactioncurrency",
					Entity2LogicalName = "contractdetail",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N TransactionCurrency_CustomerAddress</summary>
			public static readonly XrmFakedRelationship TransactionCurrencyCustomerAddress = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "transactioncurrencyid",
					Entity2Attribute = "transactioncurrencyid",
					Entity1LogicalName = "transactioncurrency",
					Entity2LogicalName = "customeraddress",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N transactioncurrency_discount</summary>
			public static readonly XrmFakedRelationship TransactioncurrencyDiscount = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "transactioncurrencyid",
					Entity2Attribute = "transactioncurrencyid",
					Entity1LogicalName = "transactioncurrency",
					Entity2LogicalName = "discount",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N transactioncurrency_discounttype</summary>
			public static readonly XrmFakedRelationship TransactioncurrencyDiscounttype = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "transactioncurrencyid",
					Entity2Attribute = "transactioncurrencyid",
					Entity1LogicalName = "transactioncurrency",
					Entity2LogicalName = "discounttype",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N TransactionCurrency_DuplicateBaseRecord</summary>
			public static readonly XrmFakedRelationship TransactionCurrencyDuplicateBaseRecord = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "transactioncurrencyid",
					Entity2Attribute = "baserecordid",
					Entity1LogicalName = "transactioncurrency",
					Entity2LogicalName = "duplicaterecord",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N TransactionCurrency_DuplicateMatchingRecord</summary>
			public static readonly XrmFakedRelationship TransactionCurrencyDuplicateMatchingRecord = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "transactioncurrencyid",
					Entity2Attribute = "duplicaterecordid",
					Entity1LogicalName = "transactioncurrency",
					Entity2LogicalName = "duplicaterecord",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N TransactionCurrency_Dynamicpropertyinsatance</summary>
			public static readonly XrmFakedRelationship TransactionCurrencyDynamicpropertyinsatance = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "transactioncurrencyid",
					Entity2Attribute = "dynamicpropertyinstanceid",
					Entity1LogicalName = "transactioncurrency",
					Entity2LogicalName = "dynamicpropertyinstance",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N TransactionCurrency_Email</summary>
			public static readonly XrmFakedRelationship TransactionCurrencyEmail = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "transactioncurrencyid",
					Entity2Attribute = "transactioncurrencyid",
					Entity1LogicalName = "transactioncurrency",
					Entity2LogicalName = "email",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N TransactionCurrency_Entitlement</summary>
			public static readonly XrmFakedRelationship TransactionCurrencyEntitlement = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "transactioncurrencyid",
					Entity2Attribute = "transactioncurrencyid",
					Entity1LogicalName = "transactioncurrency",
					Entity2LogicalName = "entitlement",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N TransactionCurrency_entitlementchannel</summary>
			public static readonly XrmFakedRelationship TransactionCurrencyEntitlementchannel = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "transactioncurrencyid",
					Entity2Attribute = "transactioncurrencyid",
					Entity1LogicalName = "transactioncurrency",
					Entity2LogicalName = "entitlementchannel",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N TransactionCurrency_entitlementtemplate</summary>
			public static readonly XrmFakedRelationship TransactionCurrencyEntitlementtemplate = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "transactioncurrencyid",
					Entity2Attribute = "transactioncurrencyid",
					Entity1LogicalName = "transactioncurrency",
					Entity2LogicalName = "entitlementtemplate",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N TransactionCurrency_entitlementtemplatechannel</summary>
			public static readonly XrmFakedRelationship TransactionCurrencyEntitlementtemplatechannel = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "transactioncurrencyid",
					Entity2Attribute = "transactioncurrencyid",
					Entity1LogicalName = "transactioncurrency",
					Entity2LogicalName = "entitlementtemplatechannel",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N TransactionCurrency_Equipment</summary>
			public static readonly XrmFakedRelationship TransactionCurrencyEquipment = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "transactioncurrencyid",
					Entity2Attribute = "transactioncurrencyid",
					Entity1LogicalName = "transactioncurrency",
					Entity2LogicalName = "equipment",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N transactioncurrency_expiredprocess</summary>
			public static readonly XrmFakedRelationship TransactioncurrencyExpiredprocess = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "transactioncurrencyid",
					Entity2Attribute = "transactioncurrencyid",
					Entity1LogicalName = "transactioncurrency",
					Entity2LogicalName = "expiredprocess",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N TransactionCurrency_Fax</summary>
			public static readonly XrmFakedRelationship TransactionCurrencyFax = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "transactioncurrencyid",
					Entity2Attribute = "transactioncurrencyid",
					Entity1LogicalName = "transactioncurrency",
					Entity2LogicalName = "fax",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N transactioncurrency_feedback</summary>
			public static readonly XrmFakedRelationship TransactioncurrencyFeedback = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "transactioncurrencyid",
					Entity2Attribute = "transactioncurrencyid",
					Entity1LogicalName = "transactioncurrency",
					Entity2LogicalName = "feedback",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N transactioncurrency_fixedmonthlyfiscalcalendar</summary>
			public static readonly XrmFakedRelationship TransactioncurrencyFixedmonthlyfiscalcalendar = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "transactioncurrencyid",
					Entity2Attribute = "transactioncurrencyid",
					Entity1LogicalName = "transactioncurrency",
					Entity2LogicalName = "fixedmonthlyfiscalcalendar",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N TransactionCurrency_Goal</summary>
			public static readonly XrmFakedRelationship TransactionCurrencyGoal = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "transactioncurrencyid",
					Entity2Attribute = "transactioncurrencyid",
					Entity1LogicalName = "transactioncurrency",
					Entity2LogicalName = "goal",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N TransactionCurrency_Incident</summary>
			public static readonly XrmFakedRelationship TransactionCurrencyIncident = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "transactioncurrencyid",
					Entity2Attribute = "transactioncurrencyid",
					Entity1LogicalName = "transactioncurrency",
					Entity2LogicalName = "incident",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N TransactionCurrency_InteractionForEmail</summary>
			public static readonly XrmFakedRelationship TransactionCurrencyInteractionForEmail = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "transactioncurrencyid",
					Entity2Attribute = "transactioncurrencyid",
					Entity1LogicalName = "transactioncurrency",
					Entity2LogicalName = "interactionforemail",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N transactioncurrency_invoice</summary>
			public static readonly XrmFakedRelationship TransactioncurrencyInvoice = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "transactioncurrencyid",
					Entity2Attribute = "transactioncurrencyid",
					Entity1LogicalName = "transactioncurrency",
					Entity2LogicalName = "invoice",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N transactioncurrency_invoicedetail</summary>
			public static readonly XrmFakedRelationship TransactioncurrencyInvoicedetail = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "transactioncurrencyid",
					Entity2Attribute = "transactioncurrencyid",
					Entity1LogicalName = "transactioncurrency",
					Entity2LogicalName = "invoicedetail",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N TransactionCurrency_KbArticle</summary>
			public static readonly XrmFakedRelationship TransactionCurrencyKbArticle = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "transactioncurrencyid",
					Entity2Attribute = "transactioncurrencyid",
					Entity1LogicalName = "transactioncurrency",
					Entity2LogicalName = "kbarticle",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N TransactionCurrency_knowledgearticle</summary>
			public static readonly XrmFakedRelationship TransactionCurrencyKnowledgearticle = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "transactioncurrencyid",
					Entity2Attribute = "transactioncurrencyid",
					Entity1LogicalName = "transactioncurrency",
					Entity2LogicalName = "knowledgearticle",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N transactioncurrency_knowledgearticleincident</summary>
			public static readonly XrmFakedRelationship TransactioncurrencyKnowledgearticleincident = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "transactioncurrencyid",
					Entity2Attribute = "transactioncurrencyid",
					Entity1LogicalName = "transactioncurrency",
					Entity2LogicalName = "knowledgearticleincident",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N transactioncurrency_knowledgearticleviews</summary>
			public static readonly XrmFakedRelationship TransactioncurrencyKnowledgearticleviews = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "transactioncurrencyid",
					Entity2Attribute = "transactioncurrencyid",
					Entity1LogicalName = "transactioncurrency",
					Entity2LogicalName = "knowledgearticleviews",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N TransactionCurrency_KnowledgeBaseRecord</summary>
			public static readonly XrmFakedRelationship TransactionCurrencyKnowledgeBaseRecord = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "transactioncurrencyid",
					Entity2Attribute = "transactioncurrencyid",
					Entity1LogicalName = "transactioncurrency",
					Entity2LogicalName = "knowledgebaserecord",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N transactioncurrency_lead</summary>
			public static readonly XrmFakedRelationship TransactioncurrencyLead = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "transactioncurrencyid",
					Entity2Attribute = "transactioncurrencyid",
					Entity1LogicalName = "transactioncurrency",
					Entity2LogicalName = "lead",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N TransactionCurrency_LeadAddress</summary>
			public static readonly XrmFakedRelationship TransactionCurrencyLeadAddress = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "transactioncurrencyid",
					Entity2Attribute = "transactioncurrencyid",
					Entity1LogicalName = "transactioncurrency",
					Entity2LogicalName = "leadaddress",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N transactioncurrency_leadtoopportunitysalesprocess</summary>
			public static readonly XrmFakedRelationship TransactioncurrencyLeadtoopportunitysalesprocess = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "transactioncurrencyid",
					Entity2Attribute = "transactioncurrencyid",
					Entity1LogicalName = "transactioncurrency",
					Entity2LogicalName = "leadtoopportunitysalesprocess",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N TransactionCurrency_Letter</summary>
			public static readonly XrmFakedRelationship TransactionCurrencyLetter = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "transactioncurrencyid",
					Entity2Attribute = "transactioncurrencyid",
					Entity1LogicalName = "transactioncurrency",
					Entity2LogicalName = "letter",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N transactioncurrency_list</summary>
			public static readonly XrmFakedRelationship TransactioncurrencyList = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "transactioncurrencyid",
					Entity2Attribute = "transactioncurrencyid",
					Entity1LogicalName = "transactioncurrency",
					Entity2LogicalName = "list",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N TransactionCurrency_MailMergeTemplate</summary>
			public static readonly XrmFakedRelationship TransactionCurrencyMailMergeTemplate = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "transactioncurrencyid",
					Entity2Attribute = "transactioncurrencyid",
					Entity1LogicalName = "transactioncurrency",
					Entity2LogicalName = "mailmergetemplate",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N transactioncurrency_monthlyfiscalcalendar</summary>
			public static readonly XrmFakedRelationship TransactioncurrencyMonthlyfiscalcalendar = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "transactioncurrencyid",
					Entity2Attribute = "transactioncurrencyid",
					Entity1LogicalName = "transactioncurrency",
					Entity2LogicalName = "monthlyfiscalcalendar",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N transactioncurrency_newprocess</summary>
			public static readonly XrmFakedRelationship TransactioncurrencyNewprocess = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "transactioncurrencyid",
					Entity2Attribute = "transactioncurrencyid",
					Entity1LogicalName = "transactioncurrency",
					Entity2LogicalName = "newprocess",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N TransactionCurrency_officegraphdocument</summary>
			public static readonly XrmFakedRelationship TransactionCurrencyOfficegraphdocument = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "transactioncurrencyid",
					Entity2Attribute = "transactioncurrencyid",
					Entity1LogicalName = "transactioncurrency",
					Entity2LogicalName = "officegraphdocument",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N transactioncurrency_opportunity</summary>
			public static readonly XrmFakedRelationship TransactioncurrencyOpportunity = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "transactioncurrencyid",
					Entity2Attribute = "transactioncurrencyid",
					Entity1LogicalName = "transactioncurrency",
					Entity2LogicalName = "opportunity",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N transactioncurrency_opportunityclose</summary>
			public static readonly XrmFakedRelationship TransactioncurrencyOpportunityclose = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "transactioncurrencyid",
					Entity2Attribute = "transactioncurrencyid",
					Entity1LogicalName = "transactioncurrency",
					Entity2LogicalName = "opportunityclose",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N transactioncurrency_opportunityproduct</summary>
			public static readonly XrmFakedRelationship TransactioncurrencyOpportunityproduct = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "transactioncurrencyid",
					Entity2Attribute = "transactioncurrencyid",
					Entity1LogicalName = "transactioncurrency",
					Entity2LogicalName = "opportunityproduct",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N transactioncurrency_opportunitysalesprocess</summary>
			public static readonly XrmFakedRelationship TransactioncurrencyOpportunitysalesprocess = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "transactioncurrencyid",
					Entity2Attribute = "transactioncurrencyid",
					Entity1LogicalName = "transactioncurrency",
					Entity2LogicalName = "opportunitysalesprocess",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N TransactionCurrency_PhoneCall</summary>
			public static readonly XrmFakedRelationship TransactionCurrencyPhoneCall = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "transactioncurrencyid",
					Entity2Attribute = "transactioncurrencyid",
					Entity1LogicalName = "transactioncurrency",
					Entity2LogicalName = "phonecall",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N transactioncurrency_phonetocaseprocess</summary>
			public static readonly XrmFakedRelationship TransactioncurrencyPhonetocaseprocess = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "transactioncurrencyid",
					Entity2Attribute = "transactioncurrencyid",
					Entity1LogicalName = "transactioncurrency",
					Entity2LogicalName = "phonetocaseprocess",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N transactioncurrency_position</summary>
			public static readonly XrmFakedRelationship TransactioncurrencyPosition = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "transactioncurrencyid",
					Entity2Attribute = "transactioncurrencyid",
					Entity1LogicalName = "transactioncurrency",
					Entity2LogicalName = "position",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N transactioncurrency_pricelevel</summary>
			public static readonly XrmFakedRelationship TransactioncurrencyPricelevel = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "transactioncurrencyid",
					Entity2Attribute = "transactioncurrencyid",
					Entity1LogicalName = "transactioncurrency",
					Entity2LogicalName = "pricelevel",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N TransactionCurrency_ProcessSessions</summary>
			public static readonly XrmFakedRelationship TransactionCurrencyProcessSessions = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "transactioncurrencyid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "transactioncurrency",
					Entity2LogicalName = "processsession",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N transactioncurrency_product</summary>
			public static readonly XrmFakedRelationship TransactioncurrencyProduct = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "transactioncurrencyid",
					Entity2Attribute = "transactioncurrencyid",
					Entity1LogicalName = "transactioncurrency",
					Entity2LogicalName = "product",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N transactioncurrency_ProductAssociation</summary>
			public static readonly XrmFakedRelationship TransactioncurrencyProductAssociation = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "transactioncurrencyid",
					Entity2Attribute = "transactioncurrencyid",
					Entity1LogicalName = "transactioncurrency",
					Entity2LogicalName = "productassociation",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N transactioncurrency_productpricelevel</summary>
			public static readonly XrmFakedRelationship TransactioncurrencyProductpricelevel = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "transactioncurrencyid",
					Entity2Attribute = "transactioncurrencyid",
					Entity1LogicalName = "transactioncurrency",
					Entity2LogicalName = "productpricelevel",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N transactioncurrency_ProductSubstitute</summary>
			public static readonly XrmFakedRelationship TransactioncurrencyProductSubstitute = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "transactioncurrencyid",
					Entity2Attribute = "transactioncurrencyid",
					Entity1LogicalName = "transactioncurrency",
					Entity2LogicalName = "productsubstitute",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N transactioncurrency_quarterlyfiscalcalendar</summary>
			public static readonly XrmFakedRelationship TransactioncurrencyQuarterlyfiscalcalendar = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "transactioncurrencyid",
					Entity2Attribute = "transactioncurrencyid",
					Entity1LogicalName = "transactioncurrency",
					Entity2LogicalName = "quarterlyfiscalcalendar",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N TransactionCurrency_Queue</summary>
			public static readonly XrmFakedRelationship TransactionCurrencyQueue = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "transactioncurrencyid",
					Entity2Attribute = "transactioncurrencyid",
					Entity1LogicalName = "transactioncurrency",
					Entity2LogicalName = "queue",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N TransactionCurrency_QueueItem</summary>
			public static readonly XrmFakedRelationship TransactionCurrencyQueueItem = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "transactioncurrencyid",
					Entity2Attribute = "transactioncurrencyid",
					Entity1LogicalName = "transactioncurrency",
					Entity2LogicalName = "queueitem",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N transactioncurrency_quote</summary>
			public static readonly XrmFakedRelationship TransactioncurrencyQuote = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "transactioncurrencyid",
					Entity2Attribute = "transactioncurrencyid",
					Entity1LogicalName = "transactioncurrency",
					Entity2LogicalName = "quote",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N transactioncurrency_quotedetail</summary>
			public static readonly XrmFakedRelationship TransactioncurrencyQuotedetail = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "transactioncurrencyid",
					Entity2Attribute = "transactioncurrencyid",
					Entity1LogicalName = "transactioncurrency",
					Entity2LogicalName = "quotedetail",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N TransactionCurrency_ratingmodel</summary>
			public static readonly XrmFakedRelationship TransactionCurrencyRatingmodel = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "transactioncurrencyid",
					Entity2Attribute = "transactioncurrencyid",
					Entity1LogicalName = "transactioncurrency",
					Entity2LogicalName = "ratingmodel",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N TransactionCurrency_ratingvalue</summary>
			public static readonly XrmFakedRelationship TransactionCurrencyRatingvalue = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "transactioncurrencyid",
					Entity2Attribute = "transactioncurrencyid",
					Entity1LogicalName = "transactioncurrency",
					Entity2LogicalName = "ratingvalue",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N TransactionCurrency_recommendeddocument</summary>
			public static readonly XrmFakedRelationship TransactionCurrencyRecommendeddocument = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "transactioncurrencyid",
					Entity2Attribute = "transactioncurrencyid",
					Entity1LogicalName = "transactioncurrency",
					Entity2LogicalName = "recommendeddocument",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N TransactionCurrency_RecurringAppointmentMaster</summary>
			public static readonly XrmFakedRelationship TransactionCurrencyRecurringAppointmentMaster = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "transactioncurrencyid",
					Entity2Attribute = "transactioncurrencyid",
					Entity1LogicalName = "transactioncurrency",
					Entity2LogicalName = "recurringappointmentmaster",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N TransactionCurrency_ReportCategory</summary>
			public static readonly XrmFakedRelationship TransactionCurrencyReportCategory = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "transactioncurrencyid",
					Entity2Attribute = "transactioncurrencyid",
					Entity1LogicalName = "transactioncurrency",
					Entity2LogicalName = "reportcategory",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N TransactionCurrency_SalesLiterature</summary>
			public static readonly XrmFakedRelationship TransactionCurrencySalesLiterature = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "transactioncurrencyid",
					Entity2Attribute = "transactioncurrencyid",
					Entity1LogicalName = "transactioncurrency",
					Entity2LogicalName = "salesliterature",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N transactioncurrency_salesorder</summary>
			public static readonly XrmFakedRelationship TransactioncurrencySalesorder = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "transactioncurrencyid",
					Entity2Attribute = "transactioncurrencyid",
					Entity1LogicalName = "transactioncurrency",
					Entity2LogicalName = "salesorder",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N transactioncurrency_salesorderdetail</summary>
			public static readonly XrmFakedRelationship TransactioncurrencySalesorderdetail = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "transactioncurrencyid",
					Entity2Attribute = "transactioncurrencyid",
					Entity1LogicalName = "transactioncurrency",
					Entity2LogicalName = "salesorderdetail",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N transactioncurrency_semiannualfiscalcalendar</summary>
			public static readonly XrmFakedRelationship TransactioncurrencySemiannualfiscalcalendar = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "transactioncurrencyid",
					Entity2Attribute = "transactioncurrencyid",
					Entity1LogicalName = "transactioncurrency",
					Entity2LogicalName = "semiannualfiscalcalendar",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N TransactionCurrency_ServiceAppointment</summary>
			public static readonly XrmFakedRelationship TransactionCurrencyServiceAppointment = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "transactioncurrencyid",
					Entity2Attribute = "transactioncurrencyid",
					Entity1LogicalName = "transactioncurrency",
					Entity2LogicalName = "serviceappointment",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N TransactionCurrency_SharePointDocumentLocation</summary>
			public static readonly XrmFakedRelationship TransactionCurrencySharePointDocumentLocation = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "transactioncurrencyid",
					Entity2Attribute = "transactioncurrencyid",
					Entity1LogicalName = "transactioncurrency",
					Entity2LogicalName = "sharepointdocumentlocation",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N TransactionCurrency_SharePointSite</summary>
			public static readonly XrmFakedRelationship TransactionCurrencySharePointSite = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "transactioncurrencyid",
					Entity2Attribute = "transactioncurrencyid",
					Entity1LogicalName = "transactioncurrency",
					Entity2LogicalName = "sharepointsite",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N TransactionCurrency_SLA</summary>
			public static readonly XrmFakedRelationship TransactionCurrencySLA = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "transactioncurrencyid",
					Entity2Attribute = "transactioncurrencyid",
					Entity1LogicalName = "transactioncurrency",
					Entity2LogicalName = "sla",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N TransactionCurrency_SLAItem</summary>
			public static readonly XrmFakedRelationship TransactionCurrencySLAItem = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "transactioncurrencyid",
					Entity2Attribute = "transactioncurrencyid",
					Entity1LogicalName = "transactioncurrency",
					Entity2LogicalName = "slaitem",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N TransactionCurrency_slakpiinstance</summary>
			public static readonly XrmFakedRelationship TransactionCurrencySlakpiinstance = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "transactioncurrencyid",
					Entity2Attribute = "transactioncurrencyid",
					Entity1LogicalName = "transactioncurrency",
					Entity2LogicalName = "slakpiinstance",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N transactioncurrency_socialactivity</summary>
			public static readonly XrmFakedRelationship TransactioncurrencySocialactivity = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "transactioncurrencyid",
					Entity2Attribute = "transactioncurrencyid",
					Entity1LogicalName = "transactioncurrency",
					Entity2LogicalName = "socialactivity",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N transactioncurrency_SocialProfile</summary>
			public static readonly XrmFakedRelationship TransactioncurrencySocialProfile = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "transactioncurrencyid",
					Entity2Attribute = "transactioncurrencyid",
					Entity1LogicalName = "transactioncurrency",
					Entity2LogicalName = "socialprofile",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N TransactionCurrency_SyncErrors</summary>
			public static readonly XrmFakedRelationship TransactionCurrencySyncErrors = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "transactioncurrencyid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "transactioncurrency",
					Entity2LogicalName = "syncerror",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N TransactionCurrency_SystemUser</summary>
			public static readonly XrmFakedRelationship TransactionCurrencySystemUser = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "transactioncurrencyid",
					Entity2Attribute = "transactioncurrencyid",
					Entity1LogicalName = "transactioncurrency",
					Entity2LogicalName = "systemuser",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N TransactionCurrency_Task</summary>
			public static readonly XrmFakedRelationship TransactionCurrencyTask = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "transactioncurrencyid",
					Entity2Attribute = "transactioncurrencyid",
					Entity1LogicalName = "transactioncurrency",
					Entity2LogicalName = "task",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N TransactionCurrency_Team</summary>
			public static readonly XrmFakedRelationship TransactionCurrencyTeam = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "transactioncurrencyid",
					Entity2Attribute = "transactioncurrencyid",
					Entity1LogicalName = "transactioncurrency",
					Entity2LogicalName = "team",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N TransactionCurrency_Territory</summary>
			public static readonly XrmFakedRelationship TransactionCurrencyTerritory = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "transactioncurrencyid",
					Entity2Attribute = "transactioncurrencyid",
					Entity1LogicalName = "transactioncurrency",
					Entity2LogicalName = "territory",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N TransactionCurrency_Theme</summary>
			public static readonly XrmFakedRelationship TransactionCurrencyTheme = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "transactioncurrencyid",
					Entity2Attribute = "transactioncurrencyid",
					Entity1LogicalName = "transactioncurrency",
					Entity2LogicalName = "theme",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N transactioncurrency_translationprocess</summary>
			public static readonly XrmFakedRelationship TransactioncurrencyTranslationprocess = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "transactioncurrencyid",
					Entity2Attribute = "transactioncurrencyid",
					Entity1LogicalName = "transactioncurrency",
					Entity2LogicalName = "translationprocess",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N TransactionCurrency_UserMapping</summary>
			public static readonly XrmFakedRelationship TransactionCurrencyUserMapping = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "transactioncurrencyid",
					Entity2Attribute = "transactioncurrencyid",
					Entity1LogicalName = "transactioncurrency",
					Entity2LogicalName = "usermapping",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N transactioncurrency_usersettings</summary>
			public static readonly XrmFakedRelationship TransactioncurrencyUsersettings = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "transactioncurrencyid",
					Entity2Attribute = "transactioncurrencyid",
					Entity1LogicalName = "transactioncurrency",
					Entity2LogicalName = "usersettings",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

		}
		#endregion

		#region Fake
		public static Currency Create()
		{
			var faker = new Faker<Currency>()
			.RuleFor(e => e.Createdbyname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Createdbyyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.CreatedOn, fake => fake.Date.Soon())
			.RuleFor(e => e.Createdonbehalfbyname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Createdonbehalfbyyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.CurrencyName, fake => fake.Lorem.Word())
			.RuleFor(e => e.CurrencyPrecision, fake => fake.Random.Int())
			.RuleFor(e => e.CurrencySymbol, fake => fake.Lorem.Word())
			.RuleFor(e => e.EntityimageTimestamp, fake => fake.Random.Int())
			.RuleFor(e => e.EntityimageUrl, fake => fake.Lorem.Word())
			.RuleFor(e => e.EntityImageId, fake => Guid.NewGuid())
			.RuleFor(e => e.ExchangeRate, fake => fake.Finance.Amount())
			.RuleFor(e => e.ImportSequenceNumber, fake => fake.Random.Int())
			.RuleFor(e => e.CurrencyCode, fake => fake.Lorem.Word())
			.RuleFor(e => e.Modifiedbyname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Modifiedbyyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.ModifiedOn, fake => fake.Date.Soon())
			.RuleFor(e => e.Modifiedonbehalfbyname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Modifiedonbehalfbyyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.RecordCreatedOn, fake => fake.Date.Soon())
			.RuleFor(e => e.Status, fake => fake.PickRandom<Currency.eStatus>())
			.RuleFor(e => e.StatusReason, fake => fake.PickRandom<Currency.eStatusReason>())
			.RuleFor(e => e.Id, fake => Guid.NewGuid())
			.RuleFor(e => e.UniqueDscId, fake => Guid.NewGuid())
			.RuleFor(e => e.VersionNumber, fake => fake.Random.Int());
			return faker.Generate();
		}
		#endregion
	}
}

