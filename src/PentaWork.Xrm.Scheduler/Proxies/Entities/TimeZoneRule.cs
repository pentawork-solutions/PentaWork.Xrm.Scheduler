using System;
using System.Linq;
using System.Diagnostics;
using System.ComponentModel;
using Microsoft.Xrm.Sdk; 
using Microsoft.Xrm.Sdk.Client;
using System.Collections.Generic;

namespace PentaWork.Xrm.Scheduler.Proxies.Entities
{
	[DebuggerDisplay("{TimeZoneRuleVersionNumber}")] 	
	[EntityLogicalName("timezonerule")]
	public sealed class TimeZoneRule : Entity
	{	
		public static readonly int? EntityTypeCode = 4811;
		public new const string LogicalName = "timezonerule";
		public const string PrimaryIdAttribute = "timezoneruleid";
		public const string PrimaryNameAttribute = "timezoneruleversionnumber";
	
		public TimeZoneRule() : base("timezonerule") { }

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
        /// daylightbias
        /// </summary>
		[DisplayName("Daylight Bias")]
		[AttributeLogicalName("daylightbias")]
		public int? DaylightBias
		{	
			get { return GetAttributeValue<int?>("daylightbias"); }
			set
			{ 
				if(value == DaylightBias) return;
				SetAttributeValue("daylightbias", value);
			}
		}	
			
		/// <summary>
        /// daylightday
        /// </summary>
		[DisplayName("Daylight Day")]
		[AttributeLogicalName("daylightday")]
		public int? DaylightDay
		{	
			get { return GetAttributeValue<int?>("daylightday"); }
			set
			{ 
				if(value == DaylightDay) return;
				SetAttributeValue("daylightday", value);
			}
		}	
			
		/// <summary>
        /// daylightdayofweek
        /// </summary>
		[DisplayName("Daylight Day Of Week")]
		[AttributeLogicalName("daylightdayofweek")]
		public int? DaylightDayOfWeek
		{	
			get { return GetAttributeValue<int?>("daylightdayofweek"); }
			set
			{ 
				if(value == DaylightDayOfWeek) return;
				SetAttributeValue("daylightdayofweek", value);
			}
		}	
			
		/// <summary>
        /// daylighthour
        /// </summary>
		[DisplayName("Daylight Hour")]
		[AttributeLogicalName("daylighthour")]
		public int? DaylightHour
		{	
			get { return GetAttributeValue<int?>("daylighthour"); }
			set
			{ 
				if(value == DaylightHour) return;
				SetAttributeValue("daylighthour", value);
			}
		}	
			
		/// <summary>
        /// daylightminute
        /// </summary>
		[DisplayName("Daylight Minute")]
		[AttributeLogicalName("daylightminute")]
		public int? DaylightMinute
		{	
			get { return GetAttributeValue<int?>("daylightminute"); }
			set
			{ 
				if(value == DaylightMinute) return;
				SetAttributeValue("daylightminute", value);
			}
		}	
			
		/// <summary>
        /// daylightmonth
        /// </summary>
		[DisplayName("Daylight Month")]
		[AttributeLogicalName("daylightmonth")]
		public int? DaylightMonth
		{	
			get { return GetAttributeValue<int?>("daylightmonth"); }
			set
			{ 
				if(value == DaylightMonth) return;
				SetAttributeValue("daylightmonth", value);
			}
		}	
			
		/// <summary>
        /// daylightsecond
        /// </summary>
		[DisplayName("Daylight Second")]
		[AttributeLogicalName("daylightsecond")]
		public int? DaylightSecond
		{	
			get { return GetAttributeValue<int?>("daylightsecond"); }
			set
			{ 
				if(value == DaylightSecond) return;
				SetAttributeValue("daylightsecond", value);
			}
		}	
			
		/// <summary>
        /// daylightyear
        /// </summary>
		[DisplayName("Daylight Year")]
		[AttributeLogicalName("daylightyear")]
		public int? DaylightYear
		{	
			get { return GetAttributeValue<int?>("daylightyear"); }
			set
			{ 
				if(value == DaylightYear) return;
				SetAttributeValue("daylightyear", value);
			}
		}	
			
