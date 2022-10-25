using System;
using System.Linq;
using System.Diagnostics;
using System.ComponentModel;
using Microsoft.Xrm.Sdk; 
using Microsoft.Xrm.Sdk.Client;
using System.Collections.Generic;

namespace PentaWork.Xrm.Scheduler.Proxies.Entities
{
	[DebuggerDisplay("{UserInterfaceName}")] 	
	[EntityLogicalName("timezonelocalizedname")]
	public sealed class TimeZoneLocalizedName : Entity
	{	
		public static readonly int? EntityTypeCode = 4812;
		public new const string LogicalName = "timezonelocalizedname";
		public const string PrimaryIdAttribute = "timezonelocalizednameid";
		public const string PrimaryNameAttribute = "userinterfacename";
	
		public TimeZoneLocalizedName() : base("timezonelocalizedname") { }

		#region Attributes
		/// <summary>
        /// createdby
        /// </summary>
		[DisplayName("Created By")]
		[AttributeLogicalName("createdby")]
		public EntityReference CreatedBy
		{	
			get { return GetAttributeValue<EntityReference>("createdby"); }
			set
			{ 
				if(value == CreatedBy) return;
				SetAttributeValue("createdby", value);
			}
		}	
			
		/// <summary>
        /// createdon
        /// </summary>
		[DisplayName("Created On")]
		[AttributeLogicalName("createdon")]
		public DateTime? CreatedOn
		{	
			get { return GetAttributeValue<DateTime?>("createdon"); }
			set
			{ 
				if(value == CreatedOn) return;
				SetAttributeValue("createdon", value);
			}
		}	
			
		/// <summary>
        /// createdonbehalfby
        /// </summary>
		[DisplayName("Created By (Delegate)")]
		[AttributeLogicalName("createdonbehalfby")]
		public EntityReference CreatedByDelegate
		{	
			get { return GetAttributeValue<EntityReference>("createdonbehalfby"); }
			set
			{ 
				if(value == CreatedByDelegate) return;
				SetAttributeValue("createdonbehalfby", value);
			}
		}	
			
		/// <summary>
        /// createdonbehalfbyname
        /// </summary>
		[DisplayName("createdonbehalfbyname")]
		[AttributeLogicalName("createdonbehalfbyname")]
		public string Createdonbehalfbyname
		{	
			get { return GetAttributeValue<string>("createdonbehalfbyname"); }
			set
			{ 
				if(value == Createdonbehalfbyname) return;
				SetAttributeValue("createdonbehalfbyname", value);
			}
		}	
			
		/// <summary>
        /// createdonbehalfbyyominame
        /// </summary>
		[DisplayName("createdonbehalfbyyominame")]
		[AttributeLogicalName("createdonbehalfbyyominame")]
		public string Createdonbehalfbyyominame
		{	
			get { return GetAttributeValue<string>("createdonbehalfbyyominame"); }
			set
			{ 
				if(value == Createdonbehalfbyyominame) return;
				SetAttributeValue("createdonbehalfbyyominame", value);
			}
		}	
			
		/// <summary>
        /// cultureid
        /// </summary>
		[DisplayName("Culture")]
		[AttributeLogicalName("cultureid")]
		public int? Culture
		{	
			get { return GetAttributeValue<int?>("cultureid"); }
			set
			{ 
				if(value == Culture) return;
				SetAttributeValue("cultureid", value);
			}
		}	
			
		/// <summary>
        /// daylightname
        /// </summary>
		[DisplayName("Daylight Name")]
		[AttributeLogicalName("daylightname")]
		public string DaylightName
		{	
			get { return GetAttributeValue<string>("daylightname"); }
			set
			{ 
				if(value == DaylightName) return;
				SetAttributeValue("daylightname", value);
			}
		}	
			
		/// <summary>
        /// modifiedby
        /// </summary>
		[DisplayName("Modified By")]
		[AttributeLogicalName("modifiedby")]
		public EntityReference ModifiedBy
		{	
			get { return GetAttributeValue<EntityReference>("modifiedby"); }
			set
			{ 
				if(value == ModifiedBy) return;
				SetAttributeValue("modifiedby", value);
			}
		}	
			
		/// <summary>
        /// modifiedon
        /// </summary>
		[DisplayName("Modified On")]
		[AttributeLogicalName("modifiedon")]
		public DateTime? ModifiedOn
		{	
			get { return GetAttributeValue<DateTime?>("modifiedon"); }
			set
			{ 
				if(value == ModifiedOn) return;
				SetAttributeValue("modifiedon", value);
			}
		}	
			
		/// <summary>
        /// modifiedonbehalfby
        /// </summary>
		[DisplayName("Modified By (Delegate)")]
		[AttributeLogicalName("modifiedonbehalfby")]
		public EntityReference ModifiedByDelegate
		{	
			get { return GetAttributeValue<EntityReference>("modifiedonbehalfby"); }
			set
			{ 
				if(value == ModifiedByDelegate) return;
				SetAttributeValue("modifiedonbehalfby", value);
			}
		}	
			
