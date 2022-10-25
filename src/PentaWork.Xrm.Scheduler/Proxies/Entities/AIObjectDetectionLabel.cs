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
	[EntityLogicalName("msdyn_aiodlabel")]
	public sealed class AIObjectDetectionLabel : Entity
	{	
		public static readonly int? EntityTypeCode = 10062;
		public new const string LogicalName = "msdyn_aiodlabel";
		public const string PrimaryIdAttribute = "msdyn_aiodlabelid";
		public const string PrimaryNameAttribute = "msdyn_name";
	
		public AIObjectDetectionLabel() : base("msdyn_aiodlabel") { }

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
        /// msdyn_aiodlabelid
        /// </summary>
		[DisplayName("Label")]
		[AttributeLogicalName("msdyn_aiodlabelid")]
		public override Guid Id
		{
			get => base.Id;
			set { base.Id = value; SetAttributeValue("msdyn_aiodlabelid", value); }
		}

							/// <summary>
        /// msdyn_labelstring
        /// </summary>
		[DisplayName("Label:String")]
		[AttributeLogicalName("msdyn_labelstring")]
		public string LabelString
		{	
			get { return GetAttributeValue<string>("msdyn_labelstring"); }
			set
			{ 
				if(value == LabelString) return;
				SetAttributeValue("msdyn_labelstring", value);
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
        /// msdyn_sourceattributelogicalname
        /// </summary>
		[DisplayName("Source Attribute Logical Name")]
		[AttributeLogicalName("msdyn_sourceattributelogicalname")]
		public string SourceAttributeLogicalName
		{	
			get { return GetAttributeValue<string>("msdyn_sourceattributelogicalname"); }
			set
			{ 
				if(value == SourceAttributeLogicalName) return;
				SetAttributeValue("msdyn_sourceattributelogicalname", value);
			}
		}	
			
		/// <summary>
        /// msdyn_sourceentitysetname
        /// </summary>
		[DisplayName("Source Entity Logical Collection Name")]
		[AttributeLogicalName("msdyn_sourceentitysetname")]
		public string SourceEntityLogicalCollectionName
		{	
			get { return GetAttributeValue<string>("msdyn_sourceentitysetname"); }
			set
			{ 
				if(value == SourceEntityLogicalCollectionName) return;
				SetAttributeValue("msdyn_sourceentitysetname", value);
			}
		}	
			
		/// <summary>
        /// msdyn_sourcerecordid
        /// </summary>
		[DisplayName("Source Record Id")]
		[AttributeLogicalName("msdyn_sourcerecordid")]
		public string SourceRecordId
		{	
			get { return GetAttributeValue<string>("msdyn_sourcerecordid"); }
			set
			{ 
				if(value == SourceRecordId) return;
				SetAttributeValue("msdyn_sourcerecordid", value);
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
        /// 1:N Get entities for 'msdyn_aiodlabel_AsyncOperations'
        /// </summary>
		[RelationshipSchemaName("msdyn_aiodlabel_AsyncOperations")]
		public IEnumerable<SystemJob> MsdynAiodlabelAsyncOperations
		{
			get { return GetRelatedEntities<SystemJob>("msdyn_aiodlabel_AsyncOperations", null); }
			set { SetRelatedEntities("msdyn_aiodlabel_AsyncOperations", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'msdyn_aiodlabel_BulkDeleteFailures'
        /// </summary>
		[RelationshipSchemaName("msdyn_aiodlabel_BulkDeleteFailures")]
		public IEnumerable<BulkDeleteFailure> MsdynAiodlabelBulkDeleteFailures
		{
			get { return GetRelatedEntities<BulkDeleteFailure>("msdyn_aiodlabel_BulkDeleteFailures", null); }
			set { SetRelatedEntities("msdyn_aiodlabel_BulkDeleteFailures", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'msdyn_aiodlabel_DuplicateBaseRecord'
        /// </summary>
		[RelationshipSchemaName("msdyn_aiodlabel_DuplicateBaseRecord")]
		public IEnumerable<DuplicateRecord> MsdynAiodlabelDuplicateBaseRecord
		{
			get { return GetRelatedEntities<DuplicateRecord>("msdyn_aiodlabel_DuplicateBaseRecord", null); }
			set { SetRelatedEntities("msdyn_aiodlabel_DuplicateBaseRecord", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'msdyn_aiodlabel_DuplicateMatchingRecord'
        /// </summary>
		[RelationshipSchemaName("msdyn_aiodlabel_DuplicateMatchingRecord")]
		public IEnumerable<DuplicateRecord> MsdynAiodlabelDuplicateMatchingRecord
		{
			get { return GetRelatedEntities<DuplicateRecord>("msdyn_aiodlabel_DuplicateMatchingRecord", null); }
			set { SetRelatedEntities("msdyn_aiodlabel_DuplicateMatchingRecord", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'msdyn_aiodlabel_MailboxTrackingFolders'
        /// </summary>
		[RelationshipSchemaName("msdyn_aiodlabel_MailboxTrackingFolders")]
		public IEnumerable<MailboxAutoTrackingFolder> MsdynAiodlabelMailboxTrackingFolders
		{
			get { return GetRelatedEntities<MailboxAutoTrackingFolder>("msdyn_aiodlabel_MailboxTrackingFolders", null); }
			set { SetRelatedEntities("msdyn_aiodlabel_MailboxTrackingFolders", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'msdyn_aiodlabel_msdyn_aiodtrainingboundingbox'
        /// </summary>
		[RelationshipSchemaName("msdyn_aiodlabel_msdyn_aiodtrainingboundingbox")]
		public IEnumerable<AIObjectDetectionBoundingBox> MsdynAiodlabelMsdynAiodtrainingboundingbox
		{
			get { return GetRelatedEntities<AIObjectDetectionBoundingBox>("msdyn_aiodlabel_msdyn_aiodtrainingboundingbox", null); }
			set { SetRelatedEntities("msdyn_aiodlabel_msdyn_aiodtrainingboundingbox", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'msdyn_aiodlabel_PrincipalObjectAttributeAccesses'
        /// </summary>
		[RelationshipSchemaName("msdyn_aiodlabel_PrincipalObjectAttributeAccesses")]
		public IEnumerable<FieldSharing> MsdynAiodlabelPrincipalObjectAttributeAccesses
		{
			get { return GetRelatedEntities<FieldSharing>("msdyn_aiodlabel_PrincipalObjectAttributeAccesses", null); }
			set { SetRelatedEntities("msdyn_aiodlabel_PrincipalObjectAttributeAccesses", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'msdyn_aiodlabel_ProcessSession'
        /// </summary>
		[RelationshipSchemaName("msdyn_aiodlabel_ProcessSession")]
		public IEnumerable<ProcessSession> MsdynAiodlabelProcessSession
		{
			get { return GetRelatedEntities<ProcessSession>("msdyn_aiodlabel_ProcessSession", null); }
			set { SetRelatedEntities("msdyn_aiodlabel_ProcessSession", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'msdyn_aiodlabel_SyncErrors'
        /// </summary>
		[RelationshipSchemaName("msdyn_aiodlabel_SyncErrors")]
		public IEnumerable<SyncError> MsdynAiodlabelSyncErrors
		{
			get { return GetRelatedEntities<SyncError>("msdyn_aiodlabel_SyncErrors", null); }
			set { SetRelatedEntities("msdyn_aiodlabel_SyncErrors", null, value); }
		}
		/// <summary>
        /// N:N Get entities for 'AIConfiguration'
        /// </summary>
		[RelationshipSchemaName("msdyn_aiodlabel_msdyn_aiconfiguration")]
		public IEnumerable<AIConfiguration> MsdynAiodlabelMsdynAiconfiguration
		{
			get { return GetRelatedEntities<AIConfiguration>("msdyn_aiodlabel_msdyn_aiconfiguration", null); }
			set { SetRelatedEntities("msdyn_aiodlabel_msdyn_aiconfiguration", null, value); }
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

			/// <summary>msdyn_aiodlabelid</summary>
			public const string LabelId = "msdyn_aiodlabelid";

			/// <summary>msdyn_labelstring</summary>
			public const string LabelString = "msdyn_labelstring";

			/// <summary>msdyn_name</summary>
			public const string Name = "msdyn_name";

			/// <summary>msdyn_sourceattributelogicalname</summary>
			public const string SourceAttributeLogicalName = "msdyn_sourceattributelogicalname";

			/// <summary>msdyn_sourceentitysetname</summary>
			public const string SourceEntityLogicalCollectionName = "msdyn_sourceentitysetname";

			/// <summary>msdyn_sourcerecordid</summary>
			public const string SourceRecordId = "msdyn_sourcerecordid";

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
			/// <summary>1:N msdyn_aiodlabel_AsyncOperations</summary>
			public const string MsdynAiodlabelAsyncOperations = "msdyn_aiodlabel_AsyncOperations";

			/// <summary>1:N msdyn_aiodlabel_BulkDeleteFailures</summary>
			public const string MsdynAiodlabelBulkDeleteFailures = "msdyn_aiodlabel_BulkDeleteFailures";

			/// <summary>1:N msdyn_aiodlabel_DuplicateBaseRecord</summary>
			public const string MsdynAiodlabelDuplicateBaseRecord = "msdyn_aiodlabel_DuplicateBaseRecord";

			/// <summary>1:N msdyn_aiodlabel_DuplicateMatchingRecord</summary>
			public const string MsdynAiodlabelDuplicateMatchingRecord = "msdyn_aiodlabel_DuplicateMatchingRecord";

			/// <summary>1:N msdyn_aiodlabel_MailboxTrackingFolders</summary>
			public const string MsdynAiodlabelMailboxTrackingFolders = "msdyn_aiodlabel_MailboxTrackingFolders";

			/// <summary>1:N msdyn_aiodlabel_msdyn_aiodtrainingboundingbox</summary>
			public const string MsdynAiodlabelMsdynAiodtrainingboundingbox = "msdyn_aiodlabel_msdyn_aiodtrainingboundingbox";

			/// <summary>1:N msdyn_aiodlabel_PrincipalObjectAttributeAccesses</summary>
			public const string MsdynAiodlabelPrincipalObjectAttributeAccesses = "msdyn_aiodlabel_PrincipalObjectAttributeAccesses";

			/// <summary>1:N msdyn_aiodlabel_ProcessSession</summary>
			public const string MsdynAiodlabelProcessSession = "msdyn_aiodlabel_ProcessSession";

			/// <summary>1:N msdyn_aiodlabel_SyncErrors</summary>
			public const string MsdynAiodlabelSyncErrors = "msdyn_aiodlabel_SyncErrors";

			/// <summary>N:N msdyn_aiodlabel_msdyn_aiconfiguration</summary>
			public const string MsdynAiodlabelMsdynAiconfiguration = "msdyn_aiodlabel_msdyn_aiconfiguration";

		}
		#endregion
	}
}

