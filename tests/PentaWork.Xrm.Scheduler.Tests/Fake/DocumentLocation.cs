using Bogus;
using System;
using FakeXrmEasy;
using System.Collections.Generic;
using PentaWork.Xrm.Scheduler.Proxies.Entities;

namespace PentaWork.Xrm.Scheduler.Tests.Fake
{
	public static class FakeDocumentLocation
	{	
		#region FakeRelationships
		public static class Relationships 
		{
			/// <summary>1:N SharePointDocumentLocation_AsyncOperations</summary>
			public static readonly XrmFakedRelationship SharePointDocumentLocationAsyncOperations = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "sharepointdocumentlocationid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "sharepointdocumentlocation",
					Entity2LogicalName = "asyncoperation",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N SharePointDocumentLocation_DuplicateBaseRecord</summary>
			public static readonly XrmFakedRelationship SharePointDocumentLocationDuplicateBaseRecord = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "sharepointdocumentlocationid",
					Entity2Attribute = "baserecordid",
					Entity1LogicalName = "sharepointdocumentlocation",
					Entity2LogicalName = "duplicaterecord",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N SharePointDocumentLocation_DuplicateMatchingRecord</summary>
			public static readonly XrmFakedRelationship SharePointDocumentLocationDuplicateMatchingRecord = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "sharepointdocumentlocationid",
					Entity2Attribute = "duplicaterecordid",
					Entity1LogicalName = "sharepointdocumentlocation",
					Entity2LogicalName = "duplicaterecord",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N sharepointdocumentlocation_parent_sharepointdocumentlocation</summary>
			public static readonly XrmFakedRelationship SharepointdocumentlocationParentSharepointdocumentlocation = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "sharepointdocumentlocationid",
					Entity2Attribute = "parentsiteorlocation",
					Entity1LogicalName = "sharepointdocumentlocation",
					Entity2LogicalName = "sharepointdocumentlocation",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N sharepointdocumentlocation_principalobjectattributeaccess</summary>
			public static readonly XrmFakedRelationship SharepointdocumentlocationPrincipalobjectattributeaccess = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "sharepointdocumentlocationid",
					Entity2Attribute = "objectid",
					Entity1LogicalName = "sharepointdocumentlocation",
					Entity2LogicalName = "principalobjectattributeaccess",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N SharePointDocumentLocation_ProcessSessions</summary>
			public static readonly XrmFakedRelationship SharePointDocumentLocationProcessSessions = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "sharepointdocumentlocationid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "sharepointdocumentlocation",
					Entity2LogicalName = "processsession",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N SharePointDocumentLocation_SyncErrors</summary>
			public static readonly XrmFakedRelationship SharePointDocumentLocationSyncErrors = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "sharepointdocumentlocationid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "sharepointdocumentlocation",
					Entity2LogicalName = "syncerror",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

		}
		#endregion

		#region Fake
		public static DocumentLocation Create()
		{
			var faker = new Faker<DocumentLocation>()
			.RuleFor(e => e.AbsoluteURL, fake => fake.Lorem.Word())
			.RuleFor(e => e.Createdbyname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Createdbyyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.CreatedOn, fake => fake.Date.Soon())
			.RuleFor(e => e.Createdonbehalfbyname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Createdonbehalfbyyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.Description, fake => fake.Lorem.Word())
			.RuleFor(e => e.ExchangeRate, fake => fake.Finance.Amount())
			.RuleFor(e => e.ImportSequenceNumber, fake => fake.Random.Int())
			.RuleFor(e => e.LocationType, fake => fake.PickRandom<DocumentLocation.egLocationType>())
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
			.RuleFor(e => e.Parentsiteorlocationname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Parentsiteorlocationtypecode, fake => fake.Lorem.Word())
			.RuleFor(e => e.Regardingobjectidname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Regardingobjectidyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.Regardingobjecttypecode, fake => fake.Lorem.Word())
			.RuleFor(e => e.RelativeURL, fake => fake.Lorem.Word())
			.RuleFor(e => e.ServiceType, fake => fake.PickRandom<DocumentLocation.egServiceType>())
			.RuleFor(e => e.Id, fake => Guid.NewGuid())
			.RuleFor(e => e.SitecollectionId, fake => Guid.NewGuid())
			.RuleFor(e => e.Status, fake => fake.PickRandom<DocumentLocation.eStatus>())
			.RuleFor(e => e.StatusReason, fake => fake.PickRandom<DocumentLocation.eStatusReason>())
			.RuleFor(e => e.Timezoneruleversionnumber, fake => fake.Random.Int())
			.RuleFor(e => e.Transactioncurrencyidname, fake => fake.Lorem.Word())
			.RuleFor(e => e.SharePointDocumentLocationOwnerId, fake => Guid.NewGuid())
			.RuleFor(e => e.Utcconversiontimezonecode, fake => fake.Random.Int())
			.RuleFor(e => e.Versionnumber, fake => fake.Random.Int());
			return faker.Generate();
		}
		#endregion
	}
}

