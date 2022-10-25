using Bogus;
using System;
using FakeXrmEasy;
using System.Collections.Generic;
using PentaWork.Xrm.Scheduler.Proxies.Entities;

namespace PentaWork.Xrm.Scheduler.Tests.Fake
{
	public static class FakeImportSourceFile
	{	
		#region FakeRelationships
		public static class Relationships 
		{
			/// <summary>1:N ImportFile_AsyncOperations</summary>
			public static readonly XrmFakedRelationship ImportFileAsyncOperations = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "importfileid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "importfile",
					Entity2LogicalName = "asyncoperation",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N ImportFile_BulkDeleteFailures</summary>
			public static readonly XrmFakedRelationship ImportFileBulkDeleteFailures = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "importfileid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "importfile",
					Entity2LogicalName = "bulkdeletefailure",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N ImportFile_ImportData</summary>
			public static readonly XrmFakedRelationship ImportFileImportData = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "importfileid",
					Entity2Attribute = "importfileid",
					Entity1LogicalName = "importfile",
					Entity2LogicalName = "importdata",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N ImportLog_ImportFile</summary>
			public static readonly XrmFakedRelationship ImportLogImportFile = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "importfileid",
					Entity2Attribute = "importfileid",
					Entity1LogicalName = "importfile",
					Entity2LogicalName = "importlog",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

		}
		#endregion

		#region Fake
		public static ImportSourceFile Create()
		{
			var faker = new Faker<ImportSourceFile>()
			.RuleFor(e => e.AdditionalHeader, fake => fake.Lorem.Word())
			.RuleFor(e => e.CompletedOn, fake => fake.Date.Soon())
			.RuleFor(e => e.Content, fake => fake.Lorem.Word())
			.RuleFor(e => e.Createdbyname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Createdbyyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.CreatedOn, fake => fake.Date.Soon())
			.RuleFor(e => e.Createdonbehalfbyname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Createdonbehalfbyyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.DataDelimiter, fake => fake.PickRandom<ImportSourceFile.eDataDelimiter>())
			.RuleFor(e => e.EnableDuplicateDetection, fake => fake.Random.Bool())
			.RuleFor(e => e.EntityKeyId, fake => Guid.NewGuid())
			.RuleFor(e => e.Errors, fake => fake.Random.Int())
			.RuleFor(e => e.FieldDelimiter, fake => fake.PickRandom<ImportSourceFile.eFieldDelimiter>())
			.RuleFor(e => e.FileType, fake => fake.PickRandom<ImportSourceFile.eFileType>())
			.RuleFor(e => e.Header, fake => fake.Lorem.Word())
			.RuleFor(e => e.Id, fake => Guid.NewGuid())
			.RuleFor(e => e.Importidname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Importmapidname, fake => fake.Lorem.Word())
			.RuleFor(e => e.IsFirstRowHeader, fake => fake.Random.Bool())
			.RuleFor(e => e.Modifiedbyname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Modifiedbyyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.ModifiedOn, fake => fake.Date.Soon())
			.RuleFor(e => e.Modifiedonbehalfbyname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Modifiedonbehalfbyyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.ImportName, fake => fake.Lorem.Word())
			.RuleFor(e => e.Owneridname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Owneridtype, fake => fake.Lorem.Word())
			.RuleFor(e => e.Owneridyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.ParseTableColumnPrefix, fake => fake.Lorem.Word())
			.RuleFor(e => e.ParseTableColumnNumber, fake => fake.Random.Int())
			.RuleFor(e => e.ParseTable, fake => fake.Lorem.Word())
			.RuleFor(e => e.PartialFailures, fake => fake.Random.Int())
			.RuleFor(e => e.ProcessCode, fake => fake.PickRandom<ImportSourceFile.eProcessCode>())
			.RuleFor(e => e.ProcessingStatus, fake => fake.PickRandom<ImportSourceFile.eProcessingStatus>())
			.RuleFor(e => e.ProgressCounter, fake => fake.Random.Int())
			.RuleFor(e => e.Recordsowneridname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Recordsowneridtype, fake => fake.Lorem.Word())
			.RuleFor(e => e.Relatedentitycolumns, fake => fake.Lorem.Word())
			.RuleFor(e => e.Size, fake => fake.Lorem.Word())
			.RuleFor(e => e.Source, fake => fake.Lorem.Word())
			.RuleFor(e => e.SourceEntity, fake => fake.Lorem.Word())
			.RuleFor(e => e.Status, fake => fake.PickRandom<ImportSourceFile.eStatus>())
			.RuleFor(e => e.StatusReason, fake => fake.PickRandom<ImportSourceFile.eStatusReason>())
			.RuleFor(e => e.Successes, fake => fake.Random.Int())
			.RuleFor(e => e.TargetEntity, fake => fake.Lorem.Word())
			.RuleFor(e => e.Timezoneruleversionnumber, fake => fake.Random.Int())
			.RuleFor(e => e.TotalProcessed, fake => fake.Random.Int())
			.RuleFor(e => e.UpsertMode, fake => fake.PickRandom<ImportSourceFile.eUpsertMode>())
			.RuleFor(e => e.UseSystemMap, fake => fake.Random.Bool())
			.RuleFor(e => e.Utcconversiontimezonecode, fake => fake.Random.Int());
			return faker.Generate();
		}
		#endregion
	}
}

