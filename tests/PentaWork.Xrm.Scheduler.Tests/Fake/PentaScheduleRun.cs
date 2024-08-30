using Bogus;
using System;
using FakeXrmEasy;
using System.Collections.Generic;
using PentaWork.Xrm.Scheduler.Proxies.Entities;

namespace PentaWork.Xrm.Scheduler.Tests.Fake
{
	public static class FakePentaScheduleRun
	{	
		#region FakeRelationships
		public static class Relationships 
		{
			/// <summary>1:N pw_penta_schedule_run_AsyncOperations</summary>
			public static readonly XrmFakedRelationship PwPentaScheduleRunAsyncOperations = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "pw_penta_schedule_runid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "pw_penta_schedule_run",
					Entity2LogicalName = "asyncoperation",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N pw_pw_penta_schedule_run_pw_schedule_next_run</summary>
			public static readonly XrmFakedRelationship PwPwPentaScheduleRunPwScheduleNextRun = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "pw_penta_schedule_runid",
					Entity2Attribute = "pw_next_run",
					Entity1LogicalName = "pw_penta_schedule_run",
					Entity2LogicalName = "pw_schedule",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

		}
		#endregion

		#region Fake
		public static PentaScheduleRun Create()
		{
			var faker = new Faker<PentaScheduleRun>()
			.RuleFor(e => e.Createdbyname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Createdbyyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.CreatedOn, fake => fake.Date.Soon())
			.RuleFor(e => e.Createdonbehalfbyname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Createdonbehalfbyyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.ImportSequenceNumber, fake => fake.Random.Int())
			.RuleFor(e => e.Modifiedbyname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Modifiedbyyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.ModifiedOn, fake => fake.Date.Soon())
			.RuleFor(e => e.Modifiedonbehalfbyname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Modifiedonbehalfbyyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.RecordCreatedOn, fake => fake.Date.Soon())
			.RuleFor(e => e.Owneridname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Owneridtype, fake => fake.Lorem.Word())
			.RuleFor(e => e.Owneridyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.Owningbusinessunitname, fake => fake.Lorem.Word())
			.RuleFor(e => e.CurrentPage, fake => fake.Random.Int())
			.RuleFor(e => e.Log, fake => fake.Lorem.Word())
			.RuleFor(e => e.Name, fake => fake.Lorem.Word())
			.RuleFor(e => e.PageSize, fake => fake.Random.Int())
			.RuleFor(e => e.Id, fake => Guid.NewGuid())
			.RuleFor(e => e.PwPentaSchedulename, fake => fake.Lorem.Word())
			.RuleFor(e => e.RunDateTime, fake => fake.Date.Soon())
			.RuleFor(e => e.TotalPages, fake => fake.Random.Int())
			.RuleFor(e => e.Status, fake => fake.PickRandom<PentaScheduleRun.eStatus>())
			.RuleFor(e => e.StatusReason, fake => fake.PickRandom<PentaScheduleRun.eStatusReason>())
			.RuleFor(e => e.TimeZoneRuleVersionNumber, fake => fake.Random.Int())
			.RuleFor(e => e.UTCConversionTimeZoneCode, fake => fake.Random.Int())
			.RuleFor(e => e.VersionNumber, fake => fake.Random.Int());
			return faker.Generate();
		}
		#endregion
	}
}

