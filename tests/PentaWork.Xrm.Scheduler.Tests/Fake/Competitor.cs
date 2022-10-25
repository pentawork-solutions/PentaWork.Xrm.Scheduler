using Bogus;
using System;
using FakeXrmEasy;
using System.Collections.Generic;
using PentaWork.Xrm.Scheduler.Proxies.Entities;

namespace PentaWork.Xrm.Scheduler.Tests.Fake
{
	public static class FakeCompetitor
	{	
		#region FakeRelationships
		public static class Relationships 
		{
			/// <summary>1:N competitor_addresses</summary>
			public static readonly XrmFakedRelationship CompetitorAddresses = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "competitorid",
					Entity2Attribute = "parentid",
					Entity1LogicalName = "competitor",
					Entity2LogicalName = "competitoraddress",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N Competitor_Annotation</summary>
			public static readonly XrmFakedRelationship CompetitorAnnotation = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "competitorid",
					Entity2Attribute = "objectid",
					Entity1LogicalName = "competitor",
					Entity2LogicalName = "annotation",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N Competitor_AsyncOperations</summary>
			public static readonly XrmFakedRelationship CompetitorAsyncOperations = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "competitorid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "competitor",
					Entity2LogicalName = "asyncoperation",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N Competitor_BulkDeleteFailures</summary>
			public static readonly XrmFakedRelationship CompetitorBulkDeleteFailures = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "competitorid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "competitor",
					Entity2LogicalName = "bulkdeletefailure",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N competitor_connections1</summary>
			public static readonly XrmFakedRelationship CompetitorConnections1 = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "competitorid",
					Entity2Attribute = "record1id",
					Entity1LogicalName = "competitor",
					Entity2LogicalName = "connection",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N competitor_connections2</summary>
			public static readonly XrmFakedRelationship CompetitorConnections2 = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "competitorid",
					Entity2Attribute = "record2id",
					Entity1LogicalName = "competitor",
					Entity2LogicalName = "connection",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N Competitor_DuplicateBaseRecord</summary>
			public static readonly XrmFakedRelationship CompetitorDuplicateBaseRecord = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "competitorid",
					Entity2Attribute = "baserecordid",
					Entity1LogicalName = "competitor",
					Entity2LogicalName = "duplicaterecord",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N Competitor_DuplicateMatchingRecord</summary>
			public static readonly XrmFakedRelationship CompetitorDuplicateMatchingRecord = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "competitorid",
					Entity2Attribute = "duplicaterecordid",
					Entity1LogicalName = "competitor",
					Entity2LogicalName = "duplicaterecord",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N competitor_MailboxTrackingFolders</summary>
			public static readonly XrmFakedRelationship CompetitorMailboxTrackingFolders = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "competitorid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "competitor",
					Entity2LogicalName = "mailboxtrackingfolder",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N competitor_opportunity_activities</summary>
			public static readonly XrmFakedRelationship CompetitorOpportunityActivities = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "competitorid",
					Entity2Attribute = "competitorid",
					Entity1LogicalName = "competitor",
					Entity2LogicalName = "opportunityclose",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N competitor_PostFollows</summary>
			public static readonly XrmFakedRelationship CompetitorPostFollows = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "competitorid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "competitor",
					Entity2LogicalName = "postfollow",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N competitor_principalobjectattributeaccess</summary>
			public static readonly XrmFakedRelationship CompetitorPrincipalobjectattributeaccess = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "competitorid",
					Entity2Attribute = "objectid",
					Entity1LogicalName = "competitor",
					Entity2LogicalName = "principalobjectattributeaccess",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N Competitor_ProcessSessions</summary>
			public static readonly XrmFakedRelationship CompetitorProcessSessions = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "competitorid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "competitor",
					Entity2LogicalName = "processsession",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N Competitor_SyncErrors</summary>
			public static readonly XrmFakedRelationship CompetitorSyncErrors = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "competitorid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "competitor",
					Entity2LogicalName = "syncerror",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>N:N competitorproduct_association</summary>
			public static readonly XrmFakedRelationship CompetitorproductAssociation = 
				new XrmFakedRelationship
				{
					IntersectEntity = "competitorproduct_association",
					Entity1Attribute = "competitorid",
					Entity2Attribute = "productid",
					Entity1LogicalName = "competitor",
					Entity2LogicalName = "product",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.ManyToMany
				};

