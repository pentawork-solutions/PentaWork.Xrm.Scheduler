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
	[EntityLogicalName("webresource")]
	public sealed class WebResource : Entity
	{	
		public static readonly int? EntityTypeCode = 9333;
		public new const string LogicalName = "webresource";
		public const string PrimaryIdAttribute = "webresourceid";
		public const string PrimaryNameAttribute = "name";
	
		public WebResource() : base("webresource") { }

		#region Attributes
		/// <summary>
        /// componentstate
        /// </summary>
		[DisplayName("Component State")]
		[AttributeLogicalName("componentstate")]
		public egComponentState? ComponentState
		{	
			get 
			{ 
				var optionSetValue = GetAttributeValue<OptionSetValue>("componentstate");
				if (optionSetValue != null) return (egComponentState)optionSetValue.Value;
				else return null;
			}
			set 
			{ 
				if(value == ComponentState) return;

				OptionSetValue optionSetValue = null;
				if(value != null) optionSetValue = new OptionSetValue((int)value);
				SetAttributeValue("componentstate", optionSetValue); 
			}
		}

		/// <summary>
        /// content
        /// </summary>
		[DisplayName("content")]
		[AttributeLogicalName("content")]
		public string Content
		{	
			get { return GetAttributeValue<string>("content"); }
			set
			{ 
				if(value == Content) return;
				SetAttributeValue("content", value);
			}
		}	
			
		/// <summary>
        /// contentjson
        /// </summary>
		[DisplayName("contentjson")]
		[AttributeLogicalName("contentjson")]
		public string Contentjson
		{	
			get { return GetAttributeValue<string>("contentjson"); }
			set
			{ 
				if(value == Contentjson) return;
				SetAttributeValue("contentjson", value);
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
        /// dependencyxml
        /// </summary>
		[DisplayName("DependencyXML")]
		[AttributeLogicalName("dependencyxml")]
		public string DependencyXML
		{	
			get { return GetAttributeValue<string>("dependencyxml"); }
			set
			{ 
				if(value == DependencyXML) return;
				SetAttributeValue("dependencyxml", value);
			}
		}	
			
		/// <summary>
        /// description
        /// </summary>
		[DisplayName("Description")]
		[AttributeLogicalName("description")]
		public string Description
		{	
			get { return GetAttributeValue<string>("description"); }
			set
			{ 
				if(value == Description) return;
				SetAttributeValue("description", value);
			}
		}	
			
		/// <summary>
        /// displayname
        /// </summary>
		[DisplayName("Display Name")]
		[AttributeLogicalName("displayname")]
		public string DisplayName
		{	
			get { return GetAttributeValue<string>("displayname"); }
			set
			{ 
				if(value == DisplayName) return;
				SetAttributeValue("displayname", value);
			}
		}	
			
		/// <summary>
        /// introducedversion
        /// </summary>
		[DisplayName("Introduced Version")]
		[AttributeLogicalName("introducedversion")]
		public string IntroducedVersion
		{	
			get { return GetAttributeValue<string>("introducedversion"); }
			set
			{ 
				if(value == IntroducedVersion) return;
				SetAttributeValue("introducedversion", value);
			}
		}	
			
		/// <summary>
        /// isavailableformobileoffline
        /// </summary>
		[DisplayName("Is Available For Mobile Offline")]
		[AttributeLogicalName("isavailableformobileoffline")]
		public bool? IsAvailableForMobileOffline
		{	
			get { return GetAttributeValue<bool?>("isavailableformobileoffline"); }
			set
			{ 
				if(value == IsAvailableForMobileOffline) return;
				SetAttributeValue("isavailableformobileoffline", value);
			}
		}	
			
		/// <summary>
        /// isenabledformobileclient
        /// </summary>
		[DisplayName("Is Enabled For Mobile Client")]
		[AttributeLogicalName("isenabledformobileclient")]
		public bool? IsEnabledForMobileClient
		{	
			get { return GetAttributeValue<bool?>("isenabledformobileclient"); }
			set
			{ 
				if(value == IsEnabledForMobileClient) return;
				SetAttributeValue("isenabledformobileclient", value);
			}
		}	
			
		/// <summary>
        /// ismanaged
        /// </summary>
		[DisplayName("ismanaged")]
		[AttributeLogicalName("ismanaged")]
		public bool? Ismanaged
		{	
			get { return GetAttributeValue<bool?>("ismanaged"); }
			set
			{ 
				if(value == Ismanaged) return;
				SetAttributeValue("ismanaged", value);
			}
		}	
			
		/// <summary>
        /// languagecode
        /// </summary>
		[DisplayName("Language")]
		[AttributeLogicalName("languagecode")]
		public int? Language
		{	
			get { return GetAttributeValue<int?>("languagecode"); }
			set
			{ 
				if(value == Language) return;
				SetAttributeValue("languagecode", value);
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
		[DisplayName("Created By (Delegate)")]
		[AttributeLogicalName("modifiedonbehalfby")]
		public EntityReference CreatedByDelegate2
		{	
			get { return GetAttributeValue<EntityReference>("modifiedonbehalfby"); }
			set
			{ 
				if(value == CreatedByDelegate2) return;
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
        /// overwritetime
        /// </summary>
		[DisplayName("Record Overwrite Time")]
		[AttributeLogicalName("overwritetime")]
		public DateTime? RecordOverwriteTime
		{	
			get { return GetAttributeValue<DateTime?>("overwritetime"); }
			set
			{ 
				if(value == RecordOverwriteTime) return;
				SetAttributeValue("overwritetime", value);
			}
		}	
			
		/// <summary>
        /// silverlightversion
        /// </summary>
		[DisplayName("Silverlight Version")]
		[AttributeLogicalName("silverlightversion")]
		public string SilverlightVersion
		{	
			get { return GetAttributeValue<string>("silverlightversion"); }
			set
			{ 
				if(value == SilverlightVersion) return;
				SetAttributeValue("silverlightversion", value);
			}
		}	
			
		/// <summary>
        /// solutionid
        /// </summary>
		[DisplayName("Solution")]
		[AttributeLogicalName("solutionid")]
		public Guid SolutionId
		{	
			get { return GetAttributeValue<Guid>("solutionid"); }
			set
			{ 
				if(value == SolutionId) return;
				SetAttributeValue("solutionid", value);
			}
		}	
			
		/// <summary>
        /// supportingsolutionid
        /// </summary>
		[DisplayName("Solution")]
		[AttributeLogicalName("supportingsolutionid")]
		public Guid SolutionId2
		{	
			get { return GetAttributeValue<Guid>("supportingsolutionid"); }
			set
			{ 
				if(value == SolutionId2) return;
				SetAttributeValue("supportingsolutionid", value);
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
			
		/// <summary>
        /// webresourceid
        /// </summary>
		[DisplayName("Web Resource Identifier")]
		[AttributeLogicalName("webresourceid")]
		public override Guid Id
		{
			get => base.Id;
			set { base.Id = value; SetAttributeValue("webresourceid", value); }
		}

							/// <summary>
        /// webresourceidunique
        /// </summary>
		[DisplayName("webresourceidunique")]
		[AttributeLogicalName("webresourceidunique")]
		public Guid WebresourceiduniqueId
		{	
			get { return GetAttributeValue<Guid>("webresourceidunique"); }
			set
			{ 
				if(value == WebresourceiduniqueId) return;
				SetAttributeValue("webresourceidunique", value);
			}
		}	
			
		/// <summary>
        /// webresourcetype
        /// </summary>
		[DisplayName("Type")]
		[AttributeLogicalName("webresourcetype")]
		public eType? Type
		{	
			get 
			{ 
				var optionSetValue = GetAttributeValue<OptionSetValue>("webresourcetype");
				if (optionSetValue != null) return (eType)optionSetValue.Value;
				else return null;
			}
			set 
			{ 
				if(value == Type) return;

				OptionSetValue optionSetValue = null;
				if(value != null) optionSetValue = new OptionSetValue((int)value);
				SetAttributeValue("webresourcetype", optionSetValue); 
			}
		}

		#endregion	

		#region Relations
			/// <summary>
        /// 1:N Get entities for 'lk_theme_logoid'
        /// </summary>
		[RelationshipSchemaName("lk_theme_logoid")]
		public IEnumerable<Theme> LkThemeLogoid
		{
			get { return GetRelatedEntities<Theme>("lk_theme_logoid", null); }
			set { SetRelatedEntities("lk_theme_logoid", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'solution_configuration_webresource'
        /// </summary>
		[RelationshipSchemaName("solution_configuration_webresource")]
		public IEnumerable<Solution> SolutionConfigurationWebresource
		{
			get { return GetRelatedEntities<Solution>("solution_configuration_webresource", null); }
			set { SetRelatedEntities("solution_configuration_webresource", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'webresource_savedqueryvisualizations'
        /// </summary>
		[RelationshipSchemaName("webresource_savedqueryvisualizations")]
		public IEnumerable<SystemChart> WebresourceSavedqueryvisualizations
		{
			get { return GetRelatedEntities<SystemChart>("webresource_savedqueryvisualizations", null); }
			set { SetRelatedEntities("webresource_savedqueryvisualizations", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'webresource_userqueryvisualizations'
        /// </summary>
		[RelationshipSchemaName("webresource_userqueryvisualizations")]
		public IEnumerable<UserChart> WebresourceUserqueryvisualizations
		{
			get { return GetRelatedEntities<UserChart>("webresource_userqueryvisualizations", null); }
			set { SetRelatedEntities("webresource_userqueryvisualizations", null, value); }
		}
		#endregion

		#region Actions
		#endregion

		#region OptionSetEnums
		public enum egComponentState
		{	
		
			[Label("Published")]
			[Description(@"")]
			Published = 0, 
		
			[Label("Unpublished")]
			[Description(@"")]
			Unpublished = 1, 
		
			[Label("Deleted")]
			[Description(@"")]
			Deleted = 2, 
		
			[Label("Deleted Unpublished")]
			[Description(@"")]
			DeletedUnpublished = 3, 
		}
		
		public enum eType
		{	
		
			[Label("Webpage (HTML)")]
			[Description(@"")]
			WebpageHTML = 1, 
		
			[Label("Style Sheet (CSS)")]
			[Description(@"")]
			StyleSheetCSS = 2, 
		
			[Label("Script (JScript)")]
			[Description(@"")]
			ScriptJScript = 3, 
		
			[Label("Data (XML)")]
			[Description(@"")]
			DataXML = 4, 
		
			[Label("PNG format")]
			[Description(@"")]
			PNGFormat = 5, 
		
			[Label("JPG format")]
			[Description(@"")]
			JPGFormat = 6, 
		
			[Label("GIF format")]
			[Description(@"")]
			GIFFormat = 7, 
		
			[Label("Silverlight (XAP)")]
			[Description(@"")]
			SilverlightXAP = 8, 
		
			[Label("Style Sheet (XSL)")]
			[Description(@"")]
			StyleSheetXSL = 9, 
		
			[Label("ICO format")]
			[Description(@"")]
			ICOFormat = 10, 
		
			[Label("Vector format (SVG)")]
			[Description(@"")]
			VectorFormatSVG = 11, 
		
			[Label("String (RESX)")]
			[Description(@"")]
			StringRESX = 12, 
		}
		
		#endregion	

		#region Properties
		public static class Properties 
		{
			/// <summary>componentstate</summary>
			public const string ComponentState = "componentstate";

			/// <summary>content</summary>
			public const string Content = "content";

			/// <summary>contentjson</summary>
			public const string Contentjson = "contentjson";

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

			/// <summary>dependencyxml</summary>
			public const string DependencyXML = "dependencyxml";

			/// <summary>description</summary>
			public const string Description = "description";

			/// <summary>displayname</summary>
			public const string DisplayName = "displayname";

			/// <summary>introducedversion</summary>
			public const string IntroducedVersion = "introducedversion";

			/// <summary>isavailableformobileoffline</summary>
			public const string IsAvailableForMobileOffline = "isavailableformobileoffline";

			/// <summary>isenabledformobileclient</summary>
			public const string IsEnabledForMobileClient = "isenabledformobileclient";

			/// <summary>ismanaged</summary>
			public const string Ismanaged = "ismanaged";

			/// <summary>languagecode</summary>
			public const string Language = "languagecode";

			/// <summary>modifiedby</summary>
			public const string ModifiedBy = "modifiedby";

			/// <summary>modifiedon</summary>
			public const string ModifiedOn = "modifiedon";

			/// <summary>modifiedonbehalfby</summary>
			public const string CreatedByDelegate2 = "modifiedonbehalfby";

			/// <summary>modifiedonbehalfbyname</summary>
			public const string Modifiedonbehalfbyname = "modifiedonbehalfbyname";

			/// <summary>modifiedonbehalfbyyominame</summary>
			public const string Modifiedonbehalfbyyominame = "modifiedonbehalfbyyominame";

			/// <summary>name</summary>
			public const string Name = "name";

			/// <summary>organizationid</summary>
			public const string Organization = "organizationid";

			/// <summary>organizationidname</summary>
			public const string Organizationidname = "organizationidname";

			/// <summary>overwritetime</summary>
			public const string RecordOverwriteTime = "overwritetime";

			/// <summary>silverlightversion</summary>
			public const string SilverlightVersion = "silverlightversion";

			/// <summary>solutionid</summary>
			public const string SolutionId = "solutionid";

			/// <summary>supportingsolutionid</summary>
			public const string SolutionId2 = "supportingsolutionid";

			/// <summary>versionnumber</summary>
			public const string Versionnumber = "versionnumber";

			/// <summary>webresourceid</summary>
			public const string WebResourceIdentifierId = "webresourceid";

			/// <summary>webresourceidunique</summary>
			public const string WebresourceiduniqueId = "webresourceidunique";

			/// <summary>webresourcetype</summary>
			public const string Type = "webresourcetype";

		}
		#endregion

		#region Schemas
		public static class Schemas 
		{
			/// <summary>1:N lk_theme_logoid</summary>
			public const string LkThemeLogoid = "lk_theme_logoid";

			/// <summary>1:N solution_configuration_webresource</summary>
			public const string SolutionConfigurationWebresource = "solution_configuration_webresource";

			/// <summary>1:N webresource_savedqueryvisualizations</summary>
			public const string WebresourceSavedqueryvisualizations = "webresource_savedqueryvisualizations";

			/// <summary>1:N webresource_userqueryvisualizations</summary>
			public const string WebresourceUserqueryvisualizations = "webresource_userqueryvisualizations";

		}
		#endregion
	}
}

