using Bogus;
using System;
using FakeXrmEasy;
using System.Collections.Generic;
using PentaWork.Xrm.Scheduler.Proxies.Entities;

namespace PentaWork.Xrm.Scheduler.Tests.Fake
{
	public static class FakeQuote
	{	
		#region FakeRelationships
		public static class Relationships 
		{
			/// <summary>1:N lk_opportunitysalesprocess_quoteid</summary>
			public static readonly XrmFakedRelationship LkOpportunitysalesprocessQuoteid = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "quoteid",
					Entity2Attribute = "quoteid",
					Entity1LogicalName = "quote",
					Entity2LogicalName = "opportunitysalesprocess",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N msdyn_playbookinstance_quote</summary>
			public static readonly XrmFakedRelationship MsdynPlaybookinstanceQuote = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "quoteid",
					Entity2Attribute = "regarding",
					Entity1LogicalName = "quote",
					Entity2LogicalName = "msdyn_playbookinstance",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N quote_activity_parties</summary>
			public static readonly XrmFakedRelationship QuoteActivityParties = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "quoteid",
					Entity2Attribute = "partyid",
					Entity1LogicalName = "quote",
					Entity2LogicalName = "activityparty",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N Quote_ActivityPointers</summary>
			public static readonly XrmFakedRelationship QuoteActivityPointers = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "quoteid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "quote",
					Entity2LogicalName = "activitypointer",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N Quote_Annotation</summary>
			public static readonly XrmFakedRelationship QuoteAnnotation = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "quoteid",
					Entity2Attribute = "objectid",
					Entity1LogicalName = "quote",
					Entity2LogicalName = "annotation",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N Quote_Appointments</summary>
			public static readonly XrmFakedRelationship QuoteAppointments = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "quoteid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "quote",
					Entity2LogicalName = "appointment",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N Quote_AsyncOperations</summary>
			public static readonly XrmFakedRelationship QuoteAsyncOperations = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "quoteid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "quote",
					Entity2LogicalName = "asyncoperation",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N Quote_BulkDeleteFailures</summary>
			public static readonly XrmFakedRelationship QuoteBulkDeleteFailures = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "quoteid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "quote",
					Entity2LogicalName = "bulkdeletefailure",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N quote_connections1</summary>
			public static readonly XrmFakedRelationship QuoteConnections1 = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "quoteid",
					Entity2Attribute = "record1id",
					Entity1LogicalName = "quote",
					Entity2LogicalName = "connection",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N quote_connections2</summary>
			public static readonly XrmFakedRelationship QuoteConnections2 = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "quoteid",
					Entity2Attribute = "record2id",
					Entity1LogicalName = "quote",
					Entity2LogicalName = "connection",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N quote_details</summary>
			public static readonly XrmFakedRelationship QuoteDetails = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "quoteid",
					Entity2Attribute = "quoteid",
					Entity1LogicalName = "quote",
					Entity2LogicalName = "quotedetail",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N Quote_DuplicateBaseRecord</summary>
			public static readonly XrmFakedRelationship QuoteDuplicateBaseRecord = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "quoteid",
					Entity2Attribute = "baserecordid",
					Entity1LogicalName = "quote",
					Entity2LogicalName = "duplicaterecord",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N Quote_DuplicateMatchingRecord</summary>
			public static readonly XrmFakedRelationship QuoteDuplicateMatchingRecord = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "quoteid",
					Entity2Attribute = "duplicaterecordid",
					Entity1LogicalName = "quote",
					Entity2LogicalName = "duplicaterecord",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N Quote_Emails</summary>
			public static readonly XrmFakedRelationship QuoteEmails = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "quoteid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "quote",
					Entity2LogicalName = "email",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N Quote_Faxes</summary>
			public static readonly XrmFakedRelationship QuoteFaxes = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "quoteid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "quote",
					Entity2LogicalName = "fax",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N Quote_Letters</summary>
			public static readonly XrmFakedRelationship QuoteLetters = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "quoteid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "quote",
					Entity2LogicalName = "letter",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N Quote_MailboxTrackingFolder</summary>
			public static readonly XrmFakedRelationship QuoteMailboxTrackingFolder = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "quoteid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "quote",
					Entity2LogicalName = "mailboxtrackingfolder",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N quote_orders</summary>
			public static readonly XrmFakedRelationship QuoteOrders = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "quoteid",
					Entity2Attribute = "quoteid",
					Entity1LogicalName = "quote",
					Entity2LogicalName = "salesorder",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N Quote_Phonecalls</summary>
			public static readonly XrmFakedRelationship QuotePhonecalls = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "quoteid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "quote",
					Entity2LogicalName = "phonecall",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N quote_principalobjectattributeaccess</summary>
			public static readonly XrmFakedRelationship QuotePrincipalobjectattributeaccess = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "quoteid",
					Entity2Attribute = "objectid",
					Entity1LogicalName = "quote",
					Entity2LogicalName = "principalobjectattributeaccess",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N Quote_ProcessSessions</summary>
			public static readonly XrmFakedRelationship QuoteProcessSessions = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "quoteid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "quote",
					Entity2LogicalName = "processsession",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N Quote_QuoteClose</summary>
			public static readonly XrmFakedRelationship QuoteQuoteClose = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "quoteid",
					Entity2Attribute = "quoteid",
					Entity1LogicalName = "quote",
					Entity2LogicalName = "quoteclose",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N quote_QuoteCloses</summary>
			public static readonly XrmFakedRelationship QuoteQuoteCloses = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "quoteid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "quote",
					Entity2LogicalName = "quoteclose",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N Quote_RecurringAppointmentMasters</summary>
			public static readonly XrmFakedRelationship QuoteRecurringAppointmentMasters = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "quoteid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "quote",
					Entity2LogicalName = "recurringappointmentmaster",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N Quote_ServiceAppointments</summary>
			public static readonly XrmFakedRelationship QuoteServiceAppointments = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "quoteid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "quote",
					Entity2LogicalName = "serviceappointment",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N Quote_SharepointDocumentLocation</summary>
			public static readonly XrmFakedRelationship QuoteSharepointDocumentLocation = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "quoteid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "quote",
					Entity2LogicalName = "sharepointdocumentlocation",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N Quote_SocialActivities</summary>
			public static readonly XrmFakedRelationship QuoteSocialActivities = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "quoteid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "quote",
					Entity2LogicalName = "socialactivity",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N Quote_SyncErrors</summary>
			public static readonly XrmFakedRelationship QuoteSyncErrors = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "quoteid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "quote",
					Entity2LogicalName = "syncerror",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N Quote_Tasks</summary>
			public static readonly XrmFakedRelationship QuoteTasks = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "quoteid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "quote",
					Entity2LogicalName = "task",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N slakpiinstance_quote</summary>
			public static readonly XrmFakedRelationship SlakpiinstanceQuote = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "quoteid",
					Entity2Attribute = "regarding",
					Entity1LogicalName = "quote",
					Entity2LogicalName = "slakpiinstance",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
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

		}
		#endregion

