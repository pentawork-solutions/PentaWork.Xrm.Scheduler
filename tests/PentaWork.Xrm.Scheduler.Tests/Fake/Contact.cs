using Bogus;
using System;
using FakeXrmEasy;
using System.Collections.Generic;
using PentaWork.Xrm.Scheduler.Proxies.Entities;

namespace PentaWork.Xrm.Scheduler.Tests.Fake
{
	public static class FakeContact
	{	
		#region FakeRelationships
		public static class Relationships 
		{
			/// <summary>1:N account_primary_contact</summary>
			public static readonly XrmFakedRelationship AccountPrimaryContact = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "contactid",
					Entity2Attribute = "primarycontactid",
					Entity1LogicalName = "contact",
					Entity2LogicalName = "account",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N contact_actioncard</summary>
			public static readonly XrmFakedRelationship ContactActioncard = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "contactid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "contact",
					Entity2LogicalName = "actioncard",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N contact_activity_parties</summary>
			public static readonly XrmFakedRelationship ContactActivityParties = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "contactid",
					Entity2Attribute = "partyid",
					Entity1LogicalName = "contact",
					Entity2LogicalName = "activityparty",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N Contact_ActivityPointers</summary>
			public static readonly XrmFakedRelationship ContactActivityPointers = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "contactid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "contact",
					Entity2LogicalName = "activitypointer",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N Contact_Annotation</summary>
			public static readonly XrmFakedRelationship ContactAnnotation = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "contactid",
					Entity2Attribute = "objectid",
					Entity1LogicalName = "contact",
					Entity2LogicalName = "annotation",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N Contact_Appointments</summary>
			public static readonly XrmFakedRelationship ContactAppointments = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "contactid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "contact",
					Entity2LogicalName = "appointment",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N contact_as_primary_contact</summary>
			public static readonly XrmFakedRelationship ContactAsPrimaryContact = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "contactid",
					Entity2Attribute = "primarycontactid",
					Entity1LogicalName = "contact",
					Entity2LogicalName = "incident",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N contact_as_responsible_contact</summary>
			public static readonly XrmFakedRelationship ContactAsResponsibleContact = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "contactid",
					Entity2Attribute = "responsiblecontactid",
					Entity1LogicalName = "contact",
					Entity2LogicalName = "incident",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N Contact_AsyncOperations</summary>
			public static readonly XrmFakedRelationship ContactAsyncOperations = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "contactid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "contact",
					Entity2LogicalName = "asyncoperation",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N contact_bookableresource_ContactId</summary>
			public static readonly XrmFakedRelationship ContactBookableresourceContactId = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "contactid",
					Entity2Attribute = "contactid",
					Entity1LogicalName = "contact",
					Entity2LogicalName = "bookableresource",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N Contact_BulkDeleteFailures</summary>
			public static readonly XrmFakedRelationship ContactBulkDeleteFailures = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "contactid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "contact",
					Entity2LogicalName = "bulkdeletefailure",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N contact_BulkOperations</summary>
			public static readonly XrmFakedRelationship ContactBulkOperations = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "contactid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "contact",
					Entity2LogicalName = "bulkoperation",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N contact_CampaignResponses</summary>
			public static readonly XrmFakedRelationship ContactCampaignResponses = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "contactid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "contact",
					Entity2LogicalName = "campaignresponse",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N contact_connections1</summary>
			public static readonly XrmFakedRelationship ContactConnections1 = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "contactid",
					Entity2Attribute = "record1id",
					Entity1LogicalName = "contact",
					Entity2LogicalName = "connection",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N contact_connections2</summary>
			public static readonly XrmFakedRelationship ContactConnections2 = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "contactid",
					Entity2Attribute = "record2id",
					Entity1LogicalName = "contact",
					Entity2LogicalName = "connection",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N contact_customer_contacts</summary>
			public static readonly XrmFakedRelationship ContactCustomerContacts = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "contactid",
					Entity2Attribute = "parentcustomerid",
					Entity1LogicalName = "contact",
					Entity2LogicalName = "contact",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N Contact_CustomerAddress</summary>
			public static readonly XrmFakedRelationship ContactCustomerAddress = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "contactid",
					Entity2Attribute = "parentid",
					Entity1LogicalName = "contact",
					Entity2LogicalName = "customeraddress",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N Contact_DuplicateBaseRecord</summary>
			public static readonly XrmFakedRelationship ContactDuplicateBaseRecord = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "contactid",
					Entity2Attribute = "baserecordid",
					Entity1LogicalName = "contact",
					Entity2LogicalName = "duplicaterecord",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N Contact_DuplicateMatchingRecord</summary>
			public static readonly XrmFakedRelationship ContactDuplicateMatchingRecord = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "contactid",
					Entity2Attribute = "duplicaterecordid",
					Entity1LogicalName = "contact",
					Entity2LogicalName = "duplicaterecord",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N Contact_Email_EmailSender</summary>
			public static readonly XrmFakedRelationship ContactEmailEmailSender = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "contactid",
					Entity2Attribute = "emailsender",
					Entity1LogicalName = "contact",
					Entity2LogicalName = "email",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N Contact_Emails</summary>
			public static readonly XrmFakedRelationship ContactEmails = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "contactid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "contact",
					Entity2LogicalName = "email",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N contact_entitlement_ContactId</summary>
			public static readonly XrmFakedRelationship ContactEntitlementContactId = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "contactid",
					Entity2Attribute = "contactid",
					Entity1LogicalName = "contact",
					Entity2LogicalName = "entitlement",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N contact_entitlement_Customer</summary>
			public static readonly XrmFakedRelationship ContactEntitlementCustomer = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "contactid",
					Entity2Attribute = "customerid",
					Entity1LogicalName = "contact",
					Entity2LogicalName = "entitlement",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N Contact_Faxes</summary>
			public static readonly XrmFakedRelationship ContactFaxes = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "contactid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "contact",
					Entity2LogicalName = "fax",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N Contact_Feedback</summary>
			public static readonly XrmFakedRelationship ContactFeedback = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "contactid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "contact",
					Entity2LogicalName = "feedback",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N Contact_Letters</summary>
			public static readonly XrmFakedRelationship ContactLetters = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "contactid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "contact",
					Entity2LogicalName = "letter",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N Contact_MailboxTrackingFolder</summary>
			public static readonly XrmFakedRelationship ContactMailboxTrackingFolder = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "contactid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "contact",
					Entity2LogicalName = "mailboxtrackingfolder",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N contact_master_contact</summary>
			public static readonly XrmFakedRelationship ContactMasterContact = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "contactid",
					Entity2Attribute = "masterid",
					Entity1LogicalName = "contact",
					Entity2LogicalName = "contact",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N Contact_Phonecalls</summary>
			public static readonly XrmFakedRelationship ContactPhonecalls = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "contactid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "contact",
					Entity2LogicalName = "phonecall",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N contact_PostFollows</summary>
			public static readonly XrmFakedRelationship ContactPostFollows = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "contactid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "contact",
					Entity2LogicalName = "postfollow",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N contact_principalobjectattributeaccess</summary>
			public static readonly XrmFakedRelationship ContactPrincipalobjectattributeaccess = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "contactid",
					Entity2Attribute = "objectid",
					Entity1LogicalName = "contact",
					Entity2LogicalName = "principalobjectattributeaccess",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N Contact_ProcessSessions</summary>
			public static readonly XrmFakedRelationship ContactProcessSessions = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "contactid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "contact",
					Entity2LogicalName = "processsession",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N Contact_RecurringAppointmentMasters</summary>
			public static readonly XrmFakedRelationship ContactRecurringAppointmentMasters = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "contactid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "contact",
					Entity2LogicalName = "recurringappointmentmaster",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N Contact_ServiceAppointments</summary>
			public static readonly XrmFakedRelationship ContactServiceAppointments = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "contactid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "contact",
					Entity2LogicalName = "serviceappointment",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N contact_SharePointDocumentLocations</summary>
			public static readonly XrmFakedRelationship ContactSharePointDocumentLocations = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "contactid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "contact",
					Entity2LogicalName = "sharepointdocumentlocation",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N Contact_SocialActivities</summary>
			public static readonly XrmFakedRelationship ContactSocialActivities = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "contactid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "contact",
					Entity2LogicalName = "socialactivity",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N Contact_SyncErrors</summary>
			public static readonly XrmFakedRelationship ContactSyncErrors = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "contactid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "contact",
					Entity2LogicalName = "syncerror",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N Contact_Tasks</summary>
			public static readonly XrmFakedRelationship ContactTasks = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "contactid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "contact",
					Entity2LogicalName = "task",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N contract_billingcustomer_contacts</summary>
			public static readonly XrmFakedRelationship ContractBillingcustomerContacts = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "contactid",
					Entity2Attribute = "billingcustomerid",
					Entity1LogicalName = "contact",
					Entity2LogicalName = "contract",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N contract_customer_contacts</summary>
			public static readonly XrmFakedRelationship ContractCustomerContacts = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "contactid",
					Entity2Attribute = "customerid",
					Entity1LogicalName = "contact",
					Entity2LogicalName = "contract",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N contractlineitem_customer_contacts</summary>
			public static readonly XrmFakedRelationship ContractlineitemCustomerContacts = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "contactid",
					Entity2Attribute = "customerid",
					Entity1LogicalName = "contact",
					Entity2LogicalName = "contractdetail",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N incident_customer_contacts</summary>
			public static readonly XrmFakedRelationship IncidentCustomerContacts = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "contactid",
					Entity2Attribute = "customerid",
					Entity1LogicalName = "contact",
					Entity2LogicalName = "incident",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N invoice_customer_contacts</summary>
			public static readonly XrmFakedRelationship InvoiceCustomerContacts = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "contactid",
					Entity2Attribute = "customerid",
					Entity1LogicalName = "contact",
					Entity2LogicalName = "invoice",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lead_customer_contacts</summary>
			public static readonly XrmFakedRelationship LeadCustomerContacts = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "contactid",
					Entity2Attribute = "customerid",
					Entity1LogicalName = "contact",
					Entity2LogicalName = "lead",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lead_parent_contact</summary>
			public static readonly XrmFakedRelationship LeadParentContact = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "contactid",
					Entity2Attribute = "parentcontactid",
					Entity1LogicalName = "contact",
					Entity2LogicalName = "lead",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_contact_feedback_createdby</summary>
			public static readonly XrmFakedRelationship LkContactFeedbackCreatedby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "contactid",
					Entity2Attribute = "createdbycontact",
					Entity1LogicalName = "contact",
					Entity2LogicalName = "feedback",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_contact_feedback_createdonbehalfby</summary>
			public static readonly XrmFakedRelationship LkContactFeedbackCreatedonbehalfby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "contactid",
					Entity2Attribute = "createdonbehalfbycontact",
					Entity1LogicalName = "contact",
					Entity2LogicalName = "feedback",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N msdyn_playbookinstance_contact</summary>
			public static readonly XrmFakedRelationship MsdynPlaybookinstanceContact = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "contactid",
					Entity2Attribute = "regarding",
					Entity1LogicalName = "contact",
					Entity2LogicalName = "msdyn_playbookinstance",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N opportunity_customer_contacts</summary>
			public static readonly XrmFakedRelationship OpportunityCustomerContacts = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "contactid",
					Entity2Attribute = "customerid",
					Entity1LogicalName = "contact",
					Entity2LogicalName = "opportunity",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N opportunity_parent_contact</summary>
			public static readonly XrmFakedRelationship OpportunityParentContact = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "contactid",
					Entity2Attribute = "parentcontactid",
					Entity1LogicalName = "contact",
					Entity2LogicalName = "opportunity",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N order_customer_contacts</summary>
			public static readonly XrmFakedRelationship OrderCustomerContacts = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "contactid",
					Entity2Attribute = "customerid",
					Entity1LogicalName = "contact",
					Entity2LogicalName = "salesorder",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N quote_customer_contacts</summary>
			public static readonly XrmFakedRelationship QuoteCustomerContacts = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "contactid",
					Entity2Attribute = "customerid",
					Entity1LogicalName = "contact",
					Entity2LogicalName = "quote",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N slakpiinstance_contact</summary>
			public static readonly XrmFakedRelationship SlakpiinstanceContact = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "contactid",
					Entity2Attribute = "regarding",
					Entity1LogicalName = "contact",
					Entity2LogicalName = "slakpiinstance",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N socialactivity_postauthor_contacts</summary>
			public static readonly XrmFakedRelationship SocialactivityPostauthorContacts = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "contactid",
					Entity2Attribute = "postauthor",
					Entity1LogicalName = "contact",
					Entity2LogicalName = "socialactivity",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N socialactivity_postauthoraccount_contacts</summary>
			public static readonly XrmFakedRelationship SocialactivityPostauthoraccountContacts = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "contactid",
					Entity2Attribute = "postauthoraccount",
					Entity1LogicalName = "contact",
					Entity2LogicalName = "socialactivity",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N Socialprofile_customer_contacts</summary>
			public static readonly XrmFakedRelationship SocialprofileCustomerContacts = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "contactid",
					Entity2Attribute = "customerid",
					Entity1LogicalName = "contact",
					Entity2LogicalName = "socialprofile",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>N:N BulkOperation_Contacts</summary>
			public static readonly XrmFakedRelationship BulkOperationContacts = 
				new XrmFakedRelationship
				{
					IntersectEntity = "BulkOperation_Contacts",
					Entity1Attribute = "bulkoperationid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "bulkoperation",
					Entity2LogicalName = "contact",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.ManyToMany
				};

