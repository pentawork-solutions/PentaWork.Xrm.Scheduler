using Bogus;
using System;
using FakeXrmEasy;
using System.Collections.Generic;
using PentaWork.Xrm.Scheduler.Proxies.Entities;

namespace PentaWork.Xrm.Scheduler.Tests.Fake
{
	public static class FakeQueue
	{	
		#region FakeRelationships
		public static class Relationships 
		{
			/// <summary>1:N mailbox_regarding_queue</summary>
			public static readonly XrmFakedRelationship MailboxRegardingQueue = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "queueid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "queue",
					Entity2LogicalName = "mailbox",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N queue_activity_parties</summary>
			public static readonly XrmFakedRelationship QueueActivityParties = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "queueid",
					Entity2Attribute = "partyid",
					Entity1LogicalName = "queue",
					Entity2LogicalName = "activityparty",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N Queue_AsyncOperations</summary>
			public static readonly XrmFakedRelationship QueueAsyncOperations = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "queueid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "queue",
					Entity2LogicalName = "asyncoperation",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N Queue_BulkDeleteFailures</summary>
			public static readonly XrmFakedRelationship QueueBulkDeleteFailures = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "queueid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "queue",
					Entity2LogicalName = "bulkdeletefailure",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N Queue_DuplicateBaseRecord</summary>
			public static readonly XrmFakedRelationship QueueDuplicateBaseRecord = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "queueid",
					Entity2Attribute = "baserecordid",
					Entity1LogicalName = "queue",
					Entity2LogicalName = "duplicaterecord",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N Queue_DuplicateMatchingRecord</summary>
			public static readonly XrmFakedRelationship QueueDuplicateMatchingRecord = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "queueid",
					Entity2Attribute = "duplicaterecordid",
					Entity1LogicalName = "queue",
					Entity2LogicalName = "duplicaterecord",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N Queue_Email_EmailSender</summary>
			public static readonly XrmFakedRelationship QueueEmailEmailSender = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "queueid",
					Entity2Attribute = "emailsender",
					Entity1LogicalName = "queue",
					Entity2LogicalName = "email",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N queue_entries</summary>
			public static readonly XrmFakedRelationship QueueEntries = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "queueid",
					Entity2Attribute = "queueid",
					Entity1LogicalName = "queue",
					Entity2LogicalName = "queueitem",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N queue_PostFollows</summary>
			public static readonly XrmFakedRelationship QueuePostFollows = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "queueid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "queue",
					Entity2LogicalName = "postfollow",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N queue_principalobjectattributeaccess</summary>
			public static readonly XrmFakedRelationship QueuePrincipalobjectattributeaccess = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "queueid",
					Entity2Attribute = "objectid",
					Entity1LogicalName = "queue",
					Entity2LogicalName = "principalobjectattributeaccess",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N Queue_ProcessSessions</summary>
			public static readonly XrmFakedRelationship QueueProcessSessions = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "queueid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "queue",
					Entity2LogicalName = "processsession",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N Queue_SyncErrors</summary>
			public static readonly XrmFakedRelationship QueueSyncErrors = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "queueid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "queue",
					Entity2LogicalName = "syncerror",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N queue_system_user</summary>
			public static readonly XrmFakedRelationship QueueSystemUser = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "queueid",
					Entity2Attribute = "queueid",
					Entity1LogicalName = "queue",
					Entity2LogicalName = "systemuser",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N queue_team</summary>
			public static readonly XrmFakedRelationship QueueTeam = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "queueid",
					Entity2Attribute = "queueid",
					Entity1LogicalName = "queue",
					Entity2LogicalName = "team",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>N:N queuemembership_association</summary>
			public static readonly XrmFakedRelationship QueuemembershipAssociation = 
				new XrmFakedRelationship
				{
					IntersectEntity = "queuemembership_association",
					Entity1Attribute = "queueid",
					Entity2Attribute = "systemuserid",
					Entity1LogicalName = "queue",
					Entity2LogicalName = "systemuser",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.ManyToMany
				};

		}
		#endregion

