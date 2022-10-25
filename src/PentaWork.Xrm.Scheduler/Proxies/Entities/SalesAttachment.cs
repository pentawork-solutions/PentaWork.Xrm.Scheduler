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
	[EntityLogicalName("salesliteratureitem")]
	public sealed class SalesAttachment : Entity
	{	
		public static readonly int? EntityTypeCode = 1070;
		public new const string LogicalName = "salesliteratureitem";
		public const string PrimaryIdAttribute = "salesliteratureitemid";
		public const string PrimaryNameAttribute = "title";
	
		public SalesAttachment() : base("salesliteratureitem") { }

		#region Attributes
		/// <summary>
        /// abstract
        /// </summary>
		[DisplayName("Abstract")]
		[AttributeLogicalName("abstract")]
		public string Abstract
		{	
			get { return GetAttributeValue<string>("abstract"); }
			set
			{ 
				if(value == Abstract) return;
				SetAttributeValue("abstract", value);
			}
		}	
			
		/// <summary>
        /// attacheddocumenturl
        /// </summary>
		[DisplayName("Attached Document URL")]
		[AttributeLogicalName("attacheddocumenturl")]
		public string AttachedDocumentURL
		{	
			get { return GetAttributeValue<string>("attacheddocumenturl"); }
			set
			{ 
				if(value == AttachedDocumentURL) return;
				SetAttributeValue("attacheddocumenturl", value);
			}
		}	
			
		/// <summary>
        /// authorname
        /// </summary>
		[DisplayName("Author Name")]
		[AttributeLogicalName("authorname")]
		public string AuthorName
		{	
			get { return GetAttributeValue<string>("authorname"); }
			set
			{ 
				if(value == AuthorName) return;
				SetAttributeValue("authorname", value);
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
        /// documentbody
        /// </summary>
		[DisplayName("documentbody")]
		[AttributeLogicalName("documentbody")]
		public string Documentbody
		{	
			get { return GetAttributeValue<string>("documentbody"); }
			set
			{ 
				if(value == Documentbody) return;
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
        /// filetype
        /// </summary>
		[DisplayName("filetype")]
		[AttributeLogicalName("filetype")]
		public int? Filetype
		{	
			get { return GetAttributeValue<int?>("filetype"); }
			set
			{ 
				if(value == Filetype) return;
				SetAttributeValue("filetype", value);
			}
		}	
			
		/// <summary>
        /// filetypecode
        /// </summary>
		[DisplayName("File Type")]
		[AttributeLogicalName("filetypecode")]
		public eFileType? FileType
		{	
			get 
			{ 
				var optionSetValue = GetAttributeValue<OptionSetValue>("filetypecode");
				if (optionSetValue != null) return (eFileType)optionSetValue.Value;
				else return null;
			}
			set 
			{ 
				if(value == FileType) return;

				OptionSetValue optionSetValue = null;
				if(value != null) optionSetValue = new OptionSetValue((int)value);
				SetAttributeValue("filetypecode", optionSetValue); 
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
        /// iscustomerviewable
        /// </summary>
		[DisplayName("Customer Viewable")]
		[AttributeLogicalName("iscustomerviewable")]
		public bool? CustomerViewable
		{	
			get { return GetAttributeValue<bool?>("iscustomerviewable"); }
			set
			{ 
				if(value == CustomerViewable) return;
				SetAttributeValue("iscustomerviewable", value);
			}
		}	
			
		/// <summary>
        /// keywords
        /// </summary>
		[DisplayName("Key Words")]
		[AttributeLogicalName("keywords")]
		public string KeyWords
		{	
			get { return GetAttributeValue<string>("keywords"); }
			set
			{ 
				if(value == KeyWords) return;
				SetAttributeValue("keywords", value);
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
        /// mode
        /// </summary>
		[DisplayName("Mode")]
		[AttributeLogicalName("mode")]
		public string Mode
		{	
			get { return GetAttributeValue<string>("mode"); }
			set
			{ 
				if(value == Mode) return;
				SetAttributeValue("mode", value);
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
        /// organizationid
        /// </summary>
		[DisplayName("Organization")]
		[AttributeLogicalName("organizationid")]
		public Guid OrganizationId
		{	
			get { return GetAttributeValue<Guid>("organizationid"); }
			set
			{ 
				if(value == OrganizationId) return;
				SetAttributeValue("organizationid", value);
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
        /// salesliteratureid
        /// </summary>
		[DisplayName("Sales Literature")]
		[AttributeLogicalName("salesliteratureid")]
		public EntityReference SalesLiterature
		{	
			get { return GetAttributeValue<EntityReference>("salesliteratureid"); }
			set
			{ 
				if(value == SalesLiterature) return;
				SetAttributeValue("salesliteratureid", value);
			}
		}	
			
		/// <summary>
        /// salesliteratureidname
        /// </summary>
		[DisplayName("salesliteratureidname")]
		[AttributeLogicalName("salesliteratureidname")]
		public string Salesliteratureidname
		{	
			get { return GetAttributeValue<string>("salesliteratureidname"); }
			set
			{ 
				if(value == Salesliteratureidname) return;
				SetAttributeValue("salesliteratureidname", value);
			}
		}	
			
		/// <summary>
        /// salesliteratureitemid
        /// </summary>
		[DisplayName("Sales Literature Item")]
		[AttributeLogicalName("salesliteratureitemid")]
		public override Guid Id
		{
			get => base.Id;
			set { base.Id = value; SetAttributeValue("salesliteratureitemid", value); }
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
        /// title
        /// </summary>
		[DisplayName("Title")]
		[AttributeLogicalName("title")]
		public string Title
		{	
			get { return GetAttributeValue<string>("title"); }
			set
			{ 
				if(value == Title) return;
				SetAttributeValue("title", value);
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
        /// 1:N Get entities for 'SalesLiteratureItem_AsyncOperations'
        /// </summary>
		[RelationshipSchemaName("SalesLiteratureItem_AsyncOperations")]
		public IEnumerable<SystemJob> SalesLiteratureItemAsyncOperations
		{
			get { return GetRelatedEntities<SystemJob>("SalesLiteratureItem_AsyncOperations", null); }
			set { SetRelatedEntities("SalesLiteratureItem_AsyncOperations", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'SalesLiteratureItem_BulkDeleteFailures'
        /// </summary>
		[RelationshipSchemaName("SalesLiteratureItem_BulkDeleteFailures")]
		public IEnumerable<BulkDeleteFailure> SalesLiteratureItemBulkDeleteFailures
		{
			get { return GetRelatedEntities<BulkDeleteFailure>("SalesLiteratureItem_BulkDeleteFailures", null); }
			set { SetRelatedEntities("SalesLiteratureItem_BulkDeleteFailures", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'salesliteratureitem_MailboxTrackingFolders'
        /// </summary>
		[RelationshipSchemaName("salesliteratureitem_MailboxTrackingFolders")]
		public IEnumerable<MailboxAutoTrackingFolder> SalesliteratureitemMailboxTrackingFolders
		{
			get { return GetRelatedEntities<MailboxAutoTrackingFolder>("salesliteratureitem_MailboxTrackingFolders", null); }
			set { SetRelatedEntities("salesliteratureitem_MailboxTrackingFolders", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'salesliteratureitem_PrincipalObjectAttributeAccesses'
        /// </summary>
		[RelationshipSchemaName("salesliteratureitem_PrincipalObjectAttributeAccesses")]
		public IEnumerable<FieldSharing> SalesliteratureitemPrincipalObjectAttributeAccesses
		{
			get { return GetRelatedEntities<FieldSharing>("salesliteratureitem_PrincipalObjectAttributeAccesses", null); }
			set { SetRelatedEntities("salesliteratureitem_PrincipalObjectAttributeAccesses", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'SalesLiteratureItem_ProcessSessions'
        /// </summary>
		[RelationshipSchemaName("SalesLiteratureItem_ProcessSessions")]
		public IEnumerable<ProcessSession> SalesLiteratureItemProcessSessions
		{
			get { return GetRelatedEntities<ProcessSession>("SalesLiteratureItem_ProcessSessions", null); }
			set { SetRelatedEntities("SalesLiteratureItem_ProcessSessions", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'salesliteratureitem_SyncErrors'
        /// </summary>
		[RelationshipSchemaName("salesliteratureitem_SyncErrors")]
		public IEnumerable<SyncError> SalesliteratureitemSyncErrors
		{
			get { return GetRelatedEntities<SyncError>("salesliteratureitem_SyncErrors", null); }
			set { SetRelatedEntities("salesliteratureitem_SyncErrors", null, value); }
		}
		#endregion

		#region Actions
		#endregion

		#region OptionSetEnums
		public enum eFileType
		{	
		
			[Label("Default Value")]
			[Description(@"")]
			DefaultValue = 1, 
		}
		
		#endregion	

		#region Properties
		public static class Properties 
		{
			/// <summary>abstract</summary>
			public const string Abstract = "abstract";

			/// <summary>attacheddocumenturl</summary>
			public const string AttachedDocumentURL = "attacheddocumenturl";

			/// <summary>authorname</summary>
			public const string AuthorName = "authorname";

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
			public const string Documentbody = "documentbody";

			/// <summary>filename</summary>
			public const string FileName = "filename";

			/// <summary>filesize</summary>
			public const string FileSizeBytes = "filesize";

			/// <summary>filetype</summary>
			public const string Filetype = "filetype";

			/// <summary>filetypecode</summary>
			public const string FileType = "filetypecode";

			/// <summary>importsequencenumber</summary>
			public const string ImportSequenceNumber = "importsequencenumber";

			/// <summary>iscustomerviewable</summary>
			public const string CustomerViewable = "iscustomerviewable";

			/// <summary>keywords</summary>
			public const string KeyWords = "keywords";

			/// <summary>mimetype</summary>
			public const string MimeType = "mimetype";

			/// <summary>mode</summary>
			public const string Mode = "mode";

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

			/// <summary>organizationid</summary>
			public const string OrganizationId = "organizationid";

			/// <summary>overriddencreatedon</summary>
			public const string RecordCreatedOn = "overriddencreatedon";

			/// <summary>salesliteratureid</summary>
			public const string SalesLiterature = "salesliteratureid";

			/// <summary>salesliteratureidname</summary>
			public const string Salesliteratureidname = "salesliteratureidname";

			/// <summary>salesliteratureitemid</summary>
			public const string SalesLiteratureItemId = "salesliteratureitemid";

			/// <summary>timezoneruleversionnumber</summary>
			public const string TimeZoneRuleVersionNumber = "timezoneruleversionnumber";

			/// <summary>title</summary>
			public const string Title = "title";

			/// <summary>utcconversiontimezonecode</summary>
			public const string UTCConversionTimeZoneCode = "utcconversiontimezonecode";

			/// <summary>versionnumber</summary>
			public const string VersionNumber = "versionnumber";

		}
		#endregion

		#region Schemas
		public static class Schemas 
		{
			/// <summary>1:N SalesLiteratureItem_AsyncOperations</summary>
			public const string SalesLiteratureItemAsyncOperations = "SalesLiteratureItem_AsyncOperations";

			/// <summary>1:N SalesLiteratureItem_BulkDeleteFailures</summary>
			public const string SalesLiteratureItemBulkDeleteFailures = "SalesLiteratureItem_BulkDeleteFailures";

			/// <summary>1:N salesliteratureitem_MailboxTrackingFolders</summary>
			public const string SalesliteratureitemMailboxTrackingFolders = "salesliteratureitem_MailboxTrackingFolders";

			/// <summary>1:N salesliteratureitem_PrincipalObjectAttributeAccesses</summary>
			public const string SalesliteratureitemPrincipalObjectAttributeAccesses = "salesliteratureitem_PrincipalObjectAttributeAccesses";

			/// <summary>1:N SalesLiteratureItem_ProcessSessions</summary>
			public const string SalesLiteratureItemProcessSessions = "SalesLiteratureItem_ProcessSessions";

			/// <summary>1:N salesliteratureitem_SyncErrors</summary>
			public const string SalesliteratureitemSyncErrors = "salesliteratureitem_SyncErrors";

		}
		#endregion
	}
}

