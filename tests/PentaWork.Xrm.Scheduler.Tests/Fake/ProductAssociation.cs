using Bogus;
using System;
using FakeXrmEasy;
using System.Collections.Generic;
using PentaWork.Xrm.Scheduler.Proxies.Entities;

namespace PentaWork.Xrm.Scheduler.Tests.Fake
{
	public static class FakeProductAssociation
	{	
		#region FakeRelationships
		public static class Relationships 
		{
			/// <summary>1:N ProductAssociation_AsyncOperations</summary>
			public static readonly XrmFakedRelationship ProductAssociationAsyncOperations = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "productassociationid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "productassociation",
					Entity2LogicalName = "asyncoperation",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N productassociation_BulkDeleteFailures</summary>
			public static readonly XrmFakedRelationship ProductassociationBulkDeleteFailures = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "productassociationid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "productassociation",
					Entity2LogicalName = "bulkdeletefailure",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N ProductAssociation_DynamicProperty</summary>
			public static readonly XrmFakedRelationship ProductAssociationDynamicProperty = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "productassociationid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "productassociation",
					Entity2LogicalName = "dynamicproperty",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N ProductAssociation_DynamicPropertyAssociation</summary>
			public static readonly XrmFakedRelationship ProductAssociationDynamicPropertyAssociation = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "productassociationid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "productassociation",
					Entity2LogicalName = "dynamicpropertyassociation",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N productAssociation_invoice_details</summary>
			public static readonly XrmFakedRelationship ProductAssociationInvoiceDetails = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "productassociationid",
					Entity2Attribute = "productassociationid",
					Entity1LogicalName = "productassociation",
					Entity2LogicalName = "invoicedetail",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N productassociation_MailboxTrackingFolders</summary>
			public static readonly XrmFakedRelationship ProductassociationMailboxTrackingFolders = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "productassociationid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "productassociation",
					Entity2LogicalName = "mailboxtrackingfolder",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N productAssociation_opportunity_product</summary>
			public static readonly XrmFakedRelationship ProductAssociationOpportunityProduct = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "productassociationid",
					Entity2Attribute = "productassociationid",
					Entity1LogicalName = "productassociation",
					Entity2LogicalName = "opportunityproduct",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N ProductAssociation_PrincipalObjectAttributeAccess</summary>
			public static readonly XrmFakedRelationship ProductAssociationPrincipalObjectAttributeAccess = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "productassociationid",
					Entity2Attribute = "objectid",
					Entity1LogicalName = "productassociation",
					Entity2LogicalName = "principalobjectattributeaccess",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N ProductAssociation_ProcessSessions</summary>
			public static readonly XrmFakedRelationship ProductAssociationProcessSessions = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "productassociationid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "productassociation",
					Entity2LogicalName = "processsession",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N productAssociation_quote_details</summary>
			public static readonly XrmFakedRelationship ProductAssociationQuoteDetails = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "productassociationid",
					Entity2Attribute = "productassociationid",
					Entity1LogicalName = "productassociation",
					Entity2LogicalName = "quotedetail",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N productAssociation_salesorder_details</summary>
			public static readonly XrmFakedRelationship ProductAssociationSalesorderDetails = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "productassociationid",
					Entity2Attribute = "productassociationid",
					Entity1LogicalName = "productassociation",
					Entity2LogicalName = "salesorderdetail",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N ProductAssociation_SyncErrors</summary>
			public static readonly XrmFakedRelationship ProductAssociationSyncErrors = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "productassociationid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "productassociation",
					Entity2LogicalName = "syncerror",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

		}
		#endregion

		#region Fake
		public static ProductAssociation Create()
		{
			var faker = new Faker<ProductAssociation>()
			.RuleFor(e => e.Associatedproductidname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Createdbyname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Createdbyyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.CreatedOn, fake => fake.Date.Soon())
			.RuleFor(e => e.Createdonbehalfbyname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Createdonbehalfbyyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.InternalUseOnly, fake => fake.Random.Int())
			.RuleFor(e => e.ExchangeRate, fake => fake.Finance.Amount())
			.RuleFor(e => e.ImportSequenceNumber, fake => fake.Random.Int())
			.RuleFor(e => e.Modifiedbyname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Modifiedbyyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.ModifiedOn, fake => fake.Date.Soon())
			.RuleFor(e => e.Modifiedonbehalfbyname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Modifiedonbehalfbyyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.Organizationidname, fake => fake.Lorem.Word())
			.RuleFor(e => e.RecordCreatedOn, fake => fake.Date.Soon())
			.RuleFor(e => e.Id, fake => Guid.NewGuid())
			.RuleFor(e => e.Productidname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Required, fake => fake.PickRandom<ProductAssociation.eIsProductRequired>())
			.RuleFor(e => e.PropertyCustomization, fake => fake.PickRandom<ProductAssociation.ePropertiesConfiguration>())
			.RuleFor(e => e.Quantity, fake => fake.Finance.Amount())
			.RuleFor(e => e.Status, fake => fake.PickRandom<ProductAssociation.eStatus>())
			.RuleFor(e => e.StatusReason, fake => fake.PickRandom<ProductAssociation.eStatusReason>())
			.RuleFor(e => e.TimeZoneRuleVersionNumber, fake => fake.Random.Int())
			.RuleFor(e => e.Transactioncurrencyidname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Uomidname, fake => fake.Lorem.Word())
			.RuleFor(e => e.UTCConversionTimeZoneCode, fake => fake.Random.Int())
			.RuleFor(e => e.VersionNumber, fake => fake.Random.Int());
			return faker.Generate();
		}
		#endregion
	}
}

