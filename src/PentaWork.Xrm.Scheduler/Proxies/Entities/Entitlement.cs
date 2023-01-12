using System;
using System.Linq;
using System.Diagnostics;
using System.ComponentModel;
using Microsoft.Xrm.Sdk; 
using Microsoft.Xrm.Sdk.Client;
using System.Collections.Generic;

namespace PentaWork.Xrm.Scheduler.Proxies.Entities
{
	[DebuggerDisplay("{EntitlementName}")] 	
	[EntityLogicalName("entitlement")]
	public sealed class Entitlement : Entity
	{	
		public static readonly int? EntityTypeCode = 9700;
		public new const string LogicalName = "entitlement";
		public const string PrimaryIdAttribute = "entitlementid";
		public const string PrimaryNameAttribute = "name";
	
		public Entitlement() : base("entitlement") { }

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
        /// allocationtypecode
        /// </summary>
		[DisplayName("Allocation Type")]
		[AttributeLogicalName("allocationtypecode")]
		public eAllocationType? AllocationType
		{	
			get 
			{ 
				var optionSetValue = GetAttributeValue<OptionSetValue>("allocationtypecode");
				if (optionSetValue != null) return (eAllocationType)optionSetValue.Value;
				else return null;
			}
			set 
			{ 
				if(value == AllocationType) return;

				OptionSetValue optionSetValue = null;
				if(value != null) optionSetValue = new OptionSetValue((int)value);
				SetAttributeValue("allocationtypecode", optionSetValue); 
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
        /// decreaseremainingon
        /// </summary>
		[DisplayName("Decrease Remaining On")]
		[AttributeLogicalName("decreaseremainingon")]
		public eDecreaseRemainingOn? DecreaseRemainingOn
		{	
			get 
			{ 
				var optionSetValue = GetAttributeValue<OptionSetValue>("decreaseremainingon");
				if (optionSetValue != null) return (eDecreaseRemainingOn)optionSetValue.Value;
				else return null;
			}
			set 
			{ 
				if(value == DecreaseRemainingOn) return;

				OptionSetValue optionSetValue = null;
				if(value != null) optionSetValue = new OptionSetValue((int)value);
				SetAttributeValue("decreaseremainingon", optionSetValue); 
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
        /// enddate
        /// </summary>
		[DisplayName("End Date")]
		[AttributeLogicalName("enddate")]
		public DateTime? EndDate
		{	
			get { return GetAttributeValue<DateTime?>("enddate"); }
			set
			{ 
				if(value == EndDate) return;
				SetAttributeValue("enddate", value);
			}
		}	
			
		/// <summary>
        /// entitlementid
        /// </summary>
		[DisplayName("Entitlement")]
		[AttributeLogicalName("entitlementid")]
		public override Guid Id
		{
			get => base.Id;
			set { base.Id = value; SetAttributeValue("entitlementid", value); }
		}

							/// <summary>
        /// entitlementtemplateid
        /// </summary>
		[DisplayName("Entitlement Template")]
		[AttributeLogicalName("entitlementtemplateid")]
		public EntityReference EntitlementTemplate
		{	
			get { return GetAttributeValue<EntityReference>("entitlementtemplateid"); }
			set
			{ 
				if(value == EntitlementTemplate) return;
				SetAttributeValue("entitlementtemplateid", value);
			}
		}	
			
		/// <summary>
        /// entitlementtemplateidname
        /// </summary>
		[DisplayName("entitlementtemplateidname")]
		[AttributeLogicalName("entitlementtemplateidname")]
		public string Entitlementtemplateidname
		{	
			get { return GetAttributeValue<string>("entitlementtemplateidname"); }
			set
			{ 
				if(value == Entitlementtemplateidname) return;
				SetAttributeValue("entitlementtemplateidname", value);
			}
		}	
			
		/// <summary>
        /// entitytype
        /// </summary>
		[DisplayName("Entity Type")]
		[AttributeLogicalName("entitytype")]
		public egEntityType? EntityType
		{	
			get 
			{ 
				var optionSetValue = GetAttributeValue<OptionSetValue>("entitytype");
				if (optionSetValue != null) return (egEntityType)optionSetValue.Value;
				else return null;
			}
			set 
			{ 
				if(value == EntityType) return;

				OptionSetValue optionSetValue = null;
				if(value != null) optionSetValue = new OptionSetValue((int)value);
				SetAttributeValue("entitytype", optionSetValue); 
			}
		}

		/// <summary>
        /// exchangerate
		///
		/// Precision: 10
		/// MaxValue: 100000000000
		/// MinValue: 0.0000000001
        /// </summary>
		[DisplayName("Exchange Rate")]
		[AttributeLogicalName("exchangerate")]
		public decimal? ExchangeRate
		{	
			get { return GetAttributeValue<decimal?>("exchangerate"); }
			set 
			{
				decimal? decimalValue = null;
				if(value != null) decimalValue = Decimal.Round(value.Value, 10);
				if(decimalValue == ExchangeRate) return;
				SetAttributeValue("exchangerate", decimalValue);  
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
        /// isdefault
        /// </summary>
		[DisplayName("Is Default")]
		[AttributeLogicalName("isdefault")]
		public bool? IsDefault
		{	
			get { return GetAttributeValue<bool?>("isdefault"); }
			set
			{ 
				if(value == IsDefault) return;
				SetAttributeValue("isdefault", value);
			}
		}	
			
		/// <summary>
        /// kbaccesslevel
        /// </summary>
		[DisplayName("KB Access Level")]
		[AttributeLogicalName("kbaccesslevel")]
		public eKBAccessLevel? KBAccessLevel
		{	
			get 
			{ 
				var optionSetValue = GetAttributeValue<OptionSetValue>("kbaccesslevel");
				if (optionSetValue != null) return (eKBAccessLevel)optionSetValue.Value;
				else return null;
			}
			set 
			{ 
				if(value == KBAccessLevel) return;

				OptionSetValue optionSetValue = null;
				if(value != null) optionSetValue = new OptionSetValue((int)value);
				SetAttributeValue("kbaccesslevel", optionSetValue); 
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
		[DisplayName("Entitlement Name")]
		[AttributeLogicalName("name")]
		public string EntitlementName
		{	
			get { return GetAttributeValue<string>("name"); }
			set
			{ 
				if(value == EntitlementName) return;
				SetAttributeValue("name", value);
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
        /// remainingterms
		///
		/// Precision: 2
		/// MaxValue: 100000000000
		/// MinValue: -100000000000
        /// </summary>
		[DisplayName("Remaining Terms")]
		[AttributeLogicalName("remainingterms")]
		public decimal? RemainingTerms
		{	
			get { return GetAttributeValue<decimal?>("remainingterms"); }
			set 
			{
				decimal? decimalValue = null;
				if(value != null) decimalValue = Decimal.Round(value.Value, 2);
				if(decimalValue == RemainingTerms) return;
				SetAttributeValue("remainingterms", decimalValue);  
			}
		}

		/// <summary>
        /// restrictcasecreation
        /// </summary>
		[DisplayName("Restrict based on entitlement terms")]
		[AttributeLogicalName("restrictcasecreation")]
		public bool? RestrictBasedOnEntitlementTerms
		{	
			get { return GetAttributeValue<bool?>("restrictcasecreation"); }
			set
			{ 
				if(value == RestrictBasedOnEntitlementTerms) return;
				SetAttributeValue("restrictcasecreation", value);
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
        /// slaidname
        /// </summary>
		[DisplayName("slaidname")]
		[AttributeLogicalName("slaidname")]
		public string Slaidname
		{	
			get { return GetAttributeValue<string>("slaidname"); }
			set
			{ 
				if(value == Slaidname) return;
				SetAttributeValue("slaidname", value);
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
        /// startdate
        /// </summary>
		[DisplayName("Start Date")]
		[AttributeLogicalName("startdate")]
		public DateTime? StartDate
		{	
			get { return GetAttributeValue<DateTime?>("startdate"); }
			set
			{ 
				if(value == StartDate) return;
				SetAttributeValue("startdate", value);
			}
		}	
			
		/// <summary>
        /// statecode
        /// </summary>
		[DisplayName("Status")]
		[AttributeLogicalName("statecode")]
		public eStateCode? Status
		{	
			get 
			{ 
				var optionSetValue = GetAttributeValue<OptionSetValue>("statecode");
				if (optionSetValue != null) return (eStateCode)optionSetValue.Value;
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
		[DisplayName("Status Code")]
		[AttributeLogicalName("statuscode")]
		public eStatus? StatusCode
		{	
			get 
			{ 
				var optionSetValue = GetAttributeValue<OptionSetValue>("statuscode");
				if (optionSetValue != null) return (eStatus)optionSetValue.Value;
				else return null;
			}
			set 
			{ 
				if(value == StatusCode) return;

				OptionSetValue optionSetValue = null;
				if(value != null) optionSetValue = new OptionSetValue((int)value);
				SetAttributeValue("statuscode", optionSetValue); 
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
        /// totalterms
		///
		/// Precision: 2
		/// MaxValue: 100000000000
		/// MinValue: 0
        /// </summary>
		[DisplayName("Total Terms")]
		[AttributeLogicalName("totalterms")]
		public decimal? TotalTerms
		{	
			get { return GetAttributeValue<decimal?>("totalterms"); }
			set 
			{
				decimal? decimalValue = null;
				if(value != null) decimalValue = Decimal.Round(value.Value, 2);
				if(decimalValue == TotalTerms) return;
				SetAttributeValue("totalterms", decimalValue);  
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
        /// 1:N Get entities for 'entitlement_ActivityParties'
        /// </summary>
		[RelationshipSchemaName("entitlement_ActivityParties")]
		public IEnumerable<ActivityParty> EntitlementActivityParties
		{
			get { return GetRelatedEntities<ActivityParty>("entitlement_ActivityParties", null); }
			set { SetRelatedEntities("entitlement_ActivityParties", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'entitlement_ActivityPointers'
        /// </summary>
		[RelationshipSchemaName("entitlement_ActivityPointers")]
		public IEnumerable<Activity> EntitlementActivityPointers
		{
			get { return GetRelatedEntities<Activity>("entitlement_ActivityPointers", null); }
			set { SetRelatedEntities("entitlement_ActivityPointers", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'entitlement_Annotations'
        /// </summary>
		[RelationshipSchemaName("entitlement_Annotations")]
		public IEnumerable<Note> EntitlementAnnotations
		{
			get { return GetRelatedEntities<Note>("entitlement_Annotations", null); }
			set { SetRelatedEntities("entitlement_Annotations", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'entitlement_Appointments'
        /// </summary>
		[RelationshipSchemaName("entitlement_Appointments")]
		public IEnumerable<Appointment> EntitlementAppointments
		{
			get { return GetRelatedEntities<Appointment>("entitlement_Appointments", null); }
			set { SetRelatedEntities("entitlement_Appointments", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'entitlement_AsyncOperations'
        /// </summary>
		[RelationshipSchemaName("entitlement_AsyncOperations")]
		public IEnumerable<SystemJob> EntitlementAsyncOperations
		{
			get { return GetRelatedEntities<SystemJob>("entitlement_AsyncOperations", null); }
			set { SetRelatedEntities("entitlement_AsyncOperations", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'entitlement_BulkDeleteFailures'
        /// </summary>
		[RelationshipSchemaName("entitlement_BulkDeleteFailures")]
		public IEnumerable<BulkDeleteFailure> EntitlementBulkDeleteFailures
		{
			get { return GetRelatedEntities<BulkDeleteFailure>("entitlement_BulkDeleteFailures", null); }
			set { SetRelatedEntities("entitlement_BulkDeleteFailures", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'entitlement_cases'
        /// </summary>
		[RelationshipSchemaName("entitlement_cases")]
		public IEnumerable<Case> EntitlementCases
		{
			get { return GetRelatedEntities<Case>("entitlement_cases", null); }
			set { SetRelatedEntities("entitlement_cases", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'entitlement_connections1'
        /// </summary>
		[RelationshipSchemaName("entitlement_connections1")]
		public IEnumerable<Connection> EntitlementConnections1
		{
			get { return GetRelatedEntities<Connection>("entitlement_connections1", null); }
			set { SetRelatedEntities("entitlement_connections1", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'entitlement_connections2'
        /// </summary>
		[RelationshipSchemaName("entitlement_connections2")]
		public IEnumerable<Connection> EntitlementConnections2
		{
			get { return GetRelatedEntities<Connection>("entitlement_connections2", null); }
			set { SetRelatedEntities("entitlement_connections2", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'entitlement_DuplicateBaseRecord'
        /// </summary>
		[RelationshipSchemaName("entitlement_DuplicateBaseRecord")]
		public IEnumerable<DuplicateRecord> EntitlementDuplicateBaseRecord
		{
			get { return GetRelatedEntities<DuplicateRecord>("entitlement_DuplicateBaseRecord", null); }
			set { SetRelatedEntities("entitlement_DuplicateBaseRecord", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'entitlement_DuplicateMatchingRecord'
        /// </summary>
		[RelationshipSchemaName("entitlement_DuplicateMatchingRecord")]
		public IEnumerable<DuplicateRecord> EntitlementDuplicateMatchingRecord
		{
			get { return GetRelatedEntities<DuplicateRecord>("entitlement_DuplicateMatchingRecord", null); }
			set { SetRelatedEntities("entitlement_DuplicateMatchingRecord", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'entitlement_Emails'
        /// </summary>
		[RelationshipSchemaName("entitlement_Emails")]
		public IEnumerable<Email> EntitlementEmails
		{
			get { return GetRelatedEntities<Email>("entitlement_Emails", null); }
			set { SetRelatedEntities("entitlement_Emails", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'entitlement_entitlementchannel_EntitlementId'
        /// </summary>
		[RelationshipSchemaName("entitlement_entitlementchannel_EntitlementId")]
		public IEnumerable<EntitlementChannel> EntitlementEntitlementchannelEntitlementId
		{
			get { return GetRelatedEntities<EntitlementChannel>("entitlement_entitlementchannel_EntitlementId", null); }
			set { SetRelatedEntities("entitlement_entitlementchannel_EntitlementId", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'entitlement_Faxes'
        /// </summary>
		[RelationshipSchemaName("entitlement_Faxes")]
		public IEnumerable<Fax> EntitlementFaxes
		{
			get { return GetRelatedEntities<Fax>("entitlement_Faxes", null); }
			set { SetRelatedEntities("entitlement_Faxes", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'entitlement_IncidentResolutions'
        /// </summary>
		[RelationshipSchemaName("entitlement_IncidentResolutions")]
		public IEnumerable<CaseResolution> EntitlementIncidentResolutions
		{
			get { return GetRelatedEntities<CaseResolution>("entitlement_IncidentResolutions", null); }
			set { SetRelatedEntities("entitlement_IncidentResolutions", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'entitlement_Letters'
        /// </summary>
		[RelationshipSchemaName("entitlement_Letters")]
		public IEnumerable<Letter> EntitlementLetters
		{
			get { return GetRelatedEntities<Letter>("entitlement_Letters", null); }
			set { SetRelatedEntities("entitlement_Letters", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'Entitlement_MailboxTrackingFolder'
        /// </summary>
		[RelationshipSchemaName("Entitlement_MailboxTrackingFolder")]
		public IEnumerable<MailboxAutoTrackingFolder> EntitlementMailboxTrackingFolder
		{
			get { return GetRelatedEntities<MailboxAutoTrackingFolder>("Entitlement_MailboxTrackingFolder", null); }
			set { SetRelatedEntities("Entitlement_MailboxTrackingFolder", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'entitlement_OpportunityCloses'
        /// </summary>
		[RelationshipSchemaName("entitlement_OpportunityCloses")]
		public IEnumerable<OpportunityClose> EntitlementOpportunityCloses
		{
			get { return GetRelatedEntities<OpportunityClose>("entitlement_OpportunityCloses", null); }
			set { SetRelatedEntities("entitlement_OpportunityCloses", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'entitlement_OrderCloses'
        /// </summary>
		[RelationshipSchemaName("entitlement_OrderCloses")]
		public IEnumerable<OrderClose> EntitlementOrderCloses
		{
			get { return GetRelatedEntities<OrderClose>("entitlement_OrderCloses", null); }
			set { SetRelatedEntities("entitlement_OrderCloses", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'entitlement_PhoneCalls'
        /// </summary>
		[RelationshipSchemaName("entitlement_PhoneCalls")]
		public IEnumerable<PhoneCall> EntitlementPhoneCalls
		{
			get { return GetRelatedEntities<PhoneCall>("entitlement_PhoneCalls", null); }
			set { SetRelatedEntities("entitlement_PhoneCalls", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'entitlement_PrincipalObjectAttributeAccesses'
        /// </summary>
		[RelationshipSchemaName("entitlement_PrincipalObjectAttributeAccesses")]
		public IEnumerable<FieldSharing> EntitlementPrincipalObjectAttributeAccesses
		{
			get { return GetRelatedEntities<FieldSharing>("entitlement_PrincipalObjectAttributeAccesses", null); }
			set { SetRelatedEntities("entitlement_PrincipalObjectAttributeAccesses", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'entitlement_ProcessSession'
        /// </summary>
		[RelationshipSchemaName("entitlement_ProcessSession")]
		public IEnumerable<ProcessSession> EntitlementProcessSession
		{
			get { return GetRelatedEntities<ProcessSession>("entitlement_ProcessSession", null); }
			set { SetRelatedEntities("entitlement_ProcessSession", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'entitlement_QuoteCloses'
        /// </summary>
		[RelationshipSchemaName("entitlement_QuoteCloses")]
		public IEnumerable<QuoteClose> EntitlementQuoteCloses
		{
			get { return GetRelatedEntities<QuoteClose>("entitlement_QuoteCloses", null); }
			set { SetRelatedEntities("entitlement_QuoteCloses", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'entitlement_RecurringAppointmentMasters'
        /// </summary>
		[RelationshipSchemaName("entitlement_RecurringAppointmentMasters")]
		public IEnumerable<RecurringAppointment> EntitlementRecurringAppointmentMasters
		{
			get { return GetRelatedEntities<RecurringAppointment>("entitlement_RecurringAppointmentMasters", null); }
			set { SetRelatedEntities("entitlement_RecurringAppointmentMasters", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'entitlement_ServiceAppointments'
        /// </summary>
		[RelationshipSchemaName("entitlement_ServiceAppointments")]
		public IEnumerable<ServiceActivity> EntitlementServiceAppointments
		{
			get { return GetRelatedEntities<ServiceActivity>("entitlement_ServiceAppointments", null); }
			set { SetRelatedEntities("entitlement_ServiceAppointments", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'entitlement_SocialActivities'
        /// </summary>
		[RelationshipSchemaName("entitlement_SocialActivities")]
		public IEnumerable<SocialActivity> EntitlementSocialActivities
		{
			get { return GetRelatedEntities<SocialActivity>("entitlement_SocialActivities", null); }
			set { SetRelatedEntities("entitlement_SocialActivities", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'Entitlement_SyncErrors'
        /// </summary>
		[RelationshipSchemaName("Entitlement_SyncErrors")]
		public IEnumerable<SyncError> EntitlementSyncErrors
		{
			get { return GetRelatedEntities<SyncError>("Entitlement_SyncErrors", null); }
			set { SetRelatedEntities("Entitlement_SyncErrors", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'entitlement_Tasks'
        /// </summary>
		[RelationshipSchemaName("entitlement_Tasks")]
		public IEnumerable<Task> EntitlementTasks
		{
			get { return GetRelatedEntities<Task>("entitlement_Tasks", null); }
			set { SetRelatedEntities("entitlement_Tasks", null, value); }
		}
		/// <summary>
        /// N:N Get entities for 'Contact'
        /// </summary>
		[RelationshipSchemaName("entitlementcontacts_association")]
		public IEnumerable<Contact> EntitlementcontactsAssociation
		{
			get { return GetRelatedEntities<Contact>("entitlementcontacts_association", null); }
			set { SetRelatedEntities("entitlementcontacts_association", null, value); }
		}
		/// <summary>
        /// N:N Get entities for 'Product'
        /// </summary>
		[RelationshipSchemaName("product_entitlement_association")]
		public IEnumerable<Product> ProductEntitlementAssociation
		{
			get { return GetRelatedEntities<Product>("product_entitlement_association", null); }
			set { SetRelatedEntities("product_entitlement_association", null, value); }
		}
		#endregion

		#region Actions
		#endregion

		#region OptionSetEnums
		public enum eAllocationType
		{	
		
			[Label("Number of cases")]
			[Description(@"Number of cases")]
			NumberOfCases = 0, 
		
			[Label("Number of hours")]
			[Description(@"Number of hours")]
			NumberOfHours = 1, 
		}
		
		public enum eDecreaseRemainingOn
		{	
		
			[Label("Case Resolution")]
			[Description(@"")]
			CaseResolution = 0, 
		
			[Label("Case Creation")]
			[Description(@"")]
			CaseCreation = 1, 
		}
		
		public enum eKBAccessLevel
		{	
		
			[Label("Standard")]
			[Description(@"Standard")]
			Standard = 0, 
		
			[Label("Premium")]
			[Description(@"Premium")]
			Premium = 1, 
		
			[Label("None")]
			[Description(@"None")]
			None = 2, 
		}
		
		public enum eStateCode
		{	
		
			[Label("Draft")]
			[Description(@"")]
			Draft = 0, 
		
			[Label("Active")]
			[Description(@"")]
			Active = 1, 
		
			[Label("Cancelled")]
			[Description(@"")]
			Cancelled = 2, 
		
			[Label("Expired")]
			[Description(@"")]
			Expired = 3, 
		
			[Label("Waiting")]
			[Description(@"")]
			Waiting = 4, 
		}
		
		public enum eStatus
		{	
		
			[Label("Draft")]
			[Description(@"")]
			Draft_Active = 0, 
		
			[Label("Active")]
			[Description(@"")]
			Active_Inactive = 1, 
		
			[Label("Cancelled")]
			[Description(@"")]
			Cancelled = 2, 
		
			[Label("Expired")]
			[Description(@"")]
			Expired = 3, 
		
			[Label("Waiting")]
			[Description(@"")]
			Waiting = 1200, 
		}
		
		public enum egEntityType
		{	
		
			[Label("Case")]
			[Description(@"")]
			Case = 0, 
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

			/// <summary>allocationtypecode</summary>
			public const string AllocationType = "allocationtypecode";

			/// <summary>contactid</summary>
			public const string Contact = "contactid";

			/// <summary>contactidname</summary>
			public const string Contactidname = "contactidname";

			/// <summary>contactidyominame</summary>
			public const string Contactidyominame = "contactidyominame";

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

			/// <summary>customerid</summary>
			public const string Customer = "customerid";

			/// <summary>customeridname</summary>
			public const string Customeridname = "customeridname";

			/// <summary>customeridtype</summary>
			public const string CustomerType = "customeridtype";

			/// <summary>customeridyominame</summary>
			public const string Customeridyominame = "customeridyominame";

			/// <summary>decreaseremainingon</summary>
			public const string DecreaseRemainingOn = "decreaseremainingon";

			/// <summary>description</summary>
			public const string Description = "description";

			/// <summary>emailaddress</summary>
			public const string EmailAddress = "emailaddress";

			/// <summary>enddate</summary>
			public const string EndDate = "enddate";

			/// <summary>entitlementid</summary>
			public const string EntitlementId = "entitlementid";

			/// <summary>entitlementtemplateid</summary>
			public const string EntitlementTemplate = "entitlementtemplateid";

			/// <summary>entitlementtemplateidname</summary>
			public const string Entitlementtemplateidname = "entitlementtemplateidname";

			/// <summary>entitytype</summary>
			public const string EntityType = "entitytype";

			/// <summary>exchangerate</summary>
			public const string ExchangeRate = "exchangerate";

			/// <summary>importsequencenumber</summary>
			public const string ImportSequenceNumber = "importsequencenumber";

			/// <summary>isdefault</summary>
			public const string IsDefault = "isdefault";

			/// <summary>kbaccesslevel</summary>
			public const string KBAccessLevel = "kbaccesslevel";

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
			public const string EntitlementName = "name";

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

			/// <summary>processid</summary>
			public const string ProcessId = "processid";

			/// <summary>remainingterms</summary>
			public const string RemainingTerms = "remainingterms";

			/// <summary>restrictcasecreation</summary>
			public const string RestrictBasedOnEntitlementTerms = "restrictcasecreation";

			/// <summary>slaid</summary>
			public const string SLA = "slaid";

			/// <summary>slaidname</summary>
			public const string Slaidname = "slaidname";

			/// <summary>stageid</summary>
			public const string DeprecatedStageId = "stageid";

			/// <summary>startdate</summary>
			public const string StartDate = "startdate";

			/// <summary>statecode</summary>
			public const string Status = "statecode";

			/// <summary>statuscode</summary>
			public const string StatusCode = "statuscode";

			/// <summary>timezoneruleversionnumber</summary>
			public const string TimeZoneRuleVersionNumber = "timezoneruleversionnumber";

			/// <summary>totalterms</summary>
			public const string TotalTerms = "totalterms";

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
			/// <summary>1:N entitlement_ActivityParties</summary>
			public const string EntitlementActivityParties = "entitlement_ActivityParties";

			/// <summary>1:N entitlement_ActivityPointers</summary>
			public const string EntitlementActivityPointers = "entitlement_ActivityPointers";

			/// <summary>1:N entitlement_Annotations</summary>
			public const string EntitlementAnnotations = "entitlement_Annotations";

			/// <summary>1:N entitlement_Appointments</summary>
			public const string EntitlementAppointments = "entitlement_Appointments";

			/// <summary>1:N entitlement_AsyncOperations</summary>
			public const string EntitlementAsyncOperations = "entitlement_AsyncOperations";

			/// <summary>1:N entitlement_BulkDeleteFailures</summary>
			public const string EntitlementBulkDeleteFailures = "entitlement_BulkDeleteFailures";

			/// <summary>1:N entitlement_cases</summary>
			public const string EntitlementCases = "entitlement_cases";

			/// <summary>1:N entitlement_connections1</summary>
			public const string EntitlementConnections1 = "entitlement_connections1";

			/// <summary>1:N entitlement_connections2</summary>
			public const string EntitlementConnections2 = "entitlement_connections2";

			/// <summary>1:N entitlement_DuplicateBaseRecord</summary>
			public const string EntitlementDuplicateBaseRecord = "entitlement_DuplicateBaseRecord";

			/// <summary>1:N entitlement_DuplicateMatchingRecord</summary>
			public const string EntitlementDuplicateMatchingRecord = "entitlement_DuplicateMatchingRecord";

			/// <summary>1:N entitlement_Emails</summary>
			public const string EntitlementEmails = "entitlement_Emails";

			/// <summary>1:N entitlement_entitlementchannel_EntitlementId</summary>
			public const string EntitlementEntitlementchannelEntitlementId = "entitlement_entitlementchannel_EntitlementId";

			/// <summary>1:N entitlement_Faxes</summary>
			public const string EntitlementFaxes = "entitlement_Faxes";

			/// <summary>1:N entitlement_IncidentResolutions</summary>
			public const string EntitlementIncidentResolutions = "entitlement_IncidentResolutions";

			/// <summary>1:N entitlement_Letters</summary>
			public const string EntitlementLetters = "entitlement_Letters";

			/// <summary>1:N Entitlement_MailboxTrackingFolder</summary>
			public const string EntitlementMailboxTrackingFolder = "Entitlement_MailboxTrackingFolder";

			/// <summary>1:N entitlement_OpportunityCloses</summary>
			public const string EntitlementOpportunityCloses = "entitlement_OpportunityCloses";

			/// <summary>1:N entitlement_OrderCloses</summary>
			public const string EntitlementOrderCloses = "entitlement_OrderCloses";

			/// <summary>1:N entitlement_PhoneCalls</summary>
			public const string EntitlementPhoneCalls = "entitlement_PhoneCalls";

			/// <summary>1:N entitlement_PrincipalObjectAttributeAccesses</summary>
			public const string EntitlementPrincipalObjectAttributeAccesses = "entitlement_PrincipalObjectAttributeAccesses";

			/// <summary>1:N entitlement_ProcessSession</summary>
			public const string EntitlementProcessSession = "entitlement_ProcessSession";

			/// <summary>1:N entitlement_QuoteCloses</summary>
			public const string EntitlementQuoteCloses = "entitlement_QuoteCloses";

			/// <summary>1:N entitlement_RecurringAppointmentMasters</summary>
			public const string EntitlementRecurringAppointmentMasters = "entitlement_RecurringAppointmentMasters";

			/// <summary>1:N entitlement_ServiceAppointments</summary>
			public const string EntitlementServiceAppointments = "entitlement_ServiceAppointments";

			/// <summary>1:N entitlement_SocialActivities</summary>
			public const string EntitlementSocialActivities = "entitlement_SocialActivities";

			/// <summary>1:N Entitlement_SyncErrors</summary>
			public const string EntitlementSyncErrors = "Entitlement_SyncErrors";

			/// <summary>1:N entitlement_Tasks</summary>
			public const string EntitlementTasks = "entitlement_Tasks";

			/// <summary>N:N entitlementcontacts_association</summary>
			public const string EntitlementcontactsAssociation = "entitlementcontacts_association";

			/// <summary>N:N product_entitlement_association</summary>
			public const string ProductEntitlementAssociation = "product_entitlement_association";

		}
		#endregion
	}
}

