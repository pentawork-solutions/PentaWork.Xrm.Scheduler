using System;
using System.Linq;
using System.Diagnostics;
using System.ComponentModel;
using Microsoft.Xrm.Sdk; 
using Microsoft.Xrm.Sdk.Client;
using System.Collections.Generic;

namespace PentaWork.Xrm.Scheduler.Proxies.Entities
{
	[DebuggerDisplay("{Summary}")] 	
	[EntityLogicalName("msdyn_upgradeversion")]
	public sealed class UpgradeVersion : Entity
	{	
		public static readonly int? EntityTypeCode = 10070;
		public new const string LogicalName = "msdyn_upgradeversion";
		public const string PrimaryIdAttribute = "msdyn_upgradeversionid";
		public const string PrimaryNameAttribute = "msdyn_summary";
	
		public UpgradeVersion() : base("msdyn_upgradeversion") { }

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
		[DisplayName("Started")]
		[AttributeLogicalName("createdon")]
		public DateTime? Started
		{	
			get { return GetAttributeValue<DateTime?>("createdon"); }
			set
			{ 
				if(value == Started) return;
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
        /// msdyn_finished
        /// </summary>
		[DisplayName("Finished")]
		[AttributeLogicalName("msdyn_finished")]
		public DateTime? Finished
		{	
			get { return GetAttributeValue<DateTime?>("msdyn_finished"); }
			set
			{ 
				if(value == Finished) return;
				SetAttributeValue("msdyn_finished", value);
			}
		}	
			
		/// <summary>
        /// msdyn_startingversion
        /// </summary>
		[DisplayName("StartingVersion")]
		[AttributeLogicalName("msdyn_startingversion")]
		public string StartingVersion
		{	
			get { return GetAttributeValue<string>("msdyn_startingversion"); }
			set
			{ 
				if(value == StartingVersion) return;
				SetAttributeValue("msdyn_startingversion", value);
			}
		}	
			
		/// <summary>
        /// msdyn_status
        /// </summary>
		[DisplayName("Upgrade Status")]
		[AttributeLogicalName("msdyn_status")]
		public egUpgradeStatus? UpgradeStatus
		{	
			get 
			{ 
				var optionSetValue = GetAttributeValue<OptionSetValue>("msdyn_status");
				if (optionSetValue != null) return (egUpgradeStatus)optionSetValue.Value;
				else return null;
			}
			set 
			{ 
				if(value == UpgradeStatus) return;

				OptionSetValue optionSetValue = null;
				if(value != null) optionSetValue = new OptionSetValue((int)value);
				SetAttributeValue("msdyn_status", optionSetValue); 
			}
		}

		/// <summary>
        /// msdyn_summary
        /// </summary>
		[DisplayName("Summary")]
		[AttributeLogicalName("msdyn_summary")]
		public string Summary
		{	
			get { return GetAttributeValue<string>("msdyn_summary"); }
			set
			{ 
				if(value == Summary) return;
				SetAttributeValue("msdyn_summary", value);
			}
		}	
			
		/// <summary>
        /// msdyn_targetversion
        /// </summary>
		[DisplayName("TargetVersion")]
		[AttributeLogicalName("msdyn_targetversion")]
		public string TargetVersion
		{	
			get { return GetAttributeValue<string>("msdyn_targetversion"); }
			set
			{ 
				if(value == TargetVersion) return;
				SetAttributeValue("msdyn_targetversion", value);
			}
		}	
			
		/// <summary>
        /// msdyn_upgraderun
        /// </summary>
		[DisplayName("UpgradeRun")]
		[AttributeLogicalName("msdyn_upgraderun")]
		public EntityReference UpgradeRun
		{	
			get { return GetAttributeValue<EntityReference>("msdyn_upgraderun"); }
			set
			{ 
				if(value == UpgradeRun) return;
				SetAttributeValue("msdyn_upgraderun", value);
			}
		}	
			
		/// <summary>
        /// msdyn_upgraderunname
        /// </summary>
		[DisplayName("msdyn_upgraderunname")]
		[AttributeLogicalName("msdyn_upgraderunname")]
		public string MsdynUpgraderunname
		{	
			get { return GetAttributeValue<string>("msdyn_upgraderunname"); }
			set
			{ 
				if(value == MsdynUpgraderunname) return;
				SetAttributeValue("msdyn_upgraderunname", value);
			}
		}	
			
		/// <summary>
        /// msdyn_upgradeversionid
        /// </summary>
		[DisplayName("UpgradeVersion")]
		[AttributeLogicalName("msdyn_upgradeversionid")]
		public override Guid Id
		{
			get => base.Id;
			set { base.Id = value; SetAttributeValue("msdyn_upgradeversionid", value); }
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
        /// 1:N Get entities for 'msdyn_msdyn_upgradeversion_msdyn_upgradestep_UpgradeVersion'
        /// </summary>
		[RelationshipSchemaName("msdyn_msdyn_upgradeversion_msdyn_upgradestep_UpgradeVersion")]
		public IEnumerable<UpgradeStep> MsdynMsdynUpgradeversionMsdynUpgradestepUpgradeVersion
		{
			get { return GetRelatedEntities<UpgradeStep>("msdyn_msdyn_upgradeversion_msdyn_upgradestep_UpgradeVersion", null); }
			set { SetRelatedEntities("msdyn_msdyn_upgradeversion_msdyn_upgradestep_UpgradeVersion", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'msdyn_upgradeversion_AsyncOperations'
        /// </summary>
		[RelationshipSchemaName("msdyn_upgradeversion_AsyncOperations")]
		public IEnumerable<SystemJob> MsdynUpgradeversionAsyncOperations
		{
			get { return GetRelatedEntities<SystemJob>("msdyn_upgradeversion_AsyncOperations", null); }
			set { SetRelatedEntities("msdyn_upgradeversion_AsyncOperations", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'msdyn_upgradeversion_BulkDeleteFailures'
        /// </summary>
		[RelationshipSchemaName("msdyn_upgradeversion_BulkDeleteFailures")]
		public IEnumerable<BulkDeleteFailure> MsdynUpgradeversionBulkDeleteFailures
		{
			get { return GetRelatedEntities<BulkDeleteFailure>("msdyn_upgradeversion_BulkDeleteFailures", null); }
			set { SetRelatedEntities("msdyn_upgradeversion_BulkDeleteFailures", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'msdyn_upgradeversion_MailboxTrackingFolders'
        /// </summary>
		[RelationshipSchemaName("msdyn_upgradeversion_MailboxTrackingFolders")]
		public IEnumerable<MailboxAutoTrackingFolder> MsdynUpgradeversionMailboxTrackingFolders
		{
			get { return GetRelatedEntities<MailboxAutoTrackingFolder>("msdyn_upgradeversion_MailboxTrackingFolders", null); }
			set { SetRelatedEntities("msdyn_upgradeversion_MailboxTrackingFolders", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'msdyn_upgradeversion_PrincipalObjectAttributeAccesses'
        /// </summary>
		[RelationshipSchemaName("msdyn_upgradeversion_PrincipalObjectAttributeAccesses")]
		public IEnumerable<FieldSharing> MsdynUpgradeversionPrincipalObjectAttributeAccesses
		{
			get { return GetRelatedEntities<FieldSharing>("msdyn_upgradeversion_PrincipalObjectAttributeAccesses", null); }
			set { SetRelatedEntities("msdyn_upgradeversion_PrincipalObjectAttributeAccesses", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'msdyn_upgradeversion_ProcessSession'
        /// </summary>
		[RelationshipSchemaName("msdyn_upgradeversion_ProcessSession")]
		public IEnumerable<ProcessSession> MsdynUpgradeversionProcessSession
		{
			get { return GetRelatedEntities<ProcessSession>("msdyn_upgradeversion_ProcessSession", null); }
			set { SetRelatedEntities("msdyn_upgradeversion_ProcessSession", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'msdyn_upgradeversion_SyncErrors'
        /// </summary>
		[RelationshipSchemaName("msdyn_upgradeversion_SyncErrors")]
		public IEnumerable<SyncError> MsdynUpgradeversionSyncErrors
		{
			get { return GetRelatedEntities<SyncError>("msdyn_upgradeversion_SyncErrors", null); }
			set { SetRelatedEntities("msdyn_upgradeversion_SyncErrors", null, value); }
		}
		#endregion

		#region Actions
		#endregion

		#region OptionSetEnums
		public enum egUpgradeStatus
		{	
		
			[Label("Started")]
			[Description(@"")]
			Started = 100000000, 
		
			[Label("Success")]
			[Description(@"")]
			Success = 100000001, 
		
			[Label("Failure")]
			[Description(@"")]
			Failure = 100000002, 
		}
		
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
			public const string Started = "createdon";

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

			/// <summary>msdyn_finished</summary>
			public const string Finished = "msdyn_finished";

			/// <summary>msdyn_startingversion</summary>
			public const string StartingVersion = "msdyn_startingversion";

			/// <summary>msdyn_status</summary>
			public const string UpgradeStatus = "msdyn_status";

			/// <summary>msdyn_summary</summary>
			public const string Summary = "msdyn_summary";

			/// <summary>msdyn_targetversion</summary>
			public const string TargetVersion = "msdyn_targetversion";

			/// <summary>msdyn_upgraderun</summary>
			public const string UpgradeRun = "msdyn_upgraderun";

			/// <summary>msdyn_upgraderunname</summary>
			public const string MsdynUpgraderunname = "msdyn_upgraderunname";

			/// <summary>msdyn_upgradeversionid</summary>
			public const string UpgradeVersionId = "msdyn_upgradeversionid";

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
			/// <summary>1:N msdyn_msdyn_upgradeversion_msdyn_upgradestep_UpgradeVersion</summary>
			public const string MsdynMsdynUpgradeversionMsdynUpgradestepUpgradeVersion = "msdyn_msdyn_upgradeversion_msdyn_upgradestep_UpgradeVersion";

			/// <summary>1:N msdyn_upgradeversion_AsyncOperations</summary>
			public const string MsdynUpgradeversionAsyncOperations = "msdyn_upgradeversion_AsyncOperations";

			/// <summary>1:N msdyn_upgradeversion_BulkDeleteFailures</summary>
			public const string MsdynUpgradeversionBulkDeleteFailures = "msdyn_upgradeversion_BulkDeleteFailures";

			/// <summary>1:N msdyn_upgradeversion_MailboxTrackingFolders</summary>
			public const string MsdynUpgradeversionMailboxTrackingFolders = "msdyn_upgradeversion_MailboxTrackingFolders";

			/// <summary>1:N msdyn_upgradeversion_PrincipalObjectAttributeAccesses</summary>
			public const string MsdynUpgradeversionPrincipalObjectAttributeAccesses = "msdyn_upgradeversion_PrincipalObjectAttributeAccesses";

			/// <summary>1:N msdyn_upgradeversion_ProcessSession</summary>
			public const string MsdynUpgradeversionProcessSession = "msdyn_upgradeversion_ProcessSession";

			/// <summary>1:N msdyn_upgradeversion_SyncErrors</summary>
			public const string MsdynUpgradeversionSyncErrors = "msdyn_upgradeversion_SyncErrors";

		}
		#endregion
	}
}

