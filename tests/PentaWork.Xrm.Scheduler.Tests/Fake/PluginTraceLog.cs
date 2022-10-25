using Bogus;
using System;
using FakeXrmEasy;
using System.Collections.Generic;
using PentaWork.Xrm.Scheduler.Proxies.Entities;

namespace PentaWork.Xrm.Scheduler.Tests.Fake
{
	public static class FakePluginTraceLog
	{	
		#region FakeRelationships
		public static class Relationships 
		{
		}
		#endregion

		#region Fake
		public static PluginTraceLog Create()
		{
			var faker = new Faker<PluginTraceLog>()
			.RuleFor(e => e.Configuration, fake => fake.Lorem.Word())
			.RuleFor(e => e.CorrelationId, fake => Guid.NewGuid())
			.RuleFor(e => e.Createdbyname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Createdbyyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.CreatedOn, fake => fake.Date.Soon())
			.RuleFor(e => e.Createdonbehalfbyname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Createdonbehalfbyyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.Depth, fake => fake.Random.Int())
			.RuleFor(e => e.ExceptionDetails, fake => fake.Lorem.Word())
			.RuleFor(e => e.SystemCreated, fake => fake.Random.Bool())
			.RuleFor(e => e.MessageBlock, fake => fake.Lorem.Word())
			.RuleFor(e => e.MessageName, fake => fake.Lorem.Word())
			.RuleFor(e => e.Mode, fake => fake.PickRandom<PluginTraceLog.eMode>())
			.RuleFor(e => e.OperationType, fake => fake.PickRandom<PluginTraceLog.eOperationType>())
			.RuleFor(e => e.OrganizationId, fake => Guid.NewGuid())
			.RuleFor(e => e.ConstructorDuration, fake => fake.Random.Int())
			.RuleFor(e => e.ConstructorStartTime, fake => fake.Date.Soon())
			.RuleFor(e => e.ExecutionDuration, fake => fake.Random.Int())
			.RuleFor(e => e.ExecutionStartTime, fake => fake.Date.Soon())
			.RuleFor(e => e.PersistenceKeyId, fake => Guid.NewGuid())
			.RuleFor(e => e.PluginStepId, fake => Guid.NewGuid())
			.RuleFor(e => e.Id, fake => Guid.NewGuid())
			.RuleFor(e => e.PrimaryEntity, fake => fake.Lorem.Word())
			.RuleFor(e => e.Profile, fake => fake.Lorem.Word())
			.RuleFor(e => e.RequestId, fake => Guid.NewGuid())
			.RuleFor(e => e.SecureConfiguration, fake => fake.Lorem.Word())
			.RuleFor(e => e.TypeName, fake => fake.Lorem.Word());
			return faker.Generate();
		}
		#endregion
	}
}

