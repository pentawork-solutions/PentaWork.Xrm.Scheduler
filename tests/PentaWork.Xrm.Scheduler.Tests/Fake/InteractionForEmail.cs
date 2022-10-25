using Bogus;
using System;
using FakeXrmEasy;
using System.Collections.Generic;
using PentaWork.Xrm.Scheduler.Proxies.Entities;

namespace PentaWork.Xrm.Scheduler.Tests.Fake
{
	public static class FakeInteractionForEmail
	{	
		#region FakeRelationships
		public static class Relationships 
		{
			/// <summary>1:N interactionforemail_ActivityPointers</summary>
			public static readonly XrmFakedRelationship InteractionforemailActivityPointers = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "interactionforemailid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "interactionforemail",
					Entity2LogicalName = "activitypointer",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N interactionforemail_AsyncOperations</summary>
			public static readonly XrmFakedRelationship InteractionforemailAsyncOperations = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "interactionforemailid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "interactionforemail",
					Entity2LogicalName = "asyncoperation",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N interactionforemail_BulkOperations</summary>
			public static readonly XrmFakedRelationship InteractionforemailBulkOperations = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "interactionforemailid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "interactionforemail",
					Entity2LogicalName = "bulkoperation",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N interactionforemail_CampaignResponses</summary>
			public static readonly XrmFakedRelationship InteractionforemailCampaignResponses = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "interactionforemailid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "interactionforemail",
					Entity2LogicalName = "campaignresponse",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N interactionforemail_IncidentResolutions</summary>
			public static readonly XrmFakedRelationship InteractionforemailIncidentResolutions = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "interactionforemailid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "interactionforemail",
					Entity2LogicalName = "incidentresolution",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N interactionforemail_OpportunityCloses</summary>
			public static readonly XrmFakedRelationship InteractionforemailOpportunityCloses = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "interactionforemailid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "interactionforemail",
					Entity2LogicalName = "opportunityclose",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N interactionforemail_OrderCloses</summary>
			public static readonly XrmFakedRelationship InteractionforemailOrderCloses = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "interactionforemailid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "interactionforemail",
					Entity2LogicalName = "orderclose",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N interactionforemail_QuoteCloses</summary>
			public static readonly XrmFakedRelationship InteractionforemailQuoteCloses = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "interactionforemailid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "interactionforemail",
					Entity2LogicalName = "quoteclose",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N interactionforemail_ServiceAppointments</summary>
			public static readonly XrmFakedRelationship InteractionforemailServiceAppointments = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "interactionforemailid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "interactionforemail",
					Entity2LogicalName = "serviceappointment",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

		}
		#endregion

		#region Fake
		public static InteractionForEmail Create()
		{
			var faker = new Faker<InteractionForEmail>()
			.RuleFor(e => e.Createdbyname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Createdbyyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.CreatedOn, fake => fake.Date.Soon())
			.RuleFor(e => e.Createdonbehalfbyname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Createdonbehalfbyyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.EmailActivityId, fake => Guid.NewGuid())
			.RuleFor(e => e.EmailInteractionComponentRelatedText, fake => fake.Lorem.Word())
			.RuleFor(e => e.EmailActivityId2, fake => Guid.NewGuid())
			.RuleFor(e => e.InteractionDateAndTimeOfTheAnEmail, fake => fake.Date.Soon())
			.RuleFor(e => e.ExchangeRate, fake => fake.Finance.Amount())
			.RuleFor(e => e.ImportSequenceNumber, fake => fake.Random.Int())
			.RuleFor(e => e.EmailInteractionComponentRelatedText2, fake => fake.Lorem.Word())
			.RuleFor(e => e.Id, fake => Guid.NewGuid())
			.RuleFor(e => e.LocationForAnInteraction, fake => fake.Lorem.Word())
			.RuleFor(e => e.InteractionPartyId, fake => Guid.NewGuid())
			.RuleFor(e => e.InteractionPartyTypeCode, fake => fake.Random.Int())
			.RuleFor(e => e.NameWhoRepliedToEmailIfInteractionIsReply, fake => fake.Lorem.Word())
			.RuleFor(e => e.InteractionReplyId, fake => fake.Lorem.Word())
			.RuleFor(e => e.InteractionType, fake => fake.PickRandom<InteractionForEmail.eInteractionType>())
			.RuleFor(e => e.UserAgentForAnInteraction, fake => fake.Lorem.Word())
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
			.RuleFor(e => e.Status, fake => fake.PickRandom<InteractionForEmail.eStatus>())
			.RuleFor(e => e.StatusReason, fake => fake.PickRandom<InteractionForEmail.eStatusReason>())
			.RuleFor(e => e.TimeZoneRuleVersionNumber, fake => fake.Random.Int())
			.RuleFor(e => e.Transactioncurrencyidname, fake => fake.Lorem.Word())
			.RuleFor(e => e.UTCConversionTimeZoneCode, fake => fake.Random.Int())
			.RuleFor(e => e.Versionnumber, fake => fake.Random.Int());
			return faker.Generate();
		}
		#endregion
	}
}

