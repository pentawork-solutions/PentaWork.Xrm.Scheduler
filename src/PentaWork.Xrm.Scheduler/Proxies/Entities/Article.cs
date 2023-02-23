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
	[EntityLogicalName("kbarticle")]
	public sealed class Article : Entity
	{	
		public static readonly int? EntityTypeCode = 127;
		public new const string LogicalName = "kbarticle";
		public const string PrimaryIdAttribute = "kbarticleid";
		public const string PrimaryNameAttribute = "title";
	
		public Article() : base("kbarticle") { }

		#region Attributes
		/// <summary>
        /// articlexml
        /// </summary>
		[DisplayName("Article XML")]
		[AttributeLogicalName("articlexml")]
		public string ArticleXML
		{	
			get { return GetAttributeValue<string>("articlexml"); }
			set
			{ 
				if(value == ArticleXML) return;
				SetAttributeValue("articlexml", value);
			}
		}	
			
		/// <summary>
        /// comments
        /// </summary>
		[DisplayName("Comments")]
		[AttributeLogicalName("comments")]
		public string Comments
		{	
			get { return GetAttributeValue<string>("comments"); }
			set
			{ 
				if(value == Comments) return;
				SetAttributeValue("comments", value);
			}
		}	
			
		/// <summary>
        /// content
        /// </summary>
		[DisplayName("Content")]
		[AttributeLogicalName("content")]
		public string Content
		{	
			get { return GetAttributeValue<string>("content"); }
			set
			{ 
				if(value == Content) return;
				SetAttributeValue("content", value);
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
		[DisplayName("Entity Image Id")]
		[AttributeLogicalName("entityimageid")]
		public Guid EntityImageId
		{	
			get { return GetAttributeValue<Guid>("entityimageid"); }
			set
			{ 
				if(value == EntityImageId) return;
				SetAttributeValue("entityimageid", value);
			}
		}	
			
		/// <summary>
        /// exchangerate
		///
		/// Precision: 10
		/// MaxValue: 100000000000
		/// MinValue: 0.0000000001
        /// </summary>
		[DisplayName("Exchange Rate")]
		[AttributeLogicalName("exchangerate")]
		public decimal? ExchangeRate
		{	
			get { return GetAttributeValue<decimal?>("exchangerate"); }
			set 
			{
				decimal? decimalValue = null;
				if(value != null) decimalValue = Decimal.Round(value.Value, 10);
				if(decimalValue == ExchangeRate) return;
				SetAttributeValue("exchangerate", decimalValue);  
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
        /// kbarticleid
        /// </summary>
		[DisplayName("Article")]
		[AttributeLogicalName("kbarticleid")]
		public override Guid Id
		{
			get => base.Id;
			set { base.Id = value; SetAttributeValue("kbarticleid", value); }
		}

							/// <summary>
        /// kbarticletemplateid
        /// </summary>
		[DisplayName("Base Template")]
		[AttributeLogicalName("kbarticletemplateid")]
		public EntityReference BaseTemplate
		{	
			get { return GetAttributeValue<EntityReference>("kbarticletemplateid"); }
			set
			{ 
				if(value == BaseTemplate) return;
				SetAttributeValue("kbarticletemplateid", value);
			}
		}	
			
		/// <summary>
        /// kbarticletemplateidtitle
        /// </summary>
		[DisplayName("kbarticletemplateidtitle")]
		[AttributeLogicalName("kbarticletemplateidtitle")]
		public string Kbarticletemplateidtitle
		{	
			get { return GetAttributeValue<string>("kbarticletemplateidtitle"); }
			set
			{ 
				if(value == Kbarticletemplateidtitle) return;
				SetAttributeValue("kbarticletemplateidtitle", value);
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
        /// number
        /// </summary>
		[DisplayName("Number")]
		[AttributeLogicalName("number")]
		public string Number
		{	
			get { return GetAttributeValue<string>("number"); }
			set
			{ 
				if(value == Number) return;
				SetAttributeValue("number", value);
			}
		}	
			
		/// <summary>
        /// organizationid
        /// </summary>
		[DisplayName("Organization")]
		[AttributeLogicalName("organizationid")]
		public EntityReference Organization
		{	
			get { return GetAttributeValue<EntityReference>("organizationid"); }
			set
			{ 
				if(value == Organization) return;
				SetAttributeValue("organizationid", value);
			}
		}	
			
		/// <summary>
        /// organizationidname
        /// </summary>
		[DisplayName("organizationidname")]
		[AttributeLogicalName("organizationidname")]
		public string Organizationidname
		{	
			get { return GetAttributeValue<string>("organizationidname"); }
			set
			{ 
				if(value == Organizationidname) return;
				SetAttributeValue("organizationidname", value);
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
        /// subjectid
        /// </summary>
		[DisplayName("Subject")]
		[AttributeLogicalName("subjectid")]
		public EntityReference Subject
		{	
			get { return GetAttributeValue<EntityReference>("subjectid"); }
			set
			{ 
				if(value == Subject) return;
				SetAttributeValue("subjectid", value);
			}
		}	
			
		/// <summary>
        /// subjectidname
        /// </summary>
		[DisplayName("subjectidname")]
		[AttributeLogicalName("subjectidname")]
		public string Subjectidname
		{	
			get { return GetAttributeValue<string>("subjectidname"); }
			set
			{ 
				if(value == Subjectidname) return;
				SetAttributeValue("subjectidname", value);
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
        /// transactioncurrencyid
        /// </summary>
		[DisplayName("Currency")]
		[AttributeLogicalName("transactioncurrencyid")]
		public EntityReference Currency
		{	
			get { return GetAttributeValue<EntityReference>("transactioncurrencyid"); }
			set
			{ 
				if(value == Currency) return;
				SetAttributeValue("transactioncurrencyid", value);
			}
		}	
			
		/// <summary>
        /// transactioncurrencyidname
        /// </summary>
		[DisplayName("transactioncurrencyidname")]
		[AttributeLogicalName("transactioncurrencyidname")]
		public string Transactioncurrencyidname
		{	
			get { return GetAttributeValue<string>("transactioncurrencyidname"); }
			set
			{ 
				if(value == Transactioncurrencyidname) return;
				SetAttributeValue("transactioncurrencyidname", value);
			}
		}	
			
		/// <summary>
        /// versionnumber
        /// </summary>
		[DisplayName("Title")]
		[AttributeLogicalName("versionnumber")]
		public int? Title2
		{	
			get { return GetAttributeValue<int?>("versionnumber"); }
			set
			{ 
				if(value == Title2) return;
				SetAttributeValue("versionnumber", value);
			}
		}	
			
		#endregion	

		#region Relations
			/// <summary>
        /// 1:N Get entities for 'KbArticle_Annotation'
        /// </summary>
		[RelationshipSchemaName("KbArticle_Annotation")]
		public IEnumerable<Note> KbArticleAnnotation
		{
			get { return GetRelatedEntities<Note>("KbArticle_Annotation", null); }
			set { SetRelatedEntities("KbArticle_Annotation", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'KbArticle_AsyncOperations'
        /// </summary>
		[RelationshipSchemaName("KbArticle_AsyncOperations")]
		public IEnumerable<SystemJob> KbArticleAsyncOperations
		{
			get { return GetRelatedEntities<SystemJob>("KbArticle_AsyncOperations", null); }
			set { SetRelatedEntities("KbArticle_AsyncOperations", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'KbArticle_BulkDeleteFailures'
        /// </summary>
		[RelationshipSchemaName("KbArticle_BulkDeleteFailures")]
		public IEnumerable<BulkDeleteFailure> KbArticleBulkDeleteFailures
		{
			get { return GetRelatedEntities<BulkDeleteFailure>("KbArticle_BulkDeleteFailures", null); }
			set { SetRelatedEntities("KbArticle_BulkDeleteFailures", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'kbarticle_comments'
        /// </summary>
		[RelationshipSchemaName("kbarticle_comments")]
		public IEnumerable<ArticleComment> KbarticleComments
		{
			get { return GetRelatedEntities<ArticleComment>("kbarticle_comments", null); }
			set { SetRelatedEntities("kbarticle_comments", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'KbArticle_DuplicateBaseRecord'
        /// </summary>
		[RelationshipSchemaName("KbArticle_DuplicateBaseRecord")]
		public IEnumerable<DuplicateRecord> KbArticleDuplicateBaseRecord
		{
			get { return GetRelatedEntities<DuplicateRecord>("KbArticle_DuplicateBaseRecord", null); }
			set { SetRelatedEntities("KbArticle_DuplicateBaseRecord", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'KbArticle_DuplicateMatchingRecord'
        /// </summary>
		[RelationshipSchemaName("KbArticle_DuplicateMatchingRecord")]
		public IEnumerable<DuplicateRecord> KbArticleDuplicateMatchingRecord
		{
			get { return GetRelatedEntities<DuplicateRecord>("KbArticle_DuplicateMatchingRecord", null); }
			set { SetRelatedEntities("KbArticle_DuplicateMatchingRecord", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'kbarticle_incidents'
        /// </summary>
		[RelationshipSchemaName("kbarticle_incidents")]
		public IEnumerable<Case> KbarticleIncidents
		{
			get { return GetRelatedEntities<Case>("kbarticle_incidents", null); }
			set { SetRelatedEntities("kbarticle_incidents", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'kbarticle_principalobjectattributeaccess'
        /// </summary>
		[RelationshipSchemaName("kbarticle_principalobjectattributeaccess")]
		public IEnumerable<FieldSharing> KbarticlePrincipalobjectattributeaccess
		{
			get { return GetRelatedEntities<FieldSharing>("kbarticle_principalobjectattributeaccess", null); }
			set { SetRelatedEntities("kbarticle_principalobjectattributeaccess", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'KbArticle_ProcessSessions'
        /// </summary>
		[RelationshipSchemaName("KbArticle_ProcessSessions")]
		public IEnumerable<ProcessSession> KbArticleProcessSessions
		{
			get { return GetRelatedEntities<ProcessSession>("KbArticle_ProcessSessions", null); }
			set { SetRelatedEntities("KbArticle_ProcessSessions", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'KbArticle_SharepointDocumentLocation'
        /// </summary>
		[RelationshipSchemaName("KbArticle_SharepointDocumentLocation")]
		public IEnumerable<DocumentLocation> KbArticleSharepointDocumentLocation
		{
			get { return GetRelatedEntities<DocumentLocation>("KbArticle_SharepointDocumentLocation", null); }
			set { SetRelatedEntities("KbArticle_SharepointDocumentLocation", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'KbArticle_SyncErrors'
        /// </summary>
		[RelationshipSchemaName("KbArticle_SyncErrors")]
		public IEnumerable<SyncError> KbArticleSyncErrors
		{
			get { return GetRelatedEntities<SyncError>("KbArticle_SyncErrors", null); }
			set { SetRelatedEntities("KbArticle_SyncErrors", null, value); }
		}
		#endregion

		#region Actions
		#endregion

		#region OptionSetEnums
		public enum eStatus
		{	
		
			[Label("Draft")]
			[Description(@"")]
			Draft = 1, 
		
			[Label("Unapproved")]
			[Description(@"")]
			Unapproved = 2, 
		
			[Label("Published")]
			[Description(@"")]
			Published = 3, 
		}
		
		public enum eStatusReason
		{	
		
			[Label("Draft")]
			[Description(@"")]
			Draft_Inactive = 1, 
		
			[Label("Unapproved")]
			[Description(@"")]
			Unapproved = 2, 
		
			[Label("Published")]
			[Description(@"")]
			Published = 3, 
		}
		
		#endregion	

		#region Properties
		public static class Properties 
		{
			/// <summary>articlexml</summary>
			public const string ArticleXML = "articlexml";

			/// <summary>comments</summary>
			public const string Comments = "comments";

			/// <summary>content</summary>
			public const string Content = "content";

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
			public const string EntityImageId = "entityimageid";

			/// <summary>exchangerate</summary>
			public const string ExchangeRate = "exchangerate";

			/// <summary>importsequencenumber</summary>
			public const string ImportSequenceNumber = "importsequencenumber";

			/// <summary>kbarticleid</summary>
			public const string ArticleId = "kbarticleid";

			/// <summary>kbarticletemplateid</summary>
			public const string BaseTemplate = "kbarticletemplateid";

			/// <summary>kbarticletemplateidtitle</summary>
			public const string Kbarticletemplateidtitle = "kbarticletemplateidtitle";

			/// <summary>keywords</summary>
			public const string KeyWords = "keywords";

			/// <summary>languagecode</summary>
			public const string Language = "languagecode";

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

			/// <summary>number</summary>
			public const string Number = "number";

			/// <summary>organizationid</summary>
			public const string Organization = "organizationid";

			/// <summary>organizationidname</summary>
			public const string Organizationidname = "organizationidname";

			/// <summary>overriddencreatedon</summary>
			public const string RecordCreatedOn = "overriddencreatedon";

			/// <summary>statecode</summary>
			public const string Status = "statecode";

			/// <summary>statuscode</summary>
			public const string StatusReason = "statuscode";

			/// <summary>subjectid</summary>
			public const string Subject = "subjectid";

			/// <summary>subjectidname</summary>
			public const string Subjectidname = "subjectidname";

			/// <summary>title</summary>
			public const string Title = "title";

			/// <summary>transactioncurrencyid</summary>
			public const string Currency = "transactioncurrencyid";

			/// <summary>transactioncurrencyidname</summary>
			public const string Transactioncurrencyidname = "transactioncurrencyidname";

			/// <summary>versionnumber</summary>
			public const string Title2 = "versionnumber";

		}
		#endregion

		#region Schemas
		public static class Schemas 
		{
			/// <summary>1:N KbArticle_Annotation</summary>
			public const string KbArticleAnnotation = "KbArticle_Annotation";

			/// <summary>1:N KbArticle_AsyncOperations</summary>
			public const string KbArticleAsyncOperations = "KbArticle_AsyncOperations";

			/// <summary>1:N KbArticle_BulkDeleteFailures</summary>
			public const string KbArticleBulkDeleteFailures = "KbArticle_BulkDeleteFailures";

			/// <summary>1:N kbarticle_comments</summary>
			public const string KbarticleComments = "kbarticle_comments";

			/// <summary>1:N KbArticle_DuplicateBaseRecord</summary>
			public const string KbArticleDuplicateBaseRecord = "KbArticle_DuplicateBaseRecord";

			/// <summary>1:N KbArticle_DuplicateMatchingRecord</summary>
			public const string KbArticleDuplicateMatchingRecord = "KbArticle_DuplicateMatchingRecord";

			/// <summary>1:N kbarticle_incidents</summary>
			public const string KbarticleIncidents = "kbarticle_incidents";

			/// <summary>1:N kbarticle_principalobjectattributeaccess</summary>
			public const string KbarticlePrincipalobjectattributeaccess = "kbarticle_principalobjectattributeaccess";

			/// <summary>1:N KbArticle_ProcessSessions</summary>
			public const string KbArticleProcessSessions = "KbArticle_ProcessSessions";

			/// <summary>1:N KbArticle_SharepointDocumentLocation</summary>
			public const string KbArticleSharepointDocumentLocation = "KbArticle_SharepointDocumentLocation";

			/// <summary>1:N KbArticle_SyncErrors</summary>
			public const string KbArticleSyncErrors = "KbArticle_SyncErrors";

		}
		#endregion
	}
}

