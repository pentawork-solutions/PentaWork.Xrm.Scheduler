using Bogus;
using System;
using FakeXrmEasy;
using System.Collections.Generic;
using PentaWork.Xrm.Scheduler.Proxies.Entities;

namespace PentaWork.Xrm.Scheduler.Tests.Fake
{
	public static class FakeInvoice
	{	
		#region FakeRelationships
		public static class Relationships 
		{
			/// <summary>1:N invoice_activity_parties</summary>
			public static readonly XrmFakedRelationship InvoiceActivityParties = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "invoiceid",
					Entity2Attribute = "partyid",
					Entity1LogicalName = "invoice",
					Entity2LogicalName = "activityparty",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N Invoice_ActivityPointers</summary>
			public static readonly XrmFakedRelationship InvoiceActivityPointers = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "invoiceid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "invoice",
					Entity2LogicalName = "activitypointer",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N Invoice_Annotation</summary>
			public static readonly XrmFakedRelationship InvoiceAnnotation = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "invoiceid",
					Entity2Attribute = "objectid",
					Entity1LogicalName = "invoice",
					Entity2LogicalName = "annotation",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N Invoice_Appointments</summary>
			public static readonly XrmFakedRelationship InvoiceAppointments = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "invoiceid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "invoice",
					Entity2LogicalName = "appointment",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N Invoice_AsyncOperations</summary>
			public static readonly XrmFakedRelationship InvoiceAsyncOperations = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "invoiceid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "invoice",
					Entity2LogicalName = "asyncoperation",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N Invoice_BulkDeleteFailures</summary>
			public static readonly XrmFakedRelationship InvoiceBulkDeleteFailures = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "invoiceid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "invoice",
					Entity2LogicalName = "bulkdeletefailure",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N invoice_connections1</summary>
			public static readonly XrmFakedRelationship InvoiceConnections1 = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "invoiceid",
					Entity2Attribute = "record1id",
					Entity1LogicalName = "invoice",
					Entity2LogicalName = "connection",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N invoice_connections2</summary>
			public static readonly XrmFakedRelationship InvoiceConnections2 = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "invoiceid",
					Entity2Attribute = "record2id",
					Entity1LogicalName = "invoice",
					Entity2LogicalName = "connection",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N invoice_details</summary>
			public static readonly XrmFakedRelationship InvoiceDetails = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "invoiceid",
					Entity2Attribute = "invoiceid",
					Entity1LogicalName = "invoice",
					Entity2LogicalName = "invoicedetail",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N Invoice_Emails</summary>
			public static readonly XrmFakedRelationship InvoiceEmails = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "invoiceid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "invoice",
					Entity2LogicalName = "email",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N Invoice_Faxes</summary>
			public static readonly XrmFakedRelationship InvoiceFaxes = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "invoiceid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "invoice",
					Entity2LogicalName = "fax",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N Invoice_Letters</summary>
			public static readonly XrmFakedRelationship InvoiceLetters = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "invoiceid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "invoice",
					Entity2LogicalName = "letter",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N Invoice_MailboxTrackingFolder</summary>
			public static readonly XrmFakedRelationship InvoiceMailboxTrackingFolder = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "invoiceid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "invoice",
					Entity2LogicalName = "mailboxtrackingfolder",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N Invoice_Phonecalls</summary>
			public static readonly XrmFakedRelationship InvoicePhonecalls = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "invoiceid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "invoice",
					Entity2LogicalName = "phonecall",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N invoice_principalobjectattributeaccess</summary>
			public static readonly XrmFakedRelationship InvoicePrincipalobjectattributeaccess = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "invoiceid",
					Entity2Attribute = "objectid",
					Entity1LogicalName = "invoice",
					Entity2LogicalName = "principalobjectattributeaccess",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N Invoice_ProcessSessions</summary>
			public static readonly XrmFakedRelationship InvoiceProcessSessions = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "invoiceid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "invoice",
					Entity2LogicalName = "processsession",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N Invoice_RecurringAppointmentMasters</summary>
			public static readonly XrmFakedRelationship InvoiceRecurringAppointmentMasters = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "invoiceid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "invoice",
					Entity2LogicalName = "recurringappointmentmaster",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N Invoice_ServiceAppointments</summary>
			public static readonly XrmFakedRelationship InvoiceServiceAppointments = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "invoiceid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "invoice",
					Entity2LogicalName = "serviceappointment",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N Invoice_SocialActivities</summary>
			public static readonly XrmFakedRelationship InvoiceSocialActivities = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "invoiceid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "invoice",
					Entity2LogicalName = "socialactivity",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N Invoice_SyncErrors</summary>
			public static readonly XrmFakedRelationship InvoiceSyncErrors = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "invoiceid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "invoice",
					Entity2LogicalName = "syncerror",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N Invoice_Tasks</summary>
			public static readonly XrmFakedRelationship InvoiceTasks = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "invoiceid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "invoice",
					Entity2LogicalName = "task",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N msdyn_playbookinstance_invoice</summary>
			public static readonly XrmFakedRelationship MsdynPlaybookinstanceInvoice = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "invoiceid",
					Entity2Attribute = "regarding",
					Entity1LogicalName = "invoice",
					Entity2LogicalName = "msdyn_playbookinstance",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N slakpiinstance_invoice</summary>
			public static readonly XrmFakedRelationship SlakpiinstanceInvoice = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "invoiceid",
					Entity2Attribute = "regarding",
					Entity1LogicalName = "invoice",
					Entity2LogicalName = "slakpiinstance",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
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

		}
		#endregion

