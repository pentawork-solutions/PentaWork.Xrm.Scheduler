using System;
using System.Linq;
using System.Diagnostics;
using System.ComponentModel;
using Microsoft.Xrm.Sdk; 
using Microsoft.Xrm.Sdk.Client;
using System.Collections.Generic;

namespace PentaWork.Xrm.Scheduler.Proxies.Entities
{
	[DebuggerDisplay("{Title}")] 	
	[EntityLogicalName("annotation")]
	public sealed class Note : Entity
	{	
		public static readonly int? EntityTypeCode = 5;
		public new const string LogicalName = "annotation";
		public const string PrimaryIdAttribute = "annotationid";
		public const string PrimaryNameAttribute = "subject";
	
		public Note() : base("annotation") { }

		#region Attributes
		/// <summary>
        /// annotationid
        /// </summary>
		[DisplayName("Note")]
		[AttributeLogicalName("annotationid")]
		public override Guid Id
		{
			get => base.Id;
			set { base.Id = value; SetAttributeValue("annotationid", value); }
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
        /// documentbody
        /// </summary>
		[DisplayName("Document")]
		[AttributeLogicalName("documentbody")]
		public string Document
		{	
			get { return GetAttributeValue<string>("documentbody"); }
			set
			{ 
				if(value == Document) return;
				SetAttributeValue("documentbody", value);
			}
		}	
			
		/// <summary>
        /// filename
        /// </summary>
		[DisplayName("File Name")]
		[AttributeLogicalName("filename")]
		public string FileName
		{	
			get { return GetAttributeValue<string>("filename"); }
			set
			{ 
				if(value == FileName) return;
				SetAttributeValue("filename", value);
			}
		}	
			
		/// <summary>
        /// filepointer
        /// </summary>
		[DisplayName("File Pointer")]
		[AttributeLogicalName("filepointer")]
		public string FilePointer
		{	
			get { return GetAttributeValue<string>("filepointer"); }
			set
			{ 
				if(value == FilePointer) return;
				SetAttributeValue("filepointer", value);
			}
		}	
			
		/// <summary>
        /// filesize
        /// </summary>
		[DisplayName("File Size (Bytes)")]
		[AttributeLogicalName("filesize")]
		public int? FileSizeBytes
		{	
			get { return GetAttributeValue<int?>("filesize"); }
			set
			{ 
				if(value == FileSizeBytes) return;
				SetAttributeValue("filesize", value);
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
        /// isdocument
        /// </summary>
		[DisplayName("Is Document")]
		[AttributeLogicalName("isdocument")]
		public bool? IsDocument
		{	
			get { return GetAttributeValue<bool?>("isdocument"); }
			set
			{ 
				if(value == IsDocument) return;
				SetAttributeValue("isdocument", value);
			}
		}	
			
		/// <summary>
        /// isprivate
        /// </summary>
		[DisplayName("isprivate")]
		[AttributeLogicalName("isprivate")]
		public bool? Isprivate
		{	
			get { return GetAttributeValue<bool?>("isprivate"); }
			set
			{ 
				if(value == Isprivate) return;
				SetAttributeValue("isprivate", value);
			}
		}	
			
		/// <summary>
        /// langid
        /// </summary>
		[DisplayName("Language ID")]
		[AttributeLogicalName("langid")]
		public string LanguageID
		{	
			get { return GetAttributeValue<string>("langid"); }
			set
			{ 
				if(value == LanguageID) return;
				SetAttributeValue("langid", value);
			}
		}	
			
		/// <summary>
        /// mimetype
        /// </summary>
		[DisplayName("Mime Type")]
		[AttributeLogicalName("mimetype")]
		public string MimeType
		{	
			get { return GetAttributeValue<string>("mimetype"); }
			set
			{ 
				if(value == MimeType) return;
				SetAttributeValue("mimetype", value);
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
        /// notetext
        /// </summary>
		[DisplayName("Description")]
		[AttributeLogicalName("notetext")]
		public string Description
		{	
			get { return GetAttributeValue<string>("notetext"); }
			set
			{ 
				if(value == Description) return;
				SetAttributeValue("notetext", value);
			}
		}	
			
		/// <summary>
        /// objectid
        /// </summary>
		[DisplayName("Regarding")]
		[AttributeLogicalName("objectid")]
		public EntityReference Regarding
		{	
			get { return GetAttributeValue<EntityReference>("objectid"); }
			set
			{ 
				if(value == Regarding) return;
				SetAttributeValue("objectid", value);
			}
		}	
			
		/// <summary>
        /// objectidtypecode
        /// </summary>
		[DisplayName("Regarding Object Type")]
		[AttributeLogicalName("objectidtypecode")]
		public string RegardingObjectType
		{	
			get { return GetAttributeValue<string>("objectidtypecode"); }
			set
			{ 
				if(value == RegardingObjectType) return;
				SetAttributeValue("objectidtypecode", value);
			}
		}	
			
		/// <summary>
        /// objecttypecode
        /// </summary>
		[DisplayName("Object Type")]
		[AttributeLogicalName("objecttypecode")]
		public string ObjectType
		{	
			get { return GetAttributeValue<string>("objecttypecode"); }
			set
			{ 
				if(value == ObjectType) return;
				SetAttributeValue("objecttypecode", value);
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
        /// prefix
        /// </summary>
		[DisplayName("Prefix")]
		[AttributeLogicalName("prefix")]
		public string Prefix
		{	
			get { return GetAttributeValue<string>("prefix"); }
			set
			{ 
				if(value == Prefix) return;
				SetAttributeValue("prefix", value);
			}
		}	
			
		/// <summary>
        /// stepid
        /// </summary>
		[DisplayName("Step Id")]
		[AttributeLogicalName("stepid")]
		public string StepId
		{	
			get { return GetAttributeValue<string>("stepid"); }
			set
			{ 
				if(value == StepId) return;
				SetAttributeValue("stepid", value);
			}
		}	
			
		/// <summary>
        /// storagepointer
        /// </summary>
		[DisplayName("Storage Pointer")]
		[AttributeLogicalName("storagepointer")]
		public string StoragePointer
		{	
			get { return GetAttributeValue<string>("storagepointer"); }
			set
			{ 
				if(value == StoragePointer) return;
				SetAttributeValue("storagepointer", value);
			}
		}	
			
		/// <summary>
        /// subject
        /// </summary>
		[DisplayName("Title")]
		[AttributeLogicalName("subject")]
		public string Title
		{	
			get { return GetAttributeValue<string>("subject"); }
			set
			{ 
				if(value == Title) return;
				SetAttributeValue("subject", value);
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
        /// 1:N Get entities for 'Annotation_AsyncOperations'
        /// </summary>
		[RelationshipSchemaName("Annotation_AsyncOperations")]
		public IEnumerable<SystemJob> AnnotationAsyncOperations
		{
			get { return GetRelatedEntities<SystemJob>("Annotation_AsyncOperations", null); }
			set { SetRelatedEntities("Annotation_AsyncOperations", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'Annotation_BulkDeleteFailures'
        /// </summary>
		[RelationshipSchemaName("Annotation_BulkDeleteFailures")]
		public IEnumerable<BulkDeleteFailure> AnnotationBulkDeleteFailures
		{
			get { return GetRelatedEntities<BulkDeleteFailure>("Annotation_BulkDeleteFailures", null); }
			set { SetRelatedEntities("Annotation_BulkDeleteFailures", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'Annotation_ProcessSessions'
        /// </summary>
		[RelationshipSchemaName("Annotation_ProcessSessions")]
		public IEnumerable<ProcessSession> AnnotationProcessSessions
		{
			get { return GetRelatedEntities<ProcessSession>("Annotation_ProcessSessions", null); }
			set { SetRelatedEntities("Annotation_ProcessSessions", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'Annotation_SyncErrors'
        /// </summary>
		[RelationshipSchemaName("Annotation_SyncErrors")]
		public IEnumerable<SyncError> AnnotationSyncErrors
		{
			get { return GetRelatedEntities<SyncError>("Annotation_SyncErrors", null); }
			set { SetRelatedEntities("Annotation_SyncErrors", null, value); }
		}
		#endregion

		#region Actions
		#endregion

		#region OptionSetEnums
		#endregion	

		#region Properties
		public static class Properties 
		{
			/// <summary>annotationid</summary>
			public const string NoteId = "annotationid";

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

			/// <summary>documentbody</summary>
			public const string Document = "documentbody";

			/// <summary>filename</summary>
			public const string FileName = "filename";

			/// <summary>filepointer</summary>
			public const string FilePointer = "filepointer";

			/// <summary>filesize</summary>
			public const string FileSizeBytes = "filesize";

			/// <summary>importsequencenumber</summary>
			public const string ImportSequenceNumber = "importsequencenumber";

			/// <summary>isdocument</summary>
			public const string IsDocument = "isdocument";

			/// <summary>isprivate</summary>
			public const string Isprivate = "isprivate";

			/// <summary>langid</summary>
			public const string LanguageID = "langid";

			/// <summary>mimetype</summary>
			public const string MimeType = "mimetype";

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

			/// <summary>notetext</summary>
			public const string Description = "notetext";

			/// <summary>objectid</summary>
			public const string Regarding = "objectid";

			/// <summary>objectidtypecode</summary>
			public const string RegardingObjectType = "objectidtypecode";

			/// <summary>objecttypecode</summary>
			public const string ObjectType = "objecttypecode";

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

			/// <summary>prefix</summary>
			public const string Prefix = "prefix";

			/// <summary>stepid</summary>
			public const string StepId = "stepid";

			/// <summary>storagepointer</summary>
			public const string StoragePointer = "storagepointer";

			/// <summary>subject</summary>
			public const string Title = "subject";

			/// <summary>versionnumber</summary>
			public const string VersionNumber = "versionnumber";

		}
		#endregion

		#region Schemas
		public static class Schemas 
		{
			/// <summary>1:N Annotation_AsyncOperations</summary>
			public const string AnnotationAsyncOperations = "Annotation_AsyncOperations";

			/// <summary>1:N Annotation_BulkDeleteFailures</summary>
			public const string AnnotationBulkDeleteFailures = "Annotation_BulkDeleteFailures";

			/// <summary>1:N Annotation_ProcessSessions</summary>
			public const string AnnotationProcessSessions = "Annotation_ProcessSessions";

			/// <summary>1:N Annotation_SyncErrors</summary>
			public const string AnnotationSyncErrors = "Annotation_SyncErrors";

		}
		#endregion
	}
}

