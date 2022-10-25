using Bogus;
using System;
using FakeXrmEasy;
using System.Collections.Generic;
using PentaWork.Xrm.Scheduler.Proxies.Entities;

namespace PentaWork.Xrm.Scheduler.Tests.Fake
{
	public static class FakeImportLog
	{	
		#region FakeRelationships
		public static class Relationships 
		{
			/// <summary>1:N ImportLog_AsyncOperations</summary>
			public static readonly XrmFakedRelationship ImportLogAsyncOperations = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "importlogid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "importlog",
					Entity2LogicalName = "asyncoperation",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N ImportLog_BulkDeleteFailures</summary>
			public static readonly XrmFakedRelationship ImportLogBulkDeleteFailures = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "importlogid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "importlog",
					Entity2LogicalName = "bulkdeletefailure",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

		}
		#endregion

		#region Fake
		public static ImportLog Create()
		{
			var faker = new Faker<ImportLog>()
			.RuleFor(e => e.MoreInformation, fake => fake.Lorem.Word())
			.RuleFor(e => e.ColumnValue, fake => fake.Lorem.Word())
			.RuleFor(e => e.Createdbyname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Createdbyyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.CreatedOn, fake => fake.Date.Soon())
			.RuleFor(e => e.Createdonbehalfbyname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Createdonbehalfbyyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.Description, fake => fake.Lorem.Word())
			.RuleFor(e => e.ErrorCode, fake => fake.Random.Int())
			.RuleFor(e => e.ColumnHeading, fake => fake.Lorem.Word())
			.RuleFor(e => e.Importdataidname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Importfileidname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Id, fake => Guid.NewGuid())
			.RuleFor(e => e.OriginalRowNumber, fake => fake.Random.Int())
			.RuleFor(e => e.LogPhase, fake => fake.PickRandom<ImportLog.eLogPhase>())
			.RuleFor(e => e.Modifiedbyname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Modifiedbyyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.ModifiedOn, fake => fake.Date.Soon())
			.RuleFor(e => e.Modifiedonbehalfbyname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Modifiedonbehalfbyyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.Owneridname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Owneridtype, fake => fake.Lorem.Word())
			.RuleFor(e => e.Owneridyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.SequenceNumber, fake => fake.Random.Int())
			.RuleFor(e => e.Status, fake => fake.PickRandom<ImportLog.eStatus>())
			.RuleFor(e => e.StatusReason, fake => fake.PickRandom<ImportLog.eStatusReason>());
			return faker.Generate();
		}
		#endregion
	}
}

