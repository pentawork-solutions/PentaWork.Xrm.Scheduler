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
	[EntityLogicalName("businessunit")]
	public sealed class BusinessUnit : Entity
	{	
		public static readonly int? EntityTypeCode = 10;
		public new const string LogicalName = "businessunit";
		public const string PrimaryIdAttribute = "businessunitid";
		public const string PrimaryNameAttribute = "name";
	
		public BusinessUnit() : base("businessunit") { }

		#region Attributes
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
		[DisplayName("Bill To City")]
		[AttributeLogicalName("address1_city")]
		public string BillToCity
		{	
			get { return GetAttributeValue<string>("address1_city"); }
			set
			{ 
				if(value == BillToCity) return;
				SetAttributeValue("address1_city", value);
			}
		}	
			
		/// <summary>
        /// address1_country
        /// </summary>
		[DisplayName("Bill To Country/Region")]
		[AttributeLogicalName("address1_country")]
		public string BillToCountryRegion
		{	
			get { return GetAttributeValue<string>("address1_country"); }
			set
			{ 
				if(value == BillToCountryRegion) return;
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
		///
		/// Precision: 5
		/// MaxValue: 90
		/// MinValue: -90
        /// </summary>
		[DisplayName("Address 1: Latitude")]
		[AttributeLogicalName("address1_latitude")]
		public double? Address1Latitude
		{	
			get { return GetAttributeValue<double?>("address1_latitude"); }
			set 
			{
				double? doubleValue = null;
				if(value != null) doubleValue = Math.Round(value.Value, 5);
				if(doubleValue == Address1Latitude) return;
				SetAttributeValue("address1_latitude", doubleValue);  
			}
		}

		/// <summary>
        /// address1_line1
        /// </summary>
		[DisplayName("Bill To Street 1")]
		[AttributeLogicalName("address1_line1")]
		public string BillToStreet1
		{	
			get { return GetAttributeValue<string>("address1_line1"); }
			set
			{ 
				if(value == BillToStreet1) return;
				SetAttributeValue("address1_line1", value);
			}
		}	
			
		/// <summary>
        /// address1_line2
        /// </summary>
		[DisplayName("Bill To Street 2")]
		[AttributeLogicalName("address1_line2")]
		public string BillToStreet2
		{	
			get { return GetAttributeValue<string>("address1_line2"); }
			set
			{ 
				if(value == BillToStreet2) return;
				SetAttributeValue("address1_line2", value);
			}
		}	
			
		/// <summary>
        /// address1_line3
        /// </summary>
		[DisplayName("Bill To Street 3")]
		[AttributeLogicalName("address1_line3")]
		public string BillToStreet3
		{	
			get { return GetAttributeValue<string>("address1_line3"); }
			set
			{ 
				if(value == BillToStreet3) return;
				SetAttributeValue("address1_line3", value);
			}
		}	
			
		/// <summary>
        /// address1_longitude
		///
		/// Precision: 5
		/// MaxValue: 180
		/// MinValue: -180
        /// </summary>
		[DisplayName("Address 1: Longitude")]
		[AttributeLogicalName("address1_longitude")]
		public double? Address1Longitude
		{	
			get { return GetAttributeValue<double?>("address1_longitude"); }
			set 
			{
				double? doubleValue = null;
				if(value != null) doubleValue = Math.Round(value.Value, 5);
				if(doubleValue == Address1Longitude) return;
				SetAttributeValue("address1_longitude", doubleValue);  
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
		[DisplayName("Bill To ZIP/Postal Code")]
		[AttributeLogicalName("address1_postalcode")]
		public string BillToZIPPostalCode
		{	
			get { return GetAttributeValue<string>("address1_postalcode"); }
			set
			{ 
				if(value == BillToZIPPostalCode) return;
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
		[DisplayName("Bill To State/Province")]
		[AttributeLogicalName("address1_stateorprovince")]
		public string BillToStateProvince
		{	
			get { return GetAttributeValue<string>("address1_stateorprovince"); }
			set
			{ 
				if(value == BillToStateProvince) return;
				SetAttributeValue("address1_stateorprovince", value);
			}
		}	
			
		/// <summary>
        /// address1_telephone1
        /// </summary>
		[DisplayName("Main Phone")]
		[AttributeLogicalName("address1_telephone1")]
		public string MainPhone
		{	
			get { return GetAttributeValue<string>("address1_telephone1"); }
			set
			{ 
				if(value == MainPhone) return;
				SetAttributeValue("address1_telephone1", value);
			}
		}	
			
		/// <summary>
        /// address1_telephone2
        /// </summary>
		[DisplayName("Other Phone")]
		[AttributeLogicalName("address1_telephone2")]
		public string OtherPhone
		{	
			get { return GetAttributeValue<string>("address1_telephone2"); }
			set
			{ 
				if(value == OtherPhone) return;
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
		[DisplayName("Ship To City")]
		[AttributeLogicalName("address2_city")]
		public string ShipToCity
		{	
			get { return GetAttributeValue<string>("address2_city"); }
			set
			{ 
				if(value == ShipToCity) return;
				SetAttributeValue("address2_city", value);
			}
		}	
			
		/// <summary>
        /// address2_country
        /// </summary>
		[DisplayName("Ship To Country/Region")]
		[AttributeLogicalName("address2_country")]
		public string ShipToCountryRegion
		{	
			get { return GetAttributeValue<string>("address2_country"); }
			set
			{ 
				if(value == ShipToCountryRegion) return;
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
		///
		/// Precision: 5
		/// MaxValue: 90
		/// MinValue: -90
        /// </summary>
		[DisplayName("Address 2: Latitude")]
		[AttributeLogicalName("address2_latitude")]
		public double? Address2Latitude
		{	
			get { return GetAttributeValue<double?>("address2_latitude"); }
			set 
			{
				double? doubleValue = null;
				if(value != null) doubleValue = Math.Round(value.Value, 5);
				if(doubleValue == Address2Latitude) return;
				SetAttributeValue("address2_latitude", doubleValue);  
			}
		}

		/// <summary>
        /// address2_line1
        /// </summary>
		[DisplayName("Ship To Street 1")]
		[AttributeLogicalName("address2_line1")]
		public string ShipToStreet1
		{	
			get { return GetAttributeValue<string>("address2_line1"); }
			set
			{ 
				if(value == ShipToStreet1) return;
				SetAttributeValue("address2_line1", value);
			}
		}	
			
		/// <summary>
        /// address2_line2
        /// </summary>
		[DisplayName("Ship To Street 2")]
		[AttributeLogicalName("address2_line2")]
		public string ShipToStreet2
		{	
			get { return GetAttributeValue<string>("address2_line2"); }
			set
			{ 
				if(value == ShipToStreet2) return;
				SetAttributeValue("address2_line2", value);
			}
		}	
			
		/// <summary>
        /// address2_line3
        /// </summary>
		[DisplayName("Ship To Street 3")]
		[AttributeLogicalName("address2_line3")]
		public string ShipToStreet3
		{	
			get { return GetAttributeValue<string>("address2_line3"); }
			set
			{ 
				if(value == ShipToStreet3) return;
				SetAttributeValue("address2_line3", value);
			}
		}	
			
		/// <summary>
        /// address2_longitude
		///
		/// Precision: 5
		/// MaxValue: 180
		/// MinValue: -180
        /// </summary>
		[DisplayName("Address 2: Longitude")]
		[AttributeLogicalName("address2_longitude")]
		public double? Address2Longitude
		{	
			get { return GetAttributeValue<double?>("address2_longitude"); }
			set 
			{
				double? doubleValue = null;
				if(value != null) doubleValue = Math.Round(value.Value, 5);
				if(doubleValue == Address2Longitude) return;
				SetAttributeValue("address2_longitude", doubleValue);  
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
		[DisplayName("Ship To ZIP/Postal Code")]
		[AttributeLogicalName("address2_postalcode")]
		public string ShipToZIPPostalCode
		{	
			get { return GetAttributeValue<string>("address2_postalcode"); }
			set
			{ 
				if(value == ShipToZIPPostalCode) return;
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
		[DisplayName("Ship To State/Province")]
		[AttributeLogicalName("address2_stateorprovince")]
		public string ShipToStateProvince
		{	
			get { return GetAttributeValue<string>("address2_stateorprovince"); }
			set
			{ 
				if(value == ShipToStateProvince) return;
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
        /// businessunitid
        /// </summary>
		[DisplayName("Business Unit")]
		[AttributeLogicalName("businessunitid")]
		public override Guid Id
		{
			get => base.Id;
			set { base.Id = value; SetAttributeValue("businessunitid", value); }
		}

							/// <summary>
        /// calendarid
        /// </summary>
		[DisplayName("Calendar")]
		[AttributeLogicalName("calendarid")]
		public EntityReference Calendar
		{	
			get { return GetAttributeValue<EntityReference>("calendarid"); }
			set
			{ 
				if(value == Calendar) return;
				SetAttributeValue("calendarid", value);
			}
		}	
			
		/// <summary>
        /// costcenter
        /// </summary>
		[DisplayName("Cost Center")]
		[AttributeLogicalName("costcenter")]
		public string CostCenter
		{	
			get { return GetAttributeValue<string>("costcenter"); }
			set
			{ 
				if(value == CostCenter) return;
				SetAttributeValue("costcenter", value);
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
        /// creditlimit
		///
		/// Precision: 2
		/// MaxValue: 1000000000
		/// MinValue: 0
        /// </summary>
		[DisplayName("Credit Limit")]
		[AttributeLogicalName("creditlimit")]
		public double? CreditLimit
		{	
			get { return GetAttributeValue<double?>("creditlimit"); }
			set 
			{
				double? doubleValue = null;
				if(value != null) doubleValue = Math.Round(value.Value, 2);
				if(doubleValue == CreditLimit) return;
				SetAttributeValue("creditlimit", doubleValue);  
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
        /// disabledreason
        /// </summary>
		[DisplayName("Disable Reason")]
		[AttributeLogicalName("disabledreason")]
		public string DisableReason
		{	
			get { return GetAttributeValue<string>("disabledreason"); }
			set
			{ 
				if(value == DisableReason) return;
				SetAttributeValue("disabledreason", value);
			}
		}	
			
		/// <summary>
        /// divisionname
        /// </summary>
		[DisplayName("Division")]
		[AttributeLogicalName("divisionname")]
		public string Division
		{	
			get { return GetAttributeValue<string>("divisionname"); }
			set
			{ 
				if(value == Division) return;
				SetAttributeValue("divisionname", value);
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
        /// fileasname
        /// </summary>
		[DisplayName("File as Name")]
		[AttributeLogicalName("fileasname")]
		public string FileAsName
		{	
			get { return GetAttributeValue<string>("fileasname"); }
			set
			{ 
				if(value == FileAsName) return;
				SetAttributeValue("fileasname", value);
			}
		}	
			
		/// <summary>
        /// ftpsiteurl
        /// </summary>
		[DisplayName("FTP Site")]
		[AttributeLogicalName("ftpsiteurl")]
		public string FTPSite
		{	
			get { return GetAttributeValue<string>("ftpsiteurl"); }
			set
			{ 
				if(value == FTPSite) return;
				SetAttributeValue("ftpsiteurl", value);
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
        /// inheritancemask
        /// </summary>
		[DisplayName("Inheritance Mask")]
		[AttributeLogicalName("inheritancemask")]
		public int? InheritanceMask
		{	
			get { return GetAttributeValue<int?>("inheritancemask"); }
			set
			{ 
				if(value == InheritanceMask) return;
				SetAttributeValue("inheritancemask", value);
			}
		}	
			
		/// <summary>
        /// isdisabled
        /// </summary>
		[DisplayName("Is Disabled")]
		[AttributeLogicalName("isdisabled")]
		public bool? IsDisabled
		{	
			get { return GetAttributeValue<bool?>("isdisabled"); }
			set
			{ 
				if(value == IsDisabled) return;
				SetAttributeValue("isdisabled", value);
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
        /// parentbusinessunitid
        /// </summary>
		[DisplayName("Parent Business")]
		[AttributeLogicalName("parentbusinessunitid")]
		public EntityReference ParentBusiness
		{	
			get { return GetAttributeValue<EntityReference>("parentbusinessunitid"); }
			set
			{ 
				if(value == ParentBusiness) return;
				SetAttributeValue("parentbusinessunitid", value);
			}
		}	
			
		/// <summary>
        /// parentbusinessunitidname
        /// </summary>
		[DisplayName("parentbusinessunitidname")]
		[AttributeLogicalName("parentbusinessunitidname")]
		public string Parentbusinessunitidname
		{	
			get { return GetAttributeValue<string>("parentbusinessunitidname"); }
			set
			{ 
				if(value == Parentbusinessunitidname) return;
				SetAttributeValue("parentbusinessunitidname", value);
			}
		}	
			
		/// <summary>
        /// picture
        /// </summary>
		[DisplayName("Picture")]
		[AttributeLogicalName("picture")]
		public string Picture
		{	
			get { return GetAttributeValue<string>("picture"); }
			set
			{ 
				if(value == Picture) return;
				SetAttributeValue("picture", value);
			}
		}	
			
		/// <summary>
        /// stockexchange
        /// </summary>
		[DisplayName("Stock Exchange")]
		[AttributeLogicalName("stockexchange")]
		public string StockExchange
		{	
			get { return GetAttributeValue<string>("stockexchange"); }
			set
			{ 
				if(value == StockExchange) return;
				SetAttributeValue("stockexchange", value);
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
			set
			{ 
				if(value == TickerSymbol) return;
				SetAttributeValue("tickersymbol", value);
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
        /// usergroupid
        /// </summary>
		[DisplayName("usergroupid")]
		[AttributeLogicalName("usergroupid")]
		public Guid UsergroupId
		{	
			get { return GetAttributeValue<Guid>("usergroupid"); }
			set
			{ 
				if(value == UsergroupId) return;
				SetAttributeValue("usergroupid", value);
			}
		}	
			
		/// <summary>
        /// utcoffset
        /// </summary>
		[DisplayName("UTC Offset")]
		[AttributeLogicalName("utcoffset")]
		public int? UTCOffset
		{	
			get { return GetAttributeValue<int?>("utcoffset"); }
			set
			{ 
				if(value == UTCOffset) return;
				SetAttributeValue("utcoffset", value);
			}
		}	
			
		/// <summary>
        /// versionnumber
        /// </summary>
		[DisplayName("Version number")]
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
        /// workflowsuspended
        /// </summary>
		[DisplayName("Workflow Suspended")]
		[AttributeLogicalName("workflowsuspended")]
		public bool? WorkflowSuspended
		{	
			get { return GetAttributeValue<bool?>("workflowsuspended"); }
			set
			{ 
				if(value == WorkflowSuspended) return;
				SetAttributeValue("workflowsuspended", value);
			}
		}	
			
		#endregion	

		#region Relations
			/// <summary>
        /// 1:N Get entities for 'BulkDeleteOperation_BusinessUnit'
        /// </summary>
		[RelationshipSchemaName("BulkDeleteOperation_BusinessUnit")]
		public IEnumerable<BulkDeleteOperation> BulkDeleteOperationBusinessUnit
		{
			get { return GetRelatedEntities<BulkDeleteOperation>("BulkDeleteOperation_BusinessUnit", null); }
			set { SetRelatedEntities("BulkDeleteOperation_BusinessUnit", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'business_unit_accounts'
        /// </summary>
		[RelationshipSchemaName("business_unit_accounts")]
		public IEnumerable<Account> BusinessUnitAccounts
		{
			get { return GetRelatedEntities<Account>("business_unit_accounts", null); }
			set { SetRelatedEntities("business_unit_accounts", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'business_unit_actioncards'
        /// </summary>
		[RelationshipSchemaName("business_unit_actioncards")]
		public IEnumerable<ActionCard> BusinessUnitActioncards
		{
			get { return GetRelatedEntities<ActionCard>("business_unit_actioncards", null); }
			set { SetRelatedEntities("business_unit_actioncards", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'business_unit_activitymonitor'
        /// </summary>
		[RelationshipSchemaName("business_unit_activitymonitor")]
		public IEnumerable<ActivityMonitor> BusinessUnitActivitymonitor
		{
			get { return GetRelatedEntities<ActivityMonitor>("business_unit_activitymonitor", null); }
			set { SetRelatedEntities("business_unit_activitymonitor", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'business_unit_activitypointer'
        /// </summary>
		[RelationshipSchemaName("business_unit_activitypointer")]
		public IEnumerable<Activity> BusinessUnitActivitypointer
		{
			get { return GetRelatedEntities<Activity>("business_unit_activitypointer", null); }
			set { SetRelatedEntities("business_unit_activitypointer", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'business_unit_adminsettingsentity'
        /// </summary>
		[RelationshipSchemaName("business_unit_adminsettingsentity")]
		public IEnumerable<AdminSettingsEntity> BusinessUnitAdminsettingsentity
		{
			get { return GetRelatedEntities<AdminSettingsEntity>("business_unit_adminsettingsentity", null); }
			set { SetRelatedEntities("business_unit_adminsettingsentity", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'business_unit_annotations'
        /// </summary>
		[RelationshipSchemaName("business_unit_annotations")]
		public IEnumerable<Note> BusinessUnitAnnotations
		{
			get { return GetRelatedEntities<Note>("business_unit_annotations", null); }
			set { SetRelatedEntities("business_unit_annotations", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'business_unit_appointment_activities'
        /// </summary>
		[RelationshipSchemaName("business_unit_appointment_activities")]
		public IEnumerable<Appointment> BusinessUnitAppointmentActivities
		{
			get { return GetRelatedEntities<Appointment>("business_unit_appointment_activities", null); }
			set { SetRelatedEntities("business_unit_appointment_activities", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'business_unit_asyncoperation'
        /// </summary>
		[RelationshipSchemaName("business_unit_asyncoperation")]
		public IEnumerable<SystemJob> BusinessUnitAsyncoperation
		{
			get { return GetRelatedEntities<SystemJob>("business_unit_asyncoperation", null); }
			set { SetRelatedEntities("business_unit_asyncoperation", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'business_unit_bookableresource'
        /// </summary>
		[RelationshipSchemaName("business_unit_bookableresource")]
		public IEnumerable<BookableResource> BusinessUnitBookableresource
		{
			get { return GetRelatedEntities<BookableResource>("business_unit_bookableresource", null); }
			set { SetRelatedEntities("business_unit_bookableresource", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'business_unit_bookableresourcebooking'
        /// </summary>
		[RelationshipSchemaName("business_unit_bookableresourcebooking")]
		public IEnumerable<BookableResourceBooking> BusinessUnitBookableresourcebooking
		{
			get { return GetRelatedEntities<BookableResourceBooking>("business_unit_bookableresourcebooking", null); }
			set { SetRelatedEntities("business_unit_bookableresourcebooking", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'business_unit_bookableresourcebookingheader'
        /// </summary>
		[RelationshipSchemaName("business_unit_bookableresourcebookingheader")]
		public IEnumerable<BookableResourceBookingHeader> BusinessUnitBookableresourcebookingheader
		{
			get { return GetRelatedEntities<BookableResourceBookingHeader>("business_unit_bookableresourcebookingheader", null); }
			set { SetRelatedEntities("business_unit_bookableresourcebookingheader", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'business_unit_bookableresourcecategory'
        /// </summary>
		[RelationshipSchemaName("business_unit_bookableresourcecategory")]
		public IEnumerable<BookableResourceCategory> BusinessUnitBookableresourcecategory
		{
			get { return GetRelatedEntities<BookableResourceCategory>("business_unit_bookableresourcecategory", null); }
			set { SetRelatedEntities("business_unit_bookableresourcecategory", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'business_unit_bookableresourcecategoryassn'
        /// </summary>
		[RelationshipSchemaName("business_unit_bookableresourcecategoryassn")]
		public IEnumerable<BookableResourceCategoryAssn> BusinessUnitBookableresourcecategoryassn
		{
			get { return GetRelatedEntities<BookableResourceCategoryAssn>("business_unit_bookableresourcecategoryassn", null); }
			set { SetRelatedEntities("business_unit_bookableresourcecategoryassn", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'business_unit_bookableresourcecharacteristic'
        /// </summary>
		[RelationshipSchemaName("business_unit_bookableresourcecharacteristic")]
		public IEnumerable<BookableResourceCharacteristic> BusinessUnitBookableresourcecharacteristic
		{
			get { return GetRelatedEntities<BookableResourceCharacteristic>("business_unit_bookableresourcecharacteristic", null); }
			set { SetRelatedEntities("business_unit_bookableresourcecharacteristic", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'business_unit_bookableresourcegroup'
        /// </summary>
		[RelationshipSchemaName("business_unit_bookableresourcegroup")]
		public IEnumerable<BookableResourceGroup> BusinessUnitBookableresourcegroup
		{
			get { return GetRelatedEntities<BookableResourceGroup>("business_unit_bookableresourcegroup", null); }
			set { SetRelatedEntities("business_unit_bookableresourcegroup", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'business_unit_bookingstatus'
        /// </summary>
		[RelationshipSchemaName("business_unit_bookingstatus")]
		public IEnumerable<BookingStatus> BusinessUnitBookingstatus
		{
			get { return GetRelatedEntities<BookingStatus>("business_unit_bookingstatus", null); }
			set { SetRelatedEntities("business_unit_bookingstatus", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'business_unit_bot'
        /// </summary>
		[RelationshipSchemaName("business_unit_bot")]
		public IEnumerable<Chatbot> BusinessUnitBot
		{
			get { return GetRelatedEntities<Chatbot>("business_unit_bot", null); }
			set { SetRelatedEntities("business_unit_bot", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'business_unit_botcomponent'
        /// </summary>
		[RelationshipSchemaName("business_unit_botcomponent")]
		public IEnumerable<ChatbotSubcomponent> BusinessUnitBotcomponent
		{
			get { return GetRelatedEntities<ChatbotSubcomponent>("business_unit_botcomponent", null); }
			set { SetRelatedEntities("business_unit_botcomponent", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'business_unit_BulkOperation_activities'
        /// </summary>
		[RelationshipSchemaName("business_unit_BulkOperation_activities")]
		public IEnumerable<QuickCampaign> BusinessUnitBulkOperationActivities
		{
			get { return GetRelatedEntities<QuickCampaign>("business_unit_BulkOperation_activities", null); }
			set { SetRelatedEntities("business_unit_BulkOperation_activities", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'business_unit_calendars'
        /// </summary>
		[RelationshipSchemaName("business_unit_calendars")]
		public IEnumerable<Calendar> BusinessUnitCalendars
		{
			get { return GetRelatedEntities<Calendar>("business_unit_calendars", null); }
			set { SetRelatedEntities("business_unit_calendars", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'business_unit_campaignactivity_activities'
        /// </summary>
		[RelationshipSchemaName("business_unit_campaignactivity_activities")]
		public IEnumerable<CampaignActivity> BusinessUnitCampaignactivityActivities
		{
			get { return GetRelatedEntities<CampaignActivity>("business_unit_campaignactivity_activities", null); }
			set { SetRelatedEntities("business_unit_campaignactivity_activities", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'business_unit_campaignresponse_activities'
        /// </summary>
		[RelationshipSchemaName("business_unit_campaignresponse_activities")]
		public IEnumerable<CampaignResponse> BusinessUnitCampaignresponseActivities
		{
			get { return GetRelatedEntities<CampaignResponse>("business_unit_campaignresponse_activities", null); }
			set { SetRelatedEntities("business_unit_campaignresponse_activities", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'business_unit_category'
        /// </summary>
		[RelationshipSchemaName("business_unit_category")]
		public IEnumerable<Category> BusinessUnitCategory
		{
			get { return GetRelatedEntities<Category>("business_unit_category", null); }
			set { SetRelatedEntities("business_unit_category", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'business_unit_characteristic'
        /// </summary>
		[RelationshipSchemaName("business_unit_characteristic")]
		public IEnumerable<Characteristic> BusinessUnitCharacteristic
		{
			get { return GetRelatedEntities<Characteristic>("business_unit_characteristic", null); }
			set { SetRelatedEntities("business_unit_characteristic", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'business_unit_connectionreference'
        /// </summary>
		[RelationshipSchemaName("business_unit_connectionreference")]
		public IEnumerable<ConnectionReference> BusinessUnitConnectionreference
		{
			get { return GetRelatedEntities<ConnectionReference>("business_unit_connectionreference", null); }
			set { SetRelatedEntities("business_unit_connectionreference", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'business_unit_connections'
        /// </summary>
		[RelationshipSchemaName("business_unit_connections")]
		public IEnumerable<Connection> BusinessUnitConnections
		{
			get { return GetRelatedEntities<Connection>("business_unit_connections", null); }
			set { SetRelatedEntities("business_unit_connections", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'business_unit_connector'
        /// </summary>
		[RelationshipSchemaName("business_unit_connector")]
		public IEnumerable<Connector> BusinessUnitConnector
		{
			get { return GetRelatedEntities<Connector>("business_unit_connector", null); }
			set { SetRelatedEntities("business_unit_connector", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'business_unit_constraint_based_groups'
        /// </summary>
		[RelationshipSchemaName("business_unit_constraint_based_groups")]
		public IEnumerable<ResourceGroup> BusinessUnitConstraintBasedGroups
		{
			get { return GetRelatedEntities<ResourceGroup>("business_unit_constraint_based_groups", null); }
			set { SetRelatedEntities("business_unit_constraint_based_groups", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'business_unit_contacts'
        /// </summary>
		[RelationshipSchemaName("business_unit_contacts")]
		public IEnumerable<Contact> BusinessUnitContacts
		{
			get { return GetRelatedEntities<Contact>("business_unit_contacts", null); }
			set { SetRelatedEntities("business_unit_contacts", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'business_unit_conversationtranscript'
        /// </summary>
		[RelationshipSchemaName("business_unit_conversationtranscript")]
		public IEnumerable<ConversationTranscript> BusinessUnitConversationtranscript
		{
			get { return GetRelatedEntities<ConversationTranscript>("business_unit_conversationtranscript", null); }
			set { SetRelatedEntities("business_unit_conversationtranscript", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'business_unit_customapi'
        /// </summary>
		[RelationshipSchemaName("business_unit_customapi")]
		public IEnumerable<CustomAPI> BusinessUnitCustomapi
		{
			get { return GetRelatedEntities<CustomAPI>("business_unit_customapi", null); }
			set { SetRelatedEntities("business_unit_customapi", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'business_unit_customapirequestparameter'
        /// </summary>
		[RelationshipSchemaName("business_unit_customapirequestparameter")]
		public IEnumerable<CustomAPIRequestParameter> BusinessUnitCustomapirequestparameter
		{
			get { return GetRelatedEntities<CustomAPIRequestParameter>("business_unit_customapirequestparameter", null); }
			set { SetRelatedEntities("business_unit_customapirequestparameter", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'business_unit_customapiresponseproperty'
        /// </summary>
		[RelationshipSchemaName("business_unit_customapiresponseproperty")]
		public IEnumerable<CustomAPIResponseProperty> BusinessUnitCustomapiresponseproperty
		{
			get { return GetRelatedEntities<CustomAPIResponseProperty>("business_unit_customapiresponseproperty", null); }
			set { SetRelatedEntities("business_unit_customapiresponseproperty", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'business_unit_datalakefolder'
        /// </summary>
		[RelationshipSchemaName("business_unit_datalakefolder")]
		public IEnumerable<DataLakeFolder> BusinessUnitDatalakefolder
		{
			get { return GetRelatedEntities<DataLakeFolder>("business_unit_datalakefolder", null); }
			set { SetRelatedEntities("business_unit_datalakefolder", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'business_unit_datalakefolderpermission'
        /// </summary>
		[RelationshipSchemaName("business_unit_datalakefolderpermission")]
		public IEnumerable<DataLakeFolderPermission> BusinessUnitDatalakefolderpermission
		{
			get { return GetRelatedEntities<DataLakeFolderPermission>("business_unit_datalakefolderpermission", null); }
			set { SetRelatedEntities("business_unit_datalakefolderpermission", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'business_unit_dynamicproperyinstance'
        /// </summary>
		[RelationshipSchemaName("business_unit_dynamicproperyinstance")]
		public IEnumerable<PropertyInstance> BusinessUnitDynamicproperyinstance
		{
			get { return GetRelatedEntities<PropertyInstance>("business_unit_dynamicproperyinstance", null); }
			set { SetRelatedEntities("business_unit_dynamicproperyinstance", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'business_unit_email_activities'
        /// </summary>
		[RelationshipSchemaName("business_unit_email_activities")]
		public IEnumerable<Email> BusinessUnitEmailActivities
		{
			get { return GetRelatedEntities<Email>("business_unit_email_activities", null); }
			set { SetRelatedEntities("business_unit_email_activities", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'business_unit_emailserverprofile'
        /// </summary>
		[RelationshipSchemaName("business_unit_emailserverprofile")]
		public IEnumerable<EmailServerProfile> BusinessUnitEmailserverprofile
		{
			get { return GetRelatedEntities<EmailServerProfile>("business_unit_emailserverprofile", null); }
			set { SetRelatedEntities("business_unit_emailserverprofile", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'business_unit_entitlement'
        /// </summary>
		[RelationshipSchemaName("business_unit_entitlement")]
		public IEnumerable<Entitlement> BusinessUnitEntitlement
		{
			get { return GetRelatedEntities<Entitlement>("business_unit_entitlement", null); }
			set { SetRelatedEntities("business_unit_entitlement", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'business_unit_entitlemententityallocationtypemapping'
        /// </summary>
		[RelationshipSchemaName("business_unit_entitlemententityallocationtypemapping")]
		public IEnumerable<EntitlementEntityAllocationTypeMapping> BusinessUnitEntitlemententityallocationtypemapping
		{
			get { return GetRelatedEntities<EntitlementEntityAllocationTypeMapping>("business_unit_entitlemententityallocationtypemapping", null); }
			set { SetRelatedEntities("business_unit_entitlemententityallocationtypemapping", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'business_unit_environmentvariabledefinition'
        /// </summary>
		[RelationshipSchemaName("business_unit_environmentvariabledefinition")]
		public IEnumerable<EnvironmentVariableDefinition> BusinessUnitEnvironmentvariabledefinition
		{
			get { return GetRelatedEntities<EnvironmentVariableDefinition>("business_unit_environmentvariabledefinition", null); }
			set { SetRelatedEntities("business_unit_environmentvariabledefinition", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'business_unit_environmentvariablevalue'
        /// </summary>
		[RelationshipSchemaName("business_unit_environmentvariablevalue")]
		public IEnumerable<EnvironmentVariableValue> BusinessUnitEnvironmentvariablevalue
		{
			get { return GetRelatedEntities<EnvironmentVariableValue>("business_unit_environmentvariablevalue", null); }
			set { SetRelatedEntities("business_unit_environmentvariablevalue", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'business_unit_equipment'
        /// </summary>
		[RelationshipSchemaName("business_unit_equipment")]
		public IEnumerable<FacilityEquipment> BusinessUnitEquipment
		{
			get { return GetRelatedEntities<FacilityEquipment>("business_unit_equipment", null); }
			set { SetRelatedEntities("business_unit_equipment", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'business_unit_exchangesyncidmapping'
        /// </summary>
		[RelationshipSchemaName("business_unit_exchangesyncidmapping")]
		public IEnumerable<ExchangeSyncIdMapping> BusinessUnitExchangesyncidmapping
		{
			get { return GetRelatedEntities<ExchangeSyncIdMapping>("business_unit_exchangesyncidmapping", null); }
			set { SetRelatedEntities("business_unit_exchangesyncidmapping", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'business_unit_exportsolutionupload'
        /// </summary>
		[RelationshipSchemaName("business_unit_exportsolutionupload")]
		public IEnumerable<ExportSolutionUpload> BusinessUnitExportsolutionupload
		{
			get { return GetRelatedEntities<ExportSolutionUpload>("business_unit_exportsolutionupload", null); }
			set { SetRelatedEntities("business_unit_exportsolutionupload", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'business_unit_fax_activities'
        /// </summary>
		[RelationshipSchemaName("business_unit_fax_activities")]
		public IEnumerable<Fax> BusinessUnitFaxActivities
		{
			get { return GetRelatedEntities<Fax>("business_unit_fax_activities", null); }
			set { SetRelatedEntities("business_unit_fax_activities", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'business_unit_feedback'
        /// </summary>
		[RelationshipSchemaName("business_unit_feedback")]
		public IEnumerable<Feedback> BusinessUnitFeedback
		{
			get { return GetRelatedEntities<Feedback>("business_unit_feedback", null); }
			set { SetRelatedEntities("business_unit_feedback", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'business_unit_flowsession'
        /// </summary>
		[RelationshipSchemaName("business_unit_flowsession")]
		public IEnumerable<FlowSession> BusinessUnitFlowsession
		{
			get { return GetRelatedEntities<FlowSession>("business_unit_flowsession", null); }
			set { SetRelatedEntities("business_unit_flowsession", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'business_unit_goal'
        /// </summary>
		[RelationshipSchemaName("business_unit_goal")]
		public IEnumerable<Goal> BusinessUnitGoal
		{
			get { return GetRelatedEntities<Goal>("business_unit_goal", null); }
			set { SetRelatedEntities("business_unit_goal", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'business_unit_goalrollupquery'
        /// </summary>
		[RelationshipSchemaName("business_unit_goalrollupquery")]
		public IEnumerable<RollupQuery> BusinessUnitGoalrollupquery
		{
			get { return GetRelatedEntities<RollupQuery>("business_unit_goalrollupquery", null); }
			set { SetRelatedEntities("business_unit_goalrollupquery", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'business_unit_incident_resolution_activities'
        /// </summary>
		[RelationshipSchemaName("business_unit_incident_resolution_activities")]
		public IEnumerable<CaseResolution> BusinessUnitIncidentResolutionActivities
		{
			get { return GetRelatedEntities<CaseResolution>("business_unit_incident_resolution_activities", null); }
			set { SetRelatedEntities("business_unit_incident_resolution_activities", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'business_unit_incidents'
        /// </summary>
		[RelationshipSchemaName("business_unit_incidents")]
		public IEnumerable<Case> BusinessUnitIncidents
		{
			get { return GetRelatedEntities<Case>("business_unit_incidents", null); }
			set { SetRelatedEntities("business_unit_incidents", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'business_unit_interactionforemail'
        /// </summary>
		[RelationshipSchemaName("business_unit_interactionforemail")]
		public IEnumerable<InteractionForEmail> BusinessUnitInteractionforemail
		{
			get { return GetRelatedEntities<InteractionForEmail>("business_unit_interactionforemail", null); }
			set { SetRelatedEntities("business_unit_interactionforemail", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'business_unit_invoices'
        /// </summary>
		[RelationshipSchemaName("business_unit_invoices")]
		public IEnumerable<Invoice> BusinessUnitInvoices
		{
			get { return GetRelatedEntities<Invoice>("business_unit_invoices", null); }
			set { SetRelatedEntities("business_unit_invoices", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'business_unit_knowledgearticle'
        /// </summary>
		[RelationshipSchemaName("business_unit_knowledgearticle")]
		public IEnumerable<KnowledgeArticle> BusinessUnitKnowledgearticle
		{
			get { return GetRelatedEntities<KnowledgeArticle>("business_unit_knowledgearticle", null); }
			set { SetRelatedEntities("business_unit_knowledgearticle", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'business_unit_leads'
        /// </summary>
		[RelationshipSchemaName("business_unit_leads")]
		public IEnumerable<Lead> BusinessUnitLeads
		{
			get { return GetRelatedEntities<Lead>("business_unit_leads", null); }
			set { SetRelatedEntities("business_unit_leads", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'business_unit_letter_activities'
        /// </summary>
		[RelationshipSchemaName("business_unit_letter_activities")]
		public IEnumerable<Letter> BusinessUnitLetterActivities
		{
			get { return GetRelatedEntities<Letter>("business_unit_letter_activities", null); }
			set { SetRelatedEntities("business_unit_letter_activities", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'business_unit_list'
        /// </summary>
		[RelationshipSchemaName("business_unit_list")]
		public IEnumerable<MarketingList> BusinessUnitList
		{
			get { return GetRelatedEntities<MarketingList>("business_unit_list", null); }
			set { SetRelatedEntities("business_unit_list", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'business_unit_listoperation'
        /// </summary>
		[RelationshipSchemaName("business_unit_listoperation")]
		public IEnumerable<ListOperation> BusinessUnitListoperation
		{
			get { return GetRelatedEntities<ListOperation>("business_unit_listoperation", null); }
			set { SetRelatedEntities("business_unit_listoperation", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'business_unit_mailbox'
        /// </summary>
		[RelationshipSchemaName("business_unit_mailbox")]
		public IEnumerable<Mailbox> BusinessUnitMailbox
		{
			get { return GetRelatedEntities<Mailbox>("business_unit_mailbox", null); }
			set { SetRelatedEntities("business_unit_mailbox", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'business_unit_mailmergetemplates'
        /// </summary>
		[RelationshipSchemaName("business_unit_mailmergetemplates")]
		public IEnumerable<MailMergeTemplate> BusinessUnitMailmergetemplates
		{
			get { return GetRelatedEntities<MailMergeTemplate>("business_unit_mailmergetemplates", null); }
			set { SetRelatedEntities("business_unit_mailmergetemplates", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'business_unit_msdyn_actioncardregarding'
        /// </summary>
		[RelationshipSchemaName("business_unit_msdyn_actioncardregarding")]
		public IEnumerable<ActionCardRegarding> BusinessUnitMsdynActioncardregarding
		{
			get { return GetRelatedEntities<ActionCardRegarding>("business_unit_msdyn_actioncardregarding", null); }
			set { SetRelatedEntities("business_unit_msdyn_actioncardregarding", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'business_unit_msdyn_actioncardrolesetting'
        /// </summary>
		[RelationshipSchemaName("business_unit_msdyn_actioncardrolesetting")]
		public IEnumerable<ActionCardRoleSetting> BusinessUnitMsdynActioncardrolesetting
		{
			get { return GetRelatedEntities<ActionCardRoleSetting>("business_unit_msdyn_actioncardrolesetting", null); }
			set { SetRelatedEntities("business_unit_msdyn_actioncardrolesetting", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'business_unit_msdyn_aibdataset'
        /// </summary>
		[RelationshipSchemaName("business_unit_msdyn_aibdataset")]
		public IEnumerable<AIBuilderDataset> BusinessUnitMsdynAibdataset
		{
			get { return GetRelatedEntities<AIBuilderDataset>("business_unit_msdyn_aibdataset", null); }
			set { SetRelatedEntities("business_unit_msdyn_aibdataset", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'business_unit_msdyn_aibdatasetfile'
        /// </summary>
		[RelationshipSchemaName("business_unit_msdyn_aibdatasetfile")]
		public IEnumerable<AIBuilderDatasetFile> BusinessUnitMsdynAibdatasetfile
		{
			get { return GetRelatedEntities<AIBuilderDatasetFile>("business_unit_msdyn_aibdatasetfile", null); }
			set { SetRelatedEntities("business_unit_msdyn_aibdatasetfile", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'business_unit_msdyn_aibdatasetrecord'
        /// </summary>
		[RelationshipSchemaName("business_unit_msdyn_aibdatasetrecord")]
		public IEnumerable<AIBuilderDatasetRecord> BusinessUnitMsdynAibdatasetrecord
		{
			get { return GetRelatedEntities<AIBuilderDatasetRecord>("business_unit_msdyn_aibdatasetrecord", null); }
			set { SetRelatedEntities("business_unit_msdyn_aibdatasetrecord", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'business_unit_msdyn_aibdatasetscontainer'
        /// </summary>
		[RelationshipSchemaName("business_unit_msdyn_aibdatasetscontainer")]
		public IEnumerable<AIBuilderDatasetsContainer> BusinessUnitMsdynAibdatasetscontainer
		{
			get { return GetRelatedEntities<AIBuilderDatasetsContainer>("business_unit_msdyn_aibdatasetscontainer", null); }
			set { SetRelatedEntities("business_unit_msdyn_aibdatasetscontainer", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'business_unit_msdyn_aibfile'
        /// </summary>
		[RelationshipSchemaName("business_unit_msdyn_aibfile")]
		public IEnumerable<AIBuilderFile> BusinessUnitMsdynAibfile
		{
			get { return GetRelatedEntities<AIBuilderFile>("business_unit_msdyn_aibfile", null); }
			set { SetRelatedEntities("business_unit_msdyn_aibfile", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'business_unit_msdyn_aibfileattacheddata'
        /// </summary>
		[RelationshipSchemaName("business_unit_msdyn_aibfileattacheddata")]
		public IEnumerable<AIBuilderFileAttachedData> BusinessUnitMsdynAibfileattacheddata
		{
			get { return GetRelatedEntities<AIBuilderFileAttachedData>("business_unit_msdyn_aibfileattacheddata", null); }
			set { SetRelatedEntities("business_unit_msdyn_aibfileattacheddata", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'business_unit_msdyn_aiconfiguration'
        /// </summary>
		[RelationshipSchemaName("business_unit_msdyn_aiconfiguration")]
		public IEnumerable<AIConfiguration> BusinessUnitMsdynAiconfiguration
		{
			get { return GetRelatedEntities<AIConfiguration>("business_unit_msdyn_aiconfiguration", null); }
			set { SetRelatedEntities("business_unit_msdyn_aiconfiguration", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'business_unit_msdyn_aifptrainingdocument'
        /// </summary>
		[RelationshipSchemaName("business_unit_msdyn_aifptrainingdocument")]
		public IEnumerable<AIFormProcessingDocument> BusinessUnitMsdynAifptrainingdocument
		{
			get { return GetRelatedEntities<AIFormProcessingDocument>("business_unit_msdyn_aifptrainingdocument", null); }
			set { SetRelatedEntities("business_unit_msdyn_aifptrainingdocument", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'business_unit_msdyn_aimodel'
        /// </summary>
		[RelationshipSchemaName("business_unit_msdyn_aimodel")]
		public IEnumerable<AIModel> BusinessUnitMsdynAimodel
		{
			get { return GetRelatedEntities<AIModel>("business_unit_msdyn_aimodel", null); }
			set { SetRelatedEntities("business_unit_msdyn_aimodel", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'business_unit_msdyn_aiodimage'
        /// </summary>
		[RelationshipSchemaName("business_unit_msdyn_aiodimage")]
		public IEnumerable<AIObjectDetectionImage> BusinessUnitMsdynAiodimage
		{
			get { return GetRelatedEntities<AIObjectDetectionImage>("business_unit_msdyn_aiodimage", null); }
			set { SetRelatedEntities("business_unit_msdyn_aiodimage", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'business_unit_msdyn_aiodlabel'
        /// </summary>
		[RelationshipSchemaName("business_unit_msdyn_aiodlabel")]
		public IEnumerable<AIObjectDetectionLabel> BusinessUnitMsdynAiodlabel
		{
			get { return GetRelatedEntities<AIObjectDetectionLabel>("business_unit_msdyn_aiodlabel", null); }
			set { SetRelatedEntities("business_unit_msdyn_aiodlabel", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'business_unit_msdyn_aiodtrainingboundingbox'
        /// </summary>
		[RelationshipSchemaName("business_unit_msdyn_aiodtrainingboundingbox")]
		public IEnumerable<AIObjectDetectionBoundingBox> BusinessUnitMsdynAiodtrainingboundingbox
		{
			get { return GetRelatedEntities<AIObjectDetectionBoundingBox>("business_unit_msdyn_aiodtrainingboundingbox", null); }
			set { SetRelatedEntities("business_unit_msdyn_aiodtrainingboundingbox", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'business_unit_msdyn_aiodtrainingimage'
        /// </summary>
		[RelationshipSchemaName("business_unit_msdyn_aiodtrainingimage")]
		public IEnumerable<AIObjectDetectionImageMapping> BusinessUnitMsdynAiodtrainingimage
		{
			get { return GetRelatedEntities<AIObjectDetectionImageMapping>("business_unit_msdyn_aiodtrainingimage", null); }
			set { SetRelatedEntities("business_unit_msdyn_aiodtrainingimage", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'business_unit_msdyn_aitemplate'
        /// </summary>
		[RelationshipSchemaName("business_unit_msdyn_aitemplate")]
		public IEnumerable<AITemplate> BusinessUnitMsdynAitemplate
		{
			get { return GetRelatedEntities<AITemplate>("business_unit_msdyn_aitemplate", null); }
			set { SetRelatedEntities("business_unit_msdyn_aitemplate", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'business_unit_msdyn_autocapturerule'
        /// </summary>
		[RelationshipSchemaName("business_unit_msdyn_autocapturerule")]
		public IEnumerable<AutoCaptureRule> BusinessUnitMsdynAutocapturerule
		{
			get { return GetRelatedEntities<AutoCaptureRule>("business_unit_msdyn_autocapturerule", null); }
			set { SetRelatedEntities("business_unit_msdyn_autocapturerule", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'business_unit_msdyn_autocapturesettings'
        /// </summary>
		[RelationshipSchemaName("business_unit_msdyn_autocapturesettings")]
		public IEnumerable<AutoCaptureSettings> BusinessUnitMsdynAutocapturesettings
		{
			get { return GetRelatedEntities<AutoCaptureSettings>("business_unit_msdyn_autocapturesettings", null); }
			set { SetRelatedEntities("business_unit_msdyn_autocapturesettings", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'business_unit_msdyn_callablecontext'
        /// </summary>
		[RelationshipSchemaName("business_unit_msdyn_callablecontext")]
		public IEnumerable<PlaybookCallableContext> BusinessUnitMsdynCallablecontext
		{
			get { return GetRelatedEntities<PlaybookCallableContext>("business_unit_msdyn_callablecontext", null); }
			set { SetRelatedEntities("business_unit_msdyn_callablecontext", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'business_unit_msdyn_entityrankingrule'
        /// </summary>
		[RelationshipSchemaName("business_unit_msdyn_entityrankingrule")]
		public IEnumerable<EntityRankingRule> BusinessUnitMsdynEntityrankingrule
		{
			get { return GetRelatedEntities<EntityRankingRule>("business_unit_msdyn_entityrankingrule", null); }
			set { SetRelatedEntities("business_unit_msdyn_entityrankingrule", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'business_unit_msdyn_federatedarticle'
        /// </summary>
		[RelationshipSchemaName("business_unit_msdyn_federatedarticle")]
		public IEnumerable<KnowledgeFederatedArticle> BusinessUnitMsdynFederatedarticle
		{
			get { return GetRelatedEntities<KnowledgeFederatedArticle>("business_unit_msdyn_federatedarticle", null); }
			set { SetRelatedEntities("business_unit_msdyn_federatedarticle", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'business_unit_msdyn_flowcardtype'
        /// </summary>
		[RelationshipSchemaName("business_unit_msdyn_flowcardtype")]
		public IEnumerable<Flowcardtype> BusinessUnitMsdynFlowcardtype
		{
			get { return GetRelatedEntities<Flowcardtype>("business_unit_msdyn_flowcardtype", null); }
			set { SetRelatedEntities("business_unit_msdyn_flowcardtype", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'business_unit_msdyn_icebreakersconfig'
        /// </summary>
		[RelationshipSchemaName("business_unit_msdyn_icebreakersconfig")]
		public IEnumerable<Icebreakersconfig> BusinessUnitMsdynIcebreakersconfig
		{
			get { return GetRelatedEntities<Icebreakersconfig>("business_unit_msdyn_icebreakersconfig", null); }
			set { SetRelatedEntities("business_unit_msdyn_icebreakersconfig", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'business_unit_msdyn_kmfederatedsearchconfig'
        /// </summary>
		[RelationshipSchemaName("business_unit_msdyn_kmfederatedsearchconfig")]
		public IEnumerable<SearchProvider> BusinessUnitMsdynKmfederatedsearchconfig
		{
			get { return GetRelatedEntities<SearchProvider>("business_unit_msdyn_kmfederatedsearchconfig", null); }
			set { SetRelatedEntities("business_unit_msdyn_kmfederatedsearchconfig", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'business_unit_msdyn_knowledgearticleimage'
        /// </summary>
		[RelationshipSchemaName("business_unit_msdyn_knowledgearticleimage")]
		public IEnumerable<KnowledgeArticleImage> BusinessUnitMsdynKnowledgearticleimage
		{
			get { return GetRelatedEntities<KnowledgeArticleImage>("business_unit_msdyn_knowledgearticleimage", null); }
			set { SetRelatedEntities("business_unit_msdyn_knowledgearticleimage", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'business_unit_msdyn_knowledgearticletemplate'
        /// </summary>
		[RelationshipSchemaName("business_unit_msdyn_knowledgearticletemplate")]
		public IEnumerable<KnowledgeArticleTemplate> BusinessUnitMsdynKnowledgearticletemplate
		{
			get { return GetRelatedEntities<KnowledgeArticleTemplate>("business_unit_msdyn_knowledgearticletemplate", null); }
			set { SetRelatedEntities("business_unit_msdyn_knowledgearticletemplate", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'business_unit_msdyn_knowledgeinteractioninsight'
        /// </summary>
		[RelationshipSchemaName("business_unit_msdyn_knowledgeinteractioninsight")]
		public IEnumerable<KnowledgeInteractionInsight> BusinessUnitMsdynKnowledgeinteractioninsight
		{
			get { return GetRelatedEntities<KnowledgeInteractionInsight>("business_unit_msdyn_knowledgeinteractioninsight", null); }
			set { SetRelatedEntities("business_unit_msdyn_knowledgeinteractioninsight", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'business_unit_msdyn_knowledgesearchinsight'
        /// </summary>
		[RelationshipSchemaName("business_unit_msdyn_knowledgesearchinsight")]
		public IEnumerable<KnowledgeSearchInsight> BusinessUnitMsdynKnowledgesearchinsight
		{
			get { return GetRelatedEntities<KnowledgeSearchInsight>("business_unit_msdyn_knowledgesearchinsight", null); }
			set { SetRelatedEntities("business_unit_msdyn_knowledgesearchinsight", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'business_unit_msdyn_msteamssetting'
        /// </summary>
		[RelationshipSchemaName("business_unit_msdyn_msteamssetting")]
		public IEnumerable<MsdynMsteamssetting> BusinessUnitMsdynMsteamssetting
		{
			get { return GetRelatedEntities<MsdynMsteamssetting>("business_unit_msdyn_msteamssetting", null); }
			set { SetRelatedEntities("business_unit_msdyn_msteamssetting", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'business_unit_msdyn_notesanalysisconfig'
        /// </summary>
		[RelationshipSchemaName("business_unit_msdyn_notesanalysisconfig")]
		public IEnumerable<NotesAnalysisConfig> BusinessUnitMsdynNotesanalysisconfig
		{
			get { return GetRelatedEntities<NotesAnalysisConfig>("business_unit_msdyn_notesanalysisconfig", null); }
			set { SetRelatedEntities("business_unit_msdyn_notesanalysisconfig", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'business_unit_msdyn_playbookactivity'
        /// </summary>
		[RelationshipSchemaName("business_unit_msdyn_playbookactivity")]
		public IEnumerable<PlaybookActivity> BusinessUnitMsdynPlaybookactivity
		{
			get { return GetRelatedEntities<PlaybookActivity>("business_unit_msdyn_playbookactivity", null); }
			set { SetRelatedEntities("business_unit_msdyn_playbookactivity", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'business_unit_msdyn_playbookactivityattribute'
        /// </summary>
		[RelationshipSchemaName("business_unit_msdyn_playbookactivityattribute")]
		public IEnumerable<PlaybookActivityAttribute> BusinessUnitMsdynPlaybookactivityattribute
		{
			get { return GetRelatedEntities<PlaybookActivityAttribute>("business_unit_msdyn_playbookactivityattribute", null); }
			set { SetRelatedEntities("business_unit_msdyn_playbookactivityattribute", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'business_unit_msdyn_playbookcategory'
        /// </summary>
		[RelationshipSchemaName("business_unit_msdyn_playbookcategory")]
		public IEnumerable<PlaybookCategory> BusinessUnitMsdynPlaybookcategory
		{
			get { return GetRelatedEntities<PlaybookCategory>("business_unit_msdyn_playbookcategory", null); }
			set { SetRelatedEntities("business_unit_msdyn_playbookcategory", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'business_unit_msdyn_playbookinstance'
        /// </summary>
		[RelationshipSchemaName("business_unit_msdyn_playbookinstance")]
		public IEnumerable<Playbook> BusinessUnitMsdynPlaybookinstance
		{
			get { return GetRelatedEntities<Playbook>("business_unit_msdyn_playbookinstance", null); }
			set { SetRelatedEntities("business_unit_msdyn_playbookinstance", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'business_unit_msdyn_playbooktemplate'
        /// </summary>
		[RelationshipSchemaName("business_unit_msdyn_playbooktemplate")]
		public IEnumerable<PlaybookTemplate> BusinessUnitMsdynPlaybooktemplate
		{
			get { return GetRelatedEntities<PlaybookTemplate>("business_unit_msdyn_playbooktemplate", null); }
			set { SetRelatedEntities("business_unit_msdyn_playbooktemplate", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'business_unit_msdyn_postalbum'
        /// </summary>
		[RelationshipSchemaName("business_unit_msdyn_postalbum")]
		public IEnumerable<ProfileAlbum> BusinessUnitMsdynPostalbum
		{
			get { return GetRelatedEntities<ProfileAlbum>("business_unit_msdyn_postalbum", null); }
			set { SetRelatedEntities("business_unit_msdyn_postalbum", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'business_unit_msdyn_relationshipinsightsunifiedconfig'
        /// </summary>
		[RelationshipSchemaName("business_unit_msdyn_relationshipinsightsunifiedconfig")]
		public IEnumerable<MsdynRelationshipinsightsunifiedconfig> BusinessUnitMsdynRelationshipinsightsunifiedconfig
		{
			get { return GetRelatedEntities<MsdynRelationshipinsightsunifiedconfig>("business_unit_msdyn_relationshipinsightsunifiedconfig", null); }
			set { SetRelatedEntities("business_unit_msdyn_relationshipinsightsunifiedconfig", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'business_unit_msdyn_richtextfile'
        /// </summary>
		[RelationshipSchemaName("business_unit_msdyn_richtextfile")]
		public IEnumerable<RichTextAttachment> BusinessUnitMsdynRichtextfile
		{
			get { return GetRelatedEntities<RichTextAttachment>("business_unit_msdyn_richtextfile", null); }
			set { SetRelatedEntities("business_unit_msdyn_richtextfile", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'business_unit_msdyn_salesinsightssettings'
        /// </summary>
		[RelationshipSchemaName("business_unit_msdyn_salesinsightssettings")]
		public IEnumerable<Salesinsightssettings> BusinessUnitMsdynSalesinsightssettings
		{
			get { return GetRelatedEntities<Salesinsightssettings>("business_unit_msdyn_salesinsightssettings", null); }
			set { SetRelatedEntities("business_unit_msdyn_salesinsightssettings", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'business_unit_msdyn_siconfig'
        /// </summary>
		[RelationshipSchemaName("business_unit_msdyn_siconfig")]
		public IEnumerable<Siconfig> BusinessUnitMsdynSiconfig
		{
			get { return GetRelatedEntities<Siconfig>("business_unit_msdyn_siconfig", null); }
			set { SetRelatedEntities("business_unit_msdyn_siconfig", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'business_unit_msdyn_untrackedappointment'
        /// </summary>
		[RelationshipSchemaName("business_unit_msdyn_untrackedappointment")]
		public IEnumerable<UntrackedAppointment> BusinessUnitMsdynUntrackedappointment
		{
			get { return GetRelatedEntities<UntrackedAppointment>("business_unit_msdyn_untrackedappointment", null); }
			set { SetRelatedEntities("business_unit_msdyn_untrackedappointment", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'business_unit_msdyn_wallsavedqueryusersettings'
        /// </summary>
		[RelationshipSchemaName("business_unit_msdyn_wallsavedqueryusersettings")]
		public IEnumerable<Filter> BusinessUnitMsdynWallsavedqueryusersettings
		{
			get { return GetRelatedEntities<Filter>("business_unit_msdyn_wallsavedqueryusersettings", null); }
			set { SetRelatedEntities("business_unit_msdyn_wallsavedqueryusersettings", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'business_unit_msdynce_botcontent'
        /// </summary>
		[RelationshipSchemaName("business_unit_msdynce_botcontent")]
		public IEnumerable<BotContent> BusinessUnitMsdynceBotcontent
		{
			get { return GetRelatedEntities<BotContent>("business_unit_msdynce_botcontent", null); }
			set { SetRelatedEntities("business_unit_msdynce_botcontent", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'business_unit_opportunities'
        /// </summary>
		[RelationshipSchemaName("business_unit_opportunities")]
		public IEnumerable<Opportunity> BusinessUnitOpportunities
		{
			get { return GetRelatedEntities<Opportunity>("business_unit_opportunities", null); }
			set { SetRelatedEntities("business_unit_opportunities", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'business_unit_opportunity_close_activities'
        /// </summary>
		[RelationshipSchemaName("business_unit_opportunity_close_activities")]
		public IEnumerable<OpportunityClose> BusinessUnitOpportunityCloseActivities
		{
			get { return GetRelatedEntities<OpportunityClose>("business_unit_opportunity_close_activities", null); }
			set { SetRelatedEntities("business_unit_opportunity_close_activities", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'business_unit_order_close_activities'
        /// </summary>
		[RelationshipSchemaName("business_unit_order_close_activities")]
		public IEnumerable<OrderClose> BusinessUnitOrderCloseActivities
		{
			get { return GetRelatedEntities<OrderClose>("business_unit_order_close_activities", null); }
			set { SetRelatedEntities("business_unit_order_close_activities", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'business_unit_orders'
        /// </summary>
		[RelationshipSchemaName("business_unit_orders")]
		public IEnumerable<Order> BusinessUnitOrders
		{
			get { return GetRelatedEntities<Order>("business_unit_orders", null); }
			set { SetRelatedEntities("business_unit_orders", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'business_unit_parent_business_unit'
        /// </summary>
		[RelationshipSchemaName("business_unit_parent_business_unit")]
		public IEnumerable<BusinessUnit> BusinessUnitParentBusinessUnit
		{
			get { return GetRelatedEntities<BusinessUnit>("business_unit_parent_business_unit", null); }
			set { SetRelatedEntities("business_unit_parent_business_unit", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'business_unit_personaldocumenttemplates'
        /// </summary>
		[RelationshipSchemaName("business_unit_personaldocumenttemplates")]
		public IEnumerable<PersonalDocumentTemplate> BusinessUnitPersonaldocumenttemplates
		{
			get { return GetRelatedEntities<PersonalDocumentTemplate>("business_unit_personaldocumenttemplates", null); }
			set { SetRelatedEntities("business_unit_personaldocumenttemplates", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'business_unit_phone_call_activities'
        /// </summary>
		[RelationshipSchemaName("business_unit_phone_call_activities")]
		public IEnumerable<PhoneCall> BusinessUnitPhoneCallActivities
		{
			get { return GetRelatedEntities<PhoneCall>("business_unit_phone_call_activities", null); }
			set { SetRelatedEntities("business_unit_phone_call_activities", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'business_unit_postfollows'
        /// </summary>
		[RelationshipSchemaName("business_unit_postfollows")]
		public IEnumerable<Follow> BusinessUnitPostfollows
		{
			get { return GetRelatedEntities<Follow>("business_unit_postfollows", null); }
			set { SetRelatedEntities("business_unit_postfollows", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'business_unit_processstageparameter'
        /// </summary>
		[RelationshipSchemaName("business_unit_processstageparameter")]
		public IEnumerable<ProcessStageParameter> BusinessUnitProcessstageparameter
		{
			get { return GetRelatedEntities<ProcessStageParameter>("business_unit_processstageparameter", null); }
			set { SetRelatedEntities("business_unit_processstageparameter", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'business_unit_pw_penta_schedule_run'
        /// </summary>
		[RelationshipSchemaName("business_unit_pw_penta_schedule_run")]
		public IEnumerable<PentaScheduleRun> BusinessUnitPwPentaScheduleRun
		{
			get { return GetRelatedEntities<PentaScheduleRun>("business_unit_pw_penta_schedule_run", null); }
			set { SetRelatedEntities("business_unit_pw_penta_schedule_run", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'business_unit_pw_schedule'
        /// </summary>
		[RelationshipSchemaName("business_unit_pw_schedule")]
		public IEnumerable<PentaSchedule> BusinessUnitPwSchedule
		{
			get { return GetRelatedEntities<PentaSchedule>("business_unit_pw_schedule", null); }
			set { SetRelatedEntities("business_unit_pw_schedule", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'business_unit_queues'
        /// </summary>
		[RelationshipSchemaName("business_unit_queues")]
		public IEnumerable<Queue> BusinessUnitQueues
		{
			get { return GetRelatedEntities<Queue>("business_unit_queues", null); }
			set { SetRelatedEntities("business_unit_queues", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'business_unit_queues2'
        /// </summary>
		[RelationshipSchemaName("business_unit_queues2")]
		public IEnumerable<Queue> BusinessUnitQueues2
		{
			get { return GetRelatedEntities<Queue>("business_unit_queues2", null); }
			set { SetRelatedEntities("business_unit_queues2", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'business_unit_quote_close_activities'
        /// </summary>
		[RelationshipSchemaName("business_unit_quote_close_activities")]
		public IEnumerable<QuoteClose> BusinessUnitQuoteCloseActivities
		{
			get { return GetRelatedEntities<QuoteClose>("business_unit_quote_close_activities", null); }
			set { SetRelatedEntities("business_unit_quote_close_activities", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'business_unit_quotes'
        /// </summary>
		[RelationshipSchemaName("business_unit_quotes")]
		public IEnumerable<Quote> BusinessUnitQuotes
		{
			get { return GetRelatedEntities<Quote>("business_unit_quotes", null); }
			set { SetRelatedEntities("business_unit_quotes", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'business_unit_ratingmodel'
        /// </summary>
		[RelationshipSchemaName("business_unit_ratingmodel")]
		public IEnumerable<RatingModel> BusinessUnitRatingmodel
		{
			get { return GetRelatedEntities<RatingModel>("business_unit_ratingmodel", null); }
			set { SetRelatedEntities("business_unit_ratingmodel", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'business_unit_ratingvalue'
        /// </summary>
		[RelationshipSchemaName("business_unit_ratingvalue")]
		public IEnumerable<RatingValue> BusinessUnitRatingvalue
		{
			get { return GetRelatedEntities<RatingValue>("business_unit_ratingvalue", null); }
			set { SetRelatedEntities("business_unit_ratingvalue", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'business_unit_recurrencerule'
        /// </summary>
		[RelationshipSchemaName("business_unit_recurrencerule")]
		public IEnumerable<RecurrenceRule> BusinessUnitRecurrencerule
		{
			get { return GetRelatedEntities<RecurrenceRule>("business_unit_recurrencerule", null); }
			set { SetRelatedEntities("business_unit_recurrencerule", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'business_unit_recurringappointmentmaster_activities'
        /// </summary>
		[RelationshipSchemaName("business_unit_recurringappointmentmaster_activities")]
		public IEnumerable<RecurringAppointment> BusinessUnitRecurringappointmentmasterActivities
		{
			get { return GetRelatedEntities<RecurringAppointment>("business_unit_recurringappointmentmaster_activities", null); }
			set { SetRelatedEntities("business_unit_recurringappointmentmaster_activities", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'business_unit_reports'
        /// </summary>
		[RelationshipSchemaName("business_unit_reports")]
		public IEnumerable<Report> BusinessUnitReports
		{
			get { return GetRelatedEntities<Report>("business_unit_reports", null); }
			set { SetRelatedEntities("business_unit_reports", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'business_unit_resource_groups'
        /// </summary>
		[RelationshipSchemaName("business_unit_resource_groups")]
		public IEnumerable<SchedulingGroup> BusinessUnitResourceGroups
		{
			get { return GetRelatedEntities<SchedulingGroup>("business_unit_resource_groups", null); }
			set { SetRelatedEntities("business_unit_resource_groups", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'business_unit_resource_specs'
        /// </summary>
		[RelationshipSchemaName("business_unit_resource_specs")]
		public IEnumerable<ResourceSpecification> BusinessUnitResourceSpecs
		{
			get { return GetRelatedEntities<ResourceSpecification>("business_unit_resource_specs", null); }
			set { SetRelatedEntities("business_unit_resource_specs", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'business_unit_resources'
        /// </summary>
		[RelationshipSchemaName("business_unit_resources")]
		public IEnumerable<Resource> BusinessUnitResources
		{
			get { return GetRelatedEntities<Resource>("business_unit_resources", null); }
			set { SetRelatedEntities("business_unit_resources", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'business_unit_roles'
        /// </summary>
		[RelationshipSchemaName("business_unit_roles")]
		public IEnumerable<SecurityRole> BusinessUnitRoles
		{
			get { return GetRelatedEntities<SecurityRole>("business_unit_roles", null); }
			set { SetRelatedEntities("business_unit_roles", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'business_unit_service_appointments'
        /// </summary>
		[RelationshipSchemaName("business_unit_service_appointments")]
		public IEnumerable<ServiceActivity> BusinessUnitServiceAppointments
		{
			get { return GetRelatedEntities<ServiceActivity>("business_unit_service_appointments", null); }
			set { SetRelatedEntities("business_unit_service_appointments", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'business_unit_service_contracts'
        /// </summary>
		[RelationshipSchemaName("business_unit_service_contracts")]
		public IEnumerable<Contract> BusinessUnitServiceContracts
		{
			get { return GetRelatedEntities<Contract>("business_unit_service_contracts", null); }
			set { SetRelatedEntities("business_unit_service_contracts", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'business_unit_sharepointdocumentlocation'
        /// </summary>
		[RelationshipSchemaName("business_unit_sharepointdocumentlocation")]
		public IEnumerable<DocumentLocation> BusinessUnitSharepointdocumentlocation
		{
			get { return GetRelatedEntities<DocumentLocation>("business_unit_sharepointdocumentlocation", null); }
			set { SetRelatedEntities("business_unit_sharepointdocumentlocation", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'business_unit_sharepointsites'
        /// </summary>
		[RelationshipSchemaName("business_unit_sharepointsites")]
		public IEnumerable<SharePointSite> BusinessUnitSharepointsites
		{
			get { return GetRelatedEntities<SharePointSite>("business_unit_sharepointsites", null); }
			set { SetRelatedEntities("business_unit_sharepointsites", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'business_unit_slabase'
        /// </summary>
		[RelationshipSchemaName("business_unit_slabase")]
		public IEnumerable<SLA> BusinessUnitSlabase
		{
			get { return GetRelatedEntities<SLA>("business_unit_slabase", null); }
			set { SetRelatedEntities("business_unit_slabase", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'business_unit_slakpiinstance'
        /// </summary>
		[RelationshipSchemaName("business_unit_slakpiinstance")]
		public IEnumerable<SLAKPIInstance> BusinessUnitSlakpiinstance
		{
			get { return GetRelatedEntities<SLAKPIInstance>("business_unit_slakpiinstance", null); }
			set { SetRelatedEntities("business_unit_slakpiinstance", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'business_unit_socialactivity'
        /// </summary>
		[RelationshipSchemaName("business_unit_socialactivity")]
		public IEnumerable<SocialActivity> BusinessUnitSocialactivity
		{
			get { return GetRelatedEntities<SocialActivity>("business_unit_socialactivity", null); }
			set { SetRelatedEntities("business_unit_socialactivity", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'business_unit_socialprofiles'
        /// </summary>
		[RelationshipSchemaName("business_unit_socialprofiles")]
		public IEnumerable<SocialProfile> BusinessUnitSocialprofiles
		{
			get { return GetRelatedEntities<SocialProfile>("business_unit_socialprofiles", null); }
			set { SetRelatedEntities("business_unit_socialprofiles", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'business_unit_stagesolutionupload'
        /// </summary>
		[RelationshipSchemaName("business_unit_stagesolutionupload")]
		public IEnumerable<StageSolutionUpload> BusinessUnitStagesolutionupload
		{
			get { return GetRelatedEntities<StageSolutionUpload>("business_unit_stagesolutionupload", null); }
			set { SetRelatedEntities("business_unit_stagesolutionupload", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'business_unit_system_users'
        /// </summary>
		[RelationshipSchemaName("business_unit_system_users")]
		public IEnumerable<User> BusinessUnitSystemUsers
		{
			get { return GetRelatedEntities<User>("business_unit_system_users", null); }
			set { SetRelatedEntities("business_unit_system_users", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'business_unit_task_activities'
        /// </summary>
		[RelationshipSchemaName("business_unit_task_activities")]
		public IEnumerable<Task> BusinessUnitTaskActivities
		{
			get { return GetRelatedEntities<Task>("business_unit_task_activities", null); }
			set { SetRelatedEntities("business_unit_task_activities", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'business_unit_teams'
        /// </summary>
		[RelationshipSchemaName("business_unit_teams")]
		public IEnumerable<Team> BusinessUnitTeams
		{
			get { return GetRelatedEntities<Team>("business_unit_teams", null); }
			set { SetRelatedEntities("business_unit_teams", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'business_unit_templates'
        /// </summary>
		[RelationshipSchemaName("business_unit_templates")]
		public IEnumerable<EmailTemplate> BusinessUnitTemplates
		{
			get { return GetRelatedEntities<EmailTemplate>("business_unit_templates", null); }
			set { SetRelatedEntities("business_unit_templates", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'business_unit_user_settings'
        /// </summary>
		[RelationshipSchemaName("business_unit_user_settings")]
		public IEnumerable<UserSettings> BusinessUnitUserSettings
		{
			get { return GetRelatedEntities<UserSettings>("business_unit_user_settings", null); }
			set { SetRelatedEntities("business_unit_user_settings", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'business_unit_userform'
        /// </summary>
		[RelationshipSchemaName("business_unit_userform")]
		public IEnumerable<UserDashboard> BusinessUnitUserform
		{
			get { return GetRelatedEntities<UserDashboard>("business_unit_userform", null); }
			set { SetRelatedEntities("business_unit_userform", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'business_unit_userquery'
        /// </summary>
		[RelationshipSchemaName("business_unit_userquery")]
		public IEnumerable<SavedView> BusinessUnitUserquery
		{
			get { return GetRelatedEntities<SavedView>("business_unit_userquery", null); }
			set { SetRelatedEntities("business_unit_userquery", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'business_unit_userqueryvisualizations'
        /// </summary>
		[RelationshipSchemaName("business_unit_userqueryvisualizations")]
		public IEnumerable<UserChart> BusinessUnitUserqueryvisualizations
		{
			get { return GetRelatedEntities<UserChart>("business_unit_userqueryvisualizations", null); }
			set { SetRelatedEntities("business_unit_userqueryvisualizations", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'business_unit_workflow'
        /// </summary>
		[RelationshipSchemaName("business_unit_workflow")]
		public IEnumerable<Process> BusinessUnitWorkflow
		{
			get { return GetRelatedEntities<Process>("business_unit_workflow", null); }
			set { SetRelatedEntities("business_unit_workflow", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'business_unit_workflowbinary'
        /// </summary>
		[RelationshipSchemaName("business_unit_workflowbinary")]
		public IEnumerable<WorkflowBinary> BusinessUnitWorkflowbinary
		{
			get { return GetRelatedEntities<WorkflowBinary>("business_unit_workflowbinary", null); }
			set { SetRelatedEntities("business_unit_workflowbinary", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'business_unit_workflowlogs'
        /// </summary>
		[RelationshipSchemaName("business_unit_workflowlogs")]
		public IEnumerable<ProcessLog> BusinessUnitWorkflowlogs
		{
			get { return GetRelatedEntities<ProcessLog>("business_unit_workflowlogs", null); }
			set { SetRelatedEntities("business_unit_workflowlogs", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'BusinessUnit_AsyncOperations'
        /// </summary>
		[RelationshipSchemaName("BusinessUnit_AsyncOperations")]
		public IEnumerable<SystemJob> BusinessUnitAsyncOperations
		{
			get { return GetRelatedEntities<SystemJob>("BusinessUnit_AsyncOperations", null); }
			set { SetRelatedEntities("BusinessUnit_AsyncOperations", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'BusinessUnit_BulkDeleteFailures'
        /// </summary>
		[RelationshipSchemaName("BusinessUnit_BulkDeleteFailures")]
		public IEnumerable<BulkDeleteFailure> BusinessUnitBulkDeleteFailures
		{
			get { return GetRelatedEntities<BulkDeleteFailure>("BusinessUnit_BulkDeleteFailures", null); }
			set { SetRelatedEntities("BusinessUnit_BulkDeleteFailures", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'businessunit_callbackregistration'
        /// </summary>
		[RelationshipSchemaName("businessunit_callbackregistration")]
		public IEnumerable<CallbackRegistration> BusinessunitCallbackregistration
		{
			get { return GetRelatedEntities<CallbackRegistration>("businessunit_callbackregistration", null); }
			set { SetRelatedEntities("businessunit_callbackregistration", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'BusinessUnit_Campaigns'
        /// </summary>
		[RelationshipSchemaName("BusinessUnit_Campaigns")]
		public IEnumerable<Campaign> BusinessUnitCampaigns
		{
			get { return GetRelatedEntities<Campaign>("BusinessUnit_Campaigns", null); }
			set { SetRelatedEntities("BusinessUnit_Campaigns", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'businessunit_canvasapp'
        /// </summary>
		[RelationshipSchemaName("businessunit_canvasapp")]
		public IEnumerable<CanvasApp> BusinessunitCanvasapp
		{
			get { return GetRelatedEntities<CanvasApp>("businessunit_canvasapp", null); }
			set { SetRelatedEntities("businessunit_canvasapp", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'BusinessUnit_DuplicateRules'
        /// </summary>
		[RelationshipSchemaName("BusinessUnit_DuplicateRules")]
		public IEnumerable<DuplicateDetectionRule> BusinessUnitDuplicateRules
		{
			get { return GetRelatedEntities<DuplicateDetectionRule>("BusinessUnit_DuplicateRules", null); }
			set { SetRelatedEntities("BusinessUnit_DuplicateRules", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'BusinessUnit_ImportData'
        /// </summary>
		[RelationshipSchemaName("BusinessUnit_ImportData")]
		public IEnumerable<ImportData> BusinessUnitImportData
		{
			get { return GetRelatedEntities<ImportData>("BusinessUnit_ImportData", null); }
			set { SetRelatedEntities("BusinessUnit_ImportData", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'BusinessUnit_ImportFiles'
        /// </summary>
		[RelationshipSchemaName("BusinessUnit_ImportFiles")]
		public IEnumerable<ImportSourceFile> BusinessUnitImportFiles
		{
			get { return GetRelatedEntities<ImportSourceFile>("BusinessUnit_ImportFiles", null); }
			set { SetRelatedEntities("BusinessUnit_ImportFiles", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'BusinessUnit_ImportLogs'
        /// </summary>
		[RelationshipSchemaName("BusinessUnit_ImportLogs")]
		public IEnumerable<ImportLog> BusinessUnitImportLogs
		{
			get { return GetRelatedEntities<ImportLog>("BusinessUnit_ImportLogs", null); }
			set { SetRelatedEntities("BusinessUnit_ImportLogs", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'BusinessUnit_ImportMaps'
        /// </summary>
		[RelationshipSchemaName("BusinessUnit_ImportMaps")]
		public IEnumerable<DataMap> BusinessUnitImportMaps
		{
			get { return GetRelatedEntities<DataMap>("BusinessUnit_ImportMaps", null); }
			set { SetRelatedEntities("BusinessUnit_ImportMaps", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'BusinessUnit_Imports'
        /// </summary>
		[RelationshipSchemaName("BusinessUnit_Imports")]
		public IEnumerable<DataImport> BusinessUnitImports
		{
			get { return GetRelatedEntities<DataImport>("BusinessUnit_Imports", null); }
			set { SetRelatedEntities("BusinessUnit_Imports", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'businessunit_mailboxtrackingfolder'
        /// </summary>
		[RelationshipSchemaName("businessunit_mailboxtrackingfolder")]
		public IEnumerable<MailboxAutoTrackingFolder> BusinessunitMailboxtrackingfolder
		{
			get { return GetRelatedEntities<MailboxAutoTrackingFolder>("businessunit_mailboxtrackingfolder", null); }
			set { SetRelatedEntities("businessunit_mailboxtrackingfolder", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'businessunit_principalobjectattributeaccess'
        /// </summary>
		[RelationshipSchemaName("businessunit_principalobjectattributeaccess")]
		public IEnumerable<FieldSharing> BusinessunitPrincipalobjectattributeaccess
		{
			get { return GetRelatedEntities<FieldSharing>("businessunit_principalobjectattributeaccess", null); }
			set { SetRelatedEntities("businessunit_principalobjectattributeaccess", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'BusinessUnit_ProcessSessions'
        /// </summary>
		[RelationshipSchemaName("BusinessUnit_ProcessSessions")]
		public IEnumerable<ProcessSession> BusinessUnitProcessSessions
		{
			get { return GetRelatedEntities<ProcessSession>("BusinessUnit_ProcessSessions", null); }
			set { SetRelatedEntities("BusinessUnit_ProcessSessions", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'BusinessUnit_SyncError'
        /// </summary>
		[RelationshipSchemaName("BusinessUnit_SyncError")]
		public IEnumerable<SyncError> BusinessUnitSyncError
		{
			get { return GetRelatedEntities<SyncError>("BusinessUnit_SyncError", null); }
			set { SetRelatedEntities("BusinessUnit_SyncError", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'BusinessUnit_SyncErrors'
        /// </summary>
		[RelationshipSchemaName("BusinessUnit_SyncErrors")]
		public IEnumerable<SyncError> BusinessUnitSyncErrors
		{
			get { return GetRelatedEntities<SyncError>("BusinessUnit_SyncErrors", null); }
			set { SetRelatedEntities("BusinessUnit_SyncErrors", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'Owning_businessunit_processsessions'
        /// </summary>
		[RelationshipSchemaName("Owning_businessunit_processsessions")]
		public IEnumerable<ProcessSession> OwningBusinessunitProcesssessions
		{
			get { return GetRelatedEntities<ProcessSession>("Owning_businessunit_processsessions", null); }
			set { SetRelatedEntities("Owning_businessunit_processsessions", null, value); }
		}
		#endregion

		#region Actions
		#endregion

		#region OptionSetEnums
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
		
		#endregion	

		#region Properties
		public static class Properties 
		{
			/// <summary>address1_addressid</summary>
			public const string Address1Id = "address1_addressid";

			/// <summary>address1_addresstypecode</summary>
			public const string Address1AddressType = "address1_addresstypecode";

			/// <summary>address1_city</summary>
			public const string BillToCity = "address1_city";

			/// <summary>address1_country</summary>
			public const string BillToCountryRegion = "address1_country";

			/// <summary>address1_county</summary>
			public const string Address1County = "address1_county";

			/// <summary>address1_fax</summary>
			public const string Address1Fax = "address1_fax";

			/// <summary>address1_latitude</summary>
			public const string Address1Latitude = "address1_latitude";

			/// <summary>address1_line1</summary>
			public const string BillToStreet1 = "address1_line1";

			/// <summary>address1_line2</summary>
			public const string BillToStreet2 = "address1_line2";

			/// <summary>address1_line3</summary>
			public const string BillToStreet3 = "address1_line3";

			/// <summary>address1_longitude</summary>
			public const string Address1Longitude = "address1_longitude";

			/// <summary>address1_name</summary>
			public const string Address1Name = "address1_name";

			/// <summary>address1_postalcode</summary>
			public const string BillToZIPPostalCode = "address1_postalcode";

			/// <summary>address1_postofficebox</summary>
			public const string Address1PostOfficeBox = "address1_postofficebox";

			/// <summary>address1_shippingmethodcode</summary>
			public const string Address1ShippingMethod = "address1_shippingmethodcode";

			/// <summary>address1_stateorprovince</summary>
			public const string BillToStateProvince = "address1_stateorprovince";

			/// <summary>address1_telephone1</summary>
			public const string MainPhone = "address1_telephone1";

			/// <summary>address1_telephone2</summary>
			public const string OtherPhone = "address1_telephone2";

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
			public const string ShipToCity = "address2_city";

			/// <summary>address2_country</summary>
			public const string ShipToCountryRegion = "address2_country";

			/// <summary>address2_county</summary>
			public const string Address2County = "address2_county";

			/// <summary>address2_fax</summary>
			public const string Address2Fax = "address2_fax";

			/// <summary>address2_latitude</summary>
			public const string Address2Latitude = "address2_latitude";

			/// <summary>address2_line1</summary>
			public const string ShipToStreet1 = "address2_line1";

			/// <summary>address2_line2</summary>
			public const string ShipToStreet2 = "address2_line2";

			/// <summary>address2_line3</summary>
			public const string ShipToStreet3 = "address2_line3";

			/// <summary>address2_longitude</summary>
			public const string Address2Longitude = "address2_longitude";

			/// <summary>address2_name</summary>
			public const string Address2Name = "address2_name";

			/// <summary>address2_postalcode</summary>
			public const string ShipToZIPPostalCode = "address2_postalcode";

			/// <summary>address2_postofficebox</summary>
			public const string Address2PostOfficeBox = "address2_postofficebox";

			/// <summary>address2_shippingmethodcode</summary>
			public const string Address2ShippingMethod = "address2_shippingmethodcode";

			/// <summary>address2_stateorprovince</summary>
			public const string ShipToStateProvince = "address2_stateorprovince";

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

			/// <summary>businessunitid</summary>
			public const string BusinessUnitId = "businessunitid";

			/// <summary>calendarid</summary>
			public const string Calendar = "calendarid";

			/// <summary>costcenter</summary>
			public const string CostCenter = "costcenter";

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

			/// <summary>creditlimit</summary>
			public const string CreditLimit = "creditlimit";

			/// <summary>description</summary>
			public const string Description = "description";

			/// <summary>disabledreason</summary>
			public const string DisableReason = "disabledreason";

			/// <summary>divisionname</summary>
			public const string Division = "divisionname";

			/// <summary>emailaddress</summary>
			public const string Email = "emailaddress";

			/// <summary>exchangerate</summary>
			public const string ExchangeRate = "exchangerate";

			/// <summary>fileasname</summary>
			public const string FileAsName = "fileasname";

			/// <summary>ftpsiteurl</summary>
			public const string FTPSite = "ftpsiteurl";

			/// <summary>importsequencenumber</summary>
			public const string ImportSequenceNumber = "importsequencenumber";

			/// <summary>inheritancemask</summary>
			public const string InheritanceMask = "inheritancemask";

			/// <summary>isdisabled</summary>
			public const string IsDisabled = "isdisabled";

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

			/// <summary>organizationid</summary>
			public const string Organization = "organizationid";

			/// <summary>organizationidname</summary>
			public const string Organizationidname = "organizationidname";

			/// <summary>overriddencreatedon</summary>
			public const string RecordCreatedOn = "overriddencreatedon";

			/// <summary>parentbusinessunitid</summary>
			public const string ParentBusiness = "parentbusinessunitid";

			/// <summary>parentbusinessunitidname</summary>
			public const string Parentbusinessunitidname = "parentbusinessunitidname";

			/// <summary>picture</summary>
			public const string Picture = "picture";

			/// <summary>stockexchange</summary>
			public const string StockExchange = "stockexchange";

			/// <summary>tickersymbol</summary>
			public const string TickerSymbol = "tickersymbol";

			/// <summary>transactioncurrencyid</summary>
			public const string Currency = "transactioncurrencyid";

			/// <summary>transactioncurrencyidname</summary>
			public const string Transactioncurrencyidname = "transactioncurrencyidname";

			/// <summary>usergroupid</summary>
			public const string UsergroupId = "usergroupid";

			/// <summary>utcoffset</summary>
			public const string UTCOffset = "utcoffset";

			/// <summary>versionnumber</summary>
			public const string VersionNumber = "versionnumber";

			/// <summary>websiteurl</summary>
			public const string Website = "websiteurl";

			/// <summary>workflowsuspended</summary>
			public const string WorkflowSuspended = "workflowsuspended";

		}
		#endregion

		#region Schemas
		public static class Schemas 
		{
			/// <summary>1:N BulkDeleteOperation_BusinessUnit</summary>
			public const string BulkDeleteOperationBusinessUnit = "BulkDeleteOperation_BusinessUnit";

			/// <summary>1:N business_unit_accounts</summary>
			public const string BusinessUnitAccounts = "business_unit_accounts";

			/// <summary>1:N business_unit_actioncards</summary>
			public const string BusinessUnitActioncards = "business_unit_actioncards";

			/// <summary>1:N business_unit_activitymonitor</summary>
			public const string BusinessUnitActivitymonitor = "business_unit_activitymonitor";

			/// <summary>1:N business_unit_activitypointer</summary>
			public const string BusinessUnitActivitypointer = "business_unit_activitypointer";

			/// <summary>1:N business_unit_adminsettingsentity</summary>
			public const string BusinessUnitAdminsettingsentity = "business_unit_adminsettingsentity";

			/// <summary>1:N business_unit_annotations</summary>
			public const string BusinessUnitAnnotations = "business_unit_annotations";

			/// <summary>1:N business_unit_appointment_activities</summary>
			public const string BusinessUnitAppointmentActivities = "business_unit_appointment_activities";

			/// <summary>1:N business_unit_asyncoperation</summary>
			public const string BusinessUnitAsyncoperation = "business_unit_asyncoperation";

			/// <summary>1:N business_unit_bookableresource</summary>
			public const string BusinessUnitBookableresource = "business_unit_bookableresource";

			/// <summary>1:N business_unit_bookableresourcebooking</summary>
			public const string BusinessUnitBookableresourcebooking = "business_unit_bookableresourcebooking";

			/// <summary>1:N business_unit_bookableresourcebookingheader</summary>
			public const string BusinessUnitBookableresourcebookingheader = "business_unit_bookableresourcebookingheader";

			/// <summary>1:N business_unit_bookableresourcecategory</summary>
			public const string BusinessUnitBookableresourcecategory = "business_unit_bookableresourcecategory";

			/// <summary>1:N business_unit_bookableresourcecategoryassn</summary>
			public const string BusinessUnitBookableresourcecategoryassn = "business_unit_bookableresourcecategoryassn";

			/// <summary>1:N business_unit_bookableresourcecharacteristic</summary>
			public const string BusinessUnitBookableresourcecharacteristic = "business_unit_bookableresourcecharacteristic";

			/// <summary>1:N business_unit_bookableresourcegroup</summary>
			public const string BusinessUnitBookableresourcegroup = "business_unit_bookableresourcegroup";

			/// <summary>1:N business_unit_bookingstatus</summary>
			public const string BusinessUnitBookingstatus = "business_unit_bookingstatus";

			/// <summary>1:N business_unit_bot</summary>
			public const string BusinessUnitBot = "business_unit_bot";

			/// <summary>1:N business_unit_botcomponent</summary>
			public const string BusinessUnitBotcomponent = "business_unit_botcomponent";

			/// <summary>1:N business_unit_BulkOperation_activities</summary>
			public const string BusinessUnitBulkOperationActivities = "business_unit_BulkOperation_activities";

			/// <summary>1:N business_unit_calendars</summary>
			public const string BusinessUnitCalendars = "business_unit_calendars";

			/// <summary>1:N business_unit_campaignactivity_activities</summary>
			public const string BusinessUnitCampaignactivityActivities = "business_unit_campaignactivity_activities";

			/// <summary>1:N business_unit_campaignresponse_activities</summary>
			public const string BusinessUnitCampaignresponseActivities = "business_unit_campaignresponse_activities";

			/// <summary>1:N business_unit_category</summary>
			public const string BusinessUnitCategory = "business_unit_category";

			/// <summary>1:N business_unit_characteristic</summary>
			public const string BusinessUnitCharacteristic = "business_unit_characteristic";

			/// <summary>1:N business_unit_connectionreference</summary>
			public const string BusinessUnitConnectionreference = "business_unit_connectionreference";

			/// <summary>1:N business_unit_connections</summary>
			public const string BusinessUnitConnections = "business_unit_connections";

			/// <summary>1:N business_unit_connector</summary>
			public const string BusinessUnitConnector = "business_unit_connector";

			/// <summary>1:N business_unit_constraint_based_groups</summary>
			public const string BusinessUnitConstraintBasedGroups = "business_unit_constraint_based_groups";

			/// <summary>1:N business_unit_contacts</summary>
			public const string BusinessUnitContacts = "business_unit_contacts";

			/// <summary>1:N business_unit_conversationtranscript</summary>
			public const string BusinessUnitConversationtranscript = "business_unit_conversationtranscript";

			/// <summary>1:N business_unit_customapi</summary>
			public const string BusinessUnitCustomapi = "business_unit_customapi";

			/// <summary>1:N business_unit_customapirequestparameter</summary>
			public const string BusinessUnitCustomapirequestparameter = "business_unit_customapirequestparameter";

			/// <summary>1:N business_unit_customapiresponseproperty</summary>
			public const string BusinessUnitCustomapiresponseproperty = "business_unit_customapiresponseproperty";

			/// <summary>1:N business_unit_datalakefolder</summary>
			public const string BusinessUnitDatalakefolder = "business_unit_datalakefolder";

			/// <summary>1:N business_unit_datalakefolderpermission</summary>
			public const string BusinessUnitDatalakefolderpermission = "business_unit_datalakefolderpermission";

			/// <summary>1:N business_unit_dynamicproperyinstance</summary>
			public const string BusinessUnitDynamicproperyinstance = "business_unit_dynamicproperyinstance";

			/// <summary>1:N business_unit_email_activities</summary>
			public const string BusinessUnitEmailActivities = "business_unit_email_activities";

			/// <summary>1:N business_unit_emailserverprofile</summary>
			public const string BusinessUnitEmailserverprofile = "business_unit_emailserverprofile";

			/// <summary>1:N business_unit_entitlement</summary>
			public const string BusinessUnitEntitlement = "business_unit_entitlement";

			/// <summary>1:N business_unit_entitlemententityallocationtypemapping</summary>
			public const string BusinessUnitEntitlemententityallocationtypemapping = "business_unit_entitlemententityallocationtypemapping";

			/// <summary>1:N business_unit_environmentvariabledefinition</summary>
			public const string BusinessUnitEnvironmentvariabledefinition = "business_unit_environmentvariabledefinition";

			/// <summary>1:N business_unit_environmentvariablevalue</summary>
			public const string BusinessUnitEnvironmentvariablevalue = "business_unit_environmentvariablevalue";

			/// <summary>1:N business_unit_equipment</summary>
			public const string BusinessUnitEquipment = "business_unit_equipment";

			/// <summary>1:N business_unit_exchangesyncidmapping</summary>
			public const string BusinessUnitExchangesyncidmapping = "business_unit_exchangesyncidmapping";

			/// <summary>1:N business_unit_exportsolutionupload</summary>
			public const string BusinessUnitExportsolutionupload = "business_unit_exportsolutionupload";

			/// <summary>1:N business_unit_fax_activities</summary>
			public const string BusinessUnitFaxActivities = "business_unit_fax_activities";

			/// <summary>1:N business_unit_feedback</summary>
			public const string BusinessUnitFeedback = "business_unit_feedback";

			/// <summary>1:N business_unit_flowsession</summary>
			public const string BusinessUnitFlowsession = "business_unit_flowsession";

			/// <summary>1:N business_unit_goal</summary>
			public const string BusinessUnitGoal = "business_unit_goal";

			/// <summary>1:N business_unit_goalrollupquery</summary>
			public const string BusinessUnitGoalrollupquery = "business_unit_goalrollupquery";

			/// <summary>1:N business_unit_incident_resolution_activities</summary>
			public const string BusinessUnitIncidentResolutionActivities = "business_unit_incident_resolution_activities";

			/// <summary>1:N business_unit_incidents</summary>
			public const string BusinessUnitIncidents = "business_unit_incidents";

			/// <summary>1:N business_unit_interactionforemail</summary>
			public const string BusinessUnitInteractionforemail = "business_unit_interactionforemail";

			/// <summary>1:N business_unit_invoices</summary>
			public const string BusinessUnitInvoices = "business_unit_invoices";

			/// <summary>1:N business_unit_knowledgearticle</summary>
			public const string BusinessUnitKnowledgearticle = "business_unit_knowledgearticle";

			/// <summary>1:N business_unit_leads</summary>
			public const string BusinessUnitLeads = "business_unit_leads";

			/// <summary>1:N business_unit_letter_activities</summary>
			public const string BusinessUnitLetterActivities = "business_unit_letter_activities";

			/// <summary>1:N business_unit_list</summary>
			public const string BusinessUnitList = "business_unit_list";

			/// <summary>1:N business_unit_listoperation</summary>
			public const string BusinessUnitListoperation = "business_unit_listoperation";

			/// <summary>1:N business_unit_mailbox</summary>
			public const string BusinessUnitMailbox = "business_unit_mailbox";

			/// <summary>1:N business_unit_mailmergetemplates</summary>
			public const string BusinessUnitMailmergetemplates = "business_unit_mailmergetemplates";

			/// <summary>1:N business_unit_msdyn_actioncardregarding</summary>
			public const string BusinessUnitMsdynActioncardregarding = "business_unit_msdyn_actioncardregarding";

			/// <summary>1:N business_unit_msdyn_actioncardrolesetting</summary>
			public const string BusinessUnitMsdynActioncardrolesetting = "business_unit_msdyn_actioncardrolesetting";

			/// <summary>1:N business_unit_msdyn_aibdataset</summary>
			public const string BusinessUnitMsdynAibdataset = "business_unit_msdyn_aibdataset";

			/// <summary>1:N business_unit_msdyn_aibdatasetfile</summary>
			public const string BusinessUnitMsdynAibdatasetfile = "business_unit_msdyn_aibdatasetfile";

			/// <summary>1:N business_unit_msdyn_aibdatasetrecord</summary>
			public const string BusinessUnitMsdynAibdatasetrecord = "business_unit_msdyn_aibdatasetrecord";

			/// <summary>1:N business_unit_msdyn_aibdatasetscontainer</summary>
			public const string BusinessUnitMsdynAibdatasetscontainer = "business_unit_msdyn_aibdatasetscontainer";

			/// <summary>1:N business_unit_msdyn_aibfile</summary>
			public const string BusinessUnitMsdynAibfile = "business_unit_msdyn_aibfile";

			/// <summary>1:N business_unit_msdyn_aibfileattacheddata</summary>
			public const string BusinessUnitMsdynAibfileattacheddata = "business_unit_msdyn_aibfileattacheddata";

			/// <summary>1:N business_unit_msdyn_aiconfiguration</summary>
			public const string BusinessUnitMsdynAiconfiguration = "business_unit_msdyn_aiconfiguration";

			/// <summary>1:N business_unit_msdyn_aifptrainingdocument</summary>
			public const string BusinessUnitMsdynAifptrainingdocument = "business_unit_msdyn_aifptrainingdocument";

			/// <summary>1:N business_unit_msdyn_aimodel</summary>
			public const string BusinessUnitMsdynAimodel = "business_unit_msdyn_aimodel";

			/// <summary>1:N business_unit_msdyn_aiodimage</summary>
			public const string BusinessUnitMsdynAiodimage = "business_unit_msdyn_aiodimage";

			/// <summary>1:N business_unit_msdyn_aiodlabel</summary>
			public const string BusinessUnitMsdynAiodlabel = "business_unit_msdyn_aiodlabel";

			/// <summary>1:N business_unit_msdyn_aiodtrainingboundingbox</summary>
			public const string BusinessUnitMsdynAiodtrainingboundingbox = "business_unit_msdyn_aiodtrainingboundingbox";

			/// <summary>1:N business_unit_msdyn_aiodtrainingimage</summary>
			public const string BusinessUnitMsdynAiodtrainingimage = "business_unit_msdyn_aiodtrainingimage";

			/// <summary>1:N business_unit_msdyn_aitemplate</summary>
			public const string BusinessUnitMsdynAitemplate = "business_unit_msdyn_aitemplate";

			/// <summary>1:N business_unit_msdyn_autocapturerule</summary>
			public const string BusinessUnitMsdynAutocapturerule = "business_unit_msdyn_autocapturerule";

			/// <summary>1:N business_unit_msdyn_autocapturesettings</summary>
			public const string BusinessUnitMsdynAutocapturesettings = "business_unit_msdyn_autocapturesettings";

			/// <summary>1:N business_unit_msdyn_callablecontext</summary>
			public const string BusinessUnitMsdynCallablecontext = "business_unit_msdyn_callablecontext";

			/// <summary>1:N business_unit_msdyn_entityrankingrule</summary>
			public const string BusinessUnitMsdynEntityrankingrule = "business_unit_msdyn_entityrankingrule";

			/// <summary>1:N business_unit_msdyn_federatedarticle</summary>
			public const string BusinessUnitMsdynFederatedarticle = "business_unit_msdyn_federatedarticle";

			/// <summary>1:N business_unit_msdyn_flowcardtype</summary>
			public const string BusinessUnitMsdynFlowcardtype = "business_unit_msdyn_flowcardtype";

			/// <summary>1:N business_unit_msdyn_icebreakersconfig</summary>
			public const string BusinessUnitMsdynIcebreakersconfig = "business_unit_msdyn_icebreakersconfig";

			/// <summary>1:N business_unit_msdyn_kmfederatedsearchconfig</summary>
			public const string BusinessUnitMsdynKmfederatedsearchconfig = "business_unit_msdyn_kmfederatedsearchconfig";

			/// <summary>1:N business_unit_msdyn_knowledgearticleimage</summary>
			public const string BusinessUnitMsdynKnowledgearticleimage = "business_unit_msdyn_knowledgearticleimage";

			/// <summary>1:N business_unit_msdyn_knowledgearticletemplate</summary>
			public const string BusinessUnitMsdynKnowledgearticletemplate = "business_unit_msdyn_knowledgearticletemplate";

			/// <summary>1:N business_unit_msdyn_knowledgeinteractioninsight</summary>
			public const string BusinessUnitMsdynKnowledgeinteractioninsight = "business_unit_msdyn_knowledgeinteractioninsight";

			/// <summary>1:N business_unit_msdyn_knowledgesearchinsight</summary>
			public const string BusinessUnitMsdynKnowledgesearchinsight = "business_unit_msdyn_knowledgesearchinsight";

			/// <summary>1:N business_unit_msdyn_msteamssetting</summary>
			public const string BusinessUnitMsdynMsteamssetting = "business_unit_msdyn_msteamssetting";

			/// <summary>1:N business_unit_msdyn_notesanalysisconfig</summary>
			public const string BusinessUnitMsdynNotesanalysisconfig = "business_unit_msdyn_notesanalysisconfig";

			/// <summary>1:N business_unit_msdyn_playbookactivity</summary>
			public const string BusinessUnitMsdynPlaybookactivity = "business_unit_msdyn_playbookactivity";

			/// <summary>1:N business_unit_msdyn_playbookactivityattribute</summary>
			public const string BusinessUnitMsdynPlaybookactivityattribute = "business_unit_msdyn_playbookactivityattribute";

			/// <summary>1:N business_unit_msdyn_playbookcategory</summary>
			public const string BusinessUnitMsdynPlaybookcategory = "business_unit_msdyn_playbookcategory";

			/// <summary>1:N business_unit_msdyn_playbookinstance</summary>
			public const string BusinessUnitMsdynPlaybookinstance = "business_unit_msdyn_playbookinstance";

			/// <summary>1:N business_unit_msdyn_playbooktemplate</summary>
			public const string BusinessUnitMsdynPlaybooktemplate = "business_unit_msdyn_playbooktemplate";

			/// <summary>1:N business_unit_msdyn_postalbum</summary>
			public const string BusinessUnitMsdynPostalbum = "business_unit_msdyn_postalbum";

			/// <summary>1:N business_unit_msdyn_relationshipinsightsunifiedconfig</summary>
			public const string BusinessUnitMsdynRelationshipinsightsunifiedconfig = "business_unit_msdyn_relationshipinsightsunifiedconfig";

			/// <summary>1:N business_unit_msdyn_richtextfile</summary>
			public const string BusinessUnitMsdynRichtextfile = "business_unit_msdyn_richtextfile";

			/// <summary>1:N business_unit_msdyn_salesinsightssettings</summary>
			public const string BusinessUnitMsdynSalesinsightssettings = "business_unit_msdyn_salesinsightssettings";

			/// <summary>1:N business_unit_msdyn_siconfig</summary>
			public const string BusinessUnitMsdynSiconfig = "business_unit_msdyn_siconfig";

			/// <summary>1:N business_unit_msdyn_untrackedappointment</summary>
			public const string BusinessUnitMsdynUntrackedappointment = "business_unit_msdyn_untrackedappointment";

			/// <summary>1:N business_unit_msdyn_wallsavedqueryusersettings</summary>
			public const string BusinessUnitMsdynWallsavedqueryusersettings = "business_unit_msdyn_wallsavedqueryusersettings";

			/// <summary>1:N business_unit_msdynce_botcontent</summary>
			public const string BusinessUnitMsdynceBotcontent = "business_unit_msdynce_botcontent";

			/// <summary>1:N business_unit_opportunities</summary>
			public const string BusinessUnitOpportunities = "business_unit_opportunities";

			/// <summary>1:N business_unit_opportunity_close_activities</summary>
			public const string BusinessUnitOpportunityCloseActivities = "business_unit_opportunity_close_activities";

			/// <summary>1:N business_unit_order_close_activities</summary>
			public const string BusinessUnitOrderCloseActivities = "business_unit_order_close_activities";

			/// <summary>1:N business_unit_orders</summary>
			public const string BusinessUnitOrders = "business_unit_orders";

			/// <summary>1:N business_unit_parent_business_unit</summary>
			public const string BusinessUnitParentBusinessUnit = "business_unit_parent_business_unit";

			/// <summary>1:N business_unit_personaldocumenttemplates</summary>
			public const string BusinessUnitPersonaldocumenttemplates = "business_unit_personaldocumenttemplates";

			/// <summary>1:N business_unit_phone_call_activities</summary>
			public const string BusinessUnitPhoneCallActivities = "business_unit_phone_call_activities";

			/// <summary>1:N business_unit_postfollows</summary>
			public const string BusinessUnitPostfollows = "business_unit_postfollows";

			/// <summary>1:N business_unit_processstageparameter</summary>
			public const string BusinessUnitProcessstageparameter = "business_unit_processstageparameter";

			/// <summary>1:N business_unit_pw_penta_schedule_run</summary>
			public const string BusinessUnitPwPentaScheduleRun = "business_unit_pw_penta_schedule_run";

			/// <summary>1:N business_unit_pw_schedule</summary>
			public const string BusinessUnitPwSchedule = "business_unit_pw_schedule";

			/// <summary>1:N business_unit_queues</summary>
			public const string BusinessUnitQueues = "business_unit_queues";

			/// <summary>1:N business_unit_queues2</summary>
			public const string BusinessUnitQueues2 = "business_unit_queues2";

			/// <summary>1:N business_unit_quote_close_activities</summary>
			public const string BusinessUnitQuoteCloseActivities = "business_unit_quote_close_activities";

			/// <summary>1:N business_unit_quotes</summary>
			public const string BusinessUnitQuotes = "business_unit_quotes";

			/// <summary>1:N business_unit_ratingmodel</summary>
			public const string BusinessUnitRatingmodel = "business_unit_ratingmodel";

			/// <summary>1:N business_unit_ratingvalue</summary>
			public const string BusinessUnitRatingvalue = "business_unit_ratingvalue";

			/// <summary>1:N business_unit_recurrencerule</summary>
			public const string BusinessUnitRecurrencerule = "business_unit_recurrencerule";

			/// <summary>1:N business_unit_recurringappointmentmaster_activities</summary>
			public const string BusinessUnitRecurringappointmentmasterActivities = "business_unit_recurringappointmentmaster_activities";

			/// <summary>1:N business_unit_reports</summary>
			public const string BusinessUnitReports = "business_unit_reports";

			/// <summary>1:N business_unit_resource_groups</summary>
			public const string BusinessUnitResourceGroups = "business_unit_resource_groups";

			/// <summary>1:N business_unit_resource_specs</summary>
			public const string BusinessUnitResourceSpecs = "business_unit_resource_specs";

			/// <summary>1:N business_unit_resources</summary>
			public const string BusinessUnitResources = "business_unit_resources";

			/// <summary>1:N business_unit_roles</summary>
			public const string BusinessUnitRoles = "business_unit_roles";

			/// <summary>1:N business_unit_service_appointments</summary>
			public const string BusinessUnitServiceAppointments = "business_unit_service_appointments";

			/// <summary>1:N business_unit_service_contracts</summary>
			public const string BusinessUnitServiceContracts = "business_unit_service_contracts";

			/// <summary>1:N business_unit_sharepointdocumentlocation</summary>
			public const string BusinessUnitSharepointdocumentlocation = "business_unit_sharepointdocumentlocation";

			/// <summary>1:N business_unit_sharepointsites</summary>
			public const string BusinessUnitSharepointsites = "business_unit_sharepointsites";

			/// <summary>1:N business_unit_slabase</summary>
			public const string BusinessUnitSlabase = "business_unit_slabase";

			/// <summary>1:N business_unit_slakpiinstance</summary>
			public const string BusinessUnitSlakpiinstance = "business_unit_slakpiinstance";

			/// <summary>1:N business_unit_socialactivity</summary>
			public const string BusinessUnitSocialactivity = "business_unit_socialactivity";

			/// <summary>1:N business_unit_socialprofiles</summary>
			public const string BusinessUnitSocialprofiles = "business_unit_socialprofiles";

			/// <summary>1:N business_unit_stagesolutionupload</summary>
			public const string BusinessUnitStagesolutionupload = "business_unit_stagesolutionupload";

			/// <summary>1:N business_unit_system_users</summary>
			public const string BusinessUnitSystemUsers = "business_unit_system_users";

			/// <summary>1:N business_unit_task_activities</summary>
			public const string BusinessUnitTaskActivities = "business_unit_task_activities";

			/// <summary>1:N business_unit_teams</summary>
			public const string BusinessUnitTeams = "business_unit_teams";

			/// <summary>1:N business_unit_templates</summary>
			public const string BusinessUnitTemplates = "business_unit_templates";

			/// <summary>1:N business_unit_user_settings</summary>
			public const string BusinessUnitUserSettings = "business_unit_user_settings";

			/// <summary>1:N business_unit_userform</summary>
			public const string BusinessUnitUserform = "business_unit_userform";

			/// <summary>1:N business_unit_userquery</summary>
			public const string BusinessUnitUserquery = "business_unit_userquery";

			/// <summary>1:N business_unit_userqueryvisualizations</summary>
			public const string BusinessUnitUserqueryvisualizations = "business_unit_userqueryvisualizations";

			/// <summary>1:N business_unit_workflow</summary>
			public const string BusinessUnitWorkflow = "business_unit_workflow";

			/// <summary>1:N business_unit_workflowbinary</summary>
			public const string BusinessUnitWorkflowbinary = "business_unit_workflowbinary";

			/// <summary>1:N business_unit_workflowlogs</summary>
			public const string BusinessUnitWorkflowlogs = "business_unit_workflowlogs";

			/// <summary>1:N BusinessUnit_AsyncOperations</summary>
			public const string BusinessUnitAsyncOperations = "BusinessUnit_AsyncOperations";

			/// <summary>1:N BusinessUnit_BulkDeleteFailures</summary>
			public const string BusinessUnitBulkDeleteFailures = "BusinessUnit_BulkDeleteFailures";

			/// <summary>1:N businessunit_callbackregistration</summary>
			public const string BusinessunitCallbackregistration = "businessunit_callbackregistration";

			/// <summary>1:N BusinessUnit_Campaigns</summary>
			public const string BusinessUnitCampaigns = "BusinessUnit_Campaigns";

			/// <summary>1:N businessunit_canvasapp</summary>
			public const string BusinessunitCanvasapp = "businessunit_canvasapp";

			/// <summary>1:N BusinessUnit_DuplicateRules</summary>
			public const string BusinessUnitDuplicateRules = "BusinessUnit_DuplicateRules";

			/// <summary>1:N BusinessUnit_ImportData</summary>
			public const string BusinessUnitImportData = "BusinessUnit_ImportData";

			/// <summary>1:N BusinessUnit_ImportFiles</summary>
			public const string BusinessUnitImportFiles = "BusinessUnit_ImportFiles";

			/// <summary>1:N BusinessUnit_ImportLogs</summary>
			public const string BusinessUnitImportLogs = "BusinessUnit_ImportLogs";

			/// <summary>1:N BusinessUnit_ImportMaps</summary>
			public const string BusinessUnitImportMaps = "BusinessUnit_ImportMaps";

			/// <summary>1:N BusinessUnit_Imports</summary>
			public const string BusinessUnitImports = "BusinessUnit_Imports";

			/// <summary>1:N businessunit_mailboxtrackingfolder</summary>
			public const string BusinessunitMailboxtrackingfolder = "businessunit_mailboxtrackingfolder";

			/// <summary>1:N businessunit_principalobjectattributeaccess</summary>
			public const string BusinessunitPrincipalobjectattributeaccess = "businessunit_principalobjectattributeaccess";

			/// <summary>1:N BusinessUnit_ProcessSessions</summary>
			public const string BusinessUnitProcessSessions = "BusinessUnit_ProcessSessions";

			/// <summary>1:N BusinessUnit_SyncError</summary>
			public const string BusinessUnitSyncError = "BusinessUnit_SyncError";

			/// <summary>1:N BusinessUnit_SyncErrors</summary>
			public const string BusinessUnitSyncErrors = "BusinessUnit_SyncErrors";

			/// <summary>1:N Owning_businessunit_processsessions</summary>
			public const string OwningBusinessunitProcesssessions = "Owning_businessunit_processsessions";

		}
		#endregion
	}
}

