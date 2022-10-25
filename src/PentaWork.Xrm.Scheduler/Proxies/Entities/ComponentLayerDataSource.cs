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
	[EntityLogicalName("msdyn_componentlayerdatasource")]
	public sealed class ComponentLayerDataSource : Entity
	{	
		public static readonly int? EntityTypeCode = 10006;
		public new const string LogicalName = "msdyn_componentlayerdatasource";
		public const string PrimaryIdAttribute = "msdyn_componentlayerdatasourceid";
		public const string PrimaryNameAttribute = "msdyn_name";
	
		public ComponentLayerDataSource() : base("msdyn_componentlayerdatasource") { }

		#region Attributes
		/// <summary>
        /// msdyn_componentlayerdatasourceid
        /// </summary>
		[DisplayName("Component Layer Data Source")]
		[AttributeLogicalName("msdyn_componentlayerdatasourceid")]
		public override Guid Id
		{
			get => base.Id;
			set { base.Id = value; SetAttributeValue("msdyn_componentlayerdatasourceid", value); }
		}

							/// <summary>
        /// msdyn_name
        /// </summary>
		[DisplayName("Name")]
		[AttributeLogicalName("msdyn_name")]
		public string Name
		{	
			get { return GetAttributeValue<string>("msdyn_name"); }
			set
			{ 
				if(value == Name) return;
				SetAttributeValue("msdyn_name", value);
			}
		}	
			
		#endregion	

		#region Relations
			#endregion

		#region Actions
		#endregion

		#region OptionSetEnums
		#endregion	

		#region Properties
		public static class Properties 
		{
			/// <summary>msdyn_componentlayerdatasourceid</summary>
			public const string ComponentLayerDataSourceId = "msdyn_componentlayerdatasourceid";

			/// <summary>msdyn_name</summary>
			public const string Name = "msdyn_name";

		}
		#endregion

		#region Schemas
		public static class Schemas 
		{
		}
		#endregion
	}
}