		#region Fake
		public static Invoice Create()
		{
			var faker = new Faker<Invoice>()
			.RuleFor(e => e.Accountidname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Accountidyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.BillToCity, fake => fake.Lorem.Word())
			.RuleFor(e => e.BillToAddress, fake => fake.Lorem.Word())
			.RuleFor(e => e.BillToCountryRegion, fake => fake.Lorem.Word())
			.RuleFor(e => e.BillToFax, fake => fake.Lorem.Word())
			.RuleFor(e => e.BillToStreet1, fake => fake.Lorem.Word())
			.RuleFor(e => e.BillToStreet2, fake => fake.Lorem.Word())
			.RuleFor(e => e.BillToStreet3, fake => fake.Lorem.Word())
			.RuleFor(e => e.BillToName, fake => fake.Lorem.Word())
			.RuleFor(e => e.BillToZIPPostalCode, fake => fake.Lorem.Word())
			.RuleFor(e => e.BillToStateProvince, fake => fake.Lorem.Word())
			.RuleFor(e => e.BillToPhone, fake => fake.Lorem.Word())
			.RuleFor(e => e.Contactidname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Contactidyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.Createdbyname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Createdbyyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.CreatedOn, fake => fake.Date.Soon())
			.RuleFor(e => e.Createdonbehalfbyname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Createdonbehalfbyyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.Customeridname, fake => fake.Lorem.Word())
			.RuleFor(e => e.CustomerType, fake => fake.Lorem.Word())
			.RuleFor(e => e.Customeridyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.DateDelivered, fake => fake.Date.Soon())
			.RuleFor(e => e.Description, fake => fake.Lorem.Word())
			.RuleFor(e => e.InvoiceDiscountAmount, fake => fake.Finance.Amount())
			.RuleFor(e => e.InvoiceDiscount, fake => fake.Finance.Amount())
			.RuleFor(e => e.DueDate, fake => fake.Date.Soon())
			.RuleFor(e => e.EmailAddress, fake => fake.Lorem.Word())
			.RuleFor(e => e.EntityimageTimestamp, fake => fake.Random.Int())
			.RuleFor(e => e.EntityimageUrl, fake => fake.Lorem.Word())
			.RuleFor(e => e.EntityimageId, fake => Guid.NewGuid())
			.RuleFor(e => e.ExchangeRate, fake => fake.Finance.Amount())
			.RuleFor(e => e.FreightAmount, fake => fake.Finance.Amount())
			.RuleFor(e => e.ImportSequenceNumber, fake => fake.Random.Int())
			.RuleFor(e => e.Id, fake => Guid.NewGuid())
			.RuleFor(e => e.InvoiceID, fake => fake.Lorem.Word())
			.RuleFor(e => e.PricesLocked, fake => fake.Random.Bool())
			.RuleFor(e => e.LastSubmittedToBackOffice, fake => fake.Date.Soon())
			.RuleFor(e => e.LastOnHoldTime, fake => fake.Date.Soon())
			.RuleFor(e => e.Modifiedbyname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Modifiedbyyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.ModifiedOn, fake => fake.Date.Soon())
			.RuleFor(e => e.Modifiedonbehalfbyname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Modifiedonbehalfbyyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.Name, fake => fake.Lorem.Word())
			.RuleFor(e => e.OnHoldTimeMinutes, fake => fake.Random.Int())
			.RuleFor(e => e.Opportunityidname, fake => fake.Lorem.Word())
			.RuleFor(e => e.RecordCreatedOn, fake => fake.Date.Soon())
			.RuleFor(e => e.Owneridname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Owneridtype, fake => fake.Lorem.Word())
			.RuleFor(e => e.Owneridyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.PaymentTerms, fake => fake.PickRandom<Invoice.ePaymentTerms>())
			.RuleFor(e => e.Pricelevelidname, fake => fake.Lorem.Word())
			.RuleFor(e => e.PricingError, fake => fake.PickRandom<Invoice.egPricingError>())
			.RuleFor(e => e.Priority, fake => fake.PickRandom<Invoice.ePriority>())
			.RuleFor(e => e.ProcessId, fake => Guid.NewGuid())
			.RuleFor(e => e.Salesorderidname, fake => fake.Lorem.Word())
			.RuleFor(e => e.ShippingMethod, fake => fake.PickRandom<Invoice.eShippingMethod>())
			.RuleFor(e => e.ShipToCity, fake => fake.Lorem.Word())
			.RuleFor(e => e.ShipToAddress, fake => fake.Lorem.Word())
			.RuleFor(e => e.ShipToCountryRegion, fake => fake.Lorem.Word())
			.RuleFor(e => e.ShipToFax, fake => fake.Lorem.Word())
			.RuleFor(e => e.ShipToFreightTerms, fake => fake.PickRandom<Invoice.eShipToFreightTerms>())
			.RuleFor(e => e.ShipToStreet1, fake => fake.Lorem.Word())
			.RuleFor(e => e.ShipToStreet2, fake => fake.Lorem.Word())
			.RuleFor(e => e.ShipToStreet3, fake => fake.Lorem.Word())
			.RuleFor(e => e.ShipToName, fake => fake.Lorem.Word())
			.RuleFor(e => e.ShipToZIPPostalCode, fake => fake.Lorem.Word())
			.RuleFor(e => e.ShipToStateProvince, fake => fake.Lorem.Word())
			.RuleFor(e => e.ShipToPhone, fake => fake.Lorem.Word())
			.RuleFor(e => e.SkipPriceCalculation, fake => fake.PickRandom<Invoice.egSkipPriceCalculationOptionSet>())
			.RuleFor(e => e.Slainvokedidname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Slaname, fake => fake.Lorem.Word())
			.RuleFor(e => e.DeprecatedStageId, fake => Guid.NewGuid())
			.RuleFor(e => e.Status, fake => fake.PickRandom<Invoice.eStatus>())
			.RuleFor(e => e.StatusReason, fake => fake.PickRandom<Invoice.eStatusReason>())
			.RuleFor(e => e.TimeZoneRuleVersionNumber, fake => fake.Random.Int())
			.RuleFor(e => e.TotalAmount, fake => fake.Finance.Amount())
			.RuleFor(e => e.TotalPreFreightAmount, fake => fake.Finance.Amount())
			.RuleFor(e => e.TotalDiscountAmount, fake => fake.Finance.Amount())
			.RuleFor(e => e.TotalDetailAmount, fake => fake.Finance.Amount())
			.RuleFor(e => e.TotalLineItemDiscountAmount, fake => fake.Finance.Amount())
			.RuleFor(e => e.TotalTax, fake => fake.Finance.Amount())
			.RuleFor(e => e.Transactioncurrencyidname, fake => fake.Lorem.Word())
			.RuleFor(e => e.DeprecatedTraversedPath, fake => fake.Lorem.Word())
			.RuleFor(e => e.UTCConversionTimeZoneCode, fake => fake.Random.Int())
			.RuleFor(e => e.VersionNumber, fake => fake.Random.Int())
			.RuleFor(e => e.ShipTo, fake => fake.Random.Bool());
			return faker.Generate();
		}
		#endregion
	}
}

