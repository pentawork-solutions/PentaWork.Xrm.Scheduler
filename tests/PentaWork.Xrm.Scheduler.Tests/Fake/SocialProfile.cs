using Bogus;
using System;
using FakeXrmEasy;
using System.Collections.Generic;
using PentaWork.Xrm.Scheduler.Proxies.Entities;

namespace PentaWork.Xrm.Scheduler.Tests.Fake
{
	public static class FakeSocialProfile
	{	
		#region FakeRelationships
		public static class Relationships 
		{
			/// <summary>1:N SocialProfile_AsyncOperations</summary>
			public static readonly XrmFakedRelationship SocialProfileAsyncOperations = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "socialprofileid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "socialprofile",
					Entity2LogicalName = "asyncoperation",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N socialprofile_cases</summary>
			public static readonly XrmFakedRelationship SocialprofileCases = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "socialprofileid",
					Entity2Attribute = "socialprofileid",
					Entity1LogicalName = "socialprofile",
					Entity2LogicalName = "incident",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N socialprofile_connections1</summary>
			public static readonly XrmFakedRelationship SocialprofileConnections1 = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "socialprofileid",
					Entity2Attribute = "record1id",
					Entity1LogicalName = "socialprofile",
					Entity2LogicalName = "connection",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N socialprofile_connections2</summary>
			public static readonly XrmFakedRelationship SocialprofileConnections2 = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "socialprofileid",
					Entity2Attribute = "record2id",
					Entity1LogicalName = "socialprofile",
					Entity2LogicalName = "connection",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N SocialProfile_DuplicateBaseRecord</summary>
			public static readonly XrmFakedRelationship SocialProfileDuplicateBaseRecord = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "socialprofileid",
					Entity2Attribute = "baserecordid",
					Entity1LogicalName = "socialprofile",
					Entity2LogicalName = "duplicaterecord",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N SocialProfile_DuplicateMatchingRecord</summary>
			public static readonly XrmFakedRelationship SocialProfileDuplicateMatchingRecord = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "socialprofileid",
					Entity2Attribute = "duplicaterecordid",
					Entity1LogicalName = "socialprofile",
					Entity2LogicalName = "duplicaterecord",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N socialprofile_principalobjectattributeaccess</summary>
			public static readonly XrmFakedRelationship SocialprofilePrincipalobjectattributeaccess = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "socialprofileid",
					Entity2Attribute = "objectid",
					Entity1LogicalName = "socialprofile",
					Entity2LogicalName = "principalobjectattributeaccess",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N SocialProfile_ProcessSessions</summary>
			public static readonly XrmFakedRelationship SocialProfileProcessSessions = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "socialprofileid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "socialprofile",
					Entity2LogicalName = "processsession",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N Socialprofile_SocialActivities</summary>
			public static readonly XrmFakedRelationship SocialprofileSocialActivities = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "socialprofileid",
					Entity2Attribute = "postfromprofileid",
					Entity1LogicalName = "socialprofile",
					Entity2LogicalName = "socialactivity",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N SocialProfile_SyncErrors</summary>
			public static readonly XrmFakedRelationship SocialProfileSyncErrors = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "socialprofileid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "socialprofile",
					Entity2LogicalName = "syncerror",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

		}
		#endregion

		#region Fake
		public static SocialProfile Create()
		{
			var faker = new Faker<SocialProfile>()
			.RuleFor(e => e.Blocked, fake => fake.Random.Bool())
			.RuleFor(e => e.SocialChannel, fake => fake.PickRandom<SocialProfile.egSocialChannel>())
			.RuleFor(e => e.CreatedOn, fake => fake.Date.Soon())
			.RuleFor(e => e.Createdonbehalfbyname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Createdonbehalfbyyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.ParentCustomerType, fake => fake.Lorem.Word())
			.RuleFor(e => e.ParentCustomerType2, fake => fake.Lorem.Word())
			.RuleFor(e => e.ParentCustomerType3, fake => fake.Lorem.Word())
			.RuleFor(e => e.ExchangeRate, fake => fake.Finance.Amount())
			.RuleFor(e => e.ImportSequenceNumber, fake => fake.Random.Int())
			.RuleFor(e => e.InfluenceScore, fake => fake.Random.Double())
			.RuleFor(e => e.ModifiedOn, fake => fake.Date.Soon())
			.RuleFor(e => e.Modifiedonbehalfbyname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Modifiedonbehalfbyyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.RecordCreatedOn, fake => fake.Date.Soon())
			.RuleFor(e => e.Owneridname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Owneridtype, fake => fake.Lorem.Word())
			.RuleFor(e => e.Owneridyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.FullName, fake => fake.Lorem.Word())
			.RuleFor(e => e.ProfileLink, fake => fake.Lorem.Word())
			.RuleFor(e => e.ProfileName, fake => fake.Lorem.Word())
			.RuleFor(e => e.Id, fake => Guid.NewGuid())
			.RuleFor(e => e.Status, fake => fake.PickRandom<SocialProfile.eStatus>())
			.RuleFor(e => e.StatusReason, fake => fake.PickRandom<SocialProfile.eStatusReason>())
			.RuleFor(e => e.TimeZoneRuleVersionNumber, fake => fake.Random.Int())
			.RuleFor(e => e.Transactioncurrencyidname, fake => fake.Lorem.Word())
			.RuleFor(e => e.UniqueProfileID, fake => fake.Lorem.Word())
			.RuleFor(e => e.UTCConversionTimeZoneCode, fake => fake.Random.Int())
			.RuleFor(e => e.VersionNumber, fake => fake.Random.Int());
			return faker.Generate();
		}
		#endregion
	}
}

