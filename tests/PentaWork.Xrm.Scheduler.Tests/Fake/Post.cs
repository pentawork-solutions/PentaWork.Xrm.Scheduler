using Bogus;
using System;
using FakeXrmEasy;
using System.Collections.Generic;
using PentaWork.Xrm.Scheduler.Proxies.Entities;

namespace PentaWork.Xrm.Scheduler.Tests.Fake
{
	public static class FakePost
	{	
		#region FakeRelationships
		public static class Relationships 
		{
			/// <summary>1:N post_AsyncOperations</summary>
			public static readonly XrmFakedRelationship PostAsyncOperations = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "postid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "post",
					Entity2LogicalName = "asyncoperation",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N post_BulkDeleteFailures</summary>
			public static readonly XrmFakedRelationship PostBulkDeleteFailures = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "postid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "post",
					Entity2LogicalName = "bulkdeletefailure",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N Post_Comments</summary>
			public static readonly XrmFakedRelationship PostComments = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "postid",
					Entity2Attribute = "postid",
					Entity1LogicalName = "post",
					Entity2LogicalName = "postcomment",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N Post_Likes</summary>
			public static readonly XrmFakedRelationship PostLikes = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "postid",
					Entity2Attribute = "postid",
					Entity1LogicalName = "post",
					Entity2LogicalName = "postlike",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

		}
		#endregion

		#region Fake
		public static Post Create()
		{
			var faker = new Faker<Post>()
			.RuleFor(e => e.Createdbyname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Createdbyyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.CreatedOn, fake => fake.Date.Soon())
			.RuleFor(e => e.Createdonbehalfbyname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Createdonbehalfbyyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.Modifiedbyname, fake => fake.Lorem.Word())
			.RuleFor(e => e.ModifiedOn, fake => fake.Date.Soon())
			.RuleFor(e => e.Modifiedonbehalfbyname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Modifiedonbehalfbyyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.Organizationidname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Id, fake => Guid.NewGuid())
			.RuleFor(e => e.PostToYammer, fake => fake.Random.Bool())
			.RuleFor(e => e.Regardingobjectidname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Regardingobjectidyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.RegardingObjectOwnerIdType, fake => fake.Lorem.Word())
			.RuleFor(e => e.RegardingObjectTypeCode, fake => fake.Lorem.Word())
			.RuleFor(e => e.Source, fake => fake.PickRandom<Post.ePostType>())
			.RuleFor(e => e.Text, fake => fake.Lorem.Word())
			.RuleFor(e => e.TimeZoneRuleVersionNumber, fake => fake.Random.Int())
			.RuleFor(e => e.Type, fake => fake.PickRandom<Post.eType>())
			.RuleFor(e => e.UTCConversionTimeZoneCode, fake => fake.Random.Int())
			.RuleFor(e => e.YammerPostState, fake => fake.Random.Int())
			.RuleFor(e => e.YammerRetryCount, fake => fake.Random.Int());
			return faker.Generate();
		}
		#endregion
	}
}

