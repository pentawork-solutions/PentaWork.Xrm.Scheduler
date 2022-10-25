using Bogus;
using System;
using FakeXrmEasy;
using System.Collections.Generic;
using PentaWork.Xrm.Scheduler.Proxies.Entities;

namespace PentaWork.Xrm.Scheduler.Tests.Fake
{
	public static class FakePhoneToCaseProcess
	{	
		#region FakeRelationships
		public static class Relationships 
		{
			/// <summary>1:N lk_phonetocaseprocess_workflowlogs</summary>
			public static readonly XrmFakedRelationship LkPhonetocaseprocessWorkflowlogs = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "businessprocessflowinstanceid",
					Entity2Attribute = "asyncoperationid",
					Entity1LogicalName = "phonetocaseprocess",
					Entity2LogicalName = "workflowlog",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N phonetocaseprocess_AsyncOperations</summary>
			public static readonly XrmFakedRelationship PhonetocaseprocessAsyncOperations = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "businessprocessflowinstanceid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "phonetocaseprocess",
					Entity2LogicalName = "asyncoperation",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N phonetocaseprocess_BulkDeleteFailures</summary>
			public static readonly XrmFakedRelationship PhonetocaseprocessBulkDeleteFailures = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "businessprocessflowinstanceid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "phonetocaseprocess",
					Entity2LogicalName = "bulkdeletefailure",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N phonetocaseprocess_MailboxTrackingFolders</summary>
			public static readonly XrmFakedRelationship PhonetocaseprocessMailboxTrackingFolders = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "businessprocessflowinstanceid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "phonetocaseprocess",
					Entity2LogicalName = "mailboxtrackingfolder",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N phonetocaseprocess_PrincipalObjectAttributeAccesses</summary>
			public static readonly XrmFakedRelationship PhonetocaseprocessPrincipalObjectAttributeAccesses = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "businessprocessflowinstanceid",
					Entity2Attribute = "objectid",
					Entity1LogicalName = "phonetocaseprocess",
					Entity2LogicalName = "principalobjectattributeaccess",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N phonetocaseprocess_ProcessSession</summary>
			public static readonly XrmFakedRelationship PhonetocaseprocessProcessSession = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "businessprocessflowinstanceid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "phonetocaseprocess",
					Entity2LogicalName = "processsession",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N PhoneToCaseProcess_SyncErrors</summary>
			public static readonly XrmFakedRelationship PhoneToCaseProcessSyncErrors = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "businessprocessflowinstanceid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "phonetocaseprocess",
					Entity2LogicalName = "syncerror",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

		}
		#endregion

		#region Fake
		public static PhoneToCaseProcess Create()
		{
			var faker = new Faker<PhoneToCaseProcess>()
			.RuleFor(e => e.Activestageidname, fake => fake.Lorem.Word())
			.RuleFor(e => e.ActiveStageStartedOn, fake => fake.Date.Soon())
			.RuleFor(e => e.Id, fake => Guid.NewGuid())
			.RuleFor(e => e.CompletedOn, fake => fake.Date.Soon())
			.RuleFor(e => e.Createdbyname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Createdbyyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.CreatedOn, fake => fake.Date.Soon())
			.RuleFor(e => e.Createdonbehalfbyname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Createdonbehalfbyyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.Duration, fake => fake.Random.Int())
			.RuleFor(e => e.ExchangeRate, fake => fake.Finance.Amount())
			.RuleFor(e => e.ImportSequenceNumber, fake => fake.Random.Int())
			.RuleFor(e => e.Incidentidname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Modifiedbyname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Modifiedbyyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.ModifiedOn, fake => fake.Date.Soon())
			.RuleFor(e => e.Modifiedonbehalfbyname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Modifiedonbehalfbyyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.ProcessName, fake => fake.Lorem.Word())
			.RuleFor(e => e.Organizationidname, fake => fake.Lorem.Word())
			.RuleFor(e => e.RecordCreatedOn, fake => fake.Date.Soon())
			.RuleFor(e => e.Processidname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Status, fake => fake.PickRandom<PhoneToCaseProcess.eStatus>())
			.RuleFor(e => e.StatusReason, fake => fake.PickRandom<PhoneToCaseProcess.eStatusReason>())
			.RuleFor(e => e.TimeZoneRuleVersionNumber, fake => fake.Random.Int())
			.RuleFor(e => e.Transactioncurrencyidname, fake => fake.Lorem.Word())
			.RuleFor(e => e.TraversedPath, fake => fake.Lorem.Word())
			.RuleFor(e => e.UTCConversionTimeZoneCode, fake => fake.Random.Int())
			.RuleFor(e => e.VersionNumber, fake => fake.Random.Int());
			return faker.Generate();
		}
		#endregion
	}
}

