using System;
using System.Linq;
using System.Diagnostics;
using System.ComponentModel;
using Microsoft.Xrm.Sdk; 
using Microsoft.Xrm.Sdk.Client;
using System.Collections.Generic;

namespace PentaWork.Xrm.Scheduler.Proxies.Entities
{
	[DebuggerDisplay("{Subject}")] 	
	[EntityLogicalName("appointment")]
	public sealed class Appointment : Entity
	{	
		public static readonly int? EntityTypeCode = 4201;
		public new const string LogicalName = "appointment";
		public const string PrimaryIdAttribute = "activityid";
		public const string PrimaryNameAttribute = "subject";
	
		public Appointment() : base("appointment") { }

		#region Attributes
		/// <summary>
        /// activityadditionalparams
        /// </summary>
		[DisplayName("Additional Parameters")]
		[AttributeLogicalName("activityadditionalparams")]
		public string AdditionalParameters
		{	
			get { return GetAttributeValue<string>("activityadditionalparams"); }
			set
			{ 
				if(value == AdditionalParameters) return;
				SetAttributeValue("activityadditionalparams", value);
			}
		}	
			
		/// <summary>
        /// activityid
        /// </summary>
		[DisplayName("Appointment")]
		[AttributeLogicalName("activityid")]
		public override Guid Id
		{
			get => base.Id;
			set { base.Id = value; SetAttributeValue("activityid", value); }
		}

							/// <summary>
        /// activitytypecode
        /// </summary>
		[DisplayName("Activity Type")]
		[AttributeLogicalName("activitytypecode")]
		public string ActivityType
		{	
			get { return GetAttributeValue<string>("activitytypecode"); }
			set
			{ 
				if(value == ActivityType) return;
				SetAttributeValue("activitytypecode", value);
			}
		}	
			
		/// <summary>
        /// actualdurationminutes
        /// </summary>
		[DisplayName("Actual Duration")]
		[AttributeLogicalName("actualdurationminutes")]
		public int? ActualDuration
		{	
			get { return GetAttributeValue<int?>("actualdurationminutes"); }
			set
			{ 
				if(value == ActualDuration) return;
				SetAttributeValue("actualdurationminutes", value);
			}
		}	
			
		/// <summary>
        /// actualend
        /// </summary>
		[DisplayName("Actual End")]
		[AttributeLogicalName("actualend")]
		public DateTime? ActualEnd
		{	
			get { return GetAttributeValue<DateTime?>("actualend"); }
			set
			{ 
				if(value == ActualEnd) return;
				SetAttributeValue("actualend", value);
			}
		}	
			
		/// <summary>
        /// actualstart
        /// </summary>
		[DisplayName("Actual Start")]
		[AttributeLogicalName("actualstart")]
		public DateTime? ActualStart
		{	
			get { return GetAttributeValue<DateTime?>("actualstart"); }
			set
			{ 
				if(value == ActualStart) return;
				SetAttributeValue("actualstart", value);
			}
		}	
			
		/// <summary>
        /// attachmentcount
        /// </summary>
		[DisplayName("Attachment Count")]
		[AttributeLogicalName("attachmentcount")]
		public int? AttachmentCount
		{	
			get { return GetAttributeValue<int?>("attachmentcount"); }
			set
			{ 
				if(value == AttachmentCount) return;
				SetAttributeValue("attachmentcount", value);
			}
		}	
			
		/// <summary>
        /// attachmenterrors
        /// </summary>
		[DisplayName("AttachmentErrors")]
		[AttributeLogicalName("attachmenterrors")]
		public eAttachmentErrors? AttachmentErrors
		{	
			get 
			{ 
				var optionSetValue = GetAttributeValue<OptionSetValue>("attachmenterrors");
				if (optionSetValue != null) return (eAttachmentErrors)optionSetValue.Value;
				else return null;
			}
			set 
			{ 
				if(value == AttachmentErrors) return;

				OptionSetValue optionSetValue = null;
				if(value != null) optionSetValue = new OptionSetValue((int)value);
				SetAttributeValue("attachmenterrors", optionSetValue); 
			}
		}

