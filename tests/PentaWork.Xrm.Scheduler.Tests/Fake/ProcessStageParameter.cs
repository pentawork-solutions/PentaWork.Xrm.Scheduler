using Bogus;
using System;
using FakeXrmEasy;
using System.Collections.Generic;
using PentaWork.Xrm.Scheduler.Proxies.Entities;

namespace PentaWork.Xrm.Scheduler.Tests.Fake
{
	public static class FakeProcessStageParameter
	{	
		#region FakeRelationships
		public static class Relationships 
		{
			/// <summary>1:N processstageparameter_AsyncOperations</summary>
			public static readonly XrmFakedRelationship ProcessstageparameterAsyncOperations = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "processstageparameterid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "processstageparameter",
					Entity2LogicalName = "asyncoperation",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N processstageparameter_BulkDeleteFailures</summary>
			public static readonly XrmFakedRelationship ProcessstageparameterBulkDeleteFailures = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "processstageparameterid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "processstageparameter",
					Entity2LogicalName = "bulkdeletefailure",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N processstageparameter_MailboxTrackingFolders</summary>
			public static readonly XrmFakedRelationship ProcessstageparameterMailboxTrackingFolders = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "processstageparameterid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "processstageparameter",
					Entity2LogicalName = "mailboxtrackingfolder",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N processstageparameter_PrincipalObjectAttributeAccesses</summary>
			public static readonly XrmFakedRelationship ProcessstageparameterPrincipalObjectAttributeAccesses = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "processstageparameterid",
					Entity2Attribute = "objectid",
					Entity1LogicalName = "processstageparameter",
					Entity2LogicalName = "principalobjectattributeaccess",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N processstageparameter_ProcessSession</summary>
			public static readonly XrmFakedRelationship ProcessstageparameterProcessSession = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "processstageparameterid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "processstageparameter",
					Entity2LogicalName = "processsession",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N processstageparameter_SyncErrors</summary>
			public static readonly XrmFakedRelationship ProcessstageparameterSyncErrors = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "processstageparameterid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "processstageparameter",
					Entity2LogicalName = "syncerror",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

		}
		#endregion

		#region Fake
		public static ProcessStageParameter Create()
		{
			var faker = new Faker<ProcessStageParameter>()
			.RuleFor(e => e.Createdbyname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Createdbyyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.CreatedOn, fake => fake.Date.Soon())
			.RuleFor(e => e.Createdonbehalfbyname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Createdonbehalfbyyominame, fake => fake.Lorem.Word())
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
			.RuleFor(e => e.Processstageidname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Id, fake => Guid.NewGuid())
			.RuleFor(e => e.Status, fake => fake.PickRandom<ProcessStageParameter.eStatus>())
			.RuleFor(e => e.StatusReason, fake => fake.PickRandom<ProcessStageParameter.eStatusReason>())
			.RuleFor(e => e.TimeZoneRuleVersionNumber, fake => fake.Random.Int())
			.RuleFor(e => e.UTCConversionTimeZoneCode, fake => fake.Random.Int())
			.RuleFor(e => e.Value, fake => fake.Lorem.Word())
			.RuleFor(e => e.VersionNumber, fake => fake.Random.Int());
			return faker.Generate();
		}
		#endregion
	}
}