		/// <summary>
        /// effectivedatetime
        /// </summary>
		[DisplayName("Effective Date Time")]
		[AttributeLogicalName("effectivedatetime")]
		public DateTime? EffectiveDateTime
		{	
			get { return GetAttributeValue<DateTime?>("effectivedatetime"); }
			set
			{ 
				if(value == EffectiveDateTime) return;
				SetAttributeValue("effectivedatetime", value);
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
        /// standardbias
        /// </summary>
		[DisplayName("Standard Bias")]
		[AttributeLogicalName("standardbias")]
		public int? StandardBias
		{	
			get { return GetAttributeValue<int?>("standardbias"); }
			set
			{ 
				if(value == StandardBias) return;
				SetAttributeValue("standardbias", value);
			}
		}	
			
		/// <summary>
        /// standardday
        /// </summary>
		[DisplayName("Standard Day")]
		[AttributeLogicalName("standardday")]
		public int? StandardDay
		{	
			get { return GetAttributeValue<int?>("standardday"); }
			set
			{ 
				if(value == StandardDay) return;
				SetAttributeValue("standardday", value);
			}
		}	
			
		/// <summary>
        /// standarddayofweek
        /// </summary>
		[DisplayName("Standard Day Of Week")]
		[AttributeLogicalName("standarddayofweek")]
		public int? StandardDayOfWeek
		{	
			get { return GetAttributeValue<int?>("standarddayofweek"); }
			set
			{ 
				if(value == StandardDayOfWeek) return;
				SetAttributeValue("standarddayofweek", value);
			}
		}	
			
		/// <summary>
        /// standardhour
        /// </summary>
		[DisplayName("Standard Hour")]
		[AttributeLogicalName("standardhour")]
		public int? StandardHour
		{	
			get { return GetAttributeValue<int?>("standardhour"); }
			set
			{ 
				if(value == StandardHour) return;
				SetAttributeValue("standardhour", value);
			}
		}	
			
		/// <summary>
        /// standardminute
        /// </summary>
		[DisplayName("Standard Minute")]
		[AttributeLogicalName("standardminute")]
		public int? StandardMinute
		{	
			get { return GetAttributeValue<int?>("standardminute"); }
			set
			{ 
				if(value == StandardMinute) return;
				SetAttributeValue("standardminute", value);
			}
		}	
			
		/// <summary>
        /// standardmonth
        /// </summary>
		[DisplayName("Standard Month")]
		[AttributeLogicalName("standardmonth")]
		public int? StandardMonth
		{	
			get { return GetAttributeValue<int?>("standardmonth"); }
			set
			{ 
				if(value == StandardMonth) return;
				SetAttributeValue("standardmonth", value);
			}
		}	
			
		/// <summary>
        /// standardsecond
        /// </summary>
		[DisplayName("Standard Second")]
		[AttributeLogicalName("standardsecond")]
		public int? StandardSecond
		{	
			get { return GetAttributeValue<int?>("standardsecond"); }
			set
			{ 
				if(value == StandardSecond) return;
				SetAttributeValue("standardsecond", value);
			}
		}	
			
		/// <summary>
        /// standardyear
        /// </summary>
		[DisplayName("Standard Year")]
		[AttributeLogicalName("standardyear")]
		public int? StandardYear
		{	
			get { return GetAttributeValue<int?>("standardyear"); }
			set
			{ 
				if(value == StandardYear) return;
				SetAttributeValue("standardyear", value);
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
        /// timezoneruleid
        /// </summary>
		[DisplayName("Time Zone Rule")]
		[AttributeLogicalName("timezoneruleid")]
		public override Guid Id
		{
			get => base.Id;
			set { base.Id = value; SetAttributeValue("timezoneruleid", value); }
		}

							/// <summary>
        /// timezoneruleversionnumber
        /// </summary>
		[DisplayName("Time Zone Rule Version Number")]
		[AttributeLogicalName("timezoneruleversionnumber")]
		public int? TimeZoneRuleVersionNumber
		{	
			get { return GetAttributeValue<int?>("timezoneruleversionnumber"); }
			set
			{ 
				if(value == TimeZoneRuleVersionNumber) return;
				SetAttributeValue("timezoneruleversionnumber", value);
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

			/// <summary>daylightbias</summary>
			public const string DaylightBias = "daylightbias";

			/// <summary>daylightday</summary>
			public const string DaylightDay = "daylightday";

			/// <summary>daylightdayofweek</summary>
			public const string DaylightDayOfWeek = "daylightdayofweek";

			/// <summary>daylighthour</summary>
			public const string DaylightHour = "daylighthour";

			/// <summary>daylightminute</summary>
			public const string DaylightMinute = "daylightminute";

			/// <summary>daylightmonth</summary>
			public const string DaylightMonth = "daylightmonth";

			/// <summary>daylightsecond</summary>
			public const string DaylightSecond = "daylightsecond";

			/// <summary>daylightyear</summary>
			public const string DaylightYear = "daylightyear";

			/// <summary>effectivedatetime</summary>
			public const string EffectiveDateTime = "effectivedatetime";

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

			/// <summary>standardbias</summary>
			public const string StandardBias = "standardbias";

			/// <summary>standardday</summary>
			public const string StandardDay = "standardday";

			/// <summary>standarddayofweek</summary>
			public const string StandardDayOfWeek = "standarddayofweek";

			/// <summary>standardhour</summary>
			public const string StandardHour = "standardhour";

			/// <summary>standardminute</summary>
			public const string StandardMinute = "standardminute";

			/// <summary>standardmonth</summary>
			public const string StandardMonth = "standardmonth";

			/// <summary>standardsecond</summary>
			public const string StandardSecond = "standardsecond";

			/// <summary>standardyear</summary>
			public const string StandardYear = "standardyear";

			/// <summary>timezonedefinitionid</summary>
			public const string TimeZoneDefinition = "timezonedefinitionid";

			/// <summary>timezoneruleid</summary>
			public const string TimeZoneRuleId = "timezoneruleid";

			/// <summary>timezoneruleversionnumber</summary>
			public const string TimeZoneRuleVersionNumber = "timezoneruleversionnumber";

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

