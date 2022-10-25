using Bogus;
using System;
using FakeXrmEasy;
using System.Collections.Generic;
using PentaWork.Xrm.Scheduler.Proxies.Entities;

namespace PentaWork.Xrm.Scheduler.Tests.Fake
{
	public static class FakeSLAKPIInstance
	{	
		#region FakeRelationships
		public static class Relationships 
		{
			/// <summary>1:N slakpiinstance_incident_firstresponsebykpi</summary>
			public static readonly XrmFakedRelationship SlakpiinstanceIncidentFirstresponsebykpi = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "slakpiinstanceid",
					Entity2Attribute = "firstresponsebykpiid",
					Entity1LogicalName = "slakpiinstance",
					Entity2LogicalName = "incident",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N slakpiinstance_incident_resolvebykpi</summary>
			public static readonly XrmFakedRelationship SlakpiinstanceIncidentResolvebykpi = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "slakpiinstanceid",
					Entity2Attribute = "resolvebykpiid",
					Entity1LogicalName = "slakpiinstance",
					Entity2LogicalName = "incident",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N SLAKPIInstance_SyncErrors</summary>
			public static readonly XrmFakedRelationship SLAKPIInstanceSyncErrors = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "slakpiinstanceid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "slakpiinstance",
					Entity2LogicalName = "syncerror",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

		}
		#endregion

		#region Fake
		public static SLAKPIInstance Create()
		{
			var faker = new Faker<SLAKPIInstance>()
			.RuleFor(e => e.ApplicableFromValue, fake => fake.Date.Soon())
			.RuleFor(e => e.ComputedFailureTime, fake => fake.Date.Soon())
			.RuleFor(e => e.ComputedWarningTime, fake => fake.Date.Soon())
			.RuleFor(e => e.Createdbyname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Createdbyyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.CreatedOn, fake => fake.Date.Soon())
			.RuleFor(e => e.Createdonbehalfbyname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Createdonbehalfbyyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.Description, fake => fake.Lorem.Word())
			.RuleFor(e => e.ElapsedTime, fake => fake.Random.Int())
			.RuleFor(e => e.ExchangeRate, fake => fake.Finance.Amount())
			.RuleFor(e => e.FailureTime, fake => fake.Date.Soon())
			.RuleFor(e => e.LastResumeTime, fake => fake.Date.Soon())
			.RuleFor(e => e.Modifiedbyname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Modifiedbyyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.ModifiedOn, fake => fake.Date.Soon())
			.RuleFor(e => e.Modifiedonbehalfbyname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Modifiedonbehalfbyyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.Name, fake => fake.Lorem.Word())
			.RuleFor(e => e.Owneridname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Owneridtype, fake => fake.Lorem.Word())
			.RuleFor(e => e.Owneridyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.PausedOn, fake => fake.Date.Soon())
			.RuleFor(e => e.RegardingID, fake => fake.Lorem.Word())
			.RuleFor(e => e.RegardingName, fake => fake.Lorem.Word())
			.RuleFor(e => e.Regardingname, fake => fake.Lorem.Word())
			.RuleFor(e => e.RegardingObjectTypeCode, fake => fake.Lorem.Word())
			.RuleFor(e => e.RegardingYomiName, fake => fake.Lorem.Word())
			.RuleFor(e => e.Id, fake => Guid.NewGuid())
			.RuleFor(e => e.Status, fake => fake.PickRandom<SLAKPIInstance.eSLAKPIInstanceType>())
			.RuleFor(e => e.SucceededOn, fake => fake.Date.Soon())
			.RuleFor(e => e.SuccessCheckedAt, fake => fake.Date.Soon())
			.RuleFor(e => e.TerminalStateReached, fake => fake.Random.Bool())
			.RuleFor(e => e.TerminalStateTime, fake => fake.Date.Soon())
			.RuleFor(e => e.Transactioncurrencyidname, fake => fake.Lorem.Word())
			.RuleFor(e => e.VersionNumber, fake => fake.Random.Int())
			.RuleFor(e => e.WarningTime, fake => fake.Date.Soon())
			.RuleFor(e => e.WarningTimeReached, fake => fake.PickRandom<SLAKPIInstance.eWarningTimeReached>());
			return faker.Generate();
		}
		#endregion
	}
}

