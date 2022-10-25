using Bogus;
using System;
using FakeXrmEasy;
using System.Collections.Generic;
using PentaWork.Xrm.Scheduler.Proxies.Entities;

namespace PentaWork.Xrm.Scheduler.Tests.Fake
{
	public static class FakeResourceSpecification
	{	
		#region FakeRelationships
		public static class Relationships 
		{
			/// <summary>1:N ActivityPartyResourceSpec</summary>
			public static readonly XrmFakedRelationship ActivityPartyResourceSpec = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "resourcespecid",
					Entity2Attribute = "resourcespecid",
					Entity1LogicalName = "resourcespec",
					Entity2LogicalName = "activityparty",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N resource_spec_services</summary>
			public static readonly XrmFakedRelationship ResourceSpecServices = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "resourcespecid",
					Entity2Attribute = "resourcespecid",
					Entity1LogicalName = "resourcespec",
					Entity2LogicalName = "service",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N ResourceSpec_Annotation</summary>
			public static readonly XrmFakedRelationship ResourceSpecAnnotation = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "resourcespecid",
					Entity2Attribute = "objectid",
					Entity1LogicalName = "resourcespec",
					Entity2LogicalName = "annotation",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N ResourceSpec_AsyncOperations</summary>
			public static readonly XrmFakedRelationship ResourceSpecAsyncOperations = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "resourcespecid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "resourcespec",
					Entity2LogicalName = "asyncoperation",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N ResourceSpec_BulkDeleteFailures</summary>
			public static readonly XrmFakedRelationship ResourceSpecBulkDeleteFailures = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "resourcespecid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "resourcespec",
					Entity2LogicalName = "bulkdeletefailure",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N resourcespec_MailboxTrackingFolders</summary>
			public static readonly XrmFakedRelationship ResourcespecMailboxTrackingFolders = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "resourcespecid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "resourcespec",
					Entity2LogicalName = "mailboxtrackingfolder",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N resourcespec_PrincipalObjectAttributeAccesses</summary>
			public static readonly XrmFakedRelationship ResourcespecPrincipalObjectAttributeAccesses = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "resourcespecid",
					Entity2Attribute = "objectid",
					Entity1LogicalName = "resourcespec",
					Entity2LogicalName = "principalobjectattributeaccess",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N resourcespec_resources</summary>
			public static readonly XrmFakedRelationship ResourcespecResources = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "resourcespecid",
					Entity2Attribute = "resourceid",
					Entity1LogicalName = "resourcespec",
					Entity2LogicalName = "resource",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N resourcespec_SyncErrors</summary>
			public static readonly XrmFakedRelationship ResourcespecSyncErrors = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "resourcespecid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "resourcespec",
					Entity2LogicalName = "syncerror",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

		}
		#endregion

		#region Fake
		public static ResourceSpecification Create()
		{
			var faker = new Faker<ResourceSpecification>()
			.RuleFor(e => e.Businessunitidname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Constraints, fake => fake.Lorem.Word())
			.RuleFor(e => e.Createdbyname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Createdbyyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.CreatedOn, fake => fake.Date.Soon())
			.RuleFor(e => e.Createdonbehalfbyname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Createdonbehalfbyyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.Description, fake => fake.Lorem.Word())
			.RuleFor(e => e.EffortRequired, fake => fake.Random.Double())
			.RuleFor(e => e.GroupObjectId, fake => Guid.NewGuid())
			.RuleFor(e => e.ImportSequenceNumber, fake => fake.Random.Int())
			.RuleFor(e => e.Modifiedbyname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Modifiedbyyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.ModifiedOn, fake => fake.Date.Soon())
			.RuleFor(e => e.Modifiedonbehalfbyname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Modifiedonbehalfbyyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.Name, fake => fake.Lorem.Word())
			.RuleFor(e => e.ObjectiveExpression, fake => fake.Lorem.Word())
			.RuleFor(e => e.ObjectType, fake => fake.Lorem.Word())
			.RuleFor(e => e.Organizationidname, fake => fake.Lorem.Word())
			.RuleFor(e => e.RecordCreatedOn, fake => fake.Date.Soon())
			.RuleFor(e => e.RequiredCount, fake => fake.Random.Int())
			.RuleFor(e => e.Id, fake => Guid.NewGuid())
			.RuleFor(e => e.SameSite, fake => fake.Random.Bool())
			.RuleFor(e => e.TimeZoneRuleVersionNumber, fake => fake.Random.Int())
			.RuleFor(e => e.UTCConversionTimeZoneCode, fake => fake.Random.Int())
			.RuleFor(e => e.VersionNumber, fake => fake.Random.Int());
			return faker.Generate();
		}
		#endregion
	}
}

