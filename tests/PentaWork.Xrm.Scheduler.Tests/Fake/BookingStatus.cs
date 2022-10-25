using Bogus;
using System;
using FakeXrmEasy;
using System.Collections.Generic;
using PentaWork.Xrm.Scheduler.Proxies.Entities;

namespace PentaWork.Xrm.Scheduler.Tests.Fake
{
	public static class FakeBookingStatus
	{	
		#region FakeRelationships
		public static class Relationships 
		{
			/// <summary>1:N bookingstatus_AsyncOperations</summary>
			public static readonly XrmFakedRelationship BookingstatusAsyncOperations = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "bookingstatusid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "bookingstatus",
					Entity2LogicalName = "asyncoperation",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N bookingstatus_bookableresourcebooking_BookingStatus</summary>
			public static readonly XrmFakedRelationship BookingstatusBookableresourcebookingBookingStatus = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "bookingstatusid",
					Entity2Attribute = "bookingstatus",
					Entity1LogicalName = "bookingstatus",
					Entity2LogicalName = "bookableresourcebooking",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N bookingstatus_BulkDeleteFailures</summary>
			public static readonly XrmFakedRelationship BookingstatusBulkDeleteFailures = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "bookingstatusid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "bookingstatus",
					Entity2LogicalName = "bulkdeletefailure",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N bookingstatus_DuplicateBaseRecord</summary>
			public static readonly XrmFakedRelationship BookingstatusDuplicateBaseRecord = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "bookingstatusid",
					Entity2Attribute = "baserecordid",
					Entity1LogicalName = "bookingstatus",
					Entity2LogicalName = "duplicaterecord",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N bookingstatus_DuplicateMatchingRecord</summary>
			public static readonly XrmFakedRelationship BookingstatusDuplicateMatchingRecord = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "bookingstatusid",
					Entity2Attribute = "duplicaterecordid",
					Entity1LogicalName = "bookingstatus",
					Entity2LogicalName = "duplicaterecord",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N bookingstatus_MailboxTrackingFolders</summary>
			public static readonly XrmFakedRelationship BookingstatusMailboxTrackingFolders = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "bookingstatusid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "bookingstatus",
					Entity2LogicalName = "mailboxtrackingfolder",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N bookingstatus_PrincipalObjectAttributeAccess</summary>
			public static readonly XrmFakedRelationship BookingstatusPrincipalObjectAttributeAccess = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "bookingstatusid",
					Entity2Attribute = "objectid",
					Entity1LogicalName = "bookingstatus",
					Entity2LogicalName = "principalobjectattributeaccess",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N bookingstatus_ProcessSession</summary>
			public static readonly XrmFakedRelationship BookingstatusProcessSession = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "bookingstatusid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "bookingstatus",
					Entity2LogicalName = "processsession",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N BookingStatus_SyncErrors</summary>
			public static readonly XrmFakedRelationship BookingStatusSyncErrors = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "bookingstatusid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "bookingstatus",
					Entity2LogicalName = "syncerror",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

		}
		#endregion

		#region Fake
		public static BookingStatus Create()
		{
			var faker = new Faker<BookingStatus>()
			.RuleFor(e => e.Id, fake => Guid.NewGuid())
			.RuleFor(e => e.Createdbyname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Createdbyyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.CreatedOn, fake => fake.Date.Soon())
			.RuleFor(e => e.Createdonbehalfbyname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Createdonbehalfbyyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.TypeADetailedDescriptionOfTheBookingStatus, fake => fake.Lorem.Word())
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
			.RuleFor(e => e.Status, fake => fake.PickRandom<BookingStatus.eStatus>())
			.RuleFor(e => e.Status2, fake => fake.PickRandom<BookingStatus.eStatus2>())
			.RuleFor(e => e.StatusReason, fake => fake.PickRandom<BookingStatus.eStatusReason>())
			.RuleFor(e => e.TimeZoneRuleVersionNumber, fake => fake.Random.Int())
			.RuleFor(e => e.Transactioncurrencyidname, fake => fake.Lorem.Word())
			.RuleFor(e => e.UTCConversionTimeZoneCode, fake => fake.Random.Int())
			.RuleFor(e => e.VersionNumber, fake => fake.Random.Int());
			return faker.Generate();
		}
		#endregion
	}
}

