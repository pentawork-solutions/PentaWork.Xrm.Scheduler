using Bogus;
using System;
using FakeXrmEasy;
using System.Collections.Generic;
using PentaWork.Xrm.Scheduler.Proxies.Entities;

namespace PentaWork.Xrm.Scheduler.Tests.Fake
{
	public static class FakeSolutionComponentSummary
	{	
		#region FakeRelationships
		public static class Relationships 
		{
		}
		#endregion

		#region Fake
		public static SolutionComponentSummary Create()
		{
			var faker = new Faker<SolutionComponentSummary>()
			.RuleFor(e => e.CanvasAppUniqueId, fake => fake.Lorem.Word())
			.RuleFor(e => e.ComponentLogicalName, fake => fake.Lorem.Word())
			.RuleFor(e => e.MsdynComponenttype, fake => fake.Finance.Amount())
			.RuleFor(e => e.ComponentTypeName, fake => fake.Lorem.Word())
			.RuleFor(e => e.ConnectorInternalId, fake => fake.Lorem.Word())
			.RuleFor(e => e.MsdynCreatedon, fake => fake.Lorem.Word())
			.RuleFor(e => e.MsdynCulture, fake => fake.Lorem.Word())
			.RuleFor(e => e.MsdynDeployment, fake => fake.Lorem.Word())
			.RuleFor(e => e.MsdynDescription, fake => fake.Lorem.Word())
			.RuleFor(e => e.MsdynDisplayname, fake => fake.Lorem.Word())
			.RuleFor(e => e.MsdynEventhandler, fake => fake.Lorem.Word())
			.RuleFor(e => e.MsdynExecutionorder, fake => fake.Lorem.Word())
			.RuleFor(e => e.MsdynExecutionstage, fake => fake.Lorem.Word())
			.RuleFor(e => e.FieldSecurity, fake => fake.Lorem.Word())
			.RuleFor(e => e.FieldType, fake => fake.Lorem.Word())
			.RuleFor(e => e.MsdynIsappaware, fake => fake.Lorem.Word())
			.RuleFor(e => e.AppAwareName, fake => fake.Lorem.Word())
			.RuleFor(e => e.MsdynIsauditenabled, fake => fake.Lorem.Word())
			.RuleFor(e => e.AuditName, fake => fake.Lorem.Word())
			.RuleFor(e => e.MsdynIscustom, fake => fake.Lorem.Word())
			.RuleFor(e => e.MsdynIscustomizable, fake => fake.Lorem.Word())
			.RuleFor(e => e.CustomizableName, fake => fake.Lorem.Word())
			.RuleFor(e => e.IsCustomName, fake => fake.Lorem.Word())
			.RuleFor(e => e.Default, fake => fake.Lorem.Word())
			.RuleFor(e => e.DefaultName, fake => fake.Lorem.Word())
			.RuleFor(e => e.MsdynIsmanaged, fake => fake.Lorem.Word())
			.RuleFor(e => e.ManagedName, fake => fake.Lorem.Word())
			.RuleFor(e => e.MsdynIsolationmode, fake => fake.Lorem.Word())
			.RuleFor(e => e.MsdynIstableenabled, fake => fake.Lorem.Word())
			.RuleFor(e => e.LogicalCollectionName, fake => fake.Lorem.Word())
			.RuleFor(e => e.MsdynModifiedon, fake => fake.Lorem.Word())
			.RuleFor(e => e.MsdynName, fake => fake.Lorem.Word())
			.RuleFor(e => e.MsdynObjectid, fake => fake.Lorem.Word())
			.RuleFor(e => e.MsdynObjecttypecode, fake => fake.Lorem.Word())
			.RuleFor(e => e.MsdynOwner, fake => fake.Lorem.Word())
			.RuleFor(e => e.OwningBusinessUnit, fake => fake.Lorem.Word())
			.RuleFor(e => e.PrimaryEntityName, fake => fake.Lorem.Word())
			.RuleFor(e => e.MsdynPublickeytoken, fake => fake.Lorem.Word())
			.RuleFor(e => e.RelatedEntity, fake => fake.Lorem.Word())
			.RuleFor(e => e.RelatedEntityAttributeName, fake => fake.Lorem.Word())
			.RuleFor(e => e.MsdynSchemaname, fake => fake.Lorem.Word())
			.RuleFor(e => e.MsdynSdkmessagename, fake => fake.Lorem.Word())
			.RuleFor(e => e.Id, fake => Guid.NewGuid())
			.RuleFor(e => e.MsdynSolutionid, fake => fake.Lorem.Word())
			.RuleFor(e => e.MsdynStatus, fake => fake.Lorem.Word())
			.RuleFor(e => e.StatusName, fake => fake.Lorem.Word())
			.RuleFor(e => e.MsdynSubtype, fake => fake.Lorem.Word())
			.RuleFor(e => e.MsdynSynctoexternalsearchindex, fake => fake.Lorem.Word())
			.RuleFor(e => e.MsdynTotal, fake => fake.Finance.Amount())
			.RuleFor(e => e.MsdynTypename, fake => fake.Lorem.Word())
			.RuleFor(e => e.MsdynUniquename, fake => fake.Lorem.Word())
			.RuleFor(e => e.MsdynVersion, fake => fake.Lorem.Word())
			.RuleFor(e => e.MsdynWorkflowcategory, fake => fake.Lorem.Word())
			.RuleFor(e => e.WorkflowCategoryName, fake => fake.Lorem.Word())
			.RuleFor(e => e.WorkflowIdUnique, fake => fake.Lorem.Word())
			.RuleFor(e => e.OrganizationId, fake => Guid.NewGuid());
			return faker.Generate();
		}
		#endregion
	}
}

