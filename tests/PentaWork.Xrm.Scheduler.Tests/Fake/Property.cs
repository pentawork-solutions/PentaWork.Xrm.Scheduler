using Bogus;
using System;
using FakeXrmEasy;
using System.Collections.Generic;
using PentaWork.Xrm.Scheduler.Proxies.Entities;

namespace PentaWork.Xrm.Scheduler.Tests.Fake
{
	public static class FakeProperty
	{	
		#region FakeRelationships
		public static class Relationships 
		{
			/// <summary>1:N dynamicproperty_AsyncOperations</summary>
			public static readonly XrmFakedRelationship DynamicpropertyAsyncOperations = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "dynamicpropertyid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "dynamicproperty",
					Entity2LogicalName = "asyncoperation",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N dynamicproperty_base_dynamicproperty</summary>
			public static readonly XrmFakedRelationship DynamicpropertyBaseDynamicproperty = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "dynamicpropertyid",
					Entity2Attribute = "basedynamicpropertyid",
					Entity1LogicalName = "dynamicproperty",
					Entity2LogicalName = "dynamicproperty",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N dynamicproperty_BulkDeleteFailures</summary>
			public static readonly XrmFakedRelationship DynamicpropertyBulkDeleteFailures = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "dynamicpropertyid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "dynamicproperty",
					Entity2LogicalName = "bulkdeletefailure",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N Dynamicproperty_DynamicPropertyAssociation</summary>
			public static readonly XrmFakedRelationship DynamicpropertyDynamicPropertyAssociation = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "dynamicpropertyid",
					Entity2Attribute = "dynamicpropertyid",
					Entity1LogicalName = "dynamicproperty",
					Entity2LogicalName = "dynamicpropertyassociation",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N DynamicProperty_DynamicPropertyInstance</summary>
			public static readonly XrmFakedRelationship DynamicPropertyDynamicPropertyInstance = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "dynamicpropertyid",
					Entity2Attribute = "dynamicpropertyid",
					Entity1LogicalName = "dynamicproperty",
					Entity2LogicalName = "dynamicpropertyinstance",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N DynamicProperty_DynamicPropertyOptionSetItem</summary>
			public static readonly XrmFakedRelationship DynamicPropertyDynamicPropertyOptionSetItem = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "dynamicpropertyid",
					Entity2Attribute = "dynamicpropertyid",
					Entity1LogicalName = "dynamicproperty",
					Entity2LogicalName = "dynamicpropertyoptionsetitem",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N dynamicproperty_MailboxTrackingFolders</summary>
			public static readonly XrmFakedRelationship DynamicpropertyMailboxTrackingFolders = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "dynamicpropertyid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "dynamicproperty",
					Entity2LogicalName = "mailboxtrackingfolder",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N dynamicproperty_PrincipalObjectAttributeAccesses</summary>
			public static readonly XrmFakedRelationship DynamicpropertyPrincipalObjectAttributeAccesses = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "dynamicpropertyid",
					Entity2Attribute = "objectid",
					Entity1LogicalName = "dynamicproperty",
					Entity2LogicalName = "principalobjectattributeaccess",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N dynamicproperty_SyncErrors</summary>
			public static readonly XrmFakedRelationship DynamicpropertySyncErrors = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "dynamicpropertyid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "dynamicproperty",
					Entity2LogicalName = "syncerror",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

		}
		#endregion

		#region Fake
		public static Property Create()
		{
			var faker = new Faker<Property>()
			.RuleFor(e => e.Basedynamicpropertyidname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Createdbyname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Createdbyyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.CreatedOn, fake => fake.Date.Soon())
			.RuleFor(e => e.Createdonbehalfbyname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Createdonbehalfbyyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.DataType, fake => fake.PickRandom<Property.ePropertyDataType>())
			.RuleFor(e => e.DefaultValue, fake => fake.Lorem.Word())
			.RuleFor(e => e.DefaultDecimalValue, fake => fake.Finance.Amount())
			.RuleFor(e => e.DefaultDoubleValue, fake => fake.Random.Double())
			.RuleFor(e => e.DefaultWholeNumberValue, fake => fake.Random.Int())
			.RuleFor(e => e.Defaultvalueoptionsetname, fake => fake.Lorem.Word())
			.RuleFor(e => e.DefaultStringValue, fake => fake.Lorem.Word())
			.RuleFor(e => e.Description, fake => fake.Lorem.Word())
			.RuleFor(e => e.InternalUseOnly, fake => fake.Random.Int())
			.RuleFor(e => e.Id, fake => Guid.NewGuid())
			.RuleFor(e => e.ImportSequenceNumber, fake => fake.Random.Int())
			.RuleFor(e => e.Hidden, fake => fake.Random.Bool())
			.RuleFor(e => e.ReadOnly, fake => fake.Random.Bool())
			.RuleFor(e => e.Required, fake => fake.Random.Bool())
			.RuleFor(e => e.MaximumStringLength, fake => fake.Random.Int())
			.RuleFor(e => e.MaximumDecimalValue, fake => fake.Finance.Amount())
			.RuleFor(e => e.MaximumDoubleValue, fake => fake.Random.Double())
			.RuleFor(e => e.MaximumWholeNumberValue, fake => fake.Random.Int())
			.RuleFor(e => e.MinimumDecimalValue, fake => fake.Finance.Amount())
			.RuleFor(e => e.MinimumDoubleValue, fake => fake.Random.Double())
			.RuleFor(e => e.MinimumWholeNumberValue, fake => fake.Random.Int())
			.RuleFor(e => e.Modifiedbyname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Modifiedbyyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.ModifiedOn, fake => fake.Date.Soon())
			.RuleFor(e => e.Modifiedonbehalfbyname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Modifiedonbehalfbyyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.Name, fake => fake.Lorem.Word())
			.RuleFor(e => e.Organizationidname, fake => fake.Lorem.Word())
			.RuleFor(e => e.RecordCreatedOn, fake => fake.Date.Soon())
			.RuleFor(e => e.OverwrittenPropertyId, fake => Guid.NewGuid())
			.RuleFor(e => e.Precision, fake => fake.Random.Int())
			.RuleFor(e => e.Regardingobjectidname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Regardingobjectidyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.Regardingobjecttypecode, fake => fake.Lorem.Word())
			.RuleFor(e => e.RootPropertyId, fake => Guid.NewGuid())
			.RuleFor(e => e.Status, fake => fake.PickRandom<Property.eStatus>())
			.RuleFor(e => e.StatusReason, fake => fake.PickRandom<Property.eStatusCode>())
			.RuleFor(e => e.TimeZoneRuleVersionNumber, fake => fake.Random.Int())
			.RuleFor(e => e.UTCConversionTimeZoneCode, fake => fake.Random.Int())
			.RuleFor(e => e.VersionNumber, fake => fake.Random.Int());
			return faker.Generate();
		}
		#endregion
	}
}

