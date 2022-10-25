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
	[EntityLogicalName("emailserverprofile")]
	public sealed class EmailServerProfile : Entity
	{	
		public static readonly int? EntityTypeCode = 9605;
		public new const string LogicalName = "emailserverprofile";
		public const string PrimaryIdAttribute = "emailserverprofileid";
		public const string PrimaryNameAttribute = "name";
	
		public EmailServerProfile() : base("emailserverprofile") { }

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
        /// defaultserverlocation
        /// </summary>
		[DisplayName("Default Email Server Location")]
		[AttributeLogicalName("defaultserverlocation")]
		public string DefaultEmailServerLocation
		{	
			get { return GetAttributeValue<string>("defaultserverlocation"); }
			set
			{ 
				if(value == DefaultEmailServerLocation) return;
				SetAttributeValue("defaultserverlocation", value);
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
        /// emailserverprofileid
        /// </summary>
		[DisplayName("EmailServerProfile")]
		[AttributeLogicalName("emailserverprofileid")]
		public override Guid Id
		{
			get => base.Id;
			set { base.Id = value; SetAttributeValue("emailserverprofileid", value); }
		}

							/// <summary>
        /// emailservertypename
        /// </summary>
		[DisplayName("Email Server Type Name")]
		[AttributeLogicalName("emailservertypename")]
		public string EmailServerTypeName
		{	
			get { return GetAttributeValue<string>("emailservertypename"); }
			set
			{ 
				if(value == EmailServerTypeName) return;
				SetAttributeValue("emailservertypename", value);
			}
		}	
			
		/// <summary>
        /// encodingcodepage
        /// </summary>
		[DisplayName("Encoding Code Page")]
		[AttributeLogicalName("encodingcodepage")]
		public string EncodingCodePage
		{	
			get { return GetAttributeValue<string>("encodingcodepage"); }
			set
			{ 
				if(value == EncodingCodePage) return;
				SetAttributeValue("encodingcodepage", value);
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
        /// exchangeonlinetenantid
        /// </summary>
		[DisplayName("Exchange Online Tenant Id")]
		[AttributeLogicalName("exchangeonlinetenantid")]
		public string ExchangeOnlineTenantId
		{	
			get { return GetAttributeValue<string>("exchangeonlinetenantid"); }
			set
			{ 
				if(value == ExchangeOnlineTenantId) return;
				SetAttributeValue("exchangeonlinetenantid", value);
			}
		}	
			
		/// <summary>
        /// exchangeversion
        /// </summary>
		[DisplayName("Exchange Version")]
		[AttributeLogicalName("exchangeversion")]
		public eExchangeVersion? ExchangeVersion
		{	
			get 
			{ 
				var optionSetValue = GetAttributeValue<OptionSetValue>("exchangeversion");
				if (optionSetValue != null) return (eExchangeVersion)optionSetValue.Value;
				else return null;
			}
			set 
			{ 
				if(value == ExchangeVersion) return;

				OptionSetValue optionSetValue = null;
				if(value != null) optionSetValue = new OptionSetValue((int)value);
				SetAttributeValue("exchangeversion", optionSetValue); 
			}
		}

		/// <summary>
        /// incomingauthenticationprotocol
        /// </summary>
		[DisplayName("Incoming Authentication Protocol")]
		[AttributeLogicalName("incomingauthenticationprotocol")]
		public egAuthenticationProtocol? IncomingAuthenticationProtocol
		{	
			get 
			{ 
				var optionSetValue = GetAttributeValue<OptionSetValue>("incomingauthenticationprotocol");
				if (optionSetValue != null) return (egAuthenticationProtocol)optionSetValue.Value;
				else return null;
			}
			set 
			{ 
				if(value == IncomingAuthenticationProtocol) return;

				OptionSetValue optionSetValue = null;
				if(value != null) optionSetValue = new OptionSetValue((int)value);
				SetAttributeValue("incomingauthenticationprotocol", optionSetValue); 
			}
		}

		/// <summary>
        /// incomingcredentialretrieval
        /// </summary>
		[DisplayName("Incoming Email Credential Retrieval")]
		[AttributeLogicalName("incomingcredentialretrieval")]
		public eCredentialRetrievalMethod? IncomingEmailCredentialRetrieval
		{	
			get 
			{ 
				var optionSetValue = GetAttributeValue<OptionSetValue>("incomingcredentialretrieval");
				if (optionSetValue != null) return (eCredentialRetrievalMethod)optionSetValue.Value;
				else return null;
			}
			set 
			{ 
				if(value == IncomingEmailCredentialRetrieval) return;

				OptionSetValue optionSetValue = null;
				if(value != null) optionSetValue = new OptionSetValue((int)value);
				SetAttributeValue("incomingcredentialretrieval", optionSetValue); 
			}
		}

		/// <summary>
        /// incomingpartnerapplication
        /// </summary>
		[DisplayName("Incoming Partner Application")]
		[AttributeLogicalName("incomingpartnerapplication")]
		public EntityReference IncomingPartnerApplication
		{	
			get { return GetAttributeValue<EntityReference>("incomingpartnerapplication"); }
			set
			{ 
				if(value == IncomingPartnerApplication) return;
				SetAttributeValue("incomingpartnerapplication", value);
			}
		}	
			
		/// <summary>
        /// incomingpartnerapplicationname
        /// </summary>
		[DisplayName("incomingpartnerapplicationname")]
		[AttributeLogicalName("incomingpartnerapplicationname")]
		public string Incomingpartnerapplicationname
		{	
			get { return GetAttributeValue<string>("incomingpartnerapplicationname"); }
			set
			{ 
				if(value == Incomingpartnerapplicationname) return;
				SetAttributeValue("incomingpartnerapplicationname", value);
			}
		}	
			
		/// <summary>
        /// incomingpassword
        /// </summary>
		[DisplayName("Incoming Email Password")]
		[AttributeLogicalName("incomingpassword")]
		public string IncomingEmailPassword
		{	
			get { return GetAttributeValue<string>("incomingpassword"); }
			set
			{ 
				if(value == IncomingEmailPassword) return;
				SetAttributeValue("incomingpassword", value);
			}
		}	
			
		/// <summary>
        /// incomingportnumber
        /// </summary>
		[DisplayName("Incoming Email Port")]
		[AttributeLogicalName("incomingportnumber")]
		public int? IncomingEmailPort
		{	
			get { return GetAttributeValue<int?>("incomingportnumber"); }
			set
			{ 
				if(value == IncomingEmailPort) return;
				SetAttributeValue("incomingportnumber", value);
			}
		}	
			
		/// <summary>
        /// incomingserverlocation
        /// </summary>
		[DisplayName("Incoming Email Server Location")]
		[AttributeLogicalName("incomingserverlocation")]
		public string IncomingEmailServerLocation
		{	
			get { return GetAttributeValue<string>("incomingserverlocation"); }
			set
			{ 
				if(value == IncomingEmailServerLocation) return;
				SetAttributeValue("incomingserverlocation", value);
			}
		}	
			
		/// <summary>
        /// incominguseimpersonation
        /// </summary>
		[DisplayName("Use Impersonation for Incoming Email")]
		[AttributeLogicalName("incominguseimpersonation")]
		public bool? UseImpersonationForIncomingEmail
		{	
			get { return GetAttributeValue<bool?>("incominguseimpersonation"); }
			set
			{ 
				if(value == UseImpersonationForIncomingEmail) return;
				SetAttributeValue("incominguseimpersonation", value);
			}
		}	
			
		/// <summary>
        /// incomingusername
        /// </summary>
		[DisplayName("Incoming Email User Name")]
		[AttributeLogicalName("incomingusername")]
		public string IncomingEmailUserName
		{	
			get { return GetAttributeValue<string>("incomingusername"); }
			set
			{ 
				if(value == IncomingEmailUserName) return;
				SetAttributeValue("incomingusername", value);
			}
		}	
			
		/// <summary>
        /// incomingusessl
        /// </summary>
		[DisplayName("Use SSL for Incoming Email")]
		[AttributeLogicalName("incomingusessl")]
		public bool? UseSSLForIncomingEmail
		{	
			get { return GetAttributeValue<bool?>("incomingusessl"); }
			set
			{ 
				if(value == UseSSLForIncomingEmail) return;
				SetAttributeValue("incomingusessl", value);
			}
		}	
			
		/// <summary>
        /// isincomingpasswordset
        /// </summary>
		[DisplayName("isincomingpasswordset")]
		[AttributeLogicalName("isincomingpasswordset")]
		public bool? Isincomingpasswordset
		{	
			get { return GetAttributeValue<bool?>("isincomingpasswordset"); }
			set
			{ 
				if(value == Isincomingpasswordset) return;
				SetAttributeValue("isincomingpasswordset", value);
			}
		}	
			
		/// <summary>
        /// isoauthclientsecretset
        /// </summary>
		[DisplayName("isoauthclientsecretset")]
		[AttributeLogicalName("isoauthclientsecretset")]
		public bool? Isoauthclientsecretset
		{	
			get { return GetAttributeValue<bool?>("isoauthclientsecretset"); }
			set
			{ 
				if(value == Isoauthclientsecretset) return;
				SetAttributeValue("isoauthclientsecretset", value);
			}
		}	
			
		/// <summary>
        /// isoutgoingpasswordset
        /// </summary>
		[DisplayName("isoutgoingpasswordset")]
		[AttributeLogicalName("isoutgoingpasswordset")]
		public bool? Isoutgoingpasswordset
		{	
			get { return GetAttributeValue<bool?>("isoutgoingpasswordset"); }
			set
			{ 
				if(value == Isoutgoingpasswordset) return;
				SetAttributeValue("isoutgoingpasswordset", value);
			}
		}	
			
		/// <summary>
        /// lastauthorizationstatus
        /// </summary>
		[DisplayName("Last Test Authorization Status")]
		[AttributeLogicalName("lastauthorizationstatus")]
		public eSelectTheStatusOfTheTest? LastTestAuthorizationStatus
		{	
			get 
			{ 
				var optionSetValue = GetAttributeValue<OptionSetValue>("lastauthorizationstatus");
				if (optionSetValue != null) return (eSelectTheStatusOfTheTest)optionSetValue.Value;
				else return null;
			}
			set 
			{ 
				if(value == LastTestAuthorizationStatus) return;

				OptionSetValue optionSetValue = null;
				if(value != null) optionSetValue = new OptionSetValue((int)value);
				SetAttributeValue("lastauthorizationstatus", optionSetValue); 
			}
		}

		/// <summary>
        /// lastcrmmessage
        /// </summary>
		[DisplayName("Last Dynamics 365 Message")]
		[AttributeLogicalName("lastcrmmessage")]
		public string LastDynamics365Message
		{	
			get { return GetAttributeValue<string>("lastcrmmessage"); }
			set
			{ 
				if(value == LastDynamics365Message) return;
				SetAttributeValue("lastcrmmessage", value);
			}
		}	
			
		/// <summary>
        /// lasttestexecutionstatus
        /// </summary>
		[DisplayName("Last Test Execution Status")]
		[AttributeLogicalName("lasttestexecutionstatus")]
		public eSelectTheStatusOfTheTest2? LastTestExecutionStatus
		{	
			get 
			{ 
				var optionSetValue = GetAttributeValue<OptionSetValue>("lasttestexecutionstatus");
				if (optionSetValue != null) return (eSelectTheStatusOfTheTest2)optionSetValue.Value;
				else return null;
			}
			set 
			{ 
				if(value == LastTestExecutionStatus) return;

				OptionSetValue optionSetValue = null;
				if(value != null) optionSetValue = new OptionSetValue((int)value);
				SetAttributeValue("lasttestexecutionstatus", optionSetValue); 
			}
		}

		/// <summary>
        /// lasttestrequest
        /// </summary>
		[DisplayName("Last Test Request")]
		[AttributeLogicalName("lasttestrequest")]
		public string LastTestRequest
		{	
			get { return GetAttributeValue<string>("lasttestrequest"); }
			set
			{ 
				if(value == LastTestRequest) return;
				SetAttributeValue("lasttestrequest", value);
			}
		}	
			
		/// <summary>
        /// lasttestresponse
        /// </summary>
		[DisplayName("Last Test Response")]
		[AttributeLogicalName("lasttestresponse")]
		public string LastTestResponse
		{	
			get { return GetAttributeValue<string>("lasttestresponse"); }
			set
			{ 
				if(value == LastTestResponse) return;
				SetAttributeValue("lasttestresponse", value);
			}
		}	
			
		/// <summary>
        /// lastteststarttime
        /// </summary>
		[DisplayName("Last Test Time")]
		[AttributeLogicalName("lastteststarttime")]
		public DateTime? LastTestTime
		{	
			get { return GetAttributeValue<DateTime?>("lastteststarttime"); }
			set
			{ 
				if(value == LastTestTime) return;
				SetAttributeValue("lastteststarttime", value);
			}
		}	
			
		/// <summary>
        /// lasttesttotalexecutiontime
        /// </summary>
		[DisplayName("Last Test Time Taken")]
		[AttributeLogicalName("lasttesttotalexecutiontime")]
		public int? LastTestTimeTaken
		{	
			get { return GetAttributeValue<int?>("lasttesttotalexecutiontime"); }
			set
			{ 
				if(value == LastTestTimeTaken) return;
				SetAttributeValue("lasttesttotalexecutiontime", value);
			}
		}	
			
		/// <summary>
        /// lasttestvalidationstatus
        /// </summary>
		[DisplayName("Last Test Validation Status")]
		[AttributeLogicalName("lasttestvalidationstatus")]
		public eSelectTheStatusOfTheTest3? LastTestValidationStatus
		{	
			get 
			{ 
				var optionSetValue = GetAttributeValue<OptionSetValue>("lasttestvalidationstatus");
				if (optionSetValue != null) return (eSelectTheStatusOfTheTest3)optionSetValue.Value;
				else return null;
			}
			set 
			{ 
				if(value == LastTestValidationStatus) return;

				OptionSetValue optionSetValue = null;
				if(value != null) optionSetValue = new OptionSetValue((int)value);
				SetAttributeValue("lasttestvalidationstatus", optionSetValue); 
			}
		}

		/// <summary>
        /// maxconcurrentconnections
        /// </summary>
		[DisplayName("Maximum Concurrent Connections")]
		[AttributeLogicalName("maxconcurrentconnections")]
		public int? MaximumConcurrentConnections
		{	
			get { return GetAttributeValue<int?>("maxconcurrentconnections"); }
			set
			{ 
				if(value == MaximumConcurrentConnections) return;
				SetAttributeValue("maxconcurrentconnections", value);
			}
		}	
			
		/// <summary>
        /// minpollingintervalinminutes
        /// </summary>
		[DisplayName("Minimum Polling Interval In Minutes")]
		[AttributeLogicalName("minpollingintervalinminutes")]
		public int? MinimumPollingIntervalInMinutes
		{	
			get { return GetAttributeValue<int?>("minpollingintervalinminutes"); }
			set
			{ 
				if(value == MinimumPollingIntervalInMinutes) return;
				SetAttributeValue("minpollingintervalinminutes", value);
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
        /// moveundeliveredemails
        /// </summary>
		[DisplayName("Move Undelivered Emails to the Undeliverable Folder")]
		[AttributeLogicalName("moveundeliveredemails")]
		public bool? MoveUndeliveredEmailsToTheUndeliverableFolder
		{	
			get { return GetAttributeValue<bool?>("moveundeliveredemails"); }
			set
			{ 
				if(value == MoveUndeliveredEmailsToTheUndeliverableFolder) return;
				SetAttributeValue("moveundeliveredemails", value);
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
        /// oauthclientid
        /// </summary>
		[DisplayName("Oauth ClientId")]
		[AttributeLogicalName("oauthclientid")]
		public string OauthClientId
		{	
			get { return GetAttributeValue<string>("oauthclientid"); }
			set
			{ 
				if(value == OauthClientId) return;
				SetAttributeValue("oauthclientid", value);
			}
		}	
			
		/// <summary>
        /// oauthclientsecret
        /// </summary>
		[DisplayName("OAuth Client Secret")]
		[AttributeLogicalName("oauthclientsecret")]
		public string OAuthClientSecret
		{	
			get { return GetAttributeValue<string>("oauthclientsecret"); }
			set
			{ 
				if(value == OAuthClientSecret) return;
				SetAttributeValue("oauthclientsecret", value);
			}
		}	
			
		/// <summary>
        /// organizationid
        /// </summary>
		[DisplayName("Organization Id")]
		[AttributeLogicalName("organizationid")]
		public EntityReference OrganizationId
		{	
			get { return GetAttributeValue<EntityReference>("organizationid"); }
			set
			{ 
				if(value == OrganizationId) return;
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
        /// outgoingauthenticationprotocol
        /// </summary>
		[DisplayName("Outgoing Authentication Protocol")]
		[AttributeLogicalName("outgoingauthenticationprotocol")]
		public egAuthenticationProtocol? OutgoingAuthenticationProtocol
		{	
			get 
			{ 
				var optionSetValue = GetAttributeValue<OptionSetValue>("outgoingauthenticationprotocol");
				if (optionSetValue != null) return (egAuthenticationProtocol)optionSetValue.Value;
				else return null;
			}
			set 
			{ 
				if(value == OutgoingAuthenticationProtocol) return;

				OptionSetValue optionSetValue = null;
				if(value != null) optionSetValue = new OptionSetValue((int)value);
				SetAttributeValue("outgoingauthenticationprotocol", optionSetValue); 
			}
		}

		/// <summary>
        /// outgoingautograntdelegateaccess
        /// </summary>
		[DisplayName("Auto Grant Delegate Access for Outgoing Email.")]
		[AttributeLogicalName("outgoingautograntdelegateaccess")]
		public bool? AutoGrantDelegateAccessForOutgoingEmail
		{	
			get { return GetAttributeValue<bool?>("outgoingautograntdelegateaccess"); }
			set
			{ 
				if(value == AutoGrantDelegateAccessForOutgoingEmail) return;
				SetAttributeValue("outgoingautograntdelegateaccess", value);
			}
		}	
			
		/// <summary>
        /// outgoingcredentialretrieval
        /// </summary>
		[DisplayName("Outgoing Email Credential Retrieval")]
		[AttributeLogicalName("outgoingcredentialretrieval")]
		public eUseWindowsAuthenticationForOutgoing? OutgoingEmailCredentialRetrieval
		{	
			get 
			{ 
				var optionSetValue = GetAttributeValue<OptionSetValue>("outgoingcredentialretrieval");
				if (optionSetValue != null) return (eUseWindowsAuthenticationForOutgoing)optionSetValue.Value;
				else return null;
			}
			set 
			{ 
				if(value == OutgoingEmailCredentialRetrieval) return;

				OptionSetValue optionSetValue = null;
				if(value != null) optionSetValue = new OptionSetValue((int)value);
				SetAttributeValue("outgoingcredentialretrieval", optionSetValue); 
			}
		}

		/// <summary>
        /// outgoingpartnerapplication
        /// </summary>
		[DisplayName("Outgoing Partner Application")]
		[AttributeLogicalName("outgoingpartnerapplication")]
		public EntityReference OutgoingPartnerApplication
		{	
			get { return GetAttributeValue<EntityReference>("outgoingpartnerapplication"); }
			set
			{ 
				if(value == OutgoingPartnerApplication) return;
				SetAttributeValue("outgoingpartnerapplication", value);
			}
		}	
			
		/// <summary>
        /// outgoingpartnerapplicationname
        /// </summary>
		[DisplayName("outgoingpartnerapplicationname")]
		[AttributeLogicalName("outgoingpartnerapplicationname")]
		public string Outgoingpartnerapplicationname
		{	
			get { return GetAttributeValue<string>("outgoingpartnerapplicationname"); }
			set
			{ 
				if(value == Outgoingpartnerapplicationname) return;
				SetAttributeValue("outgoingpartnerapplicationname", value);
			}
		}	
			
		/// <summary>
        /// outgoingpassword
        /// </summary>
		[DisplayName("Outgoing Email Password")]
		[AttributeLogicalName("outgoingpassword")]
		public string OutgoingEmailPassword
		{	
			get { return GetAttributeValue<string>("outgoingpassword"); }
			set
			{ 
				if(value == OutgoingEmailPassword) return;
				SetAttributeValue("outgoingpassword", value);
			}
		}	
			
		/// <summary>
        /// outgoingportnumber
        /// </summary>
		[DisplayName("Outgoing Email Port")]
		[AttributeLogicalName("outgoingportnumber")]
		public int? OutgoingEmailPort
		{	
			get { return GetAttributeValue<int?>("outgoingportnumber"); }
			set
			{ 
				if(value == OutgoingEmailPort) return;
				SetAttributeValue("outgoingportnumber", value);
			}
		}	
			
		/// <summary>
        /// outgoingserverlocation
        /// </summary>
		[DisplayName("Outgoing Email Server Location")]
		[AttributeLogicalName("outgoingserverlocation")]
		public string OutgoingEmailServerLocation
		{	
			get { return GetAttributeValue<string>("outgoingserverlocation"); }
			set
			{ 
				if(value == OutgoingEmailServerLocation) return;
				SetAttributeValue("outgoingserverlocation", value);
			}
		}	
			
		/// <summary>
        /// outgoinguseimpersonation
        /// </summary>
		[DisplayName("Use Impersonation for Outgoing Email")]
		[AttributeLogicalName("outgoinguseimpersonation")]
		public bool? UseImpersonationForOutgoingEmail
		{	
			get { return GetAttributeValue<bool?>("outgoinguseimpersonation"); }
			set
			{ 
				if(value == UseImpersonationForOutgoingEmail) return;
				SetAttributeValue("outgoinguseimpersonation", value);
			}
		}	
			
		/// <summary>
        /// outgoingusername
        /// </summary>
		[DisplayName("Outgoing Email User Name")]
		[AttributeLogicalName("outgoingusername")]
		public string OutgoingEmailUserName
		{	
			get { return GetAttributeValue<string>("outgoingusername"); }
			set
			{ 
				if(value == OutgoingEmailUserName) return;
				SetAttributeValue("outgoingusername", value);
			}
		}	
			
		/// <summary>
        /// outgoingusessl
        /// </summary>
		[DisplayName("Use SSL for Outgoing Email")]
		[AttributeLogicalName("outgoingusessl")]
		public bool? UseSSLForOutgoingEmail
		{	
			get { return GetAttributeValue<bool?>("outgoingusessl"); }
			set
			{ 
				if(value == UseSSLForOutgoingEmail) return;
				SetAttributeValue("outgoingusessl", value);
			}
		}	
			
		/// <summary>
        /// owneremailaddress
        /// </summary>
		[DisplayName("Email Server Profile Owner's email address")]
		[AttributeLogicalName("owneremailaddress")]
		public string EmailServerProfileOwnersEmailAddress
		{	
			get { return GetAttributeValue<string>("owneremailaddress"); }
			set
			{ 
				if(value == EmailServerProfileOwnersEmailAddress) return;
				SetAttributeValue("owneremailaddress", value);
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
        /// processemailsreceivedafter
        /// </summary>
		[DisplayName("Process Emails Received After")]
		[AttributeLogicalName("processemailsreceivedafter")]
		public DateTime? ProcessEmailsReceivedAfter
		{	
			get { return GetAttributeValue<DateTime?>("processemailsreceivedafter"); }
			set
			{ 
				if(value == ProcessEmailsReceivedAfter) return;
				SetAttributeValue("processemailsreceivedafter", value);
			}
		}	
			
		/// <summary>
        /// sendemailalert
        /// </summary>
		[DisplayName("Send an alert email to the owner of the email server profile reporting on major events")]
		[AttributeLogicalName("sendemailalert")]
		public bool? SendAnAlertEmailToTheOwnerOfTheEmailServerProfileReportingOnMajorEvents
		{	
			get { return GetAttributeValue<bool?>("sendemailalert"); }
			set
			{ 
				if(value == SendAnAlertEmailToTheOwnerOfTheEmailServerProfileReportingOnMajorEvents) return;
				SetAttributeValue("sendemailalert", value);
			}
		}	
			
		/// <summary>
        /// servertype
        /// </summary>
		[DisplayName("Email Server Type")]
		[AttributeLogicalName("servertype")]
		public eEmailServerType? EmailServerType
		{	
			get 
			{ 
				var optionSetValue = GetAttributeValue<OptionSetValue>("servertype");
				if (optionSetValue != null) return (eEmailServerType)optionSetValue.Value;
				else return null;
			}
			set 
			{ 
				if(value == EmailServerType) return;

				OptionSetValue optionSetValue = null;
				if(value != null) optionSetValue = new OptionSetValue((int)value);
				SetAttributeValue("servertype", optionSetValue); 
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
        /// timeoutmailboxconnection
        /// </summary>
		[DisplayName("Timeout Mailbox Connection to Exchange")]
		[AttributeLogicalName("timeoutmailboxconnection")]
		public bool? TimeoutMailboxConnectionToExchange
		{	
			get { return GetAttributeValue<bool?>("timeoutmailboxconnection"); }
			set
			{ 
				if(value == TimeoutMailboxConnectionToExchange) return;
				SetAttributeValue("timeoutmailboxconnection", value);
			}
		}	
			
		/// <summary>
        /// timeoutmailboxconnectionafteramount
        /// </summary>
		[DisplayName("Timeout a Single Mailbox Connection After this Amount of Milliseconds")]
		[AttributeLogicalName("timeoutmailboxconnectionafteramount")]
		public int? TimeoutASingleMailboxConnectionAfterThisAmountOfMilliseconds
		{	
			get { return GetAttributeValue<int?>("timeoutmailboxconnectionafteramount"); }
			set
			{ 
				if(value == TimeoutASingleMailboxConnectionAfterThisAmountOfMilliseconds) return;
				SetAttributeValue("timeoutmailboxconnectionafteramount", value);
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
        /// useautodiscover
        /// </summary>
		[DisplayName("Auto Discover Server Location")]
		[AttributeLogicalName("useautodiscover")]
		public bool? AutoDiscoverServerLocation
		{	
			get { return GetAttributeValue<bool?>("useautodiscover"); }
			set
			{ 
				if(value == AutoDiscoverServerLocation) return;
				SetAttributeValue("useautodiscover", value);
			}
		}	
			
		/// <summary>
        /// usedefaulttenantid
        /// </summary>
		[DisplayName("Use Default Tenant Id")]
		[AttributeLogicalName("usedefaulttenantid")]
		public bool? UseDefaultTenantId
		{	
			get { return GetAttributeValue<bool?>("usedefaulttenantid"); }
			set
			{ 
				if(value == UseDefaultTenantId) return;
				SetAttributeValue("usedefaulttenantid", value);
			}
		}	
			
		/// <summary>
        /// usesamesettingsforoutgoingconnections
        /// </summary>
		[DisplayName("Use Same Settings for Outgoing Connection")]
		[AttributeLogicalName("usesamesettingsforoutgoingconnections")]
		public bool? UseSameSettingsForOutgoingConnection
		{	
			get { return GetAttributeValue<bool?>("usesamesettingsforoutgoingconnections"); }
			set
			{ 
				if(value == UseSameSettingsForOutgoingConnection) return;
				SetAttributeValue("usesamesettingsforoutgoingconnections", value);
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
        /// 1:N Get entities for 'EmailServerProfile_Annotation'
        /// </summary>
		[RelationshipSchemaName("EmailServerProfile_Annotation")]
		public IEnumerable<Note> EmailServerProfileAnnotation
		{
			get { return GetRelatedEntities<Note>("EmailServerProfile_Annotation", null); }
			set { SetRelatedEntities("EmailServerProfile_Annotation", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'emailserverprofile_asyncoperations'
        /// </summary>
		[RelationshipSchemaName("emailserverprofile_asyncoperations")]
		public IEnumerable<SystemJob> EmailserverprofileAsyncoperations
		{
			get { return GetRelatedEntities<SystemJob>("emailserverprofile_asyncoperations", null); }
			set { SetRelatedEntities("emailserverprofile_asyncoperations", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'emailserverprofile_bulkdeletefailures'
        /// </summary>
		[RelationshipSchemaName("emailserverprofile_bulkdeletefailures")]
		public IEnumerable<BulkDeleteFailure> EmailserverprofileBulkdeletefailures
		{
			get { return GetRelatedEntities<BulkDeleteFailure>("emailserverprofile_bulkdeletefailures", null); }
			set { SetRelatedEntities("emailserverprofile_bulkdeletefailures", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'emailserverprofile_duplicatebaserecord'
        /// </summary>
		[RelationshipSchemaName("emailserverprofile_duplicatebaserecord")]
		public IEnumerable<DuplicateRecord> EmailserverprofileDuplicatebaserecord
		{
			get { return GetRelatedEntities<DuplicateRecord>("emailserverprofile_duplicatebaserecord", null); }
			set { SetRelatedEntities("emailserverprofile_duplicatebaserecord", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'emailserverprofile_duplicatematchingrecord'
        /// </summary>
		[RelationshipSchemaName("emailserverprofile_duplicatematchingrecord")]
		public IEnumerable<DuplicateRecord> EmailserverprofileDuplicatematchingrecord
		{
			get { return GetRelatedEntities<DuplicateRecord>("emailserverprofile_duplicatematchingrecord", null); }
			set { SetRelatedEntities("emailserverprofile_duplicatematchingrecord", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'emailserverprofile_mailbox'
        /// </summary>
		[RelationshipSchemaName("emailserverprofile_mailbox")]
		public IEnumerable<Mailbox> EmailserverprofileMailbox
		{
			get { return GetRelatedEntities<Mailbox>("emailserverprofile_mailbox", null); }
			set { SetRelatedEntities("emailserverprofile_mailbox", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'EmailServerProfile_Organization'
        /// </summary>
		[RelationshipSchemaName("EmailServerProfile_Organization")]
		public IEnumerable<Organization> EmailServerProfileOrganization
		{
			get { return GetRelatedEntities<Organization>("EmailServerProfile_Organization", null); }
			set { SetRelatedEntities("EmailServerProfile_Organization", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'EmailServerProfile_SyncErrors'
        /// </summary>
		[RelationshipSchemaName("EmailServerProfile_SyncErrors")]
		public IEnumerable<SyncError> EmailServerProfileSyncErrors
		{
			get { return GetRelatedEntities<SyncError>("EmailServerProfile_SyncErrors", null); }
			set { SetRelatedEntities("EmailServerProfile_SyncErrors", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'tracelog_EmailServerProfile'
        /// </summary>
		[RelationshipSchemaName("tracelog_EmailServerProfile")]
		public IEnumerable<Trace> TracelogEmailServerProfile
		{
			get { return GetRelatedEntities<Trace>("tracelog_EmailServerProfile", null); }
			set { SetRelatedEntities("tracelog_EmailServerProfile", null, value); }
		}
		#endregion

		#region Actions
		#endregion

		#region OptionSetEnums
		public enum egAuthenticationProtocol
		{	
		
			[Label("Auto Detect")]
			[Description(@"")]
			AutoDetect = 0, 
		
			[Label("Negotiate")]
			[Description(@"")]
			Negotiate = 1, 
		
			[Label("NTLM")]
			[Description(@"")]
			NTLM = 2, 
		
			[Label("Basic")]
			[Description(@"")]
			Basic = 3, 
		
			[Label("OAuth")]
			[Description(@"")]
			OAuth = 4, 
		}
		
		public enum eExchangeVersion
		{	
		
			[Label("Exchange 2007")]
			[Description(@"")]
			Exchange2007 = 0, 
		
			[Label("Exchange 2007 SP1")]
			[Description(@"")]
			Exchange2007SP1 = 1, 
		
			[Label("Exchange 2010")]
			[Description(@"")]
			Exchange2010 = 2, 
		
			[Label("Exchange 2010 SP1")]
			[Description(@"")]
			Exchange2010SP1 = 3, 
		
			[Label("Exchange 2010 SP2")]
			[Description(@"")]
			Exchange2010SP2 = 4, 
		
			[Label("Exchange 2013")]
			[Description(@"")]
			Exchange2013 = 5, 
		}
		
		public enum eCredentialRetrievalMethod
		{	
		
			[Label("Credentials Specified by a User or Queue")]
			[Description(@"")]
			CredentialsSpecifiedByAUserOrQueue = 0, 
		
			[Label("Credentials Specified in Email Server Profile")]
			[Description(@"")]
			CredentialsSpecifiedInEmailServerProfile = 1, 
		
			[Label("Server to Server Authentication")]
			[Description(@"")]
			ServerToServerAuthentication = 2, 
		
			[Label("Windows Integrated Authentication")]
			[Description(@"")]
			WindowsIntegratedAuthentication = 3, 
		
			[Label("Without Credentials (Anonymous)")]
			[Description(@"")]
			WithoutCredentialsAnonymous = 4, 
		
			[Label("Gmail OAuth")]
			[Description(@"")]
			GmailOAuth = 5, 
		}
		
		public enum eSelectTheStatusOfTheTest
		{	
		
			[Label("Failure")]
			[Description(@"")]
			Failure = 0, 
		
			[Label("Success")]
			[Description(@"")]
			Success = 1, 
		}
		
		public enum eSelectTheStatusOfTheTest2
		{	
		
			[Label("Failure")]
			[Description(@"")]
			Failure = 0, 
		
			[Label("Success")]
			[Description(@"")]
			Success = 1, 
		
			[Label("Warning")]
			[Description(@"")]
			Warning = 2, 
		}
		
		public enum eSelectTheStatusOfTheTest3
		{	
		
			[Label("Failure")]
			[Description(@"")]
			Failure = 0, 
		
			[Label("Success")]
			[Description(@"")]
			Success = 1, 
		}
		
		public enum eUseWindowsAuthenticationForOutgoing
		{	
		
			[Label("Credentials Specified by a User or Queue")]
			[Description(@"")]
			CredentialsSpecifiedByAUserOrQueue = 0, 
		
			[Label("Credentials Specified in Email Server Profile")]
			[Description(@"")]
			CredentialsSpecifiedInEmailServerProfile = 1, 
		
			[Label("Server to Server Authentication")]
			[Description(@"")]
			ServerToServerAuthentication = 2, 
		
			[Label("Windows Integrated Authentication")]
			[Description(@"")]
			WindowsIntegratedAuthentication = 3, 
		
			[Label("Without Credentials (Anonymous)")]
			[Description(@"")]
			WithoutCredentialsAnonymous = 4, 
		
			[Label("Gmail OAuth")]
			[Description(@"")]
			GmailOAuth = 5, 
		}
		
		public enum eEmailServerType
		{	
		
			[Label("Exchange Server")]
			[Description(@"")]
			ExchangeServer = 0, 
		
			[Label("Other (POP3/SMTP)")]
			[Description(@"")]
			OtherPOP3SMTP = 1, 
		
			[Label("Exchange Server (Hybrid)")]
			[Description(@"")]
			ExchangeServerHybrid = 2, 
		
			[Label("Exchange Online (Hybrid)")]
			[Description(@"")]
			ExchangeOnlineHybrid = 3, 
		
			[Label("IMAP/SMTP")]
			[Description(@"")]
			IMAPSMTP = 4, 
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

			/// <summary>defaultserverlocation</summary>
			public const string DefaultEmailServerLocation = "defaultserverlocation";

			/// <summary>description</summary>
			public const string Description = "description";

			/// <summary>emailserverprofileid</summary>
			public const string EmailServerProfileId = "emailserverprofileid";

			/// <summary>emailservertypename</summary>
			public const string EmailServerTypeName = "emailservertypename";

			/// <summary>encodingcodepage</summary>
			public const string EncodingCodePage = "encodingcodepage";

			/// <summary>entityimage_timestamp</summary>
			public const string EntityimageTimestamp = "entityimage_timestamp";

			/// <summary>entityimage_url</summary>
			public const string EntityimageUrl = "entityimage_url";

			/// <summary>entityimageid</summary>
			public const string EntityImageId = "entityimageid";

			/// <summary>exchangeonlinetenantid</summary>
			public const string ExchangeOnlineTenantId = "exchangeonlinetenantid";

			/// <summary>exchangeversion</summary>
			public const string ExchangeVersion = "exchangeversion";

			/// <summary>incomingauthenticationprotocol</summary>
			public const string IncomingAuthenticationProtocol = "incomingauthenticationprotocol";

			/// <summary>incomingcredentialretrieval</summary>
			public const string IncomingEmailCredentialRetrieval = "incomingcredentialretrieval";

			/// <summary>incomingpartnerapplication</summary>
			public const string IncomingPartnerApplication = "incomingpartnerapplication";

			/// <summary>incomingpartnerapplicationname</summary>
			public const string Incomingpartnerapplicationname = "incomingpartnerapplicationname";

			/// <summary>incomingpassword</summary>
			public const string IncomingEmailPassword = "incomingpassword";

			/// <summary>incomingportnumber</summary>
			public const string IncomingEmailPort = "incomingportnumber";

			/// <summary>incomingserverlocation</summary>
			public const string IncomingEmailServerLocation = "incomingserverlocation";

			/// <summary>incominguseimpersonation</summary>
			public const string UseImpersonationForIncomingEmail = "incominguseimpersonation";

			/// <summary>incomingusername</summary>
			public const string IncomingEmailUserName = "incomingusername";

			/// <summary>incomingusessl</summary>
			public const string UseSSLForIncomingEmail = "incomingusessl";

			/// <summary>isincomingpasswordset</summary>
			public const string Isincomingpasswordset = "isincomingpasswordset";

			/// <summary>isoauthclientsecretset</summary>
			public const string Isoauthclientsecretset = "isoauthclientsecretset";

			/// <summary>isoutgoingpasswordset</summary>
			public const string Isoutgoingpasswordset = "isoutgoingpasswordset";

			/// <summary>lastauthorizationstatus</summary>
			public const string LastTestAuthorizationStatus = "lastauthorizationstatus";

			/// <summary>lastcrmmessage</summary>
			public const string LastDynamics365Message = "lastcrmmessage";

			/// <summary>lasttestexecutionstatus</summary>
			public const string LastTestExecutionStatus = "lasttestexecutionstatus";

			/// <summary>lasttestrequest</summary>
			public const string LastTestRequest = "lasttestrequest";

			/// <summary>lasttestresponse</summary>
			public const string LastTestResponse = "lasttestresponse";

			/// <summary>lastteststarttime</summary>
			public const string LastTestTime = "lastteststarttime";

			/// <summary>lasttesttotalexecutiontime</summary>
			public const string LastTestTimeTaken = "lasttesttotalexecutiontime";

			/// <summary>lasttestvalidationstatus</summary>
			public const string LastTestValidationStatus = "lasttestvalidationstatus";

			/// <summary>maxconcurrentconnections</summary>
			public const string MaximumConcurrentConnections = "maxconcurrentconnections";

			/// <summary>minpollingintervalinminutes</summary>
			public const string MinimumPollingIntervalInMinutes = "minpollingintervalinminutes";

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

			/// <summary>moveundeliveredemails</summary>
			public const string MoveUndeliveredEmailsToTheUndeliverableFolder = "moveundeliveredemails";

			/// <summary>name</summary>
			public const string Name = "name";

			/// <summary>oauthclientid</summary>
			public const string OauthClientId = "oauthclientid";

			/// <summary>oauthclientsecret</summary>
			public const string OAuthClientSecret = "oauthclientsecret";

			/// <summary>organizationid</summary>
			public const string OrganizationId = "organizationid";

			/// <summary>organizationidname</summary>
			public const string Organizationidname = "organizationidname";

			/// <summary>outgoingauthenticationprotocol</summary>
			public const string OutgoingAuthenticationProtocol = "outgoingauthenticationprotocol";

			/// <summary>outgoingautograntdelegateaccess</summary>
			public const string AutoGrantDelegateAccessForOutgoingEmail = "outgoingautograntdelegateaccess";

			/// <summary>outgoingcredentialretrieval</summary>
			public const string OutgoingEmailCredentialRetrieval = "outgoingcredentialretrieval";

			/// <summary>outgoingpartnerapplication</summary>
			public const string OutgoingPartnerApplication = "outgoingpartnerapplication";

			/// <summary>outgoingpartnerapplicationname</summary>
			public const string Outgoingpartnerapplicationname = "outgoingpartnerapplicationname";

			/// <summary>outgoingpassword</summary>
			public const string OutgoingEmailPassword = "outgoingpassword";

			/// <summary>outgoingportnumber</summary>
			public const string OutgoingEmailPort = "outgoingportnumber";

			/// <summary>outgoingserverlocation</summary>
			public const string OutgoingEmailServerLocation = "outgoingserverlocation";

			/// <summary>outgoinguseimpersonation</summary>
			public const string UseImpersonationForOutgoingEmail = "outgoinguseimpersonation";

			/// <summary>outgoingusername</summary>
			public const string OutgoingEmailUserName = "outgoingusername";

			/// <summary>outgoingusessl</summary>
			public const string UseSSLForOutgoingEmail = "outgoingusessl";

			/// <summary>owneremailaddress</summary>
			public const string EmailServerProfileOwnersEmailAddress = "owneremailaddress";

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

			/// <summary>processemailsreceivedafter</summary>
			public const string ProcessEmailsReceivedAfter = "processemailsreceivedafter";

			/// <summary>sendemailalert</summary>
			public const string SendAnAlertEmailToTheOwnerOfTheEmailServerProfileReportingOnMajorEvents = "sendemailalert";

			/// <summary>servertype</summary>
			public const string EmailServerType = "servertype";

			/// <summary>statecode</summary>
			public const string Status = "statecode";

			/// <summary>statuscode</summary>
			public const string StatusReason = "statuscode";

			/// <summary>timeoutmailboxconnection</summary>
			public const string TimeoutMailboxConnectionToExchange = "timeoutmailboxconnection";

			/// <summary>timeoutmailboxconnectionafteramount</summary>
			public const string TimeoutASingleMailboxConnectionAfterThisAmountOfMilliseconds = "timeoutmailboxconnectionafteramount";

			/// <summary>timezoneruleversionnumber</summary>
			public const string TimeZoneRuleVersionNumber = "timezoneruleversionnumber";

			/// <summary>useautodiscover</summary>
			public const string AutoDiscoverServerLocation = "useautodiscover";

			/// <summary>usedefaulttenantid</summary>
			public const string UseDefaultTenantId = "usedefaulttenantid";

			/// <summary>usesamesettingsforoutgoingconnections</summary>
			public const string UseSameSettingsForOutgoingConnection = "usesamesettingsforoutgoingconnections";

			/// <summary>utcconversiontimezonecode</summary>
			public const string UTCConversionTimeZoneCode = "utcconversiontimezonecode";

			/// <summary>versionnumber</summary>
			public const string VersionNumber = "versionnumber";

		}
		#endregion

		#region Schemas
		public static class Schemas 
		{
			/// <summary>1:N EmailServerProfile_Annotation</summary>
			public const string EmailServerProfileAnnotation = "EmailServerProfile_Annotation";

			/// <summary>1:N emailserverprofile_asyncoperations</summary>
			public const string EmailserverprofileAsyncoperations = "emailserverprofile_asyncoperations";

			/// <summary>1:N emailserverprofile_bulkdeletefailures</summary>
			public const string EmailserverprofileBulkdeletefailures = "emailserverprofile_bulkdeletefailures";

			/// <summary>1:N emailserverprofile_duplicatebaserecord</summary>
			public const string EmailserverprofileDuplicatebaserecord = "emailserverprofile_duplicatebaserecord";

			/// <summary>1:N emailserverprofile_duplicatematchingrecord</summary>
			public const string EmailserverprofileDuplicatematchingrecord = "emailserverprofile_duplicatematchingrecord";

			/// <summary>1:N emailserverprofile_mailbox</summary>
			public const string EmailserverprofileMailbox = "emailserverprofile_mailbox";

			/// <summary>1:N EmailServerProfile_Organization</summary>
			public const string EmailServerProfileOrganization = "EmailServerProfile_Organization";

			/// <summary>1:N EmailServerProfile_SyncErrors</summary>
			public const string EmailServerProfileSyncErrors = "EmailServerProfile_SyncErrors";

			/// <summary>1:N tracelog_EmailServerProfile</summary>
			public const string TracelogEmailServerProfile = "tracelog_EmailServerProfile";

		}
		#endregion
	}
}

