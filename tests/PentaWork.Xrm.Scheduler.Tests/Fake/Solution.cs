using Bogus;
using System;
using FakeXrmEasy;
using System.Collections.Generic;
using PentaWork.Xrm.Scheduler.Proxies.Entities;

namespace PentaWork.Xrm.Scheduler.Tests.Fake
{
	public static class FakeSolution
	{	
		#region FakeRelationships
		public static class Relationships 
		{
			/// <summary>1:N FileAttachment_Solution</summary>
			public static readonly XrmFakedRelationship FileAttachmentSolution = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "solutionid",
					Entity2Attribute = "objectid",
					Entity1LogicalName = "solution",
					Entity2LogicalName = "fileattachment",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N FK_CanvasApp_Solution</summary>
			public static readonly XrmFakedRelationship FKCanvasAppSolution = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "solutionid",
					Entity2Attribute = "solutionid",
					Entity1LogicalName = "solution",
					Entity2LogicalName = "canvasapp",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N solution_fieldpermission</summary>
			public static readonly XrmFakedRelationship SolutionFieldpermission = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "solutionid",
					Entity2Attribute = "solutionid",
					Entity1LogicalName = "solution",
					Entity2LogicalName = "fieldpermission",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N solution_fieldsecurityprofile</summary>
			public static readonly XrmFakedRelationship SolutionFieldsecurityprofile = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "solutionid",
					Entity2Attribute = "solutionid",
					Entity1LogicalName = "solution",
					Entity2LogicalName = "fieldsecurityprofile",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N solution_parent_solution</summary>
			public static readonly XrmFakedRelationship SolutionParentSolution = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "solutionid",
					Entity2Attribute = "parentsolutionid",
					Entity1LogicalName = "solution",
					Entity2LogicalName = "solution",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N solution_privilege</summary>
			public static readonly XrmFakedRelationship SolutionPrivilege = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "solutionid",
					Entity2Attribute = "solutionid",
					Entity1LogicalName = "solution",
					Entity2LogicalName = "privilege",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N solution_role</summary>
			public static readonly XrmFakedRelationship SolutionRole = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "solutionid",
					Entity2Attribute = "solutionid",
					Entity1LogicalName = "solution",
					Entity2LogicalName = "role",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N solution_solutioncomponent</summary>
			public static readonly XrmFakedRelationship SolutionSolutioncomponent = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "solutionid",
					Entity2Attribute = "solutionid",
					Entity1LogicalName = "solution",
					Entity2LogicalName = "solutioncomponent",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N Solution_SyncErrors</summary>
			public static readonly XrmFakedRelationship SolutionSyncErrors = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "solutionid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "solution",
					Entity2LogicalName = "syncerror",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>N:N package_solution</summary>
			public static readonly XrmFakedRelationship PackageSolution = 
				new XrmFakedRelationship
				{
					IntersectEntity = "package_solution",
					Entity1Attribute = "packageid",
					Entity2Attribute = "solutionid",
					Entity1LogicalName = "package",
					Entity2LogicalName = "solution",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.ManyToMany
				};

		}
		#endregion

		#region Fake
		public static Solution Create()
		{
			var faker = new Faker<Solution>()
			.RuleFor(e => e.Configurationpageidname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Createdbyname, fake => fake.Lorem.Word())
			.RuleFor(e => e.CreatedOn, fake => fake.Date.Soon())
			.RuleFor(e => e.Createdonbehalfbyname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Createdonbehalfbyyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.Description, fake => fake.Lorem.Word())
			.RuleFor(e => e.DisplayName, fake => fake.Lorem.Word())
			.RuleFor(e => e.InstalledOn, fake => fake.Date.Soon())
			.RuleFor(e => e.IsApiManagedSolution, fake => fake.Random.Bool())
			.RuleFor(e => e.IsInternalSolution, fake => fake.Random.Bool())
			.RuleFor(e => e.PackageType, fake => fake.Random.Bool())
			.RuleFor(e => e.IsVisibleOutsidePlatform, fake => fake.Random.Bool())
			.RuleFor(e => e.Modifiedbyname, fake => fake.Lorem.Word())
			.RuleFor(e => e.ModifiedOn, fake => fake.Date.Soon())
			.RuleFor(e => e.Modifiedonbehalfbyname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Modifiedonbehalfbyyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.Organizationidname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Parentsolutionidname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Pinpointassetid, fake => fake.Lorem.Word())
			.RuleFor(e => e.Pinpointpublisherid, fake => fake.Random.Int())
			.RuleFor(e => e.Pinpointsolutiondefaultlocale, fake => fake.Lorem.Word())
			.RuleFor(e => e.Pinpointsolutionid, fake => fake.Random.Int())
			.RuleFor(e => e.Publisher2, fake => fake.Lorem.Word())
			.RuleFor(e => e.Publisheridoptionvalueprefix, fake => fake.Random.Int())
			.RuleFor(e => e.Publisheridprefix, fake => fake.Lorem.Word())
			.RuleFor(e => e.Id, fake => Guid.NewGuid())
			.RuleFor(e => e.SolutionPackageVersion, fake => fake.Lorem.Word())
			.RuleFor(e => e.SolutionType, fake => fake.PickRandom<Solution.eSolutionType>())
			.RuleFor(e => e.Name, fake => fake.Lorem.Word())
			.RuleFor(e => e.UpdatedOn, fake => fake.Date.Soon())
			.RuleFor(e => e.Version, fake => fake.Lorem.Word())
			.RuleFor(e => e.Versionnumber, fake => fake.Random.Int());
			return faker.Generate();
		}
		#endregion
	}
}

