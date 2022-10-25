using Bogus;
using System;
using FakeXrmEasy;
using System.Collections.Generic;
using PentaWork.Xrm.Scheduler.Proxies.Entities;

namespace PentaWork.Xrm.Scheduler.Tests.Fake
{
	public static class FakeView
	{	
		#region FakeRelationships
		public static class Relationships 
		{
			/// <summary>1:N lk_mobileofflineprofileitem_savedquery</summary>
			public static readonly XrmFakedRelationship LkMobileofflineprofileitemSavedquery = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "savedqueryid",
					Entity2Attribute = "profileitemrule",
					Entity1LogicalName = "savedquery",
					Entity2LogicalName = "mobileofflineprofileitem",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N SavedQuery_AsyncOperations</summary>
			public static readonly XrmFakedRelationship SavedQueryAsyncOperations = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "savedqueryid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "savedquery",
					Entity2LogicalName = "asyncoperation",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N SavedQuery_BulkDeleteFailures</summary>
			public static readonly XrmFakedRelationship SavedQueryBulkDeleteFailures = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "savedqueryid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "savedquery",
					Entity2LogicalName = "bulkdeletefailure",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N SavedQuery_SyncErrors</summary>
			public static readonly XrmFakedRelationship SavedQuerySyncErrors = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "savedqueryid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "savedquery",
					Entity2LogicalName = "syncerror",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

		}
		#endregion

		#region Fake
		public static View Create()
		{
			var faker = new Faker<View>()
			.RuleFor(e => e.AdvancedGroupBy, fake => fake.Lorem.Word())
			.RuleFor(e => e.ColumnSetXML, fake => fake.Lorem.Word())
			.RuleFor(e => e.ComponentState, fake => fake.PickRandom<View.egComponentState>())
			.RuleFor(e => e.ConditionalFormatting, fake => fake.Lorem.Word())
			.RuleFor(e => e.Createdbyname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Createdbyyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.CreatedOn, fake => fake.Date.Soon())
			.RuleFor(e => e.Createdonbehalfbyname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Createdonbehalfbyyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.Description, fake => fake.Lorem.Word())
			.RuleFor(e => e.FetchXML, fake => fake.Lorem.Word())
			.RuleFor(e => e.IntroducedVersion, fake => fake.Lorem.Word())
			.RuleFor(e => e.IsCustom, fake => fake.Random.Bool())
			.RuleFor(e => e.Default, fake => fake.Random.Bool())
			.RuleFor(e => e.State, fake => fake.Random.Bool())
			.RuleFor(e => e.IsPrivate, fake => fake.Random.Bool())
			.RuleFor(e => e.QuickFindCompatible, fake => fake.Random.Bool())
			.RuleFor(e => e.UserDefined, fake => fake.Random.Bool())
			.RuleFor(e => e.LayoutDataInJSONFormat, fake => fake.Lorem.Word())
			.RuleFor(e => e.LayoutXML, fake => fake.Lorem.Word())
			.RuleFor(e => e.Modifiedbyname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Modifiedbyyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.ModifiedOn, fake => fake.Date.Soon())
			.RuleFor(e => e.Modifiedonbehalfbyname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Modifiedonbehalfbyyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.Name, fake => fake.Lorem.Word())
			.RuleFor(e => e.OfflineSQLQuery, fake => fake.Lorem.Word())
			.RuleFor(e => e.Organizationidname, fake => fake.Lorem.Word())
			.RuleFor(e => e.DefaultOrganizationTabOrder, fake => fake.Random.Int())
			.RuleFor(e => e.RecordOverwriteTime, fake => fake.Date.Soon())
			.RuleFor(e => e.QueryAPI, fake => fake.Lorem.Word())
			.RuleFor(e => e.QueryApplicationUsage, fake => fake.Random.Int())
			.RuleFor(e => e.QueryType, fake => fake.Random.Int())
			.RuleFor(e => e.EntityName, fake => fake.Lorem.Word())
			.RuleFor(e => e.Id, fake => Guid.NewGuid())
			.RuleFor(e => e.SavedqueryiduniqueId, fake => Guid.NewGuid())
			.RuleFor(e => e.SolutionId, fake => Guid.NewGuid())
			.RuleFor(e => e.Status, fake => fake.PickRandom<View.eStatus>())
			.RuleFor(e => e.StatusReason, fake => fake.PickRandom<View.eStatusReason>())
			.RuleFor(e => e.SolutionId2, fake => Guid.NewGuid())
			.RuleFor(e => e.VersionNumber, fake => fake.Random.Int());
			return faker.Generate();
		}
		#endregion
	}
}

