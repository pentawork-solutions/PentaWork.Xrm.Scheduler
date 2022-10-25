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
	[EntityLogicalName("recurringappointmentmaster")]
	public sealed class RecurringAppointment : Entity
	{	
		public static readonly int? EntityTypeCode = 4251;
		public new const string LogicalName = "recurringappointmentmaster";
		public const string PrimaryIdAttribute = "activityid";
		public const string PrimaryNameAttribute = "subject";
	
		public RecurringAppointment() : base("recurringappointmentmaster") { }

		#region Attributes
		/// <summary>
        /// activityid
        /// </summary>
		[DisplayName("Recurring Appointment")]
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
        /// dayofmonth
        /// </summary>
		[DisplayName("Day Of Month")]
		[AttributeLogicalName("dayofmonth")]
		public int? DayOfMonth
		{	
			get { return GetAttributeValue<int?>("dayofmonth"); }
			set
			{ 
				if(value == DayOfMonth) return;
				SetAttributeValue("dayofmonth", value);
			}
		}	
			
		/// <summary>
        /// daysofweekmask
        /// </summary>
		[DisplayName("Days Of Week Mask")]
		[AttributeLogicalName("daysofweekmask")]
		public int? DaysOfWeekMask
		{	
			get { return GetAttributeValue<int?>("daysofweekmask"); }
			set
			{ 
				if(value == DaysOfWeekMask) return;
				SetAttributeValue("daysofweekmask", value);
			}
		}	
			
		/// <summary>
        /// deletedexceptionslist
        /// </summary>
		[DisplayName("Deleted Appointments")]
		[AttributeLogicalName("deletedexceptionslist")]
		public string DeletedAppointments
		{	
			get { return GetAttributeValue<string>("deletedexceptionslist"); }
			set
			{ 
				if(value == DeletedAppointments) return;
				SetAttributeValue("deletedexceptionslist", value);
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
        /// effectiveenddate
        /// </summary>
		[DisplayName("Effective End Date")]
		[AttributeLogicalName("effectiveenddate")]
		public DateTime? EffectiveEndDate
		{	
			get { return GetAttributeValue<DateTime?>("effectiveenddate"); }
			set
			{ 
				if(value == EffectiveEndDate) return;
				SetAttributeValue("effectiveenddate", value);
			}
		}	
			
		/// <summary>
        /// effectivestartdate
        /// </summary>
		[DisplayName("Effective Start Date")]
		[AttributeLogicalName("effectivestartdate")]
		public DateTime? EffectiveStartDate
		{	
			get { return GetAttributeValue<DateTime?>("effectivestartdate"); }
			set
			{ 
				if(value == EffectiveStartDate) return;
				SetAttributeValue("effectivestartdate", value);
			}
		}	
			
		/// <summary>
        /// endtime
        /// </summary>
		[DisplayName("Pattern End Time")]
		[AttributeLogicalName("endtime")]
		public DateTime? PatternEndTime
		{	
			get { return GetAttributeValue<DateTime?>("endtime"); }
			set
			{ 
				if(value == PatternEndTime) return;
				SetAttributeValue("endtime", value);
			}
		}	
			
		/// <summary>
        /// exchangerate
        /// </summary>
		[DisplayName("Exchange Rate")]
		[AttributeLogicalName("exchangerate")]
		public decimal? ExchangeRate
		{	
			get { return GetAttributeValue<decimal?>("exchangerate"); }
			set
			{ 
				if(value == ExchangeRate) return;
				SetAttributeValue("exchangerate", value);
			}
		}	
			
		/// <summary>
        /// expansionstatecode
        /// </summary>
		[DisplayName("Expansion State Code")]
		[AttributeLogicalName("expansionstatecode")]
		public eExpansionStateCode? ExpansionStateCode
		{	
			get 
			{ 
				var optionSetValue = GetAttributeValue<OptionSetValue>("expansionstatecode");
				if (optionSetValue != null) return (eExpansionStateCode)optionSetValue.Value;
				else return null;
			}
			set 
			{ 
				if(value == ExpansionStateCode) return;

				OptionSetValue optionSetValue = null;
				if(value != null) optionSetValue = new OptionSetValue((int)value);
				SetAttributeValue("expansionstatecode", optionSetValue); 
			}
		}

		/// <summary>
        /// firstdayofweek
        /// </summary>
		[DisplayName("First Day Of Week")]
		[AttributeLogicalName("firstdayofweek")]
		public int? FirstDayOfWeek
		{	
			get { return GetAttributeValue<int?>("firstdayofweek"); }
			set
			{ 
				if(value == FirstDayOfWeek) return;
				SetAttributeValue("firstdayofweek", value);
			}
		}	
			
		/// <summary>
        /// globalobjectid
        /// </summary>
		[DisplayName("Outlook Recurring Appointment Master")]
		[AttributeLogicalName("globalobjectid")]
		public string OutlookRecurringAppointmentMaster
		{	
			get { return GetAttributeValue<string>("globalobjectid"); }
			set
			{ 
				if(value == OutlookRecurringAppointmentMaster) return;
				SetAttributeValue("globalobjectid", value);
			}
		}	
			
		/// <summary>
        /// groupid
        /// </summary>
		[DisplayName("Group Id")]
		[AttributeLogicalName("groupid")]
		public EntityReference GroupId
		{	
			get { return GetAttributeValue<EntityReference>("groupid"); }
			set
			{ 
				if(value == GroupId) return;
				SetAttributeValue("groupid", value);
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
        /// instance
        /// </summary>
		[DisplayName("Instance")]
		[AttributeLogicalName("instance")]
		public eInstance? Instance
		{	
			get 
			{ 
				var optionSetValue = GetAttributeValue<OptionSetValue>("instance");
				if (optionSetValue != null) return (eInstance)optionSetValue.Value;
				else return null;
			}
			set 
			{ 
				if(value == Instance) return;

				OptionSetValue optionSetValue = null;
				if(value != null) optionSetValue = new OptionSetValue((int)value);
				SetAttributeValue("instance", optionSetValue); 
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
        /// interval
        /// </summary>
		[DisplayName("Interval")]
		[AttributeLogicalName("interval")]
		public int? Interval
		{	
			get { return GetAttributeValue<int?>("interval"); }
			set
			{ 
				if(value == Interval) return;
				SetAttributeValue("interval", value);
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
        /// isnthmonthly
        /// </summary>
		[DisplayName("Nth Monthly")]
		[AttributeLogicalName("isnthmonthly")]
		public bool? NthMonthly
		{	
			get { return GetAttributeValue<bool?>("isnthmonthly"); }
			set
			{ 
				if(value == NthMonthly) return;
				SetAttributeValue("isnthmonthly", value);
			}
		}	
			
		/// <summary>
        /// isnthyearly
        /// </summary>
		[DisplayName("Nth Yearly")]
		[AttributeLogicalName("isnthyearly")]
		public bool? NthYearly
		{	
			get { return GetAttributeValue<bool?>("isnthyearly"); }
			set
			{ 
				if(value == NthYearly) return;
				SetAttributeValue("isnthyearly", value);
			}
		}	
			
		/// <summary>
        /// isregenerate
        /// </summary>
		[DisplayName("Regenerate")]
		[AttributeLogicalName("isregenerate")]
		public bool? Regenerate
		{	
			get { return GetAttributeValue<bool?>("isregenerate"); }
			set
			{ 
				if(value == Regenerate) return;
				SetAttributeValue("isregenerate", value);
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
        /// isweekdaypattern
        /// </summary>
		[DisplayName("Every Weekday")]
		[AttributeLogicalName("isweekdaypattern")]
		public bool? EveryWeekday
		{	
			get { return GetAttributeValue<bool?>("isweekdaypattern"); }
			set
			{ 
				if(value == EveryWeekday) return;
				SetAttributeValue("isweekdaypattern", value);
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
        /// lastexpandedinstancedate
        /// </summary>
		[DisplayName("Last Expanded Instance Date")]
		[AttributeLogicalName("lastexpandedinstancedate")]
		public DateTime? LastExpandedInstanceDate
		{	
			get { return GetAttributeValue<DateTime?>("lastexpandedinstancedate"); }
			set
			{ 
				if(value == LastExpandedInstanceDate) return;
				SetAttributeValue("lastexpandedinstancedate", value);
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
        /// monthofyear
        /// </summary>
		[DisplayName("Month Of Year")]
		[AttributeLogicalName("monthofyear")]
		public egMonthOfYear? MonthOfYear
		{	
			get 
			{ 
				var optionSetValue = GetAttributeValue<OptionSetValue>("monthofyear");
				if (optionSetValue != null) return (egMonthOfYear)optionSetValue.Value;
				else return null;
			}
			set 
			{ 
				if(value == MonthOfYear) return;

				OptionSetValue optionSetValue = null;
				if(value != null) optionSetValue = new OptionSetValue((int)value);
				SetAttributeValue("monthofyear", optionSetValue); 
			}
		}

		/// <summary>
        /// nextexpansioninstancedate
        /// </summary>
		[DisplayName("Next Expanded Instance Date")]
		[AttributeLogicalName("nextexpansioninstancedate")]
		public DateTime? NextExpandedInstanceDate
		{	
			get { return GetAttributeValue<DateTime?>("nextexpansioninstancedate"); }
			set
			{ 
				if(value == NextExpandedInstanceDate) return;
				SetAttributeValue("nextexpansioninstancedate", value);
			}
		}	
			
		/// <summary>
        /// occurrences
        /// </summary>
		[DisplayName("Occurrences")]
		[AttributeLogicalName("occurrences")]
		public int? Occurrences
		{	
			get { return GetAttributeValue<int?>("occurrences"); }
			set
			{ 
				if(value == Occurrences) return;
				SetAttributeValue("occurrences", value);
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
        /// outlookownerapptid
        /// </summary>
		[DisplayName("Outlook Recurring Appointment Master Owner")]
		[AttributeLogicalName("outlookownerapptid")]
		public int? OutlookRecurringAppointmentMasterOwner
		{	
			get { return GetAttributeValue<int?>("outlookownerapptid"); }
			set
			{ 
				if(value == OutlookRecurringAppointmentMasterOwner) return;
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
        /// patternenddate
        /// </summary>
		[DisplayName("Recurrence Range End")]
		[AttributeLogicalName("patternenddate")]
		public DateTime? RecurrenceRangeEnd
		{	
			get { return GetAttributeValue<DateTime?>("patternenddate"); }
			set
			{ 
				if(value == RecurrenceRangeEnd) return;
				SetAttributeValue("patternenddate", value);
			}
		}	
			
		/// <summary>
        /// patternendtype
        /// </summary>
		[DisplayName("Pattern End Type")]
		[AttributeLogicalName("patternendtype")]
		public ePatternEndType? PatternEndType
		{	
			get 
			{ 
				var optionSetValue = GetAttributeValue<OptionSetValue>("patternendtype");
				if (optionSetValue != null) return (ePatternEndType)optionSetValue.Value;
				else return null;
			}
			set 
			{ 
				if(value == PatternEndType) return;

				OptionSetValue optionSetValue = null;
				if(value != null) optionSetValue = new OptionSetValue((int)value);
				SetAttributeValue("patternendtype", optionSetValue); 
			}
		}

		/// <summary>
        /// patternstartdate
        /// </summary>
		[DisplayName("Recurrence Range Start")]
		[AttributeLogicalName("patternstartdate")]
		public DateTime? RecurrenceRangeStart
		{	
			get { return GetAttributeValue<DateTime?>("patternstartdate"); }
			set
			{ 
				if(value == RecurrenceRangeStart) return;
				SetAttributeValue("patternstartdate", value);
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
        /// recurrencepatterntype
        /// </summary>
		[DisplayName("Recurrence Frequency")]
		[AttributeLogicalName("recurrencepatterntype")]
		public eRecurrencePattern? RecurrenceFrequency
		{	
			get 
			{ 
				var optionSetValue = GetAttributeValue<OptionSetValue>("recurrencepatterntype");
				if (optionSetValue != null) return (eRecurrencePattern)optionSetValue.Value;
				else return null;
			}
			set 
			{ 
				if(value == RecurrenceFrequency) return;

				OptionSetValue optionSetValue = null;
				if(value != null) optionSetValue = new OptionSetValue((int)value);
				SetAttributeValue("recurrencepatterntype", optionSetValue); 
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
        /// ruleid
        /// </summary>
		[DisplayName("Recurrence Rule")]
		[AttributeLogicalName("ruleid")]
		public EntityReference RecurrenceRule
		{	
			get { return GetAttributeValue<EntityReference>("ruleid"); }
			set
			{ 
				if(value == RecurrenceRule) return;
				SetAttributeValue("ruleid", value);
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
        /// seriesstatus
        /// </summary>
		[DisplayName("Series Status")]
		[AttributeLogicalName("seriesstatus")]
		public bool? SeriesStatus
		{	
			get { return GetAttributeValue<bool?>("seriesstatus"); }
			set
			{ 
				if(value == SeriesStatus) return;
				SetAttributeValue("seriesstatus", value);
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
        /// starttime
        /// </summary>
		[DisplayName("Pattern Start Time")]
		[AttributeLogicalName("starttime")]
		public DateTime? PatternStartTime
		{	
			get { return GetAttributeValue<DateTime?>("starttime"); }
			set
			{ 
				if(value == PatternStartTime) return;
				SetAttributeValue("starttime", value);
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
		[DisplayName("subscriptionid")]
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
		[DisplayName("timezoneruleversionnumber")]
		[AttributeLogicalName("timezoneruleversionnumber")]
		public int? Timezoneruleversionnumber
		{	
			get { return GetAttributeValue<int?>("timezoneruleversionnumber"); }
			set
			{ 
				if(value == Timezoneruleversionnumber) return;
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
        /// 1:N Get entities for 'recurringappointmentmaster_actioncard'
        /// </summary>
		[RelationshipSchemaName("recurringappointmentmaster_actioncard")]
		public IEnumerable<ActionCard> RecurringappointmentmasterActioncard
		{
			get { return GetRelatedEntities<ActionCard>("recurringappointmentmaster_actioncard", null); }
			set { SetRelatedEntities("recurringappointmentmaster_actioncard", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'recurringappointmentmaster_activity_parties'
        /// </summary>
		[RelationshipSchemaName("recurringappointmentmaster_activity_parties")]
		public IEnumerable<ActivityParty> RecurringappointmentmasterActivityParties
		{
			get { return GetRelatedEntities<ActivityParty>("recurringappointmentmaster_activity_parties", null); }
			set { SetRelatedEntities("recurringappointmentmaster_activity_parties", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'RecurringAppointmentMaster_Annotation'
        /// </summary>
		[RelationshipSchemaName("RecurringAppointmentMaster_Annotation")]
		public IEnumerable<Note> RecurringAppointmentMasterAnnotation
		{
			get { return GetRelatedEntities<Note>("RecurringAppointmentMaster_Annotation", null); }
			set { SetRelatedEntities("RecurringAppointmentMaster_Annotation", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'recurringappointmentmaster_appointment'
        /// </summary>
		[RelationshipSchemaName("recurringappointmentmaster_appointment")]
		public IEnumerable<Appointment> RecurringappointmentmasterAppointment
		{
			get { return GetRelatedEntities<Appointment>("recurringappointmentmaster_appointment", null); }
			set { SetRelatedEntities("recurringappointmentmaster_appointment", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'RecurringAppointmentMaster_AsyncOperations'
        /// </summary>
		[RelationshipSchemaName("RecurringAppointmentMaster_AsyncOperations")]
		public IEnumerable<SystemJob> RecurringAppointmentMasterAsyncOperations
		{
			get { return GetRelatedEntities<SystemJob>("RecurringAppointmentMaster_AsyncOperations", null); }
			set { SetRelatedEntities("RecurringAppointmentMaster_AsyncOperations", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'RecurringAppointmentMaster_BulkDeleteFailures'
        /// </summary>
		[RelationshipSchemaName("RecurringAppointmentMaster_BulkDeleteFailures")]
		public IEnumerable<BulkDeleteFailure> RecurringAppointmentMasterBulkDeleteFailures
		{
			get { return GetRelatedEntities<BulkDeleteFailure>("RecurringAppointmentMaster_BulkDeleteFailures", null); }
			set { SetRelatedEntities("RecurringAppointmentMaster_BulkDeleteFailures", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'recurringappointmentmaster_campaignresponse'
        /// </summary>
		[RelationshipSchemaName("recurringappointmentmaster_campaignresponse")]
		public IEnumerable<CampaignResponse> RecurringappointmentmasterCampaignresponse
		{
			get { return GetRelatedEntities<CampaignResponse>("recurringappointmentmaster_campaignresponse", null); }
			set { SetRelatedEntities("recurringappointmentmaster_campaignresponse", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'recurringappointmentmaster_connections1'
        /// </summary>
		[RelationshipSchemaName("recurringappointmentmaster_connections1")]
		public IEnumerable<Connection> RecurringappointmentmasterConnections1
		{
			get { return GetRelatedEntities<Connection>("recurringappointmentmaster_connections1", null); }
			set { SetRelatedEntities("recurringappointmentmaster_connections1", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'recurringappointmentmaster_connections2'
        /// </summary>
		[RelationshipSchemaName("recurringappointmentmaster_connections2")]
		public IEnumerable<Connection> RecurringappointmentmasterConnections2
		{
			get { return GetRelatedEntities<Connection>("recurringappointmentmaster_connections2", null); }
			set { SetRelatedEntities("recurringappointmentmaster_connections2", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'RecurringAppointmentMaster_DuplicateBaseRecord'
        /// </summary>
		[RelationshipSchemaName("RecurringAppointmentMaster_DuplicateBaseRecord")]
		public IEnumerable<DuplicateRecord> RecurringAppointmentMasterDuplicateBaseRecord
		{
			get { return GetRelatedEntities<DuplicateRecord>("RecurringAppointmentMaster_DuplicateBaseRecord", null); }
			set { SetRelatedEntities("RecurringAppointmentMaster_DuplicateBaseRecord", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'RecurringAppointmentMaster_DuplicateMatchingRecord'
        /// </summary>
		[RelationshipSchemaName("RecurringAppointmentMaster_DuplicateMatchingRecord")]
		public IEnumerable<DuplicateRecord> RecurringAppointmentMasterDuplicateMatchingRecord
		{
			get { return GetRelatedEntities<DuplicateRecord>("RecurringAppointmentMaster_DuplicateMatchingRecord", null); }
			set { SetRelatedEntities("RecurringAppointmentMaster_DuplicateMatchingRecord", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'recurringappointmentmaster_PostFollows'
        /// </summary>
		[RelationshipSchemaName("recurringappointmentmaster_PostFollows")]
		public IEnumerable<Follow> RecurringappointmentmasterPostFollows
		{
			get { return GetRelatedEntities<Follow>("recurringappointmentmaster_PostFollows", null); }
			set { SetRelatedEntities("recurringappointmentmaster_PostFollows", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'recurringappointmentmaster_principalobjectattributeaccess'
        /// </summary>
		[RelationshipSchemaName("recurringappointmentmaster_principalobjectattributeaccess")]
		public IEnumerable<FieldSharing> RecurringappointmentmasterPrincipalobjectattributeaccess
		{
			get { return GetRelatedEntities<FieldSharing>("recurringappointmentmaster_principalobjectattributeaccess", null); }
			set { SetRelatedEntities("recurringappointmentmaster_principalobjectattributeaccess", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'RecurringAppointmentMaster_ProcessSessions'
        /// </summary>
		[RelationshipSchemaName("RecurringAppointmentMaster_ProcessSessions")]
		public IEnumerable<ProcessSession> RecurringAppointmentMasterProcessSessions
		{
			get { return GetRelatedEntities<ProcessSession>("RecurringAppointmentMaster_ProcessSessions", null); }
			set { SetRelatedEntities("RecurringAppointmentMaster_ProcessSessions", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'RecurringAppointmentMaster_QueueItem'
        /// </summary>
		[RelationshipSchemaName("RecurringAppointmentMaster_QueueItem")]
		public IEnumerable<QueueItem> RecurringAppointmentMasterQueueItem
		{
			get { return GetRelatedEntities<QueueItem>("RecurringAppointmentMaster_QueueItem", null); }
			set { SetRelatedEntities("RecurringAppointmentMaster_QueueItem", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'RecurringAppointmentMaster_SyncErrors'
        /// </summary>
		[RelationshipSchemaName("RecurringAppointmentMaster_SyncErrors")]
		public IEnumerable<SyncError> RecurringAppointmentMasterSyncErrors
		{
			get { return GetRelatedEntities<SyncError>("RecurringAppointmentMaster_SyncErrors", null); }
			set { SetRelatedEntities("RecurringAppointmentMaster_SyncErrors", null, value); }
		}
		#endregion

		#region Actions
		#endregion

		#region OptionSetEnums
		public enum egMonthOfYear
		{	
		
			[Label("Invalid Month Of Year")]
			[Description(@"")]
			InvalidMonthOfYear = 0, 
		
			[Label("January")]
			[Description(@"")]
			January = 1, 
		
			[Label("February")]
			[Description(@"")]
			February = 2, 
		
			[Label("March")]
			[Description(@"")]
			March = 3, 
		
			[Label("April")]
			[Description(@"")]
			April = 4, 
		
			[Label("May")]
			[Description(@"")]
			May = 5, 
		
			[Label("June")]
			[Description(@"")]
			June = 6, 
		
			[Label("July")]
			[Description(@"")]
			July = 7, 
		
			[Label("August")]
			[Description(@"")]
			August = 8, 
		
			[Label("September")]
			[Description(@"")]
			September = 9, 
		
			[Label("October")]
			[Description(@"")]
			October = 10, 
		
			[Label("November")]
			[Description(@"")]
			November = 11, 
		
			[Label("December")]
			[Description(@"")]
			December = 12, 
		}
		
		public enum eExpansionStateCode
		{	
		
			[Label("Unexpanded")]
			[Description(@"")]
			Unexpanded = 0, 
		
			[Label("Partial")]
			[Description(@"")]
			Partial = 1, 
		
			[Label("Full")]
			[Description(@"")]
			Full = 2, 
		}
		
		public enum eInstance
		{	
		
			[Label("First")]
			[Description(@"")]
			First = 1, 
		
			[Label("Second")]
			[Description(@"")]
			Second = 2, 
		
			[Label("Third")]
			[Description(@"")]
			Third = 3, 
		
			[Label("Fourth")]
			[Description(@"")]
			Fourth = 4, 
		
			[Label("Last")]
			[Description(@"")]
			Last = 5, 
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
		
		public enum ePatternEndType
		{	
		
			[Label("No End Date")]
			[Description(@"")]
			NoEndDate = 1, 
		
			[Label("Occurrences")]
			[Description(@"")]
			Occurrences = 2, 
		
			[Label("Pattern End Date")]
			[Description(@"")]
			PatternEndDate = 3, 
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
		
		public enum eRecurrencePattern
		{	
		
			[Label("Daily")]
			[Description(@"")]
			Daily = 0, 
		
			[Label("Weekly")]
			[Description(@"")]
			Weekly = 1, 
		
			[Label("Monthly")]
			[Description(@"")]
			Monthly = 2, 
		
			[Label("Yearly")]
			[Description(@"")]
			Yearly = 3, 
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
			/// <summary>activityid</summary>
			public const string RecurringAppointmentId = "activityid";

			/// <summary>activitytypecode</summary>
			public const string ActivityType = "activitytypecode";

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

			/// <summary>dayofmonth</summary>
			public const string DayOfMonth = "dayofmonth";

			/// <summary>daysofweekmask</summary>
			public const string DaysOfWeekMask = "daysofweekmask";

			/// <summary>deletedexceptionslist</summary>
			public const string DeletedAppointments = "deletedexceptionslist";

			/// <summary>description</summary>
			public const string Description = "description";

			/// <summary>duration</summary>
			public const string Duration = "duration";

			/// <summary>effectiveenddate</summary>
			public const string EffectiveEndDate = "effectiveenddate";

			/// <summary>effectivestartdate</summary>
			public const string EffectiveStartDate = "effectivestartdate";

			/// <summary>endtime</summary>
			public const string PatternEndTime = "endtime";

			/// <summary>exchangerate</summary>
			public const string ExchangeRate = "exchangerate";

			/// <summary>expansionstatecode</summary>
			public const string ExpansionStateCode = "expansionstatecode";

			/// <summary>firstdayofweek</summary>
			public const string FirstDayOfWeek = "firstdayofweek";

			/// <summary>globalobjectid</summary>
			public const string OutlookRecurringAppointmentMaster = "globalobjectid";

			/// <summary>groupid</summary>
			public const string GroupId = "groupid";

			/// <summary>importsequencenumber</summary>
			public const string ImportSequenceNumber = "importsequencenumber";

			/// <summary>instance</summary>
			public const string Instance = "instance";

			/// <summary>instancetypecode</summary>
			public const string AppointmentType = "instancetypecode";

			/// <summary>interval</summary>
			public const string Interval = "interval";

			/// <summary>isalldayevent</summary>
			public const string AllDayEvent = "isalldayevent";

			/// <summary>isbilled</summary>
			public const string IsBilled = "isbilled";

			/// <summary>ismapiprivate</summary>
			public const string IsPrivate = "ismapiprivate";

			/// <summary>isnthmonthly</summary>
			public const string NthMonthly = "isnthmonthly";

			/// <summary>isnthyearly</summary>
			public const string NthYearly = "isnthyearly";

			/// <summary>isregenerate</summary>
			public const string Regenerate = "isregenerate";

			/// <summary>isregularactivity</summary>
			public const string IsRegularActivity = "isregularactivity";

			/// <summary>isunsafe</summary>
			public const string IsUnsafe = "isunsafe";

			/// <summary>isweekdaypattern</summary>
			public const string EveryWeekday = "isweekdaypattern";

			/// <summary>isworkflowcreated</summary>
			public const string IsWorkflowCreated = "isworkflowcreated";

			/// <summary>lastexpandedinstancedate</summary>
			public const string LastExpandedInstanceDate = "lastexpandedinstancedate";

			/// <summary>location</summary>
			public const string Location = "location";

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

			/// <summary>monthofyear</summary>
			public const string MonthOfYear = "monthofyear";

			/// <summary>nextexpansioninstancedate</summary>
			public const string NextExpandedInstanceDate = "nextexpansioninstancedate";

			/// <summary>occurrences</summary>
			public const string Occurrences = "occurrences";

			/// <summary>optionalattendees</summary>
			public const string OptionalAttendees = "optionalattendees";

			/// <summary>organizer</summary>
			public const string Organizer = "organizer";

			/// <summary>outlookownerapptid</summary>
			public const string OutlookRecurringAppointmentMasterOwner = "outlookownerapptid";

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

			/// <summary>patternenddate</summary>
			public const string RecurrenceRangeEnd = "patternenddate";

			/// <summary>patternendtype</summary>
			public const string PatternEndType = "patternendtype";

			/// <summary>patternstartdate</summary>
			public const string RecurrenceRangeStart = "patternstartdate";

			/// <summary>prioritycode</summary>
			public const string Priority = "prioritycode";

			/// <summary>processid</summary>
			public const string ProcessId = "processid";

			/// <summary>recurrencepatterntype</summary>
			public const string RecurrenceFrequency = "recurrencepatterntype";

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

			/// <summary>ruleid</summary>
			public const string RecurrenceRule = "ruleid";

			/// <summary>safedescription</summary>
			public const string SafeDescription = "safedescription";

			/// <summary>scheduledend</summary>
			public const string EndTime = "scheduledend";

			/// <summary>scheduledstart</summary>
			public const string StartTime = "scheduledstart";

			/// <summary>seriesstatus</summary>
			public const string SeriesStatus = "seriesstatus";

			/// <summary>serviceid</summary>
			public const string Service = "serviceid";

			/// <summary>serviceidname</summary>
			public const string Serviceidname = "serviceidname";

			/// <summary>sortdate</summary>
			public const string SortDate = "sortdate";

			/// <summary>stageid</summary>
			public const string DeprecatedProcessStageId = "stageid";

			/// <summary>starttime</summary>
			public const string PatternStartTime = "starttime";

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
			public const string Timezoneruleversionnumber = "timezoneruleversionnumber";

			/// <summary>transactioncurrencyid</summary>
			public const string Currency = "transactioncurrencyid";

			/// <summary>transactioncurrencyidname</summary>
			public const string Transactioncurrencyidname = "transactioncurrencyidname";

			/// <summary>traversedpath</summary>
			public const string DeprecatedTraversedPath = "traversedpath";

			/// <summary>utcconversiontimezonecode</summary>
			public const string UTCConversionTimeZoneCode = "utcconversiontimezonecode";

			/// <summary>versionnumber</summary>
			public const string Versionnumber = "versionnumber";

		}
		#endregion

		#region Schemas
		public static class Schemas 
		{
			/// <summary>1:N recurringappointmentmaster_actioncard</summary>
			public const string RecurringappointmentmasterActioncard = "recurringappointmentmaster_actioncard";

			/// <summary>1:N recurringappointmentmaster_activity_parties</summary>
			public const string RecurringappointmentmasterActivityParties = "recurringappointmentmaster_activity_parties";

			/// <summary>1:N RecurringAppointmentMaster_Annotation</summary>
			public const string RecurringAppointmentMasterAnnotation = "RecurringAppointmentMaster_Annotation";

			/// <summary>1:N recurringappointmentmaster_appointment</summary>
			public const string RecurringappointmentmasterAppointment = "recurringappointmentmaster_appointment";

			/// <summary>1:N RecurringAppointmentMaster_AsyncOperations</summary>
			public const string RecurringAppointmentMasterAsyncOperations = "RecurringAppointmentMaster_AsyncOperations";

			/// <summary>1:N RecurringAppointmentMaster_BulkDeleteFailures</summary>
			public const string RecurringAppointmentMasterBulkDeleteFailures = "RecurringAppointmentMaster_BulkDeleteFailures";

			/// <summary>1:N recurringappointmentmaster_campaignresponse</summary>
			public const string RecurringappointmentmasterCampaignresponse = "recurringappointmentmaster_campaignresponse";

			/// <summary>1:N recurringappointmentmaster_connections1</summary>
			public const string RecurringappointmentmasterConnections1 = "recurringappointmentmaster_connections1";

			/// <summary>1:N recurringappointmentmaster_connections2</summary>
			public const string RecurringappointmentmasterConnections2 = "recurringappointmentmaster_connections2";

			/// <summary>1:N RecurringAppointmentMaster_DuplicateBaseRecord</summary>
			public const string RecurringAppointmentMasterDuplicateBaseRecord = "RecurringAppointmentMaster_DuplicateBaseRecord";

			/// <summary>1:N RecurringAppointmentMaster_DuplicateMatchingRecord</summary>
			public const string RecurringAppointmentMasterDuplicateMatchingRecord = "RecurringAppointmentMaster_DuplicateMatchingRecord";

			/// <summary>1:N recurringappointmentmaster_PostFollows</summary>
			public const string RecurringappointmentmasterPostFollows = "recurringappointmentmaster_PostFollows";

			/// <summary>1:N recurringappointmentmaster_principalobjectattributeaccess</summary>
			public const string RecurringappointmentmasterPrincipalobjectattributeaccess = "recurringappointmentmaster_principalobjectattributeaccess";

			/// <summary>1:N RecurringAppointmentMaster_ProcessSessions</summary>
			public const string RecurringAppointmentMasterProcessSessions = "RecurringAppointmentMaster_ProcessSessions";

			/// <summary>1:N RecurringAppointmentMaster_QueueItem</summary>
			public const string RecurringAppointmentMasterQueueItem = "RecurringAppointmentMaster_QueueItem";

			/// <summary>1:N RecurringAppointmentMaster_SyncErrors</summary>
			public const string RecurringAppointmentMasterSyncErrors = "RecurringAppointmentMaster_SyncErrors";

		}
		#endregion
	}
}

