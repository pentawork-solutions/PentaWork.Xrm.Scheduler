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
	[EntityLogicalName("bookableresourcegroup")]
	public sealed class BookableResourceGroup : Entity
	{	
		public static readonly int? EntityTypeCode = 1151;
		public new const string LogicalName = "bookableresourcegroup";
		public const string PrimaryIdAttribute = "bookableresourcegroupid";
		public const string PrimaryNameAttribute = "name";
	
		public BookableResourceGroup() : base("bookableresourcegroup") { }

		#region Attributes
		/// <summary>
        /// bookableresourcegroupid
        /// </summary>
		[DisplayName("Bookable Resource Group")]
		[AttributeLogicalName("bookableresourcegroupid")]
		public override Guid Id
		{
			get => base.Id;
			set { base.Id = value; SetAttributeValue("bookableresourcegroupid", value); }
		}

							/// <summary>
        /// childresource
        /// </summary>
		[DisplayName("Child Resource")]
		[AttributeLogicalName("childresource")]
		public EntityReference ChildResource
		{	
			get { return GetAttributeValue<EntityReference>("childresource"); }
			set
			{ 
				if(value == ChildResource) return;
				SetAttributeValue("childresource", value);
			}
		}	
			
		/// <summary>
        /// childresourcename
        /// </summary>
		[DisplayName("childresourcename")]
		[AttributeLogicalName("childresourcename")]
		public string Childresourcename
		{	
			get { return GetAttributeValue<string>("childresourcename"); }
			set
			{ 
				if(value == Childresourcename) return;
				SetAttributeValue("childresourcename", value);
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
        /// exchangerate
		///
		/// Precision: 10
		/// MaxValue: 100000000000
		/// MinValue: 0.0000000001
        /// </summary>
		[DisplayName("ExchangeRate")]
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
        /// fromdate
        /// </summary>
		[DisplayName("From Date")]
		[AttributeLogicalName("fromdate")]
		public DateTime? FromDate
		{	
			get { return GetAttributeValue<DateTime?>("fromdate"); }
			set
			{ 
				if(value == FromDate) return;
				SetAttributeValue("fromdate", value);
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
        /// parentresource
        /// </summary>
		[DisplayName("Parent Resource")]
		[AttributeLogicalName("parentresource")]
		public EntityReference ParentResource
		{	
			get { return GetAttributeValue<EntityReference>("parentresource"); }
			set
			{ 
				if(value == ParentResource) return;
				SetAttributeValue("parentresource", value);
			}
		}	
			
		/// <summary>
        /// parentresourcename
        /// </summary>
		[DisplayName("parentresourcename")]
		[AttributeLogicalName("parentresourcename")]
		public string Parentresourcename
		{	
			get { return GetAttributeValue<string>("parentresourcename"); }
			set
			{ 
				if(value == Parentresourcename) return;
				SetAttributeValue("parentresourcename", value);
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
        /// todate
        /// </summary>
		[DisplayName("To Date")]
		[AttributeLogicalName("todate")]
		public DateTime? ToDate
		{	
			get { return GetAttributeValue<DateTime?>("todate"); }
			set
			{ 
				if(value == ToDate) return;
				SetAttributeValue("todate", value);
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
        /// 1:N Get entities for 'bookableresourcegroup_Annotations'
        /// </summary>
		[RelationshipSchemaName("bookableresourcegroup_Annotations")]
		public IEnumerable<Note> BookableresourcegroupAnnotations
		{
			get { return GetRelatedEntities<Note>("bookableresourcegroup_Annotations", null); }
			set { SetRelatedEntities("bookableresourcegroup_Annotations", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'bookableresourcegroup_AsyncOperations'
        /// </summary>
		[RelationshipSchemaName("bookableresourcegroup_AsyncOperations")]
		public IEnumerable<SystemJob> BookableresourcegroupAsyncOperations
		{
			get { return GetRelatedEntities<SystemJob>("bookableresourcegroup_AsyncOperations", null); }
			set { SetRelatedEntities("bookableresourcegroup_AsyncOperations", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'bookableresourcegroup_BulkDeleteFailures'
        /// </summary>
		[RelationshipSchemaName("bookableresourcegroup_BulkDeleteFailures")]
		public IEnumerable<BulkDeleteFailure> BookableresourcegroupBulkDeleteFailures
		{
			get { return GetRelatedEntities<BulkDeleteFailure>("bookableresourcegroup_BulkDeleteFailures", null); }
			set { SetRelatedEntities("bookableresourcegroup_BulkDeleteFailures", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'bookableresourcegroup_DuplicateBaseRecord'
        /// </summary>
		[RelationshipSchemaName("bookableresourcegroup_DuplicateBaseRecord")]
		public IEnumerable<DuplicateRecord> BookableresourcegroupDuplicateBaseRecord
		{
			get { return GetRelatedEntities<DuplicateRecord>("bookableresourcegroup_DuplicateBaseRecord", null); }
			set { SetRelatedEntities("bookableresourcegroup_DuplicateBaseRecord", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'bookableresourcegroup_DuplicateMatchingRecord'
        /// </summary>
		[RelationshipSchemaName("bookableresourcegroup_DuplicateMatchingRecord")]
		public IEnumerable<DuplicateRecord> BookableresourcegroupDuplicateMatchingRecord
		{
			get { return GetRelatedEntities<DuplicateRecord>("bookableresourcegroup_DuplicateMatchingRecord", null); }
			set { SetRelatedEntities("bookableresourcegroup_DuplicateMatchingRecord", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'bookableresourcegroup_MailboxTrackingFolders'
        /// </summary>
		[RelationshipSchemaName("bookableresourcegroup_MailboxTrackingFolders")]
		public IEnumerable<MailboxAutoTrackingFolder> BookableresourcegroupMailboxTrackingFolders
		{
			get { return GetRelatedEntities<MailboxAutoTrackingFolder>("bookableresourcegroup_MailboxTrackingFolders", null); }
			set { SetRelatedEntities("bookableresourcegroup_MailboxTrackingFolders", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'bookableresourcegroup_PrincipalObjectAttributeAccess'
        /// </summary>
		[RelationshipSchemaName("bookableresourcegroup_PrincipalObjectAttributeAccess")]
		public IEnumerable<FieldSharing> BookableresourcegroupPrincipalObjectAttributeAccess
		{
			get { return GetRelatedEntities<FieldSharing>("bookableresourcegroup_PrincipalObjectAttributeAccess", null); }
			set { SetRelatedEntities("bookableresourcegroup_PrincipalObjectAttributeAccess", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'bookableresourcegroup_ProcessSession'
        /// </summary>
		[RelationshipSchemaName("bookableresourcegroup_ProcessSession")]
		public IEnumerable<ProcessSession> BookableresourcegroupProcessSession
		{
			get { return GetRelatedEntities<ProcessSession>("bookableresourcegroup_ProcessSession", null); }
			set { SetRelatedEntities("bookableresourcegroup_ProcessSession", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'BookableResourceGroup_SyncErrors'
        /// </summary>
		[RelationshipSchemaName("BookableResourceGroup_SyncErrors")]
		public IEnumerable<SyncError> BookableResourceGroupSyncErrors
		{
			get { return GetRelatedEntities<SyncError>("BookableResourceGroup_SyncErrors", null); }
			set { SetRelatedEntities("BookableResourceGroup_SyncErrors", null, value); }
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
			/// <summary>bookableresourcegroupid</summary>
			public const string BookableResourceGroupId = "bookableresourcegroupid";

			/// <summary>childresource</summary>
			public const string ChildResource = "childresource";

			/// <summary>childresourcename</summary>
			public const string Childresourcename = "childresourcename";

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

			/// <summary>fromdate</summary>
			public const string FromDate = "fromdate";

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

			/// <summary>parentresource</summary>
			public const string ParentResource = "parentresource";

			/// <summary>parentresourcename</summary>
			public const string Parentresourcename = "parentresourcename";

			/// <summary>statecode</summary>
			public const string Status = "statecode";

			/// <summary>statuscode</summary>
			public const string StatusReason = "statuscode";

			/// <summary>timezoneruleversionnumber</summary>
			public const string TimeZoneRuleVersionNumber = "timezoneruleversionnumber";

			/// <summary>todate</summary>
			public const string ToDate = "todate";

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
			/// <summary>1:N bookableresourcegroup_Annotations</summary>
			public const string BookableresourcegroupAnnotations = "bookableresourcegroup_Annotations";

			/// <summary>1:N bookableresourcegroup_AsyncOperations</summary>
			public const string BookableresourcegroupAsyncOperations = "bookableresourcegroup_AsyncOperations";

			/// <summary>1:N bookableresourcegroup_BulkDeleteFailures</summary>
			public const string BookableresourcegroupBulkDeleteFailures = "bookableresourcegroup_BulkDeleteFailures";

			/// <summary>1:N bookableresourcegroup_DuplicateBaseRecord</summary>
			public const string BookableresourcegroupDuplicateBaseRecord = "bookableresourcegroup_DuplicateBaseRecord";

			/// <summary>1:N bookableresourcegroup_DuplicateMatchingRecord</summary>
			public const string BookableresourcegroupDuplicateMatchingRecord = "bookableresourcegroup_DuplicateMatchingRecord";

			/// <summary>1:N bookableresourcegroup_MailboxTrackingFolders</summary>
			public const string BookableresourcegroupMailboxTrackingFolders = "bookableresourcegroup_MailboxTrackingFolders";

			/// <summary>1:N bookableresourcegroup_PrincipalObjectAttributeAccess</summary>
			public const string BookableresourcegroupPrincipalObjectAttributeAccess = "bookableresourcegroup_PrincipalObjectAttributeAccess";

			/// <summary>1:N bookableresourcegroup_ProcessSession</summary>
			public const string BookableresourcegroupProcessSession = "bookableresourcegroup_ProcessSession";

			/// <summary>1:N BookableResourceGroup_SyncErrors</summary>
			public const string BookableResourceGroupSyncErrors = "BookableResourceGroup_SyncErrors";

		}
		#endregion
	}
}

