using Bogus;
using System;
using FakeXrmEasy;
using System.Collections.Generic;
using PentaWork.Xrm.Scheduler.Proxies.Entities;

namespace PentaWork.Xrm.Scheduler.Tests.Fake
{
	public static class FakeEnvironmentVariableDefinition
	{	
		#region FakeRelationships
		public static class Relationships 
		{
			/// <summary>1:N environmentvariabledefinition_AsyncOperations</summary>
			public static readonly XrmFakedRelationship EnvironmentvariabledefinitionAsyncOperations = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "environmentvariabledefinitionid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "environmentvariabledefinition",
					Entity2LogicalName = "asyncoperation",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N environmentvariabledefinition_BulkDeleteFailures</summary>
			public static readonly XrmFakedRelationship EnvironmentvariabledefinitionBulkDeleteFailures = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "environmentvariabledefinitionid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "environmentvariabledefinition",
					Entity2LogicalName = "bulkdeletefailure",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N environmentvariabledefinition_DuplicateBaseRecord</summary>
			public static readonly XrmFakedRelationship EnvironmentvariabledefinitionDuplicateBaseRecord = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "environmentvariabledefinitionid",
					Entity2Attribute = "baserecordid",
					Entity1LogicalName = "environmentvariabledefinition",
					Entity2LogicalName = "duplicaterecord",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N environmentvariabledefinition_DuplicateMatchingRecord</summary>
			public static readonly XrmFakedRelationship EnvironmentvariabledefinitionDuplicateMatchingRecord = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "environmentvariabledefinitionid",
					Entity2Attribute = "duplicaterecordid",
					Entity1LogicalName = "environmentvariabledefinition",
					Entity2LogicalName = "duplicaterecord",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N environmentvariabledefinition_environmentvariablevalue</summary>
			public static readonly XrmFakedRelationship EnvironmentvariabledefinitionEnvironmentvariablevalue = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "environmentvariabledefinitionid",
					Entity2Attribute = "environmentvariabledefinitionid",
					Entity1LogicalName = "environmentvariabledefinition",
					Entity2LogicalName = "environmentvariablevalue",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N environmentvariabledefinition_MailboxTrackingFolders</summary>
			public static readonly XrmFakedRelationship EnvironmentvariabledefinitionMailboxTrackingFolders = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "environmentvariabledefinitionid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "environmentvariabledefinition",
					Entity2LogicalName = "mailboxtrackingfolder",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N environmentvariabledefinition_PrincipalObjectAttributeAccesses</summary>
			public static readonly XrmFakedRelationship EnvironmentvariabledefinitionPrincipalObjectAttributeAccesses = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "environmentvariabledefinitionid",
					Entity2Attribute = "objectid",
					Entity1LogicalName = "environmentvariabledefinition",
					Entity2LogicalName = "principalobjectattributeaccess",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N environmentvariabledefinition_ProcessSession</summary>
			public static readonly XrmFakedRelationship EnvironmentvariabledefinitionProcessSession = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "environmentvariabledefinitionid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "environmentvariabledefinition",
					Entity2LogicalName = "processsession",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N environmentvariabledefinition_SyncErrors</summary>
			public static readonly XrmFakedRelationship EnvironmentvariabledefinitionSyncErrors = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "environmentvariabledefinitionid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "environmentvariabledefinition",
					Entity2LogicalName = "syncerror",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

		}
		#endregion

		#region Fake
		public static EnvironmentVariableDefinition Create()
		{
			var faker = new Faker<EnvironmentVariableDefinition>()
			.RuleFor(e => e.ComponentState, fake => fake.PickRandom<EnvironmentVariableDefinition.egComponentState>())
			.RuleFor(e => e.ConnectionId, fake => fake.Lorem.Word())
			.RuleFor(e => e.Createdbyname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Createdbyyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.CreatedOn, fake => fake.Date.Soon())
			.RuleFor(e => e.Createdonbehalfbyname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Createdonbehalfbyyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.DataSourceType, fake => fake.Lorem.Word())
			.RuleFor(e => e.DefaultValue, fake => fake.Lorem.Word())
			.RuleFor(e => e.Description, fake => fake.Lorem.Word())
			.RuleFor(e => e.DisplayName, fake => fake.Lorem.Word())
			.RuleFor(e => e.Id, fake => Guid.NewGuid())
			.RuleFor(e => e.EnvironmentvariabledefinitioniduniqueId, fake => Guid.NewGuid())
			.RuleFor(e => e.Hint, fake => fake.Lorem.Word())
			.RuleFor(e => e.ImportSequenceNumber, fake => fake.Random.Int())
			.RuleFor(e => e.IntroducedVersion, fake => fake.Lorem.Word())
			.RuleFor(e => e.IsManaged, fake => fake.Random.Bool())
			.RuleFor(e => e.IsRequired, fake => fake.Random.Bool())
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
			.RuleFor(e => e.Status, fake => fake.PickRandom<EnvironmentVariableDefinition.eStatus>())
			.RuleFor(e => e.StatusReason, fake => fake.PickRandom<EnvironmentVariableDefinition.eStatusReason>())
			.RuleFor(e => e.SolutionId2, fake => Guid.NewGuid())
			.RuleFor(e => e.TimeZoneRuleVersionNumber, fake => fake.Random.Int())
			.RuleFor(e => e.Type, fake => fake.PickRandom<EnvironmentVariableDefinition.eType>())
			.RuleFor(e => e.UTCConversionTimeZoneCode, fake => fake.Random.Int())
			.RuleFor(e => e.ValueSchema, fake => fake.Lorem.Word())
			.RuleFor(e => e.VersionNumber, fake => fake.Random.Int());
			return faker.Generate();
		}
		#endregion
	}
}

