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
	[EntityLogicalName("msdyn_knowledgearticletemplate")]
	public sealed class KnowledgeArticleTemplate : Entity
	{	
		public static readonly int? EntityTypeCode = 10047;
		public new const string LogicalName = "msdyn_knowledgearticletemplate";
		public const string PrimaryIdAttribute = "msdyn_knowledgearticletemplateid";
		public const string PrimaryNameAttribute = "msdyn_name";
	
		public KnowledgeArticleTemplate() : base("msdyn_knowledgearticletemplate") { }

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
        /// msdyn_content
        /// </summary>
		[DisplayName("Content")]
		[AttributeLogicalName("msdyn_content")]
		public string Content
		{	
			get { return GetAttributeValue<string>("msdyn_content"); }
			set
			{ 
				if(value == Content) return;
				SetAttributeValue("msdyn_content", value);
			}
		}	
			
		/// <summary>
        /// msdyn_description
        /// </summary>
		[DisplayName("Description")]
		[AttributeLogicalName("msdyn_description")]
		public string Description
		{	
			get { return GetAttributeValue<string>("msdyn_description"); }
			set
			{ 
				if(value == Description) return;
				SetAttributeValue("msdyn_description", value);
			}
		}	
			
		/// <summary>
        /// msdyn_isinternal
        /// </summary>
		[DisplayName("Internal")]
		[AttributeLogicalName("msdyn_isinternal")]
		public bool? Internal
		{	
			get { return GetAttributeValue<bool?>("msdyn_isinternal"); }
			set
			{ 
				if(value == Internal) return;
				SetAttributeValue("msdyn_isinternal", value);
			}
		}	
			
		/// <summary>
        /// msdyn_keywords
        /// </summary>
		[DisplayName("Keywords")]
		[AttributeLogicalName("msdyn_keywords")]
		public string Keywords
		{	
			get { return GetAttributeValue<string>("msdyn_keywords"); }
			set
			{ 
				if(value == Keywords) return;
				SetAttributeValue("msdyn_keywords", value);
			}
		}	
			
		/// <summary>
        /// msdyn_knowledgearticletemplateid
        /// </summary>
		[DisplayName("Knowledge Article Template")]
		[AttributeLogicalName("msdyn_knowledgearticletemplateid")]
		public override Guid Id
		{
			get => base.Id;
			set { base.Id = value; SetAttributeValue("msdyn_knowledgearticletemplateid", value); }
		}

							/// <summary>
        /// msdyn_languagelocaleid
        /// </summary>
		[DisplayName("Article Template Language Id")]
		[AttributeLogicalName("msdyn_languagelocaleid")]
		public string ArticleTemplateLanguageId
		{	
			get { return GetAttributeValue<string>("msdyn_languagelocaleid"); }
			set
			{ 
				if(value == ArticleTemplateLanguageId) return;
				SetAttributeValue("msdyn_languagelocaleid", value);
			}
		}	
			
		/// <summary>
        /// msdyn_LanguageLocaleIdName
        /// </summary>
		[DisplayName("Article Language Name")]
		[AttributeLogicalName("msdyn_LanguageLocaleIdName")]
		public string ArticleLanguageName
		{	
			get { return GetAttributeValue<string>("msdyn_LanguageLocaleIdName"); }
			set
			{ 
				if(value == ArticleLanguageName) return;
				SetAttributeValue("msdyn_LanguageLocaleIdName", value);
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
        /// msdyn_subjectid
        /// </summary>
		[DisplayName("Subject")]
		[AttributeLogicalName("msdyn_subjectid")]
		public EntityReference Subject
		{	
			get { return GetAttributeValue<EntityReference>("msdyn_subjectid"); }
			set
			{ 
				if(value == Subject) return;
				SetAttributeValue("msdyn_subjectid", value);
			}
		}	
			
		/// <summary>
        /// msdyn_subjectidname
        /// </summary>
		[DisplayName("msdyn_subjectidname")]
		[AttributeLogicalName("msdyn_subjectidname")]
		public string MsdynSubjectidname
		{	
			get { return GetAttributeValue<string>("msdyn_subjectidname"); }
			set
			{ 
				if(value == MsdynSubjectidname) return;
				SetAttributeValue("msdyn_subjectidname", value);
			}
		}	
			
		/// <summary>
        /// msdyn_title
        /// </summary>
		[DisplayName("Title")]
		[AttributeLogicalName("msdyn_title")]
		public string Title
		{	
			get { return GetAttributeValue<string>("msdyn_title"); }
			set
			{ 
				if(value == Title) return;
				SetAttributeValue("msdyn_title", value);
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
        /// 1:N Get entities for 'msdyn_knowledgearticletemplate_AsyncOperations'
        /// </summary>
		[RelationshipSchemaName("msdyn_knowledgearticletemplate_AsyncOperations")]
		public IEnumerable<SystemJob> MsdynKnowledgearticletemplateAsyncOperations
		{
			get { return GetRelatedEntities<SystemJob>("msdyn_knowledgearticletemplate_AsyncOperations", null); }
			set { SetRelatedEntities("msdyn_knowledgearticletemplate_AsyncOperations", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'msdyn_knowledgearticletemplate_BulkDeleteFailures'
        /// </summary>
		[RelationshipSchemaName("msdyn_knowledgearticletemplate_BulkDeleteFailures")]
		public IEnumerable<BulkDeleteFailure> MsdynKnowledgearticletemplateBulkDeleteFailures
		{
			get { return GetRelatedEntities<BulkDeleteFailure>("msdyn_knowledgearticletemplate_BulkDeleteFailures", null); }
			set { SetRelatedEntities("msdyn_knowledgearticletemplate_BulkDeleteFailures", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'msdyn_knowledgearticletemplate_DuplicateBaseRecord'
        /// </summary>
		[RelationshipSchemaName("msdyn_knowledgearticletemplate_DuplicateBaseRecord")]
		public IEnumerable<DuplicateRecord> MsdynKnowledgearticletemplateDuplicateBaseRecord
		{
			get { return GetRelatedEntities<DuplicateRecord>("msdyn_knowledgearticletemplate_DuplicateBaseRecord", null); }
			set { SetRelatedEntities("msdyn_knowledgearticletemplate_DuplicateBaseRecord", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'msdyn_knowledgearticletemplate_DuplicateMatchingRecord'
        /// </summary>
		[RelationshipSchemaName("msdyn_knowledgearticletemplate_DuplicateMatchingRecord")]
		public IEnumerable<DuplicateRecord> MsdynKnowledgearticletemplateDuplicateMatchingRecord
		{
			get { return GetRelatedEntities<DuplicateRecord>("msdyn_knowledgearticletemplate_DuplicateMatchingRecord", null); }
			set { SetRelatedEntities("msdyn_knowledgearticletemplate_DuplicateMatchingRecord", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'msdyn_knowledgearticletemplate_MailboxTrackingFolders'
        /// </summary>
		[RelationshipSchemaName("msdyn_knowledgearticletemplate_MailboxTrackingFolders")]
		public IEnumerable<MailboxAutoTrackingFolder> MsdynKnowledgearticletemplateMailboxTrackingFolders
		{
			get { return GetRelatedEntities<MailboxAutoTrackingFolder>("msdyn_knowledgearticletemplate_MailboxTrackingFolders", null); }
			set { SetRelatedEntities("msdyn_knowledgearticletemplate_MailboxTrackingFolders", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'msdyn_knowledgearticletemplate_PrincipalObjectAttributeAccesses'
        /// </summary>
		[RelationshipSchemaName("msdyn_knowledgearticletemplate_PrincipalObjectAttributeAccesses")]
		public IEnumerable<FieldSharing> MsdynKnowledgearticletemplatePrincipalObjectAttributeAccesses
		{
			get { return GetRelatedEntities<FieldSharing>("msdyn_knowledgearticletemplate_PrincipalObjectAttributeAccesses", null); }
			set { SetRelatedEntities("msdyn_knowledgearticletemplate_PrincipalObjectAttributeAccesses", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'msdyn_knowledgearticletemplate_ProcessSession'
        /// </summary>
		[RelationshipSchemaName("msdyn_knowledgearticletemplate_ProcessSession")]
		public IEnumerable<ProcessSession> MsdynKnowledgearticletemplateProcessSession
		{
			get { return GetRelatedEntities<ProcessSession>("msdyn_knowledgearticletemplate_ProcessSession", null); }
			set { SetRelatedEntities("msdyn_knowledgearticletemplate_ProcessSession", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'msdyn_knowledgearticletemplate_QueueItems'
        /// </summary>
		[RelationshipSchemaName("msdyn_knowledgearticletemplate_QueueItems")]
		public IEnumerable<QueueItem> MsdynKnowledgearticletemplateQueueItems
		{
			get { return GetRelatedEntities<QueueItem>("msdyn_knowledgearticletemplate_QueueItems", null); }
			set { SetRelatedEntities("msdyn_knowledgearticletemplate_QueueItems", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'msdyn_knowledgearticletemplate_SharePointDocumentLocations'
        /// </summary>
		[RelationshipSchemaName("msdyn_knowledgearticletemplate_SharePointDocumentLocations")]
		public IEnumerable<DocumentLocation> MsdynKnowledgearticletemplateSharePointDocumentLocations
		{
			get { return GetRelatedEntities<DocumentLocation>("msdyn_knowledgearticletemplate_SharePointDocumentLocations", null); }
			set { SetRelatedEntities("msdyn_knowledgearticletemplate_SharePointDocumentLocations", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'msdyn_knowledgearticletemplate_SyncErrors'
        /// </summary>
		[RelationshipSchemaName("msdyn_knowledgearticletemplate_SyncErrors")]
		public IEnumerable<SyncError> MsdynKnowledgearticletemplateSyncErrors
		{
			get { return GetRelatedEntities<SyncError>("msdyn_knowledgearticletemplate_SyncErrors", null); }
			set { SetRelatedEntities("msdyn_knowledgearticletemplate_SyncErrors", null, value); }
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

			/// <summary>msdyn_content</summary>
			public const string Content = "msdyn_content";

			/// <summary>msdyn_description</summary>
			public const string Description = "msdyn_description";

			/// <summary>msdyn_isinternal</summary>
			public const string Internal = "msdyn_isinternal";

			/// <summary>msdyn_keywords</summary>
			public const string Keywords = "msdyn_keywords";

			/// <summary>msdyn_knowledgearticletemplateid</summary>
			public const string KnowledgeArticleTemplateId = "msdyn_knowledgearticletemplateid";

			/// <summary>msdyn_languagelocaleid</summary>
			public const string ArticleTemplateLanguageId = "msdyn_languagelocaleid";

			/// <summary>msdyn_LanguageLocaleIdName</summary>
			public const string ArticleLanguageName = "msdyn_LanguageLocaleIdName";

			/// <summary>msdyn_name</summary>
			public const string Name = "msdyn_name";

			/// <summary>msdyn_subjectid</summary>
			public const string Subject = "msdyn_subjectid";

			/// <summary>msdyn_subjectidname</summary>
			public const string MsdynSubjectidname = "msdyn_subjectidname";

			/// <summary>msdyn_title</summary>
			public const string Title = "msdyn_title";

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
			/// <summary>1:N msdyn_knowledgearticletemplate_AsyncOperations</summary>
			public const string MsdynKnowledgearticletemplateAsyncOperations = "msdyn_knowledgearticletemplate_AsyncOperations";

			/// <summary>1:N msdyn_knowledgearticletemplate_BulkDeleteFailures</summary>
			public const string MsdynKnowledgearticletemplateBulkDeleteFailures = "msdyn_knowledgearticletemplate_BulkDeleteFailures";

			/// <summary>1:N msdyn_knowledgearticletemplate_DuplicateBaseRecord</summary>
			public const string MsdynKnowledgearticletemplateDuplicateBaseRecord = "msdyn_knowledgearticletemplate_DuplicateBaseRecord";

			/// <summary>1:N msdyn_knowledgearticletemplate_DuplicateMatchingRecord</summary>
			public const string MsdynKnowledgearticletemplateDuplicateMatchingRecord = "msdyn_knowledgearticletemplate_DuplicateMatchingRecord";

			/// <summary>1:N msdyn_knowledgearticletemplate_MailboxTrackingFolders</summary>
			public const string MsdynKnowledgearticletemplateMailboxTrackingFolders = "msdyn_knowledgearticletemplate_MailboxTrackingFolders";

			/// <summary>1:N msdyn_knowledgearticletemplate_PrincipalObjectAttributeAccesses</summary>
			public const string MsdynKnowledgearticletemplatePrincipalObjectAttributeAccesses = "msdyn_knowledgearticletemplate_PrincipalObjectAttributeAccesses";

			/// <summary>1:N msdyn_knowledgearticletemplate_ProcessSession</summary>
			public const string MsdynKnowledgearticletemplateProcessSession = "msdyn_knowledgearticletemplate_ProcessSession";

			/// <summary>1:N msdyn_knowledgearticletemplate_QueueItems</summary>
			public const string MsdynKnowledgearticletemplateQueueItems = "msdyn_knowledgearticletemplate_QueueItems";

			/// <summary>1:N msdyn_knowledgearticletemplate_SharePointDocumentLocations</summary>
			public const string MsdynKnowledgearticletemplateSharePointDocumentLocations = "msdyn_knowledgearticletemplate_SharePointDocumentLocations";

			/// <summary>1:N msdyn_knowledgearticletemplate_SyncErrors</summary>
			public const string MsdynKnowledgearticletemplateSyncErrors = "msdyn_knowledgearticletemplate_SyncErrors";

		}
		#endregion
	}
}

