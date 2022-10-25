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
	[EntityLogicalName("msdyn_suggestedcontactsdatasource")]
	public sealed class SuggestedContactsDataSource : Entity
	{	
		public static readonly int? EntityTypeCode = 10098;
		public new const string LogicalName = "msdyn_suggestedcontactsdatasource";
		public const string PrimaryIdAttribute = "msdyn_suggestedcontactsdatasourceid";
		public const string PrimaryNameAttribute = "msdyn_name";
	
		public SuggestedContactsDataSource() : base("msdyn_suggestedcontactsdatasource") { }

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
        /// msdyn_suggestedcontactsdatasourceid
        /// </summary>
		[DisplayName("Suggested contacts data source")]
		[AttributeLogicalName("msdyn_suggestedcontactsdatasourceid")]
		public override Guid Id
		{
			get => base.Id;
			set { base.Id = value; SetAttributeValue("msdyn_suggestedcontactsdatasourceid", value); }
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

			/// <summary>msdyn_suggestedcontactsdatasourceid</summary>
			public const string SuggestedContactsDataSourceId = "msdyn_suggestedcontactsdatasourceid";

		}
		#endregion

		#region Schemas
		public static class Schemas 
		{
		}
		#endregion
	}
}

