using Bogus;
using System;
using FakeXrmEasy;
using System.Collections.Generic;
using PentaWork.Xrm.Scheduler.Proxies.Entities;

namespace PentaWork.Xrm.Scheduler.Tests.Fake
{
	public static class FakeSystemForm
	{	
		#region FakeRelationships
		public static class Relationships 
		{
			/// <summary>1:N form_ancestor_form</summary>
			public static readonly XrmFakedRelationship FormAncestorForm = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "formid",
					Entity2Attribute = "ancestorformid",
					Entity1LogicalName = "systemform",
					Entity2LogicalName = "systemform",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N processtrigger_systemform</summary>
			public static readonly XrmFakedRelationship ProcesstriggerSystemform = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "formid",
					Entity2Attribute = "formid",
					Entity1LogicalName = "systemform",
					Entity2LogicalName = "processtrigger",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N SystemForm_AsyncOperations</summary>
			public static readonly XrmFakedRelationship SystemFormAsyncOperations = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "formid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "systemform",
					Entity2LogicalName = "asyncoperation",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N SystemForm_BulkDeleteFailures</summary>
			public static readonly XrmFakedRelationship SystemFormBulkDeleteFailures = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "formid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "systemform",
					Entity2LogicalName = "bulkdeletefailure",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

		}
		#endregion

		#region Fake
		public static SystemForm Create()
		{
			var faker = new Faker<SystemForm>()
			.RuleFor(e => e.Ancestorformidname, fake => fake.Lorem.Word())
			.RuleFor(e => e.ComponentState, fake => fake.PickRandom<SystemForm.egComponentState>())
			.RuleFor(e => e.Description, fake => fake.Lorem.Word())
			.RuleFor(e => e.FormState, fake => fake.PickRandom<SystemForm.eFormState>())
			.RuleFor(e => e.Id, fake => Guid.NewGuid())
			.RuleFor(e => e.FormiduniqueId, fake => Guid.NewGuid())
			.RuleFor(e => e.Formjson, fake => fake.Lorem.Word())
			.RuleFor(e => e.AIRRefreshed, fake => fake.PickRandom<SystemForm.eRefreshedLayout>())
			.RuleFor(e => e.Formxml, fake => fake.Lorem.Word())
			.RuleFor(e => e.Formxmlmanaged, fake => fake.Lorem.Word())
			.RuleFor(e => e.IntroducedVersion, fake => fake.Lorem.Word())
			.RuleFor(e => e.Refreshed, fake => fake.Random.Bool())
			.RuleFor(e => e.DefaultForm, fake => fake.Random.Bool())
			.RuleFor(e => e.IsDesktopEnabled, fake => fake.Random.Bool())
			.RuleFor(e => e.State, fake => fake.Random.Bool())
			.RuleFor(e => e.IsTabletEnabled, fake => fake.Random.Bool())
			.RuleFor(e => e.Name, fake => fake.Lorem.Word())
			.RuleFor(e => e.EntityName, fake => fake.Lorem.Word())
			.RuleFor(e => e.Organizationidname, fake => fake.Lorem.Word())
			.RuleFor(e => e.RecordOverwriteTime, fake => fake.Date.Soon())
			.RuleFor(e => e.PublishedOn, fake => fake.Date.Soon())
			.RuleFor(e => e.SolutionId, fake => Guid.NewGuid())
			.RuleFor(e => e.SolutionId2, fake => Guid.NewGuid())
			.RuleFor(e => e.FormType, fake => fake.PickRandom<SystemForm.eType>())
			.RuleFor(e => e.UniqueName, fake => fake.Lorem.Word())
			.RuleFor(e => e.Version, fake => fake.Random.Int())
			.RuleFor(e => e.Versionnumber, fake => fake.Random.Int());
			return faker.Generate();
		}
		#endregion
	}
}

