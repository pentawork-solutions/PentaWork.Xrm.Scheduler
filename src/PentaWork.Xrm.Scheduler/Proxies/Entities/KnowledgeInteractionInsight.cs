using System;
using System.Linq;
using System.Diagnostics;
using System.ComponentModel;
using Microsoft.Xrm.Sdk; 
using Microsoft.Xrm.Sdk.Client;
using System.Collections.Generic;

namespace PentaWork.Xrm.Scheduler.Proxies.Entities
{
	[DebuggerDisplay("{InteractionType}")] 	
	[EntityLogicalName("msdyn_knowledgeinteractioninsight")]
	public sealed class KnowledgeInteractionInsight : Entity
	{	
		public static readonly int? EntityTypeCode = 10045;
		public new const string LogicalName = "msdyn_knowledgeinteractioninsight";
		public const string PrimaryIdAttribute = "msdyn_knowledgeinteractioninsightid";
		public const string PrimaryNameAttribute = "msdyn_interactiontype";
	
		public KnowledgeInteractionInsight() : base("msdyn_knowledgeinteractioninsight") { }

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
        /// msdyn_articlerank
        /// </summary>
		[DisplayName("Article rank")]
		[AttributeLogicalName("msdyn_articlerank")]
		public int? ArticleRank
		{	
			get { return GetAttributeValue<int?>("msdyn_articlerank"); }
			set
			{ 
				if(value == ArticleRank) return;
				SetAttributeValue("msdyn_articlerank", value);
			}
		}	
			
		/// <summary>
        /// msdyn_articlerecordid
        /// </summary>
		[DisplayName("Article Record ID")]
		[AttributeLogicalName("msdyn_articlerecordid")]
		public string ArticleRecordID
		{	
			get { return GetAttributeValue<string>("msdyn_articlerecordid"); }
			set
			{ 
				if(value == ArticleRecordID) return;
				SetAttributeValue("msdyn_articlerecordid", value);
			}
		}	
			
		/// <summary>
        /// msdyn_articlerelevance
		///
		/// Precision: 2
		/// MaxValue: 1000000000
		/// MinValue: -1000000000
        /// </summary>
		[DisplayName("Article relevance")]
		[AttributeLogicalName("msdyn_articlerelevance")]
		public double? ArticleRelevance
		{	
			get { return GetAttributeValue<double?>("msdyn_articlerelevance"); }
			set 
			{
				double? doubleValue = null;
				if(value != null) doubleValue = Math.Round(value.Value, 2);
				if(doubleValue == ArticleRelevance) return;
				SetAttributeValue("msdyn_articlerelevance", doubleValue);  
			}
		}

		/// <summary>
        /// msdyn_interactioncontext
        /// </summary>
		[DisplayName("Interaction context")]
		[AttributeLogicalName("msdyn_interactioncontext")]
		public string InteractionContext
		{	
			get { return GetAttributeValue<string>("msdyn_interactioncontext"); }
			set
			{ 
				if(value == InteractionContext) return;
				SetAttributeValue("msdyn_interactioncontext", value);
			}
		}	
			
		/// <summary>
        /// msdyn_interactiontype
        /// </summary>
		[DisplayName("Interaction type")]
		[AttributeLogicalName("msdyn_interactiontype")]
		public string InteractionType
		{	
			get { return GetAttributeValue<string>("msdyn_interactiontype"); }
			set
			{ 
				if(value == InteractionType) return;
				SetAttributeValue("msdyn_interactiontype", value);
			}
		}	
			
		/// <summary>
        /// msdyn_knowledgeinteractioninsightid
        /// </summary>
		[DisplayName("Knowledge Interaction Insight ID")]
		[AttributeLogicalName("msdyn_knowledgeinteractioninsightid")]
		public override Guid Id
		{
			get => base.Id;
			set { base.Id = value; SetAttributeValue("msdyn_knowledgeinteractioninsightid", value); }
		}

							/// <summary>
        /// msdyn_knowledgeoperationid
        /// </summary>
		[DisplayName("Knowledge Operation ID")]
		[AttributeLogicalName("msdyn_knowledgeoperationid")]
		public string KnowledgeOperationID
		{	
			get { return GetAttributeValue<string>("msdyn_knowledgeoperationid"); }
			set
			{ 
				if(value == KnowledgeOperationID) return;
				SetAttributeValue("msdyn_knowledgeoperationid", value);
			}
		}	
			
