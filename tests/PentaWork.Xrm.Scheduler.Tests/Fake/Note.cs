using Bogus;
using System;
using FakeXrmEasy;
using System.Collections.Generic;
using PentaWork.Xrm.Scheduler.Proxies.Entities;

namespace PentaWork.Xrm.Scheduler.Tests.Fake
{
	public static class FakeNote
	{	
		#region FakeRelationships
		public static class Relationships 
		{
			/// <summary>1:N Annotation_AsyncOperations</summary>
			public static readonly XrmFakedRelationship AnnotationAsyncOperations = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "annotationid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "annotation",
					Entity2LogicalName = "asyncoperation",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N Annotation_BulkDeleteFailures</summary>
			public static readonly XrmFakedRelationship AnnotationBulkDeleteFailures = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "annotationid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "annotation",
					Entity2LogicalName = "bulkdeletefailure",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N Annotation_ProcessSessions</summary>
			public static readonly XrmFakedRelationship AnnotationProcessSessions = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "annotationid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "annotation",
					Entity2LogicalName = "processsession",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N Annotation_SyncErrors</summary>
			public static readonly XrmFakedRelationship AnnotationSyncErrors = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "annotationid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "annotation",
					Entity2LogicalName = "syncerror",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

		}
		#endregion

		#region Fake
		public static Note Create()
		{
			var faker = new Faker<Note>()
			.RuleFor(e => e.Id, fake => Guid.NewGuid())
			.RuleFor(e => e.Createdbyname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Createdbyyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.CreatedOn, fake => fake.Date.Soon())
			.RuleFor(e => e.Createdonbehalfbyname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Createdonbehalfbyyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.Document, fake => fake.Lorem.Word())
			.RuleFor(e => e.FileName, fake => fake.Lorem.Word())
			.RuleFor(e => e.FilePointer, fake => fake.Lorem.Word())
			.RuleFor(e => e.FileSizeBytes, fake => fake.Random.Int())
			.RuleFor(e => e.ImportSequenceNumber, fake => fake.Random.Int())
			.RuleFor(e => e.IsDocument, fake => fake.Random.Bool())
			.RuleFor(e => e.Isprivate, fake => fake.Random.Bool())
			.RuleFor(e => e.LanguageID, fake => fake.Lorem.Word())
			.RuleFor(e => e.MimeType, fake => fake.Lorem.Word())
			.RuleFor(e => e.Modifiedbyname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Modifiedbyyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.ModifiedOn, fake => fake.Date.Soon())
			.RuleFor(e => e.Modifiedonbehalfbyname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Modifiedonbehalfbyyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.Description, fake => fake.Lorem.Word())
			.RuleFor(e => e.RegardingObjectType, fake => fake.Lorem.Word())
			.RuleFor(e => e.ObjectType, fake => fake.Lorem.Word())
			.RuleFor(e => e.RecordCreatedOn, fake => fake.Date.Soon())
			.RuleFor(e => e.Owneridname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Owneridtype, fake => fake.Lorem.Word())
			.RuleFor(e => e.Owneridyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.Prefix, fake => fake.Lorem.Word())
			.RuleFor(e => e.StepId, fake => fake.Lorem.Word())
			.RuleFor(e => e.StoragePointer, fake => fake.Lorem.Word())
			.RuleFor(e => e.Title, fake => fake.Lorem.Word())
			.RuleFor(e => e.VersionNumber, fake => fake.Random.Int());
			return faker.Generate();
		}
		#endregion
	}
}

