using Bogus;
using System;
using FakeXrmEasy;
using System.Collections.Generic;
using PentaWork.Xrm.Scheduler.Proxies.Entities;

namespace PentaWork.Xrm.Scheduler.Tests.Fake
{
	public static class FakeProductRelationship
	{	
		#region FakeRelationships
		public static class Relationships 
		{
			/// <summary>1:N ProductSubstitute_AsyncOperations</summary>
			public static readonly XrmFakedRelationship ProductSubstituteAsyncOperations = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "productsubstituteid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "productsubstitute",
					Entity2LogicalName = "asyncoperation",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N ProductSubstitute_BulkDeleteFailures</summary>
			public static readonly XrmFakedRelationship ProductSubstituteBulkDeleteFailures = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "productsubstituteid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "productsubstitute",
					Entity2LogicalName = "bulkdeletefailure",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N productsubstitute_MailboxTrackingFolders</summary>
			public static readonly XrmFakedRelationship ProductsubstituteMailboxTrackingFolders = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "productsubstituteid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "productsubstitute",
					Entity2LogicalName = "mailboxtrackingfolder",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N ProductSubstitute_PrincipalObjectAttributeAccess</summary>
			public static readonly XrmFakedRelationship ProductSubstitutePrincipalObjectAttributeAccess = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "productsubstituteid",
					Entity2Attribute = "objectid",
					Entity1LogicalName = "productsubstitute",
					Entity2LogicalName = "principalobjectattributeaccess",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N ProductSubstitute_ProcessSession</summary>
			public static readonly XrmFakedRelationship ProductSubstituteProcessSession = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "productsubstituteid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "productsubstitute",
					Entity2LogicalName = "processsession",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N ProductSubstitute_SyncErrors</summary>
			public static readonly XrmFakedRelationship ProductSubstituteSyncErrors = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "productsubstituteid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "productsubstitute",
					Entity2LogicalName = "syncerror",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

		}
		#endregion

		#region Fake
		public static ProductRelationship Create()
		{
			var faker = new Faker<ProductRelationship>()
			.RuleFor(e => e.Createdbyname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Createdbyyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.CreatedOn, fake => fake.Date.Soon())
			.RuleFor(e => e.Createdonbehalfbyname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Createdonbehalfbyyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.Direction, fake => fake.PickRandom<ProductRelationship.eDirection>())
			.RuleFor(e => e.ExchangeRate, fake => fake.Finance.Amount())
			.RuleFor(e => e.ImportSequenceNumber, fake => fake.Random.Int())
			.RuleFor(e => e.Modifiedbyname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Modifiedbyyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.ModifiedOn, fake => fake.Date.Soon())
			.RuleFor(e => e.Modifiedonbehalfbyname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Modifiedonbehalfbyyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.Name, fake => fake.Lorem.Word())
			.RuleFor(e => e.Organizationidname, fake => fake.Lorem.Word())
			.RuleFor(e => e.RecordCreatedOn, fake => fake.Date.Soon())
			.RuleFor(e => e.Productidname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Id, fake => Guid.NewGuid())
			.RuleFor(e => e.SalesRelationshipType, fake => fake.PickRandom<ProductRelationship.eSalesRelationshipType>())
			.RuleFor(e => e.Status, fake => fake.PickRandom<ProductRelationship.eStatus>())
			.RuleFor(e => e.StatusReason, fake => fake.PickRandom<ProductRelationship.eStatusReason>())
			.RuleFor(e => e.Substitutedproductidname, fake => fake.Lorem.Word())
			.RuleFor(e => e.TimeZoneRuleVersionNumber, fake => fake.Random.Int())
			.RuleFor(e => e.Transactioncurrencyidname, fake => fake.Lorem.Word())
			.RuleFor(e => e.UTCConversionTimeZoneCode, fake => fake.Random.Int())
			.RuleFor(e => e.VersionNumber, fake => fake.Random.Int());
			return faker.Generate();
		}
		#endregion
	}
}

