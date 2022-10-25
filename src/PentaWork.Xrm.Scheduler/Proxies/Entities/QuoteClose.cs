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
	[EntityLogicalName("quoteclose")]
	public sealed class QuoteClose : Entity
	{	
		public static readonly int? EntityTypeCode = 4211;
		public new const string LogicalName = "quoteclose";
		public const string PrimaryIdAttribute = "activityid";
		public const string PrimaryNameAttribute = "subject";
	
		public QuoteClose() : base("quoteclose") { }

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
		[DisplayName("Quote Close")]
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
		[DisplayName("Closed Date")]
		[AttributeLogicalName("actualend")]
		public DateTime? ClosedDate
		{	
			get { return GetAttributeValue<DateTime?>("actualend"); }
			set
			{ 
				if(value == ClosedDate) return;
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
        /// createdbyexternalparty
        /// </summary>
		[DisplayName("Created By (External Party)")]
		[AttributeLogicalName("createdbyexternalparty")]
		public EntityReference CreatedByExternalParty
		{	
			get { return GetAttributeValue<EntityReference>("createdbyexternalparty"); }
			set
			{ 
				if(value == CreatedByExternalParty) return;
				SetAttributeValue("createdbyexternalparty", value);
			}
		}	
			
		/// <summary>
        /// createdbyexternalpartyname
        /// </summary>
		[DisplayName("createdbyexternalpartyname")]
		[AttributeLogicalName("createdbyexternalpartyname")]
		public string Createdbyexternalpartyname
		{	
			get { return GetAttributeValue<string>("createdbyexternalpartyname"); }
			set
			{ 
				if(value == Createdbyexternalpartyname) return;
				SetAttributeValue("createdbyexternalpartyname", value);
			}
		}	
			
		/// <summary>
        /// createdbyexternalpartyyominame
        /// </summary>
		[DisplayName("createdbyexternalpartyyominame")]
		[AttributeLogicalName("createdbyexternalpartyyominame")]
		public string Createdbyexternalpartyyominame
		{	
			get { return GetAttributeValue<string>("createdbyexternalpartyyominame"); }
			set
			{ 
				if(value == Createdbyexternalpartyyominame) return;
				SetAttributeValue("createdbyexternalpartyyominame", value);
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
        /// modifiedbyexternalparty
        /// </summary>
		[DisplayName("Modified By (External Party)")]
		[AttributeLogicalName("modifiedbyexternalparty")]
		public EntityReference ModifiedByExternalParty
		{	
			get { return GetAttributeValue<EntityReference>("modifiedbyexternalparty"); }
			set
			{ 
				if(value == ModifiedByExternalParty) return;
				SetAttributeValue("modifiedbyexternalparty", value);
			}
		}	
			
		/// <summary>
        /// modifiedbyexternalpartyname
        /// </summary>
		[DisplayName("modifiedbyexternalpartyname")]
		[AttributeLogicalName("modifiedbyexternalpartyname")]
		public string Modifiedbyexternalpartyname
		{	
			get { return GetAttributeValue<string>("modifiedbyexternalpartyname"); }
			set
			{ 
				if(value == Modifiedbyexternalpartyname) return;
				SetAttributeValue("modifiedbyexternalpartyname", value);
			}
		}	
			
		/// <summary>
        /// modifiedbyexternalpartyyominame
        /// </summary>
		[DisplayName("modifiedbyexternalpartyyominame")]
		[AttributeLogicalName("modifiedbyexternalpartyyominame")]
		public string Modifiedbyexternalpartyyominame
		{	
			get { return GetAttributeValue<string>("modifiedbyexternalpartyyominame"); }
			set
			{ 
				if(value == Modifiedbyexternalpartyyominame) return;
				SetAttributeValue("modifiedbyexternalpartyyominame", value);
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
        /// quoteid
        /// </summary>
		[DisplayName("Quote")]
		[AttributeLogicalName("quoteid")]
		public EntityReference Quote
		{	
			get { return GetAttributeValue<EntityReference>("quoteid"); }
			set
			{ 
				if(value == Quote) return;
				SetAttributeValue("quoteid", value);
			}
		}	
			
		/// <summary>
        /// quoteidname
        /// </summary>
		[DisplayName("quoteidname")]
		[AttributeLogicalName("quoteidname")]
		public string Quoteidname
		{	
			get { return GetAttributeValue<string>("quoteidname"); }
			set
			{ 
				if(value == Quoteidname) return;
				SetAttributeValue("quoteidname", value);
			}
		}	
			
		/// <summary>
        /// quoteidtype
        /// </summary>
		[DisplayName("quoteidtype")]
		[AttributeLogicalName("quoteidtype")]
		public string Quoteidtype
		{	
			get { return GetAttributeValue<string>("quoteidtype"); }
			set
			{ 
				if(value == Quoteidtype) return;
				SetAttributeValue("quoteidtype", value);
			}
		}	
			
		/// <summary>
        /// quotenumber
        /// </summary>
		[DisplayName("Quote Number")]
		[AttributeLogicalName("quotenumber")]
		public string QuoteNumber
		{	
			get { return GetAttributeValue<string>("quotenumber"); }
			set
			{ 
				if(value == QuoteNumber) return;
				SetAttributeValue("quotenumber", value);
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
        /// revision
        /// </summary>
		[DisplayName("Revision")]
		[AttributeLogicalName("revision")]
		public int? Revision
		{	
			get { return GetAttributeValue<int?>("revision"); }
			set
			{ 
				if(value == Revision) return;
				SetAttributeValue("revision", value);
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
		[DisplayName("Scheduled End")]
		[AttributeLogicalName("scheduledend")]
		public DateTime? ScheduledEnd
		{	
			get { return GetAttributeValue<DateTime?>("scheduledend"); }
			set
			{ 
				if(value == ScheduledEnd) return;
				SetAttributeValue("scheduledend", value);
			}
		}	
			
		/// <summary>
        /// scheduledstart
        /// </summary>
		[DisplayName("Scheduled Start")]
		[AttributeLogicalName("scheduledstart")]
		public DateTime? ScheduledStart
		{	
			get { return GetAttributeValue<DateTime?>("scheduledstart"); }
			set
			{ 
				if(value == ScheduledStart) return;
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
			
		#endregion	

		#region Relations
			/// <summary>
        /// 1:N Get entities for 'CampaignResponse_QuoteCloses'
        /// </summary>
		[RelationshipSchemaName("CampaignResponse_QuoteCloses")]
		public IEnumerable<CampaignResponse> CampaignResponseQuoteCloses
		{
			get { return GetRelatedEntities<CampaignResponse>("CampaignResponse_QuoteCloses", null); }
			set { SetRelatedEntities("CampaignResponse_QuoteCloses", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'quoteclose_activity_parties'
        /// </summary>
		[RelationshipSchemaName("quoteclose_activity_parties")]
		public IEnumerable<ActivityParty> QuotecloseActivityParties
		{
			get { return GetRelatedEntities<ActivityParty>("quoteclose_activity_parties", null); }
			set { SetRelatedEntities("quoteclose_activity_parties", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'QuoteClose_Annotation'
        /// </summary>
		[RelationshipSchemaName("QuoteClose_Annotation")]
		public IEnumerable<Note> QuoteCloseAnnotation
		{
			get { return GetRelatedEntities<Note>("QuoteClose_Annotation", null); }
			set { SetRelatedEntities("QuoteClose_Annotation", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'QuoteClose_AsyncOperations'
        /// </summary>
		[RelationshipSchemaName("QuoteClose_AsyncOperations")]
		public IEnumerable<SystemJob> QuoteCloseAsyncOperations
		{
			get { return GetRelatedEntities<SystemJob>("QuoteClose_AsyncOperations", null); }
			set { SetRelatedEntities("QuoteClose_AsyncOperations", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'QuoteClose_BulkDeleteFailures'
        /// </summary>
		[RelationshipSchemaName("QuoteClose_BulkDeleteFailures")]
		public IEnumerable<BulkDeleteFailure> QuoteCloseBulkDeleteFailures
		{
			get { return GetRelatedEntities<BulkDeleteFailure>("QuoteClose_BulkDeleteFailures", null); }
			set { SetRelatedEntities("QuoteClose_BulkDeleteFailures", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'quoteclose_MailboxTrackingFolders'
        /// </summary>
		[RelationshipSchemaName("quoteclose_MailboxTrackingFolders")]
		public IEnumerable<MailboxAutoTrackingFolder> QuotecloseMailboxTrackingFolders
		{
			get { return GetRelatedEntities<MailboxAutoTrackingFolder>("quoteclose_MailboxTrackingFolders", null); }
			set { SetRelatedEntities("quoteclose_MailboxTrackingFolders", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'quoteclose_PrincipalObjectAttributeAccesses'
        /// </summary>
		[RelationshipSchemaName("quoteclose_PrincipalObjectAttributeAccesses")]
		public IEnumerable<FieldSharing> QuoteclosePrincipalObjectAttributeAccesses
		{
			get { return GetRelatedEntities<FieldSharing>("quoteclose_PrincipalObjectAttributeAccesses", null); }
			set { SetRelatedEntities("quoteclose_PrincipalObjectAttributeAccesses", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'QuoteClose_SyncErrors'
        /// </summary>
		[RelationshipSchemaName("QuoteClose_SyncErrors")]
		public IEnumerable<SyncError> QuoteCloseSyncErrors
		{
			get { return GetRelatedEntities<SyncError>("QuoteClose_SyncErrors", null); }
			set { SetRelatedEntities("QuoteClose_SyncErrors", null, value); }
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
			public const string QuoteCloseId = "activityid";

			/// <summary>activitytypecode</summary>
			public const string ActivityType = "activitytypecode";

			/// <summary>actualdurationminutes</summary>
			public const string ActualDuration = "actualdurationminutes";

			/// <summary>actualend</summary>
			public const string ClosedDate = "actualend";

			/// <summary>actualstart</summary>
			public const string ActualStart = "actualstart";

			/// <summary>bcc</summary>
			public const string BCC = "bcc";

			/// <summary>category</summary>
			public const string Category = "category";

			/// <summary>cc</summary>
			public const string CC = "cc";

			/// <summary>community</summary>
			public const string SocialChannel = "community";

			/// <summary>createdby</summary>
			public const string CreatedBy = "createdby";

			/// <summary>createdbyexternalparty</summary>
			public const string CreatedByExternalParty = "createdbyexternalparty";

			/// <summary>createdbyexternalpartyname</summary>
			public const string Createdbyexternalpartyname = "createdbyexternalpartyname";

			/// <summary>createdbyexternalpartyyominame</summary>
			public const string Createdbyexternalpartyyominame = "createdbyexternalpartyyominame";

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

			/// <summary>customers</summary>
			public const string Customers = "customers";

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

			/// <summary>modifiedbyexternalparty</summary>
			public const string ModifiedByExternalParty = "modifiedbyexternalparty";

			/// <summary>modifiedbyexternalpartyname</summary>
			public const string Modifiedbyexternalpartyname = "modifiedbyexternalpartyname";

			/// <summary>modifiedbyexternalpartyyominame</summary>
			public const string Modifiedbyexternalpartyyominame = "modifiedbyexternalpartyyominame";

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

			/// <summary>partners</summary>
			public const string OutsourceVendors = "partners";

			/// <summary>postponeactivityprocessinguntil</summary>
			public const string DelayActivityProcessingUntil = "postponeactivityprocessinguntil";

			/// <summary>prioritycode</summary>
			public const string Priority = "prioritycode";

			/// <summary>processid</summary>
			public const string ProcessId = "processid";

			/// <summary>quoteid</summary>
			public const string Quote = "quoteid";

			/// <summary>quoteidname</summary>
			public const string Quoteidname = "quoteidname";

			/// <summary>quoteidtype</summary>
			public const string Quoteidtype = "quoteidtype";

			/// <summary>quotenumber</summary>
			public const string QuoteNumber = "quotenumber";

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

			/// <summary>resources</summary>
			public const string Resources = "resources";

			/// <summary>revision</summary>
			public const string Revision = "revision";

			/// <summary>scheduleddurationminutes</summary>
			public const string ScheduledDuration = "scheduleddurationminutes";

			/// <summary>scheduledend</summary>
			public const string ScheduledEnd = "scheduledend";

			/// <summary>scheduledstart</summary>
			public const string ScheduledStart = "scheduledstart";

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
			public const string Status = "statecode";

			/// <summary>statuscode</summary>
			public const string StatusReason = "statuscode";

			/// <summary>subcategory</summary>
			public const string SubCategory = "subcategory";

			/// <summary>subject</summary>
			public const string Subject = "subject";

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

		}
		#endregion

		#region Schemas
		public static class Schemas 
		{
			/// <summary>1:N CampaignResponse_QuoteCloses</summary>
			public const string CampaignResponseQuoteCloses = "CampaignResponse_QuoteCloses";

			/// <summary>1:N quoteclose_activity_parties</summary>
			public const string QuotecloseActivityParties = "quoteclose_activity_parties";

			/// <summary>1:N QuoteClose_Annotation</summary>
			public const string QuoteCloseAnnotation = "QuoteClose_Annotation";

			/// <summary>1:N QuoteClose_AsyncOperations</summary>
			public const string QuoteCloseAsyncOperations = "QuoteClose_AsyncOperations";

			/// <summary>1:N QuoteClose_BulkDeleteFailures</summary>
			public const string QuoteCloseBulkDeleteFailures = "QuoteClose_BulkDeleteFailures";

			/// <summary>1:N quoteclose_MailboxTrackingFolders</summary>
			public const string QuotecloseMailboxTrackingFolders = "quoteclose_MailboxTrackingFolders";

			/// <summary>1:N quoteclose_PrincipalObjectAttributeAccesses</summary>
			public const string QuoteclosePrincipalObjectAttributeAccesses = "quoteclose_PrincipalObjectAttributeAccesses";

			/// <summary>1:N QuoteClose_SyncErrors</summary>
			public const string QuoteCloseSyncErrors = "QuoteClose_SyncErrors";

		}
		#endregion
	}
}

