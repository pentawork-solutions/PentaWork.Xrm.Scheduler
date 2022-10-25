using Bogus;
using System;
using FakeXrmEasy;
using System.Collections.Generic;
using PentaWork.Xrm.Scheduler.Proxies.Entities;

namespace PentaWork.Xrm.Scheduler.Tests.Fake
{
	public static class FakeSubject
	{	
		#region FakeRelationships
		public static class Relationships 
		{
			/// <summary>1:N msdyn_subject_knowledgearticletemplate_subjectid</summary>
			public static readonly XrmFakedRelationship MsdynSubjectKnowledgearticletemplateSubjectid = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "subjectid",
					Entity2Attribute = "msdyn_subjectid",
					Entity1LogicalName = "subject",
					Entity2LogicalName = "msdyn_knowledgearticletemplate",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N Subject_AsyncOperations</summary>
			public static readonly XrmFakedRelationship SubjectAsyncOperations = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "subjectid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "subject",
					Entity2LogicalName = "asyncoperation",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N Subject_BulkDeleteFailures</summary>
			public static readonly XrmFakedRelationship SubjectBulkDeleteFailures = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "subjectid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "subject",
					Entity2LogicalName = "bulkdeletefailure",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N subject_incidents</summary>
			public static readonly XrmFakedRelationship SubjectIncidents = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "subjectid",
					Entity2Attribute = "subjectid",
					Entity1LogicalName = "subject",
					Entity2LogicalName = "incident",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N subject_kb_articles</summary>
			public static readonly XrmFakedRelationship SubjectKbArticles = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "subjectid",
					Entity2Attribute = "subjectid",
					Entity1LogicalName = "subject",
					Entity2LogicalName = "kbarticle",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N subject_knowledgearticles</summary>
			public static readonly XrmFakedRelationship SubjectKnowledgearticles = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "subjectid",
					Entity2Attribute = "subjectid",
					Entity1LogicalName = "subject",
					Entity2LogicalName = "knowledgearticle",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N subject_parent_subject</summary>
			public static readonly XrmFakedRelationship SubjectParentSubject = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "subjectid",
					Entity2Attribute = "parentsubject",
					Entity1LogicalName = "subject",
					Entity2LogicalName = "subject",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N Subject_ProcessSessions</summary>
			public static readonly XrmFakedRelationship SubjectProcessSessions = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "subjectid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "subject",
					Entity2LogicalName = "processsession",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N subject_products</summary>
			public static readonly XrmFakedRelationship SubjectProducts = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "subjectid",
					Entity2Attribute = "subjectid",
					Entity1LogicalName = "subject",
					Entity2LogicalName = "product",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N subject_sales_literature</summary>
			public static readonly XrmFakedRelationship SubjectSalesLiterature = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "subjectid",
					Entity2Attribute = "subjectid",
					Entity1LogicalName = "subject",
					Entity2LogicalName = "salesliterature",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N Subject_SyncErrors</summary>
			public static readonly XrmFakedRelationship SubjectSyncErrors = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "subjectid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "subject",
					Entity2LogicalName = "syncerror",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

		}
		#endregion

		#region Fake
		public static Subject Create()
		{
			var faker = new Faker<Subject>()
			.RuleFor(e => e.Createdbyexternalpartyname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Createdbyexternalpartyyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.Createdbyname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Createdbyyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.CreatedOn, fake => fake.Date.Soon())
			.RuleFor(e => e.Createdonbehalfbyname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Createdonbehalfbyyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.Description, fake => fake.Lorem.Word())
			.RuleFor(e => e.FeatureMask, fake => fake.Random.Int())
			.RuleFor(e => e.ImportSequenceNumber, fake => fake.Random.Int())
			.RuleFor(e => e.Modifiedbyexternalpartyname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Modifiedbyexternalpartyyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.Modifiedbyname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Modifiedbyyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.ModifiedOn, fake => fake.Date.Soon())
			.RuleFor(e => e.Modifiedonbehalfbyname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Modifiedonbehalfbyyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.Organizationidname, fake => fake.Lorem.Word())
			.RuleFor(e => e.RecordCreatedOn, fake => fake.Date.Soon())
			.RuleFor(e => e.Parentsubjectname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Id, fake => Guid.NewGuid())
			.RuleFor(e => e.Title, fake => fake.Lorem.Word())
			.RuleFor(e => e.VersionNumber, fake => fake.Random.Int());
			return faker.Generate();
		}
		#endregion
	}
}

