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
	[EntityLogicalName("activitymonitor")]
	public sealed class ActivityMonitor : Entity
	{	
		public static readonly int? EntityTypeCode = 10071;
		public new const string LogicalName = "activitymonitor";
		public const string PrimaryIdAttribute = "activitymonitorid";
		public const string PrimaryNameAttribute = "name";
	
		public ActivityMonitor() : base("activitymonitor") { }

		#region Attributes
		/// <summary>
        /// activitymonitorid
        /// </summary>
		[DisplayName("Activity monitor id")]
		[AttributeLogicalName("activitymonitorid")]
		public override Guid Id
		{
			get => base.Id;
			set { base.Id = value; SetAttributeValue("activitymonitorid", value); }
		}

							/// <summary>
        /// advancedsettings
        /// </summary>
		[DisplayName("Advanced settings")]
		[AttributeLogicalName("advancedsettings")]
		public string AdvancedSettings
		{	
			get { return GetAttributeValue<string>("advancedsettings"); }
			set
			{ 
				if(value == AdvancedSettings) return;
				SetAttributeValue("advancedsettings", value);
			}
		}	
			
		/// <summary>
        /// conditionid
        /// </summary>
		[DisplayName("Condition name")]
		[AttributeLogicalName("conditionid")]
		public EntityReference ConditionName
		{	
			get { return GetAttributeValue<EntityReference>("conditionid"); }
			set
			{ 
				if(value == ConditionName) return;
				SetAttributeValue("conditionid", value);
			}
		}	
			
		/// <summary>
        /// conditionidname
        /// </summary>
		[DisplayName("conditionidname")]
		[AttributeLogicalName("conditionidname")]
		public string Conditionidname
		{	
			get { return GetAttributeValue<string>("conditionidname"); }
			set
			{ 
				if(value == Conditionidname) return;
				SetAttributeValue("conditionidname", value);
			}
		}	
			
		/// <summary>
        /// contactcreatedbyrule
        /// </summary>
		[DisplayName("Contact created by rule")]
		[AttributeLogicalName("contactcreatedbyrule")]
		public bool? ContactCreatedByRule
		{	
			get { return GetAttributeValue<bool?>("contactcreatedbyrule"); }
			set
			{ 
				if(value == ContactCreatedByRule) return;
				SetAttributeValue("contactcreatedbyrule", value);
			}
		}	
			
		/// <summary>
        /// createdby
        /// </summary>
		[DisplayName("Created by")]
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
		[DisplayName("Evaluated on")]
		[AttributeLogicalName("createdon")]
		public DateTime? EvaluatedOn
		{	
			get { return GetAttributeValue<DateTime?>("createdon"); }
			set
			{ 
				if(value == EvaluatedOn) return;
				SetAttributeValue("createdon", value);
			}
		}	
			
		/// <summary>
        /// createdonbehalfby
        /// </summary>
		[DisplayName("Created by (Delegate)")]
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
        /// currentstate
        /// </summary>
		[DisplayName("Current state")]
		[AttributeLogicalName("currentstate")]
		public eCurrentState? CurrentState
		{	
			get 
			{ 
				var optionSetValue = GetAttributeValue<OptionSetValue>("currentstate");
				if (optionSetValue != null) return (eCurrentState)optionSetValue.Value;
				else return null;
			}
			set 
			{ 
				if(value == CurrentState) return;

				OptionSetValue optionSetValue = null;
				if(value != null) optionSetValue = new OptionSetValue((int)value);
				SetAttributeValue("currentstate", optionSetValue); 
			}
		}

		/// <summary>
        /// entitlementcheck
        /// </summary>
		[DisplayName("Entitlement check")]
		[AttributeLogicalName("entitlementcheck")]
		public bool? EntitlementCheck
		{	
			get { return GetAttributeValue<bool?>("entitlementcheck"); }
			set
			{ 
				if(value == EntitlementCheck) return;
				SetAttributeValue("entitlementcheck", value);
			}
		}	
			
		/// <summary>
        /// importsequencenumber
        /// </summary>
		[DisplayName("Import sequence number")]
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
		[DisplayName("Modified by")]
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
		[DisplayName("Modified by (Delegate)")]
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
        /// monitoredactivityitemid
        /// </summary>
		[DisplayName("Monitored activity item")]
		[AttributeLogicalName("monitoredactivityitemid")]
		public EntityReference MonitoredActivityItem
		{	
			get { return GetAttributeValue<EntityReference>("monitoredactivityitemid"); }
			set
			{ 
				if(value == MonitoredActivityItem) return;
				SetAttributeValue("monitoredactivityitemid", value);
			}
		}	
			
		/// <summary>
        /// monitoredactivityitemidname
        /// </summary>
		[DisplayName("monitoredactivityitemidname")]
		[AttributeLogicalName("monitoredactivityitemidname")]
		public string Monitoredactivityitemidname
		{	
			get { return GetAttributeValue<string>("monitoredactivityitemidname"); }
			set
			{ 
				if(value == Monitoredactivityitemidname) return;
				SetAttributeValue("monitoredactivityitemidname", value);
			}
		}	
			
		/// <summary>
        /// monitoredactivityitemidtype
        /// </summary>
		[DisplayName("Monitored activity type")]
		[AttributeLogicalName("monitoredactivityitemidtype")]
		public string MonitoredActivityType
		{	
			get { return GetAttributeValue<string>("monitoredactivityitemidtype"); }
			set
			{ 
				if(value == MonitoredActivityType) return;
				SetAttributeValue("monitoredactivityitemidtype", value);
			}
		}	
			
		/// <summary>
        /// name
        /// </summary>
		[DisplayName("Name")]
		[AttributeLogicalName("name")]
		public string Name
		{	
			get { return GetAttributeValue<string>("name"); }
			set
			{ 
				if(value == Name) return;
				SetAttributeValue("name", value);
			}
		}	
			
		/// <summary>
        /// overriddencreatedon
        /// </summary>
		[DisplayName("Record created on")]
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
		[DisplayName("Owning business unit")]
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
		[DisplayName("Owning team")]
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
		[DisplayName("Owning user")]
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
        /// reason
        /// </summary>
		[DisplayName("Reason")]
		[AttributeLogicalName("reason")]
		public eReason? Reason
		{	
			get 
			{ 
				var optionSetValue = GetAttributeValue<OptionSetValue>("reason");
				if (optionSetValue != null) return (eReason)optionSetValue.Value;
				else return null;
			}
			set 
			{ 
				if(value == Reason) return;

				OptionSetValue optionSetValue = null;
				if(value != null) optionSetValue = new OptionSetValue((int)value);
				SetAttributeValue("reason", optionSetValue); 
			}
		}

		/// <summary>
        /// ruleid
        /// </summary>
		[DisplayName("Rule name")]
		[AttributeLogicalName("ruleid")]
		public EntityReference RuleName
		{	
			get { return GetAttributeValue<EntityReference>("ruleid"); }
			set
			{ 
				if(value == RuleName) return;
				SetAttributeValue("ruleid", value);
			}
		}	
			
		/// <summary>
        /// ruleidname
        /// </summary>
		[DisplayName("ruleidname")]
		[AttributeLogicalName("ruleidname")]
		public string Ruleidname
		{	
			get { return GetAttributeValue<string>("ruleidname"); }
			set
			{ 
				if(value == Ruleidname) return;
				SetAttributeValue("ruleidname", value);
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
		[DisplayName("Time zone rule version number")]
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
		[DisplayName("UTC conversion time zone code")]
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
        /// 1:N Get entities for 'activitymonitor_AsyncOperations'
        /// </summary>
		[RelationshipSchemaName("activitymonitor_AsyncOperations")]
		public IEnumerable<SystemJob> ActivitymonitorAsyncOperations
		{
			get { return GetRelatedEntities<SystemJob>("activitymonitor_AsyncOperations", null); }
			set { SetRelatedEntities("activitymonitor_AsyncOperations", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'activitymonitor_BulkDeleteFailures'
        /// </summary>
		[RelationshipSchemaName("activitymonitor_BulkDeleteFailures")]
		public IEnumerable<BulkDeleteFailure> ActivitymonitorBulkDeleteFailures
		{
			get { return GetRelatedEntities<BulkDeleteFailure>("activitymonitor_BulkDeleteFailures", null); }
			set { SetRelatedEntities("activitymonitor_BulkDeleteFailures", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'activitymonitor_DuplicateBaseRecord'
        /// </summary>
		[RelationshipSchemaName("activitymonitor_DuplicateBaseRecord")]
		public IEnumerable<DuplicateRecord> ActivitymonitorDuplicateBaseRecord
		{
			get { return GetRelatedEntities<DuplicateRecord>("activitymonitor_DuplicateBaseRecord", null); }
			set { SetRelatedEntities("activitymonitor_DuplicateBaseRecord", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'activitymonitor_DuplicateMatchingRecord'
        /// </summary>
		[RelationshipSchemaName("activitymonitor_DuplicateMatchingRecord")]
		public IEnumerable<DuplicateRecord> ActivitymonitorDuplicateMatchingRecord
		{
			get { return GetRelatedEntities<DuplicateRecord>("activitymonitor_DuplicateMatchingRecord", null); }
			set { SetRelatedEntities("activitymonitor_DuplicateMatchingRecord", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'activitymonitor_MailboxTrackingFolders'
        /// </summary>
		[RelationshipSchemaName("activitymonitor_MailboxTrackingFolders")]
		public IEnumerable<MailboxAutoTrackingFolder> ActivitymonitorMailboxTrackingFolders
		{
			get { return GetRelatedEntities<MailboxAutoTrackingFolder>("activitymonitor_MailboxTrackingFolders", null); }
			set { SetRelatedEntities("activitymonitor_MailboxTrackingFolders", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'activitymonitor_PrincipalObjectAttributeAccesses'
        /// </summary>
		[RelationshipSchemaName("activitymonitor_PrincipalObjectAttributeAccesses")]
		public IEnumerable<FieldSharing> ActivitymonitorPrincipalObjectAttributeAccesses
		{
			get { return GetRelatedEntities<FieldSharing>("activitymonitor_PrincipalObjectAttributeAccesses", null); }
			set { SetRelatedEntities("activitymonitor_PrincipalObjectAttributeAccesses", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'activitymonitor_ProcessSession'
        /// </summary>
		[RelationshipSchemaName("activitymonitor_ProcessSession")]
		public IEnumerable<ProcessSession> ActivitymonitorProcessSession
		{
			get { return GetRelatedEntities<ProcessSession>("activitymonitor_ProcessSession", null); }
			set { SetRelatedEntities("activitymonitor_ProcessSession", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'activitymonitor_SyncErrors'
        /// </summary>
		[RelationshipSchemaName("activitymonitor_SyncErrors")]
		public IEnumerable<SyncError> ActivitymonitorSyncErrors
		{
			get { return GetRelatedEntities<SyncError>("activitymonitor_SyncErrors", null); }
			set { SetRelatedEntities("activitymonitor_SyncErrors", null, value); }
		}
		#endregion

		#region Actions
		#endregion

		#region OptionSetEnums
		public enum eCurrentState
		{	
		
			[Label("Ready for workflow")]
			[Description(@"")]
			ReadyForWorkflow = 0, 
		
			[Label("Ready for Power Automate")]
			[Description(@"")]
			ReadyForPowerAutomate = 1, 
		
			[Label("Failed")]
			[Description(@"")]
			Failed = 2, 
		
			[Label("Skipped")]
			[Description(@"")]
			Skipped = 3, 
		}
		
		public enum eReason
		{	
		
			[Label("--")]
			[Description(@"")]
			Empty = 0, 
		
			[Label("Unable to find the source data for this email.")]
			[Description(@"")]
			UnableToFindTheSourceDataForThisEmail = 1, 
		
			[Label("An existing entity is already connected with this record.")]
			[Description(@"")]
			AnExistingEntityIsAlreadyConnectedWithThisRecord = 2, 
		
			[Label("An active case is already connected with this record.")]
			[Description(@"")]
			AnActiveCaseIsAlreadyConnectedWithThisRecord = 3, 
		
			[Label("A resolved case is already connected with this record.")]
			[Description(@"")]
			AResolvedCaseIsAlreadyConnectedWithThisRecord = 4, 
		
			[Label("The rule requires a connected case to be resolved for a specific amount of time before creating a new one. This connected case has been resolved for less than the amount of time selected.")]
			[Description(@"")]
			TheRuleRequiresAConnectedCaseToBeResolvedForASpecificAmountOfTimeBeforeCreatingANewOneThisConnectedCaseHasBeenResolvedForLessThanTheAmountOfTimeSelected = 5, 
		
			[Label("No email sender is found.")]
			[Description(@"")]
			NoEmailSenderIsFound = 6, 
		
			[Label("Email is coming from an unknown sender.")]
			[Description(@"")]
			EmailIsComingFromAnUnknownSender = 7, 
		
			[Label("--")]
			[Description(@"")]
			Empty2 = 8, 
		
			[Label("A contact was not created for this sender. This can be that the rule owner doesn't have permission to create contacts.")]
			[Description(@"")]
			AContactWasNotCreatedForThisSenderThisCanBeThatTheRuleOwnerDoesntHavePermissionToCreateContacts = 9, 
		
			[Label("No valid entitlement for this email sender. The rule continued with any additional action selected, but skipped the primary action for this email sender.")]
			[Description(@"")]
			NoValidEntitlementForThisEmailSenderTheRuleContinuedWithAnyAdditionalActionSelectedButSkippedThePrimaryActionForThisEmailSender = 10, 
		
			[Label("No valid entitlement for this email sender.")]
			[Description(@"")]
			NoValidEntitlementForThisEmailSender = 11, 
		
			[Label("--")]
			[Description(@"")]
			Empty3 = 12, 
		
			[Label("The rule doesn’t have any conditions applicable to the record.")]
			[Description(@"")]
			TheRuleDoesntHaveAnyConditionsApplicableToTheRecord = 13, 
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
			/// <summary>activitymonitorid</summary>
			public const string ActivityMonitorId = "activitymonitorid";

			/// <summary>advancedsettings</summary>
			public const string AdvancedSettings = "advancedsettings";

			/// <summary>conditionid</summary>
			public const string ConditionName = "conditionid";

			/// <summary>conditionidname</summary>
			public const string Conditionidname = "conditionidname";

			/// <summary>contactcreatedbyrule</summary>
			public const string ContactCreatedByRule = "contactcreatedbyrule";

			/// <summary>createdby</summary>
			public const string CreatedBy = "createdby";

			/// <summary>createdbyname</summary>
			public const string Createdbyname = "createdbyname";

			/// <summary>createdbyyominame</summary>
			public const string Createdbyyominame = "createdbyyominame";

			/// <summary>createdon</summary>
			public const string EvaluatedOn = "createdon";

			/// <summary>createdonbehalfby</summary>
			public const string CreatedByDelegate = "createdonbehalfby";

			/// <summary>createdonbehalfbyname</summary>
			public const string Createdonbehalfbyname = "createdonbehalfbyname";

			/// <summary>createdonbehalfbyyominame</summary>
			public const string Createdonbehalfbyyominame = "createdonbehalfbyyominame";

			/// <summary>currentstate</summary>
			public const string CurrentState = "currentstate";

			/// <summary>entitlementcheck</summary>
			public const string EntitlementCheck = "entitlementcheck";

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

			/// <summary>monitoredactivityitemid</summary>
			public const string MonitoredActivityItem = "monitoredactivityitemid";

			/// <summary>monitoredactivityitemidname</summary>
			public const string Monitoredactivityitemidname = "monitoredactivityitemidname";

			/// <summary>monitoredactivityitemidtype</summary>
			public const string MonitoredActivityType = "monitoredactivityitemidtype";

			/// <summary>name</summary>
			public const string Name = "name";

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

			/// <summary>reason</summary>
			public const string Reason = "reason";

			/// <summary>ruleid</summary>
			public const string RuleName = "ruleid";

			/// <summary>ruleidname</summary>
			public const string Ruleidname = "ruleidname";

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
			/// <summary>1:N activitymonitor_AsyncOperations</summary>
			public const string ActivitymonitorAsyncOperations = "activitymonitor_AsyncOperations";

			/// <summary>1:N activitymonitor_BulkDeleteFailures</summary>
			public const string ActivitymonitorBulkDeleteFailures = "activitymonitor_BulkDeleteFailures";

			/// <summary>1:N activitymonitor_DuplicateBaseRecord</summary>
			public const string ActivitymonitorDuplicateBaseRecord = "activitymonitor_DuplicateBaseRecord";

			/// <summary>1:N activitymonitor_DuplicateMatchingRecord</summary>
			public const string ActivitymonitorDuplicateMatchingRecord = "activitymonitor_DuplicateMatchingRecord";

			/// <summary>1:N activitymonitor_MailboxTrackingFolders</summary>
			public const string ActivitymonitorMailboxTrackingFolders = "activitymonitor_MailboxTrackingFolders";

			/// <summary>1:N activitymonitor_PrincipalObjectAttributeAccesses</summary>
			public const string ActivitymonitorPrincipalObjectAttributeAccesses = "activitymonitor_PrincipalObjectAttributeAccesses";

			/// <summary>1:N activitymonitor_ProcessSession</summary>
			public const string ActivitymonitorProcessSession = "activitymonitor_ProcessSession";

			/// <summary>1:N activitymonitor_SyncErrors</summary>
			public const string ActivitymonitorSyncErrors = "activitymonitor_SyncErrors";

		}
		#endregion
	}
}

