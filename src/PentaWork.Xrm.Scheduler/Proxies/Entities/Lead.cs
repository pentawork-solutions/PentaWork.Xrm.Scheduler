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
	[EntityLogicalName("lead")]
	public sealed class Lead : Entity
	{	
		public static readonly int? EntityTypeCode = 4;
		public new const string LogicalName = "lead";
		public const string PrimaryIdAttribute = "leadid";
		public const string PrimaryNameAttribute = "fullname";
	
		public Lead() : base("lead") { }

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
        /// address1_addressid
        /// </summary>
		[DisplayName("Address 1: ID")]
		[AttributeLogicalName("address1_addressid")]
		public Guid Address1Id
		{	
			get { return GetAttributeValue<Guid>("address1_addressid"); }
			set
			{ 
				if(value == Address1Id) return;
				SetAttributeValue("address1_addressid", value);
			}
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
				if(value == Address1AddressType) return;

				OptionSetValue optionSetValue = null;
				if(value != null) optionSetValue = new OptionSetValue((int)value);
				SetAttributeValue("address1_addresstypecode", optionSetValue); 
			}
		}

		/// <summary>
        /// address1_city
        /// </summary>
		[DisplayName("City")]
		[AttributeLogicalName("address1_city")]
		public string City
		{	
			get { return GetAttributeValue<string>("address1_city"); }
			set
			{ 
				if(value == City) return;
				SetAttributeValue("address1_city", value);
			}
		}	
			
		/// <summary>
        /// address1_composite
        /// </summary>
		[DisplayName("Address 1")]
		[AttributeLogicalName("address1_composite")]
		public string Address1
		{	
			get { return GetAttributeValue<string>("address1_composite"); }
			set
			{ 
				if(value == Address1) return;
				SetAttributeValue("address1_composite", value);
			}
		}	
			
		/// <summary>
        /// address1_country
        /// </summary>
		[DisplayName("Country/Region")]
		[AttributeLogicalName("address1_country")]
		public string CountryRegion
		{	
			get { return GetAttributeValue<string>("address1_country"); }
			set
			{ 
				if(value == CountryRegion) return;
				SetAttributeValue("address1_country", value);
			}
		}	
			
		/// <summary>
        /// address1_county
        /// </summary>
		[DisplayName("Address 1: County")]
		[AttributeLogicalName("address1_county")]
		public string Address1County
		{	
			get { return GetAttributeValue<string>("address1_county"); }
			set
			{ 
				if(value == Address1County) return;
				SetAttributeValue("address1_county", value);
			}
		}	
			
		/// <summary>
        /// address1_fax
        /// </summary>
		[DisplayName("Address 1: Fax")]
		[AttributeLogicalName("address1_fax")]
		public string Address1Fax
		{	
			get { return GetAttributeValue<string>("address1_fax"); }
			set
			{ 
				if(value == Address1Fax) return;
				SetAttributeValue("address1_fax", value);
			}
		}	
			
		/// <summary>
        /// address1_latitude
        /// </summary>
		[DisplayName("Address 1: Latitude")]
		[AttributeLogicalName("address1_latitude")]
		public double? Address1Latitude
		{	
			get { return GetAttributeValue<double?>("address1_latitude"); }
			set
			{ 
				if(value == Address1Latitude) return;
				SetAttributeValue("address1_latitude", value);
			}
		}	
			
		/// <summary>
        /// address1_line1
        /// </summary>
		[DisplayName("Street 1")]
		[AttributeLogicalName("address1_line1")]
		public string Street1
		{	
			get { return GetAttributeValue<string>("address1_line1"); }
			set
			{ 
				if(value == Street1) return;
				SetAttributeValue("address1_line1", value);
			}
		}	
			
		/// <summary>
        /// address1_line2
        /// </summary>
		[DisplayName("Street 2")]
		[AttributeLogicalName("address1_line2")]
		public string Street2
		{	
			get { return GetAttributeValue<string>("address1_line2"); }
			set
			{ 
				if(value == Street2) return;
				SetAttributeValue("address1_line2", value);
			}
		}	
			
		/// <summary>
        /// address1_line3
        /// </summary>
		[DisplayName("Street 3")]
		[AttributeLogicalName("address1_line3")]
		public string Street3
		{	
			get { return GetAttributeValue<string>("address1_line3"); }
			set
			{ 
				if(value == Street3) return;
				SetAttributeValue("address1_line3", value);
			}
		}	
			
		/// <summary>
        /// address1_longitude
        /// </summary>
		[DisplayName("Address 1: Longitude")]
		[AttributeLogicalName("address1_longitude")]
		public double? Address1Longitude
		{	
			get { return GetAttributeValue<double?>("address1_longitude"); }
			set
			{ 
				if(value == Address1Longitude) return;
				SetAttributeValue("address1_longitude", value);
			}
		}	
			
		/// <summary>
        /// address1_name
        /// </summary>
		[DisplayName("Address 1: Name")]
		[AttributeLogicalName("address1_name")]
		public string Address1Name
		{	
			get { return GetAttributeValue<string>("address1_name"); }
			set
			{ 
				if(value == Address1Name) return;
				SetAttributeValue("address1_name", value);
			}
		}	
			
		/// <summary>
        /// address1_postalcode
        /// </summary>
		[DisplayName("ZIP/Postal Code")]
		[AttributeLogicalName("address1_postalcode")]
		public string ZIPPostalCode
		{	
			get { return GetAttributeValue<string>("address1_postalcode"); }
			set
			{ 
				if(value == ZIPPostalCode) return;
				SetAttributeValue("address1_postalcode", value);
			}
		}	
			
		/// <summary>
        /// address1_postofficebox
        /// </summary>
		[DisplayName("Address 1: Post Office Box")]
		[AttributeLogicalName("address1_postofficebox")]
		public string Address1PostOfficeBox
		{	
			get { return GetAttributeValue<string>("address1_postofficebox"); }
			set
			{ 
				if(value == Address1PostOfficeBox) return;
				SetAttributeValue("address1_postofficebox", value);
			}
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
				if(value == Address1ShippingMethod) return;

				OptionSetValue optionSetValue = null;
				if(value != null) optionSetValue = new OptionSetValue((int)value);
				SetAttributeValue("address1_shippingmethodcode", optionSetValue); 
			}
		}

		/// <summary>
        /// address1_stateorprovince
        /// </summary>
		[DisplayName("State/Province")]
		[AttributeLogicalName("address1_stateorprovince")]
		public string StateProvince
		{	
			get { return GetAttributeValue<string>("address1_stateorprovince"); }
			set
			{ 
				if(value == StateProvince) return;
				SetAttributeValue("address1_stateorprovince", value);
			}
		}	
			
		/// <summary>
        /// address1_telephone1
        /// </summary>
		[DisplayName("Address 1: Telephone 1")]
		[AttributeLogicalName("address1_telephone1")]
		public string Address1Telephone1
		{	
			get { return GetAttributeValue<string>("address1_telephone1"); }
			set
			{ 
				if(value == Address1Telephone1) return;
				SetAttributeValue("address1_telephone1", value);
			}
		}	
			
		/// <summary>
        /// address1_telephone2
        /// </summary>
		[DisplayName("Address 1: Telephone 2")]
		[AttributeLogicalName("address1_telephone2")]
		public string Address1Telephone2
		{	
			get { return GetAttributeValue<string>("address1_telephone2"); }
			set
			{ 
				if(value == Address1Telephone2) return;
				SetAttributeValue("address1_telephone2", value);
			}
		}	
			
		/// <summary>
        /// address1_telephone3
        /// </summary>
		[DisplayName("Address 1: Telephone 3")]
		[AttributeLogicalName("address1_telephone3")]
		public string Address1Telephone3
		{	
			get { return GetAttributeValue<string>("address1_telephone3"); }
			set
			{ 
				if(value == Address1Telephone3) return;
				SetAttributeValue("address1_telephone3", value);
			}
		}	
			
		/// <summary>
        /// address1_upszone
        /// </summary>
		[DisplayName("Address 1: UPS Zone")]
		[AttributeLogicalName("address1_upszone")]
		public string Address1UPSZone
		{	
			get { return GetAttributeValue<string>("address1_upszone"); }
			set
			{ 
				if(value == Address1UPSZone) return;
				SetAttributeValue("address1_upszone", value);
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
			set
			{ 
				if(value == Address1UTCOffset) return;
				SetAttributeValue("address1_utcoffset", value);
			}
		}	
			
		/// <summary>
        /// address2_addressid
        /// </summary>
		[DisplayName("Address 2: ID")]
		[AttributeLogicalName("address2_addressid")]
		public Guid Address2Id
		{	
			get { return GetAttributeValue<Guid>("address2_addressid"); }
			set
			{ 
				if(value == Address2Id) return;
				SetAttributeValue("address2_addressid", value);
			}
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
				if(value == Address2AddressType) return;

				OptionSetValue optionSetValue = null;
				if(value != null) optionSetValue = new OptionSetValue((int)value);
				SetAttributeValue("address2_addresstypecode", optionSetValue); 
			}
		}

		/// <summary>
        /// address2_city
        /// </summary>
		[DisplayName("Address 2: City")]
		[AttributeLogicalName("address2_city")]
		public string Address2City
		{	
			get { return GetAttributeValue<string>("address2_city"); }
			set
			{ 
				if(value == Address2City) return;
				SetAttributeValue("address2_city", value);
			}
		}	
			
		/// <summary>
        /// address2_composite
        /// </summary>
		[DisplayName("Address 2")]
		[AttributeLogicalName("address2_composite")]
		public string Address2
		{	
			get { return GetAttributeValue<string>("address2_composite"); }
			set
			{ 
				if(value == Address2) return;
				SetAttributeValue("address2_composite", value);
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
			set
			{ 
				if(value == Address2CountryRegion) return;
				SetAttributeValue("address2_country", value);
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
			set
			{ 
				if(value == Address2County) return;
				SetAttributeValue("address2_county", value);
			}
		}	
			
		/// <summary>
        /// address2_fax
        /// </summary>
		[DisplayName("Address 2: Fax")]
		[AttributeLogicalName("address2_fax")]
		public string Address2Fax
		{	
			get { return GetAttributeValue<string>("address2_fax"); }
			set
			{ 
				if(value == Address2Fax) return;
				SetAttributeValue("address2_fax", value);
			}
		}	
			
		/// <summary>
        /// address2_latitude
        /// </summary>
		[DisplayName("Address 2: Latitude")]
		[AttributeLogicalName("address2_latitude")]
		public double? Address2Latitude
		{	
			get { return GetAttributeValue<double?>("address2_latitude"); }
			set
			{ 
				if(value == Address2Latitude) return;
				SetAttributeValue("address2_latitude", value);
			}
		}	
			
		/// <summary>
        /// address2_line1
        /// </summary>
		[DisplayName("Address 2: Street 1")]
		[AttributeLogicalName("address2_line1")]
		public string Address2Street1
		{	
			get { return GetAttributeValue<string>("address2_line1"); }
			set
			{ 
				if(value == Address2Street1) return;
				SetAttributeValue("address2_line1", value);
			}
		}	
			
		/// <summary>
        /// address2_line2
        /// </summary>
		[DisplayName("Address 2: Street 2")]
		[AttributeLogicalName("address2_line2")]
		public string Address2Street2
		{	
			get { return GetAttributeValue<string>("address2_line2"); }
			set
			{ 
				if(value == Address2Street2) return;
				SetAttributeValue("address2_line2", value);
			}
		}	
			
		/// <summary>
        /// address2_line3
        /// </summary>
		[DisplayName("Address 2: Street 3")]
		[AttributeLogicalName("address2_line3")]
		public string Address2Street3
		{	
			get { return GetAttributeValue<string>("address2_line3"); }
			set
			{ 
				if(value == Address2Street3) return;
				SetAttributeValue("address2_line3", value);
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
			set
			{ 
				if(value == Address2Longitude) return;
				SetAttributeValue("address2_longitude", value);
			}
		}	
			
		/// <summary>
        /// address2_name
        /// </summary>
		[DisplayName("Address 2: Name")]
		[AttributeLogicalName("address2_name")]
		public string Address2Name
		{	
			get { return GetAttributeValue<string>("address2_name"); }
			set
			{ 
				if(value == Address2Name) return;
				SetAttributeValue("address2_name", value);
			}
		}	
			
		/// <summary>
        /// address2_postalcode
        /// </summary>
		[DisplayName("Address 2: ZIP/Postal Code")]
		[AttributeLogicalName("address2_postalcode")]
		public string Address2ZIPPostalCode
		{	
			get { return GetAttributeValue<string>("address2_postalcode"); }
			set
			{ 
				if(value == Address2ZIPPostalCode) return;
				SetAttributeValue("address2_postalcode", value);
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
			set
			{ 
				if(value == Address2PostOfficeBox) return;
				SetAttributeValue("address2_postofficebox", value);
			}
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
				if(value == Address2ShippingMethod) return;

				OptionSetValue optionSetValue = null;
				if(value != null) optionSetValue = new OptionSetValue((int)value);
				SetAttributeValue("address2_shippingmethodcode", optionSetValue); 
			}
		}

		/// <summary>
        /// address2_stateorprovince
        /// </summary>
		[DisplayName("Address 2: State/Province")]
		[AttributeLogicalName("address2_stateorprovince")]
		public string Address2StateProvince
		{	
			get { return GetAttributeValue<string>("address2_stateorprovince"); }
			set
			{ 
				if(value == Address2StateProvince) return;
				SetAttributeValue("address2_stateorprovince", value);
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
			set
			{ 
				if(value == Address2Telephone1) return;
				SetAttributeValue("address2_telephone1", value);
			}
		}	
			
		/// <summary>
        /// address2_telephone2
        /// </summary>
		[DisplayName("Address 2: Telephone 2")]
		[AttributeLogicalName("address2_telephone2")]
		public string Address2Telephone2
		{	
			get { return GetAttributeValue<string>("address2_telephone2"); }
			set
			{ 
				if(value == Address2Telephone2) return;
				SetAttributeValue("address2_telephone2", value);
			}
		}	
			
		/// <summary>
        /// address2_telephone3
        /// </summary>
		[DisplayName("Address 2: Telephone 3")]
		[AttributeLogicalName("address2_telephone3")]
		public string Address2Telephone3
		{	
			get { return GetAttributeValue<string>("address2_telephone3"); }
			set
			{ 
				if(value == Address2Telephone3) return;
				SetAttributeValue("address2_telephone3", value);
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
			set
			{ 
				if(value == Address2UPSZone) return;
				SetAttributeValue("address2_upszone", value);
			}
		}	
			
		/// <summary>
        /// address2_utcoffset
        /// </summary>
		[DisplayName("Address 2: UTC Offset")]
		[AttributeLogicalName("address2_utcoffset")]
		public int? Address2UTCOffset
		{	
			get { return GetAttributeValue<int?>("address2_utcoffset"); }
			set
			{ 
				if(value == Address2UTCOffset) return;
				SetAttributeValue("address2_utcoffset", value);
			}
		}	
			
		/// <summary>
        /// budgetamount
        /// </summary>
		[DisplayName("Budget Amount")]
		[AttributeLogicalName("budgetamount")]
		public decimal? BudgetAmount
		{	
			get { return GetAttributeValue<Money>("budgetamount")?.Value; }
			set 
			{ 
				if(value == BudgetAmount) return;

				Money moneyValue = null;
				if(value != null) moneyValue = new Money(value.Value);
				SetAttributeValue("budgetamount", moneyValue);  
			}
		}

		/// <summary>
        /// budgetstatus
        /// </summary>
		[DisplayName("Budget")]
		[AttributeLogicalName("budgetstatus")]
		public egBudget? Budget
		{	
			get 
			{ 
				var optionSetValue = GetAttributeValue<OptionSetValue>("budgetstatus");
				if (optionSetValue != null) return (egBudget)optionSetValue.Value;
				else return null;
			}
			set 
			{ 
				if(value == Budget) return;

				OptionSetValue optionSetValue = null;
				if(value != null) optionSetValue = new OptionSetValue((int)value);
				SetAttributeValue("budgetstatus", optionSetValue); 
			}
		}

		/// <summary>
        /// businesscard
        /// </summary>
		[DisplayName("Business Card")]
		[AttributeLogicalName("businesscard")]
		public string BusinessCard
		{	
			get { return GetAttributeValue<string>("businesscard"); }
			set
			{ 
				if(value == BusinessCard) return;
				SetAttributeValue("businesscard", value);
			}
		}	
			
		/// <summary>
        /// businesscardattributes
        /// </summary>
		[DisplayName("BusinessCardAttributes")]
		[AttributeLogicalName("businesscardattributes")]
		public string BusinessCardAttributes
		{	
			get { return GetAttributeValue<string>("businesscardattributes"); }
			set
			{ 
				if(value == BusinessCardAttributes) return;
				SetAttributeValue("businesscardattributes", value);
			}
		}	
			
		/// <summary>
        /// campaignid
        /// </summary>
		[DisplayName("Source Campaign")]
		[AttributeLogicalName("campaignid")]
		public EntityReference SourceCampaign
		{	
			get { return GetAttributeValue<EntityReference>("campaignid"); }
			set
			{ 
				if(value == SourceCampaign) return;
				SetAttributeValue("campaignid", value);
			}
		}	
			
		/// <summary>
        /// campaignidname
        /// </summary>
		[DisplayName("campaignidname")]
		[AttributeLogicalName("campaignidname")]
		public string Campaignidname
		{	
			get { return GetAttributeValue<string>("campaignidname"); }
			set
			{ 
				if(value == Campaignidname) return;
				SetAttributeValue("campaignidname", value);
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
        /// confirminterest
        /// </summary>
		[DisplayName("Confirm Interest")]
		[AttributeLogicalName("confirminterest")]
		public bool? ConfirmInterest
		{	
			get { return GetAttributeValue<bool?>("confirminterest"); }
			set
			{ 
				if(value == ConfirmInterest) return;
				SetAttributeValue("confirminterest", value);
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
        /// decisionmaker
        /// </summary>
		[DisplayName("Decision Maker?")]
		[AttributeLogicalName("decisionmaker")]
		public bool? DecisionMaker
		{	
			get { return GetAttributeValue<bool?>("decisionmaker"); }
			set
			{ 
				if(value == DecisionMaker) return;
				SetAttributeValue("decisionmaker", value);
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
        /// donotbulkemail
        /// </summary>
		[DisplayName("Do not allow Bulk Emails")]
		[AttributeLogicalName("donotbulkemail")]
		public bool? DoNotAllowBulkEmails
		{	
			get { return GetAttributeValue<bool?>("donotbulkemail"); }
			set
			{ 
				if(value == DoNotAllowBulkEmails) return;
				SetAttributeValue("donotbulkemail", value);
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
			set
			{ 
				if(value == DoNotAllowEmails) return;
				SetAttributeValue("donotemail", value);
			}
		}	
			
		/// <summary>
        /// donotfax
        /// </summary>
		[DisplayName("Do not allow Faxes")]
		[AttributeLogicalName("donotfax")]
		public bool? DoNotAllowFaxes
		{	
			get { return GetAttributeValue<bool?>("donotfax"); }
			set
			{ 
				if(value == DoNotAllowFaxes) return;
				SetAttributeValue("donotfax", value);
			}
		}	
			
		/// <summary>
        /// donotphone
        /// </summary>
		[DisplayName("Do not allow Phone Calls")]
		[AttributeLogicalName("donotphone")]
		public bool? DoNotAllowPhoneCalls
		{	
			get { return GetAttributeValue<bool?>("donotphone"); }
			set
			{ 
				if(value == DoNotAllowPhoneCalls) return;
				SetAttributeValue("donotphone", value);
			}
		}	
			
		/// <summary>
        /// donotpostalmail
        /// </summary>
		[DisplayName("Do not allow Mails")]
		[AttributeLogicalName("donotpostalmail")]
		public bool? DoNotAllowMails
		{	
			get { return GetAttributeValue<bool?>("donotpostalmail"); }
			set
			{ 
				if(value == DoNotAllowMails) return;
				SetAttributeValue("donotpostalmail", value);
			}
		}	
			
		/// <summary>
        /// donotsendmm
        /// </summary>
		[DisplayName("Marketing Material")]
		[AttributeLogicalName("donotsendmm")]
		public bool? MarketingMaterial
		{	
			get { return GetAttributeValue<bool?>("donotsendmm"); }
			set
			{ 
				if(value == MarketingMaterial) return;
				SetAttributeValue("donotsendmm", value);
			}
		}	
			
		/// <summary>
        /// emailaddress1
        /// </summary>
		[DisplayName("Email")]
		[AttributeLogicalName("emailaddress1")]
		public string Email
		{	
			get { return GetAttributeValue<string>("emailaddress1"); }
			set
			{ 
				if(value == Email) return;
				SetAttributeValue("emailaddress1", value);
			}
		}	
			
		/// <summary>
        /// emailaddress2
        /// </summary>
		[DisplayName("Email Address 2")]
		[AttributeLogicalName("emailaddress2")]
		public string EmailAddress2
		{	
			get { return GetAttributeValue<string>("emailaddress2"); }
			set
			{ 
				if(value == EmailAddress2) return;
				SetAttributeValue("emailaddress2", value);
			}
		}	
			
		/// <summary>
        /// emailaddress3
        /// </summary>
		[DisplayName("Email Address 3")]
		[AttributeLogicalName("emailaddress3")]
		public string EmailAddress3
		{	
			get { return GetAttributeValue<string>("emailaddress3"); }
			set
			{ 
				if(value == EmailAddress3) return;
				SetAttributeValue("emailaddress3", value);
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
        /// estimatedamount
        /// </summary>
		[DisplayName("Est. Value")]
		[AttributeLogicalName("estimatedamount")]
		public decimal? EstValue
		{	
			get { return GetAttributeValue<Money>("estimatedamount")?.Value; }
			set 
			{ 
				if(value == EstValue) return;

				Money moneyValue = null;
				if(value != null) moneyValue = new Money(value.Value);
				SetAttributeValue("estimatedamount", moneyValue);  
			}
		}

		/// <summary>
        /// estimatedclosedate
        /// </summary>
		[DisplayName("Est. Close Date")]
		[AttributeLogicalName("estimatedclosedate")]
		public DateTime? EstCloseDate
		{	
			get { return GetAttributeValue<DateTime?>("estimatedclosedate"); }
			set
			{ 
				if(value == EstCloseDate) return;
				SetAttributeValue("estimatedclosedate", value);
			}
		}	
			
		/// <summary>
        /// estimatedvalue
        /// </summary>
		[DisplayName("Est. Value (deprecated)")]
		[AttributeLogicalName("estimatedvalue")]
		public double? EstValuedeprecated
		{	
			get { return GetAttributeValue<double?>("estimatedvalue"); }
			set
			{ 
				if(value == EstValuedeprecated) return;
				SetAttributeValue("estimatedvalue", value);
			}
		}	
			
		/// <summary>
        /// evaluatefit
        /// </summary>
		[DisplayName("Evaluate Fit")]
		[AttributeLogicalName("evaluatefit")]
		public bool? EvaluateFit
		{	
			get { return GetAttributeValue<bool?>("evaluatefit"); }
			set
			{ 
				if(value == EvaluateFit) return;
				SetAttributeValue("evaluatefit", value);
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
        /// followemail
        /// </summary>
		[DisplayName("Follow Email Activity")]
		[AttributeLogicalName("followemail")]
		public bool? FollowEmailActivity
		{	
			get { return GetAttributeValue<bool?>("followemail"); }
			set
			{ 
				if(value == FollowEmailActivity) return;
				SetAttributeValue("followemail", value);
			}
		}	
			
		/// <summary>
        /// fullname
        /// </summary>
		[DisplayName("Name")]
		[AttributeLogicalName("fullname")]
		public string Name
		{	
			get { return GetAttributeValue<string>("fullname"); }
			set
			{ 
				if(value == Name) return;
				SetAttributeValue("fullname", value);
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
				if(value == Industry) return;

				OptionSetValue optionSetValue = null;
				if(value != null) optionSetValue = new OptionSetValue((int)value);
				SetAttributeValue("industrycode", optionSetValue); 
			}
		}

		/// <summary>
        /// initialcommunication
        /// </summary>
		[DisplayName("Initial Communication")]
		[AttributeLogicalName("initialcommunication")]
		public egInitialCommunication? InitialCommunication
		{	
			get 
			{ 
				var optionSetValue = GetAttributeValue<OptionSetValue>("initialcommunication");
				if (optionSetValue != null) return (egInitialCommunication)optionSetValue.Value;
				else return null;
			}
			set 
			{ 
				if(value == InitialCommunication) return;

				OptionSetValue optionSetValue = null;
				if(value != null) optionSetValue = new OptionSetValue((int)value);
				SetAttributeValue("initialcommunication", optionSetValue); 
			}
		}

		/// <summary>
        /// isautocreate
        /// </summary>
		[DisplayName("Auto-created")]
		[AttributeLogicalName("isautocreate")]
		public bool? Autocreated
		{	
			get { return GetAttributeValue<bool?>("isautocreate"); }
			set
			{ 
				if(value == Autocreated) return;
				SetAttributeValue("isautocreate", value);
			}
		}	
			
		/// <summary>
        /// isprivate
        /// </summary>
		[DisplayName("Is Private")]
		[AttributeLogicalName("isprivate")]
		public bool? IsPrivate
		{	
			get { return GetAttributeValue<bool?>("isprivate"); }
			set
			{ 
				if(value == IsPrivate) return;
				SetAttributeValue("isprivate", value);
			}
		}	
			
		/// <summary>
        /// jobtitle
        /// </summary>
		[DisplayName("Job Title")]
		[AttributeLogicalName("jobtitle")]
		public string JobTitle
		{	
			get { return GetAttributeValue<string>("jobtitle"); }
			set
			{ 
				if(value == JobTitle) return;
				SetAttributeValue("jobtitle", value);
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
        /// lastusedincampaign
        /// </summary>
		[DisplayName("Last Campaign Date")]
		[AttributeLogicalName("lastusedincampaign")]
		public DateTime? LastCampaignDate
		{	
			get { return GetAttributeValue<DateTime?>("lastusedincampaign"); }
			set
			{ 
				if(value == LastCampaignDate) return;
				SetAttributeValue("lastusedincampaign", value);
			}
		}	
			
		/// <summary>
        /// leadid
        /// </summary>
		[DisplayName("Lead")]
		[AttributeLogicalName("leadid")]
		public override Guid Id
		{
			get => base.Id;
			set { base.Id = value; SetAttributeValue("leadid", value); }
		}

							/// <summary>
        /// leadqualitycode
        /// </summary>
		[DisplayName("Rating")]
		[AttributeLogicalName("leadqualitycode")]
		public eRating? Rating
		{	
			get 
			{ 
				var optionSetValue = GetAttributeValue<OptionSetValue>("leadqualitycode");
				if (optionSetValue != null) return (eRating)optionSetValue.Value;
				else return null;
			}
			set 
			{ 
				if(value == Rating) return;

				OptionSetValue optionSetValue = null;
				if(value != null) optionSetValue = new OptionSetValue((int)value);
				SetAttributeValue("leadqualitycode", optionSetValue); 
			}
		}

		/// <summary>
        /// leadsourcecode
        /// </summary>
		[DisplayName("Lead Source")]
		[AttributeLogicalName("leadsourcecode")]
		public eLeadSource? LeadSource
		{	
			get 
			{ 
				var optionSetValue = GetAttributeValue<OptionSetValue>("leadsourcecode");
				if (optionSetValue != null) return (eLeadSource)optionSetValue.Value;
				else return null;
			}
			set 
			{ 
				if(value == LeadSource) return;

				OptionSetValue optionSetValue = null;
				if(value != null) optionSetValue = new OptionSetValue((int)value);
				SetAttributeValue("leadsourcecode", optionSetValue); 
			}
		}

		/// <summary>
        /// masterid
        /// </summary>
		[DisplayName("Master ID")]
		[AttributeLogicalName("masterid")]
		public EntityReference MasterID
		{	
			get { return GetAttributeValue<EntityReference>("masterid"); }
			set
			{ 
				if(value == MasterID) return;
				SetAttributeValue("masterid", value);
			}
		}	
			
		/// <summary>
        /// masterleadidname
        /// </summary>
		[DisplayName("masterleadidname")]
		[AttributeLogicalName("masterleadidname")]
		public string Masterleadidname
		{	
			get { return GetAttributeValue<string>("masterleadidname"); }
			set
			{ 
				if(value == Masterleadidname) return;
				SetAttributeValue("masterleadidname", value);
			}
		}	
			
		/// <summary>
        /// masterleadidyominame
        /// </summary>
		[DisplayName("masterleadidyominame")]
		[AttributeLogicalName("masterleadidyominame")]
		public string Masterleadidyominame
		{	
			get { return GetAttributeValue<string>("masterleadidyominame"); }
			set
			{ 
				if(value == Masterleadidyominame) return;
				SetAttributeValue("masterleadidyominame", value);
			}
		}	
			
		/// <summary>
        /// merged
        /// </summary>
		[DisplayName("Merged")]
		[AttributeLogicalName("merged")]
		public bool? Merged
		{	
			get { return GetAttributeValue<bool?>("merged"); }
			set
			{ 
				if(value == Merged) return;
				SetAttributeValue("merged", value);
			}
		}	
			
		/// <summary>
        /// middlename
        /// </summary>
		[DisplayName("Middle Name")]
		[AttributeLogicalName("middlename")]
		public string MiddleName
		{	
			get { return GetAttributeValue<string>("middlename"); }
			set
			{ 
				if(value == MiddleName) return;
				SetAttributeValue("middlename", value);
			}
		}	
			
		/// <summary>
        /// mobilephone
        /// </summary>
		[DisplayName("Mobile Phone")]
		[AttributeLogicalName("mobilephone")]
		public string MobilePhone
		{	
			get { return GetAttributeValue<string>("mobilephone"); }
			set
			{ 
				if(value == MobilePhone) return;
				SetAttributeValue("mobilephone", value);
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
        /// msdyn_gdproptout
        /// </summary>
		[DisplayName("GDPR Optout")]
		[AttributeLogicalName("msdyn_gdproptout")]
		public bool? GDPROptout
		{	
			get { return GetAttributeValue<bool?>("msdyn_gdproptout"); }
			set
			{ 
				if(value == GDPROptout) return;
				SetAttributeValue("msdyn_gdproptout", value);
			}
		}	
			
		/// <summary>
        /// need
        /// </summary>
		[DisplayName("Need")]
		[AttributeLogicalName("need")]
		public egNeed? Need
		{	
			get 
			{ 
				var optionSetValue = GetAttributeValue<OptionSetValue>("need");
				if (optionSetValue != null) return (egNeed)optionSetValue.Value;
				else return null;
			}
			set 
			{ 
				if(value == Need) return;

				OptionSetValue optionSetValue = null;
				if(value != null) optionSetValue = new OptionSetValue((int)value);
				SetAttributeValue("need", optionSetValue); 
			}
		}

		/// <summary>
        /// numberofemployees
        /// </summary>
		[DisplayName("No. of Employees")]
		[AttributeLogicalName("numberofemployees")]
		public int? NoOfEmployees
		{	
			get { return GetAttributeValue<int?>("numberofemployees"); }
			set
			{ 
				if(value == NoOfEmployees) return;
				SetAttributeValue("numberofemployees", value);
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
        /// originatingcaseid
        /// </summary>
		[DisplayName("Originating Case")]
		[AttributeLogicalName("originatingcaseid")]
		public EntityReference OriginatingCase
		{	
			get { return GetAttributeValue<EntityReference>("originatingcaseid"); }
			set
			{ 
				if(value == OriginatingCase) return;
				SetAttributeValue("originatingcaseid", value);
			}
		}	
			
		/// <summary>
        /// originatingcaseidname
        /// </summary>
		[DisplayName("originatingcaseidname")]
		[AttributeLogicalName("originatingcaseidname")]
		public string Originatingcaseidname
		{	
			get { return GetAttributeValue<string>("originatingcaseidname"); }
			set
			{ 
				if(value == Originatingcaseidname) return;
				SetAttributeValue("originatingcaseidname", value);
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
        /// pager
        /// </summary>
		[DisplayName("Pager")]
		[AttributeLogicalName("pager")]
		public string Pager
		{	
			get { return GetAttributeValue<string>("pager"); }
			set
			{ 
				if(value == Pager) return;
				SetAttributeValue("pager", value);
			}
		}	
			
		/// <summary>
        /// parentaccountid
        /// </summary>
		[DisplayName("Parent Account for lead")]
		[AttributeLogicalName("parentaccountid")]
		public EntityReference ParentAccountForLead
		{	
			get { return GetAttributeValue<EntityReference>("parentaccountid"); }
			set
			{ 
				if(value == ParentAccountForLead) return;
				SetAttributeValue("parentaccountid", value);
			}
		}	
			
		/// <summary>
        /// parentaccountidname
        /// </summary>
		[DisplayName("parentaccountidname")]
		[AttributeLogicalName("parentaccountidname")]
		public string Parentaccountidname
		{	
			get { return GetAttributeValue<string>("parentaccountidname"); }
			set
			{ 
				if(value == Parentaccountidname) return;
				SetAttributeValue("parentaccountidname", value);
			}
		}	
			
		/// <summary>
        /// parentaccountidyominame
        /// </summary>
		[DisplayName("parentaccountidyominame")]
		[AttributeLogicalName("parentaccountidyominame")]
		public string Parentaccountidyominame
		{	
			get { return GetAttributeValue<string>("parentaccountidyominame"); }
			set
			{ 
				if(value == Parentaccountidyominame) return;
				SetAttributeValue("parentaccountidyominame", value);
			}
		}	
			
		/// <summary>
        /// parentcontactid
        /// </summary>
		[DisplayName("Parent Contact for lead")]
		[AttributeLogicalName("parentcontactid")]
		public EntityReference ParentContactForLead
		{	
			get { return GetAttributeValue<EntityReference>("parentcontactid"); }
			set
			{ 
				if(value == ParentContactForLead) return;
				SetAttributeValue("parentcontactid", value);
			}
		}	
			
		/// <summary>
        /// parentcontactidname
        /// </summary>
		[DisplayName("parentcontactidname")]
		[AttributeLogicalName("parentcontactidname")]
		public string Parentcontactidname
		{	
			get { return GetAttributeValue<string>("parentcontactidname"); }
			set
			{ 
				if(value == Parentcontactidname) return;
				SetAttributeValue("parentcontactidname", value);
			}
		}	
			
		/// <summary>
        /// parentcontactidyominame
        /// </summary>
		[DisplayName("parentcontactidyominame")]
		[AttributeLogicalName("parentcontactidyominame")]
		public string Parentcontactidyominame
		{	
			get { return GetAttributeValue<string>("parentcontactidyominame"); }
			set
			{ 
				if(value == Parentcontactidyominame) return;
				SetAttributeValue("parentcontactidyominame", value);
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
			set
			{ 
				if(value == ParticipatesInWorkflow) return;
				SetAttributeValue("participatesinworkflow", value);
			}
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
				if(value == PreferredMethodOfContact) return;

				OptionSetValue optionSetValue = null;
				if(value != null) optionSetValue = new OptionSetValue((int)value);
				SetAttributeValue("preferredcontactmethodcode", optionSetValue); 
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
        /// purchaseprocess
        /// </summary>
		[DisplayName("Purchase Process")]
		[AttributeLogicalName("purchaseprocess")]
		public egPurchaseProcess? PurchaseProcess
		{	
			get 
			{ 
				var optionSetValue = GetAttributeValue<OptionSetValue>("purchaseprocess");
				if (optionSetValue != null) return (egPurchaseProcess)optionSetValue.Value;
				else return null;
			}
			set 
			{ 
				if(value == PurchaseProcess) return;

				OptionSetValue optionSetValue = null;
				if(value != null) optionSetValue = new OptionSetValue((int)value);
				SetAttributeValue("purchaseprocess", optionSetValue); 
			}
		}

		/// <summary>
        /// purchasetimeframe
        /// </summary>
		[DisplayName("Purchase Timeframe")]
		[AttributeLogicalName("purchasetimeframe")]
		public egPurchaseTimeframe? PurchaseTimeframe
		{	
			get 
			{ 
				var optionSetValue = GetAttributeValue<OptionSetValue>("purchasetimeframe");
				if (optionSetValue != null) return (egPurchaseTimeframe)optionSetValue.Value;
				else return null;
			}
			set 
			{ 
				if(value == PurchaseTimeframe) return;

				OptionSetValue optionSetValue = null;
				if(value != null) optionSetValue = new OptionSetValue((int)value);
				SetAttributeValue("purchasetimeframe", optionSetValue); 
			}
		}

		/// <summary>
        /// qualificationcomments
        /// </summary>
		[DisplayName("Qualification Comments")]
		[AttributeLogicalName("qualificationcomments")]
		public string QualificationComments
		{	
			get { return GetAttributeValue<string>("qualificationcomments"); }
			set
			{ 
				if(value == QualificationComments) return;
				SetAttributeValue("qualificationcomments", value);
			}
		}	
			
		/// <summary>
        /// qualifyingopportunityid
        /// </summary>
		[DisplayName("Qualifying Opportunity")]
		[AttributeLogicalName("qualifyingopportunityid")]
		public EntityReference QualifyingOpportunity
		{	
			get { return GetAttributeValue<EntityReference>("qualifyingopportunityid"); }
			set
			{ 
				if(value == QualifyingOpportunity) return;
				SetAttributeValue("qualifyingopportunityid", value);
			}
		}	
			
		/// <summary>
        /// qualifyingopportunityidname
        /// </summary>
		[DisplayName("qualifyingopportunityidname")]
		[AttributeLogicalName("qualifyingopportunityidname")]
		public string Qualifyingopportunityidname
		{	
			get { return GetAttributeValue<string>("qualifyingopportunityidname"); }
			set
			{ 
				if(value == Qualifyingopportunityidname) return;
				SetAttributeValue("qualifyingopportunityidname", value);
			}
		}	
			
		/// <summary>
        /// relatedobjectid
        /// </summary>
		[DisplayName("Related Campaign Response")]
		[AttributeLogicalName("relatedobjectid")]
		public EntityReference RelatedCampaignResponse
		{	
			get { return GetAttributeValue<EntityReference>("relatedobjectid"); }
			set
			{ 
				if(value == RelatedCampaignResponse) return;
				SetAttributeValue("relatedobjectid", value);
			}
		}	
			
		/// <summary>
        /// relatedobjectidname
        /// </summary>
		[DisplayName("relatedobjectidname")]
		[AttributeLogicalName("relatedobjectidname")]
		public string Relatedobjectidname
		{	
			get { return GetAttributeValue<string>("relatedobjectidname"); }
			set
			{ 
				if(value == Relatedobjectidname) return;
				SetAttributeValue("relatedobjectidname", value);
			}
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
				if(value == AnnualRevenue) return;

				Money moneyValue = null;
				if(value != null) moneyValue = new Money(value.Value);
				SetAttributeValue("revenue", moneyValue);  
			}
		}

		/// <summary>
        /// salesstage
        /// </summary>
		[DisplayName("Sales Stage")]
		[AttributeLogicalName("salesstage")]
		public egLeadSalesStage? SalesStage
		{	
			get 
			{ 
				var optionSetValue = GetAttributeValue<OptionSetValue>("salesstage");
				if (optionSetValue != null) return (egLeadSalesStage)optionSetValue.Value;
				else return null;
			}
			set 
			{ 
				if(value == SalesStage) return;

				OptionSetValue optionSetValue = null;
				if(value != null) optionSetValue = new OptionSetValue((int)value);
				SetAttributeValue("salesstage", optionSetValue); 
			}
		}

		/// <summary>
        /// salesstagecode
        /// </summary>
		[DisplayName("Sales Stage Code")]
		[AttributeLogicalName("salesstagecode")]
		public eSalesStage? SalesStageCode
		{	
			get 
			{ 
				var optionSetValue = GetAttributeValue<OptionSetValue>("salesstagecode");
				if (optionSetValue != null) return (eSalesStage)optionSetValue.Value;
				else return null;
			}
			set 
			{ 
				if(value == SalesStageCode) return;

				OptionSetValue optionSetValue = null;
				if(value != null) optionSetValue = new OptionSetValue((int)value);
				SetAttributeValue("salesstagecode", optionSetValue); 
			}
		}

		/// <summary>
        /// salutation
        /// </summary>
		[DisplayName("Salutation")]
		[AttributeLogicalName("salutation")]
		public string Salutation
		{	
			get { return GetAttributeValue<string>("salutation"); }
			set
			{ 
				if(value == Salutation) return;
				SetAttributeValue("salutation", value);
			}
		}	
			
		/// <summary>
        /// schedulefollowup_prospect
        /// </summary>
		[DisplayName("Schedule Follow Up (Prospect)")]
		[AttributeLogicalName("schedulefollowup_prospect")]
		public DateTime? ScheduleFollowUpProspect
		{	
			get { return GetAttributeValue<DateTime?>("schedulefollowup_prospect"); }
			set
			{ 
				if(value == ScheduleFollowUpProspect) return;
				SetAttributeValue("schedulefollowup_prospect", value);
			}
		}	
			
		/// <summary>
        /// schedulefollowup_qualify
        /// </summary>
		[DisplayName("Schedule Follow Up (Qualify)")]
		[AttributeLogicalName("schedulefollowup_qualify")]
		public DateTime? ScheduleFollowUpQualify
		{	
			get { return GetAttributeValue<DateTime?>("schedulefollowup_qualify"); }
			set
			{ 
				if(value == ScheduleFollowUpQualify) return;
				SetAttributeValue("schedulefollowup_qualify", value);
			}
		}	
			
		/// <summary>
        /// sic
        /// </summary>
		[DisplayName("SIC Code")]
		[AttributeLogicalName("sic")]
		public string SICCode
		{	
			get { return GetAttributeValue<string>("sic"); }
			set
			{ 
				if(value == SICCode) return;
				SetAttributeValue("sic", value);
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
        /// subject
        /// </summary>
		[DisplayName("Topic")]
		[AttributeLogicalName("subject")]
		public string Topic
		{	
			get { return GetAttributeValue<string>("subject"); }
			set
			{ 
				if(value == Topic) return;
				SetAttributeValue("subject", value);
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
			set
			{ 
				if(value == TeamsFollowed) return;
				SetAttributeValue("teamsfollowed", value);
			}
		}	
			
		/// <summary>
        /// telephone1
        /// </summary>
		[DisplayName("Business Phone")]
		[AttributeLogicalName("telephone1")]
		public string BusinessPhone
		{	
			get { return GetAttributeValue<string>("telephone1"); }
			set
			{ 
				if(value == BusinessPhone) return;
				SetAttributeValue("telephone1", value);
			}
		}	
			
		/// <summary>
        /// telephone2
        /// </summary>
		[DisplayName("Home Phone")]
		[AttributeLogicalName("telephone2")]
		public string HomePhone
		{	
			get { return GetAttributeValue<string>("telephone2"); }
			set
			{ 
				if(value == HomePhone) return;
				SetAttributeValue("telephone2", value);
			}
		}	
			
		/// <summary>
        /// telephone3
        /// </summary>
		[DisplayName("Other Phone")]
		[AttributeLogicalName("telephone3")]
		public string OtherPhone
		{	
			get { return GetAttributeValue<string>("telephone3"); }
			set
			{ 
				if(value == OtherPhone) return;
				SetAttributeValue("telephone3", value);
			}
		}	
			
		/// <summary>
        /// timespentbymeonemailandmeetings
        /// </summary>
		[DisplayName("Time Spent by me")]
		[AttributeLogicalName("timespentbymeonemailandmeetings")]
		public string TimeSpentByMe
		{	
			get { return GetAttributeValue<string>("timespentbymeonemailandmeetings"); }
			set
			{ 
				if(value == TimeSpentByMe) return;
				SetAttributeValue("timespentbymeonemailandmeetings", value);
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
        /// websiteurl
        /// </summary>
		[DisplayName("Website")]
		[AttributeLogicalName("websiteurl")]
		public string Website
		{	
			get { return GetAttributeValue<string>("websiteurl"); }
			set
			{ 
				if(value == Website) return;
				SetAttributeValue("websiteurl", value);
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
        /// yomifullname
        /// </summary>
		[DisplayName("Yomi Full Name")]
		[AttributeLogicalName("yomifullname")]
		public string YomiFullName
		{	
			get { return GetAttributeValue<string>("yomifullname"); }
			set
			{ 
				if(value == YomiFullName) return;
				SetAttributeValue("yomifullname", value);
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
			
		/// <summary>
        /// yomimiddlename
        /// </summary>
		[DisplayName("Yomi Middle Name")]
		[AttributeLogicalName("yomimiddlename")]
		public string YomiMiddleName
		{	
			get { return GetAttributeValue<string>("yomimiddlename"); }
			set
			{ 
				if(value == YomiMiddleName) return;
				SetAttributeValue("yomimiddlename", value);
			}
		}	
			
		#endregion	

		#region Relations
			/// <summary>
        /// 1:N Get entities for 'account_originating_lead'
        /// </summary>
		[RelationshipSchemaName("account_originating_lead")]
		public IEnumerable<Account> AccountOriginatingLead
		{
			get { return GetRelatedEntities<Account>("account_originating_lead", null); }
			set { SetRelatedEntities("account_originating_lead", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'contact_originating_lead'
        /// </summary>
		[RelationshipSchemaName("contact_originating_lead")]
		public IEnumerable<Contact> ContactOriginatingLead
		{
			get { return GetRelatedEntities<Contact>("contact_originating_lead", null); }
			set { SetRelatedEntities("contact_originating_lead", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'Lead_actioncard'
        /// </summary>
		[RelationshipSchemaName("Lead_actioncard")]
		public IEnumerable<ActionCard> LeadActioncard
		{
			get { return GetRelatedEntities<ActionCard>("Lead_actioncard", null); }
			set { SetRelatedEntities("Lead_actioncard", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lead_activity_parties'
        /// </summary>
		[RelationshipSchemaName("lead_activity_parties")]
		public IEnumerable<ActivityParty> LeadActivityParties
		{
			get { return GetRelatedEntities<ActivityParty>("lead_activity_parties", null); }
			set { SetRelatedEntities("lead_activity_parties", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'Lead_ActivityPointers'
        /// </summary>
		[RelationshipSchemaName("Lead_ActivityPointers")]
		public IEnumerable<Activity> LeadActivityPointers
		{
			get { return GetRelatedEntities<Activity>("Lead_ActivityPointers", null); }
			set { SetRelatedEntities("Lead_ActivityPointers", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lead_addresses'
        /// </summary>
		[RelationshipSchemaName("lead_addresses")]
		public IEnumerable<LeadAddress> LeadAddresses
		{
			get { return GetRelatedEntities<LeadAddress>("lead_addresses", null); }
			set { SetRelatedEntities("lead_addresses", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'Lead_Annotation'
        /// </summary>
		[RelationshipSchemaName("Lead_Annotation")]
		public IEnumerable<Note> LeadAnnotation
		{
			get { return GetRelatedEntities<Note>("Lead_Annotation", null); }
			set { SetRelatedEntities("Lead_Annotation", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'Lead_Appointments'
        /// </summary>
		[RelationshipSchemaName("Lead_Appointments")]
		public IEnumerable<Appointment> LeadAppointments
		{
			get { return GetRelatedEntities<Appointment>("Lead_Appointments", null); }
			set { SetRelatedEntities("Lead_Appointments", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'Lead_AsyncOperations'
        /// </summary>
		[RelationshipSchemaName("Lead_AsyncOperations")]
		public IEnumerable<SystemJob> LeadAsyncOperations
		{
			get { return GetRelatedEntities<SystemJob>("Lead_AsyncOperations", null); }
			set { SetRelatedEntities("Lead_AsyncOperations", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'Lead_BulkDeleteFailures'
        /// </summary>
		[RelationshipSchemaName("Lead_BulkDeleteFailures")]
		public IEnumerable<BulkDeleteFailure> LeadBulkDeleteFailures
		{
			get { return GetRelatedEntities<BulkDeleteFailure>("Lead_BulkDeleteFailures", null); }
			set { SetRelatedEntities("Lead_BulkDeleteFailures", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lead_BulkOperations'
        /// </summary>
		[RelationshipSchemaName("lead_BulkOperations")]
		public IEnumerable<QuickCampaign> LeadBulkOperations
		{
			get { return GetRelatedEntities<QuickCampaign>("lead_BulkOperations", null); }
			set { SetRelatedEntities("lead_BulkOperations", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lead_CampaignResponses'
        /// </summary>
		[RelationshipSchemaName("lead_CampaignResponses")]
		public IEnumerable<CampaignResponse> LeadCampaignResponses
		{
			get { return GetRelatedEntities<CampaignResponse>("lead_CampaignResponses", null); }
			set { SetRelatedEntities("lead_CampaignResponses", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lead_connections1'
        /// </summary>
		[RelationshipSchemaName("lead_connections1")]
		public IEnumerable<Connection> LeadConnections1
		{
			get { return GetRelatedEntities<Connection>("lead_connections1", null); }
			set { SetRelatedEntities("lead_connections1", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lead_connections2'
        /// </summary>
		[RelationshipSchemaName("lead_connections2")]
		public IEnumerable<Connection> LeadConnections2
		{
			get { return GetRelatedEntities<Connection>("lead_connections2", null); }
			set { SetRelatedEntities("lead_connections2", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'Lead_DuplicateBaseRecord'
        /// </summary>
		[RelationshipSchemaName("Lead_DuplicateBaseRecord")]
		public IEnumerable<DuplicateRecord> LeadDuplicateBaseRecord
		{
			get { return GetRelatedEntities<DuplicateRecord>("Lead_DuplicateBaseRecord", null); }
			set { SetRelatedEntities("Lead_DuplicateBaseRecord", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'Lead_DuplicateMatchingRecord'
        /// </summary>
		[RelationshipSchemaName("Lead_DuplicateMatchingRecord")]
		public IEnumerable<DuplicateRecord> LeadDuplicateMatchingRecord
		{
			get { return GetRelatedEntities<DuplicateRecord>("Lead_DuplicateMatchingRecord", null); }
			set { SetRelatedEntities("Lead_DuplicateMatchingRecord", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'Lead_Email_EmailSender'
        /// </summary>
		[RelationshipSchemaName("Lead_Email_EmailSender")]
		public IEnumerable<Email> LeadEmailEmailSender
		{
			get { return GetRelatedEntities<Email>("Lead_Email_EmailSender", null); }
			set { SetRelatedEntities("Lead_Email_EmailSender", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'Lead_Emails'
        /// </summary>
		[RelationshipSchemaName("Lead_Emails")]
		public IEnumerable<Email> LeadEmails
		{
			get { return GetRelatedEntities<Email>("Lead_Emails", null); }
			set { SetRelatedEntities("Lead_Emails", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'Lead_Faxes'
        /// </summary>
		[RelationshipSchemaName("Lead_Faxes")]
		public IEnumerable<Fax> LeadFaxes
		{
			get { return GetRelatedEntities<Fax>("Lead_Faxes", null); }
			set { SetRelatedEntities("Lead_Faxes", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lead_IncidentResolutions'
        /// </summary>
		[RelationshipSchemaName("lead_IncidentResolutions")]
		public IEnumerable<CaseResolution> LeadIncidentResolutions
		{
			get { return GetRelatedEntities<CaseResolution>("lead_IncidentResolutions", null); }
			set { SetRelatedEntities("lead_IncidentResolutions", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'Lead_Letters'
        /// </summary>
		[RelationshipSchemaName("Lead_Letters")]
		public IEnumerable<Letter> LeadLetters
		{
			get { return GetRelatedEntities<Letter>("Lead_Letters", null); }
			set { SetRelatedEntities("Lead_Letters", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'Lead_MailboxTrackingFolder'
        /// </summary>
		[RelationshipSchemaName("Lead_MailboxTrackingFolder")]
		public IEnumerable<MailboxAutoTrackingFolder> LeadMailboxTrackingFolder
		{
			get { return GetRelatedEntities<MailboxAutoTrackingFolder>("Lead_MailboxTrackingFolder", null); }
			set { SetRelatedEntities("Lead_MailboxTrackingFolder", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lead_master_lead'
        /// </summary>
		[RelationshipSchemaName("lead_master_lead")]
		public IEnumerable<Lead> LeadMasterLead
		{
			get { return GetRelatedEntities<Lead>("lead_master_lead", null); }
			set { SetRelatedEntities("lead_master_lead", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lead_OpportunityCloses'
        /// </summary>
		[RelationshipSchemaName("lead_OpportunityCloses")]
		public IEnumerable<OpportunityClose> LeadOpportunityCloses
		{
			get { return GetRelatedEntities<OpportunityClose>("lead_OpportunityCloses", null); }
			set { SetRelatedEntities("lead_OpportunityCloses", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lead_OrderCloses'
        /// </summary>
		[RelationshipSchemaName("lead_OrderCloses")]
		public IEnumerable<OrderClose> LeadOrderCloses
		{
			get { return GetRelatedEntities<OrderClose>("lead_OrderCloses", null); }
			set { SetRelatedEntities("lead_OrderCloses", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'Lead_Phonecalls'
        /// </summary>
		[RelationshipSchemaName("Lead_Phonecalls")]
		public IEnumerable<PhoneCall> LeadPhonecalls
		{
			get { return GetRelatedEntities<PhoneCall>("Lead_Phonecalls", null); }
			set { SetRelatedEntities("Lead_Phonecalls", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lead_PostFollows'
        /// </summary>
		[RelationshipSchemaName("lead_PostFollows")]
		public IEnumerable<Follow> LeadPostFollows
		{
			get { return GetRelatedEntities<Follow>("lead_PostFollows", null); }
			set { SetRelatedEntities("lead_PostFollows", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lead_principalobjectattributeaccess'
        /// </summary>
		[RelationshipSchemaName("lead_principalobjectattributeaccess")]
		public IEnumerable<FieldSharing> LeadPrincipalobjectattributeaccess
		{
			get { return GetRelatedEntities<FieldSharing>("lead_principalobjectattributeaccess", null); }
			set { SetRelatedEntities("lead_principalobjectattributeaccess", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'Lead_ProcessSessions'
        /// </summary>
		[RelationshipSchemaName("Lead_ProcessSessions")]
		public IEnumerable<ProcessSession> LeadProcessSessions
		{
			get { return GetRelatedEntities<ProcessSession>("Lead_ProcessSessions", null); }
			set { SetRelatedEntities("Lead_ProcessSessions", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lead_QuoteCloses'
        /// </summary>
		[RelationshipSchemaName("lead_QuoteCloses")]
		public IEnumerable<QuoteClose> LeadQuoteCloses
		{
			get { return GetRelatedEntities<QuoteClose>("lead_QuoteCloses", null); }
			set { SetRelatedEntities("lead_QuoteCloses", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'Lead_RecurringAppointmentMasters'
        /// </summary>
		[RelationshipSchemaName("Lead_RecurringAppointmentMasters")]
		public IEnumerable<RecurringAppointment> LeadRecurringAppointmentMasters
		{
			get { return GetRelatedEntities<RecurringAppointment>("Lead_RecurringAppointmentMasters", null); }
			set { SetRelatedEntities("Lead_RecurringAppointmentMasters", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'Lead_ServiceAppointments'
        /// </summary>
		[RelationshipSchemaName("Lead_ServiceAppointments")]
		public IEnumerable<ServiceActivity> LeadServiceAppointments
		{
			get { return GetRelatedEntities<ServiceActivity>("Lead_ServiceAppointments", null); }
			set { SetRelatedEntities("Lead_ServiceAppointments", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'Lead_SharepointDocumentLocation'
        /// </summary>
		[RelationshipSchemaName("Lead_SharepointDocumentLocation")]
		public IEnumerable<DocumentLocation> LeadSharepointDocumentLocation
		{
			get { return GetRelatedEntities<DocumentLocation>("Lead_SharepointDocumentLocation", null); }
			set { SetRelatedEntities("Lead_SharepointDocumentLocation", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'Lead_SocialActivities'
        /// </summary>
		[RelationshipSchemaName("Lead_SocialActivities")]
		public IEnumerable<SocialActivity> LeadSocialActivities
		{
			get { return GetRelatedEntities<SocialActivity>("Lead_SocialActivities", null); }
			set { SetRelatedEntities("Lead_SocialActivities", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'Lead_SyncErrors'
        /// </summary>
		[RelationshipSchemaName("Lead_SyncErrors")]
		public IEnumerable<SyncError> LeadSyncErrors
		{
			get { return GetRelatedEntities<SyncError>("Lead_SyncErrors", null); }
			set { SetRelatedEntities("Lead_SyncErrors", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'Lead_Tasks'
        /// </summary>
		[RelationshipSchemaName("Lead_Tasks")]
		public IEnumerable<Task> LeadTasks
		{
			get { return GetRelatedEntities<Task>("Lead_Tasks", null); }
			set { SetRelatedEntities("Lead_Tasks", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_leadtoopportunitysalesprocess_leadid'
        /// </summary>
		[RelationshipSchemaName("lk_leadtoopportunitysalesprocess_leadid")]
		public IEnumerable<LeadToOpportunitySalesProcess> LkLeadtoopportunitysalesprocessLeadid
		{
			get { return GetRelatedEntities<LeadToOpportunitySalesProcess>("lk_leadtoopportunitysalesprocess_leadid", null); }
			set { SetRelatedEntities("lk_leadtoopportunitysalesprocess_leadid", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'msdyn_playbookinstance_lead'
        /// </summary>
		[RelationshipSchemaName("msdyn_playbookinstance_lead")]
		public IEnumerable<Playbook> MsdynPlaybookinstanceLead
		{
			get { return GetRelatedEntities<Playbook>("msdyn_playbookinstance_lead", null); }
			set { SetRelatedEntities("msdyn_playbookinstance_lead", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'opportunity_originating_lead'
        /// </summary>
		[RelationshipSchemaName("opportunity_originating_lead")]
		public IEnumerable<Opportunity> OpportunityOriginatingLead
		{
			get { return GetRelatedEntities<Opportunity>("opportunity_originating_lead", null); }
			set { SetRelatedEntities("opportunity_originating_lead", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'slakpiinstance_lead'
        /// </summary>
		[RelationshipSchemaName("slakpiinstance_lead")]
		public IEnumerable<SLAKPIInstance> SlakpiinstanceLead
		{
			get { return GetRelatedEntities<SLAKPIInstance>("slakpiinstance_lead", null); }
			set { SetRelatedEntities("slakpiinstance_lead", null, value); }
		}
		/// <summary>
        /// N:N Get entities for 'Account'
        /// </summary>
		[RelationshipSchemaName("accountleads_association")]
		public IEnumerable<Account> AccountleadsAssociation
		{
			get { return GetRelatedEntities<Account>("accountleads_association", null); }
			set { SetRelatedEntities("accountleads_association", null, value); }
		}
		/// <summary>
        /// N:N Get entities for 'QuickCampaign'
        /// </summary>
		[RelationshipSchemaName("BulkOperation_Leads")]
		public IEnumerable<QuickCampaign> BulkOperationLeads
		{
			get { return GetRelatedEntities<QuickCampaign>("BulkOperation_Leads", null); }
			set { SetRelatedEntities("BulkOperation_Leads", null, value); }
		}
		/// <summary>
        /// N:N Get entities for 'CampaignActivity'
        /// </summary>
		[RelationshipSchemaName("CampaignActivity_Leads")]
		public IEnumerable<CampaignActivity> CampaignActivityLeads
		{
			get { return GetRelatedEntities<CampaignActivity>("CampaignActivity_Leads", null); }
			set { SetRelatedEntities("CampaignActivity_Leads", null, value); }
		}
		/// <summary>
        /// N:N Get entities for 'Contact'
        /// </summary>
		[RelationshipSchemaName("contactleads_association")]
		public IEnumerable<Contact> ContactleadsAssociation
		{
			get { return GetRelatedEntities<Contact>("contactleads_association", null); }
			set { SetRelatedEntities("contactleads_association", null, value); }
		}
		/// <summary>
        /// N:N Get entities for 'Competitor'
        /// </summary>
		[RelationshipSchemaName("leadcompetitors_association")]
		public IEnumerable<Competitor> LeadcompetitorsAssociation
		{
			get { return GetRelatedEntities<Competitor>("leadcompetitors_association", null); }
			set { SetRelatedEntities("leadcompetitors_association", null, value); }
		}
		/// <summary>
        /// N:N Get entities for 'Product'
        /// </summary>
		[RelationshipSchemaName("leadproduct_association")]
		public IEnumerable<Product> LeadproductAssociation
		{
			get { return GetRelatedEntities<Product>("leadproduct_association", null); }
			set { SetRelatedEntities("leadproduct_association", null, value); }
		}
		/// <summary>
        /// N:N Get entities for 'MarketingList'
        /// </summary>
		[RelationshipSchemaName("listlead_association")]
		public IEnumerable<MarketingList> ListleadAssociation
		{
			get { return GetRelatedEntities<MarketingList>("listlead_association", null); }
			set { SetRelatedEntities("listlead_association", null, value); }
		}
		#endregion

		#region Actions
		public OrganizationResponse ExecuteSalesInsightsGDPROptoutLead(OrganizationServiceContext serviceContext)
		{
			var orgRequest = new OrganizationRequest("msdyn_GDPROptoutLead");
			orgRequest["Target"] = ToEntityReference();
            return serviceContext.Execute(orgRequest);
		}
		#endregion

		#region OptionSetEnums
		public enum egBudget
		{	
		
			[Label("No Committed Budget")]
			[Description(@"")]
			NoCommittedBudget = 0, 
		
			[Label("May Buy")]
			[Description(@"")]
			MayBuy = 1, 
		
			[Label("Can Buy")]
			[Description(@"")]
			CanBuy = 2, 
		
			[Label("Will Buy")]
			[Description(@"")]
			WillBuy = 3, 
		}
		
		public enum egInitialCommunication
		{	
		
			[Label("Contacted")]
			[Description(@"")]
			Contacted = 0, 
		
			[Label("Not Contacted")]
			[Description(@"")]
			NotContacted = 1, 
		}
		
		public enum eAddress1AddressType
		{	
		
			[Label("Default Value")]
			[Description(@"")]
			DefaultValue = 1, 
		}
		
		public enum eAddress1ShippingMethod
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
		
		public enum eAddress2ShippingMethod
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
		
		public enum eRating
		{	
		
			[Label("Hot")]
			[Description(@"")]
			Hot = 1, 
		
			[Label("Warm")]
			[Description(@"")]
			Warm = 2, 
		
			[Label("Cold")]
			[Description(@"")]
			Cold = 3, 
		}
		
		public enum eLeadSource
		{	
		
			[Label("Advertisement")]
			[Description(@"")]
			Advertisement = 1, 
		
			[Label("Employee Referral")]
			[Description(@"")]
			EmployeeReferral = 2, 
		
			[Label("External Referral")]
			[Description(@"")]
			ExternalReferral = 3, 
		
			[Label("Partner")]
			[Description(@"")]
			Partner = 4, 
		
			[Label("Public Relations")]
			[Description(@"")]
			PublicRelations = 5, 
		
			[Label("Seminar")]
			[Description(@"")]
			Seminar = 6, 
		
			[Label("Trade Show")]
			[Description(@"")]
			TradeShow = 7, 
		
			[Label("Web")]
			[Description(@"")]
			Web = 8, 
		
			[Label("Word of Mouth")]
			[Description(@"")]
			WordOfMouth = 9, 
		
			[Label("Other")]
			[Description(@"")]
			Other = 10, 
		}
		
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
		
		public enum ePriority
		{	
		
			[Label("Default Value")]
			[Description(@"")]
			DefaultValue = 1, 
		}
		
		public enum egLeadSalesStage
		{	
		
			[Label("Qualify")]
			[Description(@"")]
			Qualify = 0, 
		}
		
		public enum eSalesStage
		{	
		
			[Label("Default Value")]
			[Description(@"")]
			DefaultValue = 1, 
		}
		
		public enum eStatus
		{	
		
			[Label("Open")]
			[Description(@"")]
			Open = 0, 
		
			[Label("Qualified")]
			[Description(@"")]
			Qualified = 1, 
		
			[Label("Disqualified")]
			[Description(@"")]
			Disqualified = 2, 
		}
		
		public enum eStatusReason
		{	
		
			[Label("New")]
			[Description(@"")]
			New_Active = 1, 
		
			[Label("Contacted")]
			[Description(@"")]
			Contacted_Active = 2, 
		
			[Label("Qualified")]
			[Description(@"")]
			Qualified_Inactive = 3, 
		
			[Label("Lost")]
			[Description(@"")]
			Lost = 4, 
		
			[Label("Cannot Contact")]
			[Description(@"")]
			CannotContact = 5, 
		
			[Label("No Longer Interested")]
			[Description(@"")]
			NoLongerInterested = 6, 
		
			[Label("Canceled")]
			[Description(@"")]
			Canceled = 7, 
		}
		
		public enum egNeed
		{	
		
			[Label("Must have")]
			[Description(@"")]
			MustHave = 0, 
		
			[Label("Should have")]
			[Description(@"")]
			ShouldHave = 1, 
		
			[Label("Good to have")]
			[Description(@"")]
			GoodToHave = 2, 
		
			[Label("No need")]
			[Description(@"")]
			NoNeed = 3, 
		}
		
		public enum egPurchaseProcess
		{	
		
			[Label("Individual")]
			[Description(@"")]
			Individual = 0, 
		
			[Label("Committee")]
			[Description(@"")]
			Committee = 1, 
		
			[Label("Unknown")]
			[Description(@"")]
			Unknown = 2, 
		}
		
		public enum egPurchaseTimeframe
		{	
		
			[Label("Immediate")]
			[Description(@"")]
			Immediate = 0, 
		
			[Label("This Quarter")]
			[Description(@"")]
			ThisQuarter = 1, 
		
			[Label("Next Quarter")]
			[Description(@"")]
			NextQuarter = 2, 
		
			[Label("This Year")]
			[Description(@"")]
			ThisYear = 3, 
		
			[Label("Unknown")]
			[Description(@"")]
			Unknown = 4, 
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

			/// <summary>address1_addressid</summary>
			public const string Address1Id = "address1_addressid";

			/// <summary>address1_addresstypecode</summary>
			public const string Address1AddressType = "address1_addresstypecode";

			/// <summary>address1_city</summary>
			public const string City = "address1_city";

			/// <summary>address1_composite</summary>
			public const string Address1 = "address1_composite";

			/// <summary>address1_country</summary>
			public const string CountryRegion = "address1_country";

			/// <summary>address1_county</summary>
			public const string Address1County = "address1_county";

			/// <summary>address1_fax</summary>
			public const string Address1Fax = "address1_fax";

			/// <summary>address1_latitude</summary>
			public const string Address1Latitude = "address1_latitude";

			/// <summary>address1_line1</summary>
			public const string Street1 = "address1_line1";

			/// <summary>address1_line2</summary>
			public const string Street2 = "address1_line2";

			/// <summary>address1_line3</summary>
			public const string Street3 = "address1_line3";

			/// <summary>address1_longitude</summary>
			public const string Address1Longitude = "address1_longitude";

			/// <summary>address1_name</summary>
			public const string Address1Name = "address1_name";

			/// <summary>address1_postalcode</summary>
			public const string ZIPPostalCode = "address1_postalcode";

			/// <summary>address1_postofficebox</summary>
			public const string Address1PostOfficeBox = "address1_postofficebox";

			/// <summary>address1_shippingmethodcode</summary>
			public const string Address1ShippingMethod = "address1_shippingmethodcode";

			/// <summary>address1_stateorprovince</summary>
			public const string StateProvince = "address1_stateorprovince";

			/// <summary>address1_telephone1</summary>
			public const string Address1Telephone1 = "address1_telephone1";

			/// <summary>address1_telephone2</summary>
			public const string Address1Telephone2 = "address1_telephone2";

			/// <summary>address1_telephone3</summary>
			public const string Address1Telephone3 = "address1_telephone3";

			/// <summary>address1_upszone</summary>
			public const string Address1UPSZone = "address1_upszone";

			/// <summary>address1_utcoffset</summary>
			public const string Address1UTCOffset = "address1_utcoffset";

			/// <summary>address2_addressid</summary>
			public const string Address2Id = "address2_addressid";

			/// <summary>address2_addresstypecode</summary>
			public const string Address2AddressType = "address2_addresstypecode";

			/// <summary>address2_city</summary>
			public const string Address2City = "address2_city";

			/// <summary>address2_composite</summary>
			public const string Address2 = "address2_composite";

			/// <summary>address2_country</summary>
			public const string Address2CountryRegion = "address2_country";

			/// <summary>address2_county</summary>
			public const string Address2County = "address2_county";

			/// <summary>address2_fax</summary>
			public const string Address2Fax = "address2_fax";

			/// <summary>address2_latitude</summary>
			public const string Address2Latitude = "address2_latitude";

			/// <summary>address2_line1</summary>
			public const string Address2Street1 = "address2_line1";

			/// <summary>address2_line2</summary>
			public const string Address2Street2 = "address2_line2";

			/// <summary>address2_line3</summary>
			public const string Address2Street3 = "address2_line3";

			/// <summary>address2_longitude</summary>
			public const string Address2Longitude = "address2_longitude";

			/// <summary>address2_name</summary>
			public const string Address2Name = "address2_name";

			/// <summary>address2_postalcode</summary>
			public const string Address2ZIPPostalCode = "address2_postalcode";

			/// <summary>address2_postofficebox</summary>
			public const string Address2PostOfficeBox = "address2_postofficebox";

			/// <summary>address2_shippingmethodcode</summary>
			public const string Address2ShippingMethod = "address2_shippingmethodcode";

			/// <summary>address2_stateorprovince</summary>
			public const string Address2StateProvince = "address2_stateorprovince";

			/// <summary>address2_telephone1</summary>
			public const string Address2Telephone1 = "address2_telephone1";

			/// <summary>address2_telephone2</summary>
			public const string Address2Telephone2 = "address2_telephone2";

			/// <summary>address2_telephone3</summary>
			public const string Address2Telephone3 = "address2_telephone3";

			/// <summary>address2_upszone</summary>
			public const string Address2UPSZone = "address2_upszone";

			/// <summary>address2_utcoffset</summary>
			public const string Address2UTCOffset = "address2_utcoffset";

			/// <summary>budgetamount</summary>
			public const string BudgetAmount = "budgetamount";

			/// <summary>budgetstatus</summary>
			public const string Budget = "budgetstatus";

			/// <summary>businesscard</summary>
			public const string BusinessCard = "businesscard";

			/// <summary>businesscardattributes</summary>
			public const string BusinessCardAttributes = "businesscardattributes";

			/// <summary>campaignid</summary>
			public const string SourceCampaign = "campaignid";

			/// <summary>campaignidname</summary>
			public const string Campaignidname = "campaignidname";

			/// <summary>companyname</summary>
			public const string CompanyName = "companyname";

			/// <summary>confirminterest</summary>
			public const string ConfirmInterest = "confirminterest";

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

			/// <summary>decisionmaker</summary>
			public const string DecisionMaker = "decisionmaker";

			/// <summary>description</summary>
			public const string Description = "description";

			/// <summary>donotbulkemail</summary>
			public const string DoNotAllowBulkEmails = "donotbulkemail";

			/// <summary>donotemail</summary>
			public const string DoNotAllowEmails = "donotemail";

			/// <summary>donotfax</summary>
			public const string DoNotAllowFaxes = "donotfax";

			/// <summary>donotphone</summary>
			public const string DoNotAllowPhoneCalls = "donotphone";

			/// <summary>donotpostalmail</summary>
			public const string DoNotAllowMails = "donotpostalmail";

			/// <summary>donotsendmm</summary>
			public const string MarketingMaterial = "donotsendmm";

			/// <summary>emailaddress1</summary>
			public const string Email = "emailaddress1";

			/// <summary>emailaddress2</summary>
			public const string EmailAddress2 = "emailaddress2";

			/// <summary>emailaddress3</summary>
			public const string EmailAddress3 = "emailaddress3";

			/// <summary>entityimage_timestamp</summary>
			public const string EntityimageTimestamp = "entityimage_timestamp";

			/// <summary>entityimage_url</summary>
			public const string EntityimageUrl = "entityimage_url";

			/// <summary>entityimageid</summary>
			public const string EntityimageId = "entityimageid";

			/// <summary>estimatedamount</summary>
			public const string EstValue = "estimatedamount";

			/// <summary>estimatedclosedate</summary>
			public const string EstCloseDate = "estimatedclosedate";

			/// <summary>estimatedvalue</summary>
			public const string EstValuedeprecated = "estimatedvalue";

			/// <summary>evaluatefit</summary>
			public const string EvaluateFit = "evaluatefit";

			/// <summary>exchangerate</summary>
			public const string ExchangeRate = "exchangerate";

			/// <summary>fax</summary>
			public const string Fax = "fax";

			/// <summary>firstname</summary>
			public const string FirstName = "firstname";

			/// <summary>followemail</summary>
			public const string FollowEmailActivity = "followemail";

			/// <summary>fullname</summary>
			public const string Name = "fullname";

			/// <summary>importsequencenumber</summary>
			public const string ImportSequenceNumber = "importsequencenumber";

			/// <summary>industrycode</summary>
			public const string Industry = "industrycode";

			/// <summary>initialcommunication</summary>
			public const string InitialCommunication = "initialcommunication";

			/// <summary>isautocreate</summary>
			public const string Autocreated = "isautocreate";

			/// <summary>isprivate</summary>
			public const string IsPrivate = "isprivate";

			/// <summary>jobtitle</summary>
			public const string JobTitle = "jobtitle";

			/// <summary>lastname</summary>
			public const string LastName = "lastname";

			/// <summary>lastonholdtime</summary>
			public const string LastOnHoldTime = "lastonholdtime";

			/// <summary>lastusedincampaign</summary>
			public const string LastCampaignDate = "lastusedincampaign";

			/// <summary>leadid</summary>
			public const string LeadId = "leadid";

			/// <summary>leadqualitycode</summary>
			public const string Rating = "leadqualitycode";

			/// <summary>leadsourcecode</summary>
			public const string LeadSource = "leadsourcecode";

			/// <summary>masterid</summary>
			public const string MasterID = "masterid";

			/// <summary>masterleadidname</summary>
			public const string Masterleadidname = "masterleadidname";

			/// <summary>masterleadidyominame</summary>
			public const string Masterleadidyominame = "masterleadidyominame";

			/// <summary>merged</summary>
			public const string Merged = "merged";

			/// <summary>middlename</summary>
			public const string MiddleName = "middlename";

			/// <summary>mobilephone</summary>
			public const string MobilePhone = "mobilephone";

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

			/// <summary>msdyn_gdproptout</summary>
			public const string GDPROptout = "msdyn_gdproptout";

			/// <summary>need</summary>
			public const string Need = "need";

			/// <summary>numberofemployees</summary>
			public const string NoOfEmployees = "numberofemployees";

			/// <summary>onholdtime</summary>
			public const string OnHoldTimeMinutes = "onholdtime";

			/// <summary>originatingcaseid</summary>
			public const string OriginatingCase = "originatingcaseid";

			/// <summary>originatingcaseidname</summary>
			public const string Originatingcaseidname = "originatingcaseidname";

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

			/// <summary>pager</summary>
			public const string Pager = "pager";

			/// <summary>parentaccountid</summary>
			public const string ParentAccountForLead = "parentaccountid";

			/// <summary>parentaccountidname</summary>
			public const string Parentaccountidname = "parentaccountidname";

			/// <summary>parentaccountidyominame</summary>
			public const string Parentaccountidyominame = "parentaccountidyominame";

			/// <summary>parentcontactid</summary>
			public const string ParentContactForLead = "parentcontactid";

			/// <summary>parentcontactidname</summary>
			public const string Parentcontactidname = "parentcontactidname";

			/// <summary>parentcontactidyominame</summary>
			public const string Parentcontactidyominame = "parentcontactidyominame";

			/// <summary>participatesinworkflow</summary>
			public const string ParticipatesInWorkflow = "participatesinworkflow";

			/// <summary>preferredcontactmethodcode</summary>
			public const string PreferredMethodOfContact = "preferredcontactmethodcode";

			/// <summary>prioritycode</summary>
			public const string Priority = "prioritycode";

			/// <summary>processid</summary>
			public const string ProcessId = "processid";

			/// <summary>purchaseprocess</summary>
			public const string PurchaseProcess = "purchaseprocess";

			/// <summary>purchasetimeframe</summary>
			public const string PurchaseTimeframe = "purchasetimeframe";

			/// <summary>qualificationcomments</summary>
			public const string QualificationComments = "qualificationcomments";

			/// <summary>qualifyingopportunityid</summary>
			public const string QualifyingOpportunity = "qualifyingopportunityid";

			/// <summary>qualifyingopportunityidname</summary>
			public const string Qualifyingopportunityidname = "qualifyingopportunityidname";

			/// <summary>relatedobjectid</summary>
			public const string RelatedCampaignResponse = "relatedobjectid";

			/// <summary>relatedobjectidname</summary>
			public const string Relatedobjectidname = "relatedobjectidname";

			/// <summary>revenue</summary>
			public const string AnnualRevenue = "revenue";

			/// <summary>salesstage</summary>
			public const string SalesStage = "salesstage";

			/// <summary>salesstagecode</summary>
			public const string SalesStageCode = "salesstagecode";

			/// <summary>salutation</summary>
			public const string Salutation = "salutation";

			/// <summary>schedulefollowup_prospect</summary>
			public const string ScheduleFollowUpProspect = "schedulefollowup_prospect";

			/// <summary>schedulefollowup_qualify</summary>
			public const string ScheduleFollowUpQualify = "schedulefollowup_qualify";

			/// <summary>sic</summary>
			public const string SICCode = "sic";

			/// <summary>slaid</summary>
			public const string SLA = "slaid";

			/// <summary>slainvokedid</summary>
			public const string LastSLAApplied = "slainvokedid";

			/// <summary>slainvokedidname</summary>
			public const string Slainvokedidname = "slainvokedidname";

			/// <summary>slaname</summary>
			public const string Slaname = "slaname";

			/// <summary>stageid</summary>
			public const string DeprecatedStageId = "stageid";

			/// <summary>statecode</summary>
			public const string Status = "statecode";

			/// <summary>statuscode</summary>
			public const string StatusReason = "statuscode";

			/// <summary>subject</summary>
			public const string Topic = "subject";

			/// <summary>teamsfollowed</summary>
			public const string TeamsFollowed = "teamsfollowed";

			/// <summary>telephone1</summary>
			public const string BusinessPhone = "telephone1";

			/// <summary>telephone2</summary>
			public const string HomePhone = "telephone2";

			/// <summary>telephone3</summary>
			public const string OtherPhone = "telephone3";

			/// <summary>timespentbymeonemailandmeetings</summary>
			public const string TimeSpentByMe = "timespentbymeonemailandmeetings";

			/// <summary>timezoneruleversionnumber</summary>
			public const string TimeZoneRuleVersionNumber = "timezoneruleversionnumber";

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

			/// <summary>websiteurl</summary>
			public const string Website = "websiteurl";

			/// <summary>yomicompanyname</summary>
			public const string YomiCompanyName = "yomicompanyname";

			/// <summary>yomifirstname</summary>
			public const string YomiFirstName = "yomifirstname";

			/// <summary>yomifullname</summary>
			public const string YomiFullName = "yomifullname";

			/// <summary>yomilastname</summary>
			public const string YomiLastName = "yomilastname";

			/// <summary>yomimiddlename</summary>
			public const string YomiMiddleName = "yomimiddlename";

		}
		#endregion

		#region Schemas
		public static class Schemas 
		{
			/// <summary>1:N account_originating_lead</summary>
			public const string AccountOriginatingLead = "account_originating_lead";

			/// <summary>1:N contact_originating_lead</summary>
			public const string ContactOriginatingLead = "contact_originating_lead";

			/// <summary>1:N Lead_actioncard</summary>
			public const string LeadActioncard = "Lead_actioncard";

			/// <summary>1:N lead_activity_parties</summary>
			public const string LeadActivityParties = "lead_activity_parties";

			/// <summary>1:N Lead_ActivityPointers</summary>
			public const string LeadActivityPointers = "Lead_ActivityPointers";

			/// <summary>1:N lead_addresses</summary>
			public const string LeadAddresses = "lead_addresses";

			/// <summary>1:N Lead_Annotation</summary>
			public const string LeadAnnotation = "Lead_Annotation";

			/// <summary>1:N Lead_Appointments</summary>
			public const string LeadAppointments = "Lead_Appointments";

			/// <summary>1:N Lead_AsyncOperations</summary>
			public const string LeadAsyncOperations = "Lead_AsyncOperations";

			/// <summary>1:N Lead_BulkDeleteFailures</summary>
			public const string LeadBulkDeleteFailures = "Lead_BulkDeleteFailures";

			/// <summary>1:N lead_BulkOperations</summary>
			public const string LeadBulkOperations = "lead_BulkOperations";

			/// <summary>1:N lead_CampaignResponses</summary>
			public const string LeadCampaignResponses = "lead_CampaignResponses";

			/// <summary>1:N lead_connections1</summary>
			public const string LeadConnections1 = "lead_connections1";

			/// <summary>1:N lead_connections2</summary>
			public const string LeadConnections2 = "lead_connections2";

			/// <summary>1:N Lead_DuplicateBaseRecord</summary>
			public const string LeadDuplicateBaseRecord = "Lead_DuplicateBaseRecord";

			/// <summary>1:N Lead_DuplicateMatchingRecord</summary>
			public const string LeadDuplicateMatchingRecord = "Lead_DuplicateMatchingRecord";

			/// <summary>1:N Lead_Email_EmailSender</summary>
			public const string LeadEmailEmailSender = "Lead_Email_EmailSender";

			/// <summary>1:N Lead_Emails</summary>
			public const string LeadEmails = "Lead_Emails";

			/// <summary>1:N Lead_Faxes</summary>
			public const string LeadFaxes = "Lead_Faxes";

			/// <summary>1:N lead_IncidentResolutions</summary>
			public const string LeadIncidentResolutions = "lead_IncidentResolutions";

			/// <summary>1:N Lead_Letters</summary>
			public const string LeadLetters = "Lead_Letters";

			/// <summary>1:N Lead_MailboxTrackingFolder</summary>
			public const string LeadMailboxTrackingFolder = "Lead_MailboxTrackingFolder";

			/// <summary>1:N lead_master_lead</summary>
			public const string LeadMasterLead = "lead_master_lead";

			/// <summary>1:N lead_OpportunityCloses</summary>
			public const string LeadOpportunityCloses = "lead_OpportunityCloses";

			/// <summary>1:N lead_OrderCloses</summary>
			public const string LeadOrderCloses = "lead_OrderCloses";

			/// <summary>1:N Lead_Phonecalls</summary>
			public const string LeadPhonecalls = "Lead_Phonecalls";

			/// <summary>1:N lead_PostFollows</summary>
			public const string LeadPostFollows = "lead_PostFollows";

			/// <summary>1:N lead_principalobjectattributeaccess</summary>
			public const string LeadPrincipalobjectattributeaccess = "lead_principalobjectattributeaccess";

			/// <summary>1:N Lead_ProcessSessions</summary>
			public const string LeadProcessSessions = "Lead_ProcessSessions";

			/// <summary>1:N lead_QuoteCloses</summary>
			public const string LeadQuoteCloses = "lead_QuoteCloses";

			/// <summary>1:N Lead_RecurringAppointmentMasters</summary>
			public const string LeadRecurringAppointmentMasters = "Lead_RecurringAppointmentMasters";

			/// <summary>1:N Lead_ServiceAppointments</summary>
			public const string LeadServiceAppointments = "Lead_ServiceAppointments";

			/// <summary>1:N Lead_SharepointDocumentLocation</summary>
			public const string LeadSharepointDocumentLocation = "Lead_SharepointDocumentLocation";

			/// <summary>1:N Lead_SocialActivities</summary>
			public const string LeadSocialActivities = "Lead_SocialActivities";

			/// <summary>1:N Lead_SyncErrors</summary>
			public const string LeadSyncErrors = "Lead_SyncErrors";

			/// <summary>1:N Lead_Tasks</summary>
			public const string LeadTasks = "Lead_Tasks";

			/// <summary>1:N lk_leadtoopportunitysalesprocess_leadid</summary>
			public const string LkLeadtoopportunitysalesprocessLeadid = "lk_leadtoopportunitysalesprocess_leadid";

			/// <summary>1:N msdyn_playbookinstance_lead</summary>
			public const string MsdynPlaybookinstanceLead = "msdyn_playbookinstance_lead";

			/// <summary>1:N opportunity_originating_lead</summary>
			public const string OpportunityOriginatingLead = "opportunity_originating_lead";

			/// <summary>1:N slakpiinstance_lead</summary>
			public const string SlakpiinstanceLead = "slakpiinstance_lead";

			/// <summary>N:N accountleads_association</summary>
			public const string AccountleadsAssociation = "accountleads_association";

			/// <summary>N:N BulkOperation_Leads</summary>
			public const string BulkOperationLeads = "BulkOperation_Leads";

			/// <summary>N:N CampaignActivity_Leads</summary>
			public const string CampaignActivityLeads = "CampaignActivity_Leads";

			/// <summary>N:N contactleads_association</summary>
			public const string ContactleadsAssociation = "contactleads_association";

			/// <summary>N:N leadcompetitors_association</summary>
			public const string LeadcompetitorsAssociation = "leadcompetitors_association";

			/// <summary>N:N leadproduct_association</summary>
			public const string LeadproductAssociation = "leadproduct_association";

			/// <summary>N:N listlead_association</summary>
			public const string ListleadAssociation = "listlead_association";

		}
		#endregion
	}
}

