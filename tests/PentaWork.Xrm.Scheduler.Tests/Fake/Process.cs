using Bogus;
using System;
using FakeXrmEasy;
using System.Collections.Generic;
using PentaWork.Xrm.Scheduler.Proxies.Entities;

namespace PentaWork.Xrm.Scheduler.Tests.Fake
{
	public static class FakeProcess
	{	
		#region FakeRelationships
		public static class Relationships 
		{
			/// <summary>1:N lk_asyncoperation_workflowactivationid</summary>
			public static readonly XrmFakedRelationship LkAsyncoperationWorkflowactivationid = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "workflowid",
					Entity2Attribute = "workflowactivationid",
					Entity1LogicalName = "workflow",
					Entity2LogicalName = "asyncoperation",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N pw_workflow_pw_schedule_action</summary>
			public static readonly XrmFakedRelationship PwWorkflowPwScheduleAction = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "workflowid",
					Entity2Attribute = "pw_action",
					Entity1LogicalName = "workflow",
					Entity2LogicalName = "pw_schedule",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N pw_workflow_pw_schedule_global_action</summary>
			public static readonly XrmFakedRelationship PwWorkflowPwScheduleGlobalAction = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "workflowid",
					Entity2Attribute = "pw_global_action",
					Entity1LogicalName = "workflow",
					Entity2LogicalName = "pw_schedule",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N pw_workflow_pw_schedule_workflow</summary>
			public static readonly XrmFakedRelationship PwWorkflowPwScheduleWorkflow = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "workflowid",
					Entity2Attribute = "pw_workflow",
					Entity1LogicalName = "workflow",
					Entity2LogicalName = "pw_schedule",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N workflow_active_workflow</summary>
			public static readonly XrmFakedRelationship WorkflowActiveWorkflow = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "workflowid",
					Entity2Attribute = "activeworkflowid",
					Entity1LogicalName = "workflow",
					Entity2LogicalName = "workflow",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N Workflow_licenseentitledby</summary>
			public static readonly XrmFakedRelationship WorkflowLicenseentitledby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "workflowid",
					Entity2Attribute = "licenseentitledby",
					Entity1LogicalName = "workflow",
					Entity2LogicalName = "workflow",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N workflow_parent_workflow</summary>
			public static readonly XrmFakedRelationship WorkflowParentWorkflow = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "workflowid",
					Entity2Attribute = "parentworkflowid",
					Entity1LogicalName = "workflow",
					Entity2LogicalName = "workflow",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

		}
		#endregion

