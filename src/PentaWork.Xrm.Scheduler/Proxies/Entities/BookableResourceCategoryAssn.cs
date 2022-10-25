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
	[EntityLogicalName("bookableresourcecategoryassn")]
	public sealed class BookableResourceCategoryAssn : Entity
	{	
		public static readonly int? EntityTypeCode = 1149;
		public new const string LogicalName = "bookableresourcecategoryassn";
		public const string PrimaryIdAttribute = "bookableresourcecategoryassnid";
		public const string PrimaryNameAttribute = "name";
	
		public BookableResourceCategoryAssn() : base("bookableresourcecategoryassn") { }

		#region Attributes
		/// <summary>
        /// bookableresourcecategoryassnid
        /// </summary>
		[DisplayName("Resource Category Assn")]
		[AttributeLogicalName("bookableresourcecategoryassnid")]
		public override Guid Id
		{
			get => base.Id;
			set { base.Id = value; SetAttributeValue("bookableresourcecategoryassnid", value); }
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
        /// exchangerate
        /// </summary>
		[DisplayName("ExchangeRate")]
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
        /// name
        /// </summary>
		[DisplayName("Name")]
		[AttributeLogicalName("name")]
		public string Name
		{	
			get { return GetAttributeValue<string>("name"); }
			set
			{ 
				if(value == Name) return;
				SetAttributeValue("name", value);
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
        /// resource
        /// </summary>
		[DisplayName("Resource")]
		[AttributeLogicalName("resource")]
		public EntityReference Resource
		{	
			get { return GetAttributeValue<EntityReference>("resource"); }
			set
			{ 
				if(value == Resource) return;
				SetAttributeValue("resource", value);
			}
		}	
			
		/// <summary>
        /// resourcecategory
        /// </summary>
		[DisplayName("Resource Category")]
		[AttributeLogicalName("resourcecategory")]
		public EntityReference ResourceCategory
		{	
			get { return GetAttributeValue<EntityReference>("resourcecategory"); }
			set
			{ 
				if(value == ResourceCategory) return;
				SetAttributeValue("resourcecategory", value);
			}
		}	
			
		/// <summary>
        /// resourcecategoryname
        /// </summary>
		[DisplayName("resourcecategoryname")]
		[AttributeLogicalName("resourcecategoryname")]
		public string Resourcecategoryname
		{	
			get { return GetAttributeValue<string>("resourcecategoryname"); }
			set
			{ 
				if(value == Resourcecategoryname) return;
				SetAttributeValue("resourcecategoryname", value);
			}
		}	
			
		/// <summary>
        /// resourcename
        /// </summary>
		[DisplayName("resourcename")]
		[AttributeLogicalName("resourcename")]
		public string Resourcename
		{	
			get { return GetAttributeValue<string>("resourcename"); }
			set
			{ 
				if(value == Resourcename) return;
				SetAttributeValue("resourcename", value);
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
        /// 1:N Get entities for 'bookableresourcecategoryassn_Annotations'
        /// </summary>
		[RelationshipSchemaName("bookableresourcecategoryassn_Annotations")]
		public IEnumerable<Note> BookableresourcecategoryassnAnnotations
		{
			get { return GetRelatedEntities<Note>("bookableresourcecategoryassn_Annotations", null); }
			set { SetRelatedEntities("bookableresourcecategoryassn_Annotations", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'bookableresourcecategoryassn_AsyncOperations'
        /// </summary>
		[RelationshipSchemaName("bookableresourcecategoryassn_AsyncOperations")]
		public IEnumerable<SystemJob> BookableresourcecategoryassnAsyncOperations
		{
			get { return GetRelatedEntities<SystemJob>("bookableresourcecategoryassn_AsyncOperations", null); }
			set { SetRelatedEntities("bookableresourcecategoryassn_AsyncOperations", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'bookableresourcecategoryassn_BulkDeleteFailures'
        /// </summary>
		[RelationshipSchemaName("bookableresourcecategoryassn_BulkDeleteFailures")]
		public IEnumerable<BulkDeleteFailure> BookableresourcecategoryassnBulkDeleteFailures
		{
			get { return GetRelatedEntities<BulkDeleteFailure>("bookableresourcecategoryassn_BulkDeleteFailures", null); }
			set { SetRelatedEntities("bookableresourcecategoryassn_BulkDeleteFailures", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'bookableresourcecategoryassn_DuplicateBaseRecord'
        /// </summary>
		[RelationshipSchemaName("bookableresourcecategoryassn_DuplicateBaseRecord")]
		public IEnumerable<DuplicateRecord> BookableresourcecategoryassnDuplicateBaseRecord
		{
			get { return GetRelatedEntities<DuplicateRecord>("bookableresourcecategoryassn_DuplicateBaseRecord", null); }
			set { SetRelatedEntities("bookableresourcecategoryassn_DuplicateBaseRecord", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'bookableresourcecategoryassn_DuplicateMatchingRecord'
        /// </summary>
		[RelationshipSchemaName("bookableresourcecategoryassn_DuplicateMatchingRecord")]
		public IEnumerable<DuplicateRecord> BookableresourcecategoryassnDuplicateMatchingRecord
		{
			get { return GetRelatedEntities<DuplicateRecord>("bookableresourcecategoryassn_DuplicateMatchingRecord", null); }
			set { SetRelatedEntities("bookableresourcecategoryassn_DuplicateMatchingRecord", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'bookableresourcecategoryassn_MailboxTrackingFolders'
        /// </summary>
		[RelationshipSchemaName("bookableresourcecategoryassn_MailboxTrackingFolders")]
		public IEnumerable<MailboxAutoTrackingFolder> BookableresourcecategoryassnMailboxTrackingFolders
		{
			get { return GetRelatedEntities<MailboxAutoTrackingFolder>("bookableresourcecategoryassn_MailboxTrackingFolders", null); }
			set { SetRelatedEntities("bookableresourcecategoryassn_MailboxTrackingFolders", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'bookableresourcecategoryassn_PrincipalObjectAttributeAccess'
        /// </summary>
		[RelationshipSchemaName("bookableresourcecategoryassn_PrincipalObjectAttributeAccess")]
		public IEnumerable<FieldSharing> BookableresourcecategoryassnPrincipalObjectAttributeAccess
		{
			get { return GetRelatedEntities<FieldSharing>("bookableresourcecategoryassn_PrincipalObjectAttributeAccess", null); }
			set { SetRelatedEntities("bookableresourcecategoryassn_PrincipalObjectAttributeAccess", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'bookableresourcecategoryassn_ProcessSession'
        /// </summary>
		[RelationshipSchemaName("bookableresourcecategoryassn_ProcessSession")]
		public IEnumerable<ProcessSession> BookableresourcecategoryassnProcessSession
		{
			get { return GetRelatedEntities<ProcessSession>("bookableresourcecategoryassn_ProcessSession", null); }
			set { SetRelatedEntities("bookableresourcecategoryassn_ProcessSession", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'BookableResourceCategoryAssn_SyncErrors'
        /// </summary>
		[RelationshipSchemaName("BookableResourceCategoryAssn_SyncErrors")]
		public IEnumerable<SyncError> BookableResourceCategoryAssnSyncErrors
		{
			get { return GetRelatedEntities<SyncError>("BookableResourceCategoryAssn_SyncErrors", null); }
			set { SetRelatedEntities("BookableResourceCategoryAssn_SyncErrors", null, value); }
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
			/// <summary>bookableresourcecategoryassnid</summary>
			public const string ResourceCategoryAssnId = "bookableresourcecategoryassnid";

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

			/// <summary>exchangerate</summary>
			public const string ExchangeRate = "exchangerate";

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

			/// <summary>name</summary>
			public const string Name = "name";

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

			/// <summary>resource</summary>
			public const string Resource = "resource";

			/// <summary>resourcecategory</summary>
			public const string ResourceCategory = "resourcecategory";

			/// <summary>resourcecategoryname</summary>
			public const string Resourcecategoryname = "resourcecategoryname";

			/// <summary>resourcename</summary>
			public const string Resourcename = "resourcename";

			/// <summary>statecode</summary>
			public const string Status = "statecode";

			/// <summary>statuscode</summary>
			public const string StatusReason = "statuscode";

			/// <summary>timezoneruleversionnumber</summary>
			public const string TimeZoneRuleVersionNumber = "timezoneruleversionnumber";

			/// <summary>transactioncurrencyid</summary>
			public const string Currency = "transactioncurrencyid";

			/// <summary>transactioncurrencyidname</summary>
			public const string Transactioncurrencyidname = "transactioncurrencyidname";

			/// <summary>utcconversiontimezonecode</summary>
			public const string UTCConversionTimeZoneCode = "utcconversiontimezonecode";

			/// <summary>versionnumber</summary>
			public const string VersionNumber = "versionnumber";

		}
		#endregion

		#region Schemas
		public static class Schemas 
		{
			/// <summary>1:N bookableresourcecategoryassn_Annotations</summary>
			public const string BookableresourcecategoryassnAnnotations = "bookableresourcecategoryassn_Annotations";

			/// <summary>1:N bookableresourcecategoryassn_AsyncOperations</summary>
			public const string BookableresourcecategoryassnAsyncOperations = "bookableresourcecategoryassn_AsyncOperations";

			/// <summary>1:N bookableresourcecategoryassn_BulkDeleteFailures</summary>
			public const string BookableresourcecategoryassnBulkDeleteFailures = "bookableresourcecategoryassn_BulkDeleteFailures";

			/// <summary>1:N bookableresourcecategoryassn_DuplicateBaseRecord</summary>
			public const string BookableresourcecategoryassnDuplicateBaseRecord = "bookableresourcecategoryassn_DuplicateBaseRecord";

			/// <summary>1:N bookableresourcecategoryassn_DuplicateMatchingRecord</summary>
			public const string BookableresourcecategoryassnDuplicateMatchingRecord = "bookableresourcecategoryassn_DuplicateMatchingRecord";

			/// <summary>1:N bookableresourcecategoryassn_MailboxTrackingFolders</summary>
			public const string BookableresourcecategoryassnMailboxTrackingFolders = "bookableresourcecategoryassn_MailboxTrackingFolders";

			/// <summary>1:N bookableresourcecategoryassn_PrincipalObjectAttributeAccess</summary>
			public const string BookableresourcecategoryassnPrincipalObjectAttributeAccess = "bookableresourcecategoryassn_PrincipalObjectAttributeAccess";

			/// <summary>1:N bookableresourcecategoryassn_ProcessSession</summary>
			public const string BookableresourcecategoryassnProcessSession = "bookableresourcecategoryassn_ProcessSession";

			/// <summary>1:N BookableResourceCategoryAssn_SyncErrors</summary>
			public const string BookableResourceCategoryAssnSyncErrors = "BookableResourceCategoryAssn_SyncErrors";

		}
		#endregion
	}
}

