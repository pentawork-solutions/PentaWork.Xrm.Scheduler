using Bogus;
using System;
using FakeXrmEasy;
using System.Collections.Generic;
using PentaWork.Xrm.Scheduler.Proxies.Entities;

namespace PentaWork.Xrm.Scheduler.Tests.Fake
{
	public static class FakeGoal
	{	
		#region FakeRelationships
		public static class Relationships 
		{
			/// <summary>1:N Goal_Annotation</summary>
			public static readonly XrmFakedRelationship GoalAnnotation = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "goalid",
					Entity2Attribute = "objectid",
					Entity1LogicalName = "goal",
					Entity2LogicalName = "annotation",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N Goal_AsyncOperations</summary>
			public static readonly XrmFakedRelationship GoalAsyncOperations = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "goalid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "goal",
					Entity2LogicalName = "asyncoperation",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N goal_connections1</summary>
			public static readonly XrmFakedRelationship GoalConnections1 = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "goalid",
					Entity2Attribute = "record1id",
					Entity1LogicalName = "goal",
					Entity2LogicalName = "connection",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N goal_connections2</summary>
			public static readonly XrmFakedRelationship GoalConnections2 = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "goalid",
					Entity2Attribute = "record2id",
					Entity1LogicalName = "goal",
					Entity2LogicalName = "connection",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N Goal_DuplicateBaseRecord</summary>
			public static readonly XrmFakedRelationship GoalDuplicateBaseRecord = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "goalid",
					Entity2Attribute = "baserecordid",
					Entity1LogicalName = "goal",
					Entity2LogicalName = "duplicaterecord",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N Goal_DuplicateMatchingRecord</summary>
			public static readonly XrmFakedRelationship GoalDuplicateMatchingRecord = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "goalid",
					Entity2Attribute = "duplicaterecordid",
					Entity1LogicalName = "goal",
					Entity2LogicalName = "duplicaterecord",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N goal_parent_goal</summary>
			public static readonly XrmFakedRelationship GoalParentGoal = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "goalid",
					Entity2Attribute = "parentgoalid",
					Entity1LogicalName = "goal",
					Entity2LogicalName = "goal",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N goal_principalobjectattributeaccess</summary>
			public static readonly XrmFakedRelationship GoalPrincipalobjectattributeaccess = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "goalid",
					Entity2Attribute = "objectid",
					Entity1LogicalName = "goal",
					Entity2LogicalName = "principalobjectattributeaccess",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N Goal_ProcessSessions</summary>
			public static readonly XrmFakedRelationship GoalProcessSessions = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "goalid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "goal",
					Entity2LogicalName = "processsession",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N Goal_RollupError_Goal</summary>
			public static readonly XrmFakedRelationship GoalRollupErrorGoal = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "goalid",
					Entity2Attribute = "goalwitherrorid",
					Entity1LogicalName = "goal",
					Entity2LogicalName = "goal",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N Goal_SyncErrors</summary>
			public static readonly XrmFakedRelationship GoalSyncErrors = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "goalid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "goal",
					Entity2LogicalName = "syncerror",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

		}
		#endregion

