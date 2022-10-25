using Bogus;
using System;
using FakeXrmEasy;
using System.Collections.Generic;
using PentaWork.Xrm.Scheduler.Proxies.Entities;

namespace PentaWork.Xrm.Scheduler.Tests.Fake
{
	public static class FakePropertyOptionSetItem
	{	
		#region FakeRelationships
		public static class Relationships 
		{
			/// <summary>1:N DefaultValueOptionSet_DynamicProperty</summary>
			public static readonly XrmFakedRelationship DefaultValueOptionSetDynamicProperty = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "dynamicpropertyoptionsetvalueid",
					Entity2Attribute = "defaultvalueoptionset",
					Entity1LogicalName = "dynamicpropertyoptionsetitem",
					Entity2LogicalName = "dynamicproperty",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N dynamicpropertyoptionsetitem_AsyncOperations</summary>
			public static readonly XrmFakedRelationship DynamicpropertyoptionsetitemAsyncOperations = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "dynamicpropertyoptionsetvalueid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "dynamicpropertyoptionsetitem",
					Entity2LogicalName = "asyncoperation",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N dynamicpropertyoptionsetitem_BulkDeleteFailures</summary>
			public static readonly XrmFakedRelationship DynamicpropertyoptionsetitemBulkDeleteFailures = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "dynamicpropertyoptionsetvalueid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "dynamicpropertyoptionsetitem",
					Entity2LogicalName = "bulkdeletefailure",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N dynamicpropertyoptionsetitem_MailboxTrackingFolders</summary>
			public static readonly XrmFakedRelationship DynamicpropertyoptionsetitemMailboxTrackingFolders = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "dynamicpropertyoptionsetvalueid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "dynamicpropertyoptionsetitem",
					Entity2LogicalName = "mailboxtrackingfolder",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N dynamicpropertyoptionsetitem_PrincipalObjectAttributeAccesses</summary>
			public static readonly XrmFakedRelationship DynamicpropertyoptionsetitemPrincipalObjectAttributeAccesses = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "dynamicpropertyoptionsetvalueid",
					Entity2Attribute = "objectid",
					Entity1LogicalName = "dynamicpropertyoptionsetitem",
					Entity2LogicalName = "principalobjectattributeaccess",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N dynamicpropertyoptionsetitem_SyncErrors</summary>
			public static readonly XrmFakedRelationship DynamicpropertyoptionsetitemSyncErrors = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "dynamicpropertyoptionsetvalueid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "dynamicpropertyoptionsetitem",
					Entity2LogicalName = "syncerror",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

		}
		#endregion

		#region Fake
		public static PropertyOptionSetItem Create()
		{
			var faker = new Faker<PropertyOptionSetItem>()
			.RuleFor(e => e.Createdbyname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Createdbyyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.CreatedOn, fake => fake.Date.Soon())
			.RuleFor(e => e.Createdonbehalfbyname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Createdonbehalfbyyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.InternalUseOnly, fake => fake.Random.Int())
			.RuleFor(e => e.Dynamicpropertyidname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Description, fake => fake.Lorem.Word())
			.RuleFor(e => e.Name, fake => fake.Lorem.Word())
			.RuleFor(e => e.Id, fake => Guid.NewGuid())
			.RuleFor(e => e.InternalUseOnly2, fake => fake.Random.Int())
			.RuleFor(e => e.Value, fake => fake.Random.Int())
			.RuleFor(e => e.ExchangeRate, fake => fake.Finance.Amount())
			.RuleFor(e => e.ImportSequenceNumber, fake => fake.Random.Int())
			.RuleFor(e => e.Modifiedbyname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Modifiedbyyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.ModifiedOn, fake => fake.Date.Soon())
			.RuleFor(e => e.Modifiedonbehalfbyname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Modifiedonbehalfbyyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.Organizationidname, fake => fake.Lorem.Word())
			.RuleFor(e => e.RecordCreatedOn, fake => fake.Date.Soon())
			.RuleFor(e => e.TimeZoneRuleVersionNumber, fake => fake.Random.Int())
			.RuleFor(e => e.Transactioncurrencyidname, fake => fake.Lorem.Word())
			.RuleFor(e => e.UTCConversionTimeZoneCode, fake => fake.Random.Int())
			.RuleFor(e => e.VersionNumber, fake => fake.Random.Int());
			return faker.Generate();
		}
		#endregion
	}
}

