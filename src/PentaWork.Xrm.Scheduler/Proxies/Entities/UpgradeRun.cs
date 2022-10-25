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
	[EntityLogicalName("msdyn_upgraderun")]
	public sealed class UpgradeRun : Entity
	{	
		public static readonly int? EntityTypeCode = 10068;
		public new const string LogicalName = "msdyn_upgraderun";
		public const string PrimaryIdAttribute = "msdyn_upgraderunid";
		public const string PrimaryNameAttribute = "msdyn_summary";
	
		public UpgradeRun() : base("msdyn_upgraderun") { }

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
        /// msdyn_error
        /// </summary>
		[DisplayName("Error")]
		[AttributeLogicalName("msdyn_error")]
		public string Error
		{	
			get { return GetAttributeValue<string>("msdyn_error"); }
			set
			{ 
				if(value == Error) return;
				SetAttributeValue("msdyn_error", value);
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
        /// msdyn_package
        /// </summary>
		[DisplayName("Package Name")]
		[AttributeLogicalName("msdyn_package")]
		public string PackageName
		{	
			get { return GetAttributeValue<string>("msdyn_package"); }
			set
			{ 
				if(value == PackageName) return;
				SetAttributeValue("msdyn_package", value);
			}
		}	
			
		/// <summary>
        /// msdyn_solution
        /// </summary>
		[DisplayName("Solution Name")]
		[AttributeLogicalName("msdyn_solution")]
		public string SolutionName
		{	
			get { return GetAttributeValue<string>("msdyn_solution"); }
			set
			{ 
				if(value == SolutionName) return;
				SetAttributeValue("msdyn_solution", value);
			}
		}	
			
		/// <summary>
        /// msdyn_startingversion
        /// </summary>
		[DisplayName("Starting Version")]
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
		[DisplayName("Run Status")]
		[AttributeLogicalName("msdyn_status")]
		public egUpgradeStatus? RunStatus
		{	
			get 
			{ 
				var optionSetValue = GetAttributeValue<OptionSetValue>("msdyn_status");
				if (optionSetValue != null) return (egUpgradeStatus)optionSetValue.Value;
				else return null;
			}
			set 
			{ 
				if(value == RunStatus) return;

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
		[DisplayName("Target Version")]
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
        /// msdyn_upgraderunid
        /// </summary>
		[DisplayName("Upgrade Run")]
		[AttributeLogicalName("msdyn_upgraderunid")]
		public override Guid Id
		{
			get => base.Id;
			set { base.Id = value; SetAttributeValue("msdyn_upgraderunid", value); }
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
        /// 1:N Get entities for 'msdyn_msdyn_upgraderun_msdyn_upgradeversion_UpgradeRun'
        /// </summary>
		[RelationshipSchemaName("msdyn_msdyn_upgraderun_msdyn_upgradeversion_UpgradeRun")]
		public IEnumerable<UpgradeVersion> MsdynMsdynUpgraderunMsdynUpgradeversionUpgradeRun
		{
			get { return GetRelatedEntities<UpgradeVersion>("msdyn_msdyn_upgraderun_msdyn_upgradeversion_UpgradeRun", null); }
			set { SetRelatedEntities("msdyn_msdyn_upgraderun_msdyn_upgradeversion_UpgradeRun", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'msdyn_upgraderun_AsyncOperations'
        /// </summary>
		[RelationshipSchemaName("msdyn_upgraderun_AsyncOperations")]
		public IEnumerable<SystemJob> MsdynUpgraderunAsyncOperations
		{
			get { return GetRelatedEntities<SystemJob>("msdyn_upgraderun_AsyncOperations", null); }
			set { SetRelatedEntities("msdyn_upgraderun_AsyncOperations", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'msdyn_upgraderun_BulkDeleteFailures'
        /// </summary>
		[RelationshipSchemaName("msdyn_upgraderun_BulkDeleteFailures")]
		public IEnumerable<BulkDeleteFailure> MsdynUpgraderunBulkDeleteFailures
		{
			get { return GetRelatedEntities<BulkDeleteFailure>("msdyn_upgraderun_BulkDeleteFailures", null); }
			set { SetRelatedEntities("msdyn_upgraderun_BulkDeleteFailures", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'msdyn_upgraderun_MailboxTrackingFolders'
        /// </summary>
		[RelationshipSchemaName("msdyn_upgraderun_MailboxTrackingFolders")]
		public IEnumerable<MailboxAutoTrackingFolder> MsdynUpgraderunMailboxTrackingFolders
		{
			get { return GetRelatedEntities<MailboxAutoTrackingFolder>("msdyn_upgraderun_MailboxTrackingFolders", null); }
			set { SetRelatedEntities("msdyn_upgraderun_MailboxTrackingFolders", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'msdyn_upgraderun_PrincipalObjectAttributeAccesses'
        /// </summary>
		[RelationshipSchemaName("msdyn_upgraderun_PrincipalObjectAttributeAccesses")]
		public IEnumerable<FieldSharing> MsdynUpgraderunPrincipalObjectAttributeAccesses
		{
			get { return GetRelatedEntities<FieldSharing>("msdyn_upgraderun_PrincipalObjectAttributeAccesses", null); }
			set { SetRelatedEntities("msdyn_upgraderun_PrincipalObjectAttributeAccesses", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'msdyn_upgraderun_ProcessSession'
        /// </summary>
		[RelationshipSchemaName("msdyn_upgraderun_ProcessSession")]
		public IEnumerable<ProcessSession> MsdynUpgraderunProcessSession
		{
			get { return GetRelatedEntities<ProcessSession>("msdyn_upgraderun_ProcessSession", null); }
			set { SetRelatedEntities("msdyn_upgraderun_ProcessSession", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'msdyn_upgraderun_SyncErrors'
        /// </summary>
		[RelationshipSchemaName("msdyn_upgraderun_SyncErrors")]
		public IEnumerable<SyncError> MsdynUpgraderunSyncErrors
		{
			get { return GetRelatedEntities<SyncError>("msdyn_upgraderun_SyncErrors", null); }
			set { SetRelatedEntities("msdyn_upgraderun_SyncErrors", null, value); }
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

			/// <summary>msdyn_error</summary>
			public const string Error = "msdyn_error";

			/// <summary>msdyn_finished</summary>
			public const string FinishedDate = "msdyn_finished";

			/// <summary>msdyn_package</summary>
			public const string PackageName = "msdyn_package";

			/// <summary>msdyn_solution</summary>
			public const string SolutionName = "msdyn_solution";

			/// <summary>msdyn_startingversion</summary>
			public const string StartingVersion = "msdyn_startingversion";

			/// <summary>msdyn_status</summary>
			public const string RunStatus = "msdyn_status";

			/// <summary>msdyn_summary</summary>
			public const string Summary = "msdyn_summary";

			/// <summary>msdyn_targetversion</summary>
			public const string TargetVersion = "msdyn_targetversion";

			/// <summary>msdyn_upgraderunid</summary>
			public const string UpgradeRunId = "msdyn_upgraderunid";

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
			/// <summary>1:N msdyn_msdyn_upgraderun_msdyn_upgradeversion_UpgradeRun</summary>
			public const string MsdynMsdynUpgraderunMsdynUpgradeversionUpgradeRun = "msdyn_msdyn_upgraderun_msdyn_upgradeversion_UpgradeRun";

			/// <summary>1:N msdyn_upgraderun_AsyncOperations</summary>
			public const string MsdynUpgraderunAsyncOperations = "msdyn_upgraderun_AsyncOperations";

			/// <summary>1:N msdyn_upgraderun_BulkDeleteFailures</summary>
			public const string MsdynUpgraderunBulkDeleteFailures = "msdyn_upgraderun_BulkDeleteFailures";

			/// <summary>1:N msdyn_upgraderun_MailboxTrackingFolders</summary>
			public const string MsdynUpgraderunMailboxTrackingFolders = "msdyn_upgraderun_MailboxTrackingFolders";

			/// <summary>1:N msdyn_upgraderun_PrincipalObjectAttributeAccesses</summary>
			public const string MsdynUpgraderunPrincipalObjectAttributeAccesses = "msdyn_upgraderun_PrincipalObjectAttributeAccesses";

			/// <summary>1:N msdyn_upgraderun_ProcessSession</summary>
			public const string MsdynUpgraderunProcessSession = "msdyn_upgraderun_ProcessSession";

			/// <summary>1:N msdyn_upgraderun_SyncErrors</summary>
			public const string MsdynUpgraderunSyncErrors = "msdyn_upgraderun_SyncErrors";

		}
		#endregion
	}
}

