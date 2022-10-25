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
	[EntityLogicalName("resourcegroupdatasource")]
	public sealed class ResourceGroupDataSource : Entity
	{	
		public static readonly int? EntityTypeCode = 10074;
		public new const string LogicalName = "resourcegroupdatasource";
		public const string PrimaryIdAttribute = "resourcegroupdatasourceid";
		public const string PrimaryNameAttribute = "name";
	
		public ResourceGroupDataSource() : base("resourcegroupdatasource") { }

		#region Attributes
		/// <summary>
        /// name
        /// </summary>
		[DisplayName("Name")]
		[AttributeLogicalName("name")]
		public string Name
		{	
			get { return GetAttributeValue<string>("name"); }
			set
			{ 
				if(value == Name) return;
				SetAttributeValue("name", value);
			}
		}	
			
		/// <summary>
        /// resourcegroupdatasourceid
        /// </summary>
		[DisplayName("resource group data source")]
		[AttributeLogicalName("resourcegroupdatasourceid")]
		public override Guid Id
		{
			get => base.Id;
			set { base.Id = value; SetAttributeValue("resourcegroupdatasourceid", value); }
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
			/// <summary>name</summary>
			public const string Name = "name";

			/// <summary>resourcegroupdatasourceid</summary>
			public const string ResourceGroupDataSourceId = "resourcegroupdatasourceid";

		}
		#endregion

		#region Schemas
		public static class Schemas 
		{
		}
		#endregion
	}
}

