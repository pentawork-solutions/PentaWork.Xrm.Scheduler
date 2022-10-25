using Bogus;
using System;
using FakeXrmEasy;
using System.Collections.Generic;
using PentaWork.Xrm.Scheduler.Proxies.Entities;

namespace PentaWork.Xrm.Scheduler.Tests.Fake
{
	public static class FakeDuplicateDetectionRule
	{	
		#region FakeRelationships
		public static class Relationships 
		{
			/// <summary>1:N DuplicateRule_Annotation</summary>
			public static readonly XrmFakedRelationship DuplicateRuleAnnotation = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "duplicateruleid",
					Entity2Attribute = "objectid",
					Entity1LogicalName = "duplicaterule",
					Entity2LogicalName = "annotation",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N DuplicateRule_DuplicateBaseRecord</summary>
			public static readonly XrmFakedRelationship DuplicateRuleDuplicateBaseRecord = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "duplicateruleid",
					Entity2Attribute = "duplicateruleid",
					Entity1LogicalName = "duplicaterule",
					Entity2LogicalName = "duplicaterecord",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N DuplicateRule_DuplicateRuleConditions</summary>
			public static readonly XrmFakedRelationship DuplicateRuleDuplicateRuleConditions = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "duplicateruleid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "duplicaterule",
					Entity2LogicalName = "duplicaterulecondition",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N DuplicateRule_SyncErrors</summary>
			public static readonly XrmFakedRelationship DuplicateRuleSyncErrors = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "duplicateruleid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "duplicaterule",
					Entity2LogicalName = "syncerror",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

		}
		#endregion

		#region Fake
		public static DuplicateDetectionRule Create()
		{
			var faker = new Faker<DuplicateDetectionRule>()
			.RuleFor(e => e.BaseRecordTypeMatchCodeTable, fake => fake.Lorem.Word())
			.RuleFor(e => e.BaseRecordType, fake => fake.Lorem.Word())
			.RuleFor(e => e.BaseRecordType2, fake => fake.PickRandom<DuplicateDetectionRule.eBaseRecordType>())
			.RuleFor(e => e.Createdbyname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Createdbyyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.CreatedOn, fake => fake.Date.Soon())
			.RuleFor(e => e.Createdonbehalfbyname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Createdonbehalfbyyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.Description, fake => fake.Lorem.Word())
			.RuleFor(e => e.Id, fake => Guid.NewGuid())
			.RuleFor(e => e.ExcludeInactiveRecords, fake => fake.Random.Bool())
			.RuleFor(e => e.CaseSensitive, fake => fake.Random.Bool())
			.RuleFor(e => e.MatchingRecordTypeMatchCodeTable, fake => fake.Lorem.Word())
			.RuleFor(e => e.MatchingRecordType, fake => fake.Lorem.Word())
			.RuleFor(e => e.MatchingRecordType2, fake => fake.PickRandom<DuplicateDetectionRule.eMatchingRecordType>())
			.RuleFor(e => e.Modifiedbyname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Modifiedbyyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.ModifiedOn, fake => fake.Date.Soon())
			.RuleFor(e => e.Modifiedonbehalfbyname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Modifiedonbehalfbyyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.RuleName, fake => fake.Lorem.Word())
			.RuleFor(e => e.Owneridname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Owneridtype, fake => fake.Lorem.Word())
			.RuleFor(e => e.Owneridyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.Status, fake => fake.PickRandom<DuplicateDetectionRule.eStatus>())
			.RuleFor(e => e.StatusReason, fake => fake.PickRandom<DuplicateDetectionRule.eStatusReason>())
			.RuleFor(e => e.Timezoneruleversionnumber, fake => fake.Random.Int())
			.RuleFor(e => e.Utcconversiontimezonecode, fake => fake.Random.Int());
			return faker.Generate();
		}
		#endregion
	}
}

