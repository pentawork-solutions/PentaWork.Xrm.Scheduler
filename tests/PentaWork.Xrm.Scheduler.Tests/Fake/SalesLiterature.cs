using Bogus;
using System;
using FakeXrmEasy;
using System.Collections.Generic;
using PentaWork.Xrm.Scheduler.Proxies.Entities;

namespace PentaWork.Xrm.Scheduler.Tests.Fake
{
	public static class FakeSalesLiterature
	{	
		#region FakeRelationships
		public static class Relationships 
		{
			/// <summary>1:N sales_literature_items</summary>
			public static readonly XrmFakedRelationship SalesLiteratureItems = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "salesliteratureid",
					Entity2Attribute = "salesliteratureid",
					Entity1LogicalName = "salesliterature",
					Entity2LogicalName = "salesliteratureitem",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N SalesLiterature_AsyncOperations</summary>
			public static readonly XrmFakedRelationship SalesLiteratureAsyncOperations = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "salesliteratureid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "salesliterature",
					Entity2LogicalName = "asyncoperation",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N SalesLiterature_BulkDeleteFailures</summary>
			public static readonly XrmFakedRelationship SalesLiteratureBulkDeleteFailures = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "salesliteratureid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "salesliterature",
					Entity2LogicalName = "bulkdeletefailure",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N salesliterature_MailboxTrackingFolders</summary>
			public static readonly XrmFakedRelationship SalesliteratureMailboxTrackingFolders = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "salesliteratureid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "salesliterature",
					Entity2LogicalName = "mailboxtrackingfolder",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N salesliterature_principalobjectattributeaccess</summary>
			public static readonly XrmFakedRelationship SalesliteraturePrincipalobjectattributeaccess = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "salesliteratureid",
					Entity2Attribute = "objectid",
					Entity1LogicalName = "salesliterature",
					Entity2LogicalName = "principalobjectattributeaccess",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N SalesLiterature_ProcessSessions</summary>
			public static readonly XrmFakedRelationship SalesLiteratureProcessSessions = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "salesliteratureid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "salesliterature",
					Entity2LogicalName = "processsession",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N SalesLiterature_SharepointDocumentLocation</summary>
			public static readonly XrmFakedRelationship SalesLiteratureSharepointDocumentLocation = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "salesliteratureid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "salesliterature",
					Entity2LogicalName = "sharepointdocumentlocation",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N SalesLiterature_SyncErrors</summary>
			public static readonly XrmFakedRelationship SalesLiteratureSyncErrors = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "salesliteratureid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "salesliterature",
					Entity2LogicalName = "syncerror",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>N:N campaignactivitysalesliterature_association</summary>
			public static readonly XrmFakedRelationship CampaignactivitysalesliteratureAssociation = 
				new XrmFakedRelationship
				{
					IntersectEntity = "campaignactivitysalesliterature_association",
					Entity1Attribute = "campaignactivityid",
					Entity2Attribute = "itemid",
					Entity1LogicalName = "campaignactivity",
					Entity2LogicalName = "salesliterature",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.ManyToMany
				};

			/// <summary>N:N campaignsalesliterature_association</summary>
			public static readonly XrmFakedRelationship CampaignsalesliteratureAssociation = 
				new XrmFakedRelationship
				{
					IntersectEntity = "campaignsalesliterature_association",
					Entity1Attribute = "campaignid",
					Entity2Attribute = "entityid",
					Entity1LogicalName = "campaign",
					Entity2LogicalName = "salesliterature",
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

			/// <summary>N:N productsalesliterature_association</summary>
			public static readonly XrmFakedRelationship ProductsalesliteratureAssociation = 
				new XrmFakedRelationship
				{
					IntersectEntity = "productsalesliterature_association",
					Entity1Attribute = "productid",
					Entity2Attribute = "salesliteratureid",
					Entity1LogicalName = "product",
					Entity2LogicalName = "salesliterature",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.ManyToMany
				};

		}
		#endregion

		#region Fake
		public static SalesLiterature Create()
		{
			var faker = new Faker<SalesLiterature>()
			.RuleFor(e => e.Createdbyname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Createdbyyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.CreatedOn, fake => fake.Date.Soon())
			.RuleFor(e => e.Createdonbehalfbyname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Createdonbehalfbyyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.Description, fake => fake.Lorem.Word())
			.RuleFor(e => e.Employeecontactidname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Employeecontactidyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.EntityimageTimestamp, fake => fake.Random.Int())
			.RuleFor(e => e.EntityimageUrl, fake => fake.Lorem.Word())
			.RuleFor(e => e.EntityimageId, fake => Guid.NewGuid())
			.RuleFor(e => e.ExchangeRate, fake => fake.Finance.Amount())
			.RuleFor(e => e.ExpirationDate, fake => fake.Date.Soon())
			.RuleFor(e => e.HasAttachments, fake => fake.Random.Bool())
			.RuleFor(e => e.ImportSequenceNumber, fake => fake.Random.Int())
			.RuleFor(e => e.CustomerViewable, fake => fake.Random.Bool())
			.RuleFor(e => e.KeyWords, fake => fake.Lorem.Word())
			.RuleFor(e => e.Type, fake => fake.PickRandom<SalesLiterature.eType>())
			.RuleFor(e => e.Modifiedbyname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Modifiedbyyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.ModifiedOn, fake => fake.Date.Soon())
			.RuleFor(e => e.Modifiedonbehalfbyname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Modifiedonbehalfbyyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.Title, fake => fake.Lorem.Word())
			.RuleFor(e => e.Organizationidname, fake => fake.Lorem.Word())
			.RuleFor(e => e.RecordCreatedOn, fake => fake.Date.Soon())
			.RuleFor(e => e.ProcessId, fake => Guid.NewGuid())
			.RuleFor(e => e.Id, fake => Guid.NewGuid())
			.RuleFor(e => e.DeprecatedStageId, fake => Guid.NewGuid())
			.RuleFor(e => e.Subjectidname, fake => fake.Lorem.Word())
			.RuleFor(e => e.TimeZoneRuleVersionNumber, fake => fake.Random.Int())
			.RuleFor(e => e.Transactioncurrencyidname, fake => fake.Lorem.Word())
			.RuleFor(e => e.DeprecatedTraversedPath, fake => fake.Lorem.Word())
			.RuleFor(e => e.UTCConversionTimeZoneCode, fake => fake.Random.Int())
			.RuleFor(e => e.VersionNumber, fake => fake.Random.Int());
			return faker.Generate();
		}
		#endregion
	}
}

