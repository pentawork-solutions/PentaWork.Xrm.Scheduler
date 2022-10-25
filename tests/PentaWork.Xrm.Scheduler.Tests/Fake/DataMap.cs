using Bogus;
using System;
using FakeXrmEasy;
using System.Collections.Generic;
using PentaWork.Xrm.Scheduler.Proxies.Entities;

namespace PentaWork.Xrm.Scheduler.Tests.Fake
{
	public static class FakeDataMap
	{	
		#region FakeRelationships
		public static class Relationships 
		{
			/// <summary>1:N ColumnMapping_ImportMap</summary>
			public static readonly XrmFakedRelationship ColumnMappingImportMap = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "importmapid",
					Entity2Attribute = "importmapid",
					Entity1LogicalName = "importmap",
					Entity2LogicalName = "columnmapping",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N ImportEntityMapping_ImportMap</summary>
			public static readonly XrmFakedRelationship ImportEntityMappingImportMap = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "importmapid",
					Entity2Attribute = "importmapid",
					Entity1LogicalName = "importmap",
					Entity2LogicalName = "importentitymapping",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N ImportMap_AsyncOperations</summary>
			public static readonly XrmFakedRelationship ImportMapAsyncOperations = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "importmapid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "importmap",
					Entity2LogicalName = "asyncoperation",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N ImportMap_BulkDeleteFailures</summary>
			public static readonly XrmFakedRelationship ImportMapBulkDeleteFailures = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "importmapid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "importmap",
					Entity2LogicalName = "bulkdeletefailure",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N ImportMap_ImportFile</summary>
			public static readonly XrmFakedRelationship ImportMapImportFile = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "importmapid",
					Entity2Attribute = "importmapid",
					Entity1LogicalName = "importmap",
					Entity2LogicalName = "importfile",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N ImportMap_SyncErrors</summary>
			public static readonly XrmFakedRelationship ImportMapSyncErrors = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "importmapid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "importmap",
					Entity2LogicalName = "syncerror",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N OwnerMapping_ImportMap</summary>
			public static readonly XrmFakedRelationship OwnerMappingImportMap = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "importmapid",
					Entity2Attribute = "importmapid",
					Entity1LogicalName = "importmap",
					Entity2LogicalName = "ownermapping",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N TransformationMapping_ImportMap</summary>
			public static readonly XrmFakedRelationship TransformationMappingImportMap = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "importmapid",
					Entity2Attribute = "importmapid",
					Entity1LogicalName = "importmap",
					Entity2LogicalName = "transformationmapping",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

		}
		#endregion

		#region Fake
		public static DataMap Create()
		{
			var faker = new Faker<DataMap>()
			.RuleFor(e => e.ComponentState, fake => fake.PickRandom<DataMap.egComponentState>())
			.RuleFor(e => e.Createdbyname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Createdbyyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.CreatedOn, fake => fake.Date.Soon())
			.RuleFor(e => e.Createdonbehalfbyname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Createdonbehalfbyyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.Description, fake => fake.Lorem.Word())
			.RuleFor(e => e.EntitiesPerFile, fake => fake.PickRandom<DataMap.eEntitiesPerFile>())
			.RuleFor(e => e.Id, fake => Guid.NewGuid())
			.RuleFor(e => e.ImportmapiduniqueId, fake => Guid.NewGuid())
			.RuleFor(e => e.MapType, fake => fake.PickRandom<DataMap.eMapType>())
			.RuleFor(e => e.IntroducedVersion, fake => fake.Lorem.Word())
			.RuleFor(e => e.State, fake => fake.Random.Bool())
			.RuleFor(e => e.IsValidForImport, fake => fake.Random.Bool())
			.RuleFor(e => e.IsWizardCreated, fake => fake.Random.Bool())
			.RuleFor(e => e.MapCustomizations, fake => fake.Lorem.Word())
			.RuleFor(e => e.Modifiedbyname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Modifiedbyyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.ModifiedOn, fake => fake.Date.Soon())
			.RuleFor(e => e.Modifiedonbehalfbyname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Modifiedonbehalfbyyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.MapName, fake => fake.Lorem.Word())
			.RuleFor(e => e.RecordOverwriteTime, fake => fake.Date.Soon())
			.RuleFor(e => e.Owneridname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Owneridtype, fake => fake.Lorem.Word())
			.RuleFor(e => e.Owneridyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.SolutionId, fake => Guid.NewGuid())
			.RuleFor(e => e.Source, fake => fake.Lorem.Word())
			.RuleFor(e => e.SourceSystemType, fake => fake.PickRandom<DataMap.eSourceSystemType>())
			.RuleFor(e => e.SourceUserValue, fake => fake.Lorem.Word())
			.RuleFor(e => e.SourceUserIdentifier, fake => fake.Lorem.Word())
			.RuleFor(e => e.Status, fake => fake.PickRandom<DataMap.eStatus>())
			.RuleFor(e => e.StatusReason, fake => fake.PickRandom<DataMap.eStatusReason>())
			.RuleFor(e => e.SolutionId2, fake => Guid.NewGuid())
			.RuleFor(e => e.RecordType, fake => fake.PickRandom<DataMap.eRecordType>())
			.RuleFor(e => e.TargetUserValue, fake => fake.Lorem.Word());
			return faker.Generate();
		}
		#endregion
	}
}

