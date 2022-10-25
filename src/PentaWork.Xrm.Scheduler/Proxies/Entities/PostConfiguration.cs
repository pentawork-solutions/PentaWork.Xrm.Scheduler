using System;
using System.Linq;
using System.Diagnostics;
using System.ComponentModel;
using Microsoft.Xrm.Sdk; 
using Microsoft.Xrm.Sdk.Client;
using System.Collections.Generic;

namespace PentaWork.Xrm.Scheduler.Proxies.Entities
{
	[DebuggerDisplay("{EntityDisplayName}")] 	
	[EntityLogicalName("msdyn_postconfig")]
	public sealed class PostConfiguration : Entity
	{	
		public static readonly int? EntityTypeCode = 10102;
		public new const string LogicalName = "msdyn_postconfig";
		public const string PrimaryIdAttribute = "msdyn_postconfigid";
		public const string PrimaryNameAttribute = "msdyn_entitydisplayname";
	
		public PostConfiguration() : base("msdyn_postconfig") { }

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
        /// msdyn_configurewall
        /// </summary>
		[DisplayName("Wall Enabled")]
		[AttributeLogicalName("msdyn_configurewall")]
		public bool? WallEnabled
		{	
			get { return GetAttributeValue<bool?>("msdyn_configurewall"); }
			set
			{ 
				if(value == WallEnabled) return;
				SetAttributeValue("msdyn_configurewall", value);
			}
		}	
			
		/// <summary>
        /// msdyn_entitydisplayname
        /// </summary>
		[DisplayName("Entity Display Name")]
		[AttributeLogicalName("msdyn_entitydisplayname")]
		public string EntityDisplayName
		{	
			get { return GetAttributeValue<string>("msdyn_entitydisplayname"); }
			set
			{ 
				if(value == EntityDisplayName) return;
				SetAttributeValue("msdyn_entitydisplayname", value);
			}
		}	
			
		/// <summary>
        /// msdyn_entityname
        /// </summary>
		[DisplayName("Entity Name")]
		[AttributeLogicalName("msdyn_entityname")]
		public string EntityName
		{	
			get { return GetAttributeValue<string>("msdyn_entityname"); }
			set
			{ 
				if(value == EntityName) return;
				SetAttributeValue("msdyn_entityname", value);
			}
		}	
			
		/// <summary>
        /// msdyn_followingviewid
        /// </summary>
		[DisplayName("Following View Id")]
		[AttributeLogicalName("msdyn_followingviewid")]
		public string FollowingViewId
		{	
			get { return GetAttributeValue<string>("msdyn_followingviewid"); }
			set
			{ 
				if(value == FollowingViewId) return;
				SetAttributeValue("msdyn_followingviewid", value);
			}
		}	
			
		/// <summary>
        /// msdyn_followingviewid2
        /// </summary>
		[DisplayName("Following View Id 2")]
		[AttributeLogicalName("msdyn_followingviewid2")]
		public string FollowingViewId2
		{	
			get { return GetAttributeValue<string>("msdyn_followingviewid2"); }
			set
			{ 
				if(value == FollowingViewId2) return;
				SetAttributeValue("msdyn_followingviewid2", value);
			}
		}	
			
		/// <summary>
        /// msdyn_otc
        /// </summary>
		[DisplayName("Object Type Code")]
		[AttributeLogicalName("msdyn_otc")]
		public int? ObjectTypeCode
		{	
			get { return GetAttributeValue<int?>("msdyn_otc"); }
			set
			{ 
				if(value == ObjectTypeCode) return;
				SetAttributeValue("msdyn_otc", value);
			}
		}	
			
		/// <summary>
        /// msdyn_postconfigid
        /// </summary>
		[DisplayName("Post Configuration")]
		[AttributeLogicalName("msdyn_postconfigid")]
		public override Guid Id
		{
			get => base.Id;
			set { base.Id = value; SetAttributeValue("msdyn_postconfigid", value); }
		}

