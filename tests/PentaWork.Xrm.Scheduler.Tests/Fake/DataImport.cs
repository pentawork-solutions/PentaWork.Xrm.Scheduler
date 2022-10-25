using Bogus;
using System;
using FakeXrmEasy;
using System.Collections.Generic;
using PentaWork.Xrm.Scheduler.Proxies.Entities;

namespace PentaWork.Xrm.Scheduler.Tests.Fake
{
	public static class FakeDataImport
	{	
		#region FakeRelationships
		public static class Relationships 
		{
			/// <summary>1:N Import_AsyncOperations</summary>
			public static readonly XrmFakedRelationship ImportAsyncOperations = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "importid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "import",
					Entity2LogicalName = "asyncoperation",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N Import_BulkDeleteFailures</summary>
			public static readonly XrmFakedRelationship ImportBulkDeleteFailures = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "importid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "import",
					Entity2LogicalName = "bulkdeletefailure",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N Import_ImportFile</summary>
			public static readonly XrmFakedRelationship ImportImportFile = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "importid",
					Entity2Attribute = "importid",
					Entity1LogicalName = "import",
					Entity2LogicalName = "importfile",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

		}
		#endregion

		#region Fake
		public static DataImport Create()
		{
			var faker = new Faker<DataImport>()
			.RuleFor(e => e.Createdbyname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Createdbyyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.CreatedOn, fake => fake.Date.Soon())
			.RuleFor(e => e.Createdonbehalfbyname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Createdonbehalfbyyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.Email, fake => fake.Lorem.Word())
			.RuleFor(e => e.Id, fake => Guid.NewGuid())
			.RuleFor(e => e.IsImport, fake => fake.Random.Bool())
			.RuleFor(e => e.Mode, fake => fake.PickRandom<DataImport.eMode>())
			.RuleFor(e => e.Modifiedbyname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Modifiedbyyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.ModifiedOn, fake => fake.Date.Soon())
			.RuleFor(e => e.Modifiedonbehalfbyname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Modifiedonbehalfbyyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.ImportName, fake => fake.Lorem.Word())
			.RuleFor(e => e.Owneridname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Owneridtype, fake => fake.Lorem.Word())
			.RuleFor(e => e.Owneridyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.SendNotification, fake => fake.Random.Bool())
			.RuleFor(e => e.Sequence, fake => fake.Random.Int())
			.RuleFor(e => e.Status, fake => fake.PickRandom<DataImport.eStatus>())
			.RuleFor(e => e.StatusReason, fake => fake.PickRandom<DataImport.eStatusReason>());
			return faker.Generate();
		}
		#endregion
	}
}

