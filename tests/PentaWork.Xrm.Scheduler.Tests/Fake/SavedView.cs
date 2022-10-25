using Bogus;
using System;
using FakeXrmEasy;
using System.Collections.Generic;
using PentaWork.Xrm.Scheduler.Proxies.Entities;

namespace PentaWork.Xrm.Scheduler.Tests.Fake
{
	public static class FakeSavedView
	{	
		#region FakeRelationships
		public static class Relationships 
		{
			/// <summary>1:N UserQuery_AsyncOperations</summary>
			public static readonly XrmFakedRelationship UserQueryAsyncOperations = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "userqueryid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "userquery",
					Entity2LogicalName = "asyncoperation",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N UserQuery_BulkDeleteFailures</summary>
			public static readonly XrmFakedRelationship UserQueryBulkDeleteFailures = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "userqueryid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "userquery",
					Entity2LogicalName = "bulkdeletefailure",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N UserQuery_SyncErrors</summary>
			public static readonly XrmFakedRelationship UserQuerySyncErrors = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "userqueryid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "userquery",
					Entity2LogicalName = "syncerror",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

		}
		#endregion

		#region Fake
		public static SavedView Create()
		{
			var faker = new Faker<SavedView>()
			.RuleFor(e => e.AdvancedGroupBy, fake => fake.Lorem.Word())
			.RuleFor(e => e.ColumnSetXML, fake => fake.Lorem.Word())
			.RuleFor(e => e.UserGroupBy, fake => fake.Lorem.Word())
			.RuleFor(e => e.Createdbyname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Createdbyyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.CreatedOn, fake => fake.Date.Soon())
			.RuleFor(e => e.Createdonbehalfbyname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Createdonbehalfbyyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.Description, fake => fake.Lorem.Word())
			.RuleFor(e => e.FetchXML, fake => fake.Lorem.Word())
			.RuleFor(e => e.LayoutDataInJSONFormat, fake => fake.Lorem.Word())
			.RuleFor(e => e.LayoutXML, fake => fake.Lorem.Word())
			.RuleFor(e => e.Modifiedbyname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Modifiedbyyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.LastModified, fake => fake.Date.Soon())
			.RuleFor(e => e.Modifiedonbehalfbyname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Modifiedonbehalfbyyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.Name, fake => fake.Lorem.Word())
			.RuleFor(e => e.OfflineSQLQuery, fake => fake.Lorem.Word())
			.RuleFor(e => e.Owneridname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Owneridtype, fake => fake.Lorem.Word())
			.RuleFor(e => e.Owneridyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.QueryType, fake => fake.Random.Int())
			.RuleFor(e => e.ReturnedType, fake => fake.Lorem.Word())
			.RuleFor(e => e.Status, fake => fake.PickRandom<SavedView.eStatus>())
			.RuleFor(e => e.StatusReason, fake => fake.PickRandom<SavedView.eStatusReason>())
			.RuleFor(e => e.Id, fake => Guid.NewGuid())
			.RuleFor(e => e.VersionNumber, fake => fake.Random.Int());
			return faker.Generate();
		}
		#endregion
	}
}

