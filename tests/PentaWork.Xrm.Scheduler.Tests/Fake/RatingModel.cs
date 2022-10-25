using Bogus;
using System;
using FakeXrmEasy;
using System.Collections.Generic;
using PentaWork.Xrm.Scheduler.Proxies.Entities;

namespace PentaWork.Xrm.Scheduler.Tests.Fake
{
	public static class FakeRatingModel
	{	
		#region FakeRelationships
		public static class Relationships 
		{
			/// <summary>1:N ratingmodel_AsyncOperations</summary>
			public static readonly XrmFakedRelationship RatingmodelAsyncOperations = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "ratingmodelid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "ratingmodel",
					Entity2LogicalName = "asyncoperation",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N ratingmodel_BulkDeleteFailures</summary>
			public static readonly XrmFakedRelationship RatingmodelBulkDeleteFailures = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "ratingmodelid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "ratingmodel",
					Entity2LogicalName = "bulkdeletefailure",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N ratingmodel_DuplicateBaseRecord</summary>
			public static readonly XrmFakedRelationship RatingmodelDuplicateBaseRecord = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "ratingmodelid",
					Entity2Attribute = "baserecordid",
					Entity1LogicalName = "ratingmodel",
					Entity2LogicalName = "duplicaterecord",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N ratingmodel_DuplicateMatchingRecord</summary>
			public static readonly XrmFakedRelationship RatingmodelDuplicateMatchingRecord = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "ratingmodelid",
					Entity2Attribute = "duplicaterecordid",
					Entity1LogicalName = "ratingmodel",
					Entity2LogicalName = "duplicaterecord",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N ratingmodel_MailboxTrackingFolders</summary>
			public static readonly XrmFakedRelationship RatingmodelMailboxTrackingFolders = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "ratingmodelid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "ratingmodel",
					Entity2LogicalName = "mailboxtrackingfolder",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N ratingmodel_PrincipalObjectAttributeAccess</summary>
			public static readonly XrmFakedRelationship RatingmodelPrincipalObjectAttributeAccess = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "ratingmodelid",
					Entity2Attribute = "objectid",
					Entity1LogicalName = "ratingmodel",
					Entity2LogicalName = "principalobjectattributeaccess",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N ratingmodel_ProcessSession</summary>
			public static readonly XrmFakedRelationship RatingmodelProcessSession = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "ratingmodelid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "ratingmodel",
					Entity2LogicalName = "processsession",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N ratingmodel_ratingvalue_RatingModel</summary>
			public static readonly XrmFakedRelationship RatingmodelRatingvalueRatingModel = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "ratingmodelid",
					Entity2Attribute = "ratingmodel",
					Entity1LogicalName = "ratingmodel",
					Entity2LogicalName = "ratingvalue",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N RatingModel_SyncErrors</summary>
			public static readonly XrmFakedRelationship RatingModelSyncErrors = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "ratingmodelid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "ratingmodel",
					Entity2LogicalName = "syncerror",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

		}
		#endregion

		#region Fake
		public static RatingModel Create()
		{
			var faker = new Faker<RatingModel>()
			.RuleFor(e => e.Createdbyname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Createdbyyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.CreatedOn, fake => fake.Date.Soon())
			.RuleFor(e => e.Createdonbehalfbyname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Createdonbehalfbyyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.ExchangeRate, fake => fake.Finance.Amount())
			.RuleFor(e => e.ImportSequenceNumber, fake => fake.Random.Int())
			.RuleFor(e => e.MaxRatingValue, fake => fake.Random.Int())
			.RuleFor(e => e.MinRatingValue, fake => fake.Random.Int())
			.RuleFor(e => e.Modifiedbyname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Modifiedbyyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.ModifiedOn, fake => fake.Date.Soon())
			.RuleFor(e => e.Modifiedonbehalfbyname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Modifiedonbehalfbyyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.Name, fake => fake.Lorem.Word())
			.RuleFor(e => e.RecordCreatedOn, fake => fake.Date.Soon())
			.RuleFor(e => e.Owneridname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Owneridtype, fake => fake.Lorem.Word())
			.RuleFor(e => e.Owneridyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.Id, fake => Guid.NewGuid())
			.RuleFor(e => e.Status, fake => fake.PickRandom<RatingModel.eStatus>())
			.RuleFor(e => e.StatusReason, fake => fake.PickRandom<RatingModel.eStatusReason>())
			.RuleFor(e => e.TimeZoneRuleVersionNumber, fake => fake.Random.Int())
			.RuleFor(e => e.Transactioncurrencyidname, fake => fake.Lorem.Word())
			.RuleFor(e => e.UTCConversionTimeZoneCode, fake => fake.Random.Int())
			.RuleFor(e => e.VersionNumber, fake => fake.Random.Int());
			return faker.Generate();
		}
		#endregion
	}
}

