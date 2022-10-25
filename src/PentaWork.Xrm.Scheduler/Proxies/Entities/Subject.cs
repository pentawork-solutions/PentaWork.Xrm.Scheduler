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
	[EntityLogicalName("subject")]
	public sealed class Subject : Entity
	{	
		public static readonly int? EntityTypeCode = 129;
		public new const string LogicalName = "subject";
		public const string PrimaryIdAttribute = "subjectid";
		public const string PrimaryNameAttribute = "title";
	
		public Subject() : base("subject") { }

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
        /// createdbyexternalparty
        /// </summary>
		[DisplayName("Created By (External Party)")]
		[AttributeLogicalName("createdbyexternalparty")]
		public EntityReference CreatedByExternalParty
		{	
			get { return GetAttributeValue<EntityReference>("createdbyexternalparty"); }
			set
			{ 
				if(value == CreatedByExternalParty) return;
				SetAttributeValue("createdbyexternalparty", value);
			}
		}	
			
		/// <summary>
        /// createdbyexternalpartyname
        /// </summary>
		[DisplayName("createdbyexternalpartyname")]
		[AttributeLogicalName("createdbyexternalpartyname")]
		public string Createdbyexternalpartyname
		{	
			get { return GetAttributeValue<string>("createdbyexternalpartyname"); }
			set
			{ 
				if(value == Createdbyexternalpartyname) return;
				SetAttributeValue("createdbyexternalpartyname", value);
			}
		}	
			
		/// <summary>
        /// createdbyexternalpartyyominame
        /// </summary>
		[DisplayName("createdbyexternalpartyyominame")]
		[AttributeLogicalName("createdbyexternalpartyyominame")]
		public string Createdbyexternalpartyyominame
		{	
			get { return GetAttributeValue<string>("createdbyexternalpartyyominame"); }
			set
			{ 
				if(value == Createdbyexternalpartyyominame) return;
				SetAttributeValue("createdbyexternalpartyyominame", value);
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
        /// featuremask
        /// </summary>
		[DisplayName("Feature Mask")]
		[AttributeLogicalName("featuremask")]
		public int? FeatureMask
		{	
			get { return GetAttributeValue<int?>("featuremask"); }
			set
			{ 
				if(value == FeatureMask) return;
				SetAttributeValue("featuremask", value);
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
        /// modifiedbyexternalparty
        /// </summary>
		[DisplayName("Modified By (External Party)")]
		[AttributeLogicalName("modifiedbyexternalparty")]
		public EntityReference ModifiedByExternalParty
		{	
			get { return GetAttributeValue<EntityReference>("modifiedbyexternalparty"); }
			set
			{ 
				if(value == ModifiedByExternalParty) return;
				SetAttributeValue("modifiedbyexternalparty", value);
			}
		}	
			
		/// <summary>
        /// modifiedbyexternalpartyname
        /// </summary>
		[DisplayName("modifiedbyexternalpartyname")]
		[AttributeLogicalName("modifiedbyexternalpartyname")]
		public string Modifiedbyexternalpartyname
		{	
			get { return GetAttributeValue<string>("modifiedbyexternalpartyname"); }
			set
			{ 
				if(value == Modifiedbyexternalpartyname) return;
				SetAttributeValue("modifiedbyexternalpartyname", value);
			}
		}	
			
		/// <summary>
        /// modifiedbyexternalpartyyominame
        /// </summary>
		[DisplayName("modifiedbyexternalpartyyominame")]
		[AttributeLogicalName("modifiedbyexternalpartyyominame")]
		public string Modifiedbyexternalpartyyominame
		{	
			get { return GetAttributeValue<string>("modifiedbyexternalpartyyominame"); }
			set
			{ 
				if(value == Modifiedbyexternalpartyyominame) return;
				SetAttributeValue("modifiedbyexternalpartyyominame", value);
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
        /// parentsubject
        /// </summary>
		[DisplayName("Parent Subject")]
		[AttributeLogicalName("parentsubject")]
		public EntityReference ParentSubject
		{	
			get { return GetAttributeValue<EntityReference>("parentsubject"); }
			set
			{ 
				if(value == ParentSubject) return;
				SetAttributeValue("parentsubject", value);
			}
		}	
			
		/// <summary>
        /// parentsubjectname
        /// </summary>
		[DisplayName("parentsubjectname")]
		[AttributeLogicalName("parentsubjectname")]
		public string Parentsubjectname
		{	
			get { return GetAttributeValue<string>("parentsubjectname"); }
			set
			{ 
				if(value == Parentsubjectname) return;
				SetAttributeValue("parentsubjectname", value);
			}
		}	
			
		/// <summary>
        /// subjectid
        /// </summary>
		[DisplayName("Subject")]
		[AttributeLogicalName("subjectid")]
		public override Guid Id
		{
			get => base.Id;
			set { base.Id = value; SetAttributeValue("subjectid", value); }
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
        /// 1:N Get entities for 'msdyn_subject_knowledgearticletemplate_subjectid'
        /// </summary>
		[RelationshipSchemaName("msdyn_subject_knowledgearticletemplate_subjectid")]
		public IEnumerable<KnowledgeArticleTemplate> MsdynSubjectKnowledgearticletemplateSubjectid
		{
			get { return GetRelatedEntities<KnowledgeArticleTemplate>("msdyn_subject_knowledgearticletemplate_subjectid", null); }
			set { SetRelatedEntities("msdyn_subject_knowledgearticletemplate_subjectid", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'Subject_AsyncOperations'
        /// </summary>
		[RelationshipSchemaName("Subject_AsyncOperations")]
		public IEnumerable<SystemJob> SubjectAsyncOperations
		{
			get { return GetRelatedEntities<SystemJob>("Subject_AsyncOperations", null); }
			set { SetRelatedEntities("Subject_AsyncOperations", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'Subject_BulkDeleteFailures'
        /// </summary>
		[RelationshipSchemaName("Subject_BulkDeleteFailures")]
		public IEnumerable<BulkDeleteFailure> SubjectBulkDeleteFailures
		{
			get { return GetRelatedEntities<BulkDeleteFailure>("Subject_BulkDeleteFailures", null); }
			set { SetRelatedEntities("Subject_BulkDeleteFailures", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'subject_incidents'
        /// </summary>
		[RelationshipSchemaName("subject_incidents")]
		public IEnumerable<Case> SubjectIncidents
		{
			get { return GetRelatedEntities<Case>("subject_incidents", null); }
			set { SetRelatedEntities("subject_incidents", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'subject_kb_articles'
        /// </summary>
		[RelationshipSchemaName("subject_kb_articles")]
		public IEnumerable<Article> SubjectKbArticles
		{
			get { return GetRelatedEntities<Article>("subject_kb_articles", null); }
			set { SetRelatedEntities("subject_kb_articles", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'subject_knowledgearticles'
        /// </summary>
		[RelationshipSchemaName("subject_knowledgearticles")]
		public IEnumerable<KnowledgeArticle> SubjectKnowledgearticles
		{
			get { return GetRelatedEntities<KnowledgeArticle>("subject_knowledgearticles", null); }
			set { SetRelatedEntities("subject_knowledgearticles", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'subject_parent_subject'
        /// </summary>
		[RelationshipSchemaName("subject_parent_subject")]
		public IEnumerable<Subject> SubjectParentSubject
		{
			get { return GetRelatedEntities<Subject>("subject_parent_subject", null); }
			set { SetRelatedEntities("subject_parent_subject", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'Subject_ProcessSessions'
        /// </summary>
		[RelationshipSchemaName("Subject_ProcessSessions")]
		public IEnumerable<ProcessSession> SubjectProcessSessions
		{
			get { return GetRelatedEntities<ProcessSession>("Subject_ProcessSessions", null); }
			set { SetRelatedEntities("Subject_ProcessSessions", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'subject_products'
        /// </summary>
		[RelationshipSchemaName("subject_products")]
		public IEnumerable<Product> SubjectProducts
		{
			get { return GetRelatedEntities<Product>("subject_products", null); }
			set { SetRelatedEntities("subject_products", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'subject_sales_literature'
        /// </summary>
		[RelationshipSchemaName("subject_sales_literature")]
		public IEnumerable<SalesLiterature> SubjectSalesLiterature
		{
			get { return GetRelatedEntities<SalesLiterature>("subject_sales_literature", null); }
			set { SetRelatedEntities("subject_sales_literature", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'Subject_SyncErrors'
        /// </summary>
		[RelationshipSchemaName("Subject_SyncErrors")]
		public IEnumerable<SyncError> SubjectSyncErrors
		{
			get { return GetRelatedEntities<SyncError>("Subject_SyncErrors", null); }
			set { SetRelatedEntities("Subject_SyncErrors", null, value); }
		}
		#endregion

		#region Actions
		#endregion

		#region OptionSetEnums
		#endregion	

		#region Properties
		public static class Properties 
		{
			/// <summary>createdby</summary>
			public const string CreatedBy = "createdby";

			/// <summary>createdbyexternalparty</summary>
			public const string CreatedByExternalParty = "createdbyexternalparty";

			/// <summary>createdbyexternalpartyname</summary>
			public const string Createdbyexternalpartyname = "createdbyexternalpartyname";

			/// <summary>createdbyexternalpartyyominame</summary>
			public const string Createdbyexternalpartyyominame = "createdbyexternalpartyyominame";

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

			/// <summary>featuremask</summary>
			public const string FeatureMask = "featuremask";

			/// <summary>importsequencenumber</summary>
			public const string ImportSequenceNumber = "importsequencenumber";

			/// <summary>modifiedby</summary>
			public const string ModifiedBy = "modifiedby";

			/// <summary>modifiedbyexternalparty</summary>
			public const string ModifiedByExternalParty = "modifiedbyexternalparty";

			/// <summary>modifiedbyexternalpartyname</summary>
			public const string Modifiedbyexternalpartyname = "modifiedbyexternalpartyname";

			/// <summary>modifiedbyexternalpartyyominame</summary>
			public const string Modifiedbyexternalpartyyominame = "modifiedbyexternalpartyyominame";

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
			public const string Organization = "organizationid";

			/// <summary>organizationidname</summary>
			public const string Organizationidname = "organizationidname";

			/// <summary>overriddencreatedon</summary>
			public const string RecordCreatedOn = "overriddencreatedon";

			/// <summary>parentsubject</summary>
			public const string ParentSubject = "parentsubject";

			/// <summary>parentsubjectname</summary>
			public const string Parentsubjectname = "parentsubjectname";

			/// <summary>subjectid</summary>
			public const string SubjectId = "subjectid";

			/// <summary>title</summary>
			public const string Title = "title";

			/// <summary>versionnumber</summary>
			public const string VersionNumber = "versionnumber";

		}
		#endregion

		#region Schemas
		public static class Schemas 
		{
			/// <summary>1:N msdyn_subject_knowledgearticletemplate_subjectid</summary>
			public const string MsdynSubjectKnowledgearticletemplateSubjectid = "msdyn_subject_knowledgearticletemplate_subjectid";

			/// <summary>1:N Subject_AsyncOperations</summary>
			public const string SubjectAsyncOperations = "Subject_AsyncOperations";

			/// <summary>1:N Subject_BulkDeleteFailures</summary>
			public const string SubjectBulkDeleteFailures = "Subject_BulkDeleteFailures";

			/// <summary>1:N subject_incidents</summary>
			public const string SubjectIncidents = "subject_incidents";

			/// <summary>1:N subject_kb_articles</summary>
			public const string SubjectKbArticles = "subject_kb_articles";

			/// <summary>1:N subject_knowledgearticles</summary>
			public const string SubjectKnowledgearticles = "subject_knowledgearticles";

			/// <summary>1:N subject_parent_subject</summary>
			public const string SubjectParentSubject = "subject_parent_subject";

			/// <summary>1:N Subject_ProcessSessions</summary>
			public const string SubjectProcessSessions = "Subject_ProcessSessions";

			/// <summary>1:N subject_products</summary>
			public const string SubjectProducts = "subject_products";

			/// <summary>1:N subject_sales_literature</summary>
			public const string SubjectSalesLiterature = "subject_sales_literature";

			/// <summary>1:N Subject_SyncErrors</summary>
			public const string SubjectSyncErrors = "Subject_SyncErrors";

		}
		#endregion
	}
}

