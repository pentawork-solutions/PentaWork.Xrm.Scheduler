using Bogus;
using System;
using FakeXrmEasy;
using System.Collections.Generic;
using PentaWork.Xrm.Scheduler.Proxies.Entities;

namespace PentaWork.Xrm.Scheduler.Tests.Fake
{
	public static class FakeOrder
	{	
		#region FakeRelationships
		public static class Relationships 
		{
			/// <summary>1:N lk_opportunitysalesprocess_salesorderid</summary>
			public static readonly XrmFakedRelationship LkOpportunitysalesprocessSalesorderid = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "salesorderid",
					Entity2Attribute = "salesorderid",
					Entity1LogicalName = "salesorder",
					Entity2LogicalName = "opportunitysalesprocess",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N msdyn_playbookinstance_salesorder</summary>
			public static readonly XrmFakedRelationship MsdynPlaybookinstanceSalesorder = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "salesorderid",
					Entity2Attribute = "regarding",
					Entity1LogicalName = "salesorder",
					Entity2LogicalName = "msdyn_playbookinstance",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N order_details</summary>
			public static readonly XrmFakedRelationship OrderDetails = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "salesorderid",
					Entity2Attribute = "salesorderid",
					Entity1LogicalName = "salesorder",
					Entity2LogicalName = "salesorderdetail",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N order_invoices</summary>
			public static readonly XrmFakedRelationship OrderInvoices = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "salesorderid",
					Entity2Attribute = "salesorderid",
					Entity1LogicalName = "salesorder",
					Entity2LogicalName = "invoice",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N salesorder_activity_parties</summary>
			public static readonly XrmFakedRelationship SalesorderActivityParties = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "salesorderid",
					Entity2Attribute = "partyid",
					Entity1LogicalName = "salesorder",
					Entity2LogicalName = "activityparty",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N SalesOrder_ActivityPointers</summary>
			public static readonly XrmFakedRelationship SalesOrderActivityPointers = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "salesorderid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "salesorder",
					Entity2LogicalName = "activitypointer",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N SalesOrder_Annotation</summary>
			public static readonly XrmFakedRelationship SalesOrderAnnotation = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "salesorderid",
					Entity2Attribute = "objectid",
					Entity1LogicalName = "salesorder",
					Entity2LogicalName = "annotation",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N SalesOrder_Appointments</summary>
			public static readonly XrmFakedRelationship SalesOrderAppointments = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "salesorderid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "salesorder",
					Entity2LogicalName = "appointment",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N SalesOrder_AsyncOperations</summary>
			public static readonly XrmFakedRelationship SalesOrderAsyncOperations = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "salesorderid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "salesorder",
					Entity2LogicalName = "asyncoperation",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N SalesOrder_BulkDeleteFailures</summary>
			public static readonly XrmFakedRelationship SalesOrderBulkDeleteFailures = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "salesorderid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "salesorder",
					Entity2LogicalName = "bulkdeletefailure",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N salesorder_connections1</summary>
			public static readonly XrmFakedRelationship SalesorderConnections1 = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "salesorderid",
					Entity2Attribute = "record1id",
					Entity1LogicalName = "salesorder",
					Entity2LogicalName = "connection",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N salesorder_connections2</summary>
			public static readonly XrmFakedRelationship SalesorderConnections2 = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "salesorderid",
					Entity2Attribute = "record2id",
					Entity1LogicalName = "salesorder",
					Entity2LogicalName = "connection",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N SalesOrder_Emails</summary>
			public static readonly XrmFakedRelationship SalesOrderEmails = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "salesorderid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "salesorder",
					Entity2LogicalName = "email",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N SalesOrder_Faxes</summary>
			public static readonly XrmFakedRelationship SalesOrderFaxes = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "salesorderid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "salesorder",
					Entity2LogicalName = "fax",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N SalesOrder_Letters</summary>
			public static readonly XrmFakedRelationship SalesOrderLetters = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "salesorderid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "salesorder",
					Entity2LogicalName = "letter",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N SalesOrder_MailboxTrackingFolder</summary>
			public static readonly XrmFakedRelationship SalesOrderMailboxTrackingFolder = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "salesorderid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "salesorder",
					Entity2LogicalName = "mailboxtrackingfolder",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N SalesOrder_OrderClose</summary>
			public static readonly XrmFakedRelationship SalesOrderOrderClose = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "salesorderid",
					Entity2Attribute = "salesorderid",
					Entity1LogicalName = "salesorder",
					Entity2LogicalName = "orderclose",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N SalesOrder_Phonecalls</summary>
			public static readonly XrmFakedRelationship SalesOrderPhonecalls = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "salesorderid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "salesorder",
					Entity2LogicalName = "phonecall",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N salesorder_principalobjectattributeaccess</summary>
			public static readonly XrmFakedRelationship SalesorderPrincipalobjectattributeaccess = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "salesorderid",
					Entity2Attribute = "objectid",
					Entity1LogicalName = "salesorder",
					Entity2LogicalName = "principalobjectattributeaccess",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N SalesOrder_ProcessSessions</summary>
			public static readonly XrmFakedRelationship SalesOrderProcessSessions = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "salesorderid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "salesorder",
					Entity2LogicalName = "processsession",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N SalesOrder_RecurringAppointmentMasters</summary>
			public static readonly XrmFakedRelationship SalesOrderRecurringAppointmentMasters = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "salesorderid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "salesorder",
					Entity2LogicalName = "recurringappointmentmaster",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N SalesOrder_ServiceAppointments</summary>
			public static readonly XrmFakedRelationship SalesOrderServiceAppointments = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "salesorderid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "salesorder",
					Entity2LogicalName = "serviceappointment",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N SalesOrder_SocialActivities</summary>
			public static readonly XrmFakedRelationship SalesOrderSocialActivities = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "salesorderid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "salesorder",
					Entity2LogicalName = "socialactivity",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N SalesOrder_SyncErrors</summary>
			public static readonly XrmFakedRelationship SalesOrderSyncErrors = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "salesorderid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "salesorder",
					Entity2LogicalName = "syncerror",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N SalesOrder_Tasks</summary>
			public static readonly XrmFakedRelationship SalesOrderTasks = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "salesorderid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "salesorder",
					Entity2LogicalName = "task",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N slakpiinstance_salesorder</summary>
			public static readonly XrmFakedRelationship SlakpiinstanceSalesorder = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "salesorderid",
					Entity2Attribute = "regarding",
					Entity1LogicalName = "salesorder",
					Entity2LogicalName = "slakpiinstance",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
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

		}
		#endregion

