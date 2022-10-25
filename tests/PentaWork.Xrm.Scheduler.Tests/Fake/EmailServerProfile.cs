using Bogus;
using System;
using FakeXrmEasy;
using System.Collections.Generic;
using PentaWork.Xrm.Scheduler.Proxies.Entities;

namespace PentaWork.Xrm.Scheduler.Tests.Fake
{
	public static class FakeEmailServerProfile
	{	
		#region FakeRelationships
		public static class Relationships 
		{
			/// <summary>1:N EmailServerProfile_Annotation</summary>
			public static readonly XrmFakedRelationship EmailServerProfileAnnotation = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "emailserverprofileid",
					Entity2Attribute = "objectid",
					Entity1LogicalName = "emailserverprofile",
					Entity2LogicalName = "annotation",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N emailserverprofile_asyncoperations</summary>
			public static readonly XrmFakedRelationship EmailserverprofileAsyncoperations = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "emailserverprofileid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "emailserverprofile",
					Entity2LogicalName = "asyncoperation",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N emailserverprofile_bulkdeletefailures</summary>
			public static readonly XrmFakedRelationship EmailserverprofileBulkdeletefailures = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "emailserverprofileid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "emailserverprofile",
					Entity2LogicalName = "bulkdeletefailure",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N emailserverprofile_duplicatebaserecord</summary>
			public static readonly XrmFakedRelationship EmailserverprofileDuplicatebaserecord = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "emailserverprofileid",
					Entity2Attribute = "baserecordid",
					Entity1LogicalName = "emailserverprofile",
					Entity2LogicalName = "duplicaterecord",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N emailserverprofile_duplicatematchingrecord</summary>
			public static readonly XrmFakedRelationship EmailserverprofileDuplicatematchingrecord = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "emailserverprofileid",
					Entity2Attribute = "duplicaterecordid",
					Entity1LogicalName = "emailserverprofile",
					Entity2LogicalName = "duplicaterecord",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N emailserverprofile_mailbox</summary>
			public static readonly XrmFakedRelationship EmailserverprofileMailbox = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "emailserverprofileid",
					Entity2Attribute = "emailserverprofile",
					Entity1LogicalName = "emailserverprofile",
					Entity2LogicalName = "mailbox",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N EmailServerProfile_Organization</summary>
			public static readonly XrmFakedRelationship EmailServerProfileOrganization = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "emailserverprofileid",
					Entity2Attribute = "defaultemailserverprofileid",
					Entity1LogicalName = "emailserverprofile",
					Entity2LogicalName = "organization",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N EmailServerProfile_SyncErrors</summary>
			public static readonly XrmFakedRelationship EmailServerProfileSyncErrors = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "emailserverprofileid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "emailserverprofile",
					Entity2LogicalName = "syncerror",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N tracelog_EmailServerProfile</summary>
			public static readonly XrmFakedRelationship TracelogEmailServerProfile = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "emailserverprofileid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "emailserverprofile",
					Entity2LogicalName = "tracelog",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

		}
		#endregion

