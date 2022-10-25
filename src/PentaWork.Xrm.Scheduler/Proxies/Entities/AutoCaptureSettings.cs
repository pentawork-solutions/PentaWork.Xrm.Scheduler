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
	[EntityLogicalName("msdyn_autocapturesettings")]
	public sealed class AutoCaptureSettings : Entity
	{	
		public static readonly int? EntityTypeCode = 10093;
		public new const string LogicalName = "msdyn_autocapturesettings";
		public const string PrimaryIdAttribute = "msdyn_autocapturesettingsid";
		public const string PrimaryNameAttribute = "msdyn_name";
	
		public AutoCaptureSettings() : base("msdyn_autocapturesettings") { }

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
        /// msdyn_autocapture
        /// </summary>
		[DisplayName("Auto Capture")]
		[AttributeLogicalName("msdyn_autocapture")]
		public bool? AutoCapture
		{	
			get { return GetAttributeValue<bool?>("msdyn_autocapture"); }
			set
			{ 
				if(value == AutoCapture) return;
				SetAttributeValue("msdyn_autocapture", value);
			}
		}	
			
		/// <summary>
        /// msdyn_autocapturesettingsid
        /// </summary>
		[DisplayName("Auto Capture Settings")]
		[AttributeLogicalName("msdyn_autocapturesettingsid")]
		public override Guid Id
		{
			get => base.Id;
			set { base.Id = value; SetAttributeValue("msdyn_autocapturesettingsid", value); }
		}

							/// <summary>
        /// msdyn_autocapturev1
        /// </summary>
		[DisplayName("Auto Capture V1")]
		[AttributeLogicalName("msdyn_autocapturev1")]
		public bool? AutoCaptureV1
		{	
			get { return GetAttributeValue<bool?>("msdyn_autocapturev1"); }
			set
			{ 
				if(value == AutoCaptureV1) return;
				SetAttributeValue("msdyn_autocapturev1", value);
			}
		}	
			
		/// <summary>
        /// msdyn_automaticactivityupdate
        /// </summary>
		[DisplayName("Automatic Activity Update")]
		[AttributeLogicalName("msdyn_automaticactivityupdate")]
		public bool? AutomaticActivityUpdate
		{	
			get { return GetAttributeValue<bool?>("msdyn_automaticactivityupdate"); }
			set
			{ 
				if(value == AutomaticActivityUpdate) return;
				SetAttributeValue("msdyn_automaticactivityupdate", value);
			}
		}	
			
		/// <summary>
        /// msdyn_calendar
        /// </summary>
		[DisplayName("Calendar")]
		[AttributeLogicalName("msdyn_calendar")]
		public bool? Calendar
		{	
			get { return GetAttributeValue<bool?>("msdyn_calendar"); }
			set
			{ 
				if(value == Calendar) return;
				SetAttributeValue("msdyn_calendar", value);
			}
		}	
			
		/// <summary>
        /// msdyn_contacts
        /// </summary>
		[DisplayName("Contacts")]
		[AttributeLogicalName("msdyn_contacts")]
		public bool? Contacts
		{	
			get { return GetAttributeValue<bool?>("msdyn_contacts"); }
			set
			{ 
				if(value == Contacts) return;
				SetAttributeValue("msdyn_contacts", value);
			}
		}	
			
		/// <summary>
        /// msdyn_defaultassociation
        /// </summary>
		[DisplayName("Default Association")]
		[AttributeLogicalName("msdyn_defaultassociation")]
		public string DefaultAssociation
		{	
			get { return GetAttributeValue<string>("msdyn_defaultassociation"); }
			set
			{ 
				if(value == DefaultAssociation) return;
				SetAttributeValue("msdyn_defaultassociation", value);
			}
		}	
			
		/// <summary>
        /// msdyn_DontShowSettingStatus
        /// </summary>
		[DisplayName("Dont Show dialog Settings for suggestions")]
		[AttributeLogicalName("msdyn_DontShowSettingStatus")]
		public string DontShowDialogSettingsForSuggestions
		{	
			get { return GetAttributeValue<string>("msdyn_DontShowSettingStatus"); }
			set
			{ 
				if(value == DontShowDialogSettingsForSuggestions) return;
				SetAttributeValue("msdyn_DontShowSettingStatus", value);
			}
		}	
			
		/// <summary>
        /// msdyn_emails
        /// </summary>
		[DisplayName("Emails")]
		[AttributeLogicalName("msdyn_emails")]
		public bool? Emails
		{	
			get { return GetAttributeValue<bool?>("msdyn_emails"); }
			set
			{ 
				if(value == Emails) return;
				SetAttributeValue("msdyn_emails", value);
			}
		}	
			
		/// <summary>
        /// msdyn_meetings
        /// </summary>
		[DisplayName("Meetings")]
		[AttributeLogicalName("msdyn_meetings")]
		public bool? Meetings
		{	
			get { return GetAttributeValue<bool?>("msdyn_meetings"); }
			set
			{ 
				if(value == Meetings) return;
				SetAttributeValue("msdyn_meetings", value);
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
        /// msdyn_organizationid
        /// </summary>
		[DisplayName("Organization Id")]
		[AttributeLogicalName("msdyn_organizationid")]
		public string OrganizationId
		{	
			get { return GetAttributeValue<string>("msdyn_organizationid"); }
			set
			{ 
				if(value == OrganizationId) return;
				SetAttributeValue("msdyn_organizationid", value);
			}
		}	
			
		/// <summary>
        /// msdyn_settingsuiaction
        /// </summary>
		[DisplayName("SettingsUI Action")]
		[AttributeLogicalName("msdyn_settingsuiaction")]
		public string SettingsUIAction
		{	
			get { return GetAttributeValue<string>("msdyn_settingsuiaction"); }
			set
			{ 
				if(value == SettingsUIAction) return;
				SetAttributeValue("msdyn_settingsuiaction", value);
			}
		}	
			
		/// <summary>
        /// msdyn_userid
        /// </summary>
		[DisplayName("User Id")]
		[AttributeLogicalName("msdyn_userid")]
		public string UserId
		{	
			get { return GetAttributeValue<string>("msdyn_userid"); }
			set
			{ 
				if(value == UserId) return;
				SetAttributeValue("msdyn_userid", value);
			}
		}	
			
		/// <summary>
        /// msdyn_v1termsandconditionscount
        /// </summary>
		[DisplayName("V1 TERMS AND CONDITIONS COUNT")]
		[AttributeLogicalName("msdyn_v1termsandconditionscount")]
		public string V1TERMSANDCONDITIONSCOUNT
		{	
			get { return GetAttributeValue<string>("msdyn_v1termsandconditionscount"); }
			set
			{ 
				if(value == V1TERMSANDCONDITIONSCOUNT) return;
				SetAttributeValue("msdyn_v1termsandconditionscount", value);
			}
		}	
			
		/// <summary>
        /// msdyn_v2termsandconditionscount
        /// </summary>
		[DisplayName("V2 TERMS AND CONDITIONS COUNT")]
		[AttributeLogicalName("msdyn_v2termsandconditionscount")]
		public string V2TERMSANDCONDITIONSCOUNT
		{	
			get { return GetAttributeValue<string>("msdyn_v2termsandconditionscount"); }
			set
			{ 
				if(value == V2TERMSANDCONDITIONSCOUNT) return;
				SetAttributeValue("msdyn_v2termsandconditionscount", value);
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
        /// 1:N Get entities for 'msdyn_autocapturesettings_AsyncOperations'
        /// </summary>
		[RelationshipSchemaName("msdyn_autocapturesettings_AsyncOperations")]
		public IEnumerable<SystemJob> MsdynAutocapturesettingsAsyncOperations
		{
			get { return GetRelatedEntities<SystemJob>("msdyn_autocapturesettings_AsyncOperations", null); }
			set { SetRelatedEntities("msdyn_autocapturesettings_AsyncOperations", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'msdyn_autocapturesettings_BulkDeleteFailures'
        /// </summary>
		[RelationshipSchemaName("msdyn_autocapturesettings_BulkDeleteFailures")]
		public IEnumerable<BulkDeleteFailure> MsdynAutocapturesettingsBulkDeleteFailures
		{
			get { return GetRelatedEntities<BulkDeleteFailure>("msdyn_autocapturesettings_BulkDeleteFailures", null); }
			set { SetRelatedEntities("msdyn_autocapturesettings_BulkDeleteFailures", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'msdyn_autocapturesettings_DuplicateBaseRecord'
        /// </summary>
		[RelationshipSchemaName("msdyn_autocapturesettings_DuplicateBaseRecord")]
		public IEnumerable<DuplicateRecord> MsdynAutocapturesettingsDuplicateBaseRecord
		{
			get { return GetRelatedEntities<DuplicateRecord>("msdyn_autocapturesettings_DuplicateBaseRecord", null); }
			set { SetRelatedEntities("msdyn_autocapturesettings_DuplicateBaseRecord", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'msdyn_autocapturesettings_DuplicateMatchingRecord'
        /// </summary>
		[RelationshipSchemaName("msdyn_autocapturesettings_DuplicateMatchingRecord")]
		public IEnumerable<DuplicateRecord> MsdynAutocapturesettingsDuplicateMatchingRecord
		{
			get { return GetRelatedEntities<DuplicateRecord>("msdyn_autocapturesettings_DuplicateMatchingRecord", null); }
			set { SetRelatedEntities("msdyn_autocapturesettings_DuplicateMatchingRecord", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'msdyn_autocapturesettings_MailboxTrackingFolders'
        /// </summary>
		[RelationshipSchemaName("msdyn_autocapturesettings_MailboxTrackingFolders")]
		public IEnumerable<MailboxAutoTrackingFolder> MsdynAutocapturesettingsMailboxTrackingFolders
		{
			get { return GetRelatedEntities<MailboxAutoTrackingFolder>("msdyn_autocapturesettings_MailboxTrackingFolders", null); }
			set { SetRelatedEntities("msdyn_autocapturesettings_MailboxTrackingFolders", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'msdyn_autocapturesettings_PrincipalObjectAttributeAccesses'
        /// </summary>
		[RelationshipSchemaName("msdyn_autocapturesettings_PrincipalObjectAttributeAccesses")]
		public IEnumerable<FieldSharing> MsdynAutocapturesettingsPrincipalObjectAttributeAccesses
		{
			get { return GetRelatedEntities<FieldSharing>("msdyn_autocapturesettings_PrincipalObjectAttributeAccesses", null); }
			set { SetRelatedEntities("msdyn_autocapturesettings_PrincipalObjectAttributeAccesses", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'msdyn_autocapturesettings_ProcessSession'
        /// </summary>
		[RelationshipSchemaName("msdyn_autocapturesettings_ProcessSession")]
		public IEnumerable<ProcessSession> MsdynAutocapturesettingsProcessSession
		{
			get { return GetRelatedEntities<ProcessSession>("msdyn_autocapturesettings_ProcessSession", null); }
			set { SetRelatedEntities("msdyn_autocapturesettings_ProcessSession", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'msdyn_autocapturesettings_SyncErrors'
        /// </summary>
		[RelationshipSchemaName("msdyn_autocapturesettings_SyncErrors")]
		public IEnumerable<SyncError> MsdynAutocapturesettingsSyncErrors
		{
			get { return GetRelatedEntities<SyncError>("msdyn_autocapturesettings_SyncErrors", null); }
			set { SetRelatedEntities("msdyn_autocapturesettings_SyncErrors", null, value); }
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

			/// <summary>msdyn_autocapture</summary>
			public const string AutoCapture = "msdyn_autocapture";

			/// <summary>msdyn_autocapturesettingsid</summary>
			public const string AutoCaptureSettingsId = "msdyn_autocapturesettingsid";

			/// <summary>msdyn_autocapturev1</summary>
			public const string AutoCaptureV1 = "msdyn_autocapturev1";

			/// <summary>msdyn_automaticactivityupdate</summary>
			public const string AutomaticActivityUpdate = "msdyn_automaticactivityupdate";

			/// <summary>msdyn_calendar</summary>
			public const string Calendar = "msdyn_calendar";

			/// <summary>msdyn_contacts</summary>
			public const string Contacts = "msdyn_contacts";

			/// <summary>msdyn_defaultassociation</summary>
			public const string DefaultAssociation = "msdyn_defaultassociation";

			/// <summary>msdyn_DontShowSettingStatus</summary>
			public const string DontShowDialogSettingsForSuggestions = "msdyn_DontShowSettingStatus";

			/// <summary>msdyn_emails</summary>
			public const string Emails = "msdyn_emails";

			/// <summary>msdyn_meetings</summary>
			public const string Meetings = "msdyn_meetings";

			/// <summary>msdyn_name</summary>
			public const string Name = "msdyn_name";

			/// <summary>msdyn_organizationid</summary>
			public const string OrganizationId = "msdyn_organizationid";

			/// <summary>msdyn_settingsuiaction</summary>
			public const string SettingsUIAction = "msdyn_settingsuiaction";

			/// <summary>msdyn_userid</summary>
			public const string UserId = "msdyn_userid";

			/// <summary>msdyn_v1termsandconditionscount</summary>
			public const string V1TERMSANDCONDITIONSCOUNT = "msdyn_v1termsandconditionscount";

			/// <summary>msdyn_v2termsandconditionscount</summary>
			public const string V2TERMSANDCONDITIONSCOUNT = "msdyn_v2termsandconditionscount";

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
			/// <summary>1:N msdyn_autocapturesettings_AsyncOperations</summary>
			public const string MsdynAutocapturesettingsAsyncOperations = "msdyn_autocapturesettings_AsyncOperations";

			/// <summary>1:N msdyn_autocapturesettings_BulkDeleteFailures</summary>
			public const string MsdynAutocapturesettingsBulkDeleteFailures = "msdyn_autocapturesettings_BulkDeleteFailures";

			/// <summary>1:N msdyn_autocapturesettings_DuplicateBaseRecord</summary>
			public const string MsdynAutocapturesettingsDuplicateBaseRecord = "msdyn_autocapturesettings_DuplicateBaseRecord";

			/// <summary>1:N msdyn_autocapturesettings_DuplicateMatchingRecord</summary>
			public const string MsdynAutocapturesettingsDuplicateMatchingRecord = "msdyn_autocapturesettings_DuplicateMatchingRecord";

			/// <summary>1:N msdyn_autocapturesettings_MailboxTrackingFolders</summary>
			public const string MsdynAutocapturesettingsMailboxTrackingFolders = "msdyn_autocapturesettings_MailboxTrackingFolders";

			/// <summary>1:N msdyn_autocapturesettings_PrincipalObjectAttributeAccesses</summary>
			public const string MsdynAutocapturesettingsPrincipalObjectAttributeAccesses = "msdyn_autocapturesettings_PrincipalObjectAttributeAccesses";

			/// <summary>1:N msdyn_autocapturesettings_ProcessSession</summary>
			public const string MsdynAutocapturesettingsProcessSession = "msdyn_autocapturesettings_ProcessSession";

			/// <summary>1:N msdyn_autocapturesettings_SyncErrors</summary>
			public const string MsdynAutocapturesettingsSyncErrors = "msdyn_autocapturesettings_SyncErrors";

		}
		#endregion
	}
}

