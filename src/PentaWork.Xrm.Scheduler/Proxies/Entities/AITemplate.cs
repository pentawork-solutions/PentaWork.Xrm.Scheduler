using System;
using System.Linq;
using System.Diagnostics;
using System.ComponentModel;
using Microsoft.Xrm.Sdk; 
using Microsoft.Xrm.Sdk.Client;
using System.Collections.Generic;

namespace PentaWork.Xrm.Scheduler.Proxies.Entities
{
	[DebuggerDisplay("{UniqueName}")] 	
	[EntityLogicalName("msdyn_aitemplate")]
	public sealed class AITemplate : Entity
	{	
		public static readonly int? EntityTypeCode = 400;
		public new const string LogicalName = "msdyn_aitemplate";
		public const string PrimaryIdAttribute = "msdyn_aitemplateid";
		public const string PrimaryNameAttribute = "msdyn_uniquename";
	
		public AITemplate() : base("msdyn_aitemplate") { }

		#region Attributes
		/// <summary>
        /// componentstate
        /// </summary>
		[DisplayName("Component State")]
		[AttributeLogicalName("componentstate")]
		public egComponentState? ComponentState
		{	
			get 
			{ 
				var optionSetValue = GetAttributeValue<OptionSetValue>("componentstate");
				if (optionSetValue != null) return (egComponentState)optionSetValue.Value;
				else return null;
			}
			set 
			{ 
				if(value == ComponentState) return;

				OptionSetValue optionSetValue = null;
				if(value != null) optionSetValue = new OptionSetValue((int)value);
				SetAttributeValue("componentstate", optionSetValue); 
			}
		}

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
        /// introducedversion
        /// </summary>
		[DisplayName("Introduced Version")]
		[AttributeLogicalName("introducedversion")]
		public string IntroducedVersion
		{	
			get { return GetAttributeValue<string>("introducedversion"); }
			set
			{ 
				if(value == IntroducedVersion) return;
				SetAttributeValue("introducedversion", value);
			}
		}	
			