			/// <summary>N:N CampaignActivity_Contacts</summary>
			public static readonly XrmFakedRelationship CampaignActivityContacts = 
				new XrmFakedRelationship
				{
					IntersectEntity = "CampaignActivity_Contacts",
					Entity1Attribute = "campaignactivityid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "campaignactivity",
					Entity2LogicalName = "contact",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.ManyToMany
				};

			/// <summary>N:N contactinvoices_association</summary>
			public static readonly XrmFakedRelationship ContactinvoicesAssociation = 
				new XrmFakedRelationship
				{
					IntersectEntity = "contactinvoices_association",
					Entity1Attribute = "invoiceid",
					Entity2Attribute = "contactid",
					Entity1LogicalName = "invoice",
					Entity2LogicalName = "contact",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.ManyToMany
				};

			/// <summary>N:N contactleads_association</summary>
			public static readonly XrmFakedRelationship ContactleadsAssociation = 
				new XrmFakedRelationship
				{
					IntersectEntity = "contactleads_association",
					Entity1Attribute = "contactid",
					Entity2Attribute = "leadid",
					Entity1LogicalName = "contact",
					Entity2LogicalName = "lead",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.ManyToMany
				};

			/// <summary>N:N contactorders_association</summary>
			public static readonly XrmFakedRelationship ContactordersAssociation = 
				new XrmFakedRelationship
				{
					IntersectEntity = "contactorders_association",
					Entity1Attribute = "salesorderid",
					Entity2Attribute = "contactid",
					Entity1LogicalName = "salesorder",
					Entity2LogicalName = "contact",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.ManyToMany
				};

