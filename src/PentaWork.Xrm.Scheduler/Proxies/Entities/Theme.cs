using System;
using System.Linq;
using System.Diagnostics;
using System.ComponentModel;
using Microsoft.Xrm.Sdk; 
using Microsoft.Xrm.Sdk.Client;
using System.Collections.Generic;

namespace PentaWork.Xrm.Scheduler.Proxies.Entities
{
	[DebuggerDisplay("{ThemeName}")] 	
	[EntityLogicalName("theme")]
	public sealed class Theme : Entity
	{	
		public static readonly int? EntityTypeCode = 2015;
		public new const string LogicalName = "theme";
		public const string PrimaryIdAttribute = "themeid";
		public const string PrimaryNameAttribute = "name";
	
		public Theme() : base("theme") { }

		#region Attributes
		/// <summary>
        /// accentcolor
        /// </summary>
		[DisplayName("Accent Color")]
		[AttributeLogicalName("accentcolor")]
		public string AccentColor
		{	
			get { return GetAttributeValue<string>("accentcolor"); }
			set
			{ 
				if(value == AccentColor) return;
				SetAttributeValue("accentcolor", value);
			}
		}	
			
		/// <summary>
        /// backgroundcolor
        /// </summary>
		[DisplayName("Background Color")]
		[AttributeLogicalName("backgroundcolor")]
		public string BackgroundColor
		{	
			get { return GetAttributeValue<string>("backgroundcolor"); }
			set
			{ 
				if(value == BackgroundColor) return;
				SetAttributeValue("backgroundcolor", value);
			}
		}	
			
		/// <summary>
        /// controlborder
        /// </summary>
		[DisplayName("Control Hover Border Color")]
		[AttributeLogicalName("controlborder")]
		public string ControlHoverBorderColor
		{	
			get { return GetAttributeValue<string>("controlborder"); }
			set
			{ 
				if(value == ControlHoverBorderColor) return;
				SetAttributeValue("controlborder", value);
			}
		}	
			
