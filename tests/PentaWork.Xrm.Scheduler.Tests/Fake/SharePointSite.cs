using Bogus;
using System;
using FakeXrmEasy;
using System.Collections.Generic;
using PentaWork.Xrm.Scheduler.Proxies.Entities;

namespace PentaWork.Xrm.Scheduler.Tests.Fake
{
	public static class FakeSharePointSite
	{	
		#region FakeRelationships
		public static class Relationships 
		{
			/// <summary>1:N sharepointdocumentlocation_parent_sharepointsite</summary>
			public static readonly XrmFakedRelationship SharepointdocumentlocationParentSharepointsite = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "sharepointsiteid",
					Entity2Attribute = "parentsiteorlocation",
					Entity1LogicalName = "sharepointsite",
					Entity2LogicalName = "sharepointdocumentlocation",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N SharePointSite_AsyncOperations</summary>
			public static readonly XrmFakedRelationship SharePointSiteAsyncOperations = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "sharepointsiteid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "sharepointsite",
					Entity2LogicalName = "asyncoperation",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N SharePointSite_DuplicateBaseRecord</summary>
			public static readonly XrmFakedRelationship SharePointSiteDuplicateBaseRecord = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "sharepointsiteid",
					Entity2Attribute = "baserecordid",
					Entity1LogicalName = "sharepointsite",
					Entity2LogicalName = "duplicaterecord",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N SharePointSite_DuplicateMatchingRecord</summary>
			public static readonly XrmFakedRelationship SharePointSiteDuplicateMatchingRecord = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "sharepointsiteid",
					Entity2Attribute = "duplicaterecordid",
					Entity1LogicalName = "sharepointsite",
					Entity2LogicalName = "duplicaterecord",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N sharepointsite_parentsite_sharepointsite</summary>
			public static readonly XrmFakedRelationship SharepointsiteParentsiteSharepointsite = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "sharepointsiteid",
					Entity2Attribute = "parentsite",
					Entity1LogicalName = "sharepointsite",
					Entity2LogicalName = "sharepointsite",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N sharepointsite_principalobjectattributeaccess</summary>
			public static readonly XrmFakedRelationship SharepointsitePrincipalobjectattributeaccess = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "sharepointsiteid",
					Entity2Attribute = "objectid",
					Entity1LogicalName = "sharepointsite",
					Entity2LogicalName = "principalobjectattributeaccess",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N SharePointSite_ProcessSessions</summary>
			public static readonly XrmFakedRelationship SharePointSiteProcessSessions = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "sharepointsiteid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "sharepointsite",
					Entity2LogicalName = "processsession",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N SharePointSite_SyncErrors</summary>
			public static readonly XrmFakedRelationship SharePointSiteSyncErrors = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "sharepointsiteid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "sharepointsite",
					Entity2LogicalName = "syncerror",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

		}
		#endregion

		#region Fake
		public static SharePointSite Create()
		{
			var faker = new Faker<SharePointSite>()
			.RuleFor(e => e.AbsoluteURL, fake => fake.Lorem.Word())
			.RuleFor(e => e.Createdbyname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Createdbyyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.CreatedOn, fake => fake.Date.Soon())
			.RuleFor(e => e.Createdonbehalfbyname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Createdonbehalfbyyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.Description, fake => fake.Lorem.Word())
			.RuleFor(e => e.ExchangeRate, fake => fake.Finance.Amount())
			.RuleFor(e => e.EntityForSharePointFolderStructure, fake => fake.Lorem.Word())
			.RuleFor(e => e.ImportSequenceNumber, fake => fake.Random.Int())
			.RuleFor(e => e.DefaultSite, fake => fake.Random.Bool())
			.RuleFor(e => e.ListComponentIsInstalled, fake => fake.Random.Bool())
			.RuleFor(e => e.AllowEmbeddingOfPowerBIReports, fake => fake.Random.Bool())
			.RuleFor(e => e.LastValidated, fake => fake.Date.Soon())
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
			.RuleFor(e => e.Parentsitename, fake => fake.Lorem.Word())
			.RuleFor(e => e.Parentsiteobjecttypecode, fake => fake.Lorem.Word())
			.RuleFor(e => e.RelativeURL, fake => fake.Lorem.Word())
			.RuleFor(e => e.ServiceType, fake => fake.PickRandom<SharePointSite.egServiceType>())
			.RuleFor(e => e.Id, fake => Guid.NewGuid())
			.RuleFor(e => e.SitecollectionId, fake => Guid.NewGuid())
			.RuleFor(e => e.Status, fake => fake.PickRandom<SharePointSite.eStatus>())
			.RuleFor(e => e.StatusReason, fake => fake.PickRandom<SharePointSite.eStatusReason>())
			.RuleFor(e => e.Timezoneruleversionnumber, fake => fake.Random.Int())
			.RuleFor(e => e.Transactioncurrencyidname, fake => fake.Lorem.Word())
			.RuleFor(e => e.SharePointSiteOwnerId, fake => Guid.NewGuid())
			.RuleFor(e => e.Utcconversiontimezonecode, fake => fake.Random.Int())
			.RuleFor(e => e.LastValidationStatus, fake => fake.PickRandom<SharePointSite.egValidationStatus>())
			.RuleFor(e => e.AdditionalInformation, fake => fake.PickRandom<SharePointSite.egValidationStatusReason>())
			.RuleFor(e => e.Versionnumber, fake => fake.Random.Int());
			return faker.Generate();
		}
		#endregion
	}
}