		#region Fake
		public static Queue Create()
		{
			var faker = new Faker<Queue>()
			.RuleFor(e => e.AllowToUseCredentialsForEmailProcessingObsolete, fake => fake.Random.Bool())
			.RuleFor(e => e.Businessunitidname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Createdbyname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Createdbyyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.CreatedOn, fake => fake.Date.Soon())
			.RuleFor(e => e.Createdonbehalfbyname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Createdonbehalfbyyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.Defaultmailboxname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Description, fake => fake.Lorem.Word())
			.RuleFor(e => e.IncomingEmail, fake => fake.Lorem.Word())
			.RuleFor(e => e.PasswordObsolete, fake => fake.Lorem.Word())
			.RuleFor(e => e.PrimaryEmailStatus, fake => fake.PickRandom<Queue.eShowsWhetherTheEmailAddressIsApprovedForEachMailboxForProcessingEmailThroughServersideSynchronizationOrTheEmailRouter>())
			.RuleFor(e => e.UserNameObsolete, fake => fake.Lorem.Word())
			.RuleFor(e => e.EntityimageTimestamp, fake => fake.Random.Int())
			.RuleFor(e => e.EntityimageUrl, fake => fake.Lorem.Word())
			.RuleFor(e => e.EntityImageId, fake => Guid.NewGuid())
			.RuleFor(e => e.ExchangeRate, fake => fake.Finance.Amount())
			.RuleFor(e => e.ConvertToEmailActivities, fake => fake.Random.Bool())
			.RuleFor(e => e.ImportSequenceNumber, fake => fake.Random.Int())
			.RuleFor(e => e.IncomingEmailDeliveryMethod, fake => fake.PickRandom<Queue.eIncomingEmailDeliveryMethod>())
			.RuleFor(e => e.ConvertIncomingEmailToActivities, fake => fake.PickRandom<Queue.eIncomingEmailFilteringMethod>())
			.RuleFor(e => e.EmailAddressO365AdminApprovalStatus, fake => fake.Random.Bool())
			.RuleFor(e => e.FaxQueue, fake => fake.Random.Bool())
			.RuleFor(e => e.Modifiedbyname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Modifiedbyyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.ModifiedOn, fake => fake.Date.Soon())
			.RuleFor(e => e.Modifiedonbehalfbyname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Modifiedonbehalfbyyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.Name, fake => fake.Lorem.Word())
			.RuleFor(e => e.QueueItems, fake => fake.Random.Int())
			.RuleFor(e => e.NoOfMembers, fake => fake.Random.Int())
			.RuleFor(e => e.Organizationidname, fake => fake.Lorem.Word())
			.RuleFor(e => e.OutgoingEmailDeliveryMethod, fake => fake.PickRandom<Queue.eOutgoingEmailDeliveryMethod>())
			.RuleFor(e => e.RecordCreatedOn, fake => fake.Date.Soon())
			.RuleFor(e => e.Owneridname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Owneridtype, fake => fake.Lorem.Word())
			.RuleFor(e => e.Owneridyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.Primaryuseridname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Primaryuseridyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.Id, fake => Guid.NewGuid())
			.RuleFor(e => e.QueueType, fake => fake.PickRandom<Queue.eQueueType>())
			.RuleFor(e => e.Type, fake => fake.PickRandom<Queue.eType>())
			.RuleFor(e => e.Status, fake => fake.PickRandom<Queue.eStatus>())
			.RuleFor(e => e.StatusReason, fake => fake.PickRandom<Queue.eStatusReason>())
			.RuleFor(e => e.Transactioncurrencyidname, fake => fake.Lorem.Word())
			.RuleFor(e => e.VersionNumber, fake => fake.Random.Int());
			return faker.Generate();
		}
		#endregion
	}
}

