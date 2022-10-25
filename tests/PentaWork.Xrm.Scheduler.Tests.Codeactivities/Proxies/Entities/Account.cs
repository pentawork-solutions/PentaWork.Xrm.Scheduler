using System;
using System.Linq;
using System.Diagnostics;
using System.ComponentModel;
using Microsoft.Xrm.Sdk; 
using Microsoft.Xrm.Sdk.Client;
using System.Collections.Generic;

namespace PentaWork.Xrm.Scheduler.Tests.Codeactivities.Proxies.Entities
{
	[DebuggerDisplay("{AccountName}")] 	
	[EntityLogicalName("account")]
	public sealed class Account : Entity
	{	
		public new const string LogicalName = "account";
		public const string PrimaryIdAttribute = "accountid";
		public const string PrimaryNameAttribute = "name";
	
		public Account() : base("account") { }

		#region Attributes
		/// <summary>
        /// address2_postalcode
        /// </summary>
		[DisplayName("Address 2: ZIP/Postal Code")]
		[AttributeLogicalName("address2_postalcode")]
		public string Address2ZIPPostalCode
		{	
			get { return GetAttributeValue<string>("address2_postalcode"); }
			set { SetAttributeValue("address2_postalcode", value); }
		}	
			
		/// <summary>
        /// address1_longitude
        /// </summary>
		[DisplayName("Address 1: Longitude")]
		[AttributeLogicalName("address1_longitude")]
		public double? Address1Longitude
		{	
			get { return GetAttributeValue<double?>("address1_longitude"); }
			set { SetAttributeValue("address1_longitude", value); }
		}	
			
		/// <summary>
        /// aging90
        /// </summary>
		[DisplayName("Aging 90")]
		[AttributeLogicalName("aging90")]
		public decimal? Aging90
		{	
			get { return GetAttributeValue<Money>("aging90")?.Value; }
			set 
			{ 
				Money moneyValue = null;
				if(value != null) moneyValue = new Money(value.Value);
				SetAttributeValue("aging90", moneyValue);  
			}
		}

		/// <summary>
        /// address2_county
        /// </summary>
		[DisplayName("Address 2: County")]
		[AttributeLogicalName("address2_county")]
		public string Address2County
		{	
			get { return GetAttributeValue<string>("address2_county"); }
			set { SetAttributeValue("address2_county", value); }
		}	
			
		/// <summary>
        /// defaultpricelevelidname
        /// </summary>
		[DisplayName("defaultpricelevelidname")]
		[AttributeLogicalName("defaultpricelevelidname")]
		public string Defaultpricelevelidname
		{	
			get { return GetAttributeValue<string>("defaultpricelevelidname"); }
			set { SetAttributeValue("defaultpricelevelidname", value); }
		}	
			
		/// <summary>
        /// masteraccountidname
        /// </summary>
		[DisplayName("masteraccountidname")]
		[AttributeLogicalName("masteraccountidname")]
		public string Masteraccountidname
		{	
			get { return GetAttributeValue<string>("masteraccountidname"); }
			set { SetAttributeValue("masteraccountidname", value); }
		}	
			
		/// <summary>
        /// address1_county
        /// </summary>
		[DisplayName("Address 1: County")]
		[AttributeLogicalName("address1_county")]
		public string Address1County
		{	
			get { return GetAttributeValue<string>("address1_county"); }
			set { SetAttributeValue("address1_county", value); }
		}	
			
		/// <summary>
        /// preferredcontactmethodcode
        /// </summary>
		[DisplayName("Preferred Method of Contact")]
		[AttributeLogicalName("preferredcontactmethodcode")]
		public ePreferredMethodOfContact? PreferredMethodOfContact
		{	
			get 
			{ 
				var optionSetValue = GetAttributeValue<OptionSetValue>("preferredcontactmethodcode");
				if (optionSetValue != null) return (ePreferredMethodOfContact)optionSetValue.Value;
				else return null;
			}
			set 
			{ 
				OptionSetValue optionSetValue = null;
				if(value != null) optionSetValue = new OptionSetValue((int)value);
				SetAttributeValue("preferredcontactmethodcode", optionSetValue); 
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
			set { SetAttributeValue("modifiedby", value); }
		}	
			
		/// <summary>
        /// address2_line3
        /// </summary>
		[DisplayName("Address 2: Street 3")]
		[AttributeLogicalName("address2_line3")]
		public string Address2Street3
		{	
			get { return GetAttributeValue<string>("address2_line3"); }
			set { SetAttributeValue("address2_line3", value); }
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
				OptionSetValue optionSetValue = null;
				if(value != null) optionSetValue = new OptionSetValue((int)value);
				SetAttributeValue("statuscode", optionSetValue); 
			}
		}

		/// <summary>
        /// address2_longitude
        /// </summary>
		[DisplayName("Address 2: Longitude")]
		[AttributeLogicalName("address2_longitude")]
		public double? Address2Longitude
		{	
			get { return GetAttributeValue<double?>("address2_longitude"); }
			set { SetAttributeValue("address2_longitude", value); }
		}	
			
		/// <summary>
        /// modifiedonbehalfby
        /// </summary>
		[DisplayName("Modified By (Delegate)")]
		[AttributeLogicalName("modifiedonbehalfby")]
		public EntityReference ModifiedByDelegate
		{	
			get { return GetAttributeValue<EntityReference>("modifiedonbehalfby"); }
			set { SetAttributeValue("modifiedonbehalfby", value); }
		}	
			
		/// <summary>
        /// originatingleadidyominame
        /// </summary>
		[DisplayName("originatingleadidyominame")]
		[AttributeLogicalName("originatingleadidyominame")]
		public string Originatingleadidyominame
		{	
			get { return GetAttributeValue<string>("originatingleadidyominame"); }
			set { SetAttributeValue("originatingleadidyominame", value); }
		}	
			
		/// <summary>
        /// address1_telephone2
        /// </summary>
		[DisplayName("Address 1: Telephone 2")]
		[AttributeLogicalName("address1_telephone2")]
		public string Address1Telephone2
		{	
			get { return GetAttributeValue<string>("address1_telephone2"); }
			set { SetAttributeValue("address1_telephone2", value); }
		}	
			
		/// <summary>
        /// transactioncurrencyidname
        /// </summary>
		[DisplayName("transactioncurrencyidname")]
		[AttributeLogicalName("transactioncurrencyidname")]
		public string Transactioncurrencyidname
		{	
			get { return GetAttributeValue<string>("transactioncurrencyidname"); }
			set { SetAttributeValue("transactioncurrencyidname", value); }
		}	
			
		/// <summary>
        /// address1_upszone
        /// </summary>
		[DisplayName("Address 1: UPS Zone")]
		[AttributeLogicalName("address1_upszone")]
		public string Address1UPSZone
		{	
			get { return GetAttributeValue<string>("address1_upszone"); }
			set { SetAttributeValue("address1_upszone", value); }
		}	
			
		/// <summary>
        /// opendeals_date
        /// </summary>
		[DisplayName("Open Deals (Last Updated On)")]
		[AttributeLogicalName("opendeals_date")]
		public DateTime? OpenDealsLastUpdatedOn
		{	
			get { return GetAttributeValue<DateTime?>("opendeals_date"); }
			set { SetAttributeValue("opendeals_date", value); }
		}	
			
		/// <summary>
        /// processid
        /// </summary>
		[DisplayName("Process")]
		[AttributeLogicalName("processid")]
		public Guid ProcessId
		{	
			get { return GetAttributeValue<Guid>("processid"); }
			set { SetAttributeValue("processid", value); }
		}	
			
		/// <summary>
        /// marketcap
        /// </summary>
		[DisplayName("Market Capitalization")]
		[AttributeLogicalName("marketcap")]
		public decimal? MarketCapitalization
		{	
			get { return GetAttributeValue<Money>("marketcap")?.Value; }
			set 
			{ 
				Money moneyValue = null;
				if(value != null) moneyValue = new Money(value.Value);
				SetAttributeValue("marketcap", moneyValue);  
			}
		}

		/// <summary>
        /// openrevenue_date
        /// </summary>
		[DisplayName("Open Revenue (Last Updated On)")]
		[AttributeLogicalName("openrevenue_date")]
		public DateTime? OpenRevenueLastUpdatedOn
		{	
			get { return GetAttributeValue<DateTime?>("openrevenue_date"); }
			set { SetAttributeValue("openrevenue_date", value); }
		}	
			
		/// <summary>
        /// address2_name
        /// </summary>
		[DisplayName("Address 2: Name")]
		[AttributeLogicalName("address2_name")]
		public string Address2Name
		{	
			get { return GetAttributeValue<string>("address2_name"); }
			set { SetAttributeValue("address2_name", value); }
		}	
			
		/// <summary>
        /// address1_stateorprovince
        /// </summary>
		[DisplayName("Address 1: State/Province")]
		[AttributeLogicalName("address1_stateorprovince")]
		public string Address1StateProvince
		{	
			get { return GetAttributeValue<string>("address1_stateorprovince"); }
			set { SetAttributeValue("address1_stateorprovince", value); }
		}	
			
		/// <summary>
        /// masteraccountidyominame
        /// </summary>
		[DisplayName("masteraccountidyominame")]
		[AttributeLogicalName("masteraccountidyominame")]
		public string Masteraccountidyominame
		{	
			get { return GetAttributeValue<string>("masteraccountidyominame"); }
			set { SetAttributeValue("masteraccountidyominame", value); }
		}	
			
		/// <summary>
        /// emailaddress1
        /// </summary>
		[DisplayName("Email")]
		[AttributeLogicalName("emailaddress1")]
		public string Email
		{	
			get { return GetAttributeValue<string>("emailaddress1"); }
			set { SetAttributeValue("emailaddress1", value); }
		}	
			
		/// <summary>
        /// owneridyominame
        /// </summary>
		[DisplayName("owneridyominame")]
		[AttributeLogicalName("owneridyominame")]
		public string Owneridyominame
		{	
			get { return GetAttributeValue<string>("owneridyominame"); }
			set { SetAttributeValue("owneridyominame", value); }
		}	
			
		/// <summary>
        /// address1_country
        /// </summary>
		[DisplayName("Address 1: Country/Region")]
		[AttributeLogicalName("address1_country")]
		public string Address1CountryRegion
		{	
			get { return GetAttributeValue<string>("address1_country"); }
			set { SetAttributeValue("address1_country", value); }
		}	
			
		/// <summary>
        /// owningbusinessunit
        /// </summary>
		[DisplayName("Owning Business Unit")]
		[AttributeLogicalName("owningbusinessunit")]
		public EntityReference OwningBusinessUnit
		{	
			get { return GetAttributeValue<EntityReference>("owningbusinessunit"); }
			set { SetAttributeValue("owningbusinessunit", value); }
		}	
			
		/// <summary>
        /// accountratingcode
        /// </summary>
		[DisplayName("Account Rating")]
		[AttributeLogicalName("accountratingcode")]
		public eAccountRating? AccountRating
		{	
			get 
			{ 
				var optionSetValue = GetAttributeValue<OptionSetValue>("accountratingcode");
				if (optionSetValue != null) return (eAccountRating)optionSetValue.Value;
				else return null;
			}
			set 
			{ 
				OptionSetValue optionSetValue = null;
				if(value != null) optionSetValue = new OptionSetValue((int)value);
				SetAttributeValue("accountratingcode", optionSetValue); 
			}
		}

		/// <summary>
        /// address2_upszone
        /// </summary>
		[DisplayName("Address 2: UPS Zone")]
		[AttributeLogicalName("address2_upszone")]
		public string Address2UPSZone
		{	
			get { return GetAttributeValue<string>("address2_upszone"); }
			set { SetAttributeValue("address2_upszone", value); }
		}	
			
