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
				if(value == ActivityType) return;
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
				if(value == Duration) return;
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
        /// attachmentopencount
        /// </summary>
		[DisplayName("Attachment Open Count")]
		[AttributeLogicalName("attachmentopencount")]
		public int? AttachmentOpenCount
		{	
			get { return GetAttributeValue<int?>("attachmentopencount"); }
			set
			{ 
				if(value == AttachmentOpenCount) return;
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
				if(value == ConversationIndexHash) return;
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
				if(value == Bcc) return;
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
		[DisplayName("Cc")]
		[AttributeLogicalName("cc")]
		public EntityCollection Cc
		{	
			get { return GetAttributeValue<EntityCollection>("cc"); }
			set
			{ 
				if(value == Cc) return;
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
				if(value == Compression) return;
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
				if(value == ConversationIndex) return;
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
				if(value == ConversationTrackingId) return;
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
				if(value == CorrelatedActivityId) return;
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
				if(value == Correlatedactivityidname) return;
				SetAttributeValue("correlatedactivityidname", value);
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
				if(value == CorrelationMethod) return;

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
        /// delayedemailsendtime
        /// </summary>
		[DisplayName("Send Later")]
		[AttributeLogicalName("delayedemailsendtime")]
		public DateTime? SendLater
		{	
			get { return GetAttributeValue<DateTime?>("delayedemailsendtime"); }
			set
			{ 
				if(value == SendLater) return;
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
				if(value == NoOfDeliveryAttempts) return;
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
				if(value == DeliveryPriority) return;

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
				if(value == DeliveryReceiptRequested) return;
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
				if(value == Description) return;
				SetAttributeValue("description", value);
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
				if(value == Direction) return;
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
				if(value == EmailReminderExpiryTime) return;
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
				if(value == EmailReminderStatus) return;

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
				if(value == EmailReminderText) return;
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
				if(value == EmailReminderType) return;

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
				if(value == Sender) return;
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
				if(value == EmailSenderName) return;
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
				if(value == EmailSenderType) return;
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
				if(value == EmailSenderYomiName) return;
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
				if(value == EmailTrackingId) return;
				SetAttributeValue("emailtrackingid", value);
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
        /// followemailuserpreference
        /// </summary>
		[DisplayName("Following")]
		[AttributeLogicalName("followemailuserpreference")]
		public bool? Following
		{	
			get { return GetAttributeValue<bool?>("followemailuserpreference"); }
			set
			{ 
				if(value == Following) return;
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
        /// inreplyto
        /// </summary>
		[DisplayName("In Reply To Message")]
		[AttributeLogicalName("inreplyto")]
		public string InReplyToMessage
		{	
			get { return GetAttributeValue<string>("inreplyto"); }
			set
			{ 
				if(value == InReplyToMessage) return;
				SetAttributeValue("inreplyto", value);
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
        /// isemailfollowed
        /// </summary>
		[DisplayName("Followed")]
		[AttributeLogicalName("isemailfollowed")]
		public bool? Followed
		{	
			get { return GetAttributeValue<bool?>("isemailfollowed"); }
			set
			{ 
				if(value == Followed) return;
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
				if(value == ReminderSet) return;
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
        /// lastopenedtime
        /// </summary>
		[DisplayName("Last Opened Time")]
		[AttributeLogicalName("lastopenedtime")]
		public DateTime? LastOpenedTime
		{	
			get { return GetAttributeValue<DateTime?>("lastopenedtime"); }
			set
			{ 
				if(value == LastOpenedTime) return;
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
				if(value == LinksClickedCount) return;
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
				if(value == MessageID) return;
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
				if(value == MessageIDDupCheckId) return;
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
				if(value == MimeType) return;
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
				if(value == Notifications) return;

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
				if(value == OnHoldTimeMinutes) return;
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
				if(value == OpenCount) return;
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
        /// parentactivityid
        /// </summary>
		[DisplayName("Parent Activity Id")]
		[AttributeLogicalName("parentactivityid")]
		public EntityReference ParentActivityId
		{	
			get { return GetAttributeValue<EntityReference>("parentactivityid"); }
			set
			{ 
				if(value == ParentActivityId) return;
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
				if(value == ParentActivityName) return;
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
				if(value == DelayEmailProcessingUntil) return;
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
        /// readreceiptrequested
        /// </summary>
		[DisplayName("Read Receipt Requested")]
		[AttributeLogicalName("readreceiptrequested")]
		public bool? ReadReceiptRequested
		{	
			get { return GetAttributeValue<bool?>("readreceiptrequested"); }
			set
			{ 
				if(value == ReadReceiptRequested) return;
				SetAttributeValue("readreceiptrequested", value);
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
        /// reminderactioncardid
        /// </summary>
		[DisplayName("Reminder Action Card Id.")]
		[AttributeLogicalName("reminderactioncardid")]
		public Guid ReminderActionCardId
		{	
			get { return GetAttributeValue<Guid>("reminderactioncardid"); }
			set
			{ 
				if(value == ReminderActionCardId) return;
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
				if(value == ReplyCount) return;
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
				if(value == ReservedForInternalUse) return;
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
				if(value == SafeDescription) return;
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
        /// sender
        /// </summary>
		[DisplayName("From")]
		[AttributeLogicalName("sender")]
		public string From2
		{	
			get { return GetAttributeValue<string>("sender"); }
			set
			{ 
				if(value == From2) return;
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
        /// sendersaccount
        /// </summary>
		[DisplayName("Senders Account")]
		[AttributeLogicalName("sendersaccount")]
		public EntityReference SendersAccount
		{	
			get { return GetAttributeValue<EntityReference>("sendersaccount"); }
			set
			{ 
				if(value == SendersAccount) return;
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
				if(value == EmailSenderAccountName) return;
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
				if(value == SendersAccountType) return;
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
				if(value == EmailSenderAccountYomiName) return;
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
				if(value == DateSent) return;
				SetAttributeValue("senton", value);
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
        /// submittedby
        /// </summary>
		[DisplayName("Submitted By")]
		[AttributeLogicalName("submittedby")]
		public string SubmittedBy
		{	
			get { return GetAttributeValue<string>("submittedby"); }
			set
			{ 
				if(value == SubmittedBy) return;
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
				if(value == IDForTemplateUsed) return;
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
				if(value == Templateidname) return;
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
        /// torecipients
        /// </summary>
		[DisplayName("To Recipients")]
		[AttributeLogicalName("torecipients")]
		public string ToRecipients
		{	
			get { return GetAttributeValue<string>("torecipients"); }
			set
			{ 
				if(value == ToRecipients) return;
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
				if(value == TrackingToken) return;
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
        /// 1:N Get entities for 'email_actioncard'
        /// </summary>
		[RelationshipSchemaName("email_actioncard")]
		public IEnumerable<ActionCard> EmailActioncard
		{
			get { return GetRelatedEntities<ActionCard>("email_actioncard", null); }
			set { SetRelatedEntities("email_actioncard", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'email_activity_mime_attachment'
        /// </summary>
		[RelationshipSchemaName("email_activity_mime_attachment")]
		public IEnumerable<Attachment> EmailActivityMimeAttachment
		{
			get { return GetRelatedEntities<Attachment>("email_activity_mime_attachment", null); }
			set { SetRelatedEntities("email_activity_mime_attachment", null, value); }
		}
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
        /// 1:N Get entities for 'email_activitymonitor'
        /// </summary>
		[RelationshipSchemaName("email_activitymonitor")]
		public IEnumerable<ActivityMonitor> EmailActivitymonitor
		{
			get { return GetRelatedEntities<ActivityMonitor>("email_activitymonitor", null); }
			set { SetRelatedEntities("email_activitymonitor", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'Email_Annotation'
        /// </summary>
		[RelationshipSchemaName("Email_Annotation")]
		public IEnumerable<Note> EmailAnnotation
		{
			get { return GetRelatedEntities<Note>("Email_Annotation", null); }
			set { SetRelatedEntities("Email_Annotation", null, value); }
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
        /// 1:N Get entities for 'Email_BulkDeleteFailures'
        /// </summary>
		[RelationshipSchemaName("Email_BulkDeleteFailures")]
		public IEnumerable<BulkDeleteFailure> EmailBulkDeleteFailures
		{
			get { return GetRelatedEntities<BulkDeleteFailure>("Email_BulkDeleteFailures", null); }
			set { SetRelatedEntities("Email_BulkDeleteFailures", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'email_campaignresponse'
        /// </summary>
		[RelationshipSchemaName("email_campaignresponse")]
		public IEnumerable<CampaignResponse> EmailCampaignresponse
		{
			get { return GetRelatedEntities<CampaignResponse>("email_campaignresponse", null); }
			set { SetRelatedEntities("email_campaignresponse", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'email_connections1'
        /// </summary>
		[RelationshipSchemaName("email_connections1")]
		public IEnumerable<Connection> EmailConnections1
		{
			get { return GetRelatedEntities<Connection>("email_connections1", null); }
			set { SetRelatedEntities("email_connections1", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'email_connections2'
        /// </summary>
		[RelationshipSchemaName("email_connections2")]
		public IEnumerable<Connection> EmailConnections2
		{
			get { return GetRelatedEntities<Connection>("email_connections2", null); }
			set { SetRelatedEntities("email_connections2", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'Email_DuplicateBaseRecord'
        /// </summary>
		[RelationshipSchemaName("Email_DuplicateBaseRecord")]
		public IEnumerable<DuplicateRecord> EmailDuplicateBaseRecord
		{
			get { return GetRelatedEntities<DuplicateRecord>("Email_DuplicateBaseRecord", null); }
			set { SetRelatedEntities("Email_DuplicateBaseRecord", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'Email_DuplicateMatchingRecord'
        /// </summary>
		[RelationshipSchemaName("Email_DuplicateMatchingRecord")]
		public IEnumerable<DuplicateRecord> EmailDuplicateMatchingRecord
		{
			get { return GetRelatedEntities<DuplicateRecord>("Email_DuplicateMatchingRecord", null); }
			set { SetRelatedEntities("Email_DuplicateMatchingRecord", null, value); }
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
		/// <summary>
        /// 1:N Get entities for 'email_principalobjectattributeaccess'
        /// </summary>
		[RelationshipSchemaName("email_principalobjectattributeaccess")]
		public IEnumerable<FieldSharing> EmailPrincipalobjectattributeaccess
		{
			get { return GetRelatedEntities<FieldSharing>("email_principalobjectattributeaccess", null); }
			set { SetRelatedEntities("email_principalobjectattributeaccess", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'Email_ProcessSessions'
        /// </summary>
		[RelationshipSchemaName("Email_ProcessSessions")]
		public IEnumerable<ProcessSession> EmailProcessSessions
		{
			get { return GetRelatedEntities<ProcessSession>("Email_ProcessSessions", null); }
			set { SetRelatedEntities("Email_ProcessSessions", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'Email_QueueItem'
        /// </summary>
		[RelationshipSchemaName("Email_QueueItem")]
		public IEnumerable<QueueItem> EmailQueueItem
		{
			get { return GetRelatedEntities<QueueItem>("Email_QueueItem", null); }
			set { SetRelatedEntities("Email_QueueItem", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'Email_SyncErrors'
        /// </summary>
		[RelationshipSchemaName("Email_SyncErrors")]
		public IEnumerable<SyncError> EmailSyncErrors
		{
			get { return GetRelatedEntities<SyncError>("Email_SyncErrors", null); }
			set { SetRelatedEntities("Email_SyncErrors", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'slakpiinstance_email'
        /// </summary>
		[RelationshipSchemaName("slakpiinstance_email")]
		public IEnumerable<SLAKPIInstance> SlakpiinstanceEmail
		{
			get { return GetRelatedEntities<SLAKPIInstance>("slakpiinstance_email", null); }
			set { SetRelatedEntities("slakpiinstance_email", null, value); }
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

			/// <summary>isbilled</summary>
			public const string IsBilled = "isbilled";

			/// <summary>isemailfollowed</summary>
			public const string Followed = "isemailfollowed";

			/// <summary>isemailreminderset</summary>
			public const string ReminderSet = "isemailreminderset";

			/// <summary>isregularactivity</summary>
			public const string IsRegularActivity = "isregularactivity";

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

			/// <summary>regardingobjectid</summary>
			public const string Regarding = "regardingobjectid";

			/// <summary>regardingobjectidname</summary>
			public const string Regardingobjectidname = "regardingobjectidname";

			/// <summary>regardingobjectidyominame</summary>
			public const string Regardingobjectidyominame = "regardingobjectidyominame";

			/// <summary>regardingobjecttypecode</summary>
			public const string Regardingobjecttypecode = "regardingobjecttypecode";

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
			/// <summary>1:N email_actioncard</summary>
			public const string EmailActioncard = "email_actioncard";

			/// <summary>1:N email_activity_mime_attachment</summary>
			public const string EmailActivityMimeAttachment = "email_activity_mime_attachment";

			/// <summary>1:N email_activity_parties</summary>
			public const string EmailActivityParties = "email_activity_parties";

			/// <summary>1:N email_activitymonitor</summary>
			public const string EmailActivitymonitor = "email_activitymonitor";

			/// <summary>1:N Email_Annotation</summary>
			public const string EmailAnnotation = "Email_Annotation";

			/// <summary>1:N Email_AsyncOperations</summary>
			public const string EmailAsyncOperations = "Email_AsyncOperations";

			/// <summary>1:N Email_BulkDeleteFailures</summary>
			public const string EmailBulkDeleteFailures = "Email_BulkDeleteFailures";

			/// <summary>1:N email_campaignresponse</summary>
			public const string EmailCampaignresponse = "email_campaignresponse";

			/// <summary>1:N email_connections1</summary>
			public const string EmailConnections1 = "email_connections1";

			/// <summary>1:N email_connections2</summary>
			public const string EmailConnections2 = "email_connections2";

			/// <summary>1:N Email_DuplicateBaseRecord</summary>
			public const string EmailDuplicateBaseRecord = "Email_DuplicateBaseRecord";

			/// <summary>1:N Email_DuplicateMatchingRecord</summary>
			public const string EmailDuplicateMatchingRecord = "Email_DuplicateMatchingRecord";

			/// <summary>1:N email_email_CorrelatedActivityId</summary>
			public const string EmailEmailCorrelatedActivityId = "email_email_CorrelatedActivityId";

			/// <summary>1:N email_email_parentactivityid</summary>
			public const string EmailEmailParentactivityid = "email_email_parentactivityid";

			/// <summary>1:N email_principalobjectattributeaccess</summary>
			public const string EmailPrincipalobjectattributeaccess = "email_principalobjectattributeaccess";

			/// <summary>1:N Email_ProcessSessions</summary>
			public const string EmailProcessSessions = "Email_ProcessSessions";

			/// <summary>1:N Email_QueueItem</summary>
			public const string EmailQueueItem = "Email_QueueItem";

			/// <summary>1:N Email_SyncErrors</summary>
			public const string EmailSyncErrors = "Email_SyncErrors";

			/// <summary>1:N slakpiinstance_email</summary>
			public const string SlakpiinstanceEmail = "slakpiinstance_email";

		}
		#endregion
	}
}

