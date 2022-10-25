using Bogus;
using System;
using FakeXrmEasy;
using System.Collections.Generic;
using PentaWork.Xrm.Scheduler.Proxies.Entities;

namespace PentaWork.Xrm.Scheduler.Tests.Fake
{
	public static class FakeDiscount
	{	
		#region FakeRelationships
		public static class Relationships 
		{
			/// <summary>1:N Discount_AsyncOperations</summary>
			public static readonly XrmFakedRelationship DiscountAsyncOperations = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "discountid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "discount",
					Entity2LogicalName = "asyncoperation",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N Discount_BulkDeleteFailures</summary>
			public static readonly XrmFakedRelationship DiscountBulkDeleteFailures = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "discountid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "discount",
					Entity2LogicalName = "bulkdeletefailure",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N discount_MailboxTrackingFolders</summary>
			public static readonly XrmFakedRelationship DiscountMailboxTrackingFolders = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "discountid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "discount",
					Entity2LogicalName = "mailboxtrackingfolder",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N discount_PrincipalObjectAttributeAccesses</summary>
			public static readonly XrmFakedRelationship DiscountPrincipalObjectAttributeAccesses = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "discountid",
					Entity2Attribute = "objectid",
					Entity1LogicalName = "discount",
					Entity2LogicalName = "principalobjectattributeaccess",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N Discount_ProcessSessions</summary>
			public static readonly XrmFakedRelationship DiscountProcessSessions = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "discountid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "discount",
					Entity2LogicalName = "processsession",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N Discount_SyncErrors</summary>
			public static readonly XrmFakedRelationship DiscountSyncErrors = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "discountid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "discount",
					Entity2LogicalName = "syncerror",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

		}
		#endregion

		#region Fake
		public static Discount Create()
		{
			var faker = new Faker<Discount>()
			.RuleFor(e => e.Amount, fake => fake.Finance.Amount())
			.RuleFor(e => e.Createdbyname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Createdbyyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.CreatedOn, fake => fake.Date.Soon())
			.RuleFor(e => e.Createdonbehalfbyname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Createdonbehalfbyyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.Id, fake => Guid.NewGuid())
			.RuleFor(e => e.Discounttypeidname, fake => fake.Lorem.Word())
			.RuleFor(e => e.ExchangeRate, fake => fake.Finance.Amount())
			.RuleFor(e => e.EndQuantity, fake => fake.Finance.Amount())
			.RuleFor(e => e.ImportSequenceNumber, fake => fake.Random.Int())
			.RuleFor(e => e.AmountType, fake => fake.Random.Bool())
			.RuleFor(e => e.BeginQuantity, fake => fake.Finance.Amount())
			.RuleFor(e => e.Modifiedbyname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Modifiedbyyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.ModifiedOn, fake => fake.Date.Soon())
			.RuleFor(e => e.Modifiedonbehalfbyname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Modifiedonbehalfbyyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.Name, fake => fake.Lorem.Word())
			.RuleFor(e => e.OrganizationId, fake => Guid.NewGuid())
			.RuleFor(e => e.RecordCreatedOn, fake => fake.Date.Soon())
			.RuleFor(e => e.Percentage, fake => fake.Finance.Amount())
			.RuleFor(e => e.StatusReason, fake => fake.PickRandom<Discount.eStatusReason>())
			.RuleFor(e => e.TimeZoneRuleVersionNumber, fake => fake.Random.Int())
			.RuleFor(e => e.Transactioncurrencyidname, fake => fake.Lorem.Word())
			.RuleFor(e => e.UTCConversionTimeZoneCode, fake => fake.Random.Int())
			.RuleFor(e => e.VersionNumber, fake => fake.Random.Int());
			return faker.Generate();
		}
		#endregion
	}
}

