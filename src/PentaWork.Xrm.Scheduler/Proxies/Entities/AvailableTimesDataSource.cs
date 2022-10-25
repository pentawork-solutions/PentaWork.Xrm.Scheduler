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
	[EntityLogicalName("availabletimesdatasource")]
	public sealed class AvailableTimesDataSource : Entity
	{	
		public static readonly int? EntityTypeCode = 10073;
		public new const string LogicalName = "availabletimesdatasource";
		public const string PrimaryIdAttribute = "availabletimesdatasourceid";
		public const string PrimaryNameAttribute = "name";
	
		public AvailableTimesDataSource() : base("availabletimesdatasource") { }

		#region Attributes
		/// <summary>
        /// availabletimesdatasourceid
        /// </summary>
		[DisplayName("Available Times Data Source")]
		[AttributeLogicalName("availabletimesdatasourceid")]
		public override Guid Id
		{
			get => base.Id;
			set { base.Id = value; SetAttributeValue("availabletimesdatasourceid", value); }
		}

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
			/// <summary>availabletimesdatasourceid</summary>
			public const string AvailableTimesDataSourceId = "availabletimesdatasourceid";

			/// <summary>name</summary>
			public const string Name = "name";

		}
		#endregion

		#region Schemas
		public static class Schemas 
		{
		}
		#endregion
	}
}

