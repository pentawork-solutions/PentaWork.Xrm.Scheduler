using System;
using System.Linq;
using System.Diagnostics;
using System.ComponentModel;
using Microsoft.Xrm.Sdk; 
using Microsoft.Xrm.Sdk.Client;
using System.Collections.Generic;

namespace PentaWork.Xrm.Scheduler.Proxies.Entities
{
	[DebuggerDisplay("{FullName}")] 	
	[EntityLogicalName("contact")]
	public sealed class Contact : Entity
	{	
		public static readonly int? EntityTypeCode = 2;
		public new const string LogicalName = "contact";
		public const string PrimaryIdAttribute = "contactid";
		public const string PrimaryNameAttribute = "fullname";
	
		public Contact() : base("contact") { }

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
        /// accountrolecode
        /// </summary>
		[DisplayName("Role")]
		[AttributeLogicalName("accountrolecode")]
		public eRole? Role
		{	
			get 
			{ 
				var optionSetValue = GetAttributeValue<OptionSetValue>("accountrolecode");
				if (optionSetValue != null) return (eRole)optionSetValue.Value;
				else return null;
			}
			set 
			{ 
				if(value == Role) return;

				OptionSetValue optionSetValue = null;
				if(value != null) optionSetValue = new OptionSetValue((int)value);
				SetAttributeValue("accountrolecode", optionSetValue); 
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
		[DisplayName("Address 1: City")]
		[AttributeLogicalName("address1_city")]
		public string Address1City
		{	
			get { return GetAttributeValue<string>("address1_city"); }
			set
			{ 
				if(value == Address1City) return;
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
		[DisplayName("Address 1: Country/Region")]
		[AttributeLogicalName("address1_country")]
		public string Address1CountryRegion
		{	
			get { return GetAttributeValue<string>("address1_country"); }
			set
			{ 
				if(value == Address1CountryRegion) return;
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
				if(value == Address1FreightTerms) return;

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
				if(doubleValue == Address1Latitude) return;
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
				if(value == Address1Street1) return;
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
				if(value == Address1Street2) return;
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
				if(value == Address1Street3) return;
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
		[DisplayName("Address 1: ZIP/Postal Code")]
		[AttributeLogicalName("address1_postalcode")]
		public string Address1ZIPPostalCode
		{	
			get { return GetAttributeValue<string>("address1_postalcode"); }
			set
			{ 
				if(value == Address1ZIPPostalCode) return;
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
        /// address1_primarycontactname
        /// </summary>
		[DisplayName("Address 1: Primary Contact Name")]
		[AttributeLogicalName("address1_primarycontactname")]
		public string Address1PrimaryContactName
		{	
			get { return GetAttributeValue<string>("address1_primarycontactname"); }
			set
			{ 
				if(value == Address1PrimaryContactName) return;
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
				if(value == Address1ShippingMethod) return;

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
				if(value == Address1StateProvince) return;
				SetAttributeValue("address1_stateorprovince", value);
			}
		}	
			
		/// <summary>
        /// address1_telephone1
        /// </summary>
		[DisplayName("Address 1: Phone")]
		[AttributeLogicalName("address1_telephone1")]
		public string Address1Phone
		{	
			get { return GetAttributeValue<string>("address1_telephone1"); }
			set
			{ 
				if(value == Address1Phone) return;
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
				if(value == Address2FreightTerms) return;

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
				if(doubleValue == Address2Latitude) return;
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
        /// address2_primarycontactname
        /// </summary>
		[DisplayName("Address 2: Primary Contact Name")]
		[AttributeLogicalName("address2_primarycontactname")]
		public string Address2PrimaryContactName
		{	
			get { return GetAttributeValue<string>("address2_primarycontactname"); }
			set
			{ 
				if(value == Address2PrimaryContactName) return;
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
        /// address3_addressid
        /// </summary>
		[DisplayName("Address 3: ID")]
		[AttributeLogicalName("address3_addressid")]
		public Guid Address3Id
		{	
			get { return GetAttributeValue<Guid>("address3_addressid"); }
			set
			{ 
				if(value == Address3Id) return;
				SetAttributeValue("address3_addressid", value);
			}
		}	
			
		/// <summary>
        /// address3_addresstypecode
        /// </summary>
		[DisplayName("Address 3: Address Type")]
		[AttributeLogicalName("address3_addresstypecode")]
		public eAddress3AddressType? Address3AddressType
		{	
			get 
			{ 
				var optionSetValue = GetAttributeValue<OptionSetValue>("address3_addresstypecode");
				if (optionSetValue != null) return (eAddress3AddressType)optionSetValue.Value;
				else return null;
			}
			set 
			{ 
				if(value == Address3AddressType) return;

				OptionSetValue optionSetValue = null;
				if(value != null) optionSetValue = new OptionSetValue((int)value);
				SetAttributeValue("address3_addresstypecode", optionSetValue); 
			}
		}

		/// <summary>
        /// address3_city
        /// </summary>
		[DisplayName("Address 3: City")]
		[AttributeLogicalName("address3_city")]
		public string Address3City
		{	
			get { return GetAttributeValue<string>("address3_city"); }
			set
			{ 
				if(value == Address3City) return;
				SetAttributeValue("address3_city", value);
			}
		}	
			
		/// <summary>
        /// address3_composite
        /// </summary>
		[DisplayName("Address 3")]
		[AttributeLogicalName("address3_composite")]
		public string Address3
		{	
			get { return GetAttributeValue<string>("address3_composite"); }
			set
			{ 
				if(value == Address3) return;
				SetAttributeValue("address3_composite", value);
			}
		}	
			
		/// <summary>
        /// address3_country
        /// </summary>
		[DisplayName("Address3: Country/Region")]
		[AttributeLogicalName("address3_country")]
		public string Address3CountryRegion
		{	
			get { return GetAttributeValue<string>("address3_country"); }
			set
			{ 
				if(value == Address3CountryRegion) return;
				SetAttributeValue("address3_country", value);
			}
		}	
			
		/// <summary>
        /// address3_county
        /// </summary>
		[DisplayName("Address 3: County")]
		[AttributeLogicalName("address3_county")]
		public string Address3County
		{	
			get { return GetAttributeValue<string>("address3_county"); }
			set
			{ 
				if(value == Address3County) return;
				SetAttributeValue("address3_county", value);
			}
		}	
			
		/// <summary>
        /// address3_fax
        /// </summary>
		[DisplayName("Address 3: Fax")]
		[AttributeLogicalName("address3_fax")]
		public string Address3Fax
		{	
			get { return GetAttributeValue<string>("address3_fax"); }
			set
			{ 
				if(value == Address3Fax) return;
				SetAttributeValue("address3_fax", value);
			}
		}	
			
		/// <summary>
        /// address3_freighttermscode
        /// </summary>
		[DisplayName("Address 3: Freight Terms")]
		[AttributeLogicalName("address3_freighttermscode")]
		public eAddress3FreightTerms? Address3FreightTerms
		{	
			get 
			{ 
				var optionSetValue = GetAttributeValue<OptionSetValue>("address3_freighttermscode");
				if (optionSetValue != null) return (eAddress3FreightTerms)optionSetValue.Value;
				else return null;
			}
			set 
			{ 
				if(value == Address3FreightTerms) return;

				OptionSetValue optionSetValue = null;
				if(value != null) optionSetValue = new OptionSetValue((int)value);
				SetAttributeValue("address3_freighttermscode", optionSetValue); 
			}
		}

		/// <summary>
        /// address3_latitude
		///
		/// Precision: 5
		/// MaxValue: 90
		/// MinValue: -90
        /// </summary>
		[DisplayName("Address 3: Latitude")]
		[AttributeLogicalName("address3_latitude")]
		public double? Address3Latitude
		{	
			get { return GetAttributeValue<double?>("address3_latitude"); }
			set 
			{
				double? doubleValue = null;
				if(value != null) doubleValue = Math.Round(value.Value, 5);
				if(doubleValue == Address3Latitude) return;
				SetAttributeValue("address3_latitude", doubleValue);  
			}
		}

		/// <summary>
        /// address3_line1
        /// </summary>
		[DisplayName("Address3: Street 1")]
		[AttributeLogicalName("address3_line1")]
		public string Address3Street1
		{	
			get { return GetAttributeValue<string>("address3_line1"); }
			set
			{ 
				if(value == Address3Street1) return;
				SetAttributeValue("address3_line1", value);
			}
		}	
			
		/// <summary>
        /// address3_line2
        /// </summary>
		[DisplayName("Address3: Street 2")]
		[AttributeLogicalName("address3_line2")]
		public string Address3Street2
		{	
			get { return GetAttributeValue<string>("address3_line2"); }
			set
			{ 
				if(value == Address3Street2) return;
				SetAttributeValue("address3_line2", value);
			}
		}	
			
		/// <summary>
        /// address3_line3
        /// </summary>
		[DisplayName("Address3: Street 3")]
		[AttributeLogicalName("address3_line3")]
		public string Address3Street3
		{	
			get { return GetAttributeValue<string>("address3_line3"); }
			set
			{ 
				if(value == Address3Street3) return;
				SetAttributeValue("address3_line3", value);
			}
		}	
			
		/// <summary>
        /// address3_longitude
		///
		/// Precision: 5
		/// MaxValue: 180
		/// MinValue: -180
        /// </summary>
		[DisplayName("Address 3: Longitude")]
		[AttributeLogicalName("address3_longitude")]
		public double? Address3Longitude
		{	
			get { return GetAttributeValue<double?>("address3_longitude"); }
			set 
			{
				double? doubleValue = null;
				if(value != null) doubleValue = Math.Round(value.Value, 5);
				if(doubleValue == Address3Longitude) return;
				SetAttributeValue("address3_longitude", doubleValue);  
			}
		}

		/// <summary>
        /// address3_name
        /// </summary>
		[DisplayName("Address 3: Name")]
		[AttributeLogicalName("address3_name")]
		public string Address3Name
		{	
			get { return GetAttributeValue<string>("address3_name"); }
			set
			{ 
				if(value == Address3Name) return;
				SetAttributeValue("address3_name", value);
			}
		}	
			
		/// <summary>
        /// address3_postalcode
        /// </summary>
		[DisplayName("Address3: ZIP/Postal Code")]
		[AttributeLogicalName("address3_postalcode")]
		public string Address3ZIPPostalCode
		{	
			get { return GetAttributeValue<string>("address3_postalcode"); }
			set
			{ 
				if(value == Address3ZIPPostalCode) return;
				SetAttributeValue("address3_postalcode", value);
			}
		}	
			
		/// <summary>
        /// address3_postofficebox
        /// </summary>
		[DisplayName("Address 3: Post Office Box")]
		[AttributeLogicalName("address3_postofficebox")]
		public string Address3PostOfficeBox
		{	
			get { return GetAttributeValue<string>("address3_postofficebox"); }
			set
			{ 
				if(value == Address3PostOfficeBox) return;
				SetAttributeValue("address3_postofficebox", value);
			}
		}	
			
		/// <summary>
        /// address3_primarycontactname
        /// </summary>
		[DisplayName("Address 3: Primary Contact Name")]
		[AttributeLogicalName("address3_primarycontactname")]
		public string Address3PrimaryContactName
		{	
			get { return GetAttributeValue<string>("address3_primarycontactname"); }
			set
			{ 
				if(value == Address3PrimaryContactName) return;
				SetAttributeValue("address3_primarycontactname", value);
			}
		}	
			
		/// <summary>
        /// address3_shippingmethodcode
        /// </summary>
		[DisplayName("Address 3: Shipping Method")]
		[AttributeLogicalName("address3_shippingmethodcode")]
		public eAddress3ShippingMethod? Address3ShippingMethod
		{	
			get 
			{ 
				var optionSetValue = GetAttributeValue<OptionSetValue>("address3_shippingmethodcode");
				if (optionSetValue != null) return (eAddress3ShippingMethod)optionSetValue.Value;
				else return null;
			}
			set 
			{ 
				if(value == Address3ShippingMethod) return;

				OptionSetValue optionSetValue = null;
				if(value != null) optionSetValue = new OptionSetValue((int)value);
				SetAttributeValue("address3_shippingmethodcode", optionSetValue); 
			}
		}

		/// <summary>
        /// address3_stateorprovince
        /// </summary>
		[DisplayName("Address3: State/Province")]
		[AttributeLogicalName("address3_stateorprovince")]
		public string Address3StateProvince
		{	
			get { return GetAttributeValue<string>("address3_stateorprovince"); }
			set
			{ 
				if(value == Address3StateProvince) return;
				SetAttributeValue("address3_stateorprovince", value);
			}
		}	
			
		/// <summary>
        /// address3_telephone1
        /// </summary>
		[DisplayName("Address 3: Telephone1")]
		[AttributeLogicalName("address3_telephone1")]
		public string Address3Telephone1
		{	
			get { return GetAttributeValue<string>("address3_telephone1"); }
			set
			{ 
				if(value == Address3Telephone1) return;
				SetAttributeValue("address3_telephone1", value);
			}
		}	
			
		/// <summary>
        /// address3_telephone2
        /// </summary>
		[DisplayName("Address 3: Telephone2")]
		[AttributeLogicalName("address3_telephone2")]
		public string Address3Telephone2
		{	
			get { return GetAttributeValue<string>("address3_telephone2"); }
			set
			{ 
				if(value == Address3Telephone2) return;
				SetAttributeValue("address3_telephone2", value);
			}
		}	
			
		/// <summary>
        /// address3_telephone3
        /// </summary>
		[DisplayName("Address 3: Telephone3")]
		[AttributeLogicalName("address3_telephone3")]
		public string Address3Telephone3
		{	
			get { return GetAttributeValue<string>("address3_telephone3"); }
			set
			{ 
				if(value == Address3Telephone3) return;
				SetAttributeValue("address3_telephone3", value);
			}
		}	
			
		/// <summary>
        /// address3_upszone
        /// </summary>
		[DisplayName("Address 3: UPS Zone")]
		[AttributeLogicalName("address3_upszone")]
		public string Address3UPSZone
		{	
			get { return GetAttributeValue<string>("address3_upszone"); }
			set
			{ 
				if(value == Address3UPSZone) return;
				SetAttributeValue("address3_upszone", value);
			}
		}	
			
		/// <summary>
        /// address3_utcoffset
        /// </summary>
		[DisplayName("Address 3: UTC Offset")]
		[AttributeLogicalName("address3_utcoffset")]
		public int? Address3UTCOffset
		{	
			get { return GetAttributeValue<int?>("address3_utcoffset"); }
			set
			{ 
				if(value == Address3UTCOffset) return;
				SetAttributeValue("address3_utcoffset", value);
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

				if(moneyValue.Value == Aging30) return;
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

				if(moneyValue.Value == Aging60) return;
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

				if(moneyValue.Value == Aging90) return;
				SetAttributeValue("aging90", moneyValue);  
			}
		}

		/// <summary>
        /// anniversary
        /// </summary>
		[DisplayName("Anniversary")]
		[AttributeLogicalName("anniversary")]
		public DateTime? Anniversary
		{	
			get { return GetAttributeValue<DateTime?>("anniversary"); }
			set
			{ 
				if(value == Anniversary) return;
				SetAttributeValue("anniversary", value);
			}
		}	
			
		/// <summary>
        /// annualincome
		///
		/// Precision: 2
		/// MaxValue: 100000000000000
		/// MinValue: 0
        /// </summary>
		[DisplayName("Annual Income")]
		[AttributeLogicalName("annualincome")]
		public decimal? AnnualIncome
		{	
			get { return GetAttributeValue<Money>("annualincome")?.Value; }
			set 
			{
				Money moneyValue = null;
				if(value != null) 
				{
					var roundedValue = Decimal.Round(value.Value, 2);
					moneyValue = new Money(roundedValue);
				}

				if(moneyValue.Value == AnnualIncome) return;
				SetAttributeValue("annualincome", moneyValue);  
			}
		}

		/// <summary>
        /// assistantname
        /// </summary>
		[DisplayName("Assistant")]
		[AttributeLogicalName("assistantname")]
		public string Assistant
		{	
			get { return GetAttributeValue<string>("assistantname"); }
			set
			{ 
				if(value == Assistant) return;
				SetAttributeValue("assistantname", value);
			}
		}	
			
		/// <summary>
        /// assistantphone
        /// </summary>
		[DisplayName("Assistant Phone")]
		[AttributeLogicalName("assistantphone")]
		public string AssistantPhone
		{	
			get { return GetAttributeValue<string>("assistantphone"); }
			set
			{ 
				if(value == AssistantPhone) return;
				SetAttributeValue("assistantphone", value);
			}
		}	
			
		/// <summary>
        /// birthdate
        /// </summary>
		[DisplayName("Birthday")]
		[AttributeLogicalName("birthdate")]
		public DateTime? Birthday
		{	
			get { return GetAttributeValue<DateTime?>("birthdate"); }
			set
			{ 
				if(value == Birthday) return;
				SetAttributeValue("birthdate", value);
			}
		}	
			
		/// <summary>
        /// business2
        /// </summary>
		[DisplayName("Business Phone 2")]
		[AttributeLogicalName("business2")]
		public string BusinessPhone2
		{	
			get { return GetAttributeValue<string>("business2"); }
			set
			{ 
				if(value == BusinessPhone2) return;
				SetAttributeValue("business2", value);
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
        /// callback
        /// </summary>
		[DisplayName("Callback Number")]
		[AttributeLogicalName("callback")]
		public string CallbackNumber
		{	
			get { return GetAttributeValue<string>("callback"); }
			set
			{ 
				if(value == CallbackNumber) return;
				SetAttributeValue("callback", value);
			}
		}	
			
		/// <summary>
        /// childrensnames
        /// </summary>
		[DisplayName("Children's Names")]
		[AttributeLogicalName("childrensnames")]
		public string ChildrensNames
		{	
			get { return GetAttributeValue<string>("childrensnames"); }
			set
			{ 
				if(value == ChildrensNames) return;
				SetAttributeValue("childrensnames", value);
			}
		}	
			
		/// <summary>
        /// company
        /// </summary>
		[DisplayName("Company Phone")]
		[AttributeLogicalName("company")]
		public string CompanyPhone
		{	
			get { return GetAttributeValue<string>("company"); }
			set
			{ 
				if(value == CompanyPhone) return;
				SetAttributeValue("company", value);
			}
		}	
			
		/// <summary>
        /// contactid
        /// </summary>
		[DisplayName("Contact")]
		[AttributeLogicalName("contactid")]
		public override Guid Id
		{
			get => base.Id;
			set { base.Id = value; SetAttributeValue("contactid", value); }
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

				if(moneyValue.Value == CreditLimit) return;
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
				if(value == CreditHold) return;
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
				if(value == CustomerSize) return;

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
				if(value == RelationshipType) return;

				OptionSetValue optionSetValue = null;
				if(value != null) optionSetValue = new OptionSetValue((int)value);
				SetAttributeValue("customertypecode", optionSetValue); 
			}
		}

		/// <summary>
        /// defaultpricelevelid
        /// </summary>
		[DisplayName("Price List")]
		[AttributeLogicalName("defaultpricelevelid")]
		public EntityReference PriceList
		{	
			get { return GetAttributeValue<EntityReference>("defaultpricelevelid"); }
			set
			{ 
				if(value == PriceList) return;
				SetAttributeValue("defaultpricelevelid", value);
			}
		}	
			
		/// <summary>
        /// defaultpricelevelidname
        /// </summary>
		[DisplayName("defaultpricelevelidname")]
		[AttributeLogicalName("defaultpricelevelidname")]
		public string Defaultpricelevelidname
		{	
			get { return GetAttributeValue<string>("defaultpricelevelidname"); }
			set
			{ 
				if(value == Defaultpricelevelidname) return;
				SetAttributeValue("defaultpricelevelidname", value);
			}
		}	
			
		/// <summary>
        /// department
        /// </summary>
		[DisplayName("Department")]
		[AttributeLogicalName("department")]
		public string Department
		{	
			get { return GetAttributeValue<string>("department"); }
			set
			{ 
				if(value == Department) return;
				SetAttributeValue("department", value);
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
        /// donotbulkpostalmail
        /// </summary>
		[DisplayName("Do not allow Bulk Mails")]
		[AttributeLogicalName("donotbulkpostalmail")]
		public bool? DoNotAllowBulkMails
		{	
			get { return GetAttributeValue<bool?>("donotbulkpostalmail"); }
			set
			{ 
				if(value == DoNotAllowBulkMails) return;
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
		[DisplayName("Send Marketing Materials")]
		[AttributeLogicalName("donotsendmm")]
		public bool? SendMarketingMaterials
		{	
			get { return GetAttributeValue<bool?>("donotsendmm"); }
			set
			{ 
				if(value == SendMarketingMaterials) return;
				SetAttributeValue("donotsendmm", value);
			}
		}	
			
		/// <summary>
        /// educationcode
        /// </summary>
		[DisplayName("Education")]
		[AttributeLogicalName("educationcode")]
		public eEducation? Education
		{	
			get 
			{ 
				var optionSetValue = GetAttributeValue<OptionSetValue>("educationcode");
				if (optionSetValue != null) return (eEducation)optionSetValue.Value;
				else return null;
			}
			set 
			{ 
				if(value == Education) return;

				OptionSetValue optionSetValue = null;
				if(value != null) optionSetValue = new OptionSetValue((int)value);
				SetAttributeValue("educationcode", optionSetValue); 
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
        /// employeeid
        /// </summary>
		[DisplayName("Employee")]
		[AttributeLogicalName("employeeid")]
		public string Employee
		{	
			get { return GetAttributeValue<string>("employeeid"); }
			set
			{ 
				if(value == Employee) return;
				SetAttributeValue("employeeid", value);
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
        /// externaluseridentifier
        /// </summary>
		[DisplayName("External User Identifier")]
		[AttributeLogicalName("externaluseridentifier")]
		public string ExternalUserIdentifier
		{	
			get { return GetAttributeValue<string>("externaluseridentifier"); }
			set
			{ 
				if(value == ExternalUserIdentifier) return;
				SetAttributeValue("externaluseridentifier", value);
			}
		}	
			
		/// <summary>
        /// familystatuscode
        /// </summary>
		[DisplayName("Marital Status")]
		[AttributeLogicalName("familystatuscode")]
		public eMaritalStatus? MaritalStatus
		{	
			get 
			{ 
				var optionSetValue = GetAttributeValue<OptionSetValue>("familystatuscode");
				if (optionSetValue != null) return (eMaritalStatus)optionSetValue.Value;
				else return null;
			}
			set 
			{ 
				if(value == MaritalStatus) return;

				OptionSetValue optionSetValue = null;
				if(value != null) optionSetValue = new OptionSetValue((int)value);
				SetAttributeValue("familystatuscode", optionSetValue); 
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
        /// fullname
        /// </summary>
		[DisplayName("Full Name")]
		[AttributeLogicalName("fullname")]
		public string FullName
		{	
			get { return GetAttributeValue<string>("fullname"); }
			set
			{ 
				if(value == FullName) return;
				SetAttributeValue("fullname", value);
			}
		}	
			
		/// <summary>
        /// gendercode
        /// </summary>
		[DisplayName("Gender")]
		[AttributeLogicalName("gendercode")]
		public eGender? Gender
		{	
			get 
			{ 
				var optionSetValue = GetAttributeValue<OptionSetValue>("gendercode");
				if (optionSetValue != null) return (eGender)optionSetValue.Value;
				else return null;
			}
			set 
			{ 
				if(value == Gender) return;

				OptionSetValue optionSetValue = null;
				if(value != null) optionSetValue = new OptionSetValue((int)value);
				SetAttributeValue("gendercode", optionSetValue); 
			}
		}

		/// <summary>
        /// governmentid
        /// </summary>
		[DisplayName("Government")]
		[AttributeLogicalName("governmentid")]
		public string Government
		{	
			get { return GetAttributeValue<string>("governmentid"); }
			set
			{ 
				if(value == Government) return;
				SetAttributeValue("governmentid", value);
			}
		}	
			
		/// <summary>
        /// haschildrencode
        /// </summary>
		[DisplayName("Has Children")]
		[AttributeLogicalName("haschildrencode")]
		public eHasChildren? HasChildren
		{	
			get 
			{ 
				var optionSetValue = GetAttributeValue<OptionSetValue>("haschildrencode");
				if (optionSetValue != null) return (eHasChildren)optionSetValue.Value;
				else return null;
			}
			set 
			{ 
				if(value == HasChildren) return;

				OptionSetValue optionSetValue = null;
				if(value != null) optionSetValue = new OptionSetValue((int)value);
				SetAttributeValue("haschildrencode", optionSetValue); 
			}
		}

		/// <summary>
        /// home2
        /// </summary>
		[DisplayName("Home Phone 2")]
		[AttributeLogicalName("home2")]
		public string HomePhone2
		{	
			get { return GetAttributeValue<string>("home2"); }
			set
			{ 
				if(value == HomePhone2) return;
				SetAttributeValue("home2", value);
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
        /// isbackofficecustomer
        /// </summary>
		[DisplayName("Back Office Customer")]
		[AttributeLogicalName("isbackofficecustomer")]
		public bool? BackOfficeCustomer
		{	
			get { return GetAttributeValue<bool?>("isbackofficecustomer"); }
			set
			{ 
				if(value == BackOfficeCustomer) return;
				SetAttributeValue("isbackofficecustomer", value);
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
				if(value == Isprivate) return;
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
		[DisplayName("Last Date Included in Campaign")]
		[AttributeLogicalName("lastusedincampaign")]
		public DateTime? LastDateIncludedInCampaign
		{	
			get { return GetAttributeValue<DateTime?>("lastusedincampaign"); }
			set
			{ 
				if(value == LastDateIncludedInCampaign) return;
				SetAttributeValue("lastusedincampaign", value);
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
        /// managername
        /// </summary>
		[DisplayName("Manager")]
		[AttributeLogicalName("managername")]
		public string Manager
		{	
			get { return GetAttributeValue<string>("managername"); }
			set
			{ 
				if(value == Manager) return;
				SetAttributeValue("managername", value);
			}
		}	
			
		/// <summary>
        /// managerphone
        /// </summary>
		[DisplayName("Manager Phone")]
		[AttributeLogicalName("managerphone")]
		public string ManagerPhone
		{	
			get { return GetAttributeValue<string>("managerphone"); }
			set
			{ 
				if(value == ManagerPhone) return;
				SetAttributeValue("managerphone", value);
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
				if(value == MarketingOnly) return;
				SetAttributeValue("marketingonly", value);
			}
		}	
			
		/// <summary>
        /// mastercontactidname
        /// </summary>
		[DisplayName("mastercontactidname")]
		[AttributeLogicalName("mastercontactidname")]
		public string Mastercontactidname
		{	
			get { return GetAttributeValue<string>("mastercontactidname"); }
			set
			{ 
				if(value == Mastercontactidname) return;
				SetAttributeValue("mastercontactidname", value);
			}
		}	
			
		/// <summary>
        /// mastercontactidyominame
        /// </summary>
		[DisplayName("mastercontactidyominame")]
		[AttributeLogicalName("mastercontactidyominame")]
		public string Mastercontactidyominame
		{	
			get { return GetAttributeValue<string>("mastercontactidyominame"); }
			set
			{ 
				if(value == Mastercontactidyominame) return;
				SetAttributeValue("mastercontactidyominame", value);
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
        /// msdyn_orgchangestatus
        /// </summary>
		[DisplayName("Not at Company Flag")]
		[AttributeLogicalName("msdyn_orgchangestatus")]
		public eNotAtCompanyFlag? NotAtCompanyFlag
		{	
			get 
			{ 
				var optionSetValue = GetAttributeValue<OptionSetValue>("msdyn_orgchangestatus");
				if (optionSetValue != null) return (eNotAtCompanyFlag)optionSetValue.Value;
				else return null;
			}
			set 
			{ 
				if(value == NotAtCompanyFlag) return;

				OptionSetValue optionSetValue = null;
				if(value != null) optionSetValue = new OptionSetValue((int)value);
				SetAttributeValue("msdyn_orgchangestatus", optionSetValue); 
			}
		}

		/// <summary>
        /// nickname
        /// </summary>
		[DisplayName("Nickname")]
		[AttributeLogicalName("nickname")]
		public string Nickname
		{	
			get { return GetAttributeValue<string>("nickname"); }
			set
			{ 
				if(value == Nickname) return;
				SetAttributeValue("nickname", value);
			}
		}	
			
		/// <summary>
        /// numberofchildren
        /// </summary>
		[DisplayName("No. of Children")]
		[AttributeLogicalName("numberofchildren")]
		public int? NoOfChildren
		{	
			get { return GetAttributeValue<int?>("numberofchildren"); }
			set
			{ 
				if(value == NoOfChildren) return;
				SetAttributeValue("numberofchildren", value);
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
        /// originatingleadid
        /// </summary>
		[DisplayName("Originating Lead")]
		[AttributeLogicalName("originatingleadid")]
		public EntityReference OriginatingLead
		{	
			get { return GetAttributeValue<EntityReference>("originatingleadid"); }
			set
			{ 
				if(value == OriginatingLead) return;
				SetAttributeValue("originatingleadid", value);
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
			set
			{ 
				if(value == Originatingleadidname) return;
				SetAttributeValue("originatingleadidname", value);
			}
		}	
			
		/// <summary>
        /// originatingleadidyominame
        /// </summary>
		[DisplayName("originatingleadidyominame")]
		[AttributeLogicalName("originatingleadidyominame")]
		public string Originatingleadidyominame
		{	
			get { return GetAttributeValue<string>("originatingleadidyominame"); }
			set
			{ 
				if(value == Originatingleadidyominame) return;
				SetAttributeValue("originatingleadidyominame", value);
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
        /// parentcontactid
        /// </summary>
		[DisplayName("Parent Contact")]
		[AttributeLogicalName("parentcontactid")]
		public EntityReference ParentContact
		{	
			get { return GetAttributeValue<EntityReference>("parentcontactid"); }
			set
			{ 
				if(value == ParentContact) return;
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
        /// parentcustomerid
        /// </summary>
		[DisplayName("Company Name")]
		[AttributeLogicalName("parentcustomerid")]
		public EntityReference CompanyName
		{	
			get { return GetAttributeValue<EntityReference>("parentcustomerid"); }
			set
			{ 
				if(value == CompanyName) return;
				SetAttributeValue("parentcustomerid", value);
			}
		}	
			
		/// <summary>
        /// parentcustomeridname
        /// </summary>
		[DisplayName("parentcustomeridname")]
		[AttributeLogicalName("parentcustomeridname")]
		public string Parentcustomeridname
		{	
			get { return GetAttributeValue<string>("parentcustomeridname"); }
			set
			{ 
				if(value == Parentcustomeridname) return;
				SetAttributeValue("parentcustomeridname", value);
			}
		}	
			
		/// <summary>
        /// parentcustomeridtype
        /// </summary>
		[DisplayName("Parent Customer Type")]
		[AttributeLogicalName("parentcustomeridtype")]
		public string ParentCustomerType
		{	
			get { return GetAttributeValue<string>("parentcustomeridtype"); }
			set
			{ 
				if(value == ParentCustomerType) return;
				SetAttributeValue("parentcustomeridtype", value);
			}
		}	
			
		/// <summary>
        /// parentcustomeridyominame
        /// </summary>
		[DisplayName("parentcustomeridyominame")]
		[AttributeLogicalName("parentcustomeridyominame")]
		public string Parentcustomeridyominame
		{	
			get { return GetAttributeValue<string>("parentcustomeridyominame"); }
			set
			{ 
				if(value == Parentcustomeridyominame) return;
				SetAttributeValue("parentcustomeridyominame", value);
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
				if(value == PaymentTerms) return;

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
				if(value == PreferredDay) return;

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
				if(value == PreferredTime) return;

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
				if(value == PreferredMethodOfContact) return;

				OptionSetValue optionSetValue = null;
				if(value != null) optionSetValue = new OptionSetValue((int)value);
				SetAttributeValue("preferredcontactmethodcode", optionSetValue); 
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
			set
			{ 
				if(value == PreferredFacilityEquipment) return;
				SetAttributeValue("preferredequipmentid", value);
			}
		}	
			
		/// <summary>
        /// preferredequipmentidname
        /// </summary>
		[DisplayName("preferredequipmentidname")]
		[AttributeLogicalName("preferredequipmentidname")]
		public string Preferredequipmentidname
		{	
			get { return GetAttributeValue<string>("preferredequipmentidname"); }
			set
			{ 
				if(value == Preferredequipmentidname) return;
				SetAttributeValue("preferredequipmentidname", value);
			}
		}	
			
		/// <summary>
        /// preferredserviceid
        /// </summary>
		[DisplayName("Preferred Service")]
		[AttributeLogicalName("preferredserviceid")]
		public EntityReference PreferredService
		{	
			get { return GetAttributeValue<EntityReference>("preferredserviceid"); }
			set
			{ 
				if(value == PreferredService) return;
				SetAttributeValue("preferredserviceid", value);
			}
		}	
			
		/// <summary>
        /// preferredserviceidname
        /// </summary>
		[DisplayName("preferredserviceidname")]
		[AttributeLogicalName("preferredserviceidname")]
		public string Preferredserviceidname
		{	
			get { return GetAttributeValue<string>("preferredserviceidname"); }
			set
			{ 
				if(value == Preferredserviceidname) return;
				SetAttributeValue("preferredserviceidname", value);
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
				if(value == PreferredUser) return;
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
				if(value == Preferredsystemuseridname) return;
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
				if(value == Preferredsystemuseridyominame) return;
				SetAttributeValue("preferredsystemuseridyominame", value);
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
				if(value == ShippingMethod) return;

				OptionSetValue optionSetValue = null;
				if(value != null) optionSetValue = new OptionSetValue((int)value);
				SetAttributeValue("shippingmethodcode", optionSetValue); 
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
        /// spousesname
        /// </summary>
		[DisplayName("Spouse/Partner Name")]
		[AttributeLogicalName("spousesname")]
		public string SpousePartnerName
		{	
			get { return GetAttributeValue<string>("spousesname"); }
			set
			{ 
				if(value == SpousePartnerName) return;
				SetAttributeValue("spousesname", value);
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
        /// subscriptionid
        /// </summary>
		[DisplayName("Subscription")]
		[AttributeLogicalName("subscriptionid")]
		public Guid SubscriptionId
		{	
			get { return GetAttributeValue<Guid>("subscriptionid"); }
			set
			{ 
				if(value == SubscriptionId) return;
				SetAttributeValue("subscriptionid", value);
			}
		}	
			
		/// <summary>
        /// suffix
        /// </summary>
		[DisplayName("Suffix")]
		[AttributeLogicalName("suffix")]
		public string Suffix
		{	
			get { return GetAttributeValue<string>("suffix"); }
			set
			{ 
				if(value == Suffix) return;
				SetAttributeValue("suffix", value);
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
		[DisplayName("Telephone 3")]
		[AttributeLogicalName("telephone3")]
		public string Telephone3
		{	
			get { return GetAttributeValue<string>("telephone3"); }
			set
			{ 
				if(value == Telephone3) return;
				SetAttributeValue("telephone3", value);
			}
		}	
			
		/// <summary>
        /// territorycode
        /// </summary>
		[DisplayName("Territory")]
		[AttributeLogicalName("territorycode")]
		public eTerritory? Territory
		{	
			get 
			{ 
				var optionSetValue = GetAttributeValue<OptionSetValue>("territorycode");
				if (optionSetValue != null) return (eTerritory)optionSetValue.Value;
				else return null;
			}
			set 
			{ 
				if(value == Territory) return;

				OptionSetValue optionSetValue = null;
				if(value != null) optionSetValue = new OptionSetValue((int)value);
				SetAttributeValue("territorycode", optionSetValue); 
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
        /// 1:N Get entities for 'account_primary_contact'
        /// </summary>
		[RelationshipSchemaName("account_primary_contact")]
		public IEnumerable<Account> AccountPrimaryContact
		{
			get { return GetRelatedEntities<Account>("account_primary_contact", null); }
			set { SetRelatedEntities("account_primary_contact", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'contact_actioncard'
        /// </summary>
		[RelationshipSchemaName("contact_actioncard")]
		public IEnumerable<ActionCard> ContactActioncard
		{
			get { return GetRelatedEntities<ActionCard>("contact_actioncard", null); }
			set { SetRelatedEntities("contact_actioncard", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'contact_activity_parties'
        /// </summary>
		[RelationshipSchemaName("contact_activity_parties")]
		public IEnumerable<ActivityParty> ContactActivityParties
		{
			get { return GetRelatedEntities<ActivityParty>("contact_activity_parties", null); }
			set { SetRelatedEntities("contact_activity_parties", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'Contact_ActivityPointers'
        /// </summary>
		[RelationshipSchemaName("Contact_ActivityPointers")]
		public IEnumerable<Activity> ContactActivityPointers
		{
			get { return GetRelatedEntities<Activity>("Contact_ActivityPointers", null); }
			set { SetRelatedEntities("Contact_ActivityPointers", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'Contact_Annotation'
        /// </summary>
		[RelationshipSchemaName("Contact_Annotation")]
		public IEnumerable<Note> ContactAnnotation
		{
			get { return GetRelatedEntities<Note>("Contact_Annotation", null); }
			set { SetRelatedEntities("Contact_Annotation", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'Contact_Appointments'
        /// </summary>
		[RelationshipSchemaName("Contact_Appointments")]
		public IEnumerable<Appointment> ContactAppointments
		{
			get { return GetRelatedEntities<Appointment>("Contact_Appointments", null); }
			set { SetRelatedEntities("Contact_Appointments", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'contact_as_primary_contact'
        /// </summary>
		[RelationshipSchemaName("contact_as_primary_contact")]
		public IEnumerable<Case> ContactAsPrimaryContact
		{
			get { return GetRelatedEntities<Case>("contact_as_primary_contact", null); }
			set { SetRelatedEntities("contact_as_primary_contact", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'contact_as_responsible_contact'
        /// </summary>
		[RelationshipSchemaName("contact_as_responsible_contact")]
		public IEnumerable<Case> ContactAsResponsibleContact
		{
			get { return GetRelatedEntities<Case>("contact_as_responsible_contact", null); }
			set { SetRelatedEntities("contact_as_responsible_contact", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'Contact_AsyncOperations'
        /// </summary>
		[RelationshipSchemaName("Contact_AsyncOperations")]
		public IEnumerable<SystemJob> ContactAsyncOperations
		{
			get { return GetRelatedEntities<SystemJob>("Contact_AsyncOperations", null); }
			set { SetRelatedEntities("Contact_AsyncOperations", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'contact_bookableresource_ContactId'
        /// </summary>
		[RelationshipSchemaName("contact_bookableresource_ContactId")]
		public IEnumerable<BookableResource> ContactBookableresourceContactId
		{
			get { return GetRelatedEntities<BookableResource>("contact_bookableresource_ContactId", null); }
			set { SetRelatedEntities("contact_bookableresource_ContactId", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'Contact_BulkDeleteFailures'
        /// </summary>
		[RelationshipSchemaName("Contact_BulkDeleteFailures")]
		public IEnumerable<BulkDeleteFailure> ContactBulkDeleteFailures
		{
			get { return GetRelatedEntities<BulkDeleteFailure>("Contact_BulkDeleteFailures", null); }
			set { SetRelatedEntities("Contact_BulkDeleteFailures", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'contact_BulkOperations'
        /// </summary>
		[RelationshipSchemaName("contact_BulkOperations")]
		public IEnumerable<QuickCampaign> ContactBulkOperations
		{
			get { return GetRelatedEntities<QuickCampaign>("contact_BulkOperations", null); }
			set { SetRelatedEntities("contact_BulkOperations", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'contact_CampaignResponses'
        /// </summary>
		[RelationshipSchemaName("contact_CampaignResponses")]
		public IEnumerable<CampaignResponse> ContactCampaignResponses
		{
			get { return GetRelatedEntities<CampaignResponse>("contact_CampaignResponses", null); }
			set { SetRelatedEntities("contact_CampaignResponses", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'contact_connections1'
        /// </summary>
		[RelationshipSchemaName("contact_connections1")]
		public IEnumerable<Connection> ContactConnections1
		{
			get { return GetRelatedEntities<Connection>("contact_connections1", null); }
			set { SetRelatedEntities("contact_connections1", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'contact_connections2'
        /// </summary>
		[RelationshipSchemaName("contact_connections2")]
		public IEnumerable<Connection> ContactConnections2
		{
			get { return GetRelatedEntities<Connection>("contact_connections2", null); }
			set { SetRelatedEntities("contact_connections2", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'contact_customer_contacts'
        /// </summary>
		[RelationshipSchemaName("contact_customer_contacts")]
		public IEnumerable<Contact> ContactCustomerContacts
		{
			get { return GetRelatedEntities<Contact>("contact_customer_contacts", null); }
			set { SetRelatedEntities("contact_customer_contacts", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'Contact_CustomerAddress'
        /// </summary>
		[RelationshipSchemaName("Contact_CustomerAddress")]
		public IEnumerable<Address> ContactCustomerAddress
		{
			get { return GetRelatedEntities<Address>("Contact_CustomerAddress", null); }
			set { SetRelatedEntities("Contact_CustomerAddress", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'Contact_DuplicateBaseRecord'
        /// </summary>
		[RelationshipSchemaName("Contact_DuplicateBaseRecord")]
		public IEnumerable<DuplicateRecord> ContactDuplicateBaseRecord
		{
			get { return GetRelatedEntities<DuplicateRecord>("Contact_DuplicateBaseRecord", null); }
			set { SetRelatedEntities("Contact_DuplicateBaseRecord", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'Contact_DuplicateMatchingRecord'
        /// </summary>
		[RelationshipSchemaName("Contact_DuplicateMatchingRecord")]
		public IEnumerable<DuplicateRecord> ContactDuplicateMatchingRecord
		{
			get { return GetRelatedEntities<DuplicateRecord>("Contact_DuplicateMatchingRecord", null); }
			set { SetRelatedEntities("Contact_DuplicateMatchingRecord", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'Contact_Email_EmailSender'
        /// </summary>
		[RelationshipSchemaName("Contact_Email_EmailSender")]
		public IEnumerable<Email> ContactEmailEmailSender
		{
			get { return GetRelatedEntities<Email>("Contact_Email_EmailSender", null); }
			set { SetRelatedEntities("Contact_Email_EmailSender", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'Contact_Emails'
        /// </summary>
		[RelationshipSchemaName("Contact_Emails")]
		public IEnumerable<Email> ContactEmails
		{
			get { return GetRelatedEntities<Email>("Contact_Emails", null); }
			set { SetRelatedEntities("Contact_Emails", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'contact_entitlement_ContactId'
        /// </summary>
		[RelationshipSchemaName("contact_entitlement_ContactId")]
		public IEnumerable<Entitlement> ContactEntitlementContactId
		{
			get { return GetRelatedEntities<Entitlement>("contact_entitlement_ContactId", null); }
			set { SetRelatedEntities("contact_entitlement_ContactId", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'contact_entitlement_Customer'
        /// </summary>
		[RelationshipSchemaName("contact_entitlement_Customer")]
		public IEnumerable<Entitlement> ContactEntitlementCustomer
		{
			get { return GetRelatedEntities<Entitlement>("contact_entitlement_Customer", null); }
			set { SetRelatedEntities("contact_entitlement_Customer", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'Contact_Faxes'
        /// </summary>
		[RelationshipSchemaName("Contact_Faxes")]
		public IEnumerable<Fax> ContactFaxes
		{
			get { return GetRelatedEntities<Fax>("Contact_Faxes", null); }
			set { SetRelatedEntities("Contact_Faxes", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'Contact_Feedback'
        /// </summary>
		[RelationshipSchemaName("Contact_Feedback")]
		public IEnumerable<Feedback> ContactFeedback
		{
			get { return GetRelatedEntities<Feedback>("Contact_Feedback", null); }
			set { SetRelatedEntities("Contact_Feedback", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'Contact_Letters'
        /// </summary>
		[RelationshipSchemaName("Contact_Letters")]
		public IEnumerable<Letter> ContactLetters
		{
			get { return GetRelatedEntities<Letter>("Contact_Letters", null); }
			set { SetRelatedEntities("Contact_Letters", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'Contact_MailboxTrackingFolder'
        /// </summary>
		[RelationshipSchemaName("Contact_MailboxTrackingFolder")]
		public IEnumerable<MailboxAutoTrackingFolder> ContactMailboxTrackingFolder
		{
			get { return GetRelatedEntities<MailboxAutoTrackingFolder>("Contact_MailboxTrackingFolder", null); }
			set { SetRelatedEntities("Contact_MailboxTrackingFolder", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'contact_master_contact'
        /// </summary>
		[RelationshipSchemaName("contact_master_contact")]
		public IEnumerable<Contact> ContactMasterContact
		{
			get { return GetRelatedEntities<Contact>("contact_master_contact", null); }
			set { SetRelatedEntities("contact_master_contact", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'Contact_Phonecalls'
        /// </summary>
		[RelationshipSchemaName("Contact_Phonecalls")]
		public IEnumerable<PhoneCall> ContactPhonecalls
		{
			get { return GetRelatedEntities<PhoneCall>("Contact_Phonecalls", null); }
			set { SetRelatedEntities("Contact_Phonecalls", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'contact_PostFollows'
        /// </summary>
		[RelationshipSchemaName("contact_PostFollows")]
		public IEnumerable<Follow> ContactPostFollows
		{
			get { return GetRelatedEntities<Follow>("contact_PostFollows", null); }
			set { SetRelatedEntities("contact_PostFollows", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'contact_principalobjectattributeaccess'
        /// </summary>
		[RelationshipSchemaName("contact_principalobjectattributeaccess")]
		public IEnumerable<FieldSharing> ContactPrincipalobjectattributeaccess
		{
			get { return GetRelatedEntities<FieldSharing>("contact_principalobjectattributeaccess", null); }
			set { SetRelatedEntities("contact_principalobjectattributeaccess", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'Contact_ProcessSessions'
        /// </summary>
		[RelationshipSchemaName("Contact_ProcessSessions")]
		public IEnumerable<ProcessSession> ContactProcessSessions
		{
			get { return GetRelatedEntities<ProcessSession>("Contact_ProcessSessions", null); }
			set { SetRelatedEntities("Contact_ProcessSessions", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'Contact_RecurringAppointmentMasters'
        /// </summary>
		[RelationshipSchemaName("Contact_RecurringAppointmentMasters")]
		public IEnumerable<RecurringAppointment> ContactRecurringAppointmentMasters
		{
			get { return GetRelatedEntities<RecurringAppointment>("Contact_RecurringAppointmentMasters", null); }
			set { SetRelatedEntities("Contact_RecurringAppointmentMasters", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'Contact_ServiceAppointments'
        /// </summary>
		[RelationshipSchemaName("Contact_ServiceAppointments")]
		public IEnumerable<ServiceActivity> ContactServiceAppointments
		{
			get { return GetRelatedEntities<ServiceActivity>("Contact_ServiceAppointments", null); }
			set { SetRelatedEntities("Contact_ServiceAppointments", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'contact_SharePointDocumentLocations'
        /// </summary>
		[RelationshipSchemaName("contact_SharePointDocumentLocations")]
		public IEnumerable<DocumentLocation> ContactSharePointDocumentLocations
		{
			get { return GetRelatedEntities<DocumentLocation>("contact_SharePointDocumentLocations", null); }
			set { SetRelatedEntities("contact_SharePointDocumentLocations", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'Contact_SocialActivities'
        /// </summary>
		[RelationshipSchemaName("Contact_SocialActivities")]
		public IEnumerable<SocialActivity> ContactSocialActivities
		{
			get { return GetRelatedEntities<SocialActivity>("Contact_SocialActivities", null); }
			set { SetRelatedEntities("Contact_SocialActivities", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'Contact_SyncErrors'
        /// </summary>
		[RelationshipSchemaName("Contact_SyncErrors")]
		public IEnumerable<SyncError> ContactSyncErrors
		{
			get { return GetRelatedEntities<SyncError>("Contact_SyncErrors", null); }
			set { SetRelatedEntities("Contact_SyncErrors", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'Contact_Tasks'
        /// </summary>
		[RelationshipSchemaName("Contact_Tasks")]
		public IEnumerable<Task> ContactTasks
		{
			get { return GetRelatedEntities<Task>("Contact_Tasks", null); }
			set { SetRelatedEntities("Contact_Tasks", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'contract_billingcustomer_contacts'
        /// </summary>
		[RelationshipSchemaName("contract_billingcustomer_contacts")]
		public IEnumerable<Contract> ContractBillingcustomerContacts
		{
			get { return GetRelatedEntities<Contract>("contract_billingcustomer_contacts", null); }
			set { SetRelatedEntities("contract_billingcustomer_contacts", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'contract_customer_contacts'
        /// </summary>
		[RelationshipSchemaName("contract_customer_contacts")]
		public IEnumerable<Contract> ContractCustomerContacts
		{
			get { return GetRelatedEntities<Contract>("contract_customer_contacts", null); }
			set { SetRelatedEntities("contract_customer_contacts", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'contractlineitem_customer_contacts'
        /// </summary>
		[RelationshipSchemaName("contractlineitem_customer_contacts")]
		public IEnumerable<ContractLine> ContractlineitemCustomerContacts
		{
			get { return GetRelatedEntities<ContractLine>("contractlineitem_customer_contacts", null); }
			set { SetRelatedEntities("contractlineitem_customer_contacts", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'incident_customer_contacts'
        /// </summary>
		[RelationshipSchemaName("incident_customer_contacts")]
		public IEnumerable<Case> IncidentCustomerContacts
		{
			get { return GetRelatedEntities<Case>("incident_customer_contacts", null); }
			set { SetRelatedEntities("incident_customer_contacts", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'invoice_customer_contacts'
        /// </summary>
		[RelationshipSchemaName("invoice_customer_contacts")]
		public IEnumerable<Invoice> InvoiceCustomerContacts
		{
			get { return GetRelatedEntities<Invoice>("invoice_customer_contacts", null); }
			set { SetRelatedEntities("invoice_customer_contacts", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lead_customer_contacts'
        /// </summary>
		[RelationshipSchemaName("lead_customer_contacts")]
		public IEnumerable<Lead> LeadCustomerContacts
		{
			get { return GetRelatedEntities<Lead>("lead_customer_contacts", null); }
			set { SetRelatedEntities("lead_customer_contacts", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lead_parent_contact'
        /// </summary>
		[RelationshipSchemaName("lead_parent_contact")]
		public IEnumerable<Lead> LeadParentContact
		{
			get { return GetRelatedEntities<Lead>("lead_parent_contact", null); }
			set { SetRelatedEntities("lead_parent_contact", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_contact_feedback_createdby'
        /// </summary>
		[RelationshipSchemaName("lk_contact_feedback_createdby")]
		public IEnumerable<Feedback> LkContactFeedbackCreatedby
		{
			get { return GetRelatedEntities<Feedback>("lk_contact_feedback_createdby", null); }
			set { SetRelatedEntities("lk_contact_feedback_createdby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_contact_feedback_createdonbehalfby'
        /// </summary>
		[RelationshipSchemaName("lk_contact_feedback_createdonbehalfby")]
		public IEnumerable<Feedback> LkContactFeedbackCreatedonbehalfby
		{
			get { return GetRelatedEntities<Feedback>("lk_contact_feedback_createdonbehalfby", null); }
			set { SetRelatedEntities("lk_contact_feedback_createdonbehalfby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'msdyn_playbookinstance_contact'
        /// </summary>
		[RelationshipSchemaName("msdyn_playbookinstance_contact")]
		public IEnumerable<Playbook> MsdynPlaybookinstanceContact
		{
			get { return GetRelatedEntities<Playbook>("msdyn_playbookinstance_contact", null); }
			set { SetRelatedEntities("msdyn_playbookinstance_contact", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'opportunity_customer_contacts'
        /// </summary>
		[RelationshipSchemaName("opportunity_customer_contacts")]
		public IEnumerable<Opportunity> OpportunityCustomerContacts
		{
			get { return GetRelatedEntities<Opportunity>("opportunity_customer_contacts", null); }
			set { SetRelatedEntities("opportunity_customer_contacts", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'opportunity_parent_contact'
        /// </summary>
		[RelationshipSchemaName("opportunity_parent_contact")]
		public IEnumerable<Opportunity> OpportunityParentContact
		{
			get { return GetRelatedEntities<Opportunity>("opportunity_parent_contact", null); }
			set { SetRelatedEntities("opportunity_parent_contact", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'order_customer_contacts'
        /// </summary>
		[RelationshipSchemaName("order_customer_contacts")]
		public IEnumerable<Order> OrderCustomerContacts
		{
			get { return GetRelatedEntities<Order>("order_customer_contacts", null); }
			set { SetRelatedEntities("order_customer_contacts", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'quote_customer_contacts'
        /// </summary>
		[RelationshipSchemaName("quote_customer_contacts")]
		public IEnumerable<Quote> QuoteCustomerContacts
		{
			get { return GetRelatedEntities<Quote>("quote_customer_contacts", null); }
			set { SetRelatedEntities("quote_customer_contacts", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'slakpiinstance_contact'
        /// </summary>
		[RelationshipSchemaName("slakpiinstance_contact")]
		public IEnumerable<SLAKPIInstance> SlakpiinstanceContact
		{
			get { return GetRelatedEntities<SLAKPIInstance>("slakpiinstance_contact", null); }
			set { SetRelatedEntities("slakpiinstance_contact", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'socialactivity_postauthor_contacts'
        /// </summary>
		[RelationshipSchemaName("socialactivity_postauthor_contacts")]
		public IEnumerable<SocialActivity> SocialactivityPostauthorContacts
		{
			get { return GetRelatedEntities<SocialActivity>("socialactivity_postauthor_contacts", null); }
			set { SetRelatedEntities("socialactivity_postauthor_contacts", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'socialactivity_postauthoraccount_contacts'
        /// </summary>
		[RelationshipSchemaName("socialactivity_postauthoraccount_contacts")]
		public IEnumerable<SocialActivity> SocialactivityPostauthoraccountContacts
		{
			get { return GetRelatedEntities<SocialActivity>("socialactivity_postauthoraccount_contacts", null); }
			set { SetRelatedEntities("socialactivity_postauthoraccount_contacts", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'Socialprofile_customer_contacts'
        /// </summary>
		[RelationshipSchemaName("Socialprofile_customer_contacts")]
		public IEnumerable<SocialProfile> SocialprofileCustomerContacts
		{
			get { return GetRelatedEntities<SocialProfile>("Socialprofile_customer_contacts", null); }
			set { SetRelatedEntities("Socialprofile_customer_contacts", null, value); }
		}
		/// <summary>
        /// N:N Get entities for 'QuickCampaign'
        /// </summary>
		[RelationshipSchemaName("BulkOperation_Contacts")]
		public IEnumerable<QuickCampaign> BulkOperationContacts
		{
			get { return GetRelatedEntities<QuickCampaign>("BulkOperation_Contacts", null); }
			set { SetRelatedEntities("BulkOperation_Contacts", null, value); }
		}
		/// <summary>
        /// N:N Get entities for 'CampaignActivity'
        /// </summary>
		[RelationshipSchemaName("CampaignActivity_Contacts")]
		public IEnumerable<CampaignActivity> CampaignActivityContacts
		{
			get { return GetRelatedEntities<CampaignActivity>("CampaignActivity_Contacts", null); }
			set { SetRelatedEntities("CampaignActivity_Contacts", null, value); }
		}
		/// <summary>
        /// N:N Get entities for 'Invoice'
        /// </summary>
		[RelationshipSchemaName("contactinvoices_association")]
		public IEnumerable<Invoice> ContactinvoicesAssociation
		{
			get { return GetRelatedEntities<Invoice>("contactinvoices_association", null); }
			set { SetRelatedEntities("contactinvoices_association", null, value); }
		}
		/// <summary>
        /// N:N Get entities for 'Lead'
        /// </summary>
		[RelationshipSchemaName("contactleads_association")]
		public IEnumerable<Lead> ContactleadsAssociation
		{
			get { return GetRelatedEntities<Lead>("contactleads_association", null); }
			set { SetRelatedEntities("contactleads_association", null, value); }
		}
		/// <summary>
        /// N:N Get entities for 'Order'
        /// </summary>
		[RelationshipSchemaName("contactorders_association")]
		public IEnumerable<Order> ContactordersAssociation
		{
			get { return GetRelatedEntities<Order>("contactorders_association", null); }
			set { SetRelatedEntities("contactorders_association", null, value); }
		}
		/// <summary>
        /// N:N Get entities for 'Quote'
        /// </summary>
		[RelationshipSchemaName("contactquotes_association")]
		public IEnumerable<Quote> ContactquotesAssociation
		{
			get { return GetRelatedEntities<Quote>("contactquotes_association", null); }
			set { SetRelatedEntities("contactquotes_association", null, value); }
		}
		/// <summary>
        /// N:N Get entities for 'Entitlement'
        /// </summary>
		[RelationshipSchemaName("entitlementcontacts_association")]
		public IEnumerable<Entitlement> EntitlementcontactsAssociation
		{
			get { return GetRelatedEntities<Entitlement>("entitlementcontacts_association", null); }
			set { SetRelatedEntities("entitlementcontacts_association", null, value); }
		}
		/// <summary>
        /// N:N Get entities for 'MarketingList'
        /// </summary>
		[RelationshipSchemaName("listcontact_association")]
		public IEnumerable<MarketingList> ListcontactAssociation
		{
			get { return GetRelatedEntities<MarketingList>("listcontact_association", null); }
			set { SetRelatedEntities("listcontact_association", null, value); }
		}
		/// <summary>
        /// N:N Get entities for 'Contract'
        /// </summary>
		[RelationshipSchemaName("servicecontractcontacts_association")]
		public IEnumerable<Contract> ServicecontractcontactsAssociation
		{
			get { return GetRelatedEntities<Contract>("servicecontractcontacts_association", null); }
			set { SetRelatedEntities("servicecontractcontacts_association", null, value); }
		}
		#endregion

		#region Actions
		public OrganizationResponse ExecuteSalesInsightsGDPROptoutContact(OrganizationServiceContext serviceContext)
		{
			var orgRequest = new OrganizationRequest("msdyn_GDPROptoutContact");
			orgRequest["Target"] = ToEntityReference();
            return serviceContext.Execute(orgRequest);
		}
		#endregion

		#region OptionSetEnums
		public enum eRole
		{	
		
			[Label("Decision Maker")]
			[Description(@"")]
			DecisionMaker = 1, 
		
			[Label("Employee")]
			[Description(@"")]
			Employee = 2, 
		
			[Label("Influencer")]
			[Description(@"")]
			Influencer = 3, 
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
		
		public enum eAddress3AddressType
		{	
		
			[Label("Default Value")]
			[Description(@"")]
			DefaultValue = 1, 
		}
		
		public enum eAddress3FreightTerms
		{	
		
			[Label("Default Value")]
			[Description(@"")]
			DefaultValue = 1, 
		}
		
		public enum eAddress3ShippingMethod
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
		
			[Label("Default Value")]
			[Description(@"")]
			DefaultValue = 1, 
		}
		
		public enum eEducation
		{	
		
			[Label("Default Value")]
			[Description(@"")]
			DefaultValue = 1, 
		}
		
		public enum eMaritalStatus
		{	
		
			[Label("Single")]
			[Description(@"")]
			Single = 1, 
		
			[Label("Married")]
			[Description(@"")]
			Married = 2, 
		
			[Label("Divorced")]
			[Description(@"")]
			Divorced = 3, 
		
			[Label("Widowed")]
			[Description(@"")]
			Widowed = 4, 
		}
		
		public enum eGender
		{	
		
			[Label("Male")]
			[Description(@"")]
			Male = 1, 
		
			[Label("Female")]
			[Description(@"")]
			Female = 2, 
		}
		
		public enum eHasChildren
		{	
		
			[Label("Default Value")]
			[Description(@"")]
			DefaultValue = 1, 
		}
		
		public enum eLeadSource
		{	
		
			[Label("Default Value")]
			[Description(@"")]
			DefaultValue = 1, 
		}
		
		public enum eNotAtCompanyFlag
		{	
		
			[Label("No Feedback")]
			[Description(@"")]
			NoFeedback = 0, 
		
			[Label("Not at Company")]
			[Description(@"")]
			NotAtCompany = 1, 
		
			[Label("Ignore")]
			[Description(@"")]
			Ignore = 2, 
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
		
		public enum eTerritory
		{	
		
			[Label("Default Value")]
			[Description(@"")]
			DefaultValue = 1, 
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

			/// <summary>accountrolecode</summary>
			public const string Role = "accountrolecode";

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
			public const string Address1Phone = "address1_telephone1";

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

			/// <summary>address3_addressid</summary>
			public const string Address3Id = "address3_addressid";

			/// <summary>address3_addresstypecode</summary>
			public const string Address3AddressType = "address3_addresstypecode";

			/// <summary>address3_city</summary>
			public const string Address3City = "address3_city";

			/// <summary>address3_composite</summary>
			public const string Address3 = "address3_composite";

			/// <summary>address3_country</summary>
			public const string Address3CountryRegion = "address3_country";

			/// <summary>address3_county</summary>
			public const string Address3County = "address3_county";

			/// <summary>address3_fax</summary>
			public const string Address3Fax = "address3_fax";

			/// <summary>address3_freighttermscode</summary>
			public const string Address3FreightTerms = "address3_freighttermscode";

			/// <summary>address3_latitude</summary>
			public const string Address3Latitude = "address3_latitude";

			/// <summary>address3_line1</summary>
			public const string Address3Street1 = "address3_line1";

			/// <summary>address3_line2</summary>
			public const string Address3Street2 = "address3_line2";

			/// <summary>address3_line3</summary>
			public const string Address3Street3 = "address3_line3";

			/// <summary>address3_longitude</summary>
			public const string Address3Longitude = "address3_longitude";

			/// <summary>address3_name</summary>
			public const string Address3Name = "address3_name";

			/// <summary>address3_postalcode</summary>
			public const string Address3ZIPPostalCode = "address3_postalcode";

			/// <summary>address3_postofficebox</summary>
			public const string Address3PostOfficeBox = "address3_postofficebox";

			/// <summary>address3_primarycontactname</summary>
			public const string Address3PrimaryContactName = "address3_primarycontactname";

			/// <summary>address3_shippingmethodcode</summary>
			public const string Address3ShippingMethod = "address3_shippingmethodcode";

			/// <summary>address3_stateorprovince</summary>
			public const string Address3StateProvince = "address3_stateorprovince";

			/// <summary>address3_telephone1</summary>
			public const string Address3Telephone1 = "address3_telephone1";

			/// <summary>address3_telephone2</summary>
			public const string Address3Telephone2 = "address3_telephone2";

			/// <summary>address3_telephone3</summary>
			public const string Address3Telephone3 = "address3_telephone3";

			/// <summary>address3_upszone</summary>
			public const string Address3UPSZone = "address3_upszone";

			/// <summary>address3_utcoffset</summary>
			public const string Address3UTCOffset = "address3_utcoffset";

			/// <summary>aging30</summary>
			public const string Aging30 = "aging30";

			/// <summary>aging60</summary>
			public const string Aging60 = "aging60";

			/// <summary>aging90</summary>
			public const string Aging90 = "aging90";

			/// <summary>anniversary</summary>
			public const string Anniversary = "anniversary";

			/// <summary>annualincome</summary>
			public const string AnnualIncome = "annualincome";

			/// <summary>assistantname</summary>
			public const string Assistant = "assistantname";

			/// <summary>assistantphone</summary>
			public const string AssistantPhone = "assistantphone";

			/// <summary>birthdate</summary>
			public const string Birthday = "birthdate";

			/// <summary>business2</summary>
			public const string BusinessPhone2 = "business2";

			/// <summary>businesscard</summary>
			public const string BusinessCard = "businesscard";

			/// <summary>businesscardattributes</summary>
			public const string BusinessCardAttributes = "businesscardattributes";

			/// <summary>callback</summary>
			public const string CallbackNumber = "callback";

			/// <summary>childrensnames</summary>
			public const string ChildrensNames = "childrensnames";

			/// <summary>company</summary>
			public const string CompanyPhone = "company";

			/// <summary>contactid</summary>
			public const string ContactId = "contactid";

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

			/// <summary>defaultpricelevelid</summary>
			public const string PriceList = "defaultpricelevelid";

			/// <summary>defaultpricelevelidname</summary>
			public const string Defaultpricelevelidname = "defaultpricelevelidname";

			/// <summary>department</summary>
			public const string Department = "department";

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

			/// <summary>educationcode</summary>
			public const string Education = "educationcode";

			/// <summary>emailaddress1</summary>
			public const string Email = "emailaddress1";

			/// <summary>emailaddress2</summary>
			public const string EmailAddress2 = "emailaddress2";

			/// <summary>emailaddress3</summary>
			public const string EmailAddress3 = "emailaddress3";

			/// <summary>employeeid</summary>
			public const string Employee = "employeeid";

			/// <summary>entityimage_timestamp</summary>
			public const string EntityimageTimestamp = "entityimage_timestamp";

			/// <summary>entityimage_url</summary>
			public const string EntityimageUrl = "entityimage_url";

			/// <summary>entityimageid</summary>
			public const string EntityImageId = "entityimageid";

			/// <summary>exchangerate</summary>
			public const string ExchangeRate = "exchangerate";

			/// <summary>externaluseridentifier</summary>
			public const string ExternalUserIdentifier = "externaluseridentifier";

			/// <summary>familystatuscode</summary>
			public const string MaritalStatus = "familystatuscode";

			/// <summary>fax</summary>
			public const string Fax = "fax";

			/// <summary>firstname</summary>
			public const string FirstName = "firstname";

			/// <summary>followemail</summary>
			public const string FollowEmailActivity = "followemail";

			/// <summary>ftpsiteurl</summary>
			public const string FTPSite = "ftpsiteurl";

			/// <summary>fullname</summary>
			public const string FullName = "fullname";

			/// <summary>gendercode</summary>
			public const string Gender = "gendercode";

			/// <summary>governmentid</summary>
			public const string Government = "governmentid";

			/// <summary>haschildrencode</summary>
			public const string HasChildren = "haschildrencode";

			/// <summary>home2</summary>
			public const string HomePhone2 = "home2";

			/// <summary>importsequencenumber</summary>
			public const string ImportSequenceNumber = "importsequencenumber";

			/// <summary>isautocreate</summary>
			public const string Autocreated = "isautocreate";

			/// <summary>isbackofficecustomer</summary>
			public const string BackOfficeCustomer = "isbackofficecustomer";

			/// <summary>isprivate</summary>
			public const string Isprivate = "isprivate";

			/// <summary>jobtitle</summary>
			public const string JobTitle = "jobtitle";

			/// <summary>lastname</summary>
			public const string LastName = "lastname";

			/// <summary>lastonholdtime</summary>
			public const string LastOnHoldTime = "lastonholdtime";

			/// <summary>lastusedincampaign</summary>
			public const string LastDateIncludedInCampaign = "lastusedincampaign";

			/// <summary>leadsourcecode</summary>
			public const string LeadSource = "leadsourcecode";

			/// <summary>managername</summary>
			public const string Manager = "managername";

			/// <summary>managerphone</summary>
			public const string ManagerPhone = "managerphone";

			/// <summary>marketingonly</summary>
			public const string MarketingOnly = "marketingonly";

			/// <summary>mastercontactidname</summary>
			public const string Mastercontactidname = "mastercontactidname";

			/// <summary>mastercontactidyominame</summary>
			public const string Mastercontactidyominame = "mastercontactidyominame";

			/// <summary>masterid</summary>
			public const string MasterID = "masterid";

			/// <summary>merged</summary>
			public const string Merged = "merged";

			/// <summary>middlename</summary>
			public const string MiddleName = "middlename";

			/// <summary>mobilephone</summary>
			public const string MobilePhone = "mobilephone";

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

			/// <summary>msdyn_gdproptout</summary>
			public const string GDPROptout = "msdyn_gdproptout";

			/// <summary>msdyn_orgchangestatus</summary>
			public const string NotAtCompanyFlag = "msdyn_orgchangestatus";

			/// <summary>nickname</summary>
			public const string Nickname = "nickname";

			/// <summary>numberofchildren</summary>
			public const string NoOfChildren = "numberofchildren";

			/// <summary>onholdtime</summary>
			public const string OnHoldTimeMinutes = "onholdtime";

			/// <summary>originatingleadid</summary>
			public const string OriginatingLead = "originatingleadid";

			/// <summary>originatingleadidname</summary>
			public const string Originatingleadidname = "originatingleadidname";

			/// <summary>originatingleadidyominame</summary>
			public const string Originatingleadidyominame = "originatingleadidyominame";

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

			/// <summary>parentcontactid</summary>
			public const string ParentContact = "parentcontactid";

			/// <summary>parentcontactidname</summary>
			public const string Parentcontactidname = "parentcontactidname";

			/// <summary>parentcontactidyominame</summary>
			public const string Parentcontactidyominame = "parentcontactidyominame";

			/// <summary>parentcustomerid</summary>
			public const string CompanyName = "parentcustomerid";

			/// <summary>parentcustomeridname</summary>
			public const string Parentcustomeridname = "parentcustomeridname";

			/// <summary>parentcustomeridtype</summary>
			public const string ParentCustomerType = "parentcustomeridtype";

			/// <summary>parentcustomeridyominame</summary>
			public const string Parentcustomeridyominame = "parentcustomeridyominame";

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

			/// <summary>preferredequipmentid</summary>
			public const string PreferredFacilityEquipment = "preferredequipmentid";

			/// <summary>preferredequipmentidname</summary>
			public const string Preferredequipmentidname = "preferredequipmentidname";

			/// <summary>preferredserviceid</summary>
			public const string PreferredService = "preferredserviceid";

			/// <summary>preferredserviceidname</summary>
			public const string Preferredserviceidname = "preferredserviceidname";

			/// <summary>preferredsystemuserid</summary>
			public const string PreferredUser = "preferredsystemuserid";

			/// <summary>preferredsystemuseridname</summary>
			public const string Preferredsystemuseridname = "preferredsystemuseridname";

			/// <summary>preferredsystemuseridyominame</summary>
			public const string Preferredsystemuseridyominame = "preferredsystemuseridyominame";

			/// <summary>processid</summary>
			public const string ProcessId = "processid";

			/// <summary>salutation</summary>
			public const string Salutation = "salutation";

			/// <summary>shippingmethodcode</summary>
			public const string ShippingMethod = "shippingmethodcode";

			/// <summary>slaid</summary>
			public const string SLA = "slaid";

			/// <summary>slainvokedid</summary>
			public const string LastSLAApplied = "slainvokedid";

			/// <summary>slainvokedidname</summary>
			public const string Slainvokedidname = "slainvokedidname";

			/// <summary>slaname</summary>
			public const string Slaname = "slaname";

			/// <summary>spousesname</summary>
			public const string SpousePartnerName = "spousesname";

			/// <summary>stageid</summary>
			public const string DeprecatedProcessStageId = "stageid";

			/// <summary>statecode</summary>
			public const string Status = "statecode";

			/// <summary>statuscode</summary>
			public const string StatusReason = "statuscode";

			/// <summary>subscriptionid</summary>
			public const string SubscriptionId = "subscriptionid";

			/// <summary>suffix</summary>
			public const string Suffix = "suffix";

			/// <summary>teamsfollowed</summary>
			public const string TeamsFollowed = "teamsfollowed";

			/// <summary>telephone1</summary>
			public const string BusinessPhone = "telephone1";

			/// <summary>telephone2</summary>
			public const string HomePhone = "telephone2";

			/// <summary>telephone3</summary>
			public const string Telephone3 = "telephone3";

			/// <summary>territorycode</summary>
			public const string Territory = "territorycode";

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
			/// <summary>1:N account_primary_contact</summary>
			public const string AccountPrimaryContact = "account_primary_contact";

			/// <summary>1:N contact_actioncard</summary>
			public const string ContactActioncard = "contact_actioncard";

			/// <summary>1:N contact_activity_parties</summary>
			public const string ContactActivityParties = "contact_activity_parties";

			/// <summary>1:N Contact_ActivityPointers</summary>
			public const string ContactActivityPointers = "Contact_ActivityPointers";

			/// <summary>1:N Contact_Annotation</summary>
			public const string ContactAnnotation = "Contact_Annotation";

			/// <summary>1:N Contact_Appointments</summary>
			public const string ContactAppointments = "Contact_Appointments";

			/// <summary>1:N contact_as_primary_contact</summary>
			public const string ContactAsPrimaryContact = "contact_as_primary_contact";

			/// <summary>1:N contact_as_responsible_contact</summary>
			public const string ContactAsResponsibleContact = "contact_as_responsible_contact";

			/// <summary>1:N Contact_AsyncOperations</summary>
			public const string ContactAsyncOperations = "Contact_AsyncOperations";

			/// <summary>1:N contact_bookableresource_ContactId</summary>
			public const string ContactBookableresourceContactId = "contact_bookableresource_ContactId";

			/// <summary>1:N Contact_BulkDeleteFailures</summary>
			public const string ContactBulkDeleteFailures = "Contact_BulkDeleteFailures";

			/// <summary>1:N contact_BulkOperations</summary>
			public const string ContactBulkOperations = "contact_BulkOperations";

			/// <summary>1:N contact_CampaignResponses</summary>
			public const string ContactCampaignResponses = "contact_CampaignResponses";

			/// <summary>1:N contact_connections1</summary>
			public const string ContactConnections1 = "contact_connections1";

			/// <summary>1:N contact_connections2</summary>
			public const string ContactConnections2 = "contact_connections2";

			/// <summary>1:N contact_customer_contacts</summary>
			public const string ContactCustomerContacts = "contact_customer_contacts";

			/// <summary>1:N Contact_CustomerAddress</summary>
			public const string ContactCustomerAddress = "Contact_CustomerAddress";

			/// <summary>1:N Contact_DuplicateBaseRecord</summary>
			public const string ContactDuplicateBaseRecord = "Contact_DuplicateBaseRecord";

			/// <summary>1:N Contact_DuplicateMatchingRecord</summary>
			public const string ContactDuplicateMatchingRecord = "Contact_DuplicateMatchingRecord";

			/// <summary>1:N Contact_Email_EmailSender</summary>
			public const string ContactEmailEmailSender = "Contact_Email_EmailSender";

			/// <summary>1:N Contact_Emails</summary>
			public const string ContactEmails = "Contact_Emails";

			/// <summary>1:N contact_entitlement_ContactId</summary>
			public const string ContactEntitlementContactId = "contact_entitlement_ContactId";

			/// <summary>1:N contact_entitlement_Customer</summary>
			public const string ContactEntitlementCustomer = "contact_entitlement_Customer";

			/// <summary>1:N Contact_Faxes</summary>
			public const string ContactFaxes = "Contact_Faxes";

			/// <summary>1:N Contact_Feedback</summary>
			public const string ContactFeedback = "Contact_Feedback";

			/// <summary>1:N Contact_Letters</summary>
			public const string ContactLetters = "Contact_Letters";

			/// <summary>1:N Contact_MailboxTrackingFolder</summary>
			public const string ContactMailboxTrackingFolder = "Contact_MailboxTrackingFolder";

			/// <summary>1:N contact_master_contact</summary>
			public const string ContactMasterContact = "contact_master_contact";

			/// <summary>1:N Contact_Phonecalls</summary>
			public const string ContactPhonecalls = "Contact_Phonecalls";

			/// <summary>1:N contact_PostFollows</summary>
			public const string ContactPostFollows = "contact_PostFollows";

			/// <summary>1:N contact_principalobjectattributeaccess</summary>
			public const string ContactPrincipalobjectattributeaccess = "contact_principalobjectattributeaccess";

			/// <summary>1:N Contact_ProcessSessions</summary>
			public const string ContactProcessSessions = "Contact_ProcessSessions";

			/// <summary>1:N Contact_RecurringAppointmentMasters</summary>
			public const string ContactRecurringAppointmentMasters = "Contact_RecurringAppointmentMasters";

			/// <summary>1:N Contact_ServiceAppointments</summary>
			public const string ContactServiceAppointments = "Contact_ServiceAppointments";

			/// <summary>1:N contact_SharePointDocumentLocations</summary>
			public const string ContactSharePointDocumentLocations = "contact_SharePointDocumentLocations";

			/// <summary>1:N Contact_SocialActivities</summary>
			public const string ContactSocialActivities = "Contact_SocialActivities";

			/// <summary>1:N Contact_SyncErrors</summary>
			public const string ContactSyncErrors = "Contact_SyncErrors";

			/// <summary>1:N Contact_Tasks</summary>
			public const string ContactTasks = "Contact_Tasks";

			/// <summary>1:N contract_billingcustomer_contacts</summary>
			public const string ContractBillingcustomerContacts = "contract_billingcustomer_contacts";

			/// <summary>1:N contract_customer_contacts</summary>
			public const string ContractCustomerContacts = "contract_customer_contacts";

			/// <summary>1:N contractlineitem_customer_contacts</summary>
			public const string ContractlineitemCustomerContacts = "contractlineitem_customer_contacts";

			/// <summary>1:N incident_customer_contacts</summary>
			public const string IncidentCustomerContacts = "incident_customer_contacts";

			/// <summary>1:N invoice_customer_contacts</summary>
			public const string InvoiceCustomerContacts = "invoice_customer_contacts";

			/// <summary>1:N lead_customer_contacts</summary>
			public const string LeadCustomerContacts = "lead_customer_contacts";

			/// <summary>1:N lead_parent_contact</summary>
			public const string LeadParentContact = "lead_parent_contact";

			/// <summary>1:N lk_contact_feedback_createdby</summary>
			public const string LkContactFeedbackCreatedby = "lk_contact_feedback_createdby";

			/// <summary>1:N lk_contact_feedback_createdonbehalfby</summary>
			public const string LkContactFeedbackCreatedonbehalfby = "lk_contact_feedback_createdonbehalfby";

			/// <summary>1:N msdyn_playbookinstance_contact</summary>
			public const string MsdynPlaybookinstanceContact = "msdyn_playbookinstance_contact";

			/// <summary>1:N opportunity_customer_contacts</summary>
			public const string OpportunityCustomerContacts = "opportunity_customer_contacts";

			/// <summary>1:N opportunity_parent_contact</summary>
			public const string OpportunityParentContact = "opportunity_parent_contact";

			/// <summary>1:N order_customer_contacts</summary>
			public const string OrderCustomerContacts = "order_customer_contacts";

			/// <summary>1:N quote_customer_contacts</summary>
			public const string QuoteCustomerContacts = "quote_customer_contacts";

			/// <summary>1:N slakpiinstance_contact</summary>
			public const string SlakpiinstanceContact = "slakpiinstance_contact";

			/// <summary>1:N socialactivity_postauthor_contacts</summary>
			public const string SocialactivityPostauthorContacts = "socialactivity_postauthor_contacts";

			/// <summary>1:N socialactivity_postauthoraccount_contacts</summary>
			public const string SocialactivityPostauthoraccountContacts = "socialactivity_postauthoraccount_contacts";

			/// <summary>1:N Socialprofile_customer_contacts</summary>
			public const string SocialprofileCustomerContacts = "Socialprofile_customer_contacts";

			/// <summary>N:N BulkOperation_Contacts</summary>
			public const string BulkOperationContacts = "BulkOperation_Contacts";

			/// <summary>N:N CampaignActivity_Contacts</summary>
			public const string CampaignActivityContacts = "CampaignActivity_Contacts";

			/// <summary>N:N contactinvoices_association</summary>
			public const string ContactinvoicesAssociation = "contactinvoices_association";

			/// <summary>N:N contactleads_association</summary>
			public const string ContactleadsAssociation = "contactleads_association";

			/// <summary>N:N contactorders_association</summary>
			public const string ContactordersAssociation = "contactorders_association";

			/// <summary>N:N contactquotes_association</summary>
			public const string ContactquotesAssociation = "contactquotes_association";

			/// <summary>N:N entitlementcontacts_association</summary>
			public const string EntitlementcontactsAssociation = "entitlementcontacts_association";

			/// <summary>N:N listcontact_association</summary>
			public const string ListcontactAssociation = "listcontact_association";

			/// <summary>N:N servicecontractcontacts_association</summary>
			public const string ServicecontractcontactsAssociation = "servicecontractcontacts_association";

		}
		#endregion
	}
}

