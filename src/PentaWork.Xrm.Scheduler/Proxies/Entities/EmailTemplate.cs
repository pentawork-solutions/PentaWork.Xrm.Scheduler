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
	[EntityLogicalName("template")]
	public sealed class EmailTemplate : Entity
	{	
		public static readonly int? EntityTypeCode = 2010;
		public new const string LogicalName = "template";
		public const string PrimaryIdAttribute = "templateid";
		public const string PrimaryNameAttribute = "title";
	
		public EmailTemplate() : base("template") { }

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
        /// description
        /// </summary>
		[DisplayName("Description")]
		[AttributeLogicalName("description")]
		public string Description
		{	
			get { return GetAttributeValue<string>("description"); }
			set
			{ 
				if(value == Description) return;
				SetAttributeValue("description", value);
			}
		}	
			
		/// <summary>
        /// entityimage_timestamp
        /// </summary>
		[DisplayName("entityimage_timestamp")]
		[AttributeLogicalName("entityimage_timestamp")]
		public int? EntityimageTimestamp
		{	
			get { return GetAttributeValue<int?>("entityimage_timestamp"); }
			set
			{ 
				if(value == EntityimageTimestamp) return;
				SetAttributeValue("entityimage_timestamp", value);
			}
		}	
			
		/// <summary>
        /// entityimage_url
        /// </summary>
		[DisplayName("entityimage_url")]
		[AttributeLogicalName("entityimage_url")]
		public string EntityimageUrl
		{	
			get { return GetAttributeValue<string>("entityimage_url"); }
			set
			{ 
				if(value == EntityimageUrl) return;
				SetAttributeValue("entityimage_url", value);
			}
		}	
			
		/// <summary>
        /// entityimageid
        /// </summary>
		[DisplayName("entityimageid")]
		[AttributeLogicalName("entityimageid")]
		public Guid EntityimageId
		{	
			get { return GetAttributeValue<Guid>("entityimageid"); }
			set
			{ 
				if(value == EntityimageId) return;
				SetAttributeValue("entityimageid", value);
			}
		}	
			
		/// <summary>
        /// generationtypecode
        /// </summary>
		[DisplayName("Generation Type Code")]
		[AttributeLogicalName("generationtypecode")]
		public int? GenerationTypeCode
		{	
			get { return GetAttributeValue<int?>("generationtypecode"); }
			set
			{ 
				if(value == GenerationTypeCode) return;
				SetAttributeValue("generationtypecode", value);
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
        /// introducedversion
        /// </summary>
		[DisplayName("Introduced Version")]
		[AttributeLogicalName("introducedversion")]
		public string IntroducedVersion
		{	
			get { return GetAttributeValue<string>("introducedversion"); }
			set
			{ 
				if(value == IntroducedVersion) return;
				SetAttributeValue("introducedversion", value);
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
        /// ispersonal
        /// </summary>
		[DisplayName("Viewable By")]
		[AttributeLogicalName("ispersonal")]
		public bool? ViewableBy
		{	
			get { return GetAttributeValue<bool?>("ispersonal"); }
			set
			{ 
				if(value == ViewableBy) return;
				SetAttributeValue("ispersonal", value);
			}
		}	
			
		/// <summary>
        /// isrecommended
        /// </summary>
		[DisplayName("Recommended")]
		[AttributeLogicalName("isrecommended")]
		public bool? Recommended
		{	
			get { return GetAttributeValue<bool?>("isrecommended"); }
			set
			{ 
				if(value == Recommended) return;
				SetAttributeValue("isrecommended", value);
			}
		}	
			
		/// <summary>
        /// languagecode
        /// </summary>
		[DisplayName("Language")]
		[AttributeLogicalName("languagecode")]
		public int? Language
		{	
			get { return GetAttributeValue<int?>("languagecode"); }
			set
			{ 
				if(value == Language) return;
				SetAttributeValue("languagecode", value);
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
        /// opencount
        /// </summary>
		[DisplayName("Open Count")]
		[AttributeLogicalName("opencount")]
		public int? OpenCount
		{	
			get { return GetAttributeValue<int?>("opencount"); }
			set
			{ 
				if(value == OpenCount) return;
				SetAttributeValue("opencount", value);
			}
		}	
			
		/// <summary>
        /// openrate
        /// </summary>
		[DisplayName("Open Rate")]
		[AttributeLogicalName("openrate")]
		public int? OpenRate
		{	
			get { return GetAttributeValue<int?>("openrate"); }
			set
			{ 
				if(value == OpenRate) return;
				SetAttributeValue("openrate", value);
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
        /// presentationxml
        /// </summary>
		[DisplayName("Presentation XML")]
		[AttributeLogicalName("presentationxml")]
		public string PresentationXML
		{	
			get { return GetAttributeValue<string>("presentationxml"); }
			set
			{ 
				if(value == PresentationXML) return;
				SetAttributeValue("presentationxml", value);
			}
		}	
			
		/// <summary>
        /// replycount
        /// </summary>
		[DisplayName("Reply Count")]
		[AttributeLogicalName("replycount")]
		public int? ReplyCount
		{	
			get { return GetAttributeValue<int?>("replycount"); }
			set
			{ 
				if(value == ReplyCount) return;
				SetAttributeValue("replycount", value);
			}
		}	
			
		/// <summary>
        /// replyrate
        /// </summary>
		[DisplayName("Reply Rate")]
		[AttributeLogicalName("replyrate")]
		public int? ReplyRate
		{	
			get { return GetAttributeValue<int?>("replyrate"); }
			set
			{ 
				if(value == ReplyRate) return;
				SetAttributeValue("replyrate", value);
			}
		}	
			
		/// <summary>
        /// safehtml
        /// </summary>
		[DisplayName("Safe HTML of email template")]
		[AttributeLogicalName("safehtml")]
		public string SafeHTMLOfEmailTemplate
		{	
			get { return GetAttributeValue<string>("safehtml"); }
			set
			{ 
				if(value == SafeHTMLOfEmailTemplate) return;
				SetAttributeValue("safehtml", value);
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
        /// subjectpresentationxml
        /// </summary>
		[DisplayName("Subject XML")]
		[AttributeLogicalName("subjectpresentationxml")]
		public string SubjectXML
		{	
			get { return GetAttributeValue<string>("subjectpresentationxml"); }
			set
			{ 
				if(value == SubjectXML) return;
				SetAttributeValue("subjectpresentationxml", value);
			}
		}	
			
		/// <summary>
        /// subjectsafehtml
        /// </summary>
		[DisplayName("Safe HTML of email template subject")]
		[AttributeLogicalName("subjectsafehtml")]
		public string SafeHTMLOfEmailTemplateSubject
		{	
			get { return GetAttributeValue<string>("subjectsafehtml"); }
			set
			{ 
				if(value == SafeHTMLOfEmailTemplateSubject) return;
				SetAttributeValue("subjectsafehtml", value);
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
        /// templateid
        /// </summary>
		[DisplayName("Email Template")]
		[AttributeLogicalName("templateid")]
		public override Guid Id
		{
			get => base.Id;
			set { base.Id = value; SetAttributeValue("templateid", value); }
		}

							/// <summary>
        /// templateidunique
        /// </summary>
		[DisplayName("templateidunique")]
		[AttributeLogicalName("templateidunique")]
		public Guid TemplateiduniqueId
		{	
			get { return GetAttributeValue<Guid>("templateidunique"); }
			set
			{ 
				if(value == TemplateiduniqueId) return;
				SetAttributeValue("templateidunique", value);
			}
		}	
			
		/// <summary>
        /// templatetypecode
        /// </summary>
		[DisplayName("Template Type")]
		[AttributeLogicalName("templatetypecode")]
		public string TemplateType
		{	
			get { return GetAttributeValue<string>("templatetypecode"); }
			set
			{ 
				if(value == TemplateType) return;
				SetAttributeValue("templatetypecode", value);
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
        /// usedcount
        /// </summary>
		[DisplayName("Sent email count")]
		[AttributeLogicalName("usedcount")]
		public int? SentEmailCount
		{	
			get { return GetAttributeValue<int?>("usedcount"); }
			set
			{ 
				if(value == SentEmailCount) return;
				SetAttributeValue("usedcount", value);
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
        /// 1:N Get entities for 'Email_EmailTemplate'
        /// </summary>
		[RelationshipSchemaName("Email_EmailTemplate")]
		public IEnumerable<Email> EmailEmailTemplate
		{
			get { return GetRelatedEntities<Email>("Email_EmailTemplate", null); }
			set { SetRelatedEntities("Email_EmailTemplate", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'template_activity_mime_attachments'
        /// </summary>
		[RelationshipSchemaName("template_activity_mime_attachments")]
		public IEnumerable<Attachment> TemplateActivityMimeAttachments
		{
			get { return GetRelatedEntities<Attachment>("template_activity_mime_attachments", null); }
			set { SetRelatedEntities("template_activity_mime_attachments", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'Template_AsyncOperations'
        /// </summary>
		[RelationshipSchemaName("Template_AsyncOperations")]
		public IEnumerable<SystemJob> TemplateAsyncOperations
		{
			get { return GetRelatedEntities<SystemJob>("Template_AsyncOperations", null); }
			set { SetRelatedEntities("Template_AsyncOperations", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'Template_BulkDeleteFailures'
        /// </summary>
		[RelationshipSchemaName("Template_BulkDeleteFailures")]
		public IEnumerable<BulkDeleteFailure> TemplateBulkDeleteFailures
		{
			get { return GetRelatedEntities<BulkDeleteFailure>("Template_BulkDeleteFailures", null); }
			set { SetRelatedEntities("Template_BulkDeleteFailures", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'Template_Organization'
        /// </summary>
		[RelationshipSchemaName("Template_Organization")]
		public IEnumerable<Organization> TemplateOrganization
		{
			get { return GetRelatedEntities<Organization>("Template_Organization", null); }
			set { SetRelatedEntities("Template_Organization", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'Template_ProcessSessions'
        /// </summary>
		[RelationshipSchemaName("Template_ProcessSessions")]
		public IEnumerable<ProcessSession> TemplateProcessSessions
		{
			get { return GetRelatedEntities<ProcessSession>("Template_ProcessSessions", null); }
			set { SetRelatedEntities("Template_ProcessSessions", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'Template_SyncErrors'
        /// </summary>
		[RelationshipSchemaName("Template_SyncErrors")]
		public IEnumerable<SyncError> TemplateSyncErrors
		{
			get { return GetRelatedEntities<SyncError>("Template_SyncErrors", null); }
			set { SetRelatedEntities("Template_SyncErrors", null, value); }
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
			/// <summary>body</summary>
			public const string Body = "body";

			/// <summary>componentstate</summary>
			public const string ComponentState = "componentstate";

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

			/// <summary>description</summary>
			public const string Description = "description";

			/// <summary>entityimage_timestamp</summary>
			public const string EntityimageTimestamp = "entityimage_timestamp";

			/// <summary>entityimage_url</summary>
			public const string EntityimageUrl = "entityimage_url";

			/// <summary>entityimageid</summary>
			public const string EntityimageId = "entityimageid";

			/// <summary>generationtypecode</summary>
			public const string GenerationTypeCode = "generationtypecode";

			/// <summary>importsequencenumber</summary>
			public const string ImportSequenceNumber = "importsequencenumber";

			/// <summary>introducedversion</summary>
			public const string IntroducedVersion = "introducedversion";

			/// <summary>ismanaged</summary>
			public const string IsManaged = "ismanaged";

			/// <summary>ispersonal</summary>
			public const string ViewableBy = "ispersonal";

			/// <summary>isrecommended</summary>
			public const string Recommended = "isrecommended";

			/// <summary>languagecode</summary>
			public const string Language = "languagecode";

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

			/// <summary>opencount</summary>
			public const string OpenCount = "opencount";

			/// <summary>openrate</summary>
			public const string OpenRate = "openrate";

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

			/// <summary>owningbusinessunit</summary>
			public const string OwningBusinessUnit = "owningbusinessunit";

			/// <summary>owningteam</summary>
			public const string OwningTeam = "owningteam";

			/// <summary>owninguser</summary>
			public const string OwningUser = "owninguser";

			/// <summary>presentationxml</summary>
			public const string PresentationXML = "presentationxml";

			/// <summary>replycount</summary>
			public const string ReplyCount = "replycount";

			/// <summary>replyrate</summary>
			public const string ReplyRate = "replyrate";

			/// <summary>safehtml</summary>
			public const string SafeHTMLOfEmailTemplate = "safehtml";

			/// <summary>solutionid</summary>
			public const string SolutionId = "solutionid";

			/// <summary>subject</summary>
			public const string Subject = "subject";

			/// <summary>subjectpresentationxml</summary>
			public const string SubjectXML = "subjectpresentationxml";

			/// <summary>subjectsafehtml</summary>
			public const string SafeHTMLOfEmailTemplateSubject = "subjectsafehtml";

			/// <summary>supportingsolutionid</summary>
			public const string SolutionId2 = "supportingsolutionid";

			/// <summary>templateid</summary>
			public const string EmailTemplateId = "templateid";

			/// <summary>templateidunique</summary>
			public const string TemplateiduniqueId = "templateidunique";

			/// <summary>templatetypecode</summary>
			public const string TemplateType = "templatetypecode";

			/// <summary>title</summary>
			public const string Title = "title";

			/// <summary>usedcount</summary>
			public const string SentEmailCount = "usedcount";

			/// <summary>versionnumber</summary>
			public const string VersionNumber = "versionnumber";

		}
		#endregion

		#region Schemas
		public static class Schemas 
		{
			/// <summary>1:N Email_EmailTemplate</summary>
			public const string EmailEmailTemplate = "Email_EmailTemplate";

			/// <summary>1:N template_activity_mime_attachments</summary>
			public const string TemplateActivityMimeAttachments = "template_activity_mime_attachments";

			/// <summary>1:N Template_AsyncOperations</summary>
			public const string TemplateAsyncOperations = "Template_AsyncOperations";

			/// <summary>1:N Template_BulkDeleteFailures</summary>
			public const string TemplateBulkDeleteFailures = "Template_BulkDeleteFailures";

			/// <summary>1:N Template_Organization</summary>
			public const string TemplateOrganization = "Template_Organization";

			/// <summary>1:N Template_ProcessSessions</summary>
			public const string TemplateProcessSessions = "Template_ProcessSessions";

			/// <summary>1:N Template_SyncErrors</summary>
			public const string TemplateSyncErrors = "Template_SyncErrors";

		}
		#endregion
	}
}

