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
	[EntityLogicalName("msdyn_solutionhistorydatasource")]
	public sealed class SolutionHistoryDataSource : Entity
	{	
		public static readonly int? EntityTypeCode = 10001;
		public new const string LogicalName = "msdyn_solutionhistorydatasource";
		public const string PrimaryIdAttribute = "msdyn_solutionhistorydatasourceid";
		public const string PrimaryNameAttribute = "msdyn_name";
	
		public SolutionHistoryDataSource() : base("msdyn_solutionhistorydatasource") { }

		#region Attributes
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
			
		/// <summary>
        /// msdyn_solutionhistorydatasourceid
        /// </summary>
		[DisplayName("Solution History Data Source")]
		[AttributeLogicalName("msdyn_solutionhistorydatasourceid")]
		public override Guid Id
		{
			get => base.Id;
			set { base.Id = value; SetAttributeValue("msdyn_solutionhistorydatasourceid", value); }
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
			/// <summary>msdyn_name</summary>
			public const string Name = "msdyn_name";

			/// <summary>msdyn_solutionhistorydatasourceid</summary>
			public const string SolutionHistoryDataSourceId = "msdyn_solutionhistorydatasourceid";

		}
		#endregion

		#region Schemas
		public static class Schemas 
		{
		}
		#endregion
	}
}

