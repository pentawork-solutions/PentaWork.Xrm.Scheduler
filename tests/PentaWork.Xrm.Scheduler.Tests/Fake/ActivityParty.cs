using Bogus;
using System;
using FakeXrmEasy;
using System.Collections.Generic;
using PentaWork.Xrm.Scheduler.Proxies.Entities;

namespace PentaWork.Xrm.Scheduler.Tests.Fake
{
	public static class FakeActivityParty
	{	
		#region FakeRelationships
		public static class Relationships 
		{
			/// <summary>1:N ActivityParty_SyncErrors</summary>
			public static readonly XrmFakedRelationship ActivityPartySyncErrors = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "activitypartyid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "activityparty",
					Entity2LogicalName = "syncerror",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

		}
		#endregion

		#region Fake
		public static ActivityParty Create()
		{
			var faker = new Faker<ActivityParty>()
			.RuleFor(e => e.Id, fake => Guid.NewGuid())
			.RuleFor(e => e.Address, fake => fake.Lorem.Word())
			.RuleFor(e => e.EmailColumnNumberOfParty, fake => fake.Random.Int())
			.RuleFor(e => e.DoNotAllowEmails, fake => fake.Random.Bool())
			.RuleFor(e => e.DoNotAllowFaxes, fake => fake.Random.Bool())
			.RuleFor(e => e.DoNotAllowPhoneCalls, fake => fake.Random.Bool())
			.RuleFor(e => e.DoNotAllowPostalMails, fake => fake.Random.Bool())
			.RuleFor(e => e.Effort, fake => fake.Random.Double())
			.RuleFor(e => e.ExchangeEntry, fake => fake.Lorem.Word())
			.RuleFor(e => e.AppointmentType, fake => fake.PickRandom<ActivityParty.eAppointmentType>())
			.RuleFor(e => e.IsPartyDeleted, fake => fake.Random.Bool())
			.RuleFor(e => e.Owneridtype, fake => fake.Lorem.Word())
			.RuleFor(e => e.OwningbusinessunitId, fake => Guid.NewGuid())
			.RuleFor(e => e.OwninguserId, fake => Guid.NewGuid())
			.RuleFor(e => e.ParticipationType, fake => fake.PickRandom<ActivityParty.eParticipationType>())
			.RuleFor(e => e.Partyidname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Partyobjecttypecode, fake => fake.Lorem.Word())
			.RuleFor(e => e.Resourcespecidname, fake => fake.Lorem.Word())
			.RuleFor(e => e.ScheduledEnd, fake => fake.Date.Soon())
			.RuleFor(e => e.ScheduledStart, fake => fake.Date.Soon())
			.RuleFor(e => e.Versionnumber, fake => fake.Random.Int());
			return faker.Generate();
		}
		#endregion
	}
}

