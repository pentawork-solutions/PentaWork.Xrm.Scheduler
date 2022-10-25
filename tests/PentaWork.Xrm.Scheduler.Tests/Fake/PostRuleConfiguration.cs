using Bogus;
using System;
using FakeXrmEasy;
using System.Collections.Generic;
using PentaWork.Xrm.Scheduler.Proxies.Entities;

namespace PentaWork.Xrm.Scheduler.Tests.Fake
{
	public static class FakePostRuleConfiguration
	{	
		#region FakeRelationships
		public static class Relationships 
		{
			/// <summary>1:N msdyn_postruleconfig_AsyncOperations</summary>
			public static readonly XrmFakedRelationship MsdynPostruleconfigAsyncOperations = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "msdyn_postruleconfigid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "msdyn_postruleconfig",
					Entity2LogicalName = "asyncoperation",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N msdyn_postruleconfig_BulkDeleteFailures</summary>
			public static readonly XrmFakedRelationship MsdynPostruleconfigBulkDeleteFailures = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "msdyn_postruleconfigid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "msdyn_postruleconfig",
					Entity2LogicalName = "bulkdeletefailure",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N msdyn_postruleconfig_MailboxTrackingFolders</summary>
			public static readonly XrmFakedRelationship MsdynPostruleconfigMailboxTrackingFolders = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "msdyn_postruleconfigid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "msdyn_postruleconfig",
					Entity2LogicalName = "mailboxtrackingfolder",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N msdyn_postruleconfig_PrincipalObjectAttributeAccesses</summary>
			public static readonly XrmFakedRelationship MsdynPostruleconfigPrincipalObjectAttributeAccesses = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "msdyn_postruleconfigid",
					Entity2Attribute = "objectid",
					Entity1LogicalName = "msdyn_postruleconfig",
					Entity2LogicalName = "principalobjectattributeaccess",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N msdyn_postruleconfig_ProcessSession</summary>
			public static readonly XrmFakedRelationship MsdynPostruleconfigProcessSession = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "msdyn_postruleconfigid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "msdyn_postruleconfig",
					Entity2LogicalName = "processsession",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N msdyn_postruleconfig_SyncErrors</summary>
			public static readonly XrmFakedRelationship MsdynPostruleconfigSyncErrors = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "msdyn_postruleconfigid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "msdyn_postruleconfig",
					Entity2LogicalName = "syncerror",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

		}
		#endregion

		#region Fake
		public static PostRuleConfiguration Create()
		{
			var faker = new Faker<PostRuleConfiguration>()
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
			.RuleFor(e => e.FormatID, fake => fake.Lorem.Word())
			.RuleFor(e => e.Name, fake => fake.Lorem.Word())
			.RuleFor(e => e.MsdynPostconfigidname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Id, fake => Guid.NewGuid())
			.RuleFor(e => e.PostToYammerActivityStream, fake => fake.Random.Bool())
			.RuleFor(e => e.RuleID, fake => fake.Lorem.Word())
			.RuleFor(e => e.RuleSource, fake => fake.Lorem.Word())
			.RuleFor(e => e.StepID, fake => fake.Lorem.Word())
			.RuleFor(e => e.Organizationidname, fake => fake.Lorem.Word())
			.RuleFor(e => e.RecordCreatedOn, fake => fake.Date.Soon())
			.RuleFor(e => e.Status, fake => fake.PickRandom<PostRuleConfiguration.eStatus>())
			.RuleFor(e => e.StatusReason, fake => fake.PickRandom<PostRuleConfiguration.eStatusReason>())
			.RuleFor(e => e.TimeZoneRuleVersionNumber, fake => fake.Random.Int())
			.RuleFor(e => e.UTCConversionTimeZoneCode, fake => fake.Random.Int())
			.RuleFor(e => e.VersionNumber, fake => fake.Random.Int());
			return faker.Generate();
		}
		#endregion
	}
}