		/// <summary>
        /// modifiedonbehalfbyname
        /// </summary>
		[DisplayName("modifiedonbehalfbyname")]
		[AttributeLogicalName("modifiedonbehalfbyname")]
		public string Modifiedonbehalfbyname
		{	
			get { return GetAttributeValue<string>("modifiedonbehalfbyname"); }
			set
			{ 
				if(value == Modifiedonbehalfbyname) return;
				SetAttributeValue("modifiedonbehalfbyname", value);
			}
		}	
			
		/// <summary>
        /// modifiedonbehalfbyyominame
        /// </summary>
		[DisplayName("modifiedonbehalfbyyominame")]
		[AttributeLogicalName("modifiedonbehalfbyyominame")]
		public string Modifiedonbehalfbyyominame
		{	
			get { return GetAttributeValue<string>("modifiedonbehalfbyyominame"); }
			set
			{ 
				if(value == Modifiedonbehalfbyyominame) return;
				SetAttributeValue("modifiedonbehalfbyyominame", value);
			}
		}	
			
		/// <summary>
        /// organizationid
        /// </summary>
		[DisplayName("Organization")]
		[AttributeLogicalName("organizationid")]
		public EntityReference Organization
		{	
			get { return GetAttributeValue<EntityReference>("organizationid"); }
			set
			{ 
				if(value == Organization) return;
				SetAttributeValue("organizationid", value);
			}
		}	
			
		/// <summary>
        /// standardname
        /// </summary>
		[DisplayName("Standard Name")]
		[AttributeLogicalName("standardname")]
		public string StandardName
		{	
			get { return GetAttributeValue<string>("standardname"); }
			set
			{ 
				if(value == StandardName) return;
				SetAttributeValue("standardname", value);
			}
		}	
			
		/// <summary>
        /// timezonedefinitionid
        /// </summary>
		[DisplayName("Time Zone Definition")]
		[AttributeLogicalName("timezonedefinitionid")]
		public EntityReference TimeZoneDefinition
		{	
			get { return GetAttributeValue<EntityReference>("timezonedefinitionid"); }
			set
			{ 
				if(value == TimeZoneDefinition) return;
				SetAttributeValue("timezonedefinitionid", value);
			}
		}	
			
		/// <summary>
        /// timezonelocalizednameid
        /// </summary>
		[DisplayName("Time Zone Localized Name")]
		[AttributeLogicalName("timezonelocalizednameid")]
		public override Guid Id
		{
			get => base.Id;
			set { base.Id = value; SetAttributeValue("timezonelocalizednameid", value); }
		}

							/// <summary>
        /// userinterfacename
        /// </summary>
		[DisplayName("User Interface Name")]
		[AttributeLogicalName("userinterfacename")]
		public string UserInterfaceName
		{	
			get { return GetAttributeValue<string>("userinterfacename"); }
			set
			{ 
				if(value == UserInterfaceName) return;
				SetAttributeValue("userinterfacename", value);
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
			/// <summary>createdby</summary>
			public const string CreatedBy = "createdby";

			/// <summary>createdon</summary>
			public const string CreatedOn = "createdon";

			/// <summary>createdonbehalfby</summary>
			public const string CreatedByDelegate = "createdonbehalfby";

			/// <summary>createdonbehalfbyname</summary>
			public const string Createdonbehalfbyname = "createdonbehalfbyname";

			/// <summary>createdonbehalfbyyominame</summary>
			public const string Createdonbehalfbyyominame = "createdonbehalfbyyominame";

			/// <summary>cultureid</summary>
			public const string Culture = "cultureid";

			/// <summary>daylightname</summary>
			public const string DaylightName = "daylightname";

			/// <summary>modifiedby</summary>
			public const string ModifiedBy = "modifiedby";

			/// <summary>modifiedon</summary>
			public const string ModifiedOn = "modifiedon";

			/// <summary>modifiedonbehalfby</summary>
			public const string ModifiedByDelegate = "modifiedonbehalfby";

			/// <summary>modifiedonbehalfbyname</summary>
			public const string Modifiedonbehalfbyname = "modifiedonbehalfbyname";

			/// <summary>modifiedonbehalfbyyominame</summary>
			public const string Modifiedonbehalfbyyominame = "modifiedonbehalfbyyominame";

			/// <summary>organizationid</summary>
			public const string Organization = "organizationid";

			/// <summary>standardname</summary>
			public const string StandardName = "standardname";

			/// <summary>timezonedefinitionid</summary>
			public const string TimeZoneDefinition = "timezonedefinitionid";

			/// <summary>timezonelocalizednameid</summary>
			public const string TimeZoneLocalizedNameId = "timezonelocalizednameid";

			/// <summary>userinterfacename</summary>
			public const string UserInterfaceName = "userinterfacename";

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

