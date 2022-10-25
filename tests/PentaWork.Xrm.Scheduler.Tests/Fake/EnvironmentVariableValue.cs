using Bogus;
using System;
using FakeXrmEasy;
using System.Collections.Generic;
using PentaWork.Xrm.Scheduler.Proxies.Entities;

namespace PentaWork.Xrm.Scheduler.Tests.Fake
{
	public static class FakeEnvironmentVariableValue
	{	
		#region FakeRelationships
		public static class Relationships 
		{
			/// <summary>1:N environmentvariablevalue_AsyncOperations</summary>
			public static readonly XrmFakedRelationship EnvironmentvariablevalueAsyncOperations = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "environmentvariablevalueid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "environmentvariablevalue",
					Entity2LogicalName = "asyncoperation",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N environmentvariablevalue_BulkDeleteFailures</summary>
			public static readonly XrmFakedRelationship EnvironmentvariablevalueBulkDeleteFailures = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "environmentvariablevalueid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "environmentvariablevalue",
					Entity2LogicalName = "bulkdeletefailure",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N environmentvariablevalue_DuplicateBaseRecord</summary>
			public static readonly XrmFakedRelationship EnvironmentvariablevalueDuplicateBaseRecord = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "environmentvariablevalueid",
					Entity2Attribute = "baserecordid",
					Entity1LogicalName = "environmentvariablevalue",
					Entity2LogicalName = "duplicaterecord",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N environmentvariablevalue_DuplicateMatchingRecord</summary>
			public static readonly XrmFakedRelationship EnvironmentvariablevalueDuplicateMatchingRecord = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "environmentvariablevalueid",
					Entity2Attribute = "duplicaterecordid",
					Entity1LogicalName = "environmentvariablevalue",
					Entity2LogicalName = "duplicaterecord",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N environmentvariablevalue_MailboxTrackingFolders</summary>
			public static readonly XrmFakedRelationship EnvironmentvariablevalueMailboxTrackingFolders = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "environmentvariablevalueid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "environmentvariablevalue",
					Entity2LogicalName = "mailboxtrackingfolder",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N environmentvariablevalue_PrincipalObjectAttributeAccesses</summary>
			public static readonly XrmFakedRelationship EnvironmentvariablevaluePrincipalObjectAttributeAccesses = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "environmentvariablevalueid",
					Entity2Attribute = "objectid",
					Entity1LogicalName = "environmentvariablevalue",
					Entity2LogicalName = "principalobjectattributeaccess",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N environmentvariablevalue_ProcessSession</summary>
			public static readonly XrmFakedRelationship EnvironmentvariablevalueProcessSession = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "environmentvariablevalueid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "environmentvariablevalue",
					Entity2LogicalName = "processsession",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N environmentvariablevalue_SyncErrors</summary>
			public static readonly XrmFakedRelationship EnvironmentvariablevalueSyncErrors = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "environmentvariablevalueid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "environmentvariablevalue",
					Entity2LogicalName = "syncerror",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

		}
		#endregion

		#region Fake
		public static EnvironmentVariableValue Create()
		{
			var faker = new Faker<EnvironmentVariableValue>()
			.RuleFor(e => e.ComponentState, fake => fake.PickRandom<EnvironmentVariableValue.egComponentState>())
			.RuleFor(e => e.Createdbyname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Createdbyyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.CreatedOn, fake => fake.Date.Soon())
			.RuleFor(e => e.Createdonbehalfbyname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Createdonbehalfbyyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.Environmentvariabledefinitionidname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Id, fake => Guid.NewGuid())
			.RuleFor(e => e.EnvironmentvariablevalueiduniqueId, fake => Guid.NewGuid())
			.RuleFor(e => e.ImportSequenceNumber, fake => fake.Random.Int())
			.RuleFor(e => e.IntroducedVersion, fake => fake.Lorem.Word())
			.RuleFor(e => e.IsManaged, fake => fake.Random.Bool())
			.RuleFor(e => e.Modifiedbyname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Modifiedbyyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.ModifiedOn, fake => fake.Date.Soon())
			.RuleFor(e => e.Modifiedonbehalfbyname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Modifiedonbehalfbyyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.RecordCreatedOn, fake => fake.Date.Soon())
			.RuleFor(e => e.RecordOverwriteTime, fake => fake.Date.Soon())
			.RuleFor(e => e.Owneridname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Owneridtype, fake => fake.Lorem.Word())
			.RuleFor(e => e.Owneridyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.SchemaName, fake => fake.Lorem.Word())
			.RuleFor(e => e.SolutionId, fake => Guid.NewGuid())
			.RuleFor(e => e.Status, fake => fake.PickRandom<EnvironmentVariableValue.eStatus>())
			.RuleFor(e => e.StatusReason, fake => fake.PickRandom<EnvironmentVariableValue.eStatusReason>())
			.RuleFor(e => e.SolutionId2, fake => Guid.NewGuid())
			.RuleFor(e => e.TimeZoneRuleVersionNumber, fake => fake.Random.Int())
			.RuleFor(e => e.UTCConversionTimeZoneCode, fake => fake.Random.Int())
			.RuleFor(e => e.Value, fake => fake.Lorem.Word())
			.RuleFor(e => e.VersionNumber, fake => fake.Random.Int());
			return faker.Generate();
		}
		#endregion
	}
}

