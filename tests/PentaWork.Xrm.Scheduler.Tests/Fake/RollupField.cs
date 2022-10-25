using Bogus;
using System;
using FakeXrmEasy;
using System.Collections.Generic;
using PentaWork.Xrm.Scheduler.Proxies.Entities;

namespace PentaWork.Xrm.Scheduler.Tests.Fake
{
	public static class FakeRollupField
	{	
		#region FakeRelationships
		public static class Relationships 
		{
			/// <summary>1:N rollupfield_AsyncOperations</summary>
			public static readonly XrmFakedRelationship RollupfieldAsyncOperations = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "rollupfieldid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "rollupfield",
					Entity2LogicalName = "asyncoperation",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N rollupfield_ProcessSessions</summary>
			public static readonly XrmFakedRelationship RollupfieldProcessSessions = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "rollupfieldid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "rollupfield",
					Entity2LogicalName = "processsession",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N RollupField_SyncErrors</summary>
			public static readonly XrmFakedRelationship RollupFieldSyncErrors = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "rollupfieldid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "rollupfield",
					Entity2LogicalName = "syncerror",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

		}
		#endregion

		#region Fake
		public static RollupField Create()
		{
			var faker = new Faker<RollupField>()
			.RuleFor(e => e.Createdbyname, fake => fake.Lorem.Word())
			.RuleFor(e => e.CreatedOn, fake => fake.Date.Soon())
			.RuleFor(e => e.Createdonbehalfbyname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Createdonbehalfbyyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.DateField, fake => fake.Lorem.Word())
			.RuleFor(e => e.RecordType, fake => fake.Lorem.Word())
			.RuleFor(e => e.RollupField2, fake => fake.Lorem.Word())
			.RuleFor(e => e.ImportSequenceNumber, fake => fake.Random.Int())
			.RuleFor(e => e.IsStateStatusFromParentEntity, fake => fake.Random.Bool())
			.RuleFor(e => e.Metricidname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Modifiedbyname, fake => fake.Lorem.Word())
			.RuleFor(e => e.ModifiedOn, fake => fake.Date.Soon())
			.RuleFor(e => e.Modifiedonbehalfbyname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Modifiedonbehalfbyyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.Id, fake => Guid.NewGuid())
			.RuleFor(e => e.SourceField, fake => fake.Lorem.Word())
			.RuleFor(e => e.SourceRecordType, fake => fake.Lorem.Word())
			.RuleFor(e => e.SourceRecordTypeState, fake => fake.Random.Int())
			.RuleFor(e => e.SourceRecordTypeStatus, fake => fake.Random.Int())
			.RuleFor(e => e.TimeZoneRuleVersionNumber, fake => fake.Random.Int())
			.RuleFor(e => e.UTCConversionTimeZoneCode, fake => fake.Random.Int())
			.RuleFor(e => e.VersionNumber, fake => fake.Random.Int());
			return faker.Generate();
		}
		#endregion
	}
}

