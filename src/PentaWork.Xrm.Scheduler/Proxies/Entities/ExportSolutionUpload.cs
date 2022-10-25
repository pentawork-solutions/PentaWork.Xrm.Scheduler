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
	[EntityLogicalName("exportsolutionupload")]
	public sealed class ExportSolutionUpload : Entity
	{	
		public static readonly int? EntityTypeCode = 10010;
		public new const string LogicalName = "exportsolutionupload";
		public const string PrimaryIdAttribute = "exportsolutionuploadid";
		public const string PrimaryNameAttribute = "name";
	
		public ExportSolutionUpload() : base("exportsolutionupload") { }

		#region Attributes
		/// <summary>
        /// asyncoperationid
        /// </summary>
		[DisplayName("AsyncOperation Id")]
		[AttributeLogicalName("asyncoperationid")]
		public EntityReference AsyncOperationId
		{	
			get { return GetAttributeValue<EntityReference>("asyncoperationid"); }
			set
			{ 
				if(value == AsyncOperationId) return;
				SetAttributeValue("asyncoperationid", value);
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
        /// exportsolutionuploadid
        /// </summary>
		[DisplayName("ExportSolutionUpload")]
		[AttributeLogicalName("exportsolutionuploadid")]
		public override Guid Id
		{
			get => base.Id;
			set { base.Id = value; SetAttributeValue("exportsolutionuploadid", value); }
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
        /// solutionfile_name
        /// </summary>
		[DisplayName("solutionfile_name")]
		[AttributeLogicalName("solutionfile_name")]
		public string SolutionfileName
		{	
			get { return GetAttributeValue<string>("solutionfile_name"); }
			set
			{ 
				if(value == SolutionfileName) return;
				SetAttributeValue("solutionfile_name", value);
			}
		}	
			
		/// <summary>
        /// solutionfilename
        /// </summary>
		[DisplayName("SolutionFileName")]
		[AttributeLogicalName("solutionfilename")]
		public string SolutionFileName
		{	
			get { return GetAttributeValue<string>("solutionfilename"); }
			set
			{ 
				if(value == SolutionFileName) return;
				SetAttributeValue("solutionfilename", value);
			}
		}	
			
		/// <summary>
        /// solutionuniquename
        /// </summary>
		[DisplayName("SolutionUniqueName")]
		[AttributeLogicalName("solutionuniquename")]
		public string SolutionUniqueName
		{	
			get { return GetAttributeValue<string>("solutionuniquename"); }
			set
			{ 
				if(value == SolutionUniqueName) return;
				SetAttributeValue("solutionuniquename", value);
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
        /// 1:N Get entities for 'exportsolutionupload_AsyncOperations'
        /// </summary>
		[RelationshipSchemaName("exportsolutionupload_AsyncOperations")]
		public IEnumerable<SystemJob> ExportsolutionuploadAsyncOperations
		{
			get { return GetRelatedEntities<SystemJob>("exportsolutionupload_AsyncOperations", null); }
			set { SetRelatedEntities("exportsolutionupload_AsyncOperations", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'exportsolutionupload_BulkDeleteFailures'
        /// </summary>
		[RelationshipSchemaName("exportsolutionupload_BulkDeleteFailures")]
		public IEnumerable<BulkDeleteFailure> ExportsolutionuploadBulkDeleteFailures
		{
			get { return GetRelatedEntities<BulkDeleteFailure>("exportsolutionupload_BulkDeleteFailures", null); }
			set { SetRelatedEntities("exportsolutionupload_BulkDeleteFailures", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'exportsolutionupload_DuplicateBaseRecord'
        /// </summary>
		[RelationshipSchemaName("exportsolutionupload_DuplicateBaseRecord")]
		public IEnumerable<DuplicateRecord> ExportsolutionuploadDuplicateBaseRecord
		{
			get { return GetRelatedEntities<DuplicateRecord>("exportsolutionupload_DuplicateBaseRecord", null); }
			set { SetRelatedEntities("exportsolutionupload_DuplicateBaseRecord", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'exportsolutionupload_DuplicateMatchingRecord'
        /// </summary>
		[RelationshipSchemaName("exportsolutionupload_DuplicateMatchingRecord")]
		public IEnumerable<DuplicateRecord> ExportsolutionuploadDuplicateMatchingRecord
		{
			get { return GetRelatedEntities<DuplicateRecord>("exportsolutionupload_DuplicateMatchingRecord", null); }
			set { SetRelatedEntities("exportsolutionupload_DuplicateMatchingRecord", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'exportsolutionupload_FileAttachments'
        /// </summary>
		[RelationshipSchemaName("exportsolutionupload_FileAttachments")]
		public IEnumerable<FileAttachment> ExportsolutionuploadFileAttachments
		{
			get { return GetRelatedEntities<FileAttachment>("exportsolutionupload_FileAttachments", null); }
			set { SetRelatedEntities("exportsolutionupload_FileAttachments", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'exportsolutionupload_MailboxTrackingFolders'
        /// </summary>
		[RelationshipSchemaName("exportsolutionupload_MailboxTrackingFolders")]
		public IEnumerable<MailboxAutoTrackingFolder> ExportsolutionuploadMailboxTrackingFolders
		{
			get { return GetRelatedEntities<MailboxAutoTrackingFolder>("exportsolutionupload_MailboxTrackingFolders", null); }
			set { SetRelatedEntities("exportsolutionupload_MailboxTrackingFolders", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'exportsolutionupload_PrincipalObjectAttributeAccesses'
        /// </summary>
		[RelationshipSchemaName("exportsolutionupload_PrincipalObjectAttributeAccesses")]
		public IEnumerable<FieldSharing> ExportsolutionuploadPrincipalObjectAttributeAccesses
		{
			get { return GetRelatedEntities<FieldSharing>("exportsolutionupload_PrincipalObjectAttributeAccesses", null); }
			set { SetRelatedEntities("exportsolutionupload_PrincipalObjectAttributeAccesses", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'exportsolutionupload_ProcessSession'
        /// </summary>
		[RelationshipSchemaName("exportsolutionupload_ProcessSession")]
		public IEnumerable<ProcessSession> ExportsolutionuploadProcessSession
		{
			get { return GetRelatedEntities<ProcessSession>("exportsolutionupload_ProcessSession", null); }
			set { SetRelatedEntities("exportsolutionupload_ProcessSession", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'exportsolutionupload_SyncErrors'
        /// </summary>
		[RelationshipSchemaName("exportsolutionupload_SyncErrors")]
		public IEnumerable<SyncError> ExportsolutionuploadSyncErrors
		{
			get { return GetRelatedEntities<SyncError>("exportsolutionupload_SyncErrors", null); }
			set { SetRelatedEntities("exportsolutionupload_SyncErrors", null, value); }
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
		
			[Label("Inactive")]
			[Description(@"")]
			Inactive_Inactive = 2, 
		}
		
		#endregion	

		#region Properties
		public static class Properties 
		{
			/// <summary>asyncoperationid</summary>
			public const string AsyncOperationId = "asyncoperationid";

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

			/// <summary>exportsolutionuploadid</summary>
			public const string ExportSolutionUploadId = "exportsolutionuploadid";

			/// <summary>importsequencenumber</summary>
			public const string ImportSequenceNumber = "importsequencenumber";

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

			/// <summary>solutionfile_name</summary>
			public const string SolutionfileName = "solutionfile_name";

			/// <summary>solutionfilename</summary>
			public const string SolutionFileName = "solutionfilename";

			/// <summary>solutionuniquename</summary>
			public const string SolutionUniqueName = "solutionuniquename";

			/// <summary>statecode</summary>
			public const string Status = "statecode";

			/// <summary>statuscode</summary>
			public const string StatusReason = "statuscode";

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
			/// <summary>1:N exportsolutionupload_AsyncOperations</summary>
			public const string ExportsolutionuploadAsyncOperations = "exportsolutionupload_AsyncOperations";

			/// <summary>1:N exportsolutionupload_BulkDeleteFailures</summary>
			public const string ExportsolutionuploadBulkDeleteFailures = "exportsolutionupload_BulkDeleteFailures";

			/// <summary>1:N exportsolutionupload_DuplicateBaseRecord</summary>
			public const string ExportsolutionuploadDuplicateBaseRecord = "exportsolutionupload_DuplicateBaseRecord";

			/// <summary>1:N exportsolutionupload_DuplicateMatchingRecord</summary>
			public const string ExportsolutionuploadDuplicateMatchingRecord = "exportsolutionupload_DuplicateMatchingRecord";

			/// <summary>1:N exportsolutionupload_FileAttachments</summary>
			public const string ExportsolutionuploadFileAttachments = "exportsolutionupload_FileAttachments";

			/// <summary>1:N exportsolutionupload_MailboxTrackingFolders</summary>
			public const string ExportsolutionuploadMailboxTrackingFolders = "exportsolutionupload_MailboxTrackingFolders";

			/// <summary>1:N exportsolutionupload_PrincipalObjectAttributeAccesses</summary>
			public const string ExportsolutionuploadPrincipalObjectAttributeAccesses = "exportsolutionupload_PrincipalObjectAttributeAccesses";

			/// <summary>1:N exportsolutionupload_ProcessSession</summary>
			public const string ExportsolutionuploadProcessSession = "exportsolutionupload_ProcessSession";

			/// <summary>1:N exportsolutionupload_SyncErrors</summary>
			public const string ExportsolutionuploadSyncErrors = "exportsolutionupload_SyncErrors";

		}
		#endregion
	}
}

