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
	[EntityLogicalName("datalakefolder")]
	public sealed class DataLakeFolder : Entity
	{	
		public static readonly int? EntityTypeCode = 10013;
		public new const string LogicalName = "datalakefolder";
		public const string PrimaryIdAttribute = "datalakefolderid";
		public const string PrimaryNameAttribute = "name";
	
		public DataLakeFolder() : base("datalakefolder") { }

		#region Attributes
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
        /// containerendpoint
        /// </summary>
		[DisplayName("Container Endpoint")]
		[AttributeLogicalName("containerendpoint")]
		public string ContainerEndpoint
		{	
			get { return GetAttributeValue<string>("containerendpoint"); }
			set
			{ 
				if(value == ContainerEndpoint) return;
				SetAttributeValue("containerendpoint", value);
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
        /// datalakefolder_uniquename
        /// </summary>
		[DisplayName("Unique Name")]
		[AttributeLogicalName("datalakefolder_uniquename")]
		public string UniqueName
		{	
			get { return GetAttributeValue<string>("datalakefolder_uniquename"); }
			set
			{ 
				if(value == UniqueName) return;
				SetAttributeValue("datalakefolder_uniquename", value);
			}
		}	
			
		/// <summary>
        /// datalakefolderid
        /// </summary>
		[DisplayName("Data Lake Folder")]
		[AttributeLogicalName("datalakefolderid")]
		public override Guid Id
		{
			get => base.Id;
			set { base.Id = value; SetAttributeValue("datalakefolderid", value); }
		}

							/// <summary>
        /// extendedproperties
        /// </summary>
		[DisplayName("Extended Properties")]
		[AttributeLogicalName("extendedproperties")]
		public string ExtendedProperties
		{	
			get { return GetAttributeValue<string>("extendedproperties"); }
			set
			{ 
				if(value == ExtendedProperties) return;
				SetAttributeValue("extendedproperties", value);
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
        /// iscustomercapacity
        /// </summary>
		[DisplayName("Is Customer Capacity")]
		[AttributeLogicalName("iscustomercapacity")]
		public bool? IsCustomerCapacity
		{	
			get { return GetAttributeValue<bool?>("iscustomercapacity"); }
			set
			{ 
				if(value == IsCustomerCapacity) return;
				SetAttributeValue("iscustomercapacity", value);
			}
		}	
			
		/// <summary>
        /// isdeepcopyenabled
        /// </summary>
		[DisplayName("Is Deep Copy Enabled")]
		[AttributeLogicalName("isdeepcopyenabled")]
		public bool? IsDeepCopyEnabled
		{	
			get { return GetAttributeValue<bool?>("isdeepcopyenabled"); }
			set
			{ 
				if(value == IsDeepCopyEnabled) return;
				SetAttributeValue("isdeepcopyenabled", value);
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
        /// owningappid
        /// </summary>
		[DisplayName("Owning App Id")]
		[AttributeLogicalName("owningappid")]
		public Guid OwningAppId
		{	
			get { return GetAttributeValue<Guid>("owningappid"); }
			set
			{ 
				if(value == OwningAppId) return;
				SetAttributeValue("owningappid", value);
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
        /// path
        /// </summary>
		[DisplayName("Path")]
		[AttributeLogicalName("path")]
		public string Path
		{	
			get { return GetAttributeValue<string>("path"); }
			set
			{ 
				if(value == Path) return;
				SetAttributeValue("path", value);
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
        /// 1:N Get entities for 'datalakefolder_AsyncOperations'
        /// </summary>
		[RelationshipSchemaName("datalakefolder_AsyncOperations")]
		public IEnumerable<SystemJob> DatalakefolderAsyncOperations
		{
			get { return GetRelatedEntities<SystemJob>("datalakefolder_AsyncOperations", null); }
			set { SetRelatedEntities("datalakefolder_AsyncOperations", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'datalakefolder_BulkDeleteFailures'
        /// </summary>
		[RelationshipSchemaName("datalakefolder_BulkDeleteFailures")]
		public IEnumerable<BulkDeleteFailure> DatalakefolderBulkDeleteFailures
		{
			get { return GetRelatedEntities<BulkDeleteFailure>("datalakefolder_BulkDeleteFailures", null); }
			set { SetRelatedEntities("datalakefolder_BulkDeleteFailures", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'datalakefolder_datalakefolderpermission'
        /// </summary>
		[RelationshipSchemaName("datalakefolder_datalakefolderpermission")]
		public IEnumerable<DataLakeFolderPermission> DatalakefolderDatalakefolderpermission
		{
			get { return GetRelatedEntities<DataLakeFolderPermission>("datalakefolder_datalakefolderpermission", null); }
			set { SetRelatedEntities("datalakefolder_datalakefolderpermission", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'datalakefolder_DuplicateBaseRecord'
        /// </summary>
		[RelationshipSchemaName("datalakefolder_DuplicateBaseRecord")]
		public IEnumerable<DuplicateRecord> DatalakefolderDuplicateBaseRecord
		{
			get { return GetRelatedEntities<DuplicateRecord>("datalakefolder_DuplicateBaseRecord", null); }
			set { SetRelatedEntities("datalakefolder_DuplicateBaseRecord", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'datalakefolder_DuplicateMatchingRecord'
        /// </summary>
		[RelationshipSchemaName("datalakefolder_DuplicateMatchingRecord")]
		public IEnumerable<DuplicateRecord> DatalakefolderDuplicateMatchingRecord
		{
			get { return GetRelatedEntities<DuplicateRecord>("datalakefolder_DuplicateMatchingRecord", null); }
			set { SetRelatedEntities("datalakefolder_DuplicateMatchingRecord", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'datalakefolder_MailboxTrackingFolders'
        /// </summary>
		[RelationshipSchemaName("datalakefolder_MailboxTrackingFolders")]
		public IEnumerable<MailboxAutoTrackingFolder> DatalakefolderMailboxTrackingFolders
		{
			get { return GetRelatedEntities<MailboxAutoTrackingFolder>("datalakefolder_MailboxTrackingFolders", null); }
			set { SetRelatedEntities("datalakefolder_MailboxTrackingFolders", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'datalakefolder_PrincipalObjectAttributeAccesses'
        /// </summary>
		[RelationshipSchemaName("datalakefolder_PrincipalObjectAttributeAccesses")]
		public IEnumerable<FieldSharing> DatalakefolderPrincipalObjectAttributeAccesses
		{
			get { return GetRelatedEntities<FieldSharing>("datalakefolder_PrincipalObjectAttributeAccesses", null); }
			set { SetRelatedEntities("datalakefolder_PrincipalObjectAttributeAccesses", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'datalakefolder_ProcessSession'
        /// </summary>
		[RelationshipSchemaName("datalakefolder_ProcessSession")]
		public IEnumerable<ProcessSession> DatalakefolderProcessSession
		{
			get { return GetRelatedEntities<ProcessSession>("datalakefolder_ProcessSession", null); }
			set { SetRelatedEntities("datalakefolder_ProcessSession", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'datalakefolder_SyncErrors'
        /// </summary>
		[RelationshipSchemaName("datalakefolder_SyncErrors")]
		public IEnumerable<SyncError> DatalakefolderSyncErrors
		{
			get { return GetRelatedEntities<SyncError>("datalakefolder_SyncErrors", null); }
			set { SetRelatedEntities("datalakefolder_SyncErrors", null, value); }
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
			/// <summary>componentidunique</summary>
			public const string RowIdUniqueId = "componentidunique";

			/// <summary>componentstate</summary>
			public const string ComponentState = "componentstate";

			/// <summary>containerendpoint</summary>
			public const string ContainerEndpoint = "containerendpoint";

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

			/// <summary>datalakefolder_uniquename</summary>
			public const string UniqueName = "datalakefolder_uniquename";

			/// <summary>datalakefolderid</summary>
			public const string DataLakeFolderId = "datalakefolderid";

			/// <summary>extendedproperties</summary>
			public const string ExtendedProperties = "extendedproperties";

			/// <summary>importsequencenumber</summary>
			public const string ImportSequenceNumber = "importsequencenumber";

			/// <summary>iscustomercapacity</summary>
			public const string IsCustomerCapacity = "iscustomercapacity";

			/// <summary>isdeepcopyenabled</summary>
			public const string IsDeepCopyEnabled = "isdeepcopyenabled";

			/// <summary>ismanaged</summary>
			public const string IsManaged = "ismanaged";

			/// <summary>isprivate</summary>
			public const string IsPrivate = "isprivate";

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

			/// <summary>owningappid</summary>
			public const string OwningAppId = "owningappid";

			/// <summary>owningbusinessunit</summary>
			public const string OwningBusinessUnit = "owningbusinessunit";

			/// <summary>owningteam</summary>
			public const string OwningTeam = "owningteam";

			/// <summary>owninguser</summary>
			public const string OwningUser = "owninguser";

			/// <summary>path</summary>
			public const string Path = "path";

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
			/// <summary>1:N datalakefolder_AsyncOperations</summary>
			public const string DatalakefolderAsyncOperations = "datalakefolder_AsyncOperations";

			/// <summary>1:N datalakefolder_BulkDeleteFailures</summary>
			public const string DatalakefolderBulkDeleteFailures = "datalakefolder_BulkDeleteFailures";

			/// <summary>1:N datalakefolder_datalakefolderpermission</summary>
			public const string DatalakefolderDatalakefolderpermission = "datalakefolder_datalakefolderpermission";

			/// <summary>1:N datalakefolder_DuplicateBaseRecord</summary>
			public const string DatalakefolderDuplicateBaseRecord = "datalakefolder_DuplicateBaseRecord";

			/// <summary>1:N datalakefolder_DuplicateMatchingRecord</summary>
			public const string DatalakefolderDuplicateMatchingRecord = "datalakefolder_DuplicateMatchingRecord";

			/// <summary>1:N datalakefolder_MailboxTrackingFolders</summary>
			public const string DatalakefolderMailboxTrackingFolders = "datalakefolder_MailboxTrackingFolders";

			/// <summary>1:N datalakefolder_PrincipalObjectAttributeAccesses</summary>
			public const string DatalakefolderPrincipalObjectAttributeAccesses = "datalakefolder_PrincipalObjectAttributeAccesses";

			/// <summary>1:N datalakefolder_ProcessSession</summary>
			public const string DatalakefolderProcessSession = "datalakefolder_ProcessSession";

			/// <summary>1:N datalakefolder_SyncErrors</summary>
			public const string DatalakefolderSyncErrors = "datalakefolder_SyncErrors";

		}
		#endregion
	}
}

