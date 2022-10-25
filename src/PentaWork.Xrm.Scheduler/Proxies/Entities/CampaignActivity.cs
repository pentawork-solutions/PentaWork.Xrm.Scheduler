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
	[EntityLogicalName("campaignactivity")]
	public sealed class CampaignActivity : Entity
	{	
		public static readonly int? EntityTypeCode = 4402;
		public new const string LogicalName = "campaignactivity";
		public const string PrimaryIdAttribute = "activityid";
		public const string PrimaryNameAttribute = "subject";
	
		public CampaignActivity() : base("campaignactivity") { }

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
		[DisplayName("Campaign Activity")]
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
        /// actualcost
        /// </summary>
		[DisplayName("Actual Cost")]
		[AttributeLogicalName("actualcost")]
		public decimal? ActualCost
		{	
			get { return GetAttributeValue<Money>("actualcost")?.Value; }
			set 
			{ 
				if(value == ActualCost) return;

				Money moneyValue = null;
				if(value != null) moneyValue = new Money(value.Value);
				SetAttributeValue("actualcost", moneyValue);  
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
        /// budgetedcost
        /// </summary>
		[DisplayName("Budget Allocated")]
		[AttributeLogicalName("budgetedcost")]
		public decimal? BudgetAllocated
		{	
			get { return GetAttributeValue<Money>("budgetedcost")?.Value; }
			set 
			{ 
				if(value == BudgetAllocated) return;

				Money moneyValue = null;
				if(value != null) moneyValue = new Money(value.Value);
				SetAttributeValue("budgetedcost", moneyValue);  
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
        /// channeltypecode
        /// </summary>
		[DisplayName("Channel")]
		[AttributeLogicalName("channeltypecode")]
		public eChannel? Channel
		{	
			get 
			{ 
				var optionSetValue = GetAttributeValue<OptionSetValue>("channeltypecode");
				if (optionSetValue != null) return (eChannel)optionSetValue.Value;
				else return null;
			}
			set 
			{ 
				if(value == Channel) return;

				OptionSetValue optionSetValue = null;
				if(value != null) optionSetValue = new OptionSetValue((int)value);
				SetAttributeValue("channeltypecode", optionSetValue); 
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
        /// donotsendonoptout
        /// </summary>
		[DisplayName("Exclude Members Who Opt Out")]
		[AttributeLogicalName("donotsendonoptout")]
		public bool? ExcludeMembersWhoOptOut
		{	
			get { return GetAttributeValue<bool?>("donotsendonoptout"); }
			set
			{ 
				if(value == ExcludeMembersWhoOptOut) return;
				SetAttributeValue("donotsendonoptout", value);
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
        /// excludeifcontactedinxdays
        /// </summary>
		[DisplayName("No. of Days")]
		[AttributeLogicalName("excludeifcontactedinxdays")]
		public int? NoOfDays
		{	
			get { return GetAttributeValue<int?>("excludeifcontactedinxdays"); }
			set
			{ 
				if(value == NoOfDays) return;
				SetAttributeValue("excludeifcontactedinxdays", value);
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
        /// ignoreinactivelistmembers
        /// </summary>
		[DisplayName("Ignore Inactive Marketing List Members")]
		[AttributeLogicalName("ignoreinactivelistmembers")]
		public bool? IgnoreInactiveMarketingListMembers
		{	
			get { return GetAttributeValue<bool?>("ignoreinactivelistmembers"); }
			set
			{ 
				if(value == IgnoreInactiveMarketingListMembers) return;
				SetAttributeValue("ignoreinactivelistmembers", value);
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
        /// regardingobjectid
        /// </summary>
		[DisplayName("Parent Campaign")]
		[AttributeLogicalName("regardingobjectid")]
		public EntityReference ParentCampaign
		{	
			get { return GetAttributeValue<EntityReference>("regardingobjectid"); }
			set
			{ 
				if(value == ParentCampaign) return;
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
        /// typecode
        /// </summary>
		[DisplayName("Type")]
		[AttributeLogicalName("typecode")]
		public eType? Type
		{	
			get 
			{ 
				var optionSetValue = GetAttributeValue<OptionSetValue>("typecode");
				if (optionSetValue != null) return (eType)optionSetValue.Value;
				else return null;
			}
			set 
			{ 
				if(value == Type) return;

				OptionSetValue optionSetValue = null;
				if(value != null) optionSetValue = new OptionSetValue((int)value);
				SetAttributeValue("typecode", optionSetValue); 
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
        /// 1:N Get entities for 'campaignactivity_activity_parties'
        /// </summary>
		[RelationshipSchemaName("campaignactivity_activity_parties")]
		public IEnumerable<ActivityParty> CampaignactivityActivityParties
		{
			get { return GetRelatedEntities<ActivityParty>("campaignactivity_activity_parties", null); }
			set { SetRelatedEntities("campaignactivity_activity_parties", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'campaignactivity_activityparties'
        /// </summary>
		[RelationshipSchemaName("campaignactivity_activityparties")]
		public IEnumerable<ActivityParty> CampaignactivityActivityparties
		{
			get { return GetRelatedEntities<ActivityParty>("campaignactivity_activityparties", null); }
			set { SetRelatedEntities("campaignactivity_activityparties", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'CampaignActivity_ActivityPointers'
        /// </summary>
		[RelationshipSchemaName("CampaignActivity_ActivityPointers")]
		public IEnumerable<Activity> CampaignActivityActivityPointers
		{
			get { return GetRelatedEntities<Activity>("CampaignActivity_ActivityPointers", null); }
			set { SetRelatedEntities("CampaignActivity_ActivityPointers", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'CampaignActivity_Annotation'
        /// </summary>
		[RelationshipSchemaName("CampaignActivity_Annotation")]
		public IEnumerable<Note> CampaignActivityAnnotation
		{
			get { return GetRelatedEntities<Note>("CampaignActivity_Annotation", null); }
			set { SetRelatedEntities("CampaignActivity_Annotation", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'CampaignActivity_Appointments'
        /// </summary>
		[RelationshipSchemaName("CampaignActivity_Appointments")]
		public IEnumerable<Appointment> CampaignActivityAppointments
		{
			get { return GetRelatedEntities<Appointment>("CampaignActivity_Appointments", null); }
			set { SetRelatedEntities("CampaignActivity_Appointments", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'CampaignActivity_AsyncOperations'
        /// </summary>
		[RelationshipSchemaName("CampaignActivity_AsyncOperations")]
		public IEnumerable<SystemJob> CampaignActivityAsyncOperations
		{
			get { return GetRelatedEntities<SystemJob>("CampaignActivity_AsyncOperations", null); }
			set { SetRelatedEntities("CampaignActivity_AsyncOperations", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'CampaignActivity_BulkDeleteFailures'
        /// </summary>
		[RelationshipSchemaName("CampaignActivity_BulkDeleteFailures")]
		public IEnumerable<BulkDeleteFailure> CampaignActivityBulkDeleteFailures
		{
			get { return GetRelatedEntities<BulkDeleteFailure>("CampaignActivity_BulkDeleteFailures", null); }
			set { SetRelatedEntities("CampaignActivity_BulkDeleteFailures", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'CampaignActivity_BulkOperations'
        /// </summary>
		[RelationshipSchemaName("CampaignActivity_BulkOperations")]
		public IEnumerable<QuickCampaign> CampaignActivityBulkOperations
		{
			get { return GetRelatedEntities<QuickCampaign>("CampaignActivity_BulkOperations", null); }
			set { SetRelatedEntities("CampaignActivity_BulkOperations", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'campaignactivity_CampaignResponses'
        /// </summary>
		[RelationshipSchemaName("campaignactivity_CampaignResponses")]
		public IEnumerable<CampaignResponse> CampaignactivityCampaignResponses
		{
			get { return GetRelatedEntities<CampaignResponse>("campaignactivity_CampaignResponses", null); }
			set { SetRelatedEntities("campaignactivity_CampaignResponses", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'campaignactivity_connections1'
        /// </summary>
		[RelationshipSchemaName("campaignactivity_connections1")]
		public IEnumerable<Connection> CampaignactivityConnections1
		{
			get { return GetRelatedEntities<Connection>("campaignactivity_connections1", null); }
			set { SetRelatedEntities("campaignactivity_connections1", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'campaignactivity_connections2'
        /// </summary>
		[RelationshipSchemaName("campaignactivity_connections2")]
		public IEnumerable<Connection> CampaignactivityConnections2
		{
			get { return GetRelatedEntities<Connection>("campaignactivity_connections2", null); }
			set { SetRelatedEntities("campaignactivity_connections2", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'CampaignActivity_Emails'
        /// </summary>
		[RelationshipSchemaName("CampaignActivity_Emails")]
		public IEnumerable<Email> CampaignActivityEmails
		{
			get { return GetRelatedEntities<Email>("CampaignActivity_Emails", null); }
			set { SetRelatedEntities("CampaignActivity_Emails", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'CampaignActivity_Faxes'
        /// </summary>
		[RelationshipSchemaName("CampaignActivity_Faxes")]
		public IEnumerable<Fax> CampaignActivityFaxes
		{
			get { return GetRelatedEntities<Fax>("CampaignActivity_Faxes", null); }
			set { SetRelatedEntities("CampaignActivity_Faxes", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'campaignactivity_IncidentResolutions'
        /// </summary>
		[RelationshipSchemaName("campaignactivity_IncidentResolutions")]
		public IEnumerable<CaseResolution> CampaignactivityIncidentResolutions
		{
			get { return GetRelatedEntities<CaseResolution>("campaignactivity_IncidentResolutions", null); }
			set { SetRelatedEntities("campaignactivity_IncidentResolutions", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'CampaignActivity_Letters'
        /// </summary>
		[RelationshipSchemaName("CampaignActivity_Letters")]
		public IEnumerable<Letter> CampaignActivityLetters
		{
			get { return GetRelatedEntities<Letter>("CampaignActivity_Letters", null); }
			set { SetRelatedEntities("CampaignActivity_Letters", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'CampaignActivity_MailboxTrackingFolder'
        /// </summary>
		[RelationshipSchemaName("CampaignActivity_MailboxTrackingFolder")]
		public IEnumerable<MailboxAutoTrackingFolder> CampaignActivityMailboxTrackingFolder
		{
			get { return GetRelatedEntities<MailboxAutoTrackingFolder>("CampaignActivity_MailboxTrackingFolder", null); }
			set { SetRelatedEntities("CampaignActivity_MailboxTrackingFolder", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'campaignactivity_OpportunityCloses'
        /// </summary>
		[RelationshipSchemaName("campaignactivity_OpportunityCloses")]
		public IEnumerable<OpportunityClose> CampaignactivityOpportunityCloses
		{
			get { return GetRelatedEntities<OpportunityClose>("campaignactivity_OpportunityCloses", null); }
			set { SetRelatedEntities("campaignactivity_OpportunityCloses", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'campaignactivity_OrderCloses'
        /// </summary>
		[RelationshipSchemaName("campaignactivity_OrderCloses")]
		public IEnumerable<OrderClose> CampaignactivityOrderCloses
		{
			get { return GetRelatedEntities<OrderClose>("campaignactivity_OrderCloses", null); }
			set { SetRelatedEntities("campaignactivity_OrderCloses", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'CampaignActivity_Phonecalls'
        /// </summary>
		[RelationshipSchemaName("CampaignActivity_Phonecalls")]
		public IEnumerable<PhoneCall> CampaignActivityPhonecalls
		{
			get { return GetRelatedEntities<PhoneCall>("CampaignActivity_Phonecalls", null); }
			set { SetRelatedEntities("CampaignActivity_Phonecalls", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'campaignactivity_principalobjectattributeaccess'
        /// </summary>
		[RelationshipSchemaName("campaignactivity_principalobjectattributeaccess")]
		public IEnumerable<FieldSharing> CampaignactivityPrincipalobjectattributeaccess
		{
			get { return GetRelatedEntities<FieldSharing>("campaignactivity_principalobjectattributeaccess", null); }
			set { SetRelatedEntities("campaignactivity_principalobjectattributeaccess", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'CampaignActivity_ProcessSessions'
        /// </summary>
		[RelationshipSchemaName("CampaignActivity_ProcessSessions")]
		public IEnumerable<ProcessSession> CampaignActivityProcessSessions
		{
			get { return GetRelatedEntities<ProcessSession>("CampaignActivity_ProcessSessions", null); }
			set { SetRelatedEntities("CampaignActivity_ProcessSessions", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'CampaignActivity_QueueItem'
        /// </summary>
		[RelationshipSchemaName("CampaignActivity_QueueItem")]
		public IEnumerable<QueueItem> CampaignActivityQueueItem
		{
			get { return GetRelatedEntities<QueueItem>("CampaignActivity_QueueItem", null); }
			set { SetRelatedEntities("CampaignActivity_QueueItem", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'campaignactivity_QuoteCloses'
        /// </summary>
		[RelationshipSchemaName("campaignactivity_QuoteCloses")]
		public IEnumerable<QuoteClose> CampaignactivityQuoteCloses
		{
			get { return GetRelatedEntities<QuoteClose>("campaignactivity_QuoteCloses", null); }
			set { SetRelatedEntities("campaignactivity_QuoteCloses", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'CampaignActivity_RecurringAppointmentMasters'
        /// </summary>
		[RelationshipSchemaName("CampaignActivity_RecurringAppointmentMasters")]
		public IEnumerable<RecurringAppointment> CampaignActivityRecurringAppointmentMasters
		{
			get { return GetRelatedEntities<RecurringAppointment>("CampaignActivity_RecurringAppointmentMasters", null); }
			set { SetRelatedEntities("CampaignActivity_RecurringAppointmentMasters", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'campaignactivity_ServiceAppointments'
        /// </summary>
		[RelationshipSchemaName("campaignactivity_ServiceAppointments")]
		public IEnumerable<ServiceActivity> CampaignactivityServiceAppointments
		{
			get { return GetRelatedEntities<ServiceActivity>("campaignactivity_ServiceAppointments", null); }
			set { SetRelatedEntities("campaignactivity_ServiceAppointments", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'campaignactivity_SocialActivities'
        /// </summary>
		[RelationshipSchemaName("campaignactivity_SocialActivities")]
		public IEnumerable<SocialActivity> CampaignactivitySocialActivities
		{
			get { return GetRelatedEntities<SocialActivity>("campaignactivity_SocialActivities", null); }
			set { SetRelatedEntities("campaignactivity_SocialActivities", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'CampaignActivity_SyncErrors'
        /// </summary>
		[RelationshipSchemaName("CampaignActivity_SyncErrors")]
		public IEnumerable<SyncError> CampaignActivitySyncErrors
		{
			get { return GetRelatedEntities<SyncError>("CampaignActivity_SyncErrors", null); }
			set { SetRelatedEntities("CampaignActivity_SyncErrors", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'CampaignActivity_Tasks'
        /// </summary>
		[RelationshipSchemaName("CampaignActivity_Tasks")]
		public IEnumerable<Task> CampaignActivityTasks
		{
			get { return GetRelatedEntities<Task>("CampaignActivity_Tasks", null); }
			set { SetRelatedEntities("CampaignActivity_Tasks", null, value); }
		}
		/// <summary>
        /// N:N Get entities for 'Account'
        /// </summary>
		[RelationshipSchemaName("CampaignActivity_Accounts")]
		public IEnumerable<Account> CampaignActivityAccounts
		{
			get { return GetRelatedEntities<Account>("CampaignActivity_Accounts", null); }
			set { SetRelatedEntities("CampaignActivity_Accounts", null, value); }
		}
		/// <summary>
        /// N:N Get entities for 'Contact'
        /// </summary>
		[RelationshipSchemaName("CampaignActivity_Contacts")]
		public IEnumerable<Contact> CampaignActivityContacts
		{
			get { return GetRelatedEntities<Contact>("CampaignActivity_Contacts", null); }
			set { SetRelatedEntities("CampaignActivity_Contacts", null, value); }
		}
		/// <summary>
        /// N:N Get entities for 'Lead'
        /// </summary>
		[RelationshipSchemaName("CampaignActivity_Leads")]
		public IEnumerable<Lead> CampaignActivityLeads
		{
			get { return GetRelatedEntities<Lead>("CampaignActivity_Leads", null); }
			set { SetRelatedEntities("CampaignActivity_Leads", null, value); }
		}
		/// <summary>
        /// N:N Get entities for 'MarketingList'
        /// </summary>
		[RelationshipSchemaName("campaignactivitylist_association")]
		public IEnumerable<MarketingList> CampaignactivitylistAssociation
		{
			get { return GetRelatedEntities<MarketingList>("campaignactivitylist_association", null); }
			set { SetRelatedEntities("campaignactivitylist_association", null, value); }
		}
		/// <summary>
        /// N:N Get entities for 'SalesLiterature'
        /// </summary>
		[RelationshipSchemaName("campaignactivitysalesliterature_association")]
		public IEnumerable<SalesLiterature> CampaignactivitysalesliteratureAssociation
		{
			get { return GetRelatedEntities<SalesLiterature>("campaignactivitysalesliterature_association", null); }
			set { SetRelatedEntities("campaignactivitysalesliterature_association", null, value); }
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
		
		public enum eChannel
		{	
		
			[Label("Phone")]
			[Description(@"")]
			Phone = 1, 
		
			[Label("Appointment")]
			[Description(@"")]
			Appointment = 2, 
		
			[Label("Letter")]
			[Description(@"")]
			Letter = 3, 
		
			[Label("Letter via Mail Merge(deprecated)")]
			[Description(@"")]
			LetterViaMailMergedeprecated = 4, 
		
			[Label("Fax")]
			[Description(@"")]
			Fax = 5, 
		
			[Label("Fax via Mail Merge(deprecated)")]
			[Description(@"")]
			FaxViaMailMergedeprecated = 6, 
		
			[Label("Email")]
			[Description(@"")]
			Email = 7, 
		
			[Label("Email via Mail Merge(deprecated)")]
			[Description(@"")]
			EmailViaMailMergedeprecated = 8, 
		
			[Label("Other")]
			[Description(@"")]
			Other = 9, 
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
		
			[Label("Closed")]
			[Description(@"")]
			Closed = 1, 
		
			[Label("Canceled")]
			[Description(@"")]
			Canceled = 2, 
		}
		
		public enum eStatusReason
		{	
		
			[Label("Proposed")]
			[Description(@"")]
			Proposed_Active = 1, 
		
			[Label("In Progress")]
			[Description(@"")]
			InProgress_Active = 0, 
		
			[Label("Closed")]
			[Description(@"")]
			Closed_Inactive = 2, 
		
			[Label("Canceled")]
			[Description(@"")]
			Canceled = 3, 
		
			[Label("Pending")]
			[Description(@"")]
			Pending_Active = 4, 
		
			[Label("System Aborted")]
			[Description(@"")]
			SystemAborted_Active = 5, 
		
			[Label("Completed")]
			[Description(@"")]
			Completed_Active = 6, 
		}
		
		public enum eType
		{	
		
			[Label("Research")]
			[Description(@"")]
			Research = 1, 
		
			[Label("Content Preparation")]
			[Description(@"")]
			ContentPreparation = 2, 
		
			[Label("Target Marketing List Creation")]
			[Description(@"")]
			TargetMarketingListCreation = 3, 
		
			[Label("Lead Qualification")]
			[Description(@"")]
			LeadQualification = 4, 
		
			[Label("Content Distribution")]
			[Description(@"")]
			ContentDistribution = 5, 
		
			[Label("Direct Initial Contact")]
			[Description(@"")]
			DirectInitialContact = 6, 
		
			[Label("Direct Follow-Up Contact")]
			[Description(@"")]
			DirectFollowUpContact = 7, 
		
			[Label("Reminder Distribution")]
			[Description(@"")]
			ReminderDistribution = 8, 
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
			public const string CampaignActivityId = "activityid";

			/// <summary>activitytypecode</summary>
			public const string ActivityType = "activitytypecode";

			/// <summary>actualcost</summary>
			public const string ActualCost = "actualcost";

			/// <summary>actualdurationminutes</summary>
			public const string ActualDuration = "actualdurationminutes";

			/// <summary>actualend</summary>
			public const string ActualEnd = "actualend";

			/// <summary>actualstart</summary>
			public const string ActualStart = "actualstart";

			/// <summary>bcc</summary>
			public const string BCC = "bcc";

			/// <summary>budgetedcost</summary>
			public const string BudgetAllocated = "budgetedcost";

			/// <summary>category</summary>
			public const string Category = "category";

			/// <summary>cc</summary>
			public const string CC = "cc";

			/// <summary>channeltypecode</summary>
			public const string Channel = "channeltypecode";

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

			/// <summary>customers</summary>
			public const string Customers = "customers";

			/// <summary>deliverylastattemptedon</summary>
			public const string DateDeliveryLastAttempted = "deliverylastattemptedon";

			/// <summary>deliveryprioritycode</summary>
			public const string DeliveryPriority = "deliveryprioritycode";

			/// <summary>description</summary>
			public const string Description = "description";

			/// <summary>donotsendonoptout</summary>
			public const string ExcludeMembersWhoOptOut = "donotsendonoptout";

			/// <summary>exchangeitemid</summary>
			public const string ExchangeItemID = "exchangeitemid";

			/// <summary>exchangerate</summary>
			public const string ExchangeRate = "exchangerate";

			/// <summary>exchangeweblink</summary>
			public const string ExchangeWebLink = "exchangeweblink";

			/// <summary>excludeifcontactedinxdays</summary>
			public const string NoOfDays = "excludeifcontactedinxdays";

			/// <summary>from</summary>
			public const string From = "from";

			/// <summary>ignoreinactivelistmembers</summary>
			public const string IgnoreInactiveMarketingListMembers = "ignoreinactivelistmembers";

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
			public const string LastUpdated = "modifiedon";

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

			/// <summary>regardingobjectid</summary>
			public const string ParentCampaign = "regardingobjectid";

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

			/// <summary>typecode</summary>
			public const string Type = "typecode";

			/// <summary>utcconversiontimezonecode</summary>
			public const string UTCConversionTimeZoneCode = "utcconversiontimezonecode";

			/// <summary>versionnumber</summary>
			public const string VersionNumber = "versionnumber";

		}
		#endregion

		#region Schemas
		public static class Schemas 
		{
			/// <summary>1:N campaignactivity_activity_parties</summary>
			public const string CampaignactivityActivityParties = "campaignactivity_activity_parties";

			/// <summary>1:N campaignactivity_activityparties</summary>
			public const string CampaignactivityActivityparties = "campaignactivity_activityparties";

			/// <summary>1:N CampaignActivity_ActivityPointers</summary>
			public const string CampaignActivityActivityPointers = "CampaignActivity_ActivityPointers";

			/// <summary>1:N CampaignActivity_Annotation</summary>
			public const string CampaignActivityAnnotation = "CampaignActivity_Annotation";

			/// <summary>1:N CampaignActivity_Appointments</summary>
			public const string CampaignActivityAppointments = "CampaignActivity_Appointments";

			/// <summary>1:N CampaignActivity_AsyncOperations</summary>
			public const string CampaignActivityAsyncOperations = "CampaignActivity_AsyncOperations";

			/// <summary>1:N CampaignActivity_BulkDeleteFailures</summary>
			public const string CampaignActivityBulkDeleteFailures = "CampaignActivity_BulkDeleteFailures";

			/// <summary>1:N CampaignActivity_BulkOperations</summary>
			public const string CampaignActivityBulkOperations = "CampaignActivity_BulkOperations";

			/// <summary>1:N campaignactivity_CampaignResponses</summary>
			public const string CampaignactivityCampaignResponses = "campaignactivity_CampaignResponses";

			/// <summary>1:N campaignactivity_connections1</summary>
			public const string CampaignactivityConnections1 = "campaignactivity_connections1";

			/// <summary>1:N campaignactivity_connections2</summary>
			public const string CampaignactivityConnections2 = "campaignactivity_connections2";

			/// <summary>1:N CampaignActivity_Emails</summary>
			public const string CampaignActivityEmails = "CampaignActivity_Emails";

			/// <summary>1:N CampaignActivity_Faxes</summary>
			public const string CampaignActivityFaxes = "CampaignActivity_Faxes";

			/// <summary>1:N campaignactivity_IncidentResolutions</summary>
			public const string CampaignactivityIncidentResolutions = "campaignactivity_IncidentResolutions";

			/// <summary>1:N CampaignActivity_Letters</summary>
			public const string CampaignActivityLetters = "CampaignActivity_Letters";

			/// <summary>1:N CampaignActivity_MailboxTrackingFolder</summary>
			public const string CampaignActivityMailboxTrackingFolder = "CampaignActivity_MailboxTrackingFolder";

			/// <summary>1:N campaignactivity_OpportunityCloses</summary>
			public const string CampaignactivityOpportunityCloses = "campaignactivity_OpportunityCloses";

			/// <summary>1:N campaignactivity_OrderCloses</summary>
			public const string CampaignactivityOrderCloses = "campaignactivity_OrderCloses";

			/// <summary>1:N CampaignActivity_Phonecalls</summary>
			public const string CampaignActivityPhonecalls = "CampaignActivity_Phonecalls";

			/// <summary>1:N campaignactivity_principalobjectattributeaccess</summary>
			public const string CampaignactivityPrincipalobjectattributeaccess = "campaignactivity_principalobjectattributeaccess";

			/// <summary>1:N CampaignActivity_ProcessSessions</summary>
			public const string CampaignActivityProcessSessions = "CampaignActivity_ProcessSessions";

			/// <summary>1:N CampaignActivity_QueueItem</summary>
			public const string CampaignActivityQueueItem = "CampaignActivity_QueueItem";

			/// <summary>1:N campaignactivity_QuoteCloses</summary>
			public const string CampaignactivityQuoteCloses = "campaignactivity_QuoteCloses";

			/// <summary>1:N CampaignActivity_RecurringAppointmentMasters</summary>
			public const string CampaignActivityRecurringAppointmentMasters = "CampaignActivity_RecurringAppointmentMasters";

			/// <summary>1:N campaignactivity_ServiceAppointments</summary>
			public const string CampaignactivityServiceAppointments = "campaignactivity_ServiceAppointments";

			/// <summary>1:N campaignactivity_SocialActivities</summary>
			public const string CampaignactivitySocialActivities = "campaignactivity_SocialActivities";

			/// <summary>1:N CampaignActivity_SyncErrors</summary>
			public const string CampaignActivitySyncErrors = "CampaignActivity_SyncErrors";

			/// <summary>1:N CampaignActivity_Tasks</summary>
			public const string CampaignActivityTasks = "CampaignActivity_Tasks";

			/// <summary>N:N CampaignActivity_Accounts</summary>
			public const string CampaignActivityAccounts = "CampaignActivity_Accounts";

			/// <summary>N:N CampaignActivity_Contacts</summary>
			public const string CampaignActivityContacts = "CampaignActivity_Contacts";

			/// <summary>N:N CampaignActivity_Leads</summary>
			public const string CampaignActivityLeads = "CampaignActivity_Leads";

			/// <summary>N:N campaignactivitylist_association</summary>
			public const string CampaignactivitylistAssociation = "campaignactivitylist_association";

			/// <summary>N:N campaignactivitysalesliterature_association</summary>
			public const string CampaignactivitysalesliteratureAssociation = "campaignactivitysalesliterature_association";

		}
		#endregion
	}
}

