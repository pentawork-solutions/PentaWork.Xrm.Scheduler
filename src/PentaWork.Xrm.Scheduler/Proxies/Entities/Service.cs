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
	[EntityLogicalName("service")]
	public sealed class Service : Entity
	{	
		public static readonly int? EntityTypeCode = 4001;
		public new const string LogicalName = "service";
		public const string PrimaryIdAttribute = "serviceid";
		public const string PrimaryNameAttribute = "name";
	
		public Service() : base("service") { }

		#region Attributes
		/// <summary>
        /// anchoroffset
        /// </summary>
		[DisplayName("Anchor Offset")]
		[AttributeLogicalName("anchoroffset")]
		public int? AnchorOffset
		{	
			get { return GetAttributeValue<int?>("anchoroffset"); }
			set
			{ 
				if(value == AnchorOffset) return;
				SetAttributeValue("anchoroffset", value);
			}
		}	
			
		/// <summary>
        /// calendarid
        /// </summary>
		[DisplayName("Calendar")]
		[AttributeLogicalName("calendarid")]
		public Guid CalendarId
		{	
			get { return GetAttributeValue<Guid>("calendarid"); }
			set
			{ 
				if(value == CalendarId) return;
				SetAttributeValue("calendarid", value);
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
        /// description
        /// </summary>
		[DisplayName("Description")]
		[AttributeLogicalName("description")]
		public string Description
		{	
			get { return GetAttributeValue<string>("description"); }
			set
			{ 
				if(value == Description) return;
				SetAttributeValue("description", value);
			}
		}	
			
		/// <summary>
        /// duration
        /// </summary>
		[DisplayName("Duration")]
		[AttributeLogicalName("duration")]
		public int? Duration
		{	
			get { return GetAttributeValue<int?>("duration"); }
			set
			{ 
				if(value == Duration) return;
				SetAttributeValue("duration", value);
			}
		}	
			
		/// <summary>
        /// granularity
        /// </summary>
		[DisplayName("Granularity")]
		[AttributeLogicalName("granularity")]
		public string Granularity
		{	
			get { return GetAttributeValue<string>("granularity"); }
			set
			{ 
				if(value == Granularity) return;
				SetAttributeValue("granularity", value);
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
        /// initialstatuscode
        /// </summary>
		[DisplayName("Initial Status Reason")]
		[AttributeLogicalName("initialstatuscode")]
		public eInitialStatusReason? InitialStatusReason
		{	
			get 
			{ 
				var optionSetValue = GetAttributeValue<OptionSetValue>("initialstatuscode");
				if (optionSetValue != null) return (eInitialStatusReason)optionSetValue.Value;
				else return null;
			}
			set 
			{ 
				if(value == InitialStatusReason) return;

				OptionSetValue optionSetValue = null;
				if(value != null) optionSetValue = new OptionSetValue((int)value);
				SetAttributeValue("initialstatuscode", optionSetValue); 
			}
		}

		/// <summary>
        /// isschedulable
        /// </summary>
		[DisplayName("Status")]
		[AttributeLogicalName("isschedulable")]
		public bool? Status
		{	
			get { return GetAttributeValue<bool?>("isschedulable"); }
			set
			{ 
				if(value == Status) return;
				SetAttributeValue("isschedulable", value);
			}
		}	
			
		/// <summary>
        /// isvisible
        /// </summary>
		[DisplayName("Is Visible")]
		[AttributeLogicalName("isvisible")]
		public bool? IsVisible
		{	
			get { return GetAttributeValue<bool?>("isvisible"); }
			set
			{ 
				if(value == IsVisible) return;
				SetAttributeValue("isvisible", value);
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
        /// resourcespecid
        /// </summary>
		[DisplayName("Required Resources")]
		[AttributeLogicalName("resourcespecid")]
		public EntityReference RequiredResources
		{	
			get { return GetAttributeValue<EntityReference>("resourcespecid"); }
			set
			{ 
				if(value == RequiredResources) return;
				SetAttributeValue("resourcespecid", value);
			}
		}	
			
		/// <summary>
        /// resourcespecidname
        /// </summary>
		[DisplayName("resourcespecidname")]
		[AttributeLogicalName("resourcespecidname")]
		public string Resourcespecidname
		{	
			get { return GetAttributeValue<string>("resourcespecidname"); }
			set
			{ 
				if(value == Resourcespecidname) return;
				SetAttributeValue("resourcespecidname", value);
			}
		}	
			
		/// <summary>
        /// serviceid
        /// </summary>
		[DisplayName("Service")]
		[AttributeLogicalName("serviceid")]
		public override Guid Id
		{
			get => base.Id;
			set { base.Id = value; SetAttributeValue("serviceid", value); }
		}

							/// <summary>
        /// showresources
        /// </summary>
		[DisplayName("Show Resources")]
		[AttributeLogicalName("showresources")]
		public bool? ShowResources
		{	
			get { return GetAttributeValue<bool?>("showresources"); }
			set
			{ 
				if(value == ShowResources) return;
				SetAttributeValue("showresources", value);
			}
		}	
			
		/// <summary>
        /// strategyid
        /// </summary>
		[DisplayName("Strategy")]
		[AttributeLogicalName("strategyid")]
		public EntityReference Strategy
		{	
			get { return GetAttributeValue<EntityReference>("strategyid"); }
			set
			{ 
				if(value == Strategy) return;
				SetAttributeValue("strategyid", value);
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
        /// 1:N Get entities for 'service_accounts'
        /// </summary>
		[RelationshipSchemaName("service_accounts")]
		public IEnumerable<Account> ServiceAccounts
		{
			get { return GetRelatedEntities<Account>("service_accounts", null); }
			set { SetRelatedEntities("service_accounts", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'service_activity_pointers'
        /// </summary>
		[RelationshipSchemaName("service_activity_pointers")]
		public IEnumerable<Activity> ServiceActivityPointers
		{
			get { return GetRelatedEntities<Activity>("service_activity_pointers", null); }
			set { SetRelatedEntities("service_activity_pointers", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'Service_Annotation'
        /// </summary>
		[RelationshipSchemaName("Service_Annotation")]
		public IEnumerable<Note> ServiceAnnotation
		{
			get { return GetRelatedEntities<Note>("Service_Annotation", null); }
			set { SetRelatedEntities("Service_Annotation", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'service_appointments'
        /// </summary>
		[RelationshipSchemaName("service_appointments")]
		public IEnumerable<Appointment> ServiceAppointments
		{
			get { return GetRelatedEntities<Appointment>("service_appointments", null); }
			set { SetRelatedEntities("service_appointments", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'Service_AsyncOperations'
        /// </summary>
		[RelationshipSchemaName("Service_AsyncOperations")]
		public IEnumerable<SystemJob> ServiceAsyncOperations
		{
			get { return GetRelatedEntities<SystemJob>("Service_AsyncOperations", null); }
			set { SetRelatedEntities("Service_AsyncOperations", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'Service_BulkDeleteFailures'
        /// </summary>
		[RelationshipSchemaName("Service_BulkDeleteFailures")]
		public IEnumerable<BulkDeleteFailure> ServiceBulkDeleteFailures
		{
			get { return GetRelatedEntities<BulkDeleteFailure>("Service_BulkDeleteFailures", null); }
			set { SetRelatedEntities("Service_BulkDeleteFailures", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'service_contacts'
        /// </summary>
		[RelationshipSchemaName("service_contacts")]
		public IEnumerable<Contact> ServiceContacts
		{
			get { return GetRelatedEntities<Contact>("service_contacts", null); }
			set { SetRelatedEntities("service_contacts", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'Service_DuplicateBaseRecord'
        /// </summary>
		[RelationshipSchemaName("Service_DuplicateBaseRecord")]
		public IEnumerable<DuplicateRecord> ServiceDuplicateBaseRecord
		{
			get { return GetRelatedEntities<DuplicateRecord>("Service_DuplicateBaseRecord", null); }
			set { SetRelatedEntities("Service_DuplicateBaseRecord", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'Service_DuplicateMatchingRecord'
        /// </summary>
		[RelationshipSchemaName("Service_DuplicateMatchingRecord")]
		public IEnumerable<DuplicateRecord> ServiceDuplicateMatchingRecord
		{
			get { return GetRelatedEntities<DuplicateRecord>("Service_DuplicateMatchingRecord", null); }
			set { SetRelatedEntities("Service_DuplicateMatchingRecord", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'service_emails'
        /// </summary>
		[RelationshipSchemaName("service_emails")]
		public IEnumerable<Email> ServiceEmails
		{
			get { return GetRelatedEntities<Email>("service_emails", null); }
			set { SetRelatedEntities("service_emails", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'service_faxes'
        /// </summary>
		[RelationshipSchemaName("service_faxes")]
		public IEnumerable<Fax> ServiceFaxes
		{
			get { return GetRelatedEntities<Fax>("service_faxes", null); }
			set { SetRelatedEntities("service_faxes", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'service_incidentresolutions'
        /// </summary>
		[RelationshipSchemaName("service_incidentresolutions")]
		public IEnumerable<CaseResolution> ServiceIncidentresolutions
		{
			get { return GetRelatedEntities<CaseResolution>("service_incidentresolutions", null); }
			set { SetRelatedEntities("service_incidentresolutions", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'service_letters'
        /// </summary>
		[RelationshipSchemaName("service_letters")]
		public IEnumerable<Letter> ServiceLetters
		{
			get { return GetRelatedEntities<Letter>("service_letters", null); }
			set { SetRelatedEntities("service_letters", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'service_MailboxTrackingFolders'
        /// </summary>
		[RelationshipSchemaName("service_MailboxTrackingFolders")]
		public IEnumerable<MailboxAutoTrackingFolder> ServiceMailboxTrackingFolders
		{
			get { return GetRelatedEntities<MailboxAutoTrackingFolder>("service_MailboxTrackingFolders", null); }
			set { SetRelatedEntities("service_MailboxTrackingFolders", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'service_opportunityclose'
        /// </summary>
		[RelationshipSchemaName("service_opportunityclose")]
		public IEnumerable<OpportunityClose> ServiceOpportunityclose
		{
			get { return GetRelatedEntities<OpportunityClose>("service_opportunityclose", null); }
			set { SetRelatedEntities("service_opportunityclose", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'service_orderclose'
        /// </summary>
		[RelationshipSchemaName("service_orderclose")]
		public IEnumerable<OrderClose> ServiceOrderclose
		{
			get { return GetRelatedEntities<OrderClose>("service_orderclose", null); }
			set { SetRelatedEntities("service_orderclose", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'service_phonecalls'
        /// </summary>
		[RelationshipSchemaName("service_phonecalls")]
		public IEnumerable<PhoneCall> ServicePhonecalls
		{
			get { return GetRelatedEntities<PhoneCall>("service_phonecalls", null); }
			set { SetRelatedEntities("service_phonecalls", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'service_PrincipalObjectAttributeAccesses'
        /// </summary>
		[RelationshipSchemaName("service_PrincipalObjectAttributeAccesses")]
		public IEnumerable<FieldSharing> ServicePrincipalObjectAttributeAccesses
		{
			get { return GetRelatedEntities<FieldSharing>("service_PrincipalObjectAttributeAccesses", null); }
			set { SetRelatedEntities("service_PrincipalObjectAttributeAccesses", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'Service_ProcessSessions'
        /// </summary>
		[RelationshipSchemaName("Service_ProcessSessions")]
		public IEnumerable<ProcessSession> ServiceProcessSessions
		{
			get { return GetRelatedEntities<ProcessSession>("Service_ProcessSessions", null); }
			set { SetRelatedEntities("Service_ProcessSessions", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'service_quoteclose'
        /// </summary>
		[RelationshipSchemaName("service_quoteclose")]
		public IEnumerable<QuoteClose> ServiceQuoteclose
		{
			get { return GetRelatedEntities<QuoteClose>("service_quoteclose", null); }
			set { SetRelatedEntities("service_quoteclose", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'service_recurringappointmentmasters'
        /// </summary>
		[RelationshipSchemaName("service_recurringappointmentmasters")]
		public IEnumerable<RecurringAppointment> ServiceRecurringappointmentmasters
		{
			get { return GetRelatedEntities<RecurringAppointment>("service_recurringappointmentmasters", null); }
			set { SetRelatedEntities("service_recurringappointmentmasters", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'service_service_appointments'
        /// </summary>
		[RelationshipSchemaName("service_service_appointments")]
		public IEnumerable<ServiceActivity> ServiceServiceAppointments
		{
			get { return GetRelatedEntities<ServiceActivity>("service_service_appointments", null); }
			set { SetRelatedEntities("service_service_appointments", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'service_socialactivities'
        /// </summary>
		[RelationshipSchemaName("service_socialactivities")]
		public IEnumerable<SocialActivity> ServiceSocialactivities
		{
			get { return GetRelatedEntities<SocialActivity>("service_socialactivities", null); }
			set { SetRelatedEntities("service_socialactivities", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'Service_SyncErrors'
        /// </summary>
		[RelationshipSchemaName("Service_SyncErrors")]
		public IEnumerable<SyncError> ServiceSyncErrors
		{
			get { return GetRelatedEntities<SyncError>("Service_SyncErrors", null); }
			set { SetRelatedEntities("Service_SyncErrors", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'service_tasks'
        /// </summary>
		[RelationshipSchemaName("service_tasks")]
		public IEnumerable<Task> ServiceTasks
		{
			get { return GetRelatedEntities<Task>("service_tasks", null); }
			set { SetRelatedEntities("service_tasks", null, value); }
		}
		#endregion

		#region Actions
		#endregion

		#region OptionSetEnums
		public enum eInitialStatusReason
		{	
		
			[Label("Requested")]
			[Description(@"")]
			Requested_Active = 1, 
		
			[Label("Tentative")]
			[Description(@"")]
			Tentative_Active = 2, 
		
			[Label("Pending")]
			[Description(@"")]
			Pending_Active = 3, 
		
			[Label("Reserved")]
			[Description(@"")]
			Reserved_Active = 4, 
		
			[Label("In Progress")]
			[Description(@"")]
			InProgress_Active = 6, 
		
			[Label("Arrived")]
			[Description(@"")]
			Arrived_Active = 7, 
		
			[Label("Completed")]
			[Description(@"")]
			Completed_Inactive = 8, 
		
			[Label("Canceled")]
			[Description(@"")]
			Canceled = 9, 
		
			[Label("No Show")]
			[Description(@"")]
			NoShow = 10, 
		}
		
		#endregion	

		#region Properties
		public static class Properties 
		{
			/// <summary>anchoroffset</summary>
			public const string AnchorOffset = "anchoroffset";

			/// <summary>calendarid</summary>
			public const string CalendarId = "calendarid";

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

			/// <summary>description</summary>
			public const string Description = "description";

			/// <summary>duration</summary>
			public const string Duration = "duration";

			/// <summary>granularity</summary>
			public const string Granularity = "granularity";

			/// <summary>importsequencenumber</summary>
			public const string ImportSequenceNumber = "importsequencenumber";

			/// <summary>initialstatuscode</summary>
			public const string InitialStatusReason = "initialstatuscode";

			/// <summary>isschedulable</summary>
			public const string Status = "isschedulable";

			/// <summary>isvisible</summary>
			public const string IsVisible = "isvisible";

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

			/// <summary>name</summary>
			public const string Name = "name";

			/// <summary>organizationid</summary>
			public const string OrganizationId = "organizationid";

			/// <summary>organizationidname</summary>
			public const string Organizationidname = "organizationidname";

			/// <summary>overriddencreatedon</summary>
			public const string RecordCreatedOn = "overriddencreatedon";

			/// <summary>resourcespecid</summary>
			public const string RequiredResources = "resourcespecid";

			/// <summary>resourcespecidname</summary>
			public const string Resourcespecidname = "resourcespecidname";

			/// <summary>serviceid</summary>
			public const string ServiceId = "serviceid";

			/// <summary>showresources</summary>
			public const string ShowResources = "showresources";

			/// <summary>strategyid</summary>
			public const string Strategy = "strategyid";

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
			/// <summary>1:N service_accounts</summary>
			public const string ServiceAccounts = "service_accounts";

			/// <summary>1:N service_activity_pointers</summary>
			public const string ServiceActivityPointers = "service_activity_pointers";

			/// <summary>1:N Service_Annotation</summary>
			public const string ServiceAnnotation = "Service_Annotation";

			/// <summary>1:N service_appointments</summary>
			public const string ServiceAppointments = "service_appointments";

			/// <summary>1:N Service_AsyncOperations</summary>
			public const string ServiceAsyncOperations = "Service_AsyncOperations";

			/// <summary>1:N Service_BulkDeleteFailures</summary>
			public const string ServiceBulkDeleteFailures = "Service_BulkDeleteFailures";

			/// <summary>1:N service_contacts</summary>
			public const string ServiceContacts = "service_contacts";

			/// <summary>1:N Service_DuplicateBaseRecord</summary>
			public const string ServiceDuplicateBaseRecord = "Service_DuplicateBaseRecord";

			/// <summary>1:N Service_DuplicateMatchingRecord</summary>
			public const string ServiceDuplicateMatchingRecord = "Service_DuplicateMatchingRecord";

			/// <summary>1:N service_emails</summary>
			public const string ServiceEmails = "service_emails";

			/// <summary>1:N service_faxes</summary>
			public const string ServiceFaxes = "service_faxes";

			/// <summary>1:N service_incidentresolutions</summary>
			public const string ServiceIncidentresolutions = "service_incidentresolutions";

			/// <summary>1:N service_letters</summary>
			public const string ServiceLetters = "service_letters";

			/// <summary>1:N service_MailboxTrackingFolders</summary>
			public const string ServiceMailboxTrackingFolders = "service_MailboxTrackingFolders";

			/// <summary>1:N service_opportunityclose</summary>
			public const string ServiceOpportunityclose = "service_opportunityclose";

			/// <summary>1:N service_orderclose</summary>
			public const string ServiceOrderclose = "service_orderclose";

			/// <summary>1:N service_phonecalls</summary>
			public const string ServicePhonecalls = "service_phonecalls";

			/// <summary>1:N service_PrincipalObjectAttributeAccesses</summary>
			public const string ServicePrincipalObjectAttributeAccesses = "service_PrincipalObjectAttributeAccesses";

			/// <summary>1:N Service_ProcessSessions</summary>
			public const string ServiceProcessSessions = "Service_ProcessSessions";

			/// <summary>1:N service_quoteclose</summary>
			public const string ServiceQuoteclose = "service_quoteclose";

			/// <summary>1:N service_recurringappointmentmasters</summary>
			public const string ServiceRecurringappointmentmasters = "service_recurringappointmentmasters";

			/// <summary>1:N service_service_appointments</summary>
			public const string ServiceServiceAppointments = "service_service_appointments";

			/// <summary>1:N service_socialactivities</summary>
			public const string ServiceSocialactivities = "service_socialactivities";

			/// <summary>1:N Service_SyncErrors</summary>
			public const string ServiceSyncErrors = "Service_SyncErrors";

			/// <summary>1:N service_tasks</summary>
			public const string ServiceTasks = "service_tasks";

		}
		#endregion
	}
}

