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
	[EntityLogicalName("msdyn_suggestedactivitydatasource")]
	public sealed class SuggestedActivityDataSource : Entity
	{	
		public static readonly int? EntityTypeCode = 10096;
		public new const string LogicalName = "msdyn_suggestedactivitydatasource";
		public const string PrimaryIdAttribute = "msdyn_suggestedactivitydatasourceid";
		public const string PrimaryNameAttribute = "msdyn_name";
	
		public SuggestedActivityDataSource() : base("msdyn_suggestedactivitydatasource") { }

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
        /// msdyn_suggestedactivitydatasourceid
        /// </summary>
		[DisplayName("Suggested Activity Data Source")]
		[AttributeLogicalName("msdyn_suggestedactivitydatasourceid")]
		public override Guid Id
		{
			get => base.Id;
			set { base.Id = value; SetAttributeValue("msdyn_suggestedactivitydatasourceid", value); }
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

			/// <summary>msdyn_suggestedactivitydatasourceid</summary>
			public const string SuggestedActivityDataSourceId = "msdyn_suggestedactivitydatasourceid";

		}
		#endregion

		#region Schemas
		public static class Schemas 
		{
		}
		#endregion
	}
}