		/// <summary>
        /// msdyn_knowledgeoperationtype
        /// </summary>
		[DisplayName("Knowledge Operation Type")]
		[AttributeLogicalName("msdyn_knowledgeoperationtype")]
		public string KnowledgeOperationType
		{	
			get { return GetAttributeValue<string>("msdyn_knowledgeoperationtype"); }
			set
			{ 
				if(value == KnowledgeOperationType) return;
				SetAttributeValue("msdyn_knowledgeoperationtype", value);
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
        /// 1:N Get entities for 'msdyn_knowledgeinteractioninsight_AsyncOperations'
        /// </summary>
		[RelationshipSchemaName("msdyn_knowledgeinteractioninsight_AsyncOperations")]
		public IEnumerable<SystemJob> MsdynKnowledgeinteractioninsightAsyncOperations
		{
			get { return GetRelatedEntities<SystemJob>("msdyn_knowledgeinteractioninsight_AsyncOperations", null); }
			set { SetRelatedEntities("msdyn_knowledgeinteractioninsight_AsyncOperations", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'msdyn_knowledgeinteractioninsight_BulkDeleteFailures'
        /// </summary>
		[RelationshipSchemaName("msdyn_knowledgeinteractioninsight_BulkDeleteFailures")]
		public IEnumerable<BulkDeleteFailure> MsdynKnowledgeinteractioninsightBulkDeleteFailures
		{
			get { return GetRelatedEntities<BulkDeleteFailure>("msdyn_knowledgeinteractioninsight_BulkDeleteFailures", null); }
			set { SetRelatedEntities("msdyn_knowledgeinteractioninsight_BulkDeleteFailures", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'msdyn_knowledgeinteractioninsight_DuplicateBaseRecord'
        /// </summary>
		[RelationshipSchemaName("msdyn_knowledgeinteractioninsight_DuplicateBaseRecord")]
		public IEnumerable<DuplicateRecord> MsdynKnowledgeinteractioninsightDuplicateBaseRecord
		{
			get { return GetRelatedEntities<DuplicateRecord>("msdyn_knowledgeinteractioninsight_DuplicateBaseRecord", null); }
			set { SetRelatedEntities("msdyn_knowledgeinteractioninsight_DuplicateBaseRecord", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'msdyn_knowledgeinteractioninsight_DuplicateMatchingRecord'
        /// </summary>
		[RelationshipSchemaName("msdyn_knowledgeinteractioninsight_DuplicateMatchingRecord")]
		public IEnumerable<DuplicateRecord> MsdynKnowledgeinteractioninsightDuplicateMatchingRecord
		{
			get { return GetRelatedEntities<DuplicateRecord>("msdyn_knowledgeinteractioninsight_DuplicateMatchingRecord", null); }
			set { SetRelatedEntities("msdyn_knowledgeinteractioninsight_DuplicateMatchingRecord", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'msdyn_knowledgeinteractioninsight_MailboxTrackingFolders'
        /// </summary>
		[RelationshipSchemaName("msdyn_knowledgeinteractioninsight_MailboxTrackingFolders")]
		public IEnumerable<MailboxAutoTrackingFolder> MsdynKnowledgeinteractioninsightMailboxTrackingFolders
		{
			get { return GetRelatedEntities<MailboxAutoTrackingFolder>("msdyn_knowledgeinteractioninsight_MailboxTrackingFolders", null); }
			set { SetRelatedEntities("msdyn_knowledgeinteractioninsight_MailboxTrackingFolders", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'msdyn_knowledgeinteractioninsight_PrincipalObjectAttributeAccesses'
        /// </summary>
		[RelationshipSchemaName("msdyn_knowledgeinteractioninsight_PrincipalObjectAttributeAccesses")]
		public IEnumerable<FieldSharing> MsdynKnowledgeinteractioninsightPrincipalObjectAttributeAccesses
		{
			get { return GetRelatedEntities<FieldSharing>("msdyn_knowledgeinteractioninsight_PrincipalObjectAttributeAccesses", null); }
			set { SetRelatedEntities("msdyn_knowledgeinteractioninsight_PrincipalObjectAttributeAccesses", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'msdyn_knowledgeinteractioninsight_ProcessSession'
        /// </summary>
		[RelationshipSchemaName("msdyn_knowledgeinteractioninsight_ProcessSession")]
		public IEnumerable<ProcessSession> MsdynKnowledgeinteractioninsightProcessSession
		{
			get { return GetRelatedEntities<ProcessSession>("msdyn_knowledgeinteractioninsight_ProcessSession", null); }
			set { SetRelatedEntities("msdyn_knowledgeinteractioninsight_ProcessSession", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'msdyn_knowledgeinteractioninsight_SyncErrors'
        /// </summary>
		[RelationshipSchemaName("msdyn_knowledgeinteractioninsight_SyncErrors")]
		public IEnumerable<SyncError> MsdynKnowledgeinteractioninsightSyncErrors
		{
			get { return GetRelatedEntities<SyncError>("msdyn_knowledgeinteractioninsight_SyncErrors", null); }
			set { SetRelatedEntities("msdyn_knowledgeinteractioninsight_SyncErrors", null, value); }
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

			/// <summary>msdyn_articlerank</summary>
			public const string ArticleRank = "msdyn_articlerank";

			/// <summary>msdyn_articlerecordid</summary>
			public const string ArticleRecordID = "msdyn_articlerecordid";

			/// <summary>msdyn_articlerelevance</summary>
			public const string ArticleRelevance = "msdyn_articlerelevance";

			/// <summary>msdyn_interactioncontext</summary>
			public const string InteractionContext = "msdyn_interactioncontext";

			/// <summary>msdyn_interactiontype</summary>
			public const string InteractionType = "msdyn_interactiontype";

			/// <summary>msdyn_knowledgeinteractioninsightid</summary>
			public const string KnowledgeInteractionInsightId = "msdyn_knowledgeinteractioninsightid";

			/// <summary>msdyn_knowledgeoperationid</summary>
			public const string KnowledgeOperationID = "msdyn_knowledgeoperationid";

			/// <summary>msdyn_knowledgeoperationtype</summary>
			public const string KnowledgeOperationType = "msdyn_knowledgeoperationtype";

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
			/// <summary>1:N msdyn_knowledgeinteractioninsight_AsyncOperations</summary>
			public const string MsdynKnowledgeinteractioninsightAsyncOperations = "msdyn_knowledgeinteractioninsight_AsyncOperations";

			/// <summary>1:N msdyn_knowledgeinteractioninsight_BulkDeleteFailures</summary>
			public const string MsdynKnowledgeinteractioninsightBulkDeleteFailures = "msdyn_knowledgeinteractioninsight_BulkDeleteFailures";

			/// <summary>1:N msdyn_knowledgeinteractioninsight_DuplicateBaseRecord</summary>
			public const string MsdynKnowledgeinteractioninsightDuplicateBaseRecord = "msdyn_knowledgeinteractioninsight_DuplicateBaseRecord";

			/// <summary>1:N msdyn_knowledgeinteractioninsight_DuplicateMatchingRecord</summary>
			public const string MsdynKnowledgeinteractioninsightDuplicateMatchingRecord = "msdyn_knowledgeinteractioninsight_DuplicateMatchingRecord";

			/// <summary>1:N msdyn_knowledgeinteractioninsight_MailboxTrackingFolders</summary>
			public const string MsdynKnowledgeinteractioninsightMailboxTrackingFolders = "msdyn_knowledgeinteractioninsight_MailboxTrackingFolders";

			/// <summary>1:N msdyn_knowledgeinteractioninsight_PrincipalObjectAttributeAccesses</summary>
			public const string MsdynKnowledgeinteractioninsightPrincipalObjectAttributeAccesses = "msdyn_knowledgeinteractioninsight_PrincipalObjectAttributeAccesses";

			/// <summary>1:N msdyn_knowledgeinteractioninsight_ProcessSession</summary>
			public const string MsdynKnowledgeinteractioninsightProcessSession = "msdyn_knowledgeinteractioninsight_ProcessSession";

			/// <summary>1:N msdyn_knowledgeinteractioninsight_SyncErrors</summary>
			public const string MsdynKnowledgeinteractioninsightSyncErrors = "msdyn_knowledgeinteractioninsight_SyncErrors";

		}
		#endregion
	}
}

