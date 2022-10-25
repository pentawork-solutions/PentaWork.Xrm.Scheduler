using System;
using System.Linq;
using System.Diagnostics;
using System.ComponentModel;
using Microsoft.Xrm.Sdk; 
using Microsoft.Xrm.Sdk.Client;
using System.Collections.Generic;

namespace PentaWork.Xrm.Scheduler.Proxies.Entities
{
	
	[EntityLogicalName("principalobjectaccess")]
	public sealed class Principalobjectaccess : Entity
	{	
		public static readonly int? EntityTypeCode = 11;
		public new const string LogicalName = "principalobjectaccess";
		public const string PrimaryIdAttribute = "principalobjectaccessid";
		public const string PrimaryNameAttribute = "";
	
		public Principalobjectaccess() : base("principalobjectaccess") { }

		#region Attributes
		/// <summary>
        /// accessrightsmask
        /// </summary>
		[DisplayName("accessrightsmask")]
		[AttributeLogicalName("accessrightsmask")]
		public int? Accessrightsmask
		{	
			get { return GetAttributeValue<int?>("accessrightsmask"); }
			set
			{ 
				if(value == Accessrightsmask) return;
				SetAttributeValue("accessrightsmask", value);
			}
		}	
			
		/// <summary>
        /// changedon
        /// </summary>
		[DisplayName("changedon")]
		[AttributeLogicalName("changedon")]
		public DateTime? Changedon
		{	
			get { return GetAttributeValue<DateTime?>("changedon"); }
			set
			{ 
				if(value == Changedon) return;
				SetAttributeValue("changedon", value);
			}
		}	
			
		/// <summary>
        /// inheritedaccessrightsmask
        /// </summary>
		[DisplayName("inheritedaccessrightsmask")]
		[AttributeLogicalName("inheritedaccessrightsmask")]
		public int? Inheritedaccessrightsmask
		{	
			get { return GetAttributeValue<int?>("inheritedaccessrightsmask"); }
			set
			{ 
				if(value == Inheritedaccessrightsmask) return;
				SetAttributeValue("inheritedaccessrightsmask", value);
			}
		}	
			
		/// <summary>
        /// objectid
        /// </summary>
		[DisplayName("objectid")]
		[AttributeLogicalName("objectid")]
		public Guid ObjectId
		{	
			get { return GetAttributeValue<Guid>("objectid"); }
			set
			{ 
				if(value == ObjectId) return;
				SetAttributeValue("objectid", value);
			}
		}	
			
		/// <summary>
        /// objecttypecode
        /// </summary>
		[DisplayName("objecttypecode")]
		[AttributeLogicalName("objecttypecode")]
		public string Objecttypecode
		{	
			get { return GetAttributeValue<string>("objecttypecode"); }
			set
			{ 
				if(value == Objecttypecode) return;
				SetAttributeValue("objecttypecode", value);
			}
		}	
			
		/// <summary>
        /// principalid
        /// </summary>
		[DisplayName("principalid")]
		[AttributeLogicalName("principalid")]
		public Guid PrincipalId
		{	
			get { return GetAttributeValue<Guid>("principalid"); }
			set
			{ 
				if(value == PrincipalId) return;
				SetAttributeValue("principalid", value);
			}
		}	
			
		/// <summary>
        /// principalobjectaccessid
        /// </summary>
		[DisplayName("principalobjectaccessid")]
		[AttributeLogicalName("principalobjectaccessid")]
		public override Guid Id
		{
			get => base.Id;
			set { base.Id = value; SetAttributeValue("principalobjectaccessid", value); }
		}

							/// <summary>
        /// principaltypecode
        /// </summary>
		[DisplayName("principaltypecode")]
		[AttributeLogicalName("principaltypecode")]
		public string Principaltypecode
		{	
			get { return GetAttributeValue<string>("principaltypecode"); }
			set
			{ 
				if(value == Principaltypecode) return;
				SetAttributeValue("principaltypecode", value);
			}
		}	
			
		/// <summary>
        /// timezoneruleversionnumber
        /// </summary>
		[DisplayName("timezoneruleversionnumber")]
		[AttributeLogicalName("timezoneruleversionnumber")]
		public int? Timezoneruleversionnumber
		{	
			get { return GetAttributeValue<int?>("timezoneruleversionnumber"); }
			set
			{ 
				if(value == Timezoneruleversionnumber) return;
				SetAttributeValue("timezoneruleversionnumber", value);
			}
		}	
			
		/// <summary>
        /// utcconversiontimezonecode
        /// </summary>
		[DisplayName("utcconversiontimezonecode")]
		[AttributeLogicalName("utcconversiontimezonecode")]
		public int? Utcconversiontimezonecode
		{	
			get { return GetAttributeValue<int?>("utcconversiontimezonecode"); }
			set
			{ 
				if(value == Utcconversiontimezonecode) return;
				SetAttributeValue("utcconversiontimezonecode", value);
			}
		}	
			
		/// <summary>
        /// versionnumber
        /// </summary>
		[DisplayName("versionnumber")]
		[AttributeLogicalName("versionnumber")]
		public int? Versionnumber
		{	
			get { return GetAttributeValue<int?>("versionnumber"); }
			set
			{ 
				if(value == Versionnumber) return;
				SetAttributeValue("versionnumber", value);
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
			/// <summary>accessrightsmask</summary>
			public const string Accessrightsmask = "accessrightsmask";

			/// <summary>changedon</summary>
			public const string Changedon = "changedon";

			/// <summary>inheritedaccessrightsmask</summary>
			public const string Inheritedaccessrightsmask = "inheritedaccessrightsmask";

			/// <summary>objectid</summary>
			public const string ObjectId = "objectid";

			/// <summary>objecttypecode</summary>
			public const string Objecttypecode = "objecttypecode";

			/// <summary>principalid</summary>
			public const string PrincipalId = "principalid";

			/// <summary>principalobjectaccessid</summary>
			public const string PrincipalobjectaccessId = "principalobjectaccessid";

			/// <summary>principaltypecode</summary>
			public const string Principaltypecode = "principaltypecode";

			/// <summary>timezoneruleversionnumber</summary>
			public const string Timezoneruleversionnumber = "timezoneruleversionnumber";

			/// <summary>utcconversiontimezonecode</summary>
			public const string Utcconversiontimezonecode = "utcconversiontimezonecode";

			/// <summary>versionnumber</summary>
			public const string Versionnumber = "versionnumber";

		}
		#endregion

		#region Schemas
		public static class Schemas 
		{
		}
		#endregion
	}
}

