using Bogus;
using System;
using FakeXrmEasy;
using System.Collections.Generic;
using PentaWork.Xrm.Scheduler.Proxies.Entities;

namespace PentaWork.Xrm.Scheduler.Tests.Fake
{
	public static class FakeServiceEndpoint
	{	
		#region FakeRelationships
		public static class Relationships 
		{
			/// <summary>1:N serviceendpoint_sdkmessageprocessingstep</summary>
			public static readonly XrmFakedRelationship ServiceendpointSdkmessageprocessingstep = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "serviceendpointid",
					Entity2Attribute = "eventhandler",
					Entity1LogicalName = "serviceendpoint",
					Entity2LogicalName = "sdkmessageprocessingstep",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

		}
		#endregion

		#region Fake
		public static ServiceEndpoint Create()
		{
			var faker = new Faker<ServiceEndpoint>()
			.RuleFor(e => e.SpecifiesModeOfAuthenticationWithSB, fake => fake.PickRandom<ServiceEndpoint.eAuthenticationTypeForServiceBus>())
			.RuleFor(e => e.AuthenticationValue, fake => fake.Lorem.Word())
			.RuleFor(e => e.ComponentState, fake => fake.PickRandom<ServiceEndpoint.egComponentState>())
			.RuleFor(e => e.ConnectionMode, fake => fake.PickRandom<ServiceEndpoint.eConnectionMode>())
			.RuleFor(e => e.Contract, fake => fake.PickRandom<ServiceEndpoint.eContract>())
			.RuleFor(e => e.CreatedOn, fake => fake.Date.Soon())
			.RuleFor(e => e.Createdonbehalfbyname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Createdonbehalfbyyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.Description, fake => fake.Lorem.Word())
			.RuleFor(e => e.IntroducedVersion, fake => fake.Lorem.Word())
			.RuleFor(e => e.Isauthvalueset, fake => fake.Random.Bool())
			.RuleFor(e => e.State, fake => fake.Random.Bool())
			.RuleFor(e => e.Issaskeyset, fake => fake.Random.Bool())
			.RuleFor(e => e.Issastokenset, fake => fake.Random.Bool())
			.RuleFor(e => e.ContentTypeOfTheMessage, fake => fake.PickRandom<ServiceEndpoint.eMessageFormat>())
			.RuleFor(e => e.ModifiedOn, fake => fake.Date.Soon())
			.RuleFor(e => e.Modifiedonbehalfbyname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Modifiedonbehalfbyyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.Name, fake => fake.Lorem.Word())
			.RuleFor(e => e.NamespaceAddress, fake => fake.Lorem.Word())
			.RuleFor(e => e.FormatOfServiceBusNamespace, fake => fake.PickRandom<ServiceEndpoint.eFormatForServiceBusNamespace>())
			.RuleFor(e => e.RecordOverwriteTime, fake => fake.Date.Soon())
			.RuleFor(e => e.Path, fake => fake.Lorem.Word())
			.RuleFor(e => e.SharedAccessKey, fake => fake.Lorem.Word())
			.RuleFor(e => e.SharedAccessKeyName, fake => fake.Lorem.Word())
			.RuleFor(e => e.SharedAccessToken, fake => fake.Lorem.Word())
			.RuleFor(e => e.Id, fake => Guid.NewGuid())
			.RuleFor(e => e.ServiceendpointiduniqueId, fake => Guid.NewGuid())
			.RuleFor(e => e.SolutionId, fake => Guid.NewGuid())
			.RuleFor(e => e.ServiceNamespace, fake => fake.Lorem.Word())
			.RuleFor(e => e.SolutionId2, fake => Guid.NewGuid())
			.RuleFor(e => e.UrlAddress, fake => fake.Lorem.Word())
			.RuleFor(e => e.UserClaim, fake => fake.PickRandom<ServiceEndpoint.eUserClaim>());
			return faker.Generate();
		}
		#endregion
	}
}

