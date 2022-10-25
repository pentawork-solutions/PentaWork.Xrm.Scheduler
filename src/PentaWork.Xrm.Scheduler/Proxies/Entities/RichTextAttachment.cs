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
	[EntityLogicalName("msdyn_richtextfile")]
	public sealed class RichTextAttachment : Entity
	{	
		public static readonly int? EntityTypeCode = 10040;
		public new const string LogicalName = "msdyn_richtextfile";
		public const string PrimaryIdAttribute = "msdyn_richtextfileid";
		public const string PrimaryNameAttribute = "msdyn_name";
	
		public RichTextAttachment() : base("msdyn_richtextfile") { }

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
        /// msdyn_fileblob_name
        /// </summary>
		[DisplayName("msdyn_fileblob_name")]
		[AttributeLogicalName("msdyn_fileblob_name")]
		public string MsdynFileblobName
		{	
			get { return GetAttributeValue<string>("msdyn_fileblob_name"); }
			set
			{ 
				if(value == MsdynFileblobName) return;
				SetAttributeValue("msdyn_fileblob_name", value);
			}
		}	
			
		/// <summary>
        /// msdyn_imageblob_timestamp
        /// </summary>
		[DisplayName("msdyn_imageblob_timestamp")]
		[AttributeLogicalName("msdyn_imageblob_timestamp")]
		public int? MsdynImageblobTimestamp
		{	
			get { return GetAttributeValue<int?>("msdyn_imageblob_timestamp"); }
			set
			{ 
				if(value == MsdynImageblobTimestamp) return;
				SetAttributeValue("msdyn_imageblob_timestamp", value);
			}
		}	
			
		/// <summary>
        /// msdyn_imageblob_url
        /// </summary>
		[DisplayName("msdyn_imageblob_url")]
		[AttributeLogicalName("msdyn_imageblob_url")]
		public string MsdynImageblobUrl
		{	
			get { return GetAttributeValue<string>("msdyn_imageblob_url"); }
			set
			{ 
				if(value == MsdynImageblobUrl) return;
				SetAttributeValue("msdyn_imageblob_url", value);
			}
		}	
			
		/// <summary>
        /// msdyn_imageblobid
        /// </summary>
		[DisplayName("msdyn_imageblobid")]
		[AttributeLogicalName("msdyn_imageblobid")]
		public Guid MsdynImageblobId
		{	
			get { return GetAttributeValue<Guid>("msdyn_imageblobid"); }
			set
			{ 
				if(value == MsdynImageblobId) return;
				SetAttributeValue("msdyn_imageblobid", value);
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
        /// msdyn_parententity_fieldname
        /// </summary>
		[DisplayName("Parent Entity Field Name")]
		[AttributeLogicalName("msdyn_parententity_fieldname")]
		public string ParentEntityFieldName
		{	
			get { return GetAttributeValue<string>("msdyn_parententity_fieldname"); }
			set
			{ 
				if(value == ParentEntityFieldName) return;
				SetAttributeValue("msdyn_parententity_fieldname", value);
			}
		}	
			
		/// <summary>
        /// msdyn_parententityname
        /// </summary>
		[DisplayName("Parent Entity Name")]
		[AttributeLogicalName("msdyn_parententityname")]
		public string ParentEntityName
		{	
			get { return GetAttributeValue<string>("msdyn_parententityname"); }
			set
			{ 
				if(value == ParentEntityName) return;
				SetAttributeValue("msdyn_parententityname", value);
			}
		}	
			
		/// <summary>
        /// msdyn_parentid
        /// </summary>
		[DisplayName("Parent ID")]
		[AttributeLogicalName("msdyn_parentid")]
		public string ParentID
		{	
			get { return GetAttributeValue<string>("msdyn_parentid"); }
			set
			{ 
				if(value == ParentID) return;
				SetAttributeValue("msdyn_parentid", value);
			}
		}	
			
		/// <summary>
        /// msdyn_richtextfileid
        /// </summary>
		[DisplayName("Rich Text Attachment")]
		[AttributeLogicalName("msdyn_richtextfileid")]
		public override Guid Id
		{
			get => base.Id;
			set { base.Id = value; SetAttributeValue("msdyn_richtextfileid", value); }
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
        /// 1:N Get entities for 'msdyn_richtextfile_AsyncOperations'
        /// </summary>
		[RelationshipSchemaName("msdyn_richtextfile_AsyncOperations")]
		public IEnumerable<SystemJob> MsdynRichtextfileAsyncOperations
		{
			get { return GetRelatedEntities<SystemJob>("msdyn_richtextfile_AsyncOperations", null); }
			set { SetRelatedEntities("msdyn_richtextfile_AsyncOperations", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'msdyn_richtextfile_BulkDeleteFailures'
        /// </summary>
		[RelationshipSchemaName("msdyn_richtextfile_BulkDeleteFailures")]
		public IEnumerable<BulkDeleteFailure> MsdynRichtextfileBulkDeleteFailures
		{
			get { return GetRelatedEntities<BulkDeleteFailure>("msdyn_richtextfile_BulkDeleteFailures", null); }
			set { SetRelatedEntities("msdyn_richtextfile_BulkDeleteFailures", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'msdyn_richtextfile_FileAttachments'
        /// </summary>
		[RelationshipSchemaName("msdyn_richtextfile_FileAttachments")]
		public IEnumerable<FileAttachment> MsdynRichtextfileFileAttachments
		{
			get { return GetRelatedEntities<FileAttachment>("msdyn_richtextfile_FileAttachments", null); }
			set { SetRelatedEntities("msdyn_richtextfile_FileAttachments", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'msdyn_richtextfile_MailboxTrackingFolders'
        /// </summary>
		[RelationshipSchemaName("msdyn_richtextfile_MailboxTrackingFolders")]
		public IEnumerable<MailboxAutoTrackingFolder> MsdynRichtextfileMailboxTrackingFolders
		{
			get { return GetRelatedEntities<MailboxAutoTrackingFolder>("msdyn_richtextfile_MailboxTrackingFolders", null); }
			set { SetRelatedEntities("msdyn_richtextfile_MailboxTrackingFolders", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'msdyn_richtextfile_PrincipalObjectAttributeAccesses'
        /// </summary>
		[RelationshipSchemaName("msdyn_richtextfile_PrincipalObjectAttributeAccesses")]
		public IEnumerable<FieldSharing> MsdynRichtextfilePrincipalObjectAttributeAccesses
		{
			get { return GetRelatedEntities<FieldSharing>("msdyn_richtextfile_PrincipalObjectAttributeAccesses", null); }
			set { SetRelatedEntities("msdyn_richtextfile_PrincipalObjectAttributeAccesses", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'msdyn_richtextfile_ProcessSession'
        /// </summary>
		[RelationshipSchemaName("msdyn_richtextfile_ProcessSession")]
		public IEnumerable<ProcessSession> MsdynRichtextfileProcessSession
		{
			get { return GetRelatedEntities<ProcessSession>("msdyn_richtextfile_ProcessSession", null); }
			set { SetRelatedEntities("msdyn_richtextfile_ProcessSession", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'msdyn_richtextfile_SyncErrors'
        /// </summary>
		[RelationshipSchemaName("msdyn_richtextfile_SyncErrors")]
		public IEnumerable<SyncError> MsdynRichtextfileSyncErrors
		{
			get { return GetRelatedEntities<SyncError>("msdyn_richtextfile_SyncErrors", null); }
			set { SetRelatedEntities("msdyn_richtextfile_SyncErrors", null, value); }
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

			/// <summary>msdyn_fileblob_name</summary>
			public const string MsdynFileblobName = "msdyn_fileblob_name";

			/// <summary>msdyn_imageblob_timestamp</summary>
			public const string MsdynImageblobTimestamp = "msdyn_imageblob_timestamp";

			/// <summary>msdyn_imageblob_url</summary>
			public const string MsdynImageblobUrl = "msdyn_imageblob_url";

			/// <summary>msdyn_imageblobid</summary>
			public const string MsdynImageblobId = "msdyn_imageblobid";

			/// <summary>msdyn_name</summary>
			public const string Name = "msdyn_name";

			/// <summary>msdyn_parententity_fieldname</summary>
			public const string ParentEntityFieldName = "msdyn_parententity_fieldname";

			/// <summary>msdyn_parententityname</summary>
			public const string ParentEntityName = "msdyn_parententityname";

			/// <summary>msdyn_parentid</summary>
			public const string ParentID = "msdyn_parentid";

			/// <summary>msdyn_richtextfileid</summary>
			public const string RichTextAttachmentId = "msdyn_richtextfileid";

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
			/// <summary>1:N msdyn_richtextfile_AsyncOperations</summary>
			public const string MsdynRichtextfileAsyncOperations = "msdyn_richtextfile_AsyncOperations";

			/// <summary>1:N msdyn_richtextfile_BulkDeleteFailures</summary>
			public const string MsdynRichtextfileBulkDeleteFailures = "msdyn_richtextfile_BulkDeleteFailures";

			/// <summary>1:N msdyn_richtextfile_FileAttachments</summary>
			public const string MsdynRichtextfileFileAttachments = "msdyn_richtextfile_FileAttachments";

			/// <summary>1:N msdyn_richtextfile_MailboxTrackingFolders</summary>
			public const string MsdynRichtextfileMailboxTrackingFolders = "msdyn_richtextfile_MailboxTrackingFolders";

			/// <summary>1:N msdyn_richtextfile_PrincipalObjectAttributeAccesses</summary>
			public const string MsdynRichtextfilePrincipalObjectAttributeAccesses = "msdyn_richtextfile_PrincipalObjectAttributeAccesses";

			/// <summary>1:N msdyn_richtextfile_ProcessSession</summary>
			public const string MsdynRichtextfileProcessSession = "msdyn_richtextfile_ProcessSession";

			/// <summary>1:N msdyn_richtextfile_SyncErrors</summary>
			public const string MsdynRichtextfileSyncErrors = "msdyn_richtextfile_SyncErrors";

		}
		#endregion
	}
}

