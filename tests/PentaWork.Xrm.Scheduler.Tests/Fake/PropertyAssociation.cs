using Bogus;
using System;
using FakeXrmEasy;
using System.Collections.Generic;
using PentaWork.Xrm.Scheduler.Proxies.Entities;

namespace PentaWork.Xrm.Scheduler.Tests.Fake
{
	public static class FakePropertyAssociation
	{	
		#region FakeRelationships
		public static class Relationships 
		{
			/// <summary>1:N dynamicpropertyassociation_AsyncOperations</summary>
			public static readonly XrmFakedRelationship DynamicpropertyassociationAsyncOperations = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "dynamicpropertyassociationid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "dynamicpropertyassociation",
					Entity2LogicalName = "asyncoperation",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N dynamicpropertyassociation_BulkDeleteFailures</summary>
			public static readonly XrmFakedRelationship DynamicpropertyassociationBulkDeleteFailures = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "dynamicpropertyassociationid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "dynamicpropertyassociation",
					Entity2LogicalName = "bulkdeletefailure",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N dynamicpropertyassociation_MailboxTrackingFolders</summary>
			public static readonly XrmFakedRelationship DynamicpropertyassociationMailboxTrackingFolders = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "dynamicpropertyassociationid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "dynamicpropertyassociation",
					Entity2LogicalName = "mailboxtrackingfolder",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N dynamicpropertyassociation_PrincipalObjectAttributeAccesses</summary>
			public static readonly XrmFakedRelationship DynamicpropertyassociationPrincipalObjectAttributeAccesses = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "dynamicpropertyassociationid",
					Entity2Attribute = "objectid",
					Entity1LogicalName = "dynamicpropertyassociation",
					Entity2LogicalName = "principalobjectattributeaccess",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N dynamicpropertyassociation_SyncErrors</summary>
			public static readonly XrmFakedRelationship DynamicpropertyassociationSyncErrors = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "dynamicpropertyassociationid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "dynamicpropertyassociation",
					Entity2LogicalName = "syncerror",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

		}
		#endregion

		#region Fake
		public static PropertyAssociation Create()
		{
			var faker = new Faker<PropertyAssociation>()
			.RuleFor(e => e.AssociationStatus, fake => fake.PickRandom<PropertyAssociation.eAssociationStatus>())
			.RuleFor(e => e.Createdbyname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Createdbyyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.CreatedOn, fake => fake.Date.Soon())
			.RuleFor(e => e.Createdonbehalfbyname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Createdonbehalfbyyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.InternalUseOnly, fake => fake.Random.Int())
			.RuleFor(e => e.Id, fake => Guid.NewGuid())
			.RuleFor(e => e.Dynamicpropertyidname, fake => fake.Lorem.Word())
			.RuleFor(e => e.ExchangeRate, fake => fake.Finance.Amount())
			.RuleFor(e => e.ImportSequenceNumber, fake => fake.Random.Int())
			.RuleFor(e => e.InheritanceState, fake => fake.PickRandom<PropertyAssociation.eInheritanceState>())
			.RuleFor(e => e.Modifiedbyname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Modifiedbyyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.ModifiedOn, fake => fake.Date.Soon())
			.RuleFor(e => e.Modifiedonbehalfbyname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Modifiedonbehalfbyyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.Name, fake => fake.Lorem.Word())
			.RuleFor(e => e.Organizationidname, fake => fake.Lorem.Word())
			.RuleFor(e => e.RecordCreatedOn, fake => fake.Date.Soon())
			.RuleFor(e => e.Regardingobjectidname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Regardingobjectidyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.Regardingobjecttypecode, fake => fake.Lorem.Word())
			.RuleFor(e => e.TimeZoneRuleVersionNumber, fake => fake.Random.Int())
			.RuleFor(e => e.Transactioncurrencyidname, fake => fake.Lorem.Word())
			.RuleFor(e => e.UTCConversionTimeZoneCode, fake => fake.Random.Int())
			.RuleFor(e => e.VersionNumber, fake => fake.Random.Int());
			return faker.Generate();
		}
		#endregion
	}
}

