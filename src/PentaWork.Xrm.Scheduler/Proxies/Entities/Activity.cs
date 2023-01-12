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
	[EntityLogicalName("activitypointer")]
	public sealed class Activity : Entity
	{	
		public static readonly int? EntityTypeCode = 4200;
		public new const string LogicalName = "activitypointer";
		public const string PrimaryIdAttribute = "activityid";
		public const string PrimaryNameAttribute = "subject";
	
		public Activity() : base("activitypointer") { }

		#region Attributes
		/// <summary>
        /// activityadditionalparams
        /// </summary>
		[DisplayName("Activity Additional Parameters")]
		[AttributeLogicalName("activityadditionalparams")]
		public string ActivityAdditionalParameters
		{	
			get { return GetAttributeValue<string>("activityadditionalparams"); }
			set
			{ 
				if(value == ActivityAdditionalParameters) return;
				SetAttributeValue("activityadditionalparams", value);
			}
		}	
			
		/// <summary>
        /// activityid
        /// </summary>
		[DisplayName("Activity")]
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
        /// allparties
        /// </summary>
		[DisplayName("All Activity Parties")]
		[AttributeLogicalName("allparties")]
		public EntityCollection AllActivityParties
		{	
			get { return GetAttributeValue<EntityCollection>("allparties"); }
			set
			{ 
				if(value == AllActivityParties) return;
				SetAttributeValue("allparties", value);
			}
		}	
			
		/// <summary>
        /// community
        /// </summary>
		[DisplayName("Social Channel")]
		[AttributeLogicalName("community")]
		public egSocialChannel? SocialChannel
		{	
			get 
			{ 
				var optionSetValue = GetAttributeValue<OptionSetValue>("community");
				if (optionSetValue != null) return (egSocialChannel)optionSetValue.Value;
				else return null;
			}
			set 
			{ 
				if(value == SocialChannel) return;

				OptionSetValue optionSetValue = null;
				if(value != null) optionSetValue = new OptionSetValue((int)value);
				SetAttributeValue("community", optionSetValue); 
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
		[DisplayName("Date Created")]
		[AttributeLogicalName("createdon")]
		public DateTime? DateCreated
		{	
			get { return GetAttributeValue<DateTime?>("createdon"); }
			set
			{ 
				if(value == DateCreated) return;
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
        /// deliverylastattemptedon
        /// </summary>
		[DisplayName("Date Delivery Last Attempted")]
		[AttributeLogicalName("deliverylastattemptedon")]
		public DateTime? DateDeliveryLastAttempted
		{	
			get { return GetAttributeValue<DateTime?>("deliverylastattemptedon"); }
			set
			{ 
				if(value == DateDeliveryLastAttempted) return;
				SetAttributeValue("deliverylastattemptedon", value);
			}
		}	
			
		/// <summary>
        /// deliveryprioritycode
        /// </summary>
		[DisplayName("Delivery Priority")]
		[AttributeLogicalName("deliveryprioritycode")]
		public egDeliveryPriority? DeliveryPriority
		{	
			get 
			{ 
				var optionSetValue = GetAttributeValue<OptionSetValue>("deliveryprioritycode");
				if (optionSetValue != null) return (egDeliveryPriority)optionSetValue.Value;
				else return null;
			}
			set 
			{ 
				if(value == DeliveryPriority) return;

				OptionSetValue optionSetValue = null;
				if(value != null) optionSetValue = new OptionSetValue((int)value);
				SetAttributeValue("deliveryprioritycode", optionSetValue); 
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
        /// exchangeitemid
        /// </summary>
		[DisplayName("Exchange Item ID")]
		[AttributeLogicalName("exchangeitemid")]
		public string ExchangeItemID
		{	
			get { return GetAttributeValue<string>("exchangeitemid"); }
			set
			{ 
				if(value == ExchangeItemID) return;
				SetAttributeValue("exchangeitemid", value);
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
        /// exchangeweblink
        /// </summary>
		[DisplayName("Exchange WebLink")]
		[AttributeLogicalName("exchangeweblink")]
		public string ExchangeWebLink
		{	
			get { return GetAttributeValue<string>("exchangeweblink"); }
			set
			{ 
				if(value == ExchangeWebLink) return;
				SetAttributeValue("exchangeweblink", value);
			}
		}	
			
		/// <summary>
        /// instancetypecode
        /// </summary>
		[DisplayName("Recurring Instance Type")]
		[AttributeLogicalName("instancetypecode")]
		public eAppointmentType? RecurringInstanceType
		{	
			get 
			{ 
				var optionSetValue = GetAttributeValue<OptionSetValue>("instancetypecode");
				if (optionSetValue != null) return (eAppointmentType)optionSetValue.Value;
				else return null;
			}
			set 
			{ 
				if(value == RecurringInstanceType) return;

				OptionSetValue optionSetValue = null;
				if(value != null) optionSetValue = new OptionSetValue((int)value);
				SetAttributeValue("instancetypecode", optionSetValue); 
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
        /// leftvoicemail
        /// </summary>
		[DisplayName("Left Voice Mail")]
		[AttributeLogicalName("leftvoicemail")]
		public bool? LeftVoiceMail
		{	
			get { return GetAttributeValue<bool?>("leftvoicemail"); }
			set
			{ 
				if(value == LeftVoiceMail) return;
				SetAttributeValue("leftvoicemail", value);
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
		[DisplayName("Last Updated")]
		[AttributeLogicalName("modifiedon")]
		public DateTime? LastUpdated
		{	
			get { return GetAttributeValue<DateTime?>("modifiedon"); }
			set
			{ 
				if(value == LastUpdated) return;
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
        /// postponeactivityprocessinguntil
        /// </summary>
		[DisplayName("Delay activity processing until")]
		[AttributeLogicalName("postponeactivityprocessinguntil")]
		public DateTime? DelayActivityProcessingUntil
		{	
			get { return GetAttributeValue<DateTime?>("postponeactivityprocessinguntil"); }
			set
			{ 
				if(value == DelayActivityProcessingUntil) return;
				SetAttributeValue("postponeactivityprocessinguntil", value);
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
        /// scheduleddurationminutes
        /// </summary>
		[DisplayName("Scheduled Duration")]
		[AttributeLogicalName("scheduleddurationminutes")]
		public int? ScheduledDuration
		{	
			get { return GetAttributeValue<int?>("scheduleddurationminutes"); }
			set
			{ 
				if(value == ScheduledDuration) return;
				SetAttributeValue("scheduleddurationminutes", value);
			}
		}	
			
		/// <summary>
        /// scheduledend
        /// </summary>
		[DisplayName("Due Date")]
		[AttributeLogicalName("scheduledend")]
		public DateTime? DueDate
		{	
			get { return GetAttributeValue<DateTime?>("scheduledend"); }
			set
			{ 
				if(value == DueDate) return;
				SetAttributeValue("scheduledend", value);
			}
		}	
			
		/// <summary>
        /// scheduledstart
        /// </summary>
		[DisplayName("Start Date")]
		[AttributeLogicalName("scheduledstart")]
		public DateTime? StartDate
		{	
			get { return GetAttributeValue<DateTime?>("scheduledstart"); }
			set
			{ 
				if(value == StartDate) return;
				SetAttributeValue("scheduledstart", value);
			}
		}	
			
		/// <summary>
        /// sendermailboxid
        /// </summary>
		[DisplayName("Sender's Mailbox")]
		[AttributeLogicalName("sendermailboxid")]
		public EntityReference SendersMailbox
		{	
			get { return GetAttributeValue<EntityReference>("sendermailboxid"); }
			set
			{ 
				if(value == SendersMailbox) return;
				SetAttributeValue("sendermailboxid", value);
			}
		}	
			
		/// <summary>
        /// sendermailboxidname
        /// </summary>
		[DisplayName("sendermailboxidname")]
		[AttributeLogicalName("sendermailboxidname")]
		public string Sendermailboxidname
		{	
			get { return GetAttributeValue<string>("sendermailboxidname"); }
			set
			{ 
				if(value == Sendermailboxidname) return;
				SetAttributeValue("sendermailboxidname", value);
			}
		}	
			
		/// <summary>
        /// senton
        /// </summary>
		[DisplayName("Date Sent")]
		[AttributeLogicalName("senton")]
		public DateTime? DateSent
		{	
			get { return GetAttributeValue<DateTime?>("senton"); }
			set
			{ 
				if(value == DateSent) return;
				SetAttributeValue("senton", value);
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
		[DisplayName("Activity Status")]
		[AttributeLogicalName("statecode")]
		public eActivityStatus? ActivityStatus
		{	
			get 
			{ 
				var optionSetValue = GetAttributeValue<OptionSetValue>("statecode");
				if (optionSetValue != null) return (eActivityStatus)optionSetValue.Value;
				else return null;
			}
			set 
			{ 
				if(value == ActivityStatus) return;

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
        /// 1:N Get entities for 'activity_campaignresponse'
        /// </summary>
		[RelationshipSchemaName("activity_campaignresponse")]
		public IEnumerable<CampaignResponse> ActivityCampaignresponse
		{
			get { return GetRelatedEntities<CampaignResponse>("activity_campaignresponse", null); }
			set { SetRelatedEntities("activity_campaignresponse", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'activity_pointer_activity_mime_attachment'
        /// </summary>
		[RelationshipSchemaName("activity_pointer_activity_mime_attachment")]
		public IEnumerable<Attachment> ActivityPointerActivityMimeAttachment
		{
			get { return GetRelatedEntities<Attachment>("activity_pointer_activity_mime_attachment", null); }
			set { SetRelatedEntities("activity_pointer_activity_mime_attachment", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'activity_pointer_appointment'
        /// </summary>
		[RelationshipSchemaName("activity_pointer_appointment")]
		public IEnumerable<Appointment> ActivityPointerAppointment
		{
			get { return GetRelatedEntities<Appointment>("activity_pointer_appointment", null); }
			set { SetRelatedEntities("activity_pointer_appointment", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'activity_pointer_BulkOperation'
        /// </summary>
		[RelationshipSchemaName("activity_pointer_BulkOperation")]
		public IEnumerable<QuickCampaign> ActivityPointerBulkOperation
		{
			get { return GetRelatedEntities<QuickCampaign>("activity_pointer_BulkOperation", null); }
			set { SetRelatedEntities("activity_pointer_BulkOperation", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'activity_pointer_campaignactivity'
        /// </summary>
		[RelationshipSchemaName("activity_pointer_campaignactivity")]
		public IEnumerable<CampaignActivity> ActivityPointerCampaignactivity
		{
			get { return GetRelatedEntities<CampaignActivity>("activity_pointer_campaignactivity", null); }
			set { SetRelatedEntities("activity_pointer_campaignactivity", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'activity_pointer_campaignresponse'
        /// </summary>
		[RelationshipSchemaName("activity_pointer_campaignresponse")]
		public IEnumerable<CampaignResponse> ActivityPointerCampaignresponse
		{
			get { return GetRelatedEntities<CampaignResponse>("activity_pointer_campaignresponse", null); }
			set { SetRelatedEntities("activity_pointer_campaignresponse", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'activity_pointer_email'
        /// </summary>
		[RelationshipSchemaName("activity_pointer_email")]
		public IEnumerable<Email> ActivityPointerEmail
		{
			get { return GetRelatedEntities<Email>("activity_pointer_email", null); }
			set { SetRelatedEntities("activity_pointer_email", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'activity_pointer_fax'
        /// </summary>
		[RelationshipSchemaName("activity_pointer_fax")]
		public IEnumerable<Fax> ActivityPointerFax
		{
			get { return GetRelatedEntities<Fax>("activity_pointer_fax", null); }
			set { SetRelatedEntities("activity_pointer_fax", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'activity_pointer_incident_resolution'
        /// </summary>
		[RelationshipSchemaName("activity_pointer_incident_resolution")]
		public IEnumerable<CaseResolution> ActivityPointerIncidentResolution
		{
			get { return GetRelatedEntities<CaseResolution>("activity_pointer_incident_resolution", null); }
			set { SetRelatedEntities("activity_pointer_incident_resolution", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'activity_pointer_letter'
        /// </summary>
		[RelationshipSchemaName("activity_pointer_letter")]
		public IEnumerable<Letter> ActivityPointerLetter
		{
			get { return GetRelatedEntities<Letter>("activity_pointer_letter", null); }
			set { SetRelatedEntities("activity_pointer_letter", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'activity_pointer_opportunity_close'
        /// </summary>
		[RelationshipSchemaName("activity_pointer_opportunity_close")]
		public IEnumerable<OpportunityClose> ActivityPointerOpportunityClose
		{
			get { return GetRelatedEntities<OpportunityClose>("activity_pointer_opportunity_close", null); }
			set { SetRelatedEntities("activity_pointer_opportunity_close", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'activity_pointer_order_close'
        /// </summary>
		[RelationshipSchemaName("activity_pointer_order_close")]
		public IEnumerable<OrderClose> ActivityPointerOrderClose
		{
			get { return GetRelatedEntities<OrderClose>("activity_pointer_order_close", null); }
			set { SetRelatedEntities("activity_pointer_order_close", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'activity_pointer_phonecall'
        /// </summary>
		[RelationshipSchemaName("activity_pointer_phonecall")]
		public IEnumerable<PhoneCall> ActivityPointerPhonecall
		{
			get { return GetRelatedEntities<PhoneCall>("activity_pointer_phonecall", null); }
			set { SetRelatedEntities("activity_pointer_phonecall", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'activity_pointer_quote_close'
        /// </summary>
		[RelationshipSchemaName("activity_pointer_quote_close")]
		public IEnumerable<QuoteClose> ActivityPointerQuoteClose
		{
			get { return GetRelatedEntities<QuoteClose>("activity_pointer_quote_close", null); }
			set { SetRelatedEntities("activity_pointer_quote_close", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'activity_pointer_recurrencerule'
        /// </summary>
		[RelationshipSchemaName("activity_pointer_recurrencerule")]
		public IEnumerable<RecurrenceRule> ActivityPointerRecurrencerule
		{
			get { return GetRelatedEntities<RecurrenceRule>("activity_pointer_recurrencerule", null); }
			set { SetRelatedEntities("activity_pointer_recurrencerule", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'activity_pointer_recurringappointmentmaster'
        /// </summary>
		[RelationshipSchemaName("activity_pointer_recurringappointmentmaster")]
		public IEnumerable<RecurringAppointment> ActivityPointerRecurringappointmentmaster
		{
			get { return GetRelatedEntities<RecurringAppointment>("activity_pointer_recurringappointmentmaster", null); }
			set { SetRelatedEntities("activity_pointer_recurringappointmentmaster", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'activity_pointer_service_appointment'
        /// </summary>
		[RelationshipSchemaName("activity_pointer_service_appointment")]
		public IEnumerable<ServiceActivity> ActivityPointerServiceAppointment
		{
			get { return GetRelatedEntities<ServiceActivity>("activity_pointer_service_appointment", null); }
			set { SetRelatedEntities("activity_pointer_service_appointment", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'activity_pointer_socialactivity'
        /// </summary>
		[RelationshipSchemaName("activity_pointer_socialactivity")]
		public IEnumerable<SocialActivity> ActivityPointerSocialactivity
		{
			get { return GetRelatedEntities<SocialActivity>("activity_pointer_socialactivity", null); }
			set { SetRelatedEntities("activity_pointer_socialactivity", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'activity_pointer_task'
        /// </summary>
		[RelationshipSchemaName("activity_pointer_task")]
		public IEnumerable<Task> ActivityPointerTask
		{
			get { return GetRelatedEntities<Task>("activity_pointer_task", null); }
			set { SetRelatedEntities("activity_pointer_task", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'activitypointer_activity_parties'
        /// </summary>
		[RelationshipSchemaName("activitypointer_activity_parties")]
		public IEnumerable<ActivityParty> ActivitypointerActivityParties
		{
			get { return GetRelatedEntities<ActivityParty>("activitypointer_activity_parties", null); }
			set { SetRelatedEntities("activitypointer_activity_parties", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'ActivityPointer_AsyncOperations'
        /// </summary>
		[RelationshipSchemaName("ActivityPointer_AsyncOperations")]
		public IEnumerable<SystemJob> ActivityPointerAsyncOperations
		{
			get { return GetRelatedEntities<SystemJob>("ActivityPointer_AsyncOperations", null); }
			set { SetRelatedEntities("ActivityPointer_AsyncOperations", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'ActivityPointer_BulkDeleteFailures'
        /// </summary>
		[RelationshipSchemaName("ActivityPointer_BulkDeleteFailures")]
		public IEnumerable<BulkDeleteFailure> ActivityPointerBulkDeleteFailures
		{
			get { return GetRelatedEntities<BulkDeleteFailure>("ActivityPointer_BulkDeleteFailures", null); }
			set { SetRelatedEntities("ActivityPointer_BulkDeleteFailures", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'activitypointer_connections1'
        /// </summary>
		[RelationshipSchemaName("activitypointer_connections1")]
		public IEnumerable<Connection> ActivitypointerConnections1
		{
			get { return GetRelatedEntities<Connection>("activitypointer_connections1", null); }
			set { SetRelatedEntities("activitypointer_connections1", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'activitypointer_connections2'
        /// </summary>
		[RelationshipSchemaName("activitypointer_connections2")]
		public IEnumerable<Connection> ActivitypointerConnections2
		{
			get { return GetRelatedEntities<Connection>("activitypointer_connections2", null); }
			set { SetRelatedEntities("activitypointer_connections2", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'ActivityPointer_QueueItem'
        /// </summary>
		[RelationshipSchemaName("ActivityPointer_QueueItem")]
		public IEnumerable<QueueItem> ActivityPointerQueueItem
		{
			get { return GetRelatedEntities<QueueItem>("ActivityPointer_QueueItem", null); }
			set { SetRelatedEntities("ActivityPointer_QueueItem", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'slakpiinstance_activitypointer'
        /// </summary>
		[RelationshipSchemaName("slakpiinstance_activitypointer")]
		public IEnumerable<SLAKPIInstance> SlakpiinstanceActivitypointer
		{
			get { return GetRelatedEntities<SLAKPIInstance>("slakpiinstance_activitypointer", null); }
			set { SetRelatedEntities("slakpiinstance_activitypointer", null, value); }
		}
		#endregion

		#region Actions
		#endregion

		#region OptionSetEnums
		public enum egDeliveryPriority
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
		
		public enum eActivityStatus
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
		
			[Label("Open")]
			[Description(@"")]
			Open_Active = 1, 
		
			[Label("Completed")]
			[Description(@"")]
			Completed_Inactive = 2, 
		
			[Label("Canceled")]
			[Description(@"")]
			Canceled = 3, 
		
			[Label("Scheduled")]
			[Description(@"")]
			Scheduled = 4, 
		}
		
		public enum egSocialChannel
		{	
		
			[Label("Facebook")]
			[Description(@"Facebook item.")]
			Facebook = 1, 
		
			[Label("Twitter")]
			[Description(@"Twitter.")]
			Twitter = 2, 
		
			[Label("Other")]
			[Description(@"Other default")]
			Other = 0, 
		}
		
		#endregion	

		#region Properties
		public static class Properties 
		{
			/// <summary>activityadditionalparams</summary>
			public const string ActivityAdditionalParameters = "activityadditionalparams";

			/// <summary>activityid</summary>
			public const string ActivityId = "activityid";

			/// <summary>activitytypecode</summary>
			public const string ActivityType = "activitytypecode";

			/// <summary>actualdurationminutes</summary>
			public const string ActualDuration = "actualdurationminutes";

			/// <summary>actualend</summary>
			public const string ActualEnd = "actualend";

			/// <summary>actualstart</summary>
			public const string ActualStart = "actualstart";

			/// <summary>allparties</summary>
			public const string AllActivityParties = "allparties";

			/// <summary>community</summary>
			public const string SocialChannel = "community";

			/// <summary>createdby</summary>
			public const string CreatedBy = "createdby";

			/// <summary>createdbyname</summary>
			public const string Createdbyname = "createdbyname";

			/// <summary>createdbyyominame</summary>
			public const string Createdbyyominame = "createdbyyominame";

			/// <summary>createdon</summary>
			public const string DateCreated = "createdon";

			/// <summary>createdonbehalfby</summary>
			public const string CreatedByDelegate = "createdonbehalfby";

			/// <summary>createdonbehalfbyname</summary>
			public const string Createdonbehalfbyname = "createdonbehalfbyname";

			/// <summary>createdonbehalfbyyominame</summary>
			public const string Createdonbehalfbyyominame = "createdonbehalfbyyominame";

			/// <summary>deliverylastattemptedon</summary>
			public const string DateDeliveryLastAttempted = "deliverylastattemptedon";

			/// <summary>deliveryprioritycode</summary>
			public const string DeliveryPriority = "deliveryprioritycode";

			/// <summary>description</summary>
			public const string Description = "description";

			/// <summary>exchangeitemid</summary>
			public const string ExchangeItemID = "exchangeitemid";

			/// <summary>exchangerate</summary>
			public const string ExchangeRate = "exchangerate";

			/// <summary>exchangeweblink</summary>
			public const string ExchangeWebLink = "exchangeweblink";

			/// <summary>instancetypecode</summary>
			public const string RecurringInstanceType = "instancetypecode";

			/// <summary>isbilled</summary>
			public const string IsBilled = "isbilled";

			/// <summary>ismapiprivate</summary>
			public const string IsPrivate = "ismapiprivate";

			/// <summary>isregularactivity</summary>
			public const string IsRegularActivity = "isregularactivity";

			/// <summary>isworkflowcreated</summary>
			public const string IsWorkflowCreated = "isworkflowcreated";

			/// <summary>lastonholdtime</summary>
			public const string LastOnHoldTime = "lastonholdtime";

			/// <summary>leftvoicemail</summary>
			public const string LeftVoiceMail = "leftvoicemail";

			/// <summary>modifiedby</summary>
			public const string ModifiedBy = "modifiedby";

			/// <summary>modifiedbyname</summary>
			public const string Modifiedbyname = "modifiedbyname";

			/// <summary>modifiedbyyominame</summary>
			public const string Modifiedbyyominame = "modifiedbyyominame";

			/// <summary>modifiedon</summary>
			public const string LastUpdated = "modifiedon";

			/// <summary>modifiedonbehalfby</summary>
			public const string ModifiedByDelegate = "modifiedonbehalfby";

			/// <summary>modifiedonbehalfbyname</summary>
			public const string Modifiedonbehalfbyname = "modifiedonbehalfbyname";

			/// <summary>modifiedonbehalfbyyominame</summary>
			public const string Modifiedonbehalfbyyominame = "modifiedonbehalfbyyominame";

			/// <summary>onholdtime</summary>
			public const string OnHoldTimeMinutes = "onholdtime";

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

			/// <summary>postponeactivityprocessinguntil</summary>
			public const string DelayActivityProcessingUntil = "postponeactivityprocessinguntil";

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

			/// <summary>scheduleddurationminutes</summary>
			public const string ScheduledDuration = "scheduleddurationminutes";

			/// <summary>scheduledend</summary>
			public const string DueDate = "scheduledend";

			/// <summary>scheduledstart</summary>
			public const string StartDate = "scheduledstart";

			/// <summary>sendermailboxid</summary>
			public const string SendersMailbox = "sendermailboxid";

			/// <summary>sendermailboxidname</summary>
			public const string Sendermailboxidname = "sendermailboxidname";

			/// <summary>senton</summary>
			public const string DateSent = "senton";

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
			public const string ActivityStatus = "statecode";

			/// <summary>statuscode</summary>
			public const string StatusReason = "statuscode";

			/// <summary>subject</summary>
			public const string Subject = "subject";

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
			/// <summary>1:N activity_campaignresponse</summary>
			public const string ActivityCampaignresponse = "activity_campaignresponse";

			/// <summary>1:N activity_pointer_activity_mime_attachment</summary>
			public const string ActivityPointerActivityMimeAttachment = "activity_pointer_activity_mime_attachment";

			/// <summary>1:N activity_pointer_appointment</summary>
			public const string ActivityPointerAppointment = "activity_pointer_appointment";

			/// <summary>1:N activity_pointer_BulkOperation</summary>
			public const string ActivityPointerBulkOperation = "activity_pointer_BulkOperation";

			/// <summary>1:N activity_pointer_campaignactivity</summary>
			public const string ActivityPointerCampaignactivity = "activity_pointer_campaignactivity";

			/// <summary>1:N activity_pointer_campaignresponse</summary>
			public const string ActivityPointerCampaignresponse = "activity_pointer_campaignresponse";

			/// <summary>1:N activity_pointer_email</summary>
			public const string ActivityPointerEmail = "activity_pointer_email";

			/// <summary>1:N activity_pointer_fax</summary>
			public const string ActivityPointerFax = "activity_pointer_fax";

			/// <summary>1:N activity_pointer_incident_resolution</summary>
			public const string ActivityPointerIncidentResolution = "activity_pointer_incident_resolution";

			/// <summary>1:N activity_pointer_letter</summary>
			public const string ActivityPointerLetter = "activity_pointer_letter";

			/// <summary>1:N activity_pointer_opportunity_close</summary>
			public const string ActivityPointerOpportunityClose = "activity_pointer_opportunity_close";

			/// <summary>1:N activity_pointer_order_close</summary>
			public const string ActivityPointerOrderClose = "activity_pointer_order_close";

			/// <summary>1:N activity_pointer_phonecall</summary>
			public const string ActivityPointerPhonecall = "activity_pointer_phonecall";

			/// <summary>1:N activity_pointer_quote_close</summary>
			public const string ActivityPointerQuoteClose = "activity_pointer_quote_close";

			/// <summary>1:N activity_pointer_recurrencerule</summary>
			public const string ActivityPointerRecurrencerule = "activity_pointer_recurrencerule";

			/// <summary>1:N activity_pointer_recurringappointmentmaster</summary>
			public const string ActivityPointerRecurringappointmentmaster = "activity_pointer_recurringappointmentmaster";

			/// <summary>1:N activity_pointer_service_appointment</summary>
			public const string ActivityPointerServiceAppointment = "activity_pointer_service_appointment";

			/// <summary>1:N activity_pointer_socialactivity</summary>
			public const string ActivityPointerSocialactivity = "activity_pointer_socialactivity";

			/// <summary>1:N activity_pointer_task</summary>
			public const string ActivityPointerTask = "activity_pointer_task";

			/// <summary>1:N activitypointer_activity_parties</summary>
			public const string ActivitypointerActivityParties = "activitypointer_activity_parties";

			/// <summary>1:N ActivityPointer_AsyncOperations</summary>
			public const string ActivityPointerAsyncOperations = "ActivityPointer_AsyncOperations";

			/// <summary>1:N ActivityPointer_BulkDeleteFailures</summary>
			public const string ActivityPointerBulkDeleteFailures = "ActivityPointer_BulkDeleteFailures";

			/// <summary>1:N activitypointer_connections1</summary>
			public const string ActivitypointerConnections1 = "activitypointer_connections1";

			/// <summary>1:N activitypointer_connections2</summary>
			public const string ActivitypointerConnections2 = "activitypointer_connections2";

			/// <summary>1:N ActivityPointer_QueueItem</summary>
			public const string ActivityPointerQueueItem = "ActivityPointer_QueueItem";

			/// <summary>1:N slakpiinstance_activitypointer</summary>
			public const string SlakpiinstanceActivitypointer = "slakpiinstance_activitypointer";

		}
		#endregion
	}
}