			/// <summary>N:N competitorsalesliterature_association</summary>
			public static readonly XrmFakedRelationship CompetitorsalesliteratureAssociation = 
				new XrmFakedRelationship
				{
					IntersectEntity = "competitorsalesliterature_association",
					Entity1Attribute = "salesliteratureid",
					Entity2Attribute = "competitorid",
					Entity1LogicalName = "salesliterature",
					Entity2LogicalName = "competitor",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.ManyToMany
				};

			/// <summary>N:N leadcompetitors_association</summary>
			public static readonly XrmFakedRelationship LeadcompetitorsAssociation = 
				new XrmFakedRelationship
				{
					IntersectEntity = "leadcompetitors_association",
					Entity1Attribute = "leadid",
					Entity2Attribute = "competitorid",
					Entity1LogicalName = "lead",
					Entity2LogicalName = "competitor",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.ManyToMany
				};

			/// <summary>N:N opportunitycompetitors_association</summary>
			public static readonly XrmFakedRelationship OpportunitycompetitorsAssociation = 
				new XrmFakedRelationship
				{
					IntersectEntity = "opportunitycompetitors_association",
					Entity1Attribute = "opportunityid",
					Entity2Attribute = "competitorid",
					Entity1LogicalName = "opportunity",
					Entity2LogicalName = "competitor",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.ManyToMany
				};

		}
		#endregion