			/// <summary>N:N contactquotes_association</summary>
			public static readonly XrmFakedRelationship ContactquotesAssociation = 
				new XrmFakedRelationship
				{
					IntersectEntity = "contactquotes_association",
					Entity1Attribute = "quoteid",
					Entity2Attribute = "contactid",
					Entity1LogicalName = "quote",
					Entity2LogicalName = "contact",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.ManyToMany
				};

			/// <summary>N:N entitlementcontacts_association</summary>
			public static readonly XrmFakedRelationship EntitlementcontactsAssociation = 
				new XrmFakedRelationship
				{
					IntersectEntity = "entitlementcontacts_association",
					Entity1Attribute = "contactid",
					Entity2Attribute = "entitlementid",
					Entity1LogicalName = "contact",
					Entity2LogicalName = "entitlement",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.ManyToMany
				};

			/// <summary>N:N listcontact_association</summary>
			public static readonly XrmFakedRelationship ListcontactAssociation = 
				new XrmFakedRelationship
				{
					IntersectEntity = "listcontact_association",
					Entity1Attribute = "listid",
					Entity2Attribute = "entityid",
					Entity1LogicalName = "list",
					Entity2LogicalName = "contact",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.ManyToMany
				};

			/// <summary>N:N servicecontractcontacts_association</summary>
			public static readonly XrmFakedRelationship ServicecontractcontactsAssociation = 
				new XrmFakedRelationship
				{
					IntersectEntity = "servicecontractcontacts_association",
					Entity1Attribute = "contactid",
					Entity2Attribute = "contractid",
					Entity1LogicalName = "contact",
					Entity2LogicalName = "contract",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.ManyToMany
				};

		}
		#endregion

