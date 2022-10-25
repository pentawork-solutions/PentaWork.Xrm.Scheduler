using Bogus;
using System;
using FakeXrmEasy;
using System.Collections.Generic;
using PentaWork.Xrm.Scheduler.Proxies.Entities;

namespace PentaWork.Xrm.Scheduler.Tests.Fake
{
	public static class FakeRollupQuery
	{	
		#region FakeRelationships
		public static class Relationships 
		{
			/// <summary>1:N goal_rollupquery_actualdecimal</summary>
			public static readonly XrmFakedRelationship GoalRollupqueryActualdecimal = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "goalrollupqueryid",
					Entity2Attribute = "rollupqueryactualdecimalid",
					Entity1LogicalName = "goalrollupquery",
					Entity2LogicalName = "goal",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N goal_rollupquery_actualmoney</summary>
			public static readonly XrmFakedRelationship GoalRollupqueryActualmoney = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "goalrollupqueryid",
					Entity2Attribute = "rollupqueryactualmoneyid",
					Entity1LogicalName = "goalrollupquery",
					Entity2LogicalName = "goal",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N goal_rollupquery_customdecimal</summary>
			public static readonly XrmFakedRelationship GoalRollupqueryCustomdecimal = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "goalrollupqueryid",
					Entity2Attribute = "rollupquerycustomdecimalid",
					Entity1LogicalName = "goalrollupquery",
					Entity2LogicalName = "goal",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N goal_rollupquery_customint</summary>
			public static readonly XrmFakedRelationship GoalRollupqueryCustomint = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "goalrollupqueryid",
					Entity2Attribute = "rollupquerycustomintegerid",
					Entity1LogicalName = "goalrollupquery",
					Entity2LogicalName = "goal",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N goal_rollupquery_custommoney</summary>
			public static readonly XrmFakedRelationship GoalRollupqueryCustommoney = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "goalrollupqueryid",
					Entity2Attribute = "rollupquerycustommoneyid",
					Entity1LogicalName = "goalrollupquery",
					Entity2LogicalName = "goal",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N goal_rollupquery_inprogressdecimal</summary>
			public static readonly XrmFakedRelationship GoalRollupqueryInprogressdecimal = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "goalrollupqueryid",
					Entity2Attribute = "rollupqueryinprogressdecimalid",
					Entity1LogicalName = "goalrollupquery",
					Entity2LogicalName = "goal",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N goal_rollupquery_inprogressint</summary>
			public static readonly XrmFakedRelationship GoalRollupqueryInprogressint = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "goalrollupqueryid",
					Entity2Attribute = "rollupqueryinprogressintegerid",
					Entity1LogicalName = "goalrollupquery",
					Entity2LogicalName = "goal",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N goal_rollupquery_inprogressmoney</summary>
			public static readonly XrmFakedRelationship GoalRollupqueryInprogressmoney = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "goalrollupqueryid",
					Entity2Attribute = "rollupqueryinprogressmoneyid",
					Entity1LogicalName = "goalrollupquery",
					Entity2LogicalName = "goal",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N goalrollupquery_actualint</summary>
			public static readonly XrmFakedRelationship GoalrollupqueryActualint = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "goalrollupqueryid",
					Entity2Attribute = "rollupqueryactualintegerid",
					Entity1LogicalName = "goalrollupquery",
					Entity2LogicalName = "goal",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N goalrollupquery_AsyncOperations</summary>
			public static readonly XrmFakedRelationship GoalrollupqueryAsyncOperations = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "goalrollupqueryid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "goalrollupquery",
					Entity2LogicalName = "asyncoperation",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N GoalRollupQuery_DuplicateBaseRecord</summary>
			public static readonly XrmFakedRelationship GoalRollupQueryDuplicateBaseRecord = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "goalrollupqueryid",
					Entity2Attribute = "baserecordid",
					Entity1LogicalName = "goalrollupquery",
					Entity2LogicalName = "duplicaterecord",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N GoalRollupQuery_DuplicateMatchingRecord</summary>
			public static readonly XrmFakedRelationship GoalRollupQueryDuplicateMatchingRecord = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "goalrollupqueryid",
					Entity2Attribute = "duplicaterecordid",
					Entity1LogicalName = "goalrollupquery",
					Entity2LogicalName = "duplicaterecord",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N goalrollupquery_ProcessSessions</summary>
			public static readonly XrmFakedRelationship GoalrollupqueryProcessSessions = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "goalrollupqueryid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "goalrollupquery",
					Entity2LogicalName = "processsession",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N GoalRollupQuery_SyncErrors</summary>
			public static readonly XrmFakedRelationship GoalRollupQuerySyncErrors = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "goalrollupqueryid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "goalrollupquery",
					Entity2LogicalName = "syncerror",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

		}
		#endregion

		#region Fake
		public static RollupQuery Create()
		{
			var faker = new Faker<RollupQuery>()
			.RuleFor(e => e.Createdbyname, fake => fake.Lorem.Word())
			.RuleFor(e => e.CreatedOn, fake => fake.Date.Soon())
			.RuleFor(e => e.Createdonbehalfbyname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Createdonbehalfbyyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.ConditionCriteria, fake => fake.Lorem.Word())
			.RuleFor(e => e.Id, fake => Guid.NewGuid())
			.RuleFor(e => e.ImportSequenceNumber, fake => fake.Random.Int())
			.RuleFor(e => e.Modifiedbyname, fake => fake.Lorem.Word())
			.RuleFor(e => e.ModifiedOn, fake => fake.Date.Soon())
			.RuleFor(e => e.Modifiedonbehalfbyname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Modifiedonbehalfbyyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.Name, fake => fake.Lorem.Word())
			.RuleFor(e => e.RecordCreatedOn, fake => fake.Date.Soon())
			.RuleFor(e => e.Owneridname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Owneridtype, fake => fake.Lorem.Word())
			.RuleFor(e => e.Owneridyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.EntityType, fake => fake.Lorem.Word())
			.RuleFor(e => e.Status, fake => fake.PickRandom<RollupQuery.eStatus>())
			.RuleFor(e => e.StatusReason, fake => fake.PickRandom<RollupQuery.eStatusReason>())
			.RuleFor(e => e.TimeZoneRuleVersionNumber, fake => fake.Random.Int())
			.RuleFor(e => e.UTCConversionTimeZoneCode, fake => fake.Random.Int())
			.RuleFor(e => e.VersionNumber, fake => fake.Random.Int());
			return faker.Generate();
		}
		#endregion
	}
}

