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
	[EntityLogicalName("msdyn_postruleconfig")]
	public sealed class PostRuleConfiguration : Entity
	{	
		public static readonly int? EntityTypeCode = 10103;
		public new const string LogicalName = "msdyn_postruleconfig";
		public const string PrimaryIdAttribute = "msdyn_postruleconfigid";
		public const string PrimaryNameAttribute = "msdyn_name";
	
		public PostRuleConfiguration() : base("msdyn_postruleconfig") { }

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
        /// msdyn_formatid
        /// </summary>
		[DisplayName("Format ID")]
		[AttributeLogicalName("msdyn_formatid")]
		public string FormatID
		{	
			get { return GetAttributeValue<string>("msdyn_formatid"); }
			set
			{ 
				if(value == FormatID) return;
				SetAttributeValue("msdyn_formatid", value);
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
        /// msdyn_postconfigid
        /// </summary>
		[DisplayName("Post Entity Id")]
		[AttributeLogicalName("msdyn_postconfigid")]
		public EntityReference PostEntityId
		{	
			get { return GetAttributeValue<EntityReference>("msdyn_postconfigid"); }
			set
			{ 
				if(value == PostEntityId) return;
				SetAttributeValue("msdyn_postconfigid", value);
			}
		}	
			
		/// <summary>
        /// msdyn_postconfigidname
        /// </summary>
		[DisplayName("msdyn_postconfigidname")]
		[AttributeLogicalName("msdyn_postconfigidname")]
		public string MsdynPostconfigidname
		{	
			get { return GetAttributeValue<string>("msdyn_postconfigidname"); }
			set
			{ 
				if(value == MsdynPostconfigidname) return;
				SetAttributeValue("msdyn_postconfigidname", value);
			}
		}	
			
		/// <summary>
        /// msdyn_postruleconfigid
        /// </summary>
		[DisplayName("Post Rule Configuration Id")]
		[AttributeLogicalName("msdyn_postruleconfigid")]
		public override Guid Id
		{
			get => base.Id;
			set { base.Id = value; SetAttributeValue("msdyn_postruleconfigid", value); }
		}

							/// <summary>
        /// msdyn_posttoyammer
        /// </summary>
		[DisplayName("Post to Yammer Activity Stream")]
		[AttributeLogicalName("msdyn_posttoyammer")]
		public bool? PostToYammerActivityStream
		{	
			get { return GetAttributeValue<bool?>("msdyn_posttoyammer"); }
			set
			{ 
				if(value == PostToYammerActivityStream) return;
				SetAttributeValue("msdyn_posttoyammer", value);
			}
		}	
			
		/// <summary>
        /// msdyn_ruleid
        /// </summary>
		[DisplayName("Rule ID")]
		[AttributeLogicalName("msdyn_ruleid")]
		public string RuleID
		{	
			get { return GetAttributeValue<string>("msdyn_ruleid"); }
			set
			{ 
				if(value == RuleID) return;
				SetAttributeValue("msdyn_ruleid", value);
			}
		}	
			
		/// <summary>
        /// msdyn_rulesource
        /// </summary>
		[DisplayName("Rule Source")]
		[AttributeLogicalName("msdyn_rulesource")]
		public string RuleSource
		{	
			get { return GetAttributeValue<string>("msdyn_rulesource"); }
			set
			{ 
				if(value == RuleSource) return;
				SetAttributeValue("msdyn_rulesource", value);
			}
		}	
			
		/// <summary>
        /// msdyn_stepid
        /// </summary>
		[DisplayName("Step ID")]
		[AttributeLogicalName("msdyn_stepid")]
		public string StepID
		{	
			get { return GetAttributeValue<string>("msdyn_stepid"); }
			set
			{ 
				if(value == StepID) return;
				SetAttributeValue("msdyn_stepid", value);
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
        /// 1:N Get entities for 'msdyn_postruleconfig_AsyncOperations'
        /// </summary>
		[RelationshipSchemaName("msdyn_postruleconfig_AsyncOperations")]
		public IEnumerable<SystemJob> MsdynPostruleconfigAsyncOperations
		{
			get { return GetRelatedEntities<SystemJob>("msdyn_postruleconfig_AsyncOperations", null); }
			set { SetRelatedEntities("msdyn_postruleconfig_AsyncOperations", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'msdyn_postruleconfig_BulkDeleteFailures'
        /// </summary>
		[RelationshipSchemaName("msdyn_postruleconfig_BulkDeleteFailures")]
		public IEnumerable<BulkDeleteFailure> MsdynPostruleconfigBulkDeleteFailures
		{
			get { return GetRelatedEntities<BulkDeleteFailure>("msdyn_postruleconfig_BulkDeleteFailures", null); }
			set { SetRelatedEntities("msdyn_postruleconfig_BulkDeleteFailures", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'msdyn_postruleconfig_MailboxTrackingFolders'
        /// </summary>
		[RelationshipSchemaName("msdyn_postruleconfig_MailboxTrackingFolders")]
		public IEnumerable<MailboxAutoTrackingFolder> MsdynPostruleconfigMailboxTrackingFolders
		{
			get { return GetRelatedEntities<MailboxAutoTrackingFolder>("msdyn_postruleconfig_MailboxTrackingFolders", null); }
			set { SetRelatedEntities("msdyn_postruleconfig_MailboxTrackingFolders", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'msdyn_postruleconfig_PrincipalObjectAttributeAccesses'
        /// </summary>
		[RelationshipSchemaName("msdyn_postruleconfig_PrincipalObjectAttributeAccesses")]
		public IEnumerable<FieldSharing> MsdynPostruleconfigPrincipalObjectAttributeAccesses
		{
			get { return GetRelatedEntities<FieldSharing>("msdyn_postruleconfig_PrincipalObjectAttributeAccesses", null); }
			set { SetRelatedEntities("msdyn_postruleconfig_PrincipalObjectAttributeAccesses", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'msdyn_postruleconfig_ProcessSession'
        /// </summary>
		[RelationshipSchemaName("msdyn_postruleconfig_ProcessSession")]
		public IEnumerable<ProcessSession> MsdynPostruleconfigProcessSession
		{
			get { return GetRelatedEntities<ProcessSession>("msdyn_postruleconfig_ProcessSession", null); }
			set { SetRelatedEntities("msdyn_postruleconfig_ProcessSession", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'msdyn_postruleconfig_SyncErrors'
        /// </summary>
		[RelationshipSchemaName("msdyn_postruleconfig_SyncErrors")]
		public IEnumerable<SyncError> MsdynPostruleconfigSyncErrors
		{
			get { return GetRelatedEntities<SyncError>("msdyn_postruleconfig_SyncErrors", null); }
			set { SetRelatedEntities("msdyn_postruleconfig_SyncErrors", null, value); }
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

			/// <summary>msdyn_formatid</summary>
			public const string FormatID = "msdyn_formatid";

			/// <summary>msdyn_name</summary>
			public const string Name = "msdyn_name";

			/// <summary>msdyn_postconfigid</summary>
			public const string PostEntityId = "msdyn_postconfigid";

			/// <summary>msdyn_postconfigidname</summary>
			public const string MsdynPostconfigidname = "msdyn_postconfigidname";

			/// <summary>msdyn_postruleconfigid</summary>
			public const string PostRuleConfigurationId = "msdyn_postruleconfigid";

			/// <summary>msdyn_posttoyammer</summary>
			public const string PostToYammerActivityStream = "msdyn_posttoyammer";

			/// <summary>msdyn_ruleid</summary>
			public const string RuleID = "msdyn_ruleid";

			/// <summary>msdyn_rulesource</summary>
			public const string RuleSource = "msdyn_rulesource";

			/// <summary>msdyn_stepid</summary>
			public const string StepID = "msdyn_stepid";

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
			/// <summary>1:N msdyn_postruleconfig_AsyncOperations</summary>
			public const string MsdynPostruleconfigAsyncOperations = "msdyn_postruleconfig_AsyncOperations";

			/// <summary>1:N msdyn_postruleconfig_BulkDeleteFailures</summary>
			public const string MsdynPostruleconfigBulkDeleteFailures = "msdyn_postruleconfig_BulkDeleteFailures";

			/// <summary>1:N msdyn_postruleconfig_MailboxTrackingFolders</summary>
			public const string MsdynPostruleconfigMailboxTrackingFolders = "msdyn_postruleconfig_MailboxTrackingFolders";

			/// <summary>1:N msdyn_postruleconfig_PrincipalObjectAttributeAccesses</summary>
			public const string MsdynPostruleconfigPrincipalObjectAttributeAccesses = "msdyn_postruleconfig_PrincipalObjectAttributeAccesses";

			/// <summary>1:N msdyn_postruleconfig_ProcessSession</summary>
			public const string MsdynPostruleconfigProcessSession = "msdyn_postruleconfig_ProcessSession";

			/// <summary>1:N msdyn_postruleconfig_SyncErrors</summary>
			public const string MsdynPostruleconfigSyncErrors = "msdyn_postruleconfig_SyncErrors";

		}
		#endregion
	}
}

