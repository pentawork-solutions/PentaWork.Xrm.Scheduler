using System;
using System.Linq;
using System.Diagnostics;
using System.ComponentModel;
using Microsoft.Xrm.Sdk; 
using Microsoft.Xrm.Sdk.Client;
using System.Collections.Generic;

namespace PentaWork.Xrm.Scheduler.Proxies.Entities
{
	[DebuggerDisplay("{SearchTerm}")] 	
	[EntityLogicalName("msdyn_knowledgesearchinsight")]
	public sealed class KnowledgeSearchInsight : Entity
	{	
		public static readonly int? EntityTypeCode = 10046;
		public new const string LogicalName = "msdyn_knowledgesearchinsight";
		public const string PrimaryIdAttribute = "msdyn_knowledgesearchinsightid";
		public const string PrimaryNameAttribute = "msdyn_searchterm";
	
		public KnowledgeSearchInsight() : base("msdyn_knowledgesearchinsight") { }

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
        /// msdyn_applicationname
        /// </summary>
		[DisplayName("Application name")]
		[AttributeLogicalName("msdyn_applicationname")]
		public string ApplicationName
		{	
			get { return GetAttributeValue<string>("msdyn_applicationname"); }
			set
			{ 
				if(value == ApplicationName) return;
				SetAttributeValue("msdyn_applicationname", value);
			}
		}	
			
		/// <summary>
        /// msdyn_correlationid
        /// </summary>
		[DisplayName("Correlation ID")]
		[AttributeLogicalName("msdyn_correlationid")]
		public string CorrelationID
		{	
			get { return GetAttributeValue<string>("msdyn_correlationid"); }
			set
			{ 
				if(value == CorrelationID) return;
				SetAttributeValue("msdyn_correlationid", value);
			}
		}	
			
		/// <summary>
        /// msdyn_customcontrolid
        /// </summary>
		[DisplayName("Custom Control ID")]
		[AttributeLogicalName("msdyn_customcontrolid")]
		public string CustomControlID
		{	
			get { return GetAttributeValue<string>("msdyn_customcontrolid"); }
			set
			{ 
				if(value == CustomControlID) return;
				SetAttributeValue("msdyn_customcontrolid", value);
			}
		}	
			
		/// <summary>
        /// msdyn_entityrecordid
        /// </summary>
		[DisplayName("Entity Record ID")]
		[AttributeLogicalName("msdyn_entityrecordid")]
		public string EntityRecordID
		{	
			get { return GetAttributeValue<string>("msdyn_entityrecordid"); }
			set
			{ 
				if(value == EntityRecordID) return;
				SetAttributeValue("msdyn_entityrecordid", value);
			}
		}	
			
		/// <summary>
        /// msdyn_entitytype
        /// </summary>
		[DisplayName("Entity type")]
		[AttributeLogicalName("msdyn_entitytype")]
		public string EntityType
		{	
			get { return GetAttributeValue<string>("msdyn_entitytype"); }
			set
			{ 
				if(value == EntityType) return;
				SetAttributeValue("msdyn_entitytype", value);
			}
		}	
			
		/// <summary>
        /// msdyn_filters
        /// </summary>
		[DisplayName("Filters")]
		[AttributeLogicalName("msdyn_filters")]
		public string Filters
		{	
			get { return GetAttributeValue<string>("msdyn_filters"); }
			set
			{ 
				if(value == Filters) return;
				SetAttributeValue("msdyn_filters", value);
			}
		}	
			
		/// <summary>
        /// msdyn_initiatedby
        /// </summary>
		[DisplayName("Initiated by")]
		[AttributeLogicalName("msdyn_initiatedby")]
		public string InitiatedBy
		{	
			get { return GetAttributeValue<string>("msdyn_initiatedby"); }
			set
			{ 
				if(value == InitiatedBy) return;
				SetAttributeValue("msdyn_initiatedby", value);
			}
		}	
			
