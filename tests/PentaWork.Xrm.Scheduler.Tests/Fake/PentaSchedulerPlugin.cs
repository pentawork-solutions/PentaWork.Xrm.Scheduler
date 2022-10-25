using Bogus;
using System;
using FakeXrmEasy;
using System.Collections.Generic;
using PentaWork.Xrm.Scheduler.Proxies.Entities;

namespace PentaWork.Xrm.Scheduler.Tests.Fake
{
	public static class FakePentaSchedulerPlugin
	{	
		#region FakeRelationships
		public static class Relationships 
		{
			/// <summary>1:N pw_pw_scheduler_plugin_virt_pw_schedule_ServicePlugin</summary>
			public static readonly XrmFakedRelationship PwPwSchedulerPluginVirtPwScheduleServicePlugin = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "pw_scheduler_plugin_virtid",
					Entity2Attribute = "pw_service_plugin",
					Entity1LogicalName = "pw_scheduler_plugin_virt",
					Entity2LogicalName = "pw_schedule",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

		}
		#endregion

		#region Fake
		public static PentaSchedulerPlugin Create()
		{
			var faker = new Faker<PentaSchedulerPlugin>()
			.RuleFor(e => e.Name, fake => fake.Lorem.Word())
			.RuleFor(e => e.Id, fake => Guid.NewGuid());
			return faker.Generate();
		}
		#endregion
	}
}

