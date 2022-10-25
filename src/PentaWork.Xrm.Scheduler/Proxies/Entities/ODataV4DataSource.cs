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
	[EntityLogicalName("msdyn_odatav4ds")]
	public sealed class ODataV4DataSource : Entity
	{	
		public static readonly int? EntityTypeCode = 10027;
		public new const string LogicalName = "msdyn_odatav4ds";
		public const string PrimaryIdAttribute = "msdyn_odatav4dsid";
		public const string PrimaryNameAttribute = "msdyn_name";
	
		public ODataV4DataSource() : base("msdyn_odatav4ds") { }

		#region Attributes
		/// <summary>
        /// msdyn_description
        /// </summary>
		[DisplayName("Description")]
		[AttributeLogicalName("msdyn_description")]
		public string Description
		{	
			get { return GetAttributeValue<string>("msdyn_description"); }
			set
			{ 
				if(value == Description) return;
				SetAttributeValue("msdyn_description", value);
			}
		}	
			
		/// <summary>
        /// msdyn_isparameter10header
        /// </summary>
		[DisplayName("Parameter10 Type")]
		[AttributeLogicalName("msdyn_isparameter10header")]
		public bool? Parameter10Type
		{	
			get { return GetAttributeValue<bool?>("msdyn_isparameter10header"); }
			set
			{ 
				if(value == Parameter10Type) return;
				SetAttributeValue("msdyn_isparameter10header", value);
			}
		}	
			
		/// <summary>
        /// msdyn_isparameter1header
        /// </summary>
		[DisplayName("Parameter1 Type")]
		[AttributeLogicalName("msdyn_isparameter1header")]
		public bool? Parameter1Type
		{	
			get { return GetAttributeValue<bool?>("msdyn_isparameter1header"); }
			set
			{ 
				if(value == Parameter1Type) return;
				SetAttributeValue("msdyn_isparameter1header", value);
			}
		}	
			
		/// <summary>
        /// msdyn_isparameter2header
        /// </summary>
		[DisplayName("Parameter2 Type")]
		[AttributeLogicalName("msdyn_isparameter2header")]
		public bool? Parameter2Type
		{	
			get { return GetAttributeValue<bool?>("msdyn_isparameter2header"); }
			set
			{ 
				if(value == Parameter2Type) return;
				SetAttributeValue("msdyn_isparameter2header", value);
			}
		}	
			
		/// <summary>
        /// msdyn_isparameter3header
        /// </summary>
		[DisplayName("Parameter3 Type")]
		[AttributeLogicalName("msdyn_isparameter3header")]
		public bool? Parameter3Type
		{	
			get { return GetAttributeValue<bool?>("msdyn_isparameter3header"); }
			set
			{ 
				if(value == Parameter3Type) return;
				SetAttributeValue("msdyn_isparameter3header", value);
			}
		}	
			
		/// <summary>
        /// msdyn_isparameter4header
        /// </summary>
		[DisplayName("Parameter4 Type")]
		[AttributeLogicalName("msdyn_isparameter4header")]
		public bool? Parameter4Type
		{	
			get { return GetAttributeValue<bool?>("msdyn_isparameter4header"); }
			set
			{ 
				if(value == Parameter4Type) return;
				SetAttributeValue("msdyn_isparameter4header", value);
			}
		}	
			
		/// <summary>
        /// msdyn_isparameter5header
        /// </summary>
		[DisplayName("Parameter5 Type")]
		[AttributeLogicalName("msdyn_isparameter5header")]
		public bool? Parameter5Type
		{	
			get { return GetAttributeValue<bool?>("msdyn_isparameter5header"); }
			set
			{ 
				if(value == Parameter5Type) return;
				SetAttributeValue("msdyn_isparameter5header", value);
			}
		}	
			
		/// <summary>
        /// msdyn_isparameter6header
        /// </summary>
		[DisplayName("Parameter6 Type")]
		[AttributeLogicalName("msdyn_isparameter6header")]
		public bool? Parameter6Type
		{	
			get { return GetAttributeValue<bool?>("msdyn_isparameter6header"); }
			set
			{ 
				if(value == Parameter6Type) return;
				SetAttributeValue("msdyn_isparameter6header", value);
			}
		}	
			
		/// <summary>
        /// msdyn_isparameter7header
        /// </summary>
		[DisplayName("Parameter7 Type")]
		[AttributeLogicalName("msdyn_isparameter7header")]
		public bool? Parameter7Type
		{	
			get { return GetAttributeValue<bool?>("msdyn_isparameter7header"); }
			set
			{ 
				if(value == Parameter7Type) return;
				SetAttributeValue("msdyn_isparameter7header", value);
			}
		}	
			
		/// <summary>
        /// msdyn_isparameter8header
        /// </summary>
		[DisplayName("Parameter8 Type")]
		[AttributeLogicalName("msdyn_isparameter8header")]
		public bool? Parameter8Type
		{	
			get { return GetAttributeValue<bool?>("msdyn_isparameter8header"); }
			set
			{ 
				if(value == Parameter8Type) return;
				SetAttributeValue("msdyn_isparameter8header", value);
			}
		}	
			
		/// <summary>
        /// msdyn_isparameter9header
        /// </summary>
		[DisplayName("Parameter9 Type")]
		[AttributeLogicalName("msdyn_isparameter9header")]
		public bool? Parameter9Type
		{	
			get { return GetAttributeValue<bool?>("msdyn_isparameter9header"); }
			set
			{ 
				if(value == Parameter9Type) return;
				SetAttributeValue("msdyn_isparameter9header", value);
			}
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
			
		/// <summary>
        /// msdyn_odatav4dsid
        /// </summary>
		[DisplayName("OData v4 Data Source")]
		[AttributeLogicalName("msdyn_odatav4dsid")]
		public override Guid Id
		{
			get => base.Id;
			set { base.Id = value; SetAttributeValue("msdyn_odatav4dsid", value); }
		}

							/// <summary>
        /// msdyn_paginationmode
        /// </summary>
		[DisplayName("Pagination Mode")]
		[AttributeLogicalName("msdyn_paginationmode")]
		public bool? PaginationMode
		{	
			get { return GetAttributeValue<bool?>("msdyn_paginationmode"); }
			set
			{ 
				if(value == PaginationMode) return;
				SetAttributeValue("msdyn_paginationmode", value);
			}
		}	
			
		/// <summary>
        /// msdyn_paginationtype
        /// </summary>
		[DisplayName("Pagination Mode")]
		[AttributeLogicalName("msdyn_paginationtype")]
		public ePaginationMode? PaginationMode2
		{	
			get 
			{ 
				var optionSetValue = GetAttributeValue<OptionSetValue>("msdyn_paginationtype");
				if (optionSetValue != null) return (ePaginationMode)optionSetValue.Value;
				else return null;
			}
			set 
			{ 
				if(value == PaginationMode2) return;

				OptionSetValue optionSetValue = null;
				if(value != null) optionSetValue = new OptionSetValue((int)value);
				SetAttributeValue("msdyn_paginationtype", optionSetValue); 
			}
		}

		/// <summary>
        /// msdyn_parameter10name
        /// </summary>
		[DisplayName("parameter10name")]
		[AttributeLogicalName("msdyn_parameter10name")]
		public string Parameter10name
		{	
			get { return GetAttributeValue<string>("msdyn_parameter10name"); }
			set
			{ 
				if(value == Parameter10name) return;
				SetAttributeValue("msdyn_parameter10name", value);
			}
		}	
			
		/// <summary>
        /// msdyn_parameter10value
        /// </summary>
		[DisplayName("parameter10value")]
		[AttributeLogicalName("msdyn_parameter10value")]
		public string Parameter10value
		{	
			get { return GetAttributeValue<string>("msdyn_parameter10value"); }
			set
			{ 
				if(value == Parameter10value) return;
				SetAttributeValue("msdyn_parameter10value", value);
			}
		}	
			
		/// <summary>
        /// msdyn_parameter1name
        /// </summary>
		[DisplayName("parameter1name")]
		[AttributeLogicalName("msdyn_parameter1name")]
		public string Parameter1name
		{	
			get { return GetAttributeValue<string>("msdyn_parameter1name"); }
			set
			{ 
				if(value == Parameter1name) return;
				SetAttributeValue("msdyn_parameter1name", value);
			}
		}	
			
		/// <summary>
        /// msdyn_parameter1value
        /// </summary>
		[DisplayName("parameter1value")]
		[AttributeLogicalName("msdyn_parameter1value")]
		public string Parameter1value
		{	
			get { return GetAttributeValue<string>("msdyn_parameter1value"); }
			set
			{ 
				if(value == Parameter1value) return;
				SetAttributeValue("msdyn_parameter1value", value);
			}
		}	
			
		/// <summary>
        /// msdyn_parameter2name
        /// </summary>
		[DisplayName("parameter2name")]
		[AttributeLogicalName("msdyn_parameter2name")]
		public string Parameter2name
		{	
			get { return GetAttributeValue<string>("msdyn_parameter2name"); }
			set
			{ 
				if(value == Parameter2name) return;
				SetAttributeValue("msdyn_parameter2name", value);
			}
		}	
			
		/// <summary>
        /// msdyn_parameter2value
        /// </summary>
		[DisplayName("parameter2value")]
		[AttributeLogicalName("msdyn_parameter2value")]
		public string Parameter2value
		{	
			get { return GetAttributeValue<string>("msdyn_parameter2value"); }
			set
			{ 
				if(value == Parameter2value) return;
				SetAttributeValue("msdyn_parameter2value", value);
			}
		}	
			
		/// <summary>
        /// msdyn_parameter3name
        /// </summary>
		[DisplayName("parameter3name")]
		[AttributeLogicalName("msdyn_parameter3name")]
		public string Parameter3name
		{	
			get { return GetAttributeValue<string>("msdyn_parameter3name"); }
			set
			{ 
				if(value == Parameter3name) return;
				SetAttributeValue("msdyn_parameter3name", value);
			}
		}	
			
		/// <summary>
        /// msdyn_parameter3value
        /// </summary>
		[DisplayName("parameter3value")]
		[AttributeLogicalName("msdyn_parameter3value")]
		public string Parameter3value
		{	
			get { return GetAttributeValue<string>("msdyn_parameter3value"); }
			set
			{ 
				if(value == Parameter3value) return;
				SetAttributeValue("msdyn_parameter3value", value);
			}
		}	
			
		/// <summary>
        /// msdyn_parameter4name
        /// </summary>
		[DisplayName("parameter4name")]
		[AttributeLogicalName("msdyn_parameter4name")]
		public string Parameter4name
		{	
			get { return GetAttributeValue<string>("msdyn_parameter4name"); }
			set
			{ 
				if(value == Parameter4name) return;
				SetAttributeValue("msdyn_parameter4name", value);
			}
		}	
			
		/// <summary>
        /// msdyn_parameter4value
        /// </summary>
		[DisplayName("parameter4value")]
		[AttributeLogicalName("msdyn_parameter4value")]
		public string Parameter4value
		{	
			get { return GetAttributeValue<string>("msdyn_parameter4value"); }
			set
			{ 
				if(value == Parameter4value) return;
				SetAttributeValue("msdyn_parameter4value", value);
			}
		}	
			
		/// <summary>
        /// msdyn_parameter5name
        /// </summary>
		[DisplayName("parameter5name")]
		[AttributeLogicalName("msdyn_parameter5name")]
		public string Parameter5name
		{	
			get { return GetAttributeValue<string>("msdyn_parameter5name"); }
			set
			{ 
				if(value == Parameter5name) return;
				SetAttributeValue("msdyn_parameter5name", value);
			}
		}	
			
		/// <summary>
        /// msdyn_parameter5value
        /// </summary>
		[DisplayName("parameter5value")]
		[AttributeLogicalName("msdyn_parameter5value")]
		public string Parameter5value
		{	
			get { return GetAttributeValue<string>("msdyn_parameter5value"); }
			set
			{ 
				if(value == Parameter5value) return;
				SetAttributeValue("msdyn_parameter5value", value);
			}
		}	
			
		/// <summary>
        /// msdyn_parameter6name
        /// </summary>
		[DisplayName("parameter6name")]
		[AttributeLogicalName("msdyn_parameter6name")]
		public string Parameter6name
		{	
			get { return GetAttributeValue<string>("msdyn_parameter6name"); }
			set
			{ 
				if(value == Parameter6name) return;
				SetAttributeValue("msdyn_parameter6name", value);
			}
		}	
			
		/// <summary>
        /// msdyn_parameter6value
        /// </summary>
		[DisplayName("parameter6value")]
		[AttributeLogicalName("msdyn_parameter6value")]
		public string Parameter6value
		{	
			get { return GetAttributeValue<string>("msdyn_parameter6value"); }
			set
			{ 
				if(value == Parameter6value) return;
				SetAttributeValue("msdyn_parameter6value", value);
			}
		}	
			
		/// <summary>
        /// msdyn_parameter7name
        /// </summary>
		[DisplayName("parameter7name")]
		[AttributeLogicalName("msdyn_parameter7name")]
		public string Parameter7name
		{	
			get { return GetAttributeValue<string>("msdyn_parameter7name"); }
			set
			{ 
				if(value == Parameter7name) return;
				SetAttributeValue("msdyn_parameter7name", value);
			}
		}	
			
		/// <summary>
        /// msdyn_parameter7value
        /// </summary>
		[DisplayName("parameter7value")]
		[AttributeLogicalName("msdyn_parameter7value")]
		public string Parameter7value
		{	
			get { return GetAttributeValue<string>("msdyn_parameter7value"); }
			set
			{ 
				if(value == Parameter7value) return;
				SetAttributeValue("msdyn_parameter7value", value);
			}
		}	
			
		/// <summary>
        /// msdyn_parameter8name
        /// </summary>
		[DisplayName("parameter8name")]
		[AttributeLogicalName("msdyn_parameter8name")]
		public string Parameter8name
		{	
			get { return GetAttributeValue<string>("msdyn_parameter8name"); }
			set
			{ 
				if(value == Parameter8name) return;
				SetAttributeValue("msdyn_parameter8name", value);
			}
		}	
			
		/// <summary>
        /// msdyn_parameter8value
        /// </summary>
		[DisplayName("parameter8value")]
		[AttributeLogicalName("msdyn_parameter8value")]
		public string Parameter8value
		{	
			get { return GetAttributeValue<string>("msdyn_parameter8value"); }
			set
			{ 
				if(value == Parameter8value) return;
				SetAttributeValue("msdyn_parameter8value", value);
			}
		}	
			
		/// <summary>
        /// msdyn_parameter9name
        /// </summary>
		[DisplayName("parameter9name")]
		[AttributeLogicalName("msdyn_parameter9name")]
		public string Parameter9name
		{	
			get { return GetAttributeValue<string>("msdyn_parameter9name"); }
			set
			{ 
				if(value == Parameter9name) return;
				SetAttributeValue("msdyn_parameter9name", value);
			}
		}	
			
		/// <summary>
        /// msdyn_parameter9value
        /// </summary>
		[DisplayName("parameter9value")]
		[AttributeLogicalName("msdyn_parameter9value")]
		public string Parameter9value
		{	
			get { return GetAttributeValue<string>("msdyn_parameter9value"); }
			set
			{ 
				if(value == Parameter9value) return;
				SetAttributeValue("msdyn_parameter9value", value);
			}
		}	
			
		/// <summary>
        /// msdyn_returninlinecount
        /// </summary>
		[DisplayName("Return Inline Count")]
		[AttributeLogicalName("msdyn_returninlinecount")]
		public bool? ReturnInlineCount
		{	
			get { return GetAttributeValue<bool?>("msdyn_returninlinecount"); }
			set
			{ 
				if(value == ReturnInlineCount) return;
				SetAttributeValue("msdyn_returninlinecount", value);
			}
		}	
			
		/// <summary>
        /// msdyn_timeout
        /// </summary>
		[DisplayName("Timeout")]
		[AttributeLogicalName("msdyn_timeout")]
		public int? Timeout
		{	
			get { return GetAttributeValue<int?>("msdyn_timeout"); }
			set
			{ 
				if(value == Timeout) return;
				SetAttributeValue("msdyn_timeout", value);
			}
		}	
			
		/// <summary>
        /// msdyn_uri
        /// </summary>
		[DisplayName("URL")]
		[AttributeLogicalName("msdyn_uri")]
		public string URL
		{	
			get { return GetAttributeValue<string>("msdyn_uri"); }
			set
			{ 
				if(value == URL) return;
				SetAttributeValue("msdyn_uri", value);
			}
		}	
			
		#endregion	

		#region Relations
			#endregion

		#region Actions
		#endregion

		#region OptionSetEnums
		public enum ePaginationMode
		{	
		
			[Label("Client-side Paging")]
			[Description(@"")]
			ClientsidePaging = 0, 
		
			[Label("Server-side Paging")]
			[Description(@"")]
			ServersidePaging = 1, 
		}
		
		#endregion	

		#region Properties
		public static class Properties 
		{
			/// <summary>msdyn_description</summary>
			public const string Description = "msdyn_description";

			/// <summary>msdyn_isparameter10header</summary>
			public const string Parameter10Type = "msdyn_isparameter10header";

			/// <summary>msdyn_isparameter1header</summary>
			public const string Parameter1Type = "msdyn_isparameter1header";

			/// <summary>msdyn_isparameter2header</summary>
			public const string Parameter2Type = "msdyn_isparameter2header";

			/// <summary>msdyn_isparameter3header</summary>
			public const string Parameter3Type = "msdyn_isparameter3header";

			/// <summary>msdyn_isparameter4header</summary>
			public const string Parameter4Type = "msdyn_isparameter4header";

			/// <summary>msdyn_isparameter5header</summary>
			public const string Parameter5Type = "msdyn_isparameter5header";

			/// <summary>msdyn_isparameter6header</summary>
			public const string Parameter6Type = "msdyn_isparameter6header";

			/// <summary>msdyn_isparameter7header</summary>
			public const string Parameter7Type = "msdyn_isparameter7header";

			/// <summary>msdyn_isparameter8header</summary>
			public const string Parameter8Type = "msdyn_isparameter8header";

			/// <summary>msdyn_isparameter9header</summary>
			public const string Parameter9Type = "msdyn_isparameter9header";

			/// <summary>msdyn_name</summary>
			public const string Name = "msdyn_name";

			/// <summary>msdyn_odatav4dsid</summary>
			public const string ODataV4DataSourceId = "msdyn_odatav4dsid";

			/// <summary>msdyn_paginationmode</summary>
			public const string PaginationMode = "msdyn_paginationmode";

			/// <summary>msdyn_paginationtype</summary>
			public const string PaginationMode2 = "msdyn_paginationtype";

			/// <summary>msdyn_parameter10name</summary>
			public const string Parameter10name = "msdyn_parameter10name";

			/// <summary>msdyn_parameter10value</summary>
			public const string Parameter10value = "msdyn_parameter10value";

			/// <summary>msdyn_parameter1name</summary>
			public const string Parameter1name = "msdyn_parameter1name";

			/// <summary>msdyn_parameter1value</summary>
			public const string Parameter1value = "msdyn_parameter1value";

			/// <summary>msdyn_parameter2name</summary>
			public const string Parameter2name = "msdyn_parameter2name";

			/// <summary>msdyn_parameter2value</summary>
			public const string Parameter2value = "msdyn_parameter2value";

			/// <summary>msdyn_parameter3name</summary>
			public const string Parameter3name = "msdyn_parameter3name";

			/// <summary>msdyn_parameter3value</summary>
			public const string Parameter3value = "msdyn_parameter3value";

			/// <summary>msdyn_parameter4name</summary>
			public const string Parameter4name = "msdyn_parameter4name";

			/// <summary>msdyn_parameter4value</summary>
			public const string Parameter4value = "msdyn_parameter4value";

			/// <summary>msdyn_parameter5name</summary>
			public const string Parameter5name = "msdyn_parameter5name";

			/// <summary>msdyn_parameter5value</summary>
			public const string Parameter5value = "msdyn_parameter5value";

			/// <summary>msdyn_parameter6name</summary>
			public const string Parameter6name = "msdyn_parameter6name";

			/// <summary>msdyn_parameter6value</summary>
			public const string Parameter6value = "msdyn_parameter6value";

			/// <summary>msdyn_parameter7name</summary>
			public const string Parameter7name = "msdyn_parameter7name";

			/// <summary>msdyn_parameter7value</summary>
			public const string Parameter7value = "msdyn_parameter7value";

			/// <summary>msdyn_parameter8name</summary>
			public const string Parameter8name = "msdyn_parameter8name";

			/// <summary>msdyn_parameter8value</summary>
			public const string Parameter8value = "msdyn_parameter8value";

			/// <summary>msdyn_parameter9name</summary>
			public const string Parameter9name = "msdyn_parameter9name";

			/// <summary>msdyn_parameter9value</summary>
			public const string Parameter9value = "msdyn_parameter9value";

			/// <summary>msdyn_returninlinecount</summary>
			public const string ReturnInlineCount = "msdyn_returninlinecount";

			/// <summary>msdyn_timeout</summary>
			public const string Timeout = "msdyn_timeout";

			/// <summary>msdyn_uri</summary>
			public const string URL = "msdyn_uri";

		}
		#endregion

		#region Schemas
		public static class Schemas 
		{
		}
		#endregion
	}
}

