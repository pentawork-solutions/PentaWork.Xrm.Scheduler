using Bogus;
using System;
using FakeXrmEasy;
using System.Collections.Generic;
using PentaWork.Xrm.Scheduler.Proxies.Entities;

namespace PentaWork.Xrm.Scheduler.Tests.Fake
{
	public static class FakeTour
	{	
		#region FakeRelationships
		public static class Relationships 
		{
			/// <summary>1:N msdyn_tour_AsyncOperations</summary>
			public static readonly XrmFakedRelationship MsdynTourAsyncOperations = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "msdyn_tourid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "msdyn_tour",
					Entity2LogicalName = "asyncoperation",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N msdyn_tour_BulkDeleteFailures</summary>
			public static readonly XrmFakedRelationship MsdynTourBulkDeleteFailures = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "msdyn_tourid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "msdyn_tour",
					Entity2LogicalName = "bulkdeletefailure",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N msdyn_tour_MailboxTrackingFolders</summary>
			public static readonly XrmFakedRelationship MsdynTourMailboxTrackingFolders = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "msdyn_tourid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "msdyn_tour",
					Entity2LogicalName = "mailboxtrackingfolder",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N msdyn_tour_PrincipalObjectAttributeAccesses</summary>
			public static readonly XrmFakedRelationship MsdynTourPrincipalObjectAttributeAccesses = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "msdyn_tourid",
					Entity2Attribute = "objectid",
					Entity1LogicalName = "msdyn_tour",
					Entity2LogicalName = "principalobjectattributeaccess",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N msdyn_tour_ProcessSession</summary>
			public static readonly XrmFakedRelationship MsdynTourProcessSession = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "msdyn_tourid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "msdyn_tour",
					Entity2LogicalName = "processsession",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N msdyn_tour_SyncErrors</summary>
			public static readonly XrmFakedRelationship MsdynTourSyncErrors = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "msdyn_tourid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "msdyn_tour",
					Entity2LogicalName = "syncerror",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

		}
		#endregion

		#region Fake
		public static Tour Create()
		{
			var faker = new Faker<Tour>()
			.RuleFor(e => e.RowIdUniqueId, fake => Guid.NewGuid())
			.RuleFor(e => e.ComponentState, fake => fake.PickRandom<Tour.egComponentState>())
			.RuleFor(e => e.Createdbyname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Createdbyyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.CreatedOn, fake => fake.Date.Soon())
			.RuleFor(e => e.Createdonbehalfbyname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Createdonbehalfbyyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.ImportSequenceNumber, fake => fake.Random.Int())
			.RuleFor(e => e.IsManaged, fake => fake.Random.Bool())
			.RuleFor(e => e.Modifiedbyname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Modifiedbyyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.ModifiedOn, fake => fake.Date.Soon())
			.RuleFor(e => e.Modifiedonbehalfbyname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Modifiedonbehalfbyyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.DisplayName, fake => fake.Lorem.Word())
			.RuleFor(e => e.LabelsResource, fake => fake.Lorem.Word())
			.RuleFor(e => e.Path, fake => fake.Lorem.Word())
			.RuleFor(e => e.TourDefinition, fake => fake.Lorem.Word())
			.RuleFor(e => e.Id, fake => Guid.NewGuid())
			.RuleFor(e => e.Organizationidname, fake => fake.Lorem.Word())
			.RuleFor(e => e.RecordCreatedOn, fake => fake.Date.Soon())
			.RuleFor(e => e.RecordOverwriteTime, fake => fake.Date.Soon())
			.RuleFor(e => e.SolutionId, fake => Guid.NewGuid())
			.RuleFor(e => e.Status, fake => fake.PickRandom<Tour.eStatus>())
			.RuleFor(e => e.StatusReason, fake => fake.PickRandom<Tour.eStatusReason>())
			.RuleFor(e => e.SolutionId2, fake => Guid.NewGuid())
			.RuleFor(e => e.TimeZoneRuleVersionNumber, fake => fake.Random.Int())
			.RuleFor(e => e.UTCConversionTimeZoneCode, fake => fake.Random.Int())
			.RuleFor(e => e.VersionNumber, fake => fake.Random.Int());
			return faker.Generate();
		}
		#endregion
	}
}

