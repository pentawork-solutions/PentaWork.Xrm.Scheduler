using Bogus;
using System;
using FakeXrmEasy;
using System.Collections.Generic;
using PentaWork.Xrm.Scheduler.Proxies.Entities;

namespace PentaWork.Xrm.Scheduler.Tests.Fake
{
	public static class FakeWorkflowBinary
	{	
		#region FakeRelationships
		public static class Relationships 
		{
			/// <summary>1:N workflowbinary_AsyncOperations</summary>
			public static readonly XrmFakedRelationship WorkflowbinaryAsyncOperations = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "workflowbinaryid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "workflowbinary",
					Entity2LogicalName = "asyncoperation",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N workflowbinary_BulkDeleteFailures</summary>
			public static readonly XrmFakedRelationship WorkflowbinaryBulkDeleteFailures = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "workflowbinaryid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "workflowbinary",
					Entity2LogicalName = "bulkdeletefailure",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N workflowbinary_FileAttachments</summary>
			public static readonly XrmFakedRelationship WorkflowbinaryFileAttachments = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "workflowbinaryid",
					Entity2Attribute = "objectid",
					Entity1LogicalName = "workflowbinary",
					Entity2LogicalName = "fileattachment",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N workflowbinary_MailboxTrackingFolders</summary>
			public static readonly XrmFakedRelationship WorkflowbinaryMailboxTrackingFolders = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "workflowbinaryid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "workflowbinary",
					Entity2LogicalName = "mailboxtrackingfolder",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N workflowbinary_PrincipalObjectAttributeAccesses</summary>
			public static readonly XrmFakedRelationship WorkflowbinaryPrincipalObjectAttributeAccesses = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "workflowbinaryid",
					Entity2Attribute = "objectid",
					Entity1LogicalName = "workflowbinary",
					Entity2LogicalName = "principalobjectattributeaccess",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N workflowbinary_ProcessSession</summary>
			public static readonly XrmFakedRelationship WorkflowbinaryProcessSession = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "workflowbinaryid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "workflowbinary",
					Entity2LogicalName = "processsession",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N workflowbinary_SyncErrors</summary>
			public static readonly XrmFakedRelationship WorkflowbinarySyncErrors = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "workflowbinaryid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "workflowbinary",
					Entity2LogicalName = "syncerror",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

		}
		#endregion

		#region Fake
		public static WorkflowBinary Create()
		{
			var faker = new Faker<WorkflowBinary>()
			.RuleFor(e => e.Createdbyname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Createdbyyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.CreatedOn, fake => fake.Date.Soon())
			.RuleFor(e => e.Createdonbehalfbyname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Createdonbehalfbyyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.DataName, fake => fake.Lorem.Word())
			.RuleFor(e => e.Flowsessionidname, fake => fake.Lorem.Word())
			.RuleFor(e => e.ImportSequenceNumber, fake => fake.Random.Int())
			.RuleFor(e => e.Metadata, fake => fake.Lorem.Word())
			.RuleFor(e => e.MimeType, fake => fake.Lorem.Word())
			.RuleFor(e => e.Modifiedbyname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Modifiedbyyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.ModifiedOn, fake => fake.Date.Soon())
			.RuleFor(e => e.Modifiedonbehalfbyname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Modifiedonbehalfbyyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.Name, fake => fake.Lorem.Word())
			.RuleFor(e => e.RecordCreatedOn, fake => fake.Date.Soon())
			.RuleFor(e => e.Owneridname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Owneridtype, fake => fake.Lorem.Word())
			.RuleFor(e => e.Owneridyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.Processname, fake => fake.Lorem.Word())
			.RuleFor(e => e.ReferenceName, fake => fake.Lorem.Word())
			.RuleFor(e => e.Status, fake => fake.PickRandom<WorkflowBinary.eStatus>())
			.RuleFor(e => e.StatusReason, fake => fake.PickRandom<WorkflowBinary.eStatusReason>())
			.RuleFor(e => e.TimeZoneRuleVersionNumber, fake => fake.Random.Int())
			.RuleFor(e => e.Type, fake => fake.Lorem.Word())
			.RuleFor(e => e.UTCConversionTimeZoneCode, fake => fake.Random.Int())
			.RuleFor(e => e.VersionNumber, fake => fake.Random.Int())
			.RuleFor(e => e.Id, fake => Guid.NewGuid());
			return faker.Generate();
		}
		#endregion
	}
}

