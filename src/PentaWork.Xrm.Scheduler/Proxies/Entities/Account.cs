using System;
using System.Linq;
using System.Diagnostics;
using System.ComponentModel;
using Microsoft.Xrm.Sdk; 
using Microsoft.Xrm.Sdk.Client;
using System.Collections.Generic;

namespace PentaWork.Xrm.Scheduler.Proxies.Entities
{
	[DebuggerDisplay("{AccountName}")] 	
	[EntityLogicalName("account")]
	public sealed class Account : Entity
	{	
		public static readonly int? EntityTypeCode = 1;
		public new const string LogicalName = "account";
		public const string PrimaryIdAttribute = "accountid";
		public const string PrimaryNameAttribute = "name";
	
		public Account() : base("account") { }

		#region Attributes
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
				if(Attributes.ContainsKey("accountcategorycode") && value == Category) return;

				OptionSetValue optionSetValue = null;
				if(value != null) optionSetValue = new OptionSetValue((int)value);
				SetAttributeValue("accountcategorycode", optionSetValue); 
			}
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
				if(Attributes.ContainsKey("accountclassificationcode") && value == Classification) return;

				OptionSetValue optionSetValue = null;
				if(value != null) optionSetValue = new OptionSetValue((int)value);
				SetAttributeValue("accountclassificationcode", optionSetValue); 
			}
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
        /// accountnumber
        /// </summary>
		[DisplayName("Account Number")]
		[AttributeLogicalName("accountnumber")]
		public string AccountNumber
		{	
			get { return GetAttributeValue<string>("accountnumber"); }
			set
			{ 
				if(Attributes.ContainsKey("accountnumber") && value == AccountNumber) return;
				SetAttributeValue("accountnumber", value);
			}
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
				if(Attributes.ContainsKey("accountratingcode") && value == AccountRating) return;

				OptionSetValue optionSetValue = null;
				if(value != null) optionSetValue = new OptionSetValue((int)value);
				SetAttributeValue("accountratingcode", optionSetValue); 
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
				if(Attributes.ContainsKey("address1_addressid") && value == Address1Id) return;
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
				if(Attributes.ContainsKey("address1_addresstypecode") && value == Address1AddressType) return;

				OptionSetValue optionSetValue = null;
				if(value != null) optionSetValue = new OptionSetValue((int)value);
				SetAttributeValue("address1_addresstypecode", optionSetValue); 
			}
		}

		/// <summary>
        /// address1_city
        /// </summary>
		[DisplayName("Address 1: City")]
		[AttributeLogicalName("address1_city")]
		public string Address1City
		{	
			get { return GetAttributeValue<string>("address1_city"); }
			set
			{ 
				if(Attributes.ContainsKey("address1_city") && value == Address1City) return;
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
				if(Attributes.ContainsKey("address1_composite") && value == Address1) return;
				SetAttributeValue("address1_composite", value);
			}
		}	
			
		/// <summary>
        /// address1_country
        /// </summary>
		[DisplayName("Address 1: Country/Region")]
		[AttributeLogicalName("address1_country")]
		public string Address1CountryRegion
		{	
			get { return GetAttributeValue<string>("address1_country"); }
			set
			{ 
				if(Attributes.ContainsKey("address1_country") && value == Address1CountryRegion) return;
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
				if(Attributes.ContainsKey("address1_county") && value == Address1County) return;
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
				if(Attributes.ContainsKey("address1_fax") && value == Address1Fax) return;
				SetAttributeValue("address1_fax", value);
			}
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
				if(Attributes.ContainsKey("address1_freighttermscode") && value == Address1FreightTerms) return;

				OptionSetValue optionSetValue = null;
				if(value != null) optionSetValue = new OptionSetValue((int)value);
				SetAttributeValue("address1_freighttermscode", optionSetValue); 
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
				if(Attributes.ContainsKey("address1_latitude") && doubleValue == Address1Latitude) return;
				SetAttributeValue("address1_latitude", doubleValue);  
			}
		}

		/// <summary>
        /// address1_line1
        /// </summary>
		[DisplayName("Address 1: Street 1")]
		[AttributeLogicalName("address1_line1")]
		public string Address1Street1
		{	
			get { return GetAttributeValue<string>("address1_line1"); }
			set
			{ 
				if(Attributes.ContainsKey("address1_line1") && value == Address1Street1) return;
				SetAttributeValue("address1_line1", value);
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
			set
			{ 
				if(Attributes.ContainsKey("address1_line2") && value == Address1Street2) return;
				SetAttributeValue("address1_line2", value);
			}
		}	
			
		/// <summary>
        /// address1_line3
        /// </summary>
		[DisplayName("Address 1: Street 3")]
		[AttributeLogicalName("address1_line3")]
		public string Address1Street3
		{	
			get { return GetAttributeValue<string>("address1_line3"); }
			set
			{ 
				if(Attributes.ContainsKey("address1_line3") && value == Address1Street3) return;
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
				if(Attributes.ContainsKey("address1_longitude") && doubleValue == Address1Longitude) return;
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
				if(Attributes.ContainsKey("address1_name") && value == Address1Name) return;
				SetAttributeValue("address1_name", value);
			}
		}	
			
		/// <summary>
        /// address1_postalcode
        /// </summary>
		[DisplayName("Address 1: ZIP/Postal Code")]
		[AttributeLogicalName("address1_postalcode")]
		public string Address1ZIPPostalCode
		{	
			get { return GetAttributeValue<string>("address1_postalcode"); }
			set
			{ 
				if(Attributes.ContainsKey("address1_postalcode") && value == Address1ZIPPostalCode) return;
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
				if(Attributes.ContainsKey("address1_postofficebox") && value == Address1PostOfficeBox) return;
				SetAttributeValue("address1_postofficebox", value);
			}
		}	
			
		/// <summary>
        /// address1_primarycontactname
        /// </summary>
		[DisplayName("Address 1: Primary Contact Name")]
		[AttributeLogicalName("address1_primarycontactname")]
		public string Address1PrimaryContactName
		{	
			get { return GetAttributeValue<string>("address1_primarycontactname"); }
			set
			{ 
				if(Attributes.ContainsKey("address1_primarycontactname") && value == Address1PrimaryContactName) return;
				SetAttributeValue("address1_primarycontactname", value);
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
				if(Attributes.ContainsKey("address1_shippingmethodcode") && value == Address1ShippingMethod) return;

				OptionSetValue optionSetValue = null;
				if(value != null) optionSetValue = new OptionSetValue((int)value);
				SetAttributeValue("address1_shippingmethodcode", optionSetValue); 
			}
		}

		/// <summary>
        /// address1_stateorprovince
        /// </summary>
		[DisplayName("Address 1: State/Province")]
		[AttributeLogicalName("address1_stateorprovince")]
		public string Address1StateProvince
		{	
			get { return GetAttributeValue<string>("address1_stateorprovince"); }
			set
			{ 
				if(Attributes.ContainsKey("address1_stateorprovince") && value == Address1StateProvince) return;
				SetAttributeValue("address1_stateorprovince", value);
			}
		}	
			
		/// <summary>
        /// address1_telephone1
        /// </summary>
		[DisplayName("Address Phone")]
		[AttributeLogicalName("address1_telephone1")]
		public string AddressPhone
		{	
			get { return GetAttributeValue<string>("address1_telephone1"); }
			set
			{ 
				if(Attributes.ContainsKey("address1_telephone1") && value == AddressPhone) return;
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
				if(Attributes.ContainsKey("address1_telephone2") && value == Address1Telephone2) return;
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
				if(Attributes.ContainsKey("address1_telephone3") && value == Address1Telephone3) return;
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
				if(Attributes.ContainsKey("address1_upszone") && value == Address1UPSZone) return;
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
				if(Attributes.ContainsKey("address1_utcoffset") && value == Address1UTCOffset) return;
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
				if(Attributes.ContainsKey("address2_addressid") && value == Address2Id) return;
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
				if(Attributes.ContainsKey("address2_addresstypecode") && value == Address2AddressType) return;

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
				if(Attributes.ContainsKey("address2_city") && value == Address2City) return;
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
				if(Attributes.ContainsKey("address2_composite") && value == Address2) return;
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
				if(Attributes.ContainsKey("address2_country") && value == Address2CountryRegion) return;
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
				if(Attributes.ContainsKey("address2_county") && value == Address2County) return;
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
				if(Attributes.ContainsKey("address2_fax") && value == Address2Fax) return;
				SetAttributeValue("address2_fax", value);
			}
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
				if(Attributes.ContainsKey("address2_freighttermscode") && value == Address2FreightTerms) return;

				OptionSetValue optionSetValue = null;
				if(value != null) optionSetValue = new OptionSetValue((int)value);
				SetAttributeValue("address2_freighttermscode", optionSetValue); 
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
				if(Attributes.ContainsKey("address2_latitude") && doubleValue == Address2Latitude) return;
				SetAttributeValue("address2_latitude", doubleValue);  
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
				if(Attributes.ContainsKey("address2_line1") && value == Address2Street1) return;
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
				if(Attributes.ContainsKey("address2_line2") && value == Address2Street2) return;
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
				if(Attributes.ContainsKey("address2_line3") && value == Address2Street3) return;
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
				if(Attributes.ContainsKey("address2_longitude") && doubleValue == Address2Longitude) return;
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
				if(Attributes.ContainsKey("address2_name") && value == Address2Name) return;
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
				if(Attributes.ContainsKey("address2_postalcode") && value == Address2ZIPPostalCode) return;
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
				if(Attributes.ContainsKey("address2_postofficebox") && value == Address2PostOfficeBox) return;
				SetAttributeValue("address2_postofficebox", value);
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
			set
			{ 
				if(Attributes.ContainsKey("address2_primarycontactname") && value == Address2PrimaryContactName) return;
				SetAttributeValue("address2_primarycontactname", value);
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
				if(Attributes.ContainsKey("address2_shippingmethodcode") && value == Address2ShippingMethod) return;

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
				if(Attributes.ContainsKey("address2_stateorprovince") && value == Address2StateProvince) return;
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
				if(Attributes.ContainsKey("address2_telephone1") && value == Address2Telephone1) return;
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
				if(Attributes.ContainsKey("address2_telephone2") && value == Address2Telephone2) return;
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
				if(Attributes.ContainsKey("address2_telephone3") && value == Address2Telephone3) return;
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
				if(Attributes.ContainsKey("address2_upszone") && value == Address2UPSZone) return;
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
				if(Attributes.ContainsKey("address2_utcoffset") && value == Address2UTCOffset) return;
				SetAttributeValue("address2_utcoffset", value);
			}
		}	
			
		/// <summary>
        /// adx_createdbyipaddress
        /// </summary>
		[DisplayName("Created By (IP Address)")]
		[AttributeLogicalName("adx_createdbyipaddress")]
		public string CreatedByIPAddress
		{	
			get { return GetAttributeValue<string>("adx_createdbyipaddress"); }
			set
			{ 
				if(Attributes.ContainsKey("adx_createdbyipaddress") && value == CreatedByIPAddress) return;
				SetAttributeValue("adx_createdbyipaddress", value);
			}
		}	
			
		/// <summary>
        /// adx_createdbyusername
        /// </summary>
		[DisplayName("Created By (User Name)")]
		[AttributeLogicalName("adx_createdbyusername")]
		public string CreatedByUserName
		{	
			get { return GetAttributeValue<string>("adx_createdbyusername"); }
			set
			{ 
				if(Attributes.ContainsKey("adx_createdbyusername") && value == CreatedByUserName) return;
				SetAttributeValue("adx_createdbyusername", value);
			}
		}	
			
		/// <summary>
        /// adx_modifiedbyipaddress
        /// </summary>
		[DisplayName("Modified By (IP Address)")]
		[AttributeLogicalName("adx_modifiedbyipaddress")]
		public string ModifiedByIPAddress
		{	
			get { return GetAttributeValue<string>("adx_modifiedbyipaddress"); }
			set
			{ 
				if(Attributes.ContainsKey("adx_modifiedbyipaddress") && value == ModifiedByIPAddress) return;
				SetAttributeValue("adx_modifiedbyipaddress", value);
			}
		}	
			
		/// <summary>
        /// adx_modifiedbyusername
        /// </summary>
		[DisplayName("Modified By (User Name)")]
		[AttributeLogicalName("adx_modifiedbyusername")]
		public string ModifiedByUserName
		{	
			get { return GetAttributeValue<string>("adx_modifiedbyusername"); }
			set
			{ 
				if(Attributes.ContainsKey("adx_modifiedbyusername") && value == ModifiedByUserName) return;
				SetAttributeValue("adx_modifiedbyusername", value);
			}
		}	
			
		/// <summary>
        /// aging30
		///
		/// Precision: 2
		/// MaxValue: 100000000000000
		/// MinValue: 0
        /// </summary>
		[DisplayName("Aging 30")]
		[AttributeLogicalName("aging30")]
		public decimal? Aging30
		{	
			get { return GetAttributeValue<Money>("aging30")?.Value; }
			set 
			{
				Money moneyValue = null;
				if(value != null) 
				{
					var roundedValue = Decimal.Round(value.Value, 2);
					moneyValue = new Money(roundedValue);
				}

				if(Attributes.ContainsKey("aging30") && moneyValue?.Value == Aging30) return;
				SetAttributeValue("aging30", moneyValue);  
			}
		}

		/// <summary>
        /// aging60
		///
		/// Precision: 2
		/// MaxValue: 100000000000000
		/// MinValue: 0
        /// </summary>
		[DisplayName("Aging 60")]
		[AttributeLogicalName("aging60")]
		public decimal? Aging60
		{	
			get { return GetAttributeValue<Money>("aging60")?.Value; }
			set 
			{
				Money moneyValue = null;
				if(value != null) 
				{
					var roundedValue = Decimal.Round(value.Value, 2);
					moneyValue = new Money(roundedValue);
				}

				if(Attributes.ContainsKey("aging60") && moneyValue?.Value == Aging60) return;
				SetAttributeValue("aging60", moneyValue);  
			}
		}

		/// <summary>
        /// aging90
		///
		/// Precision: 2
		/// MaxValue: 100000000000000
		/// MinValue: 0
        /// </summary>
		[DisplayName("Aging 90")]
		[AttributeLogicalName("aging90")]
		public decimal? Aging90
		{	
			get { return GetAttributeValue<Money>("aging90")?.Value; }
			set 
			{
				Money moneyValue = null;
				if(value != null) 
				{
					var roundedValue = Decimal.Round(value.Value, 2);
					moneyValue = new Money(roundedValue);
				}

				if(Attributes.ContainsKey("aging90") && moneyValue?.Value == Aging90) return;
				SetAttributeValue("aging90", moneyValue);  
			}
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
				if(Attributes.ContainsKey("businesstypecode") && value == BusinessType) return;

				OptionSetValue optionSetValue = null;
				if(value != null) optionSetValue = new OptionSetValue((int)value);
				SetAttributeValue("businesstypecode", optionSetValue); 
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
        /// createdbyexternalparty
        /// </summary>
		[DisplayName("Created By (External Party)")]
		[AttributeLogicalName("createdbyexternalparty")]
		public EntityReference CreatedByExternalParty
		{	
			get { return GetAttributeValue<EntityReference>("createdbyexternalparty"); }
			set
			{ 
				if(Attributes.ContainsKey("createdbyexternalparty") && value == CreatedByExternalParty) return;
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
				if(Attributes.ContainsKey("createdbyexternalpartyname") && value == Createdbyexternalpartyname) return;
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
				if(Attributes.ContainsKey("createdbyexternalpartyyominame") && value == Createdbyexternalpartyyominame) return;
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
        /// creditlimit
		///
		/// Precision: 2
		/// MaxValue: 100000000000000
		/// MinValue: 0
        /// </summary>
		[DisplayName("Credit Limit")]
		[AttributeLogicalName("creditlimit")]
		public decimal? CreditLimit
		{	
			get { return GetAttributeValue<Money>("creditlimit")?.Value; }
			set 
			{
				Money moneyValue = null;
				if(value != null) 
				{
					var roundedValue = Decimal.Round(value.Value, 2);
					moneyValue = new Money(roundedValue);
				}

				if(Attributes.ContainsKey("creditlimit") && moneyValue?.Value == CreditLimit) return;
				SetAttributeValue("creditlimit", moneyValue);  
			}
		}

		/// <summary>
        /// creditonhold
        /// </summary>
		[DisplayName("Credit Hold")]
		[AttributeLogicalName("creditonhold")]
		public bool? CreditHold
		{	
			get { return GetAttributeValue<bool?>("creditonhold"); }
			set
			{ 
				if(Attributes.ContainsKey("creditonhold") && value == CreditHold) return;
				SetAttributeValue("creditonhold", value);
			}
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
				if(Attributes.ContainsKey("customersizecode") && value == CustomerSize) return;

				OptionSetValue optionSetValue = null;
				if(value != null) optionSetValue = new OptionSetValue((int)value);
				SetAttributeValue("customersizecode", optionSetValue); 
			}
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
				if(Attributes.ContainsKey("customertypecode") && value == RelationshipType) return;

				OptionSetValue optionSetValue = null;
				if(value != null) optionSetValue = new OptionSetValue((int)value);
				SetAttributeValue("customertypecode", optionSetValue); 
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
        /// donotbulkemail
        /// </summary>
		[DisplayName("Do not allow Bulk Emails")]
		[AttributeLogicalName("donotbulkemail")]
		public bool? DoNotAllowBulkEmails
		{	
			get { return GetAttributeValue<bool?>("donotbulkemail"); }
			set
			{ 
				if(Attributes.ContainsKey("donotbulkemail") && value == DoNotAllowBulkEmails) return;
				SetAttributeValue("donotbulkemail", value);
			}
		}	
			
		/// <summary>
        /// donotbulkpostalmail
        /// </summary>
		[DisplayName("Do not allow Bulk Mails")]
		[AttributeLogicalName("donotbulkpostalmail")]
		public bool? DoNotAllowBulkMails
		{	
			get { return GetAttributeValue<bool?>("donotbulkpostalmail"); }
			set
			{ 
				if(Attributes.ContainsKey("donotbulkpostalmail") && value == DoNotAllowBulkMails) return;
				SetAttributeValue("donotbulkpostalmail", value);
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
				if(Attributes.ContainsKey("donotemail") && value == DoNotAllowEmails) return;
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
				if(Attributes.ContainsKey("donotfax") && value == DoNotAllowFaxes) return;
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
				if(Attributes.ContainsKey("donotphone") && value == DoNotAllowPhoneCalls) return;
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
				if(Attributes.ContainsKey("donotpostalmail") && value == DoNotAllowMails) return;
				SetAttributeValue("donotpostalmail", value);
			}
		}	
			
		/// <summary>
        /// donotsendmm
        /// </summary>
		[DisplayName("Send Marketing Materials")]
		[AttributeLogicalName("donotsendmm")]
		public bool? SendMarketingMaterials
		{	
			get { return GetAttributeValue<bool?>("donotsendmm"); }
			set
			{ 
				if(Attributes.ContainsKey("donotsendmm") && value == SendMarketingMaterials) return;
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
				if(Attributes.ContainsKey("emailaddress1") && value == Email) return;
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
				if(Attributes.ContainsKey("emailaddress2") && value == EmailAddress2) return;
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
				if(Attributes.ContainsKey("emailaddress3") && value == EmailAddress3) return;
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
				if(Attributes.ContainsKey("entityimage_timestamp") && value == EntityimageTimestamp) return;
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
				if(Attributes.ContainsKey("entityimage_url") && value == EntityimageUrl) return;
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
				if(Attributes.ContainsKey("entityimageid") && value == EntityImageId) return;
				SetAttributeValue("entityimageid", value);
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
        /// fax
        /// </summary>
		[DisplayName("Fax")]
		[AttributeLogicalName("fax")]
		public string Fax
		{	
			get { return GetAttributeValue<string>("fax"); }
			set
			{ 
				if(Attributes.ContainsKey("fax") && value == Fax) return;
				SetAttributeValue("fax", value);
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
				if(Attributes.ContainsKey("followemail") && value == FollowEmailActivity) return;
				SetAttributeValue("followemail", value);
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
				if(Attributes.ContainsKey("ftpsiteurl") && value == FTPSite) return;
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
				if(Attributes.ContainsKey("importsequencenumber") && value == ImportSequenceNumber) return;
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
				if(Attributes.ContainsKey("industrycode") && value == Industry) return;

				OptionSetValue optionSetValue = null;
				if(value != null) optionSetValue = new OptionSetValue((int)value);
				SetAttributeValue("industrycode", optionSetValue); 
			}
		}

		/// <summary>
        /// isprivate
        /// </summary>
		[DisplayName("isprivate")]
		[AttributeLogicalName("isprivate")]
		public bool? Isprivate
		{	
			get { return GetAttributeValue<bool?>("isprivate"); }
			set
			{ 
				if(Attributes.ContainsKey("isprivate") && value == Isprivate) return;
				SetAttributeValue("isprivate", value);
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
        /// lastusedincampaign
        /// </summary>
		[DisplayName("Last Date Included in Campaign")]
		[AttributeLogicalName("lastusedincampaign")]
		public DateTime? LastDateIncludedInCampaign
		{	
			get { return GetAttributeValue<DateTime?>("lastusedincampaign"); }
			set
			{ 
				if(Attributes.ContainsKey("lastusedincampaign") && value == LastDateIncludedInCampaign) return;
				SetAttributeValue("lastusedincampaign", value);
			}
		}	
			
		/// <summary>
        /// marketcap
		///
		/// Precision: 2
		/// MaxValue: 100000000000000
		/// MinValue: 0
        /// </summary>
		[DisplayName("Market Capitalization")]
		[AttributeLogicalName("marketcap")]
		public decimal? MarketCapitalization
		{	
			get { return GetAttributeValue<Money>("marketcap")?.Value; }
			set 
			{
				Money moneyValue = null;
				if(value != null) 
				{
					var roundedValue = Decimal.Round(value.Value, 2);
					moneyValue = new Money(roundedValue);
				}

				if(Attributes.ContainsKey("marketcap") && moneyValue?.Value == MarketCapitalization) return;
				SetAttributeValue("marketcap", moneyValue);  
			}
		}

		/// <summary>
        /// marketingonly
        /// </summary>
		[DisplayName("Marketing Only")]
		[AttributeLogicalName("marketingonly")]
		public bool? MarketingOnly
		{	
			get { return GetAttributeValue<bool?>("marketingonly"); }
			set
			{ 
				if(Attributes.ContainsKey("marketingonly") && value == MarketingOnly) return;
				SetAttributeValue("marketingonly", value);
			}
		}	
			
		/// <summary>
        /// masteraccountidname
        /// </summary>
		[DisplayName("masteraccountidname")]
		[AttributeLogicalName("masteraccountidname")]
		public string Masteraccountidname
		{	
			get { return GetAttributeValue<string>("masteraccountidname"); }
			set
			{ 
				if(Attributes.ContainsKey("masteraccountidname") && value == Masteraccountidname) return;
				SetAttributeValue("masteraccountidname", value);
			}
		}	
			
		/// <summary>
        /// masteraccountidyominame
        /// </summary>
		[DisplayName("masteraccountidyominame")]
		[AttributeLogicalName("masteraccountidyominame")]
		public string Masteraccountidyominame
		{	
			get { return GetAttributeValue<string>("masteraccountidyominame"); }
			set
			{ 
				if(Attributes.ContainsKey("masteraccountidyominame") && value == Masteraccountidyominame) return;
				SetAttributeValue("masteraccountidyominame", value);
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
				if(Attributes.ContainsKey("masterid") && value == MasterID) return;
				SetAttributeValue("masterid", value);
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
				if(Attributes.ContainsKey("merged") && value == Merged) return;
				SetAttributeValue("merged", value);
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
        /// modifiedbyexternalparty
        /// </summary>
		[DisplayName("Modified By (External Party)")]
		[AttributeLogicalName("modifiedbyexternalparty")]
		public EntityReference ModifiedByExternalParty
		{	
			get { return GetAttributeValue<EntityReference>("modifiedbyexternalparty"); }
			set
			{ 
				if(Attributes.ContainsKey("modifiedbyexternalparty") && value == ModifiedByExternalParty) return;
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
				if(Attributes.ContainsKey("modifiedbyexternalpartyname") && value == Modifiedbyexternalpartyname) return;
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
				if(Attributes.ContainsKey("modifiedbyexternalpartyyominame") && value == Modifiedbyexternalpartyyominame) return;
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
        /// msa_managingpartnerid
        /// </summary>
		[DisplayName("Managing Partner")]
		[AttributeLogicalName("msa_managingpartnerid")]
		public EntityReference ManagingPartner
		{	
			get { return GetAttributeValue<EntityReference>("msa_managingpartnerid"); }
			set
			{ 
				if(Attributes.ContainsKey("msa_managingpartnerid") && value == ManagingPartner) return;
				SetAttributeValue("msa_managingpartnerid", value);
			}
		}	
			
		/// <summary>
        /// msa_managingpartneridname
        /// </summary>
		[DisplayName("msa_managingpartneridname")]
		[AttributeLogicalName("msa_managingpartneridname")]
		public string MsaManagingpartneridname
		{	
			get { return GetAttributeValue<string>("msa_managingpartneridname"); }
			set
			{ 
				if(Attributes.ContainsKey("msa_managingpartneridname") && value == MsaManagingpartneridname) return;
				SetAttributeValue("msa_managingpartneridname", value);
			}
		}	
			
		/// <summary>
        /// msa_managingpartneridyominame
        /// </summary>
		[DisplayName("msa_managingpartneridyominame")]
		[AttributeLogicalName("msa_managingpartneridyominame")]
		public string MsaManagingpartneridyominame
		{	
			get { return GetAttributeValue<string>("msa_managingpartneridyominame"); }
			set
			{ 
				if(Attributes.ContainsKey("msa_managingpartneridyominame") && value == MsaManagingpartneridyominame) return;
				SetAttributeValue("msa_managingpartneridyominame", value);
			}
		}	
			
		/// <summary>
        /// name
        /// </summary>
		[DisplayName("Account Name")]
		[AttributeLogicalName("name")]
		public string AccountName
		{	
			get { return GetAttributeValue<string>("name"); }
			set
			{ 
				if(Attributes.ContainsKey("name") && value == AccountName) return;
				SetAttributeValue("name", value);
			}
		}	
			
		/// <summary>
        /// numberofemployees
        /// </summary>
		[DisplayName("Number of Employees")]
		[AttributeLogicalName("numberofemployees")]
		public int? NumberOfEmployees
		{	
			get { return GetAttributeValue<int?>("numberofemployees"); }
			set
			{ 
				if(Attributes.ContainsKey("numberofemployees") && value == NumberOfEmployees) return;
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
				if(Attributes.ContainsKey("onholdtime") && value == OnHoldTimeMinutes) return;
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
				if(Attributes.ContainsKey("ownershipcode") && value == Ownership) return;

				OptionSetValue optionSetValue = null;
				if(value != null) optionSetValue = new OptionSetValue((int)value);
				SetAttributeValue("ownershipcode", optionSetValue); 
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
        /// parentaccountid
        /// </summary>
		[DisplayName("Parent Account")]
		[AttributeLogicalName("parentaccountid")]
		public EntityReference ParentAccount
		{	
			get { return GetAttributeValue<EntityReference>("parentaccountid"); }
			set
			{ 
				if(Attributes.ContainsKey("parentaccountid") && value == ParentAccount) return;
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
				if(Attributes.ContainsKey("parentaccountidname") && value == Parentaccountidname) return;
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
				if(Attributes.ContainsKey("parentaccountidyominame") && value == Parentaccountidyominame) return;
				SetAttributeValue("parentaccountidyominame", value);
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
				if(Attributes.ContainsKey("participatesinworkflow") && value == ParticipatesInWorkflow) return;
				SetAttributeValue("participatesinworkflow", value);
			}
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
				if(Attributes.ContainsKey("paymenttermscode") && value == PaymentTerms) return;

				OptionSetValue optionSetValue = null;
				if(value != null) optionSetValue = new OptionSetValue((int)value);
				SetAttributeValue("paymenttermscode", optionSetValue); 
			}
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
				if(Attributes.ContainsKey("preferredappointmentdaycode") && value == PreferredDay) return;

				OptionSetValue optionSetValue = null;
				if(value != null) optionSetValue = new OptionSetValue((int)value);
				SetAttributeValue("preferredappointmentdaycode", optionSetValue); 
			}
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
				if(Attributes.ContainsKey("preferredappointmenttimecode") && value == PreferredTime) return;

				OptionSetValue optionSetValue = null;
				if(value != null) optionSetValue = new OptionSetValue((int)value);
				SetAttributeValue("preferredappointmenttimecode", optionSetValue); 
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
				if(Attributes.ContainsKey("preferredcontactmethodcode") && value == PreferredMethodOfContact) return;

				OptionSetValue optionSetValue = null;
				if(value != null) optionSetValue = new OptionSetValue((int)value);
				SetAttributeValue("preferredcontactmethodcode", optionSetValue); 
			}
		}

		/// <summary>
        /// preferredsystemuserid
        /// </summary>
		[DisplayName("Preferred User")]
		[AttributeLogicalName("preferredsystemuserid")]
		public EntityReference PreferredUser
		{	
			get { return GetAttributeValue<EntityReference>("preferredsystemuserid"); }
			set
			{ 
				if(Attributes.ContainsKey("preferredsystemuserid") && value == PreferredUser) return;
				SetAttributeValue("preferredsystemuserid", value);
			}
		}	
			
		/// <summary>
        /// preferredsystemuseridname
        /// </summary>
		[DisplayName("preferredsystemuseridname")]
		[AttributeLogicalName("preferredsystemuseridname")]
		public string Preferredsystemuseridname
		{	
			get { return GetAttributeValue<string>("preferredsystemuseridname"); }
			set
			{ 
				if(Attributes.ContainsKey("preferredsystemuseridname") && value == Preferredsystemuseridname) return;
				SetAttributeValue("preferredsystemuseridname", value);
			}
		}	
			
		/// <summary>
        /// preferredsystemuseridyominame
        /// </summary>
		[DisplayName("preferredsystemuseridyominame")]
		[AttributeLogicalName("preferredsystemuseridyominame")]
		public string Preferredsystemuseridyominame
		{	
			get { return GetAttributeValue<string>("preferredsystemuseridyominame"); }
			set
			{ 
				if(Attributes.ContainsKey("preferredsystemuseridyominame") && value == Preferredsystemuseridyominame) return;
				SetAttributeValue("preferredsystemuseridyominame", value);
			}
		}	
			
		/// <summary>
        /// primarycontactid
        /// </summary>
		[DisplayName("Primary Contact")]
		[AttributeLogicalName("primarycontactid")]
		public EntityReference PrimaryContact
		{	
			get { return GetAttributeValue<EntityReference>("primarycontactid"); }
			set
			{ 
				if(Attributes.ContainsKey("primarycontactid") && value == PrimaryContact) return;
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
				if(Attributes.ContainsKey("primarycontactidname") && value == Primarycontactidname) return;
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
				if(Attributes.ContainsKey("primarycontactidyominame") && value == Primarycontactidyominame) return;
				SetAttributeValue("primarycontactidyominame", value);
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
			set
			{ 
				if(Attributes.ContainsKey("primarysatoriid") && value == PrimarySatoriID) return;
				SetAttributeValue("primarysatoriid", value);
			}
		}	
			
		/// <summary>
        /// primarytwitterid
        /// </summary>
		[DisplayName("Primary Twitter ID")]
		[AttributeLogicalName("primarytwitterid")]
		public string PrimaryTwitterID
		{	
			get { return GetAttributeValue<string>("primarytwitterid"); }
			set
			{ 
				if(Attributes.ContainsKey("primarytwitterid") && value == PrimaryTwitterID) return;
				SetAttributeValue("primarytwitterid", value);
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
        /// revenue
		///
		/// Precision: 2
		/// MaxValue: 100000000000000
		/// MinValue: 0
        /// </summary>
		[DisplayName("Annual Revenue")]
		[AttributeLogicalName("revenue")]
		public decimal? AnnualRevenue
		{	
			get { return GetAttributeValue<Money>("revenue")?.Value; }
			set 
			{
				Money moneyValue = null;
				if(value != null) 
				{
					var roundedValue = Decimal.Round(value.Value, 2);
					moneyValue = new Money(roundedValue);
				}

				if(Attributes.ContainsKey("revenue") && moneyValue?.Value == AnnualRevenue) return;
				SetAttributeValue("revenue", moneyValue);  
			}
		}

		/// <summary>
        /// sharesoutstanding
        /// </summary>
		[DisplayName("Shares Outstanding")]
		[AttributeLogicalName("sharesoutstanding")]
		public int? SharesOutstanding
		{	
			get { return GetAttributeValue<int?>("sharesoutstanding"); }
			set
			{ 
				if(Attributes.ContainsKey("sharesoutstanding") && value == SharesOutstanding) return;
				SetAttributeValue("sharesoutstanding", value);
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
				if(Attributes.ContainsKey("shippingmethodcode") && value == ShippingMethod) return;

				OptionSetValue optionSetValue = null;
				if(value != null) optionSetValue = new OptionSetValue((int)value);
				SetAttributeValue("shippingmethodcode", optionSetValue); 
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
				if(Attributes.ContainsKey("sic") && value == SICCode) return;
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
				if(Attributes.ContainsKey("statecode") && value == Status) return;

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
        /// stockexchange
        /// </summary>
		[DisplayName("Stock Exchange")]
		[AttributeLogicalName("stockexchange")]
		public string StockExchange
		{	
			get { return GetAttributeValue<string>("stockexchange"); }
			set
			{ 
				if(Attributes.ContainsKey("stockexchange") && value == StockExchange) return;
				SetAttributeValue("stockexchange", value);
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
			set
			{ 
				if(Attributes.ContainsKey("telephone1") && value == MainPhone) return;
				SetAttributeValue("telephone1", value);
			}
		}	
			
		/// <summary>
        /// telephone2
        /// </summary>
		[DisplayName("Other Phone")]
		[AttributeLogicalName("telephone2")]
		public string OtherPhone
		{	
			get { return GetAttributeValue<string>("telephone2"); }
			set
			{ 
				if(Attributes.ContainsKey("telephone2") && value == OtherPhone) return;
				SetAttributeValue("telephone2", value);
			}
		}	
			
		/// <summary>
        /// telephone3
        /// </summary>
		[DisplayName("Telephone 3")]
		[AttributeLogicalName("telephone3")]
		public string Telephone3
		{	
			get { return GetAttributeValue<string>("telephone3"); }
			set
			{ 
				if(Attributes.ContainsKey("telephone3") && value == Telephone3) return;
				SetAttributeValue("telephone3", value);
			}
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
				if(Attributes.ContainsKey("territorycode") && value == TerritoryCode) return;

				OptionSetValue optionSetValue = null;
				if(value != null) optionSetValue = new OptionSetValue((int)value);
				SetAttributeValue("territorycode", optionSetValue); 
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
				if(Attributes.ContainsKey("tickersymbol") && value == TickerSymbol) return;
				SetAttributeValue("tickersymbol", value);
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
				if(Attributes.ContainsKey("timespentbymeonemailandmeetings") && value == TimeSpentByMe) return;
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
				if(Attributes.ContainsKey("timezoneruleversionnumber") && value == TimeZoneRuleVersionNumber) return;
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
				if(Attributes.ContainsKey("websiteurl") && value == Website) return;
				SetAttributeValue("websiteurl", value);
			}
		}	
			
		/// <summary>
        /// yominame
        /// </summary>
		[DisplayName("Yomi Account Name")]
		[AttributeLogicalName("yominame")]
		public string YomiAccountName
		{	
			get { return GetAttributeValue<string>("yominame"); }
			set
			{ 
				if(Attributes.ContainsKey("yominame") && value == YomiAccountName) return;
				SetAttributeValue("yominame", value);
			}
		}	
			
		#endregion	

		#region Relations
			/// <summary>
        /// 1:N Get entities for 'account_activity_parties'
        /// </summary>
		[RelationshipSchemaName("account_activity_parties")]
		public IEnumerable<ActivityParty> AccountActivityParties
		{
			get { return GetRelatedEntities<ActivityParty>("account_activity_parties", null); }
			set { SetRelatedEntities("account_activity_parties", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'Account_AsyncOperations'
        /// </summary>
		[RelationshipSchemaName("Account_AsyncOperations")]
		public IEnumerable<SystemJob> AccountAsyncOperations
		{
			get { return GetRelatedEntities<SystemJob>("Account_AsyncOperations", null); }
			set { SetRelatedEntities("Account_AsyncOperations", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'Account_Email_EmailSender'
        /// </summary>
		[RelationshipSchemaName("Account_Email_EmailSender")]
		public IEnumerable<Email> AccountEmailEmailSender
		{
			get { return GetRelatedEntities<Email>("Account_Email_EmailSender", null); }
			set { SetRelatedEntities("Account_Email_EmailSender", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'Account_Email_SendersAccount'
        /// </summary>
		[RelationshipSchemaName("Account_Email_SendersAccount")]
		public IEnumerable<Email> AccountEmailSendersAccount
		{
			get { return GetRelatedEntities<Email>("Account_Email_SendersAccount", null); }
			set { SetRelatedEntities("Account_Email_SendersAccount", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'Account_Emails'
        /// </summary>
		[RelationshipSchemaName("Account_Emails")]
		public IEnumerable<Email> AccountEmails
		{
			get { return GetRelatedEntities<Email>("Account_Emails", null); }
			set { SetRelatedEntities("Account_Emails", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'account_master_account'
        /// </summary>
		[RelationshipSchemaName("account_master_account")]
		public IEnumerable<Account> AccountMasterAccount
		{
			get { return GetRelatedEntities<Account>("account_master_account", null); }
			set { SetRelatedEntities("account_master_account", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'account_parent_account'
        /// </summary>
		[RelationshipSchemaName("account_parent_account")]
		public IEnumerable<Account> AccountParentAccount
		{
			get { return GetRelatedEntities<Account>("account_parent_account", null); }
			set { SetRelatedEntities("account_parent_account", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'msa_account_managingpartner'
        /// </summary>
		[RelationshipSchemaName("msa_account_managingpartner")]
		public IEnumerable<Account> MsaAccountManagingpartner
		{
			get { return GetRelatedEntities<Account>("msa_account_managingpartner", null); }
			set { SetRelatedEntities("msa_account_managingpartner", null, value); }
		}
		#endregion

		#region Actions
		#endregion

		#region OptionSetEnums
		public enum eCategory
		{	
		
			[Label("Preferred Customer")]
			[Description(@"")]
			PreferredCustomer = 1, 
		
			[Label("Standard")]
			[Description(@"")]
			Standard = 2, 
		}
		
		public enum eClassification
		{	
		
			[Label("Default Value")]
			[Description(@"")]
			DefaultValue = 1, 
		}
		
		public enum eAccountRating
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
		
		public enum eAddress1FreightTerms
		{	
		
			[Label("FOB")]
			[Description(@"")]
			FOB = 1, 
		
			[Label("No Charge")]
			[Description(@"")]
			NoCharge = 2, 
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
		
		public enum eAddress2AddressType
		{	
		
			[Label("Default Value")]
			[Description(@"")]
			DefaultValue = 1, 
		}
		
		public enum eAddress2FreightTerms
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
		
		public enum eBusinessType
		{	
		
			[Label("Default Value")]
			[Description(@"")]
			DefaultValue = 1, 
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
		
		public enum eShippingMethod
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
		
		public enum eStatusReason
		{	
		
			[Label("Active")]
			[Description(@"")]
			Active_Active = 1, 
		
			[Label("Inactive")]
			[Description(@"")]
			Inactive_Inactive = 2, 
		}
		
		public enum eTerritoryCode
		{	
		
			[Label("Default Value")]
			[Description(@"")]
			DefaultValue = 1, 
		}
		
		#endregion	

		#region Properties
		public static class Properties 
		{
			/// <summary>accountcategorycode</summary>
			public const string Category = "accountcategorycode";

			/// <summary>accountclassificationcode</summary>
			public const string Classification = "accountclassificationcode";

			/// <summary>accountid</summary>
			public const string AccountId = "accountid";

			/// <summary>accountnumber</summary>
			public const string AccountNumber = "accountnumber";

			/// <summary>accountratingcode</summary>
			public const string AccountRating = "accountratingcode";

			/// <summary>address1_addressid</summary>
			public const string Address1Id = "address1_addressid";

			/// <summary>address1_addresstypecode</summary>
			public const string Address1AddressType = "address1_addresstypecode";

			/// <summary>address1_city</summary>
			public const string Address1City = "address1_city";

			/// <summary>address1_composite</summary>
			public const string Address1 = "address1_composite";

			/// <summary>address1_country</summary>
			public const string Address1CountryRegion = "address1_country";

			/// <summary>address1_county</summary>
			public const string Address1County = "address1_county";

			/// <summary>address1_fax</summary>
			public const string Address1Fax = "address1_fax";

			/// <summary>address1_freighttermscode</summary>
			public const string Address1FreightTerms = "address1_freighttermscode";

			/// <summary>address1_latitude</summary>
			public const string Address1Latitude = "address1_latitude";

			/// <summary>address1_line1</summary>
			public const string Address1Street1 = "address1_line1";

			/// <summary>address1_line2</summary>
			public const string Address1Street2 = "address1_line2";

			/// <summary>address1_line3</summary>
			public const string Address1Street3 = "address1_line3";

			/// <summary>address1_longitude</summary>
			public const string Address1Longitude = "address1_longitude";

			/// <summary>address1_name</summary>
			public const string Address1Name = "address1_name";

			/// <summary>address1_postalcode</summary>
			public const string Address1ZIPPostalCode = "address1_postalcode";

			/// <summary>address1_postofficebox</summary>
			public const string Address1PostOfficeBox = "address1_postofficebox";

			/// <summary>address1_primarycontactname</summary>
			public const string Address1PrimaryContactName = "address1_primarycontactname";

			/// <summary>address1_shippingmethodcode</summary>
			public const string Address1ShippingMethod = "address1_shippingmethodcode";

			/// <summary>address1_stateorprovince</summary>
			public const string Address1StateProvince = "address1_stateorprovince";

			/// <summary>address1_telephone1</summary>
			public const string AddressPhone = "address1_telephone1";

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

			/// <summary>address2_freighttermscode</summary>
			public const string Address2FreightTerms = "address2_freighttermscode";

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

			/// <summary>address2_primarycontactname</summary>
			public const string Address2PrimaryContactName = "address2_primarycontactname";

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

			/// <summary>adx_createdbyipaddress</summary>
			public const string CreatedByIPAddress = "adx_createdbyipaddress";

			/// <summary>adx_createdbyusername</summary>
			public const string CreatedByUserName = "adx_createdbyusername";

			/// <summary>adx_modifiedbyipaddress</summary>
			public const string ModifiedByIPAddress = "adx_modifiedbyipaddress";

			/// <summary>adx_modifiedbyusername</summary>
			public const string ModifiedByUserName = "adx_modifiedbyusername";

			/// <summary>aging30</summary>
			public const string Aging30 = "aging30";

			/// <summary>aging60</summary>
			public const string Aging60 = "aging60";

			/// <summary>aging90</summary>
			public const string Aging90 = "aging90";

			/// <summary>businesstypecode</summary>
			public const string BusinessType = "businesstypecode";

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

			/// <summary>creditlimit</summary>
			public const string CreditLimit = "creditlimit";

			/// <summary>creditonhold</summary>
			public const string CreditHold = "creditonhold";

			/// <summary>customersizecode</summary>
			public const string CustomerSize = "customersizecode";

			/// <summary>customertypecode</summary>
			public const string RelationshipType = "customertypecode";

			/// <summary>description</summary>
			public const string Description = "description";

			/// <summary>donotbulkemail</summary>
			public const string DoNotAllowBulkEmails = "donotbulkemail";

			/// <summary>donotbulkpostalmail</summary>
			public const string DoNotAllowBulkMails = "donotbulkpostalmail";

			/// <summary>donotemail</summary>
			public const string DoNotAllowEmails = "donotemail";

			/// <summary>donotfax</summary>
			public const string DoNotAllowFaxes = "donotfax";

			/// <summary>donotphone</summary>
			public const string DoNotAllowPhoneCalls = "donotphone";

			/// <summary>donotpostalmail</summary>
			public const string DoNotAllowMails = "donotpostalmail";

			/// <summary>donotsendmm</summary>
			public const string SendMarketingMaterials = "donotsendmm";

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
			public const string EntityImageId = "entityimageid";

			/// <summary>exchangerate</summary>
			public const string ExchangeRate = "exchangerate";

			/// <summary>fax</summary>
			public const string Fax = "fax";

			/// <summary>followemail</summary>
			public const string FollowEmailActivity = "followemail";

			/// <summary>ftpsiteurl</summary>
			public const string FTPSite = "ftpsiteurl";

			/// <summary>importsequencenumber</summary>
			public const string ImportSequenceNumber = "importsequencenumber";

			/// <summary>industrycode</summary>
			public const string Industry = "industrycode";

			/// <summary>isprivate</summary>
			public const string Isprivate = "isprivate";

			/// <summary>lastonholdtime</summary>
			public const string LastOnHoldTime = "lastonholdtime";

			/// <summary>lastusedincampaign</summary>
			public const string LastDateIncludedInCampaign = "lastusedincampaign";

			/// <summary>marketcap</summary>
			public const string MarketCapitalization = "marketcap";

			/// <summary>marketingonly</summary>
			public const string MarketingOnly = "marketingonly";

			/// <summary>masteraccountidname</summary>
			public const string Masteraccountidname = "masteraccountidname";

			/// <summary>masteraccountidyominame</summary>
			public const string Masteraccountidyominame = "masteraccountidyominame";

			/// <summary>masterid</summary>
			public const string MasterID = "masterid";

			/// <summary>merged</summary>
			public const string Merged = "merged";

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

			/// <summary>msa_managingpartnerid</summary>
			public const string ManagingPartner = "msa_managingpartnerid";

			/// <summary>msa_managingpartneridname</summary>
			public const string MsaManagingpartneridname = "msa_managingpartneridname";

			/// <summary>msa_managingpartneridyominame</summary>
			public const string MsaManagingpartneridyominame = "msa_managingpartneridyominame";

			/// <summary>name</summary>
			public const string AccountName = "name";

			/// <summary>numberofemployees</summary>
			public const string NumberOfEmployees = "numberofemployees";

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

			/// <summary>ownershipcode</summary>
			public const string Ownership = "ownershipcode";

			/// <summary>owningbusinessunit</summary>
			public const string OwningBusinessUnit = "owningbusinessunit";

			/// <summary>owningbusinessunitname</summary>
			public const string Owningbusinessunitname = "owningbusinessunitname";

			/// <summary>owningteam</summary>
			public const string OwningTeam = "owningteam";

			/// <summary>owninguser</summary>
			public const string OwningUser = "owninguser";

			/// <summary>parentaccountid</summary>
			public const string ParentAccount = "parentaccountid";

			/// <summary>parentaccountidname</summary>
			public const string Parentaccountidname = "parentaccountidname";

			/// <summary>parentaccountidyominame</summary>
			public const string Parentaccountidyominame = "parentaccountidyominame";

			/// <summary>participatesinworkflow</summary>
			public const string ParticipatesInWorkflow = "participatesinworkflow";

			/// <summary>paymenttermscode</summary>
			public const string PaymentTerms = "paymenttermscode";

			/// <summary>preferredappointmentdaycode</summary>
			public const string PreferredDay = "preferredappointmentdaycode";

			/// <summary>preferredappointmenttimecode</summary>
			public const string PreferredTime = "preferredappointmenttimecode";

			/// <summary>preferredcontactmethodcode</summary>
			public const string PreferredMethodOfContact = "preferredcontactmethodcode";

			/// <summary>preferredsystemuserid</summary>
			public const string PreferredUser = "preferredsystemuserid";

			/// <summary>preferredsystemuseridname</summary>
			public const string Preferredsystemuseridname = "preferredsystemuseridname";

			/// <summary>preferredsystemuseridyominame</summary>
			public const string Preferredsystemuseridyominame = "preferredsystemuseridyominame";

			/// <summary>primarycontactid</summary>
			public const string PrimaryContact = "primarycontactid";

			/// <summary>primarycontactidname</summary>
			public const string Primarycontactidname = "primarycontactidname";

			/// <summary>primarycontactidyominame</summary>
			public const string Primarycontactidyominame = "primarycontactidyominame";

			/// <summary>primarysatoriid</summary>
			public const string PrimarySatoriID = "primarysatoriid";

			/// <summary>primarytwitterid</summary>
			public const string PrimaryTwitterID = "primarytwitterid";

			/// <summary>processid</summary>
			public const string ProcessId = "processid";

			/// <summary>revenue</summary>
			public const string AnnualRevenue = "revenue";

			/// <summary>sharesoutstanding</summary>
			public const string SharesOutstanding = "sharesoutstanding";

			/// <summary>shippingmethodcode</summary>
			public const string ShippingMethod = "shippingmethodcode";

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
			public const string DeprecatedProcessStageId = "stageid";

			/// <summary>statecode</summary>
			public const string Status = "statecode";

			/// <summary>statuscode</summary>
			public const string StatusReason = "statuscode";

			/// <summary>stockexchange</summary>
			public const string StockExchange = "stockexchange";

			/// <summary>telephone1</summary>
			public const string MainPhone = "telephone1";

			/// <summary>telephone2</summary>
			public const string OtherPhone = "telephone2";

			/// <summary>telephone3</summary>
			public const string Telephone3 = "telephone3";

			/// <summary>territorycode</summary>
			public const string TerritoryCode = "territorycode";

			/// <summary>tickersymbol</summary>
			public const string TickerSymbol = "tickersymbol";

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

			/// <summary>yominame</summary>
			public const string YomiAccountName = "yominame";

		}
		#endregion

		#region Schemas
		public static class Schemas 
		{
			/// <summary>1:N account_activity_parties</summary>
			public const string AccountActivityParties = "account_activity_parties";

			/// <summary>1:N Account_AsyncOperations</summary>
			public const string AccountAsyncOperations = "Account_AsyncOperations";

			/// <summary>1:N Account_Email_EmailSender</summary>
			public const string AccountEmailEmailSender = "Account_Email_EmailSender";

			/// <summary>1:N Account_Email_SendersAccount</summary>
			public const string AccountEmailSendersAccount = "Account_Email_SendersAccount";

			/// <summary>1:N Account_Emails</summary>
			public const string AccountEmails = "Account_Emails";

			/// <summary>1:N account_master_account</summary>
			public const string AccountMasterAccount = "account_master_account";

			/// <summary>1:N account_parent_account</summary>
			public const string AccountParentAccount = "account_parent_account";

			/// <summary>1:N msa_account_managingpartner</summary>
			public const string MsaAccountManagingpartner = "msa_account_managingpartner";

		}
		#endregion
	}
}

