using Bogus;
using System;
using FakeXrmEasy;
using System.Collections.Generic;
using PentaWork.Xrm.Scheduler.Proxies.Entities;

namespace PentaWork.Xrm.Scheduler.Tests.Fake
{
	public static class FakeUnitGroup
	{	
		#region FakeRelationships
		public static class Relationships 
		{
			/// <summary>1:N contract_detail_unit_of_measure_schedule</summary>
			public static readonly XrmFakedRelationship ContractDetailUnitOfMeasureSchedule = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "uomscheduleid",
					Entity2Attribute = "uomscheduleid",
					Entity1LogicalName = "uomschedule",
					Entity2LogicalName = "contractdetail",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N unit_of_measure_schedule_conversions</summary>
			public static readonly XrmFakedRelationship UnitOfMeasureScheduleConversions = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "uomscheduleid",
					Entity2Attribute = "uomscheduleid",
					Entity1LogicalName = "uomschedule",
					Entity2LogicalName = "uom",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N unit_of_measure_schedule_product_price_level</summary>
			public static readonly XrmFakedRelationship UnitOfMeasureScheduleProductPriceLevel = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "uomscheduleid",
					Entity2Attribute = "uomscheduleid",
					Entity1LogicalName = "uomschedule",
					Entity2LogicalName = "productpricelevel",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N unit_of_measurement_schedule_products</summary>
			public static readonly XrmFakedRelationship UnitOfMeasurementScheduleProducts = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "uomscheduleid",
					Entity2Attribute = "defaultuomscheduleid",
					Entity1LogicalName = "uomschedule",
					Entity2LogicalName = "product",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N UoMSchedule_AsyncOperations</summary>
			public static readonly XrmFakedRelationship UoMScheduleAsyncOperations = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "uomscheduleid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "uomschedule",
					Entity2LogicalName = "asyncoperation",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N UoMSchedule_BulkDeleteFailures</summary>
			public static readonly XrmFakedRelationship UoMScheduleBulkDeleteFailures = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "uomscheduleid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "uomschedule",
					Entity2LogicalName = "bulkdeletefailure",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N uomschedule_MailboxTrackingFolders</summary>
			public static readonly XrmFakedRelationship UomscheduleMailboxTrackingFolders = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "uomscheduleid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "uomschedule",
					Entity2LogicalName = "mailboxtrackingfolder",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N uomschedule_PrincipalObjectAttributeAccesses</summary>
			public static readonly XrmFakedRelationship UomschedulePrincipalObjectAttributeAccesses = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "uomscheduleid",
					Entity2Attribute = "objectid",
					Entity1LogicalName = "uomschedule",
					Entity2LogicalName = "principalobjectattributeaccess",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N UoMSchedule_SyncErrors</summary>
			public static readonly XrmFakedRelationship UoMScheduleSyncErrors = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "uomscheduleid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "uomschedule",
					Entity2LogicalName = "syncerror",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

		}
		#endregion

		#region Fake
		public static UnitGroup Create()
		{
			var faker = new Faker<UnitGroup>()
			.RuleFor(e => e.BaseUnitName, fake => fake.Lorem.Word())
			.RuleFor(e => e.Createdbyexternalpartyname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Createdbyexternalpartyyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.Createdbyname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Createdbyyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.CreatedOn, fake => fake.Date.Soon())
			.RuleFor(e => e.Createdonbehalfbyname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Createdonbehalfbyyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.Description, fake => fake.Lorem.Word())
			.RuleFor(e => e.ImportSequenceNumber, fake => fake.Random.Int())
			.RuleFor(e => e.Modifiedbyexternalpartyname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Modifiedbyexternalpartyyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.Modifiedbyname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Modifiedbyyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.ModifiedOn, fake => fake.Date.Soon())
			.RuleFor(e => e.Modifiedonbehalfbyname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Modifiedonbehalfbyyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.Name, fake => fake.Lorem.Word())
			.RuleFor(e => e.Organizationidname, fake => fake.Lorem.Word())
			.RuleFor(e => e.RecordCreatedOn, fake => fake.Date.Soon())
			.RuleFor(e => e.Status, fake => fake.PickRandom<UnitGroup.eStatus>())
			.RuleFor(e => e.StatusReason, fake => fake.PickRandom<UnitGroup.eStatusReason>())
			.RuleFor(e => e.TimeZoneRuleVersionNumber, fake => fake.Random.Int())
			.RuleFor(e => e.Id, fake => Guid.NewGuid())
			.RuleFor(e => e.UTCConversionTimeZoneCode, fake => fake.Random.Int())
			.RuleFor(e => e.VersionNumber, fake => fake.Random.Int());
			return faker.Generate();
		}
		#endregion
	}
}