		#region Fake
		public static Competitor Create()
		{
			var faker = new Faker<Competitor>()
			.RuleFor(e => e.Address1Id, fake => Guid.NewGuid())
			.RuleFor(e => e.Address1AddressType, fake => fake.PickRandom<Competitor.eAddress1AddressType>())
			.RuleFor(e => e.City, fake => fake.Lorem.Word())
			.RuleFor(e => e.Address1, fake => fake.Lorem.Word())
			.RuleFor(e => e.CountryRegion, fake => fake.Lorem.Word())
			.RuleFor(e => e.Address1County, fake => fake.Lorem.Word())
			.RuleFor(e => e.Address1Fax, fake => fake.Lorem.Word())
			.RuleFor(e => e.Address1Latitude, fake => fake.Random.Double())
			.RuleFor(e => e.Street1, fake => fake.Lorem.Word())
			.RuleFor(e => e.Street2, fake => fake.Lorem.Word())
			.RuleFor(e => e.Street3, fake => fake.Lorem.Word())
			.RuleFor(e => e.Address1Longitude, fake => fake.Random.Double())
			.RuleFor(e => e.Address1Name, fake => fake.Lorem.Word())
			.RuleFor(e => e.ZIPPostalCode, fake => fake.Lorem.Word())
			.RuleFor(e => e.Address1PostOfficeBox, fake => fake.Lorem.Word())
			.RuleFor(e => e.Address1ShippingMethod, fake => fake.PickRandom<Competitor.eAddress1ShippingMethod>())
			.RuleFor(e => e.StateProvince, fake => fake.Lorem.Word())
			.RuleFor(e => e.Address1Telephone1, fake => fake.Lorem.Word())
			.RuleFor(e => e.Address1Telephone2, fake => fake.Lorem.Word())
			.RuleFor(e => e.Address1Telephone3, fake => fake.Lorem.Word())
			.RuleFor(e => e.Address1UPSZone, fake => fake.Lorem.Word())
			.RuleFor(e => e.Address1UTCOffset, fake => fake.Random.Int())
			.RuleFor(e => e.Address2Id, fake => Guid.NewGuid())
			.RuleFor(e => e.Address2AddressType, fake => fake.PickRandom<Competitor.eAddress2AddressType>())
			.RuleFor(e => e.Address2City, fake => fake.Lorem.Word())
			.RuleFor(e => e.Address2, fake => fake.Lorem.Word())
			.RuleFor(e => e.Address2CountryRegion, fake => fake.Lorem.Word())
			.RuleFor(e => e.Address2County, fake => fake.Lorem.Word())
			.RuleFor(e => e.Address2Fax, fake => fake.Lorem.Word())
			.RuleFor(e => e.Address2Latitude, fake => fake.Random.Double())
			.RuleFor(e => e.Address2Street1, fake => fake.Lorem.Word())
			.RuleFor(e => e.Address2Street2, fake => fake.Lorem.Word())
			.RuleFor(e => e.Address2Street3, fake => fake.Lorem.Word())
			.RuleFor(e => e.Address2Longitude, fake => fake.Random.Double())
			.RuleFor(e => e.Address2Name, fake => fake.Lorem.Word())
			.RuleFor(e => e.Address2ZIPPostalCode, fake => fake.Lorem.Word())
			.RuleFor(e => e.Address2PostOfficeBox, fake => fake.Lorem.Word())
			.RuleFor(e => e.Address2ShippingMethod, fake => fake.PickRandom<Competitor.eAddress2ShippingMethod>())
			.RuleFor(e => e.Address2StateProvince, fake => fake.Lorem.Word())
			.RuleFor(e => e.Address2Telephone1, fake => fake.Lorem.Word())
			.RuleFor(e => e.Address2Telephone2, fake => fake.Lorem.Word())
			.RuleFor(e => e.Address2Telephone3, fake => fake.Lorem.Word())
			.RuleFor(e => e.Address2UPSZone, fake => fake.Lorem.Word())
			.RuleFor(e => e.Address2UTCOffset, fake => fake.Random.Int())
			.RuleFor(e => e.Id, fake => Guid.NewGuid())
			.RuleFor(e => e.Createdbyname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Createdbyyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.CreatedOn, fake => fake.Date.Soon())
			.RuleFor(e => e.Createdonbehalfbyname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Createdonbehalfbyyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.EntityimageTimestamp, fake => fake.Random.Int())
			.RuleFor(e => e.EntityimageUrl, fake => fake.Lorem.Word())
			.RuleFor(e => e.EntityimageId, fake => Guid.NewGuid())
			.RuleFor(e => e.ExchangeRate, fake => fake.Finance.Amount())
			.RuleFor(e => e.ImportSequenceNumber, fake => fake.Random.Int())
			.RuleFor(e => e.KeyProduct, fake => fake.Lorem.Word())
			.RuleFor(e => e.Modifiedbyname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Modifiedbyyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.ModifiedOn, fake => fake.Date.Soon())
			.RuleFor(e => e.Modifiedonbehalfbyname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Modifiedonbehalfbyyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.Name, fake => fake.Lorem.Word())
			.RuleFor(e => e.Opportunity, fake => fake.Lorem.Word())
			.RuleFor(e => e.Organizationidname, fake => fake.Lorem.Word())
			.RuleFor(e => e.RecordCreatedOn, fake => fake.Date.Soon())
			.RuleFor(e => e.Overview, fake => fake.Lorem.Word())
			.RuleFor(e => e.ProcessId, fake => Guid.NewGuid())
			.RuleFor(e => e.ReferenceInfoURL, fake => fake.Lorem.Word())
			.RuleFor(e => e.ReportedRevenue, fake => fake.Finance.Amount())
			.RuleFor(e => e.ReportingQuarter, fake => fake.Random.Int())
			.RuleFor(e => e.ReportingYear, fake => fake.Random.Int())
			.RuleFor(e => e.DeprecatedStageId, fake => Guid.NewGuid())
			.RuleFor(e => e.StockExchange, fake => fake.Lorem.Word())
			.RuleFor(e => e.Strength, fake => fake.Lorem.Word())
			.RuleFor(e => e.Threat, fake => fake.Lorem.Word())
			.RuleFor(e => e.TickerSymbol, fake => fake.Lorem.Word())
			.RuleFor(e => e.TimeZoneRuleVersionNumber, fake => fake.Random.Int())
			.RuleFor(e => e.Transactioncurrencyidname, fake => fake.Lorem.Word())
			.RuleFor(e => e.DeprecatedTraversedPath, fake => fake.Lorem.Word())
			.RuleFor(e => e.UTCConversionTimeZoneCode, fake => fake.Random.Int())
			.RuleFor(e => e.VersionNumber, fake => fake.Random.Int())
			.RuleFor(e => e.Weakness, fake => fake.Lorem.Word())
			.RuleFor(e => e.Website, fake => fake.Lorem.Word())
			.RuleFor(e => e.WinPercentage, fake => fake.Random.Double())
			.RuleFor(e => e.YomiName, fake => fake.Lorem.Word());
			return faker.Generate();
		}
		#endregion
	}
}

