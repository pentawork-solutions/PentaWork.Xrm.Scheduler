using Bogus;
using System;
using FakeXrmEasy;
using System.Collections.Generic;
using PentaWork.Xrm.Scheduler.Proxies.Entities;

namespace PentaWork.Xrm.Scheduler.Tests.Fake
{
	public static class FakeContract
	{	
		#region FakeRelationships
		public static class Relationships 
		{
			/// <summary>1:N contract_activity_parties</summary>
			public static readonly XrmFakedRelationship ContractActivityParties = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "contractid",
					Entity2Attribute = "partyid",
					Entity1LogicalName = "contract",
					Entity2LogicalName = "activityparty",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N Contract_ActivityPointers</summary>
			public static readonly XrmFakedRelationship ContractActivityPointers = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "contractid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "contract",
					Entity2LogicalName = "activitypointer",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N Contract_Annotation</summary>
			public static readonly XrmFakedRelationship ContractAnnotation = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "contractid",
					Entity2Attribute = "objectid",
					Entity1LogicalName = "contract",
					Entity2LogicalName = "annotation",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N Contract_Appointments</summary>
			public static readonly XrmFakedRelationship ContractAppointments = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "contractid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "contract",
					Entity2LogicalName = "appointment",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N Contract_AsyncOperations</summary>
			public static readonly XrmFakedRelationship ContractAsyncOperations = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "contractid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "contract",
					Entity2LogicalName = "asyncoperation",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N Contract_BulkDeleteFailures</summary>
			public static readonly XrmFakedRelationship ContractBulkDeleteFailures = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "contractid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "contract",
					Entity2LogicalName = "bulkdeletefailure",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N contract_cases</summary>
			public static readonly XrmFakedRelationship ContractCases = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "contractid",
					Entity2Attribute = "contractid",
					Entity1LogicalName = "contract",
					Entity2LogicalName = "incident",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N contract_connections1</summary>
			public static readonly XrmFakedRelationship ContractConnections1 = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "contractid",
					Entity2Attribute = "record1id",
					Entity1LogicalName = "contract",
					Entity2LogicalName = "connection",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N contract_connections2</summary>
			public static readonly XrmFakedRelationship ContractConnections2 = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "contractid",
					Entity2Attribute = "record2id",
					Entity1LogicalName = "contract",
					Entity2LogicalName = "connection",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N Contract_DuplicateBaseRecord</summary>
			public static readonly XrmFakedRelationship ContractDuplicateBaseRecord = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "contractid",
					Entity2Attribute = "baserecordid",
					Entity1LogicalName = "contract",
					Entity2LogicalName = "duplicaterecord",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N Contract_DuplicateMatchingRecord</summary>
			public static readonly XrmFakedRelationship ContractDuplicateMatchingRecord = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "contractid",
					Entity2Attribute = "duplicaterecordid",
					Entity1LogicalName = "contract",
					Entity2LogicalName = "duplicaterecord",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N Contract_Emails</summary>
			public static readonly XrmFakedRelationship ContractEmails = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "contractid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "contract",
					Entity2LogicalName = "email",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N Contract_Faxes</summary>
			public static readonly XrmFakedRelationship ContractFaxes = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "contractid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "contract",
					Entity2LogicalName = "fax",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N Contract_Letters</summary>
			public static readonly XrmFakedRelationship ContractLetters = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "contractid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "contract",
					Entity2LogicalName = "letter",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N contract_line_items</summary>
			public static readonly XrmFakedRelationship ContractLineItems = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "contractid",
					Entity2Attribute = "contractid",
					Entity1LogicalName = "contract",
					Entity2LogicalName = "contractdetail",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N Contract_MailboxTrackingFolder</summary>
			public static readonly XrmFakedRelationship ContractMailboxTrackingFolder = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "contractid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "contract",
					Entity2LogicalName = "mailboxtrackingfolder",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N contract_originating_contract</summary>
			public static readonly XrmFakedRelationship ContractOriginatingContract = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "contractid",
					Entity2Attribute = "originatingcontract",
					Entity1LogicalName = "contract",
					Entity2LogicalName = "contract",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N Contract_Phonecalls</summary>
			public static readonly XrmFakedRelationship ContractPhonecalls = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "contractid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "contract",
					Entity2LogicalName = "phonecall",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N contract_principalobjectattributeaccess</summary>
			public static readonly XrmFakedRelationship ContractPrincipalobjectattributeaccess = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "contractid",
					Entity2Attribute = "objectid",
					Entity1LogicalName = "contract",
					Entity2LogicalName = "principalobjectattributeaccess",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N Contract_ProcessSessions</summary>
			public static readonly XrmFakedRelationship ContractProcessSessions = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "contractid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "contract",
					Entity2LogicalName = "processsession",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N Contract_RecurringAppointmentMasters</summary>
			public static readonly XrmFakedRelationship ContractRecurringAppointmentMasters = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "contractid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "contract",
					Entity2LogicalName = "recurringappointmentmaster",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N Contract_ServiceAppointments</summary>
			public static readonly XrmFakedRelationship ContractServiceAppointments = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "contractid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "contract",
					Entity2LogicalName = "serviceappointment",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N Contract_SocialActivities</summary>
			public static readonly XrmFakedRelationship ContractSocialActivities = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "contractid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "contract",
					Entity2LogicalName = "socialactivity",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N Contract_SyncErrors</summary>
			public static readonly XrmFakedRelationship ContractSyncErrors = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "contractid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "contract",
					Entity2LogicalName = "syncerror",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N Contract_Tasks</summary>
			public static readonly XrmFakedRelationship ContractTasks = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "contractid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "contract",
					Entity2LogicalName = "task",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>N:N servicecontractcontacts_association</summary>
			public static readonly XrmFakedRelationship ServicecontractcontactsAssociation = 
				new XrmFakedRelationship
				{
					IntersectEntity = "servicecontractcontacts_association",
					Entity1Attribute = "contactid",
					Entity2Attribute = "contractid",
					Entity1LogicalName = "contact",
					Entity2LogicalName = "contract",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.ManyToMany
				};

		}
		#endregion

