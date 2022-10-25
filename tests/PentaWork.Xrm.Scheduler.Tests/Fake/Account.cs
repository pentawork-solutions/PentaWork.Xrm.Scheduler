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
			/// <summary>1:N account_actioncard</summary>
			public static readonly XrmFakedRelationship AccountActioncard = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "accountid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "account",
					Entity2LogicalName = "actioncard",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

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

			/// <summary>1:N Account_ActivityPointers</summary>
			public static readonly XrmFakedRelationship AccountActivityPointers = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "accountid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "account",
					Entity2LogicalName = "activitypointer",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N Account_Annotation</summary>
			public static readonly XrmFakedRelationship AccountAnnotation = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "accountid",
					Entity2Attribute = "objectid",
					Entity1LogicalName = "account",
					Entity2LogicalName = "annotation",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N Account_Appointments</summary>
			public static readonly XrmFakedRelationship AccountAppointments = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "accountid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "account",
					Entity2LogicalName = "appointment",
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

			/// <summary>1:N account_bookableresource_AccountId</summary>
			public static readonly XrmFakedRelationship AccountBookableresourceAccountId = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "accountid",
					Entity2Attribute = "accountid",
					Entity1LogicalName = "account",
					Entity2LogicalName = "bookableresource",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N Account_BulkDeleteFailures</summary>
			public static readonly XrmFakedRelationship AccountBulkDeleteFailures = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "accountid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "account",
					Entity2LogicalName = "bulkdeletefailure",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N account_BulkOperations</summary>
			public static readonly XrmFakedRelationship AccountBulkOperations = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "accountid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "account",
					Entity2LogicalName = "bulkoperation",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N account_CampaignResponses</summary>
			public static readonly XrmFakedRelationship AccountCampaignResponses = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "accountid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "account",
					Entity2LogicalName = "campaignresponse",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N account_connections1</summary>
			public static readonly XrmFakedRelationship AccountConnections1 = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "accountid",
					Entity2Attribute = "record1id",
					Entity1LogicalName = "account",
					Entity2LogicalName = "connection",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N account_connections2</summary>
			public static readonly XrmFakedRelationship AccountConnections2 = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "accountid",
					Entity2Attribute = "record2id",
					Entity1LogicalName = "account",
					Entity2LogicalName = "connection",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N Account_CustomerAddress</summary>
			public static readonly XrmFakedRelationship AccountCustomerAddress = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "accountid",
					Entity2Attribute = "parentid",
					Entity1LogicalName = "account",
					Entity2LogicalName = "customeraddress",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N Account_DuplicateBaseRecord</summary>
			public static readonly XrmFakedRelationship AccountDuplicateBaseRecord = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "accountid",
					Entity2Attribute = "baserecordid",
					Entity1LogicalName = "account",
					Entity2LogicalName = "duplicaterecord",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N Account_DuplicateMatchingRecord</summary>
			public static readonly XrmFakedRelationship AccountDuplicateMatchingRecord = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "accountid",
					Entity2Attribute = "duplicaterecordid",
					Entity1LogicalName = "account",
					Entity2LogicalName = "duplicaterecord",
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

			/// <summary>1:N account_entitlement_Account</summary>
			public static readonly XrmFakedRelationship AccountEntitlementAccount = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "accountid",
					Entity2Attribute = "accountid",
					Entity1LogicalName = "account",
					Entity2LogicalName = "entitlement",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N account_entitlement_Customer</summary>
			public static readonly XrmFakedRelationship AccountEntitlementCustomer = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "accountid",
					Entity2Attribute = "customerid",
					Entity1LogicalName = "account",
					Entity2LogicalName = "entitlement",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N Account_Faxes</summary>
			public static readonly XrmFakedRelationship AccountFaxes = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "accountid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "account",
					Entity2LogicalName = "fax",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N account_IncidentResolutions</summary>
			public static readonly XrmFakedRelationship AccountIncidentResolutions = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "accountid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "account",
					Entity2LogicalName = "incidentresolution",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N Account_Letters</summary>
			public static readonly XrmFakedRelationship AccountLetters = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "accountid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "account",
					Entity2LogicalName = "letter",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N Account_MailboxTrackingFolder</summary>
			public static readonly XrmFakedRelationship AccountMailboxTrackingFolder = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "accountid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "account",
					Entity2LogicalName = "mailboxtrackingfolder",
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

			/// <summary>1:N account_OpportunityCloses</summary>
			public static readonly XrmFakedRelationship AccountOpportunityCloses = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "accountid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "account",
					Entity2LogicalName = "opportunityclose",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N account_OrderCloses</summary>
			public static readonly XrmFakedRelationship AccountOrderCloses = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "accountid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "account",
					Entity2LogicalName = "orderclose",
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

			/// <summary>1:N Account_Phonecalls</summary>
			public static readonly XrmFakedRelationship AccountPhonecalls = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "accountid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "account",
					Entity2LogicalName = "phonecall",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N account_PostFollows</summary>
			public static readonly XrmFakedRelationship AccountPostFollows = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "accountid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "account",
					Entity2LogicalName = "postfollow",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N account_principalobjectattributeaccess</summary>
			public static readonly XrmFakedRelationship AccountPrincipalobjectattributeaccess = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "accountid",
					Entity2Attribute = "objectid",
					Entity1LogicalName = "account",
					Entity2LogicalName = "principalobjectattributeaccess",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N Account_ProcessSessions</summary>
			public static readonly XrmFakedRelationship AccountProcessSessions = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "accountid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "account",
					Entity2LogicalName = "processsession",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N account_QuoteCloses</summary>
			public static readonly XrmFakedRelationship AccountQuoteCloses = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "accountid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "account",
					Entity2LogicalName = "quoteclose",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N Account_RecurringAppointmentMasters</summary>
			public static readonly XrmFakedRelationship AccountRecurringAppointmentMasters = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "accountid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "account",
					Entity2LogicalName = "recurringappointmentmaster",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N Account_ServiceAppointments</summary>
			public static readonly XrmFakedRelationship AccountServiceAppointments = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "accountid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "account",
					Entity2LogicalName = "serviceappointment",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N Account_SharepointDocumentLocation</summary>
			public static readonly XrmFakedRelationship AccountSharepointDocumentLocation = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "accountid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "account",
					Entity2LogicalName = "sharepointdocumentlocation",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N Account_SocialActivities</summary>
			public static readonly XrmFakedRelationship AccountSocialActivities = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "accountid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "account",
					Entity2LogicalName = "socialactivity",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N Account_SyncErrors</summary>
			public static readonly XrmFakedRelationship AccountSyncErrors = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "accountid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "account",
					Entity2LogicalName = "syncerror",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N Account_Tasks</summary>
			public static readonly XrmFakedRelationship AccountTasks = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "accountid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "account",
					Entity2LogicalName = "task",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N contact_customer_accounts</summary>
			public static readonly XrmFakedRelationship ContactCustomerAccounts = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "accountid",
					Entity2Attribute = "parentcustomerid",
					Entity1LogicalName = "account",
					Entity2LogicalName = "contact",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N contract_billingcustomer_accounts</summary>
			public static readonly XrmFakedRelationship ContractBillingcustomerAccounts = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "accountid",
					Entity2Attribute = "billingcustomerid",
					Entity1LogicalName = "account",
					Entity2LogicalName = "contract",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N contract_customer_accounts</summary>
			public static readonly XrmFakedRelationship ContractCustomerAccounts = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "accountid",
					Entity2Attribute = "customerid",
					Entity1LogicalName = "account",
					Entity2LogicalName = "contract",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N contractlineitem_customer_accounts</summary>
			public static readonly XrmFakedRelationship ContractlineitemCustomerAccounts = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "accountid",
					Entity2Attribute = "customerid",
					Entity1LogicalName = "account",
					Entity2LogicalName = "contractdetail",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N incident_customer_accounts</summary>
			public static readonly XrmFakedRelationship IncidentCustomerAccounts = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "accountid",
					Entity2Attribute = "customerid",
					Entity1LogicalName = "account",
					Entity2LogicalName = "incident",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N invoice_customer_accounts</summary>
			public static readonly XrmFakedRelationship InvoiceCustomerAccounts = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "accountid",
					Entity2Attribute = "customerid",
					Entity1LogicalName = "account",
					Entity2LogicalName = "invoice",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lead_customer_accounts</summary>
			public static readonly XrmFakedRelationship LeadCustomerAccounts = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "accountid",
					Entity2Attribute = "customerid",
					Entity1LogicalName = "account",
					Entity2LogicalName = "lead",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lead_parent_account</summary>
			public static readonly XrmFakedRelationship LeadParentAccount = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "accountid",
					Entity2Attribute = "parentaccountid",
					Entity1LogicalName = "account",
					Entity2LogicalName = "lead",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N msdyn_playbookinstance_account</summary>
			public static readonly XrmFakedRelationship MsdynPlaybookinstanceAccount = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "accountid",
					Entity2Attribute = "regarding",
					Entity1LogicalName = "account",
					Entity2LogicalName = "msdyn_playbookinstance",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N opportunity_customer_accounts</summary>
			public static readonly XrmFakedRelationship OpportunityCustomerAccounts = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "accountid",
					Entity2Attribute = "customerid",
					Entity1LogicalName = "account",
					Entity2LogicalName = "opportunity",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N opportunity_parent_account</summary>
			public static readonly XrmFakedRelationship OpportunityParentAccount = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "accountid",
					Entity2Attribute = "parentaccountid",
					Entity1LogicalName = "account",
					Entity2LogicalName = "opportunity",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N order_customer_accounts</summary>
			public static readonly XrmFakedRelationship OrderCustomerAccounts = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "accountid",
					Entity2Attribute = "customerid",
					Entity1LogicalName = "account",
					Entity2LogicalName = "salesorder",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N quote_customer_accounts</summary>
			public static readonly XrmFakedRelationship QuoteCustomerAccounts = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "accountid",
					Entity2Attribute = "customerid",
					Entity1LogicalName = "account",
					Entity2LogicalName = "quote",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N slakpiinstance_account</summary>
			public static readonly XrmFakedRelationship SlakpiinstanceAccount = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "accountid",
					Entity2Attribute = "regarding",
					Entity1LogicalName = "account",
					Entity2LogicalName = "slakpiinstance",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N SocialActivity_PostAuthor_accounts</summary>
			public static readonly XrmFakedRelationship SocialActivityPostAuthorAccounts = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "accountid",
					Entity2Attribute = "postauthor",
					Entity1LogicalName = "account",
					Entity2LogicalName = "socialactivity",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N SocialActivity_PostAuthorAccount_accounts</summary>
			public static readonly XrmFakedRelationship SocialActivityPostAuthorAccountAccounts = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "accountid",
					Entity2Attribute = "postauthoraccount",
					Entity1LogicalName = "account",
					Entity2LogicalName = "socialactivity",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N Socialprofile_customer_accounts</summary>
			public static readonly XrmFakedRelationship SocialprofileCustomerAccounts = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "accountid",
					Entity2Attribute = "customerid",
					Entity1LogicalName = "account",
					Entity2LogicalName = "socialprofile",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>N:N accountleads_association</summary>
			public static readonly XrmFakedRelationship AccountleadsAssociation = 
				new XrmFakedRelationship
				{
					IntersectEntity = "accountleads_association",
					Entity1Attribute = "leadid",
					Entity2Attribute = "accountid",
					Entity1LogicalName = "account",
					Entity2LogicalName = "lead",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.ManyToMany
				};

			/// <summary>N:N BulkOperation_Accounts</summary>
			public static readonly XrmFakedRelationship BulkOperationAccounts = 
				new XrmFakedRelationship
				{
					IntersectEntity = "BulkOperation_Accounts",
					Entity1Attribute = "bulkoperationid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "bulkoperation",
					Entity2LogicalName = "account",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.ManyToMany
				};

			/// <summary>N:N CampaignActivity_Accounts</summary>
			public static readonly XrmFakedRelationship CampaignActivityAccounts = 
				new XrmFakedRelationship
				{
					IntersectEntity = "CampaignActivity_Accounts",
					Entity1Attribute = "campaignactivityid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "campaignactivity",
					Entity2LogicalName = "account",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.ManyToMany
				};

			/// <summary>N:N listaccount_association</summary>
			public static readonly XrmFakedRelationship ListaccountAssociation = 
				new XrmFakedRelationship
				{
					IntersectEntity = "listaccount_association",
					Entity1Attribute = "listid",
					Entity2Attribute = "entityid",
					Entity1LogicalName = "list",
					Entity2LogicalName = "account",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.ManyToMany
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
			.RuleFor(e => e.Defaultpricelevelidname, fake => fake.Lorem.Word())
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
			.RuleFor(e => e.AccountName, fake => fake.Lorem.Word())
			.RuleFor(e => e.NumberOfEmployees, fake => fake.Random.Int())
			.RuleFor(e => e.OnHoldTimeMinutes, fake => fake.Random.Int())
			.RuleFor(e => e.OpenDeals, fake => fake.Random.Int())
			.RuleFor(e => e.OpenDealsLastUpdatedOn, fake => fake.Date.Soon())
			.RuleFor(e => e.OpenDealsState, fake => fake.Random.Int())
			.RuleFor(e => e.OpenRevenue, fake => fake.Finance.Amount())
			.RuleFor(e => e.OpenRevenueLastUpdatedOn, fake => fake.Date.Soon())
			.RuleFor(e => e.OpenRevenueState, fake => fake.Random.Int())
			.RuleFor(e => e.Originatingleadidname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Originatingleadidyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.RecordCreatedOn, fake => fake.Date.Soon())
			.RuleFor(e => e.Owneridname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Owneridtype, fake => fake.Lorem.Word())
			.RuleFor(e => e.Owneridyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.Ownership, fake => fake.PickRandom<Account.eOwnership>())
			.RuleFor(e => e.Parentaccountidname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Parentaccountidyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.ParticipatesInWorkflow, fake => fake.Random.Bool())
			.RuleFor(e => e.PaymentTerms, fake => fake.PickRandom<Account.ePaymentTerms>())
			.RuleFor(e => e.PreferredDay, fake => fake.PickRandom<Account.ePreferredDay>())
			.RuleFor(e => e.PreferredTime, fake => fake.PickRandom<Account.ePreferredTime>())
			.RuleFor(e => e.PreferredMethodOfContact, fake => fake.PickRandom<Account.ePreferredMethodOfContact>())
			.RuleFor(e => e.Preferredequipmentidname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Preferredserviceidname, fake => fake.Lorem.Word())
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
			.RuleFor(e => e.TeamsFollowed, fake => fake.Random.Int())
			.RuleFor(e => e.MainPhone, fake => fake.Lorem.Word())
			.RuleFor(e => e.OtherPhone, fake => fake.Lorem.Word())
			.RuleFor(e => e.Telephone3, fake => fake.Lorem.Word())
			.RuleFor(e => e.TerritoryCode, fake => fake.PickRandom<Account.eTerritoryCode>())
			.RuleFor(e => e.Territoryidname, fake => fake.Lorem.Word())
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

