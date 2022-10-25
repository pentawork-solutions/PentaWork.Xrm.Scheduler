using Bogus;
using System;
using FakeXrmEasy;
using System.Collections.Generic;
using PentaWork.Xrm.Scheduler.Proxies.Entities;

namespace PentaWork.Xrm.Scheduler.Tests.Fake
{
	public static class FakePropertyInstance
	{	
		#region FakeRelationships
		public static class Relationships 
		{
			/// <summary>1:N dynamicpropertyinstance_AsyncOperations</summary>
			public static readonly XrmFakedRelationship DynamicpropertyinstanceAsyncOperations = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "dynamicpropertyinstanceid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "dynamicpropertyinstance",
					Entity2LogicalName = "asyncoperation",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N dynamicpropertyinstance_BulkDeleteFailures</summary>
			public static readonly XrmFakedRelationship DynamicpropertyinstanceBulkDeleteFailures = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "dynamicpropertyinstanceid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "dynamicpropertyinstance",
					Entity2LogicalName = "bulkdeletefailure",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N dynamicpropertyinstance_MailboxTrackingFolders</summary>
			public static readonly XrmFakedRelationship DynamicpropertyinstanceMailboxTrackingFolders = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "dynamicpropertyinstanceid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "dynamicpropertyinstance",
					Entity2LogicalName = "mailboxtrackingfolder",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N dynamicpropertyinstance_PrincipalObjectAttributeAccesses</summary>
			public static readonly XrmFakedRelationship DynamicpropertyinstancePrincipalObjectAttributeAccesses = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "dynamicpropertyinstanceid",
					Entity2Attribute = "objectid",
					Entity1LogicalName = "dynamicpropertyinstance",
					Entity2LogicalName = "principalobjectattributeaccess",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N dynamicpropertyinstance_SyncErrors</summary>
			public static readonly XrmFakedRelationship DynamicpropertyinstanceSyncErrors = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "dynamicpropertyinstanceid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "dynamicpropertyinstance",
					Entity2LogicalName = "syncerror",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

		}
		#endregion

		#region Fake
		public static PropertyInstance Create()
		{
			var faker = new Faker<PropertyInstance>()
			.RuleFor(e => e.Createdbyname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Createdbyyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.CreatedOn, fake => fake.Date.Soon())
			.RuleFor(e => e.Createdonbehalfbyname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Createdonbehalfbyyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.InternalUseOnly, fake => fake.Random.Int())
			.RuleFor(e => e.Dynamicpropertyidname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Id, fake => Guid.NewGuid())
			.RuleFor(e => e.ExchangeRate, fake => fake.Finance.Amount())
			.RuleFor(e => e.ImportSequenceNumber, fake => fake.Random.Int())
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
			.RuleFor(e => e.Regardingobjectidname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Regardingobjectidtype, fake => fake.Lorem.Word())
			.RuleFor(e => e.Regardingobjectidyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.TimeZoneRuleVersionNumber, fake => fake.Random.Int())
			.RuleFor(e => e.Transactioncurrencyidname, fake => fake.Lorem.Word())
			.RuleFor(e => e.UTCConversionTimeZoneCode, fake => fake.Random.Int())
			.RuleFor(e => e.IsValid, fake => fake.Random.Bool())
			.RuleFor(e => e.DecimalValue, fake => fake.Finance.Amount())
			.RuleFor(e => e.DoubleValue, fake => fake.Random.Double())
			.RuleFor(e => e.IntegerValue, fake => fake.Random.Int())
			.RuleFor(e => e.StringValue, fake => fake.Lorem.Word())
			.RuleFor(e => e.VersionNumber, fake => fake.Random.Int());
			return faker.Generate();
		}
		#endregion
	}
}

