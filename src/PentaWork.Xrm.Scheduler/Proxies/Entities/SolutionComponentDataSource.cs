using System;
using System.Linq;
using System.Diagnostics;
using System.ComponentModel;
using Microsoft.Xrm.Sdk; 
using Microsoft.Xrm.Sdk.Client;
using System.Collections.Generic;

namespace PentaWork.Xrm.Scheduler.Proxies.Entities
{
	[DebuggerDisplay("{MsdynName}")] 	
	[EntityLogicalName("msdyn_solutioncomponentdatasource")]
	public sealed class SolutionComponentDataSource : Entity
	{	
		public static readonly int? EntityTypeCode = 10012;
		public new const string LogicalName = "msdyn_solutioncomponentdatasource";
		public const string PrimaryIdAttribute = "msdyn_solutioncomponentdatasourceid";
		public const string PrimaryNameAttribute = "msdyn_name";
	
		public SolutionComponentDataSource() : base("msdyn_solutioncomponentdatasource") { }

		#region Attributes
		/// <summary>
        /// msdyn_name
        /// </summary>
		[DisplayName("msdyn_name")]
		[AttributeLogicalName("msdyn_name")]
		public string MsdynName
		{	
			get { return GetAttributeValue<string>("msdyn_name"); }
			set
			{ 
				if(value == MsdynName) return;
				SetAttributeValue("msdyn_name", value);
			}
		}	
			
		/// <summary>
        /// msdyn_solutioncomponentdatasourceid
        /// </summary>
		[DisplayName("Solution Component Data Source")]
		[AttributeLogicalName("msdyn_solutioncomponentdatasourceid")]
		public override Guid Id
		{
			get => base.Id;
			set { base.Id = value; SetAttributeValue("msdyn_solutioncomponentdatasourceid", value); }
		}

							/// <summary>
        /// organizationid
        /// </summary>
		[DisplayName("Organization Id")]
		[AttributeLogicalName("organizationid")]
		public Guid OrganizationId
		{	
			get { return GetAttributeValue<Guid>("organizationid"); }
			set
			{ 
				if(value == OrganizationId) return;
				SetAttributeValue("organizationid", value);
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
			/// <summary>msdyn_name</summary>
			public const string MsdynName = "msdyn_name";

			/// <summary>msdyn_solutioncomponentdatasourceid</summary>
			public const string SolutionComponentDataSourceId = "msdyn_solutioncomponentdatasourceid";

			/// <summary>organizationid</summary>
			public const string OrganizationId = "organizationid";

		}
		#endregion

		#region Schemas
		public static class Schemas 
		{
		}
		#endregion
	}
}

