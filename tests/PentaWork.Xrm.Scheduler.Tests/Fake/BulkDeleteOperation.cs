using Bogus;
using System;
using FakeXrmEasy;
using System.Collections.Generic;
using PentaWork.Xrm.Scheduler.Proxies.Entities;

namespace PentaWork.Xrm.Scheduler.Tests.Fake
{
	public static class FakeBulkDeleteOperation
	{	
		#region FakeRelationships
		public static class Relationships 
		{
			/// <summary>1:N BulkDeleteOperation_BulkDeleteFailure</summary>
			public static readonly XrmFakedRelationship BulkDeleteOperationBulkDeleteFailure = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "bulkdeleteoperationid",
					Entity2Attribute = "bulkdeleteoperationid",
					Entity1LogicalName = "bulkdeleteoperation",
					Entity2LogicalName = "bulkdeletefailure",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

		}
		#endregion

		#region Fake
		public static BulkDeleteOperation Create()
		{
			var faker = new Faker<BulkDeleteOperation>()
			.RuleFor(e => e.Id, fake => Guid.NewGuid())
			.RuleFor(e => e.Createdbyname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Createdbyyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.Createdon, fake => fake.Date.Soon())
			.RuleFor(e => e.Createdonbehalfbyname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Createdonbehalfbyyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.Failures, fake => fake.Random.Int())
			.RuleFor(e => e.IsRecurring, fake => fake.Random.Bool())
			.RuleFor(e => e.Modifiedbyname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Modifiedbyyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.ModifiedOn, fake => fake.Date.Soon())
			.RuleFor(e => e.Modifiedonbehalfbyname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Modifiedonbehalfbyyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.SystemJobName, fake => fake.Lorem.Word())
			.RuleFor(e => e.NextRun, fake => fake.Date.Soon())
			.RuleFor(e => e.Orderedquerysetxml, fake => fake.Lorem.Word())
			.RuleFor(e => e.Owneridtype, fake => fake.Lorem.Word())
			.RuleFor(e => e.QueryIndex, fake => fake.Random.Int())
			.RuleFor(e => e.Status, fake => fake.PickRandom<BulkDeleteOperation.eStatus>())
			.RuleFor(e => e.StatusReason, fake => fake.PickRandom<BulkDeleteOperation.eStatusReason>())
			.RuleFor(e => e.Deleted, fake => fake.Random.Int())
			.RuleFor(e => e.Timezoneruleversionnumber, fake => fake.Random.Int())
			.RuleFor(e => e.Utcconversiontimezonecode, fake => fake.Random.Int());
			return faker.Generate();
		}
		#endregion
	}
}

