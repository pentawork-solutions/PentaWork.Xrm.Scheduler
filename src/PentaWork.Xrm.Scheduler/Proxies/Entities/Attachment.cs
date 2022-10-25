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
	[EntityLogicalName("activitymimeattachment")]
	public sealed class Attachment : Entity
	{	
		public static readonly int? EntityTypeCode = 1001;
		public new const string LogicalName = "activitymimeattachment";
		public const string PrimaryIdAttribute = "activitymimeattachmentid";
		public const string PrimaryNameAttribute = "filename";
	
		public Attachment() : base("activitymimeattachment") { }

		#region Attributes
		/// <summary>
        /// activityid
        /// </summary>
		[DisplayName("Regarding")]
		[AttributeLogicalName("activityid")]
		public EntityReference Regarding
		{	
			get { return GetAttributeValue<EntityReference>("activityid"); }
			set
			{ 
				if(value == Regarding) return;
				SetAttributeValue("activityid", value);
			}
		}	
			
		/// <summary>
        /// activitymimeattachmentid
        /// </summary>
		[DisplayName("Activity Mime Attachment")]
		[AttributeLogicalName("activitymimeattachmentid")]
		public override Guid Id
		{
			get => base.Id;
			set { base.Id = value; SetAttributeValue("activitymimeattachmentid", value); }
		}

							/// <summary>
        /// activitymimeattachmentidunique
        /// </summary>
		[DisplayName("activitymimeattachmentidunique")]
		[AttributeLogicalName("activitymimeattachmentidunique")]
		public Guid ActivitymimeattachmentiduniqueId
		{	
			get { return GetAttributeValue<Guid>("activitymimeattachmentidunique"); }
			set
			{ 
				if(value == ActivitymimeattachmentiduniqueId) return;
				SetAttributeValue("activitymimeattachmentidunique", value);
			}
		}	
			
		/// <summary>
        /// activitysubject
        /// </summary>
		[DisplayName("ActivitySubject")]
		[AttributeLogicalName("activitysubject")]
		public string ActivitySubject
		{	
			get { return GetAttributeValue<string>("activitysubject"); }
			set
			{ 
				if(value == ActivitySubject) return;
				SetAttributeValue("activitysubject", value);
			}
		}	
			
		/// <summary>
        /// anonymouslink
        /// </summary>
		[DisplayName("For internal use only.")]
		[AttributeLogicalName("anonymouslink")]
		public string ForInternalUseOnly
		{	
			get { return GetAttributeValue<string>("anonymouslink"); }
			set
			{ 
				if(value == ForInternalUseOnly) return;
				SetAttributeValue("anonymouslink", value);
			}
		}	
			
		/// <summary>
        /// attachmentcontentid
        /// </summary>
		[DisplayName("Content Id")]
		[AttributeLogicalName("attachmentcontentid")]
		public string ContentId
		{	
			get { return GetAttributeValue<string>("attachmentcontentid"); }
			set
			{ 
				if(value == ContentId) return;
				SetAttributeValue("attachmentcontentid", value);
			}
		}	
			
		/// <summary>
        /// attachmentid
        /// </summary>
		[DisplayName("Attachment")]
		[AttributeLogicalName("attachmentid")]
		public EntityReference Attachment2
		{	
			get { return GetAttributeValue<EntityReference>("attachmentid"); }
			set
			{ 
				if(value == Attachment2) return;
				SetAttributeValue("attachmentid", value);
			}
		}	
			
		/// <summary>
        /// attachmentnumber
        /// </summary>
		[DisplayName("Attachment Number")]
		[AttributeLogicalName("attachmentnumber")]
		public int? AttachmentNumber
		{	
			get { return GetAttributeValue<int?>("attachmentnumber"); }
			set
			{ 
				if(value == AttachmentNumber) return;
				SetAttributeValue("attachmentnumber", value);
			}
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
        /// isfollowed
        /// </summary>
		[DisplayName("Followed")]
		[AttributeLogicalName("isfollowed")]
		public bool? Followed
		{	
			get { return GetAttributeValue<bool?>("isfollowed"); }
			set
			{ 
				if(value == Followed) return;
				SetAttributeValue("isfollowed", value);
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
        /// objectid
        /// </summary>
		[DisplayName("Item")]
		[AttributeLogicalName("objectid")]
		public EntityReference Item
		{	
			get { return GetAttributeValue<EntityReference>("objectid"); }
			set
			{ 
				if(value == Item) return;
				SetAttributeValue("objectid", value);
			}
		}	
			
		/// <summary>
        /// objecttypecode
        /// </summary>
		[DisplayName("Entity")]
		[AttributeLogicalName("objecttypecode")]
		public string Entity
		{	
			get { return GetAttributeValue<string>("objecttypecode"); }
			set
			{ 
				if(value == Entity) return;
				SetAttributeValue("objecttypecode", value);
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
        /// owninguser
        /// </summary>
		[DisplayName("Owner")]
		[AttributeLogicalName("owninguser")]
		public EntityReference Owner2
		{	
			get { return GetAttributeValue<EntityReference>("owninguser"); }
			set
			{ 
				if(value == Owner2) return;
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
        /// 1:N Get entities for 'ActivityMimeAttachment_AsyncOperations'
        /// </summary>
		[RelationshipSchemaName("ActivityMimeAttachment_AsyncOperations")]
		public IEnumerable<SystemJob> ActivityMimeAttachmentAsyncOperations
		{
			get { return GetRelatedEntities<SystemJob>("ActivityMimeAttachment_AsyncOperations", null); }
			set { SetRelatedEntities("ActivityMimeAttachment_AsyncOperations", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'ActivityMimeAttachment_BulkDeleteFailures'
        /// </summary>
		[RelationshipSchemaName("ActivityMimeAttachment_BulkDeleteFailures")]
		public IEnumerable<BulkDeleteFailure> ActivityMimeAttachmentBulkDeleteFailures
		{
			get { return GetRelatedEntities<BulkDeleteFailure>("ActivityMimeAttachment_BulkDeleteFailures", null); }
			set { SetRelatedEntities("ActivityMimeAttachment_BulkDeleteFailures", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'ActivityMimeAttachment_SyncErrors'
        /// </summary>
		[RelationshipSchemaName("ActivityMimeAttachment_SyncErrors")]
		public IEnumerable<SyncError> ActivityMimeAttachmentSyncErrors
		{
			get { return GetRelatedEntities<SyncError>("ActivityMimeAttachment_SyncErrors", null); }
			set { SetRelatedEntities("ActivityMimeAttachment_SyncErrors", null, value); }
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
		
		#endregion	

		#region Properties
		public static class Properties 
		{
			/// <summary>activityid</summary>
			public const string Regarding = "activityid";

			/// <summary>activitymimeattachmentid</summary>
			public const string ActivityMimeAttachmentId = "activitymimeattachmentid";

			/// <summary>activitymimeattachmentidunique</summary>
			public const string ActivitymimeattachmentiduniqueId = "activitymimeattachmentidunique";

			/// <summary>activitysubject</summary>
			public const string ActivitySubject = "activitysubject";

			/// <summary>anonymouslink</summary>
			public const string ForInternalUseOnly = "anonymouslink";

			/// <summary>attachmentcontentid</summary>
			public const string ContentId = "attachmentcontentid";

			/// <summary>attachmentid</summary>
			public const string Attachment2 = "attachmentid";

			/// <summary>attachmentnumber</summary>
			public const string AttachmentNumber = "attachmentnumber";

			/// <summary>body</summary>
			public const string Body = "body";

			/// <summary>componentstate</summary>
			public const string ComponentState = "componentstate";

			/// <summary>filename</summary>
			public const string FileName = "filename";

			/// <summary>filesize</summary>
			public const string FileSizeBytes = "filesize";

			/// <summary>isfollowed</summary>
			public const string Followed = "isfollowed";

			/// <summary>ismanaged</summary>
			public const string IsManaged = "ismanaged";

			/// <summary>mimetype</summary>
			public const string MimeType = "mimetype";

			/// <summary>objectid</summary>
			public const string Item = "objectid";

			/// <summary>objecttypecode</summary>
			public const string Entity = "objecttypecode";

			/// <summary>overwritetime</summary>
			public const string RecordOverwriteTime = "overwritetime";

			/// <summary>ownerid</summary>
			public const string Owner = "ownerid";

			/// <summary>owneridname</summary>
			public const string Owneridname = "owneridname";

			/// <summary>owneridtype</summary>
			public const string Owneridtype = "owneridtype";

			/// <summary>owningbusinessunit</summary>
			public const string OwningBusinessUnit = "owningbusinessunit";

			/// <summary>owninguser</summary>
			public const string Owner2 = "owninguser";

			/// <summary>solutionid</summary>
			public const string SolutionId = "solutionid";

			/// <summary>subject</summary>
			public const string Subject = "subject";

			/// <summary>supportingsolutionid</summary>
			public const string SolutionId2 = "supportingsolutionid";

			/// <summary>versionnumber</summary>
			public const string VersionNumber = "versionnumber";

		}
		#endregion

		#region Schemas
		public static class Schemas 
		{
			/// <summary>1:N ActivityMimeAttachment_AsyncOperations</summary>
			public const string ActivityMimeAttachmentAsyncOperations = "ActivityMimeAttachment_AsyncOperations";

			/// <summary>1:N ActivityMimeAttachment_BulkDeleteFailures</summary>
			public const string ActivityMimeAttachmentBulkDeleteFailures = "ActivityMimeAttachment_BulkDeleteFailures";

			/// <summary>1:N ActivityMimeAttachment_SyncErrors</summary>
			public const string ActivityMimeAttachmentSyncErrors = "ActivityMimeAttachment_SyncErrors";

		}
		#endregion
	}
}

