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
	[EntityLogicalName("msdyn_aibdatasetfile")]
	public sealed class AIBuilderDatasetFile : Entity
	{	
		public static readonly int? EntityTypeCode = 10055;
		public new const string LogicalName = "msdyn_aibdatasetfile";
		public const string PrimaryIdAttribute = "msdyn_aibdatasetfileid";
		public const string PrimaryNameAttribute = "msdyn_name";
	
		public AIBuilderDatasetFile() : base("msdyn_aibdatasetfile") { }

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
        /// msdyn_aibdatasetfileid
        /// </summary>
		[DisplayName("AI Builder Dataset File")]
		[AttributeLogicalName("msdyn_aibdatasetfileid")]
		public override Guid Id
		{
			get => base.Id;
			set { base.Id = value; SetAttributeValue("msdyn_aibdatasetfileid", value); }
		}

							/// <summary>
        /// msdyn_aibdatasetid
        /// </summary>
		[DisplayName("AI Builder Dataset")]
		[AttributeLogicalName("msdyn_aibdatasetid")]
		public EntityReference AIBuilderDataset
		{	
			get { return GetAttributeValue<EntityReference>("msdyn_aibdatasetid"); }
			set
			{ 
				if(value == AIBuilderDataset) return;
				SetAttributeValue("msdyn_aibdatasetid", value);
			}
		}	
			
		/// <summary>
        /// msdyn_aibdatasetidname
        /// </summary>
		[DisplayName("msdyn_aibdatasetidname")]
		[AttributeLogicalName("msdyn_aibdatasetidname")]
		public string MsdynAibdatasetidname
		{	
			get { return GetAttributeValue<string>("msdyn_aibdatasetidname"); }
			set
			{ 
				if(value == MsdynAibdatasetidname) return;
				SetAttributeValue("msdyn_aibdatasetidname", value);
			}
		}	
			
		/// <summary>
        /// msdyn_aibfileid
        /// </summary>
		[DisplayName("AI Builder File")]
		[AttributeLogicalName("msdyn_aibfileid")]
		public EntityReference AIBuilderFile
		{	
			get { return GetAttributeValue<EntityReference>("msdyn_aibfileid"); }
			set
			{ 
				if(value == AIBuilderFile) return;
				SetAttributeValue("msdyn_aibfileid", value);
			}
		}	
			
		/// <summary>
        /// msdyn_aibfileidname
        /// </summary>
		[DisplayName("msdyn_aibfileidname")]
		[AttributeLogicalName("msdyn_aibfileidname")]
		public string MsdynAibfileidname
		{	
			get { return GetAttributeValue<string>("msdyn_aibfileidname"); }
			set
			{ 
				if(value == MsdynAibfileidname) return;
				SetAttributeValue("msdyn_aibfileidname", value);
			}
		}	
			
		/// <summary>
        /// msdyn_lastmodifieddate
        /// </summary>
		[DisplayName("LastModifiedDate")]
		[AttributeLogicalName("msdyn_lastmodifieddate")]
		public DateTime? LastModifiedDate
		{	
			get { return GetAttributeValue<DateTime?>("msdyn_lastmodifieddate"); }
			set
			{ 
				if(value == LastModifiedDate) return;
				SetAttributeValue("msdyn_lastmodifieddate", value);
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
        /// 1:N Get entities for 'msdyn_aibdatasetfile_AsyncOperations'
        /// </summary>
		[RelationshipSchemaName("msdyn_aibdatasetfile_AsyncOperations")]
		public IEnumerable<SystemJob> MsdynAibdatasetfileAsyncOperations
		{
			get { return GetRelatedEntities<SystemJob>("msdyn_aibdatasetfile_AsyncOperations", null); }
			set { SetRelatedEntities("msdyn_aibdatasetfile_AsyncOperations", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'msdyn_aibdatasetfile_BulkDeleteFailures'
        /// </summary>
		[RelationshipSchemaName("msdyn_aibdatasetfile_BulkDeleteFailures")]
		public IEnumerable<BulkDeleteFailure> MsdynAibdatasetfileBulkDeleteFailures
		{
			get { return GetRelatedEntities<BulkDeleteFailure>("msdyn_aibdatasetfile_BulkDeleteFailures", null); }
			set { SetRelatedEntities("msdyn_aibdatasetfile_BulkDeleteFailures", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'msdyn_aibdatasetfile_DuplicateBaseRecord'
        /// </summary>
		[RelationshipSchemaName("msdyn_aibdatasetfile_DuplicateBaseRecord")]
		public IEnumerable<DuplicateRecord> MsdynAibdatasetfileDuplicateBaseRecord
		{
			get { return GetRelatedEntities<DuplicateRecord>("msdyn_aibdatasetfile_DuplicateBaseRecord", null); }
			set { SetRelatedEntities("msdyn_aibdatasetfile_DuplicateBaseRecord", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'msdyn_aibdatasetfile_DuplicateMatchingRecord'
        /// </summary>
		[RelationshipSchemaName("msdyn_aibdatasetfile_DuplicateMatchingRecord")]
		public IEnumerable<DuplicateRecord> MsdynAibdatasetfileDuplicateMatchingRecord
		{
			get { return GetRelatedEntities<DuplicateRecord>("msdyn_aibdatasetfile_DuplicateMatchingRecord", null); }
			set { SetRelatedEntities("msdyn_aibdatasetfile_DuplicateMatchingRecord", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'msdyn_aibdatasetfile_MailboxTrackingFolders'
        /// </summary>
		[RelationshipSchemaName("msdyn_aibdatasetfile_MailboxTrackingFolders")]
		public IEnumerable<MailboxAutoTrackingFolder> MsdynAibdatasetfileMailboxTrackingFolders
		{
			get { return GetRelatedEntities<MailboxAutoTrackingFolder>("msdyn_aibdatasetfile_MailboxTrackingFolders", null); }
			set { SetRelatedEntities("msdyn_aibdatasetfile_MailboxTrackingFolders", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'msdyn_aibdatasetfile_PrincipalObjectAttributeAccesses'
        /// </summary>
		[RelationshipSchemaName("msdyn_aibdatasetfile_PrincipalObjectAttributeAccesses")]
		public IEnumerable<FieldSharing> MsdynAibdatasetfilePrincipalObjectAttributeAccesses
		{
			get { return GetRelatedEntities<FieldSharing>("msdyn_aibdatasetfile_PrincipalObjectAttributeAccesses", null); }
			set { SetRelatedEntities("msdyn_aibdatasetfile_PrincipalObjectAttributeAccesses", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'msdyn_aibdatasetfile_ProcessSession'
        /// </summary>
		[RelationshipSchemaName("msdyn_aibdatasetfile_ProcessSession")]
		public IEnumerable<ProcessSession> MsdynAibdatasetfileProcessSession
		{
			get { return GetRelatedEntities<ProcessSession>("msdyn_aibdatasetfile_ProcessSession", null); }
			set { SetRelatedEntities("msdyn_aibdatasetfile_ProcessSession", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'msdyn_aibdatasetfile_SyncErrors'
        /// </summary>
		[RelationshipSchemaName("msdyn_aibdatasetfile_SyncErrors")]
		public IEnumerable<SyncError> MsdynAibdatasetfileSyncErrors
		{
			get { return GetRelatedEntities<SyncError>("msdyn_aibdatasetfile_SyncErrors", null); }
			set { SetRelatedEntities("msdyn_aibdatasetfile_SyncErrors", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'msdyn_AIBFileAttachedData_msdyn_AIB'
        /// </summary>
		[RelationshipSchemaName("msdyn_AIBFileAttachedData_msdyn_AIB")]
		public IEnumerable<AIBuilderFileAttachedData> MsdynAIBFileAttachedDataMsdynAIB
		{
			get { return GetRelatedEntities<AIBuilderFileAttachedData>("msdyn_AIBFileAttachedData_msdyn_AIB", null); }
			set { SetRelatedEntities("msdyn_AIBFileAttachedData_msdyn_AIB", null, value); }
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

			/// <summary>msdyn_aibdatasetfileid</summary>
			public const string AIBuilderDatasetFileId = "msdyn_aibdatasetfileid";

			/// <summary>msdyn_aibdatasetid</summary>
			public const string AIBuilderDataset = "msdyn_aibdatasetid";

			/// <summary>msdyn_aibdatasetidname</summary>
			public const string MsdynAibdatasetidname = "msdyn_aibdatasetidname";

			/// <summary>msdyn_aibfileid</summary>
			public const string AIBuilderFile = "msdyn_aibfileid";

			/// <summary>msdyn_aibfileidname</summary>
			public const string MsdynAibfileidname = "msdyn_aibfileidname";

			/// <summary>msdyn_lastmodifieddate</summary>
			public const string LastModifiedDate = "msdyn_lastmodifieddate";

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
			/// <summary>1:N msdyn_aibdatasetfile_AsyncOperations</summary>
			public const string MsdynAibdatasetfileAsyncOperations = "msdyn_aibdatasetfile_AsyncOperations";

			/// <summary>1:N msdyn_aibdatasetfile_BulkDeleteFailures</summary>
			public const string MsdynAibdatasetfileBulkDeleteFailures = "msdyn_aibdatasetfile_BulkDeleteFailures";

			/// <summary>1:N msdyn_aibdatasetfile_DuplicateBaseRecord</summary>
			public const string MsdynAibdatasetfileDuplicateBaseRecord = "msdyn_aibdatasetfile_DuplicateBaseRecord";

			/// <summary>1:N msdyn_aibdatasetfile_DuplicateMatchingRecord</summary>
			public const string MsdynAibdatasetfileDuplicateMatchingRecord = "msdyn_aibdatasetfile_DuplicateMatchingRecord";

			/// <summary>1:N msdyn_aibdatasetfile_MailboxTrackingFolders</summary>
			public const string MsdynAibdatasetfileMailboxTrackingFolders = "msdyn_aibdatasetfile_MailboxTrackingFolders";

			/// <summary>1:N msdyn_aibdatasetfile_PrincipalObjectAttributeAccesses</summary>
			public const string MsdynAibdatasetfilePrincipalObjectAttributeAccesses = "msdyn_aibdatasetfile_PrincipalObjectAttributeAccesses";

			/// <summary>1:N msdyn_aibdatasetfile_ProcessSession</summary>
			public const string MsdynAibdatasetfileProcessSession = "msdyn_aibdatasetfile_ProcessSession";

			/// <summary>1:N msdyn_aibdatasetfile_SyncErrors</summary>
			public const string MsdynAibdatasetfileSyncErrors = "msdyn_aibdatasetfile_SyncErrors";

			/// <summary>1:N msdyn_AIBFileAttachedData_msdyn_AIB</summary>
			public const string MsdynAIBFileAttachedDataMsdynAIB = "msdyn_AIBFileAttachedData_msdyn_AIB";

		}
		#endregion
	}
}