		/// <summary>
        /// msdyn_knowledgesearchinsightid
        /// </summary>
		[DisplayName("Knowledge Search Insight ID")]
		[AttributeLogicalName("msdyn_knowledgesearchinsightid")]
		public override Guid Id
		{
			get => base.Id;
			set { base.Id = value; SetAttributeValue("msdyn_knowledgesearchinsightid", value); }
		}

							/// <summary>
        /// msdyn_responsetime
        /// </summary>
		[DisplayName("Response time")]
		[AttributeLogicalName("msdyn_responsetime")]
		public int? ResponseTime
		{	
			get { return GetAttributeValue<int?>("msdyn_responsetime"); }
			set
			{ 
				if(value == ResponseTime) return;
				SetAttributeValue("msdyn_responsetime", value);
			}
		}	
			
		/// <summary>
        /// msdyn_resultcount
        /// </summary>
		[DisplayName("Result count")]
		[AttributeLogicalName("msdyn_resultcount")]
		public int? ResultCount
		{	
			get { return GetAttributeValue<int?>("msdyn_resultcount"); }
			set
			{ 
				if(value == ResultCount) return;
				SetAttributeValue("msdyn_resultcount", value);
			}
		}	
			
		/// <summary>
        /// msdyn_searchproviderid
        /// </summary>
		[DisplayName("Search Provider ID")]
		[AttributeLogicalName("msdyn_searchproviderid")]
		public string SearchProviderID
		{	
			get { return GetAttributeValue<string>("msdyn_searchproviderid"); }
			set
			{ 
				if(value == SearchProviderID) return;
				SetAttributeValue("msdyn_searchproviderid", value);
			}
		}	
			
		/// <summary>
        /// msdyn_searchprovidername
        /// </summary>
		[DisplayName("Search provider name")]
		[AttributeLogicalName("msdyn_searchprovidername")]
		public string SearchProviderName
		{	
			get { return GetAttributeValue<string>("msdyn_searchprovidername"); }
			set
			{ 
				if(value == SearchProviderName) return;
				SetAttributeValue("msdyn_searchprovidername", value);
			}
		}	
			
		/// <summary>
        /// msdyn_searchterm
        /// </summary>
		[DisplayName("Search term")]
		[AttributeLogicalName("msdyn_searchterm")]
		public string SearchTerm
		{	
			get { return GetAttributeValue<string>("msdyn_searchterm"); }
			set
			{ 
				if(value == SearchTerm) return;
				SetAttributeValue("msdyn_searchterm", value);
			}
		}	
			
		/// <summary>
        /// msdyn_searchtype
        /// </summary>
		[DisplayName("Search type")]
		[AttributeLogicalName("msdyn_searchtype")]
		public string SearchType
		{	
			get { return GetAttributeValue<string>("msdyn_searchtype"); }
			set
			{ 
				if(value == SearchType) return;
				SetAttributeValue("msdyn_searchtype", value);
			}
		}	
			
		/// <summary>
        /// msdyn_sortby
        /// </summary>
		[DisplayName("Sort by")]
		[AttributeLogicalName("msdyn_sortby")]
		public string SortBy
		{	
			get { return GetAttributeValue<string>("msdyn_sortby"); }
			set
			{ 
				if(value == SortBy) return;
				SetAttributeValue("msdyn_sortby", value);
			}
		}	
			