		#region Fake
		public static EmailServerProfile Create()
		{
			var faker = new Faker<EmailServerProfile>()
			.RuleFor(e => e.Createdbyname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Createdbyyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.CreatedOn, fake => fake.Date.Soon())
			.RuleFor(e => e.Createdonbehalfbyname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Createdonbehalfbyyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.DefaultEmailServerLocation, fake => fake.Lorem.Word())
			.RuleFor(e => e.Description, fake => fake.Lorem.Word())
			.RuleFor(e => e.Id, fake => Guid.NewGuid())
			.RuleFor(e => e.EmailServerTypeName, fake => fake.Lorem.Word())
			.RuleFor(e => e.EncodingCodePage, fake => fake.Lorem.Word())
			.RuleFor(e => e.EntityimageTimestamp, fake => fake.Random.Int())
			.RuleFor(e => e.EntityimageUrl, fake => fake.Lorem.Word())
			.RuleFor(e => e.EntityImageId, fake => Guid.NewGuid())
			.RuleFor(e => e.ExchangeOnlineTenantId, fake => fake.Lorem.Word())
			.RuleFor(e => e.ExchangeVersion, fake => fake.PickRandom<EmailServerProfile.eExchangeVersion>())
			.RuleFor(e => e.IncomingAuthenticationProtocol, fake => fake.PickRandom<EmailServerProfile.egAuthenticationProtocol>())
			.RuleFor(e => e.IncomingEmailCredentialRetrieval, fake => fake.PickRandom<EmailServerProfile.eCredentialRetrievalMethod>())
			.RuleFor(e => e.Incomingpartnerapplicationname, fake => fake.Lorem.Word())
			.RuleFor(e => e.IncomingEmailPassword, fake => fake.Lorem.Word())
			.RuleFor(e => e.IncomingEmailPort, fake => fake.Random.Int())
			.RuleFor(e => e.IncomingEmailServerLocation, fake => fake.Lorem.Word())
			.RuleFor(e => e.UseImpersonationForIncomingEmail, fake => fake.Random.Bool())
			.RuleFor(e => e.IncomingEmailUserName, fake => fake.Lorem.Word())
			.RuleFor(e => e.UseSSLForIncomingEmail, fake => fake.Random.Bool())
			.RuleFor(e => e.Isincomingpasswordset, fake => fake.Random.Bool())
			.RuleFor(e => e.Isoauthclientsecretset, fake => fake.Random.Bool())
			.RuleFor(e => e.Isoutgoingpasswordset, fake => fake.Random.Bool())
			.RuleFor(e => e.LastTestAuthorizationStatus, fake => fake.PickRandom<EmailServerProfile.eSelectTheStatusOfTheTest>())
			.RuleFor(e => e.LastDynamics365Message, fake => fake.Lorem.Word())
			.RuleFor(e => e.LastTestExecutionStatus, fake => fake.PickRandom<EmailServerProfile.eSelectTheStatusOfTheTest2>())
			.RuleFor(e => e.LastTestRequest, fake => fake.Lorem.Word())
			.RuleFor(e => e.LastTestResponse, fake => fake.Lorem.Word())
			.RuleFor(e => e.LastTestTime, fake => fake.Date.Soon())
			.RuleFor(e => e.LastTestTimeTaken, fake => fake.Random.Int())
			.RuleFor(e => e.LastTestValidationStatus, fake => fake.PickRandom<EmailServerProfile.eSelectTheStatusOfTheTest3>())
			.RuleFor(e => e.MaximumConcurrentConnections, fake => fake.Random.Int())
			.RuleFor(e => e.MinimumPollingIntervalInMinutes, fake => fake.Random.Int())
			.RuleFor(e => e.Modifiedbyname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Modifiedbyyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.ModifiedOn, fake => fake.Date.Soon())
			.RuleFor(e => e.Modifiedonbehalfbyname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Modifiedonbehalfbyyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.MoveUndeliveredEmailsToTheUndeliverableFolder, fake => fake.Random.Bool())
			.RuleFor(e => e.Name, fake => fake.Lorem.Word())
			.RuleFor(e => e.OauthClientId, fake => fake.Lorem.Word())
			.RuleFor(e => e.OAuthClientSecret, fake => fake.Lorem.Word())
			.RuleFor(e => e.Organizationidname, fake => fake.Lorem.Word())
			.RuleFor(e => e.OutgoingAuthenticationProtocol, fake => fake.PickRandom<EmailServerProfile.egAuthenticationProtocol>())
			.RuleFor(e => e.AutoGrantDelegateAccessForOutgoingEmail, fake => fake.Random.Bool())
			.RuleFor(e => e.OutgoingEmailCredentialRetrieval, fake => fake.PickRandom<EmailServerProfile.eUseWindowsAuthenticationForOutgoing>())
			.RuleFor(e => e.Outgoingpartnerapplicationname, fake => fake.Lorem.Word())
			.RuleFor(e => e.OutgoingEmailPassword, fake => fake.Lorem.Word())
			.RuleFor(e => e.OutgoingEmailPort, fake => fake.Random.Int())
			.RuleFor(e => e.OutgoingEmailServerLocation, fake => fake.Lorem.Word())
			.RuleFor(e => e.UseImpersonationForOutgoingEmail, fake => fake.Random.Bool())
			.RuleFor(e => e.OutgoingEmailUserName, fake => fake.Lorem.Word())
			.RuleFor(e => e.UseSSLForOutgoingEmail, fake => fake.Random.Bool())
			.RuleFor(e => e.EmailServerProfileOwnersEmailAddress, fake => fake.Lorem.Word())
			.RuleFor(e => e.Owneridname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Owneridtype, fake => fake.Lorem.Word())
			.RuleFor(e => e.Owneridyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.Owningbusinessunitname, fake => fake.Lorem.Word())
			.RuleFor(e => e.ProcessEmailsReceivedAfter, fake => fake.Date.Soon())
			.RuleFor(e => e.SendAnAlertEmailToTheOwnerOfTheEmailServerProfileReportingOnMajorEvents, fake => fake.Random.Bool())
			.RuleFor(e => e.EmailServerType, fake => fake.PickRandom<EmailServerProfile.eEmailServerType>())
			.RuleFor(e => e.Status, fake => fake.PickRandom<EmailServerProfile.eStatus>())
			.RuleFor(e => e.StatusReason, fake => fake.PickRandom<EmailServerProfile.eStatusReason>())
			.RuleFor(e => e.TimeoutMailboxConnectionToExchange, fake => fake.Random.Bool())
			.RuleFor(e => e.TimeoutASingleMailboxConnectionAfterThisAmountOfMilliseconds, fake => fake.Random.Int())
			.RuleFor(e => e.TimeZoneRuleVersionNumber, fake => fake.Random.Int())
			.RuleFor(e => e.AutoDiscoverServerLocation, fake => fake.Random.Bool())
			.RuleFor(e => e.UseDefaultTenantId, fake => fake.Random.Bool())
			.RuleFor(e => e.UseSameSettingsForOutgoingConnection, fake => fake.Random.Bool())
			.RuleFor(e => e.UTCConversionTimeZoneCode, fake => fake.Random.Int())
			.RuleFor(e => e.VersionNumber, fake => fake.Random.Int());
			return faker.Generate();
		}
		#endregion
	}
}