		#region Fake
		public static Process Create()
		{
			var faker = new Faker<Process>()
			.RuleFor(e => e.Activeworkflowidname, fake => fake.Lorem.Word())
			.RuleFor(e => e.DeleteJobOnCompletion, fake => fake.Random.Bool())
			.RuleFor(e => e.BillingContext, fake => fake.Lorem.Word())
			.RuleFor(e => e.BusinessProcessType, fake => fake.PickRandom<Process.eBusinessProcessType>())
			.RuleFor(e => e.Category, fake => fake.PickRandom<Process.eCategory>())
			.RuleFor(e => e.ClientData, fake => fake.Lorem.Word())
			.RuleFor(e => e.ClientDataIsCompressed, fake => fake.Random.Bool())
			.RuleFor(e => e.ComponentState, fake => fake.PickRandom<Process.egComponentState>())
			.RuleFor(e => e.ConnectionReferences, fake => fake.Lorem.Word())
			.RuleFor(e => e.Createdbyname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Createdbyyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.CreatedOn, fake => fake.Date.Soon())
			.RuleFor(e => e.Createdonbehalfbyname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Createdonbehalfbyyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.CreateMetadata, fake => fake.Lorem.Word())
			.RuleFor(e => e.CreateStage, fake => fake.PickRandom<Process.egWorkflowStage>())
			.RuleFor(e => e.Definition, fake => fake.Lorem.Word())
			.RuleFor(e => e.DeleteStage, fake => fake.PickRandom<Process.egWorkflowStage>())
			.RuleFor(e => e.Dependencies, fake => fake.Lorem.Word())
			.RuleFor(e => e.Description, fake => fake.Lorem.Word())
			.RuleFor(e => e.DesktopFlowModules, fake => fake.Lorem.Word())
			.RuleFor(e => e.DynamicsSolutionContext, fake => fake.Lorem.Word())
			.RuleFor(e => e.EntityimageTimestamp, fake => fake.Random.Int())
			.RuleFor(e => e.EntityimageUrl, fake => fake.Lorem.Word())
			.RuleFor(e => e.EntityImageId, fake => Guid.NewGuid())
			.RuleFor(e => e.FormId, fake => Guid.NewGuid())
			.RuleFor(e => e.InputParameters, fake => fake.Lorem.Word())
			.RuleFor(e => e.Inputs, fake => fake.Lorem.Word())
			.RuleFor(e => e.IntroducedVersion, fake => fake.Lorem.Word())
			.RuleFor(e => e.IsCRMProcess, fake => fake.Random.Bool())
			.RuleFor(e => e.IsManaged, fake => fake.Random.Bool())
			.RuleFor(e => e.IsTransacted, fake => fake.Random.Bool())
			.RuleFor(e => e.Language, fake => fake.Random.Int())
			.RuleFor(e => e.Licenseentitledbyname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Metadata, fake => fake.Lorem.Word())
			.RuleFor(e => e.Mode, fake => fake.PickRandom<Process.eMode>())
			.RuleFor(e => e.Modifiedbyname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Modifiedbyyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.ModifiedOn, fake => fake.Date.Soon())
			.RuleFor(e => e.Modifiedonbehalfbyname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Modifiedonbehalfbyyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.ModifyMetadata, fake => fake.Lorem.Word())
			.RuleFor(e => e.ProcessName, fake => fake.Lorem.Word())
			.RuleFor(e => e.RunAsOnDemand, fake => fake.Random.Bool())
			.RuleFor(e => e.Outputs, fake => fake.Lorem.Word())
			.RuleFor(e => e.RecordOverwriteTime, fake => fake.Date.Soon())
			.RuleFor(e => e.Owneridname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Owneridtype, fake => fake.Lorem.Word())
			.RuleFor(e => e.Owneridyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.Owningbusinessunitname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Parentworkflowidname, fake => fake.Lorem.Word())
			.RuleFor(e => e.PlanVerified, fake => fake.Random.Bool())
			.RuleFor(e => e.PrimaryEntity, fake => fake.Lorem.Word())
			.RuleFor(e => e.ProcessOrder, fake => fake.Random.Int())
			.RuleFor(e => e.RoleAssignmentForProcess, fake => fake.Lorem.Word())
			.RuleFor(e => e.ProcessTriggerFormId, fake => Guid.NewGuid())
			.RuleFor(e => e.ProcessTriggerScope, fake => fake.PickRandom<Process.eProcesstriggerScope>())
			.RuleFor(e => e.Rank, fake => fake.Random.Int())
			.RuleFor(e => e.RendererType, fake => fake.Lorem.Word())
			.RuleFor(e => e.ResourceContainer, fake => fake.Lorem.Word())
			.RuleFor(e => e.ResourceId, fake => Guid.NewGuid())
			.RuleFor(e => e.RunAsUser, fake => fake.PickRandom<Process.egExecutingUser>())
			.RuleFor(e => e.SchemaVersion, fake => fake.Lorem.Word())
			.RuleFor(e => e.Scope, fake => fake.PickRandom<Process.eScope>())
			.RuleFor(e => e.SolutionId, fake => Guid.NewGuid())
			.RuleFor(e => e.Status, fake => fake.PickRandom<Process.eStatus>())
			.RuleFor(e => e.StatusReason, fake => fake.PickRandom<Process.eStatusReason>())
			.RuleFor(e => e.IsChildProcess, fake => fake.Random.Bool())
			.RuleFor(e => e.SolutionId2, fake => Guid.NewGuid())
			.RuleFor(e => e.Suspensionreasondetails, fake => fake.Lorem.Word())
			.RuleFor(e => e.LogUponFailure, fake => fake.Random.Bool())
			.RuleFor(e => e.ThrottlingBehaviorType, fake => fake.PickRandom<Process.eThrottlingBehaviorType>())
			.RuleFor(e => e.TriggerOnCreate, fake => fake.Random.Bool())
			.RuleFor(e => e.TriggerOnDelete, fake => fake.Random.Bool())
			.RuleFor(e => e.TriggerOnUpdateAttributeList, fake => fake.Lorem.Word())
			.RuleFor(e => e.TrustedAccess, fake => fake.Random.Bool())
			.RuleFor(e => e.Type, fake => fake.PickRandom<Process.eType>())
			.RuleFor(e => e.UIData, fake => fake.Lorem.Word())
			.RuleFor(e => e.DesktopFlowType, fake => fake.PickRandom<Process.eUIFlowType>())
			.RuleFor(e => e.UniqueName, fake => fake.Lorem.Word())
			.RuleFor(e => e.UpdateStage, fake => fake.PickRandom<Process.egWorkflowStage>())
			.RuleFor(e => e.Versionnumber, fake => fake.Random.Int())
			.RuleFor(e => e.Id, fake => Guid.NewGuid())
			.RuleFor(e => e.WorkflowiduniqueId, fake => Guid.NewGuid())
			.RuleFor(e => e.Xaml, fake => fake.Lorem.Word());
			return faker.Generate();
		}
		#endregion
	}
}