		/// <summary>
        /// msdyn_timestamp
        /// </summary>
		[DisplayName("Time stamp")]
		[AttributeLogicalName("msdyn_timestamp")]
		public DateTime? TimeStamp
		{	
			get { return GetAttributeValue<DateTime?>("msdyn_timestamp"); }
			set
			{ 
				if(value == TimeStamp) return;
				SetAttributeValue("msdyn_timestamp", value);
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
        /// 1:N Get entities for 'msdyn_knowledgesearchinsight_AsyncOperations'
        /// </summary>
		[RelationshipSchemaName("msdyn_knowledgesearchinsight_AsyncOperations")]
		public IEnumerable<SystemJob> MsdynKnowledgesearchinsightAsyncOperations
		{
			get { return GetRelatedEntities<SystemJob>("msdyn_knowledgesearchinsight_AsyncOperations", null); }
			set { SetRelatedEntities("msdyn_knowledgesearchinsight_AsyncOperations", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'msdyn_knowledgesearchinsight_BulkDeleteFailures'
        /// </summary>
		[RelationshipSchemaName("msdyn_knowledgesearchinsight_BulkDeleteFailures")]
		public IEnumerable<BulkDeleteFailure> MsdynKnowledgesearchinsightBulkDeleteFailures
		{
			get { return GetRelatedEntities<BulkDeleteFailure>("msdyn_knowledgesearchinsight_BulkDeleteFailures", null); }
			set { SetRelatedEntities("msdyn_knowledgesearchinsight_BulkDeleteFailures", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'msdyn_knowledgesearchinsight_DuplicateBaseRecord'
        /// </summary>
		[RelationshipSchemaName("msdyn_knowledgesearchinsight_DuplicateBaseRecord")]
		public IEnumerable<DuplicateRecord> MsdynKnowledgesearchinsightDuplicateBaseRecord
		{
			get { return GetRelatedEntities<DuplicateRecord>("msdyn_knowledgesearchinsight_DuplicateBaseRecord", null); }
			set { SetRelatedEntities("msdyn_knowledgesearchinsight_DuplicateBaseRecord", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'msdyn_knowledgesearchinsight_DuplicateMatchingRecord'
        /// </summary>
		[RelationshipSchemaName("msdyn_knowledgesearchinsight_DuplicateMatchingRecord")]
		public IEnumerable<DuplicateRecord> MsdynKnowledgesearchinsightDuplicateMatchingRecord
		{
			get { return GetRelatedEntities<DuplicateRecord>("msdyn_knowledgesearchinsight_DuplicateMatchingRecord", null); }
			set { SetRelatedEntities("msdyn_knowledgesearchinsight_DuplicateMatchingRecord", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'msdyn_knowledgesearchinsight_MailboxTrackingFolders'
        /// </summary>
		[RelationshipSchemaName("msdyn_knowledgesearchinsight_MailboxTrackingFolders")]
		public IEnumerable<MailboxAutoTrackingFolder> MsdynKnowledgesearchinsightMailboxTrackingFolders
		{
			get { return GetRelatedEntities<MailboxAutoTrackingFolder>("msdyn_knowledgesearchinsight_MailboxTrackingFolders", null); }
			set { SetRelatedEntities("msdyn_knowledgesearchinsight_MailboxTrackingFolders", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'msdyn_knowledgesearchinsight_PrincipalObjectAttributeAccesses'
        /// </summary>
		[RelationshipSchemaName("msdyn_knowledgesearchinsight_PrincipalObjectAttributeAccesses")]
		public IEnumerable<FieldSharing> MsdynKnowledgesearchinsightPrincipalObjectAttributeAccesses
		{
			get { return GetRelatedEntities<FieldSharing>("msdyn_knowledgesearchinsight_PrincipalObjectAttributeAccesses", null); }
			set { SetRelatedEntities("msdyn_knowledgesearchinsight_PrincipalObjectAttributeAccesses", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'msdyn_knowledgesearchinsight_ProcessSession'
        /// </summary>
		[RelationshipSchemaName("msdyn_knowledgesearchinsight_ProcessSession")]
		public IEnumerable<ProcessSession> MsdynKnowledgesearchinsightProcessSession
		{
			get { return GetRelatedEntities<ProcessSession>("msdyn_knowledgesearchinsight_ProcessSession", null); }
			set { SetRelatedEntities("msdyn_knowledgesearchinsight_ProcessSession", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'msdyn_knowledgesearchinsight_SyncErrors'
        /// </summary>
		[RelationshipSchemaName("msdyn_knowledgesearchinsight_SyncErrors")]
		public IEnumerable<SyncError> MsdynKnowledgesearchinsightSyncErrors
		{
			get { return GetRelatedEntities<SyncError>("msdyn_knowledgesearchinsight_SyncErrors", null); }
			set { SetRelatedEntities("msdyn_knowledgesearchinsight_SyncErrors", null, value); }
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

			/// <summary>msdyn_applicationname</summary>
			public const string ApplicationName = "msdyn_applicationname";

			/// <summary>msdyn_correlationid</summary>
			public const string CorrelationID = "msdyn_correlationid";

			/// <summary>msdyn_customcontrolid</summary>
			public const string CustomControlID = "msdyn_customcontrolid";

			/// <summary>msdyn_entityrecordid</summary>
			public const string EntityRecordID = "msdyn_entityrecordid";

			/// <summary>msdyn_entitytype</summary>
			public const string EntityType = "msdyn_entitytype";

			/// <summary>msdyn_filters</summary>
			public const string Filters = "msdyn_filters";

			/// <summary>msdyn_initiatedby</summary>
			public const string InitiatedBy = "msdyn_initiatedby";

			/// <summary>msdyn_knowledgesearchinsightid</summary>
			public const string KnowledgeSearchInsightId = "msdyn_knowledgesearchinsightid";

			/// <summary>msdyn_responsetime</summary>
			public const string ResponseTime = "msdyn_responsetime";

			/// <summary>msdyn_resultcount</summary>
			public const string ResultCount = "msdyn_resultcount";

			/// <summary>msdyn_searchproviderid</summary>
			public const string SearchProviderID = "msdyn_searchproviderid";

			/// <summary>msdyn_searchprovidername</summary>
			public const string SearchProviderName = "msdyn_searchprovidername";

			/// <summary>msdyn_searchterm</summary>
			public const string SearchTerm = "msdyn_searchterm";

			/// <summary>msdyn_searchtype</summary>
			public const string SearchType = "msdyn_searchtype";

			/// <summary>msdyn_sortby</summary>
			public const string SortBy = "msdyn_sortby";

			/// <summary>msdyn_timestamp</summary>
			public const string TimeStamp = "msdyn_timestamp";

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
			/// <summary>1:N msdyn_knowledgesearchinsight_AsyncOperations</summary>
			public const string MsdynKnowledgesearchinsightAsyncOperations = "msdyn_knowledgesearchinsight_AsyncOperations";

			/// <summary>1:N msdyn_knowledgesearchinsight_BulkDeleteFailures</summary>
			public const string MsdynKnowledgesearchinsightBulkDeleteFailures = "msdyn_knowledgesearchinsight_BulkDeleteFailures";

			/// <summary>1:N msdyn_knowledgesearchinsight_DuplicateBaseRecord</summary>
			public const string MsdynKnowledgesearchinsightDuplicateBaseRecord = "msdyn_knowledgesearchinsight_DuplicateBaseRecord";

			/// <summary>1:N msdyn_knowledgesearchinsight_DuplicateMatchingRecord</summary>
			public const string MsdynKnowledgesearchinsightDuplicateMatchingRecord = "msdyn_knowledgesearchinsight_DuplicateMatchingRecord";

			/// <summary>1:N msdyn_knowledgesearchinsight_MailboxTrackingFolders</summary>
			public const string MsdynKnowledgesearchinsightMailboxTrackingFolders = "msdyn_knowledgesearchinsight_MailboxTrackingFolders";

			/// <summary>1:N msdyn_knowledgesearchinsight_PrincipalObjectAttributeAccesses</summary>
			public const string MsdynKnowledgesearchinsightPrincipalObjectAttributeAccesses = "msdyn_knowledgesearchinsight_PrincipalObjectAttributeAccesses";

			/// <summary>1:N msdyn_knowledgesearchinsight_ProcessSession</summary>
			public const string MsdynKnowledgesearchinsightProcessSession = "msdyn_knowledgesearchinsight_ProcessSession";

			/// <summary>1:N msdyn_knowledgesearchinsight_SyncErrors</summary>
			public const string MsdynKnowledgesearchinsightSyncErrors = "msdyn_knowledgesearchinsight_SyncErrors";

		}
		#endregion
	}
}

