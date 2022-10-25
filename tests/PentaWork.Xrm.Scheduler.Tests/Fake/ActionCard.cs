using Bogus;
using System;
using FakeXrmEasy;
using System.Collections.Generic;
using PentaWork.Xrm.Scheduler.Proxies.Entities;

namespace PentaWork.Xrm.Scheduler.Tests.Fake
{
	public static class FakeActionCard
	{	
		#region FakeRelationships
		public static class Relationships 
		{
			/// <summary>1:N ActionCardUserState_ActionCard</summary>
			public static readonly XrmFakedRelationship ActionCardUserStateActionCard = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "actioncardid",
					Entity2Attribute = "actioncardid",
					Entity1LogicalName = "actioncard",
					Entity2LogicalName = "actioncarduserstate",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

		}
		#endregion

		#region Fake
		public static ActionCard Create()
		{
			var faker = new Faker<ActionCard>()
			.RuleFor(e => e.Id, fake => Guid.NewGuid())
			.RuleFor(e => e.CardTypeENUM, fake => fake.Random.Int())
			.RuleFor(e => e.Cardtypeidname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Createdbyname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Createdbyyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.CreatedOn, fake => fake.Date.Soon())
			.RuleFor(e => e.Createdonbehalfbyname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Createdonbehalfbyyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.DataAssociatedWithCardCommandbarActions, fake => fake.Lorem.Word())
			.RuleFor(e => e.CardDescription, fake => fake.Lorem.Word())
			.RuleFor(e => e.ExchangeRate, fake => fake.Finance.Amount())
			.RuleFor(e => e.ExpiryDate, fake => fake.Date.Soon())
			.RuleFor(e => e.ImportSequenceNumber, fake => fake.Random.Int())
			.RuleFor(e => e.Modifiedbyname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Modifiedbyyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.ModifiedOn, fake => fake.Date.Soon())
			.RuleFor(e => e.Modifiedonbehalfbyname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Modifiedonbehalfbyyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.Actioncardregardingid, fake => fake.Lorem.Word())
			.RuleFor(e => e.Regardingobjectid, fake => fake.Lorem.Word())
			.RuleFor(e => e.Regardingobjectlogicalname, fake => fake.Lorem.Word())
			.RuleFor(e => e.RecordCreatedOn, fake => fake.Date.Soon())
			.RuleFor(e => e.Owneridname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Owneridtype, fake => fake.Lorem.Word())
			.RuleFor(e => e.Owneridyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.ParentRegardingObjectIdData, fake => fake.Lorem.Word())
			.RuleFor(e => e.ParentRegardingObjectTypeCode, fake => fake.Lorem.Word())
			.RuleFor(e => e.Priority, fake => fake.Random.Int())
			.RuleFor(e => e.RecordIdName, fake => fake.Lorem.Word())
			.RuleFor(e => e.RecordIdObjectTypeCode, fake => fake.Lorem.Word())
			.RuleFor(e => e.RecordIdObjectTypeCode2, fake => fake.Random.Int())
			.RuleFor(e => e.DataAssociatedConstructingTitleAndBody, fake => fake.Lorem.Word())
			.RuleFor(e => e.Regardingobjectidname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Regardingobjecttypecode, fake => fake.Lorem.Word())
			.RuleFor(e => e.ActionCardSource, fake => fake.PickRandom<ActionCard.eActionCardSource>())
			.RuleFor(e => e.StartDate, fake => fake.Date.Soon())
			.RuleFor(e => e.ActionCardState, fake => fake.PickRandom<ActionCard.eActionCardState>())
			.RuleFor(e => e.Title, fake => fake.Lorem.Word())
			.RuleFor(e => e.Transactioncurrencyidname, fake => fake.Lorem.Word())
			.RuleFor(e => e.VersionNumber, fake => fake.Random.Int())
			.RuleFor(e => e.VisibiliyStatusOfActionCard, fake => fake.Random.Bool());
			return faker.Generate();
		}
		#endregion
	}
}

