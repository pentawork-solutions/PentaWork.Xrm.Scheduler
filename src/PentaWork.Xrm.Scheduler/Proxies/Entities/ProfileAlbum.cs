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
	[EntityLogicalName("msdyn_postalbum")]
	public sealed class ProfileAlbum : Entity
	{	
		public static readonly int? EntityTypeCode = 10101;
		public new const string LogicalName = "msdyn_postalbum";
		public const string PrimaryIdAttribute = "msdyn_postalbumid";
		public const string PrimaryNameAttribute = "msdyn_name";
	
		public ProfileAlbum() : base("msdyn_postalbum") { }

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
        /// msdyn_postalbumid
        /// </summary>
		[DisplayName("Profile Album")]
		[AttributeLogicalName("msdyn_postalbumid")]
		public override Guid Id
		{
			get => base.Id;
			set { base.Id = value; SetAttributeValue("msdyn_postalbumid", value); }
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
        /// 1:N Get entities for 'msdyn_postalbum_ActivityPointers'
        /// </summary>
		[RelationshipSchemaName("msdyn_postalbum_ActivityPointers")]
		public IEnumerable<Activity> MsdynPostalbumActivityPointers
		{
			get { return GetRelatedEntities<Activity>("msdyn_postalbum_ActivityPointers", null); }
			set { SetRelatedEntities("msdyn_postalbum_ActivityPointers", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'msdyn_postalbum_Annotations'
        /// </summary>
		[RelationshipSchemaName("msdyn_postalbum_Annotations")]
		public IEnumerable<Note> MsdynPostalbumAnnotations
		{
			get { return GetRelatedEntities<Note>("msdyn_postalbum_Annotations", null); }
			set { SetRelatedEntities("msdyn_postalbum_Annotations", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'msdyn_postalbum_Appointments'
        /// </summary>
		[RelationshipSchemaName("msdyn_postalbum_Appointments")]
		public IEnumerable<Appointment> MsdynPostalbumAppointments
		{
			get { return GetRelatedEntities<Appointment>("msdyn_postalbum_Appointments", null); }
			set { SetRelatedEntities("msdyn_postalbum_Appointments", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'msdyn_postalbum_AsyncOperations'
        /// </summary>
		[RelationshipSchemaName("msdyn_postalbum_AsyncOperations")]
		public IEnumerable<SystemJob> MsdynPostalbumAsyncOperations
		{
			get { return GetRelatedEntities<SystemJob>("msdyn_postalbum_AsyncOperations", null); }
			set { SetRelatedEntities("msdyn_postalbum_AsyncOperations", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'msdyn_postalbum_BulkDeleteFailures'
        /// </summary>
		[RelationshipSchemaName("msdyn_postalbum_BulkDeleteFailures")]
		public IEnumerable<BulkDeleteFailure> MsdynPostalbumBulkDeleteFailures
		{
			get { return GetRelatedEntities<BulkDeleteFailure>("msdyn_postalbum_BulkDeleteFailures", null); }
			set { SetRelatedEntities("msdyn_postalbum_BulkDeleteFailures", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'msdyn_postalbum_connections1'
        /// </summary>
		[RelationshipSchemaName("msdyn_postalbum_connections1")]
		public IEnumerable<Connection> MsdynPostalbumConnections1
		{
			get { return GetRelatedEntities<Connection>("msdyn_postalbum_connections1", null); }
			set { SetRelatedEntities("msdyn_postalbum_connections1", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'msdyn_postalbum_connections2'
        /// </summary>
		[RelationshipSchemaName("msdyn_postalbum_connections2")]
		public IEnumerable<Connection> MsdynPostalbumConnections2
		{
			get { return GetRelatedEntities<Connection>("msdyn_postalbum_connections2", null); }
			set { SetRelatedEntities("msdyn_postalbum_connections2", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'msdyn_postalbum_DuplicateBaseRecord'
        /// </summary>
		[RelationshipSchemaName("msdyn_postalbum_DuplicateBaseRecord")]
		public IEnumerable<DuplicateRecord> MsdynPostalbumDuplicateBaseRecord
		{
			get { return GetRelatedEntities<DuplicateRecord>("msdyn_postalbum_DuplicateBaseRecord", null); }
			set { SetRelatedEntities("msdyn_postalbum_DuplicateBaseRecord", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'msdyn_postalbum_DuplicateMatchingRecord'
        /// </summary>
		[RelationshipSchemaName("msdyn_postalbum_DuplicateMatchingRecord")]
		public IEnumerable<DuplicateRecord> MsdynPostalbumDuplicateMatchingRecord
		{
			get { return GetRelatedEntities<DuplicateRecord>("msdyn_postalbum_DuplicateMatchingRecord", null); }
			set { SetRelatedEntities("msdyn_postalbum_DuplicateMatchingRecord", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'msdyn_postalbum_Emails'
        /// </summary>
		[RelationshipSchemaName("msdyn_postalbum_Emails")]
		public IEnumerable<Email> MsdynPostalbumEmails
		{
			get { return GetRelatedEntities<Email>("msdyn_postalbum_Emails", null); }
			set { SetRelatedEntities("msdyn_postalbum_Emails", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'msdyn_postalbum_Faxes'
        /// </summary>
		[RelationshipSchemaName("msdyn_postalbum_Faxes")]
		public IEnumerable<Fax> MsdynPostalbumFaxes
		{
			get { return GetRelatedEntities<Fax>("msdyn_postalbum_Faxes", null); }
			set { SetRelatedEntities("msdyn_postalbum_Faxes", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'msdyn_postalbum_Letters'
        /// </summary>
		[RelationshipSchemaName("msdyn_postalbum_Letters")]
		public IEnumerable<Letter> MsdynPostalbumLetters
		{
			get { return GetRelatedEntities<Letter>("msdyn_postalbum_Letters", null); }
			set { SetRelatedEntities("msdyn_postalbum_Letters", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'msdyn_postalbum_MailboxTrackingFolders'
        /// </summary>
		[RelationshipSchemaName("msdyn_postalbum_MailboxTrackingFolders")]
		public IEnumerable<MailboxAutoTrackingFolder> MsdynPostalbumMailboxTrackingFolders
		{
			get { return GetRelatedEntities<MailboxAutoTrackingFolder>("msdyn_postalbum_MailboxTrackingFolders", null); }
			set { SetRelatedEntities("msdyn_postalbum_MailboxTrackingFolders", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'msdyn_postalbum_PhoneCalls'
        /// </summary>
		[RelationshipSchemaName("msdyn_postalbum_PhoneCalls")]
		public IEnumerable<PhoneCall> MsdynPostalbumPhoneCalls
		{
			get { return GetRelatedEntities<PhoneCall>("msdyn_postalbum_PhoneCalls", null); }
			set { SetRelatedEntities("msdyn_postalbum_PhoneCalls", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'msdyn_postalbum_PrincipalObjectAttributeAccesses'
        /// </summary>
		[RelationshipSchemaName("msdyn_postalbum_PrincipalObjectAttributeAccesses")]
		public IEnumerable<FieldSharing> MsdynPostalbumPrincipalObjectAttributeAccesses
		{
			get { return GetRelatedEntities<FieldSharing>("msdyn_postalbum_PrincipalObjectAttributeAccesses", null); }
			set { SetRelatedEntities("msdyn_postalbum_PrincipalObjectAttributeAccesses", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'msdyn_postalbum_ProcessSession'
        /// </summary>
		[RelationshipSchemaName("msdyn_postalbum_ProcessSession")]
		public IEnumerable<ProcessSession> MsdynPostalbumProcessSession
		{
			get { return GetRelatedEntities<ProcessSession>("msdyn_postalbum_ProcessSession", null); }
			set { SetRelatedEntities("msdyn_postalbum_ProcessSession", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'msdyn_postalbum_RecurringAppointmentMasters'
        /// </summary>
		[RelationshipSchemaName("msdyn_postalbum_RecurringAppointmentMasters")]
		public IEnumerable<RecurringAppointment> MsdynPostalbumRecurringAppointmentMasters
		{
			get { return GetRelatedEntities<RecurringAppointment>("msdyn_postalbum_RecurringAppointmentMasters", null); }
			set { SetRelatedEntities("msdyn_postalbum_RecurringAppointmentMasters", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'msdyn_postalbum_ServiceAppointments'
        /// </summary>
		[RelationshipSchemaName("msdyn_postalbum_ServiceAppointments")]
		public IEnumerable<ServiceActivity> MsdynPostalbumServiceAppointments
		{
			get { return GetRelatedEntities<ServiceActivity>("msdyn_postalbum_ServiceAppointments", null); }
			set { SetRelatedEntities("msdyn_postalbum_ServiceAppointments", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'msdyn_postalbum_SocialActivities'
        /// </summary>
		[RelationshipSchemaName("msdyn_postalbum_SocialActivities")]
		public IEnumerable<SocialActivity> MsdynPostalbumSocialActivities
		{
			get { return GetRelatedEntities<SocialActivity>("msdyn_postalbum_SocialActivities", null); }
			set { SetRelatedEntities("msdyn_postalbum_SocialActivities", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'msdyn_postalbum_SyncErrors'
        /// </summary>
		[RelationshipSchemaName("msdyn_postalbum_SyncErrors")]
		public IEnumerable<SyncError> MsdynPostalbumSyncErrors
		{
			get { return GetRelatedEntities<SyncError>("msdyn_postalbum_SyncErrors", null); }
			set { SetRelatedEntities("msdyn_postalbum_SyncErrors", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'msdyn_postalbum_Tasks'
        /// </summary>
		[RelationshipSchemaName("msdyn_postalbum_Tasks")]
		public IEnumerable<Task> MsdynPostalbumTasks
		{
			get { return GetRelatedEntities<Task>("msdyn_postalbum_Tasks", null); }
			set { SetRelatedEntities("msdyn_postalbum_Tasks", null, value); }
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

			/// <summary>msdyn_name</summary>
			public const string Name = "msdyn_name";

			/// <summary>msdyn_postalbumid</summary>
			public const string ProfileAlbumId = "msdyn_postalbumid";

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
			/// <summary>1:N msdyn_postalbum_ActivityPointers</summary>
			public const string MsdynPostalbumActivityPointers = "msdyn_postalbum_ActivityPointers";

			/// <summary>1:N msdyn_postalbum_Annotations</summary>
			public const string MsdynPostalbumAnnotations = "msdyn_postalbum_Annotations";

			/// <summary>1:N msdyn_postalbum_Appointments</summary>
			public const string MsdynPostalbumAppointments = "msdyn_postalbum_Appointments";

			/// <summary>1:N msdyn_postalbum_AsyncOperations</summary>
			public const string MsdynPostalbumAsyncOperations = "msdyn_postalbum_AsyncOperations";

			/// <summary>1:N msdyn_postalbum_BulkDeleteFailures</summary>
			public const string MsdynPostalbumBulkDeleteFailures = "msdyn_postalbum_BulkDeleteFailures";

			/// <summary>1:N msdyn_postalbum_connections1</summary>
			public const string MsdynPostalbumConnections1 = "msdyn_postalbum_connections1";

			/// <summary>1:N msdyn_postalbum_connections2</summary>
			public const string MsdynPostalbumConnections2 = "msdyn_postalbum_connections2";

			/// <summary>1:N msdyn_postalbum_DuplicateBaseRecord</summary>
			public const string MsdynPostalbumDuplicateBaseRecord = "msdyn_postalbum_DuplicateBaseRecord";

			/// <summary>1:N msdyn_postalbum_DuplicateMatchingRecord</summary>
			public const string MsdynPostalbumDuplicateMatchingRecord = "msdyn_postalbum_DuplicateMatchingRecord";

			/// <summary>1:N msdyn_postalbum_Emails</summary>
			public const string MsdynPostalbumEmails = "msdyn_postalbum_Emails";

			/// <summary>1:N msdyn_postalbum_Faxes</summary>
			public const string MsdynPostalbumFaxes = "msdyn_postalbum_Faxes";

			/// <summary>1:N msdyn_postalbum_Letters</summary>
			public const string MsdynPostalbumLetters = "msdyn_postalbum_Letters";

			/// <summary>1:N msdyn_postalbum_MailboxTrackingFolders</summary>
			public const string MsdynPostalbumMailboxTrackingFolders = "msdyn_postalbum_MailboxTrackingFolders";

			/// <summary>1:N msdyn_postalbum_PhoneCalls</summary>
			public const string MsdynPostalbumPhoneCalls = "msdyn_postalbum_PhoneCalls";

			/// <summary>1:N msdyn_postalbum_PrincipalObjectAttributeAccesses</summary>
			public const string MsdynPostalbumPrincipalObjectAttributeAccesses = "msdyn_postalbum_PrincipalObjectAttributeAccesses";

			/// <summary>1:N msdyn_postalbum_ProcessSession</summary>
			public const string MsdynPostalbumProcessSession = "msdyn_postalbum_ProcessSession";

			/// <summary>1:N msdyn_postalbum_RecurringAppointmentMasters</summary>
			public const string MsdynPostalbumRecurringAppointmentMasters = "msdyn_postalbum_RecurringAppointmentMasters";

			/// <summary>1:N msdyn_postalbum_ServiceAppointments</summary>
			public const string MsdynPostalbumServiceAppointments = "msdyn_postalbum_ServiceAppointments";

			/// <summary>1:N msdyn_postalbum_SocialActivities</summary>
			public const string MsdynPostalbumSocialActivities = "msdyn_postalbum_SocialActivities";

			/// <summary>1:N msdyn_postalbum_SyncErrors</summary>
			public const string MsdynPostalbumSyncErrors = "msdyn_postalbum_SyncErrors";

			/// <summary>1:N msdyn_postalbum_Tasks</summary>
			public const string MsdynPostalbumTasks = "msdyn_postalbum_Tasks";

		}
		#endregion
	}
}

