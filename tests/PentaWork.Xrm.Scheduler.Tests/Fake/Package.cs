using Bogus;
using System;
using FakeXrmEasy;
using System.Collections.Generic;
using PentaWork.Xrm.Scheduler.Proxies.Entities;

namespace PentaWork.Xrm.Scheduler.Tests.Fake
{
	public static class FakePackage
	{	
		#region FakeRelationships
		public static class Relationships 
		{
			/// <summary>1:N package_AsyncOperations</summary>
			public static readonly XrmFakedRelationship PackageAsyncOperations = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "packageid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "package",
					Entity2LogicalName = "asyncoperation",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N package_BulkDeleteFailures</summary>
			public static readonly XrmFakedRelationship PackageBulkDeleteFailures = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "packageid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "package",
					Entity2LogicalName = "bulkdeletefailure",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N package_DuplicateBaseRecord</summary>
			public static readonly XrmFakedRelationship PackageDuplicateBaseRecord = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "packageid",
					Entity2Attribute = "baserecordid",
					Entity1LogicalName = "package",
					Entity2LogicalName = "duplicaterecord",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N package_DuplicateMatchingRecord</summary>
			public static readonly XrmFakedRelationship PackageDuplicateMatchingRecord = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "packageid",
					Entity2Attribute = "duplicaterecordid",
					Entity1LogicalName = "package",
					Entity2LogicalName = "duplicaterecord",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N package_MailboxTrackingFolders</summary>
			public static readonly XrmFakedRelationship PackageMailboxTrackingFolders = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "packageid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "package",
					Entity2LogicalName = "mailboxtrackingfolder",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N package_PrincipalObjectAttributeAccesses</summary>
			public static readonly XrmFakedRelationship PackagePrincipalObjectAttributeAccesses = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "packageid",
					Entity2Attribute = "objectid",
					Entity1LogicalName = "package",
					Entity2LogicalName = "principalobjectattributeaccess",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N package_ProcessSession</summary>
			public static readonly XrmFakedRelationship PackageProcessSession = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "packageid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "package",
					Entity2LogicalName = "processsession",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N package_SyncErrors</summary>
			public static readonly XrmFakedRelationship PackageSyncErrors = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "packageid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "package",
					Entity2LogicalName = "syncerror",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>N:N package_solution</summary>
			public static readonly XrmFakedRelationship PackageSolution = 
				new XrmFakedRelationship
				{
					IntersectEntity = "package_solution",
					Entity1Attribute = "packageid",
					Entity2Attribute = "solutionid",
					Entity1LogicalName = "package",
					Entity2LogicalName = "solution",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.ManyToMany
				};

		}
		#endregion

		#region Fake
		public static Package Create()
		{
			var faker = new Faker<Package>()
			.RuleFor(e => e.AppId, fake => Guid.NewGuid())
			.RuleFor(e => e.ApplicationName, fake => fake.Lorem.Word())
			.RuleFor(e => e.Createdbyname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Createdbyyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.CreatedOn, fake => fake.Date.Soon())
			.RuleFor(e => e.Createdonbehalfbyname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Createdonbehalfbyyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.ImportSequenceNumber, fake => fake.Random.Int())
			.RuleFor(e => e.InstalledOn, fake => fake.Date.Soon())
			.RuleFor(e => e.Modifiedbyname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Modifiedbyyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.ModifiedOn, fake => fake.Date.Soon())
			.RuleFor(e => e.Modifiedonbehalfbyname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Modifiedonbehalfbyyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.Organizationidname, fake => fake.Lorem.Word())
			.RuleFor(e => e.RecordCreatedOn, fake => fake.Date.Soon())
			.RuleFor(e => e.Id, fake => Guid.NewGuid())
			.RuleFor(e => e.PackageInstanceId, fake => Guid.NewGuid())
			.RuleFor(e => e.PackageInstanceOperationId, fake => Guid.NewGuid())
			.RuleFor(e => e.PackageUniqueName, fake => fake.Lorem.Word())
			.RuleFor(e => e.PackageVersion, fake => fake.Lorem.Word())
			.RuleFor(e => e.PublisherId, fake => Guid.NewGuid())
			.RuleFor(e => e.PublisherName, fake => fake.Lorem.Word())
			.RuleFor(e => e.Status, fake => fake.PickRandom<Package.eStatus>())
			.RuleFor(e => e.StatusReason, fake => fake.PickRandom<Package.eStatusReason>())
			.RuleFor(e => e.TimeZoneRuleVersionNumber, fake => fake.Random.Int())
			.RuleFor(e => e.TPSPackageId, fake => Guid.NewGuid())
			.RuleFor(e => e.UTCConversionTimeZoneCode, fake => fake.Random.Int())
			.RuleFor(e => e.VersionNumber, fake => fake.Random.Int());
			return faker.Generate();
		}
		#endregion
	}
}

