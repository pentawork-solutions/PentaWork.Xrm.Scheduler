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
	[EntityLogicalName("userquery")]
	public sealed class SavedView : Entity
	{	
		public static readonly int? EntityTypeCode = 4230;
		public new const string LogicalName = "userquery";
		public const string PrimaryIdAttribute = "userqueryid";
		public const string PrimaryNameAttribute = "name";
	
		public SavedView() : base("userquery") { }

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
        /// conditionalformatting
        /// </summary>
		[DisplayName("User Group By")]
		[AttributeLogicalName("conditionalformatting")]
		public string UserGroupBy
		{	
			get { return GetAttributeValue<string>("conditionalformatting"); }
			set
			{ 
				if(value == UserGroupBy) return;
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
		[DisplayName("Last Modified")]
		[AttributeLogicalName("modifiedon")]
		public DateTime? LastModified
		{	
			get { return GetAttributeValue<DateTime?>("modifiedon"); }
			set
			{ 
				if(value == LastModified) return;
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
        /// ownerid
        /// </summary>
		[DisplayName("Owner")]
		[AttributeLogicalName("ownerid")]
		public EntityReference Owner
		{	
			get { return GetAttributeValue<EntityReference>("ownerid"); }
			set
			{ 
				if(value == Owner) return;
				SetAttributeValue("ownerid", value);
			}
		}	
			
		/// <summary>
        /// owneridname
        /// </summary>
		[DisplayName("owneridname")]
		[AttributeLogicalName("owneridname")]
		public string Owneridname
		{	
			get { return GetAttributeValue<string>("owneridname"); }
			set
			{ 
				if(value == Owneridname) return;
				SetAttributeValue("owneridname", value);
			}
		}	
			
		/// <summary>
        /// owneridtype
        /// </summary>
		[DisplayName("owneridtype")]
		[AttributeLogicalName("owneridtype")]
		public string Owneridtype
		{	
			get { return GetAttributeValue<string>("owneridtype"); }
			set
			{ 
				if(value == Owneridtype) return;
				SetAttributeValue("owneridtype", value);
			}
		}	
			
		/// <summary>
        /// owneridyominame
        /// </summary>
		[DisplayName("owneridyominame")]
		[AttributeLogicalName("owneridyominame")]
		public string Owneridyominame
		{	
			get { return GetAttributeValue<string>("owneridyominame"); }
			set
			{ 
				if(value == Owneridyominame) return;
				SetAttributeValue("owneridyominame", value);
			}
		}	
			
		/// <summary>
        /// owningbusinessunit
        /// </summary>
		[DisplayName("Owning Business Unit")]
		[AttributeLogicalName("owningbusinessunit")]
		public EntityReference OwningBusinessUnit
		{	
			get { return GetAttributeValue<EntityReference>("owningbusinessunit"); }
			set
			{ 
				if(value == OwningBusinessUnit) return;
				SetAttributeValue("owningbusinessunit", value);
			}
		}	
			
		/// <summary>
        /// owningteam
        /// </summary>
		[DisplayName("Owning Team")]
		[AttributeLogicalName("owningteam")]
		public EntityReference OwningTeam
		{	
			get { return GetAttributeValue<EntityReference>("owningteam"); }
			set
			{ 
				if(value == OwningTeam) return;
				SetAttributeValue("owningteam", value);
			}
		}	
			
		/// <summary>
        /// owninguser
        /// </summary>
		[DisplayName("Owning User")]
		[AttributeLogicalName("owninguser")]
		public EntityReference OwningUser
		{	
			get { return GetAttributeValue<EntityReference>("owninguser"); }
			set
			{ 
				if(value == OwningUser) return;
				SetAttributeValue("owninguser", value);
			}
		}	
			
		/// <summary>
        /// parentqueryid
        /// </summary>
		[DisplayName("Parent Query")]
		[AttributeLogicalName("parentqueryid")]
		public EntityReference ParentQuery
		{	
			get { return GetAttributeValue<EntityReference>("parentqueryid"); }
			set
			{ 
				if(value == ParentQuery) return;
				SetAttributeValue("parentqueryid", value);
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
		[DisplayName("Returned Type")]
		[AttributeLogicalName("returnedtypecode")]
		public string ReturnedType
		{	
			get { return GetAttributeValue<string>("returnedtypecode"); }
			set
			{ 
				if(value == ReturnedType) return;
				SetAttributeValue("returnedtypecode", value);
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
        /// userqueryid
        /// </summary>
		[DisplayName("User Query")]
		[AttributeLogicalName("userqueryid")]
		public override Guid Id
		{
			get => base.Id;
			set { base.Id = value; SetAttributeValue("userqueryid", value); }
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
        /// 1:N Get entities for 'UserQuery_AsyncOperations'
        /// </summary>
		[RelationshipSchemaName("UserQuery_AsyncOperations")]
		public IEnumerable<SystemJob> UserQueryAsyncOperations
		{
			get { return GetRelatedEntities<SystemJob>("UserQuery_AsyncOperations", null); }
			set { SetRelatedEntities("UserQuery_AsyncOperations", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'UserQuery_BulkDeleteFailures'
        /// </summary>
		[RelationshipSchemaName("UserQuery_BulkDeleteFailures")]
		public IEnumerable<BulkDeleteFailure> UserQueryBulkDeleteFailures
		{
			get { return GetRelatedEntities<BulkDeleteFailure>("UserQuery_BulkDeleteFailures", null); }
			set { SetRelatedEntities("UserQuery_BulkDeleteFailures", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'UserQuery_SyncErrors'
        /// </summary>
		[RelationshipSchemaName("UserQuery_SyncErrors")]
		public IEnumerable<SyncError> UserQuerySyncErrors
		{
			get { return GetRelatedEntities<SyncError>("UserQuery_SyncErrors", null); }
			set { SetRelatedEntities("UserQuery_SyncErrors", null, value); }
		}
		#endregion

		#region Actions
		#endregion

		#region OptionSetEnums
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
		
			[Label("All")]
			[Description(@"")]
			All_Active = 3, 
		
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

			/// <summary>conditionalformatting</summary>
			public const string UserGroupBy = "conditionalformatting";

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
			public const string LastModified = "modifiedon";

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

			/// <summary>ownerid</summary>
			public const string Owner = "ownerid";

			/// <summary>owneridname</summary>
			public const string Owneridname = "owneridname";

			/// <summary>owneridtype</summary>
			public const string Owneridtype = "owneridtype";

			/// <summary>owneridyominame</summary>
			public const string Owneridyominame = "owneridyominame";

			/// <summary>owningbusinessunit</summary>
			public const string OwningBusinessUnit = "owningbusinessunit";

			/// <summary>owningteam</summary>
			public const string OwningTeam = "owningteam";

			/// <summary>owninguser</summary>
			public const string OwningUser = "owninguser";

			/// <summary>parentqueryid</summary>
			public const string ParentQuery = "parentqueryid";

			/// <summary>querytype</summary>
			public const string QueryType = "querytype";

			/// <summary>returnedtypecode</summary>
			public const string ReturnedType = "returnedtypecode";

			/// <summary>statecode</summary>
			public const string Status = "statecode";

			/// <summary>statuscode</summary>
			public const string StatusReason = "statuscode";

			/// <summary>userqueryid</summary>
			public const string UserQueryId = "userqueryid";

			/// <summary>versionnumber</summary>
			public const string VersionNumber = "versionnumber";

		}
		#endregion

		#region Schemas
		public static class Schemas 
		{
			/// <summary>1:N UserQuery_AsyncOperations</summary>
			public const string UserQueryAsyncOperations = "UserQuery_AsyncOperations";

			/// <summary>1:N UserQuery_BulkDeleteFailures</summary>
			public const string UserQueryBulkDeleteFailures = "UserQuery_BulkDeleteFailures";

			/// <summary>1:N UserQuery_SyncErrors</summary>
			public const string UserQuerySyncErrors = "UserQuery_SyncErrors";

		}
		#endregion
	}
}

