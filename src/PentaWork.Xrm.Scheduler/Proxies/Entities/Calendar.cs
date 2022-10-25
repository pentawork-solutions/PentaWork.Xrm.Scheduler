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
	[EntityLogicalName("calendar")]
	public sealed class Calendar : Entity
	{	
		public static readonly int? EntityTypeCode = 4003;
		public new const string LogicalName = "calendar";
		public const string PrimaryIdAttribute = "calendarid";
		public const string PrimaryNameAttribute = "name";
	
		public Calendar() : base("calendar") { }

		#region Attributes
		/// <summary>
        /// businessunitid
        /// </summary>
		[DisplayName("Business Unit")]
		[AttributeLogicalName("businessunitid")]
		public EntityReference BusinessUnit
		{	
			get { return GetAttributeValue<EntityReference>("businessunitid"); }
			set
			{ 
				if(value == BusinessUnit) return;
				SetAttributeValue("businessunitid", value);
			}
		}	
			
		/// <summary>
        /// businessunitidname
        /// </summary>
		[DisplayName("businessunitidname")]
		[AttributeLogicalName("businessunitidname")]
		public string Businessunitidname
		{	
			get { return GetAttributeValue<string>("businessunitidname"); }
			set
			{ 
				if(value == Businessunitidname) return;
				SetAttributeValue("businessunitidname", value);
			}
		}	
			
		/// <summary>
        /// calendarid
        /// </summary>
		[DisplayName("Calendar")]
		[AttributeLogicalName("calendarid")]
		public override Guid Id
		{
			get => base.Id;
			set { base.Id = value; SetAttributeValue("calendarid", value); }
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
        /// holidayschedulecalendarid
        /// </summary>
		[DisplayName("Holiday Schedule CalendarId")]
		[AttributeLogicalName("holidayschedulecalendarid")]
		public EntityReference HolidayScheduleCalendarId
		{	
			get { return GetAttributeValue<EntityReference>("holidayschedulecalendarid"); }
			set
			{ 
				if(value == HolidayScheduleCalendarId) return;
				SetAttributeValue("holidayschedulecalendarid", value);
			}
		}	
			
		/// <summary>
        /// holidayschedulecalendaridname
        /// </summary>
		[DisplayName("holidayschedulecalendaridname")]
		[AttributeLogicalName("holidayschedulecalendaridname")]
		public string Holidayschedulecalendaridname
		{	
			get { return GetAttributeValue<string>("holidayschedulecalendaridname"); }
			set
			{ 
				if(value == Holidayschedulecalendaridname) return;
				SetAttributeValue("holidayschedulecalendaridname", value);
			}
		}	
			
		/// <summary>
        /// isshared
        /// </summary>
		[DisplayName("Is Shared")]
		[AttributeLogicalName("isshared")]
		public bool? IsShared
		{	
			get { return GetAttributeValue<bool?>("isshared"); }
			set
			{ 
				if(value == IsShared) return;
				SetAttributeValue("isshared", value);
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
		[DisplayName("Organization")]
		[AttributeLogicalName("organizationid")]
		public EntityReference Organization
		{	
			get { return GetAttributeValue<EntityReference>("organizationid"); }
			set
			{ 
				if(value == Organization) return;
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
        /// primaryuserid
        /// </summary>
		[DisplayName("Primary User")]
		[AttributeLogicalName("primaryuserid")]
		public Guid PrimaryUserId
		{	
			get { return GetAttributeValue<Guid>("primaryuserid"); }
			set
			{ 
				if(value == PrimaryUserId) return;
				SetAttributeValue("primaryuserid", value);
			}
		}	
			
		/// <summary>
        /// type
        /// </summary>
		[DisplayName("Calendar type")]
		[AttributeLogicalName("type")]
		public eCalendarType? CalendarType
		{	
			get 
			{ 
				var optionSetValue = GetAttributeValue<OptionSetValue>("type");
				if (optionSetValue != null) return (eCalendarType)optionSetValue.Value;
				else return null;
			}
			set 
			{ 
				if(value == CalendarType) return;

				OptionSetValue optionSetValue = null;
				if(value != null) optionSetValue = new OptionSetValue((int)value);
				SetAttributeValue("type", optionSetValue); 
			}
		}

		/// <summary>
        /// versionnumber
        /// </summary>
		[DisplayName("versionnumber")]
		[AttributeLogicalName("versionnumber")]
		public int? Versionnumber
		{	
			get { return GetAttributeValue<int?>("versionnumber"); }
			set
			{ 
				if(value == Versionnumber) return;
				SetAttributeValue("versionnumber", value);
			}
		}	
			
		#endregion	

		#region Relations
			/// <summary>
        /// 1:N Get entities for 'BusinessUnit_Calendar'
        /// </summary>
		[RelationshipSchemaName("BusinessUnit_Calendar")]
		public IEnumerable<BusinessUnit> BusinessUnitCalendar
		{
			get { return GetRelatedEntities<BusinessUnit>("BusinessUnit_Calendar", null); }
			set { SetRelatedEntities("BusinessUnit_Calendar", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'Calendar_Annotation'
        /// </summary>
		[RelationshipSchemaName("Calendar_Annotation")]
		public IEnumerable<Note> CalendarAnnotation
		{
			get { return GetRelatedEntities<Note>("Calendar_Annotation", null); }
			set { SetRelatedEntities("Calendar_Annotation", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'Calendar_AsyncOperations'
        /// </summary>
		[RelationshipSchemaName("Calendar_AsyncOperations")]
		public IEnumerable<SystemJob> CalendarAsyncOperations
		{
			get { return GetRelatedEntities<SystemJob>("Calendar_AsyncOperations", null); }
			set { SetRelatedEntities("Calendar_AsyncOperations", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'calendar_bookableresources'
        /// </summary>
		[RelationshipSchemaName("calendar_bookableresources")]
		public IEnumerable<BookableResource> CalendarBookableresources
		{
			get { return GetRelatedEntities<BookableResource>("calendar_bookableresources", null); }
			set { SetRelatedEntities("calendar_bookableresources", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'Calendar_BulkDeleteFailures'
        /// </summary>
		[RelationshipSchemaName("Calendar_BulkDeleteFailures")]
		public IEnumerable<BulkDeleteFailure> CalendarBulkDeleteFailures
		{
			get { return GetRelatedEntities<BulkDeleteFailure>("Calendar_BulkDeleteFailures", null); }
			set { SetRelatedEntities("Calendar_BulkDeleteFailures", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'calendar_customercalendar_holidaycalendar'
        /// </summary>
		[RelationshipSchemaName("calendar_customercalendar_holidaycalendar")]
		public IEnumerable<Calendar> CalendarCustomercalendarHolidaycalendar
		{
			get { return GetRelatedEntities<Calendar>("calendar_customercalendar_holidaycalendar", null); }
			set { SetRelatedEntities("calendar_customercalendar_holidaycalendar", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'calendar_equipment'
        /// </summary>
		[RelationshipSchemaName("calendar_equipment")]
		public IEnumerable<FacilityEquipment> CalendarEquipment
		{
			get { return GetRelatedEntities<FacilityEquipment>("calendar_equipment", null); }
			set { SetRelatedEntities("calendar_equipment", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'calendar_organization'
        /// </summary>
		[RelationshipSchemaName("calendar_organization")]
		public IEnumerable<Organization> CalendarOrganization
		{
			get { return GetRelatedEntities<Organization>("calendar_organization", null); }
			set { SetRelatedEntities("calendar_organization", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'calendar_services'
        /// </summary>
		[RelationshipSchemaName("calendar_services")]
		public IEnumerable<Service> CalendarServices
		{
			get { return GetRelatedEntities<Service>("calendar_services", null); }
			set { SetRelatedEntities("calendar_services", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'calendar_slaitem'
        /// </summary>
		[RelationshipSchemaName("calendar_slaitem")]
		public IEnumerable<SLAItem> CalendarSlaitem
		{
			get { return GetRelatedEntities<SLAItem>("calendar_slaitem", null); }
			set { SetRelatedEntities("calendar_slaitem", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'calendar_system_users'
        /// </summary>
		[RelationshipSchemaName("calendar_system_users")]
		public IEnumerable<User> CalendarSystemUsers
		{
			get { return GetRelatedEntities<User>("calendar_system_users", null); }
			set { SetRelatedEntities("calendar_system_users", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'slabase_businesshoursid'
        /// </summary>
		[RelationshipSchemaName("slabase_businesshoursid")]
		public IEnumerable<SLA> SlabaseBusinesshoursid
		{
			get { return GetRelatedEntities<SLA>("slabase_businesshoursid", null); }
			set { SetRelatedEntities("slabase_businesshoursid", null, value); }
		}
		#endregion

		#region Actions
		#endregion

		#region OptionSetEnums
		public enum eCalendarType
		{	
		
			[Label("Default")]
			[Description(@"")]
			Default = 0, 
		
			[Label("Customer Service")]
			[Description(@"")]
			CustomerService = 1, 
		
			[Label("Holiday Schedule")]
			[Description(@"")]
			HolidaySchedule = 2, 
		
			[Label("Inner Calendar type")]
			[Description(@"")]
			InnerCalendarType = -1, 
		}
		
		#endregion	

		#region Properties
		public static class Properties 
		{
			/// <summary>businessunitid</summary>
			public const string BusinessUnit = "businessunitid";

			/// <summary>businessunitidname</summary>
			public const string Businessunitidname = "businessunitidname";

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

			/// <summary>holidayschedulecalendarid</summary>
			public const string HolidayScheduleCalendarId = "holidayschedulecalendarid";

			/// <summary>holidayschedulecalendaridname</summary>
			public const string Holidayschedulecalendaridname = "holidayschedulecalendaridname";

			/// <summary>isshared</summary>
			public const string IsShared = "isshared";

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
			public const string Organization = "organizationid";

			/// <summary>organizationidname</summary>
			public const string Organizationidname = "organizationidname";

			/// <summary>primaryuserid</summary>
			public const string PrimaryUserId = "primaryuserid";

			/// <summary>type</summary>
			public const string CalendarType = "type";

			/// <summary>versionnumber</summary>
			public const string Versionnumber = "versionnumber";

		}
		#endregion

		#region Schemas
		public static class Schemas 
		{
			/// <summary>1:N BusinessUnit_Calendar</summary>
			public const string BusinessUnitCalendar = "BusinessUnit_Calendar";

			/// <summary>1:N Calendar_Annotation</summary>
			public const string CalendarAnnotation = "Calendar_Annotation";

			/// <summary>1:N Calendar_AsyncOperations</summary>
			public const string CalendarAsyncOperations = "Calendar_AsyncOperations";

			/// <summary>1:N calendar_bookableresources</summary>
			public const string CalendarBookableresources = "calendar_bookableresources";

			/// <summary>1:N Calendar_BulkDeleteFailures</summary>
			public const string CalendarBulkDeleteFailures = "Calendar_BulkDeleteFailures";

			/// <summary>1:N calendar_customercalendar_holidaycalendar</summary>
			public const string CalendarCustomercalendarHolidaycalendar = "calendar_customercalendar_holidaycalendar";

			/// <summary>1:N calendar_equipment</summary>
			public const string CalendarEquipment = "calendar_equipment";

			/// <summary>1:N calendar_organization</summary>
			public const string CalendarOrganization = "calendar_organization";

			/// <summary>1:N calendar_services</summary>
			public const string CalendarServices = "calendar_services";

			/// <summary>1:N calendar_slaitem</summary>
			public const string CalendarSlaitem = "calendar_slaitem";

			/// <summary>1:N calendar_system_users</summary>
			public const string CalendarSystemUsers = "calendar_system_users";

			/// <summary>1:N slabase_businesshoursid</summary>
			public const string SlabaseBusinesshoursid = "slabase_businesshoursid";

		}
		#endregion
	}
}

