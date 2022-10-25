using System;
using System.Linq;
using System.Diagnostics;
using System.ComponentModel;
using Microsoft.Xrm.Sdk; 
using Microsoft.Xrm.Sdk.Client;
using System.Collections.Generic;

namespace PentaWork.Xrm.Scheduler.Proxies.Entities
{
	[DebuggerDisplay("{Name}")] 	
	[EntityLogicalName("mailbox")]
	public sealed class Mailbox : Entity
	{	
		public static readonly int? EntityTypeCode = 9606;
		public new const string LogicalName = "mailbox";
		public const string PrimaryIdAttribute = "mailboxid";
		public const string PrimaryNameAttribute = "name";
	
		public Mailbox() : base("mailbox") { }

		#region Attributes
		/// <summary>
        /// actdeliverymethod
        /// </summary>
		[DisplayName("Appointments, Contacts, and Tasks")]
		[AttributeLogicalName("actdeliverymethod")]
		public eAppointmentsContactsAndTasks? AppointmentsContactsAndTasks
		{	
			get 
			{ 
				var optionSetValue = GetAttributeValue<OptionSetValue>("actdeliverymethod");
				if (optionSetValue != null) return (eAppointmentsContactsAndTasks)optionSetValue.Value;
				else return null;
			}
			set 
			{ 
				if(value == AppointmentsContactsAndTasks) return;

				OptionSetValue optionSetValue = null;
				if(value != null) optionSetValue = new OptionSetValue((int)value);
				SetAttributeValue("actdeliverymethod", optionSetValue); 
			}
		}

		/// <summary>
        /// actstatus
        /// </summary>
		[DisplayName("Appointments, Contacts, and Tasks Status")]
		[AttributeLogicalName("actstatus")]
		public eAppointmentsContactsAndTasksStatus? AppointmentsContactsAndTasksStatus
		{	
			get 
			{ 
				var optionSetValue = GetAttributeValue<OptionSetValue>("actstatus");
				if (optionSetValue != null) return (eAppointmentsContactsAndTasksStatus)optionSetValue.Value;
				else return null;
			}
			set 
			{ 
				if(value == AppointmentsContactsAndTasksStatus) return;

				OptionSetValue optionSetValue = null;
				if(value != null) optionSetValue = new OptionSetValue((int)value);
				SetAttributeValue("actstatus", optionSetValue); 
			}
		}

		/// <summary>
        /// allowemailconnectortousecredentials
        /// </summary>
		[DisplayName("Allow to Use Credentials for Email Processing")]
		[AttributeLogicalName("allowemailconnectortousecredentials")]
		public bool? AllowToUseCredentialsForEmailProcessing
		{	
			get { return GetAttributeValue<bool?>("allowemailconnectortousecredentials"); }
			set
			{ 
				if(value == AllowToUseCredentialsForEmailProcessing) return;
				SetAttributeValue("allowemailconnectortousecredentials", value);
			}
		}	
			