		/// <summary>
        /// controlshade
        /// </summary>
		[DisplayName("Control Hover Fill Color")]
		[AttributeLogicalName("controlshade")]
		public string ControlHoverFillColor
		{	
			get { return GetAttributeValue<string>("controlshade"); }
			set
			{ 
				if(value == ControlHoverFillColor) return;
				SetAttributeValue("controlshade", value);
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
        /// createdbyname
        /// </summary>
		[DisplayName("createdbyname")]
		[AttributeLogicalName("createdbyname")]
		public string Createdbyname
		{	
			get { return GetAttributeValue<string>("createdbyname"); }
			set
			{ 
				if(value == Createdbyname) return;
				SetAttributeValue("createdbyname", value);
			}
		}	
			
		/// <summary>
        /// createdbyyominame
        /// </summary>
		[DisplayName("createdbyyominame")]
		[AttributeLogicalName("createdbyyominame")]
		public string Createdbyyominame
		{	
			get { return GetAttributeValue<string>("createdbyyominame"); }
			set
			{ 
				if(value == Createdbyyominame) return;
				SetAttributeValue("createdbyyominame", value);
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
        /// defaultcustomentitycolor
        /// </summary>
		[DisplayName("Default Custom Entity Color")]
		[AttributeLogicalName("defaultcustomentitycolor")]
		public string DefaultCustomEntityColor
		{	
			get { return GetAttributeValue<string>("defaultcustomentitycolor"); }
			set
			{ 
				if(value == DefaultCustomEntityColor) return;
				SetAttributeValue("defaultcustomentitycolor", value);
			}
		}	
			
		/// <summary>
        /// defaultentitycolor
        /// </summary>
		[DisplayName("Default Entity Color")]
		[AttributeLogicalName("defaultentitycolor")]
		public string DefaultEntityColor
		{	
			get { return GetAttributeValue<string>("defaultentitycolor"); }
			set
			{ 
				if(value == DefaultEntityColor) return;
				SetAttributeValue("defaultentitycolor", value);
			}
		}	
			
		/// <summary>
        /// exchangerate
		///
		/// Precision: 10
		/// MaxValue: 100000000000
		/// MinValue: 0.0000000001
        /// </summary>
		[DisplayName("ExchangeRate")]
		[AttributeLogicalName("exchangerate")]
		public decimal? ExchangeRate
		{	
			get { return GetAttributeValue<decimal?>("exchangerate"); }
			set 
			{
				decimal? decimalValue = null;
				if(value != null) decimalValue = Decimal.Round(value.Value, 10);
				if(decimalValue == ExchangeRate) return;
				SetAttributeValue("exchangerate", decimalValue);  
			}
		}

		/// <summary>
        /// globallinkcolor
        /// </summary>
		[DisplayName("Link and Button Text Color")]
		[AttributeLogicalName("globallinkcolor")]
		public string LinkAndButtonTextColor
		{	
			get { return GetAttributeValue<string>("globallinkcolor"); }
			set
			{ 
				if(value == LinkAndButtonTextColor) return;
				SetAttributeValue("globallinkcolor", value);
			}
		}	
			
		/// <summary>
        /// headercolor
        /// </summary>
		[DisplayName("Title Text Color")]
		[AttributeLogicalName("headercolor")]
		public string TitleTextColor
		{	
			get { return GetAttributeValue<string>("headercolor"); }
			set
			{ 
				if(value == TitleTextColor) return;
				SetAttributeValue("headercolor", value);
			}
		}	
			
		/// <summary>
        /// hoverlinkeffect
        /// </summary>
		[DisplayName("Hover Link Color")]
		[AttributeLogicalName("hoverlinkeffect")]
		public string HoverLinkColor
		{	
			get { return GetAttributeValue<string>("hoverlinkeffect"); }
			set
			{ 
				if(value == HoverLinkColor) return;
				SetAttributeValue("hoverlinkeffect", value);
			}
		}	
			
		/// <summary>
        /// importsequencenumber
        /// </summary>
		[DisplayName("Import Sequence Number")]
		[AttributeLogicalName("importsequencenumber")]
		public int? ImportSequenceNumber
		{	
			get { return GetAttributeValue<int?>("importsequencenumber"); }
			set
			{ 
				if(value == ImportSequenceNumber) return;
				SetAttributeValue("importsequencenumber", value);
			}
		}	
			
		/// <summary>
        /// isdefaulttheme
        /// </summary>
		[DisplayName("Default Theme")]
		[AttributeLogicalName("isdefaulttheme")]
		public bool? DefaultTheme
		{	
			get { return GetAttributeValue<bool?>("isdefaulttheme"); }
			set
			{ 
				if(value == DefaultTheme) return;
				SetAttributeValue("isdefaulttheme", value);
			}
		}	
			
		/// <summary>
        /// logoid
        /// </summary>
		[DisplayName("Logo")]
		[AttributeLogicalName("logoid")]
		public EntityReference Logo
		{	
			get { return GetAttributeValue<EntityReference>("logoid"); }
			set
			{ 
				if(value == Logo) return;
				SetAttributeValue("logoid", value);
			}
		}	
			
		/// <summary>
        /// logoidname
        /// </summary>
		[DisplayName("logoidname")]
		[AttributeLogicalName("logoidname")]
		public string Logoidname
		{	
			get { return GetAttributeValue<string>("logoidname"); }
			set
			{ 
				if(value == Logoidname) return;
				SetAttributeValue("logoidname", value);
			}
		}	
			
		/// <summary>
        /// logotooltip
        /// </summary>
		[DisplayName("Logo Tooltip")]
		[AttributeLogicalName("logotooltip")]
		public string LogoTooltip
		{	
			get { return GetAttributeValue<string>("logotooltip"); }
			set
			{ 
				if(value == LogoTooltip) return;
				SetAttributeValue("logotooltip", value);
			}
		}	
			
		/// <summary>
        /// maincolor
        /// </summary>
		[DisplayName("Main Color")]
		[AttributeLogicalName("maincolor")]
		public string MainColor
		{	
			get { return GetAttributeValue<string>("maincolor"); }
			set
			{ 
				if(value == MainColor) return;
				SetAttributeValue("maincolor", value);
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
        /// modifiedbyname
        /// </summary>
		[DisplayName("modifiedbyname")]
		[AttributeLogicalName("modifiedbyname")]
		public string Modifiedbyname
		{	
			get { return GetAttributeValue<string>("modifiedbyname"); }
			set
			{ 
				if(value == Modifiedbyname) return;
				SetAttributeValue("modifiedbyname", value);
			}
		}	
			
		/// <summary>
        /// modifiedbyyominame
        /// </summary>
		[DisplayName("modifiedbyyominame")]
		[AttributeLogicalName("modifiedbyyominame")]
		public string Modifiedbyyominame
		{	
			get { return GetAttributeValue<string>("modifiedbyyominame"); }
			set
			{ 
				if(value == Modifiedbyyominame) return;
				SetAttributeValue("modifiedbyyominame", value);
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
        /// name
        /// </summary>
		[DisplayName("Theme Name")]
		[AttributeLogicalName("name")]
		public string ThemeName
		{	
			get { return GetAttributeValue<string>("name"); }
			set
			{ 
				if(value == ThemeName) return;
				SetAttributeValue("name", value);
			}
		}	
			
		/// <summary>
        /// navbarbackgroundcolor
        /// </summary>
		[DisplayName("Navigation Bar Fill Color")]
		[AttributeLogicalName("navbarbackgroundcolor")]
		public string NavigationBarFillColor
		{	
			get { return GetAttributeValue<string>("navbarbackgroundcolor"); }
			set
			{ 
				if(value == NavigationBarFillColor) return;
				SetAttributeValue("navbarbackgroundcolor", value);
			}
		}	
			
		/// <summary>
        /// navbarshelfcolor
        /// </summary>
		[DisplayName("Navigation Bar Shelf Fill Color")]
		[AttributeLogicalName("navbarshelfcolor")]
		public string NavigationBarShelfFillColor
		{	
			get { return GetAttributeValue<string>("navbarshelfcolor"); }
			set
			{ 
				if(value == NavigationBarShelfFillColor) return;
				SetAttributeValue("navbarshelfcolor", value);
			}
		}	
			
		/// <summary>
        /// organizationid
        /// </summary>
		[DisplayName("Organization Id")]
		[AttributeLogicalName("organizationid")]
		public EntityReference OrganizationId
		{	
			get { return GetAttributeValue<EntityReference>("organizationid"); }
			set
			{ 
				if(value == OrganizationId) return;
				SetAttributeValue("organizationid", value);
			}
		}	
			
		/// <summary>
        /// organizationidname
        /// </summary>
		[DisplayName("organizationidname")]
		[AttributeLogicalName("organizationidname")]
		public string Organizationidname
		{	
			get { return GetAttributeValue<string>("organizationidname"); }
			set
			{ 
				if(value == Organizationidname) return;
				SetAttributeValue("organizationidname", value);
			}
		}	
			
		/// <summary>
        /// overriddencreatedon
        /// </summary>
		[DisplayName("Record Created On")]
		[AttributeLogicalName("overriddencreatedon")]
		public DateTime? RecordCreatedOn
		{	
			get { return GetAttributeValue<DateTime?>("overriddencreatedon"); }
			set
			{ 
				if(value == RecordCreatedOn) return;
				SetAttributeValue("overriddencreatedon", value);
			}
		}	
			
		/// <summary>
        /// pageheaderbackgroundcolor
        /// </summary>
		[DisplayName("Page Header Fill Color")]
		[AttributeLogicalName("pageheaderbackgroundcolor")]
		public string PageHeaderFillColor
		{	
			get { return GetAttributeValue<string>("pageheaderbackgroundcolor"); }
			set
			{ 
				if(value == PageHeaderFillColor) return;
				SetAttributeValue("pageheaderbackgroundcolor", value);
			}
		}	
			
		/// <summary>
        /// panelheaderbackgroundcolor
        /// </summary>
		[DisplayName("Panel Header Fill Color")]
		[AttributeLogicalName("panelheaderbackgroundcolor")]
		public string PanelHeaderFillColor
		{	
			get { return GetAttributeValue<string>("panelheaderbackgroundcolor"); }
			set
			{ 
				if(value == PanelHeaderFillColor) return;
				SetAttributeValue("panelheaderbackgroundcolor", value);
			}
		}	
			
		/// <summary>
        /// processcontrolcolor
        /// </summary>
		[DisplayName("Legacy Accent Color")]
		[AttributeLogicalName("processcontrolcolor")]
		public string LegacyAccentColor
		{	
			get { return GetAttributeValue<string>("processcontrolcolor"); }
			set
			{ 
				if(value == LegacyAccentColor) return;
				SetAttributeValue("processcontrolcolor", value);
			}
		}	
			
		/// <summary>
        /// selectedlinkeffect
        /// </summary>
		[DisplayName("Selected Link Color")]
		[AttributeLogicalName("selectedlinkeffect")]
		public string SelectedLinkColor
		{	
			get { return GetAttributeValue<string>("selectedlinkeffect"); }
			set
			{ 
				if(value == SelectedLinkColor) return;
				SetAttributeValue("selectedlinkeffect", value);
			}
		}	
			
		/// <summary>
        /// statecode
        /// </summary>
		[DisplayName("Status")]
		[AttributeLogicalName("statecode")]
		public eStatus? Status
		{	
			get 
			{ 
				var optionSetValue = GetAttributeValue<OptionSetValue>("statecode");
				if (optionSetValue != null) return (eStatus)optionSetValue.Value;
				else return null;
			}
			set 
			{ 
				if(value == Status) return;

				OptionSetValue optionSetValue = null;
				if(value != null) optionSetValue = new OptionSetValue((int)value);
				SetAttributeValue("statecode", optionSetValue); 
			}
		}

		/// <summary>
        /// statuscode
        /// </summary>
		[DisplayName("Status Reason")]
		[AttributeLogicalName("statuscode")]
		public eStatusReason? StatusReason
		{	
			get 
			{ 
				var optionSetValue = GetAttributeValue<OptionSetValue>("statuscode");
				if (optionSetValue != null) return (eStatusReason)optionSetValue.Value;
				else return null;
			}
			set 
			{ 
				if(value == StatusReason) return;

				OptionSetValue optionSetValue = null;
				if(value != null) optionSetValue = new OptionSetValue((int)value);
				SetAttributeValue("statuscode", optionSetValue); 
			}
		}

		/// <summary>
        /// themeid
        /// </summary>
		[DisplayName("Theme")]
		[AttributeLogicalName("themeid")]
		public override Guid Id
		{
			get => base.Id;
			set { base.Id = value; SetAttributeValue("themeid", value); }
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
        /// transactioncurrencyid
        /// </summary>
		[DisplayName("Currency")]
		[AttributeLogicalName("transactioncurrencyid")]
		public EntityReference Currency
		{	
			get { return GetAttributeValue<EntityReference>("transactioncurrencyid"); }
			set
			{ 
				if(value == Currency) return;
				SetAttributeValue("transactioncurrencyid", value);
			}
		}	
			
		/// <summary>
        /// transactioncurrencyidname
        /// </summary>
		[DisplayName("transactioncurrencyidname")]
		[AttributeLogicalName("transactioncurrencyidname")]
		public string Transactioncurrencyidname
		{	
			get { return GetAttributeValue<string>("transactioncurrencyidname"); }
			set
			{ 
				if(value == Transactioncurrencyidname) return;
				SetAttributeValue("transactioncurrencyidname", value);
			}
		}	
			
		/// <summary>
        /// type
        /// </summary>
		[DisplayName("Type")]
		[AttributeLogicalName("type")]
		public bool? Type
		{	
			get { return GetAttributeValue<bool?>("type"); }
			set
			{ 
				if(value == Type) return;
				SetAttributeValue("type", value);
			}
		}	
			
		/// <summary>
        /// utcconversiontimezonecode
        /// </summary>
		[DisplayName("UTC Conversion Time Zone Code")]
		[AttributeLogicalName("utcconversiontimezonecode")]
		public int? UTCConversionTimeZoneCode
		{	
			get { return GetAttributeValue<int?>("utcconversiontimezonecode"); }
			set
			{ 
				if(value == UTCConversionTimeZoneCode) return;
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
			/// <summary>
        /// 1:N Get entities for 'theme_AsyncOperations'
        /// </summary>
		[RelationshipSchemaName("theme_AsyncOperations")]
		public IEnumerable<SystemJob> ThemeAsyncOperations
		{
			get { return GetRelatedEntities<SystemJob>("theme_AsyncOperations", null); }
			set { SetRelatedEntities("theme_AsyncOperations", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'theme_BulkDeleteFailures'
        /// </summary>
		[RelationshipSchemaName("theme_BulkDeleteFailures")]
		public IEnumerable<BulkDeleteFailure> ThemeBulkDeleteFailures
		{
			get { return GetRelatedEntities<BulkDeleteFailure>("theme_BulkDeleteFailures", null); }
			set { SetRelatedEntities("theme_BulkDeleteFailures", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'theme_ProcessSession'
        /// </summary>
		[RelationshipSchemaName("theme_ProcessSession")]
		public IEnumerable<ProcessSession> ThemeProcessSession
		{
			get { return GetRelatedEntities<ProcessSession>("theme_ProcessSession", null); }
			set { SetRelatedEntities("theme_ProcessSession", null, value); }
		}
		#endregion

		#region Actions
		#endregion

		#region OptionSetEnums
		public enum eStatus
		{	
		
			[Label("Custom")]
			[Description(@"")]
			Custom = 0, 
		
			[Label("System")]
			[Description(@"")]
			System = 1, 
		}
		
		public enum eStatusReason
		{	
		
			[Label("Custom")]
			[Description(@"")]
			Custom_Active = 1, 
		
			[Label("System")]
			[Description(@"")]
			System_Inactive = 2, 
		}
		
		#endregion	

		#region Properties
		public static class Properties 
		{
			/// <summary>accentcolor</summary>
			public const string AccentColor = "accentcolor";

			/// <summary>backgroundcolor</summary>
			public const string BackgroundColor = "backgroundcolor";

			/// <summary>controlborder</summary>
			public const string ControlHoverBorderColor = "controlborder";

			/// <summary>controlshade</summary>
			public const string ControlHoverFillColor = "controlshade";

			/// <summary>createdby</summary>
			public const string CreatedBy = "createdby";

			/// <summary>createdbyname</summary>
			public const string Createdbyname = "createdbyname";

			/// <summary>createdbyyominame</summary>
			public const string Createdbyyominame = "createdbyyominame";

			/// <summary>createdon</summary>
			public const string CreatedOn = "createdon";

			/// <summary>createdonbehalfby</summary>
			public const string CreatedByDelegate = "createdonbehalfby";

			/// <summary>createdonbehalfbyname</summary>
			public const string Createdonbehalfbyname = "createdonbehalfbyname";

			/// <summary>createdonbehalfbyyominame</summary>
			public const string Createdonbehalfbyyominame = "createdonbehalfbyyominame";

			/// <summary>defaultcustomentitycolor</summary>
			public const string DefaultCustomEntityColor = "defaultcustomentitycolor";

			/// <summary>defaultentitycolor</summary>
			public const string DefaultEntityColor = "defaultentitycolor";

			/// <summary>exchangerate</summary>
			public const string ExchangeRate = "exchangerate";

			/// <summary>globallinkcolor</summary>
			public const string LinkAndButtonTextColor = "globallinkcolor";

			/// <summary>headercolor</summary>
			public const string TitleTextColor = "headercolor";

			/// <summary>hoverlinkeffect</summary>
			public const string HoverLinkColor = "hoverlinkeffect";

			/// <summary>importsequencenumber</summary>
			public const string ImportSequenceNumber = "importsequencenumber";

			/// <summary>isdefaulttheme</summary>
			public const string DefaultTheme = "isdefaulttheme";

			/// <summary>logoid</summary>
			public const string Logo = "logoid";

			/// <summary>logoidname</summary>
			public const string Logoidname = "logoidname";

			/// <summary>logotooltip</summary>
			public const string LogoTooltip = "logotooltip";

			/// <summary>maincolor</summary>
			public const string MainColor = "maincolor";

			/// <summary>modifiedby</summary>
			public const string ModifiedBy = "modifiedby";

			/// <summary>modifiedbyname</summary>
			public const string Modifiedbyname = "modifiedbyname";

			/// <summary>modifiedbyyominame</summary>
			public const string Modifiedbyyominame = "modifiedbyyominame";

			/// <summary>modifiedon</summary>
			public const string ModifiedOn = "modifiedon";

			/// <summary>modifiedonbehalfby</summary>
			public const string ModifiedByDelegate = "modifiedonbehalfby";

			/// <summary>modifiedonbehalfbyname</summary>
			public const string Modifiedonbehalfbyname = "modifiedonbehalfbyname";

			/// <summary>modifiedonbehalfbyyominame</summary>
			public const string Modifiedonbehalfbyyominame = "modifiedonbehalfbyyominame";

			/// <summary>name</summary>
			public const string ThemeName = "name";

			/// <summary>navbarbackgroundcolor</summary>
			public const string NavigationBarFillColor = "navbarbackgroundcolor";

			/// <summary>navbarshelfcolor</summary>
			public const string NavigationBarShelfFillColor = "navbarshelfcolor";

			/// <summary>organizationid</summary>
			public const string OrganizationId = "organizationid";

			/// <summary>organizationidname</summary>
			public const string Organizationidname = "organizationidname";

			/// <summary>overriddencreatedon</summary>
			public const string RecordCreatedOn = "overriddencreatedon";

			/// <summary>pageheaderbackgroundcolor</summary>
			public const string PageHeaderFillColor = "pageheaderbackgroundcolor";

			/// <summary>panelheaderbackgroundcolor</summary>
			public const string PanelHeaderFillColor = "panelheaderbackgroundcolor";

			/// <summary>processcontrolcolor</summary>
			public const string LegacyAccentColor = "processcontrolcolor";

			/// <summary>selectedlinkeffect</summary>
			public const string SelectedLinkColor = "selectedlinkeffect";

			/// <summary>statecode</summary>
			public const string Status = "statecode";

			/// <summary>statuscode</summary>
			public const string StatusReason = "statuscode";

			/// <summary>themeid</summary>
			public const string ThemeId = "themeid";

			/// <summary>timezoneruleversionnumber</summary>
			public const string TimeZoneRuleVersionNumber = "timezoneruleversionnumber";

			/// <summary>transactioncurrencyid</summary>
			public const string Currency = "transactioncurrencyid";

			/// <summary>transactioncurrencyidname</summary>
			public const string Transactioncurrencyidname = "transactioncurrencyidname";

			/// <summary>type</summary>
			public const string Type = "type";

			/// <summary>utcconversiontimezonecode</summary>
			public const string UTCConversionTimeZoneCode = "utcconversiontimezonecode";

			/// <summary>versionnumber</summary>
			public const string Versionnumber = "versionnumber";

		}
		#endregion

		#region Schemas
		public static class Schemas 
		{
			/// <summary>1:N theme_AsyncOperations</summary>
			public const string ThemeAsyncOperations = "theme_AsyncOperations";

			/// <summary>1:N theme_BulkDeleteFailures</summary>
			public const string ThemeBulkDeleteFailures = "theme_BulkDeleteFailures";

			/// <summary>1:N theme_ProcessSession</summary>
			public const string ThemeProcessSession = "theme_ProcessSession";

		}
		#endregion
	}
}

