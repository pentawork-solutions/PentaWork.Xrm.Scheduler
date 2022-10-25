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
	[EntityLogicalName("datalakeworkspacepermission")]
	public sealed class DataLakeWorkspacePermission : Entity
	{	
		public static readonly int? EntityTypeCode = 10016;
		public new const string LogicalName = "datalakeworkspacepermission";
		public const string PrimaryIdAttribute = "datalakeworkspacepermissionid";
		public const string PrimaryNameAttribute = "name";
	
		public DataLakeWorkspacePermission() : base("datalakeworkspacepermission") { }

		#region Attributes
		/// <summary>
        /// appid
        /// </summary>
		[DisplayName("App Id")]
		[AttributeLogicalName("appid")]
		public Guid AppId
		{	
			get { return GetAttributeValue<Guid>("appid"); }
			set
			{ 
				if(value == AppId) return;
				SetAttributeValue("appid", value);
			}
		}	
			
		/// <summary>
        /// canexecute
        /// </summary>
		[DisplayName("Can Execute")]
		[AttributeLogicalName("canexecute")]
		public bool? CanExecute
		{	
			get { return GetAttributeValue<bool?>("canexecute"); }
			set
			{ 
				if(value == CanExecute) return;
				SetAttributeValue("canexecute", value);
			}
		}	
			
		/// <summary>
        /// canread
        /// </summary>
		[DisplayName("Can Read")]
		[AttributeLogicalName("canread")]
		public bool? CanRead
		{	
			get { return GetAttributeValue<bool?>("canread"); }
			set
			{ 
				if(value == CanRead) return;
				SetAttributeValue("canread", value);
			}
		}	
			
		/// <summary>
        /// canwrite
        /// </summary>
		[DisplayName("Can Write")]
		[AttributeLogicalName("canwrite")]
		public bool? CanWrite
		{	
			get { return GetAttributeValue<bool?>("canwrite"); }
			set
			{ 
				if(value == CanWrite) return;
				SetAttributeValue("canwrite", value);
			}
		}	
			
		/// <summary>
        /// componentidunique
        /// </summary>
		[DisplayName("Row id unique")]
		[AttributeLogicalName("componentidunique")]
		public Guid RowIdUniqueId
		{	
			get { return GetAttributeValue<Guid>("componentidunique"); }
			set
			{ 
				if(value == RowIdUniqueId) return;
				SetAttributeValue("componentidunique", value);
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
        /// datalakeworkspacepermission_uniquename
        /// </summary>
		[DisplayName("Unique Name")]
		[AttributeLogicalName("datalakeworkspacepermission_uniquename")]
		public string UniqueName
		{	
			get { return GetAttributeValue<string>("datalakeworkspacepermission_uniquename"); }
			set
			{ 
				if(value == UniqueName) return;
				SetAttributeValue("datalakeworkspacepermission_uniquename", value);
			}
		}	
			
		/// <summary>
        /// datalakeworkspacepermissionid
        /// </summary>
		[DisplayName("Data Lake Workspace Permission")]
		[AttributeLogicalName("datalakeworkspacepermissionid")]
		public override Guid Id
		{
			get => base.Id;
			set { base.Id = value; SetAttributeValue("datalakeworkspacepermissionid", value); }
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
        /// ismanaged
        /// </summary>
		[DisplayName("Is Managed")]
		[AttributeLogicalName("ismanaged")]
		public bool? IsManaged
		{	
			get { return GetAttributeValue<bool?>("ismanaged"); }
			set
			{ 
				if(value == IsManaged) return;
				SetAttributeValue("ismanaged", value);
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
        /// tenantid
        /// </summary>
		[DisplayName("Tenant Id")]
		[AttributeLogicalName("tenantid")]
		public Guid TenantId
		{	
			get { return GetAttributeValue<Guid>("tenantid"); }
			set
			{ 
				if(value == TenantId) return;
				SetAttributeValue("tenantid", value);
			}
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
			
		/// <summary>
        /// whitelistedappid
        /// </summary>
		[DisplayName("Whitelisted App ID")]
		[AttributeLogicalName("whitelistedappid")]
		public Guid WhitelistedAppId
		{	
			get { return GetAttributeValue<Guid>("whitelistedappid"); }
			set
			{ 
				if(value == WhitelistedAppId) return;
				SetAttributeValue("whitelistedappid", value);
			}
		}	
			
		/// <summary>
        /// workspaceid
        /// </summary>
		[DisplayName("Workspace Id")]
		[AttributeLogicalName("workspaceid")]
		public EntityReference WorkspaceId
		{	
			get { return GetAttributeValue<EntityReference>("workspaceid"); }
			set
			{ 
				if(value == WorkspaceId) return;
				SetAttributeValue("workspaceid", value);
			}
		}	
			
		/// <summary>
        /// workspaceidname
        /// </summary>
		[DisplayName("workspaceidname")]
		[AttributeLogicalName("workspaceidname")]
		public string Workspaceidname
		{	
			get { return GetAttributeValue<string>("workspaceidname"); }
			set
			{ 
				if(value == Workspaceidname) return;
				SetAttributeValue("workspaceidname", value);
			}
		}	
			
		#endregion	

		#region Relations
			/// <summary>
        /// 1:N Get entities for 'datalakeworkspacepermission_AsyncOperations'
        /// </summary>
		[RelationshipSchemaName("datalakeworkspacepermission_AsyncOperations")]
		public IEnumerable<SystemJob> DatalakeworkspacepermissionAsyncOperations
		{
			get { return GetRelatedEntities<SystemJob>("datalakeworkspacepermission_AsyncOperations", null); }
			set { SetRelatedEntities("datalakeworkspacepermission_AsyncOperations", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'datalakeworkspacepermission_BulkDeleteFailures'
        /// </summary>
		[RelationshipSchemaName("datalakeworkspacepermission_BulkDeleteFailures")]
		public IEnumerable<BulkDeleteFailure> DatalakeworkspacepermissionBulkDeleteFailures
		{
			get { return GetRelatedEntities<BulkDeleteFailure>("datalakeworkspacepermission_BulkDeleteFailures", null); }
			set { SetRelatedEntities("datalakeworkspacepermission_BulkDeleteFailures", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'datalakeworkspacepermission_DuplicateBaseRecord'
        /// </summary>
		[RelationshipSchemaName("datalakeworkspacepermission_DuplicateBaseRecord")]
		public IEnumerable<DuplicateRecord> DatalakeworkspacepermissionDuplicateBaseRecord
		{
			get { return GetRelatedEntities<DuplicateRecord>("datalakeworkspacepermission_DuplicateBaseRecord", null); }
			set { SetRelatedEntities("datalakeworkspacepermission_DuplicateBaseRecord", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'datalakeworkspacepermission_DuplicateMatchingRecord'
        /// </summary>
		[RelationshipSchemaName("datalakeworkspacepermission_DuplicateMatchingRecord")]
		public IEnumerable<DuplicateRecord> DatalakeworkspacepermissionDuplicateMatchingRecord
		{
			get { return GetRelatedEntities<DuplicateRecord>("datalakeworkspacepermission_DuplicateMatchingRecord", null); }
			set { SetRelatedEntities("datalakeworkspacepermission_DuplicateMatchingRecord", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'datalakeworkspacepermission_MailboxTrackingFolders'
        /// </summary>
		[RelationshipSchemaName("datalakeworkspacepermission_MailboxTrackingFolders")]
		public IEnumerable<MailboxAutoTrackingFolder> DatalakeworkspacepermissionMailboxTrackingFolders
		{
			get { return GetRelatedEntities<MailboxAutoTrackingFolder>("datalakeworkspacepermission_MailboxTrackingFolders", null); }
			set { SetRelatedEntities("datalakeworkspacepermission_MailboxTrackingFolders", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'datalakeworkspacepermission_PrincipalObjectAttributeAccesses'
        /// </summary>
		[RelationshipSchemaName("datalakeworkspacepermission_PrincipalObjectAttributeAccesses")]
		public IEnumerable<FieldSharing> DatalakeworkspacepermissionPrincipalObjectAttributeAccesses
		{
			get { return GetRelatedEntities<FieldSharing>("datalakeworkspacepermission_PrincipalObjectAttributeAccesses", null); }
			set { SetRelatedEntities("datalakeworkspacepermission_PrincipalObjectAttributeAccesses", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'datalakeworkspacepermission_ProcessSession'
        /// </summary>
		[RelationshipSchemaName("datalakeworkspacepermission_ProcessSession")]
		public IEnumerable<ProcessSession> DatalakeworkspacepermissionProcessSession
		{
			get { return GetRelatedEntities<ProcessSession>("datalakeworkspacepermission_ProcessSession", null); }
			set { SetRelatedEntities("datalakeworkspacepermission_ProcessSession", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'datalakeworkspacepermission_SyncErrors'
        /// </summary>
		[RelationshipSchemaName("datalakeworkspacepermission_SyncErrors")]
		public IEnumerable<SyncError> DatalakeworkspacepermissionSyncErrors
		{
			get { return GetRelatedEntities<SyncError>("datalakeworkspacepermission_SyncErrors", null); }
			set { SetRelatedEntities("datalakeworkspacepermission_SyncErrors", null, value); }
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
			/// <summary>appid</summary>
			public const string AppId = "appid";

			/// <summary>canexecute</summary>
			public const string CanExecute = "canexecute";

			/// <summary>canread</summary>
			public const string CanRead = "canread";

			/// <summary>canwrite</summary>
			public const string CanWrite = "canwrite";

			/// <summary>componentidunique</summary>
			public const string RowIdUniqueId = "componentidunique";

			/// <summary>componentstate</summary>
			public const string ComponentState = "componentstate";

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

			/// <summary>datalakeworkspacepermission_uniquename</summary>
			public const string UniqueName = "datalakeworkspacepermission_uniquename";

			/// <summary>datalakeworkspacepermissionid</summary>
			public const string DataLakeWorkspacePermissionId = "datalakeworkspacepermissionid";

			/// <summary>importsequencenumber</summary>
			public const string ImportSequenceNumber = "importsequencenumber";

			/// <summary>ismanaged</summary>
			public const string IsManaged = "ismanaged";

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

			/// <summary>organizationid</summary>
			public const string OrganizationId = "organizationid";

			/// <summary>organizationidname</summary>
			public const string Organizationidname = "organizationidname";

			/// <summary>overriddencreatedon</summary>
			public const string RecordCreatedOn = "overriddencreatedon";

			/// <summary>overwritetime</summary>
			public const string RecordOverwriteTime = "overwritetime";

			/// <summary>solutionid</summary>
			public const string SolutionId = "solutionid";

			/// <summary>statecode</summary>
			public const string Status = "statecode";

			/// <summary>statuscode</summary>
			public const string StatusReason = "statuscode";

			/// <summary>supportingsolutionid</summary>
			public const string SolutionId2 = "supportingsolutionid";

			/// <summary>tenantid</summary>
			public const string TenantId = "tenantid";

			/// <summary>timezoneruleversionnumber</summary>
			public const string TimeZoneRuleVersionNumber = "timezoneruleversionnumber";

			/// <summary>utcconversiontimezonecode</summary>
			public const string UTCConversionTimeZoneCode = "utcconversiontimezonecode";

			/// <summary>versionnumber</summary>
			public const string VersionNumber = "versionnumber";

			/// <summary>whitelistedappid</summary>
			public const string WhitelistedAppId = "whitelistedappid";

			/// <summary>workspaceid</summary>
			public const string WorkspaceId = "workspaceid";

			/// <summary>workspaceidname</summary>
			public const string Workspaceidname = "workspaceidname";

		}
		#endregion

		#region Schemas
		public static class Schemas 
		{
			/// <summary>1:N datalakeworkspacepermission_AsyncOperations</summary>
			public const string DatalakeworkspacepermissionAsyncOperations = "datalakeworkspacepermission_AsyncOperations";

			/// <summary>1:N datalakeworkspacepermission_BulkDeleteFailures</summary>
			public const string DatalakeworkspacepermissionBulkDeleteFailures = "datalakeworkspacepermission_BulkDeleteFailures";

			/// <summary>1:N datalakeworkspacepermission_DuplicateBaseRecord</summary>
			public const string DatalakeworkspacepermissionDuplicateBaseRecord = "datalakeworkspacepermission_DuplicateBaseRecord";

			/// <summary>1:N datalakeworkspacepermission_DuplicateMatchingRecord</summary>
			public const string DatalakeworkspacepermissionDuplicateMatchingRecord = "datalakeworkspacepermission_DuplicateMatchingRecord";

			/// <summary>1:N datalakeworkspacepermission_MailboxTrackingFolders</summary>
			public const string DatalakeworkspacepermissionMailboxTrackingFolders = "datalakeworkspacepermission_MailboxTrackingFolders";

			/// <summary>1:N datalakeworkspacepermission_PrincipalObjectAttributeAccesses</summary>
			public const string DatalakeworkspacepermissionPrincipalObjectAttributeAccesses = "datalakeworkspacepermission_PrincipalObjectAttributeAccesses";

			/// <summary>1:N datalakeworkspacepermission_ProcessSession</summary>
			public const string DatalakeworkspacepermissionProcessSession = "datalakeworkspacepermission_ProcessSession";

			/// <summary>1:N datalakeworkspacepermission_SyncErrors</summary>
			public const string DatalakeworkspacepermissionSyncErrors = "datalakeworkspacepermission_SyncErrors";

		}
		#endregion
	}
}