		/// <summary>
        /// category
        /// </summary>
		[DisplayName("Category")]
		[AttributeLogicalName("category")]
		public string Category
		{	
			get { return GetAttributeValue<string>("category"); }
			set
			{ 
				if(value == Category) return;
				SetAttributeValue("category", value);
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
        /// exchangerate
		///
		/// Precision: 10
		/// MaxValue: 100000000000
		/// MinValue: 0.0000000001
        /// </summary>
		[DisplayName("Exchange Rate")]
		[AttributeLogicalName("exchangerate")]
		public decimal? ExchangeRate
		{	
			get { return GetAttributeValue<decimal?>("exchangerate"); }
			set 
			{
				decimal? decimalValue = null;
				if(value != null) decimalValue = Decimal.Round(value.Value, 10);
				if(decimalValue == ExchangeRate) return;
				SetAttributeValue("exchangerate", decimalValue);  
			}
		}

		/// <summary>
        /// globalobjectid
        /// </summary>
		[DisplayName("Outlook Appointment")]
		[AttributeLogicalName("globalobjectid")]
		public string OutlookAppointment
		{	
			get { return GetAttributeValue<string>("globalobjectid"); }
			set
			{ 
				if(value == OutlookAppointment) return;
				SetAttributeValue("globalobjectid", value);
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
        /// instancetypecode
        /// </summary>
		[DisplayName("Appointment Type")]
		[AttributeLogicalName("instancetypecode")]
		public eAppointmentType? AppointmentType
		{	
			get 
			{ 
				var optionSetValue = GetAttributeValue<OptionSetValue>("instancetypecode");
				if (optionSetValue != null) return (eAppointmentType)optionSetValue.Value;
				else return null;
			}
			set 
			{ 
				if(value == AppointmentType) return;

				OptionSetValue optionSetValue = null;
				if(value != null) optionSetValue = new OptionSetValue((int)value);
				SetAttributeValue("instancetypecode", optionSetValue); 
			}
		}

		/// <summary>
        /// isalldayevent
        /// </summary>
		[DisplayName("All Day Event")]
		[AttributeLogicalName("isalldayevent")]
		public bool? AllDayEvent
		{	
			get { return GetAttributeValue<bool?>("isalldayevent"); }
			set
			{ 
				if(value == AllDayEvent) return;
				SetAttributeValue("isalldayevent", value);
			}
		}	
			
		/// <summary>
        /// isbilled
        /// </summary>
		[DisplayName("Is Billed")]
		[AttributeLogicalName("isbilled")]
		public bool? IsBilled
		{	
			get { return GetAttributeValue<bool?>("isbilled"); }
			set
			{ 
				if(value == IsBilled) return;
				SetAttributeValue("isbilled", value);
			}
		}	
			
		/// <summary>
        /// isdraft
        /// </summary>
		[DisplayName("IsDraft")]
		[AttributeLogicalName("isdraft")]
		public bool? IsDraft
		{	
			get { return GetAttributeValue<bool?>("isdraft"); }
			set
			{ 
				if(value == IsDraft) return;
				SetAttributeValue("isdraft", value);
			}
		}	
			
		/// <summary>
        /// ismapiprivate
        /// </summary>
		[DisplayName("Is Private")]
		[AttributeLogicalName("ismapiprivate")]
		public bool? IsPrivate
		{	
			get { return GetAttributeValue<bool?>("ismapiprivate"); }
			set
			{ 
				if(value == IsPrivate) return;
				SetAttributeValue("ismapiprivate", value);
			}
		}	
			
		/// <summary>
        /// isregularactivity
        /// </summary>
		[DisplayName("Is Regular Activity")]
		[AttributeLogicalName("isregularactivity")]
		public bool? IsRegularActivity
		{	
			get { return GetAttributeValue<bool?>("isregularactivity"); }
			set
			{ 
				if(value == IsRegularActivity) return;
				SetAttributeValue("isregularactivity", value);
			}
		}	
			
		/// <summary>
        /// isunsafe
        /// </summary>
		[DisplayName("IsUnsafe")]
		[AttributeLogicalName("isunsafe")]
		public int? IsUnsafe
		{	
			get { return GetAttributeValue<int?>("isunsafe"); }
			set
			{ 
				if(value == IsUnsafe) return;
				SetAttributeValue("isunsafe", value);
			}
		}	
			
		/// <summary>
        /// isworkflowcreated
        /// </summary>
		[DisplayName("Is Workflow Created")]
		[AttributeLogicalName("isworkflowcreated")]
		public bool? IsWorkflowCreated
		{	
			get { return GetAttributeValue<bool?>("isworkflowcreated"); }
			set
			{ 
				if(value == IsWorkflowCreated) return;
				SetAttributeValue("isworkflowcreated", value);
			}
		}	
			
		/// <summary>
        /// lastonholdtime
        /// </summary>
		[DisplayName("Last On Hold Time")]
		[AttributeLogicalName("lastonholdtime")]
		public DateTime? LastOnHoldTime
		{	
			get { return GetAttributeValue<DateTime?>("lastonholdtime"); }
			set
			{ 
				if(value == LastOnHoldTime) return;
				SetAttributeValue("lastonholdtime", value);
			}
		}	
			
		/// <summary>
        /// location
        /// </summary>
		[DisplayName("Location")]
		[AttributeLogicalName("location")]
		public string Location
		{	
			get { return GetAttributeValue<string>("location"); }
			set
			{ 
				if(value == Location) return;
				SetAttributeValue("location", value);
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
        /// modifiedfieldsmask
        /// </summary>
		[DisplayName("Modified Fields Mask")]
		[AttributeLogicalName("modifiedfieldsmask")]
		public string ModifiedFieldsMask
		{	
			get { return GetAttributeValue<string>("modifiedfieldsmask"); }
			set
			{ 
				if(value == ModifiedFieldsMask) return;
				SetAttributeValue("modifiedfieldsmask", value);
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
        /// onholdtime
        /// </summary>
		[DisplayName("On Hold Time (Minutes)")]
		[AttributeLogicalName("onholdtime")]
		public int? OnHoldTimeMinutes
		{	
			get { return GetAttributeValue<int?>("onholdtime"); }
			set
			{ 
				if(value == OnHoldTimeMinutes) return;
				SetAttributeValue("onholdtime", value);
			}
		}	
			
		/// <summary>
        /// optionalattendees
        /// </summary>
		[DisplayName("Optional Attendees")]
		[AttributeLogicalName("optionalattendees")]
		public EntityCollection OptionalAttendees
		{	
			get { return GetAttributeValue<EntityCollection>("optionalattendees"); }
			set
			{ 
				if(value == OptionalAttendees) return;
				SetAttributeValue("optionalattendees", value);
			}
		}	
			
		/// <summary>
        /// organizer
        /// </summary>
		[DisplayName("Organizer")]
		[AttributeLogicalName("organizer")]
		public EntityCollection Organizer
		{	
			get { return GetAttributeValue<EntityCollection>("organizer"); }
			set
			{ 
				if(value == Organizer) return;
				SetAttributeValue("organizer", value);
			}
		}	
			
		/// <summary>
        /// originalstartdate
        /// </summary>
		[DisplayName("Original Start Date")]
		[AttributeLogicalName("originalstartdate")]
		public DateTime? OriginalStartDate
		{	
			get { return GetAttributeValue<DateTime?>("originalstartdate"); }
			set
			{ 
				if(value == OriginalStartDate) return;
				SetAttributeValue("originalstartdate", value);
			}
		}	
			
		/// <summary>
        /// outlookownerapptid
        /// </summary>
		[DisplayName("Outlook Appointment Owner")]
		[AttributeLogicalName("outlookownerapptid")]
		public int? OutlookAppointmentOwner
		{	
			get { return GetAttributeValue<int?>("outlookownerapptid"); }
			set
			{ 
				if(value == OutlookAppointmentOwner) return;
				SetAttributeValue("outlookownerapptid", value);
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
        /// prioritycode
        /// </summary>
		[DisplayName("Priority")]
		[AttributeLogicalName("prioritycode")]
		public ePriority? Priority
		{	
			get 
			{ 
				var optionSetValue = GetAttributeValue<OptionSetValue>("prioritycode");
				if (optionSetValue != null) return (ePriority)optionSetValue.Value;
				else return null;
			}
			set 
			{ 
				if(value == Priority) return;

				OptionSetValue optionSetValue = null;
				if(value != null) optionSetValue = new OptionSetValue((int)value);
				SetAttributeValue("prioritycode", optionSetValue); 
			}
		}

		/// <summary>
        /// processid
        /// </summary>
		[DisplayName("Process")]
		[AttributeLogicalName("processid")]
		public Guid ProcessId
		{	
			get { return GetAttributeValue<Guid>("processid"); }
			set
			{ 
				if(value == ProcessId) return;
				SetAttributeValue("processid", value);
			}
		}	
			
		/// <summary>
        /// regardingobjectid
        /// </summary>
		[DisplayName("Regarding")]
		[AttributeLogicalName("regardingobjectid")]
		public EntityReference Regarding
		{	
			get { return GetAttributeValue<EntityReference>("regardingobjectid"); }
			set
			{ 
				if(value == Regarding) return;
				SetAttributeValue("regardingobjectid", value);
			}
		}	
			
		/// <summary>
        /// regardingobjectidname
        /// </summary>
		[DisplayName("regardingobjectidname")]
		[AttributeLogicalName("regardingobjectidname")]
		public string Regardingobjectidname
		{	
			get { return GetAttributeValue<string>("regardingobjectidname"); }
			set
			{ 
				if(value == Regardingobjectidname) return;
				SetAttributeValue("regardingobjectidname", value);
			}
		}	
			
		/// <summary>
        /// regardingobjectidyominame
        /// </summary>
		[DisplayName("regardingobjectidyominame")]
		[AttributeLogicalName("regardingobjectidyominame")]
		public string Regardingobjectidyominame
		{	
			get { return GetAttributeValue<string>("regardingobjectidyominame"); }
			set
			{ 
				if(value == Regardingobjectidyominame) return;
				SetAttributeValue("regardingobjectidyominame", value);
			}
		}	
			
		/// <summary>
        /// regardingobjecttypecode
        /// </summary>
		[DisplayName("regardingobjecttypecode")]
		[AttributeLogicalName("regardingobjecttypecode")]
		public string Regardingobjecttypecode
		{	
			get { return GetAttributeValue<string>("regardingobjecttypecode"); }
			set
			{ 
				if(value == Regardingobjecttypecode) return;
				SetAttributeValue("regardingobjecttypecode", value);
			}
		}	
			
		/// <summary>
        /// requiredattendees
        /// </summary>
		[DisplayName("Required Attendees")]
		[AttributeLogicalName("requiredattendees")]
		public EntityCollection RequiredAttendees
		{	
			get { return GetAttributeValue<EntityCollection>("requiredattendees"); }
			set
			{ 
				if(value == RequiredAttendees) return;
				SetAttributeValue("requiredattendees", value);
			}
		}	
			
		/// <summary>
        /// safedescription
        /// </summary>
		[DisplayName("Safe Description")]
		[AttributeLogicalName("safedescription")]
		public string SafeDescription
		{	
			get { return GetAttributeValue<string>("safedescription"); }
			set
			{ 
				if(value == SafeDescription) return;
				SetAttributeValue("safedescription", value);
			}
		}	
			
		/// <summary>
        /// scheduleddurationminutes
        /// </summary>
		[DisplayName("Duration")]
		[AttributeLogicalName("scheduleddurationminutes")]
		public int? Duration
		{	
			get { return GetAttributeValue<int?>("scheduleddurationminutes"); }
			set
			{ 
				if(value == Duration) return;
				SetAttributeValue("scheduleddurationminutes", value);
			}
		}	
			
		/// <summary>
        /// scheduledend
        /// </summary>
		[DisplayName("End Time")]
		[AttributeLogicalName("scheduledend")]
		public DateTime? EndTime
		{	
			get { return GetAttributeValue<DateTime?>("scheduledend"); }
			set
			{ 
				if(value == EndTime) return;
				SetAttributeValue("scheduledend", value);
			}
		}	
			
		/// <summary>
        /// scheduledstart
        /// </summary>
		[DisplayName("Start Time")]
		[AttributeLogicalName("scheduledstart")]
		public DateTime? StartTime
		{	
			get { return GetAttributeValue<DateTime?>("scheduledstart"); }
			set
			{ 
				if(value == StartTime) return;
				SetAttributeValue("scheduledstart", value);
			}
		}	
			
		/// <summary>
        /// seriesid
        /// </summary>
		[DisplayName("Series Id")]
		[AttributeLogicalName("seriesid")]
		public Guid SeriesId
		{	
			get { return GetAttributeValue<Guid>("seriesid"); }
			set
			{ 
				if(value == SeriesId) return;
				SetAttributeValue("seriesid", value);
			}
		}	
			
		/// <summary>
        /// serviceid
        /// </summary>
		[DisplayName("Service")]
		[AttributeLogicalName("serviceid")]
		public EntityReference Service
		{	
			get { return GetAttributeValue<EntityReference>("serviceid"); }
			set
			{ 
				if(value == Service) return;
				SetAttributeValue("serviceid", value);
			}
		}	
			
		/// <summary>
        /// serviceidname
        /// </summary>
		[DisplayName("serviceidname")]
		[AttributeLogicalName("serviceidname")]
		public string Serviceidname
		{	
			get { return GetAttributeValue<string>("serviceidname"); }
			set
			{ 
				if(value == Serviceidname) return;
				SetAttributeValue("serviceidname", value);
			}
		}	
			
		/// <summary>
        /// slaid
        /// </summary>
		[DisplayName("SLA")]
		[AttributeLogicalName("slaid")]
		public EntityReference SLA
		{	
			get { return GetAttributeValue<EntityReference>("slaid"); }
			set
			{ 
				if(value == SLA) return;
				SetAttributeValue("slaid", value);
			}
		}	
			
		/// <summary>
        /// slainvokedid
        /// </summary>
		[DisplayName("Last SLA applied")]
		[AttributeLogicalName("slainvokedid")]
		public EntityReference LastSLAApplied
		{	
			get { return GetAttributeValue<EntityReference>("slainvokedid"); }
			set
			{ 
				if(value == LastSLAApplied) return;
				SetAttributeValue("slainvokedid", value);
			}
		}	
			
		/// <summary>
        /// slainvokedidname
        /// </summary>
		[DisplayName("slainvokedidname")]
		[AttributeLogicalName("slainvokedidname")]
		public string Slainvokedidname
		{	
			get { return GetAttributeValue<string>("slainvokedidname"); }
			set
			{ 
				if(value == Slainvokedidname) return;
				SetAttributeValue("slainvokedidname", value);
			}
		}	
			
		/// <summary>
        /// slaname
        /// </summary>
		[DisplayName("slaname")]
		[AttributeLogicalName("slaname")]
		public string Slaname
		{	
			get { return GetAttributeValue<string>("slaname"); }
			set
			{ 
				if(value == Slaname) return;
				SetAttributeValue("slaname", value);
			}
		}	
			
		/// <summary>
        /// sortdate
        /// </summary>
		[DisplayName("Sort Date")]
		[AttributeLogicalName("sortdate")]
		public DateTime? SortDate
		{	
			get { return GetAttributeValue<DateTime?>("sortdate"); }
			set
			{ 
				if(value == SortDate) return;
				SetAttributeValue("sortdate", value);
			}
		}	
			
		/// <summary>
        /// stageid
        /// </summary>
		[DisplayName("(Deprecated) Process Stage")]
		[AttributeLogicalName("stageid")]
		public Guid DeprecatedProcessStageId
		{	
			get { return GetAttributeValue<Guid>("stageid"); }
			set
			{ 
				if(value == DeprecatedProcessStageId) return;
				SetAttributeValue("stageid", value);
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
        /// subcategory
        /// </summary>
		[DisplayName("Sub-Category")]
		[AttributeLogicalName("subcategory")]
		public string SubCategory
		{	
			get { return GetAttributeValue<string>("subcategory"); }
			set
			{ 
				if(value == SubCategory) return;
				SetAttributeValue("subcategory", value);
			}
		}	
			
		/// <summary>
        /// subject
        /// </summary>
		[DisplayName("Subject")]
		[AttributeLogicalName("subject")]
		public string Subject
		{	
			get { return GetAttributeValue<string>("subject"); }
			set
			{ 
				if(value == Subject) return;
				SetAttributeValue("subject", value);
			}
		}	
			
		/// <summary>
        /// subscriptionid
        /// </summary>
		[DisplayName("Subscription")]
		[AttributeLogicalName("subscriptionid")]
		public Guid SubscriptionId
		{	
			get { return GetAttributeValue<Guid>("subscriptionid"); }
			set
			{ 
				if(value == SubscriptionId) return;
				SetAttributeValue("subscriptionid", value);
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
        /// transactioncurrencyid
        /// </summary>
		[DisplayName("Currency")]
		[AttributeLogicalName("transactioncurrencyid")]
		public EntityReference Currency
		{	
			get { return GetAttributeValue<EntityReference>("transactioncurrencyid"); }
			set
			{ 
				if(value == Currency) return;
				SetAttributeValue("transactioncurrencyid", value);
			}
		}	
			
		/// <summary>
        /// transactioncurrencyidname
        /// </summary>
		[DisplayName("transactioncurrencyidname")]
		[AttributeLogicalName("transactioncurrencyidname")]
		public string Transactioncurrencyidname
		{	
			get { return GetAttributeValue<string>("transactioncurrencyidname"); }
			set
			{ 
				if(value == Transactioncurrencyidname) return;
				SetAttributeValue("transactioncurrencyidname", value);
			}
		}	
			
		/// <summary>
        /// traversedpath
        /// </summary>
		[DisplayName("(Deprecated) Traversed Path")]
		[AttributeLogicalName("traversedpath")]
		public string DeprecatedTraversedPath
		{	
			get { return GetAttributeValue<string>("traversedpath"); }
			set
			{ 
				if(value == DeprecatedTraversedPath) return;
				SetAttributeValue("traversedpath", value);
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
        /// 1:N Get entities for 'appointment_actioncard'
        /// </summary>
		[RelationshipSchemaName("appointment_actioncard")]
		public IEnumerable<ActionCard> AppointmentActioncard
		{
			get { return GetRelatedEntities<ActionCard>("appointment_actioncard", null); }
			set { SetRelatedEntities("appointment_actioncard", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'appointment_activity_mime_attachment'
        /// </summary>
		[RelationshipSchemaName("appointment_activity_mime_attachment")]
		public IEnumerable<Attachment> AppointmentActivityMimeAttachment
		{
			get { return GetRelatedEntities<Attachment>("appointment_activity_mime_attachment", null); }
			set { SetRelatedEntities("appointment_activity_mime_attachment", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'appointment_activity_parties'
        /// </summary>
		[RelationshipSchemaName("appointment_activity_parties")]
		public IEnumerable<ActivityParty> AppointmentActivityParties
		{
			get { return GetRelatedEntities<ActivityParty>("appointment_activity_parties", null); }
			set { SetRelatedEntities("appointment_activity_parties", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'Appointment_Annotation'
        /// </summary>
		[RelationshipSchemaName("Appointment_Annotation")]
		public IEnumerable<Note> AppointmentAnnotation
		{
			get { return GetRelatedEntities<Note>("Appointment_Annotation", null); }
			set { SetRelatedEntities("Appointment_Annotation", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'Appointment_AsyncOperations'
        /// </summary>
		[RelationshipSchemaName("Appointment_AsyncOperations")]
		public IEnumerable<SystemJob> AppointmentAsyncOperations
		{
			get { return GetRelatedEntities<SystemJob>("Appointment_AsyncOperations", null); }
			set { SetRelatedEntities("Appointment_AsyncOperations", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'Appointment_BulkDeleteFailures'
        /// </summary>
		[RelationshipSchemaName("Appointment_BulkDeleteFailures")]
		public IEnumerable<BulkDeleteFailure> AppointmentBulkDeleteFailures
		{
			get { return GetRelatedEntities<BulkDeleteFailure>("Appointment_BulkDeleteFailures", null); }
			set { SetRelatedEntities("Appointment_BulkDeleteFailures", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'appointment_campaignresponse'
        /// </summary>
		[RelationshipSchemaName("appointment_campaignresponse")]
		public IEnumerable<CampaignResponse> AppointmentCampaignresponse
		{
			get { return GetRelatedEntities<CampaignResponse>("appointment_campaignresponse", null); }
			set { SetRelatedEntities("appointment_campaignresponse", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'appointment_connections1'
        /// </summary>
		[RelationshipSchemaName("appointment_connections1")]
		public IEnumerable<Connection> AppointmentConnections1
		{
			get { return GetRelatedEntities<Connection>("appointment_connections1", null); }
			set { SetRelatedEntities("appointment_connections1", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'appointment_connections2'
        /// </summary>
		[RelationshipSchemaName("appointment_connections2")]
		public IEnumerable<Connection> AppointmentConnections2
		{
			get { return GetRelatedEntities<Connection>("appointment_connections2", null); }
			set { SetRelatedEntities("appointment_connections2", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'Appointment_DuplicateBaseRecord'
        /// </summary>
		[RelationshipSchemaName("Appointment_DuplicateBaseRecord")]
		public IEnumerable<DuplicateRecord> AppointmentDuplicateBaseRecord
		{
			get { return GetRelatedEntities<DuplicateRecord>("Appointment_DuplicateBaseRecord", null); }
			set { SetRelatedEntities("Appointment_DuplicateBaseRecord", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'Appointment_DuplicateMatchingRecord'
        /// </summary>
		[RelationshipSchemaName("Appointment_DuplicateMatchingRecord")]
		public IEnumerable<DuplicateRecord> AppointmentDuplicateMatchingRecord
		{
			get { return GetRelatedEntities<DuplicateRecord>("Appointment_DuplicateMatchingRecord", null); }
			set { SetRelatedEntities("Appointment_DuplicateMatchingRecord", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'appointment_PostFollows'
        /// </summary>
		[RelationshipSchemaName("appointment_PostFollows")]
		public IEnumerable<Follow> AppointmentPostFollows
		{
			get { return GetRelatedEntities<Follow>("appointment_PostFollows", null); }
			set { SetRelatedEntities("appointment_PostFollows", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'appointment_principalobjectattributeaccess'
        /// </summary>
		[RelationshipSchemaName("appointment_principalobjectattributeaccess")]
		public IEnumerable<FieldSharing> AppointmentPrincipalobjectattributeaccess
		{
			get { return GetRelatedEntities<FieldSharing>("appointment_principalobjectattributeaccess", null); }
			set { SetRelatedEntities("appointment_principalobjectattributeaccess", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'Appointment_ProcessSessions'
        /// </summary>
		[RelationshipSchemaName("Appointment_ProcessSessions")]
		public IEnumerable<ProcessSession> AppointmentProcessSessions
		{
			get { return GetRelatedEntities<ProcessSession>("Appointment_ProcessSessions", null); }
			set { SetRelatedEntities("Appointment_ProcessSessions", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'Appointment_QueueItem'
        /// </summary>
		[RelationshipSchemaName("Appointment_QueueItem")]
		public IEnumerable<QueueItem> AppointmentQueueItem
		{
			get { return GetRelatedEntities<QueueItem>("Appointment_QueueItem", null); }
			set { SetRelatedEntities("Appointment_QueueItem", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'Appointment_SyncErrors'
        /// </summary>
		[RelationshipSchemaName("Appointment_SyncErrors")]
		public IEnumerable<SyncError> AppointmentSyncErrors
		{
			get { return GetRelatedEntities<SyncError>("Appointment_SyncErrors", null); }
			set { SetRelatedEntities("Appointment_SyncErrors", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'slakpiinstance_appointment'
        /// </summary>
		[RelationshipSchemaName("slakpiinstance_appointment")]
		public IEnumerable<SLAKPIInstance> SlakpiinstanceAppointment
		{
			get { return GetRelatedEntities<SLAKPIInstance>("slakpiinstance_appointment", null); }
			set { SetRelatedEntities("slakpiinstance_appointment", null, value); }
		}
		#endregion

		#region Actions
		#endregion

		#region OptionSetEnums
		public enum eAttachmentErrors
		{	
		
			[Label("None")]
			[Description(@"")]
			None = 0, 
		
			[Label("The appointment was saved as a Microsoft Dynamics 365 appointment record, but not all the attachments could be saved with it. An attachment cannot be saved if it is blocked or if its file type is invalid.")]
			[Description(@"")]
			TheAppointmentWasSavedAsAMicrosoftDynamics365AppointmentRecordButNotAllTheAttachmentsCouldBeSavedWithItAnAttachmentCannotBeSavedIfItIsBlockedOrIfItsFileTypeIsInvalid = 1, 
		}
		
		public enum eAppointmentType
		{	
		
			[Label("Not Recurring")]
			[Description(@"")]
			NotRecurring = 0, 
		
			[Label("Recurring Master")]
			[Description(@"")]
			RecurringMaster = 1, 
		
			[Label("Recurring Instance")]
			[Description(@"")]
			RecurringInstance = 2, 
		
			[Label("Recurring Exception")]
			[Description(@"")]
			RecurringException = 3, 
		
			[Label("Recurring Future Exception")]
			[Description(@"")]
			RecurringFutureException = 4, 
		}
		
		public enum ePriority
		{	
		
			[Label("Low")]
			[Description(@"")]
			Low = 0, 
		
			[Label("Normal")]
			[Description(@"")]
			Normal = 1, 
		
			[Label("High")]
			[Description(@"")]
			High = 2, 
		}
		
		public enum eStatus
		{	
		
			[Label("Open")]
			[Description(@"")]
			Open = 0, 
		
			[Label("Completed")]
			[Description(@"")]
			Completed = 1, 
		
			[Label("Canceled")]
			[Description(@"")]
			Canceled = 2, 
		
			[Label("Scheduled")]
			[Description(@"")]
			Scheduled = 3, 
		}
		
		public enum eStatusReason
		{	
		
			[Label("Free")]
			[Description(@"")]
			Free_Active = 1, 
		
			[Label("Tentative")]
			[Description(@"")]
			Tentative_Active = 2, 
		
			[Label("Completed")]
			[Description(@"")]
			Completed_Inactive = 3, 
		
			[Label("Canceled")]
			[Description(@"")]
			Canceled = 4, 
		
			[Label("Busy")]
			[Description(@"")]
			Busy = 5, 
		
			[Label("Out of Office")]
			[Description(@"")]
			OutOfOffice = 6, 
		}
		
		#endregion	

		#region Properties
		public static class Properties 
		{
			/// <summary>activityadditionalparams</summary>
			public const string AdditionalParameters = "activityadditionalparams";

			/// <summary>activityid</summary>
			public const string AppointmentId = "activityid";

			/// <summary>activitytypecode</summary>
			public const string ActivityType = "activitytypecode";

			/// <summary>actualdurationminutes</summary>
			public const string ActualDuration = "actualdurationminutes";

			/// <summary>actualend</summary>
			public const string ActualEnd = "actualend";

			/// <summary>actualstart</summary>
			public const string ActualStart = "actualstart";

			/// <summary>attachmentcount</summary>
			public const string AttachmentCount = "attachmentcount";

			/// <summary>attachmenterrors</summary>
			public const string AttachmentErrors = "attachmenterrors";

			/// <summary>category</summary>
			public const string Category = "category";

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

			/// <summary>exchangerate</summary>
			public const string ExchangeRate = "exchangerate";

			/// <summary>globalobjectid</summary>
			public const string OutlookAppointment = "globalobjectid";

			/// <summary>importsequencenumber</summary>
			public const string ImportSequenceNumber = "importsequencenumber";

			/// <summary>instancetypecode</summary>
			public const string AppointmentType = "instancetypecode";

			/// <summary>isalldayevent</summary>
			public const string AllDayEvent = "isalldayevent";

			/// <summary>isbilled</summary>
			public const string IsBilled = "isbilled";

			/// <summary>isdraft</summary>
			public const string IsDraft = "isdraft";

			/// <summary>ismapiprivate</summary>
			public const string IsPrivate = "ismapiprivate";

			/// <summary>isregularactivity</summary>
			public const string IsRegularActivity = "isregularactivity";

			/// <summary>isunsafe</summary>
			public const string IsUnsafe = "isunsafe";

			/// <summary>isworkflowcreated</summary>
			public const string IsWorkflowCreated = "isworkflowcreated";

			/// <summary>lastonholdtime</summary>
			public const string LastOnHoldTime = "lastonholdtime";

			/// <summary>location</summary>
			public const string Location = "location";

			/// <summary>modifiedby</summary>
			public const string ModifiedBy = "modifiedby";

			/// <summary>modifiedbyname</summary>
			public const string Modifiedbyname = "modifiedbyname";

			/// <summary>modifiedbyyominame</summary>
			public const string Modifiedbyyominame = "modifiedbyyominame";

			/// <summary>modifiedfieldsmask</summary>
			public const string ModifiedFieldsMask = "modifiedfieldsmask";

			/// <summary>modifiedon</summary>
			public const string ModifiedOn = "modifiedon";

			/// <summary>modifiedonbehalfby</summary>
			public const string ModifiedByDelegate = "modifiedonbehalfby";

			/// <summary>modifiedonbehalfbyname</summary>
			public const string Modifiedonbehalfbyname = "modifiedonbehalfbyname";

			/// <summary>modifiedonbehalfbyyominame</summary>
			public const string Modifiedonbehalfbyyominame = "modifiedonbehalfbyyominame";

			/// <summary>onholdtime</summary>
			public const string OnHoldTimeMinutes = "onholdtime";

			/// <summary>optionalattendees</summary>
			public const string OptionalAttendees = "optionalattendees";

			/// <summary>organizer</summary>
			public const string Organizer = "organizer";

			/// <summary>originalstartdate</summary>
			public const string OriginalStartDate = "originalstartdate";

			/// <summary>outlookownerapptid</summary>
			public const string OutlookAppointmentOwner = "outlookownerapptid";

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

			/// <summary>prioritycode</summary>
			public const string Priority = "prioritycode";

			/// <summary>processid</summary>
			public const string ProcessId = "processid";

			/// <summary>regardingobjectid</summary>
			public const string Regarding = "regardingobjectid";

			/// <summary>regardingobjectidname</summary>
			public const string Regardingobjectidname = "regardingobjectidname";

			/// <summary>regardingobjectidyominame</summary>
			public const string Regardingobjectidyominame = "regardingobjectidyominame";

			/// <summary>regardingobjecttypecode</summary>
			public const string Regardingobjecttypecode = "regardingobjecttypecode";

			/// <summary>requiredattendees</summary>
			public const string RequiredAttendees = "requiredattendees";

			/// <summary>safedescription</summary>
			public const string SafeDescription = "safedescription";

			/// <summary>scheduleddurationminutes</summary>
			public const string Duration = "scheduleddurationminutes";

			/// <summary>scheduledend</summary>
			public const string EndTime = "scheduledend";

			/// <summary>scheduledstart</summary>
			public const string StartTime = "scheduledstart";

			/// <summary>seriesid</summary>
			public const string SeriesId = "seriesid";

			/// <summary>serviceid</summary>
			public const string Service = "serviceid";

			/// <summary>serviceidname</summary>
			public const string Serviceidname = "serviceidname";

			/// <summary>slaid</summary>
			public const string SLA = "slaid";

			/// <summary>slainvokedid</summary>
			public const string LastSLAApplied = "slainvokedid";

			/// <summary>slainvokedidname</summary>
			public const string Slainvokedidname = "slainvokedidname";

			/// <summary>slaname</summary>
			public const string Slaname = "slaname";

			/// <summary>sortdate</summary>
			public const string SortDate = "sortdate";

			/// <summary>stageid</summary>
			public const string DeprecatedProcessStageId = "stageid";

			/// <summary>statecode</summary>
			public const string Status = "statecode";

			/// <summary>statuscode</summary>
			public const string StatusReason = "statuscode";

			/// <summary>subcategory</summary>
			public const string SubCategory = "subcategory";

			/// <summary>subject</summary>
			public const string Subject = "subject";

			/// <summary>subscriptionid</summary>
			public const string SubscriptionId = "subscriptionid";

			/// <summary>timezoneruleversionnumber</summary>
			public const string TimeZoneRuleVersionNumber = "timezoneruleversionnumber";

			/// <summary>transactioncurrencyid</summary>
			public const string Currency = "transactioncurrencyid";

			/// <summary>transactioncurrencyidname</summary>
			public const string Transactioncurrencyidname = "transactioncurrencyidname";

			/// <summary>traversedpath</summary>
			public const string DeprecatedTraversedPath = "traversedpath";

			/// <summary>utcconversiontimezonecode</summary>
			public const string UTCConversionTimeZoneCode = "utcconversiontimezonecode";

			/// <summary>versionnumber</summary>
			public const string VersionNumber = "versionnumber";

		}
		#endregion

		#region Schemas
		public static class Schemas 
		{
			/// <summary>1:N appointment_actioncard</summary>
			public const string AppointmentActioncard = "appointment_actioncard";

			/// <summary>1:N appointment_activity_mime_attachment</summary>
			public const string AppointmentActivityMimeAttachment = "appointment_activity_mime_attachment";

			/// <summary>1:N appointment_activity_parties</summary>
			public const string AppointmentActivityParties = "appointment_activity_parties";

			/// <summary>1:N Appointment_Annotation</summary>
			public const string AppointmentAnnotation = "Appointment_Annotation";

			/// <summary>1:N Appointment_AsyncOperations</summary>
			public const string AppointmentAsyncOperations = "Appointment_AsyncOperations";

			/// <summary>1:N Appointment_BulkDeleteFailures</summary>
			public const string AppointmentBulkDeleteFailures = "Appointment_BulkDeleteFailures";

			/// <summary>1:N appointment_campaignresponse</summary>
			public const string AppointmentCampaignresponse = "appointment_campaignresponse";

			/// <summary>1:N appointment_connections1</summary>
			public const string AppointmentConnections1 = "appointment_connections1";

			/// <summary>1:N appointment_connections2</summary>
			public const string AppointmentConnections2 = "appointment_connections2";

			/// <summary>1:N Appointment_DuplicateBaseRecord</summary>
			public const string AppointmentDuplicateBaseRecord = "Appointment_DuplicateBaseRecord";

			/// <summary>1:N Appointment_DuplicateMatchingRecord</summary>
			public const string AppointmentDuplicateMatchingRecord = "Appointment_DuplicateMatchingRecord";

			/// <summary>1:N appointment_PostFollows</summary>
			public const string AppointmentPostFollows = "appointment_PostFollows";

			/// <summary>1:N appointment_principalobjectattributeaccess</summary>
			public const string AppointmentPrincipalobjectattributeaccess = "appointment_principalobjectattributeaccess";

			/// <summary>1:N Appointment_ProcessSessions</summary>
			public const string AppointmentProcessSessions = "Appointment_ProcessSessions";

			/// <summary>1:N Appointment_QueueItem</summary>
			public const string AppointmentQueueItem = "Appointment_QueueItem";

			/// <summary>1:N Appointment_SyncErrors</summary>
			public const string AppointmentSyncErrors = "Appointment_SyncErrors";

			/// <summary>1:N slakpiinstance_appointment</summary>
			public const string SlakpiinstanceAppointment = "slakpiinstance_appointment";

		}
		#endregion
	}
}

