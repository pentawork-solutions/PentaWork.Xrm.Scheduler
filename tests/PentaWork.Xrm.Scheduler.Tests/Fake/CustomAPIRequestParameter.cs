using Bogus;
using System;
using FakeXrmEasy;
using System.Collections.Generic;
using PentaWork.Xrm.Scheduler.Proxies.Entities;

namespace PentaWork.Xrm.Scheduler.Tests.Fake
{
	public static class FakeCustomAPIRequestParameter
	{	
		#region FakeRelationships
		public static class Relationships 
		{
			/// <summary>1:N customapirequestparameter_AsyncOperations</summary>
			public static readonly XrmFakedRelationship CustomapirequestparameterAsyncOperations = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "customapirequestparameterid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "customapirequestparameter",
					Entity2LogicalName = "asyncoperation",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N customapirequestparameter_BulkDeleteFailures</summary>
			public static readonly XrmFakedRelationship CustomapirequestparameterBulkDeleteFailures = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "customapirequestparameterid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "customapirequestparameter",
					Entity2LogicalName = "bulkdeletefailure",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N customapirequestparameter_MailboxTrackingFolders</summary>
			public static readonly XrmFakedRelationship CustomapirequestparameterMailboxTrackingFolders = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "customapirequestparameterid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "customapirequestparameter",
					Entity2LogicalName = "mailboxtrackingfolder",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N customapirequestparameter_PrincipalObjectAttributeAccesses</summary>
			public static readonly XrmFakedRelationship CustomapirequestparameterPrincipalObjectAttributeAccesses = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "customapirequestparameterid",
					Entity2Attribute = "objectid",
					Entity1LogicalName = "customapirequestparameter",
					Entity2LogicalName = "principalobjectattributeaccess",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N customapirequestparameter_ProcessSession</summary>
			public static readonly XrmFakedRelationship CustomapirequestparameterProcessSession = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "customapirequestparameterid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "customapirequestparameter",
					Entity2LogicalName = "processsession",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N customapirequestparameter_SyncErrors</summary>
			public static readonly XrmFakedRelationship CustomapirequestparameterSyncErrors = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "customapirequestparameterid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "customapirequestparameter",
					Entity2LogicalName = "syncerror",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

		}
		#endregion

		#region Fake
		public static CustomAPIRequestParameter Create()
		{
			var faker = new Faker<CustomAPIRequestParameter>()
			.RuleFor(e => e.RowIdUniqueId, fake => Guid.NewGuid())
			.RuleFor(e => e.ComponentState, fake => fake.PickRandom<CustomAPIRequestParameter.egComponentState>())
			.RuleFor(e => e.Createdbyname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Createdbyyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.CreatedOn, fake => fake.Date.Soon())
			.RuleFor(e => e.Createdonbehalfbyname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Createdonbehalfbyyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.Customapiidname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Id, fake => Guid.NewGuid())
			.RuleFor(e => e.Description, fake => fake.Lorem.Word())
			.RuleFor(e => e.DisplayName, fake => fake.Lorem.Word())
			.RuleFor(e => e.EntityLogicalName, fake => fake.Lorem.Word())
			.RuleFor(e => e.ImportSequenceNumber, fake => fake.Random.Int())
			.RuleFor(e => e.IsManaged, fake => fake.Random.Bool())
			.RuleFor(e => e.IsOptional, fake => fake.Random.Bool())
			.RuleFor(e => e.Modifiedbyname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Modifiedbyyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.ModifiedOn, fake => fake.Date.Soon())
			.RuleFor(e => e.Modifiedonbehalfbyname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Modifiedonbehalfbyyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.Name, fake => fake.Lorem.Word())
			.RuleFor(e => e.RecordCreatedOn, fake => fake.Date.Soon())
			.RuleFor(e => e.RecordOverwriteTime, fake => fake.Date.Soon())
			.RuleFor(e => e.Owneridname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Owneridtype, fake => fake.Lorem.Word())
			.RuleFor(e => e.Owneridyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.SolutionId, fake => Guid.NewGuid())
			.RuleFor(e => e.Status, fake => fake.PickRandom<CustomAPIRequestParameter.eStatus>())
			.RuleFor(e => e.StatusReason, fake => fake.PickRandom<CustomAPIRequestParameter.eStatusReason>())
			.RuleFor(e => e.SolutionId2, fake => Guid.NewGuid())
			.RuleFor(e => e.TimeZoneRuleVersionNumber, fake => fake.Random.Int())
			.RuleFor(e => e.Type, fake => fake.PickRandom<CustomAPIRequestParameter.egCustomAPIFieldType>())
			.RuleFor(e => e.UniqueName, fake => fake.Lorem.Word())
			.RuleFor(e => e.UTCConversionTimeZoneCode, fake => fake.Random.Int())
			.RuleFor(e => e.VersionNumber, fake => fake.Random.Int());
			return faker.Generate();
		}
		#endregion
	}
}

