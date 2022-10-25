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
	[EntityLogicalName("bulkoperation")]
	public sealed class QuickCampaign : Entity
	{	
		public static readonly int? EntityTypeCode = 4406;
		public new const string LogicalName = "bulkoperation";
		public const string PrimaryIdAttribute = "activityid";
		public const string PrimaryNameAttribute = "subject";
	
		public QuickCampaign() : base("bulkoperation") { }

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
        /// bcc
        /// </summary>
		[DisplayName("BCC")]
		[AttributeLogicalName("bcc")]
		public EntityCollection BCC
		{	
			get { return GetAttributeValue<EntityCollection>("bcc"); }
			set
			{ 
				if(value == BCC) return;
				SetAttributeValue("bcc", value);
			}
		}	
			
		/// <summary>
        /// bulkoperationnumber
        /// </summary>
		[DisplayName("Bulk Operation Number")]
		[AttributeLogicalName("bulkoperationnumber")]
		public string BulkOperationNumber
		{	
			get { return GetAttributeValue<string>("bulkoperationnumber"); }
			set
			{ 
				if(value == BulkOperationNumber) return;
				SetAttributeValue("bulkoperationnumber", value);
			}
		}	
			
		/// <summary>
        /// cc
        /// </summary>
		[DisplayName("CC")]
		[AttributeLogicalName("cc")]
		public EntityCollection CC
		{	
			get { return GetAttributeValue<EntityCollection>("cc"); }
			set
			{ 
				if(value == CC) return;
				SetAttributeValue("cc", value);
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
        /// createdrecordtypecode
        /// </summary>
		[DisplayName("Activity Type")]
		[AttributeLogicalName("createdrecordtypecode")]
		public eActivityType? ActivityType2
		{	
			get 
			{ 
				var optionSetValue = GetAttributeValue<OptionSetValue>("createdrecordtypecode");
				if (optionSetValue != null) return (eActivityType)optionSetValue.Value;
				else return null;
			}
			set 
			{ 
				if(value == ActivityType2) return;

				OptionSetValue optionSetValue = null;
				if(value != null) optionSetValue = new OptionSetValue((int)value);
				SetAttributeValue("createdrecordtypecode", optionSetValue); 
			}
		}

		/// <summary>
        /// customers
        /// </summary>
		[DisplayName("Customers")]
		[AttributeLogicalName("customers")]
		public EntityCollection Customers
		{	
			get { return GetAttributeValue<EntityCollection>("customers"); }
			set
			{ 
				if(value == Customers) return;
				SetAttributeValue("customers", value);
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
        /// errornumber
        /// </summary>
		[DisplayName("Error Number")]
		[AttributeLogicalName("errornumber")]
		public int? ErrorNumber
		{	
			get { return GetAttributeValue<int?>("errornumber"); }
			set
			{ 
				if(value == ErrorNumber) return;
				SetAttributeValue("errornumber", value);
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
        /// failurecount
        /// </summary>
		[DisplayName("No. of Failures")]
		[AttributeLogicalName("failurecount")]
		public int? NoOfFailures
		{	
			get { return GetAttributeValue<int?>("failurecount"); }
			set
			{ 
				if(value == NoOfFailures) return;
				SetAttributeValue("failurecount", value);
			}
		}	
			
		/// <summary>
        /// from
        /// </summary>
		[DisplayName("From")]
		[AttributeLogicalName("from")]
		public EntityCollection From
		{	
			get { return GetAttributeValue<EntityCollection>("from"); }
			set
			{ 
				if(value == From) return;
				SetAttributeValue("from", value);
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
        /// operationtypecode
        /// </summary>
		[DisplayName("Operation")]
		[AttributeLogicalName("operationtypecode")]
		public eOperation? Operation
		{	
			get 
			{ 
				var optionSetValue = GetAttributeValue<OptionSetValue>("operationtypecode");
				if (optionSetValue != null) return (eOperation)optionSetValue.Value;
				else return null;
			}
			set 
			{ 
				if(value == Operation) return;

				OptionSetValue optionSetValue = null;
				if(value != null) optionSetValue = new OptionSetValue((int)value);
				SetAttributeValue("operationtypecode", optionSetValue); 
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
        /// parameters
        /// </summary>
		[DisplayName("Parameters")]
		[AttributeLogicalName("parameters")]
		public string Parameters
		{	
			get { return GetAttributeValue<string>("parameters"); }
			set
			{ 
				if(value == Parameters) return;
				SetAttributeValue("parameters", value);
			}
		}	
			
		/// <summary>
        /// partners
        /// </summary>
		[DisplayName("Outsource Vendors")]
		[AttributeLogicalName("partners")]
		public EntityCollection OutsourceVendors
		{	
			get { return GetAttributeValue<EntityCollection>("partners"); }
			set
			{ 
				if(value == OutsourceVendors) return;
				SetAttributeValue("partners", value);
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
		[DisplayName("Import File Name")]
		[AttributeLogicalName("regardingobjectid")]
		public EntityReference ImportFileName
		{	
			get { return GetAttributeValue<EntityReference>("regardingobjectid"); }
			set
			{ 
				if(value == ImportFileName) return;
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
        /// resources
        /// </summary>
		[DisplayName("Resources")]
		[AttributeLogicalName("resources")]
		public EntityCollection Resources
		{	
			get { return GetAttributeValue<EntityCollection>("resources"); }
			set
			{ 
				if(value == Resources) return;
				SetAttributeValue("resources", value);
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
		public eActivityStatus? Status
		{	
			get 
			{ 
				var optionSetValue = GetAttributeValue<OptionSetValue>("statecode");
				if (optionSetValue != null) return (eActivityStatus)optionSetValue.Value;
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
        /// successcount
        /// </summary>
		[DisplayName("No. of Successes")]
		[AttributeLogicalName("successcount")]
		public int? NoOfSuccesses
		{	
			get { return GetAttributeValue<int?>("successcount"); }
			set
			{ 
				if(value == NoOfSuccesses) return;
				SetAttributeValue("successcount", value);
			}
		}	
			
		/// <summary>
        /// targetedrecordtypecode
        /// </summary>
		[DisplayName("Members Type")]
		[AttributeLogicalName("targetedrecordtypecode")]
		public eMembersType? MembersType
		{	
			get 
			{ 
				var optionSetValue = GetAttributeValue<OptionSetValue>("targetedrecordtypecode");
				if (optionSetValue != null) return (eMembersType)optionSetValue.Value;
				else return null;
			}
			set 
			{ 
				if(value == MembersType) return;

				OptionSetValue optionSetValue = null;
				if(value != null) optionSetValue = new OptionSetValue((int)value);
				SetAttributeValue("targetedrecordtypecode", optionSetValue); 
			}
		}

		/// <summary>
        /// targetmemberscount
        /// </summary>
		[DisplayName("Total Members")]
		[AttributeLogicalName("targetmemberscount")]
		public int? TotalMembers
		{	
			get { return GetAttributeValue<int?>("targetmemberscount"); }
			set
			{ 
				if(value == TotalMembers) return;
				SetAttributeValue("targetmemberscount", value);
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
        /// to
        /// </summary>
		[DisplayName("To")]
		[AttributeLogicalName("to")]
		public EntityCollection To
		{	
			get { return GetAttributeValue<EntityCollection>("to"); }
			set
			{ 
				if(value == To) return;
				SetAttributeValue("to", value);
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
			
		/// <summary>
        /// workflowinfo
        /// </summary>
		[DisplayName("Workflow information")]
		[AttributeLogicalName("workflowinfo")]
		public string WorkflowInformation
		{	
			get { return GetAttributeValue<string>("workflowinfo"); }
			set
			{ 
				if(value == WorkflowInformation) return;
				SetAttributeValue("workflowinfo", value);
			}
		}	
			
		#endregion	

		#region Relations
			/// <summary>
        /// 1:N Get entities for 'bulkoperation_activity_parties'
        /// </summary>
		[RelationshipSchemaName("bulkoperation_activity_parties")]
		public IEnumerable<ActivityParty> BulkoperationActivityParties
		{
			get { return GetRelatedEntities<ActivityParty>("bulkoperation_activity_parties", null); }
			set { SetRelatedEntities("bulkoperation_activity_parties", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'BulkOperation_ActivityPointers'
        /// </summary>
		[RelationshipSchemaName("BulkOperation_ActivityPointers")]
		public IEnumerable<Activity> BulkOperationActivityPointers
		{
			get { return GetRelatedEntities<Activity>("BulkOperation_ActivityPointers", null); }
			set { SetRelatedEntities("BulkOperation_ActivityPointers", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'bulkoperation_Annotations'
        /// </summary>
		[RelationshipSchemaName("bulkoperation_Annotations")]
		public IEnumerable<Note> BulkoperationAnnotations
		{
			get { return GetRelatedEntities<Note>("bulkoperation_Annotations", null); }
			set { SetRelatedEntities("bulkoperation_Annotations", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'BulkOperation_Appointment'
        /// </summary>
		[RelationshipSchemaName("BulkOperation_Appointment")]
		public IEnumerable<Appointment> BulkOperationAppointment
		{
			get { return GetRelatedEntities<Appointment>("BulkOperation_Appointment", null); }
			set { SetRelatedEntities("BulkOperation_Appointment", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'BulkOperation_AsyncOperations'
        /// </summary>
		[RelationshipSchemaName("BulkOperation_AsyncOperations")]
		public IEnumerable<SystemJob> BulkOperationAsyncOperations
		{
			get { return GetRelatedEntities<SystemJob>("BulkOperation_AsyncOperations", null); }
			set { SetRelatedEntities("BulkOperation_AsyncOperations", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'BulkOperation_BulkDeleteFailures'
        /// </summary>
		[RelationshipSchemaName("BulkOperation_BulkDeleteFailures")]
		public IEnumerable<BulkDeleteFailure> BulkOperationBulkDeleteFailures
		{
			get { return GetRelatedEntities<BulkDeleteFailure>("BulkOperation_BulkDeleteFailures", null); }
			set { SetRelatedEntities("BulkOperation_BulkDeleteFailures", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'BulkOperation_CampaignResponse'
        /// </summary>
		[RelationshipSchemaName("BulkOperation_CampaignResponse")]
		public IEnumerable<CampaignResponse> BulkOperationCampaignResponse
		{
			get { return GetRelatedEntities<CampaignResponse>("BulkOperation_CampaignResponse", null); }
			set { SetRelatedEntities("BulkOperation_CampaignResponse", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'BulkOperation_Email'
        /// </summary>
		[RelationshipSchemaName("BulkOperation_Email")]
		public IEnumerable<Email> BulkOperationEmail
		{
			get { return GetRelatedEntities<Email>("BulkOperation_Email", null); }
			set { SetRelatedEntities("BulkOperation_Email", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'BulkOperation_Faxes'
        /// </summary>
		[RelationshipSchemaName("BulkOperation_Faxes")]
		public IEnumerable<Fax> BulkOperationFaxes
		{
			get { return GetRelatedEntities<Fax>("BulkOperation_Faxes", null); }
			set { SetRelatedEntities("BulkOperation_Faxes", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'bulkoperation_IncidentResolutions'
        /// </summary>
		[RelationshipSchemaName("bulkoperation_IncidentResolutions")]
		public IEnumerable<CaseResolution> BulkoperationIncidentResolutions
		{
			get { return GetRelatedEntities<CaseResolution>("bulkoperation_IncidentResolutions", null); }
			set { SetRelatedEntities("bulkoperation_IncidentResolutions", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'BulkOperation_Letter'
        /// </summary>
		[RelationshipSchemaName("BulkOperation_Letter")]
		public IEnumerable<Letter> BulkOperationLetter
		{
			get { return GetRelatedEntities<Letter>("BulkOperation_Letter", null); }
			set { SetRelatedEntities("BulkOperation_Letter", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'BulkOperation_MailboxTrackingFolder'
        /// </summary>
		[RelationshipSchemaName("BulkOperation_MailboxTrackingFolder")]
		public IEnumerable<MailboxAutoTrackingFolder> BulkOperationMailboxTrackingFolder
		{
			get { return GetRelatedEntities<MailboxAutoTrackingFolder>("BulkOperation_MailboxTrackingFolder", null); }
			set { SetRelatedEntities("BulkOperation_MailboxTrackingFolder", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'bulkoperation_OpportunityCloses'
        /// </summary>
		[RelationshipSchemaName("bulkoperation_OpportunityCloses")]
		public IEnumerable<OpportunityClose> BulkoperationOpportunityCloses
		{
			get { return GetRelatedEntities<OpportunityClose>("bulkoperation_OpportunityCloses", null); }
			set { SetRelatedEntities("bulkoperation_OpportunityCloses", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'bulkoperation_OrderCloses'
        /// </summary>
		[RelationshipSchemaName("bulkoperation_OrderCloses")]
		public IEnumerable<OrderClose> BulkoperationOrderCloses
		{
			get { return GetRelatedEntities<OrderClose>("bulkoperation_OrderCloses", null); }
			set { SetRelatedEntities("bulkoperation_OrderCloses", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'BulkOperation_Phonecall'
        /// </summary>
		[RelationshipSchemaName("BulkOperation_Phonecall")]
		public IEnumerable<PhoneCall> BulkOperationPhonecall
		{
			get { return GetRelatedEntities<PhoneCall>("BulkOperation_Phonecall", null); }
			set { SetRelatedEntities("BulkOperation_Phonecall", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'bulkoperation_PrincipalObjectAttributeAccesses'
        /// </summary>
		[RelationshipSchemaName("bulkoperation_PrincipalObjectAttributeAccesses")]
		public IEnumerable<FieldSharing> BulkoperationPrincipalObjectAttributeAccesses
		{
			get { return GetRelatedEntities<FieldSharing>("bulkoperation_PrincipalObjectAttributeAccesses", null); }
			set { SetRelatedEntities("bulkoperation_PrincipalObjectAttributeAccesses", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'BulkOperation_QueueItem'
        /// </summary>
		[RelationshipSchemaName("BulkOperation_QueueItem")]
		public IEnumerable<QueueItem> BulkOperationQueueItem
		{
			get { return GetRelatedEntities<QueueItem>("BulkOperation_QueueItem", null); }
			set { SetRelatedEntities("BulkOperation_QueueItem", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'bulkoperation_QuoteCloses'
        /// </summary>
		[RelationshipSchemaName("bulkoperation_QuoteCloses")]
		public IEnumerable<QuoteClose> BulkoperationQuoteCloses
		{
			get { return GetRelatedEntities<QuoteClose>("bulkoperation_QuoteCloses", null); }
			set { SetRelatedEntities("bulkoperation_QuoteCloses", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'BulkOperation_RecurringAppointmentMaster'
        /// </summary>
		[RelationshipSchemaName("BulkOperation_RecurringAppointmentMaster")]
		public IEnumerable<RecurringAppointment> BulkOperationRecurringAppointmentMaster
		{
			get { return GetRelatedEntities<RecurringAppointment>("BulkOperation_RecurringAppointmentMaster", null); }
			set { SetRelatedEntities("BulkOperation_RecurringAppointmentMaster", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'bulkoperation_ServiceAppointments'
        /// </summary>
		[RelationshipSchemaName("bulkoperation_ServiceAppointments")]
		public IEnumerable<ServiceActivity> BulkoperationServiceAppointments
		{
			get { return GetRelatedEntities<ServiceActivity>("bulkoperation_ServiceAppointments", null); }
			set { SetRelatedEntities("bulkoperation_ServiceAppointments", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'BulkOperation_SocialActivity'
        /// </summary>
		[RelationshipSchemaName("BulkOperation_SocialActivity")]
		public IEnumerable<SocialActivity> BulkOperationSocialActivity
		{
			get { return GetRelatedEntities<SocialActivity>("BulkOperation_SocialActivity", null); }
			set { SetRelatedEntities("BulkOperation_SocialActivity", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'BulkOperation_SyncErrors'
        /// </summary>
		[RelationshipSchemaName("BulkOperation_SyncErrors")]
		public IEnumerable<SyncError> BulkOperationSyncErrors
		{
			get { return GetRelatedEntities<SyncError>("BulkOperation_SyncErrors", null); }
			set { SetRelatedEntities("BulkOperation_SyncErrors", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'bulkoperation_Tasks'
        /// </summary>
		[RelationshipSchemaName("bulkoperation_Tasks")]
		public IEnumerable<Task> BulkoperationTasks
		{
			get { return GetRelatedEntities<Task>("bulkoperation_Tasks", null); }
			set { SetRelatedEntities("bulkoperation_Tasks", null, value); }
		}
		/// <summary>
        /// N:N Get entities for 'Account'
        /// </summary>
		[RelationshipSchemaName("BulkOperation_Accounts")]
		public IEnumerable<Account> BulkOperationAccounts
		{
			get { return GetRelatedEntities<Account>("BulkOperation_Accounts", null); }
			set { SetRelatedEntities("BulkOperation_Accounts", null, value); }
		}
		/// <summary>
        /// N:N Get entities for 'Contact'
        /// </summary>
		[RelationshipSchemaName("BulkOperation_Contacts")]
		public IEnumerable<Contact> BulkOperationContacts
		{
			get { return GetRelatedEntities<Contact>("BulkOperation_Contacts", null); }
			set { SetRelatedEntities("BulkOperation_Contacts", null, value); }
		}
		/// <summary>
        /// N:N Get entities for 'Lead'
        /// </summary>
		[RelationshipSchemaName("BulkOperation_Leads")]
		public IEnumerable<Lead> BulkOperationLeads
		{
			get { return GetRelatedEntities<Lead>("BulkOperation_Leads", null); }
			set { SetRelatedEntities("BulkOperation_Leads", null, value); }
		}
		#endregion

		#region Actions
		#endregion

		#region OptionSetEnums
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
		
		public enum eActivityType
		{	
		
			[Label("Phone Call")]
			[Description(@"")]
			PhoneCall = 1, 
		
			[Label("Fax")]
			[Description(@"")]
			Fax = 2, 
		
			[Label("Letter")]
			[Description(@"")]
			Letter = 3, 
		
			[Label("Email")]
			[Description(@"")]
			Email = 4, 
		
			[Label("Appointment")]
			[Description(@"")]
			Appointment = 5, 
		
			[Label("Send Direct Email")]
			[Description(@"")]
			SendDirectEmail = 6, 
		}
		
		public enum eOperation
		{	
		
			[Label("Create Opportunities")]
			[Description(@"")]
			CreateOpportunities = 1, 
		
			[Label("Create Activities")]
			[Description(@"")]
			CreateActivities = 2, 
		
			[Label("Send Direct Mail")]
			[Description(@"")]
			SendDirectMail = 3, 
		
			[Label("Distribute")]
			[Description(@"")]
			Distribute = 4, 
		
			[Label("Execute")]
			[Description(@"")]
			Execute = 5, 
		
			[Label("Quick Campaign")]
			[Description(@"")]
			QuickCampaign = 7, 
		}
		
		public enum eActivityStatus
		{	
		
			[Label("Open")]
			[Description(@"")]
			Open = 0, 
		
			[Label("Closed")]
			[Description(@"")]
			Closed = 1, 
		
			[Label("Canceled")]
			[Description(@"")]
			Canceled = 2, 
		}
		
		public enum eStatusReason
		{	
		
			[Label("Pending")]
			[Description(@"")]
			Pending_Active = 1, 
		
			[Label("In Progress")]
			[Description(@"")]
			InProgress_Active = 2, 
		
			[Label("Aborted")]
			[Description(@"")]
			Aborted_Inactive = 3, 
		
			[Label("Completed")]
			[Description(@"")]
			Completed_Inactive = 4, 
		
			[Label("Canceled")]
			[Description(@"")]
			Canceled = 5, 
		}
		
		public enum eMembersType
		{	
		
			[Label("Account")]
			[Description(@"")]
			Account = 1, 
		
			[Label("Contact")]
			[Description(@"")]
			Contact = 2, 
		
			[Label("Lead")]
			[Description(@"")]
			Lead = 4, 
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

			/// <summary>bcc</summary>
			public const string BCC = "bcc";

			/// <summary>bulkoperationnumber</summary>
			public const string BulkOperationNumber = "bulkoperationnumber";

			/// <summary>cc</summary>
			public const string CC = "cc";

			/// <summary>community</summary>
			public const string SocialChannel = "community";

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

			/// <summary>createdrecordtypecode</summary>
			public const string ActivityType2 = "createdrecordtypecode";

			/// <summary>customers</summary>
			public const string Customers = "customers";

			/// <summary>deliverylastattemptedon</summary>
			public const string DateDeliveryLastAttempted = "deliverylastattemptedon";

			/// <summary>deliveryprioritycode</summary>
			public const string DeliveryPriority = "deliveryprioritycode";

			/// <summary>description</summary>
			public const string Description = "description";

			/// <summary>errornumber</summary>
			public const string ErrorNumber = "errornumber";

			/// <summary>exchangeitemid</summary>
			public const string ExchangeItemID = "exchangeitemid";

			/// <summary>exchangerate</summary>
			public const string ExchangeRate = "exchangerate";

			/// <summary>exchangeweblink</summary>
			public const string ExchangeWebLink = "exchangeweblink";

			/// <summary>failurecount</summary>
			public const string NoOfFailures = "failurecount";

			/// <summary>from</summary>
			public const string From = "from";

			/// <summary>importsequencenumber</summary>
			public const string ImportSequenceNumber = "importsequencenumber";

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
			public const string ModifiedOn = "modifiedon";

			/// <summary>modifiedonbehalfby</summary>
			public const string ModifiedByDelegate = "modifiedonbehalfby";

			/// <summary>modifiedonbehalfbyname</summary>
			public const string Modifiedonbehalfbyname = "modifiedonbehalfbyname";

			/// <summary>modifiedonbehalfbyyominame</summary>
			public const string Modifiedonbehalfbyyominame = "modifiedonbehalfbyyominame";

			/// <summary>onholdtime</summary>
			public const string OnHoldTimeMinutes = "onholdtime";

			/// <summary>operationtypecode</summary>
			public const string Operation = "operationtypecode";

			/// <summary>optionalattendees</summary>
			public const string OptionalAttendees = "optionalattendees";

			/// <summary>organizer</summary>
			public const string Organizer = "organizer";

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

			/// <summary>parameters</summary>
			public const string Parameters = "parameters";

			/// <summary>partners</summary>
			public const string OutsourceVendors = "partners";

			/// <summary>postponeactivityprocessinguntil</summary>
			public const string DelayActivityProcessingUntil = "postponeactivityprocessinguntil";

			/// <summary>prioritycode</summary>
			public const string Priority = "prioritycode";

			/// <summary>processid</summary>
			public const string ProcessId = "processid";

			/// <summary>regardingobjectid</summary>
			public const string ImportFileName = "regardingobjectid";

			/// <summary>regardingobjectidname</summary>
			public const string Regardingobjectidname = "regardingobjectidname";

			/// <summary>regardingobjectidyominame</summary>
			public const string Regardingobjectidyominame = "regardingobjectidyominame";

			/// <summary>regardingobjecttypecode</summary>
			public const string Regardingobjecttypecode = "regardingobjecttypecode";

			/// <summary>requiredattendees</summary>
			public const string RequiredAttendees = "requiredattendees";

			/// <summary>resources</summary>
			public const string Resources = "resources";

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

			/// <summary>subject</summary>
			public const string Subject = "subject";

			/// <summary>successcount</summary>
			public const string NoOfSuccesses = "successcount";

			/// <summary>targetedrecordtypecode</summary>
			public const string MembersType = "targetedrecordtypecode";

			/// <summary>targetmemberscount</summary>
			public const string TotalMembers = "targetmemberscount";

			/// <summary>timezoneruleversionnumber</summary>
			public const string TimeZoneRuleVersionNumber = "timezoneruleversionnumber";

			/// <summary>to</summary>
			public const string To = "to";

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

			/// <summary>workflowinfo</summary>
			public const string WorkflowInformation = "workflowinfo";

		}
		#endregion

		#region Schemas
		public static class Schemas 
		{
			/// <summary>1:N bulkoperation_activity_parties</summary>
			public const string BulkoperationActivityParties = "bulkoperation_activity_parties";

			/// <summary>1:N BulkOperation_ActivityPointers</summary>
			public const string BulkOperationActivityPointers = "BulkOperation_ActivityPointers";

			/// <summary>1:N bulkoperation_Annotations</summary>
			public const string BulkoperationAnnotations = "bulkoperation_Annotations";

			/// <summary>1:N BulkOperation_Appointment</summary>
			public const string BulkOperationAppointment = "BulkOperation_Appointment";

			/// <summary>1:N BulkOperation_AsyncOperations</summary>
			public const string BulkOperationAsyncOperations = "BulkOperation_AsyncOperations";

			/// <summary>1:N BulkOperation_BulkDeleteFailures</summary>
			public const string BulkOperationBulkDeleteFailures = "BulkOperation_BulkDeleteFailures";

			/// <summary>1:N BulkOperation_CampaignResponse</summary>
			public const string BulkOperationCampaignResponse = "BulkOperation_CampaignResponse";

			/// <summary>1:N BulkOperation_Email</summary>
			public const string BulkOperationEmail = "BulkOperation_Email";

			/// <summary>1:N BulkOperation_Faxes</summary>
			public const string BulkOperationFaxes = "BulkOperation_Faxes";

			/// <summary>1:N bulkoperation_IncidentResolutions</summary>
			public const string BulkoperationIncidentResolutions = "bulkoperation_IncidentResolutions";

			/// <summary>1:N BulkOperation_Letter</summary>
			public const string BulkOperationLetter = "BulkOperation_Letter";

			/// <summary>1:N BulkOperation_MailboxTrackingFolder</summary>
			public const string BulkOperationMailboxTrackingFolder = "BulkOperation_MailboxTrackingFolder";

			/// <summary>1:N bulkoperation_OpportunityCloses</summary>
			public const string BulkoperationOpportunityCloses = "bulkoperation_OpportunityCloses";

			/// <summary>1:N bulkoperation_OrderCloses</summary>
			public const string BulkoperationOrderCloses = "bulkoperation_OrderCloses";

			/// <summary>1:N BulkOperation_Phonecall</summary>
			public const string BulkOperationPhonecall = "BulkOperation_Phonecall";

			/// <summary>1:N bulkoperation_PrincipalObjectAttributeAccesses</summary>
			public const string BulkoperationPrincipalObjectAttributeAccesses = "bulkoperation_PrincipalObjectAttributeAccesses";

			/// <summary>1:N BulkOperation_QueueItem</summary>
			public const string BulkOperationQueueItem = "BulkOperation_QueueItem";

			/// <summary>1:N bulkoperation_QuoteCloses</summary>
			public const string BulkoperationQuoteCloses = "bulkoperation_QuoteCloses";

			/// <summary>1:N BulkOperation_RecurringAppointmentMaster</summary>
			public const string BulkOperationRecurringAppointmentMaster = "BulkOperation_RecurringAppointmentMaster";

			/// <summary>1:N bulkoperation_ServiceAppointments</summary>
			public const string BulkoperationServiceAppointments = "bulkoperation_ServiceAppointments";

			/// <summary>1:N BulkOperation_SocialActivity</summary>
			public const string BulkOperationSocialActivity = "BulkOperation_SocialActivity";

			/// <summary>1:N BulkOperation_SyncErrors</summary>
			public const string BulkOperationSyncErrors = "BulkOperation_SyncErrors";

			/// <summary>1:N bulkoperation_Tasks</summary>
			public const string BulkoperationTasks = "bulkoperation_Tasks";

			/// <summary>N:N BulkOperation_Accounts</summary>
			public const string BulkOperationAccounts = "BulkOperation_Accounts";

			/// <summary>N:N BulkOperation_Contacts</summary>
			public const string BulkOperationContacts = "BulkOperation_Contacts";

			/// <summary>N:N BulkOperation_Leads</summary>
			public const string BulkOperationLeads = "BulkOperation_Leads";

		}
		#endregion
	}
}

