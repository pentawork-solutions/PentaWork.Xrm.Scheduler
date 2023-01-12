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
	[EntityLogicalName("pw_schedule")]
	public sealed class PentaSchedule : Entity
	{	
		public static readonly int? EntityTypeCode = 10110;
		public new const string LogicalName = "pw_schedule";
		public const string PrimaryIdAttribute = "pw_scheduleid";
		public const string PrimaryNameAttribute = "pw_name";
	
		public PentaSchedule() : base("pw_schedule") { }

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
        /// pw_action
        /// </summary>
		[DisplayName("Action")]
		[AttributeLogicalName("pw_action")]
		public EntityReference Action
		{	
			get { return GetAttributeValue<EntityReference>("pw_action"); }
			set
			{ 
				if(value == Action) return;
				SetAttributeValue("pw_action", value);
			}
		}	
			
		/// <summary>
        /// pw_actionname
        /// </summary>
		[DisplayName("pw_actionname")]
		[AttributeLogicalName("pw_actionname")]
		public string PwActionname
		{	
			get { return GetAttributeValue<string>("pw_actionname"); }
			set
			{ 
				if(value == PwActionname) return;
				SetAttributeValue("pw_actionname", value);
			}
		}	
			
		/// <summary>
        /// pw_email_on_error
        /// </summary>
		[DisplayName("Email on error")]
		[AttributeLogicalName("pw_email_on_error")]
		public bool? EmailOnError
		{	
			get { return GetAttributeValue<bool?>("pw_email_on_error"); }
			set
			{ 
				if(value == EmailOnError) return;
				SetAttributeValue("pw_email_on_error", value);
			}
		}	
			
		/// <summary>
        /// pw_end_datetime
        /// </summary>
		[DisplayName("End DateTime")]
		[AttributeLogicalName("pw_end_datetime")]
		public DateTime? EndDateTime
		{	
			get { return GetAttributeValue<DateTime?>("pw_end_datetime"); }
			set
			{ 
				if(value == EndDateTime) return;
				SetAttributeValue("pw_end_datetime", value);
			}
		}	
			
		/// <summary>
        /// pw_error_email_address
        /// </summary>
		[DisplayName("Error Email Address")]
		[AttributeLogicalName("pw_error_email_address")]
		public string ErrorEmailAddress
		{	
			get { return GetAttributeValue<string>("pw_error_email_address"); }
			set
			{ 
				if(value == ErrorEmailAddress) return;
				SetAttributeValue("pw_error_email_address", value);
			}
		}	
			
		/// <summary>
        /// pw_error_threshold
        /// </summary>
		[DisplayName("Error Threshold")]
		[AttributeLogicalName("pw_error_threshold")]
		public int? ErrorThreshold
		{	
			get { return GetAttributeValue<int?>("pw_error_threshold"); }
			set
			{ 
				if(value == ErrorThreshold) return;
				SetAttributeValue("pw_error_threshold", value);
			}
		}	
			
		/// <summary>
        /// pw_fetch_xml
        /// </summary>
		[DisplayName("Fetch XML")]
		[AttributeLogicalName("pw_fetch_xml")]
		public string FetchXML
		{	
			get { return GetAttributeValue<string>("pw_fetch_xml"); }
			set
			{ 
				if(value == FetchXML) return;
				SetAttributeValue("pw_fetch_xml", value);
			}
		}	
			
		/// <summary>
        /// pw_frequency
        /// </summary>
		[DisplayName("Frequency")]
		[AttributeLogicalName("pw_frequency")]
		public egFrequency? Frequency
		{	
			get 
			{ 
				var optionSetValue = GetAttributeValue<OptionSetValue>("pw_frequency");
				if (optionSetValue != null) return (egFrequency)optionSetValue.Value;
				else return null;
			}
			set 
			{ 
				if(value == Frequency) return;

				OptionSetValue optionSetValue = null;
				if(value != null) optionSetValue = new OptionSetValue((int)value);
				SetAttributeValue("pw_frequency", optionSetValue); 
			}
		}

		/// <summary>
        /// pw_frequency_value
        /// </summary>
		[DisplayName("Frequency Value")]
		[AttributeLogicalName("pw_frequency_value")]
		public int? FrequencyValue
		{	
			get { return GetAttributeValue<int?>("pw_frequency_value"); }
			set
			{ 
				if(value == FrequencyValue) return;
				SetAttributeValue("pw_frequency_value", value);
			}
		}	
			
		/// <summary>
        /// pw_global_action
        /// </summary>
		[DisplayName("Global Action")]
		[AttributeLogicalName("pw_global_action")]
		public EntityReference GlobalAction
		{	
			get { return GetAttributeValue<EntityReference>("pw_global_action"); }
			set
			{ 
				if(value == GlobalAction) return;
				SetAttributeValue("pw_global_action", value);
			}
		}	
			
		/// <summary>
        /// pw_global_actionname
        /// </summary>
		[DisplayName("pw_global_actionname")]
		[AttributeLogicalName("pw_global_actionname")]
		public string PwGlobalActionname
		{	
			get { return GetAttributeValue<string>("pw_global_actionname"); }
			set
			{ 
				if(value == PwGlobalActionname) return;
				SetAttributeValue("pw_global_actionname", value);
			}
		}	
			
		/// <summary>
        /// pw_last_run_datetime
        /// </summary>
		[DisplayName("Last Run DateTime")]
		[AttributeLogicalName("pw_last_run_datetime")]
		public DateTime? LastRunDateTime
		{	
			get { return GetAttributeValue<DateTime?>("pw_last_run_datetime"); }
			set
			{ 
				if(value == LastRunDateTime) return;
				SetAttributeValue("pw_last_run_datetime", value);
			}
		}	
			
		/// <summary>
        /// pw_name
        /// </summary>
		[DisplayName("Name")]
		[AttributeLogicalName("pw_name")]
		public string Name
		{	
			get { return GetAttributeValue<string>("pw_name"); }
			set
			{ 
				if(value == Name) return;
				SetAttributeValue("pw_name", value);
			}
		}	
			
		/// <summary>
        /// pw_next_run
        /// </summary>
		[DisplayName("Next Run")]
		[AttributeLogicalName("pw_next_run")]
		public EntityReference NextRun
		{	
			get { return GetAttributeValue<EntityReference>("pw_next_run"); }
			set
			{ 
				if(value == NextRun) return;
				SetAttributeValue("pw_next_run", value);
			}
		}	
			
		/// <summary>
        /// pw_next_runname
        /// </summary>
		[DisplayName("pw_next_runname")]
		[AttributeLogicalName("pw_next_runname")]
		public string PwNextRunname
		{	
			get { return GetAttributeValue<string>("pw_next_runname"); }
			set
			{ 
				if(value == PwNextRunname) return;
				SetAttributeValue("pw_next_runname", value);
			}
		}	
			
		/// <summary>
        /// pw_page_size
        /// </summary>
		[DisplayName("Page Size")]
		[AttributeLogicalName("pw_page_size")]
		public int? PageSize
		{	
			get { return GetAttributeValue<int?>("pw_page_size"); }
			set
			{ 
				if(value == PageSize) return;
				SetAttributeValue("pw_page_size", value);
			}
		}	
			
		/// <summary>
        /// pw_retry_on_error
        /// </summary>
		[DisplayName("Retry on error")]
		[AttributeLogicalName("pw_retry_on_error")]
		public bool? RetryOnError
		{	
			get { return GetAttributeValue<bool?>("pw_retry_on_error"); }
			set
			{ 
				if(value == RetryOnError) return;
				SetAttributeValue("pw_retry_on_error", value);
			}
		}	
			
		/// <summary>
        /// pw_schedule_type
        /// </summary>
		[DisplayName("Schedule Type")]
		[AttributeLogicalName("pw_schedule_type")]
		public egScheduleType? ScheduleType
		{	
			get 
			{ 
				var optionSetValue = GetAttributeValue<OptionSetValue>("pw_schedule_type");
				if (optionSetValue != null) return (egScheduleType)optionSetValue.Value;
				else return null;
			}
			set 
			{ 
				if(value == ScheduleType) return;

				OptionSetValue optionSetValue = null;
				if(value != null) optionSetValue = new OptionSetValue((int)value);
				SetAttributeValue("pw_schedule_type", optionSetValue); 
			}
		}

		/// <summary>
        /// pw_scheduleid
        /// </summary>
		[DisplayName("Penta Schedule")]
		[AttributeLogicalName("pw_scheduleid")]
		public override Guid Id
		{
			get => base.Id;
			set { base.Id = value; SetAttributeValue("pw_scheduleid", value); }
		}

							/// <summary>
        /// pw_service_plugin
        /// </summary>
		[DisplayName("Schedule Plugin")]
		[AttributeLogicalName("pw_service_plugin")]
		public EntityReference SchedulePlugin
		{	
			get { return GetAttributeValue<EntityReference>("pw_service_plugin"); }
			set
			{ 
				if(value == SchedulePlugin) return;
				SetAttributeValue("pw_service_plugin", value);
			}
		}	
			
		/// <summary>
        /// pw_service_plugin_config
        /// </summary>
		[DisplayName("Schedule Plugin Config")]
		[AttributeLogicalName("pw_service_plugin_config")]
		public string SchedulePluginConfig
		{	
			get { return GetAttributeValue<string>("pw_service_plugin_config"); }
			set
			{ 
				if(value == SchedulePluginConfig) return;
				SetAttributeValue("pw_service_plugin_config", value);
			}
		}	
			
		/// <summary>
        /// pw_service_pluginname
        /// </summary>
		[DisplayName("pw_service_pluginname")]
		[AttributeLogicalName("pw_service_pluginname")]
		public string PwServicePluginname
		{	
			get { return GetAttributeValue<string>("pw_service_pluginname"); }
			set
			{ 
				if(value == PwServicePluginname) return;
				SetAttributeValue("pw_service_pluginname", value);
			}
		}	
			
		/// <summary>
        /// pw_start_datetime
        /// </summary>
		[DisplayName("Start DateTime")]
		[AttributeLogicalName("pw_start_datetime")]
		public DateTime? StartDateTime
		{	
			get { return GetAttributeValue<DateTime?>("pw_start_datetime"); }
			set
			{ 
				if(value == StartDateTime) return;
				SetAttributeValue("pw_start_datetime", value);
			}
		}	
			
		/// <summary>
        /// pw_workflow
        /// </summary>
		[DisplayName("Workflow")]
		[AttributeLogicalName("pw_workflow")]
		public EntityReference Workflow
		{	
			get { return GetAttributeValue<EntityReference>("pw_workflow"); }
			set
			{ 
				if(value == Workflow) return;
				SetAttributeValue("pw_workflow", value);
			}
		}	
			
		/// <summary>
        /// pw_workflowname
        /// </summary>
		[DisplayName("pw_workflowname")]
		[AttributeLogicalName("pw_workflowname")]
		public string PwWorkflowname
		{	
			get { return GetAttributeValue<string>("pw_workflowname"); }
			set
			{ 
				if(value == PwWorkflowname) return;
				SetAttributeValue("pw_workflowname", value);
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
        /// 1:N Get entities for 'pw_pw_schedule_pw_penta_schedule_run_penta_schedule'
        /// </summary>
		[RelationshipSchemaName("pw_pw_schedule_pw_penta_schedule_run_penta_schedule")]
		public IEnumerable<PentaScheduleRun> PwPwSchedulePwPentaScheduleRunPentaSchedule
		{
			get { return GetRelatedEntities<PentaScheduleRun>("pw_pw_schedule_pw_penta_schedule_run_penta_schedule", null); }
			set { SetRelatedEntities("pw_pw_schedule_pw_penta_schedule_run_penta_schedule", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'pw_schedule_AsyncOperations'
        /// </summary>
		[RelationshipSchemaName("pw_schedule_AsyncOperations")]
		public IEnumerable<SystemJob> PwScheduleAsyncOperations
		{
			get { return GetRelatedEntities<SystemJob>("pw_schedule_AsyncOperations", null); }
			set { SetRelatedEntities("pw_schedule_AsyncOperations", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'pw_schedule_BulkDeleteFailures'
        /// </summary>
		[RelationshipSchemaName("pw_schedule_BulkDeleteFailures")]
		public IEnumerable<BulkDeleteFailure> PwScheduleBulkDeleteFailures
		{
			get { return GetRelatedEntities<BulkDeleteFailure>("pw_schedule_BulkDeleteFailures", null); }
			set { SetRelatedEntities("pw_schedule_BulkDeleteFailures", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'pw_schedule_DuplicateBaseRecord'
        /// </summary>
		[RelationshipSchemaName("pw_schedule_DuplicateBaseRecord")]
		public IEnumerable<DuplicateRecord> PwScheduleDuplicateBaseRecord
		{
			get { return GetRelatedEntities<DuplicateRecord>("pw_schedule_DuplicateBaseRecord", null); }
			set { SetRelatedEntities("pw_schedule_DuplicateBaseRecord", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'pw_schedule_DuplicateMatchingRecord'
        /// </summary>
		[RelationshipSchemaName("pw_schedule_DuplicateMatchingRecord")]
		public IEnumerable<DuplicateRecord> PwScheduleDuplicateMatchingRecord
		{
			get { return GetRelatedEntities<DuplicateRecord>("pw_schedule_DuplicateMatchingRecord", null); }
			set { SetRelatedEntities("pw_schedule_DuplicateMatchingRecord", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'pw_schedule_MailboxTrackingFolders'
        /// </summary>
		[RelationshipSchemaName("pw_schedule_MailboxTrackingFolders")]
		public IEnumerable<MailboxAutoTrackingFolder> PwScheduleMailboxTrackingFolders
		{
			get { return GetRelatedEntities<MailboxAutoTrackingFolder>("pw_schedule_MailboxTrackingFolders", null); }
			set { SetRelatedEntities("pw_schedule_MailboxTrackingFolders", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'pw_schedule_PrincipalObjectAttributeAccesses'
        /// </summary>
		[RelationshipSchemaName("pw_schedule_PrincipalObjectAttributeAccesses")]
		public IEnumerable<FieldSharing> PwSchedulePrincipalObjectAttributeAccesses
		{
			get { return GetRelatedEntities<FieldSharing>("pw_schedule_PrincipalObjectAttributeAccesses", null); }
			set { SetRelatedEntities("pw_schedule_PrincipalObjectAttributeAccesses", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'pw_schedule_ProcessSession'
        /// </summary>
		[RelationshipSchemaName("pw_schedule_ProcessSession")]
		public IEnumerable<ProcessSession> PwScheduleProcessSession
		{
			get { return GetRelatedEntities<ProcessSession>("pw_schedule_ProcessSession", null); }
			set { SetRelatedEntities("pw_schedule_ProcessSession", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'pw_schedule_SyncErrors'
        /// </summary>
		[RelationshipSchemaName("pw_schedule_SyncErrors")]
		public IEnumerable<SyncError> PwScheduleSyncErrors
		{
			get { return GetRelatedEntities<SyncError>("pw_schedule_SyncErrors", null); }
			set { SetRelatedEntities("pw_schedule_SyncErrors", null, value); }
		}
		#endregion

		#region Actions
		#endregion

		#region OptionSetEnums
		public enum egFrequency
		{	
		
			[Label("Once")]
			[Description(@"")]
			Once = 266890000, 
		
			[Label("Hourly")]
			[Description(@"")]
			Hourly = 266890001, 
		
			[Label("Daily")]
			[Description(@"")]
			Daily = 266890002, 
		
			[Label("Weekly")]
			[Description(@"")]
			Weekly = 266890003, 
		
			[Label("Monthly")]
			[Description(@"")]
			Monthly = 266890011, 
		
			[Label("Quarterly")]
			[Description(@"")]
			Quarterly = 266890004, 
		
			[Label("Yearly")]
			[Description(@"")]
			Yearly = 266890005, 
		
			[Label("Every X Minutes")]
			[Description(@"")]
			EveryXMinutes = 266890006, 
		
			[Label("Every X Hours")]
			[Description(@"")]
			EveryXHours = 266890007, 
		
			[Label("Every X Days")]
			[Description(@"")]
			EveryXDays = 266890008, 
		
			[Label("Every X Weeks")]
			[Description(@"")]
			EveryXWeeks = 266890009, 
		
			[Label("Every X Months")]
			[Description(@"")]
			EveryXMonths = 266890010, 
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
		
			[Label("Draft")]
			[Description(@"")]
			Draft_Active = 266890000, 
		
			[Label("Active")]
			[Description(@"")]
			Active_Active = 1, 
		
			[Label("Retry")]
			[Description(@"")]
			Retry_Active = 266890003, 
		
			[Label("Ended")]
			[Description(@"")]
			Ended_Active = 266890001, 
		
			[Label("Error")]
			[Description(@"")]
			Error_Active = 266890002, 
		
			[Label("Inactive")]
			[Description(@"")]
			Inactive_Inactive = 2, 
		}
		
		public enum egScheduleType
		{	
		
			[Label("Action")]
			[Description(@"")]
			Action = 266890003, 
		
			[Label("Workflow")]
			[Description(@"")]
			Workflow = 266890002, 
		
			[Label("Global Action")]
			[Description(@"")]
			GlobalAction = 266890001, 
		
			[Label("Schedule Plugin")]
			[Description(@"")]
			SchedulePlugin = 266890004, 
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

			/// <summary>pw_action</summary>
			public const string Action = "pw_action";

			/// <summary>pw_actionname</summary>
			public const string PwActionname = "pw_actionname";

			/// <summary>pw_email_on_error</summary>
			public const string EmailOnError = "pw_email_on_error";

			/// <summary>pw_end_datetime</summary>
			public const string EndDateTime = "pw_end_datetime";

			/// <summary>pw_error_email_address</summary>
			public const string ErrorEmailAddress = "pw_error_email_address";

			/// <summary>pw_error_threshold</summary>
			public const string ErrorThreshold = "pw_error_threshold";

			/// <summary>pw_fetch_xml</summary>
			public const string FetchXML = "pw_fetch_xml";

			/// <summary>pw_frequency</summary>
			public const string Frequency = "pw_frequency";

			/// <summary>pw_frequency_value</summary>
			public const string FrequencyValue = "pw_frequency_value";

			/// <summary>pw_global_action</summary>
			public const string GlobalAction = "pw_global_action";

			/// <summary>pw_global_actionname</summary>
			public const string PwGlobalActionname = "pw_global_actionname";

			/// <summary>pw_last_run_datetime</summary>
			public const string LastRunDateTime = "pw_last_run_datetime";

			/// <summary>pw_name</summary>
			public const string Name = "pw_name";

			/// <summary>pw_next_run</summary>
			public const string NextRun = "pw_next_run";

			/// <summary>pw_next_runname</summary>
			public const string PwNextRunname = "pw_next_runname";

			/// <summary>pw_page_size</summary>
			public const string PageSize = "pw_page_size";

			/// <summary>pw_retry_on_error</summary>
			public const string RetryOnError = "pw_retry_on_error";

			/// <summary>pw_schedule_type</summary>
			public const string ScheduleType = "pw_schedule_type";

			/// <summary>pw_scheduleid</summary>
			public const string PentaScheduleId = "pw_scheduleid";

			/// <summary>pw_service_plugin</summary>
			public const string SchedulePlugin = "pw_service_plugin";

			/// <summary>pw_service_plugin_config</summary>
			public const string SchedulePluginConfig = "pw_service_plugin_config";

			/// <summary>pw_service_pluginname</summary>
			public const string PwServicePluginname = "pw_service_pluginname";

			/// <summary>pw_start_datetime</summary>
			public const string StartDateTime = "pw_start_datetime";

			/// <summary>pw_workflow</summary>
			public const string Workflow = "pw_workflow";

			/// <summary>pw_workflowname</summary>
			public const string PwWorkflowname = "pw_workflowname";

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
			/// <summary>1:N pw_pw_schedule_pw_penta_schedule_run_penta_schedule</summary>
			public const string PwPwSchedulePwPentaScheduleRunPentaSchedule = "pw_pw_schedule_pw_penta_schedule_run_penta_schedule";

			/// <summary>1:N pw_schedule_AsyncOperations</summary>
			public const string PwScheduleAsyncOperations = "pw_schedule_AsyncOperations";

			/// <summary>1:N pw_schedule_BulkDeleteFailures</summary>
			public const string PwScheduleBulkDeleteFailures = "pw_schedule_BulkDeleteFailures";

			/// <summary>1:N pw_schedule_DuplicateBaseRecord</summary>
			public const string PwScheduleDuplicateBaseRecord = "pw_schedule_DuplicateBaseRecord";

			/// <summary>1:N pw_schedule_DuplicateMatchingRecord</summary>
			public const string PwScheduleDuplicateMatchingRecord = "pw_schedule_DuplicateMatchingRecord";

			/// <summary>1:N pw_schedule_MailboxTrackingFolders</summary>
			public const string PwScheduleMailboxTrackingFolders = "pw_schedule_MailboxTrackingFolders";

			/// <summary>1:N pw_schedule_PrincipalObjectAttributeAccesses</summary>
			public const string PwSchedulePrincipalObjectAttributeAccesses = "pw_schedule_PrincipalObjectAttributeAccesses";

			/// <summary>1:N pw_schedule_ProcessSession</summary>
			public const string PwScheduleProcessSession = "pw_schedule_ProcessSession";

			/// <summary>1:N pw_schedule_SyncErrors</summary>
			public const string PwScheduleSyncErrors = "pw_schedule_SyncErrors";

		}
		#endregion
	}
}

