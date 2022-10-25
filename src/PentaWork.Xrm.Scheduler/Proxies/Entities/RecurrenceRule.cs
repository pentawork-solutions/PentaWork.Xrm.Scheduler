using System;
using System.Linq;
using System.Diagnostics;
using System.ComponentModel;
using Microsoft.Xrm.Sdk; 
using Microsoft.Xrm.Sdk.Client;
using System.Collections.Generic;

namespace PentaWork.Xrm.Scheduler.Proxies.Entities
{
	
	[EntityLogicalName("recurrencerule")]
	public sealed class RecurrenceRule : Entity
	{	
		public static readonly int? EntityTypeCode = 4250;
		public new const string LogicalName = "recurrencerule";
		public const string PrimaryIdAttribute = "ruleid";
		public const string PrimaryNameAttribute = "";
	
		public RecurrenceRule() : base("recurrencerule") { }

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
		[DisplayName("End Time")]
		[AttributeLogicalName("endtime")]
		public DateTime? EndTime
		{	
			get { return GetAttributeValue<DateTime?>("endtime"); }
			set
			{ 
				if(value == EndTime) return;
				SetAttributeValue("endtime", value);
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
		[DisplayName("Created By (Delegate)")]
		[AttributeLogicalName("modifiedonbehalfby")]
		public EntityReference CreatedByDelegate2
		{	
			get { return GetAttributeValue<EntityReference>("modifiedonbehalfby"); }
			set
			{ 
				if(value == CreatedByDelegate2) return;
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
        /// objectid
        /// </summary>
		[DisplayName("Regarding")]
		[AttributeLogicalName("objectid")]
		public EntityReference Regarding
		{	
			get { return GetAttributeValue<EntityReference>("objectid"); }
			set
			{ 
				if(value == Regarding) return;
				SetAttributeValue("objectid", value);
			}
		}	
			
		/// <summary>
        /// objecttypecode
        /// </summary>
		[DisplayName("Object Type")]
		[AttributeLogicalName("objecttypecode")]
		public string ObjectType
		{	
			get { return GetAttributeValue<string>("objecttypecode"); }
			set
			{ 
				if(value == ObjectType) return;
				SetAttributeValue("objecttypecode", value);
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
        /// recurrencepatterntype
        /// </summary>
		[DisplayName("Recurrence Pattern")]
		[AttributeLogicalName("recurrencepatterntype")]
		public eRecurrencePattern? RecurrencePattern
		{	
			get 
			{ 
				var optionSetValue = GetAttributeValue<OptionSetValue>("recurrencepatterntype");
				if (optionSetValue != null) return (eRecurrencePattern)optionSetValue.Value;
				else return null;
			}
			set 
			{ 
				if(value == RecurrencePattern) return;

				OptionSetValue optionSetValue = null;
				if(value != null) optionSetValue = new OptionSetValue((int)value);
				SetAttributeValue("recurrencepatterntype", optionSetValue); 
			}
		}

		/// <summary>
        /// ruleid
        /// </summary>
		[DisplayName("Recurrence Rule")]
		[AttributeLogicalName("ruleid")]
		public override Guid Id
		{
			get => base.Id;
			set { base.Id = value; SetAttributeValue("ruleid", value); }
		}

							/// <summary>
        /// starttime
        /// </summary>
		[DisplayName("Start Time")]
		[AttributeLogicalName("starttime")]
		public DateTime? StartTime
		{	
			get { return GetAttributeValue<DateTime?>("starttime"); }
			set
			{ 
				if(value == StartTime) return;
				SetAttributeValue("starttime", value);
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
        /// 1:N Get entities for 'recurrencerule_recurringappointmentmaster'
        /// </summary>
		[RelationshipSchemaName("recurrencerule_recurringappointmentmaster")]
		public IEnumerable<RecurringAppointment> RecurrenceruleRecurringappointmentmaster
		{
			get { return GetRelatedEntities<RecurringAppointment>("recurrencerule_recurringappointmentmaster", null); }
			set { SetRelatedEntities("recurrencerule_recurringappointmentmaster", null, value); }
		}
		#endregion

		#region Actions
		#endregion

		#region OptionSetEnums
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

			/// <summary>dayofmonth</summary>
			public const string DayOfMonth = "dayofmonth";

			/// <summary>daysofweekmask</summary>
			public const string DaysOfWeekMask = "daysofweekmask";

			/// <summary>duration</summary>
			public const string Duration = "duration";

			/// <summary>effectiveenddate</summary>
			public const string EffectiveEndDate = "effectiveenddate";

			/// <summary>effectivestartdate</summary>
			public const string EffectiveStartDate = "effectivestartdate";

			/// <summary>endtime</summary>
			public const string EndTime = "endtime";

			/// <summary>firstdayofweek</summary>
			public const string FirstDayOfWeek = "firstdayofweek";

			/// <summary>instance</summary>
			public const string Instance = "instance";

			/// <summary>interval</summary>
			public const string Interval = "interval";

			/// <summary>isnthmonthly</summary>
			public const string NthMonthly = "isnthmonthly";

			/// <summary>isnthyearly</summary>
			public const string NthYearly = "isnthyearly";

			/// <summary>isregenerate</summary>
			public const string Regenerate = "isregenerate";

			/// <summary>isweekdaypattern</summary>
			public const string EveryWeekday = "isweekdaypattern";

			/// <summary>modifiedby</summary>
			public const string ModifiedBy = "modifiedby";

			/// <summary>modifiedbyname</summary>
			public const string Modifiedbyname = "modifiedbyname";

			/// <summary>modifiedbyyominame</summary>
			public const string Modifiedbyyominame = "modifiedbyyominame";

			/// <summary>modifiedon</summary>
			public const string ModifiedOn = "modifiedon";

			/// <summary>modifiedonbehalfby</summary>
			public const string CreatedByDelegate2 = "modifiedonbehalfby";

			/// <summary>modifiedonbehalfbyname</summary>
			public const string Modifiedonbehalfbyname = "modifiedonbehalfbyname";

			/// <summary>modifiedonbehalfbyyominame</summary>
			public const string Modifiedonbehalfbyyominame = "modifiedonbehalfbyyominame";

			/// <summary>monthofyear</summary>
			public const string MonthOfYear = "monthofyear";

			/// <summary>objectid</summary>
			public const string Regarding = "objectid";

			/// <summary>objecttypecode</summary>
			public const string ObjectType = "objecttypecode";

			/// <summary>occurrences</summary>
			public const string Occurrences = "occurrences";

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

			/// <summary>recurrencepatterntype</summary>
			public const string RecurrencePattern = "recurrencepatterntype";

			/// <summary>ruleid</summary>
			public const string RecurrenceRuleId = "ruleid";

			/// <summary>starttime</summary>
			public const string StartTime = "starttime";

			/// <summary>versionnumber</summary>
			public const string Versionnumber = "versionnumber";

		}
		#endregion

		#region Schemas
		public static class Schemas 
		{
			/// <summary>1:N recurrencerule_recurringappointmentmaster</summary>
			public const string RecurrenceruleRecurringappointmentmaster = "recurrencerule_recurringappointmentmaster";

		}
		#endregion
	}
}

