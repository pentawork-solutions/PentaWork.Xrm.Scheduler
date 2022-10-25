using System;
using System.Linq;
using System.Diagnostics;
using System.ComponentModel;
using Microsoft.Xrm.Sdk; 
using Microsoft.Xrm.Sdk.Client;
using System.Collections.Generic;

namespace PentaWork.Xrm.Scheduler.Proxies.Entities
{
	[DebuggerDisplay("{Name}")] 	
	[EntityLogicalName("pw_scheduler_plugin_virt")]
	public sealed class PentaSchedulerPlugin : Entity
	{	
		public static readonly int? EntityTypeCode = 10125;
		public new const string LogicalName = "pw_scheduler_plugin_virt";
		public const string PrimaryIdAttribute = "pw_scheduler_plugin_virtid";
		public const string PrimaryNameAttribute = "pw_name";
	
		public PentaSchedulerPlugin() : base("pw_scheduler_plugin_virt") { }

		#region Attributes
		/// <summary>
        /// pw_name
        /// </summary>
		[DisplayName("Name")]
		[AttributeLogicalName("pw_name")]
		public string Name
		{	
			get { return GetAttributeValue<string>("pw_name"); }
			set
			{ 
				if(value == Name) return;
				SetAttributeValue("pw_name", value);
			}
		}	
			
		/// <summary>
        /// pw_scheduler_plugin_virtid
        /// </summary>
		[DisplayName("Penta Scheduler Plugin")]
		[AttributeLogicalName("pw_scheduler_plugin_virtid")]
		public override Guid Id
		{
			get => base.Id;
			set { base.Id = value; SetAttributeValue("pw_scheduler_plugin_virtid", value); }
		}

							#endregion	

		#region Relations
			/// <summary>
        /// 1:N Get entities for 'pw_pw_scheduler_plugin_virt_pw_schedule_ServicePlugin'
        /// </summary>
		[RelationshipSchemaName("pw_pw_scheduler_plugin_virt_pw_schedule_ServicePlugin")]
		public IEnumerable<PentaSchedule> PwPwSchedulerPluginVirtPwScheduleServicePlugin
		{
			get { return GetRelatedEntities<PentaSchedule>("pw_pw_scheduler_plugin_virt_pw_schedule_ServicePlugin", null); }
			set { SetRelatedEntities("pw_pw_scheduler_plugin_virt_pw_schedule_ServicePlugin", null, value); }
		}
		#endregion

		#region Actions
		#endregion

		#region OptionSetEnums
		#endregion	

		#region Properties
		public static class Properties 
		{
			/// <summary>pw_name</summary>
			public const string Name = "pw_name";

			/// <summary>pw_scheduler_plugin_virtid</summary>
			public const string PentaSchedulerPluginId = "pw_scheduler_plugin_virtid";

		}
		#endregion

		#region Schemas
		public static class Schemas 
		{
			/// <summary>1:N pw_pw_scheduler_plugin_virt_pw_schedule_ServicePlugin</summary>
			public const string PwPwSchedulerPluginVirtPwScheduleServicePlugin = "pw_pw_scheduler_plugin_virt_pw_schedule_ServicePlugin";

		}
		#endregion
	}
}

