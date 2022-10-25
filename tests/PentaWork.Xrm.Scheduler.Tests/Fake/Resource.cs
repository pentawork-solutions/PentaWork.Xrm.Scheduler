using Bogus;
using System;
using FakeXrmEasy;
using System.Collections.Generic;
using PentaWork.Xrm.Scheduler.Proxies.Entities;

namespace PentaWork.Xrm.Scheduler.Tests.Fake
{
	public static class FakeResource
	{	
		#region FakeRelationships
		public static class Relationships 
		{
			/// <summary>1:N Resource_AsyncOperations</summary>
			public static readonly XrmFakedRelationship ResourceAsyncOperations = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "resourceid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "resource",
					Entity2LogicalName = "asyncoperation",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N Resource_BulkDeleteFailures</summary>
			public static readonly XrmFakedRelationship ResourceBulkDeleteFailures = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "resourceid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "resource",
					Entity2LogicalName = "bulkdeletefailure",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N resource_MailboxTrackingFolders</summary>
			public static readonly XrmFakedRelationship ResourceMailboxTrackingFolders = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "resourceid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "resource",
					Entity2LogicalName = "mailboxtrackingfolder",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N resource_PrincipalObjectAttributeAccesses</summary>
			public static readonly XrmFakedRelationship ResourcePrincipalObjectAttributeAccesses = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "resourceid",
					Entity2Attribute = "objectid",
					Entity1LogicalName = "resource",
					Entity2LogicalName = "principalobjectattributeaccess",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N Resource_SyncErrors</summary>
			public static readonly XrmFakedRelationship ResourceSyncErrors = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "resourceid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "resource",
					Entity2LogicalName = "syncerror",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

		}
		#endregion

		#region Fake
		public static Resource Create()
		{
			var faker = new Faker<Resource>()
			.RuleFor(e => e.Businessunitidname, fake => fake.Lorem.Word())
			.RuleFor(e => e.CalendarId, fake => Guid.NewGuid())
			.RuleFor(e => e.DisplayInServiceViews, fake => fake.Random.Bool())
			.RuleFor(e => e.EntityimageTimestamp, fake => fake.Random.Int())
			.RuleFor(e => e.EntityimageUrl, fake => fake.Lorem.Word())
			.RuleFor(e => e.EntityimageId, fake => Guid.NewGuid())
			.RuleFor(e => e.ImportSequenceNumber, fake => fake.Random.Int())
			.RuleFor(e => e.IsDisabled, fake => fake.Random.Bool())
			.RuleFor(e => e.Name, fake => fake.Lorem.Word())
			.RuleFor(e => e.ObjectType, fake => fake.Lorem.Word())
			.RuleFor(e => e.Organizationidname, fake => fake.Lorem.Word())
			.RuleFor(e => e.RecordCreatedOn, fake => fake.Date.Soon())
			.RuleFor(e => e.Id, fake => Guid.NewGuid())
			.RuleFor(e => e.Siteidname, fake => fake.Lorem.Word())
			.RuleFor(e => e.TimeZoneRuleVersionNumber, fake => fake.Random.Int())
			.RuleFor(e => e.UTCConversionTimeZoneCode, fake => fake.Random.Int())
			.RuleFor(e => e.VersionNumber, fake => fake.Random.Int());
			return faker.Generate();
		}
		#endregion
	}
}

