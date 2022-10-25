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
	[EntityLogicalName("savedquery")]
	public sealed class View : Entity
	{	
		public static readonly int? EntityTypeCode = 1039;
		public new const string LogicalName = "savedquery";
		public const string PrimaryIdAttribute = "savedqueryid";
		public const string PrimaryNameAttribute = "name";
	
		public View() : base("savedquery") { }

		#region Attributes
		/// <summary>
        /// advancedgroupby
        /// </summary>
		[DisplayName("Advanced Group By")]
		[AttributeLogicalName("advancedgroupby")]
		public string AdvancedGroupBy
		{	
			get { return GetAttributeValue<string>("advancedgroupby"); }
			set
			{ 
				if(value == AdvancedGroupBy) return;
				SetAttributeValue("advancedgroupby", value);
			}
		}	
			
		/// <summary>
        /// columnsetxml
        /// </summary>
		[DisplayName("Column Set XML")]
		[AttributeLogicalName("columnsetxml")]
		public string ColumnSetXML
		{	
			get { return GetAttributeValue<string>("columnsetxml"); }
			set
			{ 
				if(value == ColumnSetXML) return;
				SetAttributeValue("columnsetxml", value);
			}
		}	
			
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
        /// conditionalformatting
        /// </summary>
		[DisplayName("Conditional formatting")]
		[AttributeLogicalName("conditionalformatting")]
		public string ConditionalFormatting
		{	
			get { return GetAttributeValue<string>("conditionalformatting"); }
			set
			{ 
				if(value == ConditionalFormatting) return;
				SetAttributeValue("conditionalformatting", value);
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
        /// fetchxml
        /// </summary>
		[DisplayName("Fetch XML")]
		[AttributeLogicalName("fetchxml")]
		public string FetchXML
		{	
			get { return GetAttributeValue<string>("fetchxml"); }
			set
			{ 
				if(value == FetchXML) return;
				SetAttributeValue("fetchxml", value);
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
        /// iscustom
        /// </summary>
		[DisplayName("Is Custom")]
		[AttributeLogicalName("iscustom")]
		public bool? IsCustom
		{	
			get { return GetAttributeValue<bool?>("iscustom"); }
			set
			{ 
				if(value == IsCustom) return;
				SetAttributeValue("iscustom", value);
			}
		}	
			
		/// <summary>
        /// isdefault
        /// </summary>
		[DisplayName("Default")]
		[AttributeLogicalName("isdefault")]
		public bool? Default
		{	
			get { return GetAttributeValue<bool?>("isdefault"); }
			set
			{ 
				if(value == Default) return;
				SetAttributeValue("isdefault", value);
			}
		}	
			
		/// <summary>
        /// ismanaged
        /// </summary>
		[DisplayName("State")]
		[AttributeLogicalName("ismanaged")]
		public bool? State
		{	
			get { return GetAttributeValue<bool?>("ismanaged"); }
			set
			{ 
				if(value == State) return;
				SetAttributeValue("ismanaged", value);
			}
		}	
			
		/// <summary>
        /// isprivate
        /// </summary>
		[DisplayName("Is Private")]
		[AttributeLogicalName("isprivate")]
		public bool? IsPrivate
		{	
			get { return GetAttributeValue<bool?>("isprivate"); }
			set
			{ 
				if(value == IsPrivate) return;
				SetAttributeValue("isprivate", value);
			}
		}	
			
		/// <summary>
        /// isquickfindquery
        /// </summary>
		[DisplayName("Quick Find Compatible")]
		[AttributeLogicalName("isquickfindquery")]
		public bool? QuickFindCompatible
		{	
			get { return GetAttributeValue<bool?>("isquickfindquery"); }
			set
			{ 
				if(value == QuickFindCompatible) return;
				SetAttributeValue("isquickfindquery", value);
			}
		}	
			
		/// <summary>
        /// isuserdefined
        /// </summary>
		[DisplayName("User Defined")]
		[AttributeLogicalName("isuserdefined")]
		public bool? UserDefined
		{	
			get { return GetAttributeValue<bool?>("isuserdefined"); }
			set
			{ 
				if(value == UserDefined) return;
				SetAttributeValue("isuserdefined", value);
			}
		}	
			
		/// <summary>
        /// layoutjson
        /// </summary>
		[DisplayName("Layout data in JSON format.")]
		[AttributeLogicalName("layoutjson")]
		public string LayoutDataInJSONFormat
		{	
			get { return GetAttributeValue<string>("layoutjson"); }
			set
			{ 
				if(value == LayoutDataInJSONFormat) return;
				SetAttributeValue("layoutjson", value);
			}
		}	
			
		/// <summary>
        /// layoutxml
        /// </summary>
		[DisplayName("Layout XML")]
		[AttributeLogicalName("layoutxml")]
		public string LayoutXML
		{	
			get { return GetAttributeValue<string>("layoutxml"); }
			set
			{ 
				if(value == LayoutXML) return;
				SetAttributeValue("layoutxml", value);
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
        /// offlinesqlquery
        /// </summary>
		[DisplayName("Offline SQL Query")]
		[AttributeLogicalName("offlinesqlquery")]
		public string OfflineSQLQuery
		{	
			get { return GetAttributeValue<string>("offlinesqlquery"); }
			set
			{ 
				if(value == OfflineSQLQuery) return;
				SetAttributeValue("offlinesqlquery", value);
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
        /// organizationtaborder
        /// </summary>
		[DisplayName("Default Organization tab order")]
		[AttributeLogicalName("organizationtaborder")]
		public int? DefaultOrganizationTabOrder
		{	
			get { return GetAttributeValue<int?>("organizationtaborder"); }
			set
			{ 
				if(value == DefaultOrganizationTabOrder) return;
				SetAttributeValue("organizationtaborder", value);
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
        /// queryapi
        /// </summary>
		[DisplayName("Query API")]
		[AttributeLogicalName("queryapi")]
		public string QueryAPI
		{	
			get { return GetAttributeValue<string>("queryapi"); }
			set
			{ 
				if(value == QueryAPI) return;
				SetAttributeValue("queryapi", value);
			}
		}	
			
		/// <summary>
        /// queryappusage
        /// </summary>
		[DisplayName("Query Application Usage")]
		[AttributeLogicalName("queryappusage")]
		public int? QueryApplicationUsage
		{	
			get { return GetAttributeValue<int?>("queryappusage"); }
			set
			{ 
				if(value == QueryApplicationUsage) return;
				SetAttributeValue("queryappusage", value);
			}
		}	
			
		/// <summary>
        /// querytype
        /// </summary>
		[DisplayName("Query Type")]
		[AttributeLogicalName("querytype")]
		public int? QueryType
		{	
			get { return GetAttributeValue<int?>("querytype"); }
			set
			{ 
				if(value == QueryType) return;
				SetAttributeValue("querytype", value);
			}
		}	
			
		/// <summary>
        /// returnedtypecode
        /// </summary>
		[DisplayName("Entity Name")]
		[AttributeLogicalName("returnedtypecode")]
		public string EntityName
		{	
			get { return GetAttributeValue<string>("returnedtypecode"); }
			set
			{ 
				if(value == EntityName) return;
				SetAttributeValue("returnedtypecode", value);
			}
		}	
			
		/// <summary>
        /// savedqueryid
        /// </summary>
		[DisplayName("View")]
		[AttributeLogicalName("savedqueryid")]
		public override Guid Id
		{
			get => base.Id;
			set { base.Id = value; SetAttributeValue("savedqueryid", value); }
		}

							/// <summary>
        /// savedqueryidunique
        /// </summary>
		[DisplayName("savedqueryidunique")]
		[AttributeLogicalName("savedqueryidunique")]
		public Guid SavedqueryiduniqueId
		{	
			get { return GetAttributeValue<Guid>("savedqueryidunique"); }
			set
			{ 
				if(value == SavedqueryiduniqueId) return;
				SetAttributeValue("savedqueryidunique", value);
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
		[DisplayName("Version Number")]
		[AttributeLogicalName("versionnumber")]
		public int? VersionNumber
		{	
			get { return GetAttributeValue<int?>("versionnumber"); }
			set
			{ 
				if(value == VersionNumber) return;
				SetAttributeValue("versionnumber", value);
			}
		}	
			
		#endregion	

		#region Relations
			/// <summary>
        /// 1:N Get entities for 'lk_mobileofflineprofileitem_savedquery'
        /// </summary>
		[RelationshipSchemaName("lk_mobileofflineprofileitem_savedquery")]
		public IEnumerable<MobileOfflineProfileItem> LkMobileofflineprofileitemSavedquery
		{
			get { return GetRelatedEntities<MobileOfflineProfileItem>("lk_mobileofflineprofileitem_savedquery", null); }
			set { SetRelatedEntities("lk_mobileofflineprofileitem_savedquery", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'SavedQuery_AsyncOperations'
        /// </summary>
		[RelationshipSchemaName("SavedQuery_AsyncOperations")]
		public IEnumerable<SystemJob> SavedQueryAsyncOperations
		{
			get { return GetRelatedEntities<SystemJob>("SavedQuery_AsyncOperations", null); }
			set { SetRelatedEntities("SavedQuery_AsyncOperations", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'SavedQuery_BulkDeleteFailures'
        /// </summary>
		[RelationshipSchemaName("SavedQuery_BulkDeleteFailures")]
		public IEnumerable<BulkDeleteFailure> SavedQueryBulkDeleteFailures
		{
			get { return GetRelatedEntities<BulkDeleteFailure>("SavedQuery_BulkDeleteFailures", null); }
			set { SetRelatedEntities("SavedQuery_BulkDeleteFailures", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'SavedQuery_SyncErrors'
        /// </summary>
		[RelationshipSchemaName("SavedQuery_SyncErrors")]
		public IEnumerable<SyncError> SavedQuerySyncErrors
		{
			get { return GetRelatedEntities<SyncError>("SavedQuery_SyncErrors", null); }
			set { SetRelatedEntities("SavedQuery_SyncErrors", null, value); }
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
		
		public enum eStatus
		{	
		
			[Label("Active")]
			[Description(@"")]
			Active = 0, 
		
			[Label("Inactive")]
			[Description(@"")]
			Inactive = 1, 
		}
		
		public enum eStatusReason
		{	
		
			[Label("Active")]
			[Description(@"")]
			Active_Active = 1, 
		
			[Label("Inactive")]
			[Description(@"")]
			Inactive_Inactive = 2, 
		}
		
		#endregion	

		#region Properties
		public static class Properties 
		{
			/// <summary>advancedgroupby</summary>
			public const string AdvancedGroupBy = "advancedgroupby";

			/// <summary>columnsetxml</summary>
			public const string ColumnSetXML = "columnsetxml";

			/// <summary>componentstate</summary>
			public const string ComponentState = "componentstate";

			/// <summary>conditionalformatting</summary>
			public const string ConditionalFormatting = "conditionalformatting";

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

			/// <summary>description</summary>
			public const string Description = "description";

			/// <summary>fetchxml</summary>
			public const string FetchXML = "fetchxml";

			/// <summary>introducedversion</summary>
			public const string IntroducedVersion = "introducedversion";

			/// <summary>iscustom</summary>
			public const string IsCustom = "iscustom";

			/// <summary>isdefault</summary>
			public const string Default = "isdefault";

			/// <summary>ismanaged</summary>
			public const string State = "ismanaged";

			/// <summary>isprivate</summary>
			public const string IsPrivate = "isprivate";

			/// <summary>isquickfindquery</summary>
			public const string QuickFindCompatible = "isquickfindquery";

			/// <summary>isuserdefined</summary>
			public const string UserDefined = "isuserdefined";

			/// <summary>layoutjson</summary>
			public const string LayoutDataInJSONFormat = "layoutjson";

			/// <summary>layoutxml</summary>
			public const string LayoutXML = "layoutxml";

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
			public const string Name = "name";

			/// <summary>offlinesqlquery</summary>
			public const string OfflineSQLQuery = "offlinesqlquery";

			/// <summary>organizationid</summary>
			public const string Organization = "organizationid";

			/// <summary>organizationidname</summary>
			public const string Organizationidname = "organizationidname";

			/// <summary>organizationtaborder</summary>
			public const string DefaultOrganizationTabOrder = "organizationtaborder";

			/// <summary>overwritetime</summary>
			public const string RecordOverwriteTime = "overwritetime";

			/// <summary>queryapi</summary>
			public const string QueryAPI = "queryapi";

			/// <summary>queryappusage</summary>
			public const string QueryApplicationUsage = "queryappusage";

			/// <summary>querytype</summary>
			public const string QueryType = "querytype";

			/// <summary>returnedtypecode</summary>
			public const string EntityName = "returnedtypecode";

			/// <summary>savedqueryid</summary>
			public const string ViewId = "savedqueryid";

			/// <summary>savedqueryidunique</summary>
			public const string SavedqueryiduniqueId = "savedqueryidunique";

			/// <summary>solutionid</summary>
			public const string SolutionId = "solutionid";

			/// <summary>statecode</summary>
			public const string Status = "statecode";

			/// <summary>statuscode</summary>
			public const string StatusReason = "statuscode";

			/// <summary>supportingsolutionid</summary>
			public const string SolutionId2 = "supportingsolutionid";

			/// <summary>versionnumber</summary>
			public const string VersionNumber = "versionnumber";

		}
		#endregion

		#region Schemas
		public static class Schemas 
		{
			/// <summary>1:N lk_mobileofflineprofileitem_savedquery</summary>
			public const string LkMobileofflineprofileitemSavedquery = "lk_mobileofflineprofileitem_savedquery";

			/// <summary>1:N SavedQuery_AsyncOperations</summary>
			public const string SavedQueryAsyncOperations = "SavedQuery_AsyncOperations";

			/// <summary>1:N SavedQuery_BulkDeleteFailures</summary>
			public const string SavedQueryBulkDeleteFailures = "SavedQuery_BulkDeleteFailures";

			/// <summary>1:N SavedQuery_SyncErrors</summary>
			public const string SavedQuerySyncErrors = "SavedQuery_SyncErrors";

		}
		#endregion
	}
}

