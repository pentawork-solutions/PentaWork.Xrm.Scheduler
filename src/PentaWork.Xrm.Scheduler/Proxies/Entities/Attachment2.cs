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
	[EntityLogicalName("attachment")]
	public sealed class Attachment2 : Entity
	{	
		public static readonly int? EntityTypeCode = 1002;
		public new const string LogicalName = "attachment";
		public const string PrimaryIdAttribute = "attachmentid";
		public const string PrimaryNameAttribute = "filename";
	
		public Attachment2() : base("attachment") { }

		#region Attributes
		/// <summary>
        /// attachmentid
        /// </summary>
		[DisplayName("Attachment")]
		[AttributeLogicalName("attachmentid")]
		public override Guid Id
		{
			get => base.Id;
			set { base.Id = value; SetAttributeValue("attachmentid", value); }
		}

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
		[DisplayName("Subject")]
		[AttributeLogicalName("subject")]
		public string Subject
		{	
			get { return GetAttributeValue<string>("subject"); }
			set
			{ 
				if(value == Subject) return;
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
        /// 1:N Get entities for 'attachment_activity_mime_attachments'
        /// </summary>
		[RelationshipSchemaName("attachment_activity_mime_attachments")]
		public IEnumerable<Attachment> AttachmentActivityMimeAttachments
		{
			get { return GetRelatedEntities<Attachment>("attachment_activity_mime_attachments", null); }
			set { SetRelatedEntities("attachment_activity_mime_attachments", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'Attachment_SyncErrors'
        /// </summary>
		[RelationshipSchemaName("Attachment_SyncErrors")]
		public IEnumerable<SyncError> AttachmentSyncErrors
		{
			get { return GetRelatedEntities<SyncError>("Attachment_SyncErrors", null); }
			set { SetRelatedEntities("Attachment_SyncErrors", null, value); }
		}
		#endregion

		#region Actions
		#endregion

		#region OptionSetEnums
		#endregion	

		#region Properties
		public static class Properties 
		{
			/// <summary>attachmentid</summary>
			public const string AttachmentId = "attachmentid";

			/// <summary>body</summary>
			public const string Body = "body";

			/// <summary>filename</summary>
			public const string FileName = "filename";

			/// <summary>filepointer</summary>
			public const string FilePointer = "filepointer";

			/// <summary>filesize</summary>
			public const string FileSizeBytes = "filesize";

			/// <summary>mimetype</summary>
			public const string MIMEType = "mimetype";

			/// <summary>prefix</summary>
			public const string Prefix = "prefix";

			/// <summary>storagepointer</summary>
			public const string StoragePointer = "storagepointer";

			/// <summary>subject</summary>
			public const string Subject = "subject";

			/// <summary>versionnumber</summary>
			public const string VersionNumber = "versionnumber";

		}
		#endregion

		#region Schemas
		public static class Schemas 
		{
			/// <summary>1:N attachment_activity_mime_attachments</summary>
			public const string AttachmentActivityMimeAttachments = "attachment_activity_mime_attachments";

			/// <summary>1:N Attachment_SyncErrors</summary>
			public const string AttachmentSyncErrors = "Attachment_SyncErrors";

		}
		#endregion
	}
}

