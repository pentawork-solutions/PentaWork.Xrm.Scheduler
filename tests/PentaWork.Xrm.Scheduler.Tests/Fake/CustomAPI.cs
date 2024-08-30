using Bogus;
using System;
using FakeXrmEasy;
using System.Collections.Generic;
using PentaWork.Xrm.Scheduler.Proxies.Entities;

namespace PentaWork.Xrm.Scheduler.Tests.Fake
{
	public static class FakeCustomAPI
	{	
		#region FakeRelationships
		public static class Relationships 
		{
			/// <summary>1:N customapi_AsyncOperations</summary>
			public static readonly XrmFakedRelationship CustomapiAsyncOperations = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "customapiid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "customapi",
					Entity2LogicalName = "asyncoperation",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N pw_schedule_custom_api_id_customapi</summary>
			public static readonly XrmFakedRelationship PwScheduleCustomApiIdCustomapi = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "customapiid",
					Entity2Attribute = "pw_custom_api_id",
					Entity1LogicalName = "customapi",
					Entity2LogicalName = "pw_schedule",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N pw_schedule_global_custom_api_id_customapi</summary>
			public static readonly XrmFakedRelationship PwScheduleGlobalCustomApiIdCustomapi = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "customapiid",
					Entity2Attribute = "pw_global_custom_api_id",
					Entity1LogicalName = "customapi",
					Entity2LogicalName = "pw_schedule",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

		}
		#endregion

		#region Fake
		public static CustomAPI Create()
		{
			var faker = new Faker<CustomAPI>()
			.RuleFor(e => e.AllowedCustomProcessingStepType, fake => fake.PickRandom<CustomAPI.eAllowedCustomProcessingStepType>())
			.RuleFor(e => e.BindingType, fake => fake.PickRandom<CustomAPI.eBindingType>())
			.RuleFor(e => e.BoundEntityLogicalName, fake => fake.Lorem.Word())
			.RuleFor(e => e.RowIdUniqueId, fake => Guid.NewGuid())
			.RuleFor(e => e.ComponentState, fake => fake.PickRandom<CustomAPI.egComponentState>())
			.RuleFor(e => e.Createdbyname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Createdbyyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.CreatedOn, fake => fake.Date.Soon())
			.RuleFor(e => e.Createdonbehalfbyname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Createdonbehalfbyyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.Id, fake => Guid.NewGuid())
			.RuleFor(e => e.Description, fake => fake.Lorem.Word())
			.RuleFor(e => e.DisplayName, fake => fake.Lorem.Word())
			.RuleFor(e => e.ExecutePrivilegeName, fake => fake.Lorem.Word())
			.RuleFor(e => e.Fxexpressionidname, fake => fake.Lorem.Word())
			.RuleFor(e => e.ImportSequenceNumber, fake => fake.Random.Int())
			.RuleFor(e => e.IsFunction, fake => fake.Random.Bool())
			.RuleFor(e => e.IsManaged, fake => fake.Random.Bool())
			.RuleFor(e => e.IsPrivate, fake => fake.Random.Bool())
			.RuleFor(e => e.Modifiedbyname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Modifiedbyyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.ModifiedOn, fake => fake.Date.Soon())
			.RuleFor(e => e.Modifiedonbehalfbyname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Modifiedonbehalfbyyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.Name, fake => fake.Lorem.Word())
			.RuleFor(e => e.RecordCreatedOn, fake => fake.Date.Soon())
			.RuleFor(e => e.RecordOverwriteTime, fake => fake.Date.Soon())
			.RuleFor(e => e.Owneridname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Owneridtype, fake => fake.Lorem.Word())
			.RuleFor(e => e.Owneridyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.Owningbusinessunitname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Plugintypeidname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Powerfxruleidname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Sdkmessageidname, fake => fake.Lorem.Word())
			.RuleFor(e => e.SolutionId, fake => Guid.NewGuid())
			.RuleFor(e => e.Status, fake => fake.PickRandom<CustomAPI.eStatus>())
			.RuleFor(e => e.StatusReason, fake => fake.PickRandom<CustomAPI.eStatusReason>())
			.RuleFor(e => e.SolutionId2, fake => Guid.NewGuid())
			.RuleFor(e => e.TimeZoneRuleVersionNumber, fake => fake.Random.Int())
			.RuleFor(e => e.UniqueName, fake => fake.Lorem.Word())
			.RuleFor(e => e.UTCConversionTimeZoneCode, fake => fake.Random.Int())
			.RuleFor(e => e.VersionNumber, fake => fake.Random.Int())
			.RuleFor(e => e.EnabledForWorkflow, fake => fake.Random.Bool());
			return faker.Generate();
		}
		#endregion
	}
}

