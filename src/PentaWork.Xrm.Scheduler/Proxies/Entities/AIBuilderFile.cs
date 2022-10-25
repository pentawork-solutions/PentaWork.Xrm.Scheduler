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
	[EntityLogicalName("msdyn_aibfile")]
	public sealed class AIBuilderFile : Entity
	{	
		public static readonly int? EntityTypeCode = 10058;
		public new const string LogicalName = "msdyn_aibfile";
		public const string PrimaryIdAttribute = "msdyn_aibfileid";
		public const string PrimaryNameAttribute = "msdyn_name";
	
		public AIBuilderFile() : base("msdyn_aibfile") { }

		#region Attributes
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
        /// msdyn_aibdatasetscontainerid
        /// </summary>
		[DisplayName("AI Builder Datasets Container")]
		[AttributeLogicalName("msdyn_aibdatasetscontainerid")]
		public EntityReference AIBuilderDatasetsContainer
		{	
			get { return GetAttributeValue<EntityReference>("msdyn_aibdatasetscontainerid"); }
			set
			{ 
				if(value == AIBuilderDatasetsContainer) return;
				SetAttributeValue("msdyn_aibdatasetscontainerid", value);
			}
		}	
			
		/// <summary>
        /// msdyn_aibdatasetscontaineridname
        /// </summary>
		[DisplayName("msdyn_aibdatasetscontaineridname")]
		[AttributeLogicalName("msdyn_aibdatasetscontaineridname")]
		public string MsdynAibdatasetscontaineridname
		{	
			get { return GetAttributeValue<string>("msdyn_aibdatasetscontaineridname"); }
			set
			{ 
				if(value == MsdynAibdatasetscontaineridname) return;
				SetAttributeValue("msdyn_aibdatasetscontaineridname", value);
			}
		}	
			
		/// <summary>
        /// msdyn_aibfileid
        /// </summary>
		[DisplayName("AI Builder File")]
		[AttributeLogicalName("msdyn_aibfileid")]
		public override Guid Id
		{
			get => base.Id;
			set { base.Id = value; SetAttributeValue("msdyn_aibfileid", value); }
		}

							/// <summary>
        /// msdyn_checksum
        /// </summary>
		[DisplayName("Checksum")]
		[AttributeLogicalName("msdyn_checksum")]
		public string Checksum
		{	
			get { return GetAttributeValue<string>("msdyn_checksum"); }
			set
			{ 
				if(value == Checksum) return;
				SetAttributeValue("msdyn_checksum", value);
			}
		}	
			
		/// <summary>
        /// msdyn_file_name
        /// </summary>
		[DisplayName("msdyn_file_name")]
		[AttributeLogicalName("msdyn_file_name")]
		public string MsdynFileName
		{	
			get { return GetAttributeValue<string>("msdyn_file_name"); }
			set
			{ 
				if(value == MsdynFileName) return;
				SetAttributeValue("msdyn_file_name", value);
			}
		}	
			
		/// <summary>
        /// msdyn_image_timestamp
        /// </summary>
		[DisplayName("msdyn_image_timestamp")]
		[AttributeLogicalName("msdyn_image_timestamp")]
		public int? MsdynImageTimestamp
		{	
			get { return GetAttributeValue<int?>("msdyn_image_timestamp"); }
			set
			{ 
				if(value == MsdynImageTimestamp) return;
				SetAttributeValue("msdyn_image_timestamp", value);
			}
		}	
			
		/// <summary>
        /// msdyn_image_url
        /// </summary>
		[DisplayName("msdyn_image_url")]
		[AttributeLogicalName("msdyn_image_url")]
		public string MsdynImageUrl
		{	
			get { return GetAttributeValue<string>("msdyn_image_url"); }
			set
			{ 
				if(value == MsdynImageUrl) return;
				SetAttributeValue("msdyn_image_url", value);
			}
		}	
			
		/// <summary>
        /// msdyn_imageid
        /// </summary>
		[DisplayName("msdyn_imageid")]
		[AttributeLogicalName("msdyn_imageid")]
		public Guid MsdynImageId
		{	
			get { return GetAttributeValue<Guid>("msdyn_imageid"); }
			set
			{ 
				if(value == MsdynImageId) return;
				SetAttributeValue("msdyn_imageid", value);
			}
		}	
			
		/// <summary>
        /// msdyn_importmetadata
        /// </summary>
		[DisplayName("ImportMetadata")]
		[AttributeLogicalName("msdyn_importmetadata")]
		public string ImportMetadata
		{	
			get { return GetAttributeValue<string>("msdyn_importmetadata"); }
			set
			{ 
				if(value == ImportMetadata) return;
				SetAttributeValue("msdyn_importmetadata", value);
			}
		}	
			
		/// <summary>
        /// msdyn_mimetype
        /// </summary>
		[DisplayName("MimeType")]
		[AttributeLogicalName("msdyn_mimetype")]
		public string MimeType
		{	
			get { return GetAttributeValue<string>("msdyn_mimetype"); }
			set
			{ 
				if(value == MimeType) return;
				SetAttributeValue("msdyn_mimetype", value);
			}
		}	
			
		/// <summary>
        /// msdyn_name
        /// </summary>
		[DisplayName("Name")]
		[AttributeLogicalName("msdyn_name")]
		public string Name
		{	
			get { return GetAttributeValue<string>("msdyn_name"); }
			set
			{ 
				if(value == Name) return;
				SetAttributeValue("msdyn_name", value);
			}
		}	
			
		/// <summary>
        /// msdyn_size
        /// </summary>
		[DisplayName("Size")]
		[AttributeLogicalName("msdyn_size")]
		public int? Size
		{	
			get { return GetAttributeValue<int?>("msdyn_size"); }
			set
			{ 
				if(value == Size) return;
				SetAttributeValue("msdyn_size", value);
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
        /// 1:N Get entities for 'msdyn_AIBDatasetFile_msdyn_AIBuilde'
        /// </summary>
		[RelationshipSchemaName("msdyn_AIBDatasetFile_msdyn_AIBuilde")]
		public IEnumerable<AIBuilderDatasetFile> MsdynAIBDatasetFileMsdynAIBuilde
		{
			get { return GetRelatedEntities<AIBuilderDatasetFile>("msdyn_AIBDatasetFile_msdyn_AIBuilde", null); }
			set { SetRelatedEntities("msdyn_AIBDatasetFile_msdyn_AIBuilde", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'msdyn_aibfile_AsyncOperations'
        /// </summary>
		[RelationshipSchemaName("msdyn_aibfile_AsyncOperations")]
		public IEnumerable<SystemJob> MsdynAibfileAsyncOperations
		{
			get { return GetRelatedEntities<SystemJob>("msdyn_aibfile_AsyncOperations", null); }
			set { SetRelatedEntities("msdyn_aibfile_AsyncOperations", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'msdyn_aibfile_BulkDeleteFailures'
        /// </summary>
		[RelationshipSchemaName("msdyn_aibfile_BulkDeleteFailures")]
		public IEnumerable<BulkDeleteFailure> MsdynAibfileBulkDeleteFailures
		{
			get { return GetRelatedEntities<BulkDeleteFailure>("msdyn_aibfile_BulkDeleteFailures", null); }
			set { SetRelatedEntities("msdyn_aibfile_BulkDeleteFailures", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'msdyn_aibfile_DuplicateBaseRecord'
        /// </summary>
		[RelationshipSchemaName("msdyn_aibfile_DuplicateBaseRecord")]
		public IEnumerable<DuplicateRecord> MsdynAibfileDuplicateBaseRecord
		{
			get { return GetRelatedEntities<DuplicateRecord>("msdyn_aibfile_DuplicateBaseRecord", null); }
			set { SetRelatedEntities("msdyn_aibfile_DuplicateBaseRecord", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'msdyn_aibfile_DuplicateMatchingRecord'
        /// </summary>
		[RelationshipSchemaName("msdyn_aibfile_DuplicateMatchingRecord")]
		public IEnumerable<DuplicateRecord> MsdynAibfileDuplicateMatchingRecord
		{
			get { return GetRelatedEntities<DuplicateRecord>("msdyn_aibfile_DuplicateMatchingRecord", null); }
			set { SetRelatedEntities("msdyn_aibfile_DuplicateMatchingRecord", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'msdyn_aibfile_FileAttachments'
        /// </summary>
		[RelationshipSchemaName("msdyn_aibfile_FileAttachments")]
		public IEnumerable<FileAttachment> MsdynAibfileFileAttachments
		{
			get { return GetRelatedEntities<FileAttachment>("msdyn_aibfile_FileAttachments", null); }
			set { SetRelatedEntities("msdyn_aibfile_FileAttachments", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'msdyn_aibfile_MailboxTrackingFolders'
        /// </summary>
		[RelationshipSchemaName("msdyn_aibfile_MailboxTrackingFolders")]
		public IEnumerable<MailboxAutoTrackingFolder> MsdynAibfileMailboxTrackingFolders
		{
			get { return GetRelatedEntities<MailboxAutoTrackingFolder>("msdyn_aibfile_MailboxTrackingFolders", null); }
			set { SetRelatedEntities("msdyn_aibfile_MailboxTrackingFolders", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'msdyn_aibfile_PrincipalObjectAttributeAccesses'
        /// </summary>
		[RelationshipSchemaName("msdyn_aibfile_PrincipalObjectAttributeAccesses")]
		public IEnumerable<FieldSharing> MsdynAibfilePrincipalObjectAttributeAccesses
		{
			get { return GetRelatedEntities<FieldSharing>("msdyn_aibfile_PrincipalObjectAttributeAccesses", null); }
			set { SetRelatedEntities("msdyn_aibfile_PrincipalObjectAttributeAccesses", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'msdyn_aibfile_ProcessSession'
        /// </summary>
		[RelationshipSchemaName("msdyn_aibfile_ProcessSession")]
		public IEnumerable<ProcessSession> MsdynAibfileProcessSession
		{
			get { return GetRelatedEntities<ProcessSession>("msdyn_aibfile_ProcessSession", null); }
			set { SetRelatedEntities("msdyn_aibfile_ProcessSession", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'msdyn_aibfile_SyncErrors'
        /// </summary>
		[RelationshipSchemaName("msdyn_aibfile_SyncErrors")]
		public IEnumerable<SyncError> MsdynAibfileSyncErrors
		{
			get { return GetRelatedEntities<SyncError>("msdyn_aibfile_SyncErrors", null); }
			set { SetRelatedEntities("msdyn_aibfile_SyncErrors", null, value); }
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

			/// <summary>msdyn_aibdatasetscontainerid</summary>
			public const string AIBuilderDatasetsContainer = "msdyn_aibdatasetscontainerid";

			/// <summary>msdyn_aibdatasetscontaineridname</summary>
			public const string MsdynAibdatasetscontaineridname = "msdyn_aibdatasetscontaineridname";

			/// <summary>msdyn_aibfileid</summary>
			public const string AIBuilderFileId = "msdyn_aibfileid";

			/// <summary>msdyn_checksum</summary>
			public const string Checksum = "msdyn_checksum";

			/// <summary>msdyn_file_name</summary>
			public const string MsdynFileName = "msdyn_file_name";

			/// <summary>msdyn_image_timestamp</summary>
			public const string MsdynImageTimestamp = "msdyn_image_timestamp";

			/// <summary>msdyn_image_url</summary>
			public const string MsdynImageUrl = "msdyn_image_url";

			/// <summary>msdyn_imageid</summary>
			public const string MsdynImageId = "msdyn_imageid";

			/// <summary>msdyn_importmetadata</summary>
			public const string ImportMetadata = "msdyn_importmetadata";

			/// <summary>msdyn_mimetype</summary>
			public const string MimeType = "msdyn_mimetype";

			/// <summary>msdyn_name</summary>
			public const string Name = "msdyn_name";

			/// <summary>msdyn_size</summary>
			public const string Size = "msdyn_size";

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
			/// <summary>1:N msdyn_AIBDatasetFile_msdyn_AIBuilde</summary>
			public const string MsdynAIBDatasetFileMsdynAIBuilde = "msdyn_AIBDatasetFile_msdyn_AIBuilde";

			/// <summary>1:N msdyn_aibfile_AsyncOperations</summary>
			public const string MsdynAibfileAsyncOperations = "msdyn_aibfile_AsyncOperations";

			/// <summary>1:N msdyn_aibfile_BulkDeleteFailures</summary>
			public const string MsdynAibfileBulkDeleteFailures = "msdyn_aibfile_BulkDeleteFailures";

			/// <summary>1:N msdyn_aibfile_DuplicateBaseRecord</summary>
			public const string MsdynAibfileDuplicateBaseRecord = "msdyn_aibfile_DuplicateBaseRecord";

			/// <summary>1:N msdyn_aibfile_DuplicateMatchingRecord</summary>
			public const string MsdynAibfileDuplicateMatchingRecord = "msdyn_aibfile_DuplicateMatchingRecord";

			/// <summary>1:N msdyn_aibfile_FileAttachments</summary>
			public const string MsdynAibfileFileAttachments = "msdyn_aibfile_FileAttachments";

			/// <summary>1:N msdyn_aibfile_MailboxTrackingFolders</summary>
			public const string MsdynAibfileMailboxTrackingFolders = "msdyn_aibfile_MailboxTrackingFolders";

			/// <summary>1:N msdyn_aibfile_PrincipalObjectAttributeAccesses</summary>
			public const string MsdynAibfilePrincipalObjectAttributeAccesses = "msdyn_aibfile_PrincipalObjectAttributeAccesses";

			/// <summary>1:N msdyn_aibfile_ProcessSession</summary>
			public const string MsdynAibfileProcessSession = "msdyn_aibfile_ProcessSession";

			/// <summary>1:N msdyn_aibfile_SyncErrors</summary>
			public const string MsdynAibfileSyncErrors = "msdyn_aibfile_SyncErrors";

		}
		#endregion
	}
}

