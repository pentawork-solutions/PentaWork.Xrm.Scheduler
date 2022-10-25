using Bogus;
using System;
using FakeXrmEasy;
using System.Collections.Generic;
using PentaWork.Xrm.Scheduler.Proxies.Entities;

namespace PentaWork.Xrm.Scheduler.Tests.Fake
{
	public static class FakeContractLine
	{	
		#region FakeRelationships
		public static class Relationships 
		{
			/// <summary>1:N contract_detail_cases</summary>
			public static readonly XrmFakedRelationship ContractDetailCases = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "contractdetailid",
					Entity2Attribute = "contractdetailid",
					Entity1LogicalName = "contractdetail",
					Entity2LogicalName = "incident",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N ContractDetail_Annotation</summary>
			public static readonly XrmFakedRelationship ContractDetailAnnotation = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "contractdetailid",
					Entity2Attribute = "objectid",
					Entity1LogicalName = "contractdetail",
					Entity2LogicalName = "annotation",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N ContractDetail_AsyncOperations</summary>
			public static readonly XrmFakedRelationship ContractDetailAsyncOperations = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "contractdetailid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "contractdetail",
					Entity2LogicalName = "asyncoperation",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N ContractDetail_BulkDeleteFailures</summary>
			public static readonly XrmFakedRelationship ContractDetailBulkDeleteFailures = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "contractdetailid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "contractdetail",
					Entity2LogicalName = "bulkdeletefailure",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N contractdetail_MailboxTrackingFolders</summary>
			public static readonly XrmFakedRelationship ContractdetailMailboxTrackingFolders = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "contractdetailid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "contractdetail",
					Entity2LogicalName = "mailboxtrackingfolder",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N contractdetail_principalobjectattributeaccess</summary>
			public static readonly XrmFakedRelationship ContractdetailPrincipalobjectattributeaccess = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "contractdetailid",
					Entity2Attribute = "objectid",
					Entity1LogicalName = "contractdetail",
					Entity2LogicalName = "principalobjectattributeaccess",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N ContractDetail_ProcessSessions</summary>
			public static readonly XrmFakedRelationship ContractDetailProcessSessions = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "contractdetailid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "contractdetail",
					Entity2LogicalName = "processsession",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N ContractDetail_SyncErrors</summary>
			public static readonly XrmFakedRelationship ContractDetailSyncErrors = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "contractdetailid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "contractdetail",
					Entity2LogicalName = "syncerror",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

		}
		#endregion

		#region Fake
		public static ContractLine Create()
		{
			var faker = new Faker<ContractLine>()
			.RuleFor(e => e.StartDate, fake => fake.Date.Soon())
			.RuleFor(e => e.AllotmentsOverage, fake => fake.Random.Int())
			.RuleFor(e => e.AllotmentsRemaining, fake => fake.Random.Int())
			.RuleFor(e => e.AllotmentsUsed, fake => fake.Random.Int())
			.RuleFor(e => e.Id, fake => Guid.NewGuid())
			.RuleFor(e => e.Contractidname, fake => fake.Lorem.Word())
			.RuleFor(e => e.ContractState, fake => fake.PickRandom<ContractLine.eContractState>())
			.RuleFor(e => e.Createdbyname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Createdbyyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.CreatedOn, fake => fake.Date.Soon())
			.RuleFor(e => e.Createdonbehalfbyname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Createdonbehalfbyyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.Customeridname, fake => fake.Lorem.Word())
			.RuleFor(e => e.CustomerType, fake => fake.Lorem.Word())
			.RuleFor(e => e.Customeridyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.Discount, fake => fake.Finance.Amount())
			.RuleFor(e => e.Discount2, fake => fake.Finance.Amount())
			.RuleFor(e => e.SupportCalendar, fake => fake.Lorem.Word())
			.RuleFor(e => e.ExchangeRate, fake => fake.Finance.Amount())
			.RuleFor(e => e.EndDate, fake => fake.Date.Soon())
			.RuleFor(e => e.ImportSequenceNumber, fake => fake.Random.Int())
			.RuleFor(e => e.Quantity, fake => fake.Random.Int())
			.RuleFor(e => e.LineItemOrder, fake => fake.Random.Int())
			.RuleFor(e => e.Modifiedbyname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Modifiedbyyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.ModifiedOn, fake => fake.Date.Soon())
			.RuleFor(e => e.Modifiedonbehalfbyname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Modifiedonbehalfbyyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.Net, fake => fake.Finance.Amount())
			.RuleFor(e => e.RecordCreatedOn, fake => fake.Date.Soon())
			.RuleFor(e => e.Owneridname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Owneridtype, fake => fake.Lorem.Word())
			.RuleFor(e => e.Owneridyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.TotalPrice, fake => fake.Finance.Amount())
			.RuleFor(e => e.Productidname, fake => fake.Lorem.Word())
			.RuleFor(e => e.SerialNumber, fake => fake.Lorem.Word())
			.RuleFor(e => e.Rate, fake => fake.Finance.Amount())
			.RuleFor(e => e.Serviceaddressname, fake => fake.Lorem.Word())
			.RuleFor(e => e.ServiceContractUnits, fake => fake.PickRandom<ContractLine.eServiceContractUnits>())
			.RuleFor(e => e.Status, fake => fake.PickRandom<ContractLine.eStatus>())
			.RuleFor(e => e.StatusReason, fake => fake.PickRandom<ContractLine.eStatusReason>())
			.RuleFor(e => e.TimeZoneRuleVersionNumber, fake => fake.Random.Int())
			.RuleFor(e => e.Title, fake => fake.Lorem.Word())
			.RuleFor(e => e.TotalAllotments, fake => fake.Random.Int())
			.RuleFor(e => e.Transactioncurrencyidname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Uomidname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Uomscheduleidname, fake => fake.Lorem.Word())
			.RuleFor(e => e.UTCConversionTimeZoneCode, fake => fake.Random.Int())
			.RuleFor(e => e.VersionNumber, fake => fake.Random.Int());
			return faker.Generate();
		}
		#endregion
	}
}

