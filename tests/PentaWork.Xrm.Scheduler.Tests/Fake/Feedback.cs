using Bogus;
using System;
using FakeXrmEasy;
using System.Collections.Generic;
using PentaWork.Xrm.Scheduler.Proxies.Entities;

namespace PentaWork.Xrm.Scheduler.Tests.Fake
{
	public static class FakeFeedback
	{	
		#region FakeRelationships
		public static class Relationships 
		{
			/// <summary>1:N feedback_DuplicateBaseRecord</summary>
			public static readonly XrmFakedRelationship FeedbackDuplicateBaseRecord = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "feedbackid",
					Entity2Attribute = "baserecordid",
					Entity1LogicalName = "feedback",
					Entity2LogicalName = "duplicaterecord",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N feedback_DuplicateMatchingRecord</summary>
			public static readonly XrmFakedRelationship FeedbackDuplicateMatchingRecord = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "feedbackid",
					Entity2Attribute = "duplicaterecordid",
					Entity1LogicalName = "feedback",
					Entity2LogicalName = "duplicaterecord",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N feedback_feedback</summary>
			public static readonly XrmFakedRelationship FeedbackFeedback = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "feedbackid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "feedback",
					Entity2LogicalName = "feedback",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N feedback_principalobjectattributeaccess</summary>
			public static readonly XrmFakedRelationship FeedbackPrincipalobjectattributeaccess = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "feedbackid",
					Entity2Attribute = "objectid",
					Entity1LogicalName = "feedback",
					Entity2LogicalName = "principalobjectattributeaccess",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N Feedback_SyncErrors</summary>
			public static readonly XrmFakedRelationship FeedbackSyncErrors = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "feedbackid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "feedback",
					Entity2LogicalName = "syncerror",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

		}
		#endregion

		#region Fake
		public static Feedback Create()
		{
			var faker = new Faker<Feedback>()
			.RuleFor(e => e.Closedbyname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Closedbyyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.ClosedOn, fake => fake.Date.Soon())
			.RuleFor(e => e.Comments, fake => fake.Lorem.Word())
			.RuleFor(e => e.Createdbycontactname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Createdbyname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Createdbyyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.CreatedOn, fake => fake.Date.Soon())
			.RuleFor(e => e.Createdonbehalfbycontactname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Createdonbehalfbycontactyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.Createdonbehalfbyname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Createdonbehalfbyyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.ExchangeRate, fake => fake.Finance.Amount())
			.RuleFor(e => e.Id, fake => Guid.NewGuid())
			.RuleFor(e => e.ImportSequenceNumber, fake => fake.Random.Int())
			.RuleFor(e => e.MaximumRating, fake => fake.Random.Int())
			.RuleFor(e => e.MinimumRating, fake => fake.Random.Int())
			.RuleFor(e => e.Modifiedbyname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Modifiedbyyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.ModifiedOn, fake => fake.Date.Soon())
			.RuleFor(e => e.Modifiedonbehalfbyname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Modifiedonbehalfbyyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.MsdynContextobjectidname, fake => fake.Lorem.Word())
			.RuleFor(e => e.MsdynContextobjectidtype, fake => fake.Lorem.Word())
			.RuleFor(e => e.MsdynContextobjectidyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.NormalizedRating, fake => fake.Finance.Amount())
			.RuleFor(e => e.RecordCreatedOn, fake => fake.Date.Soon())
			.RuleFor(e => e.Owneridname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Owneridtype, fake => fake.Lorem.Word())
			.RuleFor(e => e.Owneridyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.Rating, fake => fake.Random.Int())
			.RuleFor(e => e.Regardingobjectidname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Regardingobjectidyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.Regardingobjecttypecode, fake => fake.Lorem.Word())
			.RuleFor(e => e.Source, fake => fake.PickRandom<Feedback.eSource>())
			.RuleFor(e => e.Status, fake => fake.PickRandom<Feedback.eState>())
			.RuleFor(e => e.StatusReason, fake => fake.PickRandom<Feedback.eStatus>())
			.RuleFor(e => e.Title, fake => fake.Lorem.Word())
			.RuleFor(e => e.Transactioncurrencyidname, fake => fake.Lorem.Word())
			.RuleFor(e => e.VersionNumber, fake => fake.Random.Int());
			return faker.Generate();
		}
		#endregion
	}
}

