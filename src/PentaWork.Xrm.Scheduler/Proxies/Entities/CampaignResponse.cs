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
	[EntityLogicalName("campaignresponse")]
	public sealed class CampaignResponse : Entity
	{	
		public static readonly int? EntityTypeCode = 4401;
		public new const string LogicalName = "campaignresponse";
		public const string PrimaryIdAttribute = "activityid";
		public const string PrimaryNameAttribute = "subject";
	
		public CampaignResponse() : base("campaignresponse") { }

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
		[DisplayName("Campaign Response")]
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
        /// companyname
        /// </summary>
		[DisplayName("Company Name")]
		[AttributeLogicalName("companyname")]
		public string CompanyName
		{	
			get { return GetAttributeValue<string>("companyname"); }
			set
			{ 
				if(value == CompanyName) return;
				SetAttributeValue("companyname", value);
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
        /// customer
        /// </summary>
		[DisplayName("Customer")]
		[AttributeLogicalName("customer")]
		public EntityCollection Customer
		{	
			get { return GetAttributeValue<EntityCollection>("customer"); }
			set
			{ 
				if(value == Customer) return;
				SetAttributeValue("customer", value);
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
        /// emailaddress
        /// </summary>
		[DisplayName("Email")]
		[AttributeLogicalName("emailaddress")]
		public string Email
		{	
			get { return GetAttributeValue<string>("emailaddress"); }
			set
			{ 
				if(value == Email) return;
				SetAttributeValue("emailaddress", value);
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
        /// fax
        /// </summary>
		[DisplayName("Fax")]
		[AttributeLogicalName("fax")]
		public string Fax
		{	
			get { return GetAttributeValue<string>("fax"); }
			set
			{ 
				if(value == Fax) return;
				SetAttributeValue("fax", value);
			}
		}	
			
		/// <summary>
        /// firstname
        /// </summary>
		[DisplayName("First Name")]
		[AttributeLogicalName("firstname")]
		public string FirstName
		{	
			get { return GetAttributeValue<string>("firstname"); }
			set
			{ 
				if(value == FirstName) return;
				SetAttributeValue("firstname", value);
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
        /// lastname
        /// </summary>
		[DisplayName("Last Name")]
		[AttributeLogicalName("lastname")]
		public string LastName
		{	
			get { return GetAttributeValue<string>("lastname"); }
			set
			{ 
				if(value == LastName) return;
				SetAttributeValue("lastname", value);
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
        /// originatingactivityid
        /// </summary>
		[DisplayName("Originating Activity")]
		[AttributeLogicalName("originatingactivityid")]
		public EntityReference OriginatingActivity
		{	
			get { return GetAttributeValue<EntityReference>("originatingactivityid"); }
			set
			{ 
				if(value == OriginatingActivity) return;
				SetAttributeValue("originatingactivityid", value);
			}
		}	
			
		/// <summary>
        /// originatingactivityidtypecode
        /// </summary>
		[DisplayName("originatingactivityidtypecode")]
		[AttributeLogicalName("originatingactivityidtypecode")]
		public string Originatingactivityidtypecode
		{	
			get { return GetAttributeValue<string>("originatingactivityidtypecode"); }
			set
			{ 
				if(value == Originatingactivityidtypecode) return;
				SetAttributeValue("originatingactivityidtypecode", value);
			}
		}	
			
		/// <summary>
        /// originatingactivityidyominame
        /// </summary>
		[DisplayName("originatingactivityidyominame")]
		[AttributeLogicalName("originatingactivityidyominame")]
		public string Originatingactivityidyominame
		{	
			get { return GetAttributeValue<string>("originatingactivityidyominame"); }
			set
			{ 
				if(value == Originatingactivityidyominame) return;
				SetAttributeValue("originatingactivityidyominame", value);
			}
		}	
			
		/// <summary>
        /// originatingactivityname
        /// </summary>
		[DisplayName("originatingactivityname")]
		[AttributeLogicalName("originatingactivityname")]
		public string Originatingactivityname
		{	
			get { return GetAttributeValue<string>("originatingactivityname"); }
			set
			{ 
				if(value == Originatingactivityname) return;
				SetAttributeValue("originatingactivityname", value);
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
        /// partner
        /// </summary>
		[DisplayName("Outsource Vendor")]
		[AttributeLogicalName("partner")]
		public EntityCollection OutsourceVendor
		{	
			get { return GetAttributeValue<EntityCollection>("partner"); }
			set
			{ 
				if(value == OutsourceVendor) return;
				SetAttributeValue("partner", value);
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
        /// promotioncodename
        /// </summary>
		[DisplayName("Promotion Code")]
		[AttributeLogicalName("promotioncodename")]
		public string PromotionCode
		{	
			get { return GetAttributeValue<string>("promotioncodename"); }
			set
			{ 
				if(value == PromotionCode) return;
				SetAttributeValue("promotioncodename", value);
			}
		}	
			
		/// <summary>
        /// receivedon
        /// </summary>
		[DisplayName("Received On")]
		[AttributeLogicalName("receivedon")]
		public DateTime? ReceivedOn
		{	
			get { return GetAttributeValue<DateTime?>("receivedon"); }
			set
			{ 
				if(value == ReceivedOn) return;
				SetAttributeValue("receivedon", value);
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
        /// responsecode
        /// </summary>
		[DisplayName("Response Code")]
		[AttributeLogicalName("responsecode")]
		public eResponseCode? ResponseCode
		{	
			get 
			{ 
				var optionSetValue = GetAttributeValue<OptionSetValue>("responsecode");
				if (optionSetValue != null) return (eResponseCode)optionSetValue.Value;
				else return null;
			}
			set 
			{ 
				if(value == ResponseCode) return;

				OptionSetValue optionSetValue = null;
				if(value != null) optionSetValue = new OptionSetValue((int)value);
				SetAttributeValue("responsecode", optionSetValue); 
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
		[DisplayName("Close By")]
		[AttributeLogicalName("scheduledend")]
		public DateTime? CloseBy
		{	
			get { return GetAttributeValue<DateTime?>("scheduledend"); }
			set
			{ 
				if(value == CloseBy) return;
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
        /// telephone
        /// </summary>
		[DisplayName("Phone")]
		[AttributeLogicalName("telephone")]
		public string Phone
		{	
			get { return GetAttributeValue<string>("telephone"); }
			set
			{ 
				if(value == Phone) return;
				SetAttributeValue("telephone", value);
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
        /// yomicompanyname
        /// </summary>
		[DisplayName("Yomi Company Name")]
		[AttributeLogicalName("yomicompanyname")]
		public string YomiCompanyName
		{	
			get { return GetAttributeValue<string>("yomicompanyname"); }
			set
			{ 
				if(value == YomiCompanyName) return;
				SetAttributeValue("yomicompanyname", value);
			}
		}	
			
		/// <summary>
        /// yomifirstname
        /// </summary>
		[DisplayName("Yomi First Name")]
		[AttributeLogicalName("yomifirstname")]
		public string YomiFirstName
		{	
			get { return GetAttributeValue<string>("yomifirstname"); }
			set
			{ 
				if(value == YomiFirstName) return;
				SetAttributeValue("yomifirstname", value);
			}
		}	
			
		/// <summary>
        /// yomilastname
        /// </summary>
		[DisplayName("Yomi Last Name")]
		[AttributeLogicalName("yomilastname")]
		public string YomiLastName
		{	
			get { return GetAttributeValue<string>("yomilastname"); }
			set
			{ 
				if(value == YomiLastName) return;
				SetAttributeValue("yomilastname", value);
			}
		}	
			
		#endregion	

		#region Relations
			/// <summary>
        /// 1:N Get entities for 'campaignresponse_activity_parties'
        /// </summary>
		[RelationshipSchemaName("campaignresponse_activity_parties")]
		public IEnumerable<ActivityParty> CampaignresponseActivityParties
		{
			get { return GetRelatedEntities<ActivityParty>("campaignresponse_activity_parties", null); }
			set { SetRelatedEntities("campaignresponse_activity_parties", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'CampaignResponse_Annotation'
        /// </summary>
		[RelationshipSchemaName("CampaignResponse_Annotation")]
		public IEnumerable<Note> CampaignResponseAnnotation
		{
			get { return GetRelatedEntities<Note>("CampaignResponse_Annotation", null); }
			set { SetRelatedEntities("CampaignResponse_Annotation", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'CampaignResponse_AsyncOperations'
        /// </summary>
		[RelationshipSchemaName("CampaignResponse_AsyncOperations")]
		public IEnumerable<SystemJob> CampaignResponseAsyncOperations
		{
			get { return GetRelatedEntities<SystemJob>("CampaignResponse_AsyncOperations", null); }
			set { SetRelatedEntities("CampaignResponse_AsyncOperations", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'CampaignResponse_BulkDeleteFailures'
        /// </summary>
		[RelationshipSchemaName("CampaignResponse_BulkDeleteFailures")]
		public IEnumerable<BulkDeleteFailure> CampaignResponseBulkDeleteFailures
		{
			get { return GetRelatedEntities<BulkDeleteFailure>("CampaignResponse_BulkDeleteFailures", null); }
			set { SetRelatedEntities("CampaignResponse_BulkDeleteFailures", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'CampaignResponse_DuplicateBaseRecord'
        /// </summary>
		[RelationshipSchemaName("CampaignResponse_DuplicateBaseRecord")]
		public IEnumerable<DuplicateRecord> CampaignResponseDuplicateBaseRecord
		{
			get { return GetRelatedEntities<DuplicateRecord>("CampaignResponse_DuplicateBaseRecord", null); }
			set { SetRelatedEntities("CampaignResponse_DuplicateBaseRecord", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'CampaignResponse_DuplicateMatchingRecord'
        /// </summary>
		[RelationshipSchemaName("CampaignResponse_DuplicateMatchingRecord")]
		public IEnumerable<DuplicateRecord> CampaignResponseDuplicateMatchingRecord
		{
			get { return GetRelatedEntities<DuplicateRecord>("CampaignResponse_DuplicateMatchingRecord", null); }
			set { SetRelatedEntities("CampaignResponse_DuplicateMatchingRecord", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'CampaignResponse_Lead'
        /// </summary>
		[RelationshipSchemaName("CampaignResponse_Lead")]
		public IEnumerable<Lead> CampaignResponseLead
		{
			get { return GetRelatedEntities<Lead>("CampaignResponse_Lead", null); }
			set { SetRelatedEntities("CampaignResponse_Lead", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'campaignresponse_MailboxTrackingFolders'
        /// </summary>
		[RelationshipSchemaName("campaignresponse_MailboxTrackingFolders")]
		public IEnumerable<MailboxAutoTrackingFolder> CampaignresponseMailboxTrackingFolders
		{
			get { return GetRelatedEntities<MailboxAutoTrackingFolder>("campaignresponse_MailboxTrackingFolders", null); }
			set { SetRelatedEntities("campaignresponse_MailboxTrackingFolders", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'campaignresponse_principalobjectattributeaccess'
        /// </summary>
		[RelationshipSchemaName("campaignresponse_principalobjectattributeaccess")]
		public IEnumerable<FieldSharing> CampaignresponsePrincipalobjectattributeaccess
		{
			get { return GetRelatedEntities<FieldSharing>("campaignresponse_principalobjectattributeaccess", null); }
			set { SetRelatedEntities("campaignresponse_principalobjectattributeaccess", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'CampaignResponse_ProcessSessions'
        /// </summary>
		[RelationshipSchemaName("CampaignResponse_ProcessSessions")]
		public IEnumerable<ProcessSession> CampaignResponseProcessSessions
		{
			get { return GetRelatedEntities<ProcessSession>("CampaignResponse_ProcessSessions", null); }
			set { SetRelatedEntities("CampaignResponse_ProcessSessions", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'CampaignResponse_QueueItem'
        /// </summary>
		[RelationshipSchemaName("CampaignResponse_QueueItem")]
		public IEnumerable<QueueItem> CampaignResponseQueueItem
		{
			get { return GetRelatedEntities<QueueItem>("CampaignResponse_QueueItem", null); }
			set { SetRelatedEntities("CampaignResponse_QueueItem", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'CampaignResponse_SyncErrors'
        /// </summary>
		[RelationshipSchemaName("CampaignResponse_SyncErrors")]
		public IEnumerable<SyncError> CampaignResponseSyncErrors
		{
			get { return GetRelatedEntities<SyncError>("CampaignResponse_SyncErrors", null); }
			set { SetRelatedEntities("CampaignResponse_SyncErrors", null, value); }
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
		
			[Label("Email")]
			[Description(@"")]
			Email = 1, 
		
			[Label("Phone")]
			[Description(@"")]
			Phone = 2, 
		
			[Label("Fax")]
			[Description(@"")]
			Fax = 3, 
		
			[Label("Letter")]
			[Description(@"")]
			Letter = 4, 
		
			[Label("Appointment")]
			[Description(@"")]
			Appointment = 5, 
		
			[Label("Others")]
			[Description(@"")]
			Others = 6, 
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
		
		public enum eResponseCode
		{	
		
			[Label("Interested")]
			[Description(@"")]
			Interested = 1, 
		
			[Label("Not Interested")]
			[Description(@"")]
			NotInterested = 2, 
		
			[Label("Do Not Send Marketing Materials")]
			[Description(@"")]
			DoNotSendMarketingMaterials = 3, 
		
			[Label("Error")]
			[Description(@"")]
			Error = 4, 
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
		
			[Label("Open")]
			[Description(@"")]
			Open_Active = 1, 
		
			[Label("Closed")]
			[Description(@"")]
			Closed_Inactive = 2, 
		
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
			public const string AdditionalParameters = "activityadditionalparams";

			/// <summary>activityid</summary>
			public const string CampaignResponseId = "activityid";

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

			/// <summary>category</summary>
			public const string Category = "category";

			/// <summary>cc</summary>
			public const string CC = "cc";

			/// <summary>channeltypecode</summary>
			public const string Channel = "channeltypecode";

			/// <summary>community</summary>
			public const string SocialChannel = "community";

			/// <summary>companyname</summary>
			public const string CompanyName = "companyname";

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

			/// <summary>customer</summary>
			public const string Customer = "customer";

			/// <summary>customers</summary>
			public const string Customers = "customers";

			/// <summary>deliverylastattemptedon</summary>
			public const string DateDeliveryLastAttempted = "deliverylastattemptedon";

			/// <summary>deliveryprioritycode</summary>
			public const string DeliveryPriority = "deliveryprioritycode";

			/// <summary>description</summary>
			public const string Description = "description";

			/// <summary>emailaddress</summary>
			public const string Email = "emailaddress";

			/// <summary>exchangeitemid</summary>
			public const string ExchangeItemID = "exchangeitemid";

			/// <summary>exchangerate</summary>
			public const string ExchangeRate = "exchangerate";

			/// <summary>exchangeweblink</summary>
			public const string ExchangeWebLink = "exchangeweblink";

			/// <summary>fax</summary>
			public const string Fax = "fax";

			/// <summary>firstname</summary>
			public const string FirstName = "firstname";

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

			/// <summary>lastname</summary>
			public const string LastName = "lastname";

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

			/// <summary>originatingactivityid</summary>
			public const string OriginatingActivity = "originatingactivityid";

			/// <summary>originatingactivityidtypecode</summary>
			public const string Originatingactivityidtypecode = "originatingactivityidtypecode";

			/// <summary>originatingactivityidyominame</summary>
			public const string Originatingactivityidyominame = "originatingactivityidyominame";

			/// <summary>originatingactivityname</summary>
			public const string Originatingactivityname = "originatingactivityname";

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

			/// <summary>partner</summary>
			public const string OutsourceVendor = "partner";

			/// <summary>partners</summary>
			public const string OutsourceVendors = "partners";

			/// <summary>postponeactivityprocessinguntil</summary>
			public const string DelayActivityProcessingUntil = "postponeactivityprocessinguntil";

			/// <summary>prioritycode</summary>
			public const string Priority = "prioritycode";

			/// <summary>processid</summary>
			public const string ProcessId = "processid";

			/// <summary>promotioncodename</summary>
			public const string PromotionCode = "promotioncodename";

			/// <summary>receivedon</summary>
			public const string ReceivedOn = "receivedon";

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

			/// <summary>responsecode</summary>
			public const string ResponseCode = "responsecode";

			/// <summary>scheduleddurationminutes</summary>
			public const string ScheduledDuration = "scheduleddurationminutes";

			/// <summary>scheduledend</summary>
			public const string CloseBy = "scheduledend";

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

			/// <summary>telephone</summary>
			public const string Phone = "telephone";

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

			/// <summary>yomicompanyname</summary>
			public const string YomiCompanyName = "yomicompanyname";

			/// <summary>yomifirstname</summary>
			public const string YomiFirstName = "yomifirstname";

			/// <summary>yomilastname</summary>
			public const string YomiLastName = "yomilastname";

		}
		#endregion

		#region Schemas
		public static class Schemas 
		{
			/// <summary>1:N campaignresponse_activity_parties</summary>
			public const string CampaignresponseActivityParties = "campaignresponse_activity_parties";

			/// <summary>1:N CampaignResponse_Annotation</summary>
			public const string CampaignResponseAnnotation = "CampaignResponse_Annotation";

			/// <summary>1:N CampaignResponse_AsyncOperations</summary>
			public const string CampaignResponseAsyncOperations = "CampaignResponse_AsyncOperations";

			/// <summary>1:N CampaignResponse_BulkDeleteFailures</summary>
			public const string CampaignResponseBulkDeleteFailures = "CampaignResponse_BulkDeleteFailures";

			/// <summary>1:N CampaignResponse_DuplicateBaseRecord</summary>
			public const string CampaignResponseDuplicateBaseRecord = "CampaignResponse_DuplicateBaseRecord";

			/// <summary>1:N CampaignResponse_DuplicateMatchingRecord</summary>
			public const string CampaignResponseDuplicateMatchingRecord = "CampaignResponse_DuplicateMatchingRecord";

			/// <summary>1:N CampaignResponse_Lead</summary>
			public const string CampaignResponseLead = "CampaignResponse_Lead";

			/// <summary>1:N campaignresponse_MailboxTrackingFolders</summary>
			public const string CampaignresponseMailboxTrackingFolders = "campaignresponse_MailboxTrackingFolders";

			/// <summary>1:N campaignresponse_principalobjectattributeaccess</summary>
			public const string CampaignresponsePrincipalobjectattributeaccess = "campaignresponse_principalobjectattributeaccess";

			/// <summary>1:N CampaignResponse_ProcessSessions</summary>
			public const string CampaignResponseProcessSessions = "CampaignResponse_ProcessSessions";

			/// <summary>1:N CampaignResponse_QueueItem</summary>
			public const string CampaignResponseQueueItem = "CampaignResponse_QueueItem";

			/// <summary>1:N CampaignResponse_SyncErrors</summary>
			public const string CampaignResponseSyncErrors = "CampaignResponse_SyncErrors";

		}
		#endregion
	}
}