		/// <summary>
        /// address1_shippingmethodcode
        /// </summary>
		[DisplayName("Address 1: Shipping Method")]
		[AttributeLogicalName("address1_shippingmethodcode")]
		public eAddress1ShippingMethod? Address1ShippingMethod
		{	
			get 
			{ 
				var optionSetValue = GetAttributeValue<OptionSetValue>("address1_shippingmethodcode");
				if (optionSetValue != null) return (eAddress1ShippingMethod)optionSetValue.Value;
				else return null;
			}
			set 
			{ 
				OptionSetValue optionSetValue = null;
				if(value != null) optionSetValue = new OptionSetValue((int)value);
				SetAttributeValue("address1_shippingmethodcode", optionSetValue); 
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
			set { SetAttributeValue("exchangerate", value); }
		}	
			
		/// <summary>
        /// defaultpricelevelid
        /// </summary>
		[DisplayName("Price List")]
		[AttributeLogicalName("defaultpricelevelid")]
		public EntityReference PriceList
		{	
			get { return GetAttributeValue<EntityReference>("defaultpricelevelid"); }
			set { SetAttributeValue("defaultpricelevelid", value); }
		}	
			
		/// <summary>
        /// businesstypecode
        /// </summary>
		[DisplayName("Business Type")]
		[AttributeLogicalName("businesstypecode")]
		public eBusinessType? BusinessType
		{	
			get 
			{ 
				var optionSetValue = GetAttributeValue<OptionSetValue>("businesstypecode");
				if (optionSetValue != null) return (eBusinessType)optionSetValue.Value;
				else return null;
			}
			set 
			{ 
				OptionSetValue optionSetValue = null;
				if(value != null) optionSetValue = new OptionSetValue((int)value);
				SetAttributeValue("businesstypecode", optionSetValue); 
			}
		}

		/// <summary>
        /// address1_line2
        /// </summary>
		[DisplayName("Address 1: Street 2")]
		[AttributeLogicalName("address1_line2")]
		public string Address1Street2
		{	
			get { return GetAttributeValue<string>("address1_line2"); }
			set { SetAttributeValue("address1_line2", value); }
		}	
			
		/// <summary>
        /// donotpostalmail
        /// </summary>
		[DisplayName("Do not allow Mails")]
		[AttributeLogicalName("donotpostalmail")]
		public bool? DoNotAllowMails
		{	
			get { return GetAttributeValue<bool?>("donotpostalmail"); }
			set { SetAttributeValue("donotpostalmail", value); }
		}	
			
		/// <summary>
        /// openrevenue
        /// </summary>
		[DisplayName("Open Revenue")]
		[AttributeLogicalName("openrevenue")]
		public decimal? OpenRevenue
		{	
			get { return GetAttributeValue<Money>("openrevenue")?.Value; }
			set 
			{ 
				Money moneyValue = null;
				if(value != null) moneyValue = new Money(value.Value);
				SetAttributeValue("openrevenue", moneyValue);  
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
			set { SetAttributeValue("ownerid", value); }
		}	
			
		/// <summary>
        /// createdbyexternalpartyyominame
        /// </summary>
		[DisplayName("createdbyexternalpartyyominame")]
		[AttributeLogicalName("createdbyexternalpartyyominame")]
		public string Createdbyexternalpartyyominame
		{	
			get { return GetAttributeValue<string>("createdbyexternalpartyyominame"); }
			set { SetAttributeValue("createdbyexternalpartyyominame", value); }
		}	
			
		/// <summary>
        /// openrevenue_state
        /// </summary>
		[DisplayName("Open Revenue (State)")]
		[AttributeLogicalName("openrevenue_state")]
		public int? OpenRevenueState
		{	
			get { return GetAttributeValue<int?>("openrevenue_state"); }
			set { SetAttributeValue("openrevenue_state", value); }
		}	
			
		/// <summary>
        /// address1_city
        /// </summary>
		[DisplayName("Address 1: City")]
		[AttributeLogicalName("address1_city")]
		public string Address1City
		{	
			get { return GetAttributeValue<string>("address1_city"); }
			set { SetAttributeValue("address1_city", value); }
		}	
			
		/// <summary>
        /// industrycode
        /// </summary>
		[DisplayName("Industry")]
		[AttributeLogicalName("industrycode")]
		public eIndustry? Industry
		{	
			get 
			{ 
				var optionSetValue = GetAttributeValue<OptionSetValue>("industrycode");
				if (optionSetValue != null) return (eIndustry)optionSetValue.Value;
				else return null;
			}
			set 
			{ 
				OptionSetValue optionSetValue = null;
				if(value != null) optionSetValue = new OptionSetValue((int)value);
				SetAttributeValue("industrycode", optionSetValue); 
			}
		}

		/// <summary>
        /// shippingmethodcode
        /// </summary>
		[DisplayName("Shipping Method")]
		[AttributeLogicalName("shippingmethodcode")]
		public eShippingMethod? ShippingMethod
		{	
			get 
			{ 
				var optionSetValue = GetAttributeValue<OptionSetValue>("shippingmethodcode");
				if (optionSetValue != null) return (eShippingMethod)optionSetValue.Value;
				else return null;
			}
			set 
			{ 
				OptionSetValue optionSetValue = null;
				if(value != null) optionSetValue = new OptionSetValue((int)value);
				SetAttributeValue("shippingmethodcode", optionSetValue); 
			}
		}

		/// <summary>
        /// address1_utcoffset
        /// </summary>
		[DisplayName("Address 1: UTC Offset")]
		[AttributeLogicalName("address1_utcoffset")]
		public int? Address1UTCOffset
		{	
			get { return GetAttributeValue<int?>("address1_utcoffset"); }
			set { SetAttributeValue("address1_utcoffset", value); }
		}	
			
		/// <summary>
        /// address2_stateorprovince
        /// </summary>
		[DisplayName("Address 2: State/Province")]
		[AttributeLogicalName("address2_stateorprovince")]
		public string Address2StateProvince
		{	
			get { return GetAttributeValue<string>("address2_stateorprovince"); }
			set { SetAttributeValue("address2_stateorprovince", value); }
		}	
			
		/// <summary>
        /// versionnumber
        /// </summary>
		[DisplayName("Version Number")]
		[AttributeLogicalName("versionnumber")]
		public int? VersionNumber
		{	
			get { return GetAttributeValue<int?>("versionnumber"); }
			set { SetAttributeValue("versionnumber", value); }
		}	
			
		/// <summary>
        /// entityimageid
        /// </summary>
		[DisplayName("Entity Image Id")]
		[AttributeLogicalName("entityimageid")]
		public Guid EntityImageId
		{	
			get { return GetAttributeValue<Guid>("entityimageid"); }
			set { SetAttributeValue("entityimageid", value); }
		}	
			
		/// <summary>
        /// preferredappointmenttimecode
        /// </summary>
		[DisplayName("Preferred Time")]
		[AttributeLogicalName("preferredappointmenttimecode")]
		public ePreferredTime? PreferredTime
		{	
			get 
			{ 
				var optionSetValue = GetAttributeValue<OptionSetValue>("preferredappointmenttimecode");
				if (optionSetValue != null) return (ePreferredTime)optionSetValue.Value;
				else return null;
			}
			set 
			{ 
				OptionSetValue optionSetValue = null;
				if(value != null) optionSetValue = new OptionSetValue((int)value);
				SetAttributeValue("preferredappointmenttimecode", optionSetValue); 
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
			set { SetAttributeValue("createdby", value); }
		}	
			
		/// <summary>
        /// address2_shippingmethodcode
        /// </summary>
		[DisplayName("Address 2: Shipping Method")]
		[AttributeLogicalName("address2_shippingmethodcode")]
		public eAddress2ShippingMethod? Address2ShippingMethod
		{	
			get 
			{ 
				var optionSetValue = GetAttributeValue<OptionSetValue>("address2_shippingmethodcode");
				if (optionSetValue != null) return (eAddress2ShippingMethod)optionSetValue.Value;
				else return null;
			}
			set 
			{ 
				OptionSetValue optionSetValue = null;
				if(value != null) optionSetValue = new OptionSetValue((int)value);
				SetAttributeValue("address2_shippingmethodcode", optionSetValue); 
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
			set { SetAttributeValue("modifiedon", value); }
		}	
			
		/// <summary>
        /// territorycode
        /// </summary>
		[DisplayName("Territory Code")]
		[AttributeLogicalName("territorycode")]
		public eTerritoryCode? TerritoryCode
		{	
			get 
			{ 
				var optionSetValue = GetAttributeValue<OptionSetValue>("territorycode");
				if (optionSetValue != null) return (eTerritoryCode)optionSetValue.Value;
				else return null;
			}
			set 
			{ 
				OptionSetValue optionSetValue = null;
				if(value != null) optionSetValue = new OptionSetValue((int)value);
				SetAttributeValue("territorycode", optionSetValue); 
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
			set { SetAttributeValue("transactioncurrencyid", value); }
		}	
			
		/// <summary>
        /// modifiedbyexternalparty
        /// </summary>
		[DisplayName("Modified By (External Party)")]
		[AttributeLogicalName("modifiedbyexternalparty")]
		public EntityReference ModifiedByExternalParty
		{	
			get { return GetAttributeValue<EntityReference>("modifiedbyexternalparty"); }
			set { SetAttributeValue("modifiedbyexternalparty", value); }
		}	
			
		/// <summary>
        /// createdon
        /// </summary>
		[DisplayName("Created On")]
		[AttributeLogicalName("createdon")]
		public DateTime? CreatedOn
		{	
			get { return GetAttributeValue<DateTime?>("createdon"); }
			set { SetAttributeValue("createdon", value); }
		}	
			
		/// <summary>
        /// marketingonly
        /// </summary>
		[DisplayName("Marketing Only")]
		[AttributeLogicalName("marketingonly")]
		public bool? MarketingOnly
		{	
			get { return GetAttributeValue<bool?>("marketingonly"); }
			set { SetAttributeValue("marketingonly", value); }
		}	
			
		/// <summary>
        /// accountid
        /// </summary>
		[DisplayName("Account")]
		[AttributeLogicalName("accountid")]
		public override Guid Id
		{
			get => base.Id;
			set { base.Id = value; SetAttributeValue("accountid", value); }
		}

							/// <summary>
        /// address2_utcoffset
        /// </summary>
		[DisplayName("Address 2: UTC Offset")]
		[AttributeLogicalName("address2_utcoffset")]
		public int? Address2UTCOffset
		{	
			get { return GetAttributeValue<int?>("address2_utcoffset"); }
			set { SetAttributeValue("address2_utcoffset", value); }
		}	
			
		/// <summary>
        /// aging60
        /// </summary>
		[DisplayName("Aging 60")]
		[AttributeLogicalName("aging60")]
		public decimal? Aging60
		{	
			get { return GetAttributeValue<Money>("aging60")?.Value; }
			set 
			{ 
				Money moneyValue = null;
				if(value != null) moneyValue = new Money(value.Value);
				SetAttributeValue("aging60", moneyValue);  
			}
		}

		/// <summary>
        /// originatingleadidname
        /// </summary>
		[DisplayName("originatingleadidname")]
		[AttributeLogicalName("originatingleadidname")]
		public string Originatingleadidname
		{	
			get { return GetAttributeValue<string>("originatingleadidname"); }
			set { SetAttributeValue("originatingleadidname", value); }
		}	
			
		/// <summary>
        /// opendeals
        /// </summary>
		[DisplayName("Open Deals")]
		[AttributeLogicalName("opendeals")]
		public int? OpenDeals
		{	
			get { return GetAttributeValue<int?>("opendeals"); }
			set { SetAttributeValue("opendeals", value); }
		}	
			
		/// <summary>
        /// modifiedbyyominame
        /// </summary>
		[DisplayName("modifiedbyyominame")]
		[AttributeLogicalName("modifiedbyyominame")]
		public string Modifiedbyyominame
		{	
			get { return GetAttributeValue<string>("modifiedbyyominame"); }
			set { SetAttributeValue("modifiedbyyominame", value); }
		}	
			
		/// <summary>
        /// preferredappointmentdaycode
        /// </summary>
		[DisplayName("Preferred Day")]
		[AttributeLogicalName("preferredappointmentdaycode")]
		public ePreferredDay? PreferredDay
		{	
			get 
			{ 
				var optionSetValue = GetAttributeValue<OptionSetValue>("preferredappointmentdaycode");
				if (optionSetValue != null) return (ePreferredDay)optionSetValue.Value;
				else return null;
			}
			set 
			{ 
				OptionSetValue optionSetValue = null;
				if(value != null) optionSetValue = new OptionSetValue((int)value);
				SetAttributeValue("preferredappointmentdaycode", optionSetValue); 
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
			set { SetAttributeValue("overriddencreatedon", value); }
		}	
			
		/// <summary>
        /// paymenttermscode
        /// </summary>
		[DisplayName("Payment Terms")]
		[AttributeLogicalName("paymenttermscode")]
		public ePaymentTerms? PaymentTerms
		{	
			get 
			{ 
				var optionSetValue = GetAttributeValue<OptionSetValue>("paymenttermscode");
				if (optionSetValue != null) return (ePaymentTerms)optionSetValue.Value;
				else return null;
			}
			set 
			{ 
				OptionSetValue optionSetValue = null;
				if(value != null) optionSetValue = new OptionSetValue((int)value);
				SetAttributeValue("paymenttermscode", optionSetValue); 
			}
		}

		/// <summary>
        /// donotbulkemail
        /// </summary>
		[DisplayName("Do not allow Bulk Emails")]
		[AttributeLogicalName("donotbulkemail")]
		public bool? DoNotAllowBulkEmails
		{	
			get { return GetAttributeValue<bool?>("donotbulkemail"); }
			set { SetAttributeValue("donotbulkemail", value); }
		}	
			
		/// <summary>
        /// modifiedbyname
        /// </summary>
		[DisplayName("modifiedbyname")]
		[AttributeLogicalName("modifiedbyname")]
		public string Modifiedbyname
		{	
			get { return GetAttributeValue<string>("modifiedbyname"); }
			set { SetAttributeValue("modifiedbyname", value); }
		}	
			
		/// <summary>
        /// modifiedonbehalfbyname
        /// </summary>
		[DisplayName("modifiedonbehalfbyname")]
		[AttributeLogicalName("modifiedonbehalfbyname")]
		public string Modifiedonbehalfbyname
		{	
			get { return GetAttributeValue<string>("modifiedonbehalfbyname"); }
			set { SetAttributeValue("modifiedonbehalfbyname", value); }
		}	
			
		/// <summary>
        /// preferredserviceid
        /// </summary>
		[DisplayName("Preferred Service")]
		[AttributeLogicalName("preferredserviceid")]
		public EntityReference PreferredService
		{	
			get { return GetAttributeValue<EntityReference>("preferredserviceid"); }
			set { SetAttributeValue("preferredserviceid", value); }
		}	
			
		/// <summary>
        /// accountclassificationcode
        /// </summary>
		[DisplayName("Classification")]
		[AttributeLogicalName("accountclassificationcode")]
		public eClassification? Classification
		{	
			get 
			{ 
				var optionSetValue = GetAttributeValue<OptionSetValue>("accountclassificationcode");
				if (optionSetValue != null) return (eClassification)optionSetValue.Value;
				else return null;
			}
			set 
			{ 
				OptionSetValue optionSetValue = null;
				if(value != null) optionSetValue = new OptionSetValue((int)value);
				SetAttributeValue("accountclassificationcode", optionSetValue); 
			}
		}

		/// <summary>
        /// preferredequipmentid
        /// </summary>
		[DisplayName("Preferred Facility/Equipment")]
		[AttributeLogicalName("preferredequipmentid")]
		public EntityReference PreferredFacilityEquipment
		{	
			get { return GetAttributeValue<EntityReference>("preferredequipmentid"); }
			set { SetAttributeValue("preferredequipmentid", value); }
		}	
			
		/// <summary>
        /// entityimage_url
        /// </summary>
		[DisplayName("entityimage_url")]
		[AttributeLogicalName("entityimage_url")]
		public string EntityimageUrl
		{	
			get { return GetAttributeValue<string>("entityimage_url"); }
			set { SetAttributeValue("entityimage_url", value); }
		}	
			
		/// <summary>
        /// primarytwitterid
        /// </summary>
		[DisplayName("Primary Twitter ID")]
		[AttributeLogicalName("primarytwitterid")]
		public string PrimaryTwitterID
		{	
			get { return GetAttributeValue<string>("primarytwitterid"); }
			set { SetAttributeValue("primarytwitterid", value); }
		}	
			
		/// <summary>
        /// address2_line2
        /// </summary>
		[DisplayName("Address 2: Street 2")]
		[AttributeLogicalName("address2_line2")]
		public string Address2Street2
		{	
			get { return GetAttributeValue<string>("address2_line2"); }
			set { SetAttributeValue("address2_line2", value); }
		}	
			
		/// <summary>
        /// address1_addresstypecode
        /// </summary>
		[DisplayName("Address 1: Address Type")]
		[AttributeLogicalName("address1_addresstypecode")]
		public eAddress1AddressType? Address1AddressType
		{	
			get 
			{ 
				var optionSetValue = GetAttributeValue<OptionSetValue>("address1_addresstypecode");
				if (optionSetValue != null) return (eAddress1AddressType)optionSetValue.Value;
				else return null;
			}
			set 
			{ 
				OptionSetValue optionSetValue = null;
				if(value != null) optionSetValue = new OptionSetValue((int)value);
				SetAttributeValue("address1_addresstypecode", optionSetValue); 
			}
		}

		/// <summary>
        /// territoryidname
        /// </summary>
		[DisplayName("territoryidname")]
		[AttributeLogicalName("territoryidname")]
		public string Territoryidname
		{	
			get { return GetAttributeValue<string>("territoryidname"); }
			set { SetAttributeValue("territoryidname", value); }
		}	
			
		/// <summary>
        /// revenue
        /// </summary>
		[DisplayName("Annual Revenue")]
		[AttributeLogicalName("revenue")]
		public decimal? AnnualRevenue
		{	
			get { return GetAttributeValue<Money>("revenue")?.Value; }
			set 
			{ 
				Money moneyValue = null;
				if(value != null) moneyValue = new Money(value.Value);
				SetAttributeValue("revenue", moneyValue);  
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
			set { SetAttributeValue("owninguser", value); }
		}	
			
		/// <summary>
        /// yominame
        /// </summary>
		[DisplayName("Yomi Account Name")]
		[AttributeLogicalName("yominame")]
		public string YomiAccountName
		{	
			get { return GetAttributeValue<string>("yominame"); }
			set { SetAttributeValue("yominame", value); }
		}	
			
		/// <summary>
        /// address1_latitude
        /// </summary>
		[DisplayName("Address 1: Latitude")]
		[AttributeLogicalName("address1_latitude")]
		public double? Address1Latitude
		{	
			get { return GetAttributeValue<double?>("address1_latitude"); }
			set { SetAttributeValue("address1_latitude", value); }
		}	
			
		/// <summary>
        /// ownershipcode
        /// </summary>
		[DisplayName("Ownership")]
		[AttributeLogicalName("ownershipcode")]
		public eOwnership? Ownership
		{	
			get 
			{ 
				var optionSetValue = GetAttributeValue<OptionSetValue>("ownershipcode");
				if (optionSetValue != null) return (eOwnership)optionSetValue.Value;
				else return null;
			}
			set 
			{ 
				OptionSetValue optionSetValue = null;
				if(value != null) optionSetValue = new OptionSetValue((int)value);
				SetAttributeValue("ownershipcode", optionSetValue); 
			}
		}

		/// <summary>
        /// primarysatoriid
        /// </summary>
		[DisplayName("Primary Satori ID")]
		[AttributeLogicalName("primarysatoriid")]
		public string PrimarySatoriID
		{	
			get { return GetAttributeValue<string>("primarysatoriid"); }
			set { SetAttributeValue("primarysatoriid", value); }
		}	
			
		/// <summary>
        /// fax
        /// </summary>
		[DisplayName("Fax")]
		[AttributeLogicalName("fax")]
		public string Fax
		{	
			get { return GetAttributeValue<string>("fax"); }
			set { SetAttributeValue("fax", value); }
		}	
			
		/// <summary>
        /// timezoneruleversionnumber
        /// </summary>
		[DisplayName("Time Zone Rule Version Number")]
		[AttributeLogicalName("timezoneruleversionnumber")]
		public int? TimeZoneRuleVersionNumber
		{	
			get { return GetAttributeValue<int?>("timezoneruleversionnumber"); }
			set { SetAttributeValue("timezoneruleversionnumber", value); }
		}	
			
		/// <summary>
        /// createdonbehalfbyyominame
        /// </summary>
		[DisplayName("createdonbehalfbyyominame")]
		[AttributeLogicalName("createdonbehalfbyyominame")]
		public string Createdonbehalfbyyominame
		{	
			get { return GetAttributeValue<string>("createdonbehalfbyyominame"); }
			set { SetAttributeValue("createdonbehalfbyyominame", value); }
		}	
			
		/// <summary>
        /// donotbulkpostalmail
        /// </summary>
		[DisplayName("Do not allow Bulk Mails")]
		[AttributeLogicalName("donotbulkpostalmail")]
		public bool? DoNotAllowBulkMails
		{	
			get { return GetAttributeValue<bool?>("donotbulkpostalmail"); }
			set { SetAttributeValue("donotbulkpostalmail", value); }
		}	
			
		/// <summary>
        /// address2_composite
        /// </summary>
		[DisplayName("Address 2")]
		[AttributeLogicalName("address2_composite")]
		public string Address2
		{	
			get { return GetAttributeValue<string>("address2_composite"); }
			set { SetAttributeValue("address2_composite", value); }
		}	
			
		/// <summary>
        /// owneridtype
        /// </summary>
		[DisplayName("owneridtype")]
		[AttributeLogicalName("owneridtype")]
		public string Owneridtype
		{	
			get { return GetAttributeValue<string>("owneridtype"); }
			set { SetAttributeValue("owneridtype", value); }
		}	
			
		/// <summary>
        /// address1_name
        /// </summary>
		[DisplayName("Address 1: Name")]
		[AttributeLogicalName("address1_name")]
		public string Address1Name
		{	
			get { return GetAttributeValue<string>("address1_name"); }
			set { SetAttributeValue("address1_name", value); }
		}	
			
		/// <summary>
        /// parentaccountidname
        /// </summary>
		[DisplayName("parentaccountidname")]
		[AttributeLogicalName("parentaccountidname")]
		public string Parentaccountidname
		{	
			get { return GetAttributeValue<string>("parentaccountidname"); }
			set { SetAttributeValue("parentaccountidname", value); }
		}	
			
		/// <summary>
        /// telephone3
        /// </summary>
		[DisplayName("Telephone 3")]
		[AttributeLogicalName("telephone3")]
		public string Telephone3
		{	
			get { return GetAttributeValue<string>("telephone3"); }
			set { SetAttributeValue("telephone3", value); }
		}	
			
		/// <summary>
        /// parentaccountidyominame
        /// </summary>
		[DisplayName("parentaccountidyominame")]
		[AttributeLogicalName("parentaccountidyominame")]
		public string Parentaccountidyominame
		{	
			get { return GetAttributeValue<string>("parentaccountidyominame"); }
			set { SetAttributeValue("parentaccountidyominame", value); }
		}	
			
		/// <summary>
        /// owningteam
        /// </summary>
		[DisplayName("Owning Team")]
		[AttributeLogicalName("owningteam")]
		public EntityReference OwningTeam
		{	
			get { return GetAttributeValue<EntityReference>("owningteam"); }
			set { SetAttributeValue("owningteam", value); }
		}	
			
		/// <summary>
        /// entityimage_timestamp
        /// </summary>
		[DisplayName("entityimage_timestamp")]
		[AttributeLogicalName("entityimage_timestamp")]
		public int? EntityimageTimestamp
		{	
			get { return GetAttributeValue<int?>("entityimage_timestamp"); }
			set { SetAttributeValue("entityimage_timestamp", value); }
		}	
			
		/// <summary>
        /// modifiedbyexternalpartyname
        /// </summary>
		[DisplayName("modifiedbyexternalpartyname")]
		[AttributeLogicalName("modifiedbyexternalpartyname")]
		public string Modifiedbyexternalpartyname
		{	
			get { return GetAttributeValue<string>("modifiedbyexternalpartyname"); }
			set { SetAttributeValue("modifiedbyexternalpartyname", value); }
		}	
			
		/// <summary>
        /// emailaddress3
        /// </summary>
		[DisplayName("Email Address 3")]
		[AttributeLogicalName("emailaddress3")]
		public string EmailAddress3
		{	
			get { return GetAttributeValue<string>("emailaddress3"); }
			set { SetAttributeValue("emailaddress3", value); }
		}	
			
		/// <summary>
        /// emailaddress2
        /// </summary>
		[DisplayName("Email Address 2")]
		[AttributeLogicalName("emailaddress2")]
		public string EmailAddress2
		{	
			get { return GetAttributeValue<string>("emailaddress2"); }
			set { SetAttributeValue("emailaddress2", value); }
		}	
			
		/// <summary>
        /// createdonbehalfby
        /// </summary>
		[DisplayName("Created By (Delegate)")]
		[AttributeLogicalName("createdonbehalfby")]
		public EntityReference CreatedByDelegate
		{	
			get { return GetAttributeValue<EntityReference>("createdonbehalfby"); }
			set { SetAttributeValue("createdonbehalfby", value); }
		}	
			
		/// <summary>
        /// creditlimit
        /// </summary>
		[DisplayName("Credit Limit")]
		[AttributeLogicalName("creditlimit")]
		public decimal? CreditLimit
		{	
			get { return GetAttributeValue<Money>("creditlimit")?.Value; }
			set 
			{ 
				Money moneyValue = null;
				if(value != null) moneyValue = new Money(value.Value);
				SetAttributeValue("creditlimit", moneyValue);  
			}
		}

		/// <summary>
        /// teamsfollowed
        /// </summary>
		[DisplayName("TeamsFollowed")]
		[AttributeLogicalName("teamsfollowed")]
		public int? TeamsFollowed
		{	
			get { return GetAttributeValue<int?>("teamsfollowed"); }
			set { SetAttributeValue("teamsfollowed", value); }
		}	
			
		/// <summary>
        /// aging30
        /// </summary>
		[DisplayName("Aging 30")]
		[AttributeLogicalName("aging30")]
		public decimal? Aging30
		{	
			get { return GetAttributeValue<Money>("aging30")?.Value; }
			set 
			{ 
				Money moneyValue = null;
				if(value != null) moneyValue = new Money(value.Value);
				SetAttributeValue("aging30", moneyValue);  
			}
		}

		/// <summary>
        /// address2_country
        /// </summary>
		[DisplayName("Address 2: Country/Region")]
		[AttributeLogicalName("address2_country")]
		public string Address2CountryRegion
		{	
			get { return GetAttributeValue<string>("address2_country"); }
			set { SetAttributeValue("address2_country", value); }
		}	
			
		/// <summary>
        /// telephone2
        /// </summary>
		[DisplayName("Other Phone")]
		[AttributeLogicalName("telephone2")]
		public string OtherPhone
		{	
			get { return GetAttributeValue<string>("telephone2"); }
			set { SetAttributeValue("telephone2", value); }
		}	
			
		/// <summary>
        /// createdbyexternalpartyname
        /// </summary>
		[DisplayName("createdbyexternalpartyname")]
		[AttributeLogicalName("createdbyexternalpartyname")]
		public string Createdbyexternalpartyname
		{	
			get { return GetAttributeValue<string>("createdbyexternalpartyname"); }
			set { SetAttributeValue("createdbyexternalpartyname", value); }
		}	
			
		/// <summary>
        /// lastusedincampaign
        /// </summary>
		[DisplayName("Last Date Included in Campaign")]
		[AttributeLogicalName("lastusedincampaign")]
		public DateTime? LastDateIncludedInCampaign
		{	
			get { return GetAttributeValue<DateTime?>("lastusedincampaign"); }
			set { SetAttributeValue("lastusedincampaign", value); }
		}	
			
		/// <summary>
        /// preferredequipmentidname
        /// </summary>
		[DisplayName("preferredequipmentidname")]
		[AttributeLogicalName("preferredequipmentidname")]
		public string Preferredequipmentidname
		{	
			get { return GetAttributeValue<string>("preferredequipmentidname"); }
			set { SetAttributeValue("preferredequipmentidname", value); }
		}	
			
		/// <summary>
        /// accountnumber
        /// </summary>
		[DisplayName("Account Number")]
		[AttributeLogicalName("accountnumber")]
		public string AccountNumber
		{	
			get { return GetAttributeValue<string>("accountnumber"); }
			set { SetAttributeValue("accountnumber", value); }
		}	
			
		/// <summary>
        /// slainvokedid
        /// </summary>
		[DisplayName("Last SLA applied")]
		[AttributeLogicalName("slainvokedid")]
		public EntityReference LastSLAApplied
		{	
			get { return GetAttributeValue<EntityReference>("slainvokedid"); }
			set { SetAttributeValue("slainvokedid", value); }
		}	
			
		/// <summary>
        /// masterid
        /// </summary>
		[DisplayName("Master ID")]
		[AttributeLogicalName("masterid")]
		public EntityReference MasterID
		{	
			get { return GetAttributeValue<EntityReference>("masterid"); }
			set { SetAttributeValue("masterid", value); }
		}	
			
		/// <summary>
        /// traversedpath
        /// </summary>
		[DisplayName("(Deprecated) Traversed Path")]
		[AttributeLogicalName("traversedpath")]
		public string DeprecatedTraversedPath
		{	
			get { return GetAttributeValue<string>("traversedpath"); }
			set { SetAttributeValue("traversedpath", value); }
		}	
			
		/// <summary>
        /// primarycontactidname
        /// </summary>
		[DisplayName("primarycontactidname")]
		[AttributeLogicalName("primarycontactidname")]
		public string Primarycontactidname
		{	
			get { return GetAttributeValue<string>("primarycontactidname"); }
			set { SetAttributeValue("primarycontactidname", value); }
		}	
			
		/// <summary>
        /// timespentbymeonemailandmeetings
        /// </summary>
		[DisplayName("Time Spent by me")]
		[AttributeLogicalName("timespentbymeonemailandmeetings")]
		public string TimeSpentByMe
		{	
			get { return GetAttributeValue<string>("timespentbymeonemailandmeetings"); }
			set { SetAttributeValue("timespentbymeonemailandmeetings", value); }
		}	
			
		/// <summary>
        /// address1_primarycontactname
        /// </summary>
		[DisplayName("Address 1: Primary Contact Name")]
		[AttributeLogicalName("address1_primarycontactname")]
		public string Address1PrimaryContactName
		{	
			get { return GetAttributeValue<string>("address1_primarycontactname"); }
			set { SetAttributeValue("address1_primarycontactname", value); }
		}	
			
		/// <summary>
        /// donotphone
        /// </summary>
		[DisplayName("Do not allow Phone Calls")]
		[AttributeLogicalName("donotphone")]
		public bool? DoNotAllowPhoneCalls
		{	
			get { return GetAttributeValue<bool?>("donotphone"); }
			set { SetAttributeValue("donotphone", value); }
		}	
			
		/// <summary>
        /// preferredsystemuseridname
        /// </summary>
		[DisplayName("preferredsystemuseridname")]
		[AttributeLogicalName("preferredsystemuseridname")]
		public string Preferredsystemuseridname
		{	
			get { return GetAttributeValue<string>("preferredsystemuseridname"); }
			set { SetAttributeValue("preferredsystemuseridname", value); }
		}	
			
		/// <summary>
        /// createdonbehalfbyname
        /// </summary>
		[DisplayName("createdonbehalfbyname")]
		[AttributeLogicalName("createdonbehalfbyname")]
		public string Createdonbehalfbyname
		{	
			get { return GetAttributeValue<string>("createdonbehalfbyname"); }
			set { SetAttributeValue("createdonbehalfbyname", value); }
		}	
			
		/// <summary>
        /// address2_freighttermscode
        /// </summary>
		[DisplayName("Address 2: Freight Terms")]
		[AttributeLogicalName("address2_freighttermscode")]
		public eAddress2FreightTerms? Address2FreightTerms
		{	
			get 
			{ 
				var optionSetValue = GetAttributeValue<OptionSetValue>("address2_freighttermscode");
				if (optionSetValue != null) return (eAddress2FreightTerms)optionSetValue.Value;
				else return null;
			}
			set 
			{ 
				OptionSetValue optionSetValue = null;
				if(value != null) optionSetValue = new OptionSetValue((int)value);
				SetAttributeValue("address2_freighttermscode", optionSetValue); 
			}
		}

		/// <summary>
        /// address2_postofficebox
        /// </summary>
		[DisplayName("Address 2: Post Office Box")]
		[AttributeLogicalName("address2_postofficebox")]
		public string Address2PostOfficeBox
		{	
			get { return GetAttributeValue<string>("address2_postofficebox"); }
			set { SetAttributeValue("address2_postofficebox", value); }
		}	
			
		/// <summary>
        /// donotsendmm
        /// </summary>
		[DisplayName("Send Marketing Materials")]
		[AttributeLogicalName("donotsendmm")]
		public bool? SendMarketingMaterials
		{	
			get { return GetAttributeValue<bool?>("donotsendmm"); }
			set { SetAttributeValue("donotsendmm", value); }
		}	
			
		/// <summary>
        /// address2_latitude
        /// </summary>
		[DisplayName("Address 2: Latitude")]
		[AttributeLogicalName("address2_latitude")]
		public double? Address2Latitude
		{	
			get { return GetAttributeValue<double?>("address2_latitude"); }
			set { SetAttributeValue("address2_latitude", value); }
		}	
			
		/// <summary>
        /// parentaccountid
        /// </summary>
		[DisplayName("Parent Account")]
		[AttributeLogicalName("parentaccountid")]
		public EntityReference ParentAccount
		{	
			get { return GetAttributeValue<EntityReference>("parentaccountid"); }
			set { SetAttributeValue("parentaccountid", value); }
		}	
			
		/// <summary>
        /// modifiedbyexternalpartyyominame
        /// </summary>
		[DisplayName("modifiedbyexternalpartyyominame")]
		[AttributeLogicalName("modifiedbyexternalpartyyominame")]
		public string Modifiedbyexternalpartyyominame
		{	
			get { return GetAttributeValue<string>("modifiedbyexternalpartyyominame"); }
			set { SetAttributeValue("modifiedbyexternalpartyyominame", value); }
		}	
			
		/// <summary>
        /// primarycontactidyominame
        /// </summary>
		[DisplayName("primarycontactidyominame")]
		[AttributeLogicalName("primarycontactidyominame")]
		public string Primarycontactidyominame
		{	
			get { return GetAttributeValue<string>("primarycontactidyominame"); }
			set { SetAttributeValue("primarycontactidyominame", value); }
		}	
			
		/// <summary>
        /// preferredsystemuserid
        /// </summary>
		[DisplayName("Preferred User")]
		[AttributeLogicalName("preferredsystemuserid")]
		public EntityReference PreferredUser
		{	
			get { return GetAttributeValue<EntityReference>("preferredsystemuserid"); }
			set { SetAttributeValue("preferredsystemuserid", value); }
		}	
			
		/// <summary>
        /// primarycontactid
        /// </summary>
		[DisplayName("Primary Contact")]
		[AttributeLogicalName("primarycontactid")]
		public EntityReference PrimaryContact
		{	
			get { return GetAttributeValue<EntityReference>("primarycontactid"); }
			set { SetAttributeValue("primarycontactid", value); }
		}	
			
		/// <summary>
        /// slaid
        /// </summary>
		[DisplayName("SLA")]
		[AttributeLogicalName("slaid")]
		public EntityReference SLA
		{	
			get { return GetAttributeValue<EntityReference>("slaid"); }
			set { SetAttributeValue("slaid", value); }
		}	
			
		/// <summary>
        /// territoryid
        /// </summary>
		[DisplayName("Territory")]
		[AttributeLogicalName("territoryid")]
		public EntityReference Territory
		{	
			get { return GetAttributeValue<EntityReference>("territoryid"); }
			set { SetAttributeValue("territoryid", value); }
		}	
			
		/// <summary>
        /// slaname
        /// </summary>
		[DisplayName("slaname")]
		[AttributeLogicalName("slaname")]
		public string Slaname
		{	
			get { return GetAttributeValue<string>("slaname"); }
			set { SetAttributeValue("slaname", value); }
		}	
			
		/// <summary>
        /// address1_composite
        /// </summary>
		[DisplayName("Address 1")]
		[AttributeLogicalName("address1_composite")]
		public string Address1
		{	
			get { return GetAttributeValue<string>("address1_composite"); }
			set { SetAttributeValue("address1_composite", value); }
		}	
			
		/// <summary>
        /// ftpsiteurl
        /// </summary>
		[DisplayName("FTP Site")]
		[AttributeLogicalName("ftpsiteurl")]
		public string FTPSite
		{	
			get { return GetAttributeValue<string>("ftpsiteurl"); }
			set { SetAttributeValue("ftpsiteurl", value); }
		}	
			
		/// <summary>
        /// opendeals_state
        /// </summary>
		[DisplayName("Open Deals (State)")]
		[AttributeLogicalName("opendeals_state")]
		public int? OpenDealsState
		{	
			get { return GetAttributeValue<int?>("opendeals_state"); }
			set { SetAttributeValue("opendeals_state", value); }
		}	
			
		/// <summary>
        /// isprivate
        /// </summary>
		[DisplayName("isprivate")]
		[AttributeLogicalName("isprivate")]
		public bool? Isprivate
		{	
			get { return GetAttributeValue<bool?>("isprivate"); }
			set { SetAttributeValue("isprivate", value); }
		}	
			
		/// <summary>
        /// sic
        /// </summary>
		[DisplayName("SIC Code")]
		[AttributeLogicalName("sic")]
		public string SICCode
		{	
			get { return GetAttributeValue<string>("sic"); }
			set { SetAttributeValue("sic", value); }
		}	
			
		/// <summary>
        /// address2_line1
        /// </summary>
		[DisplayName("Address 2: Street 1")]
		[AttributeLogicalName("address2_line1")]
		public string Address2Street1
		{	
			get { return GetAttributeValue<string>("address2_line1"); }
			set { SetAttributeValue("address2_line1", value); }
		}	
			
		/// <summary>
        /// lastonholdtime
        /// </summary>
		[DisplayName("Last On Hold Time")]
		[AttributeLogicalName("lastonholdtime")]
		public DateTime? LastOnHoldTime
		{	
			get { return GetAttributeValue<DateTime?>("lastonholdtime"); }
			set { SetAttributeValue("lastonholdtime", value); }
		}	
			
		/// <summary>
        /// address1_telephone1
        /// </summary>
		[DisplayName("Address Phone")]
		[AttributeLogicalName("address1_telephone1")]
		public string AddressPhone
		{	
			get { return GetAttributeValue<string>("address1_telephone1"); }
			set { SetAttributeValue("address1_telephone1", value); }
		}	
			
		/// <summary>
        /// address2_fax
        /// </summary>
		[DisplayName("Address 2: Fax")]
		[AttributeLogicalName("address2_fax")]
		public string Address2Fax
		{	
			get { return GetAttributeValue<string>("address2_fax"); }
			set { SetAttributeValue("address2_fax", value); }
		}	
			
		/// <summary>
        /// address1_telephone3
        /// </summary>
		[DisplayName("Address 1: Telephone 3")]
		[AttributeLogicalName("address1_telephone3")]
		public string Address1Telephone3
		{	
			get { return GetAttributeValue<string>("address1_telephone3"); }
			set { SetAttributeValue("address1_telephone3", value); }
		}	
			
		/// <summary>
        /// description
        /// </summary>
		[DisplayName("Description")]
		[AttributeLogicalName("description")]
		public string Description
		{	
			get { return GetAttributeValue<string>("description"); }
			set { SetAttributeValue("description", value); }
		}	
			
		/// <summary>
        /// stageid
        /// </summary>
		[DisplayName("(Deprecated) Process Stage")]
		[AttributeLogicalName("stageid")]
		public Guid DeprecatedProcessStageId
		{	
			get { return GetAttributeValue<Guid>("stageid"); }
			set { SetAttributeValue("stageid", value); }
		}	
			
		/// <summary>
        /// address2_addresstypecode
        /// </summary>
		[DisplayName("Address 2: Address Type")]
		[AttributeLogicalName("address2_addresstypecode")]
		public eAddress2AddressType? Address2AddressType
		{	
			get 
			{ 
				var optionSetValue = GetAttributeValue<OptionSetValue>("address2_addresstypecode");
				if (optionSetValue != null) return (eAddress2AddressType)optionSetValue.Value;
				else return null;
			}
			set 
			{ 
				OptionSetValue optionSetValue = null;
				if(value != null) optionSetValue = new OptionSetValue((int)value);
				SetAttributeValue("address2_addresstypecode", optionSetValue); 
			}
		}

		/// <summary>
        /// telephone1
        /// </summary>
		[DisplayName("Main Phone")]
		[AttributeLogicalName("telephone1")]
		public string MainPhone
		{	
			get { return GetAttributeValue<string>("telephone1"); }
			set { SetAttributeValue("telephone1", value); }
		}	
			
		/// <summary>
        /// websiteurl
        /// </summary>
		[DisplayName("Website")]
		[AttributeLogicalName("websiteurl")]
		public string Website
		{	
			get { return GetAttributeValue<string>("websiteurl"); }
			set { SetAttributeValue("websiteurl", value); }
		}	
			
		/// <summary>
        /// utcconversiontimezonecode
        /// </summary>
		[DisplayName("UTC Conversion Time Zone Code")]
		[AttributeLogicalName("utcconversiontimezonecode")]
		public int? UTCConversionTimeZoneCode
		{	
			get { return GetAttributeValue<int?>("utcconversiontimezonecode"); }
			set { SetAttributeValue("utcconversiontimezonecode", value); }
		}	
			
		/// <summary>
        /// stockexchange
        /// </summary>
		[DisplayName("Stock Exchange")]
		[AttributeLogicalName("stockexchange")]
		public string StockExchange
		{	
			get { return GetAttributeValue<string>("stockexchange"); }
			set { SetAttributeValue("stockexchange", value); }
		}	
			
		/// <summary>
        /// originatingleadid
        /// </summary>
		[DisplayName("Originating Lead")]
		[AttributeLogicalName("originatingleadid")]
		public EntityReference OriginatingLead
		{	
			get { return GetAttributeValue<EntityReference>("originatingleadid"); }
			set { SetAttributeValue("originatingleadid", value); }
		}	
			
		/// <summary>
        /// address1_addressid
        /// </summary>
		[DisplayName("Address 1: ID")]
		[AttributeLogicalName("address1_addressid")]
		public Guid Address1Id
		{	
			get { return GetAttributeValue<Guid>("address1_addressid"); }
			set { SetAttributeValue("address1_addressid", value); }
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
				OptionSetValue optionSetValue = null;
				if(value != null) optionSetValue = new OptionSetValue((int)value);
				SetAttributeValue("statecode", optionSetValue); 
			}
		}

		/// <summary>
        /// participatesinworkflow
        /// </summary>
		[DisplayName("Participates in Workflow")]
		[AttributeLogicalName("participatesinworkflow")]
		public bool? ParticipatesInWorkflow
		{	
			get { return GetAttributeValue<bool?>("participatesinworkflow"); }
			set { SetAttributeValue("participatesinworkflow", value); }
		}	
			
		/// <summary>
        /// address2_city
        /// </summary>
		[DisplayName("Address 2: City")]
		[AttributeLogicalName("address2_city")]
		public string Address2City
		{	
			get { return GetAttributeValue<string>("address2_city"); }
			set { SetAttributeValue("address2_city", value); }
		}	
			
		/// <summary>
        /// address1_freighttermscode
        /// </summary>
		[DisplayName("Address 1: Freight Terms")]
		[AttributeLogicalName("address1_freighttermscode")]
		public eAddress1FreightTerms? Address1FreightTerms
		{	
			get 
			{ 
				var optionSetValue = GetAttributeValue<OptionSetValue>("address1_freighttermscode");
				if (optionSetValue != null) return (eAddress1FreightTerms)optionSetValue.Value;
				else return null;
			}
			set 
			{ 
				OptionSetValue optionSetValue = null;
				if(value != null) optionSetValue = new OptionSetValue((int)value);
				SetAttributeValue("address1_freighttermscode", optionSetValue); 
			}
		}

		/// <summary>
        /// address2_primarycontactname
        /// </summary>
		[DisplayName("Address 2: Primary Contact Name")]
		[AttributeLogicalName("address2_primarycontactname")]
		public string Address2PrimaryContactName
		{	
			get { return GetAttributeValue<string>("address2_primarycontactname"); }
			set { SetAttributeValue("address2_primarycontactname", value); }
		}	
			
		/// <summary>
        /// merged
        /// </summary>
		[DisplayName("Merged")]
		[AttributeLogicalName("merged")]
		public bool? Merged
		{	
			get { return GetAttributeValue<bool?>("merged"); }
			set { SetAttributeValue("merged", value); }
		}	
			
		/// <summary>
        /// createdbyexternalparty
        /// </summary>
		[DisplayName("Created By (External Party)")]
		[AttributeLogicalName("createdbyexternalparty")]
		public EntityReference CreatedByExternalParty
		{	
			get { return GetAttributeValue<EntityReference>("createdbyexternalparty"); }
			set { SetAttributeValue("createdbyexternalparty", value); }
		}	
			
		/// <summary>
        /// address2_addressid
        /// </summary>
		[DisplayName("Address 2: ID")]
		[AttributeLogicalName("address2_addressid")]
		public Guid Address2Id
		{	
			get { return GetAttributeValue<Guid>("address2_addressid"); }
			set { SetAttributeValue("address2_addressid", value); }
		}	
			
		/// <summary>
        /// onholdtime
        /// </summary>
		[DisplayName("On Hold Time (Minutes)")]
		[AttributeLogicalName("onholdtime")]
		public int? OnHoldTimeMinutes
		{	
			get { return GetAttributeValue<int?>("onholdtime"); }
			set { SetAttributeValue("onholdtime", value); }
		}	
			
		/// <summary>
        /// address1_line1
        /// </summary>
		[DisplayName("Address 1: Street 1")]
		[AttributeLogicalName("address1_line1")]
		public string Address1Street1
		{	
			get { return GetAttributeValue<string>("address1_line1"); }
			set { SetAttributeValue("address1_line1", value); }
		}	
			
		/// <summary>
        /// address1_line3
        /// </summary>
		[DisplayName("Address 1: Street 3")]
		[AttributeLogicalName("address1_line3")]
		public string Address1Street3
		{	
			get { return GetAttributeValue<string>("address1_line3"); }
			set { SetAttributeValue("address1_line3", value); }
		}	
			
		/// <summary>
        /// creditonhold
        /// </summary>
		[DisplayName("Credit Hold")]
		[AttributeLogicalName("creditonhold")]
		public bool? CreditHold
		{	
			get { return GetAttributeValue<bool?>("creditonhold"); }
			set { SetAttributeValue("creditonhold", value); }
		}	
			
		/// <summary>
        /// donotfax
        /// </summary>
		[DisplayName("Do not allow Faxes")]
		[AttributeLogicalName("donotfax")]
		public bool? DoNotAllowFaxes
		{	
			get { return GetAttributeValue<bool?>("donotfax"); }
			set { SetAttributeValue("donotfax", value); }
		}	
			
		/// <summary>
        /// createdbyyominame
        /// </summary>
		[DisplayName("createdbyyominame")]
		[AttributeLogicalName("createdbyyominame")]
		public string Createdbyyominame
		{	
			get { return GetAttributeValue<string>("createdbyyominame"); }
			set { SetAttributeValue("createdbyyominame", value); }
		}	
			
		/// <summary>
        /// customersizecode
        /// </summary>
		[DisplayName("Customer Size")]
		[AttributeLogicalName("customersizecode")]
		public eCustomerSize? CustomerSize
		{	
			get 
			{ 
				var optionSetValue = GetAttributeValue<OptionSetValue>("customersizecode");
				if (optionSetValue != null) return (eCustomerSize)optionSetValue.Value;
				else return null;
			}
			set 
			{ 
				OptionSetValue optionSetValue = null;
				if(value != null) optionSetValue = new OptionSetValue((int)value);
				SetAttributeValue("customersizecode", optionSetValue); 
			}
		}

		/// <summary>
        /// address2_telephone1
        /// </summary>
		[DisplayName("Address 2: Telephone 1")]
		[AttributeLogicalName("address2_telephone1")]
		public string Address2Telephone1
		{	
			get { return GetAttributeValue<string>("address2_telephone1"); }
			set { SetAttributeValue("address2_telephone1", value); }
		}	
			
		/// <summary>
        /// address2_telephone2
        /// </summary>
		[DisplayName("Address 2: Telephone 2")]
		[AttributeLogicalName("address2_telephone2")]
		public string Address2Telephone2
		{	
			get { return GetAttributeValue<string>("address2_telephone2"); }
			set { SetAttributeValue("address2_telephone2", value); }
		}	
			
		/// <summary>
        /// address2_telephone3
        /// </summary>
		[DisplayName("Address 2: Telephone 3")]
		[AttributeLogicalName("address2_telephone3")]
		public string Address2Telephone3
		{	
			get { return GetAttributeValue<string>("address2_telephone3"); }
			set { SetAttributeValue("address2_telephone3", value); }
		}	
			
		/// <summary>
        /// address1_postofficebox
        /// </summary>
		[DisplayName("Address 1: Post Office Box")]
		[AttributeLogicalName("address1_postofficebox")]
		public string Address1PostOfficeBox
		{	
			get { return GetAttributeValue<string>("address1_postofficebox"); }
			set { SetAttributeValue("address1_postofficebox", value); }
		}	
			
		/// <summary>
        /// customertypecode
        /// </summary>
		[DisplayName("Relationship Type")]
		[AttributeLogicalName("customertypecode")]
		public eRelationshipType? RelationshipType
		{	
			get 
			{ 
				var optionSetValue = GetAttributeValue<OptionSetValue>("customertypecode");
				if (optionSetValue != null) return (eRelationshipType)optionSetValue.Value;
				else return null;
			}
			set 
			{ 
				OptionSetValue optionSetValue = null;
				if(value != null) optionSetValue = new OptionSetValue((int)value);
				SetAttributeValue("customertypecode", optionSetValue); 
			}
		}

		/// <summary>
        /// donotemail
        /// </summary>
		[DisplayName("Do not allow Emails")]
		[AttributeLogicalName("donotemail")]
		public bool? DoNotAllowEmails
		{	
			get { return GetAttributeValue<bool?>("donotemail"); }
			set { SetAttributeValue("donotemail", value); }
		}	
			
		/// <summary>
        /// createdbyname
        /// </summary>
		[DisplayName("createdbyname")]
		[AttributeLogicalName("createdbyname")]
		public string Createdbyname
		{	
			get { return GetAttributeValue<string>("createdbyname"); }
			set { SetAttributeValue("createdbyname", value); }
		}	
			
		/// <summary>
        /// accountcategorycode
        /// </summary>
		[DisplayName("Category")]
		[AttributeLogicalName("accountcategorycode")]
		public eCategory? Category
		{	
			get 
			{ 
				var optionSetValue = GetAttributeValue<OptionSetValue>("accountcategorycode");
				if (optionSetValue != null) return (eCategory)optionSetValue.Value;
				else return null;
			}
			set 
			{ 
				OptionSetValue optionSetValue = null;
				if(value != null) optionSetValue = new OptionSetValue((int)value);
				SetAttributeValue("accountcategorycode", optionSetValue); 
			}
		}

		/// <summary>
        /// tickersymbol
        /// </summary>
		[DisplayName("Ticker Symbol")]
		[AttributeLogicalName("tickersymbol")]
		public string TickerSymbol
		{	
			get { return GetAttributeValue<string>("tickersymbol"); }
			set { SetAttributeValue("tickersymbol", value); }
		}	
			
		/// <summary>
        /// preferredserviceidname
        /// </summary>
		[DisplayName("preferredserviceidname")]
		[AttributeLogicalName("preferredserviceidname")]
		public string Preferredserviceidname
		{	
			get { return GetAttributeValue<string>("preferredserviceidname"); }
			set { SetAttributeValue("preferredserviceidname", value); }
		}	
			
		/// <summary>
        /// numberofemployees
        /// </summary>
		[DisplayName("Number of Employees")]
		[AttributeLogicalName("numberofemployees")]
		public int? NumberOfEmployees
		{	
			get { return GetAttributeValue<int?>("numberofemployees"); }
			set { SetAttributeValue("numberofemployees", value); }
		}	
			
		/// <summary>
        /// owneridname
        /// </summary>
		[DisplayName("owneridname")]
		[AttributeLogicalName("owneridname")]
		public string Owneridname
		{	
			get { return GetAttributeValue<string>("owneridname"); }
			set { SetAttributeValue("owneridname", value); }
		}	
			
		/// <summary>
        /// modifiedonbehalfbyyominame
        /// </summary>
		[DisplayName("modifiedonbehalfbyyominame")]
		[AttributeLogicalName("modifiedonbehalfbyyominame")]
		public string Modifiedonbehalfbyyominame
		{	
			get { return GetAttributeValue<string>("modifiedonbehalfbyyominame"); }
			set { SetAttributeValue("modifiedonbehalfbyyominame", value); }
		}	
			
		/// <summary>
        /// address1_fax
        /// </summary>
		[DisplayName("Address 1: Fax")]
		[AttributeLogicalName("address1_fax")]
		public string Address1Fax
		{	
			get { return GetAttributeValue<string>("address1_fax"); }
			set { SetAttributeValue("address1_fax", value); }
		}	
			
		/// <summary>
        /// importsequencenumber
        /// </summary>
		[DisplayName("Import Sequence Number")]
		[AttributeLogicalName("importsequencenumber")]
		public int? ImportSequenceNumber
		{	
			get { return GetAttributeValue<int?>("importsequencenumber"); }
			set { SetAttributeValue("importsequencenumber", value); }
		}	
			
		/// <summary>
        /// followemail
        /// </summary>
		[DisplayName("Follow Email Activity")]
		[AttributeLogicalName("followemail")]
		public bool? FollowEmailActivity
		{	
			get { return GetAttributeValue<bool?>("followemail"); }
			set { SetAttributeValue("followemail", value); }
		}	
			
		/// <summary>
        /// name
        /// </summary>
		[DisplayName("Account Name")]
		[AttributeLogicalName("name")]
		public string AccountName
		{	
			get { return GetAttributeValue<string>("name"); }
			set { SetAttributeValue("name", value); }
		}	
			
		/// <summary>
        /// slainvokedidname
        /// </summary>
		[DisplayName("slainvokedidname")]
		[AttributeLogicalName("slainvokedidname")]
		public string Slainvokedidname
		{	
			get { return GetAttributeValue<string>("slainvokedidname"); }
			set { SetAttributeValue("slainvokedidname", value); }
		}	
			
		/// <summary>
        /// preferredsystemuseridyominame
        /// </summary>
		[DisplayName("preferredsystemuseridyominame")]
		[AttributeLogicalName("preferredsystemuseridyominame")]
		public string Preferredsystemuseridyominame
		{	
			get { return GetAttributeValue<string>("preferredsystemuseridyominame"); }
			set { SetAttributeValue("preferredsystemuseridyominame", value); }
		}	
			
		/// <summary>
        /// sharesoutstanding
        /// </summary>
		[DisplayName("Shares Outstanding")]
		[AttributeLogicalName("sharesoutstanding")]
		public int? SharesOutstanding
		{	
			get { return GetAttributeValue<int?>("sharesoutstanding"); }
			set { SetAttributeValue("sharesoutstanding", value); }
		}	
			
		/// <summary>
        /// address1_postalcode
        /// </summary>
		[DisplayName("Address 1: ZIP/Postal Code")]
		[AttributeLogicalName("address1_postalcode")]
		public string Address1ZIPPostalCode
		{	
			get { return GetAttributeValue<string>("address1_postalcode"); }
			set { SetAttributeValue("address1_postalcode", value); }
		}	
			
		#endregion	
	
		#region OptionSetEnums
		public enum ePreferredMethodOfContact
		{	
		
			[Label("Any")]
			[Description(@"")]
			Any = 1, 
		
			[Label("Email")]
			[Description(@"")]
			Email = 2, 
		
			[Label("Phone")]
			[Description(@"")]
			Phone = 3, 
		
			[Label("Fax")]
			[Description(@"")]
			Fax = 4, 
		
			[Label("Mail")]
			[Description(@"")]
			Mail = 5, 
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
		
		public enum eAccountRating
		{	
		
			[Label("Default Value")]
			[Description(@"")]
			DefaultValue = 1, 
		}
		
		public enum eAddress1ShippingMethod
		{	
		
			[Label("Airborne")]
			[Description(@"")]
			Airborne = 1, 
		
			[Label("DHL")]
			[Description(@"")]
			DHL = 2, 
		
			[Label("FedEx")]
			[Description(@"")]
			FedEx = 3, 
		
			[Label("UPS")]
			[Description(@"")]
			UPS = 4, 
		
			[Label("Postal Mail")]
			[Description(@"")]
			PostalMail = 5, 
		
			[Label("Full Load")]
			[Description(@"")]
			FullLoad = 6, 
		
			[Label("Will Call")]
			[Description(@"")]
			WillCall = 7, 
		}
		
		public enum eBusinessType
		{	
		
			[Label("Default Value")]
			[Description(@"")]
			DefaultValue = 1, 
		}
		
		public enum eIndustry
		{	
		
			[Label("Accounting")]
			[Description(@"")]
			Accounting = 1, 
		
			[Label("Agriculture and Non-petrol Natural Resource Extraction")]
			[Description(@"")]
			AgricultureAndNonpetrolNaturalResourceExtraction = 2, 
		
			[Label("Broadcasting Printing and Publishing")]
			[Description(@"")]
			BroadcastingPrintingAndPublishing = 3, 
		
			[Label("Brokers")]
			[Description(@"")]
			Brokers = 4, 
		
			[Label("Building Supply Retail")]
			[Description(@"")]
			BuildingSupplyRetail = 5, 
		
			[Label("Business Services")]
			[Description(@"")]
			BusinessServices = 6, 
		
			[Label("Consulting")]
			[Description(@"")]
			Consulting = 7, 
		
			[Label("Consumer Services")]
			[Description(@"")]
			ConsumerServices = 8, 
		
			[Label("Design, Direction and Creative Management")]
			[Description(@"")]
			DesignDirectionAndCreativeManagement = 9, 
		
			[Label("Distributors, Dispatchers and Processors")]
			[Description(@"")]
			DistributorsDispatchersAndProcessors = 10, 
		
			[Label("Doctor's Offices and Clinics")]
			[Description(@"")]
			DoctorsOfficesAndClinics = 11, 
		
			[Label("Durable Manufacturing")]
			[Description(@"")]
			DurableManufacturing = 12, 
		
			[Label("Eating and Drinking Places")]
			[Description(@"")]
			EatingAndDrinkingPlaces = 13, 
		
			[Label("Entertainment Retail")]
			[Description(@"")]
			EntertainmentRetail = 14, 
		
			[Label("Equipment Rental and Leasing")]
			[Description(@"")]
			EquipmentRentalAndLeasing = 15, 
		
			[Label("Financial")]
			[Description(@"")]
			Financial = 16, 
		
			[Label("Food and Tobacco Processing")]
			[Description(@"")]
			FoodAndTobaccoProcessing = 17, 
		
			[Label("Inbound Capital Intensive Processing")]
			[Description(@"")]
			InboundCapitalIntensiveProcessing = 18, 
		
			[Label("Inbound Repair and Services")]
			[Description(@"")]
			InboundRepairAndServices = 19, 
		
			[Label("Insurance")]
			[Description(@"")]
			Insurance = 20, 
		
			[Label("Legal Services")]
			[Description(@"")]
			LegalServices = 21, 
		
			[Label("Non-Durable Merchandise Retail")]
			[Description(@"")]
			NonDurableMerchandiseRetail = 22, 
		
			[Label("Outbound Consumer Service")]
			[Description(@"")]
			OutboundConsumerService = 23, 
		
			[Label("Petrochemical Extraction and Distribution")]
			[Description(@"")]
			PetrochemicalExtractionAndDistribution = 24, 
		
			[Label("Service Retail")]
			[Description(@"")]
			ServiceRetail = 25, 
		
			[Label("SIG Affiliations")]
			[Description(@"")]
			SIGAffiliations = 26, 
		
			[Label("Social Services")]
			[Description(@"")]
			SocialServices = 27, 
		
			[Label("Special Outbound Trade Contractors")]
			[Description(@"")]
			SpecialOutboundTradeContractors = 28, 
		
			[Label("Specialty Realty")]
			[Description(@"")]
			SpecialtyRealty = 29, 
		
			[Label("Transportation")]
			[Description(@"")]
			Transportation = 30, 
		
			[Label("Utility Creation and Distribution")]
			[Description(@"")]
			UtilityCreationAndDistribution = 31, 
		
			[Label("Vehicle Retail")]
			[Description(@"")]
			VehicleRetail = 32, 
		
			[Label("Wholesale")]
			[Description(@"")]
			Wholesale = 33, 
		}
		
		public enum eShippingMethod
		{	
		
			[Label("Default Value")]
			[Description(@"")]
			DefaultValue = 1, 
		}
		
		public enum ePreferredTime
		{	
		
			[Label("Morning")]
			[Description(@"")]
			Morning = 1, 
		
			[Label("Afternoon")]
			[Description(@"")]
			Afternoon = 2, 
		
			[Label("Evening")]
			[Description(@"")]
			Evening = 3, 
		}
		
		public enum eAddress2ShippingMethod
		{	
		
			[Label("Default Value")]
			[Description(@"")]
			DefaultValue = 1, 
		}
		
		public enum eTerritoryCode
		{	
		
			[Label("Default Value")]
			[Description(@"")]
			DefaultValue = 1, 
		}
		
		public enum ePreferredDay
		{	
		
			[Label("Sunday")]
			[Description(@"")]
			Sunday = 0, 
		
			[Label("Monday")]
			[Description(@"")]
			Monday = 1, 
		
			[Label("Tuesday")]
			[Description(@"")]
			Tuesday = 2, 
		
			[Label("Wednesday")]
			[Description(@"")]
			Wednesday = 3, 
		
			[Label("Thursday")]
			[Description(@"")]
			Thursday = 4, 
		
			[Label("Friday")]
			[Description(@"")]
			Friday = 5, 
		
			[Label("Saturday")]
			[Description(@"")]
			Saturday = 6, 
		}
		
		public enum ePaymentTerms
		{	
		
			[Label("Net 30")]
			[Description(@"")]
			Net30 = 1, 
		
			[Label("2% 10, Net 30")]
			[Description(@"")]
			_210Net30 = 2, 
		
			[Label("Net 45")]
			[Description(@"")]
			Net45 = 3, 
		
			[Label("Net 60")]
			[Description(@"")]
			Net60 = 4, 
		}
		
		public enum eClassification
		{	
		
			[Label("Default Value")]
			[Description(@"")]
			DefaultValue = 1, 
		}
		
		public enum eAddress1AddressType
		{	
		
			[Label("Bill To")]
			[Description(@"")]
			BillTo = 1, 
		
			[Label("Ship To")]
			[Description(@"")]
			ShipTo = 2, 
		
			[Label("Primary")]
			[Description(@"")]
			Primary = 3, 
		
			[Label("Other")]
			[Description(@"")]
			Other = 4, 
		}
		
		public enum eOwnership
		{	
		
			[Label("Public")]
			[Description(@"")]
			Public = 1, 
		
			[Label("Private")]
			[Description(@"")]
			Private = 2, 
		
			[Label("Subsidiary")]
			[Description(@"")]
			Subsidiary = 3, 
		
			[Label("Other")]
			[Description(@"")]
			Other = 4, 
		}
		
		public enum eAddress2FreightTerms
		{	
		
			[Label("Default Value")]
			[Description(@"")]
			DefaultValue = 1, 
		}
		
		public enum eAddress2AddressType
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
		
			[Label("Inactive")]
			[Description(@"")]
			Inactive = 1, 
		}
		
		public enum eAddress1FreightTerms
		{	
		
			[Label("FOB")]
			[Description(@"")]
			FOB = 1, 
		
			[Label("No Charge")]
			[Description(@"")]
			NoCharge = 2, 
		}
		
		public enum eCustomerSize
		{	
		
			[Label("Default Value")]
			[Description(@"")]
			DefaultValue = 1, 
		}
		
		public enum eRelationshipType
		{	
		
			[Label("Competitor")]
			[Description(@"")]
			Competitor = 1, 
		
			[Label("Consultant")]
			[Description(@"")]
			Consultant = 2, 
		
			[Label("Customer")]
			[Description(@"")]
			Customer = 3, 
		
			[Label("Investor")]
			[Description(@"")]
			Investor = 4, 
		
			[Label("Partner")]
			[Description(@"")]
			Partner = 5, 
		
			[Label("Influencer")]
			[Description(@"")]
			Influencer = 6, 
		
			[Label("Press")]
			[Description(@"")]
			Press = 7, 
		
			[Label("Prospect")]
			[Description(@"")]
			Prospect = 8, 
		
			[Label("Reseller")]
			[Description(@"")]
			Reseller = 9, 
		
			[Label("Supplier")]
			[Description(@"")]
			Supplier = 10, 
		
			[Label("Vendor")]
			[Description(@"")]
			Vendor = 11, 
		
			[Label("Other")]
			[Description(@"")]
			Other = 12, 
		}
		
		public enum eCategory
		{	
		
			[Label("Preferred Customer")]
			[Description(@"")]
			PreferredCustomer = 1, 
		
			[Label("Standard")]
			[Description(@"")]
			Standard = 2, 
		}
		
		#endregion	

		#region Properties
		public static class Properties 
		{
			/// <summary>address2_postalcode</summary>
			public const string Address2ZIPPostalCode = "address2_postalcode";

			/// <summary>address1_longitude</summary>
			public const string Address1Longitude = "address1_longitude";

			/// <summary>aging90</summary>
			public const string Aging90 = "aging90";

			/// <summary>address2_county</summary>
			public const string Address2County = "address2_county";

			/// <summary>defaultpricelevelidname</summary>
			public const string Defaultpricelevelidname = "defaultpricelevelidname";

			/// <summary>masteraccountidname</summary>
			public const string Masteraccountidname = "masteraccountidname";

			/// <summary>address1_county</summary>
			public const string Address1County = "address1_county";

			/// <summary>preferredcontactmethodcode</summary>
			public const string PreferredMethodOfContact = "preferredcontactmethodcode";

			/// <summary>modifiedby</summary>
			public const string ModifiedBy = "modifiedby";

			/// <summary>address2_line3</summary>
			public const string Address2Street3 = "address2_line3";

			/// <summary>statuscode</summary>
			public const string StatusReason = "statuscode";

			/// <summary>address2_longitude</summary>
			public const string Address2Longitude = "address2_longitude";

			/// <summary>modifiedonbehalfby</summary>
			public const string ModifiedByDelegate = "modifiedonbehalfby";

			/// <summary>originatingleadidyominame</summary>
			public const string Originatingleadidyominame = "originatingleadidyominame";

			/// <summary>address1_telephone2</summary>
			public const string Address1Telephone2 = "address1_telephone2";

			/// <summary>transactioncurrencyidname</summary>
			public const string Transactioncurrencyidname = "transactioncurrencyidname";

			/// <summary>address1_upszone</summary>
			public const string Address1UPSZone = "address1_upszone";

			/// <summary>opendeals_date</summary>
			public const string OpenDealsLastUpdatedOn = "opendeals_date";

			/// <summary>processid</summary>
			public const string ProcessId = "processid";

			/// <summary>marketcap</summary>
			public const string MarketCapitalization = "marketcap";

			/// <summary>openrevenue_date</summary>
			public const string OpenRevenueLastUpdatedOn = "openrevenue_date";

			/// <summary>address2_name</summary>
			public const string Address2Name = "address2_name";

			/// <summary>address1_stateorprovince</summary>
			public const string Address1StateProvince = "address1_stateorprovince";

			/// <summary>masteraccountidyominame</summary>
			public const string Masteraccountidyominame = "masteraccountidyominame";

			/// <summary>emailaddress1</summary>
			public const string Email = "emailaddress1";

			/// <summary>owneridyominame</summary>
			public const string Owneridyominame = "owneridyominame";

			/// <summary>address1_country</summary>
			public const string Address1CountryRegion = "address1_country";

			/// <summary>owningbusinessunit</summary>
			public const string OwningBusinessUnit = "owningbusinessunit";

			/// <summary>accountratingcode</summary>
			public const string AccountRating = "accountratingcode";

			/// <summary>address2_upszone</summary>
			public const string Address2UPSZone = "address2_upszone";

			/// <summary>address1_shippingmethodcode</summary>
			public const string Address1ShippingMethod = "address1_shippingmethodcode";

			/// <summary>exchangerate</summary>
			public const string ExchangeRate = "exchangerate";

			/// <summary>defaultpricelevelid</summary>
			public const string PriceList = "defaultpricelevelid";

			/// <summary>businesstypecode</summary>
			public const string BusinessType = "businesstypecode";

			/// <summary>address1_line2</summary>
			public const string Address1Street2 = "address1_line2";

			/// <summary>donotpostalmail</summary>
			public const string DoNotAllowMails = "donotpostalmail";

			/// <summary>openrevenue</summary>
			public const string OpenRevenue = "openrevenue";

			/// <summary>ownerid</summary>
			public const string Owner = "ownerid";

			/// <summary>createdbyexternalpartyyominame</summary>
			public const string Createdbyexternalpartyyominame = "createdbyexternalpartyyominame";

			/// <summary>openrevenue_state</summary>
			public const string OpenRevenueState = "openrevenue_state";

			/// <summary>address1_city</summary>
			public const string Address1City = "address1_city";

			/// <summary>industrycode</summary>
			public const string Industry = "industrycode";

			/// <summary>shippingmethodcode</summary>
			public const string ShippingMethod = "shippingmethodcode";

			/// <summary>address1_utcoffset</summary>
			public const string Address1UTCOffset = "address1_utcoffset";

			/// <summary>address2_stateorprovince</summary>
			public const string Address2StateProvince = "address2_stateorprovince";

			/// <summary>versionnumber</summary>
			public const string VersionNumber = "versionnumber";

			/// <summary>entityimageid</summary>
			public const string EntityImageId = "entityimageid";

			/// <summary>preferredappointmenttimecode</summary>
			public const string PreferredTime = "preferredappointmenttimecode";

			/// <summary>createdby</summary>
			public const string CreatedBy = "createdby";

			/// <summary>address2_shippingmethodcode</summary>
			public const string Address2ShippingMethod = "address2_shippingmethodcode";

			/// <summary>modifiedon</summary>
			public const string ModifiedOn = "modifiedon";

			/// <summary>territorycode</summary>
			public const string TerritoryCode = "territorycode";

			/// <summary>transactioncurrencyid</summary>
			public const string Currency = "transactioncurrencyid";

			/// <summary>modifiedbyexternalparty</summary>
			public const string ModifiedByExternalParty = "modifiedbyexternalparty";

			/// <summary>createdon</summary>
			public const string CreatedOn = "createdon";

			/// <summary>marketingonly</summary>
			public const string MarketingOnly = "marketingonly";

			/// <summary>accountid</summary>
			public const string AccountId = "accountid";

			/// <summary>address2_utcoffset</summary>
			public const string Address2UTCOffset = "address2_utcoffset";

			/// <summary>aging60</summary>
			public const string Aging60 = "aging60";

			/// <summary>originatingleadidname</summary>
			public const string Originatingleadidname = "originatingleadidname";

			/// <summary>opendeals</summary>
			public const string OpenDeals = "opendeals";

			/// <summary>modifiedbyyominame</summary>
			public const string Modifiedbyyominame = "modifiedbyyominame";

			/// <summary>preferredappointmentdaycode</summary>
			public const string PreferredDay = "preferredappointmentdaycode";

			/// <summary>overriddencreatedon</summary>
			public const string RecordCreatedOn = "overriddencreatedon";

			/// <summary>paymenttermscode</summary>
			public const string PaymentTerms = "paymenttermscode";

			/// <summary>donotbulkemail</summary>
			public const string DoNotAllowBulkEmails = "donotbulkemail";

			/// <summary>modifiedbyname</summary>
			public const string Modifiedbyname = "modifiedbyname";

			/// <summary>modifiedonbehalfbyname</summary>
			public const string Modifiedonbehalfbyname = "modifiedonbehalfbyname";

			/// <summary>preferredserviceid</summary>
			public const string PreferredService = "preferredserviceid";

			/// <summary>accountclassificationcode</summary>
			public const string Classification = "accountclassificationcode";

			/// <summary>preferredequipmentid</summary>
			public const string PreferredFacilityEquipment = "preferredequipmentid";

			/// <summary>entityimage_url</summary>
			public const string EntityimageUrl = "entityimage_url";

			/// <summary>primarytwitterid</summary>
			public const string PrimaryTwitterID = "primarytwitterid";

			/// <summary>address2_line2</summary>
			public const string Address2Street2 = "address2_line2";

			/// <summary>address1_addresstypecode</summary>
			public const string Address1AddressType = "address1_addresstypecode";

			/// <summary>territoryidname</summary>
			public const string Territoryidname = "territoryidname";

			/// <summary>revenue</summary>
			public const string AnnualRevenue = "revenue";

			/// <summary>owninguser</summary>
			public const string OwningUser = "owninguser";

			/// <summary>yominame</summary>
			public const string YomiAccountName = "yominame";

			/// <summary>address1_latitude</summary>
			public const string Address1Latitude = "address1_latitude";

			/// <summary>ownershipcode</summary>
			public const string Ownership = "ownershipcode";

			/// <summary>primarysatoriid</summary>
			public const string PrimarySatoriID = "primarysatoriid";

			/// <summary>fax</summary>
			public const string Fax = "fax";

			/// <summary>timezoneruleversionnumber</summary>
			public const string TimeZoneRuleVersionNumber = "timezoneruleversionnumber";

			/// <summary>createdonbehalfbyyominame</summary>
			public const string Createdonbehalfbyyominame = "createdonbehalfbyyominame";

			/// <summary>donotbulkpostalmail</summary>
			public const string DoNotAllowBulkMails = "donotbulkpostalmail";

			/// <summary>address2_composite</summary>
			public const string Address2 = "address2_composite";

			/// <summary>owneridtype</summary>
			public const string Owneridtype = "owneridtype";

			/// <summary>address1_name</summary>
			public const string Address1Name = "address1_name";

			/// <summary>parentaccountidname</summary>
			public const string Parentaccountidname = "parentaccountidname";

			/// <summary>telephone3</summary>
			public const string Telephone3 = "telephone3";

			/// <summary>parentaccountidyominame</summary>
			public const string Parentaccountidyominame = "parentaccountidyominame";

			/// <summary>owningteam</summary>
			public const string OwningTeam = "owningteam";

			/// <summary>entityimage_timestamp</summary>
			public const string EntityimageTimestamp = "entityimage_timestamp";

			/// <summary>modifiedbyexternalpartyname</summary>
			public const string Modifiedbyexternalpartyname = "modifiedbyexternalpartyname";

			/// <summary>emailaddress3</summary>
			public const string EmailAddress3 = "emailaddress3";

			/// <summary>emailaddress2</summary>
			public const string EmailAddress2 = "emailaddress2";

			/// <summary>createdonbehalfby</summary>
			public const string CreatedByDelegate = "createdonbehalfby";

			/// <summary>creditlimit</summary>
			public const string CreditLimit = "creditlimit";

			/// <summary>teamsfollowed</summary>
			public const string TeamsFollowed = "teamsfollowed";

			/// <summary>aging30</summary>
			public const string Aging30 = "aging30";

			/// <summary>address2_country</summary>
			public const string Address2CountryRegion = "address2_country";

			/// <summary>telephone2</summary>
			public const string OtherPhone = "telephone2";

			/// <summary>createdbyexternalpartyname</summary>
			public const string Createdbyexternalpartyname = "createdbyexternalpartyname";

			/// <summary>lastusedincampaign</summary>
			public const string LastDateIncludedInCampaign = "lastusedincampaign";

			/// <summary>preferredequipmentidname</summary>
			public const string Preferredequipmentidname = "preferredequipmentidname";

			/// <summary>accountnumber</summary>
			public const string AccountNumber = "accountnumber";

			/// <summary>slainvokedid</summary>
			public const string LastSLAApplied = "slainvokedid";

			/// <summary>masterid</summary>
			public const string MasterID = "masterid";

			/// <summary>traversedpath</summary>
			public const string DeprecatedTraversedPath = "traversedpath";

			/// <summary>primarycontactidname</summary>
			public const string Primarycontactidname = "primarycontactidname";

			/// <summary>timespentbymeonemailandmeetings</summary>
			public const string TimeSpentByMe = "timespentbymeonemailandmeetings";

			/// <summary>address1_primarycontactname</summary>
			public const string Address1PrimaryContactName = "address1_primarycontactname";

			/// <summary>donotphone</summary>
			public const string DoNotAllowPhoneCalls = "donotphone";

			/// <summary>preferredsystemuseridname</summary>
			public const string Preferredsystemuseridname = "preferredsystemuseridname";

			/// <summary>createdonbehalfbyname</summary>
			public const string Createdonbehalfbyname = "createdonbehalfbyname";

			/// <summary>address2_freighttermscode</summary>
			public const string Address2FreightTerms = "address2_freighttermscode";

			/// <summary>address2_postofficebox</summary>
			public const string Address2PostOfficeBox = "address2_postofficebox";

			/// <summary>donotsendmm</summary>
			public const string SendMarketingMaterials = "donotsendmm";

			/// <summary>address2_latitude</summary>
			public const string Address2Latitude = "address2_latitude";

			/// <summary>parentaccountid</summary>
			public const string ParentAccount = "parentaccountid";

			/// <summary>modifiedbyexternalpartyyominame</summary>
			public const string Modifiedbyexternalpartyyominame = "modifiedbyexternalpartyyominame";

			/// <summary>primarycontactidyominame</summary>
			public const string Primarycontactidyominame = "primarycontactidyominame";

			/// <summary>preferredsystemuserid</summary>
			public const string PreferredUser = "preferredsystemuserid";

			/// <summary>primarycontactid</summary>
			public const string PrimaryContact = "primarycontactid";

			/// <summary>slaid</summary>
			public const string SLA = "slaid";

			/// <summary>territoryid</summary>
			public const string Territory = "territoryid";

			/// <summary>slaname</summary>
			public const string Slaname = "slaname";

			/// <summary>address1_composite</summary>
			public const string Address1 = "address1_composite";

			/// <summary>ftpsiteurl</summary>
			public const string FTPSite = "ftpsiteurl";

			/// <summary>opendeals_state</summary>
			public const string OpenDealsState = "opendeals_state";

			/// <summary>isprivate</summary>
			public const string Isprivate = "isprivate";

			/// <summary>sic</summary>
			public const string SICCode = "sic";

			/// <summary>address2_line1</summary>
			public const string Address2Street1 = "address2_line1";

			/// <summary>lastonholdtime</summary>
			public const string LastOnHoldTime = "lastonholdtime";

			/// <summary>address1_telephone1</summary>
			public const string AddressPhone = "address1_telephone1";

			/// <summary>address2_fax</summary>
			public const string Address2Fax = "address2_fax";

			/// <summary>address1_telephone3</summary>
			public const string Address1Telephone3 = "address1_telephone3";

			/// <summary>description</summary>
			public const string Description = "description";

			/// <summary>stageid</summary>
			public const string DeprecatedProcessStageId = "stageid";

			/// <summary>address2_addresstypecode</summary>
			public const string Address2AddressType = "address2_addresstypecode";

			/// <summary>telephone1</summary>
			public const string MainPhone = "telephone1";

			/// <summary>websiteurl</summary>
			public const string Website = "websiteurl";

			/// <summary>utcconversiontimezonecode</summary>
			public const string UTCConversionTimeZoneCode = "utcconversiontimezonecode";

			/// <summary>stockexchange</summary>
			public const string StockExchange = "stockexchange";

			/// <summary>originatingleadid</summary>
			public const string OriginatingLead = "originatingleadid";

			/// <summary>address1_addressid</summary>
			public const string Address1Id = "address1_addressid";

			/// <summary>statecode</summary>
			public const string Status = "statecode";

			/// <summary>participatesinworkflow</summary>
			public const string ParticipatesInWorkflow = "participatesinworkflow";

			/// <summary>address2_city</summary>
			public const string Address2City = "address2_city";

			/// <summary>address1_freighttermscode</summary>
			public const string Address1FreightTerms = "address1_freighttermscode";

			/// <summary>address2_primarycontactname</summary>
			public const string Address2PrimaryContactName = "address2_primarycontactname";

			/// <summary>merged</summary>
			public const string Merged = "merged";

			/// <summary>createdbyexternalparty</summary>
			public const string CreatedByExternalParty = "createdbyexternalparty";

			/// <summary>address2_addressid</summary>
			public const string Address2Id = "address2_addressid";

			/// <summary>onholdtime</summary>
			public const string OnHoldTimeMinutes = "onholdtime";

			/// <summary>address1_line1</summary>
			public const string Address1Street1 = "address1_line1";

			/// <summary>address1_line3</summary>
			public const string Address1Street3 = "address1_line3";

			/// <summary>creditonhold</summary>
			public const string CreditHold = "creditonhold";

			/// <summary>donotfax</summary>
			public const string DoNotAllowFaxes = "donotfax";

			/// <summary>createdbyyominame</summary>
			public const string Createdbyyominame = "createdbyyominame";

			/// <summary>customersizecode</summary>
			public const string CustomerSize = "customersizecode";

			/// <summary>address2_telephone1</summary>
			public const string Address2Telephone1 = "address2_telephone1";

			/// <summary>address2_telephone2</summary>
			public const string Address2Telephone2 = "address2_telephone2";

			/// <summary>address2_telephone3</summary>
			public const string Address2Telephone3 = "address2_telephone3";

			/// <summary>address1_postofficebox</summary>
			public const string Address1PostOfficeBox = "address1_postofficebox";

			/// <summary>customertypecode</summary>
			public const string RelationshipType = "customertypecode";

			/// <summary>donotemail</summary>
			public const string DoNotAllowEmails = "donotemail";

			/// <summary>createdbyname</summary>
			public const string Createdbyname = "createdbyname";

			/// <summary>accountcategorycode</summary>
			public const string Category = "accountcategorycode";

			/// <summary>tickersymbol</summary>
			public const string TickerSymbol = "tickersymbol";

			/// <summary>preferredserviceidname</summary>
			public const string Preferredserviceidname = "preferredserviceidname";

			/// <summary>numberofemployees</summary>
			public const string NumberOfEmployees = "numberofemployees";

			/// <summary>owneridname</summary>
			public const string Owneridname = "owneridname";

			/// <summary>modifiedonbehalfbyyominame</summary>
			public const string Modifiedonbehalfbyyominame = "modifiedonbehalfbyyominame";

			/// <summary>address1_fax</summary>
			public const string Address1Fax = "address1_fax";

			/// <summary>importsequencenumber</summary>
			public const string ImportSequenceNumber = "importsequencenumber";

			/// <summary>followemail</summary>
			public const string FollowEmailActivity = "followemail";

			/// <summary>name</summary>
			public const string AccountName = "name";

			/// <summary>slainvokedidname</summary>
			public const string Slainvokedidname = "slainvokedidname";

			/// <summary>preferredsystemuseridyominame</summary>
			public const string Preferredsystemuseridyominame = "preferredsystemuseridyominame";

			/// <summary>sharesoutstanding</summary>
			public const string SharesOutstanding = "sharesoutstanding";

			/// <summary>address1_postalcode</summary>
			public const string Address1ZIPPostalCode = "address1_postalcode";

		}
		#endregion

		#region Schemas
		public static class Schemas 
		{
			/// <summary>1:N account_principalobjectattributeaccess</summary>
			public const string AccountPrincipalobjectattributeaccess = "account_principalobjectattributeaccess";

			/// <summary>1:N Account_Faxes</summary>
			public const string AccountFaxes = "Account_Faxes";

			/// <summary>1:N slakpiinstance_account</summary>
			public const string SlakpiinstanceAccount = "slakpiinstance_account";

			/// <summary>1:N account_PostFollows</summary>
			public const string AccountPostFollows = "account_PostFollows";

			/// <summary>1:N Account_Tasks</summary>
			public const string AccountTasks = "Account_Tasks";

			/// <summary>1:N account_connections1</summary>
			public const string AccountConnections1 = "account_connections1";

			/// <summary>1:N SocialActivity_PostAuthorAccount_accounts</summary>
			public const string SocialActivityPostAuthorAccountAccounts = "SocialActivity_PostAuthorAccount_accounts";

			/// <summary>1:N Account_DuplicateBaseRecord</summary>
			public const string AccountDuplicateBaseRecord = "Account_DuplicateBaseRecord";

			/// <summary>1:N SocialActivity_PostAuthor_accounts</summary>
			public const string SocialActivityPostAuthorAccounts = "SocialActivity_PostAuthor_accounts";

			/// <summary>1:N Account_SyncErrors</summary>
			public const string AccountSyncErrors = "Account_SyncErrors";

			/// <summary>1:N Account_MailboxTrackingFolder</summary>
			public const string AccountMailboxTrackingFolder = "Account_MailboxTrackingFolder";

			/// <summary>1:N Account_BulkDeleteFailures</summary>
			public const string AccountBulkDeleteFailures = "Account_BulkDeleteFailures";

			/// <summary>1:N Account_ActivityPointers</summary>
			public const string AccountActivityPointers = "Account_ActivityPointers";

			/// <summary>1:N Account_Email_SendersAccount</summary>
			public const string AccountEmailSendersAccount = "Account_Email_SendersAccount";

			/// <summary>1:N Account_Appointments</summary>
			public const string AccountAppointments = "Account_Appointments";

			/// <summary>1:N Socialprofile_customer_accounts</summary>
			public const string SocialprofileCustomerAccounts = "Socialprofile_customer_accounts";

			/// <summary>1:N Account_Emails</summary>
			public const string AccountEmails = "Account_Emails";

			/// <summary>1:N account_activity_parties</summary>
			public const string AccountActivityParties = "account_activity_parties";

			/// <summary>1:N Account_Phonecalls</summary>
			public const string AccountPhonecalls = "Account_Phonecalls";

			/// <summary>1:N Account_SocialActivities</summary>
			public const string AccountSocialActivities = "Account_SocialActivities";

			/// <summary>1:N Account_DuplicateMatchingRecord</summary>
			public const string AccountDuplicateMatchingRecord = "Account_DuplicateMatchingRecord";

			/// <summary>1:N account_actioncard</summary>
			public const string AccountActioncard = "account_actioncard";

			/// <summary>1:N Account_AsyncOperations</summary>
			public const string AccountAsyncOperations = "Account_AsyncOperations";

			/// <summary>1:N Account_CustomerAddress</summary>
			public const string AccountCustomerAddress = "Account_CustomerAddress";

			/// <summary>1:N Account_Annotation</summary>
			public const string AccountAnnotation = "Account_Annotation";

			/// <summary>1:N Account_Letters</summary>
			public const string AccountLetters = "Account_Letters";

			/// <summary>1:N Account_RecurringAppointmentMasters</summary>
			public const string AccountRecurringAppointmentMasters = "Account_RecurringAppointmentMasters";

			/// <summary>1:N Account_Email_EmailSender</summary>
			public const string AccountEmailEmailSender = "Account_Email_EmailSender";

			/// <summary>1:N Account_ProcessSessions</summary>
			public const string AccountProcessSessions = "Account_ProcessSessions";

			/// <summary>1:N account_parent_account</summary>
			public const string AccountParentAccount = "account_parent_account";

			/// <summary>1:N contact_customer_accounts</summary>
			public const string ContactCustomerAccounts = "contact_customer_accounts";

			/// <summary>1:N account_master_account</summary>
			public const string AccountMasterAccount = "account_master_account";

			/// <summary>1:N Account_SharepointDocumentLocation</summary>
			public const string AccountSharepointDocumentLocation = "Account_SharepointDocumentLocation";

			/// <summary>1:N account_connections2</summary>
			public const string AccountConnections2 = "account_connections2";

			/// <summary>1:N lead_customer_accounts</summary>
			public const string LeadCustomerAccounts = "lead_customer_accounts";

			/// <summary>1:N lead_parent_account</summary>
			public const string LeadParentAccount = "lead_parent_account";

			/// <summary>1:N account_bookableresource_AccountId</summary>
			public const string AccountBookableresourceAccountId = "account_bookableresource_AccountId";

			/// <summary>1:N account_BulkOperations</summary>
			public const string AccountBulkOperations = "account_BulkOperations";

			/// <summary>1:N account_CampaignResponses</summary>
			public const string AccountCampaignResponses = "account_CampaignResponses";

			/// <summary>1:N account_IncidentResolutions</summary>
			public const string AccountIncidentResolutions = "account_IncidentResolutions";

			/// <summary>1:N Account_ServiceAppointments</summary>
			public const string AccountServiceAppointments = "Account_ServiceAppointments";

			/// <summary>1:N contractlineitem_customer_accounts</summary>
			public const string ContractlineitemCustomerAccounts = "contractlineitem_customer_accounts";

			/// <summary>1:N contract_billingcustomer_accounts</summary>
			public const string ContractBillingcustomerAccounts = "contract_billingcustomer_accounts";

			/// <summary>1:N contract_customer_accounts</summary>
			public const string ContractCustomerAccounts = "contract_customer_accounts";

			/// <summary>1:N incident_customer_accounts</summary>
			public const string IncidentCustomerAccounts = "incident_customer_accounts";

			/// <summary>1:N account_entitlement_Account</summary>
			public const string AccountEntitlementAccount = "account_entitlement_Account";

			/// <summary>1:N account_entitlement_Customer</summary>
			public const string AccountEntitlementCustomer = "account_entitlement_Customer";

			/// <summary>1:N account_OpportunityCloses</summary>
			public const string AccountOpportunityCloses = "account_OpportunityCloses";

			/// <summary>1:N account_OrderCloses</summary>
			public const string AccountOrderCloses = "account_OrderCloses";

			/// <summary>1:N account_QuoteCloses</summary>
			public const string AccountQuoteCloses = "account_QuoteCloses";

			/// <summary>1:N invoice_customer_accounts</summary>
			public const string InvoiceCustomerAccounts = "invoice_customer_accounts";

			/// <summary>1:N opportunity_customer_accounts</summary>
			public const string OpportunityCustomerAccounts = "opportunity_customer_accounts";

			/// <summary>1:N order_customer_accounts</summary>
			public const string OrderCustomerAccounts = "order_customer_accounts";

			/// <summary>1:N quote_customer_accounts</summary>
			public const string QuoteCustomerAccounts = "quote_customer_accounts";

			/// <summary>1:N opportunity_parent_account</summary>
			public const string OpportunityParentAccount = "opportunity_parent_account";

			/// <summary>1:N msdyn_playbookinstance_account</summary>
			public const string MsdynPlaybookinstanceAccount = "msdyn_playbookinstance_account";

			/// <summary>N:N accountleads_association</summary>
			public const string AccountleadsAssociation = "accountleads_association";

			/// <summary>N:N listaccount_association</summary>
			public const string ListaccountAssociation = "listaccount_association";

			/// <summary>N:N BulkOperation_Accounts</summary>
			public const string BulkOperationAccounts = "BulkOperation_Accounts";

			/// <summary>N:N CampaignActivity_Accounts</summary>
			public const string CampaignActivityAccounts = "CampaignActivity_Accounts";

		}
		#endregion
	}
}

