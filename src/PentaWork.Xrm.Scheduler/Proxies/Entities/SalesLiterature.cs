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
	[EntityLogicalName("salesliterature")]
	public sealed class SalesLiterature : Entity
	{	
		public static readonly int? EntityTypeCode = 1038;
		public new const string LogicalName = "salesliterature";
		public const string PrimaryIdAttribute = "salesliteratureid";
		public const string PrimaryNameAttribute = "name";
	
		public SalesLiterature() : base("salesliterature") { }

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
        /// employeecontactid
        /// </summary>
		[DisplayName("Employee Contact")]
		[AttributeLogicalName("employeecontactid")]
		public EntityReference EmployeeContact
		{	
			get { return GetAttributeValue<EntityReference>("employeecontactid"); }
			set
			{ 
				if(value == EmployeeContact) return;
				SetAttributeValue("employeecontactid", value);
			}
		}	
			
		/// <summary>
        /// employeecontactidname
        /// </summary>
		[DisplayName("employeecontactidname")]
		[AttributeLogicalName("employeecontactidname")]
		public string Employeecontactidname
		{	
			get { return GetAttributeValue<string>("employeecontactidname"); }
			set
			{ 
				if(value == Employeecontactidname) return;
				SetAttributeValue("employeecontactidname", value);
			}
		}	
			
		/// <summary>
        /// employeecontactidyominame
        /// </summary>
		[DisplayName("employeecontactidyominame")]
		[AttributeLogicalName("employeecontactidyominame")]
		public string Employeecontactidyominame
		{	
			get { return GetAttributeValue<string>("employeecontactidyominame"); }
			set
			{ 
				if(value == Employeecontactidyominame) return;
				SetAttributeValue("employeecontactidyominame", value);
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
        /// exchangerate
        /// </summary>
		[DisplayName("Exchange Rate")]
		[AttributeLogicalName("exchangerate")]
		public decimal? ExchangeRate
		{	
			get { return GetAttributeValue<decimal?>("exchangerate"); }
			set
			{ 
				if(value == ExchangeRate) return;
				SetAttributeValue("exchangerate", value);
			}
		}	
			
		/// <summary>
        /// expirationdate
        /// </summary>
		[DisplayName("Expiration Date")]
		[AttributeLogicalName("expirationdate")]
		public DateTime? ExpirationDate
		{	
			get { return GetAttributeValue<DateTime?>("expirationdate"); }
			set
			{ 
				if(value == ExpirationDate) return;
				SetAttributeValue("expirationdate", value);
			}
		}	
			
		/// <summary>
        /// hasattachments
        /// </summary>
		[DisplayName("Has Attachments")]
		[AttributeLogicalName("hasattachments")]
		public bool? HasAttachments
		{	
			get { return GetAttributeValue<bool?>("hasattachments"); }
			set
			{ 
				if(value == HasAttachments) return;
				SetAttributeValue("hasattachments", value);
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
        /// literaturetypecode
        /// </summary>
		[DisplayName("Type")]
		[AttributeLogicalName("literaturetypecode")]
		public eType? Type
		{	
			get 
			{ 
				var optionSetValue = GetAttributeValue<OptionSetValue>("literaturetypecode");
				if (optionSetValue != null) return (eType)optionSetValue.Value;
				else return null;
			}
			set 
			{ 
				if(value == Type) return;

				OptionSetValue optionSetValue = null;
				if(value != null) optionSetValue = new OptionSetValue((int)value);
				SetAttributeValue("literaturetypecode", optionSetValue); 
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
        /// name
        /// </summary>
		[DisplayName("Title")]
		[AttributeLogicalName("name")]
		public string Title
		{	
			get { return GetAttributeValue<string>("name"); }
			set
			{ 
				if(value == Title) return;
				SetAttributeValue("name", value);
			}
		}	
			
		/// <summary>
        /// organizationid
        /// </summary>
		[DisplayName("Organization Id")]
		[AttributeLogicalName("organizationid")]
		public EntityReference OrganizationId
		{	
			get { return GetAttributeValue<EntityReference>("organizationid"); }
			set
			{ 
				if(value == OrganizationId) return;
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
        /// processid
        /// </summary>
		[DisplayName("Process Id")]
		[AttributeLogicalName("processid")]
		public Guid ProcessId
		{	
			get { return GetAttributeValue<Guid>("processid"); }
			set
			{ 
				if(value == ProcessId) return;
				SetAttributeValue("processid", value);
			}
		}	
			
		/// <summary>
        /// salesliteratureid
        /// </summary>
		[DisplayName("Sales Literature")]
		[AttributeLogicalName("salesliteratureid")]
		public override Guid Id
		{
			get => base.Id;
			set { base.Id = value; SetAttributeValue("salesliteratureid", value); }
		}

							/// <summary>
        /// stageid
        /// </summary>
		[DisplayName("(Deprecated) Stage Id")]
		[AttributeLogicalName("stageid")]
		public Guid DeprecatedStageId
		{	
			get { return GetAttributeValue<Guid>("stageid"); }
			set
			{ 
				if(value == DeprecatedStageId) return;
				SetAttributeValue("stageid", value);
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
        /// traversedpath
        /// </summary>
		[DisplayName("(Deprecated) Traversed Path")]
		[AttributeLogicalName("traversedpath")]
		public string DeprecatedTraversedPath
		{	
			get { return GetAttributeValue<string>("traversedpath"); }
			set
			{ 
				if(value == DeprecatedTraversedPath) return;
				SetAttributeValue("traversedpath", value);
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
        /// 1:N Get entities for 'sales_literature_items'
        /// </summary>
		[RelationshipSchemaName("sales_literature_items")]
		public IEnumerable<SalesAttachment> SalesLiteratureItems
		{
			get { return GetRelatedEntities<SalesAttachment>("sales_literature_items", null); }
			set { SetRelatedEntities("sales_literature_items", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'SalesLiterature_AsyncOperations'
        /// </summary>
		[RelationshipSchemaName("SalesLiterature_AsyncOperations")]
		public IEnumerable<SystemJob> SalesLiteratureAsyncOperations
		{
			get { return GetRelatedEntities<SystemJob>("SalesLiterature_AsyncOperations", null); }
			set { SetRelatedEntities("SalesLiterature_AsyncOperations", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'SalesLiterature_BulkDeleteFailures'
        /// </summary>
		[RelationshipSchemaName("SalesLiterature_BulkDeleteFailures")]
		public IEnumerable<BulkDeleteFailure> SalesLiteratureBulkDeleteFailures
		{
			get { return GetRelatedEntities<BulkDeleteFailure>("SalesLiterature_BulkDeleteFailures", null); }
			set { SetRelatedEntities("SalesLiterature_BulkDeleteFailures", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'salesliterature_MailboxTrackingFolders'
        /// </summary>
		[RelationshipSchemaName("salesliterature_MailboxTrackingFolders")]
		public IEnumerable<MailboxAutoTrackingFolder> SalesliteratureMailboxTrackingFolders
		{
			get { return GetRelatedEntities<MailboxAutoTrackingFolder>("salesliterature_MailboxTrackingFolders", null); }
			set { SetRelatedEntities("salesliterature_MailboxTrackingFolders", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'salesliterature_principalobjectattributeaccess'
        /// </summary>
		[RelationshipSchemaName("salesliterature_principalobjectattributeaccess")]
		public IEnumerable<FieldSharing> SalesliteraturePrincipalobjectattributeaccess
		{
			get { return GetRelatedEntities<FieldSharing>("salesliterature_principalobjectattributeaccess", null); }
			set { SetRelatedEntities("salesliterature_principalobjectattributeaccess", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'SalesLiterature_ProcessSessions'
        /// </summary>
		[RelationshipSchemaName("SalesLiterature_ProcessSessions")]
		public IEnumerable<ProcessSession> SalesLiteratureProcessSessions
		{
			get { return GetRelatedEntities<ProcessSession>("SalesLiterature_ProcessSessions", null); }
			set { SetRelatedEntities("SalesLiterature_ProcessSessions", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'SalesLiterature_SharepointDocumentLocation'
        /// </summary>
		[RelationshipSchemaName("SalesLiterature_SharepointDocumentLocation")]
		public IEnumerable<DocumentLocation> SalesLiteratureSharepointDocumentLocation
		{
			get { return GetRelatedEntities<DocumentLocation>("SalesLiterature_SharepointDocumentLocation", null); }
			set { SetRelatedEntities("SalesLiterature_SharepointDocumentLocation", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'SalesLiterature_SyncErrors'
        /// </summary>
		[RelationshipSchemaName("SalesLiterature_SyncErrors")]
		public IEnumerable<SyncError> SalesLiteratureSyncErrors
		{
			get { return GetRelatedEntities<SyncError>("SalesLiterature_SyncErrors", null); }
			set { SetRelatedEntities("SalesLiterature_SyncErrors", null, value); }
		}
		/// <summary>
        /// N:N Get entities for 'CampaignActivity'
        /// </summary>
		[RelationshipSchemaName("campaignactivitysalesliterature_association")]
		public IEnumerable<CampaignActivity> CampaignactivitysalesliteratureAssociation
		{
			get { return GetRelatedEntities<CampaignActivity>("campaignactivitysalesliterature_association", null); }
			set { SetRelatedEntities("campaignactivitysalesliterature_association", null, value); }
		}
		/// <summary>
        /// N:N Get entities for 'Campaign'
        /// </summary>
		[RelationshipSchemaName("campaignsalesliterature_association")]
		public IEnumerable<Campaign> CampaignsalesliteratureAssociation
		{
			get { return GetRelatedEntities<Campaign>("campaignsalesliterature_association", null); }
			set { SetRelatedEntities("campaignsalesliterature_association", null, value); }
		}
		/// <summary>
        /// N:N Get entities for 'Competitor'
        /// </summary>
		[RelationshipSchemaName("competitorsalesliterature_association")]
		public IEnumerable<Competitor> CompetitorsalesliteratureAssociation
		{
			get { return GetRelatedEntities<Competitor>("competitorsalesliterature_association", null); }
			set { SetRelatedEntities("competitorsalesliterature_association", null, value); }
		}
		/// <summary>
        /// N:N Get entities for 'Product'
        /// </summary>
		[RelationshipSchemaName("productsalesliterature_association")]
		public IEnumerable<Product> ProductsalesliteratureAssociation
		{
			get { return GetRelatedEntities<Product>("productsalesliterature_association", null); }
			set { SetRelatedEntities("productsalesliterature_association", null, value); }
		}
		#endregion

		#region Actions
		#endregion

		#region OptionSetEnums
		public enum eType
		{	
		
			[Label("Presentation")]
			[Description(@"")]
			Presentation = 0, 
		
			[Label("Product Sheet")]
			[Description(@"")]
			ProductSheet = 1, 
		
			[Label("Policies And Procedures")]
			[Description(@"")]
			PoliciesAndProcedures = 2, 
		
			[Label("Sales Literature")]
			[Description(@"")]
			SalesLiterature = 3, 
		
			[Label("Spreadsheets")]
			[Description(@"")]
			Spreadsheets = 4, 
		
			[Label("News")]
			[Description(@"")]
			News = 5, 
		
			[Label("Bulletins")]
			[Description(@"")]
			Bulletins = 6, 
		
			[Label("Price Sheets")]
			[Description(@"")]
			PriceSheets = 7, 
		
			[Label("Manuals")]
			[Description(@"")]
			Manuals = 8, 
		
			[Label("Company Background")]
			[Description(@"")]
			CompanyBackground = 9, 
		
			[Label("Marketing Collateral")]
			[Description(@"")]
			MarketingCollateral = 100001, 
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

			/// <summary>description</summary>
			public const string Description = "description";

			/// <summary>employeecontactid</summary>
			public const string EmployeeContact = "employeecontactid";

			/// <summary>employeecontactidname</summary>
			public const string Employeecontactidname = "employeecontactidname";

			/// <summary>employeecontactidyominame</summary>
			public const string Employeecontactidyominame = "employeecontactidyominame";

			/// <summary>entityimage_timestamp</summary>
			public const string EntityimageTimestamp = "entityimage_timestamp";

			/// <summary>entityimage_url</summary>
			public const string EntityimageUrl = "entityimage_url";

			/// <summary>entityimageid</summary>
			public const string EntityimageId = "entityimageid";

			/// <summary>exchangerate</summary>
			public const string ExchangeRate = "exchangerate";

			/// <summary>expirationdate</summary>
			public const string ExpirationDate = "expirationdate";

			/// <summary>hasattachments</summary>
			public const string HasAttachments = "hasattachments";

			/// <summary>importsequencenumber</summary>
			public const string ImportSequenceNumber = "importsequencenumber";

			/// <summary>iscustomerviewable</summary>
			public const string CustomerViewable = "iscustomerviewable";

			/// <summary>keywords</summary>
			public const string KeyWords = "keywords";

			/// <summary>literaturetypecode</summary>
			public const string Type = "literaturetypecode";

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

			/// <summary>name</summary>
			public const string Title = "name";

			/// <summary>organizationid</summary>
			public const string OrganizationId = "organizationid";

			/// <summary>organizationidname</summary>
			public const string Organizationidname = "organizationidname";

			/// <summary>overriddencreatedon</summary>
			public const string RecordCreatedOn = "overriddencreatedon";

			/// <summary>processid</summary>
			public const string ProcessId = "processid";

			/// <summary>salesliteratureid</summary>
			public const string SalesLiteratureId = "salesliteratureid";

			/// <summary>stageid</summary>
			public const string DeprecatedStageId = "stageid";

			/// <summary>subjectid</summary>
			public const string Subject = "subjectid";

			/// <summary>subjectidname</summary>
			public const string Subjectidname = "subjectidname";

			/// <summary>timezoneruleversionnumber</summary>
			public const string TimeZoneRuleVersionNumber = "timezoneruleversionnumber";

			/// <summary>transactioncurrencyid</summary>
			public const string Currency = "transactioncurrencyid";

			/// <summary>transactioncurrencyidname</summary>
			public const string Transactioncurrencyidname = "transactioncurrencyidname";

			/// <summary>traversedpath</summary>
			public const string DeprecatedTraversedPath = "traversedpath";

			/// <summary>utcconversiontimezonecode</summary>
			public const string UTCConversionTimeZoneCode = "utcconversiontimezonecode";

			/// <summary>versionnumber</summary>
			public const string VersionNumber = "versionnumber";

		}
		#endregion

		#region Schemas
		public static class Schemas 
		{
			/// <summary>1:N sales_literature_items</summary>
			public const string SalesLiteratureItems = "sales_literature_items";

			/// <summary>1:N SalesLiterature_AsyncOperations</summary>
			public const string SalesLiteratureAsyncOperations = "SalesLiterature_AsyncOperations";

			/// <summary>1:N SalesLiterature_BulkDeleteFailures</summary>
			public const string SalesLiteratureBulkDeleteFailures = "SalesLiterature_BulkDeleteFailures";

			/// <summary>1:N salesliterature_MailboxTrackingFolders</summary>
			public const string SalesliteratureMailboxTrackingFolders = "salesliterature_MailboxTrackingFolders";

			/// <summary>1:N salesliterature_principalobjectattributeaccess</summary>
			public const string SalesliteraturePrincipalobjectattributeaccess = "salesliterature_principalobjectattributeaccess";

			/// <summary>1:N SalesLiterature_ProcessSessions</summary>
			public const string SalesLiteratureProcessSessions = "SalesLiterature_ProcessSessions";

			/// <summary>1:N SalesLiterature_SharepointDocumentLocation</summary>
			public const string SalesLiteratureSharepointDocumentLocation = "SalesLiterature_SharepointDocumentLocation";

			/// <summary>1:N SalesLiterature_SyncErrors</summary>
			public const string SalesLiteratureSyncErrors = "SalesLiterature_SyncErrors";

			/// <summary>N:N campaignactivitysalesliterature_association</summary>
			public const string CampaignactivitysalesliteratureAssociation = "campaignactivitysalesliterature_association";

			/// <summary>N:N campaignsalesliterature_association</summary>
			public const string CampaignsalesliteratureAssociation = "campaignsalesliterature_association";

			/// <summary>N:N competitorsalesliterature_association</summary>
			public const string CompetitorsalesliteratureAssociation = "competitorsalesliterature_association";

			/// <summary>N:N productsalesliterature_association</summary>
			public const string ProductsalesliteratureAssociation = "productsalesliterature_association";

		}
		#endregion
	}
}