		#region Fake
		public static Contract Create()
		{
			var faker = new Faker<Contract>()
			.RuleFor(e => e.Accountidname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Accountidyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.ContractStartDate, fake => fake.Date.Soon())
			.RuleFor(e => e.AllotmentType, fake => fake.PickRandom<Contract.eAllotmentType>())
			.RuleFor(e => e.Billingaccountidname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Billingaccountidyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.Billingcontactidname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Billingcontactidyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.Billingcustomeridname, fake => fake.Lorem.Word())
			.RuleFor(e => e.BillToCustomerType, fake => fake.Lorem.Word())
			.RuleFor(e => e.Billingcustomeridyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.BillingEndDate, fake => fake.Date.Soon())
			.RuleFor(e => e.BillingFrequency, fake => fake.PickRandom<Contract.eBillingFrequency>())
			.RuleFor(e => e.BillingStartDate, fake => fake.Date.Soon())
			.RuleFor(e => e.Billtoaddressname, fake => fake.Lorem.Word())
			.RuleFor(e => e.CancellationDate, fake => fake.Date.Soon())
			.RuleFor(e => e.Contactidname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Contactidyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.Id, fake => Guid.NewGuid())
			.RuleFor(e => e.Description, fake => fake.Lorem.Word())
			.RuleFor(e => e.ContractID, fake => fake.Lorem.Word())
			.RuleFor(e => e.ServiceLevel, fake => fake.PickRandom<Contract.eServiceLevel>())
			.RuleFor(e => e.TemplateAbbreviation, fake => fake.Lorem.Word())
			.RuleFor(e => e.Contracttemplateidname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Createdbyname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Createdbyyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.CreatedOn, fake => fake.Date.Soon())
			.RuleFor(e => e.Createdonbehalfbyname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Createdonbehalfbyyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.Customeridname, fake => fake.Lorem.Word())
			.RuleFor(e => e.CustomerType, fake => fake.Lorem.Word())
			.RuleFor(e => e.Customeridyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.Duration, fake => fake.Random.Int())
			.RuleFor(e => e.SupportCalendar, fake => fake.Lorem.Word())
			.RuleFor(e => e.EmailAddress, fake => fake.Lorem.Word())
			.RuleFor(e => e.EntityimageTimestamp, fake => fake.Random.Int())
			.RuleFor(e => e.EntityimageUrl, fake => fake.Lorem.Word())
			.RuleFor(e => e.EntityimageId, fake => Guid.NewGuid())
			.RuleFor(e => e.ExchangeRate, fake => fake.Finance.Amount())
			.RuleFor(e => e.ContractEndDate, fake => fake.Date.Soon())
			.RuleFor(e => e.ImportSequenceNumber, fake => fake.Random.Int())
			.RuleFor(e => e.Modifiedbyname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Modifiedbyyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.ModifiedOn, fake => fake.Date.Soon())
			.RuleFor(e => e.Modifiedonbehalfbyname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Modifiedonbehalfbyyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.NetPrice, fake => fake.Finance.Amount())
			.RuleFor(e => e.Originatingcontractname, fake => fake.Lorem.Word())
			.RuleFor(e => e.RecordCreatedOn, fake => fake.Date.Soon())
			.RuleFor(e => e.Owneridname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Owneridtype, fake => fake.Lorem.Word())
			.RuleFor(e => e.Owneridyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.Serviceaddressname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Status, fake => fake.PickRandom<Contract.eStatus>())
			.RuleFor(e => e.StatusReason, fake => fake.PickRandom<Contract.eStatusReason>())
			.RuleFor(e => e.TimeZoneRuleVersionNumber, fake => fake.Random.Int())
			.RuleFor(e => e.ContractName, fake => fake.Lorem.Word())
			.RuleFor(e => e.TotalDiscount, fake => fake.Finance.Amount())
			.RuleFor(e => e.TotalPrice, fake => fake.Finance.Amount())
			.RuleFor(e => e.Transactioncurrencyidname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Discount, fake => fake.Random.Bool())
			.RuleFor(e => e.UTCConversionTimeZoneCode, fake => fake.Random.Int())
			.RuleFor(e => e.VersionNumber, fake => fake.Random.Int());
			return faker.Generate();
		}
		#endregion
	}
}

