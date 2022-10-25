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
	[EntityLogicalName("msdyn_upgradestep")]
	public sealed class UpgradeStep : Entity
	{	
		public static readonly int? EntityTypeCode = 10069;
		public new const string LogicalName = "msdyn_upgradestep";
		public const string PrimaryIdAttribute = "msdyn_upgradestepid";
		public const string PrimaryNameAttribute = "msdyn_name";
	
		public UpgradeStep() : base("msdyn_upgradestep") { }

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
        /// msdyn_dbversion
        /// </summary>
		[DisplayName("Database Version")]
		[AttributeLogicalName("msdyn_dbversion")]
		public int? DatabaseVersion
		{	
			get { return GetAttributeValue<int?>("msdyn_dbversion"); }
			set
			{ 
				if(value == DatabaseVersion) return;
				SetAttributeValue("msdyn_dbversion", value);
			}
		}	
			
		/// <summary>
        /// msdyn_details
        /// </summary>
		[DisplayName("Details")]
		[AttributeLogicalName("msdyn_details")]
		public string Details
		{	
			get { return GetAttributeValue<string>("msdyn_details"); }
			set
			{ 
				if(value == Details) return;
				SetAttributeValue("msdyn_details", value);
			}
		}	
			
		/// <summary>
        /// msdyn_errors
        /// </summary>
		[DisplayName("Errors")]
		[AttributeLogicalName("msdyn_errors")]
		public string Errors
		{	
			get { return GetAttributeValue<string>("msdyn_errors"); }
			set
			{ 
				if(value == Errors) return;
				SetAttributeValue("msdyn_errors", value);
			}
		}	
			
		/// <summary>
        /// msdyn_finished
        /// </summary>
		[DisplayName("Finished Date")]
		[AttributeLogicalName("msdyn_finished")]
		public DateTime? FinishedDate
		{	
			get { return GetAttributeValue<DateTime?>("msdyn_finished"); }
			set
			{ 
				if(value == FinishedDate) return;
				SetAttributeValue("msdyn_finished", value);
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
        /// msdyn_status
        /// </summary>
		[DisplayName("Step Status")]
		[AttributeLogicalName("msdyn_status")]
		public egUpgradeStatus? StepStatus
		{	
			get 
			{ 
				var optionSetValue = GetAttributeValue<OptionSetValue>("msdyn_status");
				if (optionSetValue != null) return (egUpgradeStatus)optionSetValue.Value;
				else return null;
			}
			set 
			{ 
				if(value == StepStatus) return;

				OptionSetValue optionSetValue = null;
				if(value != null) optionSetValue = new OptionSetValue((int)value);
				SetAttributeValue("msdyn_status", optionSetValue); 
			}
		}

		/// <summary>
        /// msdyn_stepid
        /// </summary>
		[DisplayName("Step ID")]
		[AttributeLogicalName("msdyn_stepid")]
		public Guid StepId
		{	
			get { return GetAttributeValue<Guid>("msdyn_stepid"); }
			set
			{ 
				if(value == StepId) return;
				SetAttributeValue("msdyn_stepid", value);
			}
		}	
			
		/// <summary>
        /// msdyn_upgradestepid
        /// </summary>
		[DisplayName("Upgrade Step")]
		[AttributeLogicalName("msdyn_upgradestepid")]
		public override Guid Id
		{
			get => base.Id;
			set { base.Id = value; SetAttributeValue("msdyn_upgradestepid", value); }
		}

							/// <summary>
        /// msdyn_upgradeversion
        /// </summary>
		[DisplayName("Upgrade Version")]
		[AttributeLogicalName("msdyn_upgradeversion")]
		public EntityReference UpgradeVersion
		{	
			get { return GetAttributeValue<EntityReference>("msdyn_upgradeversion"); }
			set
			{ 
				if(value == UpgradeVersion) return;
				SetAttributeValue("msdyn_upgradeversion", value);
			}
		}	
			
		/// <summary>
        /// msdyn_upgradeversionname
        /// </summary>
		[DisplayName("msdyn_upgradeversionname")]
		[AttributeLogicalName("msdyn_upgradeversionname")]
		public string MsdynUpgradeversionname
		{	
			get { return GetAttributeValue<string>("msdyn_upgradeversionname"); }
			set
			{ 
				if(value == MsdynUpgradeversionname) return;
				SetAttributeValue("msdyn_upgradeversionname", value);
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
        /// 1:N Get entities for 'msdyn_upgradestep_AsyncOperations'
        /// </summary>
		[RelationshipSchemaName("msdyn_upgradestep_AsyncOperations")]
		public IEnumerable<SystemJob> MsdynUpgradestepAsyncOperations
		{
			get { return GetRelatedEntities<SystemJob>("msdyn_upgradestep_AsyncOperations", null); }
			set { SetRelatedEntities("msdyn_upgradestep_AsyncOperations", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'msdyn_upgradestep_BulkDeleteFailures'
        /// </summary>
		[RelationshipSchemaName("msdyn_upgradestep_BulkDeleteFailures")]
		public IEnumerable<BulkDeleteFailure> MsdynUpgradestepBulkDeleteFailures
		{
			get { return GetRelatedEntities<BulkDeleteFailure>("msdyn_upgradestep_BulkDeleteFailures", null); }
			set { SetRelatedEntities("msdyn_upgradestep_BulkDeleteFailures", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'msdyn_upgradestep_MailboxTrackingFolders'
        /// </summary>
		[RelationshipSchemaName("msdyn_upgradestep_MailboxTrackingFolders")]
		public IEnumerable<MailboxAutoTrackingFolder> MsdynUpgradestepMailboxTrackingFolders
		{
			get { return GetRelatedEntities<MailboxAutoTrackingFolder>("msdyn_upgradestep_MailboxTrackingFolders", null); }
			set { SetRelatedEntities("msdyn_upgradestep_MailboxTrackingFolders", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'msdyn_upgradestep_PrincipalObjectAttributeAccesses'
        /// </summary>
		[RelationshipSchemaName("msdyn_upgradestep_PrincipalObjectAttributeAccesses")]
		public IEnumerable<FieldSharing> MsdynUpgradestepPrincipalObjectAttributeAccesses
		{
			get { return GetRelatedEntities<FieldSharing>("msdyn_upgradestep_PrincipalObjectAttributeAccesses", null); }
			set { SetRelatedEntities("msdyn_upgradestep_PrincipalObjectAttributeAccesses", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'msdyn_upgradestep_ProcessSession'
        /// </summary>
		[RelationshipSchemaName("msdyn_upgradestep_ProcessSession")]
		public IEnumerable<ProcessSession> MsdynUpgradestepProcessSession
		{
			get { return GetRelatedEntities<ProcessSession>("msdyn_upgradestep_ProcessSession", null); }
			set { SetRelatedEntities("msdyn_upgradestep_ProcessSession", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'msdyn_upgradestep_SyncErrors'
        /// </summary>
		[RelationshipSchemaName("msdyn_upgradestep_SyncErrors")]
		public IEnumerable<SyncError> MsdynUpgradestepSyncErrors
		{
			get { return GetRelatedEntities<SyncError>("msdyn_upgradestep_SyncErrors", null); }
			set { SetRelatedEntities("msdyn_upgradestep_SyncErrors", null, value); }
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

			/// <summary>msdyn_dbversion</summary>
			public const string DatabaseVersion = "msdyn_dbversion";

			/// <summary>msdyn_details</summary>
			public const string Details = "msdyn_details";

			/// <summary>msdyn_errors</summary>
			public const string Errors = "msdyn_errors";

			/// <summary>msdyn_finished</summary>
			public const string FinishedDate = "msdyn_finished";

			/// <summary>msdyn_name</summary>
			public const string Name = "msdyn_name";

			/// <summary>msdyn_status</summary>
			public const string StepStatus = "msdyn_status";

			/// <summary>msdyn_stepid</summary>
			public const string StepId = "msdyn_stepid";

			/// <summary>msdyn_upgradestepid</summary>
			public const string UpgradeStepId = "msdyn_upgradestepid";

			/// <summary>msdyn_upgradeversion</summary>
			public const string UpgradeVersion = "msdyn_upgradeversion";

			/// <summary>msdyn_upgradeversionname</summary>
			public const string MsdynUpgradeversionname = "msdyn_upgradeversionname";

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
			/// <summary>1:N msdyn_upgradestep_AsyncOperations</summary>
			public const string MsdynUpgradestepAsyncOperations = "msdyn_upgradestep_AsyncOperations";

			/// <summary>1:N msdyn_upgradestep_BulkDeleteFailures</summary>
			public const string MsdynUpgradestepBulkDeleteFailures = "msdyn_upgradestep_BulkDeleteFailures";

			/// <summary>1:N msdyn_upgradestep_MailboxTrackingFolders</summary>
			public const string MsdynUpgradestepMailboxTrackingFolders = "msdyn_upgradestep_MailboxTrackingFolders";

			/// <summary>1:N msdyn_upgradestep_PrincipalObjectAttributeAccesses</summary>
			public const string MsdynUpgradestepPrincipalObjectAttributeAccesses = "msdyn_upgradestep_PrincipalObjectAttributeAccesses";

			/// <summary>1:N msdyn_upgradestep_ProcessSession</summary>
			public const string MsdynUpgradestepProcessSession = "msdyn_upgradestep_ProcessSession";

			/// <summary>1:N msdyn_upgradestep_SyncErrors</summary>
			public const string MsdynUpgradestepSyncErrors = "msdyn_upgradestep_SyncErrors";

		}
		#endregion
	}
}

