using Bogus;
using System;
using FakeXrmEasy;
using System.Collections.Generic;
using PentaWork.Xrm.Scheduler.Proxies.Entities;

namespace PentaWork.Xrm.Scheduler.Tests.Fake
{
	public static class FakeMarketingFormDisplayAttributes
	{	
		#region FakeRelationships
		public static class Relationships 
		{
			/// <summary>1:N marketingformdisplayattributes_AsyncOperations</summary>
			public static readonly XrmFakedRelationship MarketingformdisplayattributesAsyncOperations = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "marketingformdisplayattributesid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "marketingformdisplayattributes",
					Entity2LogicalName = "asyncoperation",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N marketingformdisplayattributes_BulkDeleteFailures</summary>
			public static readonly XrmFakedRelationship MarketingformdisplayattributesBulkDeleteFailures = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "marketingformdisplayattributesid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "marketingformdisplayattributes",
					Entity2LogicalName = "bulkdeletefailure",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N marketingformdisplayattributes_DuplicateBaseRecord</summary>
			public static readonly XrmFakedRelationship MarketingformdisplayattributesDuplicateBaseRecord = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "marketingformdisplayattributesid",
					Entity2Attribute = "baserecordid",
					Entity1LogicalName = "marketingformdisplayattributes",
					Entity2LogicalName = "duplicaterecord",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N marketingformdisplayattributes_DuplicateMatchingRecord</summary>
			public static readonly XrmFakedRelationship MarketingformdisplayattributesDuplicateMatchingRecord = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "marketingformdisplayattributesid",
					Entity2Attribute = "duplicaterecordid",
					Entity1LogicalName = "marketingformdisplayattributes",
					Entity2LogicalName = "duplicaterecord",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N marketingformdisplayattributes_MailboxTrackingFolders</summary>
			public static readonly XrmFakedRelationship MarketingformdisplayattributesMailboxTrackingFolders = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "marketingformdisplayattributesid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "marketingformdisplayattributes",
					Entity2LogicalName = "mailboxtrackingfolder",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N marketingformdisplayattributes_PrincipalObjectAttributeAccesses</summary>
			public static readonly XrmFakedRelationship MarketingformdisplayattributesPrincipalObjectAttributeAccesses = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "marketingformdisplayattributesid",
					Entity2Attribute = "objectid",
					Entity1LogicalName = "marketingformdisplayattributes",
					Entity2LogicalName = "principalobjectattributeaccess",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N marketingformdisplayattributes_ProcessSession</summary>
			public static readonly XrmFakedRelationship MarketingformdisplayattributesProcessSession = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "marketingformdisplayattributesid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "marketingformdisplayattributes",
					Entity2LogicalName = "processsession",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N marketingformdisplayattributes_SyncErrors</summary>
			public static readonly XrmFakedRelationship MarketingformdisplayattributesSyncErrors = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "marketingformdisplayattributesid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "marketingformdisplayattributes",
					Entity2LogicalName = "syncerror",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

		}
		#endregion

		#region Fake
		public static MarketingFormDisplayAttributes Create()
		{
			var faker = new Faker<MarketingFormDisplayAttributes>()
			.RuleFor(e => e.Createdbyname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Createdbyyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.CreatedOn, fake => fake.Date.Soon())
			.RuleFor(e => e.Createdonbehalfbyname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Createdonbehalfbyyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.DisplayAttributesList, fake => fake.Lorem.Word())
			.RuleFor(e => e.EntityName, fake => fake.Lorem.Word())
			.RuleFor(e => e.ImportSequenceNumber, fake => fake.Random.Int())
			.RuleFor(e => e.Id, fake => Guid.NewGuid())
			.RuleFor(e => e.Modifiedbyname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Modifiedbyyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.ModifiedOn, fake => fake.Date.Soon())
			.RuleFor(e => e.Modifiedonbehalfbyname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Modifiedonbehalfbyyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.Name, fake => fake.Lorem.Word())
			.RuleFor(e => e.Organizationidname, fake => fake.Lorem.Word())
			.RuleFor(e => e.RecordCreatedOn, fake => fake.Date.Soon())
			.RuleFor(e => e.Status, fake => fake.PickRandom<MarketingFormDisplayAttributes.eStatus>())
			.RuleFor(e => e.StatusReason, fake => fake.PickRandom<MarketingFormDisplayAttributes.eStatusReason>())
			.RuleFor(e => e.TimeZoneRuleVersionNumber, fake => fake.Random.Int())
			.RuleFor(e => e.UTCConversionTimeZoneCode, fake => fake.Random.Int())
			.RuleFor(e => e.VersionNumber, fake => fake.Random.Int());
			return faker.Generate();
		}
		#endregion
	}
}

