using Bogus;
using System;
using FakeXrmEasy;
using System.Collections.Generic;
using PentaWork.Xrm.Scheduler.Proxies.Entities;

namespace PentaWork.Xrm.Scheduler.Tests.Fake
{
	public static class FakeProvisionLanguageForUser
	{	
		#region FakeRelationships
		public static class Relationships 
		{
			/// <summary>1:N provisionlanguageforuser_AsyncOperations</summary>
			public static readonly XrmFakedRelationship ProvisionlanguageforuserAsyncOperations = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "provisionlanguageforuserid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "provisionlanguageforuser",
					Entity2LogicalName = "asyncoperation",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N provisionlanguageforuser_BulkDeleteFailures</summary>
			public static readonly XrmFakedRelationship ProvisionlanguageforuserBulkDeleteFailures = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "provisionlanguageforuserid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "provisionlanguageforuser",
					Entity2LogicalName = "bulkdeletefailure",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N provisionlanguageforuser_MailboxTrackingFolders</summary>
			public static readonly XrmFakedRelationship ProvisionlanguageforuserMailboxTrackingFolders = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "provisionlanguageforuserid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "provisionlanguageforuser",
					Entity2LogicalName = "mailboxtrackingfolder",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N provisionlanguageforuser_PrincipalObjectAttributeAccesses</summary>
			public static readonly XrmFakedRelationship ProvisionlanguageforuserPrincipalObjectAttributeAccesses = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "provisionlanguageforuserid",
					Entity2Attribute = "objectid",
					Entity1LogicalName = "provisionlanguageforuser",
					Entity2LogicalName = "principalobjectattributeaccess",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N provisionlanguageforuser_ProcessSession</summary>
			public static readonly XrmFakedRelationship ProvisionlanguageforuserProcessSession = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "provisionlanguageforuserid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "provisionlanguageforuser",
					Entity2LogicalName = "processsession",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N provisionlanguageforuser_SyncErrors</summary>
			public static readonly XrmFakedRelationship ProvisionlanguageforuserSyncErrors = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "provisionlanguageforuserid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "provisionlanguageforuser",
					Entity2LogicalName = "syncerror",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

		}
		#endregion

		#region Fake
		public static ProvisionLanguageForUser Create()
		{
			var faker = new Faker<ProvisionLanguageForUser>()
			.RuleFor(e => e.AsyncOperationId, fake => Guid.NewGuid())
			.RuleFor(e => e.Lcid, fake => fake.Random.Int())
			.RuleFor(e => e.Name, fake => fake.Lorem.Word())
			.RuleFor(e => e.OperationStatus, fake => fake.PickRandom<ProvisionLanguageForUser.eOperationStatus>())
			.RuleFor(e => e.OrganizationId, fake => Guid.NewGuid())
			.RuleFor(e => e.Id, fake => Guid.NewGuid())
			.RuleFor(e => e.UserId, fake => Guid.NewGuid());
			return faker.Generate();
		}
		#endregion
	}
}

