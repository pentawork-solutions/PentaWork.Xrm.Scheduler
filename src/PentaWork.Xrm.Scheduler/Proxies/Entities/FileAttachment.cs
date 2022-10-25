using System;
using System.Linq;
using System.Diagnostics;
using System.ComponentModel;
using Microsoft.Xrm.Sdk; 
using Microsoft.Xrm.Sdk.Client;
using System.Collections.Generic;

namespace PentaWork.Xrm.Scheduler.Proxies.Entities
{
	[DebuggerDisplay("{FileName}")] 	
	[EntityLogicalName("fileattachment")]
	public sealed class FileAttachment : Entity
	{	
		public static readonly int? EntityTypeCode = 55;
		public new const string LogicalName = "fileattachment";
		public const string PrimaryIdAttribute = "fileattachmentid";
		public const string PrimaryNameAttribute = "filename";
	
		public FileAttachment() : base("fileattachment") { }

		#region Attributes
		/// <summary>
        /// body
        /// </summary>
		[DisplayName("Body")]
		[AttributeLogicalName("body")]
		public string Body
		{	
			get { return GetAttributeValue<string>("body"); }
			set
			{ 
				if(value == Body) return;
				SetAttributeValue("body", value);
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
        /// fileattachmentid
        /// </summary>
		[DisplayName("FileAttachmentId")]
		[AttributeLogicalName("fileattachmentid")]
		public override Guid Id
		{
			get => base.Id;
			set { base.Id = value; SetAttributeValue("fileattachmentid", value); }
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
        /// filesizeinbytes
        /// </summary>
		[DisplayName("File Size (Bytes)")]
		[AttributeLogicalName("filesizeinbytes")]
		public int? FileSizeBytes
		{	
			get { return GetAttributeValue<int?>("filesizeinbytes"); }
			set
			{ 
				if(value == FileSizeBytes) return;
				SetAttributeValue("filesizeinbytes", value);
			}
		}	
			
		/// <summary>
        /// iscommitted
        /// </summary>
		[DisplayName("IsCommitted")]
		[AttributeLogicalName("iscommitted")]
		public bool? IsCommitted
		{	
			get { return GetAttributeValue<bool?>("iscommitted"); }
			set
			{ 
				if(value == IsCommitted) return;
				SetAttributeValue("iscommitted", value);
			}
		}	
			
		/// <summary>
        /// mimetype
        /// </summary>
		[DisplayName("MIME Type")]
		[AttributeLogicalName("mimetype")]
		public string MIMEType
		{	
			get { return GetAttributeValue<string>("mimetype"); }
			set
			{ 
				if(value == MIMEType) return;
				SetAttributeValue("mimetype", value);
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
		[DisplayName("Object Id Type Code")]
		[AttributeLogicalName("objectidtypecode")]
		public string ObjectIdTypeCode
		{	
			get { return GetAttributeValue<string>("objectidtypecode"); }
			set
			{ 
				if(value == ObjectIdTypeCode) return;
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
        /// regardingfieldname
        /// </summary>
		[DisplayName("Regarding Attribute Schema Name")]
		[AttributeLogicalName("regardingfieldname")]
		public string RegardingAttributeSchemaName
		{	
			get { return GetAttributeValue<string>("regardingfieldname"); }
			set
			{ 
				if(value == RegardingAttributeSchemaName) return;
				SetAttributeValue("regardingfieldname", value);
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
        /// 1:N Get entities for 'FileAttachment_AsyncOperation_DataBlobId'
        /// </summary>
		[RelationshipSchemaName("FileAttachment_AsyncOperation_DataBlobId")]
		public IEnumerable<SystemJob> FileAttachmentAsyncOperationDataBlobId
		{
			get { return GetRelatedEntities<SystemJob>("FileAttachment_AsyncOperation_DataBlobId", null); }
			set { SetRelatedEntities("FileAttachment_AsyncOperation_DataBlobId", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'FileAttachment_CanvasApp_Assets'
        /// </summary>
		[RelationshipSchemaName("FileAttachment_CanvasApp_Assets")]
		public IEnumerable<CanvasApp> FileAttachmentCanvasAppAssets
		{
			get { return GetRelatedEntities<CanvasApp>("FileAttachment_CanvasApp_Assets", null); }
			set { SetRelatedEntities("FileAttachment_CanvasApp_Assets", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'FileAttachment_CanvasApp_BackgroundImage'
        /// </summary>
		[RelationshipSchemaName("FileAttachment_CanvasApp_BackgroundImage")]
		public IEnumerable<CanvasApp> FileAttachmentCanvasAppBackgroundImage
		{
			get { return GetRelatedEntities<CanvasApp>("FileAttachment_CanvasApp_BackgroundImage", null); }
			set { SetRelatedEntities("FileAttachment_CanvasApp_BackgroundImage", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'FileAttachment_CanvasApp_Document'
        /// </summary>
		[RelationshipSchemaName("FileAttachment_CanvasApp_Document")]
		public IEnumerable<CanvasApp> FileAttachmentCanvasAppDocument
		{
			get { return GetRelatedEntities<CanvasApp>("FileAttachment_CanvasApp_Document", null); }
			set { SetRelatedEntities("FileAttachment_CanvasApp_Document", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'FileAttachment_CanvasApp_LargeIcon'
        /// </summary>
		[RelationshipSchemaName("FileAttachment_CanvasApp_LargeIcon")]
		public IEnumerable<CanvasApp> FileAttachmentCanvasAppLargeIcon
		{
			get { return GetRelatedEntities<CanvasApp>("FileAttachment_CanvasApp_LargeIcon", null); }
			set { SetRelatedEntities("FileAttachment_CanvasApp_LargeIcon", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'FileAttachment_CanvasApp_MediumIcon'
        /// </summary>
		[RelationshipSchemaName("FileAttachment_CanvasApp_MediumIcon")]
		public IEnumerable<CanvasApp> FileAttachmentCanvasAppMediumIcon
		{
			get { return GetRelatedEntities<CanvasApp>("FileAttachment_CanvasApp_MediumIcon", null); }
			set { SetRelatedEntities("FileAttachment_CanvasApp_MediumIcon", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'FileAttachment_CanvasApp_SmallIcon'
        /// </summary>
		[RelationshipSchemaName("FileAttachment_CanvasApp_SmallIcon")]
		public IEnumerable<CanvasApp> FileAttachmentCanvasAppSmallIcon
		{
			get { return GetRelatedEntities<CanvasApp>("FileAttachment_CanvasApp_SmallIcon", null); }
			set { SetRelatedEntities("FileAttachment_CanvasApp_SmallIcon", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'FileAttachment_CanvasApp_TeamsIcon'
        /// </summary>
		[RelationshipSchemaName("FileAttachment_CanvasApp_TeamsIcon")]
		public IEnumerable<CanvasApp> FileAttachmentCanvasAppTeamsIcon
		{
			get { return GetRelatedEntities<CanvasApp>("FileAttachment_CanvasApp_TeamsIcon", null); }
			set { SetRelatedEntities("FileAttachment_CanvasApp_TeamsIcon", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'FileAttachment_CanvasApp_WideIcon'
        /// </summary>
		[RelationshipSchemaName("FileAttachment_CanvasApp_WideIcon")]
		public IEnumerable<CanvasApp> FileAttachmentCanvasAppWideIcon
		{
			get { return GetRelatedEntities<CanvasApp>("FileAttachment_CanvasApp_WideIcon", null); }
			set { SetRelatedEntities("FileAttachment_CanvasApp_WideIcon", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'FileAttachment_ExportSolutionUpload_SolutionFile'
        /// </summary>
		[RelationshipSchemaName("FileAttachment_ExportSolutionUpload_SolutionFile")]
		public IEnumerable<ExportSolutionUpload> FileAttachmentExportSolutionUploadSolutionFile
		{
			get { return GetRelatedEntities<ExportSolutionUpload>("FileAttachment_ExportSolutionUpload_SolutionFile", null); }
			set { SetRelatedEntities("FileAttachment_ExportSolutionUpload_SolutionFile", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'FileAttachment_FlowSession_AdditionalContext'
        /// </summary>
		[RelationshipSchemaName("FileAttachment_FlowSession_AdditionalContext")]
		public IEnumerable<FlowSession> FileAttachmentFlowSessionAdditionalContext
		{
			get { return GetRelatedEntities<FlowSession>("FileAttachment_FlowSession_AdditionalContext", null); }
			set { SetRelatedEntities("FileAttachment_FlowSession_AdditionalContext", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'FileAttachment_FlowSession_Outputs'
        /// </summary>
		[RelationshipSchemaName("FileAttachment_FlowSession_Outputs")]
		public IEnumerable<FlowSession> FileAttachmentFlowSessionOutputs
		{
			get { return GetRelatedEntities<FlowSession>("FileAttachment_FlowSession_Outputs", null); }
			set { SetRelatedEntities("FileAttachment_FlowSession_Outputs", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'FileAttachment_Mailbox_ExchangeSyncStateXmlFileRef'
        /// </summary>
		[RelationshipSchemaName("FileAttachment_Mailbox_ExchangeSyncStateXmlFileRef")]
		public IEnumerable<Mailbox> FileAttachmentMailboxExchangeSyncStateXmlFileRef
		{
			get { return GetRelatedEntities<Mailbox>("FileAttachment_Mailbox_ExchangeSyncStateXmlFileRef", null); }
			set { SetRelatedEntities("FileAttachment_Mailbox_ExchangeSyncStateXmlFileRef", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'FileAttachment_msdyn_AIBFile_msdyn_File'
        /// </summary>
		[RelationshipSchemaName("FileAttachment_msdyn_AIBFile_msdyn_File")]
		public IEnumerable<AIBuilderFile> FileAttachmentMsdynAIBFileMsdynFile
		{
			get { return GetRelatedEntities<AIBuilderFile>("FileAttachment_msdyn_AIBFile_msdyn_File", null); }
			set { SetRelatedEntities("FileAttachment_msdyn_AIBFile_msdyn_File", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'FileAttachment_msdyn_AIConfiguration_msdyn_Model'
        /// </summary>
		[RelationshipSchemaName("FileAttachment_msdyn_AIConfiguration_msdyn_Model")]
		public IEnumerable<AIConfiguration> FileAttachmentMsdynAIConfigurationMsdynModel
		{
			get { return GetRelatedEntities<AIConfiguration>("FileAttachment_msdyn_AIConfiguration_msdyn_Model", null); }
			set { SetRelatedEntities("FileAttachment_msdyn_AIConfiguration_msdyn_Model", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'FileAttachment_msdyn_knowledgearticleimage_msdyn_BlobFile'
        /// </summary>
		[RelationshipSchemaName("FileAttachment_msdyn_knowledgearticleimage_msdyn_BlobFile")]
		public IEnumerable<KnowledgeArticleImage> FileAttachmentMsdynKnowledgearticleimageMsdynBlobFile
		{
			get { return GetRelatedEntities<KnowledgeArticleImage>("FileAttachment_msdyn_knowledgearticleimage_msdyn_BlobFile", null); }
			set { SetRelatedEntities("FileAttachment_msdyn_knowledgearticleimage_msdyn_BlobFile", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'FileAttachment_msdyn_richtextfile_msdyn_fileblob'
        /// </summary>
		[RelationshipSchemaName("FileAttachment_msdyn_richtextfile_msdyn_fileblob")]
		public IEnumerable<RichTextAttachment> FileAttachmentMsdynRichtextfileMsdynFileblob
		{
			get { return GetRelatedEntities<RichTextAttachment>("FileAttachment_msdyn_richtextfile_msdyn_fileblob", null); }
			set { SetRelatedEntities("FileAttachment_msdyn_richtextfile_msdyn_fileblob", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'fileattachment_solution_fileid'
        /// </summary>
		[RelationshipSchemaName("fileattachment_solution_fileid")]
		public IEnumerable<Solution> FileattachmentSolutionFileid
		{
			get { return GetRelatedEntities<Solution>("fileattachment_solution_fileid", null); }
			set { SetRelatedEntities("fileattachment_solution_fileid", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'FileAttachment_StageSolutionUpload_SolutionFile'
        /// </summary>
		[RelationshipSchemaName("FileAttachment_StageSolutionUpload_SolutionFile")]
		public IEnumerable<StageSolutionUpload> FileAttachmentStageSolutionUploadSolutionFile
		{
			get { return GetRelatedEntities<StageSolutionUpload>("FileAttachment_StageSolutionUpload_SolutionFile", null); }
			set { SetRelatedEntities("FileAttachment_StageSolutionUpload_SolutionFile", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'FileAttachment_SyncErrors'
        /// </summary>
		[RelationshipSchemaName("FileAttachment_SyncErrors")]
		public IEnumerable<SyncError> FileAttachmentSyncErrors
		{
			get { return GetRelatedEntities<SyncError>("FileAttachment_SyncErrors", null); }
			set { SetRelatedEntities("FileAttachment_SyncErrors", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'FileAttachment_workflowbinary_Data'
        /// </summary>
		[RelationshipSchemaName("FileAttachment_workflowbinary_Data")]
		public IEnumerable<WorkflowBinary> FileAttachmentWorkflowbinaryData
		{
			get { return GetRelatedEntities<WorkflowBinary>("FileAttachment_workflowbinary_Data", null); }
			set { SetRelatedEntities("FileAttachment_workflowbinary_Data", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'FileAttachment_WorkflowLog_Inputs'
        /// </summary>
		[RelationshipSchemaName("FileAttachment_WorkflowLog_Inputs")]
		public IEnumerable<ProcessLog> FileAttachmentWorkflowLogInputs
		{
			get { return GetRelatedEntities<ProcessLog>("FileAttachment_WorkflowLog_Inputs", null); }
			set { SetRelatedEntities("FileAttachment_WorkflowLog_Inputs", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'FileAttachment_WorkflowLog_Outputs'
        /// </summary>
		[RelationshipSchemaName("FileAttachment_WorkflowLog_Outputs")]
		public IEnumerable<ProcessLog> FileAttachmentWorkflowLogOutputs
		{
			get { return GetRelatedEntities<ProcessLog>("FileAttachment_WorkflowLog_Outputs", null); }
			set { SetRelatedEntities("FileAttachment_WorkflowLog_Outputs", null, value); }
		}
		#endregion

		#region Actions
		#endregion

		#region OptionSetEnums
		#endregion	

		#region Properties
		public static class Properties 
		{
			/// <summary>body</summary>
			public const string Body = "body";

			/// <summary>createdon</summary>
			public const string CreatedOn = "createdon";

			/// <summary>fileattachmentid</summary>
			public const string FileAttachmentId = "fileattachmentid";

			/// <summary>filename</summary>
			public const string FileName = "filename";

			/// <summary>filepointer</summary>
			public const string FilePointer = "filepointer";

			/// <summary>filesizeinbytes</summary>
			public const string FileSizeBytes = "filesizeinbytes";

			/// <summary>iscommitted</summary>
			public const string IsCommitted = "iscommitted";

			/// <summary>mimetype</summary>
			public const string MIMEType = "mimetype";

			/// <summary>objectid</summary>
			public const string Regarding = "objectid";

			/// <summary>objectidtypecode</summary>
			public const string ObjectIdTypeCode = "objectidtypecode";

			/// <summary>objecttypecode</summary>
			public const string ObjectType = "objecttypecode";

			/// <summary>prefix</summary>
			public const string Prefix = "prefix";

			/// <summary>regardingfieldname</summary>
			public const string RegardingAttributeSchemaName = "regardingfieldname";

			/// <summary>storagepointer</summary>
			public const string StoragePointer = "storagepointer";

			/// <summary>versionnumber</summary>
			public const string VersionNumber = "versionnumber";

		}
		#endregion

		#region Schemas
		public static class Schemas 
		{
			/// <summary>1:N FileAttachment_AsyncOperation_DataBlobId</summary>
			public const string FileAttachmentAsyncOperationDataBlobId = "FileAttachment_AsyncOperation_DataBlobId";

			/// <summary>1:N FileAttachment_CanvasApp_Assets</summary>
			public const string FileAttachmentCanvasAppAssets = "FileAttachment_CanvasApp_Assets";

			/// <summary>1:N FileAttachment_CanvasApp_BackgroundImage</summary>
			public const string FileAttachmentCanvasAppBackgroundImage = "FileAttachment_CanvasApp_BackgroundImage";

			/// <summary>1:N FileAttachment_CanvasApp_Document</summary>
			public const string FileAttachmentCanvasAppDocument = "FileAttachment_CanvasApp_Document";

			/// <summary>1:N FileAttachment_CanvasApp_LargeIcon</summary>
			public const string FileAttachmentCanvasAppLargeIcon = "FileAttachment_CanvasApp_LargeIcon";

			/// <summary>1:N FileAttachment_CanvasApp_MediumIcon</summary>
			public const string FileAttachmentCanvasAppMediumIcon = "FileAttachment_CanvasApp_MediumIcon";

			/// <summary>1:N FileAttachment_CanvasApp_SmallIcon</summary>
			public const string FileAttachmentCanvasAppSmallIcon = "FileAttachment_CanvasApp_SmallIcon";

			/// <summary>1:N FileAttachment_CanvasApp_TeamsIcon</summary>
			public const string FileAttachmentCanvasAppTeamsIcon = "FileAttachment_CanvasApp_TeamsIcon";

			/// <summary>1:N FileAttachment_CanvasApp_WideIcon</summary>
			public const string FileAttachmentCanvasAppWideIcon = "FileAttachment_CanvasApp_WideIcon";

			/// <summary>1:N FileAttachment_ExportSolutionUpload_SolutionFile</summary>
			public const string FileAttachmentExportSolutionUploadSolutionFile = "FileAttachment_ExportSolutionUpload_SolutionFile";

			/// <summary>1:N FileAttachment_FlowSession_AdditionalContext</summary>
			public const string FileAttachmentFlowSessionAdditionalContext = "FileAttachment_FlowSession_AdditionalContext";

			/// <summary>1:N FileAttachment_FlowSession_Outputs</summary>
			public const string FileAttachmentFlowSessionOutputs = "FileAttachment_FlowSession_Outputs";

			/// <summary>1:N FileAttachment_Mailbox_ExchangeSyncStateXmlFileRef</summary>
			public const string FileAttachmentMailboxExchangeSyncStateXmlFileRef = "FileAttachment_Mailbox_ExchangeSyncStateXmlFileRef";

			/// <summary>1:N FileAttachment_msdyn_AIBFile_msdyn_File</summary>
			public const string FileAttachmentMsdynAIBFileMsdynFile = "FileAttachment_msdyn_AIBFile_msdyn_File";

			/// <summary>1:N FileAttachment_msdyn_AIConfiguration_msdyn_Model</summary>
			public const string FileAttachmentMsdynAIConfigurationMsdynModel = "FileAttachment_msdyn_AIConfiguration_msdyn_Model";

			/// <summary>1:N FileAttachment_msdyn_knowledgearticleimage_msdyn_BlobFile</summary>
			public const string FileAttachmentMsdynKnowledgearticleimageMsdynBlobFile = "FileAttachment_msdyn_knowledgearticleimage_msdyn_BlobFile";

			/// <summary>1:N FileAttachment_msdyn_richtextfile_msdyn_fileblob</summary>
			public const string FileAttachmentMsdynRichtextfileMsdynFileblob = "FileAttachment_msdyn_richtextfile_msdyn_fileblob";

			/// <summary>1:N fileattachment_solution_fileid</summary>
			public const string FileattachmentSolutionFileid = "fileattachment_solution_fileid";

			/// <summary>1:N FileAttachment_StageSolutionUpload_SolutionFile</summary>
			public const string FileAttachmentStageSolutionUploadSolutionFile = "FileAttachment_StageSolutionUpload_SolutionFile";

			/// <summary>1:N FileAttachment_SyncErrors</summary>
			public const string FileAttachmentSyncErrors = "FileAttachment_SyncErrors";

			/// <summary>1:N FileAttachment_workflowbinary_Data</summary>
			public const string FileAttachmentWorkflowbinaryData = "FileAttachment_workflowbinary_Data";

			/// <summary>1:N FileAttachment_WorkflowLog_Inputs</summary>
			public const string FileAttachmentWorkflowLogInputs = "FileAttachment_WorkflowLog_Inputs";

			/// <summary>1:N FileAttachment_WorkflowLog_Outputs</summary>
			public const string FileAttachmentWorkflowLogOutputs = "FileAttachment_WorkflowLog_Outputs";

		}
		#endregion
	}
}

