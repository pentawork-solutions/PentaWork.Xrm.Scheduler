using Bogus;
using System;
using FakeXrmEasy;
using System.Collections.Generic;
using PentaWork.Xrm.Scheduler.Proxies.Entities;

namespace PentaWork.Xrm.Scheduler.Tests.Fake
{
	public static class FakeFlowcardtype
	{	
		#region FakeRelationships
		public static class Relationships 
		{
			/// <summary>1:N msdyn_flowcardtype_AsyncOperations</summary>
			public static readonly XrmFakedRelationship MsdynFlowcardtypeAsyncOperations = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "msdyn_flowcardtypeid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "msdyn_flowcardtype",
					Entity2LogicalName = "asyncoperation",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N msdyn_flowcardtype_BulkDeleteFailures</summary>
			public static readonly XrmFakedRelationship MsdynFlowcardtypeBulkDeleteFailures = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "msdyn_flowcardtypeid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "msdyn_flowcardtype",
					Entity2LogicalName = "bulkdeletefailure",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N msdyn_flowcardtype_DuplicateBaseRecord</summary>
			public static readonly XrmFakedRelationship MsdynFlowcardtypeDuplicateBaseRecord = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "msdyn_flowcardtypeid",
					Entity2Attribute = "baserecordid",
					Entity1LogicalName = "msdyn_flowcardtype",
					Entity2LogicalName = "duplicaterecord",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N msdyn_flowcardtype_DuplicateMatchingRecord</summary>
			public static readonly XrmFakedRelationship MsdynFlowcardtypeDuplicateMatchingRecord = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "msdyn_flowcardtypeid",
					Entity2Attribute = "duplicaterecordid",
					Entity1LogicalName = "msdyn_flowcardtype",
					Entity2LogicalName = "duplicaterecord",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N msdyn_flowcardtype_MailboxTrackingFolders</summary>
			public static readonly XrmFakedRelationship MsdynFlowcardtypeMailboxTrackingFolders = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "msdyn_flowcardtypeid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "msdyn_flowcardtype",
					Entity2LogicalName = "mailboxtrackingfolder",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N msdyn_flowcardtype_PrincipalObjectAttributeAccesses</summary>
			public static readonly XrmFakedRelationship MsdynFlowcardtypePrincipalObjectAttributeAccesses = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "msdyn_flowcardtypeid",
					Entity2Attribute = "objectid",
					Entity1LogicalName = "msdyn_flowcardtype",
					Entity2LogicalName = "principalobjectattributeaccess",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N msdyn_flowcardtype_ProcessSession</summary>
			public static readonly XrmFakedRelationship MsdynFlowcardtypeProcessSession = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "msdyn_flowcardtypeid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "msdyn_flowcardtype",
					Entity2LogicalName = "processsession",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N msdyn_flowcardtype_SyncErrors</summary>
			public static readonly XrmFakedRelationship MsdynFlowcardtypeSyncErrors = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "msdyn_flowcardtypeid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "msdyn_flowcardtype",
					Entity2LogicalName = "syncerror",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

		}
		#endregion

		#region Fake
		public static Flowcardtype Create()
		{
			var faker = new Faker<Flowcardtype>()
			.RuleFor(e => e.Createdbyname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Createdbyyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.CreatedOn, fake => fake.Date.Soon())
			.RuleFor(e => e.Createdonbehalfbyname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Createdonbehalfbyyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.ImportSequenceNumber, fake => fake.Random.Int())
			.RuleFor(e => e.Modifiedbyname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Modifiedbyyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.ModifiedOn, fake => fake.Date.Soon())
			.RuleFor(e => e.Modifiedonbehalfbyname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Modifiedonbehalfbyyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.ActionCommand, fake => fake.Lorem.Word())
			.RuleFor(e => e.Actionname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Cardname, fake => fake.Lorem.Word())
			.RuleFor(e => e.MsdynCardtypeidname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Description, fake => fake.Lorem.Word())
			.RuleFor(e => e.Id, fake => Guid.NewGuid())
			.RuleFor(e => e.Flowname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Iscdsflow, fake => fake.Random.Bool())
			.RuleFor(e => e.Isdeleted, fake => fake.Random.Bool())
			.RuleFor(e => e.Name, fake => fake.Lorem.Word())
			.RuleFor(e => e.Samplebody, fake => fake.Lorem.Word())
			.RuleFor(e => e.Sampletitle, fake => fake.Lorem.Word())
			.RuleFor(e => e.Workflowid, fake => fake.Lorem.Word())
			.RuleFor(e => e.RecordCreatedOn, fake => fake.Date.Soon())
			.RuleFor(e => e.Owneridname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Owneridtype, fake => fake.Lorem.Word())
			.RuleFor(e => e.Owneridyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.Status, fake => fake.PickRandom<Flowcardtype.eStatus>())
			.RuleFor(e => e.StatusReason, fake => fake.PickRandom<Flowcardtype.eStatusReason>())
			.RuleFor(e => e.TimeZoneRuleVersionNumber, fake => fake.Random.Int())
			.RuleFor(e => e.UTCConversionTimeZoneCode, fake => fake.Random.Int())
			.RuleFor(e => e.VersionNumber, fake => fake.Random.Int());
			return faker.Generate();
		}
		#endregion
	}
}

