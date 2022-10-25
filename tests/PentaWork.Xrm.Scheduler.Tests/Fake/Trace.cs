using Bogus;
using System;
using FakeXrmEasy;
using System.Collections.Generic;
using PentaWork.Xrm.Scheduler.Proxies.Entities;

namespace PentaWork.Xrm.Scheduler.Tests.Fake
{
	public static class FakeTrace
	{	
		#region FakeRelationships
		public static class Relationships 
		{
			/// <summary>1:N tracelog_parent_tracelog</summary>
			public static readonly XrmFakedRelationship TracelogParentTracelog = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "tracelogid",
					Entity2Attribute = "parenttracelogid",
					Entity1LogicalName = "tracelog",
					Entity2LogicalName = "tracelog",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

		}
		#endregion

		#region Fake
		public static Trace Create()
		{
			var faker = new Faker<Trace>()
			.RuleFor(e => e.TraceCanBeDeletedFlag, fake => fake.Random.Bool())
			.RuleFor(e => e.CollationLevel, fake => fake.Random.Int())
			.RuleFor(e => e.Createdbyname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Createdbyyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.CreatedOn, fake => fake.Date.Soon())
			.RuleFor(e => e.Createdonbehalfbyname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Createdonbehalfbyyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.Errordetails, fake => fake.Lorem.Word())
			.RuleFor(e => e.TraceErrorDetails, fake => fake.Lorem.Word())
			.RuleFor(e => e.IsUniqueTrace, fake => fake.Random.Bool())
			.RuleFor(e => e.Level, fake => fake.PickRandom<Trace.eLevel>())
			.RuleFor(e => e.Machinename, fake => fake.Lorem.Word())
			.RuleFor(e => e.Modifiedbyname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Modifiedbyyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.LastUpdateOn, fake => fake.Date.Soon())
			.RuleFor(e => e.Modifiedonbehalfbyname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Modifiedonbehalfbyyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.Organizationidname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Regardingobjectidname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Regardingobjectidyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.OwnerType, fake => fake.Lorem.Word())
			.RuleFor(e => e.RegardingObjectType, fake => fake.Lorem.Word())
			.RuleFor(e => e.Text, fake => fake.Lorem.Word())
			.RuleFor(e => e.TimeZoneRuleVersionNumber, fake => fake.Random.Int())
			.RuleFor(e => e.TraceActionsXML, fake => fake.Lorem.Word())
			.RuleFor(e => e.ErrorCode, fake => fake.Random.Int())
			.RuleFor(e => e.TraceDetailXML, fake => fake.Lorem.Word())
			.RuleFor(e => e.Id, fake => Guid.NewGuid())
			.RuleFor(e => e.TraceParameterHash, fake => fake.Random.Int())
			.RuleFor(e => e.TraceParameterXML, fake => fake.Lorem.Word())
			.RuleFor(e => e.TraceStatus, fake => fake.Random.Bool())
			.RuleFor(e => e.UTCConversionTimeZoneCode, fake => fake.Random.Int());
			return faker.Generate();
		}
		#endregion
	}
}