		#region Fake
		public static Order Create()
		{
			var faker = new Faker<Order>()
			.RuleFor(e => e.Accountidname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Accountidyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.BillToAddressId, fake => Guid.NewGuid())
			.RuleFor(e => e.BillToCity, fake => fake.Lorem.Word())
			.RuleFor(e => e.BillToAddress, fake => fake.Lorem.Word())
			.RuleFor(e => e.BillToContactName, fake => fake.Lorem.Word())
			.RuleFor(e => e.BillToCountryRegion, fake => fake.Lorem.Word())
			.RuleFor(e => e.BillToFax, fake => fake.Lorem.Word())
			.RuleFor(e => e.BillToStreet1, fake => fake.Lorem.Word())
			.RuleFor(e => e.BillToStreet2, fake => fake.Lorem.Word())
			.RuleFor(e => e.BillToStreet3, fake => fake.Lorem.Word())
			.RuleFor(e => e.BillToName, fake => fake.Lorem.Word())
			.RuleFor(e => e.BillToZIPPostalCode, fake => fake.Lorem.Word())
			.RuleFor(e => e.BillToStateProvince, fake => fake.Lorem.Word())
			.RuleFor(e => e.BillToPhone, fake => fake.Lorem.Word())
			.RuleFor(e => e.Campaignidname, fake => fake.Lorem.Word())
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
			.RuleFor(e => e.DateFulfilled, fake => fake.Date.Soon())
			.RuleFor(e => e.Description, fake => fake.Lorem.Word())
			.RuleFor(e => e.OrderDiscountAmount, fake => fake.Finance.Amount())
			.RuleFor(e => e.OrderDiscount, fake => fake.Finance.Amount())
			.RuleFor(e => e.EmailAddress, fake => fake.Lorem.Word())
			.RuleFor(e => e.EntityimageTimestamp, fake => fake.Random.Int())
			.RuleFor(e => e.EntityimageUrl, fake => fake.Lorem.Word())
			.RuleFor(e => e.EntityimageId, fake => Guid.NewGuid())
			.RuleFor(e => e.ExchangeRate, fake => fake.Finance.Amount())
			.RuleFor(e => e.FreightAmount, fake => fake.Finance.Amount())
			.RuleFor(e => e.FreightTerms, fake => fake.PickRandom<Order.eFreightTerms>())
			.RuleFor(e => e.ImportSequenceNumber, fake => fake.Random.Int())
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
			.RuleFor(e => e.OrderID, fake => fake.Lorem.Word())
			.RuleFor(e => e.RecordCreatedOn, fake => fake.Date.Soon())
			.RuleFor(e => e.Owneridname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Owneridtype, fake => fake.Lorem.Word())
			.RuleFor(e => e.Owneridyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.PaymentTerms, fake => fake.PickRandom<Order.ePaymentTerms>())
			.RuleFor(e => e.Pricelevelidname, fake => fake.Lorem.Word())
			.RuleFor(e => e.PricingError, fake => fake.PickRandom<Order.egPricingError>())
			.RuleFor(e => e.Priority, fake => fake.PickRandom<Order.ePriority>())
			.RuleFor(e => e.ProcessId, fake => Guid.NewGuid())
			.RuleFor(e => e.Quoteidname, fake => fake.Lorem.Word())
			.RuleFor(e => e.RequestedDeliveryDate, fake => fake.Date.Soon())
			.RuleFor(e => e.Id, fake => Guid.NewGuid())
			.RuleFor(e => e.ShippingMethod, fake => fake.PickRandom<Order.eShippingMethod>())
			.RuleFor(e => e.ShipToAddressId, fake => Guid.NewGuid())
			.RuleFor(e => e.ShipToCity, fake => fake.Lorem.Word())
			.RuleFor(e => e.ShipToAddress, fake => fake.Lorem.Word())
			.RuleFor(e => e.ShipToContactName, fake => fake.Lorem.Word())
			.RuleFor(e => e.ShipToCountryRegion, fake => fake.Lorem.Word())
			.RuleFor(e => e.ShipToFax, fake => fake.Lorem.Word())
			.RuleFor(e => e.ShipToFreightTerms, fake => fake.PickRandom<Order.eShipToFreightTerms>())
			.RuleFor(e => e.ShipToStreet1, fake => fake.Lorem.Word())
			.RuleFor(e => e.ShipToStreet2, fake => fake.Lorem.Word())
			.RuleFor(e => e.ShipToStreet3, fake => fake.Lorem.Word())
			.RuleFor(e => e.ShipToName, fake => fake.Lorem.Word())
			.RuleFor(e => e.ShipToZIPPostalCode, fake => fake.Lorem.Word())
			.RuleFor(e => e.ShipToStateProvince, fake => fake.Lorem.Word())
			.RuleFor(e => e.ShipToPhone, fake => fake.Lorem.Word())
			.RuleFor(e => e.SkipPriceCalculationForInternalUse, fake => fake.PickRandom<Order.egSkipPriceCalculationOptionSet>())
			.RuleFor(e => e.Slainvokedidname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Slaname, fake => fake.Lorem.Word())
			.RuleFor(e => e.DeprecatedStageId, fake => Guid.NewGuid())
			.RuleFor(e => e.Status, fake => fake.PickRandom<Order.eStatus>())
			.RuleFor(e => e.StatusReason, fake => fake.PickRandom<Order.eStatusReason>())
			.RuleFor(e => e.DateSubmitted, fake => fake.Date.Soon())
			.RuleFor(e => e.SubmittedStatus, fake => fake.Random.Int())
			.RuleFor(e => e.SubmittedStatusDescription, fake => fake.Lorem.Word())
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