		/// <summary>
        /// ismanaged
        /// </summary>
		[DisplayName("Is Managed")]
		[AttributeLogicalName("ismanaged")]
		public bool? IsManaged
		{	
			get { return GetAttributeValue<bool?>("ismanaged"); }
			set
			{ 
				if(value == IsManaged) return;
				SetAttributeValue("ismanaged", value);
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
        /// msdyn_aitemplateid
        /// </summary>
		[DisplayName("AITemplate")]
		[AttributeLogicalName("msdyn_aitemplateid")]
		public override Guid Id
		{
			get => base.Id;
			set { base.Id = value; SetAttributeValue("msdyn_aitemplateid", value); }
		}

							/// <summary>
        /// msdyn_aitemplateidunique
        /// </summary>
		[DisplayName("msdyn_aitemplateidunique")]
		[AttributeLogicalName("msdyn_aitemplateidunique")]
		public Guid MsdynAitemplateiduniqueId
		{	
			get { return GetAttributeValue<Guid>("msdyn_aitemplateidunique"); }
			set
			{ 
				if(value == MsdynAitemplateiduniqueId) return;
				SetAttributeValue("msdyn_aitemplateidunique", value);
			}
		}	
			
		/// <summary>
        /// msdyn_databinding
        /// </summary>
		[DisplayName("DataBinding")]
		[AttributeLogicalName("msdyn_databinding")]
		public string DataBinding
		{	
			get { return GetAttributeValue<string>("msdyn_databinding"); }
			set
			{ 
				if(value == DataBinding) return;
				SetAttributeValue("msdyn_databinding", value);
			}
		}	
			
		/// <summary>
        /// msdyn_defaultrunschedulingoptions
        /// </summary>
		[DisplayName("DefaultRunSchedulingOptions")]
		[AttributeLogicalName("msdyn_defaultrunschedulingoptions")]
		public string DefaultRunSchedulingOptions
		{	
			get { return GetAttributeValue<string>("msdyn_defaultrunschedulingoptions"); }
			set
			{ 
				if(value == DefaultRunSchedulingOptions) return;
				SetAttributeValue("msdyn_defaultrunschedulingoptions", value);
			}
		}	
			
		/// <summary>
        /// msdyn_istrainable
        /// </summary>
		[DisplayName("IsTrainable")]
		[AttributeLogicalName("msdyn_istrainable")]
		public bool? IsTrainable
		{	
			get { return GetAttributeValue<bool?>("msdyn_istrainable"); }
			set
			{ 
				if(value == IsTrainable) return;
				SetAttributeValue("msdyn_istrainable", value);
			}
		}	
			
		/// <summary>
        /// msdyn_resourceinfo
        /// </summary>
		[DisplayName("ResourceInfo")]
		[AttributeLogicalName("msdyn_resourceinfo")]
		public string ResourceInfo
		{	
			get { return GetAttributeValue<string>("msdyn_resourceinfo"); }
			set
			{ 
				if(value == ResourceInfo) return;
				SetAttributeValue("msdyn_resourceinfo", value);
			}
		}	
			
		/// <summary>
        /// msdyn_runconfigschema
        /// </summary>
		[DisplayName("RunConfigSchema")]
		[AttributeLogicalName("msdyn_runconfigschema")]
		public string RunConfigSchema
		{	
			get { return GetAttributeValue<string>("msdyn_runconfigschema"); }
			set
			{ 
				if(value == RunConfigSchema) return;
				SetAttributeValue("msdyn_runconfigschema", value);
			}
		}	
			
		/// <summary>
        /// msdyn_rundataspecification
        /// </summary>
		[DisplayName("RunDataSpecification")]
		[AttributeLogicalName("msdyn_rundataspecification")]
		public string RunDataSpecification
		{	
			get { return GetAttributeValue<string>("msdyn_rundataspecification"); }
			set
			{ 
				if(value == RunDataSpecification) return;
				SetAttributeValue("msdyn_rundataspecification", value);
			}
		}	
			
		/// <summary>
        /// msdyn_templateversion
        /// </summary>
		[DisplayName("TemplateVersion")]
		[AttributeLogicalName("msdyn_templateversion")]
		public int? TemplateVersion
		{	
			get { return GetAttributeValue<int?>("msdyn_templateversion"); }
			set
			{ 
				if(value == TemplateVersion) return;
				SetAttributeValue("msdyn_templateversion", value);
			}
		}	
			
		/// <summary>
        /// msdyn_trainingconfigschema
        /// </summary>
		[DisplayName("TrainingConfigSchema")]
		[AttributeLogicalName("msdyn_trainingconfigschema")]
		public string TrainingConfigSchema
		{	
			get { return GetAttributeValue<string>("msdyn_trainingconfigschema"); }
			set
			{ 
				if(value == TrainingConfigSchema) return;
				SetAttributeValue("msdyn_trainingconfigschema", value);
			}
		}	
			
		/// <summary>
        /// msdyn_trainingdataspecification
        /// </summary>
		[DisplayName("TrainingDataSpecification")]
		[AttributeLogicalName("msdyn_trainingdataspecification")]
		public string TrainingDataSpecification
		{	
			get { return GetAttributeValue<string>("msdyn_trainingdataspecification"); }
			set
			{ 
				if(value == TrainingDataSpecification) return;
				SetAttributeValue("msdyn_trainingdataspecification", value);
			}
		}	
			
		/// <summary>
        /// msdyn_uniquename
        /// </summary>
		[DisplayName("UniqueName")]
		[AttributeLogicalName("msdyn_uniquename")]
		public string UniqueName
		{	
			get { return GetAttributeValue<string>("msdyn_uniquename"); }
			set
			{ 
				if(value == UniqueName) return;
				SetAttributeValue("msdyn_uniquename", value);
			}
		}	
			
		/// <summary>
        /// msdyn_uxconfiguration
        /// </summary>
		[DisplayName("UXConfiguration")]
		[AttributeLogicalName("msdyn_uxconfiguration")]
		public string UXConfiguration
		{	
			get { return GetAttributeValue<string>("msdyn_uxconfiguration"); }
			set
			{ 
				if(value == UXConfiguration) return;
				SetAttributeValue("msdyn_uxconfiguration", value);
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
        /// overwritetime
        /// </summary>
		[DisplayName("Record Overwrite Time")]
		[AttributeLogicalName("overwritetime")]
		public DateTime? RecordOverwriteTime
		{	
			get { return GetAttributeValue<DateTime?>("overwritetime"); }
			set
			{ 
				if(value == RecordOverwriteTime) return;
				SetAttributeValue("overwritetime", value);
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
        /// solutionid
        /// </summary>
		[DisplayName("Solution")]
		[AttributeLogicalName("solutionid")]
		public Guid SolutionId
		{	
			get { return GetAttributeValue<Guid>("solutionid"); }
			set
			{ 
				if(value == SolutionId) return;
				SetAttributeValue("solutionid", value);
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
        /// supportingsolutionid
        /// </summary>
		[DisplayName("Solution")]
		[AttributeLogicalName("supportingsolutionid")]
		public Guid SolutionId2
		{	
			get { return GetAttributeValue<Guid>("supportingsolutionid"); }
			set
			{ 
				if(value == SolutionId2) return;
				SetAttributeValue("supportingsolutionid", value);
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
        /// 1:N Get entities for 'msdyn_aitemplate_AsyncOperations'
        /// </summary>
		[RelationshipSchemaName("msdyn_aitemplate_AsyncOperations")]
		public IEnumerable<SystemJob> MsdynAitemplateAsyncOperations
		{
			get { return GetRelatedEntities<SystemJob>("msdyn_aitemplate_AsyncOperations", null); }
			set { SetRelatedEntities("msdyn_aitemplate_AsyncOperations", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'msdyn_aitemplate_BulkDeleteFailures'
        /// </summary>
		[RelationshipSchemaName("msdyn_aitemplate_BulkDeleteFailures")]
		public IEnumerable<BulkDeleteFailure> MsdynAitemplateBulkDeleteFailures
		{
			get { return GetRelatedEntities<BulkDeleteFailure>("msdyn_aitemplate_BulkDeleteFailures", null); }
			set { SetRelatedEntities("msdyn_aitemplate_BulkDeleteFailures", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'msdyn_aitemplate_MailboxTrackingFolders'
        /// </summary>
		[RelationshipSchemaName("msdyn_aitemplate_MailboxTrackingFolders")]
		public IEnumerable<MailboxAutoTrackingFolder> MsdynAitemplateMailboxTrackingFolders
		{
			get { return GetRelatedEntities<MailboxAutoTrackingFolder>("msdyn_aitemplate_MailboxTrackingFolders", null); }
			set { SetRelatedEntities("msdyn_aitemplate_MailboxTrackingFolders", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'msdyn_aitemplate_msdyn_aimodel'
        /// </summary>
		[RelationshipSchemaName("msdyn_aitemplate_msdyn_aimodel")]
		public IEnumerable<AIModel> MsdynAitemplateMsdynAimodel
		{
			get { return GetRelatedEntities<AIModel>("msdyn_aitemplate_msdyn_aimodel", null); }
			set { SetRelatedEntities("msdyn_aitemplate_msdyn_aimodel", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'msdyn_aitemplate_PrincipalObjectAttributeAccesses'
        /// </summary>
		[RelationshipSchemaName("msdyn_aitemplate_PrincipalObjectAttributeAccesses")]
		public IEnumerable<FieldSharing> MsdynAitemplatePrincipalObjectAttributeAccesses
		{
			get { return GetRelatedEntities<FieldSharing>("msdyn_aitemplate_PrincipalObjectAttributeAccesses", null); }
			set { SetRelatedEntities("msdyn_aitemplate_PrincipalObjectAttributeAccesses", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'msdyn_aitemplate_ProcessSession'
        /// </summary>
		[RelationshipSchemaName("msdyn_aitemplate_ProcessSession")]
		public IEnumerable<ProcessSession> MsdynAitemplateProcessSession
		{
			get { return GetRelatedEntities<ProcessSession>("msdyn_aitemplate_ProcessSession", null); }
			set { SetRelatedEntities("msdyn_aitemplate_ProcessSession", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'msdyn_aitemplate_SyncErrors'
        /// </summary>
		[RelationshipSchemaName("msdyn_aitemplate_SyncErrors")]
		public IEnumerable<SyncError> MsdynAitemplateSyncErrors
		{
			get { return GetRelatedEntities<SyncError>("msdyn_aitemplate_SyncErrors", null); }
			set { SetRelatedEntities("msdyn_aitemplate_SyncErrors", null, value); }
		}
		#endregion

		#region Actions
		#endregion

		#region OptionSetEnums
		public enum egComponentState
		{	
		
			[Label("Published")]
			[Description(@"")]
			Published = 0, 
		
			[Label("Unpublished")]
			[Description(@"")]
			Unpublished = 1, 
		
			[Label("Deleted")]
			[Description(@"")]
			Deleted = 2, 
		
			[Label("Deleted Unpublished")]
			[Description(@"")]
			DeletedUnpublished = 3, 
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
			/// <summary>componentstate</summary>
			public const string ComponentState = "componentstate";

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

			/// <summary>introducedversion</summary>
			public const string IntroducedVersion = "introducedversion";

			/// <summary>ismanaged</summary>
			public const string IsManaged = "ismanaged";

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

			/// <summary>msdyn_aitemplateid</summary>
			public const string AITemplateId = "msdyn_aitemplateid";

			/// <summary>msdyn_aitemplateidunique</summary>
			public const string MsdynAitemplateiduniqueId = "msdyn_aitemplateidunique";

			/// <summary>msdyn_databinding</summary>
			public const string DataBinding = "msdyn_databinding";

			/// <summary>msdyn_defaultrunschedulingoptions</summary>
			public const string DefaultRunSchedulingOptions = "msdyn_defaultrunschedulingoptions";

			/// <summary>msdyn_istrainable</summary>
			public const string IsTrainable = "msdyn_istrainable";

			/// <summary>msdyn_resourceinfo</summary>
			public const string ResourceInfo = "msdyn_resourceinfo";

			/// <summary>msdyn_runconfigschema</summary>
			public const string RunConfigSchema = "msdyn_runconfigschema";

			/// <summary>msdyn_rundataspecification</summary>
			public const string RunDataSpecification = "msdyn_rundataspecification";

			/// <summary>msdyn_templateversion</summary>
			public const string TemplateVersion = "msdyn_templateversion";

			/// <summary>msdyn_trainingconfigschema</summary>
			public const string TrainingConfigSchema = "msdyn_trainingconfigschema";

			/// <summary>msdyn_trainingdataspecification</summary>
			public const string TrainingDataSpecification = "msdyn_trainingdataspecification";

			/// <summary>msdyn_uniquename</summary>
			public const string UniqueName = "msdyn_uniquename";

			/// <summary>msdyn_uxconfiguration</summary>
			public const string UXConfiguration = "msdyn_uxconfiguration";

			/// <summary>overriddencreatedon</summary>
			public const string RecordCreatedOn = "overriddencreatedon";

			/// <summary>overwritetime</summary>
			public const string RecordOverwriteTime = "overwritetime";

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

			/// <summary>solutionid</summary>
			public const string SolutionId = "solutionid";

			/// <summary>statecode</summary>
			public const string Status = "statecode";

			/// <summary>statuscode</summary>
			public const string StatusReason = "statuscode";

			/// <summary>supportingsolutionid</summary>
			public const string SolutionId2 = "supportingsolutionid";

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
			/// <summary>1:N msdyn_aitemplate_AsyncOperations</summary>
			public const string MsdynAitemplateAsyncOperations = "msdyn_aitemplate_AsyncOperations";

			/// <summary>1:N msdyn_aitemplate_BulkDeleteFailures</summary>
			public const string MsdynAitemplateBulkDeleteFailures = "msdyn_aitemplate_BulkDeleteFailures";

			/// <summary>1:N msdyn_aitemplate_MailboxTrackingFolders</summary>
			public const string MsdynAitemplateMailboxTrackingFolders = "msdyn_aitemplate_MailboxTrackingFolders";

			/// <summary>1:N msdyn_aitemplate_msdyn_aimodel</summary>
			public const string MsdynAitemplateMsdynAimodel = "msdyn_aitemplate_msdyn_aimodel";

			/// <summary>1:N msdyn_aitemplate_PrincipalObjectAttributeAccesses</summary>
			public const string MsdynAitemplatePrincipalObjectAttributeAccesses = "msdyn_aitemplate_PrincipalObjectAttributeAccesses";

			/// <summary>1:N msdyn_aitemplate_ProcessSession</summary>
			public const string MsdynAitemplateProcessSession = "msdyn_aitemplate_ProcessSession";

			/// <summary>1:N msdyn_aitemplate_SyncErrors</summary>
			public const string MsdynAitemplateSyncErrors = "msdyn_aitemplate_SyncErrors";

		}
		#endregion
	}
}