		#region Fake
		public static Quote Create()
		{
			var faker = new Faker<Quote>()
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
			.RuleFor(e => e.ClosedOn, fake => fake.Date.Soon())
			.RuleFor(e => e.Contactidname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Contactidyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.Createdbyname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Createdbyyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.CreatedOn, fake => fake.Date.Soon())
			.RuleFor(e => e.Createdonbehalfbyname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Createdonbehalfbyyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.Customeridname, fake => fake.Lorem.Word())
			.RuleFor(e => e.PotentialCustomerType, fake => fake.Lorem.Word())
			.RuleFor(e => e.Customeridyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.Description, fake => fake.Lorem.Word())
			.RuleFor(e => e.QuoteDiscountAmount, fake => fake.Finance.Amount())
			.RuleFor(e => e.QuoteDiscount, fake => fake.Finance.Amount())
			.RuleFor(e => e.EffectiveFrom, fake => fake.Date.Soon())
			.RuleFor(e => e.EffectiveTo, fake => fake.Date.Soon())
			.RuleFor(e => e.EmailAddress, fake => fake.Lorem.Word())
			.RuleFor(e => e.ExchangeRate, fake => fake.Finance.Amount())
			.RuleFor(e => e.DueBy, fake => fake.Date.Soon())
			.RuleFor(e => e.FreightAmount, fake => fake.Finance.Amount())
			.RuleFor(e => e.FreightTerms, fake => fake.PickRandom<Quote.eFreightTerms>())
			.RuleFor(e => e.ImportSequenceNumber, fake => fake.Random.Int())
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
			.RuleFor(e => e.PaymentTerms, fake => fake.PickRandom<Quote.ePaymentTerms>())
			.RuleFor(e => e.Pricelevelidname, fake => fake.Lorem.Word())
			.RuleFor(e => e.PricingError, fake => fake.PickRandom<Quote.egPricingError>())
			.RuleFor(e => e.ProcessId, fake => Guid.NewGuid())
			.RuleFor(e => e.Id, fake => Guid.NewGuid())
			.RuleFor(e => e.QuoteID, fake => fake.Lorem.Word())
			.RuleFor(e => e.RequestedDeliveryDate, fake => fake.Date.Soon())
			.RuleFor(e => e.RevisionID, fake => fake.Random.Int())
			.RuleFor(e => e.ShippingMethod, fake => fake.PickRandom<Quote.eShippingMethod>())
			.RuleFor(e => e.ShipToAddressId, fake => Guid.NewGuid())
			.RuleFor(e => e.ShipToCity, fake => fake.Lorem.Word())
			.RuleFor(e => e.ShipToAddress, fake => fake.Lorem.Word())
			.RuleFor(e => e.ShipToContactName, fake => fake.Lorem.Word())
			.RuleFor(e => e.ShipToCountryRegion, fake => fake.Lorem.Word())
			.RuleFor(e => e.ShipToFax, fake => fake.Lorem.Word())
			.RuleFor(e => e.ShipToFreightTerms, fake => fake.PickRandom<Quote.eShipToFreightTerms>())
			.RuleFor(e => e.ShipToStreet1, fake => fake.Lorem.Word())
			.RuleFor(e => e.ShipToStreet2, fake => fake.Lorem.Word())
			.RuleFor(e => e.ShipToStreet3, fake => fake.Lorem.Word())
			.RuleFor(e => e.ShipToName, fake => fake.Lorem.Word())
			.RuleFor(e => e.ShipToZIPPostalCode, fake => fake.Lorem.Word())
			.RuleFor(e => e.ShipToStateProvince, fake => fake.Lorem.Word())
			.RuleFor(e => e.ShipToPhone, fake => fake.Lorem.Word())
			.RuleFor(e => e.SkipPriceCalculation, fake => fake.PickRandom<Quote.egSkipPriceCalculationOptionSet>())
			.RuleFor(e => e.Slainvokedidname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Slaname, fake => fake.Lorem.Word())
			.RuleFor(e => e.DeprecatedStageId, fake => Guid.NewGuid())
			.RuleFor(e => e.Status, fake => fake.PickRandom<Quote.eStatus>())
			.RuleFor(e => e.StatusReason, fake => fake.PickRandom<Quote.eStatusReason>())
			.RuleFor(e => e.TimeZoneRuleVersionNumber, fake => fake.Random.Int())
			.RuleFor(e => e.TotalAmount, fake => fake.Finance.Amount())
			.RuleFor(e => e.TotalPreFreightAmount, fake => fake.Finance.Amount())
			.RuleFor(e => e.TotalDiscountAmount, fake => fake.Finance.Amount())
			.RuleFor(e => e.TotalDetailAmount, fake => fake.Finance.Amount())
			.RuleFor(e => e.TotalLineItemDiscountAmount, fake => fake.Finance.Amount())
			.RuleFor(e => e.TotalTax, fake => fake.Finance.Amount())
			.RuleFor(e => e.Transactioncurrencyidname, fake => fake.Lorem.Word())
			.RuleFor(e => e.DeprecatedTraversedPath, fake => fake.Lorem.Word())
			.RuleFor(e => e.UniqueDscId, fake => Guid.NewGuid())
			.RuleFor(e => e.UTCConversionTimeZoneCode, fake => fake.Random.Int())
			.RuleFor(e => e.VersionNumber, fake => fake.Random.Int())
			.RuleFor(e => e.ShipTo, fake => fake.Random.Bool());
			return faker.Generate();
		}
		#endregion
	}
}

