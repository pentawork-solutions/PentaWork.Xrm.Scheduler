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
	[EntityLogicalName("timezonedefinition")]
	public sealed class TimeZoneDefinition : Entity
	{	
		public static readonly int? EntityTypeCode = 4810;
		public new const string LogicalName = "timezonedefinition";
		public const string PrimaryIdAttribute = "timezonedefinitionid";
		public const string PrimaryNameAttribute = "userinterfacename";
	
		public TimeZoneDefinition() : base("timezonedefinition") { }

		#region Attributes
		/// <summary>
        /// bias
        /// </summary>
		[DisplayName("Bias")]
		[AttributeLogicalName("bias")]
		public int? Bias
		{	
			get { return GetAttributeValue<int?>("bias"); }
			set
			{ 
				if(value == Bias) return;
				SetAttributeValue("bias", value);
			}
		}	
			
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
        /// retiredorder
        /// </summary>
		[DisplayName("Retired Order")]
		[AttributeLogicalName("retiredorder")]
		public int? RetiredOrder
		{	
			get { return GetAttributeValue<int?>("retiredorder"); }
			set
			{ 
				if(value == RetiredOrder) return;
				SetAttributeValue("retiredorder", value);
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
        /// timezonecode
        /// </summary>
		[DisplayName("Time Zone Code")]
		[AttributeLogicalName("timezonecode")]
		public int? TimeZoneCode
		{	
			get { return GetAttributeValue<int?>("timezonecode"); }
			set
			{ 
				if(value == TimeZoneCode) return;
				SetAttributeValue("timezonecode", value);
			}
		}	
			
		/// <summary>
        /// timezonedefinitionid
        /// </summary>
		[DisplayName("Time Zone Definition")]
		[AttributeLogicalName("timezonedefinitionid")]
		public override Guid Id
		{
			get => base.Id;
			set { base.Id = value; SetAttributeValue("timezonedefinitionid", value); }
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
			/// <summary>
        /// 1:N Get entities for 'lk_timezonelocalizedname_timezonedefinitionid'
        /// </summary>
		[RelationshipSchemaName("lk_timezonelocalizedname_timezonedefinitionid")]
		public IEnumerable<TimeZoneLocalizedName> LkTimezonelocalizednameTimezonedefinitionid
		{
			get { return GetRelatedEntities<TimeZoneLocalizedName>("lk_timezonelocalizedname_timezonedefinitionid", null); }
			set { SetRelatedEntities("lk_timezonelocalizedname_timezonedefinitionid", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_timezonerule_timezonedefinitionid'
        /// </summary>
		[RelationshipSchemaName("lk_timezonerule_timezonedefinitionid")]
		public IEnumerable<TimeZoneRule> LkTimezoneruleTimezonedefinitionid
		{
			get { return GetRelatedEntities<TimeZoneRule>("lk_timezonerule_timezonedefinitionid", null); }
			set { SetRelatedEntities("lk_timezonerule_timezonedefinitionid", null, value); }
		}
		#endregion

		#region Actions
		#endregion

		#region OptionSetEnums
		#endregion	

		#region Properties
		public static class Properties 
		{
			/// <summary>bias</summary>
			public const string Bias = "bias";

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

			/// <summary>retiredorder</summary>
			public const string RetiredOrder = "retiredorder";

			/// <summary>standardname</summary>
			public const string StandardName = "standardname";

			/// <summary>timezonecode</summary>
			public const string TimeZoneCode = "timezonecode";

			/// <summary>timezonedefinitionid</summary>
			public const string TimeZoneDefinitionId = "timezonedefinitionid";

			/// <summary>userinterfacename</summary>
			public const string UserInterfaceName = "userinterfacename";

			/// <summary>versionnumber</summary>
			public const string Versionnumber = "versionnumber";

		}
		#endregion

		#region Schemas
		public static class Schemas 
		{
			/// <summary>1:N lk_timezonelocalizedname_timezonedefinitionid</summary>
			public const string LkTimezonelocalizednameTimezonedefinitionid = "lk_timezonelocalizedname_timezonedefinitionid";

			/// <summary>1:N lk_timezonerule_timezonedefinitionid</summary>
			public const string LkTimezoneruleTimezonedefinitionid = "lk_timezonerule_timezonedefinitionid";

		}
		#endregion
	}
}