							/// <summary>
        /// msdyn_status
        /// </summary>
		[DisplayName("Configuration Status")]
		[AttributeLogicalName("msdyn_status")]
		public string ConfigurationStatus
		{	
			get { return GetAttributeValue<string>("msdyn_status"); }
			set
			{ 
				if(value == ConfigurationStatus) return;
				SetAttributeValue("msdyn_status", value);
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
        /// 1:N Get entities for 'msdyn_postconfig_AsyncOperations'
        /// </summary>
		[RelationshipSchemaName("msdyn_postconfig_AsyncOperations")]
		public IEnumerable<SystemJob> MsdynPostconfigAsyncOperations
		{
			get { return GetRelatedEntities<SystemJob>("msdyn_postconfig_AsyncOperations", null); }
			set { SetRelatedEntities("msdyn_postconfig_AsyncOperations", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'msdyn_postconfig_BulkDeleteFailures'
        /// </summary>
		[RelationshipSchemaName("msdyn_postconfig_BulkDeleteFailures")]
		public IEnumerable<BulkDeleteFailure> MsdynPostconfigBulkDeleteFailures
		{
			get { return GetRelatedEntities<BulkDeleteFailure>("msdyn_postconfig_BulkDeleteFailures", null); }
			set { SetRelatedEntities("msdyn_postconfig_BulkDeleteFailures", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'msdyn_postconfig_MailboxTrackingFolders'
        /// </summary>
		[RelationshipSchemaName("msdyn_postconfig_MailboxTrackingFolders")]
		public IEnumerable<MailboxAutoTrackingFolder> MsdynPostconfigMailboxTrackingFolders
		{
			get { return GetRelatedEntities<MailboxAutoTrackingFolder>("msdyn_postconfig_MailboxTrackingFolders", null); }
			set { SetRelatedEntities("msdyn_postconfig_MailboxTrackingFolders", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'msdyn_postconfig_msdyn_postruleconfig'
        /// </summary>
		[RelationshipSchemaName("msdyn_postconfig_msdyn_postruleconfig")]
		public IEnumerable<PostRuleConfiguration> MsdynPostconfigMsdynPostruleconfig
		{
			get { return GetRelatedEntities<PostRuleConfiguration>("msdyn_postconfig_msdyn_postruleconfig", null); }
			set { SetRelatedEntities("msdyn_postconfig_msdyn_postruleconfig", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'msdyn_postconfig_PrincipalObjectAttributeAccesses'
        /// </summary>
		[RelationshipSchemaName("msdyn_postconfig_PrincipalObjectAttributeAccesses")]
		public IEnumerable<FieldSharing> MsdynPostconfigPrincipalObjectAttributeAccesses
		{
			get { return GetRelatedEntities<FieldSharing>("msdyn_postconfig_PrincipalObjectAttributeAccesses", null); }
			set { SetRelatedEntities("msdyn_postconfig_PrincipalObjectAttributeAccesses", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'msdyn_postconfig_ProcessSession'
        /// </summary>
		[RelationshipSchemaName("msdyn_postconfig_ProcessSession")]
		public IEnumerable<ProcessSession> MsdynPostconfigProcessSession
		{
			get { return GetRelatedEntities<ProcessSession>("msdyn_postconfig_ProcessSession", null); }
			set { SetRelatedEntities("msdyn_postconfig_ProcessSession", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'msdyn_postconfig_SyncErrors'
        /// </summary>
		[RelationshipSchemaName("msdyn_postconfig_SyncErrors")]
		public IEnumerable<SyncError> MsdynPostconfigSyncErrors
		{
			get { return GetRelatedEntities<SyncError>("msdyn_postconfig_SyncErrors", null); }
			set { SetRelatedEntities("msdyn_postconfig_SyncErrors", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'msdyn_postconfig_wallsavedquery'
        /// </summary>
		[RelationshipSchemaName("msdyn_postconfig_wallsavedquery")]
		public IEnumerable<WallView> MsdynPostconfigWallsavedquery
		{
			get { return GetRelatedEntities<WallView>("msdyn_postconfig_wallsavedquery", null); }
			set { SetRelatedEntities("msdyn_postconfig_wallsavedquery", null, value); }
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

			/// <summary>msdyn_configurewall</summary>
			public const string WallEnabled = "msdyn_configurewall";

			/// <summary>msdyn_entitydisplayname</summary>
			public const string EntityDisplayName = "msdyn_entitydisplayname";

			/// <summary>msdyn_entityname</summary>
			public const string EntityName = "msdyn_entityname";

			/// <summary>msdyn_followingviewid</summary>
			public const string FollowingViewId = "msdyn_followingviewid";

			/// <summary>msdyn_followingviewid2</summary>
			public const string FollowingViewId2 = "msdyn_followingviewid2";

			/// <summary>msdyn_otc</summary>
			public const string ObjectTypeCode = "msdyn_otc";

			/// <summary>msdyn_postconfigid</summary>
			public const string PostConfigurationId = "msdyn_postconfigid";

			/// <summary>msdyn_status</summary>
			public const string ConfigurationStatus = "msdyn_status";

			/// <summary>organizationid</summary>
			public const string OrganizationId = "organizationid";

			/// <summary>organizationidname</summary>
			public const string Organizationidname = "organizationidname";

			/// <summary>overriddencreatedon</summary>
			public const string RecordCreatedOn = "overriddencreatedon";

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
			/// <summary>1:N msdyn_postconfig_AsyncOperations</summary>
			public const string MsdynPostconfigAsyncOperations = "msdyn_postconfig_AsyncOperations";

			/// <summary>1:N msdyn_postconfig_BulkDeleteFailures</summary>
			public const string MsdynPostconfigBulkDeleteFailures = "msdyn_postconfig_BulkDeleteFailures";

			/// <summary>1:N msdyn_postconfig_MailboxTrackingFolders</summary>
			public const string MsdynPostconfigMailboxTrackingFolders = "msdyn_postconfig_MailboxTrackingFolders";

			/// <summary>1:N msdyn_postconfig_msdyn_postruleconfig</summary>
			public const string MsdynPostconfigMsdynPostruleconfig = "msdyn_postconfig_msdyn_postruleconfig";

			/// <summary>1:N msdyn_postconfig_PrincipalObjectAttributeAccesses</summary>
			public const string MsdynPostconfigPrincipalObjectAttributeAccesses = "msdyn_postconfig_PrincipalObjectAttributeAccesses";

			/// <summary>1:N msdyn_postconfig_ProcessSession</summary>
			public const string MsdynPostconfigProcessSession = "msdyn_postconfig_ProcessSession";

			/// <summary>1:N msdyn_postconfig_SyncErrors</summary>
			public const string MsdynPostconfigSyncErrors = "msdyn_postconfig_SyncErrors";

			/// <summary>1:N msdyn_postconfig_wallsavedquery</summary>
			public const string MsdynPostconfigWallsavedquery = "msdyn_postconfig_wallsavedquery";

		}
		#endregion
	}
}

