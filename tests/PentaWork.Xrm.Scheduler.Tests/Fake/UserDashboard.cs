using Bogus;
using System;
using FakeXrmEasy;
using System.Collections.Generic;
using PentaWork.Xrm.Scheduler.Proxies.Entities;

namespace PentaWork.Xrm.Scheduler.Tests.Fake
{
	public static class FakeUserDashboard
	{	
		#region FakeRelationships
		public static class Relationships 
		{
			/// <summary>1:N UserForm_AsyncOperations</summary>
			public static readonly XrmFakedRelationship UserFormAsyncOperations = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "userformid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "userform",
					Entity2LogicalName = "asyncoperation",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N UserForm_BulkDeleteFailures</summary>
			public static readonly XrmFakedRelationship UserFormBulkDeleteFailures = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "userformid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "userform",
					Entity2LogicalName = "bulkdeletefailure",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

		}
		#endregion

		#region Fake
		public static UserDashboard Create()
		{
			var faker = new Faker<UserDashboard>()
			.RuleFor(e => e.Createdbyname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Createdbyyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.CreatedOn, fake => fake.Date.Soon())
			.RuleFor(e => e.Createdonbehalfbyname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Createdonbehalfbyyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.Description, fake => fake.Lorem.Word())
			.RuleFor(e => e.JsonRepresentationOfTheFormLayout, fake => fake.Lorem.Word())
			.RuleFor(e => e.Formxml, fake => fake.Lorem.Word())
			.RuleFor(e => e.IsTabletEnabled, fake => fake.Random.Bool())
			.RuleFor(e => e.Modifiedbyname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Modifiedbyyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.ModifiedOn, fake => fake.Date.Soon())
			.RuleFor(e => e.Modifiedonbehalfbyname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Modifiedonbehalfbyyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.Name, fake => fake.Lorem.Word())
			.RuleFor(e => e.Objecttypecode, fake => fake.Lorem.Word())
			.RuleFor(e => e.Owneridname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Owneridtype, fake => fake.Lorem.Word())
			.RuleFor(e => e.Owneridyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.FormType, fake => fake.PickRandom<UserDashboard.eType>())
			.RuleFor(e => e.Id, fake => Guid.NewGuid())
			.RuleFor(e => e.Versionnumber, fake => fake.Random.Int());
			return faker.Generate();
		}
		#endregion
	}
}

