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
	[EntityLogicalName("msdyn_aiodtrainingimage")]
	public sealed class AIObjectDetectionImageMapping : Entity
	{	
		public static readonly int? EntityTypeCode = 10064;
		public new const string LogicalName = "msdyn_aiodtrainingimage";
		public const string PrimaryIdAttribute = "msdyn_aiodtrainingimageid";
		public const string PrimaryNameAttribute = "msdyn_name";
	
		public AIObjectDetectionImageMapping() : base("msdyn_aiodtrainingimage") { }

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
        /// msdyn_aiconfigurationid
        /// </summary>
		[DisplayName("AIConfiguration")]
		[AttributeLogicalName("msdyn_aiconfigurationid")]
		public EntityReference AIConfiguration
		{	
			get { return GetAttributeValue<EntityReference>("msdyn_aiconfigurationid"); }
			set
			{ 
				if(value == AIConfiguration) return;
				SetAttributeValue("msdyn_aiconfigurationid", value);
			}
		}	
			
		/// <summary>
        /// msdyn_aiconfigurationidname
        /// </summary>
		[DisplayName("msdyn_aiconfigurationidname")]
		[AttributeLogicalName("msdyn_aiconfigurationidname")]
		public string MsdynAiconfigurationidname
		{	
			get { return GetAttributeValue<string>("msdyn_aiconfigurationidname"); }
			set
			{ 
				if(value == MsdynAiconfigurationidname) return;
				SetAttributeValue("msdyn_aiconfigurationidname", value);
			}
		}	
			
		/// <summary>
        /// msdyn_aiodimageid
        /// </summary>
		[DisplayName("Image")]
		[AttributeLogicalName("msdyn_aiodimageid")]
		public EntityReference Image
		{	
			get { return GetAttributeValue<EntityReference>("msdyn_aiodimageid"); }
			set
			{ 
				if(value == Image) return;
				SetAttributeValue("msdyn_aiodimageid", value);
			}
		}	
			
		/// <summary>
        /// msdyn_aiodimageidname
        /// </summary>
		[DisplayName("msdyn_aiodimageidname")]
		[AttributeLogicalName("msdyn_aiodimageidname")]
		public string MsdynAiodimageidname
		{	
			get { return GetAttributeValue<string>("msdyn_aiodimageidname"); }
			set
			{ 
				if(value == MsdynAiodimageidname) return;
				SetAttributeValue("msdyn_aiodimageidname", value);
			}
		}	
			
		/// <summary>
        /// msdyn_aiodtrainingimageid
        /// </summary>
		[DisplayName("Training Image")]
		[AttributeLogicalName("msdyn_aiodtrainingimageid")]
		public override Guid Id
		{
			get => base.Id;
			set { base.Id = value; SetAttributeValue("msdyn_aiodtrainingimageid", value); }
		}

							/// <summary>
        /// msdyn_lastmodifieddate
        /// </summary>
		[DisplayName("Last Modified Date")]
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
        /// msdyn_sourcetype
        /// </summary>
		[DisplayName("SourceType")]
		[AttributeLogicalName("msdyn_sourcetype")]
		public string SourceType
		{	
			get { return GetAttributeValue<string>("msdyn_sourcetype"); }
			set
			{ 
				if(value == SourceType) return;
				SetAttributeValue("msdyn_sourcetype", value);
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
        /// 1:N Get entities for 'msdyn_aiodtrainingimage_AsyncOperations'
        /// </summary>
		[RelationshipSchemaName("msdyn_aiodtrainingimage_AsyncOperations")]
		public IEnumerable<SystemJob> MsdynAiodtrainingimageAsyncOperations
		{
			get { return GetRelatedEntities<SystemJob>("msdyn_aiodtrainingimage_AsyncOperations", null); }
			set { SetRelatedEntities("msdyn_aiodtrainingimage_AsyncOperations", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'msdyn_aiodtrainingimage_BulkDeleteFailures'
        /// </summary>
		[RelationshipSchemaName("msdyn_aiodtrainingimage_BulkDeleteFailures")]
		public IEnumerable<BulkDeleteFailure> MsdynAiodtrainingimageBulkDeleteFailures
		{
			get { return GetRelatedEntities<BulkDeleteFailure>("msdyn_aiodtrainingimage_BulkDeleteFailures", null); }
			set { SetRelatedEntities("msdyn_aiodtrainingimage_BulkDeleteFailures", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'msdyn_aiodtrainingimage_DuplicateBaseRecord'
        /// </summary>
		[RelationshipSchemaName("msdyn_aiodtrainingimage_DuplicateBaseRecord")]
		public IEnumerable<DuplicateRecord> MsdynAiodtrainingimageDuplicateBaseRecord
		{
			get { return GetRelatedEntities<DuplicateRecord>("msdyn_aiodtrainingimage_DuplicateBaseRecord", null); }
			set { SetRelatedEntities("msdyn_aiodtrainingimage_DuplicateBaseRecord", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'msdyn_aiodtrainingimage_DuplicateMatchingRecord'
        /// </summary>
		[RelationshipSchemaName("msdyn_aiodtrainingimage_DuplicateMatchingRecord")]
		public IEnumerable<DuplicateRecord> MsdynAiodtrainingimageDuplicateMatchingRecord
		{
			get { return GetRelatedEntities<DuplicateRecord>("msdyn_aiodtrainingimage_DuplicateMatchingRecord", null); }
			set { SetRelatedEntities("msdyn_aiodtrainingimage_DuplicateMatchingRecord", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'msdyn_aiodtrainingimage_MailboxTrackingFolders'
        /// </summary>
		[RelationshipSchemaName("msdyn_aiodtrainingimage_MailboxTrackingFolders")]
		public IEnumerable<MailboxAutoTrackingFolder> MsdynAiodtrainingimageMailboxTrackingFolders
		{
			get { return GetRelatedEntities<MailboxAutoTrackingFolder>("msdyn_aiodtrainingimage_MailboxTrackingFolders", null); }
			set { SetRelatedEntities("msdyn_aiodtrainingimage_MailboxTrackingFolders", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'msdyn_aiodtrainingimage_msdyn_aiodtrainingboundingbox'
        /// </summary>
		[RelationshipSchemaName("msdyn_aiodtrainingimage_msdyn_aiodtrainingboundingbox")]
		public IEnumerable<AIObjectDetectionBoundingBox> MsdynAiodtrainingimageMsdynAiodtrainingboundingbox
		{
			get { return GetRelatedEntities<AIObjectDetectionBoundingBox>("msdyn_aiodtrainingimage_msdyn_aiodtrainingboundingbox", null); }
			set { SetRelatedEntities("msdyn_aiodtrainingimage_msdyn_aiodtrainingboundingbox", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'msdyn_aiodtrainingimage_PrincipalObjectAttributeAccesses'
        /// </summary>
		[RelationshipSchemaName("msdyn_aiodtrainingimage_PrincipalObjectAttributeAccesses")]
		public IEnumerable<FieldSharing> MsdynAiodtrainingimagePrincipalObjectAttributeAccesses
		{
			get { return GetRelatedEntities<FieldSharing>("msdyn_aiodtrainingimage_PrincipalObjectAttributeAccesses", null); }
			set { SetRelatedEntities("msdyn_aiodtrainingimage_PrincipalObjectAttributeAccesses", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'msdyn_aiodtrainingimage_ProcessSession'
        /// </summary>
		[RelationshipSchemaName("msdyn_aiodtrainingimage_ProcessSession")]
		public IEnumerable<ProcessSession> MsdynAiodtrainingimageProcessSession
		{
			get { return GetRelatedEntities<ProcessSession>("msdyn_aiodtrainingimage_ProcessSession", null); }
			set { SetRelatedEntities("msdyn_aiodtrainingimage_ProcessSession", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'msdyn_aiodtrainingimage_SyncErrors'
        /// </summary>
		[RelationshipSchemaName("msdyn_aiodtrainingimage_SyncErrors")]
		public IEnumerable<SyncError> MsdynAiodtrainingimageSyncErrors
		{
			get { return GetRelatedEntities<SyncError>("msdyn_aiodtrainingimage_SyncErrors", null); }
			set { SetRelatedEntities("msdyn_aiodtrainingimage_SyncErrors", null, value); }
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

			/// <summary>msdyn_aiconfigurationid</summary>
			public const string AIConfiguration = "msdyn_aiconfigurationid";

			/// <summary>msdyn_aiconfigurationidname</summary>
			public const string MsdynAiconfigurationidname = "msdyn_aiconfigurationidname";

			/// <summary>msdyn_aiodimageid</summary>
			public const string Image = "msdyn_aiodimageid";

			/// <summary>msdyn_aiodimageidname</summary>
			public const string MsdynAiodimageidname = "msdyn_aiodimageidname";

			/// <summary>msdyn_aiodtrainingimageid</summary>
			public const string TrainingImageId = "msdyn_aiodtrainingimageid";

			/// <summary>msdyn_lastmodifieddate</summary>
			public const string LastModifiedDate = "msdyn_lastmodifieddate";

			/// <summary>msdyn_name</summary>
			public const string Name = "msdyn_name";

			/// <summary>msdyn_sourcetype</summary>
			public const string SourceType = "msdyn_sourcetype";

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
			/// <summary>1:N msdyn_aiodtrainingimage_AsyncOperations</summary>
			public const string MsdynAiodtrainingimageAsyncOperations = "msdyn_aiodtrainingimage_AsyncOperations";

			/// <summary>1:N msdyn_aiodtrainingimage_BulkDeleteFailures</summary>
			public const string MsdynAiodtrainingimageBulkDeleteFailures = "msdyn_aiodtrainingimage_BulkDeleteFailures";

			/// <summary>1:N msdyn_aiodtrainingimage_DuplicateBaseRecord</summary>
			public const string MsdynAiodtrainingimageDuplicateBaseRecord = "msdyn_aiodtrainingimage_DuplicateBaseRecord";

			/// <summary>1:N msdyn_aiodtrainingimage_DuplicateMatchingRecord</summary>
			public const string MsdynAiodtrainingimageDuplicateMatchingRecord = "msdyn_aiodtrainingimage_DuplicateMatchingRecord";

			/// <summary>1:N msdyn_aiodtrainingimage_MailboxTrackingFolders</summary>
			public const string MsdynAiodtrainingimageMailboxTrackingFolders = "msdyn_aiodtrainingimage_MailboxTrackingFolders";

			/// <summary>1:N msdyn_aiodtrainingimage_msdyn_aiodtrainingboundingbox</summary>
			public const string MsdynAiodtrainingimageMsdynAiodtrainingboundingbox = "msdyn_aiodtrainingimage_msdyn_aiodtrainingboundingbox";

			/// <summary>1:N msdyn_aiodtrainingimage_PrincipalObjectAttributeAccesses</summary>
			public const string MsdynAiodtrainingimagePrincipalObjectAttributeAccesses = "msdyn_aiodtrainingimage_PrincipalObjectAttributeAccesses";

			/// <summary>1:N msdyn_aiodtrainingimage_ProcessSession</summary>
			public const string MsdynAiodtrainingimageProcessSession = "msdyn_aiodtrainingimage_ProcessSession";

			/// <summary>1:N msdyn_aiodtrainingimage_SyncErrors</summary>
			public const string MsdynAiodtrainingimageSyncErrors = "msdyn_aiodtrainingimage_SyncErrors";

		}
		#endregion
	}
}

