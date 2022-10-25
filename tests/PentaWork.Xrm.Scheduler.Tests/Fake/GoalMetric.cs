using Bogus;
using System;
using FakeXrmEasy;
using System.Collections.Generic;
using PentaWork.Xrm.Scheduler.Proxies.Entities;

namespace PentaWork.Xrm.Scheduler.Tests.Fake
{
	public static class FakeGoalMetric
	{	
		#region FakeRelationships
		public static class Relationships 
		{
			/// <summary>1:N metric_AsyncOperations</summary>
			public static readonly XrmFakedRelationship MetricAsyncOperations = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "metricid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "metric",
					Entity2LogicalName = "asyncoperation",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N metric_goal</summary>
			public static readonly XrmFakedRelationship MetricGoal = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "metricid",
					Entity2Attribute = "metricid",
					Entity1LogicalName = "metric",
					Entity2LogicalName = "goal",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N metric_ProcessSessions</summary>
			public static readonly XrmFakedRelationship MetricProcessSessions = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "metricid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "metric",
					Entity2LogicalName = "processsession",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N metric_rollupfield</summary>
			public static readonly XrmFakedRelationship MetricRollupfield = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "metricid",
					Entity2Attribute = "metricid",
					Entity1LogicalName = "metric",
					Entity2LogicalName = "rollupfield",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N Metric_SyncErrors</summary>
			public static readonly XrmFakedRelationship MetricSyncErrors = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "metricid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "metric",
					Entity2LogicalName = "syncerror",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

		}
		#endregion

		#region Fake
		public static GoalMetric Create()
		{
			var faker = new Faker<GoalMetric>()
			.RuleFor(e => e.AmountDataType, fake => fake.PickRandom<GoalMetric.egGoalType>())
			.RuleFor(e => e.Createdbyname, fake => fake.Lorem.Word())
			.RuleFor(e => e.CreatedOn, fake => fake.Date.Soon())
			.RuleFor(e => e.Createdonbehalfbyname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Createdonbehalfbyyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.Description, fake => fake.Lorem.Word())
			.RuleFor(e => e.ImportSequenceNumber, fake => fake.Random.Int())
			.RuleFor(e => e.MetricType, fake => fake.Random.Bool())
			.RuleFor(e => e.TrackStretchTarget, fake => fake.Random.Bool())
			.RuleFor(e => e.Id, fake => Guid.NewGuid())
			.RuleFor(e => e.Modifiedbyname, fake => fake.Lorem.Word())
			.RuleFor(e => e.ModifiedOn, fake => fake.Date.Soon())
			.RuleFor(e => e.Modifiedonbehalfbyname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Modifiedonbehalfbyyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.Name, fake => fake.Lorem.Word())
			.RuleFor(e => e.Organizationidname, fake => fake.Lorem.Word())
			.RuleFor(e => e.RecordCreatedOn, fake => fake.Date.Soon())
			.RuleFor(e => e.Status, fake => fake.PickRandom<GoalMetric.eStatus>())
			.RuleFor(e => e.StatusReason, fake => fake.PickRandom<GoalMetric.eStatusReason>())
			.RuleFor(e => e.TimeZoneRuleVersionNumber, fake => fake.Random.Int())
			.RuleFor(e => e.UTCConversionTimeZoneCode, fake => fake.Random.Int())
			.RuleFor(e => e.VersionNumber, fake => fake.Random.Int());
			return faker.Generate();
		}
		#endregion
	}
}

