using Bogus;
using System;
using FakeXrmEasy;
using System.Collections.Generic;
using PentaWork.Xrm.Scheduler.Proxies.Entities;

namespace PentaWork.Xrm.Scheduler.Tests.Fake
{
	public static class FakeSLAItem
	{	
		#region FakeRelationships
		public static class Relationships 
		{
			/// <summary>1:N SLAItem_SyncErrors</summary>
			public static readonly XrmFakedRelationship SLAItemSyncErrors = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "slaitemid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "slaitem",
					Entity2LogicalName = "syncerror",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

		}
		#endregion

		#region Fake
		public static SLAItem Create()
		{
			var faker = new Faker<SLAItem>()
			.RuleFor(e => e.ActionFlowUniqueName, fake => fake.Lorem.Word())
			.RuleFor(e => e.ActionURL, fake => fake.Lorem.Word())
			.RuleFor(e => e.AllowPauseAndResume, fake => fake.Random.Bool())
			.RuleFor(e => e.ApplicableEntity, fake => fake.Lorem.Word())
			.RuleFor(e => e.ApplicableWhenXml, fake => fake.Lorem.Word())
			.RuleFor(e => e.Businesshoursidname, fake => fake.Lorem.Word())
			.RuleFor(e => e.ChangedAttributeList, fake => fake.Lorem.Word())
			.RuleFor(e => e.ComponentState, fake => fake.PickRandom<SLAItem.egComponentState>())
			.RuleFor(e => e.Createdbyname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Createdbyyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.CreatedOn, fake => fake.Date.Soon())
			.RuleFor(e => e.Createdonbehalfbyname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Createdonbehalfbyyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.Description, fake => fake.Lorem.Word())
			.RuleFor(e => e.ExchangeRate, fake => fake.Finance.Amount())
			.RuleFor(e => e.FailureAfter, fake => fake.Random.Int())
			.RuleFor(e => e.IsManaged, fake => fake.Random.Bool())
			.RuleFor(e => e.Modifiedbyname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Modifiedbyyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.ModifiedOn, fake => fake.Date.Soon())
			.RuleFor(e => e.Modifiedonbehalfbyname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Modifiedonbehalfbyyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.Name, fake => fake.Lorem.Word())
			.RuleFor(e => e.RecordOverwriteTime, fake => fake.Date.Soon())
			.RuleFor(e => e.Owneridtype, fake => fake.Lorem.Word())
			.RuleFor(e => e.RelatedCaseField, fake => fake.Lorem.Word())
			.RuleFor(e => e.Sequence, fake => fake.Random.Int())
			.RuleFor(e => e.Slaidname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Id, fake => Guid.NewGuid())
			.RuleFor(e => e.UniqueId, fake => Guid.NewGuid())
			.RuleFor(e => e.SolutionId, fake => Guid.NewGuid())
			.RuleFor(e => e.SuccessConditionsXml, fake => fake.Lorem.Word())
			.RuleFor(e => e.SolutionId2, fake => Guid.NewGuid())
			.RuleFor(e => e.Transactioncurrencyidname, fake => fake.Lorem.Word())
			.RuleFor(e => e.VersionNumber, fake => fake.Random.Int())
			.RuleFor(e => e.WarnAfter, fake => fake.Random.Int())
			.RuleFor(e => e.Workflowidname, fake => fake.Lorem.Word());
			return faker.Generate();
		}
		#endregion
	}
}

