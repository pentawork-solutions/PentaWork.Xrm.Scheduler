using Bogus;
using System;
using FakeXrmEasy;
using System.Collections.Generic;
using PentaWork.Xrm.Scheduler.Proxies.Entities;

namespace PentaWork.Xrm.Scheduler.Tests.Fake
{
	public static class FakeOpportunityProduct
	{	
		#region FakeRelationships
		public static class Relationships 
		{
			/// <summary>1:N OpportunityProduct_AsyncOperations</summary>
			public static readonly XrmFakedRelationship OpportunityProductAsyncOperations = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "opportunityproductid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "opportunityproduct",
					Entity2LogicalName = "asyncoperation",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N OpportunityProduct_BulkDeleteFailures</summary>
			public static readonly XrmFakedRelationship OpportunityProductBulkDeleteFailures = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "opportunityproductid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "opportunityproduct",
					Entity2LogicalName = "bulkdeletefailure",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N OpportunityProduct_Dynamicpropertyinstance</summary>
			public static readonly XrmFakedRelationship OpportunityProductDynamicpropertyinstance = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "opportunityproductid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "opportunityproduct",
					Entity2LogicalName = "dynamicpropertyinstance",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N opportunityproduct_MailboxTrackingFolders</summary>
			public static readonly XrmFakedRelationship OpportunityproductMailboxTrackingFolders = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "opportunityproductid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "opportunityproduct",
					Entity2LogicalName = "mailboxtrackingfolder",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N opportunityproduct_parent_opportunityproduct</summary>
			public static readonly XrmFakedRelationship OpportunityproductParentOpportunityproduct = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "opportunityproductid",
					Entity2Attribute = "parentbundleid",
					Entity1LogicalName = "opportunityproduct",
					Entity2LogicalName = "opportunityproduct",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N opportunityproduct_parentref_opportunityproduct</summary>
			public static readonly XrmFakedRelationship OpportunityproductParentrefOpportunityproduct = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "opportunityproductid",
					Entity2Attribute = "parentbundleidref",
					Entity1LogicalName = "opportunityproduct",
					Entity2LogicalName = "opportunityproduct",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N opportunityproduct_principalobjectattributeaccess</summary>
			public static readonly XrmFakedRelationship OpportunityproductPrincipalobjectattributeaccess = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "opportunityproductid",
					Entity2Attribute = "objectid",
					Entity1LogicalName = "opportunityproduct",
					Entity2LogicalName = "principalobjectattributeaccess",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N OpportunityProduct_ProcessSessions</summary>
			public static readonly XrmFakedRelationship OpportunityProductProcessSessions = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "opportunityproductid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "opportunityproduct",
					Entity2LogicalName = "processsession",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N OpportunityProduct_SyncErrors</summary>
			public static readonly XrmFakedRelationship OpportunityProductSyncErrors = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "opportunityproductid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "opportunityproduct",
					Entity2LogicalName = "syncerror",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

		}
		#endregion

		#region Fake
		public static OpportunityProduct Create()
		{
			var faker = new Faker<OpportunityProduct>()
			.RuleFor(e => e.Amount, fake => fake.Finance.Amount())
			.RuleFor(e => e.Createdbyname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Createdbyyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.CreatedOn, fake => fake.Date.Soon())
			.RuleFor(e => e.Createdonbehalfbyname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Createdonbehalfbyyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.Description, fake => fake.Lorem.Word())
			.RuleFor(e => e.EntityimageTimestamp, fake => fake.Random.Int())
			.RuleFor(e => e.EntityimageUrl, fake => fake.Lorem.Word())
			.RuleFor(e => e.EntityimageId, fake => Guid.NewGuid())
			.RuleFor(e => e.ExchangeRate, fake => fake.Finance.Amount())
			.RuleFor(e => e.ExtendedAmount, fake => fake.Finance.Amount())
			.RuleFor(e => e.ImportSequenceNumber, fake => fake.Random.Int())
			.RuleFor(e => e.PriceOverridden, fake => fake.Random.Bool())
			.RuleFor(e => e.SelectProduct, fake => fake.Random.Bool())
			.RuleFor(e => e.LineItemNumber, fake => fake.Random.Int())
			.RuleFor(e => e.ManualDiscountAmount, fake => fake.Finance.Amount())
			.RuleFor(e => e.Modifiedbyname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Modifiedbyyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.ModifiedOn, fake => fake.Date.Soon())
			.RuleFor(e => e.Modifiedonbehalfbyname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Modifiedonbehalfbyyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.Opportunityidname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Id, fake => Guid.NewGuid())
			.RuleFor(e => e.Name, fake => fake.Lorem.Word())
			.RuleFor(e => e.OpportunityStatus, fake => fake.PickRandom<OpportunityProduct.eOpportunityStatus>())
			.RuleFor(e => e.RecordCreatedOn, fake => fake.Date.Soon())
			.RuleFor(e => e.Owneridname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Owneridtype, fake => fake.Lorem.Word())
			.RuleFor(e => e.Owneridyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.ParentBundleId, fake => Guid.NewGuid())
			.RuleFor(e => e.PricePerUnit, fake => fake.Finance.Amount())
			.RuleFor(e => e.PricingError, fake => fake.PickRandom<OpportunityProduct.egPricingError>())
			.RuleFor(e => e.BundleItemAssociationId, fake => Guid.NewGuid())
			.RuleFor(e => e.WriteInProduct, fake => fake.Lorem.Word())
			.RuleFor(e => e.Productidname, fake => fake.Lorem.Word())
			.RuleFor(e => e.ProductName, fake => fake.Lorem.Word())
			.RuleFor(e => e.ProductType, fake => fake.PickRandom<OpportunityProduct.egProductType>())
			.RuleFor(e => e.PropertyConfiguration, fake => fake.PickRandom<OpportunityProduct.egPropertiesConfiguration>())
			.RuleFor(e => e.Quantity, fake => fake.Finance.Amount())
			.RuleFor(e => e.SequenceNumber, fake => fake.Random.Int())
			.RuleFor(e => e.SkipPriceCalculation, fake => fake.PickRandom<OpportunityProduct.egSkipPriceCalculationOptionSet>())
			.RuleFor(e => e.Tax, fake => fake.Finance.Amount())
			.RuleFor(e => e.TimeZoneRuleVersionNumber, fake => fake.Random.Int())
			.RuleFor(e => e.Transactioncurrencyidname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Uomidname, fake => fake.Lorem.Word())
			.RuleFor(e => e.UTCConversionTimeZoneCode, fake => fake.Random.Int())
			.RuleFor(e => e.VersionNumber, fake => fake.Random.Int())
			.RuleFor(e => e.VolumeDiscount, fake => fake.Finance.Amount());
			return faker.Generate();
		}
		#endregion
	}
}

