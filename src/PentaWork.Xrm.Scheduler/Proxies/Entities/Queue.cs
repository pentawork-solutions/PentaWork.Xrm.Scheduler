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
	[EntityLogicalName("queue")]
	public sealed class Queue : Entity
	{	
		public static readonly int? EntityTypeCode = 2020;
		public new const string LogicalName = "queue";
		public const string PrimaryIdAttribute = "queueid";
		public const string PrimaryNameAttribute = "name";
	
		public Queue() : base("queue") { }

		#region Attributes
		/// <summary>
        /// allowemailcredentials
        /// </summary>
		[DisplayName("Allow to Use Credentials for Email Processing (Obsolete)")]
		[AttributeLogicalName("allowemailcredentials")]
		public bool? AllowToUseCredentialsForEmailProcessingObsolete
		{	
			get { return GetAttributeValue<bool?>("allowemailcredentials"); }
			set
			{ 
				if(value == AllowToUseCredentialsForEmailProcessingObsolete) return;
				SetAttributeValue("allowemailcredentials", value);
			}
		}	
			
		/// <summary>
        /// businessunitid
        /// </summary>
		[DisplayName("Business Unit")]
		[AttributeLogicalName("businessunitid")]
		public EntityReference BusinessUnit
		{	
			get { return GetAttributeValue<EntityReference>("businessunitid"); }
			set
			{ 
				if(value == BusinessUnit) return;
				SetAttributeValue("businessunitid", value);
			}
		}	
			
		/// <summary>
        /// businessunitidname
        /// </summary>
		[DisplayName("businessunitidname")]
		[AttributeLogicalName("businessunitidname")]
		public string Businessunitidname
		{	
			get { return GetAttributeValue<string>("businessunitidname"); }
			set
			{ 
				if(value == Businessunitidname) return;
				SetAttributeValue("businessunitidname", value);
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
        /// defaultmailbox
        /// </summary>
		[DisplayName("Mailbox")]
		[AttributeLogicalName("defaultmailbox")]
		public EntityReference Mailbox
		{	
			get { return GetAttributeValue<EntityReference>("defaultmailbox"); }
			set
			{ 
				if(value == Mailbox) return;
				SetAttributeValue("defaultmailbox", value);
			}
		}	
			
		/// <summary>
        /// defaultmailboxname
        /// </summary>
		[DisplayName("defaultmailboxname")]
		[AttributeLogicalName("defaultmailboxname")]
		public string Defaultmailboxname
		{	
			get { return GetAttributeValue<string>("defaultmailboxname"); }
			set
			{ 
				if(value == Defaultmailboxname) return;
				SetAttributeValue("defaultmailboxname", value);
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
		[DisplayName("Incoming Email")]
		[AttributeLogicalName("emailaddress")]
		public string IncomingEmail
		{	
			get { return GetAttributeValue<string>("emailaddress"); }
			set
			{ 
				if(value == IncomingEmail) return;
				SetAttributeValue("emailaddress", value);
			}
		}	
			
		/// <summary>
        /// emailpassword
        /// </summary>
		[DisplayName("Password (Obsolete)")]
		[AttributeLogicalName("emailpassword")]
		public string PasswordObsolete
		{	
			get { return GetAttributeValue<string>("emailpassword"); }
			set
			{ 
				if(value == PasswordObsolete) return;
				SetAttributeValue("emailpassword", value);
			}
		}	
			
		/// <summary>
        /// emailrouteraccessapproval
        /// </summary>
		[DisplayName("Primary Email Status")]
		[AttributeLogicalName("emailrouteraccessapproval")]
		public eShowsWhetherTheEmailAddressIsApprovedForEachMailboxForProcessingEmailThroughServersideSynchronizationOrTheEmailRouter? PrimaryEmailStatus
		{	
			get 
			{ 
				var optionSetValue = GetAttributeValue<OptionSetValue>("emailrouteraccessapproval");
				if (optionSetValue != null) return (eShowsWhetherTheEmailAddressIsApprovedForEachMailboxForProcessingEmailThroughServersideSynchronizationOrTheEmailRouter)optionSetValue.Value;
				else return null;
			}
			set 
			{ 
				if(value == PrimaryEmailStatus) return;

				OptionSetValue optionSetValue = null;
				if(value != null) optionSetValue = new OptionSetValue((int)value);
				SetAttributeValue("emailrouteraccessapproval", optionSetValue); 
			}
		}

		/// <summary>
        /// emailusername
        /// </summary>
		[DisplayName("User Name (Obsolete)")]
		[AttributeLogicalName("emailusername")]
		public string UserNameObsolete
		{	
			get { return GetAttributeValue<string>("emailusername"); }
			set
			{ 
				if(value == UserNameObsolete) return;
				SetAttributeValue("emailusername", value);
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
        /// ignoreunsolicitedemail
        /// </summary>
		[DisplayName("Convert To Email Activities")]
		[AttributeLogicalName("ignoreunsolicitedemail")]
		public bool? ConvertToEmailActivities
		{	
			get { return GetAttributeValue<bool?>("ignoreunsolicitedemail"); }
			set
			{ 
				if(value == ConvertToEmailActivities) return;
				SetAttributeValue("ignoreunsolicitedemail", value);
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
        /// incomingemaildeliverymethod
        /// </summary>
		[DisplayName("Incoming Email Delivery Method")]
		[AttributeLogicalName("incomingemaildeliverymethod")]
		public eIncomingEmailDeliveryMethod? IncomingEmailDeliveryMethod
		{	
			get 
			{ 
				var optionSetValue = GetAttributeValue<OptionSetValue>("incomingemaildeliverymethod");
				if (optionSetValue != null) return (eIncomingEmailDeliveryMethod)optionSetValue.Value;
				else return null;
			}
			set 
			{ 
				if(value == IncomingEmailDeliveryMethod) return;

				OptionSetValue optionSetValue = null;
				if(value != null) optionSetValue = new OptionSetValue((int)value);
				SetAttributeValue("incomingemaildeliverymethod", optionSetValue); 
			}
		}

		/// <summary>
        /// incomingemailfilteringmethod
        /// </summary>
		[DisplayName("Convert Incoming Email To Activities")]
		[AttributeLogicalName("incomingemailfilteringmethod")]
		public eIncomingEmailFilteringMethod? ConvertIncomingEmailToActivities
		{	
			get 
			{ 
				var optionSetValue = GetAttributeValue<OptionSetValue>("incomingemailfilteringmethod");
				if (optionSetValue != null) return (eIncomingEmailFilteringMethod)optionSetValue.Value;
				else return null;
			}
			set 
			{ 
				if(value == ConvertIncomingEmailToActivities) return;

				OptionSetValue optionSetValue = null;
				if(value != null) optionSetValue = new OptionSetValue((int)value);
				SetAttributeValue("incomingemailfilteringmethod", optionSetValue); 
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
        /// isfaxqueue
        /// </summary>
		[DisplayName("Fax Queue")]
		[AttributeLogicalName("isfaxqueue")]
		public bool? FaxQueue
		{	
			get { return GetAttributeValue<bool?>("isfaxqueue"); }
			set
			{ 
				if(value == FaxQueue) return;
				SetAttributeValue("isfaxqueue", value);
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
        /// numberofitems
        /// </summary>
		[DisplayName("Queue Items")]
		[AttributeLogicalName("numberofitems")]
		public int? QueueItems
		{	
			get { return GetAttributeValue<int?>("numberofitems"); }
			set
			{ 
				if(value == QueueItems) return;
				SetAttributeValue("numberofitems", value);
			}
		}	
			
		/// <summary>
        /// numberofmembers
        /// </summary>
		[DisplayName("No. of Members")]
		[AttributeLogicalName("numberofmembers")]
		public int? NoOfMembers
		{	
			get { return GetAttributeValue<int?>("numberofmembers"); }
			set
			{ 
				if(value == NoOfMembers) return;
				SetAttributeValue("numberofmembers", value);
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
        /// outgoingemaildeliverymethod
        /// </summary>
		[DisplayName("Outgoing Email Delivery Method")]
		[AttributeLogicalName("outgoingemaildeliverymethod")]
		public eOutgoingEmailDeliveryMethod? OutgoingEmailDeliveryMethod
		{	
			get 
			{ 
				var optionSetValue = GetAttributeValue<OptionSetValue>("outgoingemaildeliverymethod");
				if (optionSetValue != null) return (eOutgoingEmailDeliveryMethod)optionSetValue.Value;
				else return null;
			}
			set 
			{ 
				if(value == OutgoingEmailDeliveryMethod) return;

				OptionSetValue optionSetValue = null;
				if(value != null) optionSetValue = new OptionSetValue((int)value);
				SetAttributeValue("outgoingemaildeliverymethod", optionSetValue); 
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
        /// primaryuserid
        /// </summary>
		[DisplayName("Owner (deprecated)")]
		[AttributeLogicalName("primaryuserid")]
		public EntityReference Ownerdeprecated
		{	
			get { return GetAttributeValue<EntityReference>("primaryuserid"); }
			set
			{ 
				if(value == Ownerdeprecated) return;
				SetAttributeValue("primaryuserid", value);
			}
		}	
			
		/// <summary>
        /// primaryuseridname
        /// </summary>
		[DisplayName("primaryuseridname")]
		[AttributeLogicalName("primaryuseridname")]
		public string Primaryuseridname
		{	
			get { return GetAttributeValue<string>("primaryuseridname"); }
			set
			{ 
				if(value == Primaryuseridname) return;
				SetAttributeValue("primaryuseridname", value);
			}
		}	
			
		/// <summary>
        /// primaryuseridyominame
        /// </summary>
		[DisplayName("primaryuseridyominame")]
		[AttributeLogicalName("primaryuseridyominame")]
		public string Primaryuseridyominame
		{	
			get { return GetAttributeValue<string>("primaryuseridyominame"); }
			set
			{ 
				if(value == Primaryuseridyominame) return;
				SetAttributeValue("primaryuseridyominame", value);
			}
		}	
			
		/// <summary>
        /// queueid
        /// </summary>
		[DisplayName("Queue")]
		[AttributeLogicalName("queueid")]
		public override Guid Id
		{
			get => base.Id;
			set { base.Id = value; SetAttributeValue("queueid", value); }
		}

							/// <summary>
        /// queuetypecode
        /// </summary>
		[DisplayName("Queue Type")]
		[AttributeLogicalName("queuetypecode")]
		public eQueueType? QueueType
		{	
			get 
			{ 
				var optionSetValue = GetAttributeValue<OptionSetValue>("queuetypecode");
				if (optionSetValue != null) return (eQueueType)optionSetValue.Value;
				else return null;
			}
			set 
			{ 
				if(value == QueueType) return;

				OptionSetValue optionSetValue = null;
				if(value != null) optionSetValue = new OptionSetValue((int)value);
				SetAttributeValue("queuetypecode", optionSetValue); 
			}
		}

		/// <summary>
        /// queueviewtype
        /// </summary>
		[DisplayName("Type")]
		[AttributeLogicalName("queueviewtype")]
		public eType? Type
		{	
			get 
			{ 
				var optionSetValue = GetAttributeValue<OptionSetValue>("queueviewtype");
				if (optionSetValue != null) return (eType)optionSetValue.Value;
				else return null;
			}
			set 
			{ 
				if(value == Type) return;

				OptionSetValue optionSetValue = null;
				if(value != null) optionSetValue = new OptionSetValue((int)value);
				SetAttributeValue("queueviewtype", optionSetValue); 
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
        /// 1:N Get entities for 'mailbox_regarding_queue'
        /// </summary>
		[RelationshipSchemaName("mailbox_regarding_queue")]
		public IEnumerable<Mailbox> MailboxRegardingQueue
		{
			get { return GetRelatedEntities<Mailbox>("mailbox_regarding_queue", null); }
			set { SetRelatedEntities("mailbox_regarding_queue", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'queue_activity_parties'
        /// </summary>
		[RelationshipSchemaName("queue_activity_parties")]
		public IEnumerable<ActivityParty> QueueActivityParties
		{
			get { return GetRelatedEntities<ActivityParty>("queue_activity_parties", null); }
			set { SetRelatedEntities("queue_activity_parties", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'Queue_AsyncOperations'
        /// </summary>
		[RelationshipSchemaName("Queue_AsyncOperations")]
		public IEnumerable<SystemJob> QueueAsyncOperations
		{
			get { return GetRelatedEntities<SystemJob>("Queue_AsyncOperations", null); }
			set { SetRelatedEntities("Queue_AsyncOperations", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'Queue_BulkDeleteFailures'
        /// </summary>
		[RelationshipSchemaName("Queue_BulkDeleteFailures")]
		public IEnumerable<BulkDeleteFailure> QueueBulkDeleteFailures
		{
			get { return GetRelatedEntities<BulkDeleteFailure>("Queue_BulkDeleteFailures", null); }
			set { SetRelatedEntities("Queue_BulkDeleteFailures", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'Queue_DuplicateBaseRecord'
        /// </summary>
		[RelationshipSchemaName("Queue_DuplicateBaseRecord")]
		public IEnumerable<DuplicateRecord> QueueDuplicateBaseRecord
		{
			get { return GetRelatedEntities<DuplicateRecord>("Queue_DuplicateBaseRecord", null); }
			set { SetRelatedEntities("Queue_DuplicateBaseRecord", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'Queue_DuplicateMatchingRecord'
        /// </summary>
		[RelationshipSchemaName("Queue_DuplicateMatchingRecord")]
		public IEnumerable<DuplicateRecord> QueueDuplicateMatchingRecord
		{
			get { return GetRelatedEntities<DuplicateRecord>("Queue_DuplicateMatchingRecord", null); }
			set { SetRelatedEntities("Queue_DuplicateMatchingRecord", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'Queue_Email_EmailSender'
        /// </summary>
		[RelationshipSchemaName("Queue_Email_EmailSender")]
		public IEnumerable<Email> QueueEmailEmailSender
		{
			get { return GetRelatedEntities<Email>("Queue_Email_EmailSender", null); }
			set { SetRelatedEntities("Queue_Email_EmailSender", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'queue_entries'
        /// </summary>
		[RelationshipSchemaName("queue_entries")]
		public IEnumerable<QueueItem> QueueEntries
		{
			get { return GetRelatedEntities<QueueItem>("queue_entries", null); }
			set { SetRelatedEntities("queue_entries", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'queue_PostFollows'
        /// </summary>
		[RelationshipSchemaName("queue_PostFollows")]
		public IEnumerable<Follow> QueuePostFollows
		{
			get { return GetRelatedEntities<Follow>("queue_PostFollows", null); }
			set { SetRelatedEntities("queue_PostFollows", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'queue_principalobjectattributeaccess'
        /// </summary>
		[RelationshipSchemaName("queue_principalobjectattributeaccess")]
		public IEnumerable<FieldSharing> QueuePrincipalobjectattributeaccess
		{
			get { return GetRelatedEntities<FieldSharing>("queue_principalobjectattributeaccess", null); }
			set { SetRelatedEntities("queue_principalobjectattributeaccess", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'Queue_ProcessSessions'
        /// </summary>
		[RelationshipSchemaName("Queue_ProcessSessions")]
		public IEnumerable<ProcessSession> QueueProcessSessions
		{
			get { return GetRelatedEntities<ProcessSession>("Queue_ProcessSessions", null); }
			set { SetRelatedEntities("Queue_ProcessSessions", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'Queue_SyncErrors'
        /// </summary>
		[RelationshipSchemaName("Queue_SyncErrors")]
		public IEnumerable<SyncError> QueueSyncErrors
		{
			get { return GetRelatedEntities<SyncError>("Queue_SyncErrors", null); }
			set { SetRelatedEntities("Queue_SyncErrors", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'queue_system_user'
        /// </summary>
		[RelationshipSchemaName("queue_system_user")]
		public IEnumerable<User> QueueSystemUser
		{
			get { return GetRelatedEntities<User>("queue_system_user", null); }
			set { SetRelatedEntities("queue_system_user", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'queue_team'
        /// </summary>
		[RelationshipSchemaName("queue_team")]
		public IEnumerable<Team> QueueTeam
		{
			get { return GetRelatedEntities<Team>("queue_team", null); }
			set { SetRelatedEntities("queue_team", null, value); }
		}
		/// <summary>
        /// N:N Get entities for 'User'
        /// </summary>
		[RelationshipSchemaName("queuemembership_association")]
		public IEnumerable<User> QueuemembershipAssociation
		{
			get { return GetRelatedEntities<User>("queuemembership_association", null); }
			set { SetRelatedEntities("queuemembership_association", null, value); }
		}
		#endregion

		#region Actions
		#endregion

		#region OptionSetEnums
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
		
		public enum eIncomingEmailDeliveryMethod
		{	
		
			[Label("None")]
			[Description(@"")]
			None = 0, 
		
			[Label("Server-Side Synchronization or Email Router")]
			[Description(@"")]
			ServerSideSynchronizationOrEmailRouter = 2, 
		
			[Label("Forward Mailbox")]
			[Description(@"")]
			ForwardMailbox = 3, 
		}
		
		public enum eIncomingEmailFilteringMethod
		{	
		
			[Label("All email messages")]
			[Description(@"")]
			AllEmailMessages = 0, 
		
			[Label("Email messages in response to Dynamics 365 email")]
			[Description(@"")]
			EmailMessagesInResponseToDynamics365Email = 1, 
		
			[Label("Email messages from Dynamics 365 Leads, Contacts and Accounts")]
			[Description(@"")]
			EmailMessagesFromDynamics365LeadsContactsAndAccounts = 2, 
		
			[Label("Email messages from Dynamics 365 records that are email enabled")]
			[Description(@"")]
			EmailMessagesFromDynamics365RecordsThatAreEmailEnabled = 3, 
		
			[Label("No email messages")]
			[Description(@"")]
			NoEmailMessages = 4, 
		}
		
		public enum eOutgoingEmailDeliveryMethod
		{	
		
			[Label("None")]
			[Description(@"")]
			None = 0, 
		
			[Label("Server-Side Synchronization or Email Router")]
			[Description(@"")]
			ServerSideSynchronizationOrEmailRouter = 2, 
		}
		
		public enum eQueueType
		{	
		
			[Label("Default Value")]
			[Description(@"")]
			DefaultValue = 1, 
		}
		
		public enum eType
		{	
		
			[Label("Public")]
			[Description(@"")]
			Public = 0, 
		
			[Label("Private")]
			[Description(@"")]
			Private = 1, 
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
		
		public enum eStatusReason
		{	
		
			[Label("Inactive")]
			[Description(@"")]
			Inactive_Inactive = 2, 
		
			[Label("Active")]
			[Description(@"")]
			Active_Active = 1, 
		}
		
		#endregion	

		#region Properties
		public static class Properties 
		{
			/// <summary>allowemailcredentials</summary>
			public const string AllowToUseCredentialsForEmailProcessingObsolete = "allowemailcredentials";

			/// <summary>businessunitid</summary>
			public const string BusinessUnit = "businessunitid";

			/// <summary>businessunitidname</summary>
			public const string Businessunitidname = "businessunitidname";

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

			/// <summary>defaultmailbox</summary>
			public const string Mailbox = "defaultmailbox";

			/// <summary>defaultmailboxname</summary>
			public const string Defaultmailboxname = "defaultmailboxname";

			/// <summary>description</summary>
			public const string Description = "description";

			/// <summary>emailaddress</summary>
			public const string IncomingEmail = "emailaddress";

			/// <summary>emailpassword</summary>
			public const string PasswordObsolete = "emailpassword";

			/// <summary>emailrouteraccessapproval</summary>
			public const string PrimaryEmailStatus = "emailrouteraccessapproval";

			/// <summary>emailusername</summary>
			public const string UserNameObsolete = "emailusername";

			/// <summary>entityimage_timestamp</summary>
			public const string EntityimageTimestamp = "entityimage_timestamp";

			/// <summary>entityimage_url</summary>
			public const string EntityimageUrl = "entityimage_url";

			/// <summary>entityimageid</summary>
			public const string EntityImageId = "entityimageid";

			/// <summary>exchangerate</summary>
			public const string ExchangeRate = "exchangerate";

			/// <summary>ignoreunsolicitedemail</summary>
			public const string ConvertToEmailActivities = "ignoreunsolicitedemail";

			/// <summary>importsequencenumber</summary>
			public const string ImportSequenceNumber = "importsequencenumber";

			/// <summary>incomingemaildeliverymethod</summary>
			public const string IncomingEmailDeliveryMethod = "incomingemaildeliverymethod";

			/// <summary>incomingemailfilteringmethod</summary>
			public const string ConvertIncomingEmailToActivities = "incomingemailfilteringmethod";

			/// <summary>isemailaddressapprovedbyo365admin</summary>
			public const string EmailAddressO365AdminApprovalStatus = "isemailaddressapprovedbyo365admin";

			/// <summary>isfaxqueue</summary>
			public const string FaxQueue = "isfaxqueue";

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

			/// <summary>numberofitems</summary>
			public const string QueueItems = "numberofitems";

			/// <summary>numberofmembers</summary>
			public const string NoOfMembers = "numberofmembers";

			/// <summary>organizationid</summary>
			public const string Organization = "organizationid";

			/// <summary>organizationidname</summary>
			public const string Organizationidname = "organizationidname";

			/// <summary>outgoingemaildeliverymethod</summary>
			public const string OutgoingEmailDeliveryMethod = "outgoingemaildeliverymethod";

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

			/// <summary>primaryuserid</summary>
			public const string Ownerdeprecated = "primaryuserid";

			/// <summary>primaryuseridname</summary>
			public const string Primaryuseridname = "primaryuseridname";

			/// <summary>primaryuseridyominame</summary>
			public const string Primaryuseridyominame = "primaryuseridyominame";

			/// <summary>queueid</summary>
			public const string QueueId = "queueid";

			/// <summary>queuetypecode</summary>
			public const string QueueType = "queuetypecode";

			/// <summary>queueviewtype</summary>
			public const string Type = "queueviewtype";

			/// <summary>statecode</summary>
			public const string Status = "statecode";

			/// <summary>statuscode</summary>
			public const string StatusReason = "statuscode";

			/// <summary>transactioncurrencyid</summary>
			public const string Currency = "transactioncurrencyid";

			/// <summary>transactioncurrencyidname</summary>
			public const string Transactioncurrencyidname = "transactioncurrencyidname";

			/// <summary>versionnumber</summary>
			public const string VersionNumber = "versionnumber";

		}
		#endregion

		#region Schemas
		public static class Schemas 
		{
			/// <summary>1:N mailbox_regarding_queue</summary>
			public const string MailboxRegardingQueue = "mailbox_regarding_queue";

			/// <summary>1:N queue_activity_parties</summary>
			public const string QueueActivityParties = "queue_activity_parties";

			/// <summary>1:N Queue_AsyncOperations</summary>
			public const string QueueAsyncOperations = "Queue_AsyncOperations";

			/// <summary>1:N Queue_BulkDeleteFailures</summary>
			public const string QueueBulkDeleteFailures = "Queue_BulkDeleteFailures";

			/// <summary>1:N Queue_DuplicateBaseRecord</summary>
			public const string QueueDuplicateBaseRecord = "Queue_DuplicateBaseRecord";

			/// <summary>1:N Queue_DuplicateMatchingRecord</summary>
			public const string QueueDuplicateMatchingRecord = "Queue_DuplicateMatchingRecord";

			/// <summary>1:N Queue_Email_EmailSender</summary>
			public const string QueueEmailEmailSender = "Queue_Email_EmailSender";

			/// <summary>1:N queue_entries</summary>
			public const string QueueEntries = "queue_entries";

			/// <summary>1:N queue_PostFollows</summary>
			public const string QueuePostFollows = "queue_PostFollows";

			/// <summary>1:N queue_principalobjectattributeaccess</summary>
			public const string QueuePrincipalobjectattributeaccess = "queue_principalobjectattributeaccess";

			/// <summary>1:N Queue_ProcessSessions</summary>
			public const string QueueProcessSessions = "Queue_ProcessSessions";

			/// <summary>1:N Queue_SyncErrors</summary>
			public const string QueueSyncErrors = "Queue_SyncErrors";

			/// <summary>1:N queue_system_user</summary>
			public const string QueueSystemUser = "queue_system_user";

			/// <summary>1:N queue_team</summary>
			public const string QueueTeam = "queue_team";

			/// <summary>N:N queuemembership_association</summary>
			public const string QueuemembershipAssociation = "queuemembership_association";

		}
		#endregion
	}
}

