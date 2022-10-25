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
	[EntityLogicalName("datalakefolderpermission")]
	public sealed class DataLakeFolderPermission : Entity
	{	
		public static readonly int? EntityTypeCode = 10014;
		public new const string LogicalName = "datalakefolderpermission";
		public const string PrimaryIdAttribute = "datalakefolderpermissionid";
		public const string PrimaryNameAttribute = "name";
	
		public DataLakeFolderPermission() : base("datalakefolderpermission") { }

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
        /// datalakefolderpermission_uniquename
        /// </summary>
		[DisplayName("Unique Name")]
		[AttributeLogicalName("datalakefolderpermission_uniquename")]
		public string UniqueName
		{	
			get { return GetAttributeValue<string>("datalakefolderpermission_uniquename"); }
			set
			{ 
				if(value == UniqueName) return;
				SetAttributeValue("datalakefolderpermission_uniquename", value);
			}
		}	
			
		/// <summary>
        /// datalakefolderpermissionid
        /// </summary>
		[DisplayName("Data Lake Folder Permission")]
		[AttributeLogicalName("datalakefolderpermissionid")]
		public override Guid Id
		{
			get => base.Id;
			set { base.Id = value; SetAttributeValue("datalakefolderpermissionid", value); }
		}

							/// <summary>
        /// folderid
        /// </summary>
		[DisplayName("Folder Id")]
		[AttributeLogicalName("folderid")]
		public EntityReference FolderId
		{	
			get { return GetAttributeValue<EntityReference>("folderid"); }
			set
			{ 
				if(value == FolderId) return;
				SetAttributeValue("folderid", value);
			}
		}	
			
		/// <summary>
        /// folderidname
        /// </summary>
		[DisplayName("folderidname")]
		[AttributeLogicalName("folderidname")]
		public string Folderidname
		{	
			get { return GetAttributeValue<string>("folderidname"); }
			set
			{ 
				if(value == Folderidname) return;
				SetAttributeValue("folderidname", value);
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
			
		#endregion	

		#region Relations
			/// <summary>
        /// 1:N Get entities for 'datalakefolderpermission_AsyncOperations'
        /// </summary>
		[RelationshipSchemaName("datalakefolderpermission_AsyncOperations")]
		public IEnumerable<SystemJob> DatalakefolderpermissionAsyncOperations
		{
			get { return GetRelatedEntities<SystemJob>("datalakefolderpermission_AsyncOperations", null); }
			set { SetRelatedEntities("datalakefolderpermission_AsyncOperations", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'datalakefolderpermission_BulkDeleteFailures'
        /// </summary>
		[RelationshipSchemaName("datalakefolderpermission_BulkDeleteFailures")]
		public IEnumerable<BulkDeleteFailure> DatalakefolderpermissionBulkDeleteFailures
		{
			get { return GetRelatedEntities<BulkDeleteFailure>("datalakefolderpermission_BulkDeleteFailures", null); }
			set { SetRelatedEntities("datalakefolderpermission_BulkDeleteFailures", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'datalakefolderpermission_DuplicateBaseRecord'
        /// </summary>
		[RelationshipSchemaName("datalakefolderpermission_DuplicateBaseRecord")]
		public IEnumerable<DuplicateRecord> DatalakefolderpermissionDuplicateBaseRecord
		{
			get { return GetRelatedEntities<DuplicateRecord>("datalakefolderpermission_DuplicateBaseRecord", null); }
			set { SetRelatedEntities("datalakefolderpermission_DuplicateBaseRecord", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'datalakefolderpermission_DuplicateMatchingRecord'
        /// </summary>
		[RelationshipSchemaName("datalakefolderpermission_DuplicateMatchingRecord")]
		public IEnumerable<DuplicateRecord> DatalakefolderpermissionDuplicateMatchingRecord
		{
			get { return GetRelatedEntities<DuplicateRecord>("datalakefolderpermission_DuplicateMatchingRecord", null); }
			set { SetRelatedEntities("datalakefolderpermission_DuplicateMatchingRecord", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'datalakefolderpermission_MailboxTrackingFolders'
        /// </summary>
		[RelationshipSchemaName("datalakefolderpermission_MailboxTrackingFolders")]
		public IEnumerable<MailboxAutoTrackingFolder> DatalakefolderpermissionMailboxTrackingFolders
		{
			get { return GetRelatedEntities<MailboxAutoTrackingFolder>("datalakefolderpermission_MailboxTrackingFolders", null); }
			set { SetRelatedEntities("datalakefolderpermission_MailboxTrackingFolders", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'datalakefolderpermission_PrincipalObjectAttributeAccesses'
        /// </summary>
		[RelationshipSchemaName("datalakefolderpermission_PrincipalObjectAttributeAccesses")]
		public IEnumerable<FieldSharing> DatalakefolderpermissionPrincipalObjectAttributeAccesses
		{
			get { return GetRelatedEntities<FieldSharing>("datalakefolderpermission_PrincipalObjectAttributeAccesses", null); }
			set { SetRelatedEntities("datalakefolderpermission_PrincipalObjectAttributeAccesses", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'datalakefolderpermission_ProcessSession'
        /// </summary>
		[RelationshipSchemaName("datalakefolderpermission_ProcessSession")]
		public IEnumerable<ProcessSession> DatalakefolderpermissionProcessSession
		{
			get { return GetRelatedEntities<ProcessSession>("datalakefolderpermission_ProcessSession", null); }
			set { SetRelatedEntities("datalakefolderpermission_ProcessSession", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'datalakefolderpermission_SyncErrors'
        /// </summary>
		[RelationshipSchemaName("datalakefolderpermission_SyncErrors")]
		public IEnumerable<SyncError> DatalakefolderpermissionSyncErrors
		{
			get { return GetRelatedEntities<SyncError>("datalakefolderpermission_SyncErrors", null); }
			set { SetRelatedEntities("datalakefolderpermission_SyncErrors", null, value); }
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

			/// <summary>datalakefolderpermission_uniquename</summary>
			public const string UniqueName = "datalakefolderpermission_uniquename";

			/// <summary>datalakefolderpermissionid</summary>
			public const string DataLakeFolderPermissionId = "datalakefolderpermissionid";

			/// <summary>folderid</summary>
			public const string FolderId = "folderid";

			/// <summary>folderidname</summary>
			public const string Folderidname = "folderidname";

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

			/// <summary>overriddencreatedon</summary>
			public const string RecordCreatedOn = "overriddencreatedon";

			/// <summary>overwritetime</summary>
			public const string RecordOverwriteTime = "overwritetime";

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

			/// <summary>solutionid</summary>
			public const string SolutionId = "solutionid";

			/// <summary>statecode</summary>
			public const string Status = "statecode";

			/// <summary>statuscode</summary>
			public const string StatusReason = "statuscode";

			/// <summary>supportingsolutionid</summary>
			public const string SolutionId2 = "supportingsolutionid";

			/// <summary>timezoneruleversionnumber</summary>
			public const string TimeZoneRuleVersionNumber = "timezoneruleversionnumber";

			/// <summary>utcconversiontimezonecode</summary>
			public const string UTCConversionTimeZoneCode = "utcconversiontimezonecode";

			/// <summary>versionnumber</summary>
			public const string VersionNumber = "versionnumber";

		}
		#endregion

		#region Schemas
		public static class Schemas 
		{
			/// <summary>1:N datalakefolderpermission_AsyncOperations</summary>
			public const string DatalakefolderpermissionAsyncOperations = "datalakefolderpermission_AsyncOperations";

			/// <summary>1:N datalakefolderpermission_BulkDeleteFailures</summary>
			public const string DatalakefolderpermissionBulkDeleteFailures = "datalakefolderpermission_BulkDeleteFailures";

			/// <summary>1:N datalakefolderpermission_DuplicateBaseRecord</summary>
			public const string DatalakefolderpermissionDuplicateBaseRecord = "datalakefolderpermission_DuplicateBaseRecord";

			/// <summary>1:N datalakefolderpermission_DuplicateMatchingRecord</summary>
			public const string DatalakefolderpermissionDuplicateMatchingRecord = "datalakefolderpermission_DuplicateMatchingRecord";

			/// <summary>1:N datalakefolderpermission_MailboxTrackingFolders</summary>
			public const string DatalakefolderpermissionMailboxTrackingFolders = "datalakefolderpermission_MailboxTrackingFolders";

			/// <summary>1:N datalakefolderpermission_PrincipalObjectAttributeAccesses</summary>
			public const string DatalakefolderpermissionPrincipalObjectAttributeAccesses = "datalakefolderpermission_PrincipalObjectAttributeAccesses";

			/// <summary>1:N datalakefolderpermission_ProcessSession</summary>
			public const string DatalakefolderpermissionProcessSession = "datalakefolderpermission_ProcessSession";

			/// <summary>1:N datalakefolderpermission_SyncErrors</summary>
			public const string DatalakefolderpermissionSyncErrors = "datalakefolderpermission_SyncErrors";

		}
		#endregion
	}
}

