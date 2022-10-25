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
	[EntityLogicalName("msdyn_aibdatasetscontainer")]
	public sealed class AIBuilderDatasetsContainer : Entity
	{	
		public static readonly int? EntityTypeCode = 10057;
		public new const string LogicalName = "msdyn_aibdatasetscontainer";
		public const string PrimaryIdAttribute = "msdyn_aibdatasetscontainerid";
		public const string PrimaryNameAttribute = "msdyn_name";
	
		public AIBuilderDatasetsContainer() : base("msdyn_aibdatasetscontainer") { }

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
        /// msdyn_aibdatasetscontainerid
        /// </summary>
		[DisplayName("AI Builder Datasets Container")]
		[AttributeLogicalName("msdyn_aibdatasetscontainerid")]
		public override Guid Id
		{
			get => base.Id;
			set { base.Id = value; SetAttributeValue("msdyn_aibdatasetscontainerid", value); }
		}

							/// <summary>
        /// msdyn_aimodelid
        /// </summary>
		[DisplayName("AI Model")]
		[AttributeLogicalName("msdyn_aimodelid")]
		public EntityReference AIModel
		{	
			get { return GetAttributeValue<EntityReference>("msdyn_aimodelid"); }
			set
			{ 
				if(value == AIModel) return;
				SetAttributeValue("msdyn_aimodelid", value);
			}
		}	
			
		/// <summary>
        /// msdyn_aimodelidname
        /// </summary>
		[DisplayName("msdyn_aimodelidname")]
		[AttributeLogicalName("msdyn_aimodelidname")]
		public string MsdynAimodelidname
		{	
			get { return GetAttributeValue<string>("msdyn_aimodelidname"); }
			set
			{ 
				if(value == MsdynAimodelidname) return;
				SetAttributeValue("msdyn_aimodelidname", value);
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
        /// 1:N Get entities for 'msdyn_AIBDataset_msdyn_AIBDatasetsContain'
        /// </summary>
		[RelationshipSchemaName("msdyn_AIBDataset_msdyn_AIBDatasetsContain")]
		public IEnumerable<AIBuilderDataset> MsdynAIBDatasetMsdynAIBDatasetsContain
		{
			get { return GetRelatedEntities<AIBuilderDataset>("msdyn_AIBDataset_msdyn_AIBDatasetsContain", null); }
			set { SetRelatedEntities("msdyn_AIBDataset_msdyn_AIBDatasetsContain", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'msdyn_aibdatasetscontainer_AsyncOperations'
        /// </summary>
		[RelationshipSchemaName("msdyn_aibdatasetscontainer_AsyncOperations")]
		public IEnumerable<SystemJob> MsdynAibdatasetscontainerAsyncOperations
		{
			get { return GetRelatedEntities<SystemJob>("msdyn_aibdatasetscontainer_AsyncOperations", null); }
			set { SetRelatedEntities("msdyn_aibdatasetscontainer_AsyncOperations", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'msdyn_aibdatasetscontainer_BulkDeleteFailures'
        /// </summary>
		[RelationshipSchemaName("msdyn_aibdatasetscontainer_BulkDeleteFailures")]
		public IEnumerable<BulkDeleteFailure> MsdynAibdatasetscontainerBulkDeleteFailures
		{
			get { return GetRelatedEntities<BulkDeleteFailure>("msdyn_aibdatasetscontainer_BulkDeleteFailures", null); }
			set { SetRelatedEntities("msdyn_aibdatasetscontainer_BulkDeleteFailures", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'msdyn_aibdatasetscontainer_DuplicateBaseRecord'
        /// </summary>
		[RelationshipSchemaName("msdyn_aibdatasetscontainer_DuplicateBaseRecord")]
		public IEnumerable<DuplicateRecord> MsdynAibdatasetscontainerDuplicateBaseRecord
		{
			get { return GetRelatedEntities<DuplicateRecord>("msdyn_aibdatasetscontainer_DuplicateBaseRecord", null); }
			set { SetRelatedEntities("msdyn_aibdatasetscontainer_DuplicateBaseRecord", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'msdyn_aibdatasetscontainer_DuplicateMatchingRecord'
        /// </summary>
		[RelationshipSchemaName("msdyn_aibdatasetscontainer_DuplicateMatchingRecord")]
		public IEnumerable<DuplicateRecord> MsdynAibdatasetscontainerDuplicateMatchingRecord
		{
			get { return GetRelatedEntities<DuplicateRecord>("msdyn_aibdatasetscontainer_DuplicateMatchingRecord", null); }
			set { SetRelatedEntities("msdyn_aibdatasetscontainer_DuplicateMatchingRecord", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'msdyn_aibdatasetscontainer_MailboxTrackingFolders'
        /// </summary>
		[RelationshipSchemaName("msdyn_aibdatasetscontainer_MailboxTrackingFolders")]
		public IEnumerable<MailboxAutoTrackingFolder> MsdynAibdatasetscontainerMailboxTrackingFolders
		{
			get { return GetRelatedEntities<MailboxAutoTrackingFolder>("msdyn_aibdatasetscontainer_MailboxTrackingFolders", null); }
			set { SetRelatedEntities("msdyn_aibdatasetscontainer_MailboxTrackingFolders", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'msdyn_aibdatasetscontainer_PrincipalObjectAttributeAccesses'
        /// </summary>
		[RelationshipSchemaName("msdyn_aibdatasetscontainer_PrincipalObjectAttributeAccesses")]
		public IEnumerable<FieldSharing> MsdynAibdatasetscontainerPrincipalObjectAttributeAccesses
		{
			get { return GetRelatedEntities<FieldSharing>("msdyn_aibdatasetscontainer_PrincipalObjectAttributeAccesses", null); }
			set { SetRelatedEntities("msdyn_aibdatasetscontainer_PrincipalObjectAttributeAccesses", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'msdyn_aibdatasetscontainer_ProcessSession'
        /// </summary>
		[RelationshipSchemaName("msdyn_aibdatasetscontainer_ProcessSession")]
		public IEnumerable<ProcessSession> MsdynAibdatasetscontainerProcessSession
		{
			get { return GetRelatedEntities<ProcessSession>("msdyn_aibdatasetscontainer_ProcessSession", null); }
			set { SetRelatedEntities("msdyn_aibdatasetscontainer_ProcessSession", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'msdyn_aibdatasetscontainer_SyncErrors'
        /// </summary>
		[RelationshipSchemaName("msdyn_aibdatasetscontainer_SyncErrors")]
		public IEnumerable<SyncError> MsdynAibdatasetscontainerSyncErrors
		{
			get { return GetRelatedEntities<SyncError>("msdyn_aibdatasetscontainer_SyncErrors", null); }
			set { SetRelatedEntities("msdyn_aibdatasetscontainer_SyncErrors", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'msdyn_AIBFile_msdyn_AIBDatasetsCont'
        /// </summary>
		[RelationshipSchemaName("msdyn_AIBFile_msdyn_AIBDatasetsCont")]
		public IEnumerable<AIBuilderFile> MsdynAIBFileMsdynAIBDatasetsCont
		{
			get { return GetRelatedEntities<AIBuilderFile>("msdyn_AIBFile_msdyn_AIBDatasetsCont", null); }
			set { SetRelatedEntities("msdyn_AIBFile_msdyn_AIBDatasetsCont", null, value); }
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

			/// <summary>msdyn_aibdatasetscontainerid</summary>
			public const string AIBuilderDatasetsContainerId = "msdyn_aibdatasetscontainerid";

			/// <summary>msdyn_aimodelid</summary>
			public const string AIModel = "msdyn_aimodelid";

			/// <summary>msdyn_aimodelidname</summary>
			public const string MsdynAimodelidname = "msdyn_aimodelidname";

			/// <summary>msdyn_name</summary>
			public const string Name = "msdyn_name";

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
			/// <summary>1:N msdyn_AIBDataset_msdyn_AIBDatasetsContain</summary>
			public const string MsdynAIBDatasetMsdynAIBDatasetsContain = "msdyn_AIBDataset_msdyn_AIBDatasetsContain";

			/// <summary>1:N msdyn_aibdatasetscontainer_AsyncOperations</summary>
			public const string MsdynAibdatasetscontainerAsyncOperations = "msdyn_aibdatasetscontainer_AsyncOperations";

			/// <summary>1:N msdyn_aibdatasetscontainer_BulkDeleteFailures</summary>
			public const string MsdynAibdatasetscontainerBulkDeleteFailures = "msdyn_aibdatasetscontainer_BulkDeleteFailures";

			/// <summary>1:N msdyn_aibdatasetscontainer_DuplicateBaseRecord</summary>
			public const string MsdynAibdatasetscontainerDuplicateBaseRecord = "msdyn_aibdatasetscontainer_DuplicateBaseRecord";

			/// <summary>1:N msdyn_aibdatasetscontainer_DuplicateMatchingRecord</summary>
			public const string MsdynAibdatasetscontainerDuplicateMatchingRecord = "msdyn_aibdatasetscontainer_DuplicateMatchingRecord";

			/// <summary>1:N msdyn_aibdatasetscontainer_MailboxTrackingFolders</summary>
			public const string MsdynAibdatasetscontainerMailboxTrackingFolders = "msdyn_aibdatasetscontainer_MailboxTrackingFolders";

			/// <summary>1:N msdyn_aibdatasetscontainer_PrincipalObjectAttributeAccesses</summary>
			public const string MsdynAibdatasetscontainerPrincipalObjectAttributeAccesses = "msdyn_aibdatasetscontainer_PrincipalObjectAttributeAccesses";

			/// <summary>1:N msdyn_aibdatasetscontainer_ProcessSession</summary>
			public const string MsdynAibdatasetscontainerProcessSession = "msdyn_aibdatasetscontainer_ProcessSession";

			/// <summary>1:N msdyn_aibdatasetscontainer_SyncErrors</summary>
			public const string MsdynAibdatasetscontainerSyncErrors = "msdyn_aibdatasetscontainer_SyncErrors";

			/// <summary>1:N msdyn_AIBFile_msdyn_AIBDatasetsCont</summary>
			public const string MsdynAIBFileMsdynAIBDatasetsCont = "msdyn_AIBFile_msdyn_AIBDatasetsCont";

		}
		#endregion
	}
}

