using Bogus;
using System;
using FakeXrmEasy;
using System.Collections.Generic;
using PentaWork.Xrm.Scheduler.Proxies.Entities;

namespace PentaWork.Xrm.Scheduler.Tests.Fake
{
	public static class FakeProfileAlbum
	{	
		#region FakeRelationships
		public static class Relationships 
		{
			/// <summary>1:N msdyn_postalbum_ActivityPointers</summary>
			public static readonly XrmFakedRelationship MsdynPostalbumActivityPointers = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "msdyn_postalbumid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "msdyn_postalbum",
					Entity2LogicalName = "activitypointer",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N msdyn_postalbum_Annotations</summary>
			public static readonly XrmFakedRelationship MsdynPostalbumAnnotations = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "msdyn_postalbumid",
					Entity2Attribute = "objectid",
					Entity1LogicalName = "msdyn_postalbum",
					Entity2LogicalName = "annotation",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N msdyn_postalbum_Appointments</summary>
			public static readonly XrmFakedRelationship MsdynPostalbumAppointments = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "msdyn_postalbumid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "msdyn_postalbum",
					Entity2LogicalName = "appointment",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N msdyn_postalbum_AsyncOperations</summary>
			public static readonly XrmFakedRelationship MsdynPostalbumAsyncOperations = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "msdyn_postalbumid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "msdyn_postalbum",
					Entity2LogicalName = "asyncoperation",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N msdyn_postalbum_BulkDeleteFailures</summary>
			public static readonly XrmFakedRelationship MsdynPostalbumBulkDeleteFailures = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "msdyn_postalbumid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "msdyn_postalbum",
					Entity2LogicalName = "bulkdeletefailure",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N msdyn_postalbum_connections1</summary>
			public static readonly XrmFakedRelationship MsdynPostalbumConnections1 = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "msdyn_postalbumid",
					Entity2Attribute = "record1id",
					Entity1LogicalName = "msdyn_postalbum",
					Entity2LogicalName = "connection",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N msdyn_postalbum_connections2</summary>
			public static readonly XrmFakedRelationship MsdynPostalbumConnections2 = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "msdyn_postalbumid",
					Entity2Attribute = "record2id",
					Entity1LogicalName = "msdyn_postalbum",
					Entity2LogicalName = "connection",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N msdyn_postalbum_DuplicateBaseRecord</summary>
			public static readonly XrmFakedRelationship MsdynPostalbumDuplicateBaseRecord = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "msdyn_postalbumid",
					Entity2Attribute = "baserecordid",
					Entity1LogicalName = "msdyn_postalbum",
					Entity2LogicalName = "duplicaterecord",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N msdyn_postalbum_DuplicateMatchingRecord</summary>
			public static readonly XrmFakedRelationship MsdynPostalbumDuplicateMatchingRecord = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "msdyn_postalbumid",
					Entity2Attribute = "duplicaterecordid",
					Entity1LogicalName = "msdyn_postalbum",
					Entity2LogicalName = "duplicaterecord",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N msdyn_postalbum_Emails</summary>
			public static readonly XrmFakedRelationship MsdynPostalbumEmails = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "msdyn_postalbumid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "msdyn_postalbum",
					Entity2LogicalName = "email",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N msdyn_postalbum_Faxes</summary>
			public static readonly XrmFakedRelationship MsdynPostalbumFaxes = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "msdyn_postalbumid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "msdyn_postalbum",
					Entity2LogicalName = "fax",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N msdyn_postalbum_Letters</summary>
			public static readonly XrmFakedRelationship MsdynPostalbumLetters = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "msdyn_postalbumid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "msdyn_postalbum",
					Entity2LogicalName = "letter",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N msdyn_postalbum_MailboxTrackingFolders</summary>
			public static readonly XrmFakedRelationship MsdynPostalbumMailboxTrackingFolders = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "msdyn_postalbumid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "msdyn_postalbum",
					Entity2LogicalName = "mailboxtrackingfolder",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N msdyn_postalbum_PhoneCalls</summary>
			public static readonly XrmFakedRelationship MsdynPostalbumPhoneCalls = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "msdyn_postalbumid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "msdyn_postalbum",
					Entity2LogicalName = "phonecall",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N msdyn_postalbum_PrincipalObjectAttributeAccesses</summary>
			public static readonly XrmFakedRelationship MsdynPostalbumPrincipalObjectAttributeAccesses = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "msdyn_postalbumid",
					Entity2Attribute = "objectid",
					Entity1LogicalName = "msdyn_postalbum",
					Entity2LogicalName = "principalobjectattributeaccess",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N msdyn_postalbum_ProcessSession</summary>
			public static readonly XrmFakedRelationship MsdynPostalbumProcessSession = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "msdyn_postalbumid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "msdyn_postalbum",
					Entity2LogicalName = "processsession",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N msdyn_postalbum_RecurringAppointmentMasters</summary>
			public static readonly XrmFakedRelationship MsdynPostalbumRecurringAppointmentMasters = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "msdyn_postalbumid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "msdyn_postalbum",
					Entity2LogicalName = "recurringappointmentmaster",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N msdyn_postalbum_ServiceAppointments</summary>
			public static readonly XrmFakedRelationship MsdynPostalbumServiceAppointments = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "msdyn_postalbumid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "msdyn_postalbum",
					Entity2LogicalName = "serviceappointment",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N msdyn_postalbum_SocialActivities</summary>
			public static readonly XrmFakedRelationship MsdynPostalbumSocialActivities = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "msdyn_postalbumid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "msdyn_postalbum",
					Entity2LogicalName = "socialactivity",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N msdyn_postalbum_SyncErrors</summary>
			public static readonly XrmFakedRelationship MsdynPostalbumSyncErrors = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "msdyn_postalbumid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "msdyn_postalbum",
					Entity2LogicalName = "syncerror",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N msdyn_postalbum_Tasks</summary>
			public static readonly XrmFakedRelationship MsdynPostalbumTasks = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "msdyn_postalbumid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "msdyn_postalbum",
					Entity2LogicalName = "task",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

		}
		#endregion

		#region Fake
		public static ProfileAlbum Create()
		{
			var faker = new Faker<ProfileAlbum>()
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
			.RuleFor(e => e.Id, fake => Guid.NewGuid())
			.RuleFor(e => e.RecordCreatedOn, fake => fake.Date.Soon())
			.RuleFor(e => e.Owneridname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Owneridtype, fake => fake.Lorem.Word())
			.RuleFor(e => e.Owneridyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.Status, fake => fake.PickRandom<ProfileAlbum.eStatus>())
			.RuleFor(e => e.StatusReason, fake => fake.PickRandom<ProfileAlbum.eStatusReason>())
			.RuleFor(e => e.TimeZoneRuleVersionNumber, fake => fake.Random.Int())
			.RuleFor(e => e.UTCConversionTimeZoneCode, fake => fake.Random.Int())
			.RuleFor(e => e.VersionNumber, fake => fake.Random.Int());
			return faker.Generate();
		}
		#endregion
	}
}

