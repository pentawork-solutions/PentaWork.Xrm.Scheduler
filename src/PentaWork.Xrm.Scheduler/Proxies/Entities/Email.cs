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
	[EntityLogicalName("email")]
	public sealed class Email : Entity
	{	
		public static readonly int? EntityTypeCode = 4202;
		public new const string LogicalName = "email";
		public const string PrimaryIdAttribute = "activityid";
		public const string PrimaryNameAttribute = "subject";
	
		public Email() : base("email") { }

		#region Attributes
		/// <summary>
        /// acceptingentityid
        /// </summary>
		[DisplayName("Accepting Entity")]
		[AttributeLogicalName("acceptingentityid")]
		public EntityReference AcceptingEntity
		{	
			get { return GetAttributeValue<EntityReference>("acceptingentityid"); }
			set
			{ 
				if(Attributes.ContainsKey("acceptingentityid") && value == AcceptingEntity) return;
				SetAttributeValue("acceptingentityid", value);
			}
		}	
			
		/// <summary>
        /// acceptingentityidname
        /// </summary>
		[DisplayName("Accepting Entity Name")]
		[AttributeLogicalName("acceptingentityidname")]
		public string AcceptingEntityName
		{	
			get { return GetAttributeValue<string>("acceptingentityidname"); }
			set
			{ 
				if(Attributes.ContainsKey("acceptingentityidname") && value == AcceptingEntityName) return;
				SetAttributeValue("acceptingentityidname", value);
			}
		}	
			
		/// <summary>
        /// acceptingentitytypecode
        /// </summary>
		[DisplayName("Accepting User Or Queue Object Type")]
		[AttributeLogicalName("acceptingentitytypecode")]
		public string AcceptingUserOrQueueObjectType
		{	
			get { return GetAttributeValue<string>("acceptingentitytypecode"); }
			set
			{ 
				if(Attributes.ContainsKey("acceptingentitytypecode") && value == AcceptingUserOrQueueObjectType) return;
				SetAttributeValue("acceptingentitytypecode", value);
			}
		}	
			
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
				if(Attributes.ContainsKey("activityadditionalparams") && value == AdditionalParameters) return;
				SetAttributeValue("activityadditionalparams", value);
			}
		}	
			
		/// <summary>
        /// activityid
        /// </summary>
		[DisplayName("Email Message")]
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
				if(Attributes.ContainsKey("activitytypecode") && value == ActivityType) return;
				SetAttributeValue("activitytypecode", value);
			}
		}	
			
		/// <summary>
        /// actualdurationminutes
        /// </summary>
		[DisplayName("Duration")]
		[AttributeLogicalName("actualdurationminutes")]
		public int? Duration
		{	
			get { return GetAttributeValue<int?>("actualdurationminutes"); }
			set
			{ 
				if(Attributes.ContainsKey("actualdurationminutes") && value == Duration) return;
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
				if(Attributes.ContainsKey("actualend") && value == ActualEnd) return;
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
				if(Attributes.ContainsKey("actualstart") && value == ActualStart) return;
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
				if(Attributes.ContainsKey("attachmentcount") && value == AttachmentCount) return;
				SetAttributeValue("attachmentcount", value);
			}
		}	
			
		/// <summary>
        /// attachmentopencount
        /// </summary>
		[DisplayName("Attachment Open Count")]
		[AttributeLogicalName("attachmentopencount")]
		public int? AttachmentOpenCount
		{	
			get { return GetAttributeValue<int?>("attachmentopencount"); }
			set
			{ 
				if(Attributes.ContainsKey("attachmentopencount") && value == AttachmentOpenCount) return;
				SetAttributeValue("attachmentopencount", value);
			}
		}	
			
		/// <summary>
        /// baseconversationindexhash
        /// </summary>
		[DisplayName("Conversation Index (Hash)")]
		[AttributeLogicalName("baseconversationindexhash")]
		public int? ConversationIndexHash
		{	
			get { return GetAttributeValue<int?>("baseconversationindexhash"); }
			set
			{ 
				if(Attributes.ContainsKey("baseconversationindexhash") && value == ConversationIndexHash) return;
				SetAttributeValue("baseconversationindexhash", value);
			}
		}	
			
		/// <summary>
        /// bcc
        /// </summary>
		[DisplayName("Bcc")]
		[AttributeLogicalName("bcc")]
		public EntityCollection Bcc
		{	
			get { return GetAttributeValue<EntityCollection>("bcc"); }
			set
			{ 
				if(Attributes.ContainsKey("bcc") && value == Bcc) return;
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
				if(Attributes.ContainsKey("category") && value == Category) return;
				SetAttributeValue("category", value);
			}
		}	
			
		/// <summary>
        /// cc
        /// </summary>
		[DisplayName("Cc")]
		[AttributeLogicalName("cc")]
		public EntityCollection Cc
		{	
			get { return GetAttributeValue<EntityCollection>("cc"); }
			set
			{ 
				if(Attributes.ContainsKey("cc") && value == Cc) return;
				SetAttributeValue("cc", value);
			}
		}	
			
		/// <summary>
        /// compressed
        /// </summary>
		[DisplayName("Compression")]
		[AttributeLogicalName("compressed")]
		public bool? Compression
		{	
			get { return GetAttributeValue<bool?>("compressed"); }
			set
			{ 
				if(Attributes.ContainsKey("compressed") && value == Compression) return;
				SetAttributeValue("compressed", value);
			}
		}	
			
		/// <summary>
        /// conversationindex
        /// </summary>
		[DisplayName("Conversation Index")]
		[AttributeLogicalName("conversationindex")]
		public string ConversationIndex
		{	
			get { return GetAttributeValue<string>("conversationindex"); }
			set
			{ 
				if(Attributes.ContainsKey("conversationindex") && value == ConversationIndex) return;
				SetAttributeValue("conversationindex", value);
			}
		}	
			
		/// <summary>
        /// conversationtrackingid
        /// </summary>
		[DisplayName("Conversation Tracking Id")]
		[AttributeLogicalName("conversationtrackingid")]
		public Guid ConversationTrackingId
		{	
			get { return GetAttributeValue<Guid>("conversationtrackingid"); }
			set
			{ 
				if(Attributes.ContainsKey("conversationtrackingid") && value == ConversationTrackingId) return;
				SetAttributeValue("conversationtrackingid", value);
			}
		}	
			
		/// <summary>
        /// correlatedactivityid
        /// </summary>
		[DisplayName("Correlated Activity Id")]
		[AttributeLogicalName("correlatedactivityid")]
		public EntityReference CorrelatedActivityId
		{	
			get { return GetAttributeValue<EntityReference>("correlatedactivityid"); }
			set
			{ 
				if(Attributes.ContainsKey("correlatedactivityid") && value == CorrelatedActivityId) return;
				SetAttributeValue("correlatedactivityid", value);
			}
		}	
			
		/// <summary>
        /// correlatedactivityidname
        /// </summary>
		[DisplayName("correlatedactivityidname")]
		[AttributeLogicalName("correlatedactivityidname")]
		public string Correlatedactivityidname
		{	
			get { return GetAttributeValue<string>("correlatedactivityidname"); }
			set
			{ 
				if(Attributes.ContainsKey("correlatedactivityidname") && value == Correlatedactivityidname) return;
				SetAttributeValue("correlatedactivityidname", value);
			}
		}	
			
		/// <summary>
        /// correlatedsubjectchanged
        /// </summary>
		[DisplayName("Correlated subject changed")]
		[AttributeLogicalName("correlatedsubjectchanged")]
		public bool? CorrelatedSubjectChanged
		{	
			get { return GetAttributeValue<bool?>("correlatedsubjectchanged"); }
			set
			{ 
				if(Attributes.ContainsKey("correlatedsubjectchanged") && value == CorrelatedSubjectChanged) return;
				SetAttributeValue("correlatedsubjectchanged", value);
			}
		}	
			
		/// <summary>
        /// correlationmethod
        /// </summary>
		[DisplayName("Correlation Method")]
		[AttributeLogicalName("correlationmethod")]
		public eCorrelationMethod? CorrelationMethod
		{	
			get 
			{ 
				var optionSetValue = GetAttributeValue<OptionSetValue>("correlationmethod");
				if (optionSetValue != null) return (eCorrelationMethod)optionSetValue.Value;
				else return null;
			}
			set 
			{ 
				if(Attributes.ContainsKey("correlationmethod") && value == CorrelationMethod) return;

				OptionSetValue optionSetValue = null;
				if(value != null) optionSetValue = new OptionSetValue((int)value);
				SetAttributeValue("correlationmethod", optionSetValue); 
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
				if(Attributes.ContainsKey("createdby") && value == CreatedBy) return;
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
				if(Attributes.ContainsKey("createdbyname") && value == Createdbyname) return;
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
				if(Attributes.ContainsKey("createdbyyominame") && value == Createdbyyominame) return;
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
				if(Attributes.ContainsKey("createdon") && value == CreatedOn) return;
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
				if(Attributes.ContainsKey("createdonbehalfby") && value == CreatedByDelegate) return;
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
				if(Attributes.ContainsKey("createdonbehalfbyname") && value == Createdonbehalfbyname) return;
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
				if(Attributes.ContainsKey("createdonbehalfbyyominame") && value == Createdonbehalfbyyominame) return;
				SetAttributeValue("createdonbehalfbyyominame", value);
			}
		}	
			
		/// <summary>
        /// delayedemailsendtime
        /// </summary>
		[DisplayName("Send Later")]
		[AttributeLogicalName("delayedemailsendtime")]
		public DateTime? SendLater
		{	
			get { return GetAttributeValue<DateTime?>("delayedemailsendtime"); }
			set
			{ 
				if(Attributes.ContainsKey("delayedemailsendtime") && value == SendLater) return;
				SetAttributeValue("delayedemailsendtime", value);
			}
		}	
			
		/// <summary>
        /// deliveryattempts
        /// </summary>
		[DisplayName("No. of Delivery Attempts")]
		[AttributeLogicalName("deliveryattempts")]
		public int? NoOfDeliveryAttempts
		{	
			get { return GetAttributeValue<int?>("deliveryattempts"); }
			set
			{ 
				if(Attributes.ContainsKey("deliveryattempts") && value == NoOfDeliveryAttempts) return;
				SetAttributeValue("deliveryattempts", value);
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
				if(Attributes.ContainsKey("deliveryprioritycode") && value == DeliveryPriority) return;

				OptionSetValue optionSetValue = null;
				if(value != null) optionSetValue = new OptionSetValue((int)value);
				SetAttributeValue("deliveryprioritycode", optionSetValue); 
			}
		}

		/// <summary>
        /// deliveryreceiptrequested
        /// </summary>
		[DisplayName("Delivery Receipt Requested")]
		[AttributeLogicalName("deliveryreceiptrequested")]
		public bool? DeliveryReceiptRequested
		{	
			get { return GetAttributeValue<bool?>("deliveryreceiptrequested"); }
			set
			{ 
				if(Attributes.ContainsKey("deliveryreceiptrequested") && value == DeliveryReceiptRequested) return;
				SetAttributeValue("deliveryreceiptrequested", value);
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
				if(Attributes.ContainsKey("description") && value == Description) return;
				SetAttributeValue("description", value);
			}
		}	
			
		/// <summary>
        /// descriptionblobid_name
        /// </summary>
		[DisplayName("descriptionblobid_name")]
		[AttributeLogicalName("descriptionblobid_name")]
		public string DescriptionblobidName
		{	
			get { return GetAttributeValue<string>("descriptionblobid_name"); }
			set
			{ 
				if(Attributes.ContainsKey("descriptionblobid_name") && value == DescriptionblobidName) return;
				SetAttributeValue("descriptionblobid_name", value);
			}
		}	
			
		/// <summary>
        /// directioncode
        /// </summary>
		[DisplayName("Direction")]
		[AttributeLogicalName("directioncode")]
		public bool? Direction
		{	
			get { return GetAttributeValue<bool?>("directioncode"); }
			set
			{ 
				if(Attributes.ContainsKey("directioncode") && value == Direction) return;
				SetAttributeValue("directioncode", value);
			}
		}	
			
		/// <summary>
        /// emailreminderexpirytime
        /// </summary>
		[DisplayName("Email Reminder Expiry Time")]
		[AttributeLogicalName("emailreminderexpirytime")]
		public DateTime? EmailReminderExpiryTime
		{	
			get { return GetAttributeValue<DateTime?>("emailreminderexpirytime"); }
			set
			{ 
				if(Attributes.ContainsKey("emailreminderexpirytime") && value == EmailReminderExpiryTime) return;
				SetAttributeValue("emailreminderexpirytime", value);
			}
		}	
			
		/// <summary>
        /// emailreminderstatus
        /// </summary>
		[DisplayName("Email Reminder Status")]
		[AttributeLogicalName("emailreminderstatus")]
		public eEmailReminderStatus? EmailReminderStatus
		{	
			get 
			{ 
				var optionSetValue = GetAttributeValue<OptionSetValue>("emailreminderstatus");
				if (optionSetValue != null) return (eEmailReminderStatus)optionSetValue.Value;
				else return null;
			}
			set 
			{ 
				if(Attributes.ContainsKey("emailreminderstatus") && value == EmailReminderStatus) return;

				OptionSetValue optionSetValue = null;
				if(value != null) optionSetValue = new OptionSetValue((int)value);
				SetAttributeValue("emailreminderstatus", optionSetValue); 
			}
		}

		/// <summary>
        /// emailremindertext
        /// </summary>
		[DisplayName("Email Reminder Text")]
		[AttributeLogicalName("emailremindertext")]
		public string EmailReminderText
		{	
			get { return GetAttributeValue<string>("emailremindertext"); }
			set
			{ 
				if(Attributes.ContainsKey("emailremindertext") && value == EmailReminderText) return;
				SetAttributeValue("emailremindertext", value);
			}
		}	
			
		/// <summary>
        /// emailremindertype
        /// </summary>
		[DisplayName("Email Reminder Type")]
		[AttributeLogicalName("emailremindertype")]
		public eEmailReminderType? EmailReminderType
		{	
			get 
			{ 
				var optionSetValue = GetAttributeValue<OptionSetValue>("emailremindertype");
				if (optionSetValue != null) return (eEmailReminderType)optionSetValue.Value;
				else return null;
			}
			set 
			{ 
				if(Attributes.ContainsKey("emailremindertype") && value == EmailReminderType) return;

				OptionSetValue optionSetValue = null;
				if(value != null) optionSetValue = new OptionSetValue((int)value);
				SetAttributeValue("emailremindertype", optionSetValue); 
			}
		}

		/// <summary>
        /// emailsender
        /// </summary>
		[DisplayName("Sender")]
		[AttributeLogicalName("emailsender")]
		public EntityReference Sender
		{	
			get { return GetAttributeValue<EntityReference>("emailsender"); }
			set
			{ 
				if(Attributes.ContainsKey("emailsender") && value == Sender) return;
				SetAttributeValue("emailsender", value);
			}
		}	
			
		/// <summary>
        /// emailsendername
        /// </summary>
		[DisplayName("Email Sender Name")]
		[AttributeLogicalName("emailsendername")]
		public string EmailSenderName
		{	
			get { return GetAttributeValue<string>("emailsendername"); }
			set
			{ 
				if(Attributes.ContainsKey("emailsendername") && value == EmailSenderName) return;
				SetAttributeValue("emailsendername", value);
			}
		}	
			
		/// <summary>
        /// emailsenderobjecttypecode
        /// </summary>
		[DisplayName("Email Sender Type")]
		[AttributeLogicalName("emailsenderobjecttypecode")]
		public string EmailSenderType
		{	
			get { return GetAttributeValue<string>("emailsenderobjecttypecode"); }
			set
			{ 
				if(Attributes.ContainsKey("emailsenderobjecttypecode") && value == EmailSenderType) return;
				SetAttributeValue("emailsenderobjecttypecode", value);
			}
		}	
			
		/// <summary>
        /// emailsenderyominame
        /// </summary>
		[DisplayName("Email Sender yomi Name")]
		[AttributeLogicalName("emailsenderyominame")]
		public string EmailSenderYomiName
		{	
			get { return GetAttributeValue<string>("emailsenderyominame"); }
			set
			{ 
				if(Attributes.ContainsKey("emailsenderyominame") && value == EmailSenderYomiName) return;
				SetAttributeValue("emailsenderyominame", value);
			}
		}	
			
		/// <summary>
        /// emailtrackingid
        /// </summary>
		[DisplayName("Email Tracking Id")]
		[AttributeLogicalName("emailtrackingid")]
		public Guid EmailTrackingId
		{	
			get { return GetAttributeValue<Guid>("emailtrackingid"); }
			set
			{ 
				if(Attributes.ContainsKey("emailtrackingid") && value == EmailTrackingId) return;
				SetAttributeValue("emailtrackingid", value);
			}
		}	
			
		/// <summary>
        /// exchangerate
		///
		/// Precision: 12
		/// MaxValue: 100000000000
		/// MinValue: 0.000000000001
        /// </summary>
		[DisplayName("Exchange Rate")]
		[AttributeLogicalName("exchangerate")]
		public decimal? ExchangeRate
		{	
			get { return GetAttributeValue<decimal?>("exchangerate"); }
			set 
			{
				decimal? decimalValue = null;
				if(value != null) decimalValue = Decimal.Round(value.Value, 12);
				if(Attributes.ContainsKey("exchangerate") && decimalValue == ExchangeRate) return;
				SetAttributeValue("exchangerate", decimalValue);  
			}
		}

		/// <summary>
        /// followemailuserpreference
        /// </summary>
		[DisplayName("Following")]
		[AttributeLogicalName("followemailuserpreference")]
		public bool? Following
		{	
			get { return GetAttributeValue<bool?>("followemailuserpreference"); }
			set
			{ 
				if(Attributes.ContainsKey("followemailuserpreference") && value == Following) return;
				SetAttributeValue("followemailuserpreference", value);
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
				if(Attributes.ContainsKey("from") && value == From) return;
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
				if(Attributes.ContainsKey("importsequencenumber") && value == ImportSequenceNumber) return;
				SetAttributeValue("importsequencenumber", value);
			}
		}	
			
		/// <summary>
        /// inreplyto
        /// </summary>
		[DisplayName("In Reply To Message")]
		[AttributeLogicalName("inreplyto")]
		public string InReplyToMessage
		{	
			get { return GetAttributeValue<string>("inreplyto"); }
			set
			{ 
				if(Attributes.ContainsKey("inreplyto") && value == InReplyToMessage) return;
				SetAttributeValue("inreplyto", value);
			}
		}	
			
		/// <summary>
        /// internetmessageheaders
        /// </summary>
		[DisplayName("Internet message headers")]
		[AttributeLogicalName("internetmessageheaders")]
		public string InternetMessageHeaders
		{	
			get { return GetAttributeValue<string>("internetmessageheaders"); }
			set
			{ 
				if(Attributes.ContainsKey("internetmessageheaders") && value == InternetMessageHeaders) return;
				SetAttributeValue("internetmessageheaders", value);
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
				if(Attributes.ContainsKey("isbilled") && value == IsBilled) return;
				SetAttributeValue("isbilled", value);
			}
		}	
			
		/// <summary>
        /// isduplicatesenderunresolved
        /// </summary>
		[DisplayName("Is Duplicate Sender Unresolved")]
		[AttributeLogicalName("isduplicatesenderunresolved")]
		public bool? IsDuplicateSenderUnresolved
		{	
			get { return GetAttributeValue<bool?>("isduplicatesenderunresolved"); }
			set
			{ 
				if(Attributes.ContainsKey("isduplicatesenderunresolved") && value == IsDuplicateSenderUnresolved) return;
				SetAttributeValue("isduplicatesenderunresolved", value);
			}
		}	
			
		/// <summary>
        /// isemailfollowed
        /// </summary>
		[DisplayName("Followed")]
		[AttributeLogicalName("isemailfollowed")]
		public bool? Followed
		{	
			get { return GetAttributeValue<bool?>("isemailfollowed"); }
			set
			{ 
				if(Attributes.ContainsKey("isemailfollowed") && value == Followed) return;
				SetAttributeValue("isemailfollowed", value);
			}
		}	
			
		/// <summary>
        /// isemailreminderset
        /// </summary>
		[DisplayName("Reminder Set")]
		[AttributeLogicalName("isemailreminderset")]
		public bool? ReminderSet
		{	
			get { return GetAttributeValue<bool?>("isemailreminderset"); }
			set
			{ 
				if(Attributes.ContainsKey("isemailreminderset") && value == ReminderSet) return;
				SetAttributeValue("isemailreminderset", value);
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
				if(Attributes.ContainsKey("isregularactivity") && value == IsRegularActivity) return;
				SetAttributeValue("isregularactivity", value);
			}
		}	
			
		/// <summary>
        /// issafedescriptiontruncated
        /// </summary>
		[DisplayName("IsSafeDescriptionTruncated")]
		[AttributeLogicalName("issafedescriptiontruncated")]
		public int? IsSafeDescriptionTruncated
		{	
			get { return GetAttributeValue<int?>("issafedescriptiontruncated"); }
			set
			{ 
				if(Attributes.ContainsKey("issafedescriptiontruncated") && value == IsSafeDescriptionTruncated) return;
				SetAttributeValue("issafedescriptiontruncated", value);
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
				if(Attributes.ContainsKey("isunsafe") && value == IsUnsafe) return;
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
				if(Attributes.ContainsKey("isworkflowcreated") && value == IsWorkflowCreated) return;
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
				if(Attributes.ContainsKey("lastonholdtime") && value == LastOnHoldTime) return;
				SetAttributeValue("lastonholdtime", value);
			}
		}	
			
		/// <summary>
        /// lastopenedtime
        /// </summary>
		[DisplayName("Last Opened Time")]
		[AttributeLogicalName("lastopenedtime")]
		public DateTime? LastOpenedTime
		{	
			get { return GetAttributeValue<DateTime?>("lastopenedtime"); }
			set
			{ 
				if(Attributes.ContainsKey("lastopenedtime") && value == LastOpenedTime) return;
				SetAttributeValue("lastopenedtime", value);
			}
		}	
			
		/// <summary>
        /// linksclickedcount
        /// </summary>
		[DisplayName("Links Clicked Count")]
		[AttributeLogicalName("linksclickedcount")]
		public int? LinksClickedCount
		{	
			get { return GetAttributeValue<int?>("linksclickedcount"); }
			set
			{ 
				if(Attributes.ContainsKey("linksclickedcount") && value == LinksClickedCount) return;
				SetAttributeValue("linksclickedcount", value);
			}
		}	
			
		/// <summary>
        /// messageid
        /// </summary>
		[DisplayName("Message ID")]
		[AttributeLogicalName("messageid")]
		public string MessageID
		{	
			get { return GetAttributeValue<string>("messageid"); }
			set
			{ 
				if(Attributes.ContainsKey("messageid") && value == MessageID) return;
				SetAttributeValue("messageid", value);
			}
		}	
			
		/// <summary>
        /// messageiddupcheck
        /// </summary>
		[DisplayName("Message ID Dup Check")]
		[AttributeLogicalName("messageiddupcheck")]
		public Guid MessageIDDupCheckId
		{	
			get { return GetAttributeValue<Guid>("messageiddupcheck"); }
			set
			{ 
				if(Attributes.ContainsKey("messageiddupcheck") && value == MessageIDDupCheckId) return;
				SetAttributeValue("messageiddupcheck", value);
			}
		}	
			
		/// <summary>
        /// mimetype
        /// </summary>
		[DisplayName("Mime Type")]
		[AttributeLogicalName("mimetype")]
		public string MimeType
		{	
			get { return GetAttributeValue<string>("mimetype"); }
			set
			{ 
				if(Attributes.ContainsKey("mimetype") && value == MimeType) return;
				SetAttributeValue("mimetype", value);
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
				if(Attributes.ContainsKey("modifiedby") && value == ModifiedBy) return;
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
				if(Attributes.ContainsKey("modifiedbyname") && value == Modifiedbyname) return;
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
				if(Attributes.ContainsKey("modifiedbyyominame") && value == Modifiedbyyominame) return;
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
				if(Attributes.ContainsKey("modifiedon") && value == ModifiedOn) return;
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
				if(Attributes.ContainsKey("modifiedonbehalfby") && value == ModifiedByDelegate) return;
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
				if(Attributes.ContainsKey("modifiedonbehalfbyname") && value == Modifiedonbehalfbyname) return;
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
				if(Attributes.ContainsKey("modifiedonbehalfbyyominame") && value == Modifiedonbehalfbyyominame) return;
				SetAttributeValue("modifiedonbehalfbyyominame", value);
			}
		}	
			
		/// <summary>
        /// notifications
        /// </summary>
		[DisplayName("Notifications")]
		[AttributeLogicalName("notifications")]
		public eNotifications? Notifications
		{	
			get 
			{ 
				var optionSetValue = GetAttributeValue<OptionSetValue>("notifications");
				if (optionSetValue != null) return (eNotifications)optionSetValue.Value;
				else return null;
			}
			set 
			{ 
				if(Attributes.ContainsKey("notifications") && value == Notifications) return;

				OptionSetValue optionSetValue = null;
				if(value != null) optionSetValue = new OptionSetValue((int)value);
				SetAttributeValue("notifications", optionSetValue); 
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
				if(Attributes.ContainsKey("onholdtime") && value == OnHoldTimeMinutes) return;
				SetAttributeValue("onholdtime", value);
			}
		}	
			
		/// <summary>
        /// opencount
        /// </summary>
		[DisplayName("Open Count")]
		[AttributeLogicalName("opencount")]
		public int? OpenCount
		{	
			get { return GetAttributeValue<int?>("opencount"); }
			set
			{ 
				if(Attributes.ContainsKey("opencount") && value == OpenCount) return;
				SetAttributeValue("opencount", value);
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
				if(Attributes.ContainsKey("overriddencreatedon") && value == RecordCreatedOn) return;
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
				if(Attributes.ContainsKey("ownerid") && value == Owner) return;
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
				if(Attributes.ContainsKey("owneridname") && value == Owneridname) return;
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
				if(Attributes.ContainsKey("owneridtype") && value == Owneridtype) return;
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
				if(Attributes.ContainsKey("owneridyominame") && value == Owneridyominame) return;
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
				if(Attributes.ContainsKey("owningbusinessunit") && value == OwningBusinessUnit) return;
				SetAttributeValue("owningbusinessunit", value);
			}
		}	
			
		/// <summary>
        /// owningbusinessunitname
        /// </summary>
		[DisplayName("owningbusinessunitname")]
		[AttributeLogicalName("owningbusinessunitname")]
		public string Owningbusinessunitname
		{	
			get { return GetAttributeValue<string>("owningbusinessunitname"); }
			set
			{ 
				if(Attributes.ContainsKey("owningbusinessunitname") && value == Owningbusinessunitname) return;
				SetAttributeValue("owningbusinessunitname", value);
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
				if(Attributes.ContainsKey("owningteam") && value == OwningTeam) return;
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
				if(Attributes.ContainsKey("owninguser") && value == OwningUser) return;
				SetAttributeValue("owninguser", value);
			}
		}	
			
		/// <summary>
        /// parentactivityid
        /// </summary>
		[DisplayName("Parent Activity Id")]
		[AttributeLogicalName("parentactivityid")]
		public EntityReference ParentActivityId
		{	
			get { return GetAttributeValue<EntityReference>("parentactivityid"); }
			set
			{ 
				if(Attributes.ContainsKey("parentactivityid") && value == ParentActivityId) return;
				SetAttributeValue("parentactivityid", value);
			}
		}	
			
		/// <summary>
        /// parentactivityidname
        /// </summary>
		[DisplayName("Parent Activity Name")]
		[AttributeLogicalName("parentactivityidname")]
		public string ParentActivityName
		{	
			get { return GetAttributeValue<string>("parentactivityidname"); }
			set
			{ 
				if(Attributes.ContainsKey("parentactivityidname") && value == ParentActivityName) return;
				SetAttributeValue("parentactivityidname", value);
			}
		}	
			
		/// <summary>
        /// postponeemailprocessinguntil
        /// </summary>
		[DisplayName("Delay email processing until")]
		[AttributeLogicalName("postponeemailprocessinguntil")]
		public DateTime? DelayEmailProcessingUntil
		{	
			get { return GetAttributeValue<DateTime?>("postponeemailprocessinguntil"); }
			set
			{ 
				if(Attributes.ContainsKey("postponeemailprocessinguntil") && value == DelayEmailProcessingUntil) return;
				SetAttributeValue("postponeemailprocessinguntil", value);
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
				if(Attributes.ContainsKey("prioritycode") && value == Priority) return;

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
				if(Attributes.ContainsKey("processid") && value == ProcessId) return;
				SetAttributeValue("processid", value);
			}
		}	
			
		/// <summary>
        /// readreceiptrequested
        /// </summary>
		[DisplayName("Read Receipt Requested")]
		[AttributeLogicalName("readreceiptrequested")]
		public bool? ReadReceiptRequested
		{	
			get { return GetAttributeValue<bool?>("readreceiptrequested"); }
			set
			{ 
				if(Attributes.ContainsKey("readreceiptrequested") && value == ReadReceiptRequested) return;
				SetAttributeValue("readreceiptrequested", value);
			}
		}	
			
		/// <summary>
        /// receivingmailboxid
        /// </summary>
		[DisplayName("Receiving Mailbox")]
		[AttributeLogicalName("receivingmailboxid")]
		public EntityReference ReceivingMailbox
		{	
			get { return GetAttributeValue<EntityReference>("receivingmailboxid"); }
			set
			{ 
				if(Attributes.ContainsKey("receivingmailboxid") && value == ReceivingMailbox) return;
				SetAttributeValue("receivingmailboxid", value);
			}
		}	
			
		/// <summary>
        /// receivingmailboxidname
        /// </summary>
		[DisplayName("receivingmailboxidname")]
		[AttributeLogicalName("receivingmailboxidname")]
		public string Receivingmailboxidname
		{	
			get { return GetAttributeValue<string>("receivingmailboxidname"); }
			set
			{ 
				if(Attributes.ContainsKey("receivingmailboxidname") && value == Receivingmailboxidname) return;
				SetAttributeValue("receivingmailboxidname", value);
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
				if(Attributes.ContainsKey("regardingobjectid") && value == Regarding) return;
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
				if(Attributes.ContainsKey("regardingobjectidname") && value == Regardingobjectidname) return;
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
				if(Attributes.ContainsKey("regardingobjectidyominame") && value == Regardingobjectidyominame) return;
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
				if(Attributes.ContainsKey("regardingobjecttypecode") && value == Regardingobjecttypecode) return;
				SetAttributeValue("regardingobjecttypecode", value);
			}
		}	
			
		/// <summary>
        /// related
        /// </summary>
		[DisplayName("Related")]
		[AttributeLogicalName("related")]
		public EntityCollection Related
		{	
			get { return GetAttributeValue<EntityCollection>("related"); }
			set
			{ 
				if(Attributes.ContainsKey("related") && value == Related) return;
				SetAttributeValue("related", value);
			}
		}	
			
		/// <summary>
        /// reminderactioncardid
        /// </summary>
		[DisplayName("Reminder Action Card Id.")]
		[AttributeLogicalName("reminderactioncardid")]
		public Guid ReminderActionCardId
		{	
			get { return GetAttributeValue<Guid>("reminderactioncardid"); }
			set
			{ 
				if(Attributes.ContainsKey("reminderactioncardid") && value == ReminderActionCardId) return;
				SetAttributeValue("reminderactioncardid", value);
			}
		}	
			
		/// <summary>
        /// replycount
        /// </summary>
		[DisplayName("Reply Count")]
		[AttributeLogicalName("replycount")]
		public int? ReplyCount
		{	
			get { return GetAttributeValue<int?>("replycount"); }
			set
			{ 
				if(Attributes.ContainsKey("replycount") && value == ReplyCount) return;
				SetAttributeValue("replycount", value);
			}
		}	
			
		/// <summary>
        /// reservedforinternaluse
        /// </summary>
		[DisplayName("Reserved for internal use")]
		[AttributeLogicalName("reservedforinternaluse")]
		public string ReservedForInternalUse
		{	
			get { return GetAttributeValue<string>("reservedforinternaluse"); }
			set
			{ 
				if(Attributes.ContainsKey("reservedforinternaluse") && value == ReservedForInternalUse) return;
				SetAttributeValue("reservedforinternaluse", value);
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
				if(Attributes.ContainsKey("safedescription") && value == SafeDescription) return;
				SetAttributeValue("safedescription", value);
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
				if(Attributes.ContainsKey("scheduleddurationminutes") && value == ScheduledDuration) return;
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
				if(Attributes.ContainsKey("scheduledend") && value == DueDate) return;
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
				if(Attributes.ContainsKey("scheduledstart") && value == StartDate) return;
				SetAttributeValue("scheduledstart", value);
			}
		}	
			
		/// <summary>
        /// sender
        /// </summary>
		[DisplayName("From")]
		[AttributeLogicalName("sender")]
		public string From2
		{	
			get { return GetAttributeValue<string>("sender"); }
			set
			{ 
				if(Attributes.ContainsKey("sender") && value == From2) return;
				SetAttributeValue("sender", value);
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
				if(Attributes.ContainsKey("sendermailboxid") && value == SendersMailbox) return;
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
				if(Attributes.ContainsKey("sendermailboxidname") && value == Sendermailboxidname) return;
				SetAttributeValue("sendermailboxidname", value);
			}
		}	
			
		/// <summary>
        /// sendersaccount
        /// </summary>
		[DisplayName("Senders Account")]
		[AttributeLogicalName("sendersaccount")]
		public EntityReference SendersAccount
		{	
			get { return GetAttributeValue<EntityReference>("sendersaccount"); }
			set
			{ 
				if(Attributes.ContainsKey("sendersaccount") && value == SendersAccount) return;
				SetAttributeValue("sendersaccount", value);
			}
		}	
			
		/// <summary>
        /// sendersaccountname
        /// </summary>
		[DisplayName("Email Sender Account Name")]
		[AttributeLogicalName("sendersaccountname")]
		public string EmailSenderAccountName
		{	
			get { return GetAttributeValue<string>("sendersaccountname"); }
			set
			{ 
				if(Attributes.ContainsKey("sendersaccountname") && value == EmailSenderAccountName) return;
				SetAttributeValue("sendersaccountname", value);
			}
		}	
			
		/// <summary>
        /// sendersaccountobjecttypecode
        /// </summary>
		[DisplayName("SendersAccount Type")]
		[AttributeLogicalName("sendersaccountobjecttypecode")]
		public string SendersAccountType
		{	
			get { return GetAttributeValue<string>("sendersaccountobjecttypecode"); }
			set
			{ 
				if(Attributes.ContainsKey("sendersaccountobjecttypecode") && value == SendersAccountType) return;
				SetAttributeValue("sendersaccountobjecttypecode", value);
			}
		}	
			
		/// <summary>
        /// sendersaccountyominame
        /// </summary>
		[DisplayName("Email Sender Account yomi Name")]
		[AttributeLogicalName("sendersaccountyominame")]
		public string EmailSenderAccountYomiName
		{	
			get { return GetAttributeValue<string>("sendersaccountyominame"); }
			set
			{ 
				if(Attributes.ContainsKey("sendersaccountyominame") && value == EmailSenderAccountYomiName) return;
				SetAttributeValue("sendersaccountyominame", value);
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
				if(Attributes.ContainsKey("senton") && value == DateSent) return;
				SetAttributeValue("senton", value);
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
				if(Attributes.ContainsKey("slaid") && value == SLA) return;
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
				if(Attributes.ContainsKey("slainvokedid") && value == LastSLAApplied) return;
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
				if(Attributes.ContainsKey("slainvokedidname") && value == Slainvokedidname) return;
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
				if(Attributes.ContainsKey("slaname") && value == Slaname) return;
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
				if(Attributes.ContainsKey("sortdate") && value == SortDate) return;
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
				if(Attributes.ContainsKey("stageid") && value == DeprecatedProcessStageId) return;
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
				if(Attributes.ContainsKey("statecode") && value == ActivityStatus) return;

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
				if(Attributes.ContainsKey("statuscode") && value == StatusReason) return;

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
				if(Attributes.ContainsKey("subcategory") && value == SubCategory) return;
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
				if(Attributes.ContainsKey("subject") && value == Subject) return;
				SetAttributeValue("subject", value);
			}
		}	
			
		/// <summary>
        /// submittedby
        /// </summary>
		[DisplayName("Submitted By")]
		[AttributeLogicalName("submittedby")]
		public string SubmittedBy
		{	
			get { return GetAttributeValue<string>("submittedby"); }
			set
			{ 
				if(Attributes.ContainsKey("submittedby") && value == SubmittedBy) return;
				SetAttributeValue("submittedby", value);
			}
		}	
			
		/// <summary>
        /// templateid
        /// </summary>
		[DisplayName("ID for template used.")]
		[AttributeLogicalName("templateid")]
		public EntityReference IDForTemplateUsed
		{	
			get { return GetAttributeValue<EntityReference>("templateid"); }
			set
			{ 
				if(Attributes.ContainsKey("templateid") && value == IDForTemplateUsed) return;
				SetAttributeValue("templateid", value);
			}
		}	
			
		/// <summary>
        /// templateidname
        /// </summary>
		[DisplayName("templateidname")]
		[AttributeLogicalName("templateidname")]
		public string Templateidname
		{	
			get { return GetAttributeValue<string>("templateidname"); }
			set
			{ 
				if(Attributes.ContainsKey("templateidname") && value == Templateidname) return;
				SetAttributeValue("templateidname", value);
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
				if(Attributes.ContainsKey("timezoneruleversionnumber") && value == TimeZoneRuleVersionNumber) return;
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
				if(Attributes.ContainsKey("to") && value == To) return;
				SetAttributeValue("to", value);
			}
		}	
			
		/// <summary>
        /// torecipients
        /// </summary>
		[DisplayName("To Recipients")]
		[AttributeLogicalName("torecipients")]
		public string ToRecipients
		{	
			get { return GetAttributeValue<string>("torecipients"); }
			set
			{ 
				if(Attributes.ContainsKey("torecipients") && value == ToRecipients) return;
				SetAttributeValue("torecipients", value);
			}
		}	
			
		/// <summary>
        /// trackingtoken
        /// </summary>
		[DisplayName("Tracking Token")]
		[AttributeLogicalName("trackingtoken")]
		public string TrackingToken
		{	
			get { return GetAttributeValue<string>("trackingtoken"); }
			set
			{ 
				if(Attributes.ContainsKey("trackingtoken") && value == TrackingToken) return;
				SetAttributeValue("trackingtoken", value);
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
				if(Attributes.ContainsKey("transactioncurrencyid") && value == Currency) return;
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
				if(Attributes.ContainsKey("transactioncurrencyidname") && value == Transactioncurrencyidname) return;
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
				if(Attributes.ContainsKey("traversedpath") && value == DeprecatedTraversedPath) return;
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
				if(Attributes.ContainsKey("utcconversiontimezonecode") && value == UTCConversionTimeZoneCode) return;
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
				if(Attributes.ContainsKey("versionnumber") && value == VersionNumber) return;
				SetAttributeValue("versionnumber", value);
			}
		}	
			
		#endregion	

		#region Relations
			/// <summary>
        /// 1:N Get entities for 'email_activity_parties'
        /// </summary>
		[RelationshipSchemaName("email_activity_parties")]
		public IEnumerable<ActivityParty> EmailActivityParties
		{
			get { return GetRelatedEntities<ActivityParty>("email_activity_parties", null); }
			set { SetRelatedEntities("email_activity_parties", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'Email_AsyncOperations'
        /// </summary>
		[RelationshipSchemaName("Email_AsyncOperations")]
		public IEnumerable<SystemJob> EmailAsyncOperations
		{
			get { return GetRelatedEntities<SystemJob>("Email_AsyncOperations", null); }
			set { SetRelatedEntities("Email_AsyncOperations", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'email_email_CorrelatedActivityId'
        /// </summary>
		[RelationshipSchemaName("email_email_CorrelatedActivityId")]
		public IEnumerable<Email> EmailEmailCorrelatedActivityId
		{
			get { return GetRelatedEntities<Email>("email_email_CorrelatedActivityId", null); }
			set { SetRelatedEntities("email_email_CorrelatedActivityId", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'email_email_parentactivityid'
        /// </summary>
		[RelationshipSchemaName("email_email_parentactivityid")]
		public IEnumerable<Email> EmailEmailParentactivityid
		{
			get { return GetRelatedEntities<Email>("email_email_parentactivityid", null); }
			set { SetRelatedEntities("email_email_parentactivityid", null, value); }
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
		
		public enum eCorrelationMethod
		{	
		
			[Label("None")]
			[Description(@"")]
			None = 0, 
		
			[Label("Skipped")]
			[Description(@"")]
			Skipped = 1, 
		
			[Label("XHeader")]
			[Description(@"")]
			XHeader = 2, 
		
			[Label("InReplyTo")]
			[Description(@"")]
			InReplyTo = 3, 
		
			[Label("TrackingToken")]
			[Description(@"")]
			TrackingToken = 4, 
		
			[Label("ConversationIndex")]
			[Description(@"")]
			ConversationIndex = 5, 
		
			[Label("SmartMatching")]
			[Description(@"")]
			SmartMatching = 6, 
		
			[Label("CustomCorrelation")]
			[Description(@"")]
			CustomCorrelation = 7, 
		}
		
		public enum eNotifications
		{	
		
			[Label("None")]
			[Description(@"")]
			None = 0, 
		
			[Label("The message was saved as a Microsoft Dynamics 365 email record, but not all the attachments could be saved with it. An attachment cannot be saved if it is blocked or if its file type is invalid.")]
			[Description(@"")]
			TheMessageWasSavedAsAMicrosoftDynamics365EmailRecordButNotAllTheAttachmentsCouldBeSavedWithItAnAttachmentCannotBeSavedIfItIsBlockedOrIfItsFileTypeIsInvalid = 1, 
		
			[Label("Truncated body.")]
			[Description(@"")]
			TruncatedBody = 2, 
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
		
		public enum eEmailReminderStatus
		{	
		
			[Label("NotSet")]
			[Description(@"")]
			NotSet = 0, 
		
			[Label("ReminderSet")]
			[Description(@"")]
			ReminderSet = 1, 
		
			[Label("ReminderExpired")]
			[Description(@"")]
			ReminderExpired = 2, 
		
			[Label("ReminderInvalid")]
			[Description(@"")]
			ReminderInvalid = 3, 
		}
		
		public enum eEmailReminderType
		{	
		
			[Label("If I do not receive a reply by")]
			[Description(@"")]
			IfIDoNotReceiveAReplyBy = 0, 
		
			[Label("If the email is not opened by")]
			[Description(@"")]
			IfTheEmailIsNotOpenedBy = 1, 
		
			[Label("Remind me anyways at")]
			[Description(@"")]
			RemindMeAnywaysAt = 2, 
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
		
			[Label("Draft")]
			[Description(@"")]
			Draft_Active = 1, 
		
			[Label("Completed")]
			[Description(@"")]
			Completed_Inactive = 2, 
		
			[Label("Sent")]
			[Description(@"")]
			Sent_Inactive = 3, 
		
			[Label("Received")]
			[Description(@"")]
			Received_Inactive = 4, 
		
			[Label("Canceled")]
			[Description(@"")]
			Canceled = 5, 
		
			[Label("Pending Send")]
			[Description(@"")]
			PendingSend_Inactive = 6, 
		
			[Label("Sending")]
			[Description(@"")]
			Sending_Inactive = 7, 
		
			[Label("Failed")]
			[Description(@"")]
			Failed_Active = 8, 
		}
		
		#endregion	

		#region Properties
		public static class Properties 
		{
			/// <summary>acceptingentityid</summary>
			public const string AcceptingEntity = "acceptingentityid";

			/// <summary>acceptingentityidname</summary>
			public const string AcceptingEntityName = "acceptingentityidname";

			/// <summary>acceptingentitytypecode</summary>
			public const string AcceptingUserOrQueueObjectType = "acceptingentitytypecode";

			/// <summary>activityadditionalparams</summary>
			public const string AdditionalParameters = "activityadditionalparams";

			/// <summary>activityid</summary>
			public const string EmailMessageId = "activityid";

			/// <summary>activitytypecode</summary>
			public const string ActivityType = "activitytypecode";

			/// <summary>actualdurationminutes</summary>
			public const string Duration = "actualdurationminutes";

			/// <summary>actualend</summary>
			public const string ActualEnd = "actualend";

			/// <summary>actualstart</summary>
			public const string ActualStart = "actualstart";

			/// <summary>attachmentcount</summary>
			public const string AttachmentCount = "attachmentcount";

			/// <summary>attachmentopencount</summary>
			public const string AttachmentOpenCount = "attachmentopencount";

			/// <summary>baseconversationindexhash</summary>
			public const string ConversationIndexHash = "baseconversationindexhash";

			/// <summary>bcc</summary>
			public const string Bcc = "bcc";

			/// <summary>category</summary>
			public const string Category = "category";

			/// <summary>cc</summary>
			public const string Cc = "cc";

			/// <summary>compressed</summary>
			public const string Compression = "compressed";

			/// <summary>conversationindex</summary>
			public const string ConversationIndex = "conversationindex";

			/// <summary>conversationtrackingid</summary>
			public const string ConversationTrackingId = "conversationtrackingid";

			/// <summary>correlatedactivityid</summary>
			public const string CorrelatedActivityId = "correlatedactivityid";

			/// <summary>correlatedactivityidname</summary>
			public const string Correlatedactivityidname = "correlatedactivityidname";

			/// <summary>correlatedsubjectchanged</summary>
			public const string CorrelatedSubjectChanged = "correlatedsubjectchanged";

			/// <summary>correlationmethod</summary>
			public const string CorrelationMethod = "correlationmethod";

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

			/// <summary>delayedemailsendtime</summary>
			public const string SendLater = "delayedemailsendtime";

			/// <summary>deliveryattempts</summary>
			public const string NoOfDeliveryAttempts = "deliveryattempts";

			/// <summary>deliveryprioritycode</summary>
			public const string DeliveryPriority = "deliveryprioritycode";

			/// <summary>deliveryreceiptrequested</summary>
			public const string DeliveryReceiptRequested = "deliveryreceiptrequested";

			/// <summary>description</summary>
			public const string Description = "description";

			/// <summary>descriptionblobid_name</summary>
			public const string DescriptionblobidName = "descriptionblobid_name";

			/// <summary>directioncode</summary>
			public const string Direction = "directioncode";

			/// <summary>emailreminderexpirytime</summary>
			public const string EmailReminderExpiryTime = "emailreminderexpirytime";

			/// <summary>emailreminderstatus</summary>
			public const string EmailReminderStatus = "emailreminderstatus";

			/// <summary>emailremindertext</summary>
			public const string EmailReminderText = "emailremindertext";

			/// <summary>emailremindertype</summary>
			public const string EmailReminderType = "emailremindertype";

			/// <summary>emailsender</summary>
			public const string Sender = "emailsender";

			/// <summary>emailsendername</summary>
			public const string EmailSenderName = "emailsendername";

			/// <summary>emailsenderobjecttypecode</summary>
			public const string EmailSenderType = "emailsenderobjecttypecode";

			/// <summary>emailsenderyominame</summary>
			public const string EmailSenderYomiName = "emailsenderyominame";

			/// <summary>emailtrackingid</summary>
			public const string EmailTrackingId = "emailtrackingid";

			/// <summary>exchangerate</summary>
			public const string ExchangeRate = "exchangerate";

			/// <summary>followemailuserpreference</summary>
			public const string Following = "followemailuserpreference";

			/// <summary>from</summary>
			public const string From = "from";

			/// <summary>importsequencenumber</summary>
			public const string ImportSequenceNumber = "importsequencenumber";

			/// <summary>inreplyto</summary>
			public const string InReplyToMessage = "inreplyto";

			/// <summary>internetmessageheaders</summary>
			public const string InternetMessageHeaders = "internetmessageheaders";

			/// <summary>isbilled</summary>
			public const string IsBilled = "isbilled";

			/// <summary>isduplicatesenderunresolved</summary>
			public const string IsDuplicateSenderUnresolved = "isduplicatesenderunresolved";

			/// <summary>isemailfollowed</summary>
			public const string Followed = "isemailfollowed";

			/// <summary>isemailreminderset</summary>
			public const string ReminderSet = "isemailreminderset";

			/// <summary>isregularactivity</summary>
			public const string IsRegularActivity = "isregularactivity";

			/// <summary>issafedescriptiontruncated</summary>
			public const string IsSafeDescriptionTruncated = "issafedescriptiontruncated";

			/// <summary>isunsafe</summary>
			public const string IsUnsafe = "isunsafe";

			/// <summary>isworkflowcreated</summary>
			public const string IsWorkflowCreated = "isworkflowcreated";

			/// <summary>lastonholdtime</summary>
			public const string LastOnHoldTime = "lastonholdtime";

			/// <summary>lastopenedtime</summary>
			public const string LastOpenedTime = "lastopenedtime";

			/// <summary>linksclickedcount</summary>
			public const string LinksClickedCount = "linksclickedcount";

			/// <summary>messageid</summary>
			public const string MessageID = "messageid";

			/// <summary>messageiddupcheck</summary>
			public const string MessageIDDupCheckId = "messageiddupcheck";

			/// <summary>mimetype</summary>
			public const string MimeType = "mimetype";

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

			/// <summary>notifications</summary>
			public const string Notifications = "notifications";

			/// <summary>onholdtime</summary>
			public const string OnHoldTimeMinutes = "onholdtime";

			/// <summary>opencount</summary>
			public const string OpenCount = "opencount";

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

			/// <summary>owningbusinessunitname</summary>
			public const string Owningbusinessunitname = "owningbusinessunitname";

			/// <summary>owningteam</summary>
			public const string OwningTeam = "owningteam";

			/// <summary>owninguser</summary>
			public const string OwningUser = "owninguser";

			/// <summary>parentactivityid</summary>
			public const string ParentActivityId = "parentactivityid";

			/// <summary>parentactivityidname</summary>
			public const string ParentActivityName = "parentactivityidname";

			/// <summary>postponeemailprocessinguntil</summary>
			public const string DelayEmailProcessingUntil = "postponeemailprocessinguntil";

			/// <summary>prioritycode</summary>
			public const string Priority = "prioritycode";

			/// <summary>processid</summary>
			public const string ProcessId = "processid";

			/// <summary>readreceiptrequested</summary>
			public const string ReadReceiptRequested = "readreceiptrequested";

			/// <summary>receivingmailboxid</summary>
			public const string ReceivingMailbox = "receivingmailboxid";

			/// <summary>receivingmailboxidname</summary>
			public const string Receivingmailboxidname = "receivingmailboxidname";

			/// <summary>regardingobjectid</summary>
			public const string Regarding = "regardingobjectid";

			/// <summary>regardingobjectidname</summary>
			public const string Regardingobjectidname = "regardingobjectidname";

			/// <summary>regardingobjectidyominame</summary>
			public const string Regardingobjectidyominame = "regardingobjectidyominame";

			/// <summary>regardingobjecttypecode</summary>
			public const string Regardingobjecttypecode = "regardingobjecttypecode";

			/// <summary>related</summary>
			public const string Related = "related";

			/// <summary>reminderactioncardid</summary>
			public const string ReminderActionCardId = "reminderactioncardid";

			/// <summary>replycount</summary>
			public const string ReplyCount = "replycount";

			/// <summary>reservedforinternaluse</summary>
			public const string ReservedForInternalUse = "reservedforinternaluse";

			/// <summary>safedescription</summary>
			public const string SafeDescription = "safedescription";

			/// <summary>scheduleddurationminutes</summary>
			public const string ScheduledDuration = "scheduleddurationminutes";

			/// <summary>scheduledend</summary>
			public const string DueDate = "scheduledend";

			/// <summary>scheduledstart</summary>
			public const string StartDate = "scheduledstart";

			/// <summary>sender</summary>
			public const string From2 = "sender";

			/// <summary>sendermailboxid</summary>
			public const string SendersMailbox = "sendermailboxid";

			/// <summary>sendermailboxidname</summary>
			public const string Sendermailboxidname = "sendermailboxidname";

			/// <summary>sendersaccount</summary>
			public const string SendersAccount = "sendersaccount";

			/// <summary>sendersaccountname</summary>
			public const string EmailSenderAccountName = "sendersaccountname";

			/// <summary>sendersaccountobjecttypecode</summary>
			public const string SendersAccountType = "sendersaccountobjecttypecode";

			/// <summary>sendersaccountyominame</summary>
			public const string EmailSenderAccountYomiName = "sendersaccountyominame";

			/// <summary>senton</summary>
			public const string DateSent = "senton";

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

			/// <summary>subcategory</summary>
			public const string SubCategory = "subcategory";

			/// <summary>subject</summary>
			public const string Subject = "subject";

			/// <summary>submittedby</summary>
			public const string SubmittedBy = "submittedby";

			/// <summary>templateid</summary>
			public const string IDForTemplateUsed = "templateid";

			/// <summary>templateidname</summary>
			public const string Templateidname = "templateidname";

			/// <summary>timezoneruleversionnumber</summary>
			public const string TimeZoneRuleVersionNumber = "timezoneruleversionnumber";

			/// <summary>to</summary>
			public const string To = "to";

			/// <summary>torecipients</summary>
			public const string ToRecipients = "torecipients";

			/// <summary>trackingtoken</summary>
			public const string TrackingToken = "trackingtoken";

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
			/// <summary>1:N email_activity_parties</summary>
			public const string EmailActivityParties = "email_activity_parties";

			/// <summary>1:N Email_AsyncOperations</summary>
			public const string EmailAsyncOperations = "Email_AsyncOperations";

			/// <summary>1:N email_email_CorrelatedActivityId</summary>
			public const string EmailEmailCorrelatedActivityId = "email_email_CorrelatedActivityId";

			/// <summary>1:N email_email_parentactivityid</summary>
			public const string EmailEmailParentactivityid = "email_email_parentactivityid";

		}
		#endregion
	}
}

