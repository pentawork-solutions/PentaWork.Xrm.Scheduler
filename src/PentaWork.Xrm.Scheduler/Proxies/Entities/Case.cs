using System;
using System.Linq;
using System.Diagnostics;
using System.ComponentModel;
using Microsoft.Xrm.Sdk; 
using Microsoft.Xrm.Sdk.Client;
using System.Collections.Generic;

namespace PentaWork.Xrm.Scheduler.Proxies.Entities
{
	[DebuggerDisplay("{CaseTitle}")] 	
	[EntityLogicalName("incident")]
	public sealed class Case : Entity
	{	
		public static readonly int? EntityTypeCode = 112;
		public new const string LogicalName = "incident";
		public const string PrimaryIdAttribute = "incidentid";
		public const string PrimaryNameAttribute = "title";
	
		public Case() : base("incident") { }

		#region Attributes
		/// <summary>
        /// accountid
        /// </summary>
		[DisplayName("Account")]
		[AttributeLogicalName("accountid")]
		public EntityReference Account
		{	
			get { return GetAttributeValue<EntityReference>("accountid"); }
			set
			{ 
				if(value == Account) return;
				SetAttributeValue("accountid", value);
			}
		}	
			
		/// <summary>
        /// accountidname
        /// </summary>
		[DisplayName("accountidname")]
		[AttributeLogicalName("accountidname")]
		public string Accountidname
		{	
			get { return GetAttributeValue<string>("accountidname"); }
			set
			{ 
				if(value == Accountidname) return;
				SetAttributeValue("accountidname", value);
			}
		}	
			
		/// <summary>
        /// accountidyominame
        /// </summary>
		[DisplayName("accountidyominame")]
		[AttributeLogicalName("accountidyominame")]
		public string Accountidyominame
		{	
			get { return GetAttributeValue<string>("accountidyominame"); }
			set
			{ 
				if(value == Accountidyominame) return;
				SetAttributeValue("accountidyominame", value);
			}
		}	
			
		/// <summary>
        /// activitiescomplete
        /// </summary>
		[DisplayName("Activities Complete")]
		[AttributeLogicalName("activitiescomplete")]
		public bool? ActivitiesComplete
		{	
			get { return GetAttributeValue<bool?>("activitiescomplete"); }
			set
			{ 
				if(value == ActivitiesComplete) return;
				SetAttributeValue("activitiescomplete", value);
			}
		}	
			
		/// <summary>
        /// actualserviceunits
        /// </summary>
		[DisplayName("Actual Service Units")]
		[AttributeLogicalName("actualserviceunits")]
		public int? ActualServiceUnits
		{	
			get { return GetAttributeValue<int?>("actualserviceunits"); }
			set
			{ 
				if(value == ActualServiceUnits) return;
				SetAttributeValue("actualserviceunits", value);
			}
		}	
			
		/// <summary>
        /// billedserviceunits
        /// </summary>
		[DisplayName("Billed Service Units")]
		[AttributeLogicalName("billedserviceunits")]
		public int? BilledServiceUnits
		{	
			get { return GetAttributeValue<int?>("billedserviceunits"); }
			set
			{ 
				if(value == BilledServiceUnits) return;
				SetAttributeValue("billedserviceunits", value);
			}
		}	
			
		/// <summary>
        /// blockedprofile
        /// </summary>
		[DisplayName("Blocked Profile")]
		[AttributeLogicalName("blockedprofile")]
		public bool? BlockedProfile
		{	
			get { return GetAttributeValue<bool?>("blockedprofile"); }
			set
			{ 
				if(value == BlockedProfile) return;
				SetAttributeValue("blockedprofile", value);
			}
		}	
			
		/// <summary>
        /// caseorigincode
        /// </summary>
		[DisplayName("Origin")]
		[AttributeLogicalName("caseorigincode")]
		public egCaseOrigin? Origin
		{	
			get 
			{ 
				var optionSetValue = GetAttributeValue<OptionSetValue>("caseorigincode");
				if (optionSetValue != null) return (egCaseOrigin)optionSetValue.Value;
				else return null;
			}
			set 
			{ 
				if(value == Origin) return;

				OptionSetValue optionSetValue = null;
				if(value != null) optionSetValue = new OptionSetValue((int)value);
				SetAttributeValue("caseorigincode", optionSetValue); 
			}
		}

		/// <summary>
        /// casetypecode
        /// </summary>
		[DisplayName("Case Type")]
		[AttributeLogicalName("casetypecode")]
		public eCaseType? CaseType
		{	
			get 
			{ 
				var optionSetValue = GetAttributeValue<OptionSetValue>("casetypecode");
				if (optionSetValue != null) return (eCaseType)optionSetValue.Value;
				else return null;
			}
			set 
			{ 
				if(value == CaseType) return;

				OptionSetValue optionSetValue = null;
				if(value != null) optionSetValue = new OptionSetValue((int)value);
				SetAttributeValue("casetypecode", optionSetValue); 
			}
		}

		/// <summary>
        /// checkemail
        /// </summary>
		[DisplayName("Check Email")]
		[AttributeLogicalName("checkemail")]
		public bool? CheckEmail
		{	
			get { return GetAttributeValue<bool?>("checkemail"); }
			set
			{ 
				if(value == CheckEmail) return;
				SetAttributeValue("checkemail", value);
			}
		}	
			
		/// <summary>
        /// contactid
        /// </summary>
		[DisplayName("Contact")]
		[AttributeLogicalName("contactid")]
		public EntityReference Contact
		{	
			get { return GetAttributeValue<EntityReference>("contactid"); }
			set
			{ 
				if(value == Contact) return;
				SetAttributeValue("contactid", value);
			}
		}	
			
		/// <summary>
        /// contactidname
        /// </summary>
		[DisplayName("contactidname")]
		[AttributeLogicalName("contactidname")]
		public string Contactidname
		{	
			get { return GetAttributeValue<string>("contactidname"); }
			set
			{ 
				if(value == Contactidname) return;
				SetAttributeValue("contactidname", value);
			}
		}	
			
		/// <summary>
        /// contactidyominame
        /// </summary>
		[DisplayName("contactidyominame")]
		[AttributeLogicalName("contactidyominame")]
		public string Contactidyominame
		{	
			get { return GetAttributeValue<string>("contactidyominame"); }
			set
			{ 
				if(value == Contactidyominame) return;
				SetAttributeValue("contactidyominame", value);
			}
		}	
			
		/// <summary>
        /// contractdetailid
        /// </summary>
		[DisplayName("Contract Line")]
		[AttributeLogicalName("contractdetailid")]
		public EntityReference ContractLine
		{	
			get { return GetAttributeValue<EntityReference>("contractdetailid"); }
			set
			{ 
				if(value == ContractLine) return;
				SetAttributeValue("contractdetailid", value);
			}
		}	
			
		/// <summary>
        /// contractdetailidname
        /// </summary>
		[DisplayName("contractdetailidname")]
		[AttributeLogicalName("contractdetailidname")]
		public string Contractdetailidname
		{	
			get { return GetAttributeValue<string>("contractdetailidname"); }
			set
			{ 
				if(value == Contractdetailidname) return;
				SetAttributeValue("contractdetailidname", value);
			}
		}	
			
		/// <summary>
        /// contractid
        /// </summary>
		[DisplayName("Contract")]
		[AttributeLogicalName("contractid")]
		public EntityReference Contract
		{	
			get { return GetAttributeValue<EntityReference>("contractid"); }
			set
			{ 
				if(value == Contract) return;
				SetAttributeValue("contractid", value);
			}
		}	
			
		/// <summary>
        /// contractidname
        /// </summary>
		[DisplayName("contractidname")]
		[AttributeLogicalName("contractidname")]
		public string Contractidname
		{	
			get { return GetAttributeValue<string>("contractidname"); }
			set
			{ 
				if(value == Contractidname) return;
				SetAttributeValue("contractidname", value);
			}
		}	
			