		/// <summary>
        /// averagetotalduration
        /// </summary>
		[DisplayName("Monitor Total Performance")]
		[AttributeLogicalName("averagetotalduration")]
		public int? MonitorTotalPerformance
		{	
			get { return GetAttributeValue<int?>("averagetotalduration"); }
			set
			{ 
				if(value == MonitorTotalPerformance) return;
				SetAttributeValue("averagetotalduration", value);
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
        /// emailaddress
        /// </summary>
		[DisplayName("Email Address")]
		[AttributeLogicalName("emailaddress")]
		public string EmailAddress
		{	
			get { return GetAttributeValue<string>("emailaddress"); }
			set
			{ 
				if(value == EmailAddress) return;
				SetAttributeValue("emailaddress", value);
			}
		}	
			
		/// <summary>
        /// emailrouteraccessapproval
        /// </summary>
		[DisplayName("Email Address Status")]
		[AttributeLogicalName("emailrouteraccessapproval")]
		public eShowsWhetherTheEmailAddressIsApprovedForEachMailboxForProcessingEmailThroughServersideSynchronizationOrTheEmailRouter? EmailAddressStatus
		{	
			get 
			{ 
				var optionSetValue = GetAttributeValue<OptionSetValue>("emailrouteraccessapproval");
				if (optionSetValue != null) return (eShowsWhetherTheEmailAddressIsApprovedForEachMailboxForProcessingEmailThroughServersideSynchronizationOrTheEmailRouter)optionSetValue.Value;
				else return null;
			}
			set 
			{ 
				if(value == EmailAddressStatus) return;

				OptionSetValue optionSetValue = null;
				if(value != null) optionSetValue = new OptionSetValue((int)value);
				SetAttributeValue("emailrouteraccessapproval", optionSetValue); 
			}
		}

		/// <summary>
        /// emailserverprofile
        /// </summary>
		[DisplayName("Server Profile")]
		[AttributeLogicalName("emailserverprofile")]
		public EntityReference ServerProfile
		{	
			get { return GetAttributeValue<EntityReference>("emailserverprofile"); }
			set
			{ 
				if(value == ServerProfile) return;
				SetAttributeValue("emailserverprofile", value);
			}
		}	
			
		/// <summary>
        /// emailserverprofilename
        /// </summary>
		[DisplayName("emailserverprofilename")]
		[AttributeLogicalName("emailserverprofilename")]
		public string Emailserverprofilename
		{	
			get { return GetAttributeValue<string>("emailserverprofilename"); }
			set
			{ 
				if(value == Emailserverprofilename) return;
				SetAttributeValue("emailserverprofilename", value);
			}
		}	
			
		/// <summary>
        /// enabledforact
        /// </summary>
		[DisplayName("Enabled For Appointments, Contacts, And Tasks")]
		[AttributeLogicalName("enabledforact")]
		public bool? EnabledForAppointmentsContactsAndTasks
		{	
			get { return GetAttributeValue<bool?>("enabledforact"); }
			set
			{ 
				if(value == EnabledForAppointmentsContactsAndTasks) return;
				SetAttributeValue("enabledforact", value);
			}
		}	
			
		/// <summary>
        /// enabledforincomingemail
        /// </summary>
		[DisplayName("Enabled For Incoming Email")]
		[AttributeLogicalName("enabledforincomingemail")]
		public bool? EnabledForIncomingEmail
		{	
			get { return GetAttributeValue<bool?>("enabledforincomingemail"); }
			set
			{ 
				if(value == EnabledForIncomingEmail) return;
				SetAttributeValue("enabledforincomingemail", value);
			}
		}	
			
		/// <summary>
        /// enabledforoutgoingemail
        /// </summary>
		[DisplayName("Enabled For Outgoing Email")]
		[AttributeLogicalName("enabledforoutgoingemail")]
		public bool? EnabledForOutgoingEmail
		{	
			get { return GetAttributeValue<bool?>("enabledforoutgoingemail"); }
			set
			{ 
				if(value == EnabledForOutgoingEmail) return;
				SetAttributeValue("enabledforoutgoingemail", value);
			}
		}	
			
		/// <summary>
        /// entityimage_timestamp
        /// </summary>
		[DisplayName("entityimage_timestamp")]
		[AttributeLogicalName("entityimage_timestamp")]
		public int? EntityimageTimestamp
		{	
			get { return GetAttributeValue<int?>("entityimage_timestamp"); }
			set
			{ 
				if(value == EntityimageTimestamp) return;
				SetAttributeValue("entityimage_timestamp", value);
			}
		}	
			
		/// <summary>
        /// entityimage_url
        /// </summary>
		[DisplayName("entityimage_url")]
		[AttributeLogicalName("entityimage_url")]
		public string EntityimageUrl
		{	
			get { return GetAttributeValue<string>("entityimage_url"); }
			set
			{ 
				if(value == EntityimageUrl) return;
				SetAttributeValue("entityimage_url", value);
			}
		}	
			
		/// <summary>
        /// entityimageid
        /// </summary>
		[DisplayName("Entity Image Id")]
		[AttributeLogicalName("entityimageid")]
		public Guid EntityImageId
		{	
			get { return GetAttributeValue<Guid>("entityimageid"); }
			set
			{ 
				if(value == EntityImageId) return;
				SetAttributeValue("entityimageid", value);
			}
		}	
			
		/// <summary>
        /// ewsurl
        /// </summary>
		[DisplayName("Exchange Web Services URL")]
		[AttributeLogicalName("ewsurl")]
		public string ExchangeWebServicesURL
		{	
			get { return GetAttributeValue<string>("ewsurl"); }
			set
			{ 
				if(value == ExchangeWebServicesURL) return;
				SetAttributeValue("ewsurl", value);
			}
		}	
			
		/// <summary>
        /// exchangecontactsimportcompletedon
        /// </summary>
		[DisplayName("Exchange Contacts Import Completed On")]
		[AttributeLogicalName("exchangecontactsimportcompletedon")]
		public DateTime? ExchangeContactsImportCompletedOn
		{	
			get { return GetAttributeValue<DateTime?>("exchangecontactsimportcompletedon"); }
			set
			{ 
				if(value == ExchangeContactsImportCompletedOn) return;
				SetAttributeValue("exchangecontactsimportcompletedon", value);
			}
		}	
			
		/// <summary>
        /// exchangecontactsimportstatus
        /// </summary>
		[DisplayName("Exchange Contacts Import Status")]
		[AttributeLogicalName("exchangecontactsimportstatus")]
		public eExchangeContactsImportDeploymentStatus? ExchangeContactsImportStatus
		{	
			get 
			{ 
				var optionSetValue = GetAttributeValue<OptionSetValue>("exchangecontactsimportstatus");
				if (optionSetValue != null) return (eExchangeContactsImportDeploymentStatus)optionSetValue.Value;
				else return null;
			}
			set 
			{ 
				if(value == ExchangeContactsImportStatus) return;

				OptionSetValue optionSetValue = null;
				if(value != null) optionSetValue = new OptionSetValue((int)value);
				SetAttributeValue("exchangecontactsimportstatus", optionSetValue); 
			}
		}

		/// <summary>
        /// exchangesyncstatexml
        /// </summary>
		[DisplayName("Exchange Sync State")]
		[AttributeLogicalName("exchangesyncstatexml")]
		public string ExchangeSyncState
		{	
			get { return GetAttributeValue<string>("exchangesyncstatexml"); }
			set
			{ 
				if(value == ExchangeSyncState) return;
				SetAttributeValue("exchangesyncstatexml", value);
			}
		}	
			
		/// <summary>
        /// exchangesyncstatexmlfileref_name
        /// </summary>
		[DisplayName("exchangesyncstatexmlfileref_name")]
		[AttributeLogicalName("exchangesyncstatexmlfileref_name")]
		public string ExchangesyncstatexmlfilerefName
		{	
			get { return GetAttributeValue<string>("exchangesyncstatexmlfileref_name"); }
			set
			{ 
				if(value == ExchangesyncstatexmlfilerefName) return;
				SetAttributeValue("exchangesyncstatexmlfileref_name", value);
			}
		}	
			
		/// <summary>
        /// folderhierarchy
        /// </summary>
		[DisplayName("Folder Hierarchy")]
		[AttributeLogicalName("folderhierarchy")]
		public string FolderHierarchy
		{	
			get { return GetAttributeValue<string>("folderhierarchy"); }
			set
			{ 
				if(value == FolderHierarchy) return;
				SetAttributeValue("folderhierarchy", value);
			}
		}	
			
		/// <summary>
        /// forcedunlockcount
        /// </summary>
		[DisplayName("Count of the number of times a mailbox gets forced unlocked")]
		[AttributeLogicalName("forcedunlockcount")]
		public int? CountOfTheNumberOfTimesAMailboxGetsForcedUnlocked
		{	
			get { return GetAttributeValue<int?>("forcedunlockcount"); }
			set
			{ 
				if(value == CountOfTheNumberOfTimesAMailboxGetsForcedUnlocked) return;
				SetAttributeValue("forcedunlockcount", value);
			}
		}	
			
		/// <summary>
        /// hostid
        /// </summary>
		[DisplayName("Host")]
		[AttributeLogicalName("hostid")]
		public string Host
		{	
			get { return GetAttributeValue<string>("hostid"); }
			set
			{ 
				if(value == Host) return;
				SetAttributeValue("hostid", value);
			}
		}	
			
		/// <summary>
        /// incomingemaildeliverymethod
        /// </summary>
		[DisplayName("Incoming Email")]
		[AttributeLogicalName("incomingemaildeliverymethod")]
		public eIncomingEmailDeliveryMethod? IncomingEmail
		{	
			get 
			{ 
				var optionSetValue = GetAttributeValue<OptionSetValue>("incomingemaildeliverymethod");
				if (optionSetValue != null) return (eIncomingEmailDeliveryMethod)optionSetValue.Value;
				else return null;
			}
			set 
			{ 
				if(value == IncomingEmail) return;

				OptionSetValue optionSetValue = null;
				if(value != null) optionSetValue = new OptionSetValue((int)value);
				SetAttributeValue("incomingemaildeliverymethod", optionSetValue); 
			}
		}

		/// <summary>
        /// incomingemailstatus
        /// </summary>
		[DisplayName("Incoming Email Status")]
		[AttributeLogicalName("incomingemailstatus")]
		public eIncomingEmailStatus? IncomingEmailStatus
		{	
			get 
			{ 
				var optionSetValue = GetAttributeValue<OptionSetValue>("incomingemailstatus");
				if (optionSetValue != null) return (eIncomingEmailStatus)optionSetValue.Value;
				else return null;
			}
			set 
			{ 
				if(value == IncomingEmailStatus) return;

				OptionSetValue optionSetValue = null;
				if(value != null) optionSetValue = new OptionSetValue((int)value);
				SetAttributeValue("incomingemailstatus", optionSetValue); 
			}
		}

		/// <summary>
        /// isactsyncorgflagset
        /// </summary>
		[DisplayName("Set Current Organization as Synchronization Organization")]
		[AttributeLogicalName("isactsyncorgflagset")]
		public bool? SetCurrentOrganizationAsSynchronizationOrganization
		{	
			get { return GetAttributeValue<bool?>("isactsyncorgflagset"); }
			set
			{ 
				if(value == SetCurrentOrganizationAsSynchronizationOrganization) return;
				SetAttributeValue("isactsyncorgflagset", value);
			}
		}	
			
		/// <summary>
        /// isemailaddressapprovedbyo365admin
        /// </summary>
		[DisplayName("Email Address O365 Admin Approval Status")]
		[AttributeLogicalName("isemailaddressapprovedbyo365admin")]
		public bool? EmailAddressO365AdminApprovalStatus
		{	
			get { return GetAttributeValue<bool?>("isemailaddressapprovedbyo365admin"); }
			set
			{ 
				if(value == EmailAddressO365AdminApprovalStatus) return;
				SetAttributeValue("isemailaddressapprovedbyo365admin", value);
			}
		}	
			
		/// <summary>
        /// isexchangecontactsimportscheduled
        /// </summary>
		[DisplayName("Is Exchange Contacts Import Scheduled.")]
		[AttributeLogicalName("isexchangecontactsimportscheduled")]
		public bool? IsExchangeContactsImportScheduled
		{	
			get { return GetAttributeValue<bool?>("isexchangecontactsimportscheduled"); }
			set
			{ 
				if(value == IsExchangeContactsImportScheduled) return;
				SetAttributeValue("isexchangecontactsimportscheduled", value);
			}
		}	
			
		/// <summary>
        /// isforwardmailbox
        /// </summary>
		[DisplayName("Is Forward Mailbox")]
		[AttributeLogicalName("isforwardmailbox")]
		public bool? IsForwardMailbox
		{	
			get { return GetAttributeValue<bool?>("isforwardmailbox"); }
			set
			{ 
				if(value == IsForwardMailbox) return;
				SetAttributeValue("isforwardmailbox", value);
			}
		}	
			
		/// <summary>
        /// isoauthaccesstokenset
        /// </summary>
		[DisplayName("isoauthaccesstokenset")]
		[AttributeLogicalName("isoauthaccesstokenset")]
		public bool? Isoauthaccesstokenset
		{	
			get { return GetAttributeValue<bool?>("isoauthaccesstokenset"); }
			set
			{ 
				if(value == Isoauthaccesstokenset) return;
				SetAttributeValue("isoauthaccesstokenset", value);
			}
		}	
			
		/// <summary>
        /// isoauthrefreshtokenset
        /// </summary>
		[DisplayName("isoauthrefreshtokenset")]
		[AttributeLogicalName("isoauthrefreshtokenset")]
		public bool? Isoauthrefreshtokenset
		{	
			get { return GetAttributeValue<bool?>("isoauthrefreshtokenset"); }
			set
			{ 
				if(value == Isoauthrefreshtokenset) return;
				SetAttributeValue("isoauthrefreshtokenset", value);
			}
		}	
			
		/// <summary>
        /// ispasswordset
        /// </summary>
		[DisplayName("ispasswordset")]
		[AttributeLogicalName("ispasswordset")]
		public bool? Ispasswordset
		{	
			get { return GetAttributeValue<bool?>("ispasswordset"); }
			set
			{ 
				if(value == Ispasswordset) return;
				SetAttributeValue("ispasswordset", value);
			}
		}	
			
		/// <summary>
        /// isserviceaccount
        /// </summary>
		[DisplayName("Is Service Account")]
		[AttributeLogicalName("isserviceaccount")]
		public bool? IsServiceAccount
		{	
			get { return GetAttributeValue<bool?>("isserviceaccount"); }
			set
			{ 
				if(value == IsServiceAccount) return;
				SetAttributeValue("isserviceaccount", value);
			}
		}	
			
		/// <summary>
        /// itemsfailedforlastsync
        /// </summary>
		[DisplayName("Items Failed For Last Sync")]
		[AttributeLogicalName("itemsfailedforlastsync")]
		public int? ItemsFailedForLastSync
		{	
			get { return GetAttributeValue<int?>("itemsfailedforlastsync"); }
			set
			{ 
				if(value == ItemsFailedForLastSync) return;
				SetAttributeValue("itemsfailedforlastsync", value);
			}
		}	
			
		/// <summary>
        /// itemsprocessedforlastsync
        /// </summary>
		[DisplayName("Items Processed For Last Sync")]
		[AttributeLogicalName("itemsprocessedforlastsync")]
		public int? ItemsProcessedForLastSync
		{	
			get { return GetAttributeValue<int?>("itemsprocessedforlastsync"); }
			set
			{ 
				if(value == ItemsProcessedForLastSync) return;
				SetAttributeValue("itemsprocessedforlastsync", value);
			}
		}	
			
		/// <summary>
        /// lastactiveon
        /// </summary>
		[DisplayName("Last Active On")]
		[AttributeLogicalName("lastactiveon")]
		public DateTime? LastActiveOn
		{	
			get { return GetAttributeValue<DateTime?>("lastactiveon"); }
			set
			{ 
				if(value == LastActiveOn) return;
				SetAttributeValue("lastactiveon", value);
			}
		}	
			
		/// <summary>
        /// lastautodiscoveredon
        /// </summary>
		[DisplayName("Last Auto Discovered On")]
		[AttributeLogicalName("lastautodiscoveredon")]
		public DateTime? LastAutoDiscoveredOn
		{	
			get { return GetAttributeValue<DateTime?>("lastautodiscoveredon"); }
			set
			{ 
				if(value == LastAutoDiscoveredOn) return;
				SetAttributeValue("lastautodiscoveredon", value);
			}
		}	
			
		/// <summary>
        /// lastduration
        /// </summary>
		[DisplayName("Monitor last duration Performance")]
		[AttributeLogicalName("lastduration")]
		public int? MonitorLastDurationPerformance
		{	
			get { return GetAttributeValue<int?>("lastduration"); }
			set
			{ 
				if(value == MonitorLastDurationPerformance) return;
				SetAttributeValue("lastduration", value);
			}
		}	
			
		/// <summary>
        /// lastmailboxforcedunlockoccurredon
        /// </summary>
		[DisplayName("Last Date Time when a mailbox got forced unlocked")]
		[AttributeLogicalName("lastmailboxforcedunlockoccurredon")]
		public DateTime? LastDateTimeWhenAMailboxGotForcedUnlocked
		{	
			get { return GetAttributeValue<DateTime?>("lastmailboxforcedunlockoccurredon"); }
			set
			{ 
				if(value == LastDateTimeWhenAMailboxGotForcedUnlocked) return;
				SetAttributeValue("lastmailboxforcedunlockoccurredon", value);
			}
		}	
			
		/// <summary>
        /// lastmessageid
        /// </summary>
		[DisplayName("Last Message ID")]
		[AttributeLogicalName("lastmessageid")]
		public string LastMessageID
		{	
			get { return GetAttributeValue<string>("lastmessageid"); }
			set
			{ 
				if(value == LastMessageID) return;
				SetAttributeValue("lastmessageid", value);
			}
		}	
			
		/// <summary>
        /// lastsuccessfulsynccompletedon
        /// </summary>
		[DisplayName("Last Successful Sync Time")]
		[AttributeLogicalName("lastsuccessfulsynccompletedon")]
		public DateTime? LastSuccessfulSyncTime
		{	
			get { return GetAttributeValue<DateTime?>("lastsuccessfulsynccompletedon"); }
			set
			{ 
				if(value == LastSuccessfulSyncTime) return;
				SetAttributeValue("lastsuccessfulsynccompletedon", value);
			}
		}	
			
		/// <summary>
        /// lastsyncerror
        /// </summary>
		[DisplayName("Last Sync Error Stack")]
		[AttributeLogicalName("lastsyncerror")]
		public string LastSyncErrorStack
		{	
			get { return GetAttributeValue<string>("lastsyncerror"); }
			set
			{ 
				if(value == LastSyncErrorStack) return;
				SetAttributeValue("lastsyncerror", value);
			}
		}	
			
		/// <summary>
        /// lastsyncerrorcode
        /// </summary>
		[DisplayName("Last Sync Error Code")]
		[AttributeLogicalName("lastsyncerrorcode")]
		public int? LastSyncErrorCode
		{	
			get { return GetAttributeValue<int?>("lastsyncerrorcode"); }
			set
			{ 
				if(value == LastSyncErrorCode) return;
				SetAttributeValue("lastsyncerrorcode", value);
			}
		}	
			
		/// <summary>
        /// lastsyncerrorcount
        /// </summary>
		[DisplayName("Last Sync Error Continuous Count")]
		[AttributeLogicalName("lastsyncerrorcount")]
		public int? LastSyncErrorContinuousCount
		{	
			get { return GetAttributeValue<int?>("lastsyncerrorcount"); }
			set
			{ 
				if(value == LastSyncErrorContinuousCount) return;
				SetAttributeValue("lastsyncerrorcount", value);
			}
		}	
			
		/// <summary>
        /// lastsyncerrormachinename
        /// </summary>
		[DisplayName("Last Sync Error Machine Name")]
		[AttributeLogicalName("lastsyncerrormachinename")]
		public string LastSyncErrorMachineName
		{	
			get { return GetAttributeValue<string>("lastsyncerrormachinename"); }
			set
			{ 
				if(value == LastSyncErrorMachineName) return;
				SetAttributeValue("lastsyncerrormachinename", value);
			}
		}	
			
		/// <summary>
        /// lastsyncerroroccurredon
        /// </summary>
		[DisplayName("Last Sync Error Time")]
		[AttributeLogicalName("lastsyncerroroccurredon")]
		public DateTime? LastSyncErrorTime
		{	
			get { return GetAttributeValue<DateTime?>("lastsyncerroroccurredon"); }
			set
			{ 
				if(value == LastSyncErrorTime) return;
				SetAttributeValue("lastsyncerroroccurredon", value);
			}
		}	
			
		/// <summary>
        /// lastsyncstartedon
        /// </summary>
		[DisplayName("Last Sync Start Time")]
		[AttributeLogicalName("lastsyncstartedon")]
		public DateTime? LastSyncStartTime
		{	
			get { return GetAttributeValue<DateTime?>("lastsyncstartedon"); }
			set
			{ 
				if(value == LastSyncStartTime) return;
				SetAttributeValue("lastsyncstartedon", value);
			}
		}	
			
		/// <summary>
        /// mailboxid
        /// </summary>
		[DisplayName("Mailbox")]
		[AttributeLogicalName("mailboxid")]
		public override Guid Id
		{
			get => base.Id;
			set { base.Id = value; SetAttributeValue("mailboxid", value); }
		}

							/// <summary>
        /// mailboxprocessingcontext
        /// </summary>
		[DisplayName("Processing Context of the Mailbox")]
		[AttributeLogicalName("mailboxprocessingcontext")]
		public int? ProcessingContextOfTheMailbox
		{	
			get { return GetAttributeValue<int?>("mailboxprocessingcontext"); }
			set
			{ 
				if(value == ProcessingContextOfTheMailbox) return;
				SetAttributeValue("mailboxprocessingcontext", value);
			}
		}	
			
		/// <summary>
        /// mailboxstatus
        /// </summary>
		[DisplayName("Mailbox Status")]
		[AttributeLogicalName("mailboxstatus")]
		public eMailboxStatus? MailboxStatus
		{	
			get 
			{ 
				var optionSetValue = GetAttributeValue<OptionSetValue>("mailboxstatus");
				if (optionSetValue != null) return (eMailboxStatus)optionSetValue.Value;
				else return null;
			}
			set 
			{ 
				if(value == MailboxStatus) return;

				OptionSetValue optionSetValue = null;
				if(value != null) optionSetValue = new OptionSetValue((int)value);
				SetAttributeValue("mailboxstatus", optionSetValue); 
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
        /// name
        /// </summary>
		[DisplayName("Name")]
		[AttributeLogicalName("name")]
		public string Name
		{	
			get { return GetAttributeValue<string>("name"); }
			set
			{ 
				if(value == Name) return;
				SetAttributeValue("name", value);
			}
		}	
			
		/// <summary>
        /// noactcount
        /// </summary>
		[DisplayName("Zero appointment, contact, task count for mailbox")]
		[AttributeLogicalName("noactcount")]
		public int? ZeroAppointmentContactTaskCountForMailbox
		{	
			get { return GetAttributeValue<int?>("noactcount"); }
			set
			{ 
				if(value == ZeroAppointmentContactTaskCountForMailbox) return;
				SetAttributeValue("noactcount", value);
			}
		}	
			
		/// <summary>
        /// noemailcount
        /// </summary>
		[DisplayName("Zero email count for mailbox")]
		[AttributeLogicalName("noemailcount")]
		public int? ZeroEmailCountForMailbox
		{	
			get { return GetAttributeValue<int?>("noemailcount"); }
			set
			{ 
				if(value == ZeroEmailCountForMailbox) return;
				SetAttributeValue("noemailcount", value);
			}
		}	
			
		/// <summary>
        /// oauthaccesstoken
        /// </summary>
		[DisplayName("Oauth access token")]
		[AttributeLogicalName("oauthaccesstoken")]
		public string OauthAccessToken
		{	
			get { return GetAttributeValue<string>("oauthaccesstoken"); }
			set
			{ 
				if(value == OauthAccessToken) return;
				SetAttributeValue("oauthaccesstoken", value);
			}
		}	
			
		/// <summary>
        /// oauthrefreshtoken
        /// </summary>
		[DisplayName("Oauth refresh token")]
		[AttributeLogicalName("oauthrefreshtoken")]
		public string OauthRefreshToken
		{	
			get { return GetAttributeValue<string>("oauthrefreshtoken"); }
			set
			{ 
				if(value == OauthRefreshToken) return;
				SetAttributeValue("oauthrefreshtoken", value);
			}
		}	
			
		/// <summary>
        /// oauthtokenexpireson
        /// </summary>
		[DisplayName("Oauth token expiration datetime")]
		[AttributeLogicalName("oauthtokenexpireson")]
		public DateTime? OauthTokenExpirationDatetime
		{	
			get { return GetAttributeValue<DateTime?>("oauthtokenexpireson"); }
			set
			{ 
				if(value == OauthTokenExpirationDatetime) return;
				SetAttributeValue("oauthtokenexpireson", value);
			}
		}	
			
		/// <summary>
        /// officeappsdeploymentcompleteon
        /// </summary>
		[DisplayName("Office Apps Deployment Completed On")]
		[AttributeLogicalName("officeappsdeploymentcompleteon")]
		public DateTime? OfficeAppsDeploymentCompletedOn
		{	
			get { return GetAttributeValue<DateTime?>("officeappsdeploymentcompleteon"); }
			set
			{ 
				if(value == OfficeAppsDeploymentCompletedOn) return;
				SetAttributeValue("officeappsdeploymentcompleteon", value);
			}
		}	
			
		/// <summary>
        /// officeappsdeploymenterror
        /// </summary>
		[DisplayName("Office Apps Deployment Error")]
		[AttributeLogicalName("officeappsdeploymenterror")]
		public string OfficeAppsDeploymentError
		{	
			get { return GetAttributeValue<string>("officeappsdeploymenterror"); }
			set
			{ 
				if(value == OfficeAppsDeploymentError) return;
				SetAttributeValue("officeappsdeploymenterror", value);
			}
		}	
			
		/// <summary>
        /// officeappsdeploymentscheduled
        /// </summary>
		[DisplayName("Office Apps Deployment Scheduled")]
		[AttributeLogicalName("officeappsdeploymentscheduled")]
		public bool? OfficeAppsDeploymentScheduled
		{	
			get { return GetAttributeValue<bool?>("officeappsdeploymentscheduled"); }
			set
			{ 
				if(value == OfficeAppsDeploymentScheduled) return;
				SetAttributeValue("officeappsdeploymentscheduled", value);
			}
		}	
			
		/// <summary>
        /// officeappsdeploymentstatus
        /// </summary>
		[DisplayName("Office Apps Deployment Type")]
		[AttributeLogicalName("officeappsdeploymentstatus")]
		public eOfficeAppsDeploymentType? OfficeAppsDeploymentType
		{	
			get 
			{ 
				var optionSetValue = GetAttributeValue<OptionSetValue>("officeappsdeploymentstatus");
				if (optionSetValue != null) return (eOfficeAppsDeploymentType)optionSetValue.Value;
				else return null;
			}
			set 
			{ 
				if(value == OfficeAppsDeploymentType) return;

				OptionSetValue optionSetValue = null;
				if(value != null) optionSetValue = new OptionSetValue((int)value);
				SetAttributeValue("officeappsdeploymentstatus", optionSetValue); 
			}
		}

		/// <summary>
        /// organizationid
        /// </summary>
		[DisplayName("Organization")]
		[AttributeLogicalName("organizationid")]
		public EntityReference Organization
		{	
			get { return GetAttributeValue<EntityReference>("organizationid"); }
			set
			{ 
				if(value == Organization) return;
				SetAttributeValue("organizationid", value);
			}
		}	
			
		/// <summary>
        /// organizationidname
        /// </summary>
		[DisplayName("organizationidname")]
		[AttributeLogicalName("organizationidname")]
		public string Organizationidname
		{	
			get { return GetAttributeValue<string>("organizationidname"); }
			set
			{ 
				if(value == Organizationidname) return;
				SetAttributeValue("organizationidname", value);
			}
		}	
			
		/// <summary>
        /// orgmarkedasprimaryforexchangesync
        /// </summary>
		[DisplayName("Crm Org Marked as Primary Org for Exchange Mailbox")]
		[AttributeLogicalName("orgmarkedasprimaryforexchangesync")]
		public bool? CrmOrgMarkedAsPrimaryOrgForExchangeMailbox
		{	
			get { return GetAttributeValue<bool?>("orgmarkedasprimaryforexchangesync"); }
			set
			{ 
				if(value == CrmOrgMarkedAsPrimaryOrgForExchangeMailbox) return;
				SetAttributeValue("orgmarkedasprimaryforexchangesync", value);
			}
		}	
			
		/// <summary>
        /// outgoingemaildeliverymethod
        /// </summary>
		[DisplayName("Outgoing Email")]
		[AttributeLogicalName("outgoingemaildeliverymethod")]
		public eOutgoingEmailDeliveryMethod? OutgoingEmail
		{	
			get 
			{ 
				var optionSetValue = GetAttributeValue<OptionSetValue>("outgoingemaildeliverymethod");
				if (optionSetValue != null) return (eOutgoingEmailDeliveryMethod)optionSetValue.Value;
				else return null;
			}
			set 
			{ 
				if(value == OutgoingEmail) return;

				OptionSetValue optionSetValue = null;
				if(value != null) optionSetValue = new OptionSetValue((int)value);
				SetAttributeValue("outgoingemaildeliverymethod", optionSetValue); 
			}
		}

		/// <summary>
        /// outgoingemailstatus
        /// </summary>
		[DisplayName("Outgoing Email Status")]
		[AttributeLogicalName("outgoingemailstatus")]
		public eOutgoingEmailStatus? OutgoingEmailStatus
		{	
			get 
			{ 
				var optionSetValue = GetAttributeValue<OptionSetValue>("outgoingemailstatus");
				if (optionSetValue != null) return (eOutgoingEmailStatus)optionSetValue.Value;
				else return null;
			}
			set 
			{ 
				if(value == OutgoingEmailStatus) return;

				OptionSetValue optionSetValue = null;
				if(value != null) optionSetValue = new OptionSetValue((int)value);
				SetAttributeValue("outgoingemailstatus", optionSetValue); 
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
        /// owningbusinessunitname
        /// </summary>
		[DisplayName("owningbusinessunitname")]
		[AttributeLogicalName("owningbusinessunitname")]
		public string Owningbusinessunitname
		{	
			get { return GetAttributeValue<string>("owningbusinessunitname"); }
			set
			{ 
				if(value == Owningbusinessunitname) return;
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
        /// password
        /// </summary>
		[DisplayName("Password")]
		[AttributeLogicalName("password")]
		public string Password
		{	
			get { return GetAttributeValue<string>("password"); }
			set
			{ 
				if(value == Password) return;
				SetAttributeValue("password", value);
			}
		}	
			
		/// <summary>
        /// postponemailboxprocessinguntil
        /// </summary>
		[DisplayName("Postpone Mailbox Processing Until")]
		[AttributeLogicalName("postponemailboxprocessinguntil")]
		public DateTime? PostponeMailboxProcessingUntil
		{	
			get { return GetAttributeValue<DateTime?>("postponemailboxprocessinguntil"); }
			set
			{ 
				if(value == PostponeMailboxProcessingUntil) return;
				SetAttributeValue("postponemailboxprocessinguntil", value);
			}
		}	
			
		/// <summary>
        /// postponeofficeappsdeploymentuntil
        /// </summary>
		[DisplayName("Postpone Outlook Mail App Install Until")]
		[AttributeLogicalName("postponeofficeappsdeploymentuntil")]
		public DateTime? PostponeOutlookMailAppInstallUntil
		{	
			get { return GetAttributeValue<DateTime?>("postponeofficeappsdeploymentuntil"); }
			set
			{ 
				if(value == PostponeOutlookMailAppInstallUntil) return;
				SetAttributeValue("postponeofficeappsdeploymentuntil", value);
			}
		}	
			
		/// <summary>
        /// postponesendinguntil
        /// </summary>
		[DisplayName("Postpone Sending Until")]
		[AttributeLogicalName("postponesendinguntil")]
		public DateTime? PostponeSendingUntil
		{	
			get { return GetAttributeValue<DateTime?>("postponesendinguntil"); }
			set
			{ 
				if(value == PostponeSendingUntil) return;
				SetAttributeValue("postponesendinguntil", value);
			}
		}	
			
		/// <summary>
        /// postponetestemailconfigurationuntil
        /// </summary>
		[DisplayName("Postpone Test Email Configuration Until")]
		[AttributeLogicalName("postponetestemailconfigurationuntil")]
		public DateTime? PostponeTestEmailConfigurationUntil
		{	
			get { return GetAttributeValue<DateTime?>("postponetestemailconfigurationuntil"); }
			set
			{ 
				if(value == PostponeTestEmailConfigurationUntil) return;
				SetAttributeValue("postponetestemailconfigurationuntil", value);
			}
		}	
			
		/// <summary>
        /// processanddeleteemails
        /// </summary>
		[DisplayName("Delete Emails after Processing")]
		[AttributeLogicalName("processanddeleteemails")]
		public bool? DeleteEmailsAfterProcessing
		{	
			get { return GetAttributeValue<bool?>("processanddeleteemails"); }
			set
			{ 
				if(value == DeleteEmailsAfterProcessing) return;
				SetAttributeValue("processanddeleteemails", value);
			}
		}	
			
		/// <summary>
        /// processedtimes
        /// </summary>
		[DisplayName("Monitor Performance")]
		[AttributeLogicalName("processedtimes")]
		public int? MonitorPerformance
		{	
			get { return GetAttributeValue<int?>("processedtimes"); }
			set
			{ 
				if(value == MonitorPerformance) return;
				SetAttributeValue("processedtimes", value);
			}
		}	
			
		/// <summary>
        /// processemailreceivedafter
        /// </summary>
		[DisplayName("Process Email Received After")]
		[AttributeLogicalName("processemailreceivedafter")]
		public DateTime? ProcessEmailReceivedAfter
		{	
			get { return GetAttributeValue<DateTime?>("processemailreceivedafter"); }
			set
			{ 
				if(value == ProcessEmailReceivedAfter) return;
				SetAttributeValue("processemailreceivedafter", value);
			}
		}	
			
		/// <summary>
        /// processinglastattemptedon
        /// </summary>
		[DisplayName("Date Processing Last Attempted")]
		[AttributeLogicalName("processinglastattemptedon")]
		public DateTime? DateProcessingLastAttempted
		{	
			get { return GetAttributeValue<DateTime?>("processinglastattemptedon"); }
			set
			{ 
				if(value == DateProcessingLastAttempted) return;
				SetAttributeValue("processinglastattemptedon", value);
			}
		}	
			
		/// <summary>
        /// processingstatecode
        /// </summary>
		[DisplayName("Mailbox Processing State")]
		[AttributeLogicalName("processingstatecode")]
		public int? MailboxProcessingState
		{	
			get { return GetAttributeValue<int?>("processingstatecode"); }
			set
			{ 
				if(value == MailboxProcessingState) return;
				SetAttributeValue("processingstatecode", value);
			}
		}	
			
		/// <summary>
        /// receivingpostponeduntil
        /// </summary>
		[DisplayName("Postpone receiving emails for the mailbox until the specified data and time.")]
		[AttributeLogicalName("receivingpostponeduntil")]
		public DateTime? PostponeReceivingEmailsForTheMailboxUntilTheSpecifiedDataAndTime
		{	
			get { return GetAttributeValue<DateTime?>("receivingpostponeduntil"); }
			set
			{ 
				if(value == PostponeReceivingEmailsForTheMailboxUntilTheSpecifiedDataAndTime) return;
				SetAttributeValue("receivingpostponeduntil", value);
			}
		}	
			
		/// <summary>
        /// receivingpostponeduntilforact
        /// </summary>
		[DisplayName("Postpone processing Appointments, Contacts, and Tasks for the mailbox until the specified data and time.")]
		[AttributeLogicalName("receivingpostponeduntilforact")]
		public DateTime? PostponeProcessingAppointmentsContactsAndTasksForTheMailboxUntilTheSpecifiedDataAndTime
		{	
			get { return GetAttributeValue<DateTime?>("receivingpostponeduntilforact"); }
			set
			{ 
				if(value == PostponeProcessingAppointmentsContactsAndTasksForTheMailboxUntilTheSpecifiedDataAndTime) return;
				SetAttributeValue("receivingpostponeduntilforact", value);
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
		[DisplayName("Regarding Name")]
		[AttributeLogicalName("regardingobjectidname")]
		public string RegardingName
		{	
			get { return GetAttributeValue<string>("regardingobjectidname"); }
			set
			{ 
				if(value == RegardingName) return;
				SetAttributeValue("regardingobjectidname", value);
			}
		}	
			
		/// <summary>
        /// regardingobjecttypecode
        /// </summary>
		[DisplayName("Regarding Object Type Code")]
		[AttributeLogicalName("regardingobjecttypecode")]
		public string RegardingObjectTypeCode
		{	
			get { return GetAttributeValue<string>("regardingobjecttypecode"); }
			set
			{ 
				if(value == RegardingObjectTypeCode) return;
				SetAttributeValue("regardingobjecttypecode", value);
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
        /// testemailconfigurationretrycount
        /// </summary>
		[DisplayName("Test Email Configuration Retry Count")]
		[AttributeLogicalName("testemailconfigurationretrycount")]
		public int? TestEmailConfigurationRetryCount
		{	
			get { return GetAttributeValue<int?>("testemailconfigurationretrycount"); }
			set
			{ 
				if(value == TestEmailConfigurationRetryCount) return;
				SetAttributeValue("testemailconfigurationretrycount", value);
			}
		}	
			
		/// <summary>
        /// testemailconfigurationscheduled
        /// </summary>
		[DisplayName("Test Email Configuration Scheduled")]
		[AttributeLogicalName("testemailconfigurationscheduled")]
		public bool? TestEmailConfigurationScheduled
		{	
			get { return GetAttributeValue<bool?>("testemailconfigurationscheduled"); }
			set
			{ 
				if(value == TestEmailConfigurationScheduled) return;
				SetAttributeValue("testemailconfigurationscheduled", value);
			}
		}	
			
		/// <summary>
        /// testmailboxaccesscompletedon
        /// </summary>
		[DisplayName("Mailbox Test Completed On")]
		[AttributeLogicalName("testmailboxaccesscompletedon")]
		public DateTime? MailboxTestCompletedOn
		{	
			get { return GetAttributeValue<DateTime?>("testmailboxaccesscompletedon"); }
			set
			{ 
				if(value == MailboxTestCompletedOn) return;
				SetAttributeValue("testmailboxaccesscompletedon", value);
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
        /// transientfailurecount
        /// </summary>
		[DisplayName("Transient Failure Count")]
		[AttributeLogicalName("transientfailurecount")]
		public int? TransientFailureCount
		{	
			get { return GetAttributeValue<int?>("transientfailurecount"); }
			set
			{ 
				if(value == TransientFailureCount) return;
				SetAttributeValue("transientfailurecount", value);
			}
		}	
			
		/// <summary>
        /// undeliverablefolder
        /// </summary>
		[DisplayName("Undeliverable Folder")]
		[AttributeLogicalName("undeliverablefolder")]
		public string UndeliverableFolder
		{	
			get { return GetAttributeValue<string>("undeliverablefolder"); }
			set
			{ 
				if(value == UndeliverableFolder) return;
				SetAttributeValue("undeliverablefolder", value);
			}
		}	
			
		/// <summary>
        /// username
        /// </summary>
		[DisplayName("User Name")]
		[AttributeLogicalName("username")]
		public string UserName
		{	
			get { return GetAttributeValue<string>("username"); }
			set
			{ 
				if(value == UserName) return;
				SetAttributeValue("username", value);
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
        /// verboseloggingenabled
        /// </summary>
		[DisplayName("Verbose Logging")]
		[AttributeLogicalName("verboseloggingenabled")]
		public int? VerboseLogging
		{	
			get { return GetAttributeValue<int?>("verboseloggingenabled"); }
			set
			{ 
				if(value == VerboseLogging) return;
				SetAttributeValue("verboseloggingenabled", value);
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
        /// 1:N Get entities for 'activitypointer_sendermailboxid_mailbox'
        /// </summary>
		[RelationshipSchemaName("activitypointer_sendermailboxid_mailbox")]
		public IEnumerable<Activity> ActivitypointerSendermailboxidMailbox
		{
			get { return GetRelatedEntities<Activity>("activitypointer_sendermailboxid_mailbox", null); }
			set { SetRelatedEntities("activitypointer_sendermailboxid_mailbox", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'bulkoperation_mailbox_sendermailboxid'
        /// </summary>
		[RelationshipSchemaName("bulkoperation_mailbox_sendermailboxid")]
		public IEnumerable<QuickCampaign> BulkoperationMailboxSendermailboxid
		{
			get { return GetRelatedEntities<QuickCampaign>("bulkoperation_mailbox_sendermailboxid", null); }
			set { SetRelatedEntities("bulkoperation_mailbox_sendermailboxid", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'campaignactivity_mailbox_sendermailboxid'
        /// </summary>
		[RelationshipSchemaName("campaignactivity_mailbox_sendermailboxid")]
		public IEnumerable<CampaignActivity> CampaignactivityMailboxSendermailboxid
		{
			get { return GetRelatedEntities<CampaignActivity>("campaignactivity_mailbox_sendermailboxid", null); }
			set { SetRelatedEntities("campaignactivity_mailbox_sendermailboxid", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'campaignresponse_mailbox_sendermailboxid'
        /// </summary>
		[RelationshipSchemaName("campaignresponse_mailbox_sendermailboxid")]
		public IEnumerable<CampaignResponse> CampaignresponseMailboxSendermailboxid
		{
			get { return GetRelatedEntities<CampaignResponse>("campaignresponse_mailbox_sendermailboxid", null); }
			set { SetRelatedEntities("campaignresponse_mailbox_sendermailboxid", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'email_sendermailboxid_mailbox'
        /// </summary>
		[RelationshipSchemaName("email_sendermailboxid_mailbox")]
		public IEnumerable<Email> EmailSendermailboxidMailbox
		{
			get { return GetRelatedEntities<Email>("email_sendermailboxid_mailbox", null); }
			set { SetRelatedEntities("email_sendermailboxid_mailbox", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'incidentresolution_mailbox_sendermailboxid'
        /// </summary>
		[RelationshipSchemaName("incidentresolution_mailbox_sendermailboxid")]
		public IEnumerable<CaseResolution> IncidentresolutionMailboxSendermailboxid
		{
			get { return GetRelatedEntities<CaseResolution>("incidentresolution_mailbox_sendermailboxid", null); }
			set { SetRelatedEntities("incidentresolution_mailbox_sendermailboxid", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'Mailbox_Annotation'
        /// </summary>
		[RelationshipSchemaName("Mailbox_Annotation")]
		public IEnumerable<Note> MailboxAnnotation
		{
			get { return GetRelatedEntities<Note>("Mailbox_Annotation", null); }
			set { SetRelatedEntities("Mailbox_Annotation", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'mailbox_asyncoperations'
        /// </summary>
		[RelationshipSchemaName("mailbox_asyncoperations")]
		public IEnumerable<SystemJob> MailboxAsyncoperations
		{
			get { return GetRelatedEntities<SystemJob>("mailbox_asyncoperations", null); }
			set { SetRelatedEntities("mailbox_asyncoperations", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'mailbox_FileAttachments'
        /// </summary>
		[RelationshipSchemaName("mailbox_FileAttachments")]
		public IEnumerable<FileAttachment> MailboxFileAttachments
		{
			get { return GetRelatedEntities<FileAttachment>("mailbox_FileAttachments", null); }
			set { SetRelatedEntities("mailbox_FileAttachments", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'Mailbox_MailboxTrackingFolder'
        /// </summary>
		[RelationshipSchemaName("Mailbox_MailboxTrackingFolder")]
		public IEnumerable<MailboxAutoTrackingFolder> MailboxMailboxTrackingFolder
		{
			get { return GetRelatedEntities<MailboxAutoTrackingFolder>("Mailbox_MailboxTrackingFolder", null); }
			set { SetRelatedEntities("Mailbox_MailboxTrackingFolder", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'mailbox_processsessions'
        /// </summary>
		[RelationshipSchemaName("mailbox_processsessions")]
		public IEnumerable<ProcessSession> MailboxProcesssessions
		{
			get { return GetRelatedEntities<ProcessSession>("mailbox_processsessions", null); }
			set { SetRelatedEntities("mailbox_processsessions", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'Mailbox_SyncErrors'
        /// </summary>
		[RelationshipSchemaName("Mailbox_SyncErrors")]
		public IEnumerable<SyncError> MailboxSyncErrors
		{
			get { return GetRelatedEntities<SyncError>("Mailbox_SyncErrors", null); }
			set { SetRelatedEntities("Mailbox_SyncErrors", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'opportunityclose_mailbox_sendermailboxid'
        /// </summary>
		[RelationshipSchemaName("opportunityclose_mailbox_sendermailboxid")]
		public IEnumerable<OpportunityClose> OpportunitycloseMailboxSendermailboxid
		{
			get { return GetRelatedEntities<OpportunityClose>("opportunityclose_mailbox_sendermailboxid", null); }
			set { SetRelatedEntities("opportunityclose_mailbox_sendermailboxid", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'orderclose_mailbox_sendermailboxid'
        /// </summary>
		[RelationshipSchemaName("orderclose_mailbox_sendermailboxid")]
		public IEnumerable<OrderClose> OrdercloseMailboxSendermailboxid
		{
			get { return GetRelatedEntities<OrderClose>("orderclose_mailbox_sendermailboxid", null); }
			set { SetRelatedEntities("orderclose_mailbox_sendermailboxid", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'queue_defaultmailbox_mailbox'
        /// </summary>
		[RelationshipSchemaName("queue_defaultmailbox_mailbox")]
		public IEnumerable<Queue> QueueDefaultmailboxMailbox
		{
			get { return GetRelatedEntities<Queue>("queue_defaultmailbox_mailbox", null); }
			set { SetRelatedEntities("queue_defaultmailbox_mailbox", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'quoteclose_mailbox_sendermailboxid'
        /// </summary>
		[RelationshipSchemaName("quoteclose_mailbox_sendermailboxid")]
		public IEnumerable<QuoteClose> QuotecloseMailboxSendermailboxid
		{
			get { return GetRelatedEntities<QuoteClose>("quoteclose_mailbox_sendermailboxid", null); }
			set { SetRelatedEntities("quoteclose_mailbox_sendermailboxid", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'serviceappointment_mailbox_sendermailboxid'
        /// </summary>
		[RelationshipSchemaName("serviceappointment_mailbox_sendermailboxid")]
		public IEnumerable<ServiceActivity> ServiceappointmentMailboxSendermailboxid
		{
			get { return GetRelatedEntities<ServiceActivity>("serviceappointment_mailbox_sendermailboxid", null); }
			set { SetRelatedEntities("serviceappointment_mailbox_sendermailboxid", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'systemuser_defaultmailbox_mailbox'
        /// </summary>
		[RelationshipSchemaName("systemuser_defaultmailbox_mailbox")]
		public IEnumerable<User> SystemuserDefaultmailboxMailbox
		{
			get { return GetRelatedEntities<User>("systemuser_defaultmailbox_mailbox", null); }
			set { SetRelatedEntities("systemuser_defaultmailbox_mailbox", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'tracelog_Mailbox'
        /// </summary>
		[RelationshipSchemaName("tracelog_Mailbox")]
		public IEnumerable<Trace> TracelogMailbox
		{
			get { return GetRelatedEntities<Trace>("tracelog_Mailbox", null); }
			set { SetRelatedEntities("tracelog_Mailbox", null, value); }
		}
		#endregion

		#region Actions
		#endregion

		#region OptionSetEnums
		public enum eAppointmentsContactsAndTasks
		{	
		
			[Label("Microsoft Dynamics 365 for Outlook")]
			[Description(@"")]
			MicrosoftDynamics365ForOutlook = 0, 
		
			[Label("Server-Side Synchronization")]
			[Description(@"")]
			ServerSideSynchronization = 1, 
		
			[Label("None")]
			[Description(@"")]
			None = 2, 
		}
		
		public enum eAppointmentsContactsAndTasksStatus
		{	
		
			[Label("Not Run")]
			[Description(@"")]
			NotRun = 0, 
		
			[Label("Success")]
			[Description(@"")]
			Success = 1, 
		
			[Label("Failure")]
			[Description(@"")]
			Failure = 2, 
		}
		
		public enum eShowsWhetherTheEmailAddressIsApprovedForEachMailboxForProcessingEmailThroughServersideSynchronizationOrTheEmailRouter
		{	
		
			[Label("Empty")]
			[Description(@"")]
			Empty = 0, 
		
			[Label("Approved")]
			[Description(@"")]
			Approved = 1, 
		
			[Label("Pending Approval")]
			[Description(@"")]
			PendingApproval = 2, 
		
			[Label("Rejected")]
			[Description(@"")]
			Rejected = 3, 
		}
		
		public enum eExchangeContactsImportDeploymentStatus
		{	
		
			[Label("NotImported")]
			[Description(@"")]
			NotImported = 0, 
		
			[Label("Imported")]
			[Description(@"")]
			Imported = 1, 
		
			[Label("ImportFailed")]
			[Description(@"")]
			ImportFailed = 2, 
		}
		
		public enum eIncomingEmailDeliveryMethod
		{	
		
			[Label("None")]
			[Description(@"")]
			None = 0, 
		
			[Label("Microsoft Dynamics 365 for Outlook")]
			[Description(@"")]
			MicrosoftDynamics365ForOutlook = 1, 
		
			[Label("Server-Side Synchronization or Email Router")]
			[Description(@"")]
			ServerSideSynchronizationOrEmailRouter = 2, 
		
			[Label("Forward Mailbox")]
			[Description(@"")]
			ForwardMailbox = 3, 
		}
		
		public enum eIncomingEmailStatus
		{	
		
			[Label("Not Run")]
			[Description(@"")]
			NotRun = 0, 
		
			[Label("Success")]
			[Description(@"")]
			Success = 1, 
		
			[Label("Failure")]
			[Description(@"")]
			Failure = 2, 
		}
		
		public enum eOfficeAppsDeploymentType
		{	
		
			[Label("NotInstalled")]
			[Description(@"")]
			NotInstalled = 0, 
		
			[Label("Installed")]
			[Description(@"")]
			Installed = 1, 
		
			[Label("InstallFailed")]
			[Description(@"")]
			InstallFailed = 2, 
		
			[Label("UninstallFailed")]
			[Description(@"")]
			UninstallFailed = 3, 
		
			[Label("UpgradeRequired")]
			[Description(@"")]
			UpgradeRequired = 4, 
		}
		
		public enum eOutgoingEmailDeliveryMethod
		{	
		
			[Label("None")]
			[Description(@"")]
			None = 0, 
		
			[Label("Microsoft Dynamics 365 for Outlook")]
			[Description(@"")]
			MicrosoftDynamics365ForOutlook = 1, 
		
			[Label("Server-Side Synchronization or Email Router")]
			[Description(@"")]
			ServerSideSynchronizationOrEmailRouter = 2, 
		}
		
		public enum eOutgoingEmailStatus
		{	
		
			[Label("Not Run")]
			[Description(@"")]
			NotRun = 0, 
		
			[Label("Success")]
			[Description(@"")]
			Success = 1, 
		
			[Label("Failure")]
			[Description(@"")]
			Failure = 2, 
		}
		
		public enum eStatus
		{	
		
			[Label("Active")]
			[Description(@"")]
			Active = 0, 
		
			[Label("Inactive")]
			[Description(@"")]
			Inactive = 1, 
		}
		
		public enum eMailboxStatus
		{	
		
			[Label("Not Run")]
			[Description(@"")]
			NotRun = 0, 
		
			[Label("Success")]
			[Description(@"")]
			Success = 1, 
		
			[Label("Failure")]
			[Description(@"")]
			Failure = 2, 
		}
		
		public enum eStatusReason
		{	
		
			[Label("Active")]
			[Description(@"")]
			Active_Active = 1, 
		
			[Label("Inactive")]
			[Description(@"")]
			Inactive_Inactive = 2, 
		}
		
		#endregion	

		#region Properties
		public static class Properties 
		{
			/// <summary>actdeliverymethod</summary>
			public const string AppointmentsContactsAndTasks = "actdeliverymethod";

			/// <summary>actstatus</summary>
			public const string AppointmentsContactsAndTasksStatus = "actstatus";

			/// <summary>allowemailconnectortousecredentials</summary>
			public const string AllowToUseCredentialsForEmailProcessing = "allowemailconnectortousecredentials";

			/// <summary>averagetotalduration</summary>
			public const string MonitorTotalPerformance = "averagetotalduration";

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

			/// <summary>emailaddress</summary>
			public const string EmailAddress = "emailaddress";

			/// <summary>emailrouteraccessapproval</summary>
			public const string EmailAddressStatus = "emailrouteraccessapproval";

			/// <summary>emailserverprofile</summary>
			public const string ServerProfile = "emailserverprofile";

			/// <summary>emailserverprofilename</summary>
			public const string Emailserverprofilename = "emailserverprofilename";

			/// <summary>enabledforact</summary>
			public const string EnabledForAppointmentsContactsAndTasks = "enabledforact";

			/// <summary>enabledforincomingemail</summary>
			public const string EnabledForIncomingEmail = "enabledforincomingemail";

			/// <summary>enabledforoutgoingemail</summary>
			public const string EnabledForOutgoingEmail = "enabledforoutgoingemail";

			/// <summary>entityimage_timestamp</summary>
			public const string EntityimageTimestamp = "entityimage_timestamp";

			/// <summary>entityimage_url</summary>
			public const string EntityimageUrl = "entityimage_url";

			/// <summary>entityimageid</summary>
			public const string EntityImageId = "entityimageid";

			/// <summary>ewsurl</summary>
			public const string ExchangeWebServicesURL = "ewsurl";

			/// <summary>exchangecontactsimportcompletedon</summary>
			public const string ExchangeContactsImportCompletedOn = "exchangecontactsimportcompletedon";

			/// <summary>exchangecontactsimportstatus</summary>
			public const string ExchangeContactsImportStatus = "exchangecontactsimportstatus";

			/// <summary>exchangesyncstatexml</summary>
			public const string ExchangeSyncState = "exchangesyncstatexml";

			/// <summary>exchangesyncstatexmlfileref_name</summary>
			public const string ExchangesyncstatexmlfilerefName = "exchangesyncstatexmlfileref_name";

			/// <summary>folderhierarchy</summary>
			public const string FolderHierarchy = "folderhierarchy";

			/// <summary>forcedunlockcount</summary>
			public const string CountOfTheNumberOfTimesAMailboxGetsForcedUnlocked = "forcedunlockcount";

			/// <summary>hostid</summary>
			public const string Host = "hostid";

			/// <summary>incomingemaildeliverymethod</summary>
			public const string IncomingEmail = "incomingemaildeliverymethod";

			/// <summary>incomingemailstatus</summary>
			public const string IncomingEmailStatus = "incomingemailstatus";

			/// <summary>isactsyncorgflagset</summary>
			public const string SetCurrentOrganizationAsSynchronizationOrganization = "isactsyncorgflagset";

			/// <summary>isemailaddressapprovedbyo365admin</summary>
			public const string EmailAddressO365AdminApprovalStatus = "isemailaddressapprovedbyo365admin";

			/// <summary>isexchangecontactsimportscheduled</summary>
			public const string IsExchangeContactsImportScheduled = "isexchangecontactsimportscheduled";

			/// <summary>isforwardmailbox</summary>
			public const string IsForwardMailbox = "isforwardmailbox";

			/// <summary>isoauthaccesstokenset</summary>
			public const string Isoauthaccesstokenset = "isoauthaccesstokenset";

			/// <summary>isoauthrefreshtokenset</summary>
			public const string Isoauthrefreshtokenset = "isoauthrefreshtokenset";

			/// <summary>ispasswordset</summary>
			public const string Ispasswordset = "ispasswordset";

			/// <summary>isserviceaccount</summary>
			public const string IsServiceAccount = "isserviceaccount";

			/// <summary>itemsfailedforlastsync</summary>
			public const string ItemsFailedForLastSync = "itemsfailedforlastsync";

			/// <summary>itemsprocessedforlastsync</summary>
			public const string ItemsProcessedForLastSync = "itemsprocessedforlastsync";

			/// <summary>lastactiveon</summary>
			public const string LastActiveOn = "lastactiveon";

			/// <summary>lastautodiscoveredon</summary>
			public const string LastAutoDiscoveredOn = "lastautodiscoveredon";

			/// <summary>lastduration</summary>
			public const string MonitorLastDurationPerformance = "lastduration";

			/// <summary>lastmailboxforcedunlockoccurredon</summary>
			public const string LastDateTimeWhenAMailboxGotForcedUnlocked = "lastmailboxforcedunlockoccurredon";

			/// <summary>lastmessageid</summary>
			public const string LastMessageID = "lastmessageid";

			/// <summary>lastsuccessfulsynccompletedon</summary>
			public const string LastSuccessfulSyncTime = "lastsuccessfulsynccompletedon";

			/// <summary>lastsyncerror</summary>
			public const string LastSyncErrorStack = "lastsyncerror";

			/// <summary>lastsyncerrorcode</summary>
			public const string LastSyncErrorCode = "lastsyncerrorcode";

			/// <summary>lastsyncerrorcount</summary>
			public const string LastSyncErrorContinuousCount = "lastsyncerrorcount";

			/// <summary>lastsyncerrormachinename</summary>
			public const string LastSyncErrorMachineName = "lastsyncerrormachinename";

			/// <summary>lastsyncerroroccurredon</summary>
			public const string LastSyncErrorTime = "lastsyncerroroccurredon";

			/// <summary>lastsyncstartedon</summary>
			public const string LastSyncStartTime = "lastsyncstartedon";

			/// <summary>mailboxid</summary>
			public const string MailboxId = "mailboxid";

			/// <summary>mailboxprocessingcontext</summary>
			public const string ProcessingContextOfTheMailbox = "mailboxprocessingcontext";

			/// <summary>mailboxstatus</summary>
			public const string MailboxStatus = "mailboxstatus";

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

			/// <summary>name</summary>
			public const string Name = "name";

			/// <summary>noactcount</summary>
			public const string ZeroAppointmentContactTaskCountForMailbox = "noactcount";

			/// <summary>noemailcount</summary>
			public const string ZeroEmailCountForMailbox = "noemailcount";

			/// <summary>oauthaccesstoken</summary>
			public const string OauthAccessToken = "oauthaccesstoken";

			/// <summary>oauthrefreshtoken</summary>
			public const string OauthRefreshToken = "oauthrefreshtoken";

			/// <summary>oauthtokenexpireson</summary>
			public const string OauthTokenExpirationDatetime = "oauthtokenexpireson";

			/// <summary>officeappsdeploymentcompleteon</summary>
			public const string OfficeAppsDeploymentCompletedOn = "officeappsdeploymentcompleteon";

			/// <summary>officeappsdeploymenterror</summary>
			public const string OfficeAppsDeploymentError = "officeappsdeploymenterror";

			/// <summary>officeappsdeploymentscheduled</summary>
			public const string OfficeAppsDeploymentScheduled = "officeappsdeploymentscheduled";

			/// <summary>officeappsdeploymentstatus</summary>
			public const string OfficeAppsDeploymentType = "officeappsdeploymentstatus";

			/// <summary>organizationid</summary>
			public const string Organization = "organizationid";

			/// <summary>organizationidname</summary>
			public const string Organizationidname = "organizationidname";

			/// <summary>orgmarkedasprimaryforexchangesync</summary>
			public const string CrmOrgMarkedAsPrimaryOrgForExchangeMailbox = "orgmarkedasprimaryforexchangesync";

			/// <summary>outgoingemaildeliverymethod</summary>
			public const string OutgoingEmail = "outgoingemaildeliverymethod";

			/// <summary>outgoingemailstatus</summary>
			public const string OutgoingEmailStatus = "outgoingemailstatus";

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

			/// <summary>password</summary>
			public const string Password = "password";

			/// <summary>postponemailboxprocessinguntil</summary>
			public const string PostponeMailboxProcessingUntil = "postponemailboxprocessinguntil";

			/// <summary>postponeofficeappsdeploymentuntil</summary>
			public const string PostponeOutlookMailAppInstallUntil = "postponeofficeappsdeploymentuntil";

			/// <summary>postponesendinguntil</summary>
			public const string PostponeSendingUntil = "postponesendinguntil";

			/// <summary>postponetestemailconfigurationuntil</summary>
			public const string PostponeTestEmailConfigurationUntil = "postponetestemailconfigurationuntil";

			/// <summary>processanddeleteemails</summary>
			public const string DeleteEmailsAfterProcessing = "processanddeleteemails";

			/// <summary>processedtimes</summary>
			public const string MonitorPerformance = "processedtimes";

			/// <summary>processemailreceivedafter</summary>
			public const string ProcessEmailReceivedAfter = "processemailreceivedafter";

			/// <summary>processinglastattemptedon</summary>
			public const string DateProcessingLastAttempted = "processinglastattemptedon";

			/// <summary>processingstatecode</summary>
			public const string MailboxProcessingState = "processingstatecode";

			/// <summary>receivingpostponeduntil</summary>
			public const string PostponeReceivingEmailsForTheMailboxUntilTheSpecifiedDataAndTime = "receivingpostponeduntil";

			/// <summary>receivingpostponeduntilforact</summary>
			public const string PostponeProcessingAppointmentsContactsAndTasksForTheMailboxUntilTheSpecifiedDataAndTime = "receivingpostponeduntilforact";

			/// <summary>regardingobjectid</summary>
			public const string Regarding = "regardingobjectid";

			/// <summary>regardingobjectidname</summary>
			public const string RegardingName = "regardingobjectidname";

			/// <summary>regardingobjecttypecode</summary>
			public const string RegardingObjectTypeCode = "regardingobjecttypecode";

			/// <summary>statecode</summary>
			public const string Status = "statecode";

			/// <summary>statuscode</summary>
			public const string StatusReason = "statuscode";

			/// <summary>testemailconfigurationretrycount</summary>
			public const string TestEmailConfigurationRetryCount = "testemailconfigurationretrycount";

			/// <summary>testemailconfigurationscheduled</summary>
			public const string TestEmailConfigurationScheduled = "testemailconfigurationscheduled";

			/// <summary>testmailboxaccesscompletedon</summary>
			public const string MailboxTestCompletedOn = "testmailboxaccesscompletedon";

			/// <summary>timezoneruleversionnumber</summary>
			public const string TimeZoneRuleVersionNumber = "timezoneruleversionnumber";

			/// <summary>transientfailurecount</summary>
			public const string TransientFailureCount = "transientfailurecount";

			/// <summary>undeliverablefolder</summary>
			public const string UndeliverableFolder = "undeliverablefolder";

			/// <summary>username</summary>
			public const string UserName = "username";

			/// <summary>utcconversiontimezonecode</summary>
			public const string UTCConversionTimeZoneCode = "utcconversiontimezonecode";

			/// <summary>verboseloggingenabled</summary>
			public const string VerboseLogging = "verboseloggingenabled";

			/// <summary>versionnumber</summary>
			public const string VersionNumber = "versionnumber";

		}
		#endregion

		#region Schemas
		public static class Schemas 
		{
			/// <summary>1:N activitypointer_sendermailboxid_mailbox</summary>
			public const string ActivitypointerSendermailboxidMailbox = "activitypointer_sendermailboxid_mailbox";

			/// <summary>1:N bulkoperation_mailbox_sendermailboxid</summary>
			public const string BulkoperationMailboxSendermailboxid = "bulkoperation_mailbox_sendermailboxid";

			/// <summary>1:N campaignactivity_mailbox_sendermailboxid</summary>
			public const string CampaignactivityMailboxSendermailboxid = "campaignactivity_mailbox_sendermailboxid";

			/// <summary>1:N campaignresponse_mailbox_sendermailboxid</summary>
			public const string CampaignresponseMailboxSendermailboxid = "campaignresponse_mailbox_sendermailboxid";

			/// <summary>1:N email_sendermailboxid_mailbox</summary>
			public const string EmailSendermailboxidMailbox = "email_sendermailboxid_mailbox";

			/// <summary>1:N incidentresolution_mailbox_sendermailboxid</summary>
			public const string IncidentresolutionMailboxSendermailboxid = "incidentresolution_mailbox_sendermailboxid";

			/// <summary>1:N Mailbox_Annotation</summary>
			public const string MailboxAnnotation = "Mailbox_Annotation";

			/// <summary>1:N mailbox_asyncoperations</summary>
			public const string MailboxAsyncoperations = "mailbox_asyncoperations";

			/// <summary>1:N mailbox_FileAttachments</summary>
			public const string MailboxFileAttachments = "mailbox_FileAttachments";

			/// <summary>1:N Mailbox_MailboxTrackingFolder</summary>
			public const string MailboxMailboxTrackingFolder = "Mailbox_MailboxTrackingFolder";

			/// <summary>1:N mailbox_processsessions</summary>
			public const string MailboxProcesssessions = "mailbox_processsessions";

			/// <summary>1:N Mailbox_SyncErrors</summary>
			public const string MailboxSyncErrors = "Mailbox_SyncErrors";

			/// <summary>1:N opportunityclose_mailbox_sendermailboxid</summary>
			public const string OpportunitycloseMailboxSendermailboxid = "opportunityclose_mailbox_sendermailboxid";

			/// <summary>1:N orderclose_mailbox_sendermailboxid</summary>
			public const string OrdercloseMailboxSendermailboxid = "orderclose_mailbox_sendermailboxid";

			/// <summary>1:N queue_defaultmailbox_mailbox</summary>
			public const string QueueDefaultmailboxMailbox = "queue_defaultmailbox_mailbox";

			/// <summary>1:N quoteclose_mailbox_sendermailboxid</summary>
			public const string QuotecloseMailboxSendermailboxid = "quoteclose_mailbox_sendermailboxid";

			/// <summary>1:N serviceappointment_mailbox_sendermailboxid</summary>
			public const string ServiceappointmentMailboxSendermailboxid = "serviceappointment_mailbox_sendermailboxid";

			/// <summary>1:N systemuser_defaultmailbox_mailbox</summary>
			public const string SystemuserDefaultmailboxMailbox = "systemuser_defaultmailbox_mailbox";

			/// <summary>1:N tracelog_Mailbox</summary>
			public const string TracelogMailbox = "tracelog_Mailbox";

		}
		#endregion
	}
}