		#region Fake
		public static Contact Create()
		{
			var faker = new Faker<Contact>()
			.RuleFor(e => e.Accountidname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Accountidyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.Role, fake => fake.PickRandom<Contact.eRole>())
			.RuleFor(e => e.Address1Id, fake => Guid.NewGuid())
			.RuleFor(e => e.Address1AddressType, fake => fake.PickRandom<Contact.eAddress1AddressType>())
			.RuleFor(e => e.Address1City, fake => fake.Lorem.Word())
			.RuleFor(e => e.Address1, fake => fake.Lorem.Word())
			.RuleFor(e => e.Address1CountryRegion, fake => fake.Lorem.Word())
			.RuleFor(e => e.Address1County, fake => fake.Lorem.Word())
			.RuleFor(e => e.Address1Fax, fake => fake.Lorem.Word())
			.RuleFor(e => e.Address1FreightTerms, fake => fake.PickRandom<Contact.eAddress1FreightTerms>())
			.RuleFor(e => e.Address1Latitude, fake => fake.Random.Double())
			.RuleFor(e => e.Address1Street1, fake => fake.Lorem.Word())
			.RuleFor(e => e.Address1Street2, fake => fake.Lorem.Word())
			.RuleFor(e => e.Address1Street3, fake => fake.Lorem.Word())
			.RuleFor(e => e.Address1Longitude, fake => fake.Random.Double())
			.RuleFor(e => e.Address1Name, fake => fake.Lorem.Word())
			.RuleFor(e => e.Address1ZIPPostalCode, fake => fake.Lorem.Word())
			.RuleFor(e => e.Address1PostOfficeBox, fake => fake.Lorem.Word())
			.RuleFor(e => e.Address1PrimaryContactName, fake => fake.Lorem.Word())
			.RuleFor(e => e.Address1ShippingMethod, fake => fake.PickRandom<Contact.eAddress1ShippingMethod>())
			.RuleFor(e => e.Address1StateProvince, fake => fake.Lorem.Word())
			.RuleFor(e => e.Address1Phone, fake => fake.Lorem.Word())
			.RuleFor(e => e.Address1Telephone2, fake => fake.Lorem.Word())
			.RuleFor(e => e.Address1Telephone3, fake => fake.Lorem.Word())
			.RuleFor(e => e.Address1UPSZone, fake => fake.Lorem.Word())
			.RuleFor(e => e.Address1UTCOffset, fake => fake.Random.Int())
			.RuleFor(e => e.Address2Id, fake => Guid.NewGuid())
			.RuleFor(e => e.Address2AddressType, fake => fake.PickRandom<Contact.eAddress2AddressType>())
			.RuleFor(e => e.Address2City, fake => fake.Lorem.Word())
			.RuleFor(e => e.Address2, fake => fake.Lorem.Word())
			.RuleFor(e => e.Address2CountryRegion, fake => fake.Lorem.Word())
			.RuleFor(e => e.Address2County, fake => fake.Lorem.Word())
			.RuleFor(e => e.Address2Fax, fake => fake.Lorem.Word())
			.RuleFor(e => e.Address2FreightTerms, fake => fake.PickRandom<Contact.eAddress2FreightTerms>())
			.RuleFor(e => e.Address2Latitude, fake => fake.Random.Double())
			.RuleFor(e => e.Address2Street1, fake => fake.Lorem.Word())
			.RuleFor(e => e.Address2Street2, fake => fake.Lorem.Word())
			.RuleFor(e => e.Address2Street3, fake => fake.Lorem.Word())
			.RuleFor(e => e.Address2Longitude, fake => fake.Random.Double())
			.RuleFor(e => e.Address2Name, fake => fake.Lorem.Word())
			.RuleFor(e => e.Address2ZIPPostalCode, fake => fake.Lorem.Word())
			.RuleFor(e => e.Address2PostOfficeBox, fake => fake.Lorem.Word())
			.RuleFor(e => e.Address2PrimaryContactName, fake => fake.Lorem.Word())
			.RuleFor(e => e.Address2ShippingMethod, fake => fake.PickRandom<Contact.eAddress2ShippingMethod>())
			.RuleFor(e => e.Address2StateProvince, fake => fake.Lorem.Word())
			.RuleFor(e => e.Address2Telephone1, fake => fake.Lorem.Word())
			.RuleFor(e => e.Address2Telephone2, fake => fake.Lorem.Word())
			.RuleFor(e => e.Address2Telephone3, fake => fake.Lorem.Word())
			.RuleFor(e => e.Address2UPSZone, fake => fake.Lorem.Word())
			.RuleFor(e => e.Address2UTCOffset, fake => fake.Random.Int())
			.RuleFor(e => e.Address3Id, fake => Guid.NewGuid())
			.RuleFor(e => e.Address3AddressType, fake => fake.PickRandom<Contact.eAddress3AddressType>())
			.RuleFor(e => e.Address3City, fake => fake.Lorem.Word())
			.RuleFor(e => e.Address3, fake => fake.Lorem.Word())
			.RuleFor(e => e.Address3CountryRegion, fake => fake.Lorem.Word())
			.RuleFor(e => e.Address3County, fake => fake.Lorem.Word())
			.RuleFor(e => e.Address3Fax, fake => fake.Lorem.Word())
			.RuleFor(e => e.Address3FreightTerms, fake => fake.PickRandom<Contact.eAddress3FreightTerms>())
			.RuleFor(e => e.Address3Latitude, fake => fake.Random.Double())
			.RuleFor(e => e.Address3Street1, fake => fake.Lorem.Word())
			.RuleFor(e => e.Address3Street2, fake => fake.Lorem.Word())
			.RuleFor(e => e.Address3Street3, fake => fake.Lorem.Word())
			.RuleFor(e => e.Address3Longitude, fake => fake.Random.Double())
			.RuleFor(e => e.Address3Name, fake => fake.Lorem.Word())
			.RuleFor(e => e.Address3ZIPPostalCode, fake => fake.Lorem.Word())
			.RuleFor(e => e.Address3PostOfficeBox, fake => fake.Lorem.Word())
			.RuleFor(e => e.Address3PrimaryContactName, fake => fake.Lorem.Word())
			.RuleFor(e => e.Address3ShippingMethod, fake => fake.PickRandom<Contact.eAddress3ShippingMethod>())
			.RuleFor(e => e.Address3StateProvince, fake => fake.Lorem.Word())
			.RuleFor(e => e.Address3Telephone1, fake => fake.Lorem.Word())
			.RuleFor(e => e.Address3Telephone2, fake => fake.Lorem.Word())
			.RuleFor(e => e.Address3Telephone3, fake => fake.Lorem.Word())
			.RuleFor(e => e.Address3UPSZone, fake => fake.Lorem.Word())
			.RuleFor(e => e.Address3UTCOffset, fake => fake.Random.Int())
			.RuleFor(e => e.Aging30, fake => fake.Finance.Amount())
			.RuleFor(e => e.Aging60, fake => fake.Finance.Amount())
			.RuleFor(e => e.Aging90, fake => fake.Finance.Amount())
			.RuleFor(e => e.Anniversary, fake => fake.Date.Soon())
			.RuleFor(e => e.AnnualIncome, fake => fake.Finance.Amount())
			.RuleFor(e => e.Assistant, fake => fake.Lorem.Word())
			.RuleFor(e => e.AssistantPhone, fake => fake.Lorem.Word())
			.RuleFor(e => e.Birthday, fake => fake.Date.Soon())
			.RuleFor(e => e.BusinessPhone2, fake => fake.Lorem.Word())
			.RuleFor(e => e.BusinessCard, fake => fake.Lorem.Word())
			.RuleFor(e => e.BusinessCardAttributes, fake => fake.Lorem.Word())
			.RuleFor(e => e.CallbackNumber, fake => fake.Lorem.Word())
			.RuleFor(e => e.ChildrensNames, fake => fake.Lorem.Word())
			.RuleFor(e => e.CompanyPhone, fake => fake.Lorem.Word())
			.RuleFor(e => e.Id, fake => Guid.NewGuid())
			.RuleFor(e => e.Createdbyexternalpartyname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Createdbyexternalpartyyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.Createdbyname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Createdbyyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.CreatedOn, fake => fake.Date.Soon())
			.RuleFor(e => e.Createdonbehalfbyname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Createdonbehalfbyyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.CreditLimit, fake => fake.Finance.Amount())
			.RuleFor(e => e.CreditHold, fake => fake.Random.Bool())
			.RuleFor(e => e.CustomerSize, fake => fake.PickRandom<Contact.eCustomerSize>())
			.RuleFor(e => e.RelationshipType, fake => fake.PickRandom<Contact.eRelationshipType>())
			.RuleFor(e => e.Defaultpricelevelidname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Department, fake => fake.Lorem.Word())
			.RuleFor(e => e.Description, fake => fake.Lorem.Word())
			.RuleFor(e => e.DoNotAllowBulkEmails, fake => fake.Random.Bool())
			.RuleFor(e => e.DoNotAllowBulkMails, fake => fake.Random.Bool())
			.RuleFor(e => e.DoNotAllowEmails, fake => fake.Random.Bool())
			.RuleFor(e => e.DoNotAllowFaxes, fake => fake.Random.Bool())
			.RuleFor(e => e.DoNotAllowPhoneCalls, fake => fake.Random.Bool())
			.RuleFor(e => e.DoNotAllowMails, fake => fake.Random.Bool())
			.RuleFor(e => e.SendMarketingMaterials, fake => fake.Random.Bool())
			.RuleFor(e => e.Education, fake => fake.PickRandom<Contact.eEducation>())
			.RuleFor(e => e.Email, fake => fake.Lorem.Word())
			.RuleFor(e => e.EmailAddress2, fake => fake.Lorem.Word())
			.RuleFor(e => e.EmailAddress3, fake => fake.Lorem.Word())
			.RuleFor(e => e.Employee, fake => fake.Lorem.Word())
			.RuleFor(e => e.EntityimageTimestamp, fake => fake.Random.Int())
			.RuleFor(e => e.EntityimageUrl, fake => fake.Lorem.Word())
			.RuleFor(e => e.EntityImageId, fake => Guid.NewGuid())
			.RuleFor(e => e.ExchangeRate, fake => fake.Finance.Amount())
			.RuleFor(e => e.ExternalUserIdentifier, fake => fake.Lorem.Word())
			.RuleFor(e => e.MaritalStatus, fake => fake.PickRandom<Contact.eMaritalStatus>())
			.RuleFor(e => e.Fax, fake => fake.Lorem.Word())
			.RuleFor(e => e.FirstName, fake => fake.Lorem.Word())
			.RuleFor(e => e.FollowEmailActivity, fake => fake.Random.Bool())
			.RuleFor(e => e.FTPSite, fake => fake.Lorem.Word())
			.RuleFor(e => e.FullName, fake => fake.Lorem.Word())
			.RuleFor(e => e.Gender, fake => fake.PickRandom<Contact.eGender>())
			.RuleFor(e => e.Government, fake => fake.Lorem.Word())
			.RuleFor(e => e.HasChildren, fake => fake.PickRandom<Contact.eHasChildren>())
			.RuleFor(e => e.HomePhone2, fake => fake.Lorem.Word())
			.RuleFor(e => e.ImportSequenceNumber, fake => fake.Random.Int())
			.RuleFor(e => e.Autocreated, fake => fake.Random.Bool())
			.RuleFor(e => e.BackOfficeCustomer, fake => fake.Random.Bool())
			.RuleFor(e => e.Isprivate, fake => fake.Random.Bool())
			.RuleFor(e => e.JobTitle, fake => fake.Lorem.Word())
			.RuleFor(e => e.LastName, fake => fake.Lorem.Word())
			.RuleFor(e => e.LastOnHoldTime, fake => fake.Date.Soon())
			.RuleFor(e => e.LastDateIncludedInCampaign, fake => fake.Date.Soon())
			.RuleFor(e => e.LeadSource, fake => fake.PickRandom<Contact.eLeadSource>())
			.RuleFor(e => e.Manager, fake => fake.Lorem.Word())
			.RuleFor(e => e.ManagerPhone, fake => fake.Lorem.Word())
			.RuleFor(e => e.MarketingOnly, fake => fake.Random.Bool())
			.RuleFor(e => e.Mastercontactidname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Mastercontactidyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.Merged, fake => fake.Random.Bool())
			.RuleFor(e => e.MiddleName, fake => fake.Lorem.Word())
			.RuleFor(e => e.MobilePhone, fake => fake.Lorem.Word())
			.RuleFor(e => e.Modifiedbyexternalpartyname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Modifiedbyexternalpartyyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.Modifiedbyname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Modifiedbyyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.ModifiedOn, fake => fake.Date.Soon())
			.RuleFor(e => e.Modifiedonbehalfbyname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Modifiedonbehalfbyyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.GDPROptout, fake => fake.Random.Bool())
			.RuleFor(e => e.NotAtCompanyFlag, fake => fake.PickRandom<Contact.eNotAtCompanyFlag>())
			.RuleFor(e => e.Nickname, fake => fake.Lorem.Word())
			.RuleFor(e => e.NoOfChildren, fake => fake.Random.Int())
			.RuleFor(e => e.OnHoldTimeMinutes, fake => fake.Random.Int())
			.RuleFor(e => e.Originatingleadidname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Originatingleadidyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.RecordCreatedOn, fake => fake.Date.Soon())
			.RuleFor(e => e.Owneridname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Owneridtype, fake => fake.Lorem.Word())
			.RuleFor(e => e.Owneridyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.Pager, fake => fake.Lorem.Word())
			.RuleFor(e => e.Parentcontactidname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Parentcontactidyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.Parentcustomeridname, fake => fake.Lorem.Word())
			.RuleFor(e => e.ParentCustomerType, fake => fake.Lorem.Word())
			.RuleFor(e => e.Parentcustomeridyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.ParticipatesInWorkflow, fake => fake.Random.Bool())
			.RuleFor(e => e.PaymentTerms, fake => fake.PickRandom<Contact.ePaymentTerms>())
			.RuleFor(e => e.PreferredDay, fake => fake.PickRandom<Contact.ePreferredDay>())
			.RuleFor(e => e.PreferredTime, fake => fake.PickRandom<Contact.ePreferredTime>())
			.RuleFor(e => e.PreferredMethodOfContact, fake => fake.PickRandom<Contact.ePreferredMethodOfContact>())
			.RuleFor(e => e.Preferredequipmentidname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Preferredserviceidname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Preferredsystemuseridname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Preferredsystemuseridyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.ProcessId, fake => Guid.NewGuid())
			.RuleFor(e => e.Salutation, fake => fake.Lorem.Word())
			.RuleFor(e => e.ShippingMethod, fake => fake.PickRandom<Contact.eShippingMethod>())
			.RuleFor(e => e.Slainvokedidname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Slaname, fake => fake.Lorem.Word())
			.RuleFor(e => e.SpousePartnerName, fake => fake.Lorem.Word())
			.RuleFor(e => e.DeprecatedProcessStageId, fake => Guid.NewGuid())
			.RuleFor(e => e.Status, fake => fake.PickRandom<Contact.eStatus>())
			.RuleFor(e => e.StatusReason, fake => fake.PickRandom<Contact.eStatusReason>())
			.RuleFor(e => e.SubscriptionId, fake => Guid.NewGuid())
			.RuleFor(e => e.Suffix, fake => fake.Lorem.Word())
			.RuleFor(e => e.TeamsFollowed, fake => fake.Random.Int())
			.RuleFor(e => e.BusinessPhone, fake => fake.Lorem.Word())
			.RuleFor(e => e.HomePhone, fake => fake.Lorem.Word())
			.RuleFor(e => e.Telephone3, fake => fake.Lorem.Word())
			.RuleFor(e => e.Territory, fake => fake.PickRandom<Contact.eTerritory>())
			.RuleFor(e => e.TimeSpentByMe, fake => fake.Lorem.Word())
			.RuleFor(e => e.TimeZoneRuleVersionNumber, fake => fake.Random.Int())
			.RuleFor(e => e.Transactioncurrencyidname, fake => fake.Lorem.Word())
			.RuleFor(e => e.DeprecatedTraversedPath, fake => fake.Lorem.Word())
			.RuleFor(e => e.UTCConversionTimeZoneCode, fake => fake.Random.Int())
			.RuleFor(e => e.VersionNumber, fake => fake.Random.Int())
			.RuleFor(e => e.Website, fake => fake.Lorem.Word())
			.RuleFor(e => e.YomiFirstName, fake => fake.Lorem.Word())
			.RuleFor(e => e.YomiFullName, fake => fake.Lorem.Word())
			.RuleFor(e => e.YomiLastName, fake => fake.Lorem.Word())
			.RuleFor(e => e.YomiMiddleName, fake => fake.Lorem.Word());
			return faker.Generate();
		}
		#endregion
	}
}