		/// <summary>
        /// contractservicelevelcode
        /// </summary>
		[DisplayName("Service Level")]
		[AttributeLogicalName("contractservicelevelcode")]
		public eServiceLevel? ServiceLevel
		{	
			get 
			{ 
				var optionSetValue = GetAttributeValue<OptionSetValue>("contractservicelevelcode");
				if (optionSetValue != null) return (eServiceLevel)optionSetValue.Value;
				else return null;
			}
			set 
			{ 
				if(value == ServiceLevel) return;

				OptionSetValue optionSetValue = null;
				if(value != null) optionSetValue = new OptionSetValue((int)value);
				SetAttributeValue("contractservicelevelcode", optionSetValue); 
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
        /// customercontacted
        /// </summary>
		[DisplayName("Customer Contacted")]
		[AttributeLogicalName("customercontacted")]
		public bool? CustomerContacted
		{	
			get { return GetAttributeValue<bool?>("customercontacted"); }
			set
			{ 
				if(value == CustomerContacted) return;
				SetAttributeValue("customercontacted", value);
			}
		}	
			
		/// <summary>
        /// customerid
        /// </summary>
		[DisplayName("Customer")]
		[AttributeLogicalName("customerid")]
		public EntityReference Customer
		{	
			get { return GetAttributeValue<EntityReference>("customerid"); }
			set
			{ 
				if(value == Customer) return;
				SetAttributeValue("customerid", value);
			}
		}	
			
		/// <summary>
        /// customeridname
        /// </summary>
		[DisplayName("customeridname")]
		[AttributeLogicalName("customeridname")]
		public string Customeridname
		{	
			get { return GetAttributeValue<string>("customeridname"); }
			set
			{ 
				if(value == Customeridname) return;
				SetAttributeValue("customeridname", value);
			}
		}	
			
		/// <summary>
        /// customeridtype
        /// </summary>
		[DisplayName("Customer Type")]
		[AttributeLogicalName("customeridtype")]
		public string CustomerType
		{	
			get { return GetAttributeValue<string>("customeridtype"); }
			set
			{ 
				if(value == CustomerType) return;
				SetAttributeValue("customeridtype", value);
			}
		}	
			
		/// <summary>
        /// customeridyominame
        /// </summary>
		[DisplayName("customeridyominame")]
		[AttributeLogicalName("customeridyominame")]
		public string Customeridyominame
		{	
			get { return GetAttributeValue<string>("customeridyominame"); }
			set
			{ 
				if(value == Customeridyominame) return;
				SetAttributeValue("customeridyominame", value);
			}
		}	
			
		/// <summary>
        /// customersatisfactioncode
        /// </summary>
		[DisplayName("Satisfaction")]
		[AttributeLogicalName("customersatisfactioncode")]
		public eSatisfaction? Satisfaction
		{	
			get 
			{ 
				var optionSetValue = GetAttributeValue<OptionSetValue>("customersatisfactioncode");
				if (optionSetValue != null) return (eSatisfaction)optionSetValue.Value;
				else return null;
			}
			set 
			{ 
				if(value == Satisfaction) return;

				OptionSetValue optionSetValue = null;
				if(value != null) optionSetValue = new OptionSetValue((int)value);
				SetAttributeValue("customersatisfactioncode", optionSetValue); 
			}
		}

		/// <summary>
        /// decremententitlementterm
        /// </summary>
		[DisplayName("Decrement Entitlement Terms")]
		[AttributeLogicalName("decremententitlementterm")]
		public bool? DecrementEntitlementTerms
		{	
			get { return GetAttributeValue<bool?>("decremententitlementterm"); }
			set
			{ 
				if(value == DecrementEntitlementTerms) return;
				SetAttributeValue("decremententitlementterm", value);
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
        /// entitlementid
        /// </summary>
		[DisplayName("Entitlement")]
		[AttributeLogicalName("entitlementid")]
		public EntityReference Entitlement
		{	
			get { return GetAttributeValue<EntityReference>("entitlementid"); }
			set
			{ 
				if(value == Entitlement) return;
				SetAttributeValue("entitlementid", value);
			}
		}	
			
		/// <summary>
        /// entitlementidname
        /// </summary>
		[DisplayName("entitlementidname")]
		[AttributeLogicalName("entitlementidname")]
		public string Entitlementidname
		{	
			get { return GetAttributeValue<string>("entitlementidname"); }
			set
			{ 
				if(value == Entitlementidname) return;
				SetAttributeValue("entitlementidname", value);
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
		[DisplayName("entityimageid")]
		[AttributeLogicalName("entityimageid")]
		public Guid EntityimageId
		{	
			get { return GetAttributeValue<Guid>("entityimageid"); }
			set
			{ 
				if(value == EntityimageId) return;
				SetAttributeValue("entityimageid", value);
			}
		}	
			
		/// <summary>
        /// escalatedon
        /// </summary>
		[DisplayName("Escalated On")]
		[AttributeLogicalName("escalatedon")]
		public DateTime? EscalatedOn
		{	
			get { return GetAttributeValue<DateTime?>("escalatedon"); }
			set
			{ 
				if(value == EscalatedOn) return;
				SetAttributeValue("escalatedon", value);
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
        /// existingcase
        /// </summary>
		[DisplayName("Existing Case")]
		[AttributeLogicalName("existingcase")]
		public EntityReference ExistingCase
		{	
			get { return GetAttributeValue<EntityReference>("existingcase"); }
			set
			{ 
				if(value == ExistingCase) return;
				SetAttributeValue("existingcase", value);
			}
		}	
			
		/// <summary>
        /// firstresponsebykpiid
        /// </summary>
		[DisplayName("First Response By KPI")]
		[AttributeLogicalName("firstresponsebykpiid")]
		public EntityReference FirstResponseByKPI
		{	
			get { return GetAttributeValue<EntityReference>("firstresponsebykpiid"); }
			set
			{ 
				if(value == FirstResponseByKPI) return;
				SetAttributeValue("firstresponsebykpiid", value);
			}
		}	
			
		/// <summary>
        /// firstresponsebykpiidname
        /// </summary>
		[DisplayName("firstresponsebykpiidname")]
		[AttributeLogicalName("firstresponsebykpiidname")]
		public string Firstresponsebykpiidname
		{	
			get { return GetAttributeValue<string>("firstresponsebykpiidname"); }
			set
			{ 
				if(value == Firstresponsebykpiidname) return;
				SetAttributeValue("firstresponsebykpiidname", value);
			}
		}	
			
		/// <summary>
        /// firstresponsesent
        /// </summary>
		[DisplayName("First Response Sent")]
		[AttributeLogicalName("firstresponsesent")]
		public bool? FirstResponseSent
		{	
			get { return GetAttributeValue<bool?>("firstresponsesent"); }
			set
			{ 
				if(value == FirstResponseSent) return;
				SetAttributeValue("firstresponsesent", value);
			}
		}	
			
		/// <summary>
        /// firstresponseslastatus
        /// </summary>
		[DisplayName("First Response SLA Status")]
		[AttributeLogicalName("firstresponseslastatus")]
		public eFirstResponseSLAStatus? FirstResponseSLAStatus
		{	
			get 
			{ 
				var optionSetValue = GetAttributeValue<OptionSetValue>("firstresponseslastatus");
				if (optionSetValue != null) return (eFirstResponseSLAStatus)optionSetValue.Value;
				else return null;
			}
			set 
			{ 
				if(value == FirstResponseSLAStatus) return;

				OptionSetValue optionSetValue = null;
				if(value != null) optionSetValue = new OptionSetValue((int)value);
				SetAttributeValue("firstresponseslastatus", optionSetValue); 
			}
		}

		/// <summary>
        /// followupby
        /// </summary>
		[DisplayName("Follow Up By")]
		[AttributeLogicalName("followupby")]
		public DateTime? FollowUpBy
		{	
			get { return GetAttributeValue<DateTime?>("followupby"); }
			set
			{ 
				if(value == FollowUpBy) return;
				SetAttributeValue("followupby", value);
			}
		}	
			
		/// <summary>
        /// followuptaskcreated
        /// </summary>
		[DisplayName("Follow up Task Created")]
		[AttributeLogicalName("followuptaskcreated")]
		public bool? FollowUpTaskCreated
		{	
			get { return GetAttributeValue<bool?>("followuptaskcreated"); }
			set
			{ 
				if(value == FollowUpTaskCreated) return;
				SetAttributeValue("followuptaskcreated", value);
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
        /// incidentid
        /// </summary>
		[DisplayName("Case")]
		[AttributeLogicalName("incidentid")]
		public override Guid Id
		{
			get => base.Id;
			set { base.Id = value; SetAttributeValue("incidentid", value); }
		}

							/// <summary>
        /// incidentstagecode
        /// </summary>
		[DisplayName("Case Stage")]
		[AttributeLogicalName("incidentstagecode")]
		public eCaseStage? CaseStage
		{	
			get 
			{ 
				var optionSetValue = GetAttributeValue<OptionSetValue>("incidentstagecode");
				if (optionSetValue != null) return (eCaseStage)optionSetValue.Value;
				else return null;
			}
			set 
			{ 
				if(value == CaseStage) return;

				OptionSetValue optionSetValue = null;
				if(value != null) optionSetValue = new OptionSetValue((int)value);
				SetAttributeValue("incidentstagecode", optionSetValue); 
			}
		}

		/// <summary>
        /// influencescore
        /// </summary>
		[DisplayName("Influence Score")]
		[AttributeLogicalName("influencescore")]
		public double? InfluenceScore
		{	
			get { return GetAttributeValue<double?>("influencescore"); }
			set
			{ 
				if(value == InfluenceScore) return;
				SetAttributeValue("influencescore", value);
			}
		}	
			
		/// <summary>
        /// isdecrementing
        /// </summary>
		[DisplayName("Decrementing")]
		[AttributeLogicalName("isdecrementing")]
		public bool? Decrementing
		{	
			get { return GetAttributeValue<bool?>("isdecrementing"); }
			set
			{ 
				if(value == Decrementing) return;
				SetAttributeValue("isdecrementing", value);
			}
		}	
			
		/// <summary>
        /// isescalated
        /// </summary>
		[DisplayName("Is Escalated")]
		[AttributeLogicalName("isescalated")]
		public bool? IsEscalated
		{	
			get { return GetAttributeValue<bool?>("isescalated"); }
			set
			{ 
				if(value == IsEscalated) return;
				SetAttributeValue("isescalated", value);
			}
		}	
			
		/// <summary>
        /// kbarticleid
        /// </summary>
		[DisplayName("Knowledge Base Article")]
		[AttributeLogicalName("kbarticleid")]
		public EntityReference KnowledgeBaseArticle
		{	
			get { return GetAttributeValue<EntityReference>("kbarticleid"); }
			set
			{ 
				if(value == KnowledgeBaseArticle) return;
				SetAttributeValue("kbarticleid", value);
			}
		}	
			
		/// <summary>
        /// kbarticleidname
        /// </summary>
		[DisplayName("kbarticleidname")]
		[AttributeLogicalName("kbarticleidname")]
		public string Kbarticleidname
		{	
			get { return GetAttributeValue<string>("kbarticleidname"); }
			set
			{ 
				if(value == Kbarticleidname) return;
				SetAttributeValue("kbarticleidname", value);
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
        /// masterid
        /// </summary>
		[DisplayName("Master Case")]
		[AttributeLogicalName("masterid")]
		public EntityReference MasterCase
		{	
			get { return GetAttributeValue<EntityReference>("masterid"); }
			set
			{ 
				if(value == MasterCase) return;
				SetAttributeValue("masterid", value);
			}
		}	
			
		/// <summary>
        /// masteridname
        /// </summary>
		[DisplayName("masteridname")]
		[AttributeLogicalName("masteridname")]
		public string Masteridname
		{	
			get { return GetAttributeValue<string>("masteridname"); }
			set
			{ 
				if(value == Masteridname) return;
				SetAttributeValue("masteridname", value);
			}
		}	
			
		/// <summary>
        /// merged
        /// </summary>
		[DisplayName("Internal Use Only")]
		[AttributeLogicalName("merged")]
		public bool? InternalUseOnly
		{	
			get { return GetAttributeValue<bool?>("merged"); }
			set
			{ 
				if(value == InternalUseOnly) return;
				SetAttributeValue("merged", value);
			}
		}	
			
		/// <summary>
        /// messagetypecode
        /// </summary>
		[DisplayName("Received As")]
		[AttributeLogicalName("messagetypecode")]
		public egPostMessageType? ReceivedAs
		{	
			get 
			{ 
				var optionSetValue = GetAttributeValue<OptionSetValue>("messagetypecode");
				if (optionSetValue != null) return (egPostMessageType)optionSetValue.Value;
				else return null;
			}
			set 
			{ 
				if(value == ReceivedAs) return;

				OptionSetValue optionSetValue = null;
				if(value != null) optionSetValue = new OptionSetValue((int)value);
				SetAttributeValue("messagetypecode", optionSetValue); 
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
        /// numberofchildincidents
        /// </summary>
		[DisplayName("Child Cases")]
		[AttributeLogicalName("numberofchildincidents")]
		public int? ChildCases
		{	
			get { return GetAttributeValue<int?>("numberofchildincidents"); }
			set
			{ 
				if(value == ChildCases) return;
				SetAttributeValue("numberofchildincidents", value);
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
        /// parentcaseid
        /// </summary>
		[DisplayName("Parent Case")]
		[AttributeLogicalName("parentcaseid")]
		public EntityReference ParentCase
		{	
			get { return GetAttributeValue<EntityReference>("parentcaseid"); }
			set
			{ 
				if(value == ParentCase) return;
				SetAttributeValue("parentcaseid", value);
			}
		}	
			
		/// <summary>
        /// parentcaseidname
        /// </summary>
		[DisplayName("parentcaseidname")]
		[AttributeLogicalName("parentcaseidname")]
		public string Parentcaseidname
		{	
			get { return GetAttributeValue<string>("parentcaseidname"); }
			set
			{ 
				if(value == Parentcaseidname) return;
				SetAttributeValue("parentcaseidname", value);
			}
		}	
			
		/// <summary>
        /// primarycontactid
        /// </summary>
		[DisplayName("Contact")]
		[AttributeLogicalName("primarycontactid")]
		public EntityReference Contact2
		{	
			get { return GetAttributeValue<EntityReference>("primarycontactid"); }
			set
			{ 
				if(value == Contact2) return;
				SetAttributeValue("primarycontactid", value);
			}
		}	
			
		/// <summary>
        /// primarycontactidname
        /// </summary>
		[DisplayName("primarycontactidname")]
		[AttributeLogicalName("primarycontactidname")]
		public string Primarycontactidname
		{	
			get { return GetAttributeValue<string>("primarycontactidname"); }
			set
			{ 
				if(value == Primarycontactidname) return;
				SetAttributeValue("primarycontactidname", value);
			}
		}	
			
		/// <summary>
        /// primarycontactidyominame
        /// </summary>
		[DisplayName("primarycontactidyominame")]
		[AttributeLogicalName("primarycontactidyominame")]
		public string Primarycontactidyominame
		{	
			get { return GetAttributeValue<string>("primarycontactidyominame"); }
			set
			{ 
				if(value == Primarycontactidyominame) return;
				SetAttributeValue("primarycontactidyominame", value);
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
		[DisplayName("Process Id")]
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
        /// productid
        /// </summary>
		[DisplayName("Product")]
		[AttributeLogicalName("productid")]
		public EntityReference Product
		{	
			get { return GetAttributeValue<EntityReference>("productid"); }
			set
			{ 
				if(value == Product) return;
				SetAttributeValue("productid", value);
			}
		}	
			
		/// <summary>
        /// productidname
        /// </summary>
		[DisplayName("productidname")]
		[AttributeLogicalName("productidname")]
		public string Productidname
		{	
			get { return GetAttributeValue<string>("productidname"); }
			set
			{ 
				if(value == Productidname) return;
				SetAttributeValue("productidname", value);
			}
		}	
			
		/// <summary>
        /// productserialnumber
        /// </summary>
		[DisplayName("Serial Number")]
		[AttributeLogicalName("productserialnumber")]
		public string SerialNumber
		{	
			get { return GetAttributeValue<string>("productserialnumber"); }
			set
			{ 
				if(value == SerialNumber) return;
				SetAttributeValue("productserialnumber", value);
			}
		}	
			
		/// <summary>
        /// resolveby
        /// </summary>
		[DisplayName("Resolve By")]
		[AttributeLogicalName("resolveby")]
		public DateTime? ResolveBy
		{	
			get { return GetAttributeValue<DateTime?>("resolveby"); }
			set
			{ 
				if(value == ResolveBy) return;
				SetAttributeValue("resolveby", value);
			}
		}	
			
		/// <summary>
        /// resolvebykpiid
        /// </summary>
		[DisplayName("Resolve By KPI")]
		[AttributeLogicalName("resolvebykpiid")]
		public EntityReference ResolveByKPI
		{	
			get { return GetAttributeValue<EntityReference>("resolvebykpiid"); }
			set
			{ 
				if(value == ResolveByKPI) return;
				SetAttributeValue("resolvebykpiid", value);
			}
		}	
			
		/// <summary>
        /// resolvebykpiidname
        /// </summary>
		[DisplayName("resolvebykpiidname")]
		[AttributeLogicalName("resolvebykpiidname")]
		public string Resolvebykpiidname
		{	
			get { return GetAttributeValue<string>("resolvebykpiidname"); }
			set
			{ 
				if(value == Resolvebykpiidname) return;
				SetAttributeValue("resolvebykpiidname", value);
			}
		}	
			
		/// <summary>
        /// resolvebyslastatus
        /// </summary>
		[DisplayName("Resolve By SLA Status")]
		[AttributeLogicalName("resolvebyslastatus")]
		public eResolveBySLAStatus? ResolveBySLAStatus
		{	
			get 
			{ 
				var optionSetValue = GetAttributeValue<OptionSetValue>("resolvebyslastatus");
				if (optionSetValue != null) return (eResolveBySLAStatus)optionSetValue.Value;
				else return null;
			}
			set 
			{ 
				if(value == ResolveBySLAStatus) return;

				OptionSetValue optionSetValue = null;
				if(value != null) optionSetValue = new OptionSetValue((int)value);
				SetAttributeValue("resolvebyslastatus", optionSetValue); 
			}
		}

		/// <summary>
        /// responseby
        /// </summary>
		[DisplayName("First Response By")]
		[AttributeLogicalName("responseby")]
		public DateTime? FirstResponseBy
		{	
			get { return GetAttributeValue<DateTime?>("responseby"); }
			set
			{ 
				if(value == FirstResponseBy) return;
				SetAttributeValue("responseby", value);
			}
		}	
			
		/// <summary>
        /// responsiblecontactid
        /// </summary>
		[DisplayName("Responsible Contact")]
		[AttributeLogicalName("responsiblecontactid")]
		public EntityReference ResponsibleContact
		{	
			get { return GetAttributeValue<EntityReference>("responsiblecontactid"); }
			set
			{ 
				if(value == ResponsibleContact) return;
				SetAttributeValue("responsiblecontactid", value);
			}
		}	
			
		/// <summary>
        /// responsiblecontactidname
        /// </summary>
		[DisplayName("responsiblecontactidname")]
		[AttributeLogicalName("responsiblecontactidname")]
		public string Responsiblecontactidname
		{	
			get { return GetAttributeValue<string>("responsiblecontactidname"); }
			set
			{ 
				if(value == Responsiblecontactidname) return;
				SetAttributeValue("responsiblecontactidname", value);
			}
		}	
			
		/// <summary>
        /// responsiblecontactidyominame
        /// </summary>
		[DisplayName("responsiblecontactidyominame")]
		[AttributeLogicalName("responsiblecontactidyominame")]
		public string Responsiblecontactidyominame
		{	
			get { return GetAttributeValue<string>("responsiblecontactidyominame"); }
			set
			{ 
				if(value == Responsiblecontactidyominame) return;
				SetAttributeValue("responsiblecontactidyominame", value);
			}
		}	
			
		/// <summary>
        /// routecase
        /// </summary>
		[DisplayName("Route Case")]
		[AttributeLogicalName("routecase")]
		public bool? RouteCase
		{	
			get { return GetAttributeValue<bool?>("routecase"); }
			set
			{ 
				if(value == RouteCase) return;
				SetAttributeValue("routecase", value);
			}
		}	
			
		/// <summary>
        /// sentimentvalue
        /// </summary>
		[DisplayName("Sentiment Value")]
		[AttributeLogicalName("sentimentvalue")]
		public double? SentimentValue
		{	
			get { return GetAttributeValue<double?>("sentimentvalue"); }
			set
			{ 
				if(value == SentimentValue) return;
				SetAttributeValue("sentimentvalue", value);
			}
		}	
			
		/// <summary>
        /// servicestage
        /// </summary>
		[DisplayName("Service Stage")]
		[AttributeLogicalName("servicestage")]
		public egServiceStage? ServiceStage
		{	
			get 
			{ 
				var optionSetValue = GetAttributeValue<OptionSetValue>("servicestage");
				if (optionSetValue != null) return (egServiceStage)optionSetValue.Value;
				else return null;
			}
			set 
			{ 
				if(value == ServiceStage) return;

				OptionSetValue optionSetValue = null;
				if(value != null) optionSetValue = new OptionSetValue((int)value);
				SetAttributeValue("servicestage", optionSetValue); 
			}
		}

		/// <summary>
        /// severitycode
        /// </summary>
		[DisplayName("Severity")]
		[AttributeLogicalName("severitycode")]
		public eSeverity? Severity
		{	
			get 
			{ 
				var optionSetValue = GetAttributeValue<OptionSetValue>("severitycode");
				if (optionSetValue != null) return (eSeverity)optionSetValue.Value;
				else return null;
			}
			set 
			{ 
				if(value == Severity) return;

				OptionSetValue optionSetValue = null;
				if(value != null) optionSetValue = new OptionSetValue((int)value);
				SetAttributeValue("severitycode", optionSetValue); 
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
        /// socialprofileid
        /// </summary>
		[DisplayName("Social Profile")]
		[AttributeLogicalName("socialprofileid")]
		public EntityReference SocialProfile
		{	
			get { return GetAttributeValue<EntityReference>("socialprofileid"); }
			set
			{ 
				if(value == SocialProfile) return;
				SetAttributeValue("socialprofileid", value);
			}
		}	
			
		/// <summary>
        /// socialprofileidname
        /// </summary>
		[DisplayName("socialprofileidname")]
		[AttributeLogicalName("socialprofileidname")]
		public string Socialprofileidname
		{	
			get { return GetAttributeValue<string>("socialprofileidname"); }
			set
			{ 
				if(value == Socialprofileidname) return;
				SetAttributeValue("socialprofileidname", value);
			}
		}	
			
		/// <summary>
        /// stageid
        /// </summary>
		[DisplayName("(Deprecated) Stage Id")]
		[AttributeLogicalName("stageid")]
		public Guid DeprecatedStageId
		{	
			get { return GetAttributeValue<Guid>("stageid"); }
			set
			{ 
				if(value == DeprecatedStageId) return;
				SetAttributeValue("stageid", value);
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
        /// subjectid
        /// </summary>
		[DisplayName("Subject")]
		[AttributeLogicalName("subjectid")]
		public EntityReference Subject
		{	
			get { return GetAttributeValue<EntityReference>("subjectid"); }
			set
			{ 
				if(value == Subject) return;
				SetAttributeValue("subjectid", value);
			}
		}	
			
		/// <summary>
        /// subjectidname
        /// </summary>
		[DisplayName("subjectidname")]
		[AttributeLogicalName("subjectidname")]
		public string Subjectidname
		{	
			get { return GetAttributeValue<string>("subjectidname"); }
			set
			{ 
				if(value == Subjectidname) return;
				SetAttributeValue("subjectidname", value);
			}
		}	
			
		/// <summary>
        /// ticketnumber
        /// </summary>
		[DisplayName("Case Number")]
		[AttributeLogicalName("ticketnumber")]
		public string CaseNumber
		{	
			get { return GetAttributeValue<string>("ticketnumber"); }
			set
			{ 
				if(value == CaseNumber) return;
				SetAttributeValue("ticketnumber", value);
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
        /// title
        /// </summary>
		[DisplayName("Case Title")]
		[AttributeLogicalName("title")]
		public string CaseTitle
		{	
			get { return GetAttributeValue<string>("title"); }
			set
			{ 
				if(value == CaseTitle) return;
				SetAttributeValue("title", value);
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
        /// 1:N Get entities for 'incident_actioncard'
        /// </summary>
		[RelationshipSchemaName("incident_actioncard")]
		public IEnumerable<ActionCard> IncidentActioncard
		{
			get { return GetRelatedEntities<ActionCard>("incident_actioncard", null); }
			set { SetRelatedEntities("incident_actioncard", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'incident_activity_parties'
        /// </summary>
		[RelationshipSchemaName("incident_activity_parties")]
		public IEnumerable<ActivityParty> IncidentActivityParties
		{
			get { return GetRelatedEntities<ActivityParty>("incident_activity_parties", null); }
			set { SetRelatedEntities("incident_activity_parties", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'Incident_ActivityPointers'
        /// </summary>
		[RelationshipSchemaName("Incident_ActivityPointers")]
		public IEnumerable<Activity> IncidentActivityPointers
		{
			get { return GetRelatedEntities<Activity>("Incident_ActivityPointers", null); }
			set { SetRelatedEntities("Incident_ActivityPointers", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'Incident_Annotation'
        /// </summary>
		[RelationshipSchemaName("Incident_Annotation")]
		public IEnumerable<Note> IncidentAnnotation
		{
			get { return GetRelatedEntities<Note>("Incident_Annotation", null); }
			set { SetRelatedEntities("Incident_Annotation", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'Incident_Appointments'
        /// </summary>
		[RelationshipSchemaName("Incident_Appointments")]
		public IEnumerable<Appointment> IncidentAppointments
		{
			get { return GetRelatedEntities<Appointment>("Incident_Appointments", null); }
			set { SetRelatedEntities("Incident_Appointments", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'Incident_AsyncOperations'
        /// </summary>
		[RelationshipSchemaName("Incident_AsyncOperations")]
		public IEnumerable<SystemJob> IncidentAsyncOperations
		{
			get { return GetRelatedEntities<SystemJob>("Incident_AsyncOperations", null); }
			set { SetRelatedEntities("Incident_AsyncOperations", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'Incident_BulkDeleteFailures'
        /// </summary>
		[RelationshipSchemaName("Incident_BulkDeleteFailures")]
		public IEnumerable<BulkDeleteFailure> IncidentBulkDeleteFailures
		{
			get { return GetRelatedEntities<BulkDeleteFailure>("Incident_BulkDeleteFailures", null); }
			set { SetRelatedEntities("Incident_BulkDeleteFailures", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'incident_connections1'
        /// </summary>
		[RelationshipSchemaName("incident_connections1")]
		public IEnumerable<Connection> IncidentConnections1
		{
			get { return GetRelatedEntities<Connection>("incident_connections1", null); }
			set { SetRelatedEntities("incident_connections1", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'incident_connections2'
        /// </summary>
		[RelationshipSchemaName("incident_connections2")]
		public IEnumerable<Connection> IncidentConnections2
		{
			get { return GetRelatedEntities<Connection>("incident_connections2", null); }
			set { SetRelatedEntities("incident_connections2", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'Incident_DuplicateBaseRecord'
        /// </summary>
		[RelationshipSchemaName("Incident_DuplicateBaseRecord")]
		public IEnumerable<DuplicateRecord> IncidentDuplicateBaseRecord
		{
			get { return GetRelatedEntities<DuplicateRecord>("Incident_DuplicateBaseRecord", null); }
			set { SetRelatedEntities("Incident_DuplicateBaseRecord", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'Incident_DuplicateMatchingRecord'
        /// </summary>
		[RelationshipSchemaName("Incident_DuplicateMatchingRecord")]
		public IEnumerable<DuplicateRecord> IncidentDuplicateMatchingRecord
		{
			get { return GetRelatedEntities<DuplicateRecord>("Incident_DuplicateMatchingRecord", null); }
			set { SetRelatedEntities("Incident_DuplicateMatchingRecord", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'Incident_Emails'
        /// </summary>
		[RelationshipSchemaName("Incident_Emails")]
		public IEnumerable<Email> IncidentEmails
		{
			get { return GetRelatedEntities<Email>("Incident_Emails", null); }
			set { SetRelatedEntities("Incident_Emails", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'incident_existingcase'
        /// </summary>
		[RelationshipSchemaName("incident_existingcase")]
		public IEnumerable<Case> IncidentExistingcase
		{
			get { return GetRelatedEntities<Case>("incident_existingcase", null); }
			set { SetRelatedEntities("incident_existingcase", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'Incident_Faxes'
        /// </summary>
		[RelationshipSchemaName("Incident_Faxes")]
		public IEnumerable<Fax> IncidentFaxes
		{
			get { return GetRelatedEntities<Fax>("Incident_Faxes", null); }
			set { SetRelatedEntities("Incident_Faxes", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'Incident_IncidentResolutions'
        /// </summary>
		[RelationshipSchemaName("Incident_IncidentResolutions")]
		public IEnumerable<CaseResolution> IncidentIncidentResolutions
		{
			get { return GetRelatedEntities<CaseResolution>("Incident_IncidentResolutions", null); }
			set { SetRelatedEntities("Incident_IncidentResolutions", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'Incident_Letters'
        /// </summary>
		[RelationshipSchemaName("Incident_Letters")]
		public IEnumerable<Letter> IncidentLetters
		{
			get { return GetRelatedEntities<Letter>("Incident_Letters", null); }
			set { SetRelatedEntities("Incident_Letters", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'Incident_MailboxTrackingFolder'
        /// </summary>
		[RelationshipSchemaName("Incident_MailboxTrackingFolder")]
		public IEnumerable<MailboxAutoTrackingFolder> IncidentMailboxTrackingFolder
		{
			get { return GetRelatedEntities<MailboxAutoTrackingFolder>("Incident_MailboxTrackingFolder", null); }
			set { SetRelatedEntities("Incident_MailboxTrackingFolder", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'incident_master_incident'
        /// </summary>
		[RelationshipSchemaName("incident_master_incident")]
		public IEnumerable<Case> IncidentMasterIncident
		{
			get { return GetRelatedEntities<Case>("incident_master_incident", null); }
			set { SetRelatedEntities("incident_master_incident", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'incident_OpportunityCloses'
        /// </summary>
		[RelationshipSchemaName("incident_OpportunityCloses")]
		public IEnumerable<OpportunityClose> IncidentOpportunityCloses
		{
			get { return GetRelatedEntities<OpportunityClose>("incident_OpportunityCloses", null); }
			set { SetRelatedEntities("incident_OpportunityCloses", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'incident_OrderCloses'
        /// </summary>
		[RelationshipSchemaName("incident_OrderCloses")]
		public IEnumerable<OrderClose> IncidentOrderCloses
		{
			get { return GetRelatedEntities<OrderClose>("incident_OrderCloses", null); }
			set { SetRelatedEntities("incident_OrderCloses", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'incident_parent_incident'
        /// </summary>
		[RelationshipSchemaName("incident_parent_incident")]
		public IEnumerable<Case> IncidentParentIncident
		{
			get { return GetRelatedEntities<Case>("incident_parent_incident", null); }
			set { SetRelatedEntities("incident_parent_incident", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'Incident_Phonecalls'
        /// </summary>
		[RelationshipSchemaName("Incident_Phonecalls")]
		public IEnumerable<PhoneCall> IncidentPhonecalls
		{
			get { return GetRelatedEntities<PhoneCall>("Incident_Phonecalls", null); }
			set { SetRelatedEntities("Incident_Phonecalls", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'incident_PostFollows'
        /// </summary>
		[RelationshipSchemaName("incident_PostFollows")]
		public IEnumerable<Follow> IncidentPostFollows
		{
			get { return GetRelatedEntities<Follow>("incident_PostFollows", null); }
			set { SetRelatedEntities("incident_PostFollows", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'incident_principalobjectattributeaccess'
        /// </summary>
		[RelationshipSchemaName("incident_principalobjectattributeaccess")]
		public IEnumerable<FieldSharing> IncidentPrincipalobjectattributeaccess
		{
			get { return GetRelatedEntities<FieldSharing>("incident_principalobjectattributeaccess", null); }
			set { SetRelatedEntities("incident_principalobjectattributeaccess", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'Incident_ProcessSessions'
        /// </summary>
		[RelationshipSchemaName("Incident_ProcessSessions")]
		public IEnumerable<ProcessSession> IncidentProcessSessions
		{
			get { return GetRelatedEntities<ProcessSession>("Incident_ProcessSessions", null); }
			set { SetRelatedEntities("Incident_ProcessSessions", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'Incident_QueueItem'
        /// </summary>
		[RelationshipSchemaName("Incident_QueueItem")]
		public IEnumerable<QueueItem> IncidentQueueItem
		{
			get { return GetRelatedEntities<QueueItem>("Incident_QueueItem", null); }
			set { SetRelatedEntities("Incident_QueueItem", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'incident_QuoteCloses'
        /// </summary>
		[RelationshipSchemaName("incident_QuoteCloses")]
		public IEnumerable<QuoteClose> IncidentQuoteCloses
		{
			get { return GetRelatedEntities<QuoteClose>("incident_QuoteCloses", null); }
			set { SetRelatedEntities("incident_QuoteCloses", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'Incident_RecurringAppointmentMasters'
        /// </summary>
		[RelationshipSchemaName("Incident_RecurringAppointmentMasters")]
		public IEnumerable<RecurringAppointment> IncidentRecurringAppointmentMasters
		{
			get { return GetRelatedEntities<RecurringAppointment>("Incident_RecurringAppointmentMasters", null); }
			set { SetRelatedEntities("Incident_RecurringAppointmentMasters", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'Incident_ServiceAppointments'
        /// </summary>
		[RelationshipSchemaName("Incident_ServiceAppointments")]
		public IEnumerable<ServiceActivity> IncidentServiceAppointments
		{
			get { return GetRelatedEntities<ServiceActivity>("Incident_ServiceAppointments", null); }
			set { SetRelatedEntities("Incident_ServiceAppointments", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'Incident_SocialActivities'
        /// </summary>
		[RelationshipSchemaName("Incident_SocialActivities")]
		public IEnumerable<SocialActivity> IncidentSocialActivities
		{
			get { return GetRelatedEntities<SocialActivity>("Incident_SocialActivities", null); }
			set { SetRelatedEntities("Incident_SocialActivities", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'Incident_SyncErrors'
        /// </summary>
		[RelationshipSchemaName("Incident_SyncErrors")]
		public IEnumerable<SyncError> IncidentSyncErrors
		{
			get { return GetRelatedEntities<SyncError>("Incident_SyncErrors", null); }
			set { SetRelatedEntities("Incident_SyncErrors", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'Incident_Tasks'
        /// </summary>
		[RelationshipSchemaName("Incident_Tasks")]
		public IEnumerable<Task> IncidentTasks
		{
			get { return GetRelatedEntities<Task>("Incident_Tasks", null); }
			set { SetRelatedEntities("Incident_Tasks", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'knowledgearticle_incidents'
        /// </summary>
		[RelationshipSchemaName("knowledgearticle_incidents")]
		public IEnumerable<KnowledgeArticleIncident> KnowledgearticleIncidents
		{
			get { return GetRelatedEntities<KnowledgeArticleIncident>("knowledgearticle_incidents", null); }
			set { SetRelatedEntities("knowledgearticle_incidents", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_phonetocaseprocess_incidentid'
        /// </summary>
		[RelationshipSchemaName("lk_phonetocaseprocess_incidentid")]
		public IEnumerable<PhoneToCaseProcess> LkPhonetocaseprocessIncidentid
		{
			get { return GetRelatedEntities<PhoneToCaseProcess>("lk_phonetocaseprocess_incidentid", null); }
			set { SetRelatedEntities("lk_phonetocaseprocess_incidentid", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'OriginatingCase_Lead'
        /// </summary>
		[RelationshipSchemaName("OriginatingCase_Lead")]
		public IEnumerable<Lead> OriginatingCaseLead
		{
			get { return GetRelatedEntities<Lead>("OriginatingCase_Lead", null); }
			set { SetRelatedEntities("OriginatingCase_Lead", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'slakpiinstance_incident'
        /// </summary>
		[RelationshipSchemaName("slakpiinstance_incident")]
		public IEnumerable<SLAKPIInstance> SlakpiinstanceIncident
		{
			get { return GetRelatedEntities<SLAKPIInstance>("slakpiinstance_incident", null); }
			set { SetRelatedEntities("slakpiinstance_incident", null, value); }
		}
		/// <summary>
        /// N:N Get entities for 'KnowledgeBaseRecord'
        /// </summary>
		[RelationshipSchemaName("KnowledgeBaseRecord_Incident")]
		public IEnumerable<KnowledgeBaseRecord> KnowledgeBaseRecordIncident
		{
			get { return GetRelatedEntities<KnowledgeBaseRecord>("KnowledgeBaseRecord_Incident", null); }
			set { SetRelatedEntities("KnowledgeBaseRecord_Incident", null, value); }
		}
		#endregion

		#region Actions
		#endregion

		#region OptionSetEnums
		public enum egCaseOrigin
		{	
		
			[Label("Phone")]
			[Description(@"")]
			Phone = 1, 
		
			[Label("Email")]
			[Description(@"")]
			Email = 2, 
		
			[Label("Web")]
			[Description(@"")]
			Web = 3, 
		
			[Label("Facebook")]
			[Description(@"")]
			Facebook = 2483, 
		
			[Label("Twitter")]
			[Description(@"")]
			Twitter = 3986, 
		}
		
		public enum eCaseType
		{	
		
			[Label("Question")]
			[Description(@"")]
			Question = 1, 
		
			[Label("Problem")]
			[Description(@"")]
			Problem = 2, 
		
			[Label("Request")]
			[Description(@"")]
			Request = 3, 
		}
		
		public enum eServiceLevel
		{	
		
			[Label("Gold")]
			[Description(@"")]
			Gold = 1, 
		
			[Label("Silver")]
			[Description(@"")]
			Silver = 2, 
		
			[Label("Bronze")]
			[Description(@"")]
			Bronze = 3, 
		}
		
		public enum eSatisfaction
		{	
		
			[Label("Very Satisfied")]
			[Description(@"")]
			VerySatisfied = 5, 
		
			[Label("Satisfied")]
			[Description(@"")]
			Satisfied = 4, 
		
			[Label("Neutral")]
			[Description(@"")]
			Neutral = 3, 
		
			[Label("Dissatisfied")]
			[Description(@"")]
			Dissatisfied = 2, 
		
			[Label("Very Dissatisfied")]
			[Description(@"")]
			VeryDissatisfied = 1, 
		}
		
		public enum eFirstResponseSLAStatus
		{	
		
			[Label("In Progress")]
			[Description(@"")]
			InProgress = 1, 
		
			[Label("Nearing Noncompliance")]
			[Description(@"")]
			NearingNoncompliance = 2, 
		
			[Label("Succeeded")]
			[Description(@"")]
			Succeeded = 3, 
		
			[Label("Noncompliant")]
			[Description(@"")]
			Noncompliant = 4, 
		}
		
		public enum eCaseStage
		{	
		
			[Label("Default Value")]
			[Description(@"")]
			DefaultValue = 1, 
		}
		
		public enum ePriority
		{	
		
			[Label("High")]
			[Description(@"")]
			High = 1, 
		
			[Label("Normal")]
			[Description(@"")]
			Normal = 2, 
		
			[Label("Low")]
			[Description(@"")]
			Low = 3, 
		}
		
		public enum eResolveBySLAStatus
		{	
		
			[Label("In Progress")]
			[Description(@"")]
			InProgress = 1, 
		
			[Label("Nearing Noncompliance")]
			[Description(@"")]
			NearingNoncompliance = 2, 
		
			[Label("Succeeded")]
			[Description(@"")]
			Succeeded = 3, 
		
			[Label("Noncompliant")]
			[Description(@"")]
			Noncompliant = 4, 
		}
		
		public enum eSeverity
		{	
		
			[Label("Default Value")]
			[Description(@"")]
			DefaultValue = 1, 
		}
		
		public enum eStatus
		{	
		
			[Label("Active")]
			[Description(@"")]
			Active = 0, 
		
			[Label("Resolved")]
			[Description(@"")]
			Resolved = 1, 
		
			[Label("Cancelled")]
			[Description(@"")]
			Cancelled = 2, 
		}
		
		public enum eStatusReason
		{	
		
			[Label("Problem Solved")]
			[Description(@"")]
			ProblemSolved_Inactive = 5, 
		
			[Label("Information Provided")]
			[Description(@"")]
			InformationProvided_Inactive = 1000, 
		
			[Label("Cancelled")]
			[Description(@"")]
			Cancelled = 6, 
		
			[Label("Merged")]
			[Description(@"")]
			Merged = 2000, 
		
			[Label("In Progress")]
			[Description(@"")]
			InProgress_Active = 1, 
		
			[Label("On Hold")]
			[Description(@"")]
			OnHold_Active = 2, 
		
			[Label("Waiting for Details")]
			[Description(@"")]
			WaitingForDetails_Active = 3, 
		
			[Label("Researching")]
			[Description(@"")]
			Researching_Active = 4, 
		}
		
		public enum egServiceStage
		{	
		
			[Label("Identify")]
			[Description(@"")]
			Identify = 0, 
		
			[Label("Research")]
			[Description(@"")]
			Research = 1, 
		
			[Label("Resolve")]
			[Description(@"")]
			Resolve = 2, 
		}
		
		public enum egPostMessageType
		{	
		
			[Label("Public Message")]
			[Description(@"")]
			PublicMessage = 0, 
		
			[Label("Private Message")]
			[Description(@"")]
			PrivateMessage = 1, 
		}
		
		#endregion	

		#region Properties
		public static class Properties 
		{
			/// <summary>accountid</summary>
			public const string Account = "accountid";

			/// <summary>accountidname</summary>
			public const string Accountidname = "accountidname";

			/// <summary>accountidyominame</summary>
			public const string Accountidyominame = "accountidyominame";

			/// <summary>activitiescomplete</summary>
			public const string ActivitiesComplete = "activitiescomplete";

			/// <summary>actualserviceunits</summary>
			public const string ActualServiceUnits = "actualserviceunits";

			/// <summary>billedserviceunits</summary>
			public const string BilledServiceUnits = "billedserviceunits";

			/// <summary>blockedprofile</summary>
			public const string BlockedProfile = "blockedprofile";

			/// <summary>caseorigincode</summary>
			public const string Origin = "caseorigincode";

			/// <summary>casetypecode</summary>
			public const string CaseType = "casetypecode";

			/// <summary>checkemail</summary>
			public const string CheckEmail = "checkemail";

			/// <summary>contactid</summary>
			public const string Contact = "contactid";

			/// <summary>contactidname</summary>
			public const string Contactidname = "contactidname";

			/// <summary>contactidyominame</summary>
			public const string Contactidyominame = "contactidyominame";

			/// <summary>contractdetailid</summary>
			public const string ContractLine = "contractdetailid";

			/// <summary>contractdetailidname</summary>
			public const string Contractdetailidname = "contractdetailidname";

			/// <summary>contractid</summary>
			public const string Contract = "contractid";

			/// <summary>contractidname</summary>
			public const string Contractidname = "contractidname";

			/// <summary>contractservicelevelcode</summary>
			public const string ServiceLevel = "contractservicelevelcode";

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

			/// <summary>customercontacted</summary>
			public const string CustomerContacted = "customercontacted";

			/// <summary>customerid</summary>
			public const string Customer = "customerid";

			/// <summary>customeridname</summary>
			public const string Customeridname = "customeridname";

			/// <summary>customeridtype</summary>
			public const string CustomerType = "customeridtype";

			/// <summary>customeridyominame</summary>
			public const string Customeridyominame = "customeridyominame";

			/// <summary>customersatisfactioncode</summary>
			public const string Satisfaction = "customersatisfactioncode";

			/// <summary>decremententitlementterm</summary>
			public const string DecrementEntitlementTerms = "decremententitlementterm";

			/// <summary>description</summary>
			public const string Description = "description";

			/// <summary>emailaddress</summary>
			public const string EmailAddress = "emailaddress";

			/// <summary>entitlementid</summary>
			public const string Entitlement = "entitlementid";

			/// <summary>entitlementidname</summary>
			public const string Entitlementidname = "entitlementidname";

			/// <summary>entityimage_timestamp</summary>
			public const string EntityimageTimestamp = "entityimage_timestamp";

			/// <summary>entityimage_url</summary>
			public const string EntityimageUrl = "entityimage_url";

			/// <summary>entityimageid</summary>
			public const string EntityimageId = "entityimageid";

			/// <summary>escalatedon</summary>
			public const string EscalatedOn = "escalatedon";

			/// <summary>exchangerate</summary>
			public const string ExchangeRate = "exchangerate";

			/// <summary>existingcase</summary>
			public const string ExistingCase = "existingcase";

			/// <summary>firstresponsebykpiid</summary>
			public const string FirstResponseByKPI = "firstresponsebykpiid";

			/// <summary>firstresponsebykpiidname</summary>
			public const string Firstresponsebykpiidname = "firstresponsebykpiidname";

			/// <summary>firstresponsesent</summary>
			public const string FirstResponseSent = "firstresponsesent";

			/// <summary>firstresponseslastatus</summary>
			public const string FirstResponseSLAStatus = "firstresponseslastatus";

			/// <summary>followupby</summary>
			public const string FollowUpBy = "followupby";

			/// <summary>followuptaskcreated</summary>
			public const string FollowUpTaskCreated = "followuptaskcreated";

			/// <summary>importsequencenumber</summary>
			public const string ImportSequenceNumber = "importsequencenumber";

			/// <summary>incidentid</summary>
			public const string CaseId = "incidentid";

			/// <summary>incidentstagecode</summary>
			public const string CaseStage = "incidentstagecode";

			/// <summary>influencescore</summary>
			public const string InfluenceScore = "influencescore";

			/// <summary>isdecrementing</summary>
			public const string Decrementing = "isdecrementing";

			/// <summary>isescalated</summary>
			public const string IsEscalated = "isescalated";

			/// <summary>kbarticleid</summary>
			public const string KnowledgeBaseArticle = "kbarticleid";

			/// <summary>kbarticleidname</summary>
			public const string Kbarticleidname = "kbarticleidname";

			/// <summary>lastonholdtime</summary>
			public const string LastOnHoldTime = "lastonholdtime";

			/// <summary>masterid</summary>
			public const string MasterCase = "masterid";

			/// <summary>masteridname</summary>
			public const string Masteridname = "masteridname";

			/// <summary>merged</summary>
			public const string InternalUseOnly = "merged";

			/// <summary>messagetypecode</summary>
			public const string ReceivedAs = "messagetypecode";

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

			/// <summary>numberofchildincidents</summary>
			public const string ChildCases = "numberofchildincidents";

			/// <summary>onholdtime</summary>
			public const string OnHoldTimeMinutes = "onholdtime";

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

			/// <summary>parentcaseid</summary>
			public const string ParentCase = "parentcaseid";

			/// <summary>parentcaseidname</summary>
			public const string Parentcaseidname = "parentcaseidname";

			/// <summary>primarycontactid</summary>
			public const string Contact2 = "primarycontactid";

			/// <summary>primarycontactidname</summary>
			public const string Primarycontactidname = "primarycontactidname";

			/// <summary>primarycontactidyominame</summary>
			public const string Primarycontactidyominame = "primarycontactidyominame";

			/// <summary>prioritycode</summary>
			public const string Priority = "prioritycode";

			/// <summary>processid</summary>
			public const string ProcessId = "processid";

			/// <summary>productid</summary>
			public const string Product = "productid";

			/// <summary>productidname</summary>
			public const string Productidname = "productidname";

			/// <summary>productserialnumber</summary>
			public const string SerialNumber = "productserialnumber";

			/// <summary>resolveby</summary>
			public const string ResolveBy = "resolveby";

			/// <summary>resolvebykpiid</summary>
			public const string ResolveByKPI = "resolvebykpiid";

			/// <summary>resolvebykpiidname</summary>
			public const string Resolvebykpiidname = "resolvebykpiidname";

			/// <summary>resolvebyslastatus</summary>
			public const string ResolveBySLAStatus = "resolvebyslastatus";

			/// <summary>responseby</summary>
			public const string FirstResponseBy = "responseby";

			/// <summary>responsiblecontactid</summary>
			public const string ResponsibleContact = "responsiblecontactid";

			/// <summary>responsiblecontactidname</summary>
			public const string Responsiblecontactidname = "responsiblecontactidname";

			/// <summary>responsiblecontactidyominame</summary>
			public const string Responsiblecontactidyominame = "responsiblecontactidyominame";

			/// <summary>routecase</summary>
			public const string RouteCase = "routecase";

			/// <summary>sentimentvalue</summary>
			public const string SentimentValue = "sentimentvalue";

			/// <summary>servicestage</summary>
			public const string ServiceStage = "servicestage";

			/// <summary>severitycode</summary>
			public const string Severity = "severitycode";

			/// <summary>slaid</summary>
			public const string SLA = "slaid";

			/// <summary>slainvokedid</summary>
			public const string LastSLAApplied = "slainvokedid";

			/// <summary>slainvokedidname</summary>
			public const string Slainvokedidname = "slainvokedidname";

			/// <summary>slaname</summary>
			public const string Slaname = "slaname";

			/// <summary>socialprofileid</summary>
			public const string SocialProfile = "socialprofileid";

			/// <summary>socialprofileidname</summary>
			public const string Socialprofileidname = "socialprofileidname";

			/// <summary>stageid</summary>
			public const string DeprecatedStageId = "stageid";

			/// <summary>statecode</summary>
			public const string Status = "statecode";

			/// <summary>statuscode</summary>
			public const string StatusReason = "statuscode";

			/// <summary>subjectid</summary>
			public const string Subject = "subjectid";

			/// <summary>subjectidname</summary>
			public const string Subjectidname = "subjectidname";

			/// <summary>ticketnumber</summary>
			public const string CaseNumber = "ticketnumber";

			/// <summary>timezoneruleversionnumber</summary>
			public const string TimeZoneRuleVersionNumber = "timezoneruleversionnumber";

			/// <summary>title</summary>
			public const string CaseTitle = "title";

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
			/// <summary>1:N incident_actioncard</summary>
			public const string IncidentActioncard = "incident_actioncard";

			/// <summary>1:N incident_activity_parties</summary>
			public const string IncidentActivityParties = "incident_activity_parties";

			/// <summary>1:N Incident_ActivityPointers</summary>
			public const string IncidentActivityPointers = "Incident_ActivityPointers";

			/// <summary>1:N Incident_Annotation</summary>
			public const string IncidentAnnotation = "Incident_Annotation";

			/// <summary>1:N Incident_Appointments</summary>
			public const string IncidentAppointments = "Incident_Appointments";

			/// <summary>1:N Incident_AsyncOperations</summary>
			public const string IncidentAsyncOperations = "Incident_AsyncOperations";

			/// <summary>1:N Incident_BulkDeleteFailures</summary>
			public const string IncidentBulkDeleteFailures = "Incident_BulkDeleteFailures";

			/// <summary>1:N incident_connections1</summary>
			public const string IncidentConnections1 = "incident_connections1";

			/// <summary>1:N incident_connections2</summary>
			public const string IncidentConnections2 = "incident_connections2";

			/// <summary>1:N Incident_DuplicateBaseRecord</summary>
			public const string IncidentDuplicateBaseRecord = "Incident_DuplicateBaseRecord";

			/// <summary>1:N Incident_DuplicateMatchingRecord</summary>
			public const string IncidentDuplicateMatchingRecord = "Incident_DuplicateMatchingRecord";

			/// <summary>1:N Incident_Emails</summary>
			public const string IncidentEmails = "Incident_Emails";

			/// <summary>1:N incident_existingcase</summary>
			public const string IncidentExistingcase = "incident_existingcase";

			/// <summary>1:N Incident_Faxes</summary>
			public const string IncidentFaxes = "Incident_Faxes";

			/// <summary>1:N Incident_IncidentResolutions</summary>
			public const string IncidentIncidentResolutions = "Incident_IncidentResolutions";

			/// <summary>1:N Incident_Letters</summary>
			public const string IncidentLetters = "Incident_Letters";

			/// <summary>1:N Incident_MailboxTrackingFolder</summary>
			public const string IncidentMailboxTrackingFolder = "Incident_MailboxTrackingFolder";

			/// <summary>1:N incident_master_incident</summary>
			public const string IncidentMasterIncident = "incident_master_incident";

			/// <summary>1:N incident_OpportunityCloses</summary>
			public const string IncidentOpportunityCloses = "incident_OpportunityCloses";

			/// <summary>1:N incident_OrderCloses</summary>
			public const string IncidentOrderCloses = "incident_OrderCloses";

			/// <summary>1:N incident_parent_incident</summary>
			public const string IncidentParentIncident = "incident_parent_incident";

			/// <summary>1:N Incident_Phonecalls</summary>
			public const string IncidentPhonecalls = "Incident_Phonecalls";

			/// <summary>1:N incident_PostFollows</summary>
			public const string IncidentPostFollows = "incident_PostFollows";

			/// <summary>1:N incident_principalobjectattributeaccess</summary>
			public const string IncidentPrincipalobjectattributeaccess = "incident_principalobjectattributeaccess";

			/// <summary>1:N Incident_ProcessSessions</summary>
			public const string IncidentProcessSessions = "Incident_ProcessSessions";

			/// <summary>1:N Incident_QueueItem</summary>
			public const string IncidentQueueItem = "Incident_QueueItem";

			/// <summary>1:N incident_QuoteCloses</summary>
			public const string IncidentQuoteCloses = "incident_QuoteCloses";

			/// <summary>1:N Incident_RecurringAppointmentMasters</summary>
			public const string IncidentRecurringAppointmentMasters = "Incident_RecurringAppointmentMasters";

			/// <summary>1:N Incident_ServiceAppointments</summary>
			public const string IncidentServiceAppointments = "Incident_ServiceAppointments";

			/// <summary>1:N Incident_SocialActivities</summary>
			public const string IncidentSocialActivities = "Incident_SocialActivities";

			/// <summary>1:N Incident_SyncErrors</summary>
			public const string IncidentSyncErrors = "Incident_SyncErrors";

			/// <summary>1:N Incident_Tasks</summary>
			public const string IncidentTasks = "Incident_Tasks";

			/// <summary>1:N knowledgearticle_incidents</summary>
			public const string KnowledgearticleIncidents = "knowledgearticle_incidents";

			/// <summary>1:N lk_phonetocaseprocess_incidentid</summary>
			public const string LkPhonetocaseprocessIncidentid = "lk_phonetocaseprocess_incidentid";

			/// <summary>1:N OriginatingCase_Lead</summary>
			public const string OriginatingCaseLead = "OriginatingCase_Lead";

			/// <summary>1:N slakpiinstance_incident</summary>
			public const string SlakpiinstanceIncident = "slakpiinstance_incident";

			/// <summary>N:N KnowledgeBaseRecord_Incident</summary>
			public const string KnowledgeBaseRecordIncident = "KnowledgeBaseRecord_Incident";

		}
		#endregion
	}
}

