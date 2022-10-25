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
	[EntityLogicalName("msdyn_componentlayer")]
	public sealed class ComponentLayer : Entity
	{	
		public static readonly int? EntityTypeCode = 10005;
		public new const string LogicalName = "msdyn_componentlayer";
		public const string PrimaryIdAttribute = "msdyn_componentlayerid";
		public const string PrimaryNameAttribute = "msdyn_name";
	
		public ComponentLayer() : base("msdyn_componentlayer") { }

		#region Attributes
		/// <summary>
        /// msdyn_changes
        /// </summary>
		[DisplayName("Changes")]
		[AttributeLogicalName("msdyn_changes")]
		public string Changes
		{	
			get { return GetAttributeValue<string>("msdyn_changes"); }
			set
			{ 
				if(value == Changes) return;
				SetAttributeValue("msdyn_changes", value);
			}
		}	
			
		/// <summary>
        /// msdyn_children
        /// </summary>
		[DisplayName("Children")]
		[AttributeLogicalName("msdyn_children")]
		public string Children
		{	
			get { return GetAttributeValue<string>("msdyn_children"); }
			set
			{ 
				if(value == Children) return;
				SetAttributeValue("msdyn_children", value);
			}
		}	
			
		/// <summary>
        /// msdyn_componentid
        /// </summary>
		[DisplayName("Component Id")]
		[AttributeLogicalName("msdyn_componentid")]
		public string ComponentId
		{	
			get { return GetAttributeValue<string>("msdyn_componentid"); }
			set
			{ 
				if(value == ComponentId) return;
				SetAttributeValue("msdyn_componentid", value);
			}
		}	
			
		/// <summary>
        /// msdyn_componentjson
        /// </summary>
		[DisplayName("Component Json")]
		[AttributeLogicalName("msdyn_componentjson")]
		public string ComponentJson
		{	
			get { return GetAttributeValue<string>("msdyn_componentjson"); }
			set
			{ 
				if(value == ComponentJson) return;
				SetAttributeValue("msdyn_componentjson", value);
			}
		}	
			
		/// <summary>
        /// msdyn_componentlayerid
        /// </summary>
		[DisplayName("Component Layer")]
		[AttributeLogicalName("msdyn_componentlayerid")]
		public override Guid Id
		{
			get => base.Id;
			set { base.Id = value; SetAttributeValue("msdyn_componentlayerid", value); }
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
        /// msdyn_order
        /// </summary>
		[DisplayName("Order")]
		[AttributeLogicalName("msdyn_order")]
		public int? Order
		{	
			get { return GetAttributeValue<int?>("msdyn_order"); }
			set
			{ 
				if(value == Order) return;
				SetAttributeValue("msdyn_order", value);
			}
		}	
			
		/// <summary>
        /// msdyn_overwritetime
        /// </summary>
		[DisplayName("Overwrite Time")]
		[AttributeLogicalName("msdyn_overwritetime")]
		public DateTime? OverwriteTime
		{	
			get { return GetAttributeValue<DateTime?>("msdyn_overwritetime"); }
			set
			{ 
				if(value == OverwriteTime) return;
				SetAttributeValue("msdyn_overwritetime", value);
			}
		}	
			
		/// <summary>
        /// msdyn_publishername
        /// </summary>
		[DisplayName("Publisher Name")]
		[AttributeLogicalName("msdyn_publishername")]
		public string PublisherName
		{	
			get { return GetAttributeValue<string>("msdyn_publishername"); }
			set
			{ 
				if(value == PublisherName) return;
				SetAttributeValue("msdyn_publishername", value);
			}
		}	
			
		/// <summary>
        /// msdyn_solutioncomponentname
        /// </summary>
		[DisplayName("Solution Component Name")]
		[AttributeLogicalName("msdyn_solutioncomponentname")]
		public string SolutionComponentName
		{	
			get { return GetAttributeValue<string>("msdyn_solutioncomponentname"); }
			set
			{ 
				if(value == SolutionComponentName) return;
				SetAttributeValue("msdyn_solutioncomponentname", value);
			}
		}	
			
		/// <summary>
        /// msdyn_solutionname
        /// </summary>
		[DisplayName("Solution Name")]
		[AttributeLogicalName("msdyn_solutionname")]
		public string SolutionName
		{	
			get { return GetAttributeValue<string>("msdyn_solutionname"); }
			set
			{ 
				if(value == SolutionName) return;
				SetAttributeValue("msdyn_solutionname", value);
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
			/// <summary>msdyn_changes</summary>
			public const string Changes = "msdyn_changes";

			/// <summary>msdyn_children</summary>
			public const string Children = "msdyn_children";

			/// <summary>msdyn_componentid</summary>
			public const string ComponentId = "msdyn_componentid";

			/// <summary>msdyn_componentjson</summary>
			public const string ComponentJson = "msdyn_componentjson";

			/// <summary>msdyn_componentlayerid</summary>
			public const string ComponentLayerId = "msdyn_componentlayerid";

			/// <summary>msdyn_name</summary>
			public const string Name = "msdyn_name";

			/// <summary>msdyn_order</summary>
			public const string Order = "msdyn_order";

			/// <summary>msdyn_overwritetime</summary>
			public const string OverwriteTime = "msdyn_overwritetime";

			/// <summary>msdyn_publishername</summary>
			public const string PublisherName = "msdyn_publishername";

			/// <summary>msdyn_solutioncomponentname</summary>
			public const string SolutionComponentName = "msdyn_solutioncomponentname";

			/// <summary>msdyn_solutionname</summary>
			public const string SolutionName = "msdyn_solutionname";

		}
		#endregion

		#region Schemas
		public static class Schemas 
		{
		}
		#endregion
	}
}