		#region Fake
		public static Goal Create()
		{
			var faker = new Faker<Goal>()
			.RuleFor(e => e.ActualDecimal, fake => fake.Finance.Amount())
			.RuleFor(e => e.ActualInteger, fake => fake.Random.Int())
			.RuleFor(e => e.ActualMoney, fake => fake.Finance.Amount())
			.RuleFor(e => e.Actual, fake => fake.Lorem.Word())
			.RuleFor(e => e.AmountDataType, fake => fake.PickRandom<Goal.egGoalType>())
			.RuleFor(e => e.TodaysTargetDecimal, fake => fake.Finance.Amount())
			.RuleFor(e => e.TodaysTargetInteger, fake => fake.Random.Int())
			.RuleFor(e => e.TodaysTargetMoney, fake => fake.Finance.Amount())
			.RuleFor(e => e.TodaysTargetPercentageAchieved, fake => fake.Finance.Amount())
			.RuleFor(e => e.RecordSetForRollup, fake => fake.Random.Bool())
			.RuleFor(e => e.Createdbyname, fake => fake.Lorem.Word())
			.RuleFor(e => e.CreatedOn, fake => fake.Date.Soon())
			.RuleFor(e => e.Createdonbehalfbyname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Createdonbehalfbyyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.CustomRollupFieldDecimal, fake => fake.Finance.Amount())
			.RuleFor(e => e.CustomRollupFieldInteger, fake => fake.Random.Int())
			.RuleFor(e => e.CustomRollupFieldMoney, fake => fake.Finance.Amount())
			.RuleFor(e => e.CustomRollupField, fake => fake.Lorem.Word())
			.RuleFor(e => e.Depth, fake => fake.Random.Int())
			.RuleFor(e => e.EntityimageTimestamp, fake => fake.Random.Int())
			.RuleFor(e => e.EntityimageUrl, fake => fake.Lorem.Word())
			.RuleFor(e => e.EntityImageId, fake => Guid.NewGuid())
			.RuleFor(e => e.ExchangeRate, fake => fake.Finance.Amount())
			.RuleFor(e => e.FiscalPeriod, fake => fake.PickRandom<Goal.egFiscalPeriod>())
			.RuleFor(e => e.FiscalYear, fake => fake.PickRandom<Goal.egFiscalYear>())
			.RuleFor(e => e.To, fake => fake.Date.Soon())
			.RuleFor(e => e.Id, fake => Guid.NewGuid())
			.RuleFor(e => e.Goalowneridname, fake => fake.Lorem.Word())
			.RuleFor(e => e.GoalOwnerType, fake => fake.Lorem.Word())
			.RuleFor(e => e.Goalowneridyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.From, fake => fake.Date.Soon())
			.RuleFor(e => e.Goalwitherroridname, fake => fake.Lorem.Word())
			.RuleFor(e => e.ImportSequenceNumber, fake => fake.Random.Int())
			.RuleFor(e => e.InprogressDecimal, fake => fake.Finance.Amount())
			.RuleFor(e => e.InprogressInteger, fake => fake.Random.Int())
			.RuleFor(e => e.InprogressMoney, fake => fake.Finance.Amount())
			.RuleFor(e => e.InProgress, fake => fake.Lorem.Word())
			.RuleFor(e => e.MetricType, fake => fake.Random.Bool())
			.RuleFor(e => e.GoalPeriodType, fake => fake.Random.Bool())
			.RuleFor(e => e.Overridden, fake => fake.Random.Bool())
			.RuleFor(e => e.Override, fake => fake.Random.Bool())
			.RuleFor(e => e.LastRolledUpDate, fake => fake.Date.Soon())
			.RuleFor(e => e.Metricidname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Modifiedbyname, fake => fake.Lorem.Word())
			.RuleFor(e => e.ModifiedOn, fake => fake.Date.Soon())
			.RuleFor(e => e.Modifiedonbehalfbyname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Modifiedonbehalfbyyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.RecordCreatedOn, fake => fake.Date.Soon())
			.RuleFor(e => e.Owneridname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Owneridtype, fake => fake.Lorem.Word())
			.RuleFor(e => e.Owneridyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.Parentgoalidname, fake => fake.Lorem.Word())
			.RuleFor(e => e.PercentageAchieved, fake => fake.Finance.Amount())
			.RuleFor(e => e.RollupErrorCode, fake => fake.Random.Int())
			.RuleFor(e => e.RollUpOnlyFromChildGoals, fake => fake.Random.Bool())
			.RuleFor(e => e.Rollupqueryactualdecimalidname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Rollupqueryactualintegeridname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Rollupqueryactualmoneyidname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Rollupquerycustomdecimalidname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Rollupquerycustomintegeridname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Rollupquerycustommoneyidname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Rollupqueryinprogressdecimalidname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Rollupqueryinprogressintegeridname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Rollupqueryinprogressmoneyidname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Status, fake => fake.PickRandom<Goal.eStatus>())
			.RuleFor(e => e.StatusReason, fake => fake.PickRandom<Goal.eStatusReason>())
			.RuleFor(e => e.StretchTargetDecimal, fake => fake.Finance.Amount())
			.RuleFor(e => e.StretchTargetInteger, fake => fake.Random.Int())
			.RuleFor(e => e.StretchTargetMoney, fake => fake.Finance.Amount())
			.RuleFor(e => e.StretchedTarget, fake => fake.Lorem.Word())
			.RuleFor(e => e.TargetDecimal, fake => fake.Finance.Amount())
			.RuleFor(e => e.TargetInteger, fake => fake.Random.Int())
			.RuleFor(e => e.TargetMoney, fake => fake.Finance.Amount())
			.RuleFor(e => e.Target, fake => fake.Lorem.Word())
			.RuleFor(e => e.TimeZoneRuleVersionNumber, fake => fake.Random.Int())
			.RuleFor(e => e.Name, fake => fake.Lorem.Word())
			.RuleFor(e => e.Transactioncurrencyidname, fake => fake.Lorem.Word())
			.RuleFor(e => e.TreeId, fake => Guid.NewGuid())
			.RuleFor(e => e.UTCConversionTimeZoneCode, fake => fake.Random.Int())
			.RuleFor(e => e.VersionNumber, fake => fake.Random.Int());
			return faker.Generate();
		}
		#endregion
	}
}

