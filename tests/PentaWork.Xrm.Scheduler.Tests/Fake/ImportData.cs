using Bogus;
using System;
using FakeXrmEasy;
using System.Collections.Generic;
using PentaWork.Xrm.Scheduler.Proxies.Entities;

namespace PentaWork.Xrm.Scheduler.Tests.Fake
{
	public static class FakeImportData
	{	
		#region FakeRelationships
		public static class Relationships 
		{
			/// <summary>1:N ImportData_AsyncOperations</summary>
			public static readonly XrmFakedRelationship ImportDataAsyncOperations = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "importdataid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "importdata",
					Entity2LogicalName = "asyncoperation",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N ImportData_BulkDeleteFailures</summary>
			public static readonly XrmFakedRelationship ImportDataBulkDeleteFailures = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "importdataid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "importdata",
					Entity2LogicalName = "bulkdeletefailure",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N ImportLog_ImportData</summary>
			public static readonly XrmFakedRelationship ImportLogImportData = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "importdataid",
					Entity2Attribute = "importdataid",
					Entity1LogicalName = "importdata",
					Entity2LogicalName = "importlog",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

		}
		#endregion

		#region Fake
		public static ImportData Create()
		{
			var faker = new Faker<ImportData>()
			.RuleFor(e => e.Createdbyname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Createdbyyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.Createdon, fake => fake.Date.Soon())
			.RuleFor(e => e.Createdonbehalfbyname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Createdonbehalfbyyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.Data, fake => fake.Lorem.Word())
			.RuleFor(e => e.ErrorType, fake => fake.PickRandom<ImportData.eErrorType>())
			.RuleFor(e => e.HasError, fake => fake.Random.Bool())
			.RuleFor(e => e.Id, fake => Guid.NewGuid())
			.RuleFor(e => e.Importfileidname, fake => fake.Lorem.Word())
			.RuleFor(e => e.LineNumber, fake => fake.Random.Int())
			.RuleFor(e => e.Modifiedbyname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Modifiedbyyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.ModifiedOn, fake => fake.Date.Soon())
			.RuleFor(e => e.Modifiedonbehalfbyname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Modifiedonbehalfbyyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.Owneridname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Owneridtype, fake => fake.Lorem.Word())
			.RuleFor(e => e.Owneridyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.RecordId, fake => Guid.NewGuid())
			.RuleFor(e => e.Status, fake => fake.PickRandom<ImportData.eStatus>())
			.RuleFor(e => e.StatusReason, fake => fake.PickRandom<ImportData.eStatusReason>());
			return faker.Generate();
		}
		#endregion
	}
}

