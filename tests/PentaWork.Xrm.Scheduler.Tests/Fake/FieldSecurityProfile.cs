using Bogus;
using System;
using FakeXrmEasy;
using System.Collections.Generic;
using PentaWork.Xrm.Scheduler.Proxies.Entities;

namespace PentaWork.Xrm.Scheduler.Tests.Fake
{
	public static class FakeFieldSecurityProfile
	{	
		#region FakeRelationships
		public static class Relationships 
		{
			/// <summary>1:N FieldSecurityProfile_SyncErrors</summary>
			public static readonly XrmFakedRelationship FieldSecurityProfileSyncErrors = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "fieldsecurityprofileid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "fieldsecurityprofile",
					Entity2LogicalName = "syncerror",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_fieldpermission_fieldsecurityprofileid</summary>
			public static readonly XrmFakedRelationship LkFieldpermissionFieldsecurityprofileid = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "fieldsecurityprofileid",
					Entity2Attribute = "fieldsecurityprofileid",
					Entity1LogicalName = "fieldsecurityprofile",
					Entity2LogicalName = "fieldpermission",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>N:N systemuserprofiles_association</summary>
			public static readonly XrmFakedRelationship SystemuserprofilesAssociation = 
				new XrmFakedRelationship
				{
					IntersectEntity = "systemuserprofiles_association",
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "fieldsecurityprofileid",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "fieldsecurityprofile",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.ManyToMany
				};

			/// <summary>N:N teamprofiles_association</summary>
			public static readonly XrmFakedRelationship TeamprofilesAssociation = 
				new XrmFakedRelationship
				{
					IntersectEntity = "teamprofiles_association",
					Entity1Attribute = "teamid",
					Entity2Attribute = "fieldsecurityprofileid",
					Entity1LogicalName = "team",
					Entity2LogicalName = "fieldsecurityprofile",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.ManyToMany
				};

		}
		#endregion

		#region Fake
		public static FieldSecurityProfile Create()
		{
			var faker = new Faker<FieldSecurityProfile>()
			.RuleFor(e => e.ComponentState, fake => fake.PickRandom<FieldSecurityProfile.egComponentState>())
			.RuleFor(e => e.Createdbyname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Createdbyyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.CreatedOn, fake => fake.Date.Soon())
			.RuleFor(e => e.Createdonbehalfbyname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Createdonbehalfbyyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.Description, fake => fake.Lorem.Word())
			.RuleFor(e => e.Id, fake => Guid.NewGuid())
			.RuleFor(e => e.FieldSecurityProfileId2, fake => Guid.NewGuid())
			.RuleFor(e => e.IsManaged, fake => fake.Random.Bool())
			.RuleFor(e => e.Modifiedbyname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Modifiedbyyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.ModifiedOn, fake => fake.Date.Soon())
			.RuleFor(e => e.Modifiedonbehalfbyname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Modifiedonbehalfbyyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.Name, fake => fake.Lorem.Word())
			.RuleFor(e => e.Organizationidname, fake => fake.Lorem.Word())
			.RuleFor(e => e.RecordOverwriteTime, fake => fake.Date.Soon())
			.RuleFor(e => e.SolutionId, fake => Guid.NewGuid())
			.RuleFor(e => e.SolutionId2, fake => Guid.NewGuid())
			.RuleFor(e => e.Versionnumber, fake => fake.Random.Int());
			return faker.Generate();
		}
		#endregion
	}
}

