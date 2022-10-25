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
	[EntityLogicalName("systemuser")]
	public sealed class User : Entity
	{	
		public static readonly int? EntityTypeCode = 8;
		public new const string LogicalName = "systemuser";
		public const string PrimaryIdAttribute = "systemuserid";
		public const string PrimaryNameAttribute = "fullname";
	
		public User() : base("systemuser") { }

		#region Attributes
		/// <summary>
        /// accessmode
        /// </summary>
		[DisplayName("Access Mode")]
		[AttributeLogicalName("accessmode")]
		public eAccessMode? AccessMode
		{	
			get 
			{ 
				var optionSetValue = GetAttributeValue<OptionSetValue>("accessmode");
				if (optionSetValue != null) return (eAccessMode)optionSetValue.Value;
				else return null;
			}
			set 
			{ 
				if(value == AccessMode) return;

				OptionSetValue optionSetValue = null;
				if(value != null) optionSetValue = new OptionSetValue((int)value);
				SetAttributeValue("accessmode", optionSetValue); 
			}
		}

		/// <summary>
        /// activedirectoryguid
        /// </summary>
		[DisplayName("Active Directory Guid")]
		[AttributeLogicalName("activedirectoryguid")]
		public Guid ActiveDirectoryGuId
		{	
			get { return GetAttributeValue<Guid>("activedirectoryguid"); }
			set
			{ 
				if(value == ActiveDirectoryGuId) return;
				SetAttributeValue("activedirectoryguid", value);
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
		[DisplayName("Address")]
		[AttributeLogicalName("address1_composite")]
		public string Address
		{	
			get { return GetAttributeValue<string>("address1_composite"); }
			set
			{ 
				if(value == Address) return;
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
		[DisplayName("Pager")]
		[AttributeLogicalName("address1_telephone3")]
		public string Pager
		{	
			get { return GetAttributeValue<string>("address1_telephone3"); }
			set
			{ 
				if(value == Pager) return;
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
		[DisplayName("Other City")]
		[AttributeLogicalName("address2_city")]
		public string OtherCity
		{	
			get { return GetAttributeValue<string>("address2_city"); }
			set
			{ 
				if(value == OtherCity) return;
				SetAttributeValue("address2_city", value);
			}
		}	
			
		/// <summary>
        /// address2_composite
        /// </summary>
		[DisplayName("Other Address")]
		[AttributeLogicalName("address2_composite")]
		public string OtherAddress
		{	
			get { return GetAttributeValue<string>("address2_composite"); }
			set
			{ 
				if(value == OtherAddress) return;
				SetAttributeValue("address2_composite", value);
			}
		}	
			
		/// <summary>
        /// address2_country
        /// </summary>
		[DisplayName("Other Country/Region")]
		[AttributeLogicalName("address2_country")]
		public string OtherCountryRegion
		{	
			get { return GetAttributeValue<string>("address2_country"); }
			set
			{ 
				if(value == OtherCountryRegion) return;
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
		[DisplayName("Other Street 1")]
		[AttributeLogicalName("address2_line1")]
		public string OtherStreet1
		{	
			get { return GetAttributeValue<string>("address2_line1"); }
			set
			{ 
				if(value == OtherStreet1) return;
				SetAttributeValue("address2_line1", value);
			}
		}	
			
		/// <summary>
        /// address2_line2
        /// </summary>
		[DisplayName("Other Street 2")]
		[AttributeLogicalName("address2_line2")]
		public string OtherStreet2
		{	
			get { return GetAttributeValue<string>("address2_line2"); }
			set
			{ 
				if(value == OtherStreet2) return;
				SetAttributeValue("address2_line2", value);
			}
		}	
			
		/// <summary>
        /// address2_line3
        /// </summary>
		[DisplayName("Other Street 3")]
		[AttributeLogicalName("address2_line3")]
		public string OtherStreet3
		{	
			get { return GetAttributeValue<string>("address2_line3"); }
			set
			{ 
				if(value == OtherStreet3) return;
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
		[DisplayName("Other ZIP/Postal Code")]
		[AttributeLogicalName("address2_postalcode")]
		public string OtherZIPPostalCode
		{	
			get { return GetAttributeValue<string>("address2_postalcode"); }
			set
			{ 
				if(value == OtherZIPPostalCode) return;
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
		[DisplayName("Other State/Province")]
		[AttributeLogicalName("address2_stateorprovince")]
		public string OtherStateProvince
		{	
			get { return GetAttributeValue<string>("address2_stateorprovince"); }
			set
			{ 
				if(value == OtherStateProvince) return;
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
        /// applicationid
        /// </summary>
		[DisplayName("Application ID")]
		[AttributeLogicalName("applicationid")]
		public Guid ApplicationId
		{	
			get { return GetAttributeValue<Guid>("applicationid"); }
			set
			{ 
				if(value == ApplicationId) return;
				SetAttributeValue("applicationid", value);
			}
		}	
			
		/// <summary>
        /// applicationiduri
        /// </summary>
		[DisplayName("Application ID URI")]
		[AttributeLogicalName("applicationiduri")]
		public string ApplicationIDURI
		{	
			get { return GetAttributeValue<string>("applicationiduri"); }
			set
			{ 
				if(value == ApplicationIDURI) return;
				SetAttributeValue("applicationiduri", value);
			}
		}	
			
		/// <summary>
        /// azureactivedirectoryobjectid
        /// </summary>
		[DisplayName("Azure AD Object ID")]
		[AttributeLogicalName("azureactivedirectoryobjectid")]
		public Guid AzureADObjectId
		{	
			get { return GetAttributeValue<Guid>("azureactivedirectoryobjectid"); }
			set
			{ 
				if(value == AzureADObjectId) return;
				SetAttributeValue("azureactivedirectoryobjectid", value);
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
        /// caltype
        /// </summary>
		[DisplayName("License Type")]
		[AttributeLogicalName("caltype")]
		public eCALTypes? LicenseType
		{	
			get 
			{ 
				var optionSetValue = GetAttributeValue<OptionSetValue>("caltype");
				if (optionSetValue != null) return (eCALTypes)optionSetValue.Value;
				else return null;
			}
			set 
			{ 
				if(value == LicenseType) return;

				OptionSetValue optionSetValue = null;
				if(value != null) optionSetValue = new OptionSetValue((int)value);
				SetAttributeValue("caltype", optionSetValue); 
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
        /// defaultfilterspopulated
        /// </summary>
		[DisplayName("Default Filters Populated")]
		[AttributeLogicalName("defaultfilterspopulated")]
		public bool? DefaultFiltersPopulated
		{	
			get { return GetAttributeValue<bool?>("defaultfilterspopulated"); }
			set
			{ 
				if(value == DefaultFiltersPopulated) return;
				SetAttributeValue("defaultfilterspopulated", value);
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
        /// defaultodbfoldername
        /// </summary>
		[DisplayName("Default OneDrive for Business Folder Name")]
		[AttributeLogicalName("defaultodbfoldername")]
		public string DefaultOneDriveForBusinessFolderName
		{	
			get { return GetAttributeValue<string>("defaultodbfoldername"); }
			set
			{ 
				if(value == DefaultOneDriveForBusinessFolderName) return;
				SetAttributeValue("defaultodbfoldername", value);
			}
		}	
			
		/// <summary>
        /// disabledreason
        /// </summary>
		[DisplayName("Disabled Reason")]
		[AttributeLogicalName("disabledreason")]
		public string DisabledReason
		{	
			get { return GetAttributeValue<string>("disabledreason"); }
			set
			{ 
				if(value == DisabledReason) return;
				SetAttributeValue("disabledreason", value);
			}
		}	
			
		/// <summary>
        /// displayinserviceviews
        /// </summary>
		[DisplayName("Display in Service Views")]
		[AttributeLogicalName("displayinserviceviews")]
		public bool? DisplayInServiceViews
		{	
			get { return GetAttributeValue<bool?>("displayinserviceviews"); }
			set
			{ 
				if(value == DisplayInServiceViews) return;
				SetAttributeValue("displayinserviceviews", value);
			}
		}	
			
		/// <summary>
        /// domainname
        /// </summary>
		[DisplayName("User Name")]
		[AttributeLogicalName("domainname")]
		public string UserName
		{	
			get { return GetAttributeValue<string>("domainname"); }
			set
			{ 
				if(value == UserName) return;
				SetAttributeValue("domainname", value);
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
        /// homephone
        /// </summary>
		[DisplayName("Home Phone")]
		[AttributeLogicalName("homephone")]
		public string HomePhone
		{	
			get { return GetAttributeValue<string>("homephone"); }
			set
			{ 
				if(value == HomePhone) return;
				SetAttributeValue("homephone", value);
			}
		}	
			
		/// <summary>
        /// identityid
        /// </summary>
		[DisplayName("Unique user identity id")]
		[AttributeLogicalName("identityid")]
		public int? UniqueUserIdentityId
		{	
			get { return GetAttributeValue<int?>("identityid"); }
			set
			{ 
				if(value == UniqueUserIdentityId) return;
				SetAttributeValue("identityid", value);
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
        /// internalemailaddress
        /// </summary>
		[DisplayName("Primary Email")]
		[AttributeLogicalName("internalemailaddress")]
		public string PrimaryEmail
		{	
			get { return GetAttributeValue<string>("internalemailaddress"); }
			set
			{ 
				if(value == PrimaryEmail) return;
				SetAttributeValue("internalemailaddress", value);
			}
		}	
			
		/// <summary>
        /// invitestatuscode
        /// </summary>
		[DisplayName("Invitation Status")]
		[AttributeLogicalName("invitestatuscode")]
		public eInvitationStatus? InvitationStatus
		{	
			get 
			{ 
				var optionSetValue = GetAttributeValue<OptionSetValue>("invitestatuscode");
				if (optionSetValue != null) return (eInvitationStatus)optionSetValue.Value;
				else return null;
			}
			set 
			{ 
				if(value == InvitationStatus) return;

				OptionSetValue optionSetValue = null;
				if(value != null) optionSetValue = new OptionSetValue((int)value);
				SetAttributeValue("invitestatuscode", optionSetValue); 
			}
		}

		/// <summary>
        /// isactivedirectoryuser
        /// </summary>
		[DisplayName("Is Active Directory User")]
		[AttributeLogicalName("isactivedirectoryuser")]
		public bool? IsActiveDirectoryUser
		{	
			get { return GetAttributeValue<bool?>("isactivedirectoryuser"); }
			set
			{ 
				if(value == IsActiveDirectoryUser) return;
				SetAttributeValue("isactivedirectoryuser", value);
			}
		}	
			
		/// <summary>
        /// isdisabled
        /// </summary>
		[DisplayName("Status")]
		[AttributeLogicalName("isdisabled")]
		public bool? Status
		{	
			get { return GetAttributeValue<bool?>("isdisabled"); }
			set
			{ 
				if(value == Status) return;
				SetAttributeValue("isdisabled", value);
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
        /// isintegrationuser
        /// </summary>
		[DisplayName("Integration user mode")]
		[AttributeLogicalName("isintegrationuser")]
		public bool? IntegrationUserMode
		{	
			get { return GetAttributeValue<bool?>("isintegrationuser"); }
			set
			{ 
				if(value == IntegrationUserMode) return;
				SetAttributeValue("isintegrationuser", value);
			}
		}	
			
		/// <summary>
        /// islicensed
        /// </summary>
		[DisplayName("User Licensed")]
		[AttributeLogicalName("islicensed")]
		public bool? UserLicensed
		{	
			get { return GetAttributeValue<bool?>("islicensed"); }
			set
			{ 
				if(value == UserLicensed) return;
				SetAttributeValue("islicensed", value);
			}
		}	
			
		/// <summary>
        /// issyncwithdirectory
        /// </summary>
		[DisplayName("User Synced")]
		[AttributeLogicalName("issyncwithdirectory")]
		public bool? UserSynced
		{	
			get { return GetAttributeValue<bool?>("issyncwithdirectory"); }
			set
			{ 
				if(value == UserSynced) return;
				SetAttributeValue("issyncwithdirectory", value);
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
        /// latestupdatetime
        /// </summary>
		[DisplayName("Latest User Update Time")]
		[AttributeLogicalName("latestupdatetime")]
		public DateTime? LatestUserUpdateTime
		{	
			get { return GetAttributeValue<DateTime?>("latestupdatetime"); }
			set
			{ 
				if(value == LatestUserUpdateTime) return;
				SetAttributeValue("latestupdatetime", value);
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
        /// mobilealertemail
        /// </summary>
		[DisplayName("Mobile Alert Email")]
		[AttributeLogicalName("mobilealertemail")]
		public string MobileAlertEmail
		{	
			get { return GetAttributeValue<string>("mobilealertemail"); }
			set
			{ 
				if(value == MobileAlertEmail) return;
				SetAttributeValue("mobilealertemail", value);
			}
		}	
			
		/// <summary>
        /// mobileofflineprofileid
        /// </summary>
		[DisplayName("Mobile Offline Profile")]
		[AttributeLogicalName("mobileofflineprofileid")]
		public EntityReference MobileOfflineProfile
		{	
			get { return GetAttributeValue<EntityReference>("mobileofflineprofileid"); }
			set
			{ 
				if(value == MobileOfflineProfile) return;
				SetAttributeValue("mobileofflineprofileid", value);
			}
		}	
			
		/// <summary>
        /// mobileofflineprofileidname
        /// </summary>
		[DisplayName("mobileofflineprofileidname")]
		[AttributeLogicalName("mobileofflineprofileidname")]
		public string Mobileofflineprofileidname
		{	
			get { return GetAttributeValue<string>("mobileofflineprofileidname"); }
			set
			{ 
				if(value == Mobileofflineprofileidname) return;
				SetAttributeValue("mobileofflineprofileidname", value);
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
        /// organizationid
        /// </summary>
		[DisplayName("Organization")]
		[AttributeLogicalName("organizationid")]
		public Guid OrganizationId
		{	
			get { return GetAttributeValue<Guid>("organizationid"); }
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
        /// parentsystemuserid
        /// </summary>
		[DisplayName("Manager")]
		[AttributeLogicalName("parentsystemuserid")]
		public EntityReference Manager
		{	
			get { return GetAttributeValue<EntityReference>("parentsystemuserid"); }
			set
			{ 
				if(value == Manager) return;
				SetAttributeValue("parentsystemuserid", value);
			}
		}	
			
		/// <summary>
        /// parentsystemuseridname
        /// </summary>
		[DisplayName("parentsystemuseridname")]
		[AttributeLogicalName("parentsystemuseridname")]
		public string Parentsystemuseridname
		{	
			get { return GetAttributeValue<string>("parentsystemuseridname"); }
			set
			{ 
				if(value == Parentsystemuseridname) return;
				SetAttributeValue("parentsystemuseridname", value);
			}
		}	
			
		/// <summary>
        /// parentsystemuseridyominame
        /// </summary>
		[DisplayName("parentsystemuseridyominame")]
		[AttributeLogicalName("parentsystemuseridyominame")]
		public string Parentsystemuseridyominame
		{	
			get { return GetAttributeValue<string>("parentsystemuseridyominame"); }
			set
			{ 
				if(value == Parentsystemuseridyominame) return;
				SetAttributeValue("parentsystemuseridyominame", value);
			}
		}	
			
		/// <summary>
        /// passporthi
        /// </summary>
		[DisplayName("Passport Hi")]
		[AttributeLogicalName("passporthi")]
		public int? PassportHi
		{	
			get { return GetAttributeValue<int?>("passporthi"); }
			set
			{ 
				if(value == PassportHi) return;
				SetAttributeValue("passporthi", value);
			}
		}	
			
		/// <summary>
        /// passportlo
        /// </summary>
		[DisplayName("Passport Lo")]
		[AttributeLogicalName("passportlo")]
		public int? PassportLo
		{	
			get { return GetAttributeValue<int?>("passportlo"); }
			set
			{ 
				if(value == PassportLo) return;
				SetAttributeValue("passportlo", value);
			}
		}	
			
		/// <summary>
        /// personalemailaddress
        /// </summary>
		[DisplayName("Email 2")]
		[AttributeLogicalName("personalemailaddress")]
		public string Email2
		{	
			get { return GetAttributeValue<string>("personalemailaddress"); }
			set
			{ 
				if(value == Email2) return;
				SetAttributeValue("personalemailaddress", value);
			}
		}	
			
		/// <summary>
        /// photourl
        /// </summary>
		[DisplayName("Photo URL")]
		[AttributeLogicalName("photourl")]
		public string PhotoURL
		{	
			get { return GetAttributeValue<string>("photourl"); }
			set
			{ 
				if(value == PhotoURL) return;
				SetAttributeValue("photourl", value);
			}
		}	
			
		/// <summary>
        /// positionid
        /// </summary>
		[DisplayName("Position")]
		[AttributeLogicalName("positionid")]
		public EntityReference Position
		{	
			get { return GetAttributeValue<EntityReference>("positionid"); }
			set
			{ 
				if(value == Position) return;
				SetAttributeValue("positionid", value);
			}
		}	
			
		/// <summary>
        /// positionidname
        /// </summary>
		[DisplayName("positionidname")]
		[AttributeLogicalName("positionidname")]
		public string Positionidname
		{	
			get { return GetAttributeValue<string>("positionidname"); }
			set
			{ 
				if(value == Positionidname) return;
				SetAttributeValue("positionidname", value);
			}
		}	
			
		/// <summary>
        /// preferredaddresscode
        /// </summary>
		[DisplayName("Preferred Address")]
		[AttributeLogicalName("preferredaddresscode")]
		public ePreferredAddress? PreferredAddress
		{	
			get 
			{ 
				var optionSetValue = GetAttributeValue<OptionSetValue>("preferredaddresscode");
				if (optionSetValue != null) return (ePreferredAddress)optionSetValue.Value;
				else return null;
			}
			set 
			{ 
				if(value == PreferredAddress) return;

				OptionSetValue optionSetValue = null;
				if(value != null) optionSetValue = new OptionSetValue((int)value);
				SetAttributeValue("preferredaddresscode", optionSetValue); 
			}
		}

		/// <summary>
        /// preferredemailcode
        /// </summary>
		[DisplayName("Preferred Email")]
		[AttributeLogicalName("preferredemailcode")]
		public ePreferredEmail? PreferredEmail
		{	
			get 
			{ 
				var optionSetValue = GetAttributeValue<OptionSetValue>("preferredemailcode");
				if (optionSetValue != null) return (ePreferredEmail)optionSetValue.Value;
				else return null;
			}
			set 
			{ 
				if(value == PreferredEmail) return;

				OptionSetValue optionSetValue = null;
				if(value != null) optionSetValue = new OptionSetValue((int)value);
				SetAttributeValue("preferredemailcode", optionSetValue); 
			}
		}

		/// <summary>
        /// preferredphonecode
        /// </summary>
		[DisplayName("Preferred Phone")]
		[AttributeLogicalName("preferredphonecode")]
		public ePreferredPhone? PreferredPhone
		{	
			get 
			{ 
				var optionSetValue = GetAttributeValue<OptionSetValue>("preferredphonecode");
				if (optionSetValue != null) return (ePreferredPhone)optionSetValue.Value;
				else return null;
			}
			set 
			{ 
				if(value == PreferredPhone) return;

				OptionSetValue optionSetValue = null;
				if(value != null) optionSetValue = new OptionSetValue((int)value);
				SetAttributeValue("preferredphonecode", optionSetValue); 
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
        /// queueid
        /// </summary>
		[DisplayName("Default Queue")]
		[AttributeLogicalName("queueid")]
		public EntityReference DefaultQueue
		{	
			get { return GetAttributeValue<EntityReference>("queueid"); }
			set
			{ 
				if(value == DefaultQueue) return;
				SetAttributeValue("queueid", value);
			}
		}	
			
		/// <summary>
        /// queueidname
        /// </summary>
		[DisplayName("queueidname")]
		[AttributeLogicalName("queueidname")]
		public string Queueidname
		{	
			get { return GetAttributeValue<string>("queueidname"); }
			set
			{ 
				if(value == Queueidname) return;
				SetAttributeValue("queueidname", value);
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
        /// setupuser
        /// </summary>
		[DisplayName("Restricted Access Mode")]
		[AttributeLogicalName("setupuser")]
		public bool? RestrictedAccessMode
		{	
			get { return GetAttributeValue<bool?>("setupuser"); }
			set
			{ 
				if(value == RestrictedAccessMode) return;
				SetAttributeValue("setupuser", value);
			}
		}	
			
		/// <summary>
        /// sharepointemailaddress
        /// </summary>
		[DisplayName("SharePoint Email Address")]
		[AttributeLogicalName("sharepointemailaddress")]
		public string SharePointEmailAddress
		{	
			get { return GetAttributeValue<string>("sharepointemailaddress"); }
			set
			{ 
				if(value == SharePointEmailAddress) return;
				SetAttributeValue("sharepointemailaddress", value);
			}
		}	
			
		/// <summary>
        /// siteid
        /// </summary>
		[DisplayName("Site")]
		[AttributeLogicalName("siteid")]
		public EntityReference Site
		{	
			get { return GetAttributeValue<EntityReference>("siteid"); }
			set
			{ 
				if(value == Site) return;
				SetAttributeValue("siteid", value);
			}
		}	
			
		/// <summary>
        /// siteidname
        /// </summary>
		[DisplayName("siteidname")]
		[AttributeLogicalName("siteidname")]
		public string Siteidname
		{	
			get { return GetAttributeValue<string>("siteidname"); }
			set
			{ 
				if(value == Siteidname) return;
				SetAttributeValue("siteidname", value);
			}
		}	
			
		/// <summary>
        /// skills
        /// </summary>
		[DisplayName("Skills")]
		[AttributeLogicalName("skills")]
		public string Skills
		{	
			get { return GetAttributeValue<string>("skills"); }
			set
			{ 
				if(value == Skills) return;
				SetAttributeValue("skills", value);
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
        /// systemuserid
        /// </summary>
		[DisplayName("User")]
		[AttributeLogicalName("systemuserid")]
		public override Guid Id
		{
			get => base.Id;
			set { base.Id = value; SetAttributeValue("systemuserid", value); }
		}

							/// <summary>
        /// territoryid
        /// </summary>
		[DisplayName("Territory")]
		[AttributeLogicalName("territoryid")]
		public EntityReference Territory
		{	
			get { return GetAttributeValue<EntityReference>("territoryid"); }
			set
			{ 
				if(value == Territory) return;
				SetAttributeValue("territoryid", value);
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
			set
			{ 
				if(value == Territoryidname) return;
				SetAttributeValue("territoryidname", value);
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
		[DisplayName("Title")]
		[AttributeLogicalName("title")]
		public string Title
		{	
			get { return GetAttributeValue<string>("title"); }
			set
			{ 
				if(value == Title) return;
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
        /// userlicensetype
        /// </summary>
		[DisplayName("User License Type")]
		[AttributeLogicalName("userlicensetype")]
		public int? UserLicenseType
		{	
			get { return GetAttributeValue<int?>("userlicensetype"); }
			set
			{ 
				if(value == UserLicenseType) return;
				SetAttributeValue("userlicensetype", value);
			}
		}	
			
		/// <summary>
        /// userpuid
        /// </summary>
		[DisplayName("User PUID")]
		[AttributeLogicalName("userpuid")]
		public string UserPUID
		{	
			get { return GetAttributeValue<string>("userpuid"); }
			set
			{ 
				if(value == UserPUID) return;
				SetAttributeValue("userpuid", value);
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
        /// windowsliveid
        /// </summary>
		[DisplayName("Windows Live ID")]
		[AttributeLogicalName("windowsliveid")]
		public string WindowsLiveID
		{	
			get { return GetAttributeValue<string>("windowsliveid"); }
			set
			{ 
				if(value == WindowsLiveID) return;
				SetAttributeValue("windowsliveid", value);
			}
		}	
			
		/// <summary>
        /// yammeremailaddress
        /// </summary>
		[DisplayName("Yammer Email")]
		[AttributeLogicalName("yammeremailaddress")]
		public string YammerEmail
		{	
			get { return GetAttributeValue<string>("yammeremailaddress"); }
			set
			{ 
				if(value == YammerEmail) return;
				SetAttributeValue("yammeremailaddress", value);
			}
		}	
			
		/// <summary>
        /// yammeruserid
        /// </summary>
		[DisplayName("Yammer User ID")]
		[AttributeLogicalName("yammeruserid")]
		public string YammerUserID
		{	
			get { return GetAttributeValue<string>("yammeruserid"); }
			set
			{ 
				if(value == YammerUserID) return;
				SetAttributeValue("yammeruserid", value);
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
        /// 1:N Get entities for 'annotation_owning_user'
        /// </summary>
		[RelationshipSchemaName("annotation_owning_user")]
		public IEnumerable<Note> AnnotationOwningUser
		{
			get { return GetRelatedEntities<Note>("annotation_owning_user", null); }
			set { SetRelatedEntities("annotation_owning_user", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'constraintbasedgroup_systemuser'
        /// </summary>
		[RelationshipSchemaName("constraintbasedgroup_systemuser")]
		public IEnumerable<ResourceGroup> ConstraintbasedgroupSystemuser
		{
			get { return GetRelatedEntities<ResourceGroup>("constraintbasedgroup_systemuser", null); }
			set { SetRelatedEntities("constraintbasedgroup_systemuser", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'contact_owning_user'
        /// </summary>
		[RelationshipSchemaName("contact_owning_user")]
		public IEnumerable<Contact> ContactOwningUser
		{
			get { return GetRelatedEntities<Contact>("contact_owning_user", null); }
			set { SetRelatedEntities("contact_owning_user", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'createdby_connection'
        /// </summary>
		[RelationshipSchemaName("createdby_connection")]
		public IEnumerable<Connection> CreatedbyConnection
		{
			get { return GetRelatedEntities<Connection>("createdby_connection", null); }
			set { SetRelatedEntities("createdby_connection", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'createdby_connection_role'
        /// </summary>
		[RelationshipSchemaName("createdby_connection_role")]
		public IEnumerable<ConnectionRole> CreatedbyConnectionRole
		{
			get { return GetRelatedEntities<ConnectionRole>("createdby_connection_role", null); }
			set { SetRelatedEntities("createdby_connection_role", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'createdby_pluginassembly'
        /// </summary>
		[RelationshipSchemaName("createdby_pluginassembly")]
		public IEnumerable<PluginAssembly> CreatedbyPluginassembly
		{
			get { return GetRelatedEntities<PluginAssembly>("createdby_pluginassembly", null); }
			set { SetRelatedEntities("createdby_pluginassembly", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'createdby_plugintracelog'
        /// </summary>
		[RelationshipSchemaName("createdby_plugintracelog")]
		public IEnumerable<PluginTraceLog> CreatedbyPlugintracelog
		{
			get { return GetRelatedEntities<PluginTraceLog>("createdby_plugintracelog", null); }
			set { SetRelatedEntities("createdby_plugintracelog", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'createdby_plugintype'
        /// </summary>
		[RelationshipSchemaName("createdby_plugintype")]
		public IEnumerable<PluginType> CreatedbyPlugintype
		{
			get { return GetRelatedEntities<PluginType>("createdby_plugintype", null); }
			set { SetRelatedEntities("createdby_plugintype", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'createdby_plugintypestatistic'
        /// </summary>
		[RelationshipSchemaName("createdby_plugintypestatistic")]
		public IEnumerable<PluginTypeStatistic> CreatedbyPlugintypestatistic
		{
			get { return GetRelatedEntities<PluginTypeStatistic>("createdby_plugintypestatistic", null); }
			set { SetRelatedEntities("createdby_plugintypestatistic", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'createdby_sdkmessage'
        /// </summary>
		[RelationshipSchemaName("createdby_sdkmessage")]
		public IEnumerable<SdkMessage> CreatedbySdkmessage
		{
			get { return GetRelatedEntities<SdkMessage>("createdby_sdkmessage", null); }
			set { SetRelatedEntities("createdby_sdkmessage", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'createdby_sdkmessagefilter'
        /// </summary>
		[RelationshipSchemaName("createdby_sdkmessagefilter")]
		public IEnumerable<SdkMessageFilter> CreatedbySdkmessagefilter
		{
			get { return GetRelatedEntities<SdkMessageFilter>("createdby_sdkmessagefilter", null); }
			set { SetRelatedEntities("createdby_sdkmessagefilter", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'createdby_sdkmessageprocessingstep'
        /// </summary>
		[RelationshipSchemaName("createdby_sdkmessageprocessingstep")]
		public IEnumerable<SdkMessageProcessingStep> CreatedbySdkmessageprocessingstep
		{
			get { return GetRelatedEntities<SdkMessageProcessingStep>("createdby_sdkmessageprocessingstep", null); }
			set { SetRelatedEntities("createdby_sdkmessageprocessingstep", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'createdby_sdkmessageprocessingstepimage'
        /// </summary>
		[RelationshipSchemaName("createdby_sdkmessageprocessingstepimage")]
		public IEnumerable<SdkMessageProcessingStepImage> CreatedbySdkmessageprocessingstepimage
		{
			get { return GetRelatedEntities<SdkMessageProcessingStepImage>("createdby_sdkmessageprocessingstepimage", null); }
			set { SetRelatedEntities("createdby_sdkmessageprocessingstepimage", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'createdby_sdkmessageprocessingstepsecureconfig'
        /// </summary>
		[RelationshipSchemaName("createdby_sdkmessageprocessingstepsecureconfig")]
		public IEnumerable<SdkMessageProcessingStepSecureConfiguration> CreatedbySdkmessageprocessingstepsecureconfig
		{
			get { return GetRelatedEntities<SdkMessageProcessingStepSecureConfiguration>("createdby_sdkmessageprocessingstepsecureconfig", null); }
			set { SetRelatedEntities("createdby_sdkmessageprocessingstepsecureconfig", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'createdby_serviceendpoint'
        /// </summary>
		[RelationshipSchemaName("createdby_serviceendpoint")]
		public IEnumerable<ServiceEndpoint> CreatedbyServiceendpoint
		{
			get { return GetRelatedEntities<ServiceEndpoint>("createdby_serviceendpoint", null); }
			set { SetRelatedEntities("createdby_serviceendpoint", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'Dynamicpropertyinsatance_createdby'
        /// </summary>
		[RelationshipSchemaName("Dynamicpropertyinsatance_createdby")]
		public IEnumerable<PropertyInstance> DynamicpropertyinsatanceCreatedby
		{
			get { return GetRelatedEntities<PropertyInstance>("Dynamicpropertyinsatance_createdby", null); }
			set { SetRelatedEntities("Dynamicpropertyinsatance_createdby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'equipment_systemuser'
        /// </summary>
		[RelationshipSchemaName("equipment_systemuser")]
		public IEnumerable<FacilityEquipment> EquipmentSystemuser
		{
			get { return GetRelatedEntities<FacilityEquipment>("equipment_systemuser", null); }
			set { SetRelatedEntities("equipment_systemuser", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'impersonatinguserid_sdkmessageprocessingstep'
        /// </summary>
		[RelationshipSchemaName("impersonatinguserid_sdkmessageprocessingstep")]
		public IEnumerable<SdkMessageProcessingStep> ImpersonatinguseridSdkmessageprocessingstep
		{
			get { return GetRelatedEntities<SdkMessageProcessingStep>("impersonatinguserid_sdkmessageprocessingstep", null); }
			set { SetRelatedEntities("impersonatinguserid_sdkmessageprocessingstep", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'ImportFile_SystemUser'
        /// </summary>
		[RelationshipSchemaName("ImportFile_SystemUser")]
		public IEnumerable<ImportSourceFile> ImportFileSystemUser
		{
			get { return GetRelatedEntities<ImportSourceFile>("ImportFile_SystemUser", null); }
			set { SetRelatedEntities("ImportFile_SystemUser", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'knowledgearticle_primaryauthorid'
        /// </summary>
		[RelationshipSchemaName("knowledgearticle_primaryauthorid")]
		public IEnumerable<KnowledgeArticle> KnowledgearticlePrimaryauthorid
		{
			get { return GetRelatedEntities<KnowledgeArticle>("knowledgearticle_primaryauthorid", null); }
			set { SetRelatedEntities("knowledgearticle_primaryauthorid", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lead_owning_user'
        /// </summary>
		[RelationshipSchemaName("lead_owning_user")]
		public IEnumerable<Lead> LeadOwningUser
		{
			get { return GetRelatedEntities<Lead>("lead_owning_user", null); }
			set { SetRelatedEntities("lead_owning_user", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_accountbase_createdby'
        /// </summary>
		[RelationshipSchemaName("lk_accountbase_createdby")]
		public IEnumerable<Account> LkAccountbaseCreatedby
		{
			get { return GetRelatedEntities<Account>("lk_accountbase_createdby", null); }
			set { SetRelatedEntities("lk_accountbase_createdby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_accountbase_createdonbehalfby'
        /// </summary>
		[RelationshipSchemaName("lk_accountbase_createdonbehalfby")]
		public IEnumerable<Account> LkAccountbaseCreatedonbehalfby
		{
			get { return GetRelatedEntities<Account>("lk_accountbase_createdonbehalfby", null); }
			set { SetRelatedEntities("lk_accountbase_createdonbehalfby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_accountbase_modifiedby'
        /// </summary>
		[RelationshipSchemaName("lk_accountbase_modifiedby")]
		public IEnumerable<Account> LkAccountbaseModifiedby
		{
			get { return GetRelatedEntities<Account>("lk_accountbase_modifiedby", null); }
			set { SetRelatedEntities("lk_accountbase_modifiedby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_accountbase_modifiedonbehalfby'
        /// </summary>
		[RelationshipSchemaName("lk_accountbase_modifiedonbehalfby")]
		public IEnumerable<Account> LkAccountbaseModifiedonbehalfby
		{
			get { return GetRelatedEntities<Account>("lk_accountbase_modifiedonbehalfby", null); }
			set { SetRelatedEntities("lk_accountbase_modifiedonbehalfby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_ACIViewMapper_createdby'
        /// </summary>
		[RelationshipSchemaName("lk_ACIViewMapper_createdby")]
		public IEnumerable<ACIViewMapper> LkACIViewMapperCreatedby
		{
			get { return GetRelatedEntities<ACIViewMapper>("lk_ACIViewMapper_createdby", null); }
			set { SetRelatedEntities("lk_ACIViewMapper_createdby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_ACIViewMapper_createdonbehalfby'
        /// </summary>
		[RelationshipSchemaName("lk_ACIViewMapper_createdonbehalfby")]
		public IEnumerable<ACIViewMapper> LkACIViewMapperCreatedonbehalfby
		{
			get { return GetRelatedEntities<ACIViewMapper>("lk_ACIViewMapper_createdonbehalfby", null); }
			set { SetRelatedEntities("lk_ACIViewMapper_createdonbehalfby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_ACIViewMapper_modifiedby'
        /// </summary>
		[RelationshipSchemaName("lk_ACIViewMapper_modifiedby")]
		public IEnumerable<ACIViewMapper> LkACIViewMapperModifiedby
		{
			get { return GetRelatedEntities<ACIViewMapper>("lk_ACIViewMapper_modifiedby", null); }
			set { SetRelatedEntities("lk_ACIViewMapper_modifiedby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_ACIViewMapper_modifiedonbehalfby'
        /// </summary>
		[RelationshipSchemaName("lk_ACIViewMapper_modifiedonbehalfby")]
		public IEnumerable<ACIViewMapper> LkACIViewMapperModifiedonbehalfby
		{
			get { return GetRelatedEntities<ACIViewMapper>("lk_ACIViewMapper_modifiedonbehalfby", null); }
			set { SetRelatedEntities("lk_ACIViewMapper_modifiedonbehalfby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_actioncardbase_createdby'
        /// </summary>
		[RelationshipSchemaName("lk_actioncardbase_createdby")]
		public IEnumerable<ActionCard> LkActioncardbaseCreatedby
		{
			get { return GetRelatedEntities<ActionCard>("lk_actioncardbase_createdby", null); }
			set { SetRelatedEntities("lk_actioncardbase_createdby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_actioncardbase_createdonbehalfby'
        /// </summary>
		[RelationshipSchemaName("lk_actioncardbase_createdonbehalfby")]
		public IEnumerable<ActionCard> LkActioncardbaseCreatedonbehalfby
		{
			get { return GetRelatedEntities<ActionCard>("lk_actioncardbase_createdonbehalfby", null); }
			set { SetRelatedEntities("lk_actioncardbase_createdonbehalfby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_actioncardbase_modifiedby'
        /// </summary>
		[RelationshipSchemaName("lk_actioncardbase_modifiedby")]
		public IEnumerable<ActionCard> LkActioncardbaseModifiedby
		{
			get { return GetRelatedEntities<ActionCard>("lk_actioncardbase_modifiedby", null); }
			set { SetRelatedEntities("lk_actioncardbase_modifiedby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_actioncardbase_modifiedonbehalfby'
        /// </summary>
		[RelationshipSchemaName("lk_actioncardbase_modifiedonbehalfby")]
		public IEnumerable<ActionCard> LkActioncardbaseModifiedonbehalfby
		{
			get { return GetRelatedEntities<ActionCard>("lk_actioncardbase_modifiedonbehalfby", null); }
			set { SetRelatedEntities("lk_actioncardbase_modifiedonbehalfby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_activitymonitor_createdby'
        /// </summary>
		[RelationshipSchemaName("lk_activitymonitor_createdby")]
		public IEnumerable<ActivityMonitor> LkActivitymonitorCreatedby
		{
			get { return GetRelatedEntities<ActivityMonitor>("lk_activitymonitor_createdby", null); }
			set { SetRelatedEntities("lk_activitymonitor_createdby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_activitymonitor_createdonbehalfby'
        /// </summary>
		[RelationshipSchemaName("lk_activitymonitor_createdonbehalfby")]
		public IEnumerable<ActivityMonitor> LkActivitymonitorCreatedonbehalfby
		{
			get { return GetRelatedEntities<ActivityMonitor>("lk_activitymonitor_createdonbehalfby", null); }
			set { SetRelatedEntities("lk_activitymonitor_createdonbehalfby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_activitymonitor_modifiedby'
        /// </summary>
		[RelationshipSchemaName("lk_activitymonitor_modifiedby")]
		public IEnumerable<ActivityMonitor> LkActivitymonitorModifiedby
		{
			get { return GetRelatedEntities<ActivityMonitor>("lk_activitymonitor_modifiedby", null); }
			set { SetRelatedEntities("lk_activitymonitor_modifiedby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_activitymonitor_modifiedonbehalfby'
        /// </summary>
		[RelationshipSchemaName("lk_activitymonitor_modifiedonbehalfby")]
		public IEnumerable<ActivityMonitor> LkActivitymonitorModifiedonbehalfby
		{
			get { return GetRelatedEntities<ActivityMonitor>("lk_activitymonitor_modifiedonbehalfby", null); }
			set { SetRelatedEntities("lk_activitymonitor_modifiedonbehalfby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_activitypointer_createdby'
        /// </summary>
		[RelationshipSchemaName("lk_activitypointer_createdby")]
		public IEnumerable<Activity> LkActivitypointerCreatedby
		{
			get { return GetRelatedEntities<Activity>("lk_activitypointer_createdby", null); }
			set { SetRelatedEntities("lk_activitypointer_createdby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_activitypointer_createdonbehalfby'
        /// </summary>
		[RelationshipSchemaName("lk_activitypointer_createdonbehalfby")]
		public IEnumerable<Activity> LkActivitypointerCreatedonbehalfby
		{
			get { return GetRelatedEntities<Activity>("lk_activitypointer_createdonbehalfby", null); }
			set { SetRelatedEntities("lk_activitypointer_createdonbehalfby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_activitypointer_modifiedby'
        /// </summary>
		[RelationshipSchemaName("lk_activitypointer_modifiedby")]
		public IEnumerable<Activity> LkActivitypointerModifiedby
		{
			get { return GetRelatedEntities<Activity>("lk_activitypointer_modifiedby", null); }
			set { SetRelatedEntities("lk_activitypointer_modifiedby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_activitypointer_modifiedonbehalfby'
        /// </summary>
		[RelationshipSchemaName("lk_activitypointer_modifiedonbehalfby")]
		public IEnumerable<Activity> LkActivitypointerModifiedonbehalfby
		{
			get { return GetRelatedEntities<Activity>("lk_activitypointer_modifiedonbehalfby", null); }
			set { SetRelatedEntities("lk_activitypointer_modifiedonbehalfby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_adminsettingsentity_createdby'
        /// </summary>
		[RelationshipSchemaName("lk_adminsettingsentity_createdby")]
		public IEnumerable<AdminSettingsEntity> LkAdminsettingsentityCreatedby
		{
			get { return GetRelatedEntities<AdminSettingsEntity>("lk_adminsettingsentity_createdby", null); }
			set { SetRelatedEntities("lk_adminsettingsentity_createdby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_adminsettingsentity_createdonbehalfby'
        /// </summary>
		[RelationshipSchemaName("lk_adminsettingsentity_createdonbehalfby")]
		public IEnumerable<AdminSettingsEntity> LkAdminsettingsentityCreatedonbehalfby
		{
			get { return GetRelatedEntities<AdminSettingsEntity>("lk_adminsettingsentity_createdonbehalfby", null); }
			set { SetRelatedEntities("lk_adminsettingsentity_createdonbehalfby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_adminsettingsentity_modifiedby'
        /// </summary>
		[RelationshipSchemaName("lk_adminsettingsentity_modifiedby")]
		public IEnumerable<AdminSettingsEntity> LkAdminsettingsentityModifiedby
		{
			get { return GetRelatedEntities<AdminSettingsEntity>("lk_adminsettingsentity_modifiedby", null); }
			set { SetRelatedEntities("lk_adminsettingsentity_modifiedby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_adminsettingsentity_modifiedonbehalfby'
        /// </summary>
		[RelationshipSchemaName("lk_adminsettingsentity_modifiedonbehalfby")]
		public IEnumerable<AdminSettingsEntity> LkAdminsettingsentityModifiedonbehalfby
		{
			get { return GetRelatedEntities<AdminSettingsEntity>("lk_adminsettingsentity_modifiedonbehalfby", null); }
			set { SetRelatedEntities("lk_adminsettingsentity_modifiedonbehalfby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_annotationbase_createdby'
        /// </summary>
		[RelationshipSchemaName("lk_annotationbase_createdby")]
		public IEnumerable<Note> LkAnnotationbaseCreatedby
		{
			get { return GetRelatedEntities<Note>("lk_annotationbase_createdby", null); }
			set { SetRelatedEntities("lk_annotationbase_createdby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_annotationbase_createdonbehalfby'
        /// </summary>
		[RelationshipSchemaName("lk_annotationbase_createdonbehalfby")]
		public IEnumerable<Note> LkAnnotationbaseCreatedonbehalfby
		{
			get { return GetRelatedEntities<Note>("lk_annotationbase_createdonbehalfby", null); }
			set { SetRelatedEntities("lk_annotationbase_createdonbehalfby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_annotationbase_modifiedby'
        /// </summary>
		[RelationshipSchemaName("lk_annotationbase_modifiedby")]
		public IEnumerable<Note> LkAnnotationbaseModifiedby
		{
			get { return GetRelatedEntities<Note>("lk_annotationbase_modifiedby", null); }
			set { SetRelatedEntities("lk_annotationbase_modifiedby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_annotationbase_modifiedonbehalfby'
        /// </summary>
		[RelationshipSchemaName("lk_annotationbase_modifiedonbehalfby")]
		public IEnumerable<Note> LkAnnotationbaseModifiedonbehalfby
		{
			get { return GetRelatedEntities<Note>("lk_annotationbase_modifiedonbehalfby", null); }
			set { SetRelatedEntities("lk_annotationbase_modifiedonbehalfby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_annualfiscalcalendar_createdby'
        /// </summary>
		[RelationshipSchemaName("lk_annualfiscalcalendar_createdby")]
		public IEnumerable<AnnualFiscalCalendar> LkAnnualfiscalcalendarCreatedby
		{
			get { return GetRelatedEntities<AnnualFiscalCalendar>("lk_annualfiscalcalendar_createdby", null); }
			set { SetRelatedEntities("lk_annualfiscalcalendar_createdby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_annualfiscalcalendar_createdonbehalfby'
        /// </summary>
		[RelationshipSchemaName("lk_annualfiscalcalendar_createdonbehalfby")]
		public IEnumerable<AnnualFiscalCalendar> LkAnnualfiscalcalendarCreatedonbehalfby
		{
			get { return GetRelatedEntities<AnnualFiscalCalendar>("lk_annualfiscalcalendar_createdonbehalfby", null); }
			set { SetRelatedEntities("lk_annualfiscalcalendar_createdonbehalfby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_annualfiscalcalendar_modifiedby'
        /// </summary>
		[RelationshipSchemaName("lk_annualfiscalcalendar_modifiedby")]
		public IEnumerable<AnnualFiscalCalendar> LkAnnualfiscalcalendarModifiedby
		{
			get { return GetRelatedEntities<AnnualFiscalCalendar>("lk_annualfiscalcalendar_modifiedby", null); }
			set { SetRelatedEntities("lk_annualfiscalcalendar_modifiedby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_annualfiscalcalendar_modifiedonbehalfby'
        /// </summary>
		[RelationshipSchemaName("lk_annualfiscalcalendar_modifiedonbehalfby")]
		public IEnumerable<AnnualFiscalCalendar> LkAnnualfiscalcalendarModifiedonbehalfby
		{
			get { return GetRelatedEntities<AnnualFiscalCalendar>("lk_annualfiscalcalendar_modifiedonbehalfby", null); }
			set { SetRelatedEntities("lk_annualfiscalcalendar_modifiedonbehalfby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_annualfiscalcalendar_salespersonid'
        /// </summary>
		[RelationshipSchemaName("lk_annualfiscalcalendar_salespersonid")]
		public IEnumerable<AnnualFiscalCalendar> LkAnnualfiscalcalendarSalespersonid
		{
			get { return GetRelatedEntities<AnnualFiscalCalendar>("lk_annualfiscalcalendar_salespersonid", null); }
			set { SetRelatedEntities("lk_annualfiscalcalendar_salespersonid", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_appconfig_createdby'
        /// </summary>
		[RelationshipSchemaName("lk_appconfig_createdby")]
		public IEnumerable<AppConfiguration> LkAppconfigCreatedby
		{
			get { return GetRelatedEntities<AppConfiguration>("lk_appconfig_createdby", null); }
			set { SetRelatedEntities("lk_appconfig_createdby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_appconfig_createdonbehalfby'
        /// </summary>
		[RelationshipSchemaName("lk_appconfig_createdonbehalfby")]
		public IEnumerable<AppConfiguration> LkAppconfigCreatedonbehalfby
		{
			get { return GetRelatedEntities<AppConfiguration>("lk_appconfig_createdonbehalfby", null); }
			set { SetRelatedEntities("lk_appconfig_createdonbehalfby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_appconfig_modifiedby'
        /// </summary>
		[RelationshipSchemaName("lk_appconfig_modifiedby")]
		public IEnumerable<AppConfiguration> LkAppconfigModifiedby
		{
			get { return GetRelatedEntities<AppConfiguration>("lk_appconfig_modifiedby", null); }
			set { SetRelatedEntities("lk_appconfig_modifiedby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_appconfig_modifiedonbehalfby'
        /// </summary>
		[RelationshipSchemaName("lk_appconfig_modifiedonbehalfby")]
		public IEnumerable<AppConfiguration> LkAppconfigModifiedonbehalfby
		{
			get { return GetRelatedEntities<AppConfiguration>("lk_appconfig_modifiedonbehalfby", null); }
			set { SetRelatedEntities("lk_appconfig_modifiedonbehalfby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_appconfiginstance_createdby'
        /// </summary>
		[RelationshipSchemaName("lk_appconfiginstance_createdby")]
		public IEnumerable<AppConfigurationInstance> LkAppconfiginstanceCreatedby
		{
			get { return GetRelatedEntities<AppConfigurationInstance>("lk_appconfiginstance_createdby", null); }
			set { SetRelatedEntities("lk_appconfiginstance_createdby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_appconfiginstance_createdonbehalfby'
        /// </summary>
		[RelationshipSchemaName("lk_appconfiginstance_createdonbehalfby")]
		public IEnumerable<AppConfigurationInstance> LkAppconfiginstanceCreatedonbehalfby
		{
			get { return GetRelatedEntities<AppConfigurationInstance>("lk_appconfiginstance_createdonbehalfby", null); }
			set { SetRelatedEntities("lk_appconfiginstance_createdonbehalfby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_appconfiginstance_modifiedby'
        /// </summary>
		[RelationshipSchemaName("lk_appconfiginstance_modifiedby")]
		public IEnumerable<AppConfigurationInstance> LkAppconfiginstanceModifiedby
		{
			get { return GetRelatedEntities<AppConfigurationInstance>("lk_appconfiginstance_modifiedby", null); }
			set { SetRelatedEntities("lk_appconfiginstance_modifiedby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_appconfiginstance_modifiedonbehalfby'
        /// </summary>
		[RelationshipSchemaName("lk_appconfiginstance_modifiedonbehalfby")]
		public IEnumerable<AppConfigurationInstance> LkAppconfiginstanceModifiedonbehalfby
		{
			get { return GetRelatedEntities<AppConfigurationInstance>("lk_appconfiginstance_modifiedonbehalfby", null); }
			set { SetRelatedEntities("lk_appconfiginstance_modifiedonbehalfby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_appconfigmaster_createdby'
        /// </summary>
		[RelationshipSchemaName("lk_appconfigmaster_createdby")]
		public IEnumerable<AppConfigMaster> LkAppconfigmasterCreatedby
		{
			get { return GetRelatedEntities<AppConfigMaster>("lk_appconfigmaster_createdby", null); }
			set { SetRelatedEntities("lk_appconfigmaster_createdby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_appconfigmaster_createdonbehalfby'
        /// </summary>
		[RelationshipSchemaName("lk_appconfigmaster_createdonbehalfby")]
		public IEnumerable<AppConfigMaster> LkAppconfigmasterCreatedonbehalfby
		{
			get { return GetRelatedEntities<AppConfigMaster>("lk_appconfigmaster_createdonbehalfby", null); }
			set { SetRelatedEntities("lk_appconfigmaster_createdonbehalfby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_appconfigmaster_modifiedby'
        /// </summary>
		[RelationshipSchemaName("lk_appconfigmaster_modifiedby")]
		public IEnumerable<AppConfigMaster> LkAppconfigmasterModifiedby
		{
			get { return GetRelatedEntities<AppConfigMaster>("lk_appconfigmaster_modifiedby", null); }
			set { SetRelatedEntities("lk_appconfigmaster_modifiedby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_appconfigmaster_modifiedonbehalfby'
        /// </summary>
		[RelationshipSchemaName("lk_appconfigmaster_modifiedonbehalfby")]
		public IEnumerable<AppConfigMaster> LkAppconfigmasterModifiedonbehalfby
		{
			get { return GetRelatedEntities<AppConfigMaster>("lk_appconfigmaster_modifiedonbehalfby", null); }
			set { SetRelatedEntities("lk_appconfigmaster_modifiedonbehalfby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_appmodule_createdby'
        /// </summary>
		[RelationshipSchemaName("lk_appmodule_createdby")]
		public IEnumerable<ModeldrivenApp> LkAppmoduleCreatedby
		{
			get { return GetRelatedEntities<ModeldrivenApp>("lk_appmodule_createdby", null); }
			set { SetRelatedEntities("lk_appmodule_createdby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_appmodule_createdonbehalfby'
        /// </summary>
		[RelationshipSchemaName("lk_appmodule_createdonbehalfby")]
		public IEnumerable<ModeldrivenApp> LkAppmoduleCreatedonbehalfby
		{
			get { return GetRelatedEntities<ModeldrivenApp>("lk_appmodule_createdonbehalfby", null); }
			set { SetRelatedEntities("lk_appmodule_createdonbehalfby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_appmodule_modifiedby'
        /// </summary>
		[RelationshipSchemaName("lk_appmodule_modifiedby")]
		public IEnumerable<ModeldrivenApp> LkAppmoduleModifiedby
		{
			get { return GetRelatedEntities<ModeldrivenApp>("lk_appmodule_modifiedby", null); }
			set { SetRelatedEntities("lk_appmodule_modifiedby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_appmodule_modifiedonbehalfby'
        /// </summary>
		[RelationshipSchemaName("lk_appmodule_modifiedonbehalfby")]
		public IEnumerable<ModeldrivenApp> LkAppmoduleModifiedonbehalfby
		{
			get { return GetRelatedEntities<ModeldrivenApp>("lk_appmodule_modifiedonbehalfby", null); }
			set { SetRelatedEntities("lk_appmodule_modifiedonbehalfby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_appmodulecomponent_createdby'
        /// </summary>
		[RelationshipSchemaName("lk_appmodulecomponent_createdby")]
		public IEnumerable<AppModuleComponent> LkAppmodulecomponentCreatedby
		{
			get { return GetRelatedEntities<AppModuleComponent>("lk_appmodulecomponent_createdby", null); }
			set { SetRelatedEntities("lk_appmodulecomponent_createdby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_appmodulecomponent_createdonbehalfby'
        /// </summary>
		[RelationshipSchemaName("lk_appmodulecomponent_createdonbehalfby")]
		public IEnumerable<AppModuleComponent> LkAppmodulecomponentCreatedonbehalfby
		{
			get { return GetRelatedEntities<AppModuleComponent>("lk_appmodulecomponent_createdonbehalfby", null); }
			set { SetRelatedEntities("lk_appmodulecomponent_createdonbehalfby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_appmodulecomponent_modifiedby'
        /// </summary>
		[RelationshipSchemaName("lk_appmodulecomponent_modifiedby")]
		public IEnumerable<AppModuleComponent> LkAppmodulecomponentModifiedby
		{
			get { return GetRelatedEntities<AppModuleComponent>("lk_appmodulecomponent_modifiedby", null); }
			set { SetRelatedEntities("lk_appmodulecomponent_modifiedby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_appmodulecomponent_modifiedonbehalfby'
        /// </summary>
		[RelationshipSchemaName("lk_appmodulecomponent_modifiedonbehalfby")]
		public IEnumerable<AppModuleComponent> LkAppmodulecomponentModifiedonbehalfby
		{
			get { return GetRelatedEntities<AppModuleComponent>("lk_appmodulecomponent_modifiedonbehalfby", null); }
			set { SetRelatedEntities("lk_appmodulecomponent_modifiedonbehalfby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_appointment_createdby'
        /// </summary>
		[RelationshipSchemaName("lk_appointment_createdby")]
		public IEnumerable<Appointment> LkAppointmentCreatedby
		{
			get { return GetRelatedEntities<Appointment>("lk_appointment_createdby", null); }
			set { SetRelatedEntities("lk_appointment_createdby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_appointment_createdonbehalfby'
        /// </summary>
		[RelationshipSchemaName("lk_appointment_createdonbehalfby")]
		public IEnumerable<Appointment> LkAppointmentCreatedonbehalfby
		{
			get { return GetRelatedEntities<Appointment>("lk_appointment_createdonbehalfby", null); }
			set { SetRelatedEntities("lk_appointment_createdonbehalfby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_appointment_modifiedby'
        /// </summary>
		[RelationshipSchemaName("lk_appointment_modifiedby")]
		public IEnumerable<Appointment> LkAppointmentModifiedby
		{
			get { return GetRelatedEntities<Appointment>("lk_appointment_modifiedby", null); }
			set { SetRelatedEntities("lk_appointment_modifiedby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_appointment_modifiedonbehalfby'
        /// </summary>
		[RelationshipSchemaName("lk_appointment_modifiedonbehalfby")]
		public IEnumerable<Appointment> LkAppointmentModifiedonbehalfby
		{
			get { return GetRelatedEntities<Appointment>("lk_appointment_modifiedonbehalfby", null); }
			set { SetRelatedEntities("lk_appointment_modifiedonbehalfby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_asyncoperation_createdby'
        /// </summary>
		[RelationshipSchemaName("lk_asyncoperation_createdby")]
		public IEnumerable<SystemJob> LkAsyncoperationCreatedby
		{
			get { return GetRelatedEntities<SystemJob>("lk_asyncoperation_createdby", null); }
			set { SetRelatedEntities("lk_asyncoperation_createdby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_asyncoperation_createdonbehalfby'
        /// </summary>
		[RelationshipSchemaName("lk_asyncoperation_createdonbehalfby")]
		public IEnumerable<SystemJob> LkAsyncoperationCreatedonbehalfby
		{
			get { return GetRelatedEntities<SystemJob>("lk_asyncoperation_createdonbehalfby", null); }
			set { SetRelatedEntities("lk_asyncoperation_createdonbehalfby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_asyncoperation_modifiedby'
        /// </summary>
		[RelationshipSchemaName("lk_asyncoperation_modifiedby")]
		public IEnumerable<SystemJob> LkAsyncoperationModifiedby
		{
			get { return GetRelatedEntities<SystemJob>("lk_asyncoperation_modifiedby", null); }
			set { SetRelatedEntities("lk_asyncoperation_modifiedby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_asyncoperation_modifiedonbehalfby'
        /// </summary>
		[RelationshipSchemaName("lk_asyncoperation_modifiedonbehalfby")]
		public IEnumerable<SystemJob> LkAsyncoperationModifiedonbehalfby
		{
			get { return GetRelatedEntities<SystemJob>("lk_asyncoperation_modifiedonbehalfby", null); }
			set { SetRelatedEntities("lk_asyncoperation_modifiedonbehalfby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_audit_callinguserid'
        /// </summary>
		[RelationshipSchemaName("lk_audit_callinguserid")]
		public IEnumerable<Auditing> LkAuditCallinguserid
		{
			get { return GetRelatedEntities<Auditing>("lk_audit_callinguserid", null); }
			set { SetRelatedEntities("lk_audit_callinguserid", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_audit_userid'
        /// </summary>
		[RelationshipSchemaName("lk_audit_userid")]
		public IEnumerable<Auditing> LkAuditUserid
		{
			get { return GetRelatedEntities<Auditing>("lk_audit_userid", null); }
			set { SetRelatedEntities("lk_audit_userid", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_bookableresource_createdby'
        /// </summary>
		[RelationshipSchemaName("lk_bookableresource_createdby")]
		public IEnumerable<BookableResource> LkBookableresourceCreatedby
		{
			get { return GetRelatedEntities<BookableResource>("lk_bookableresource_createdby", null); }
			set { SetRelatedEntities("lk_bookableresource_createdby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_bookableresource_createdonbehalfby'
        /// </summary>
		[RelationshipSchemaName("lk_bookableresource_createdonbehalfby")]
		public IEnumerable<BookableResource> LkBookableresourceCreatedonbehalfby
		{
			get { return GetRelatedEntities<BookableResource>("lk_bookableresource_createdonbehalfby", null); }
			set { SetRelatedEntities("lk_bookableresource_createdonbehalfby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_bookableresource_modifiedby'
        /// </summary>
		[RelationshipSchemaName("lk_bookableresource_modifiedby")]
		public IEnumerable<BookableResource> LkBookableresourceModifiedby
		{
			get { return GetRelatedEntities<BookableResource>("lk_bookableresource_modifiedby", null); }
			set { SetRelatedEntities("lk_bookableresource_modifiedby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_bookableresource_modifiedonbehalfby'
        /// </summary>
		[RelationshipSchemaName("lk_bookableresource_modifiedonbehalfby")]
		public IEnumerable<BookableResource> LkBookableresourceModifiedonbehalfby
		{
			get { return GetRelatedEntities<BookableResource>("lk_bookableresource_modifiedonbehalfby", null); }
			set { SetRelatedEntities("lk_bookableresource_modifiedonbehalfby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_bookableresourcebooking_createdby'
        /// </summary>
		[RelationshipSchemaName("lk_bookableresourcebooking_createdby")]
		public IEnumerable<BookableResourceBooking> LkBookableresourcebookingCreatedby
		{
			get { return GetRelatedEntities<BookableResourceBooking>("lk_bookableresourcebooking_createdby", null); }
			set { SetRelatedEntities("lk_bookableresourcebooking_createdby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_bookableresourcebooking_createdonbehalfby'
        /// </summary>
		[RelationshipSchemaName("lk_bookableresourcebooking_createdonbehalfby")]
		public IEnumerable<BookableResourceBooking> LkBookableresourcebookingCreatedonbehalfby
		{
			get { return GetRelatedEntities<BookableResourceBooking>("lk_bookableresourcebooking_createdonbehalfby", null); }
			set { SetRelatedEntities("lk_bookableresourcebooking_createdonbehalfby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_bookableresourcebooking_modifiedby'
        /// </summary>
		[RelationshipSchemaName("lk_bookableresourcebooking_modifiedby")]
		public IEnumerable<BookableResourceBooking> LkBookableresourcebookingModifiedby
		{
			get { return GetRelatedEntities<BookableResourceBooking>("lk_bookableresourcebooking_modifiedby", null); }
			set { SetRelatedEntities("lk_bookableresourcebooking_modifiedby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_bookableresourcebooking_modifiedonbehalfby'
        /// </summary>
		[RelationshipSchemaName("lk_bookableresourcebooking_modifiedonbehalfby")]
		public IEnumerable<BookableResourceBooking> LkBookableresourcebookingModifiedonbehalfby
		{
			get { return GetRelatedEntities<BookableResourceBooking>("lk_bookableresourcebooking_modifiedonbehalfby", null); }
			set { SetRelatedEntities("lk_bookableresourcebooking_modifiedonbehalfby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_bookableresourcebookingheader_createdby'
        /// </summary>
		[RelationshipSchemaName("lk_bookableresourcebookingheader_createdby")]
		public IEnumerable<BookableResourceBookingHeader> LkBookableresourcebookingheaderCreatedby
		{
			get { return GetRelatedEntities<BookableResourceBookingHeader>("lk_bookableresourcebookingheader_createdby", null); }
			set { SetRelatedEntities("lk_bookableresourcebookingheader_createdby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_bookableresourcebookingheader_createdonbehalfby'
        /// </summary>
		[RelationshipSchemaName("lk_bookableresourcebookingheader_createdonbehalfby")]
		public IEnumerable<BookableResourceBookingHeader> LkBookableresourcebookingheaderCreatedonbehalfby
		{
			get { return GetRelatedEntities<BookableResourceBookingHeader>("lk_bookableresourcebookingheader_createdonbehalfby", null); }
			set { SetRelatedEntities("lk_bookableresourcebookingheader_createdonbehalfby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_bookableresourcebookingheader_modifiedby'
        /// </summary>
		[RelationshipSchemaName("lk_bookableresourcebookingheader_modifiedby")]
		public IEnumerable<BookableResourceBookingHeader> LkBookableresourcebookingheaderModifiedby
		{
			get { return GetRelatedEntities<BookableResourceBookingHeader>("lk_bookableresourcebookingheader_modifiedby", null); }
			set { SetRelatedEntities("lk_bookableresourcebookingheader_modifiedby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_bookableresourcebookingheader_modifiedonbehalfby'
        /// </summary>
		[RelationshipSchemaName("lk_bookableresourcebookingheader_modifiedonbehalfby")]
		public IEnumerable<BookableResourceBookingHeader> LkBookableresourcebookingheaderModifiedonbehalfby
		{
			get { return GetRelatedEntities<BookableResourceBookingHeader>("lk_bookableresourcebookingheader_modifiedonbehalfby", null); }
			set { SetRelatedEntities("lk_bookableresourcebookingheader_modifiedonbehalfby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_bookableresourcecategory_createdby'
        /// </summary>
		[RelationshipSchemaName("lk_bookableresourcecategory_createdby")]
		public IEnumerable<BookableResourceCategory> LkBookableresourcecategoryCreatedby
		{
			get { return GetRelatedEntities<BookableResourceCategory>("lk_bookableresourcecategory_createdby", null); }
			set { SetRelatedEntities("lk_bookableresourcecategory_createdby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_bookableresourcecategory_createdonbehalfby'
        /// </summary>
		[RelationshipSchemaName("lk_bookableresourcecategory_createdonbehalfby")]
		public IEnumerable<BookableResourceCategory> LkBookableresourcecategoryCreatedonbehalfby
		{
			get { return GetRelatedEntities<BookableResourceCategory>("lk_bookableresourcecategory_createdonbehalfby", null); }
			set { SetRelatedEntities("lk_bookableresourcecategory_createdonbehalfby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_bookableresourcecategory_modifiedby'
        /// </summary>
		[RelationshipSchemaName("lk_bookableresourcecategory_modifiedby")]
		public IEnumerable<BookableResourceCategory> LkBookableresourcecategoryModifiedby
		{
			get { return GetRelatedEntities<BookableResourceCategory>("lk_bookableresourcecategory_modifiedby", null); }
			set { SetRelatedEntities("lk_bookableresourcecategory_modifiedby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_bookableresourcecategory_modifiedonbehalfby'
        /// </summary>
		[RelationshipSchemaName("lk_bookableresourcecategory_modifiedonbehalfby")]
		public IEnumerable<BookableResourceCategory> LkBookableresourcecategoryModifiedonbehalfby
		{
			get { return GetRelatedEntities<BookableResourceCategory>("lk_bookableresourcecategory_modifiedonbehalfby", null); }
			set { SetRelatedEntities("lk_bookableresourcecategory_modifiedonbehalfby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_bookableresourcecategoryassn_createdby'
        /// </summary>
		[RelationshipSchemaName("lk_bookableresourcecategoryassn_createdby")]
		public IEnumerable<BookableResourceCategoryAssn> LkBookableresourcecategoryassnCreatedby
		{
			get { return GetRelatedEntities<BookableResourceCategoryAssn>("lk_bookableresourcecategoryassn_createdby", null); }
			set { SetRelatedEntities("lk_bookableresourcecategoryassn_createdby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_bookableresourcecategoryassn_createdonbehalfby'
        /// </summary>
		[RelationshipSchemaName("lk_bookableresourcecategoryassn_createdonbehalfby")]
		public IEnumerable<BookableResourceCategoryAssn> LkBookableresourcecategoryassnCreatedonbehalfby
		{
			get { return GetRelatedEntities<BookableResourceCategoryAssn>("lk_bookableresourcecategoryassn_createdonbehalfby", null); }
			set { SetRelatedEntities("lk_bookableresourcecategoryassn_createdonbehalfby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_bookableresourcecategoryassn_modifiedby'
        /// </summary>
		[RelationshipSchemaName("lk_bookableresourcecategoryassn_modifiedby")]
		public IEnumerable<BookableResourceCategoryAssn> LkBookableresourcecategoryassnModifiedby
		{
			get { return GetRelatedEntities<BookableResourceCategoryAssn>("lk_bookableresourcecategoryassn_modifiedby", null); }
			set { SetRelatedEntities("lk_bookableresourcecategoryassn_modifiedby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_bookableresourcecategoryassn_modifiedonbehalfby'
        /// </summary>
		[RelationshipSchemaName("lk_bookableresourcecategoryassn_modifiedonbehalfby")]
		public IEnumerable<BookableResourceCategoryAssn> LkBookableresourcecategoryassnModifiedonbehalfby
		{
			get { return GetRelatedEntities<BookableResourceCategoryAssn>("lk_bookableresourcecategoryassn_modifiedonbehalfby", null); }
			set { SetRelatedEntities("lk_bookableresourcecategoryassn_modifiedonbehalfby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_bookableresourcecharacteristic_createdby'
        /// </summary>
		[RelationshipSchemaName("lk_bookableresourcecharacteristic_createdby")]
		public IEnumerable<BookableResourceCharacteristic> LkBookableresourcecharacteristicCreatedby
		{
			get { return GetRelatedEntities<BookableResourceCharacteristic>("lk_bookableresourcecharacteristic_createdby", null); }
			set { SetRelatedEntities("lk_bookableresourcecharacteristic_createdby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_bookableresourcecharacteristic_createdonbehalfby'
        /// </summary>
		[RelationshipSchemaName("lk_bookableresourcecharacteristic_createdonbehalfby")]
		public IEnumerable<BookableResourceCharacteristic> LkBookableresourcecharacteristicCreatedonbehalfby
		{
			get { return GetRelatedEntities<BookableResourceCharacteristic>("lk_bookableresourcecharacteristic_createdonbehalfby", null); }
			set { SetRelatedEntities("lk_bookableresourcecharacteristic_createdonbehalfby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_bookableresourcecharacteristic_modifiedby'
        /// </summary>
		[RelationshipSchemaName("lk_bookableresourcecharacteristic_modifiedby")]
		public IEnumerable<BookableResourceCharacteristic> LkBookableresourcecharacteristicModifiedby
		{
			get { return GetRelatedEntities<BookableResourceCharacteristic>("lk_bookableresourcecharacteristic_modifiedby", null); }
			set { SetRelatedEntities("lk_bookableresourcecharacteristic_modifiedby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_bookableresourcecharacteristic_modifiedonbehalfby'
        /// </summary>
		[RelationshipSchemaName("lk_bookableresourcecharacteristic_modifiedonbehalfby")]
		public IEnumerable<BookableResourceCharacteristic> LkBookableresourcecharacteristicModifiedonbehalfby
		{
			get { return GetRelatedEntities<BookableResourceCharacteristic>("lk_bookableresourcecharacteristic_modifiedonbehalfby", null); }
			set { SetRelatedEntities("lk_bookableresourcecharacteristic_modifiedonbehalfby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_bookableresourcegroup_createdby'
        /// </summary>
		[RelationshipSchemaName("lk_bookableresourcegroup_createdby")]
		public IEnumerable<BookableResourceGroup> LkBookableresourcegroupCreatedby
		{
			get { return GetRelatedEntities<BookableResourceGroup>("lk_bookableresourcegroup_createdby", null); }
			set { SetRelatedEntities("lk_bookableresourcegroup_createdby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_bookableresourcegroup_createdonbehalfby'
        /// </summary>
		[RelationshipSchemaName("lk_bookableresourcegroup_createdonbehalfby")]
		public IEnumerable<BookableResourceGroup> LkBookableresourcegroupCreatedonbehalfby
		{
			get { return GetRelatedEntities<BookableResourceGroup>("lk_bookableresourcegroup_createdonbehalfby", null); }
			set { SetRelatedEntities("lk_bookableresourcegroup_createdonbehalfby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_bookableresourcegroup_modifiedby'
        /// </summary>
		[RelationshipSchemaName("lk_bookableresourcegroup_modifiedby")]
		public IEnumerable<BookableResourceGroup> LkBookableresourcegroupModifiedby
		{
			get { return GetRelatedEntities<BookableResourceGroup>("lk_bookableresourcegroup_modifiedby", null); }
			set { SetRelatedEntities("lk_bookableresourcegroup_modifiedby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_bookableresourcegroup_modifiedonbehalfby'
        /// </summary>
		[RelationshipSchemaName("lk_bookableresourcegroup_modifiedonbehalfby")]
		public IEnumerable<BookableResourceGroup> LkBookableresourcegroupModifiedonbehalfby
		{
			get { return GetRelatedEntities<BookableResourceGroup>("lk_bookableresourcegroup_modifiedonbehalfby", null); }
			set { SetRelatedEntities("lk_bookableresourcegroup_modifiedonbehalfby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_bookingstatus_createdby'
        /// </summary>
		[RelationshipSchemaName("lk_bookingstatus_createdby")]
		public IEnumerable<BookingStatus> LkBookingstatusCreatedby
		{
			get { return GetRelatedEntities<BookingStatus>("lk_bookingstatus_createdby", null); }
			set { SetRelatedEntities("lk_bookingstatus_createdby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_bookingstatus_createdonbehalfby'
        /// </summary>
		[RelationshipSchemaName("lk_bookingstatus_createdonbehalfby")]
		public IEnumerable<BookingStatus> LkBookingstatusCreatedonbehalfby
		{
			get { return GetRelatedEntities<BookingStatus>("lk_bookingstatus_createdonbehalfby", null); }
			set { SetRelatedEntities("lk_bookingstatus_createdonbehalfby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_bookingstatus_modifiedby'
        /// </summary>
		[RelationshipSchemaName("lk_bookingstatus_modifiedby")]
		public IEnumerable<BookingStatus> LkBookingstatusModifiedby
		{
			get { return GetRelatedEntities<BookingStatus>("lk_bookingstatus_modifiedby", null); }
			set { SetRelatedEntities("lk_bookingstatus_modifiedby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_bookingstatus_modifiedonbehalfby'
        /// </summary>
		[RelationshipSchemaName("lk_bookingstatus_modifiedonbehalfby")]
		public IEnumerable<BookingStatus> LkBookingstatusModifiedonbehalfby
		{
			get { return GetRelatedEntities<BookingStatus>("lk_bookingstatus_modifiedonbehalfby", null); }
			set { SetRelatedEntities("lk_bookingstatus_modifiedonbehalfby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_bot_createdby'
        /// </summary>
		[RelationshipSchemaName("lk_bot_createdby")]
		public IEnumerable<Chatbot> LkBotCreatedby
		{
			get { return GetRelatedEntities<Chatbot>("lk_bot_createdby", null); }
			set { SetRelatedEntities("lk_bot_createdby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_bot_createdonbehalfby'
        /// </summary>
		[RelationshipSchemaName("lk_bot_createdonbehalfby")]
		public IEnumerable<Chatbot> LkBotCreatedonbehalfby
		{
			get { return GetRelatedEntities<Chatbot>("lk_bot_createdonbehalfby", null); }
			set { SetRelatedEntities("lk_bot_createdonbehalfby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_bot_modifiedby'
        /// </summary>
		[RelationshipSchemaName("lk_bot_modifiedby")]
		public IEnumerable<Chatbot> LkBotModifiedby
		{
			get { return GetRelatedEntities<Chatbot>("lk_bot_modifiedby", null); }
			set { SetRelatedEntities("lk_bot_modifiedby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_bot_modifiedonbehalfby'
        /// </summary>
		[RelationshipSchemaName("lk_bot_modifiedonbehalfby")]
		public IEnumerable<Chatbot> LkBotModifiedonbehalfby
		{
			get { return GetRelatedEntities<Chatbot>("lk_bot_modifiedonbehalfby", null); }
			set { SetRelatedEntities("lk_bot_modifiedonbehalfby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_botcomponent_createdby'
        /// </summary>
		[RelationshipSchemaName("lk_botcomponent_createdby")]
		public IEnumerable<ChatbotSubcomponent> LkBotcomponentCreatedby
		{
			get { return GetRelatedEntities<ChatbotSubcomponent>("lk_botcomponent_createdby", null); }
			set { SetRelatedEntities("lk_botcomponent_createdby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_botcomponent_createdonbehalfby'
        /// </summary>
		[RelationshipSchemaName("lk_botcomponent_createdonbehalfby")]
		public IEnumerable<ChatbotSubcomponent> LkBotcomponentCreatedonbehalfby
		{
			get { return GetRelatedEntities<ChatbotSubcomponent>("lk_botcomponent_createdonbehalfby", null); }
			set { SetRelatedEntities("lk_botcomponent_createdonbehalfby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_botcomponent_modifiedby'
        /// </summary>
		[RelationshipSchemaName("lk_botcomponent_modifiedby")]
		public IEnumerable<ChatbotSubcomponent> LkBotcomponentModifiedby
		{
			get { return GetRelatedEntities<ChatbotSubcomponent>("lk_botcomponent_modifiedby", null); }
			set { SetRelatedEntities("lk_botcomponent_modifiedby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_botcomponent_modifiedonbehalfby'
        /// </summary>
		[RelationshipSchemaName("lk_botcomponent_modifiedonbehalfby")]
		public IEnumerable<ChatbotSubcomponent> LkBotcomponentModifiedonbehalfby
		{
			get { return GetRelatedEntities<ChatbotSubcomponent>("lk_botcomponent_modifiedonbehalfby", null); }
			set { SetRelatedEntities("lk_botcomponent_modifiedonbehalfby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_bulkdeleteoperation_createdonbehalfby'
        /// </summary>
		[RelationshipSchemaName("lk_bulkdeleteoperation_createdonbehalfby")]
		public IEnumerable<BulkDeleteOperation> LkBulkdeleteoperationCreatedonbehalfby
		{
			get { return GetRelatedEntities<BulkDeleteOperation>("lk_bulkdeleteoperation_createdonbehalfby", null); }
			set { SetRelatedEntities("lk_bulkdeleteoperation_createdonbehalfby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_bulkdeleteoperation_modifiedonbehalfby'
        /// </summary>
		[RelationshipSchemaName("lk_bulkdeleteoperation_modifiedonbehalfby")]
		public IEnumerable<BulkDeleteOperation> LkBulkdeleteoperationModifiedonbehalfby
		{
			get { return GetRelatedEntities<BulkDeleteOperation>("lk_bulkdeleteoperation_modifiedonbehalfby", null); }
			set { SetRelatedEntities("lk_bulkdeleteoperation_modifiedonbehalfby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_bulkdeleteoperationbase_createdby'
        /// </summary>
		[RelationshipSchemaName("lk_bulkdeleteoperationbase_createdby")]
		public IEnumerable<BulkDeleteOperation> LkBulkdeleteoperationbaseCreatedby
		{
			get { return GetRelatedEntities<BulkDeleteOperation>("lk_bulkdeleteoperationbase_createdby", null); }
			set { SetRelatedEntities("lk_bulkdeleteoperationbase_createdby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_bulkdeleteoperationbase_modifiedby'
        /// </summary>
		[RelationshipSchemaName("lk_bulkdeleteoperationbase_modifiedby")]
		public IEnumerable<BulkDeleteOperation> LkBulkdeleteoperationbaseModifiedby
		{
			get { return GetRelatedEntities<BulkDeleteOperation>("lk_bulkdeleteoperationbase_modifiedby", null); }
			set { SetRelatedEntities("lk_bulkdeleteoperationbase_modifiedby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_BulkOperation_createdby'
        /// </summary>
		[RelationshipSchemaName("lk_BulkOperation_createdby")]
		public IEnumerable<QuickCampaign> LkBulkOperationCreatedby
		{
			get { return GetRelatedEntities<QuickCampaign>("lk_BulkOperation_createdby", null); }
			set { SetRelatedEntities("lk_BulkOperation_createdby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_BulkOperation_createdonbehalfby'
        /// </summary>
		[RelationshipSchemaName("lk_BulkOperation_createdonbehalfby")]
		public IEnumerable<QuickCampaign> LkBulkOperationCreatedonbehalfby
		{
			get { return GetRelatedEntities<QuickCampaign>("lk_BulkOperation_createdonbehalfby", null); }
			set { SetRelatedEntities("lk_BulkOperation_createdonbehalfby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_BulkOperation_modifiedby'
        /// </summary>
		[RelationshipSchemaName("lk_BulkOperation_modifiedby")]
		public IEnumerable<QuickCampaign> LkBulkOperationModifiedby
		{
			get { return GetRelatedEntities<QuickCampaign>("lk_BulkOperation_modifiedby", null); }
			set { SetRelatedEntities("lk_BulkOperation_modifiedby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_BulkOperation_modifiedonbehalfby'
        /// </summary>
		[RelationshipSchemaName("lk_BulkOperation_modifiedonbehalfby")]
		public IEnumerable<QuickCampaign> LkBulkOperationModifiedonbehalfby
		{
			get { return GetRelatedEntities<QuickCampaign>("lk_BulkOperation_modifiedonbehalfby", null); }
			set { SetRelatedEntities("lk_BulkOperation_modifiedonbehalfby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_businessunit_createdonbehalfby'
        /// </summary>
		[RelationshipSchemaName("lk_businessunit_createdonbehalfby")]
		public IEnumerable<BusinessUnit> LkBusinessunitCreatedonbehalfby
		{
			get { return GetRelatedEntities<BusinessUnit>("lk_businessunit_createdonbehalfby", null); }
			set { SetRelatedEntities("lk_businessunit_createdonbehalfby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_businessunit_modifiedonbehalfby'
        /// </summary>
		[RelationshipSchemaName("lk_businessunit_modifiedonbehalfby")]
		public IEnumerable<BusinessUnit> LkBusinessunitModifiedonbehalfby
		{
			get { return GetRelatedEntities<BusinessUnit>("lk_businessunit_modifiedonbehalfby", null); }
			set { SetRelatedEntities("lk_businessunit_modifiedonbehalfby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_businessunitbase_createdby'
        /// </summary>
		[RelationshipSchemaName("lk_businessunitbase_createdby")]
		public IEnumerable<BusinessUnit> LkBusinessunitbaseCreatedby
		{
			get { return GetRelatedEntities<BusinessUnit>("lk_businessunitbase_createdby", null); }
			set { SetRelatedEntities("lk_businessunitbase_createdby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_businessunitbase_modifiedby'
        /// </summary>
		[RelationshipSchemaName("lk_businessunitbase_modifiedby")]
		public IEnumerable<BusinessUnit> LkBusinessunitbaseModifiedby
		{
			get { return GetRelatedEntities<BusinessUnit>("lk_businessunitbase_modifiedby", null); }
			set { SetRelatedEntities("lk_businessunitbase_modifiedby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_businessunitnewsarticle_createdonbehalfby'
        /// </summary>
		[RelationshipSchemaName("lk_businessunitnewsarticle_createdonbehalfby")]
		public IEnumerable<Announcement> LkBusinessunitnewsarticleCreatedonbehalfby
		{
			get { return GetRelatedEntities<Announcement>("lk_businessunitnewsarticle_createdonbehalfby", null); }
			set { SetRelatedEntities("lk_businessunitnewsarticle_createdonbehalfby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_businessunitnewsarticle_modifiedonbehalfby'
        /// </summary>
		[RelationshipSchemaName("lk_businessunitnewsarticle_modifiedonbehalfby")]
		public IEnumerable<Announcement> LkBusinessunitnewsarticleModifiedonbehalfby
		{
			get { return GetRelatedEntities<Announcement>("lk_businessunitnewsarticle_modifiedonbehalfby", null); }
			set { SetRelatedEntities("lk_businessunitnewsarticle_modifiedonbehalfby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_businessunitnewsarticlebase_createdby'
        /// </summary>
		[RelationshipSchemaName("lk_businessunitnewsarticlebase_createdby")]
		public IEnumerable<Announcement> LkBusinessunitnewsarticlebaseCreatedby
		{
			get { return GetRelatedEntities<Announcement>("lk_businessunitnewsarticlebase_createdby", null); }
			set { SetRelatedEntities("lk_businessunitnewsarticlebase_createdby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_businessunitnewsarticlebase_modifiedby'
        /// </summary>
		[RelationshipSchemaName("lk_businessunitnewsarticlebase_modifiedby")]
		public IEnumerable<Announcement> LkBusinessunitnewsarticlebaseModifiedby
		{
			get { return GetRelatedEntities<Announcement>("lk_businessunitnewsarticlebase_modifiedby", null); }
			set { SetRelatedEntities("lk_businessunitnewsarticlebase_modifiedby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_calendar_createdby'
        /// </summary>
		[RelationshipSchemaName("lk_calendar_createdby")]
		public IEnumerable<Calendar> LkCalendarCreatedby
		{
			get { return GetRelatedEntities<Calendar>("lk_calendar_createdby", null); }
			set { SetRelatedEntities("lk_calendar_createdby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_calendar_createdonbehalfby'
        /// </summary>
		[RelationshipSchemaName("lk_calendar_createdonbehalfby")]
		public IEnumerable<Calendar> LkCalendarCreatedonbehalfby
		{
			get { return GetRelatedEntities<Calendar>("lk_calendar_createdonbehalfby", null); }
			set { SetRelatedEntities("lk_calendar_createdonbehalfby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_calendar_modifiedby'
        /// </summary>
		[RelationshipSchemaName("lk_calendar_modifiedby")]
		public IEnumerable<Calendar> LkCalendarModifiedby
		{
			get { return GetRelatedEntities<Calendar>("lk_calendar_modifiedby", null); }
			set { SetRelatedEntities("lk_calendar_modifiedby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_calendar_modifiedonbehalfby'
        /// </summary>
		[RelationshipSchemaName("lk_calendar_modifiedonbehalfby")]
		public IEnumerable<Calendar> LkCalendarModifiedonbehalfby
		{
			get { return GetRelatedEntities<Calendar>("lk_calendar_modifiedonbehalfby", null); }
			set { SetRelatedEntities("lk_calendar_modifiedonbehalfby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_callbackregistration_createdby'
        /// </summary>
		[RelationshipSchemaName("lk_callbackregistration_createdby")]
		public IEnumerable<CallbackRegistration> LkCallbackregistrationCreatedby
		{
			get { return GetRelatedEntities<CallbackRegistration>("lk_callbackregistration_createdby", null); }
			set { SetRelatedEntities("lk_callbackregistration_createdby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_callbackregistration_createdonbehalfby'
        /// </summary>
		[RelationshipSchemaName("lk_callbackregistration_createdonbehalfby")]
		public IEnumerable<CallbackRegistration> LkCallbackregistrationCreatedonbehalfby
		{
			get { return GetRelatedEntities<CallbackRegistration>("lk_callbackregistration_createdonbehalfby", null); }
			set { SetRelatedEntities("lk_callbackregistration_createdonbehalfby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_callbackregistration_modifiedby'
        /// </summary>
		[RelationshipSchemaName("lk_callbackregistration_modifiedby")]
		public IEnumerable<CallbackRegistration> LkCallbackregistrationModifiedby
		{
			get { return GetRelatedEntities<CallbackRegistration>("lk_callbackregistration_modifiedby", null); }
			set { SetRelatedEntities("lk_callbackregistration_modifiedby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_callbackregistration_modifiedonbehalfby'
        /// </summary>
		[RelationshipSchemaName("lk_callbackregistration_modifiedonbehalfby")]
		public IEnumerable<CallbackRegistration> LkCallbackregistrationModifiedonbehalfby
		{
			get { return GetRelatedEntities<CallbackRegistration>("lk_callbackregistration_modifiedonbehalfby", null); }
			set { SetRelatedEntities("lk_callbackregistration_modifiedonbehalfby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_campaign_createdby'
        /// </summary>
		[RelationshipSchemaName("lk_campaign_createdby")]
		public IEnumerable<Campaign> LkCampaignCreatedby
		{
			get { return GetRelatedEntities<Campaign>("lk_campaign_createdby", null); }
			set { SetRelatedEntities("lk_campaign_createdby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_campaign_createdonbehalfby'
        /// </summary>
		[RelationshipSchemaName("lk_campaign_createdonbehalfby")]
		public IEnumerable<Campaign> LkCampaignCreatedonbehalfby
		{
			get { return GetRelatedEntities<Campaign>("lk_campaign_createdonbehalfby", null); }
			set { SetRelatedEntities("lk_campaign_createdonbehalfby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_campaign_modifiedby'
        /// </summary>
		[RelationshipSchemaName("lk_campaign_modifiedby")]
		public IEnumerable<Campaign> LkCampaignModifiedby
		{
			get { return GetRelatedEntities<Campaign>("lk_campaign_modifiedby", null); }
			set { SetRelatedEntities("lk_campaign_modifiedby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_campaign_modifiedonbehalfby'
        /// </summary>
		[RelationshipSchemaName("lk_campaign_modifiedonbehalfby")]
		public IEnumerable<Campaign> LkCampaignModifiedonbehalfby
		{
			get { return GetRelatedEntities<Campaign>("lk_campaign_modifiedonbehalfby", null); }
			set { SetRelatedEntities("lk_campaign_modifiedonbehalfby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_campaignactivity_createdby'
        /// </summary>
		[RelationshipSchemaName("lk_campaignactivity_createdby")]
		public IEnumerable<CampaignActivity> LkCampaignactivityCreatedby
		{
			get { return GetRelatedEntities<CampaignActivity>("lk_campaignactivity_createdby", null); }
			set { SetRelatedEntities("lk_campaignactivity_createdby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_campaignactivity_createdonbehalfby'
        /// </summary>
		[RelationshipSchemaName("lk_campaignactivity_createdonbehalfby")]
		public IEnumerable<CampaignActivity> LkCampaignactivityCreatedonbehalfby
		{
			get { return GetRelatedEntities<CampaignActivity>("lk_campaignactivity_createdonbehalfby", null); }
			set { SetRelatedEntities("lk_campaignactivity_createdonbehalfby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_campaignactivity_modifiedby'
        /// </summary>
		[RelationshipSchemaName("lk_campaignactivity_modifiedby")]
		public IEnumerable<CampaignActivity> LkCampaignactivityModifiedby
		{
			get { return GetRelatedEntities<CampaignActivity>("lk_campaignactivity_modifiedby", null); }
			set { SetRelatedEntities("lk_campaignactivity_modifiedby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_campaignactivity_modifiedonbehalfby'
        /// </summary>
		[RelationshipSchemaName("lk_campaignactivity_modifiedonbehalfby")]
		public IEnumerable<CampaignActivity> LkCampaignactivityModifiedonbehalfby
		{
			get { return GetRelatedEntities<CampaignActivity>("lk_campaignactivity_modifiedonbehalfby", null); }
			set { SetRelatedEntities("lk_campaignactivity_modifiedonbehalfby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_campaignresponse_createdby'
        /// </summary>
		[RelationshipSchemaName("lk_campaignresponse_createdby")]
		public IEnumerable<CampaignResponse> LkCampaignresponseCreatedby
		{
			get { return GetRelatedEntities<CampaignResponse>("lk_campaignresponse_createdby", null); }
			set { SetRelatedEntities("lk_campaignresponse_createdby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_campaignresponse_createdonbehalfby'
        /// </summary>
		[RelationshipSchemaName("lk_campaignresponse_createdonbehalfby")]
		public IEnumerable<CampaignResponse> LkCampaignresponseCreatedonbehalfby
		{
			get { return GetRelatedEntities<CampaignResponse>("lk_campaignresponse_createdonbehalfby", null); }
			set { SetRelatedEntities("lk_campaignresponse_createdonbehalfby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_campaignresponse_modifiedby'
        /// </summary>
		[RelationshipSchemaName("lk_campaignresponse_modifiedby")]
		public IEnumerable<CampaignResponse> LkCampaignresponseModifiedby
		{
			get { return GetRelatedEntities<CampaignResponse>("lk_campaignresponse_modifiedby", null); }
			set { SetRelatedEntities("lk_campaignresponse_modifiedby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_campaignresponse_modifiedonbehalfby'
        /// </summary>
		[RelationshipSchemaName("lk_campaignresponse_modifiedonbehalfby")]
		public IEnumerable<CampaignResponse> LkCampaignresponseModifiedonbehalfby
		{
			get { return GetRelatedEntities<CampaignResponse>("lk_campaignresponse_modifiedonbehalfby", null); }
			set { SetRelatedEntities("lk_campaignresponse_modifiedonbehalfby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_catalog_createdby'
        /// </summary>
		[RelationshipSchemaName("lk_catalog_createdby")]
		public IEnumerable<Catalog> LkCatalogCreatedby
		{
			get { return GetRelatedEntities<Catalog>("lk_catalog_createdby", null); }
			set { SetRelatedEntities("lk_catalog_createdby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_catalog_createdonbehalfby'
        /// </summary>
		[RelationshipSchemaName("lk_catalog_createdonbehalfby")]
		public IEnumerable<Catalog> LkCatalogCreatedonbehalfby
		{
			get { return GetRelatedEntities<Catalog>("lk_catalog_createdonbehalfby", null); }
			set { SetRelatedEntities("lk_catalog_createdonbehalfby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_catalog_modifiedby'
        /// </summary>
		[RelationshipSchemaName("lk_catalog_modifiedby")]
		public IEnumerable<Catalog> LkCatalogModifiedby
		{
			get { return GetRelatedEntities<Catalog>("lk_catalog_modifiedby", null); }
			set { SetRelatedEntities("lk_catalog_modifiedby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_catalog_modifiedonbehalfby'
        /// </summary>
		[RelationshipSchemaName("lk_catalog_modifiedonbehalfby")]
		public IEnumerable<Catalog> LkCatalogModifiedonbehalfby
		{
			get { return GetRelatedEntities<Catalog>("lk_catalog_modifiedonbehalfby", null); }
			set { SetRelatedEntities("lk_catalog_modifiedonbehalfby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_catalogassignment_createdby'
        /// </summary>
		[RelationshipSchemaName("lk_catalogassignment_createdby")]
		public IEnumerable<CatalogAssignment> LkCatalogassignmentCreatedby
		{
			get { return GetRelatedEntities<CatalogAssignment>("lk_catalogassignment_createdby", null); }
			set { SetRelatedEntities("lk_catalogassignment_createdby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_catalogassignment_createdonbehalfby'
        /// </summary>
		[RelationshipSchemaName("lk_catalogassignment_createdonbehalfby")]
		public IEnumerable<CatalogAssignment> LkCatalogassignmentCreatedonbehalfby
		{
			get { return GetRelatedEntities<CatalogAssignment>("lk_catalogassignment_createdonbehalfby", null); }
			set { SetRelatedEntities("lk_catalogassignment_createdonbehalfby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_catalogassignment_modifiedby'
        /// </summary>
		[RelationshipSchemaName("lk_catalogassignment_modifiedby")]
		public IEnumerable<CatalogAssignment> LkCatalogassignmentModifiedby
		{
			get { return GetRelatedEntities<CatalogAssignment>("lk_catalogassignment_modifiedby", null); }
			set { SetRelatedEntities("lk_catalogassignment_modifiedby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_catalogassignment_modifiedonbehalfby'
        /// </summary>
		[RelationshipSchemaName("lk_catalogassignment_modifiedonbehalfby")]
		public IEnumerable<CatalogAssignment> LkCatalogassignmentModifiedonbehalfby
		{
			get { return GetRelatedEntities<CatalogAssignment>("lk_catalogassignment_modifiedonbehalfby", null); }
			set { SetRelatedEntities("lk_catalogassignment_modifiedonbehalfby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_category_createdby'
        /// </summary>
		[RelationshipSchemaName("lk_category_createdby")]
		public IEnumerable<Category> LkCategoryCreatedby
		{
			get { return GetRelatedEntities<Category>("lk_category_createdby", null); }
			set { SetRelatedEntities("lk_category_createdby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_category_createdonbehalfby'
        /// </summary>
		[RelationshipSchemaName("lk_category_createdonbehalfby")]
		public IEnumerable<Category> LkCategoryCreatedonbehalfby
		{
			get { return GetRelatedEntities<Category>("lk_category_createdonbehalfby", null); }
			set { SetRelatedEntities("lk_category_createdonbehalfby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_category_modifiedby'
        /// </summary>
		[RelationshipSchemaName("lk_category_modifiedby")]
		public IEnumerable<Category> LkCategoryModifiedby
		{
			get { return GetRelatedEntities<Category>("lk_category_modifiedby", null); }
			set { SetRelatedEntities("lk_category_modifiedby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_category_modifiedonbehalfby'
        /// </summary>
		[RelationshipSchemaName("lk_category_modifiedonbehalfby")]
		public IEnumerable<Category> LkCategoryModifiedonbehalfby
		{
			get { return GetRelatedEntities<Category>("lk_category_modifiedonbehalfby", null); }
			set { SetRelatedEntities("lk_category_modifiedonbehalfby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_characteristic_createdby'
        /// </summary>
		[RelationshipSchemaName("lk_characteristic_createdby")]
		public IEnumerable<Characteristic> LkCharacteristicCreatedby
		{
			get { return GetRelatedEntities<Characteristic>("lk_characteristic_createdby", null); }
			set { SetRelatedEntities("lk_characteristic_createdby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_characteristic_createdonbehalfby'
        /// </summary>
		[RelationshipSchemaName("lk_characteristic_createdonbehalfby")]
		public IEnumerable<Characteristic> LkCharacteristicCreatedonbehalfby
		{
			get { return GetRelatedEntities<Characteristic>("lk_characteristic_createdonbehalfby", null); }
			set { SetRelatedEntities("lk_characteristic_createdonbehalfby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_characteristic_modifiedby'
        /// </summary>
		[RelationshipSchemaName("lk_characteristic_modifiedby")]
		public IEnumerable<Characteristic> LkCharacteristicModifiedby
		{
			get { return GetRelatedEntities<Characteristic>("lk_characteristic_modifiedby", null); }
			set { SetRelatedEntities("lk_characteristic_modifiedby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_characteristic_modifiedonbehalfby'
        /// </summary>
		[RelationshipSchemaName("lk_characteristic_modifiedonbehalfby")]
		public IEnumerable<Characteristic> LkCharacteristicModifiedonbehalfby
		{
			get { return GetRelatedEntities<Characteristic>("lk_characteristic_modifiedonbehalfby", null); }
			set { SetRelatedEntities("lk_characteristic_modifiedonbehalfby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_columnmapping_createdby'
        /// </summary>
		[RelationshipSchemaName("lk_columnmapping_createdby")]
		public IEnumerable<ColumnMapping> LkColumnmappingCreatedby
		{
			get { return GetRelatedEntities<ColumnMapping>("lk_columnmapping_createdby", null); }
			set { SetRelatedEntities("lk_columnmapping_createdby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_columnmapping_createdonbehalfby'
        /// </summary>
		[RelationshipSchemaName("lk_columnmapping_createdonbehalfby")]
		public IEnumerable<ColumnMapping> LkColumnmappingCreatedonbehalfby
		{
			get { return GetRelatedEntities<ColumnMapping>("lk_columnmapping_createdonbehalfby", null); }
			set { SetRelatedEntities("lk_columnmapping_createdonbehalfby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_columnmapping_modifiedby'
        /// </summary>
		[RelationshipSchemaName("lk_columnmapping_modifiedby")]
		public IEnumerable<ColumnMapping> LkColumnmappingModifiedby
		{
			get { return GetRelatedEntities<ColumnMapping>("lk_columnmapping_modifiedby", null); }
			set { SetRelatedEntities("lk_columnmapping_modifiedby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_columnmapping_modifiedonbehalfby'
        /// </summary>
		[RelationshipSchemaName("lk_columnmapping_modifiedonbehalfby")]
		public IEnumerable<ColumnMapping> LkColumnmappingModifiedonbehalfby
		{
			get { return GetRelatedEntities<ColumnMapping>("lk_columnmapping_modifiedonbehalfby", null); }
			set { SetRelatedEntities("lk_columnmapping_modifiedonbehalfby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_competitor_createdonbehalfby'
        /// </summary>
		[RelationshipSchemaName("lk_competitor_createdonbehalfby")]
		public IEnumerable<Competitor> LkCompetitorCreatedonbehalfby
		{
			get { return GetRelatedEntities<Competitor>("lk_competitor_createdonbehalfby", null); }
			set { SetRelatedEntities("lk_competitor_createdonbehalfby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_competitor_modifiedonbehalfby'
        /// </summary>
		[RelationshipSchemaName("lk_competitor_modifiedonbehalfby")]
		public IEnumerable<Competitor> LkCompetitorModifiedonbehalfby
		{
			get { return GetRelatedEntities<Competitor>("lk_competitor_modifiedonbehalfby", null); }
			set { SetRelatedEntities("lk_competitor_modifiedonbehalfby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_competitoraddress_createdonbehalfby'
        /// </summary>
		[RelationshipSchemaName("lk_competitoraddress_createdonbehalfby")]
		public IEnumerable<CompetitorAddress> LkCompetitoraddressCreatedonbehalfby
		{
			get { return GetRelatedEntities<CompetitorAddress>("lk_competitoraddress_createdonbehalfby", null); }
			set { SetRelatedEntities("lk_competitoraddress_createdonbehalfby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_competitoraddress_modifiedonbehalfby'
        /// </summary>
		[RelationshipSchemaName("lk_competitoraddress_modifiedonbehalfby")]
		public IEnumerable<CompetitorAddress> LkCompetitoraddressModifiedonbehalfby
		{
			get { return GetRelatedEntities<CompetitorAddress>("lk_competitoraddress_modifiedonbehalfby", null); }
			set { SetRelatedEntities("lk_competitoraddress_modifiedonbehalfby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_competitoraddressbase_createdby'
        /// </summary>
		[RelationshipSchemaName("lk_competitoraddressbase_createdby")]
		public IEnumerable<CompetitorAddress> LkCompetitoraddressbaseCreatedby
		{
			get { return GetRelatedEntities<CompetitorAddress>("lk_competitoraddressbase_createdby", null); }
			set { SetRelatedEntities("lk_competitoraddressbase_createdby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_competitoraddressbase_modifiedby'
        /// </summary>
		[RelationshipSchemaName("lk_competitoraddressbase_modifiedby")]
		public IEnumerable<CompetitorAddress> LkCompetitoraddressbaseModifiedby
		{
			get { return GetRelatedEntities<CompetitorAddress>("lk_competitoraddressbase_modifiedby", null); }
			set { SetRelatedEntities("lk_competitoraddressbase_modifiedby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_competitorbase_createdby'
        /// </summary>
		[RelationshipSchemaName("lk_competitorbase_createdby")]
		public IEnumerable<Competitor> LkCompetitorbaseCreatedby
		{
			get { return GetRelatedEntities<Competitor>("lk_competitorbase_createdby", null); }
			set { SetRelatedEntities("lk_competitorbase_createdby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_competitorbase_modifiedby'
        /// </summary>
		[RelationshipSchemaName("lk_competitorbase_modifiedby")]
		public IEnumerable<Competitor> LkCompetitorbaseModifiedby
		{
			get { return GetRelatedEntities<Competitor>("lk_competitorbase_modifiedby", null); }
			set { SetRelatedEntities("lk_competitorbase_modifiedby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_connectionbase_createdonbehalfby'
        /// </summary>
		[RelationshipSchemaName("lk_connectionbase_createdonbehalfby")]
		public IEnumerable<Connection> LkConnectionbaseCreatedonbehalfby
		{
			get { return GetRelatedEntities<Connection>("lk_connectionbase_createdonbehalfby", null); }
			set { SetRelatedEntities("lk_connectionbase_createdonbehalfby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_connectionbase_modifiedonbehalfby'
        /// </summary>
		[RelationshipSchemaName("lk_connectionbase_modifiedonbehalfby")]
		public IEnumerable<Connection> LkConnectionbaseModifiedonbehalfby
		{
			get { return GetRelatedEntities<Connection>("lk_connectionbase_modifiedonbehalfby", null); }
			set { SetRelatedEntities("lk_connectionbase_modifiedonbehalfby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_connectionreference_createdby'
        /// </summary>
		[RelationshipSchemaName("lk_connectionreference_createdby")]
		public IEnumerable<ConnectionReference> LkConnectionreferenceCreatedby
		{
			get { return GetRelatedEntities<ConnectionReference>("lk_connectionreference_createdby", null); }
			set { SetRelatedEntities("lk_connectionreference_createdby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_connectionreference_createdonbehalfby'
        /// </summary>
		[RelationshipSchemaName("lk_connectionreference_createdonbehalfby")]
		public IEnumerable<ConnectionReference> LkConnectionreferenceCreatedonbehalfby
		{
			get { return GetRelatedEntities<ConnectionReference>("lk_connectionreference_createdonbehalfby", null); }
			set { SetRelatedEntities("lk_connectionreference_createdonbehalfby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_connectionreference_modifiedby'
        /// </summary>
		[RelationshipSchemaName("lk_connectionreference_modifiedby")]
		public IEnumerable<ConnectionReference> LkConnectionreferenceModifiedby
		{
			get { return GetRelatedEntities<ConnectionReference>("lk_connectionreference_modifiedby", null); }
			set { SetRelatedEntities("lk_connectionreference_modifiedby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_connectionreference_modifiedonbehalfby'
        /// </summary>
		[RelationshipSchemaName("lk_connectionreference_modifiedonbehalfby")]
		public IEnumerable<ConnectionReference> LkConnectionreferenceModifiedonbehalfby
		{
			get { return GetRelatedEntities<ConnectionReference>("lk_connectionreference_modifiedonbehalfby", null); }
			set { SetRelatedEntities("lk_connectionreference_modifiedonbehalfby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_connectionrolebase_createdonbehalfby'
        /// </summary>
		[RelationshipSchemaName("lk_connectionrolebase_createdonbehalfby")]
		public IEnumerable<ConnectionRole> LkConnectionrolebaseCreatedonbehalfby
		{
			get { return GetRelatedEntities<ConnectionRole>("lk_connectionrolebase_createdonbehalfby", null); }
			set { SetRelatedEntities("lk_connectionrolebase_createdonbehalfby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_connectionrolebase_modifiedonbehalfby'
        /// </summary>
		[RelationshipSchemaName("lk_connectionrolebase_modifiedonbehalfby")]
		public IEnumerable<ConnectionRole> LkConnectionrolebaseModifiedonbehalfby
		{
			get { return GetRelatedEntities<ConnectionRole>("lk_connectionrolebase_modifiedonbehalfby", null); }
			set { SetRelatedEntities("lk_connectionrolebase_modifiedonbehalfby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_connector_createdby'
        /// </summary>
		[RelationshipSchemaName("lk_connector_createdby")]
		public IEnumerable<Connector> LkConnectorCreatedby
		{
			get { return GetRelatedEntities<Connector>("lk_connector_createdby", null); }
			set { SetRelatedEntities("lk_connector_createdby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_connector_createdonbehalfby'
        /// </summary>
		[RelationshipSchemaName("lk_connector_createdonbehalfby")]
		public IEnumerable<Connector> LkConnectorCreatedonbehalfby
		{
			get { return GetRelatedEntities<Connector>("lk_connector_createdonbehalfby", null); }
			set { SetRelatedEntities("lk_connector_createdonbehalfby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_connector_modifiedby'
        /// </summary>
		[RelationshipSchemaName("lk_connector_modifiedby")]
		public IEnumerable<Connector> LkConnectorModifiedby
		{
			get { return GetRelatedEntities<Connector>("lk_connector_modifiedby", null); }
			set { SetRelatedEntities("lk_connector_modifiedby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_connector_modifiedonbehalfby'
        /// </summary>
		[RelationshipSchemaName("lk_connector_modifiedonbehalfby")]
		public IEnumerable<Connector> LkConnectorModifiedonbehalfby
		{
			get { return GetRelatedEntities<Connector>("lk_connector_modifiedonbehalfby", null); }
			set { SetRelatedEntities("lk_connector_modifiedonbehalfby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_constraintbasedgroup_createdby'
        /// </summary>
		[RelationshipSchemaName("lk_constraintbasedgroup_createdby")]
		public IEnumerable<ResourceGroup> LkConstraintbasedgroupCreatedby
		{
			get { return GetRelatedEntities<ResourceGroup>("lk_constraintbasedgroup_createdby", null); }
			set { SetRelatedEntities("lk_constraintbasedgroup_createdby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_constraintbasedgroup_createdonbehalfby'
        /// </summary>
		[RelationshipSchemaName("lk_constraintbasedgroup_createdonbehalfby")]
		public IEnumerable<ResourceGroup> LkConstraintbasedgroupCreatedonbehalfby
		{
			get { return GetRelatedEntities<ResourceGroup>("lk_constraintbasedgroup_createdonbehalfby", null); }
			set { SetRelatedEntities("lk_constraintbasedgroup_createdonbehalfby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_constraintbasedgroup_modifiedby'
        /// </summary>
		[RelationshipSchemaName("lk_constraintbasedgroup_modifiedby")]
		public IEnumerable<ResourceGroup> LkConstraintbasedgroupModifiedby
		{
			get { return GetRelatedEntities<ResourceGroup>("lk_constraintbasedgroup_modifiedby", null); }
			set { SetRelatedEntities("lk_constraintbasedgroup_modifiedby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_constraintbasedgroup_modifiedonbehalfby'
        /// </summary>
		[RelationshipSchemaName("lk_constraintbasedgroup_modifiedonbehalfby")]
		public IEnumerable<ResourceGroup> LkConstraintbasedgroupModifiedonbehalfby
		{
			get { return GetRelatedEntities<ResourceGroup>("lk_constraintbasedgroup_modifiedonbehalfby", null); }
			set { SetRelatedEntities("lk_constraintbasedgroup_modifiedonbehalfby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_contact_createdonbehalfby'
        /// </summary>
		[RelationshipSchemaName("lk_contact_createdonbehalfby")]
		public IEnumerable<Contact> LkContactCreatedonbehalfby
		{
			get { return GetRelatedEntities<Contact>("lk_contact_createdonbehalfby", null); }
			set { SetRelatedEntities("lk_contact_createdonbehalfby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_contact_modifiedonbehalfby'
        /// </summary>
		[RelationshipSchemaName("lk_contact_modifiedonbehalfby")]
		public IEnumerable<Contact> LkContactModifiedonbehalfby
		{
			get { return GetRelatedEntities<Contact>("lk_contact_modifiedonbehalfby", null); }
			set { SetRelatedEntities("lk_contact_modifiedonbehalfby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_contactbase_createdby'
        /// </summary>
		[RelationshipSchemaName("lk_contactbase_createdby")]
		public IEnumerable<Contact> LkContactbaseCreatedby
		{
			get { return GetRelatedEntities<Contact>("lk_contactbase_createdby", null); }
			set { SetRelatedEntities("lk_contactbase_createdby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_contactbase_modifiedby'
        /// </summary>
		[RelationshipSchemaName("lk_contactbase_modifiedby")]
		public IEnumerable<Contact> LkContactbaseModifiedby
		{
			get { return GetRelatedEntities<Contact>("lk_contactbase_modifiedby", null); }
			set { SetRelatedEntities("lk_contactbase_modifiedby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_contract_createdonbehalfby'
        /// </summary>
		[RelationshipSchemaName("lk_contract_createdonbehalfby")]
		public IEnumerable<Contract> LkContractCreatedonbehalfby
		{
			get { return GetRelatedEntities<Contract>("lk_contract_createdonbehalfby", null); }
			set { SetRelatedEntities("lk_contract_createdonbehalfby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_contract_modifiedonbehalfby'
        /// </summary>
		[RelationshipSchemaName("lk_contract_modifiedonbehalfby")]
		public IEnumerable<Contract> LkContractModifiedonbehalfby
		{
			get { return GetRelatedEntities<Contract>("lk_contract_modifiedonbehalfby", null); }
			set { SetRelatedEntities("lk_contract_modifiedonbehalfby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_contractbase_createdby'
        /// </summary>
		[RelationshipSchemaName("lk_contractbase_createdby")]
		public IEnumerable<Contract> LkContractbaseCreatedby
		{
			get { return GetRelatedEntities<Contract>("lk_contractbase_createdby", null); }
			set { SetRelatedEntities("lk_contractbase_createdby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_contractbase_modifiedby'
        /// </summary>
		[RelationshipSchemaName("lk_contractbase_modifiedby")]
		public IEnumerable<Contract> LkContractbaseModifiedby
		{
			get { return GetRelatedEntities<Contract>("lk_contractbase_modifiedby", null); }
			set { SetRelatedEntities("lk_contractbase_modifiedby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_contractdetail_createdonbehalfby'
        /// </summary>
		[RelationshipSchemaName("lk_contractdetail_createdonbehalfby")]
		public IEnumerable<ContractLine> LkContractdetailCreatedonbehalfby
		{
			get { return GetRelatedEntities<ContractLine>("lk_contractdetail_createdonbehalfby", null); }
			set { SetRelatedEntities("lk_contractdetail_createdonbehalfby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_contractdetail_modifiedonbehalfby'
        /// </summary>
		[RelationshipSchemaName("lk_contractdetail_modifiedonbehalfby")]
		public IEnumerable<ContractLine> LkContractdetailModifiedonbehalfby
		{
			get { return GetRelatedEntities<ContractLine>("lk_contractdetail_modifiedonbehalfby", null); }
			set { SetRelatedEntities("lk_contractdetail_modifiedonbehalfby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_contractdetailbase_createdby'
        /// </summary>
		[RelationshipSchemaName("lk_contractdetailbase_createdby")]
		public IEnumerable<ContractLine> LkContractdetailbaseCreatedby
		{
			get { return GetRelatedEntities<ContractLine>("lk_contractdetailbase_createdby", null); }
			set { SetRelatedEntities("lk_contractdetailbase_createdby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_contractdetailbase_modifiedby'
        /// </summary>
		[RelationshipSchemaName("lk_contractdetailbase_modifiedby")]
		public IEnumerable<ContractLine> LkContractdetailbaseModifiedby
		{
			get { return GetRelatedEntities<ContractLine>("lk_contractdetailbase_modifiedby", null); }
			set { SetRelatedEntities("lk_contractdetailbase_modifiedby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_contracttemplate_createdonbehalfby'
        /// </summary>
		[RelationshipSchemaName("lk_contracttemplate_createdonbehalfby")]
		public IEnumerable<ContractTemplate> LkContracttemplateCreatedonbehalfby
		{
			get { return GetRelatedEntities<ContractTemplate>("lk_contracttemplate_createdonbehalfby", null); }
			set { SetRelatedEntities("lk_contracttemplate_createdonbehalfby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_contracttemplate_modifiedonbehalfby'
        /// </summary>
		[RelationshipSchemaName("lk_contracttemplate_modifiedonbehalfby")]
		public IEnumerable<ContractTemplate> LkContracttemplateModifiedonbehalfby
		{
			get { return GetRelatedEntities<ContractTemplate>("lk_contracttemplate_modifiedonbehalfby", null); }
			set { SetRelatedEntities("lk_contracttemplate_modifiedonbehalfby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_contracttemplatebase_createdby'
        /// </summary>
		[RelationshipSchemaName("lk_contracttemplatebase_createdby")]
		public IEnumerable<ContractTemplate> LkContracttemplatebaseCreatedby
		{
			get { return GetRelatedEntities<ContractTemplate>("lk_contracttemplatebase_createdby", null); }
			set { SetRelatedEntities("lk_contracttemplatebase_createdby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_contracttemplatebase_modifiedby'
        /// </summary>
		[RelationshipSchemaName("lk_contracttemplatebase_modifiedby")]
		public IEnumerable<ContractTemplate> LkContracttemplatebaseModifiedby
		{
			get { return GetRelatedEntities<ContractTemplate>("lk_contracttemplatebase_modifiedby", null); }
			set { SetRelatedEntities("lk_contracttemplatebase_modifiedby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_conversationtranscript_createdby'
        /// </summary>
		[RelationshipSchemaName("lk_conversationtranscript_createdby")]
		public IEnumerable<ConversationTranscript> LkConversationtranscriptCreatedby
		{
			get { return GetRelatedEntities<ConversationTranscript>("lk_conversationtranscript_createdby", null); }
			set { SetRelatedEntities("lk_conversationtranscript_createdby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_conversationtranscript_createdonbehalfby'
        /// </summary>
		[RelationshipSchemaName("lk_conversationtranscript_createdonbehalfby")]
		public IEnumerable<ConversationTranscript> LkConversationtranscriptCreatedonbehalfby
		{
			get { return GetRelatedEntities<ConversationTranscript>("lk_conversationtranscript_createdonbehalfby", null); }
			set { SetRelatedEntities("lk_conversationtranscript_createdonbehalfby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_conversationtranscript_modifiedby'
        /// </summary>
		[RelationshipSchemaName("lk_conversationtranscript_modifiedby")]
		public IEnumerable<ConversationTranscript> LkConversationtranscriptModifiedby
		{
			get { return GetRelatedEntities<ConversationTranscript>("lk_conversationtranscript_modifiedby", null); }
			set { SetRelatedEntities("lk_conversationtranscript_modifiedby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_conversationtranscript_modifiedonbehalfby'
        /// </summary>
		[RelationshipSchemaName("lk_conversationtranscript_modifiedonbehalfby")]
		public IEnumerable<ConversationTranscript> LkConversationtranscriptModifiedonbehalfby
		{
			get { return GetRelatedEntities<ConversationTranscript>("lk_conversationtranscript_modifiedonbehalfby", null); }
			set { SetRelatedEntities("lk_conversationtranscript_modifiedonbehalfby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_customapi_createdby'
        /// </summary>
		[RelationshipSchemaName("lk_customapi_createdby")]
		public IEnumerable<CustomAPI> LkCustomapiCreatedby
		{
			get { return GetRelatedEntities<CustomAPI>("lk_customapi_createdby", null); }
			set { SetRelatedEntities("lk_customapi_createdby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_customapi_createdonbehalfby'
        /// </summary>
		[RelationshipSchemaName("lk_customapi_createdonbehalfby")]
		public IEnumerable<CustomAPI> LkCustomapiCreatedonbehalfby
		{
			get { return GetRelatedEntities<CustomAPI>("lk_customapi_createdonbehalfby", null); }
			set { SetRelatedEntities("lk_customapi_createdonbehalfby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_customapi_modifiedby'
        /// </summary>
		[RelationshipSchemaName("lk_customapi_modifiedby")]
		public IEnumerable<CustomAPI> LkCustomapiModifiedby
		{
			get { return GetRelatedEntities<CustomAPI>("lk_customapi_modifiedby", null); }
			set { SetRelatedEntities("lk_customapi_modifiedby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_customapi_modifiedonbehalfby'
        /// </summary>
		[RelationshipSchemaName("lk_customapi_modifiedonbehalfby")]
		public IEnumerable<CustomAPI> LkCustomapiModifiedonbehalfby
		{
			get { return GetRelatedEntities<CustomAPI>("lk_customapi_modifiedonbehalfby", null); }
			set { SetRelatedEntities("lk_customapi_modifiedonbehalfby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_customapirequestparameter_createdby'
        /// </summary>
		[RelationshipSchemaName("lk_customapirequestparameter_createdby")]
		public IEnumerable<CustomAPIRequestParameter> LkCustomapirequestparameterCreatedby
		{
			get { return GetRelatedEntities<CustomAPIRequestParameter>("lk_customapirequestparameter_createdby", null); }
			set { SetRelatedEntities("lk_customapirequestparameter_createdby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_customapirequestparameter_createdonbehalfby'
        /// </summary>
		[RelationshipSchemaName("lk_customapirequestparameter_createdonbehalfby")]
		public IEnumerable<CustomAPIRequestParameter> LkCustomapirequestparameterCreatedonbehalfby
		{
			get { return GetRelatedEntities<CustomAPIRequestParameter>("lk_customapirequestparameter_createdonbehalfby", null); }
			set { SetRelatedEntities("lk_customapirequestparameter_createdonbehalfby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_customapirequestparameter_modifiedby'
        /// </summary>
		[RelationshipSchemaName("lk_customapirequestparameter_modifiedby")]
		public IEnumerable<CustomAPIRequestParameter> LkCustomapirequestparameterModifiedby
		{
			get { return GetRelatedEntities<CustomAPIRequestParameter>("lk_customapirequestparameter_modifiedby", null); }
			set { SetRelatedEntities("lk_customapirequestparameter_modifiedby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_customapirequestparameter_modifiedonbehalfby'
        /// </summary>
		[RelationshipSchemaName("lk_customapirequestparameter_modifiedonbehalfby")]
		public IEnumerable<CustomAPIRequestParameter> LkCustomapirequestparameterModifiedonbehalfby
		{
			get { return GetRelatedEntities<CustomAPIRequestParameter>("lk_customapirequestparameter_modifiedonbehalfby", null); }
			set { SetRelatedEntities("lk_customapirequestparameter_modifiedonbehalfby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_customapiresponseproperty_createdby'
        /// </summary>
		[RelationshipSchemaName("lk_customapiresponseproperty_createdby")]
		public IEnumerable<CustomAPIResponseProperty> LkCustomapiresponsepropertyCreatedby
		{
			get { return GetRelatedEntities<CustomAPIResponseProperty>("lk_customapiresponseproperty_createdby", null); }
			set { SetRelatedEntities("lk_customapiresponseproperty_createdby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_customapiresponseproperty_createdonbehalfby'
        /// </summary>
		[RelationshipSchemaName("lk_customapiresponseproperty_createdonbehalfby")]
		public IEnumerable<CustomAPIResponseProperty> LkCustomapiresponsepropertyCreatedonbehalfby
		{
			get { return GetRelatedEntities<CustomAPIResponseProperty>("lk_customapiresponseproperty_createdonbehalfby", null); }
			set { SetRelatedEntities("lk_customapiresponseproperty_createdonbehalfby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_customapiresponseproperty_modifiedby'
        /// </summary>
		[RelationshipSchemaName("lk_customapiresponseproperty_modifiedby")]
		public IEnumerable<CustomAPIResponseProperty> LkCustomapiresponsepropertyModifiedby
		{
			get { return GetRelatedEntities<CustomAPIResponseProperty>("lk_customapiresponseproperty_modifiedby", null); }
			set { SetRelatedEntities("lk_customapiresponseproperty_modifiedby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_customapiresponseproperty_modifiedonbehalfby'
        /// </summary>
		[RelationshipSchemaName("lk_customapiresponseproperty_modifiedonbehalfby")]
		public IEnumerable<CustomAPIResponseProperty> LkCustomapiresponsepropertyModifiedonbehalfby
		{
			get { return GetRelatedEntities<CustomAPIResponseProperty>("lk_customapiresponseproperty_modifiedonbehalfby", null); }
			set { SetRelatedEntities("lk_customapiresponseproperty_modifiedonbehalfby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_customcontrol_createdby'
        /// </summary>
		[RelationshipSchemaName("lk_customcontrol_createdby")]
		public IEnumerable<CustomControl> LkCustomcontrolCreatedby
		{
			get { return GetRelatedEntities<CustomControl>("lk_customcontrol_createdby", null); }
			set { SetRelatedEntities("lk_customcontrol_createdby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_customcontrol_createdonbehalfby'
        /// </summary>
		[RelationshipSchemaName("lk_customcontrol_createdonbehalfby")]
		public IEnumerable<CustomControl> LkCustomcontrolCreatedonbehalfby
		{
			get { return GetRelatedEntities<CustomControl>("lk_customcontrol_createdonbehalfby", null); }
			set { SetRelatedEntities("lk_customcontrol_createdonbehalfby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_customcontrol_modifiedby'
        /// </summary>
		[RelationshipSchemaName("lk_customcontrol_modifiedby")]
		public IEnumerable<CustomControl> LkCustomcontrolModifiedby
		{
			get { return GetRelatedEntities<CustomControl>("lk_customcontrol_modifiedby", null); }
			set { SetRelatedEntities("lk_customcontrol_modifiedby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_customcontrol_modifiedonbehalfby'
        /// </summary>
		[RelationshipSchemaName("lk_customcontrol_modifiedonbehalfby")]
		public IEnumerable<CustomControl> LkCustomcontrolModifiedonbehalfby
		{
			get { return GetRelatedEntities<CustomControl>("lk_customcontrol_modifiedonbehalfby", null); }
			set { SetRelatedEntities("lk_customcontrol_modifiedonbehalfby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_customcontroldefaultconfig_createdby'
        /// </summary>
		[RelationshipSchemaName("lk_customcontroldefaultconfig_createdby")]
		public IEnumerable<CustomControlDefaultConfig> LkCustomcontroldefaultconfigCreatedby
		{
			get { return GetRelatedEntities<CustomControlDefaultConfig>("lk_customcontroldefaultconfig_createdby", null); }
			set { SetRelatedEntities("lk_customcontroldefaultconfig_createdby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_customcontroldefaultconfig_createdonbehalfby'
        /// </summary>
		[RelationshipSchemaName("lk_customcontroldefaultconfig_createdonbehalfby")]
		public IEnumerable<CustomControlDefaultConfig> LkCustomcontroldefaultconfigCreatedonbehalfby
		{
			get { return GetRelatedEntities<CustomControlDefaultConfig>("lk_customcontroldefaultconfig_createdonbehalfby", null); }
			set { SetRelatedEntities("lk_customcontroldefaultconfig_createdonbehalfby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_customcontroldefaultconfig_modifiedby'
        /// </summary>
		[RelationshipSchemaName("lk_customcontroldefaultconfig_modifiedby")]
		public IEnumerable<CustomControlDefaultConfig> LkCustomcontroldefaultconfigModifiedby
		{
			get { return GetRelatedEntities<CustomControlDefaultConfig>("lk_customcontroldefaultconfig_modifiedby", null); }
			set { SetRelatedEntities("lk_customcontroldefaultconfig_modifiedby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_customcontroldefaultconfig_modifiedonbehalfby'
        /// </summary>
		[RelationshipSchemaName("lk_customcontroldefaultconfig_modifiedonbehalfby")]
		public IEnumerable<CustomControlDefaultConfig> LkCustomcontroldefaultconfigModifiedonbehalfby
		{
			get { return GetRelatedEntities<CustomControlDefaultConfig>("lk_customcontroldefaultconfig_modifiedonbehalfby", null); }
			set { SetRelatedEntities("lk_customcontroldefaultconfig_modifiedonbehalfby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_customcontrolresource_createdby'
        /// </summary>
		[RelationshipSchemaName("lk_customcontrolresource_createdby")]
		public IEnumerable<CustomControlResource> LkCustomcontrolresourceCreatedby
		{
			get { return GetRelatedEntities<CustomControlResource>("lk_customcontrolresource_createdby", null); }
			set { SetRelatedEntities("lk_customcontrolresource_createdby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_customcontrolresource_createdonbehalfby'
        /// </summary>
		[RelationshipSchemaName("lk_customcontrolresource_createdonbehalfby")]
		public IEnumerable<CustomControlResource> LkCustomcontrolresourceCreatedonbehalfby
		{
			get { return GetRelatedEntities<CustomControlResource>("lk_customcontrolresource_createdonbehalfby", null); }
			set { SetRelatedEntities("lk_customcontrolresource_createdonbehalfby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_customcontrolresource_modifiedby'
        /// </summary>
		[RelationshipSchemaName("lk_customcontrolresource_modifiedby")]
		public IEnumerable<CustomControlResource> LkCustomcontrolresourceModifiedby
		{
			get { return GetRelatedEntities<CustomControlResource>("lk_customcontrolresource_modifiedby", null); }
			set { SetRelatedEntities("lk_customcontrolresource_modifiedby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_customcontrolresource_modifiedonbehalfby'
        /// </summary>
		[RelationshipSchemaName("lk_customcontrolresource_modifiedonbehalfby")]
		public IEnumerable<CustomControlResource> LkCustomcontrolresourceModifiedonbehalfby
		{
			get { return GetRelatedEntities<CustomControlResource>("lk_customcontrolresource_modifiedonbehalfby", null); }
			set { SetRelatedEntities("lk_customcontrolresource_modifiedonbehalfby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_customeraddress_createdonbehalfby'
        /// </summary>
		[RelationshipSchemaName("lk_customeraddress_createdonbehalfby")]
		public IEnumerable<Address> LkCustomeraddressCreatedonbehalfby
		{
			get { return GetRelatedEntities<Address>("lk_customeraddress_createdonbehalfby", null); }
			set { SetRelatedEntities("lk_customeraddress_createdonbehalfby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_customeraddress_modifiedonbehalfby'
        /// </summary>
		[RelationshipSchemaName("lk_customeraddress_modifiedonbehalfby")]
		public IEnumerable<Address> LkCustomeraddressModifiedonbehalfby
		{
			get { return GetRelatedEntities<Address>("lk_customeraddress_modifiedonbehalfby", null); }
			set { SetRelatedEntities("lk_customeraddress_modifiedonbehalfby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_customeraddressbase_createdby'
        /// </summary>
		[RelationshipSchemaName("lk_customeraddressbase_createdby")]
		public IEnumerable<Address> LkCustomeraddressbaseCreatedby
		{
			get { return GetRelatedEntities<Address>("lk_customeraddressbase_createdby", null); }
			set { SetRelatedEntities("lk_customeraddressbase_createdby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_customeraddressbase_modifiedby'
        /// </summary>
		[RelationshipSchemaName("lk_customeraddressbase_modifiedby")]
		public IEnumerable<Address> LkCustomeraddressbaseModifiedby
		{
			get { return GetRelatedEntities<Address>("lk_customeraddressbase_modifiedby", null); }
			set { SetRelatedEntities("lk_customeraddressbase_modifiedby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_datalakefolder_createdby'
        /// </summary>
		[RelationshipSchemaName("lk_datalakefolder_createdby")]
		public IEnumerable<DataLakeFolder> LkDatalakefolderCreatedby
		{
			get { return GetRelatedEntities<DataLakeFolder>("lk_datalakefolder_createdby", null); }
			set { SetRelatedEntities("lk_datalakefolder_createdby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_datalakefolder_createdonbehalfby'
        /// </summary>
		[RelationshipSchemaName("lk_datalakefolder_createdonbehalfby")]
		public IEnumerable<DataLakeFolder> LkDatalakefolderCreatedonbehalfby
		{
			get { return GetRelatedEntities<DataLakeFolder>("lk_datalakefolder_createdonbehalfby", null); }
			set { SetRelatedEntities("lk_datalakefolder_createdonbehalfby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_datalakefolder_modifiedby'
        /// </summary>
		[RelationshipSchemaName("lk_datalakefolder_modifiedby")]
		public IEnumerable<DataLakeFolder> LkDatalakefolderModifiedby
		{
			get { return GetRelatedEntities<DataLakeFolder>("lk_datalakefolder_modifiedby", null); }
			set { SetRelatedEntities("lk_datalakefolder_modifiedby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_datalakefolder_modifiedonbehalfby'
        /// </summary>
		[RelationshipSchemaName("lk_datalakefolder_modifiedonbehalfby")]
		public IEnumerable<DataLakeFolder> LkDatalakefolderModifiedonbehalfby
		{
			get { return GetRelatedEntities<DataLakeFolder>("lk_datalakefolder_modifiedonbehalfby", null); }
			set { SetRelatedEntities("lk_datalakefolder_modifiedonbehalfby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_datalakefolderpermission_createdby'
        /// </summary>
		[RelationshipSchemaName("lk_datalakefolderpermission_createdby")]
		public IEnumerable<DataLakeFolderPermission> LkDatalakefolderpermissionCreatedby
		{
			get { return GetRelatedEntities<DataLakeFolderPermission>("lk_datalakefolderpermission_createdby", null); }
			set { SetRelatedEntities("lk_datalakefolderpermission_createdby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_datalakefolderpermission_createdonbehalfby'
        /// </summary>
		[RelationshipSchemaName("lk_datalakefolderpermission_createdonbehalfby")]
		public IEnumerable<DataLakeFolderPermission> LkDatalakefolderpermissionCreatedonbehalfby
		{
			get { return GetRelatedEntities<DataLakeFolderPermission>("lk_datalakefolderpermission_createdonbehalfby", null); }
			set { SetRelatedEntities("lk_datalakefolderpermission_createdonbehalfby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_datalakefolderpermission_modifiedby'
        /// </summary>
		[RelationshipSchemaName("lk_datalakefolderpermission_modifiedby")]
		public IEnumerable<DataLakeFolderPermission> LkDatalakefolderpermissionModifiedby
		{
			get { return GetRelatedEntities<DataLakeFolderPermission>("lk_datalakefolderpermission_modifiedby", null); }
			set { SetRelatedEntities("lk_datalakefolderpermission_modifiedby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_datalakefolderpermission_modifiedonbehalfby'
        /// </summary>
		[RelationshipSchemaName("lk_datalakefolderpermission_modifiedonbehalfby")]
		public IEnumerable<DataLakeFolderPermission> LkDatalakefolderpermissionModifiedonbehalfby
		{
			get { return GetRelatedEntities<DataLakeFolderPermission>("lk_datalakefolderpermission_modifiedonbehalfby", null); }
			set { SetRelatedEntities("lk_datalakefolderpermission_modifiedonbehalfby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_datalakeworkspace_createdby'
        /// </summary>
		[RelationshipSchemaName("lk_datalakeworkspace_createdby")]
		public IEnumerable<DataLakeWorkspace> LkDatalakeworkspaceCreatedby
		{
			get { return GetRelatedEntities<DataLakeWorkspace>("lk_datalakeworkspace_createdby", null); }
			set { SetRelatedEntities("lk_datalakeworkspace_createdby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_datalakeworkspace_createdonbehalfby'
        /// </summary>
		[RelationshipSchemaName("lk_datalakeworkspace_createdonbehalfby")]
		public IEnumerable<DataLakeWorkspace> LkDatalakeworkspaceCreatedonbehalfby
		{
			get { return GetRelatedEntities<DataLakeWorkspace>("lk_datalakeworkspace_createdonbehalfby", null); }
			set { SetRelatedEntities("lk_datalakeworkspace_createdonbehalfby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_datalakeworkspace_modifiedby'
        /// </summary>
		[RelationshipSchemaName("lk_datalakeworkspace_modifiedby")]
		public IEnumerable<DataLakeWorkspace> LkDatalakeworkspaceModifiedby
		{
			get { return GetRelatedEntities<DataLakeWorkspace>("lk_datalakeworkspace_modifiedby", null); }
			set { SetRelatedEntities("lk_datalakeworkspace_modifiedby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_datalakeworkspace_modifiedonbehalfby'
        /// </summary>
		[RelationshipSchemaName("lk_datalakeworkspace_modifiedonbehalfby")]
		public IEnumerable<DataLakeWorkspace> LkDatalakeworkspaceModifiedonbehalfby
		{
			get { return GetRelatedEntities<DataLakeWorkspace>("lk_datalakeworkspace_modifiedonbehalfby", null); }
			set { SetRelatedEntities("lk_datalakeworkspace_modifiedonbehalfby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_datalakeworkspacepermission_createdby'
        /// </summary>
		[RelationshipSchemaName("lk_datalakeworkspacepermission_createdby")]
		public IEnumerable<DataLakeWorkspacePermission> LkDatalakeworkspacepermissionCreatedby
		{
			get { return GetRelatedEntities<DataLakeWorkspacePermission>("lk_datalakeworkspacepermission_createdby", null); }
			set { SetRelatedEntities("lk_datalakeworkspacepermission_createdby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_datalakeworkspacepermission_createdonbehalfby'
        /// </summary>
		[RelationshipSchemaName("lk_datalakeworkspacepermission_createdonbehalfby")]
		public IEnumerable<DataLakeWorkspacePermission> LkDatalakeworkspacepermissionCreatedonbehalfby
		{
			get { return GetRelatedEntities<DataLakeWorkspacePermission>("lk_datalakeworkspacepermission_createdonbehalfby", null); }
			set { SetRelatedEntities("lk_datalakeworkspacepermission_createdonbehalfby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_datalakeworkspacepermission_modifiedby'
        /// </summary>
		[RelationshipSchemaName("lk_datalakeworkspacepermission_modifiedby")]
		public IEnumerable<DataLakeWorkspacePermission> LkDatalakeworkspacepermissionModifiedby
		{
			get { return GetRelatedEntities<DataLakeWorkspacePermission>("lk_datalakeworkspacepermission_modifiedby", null); }
			set { SetRelatedEntities("lk_datalakeworkspacepermission_modifiedby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_datalakeworkspacepermission_modifiedonbehalfby'
        /// </summary>
		[RelationshipSchemaName("lk_datalakeworkspacepermission_modifiedonbehalfby")]
		public IEnumerable<DataLakeWorkspacePermission> LkDatalakeworkspacepermissionModifiedonbehalfby
		{
			get { return GetRelatedEntities<DataLakeWorkspacePermission>("lk_datalakeworkspacepermission_modifiedonbehalfby", null); }
			set { SetRelatedEntities("lk_datalakeworkspacepermission_modifiedonbehalfby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_discount_createdonbehalfby'
        /// </summary>
		[RelationshipSchemaName("lk_discount_createdonbehalfby")]
		public IEnumerable<Discount> LkDiscountCreatedonbehalfby
		{
			get { return GetRelatedEntities<Discount>("lk_discount_createdonbehalfby", null); }
			set { SetRelatedEntities("lk_discount_createdonbehalfby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_discount_modifiedonbehalfby'
        /// </summary>
		[RelationshipSchemaName("lk_discount_modifiedonbehalfby")]
		public IEnumerable<Discount> LkDiscountModifiedonbehalfby
		{
			get { return GetRelatedEntities<Discount>("lk_discount_modifiedonbehalfby", null); }
			set { SetRelatedEntities("lk_discount_modifiedonbehalfby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_discountbase_createdby'
        /// </summary>
		[RelationshipSchemaName("lk_discountbase_createdby")]
		public IEnumerable<Discount> LkDiscountbaseCreatedby
		{
			get { return GetRelatedEntities<Discount>("lk_discountbase_createdby", null); }
			set { SetRelatedEntities("lk_discountbase_createdby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_discountbase_modifiedby'
        /// </summary>
		[RelationshipSchemaName("lk_discountbase_modifiedby")]
		public IEnumerable<Discount> LkDiscountbaseModifiedby
		{
			get { return GetRelatedEntities<Discount>("lk_discountbase_modifiedby", null); }
			set { SetRelatedEntities("lk_discountbase_modifiedby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_discounttype_createdonbehalfby'
        /// </summary>
		[RelationshipSchemaName("lk_discounttype_createdonbehalfby")]
		public IEnumerable<DiscountList> LkDiscounttypeCreatedonbehalfby
		{
			get { return GetRelatedEntities<DiscountList>("lk_discounttype_createdonbehalfby", null); }
			set { SetRelatedEntities("lk_discounttype_createdonbehalfby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_discounttype_modifiedonbehalfby'
        /// </summary>
		[RelationshipSchemaName("lk_discounttype_modifiedonbehalfby")]
		public IEnumerable<DiscountList> LkDiscounttypeModifiedonbehalfby
		{
			get { return GetRelatedEntities<DiscountList>("lk_discounttype_modifiedonbehalfby", null); }
			set { SetRelatedEntities("lk_discounttype_modifiedonbehalfby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_discounttypebase_createdby'
        /// </summary>
		[RelationshipSchemaName("lk_discounttypebase_createdby")]
		public IEnumerable<DiscountList> LkDiscounttypebaseCreatedby
		{
			get { return GetRelatedEntities<DiscountList>("lk_discounttypebase_createdby", null); }
			set { SetRelatedEntities("lk_discounttypebase_createdby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_discounttypebase_modifiedby'
        /// </summary>
		[RelationshipSchemaName("lk_discounttypebase_modifiedby")]
		public IEnumerable<DiscountList> LkDiscounttypebaseModifiedby
		{
			get { return GetRelatedEntities<DiscountList>("lk_discounttypebase_modifiedby", null); }
			set { SetRelatedEntities("lk_discounttypebase_modifiedby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_DisplayStringbase_createdby'
        /// </summary>
		[RelationshipSchemaName("lk_DisplayStringbase_createdby")]
		public IEnumerable<DisplayString> LkDisplayStringbaseCreatedby
		{
			get { return GetRelatedEntities<DisplayString>("lk_DisplayStringbase_createdby", null); }
			set { SetRelatedEntities("lk_DisplayStringbase_createdby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_DisplayStringbase_createdonbehalfby'
        /// </summary>
		[RelationshipSchemaName("lk_DisplayStringbase_createdonbehalfby")]
		public IEnumerable<DisplayString> LkDisplayStringbaseCreatedonbehalfby
		{
			get { return GetRelatedEntities<DisplayString>("lk_DisplayStringbase_createdonbehalfby", null); }
			set { SetRelatedEntities("lk_DisplayStringbase_createdonbehalfby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_DisplayStringbase_modifiedby'
        /// </summary>
		[RelationshipSchemaName("lk_DisplayStringbase_modifiedby")]
		public IEnumerable<DisplayString> LkDisplayStringbaseModifiedby
		{
			get { return GetRelatedEntities<DisplayString>("lk_DisplayStringbase_modifiedby", null); }
			set { SetRelatedEntities("lk_DisplayStringbase_modifiedby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_DisplayStringbase_modifiedonbehalfby'
        /// </summary>
		[RelationshipSchemaName("lk_DisplayStringbase_modifiedonbehalfby")]
		public IEnumerable<DisplayString> LkDisplayStringbaseModifiedonbehalfby
		{
			get { return GetRelatedEntities<DisplayString>("lk_DisplayStringbase_modifiedonbehalfby", null); }
			set { SetRelatedEntities("lk_DisplayStringbase_modifiedonbehalfby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_documenttemplatebase_createdby'
        /// </summary>
		[RelationshipSchemaName("lk_documenttemplatebase_createdby")]
		public IEnumerable<DocumentTemplate> LkDocumenttemplatebaseCreatedby
		{
			get { return GetRelatedEntities<DocumentTemplate>("lk_documenttemplatebase_createdby", null); }
			set { SetRelatedEntities("lk_documenttemplatebase_createdby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_documenttemplatebase_createdonbehalfby'
        /// </summary>
		[RelationshipSchemaName("lk_documenttemplatebase_createdonbehalfby")]
		public IEnumerable<DocumentTemplate> LkDocumenttemplatebaseCreatedonbehalfby
		{
			get { return GetRelatedEntities<DocumentTemplate>("lk_documenttemplatebase_createdonbehalfby", null); }
			set { SetRelatedEntities("lk_documenttemplatebase_createdonbehalfby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_documenttemplatebase_modifiedby'
        /// </summary>
		[RelationshipSchemaName("lk_documenttemplatebase_modifiedby")]
		public IEnumerable<DocumentTemplate> LkDocumenttemplatebaseModifiedby
		{
			get { return GetRelatedEntities<DocumentTemplate>("lk_documenttemplatebase_modifiedby", null); }
			set { SetRelatedEntities("lk_documenttemplatebase_modifiedby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_documenttemplatebase_modifiedonbehalfby'
        /// </summary>
		[RelationshipSchemaName("lk_documenttemplatebase_modifiedonbehalfby")]
		public IEnumerable<DocumentTemplate> LkDocumenttemplatebaseModifiedonbehalfby
		{
			get { return GetRelatedEntities<DocumentTemplate>("lk_documenttemplatebase_modifiedonbehalfby", null); }
			set { SetRelatedEntities("lk_documenttemplatebase_modifiedonbehalfby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_duplicaterule_createdonbehalfby'
        /// </summary>
		[RelationshipSchemaName("lk_duplicaterule_createdonbehalfby")]
		public IEnumerable<DuplicateDetectionRule> LkDuplicateruleCreatedonbehalfby
		{
			get { return GetRelatedEntities<DuplicateDetectionRule>("lk_duplicaterule_createdonbehalfby", null); }
			set { SetRelatedEntities("lk_duplicaterule_createdonbehalfby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_duplicaterule_modifiedonbehalfby'
        /// </summary>
		[RelationshipSchemaName("lk_duplicaterule_modifiedonbehalfby")]
		public IEnumerable<DuplicateDetectionRule> LkDuplicateruleModifiedonbehalfby
		{
			get { return GetRelatedEntities<DuplicateDetectionRule>("lk_duplicaterule_modifiedonbehalfby", null); }
			set { SetRelatedEntities("lk_duplicaterule_modifiedonbehalfby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_duplicaterulebase_createdby'
        /// </summary>
		[RelationshipSchemaName("lk_duplicaterulebase_createdby")]
		public IEnumerable<DuplicateDetectionRule> LkDuplicaterulebaseCreatedby
		{
			get { return GetRelatedEntities<DuplicateDetectionRule>("lk_duplicaterulebase_createdby", null); }
			set { SetRelatedEntities("lk_duplicaterulebase_createdby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_duplicaterulebase_modifiedby'
        /// </summary>
		[RelationshipSchemaName("lk_duplicaterulebase_modifiedby")]
		public IEnumerable<DuplicateDetectionRule> LkDuplicaterulebaseModifiedby
		{
			get { return GetRelatedEntities<DuplicateDetectionRule>("lk_duplicaterulebase_modifiedby", null); }
			set { SetRelatedEntities("lk_duplicaterulebase_modifiedby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_duplicaterulecondition_createdonbehalfby'
        /// </summary>
		[RelationshipSchemaName("lk_duplicaterulecondition_createdonbehalfby")]
		public IEnumerable<DuplicateRuleCondition> LkDuplicateruleconditionCreatedonbehalfby
		{
			get { return GetRelatedEntities<DuplicateRuleCondition>("lk_duplicaterulecondition_createdonbehalfby", null); }
			set { SetRelatedEntities("lk_duplicaterulecondition_createdonbehalfby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_duplicaterulecondition_modifiedonbehalfby'
        /// </summary>
		[RelationshipSchemaName("lk_duplicaterulecondition_modifiedonbehalfby")]
		public IEnumerable<DuplicateRuleCondition> LkDuplicateruleconditionModifiedonbehalfby
		{
			get { return GetRelatedEntities<DuplicateRuleCondition>("lk_duplicaterulecondition_modifiedonbehalfby", null); }
			set { SetRelatedEntities("lk_duplicaterulecondition_modifiedonbehalfby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_duplicateruleconditionbase_createdby'
        /// </summary>
		[RelationshipSchemaName("lk_duplicateruleconditionbase_createdby")]
		public IEnumerable<DuplicateRuleCondition> LkDuplicateruleconditionbaseCreatedby
		{
			get { return GetRelatedEntities<DuplicateRuleCondition>("lk_duplicateruleconditionbase_createdby", null); }
			set { SetRelatedEntities("lk_duplicateruleconditionbase_createdby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_duplicateruleconditionbase_modifiedby'
        /// </summary>
		[RelationshipSchemaName("lk_duplicateruleconditionbase_modifiedby")]
		public IEnumerable<DuplicateRuleCondition> LkDuplicateruleconditionbaseModifiedby
		{
			get { return GetRelatedEntities<DuplicateRuleCondition>("lk_duplicateruleconditionbase_modifiedby", null); }
			set { SetRelatedEntities("lk_duplicateruleconditionbase_modifiedby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_DynamicProperty_createdby'
        /// </summary>
		[RelationshipSchemaName("lk_DynamicProperty_createdby")]
		public IEnumerable<Property> LkDynamicPropertyCreatedby
		{
			get { return GetRelatedEntities<Property>("lk_DynamicProperty_createdby", null); }
			set { SetRelatedEntities("lk_DynamicProperty_createdby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_DynamicProperty_createdonbehalfby'
        /// </summary>
		[RelationshipSchemaName("lk_DynamicProperty_createdonbehalfby")]
		public IEnumerable<Property> LkDynamicPropertyCreatedonbehalfby
		{
			get { return GetRelatedEntities<Property>("lk_DynamicProperty_createdonbehalfby", null); }
			set { SetRelatedEntities("lk_DynamicProperty_createdonbehalfby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_DynamicProperty_modifiedby'
        /// </summary>
		[RelationshipSchemaName("lk_DynamicProperty_modifiedby")]
		public IEnumerable<Property> LkDynamicPropertyModifiedby
		{
			get { return GetRelatedEntities<Property>("lk_DynamicProperty_modifiedby", null); }
			set { SetRelatedEntities("lk_DynamicProperty_modifiedby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_DynamicProperty_modifiedonbehalfby'
        /// </summary>
		[RelationshipSchemaName("lk_DynamicProperty_modifiedonbehalfby")]
		public IEnumerable<Property> LkDynamicPropertyModifiedonbehalfby
		{
			get { return GetRelatedEntities<Property>("lk_DynamicProperty_modifiedonbehalfby", null); }
			set { SetRelatedEntities("lk_DynamicProperty_modifiedonbehalfby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_DynamicPropertyAssociationattribute_createdby'
        /// </summary>
		[RelationshipSchemaName("lk_DynamicPropertyAssociationattribute_createdby")]
		public IEnumerable<PropertyAssociation> LkDynamicPropertyAssociationattributeCreatedby
		{
			get { return GetRelatedEntities<PropertyAssociation>("lk_DynamicPropertyAssociationattribute_createdby", null); }
			set { SetRelatedEntities("lk_DynamicPropertyAssociationattribute_createdby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_DynamicPropertyAssociationattribute_CreatedOnBehalfBy'
        /// </summary>
		[RelationshipSchemaName("lk_DynamicPropertyAssociationattribute_CreatedOnBehalfBy")]
		public IEnumerable<PropertyAssociation> LkDynamicPropertyAssociationattributeCreatedOnBehalfBy
		{
			get { return GetRelatedEntities<PropertyAssociation>("lk_DynamicPropertyAssociationattribute_CreatedOnBehalfBy", null); }
			set { SetRelatedEntities("lk_DynamicPropertyAssociationattribute_CreatedOnBehalfBy", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_DynamicPropertyAssociationattribute_ModifiedBy'
        /// </summary>
		[RelationshipSchemaName("lk_DynamicPropertyAssociationattribute_ModifiedBy")]
		public IEnumerable<PropertyAssociation> LkDynamicPropertyAssociationattributeModifiedBy
		{
			get { return GetRelatedEntities<PropertyAssociation>("lk_DynamicPropertyAssociationattribute_ModifiedBy", null); }
			set { SetRelatedEntities("lk_DynamicPropertyAssociationattribute_ModifiedBy", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_DynamicPropertyAssociationattribute_ModifiedOnBehalfBy'
        /// </summary>
		[RelationshipSchemaName("lk_DynamicPropertyAssociationattribute_ModifiedOnBehalfBy")]
		public IEnumerable<PropertyAssociation> LkDynamicPropertyAssociationattributeModifiedOnBehalfBy
		{
			get { return GetRelatedEntities<PropertyAssociation>("lk_DynamicPropertyAssociationattribute_ModifiedOnBehalfBy", null); }
			set { SetRelatedEntities("lk_DynamicPropertyAssociationattribute_ModifiedOnBehalfBy", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_Dynamicpropertyinsatanceattribute_createdonbehalfby'
        /// </summary>
		[RelationshipSchemaName("lk_Dynamicpropertyinsatanceattribute_createdonbehalfby")]
		public IEnumerable<PropertyInstance> LkDynamicpropertyinsatanceattributeCreatedonbehalfby
		{
			get { return GetRelatedEntities<PropertyInstance>("lk_Dynamicpropertyinsatanceattribute_createdonbehalfby", null); }
			set { SetRelatedEntities("lk_Dynamicpropertyinsatanceattribute_createdonbehalfby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_Dynamicpropertyinsatanceattribute_ModifiedBy'
        /// </summary>
		[RelationshipSchemaName("lk_Dynamicpropertyinsatanceattribute_ModifiedBy")]
		public IEnumerable<PropertyInstance> LkDynamicpropertyinsatanceattributeModifiedBy
		{
			get { return GetRelatedEntities<PropertyInstance>("lk_Dynamicpropertyinsatanceattribute_ModifiedBy", null); }
			set { SetRelatedEntities("lk_Dynamicpropertyinsatanceattribute_ModifiedBy", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_Dynamicpropertyinsatanceattribute_ModifiedOnBehalfBy'
        /// </summary>
		[RelationshipSchemaName("lk_Dynamicpropertyinsatanceattribute_ModifiedOnBehalfBy")]
		public IEnumerable<PropertyInstance> LkDynamicpropertyinsatanceattributeModifiedOnBehalfBy
		{
			get { return GetRelatedEntities<PropertyInstance>("lk_Dynamicpropertyinsatanceattribute_ModifiedOnBehalfBy", null); }
			set { SetRelatedEntities("lk_Dynamicpropertyinsatanceattribute_ModifiedOnBehalfBy", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_DynamicPropertyOptionSetItem_createdby'
        /// </summary>
		[RelationshipSchemaName("lk_DynamicPropertyOptionSetItem_createdby")]
		public IEnumerable<PropertyOptionSetItem> LkDynamicPropertyOptionSetItemCreatedby
		{
			get { return GetRelatedEntities<PropertyOptionSetItem>("lk_DynamicPropertyOptionSetItem_createdby", null); }
			set { SetRelatedEntities("lk_DynamicPropertyOptionSetItem_createdby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_DynamicPropertyOptionSetItem_createdonbehalfby'
        /// </summary>
		[RelationshipSchemaName("lk_DynamicPropertyOptionSetItem_createdonbehalfby")]
		public IEnumerable<PropertyOptionSetItem> LkDynamicPropertyOptionSetItemCreatedonbehalfby
		{
			get { return GetRelatedEntities<PropertyOptionSetItem>("lk_DynamicPropertyOptionSetItem_createdonbehalfby", null); }
			set { SetRelatedEntities("lk_DynamicPropertyOptionSetItem_createdonbehalfby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_DynamicPropertyOptionSetItem_modifiedby'
        /// </summary>
		[RelationshipSchemaName("lk_DynamicPropertyOptionSetItem_modifiedby")]
		public IEnumerable<PropertyOptionSetItem> LkDynamicPropertyOptionSetItemModifiedby
		{
			get { return GetRelatedEntities<PropertyOptionSetItem>("lk_DynamicPropertyOptionSetItem_modifiedby", null); }
			set { SetRelatedEntities("lk_DynamicPropertyOptionSetItem_modifiedby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_DynamicPropertyOptionSetItem_modifiedonbehalfby'
        /// </summary>
		[RelationshipSchemaName("lk_DynamicPropertyOptionSetItem_modifiedonbehalfby")]
		public IEnumerable<PropertyOptionSetItem> LkDynamicPropertyOptionSetItemModifiedonbehalfby
		{
			get { return GetRelatedEntities<PropertyOptionSetItem>("lk_DynamicPropertyOptionSetItem_modifiedonbehalfby", null); }
			set { SetRelatedEntities("lk_DynamicPropertyOptionSetItem_modifiedonbehalfby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_email_createdby'
        /// </summary>
		[RelationshipSchemaName("lk_email_createdby")]
		public IEnumerable<Email> LkEmailCreatedby
		{
			get { return GetRelatedEntities<Email>("lk_email_createdby", null); }
			set { SetRelatedEntities("lk_email_createdby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_email_createdonbehalfby'
        /// </summary>
		[RelationshipSchemaName("lk_email_createdonbehalfby")]
		public IEnumerable<Email> LkEmailCreatedonbehalfby
		{
			get { return GetRelatedEntities<Email>("lk_email_createdonbehalfby", null); }
			set { SetRelatedEntities("lk_email_createdonbehalfby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_email_modifiedby'
        /// </summary>
		[RelationshipSchemaName("lk_email_modifiedby")]
		public IEnumerable<Email> LkEmailModifiedby
		{
			get { return GetRelatedEntities<Email>("lk_email_modifiedby", null); }
			set { SetRelatedEntities("lk_email_modifiedby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_email_modifiedonbehalfby'
        /// </summary>
		[RelationshipSchemaName("lk_email_modifiedonbehalfby")]
		public IEnumerable<Email> LkEmailModifiedonbehalfby
		{
			get { return GetRelatedEntities<Email>("lk_email_modifiedonbehalfby", null); }
			set { SetRelatedEntities("lk_email_modifiedonbehalfby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_emailserverprofile_createdby'
        /// </summary>
		[RelationshipSchemaName("lk_emailserverprofile_createdby")]
		public IEnumerable<EmailServerProfile> LkEmailserverprofileCreatedby
		{
			get { return GetRelatedEntities<EmailServerProfile>("lk_emailserverprofile_createdby", null); }
			set { SetRelatedEntities("lk_emailserverprofile_createdby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_emailserverprofile_createdonbehalfby'
        /// </summary>
		[RelationshipSchemaName("lk_emailserverprofile_createdonbehalfby")]
		public IEnumerable<EmailServerProfile> LkEmailserverprofileCreatedonbehalfby
		{
			get { return GetRelatedEntities<EmailServerProfile>("lk_emailserverprofile_createdonbehalfby", null); }
			set { SetRelatedEntities("lk_emailserverprofile_createdonbehalfby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_emailserverprofile_modifiedby'
        /// </summary>
		[RelationshipSchemaName("lk_emailserverprofile_modifiedby")]
		public IEnumerable<EmailServerProfile> LkEmailserverprofileModifiedby
		{
			get { return GetRelatedEntities<EmailServerProfile>("lk_emailserverprofile_modifiedby", null); }
			set { SetRelatedEntities("lk_emailserverprofile_modifiedby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_emailserverprofile_modifiedonbehalfby'
        /// </summary>
		[RelationshipSchemaName("lk_emailserverprofile_modifiedonbehalfby")]
		public IEnumerable<EmailServerProfile> LkEmailserverprofileModifiedonbehalfby
		{
			get { return GetRelatedEntities<EmailServerProfile>("lk_emailserverprofile_modifiedonbehalfby", null); }
			set { SetRelatedEntities("lk_emailserverprofile_modifiedonbehalfby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_entitlement_createdby'
        /// </summary>
		[RelationshipSchemaName("lk_entitlement_createdby")]
		public IEnumerable<Entitlement> LkEntitlementCreatedby
		{
			get { return GetRelatedEntities<Entitlement>("lk_entitlement_createdby", null); }
			set { SetRelatedEntities("lk_entitlement_createdby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_entitlement_createdonbehalfby'
        /// </summary>
		[RelationshipSchemaName("lk_entitlement_createdonbehalfby")]
		public IEnumerable<Entitlement> LkEntitlementCreatedonbehalfby
		{
			get { return GetRelatedEntities<Entitlement>("lk_entitlement_createdonbehalfby", null); }
			set { SetRelatedEntities("lk_entitlement_createdonbehalfby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_entitlement_modifiedby'
        /// </summary>
		[RelationshipSchemaName("lk_entitlement_modifiedby")]
		public IEnumerable<Entitlement> LkEntitlementModifiedby
		{
			get { return GetRelatedEntities<Entitlement>("lk_entitlement_modifiedby", null); }
			set { SetRelatedEntities("lk_entitlement_modifiedby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_entitlement_modifiedonbehalfby'
        /// </summary>
		[RelationshipSchemaName("lk_entitlement_modifiedonbehalfby")]
		public IEnumerable<Entitlement> LkEntitlementModifiedonbehalfby
		{
			get { return GetRelatedEntities<Entitlement>("lk_entitlement_modifiedonbehalfby", null); }
			set { SetRelatedEntities("lk_entitlement_modifiedonbehalfby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_entitlementchannel_createdby'
        /// </summary>
		[RelationshipSchemaName("lk_entitlementchannel_createdby")]
		public IEnumerable<EntitlementChannel> LkEntitlementchannelCreatedby
		{
			get { return GetRelatedEntities<EntitlementChannel>("lk_entitlementchannel_createdby", null); }
			set { SetRelatedEntities("lk_entitlementchannel_createdby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_entitlementchannel_createdonbehalfby'
        /// </summary>
		[RelationshipSchemaName("lk_entitlementchannel_createdonbehalfby")]
		public IEnumerable<EntitlementChannel> LkEntitlementchannelCreatedonbehalfby
		{
			get { return GetRelatedEntities<EntitlementChannel>("lk_entitlementchannel_createdonbehalfby", null); }
			set { SetRelatedEntities("lk_entitlementchannel_createdonbehalfby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_entitlementchannel_modifiedby'
        /// </summary>
		[RelationshipSchemaName("lk_entitlementchannel_modifiedby")]
		public IEnumerable<EntitlementChannel> LkEntitlementchannelModifiedby
		{
			get { return GetRelatedEntities<EntitlementChannel>("lk_entitlementchannel_modifiedby", null); }
			set { SetRelatedEntities("lk_entitlementchannel_modifiedby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_entitlementchannel_modifiedonbehalfby'
        /// </summary>
		[RelationshipSchemaName("lk_entitlementchannel_modifiedonbehalfby")]
		public IEnumerable<EntitlementChannel> LkEntitlementchannelModifiedonbehalfby
		{
			get { return GetRelatedEntities<EntitlementChannel>("lk_entitlementchannel_modifiedonbehalfby", null); }
			set { SetRelatedEntities("lk_entitlementchannel_modifiedonbehalfby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_entitlemententityallocationtypemapping_createdby'
        /// </summary>
		[RelationshipSchemaName("lk_entitlemententityallocationtypemapping_createdby")]
		public IEnumerable<EntitlementEntityAllocationTypeMapping> LkEntitlemententityallocationtypemappingCreatedby
		{
			get { return GetRelatedEntities<EntitlementEntityAllocationTypeMapping>("lk_entitlemententityallocationtypemapping_createdby", null); }
			set { SetRelatedEntities("lk_entitlemententityallocationtypemapping_createdby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_entitlemententityallocationtypemapping_createdonbehalfby'
        /// </summary>
		[RelationshipSchemaName("lk_entitlemententityallocationtypemapping_createdonbehalfby")]
		public IEnumerable<EntitlementEntityAllocationTypeMapping> LkEntitlemententityallocationtypemappingCreatedonbehalfby
		{
			get { return GetRelatedEntities<EntitlementEntityAllocationTypeMapping>("lk_entitlemententityallocationtypemapping_createdonbehalfby", null); }
			set { SetRelatedEntities("lk_entitlemententityallocationtypemapping_createdonbehalfby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_entitlemententityallocationtypemapping_modifiedby'
        /// </summary>
		[RelationshipSchemaName("lk_entitlemententityallocationtypemapping_modifiedby")]
		public IEnumerable<EntitlementEntityAllocationTypeMapping> LkEntitlemententityallocationtypemappingModifiedby
		{
			get { return GetRelatedEntities<EntitlementEntityAllocationTypeMapping>("lk_entitlemententityallocationtypemapping_modifiedby", null); }
			set { SetRelatedEntities("lk_entitlemententityallocationtypemapping_modifiedby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_entitlemententityallocationtypemapping_modifiedonbehalfby'
        /// </summary>
		[RelationshipSchemaName("lk_entitlemententityallocationtypemapping_modifiedonbehalfby")]
		public IEnumerable<EntitlementEntityAllocationTypeMapping> LkEntitlemententityallocationtypemappingModifiedonbehalfby
		{
			get { return GetRelatedEntities<EntitlementEntityAllocationTypeMapping>("lk_entitlemententityallocationtypemapping_modifiedonbehalfby", null); }
			set { SetRelatedEntities("lk_entitlemententityallocationtypemapping_modifiedonbehalfby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_entitlementtemplate_createdby'
        /// </summary>
		[RelationshipSchemaName("lk_entitlementtemplate_createdby")]
		public IEnumerable<EntitlementTemplate> LkEntitlementtemplateCreatedby
		{
			get { return GetRelatedEntities<EntitlementTemplate>("lk_entitlementtemplate_createdby", null); }
			set { SetRelatedEntities("lk_entitlementtemplate_createdby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_entitlementtemplate_createdonbehalfby'
        /// </summary>
		[RelationshipSchemaName("lk_entitlementtemplate_createdonbehalfby")]
		public IEnumerable<EntitlementTemplate> LkEntitlementtemplateCreatedonbehalfby
		{
			get { return GetRelatedEntities<EntitlementTemplate>("lk_entitlementtemplate_createdonbehalfby", null); }
			set { SetRelatedEntities("lk_entitlementtemplate_createdonbehalfby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_entitlementtemplate_modifiedby'
        /// </summary>
		[RelationshipSchemaName("lk_entitlementtemplate_modifiedby")]
		public IEnumerable<EntitlementTemplate> LkEntitlementtemplateModifiedby
		{
			get { return GetRelatedEntities<EntitlementTemplate>("lk_entitlementtemplate_modifiedby", null); }
			set { SetRelatedEntities("lk_entitlementtemplate_modifiedby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_entitlementtemplate_modifiedonbehalfby'
        /// </summary>
		[RelationshipSchemaName("lk_entitlementtemplate_modifiedonbehalfby")]
		public IEnumerable<EntitlementTemplate> LkEntitlementtemplateModifiedonbehalfby
		{
			get { return GetRelatedEntities<EntitlementTemplate>("lk_entitlementtemplate_modifiedonbehalfby", null); }
			set { SetRelatedEntities("lk_entitlementtemplate_modifiedonbehalfby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_entitlementtemplatechannel_createdby'
        /// </summary>
		[RelationshipSchemaName("lk_entitlementtemplatechannel_createdby")]
		public IEnumerable<EntitlementTemplateChannel> LkEntitlementtemplatechannelCreatedby
		{
			get { return GetRelatedEntities<EntitlementTemplateChannel>("lk_entitlementtemplatechannel_createdby", null); }
			set { SetRelatedEntities("lk_entitlementtemplatechannel_createdby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_entitlementtemplatechannel_createdonbehalfby'
        /// </summary>
		[RelationshipSchemaName("lk_entitlementtemplatechannel_createdonbehalfby")]
		public IEnumerable<EntitlementTemplateChannel> LkEntitlementtemplatechannelCreatedonbehalfby
		{
			get { return GetRelatedEntities<EntitlementTemplateChannel>("lk_entitlementtemplatechannel_createdonbehalfby", null); }
			set { SetRelatedEntities("lk_entitlementtemplatechannel_createdonbehalfby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_entitlementtemplatechannel_modifiedby'
        /// </summary>
		[RelationshipSchemaName("lk_entitlementtemplatechannel_modifiedby")]
		public IEnumerable<EntitlementTemplateChannel> LkEntitlementtemplatechannelModifiedby
		{
			get { return GetRelatedEntities<EntitlementTemplateChannel>("lk_entitlementtemplatechannel_modifiedby", null); }
			set { SetRelatedEntities("lk_entitlementtemplatechannel_modifiedby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_entitlementtemplatechannel_modifiedonbehalfby'
        /// </summary>
		[RelationshipSchemaName("lk_entitlementtemplatechannel_modifiedonbehalfby")]
		public IEnumerable<EntitlementTemplateChannel> LkEntitlementtemplatechannelModifiedonbehalfby
		{
			get { return GetRelatedEntities<EntitlementTemplateChannel>("lk_entitlementtemplatechannel_modifiedonbehalfby", null); }
			set { SetRelatedEntities("lk_entitlementtemplatechannel_modifiedonbehalfby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_environmentvariabledefinition_createdby'
        /// </summary>
		[RelationshipSchemaName("lk_environmentvariabledefinition_createdby")]
		public IEnumerable<EnvironmentVariableDefinition> LkEnvironmentvariabledefinitionCreatedby
		{
			get { return GetRelatedEntities<EnvironmentVariableDefinition>("lk_environmentvariabledefinition_createdby", null); }
			set { SetRelatedEntities("lk_environmentvariabledefinition_createdby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_environmentvariabledefinition_createdonbehalfby'
        /// </summary>
		[RelationshipSchemaName("lk_environmentvariabledefinition_createdonbehalfby")]
		public IEnumerable<EnvironmentVariableDefinition> LkEnvironmentvariabledefinitionCreatedonbehalfby
		{
			get { return GetRelatedEntities<EnvironmentVariableDefinition>("lk_environmentvariabledefinition_createdonbehalfby", null); }
			set { SetRelatedEntities("lk_environmentvariabledefinition_createdonbehalfby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_environmentvariabledefinition_modifiedby'
        /// </summary>
		[RelationshipSchemaName("lk_environmentvariabledefinition_modifiedby")]
		public IEnumerable<EnvironmentVariableDefinition> LkEnvironmentvariabledefinitionModifiedby
		{
			get { return GetRelatedEntities<EnvironmentVariableDefinition>("lk_environmentvariabledefinition_modifiedby", null); }
			set { SetRelatedEntities("lk_environmentvariabledefinition_modifiedby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_environmentvariabledefinition_modifiedonbehalfby'
        /// </summary>
		[RelationshipSchemaName("lk_environmentvariabledefinition_modifiedonbehalfby")]
		public IEnumerable<EnvironmentVariableDefinition> LkEnvironmentvariabledefinitionModifiedonbehalfby
		{
			get { return GetRelatedEntities<EnvironmentVariableDefinition>("lk_environmentvariabledefinition_modifiedonbehalfby", null); }
			set { SetRelatedEntities("lk_environmentvariabledefinition_modifiedonbehalfby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_environmentvariablevalue_createdby'
        /// </summary>
		[RelationshipSchemaName("lk_environmentvariablevalue_createdby")]
		public IEnumerable<EnvironmentVariableValue> LkEnvironmentvariablevalueCreatedby
		{
			get { return GetRelatedEntities<EnvironmentVariableValue>("lk_environmentvariablevalue_createdby", null); }
			set { SetRelatedEntities("lk_environmentvariablevalue_createdby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_environmentvariablevalue_createdonbehalfby'
        /// </summary>
		[RelationshipSchemaName("lk_environmentvariablevalue_createdonbehalfby")]
		public IEnumerable<EnvironmentVariableValue> LkEnvironmentvariablevalueCreatedonbehalfby
		{
			get { return GetRelatedEntities<EnvironmentVariableValue>("lk_environmentvariablevalue_createdonbehalfby", null); }
			set { SetRelatedEntities("lk_environmentvariablevalue_createdonbehalfby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_environmentvariablevalue_modifiedby'
        /// </summary>
		[RelationshipSchemaName("lk_environmentvariablevalue_modifiedby")]
		public IEnumerable<EnvironmentVariableValue> LkEnvironmentvariablevalueModifiedby
		{
			get { return GetRelatedEntities<EnvironmentVariableValue>("lk_environmentvariablevalue_modifiedby", null); }
			set { SetRelatedEntities("lk_environmentvariablevalue_modifiedby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_environmentvariablevalue_modifiedonbehalfby'
        /// </summary>
		[RelationshipSchemaName("lk_environmentvariablevalue_modifiedonbehalfby")]
		public IEnumerable<EnvironmentVariableValue> LkEnvironmentvariablevalueModifiedonbehalfby
		{
			get { return GetRelatedEntities<EnvironmentVariableValue>("lk_environmentvariablevalue_modifiedonbehalfby", null); }
			set { SetRelatedEntities("lk_environmentvariablevalue_modifiedonbehalfby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_equipment_createdby'
        /// </summary>
		[RelationshipSchemaName("lk_equipment_createdby")]
		public IEnumerable<FacilityEquipment> LkEquipmentCreatedby
		{
			get { return GetRelatedEntities<FacilityEquipment>("lk_equipment_createdby", null); }
			set { SetRelatedEntities("lk_equipment_createdby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_equipment_createdonbehalfby'
        /// </summary>
		[RelationshipSchemaName("lk_equipment_createdonbehalfby")]
		public IEnumerable<FacilityEquipment> LkEquipmentCreatedonbehalfby
		{
			get { return GetRelatedEntities<FacilityEquipment>("lk_equipment_createdonbehalfby", null); }
			set { SetRelatedEntities("lk_equipment_createdonbehalfby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_equipment_modifiedby'
        /// </summary>
		[RelationshipSchemaName("lk_equipment_modifiedby")]
		public IEnumerable<FacilityEquipment> LkEquipmentModifiedby
		{
			get { return GetRelatedEntities<FacilityEquipment>("lk_equipment_modifiedby", null); }
			set { SetRelatedEntities("lk_equipment_modifiedby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_equipment_modifiedonbehalfby'
        /// </summary>
		[RelationshipSchemaName("lk_equipment_modifiedonbehalfby")]
		public IEnumerable<FacilityEquipment> LkEquipmentModifiedonbehalfby
		{
			get { return GetRelatedEntities<FacilityEquipment>("lk_equipment_modifiedonbehalfby", null); }
			set { SetRelatedEntities("lk_equipment_modifiedonbehalfby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_expiredprocess_createdby'
        /// </summary>
		[RelationshipSchemaName("lk_expiredprocess_createdby")]
		public IEnumerable<ExpiredProcess> LkExpiredprocessCreatedby
		{
			get { return GetRelatedEntities<ExpiredProcess>("lk_expiredprocess_createdby", null); }
			set { SetRelatedEntities("lk_expiredprocess_createdby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_expiredprocess_createdonbehalfby'
        /// </summary>
		[RelationshipSchemaName("lk_expiredprocess_createdonbehalfby")]
		public IEnumerable<ExpiredProcess> LkExpiredprocessCreatedonbehalfby
		{
			get { return GetRelatedEntities<ExpiredProcess>("lk_expiredprocess_createdonbehalfby", null); }
			set { SetRelatedEntities("lk_expiredprocess_createdonbehalfby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_expiredprocess_modifiedby'
        /// </summary>
		[RelationshipSchemaName("lk_expiredprocess_modifiedby")]
		public IEnumerable<ExpiredProcess> LkExpiredprocessModifiedby
		{
			get { return GetRelatedEntities<ExpiredProcess>("lk_expiredprocess_modifiedby", null); }
			set { SetRelatedEntities("lk_expiredprocess_modifiedby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_expiredprocess_modifiedonbehalfby'
        /// </summary>
		[RelationshipSchemaName("lk_expiredprocess_modifiedonbehalfby")]
		public IEnumerable<ExpiredProcess> LkExpiredprocessModifiedonbehalfby
		{
			get { return GetRelatedEntities<ExpiredProcess>("lk_expiredprocess_modifiedonbehalfby", null); }
			set { SetRelatedEntities("lk_expiredprocess_modifiedonbehalfby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_exportsolutionupload_createdby'
        /// </summary>
		[RelationshipSchemaName("lk_exportsolutionupload_createdby")]
		public IEnumerable<ExportSolutionUpload> LkExportsolutionuploadCreatedby
		{
			get { return GetRelatedEntities<ExportSolutionUpload>("lk_exportsolutionupload_createdby", null); }
			set { SetRelatedEntities("lk_exportsolutionupload_createdby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_exportsolutionupload_createdonbehalfby'
        /// </summary>
		[RelationshipSchemaName("lk_exportsolutionupload_createdonbehalfby")]
		public IEnumerable<ExportSolutionUpload> LkExportsolutionuploadCreatedonbehalfby
		{
			get { return GetRelatedEntities<ExportSolutionUpload>("lk_exportsolutionupload_createdonbehalfby", null); }
			set { SetRelatedEntities("lk_exportsolutionupload_createdonbehalfby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_exportsolutionupload_modifiedby'
        /// </summary>
		[RelationshipSchemaName("lk_exportsolutionupload_modifiedby")]
		public IEnumerable<ExportSolutionUpload> LkExportsolutionuploadModifiedby
		{
			get { return GetRelatedEntities<ExportSolutionUpload>("lk_exportsolutionupload_modifiedby", null); }
			set { SetRelatedEntities("lk_exportsolutionupload_modifiedby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_exportsolutionupload_modifiedonbehalfby'
        /// </summary>
		[RelationshipSchemaName("lk_exportsolutionupload_modifiedonbehalfby")]
		public IEnumerable<ExportSolutionUpload> LkExportsolutionuploadModifiedonbehalfby
		{
			get { return GetRelatedEntities<ExportSolutionUpload>("lk_exportsolutionupload_modifiedonbehalfby", null); }
			set { SetRelatedEntities("lk_exportsolutionupload_modifiedonbehalfby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_fax_createdby'
        /// </summary>
		[RelationshipSchemaName("lk_fax_createdby")]
		public IEnumerable<Fax> LkFaxCreatedby
		{
			get { return GetRelatedEntities<Fax>("lk_fax_createdby", null); }
			set { SetRelatedEntities("lk_fax_createdby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_fax_createdonbehalfby'
        /// </summary>
		[RelationshipSchemaName("lk_fax_createdonbehalfby")]
		public IEnumerable<Fax> LkFaxCreatedonbehalfby
		{
			get { return GetRelatedEntities<Fax>("lk_fax_createdonbehalfby", null); }
			set { SetRelatedEntities("lk_fax_createdonbehalfby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_fax_modifiedby'
        /// </summary>
		[RelationshipSchemaName("lk_fax_modifiedby")]
		public IEnumerable<Fax> LkFaxModifiedby
		{
			get { return GetRelatedEntities<Fax>("lk_fax_modifiedby", null); }
			set { SetRelatedEntities("lk_fax_modifiedby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_fax_modifiedonbehalfby'
        /// </summary>
		[RelationshipSchemaName("lk_fax_modifiedonbehalfby")]
		public IEnumerable<Fax> LkFaxModifiedonbehalfby
		{
			get { return GetRelatedEntities<Fax>("lk_fax_modifiedonbehalfby", null); }
			set { SetRelatedEntities("lk_fax_modifiedonbehalfby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_feedback_closedby'
        /// </summary>
		[RelationshipSchemaName("lk_feedback_closedby")]
		public IEnumerable<Feedback> LkFeedbackClosedby
		{
			get { return GetRelatedEntities<Feedback>("lk_feedback_closedby", null); }
			set { SetRelatedEntities("lk_feedback_closedby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_feedback_createdby'
        /// </summary>
		[RelationshipSchemaName("lk_feedback_createdby")]
		public IEnumerable<Feedback> LkFeedbackCreatedby
		{
			get { return GetRelatedEntities<Feedback>("lk_feedback_createdby", null); }
			set { SetRelatedEntities("lk_feedback_createdby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_feedback_createdonbehalfby'
        /// </summary>
		[RelationshipSchemaName("lk_feedback_createdonbehalfby")]
		public IEnumerable<Feedback> LkFeedbackCreatedonbehalfby
		{
			get { return GetRelatedEntities<Feedback>("lk_feedback_createdonbehalfby", null); }
			set { SetRelatedEntities("lk_feedback_createdonbehalfby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_feedback_modifiedby'
        /// </summary>
		[RelationshipSchemaName("lk_feedback_modifiedby")]
		public IEnumerable<Feedback> LkFeedbackModifiedby
		{
			get { return GetRelatedEntities<Feedback>("lk_feedback_modifiedby", null); }
			set { SetRelatedEntities("lk_feedback_modifiedby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_feedback_modifiedonbehalfby'
        /// </summary>
		[RelationshipSchemaName("lk_feedback_modifiedonbehalfby")]
		public IEnumerable<Feedback> LkFeedbackModifiedonbehalfby
		{
			get { return GetRelatedEntities<Feedback>("lk_feedback_modifiedonbehalfby", null); }
			set { SetRelatedEntities("lk_feedback_modifiedonbehalfby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_fieldsecurityprofile_createdby'
        /// </summary>
		[RelationshipSchemaName("lk_fieldsecurityprofile_createdby")]
		public IEnumerable<FieldSecurityProfile> LkFieldsecurityprofileCreatedby
		{
			get { return GetRelatedEntities<FieldSecurityProfile>("lk_fieldsecurityprofile_createdby", null); }
			set { SetRelatedEntities("lk_fieldsecurityprofile_createdby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_fieldsecurityprofile_createdonbehalfby'
        /// </summary>
		[RelationshipSchemaName("lk_fieldsecurityprofile_createdonbehalfby")]
		public IEnumerable<FieldSecurityProfile> LkFieldsecurityprofileCreatedonbehalfby
		{
			get { return GetRelatedEntities<FieldSecurityProfile>("lk_fieldsecurityprofile_createdonbehalfby", null); }
			set { SetRelatedEntities("lk_fieldsecurityprofile_createdonbehalfby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_fieldsecurityprofile_modifiedby'
        /// </summary>
		[RelationshipSchemaName("lk_fieldsecurityprofile_modifiedby")]
		public IEnumerable<FieldSecurityProfile> LkFieldsecurityprofileModifiedby
		{
			get { return GetRelatedEntities<FieldSecurityProfile>("lk_fieldsecurityprofile_modifiedby", null); }
			set { SetRelatedEntities("lk_fieldsecurityprofile_modifiedby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_fieldsecurityprofile_modifiedonbehalfby'
        /// </summary>
		[RelationshipSchemaName("lk_fieldsecurityprofile_modifiedonbehalfby")]
		public IEnumerable<FieldSecurityProfile> LkFieldsecurityprofileModifiedonbehalfby
		{
			get { return GetRelatedEntities<FieldSecurityProfile>("lk_fieldsecurityprofile_modifiedonbehalfby", null); }
			set { SetRelatedEntities("lk_fieldsecurityprofile_modifiedonbehalfby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_fixedmonthlyfiscalcalendar_createdby'
        /// </summary>
		[RelationshipSchemaName("lk_fixedmonthlyfiscalcalendar_createdby")]
		public IEnumerable<FixedMonthlyFiscalCalendar> LkFixedmonthlyfiscalcalendarCreatedby
		{
			get { return GetRelatedEntities<FixedMonthlyFiscalCalendar>("lk_fixedmonthlyfiscalcalendar_createdby", null); }
			set { SetRelatedEntities("lk_fixedmonthlyfiscalcalendar_createdby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_fixedmonthlyfiscalcalendar_createdonbehalfby'
        /// </summary>
		[RelationshipSchemaName("lk_fixedmonthlyfiscalcalendar_createdonbehalfby")]
		public IEnumerable<FixedMonthlyFiscalCalendar> LkFixedmonthlyfiscalcalendarCreatedonbehalfby
		{
			get { return GetRelatedEntities<FixedMonthlyFiscalCalendar>("lk_fixedmonthlyfiscalcalendar_createdonbehalfby", null); }
			set { SetRelatedEntities("lk_fixedmonthlyfiscalcalendar_createdonbehalfby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_fixedmonthlyfiscalcalendar_modifiedby'
        /// </summary>
		[RelationshipSchemaName("lk_fixedmonthlyfiscalcalendar_modifiedby")]
		public IEnumerable<FixedMonthlyFiscalCalendar> LkFixedmonthlyfiscalcalendarModifiedby
		{
			get { return GetRelatedEntities<FixedMonthlyFiscalCalendar>("lk_fixedmonthlyfiscalcalendar_modifiedby", null); }
			set { SetRelatedEntities("lk_fixedmonthlyfiscalcalendar_modifiedby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_fixedmonthlyfiscalcalendar_modifiedonbehalfby'
        /// </summary>
		[RelationshipSchemaName("lk_fixedmonthlyfiscalcalendar_modifiedonbehalfby")]
		public IEnumerable<FixedMonthlyFiscalCalendar> LkFixedmonthlyfiscalcalendarModifiedonbehalfby
		{
			get { return GetRelatedEntities<FixedMonthlyFiscalCalendar>("lk_fixedmonthlyfiscalcalendar_modifiedonbehalfby", null); }
			set { SetRelatedEntities("lk_fixedmonthlyfiscalcalendar_modifiedonbehalfby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_fixedmonthlyfiscalcalendar_salespersonid'
        /// </summary>
		[RelationshipSchemaName("lk_fixedmonthlyfiscalcalendar_salespersonid")]
		public IEnumerable<FixedMonthlyFiscalCalendar> LkFixedmonthlyfiscalcalendarSalespersonid
		{
			get { return GetRelatedEntities<FixedMonthlyFiscalCalendar>("lk_fixedmonthlyfiscalcalendar_salespersonid", null); }
			set { SetRelatedEntities("lk_fixedmonthlyfiscalcalendar_salespersonid", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_flowsession_createdby'
        /// </summary>
		[RelationshipSchemaName("lk_flowsession_createdby")]
		public IEnumerable<FlowSession> LkFlowsessionCreatedby
		{
			get { return GetRelatedEntities<FlowSession>("lk_flowsession_createdby", null); }
			set { SetRelatedEntities("lk_flowsession_createdby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_flowsession_createdonbehalfby'
        /// </summary>
		[RelationshipSchemaName("lk_flowsession_createdonbehalfby")]
		public IEnumerable<FlowSession> LkFlowsessionCreatedonbehalfby
		{
			get { return GetRelatedEntities<FlowSession>("lk_flowsession_createdonbehalfby", null); }
			set { SetRelatedEntities("lk_flowsession_createdonbehalfby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_flowsession_modifiedby'
        /// </summary>
		[RelationshipSchemaName("lk_flowsession_modifiedby")]
		public IEnumerable<FlowSession> LkFlowsessionModifiedby
		{
			get { return GetRelatedEntities<FlowSession>("lk_flowsession_modifiedby", null); }
			set { SetRelatedEntities("lk_flowsession_modifiedby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_flowsession_modifiedonbehalfby'
        /// </summary>
		[RelationshipSchemaName("lk_flowsession_modifiedonbehalfby")]
		public IEnumerable<FlowSession> LkFlowsessionModifiedonbehalfby
		{
			get { return GetRelatedEntities<FlowSession>("lk_flowsession_modifiedonbehalfby", null); }
			set { SetRelatedEntities("lk_flowsession_modifiedonbehalfby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_goal_createdby'
        /// </summary>
		[RelationshipSchemaName("lk_goal_createdby")]
		public IEnumerable<Goal> LkGoalCreatedby
		{
			get { return GetRelatedEntities<Goal>("lk_goal_createdby", null); }
			set { SetRelatedEntities("lk_goal_createdby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_goal_createdonbehalfby'
        /// </summary>
		[RelationshipSchemaName("lk_goal_createdonbehalfby")]
		public IEnumerable<Goal> LkGoalCreatedonbehalfby
		{
			get { return GetRelatedEntities<Goal>("lk_goal_createdonbehalfby", null); }
			set { SetRelatedEntities("lk_goal_createdonbehalfby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_goal_modifiedby'
        /// </summary>
		[RelationshipSchemaName("lk_goal_modifiedby")]
		public IEnumerable<Goal> LkGoalModifiedby
		{
			get { return GetRelatedEntities<Goal>("lk_goal_modifiedby", null); }
			set { SetRelatedEntities("lk_goal_modifiedby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_goal_modifiedonbehalfby'
        /// </summary>
		[RelationshipSchemaName("lk_goal_modifiedonbehalfby")]
		public IEnumerable<Goal> LkGoalModifiedonbehalfby
		{
			get { return GetRelatedEntities<Goal>("lk_goal_modifiedonbehalfby", null); }
			set { SetRelatedEntities("lk_goal_modifiedonbehalfby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_goalrollupquery_createdby'
        /// </summary>
		[RelationshipSchemaName("lk_goalrollupquery_createdby")]
		public IEnumerable<RollupQuery> LkGoalrollupqueryCreatedby
		{
			get { return GetRelatedEntities<RollupQuery>("lk_goalrollupquery_createdby", null); }
			set { SetRelatedEntities("lk_goalrollupquery_createdby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_goalrollupquery_createdonbehalfby'
        /// </summary>
		[RelationshipSchemaName("lk_goalrollupquery_createdonbehalfby")]
		public IEnumerable<RollupQuery> LkGoalrollupqueryCreatedonbehalfby
		{
			get { return GetRelatedEntities<RollupQuery>("lk_goalrollupquery_createdonbehalfby", null); }
			set { SetRelatedEntities("lk_goalrollupquery_createdonbehalfby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_goalrollupquery_modifiedby'
        /// </summary>
		[RelationshipSchemaName("lk_goalrollupquery_modifiedby")]
		public IEnumerable<RollupQuery> LkGoalrollupqueryModifiedby
		{
			get { return GetRelatedEntities<RollupQuery>("lk_goalrollupquery_modifiedby", null); }
			set { SetRelatedEntities("lk_goalrollupquery_modifiedby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_goalrollupquery_modifiedonbehalfby'
        /// </summary>
		[RelationshipSchemaName("lk_goalrollupquery_modifiedonbehalfby")]
		public IEnumerable<RollupQuery> LkGoalrollupqueryModifiedonbehalfby
		{
			get { return GetRelatedEntities<RollupQuery>("lk_goalrollupquery_modifiedonbehalfby", null); }
			set { SetRelatedEntities("lk_goalrollupquery_modifiedonbehalfby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_import_createdonbehalfby'
        /// </summary>
		[RelationshipSchemaName("lk_import_createdonbehalfby")]
		public IEnumerable<DataImport> LkImportCreatedonbehalfby
		{
			get { return GetRelatedEntities<DataImport>("lk_import_createdonbehalfby", null); }
			set { SetRelatedEntities("lk_import_createdonbehalfby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_import_modifiedonbehalfby'
        /// </summary>
		[RelationshipSchemaName("lk_import_modifiedonbehalfby")]
		public IEnumerable<DataImport> LkImportModifiedonbehalfby
		{
			get { return GetRelatedEntities<DataImport>("lk_import_modifiedonbehalfby", null); }
			set { SetRelatedEntities("lk_import_modifiedonbehalfby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_importbase_createdby'
        /// </summary>
		[RelationshipSchemaName("lk_importbase_createdby")]
		public IEnumerable<DataImport> LkImportbaseCreatedby
		{
			get { return GetRelatedEntities<DataImport>("lk_importbase_createdby", null); }
			set { SetRelatedEntities("lk_importbase_createdby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_importbase_modifiedby'
        /// </summary>
		[RelationshipSchemaName("lk_importbase_modifiedby")]
		public IEnumerable<DataImport> LkImportbaseModifiedby
		{
			get { return GetRelatedEntities<DataImport>("lk_importbase_modifiedby", null); }
			set { SetRelatedEntities("lk_importbase_modifiedby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_importdata_createdonbehalfby'
        /// </summary>
		[RelationshipSchemaName("lk_importdata_createdonbehalfby")]
		public IEnumerable<ImportData> LkImportdataCreatedonbehalfby
		{
			get { return GetRelatedEntities<ImportData>("lk_importdata_createdonbehalfby", null); }
			set { SetRelatedEntities("lk_importdata_createdonbehalfby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_importdata_modifiedonbehalfby'
        /// </summary>
		[RelationshipSchemaName("lk_importdata_modifiedonbehalfby")]
		public IEnumerable<ImportData> LkImportdataModifiedonbehalfby
		{
			get { return GetRelatedEntities<ImportData>("lk_importdata_modifiedonbehalfby", null); }
			set { SetRelatedEntities("lk_importdata_modifiedonbehalfby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_importdatabase_createdby'
        /// </summary>
		[RelationshipSchemaName("lk_importdatabase_createdby")]
		public IEnumerable<ImportData> LkImportdatabaseCreatedby
		{
			get { return GetRelatedEntities<ImportData>("lk_importdatabase_createdby", null); }
			set { SetRelatedEntities("lk_importdatabase_createdby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_importdatabase_modifiedby'
        /// </summary>
		[RelationshipSchemaName("lk_importdatabase_modifiedby")]
		public IEnumerable<ImportData> LkImportdatabaseModifiedby
		{
			get { return GetRelatedEntities<ImportData>("lk_importdatabase_modifiedby", null); }
			set { SetRelatedEntities("lk_importdatabase_modifiedby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_importentitymapping_createdby'
        /// </summary>
		[RelationshipSchemaName("lk_importentitymapping_createdby")]
		public IEnumerable<ImportEntityMapping> LkImportentitymappingCreatedby
		{
			get { return GetRelatedEntities<ImportEntityMapping>("lk_importentitymapping_createdby", null); }
			set { SetRelatedEntities("lk_importentitymapping_createdby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_importentitymapping_createdonbehalfby'
        /// </summary>
		[RelationshipSchemaName("lk_importentitymapping_createdonbehalfby")]
		public IEnumerable<ImportEntityMapping> LkImportentitymappingCreatedonbehalfby
		{
			get { return GetRelatedEntities<ImportEntityMapping>("lk_importentitymapping_createdonbehalfby", null); }
			set { SetRelatedEntities("lk_importentitymapping_createdonbehalfby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_importentitymapping_modifiedby'
        /// </summary>
		[RelationshipSchemaName("lk_importentitymapping_modifiedby")]
		public IEnumerable<ImportEntityMapping> LkImportentitymappingModifiedby
		{
			get { return GetRelatedEntities<ImportEntityMapping>("lk_importentitymapping_modifiedby", null); }
			set { SetRelatedEntities("lk_importentitymapping_modifiedby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_importentitymapping_modifiedonbehalfby'
        /// </summary>
		[RelationshipSchemaName("lk_importentitymapping_modifiedonbehalfby")]
		public IEnumerable<ImportEntityMapping> LkImportentitymappingModifiedonbehalfby
		{
			get { return GetRelatedEntities<ImportEntityMapping>("lk_importentitymapping_modifiedonbehalfby", null); }
			set { SetRelatedEntities("lk_importentitymapping_modifiedonbehalfby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_importfilebase_createdby'
        /// </summary>
		[RelationshipSchemaName("lk_importfilebase_createdby")]
		public IEnumerable<ImportSourceFile> LkImportfilebaseCreatedby
		{
			get { return GetRelatedEntities<ImportSourceFile>("lk_importfilebase_createdby", null); }
			set { SetRelatedEntities("lk_importfilebase_createdby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_importfilebase_createdonbehalfby'
        /// </summary>
		[RelationshipSchemaName("lk_importfilebase_createdonbehalfby")]
		public IEnumerable<ImportSourceFile> LkImportfilebaseCreatedonbehalfby
		{
			get { return GetRelatedEntities<ImportSourceFile>("lk_importfilebase_createdonbehalfby", null); }
			set { SetRelatedEntities("lk_importfilebase_createdonbehalfby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_importfilebase_modifiedby'
        /// </summary>
		[RelationshipSchemaName("lk_importfilebase_modifiedby")]
		public IEnumerable<ImportSourceFile> LkImportfilebaseModifiedby
		{
			get { return GetRelatedEntities<ImportSourceFile>("lk_importfilebase_modifiedby", null); }
			set { SetRelatedEntities("lk_importfilebase_modifiedby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_importfilebase_modifiedonbehalfby'
        /// </summary>
		[RelationshipSchemaName("lk_importfilebase_modifiedonbehalfby")]
		public IEnumerable<ImportSourceFile> LkImportfilebaseModifiedonbehalfby
		{
			get { return GetRelatedEntities<ImportSourceFile>("lk_importfilebase_modifiedonbehalfby", null); }
			set { SetRelatedEntities("lk_importfilebase_modifiedonbehalfby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_importjobbase_createdby'
        /// </summary>
		[RelationshipSchemaName("lk_importjobbase_createdby")]
		public IEnumerable<ImportJob> LkImportjobbaseCreatedby
		{
			get { return GetRelatedEntities<ImportJob>("lk_importjobbase_createdby", null); }
			set { SetRelatedEntities("lk_importjobbase_createdby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_importjobbase_createdonbehalfby'
        /// </summary>
		[RelationshipSchemaName("lk_importjobbase_createdonbehalfby")]
		public IEnumerable<ImportJob> LkImportjobbaseCreatedonbehalfby
		{
			get { return GetRelatedEntities<ImportJob>("lk_importjobbase_createdonbehalfby", null); }
			set { SetRelatedEntities("lk_importjobbase_createdonbehalfby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_importjobbase_modifiedby'
        /// </summary>
		[RelationshipSchemaName("lk_importjobbase_modifiedby")]
		public IEnumerable<ImportJob> LkImportjobbaseModifiedby
		{
			get { return GetRelatedEntities<ImportJob>("lk_importjobbase_modifiedby", null); }
			set { SetRelatedEntities("lk_importjobbase_modifiedby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_importjobbase_modifiedonbehalfby'
        /// </summary>
		[RelationshipSchemaName("lk_importjobbase_modifiedonbehalfby")]
		public IEnumerable<ImportJob> LkImportjobbaseModifiedonbehalfby
		{
			get { return GetRelatedEntities<ImportJob>("lk_importjobbase_modifiedonbehalfby", null); }
			set { SetRelatedEntities("lk_importjobbase_modifiedonbehalfby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_importlog_createdonbehalfby'
        /// </summary>
		[RelationshipSchemaName("lk_importlog_createdonbehalfby")]
		public IEnumerable<ImportLog> LkImportlogCreatedonbehalfby
		{
			get { return GetRelatedEntities<ImportLog>("lk_importlog_createdonbehalfby", null); }
			set { SetRelatedEntities("lk_importlog_createdonbehalfby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_importlog_modifiedonbehalfby'
        /// </summary>
		[RelationshipSchemaName("lk_importlog_modifiedonbehalfby")]
		public IEnumerable<ImportLog> LkImportlogModifiedonbehalfby
		{
			get { return GetRelatedEntities<ImportLog>("lk_importlog_modifiedonbehalfby", null); }
			set { SetRelatedEntities("lk_importlog_modifiedonbehalfby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_importlogbase_createdby'
        /// </summary>
		[RelationshipSchemaName("lk_importlogbase_createdby")]
		public IEnumerable<ImportLog> LkImportlogbaseCreatedby
		{
			get { return GetRelatedEntities<ImportLog>("lk_importlogbase_createdby", null); }
			set { SetRelatedEntities("lk_importlogbase_createdby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_importlogbase_modifiedby'
        /// </summary>
		[RelationshipSchemaName("lk_importlogbase_modifiedby")]
		public IEnumerable<ImportLog> LkImportlogbaseModifiedby
		{
			get { return GetRelatedEntities<ImportLog>("lk_importlogbase_modifiedby", null); }
			set { SetRelatedEntities("lk_importlogbase_modifiedby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_importmap_createdonbehalfby'
        /// </summary>
		[RelationshipSchemaName("lk_importmap_createdonbehalfby")]
		public IEnumerable<DataMap> LkImportmapCreatedonbehalfby
		{
			get { return GetRelatedEntities<DataMap>("lk_importmap_createdonbehalfby", null); }
			set { SetRelatedEntities("lk_importmap_createdonbehalfby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_importmap_modifiedonbehalfby'
        /// </summary>
		[RelationshipSchemaName("lk_importmap_modifiedonbehalfby")]
		public IEnumerable<DataMap> LkImportmapModifiedonbehalfby
		{
			get { return GetRelatedEntities<DataMap>("lk_importmap_modifiedonbehalfby", null); }
			set { SetRelatedEntities("lk_importmap_modifiedonbehalfby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_importmapbase_createdby'
        /// </summary>
		[RelationshipSchemaName("lk_importmapbase_createdby")]
		public IEnumerable<DataMap> LkImportmapbaseCreatedby
		{
			get { return GetRelatedEntities<DataMap>("lk_importmapbase_createdby", null); }
			set { SetRelatedEntities("lk_importmapbase_createdby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_importmapbase_modifiedby'
        /// </summary>
		[RelationshipSchemaName("lk_importmapbase_modifiedby")]
		public IEnumerable<DataMap> LkImportmapbaseModifiedby
		{
			get { return GetRelatedEntities<DataMap>("lk_importmapbase_modifiedby", null); }
			set { SetRelatedEntities("lk_importmapbase_modifiedby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_incidentbase_createdby'
        /// </summary>
		[RelationshipSchemaName("lk_incidentbase_createdby")]
		public IEnumerable<Case> LkIncidentbaseCreatedby
		{
			get { return GetRelatedEntities<Case>("lk_incidentbase_createdby", null); }
			set { SetRelatedEntities("lk_incidentbase_createdby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_incidentbase_createdonbehalfby'
        /// </summary>
		[RelationshipSchemaName("lk_incidentbase_createdonbehalfby")]
		public IEnumerable<Case> LkIncidentbaseCreatedonbehalfby
		{
			get { return GetRelatedEntities<Case>("lk_incidentbase_createdonbehalfby", null); }
			set { SetRelatedEntities("lk_incidentbase_createdonbehalfby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_incidentbase_modifiedby'
        /// </summary>
		[RelationshipSchemaName("lk_incidentbase_modifiedby")]
		public IEnumerable<Case> LkIncidentbaseModifiedby
		{
			get { return GetRelatedEntities<Case>("lk_incidentbase_modifiedby", null); }
			set { SetRelatedEntities("lk_incidentbase_modifiedby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_incidentbase_modifiedonbehalfby'
        /// </summary>
		[RelationshipSchemaName("lk_incidentbase_modifiedonbehalfby")]
		public IEnumerable<Case> LkIncidentbaseModifiedonbehalfby
		{
			get { return GetRelatedEntities<Case>("lk_incidentbase_modifiedonbehalfby", null); }
			set { SetRelatedEntities("lk_incidentbase_modifiedonbehalfby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_incidentresolution_createdby'
        /// </summary>
		[RelationshipSchemaName("lk_incidentresolution_createdby")]
		public IEnumerable<CaseResolution> LkIncidentresolutionCreatedby
		{
			get { return GetRelatedEntities<CaseResolution>("lk_incidentresolution_createdby", null); }
			set { SetRelatedEntities("lk_incidentresolution_createdby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_incidentresolution_createdonbehalfby'
        /// </summary>
		[RelationshipSchemaName("lk_incidentresolution_createdonbehalfby")]
		public IEnumerable<CaseResolution> LkIncidentresolutionCreatedonbehalfby
		{
			get { return GetRelatedEntities<CaseResolution>("lk_incidentresolution_createdonbehalfby", null); }
			set { SetRelatedEntities("lk_incidentresolution_createdonbehalfby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_incidentresolution_modifiedby'
        /// </summary>
		[RelationshipSchemaName("lk_incidentresolution_modifiedby")]
		public IEnumerable<CaseResolution> LkIncidentresolutionModifiedby
		{
			get { return GetRelatedEntities<CaseResolution>("lk_incidentresolution_modifiedby", null); }
			set { SetRelatedEntities("lk_incidentresolution_modifiedby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_incidentresolution_modifiedonbehalfby'
        /// </summary>
		[RelationshipSchemaName("lk_incidentresolution_modifiedonbehalfby")]
		public IEnumerable<CaseResolution> LkIncidentresolutionModifiedonbehalfby
		{
			get { return GetRelatedEntities<CaseResolution>("lk_incidentresolution_modifiedonbehalfby", null); }
			set { SetRelatedEntities("lk_incidentresolution_modifiedonbehalfby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_interactionforemail_createdby'
        /// </summary>
		[RelationshipSchemaName("lk_interactionforemail_createdby")]
		public IEnumerable<InteractionForEmail> LkInteractionforemailCreatedby
		{
			get { return GetRelatedEntities<InteractionForEmail>("lk_interactionforemail_createdby", null); }
			set { SetRelatedEntities("lk_interactionforemail_createdby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_interactionforemail_createdonbehalfby'
        /// </summary>
		[RelationshipSchemaName("lk_interactionforemail_createdonbehalfby")]
		public IEnumerable<InteractionForEmail> LkInteractionforemailCreatedonbehalfby
		{
			get { return GetRelatedEntities<InteractionForEmail>("lk_interactionforemail_createdonbehalfby", null); }
			set { SetRelatedEntities("lk_interactionforemail_createdonbehalfby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_interactionforemail_modifiedby'
        /// </summary>
		[RelationshipSchemaName("lk_interactionforemail_modifiedby")]
		public IEnumerable<InteractionForEmail> LkInteractionforemailModifiedby
		{
			get { return GetRelatedEntities<InteractionForEmail>("lk_interactionforemail_modifiedby", null); }
			set { SetRelatedEntities("lk_interactionforemail_modifiedby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_interactionforemail_modifiedonbehalfby'
        /// </summary>
		[RelationshipSchemaName("lk_interactionforemail_modifiedonbehalfby")]
		public IEnumerable<InteractionForEmail> LkInteractionforemailModifiedonbehalfby
		{
			get { return GetRelatedEntities<InteractionForEmail>("lk_interactionforemail_modifiedonbehalfby", null); }
			set { SetRelatedEntities("lk_interactionforemail_modifiedonbehalfby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_invoice_createdonbehalfby'
        /// </summary>
		[RelationshipSchemaName("lk_invoice_createdonbehalfby")]
		public IEnumerable<Invoice> LkInvoiceCreatedonbehalfby
		{
			get { return GetRelatedEntities<Invoice>("lk_invoice_createdonbehalfby", null); }
			set { SetRelatedEntities("lk_invoice_createdonbehalfby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_invoice_modifiedonbehalfby'
        /// </summary>
		[RelationshipSchemaName("lk_invoice_modifiedonbehalfby")]
		public IEnumerable<Invoice> LkInvoiceModifiedonbehalfby
		{
			get { return GetRelatedEntities<Invoice>("lk_invoice_modifiedonbehalfby", null); }
			set { SetRelatedEntities("lk_invoice_modifiedonbehalfby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_invoicebase_createdby'
        /// </summary>
		[RelationshipSchemaName("lk_invoicebase_createdby")]
		public IEnumerable<Invoice> LkInvoicebaseCreatedby
		{
			get { return GetRelatedEntities<Invoice>("lk_invoicebase_createdby", null); }
			set { SetRelatedEntities("lk_invoicebase_createdby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_invoicebase_modifiedby'
        /// </summary>
		[RelationshipSchemaName("lk_invoicebase_modifiedby")]
		public IEnumerable<Invoice> LkInvoicebaseModifiedby
		{
			get { return GetRelatedEntities<Invoice>("lk_invoicebase_modifiedby", null); }
			set { SetRelatedEntities("lk_invoicebase_modifiedby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_invoicedetail_createdonbehalfby'
        /// </summary>
		[RelationshipSchemaName("lk_invoicedetail_createdonbehalfby")]
		public IEnumerable<InvoiceProduct> LkInvoicedetailCreatedonbehalfby
		{
			get { return GetRelatedEntities<InvoiceProduct>("lk_invoicedetail_createdonbehalfby", null); }
			set { SetRelatedEntities("lk_invoicedetail_createdonbehalfby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_invoicedetail_modifiedonbehalfby'
        /// </summary>
		[RelationshipSchemaName("lk_invoicedetail_modifiedonbehalfby")]
		public IEnumerable<InvoiceProduct> LkInvoicedetailModifiedonbehalfby
		{
			get { return GetRelatedEntities<InvoiceProduct>("lk_invoicedetail_modifiedonbehalfby", null); }
			set { SetRelatedEntities("lk_invoicedetail_modifiedonbehalfby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_invoicedetailbase_createdby'
        /// </summary>
		[RelationshipSchemaName("lk_invoicedetailbase_createdby")]
		public IEnumerable<InvoiceProduct> LkInvoicedetailbaseCreatedby
		{
			get { return GetRelatedEntities<InvoiceProduct>("lk_invoicedetailbase_createdby", null); }
			set { SetRelatedEntities("lk_invoicedetailbase_createdby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_invoicedetailbase_modifiedby'
        /// </summary>
		[RelationshipSchemaName("lk_invoicedetailbase_modifiedby")]
		public IEnumerable<InvoiceProduct> LkInvoicedetailbaseModifiedby
		{
			get { return GetRelatedEntities<InvoiceProduct>("lk_invoicedetailbase_modifiedby", null); }
			set { SetRelatedEntities("lk_invoicedetailbase_modifiedby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_kbarticle_createdonbehalfby'
        /// </summary>
		[RelationshipSchemaName("lk_kbarticle_createdonbehalfby")]
		public IEnumerable<Article> LkKbarticleCreatedonbehalfby
		{
			get { return GetRelatedEntities<Article>("lk_kbarticle_createdonbehalfby", null); }
			set { SetRelatedEntities("lk_kbarticle_createdonbehalfby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_kbarticle_modifiedonbehalfby'
        /// </summary>
		[RelationshipSchemaName("lk_kbarticle_modifiedonbehalfby")]
		public IEnumerable<Article> LkKbarticleModifiedonbehalfby
		{
			get { return GetRelatedEntities<Article>("lk_kbarticle_modifiedonbehalfby", null); }
			set { SetRelatedEntities("lk_kbarticle_modifiedonbehalfby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_kbarticlebase_createdby'
        /// </summary>
		[RelationshipSchemaName("lk_kbarticlebase_createdby")]
		public IEnumerable<Article> LkKbarticlebaseCreatedby
		{
			get { return GetRelatedEntities<Article>("lk_kbarticlebase_createdby", null); }
			set { SetRelatedEntities("lk_kbarticlebase_createdby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_kbarticlebase_modifiedby'
        /// </summary>
		[RelationshipSchemaName("lk_kbarticlebase_modifiedby")]
		public IEnumerable<Article> LkKbarticlebaseModifiedby
		{
			get { return GetRelatedEntities<Article>("lk_kbarticlebase_modifiedby", null); }
			set { SetRelatedEntities("lk_kbarticlebase_modifiedby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_kbarticlecomment_createdonbehalfby'
        /// </summary>
		[RelationshipSchemaName("lk_kbarticlecomment_createdonbehalfby")]
		public IEnumerable<ArticleComment> LkKbarticlecommentCreatedonbehalfby
		{
			get { return GetRelatedEntities<ArticleComment>("lk_kbarticlecomment_createdonbehalfby", null); }
			set { SetRelatedEntities("lk_kbarticlecomment_createdonbehalfby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_kbarticlecomment_modifiedonbehalfby'
        /// </summary>
		[RelationshipSchemaName("lk_kbarticlecomment_modifiedonbehalfby")]
		public IEnumerable<ArticleComment> LkKbarticlecommentModifiedonbehalfby
		{
			get { return GetRelatedEntities<ArticleComment>("lk_kbarticlecomment_modifiedonbehalfby", null); }
			set { SetRelatedEntities("lk_kbarticlecomment_modifiedonbehalfby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_kbarticlecommentbase_createdby'
        /// </summary>
		[RelationshipSchemaName("lk_kbarticlecommentbase_createdby")]
		public IEnumerable<ArticleComment> LkKbarticlecommentbaseCreatedby
		{
			get { return GetRelatedEntities<ArticleComment>("lk_kbarticlecommentbase_createdby", null); }
			set { SetRelatedEntities("lk_kbarticlecommentbase_createdby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_kbarticlecommentbase_modifiedby'
        /// </summary>
		[RelationshipSchemaName("lk_kbarticlecommentbase_modifiedby")]
		public IEnumerable<ArticleComment> LkKbarticlecommentbaseModifiedby
		{
			get { return GetRelatedEntities<ArticleComment>("lk_kbarticlecommentbase_modifiedby", null); }
			set { SetRelatedEntities("lk_kbarticlecommentbase_modifiedby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_kbarticletemplate_createdonbehalfby'
        /// </summary>
		[RelationshipSchemaName("lk_kbarticletemplate_createdonbehalfby")]
		public IEnumerable<ArticleTemplate> LkKbarticletemplateCreatedonbehalfby
		{
			get { return GetRelatedEntities<ArticleTemplate>("lk_kbarticletemplate_createdonbehalfby", null); }
			set { SetRelatedEntities("lk_kbarticletemplate_createdonbehalfby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_kbarticletemplate_modifiedonbehalfby'
        /// </summary>
		[RelationshipSchemaName("lk_kbarticletemplate_modifiedonbehalfby")]
		public IEnumerable<ArticleTemplate> LkKbarticletemplateModifiedonbehalfby
		{
			get { return GetRelatedEntities<ArticleTemplate>("lk_kbarticletemplate_modifiedonbehalfby", null); }
			set { SetRelatedEntities("lk_kbarticletemplate_modifiedonbehalfby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_kbarticletemplatebase_createdby'
        /// </summary>
		[RelationshipSchemaName("lk_kbarticletemplatebase_createdby")]
		public IEnumerable<ArticleTemplate> LkKbarticletemplatebaseCreatedby
		{
			get { return GetRelatedEntities<ArticleTemplate>("lk_kbarticletemplatebase_createdby", null); }
			set { SetRelatedEntities("lk_kbarticletemplatebase_createdby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_kbarticletemplatebase_modifiedby'
        /// </summary>
		[RelationshipSchemaName("lk_kbarticletemplatebase_modifiedby")]
		public IEnumerable<ArticleTemplate> LkKbarticletemplatebaseModifiedby
		{
			get { return GetRelatedEntities<ArticleTemplate>("lk_kbarticletemplatebase_modifiedby", null); }
			set { SetRelatedEntities("lk_kbarticletemplatebase_modifiedby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_knowledgearticle_createdby'
        /// </summary>
		[RelationshipSchemaName("lk_knowledgearticle_createdby")]
		public IEnumerable<KnowledgeArticle> LkKnowledgearticleCreatedby
		{
			get { return GetRelatedEntities<KnowledgeArticle>("lk_knowledgearticle_createdby", null); }
			set { SetRelatedEntities("lk_knowledgearticle_createdby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_knowledgearticle_createdonbehalfby'
        /// </summary>
		[RelationshipSchemaName("lk_knowledgearticle_createdonbehalfby")]
		public IEnumerable<KnowledgeArticle> LkKnowledgearticleCreatedonbehalfby
		{
			get { return GetRelatedEntities<KnowledgeArticle>("lk_knowledgearticle_createdonbehalfby", null); }
			set { SetRelatedEntities("lk_knowledgearticle_createdonbehalfby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_knowledgearticle_modifiedby'
        /// </summary>
		[RelationshipSchemaName("lk_knowledgearticle_modifiedby")]
		public IEnumerable<KnowledgeArticle> LkKnowledgearticleModifiedby
		{
			get { return GetRelatedEntities<KnowledgeArticle>("lk_knowledgearticle_modifiedby", null); }
			set { SetRelatedEntities("lk_knowledgearticle_modifiedby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_knowledgearticle_modifiedonbehalfby'
        /// </summary>
		[RelationshipSchemaName("lk_knowledgearticle_modifiedonbehalfby")]
		public IEnumerable<KnowledgeArticle> LkKnowledgearticleModifiedonbehalfby
		{
			get { return GetRelatedEntities<KnowledgeArticle>("lk_knowledgearticle_modifiedonbehalfby", null); }
			set { SetRelatedEntities("lk_knowledgearticle_modifiedonbehalfby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_knowledgearticleincident_createdby'
        /// </summary>
		[RelationshipSchemaName("lk_knowledgearticleincident_createdby")]
		public IEnumerable<KnowledgeArticleIncident> LkKnowledgearticleincidentCreatedby
		{
			get { return GetRelatedEntities<KnowledgeArticleIncident>("lk_knowledgearticleincident_createdby", null); }
			set { SetRelatedEntities("lk_knowledgearticleincident_createdby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_knowledgearticleincident_createdonbehalfby'
        /// </summary>
		[RelationshipSchemaName("lk_knowledgearticleincident_createdonbehalfby")]
		public IEnumerable<KnowledgeArticleIncident> LkKnowledgearticleincidentCreatedonbehalfby
		{
			get { return GetRelatedEntities<KnowledgeArticleIncident>("lk_knowledgearticleincident_createdonbehalfby", null); }
			set { SetRelatedEntities("lk_knowledgearticleincident_createdonbehalfby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_knowledgearticleincident_modifiedby'
        /// </summary>
		[RelationshipSchemaName("lk_knowledgearticleincident_modifiedby")]
		public IEnumerable<KnowledgeArticleIncident> LkKnowledgearticleincidentModifiedby
		{
			get { return GetRelatedEntities<KnowledgeArticleIncident>("lk_knowledgearticleincident_modifiedby", null); }
			set { SetRelatedEntities("lk_knowledgearticleincident_modifiedby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_knowledgearticleincident_modifiedonbehalfby'
        /// </summary>
		[RelationshipSchemaName("lk_knowledgearticleincident_modifiedonbehalfby")]
		public IEnumerable<KnowledgeArticleIncident> LkKnowledgearticleincidentModifiedonbehalfby
		{
			get { return GetRelatedEntities<KnowledgeArticleIncident>("lk_knowledgearticleincident_modifiedonbehalfby", null); }
			set { SetRelatedEntities("lk_knowledgearticleincident_modifiedonbehalfby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_knowledgearticleviews_createdby'
        /// </summary>
		[RelationshipSchemaName("lk_knowledgearticleviews_createdby")]
		public IEnumerable<KnowledgeArticleViews> LkKnowledgearticleviewsCreatedby
		{
			get { return GetRelatedEntities<KnowledgeArticleViews>("lk_knowledgearticleviews_createdby", null); }
			set { SetRelatedEntities("lk_knowledgearticleviews_createdby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_knowledgearticleviews_createdonbehalfby'
        /// </summary>
		[RelationshipSchemaName("lk_knowledgearticleviews_createdonbehalfby")]
		public IEnumerable<KnowledgeArticleViews> LkKnowledgearticleviewsCreatedonbehalfby
		{
			get { return GetRelatedEntities<KnowledgeArticleViews>("lk_knowledgearticleviews_createdonbehalfby", null); }
			set { SetRelatedEntities("lk_knowledgearticleviews_createdonbehalfby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_knowledgearticleviews_modifiedby'
        /// </summary>
		[RelationshipSchemaName("lk_knowledgearticleviews_modifiedby")]
		public IEnumerable<KnowledgeArticleViews> LkKnowledgearticleviewsModifiedby
		{
			get { return GetRelatedEntities<KnowledgeArticleViews>("lk_knowledgearticleviews_modifiedby", null); }
			set { SetRelatedEntities("lk_knowledgearticleviews_modifiedby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_knowledgearticleviews_modifiedonbehalfby'
        /// </summary>
		[RelationshipSchemaName("lk_knowledgearticleviews_modifiedonbehalfby")]
		public IEnumerable<KnowledgeArticleViews> LkKnowledgearticleviewsModifiedonbehalfby
		{
			get { return GetRelatedEntities<KnowledgeArticleViews>("lk_knowledgearticleviews_modifiedonbehalfby", null); }
			set { SetRelatedEntities("lk_knowledgearticleviews_modifiedonbehalfby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_KnowledgeBaseRecord_createdby'
        /// </summary>
		[RelationshipSchemaName("lk_KnowledgeBaseRecord_createdby")]
		public IEnumerable<KnowledgeBaseRecord> LkKnowledgeBaseRecordCreatedby
		{
			get { return GetRelatedEntities<KnowledgeBaseRecord>("lk_KnowledgeBaseRecord_createdby", null); }
			set { SetRelatedEntities("lk_KnowledgeBaseRecord_createdby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_KnowledgeBaseRecord_createdonbehalfby'
        /// </summary>
		[RelationshipSchemaName("lk_KnowledgeBaseRecord_createdonbehalfby")]
		public IEnumerable<KnowledgeBaseRecord> LkKnowledgeBaseRecordCreatedonbehalfby
		{
			get { return GetRelatedEntities<KnowledgeBaseRecord>("lk_KnowledgeBaseRecord_createdonbehalfby", null); }
			set { SetRelatedEntities("lk_KnowledgeBaseRecord_createdonbehalfby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_KnowledgeBaseRecord_modifiedby'
        /// </summary>
		[RelationshipSchemaName("lk_KnowledgeBaseRecord_modifiedby")]
		public IEnumerable<KnowledgeBaseRecord> LkKnowledgeBaseRecordModifiedby
		{
			get { return GetRelatedEntities<KnowledgeBaseRecord>("lk_KnowledgeBaseRecord_modifiedby", null); }
			set { SetRelatedEntities("lk_KnowledgeBaseRecord_modifiedby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_KnowledgeBaseRecord_modifiedonbehalfby'
        /// </summary>
		[RelationshipSchemaName("lk_KnowledgeBaseRecord_modifiedonbehalfby")]
		public IEnumerable<KnowledgeBaseRecord> LkKnowledgeBaseRecordModifiedonbehalfby
		{
			get { return GetRelatedEntities<KnowledgeBaseRecord>("lk_KnowledgeBaseRecord_modifiedonbehalfby", null); }
			set { SetRelatedEntities("lk_KnowledgeBaseRecord_modifiedonbehalfby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_lead_createdonbehalfby'
        /// </summary>
		[RelationshipSchemaName("lk_lead_createdonbehalfby")]
		public IEnumerable<Lead> LkLeadCreatedonbehalfby
		{
			get { return GetRelatedEntities<Lead>("lk_lead_createdonbehalfby", null); }
			set { SetRelatedEntities("lk_lead_createdonbehalfby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_lead_modifiedonbehalfby'
        /// </summary>
		[RelationshipSchemaName("lk_lead_modifiedonbehalfby")]
		public IEnumerable<Lead> LkLeadModifiedonbehalfby
		{
			get { return GetRelatedEntities<Lead>("lk_lead_modifiedonbehalfby", null); }
			set { SetRelatedEntities("lk_lead_modifiedonbehalfby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_leadaddress_createdonbehalfby'
        /// </summary>
		[RelationshipSchemaName("lk_leadaddress_createdonbehalfby")]
		public IEnumerable<LeadAddress> LkLeadaddressCreatedonbehalfby
		{
			get { return GetRelatedEntities<LeadAddress>("lk_leadaddress_createdonbehalfby", null); }
			set { SetRelatedEntities("lk_leadaddress_createdonbehalfby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_leadaddress_modifiedonbehalfby'
        /// </summary>
		[RelationshipSchemaName("lk_leadaddress_modifiedonbehalfby")]
		public IEnumerable<LeadAddress> LkLeadaddressModifiedonbehalfby
		{
			get { return GetRelatedEntities<LeadAddress>("lk_leadaddress_modifiedonbehalfby", null); }
			set { SetRelatedEntities("lk_leadaddress_modifiedonbehalfby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_leadaddressbase_createdby'
        /// </summary>
		[RelationshipSchemaName("lk_leadaddressbase_createdby")]
		public IEnumerable<LeadAddress> LkLeadaddressbaseCreatedby
		{
			get { return GetRelatedEntities<LeadAddress>("lk_leadaddressbase_createdby", null); }
			set { SetRelatedEntities("lk_leadaddressbase_createdby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_leadaddressbase_modifiedby'
        /// </summary>
		[RelationshipSchemaName("lk_leadaddressbase_modifiedby")]
		public IEnumerable<LeadAddress> LkLeadaddressbaseModifiedby
		{
			get { return GetRelatedEntities<LeadAddress>("lk_leadaddressbase_modifiedby", null); }
			set { SetRelatedEntities("lk_leadaddressbase_modifiedby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_leadbase_createdby'
        /// </summary>
		[RelationshipSchemaName("lk_leadbase_createdby")]
		public IEnumerable<Lead> LkLeadbaseCreatedby
		{
			get { return GetRelatedEntities<Lead>("lk_leadbase_createdby", null); }
			set { SetRelatedEntities("lk_leadbase_createdby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_leadbase_modifiedby'
        /// </summary>
		[RelationshipSchemaName("lk_leadbase_modifiedby")]
		public IEnumerable<Lead> LkLeadbaseModifiedby
		{
			get { return GetRelatedEntities<Lead>("lk_leadbase_modifiedby", null); }
			set { SetRelatedEntities("lk_leadbase_modifiedby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_leadtoopportunitysalesprocess_createdby'
        /// </summary>
		[RelationshipSchemaName("lk_leadtoopportunitysalesprocess_createdby")]
		public IEnumerable<LeadToOpportunitySalesProcess> LkLeadtoopportunitysalesprocessCreatedby
		{
			get { return GetRelatedEntities<LeadToOpportunitySalesProcess>("lk_leadtoopportunitysalesprocess_createdby", null); }
			set { SetRelatedEntities("lk_leadtoopportunitysalesprocess_createdby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_leadtoopportunitysalesprocess_createdonbehalfby'
        /// </summary>
		[RelationshipSchemaName("lk_leadtoopportunitysalesprocess_createdonbehalfby")]
		public IEnumerable<LeadToOpportunitySalesProcess> LkLeadtoopportunitysalesprocessCreatedonbehalfby
		{
			get { return GetRelatedEntities<LeadToOpportunitySalesProcess>("lk_leadtoopportunitysalesprocess_createdonbehalfby", null); }
			set { SetRelatedEntities("lk_leadtoopportunitysalesprocess_createdonbehalfby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_leadtoopportunitysalesprocess_modifiedby'
        /// </summary>
		[RelationshipSchemaName("lk_leadtoopportunitysalesprocess_modifiedby")]
		public IEnumerable<LeadToOpportunitySalesProcess> LkLeadtoopportunitysalesprocessModifiedby
		{
			get { return GetRelatedEntities<LeadToOpportunitySalesProcess>("lk_leadtoopportunitysalesprocess_modifiedby", null); }
			set { SetRelatedEntities("lk_leadtoopportunitysalesprocess_modifiedby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_leadtoopportunitysalesprocess_modifiedonbehalfby'
        /// </summary>
		[RelationshipSchemaName("lk_leadtoopportunitysalesprocess_modifiedonbehalfby")]
		public IEnumerable<LeadToOpportunitySalesProcess> LkLeadtoopportunitysalesprocessModifiedonbehalfby
		{
			get { return GetRelatedEntities<LeadToOpportunitySalesProcess>("lk_leadtoopportunitysalesprocess_modifiedonbehalfby", null); }
			set { SetRelatedEntities("lk_leadtoopportunitysalesprocess_modifiedonbehalfby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_letter_createdby'
        /// </summary>
		[RelationshipSchemaName("lk_letter_createdby")]
		public IEnumerable<Letter> LkLetterCreatedby
		{
			get { return GetRelatedEntities<Letter>("lk_letter_createdby", null); }
			set { SetRelatedEntities("lk_letter_createdby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_letter_createdonbehalfby'
        /// </summary>
		[RelationshipSchemaName("lk_letter_createdonbehalfby")]
		public IEnumerable<Letter> LkLetterCreatedonbehalfby
		{
			get { return GetRelatedEntities<Letter>("lk_letter_createdonbehalfby", null); }
			set { SetRelatedEntities("lk_letter_createdonbehalfby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_letter_modifiedby'
        /// </summary>
		[RelationshipSchemaName("lk_letter_modifiedby")]
		public IEnumerable<Letter> LkLetterModifiedby
		{
			get { return GetRelatedEntities<Letter>("lk_letter_modifiedby", null); }
			set { SetRelatedEntities("lk_letter_modifiedby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_letter_modifiedonbehalfby'
        /// </summary>
		[RelationshipSchemaName("lk_letter_modifiedonbehalfby")]
		public IEnumerable<Letter> LkLetterModifiedonbehalfby
		{
			get { return GetRelatedEntities<Letter>("lk_letter_modifiedonbehalfby", null); }
			set { SetRelatedEntities("lk_letter_modifiedonbehalfby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_list_createdby'
        /// </summary>
		[RelationshipSchemaName("lk_list_createdby")]
		public IEnumerable<MarketingList> LkListCreatedby
		{
			get { return GetRelatedEntities<MarketingList>("lk_list_createdby", null); }
			set { SetRelatedEntities("lk_list_createdby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_list_createdonbehalfby'
        /// </summary>
		[RelationshipSchemaName("lk_list_createdonbehalfby")]
		public IEnumerable<MarketingList> LkListCreatedonbehalfby
		{
			get { return GetRelatedEntities<MarketingList>("lk_list_createdonbehalfby", null); }
			set { SetRelatedEntities("lk_list_createdonbehalfby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_list_modifiedby'
        /// </summary>
		[RelationshipSchemaName("lk_list_modifiedby")]
		public IEnumerable<MarketingList> LkListModifiedby
		{
			get { return GetRelatedEntities<MarketingList>("lk_list_modifiedby", null); }
			set { SetRelatedEntities("lk_list_modifiedby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_list_modifiedonbehalfby'
        /// </summary>
		[RelationshipSchemaName("lk_list_modifiedonbehalfby")]
		public IEnumerable<MarketingList> LkListModifiedonbehalfby
		{
			get { return GetRelatedEntities<MarketingList>("lk_list_modifiedonbehalfby", null); }
			set { SetRelatedEntities("lk_list_modifiedonbehalfby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_listoperation_createdby'
        /// </summary>
		[RelationshipSchemaName("lk_listoperation_createdby")]
		public IEnumerable<ListOperation> LkListoperationCreatedby
		{
			get { return GetRelatedEntities<ListOperation>("lk_listoperation_createdby", null); }
			set { SetRelatedEntities("lk_listoperation_createdby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_listoperation_createdonbehalfby'
        /// </summary>
		[RelationshipSchemaName("lk_listoperation_createdonbehalfby")]
		public IEnumerable<ListOperation> LkListoperationCreatedonbehalfby
		{
			get { return GetRelatedEntities<ListOperation>("lk_listoperation_createdonbehalfby", null); }
			set { SetRelatedEntities("lk_listoperation_createdonbehalfby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_listoperation_modifiedby'
        /// </summary>
		[RelationshipSchemaName("lk_listoperation_modifiedby")]
		public IEnumerable<ListOperation> LkListoperationModifiedby
		{
			get { return GetRelatedEntities<ListOperation>("lk_listoperation_modifiedby", null); }
			set { SetRelatedEntities("lk_listoperation_modifiedby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_listoperation_modifiedonbehalfby'
        /// </summary>
		[RelationshipSchemaName("lk_listoperation_modifiedonbehalfby")]
		public IEnumerable<ListOperation> LkListoperationModifiedonbehalfby
		{
			get { return GetRelatedEntities<ListOperation>("lk_listoperation_modifiedonbehalfby", null); }
			set { SetRelatedEntities("lk_listoperation_modifiedonbehalfby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_lookupmapping_createdby'
        /// </summary>
		[RelationshipSchemaName("lk_lookupmapping_createdby")]
		public IEnumerable<LookupMapping> LkLookupmappingCreatedby
		{
			get { return GetRelatedEntities<LookupMapping>("lk_lookupmapping_createdby", null); }
			set { SetRelatedEntities("lk_lookupmapping_createdby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_lookupmapping_createdonbehalfby'
        /// </summary>
		[RelationshipSchemaName("lk_lookupmapping_createdonbehalfby")]
		public IEnumerable<LookupMapping> LkLookupmappingCreatedonbehalfby
		{
			get { return GetRelatedEntities<LookupMapping>("lk_lookupmapping_createdonbehalfby", null); }
			set { SetRelatedEntities("lk_lookupmapping_createdonbehalfby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_lookupmapping_modifiedby'
        /// </summary>
		[RelationshipSchemaName("lk_lookupmapping_modifiedby")]
		public IEnumerable<LookupMapping> LkLookupmappingModifiedby
		{
			get { return GetRelatedEntities<LookupMapping>("lk_lookupmapping_modifiedby", null); }
			set { SetRelatedEntities("lk_lookupmapping_modifiedby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_lookupmapping_modifiedonbehalfby'
        /// </summary>
		[RelationshipSchemaName("lk_lookupmapping_modifiedonbehalfby")]
		public IEnumerable<LookupMapping> LkLookupmappingModifiedonbehalfby
		{
			get { return GetRelatedEntities<LookupMapping>("lk_lookupmapping_modifiedonbehalfby", null); }
			set { SetRelatedEntities("lk_lookupmapping_modifiedonbehalfby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_mailbox_createdby'
        /// </summary>
		[RelationshipSchemaName("lk_mailbox_createdby")]
		public IEnumerable<Mailbox> LkMailboxCreatedby
		{
			get { return GetRelatedEntities<Mailbox>("lk_mailbox_createdby", null); }
			set { SetRelatedEntities("lk_mailbox_createdby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_mailbox_createdonbehalfby'
        /// </summary>
		[RelationshipSchemaName("lk_mailbox_createdonbehalfby")]
		public IEnumerable<Mailbox> LkMailboxCreatedonbehalfby
		{
			get { return GetRelatedEntities<Mailbox>("lk_mailbox_createdonbehalfby", null); }
			set { SetRelatedEntities("lk_mailbox_createdonbehalfby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_mailbox_modifiedby'
        /// </summary>
		[RelationshipSchemaName("lk_mailbox_modifiedby")]
		public IEnumerable<Mailbox> LkMailboxModifiedby
		{
			get { return GetRelatedEntities<Mailbox>("lk_mailbox_modifiedby", null); }
			set { SetRelatedEntities("lk_mailbox_modifiedby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_mailbox_modifiedonbehalfby'
        /// </summary>
		[RelationshipSchemaName("lk_mailbox_modifiedonbehalfby")]
		public IEnumerable<Mailbox> LkMailboxModifiedonbehalfby
		{
			get { return GetRelatedEntities<Mailbox>("lk_mailbox_modifiedonbehalfby", null); }
			set { SetRelatedEntities("lk_mailbox_modifiedonbehalfby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_mailboxtrackingfolder_createdby'
        /// </summary>
		[RelationshipSchemaName("lk_mailboxtrackingfolder_createdby")]
		public IEnumerable<MailboxAutoTrackingFolder> LkMailboxtrackingfolderCreatedby
		{
			get { return GetRelatedEntities<MailboxAutoTrackingFolder>("lk_mailboxtrackingfolder_createdby", null); }
			set { SetRelatedEntities("lk_mailboxtrackingfolder_createdby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_mailboxtrackingfolder_createdonbehalfby'
        /// </summary>
		[RelationshipSchemaName("lk_mailboxtrackingfolder_createdonbehalfby")]
		public IEnumerable<MailboxAutoTrackingFolder> LkMailboxtrackingfolderCreatedonbehalfby
		{
			get { return GetRelatedEntities<MailboxAutoTrackingFolder>("lk_mailboxtrackingfolder_createdonbehalfby", null); }
			set { SetRelatedEntities("lk_mailboxtrackingfolder_createdonbehalfby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_mailboxtrackingfolder_modifiedby'
        /// </summary>
		[RelationshipSchemaName("lk_mailboxtrackingfolder_modifiedby")]
		public IEnumerable<MailboxAutoTrackingFolder> LkMailboxtrackingfolderModifiedby
		{
			get { return GetRelatedEntities<MailboxAutoTrackingFolder>("lk_mailboxtrackingfolder_modifiedby", null); }
			set { SetRelatedEntities("lk_mailboxtrackingfolder_modifiedby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_mailboxtrackingfolder_modifiedonbehalfby'
        /// </summary>
		[RelationshipSchemaName("lk_mailboxtrackingfolder_modifiedonbehalfby")]
		public IEnumerable<MailboxAutoTrackingFolder> LkMailboxtrackingfolderModifiedonbehalfby
		{
			get { return GetRelatedEntities<MailboxAutoTrackingFolder>("lk_mailboxtrackingfolder_modifiedonbehalfby", null); }
			set { SetRelatedEntities("lk_mailboxtrackingfolder_modifiedonbehalfby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_mailmergetemplate_createdonbehalfby'
        /// </summary>
		[RelationshipSchemaName("lk_mailmergetemplate_createdonbehalfby")]
		public IEnumerable<MailMergeTemplate> LkMailmergetemplateCreatedonbehalfby
		{
			get { return GetRelatedEntities<MailMergeTemplate>("lk_mailmergetemplate_createdonbehalfby", null); }
			set { SetRelatedEntities("lk_mailmergetemplate_createdonbehalfby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_mailmergetemplate_modifiedonbehalfby'
        /// </summary>
		[RelationshipSchemaName("lk_mailmergetemplate_modifiedonbehalfby")]
		public IEnumerable<MailMergeTemplate> LkMailmergetemplateModifiedonbehalfby
		{
			get { return GetRelatedEntities<MailMergeTemplate>("lk_mailmergetemplate_modifiedonbehalfby", null); }
			set { SetRelatedEntities("lk_mailmergetemplate_modifiedonbehalfby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_mailmergetemplatebase_createdby'
        /// </summary>
		[RelationshipSchemaName("lk_mailmergetemplatebase_createdby")]
		public IEnumerable<MailMergeTemplate> LkMailmergetemplatebaseCreatedby
		{
			get { return GetRelatedEntities<MailMergeTemplate>("lk_mailmergetemplatebase_createdby", null); }
			set { SetRelatedEntities("lk_mailmergetemplatebase_createdby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_mailmergetemplatebase_modifiedby'
        /// </summary>
		[RelationshipSchemaName("lk_mailmergetemplatebase_modifiedby")]
		public IEnumerable<MailMergeTemplate> LkMailmergetemplatebaseModifiedby
		{
			get { return GetRelatedEntities<MailMergeTemplate>("lk_mailmergetemplatebase_modifiedby", null); }
			set { SetRelatedEntities("lk_mailmergetemplatebase_modifiedby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_marketingformdisplayattributes_createdby'
        /// </summary>
		[RelationshipSchemaName("lk_marketingformdisplayattributes_createdby")]
		public IEnumerable<MarketingFormDisplayAttributes> LkMarketingformdisplayattributesCreatedby
		{
			get { return GetRelatedEntities<MarketingFormDisplayAttributes>("lk_marketingformdisplayattributes_createdby", null); }
			set { SetRelatedEntities("lk_marketingformdisplayattributes_createdby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_marketingformdisplayattributes_createdonbehalfby'
        /// </summary>
		[RelationshipSchemaName("lk_marketingformdisplayattributes_createdonbehalfby")]
		public IEnumerable<MarketingFormDisplayAttributes> LkMarketingformdisplayattributesCreatedonbehalfby
		{
			get { return GetRelatedEntities<MarketingFormDisplayAttributes>("lk_marketingformdisplayattributes_createdonbehalfby", null); }
			set { SetRelatedEntities("lk_marketingformdisplayattributes_createdonbehalfby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_marketingformdisplayattributes_modifiedby'
        /// </summary>
		[RelationshipSchemaName("lk_marketingformdisplayattributes_modifiedby")]
		public IEnumerable<MarketingFormDisplayAttributes> LkMarketingformdisplayattributesModifiedby
		{
			get { return GetRelatedEntities<MarketingFormDisplayAttributes>("lk_marketingformdisplayattributes_modifiedby", null); }
			set { SetRelatedEntities("lk_marketingformdisplayattributes_modifiedby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_marketingformdisplayattributes_modifiedonbehalfby'
        /// </summary>
		[RelationshipSchemaName("lk_marketingformdisplayattributes_modifiedonbehalfby")]
		public IEnumerable<MarketingFormDisplayAttributes> LkMarketingformdisplayattributesModifiedonbehalfby
		{
			get { return GetRelatedEntities<MarketingFormDisplayAttributes>("lk_marketingformdisplayattributes_modifiedonbehalfby", null); }
			set { SetRelatedEntities("lk_marketingformdisplayattributes_modifiedonbehalfby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_metric_createdby'
        /// </summary>
		[RelationshipSchemaName("lk_metric_createdby")]
		public IEnumerable<GoalMetric> LkMetricCreatedby
		{
			get { return GetRelatedEntities<GoalMetric>("lk_metric_createdby", null); }
			set { SetRelatedEntities("lk_metric_createdby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_metric_createdonbehalfby'
        /// </summary>
		[RelationshipSchemaName("lk_metric_createdonbehalfby")]
		public IEnumerable<GoalMetric> LkMetricCreatedonbehalfby
		{
			get { return GetRelatedEntities<GoalMetric>("lk_metric_createdonbehalfby", null); }
			set { SetRelatedEntities("lk_metric_createdonbehalfby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_metric_modifiedby'
        /// </summary>
		[RelationshipSchemaName("lk_metric_modifiedby")]
		public IEnumerable<GoalMetric> LkMetricModifiedby
		{
			get { return GetRelatedEntities<GoalMetric>("lk_metric_modifiedby", null); }
			set { SetRelatedEntities("lk_metric_modifiedby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_metric_modifiedonbehalfby'
        /// </summary>
		[RelationshipSchemaName("lk_metric_modifiedonbehalfby")]
		public IEnumerable<GoalMetric> LkMetricModifiedonbehalfby
		{
			get { return GetRelatedEntities<GoalMetric>("lk_metric_modifiedonbehalfby", null); }
			set { SetRelatedEntities("lk_metric_modifiedonbehalfby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_MobileOfflineProfile_createdby'
        /// </summary>
		[RelationshipSchemaName("lk_MobileOfflineProfile_createdby")]
		public IEnumerable<MobileOfflineProfile> LkMobileOfflineProfileCreatedby
		{
			get { return GetRelatedEntities<MobileOfflineProfile>("lk_MobileOfflineProfile_createdby", null); }
			set { SetRelatedEntities("lk_MobileOfflineProfile_createdby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_MobileOfflineProfile_createdonbehalfby'
        /// </summary>
		[RelationshipSchemaName("lk_MobileOfflineProfile_createdonbehalfby")]
		public IEnumerable<MobileOfflineProfile> LkMobileOfflineProfileCreatedonbehalfby
		{
			get { return GetRelatedEntities<MobileOfflineProfile>("lk_MobileOfflineProfile_createdonbehalfby", null); }
			set { SetRelatedEntities("lk_MobileOfflineProfile_createdonbehalfby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_MobileOfflineProfile_modifiedby'
        /// </summary>
		[RelationshipSchemaName("lk_MobileOfflineProfile_modifiedby")]
		public IEnumerable<MobileOfflineProfile> LkMobileOfflineProfileModifiedby
		{
			get { return GetRelatedEntities<MobileOfflineProfile>("lk_MobileOfflineProfile_modifiedby", null); }
			set { SetRelatedEntities("lk_MobileOfflineProfile_modifiedby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_MobileOfflineProfile_modifiedonbehalfby'
        /// </summary>
		[RelationshipSchemaName("lk_MobileOfflineProfile_modifiedonbehalfby")]
		public IEnumerable<MobileOfflineProfile> LkMobileOfflineProfileModifiedonbehalfby
		{
			get { return GetRelatedEntities<MobileOfflineProfile>("lk_MobileOfflineProfile_modifiedonbehalfby", null); }
			set { SetRelatedEntities("lk_MobileOfflineProfile_modifiedonbehalfby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_MobileOfflineProfileItem_createdby'
        /// </summary>
		[RelationshipSchemaName("lk_MobileOfflineProfileItem_createdby")]
		public IEnumerable<MobileOfflineProfileItem> LkMobileOfflineProfileItemCreatedby
		{
			get { return GetRelatedEntities<MobileOfflineProfileItem>("lk_MobileOfflineProfileItem_createdby", null); }
			set { SetRelatedEntities("lk_MobileOfflineProfileItem_createdby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_mobileofflineprofileitem_createdonbehalfby'
        /// </summary>
		[RelationshipSchemaName("lk_mobileofflineprofileitem_createdonbehalfby")]
		public IEnumerable<MobileOfflineProfileItem> LkMobileofflineprofileitemCreatedonbehalfby
		{
			get { return GetRelatedEntities<MobileOfflineProfileItem>("lk_mobileofflineprofileitem_createdonbehalfby", null); }
			set { SetRelatedEntities("lk_mobileofflineprofileitem_createdonbehalfby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_mobileofflineprofileitem_modifiedby'
        /// </summary>
		[RelationshipSchemaName("lk_mobileofflineprofileitem_modifiedby")]
		public IEnumerable<MobileOfflineProfileItem> LkMobileofflineprofileitemModifiedby
		{
			get { return GetRelatedEntities<MobileOfflineProfileItem>("lk_mobileofflineprofileitem_modifiedby", null); }
			set { SetRelatedEntities("lk_mobileofflineprofileitem_modifiedby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_mobileofflineprofileitem_modifiedonbehalfby'
        /// </summary>
		[RelationshipSchemaName("lk_mobileofflineprofileitem_modifiedonbehalfby")]
		public IEnumerable<MobileOfflineProfileItem> LkMobileofflineprofileitemModifiedonbehalfby
		{
			get { return GetRelatedEntities<MobileOfflineProfileItem>("lk_mobileofflineprofileitem_modifiedonbehalfby", null); }
			set { SetRelatedEntities("lk_mobileofflineprofileitem_modifiedonbehalfby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_MobileOfflineProfileItemAssociation_createdby'
        /// </summary>
		[RelationshipSchemaName("lk_MobileOfflineProfileItemAssociation_createdby")]
		public IEnumerable<MobileOfflineProfileItemAssociation> LkMobileOfflineProfileItemAssociationCreatedby
		{
			get { return GetRelatedEntities<MobileOfflineProfileItemAssociation>("lk_MobileOfflineProfileItemAssociation_createdby", null); }
			set { SetRelatedEntities("lk_MobileOfflineProfileItemAssociation_createdby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_mobileofflineprofileitemassociation_createdonbehalfby'
        /// </summary>
		[RelationshipSchemaName("lk_mobileofflineprofileitemassociation_createdonbehalfby")]
		public IEnumerable<MobileOfflineProfileItemAssociation> LkMobileofflineprofileitemassociationCreatedonbehalfby
		{
			get { return GetRelatedEntities<MobileOfflineProfileItemAssociation>("lk_mobileofflineprofileitemassociation_createdonbehalfby", null); }
			set { SetRelatedEntities("lk_mobileofflineprofileitemassociation_createdonbehalfby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_mobileofflineprofileitemassociation_modifiedby'
        /// </summary>
		[RelationshipSchemaName("lk_mobileofflineprofileitemassociation_modifiedby")]
		public IEnumerable<MobileOfflineProfileItemAssociation> LkMobileofflineprofileitemassociationModifiedby
		{
			get { return GetRelatedEntities<MobileOfflineProfileItemAssociation>("lk_mobileofflineprofileitemassociation_modifiedby", null); }
			set { SetRelatedEntities("lk_mobileofflineprofileitemassociation_modifiedby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_mobileofflineprofileitemassociation_modifiedonbehalfby'
        /// </summary>
		[RelationshipSchemaName("lk_mobileofflineprofileitemassociation_modifiedonbehalfby")]
		public IEnumerable<MobileOfflineProfileItemAssociation> LkMobileofflineprofileitemassociationModifiedonbehalfby
		{
			get { return GetRelatedEntities<MobileOfflineProfileItemAssociation>("lk_mobileofflineprofileitemassociation_modifiedonbehalfby", null); }
			set { SetRelatedEntities("lk_mobileofflineprofileitemassociation_modifiedonbehalfby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_monthlyfiscalcalendar_createdby'
        /// </summary>
		[RelationshipSchemaName("lk_monthlyfiscalcalendar_createdby")]
		public IEnumerable<MonthlyFiscalCalendar> LkMonthlyfiscalcalendarCreatedby
		{
			get { return GetRelatedEntities<MonthlyFiscalCalendar>("lk_monthlyfiscalcalendar_createdby", null); }
			set { SetRelatedEntities("lk_monthlyfiscalcalendar_createdby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_monthlyfiscalcalendar_createdonbehalfby'
        /// </summary>
		[RelationshipSchemaName("lk_monthlyfiscalcalendar_createdonbehalfby")]
		public IEnumerable<MonthlyFiscalCalendar> LkMonthlyfiscalcalendarCreatedonbehalfby
		{
			get { return GetRelatedEntities<MonthlyFiscalCalendar>("lk_monthlyfiscalcalendar_createdonbehalfby", null); }
			set { SetRelatedEntities("lk_monthlyfiscalcalendar_createdonbehalfby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_monthlyfiscalcalendar_modifiedby'
        /// </summary>
		[RelationshipSchemaName("lk_monthlyfiscalcalendar_modifiedby")]
		public IEnumerable<MonthlyFiscalCalendar> LkMonthlyfiscalcalendarModifiedby
		{
			get { return GetRelatedEntities<MonthlyFiscalCalendar>("lk_monthlyfiscalcalendar_modifiedby", null); }
			set { SetRelatedEntities("lk_monthlyfiscalcalendar_modifiedby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_monthlyfiscalcalendar_modifiedonbehalfby'
        /// </summary>
		[RelationshipSchemaName("lk_monthlyfiscalcalendar_modifiedonbehalfby")]
		public IEnumerable<MonthlyFiscalCalendar> LkMonthlyfiscalcalendarModifiedonbehalfby
		{
			get { return GetRelatedEntities<MonthlyFiscalCalendar>("lk_monthlyfiscalcalendar_modifiedonbehalfby", null); }
			set { SetRelatedEntities("lk_monthlyfiscalcalendar_modifiedonbehalfby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_monthlyfiscalcalendar_salespersonid'
        /// </summary>
		[RelationshipSchemaName("lk_monthlyfiscalcalendar_salespersonid")]
		public IEnumerable<MonthlyFiscalCalendar> LkMonthlyfiscalcalendarSalespersonid
		{
			get { return GetRelatedEntities<MonthlyFiscalCalendar>("lk_monthlyfiscalcalendar_salespersonid", null); }
			set { SetRelatedEntities("lk_monthlyfiscalcalendar_salespersonid", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_msdyn_actioncardregarding_createdby'
        /// </summary>
		[RelationshipSchemaName("lk_msdyn_actioncardregarding_createdby")]
		public IEnumerable<ActionCardRegarding> LkMsdynActioncardregardingCreatedby
		{
			get { return GetRelatedEntities<ActionCardRegarding>("lk_msdyn_actioncardregarding_createdby", null); }
			set { SetRelatedEntities("lk_msdyn_actioncardregarding_createdby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_msdyn_actioncardregarding_createdonbehalfby'
        /// </summary>
		[RelationshipSchemaName("lk_msdyn_actioncardregarding_createdonbehalfby")]
		public IEnumerable<ActionCardRegarding> LkMsdynActioncardregardingCreatedonbehalfby
		{
			get { return GetRelatedEntities<ActionCardRegarding>("lk_msdyn_actioncardregarding_createdonbehalfby", null); }
			set { SetRelatedEntities("lk_msdyn_actioncardregarding_createdonbehalfby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_msdyn_actioncardregarding_modifiedby'
        /// </summary>
		[RelationshipSchemaName("lk_msdyn_actioncardregarding_modifiedby")]
		public IEnumerable<ActionCardRegarding> LkMsdynActioncardregardingModifiedby
		{
			get { return GetRelatedEntities<ActionCardRegarding>("lk_msdyn_actioncardregarding_modifiedby", null); }
			set { SetRelatedEntities("lk_msdyn_actioncardregarding_modifiedby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_msdyn_actioncardregarding_modifiedonbehalfby'
        /// </summary>
		[RelationshipSchemaName("lk_msdyn_actioncardregarding_modifiedonbehalfby")]
		public IEnumerable<ActionCardRegarding> LkMsdynActioncardregardingModifiedonbehalfby
		{
			get { return GetRelatedEntities<ActionCardRegarding>("lk_msdyn_actioncardregarding_modifiedonbehalfby", null); }
			set { SetRelatedEntities("lk_msdyn_actioncardregarding_modifiedonbehalfby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_msdyn_actioncardrolesetting_createdby'
        /// </summary>
		[RelationshipSchemaName("lk_msdyn_actioncardrolesetting_createdby")]
		public IEnumerable<ActionCardRoleSetting> LkMsdynActioncardrolesettingCreatedby
		{
			get { return GetRelatedEntities<ActionCardRoleSetting>("lk_msdyn_actioncardrolesetting_createdby", null); }
			set { SetRelatedEntities("lk_msdyn_actioncardrolesetting_createdby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_msdyn_actioncardrolesetting_createdonbehalfby'
        /// </summary>
		[RelationshipSchemaName("lk_msdyn_actioncardrolesetting_createdonbehalfby")]
		public IEnumerable<ActionCardRoleSetting> LkMsdynActioncardrolesettingCreatedonbehalfby
		{
			get { return GetRelatedEntities<ActionCardRoleSetting>("lk_msdyn_actioncardrolesetting_createdonbehalfby", null); }
			set { SetRelatedEntities("lk_msdyn_actioncardrolesetting_createdonbehalfby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_msdyn_actioncardrolesetting_modifiedby'
        /// </summary>
		[RelationshipSchemaName("lk_msdyn_actioncardrolesetting_modifiedby")]
		public IEnumerable<ActionCardRoleSetting> LkMsdynActioncardrolesettingModifiedby
		{
			get { return GetRelatedEntities<ActionCardRoleSetting>("lk_msdyn_actioncardrolesetting_modifiedby", null); }
			set { SetRelatedEntities("lk_msdyn_actioncardrolesetting_modifiedby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_msdyn_actioncardrolesetting_modifiedonbehalfby'
        /// </summary>
		[RelationshipSchemaName("lk_msdyn_actioncardrolesetting_modifiedonbehalfby")]
		public IEnumerable<ActionCardRoleSetting> LkMsdynActioncardrolesettingModifiedonbehalfby
		{
			get { return GetRelatedEntities<ActionCardRoleSetting>("lk_msdyn_actioncardrolesetting_modifiedonbehalfby", null); }
			set { SetRelatedEntities("lk_msdyn_actioncardrolesetting_modifiedonbehalfby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_msdyn_aibdataset_createdby'
        /// </summary>
		[RelationshipSchemaName("lk_msdyn_aibdataset_createdby")]
		public IEnumerable<AIBuilderDataset> LkMsdynAibdatasetCreatedby
		{
			get { return GetRelatedEntities<AIBuilderDataset>("lk_msdyn_aibdataset_createdby", null); }
			set { SetRelatedEntities("lk_msdyn_aibdataset_createdby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_msdyn_aibdataset_createdonbehalfby'
        /// </summary>
		[RelationshipSchemaName("lk_msdyn_aibdataset_createdonbehalfby")]
		public IEnumerable<AIBuilderDataset> LkMsdynAibdatasetCreatedonbehalfby
		{
			get { return GetRelatedEntities<AIBuilderDataset>("lk_msdyn_aibdataset_createdonbehalfby", null); }
			set { SetRelatedEntities("lk_msdyn_aibdataset_createdonbehalfby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_msdyn_aibdataset_modifiedby'
        /// </summary>
		[RelationshipSchemaName("lk_msdyn_aibdataset_modifiedby")]
		public IEnumerable<AIBuilderDataset> LkMsdynAibdatasetModifiedby
		{
			get { return GetRelatedEntities<AIBuilderDataset>("lk_msdyn_aibdataset_modifiedby", null); }
			set { SetRelatedEntities("lk_msdyn_aibdataset_modifiedby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_msdyn_aibdataset_modifiedonbehalfby'
        /// </summary>
		[RelationshipSchemaName("lk_msdyn_aibdataset_modifiedonbehalfby")]
		public IEnumerable<AIBuilderDataset> LkMsdynAibdatasetModifiedonbehalfby
		{
			get { return GetRelatedEntities<AIBuilderDataset>("lk_msdyn_aibdataset_modifiedonbehalfby", null); }
			set { SetRelatedEntities("lk_msdyn_aibdataset_modifiedonbehalfby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_msdyn_aibdatasetfile_createdby'
        /// </summary>
		[RelationshipSchemaName("lk_msdyn_aibdatasetfile_createdby")]
		public IEnumerable<AIBuilderDatasetFile> LkMsdynAibdatasetfileCreatedby
		{
			get { return GetRelatedEntities<AIBuilderDatasetFile>("lk_msdyn_aibdatasetfile_createdby", null); }
			set { SetRelatedEntities("lk_msdyn_aibdatasetfile_createdby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_msdyn_aibdatasetfile_createdonbehalfby'
        /// </summary>
		[RelationshipSchemaName("lk_msdyn_aibdatasetfile_createdonbehalfby")]
		public IEnumerable<AIBuilderDatasetFile> LkMsdynAibdatasetfileCreatedonbehalfby
		{
			get { return GetRelatedEntities<AIBuilderDatasetFile>("lk_msdyn_aibdatasetfile_createdonbehalfby", null); }
			set { SetRelatedEntities("lk_msdyn_aibdatasetfile_createdonbehalfby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_msdyn_aibdatasetfile_modifiedby'
        /// </summary>
		[RelationshipSchemaName("lk_msdyn_aibdatasetfile_modifiedby")]
		public IEnumerable<AIBuilderDatasetFile> LkMsdynAibdatasetfileModifiedby
		{
			get { return GetRelatedEntities<AIBuilderDatasetFile>("lk_msdyn_aibdatasetfile_modifiedby", null); }
			set { SetRelatedEntities("lk_msdyn_aibdatasetfile_modifiedby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_msdyn_aibdatasetfile_modifiedonbehalfby'
        /// </summary>
		[RelationshipSchemaName("lk_msdyn_aibdatasetfile_modifiedonbehalfby")]
		public IEnumerable<AIBuilderDatasetFile> LkMsdynAibdatasetfileModifiedonbehalfby
		{
			get { return GetRelatedEntities<AIBuilderDatasetFile>("lk_msdyn_aibdatasetfile_modifiedonbehalfby", null); }
			set { SetRelatedEntities("lk_msdyn_aibdatasetfile_modifiedonbehalfby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_msdyn_aibdatasetrecord_createdby'
        /// </summary>
		[RelationshipSchemaName("lk_msdyn_aibdatasetrecord_createdby")]
		public IEnumerable<AIBuilderDatasetRecord> LkMsdynAibdatasetrecordCreatedby
		{
			get { return GetRelatedEntities<AIBuilderDatasetRecord>("lk_msdyn_aibdatasetrecord_createdby", null); }
			set { SetRelatedEntities("lk_msdyn_aibdatasetrecord_createdby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_msdyn_aibdatasetrecord_createdonbehalfby'
        /// </summary>
		[RelationshipSchemaName("lk_msdyn_aibdatasetrecord_createdonbehalfby")]
		public IEnumerable<AIBuilderDatasetRecord> LkMsdynAibdatasetrecordCreatedonbehalfby
		{
			get { return GetRelatedEntities<AIBuilderDatasetRecord>("lk_msdyn_aibdatasetrecord_createdonbehalfby", null); }
			set { SetRelatedEntities("lk_msdyn_aibdatasetrecord_createdonbehalfby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_msdyn_aibdatasetrecord_modifiedby'
        /// </summary>
		[RelationshipSchemaName("lk_msdyn_aibdatasetrecord_modifiedby")]
		public IEnumerable<AIBuilderDatasetRecord> LkMsdynAibdatasetrecordModifiedby
		{
			get { return GetRelatedEntities<AIBuilderDatasetRecord>("lk_msdyn_aibdatasetrecord_modifiedby", null); }
			set { SetRelatedEntities("lk_msdyn_aibdatasetrecord_modifiedby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_msdyn_aibdatasetrecord_modifiedonbehalfby'
        /// </summary>
		[RelationshipSchemaName("lk_msdyn_aibdatasetrecord_modifiedonbehalfby")]
		public IEnumerable<AIBuilderDatasetRecord> LkMsdynAibdatasetrecordModifiedonbehalfby
		{
			get { return GetRelatedEntities<AIBuilderDatasetRecord>("lk_msdyn_aibdatasetrecord_modifiedonbehalfby", null); }
			set { SetRelatedEntities("lk_msdyn_aibdatasetrecord_modifiedonbehalfby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_msdyn_aibdatasetscontainer_createdby'
        /// </summary>
		[RelationshipSchemaName("lk_msdyn_aibdatasetscontainer_createdby")]
		public IEnumerable<AIBuilderDatasetsContainer> LkMsdynAibdatasetscontainerCreatedby
		{
			get { return GetRelatedEntities<AIBuilderDatasetsContainer>("lk_msdyn_aibdatasetscontainer_createdby", null); }
			set { SetRelatedEntities("lk_msdyn_aibdatasetscontainer_createdby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_msdyn_aibdatasetscontainer_createdonbehalfby'
        /// </summary>
		[RelationshipSchemaName("lk_msdyn_aibdatasetscontainer_createdonbehalfby")]
		public IEnumerable<AIBuilderDatasetsContainer> LkMsdynAibdatasetscontainerCreatedonbehalfby
		{
			get { return GetRelatedEntities<AIBuilderDatasetsContainer>("lk_msdyn_aibdatasetscontainer_createdonbehalfby", null); }
			set { SetRelatedEntities("lk_msdyn_aibdatasetscontainer_createdonbehalfby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_msdyn_aibdatasetscontainer_modifiedby'
        /// </summary>
		[RelationshipSchemaName("lk_msdyn_aibdatasetscontainer_modifiedby")]
		public IEnumerable<AIBuilderDatasetsContainer> LkMsdynAibdatasetscontainerModifiedby
		{
			get { return GetRelatedEntities<AIBuilderDatasetsContainer>("lk_msdyn_aibdatasetscontainer_modifiedby", null); }
			set { SetRelatedEntities("lk_msdyn_aibdatasetscontainer_modifiedby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_msdyn_aibdatasetscontainer_modifiedonbehalfby'
        /// </summary>
		[RelationshipSchemaName("lk_msdyn_aibdatasetscontainer_modifiedonbehalfby")]
		public IEnumerable<AIBuilderDatasetsContainer> LkMsdynAibdatasetscontainerModifiedonbehalfby
		{
			get { return GetRelatedEntities<AIBuilderDatasetsContainer>("lk_msdyn_aibdatasetscontainer_modifiedonbehalfby", null); }
			set { SetRelatedEntities("lk_msdyn_aibdatasetscontainer_modifiedonbehalfby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_msdyn_aibfile_createdby'
        /// </summary>
		[RelationshipSchemaName("lk_msdyn_aibfile_createdby")]
		public IEnumerable<AIBuilderFile> LkMsdynAibfileCreatedby
		{
			get { return GetRelatedEntities<AIBuilderFile>("lk_msdyn_aibfile_createdby", null); }
			set { SetRelatedEntities("lk_msdyn_aibfile_createdby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_msdyn_aibfile_createdonbehalfby'
        /// </summary>
		[RelationshipSchemaName("lk_msdyn_aibfile_createdonbehalfby")]
		public IEnumerable<AIBuilderFile> LkMsdynAibfileCreatedonbehalfby
		{
			get { return GetRelatedEntities<AIBuilderFile>("lk_msdyn_aibfile_createdonbehalfby", null); }
			set { SetRelatedEntities("lk_msdyn_aibfile_createdonbehalfby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_msdyn_aibfile_modifiedby'
        /// </summary>
		[RelationshipSchemaName("lk_msdyn_aibfile_modifiedby")]
		public IEnumerable<AIBuilderFile> LkMsdynAibfileModifiedby
		{
			get { return GetRelatedEntities<AIBuilderFile>("lk_msdyn_aibfile_modifiedby", null); }
			set { SetRelatedEntities("lk_msdyn_aibfile_modifiedby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_msdyn_aibfile_modifiedonbehalfby'
        /// </summary>
		[RelationshipSchemaName("lk_msdyn_aibfile_modifiedonbehalfby")]
		public IEnumerable<AIBuilderFile> LkMsdynAibfileModifiedonbehalfby
		{
			get { return GetRelatedEntities<AIBuilderFile>("lk_msdyn_aibfile_modifiedonbehalfby", null); }
			set { SetRelatedEntities("lk_msdyn_aibfile_modifiedonbehalfby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_msdyn_aibfileattacheddata_createdby'
        /// </summary>
		[RelationshipSchemaName("lk_msdyn_aibfileattacheddata_createdby")]
		public IEnumerable<AIBuilderFileAttachedData> LkMsdynAibfileattacheddataCreatedby
		{
			get { return GetRelatedEntities<AIBuilderFileAttachedData>("lk_msdyn_aibfileattacheddata_createdby", null); }
			set { SetRelatedEntities("lk_msdyn_aibfileattacheddata_createdby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_msdyn_aibfileattacheddata_createdonbehalfby'
        /// </summary>
		[RelationshipSchemaName("lk_msdyn_aibfileattacheddata_createdonbehalfby")]
		public IEnumerable<AIBuilderFileAttachedData> LkMsdynAibfileattacheddataCreatedonbehalfby
		{
			get { return GetRelatedEntities<AIBuilderFileAttachedData>("lk_msdyn_aibfileattacheddata_createdonbehalfby", null); }
			set { SetRelatedEntities("lk_msdyn_aibfileattacheddata_createdonbehalfby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_msdyn_aibfileattacheddata_modifiedby'
        /// </summary>
		[RelationshipSchemaName("lk_msdyn_aibfileattacheddata_modifiedby")]
		public IEnumerable<AIBuilderFileAttachedData> LkMsdynAibfileattacheddataModifiedby
		{
			get { return GetRelatedEntities<AIBuilderFileAttachedData>("lk_msdyn_aibfileattacheddata_modifiedby", null); }
			set { SetRelatedEntities("lk_msdyn_aibfileattacheddata_modifiedby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_msdyn_aibfileattacheddata_modifiedonbehalfby'
        /// </summary>
		[RelationshipSchemaName("lk_msdyn_aibfileattacheddata_modifiedonbehalfby")]
		public IEnumerable<AIBuilderFileAttachedData> LkMsdynAibfileattacheddataModifiedonbehalfby
		{
			get { return GetRelatedEntities<AIBuilderFileAttachedData>("lk_msdyn_aibfileattacheddata_modifiedonbehalfby", null); }
			set { SetRelatedEntities("lk_msdyn_aibfileattacheddata_modifiedonbehalfby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_msdyn_aiconfiguration_createdby'
        /// </summary>
		[RelationshipSchemaName("lk_msdyn_aiconfiguration_createdby")]
		public IEnumerable<AIConfiguration> LkMsdynAiconfigurationCreatedby
		{
			get { return GetRelatedEntities<AIConfiguration>("lk_msdyn_aiconfiguration_createdby", null); }
			set { SetRelatedEntities("lk_msdyn_aiconfiguration_createdby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_msdyn_aiconfiguration_createdonbehalfby'
        /// </summary>
		[RelationshipSchemaName("lk_msdyn_aiconfiguration_createdonbehalfby")]
		public IEnumerable<AIConfiguration> LkMsdynAiconfigurationCreatedonbehalfby
		{
			get { return GetRelatedEntities<AIConfiguration>("lk_msdyn_aiconfiguration_createdonbehalfby", null); }
			set { SetRelatedEntities("lk_msdyn_aiconfiguration_createdonbehalfby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_msdyn_aiconfiguration_modifiedby'
        /// </summary>
		[RelationshipSchemaName("lk_msdyn_aiconfiguration_modifiedby")]
		public IEnumerable<AIConfiguration> LkMsdynAiconfigurationModifiedby
		{
			get { return GetRelatedEntities<AIConfiguration>("lk_msdyn_aiconfiguration_modifiedby", null); }
			set { SetRelatedEntities("lk_msdyn_aiconfiguration_modifiedby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_msdyn_aiconfiguration_modifiedonbehalfby'
        /// </summary>
		[RelationshipSchemaName("lk_msdyn_aiconfiguration_modifiedonbehalfby")]
		public IEnumerable<AIConfiguration> LkMsdynAiconfigurationModifiedonbehalfby
		{
			get { return GetRelatedEntities<AIConfiguration>("lk_msdyn_aiconfiguration_modifiedonbehalfby", null); }
			set { SetRelatedEntities("lk_msdyn_aiconfiguration_modifiedonbehalfby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_msdyn_aifptrainingdocument_createdby'
        /// </summary>
		[RelationshipSchemaName("lk_msdyn_aifptrainingdocument_createdby")]
		public IEnumerable<AIFormProcessingDocument> LkMsdynAifptrainingdocumentCreatedby
		{
			get { return GetRelatedEntities<AIFormProcessingDocument>("lk_msdyn_aifptrainingdocument_createdby", null); }
			set { SetRelatedEntities("lk_msdyn_aifptrainingdocument_createdby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_msdyn_aifptrainingdocument_createdonbehalfby'
        /// </summary>
		[RelationshipSchemaName("lk_msdyn_aifptrainingdocument_createdonbehalfby")]
		public IEnumerable<AIFormProcessingDocument> LkMsdynAifptrainingdocumentCreatedonbehalfby
		{
			get { return GetRelatedEntities<AIFormProcessingDocument>("lk_msdyn_aifptrainingdocument_createdonbehalfby", null); }
			set { SetRelatedEntities("lk_msdyn_aifptrainingdocument_createdonbehalfby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_msdyn_aifptrainingdocument_modifiedby'
        /// </summary>
		[RelationshipSchemaName("lk_msdyn_aifptrainingdocument_modifiedby")]
		public IEnumerable<AIFormProcessingDocument> LkMsdynAifptrainingdocumentModifiedby
		{
			get { return GetRelatedEntities<AIFormProcessingDocument>("lk_msdyn_aifptrainingdocument_modifiedby", null); }
			set { SetRelatedEntities("lk_msdyn_aifptrainingdocument_modifiedby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_msdyn_aifptrainingdocument_modifiedonbehalfby'
        /// </summary>
		[RelationshipSchemaName("lk_msdyn_aifptrainingdocument_modifiedonbehalfby")]
		public IEnumerable<AIFormProcessingDocument> LkMsdynAifptrainingdocumentModifiedonbehalfby
		{
			get { return GetRelatedEntities<AIFormProcessingDocument>("lk_msdyn_aifptrainingdocument_modifiedonbehalfby", null); }
			set { SetRelatedEntities("lk_msdyn_aifptrainingdocument_modifiedonbehalfby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_msdyn_aimodel_createdby'
        /// </summary>
		[RelationshipSchemaName("lk_msdyn_aimodel_createdby")]
		public IEnumerable<AIModel> LkMsdynAimodelCreatedby
		{
			get { return GetRelatedEntities<AIModel>("lk_msdyn_aimodel_createdby", null); }
			set { SetRelatedEntities("lk_msdyn_aimodel_createdby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_msdyn_aimodel_createdonbehalfby'
        /// </summary>
		[RelationshipSchemaName("lk_msdyn_aimodel_createdonbehalfby")]
		public IEnumerable<AIModel> LkMsdynAimodelCreatedonbehalfby
		{
			get { return GetRelatedEntities<AIModel>("lk_msdyn_aimodel_createdonbehalfby", null); }
			set { SetRelatedEntities("lk_msdyn_aimodel_createdonbehalfby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_msdyn_aimodel_modifiedby'
        /// </summary>
		[RelationshipSchemaName("lk_msdyn_aimodel_modifiedby")]
		public IEnumerable<AIModel> LkMsdynAimodelModifiedby
		{
			get { return GetRelatedEntities<AIModel>("lk_msdyn_aimodel_modifiedby", null); }
			set { SetRelatedEntities("lk_msdyn_aimodel_modifiedby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_msdyn_aimodel_modifiedonbehalfby'
        /// </summary>
		[RelationshipSchemaName("lk_msdyn_aimodel_modifiedonbehalfby")]
		public IEnumerable<AIModel> LkMsdynAimodelModifiedonbehalfby
		{
			get { return GetRelatedEntities<AIModel>("lk_msdyn_aimodel_modifiedonbehalfby", null); }
			set { SetRelatedEntities("lk_msdyn_aimodel_modifiedonbehalfby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_msdyn_aiodimage_createdby'
        /// </summary>
		[RelationshipSchemaName("lk_msdyn_aiodimage_createdby")]
		public IEnumerable<AIObjectDetectionImage> LkMsdynAiodimageCreatedby
		{
			get { return GetRelatedEntities<AIObjectDetectionImage>("lk_msdyn_aiodimage_createdby", null); }
			set { SetRelatedEntities("lk_msdyn_aiodimage_createdby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_msdyn_aiodimage_createdonbehalfby'
        /// </summary>
		[RelationshipSchemaName("lk_msdyn_aiodimage_createdonbehalfby")]
		public IEnumerable<AIObjectDetectionImage> LkMsdynAiodimageCreatedonbehalfby
		{
			get { return GetRelatedEntities<AIObjectDetectionImage>("lk_msdyn_aiodimage_createdonbehalfby", null); }
			set { SetRelatedEntities("lk_msdyn_aiodimage_createdonbehalfby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_msdyn_aiodimage_modifiedby'
        /// </summary>
		[RelationshipSchemaName("lk_msdyn_aiodimage_modifiedby")]
		public IEnumerable<AIObjectDetectionImage> LkMsdynAiodimageModifiedby
		{
			get { return GetRelatedEntities<AIObjectDetectionImage>("lk_msdyn_aiodimage_modifiedby", null); }
			set { SetRelatedEntities("lk_msdyn_aiodimage_modifiedby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_msdyn_aiodimage_modifiedonbehalfby'
        /// </summary>
		[RelationshipSchemaName("lk_msdyn_aiodimage_modifiedonbehalfby")]
		public IEnumerable<AIObjectDetectionImage> LkMsdynAiodimageModifiedonbehalfby
		{
			get { return GetRelatedEntities<AIObjectDetectionImage>("lk_msdyn_aiodimage_modifiedonbehalfby", null); }
			set { SetRelatedEntities("lk_msdyn_aiodimage_modifiedonbehalfby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_msdyn_aiodlabel_createdby'
        /// </summary>
		[RelationshipSchemaName("lk_msdyn_aiodlabel_createdby")]
		public IEnumerable<AIObjectDetectionLabel> LkMsdynAiodlabelCreatedby
		{
			get { return GetRelatedEntities<AIObjectDetectionLabel>("lk_msdyn_aiodlabel_createdby", null); }
			set { SetRelatedEntities("lk_msdyn_aiodlabel_createdby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_msdyn_aiodlabel_createdonbehalfby'
        /// </summary>
		[RelationshipSchemaName("lk_msdyn_aiodlabel_createdonbehalfby")]
		public IEnumerable<AIObjectDetectionLabel> LkMsdynAiodlabelCreatedonbehalfby
		{
			get { return GetRelatedEntities<AIObjectDetectionLabel>("lk_msdyn_aiodlabel_createdonbehalfby", null); }
			set { SetRelatedEntities("lk_msdyn_aiodlabel_createdonbehalfby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_msdyn_aiodlabel_modifiedby'
        /// </summary>
		[RelationshipSchemaName("lk_msdyn_aiodlabel_modifiedby")]
		public IEnumerable<AIObjectDetectionLabel> LkMsdynAiodlabelModifiedby
		{
			get { return GetRelatedEntities<AIObjectDetectionLabel>("lk_msdyn_aiodlabel_modifiedby", null); }
			set { SetRelatedEntities("lk_msdyn_aiodlabel_modifiedby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_msdyn_aiodlabel_modifiedonbehalfby'
        /// </summary>
		[RelationshipSchemaName("lk_msdyn_aiodlabel_modifiedonbehalfby")]
		public IEnumerable<AIObjectDetectionLabel> LkMsdynAiodlabelModifiedonbehalfby
		{
			get { return GetRelatedEntities<AIObjectDetectionLabel>("lk_msdyn_aiodlabel_modifiedonbehalfby", null); }
			set { SetRelatedEntities("lk_msdyn_aiodlabel_modifiedonbehalfby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_msdyn_aiodtrainingboundingbox_createdby'
        /// </summary>
		[RelationshipSchemaName("lk_msdyn_aiodtrainingboundingbox_createdby")]
		public IEnumerable<AIObjectDetectionBoundingBox> LkMsdynAiodtrainingboundingboxCreatedby
		{
			get { return GetRelatedEntities<AIObjectDetectionBoundingBox>("lk_msdyn_aiodtrainingboundingbox_createdby", null); }
			set { SetRelatedEntities("lk_msdyn_aiodtrainingboundingbox_createdby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_msdyn_aiodtrainingboundingbox_createdonbehalfby'
        /// </summary>
		[RelationshipSchemaName("lk_msdyn_aiodtrainingboundingbox_createdonbehalfby")]
		public IEnumerable<AIObjectDetectionBoundingBox> LkMsdynAiodtrainingboundingboxCreatedonbehalfby
		{
			get { return GetRelatedEntities<AIObjectDetectionBoundingBox>("lk_msdyn_aiodtrainingboundingbox_createdonbehalfby", null); }
			set { SetRelatedEntities("lk_msdyn_aiodtrainingboundingbox_createdonbehalfby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_msdyn_aiodtrainingboundingbox_modifiedby'
        /// </summary>
		[RelationshipSchemaName("lk_msdyn_aiodtrainingboundingbox_modifiedby")]
		public IEnumerable<AIObjectDetectionBoundingBox> LkMsdynAiodtrainingboundingboxModifiedby
		{
			get { return GetRelatedEntities<AIObjectDetectionBoundingBox>("lk_msdyn_aiodtrainingboundingbox_modifiedby", null); }
			set { SetRelatedEntities("lk_msdyn_aiodtrainingboundingbox_modifiedby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_msdyn_aiodtrainingboundingbox_modifiedonbehalfby'
        /// </summary>
		[RelationshipSchemaName("lk_msdyn_aiodtrainingboundingbox_modifiedonbehalfby")]
		public IEnumerable<AIObjectDetectionBoundingBox> LkMsdynAiodtrainingboundingboxModifiedonbehalfby
		{
			get { return GetRelatedEntities<AIObjectDetectionBoundingBox>("lk_msdyn_aiodtrainingboundingbox_modifiedonbehalfby", null); }
			set { SetRelatedEntities("lk_msdyn_aiodtrainingboundingbox_modifiedonbehalfby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_msdyn_aiodtrainingimage_createdby'
        /// </summary>
		[RelationshipSchemaName("lk_msdyn_aiodtrainingimage_createdby")]
		public IEnumerable<AIObjectDetectionImageMapping> LkMsdynAiodtrainingimageCreatedby
		{
			get { return GetRelatedEntities<AIObjectDetectionImageMapping>("lk_msdyn_aiodtrainingimage_createdby", null); }
			set { SetRelatedEntities("lk_msdyn_aiodtrainingimage_createdby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_msdyn_aiodtrainingimage_createdonbehalfby'
        /// </summary>
		[RelationshipSchemaName("lk_msdyn_aiodtrainingimage_createdonbehalfby")]
		public IEnumerable<AIObjectDetectionImageMapping> LkMsdynAiodtrainingimageCreatedonbehalfby
		{
			get { return GetRelatedEntities<AIObjectDetectionImageMapping>("lk_msdyn_aiodtrainingimage_createdonbehalfby", null); }
			set { SetRelatedEntities("lk_msdyn_aiodtrainingimage_createdonbehalfby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_msdyn_aiodtrainingimage_modifiedby'
        /// </summary>
		[RelationshipSchemaName("lk_msdyn_aiodtrainingimage_modifiedby")]
		public IEnumerable<AIObjectDetectionImageMapping> LkMsdynAiodtrainingimageModifiedby
		{
			get { return GetRelatedEntities<AIObjectDetectionImageMapping>("lk_msdyn_aiodtrainingimage_modifiedby", null); }
			set { SetRelatedEntities("lk_msdyn_aiodtrainingimage_modifiedby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_msdyn_aiodtrainingimage_modifiedonbehalfby'
        /// </summary>
		[RelationshipSchemaName("lk_msdyn_aiodtrainingimage_modifiedonbehalfby")]
		public IEnumerable<AIObjectDetectionImageMapping> LkMsdynAiodtrainingimageModifiedonbehalfby
		{
			get { return GetRelatedEntities<AIObjectDetectionImageMapping>("lk_msdyn_aiodtrainingimage_modifiedonbehalfby", null); }
			set { SetRelatedEntities("lk_msdyn_aiodtrainingimage_modifiedonbehalfby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_msdyn_aitemplate_createdby'
        /// </summary>
		[RelationshipSchemaName("lk_msdyn_aitemplate_createdby")]
		public IEnumerable<AITemplate> LkMsdynAitemplateCreatedby
		{
			get { return GetRelatedEntities<AITemplate>("lk_msdyn_aitemplate_createdby", null); }
			set { SetRelatedEntities("lk_msdyn_aitemplate_createdby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_msdyn_aitemplate_createdonbehalfby'
        /// </summary>
		[RelationshipSchemaName("lk_msdyn_aitemplate_createdonbehalfby")]
		public IEnumerable<AITemplate> LkMsdynAitemplateCreatedonbehalfby
		{
			get { return GetRelatedEntities<AITemplate>("lk_msdyn_aitemplate_createdonbehalfby", null); }
			set { SetRelatedEntities("lk_msdyn_aitemplate_createdonbehalfby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_msdyn_aitemplate_modifiedby'
        /// </summary>
		[RelationshipSchemaName("lk_msdyn_aitemplate_modifiedby")]
		public IEnumerable<AITemplate> LkMsdynAitemplateModifiedby
		{
			get { return GetRelatedEntities<AITemplate>("lk_msdyn_aitemplate_modifiedby", null); }
			set { SetRelatedEntities("lk_msdyn_aitemplate_modifiedby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_msdyn_aitemplate_modifiedonbehalfby'
        /// </summary>
		[RelationshipSchemaName("lk_msdyn_aitemplate_modifiedonbehalfby")]
		public IEnumerable<AITemplate> LkMsdynAitemplateModifiedonbehalfby
		{
			get { return GetRelatedEntities<AITemplate>("lk_msdyn_aitemplate_modifiedonbehalfby", null); }
			set { SetRelatedEntities("lk_msdyn_aitemplate_modifiedonbehalfby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_msdyn_autocapturerule_createdby'
        /// </summary>
		[RelationshipSchemaName("lk_msdyn_autocapturerule_createdby")]
		public IEnumerable<AutoCaptureRule> LkMsdynAutocaptureruleCreatedby
		{
			get { return GetRelatedEntities<AutoCaptureRule>("lk_msdyn_autocapturerule_createdby", null); }
			set { SetRelatedEntities("lk_msdyn_autocapturerule_createdby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_msdyn_autocapturerule_createdonbehalfby'
        /// </summary>
		[RelationshipSchemaName("lk_msdyn_autocapturerule_createdonbehalfby")]
		public IEnumerable<AutoCaptureRule> LkMsdynAutocaptureruleCreatedonbehalfby
		{
			get { return GetRelatedEntities<AutoCaptureRule>("lk_msdyn_autocapturerule_createdonbehalfby", null); }
			set { SetRelatedEntities("lk_msdyn_autocapturerule_createdonbehalfby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_msdyn_autocapturerule_modifiedby'
        /// </summary>
		[RelationshipSchemaName("lk_msdyn_autocapturerule_modifiedby")]
		public IEnumerable<AutoCaptureRule> LkMsdynAutocaptureruleModifiedby
		{
			get { return GetRelatedEntities<AutoCaptureRule>("lk_msdyn_autocapturerule_modifiedby", null); }
			set { SetRelatedEntities("lk_msdyn_autocapturerule_modifiedby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_msdyn_autocapturerule_modifiedonbehalfby'
        /// </summary>
		[RelationshipSchemaName("lk_msdyn_autocapturerule_modifiedonbehalfby")]
		public IEnumerable<AutoCaptureRule> LkMsdynAutocaptureruleModifiedonbehalfby
		{
			get { return GetRelatedEntities<AutoCaptureRule>("lk_msdyn_autocapturerule_modifiedonbehalfby", null); }
			set { SetRelatedEntities("lk_msdyn_autocapturerule_modifiedonbehalfby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_msdyn_autocapturesettings_createdby'
        /// </summary>
		[RelationshipSchemaName("lk_msdyn_autocapturesettings_createdby")]
		public IEnumerable<AutoCaptureSettings> LkMsdynAutocapturesettingsCreatedby
		{
			get { return GetRelatedEntities<AutoCaptureSettings>("lk_msdyn_autocapturesettings_createdby", null); }
			set { SetRelatedEntities("lk_msdyn_autocapturesettings_createdby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_msdyn_autocapturesettings_createdonbehalfby'
        /// </summary>
		[RelationshipSchemaName("lk_msdyn_autocapturesettings_createdonbehalfby")]
		public IEnumerable<AutoCaptureSettings> LkMsdynAutocapturesettingsCreatedonbehalfby
		{
			get { return GetRelatedEntities<AutoCaptureSettings>("lk_msdyn_autocapturesettings_createdonbehalfby", null); }
			set { SetRelatedEntities("lk_msdyn_autocapturesettings_createdonbehalfby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_msdyn_autocapturesettings_modifiedby'
        /// </summary>
		[RelationshipSchemaName("lk_msdyn_autocapturesettings_modifiedby")]
		public IEnumerable<AutoCaptureSettings> LkMsdynAutocapturesettingsModifiedby
		{
			get { return GetRelatedEntities<AutoCaptureSettings>("lk_msdyn_autocapturesettings_modifiedby", null); }
			set { SetRelatedEntities("lk_msdyn_autocapturesettings_modifiedby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_msdyn_autocapturesettings_modifiedonbehalfby'
        /// </summary>
		[RelationshipSchemaName("lk_msdyn_autocapturesettings_modifiedonbehalfby")]
		public IEnumerable<AutoCaptureSettings> LkMsdynAutocapturesettingsModifiedonbehalfby
		{
			get { return GetRelatedEntities<AutoCaptureSettings>("lk_msdyn_autocapturesettings_modifiedonbehalfby", null); }
			set { SetRelatedEntities("lk_msdyn_autocapturesettings_modifiedonbehalfby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_msdyn_callablecontext_createdby'
        /// </summary>
		[RelationshipSchemaName("lk_msdyn_callablecontext_createdby")]
		public IEnumerable<PlaybookCallableContext> LkMsdynCallablecontextCreatedby
		{
			get { return GetRelatedEntities<PlaybookCallableContext>("lk_msdyn_callablecontext_createdby", null); }
			set { SetRelatedEntities("lk_msdyn_callablecontext_createdby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_msdyn_callablecontext_createdonbehalfby'
        /// </summary>
		[RelationshipSchemaName("lk_msdyn_callablecontext_createdonbehalfby")]
		public IEnumerable<PlaybookCallableContext> LkMsdynCallablecontextCreatedonbehalfby
		{
			get { return GetRelatedEntities<PlaybookCallableContext>("lk_msdyn_callablecontext_createdonbehalfby", null); }
			set { SetRelatedEntities("lk_msdyn_callablecontext_createdonbehalfby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_msdyn_callablecontext_modifiedby'
        /// </summary>
		[RelationshipSchemaName("lk_msdyn_callablecontext_modifiedby")]
		public IEnumerable<PlaybookCallableContext> LkMsdynCallablecontextModifiedby
		{
			get { return GetRelatedEntities<PlaybookCallableContext>("lk_msdyn_callablecontext_modifiedby", null); }
			set { SetRelatedEntities("lk_msdyn_callablecontext_modifiedby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_msdyn_callablecontext_modifiedonbehalfby'
        /// </summary>
		[RelationshipSchemaName("lk_msdyn_callablecontext_modifiedonbehalfby")]
		public IEnumerable<PlaybookCallableContext> LkMsdynCallablecontextModifiedonbehalfby
		{
			get { return GetRelatedEntities<PlaybookCallableContext>("lk_msdyn_callablecontext_modifiedonbehalfby", null); }
			set { SetRelatedEntities("lk_msdyn_callablecontext_modifiedonbehalfby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_msdyn_collabgraphresource_createdby'
        /// </summary>
		[RelationshipSchemaName("lk_msdyn_collabgraphresource_createdby")]
		public IEnumerable<MicrosoftTeamsGraphResourceEntity> LkMsdynCollabgraphresourceCreatedby
		{
			get { return GetRelatedEntities<MicrosoftTeamsGraphResourceEntity>("lk_msdyn_collabgraphresource_createdby", null); }
			set { SetRelatedEntities("lk_msdyn_collabgraphresource_createdby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_msdyn_collabgraphresource_createdonbehalfby'
        /// </summary>
		[RelationshipSchemaName("lk_msdyn_collabgraphresource_createdonbehalfby")]
		public IEnumerable<MicrosoftTeamsGraphResourceEntity> LkMsdynCollabgraphresourceCreatedonbehalfby
		{
			get { return GetRelatedEntities<MicrosoftTeamsGraphResourceEntity>("lk_msdyn_collabgraphresource_createdonbehalfby", null); }
			set { SetRelatedEntities("lk_msdyn_collabgraphresource_createdonbehalfby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_msdyn_collabgraphresource_modifiedby'
        /// </summary>
		[RelationshipSchemaName("lk_msdyn_collabgraphresource_modifiedby")]
		public IEnumerable<MicrosoftTeamsGraphResourceEntity> LkMsdynCollabgraphresourceModifiedby
		{
			get { return GetRelatedEntities<MicrosoftTeamsGraphResourceEntity>("lk_msdyn_collabgraphresource_modifiedby", null); }
			set { SetRelatedEntities("lk_msdyn_collabgraphresource_modifiedby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_msdyn_collabgraphresource_modifiedonbehalfby'
        /// </summary>
		[RelationshipSchemaName("lk_msdyn_collabgraphresource_modifiedonbehalfby")]
		public IEnumerable<MicrosoftTeamsGraphResourceEntity> LkMsdynCollabgraphresourceModifiedonbehalfby
		{
			get { return GetRelatedEntities<MicrosoftTeamsGraphResourceEntity>("lk_msdyn_collabgraphresource_modifiedonbehalfby", null); }
			set { SetRelatedEntities("lk_msdyn_collabgraphresource_modifiedonbehalfby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_msdyn_databaseversion_createdby'
        /// </summary>
		[RelationshipSchemaName("lk_msdyn_databaseversion_createdby")]
		public IEnumerable<DatabaseVersion> LkMsdynDatabaseversionCreatedby
		{
			get { return GetRelatedEntities<DatabaseVersion>("lk_msdyn_databaseversion_createdby", null); }
			set { SetRelatedEntities("lk_msdyn_databaseversion_createdby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_msdyn_databaseversion_createdonbehalfby'
        /// </summary>
		[RelationshipSchemaName("lk_msdyn_databaseversion_createdonbehalfby")]
		public IEnumerable<DatabaseVersion> LkMsdynDatabaseversionCreatedonbehalfby
		{
			get { return GetRelatedEntities<DatabaseVersion>("lk_msdyn_databaseversion_createdonbehalfby", null); }
			set { SetRelatedEntities("lk_msdyn_databaseversion_createdonbehalfby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_msdyn_databaseversion_modifiedby'
        /// </summary>
		[RelationshipSchemaName("lk_msdyn_databaseversion_modifiedby")]
		public IEnumerable<DatabaseVersion> LkMsdynDatabaseversionModifiedby
		{
			get { return GetRelatedEntities<DatabaseVersion>("lk_msdyn_databaseversion_modifiedby", null); }
			set { SetRelatedEntities("lk_msdyn_databaseversion_modifiedby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_msdyn_databaseversion_modifiedonbehalfby'
        /// </summary>
		[RelationshipSchemaName("lk_msdyn_databaseversion_modifiedonbehalfby")]
		public IEnumerable<DatabaseVersion> LkMsdynDatabaseversionModifiedonbehalfby
		{
			get { return GetRelatedEntities<DatabaseVersion>("lk_msdyn_databaseversion_modifiedonbehalfby", null); }
			set { SetRelatedEntities("lk_msdyn_databaseversion_modifiedonbehalfby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_msdyn_entityrankingrule_createdby'
        /// </summary>
		[RelationshipSchemaName("lk_msdyn_entityrankingrule_createdby")]
		public IEnumerable<EntityRankingRule> LkMsdynEntityrankingruleCreatedby
		{
			get { return GetRelatedEntities<EntityRankingRule>("lk_msdyn_entityrankingrule_createdby", null); }
			set { SetRelatedEntities("lk_msdyn_entityrankingrule_createdby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_msdyn_entityrankingrule_createdonbehalfby'
        /// </summary>
		[RelationshipSchemaName("lk_msdyn_entityrankingrule_createdonbehalfby")]
		public IEnumerable<EntityRankingRule> LkMsdynEntityrankingruleCreatedonbehalfby
		{
			get { return GetRelatedEntities<EntityRankingRule>("lk_msdyn_entityrankingrule_createdonbehalfby", null); }
			set { SetRelatedEntities("lk_msdyn_entityrankingrule_createdonbehalfby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_msdyn_entityrankingrule_modifiedby'
        /// </summary>
		[RelationshipSchemaName("lk_msdyn_entityrankingrule_modifiedby")]
		public IEnumerable<EntityRankingRule> LkMsdynEntityrankingruleModifiedby
		{
			get { return GetRelatedEntities<EntityRankingRule>("lk_msdyn_entityrankingrule_modifiedby", null); }
			set { SetRelatedEntities("lk_msdyn_entityrankingrule_modifiedby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_msdyn_entityrankingrule_modifiedonbehalfby'
        /// </summary>
		[RelationshipSchemaName("lk_msdyn_entityrankingrule_modifiedonbehalfby")]
		public IEnumerable<EntityRankingRule> LkMsdynEntityrankingruleModifiedonbehalfby
		{
			get { return GetRelatedEntities<EntityRankingRule>("lk_msdyn_entityrankingrule_modifiedonbehalfby", null); }
			set { SetRelatedEntities("lk_msdyn_entityrankingrule_modifiedonbehalfby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_msdyn_federatedarticle_createdby'
        /// </summary>
		[RelationshipSchemaName("lk_msdyn_federatedarticle_createdby")]
		public IEnumerable<KnowledgeFederatedArticle> LkMsdynFederatedarticleCreatedby
		{
			get { return GetRelatedEntities<KnowledgeFederatedArticle>("lk_msdyn_federatedarticle_createdby", null); }
			set { SetRelatedEntities("lk_msdyn_federatedarticle_createdby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_msdyn_federatedarticle_createdonbehalfby'
        /// </summary>
		[RelationshipSchemaName("lk_msdyn_federatedarticle_createdonbehalfby")]
		public IEnumerable<KnowledgeFederatedArticle> LkMsdynFederatedarticleCreatedonbehalfby
		{
			get { return GetRelatedEntities<KnowledgeFederatedArticle>("lk_msdyn_federatedarticle_createdonbehalfby", null); }
			set { SetRelatedEntities("lk_msdyn_federatedarticle_createdonbehalfby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_msdyn_federatedarticle_modifiedby'
        /// </summary>
		[RelationshipSchemaName("lk_msdyn_federatedarticle_modifiedby")]
		public IEnumerable<KnowledgeFederatedArticle> LkMsdynFederatedarticleModifiedby
		{
			get { return GetRelatedEntities<KnowledgeFederatedArticle>("lk_msdyn_federatedarticle_modifiedby", null); }
			set { SetRelatedEntities("lk_msdyn_federatedarticle_modifiedby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_msdyn_federatedarticle_modifiedonbehalfby'
        /// </summary>
		[RelationshipSchemaName("lk_msdyn_federatedarticle_modifiedonbehalfby")]
		public IEnumerable<KnowledgeFederatedArticle> LkMsdynFederatedarticleModifiedonbehalfby
		{
			get { return GetRelatedEntities<KnowledgeFederatedArticle>("lk_msdyn_federatedarticle_modifiedonbehalfby", null); }
			set { SetRelatedEntities("lk_msdyn_federatedarticle_modifiedonbehalfby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_msdyn_federatedarticleincident_createdby'
        /// </summary>
		[RelationshipSchemaName("lk_msdyn_federatedarticleincident_createdby")]
		public IEnumerable<KnowledgeFederatedArticleIncident> LkMsdynFederatedarticleincidentCreatedby
		{
			get { return GetRelatedEntities<KnowledgeFederatedArticleIncident>("lk_msdyn_federatedarticleincident_createdby", null); }
			set { SetRelatedEntities("lk_msdyn_federatedarticleincident_createdby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_msdyn_federatedarticleincident_createdonbehalfby'
        /// </summary>
		[RelationshipSchemaName("lk_msdyn_federatedarticleincident_createdonbehalfby")]
		public IEnumerable<KnowledgeFederatedArticleIncident> LkMsdynFederatedarticleincidentCreatedonbehalfby
		{
			get { return GetRelatedEntities<KnowledgeFederatedArticleIncident>("lk_msdyn_federatedarticleincident_createdonbehalfby", null); }
			set { SetRelatedEntities("lk_msdyn_federatedarticleincident_createdonbehalfby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_msdyn_federatedarticleincident_modifiedby'
        /// </summary>
		[RelationshipSchemaName("lk_msdyn_federatedarticleincident_modifiedby")]
		public IEnumerable<KnowledgeFederatedArticleIncident> LkMsdynFederatedarticleincidentModifiedby
		{
			get { return GetRelatedEntities<KnowledgeFederatedArticleIncident>("lk_msdyn_federatedarticleincident_modifiedby", null); }
			set { SetRelatedEntities("lk_msdyn_federatedarticleincident_modifiedby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_msdyn_federatedarticleincident_modifiedonbehalfby'
        /// </summary>
		[RelationshipSchemaName("lk_msdyn_federatedarticleincident_modifiedonbehalfby")]
		public IEnumerable<KnowledgeFederatedArticleIncident> LkMsdynFederatedarticleincidentModifiedonbehalfby
		{
			get { return GetRelatedEntities<KnowledgeFederatedArticleIncident>("lk_msdyn_federatedarticleincident_modifiedonbehalfby", null); }
			set { SetRelatedEntities("lk_msdyn_federatedarticleincident_modifiedonbehalfby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_msdyn_flowcardtype_createdby'
        /// </summary>
		[RelationshipSchemaName("lk_msdyn_flowcardtype_createdby")]
		public IEnumerable<Flowcardtype> LkMsdynFlowcardtypeCreatedby
		{
			get { return GetRelatedEntities<Flowcardtype>("lk_msdyn_flowcardtype_createdby", null); }
			set { SetRelatedEntities("lk_msdyn_flowcardtype_createdby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_msdyn_flowcardtype_createdonbehalfby'
        /// </summary>
		[RelationshipSchemaName("lk_msdyn_flowcardtype_createdonbehalfby")]
		public IEnumerable<Flowcardtype> LkMsdynFlowcardtypeCreatedonbehalfby
		{
			get { return GetRelatedEntities<Flowcardtype>("lk_msdyn_flowcardtype_createdonbehalfby", null); }
			set { SetRelatedEntities("lk_msdyn_flowcardtype_createdonbehalfby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_msdyn_flowcardtype_modifiedby'
        /// </summary>
		[RelationshipSchemaName("lk_msdyn_flowcardtype_modifiedby")]
		public IEnumerable<Flowcardtype> LkMsdynFlowcardtypeModifiedby
		{
			get { return GetRelatedEntities<Flowcardtype>("lk_msdyn_flowcardtype_modifiedby", null); }
			set { SetRelatedEntities("lk_msdyn_flowcardtype_modifiedby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_msdyn_flowcardtype_modifiedonbehalfby'
        /// </summary>
		[RelationshipSchemaName("lk_msdyn_flowcardtype_modifiedonbehalfby")]
		public IEnumerable<Flowcardtype> LkMsdynFlowcardtypeModifiedonbehalfby
		{
			get { return GetRelatedEntities<Flowcardtype>("lk_msdyn_flowcardtype_modifiedonbehalfby", null); }
			set { SetRelatedEntities("lk_msdyn_flowcardtype_modifiedonbehalfby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_msdyn_helppage_createdby'
        /// </summary>
		[RelationshipSchemaName("lk_msdyn_helppage_createdby")]
		public IEnumerable<HelpPage> LkMsdynHelppageCreatedby
		{
			get { return GetRelatedEntities<HelpPage>("lk_msdyn_helppage_createdby", null); }
			set { SetRelatedEntities("lk_msdyn_helppage_createdby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_msdyn_helppage_createdonbehalfby'
        /// </summary>
		[RelationshipSchemaName("lk_msdyn_helppage_createdonbehalfby")]
		public IEnumerable<HelpPage> LkMsdynHelppageCreatedonbehalfby
		{
			get { return GetRelatedEntities<HelpPage>("lk_msdyn_helppage_createdonbehalfby", null); }
			set { SetRelatedEntities("lk_msdyn_helppage_createdonbehalfby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_msdyn_helppage_modifiedby'
        /// </summary>
		[RelationshipSchemaName("lk_msdyn_helppage_modifiedby")]
		public IEnumerable<HelpPage> LkMsdynHelppageModifiedby
		{
			get { return GetRelatedEntities<HelpPage>("lk_msdyn_helppage_modifiedby", null); }
			set { SetRelatedEntities("lk_msdyn_helppage_modifiedby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_msdyn_helppage_modifiedonbehalfby'
        /// </summary>
		[RelationshipSchemaName("lk_msdyn_helppage_modifiedonbehalfby")]
		public IEnumerable<HelpPage> LkMsdynHelppageModifiedonbehalfby
		{
			get { return GetRelatedEntities<HelpPage>("lk_msdyn_helppage_modifiedonbehalfby", null); }
			set { SetRelatedEntities("lk_msdyn_helppage_modifiedonbehalfby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_msdyn_icebreakersconfig_createdby'
        /// </summary>
		[RelationshipSchemaName("lk_msdyn_icebreakersconfig_createdby")]
		public IEnumerable<Icebreakersconfig> LkMsdynIcebreakersconfigCreatedby
		{
			get { return GetRelatedEntities<Icebreakersconfig>("lk_msdyn_icebreakersconfig_createdby", null); }
			set { SetRelatedEntities("lk_msdyn_icebreakersconfig_createdby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_msdyn_icebreakersconfig_createdonbehalfby'
        /// </summary>
		[RelationshipSchemaName("lk_msdyn_icebreakersconfig_createdonbehalfby")]
		public IEnumerable<Icebreakersconfig> LkMsdynIcebreakersconfigCreatedonbehalfby
		{
			get { return GetRelatedEntities<Icebreakersconfig>("lk_msdyn_icebreakersconfig_createdonbehalfby", null); }
			set { SetRelatedEntities("lk_msdyn_icebreakersconfig_createdonbehalfby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_msdyn_icebreakersconfig_modifiedby'
        /// </summary>
		[RelationshipSchemaName("lk_msdyn_icebreakersconfig_modifiedby")]
		public IEnumerable<Icebreakersconfig> LkMsdynIcebreakersconfigModifiedby
		{
			get { return GetRelatedEntities<Icebreakersconfig>("lk_msdyn_icebreakersconfig_modifiedby", null); }
			set { SetRelatedEntities("lk_msdyn_icebreakersconfig_modifiedby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_msdyn_icebreakersconfig_modifiedonbehalfby'
        /// </summary>
		[RelationshipSchemaName("lk_msdyn_icebreakersconfig_modifiedonbehalfby")]
		public IEnumerable<Icebreakersconfig> LkMsdynIcebreakersconfigModifiedonbehalfby
		{
			get { return GetRelatedEntities<Icebreakersconfig>("lk_msdyn_icebreakersconfig_modifiedonbehalfby", null); }
			set { SetRelatedEntities("lk_msdyn_icebreakersconfig_modifiedonbehalfby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_msdyn_kmfederatedsearchconfig_createdby'
        /// </summary>
		[RelationshipSchemaName("lk_msdyn_kmfederatedsearchconfig_createdby")]
		public IEnumerable<SearchProvider> LkMsdynKmfederatedsearchconfigCreatedby
		{
			get { return GetRelatedEntities<SearchProvider>("lk_msdyn_kmfederatedsearchconfig_createdby", null); }
			set { SetRelatedEntities("lk_msdyn_kmfederatedsearchconfig_createdby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_msdyn_kmfederatedsearchconfig_createdonbehalfby'
        /// </summary>
		[RelationshipSchemaName("lk_msdyn_kmfederatedsearchconfig_createdonbehalfby")]
		public IEnumerable<SearchProvider> LkMsdynKmfederatedsearchconfigCreatedonbehalfby
		{
			get { return GetRelatedEntities<SearchProvider>("lk_msdyn_kmfederatedsearchconfig_createdonbehalfby", null); }
			set { SetRelatedEntities("lk_msdyn_kmfederatedsearchconfig_createdonbehalfby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_msdyn_kmfederatedsearchconfig_modifiedby'
        /// </summary>
		[RelationshipSchemaName("lk_msdyn_kmfederatedsearchconfig_modifiedby")]
		public IEnumerable<SearchProvider> LkMsdynKmfederatedsearchconfigModifiedby
		{
			get { return GetRelatedEntities<SearchProvider>("lk_msdyn_kmfederatedsearchconfig_modifiedby", null); }
			set { SetRelatedEntities("lk_msdyn_kmfederatedsearchconfig_modifiedby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_msdyn_kmfederatedsearchconfig_modifiedonbehalfby'
        /// </summary>
		[RelationshipSchemaName("lk_msdyn_kmfederatedsearchconfig_modifiedonbehalfby")]
		public IEnumerable<SearchProvider> LkMsdynKmfederatedsearchconfigModifiedonbehalfby
		{
			get { return GetRelatedEntities<SearchProvider>("lk_msdyn_kmfederatedsearchconfig_modifiedonbehalfby", null); }
			set { SetRelatedEntities("lk_msdyn_kmfederatedsearchconfig_modifiedonbehalfby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_msdyn_knowledgearticleimage_createdby'
        /// </summary>
		[RelationshipSchemaName("lk_msdyn_knowledgearticleimage_createdby")]
		public IEnumerable<KnowledgeArticleImage> LkMsdynKnowledgearticleimageCreatedby
		{
			get { return GetRelatedEntities<KnowledgeArticleImage>("lk_msdyn_knowledgearticleimage_createdby", null); }
			set { SetRelatedEntities("lk_msdyn_knowledgearticleimage_createdby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_msdyn_knowledgearticleimage_createdonbehalfby'
        /// </summary>
		[RelationshipSchemaName("lk_msdyn_knowledgearticleimage_createdonbehalfby")]
		public IEnumerable<KnowledgeArticleImage> LkMsdynKnowledgearticleimageCreatedonbehalfby
		{
			get { return GetRelatedEntities<KnowledgeArticleImage>("lk_msdyn_knowledgearticleimage_createdonbehalfby", null); }
			set { SetRelatedEntities("lk_msdyn_knowledgearticleimage_createdonbehalfby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_msdyn_knowledgearticleimage_modifiedby'
        /// </summary>
		[RelationshipSchemaName("lk_msdyn_knowledgearticleimage_modifiedby")]
		public IEnumerable<KnowledgeArticleImage> LkMsdynKnowledgearticleimageModifiedby
		{
			get { return GetRelatedEntities<KnowledgeArticleImage>("lk_msdyn_knowledgearticleimage_modifiedby", null); }
			set { SetRelatedEntities("lk_msdyn_knowledgearticleimage_modifiedby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_msdyn_knowledgearticleimage_modifiedonbehalfby'
        /// </summary>
		[RelationshipSchemaName("lk_msdyn_knowledgearticleimage_modifiedonbehalfby")]
		public IEnumerable<KnowledgeArticleImage> LkMsdynKnowledgearticleimageModifiedonbehalfby
		{
			get { return GetRelatedEntities<KnowledgeArticleImage>("lk_msdyn_knowledgearticleimage_modifiedonbehalfby", null); }
			set { SetRelatedEntities("lk_msdyn_knowledgearticleimage_modifiedonbehalfby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_msdyn_knowledgearticletemplate_createdby'
        /// </summary>
		[RelationshipSchemaName("lk_msdyn_knowledgearticletemplate_createdby")]
		public IEnumerable<KnowledgeArticleTemplate> LkMsdynKnowledgearticletemplateCreatedby
		{
			get { return GetRelatedEntities<KnowledgeArticleTemplate>("lk_msdyn_knowledgearticletemplate_createdby", null); }
			set { SetRelatedEntities("lk_msdyn_knowledgearticletemplate_createdby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_msdyn_knowledgearticletemplate_createdonbehalfby'
        /// </summary>
		[RelationshipSchemaName("lk_msdyn_knowledgearticletemplate_createdonbehalfby")]
		public IEnumerable<KnowledgeArticleTemplate> LkMsdynKnowledgearticletemplateCreatedonbehalfby
		{
			get { return GetRelatedEntities<KnowledgeArticleTemplate>("lk_msdyn_knowledgearticletemplate_createdonbehalfby", null); }
			set { SetRelatedEntities("lk_msdyn_knowledgearticletemplate_createdonbehalfby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_msdyn_knowledgearticletemplate_modifiedby'
        /// </summary>
		[RelationshipSchemaName("lk_msdyn_knowledgearticletemplate_modifiedby")]
		public IEnumerable<KnowledgeArticleTemplate> LkMsdynKnowledgearticletemplateModifiedby
		{
			get { return GetRelatedEntities<KnowledgeArticleTemplate>("lk_msdyn_knowledgearticletemplate_modifiedby", null); }
			set { SetRelatedEntities("lk_msdyn_knowledgearticletemplate_modifiedby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_msdyn_knowledgearticletemplate_modifiedonbehalfby'
        /// </summary>
		[RelationshipSchemaName("lk_msdyn_knowledgearticletemplate_modifiedonbehalfby")]
		public IEnumerable<KnowledgeArticleTemplate> LkMsdynKnowledgearticletemplateModifiedonbehalfby
		{
			get { return GetRelatedEntities<KnowledgeArticleTemplate>("lk_msdyn_knowledgearticletemplate_modifiedonbehalfby", null); }
			set { SetRelatedEntities("lk_msdyn_knowledgearticletemplate_modifiedonbehalfby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_msdyn_knowledgeinteractioninsight_createdby'
        /// </summary>
		[RelationshipSchemaName("lk_msdyn_knowledgeinteractioninsight_createdby")]
		public IEnumerable<KnowledgeInteractionInsight> LkMsdynKnowledgeinteractioninsightCreatedby
		{
			get { return GetRelatedEntities<KnowledgeInteractionInsight>("lk_msdyn_knowledgeinteractioninsight_createdby", null); }
			set { SetRelatedEntities("lk_msdyn_knowledgeinteractioninsight_createdby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_msdyn_knowledgeinteractioninsight_createdonbehalfby'
        /// </summary>
		[RelationshipSchemaName("lk_msdyn_knowledgeinteractioninsight_createdonbehalfby")]
		public IEnumerable<KnowledgeInteractionInsight> LkMsdynKnowledgeinteractioninsightCreatedonbehalfby
		{
			get { return GetRelatedEntities<KnowledgeInteractionInsight>("lk_msdyn_knowledgeinteractioninsight_createdonbehalfby", null); }
			set { SetRelatedEntities("lk_msdyn_knowledgeinteractioninsight_createdonbehalfby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_msdyn_knowledgeinteractioninsight_modifiedby'
        /// </summary>
		[RelationshipSchemaName("lk_msdyn_knowledgeinteractioninsight_modifiedby")]
		public IEnumerable<KnowledgeInteractionInsight> LkMsdynKnowledgeinteractioninsightModifiedby
		{
			get { return GetRelatedEntities<KnowledgeInteractionInsight>("lk_msdyn_knowledgeinteractioninsight_modifiedby", null); }
			set { SetRelatedEntities("lk_msdyn_knowledgeinteractioninsight_modifiedby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_msdyn_knowledgeinteractioninsight_modifiedonbehalfby'
        /// </summary>
		[RelationshipSchemaName("lk_msdyn_knowledgeinteractioninsight_modifiedonbehalfby")]
		public IEnumerable<KnowledgeInteractionInsight> LkMsdynKnowledgeinteractioninsightModifiedonbehalfby
		{
			get { return GetRelatedEntities<KnowledgeInteractionInsight>("lk_msdyn_knowledgeinteractioninsight_modifiedonbehalfby", null); }
			set { SetRelatedEntities("lk_msdyn_knowledgeinteractioninsight_modifiedonbehalfby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_msdyn_knowledgesearchinsight_createdby'
        /// </summary>
		[RelationshipSchemaName("lk_msdyn_knowledgesearchinsight_createdby")]
		public IEnumerable<KnowledgeSearchInsight> LkMsdynKnowledgesearchinsightCreatedby
		{
			get { return GetRelatedEntities<KnowledgeSearchInsight>("lk_msdyn_knowledgesearchinsight_createdby", null); }
			set { SetRelatedEntities("lk_msdyn_knowledgesearchinsight_createdby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_msdyn_knowledgesearchinsight_createdonbehalfby'
        /// </summary>
		[RelationshipSchemaName("lk_msdyn_knowledgesearchinsight_createdonbehalfby")]
		public IEnumerable<KnowledgeSearchInsight> LkMsdynKnowledgesearchinsightCreatedonbehalfby
		{
			get { return GetRelatedEntities<KnowledgeSearchInsight>("lk_msdyn_knowledgesearchinsight_createdonbehalfby", null); }
			set { SetRelatedEntities("lk_msdyn_knowledgesearchinsight_createdonbehalfby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_msdyn_knowledgesearchinsight_modifiedby'
        /// </summary>
		[RelationshipSchemaName("lk_msdyn_knowledgesearchinsight_modifiedby")]
		public IEnumerable<KnowledgeSearchInsight> LkMsdynKnowledgesearchinsightModifiedby
		{
			get { return GetRelatedEntities<KnowledgeSearchInsight>("lk_msdyn_knowledgesearchinsight_modifiedby", null); }
			set { SetRelatedEntities("lk_msdyn_knowledgesearchinsight_modifiedby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_msdyn_knowledgesearchinsight_modifiedonbehalfby'
        /// </summary>
		[RelationshipSchemaName("lk_msdyn_knowledgesearchinsight_modifiedonbehalfby")]
		public IEnumerable<KnowledgeSearchInsight> LkMsdynKnowledgesearchinsightModifiedonbehalfby
		{
			get { return GetRelatedEntities<KnowledgeSearchInsight>("lk_msdyn_knowledgesearchinsight_modifiedonbehalfby", null); }
			set { SetRelatedEntities("lk_msdyn_knowledgesearchinsight_modifiedonbehalfby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_msdyn_msteamssetting_createdby'
        /// </summary>
		[RelationshipSchemaName("lk_msdyn_msteamssetting_createdby")]
		public IEnumerable<MsdynMsteamssetting> LkMsdynMsteamssettingCreatedby
		{
			get { return GetRelatedEntities<MsdynMsteamssetting>("lk_msdyn_msteamssetting_createdby", null); }
			set { SetRelatedEntities("lk_msdyn_msteamssetting_createdby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_msdyn_msteamssetting_createdonbehalfby'
        /// </summary>
		[RelationshipSchemaName("lk_msdyn_msteamssetting_createdonbehalfby")]
		public IEnumerable<MsdynMsteamssetting> LkMsdynMsteamssettingCreatedonbehalfby
		{
			get { return GetRelatedEntities<MsdynMsteamssetting>("lk_msdyn_msteamssetting_createdonbehalfby", null); }
			set { SetRelatedEntities("lk_msdyn_msteamssetting_createdonbehalfby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_msdyn_msteamssetting_modifiedby'
        /// </summary>
		[RelationshipSchemaName("lk_msdyn_msteamssetting_modifiedby")]
		public IEnumerable<MsdynMsteamssetting> LkMsdynMsteamssettingModifiedby
		{
			get { return GetRelatedEntities<MsdynMsteamssetting>("lk_msdyn_msteamssetting_modifiedby", null); }
			set { SetRelatedEntities("lk_msdyn_msteamssetting_modifiedby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_msdyn_msteamssetting_modifiedonbehalfby'
        /// </summary>
		[RelationshipSchemaName("lk_msdyn_msteamssetting_modifiedonbehalfby")]
		public IEnumerable<MsdynMsteamssetting> LkMsdynMsteamssettingModifiedonbehalfby
		{
			get { return GetRelatedEntities<MsdynMsteamssetting>("lk_msdyn_msteamssetting_modifiedonbehalfby", null); }
			set { SetRelatedEntities("lk_msdyn_msteamssetting_modifiedonbehalfby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_msdyn_msteamssettingsv2_createdby'
        /// </summary>
		[RelationshipSchemaName("lk_msdyn_msteamssettingsv2_createdby")]
		public IEnumerable<MsdynMsteamssettingsv2> LkMsdynMsteamssettingsv2Createdby
		{
			get { return GetRelatedEntities<MsdynMsteamssettingsv2>("lk_msdyn_msteamssettingsv2_createdby", null); }
			set { SetRelatedEntities("lk_msdyn_msteamssettingsv2_createdby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_msdyn_msteamssettingsv2_createdonbehalfby'
        /// </summary>
		[RelationshipSchemaName("lk_msdyn_msteamssettingsv2_createdonbehalfby")]
		public IEnumerable<MsdynMsteamssettingsv2> LkMsdynMsteamssettingsv2Createdonbehalfby
		{
			get { return GetRelatedEntities<MsdynMsteamssettingsv2>("lk_msdyn_msteamssettingsv2_createdonbehalfby", null); }
			set { SetRelatedEntities("lk_msdyn_msteamssettingsv2_createdonbehalfby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_msdyn_msteamssettingsv2_modifiedby'
        /// </summary>
		[RelationshipSchemaName("lk_msdyn_msteamssettingsv2_modifiedby")]
		public IEnumerable<MsdynMsteamssettingsv2> LkMsdynMsteamssettingsv2Modifiedby
		{
			get { return GetRelatedEntities<MsdynMsteamssettingsv2>("lk_msdyn_msteamssettingsv2_modifiedby", null); }
			set { SetRelatedEntities("lk_msdyn_msteamssettingsv2_modifiedby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_msdyn_msteamssettingsv2_modifiedonbehalfby'
        /// </summary>
		[RelationshipSchemaName("lk_msdyn_msteamssettingsv2_modifiedonbehalfby")]
		public IEnumerable<MsdynMsteamssettingsv2> LkMsdynMsteamssettingsv2Modifiedonbehalfby
		{
			get { return GetRelatedEntities<MsdynMsteamssettingsv2>("lk_msdyn_msteamssettingsv2_modifiedonbehalfby", null); }
			set { SetRelatedEntities("lk_msdyn_msteamssettingsv2_modifiedonbehalfby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_msdyn_notesanalysisconfig_createdby'
        /// </summary>
		[RelationshipSchemaName("lk_msdyn_notesanalysisconfig_createdby")]
		public IEnumerable<NotesAnalysisConfig> LkMsdynNotesanalysisconfigCreatedby
		{
			get { return GetRelatedEntities<NotesAnalysisConfig>("lk_msdyn_notesanalysisconfig_createdby", null); }
			set { SetRelatedEntities("lk_msdyn_notesanalysisconfig_createdby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_msdyn_notesanalysisconfig_createdonbehalfby'
        /// </summary>
		[RelationshipSchemaName("lk_msdyn_notesanalysisconfig_createdonbehalfby")]
		public IEnumerable<NotesAnalysisConfig> LkMsdynNotesanalysisconfigCreatedonbehalfby
		{
			get { return GetRelatedEntities<NotesAnalysisConfig>("lk_msdyn_notesanalysisconfig_createdonbehalfby", null); }
			set { SetRelatedEntities("lk_msdyn_notesanalysisconfig_createdonbehalfby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_msdyn_notesanalysisconfig_modifiedby'
        /// </summary>
		[RelationshipSchemaName("lk_msdyn_notesanalysisconfig_modifiedby")]
		public IEnumerable<NotesAnalysisConfig> LkMsdynNotesanalysisconfigModifiedby
		{
			get { return GetRelatedEntities<NotesAnalysisConfig>("lk_msdyn_notesanalysisconfig_modifiedby", null); }
			set { SetRelatedEntities("lk_msdyn_notesanalysisconfig_modifiedby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_msdyn_notesanalysisconfig_modifiedonbehalfby'
        /// </summary>
		[RelationshipSchemaName("lk_msdyn_notesanalysisconfig_modifiedonbehalfby")]
		public IEnumerable<NotesAnalysisConfig> LkMsdynNotesanalysisconfigModifiedonbehalfby
		{
			get { return GetRelatedEntities<NotesAnalysisConfig>("lk_msdyn_notesanalysisconfig_modifiedonbehalfby", null); }
			set { SetRelatedEntities("lk_msdyn_notesanalysisconfig_modifiedonbehalfby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_msdyn_playbookactivity_createdby'
        /// </summary>
		[RelationshipSchemaName("lk_msdyn_playbookactivity_createdby")]
		public IEnumerable<PlaybookActivity> LkMsdynPlaybookactivityCreatedby
		{
			get { return GetRelatedEntities<PlaybookActivity>("lk_msdyn_playbookactivity_createdby", null); }
			set { SetRelatedEntities("lk_msdyn_playbookactivity_createdby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_msdyn_playbookactivity_createdonbehalfby'
        /// </summary>
		[RelationshipSchemaName("lk_msdyn_playbookactivity_createdonbehalfby")]
		public IEnumerable<PlaybookActivity> LkMsdynPlaybookactivityCreatedonbehalfby
		{
			get { return GetRelatedEntities<PlaybookActivity>("lk_msdyn_playbookactivity_createdonbehalfby", null); }
			set { SetRelatedEntities("lk_msdyn_playbookactivity_createdonbehalfby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_msdyn_playbookactivity_modifiedby'
        /// </summary>
		[RelationshipSchemaName("lk_msdyn_playbookactivity_modifiedby")]
		public IEnumerable<PlaybookActivity> LkMsdynPlaybookactivityModifiedby
		{
			get { return GetRelatedEntities<PlaybookActivity>("lk_msdyn_playbookactivity_modifiedby", null); }
			set { SetRelatedEntities("lk_msdyn_playbookactivity_modifiedby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_msdyn_playbookactivity_modifiedonbehalfby'
        /// </summary>
		[RelationshipSchemaName("lk_msdyn_playbookactivity_modifiedonbehalfby")]
		public IEnumerable<PlaybookActivity> LkMsdynPlaybookactivityModifiedonbehalfby
		{
			get { return GetRelatedEntities<PlaybookActivity>("lk_msdyn_playbookactivity_modifiedonbehalfby", null); }
			set { SetRelatedEntities("lk_msdyn_playbookactivity_modifiedonbehalfby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_msdyn_playbookactivityattribute_createdby'
        /// </summary>
		[RelationshipSchemaName("lk_msdyn_playbookactivityattribute_createdby")]
		public IEnumerable<PlaybookActivityAttribute> LkMsdynPlaybookactivityattributeCreatedby
		{
			get { return GetRelatedEntities<PlaybookActivityAttribute>("lk_msdyn_playbookactivityattribute_createdby", null); }
			set { SetRelatedEntities("lk_msdyn_playbookactivityattribute_createdby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_msdyn_playbookactivityattribute_createdonbehalfby'
        /// </summary>
		[RelationshipSchemaName("lk_msdyn_playbookactivityattribute_createdonbehalfby")]
		public IEnumerable<PlaybookActivityAttribute> LkMsdynPlaybookactivityattributeCreatedonbehalfby
		{
			get { return GetRelatedEntities<PlaybookActivityAttribute>("lk_msdyn_playbookactivityattribute_createdonbehalfby", null); }
			set { SetRelatedEntities("lk_msdyn_playbookactivityattribute_createdonbehalfby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_msdyn_playbookactivityattribute_modifiedby'
        /// </summary>
		[RelationshipSchemaName("lk_msdyn_playbookactivityattribute_modifiedby")]
		public IEnumerable<PlaybookActivityAttribute> LkMsdynPlaybookactivityattributeModifiedby
		{
			get { return GetRelatedEntities<PlaybookActivityAttribute>("lk_msdyn_playbookactivityattribute_modifiedby", null); }
			set { SetRelatedEntities("lk_msdyn_playbookactivityattribute_modifiedby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_msdyn_playbookactivityattribute_modifiedonbehalfby'
        /// </summary>
		[RelationshipSchemaName("lk_msdyn_playbookactivityattribute_modifiedonbehalfby")]
		public IEnumerable<PlaybookActivityAttribute> LkMsdynPlaybookactivityattributeModifiedonbehalfby
		{
			get { return GetRelatedEntities<PlaybookActivityAttribute>("lk_msdyn_playbookactivityattribute_modifiedonbehalfby", null); }
			set { SetRelatedEntities("lk_msdyn_playbookactivityattribute_modifiedonbehalfby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_msdyn_playbookcategory_createdby'
        /// </summary>
		[RelationshipSchemaName("lk_msdyn_playbookcategory_createdby")]
		public IEnumerable<PlaybookCategory> LkMsdynPlaybookcategoryCreatedby
		{
			get { return GetRelatedEntities<PlaybookCategory>("lk_msdyn_playbookcategory_createdby", null); }
			set { SetRelatedEntities("lk_msdyn_playbookcategory_createdby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_msdyn_playbookcategory_createdonbehalfby'
        /// </summary>
		[RelationshipSchemaName("lk_msdyn_playbookcategory_createdonbehalfby")]
		public IEnumerable<PlaybookCategory> LkMsdynPlaybookcategoryCreatedonbehalfby
		{
			get { return GetRelatedEntities<PlaybookCategory>("lk_msdyn_playbookcategory_createdonbehalfby", null); }
			set { SetRelatedEntities("lk_msdyn_playbookcategory_createdonbehalfby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_msdyn_playbookcategory_modifiedby'
        /// </summary>
		[RelationshipSchemaName("lk_msdyn_playbookcategory_modifiedby")]
		public IEnumerable<PlaybookCategory> LkMsdynPlaybookcategoryModifiedby
		{
			get { return GetRelatedEntities<PlaybookCategory>("lk_msdyn_playbookcategory_modifiedby", null); }
			set { SetRelatedEntities("lk_msdyn_playbookcategory_modifiedby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_msdyn_playbookcategory_modifiedonbehalfby'
        /// </summary>
		[RelationshipSchemaName("lk_msdyn_playbookcategory_modifiedonbehalfby")]
		public IEnumerable<PlaybookCategory> LkMsdynPlaybookcategoryModifiedonbehalfby
		{
			get { return GetRelatedEntities<PlaybookCategory>("lk_msdyn_playbookcategory_modifiedonbehalfby", null); }
			set { SetRelatedEntities("lk_msdyn_playbookcategory_modifiedonbehalfby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_msdyn_playbookinstance_createdby'
        /// </summary>
		[RelationshipSchemaName("lk_msdyn_playbookinstance_createdby")]
		public IEnumerable<Playbook> LkMsdynPlaybookinstanceCreatedby
		{
			get { return GetRelatedEntities<Playbook>("lk_msdyn_playbookinstance_createdby", null); }
			set { SetRelatedEntities("lk_msdyn_playbookinstance_createdby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_msdyn_playbookinstance_createdonbehalfby'
        /// </summary>
		[RelationshipSchemaName("lk_msdyn_playbookinstance_createdonbehalfby")]
		public IEnumerable<Playbook> LkMsdynPlaybookinstanceCreatedonbehalfby
		{
			get { return GetRelatedEntities<Playbook>("lk_msdyn_playbookinstance_createdonbehalfby", null); }
			set { SetRelatedEntities("lk_msdyn_playbookinstance_createdonbehalfby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_msdyn_playbookinstance_modifiedby'
        /// </summary>
		[RelationshipSchemaName("lk_msdyn_playbookinstance_modifiedby")]
		public IEnumerable<Playbook> LkMsdynPlaybookinstanceModifiedby
		{
			get { return GetRelatedEntities<Playbook>("lk_msdyn_playbookinstance_modifiedby", null); }
			set { SetRelatedEntities("lk_msdyn_playbookinstance_modifiedby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_msdyn_playbookinstance_modifiedonbehalfby'
        /// </summary>
		[RelationshipSchemaName("lk_msdyn_playbookinstance_modifiedonbehalfby")]
		public IEnumerable<Playbook> LkMsdynPlaybookinstanceModifiedonbehalfby
		{
			get { return GetRelatedEntities<Playbook>("lk_msdyn_playbookinstance_modifiedonbehalfby", null); }
			set { SetRelatedEntities("lk_msdyn_playbookinstance_modifiedonbehalfby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_msdyn_playbooktemplate_createdby'
        /// </summary>
		[RelationshipSchemaName("lk_msdyn_playbooktemplate_createdby")]
		public IEnumerable<PlaybookTemplate> LkMsdynPlaybooktemplateCreatedby
		{
			get { return GetRelatedEntities<PlaybookTemplate>("lk_msdyn_playbooktemplate_createdby", null); }
			set { SetRelatedEntities("lk_msdyn_playbooktemplate_createdby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_msdyn_playbooktemplate_createdonbehalfby'
        /// </summary>
		[RelationshipSchemaName("lk_msdyn_playbooktemplate_createdonbehalfby")]
		public IEnumerable<PlaybookTemplate> LkMsdynPlaybooktemplateCreatedonbehalfby
		{
			get { return GetRelatedEntities<PlaybookTemplate>("lk_msdyn_playbooktemplate_createdonbehalfby", null); }
			set { SetRelatedEntities("lk_msdyn_playbooktemplate_createdonbehalfby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_msdyn_playbooktemplate_modifiedby'
        /// </summary>
		[RelationshipSchemaName("lk_msdyn_playbooktemplate_modifiedby")]
		public IEnumerable<PlaybookTemplate> LkMsdynPlaybooktemplateModifiedby
		{
			get { return GetRelatedEntities<PlaybookTemplate>("lk_msdyn_playbooktemplate_modifiedby", null); }
			set { SetRelatedEntities("lk_msdyn_playbooktemplate_modifiedby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_msdyn_playbooktemplate_modifiedonbehalfby'
        /// </summary>
		[RelationshipSchemaName("lk_msdyn_playbooktemplate_modifiedonbehalfby")]
		public IEnumerable<PlaybookTemplate> LkMsdynPlaybooktemplateModifiedonbehalfby
		{
			get { return GetRelatedEntities<PlaybookTemplate>("lk_msdyn_playbooktemplate_modifiedonbehalfby", null); }
			set { SetRelatedEntities("lk_msdyn_playbooktemplate_modifiedonbehalfby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_msdyn_postalbum_createdby'
        /// </summary>
		[RelationshipSchemaName("lk_msdyn_postalbum_createdby")]
		public IEnumerable<ProfileAlbum> LkMsdynPostalbumCreatedby
		{
			get { return GetRelatedEntities<ProfileAlbum>("lk_msdyn_postalbum_createdby", null); }
			set { SetRelatedEntities("lk_msdyn_postalbum_createdby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_msdyn_postalbum_createdonbehalfby'
        /// </summary>
		[RelationshipSchemaName("lk_msdyn_postalbum_createdonbehalfby")]
		public IEnumerable<ProfileAlbum> LkMsdynPostalbumCreatedonbehalfby
		{
			get { return GetRelatedEntities<ProfileAlbum>("lk_msdyn_postalbum_createdonbehalfby", null); }
			set { SetRelatedEntities("lk_msdyn_postalbum_createdonbehalfby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_msdyn_postalbum_modifiedby'
        /// </summary>
		[RelationshipSchemaName("lk_msdyn_postalbum_modifiedby")]
		public IEnumerable<ProfileAlbum> LkMsdynPostalbumModifiedby
		{
			get { return GetRelatedEntities<ProfileAlbum>("lk_msdyn_postalbum_modifiedby", null); }
			set { SetRelatedEntities("lk_msdyn_postalbum_modifiedby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_msdyn_postalbum_modifiedonbehalfby'
        /// </summary>
		[RelationshipSchemaName("lk_msdyn_postalbum_modifiedonbehalfby")]
		public IEnumerable<ProfileAlbum> LkMsdynPostalbumModifiedonbehalfby
		{
			get { return GetRelatedEntities<ProfileAlbum>("lk_msdyn_postalbum_modifiedonbehalfby", null); }
			set { SetRelatedEntities("lk_msdyn_postalbum_modifiedonbehalfby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_msdyn_postconfig_createdby'
        /// </summary>
		[RelationshipSchemaName("lk_msdyn_postconfig_createdby")]
		public IEnumerable<PostConfiguration> LkMsdynPostconfigCreatedby
		{
			get { return GetRelatedEntities<PostConfiguration>("lk_msdyn_postconfig_createdby", null); }
			set { SetRelatedEntities("lk_msdyn_postconfig_createdby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_msdyn_postconfig_createdonbehalfby'
        /// </summary>
		[RelationshipSchemaName("lk_msdyn_postconfig_createdonbehalfby")]
		public IEnumerable<PostConfiguration> LkMsdynPostconfigCreatedonbehalfby
		{
			get { return GetRelatedEntities<PostConfiguration>("lk_msdyn_postconfig_createdonbehalfby", null); }
			set { SetRelatedEntities("lk_msdyn_postconfig_createdonbehalfby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_msdyn_postconfig_modifiedby'
        /// </summary>
		[RelationshipSchemaName("lk_msdyn_postconfig_modifiedby")]
		public IEnumerable<PostConfiguration> LkMsdynPostconfigModifiedby
		{
			get { return GetRelatedEntities<PostConfiguration>("lk_msdyn_postconfig_modifiedby", null); }
			set { SetRelatedEntities("lk_msdyn_postconfig_modifiedby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_msdyn_postconfig_modifiedonbehalfby'
        /// </summary>
		[RelationshipSchemaName("lk_msdyn_postconfig_modifiedonbehalfby")]
		public IEnumerable<PostConfiguration> LkMsdynPostconfigModifiedonbehalfby
		{
			get { return GetRelatedEntities<PostConfiguration>("lk_msdyn_postconfig_modifiedonbehalfby", null); }
			set { SetRelatedEntities("lk_msdyn_postconfig_modifiedonbehalfby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_msdyn_postruleconfig_createdby'
        /// </summary>
		[RelationshipSchemaName("lk_msdyn_postruleconfig_createdby")]
		public IEnumerable<PostRuleConfiguration> LkMsdynPostruleconfigCreatedby
		{
			get { return GetRelatedEntities<PostRuleConfiguration>("lk_msdyn_postruleconfig_createdby", null); }
			set { SetRelatedEntities("lk_msdyn_postruleconfig_createdby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_msdyn_postruleconfig_createdonbehalfby'
        /// </summary>
		[RelationshipSchemaName("lk_msdyn_postruleconfig_createdonbehalfby")]
		public IEnumerable<PostRuleConfiguration> LkMsdynPostruleconfigCreatedonbehalfby
		{
			get { return GetRelatedEntities<PostRuleConfiguration>("lk_msdyn_postruleconfig_createdonbehalfby", null); }
			set { SetRelatedEntities("lk_msdyn_postruleconfig_createdonbehalfby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_msdyn_postruleconfig_modifiedby'
        /// </summary>
		[RelationshipSchemaName("lk_msdyn_postruleconfig_modifiedby")]
		public IEnumerable<PostRuleConfiguration> LkMsdynPostruleconfigModifiedby
		{
			get { return GetRelatedEntities<PostRuleConfiguration>("lk_msdyn_postruleconfig_modifiedby", null); }
			set { SetRelatedEntities("lk_msdyn_postruleconfig_modifiedby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_msdyn_postruleconfig_modifiedonbehalfby'
        /// </summary>
		[RelationshipSchemaName("lk_msdyn_postruleconfig_modifiedonbehalfby")]
		public IEnumerable<PostRuleConfiguration> LkMsdynPostruleconfigModifiedonbehalfby
		{
			get { return GetRelatedEntities<PostRuleConfiguration>("lk_msdyn_postruleconfig_modifiedonbehalfby", null); }
			set { SetRelatedEntities("lk_msdyn_postruleconfig_modifiedonbehalfby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_msdyn_relationshipinsightsunifiedconfig_createdby'
        /// </summary>
		[RelationshipSchemaName("lk_msdyn_relationshipinsightsunifiedconfig_createdby")]
		public IEnumerable<MsdynRelationshipinsightsunifiedconfig> LkMsdynRelationshipinsightsunifiedconfigCreatedby
		{
			get { return GetRelatedEntities<MsdynRelationshipinsightsunifiedconfig>("lk_msdyn_relationshipinsightsunifiedconfig_createdby", null); }
			set { SetRelatedEntities("lk_msdyn_relationshipinsightsunifiedconfig_createdby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_msdyn_relationshipinsightsunifiedconfig_createdonbehalfby'
        /// </summary>
		[RelationshipSchemaName("lk_msdyn_relationshipinsightsunifiedconfig_createdonbehalfby")]
		public IEnumerable<MsdynRelationshipinsightsunifiedconfig> LkMsdynRelationshipinsightsunifiedconfigCreatedonbehalfby
		{
			get { return GetRelatedEntities<MsdynRelationshipinsightsunifiedconfig>("lk_msdyn_relationshipinsightsunifiedconfig_createdonbehalfby", null); }
			set { SetRelatedEntities("lk_msdyn_relationshipinsightsunifiedconfig_createdonbehalfby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_msdyn_relationshipinsightsunifiedconfig_modifiedby'
        /// </summary>
		[RelationshipSchemaName("lk_msdyn_relationshipinsightsunifiedconfig_modifiedby")]
		public IEnumerable<MsdynRelationshipinsightsunifiedconfig> LkMsdynRelationshipinsightsunifiedconfigModifiedby
		{
			get { return GetRelatedEntities<MsdynRelationshipinsightsunifiedconfig>("lk_msdyn_relationshipinsightsunifiedconfig_modifiedby", null); }
			set { SetRelatedEntities("lk_msdyn_relationshipinsightsunifiedconfig_modifiedby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_msdyn_relationshipinsightsunifiedconfig_modifiedonbehalfby'
        /// </summary>
		[RelationshipSchemaName("lk_msdyn_relationshipinsightsunifiedconfig_modifiedonbehalfby")]
		public IEnumerable<MsdynRelationshipinsightsunifiedconfig> LkMsdynRelationshipinsightsunifiedconfigModifiedonbehalfby
		{
			get { return GetRelatedEntities<MsdynRelationshipinsightsunifiedconfig>("lk_msdyn_relationshipinsightsunifiedconfig_modifiedonbehalfby", null); }
			set { SetRelatedEntities("lk_msdyn_relationshipinsightsunifiedconfig_modifiedonbehalfby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_msdyn_richtextfile_createdby'
        /// </summary>
		[RelationshipSchemaName("lk_msdyn_richtextfile_createdby")]
		public IEnumerable<RichTextAttachment> LkMsdynRichtextfileCreatedby
		{
			get { return GetRelatedEntities<RichTextAttachment>("lk_msdyn_richtextfile_createdby", null); }
			set { SetRelatedEntities("lk_msdyn_richtextfile_createdby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_msdyn_richtextfile_createdonbehalfby'
        /// </summary>
		[RelationshipSchemaName("lk_msdyn_richtextfile_createdonbehalfby")]
		public IEnumerable<RichTextAttachment> LkMsdynRichtextfileCreatedonbehalfby
		{
			get { return GetRelatedEntities<RichTextAttachment>("lk_msdyn_richtextfile_createdonbehalfby", null); }
			set { SetRelatedEntities("lk_msdyn_richtextfile_createdonbehalfby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_msdyn_richtextfile_modifiedby'
        /// </summary>
		[RelationshipSchemaName("lk_msdyn_richtextfile_modifiedby")]
		public IEnumerable<RichTextAttachment> LkMsdynRichtextfileModifiedby
		{
			get { return GetRelatedEntities<RichTextAttachment>("lk_msdyn_richtextfile_modifiedby", null); }
			set { SetRelatedEntities("lk_msdyn_richtextfile_modifiedby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_msdyn_richtextfile_modifiedonbehalfby'
        /// </summary>
		[RelationshipSchemaName("lk_msdyn_richtextfile_modifiedonbehalfby")]
		public IEnumerable<RichTextAttachment> LkMsdynRichtextfileModifiedonbehalfby
		{
			get { return GetRelatedEntities<RichTextAttachment>("lk_msdyn_richtextfile_modifiedonbehalfby", null); }
			set { SetRelatedEntities("lk_msdyn_richtextfile_modifiedonbehalfby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_msdyn_salesinsightssettings_createdby'
        /// </summary>
		[RelationshipSchemaName("lk_msdyn_salesinsightssettings_createdby")]
		public IEnumerable<Salesinsightssettings> LkMsdynSalesinsightssettingsCreatedby
		{
			get { return GetRelatedEntities<Salesinsightssettings>("lk_msdyn_salesinsightssettings_createdby", null); }
			set { SetRelatedEntities("lk_msdyn_salesinsightssettings_createdby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_msdyn_salesinsightssettings_createdonbehalfby'
        /// </summary>
		[RelationshipSchemaName("lk_msdyn_salesinsightssettings_createdonbehalfby")]
		public IEnumerable<Salesinsightssettings> LkMsdynSalesinsightssettingsCreatedonbehalfby
		{
			get { return GetRelatedEntities<Salesinsightssettings>("lk_msdyn_salesinsightssettings_createdonbehalfby", null); }
			set { SetRelatedEntities("lk_msdyn_salesinsightssettings_createdonbehalfby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_msdyn_salesinsightssettings_modifiedby'
        /// </summary>
		[RelationshipSchemaName("lk_msdyn_salesinsightssettings_modifiedby")]
		public IEnumerable<Salesinsightssettings> LkMsdynSalesinsightssettingsModifiedby
		{
			get { return GetRelatedEntities<Salesinsightssettings>("lk_msdyn_salesinsightssettings_modifiedby", null); }
			set { SetRelatedEntities("lk_msdyn_salesinsightssettings_modifiedby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_msdyn_salesinsightssettings_modifiedonbehalfby'
        /// </summary>
		[RelationshipSchemaName("lk_msdyn_salesinsightssettings_modifiedonbehalfby")]
		public IEnumerable<Salesinsightssettings> LkMsdynSalesinsightssettingsModifiedonbehalfby
		{
			get { return GetRelatedEntities<Salesinsightssettings>("lk_msdyn_salesinsightssettings_modifiedonbehalfby", null); }
			set { SetRelatedEntities("lk_msdyn_salesinsightssettings_modifiedonbehalfby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_msdyn_siconfig_createdby'
        /// </summary>
		[RelationshipSchemaName("lk_msdyn_siconfig_createdby")]
		public IEnumerable<Siconfig> LkMsdynSiconfigCreatedby
		{
			get { return GetRelatedEntities<Siconfig>("lk_msdyn_siconfig_createdby", null); }
			set { SetRelatedEntities("lk_msdyn_siconfig_createdby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_msdyn_siconfig_createdonbehalfby'
        /// </summary>
		[RelationshipSchemaName("lk_msdyn_siconfig_createdonbehalfby")]
		public IEnumerable<Siconfig> LkMsdynSiconfigCreatedonbehalfby
		{
			get { return GetRelatedEntities<Siconfig>("lk_msdyn_siconfig_createdonbehalfby", null); }
			set { SetRelatedEntities("lk_msdyn_siconfig_createdonbehalfby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_msdyn_siconfig_modifiedby'
        /// </summary>
		[RelationshipSchemaName("lk_msdyn_siconfig_modifiedby")]
		public IEnumerable<Siconfig> LkMsdynSiconfigModifiedby
		{
			get { return GetRelatedEntities<Siconfig>("lk_msdyn_siconfig_modifiedby", null); }
			set { SetRelatedEntities("lk_msdyn_siconfig_modifiedby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_msdyn_siconfig_modifiedonbehalfby'
        /// </summary>
		[RelationshipSchemaName("lk_msdyn_siconfig_modifiedonbehalfby")]
		public IEnumerable<Siconfig> LkMsdynSiconfigModifiedonbehalfby
		{
			get { return GetRelatedEntities<Siconfig>("lk_msdyn_siconfig_modifiedonbehalfby", null); }
			set { SetRelatedEntities("lk_msdyn_siconfig_modifiedonbehalfby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_msdyn_sikeyvalueconfig_createdby'
        /// </summary>
		[RelationshipSchemaName("lk_msdyn_sikeyvalueconfig_createdby")]
		public IEnumerable<SIKeyValueConfig> LkMsdynSikeyvalueconfigCreatedby
		{
			get { return GetRelatedEntities<SIKeyValueConfig>("lk_msdyn_sikeyvalueconfig_createdby", null); }
			set { SetRelatedEntities("lk_msdyn_sikeyvalueconfig_createdby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_msdyn_sikeyvalueconfig_createdonbehalfby'
        /// </summary>
		[RelationshipSchemaName("lk_msdyn_sikeyvalueconfig_createdonbehalfby")]
		public IEnumerable<SIKeyValueConfig> LkMsdynSikeyvalueconfigCreatedonbehalfby
		{
			get { return GetRelatedEntities<SIKeyValueConfig>("lk_msdyn_sikeyvalueconfig_createdonbehalfby", null); }
			set { SetRelatedEntities("lk_msdyn_sikeyvalueconfig_createdonbehalfby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_msdyn_sikeyvalueconfig_modifiedby'
        /// </summary>
		[RelationshipSchemaName("lk_msdyn_sikeyvalueconfig_modifiedby")]
		public IEnumerable<SIKeyValueConfig> LkMsdynSikeyvalueconfigModifiedby
		{
			get { return GetRelatedEntities<SIKeyValueConfig>("lk_msdyn_sikeyvalueconfig_modifiedby", null); }
			set { SetRelatedEntities("lk_msdyn_sikeyvalueconfig_modifiedby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_msdyn_sikeyvalueconfig_modifiedonbehalfby'
        /// </summary>
		[RelationshipSchemaName("lk_msdyn_sikeyvalueconfig_modifiedonbehalfby")]
		public IEnumerable<SIKeyValueConfig> LkMsdynSikeyvalueconfigModifiedonbehalfby
		{
			get { return GetRelatedEntities<SIKeyValueConfig>("lk_msdyn_sikeyvalueconfig_modifiedonbehalfby", null); }
			set { SetRelatedEntities("lk_msdyn_sikeyvalueconfig_modifiedonbehalfby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_msdyn_teamscollaboration_createdby'
        /// </summary>
		[RelationshipSchemaName("lk_msdyn_teamscollaboration_createdby")]
		public IEnumerable<MicrosoftTeamsCollaborationEntity> LkMsdynTeamscollaborationCreatedby
		{
			get { return GetRelatedEntities<MicrosoftTeamsCollaborationEntity>("lk_msdyn_teamscollaboration_createdby", null); }
			set { SetRelatedEntities("lk_msdyn_teamscollaboration_createdby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_msdyn_teamscollaboration_createdonbehalfby'
        /// </summary>
		[RelationshipSchemaName("lk_msdyn_teamscollaboration_createdonbehalfby")]
		public IEnumerable<MicrosoftTeamsCollaborationEntity> LkMsdynTeamscollaborationCreatedonbehalfby
		{
			get { return GetRelatedEntities<MicrosoftTeamsCollaborationEntity>("lk_msdyn_teamscollaboration_createdonbehalfby", null); }
			set { SetRelatedEntities("lk_msdyn_teamscollaboration_createdonbehalfby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_msdyn_teamscollaboration_modifiedby'
        /// </summary>
		[RelationshipSchemaName("lk_msdyn_teamscollaboration_modifiedby")]
		public IEnumerable<MicrosoftTeamsCollaborationEntity> LkMsdynTeamscollaborationModifiedby
		{
			get { return GetRelatedEntities<MicrosoftTeamsCollaborationEntity>("lk_msdyn_teamscollaboration_modifiedby", null); }
			set { SetRelatedEntities("lk_msdyn_teamscollaboration_modifiedby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_msdyn_teamscollaboration_modifiedonbehalfby'
        /// </summary>
		[RelationshipSchemaName("lk_msdyn_teamscollaboration_modifiedonbehalfby")]
		public IEnumerable<MicrosoftTeamsCollaborationEntity> LkMsdynTeamscollaborationModifiedonbehalfby
		{
			get { return GetRelatedEntities<MicrosoftTeamsCollaborationEntity>("lk_msdyn_teamscollaboration_modifiedonbehalfby", null); }
			set { SetRelatedEntities("lk_msdyn_teamscollaboration_modifiedonbehalfby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_msdyn_tour_createdby'
        /// </summary>
		[RelationshipSchemaName("lk_msdyn_tour_createdby")]
		public IEnumerable<Tour> LkMsdynTourCreatedby
		{
			get { return GetRelatedEntities<Tour>("lk_msdyn_tour_createdby", null); }
			set { SetRelatedEntities("lk_msdyn_tour_createdby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_msdyn_tour_createdonbehalfby'
        /// </summary>
		[RelationshipSchemaName("lk_msdyn_tour_createdonbehalfby")]
		public IEnumerable<Tour> LkMsdynTourCreatedonbehalfby
		{
			get { return GetRelatedEntities<Tour>("lk_msdyn_tour_createdonbehalfby", null); }
			set { SetRelatedEntities("lk_msdyn_tour_createdonbehalfby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_msdyn_tour_modifiedby'
        /// </summary>
		[RelationshipSchemaName("lk_msdyn_tour_modifiedby")]
		public IEnumerable<Tour> LkMsdynTourModifiedby
		{
			get { return GetRelatedEntities<Tour>("lk_msdyn_tour_modifiedby", null); }
			set { SetRelatedEntities("lk_msdyn_tour_modifiedby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_msdyn_tour_modifiedonbehalfby'
        /// </summary>
		[RelationshipSchemaName("lk_msdyn_tour_modifiedonbehalfby")]
		public IEnumerable<Tour> LkMsdynTourModifiedonbehalfby
		{
			get { return GetRelatedEntities<Tour>("lk_msdyn_tour_modifiedonbehalfby", null); }
			set { SetRelatedEntities("lk_msdyn_tour_modifiedonbehalfby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_msdyn_untrackedappointment_createdby'
        /// </summary>
		[RelationshipSchemaName("lk_msdyn_untrackedappointment_createdby")]
		public IEnumerable<UntrackedAppointment> LkMsdynUntrackedappointmentCreatedby
		{
			get { return GetRelatedEntities<UntrackedAppointment>("lk_msdyn_untrackedappointment_createdby", null); }
			set { SetRelatedEntities("lk_msdyn_untrackedappointment_createdby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_msdyn_untrackedappointment_createdonbehalfby'
        /// </summary>
		[RelationshipSchemaName("lk_msdyn_untrackedappointment_createdonbehalfby")]
		public IEnumerable<UntrackedAppointment> LkMsdynUntrackedappointmentCreatedonbehalfby
		{
			get { return GetRelatedEntities<UntrackedAppointment>("lk_msdyn_untrackedappointment_createdonbehalfby", null); }
			set { SetRelatedEntities("lk_msdyn_untrackedappointment_createdonbehalfby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_msdyn_untrackedappointment_modifiedby'
        /// </summary>
		[RelationshipSchemaName("lk_msdyn_untrackedappointment_modifiedby")]
		public IEnumerable<UntrackedAppointment> LkMsdynUntrackedappointmentModifiedby
		{
			get { return GetRelatedEntities<UntrackedAppointment>("lk_msdyn_untrackedappointment_modifiedby", null); }
			set { SetRelatedEntities("lk_msdyn_untrackedappointment_modifiedby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_msdyn_untrackedappointment_modifiedonbehalfby'
        /// </summary>
		[RelationshipSchemaName("lk_msdyn_untrackedappointment_modifiedonbehalfby")]
		public IEnumerable<UntrackedAppointment> LkMsdynUntrackedappointmentModifiedonbehalfby
		{
			get { return GetRelatedEntities<UntrackedAppointment>("lk_msdyn_untrackedappointment_modifiedonbehalfby", null); }
			set { SetRelatedEntities("lk_msdyn_untrackedappointment_modifiedonbehalfby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_msdyn_upgraderun_createdby'
        /// </summary>
		[RelationshipSchemaName("lk_msdyn_upgraderun_createdby")]
		public IEnumerable<UpgradeRun> LkMsdynUpgraderunCreatedby
		{
			get { return GetRelatedEntities<UpgradeRun>("lk_msdyn_upgraderun_createdby", null); }
			set { SetRelatedEntities("lk_msdyn_upgraderun_createdby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_msdyn_upgraderun_createdonbehalfby'
        /// </summary>
		[RelationshipSchemaName("lk_msdyn_upgraderun_createdonbehalfby")]
		public IEnumerable<UpgradeRun> LkMsdynUpgraderunCreatedonbehalfby
		{
			get { return GetRelatedEntities<UpgradeRun>("lk_msdyn_upgraderun_createdonbehalfby", null); }
			set { SetRelatedEntities("lk_msdyn_upgraderun_createdonbehalfby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_msdyn_upgraderun_modifiedby'
        /// </summary>
		[RelationshipSchemaName("lk_msdyn_upgraderun_modifiedby")]
		public IEnumerable<UpgradeRun> LkMsdynUpgraderunModifiedby
		{
			get { return GetRelatedEntities<UpgradeRun>("lk_msdyn_upgraderun_modifiedby", null); }
			set { SetRelatedEntities("lk_msdyn_upgraderun_modifiedby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_msdyn_upgraderun_modifiedonbehalfby'
        /// </summary>
		[RelationshipSchemaName("lk_msdyn_upgraderun_modifiedonbehalfby")]
		public IEnumerable<UpgradeRun> LkMsdynUpgraderunModifiedonbehalfby
		{
			get { return GetRelatedEntities<UpgradeRun>("lk_msdyn_upgraderun_modifiedonbehalfby", null); }
			set { SetRelatedEntities("lk_msdyn_upgraderun_modifiedonbehalfby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_msdyn_upgradestep_createdby'
        /// </summary>
		[RelationshipSchemaName("lk_msdyn_upgradestep_createdby")]
		public IEnumerable<UpgradeStep> LkMsdynUpgradestepCreatedby
		{
			get { return GetRelatedEntities<UpgradeStep>("lk_msdyn_upgradestep_createdby", null); }
			set { SetRelatedEntities("lk_msdyn_upgradestep_createdby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_msdyn_upgradestep_createdonbehalfby'
        /// </summary>
		[RelationshipSchemaName("lk_msdyn_upgradestep_createdonbehalfby")]
		public IEnumerable<UpgradeStep> LkMsdynUpgradestepCreatedonbehalfby
		{
			get { return GetRelatedEntities<UpgradeStep>("lk_msdyn_upgradestep_createdonbehalfby", null); }
			set { SetRelatedEntities("lk_msdyn_upgradestep_createdonbehalfby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_msdyn_upgradestep_modifiedby'
        /// </summary>
		[RelationshipSchemaName("lk_msdyn_upgradestep_modifiedby")]
		public IEnumerable<UpgradeStep> LkMsdynUpgradestepModifiedby
		{
			get { return GetRelatedEntities<UpgradeStep>("lk_msdyn_upgradestep_modifiedby", null); }
			set { SetRelatedEntities("lk_msdyn_upgradestep_modifiedby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_msdyn_upgradestep_modifiedonbehalfby'
        /// </summary>
		[RelationshipSchemaName("lk_msdyn_upgradestep_modifiedonbehalfby")]
		public IEnumerable<UpgradeStep> LkMsdynUpgradestepModifiedonbehalfby
		{
			get { return GetRelatedEntities<UpgradeStep>("lk_msdyn_upgradestep_modifiedonbehalfby", null); }
			set { SetRelatedEntities("lk_msdyn_upgradestep_modifiedonbehalfby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_msdyn_upgradeversion_createdby'
        /// </summary>
		[RelationshipSchemaName("lk_msdyn_upgradeversion_createdby")]
		public IEnumerable<UpgradeVersion> LkMsdynUpgradeversionCreatedby
		{
			get { return GetRelatedEntities<UpgradeVersion>("lk_msdyn_upgradeversion_createdby", null); }
			set { SetRelatedEntities("lk_msdyn_upgradeversion_createdby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_msdyn_upgradeversion_createdonbehalfby'
        /// </summary>
		[RelationshipSchemaName("lk_msdyn_upgradeversion_createdonbehalfby")]
		public IEnumerable<UpgradeVersion> LkMsdynUpgradeversionCreatedonbehalfby
		{
			get { return GetRelatedEntities<UpgradeVersion>("lk_msdyn_upgradeversion_createdonbehalfby", null); }
			set { SetRelatedEntities("lk_msdyn_upgradeversion_createdonbehalfby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_msdyn_upgradeversion_modifiedby'
        /// </summary>
		[RelationshipSchemaName("lk_msdyn_upgradeversion_modifiedby")]
		public IEnumerable<UpgradeVersion> LkMsdynUpgradeversionModifiedby
		{
			get { return GetRelatedEntities<UpgradeVersion>("lk_msdyn_upgradeversion_modifiedby", null); }
			set { SetRelatedEntities("lk_msdyn_upgradeversion_modifiedby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_msdyn_upgradeversion_modifiedonbehalfby'
        /// </summary>
		[RelationshipSchemaName("lk_msdyn_upgradeversion_modifiedonbehalfby")]
		public IEnumerable<UpgradeVersion> LkMsdynUpgradeversionModifiedonbehalfby
		{
			get { return GetRelatedEntities<UpgradeVersion>("lk_msdyn_upgradeversion_modifiedonbehalfby", null); }
			set { SetRelatedEntities("lk_msdyn_upgradeversion_modifiedonbehalfby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_msdyn_wallsavedquery_createdby'
        /// </summary>
		[RelationshipSchemaName("lk_msdyn_wallsavedquery_createdby")]
		public IEnumerable<WallView> LkMsdynWallsavedqueryCreatedby
		{
			get { return GetRelatedEntities<WallView>("lk_msdyn_wallsavedquery_createdby", null); }
			set { SetRelatedEntities("lk_msdyn_wallsavedquery_createdby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_msdyn_wallsavedquery_createdonbehalfby'
        /// </summary>
		[RelationshipSchemaName("lk_msdyn_wallsavedquery_createdonbehalfby")]
		public IEnumerable<WallView> LkMsdynWallsavedqueryCreatedonbehalfby
		{
			get { return GetRelatedEntities<WallView>("lk_msdyn_wallsavedquery_createdonbehalfby", null); }
			set { SetRelatedEntities("lk_msdyn_wallsavedquery_createdonbehalfby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_msdyn_wallsavedquery_modifiedby'
        /// </summary>
		[RelationshipSchemaName("lk_msdyn_wallsavedquery_modifiedby")]
		public IEnumerable<WallView> LkMsdynWallsavedqueryModifiedby
		{
			get { return GetRelatedEntities<WallView>("lk_msdyn_wallsavedquery_modifiedby", null); }
			set { SetRelatedEntities("lk_msdyn_wallsavedquery_modifiedby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_msdyn_wallsavedquery_modifiedonbehalfby'
        /// </summary>
		[RelationshipSchemaName("lk_msdyn_wallsavedquery_modifiedonbehalfby")]
		public IEnumerable<WallView> LkMsdynWallsavedqueryModifiedonbehalfby
		{
			get { return GetRelatedEntities<WallView>("lk_msdyn_wallsavedquery_modifiedonbehalfby", null); }
			set { SetRelatedEntities("lk_msdyn_wallsavedquery_modifiedonbehalfby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_msdyn_wallsavedqueryusersettings_createdby'
        /// </summary>
		[RelationshipSchemaName("lk_msdyn_wallsavedqueryusersettings_createdby")]
		public IEnumerable<Filter> LkMsdynWallsavedqueryusersettingsCreatedby
		{
			get { return GetRelatedEntities<Filter>("lk_msdyn_wallsavedqueryusersettings_createdby", null); }
			set { SetRelatedEntities("lk_msdyn_wallsavedqueryusersettings_createdby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_msdyn_wallsavedqueryusersettings_createdonbehalfby'
        /// </summary>
		[RelationshipSchemaName("lk_msdyn_wallsavedqueryusersettings_createdonbehalfby")]
		public IEnumerable<Filter> LkMsdynWallsavedqueryusersettingsCreatedonbehalfby
		{
			get { return GetRelatedEntities<Filter>("lk_msdyn_wallsavedqueryusersettings_createdonbehalfby", null); }
			set { SetRelatedEntities("lk_msdyn_wallsavedqueryusersettings_createdonbehalfby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_msdyn_wallsavedqueryusersettings_modifiedby'
        /// </summary>
		[RelationshipSchemaName("lk_msdyn_wallsavedqueryusersettings_modifiedby")]
		public IEnumerable<Filter> LkMsdynWallsavedqueryusersettingsModifiedby
		{
			get { return GetRelatedEntities<Filter>("lk_msdyn_wallsavedqueryusersettings_modifiedby", null); }
			set { SetRelatedEntities("lk_msdyn_wallsavedqueryusersettings_modifiedby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_msdyn_wallsavedqueryusersettings_modifiedonbehalfby'
        /// </summary>
		[RelationshipSchemaName("lk_msdyn_wallsavedqueryusersettings_modifiedonbehalfby")]
		public IEnumerable<Filter> LkMsdynWallsavedqueryusersettingsModifiedonbehalfby
		{
			get { return GetRelatedEntities<Filter>("lk_msdyn_wallsavedqueryusersettings_modifiedonbehalfby", null); }
			set { SetRelatedEntities("lk_msdyn_wallsavedqueryusersettings_modifiedonbehalfby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_msdynce_botcontent_createdby'
        /// </summary>
		[RelationshipSchemaName("lk_msdynce_botcontent_createdby")]
		public IEnumerable<BotContent> LkMsdynceBotcontentCreatedby
		{
			get { return GetRelatedEntities<BotContent>("lk_msdynce_botcontent_createdby", null); }
			set { SetRelatedEntities("lk_msdynce_botcontent_createdby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_msdynce_botcontent_createdonbehalfby'
        /// </summary>
		[RelationshipSchemaName("lk_msdynce_botcontent_createdonbehalfby")]
		public IEnumerable<BotContent> LkMsdynceBotcontentCreatedonbehalfby
		{
			get { return GetRelatedEntities<BotContent>("lk_msdynce_botcontent_createdonbehalfby", null); }
			set { SetRelatedEntities("lk_msdynce_botcontent_createdonbehalfby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_msdynce_botcontent_modifiedby'
        /// </summary>
		[RelationshipSchemaName("lk_msdynce_botcontent_modifiedby")]
		public IEnumerable<BotContent> LkMsdynceBotcontentModifiedby
		{
			get { return GetRelatedEntities<BotContent>("lk_msdynce_botcontent_modifiedby", null); }
			set { SetRelatedEntities("lk_msdynce_botcontent_modifiedby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_msdynce_botcontent_modifiedonbehalfby'
        /// </summary>
		[RelationshipSchemaName("lk_msdynce_botcontent_modifiedonbehalfby")]
		public IEnumerable<BotContent> LkMsdynceBotcontentModifiedonbehalfby
		{
			get { return GetRelatedEntities<BotContent>("lk_msdynce_botcontent_modifiedonbehalfby", null); }
			set { SetRelatedEntities("lk_msdynce_botcontent_modifiedonbehalfby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_navigationsetting_createdby'
        /// </summary>
		[RelationshipSchemaName("lk_navigationsetting_createdby")]
		public IEnumerable<NavigationSetting> LkNavigationsettingCreatedby
		{
			get { return GetRelatedEntities<NavigationSetting>("lk_navigationsetting_createdby", null); }
			set { SetRelatedEntities("lk_navigationsetting_createdby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_navigationsetting_createdonbehalfby'
        /// </summary>
		[RelationshipSchemaName("lk_navigationsetting_createdonbehalfby")]
		public IEnumerable<NavigationSetting> LkNavigationsettingCreatedonbehalfby
		{
			get { return GetRelatedEntities<NavigationSetting>("lk_navigationsetting_createdonbehalfby", null); }
			set { SetRelatedEntities("lk_navigationsetting_createdonbehalfby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_navigationsetting_modifiedby'
        /// </summary>
		[RelationshipSchemaName("lk_navigationsetting_modifiedby")]
		public IEnumerable<NavigationSetting> LkNavigationsettingModifiedby
		{
			get { return GetRelatedEntities<NavigationSetting>("lk_navigationsetting_modifiedby", null); }
			set { SetRelatedEntities("lk_navigationsetting_modifiedby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_navigationsetting_modifiedonbehalfby'
        /// </summary>
		[RelationshipSchemaName("lk_navigationsetting_modifiedonbehalfby")]
		public IEnumerable<NavigationSetting> LkNavigationsettingModifiedonbehalfby
		{
			get { return GetRelatedEntities<NavigationSetting>("lk_navigationsetting_modifiedonbehalfby", null); }
			set { SetRelatedEntities("lk_navigationsetting_modifiedonbehalfby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_newprocess_createdby'
        /// </summary>
		[RelationshipSchemaName("lk_newprocess_createdby")]
		public IEnumerable<NewProcess> LkNewprocessCreatedby
		{
			get { return GetRelatedEntities<NewProcess>("lk_newprocess_createdby", null); }
			set { SetRelatedEntities("lk_newprocess_createdby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_newprocess_createdonbehalfby'
        /// </summary>
		[RelationshipSchemaName("lk_newprocess_createdonbehalfby")]
		public IEnumerable<NewProcess> LkNewprocessCreatedonbehalfby
		{
			get { return GetRelatedEntities<NewProcess>("lk_newprocess_createdonbehalfby", null); }
			set { SetRelatedEntities("lk_newprocess_createdonbehalfby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_newprocess_modifiedby'
        /// </summary>
		[RelationshipSchemaName("lk_newprocess_modifiedby")]
		public IEnumerable<NewProcess> LkNewprocessModifiedby
		{
			get { return GetRelatedEntities<NewProcess>("lk_newprocess_modifiedby", null); }
			set { SetRelatedEntities("lk_newprocess_modifiedby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_newprocess_modifiedonbehalfby'
        /// </summary>
		[RelationshipSchemaName("lk_newprocess_modifiedonbehalfby")]
		public IEnumerable<NewProcess> LkNewprocessModifiedonbehalfby
		{
			get { return GetRelatedEntities<NewProcess>("lk_newprocess_modifiedonbehalfby", null); }
			set { SetRelatedEntities("lk_newprocess_modifiedonbehalfby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_officegraphdocument_createdonbehalfby'
        /// </summary>
		[RelationshipSchemaName("lk_officegraphdocument_createdonbehalfby")]
		public IEnumerable<OfficeGraphDocument> LkOfficegraphdocumentCreatedonbehalfby
		{
			get { return GetRelatedEntities<OfficeGraphDocument>("lk_officegraphdocument_createdonbehalfby", null); }
			set { SetRelatedEntities("lk_officegraphdocument_createdonbehalfby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_officegraphdocument_modifiedonbehalfby'
        /// </summary>
		[RelationshipSchemaName("lk_officegraphdocument_modifiedonbehalfby")]
		public IEnumerable<OfficeGraphDocument> LkOfficegraphdocumentModifiedonbehalfby
		{
			get { return GetRelatedEntities<OfficeGraphDocument>("lk_officegraphdocument_modifiedonbehalfby", null); }
			set { SetRelatedEntities("lk_officegraphdocument_modifiedonbehalfby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_opportunity_createdonbehalfby'
        /// </summary>
		[RelationshipSchemaName("lk_opportunity_createdonbehalfby")]
		public IEnumerable<Opportunity> LkOpportunityCreatedonbehalfby
		{
			get { return GetRelatedEntities<Opportunity>("lk_opportunity_createdonbehalfby", null); }
			set { SetRelatedEntities("lk_opportunity_createdonbehalfby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_opportunity_modifiedonbehalfby'
        /// </summary>
		[RelationshipSchemaName("lk_opportunity_modifiedonbehalfby")]
		public IEnumerable<Opportunity> LkOpportunityModifiedonbehalfby
		{
			get { return GetRelatedEntities<Opportunity>("lk_opportunity_modifiedonbehalfby", null); }
			set { SetRelatedEntities("lk_opportunity_modifiedonbehalfby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_opportunitybase_createdby'
        /// </summary>
		[RelationshipSchemaName("lk_opportunitybase_createdby")]
		public IEnumerable<Opportunity> LkOpportunitybaseCreatedby
		{
			get { return GetRelatedEntities<Opportunity>("lk_opportunitybase_createdby", null); }
			set { SetRelatedEntities("lk_opportunitybase_createdby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_opportunitybase_modifiedby'
        /// </summary>
		[RelationshipSchemaName("lk_opportunitybase_modifiedby")]
		public IEnumerable<Opportunity> LkOpportunitybaseModifiedby
		{
			get { return GetRelatedEntities<Opportunity>("lk_opportunitybase_modifiedby", null); }
			set { SetRelatedEntities("lk_opportunitybase_modifiedby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_opportunityclose_createdby'
        /// </summary>
		[RelationshipSchemaName("lk_opportunityclose_createdby")]
		public IEnumerable<OpportunityClose> LkOpportunitycloseCreatedby
		{
			get { return GetRelatedEntities<OpportunityClose>("lk_opportunityclose_createdby", null); }
			set { SetRelatedEntities("lk_opportunityclose_createdby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_opportunityclose_createdonbehalfby'
        /// </summary>
		[RelationshipSchemaName("lk_opportunityclose_createdonbehalfby")]
		public IEnumerable<OpportunityClose> LkOpportunitycloseCreatedonbehalfby
		{
			get { return GetRelatedEntities<OpportunityClose>("lk_opportunityclose_createdonbehalfby", null); }
			set { SetRelatedEntities("lk_opportunityclose_createdonbehalfby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_opportunityclose_modifiedby'
        /// </summary>
		[RelationshipSchemaName("lk_opportunityclose_modifiedby")]
		public IEnumerable<OpportunityClose> LkOpportunitycloseModifiedby
		{
			get { return GetRelatedEntities<OpportunityClose>("lk_opportunityclose_modifiedby", null); }
			set { SetRelatedEntities("lk_opportunityclose_modifiedby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_opportunityclose_modifiedonbehalfby'
        /// </summary>
		[RelationshipSchemaName("lk_opportunityclose_modifiedonbehalfby")]
		public IEnumerable<OpportunityClose> LkOpportunitycloseModifiedonbehalfby
		{
			get { return GetRelatedEntities<OpportunityClose>("lk_opportunityclose_modifiedonbehalfby", null); }
			set { SetRelatedEntities("lk_opportunityclose_modifiedonbehalfby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_opportunityproduct_createdonbehalfby'
        /// </summary>
		[RelationshipSchemaName("lk_opportunityproduct_createdonbehalfby")]
		public IEnumerable<OpportunityProduct> LkOpportunityproductCreatedonbehalfby
		{
			get { return GetRelatedEntities<OpportunityProduct>("lk_opportunityproduct_createdonbehalfby", null); }
			set { SetRelatedEntities("lk_opportunityproduct_createdonbehalfby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_opportunityproduct_modifiedonbehalfby'
        /// </summary>
		[RelationshipSchemaName("lk_opportunityproduct_modifiedonbehalfby")]
		public IEnumerable<OpportunityProduct> LkOpportunityproductModifiedonbehalfby
		{
			get { return GetRelatedEntities<OpportunityProduct>("lk_opportunityproduct_modifiedonbehalfby", null); }
			set { SetRelatedEntities("lk_opportunityproduct_modifiedonbehalfby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_opportunityproductbase_createdby'
        /// </summary>
		[RelationshipSchemaName("lk_opportunityproductbase_createdby")]
		public IEnumerable<OpportunityProduct> LkOpportunityproductbaseCreatedby
		{
			get { return GetRelatedEntities<OpportunityProduct>("lk_opportunityproductbase_createdby", null); }
			set { SetRelatedEntities("lk_opportunityproductbase_createdby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_opportunityproductbase_modifiedby'
        /// </summary>
		[RelationshipSchemaName("lk_opportunityproductbase_modifiedby")]
		public IEnumerable<OpportunityProduct> LkOpportunityproductbaseModifiedby
		{
			get { return GetRelatedEntities<OpportunityProduct>("lk_opportunityproductbase_modifiedby", null); }
			set { SetRelatedEntities("lk_opportunityproductbase_modifiedby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_opportunitysalesprocess_createdby'
        /// </summary>
		[RelationshipSchemaName("lk_opportunitysalesprocess_createdby")]
		public IEnumerable<OpportunitySalesProcess> LkOpportunitysalesprocessCreatedby
		{
			get { return GetRelatedEntities<OpportunitySalesProcess>("lk_opportunitysalesprocess_createdby", null); }
			set { SetRelatedEntities("lk_opportunitysalesprocess_createdby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_opportunitysalesprocess_createdonbehalfby'
        /// </summary>
		[RelationshipSchemaName("lk_opportunitysalesprocess_createdonbehalfby")]
		public IEnumerable<OpportunitySalesProcess> LkOpportunitysalesprocessCreatedonbehalfby
		{
			get { return GetRelatedEntities<OpportunitySalesProcess>("lk_opportunitysalesprocess_createdonbehalfby", null); }
			set { SetRelatedEntities("lk_opportunitysalesprocess_createdonbehalfby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_opportunitysalesprocess_modifiedby'
        /// </summary>
		[RelationshipSchemaName("lk_opportunitysalesprocess_modifiedby")]
		public IEnumerable<OpportunitySalesProcess> LkOpportunitysalesprocessModifiedby
		{
			get { return GetRelatedEntities<OpportunitySalesProcess>("lk_opportunitysalesprocess_modifiedby", null); }
			set { SetRelatedEntities("lk_opportunitysalesprocess_modifiedby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_opportunitysalesprocess_modifiedonbehalfby'
        /// </summary>
		[RelationshipSchemaName("lk_opportunitysalesprocess_modifiedonbehalfby")]
		public IEnumerable<OpportunitySalesProcess> LkOpportunitysalesprocessModifiedonbehalfby
		{
			get { return GetRelatedEntities<OpportunitySalesProcess>("lk_opportunitysalesprocess_modifiedonbehalfby", null); }
			set { SetRelatedEntities("lk_opportunitysalesprocess_modifiedonbehalfby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_orderclose_createdby'
        /// </summary>
		[RelationshipSchemaName("lk_orderclose_createdby")]
		public IEnumerable<OrderClose> LkOrdercloseCreatedby
		{
			get { return GetRelatedEntities<OrderClose>("lk_orderclose_createdby", null); }
			set { SetRelatedEntities("lk_orderclose_createdby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_orderclose_createdonbehalfby'
        /// </summary>
		[RelationshipSchemaName("lk_orderclose_createdonbehalfby")]
		public IEnumerable<OrderClose> LkOrdercloseCreatedonbehalfby
		{
			get { return GetRelatedEntities<OrderClose>("lk_orderclose_createdonbehalfby", null); }
			set { SetRelatedEntities("lk_orderclose_createdonbehalfby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_orderclose_modifiedby'
        /// </summary>
		[RelationshipSchemaName("lk_orderclose_modifiedby")]
		public IEnumerable<OrderClose> LkOrdercloseModifiedby
		{
			get { return GetRelatedEntities<OrderClose>("lk_orderclose_modifiedby", null); }
			set { SetRelatedEntities("lk_orderclose_modifiedby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_orderclose_modifiedonbehalfby'
        /// </summary>
		[RelationshipSchemaName("lk_orderclose_modifiedonbehalfby")]
		public IEnumerable<OrderClose> LkOrdercloseModifiedonbehalfby
		{
			get { return GetRelatedEntities<OrderClose>("lk_orderclose_modifiedonbehalfby", null); }
			set { SetRelatedEntities("lk_orderclose_modifiedonbehalfby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_organization_createdonbehalfby'
        /// </summary>
		[RelationshipSchemaName("lk_organization_createdonbehalfby")]
		public IEnumerable<Organization> LkOrganizationCreatedonbehalfby
		{
			get { return GetRelatedEntities<Organization>("lk_organization_createdonbehalfby", null); }
			set { SetRelatedEntities("lk_organization_createdonbehalfby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_organization_modifiedonbehalfby'
        /// </summary>
		[RelationshipSchemaName("lk_organization_modifiedonbehalfby")]
		public IEnumerable<Organization> LkOrganizationModifiedonbehalfby
		{
			get { return GetRelatedEntities<Organization>("lk_organization_modifiedonbehalfby", null); }
			set { SetRelatedEntities("lk_organization_modifiedonbehalfby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_organizationbase_createdby'
        /// </summary>
		[RelationshipSchemaName("lk_organizationbase_createdby")]
		public IEnumerable<Organization> LkOrganizationbaseCreatedby
		{
			get { return GetRelatedEntities<Organization>("lk_organizationbase_createdby", null); }
			set { SetRelatedEntities("lk_organizationbase_createdby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_organizationbase_modifiedby'
        /// </summary>
		[RelationshipSchemaName("lk_organizationbase_modifiedby")]
		public IEnumerable<Organization> LkOrganizationbaseModifiedby
		{
			get { return GetRelatedEntities<Organization>("lk_organizationbase_modifiedby", null); }
			set { SetRelatedEntities("lk_organizationbase_modifiedby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_ownermapping_createdby'
        /// </summary>
		[RelationshipSchemaName("lk_ownermapping_createdby")]
		public IEnumerable<OwnerMapping> LkOwnermappingCreatedby
		{
			get { return GetRelatedEntities<OwnerMapping>("lk_ownermapping_createdby", null); }
			set { SetRelatedEntities("lk_ownermapping_createdby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_ownermapping_createdonbehalfby'
        /// </summary>
		[RelationshipSchemaName("lk_ownermapping_createdonbehalfby")]
		public IEnumerable<OwnerMapping> LkOwnermappingCreatedonbehalfby
		{
			get { return GetRelatedEntities<OwnerMapping>("lk_ownermapping_createdonbehalfby", null); }
			set { SetRelatedEntities("lk_ownermapping_createdonbehalfby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_ownermapping_modifiedby'
        /// </summary>
		[RelationshipSchemaName("lk_ownermapping_modifiedby")]
		public IEnumerable<OwnerMapping> LkOwnermappingModifiedby
		{
			get { return GetRelatedEntities<OwnerMapping>("lk_ownermapping_modifiedby", null); }
			set { SetRelatedEntities("lk_ownermapping_modifiedby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_ownermapping_modifiedonbehalfby'
        /// </summary>
		[RelationshipSchemaName("lk_ownermapping_modifiedonbehalfby")]
		public IEnumerable<OwnerMapping> LkOwnermappingModifiedonbehalfby
		{
			get { return GetRelatedEntities<OwnerMapping>("lk_ownermapping_modifiedonbehalfby", null); }
			set { SetRelatedEntities("lk_ownermapping_modifiedonbehalfby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_package_createdby'
        /// </summary>
		[RelationshipSchemaName("lk_package_createdby")]
		public IEnumerable<Package> LkPackageCreatedby
		{
			get { return GetRelatedEntities<Package>("lk_package_createdby", null); }
			set { SetRelatedEntities("lk_package_createdby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_package_createdonbehalfby'
        /// </summary>
		[RelationshipSchemaName("lk_package_createdonbehalfby")]
		public IEnumerable<Package> LkPackageCreatedonbehalfby
		{
			get { return GetRelatedEntities<Package>("lk_package_createdonbehalfby", null); }
			set { SetRelatedEntities("lk_package_createdonbehalfby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_package_modifiedby'
        /// </summary>
		[RelationshipSchemaName("lk_package_modifiedby")]
		public IEnumerable<Package> LkPackageModifiedby
		{
			get { return GetRelatedEntities<Package>("lk_package_modifiedby", null); }
			set { SetRelatedEntities("lk_package_modifiedby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_package_modifiedonbehalfby'
        /// </summary>
		[RelationshipSchemaName("lk_package_modifiedonbehalfby")]
		public IEnumerable<Package> LkPackageModifiedonbehalfby
		{
			get { return GetRelatedEntities<Package>("lk_package_modifiedonbehalfby", null); }
			set { SetRelatedEntities("lk_package_modifiedonbehalfby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_personaldocumenttemplatebase_createdby'
        /// </summary>
		[RelationshipSchemaName("lk_personaldocumenttemplatebase_createdby")]
		public IEnumerable<PersonalDocumentTemplate> LkPersonaldocumenttemplatebaseCreatedby
		{
			get { return GetRelatedEntities<PersonalDocumentTemplate>("lk_personaldocumenttemplatebase_createdby", null); }
			set { SetRelatedEntities("lk_personaldocumenttemplatebase_createdby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_personaldocumenttemplatebase_createdonbehalfby'
        /// </summary>
		[RelationshipSchemaName("lk_personaldocumenttemplatebase_createdonbehalfby")]
		public IEnumerable<PersonalDocumentTemplate> LkPersonaldocumenttemplatebaseCreatedonbehalfby
		{
			get { return GetRelatedEntities<PersonalDocumentTemplate>("lk_personaldocumenttemplatebase_createdonbehalfby", null); }
			set { SetRelatedEntities("lk_personaldocumenttemplatebase_createdonbehalfby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_personaldocumenttemplatebase_modifiedby'
        /// </summary>
		[RelationshipSchemaName("lk_personaldocumenttemplatebase_modifiedby")]
		public IEnumerable<PersonalDocumentTemplate> LkPersonaldocumenttemplatebaseModifiedby
		{
			get { return GetRelatedEntities<PersonalDocumentTemplate>("lk_personaldocumenttemplatebase_modifiedby", null); }
			set { SetRelatedEntities("lk_personaldocumenttemplatebase_modifiedby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_personaldocumenttemplatebase_modifiedonbehalfby'
        /// </summary>
		[RelationshipSchemaName("lk_personaldocumenttemplatebase_modifiedonbehalfby")]
		public IEnumerable<PersonalDocumentTemplate> LkPersonaldocumenttemplatebaseModifiedonbehalfby
		{
			get { return GetRelatedEntities<PersonalDocumentTemplate>("lk_personaldocumenttemplatebase_modifiedonbehalfby", null); }
			set { SetRelatedEntities("lk_personaldocumenttemplatebase_modifiedonbehalfby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_phonecall_createdby'
        /// </summary>
		[RelationshipSchemaName("lk_phonecall_createdby")]
		public IEnumerable<PhoneCall> LkPhonecallCreatedby
		{
			get { return GetRelatedEntities<PhoneCall>("lk_phonecall_createdby", null); }
			set { SetRelatedEntities("lk_phonecall_createdby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_phonecall_createdonbehalfby'
        /// </summary>
		[RelationshipSchemaName("lk_phonecall_createdonbehalfby")]
		public IEnumerable<PhoneCall> LkPhonecallCreatedonbehalfby
		{
			get { return GetRelatedEntities<PhoneCall>("lk_phonecall_createdonbehalfby", null); }
			set { SetRelatedEntities("lk_phonecall_createdonbehalfby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_phonecall_modifiedby'
        /// </summary>
		[RelationshipSchemaName("lk_phonecall_modifiedby")]
		public IEnumerable<PhoneCall> LkPhonecallModifiedby
		{
			get { return GetRelatedEntities<PhoneCall>("lk_phonecall_modifiedby", null); }
			set { SetRelatedEntities("lk_phonecall_modifiedby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_phonecall_modifiedonbehalfby'
        /// </summary>
		[RelationshipSchemaName("lk_phonecall_modifiedonbehalfby")]
		public IEnumerable<PhoneCall> LkPhonecallModifiedonbehalfby
		{
			get { return GetRelatedEntities<PhoneCall>("lk_phonecall_modifiedonbehalfby", null); }
			set { SetRelatedEntities("lk_phonecall_modifiedonbehalfby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_phonetocaseprocess_createdby'
        /// </summary>
		[RelationshipSchemaName("lk_phonetocaseprocess_createdby")]
		public IEnumerable<PhoneToCaseProcess> LkPhonetocaseprocessCreatedby
		{
			get { return GetRelatedEntities<PhoneToCaseProcess>("lk_phonetocaseprocess_createdby", null); }
			set { SetRelatedEntities("lk_phonetocaseprocess_createdby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_phonetocaseprocess_createdonbehalfby'
        /// </summary>
		[RelationshipSchemaName("lk_phonetocaseprocess_createdonbehalfby")]
		public IEnumerable<PhoneToCaseProcess> LkPhonetocaseprocessCreatedonbehalfby
		{
			get { return GetRelatedEntities<PhoneToCaseProcess>("lk_phonetocaseprocess_createdonbehalfby", null); }
			set { SetRelatedEntities("lk_phonetocaseprocess_createdonbehalfby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_phonetocaseprocess_modifiedby'
        /// </summary>
		[RelationshipSchemaName("lk_phonetocaseprocess_modifiedby")]
		public IEnumerable<PhoneToCaseProcess> LkPhonetocaseprocessModifiedby
		{
			get { return GetRelatedEntities<PhoneToCaseProcess>("lk_phonetocaseprocess_modifiedby", null); }
			set { SetRelatedEntities("lk_phonetocaseprocess_modifiedby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_phonetocaseprocess_modifiedonbehalfby'
        /// </summary>
		[RelationshipSchemaName("lk_phonetocaseprocess_modifiedonbehalfby")]
		public IEnumerable<PhoneToCaseProcess> LkPhonetocaseprocessModifiedonbehalfby
		{
			get { return GetRelatedEntities<PhoneToCaseProcess>("lk_phonetocaseprocess_modifiedonbehalfby", null); }
			set { SetRelatedEntities("lk_phonetocaseprocess_modifiedonbehalfby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_picklistmapping_createdby'
        /// </summary>
		[RelationshipSchemaName("lk_picklistmapping_createdby")]
		public IEnumerable<ListValueMapping> LkPicklistmappingCreatedby
		{
			get { return GetRelatedEntities<ListValueMapping>("lk_picklistmapping_createdby", null); }
			set { SetRelatedEntities("lk_picklistmapping_createdby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_picklistmapping_createdonbehalfby'
        /// </summary>
		[RelationshipSchemaName("lk_picklistmapping_createdonbehalfby")]
		public IEnumerable<ListValueMapping> LkPicklistmappingCreatedonbehalfby
		{
			get { return GetRelatedEntities<ListValueMapping>("lk_picklistmapping_createdonbehalfby", null); }
			set { SetRelatedEntities("lk_picklistmapping_createdonbehalfby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_picklistmapping_modifiedby'
        /// </summary>
		[RelationshipSchemaName("lk_picklistmapping_modifiedby")]
		public IEnumerable<ListValueMapping> LkPicklistmappingModifiedby
		{
			get { return GetRelatedEntities<ListValueMapping>("lk_picklistmapping_modifiedby", null); }
			set { SetRelatedEntities("lk_picklistmapping_modifiedby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_picklistmapping_modifiedonbehalfby'
        /// </summary>
		[RelationshipSchemaName("lk_picklistmapping_modifiedonbehalfby")]
		public IEnumerable<ListValueMapping> LkPicklistmappingModifiedonbehalfby
		{
			get { return GetRelatedEntities<ListValueMapping>("lk_picklistmapping_modifiedonbehalfby", null); }
			set { SetRelatedEntities("lk_picklistmapping_modifiedonbehalfby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_pluginassembly_createdonbehalfby'
        /// </summary>
		[RelationshipSchemaName("lk_pluginassembly_createdonbehalfby")]
		public IEnumerable<PluginAssembly> LkPluginassemblyCreatedonbehalfby
		{
			get { return GetRelatedEntities<PluginAssembly>("lk_pluginassembly_createdonbehalfby", null); }
			set { SetRelatedEntities("lk_pluginassembly_createdonbehalfby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_pluginassembly_modifiedonbehalfby'
        /// </summary>
		[RelationshipSchemaName("lk_pluginassembly_modifiedonbehalfby")]
		public IEnumerable<PluginAssembly> LkPluginassemblyModifiedonbehalfby
		{
			get { return GetRelatedEntities<PluginAssembly>("lk_pluginassembly_modifiedonbehalfby", null); }
			set { SetRelatedEntities("lk_pluginassembly_modifiedonbehalfby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_plugintracelogbase_createdonbehalfby'
        /// </summary>
		[RelationshipSchemaName("lk_plugintracelogbase_createdonbehalfby")]
		public IEnumerable<PluginTraceLog> LkPlugintracelogbaseCreatedonbehalfby
		{
			get { return GetRelatedEntities<PluginTraceLog>("lk_plugintracelogbase_createdonbehalfby", null); }
			set { SetRelatedEntities("lk_plugintracelogbase_createdonbehalfby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_plugintype_createdonbehalfby'
        /// </summary>
		[RelationshipSchemaName("lk_plugintype_createdonbehalfby")]
		public IEnumerable<PluginType> LkPlugintypeCreatedonbehalfby
		{
			get { return GetRelatedEntities<PluginType>("lk_plugintype_createdonbehalfby", null); }
			set { SetRelatedEntities("lk_plugintype_createdonbehalfby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_plugintype_modifiedonbehalfby'
        /// </summary>
		[RelationshipSchemaName("lk_plugintype_modifiedonbehalfby")]
		public IEnumerable<PluginType> LkPlugintypeModifiedonbehalfby
		{
			get { return GetRelatedEntities<PluginType>("lk_plugintype_modifiedonbehalfby", null); }
			set { SetRelatedEntities("lk_plugintype_modifiedonbehalfby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_plugintypestatisticbase_createdonbehalfby'
        /// </summary>
		[RelationshipSchemaName("lk_plugintypestatisticbase_createdonbehalfby")]
		public IEnumerable<PluginTypeStatistic> LkPlugintypestatisticbaseCreatedonbehalfby
		{
			get { return GetRelatedEntities<PluginTypeStatistic>("lk_plugintypestatisticbase_createdonbehalfby", null); }
			set { SetRelatedEntities("lk_plugintypestatisticbase_createdonbehalfby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_plugintypestatisticbase_modifiedonbehalfby'
        /// </summary>
		[RelationshipSchemaName("lk_plugintypestatisticbase_modifiedonbehalfby")]
		public IEnumerable<PluginTypeStatistic> LkPlugintypestatisticbaseModifiedonbehalfby
		{
			get { return GetRelatedEntities<PluginTypeStatistic>("lk_plugintypestatisticbase_modifiedonbehalfby", null); }
			set { SetRelatedEntities("lk_plugintypestatisticbase_modifiedonbehalfby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_position_createdby'
        /// </summary>
		[RelationshipSchemaName("lk_position_createdby")]
		public IEnumerable<Position> LkPositionCreatedby
		{
			get { return GetRelatedEntities<Position>("lk_position_createdby", null); }
			set { SetRelatedEntities("lk_position_createdby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_position_createdonbehalfby'
        /// </summary>
		[RelationshipSchemaName("lk_position_createdonbehalfby")]
		public IEnumerable<Position> LkPositionCreatedonbehalfby
		{
			get { return GetRelatedEntities<Position>("lk_position_createdonbehalfby", null); }
			set { SetRelatedEntities("lk_position_createdonbehalfby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_position_modifiedby'
        /// </summary>
		[RelationshipSchemaName("lk_position_modifiedby")]
		public IEnumerable<Position> LkPositionModifiedby
		{
			get { return GetRelatedEntities<Position>("lk_position_modifiedby", null); }
			set { SetRelatedEntities("lk_position_modifiedby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_position_modifiedonbehalfby'
        /// </summary>
		[RelationshipSchemaName("lk_position_modifiedonbehalfby")]
		public IEnumerable<Position> LkPositionModifiedonbehalfby
		{
			get { return GetRelatedEntities<Position>("lk_position_modifiedonbehalfby", null); }
			set { SetRelatedEntities("lk_position_modifiedonbehalfby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_post_createdby'
        /// </summary>
		[RelationshipSchemaName("lk_post_createdby")]
		public IEnumerable<Post> LkPostCreatedby
		{
			get { return GetRelatedEntities<Post>("lk_post_createdby", null); }
			set { SetRelatedEntities("lk_post_createdby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_post_createdonbehalfby'
        /// </summary>
		[RelationshipSchemaName("lk_post_createdonbehalfby")]
		public IEnumerable<Post> LkPostCreatedonbehalfby
		{
			get { return GetRelatedEntities<Post>("lk_post_createdonbehalfby", null); }
			set { SetRelatedEntities("lk_post_createdonbehalfby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_post_modifiedby'
        /// </summary>
		[RelationshipSchemaName("lk_post_modifiedby")]
		public IEnumerable<Post> LkPostModifiedby
		{
			get { return GetRelatedEntities<Post>("lk_post_modifiedby", null); }
			set { SetRelatedEntities("lk_post_modifiedby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_post_modifiedonbehalfby'
        /// </summary>
		[RelationshipSchemaName("lk_post_modifiedonbehalfby")]
		public IEnumerable<Post> LkPostModifiedonbehalfby
		{
			get { return GetRelatedEntities<Post>("lk_post_modifiedonbehalfby", null); }
			set { SetRelatedEntities("lk_post_modifiedonbehalfby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_postcomment_createdby'
        /// </summary>
		[RelationshipSchemaName("lk_postcomment_createdby")]
		public IEnumerable<Comment> LkPostcommentCreatedby
		{
			get { return GetRelatedEntities<Comment>("lk_postcomment_createdby", null); }
			set { SetRelatedEntities("lk_postcomment_createdby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_postcomment_createdonbehalfby'
        /// </summary>
		[RelationshipSchemaName("lk_postcomment_createdonbehalfby")]
		public IEnumerable<Comment> LkPostcommentCreatedonbehalfby
		{
			get { return GetRelatedEntities<Comment>("lk_postcomment_createdonbehalfby", null); }
			set { SetRelatedEntities("lk_postcomment_createdonbehalfby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_PostFollow_createdby'
        /// </summary>
		[RelationshipSchemaName("lk_PostFollow_createdby")]
		public IEnumerable<Follow> LkPostFollowCreatedby
		{
			get { return GetRelatedEntities<Follow>("lk_PostFollow_createdby", null); }
			set { SetRelatedEntities("lk_PostFollow_createdby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_postfollow_createdonbehalfby'
        /// </summary>
		[RelationshipSchemaName("lk_postfollow_createdonbehalfby")]
		public IEnumerable<Follow> LkPostfollowCreatedonbehalfby
		{
			get { return GetRelatedEntities<Follow>("lk_postfollow_createdonbehalfby", null); }
			set { SetRelatedEntities("lk_postfollow_createdonbehalfby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_postlike_createdby'
        /// </summary>
		[RelationshipSchemaName("lk_postlike_createdby")]
		public IEnumerable<Like> LkPostlikeCreatedby
		{
			get { return GetRelatedEntities<Like>("lk_postlike_createdby", null); }
			set { SetRelatedEntities("lk_postlike_createdby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_postlike_createdonbehalfby'
        /// </summary>
		[RelationshipSchemaName("lk_postlike_createdonbehalfby")]
		public IEnumerable<Like> LkPostlikeCreatedonbehalfby
		{
			get { return GetRelatedEntities<Like>("lk_postlike_createdonbehalfby", null); }
			set { SetRelatedEntities("lk_postlike_createdonbehalfby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_pricelevel_createdonbehalfby'
        /// </summary>
		[RelationshipSchemaName("lk_pricelevel_createdonbehalfby")]
		public IEnumerable<PriceList> LkPricelevelCreatedonbehalfby
		{
			get { return GetRelatedEntities<PriceList>("lk_pricelevel_createdonbehalfby", null); }
			set { SetRelatedEntities("lk_pricelevel_createdonbehalfby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_pricelevel_modifiedonbehalfby'
        /// </summary>
		[RelationshipSchemaName("lk_pricelevel_modifiedonbehalfby")]
		public IEnumerable<PriceList> LkPricelevelModifiedonbehalfby
		{
			get { return GetRelatedEntities<PriceList>("lk_pricelevel_modifiedonbehalfby", null); }
			set { SetRelatedEntities("lk_pricelevel_modifiedonbehalfby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_pricelevelbase_createdby'
        /// </summary>
		[RelationshipSchemaName("lk_pricelevelbase_createdby")]
		public IEnumerable<PriceList> LkPricelevelbaseCreatedby
		{
			get { return GetRelatedEntities<PriceList>("lk_pricelevelbase_createdby", null); }
			set { SetRelatedEntities("lk_pricelevelbase_createdby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_pricelevelbase_modifiedby'
        /// </summary>
		[RelationshipSchemaName("lk_pricelevelbase_modifiedby")]
		public IEnumerable<PriceList> LkPricelevelbaseModifiedby
		{
			get { return GetRelatedEntities<PriceList>("lk_pricelevelbase_modifiedby", null); }
			set { SetRelatedEntities("lk_pricelevelbase_modifiedby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_processsession_canceledby'
        /// </summary>
		[RelationshipSchemaName("lk_processsession_canceledby")]
		public IEnumerable<ProcessSession> LkProcesssessionCanceledby
		{
			get { return GetRelatedEntities<ProcessSession>("lk_processsession_canceledby", null); }
			set { SetRelatedEntities("lk_processsession_canceledby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_processsession_completedby'
        /// </summary>
		[RelationshipSchemaName("lk_processsession_completedby")]
		public IEnumerable<ProcessSession> LkProcesssessionCompletedby
		{
			get { return GetRelatedEntities<ProcessSession>("lk_processsession_completedby", null); }
			set { SetRelatedEntities("lk_processsession_completedby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_processsession_createdby'
        /// </summary>
		[RelationshipSchemaName("lk_processsession_createdby")]
		public IEnumerable<ProcessSession> LkProcesssessionCreatedby
		{
			get { return GetRelatedEntities<ProcessSession>("lk_processsession_createdby", null); }
			set { SetRelatedEntities("lk_processsession_createdby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_processsession_executedby'
        /// </summary>
		[RelationshipSchemaName("lk_processsession_executedby")]
		public IEnumerable<ProcessSession> LkProcesssessionExecutedby
		{
			get { return GetRelatedEntities<ProcessSession>("lk_processsession_executedby", null); }
			set { SetRelatedEntities("lk_processsession_executedby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_processsession_modifiedby'
        /// </summary>
		[RelationshipSchemaName("lk_processsession_modifiedby")]
		public IEnumerable<ProcessSession> LkProcesssessionModifiedby
		{
			get { return GetRelatedEntities<ProcessSession>("lk_processsession_modifiedby", null); }
			set { SetRelatedEntities("lk_processsession_modifiedby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_processsession_startedby'
        /// </summary>
		[RelationshipSchemaName("lk_processsession_startedby")]
		public IEnumerable<ProcessSession> LkProcesssessionStartedby
		{
			get { return GetRelatedEntities<ProcessSession>("lk_processsession_startedby", null); }
			set { SetRelatedEntities("lk_processsession_startedby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_processsessionbase_createdonbehalfby'
        /// </summary>
		[RelationshipSchemaName("lk_processsessionbase_createdonbehalfby")]
		public IEnumerable<ProcessSession> LkProcesssessionbaseCreatedonbehalfby
		{
			get { return GetRelatedEntities<ProcessSession>("lk_processsessionbase_createdonbehalfby", null); }
			set { SetRelatedEntities("lk_processsessionbase_createdonbehalfby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_processsessionbase_modifiedonbehalfby'
        /// </summary>
		[RelationshipSchemaName("lk_processsessionbase_modifiedonbehalfby")]
		public IEnumerable<ProcessSession> LkProcesssessionbaseModifiedonbehalfby
		{
			get { return GetRelatedEntities<ProcessSession>("lk_processsessionbase_modifiedonbehalfby", null); }
			set { SetRelatedEntities("lk_processsessionbase_modifiedonbehalfby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_processstageparameter_createdby'
        /// </summary>
		[RelationshipSchemaName("lk_processstageparameter_createdby")]
		public IEnumerable<ProcessStageParameter> LkProcessstageparameterCreatedby
		{
			get { return GetRelatedEntities<ProcessStageParameter>("lk_processstageparameter_createdby", null); }
			set { SetRelatedEntities("lk_processstageparameter_createdby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_processstageparameter_createdonbehalfby'
        /// </summary>
		[RelationshipSchemaName("lk_processstageparameter_createdonbehalfby")]
		public IEnumerable<ProcessStageParameter> LkProcessstageparameterCreatedonbehalfby
		{
			get { return GetRelatedEntities<ProcessStageParameter>("lk_processstageparameter_createdonbehalfby", null); }
			set { SetRelatedEntities("lk_processstageparameter_createdonbehalfby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_processstageparameter_modifiedby'
        /// </summary>
		[RelationshipSchemaName("lk_processstageparameter_modifiedby")]
		public IEnumerable<ProcessStageParameter> LkProcessstageparameterModifiedby
		{
			get { return GetRelatedEntities<ProcessStageParameter>("lk_processstageparameter_modifiedby", null); }
			set { SetRelatedEntities("lk_processstageparameter_modifiedby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_processstageparameter_modifiedonbehalfby'
        /// </summary>
		[RelationshipSchemaName("lk_processstageparameter_modifiedonbehalfby")]
		public IEnumerable<ProcessStageParameter> LkProcessstageparameterModifiedonbehalfby
		{
			get { return GetRelatedEntities<ProcessStageParameter>("lk_processstageparameter_modifiedonbehalfby", null); }
			set { SetRelatedEntities("lk_processstageparameter_modifiedonbehalfby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_processtriggerbase_createdby'
        /// </summary>
		[RelationshipSchemaName("lk_processtriggerbase_createdby")]
		public IEnumerable<ProcessTrigger> LkProcesstriggerbaseCreatedby
		{
			get { return GetRelatedEntities<ProcessTrigger>("lk_processtriggerbase_createdby", null); }
			set { SetRelatedEntities("lk_processtriggerbase_createdby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_processtriggerbase_createdonbehalfby'
        /// </summary>
		[RelationshipSchemaName("lk_processtriggerbase_createdonbehalfby")]
		public IEnumerable<ProcessTrigger> LkProcesstriggerbaseCreatedonbehalfby
		{
			get { return GetRelatedEntities<ProcessTrigger>("lk_processtriggerbase_createdonbehalfby", null); }
			set { SetRelatedEntities("lk_processtriggerbase_createdonbehalfby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_processtriggerbase_modifiedby'
        /// </summary>
		[RelationshipSchemaName("lk_processtriggerbase_modifiedby")]
		public IEnumerable<ProcessTrigger> LkProcesstriggerbaseModifiedby
		{
			get { return GetRelatedEntities<ProcessTrigger>("lk_processtriggerbase_modifiedby", null); }
			set { SetRelatedEntities("lk_processtriggerbase_modifiedby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_processtriggerbase_modifiedonbehalfby'
        /// </summary>
		[RelationshipSchemaName("lk_processtriggerbase_modifiedonbehalfby")]
		public IEnumerable<ProcessTrigger> LkProcesstriggerbaseModifiedonbehalfby
		{
			get { return GetRelatedEntities<ProcessTrigger>("lk_processtriggerbase_modifiedonbehalfby", null); }
			set { SetRelatedEntities("lk_processtriggerbase_modifiedonbehalfby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_product_createdonbehalfby'
        /// </summary>
		[RelationshipSchemaName("lk_product_createdonbehalfby")]
		public IEnumerable<Product> LkProductCreatedonbehalfby
		{
			get { return GetRelatedEntities<Product>("lk_product_createdonbehalfby", null); }
			set { SetRelatedEntities("lk_product_createdonbehalfby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_product_modifiedonbehalfby'
        /// </summary>
		[RelationshipSchemaName("lk_product_modifiedonbehalfby")]
		public IEnumerable<Product> LkProductModifiedonbehalfby
		{
			get { return GetRelatedEntities<Product>("lk_product_modifiedonbehalfby", null); }
			set { SetRelatedEntities("lk_product_modifiedonbehalfby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_ProductAssociate_createdby'
        /// </summary>
		[RelationshipSchemaName("lk_ProductAssociate_createdby")]
		public IEnumerable<ProductAssociation> LkProductAssociateCreatedby
		{
			get { return GetRelatedEntities<ProductAssociation>("lk_ProductAssociate_createdby", null); }
			set { SetRelatedEntities("lk_ProductAssociate_createdby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_ProductAssociation_createdonbehalfby'
        /// </summary>
		[RelationshipSchemaName("lk_ProductAssociation_createdonbehalfby")]
		public IEnumerable<ProductAssociation> LkProductAssociationCreatedonbehalfby
		{
			get { return GetRelatedEntities<ProductAssociation>("lk_ProductAssociation_createdonbehalfby", null); }
			set { SetRelatedEntities("lk_ProductAssociation_createdonbehalfby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_ProductAssociation_modifiedby'
        /// </summary>
		[RelationshipSchemaName("lk_ProductAssociation_modifiedby")]
		public IEnumerable<ProductAssociation> LkProductAssociationModifiedby
		{
			get { return GetRelatedEntities<ProductAssociation>("lk_ProductAssociation_modifiedby", null); }
			set { SetRelatedEntities("lk_ProductAssociation_modifiedby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_ProductAssociation_modifiedonbehalfby'
        /// </summary>
		[RelationshipSchemaName("lk_ProductAssociation_modifiedonbehalfby")]
		public IEnumerable<ProductAssociation> LkProductAssociationModifiedonbehalfby
		{
			get { return GetRelatedEntities<ProductAssociation>("lk_ProductAssociation_modifiedonbehalfby", null); }
			set { SetRelatedEntities("lk_ProductAssociation_modifiedonbehalfby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_productbase_createdby'
        /// </summary>
		[RelationshipSchemaName("lk_productbase_createdby")]
		public IEnumerable<Product> LkProductbaseCreatedby
		{
			get { return GetRelatedEntities<Product>("lk_productbase_createdby", null); }
			set { SetRelatedEntities("lk_productbase_createdby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_productbase_modifiedby'
        /// </summary>
		[RelationshipSchemaName("lk_productbase_modifiedby")]
		public IEnumerable<Product> LkProductbaseModifiedby
		{
			get { return GetRelatedEntities<Product>("lk_productbase_modifiedby", null); }
			set { SetRelatedEntities("lk_productbase_modifiedby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_productpricelevel_createdonbehalfby'
        /// </summary>
		[RelationshipSchemaName("lk_productpricelevel_createdonbehalfby")]
		public IEnumerable<PriceListItem> LkProductpricelevelCreatedonbehalfby
		{
			get { return GetRelatedEntities<PriceListItem>("lk_productpricelevel_createdonbehalfby", null); }
			set { SetRelatedEntities("lk_productpricelevel_createdonbehalfby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_productpricelevel_modifiedonbehalfby'
        /// </summary>
		[RelationshipSchemaName("lk_productpricelevel_modifiedonbehalfby")]
		public IEnumerable<PriceListItem> LkProductpricelevelModifiedonbehalfby
		{
			get { return GetRelatedEntities<PriceListItem>("lk_productpricelevel_modifiedonbehalfby", null); }
			set { SetRelatedEntities("lk_productpricelevel_modifiedonbehalfby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_productpricelevelbase_createdby'
        /// </summary>
		[RelationshipSchemaName("lk_productpricelevelbase_createdby")]
		public IEnumerable<PriceListItem> LkProductpricelevelbaseCreatedby
		{
			get { return GetRelatedEntities<PriceListItem>("lk_productpricelevelbase_createdby", null); }
			set { SetRelatedEntities("lk_productpricelevelbase_createdby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_productpricelevelbase_modifiedby'
        /// </summary>
		[RelationshipSchemaName("lk_productpricelevelbase_modifiedby")]
		public IEnumerable<PriceListItem> LkProductpricelevelbaseModifiedby
		{
			get { return GetRelatedEntities<PriceListItem>("lk_productpricelevelbase_modifiedby", null); }
			set { SetRelatedEntities("lk_productpricelevelbase_modifiedby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_ProductSubstitute_createdby'
        /// </summary>
		[RelationshipSchemaName("lk_ProductSubstitute_createdby")]
		public IEnumerable<ProductRelationship> LkProductSubstituteCreatedby
		{
			get { return GetRelatedEntities<ProductRelationship>("lk_ProductSubstitute_createdby", null); }
			set { SetRelatedEntities("lk_ProductSubstitute_createdby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_ProductSubstitute_createdonbehalfby'
        /// </summary>
		[RelationshipSchemaName("lk_ProductSubstitute_createdonbehalfby")]
		public IEnumerable<ProductRelationship> LkProductSubstituteCreatedonbehalfby
		{
			get { return GetRelatedEntities<ProductRelationship>("lk_ProductSubstitute_createdonbehalfby", null); }
			set { SetRelatedEntities("lk_ProductSubstitute_createdonbehalfby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_ProductSubstitute_modifiedby'
        /// </summary>
		[RelationshipSchemaName("lk_ProductSubstitute_modifiedby")]
		public IEnumerable<ProductRelationship> LkProductSubstituteModifiedby
		{
			get { return GetRelatedEntities<ProductRelationship>("lk_ProductSubstitute_modifiedby", null); }
			set { SetRelatedEntities("lk_ProductSubstitute_modifiedby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_ProductSubstitute_modifiedonbehalfby'
        /// </summary>
		[RelationshipSchemaName("lk_ProductSubstitute_modifiedonbehalfby")]
		public IEnumerable<ProductRelationship> LkProductSubstituteModifiedonbehalfby
		{
			get { return GetRelatedEntities<ProductRelationship>("lk_ProductSubstitute_modifiedonbehalfby", null); }
			set { SetRelatedEntities("lk_ProductSubstitute_modifiedonbehalfby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_publisher_createdby'
        /// </summary>
		[RelationshipSchemaName("lk_publisher_createdby")]
		public IEnumerable<Publisher> LkPublisherCreatedby
		{
			get { return GetRelatedEntities<Publisher>("lk_publisher_createdby", null); }
			set { SetRelatedEntities("lk_publisher_createdby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_publisher_modifiedby'
        /// </summary>
		[RelationshipSchemaName("lk_publisher_modifiedby")]
		public IEnumerable<Publisher> LkPublisherModifiedby
		{
			get { return GetRelatedEntities<Publisher>("lk_publisher_modifiedby", null); }
			set { SetRelatedEntities("lk_publisher_modifiedby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_publisheraddressbase_createdby'
        /// </summary>
		[RelationshipSchemaName("lk_publisheraddressbase_createdby")]
		public IEnumerable<PublisherAddress> LkPublisheraddressbaseCreatedby
		{
			get { return GetRelatedEntities<PublisherAddress>("lk_publisheraddressbase_createdby", null); }
			set { SetRelatedEntities("lk_publisheraddressbase_createdby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_publisheraddressbase_createdonbehalfby'
        /// </summary>
		[RelationshipSchemaName("lk_publisheraddressbase_createdonbehalfby")]
		public IEnumerable<PublisherAddress> LkPublisheraddressbaseCreatedonbehalfby
		{
			get { return GetRelatedEntities<PublisherAddress>("lk_publisheraddressbase_createdonbehalfby", null); }
			set { SetRelatedEntities("lk_publisheraddressbase_createdonbehalfby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_publisheraddressbase_modifiedby'
        /// </summary>
		[RelationshipSchemaName("lk_publisheraddressbase_modifiedby")]
		public IEnumerable<PublisherAddress> LkPublisheraddressbaseModifiedby
		{
			get { return GetRelatedEntities<PublisherAddress>("lk_publisheraddressbase_modifiedby", null); }
			set { SetRelatedEntities("lk_publisheraddressbase_modifiedby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_publisheraddressbase_modifiedonbehalfby'
        /// </summary>
		[RelationshipSchemaName("lk_publisheraddressbase_modifiedonbehalfby")]
		public IEnumerable<PublisherAddress> LkPublisheraddressbaseModifiedonbehalfby
		{
			get { return GetRelatedEntities<PublisherAddress>("lk_publisheraddressbase_modifiedonbehalfby", null); }
			set { SetRelatedEntities("lk_publisheraddressbase_modifiedonbehalfby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_publisherbase_createdonbehalfby'
        /// </summary>
		[RelationshipSchemaName("lk_publisherbase_createdonbehalfby")]
		public IEnumerable<Publisher> LkPublisherbaseCreatedonbehalfby
		{
			get { return GetRelatedEntities<Publisher>("lk_publisherbase_createdonbehalfby", null); }
			set { SetRelatedEntities("lk_publisherbase_createdonbehalfby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_publisherbase_modifiedonbehalfby'
        /// </summary>
		[RelationshipSchemaName("lk_publisherbase_modifiedonbehalfby")]
		public IEnumerable<Publisher> LkPublisherbaseModifiedonbehalfby
		{
			get { return GetRelatedEntities<Publisher>("lk_publisherbase_modifiedonbehalfby", null); }
			set { SetRelatedEntities("lk_publisherbase_modifiedonbehalfby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_pw_penta_schedule_run_createdby'
        /// </summary>
		[RelationshipSchemaName("lk_pw_penta_schedule_run_createdby")]
		public IEnumerable<PentaScheduleRun> LkPwPentaScheduleRunCreatedby
		{
			get { return GetRelatedEntities<PentaScheduleRun>("lk_pw_penta_schedule_run_createdby", null); }
			set { SetRelatedEntities("lk_pw_penta_schedule_run_createdby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_pw_penta_schedule_run_createdonbehalfby'
        /// </summary>
		[RelationshipSchemaName("lk_pw_penta_schedule_run_createdonbehalfby")]
		public IEnumerable<PentaScheduleRun> LkPwPentaScheduleRunCreatedonbehalfby
		{
			get { return GetRelatedEntities<PentaScheduleRun>("lk_pw_penta_schedule_run_createdonbehalfby", null); }
			set { SetRelatedEntities("lk_pw_penta_schedule_run_createdonbehalfby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_pw_penta_schedule_run_modifiedby'
        /// </summary>
		[RelationshipSchemaName("lk_pw_penta_schedule_run_modifiedby")]
		public IEnumerable<PentaScheduleRun> LkPwPentaScheduleRunModifiedby
		{
			get { return GetRelatedEntities<PentaScheduleRun>("lk_pw_penta_schedule_run_modifiedby", null); }
			set { SetRelatedEntities("lk_pw_penta_schedule_run_modifiedby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_pw_penta_schedule_run_modifiedonbehalfby'
        /// </summary>
		[RelationshipSchemaName("lk_pw_penta_schedule_run_modifiedonbehalfby")]
		public IEnumerable<PentaScheduleRun> LkPwPentaScheduleRunModifiedonbehalfby
		{
			get { return GetRelatedEntities<PentaScheduleRun>("lk_pw_penta_schedule_run_modifiedonbehalfby", null); }
			set { SetRelatedEntities("lk_pw_penta_schedule_run_modifiedonbehalfby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_pw_schedule_createdby'
        /// </summary>
		[RelationshipSchemaName("lk_pw_schedule_createdby")]
		public IEnumerable<PentaSchedule> LkPwScheduleCreatedby
		{
			get { return GetRelatedEntities<PentaSchedule>("lk_pw_schedule_createdby", null); }
			set { SetRelatedEntities("lk_pw_schedule_createdby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_pw_schedule_createdonbehalfby'
        /// </summary>
		[RelationshipSchemaName("lk_pw_schedule_createdonbehalfby")]
		public IEnumerable<PentaSchedule> LkPwScheduleCreatedonbehalfby
		{
			get { return GetRelatedEntities<PentaSchedule>("lk_pw_schedule_createdonbehalfby", null); }
			set { SetRelatedEntities("lk_pw_schedule_createdonbehalfby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_pw_schedule_modifiedby'
        /// </summary>
		[RelationshipSchemaName("lk_pw_schedule_modifiedby")]
		public IEnumerable<PentaSchedule> LkPwScheduleModifiedby
		{
			get { return GetRelatedEntities<PentaSchedule>("lk_pw_schedule_modifiedby", null); }
			set { SetRelatedEntities("lk_pw_schedule_modifiedby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_pw_schedule_modifiedonbehalfby'
        /// </summary>
		[RelationshipSchemaName("lk_pw_schedule_modifiedonbehalfby")]
		public IEnumerable<PentaSchedule> LkPwScheduleModifiedonbehalfby
		{
			get { return GetRelatedEntities<PentaSchedule>("lk_pw_schedule_modifiedonbehalfby", null); }
			set { SetRelatedEntities("lk_pw_schedule_modifiedonbehalfby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_quarterlyfiscalcalendar_createdby'
        /// </summary>
		[RelationshipSchemaName("lk_quarterlyfiscalcalendar_createdby")]
		public IEnumerable<QuarterlyFiscalCalendar> LkQuarterlyfiscalcalendarCreatedby
		{
			get { return GetRelatedEntities<QuarterlyFiscalCalendar>("lk_quarterlyfiscalcalendar_createdby", null); }
			set { SetRelatedEntities("lk_quarterlyfiscalcalendar_createdby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_quarterlyfiscalcalendar_createdonbehalfby'
        /// </summary>
		[RelationshipSchemaName("lk_quarterlyfiscalcalendar_createdonbehalfby")]
		public IEnumerable<QuarterlyFiscalCalendar> LkQuarterlyfiscalcalendarCreatedonbehalfby
		{
			get { return GetRelatedEntities<QuarterlyFiscalCalendar>("lk_quarterlyfiscalcalendar_createdonbehalfby", null); }
			set { SetRelatedEntities("lk_quarterlyfiscalcalendar_createdonbehalfby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_quarterlyfiscalcalendar_modifiedby'
        /// </summary>
		[RelationshipSchemaName("lk_quarterlyfiscalcalendar_modifiedby")]
		public IEnumerable<QuarterlyFiscalCalendar> LkQuarterlyfiscalcalendarModifiedby
		{
			get { return GetRelatedEntities<QuarterlyFiscalCalendar>("lk_quarterlyfiscalcalendar_modifiedby", null); }
			set { SetRelatedEntities("lk_quarterlyfiscalcalendar_modifiedby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_quarterlyfiscalcalendar_modifiedonbehalfby'
        /// </summary>
		[RelationshipSchemaName("lk_quarterlyfiscalcalendar_modifiedonbehalfby")]
		public IEnumerable<QuarterlyFiscalCalendar> LkQuarterlyfiscalcalendarModifiedonbehalfby
		{
			get { return GetRelatedEntities<QuarterlyFiscalCalendar>("lk_quarterlyfiscalcalendar_modifiedonbehalfby", null); }
			set { SetRelatedEntities("lk_quarterlyfiscalcalendar_modifiedonbehalfby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_quarterlyfiscalcalendar_salespersonid'
        /// </summary>
		[RelationshipSchemaName("lk_quarterlyfiscalcalendar_salespersonid")]
		public IEnumerable<QuarterlyFiscalCalendar> LkQuarterlyfiscalcalendarSalespersonid
		{
			get { return GetRelatedEntities<QuarterlyFiscalCalendar>("lk_quarterlyfiscalcalendar_salespersonid", null); }
			set { SetRelatedEntities("lk_quarterlyfiscalcalendar_salespersonid", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_queue_createdonbehalfby'
        /// </summary>
		[RelationshipSchemaName("lk_queue_createdonbehalfby")]
		public IEnumerable<Queue> LkQueueCreatedonbehalfby
		{
			get { return GetRelatedEntities<Queue>("lk_queue_createdonbehalfby", null); }
			set { SetRelatedEntities("lk_queue_createdonbehalfby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_queue_modifiedonbehalfby'
        /// </summary>
		[RelationshipSchemaName("lk_queue_modifiedonbehalfby")]
		public IEnumerable<Queue> LkQueueModifiedonbehalfby
		{
			get { return GetRelatedEntities<Queue>("lk_queue_modifiedonbehalfby", null); }
			set { SetRelatedEntities("lk_queue_modifiedonbehalfby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_queuebase_createdby'
        /// </summary>
		[RelationshipSchemaName("lk_queuebase_createdby")]
		public IEnumerable<Queue> LkQueuebaseCreatedby
		{
			get { return GetRelatedEntities<Queue>("lk_queuebase_createdby", null); }
			set { SetRelatedEntities("lk_queuebase_createdby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_queuebase_modifiedby'
        /// </summary>
		[RelationshipSchemaName("lk_queuebase_modifiedby")]
		public IEnumerable<Queue> LkQueuebaseModifiedby
		{
			get { return GetRelatedEntities<Queue>("lk_queuebase_modifiedby", null); }
			set { SetRelatedEntities("lk_queuebase_modifiedby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_queueitem_createdonbehalfby'
        /// </summary>
		[RelationshipSchemaName("lk_queueitem_createdonbehalfby")]
		public IEnumerable<QueueItem> LkQueueitemCreatedonbehalfby
		{
			get { return GetRelatedEntities<QueueItem>("lk_queueitem_createdonbehalfby", null); }
			set { SetRelatedEntities("lk_queueitem_createdonbehalfby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_queueitem_modifiedonbehalfby'
        /// </summary>
		[RelationshipSchemaName("lk_queueitem_modifiedonbehalfby")]
		public IEnumerable<QueueItem> LkQueueitemModifiedonbehalfby
		{
			get { return GetRelatedEntities<QueueItem>("lk_queueitem_modifiedonbehalfby", null); }
			set { SetRelatedEntities("lk_queueitem_modifiedonbehalfby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_queueitembase_createdby'
        /// </summary>
		[RelationshipSchemaName("lk_queueitembase_createdby")]
		public IEnumerable<QueueItem> LkQueueitembaseCreatedby
		{
			get { return GetRelatedEntities<QueueItem>("lk_queueitembase_createdby", null); }
			set { SetRelatedEntities("lk_queueitembase_createdby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_queueitembase_modifiedby'
        /// </summary>
		[RelationshipSchemaName("lk_queueitembase_modifiedby")]
		public IEnumerable<QueueItem> LkQueueitembaseModifiedby
		{
			get { return GetRelatedEntities<QueueItem>("lk_queueitembase_modifiedby", null); }
			set { SetRelatedEntities("lk_queueitembase_modifiedby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_queueitembase_workerid'
        /// </summary>
		[RelationshipSchemaName("lk_queueitembase_workerid")]
		public IEnumerable<QueueItem> LkQueueitembaseWorkerid
		{
			get { return GetRelatedEntities<QueueItem>("lk_queueitembase_workerid", null); }
			set { SetRelatedEntities("lk_queueitembase_workerid", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_quote_createdonbehalfby'
        /// </summary>
		[RelationshipSchemaName("lk_quote_createdonbehalfby")]
		public IEnumerable<Quote> LkQuoteCreatedonbehalfby
		{
			get { return GetRelatedEntities<Quote>("lk_quote_createdonbehalfby", null); }
			set { SetRelatedEntities("lk_quote_createdonbehalfby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_quote_modifiedonbehalfby'
        /// </summary>
		[RelationshipSchemaName("lk_quote_modifiedonbehalfby")]
		public IEnumerable<Quote> LkQuoteModifiedonbehalfby
		{
			get { return GetRelatedEntities<Quote>("lk_quote_modifiedonbehalfby", null); }
			set { SetRelatedEntities("lk_quote_modifiedonbehalfby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_quotebase_createdby'
        /// </summary>
		[RelationshipSchemaName("lk_quotebase_createdby")]
		public IEnumerable<Quote> LkQuotebaseCreatedby
		{
			get { return GetRelatedEntities<Quote>("lk_quotebase_createdby", null); }
			set { SetRelatedEntities("lk_quotebase_createdby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_quotebase_modifiedby'
        /// </summary>
		[RelationshipSchemaName("lk_quotebase_modifiedby")]
		public IEnumerable<Quote> LkQuotebaseModifiedby
		{
			get { return GetRelatedEntities<Quote>("lk_quotebase_modifiedby", null); }
			set { SetRelatedEntities("lk_quotebase_modifiedby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_quoteclose_createdby'
        /// </summary>
		[RelationshipSchemaName("lk_quoteclose_createdby")]
		public IEnumerable<QuoteClose> LkQuotecloseCreatedby
		{
			get { return GetRelatedEntities<QuoteClose>("lk_quoteclose_createdby", null); }
			set { SetRelatedEntities("lk_quoteclose_createdby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_quoteclose_createdonbehalfby'
        /// </summary>
		[RelationshipSchemaName("lk_quoteclose_createdonbehalfby")]
		public IEnumerable<QuoteClose> LkQuotecloseCreatedonbehalfby
		{
			get { return GetRelatedEntities<QuoteClose>("lk_quoteclose_createdonbehalfby", null); }
			set { SetRelatedEntities("lk_quoteclose_createdonbehalfby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_quoteclose_modifiedby'
        /// </summary>
		[RelationshipSchemaName("lk_quoteclose_modifiedby")]
		public IEnumerable<QuoteClose> LkQuotecloseModifiedby
		{
			get { return GetRelatedEntities<QuoteClose>("lk_quoteclose_modifiedby", null); }
			set { SetRelatedEntities("lk_quoteclose_modifiedby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_quoteclose_modifiedonbehalfby'
        /// </summary>
		[RelationshipSchemaName("lk_quoteclose_modifiedonbehalfby")]
		public IEnumerable<QuoteClose> LkQuotecloseModifiedonbehalfby
		{
			get { return GetRelatedEntities<QuoteClose>("lk_quoteclose_modifiedonbehalfby", null); }
			set { SetRelatedEntities("lk_quoteclose_modifiedonbehalfby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_quotedetail_createdonbehalfby'
        /// </summary>
		[RelationshipSchemaName("lk_quotedetail_createdonbehalfby")]
		public IEnumerable<QuoteProduct> LkQuotedetailCreatedonbehalfby
		{
			get { return GetRelatedEntities<QuoteProduct>("lk_quotedetail_createdonbehalfby", null); }
			set { SetRelatedEntities("lk_quotedetail_createdonbehalfby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_quotedetail_modifiedonbehalfby'
        /// </summary>
		[RelationshipSchemaName("lk_quotedetail_modifiedonbehalfby")]
		public IEnumerable<QuoteProduct> LkQuotedetailModifiedonbehalfby
		{
			get { return GetRelatedEntities<QuoteProduct>("lk_quotedetail_modifiedonbehalfby", null); }
			set { SetRelatedEntities("lk_quotedetail_modifiedonbehalfby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_quotedetailbase_createdby'
        /// </summary>
		[RelationshipSchemaName("lk_quotedetailbase_createdby")]
		public IEnumerable<QuoteProduct> LkQuotedetailbaseCreatedby
		{
			get { return GetRelatedEntities<QuoteProduct>("lk_quotedetailbase_createdby", null); }
			set { SetRelatedEntities("lk_quotedetailbase_createdby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_quotedetailbase_modifiedby'
        /// </summary>
		[RelationshipSchemaName("lk_quotedetailbase_modifiedby")]
		public IEnumerable<QuoteProduct> LkQuotedetailbaseModifiedby
		{
			get { return GetRelatedEntities<QuoteProduct>("lk_quotedetailbase_modifiedby", null); }
			set { SetRelatedEntities("lk_quotedetailbase_modifiedby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_ratingmodel_createdby'
        /// </summary>
		[RelationshipSchemaName("lk_ratingmodel_createdby")]
		public IEnumerable<RatingModel> LkRatingmodelCreatedby
		{
			get { return GetRelatedEntities<RatingModel>("lk_ratingmodel_createdby", null); }
			set { SetRelatedEntities("lk_ratingmodel_createdby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_ratingmodel_createdonbehalfby'
        /// </summary>
		[RelationshipSchemaName("lk_ratingmodel_createdonbehalfby")]
		public IEnumerable<RatingModel> LkRatingmodelCreatedonbehalfby
		{
			get { return GetRelatedEntities<RatingModel>("lk_ratingmodel_createdonbehalfby", null); }
			set { SetRelatedEntities("lk_ratingmodel_createdonbehalfby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_ratingmodel_modifiedby'
        /// </summary>
		[RelationshipSchemaName("lk_ratingmodel_modifiedby")]
		public IEnumerable<RatingModel> LkRatingmodelModifiedby
		{
			get { return GetRelatedEntities<RatingModel>("lk_ratingmodel_modifiedby", null); }
			set { SetRelatedEntities("lk_ratingmodel_modifiedby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_ratingmodel_modifiedonbehalfby'
        /// </summary>
		[RelationshipSchemaName("lk_ratingmodel_modifiedonbehalfby")]
		public IEnumerable<RatingModel> LkRatingmodelModifiedonbehalfby
		{
			get { return GetRelatedEntities<RatingModel>("lk_ratingmodel_modifiedonbehalfby", null); }
			set { SetRelatedEntities("lk_ratingmodel_modifiedonbehalfby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_ratingvalue_createdby'
        /// </summary>
		[RelationshipSchemaName("lk_ratingvalue_createdby")]
		public IEnumerable<RatingValue> LkRatingvalueCreatedby
		{
			get { return GetRelatedEntities<RatingValue>("lk_ratingvalue_createdby", null); }
			set { SetRelatedEntities("lk_ratingvalue_createdby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_ratingvalue_createdonbehalfby'
        /// </summary>
		[RelationshipSchemaName("lk_ratingvalue_createdonbehalfby")]
		public IEnumerable<RatingValue> LkRatingvalueCreatedonbehalfby
		{
			get { return GetRelatedEntities<RatingValue>("lk_ratingvalue_createdonbehalfby", null); }
			set { SetRelatedEntities("lk_ratingvalue_createdonbehalfby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_ratingvalue_modifiedby'
        /// </summary>
		[RelationshipSchemaName("lk_ratingvalue_modifiedby")]
		public IEnumerable<RatingValue> LkRatingvalueModifiedby
		{
			get { return GetRelatedEntities<RatingValue>("lk_ratingvalue_modifiedby", null); }
			set { SetRelatedEntities("lk_ratingvalue_modifiedby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_ratingvalue_modifiedonbehalfby'
        /// </summary>
		[RelationshipSchemaName("lk_ratingvalue_modifiedonbehalfby")]
		public IEnumerable<RatingValue> LkRatingvalueModifiedonbehalfby
		{
			get { return GetRelatedEntities<RatingValue>("lk_ratingvalue_modifiedonbehalfby", null); }
			set { SetRelatedEntities("lk_ratingvalue_modifiedonbehalfby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_recommendeddocument_createdby'
        /// </summary>
		[RelationshipSchemaName("lk_recommendeddocument_createdby")]
		public IEnumerable<DocumentSuggestions> LkRecommendeddocumentCreatedby
		{
			get { return GetRelatedEntities<DocumentSuggestions>("lk_recommendeddocument_createdby", null); }
			set { SetRelatedEntities("lk_recommendeddocument_createdby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_recommendeddocument_createdonbehalfby'
        /// </summary>
		[RelationshipSchemaName("lk_recommendeddocument_createdonbehalfby")]
		public IEnumerable<DocumentSuggestions> LkRecommendeddocumentCreatedonbehalfby
		{
			get { return GetRelatedEntities<DocumentSuggestions>("lk_recommendeddocument_createdonbehalfby", null); }
			set { SetRelatedEntities("lk_recommendeddocument_createdonbehalfby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_recommendeddocument_modifiedby'
        /// </summary>
		[RelationshipSchemaName("lk_recommendeddocument_modifiedby")]
		public IEnumerable<DocumentSuggestions> LkRecommendeddocumentModifiedby
		{
			get { return GetRelatedEntities<DocumentSuggestions>("lk_recommendeddocument_modifiedby", null); }
			set { SetRelatedEntities("lk_recommendeddocument_modifiedby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_recommendeddocument_modifiedonbehalfby'
        /// </summary>
		[RelationshipSchemaName("lk_recommendeddocument_modifiedonbehalfby")]
		public IEnumerable<DocumentSuggestions> LkRecommendeddocumentModifiedonbehalfby
		{
			get { return GetRelatedEntities<DocumentSuggestions>("lk_recommendeddocument_modifiedonbehalfby", null); }
			set { SetRelatedEntities("lk_recommendeddocument_modifiedonbehalfby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_recurrencerule_createdby'
        /// </summary>
		[RelationshipSchemaName("lk_recurrencerule_createdby")]
		public IEnumerable<RecurrenceRule> LkRecurrenceruleCreatedby
		{
			get { return GetRelatedEntities<RecurrenceRule>("lk_recurrencerule_createdby", null); }
			set { SetRelatedEntities("lk_recurrencerule_createdby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_recurrencerule_modifiedby'
        /// </summary>
		[RelationshipSchemaName("lk_recurrencerule_modifiedby")]
		public IEnumerable<RecurrenceRule> LkRecurrenceruleModifiedby
		{
			get { return GetRelatedEntities<RecurrenceRule>("lk_recurrencerule_modifiedby", null); }
			set { SetRelatedEntities("lk_recurrencerule_modifiedby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_recurrencerulebase_createdonbehalfby'
        /// </summary>
		[RelationshipSchemaName("lk_recurrencerulebase_createdonbehalfby")]
		public IEnumerable<RecurrenceRule> LkRecurrencerulebaseCreatedonbehalfby
		{
			get { return GetRelatedEntities<RecurrenceRule>("lk_recurrencerulebase_createdonbehalfby", null); }
			set { SetRelatedEntities("lk_recurrencerulebase_createdonbehalfby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_recurrencerulebase_modifiedonbehalfby'
        /// </summary>
		[RelationshipSchemaName("lk_recurrencerulebase_modifiedonbehalfby")]
		public IEnumerable<RecurrenceRule> LkRecurrencerulebaseModifiedonbehalfby
		{
			get { return GetRelatedEntities<RecurrenceRule>("lk_recurrencerulebase_modifiedonbehalfby", null); }
			set { SetRelatedEntities("lk_recurrencerulebase_modifiedonbehalfby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_recurringappointmentmaster_createdby'
        /// </summary>
		[RelationshipSchemaName("lk_recurringappointmentmaster_createdby")]
		public IEnumerable<RecurringAppointment> LkRecurringappointmentmasterCreatedby
		{
			get { return GetRelatedEntities<RecurringAppointment>("lk_recurringappointmentmaster_createdby", null); }
			set { SetRelatedEntities("lk_recurringappointmentmaster_createdby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_recurringappointmentmaster_createdonbehalfby'
        /// </summary>
		[RelationshipSchemaName("lk_recurringappointmentmaster_createdonbehalfby")]
		public IEnumerable<RecurringAppointment> LkRecurringappointmentmasterCreatedonbehalfby
		{
			get { return GetRelatedEntities<RecurringAppointment>("lk_recurringappointmentmaster_createdonbehalfby", null); }
			set { SetRelatedEntities("lk_recurringappointmentmaster_createdonbehalfby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_recurringappointmentmaster_modifiedby'
        /// </summary>
		[RelationshipSchemaName("lk_recurringappointmentmaster_modifiedby")]
		public IEnumerable<RecurringAppointment> LkRecurringappointmentmasterModifiedby
		{
			get { return GetRelatedEntities<RecurringAppointment>("lk_recurringappointmentmaster_modifiedby", null); }
			set { SetRelatedEntities("lk_recurringappointmentmaster_modifiedby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_recurringappointmentmaster_modifiedonbehalfby'
        /// </summary>
		[RelationshipSchemaName("lk_recurringappointmentmaster_modifiedonbehalfby")]
		public IEnumerable<RecurringAppointment> LkRecurringappointmentmasterModifiedonbehalfby
		{
			get { return GetRelatedEntities<RecurringAppointment>("lk_recurringappointmentmaster_modifiedonbehalfby", null); }
			set { SetRelatedEntities("lk_recurringappointmentmaster_modifiedonbehalfby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_report_createdonbehalfby'
        /// </summary>
		[RelationshipSchemaName("lk_report_createdonbehalfby")]
		public IEnumerable<Report> LkReportCreatedonbehalfby
		{
			get { return GetRelatedEntities<Report>("lk_report_createdonbehalfby", null); }
			set { SetRelatedEntities("lk_report_createdonbehalfby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_report_modifiedonbehalfby'
        /// </summary>
		[RelationshipSchemaName("lk_report_modifiedonbehalfby")]
		public IEnumerable<Report> LkReportModifiedonbehalfby
		{
			get { return GetRelatedEntities<Report>("lk_report_modifiedonbehalfby", null); }
			set { SetRelatedEntities("lk_report_modifiedonbehalfby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_reportbase_createdby'
        /// </summary>
		[RelationshipSchemaName("lk_reportbase_createdby")]
		public IEnumerable<Report> LkReportbaseCreatedby
		{
			get { return GetRelatedEntities<Report>("lk_reportbase_createdby", null); }
			set { SetRelatedEntities("lk_reportbase_createdby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_reportbase_modifiedby'
        /// </summary>
		[RelationshipSchemaName("lk_reportbase_modifiedby")]
		public IEnumerable<Report> LkReportbaseModifiedby
		{
			get { return GetRelatedEntities<Report>("lk_reportbase_modifiedby", null); }
			set { SetRelatedEntities("lk_reportbase_modifiedby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_reportcategory_createdonbehalfby'
        /// </summary>
		[RelationshipSchemaName("lk_reportcategory_createdonbehalfby")]
		public IEnumerable<ReportRelatedCategory> LkReportcategoryCreatedonbehalfby
		{
			get { return GetRelatedEntities<ReportRelatedCategory>("lk_reportcategory_createdonbehalfby", null); }
			set { SetRelatedEntities("lk_reportcategory_createdonbehalfby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_reportcategory_modifiedonbehalfby'
        /// </summary>
		[RelationshipSchemaName("lk_reportcategory_modifiedonbehalfby")]
		public IEnumerable<ReportRelatedCategory> LkReportcategoryModifiedonbehalfby
		{
			get { return GetRelatedEntities<ReportRelatedCategory>("lk_reportcategory_modifiedonbehalfby", null); }
			set { SetRelatedEntities("lk_reportcategory_modifiedonbehalfby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_reportcategorybase_createdby'
        /// </summary>
		[RelationshipSchemaName("lk_reportcategorybase_createdby")]
		public IEnumerable<ReportRelatedCategory> LkReportcategorybaseCreatedby
		{
			get { return GetRelatedEntities<ReportRelatedCategory>("lk_reportcategorybase_createdby", null); }
			set { SetRelatedEntities("lk_reportcategorybase_createdby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_reportcategorybase_modifiedby'
        /// </summary>
		[RelationshipSchemaName("lk_reportcategorybase_modifiedby")]
		public IEnumerable<ReportRelatedCategory> LkReportcategorybaseModifiedby
		{
			get { return GetRelatedEntities<ReportRelatedCategory>("lk_reportcategorybase_modifiedby", null); }
			set { SetRelatedEntities("lk_reportcategorybase_modifiedby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_resourcespec_createdby'
        /// </summary>
		[RelationshipSchemaName("lk_resourcespec_createdby")]
		public IEnumerable<ResourceSpecification> LkResourcespecCreatedby
		{
			get { return GetRelatedEntities<ResourceSpecification>("lk_resourcespec_createdby", null); }
			set { SetRelatedEntities("lk_resourcespec_createdby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_resourcespec_createdonbehalfby'
        /// </summary>
		[RelationshipSchemaName("lk_resourcespec_createdonbehalfby")]
		public IEnumerable<ResourceSpecification> LkResourcespecCreatedonbehalfby
		{
			get { return GetRelatedEntities<ResourceSpecification>("lk_resourcespec_createdonbehalfby", null); }
			set { SetRelatedEntities("lk_resourcespec_createdonbehalfby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_resourcespec_modifiedby'
        /// </summary>
		[RelationshipSchemaName("lk_resourcespec_modifiedby")]
		public IEnumerable<ResourceSpecification> LkResourcespecModifiedby
		{
			get { return GetRelatedEntities<ResourceSpecification>("lk_resourcespec_modifiedby", null); }
			set { SetRelatedEntities("lk_resourcespec_modifiedby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_resourcespec_modifiedonbehalfby'
        /// </summary>
		[RelationshipSchemaName("lk_resourcespec_modifiedonbehalfby")]
		public IEnumerable<ResourceSpecification> LkResourcespecModifiedonbehalfby
		{
			get { return GetRelatedEntities<ResourceSpecification>("lk_resourcespec_modifiedonbehalfby", null); }
			set { SetRelatedEntities("lk_resourcespec_modifiedonbehalfby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_role_createdonbehalfby'
        /// </summary>
		[RelationshipSchemaName("lk_role_createdonbehalfby")]
		public IEnumerable<SecurityRole> LkRoleCreatedonbehalfby
		{
			get { return GetRelatedEntities<SecurityRole>("lk_role_createdonbehalfby", null); }
			set { SetRelatedEntities("lk_role_createdonbehalfby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_role_modifiedonbehalfby'
        /// </summary>
		[RelationshipSchemaName("lk_role_modifiedonbehalfby")]
		public IEnumerable<SecurityRole> LkRoleModifiedonbehalfby
		{
			get { return GetRelatedEntities<SecurityRole>("lk_role_modifiedonbehalfby", null); }
			set { SetRelatedEntities("lk_role_modifiedonbehalfby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_rolebase_createdby'
        /// </summary>
		[RelationshipSchemaName("lk_rolebase_createdby")]
		public IEnumerable<SecurityRole> LkRolebaseCreatedby
		{
			get { return GetRelatedEntities<SecurityRole>("lk_rolebase_createdby", null); }
			set { SetRelatedEntities("lk_rolebase_createdby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_rolebase_modifiedby'
        /// </summary>
		[RelationshipSchemaName("lk_rolebase_modifiedby")]
		public IEnumerable<SecurityRole> LkRolebaseModifiedby
		{
			get { return GetRelatedEntities<SecurityRole>("lk_rolebase_modifiedby", null); }
			set { SetRelatedEntities("lk_rolebase_modifiedby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_rollupfield_createdby'
        /// </summary>
		[RelationshipSchemaName("lk_rollupfield_createdby")]
		public IEnumerable<RollupField> LkRollupfieldCreatedby
		{
			get { return GetRelatedEntities<RollupField>("lk_rollupfield_createdby", null); }
			set { SetRelatedEntities("lk_rollupfield_createdby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_rollupfield_createdonbehalfby'
        /// </summary>
		[RelationshipSchemaName("lk_rollupfield_createdonbehalfby")]
		public IEnumerable<RollupField> LkRollupfieldCreatedonbehalfby
		{
			get { return GetRelatedEntities<RollupField>("lk_rollupfield_createdonbehalfby", null); }
			set { SetRelatedEntities("lk_rollupfield_createdonbehalfby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_rollupfield_modifiedby'
        /// </summary>
		[RelationshipSchemaName("lk_rollupfield_modifiedby")]
		public IEnumerable<RollupField> LkRollupfieldModifiedby
		{
			get { return GetRelatedEntities<RollupField>("lk_rollupfield_modifiedby", null); }
			set { SetRelatedEntities("lk_rollupfield_modifiedby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_rollupfield_modifiedonbehalfby'
        /// </summary>
		[RelationshipSchemaName("lk_rollupfield_modifiedonbehalfby")]
		public IEnumerable<RollupField> LkRollupfieldModifiedonbehalfby
		{
			get { return GetRelatedEntities<RollupField>("lk_rollupfield_modifiedonbehalfby", null); }
			set { SetRelatedEntities("lk_rollupfield_modifiedonbehalfby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_salesliterature_createdonbehalfby'
        /// </summary>
		[RelationshipSchemaName("lk_salesliterature_createdonbehalfby")]
		public IEnumerable<SalesLiterature> LkSalesliteratureCreatedonbehalfby
		{
			get { return GetRelatedEntities<SalesLiterature>("lk_salesliterature_createdonbehalfby", null); }
			set { SetRelatedEntities("lk_salesliterature_createdonbehalfby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_salesliterature_modifiedonbehalfby'
        /// </summary>
		[RelationshipSchemaName("lk_salesliterature_modifiedonbehalfby")]
		public IEnumerable<SalesLiterature> LkSalesliteratureModifiedonbehalfby
		{
			get { return GetRelatedEntities<SalesLiterature>("lk_salesliterature_modifiedonbehalfby", null); }
			set { SetRelatedEntities("lk_salesliterature_modifiedonbehalfby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_salesliteraturebase_createdby'
        /// </summary>
		[RelationshipSchemaName("lk_salesliteraturebase_createdby")]
		public IEnumerable<SalesLiterature> LkSalesliteraturebaseCreatedby
		{
			get { return GetRelatedEntities<SalesLiterature>("lk_salesliteraturebase_createdby", null); }
			set { SetRelatedEntities("lk_salesliteraturebase_createdby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_salesliteraturebase_modifiedby'
        /// </summary>
		[RelationshipSchemaName("lk_salesliteraturebase_modifiedby")]
		public IEnumerable<SalesLiterature> LkSalesliteraturebaseModifiedby
		{
			get { return GetRelatedEntities<SalesLiterature>("lk_salesliteraturebase_modifiedby", null); }
			set { SetRelatedEntities("lk_salesliteraturebase_modifiedby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_salesliteratureitem_createdonbehalfby'
        /// </summary>
		[RelationshipSchemaName("lk_salesliteratureitem_createdonbehalfby")]
		public IEnumerable<SalesAttachment> LkSalesliteratureitemCreatedonbehalfby
		{
			get { return GetRelatedEntities<SalesAttachment>("lk_salesliteratureitem_createdonbehalfby", null); }
			set { SetRelatedEntities("lk_salesliteratureitem_createdonbehalfby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_salesliteratureitem_modifiedonbehalfby'
        /// </summary>
		[RelationshipSchemaName("lk_salesliteratureitem_modifiedonbehalfby")]
		public IEnumerable<SalesAttachment> LkSalesliteratureitemModifiedonbehalfby
		{
			get { return GetRelatedEntities<SalesAttachment>("lk_salesliteratureitem_modifiedonbehalfby", null); }
			set { SetRelatedEntities("lk_salesliteratureitem_modifiedonbehalfby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_salesliteratureitembase_createdby'
        /// </summary>
		[RelationshipSchemaName("lk_salesliteratureitembase_createdby")]
		public IEnumerable<SalesAttachment> LkSalesliteratureitembaseCreatedby
		{
			get { return GetRelatedEntities<SalesAttachment>("lk_salesliteratureitembase_createdby", null); }
			set { SetRelatedEntities("lk_salesliteratureitembase_createdby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_salesliteratureitembase_modifiedby'
        /// </summary>
		[RelationshipSchemaName("lk_salesliteratureitembase_modifiedby")]
		public IEnumerable<SalesAttachment> LkSalesliteratureitembaseModifiedby
		{
			get { return GetRelatedEntities<SalesAttachment>("lk_salesliteratureitembase_modifiedby", null); }
			set { SetRelatedEntities("lk_salesliteratureitembase_modifiedby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_salesorder_createdonbehalfby'
        /// </summary>
		[RelationshipSchemaName("lk_salesorder_createdonbehalfby")]
		public IEnumerable<Order> LkSalesorderCreatedonbehalfby
		{
			get { return GetRelatedEntities<Order>("lk_salesorder_createdonbehalfby", null); }
			set { SetRelatedEntities("lk_salesorder_createdonbehalfby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_salesorder_modifiedonbehalfby'
        /// </summary>
		[RelationshipSchemaName("lk_salesorder_modifiedonbehalfby")]
		public IEnumerable<Order> LkSalesorderModifiedonbehalfby
		{
			get { return GetRelatedEntities<Order>("lk_salesorder_modifiedonbehalfby", null); }
			set { SetRelatedEntities("lk_salesorder_modifiedonbehalfby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_salesorderbase_createdby'
        /// </summary>
		[RelationshipSchemaName("lk_salesorderbase_createdby")]
		public IEnumerable<Order> LkSalesorderbaseCreatedby
		{
			get { return GetRelatedEntities<Order>("lk_salesorderbase_createdby", null); }
			set { SetRelatedEntities("lk_salesorderbase_createdby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_salesorderbase_modifiedby'
        /// </summary>
		[RelationshipSchemaName("lk_salesorderbase_modifiedby")]
		public IEnumerable<Order> LkSalesorderbaseModifiedby
		{
			get { return GetRelatedEntities<Order>("lk_salesorderbase_modifiedby", null); }
			set { SetRelatedEntities("lk_salesorderbase_modifiedby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_salesorderdetail_createdonbehalfby'
        /// </summary>
		[RelationshipSchemaName("lk_salesorderdetail_createdonbehalfby")]
		public IEnumerable<OrderProduct> LkSalesorderdetailCreatedonbehalfby
		{
			get { return GetRelatedEntities<OrderProduct>("lk_salesorderdetail_createdonbehalfby", null); }
			set { SetRelatedEntities("lk_salesorderdetail_createdonbehalfby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_salesorderdetail_modifiedonbehalfby'
        /// </summary>
		[RelationshipSchemaName("lk_salesorderdetail_modifiedonbehalfby")]
		public IEnumerable<OrderProduct> LkSalesorderdetailModifiedonbehalfby
		{
			get { return GetRelatedEntities<OrderProduct>("lk_salesorderdetail_modifiedonbehalfby", null); }
			set { SetRelatedEntities("lk_salesorderdetail_modifiedonbehalfby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_salesorderdetailbase_createdby'
        /// </summary>
		[RelationshipSchemaName("lk_salesorderdetailbase_createdby")]
		public IEnumerable<OrderProduct> LkSalesorderdetailbaseCreatedby
		{
			get { return GetRelatedEntities<OrderProduct>("lk_salesorderdetailbase_createdby", null); }
			set { SetRelatedEntities("lk_salesorderdetailbase_createdby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_salesorderdetailbase_modifiedby'
        /// </summary>
		[RelationshipSchemaName("lk_salesorderdetailbase_modifiedby")]
		public IEnumerable<OrderProduct> LkSalesorderdetailbaseModifiedby
		{
			get { return GetRelatedEntities<OrderProduct>("lk_salesorderdetailbase_modifiedby", null); }
			set { SetRelatedEntities("lk_salesorderdetailbase_modifiedby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_savedquery_createdonbehalfby'
        /// </summary>
		[RelationshipSchemaName("lk_savedquery_createdonbehalfby")]
		public IEnumerable<View> LkSavedqueryCreatedonbehalfby
		{
			get { return GetRelatedEntities<View>("lk_savedquery_createdonbehalfby", null); }
			set { SetRelatedEntities("lk_savedquery_createdonbehalfby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_savedquery_modifiedonbehalfby'
        /// </summary>
		[RelationshipSchemaName("lk_savedquery_modifiedonbehalfby")]
		public IEnumerable<View> LkSavedqueryModifiedonbehalfby
		{
			get { return GetRelatedEntities<View>("lk_savedquery_modifiedonbehalfby", null); }
			set { SetRelatedEntities("lk_savedquery_modifiedonbehalfby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_savedquerybase_createdby'
        /// </summary>
		[RelationshipSchemaName("lk_savedquerybase_createdby")]
		public IEnumerable<View> LkSavedquerybaseCreatedby
		{
			get { return GetRelatedEntities<View>("lk_savedquerybase_createdby", null); }
			set { SetRelatedEntities("lk_savedquerybase_createdby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_savedquerybase_modifiedby'
        /// </summary>
		[RelationshipSchemaName("lk_savedquerybase_modifiedby")]
		public IEnumerable<View> LkSavedquerybaseModifiedby
		{
			get { return GetRelatedEntities<View>("lk_savedquerybase_modifiedby", null); }
			set { SetRelatedEntities("lk_savedquerybase_modifiedby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_savedqueryvisualizationbase_createdby'
        /// </summary>
		[RelationshipSchemaName("lk_savedqueryvisualizationbase_createdby")]
		public IEnumerable<SystemChart> LkSavedqueryvisualizationbaseCreatedby
		{
			get { return GetRelatedEntities<SystemChart>("lk_savedqueryvisualizationbase_createdby", null); }
			set { SetRelatedEntities("lk_savedqueryvisualizationbase_createdby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_savedqueryvisualizationbase_createdonbehalfby'
        /// </summary>
		[RelationshipSchemaName("lk_savedqueryvisualizationbase_createdonbehalfby")]
		public IEnumerable<SystemChart> LkSavedqueryvisualizationbaseCreatedonbehalfby
		{
			get { return GetRelatedEntities<SystemChart>("lk_savedqueryvisualizationbase_createdonbehalfby", null); }
			set { SetRelatedEntities("lk_savedqueryvisualizationbase_createdonbehalfby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_savedqueryvisualizationbase_modifiedby'
        /// </summary>
		[RelationshipSchemaName("lk_savedqueryvisualizationbase_modifiedby")]
		public IEnumerable<SystemChart> LkSavedqueryvisualizationbaseModifiedby
		{
			get { return GetRelatedEntities<SystemChart>("lk_savedqueryvisualizationbase_modifiedby", null); }
			set { SetRelatedEntities("lk_savedqueryvisualizationbase_modifiedby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_savedqueryvisualizationbase_modifiedonbehalfby'
        /// </summary>
		[RelationshipSchemaName("lk_savedqueryvisualizationbase_modifiedonbehalfby")]
		public IEnumerable<SystemChart> LkSavedqueryvisualizationbaseModifiedonbehalfby
		{
			get { return GetRelatedEntities<SystemChart>("lk_savedqueryvisualizationbase_modifiedonbehalfby", null); }
			set { SetRelatedEntities("lk_savedqueryvisualizationbase_modifiedonbehalfby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_sdkmessage_createdonbehalfby'
        /// </summary>
		[RelationshipSchemaName("lk_sdkmessage_createdonbehalfby")]
		public IEnumerable<SdkMessage> LkSdkmessageCreatedonbehalfby
		{
			get { return GetRelatedEntities<SdkMessage>("lk_sdkmessage_createdonbehalfby", null); }
			set { SetRelatedEntities("lk_sdkmessage_createdonbehalfby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_sdkmessage_modifiedonbehalfby'
        /// </summary>
		[RelationshipSchemaName("lk_sdkmessage_modifiedonbehalfby")]
		public IEnumerable<SdkMessage> LkSdkmessageModifiedonbehalfby
		{
			get { return GetRelatedEntities<SdkMessage>("lk_sdkmessage_modifiedonbehalfby", null); }
			set { SetRelatedEntities("lk_sdkmessage_modifiedonbehalfby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_sdkmessagefilter_createdonbehalfby'
        /// </summary>
		[RelationshipSchemaName("lk_sdkmessagefilter_createdonbehalfby")]
		public IEnumerable<SdkMessageFilter> LkSdkmessagefilterCreatedonbehalfby
		{
			get { return GetRelatedEntities<SdkMessageFilter>("lk_sdkmessagefilter_createdonbehalfby", null); }
			set { SetRelatedEntities("lk_sdkmessagefilter_createdonbehalfby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_sdkmessagefilter_modifiedonbehalfby'
        /// </summary>
		[RelationshipSchemaName("lk_sdkmessagefilter_modifiedonbehalfby")]
		public IEnumerable<SdkMessageFilter> LkSdkmessagefilterModifiedonbehalfby
		{
			get { return GetRelatedEntities<SdkMessageFilter>("lk_sdkmessagefilter_modifiedonbehalfby", null); }
			set { SetRelatedEntities("lk_sdkmessagefilter_modifiedonbehalfby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_sdkmessageprocessingstep_createdonbehalfby'
        /// </summary>
		[RelationshipSchemaName("lk_sdkmessageprocessingstep_createdonbehalfby")]
		public IEnumerable<SdkMessageProcessingStep> LkSdkmessageprocessingstepCreatedonbehalfby
		{
			get { return GetRelatedEntities<SdkMessageProcessingStep>("lk_sdkmessageprocessingstep_createdonbehalfby", null); }
			set { SetRelatedEntities("lk_sdkmessageprocessingstep_createdonbehalfby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_sdkmessageprocessingstep_modifiedonbehalfby'
        /// </summary>
		[RelationshipSchemaName("lk_sdkmessageprocessingstep_modifiedonbehalfby")]
		public IEnumerable<SdkMessageProcessingStep> LkSdkmessageprocessingstepModifiedonbehalfby
		{
			get { return GetRelatedEntities<SdkMessageProcessingStep>("lk_sdkmessageprocessingstep_modifiedonbehalfby", null); }
			set { SetRelatedEntities("lk_sdkmessageprocessingstep_modifiedonbehalfby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_sdkmessageprocessingstepimage_createdonbehalfby'
        /// </summary>
		[RelationshipSchemaName("lk_sdkmessageprocessingstepimage_createdonbehalfby")]
		public IEnumerable<SdkMessageProcessingStepImage> LkSdkmessageprocessingstepimageCreatedonbehalfby
		{
			get { return GetRelatedEntities<SdkMessageProcessingStepImage>("lk_sdkmessageprocessingstepimage_createdonbehalfby", null); }
			set { SetRelatedEntities("lk_sdkmessageprocessingstepimage_createdonbehalfby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_sdkmessageprocessingstepimage_modifiedonbehalfby'
        /// </summary>
		[RelationshipSchemaName("lk_sdkmessageprocessingstepimage_modifiedonbehalfby")]
		public IEnumerable<SdkMessageProcessingStepImage> LkSdkmessageprocessingstepimageModifiedonbehalfby
		{
			get { return GetRelatedEntities<SdkMessageProcessingStepImage>("lk_sdkmessageprocessingstepimage_modifiedonbehalfby", null); }
			set { SetRelatedEntities("lk_sdkmessageprocessingstepimage_modifiedonbehalfby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_sdkmessageprocessingstepsecureconfig_createdonbehalfby'
        /// </summary>
		[RelationshipSchemaName("lk_sdkmessageprocessingstepsecureconfig_createdonbehalfby")]
		public IEnumerable<SdkMessageProcessingStepSecureConfiguration> LkSdkmessageprocessingstepsecureconfigCreatedonbehalfby
		{
			get { return GetRelatedEntities<SdkMessageProcessingStepSecureConfiguration>("lk_sdkmessageprocessingstepsecureconfig_createdonbehalfby", null); }
			set { SetRelatedEntities("lk_sdkmessageprocessingstepsecureconfig_createdonbehalfby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_sdkmessageprocessingstepsecureconfig_modifiedonbehalfby'
        /// </summary>
		[RelationshipSchemaName("lk_sdkmessageprocessingstepsecureconfig_modifiedonbehalfby")]
		public IEnumerable<SdkMessageProcessingStepSecureConfiguration> LkSdkmessageprocessingstepsecureconfigModifiedonbehalfby
		{
			get { return GetRelatedEntities<SdkMessageProcessingStepSecureConfiguration>("lk_sdkmessageprocessingstepsecureconfig_modifiedonbehalfby", null); }
			set { SetRelatedEntities("lk_sdkmessageprocessingstepsecureconfig_modifiedonbehalfby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_semiannualfiscalcalendar_createdby'
        /// </summary>
		[RelationshipSchemaName("lk_semiannualfiscalcalendar_createdby")]
		public IEnumerable<SemiannualFiscalCalendar> LkSemiannualfiscalcalendarCreatedby
		{
			get { return GetRelatedEntities<SemiannualFiscalCalendar>("lk_semiannualfiscalcalendar_createdby", null); }
			set { SetRelatedEntities("lk_semiannualfiscalcalendar_createdby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_semiannualfiscalcalendar_createdonbehalfby'
        /// </summary>
		[RelationshipSchemaName("lk_semiannualfiscalcalendar_createdonbehalfby")]
		public IEnumerable<SemiannualFiscalCalendar> LkSemiannualfiscalcalendarCreatedonbehalfby
		{
			get { return GetRelatedEntities<SemiannualFiscalCalendar>("lk_semiannualfiscalcalendar_createdonbehalfby", null); }
			set { SetRelatedEntities("lk_semiannualfiscalcalendar_createdonbehalfby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_semiannualfiscalcalendar_modifiedby'
        /// </summary>
		[RelationshipSchemaName("lk_semiannualfiscalcalendar_modifiedby")]
		public IEnumerable<SemiannualFiscalCalendar> LkSemiannualfiscalcalendarModifiedby
		{
			get { return GetRelatedEntities<SemiannualFiscalCalendar>("lk_semiannualfiscalcalendar_modifiedby", null); }
			set { SetRelatedEntities("lk_semiannualfiscalcalendar_modifiedby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_semiannualfiscalcalendar_modifiedonbehalfby'
        /// </summary>
		[RelationshipSchemaName("lk_semiannualfiscalcalendar_modifiedonbehalfby")]
		public IEnumerable<SemiannualFiscalCalendar> LkSemiannualfiscalcalendarModifiedonbehalfby
		{
			get { return GetRelatedEntities<SemiannualFiscalCalendar>("lk_semiannualfiscalcalendar_modifiedonbehalfby", null); }
			set { SetRelatedEntities("lk_semiannualfiscalcalendar_modifiedonbehalfby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_semiannualfiscalcalendar_salespersonid'
        /// </summary>
		[RelationshipSchemaName("lk_semiannualfiscalcalendar_salespersonid")]
		public IEnumerable<SemiannualFiscalCalendar> LkSemiannualfiscalcalendarSalespersonid
		{
			get { return GetRelatedEntities<SemiannualFiscalCalendar>("lk_semiannualfiscalcalendar_salespersonid", null); }
			set { SetRelatedEntities("lk_semiannualfiscalcalendar_salespersonid", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_service_createdby'
        /// </summary>
		[RelationshipSchemaName("lk_service_createdby")]
		public IEnumerable<Service> LkServiceCreatedby
		{
			get { return GetRelatedEntities<Service>("lk_service_createdby", null); }
			set { SetRelatedEntities("lk_service_createdby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_service_createdonbehalfby'
        /// </summary>
		[RelationshipSchemaName("lk_service_createdonbehalfby")]
		public IEnumerable<Service> LkServiceCreatedonbehalfby
		{
			get { return GetRelatedEntities<Service>("lk_service_createdonbehalfby", null); }
			set { SetRelatedEntities("lk_service_createdonbehalfby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_service_modifiedby'
        /// </summary>
		[RelationshipSchemaName("lk_service_modifiedby")]
		public IEnumerable<Service> LkServiceModifiedby
		{
			get { return GetRelatedEntities<Service>("lk_service_modifiedby", null); }
			set { SetRelatedEntities("lk_service_modifiedby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_service_modifiedonbehalfby'
        /// </summary>
		[RelationshipSchemaName("lk_service_modifiedonbehalfby")]
		public IEnumerable<Service> LkServiceModifiedonbehalfby
		{
			get { return GetRelatedEntities<Service>("lk_service_modifiedonbehalfby", null); }
			set { SetRelatedEntities("lk_service_modifiedonbehalfby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_serviceappointment_createdby'
        /// </summary>
		[RelationshipSchemaName("lk_serviceappointment_createdby")]
		public IEnumerable<ServiceActivity> LkServiceappointmentCreatedby
		{
			get { return GetRelatedEntities<ServiceActivity>("lk_serviceappointment_createdby", null); }
			set { SetRelatedEntities("lk_serviceappointment_createdby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_serviceappointment_createdonbehalfby'
        /// </summary>
		[RelationshipSchemaName("lk_serviceappointment_createdonbehalfby")]
		public IEnumerable<ServiceActivity> LkServiceappointmentCreatedonbehalfby
		{
			get { return GetRelatedEntities<ServiceActivity>("lk_serviceappointment_createdonbehalfby", null); }
			set { SetRelatedEntities("lk_serviceappointment_createdonbehalfby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_serviceappointment_modifiedby'
        /// </summary>
		[RelationshipSchemaName("lk_serviceappointment_modifiedby")]
		public IEnumerable<ServiceActivity> LkServiceappointmentModifiedby
		{
			get { return GetRelatedEntities<ServiceActivity>("lk_serviceappointment_modifiedby", null); }
			set { SetRelatedEntities("lk_serviceappointment_modifiedby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_serviceappointment_modifiedonbehalfby'
        /// </summary>
		[RelationshipSchemaName("lk_serviceappointment_modifiedonbehalfby")]
		public IEnumerable<ServiceActivity> LkServiceappointmentModifiedonbehalfby
		{
			get { return GetRelatedEntities<ServiceActivity>("lk_serviceappointment_modifiedonbehalfby", null); }
			set { SetRelatedEntities("lk_serviceappointment_modifiedonbehalfby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_serviceendpointbase_createdonbehalfby'
        /// </summary>
		[RelationshipSchemaName("lk_serviceendpointbase_createdonbehalfby")]
		public IEnumerable<ServiceEndpoint> LkServiceendpointbaseCreatedonbehalfby
		{
			get { return GetRelatedEntities<ServiceEndpoint>("lk_serviceendpointbase_createdonbehalfby", null); }
			set { SetRelatedEntities("lk_serviceendpointbase_createdonbehalfby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_serviceendpointbase_modifiedonbehalfby'
        /// </summary>
		[RelationshipSchemaName("lk_serviceendpointbase_modifiedonbehalfby")]
		public IEnumerable<ServiceEndpoint> LkServiceendpointbaseModifiedonbehalfby
		{
			get { return GetRelatedEntities<ServiceEndpoint>("lk_serviceendpointbase_modifiedonbehalfby", null); }
			set { SetRelatedEntities("lk_serviceendpointbase_modifiedonbehalfby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_serviceplan_createdby'
        /// </summary>
		[RelationshipSchemaName("lk_serviceplan_createdby")]
		public IEnumerable<ServicePlan> LkServiceplanCreatedby
		{
			get { return GetRelatedEntities<ServicePlan>("lk_serviceplan_createdby", null); }
			set { SetRelatedEntities("lk_serviceplan_createdby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_serviceplan_createdonbehalfby'
        /// </summary>
		[RelationshipSchemaName("lk_serviceplan_createdonbehalfby")]
		public IEnumerable<ServicePlan> LkServiceplanCreatedonbehalfby
		{
			get { return GetRelatedEntities<ServicePlan>("lk_serviceplan_createdonbehalfby", null); }
			set { SetRelatedEntities("lk_serviceplan_createdonbehalfby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_serviceplan_modifiedby'
        /// </summary>
		[RelationshipSchemaName("lk_serviceplan_modifiedby")]
		public IEnumerable<ServicePlan> LkServiceplanModifiedby
		{
			get { return GetRelatedEntities<ServicePlan>("lk_serviceplan_modifiedby", null); }
			set { SetRelatedEntities("lk_serviceplan_modifiedby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_serviceplan_modifiedonbehalfby'
        /// </summary>
		[RelationshipSchemaName("lk_serviceplan_modifiedonbehalfby")]
		public IEnumerable<ServicePlan> LkServiceplanModifiedonbehalfby
		{
			get { return GetRelatedEntities<ServicePlan>("lk_serviceplan_modifiedonbehalfby", null); }
			set { SetRelatedEntities("lk_serviceplan_modifiedonbehalfby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_sharepointdocumentlocationbase_createdby'
        /// </summary>
		[RelationshipSchemaName("lk_sharepointdocumentlocationbase_createdby")]
		public IEnumerable<DocumentLocation> LkSharepointdocumentlocationbaseCreatedby
		{
			get { return GetRelatedEntities<DocumentLocation>("lk_sharepointdocumentlocationbase_createdby", null); }
			set { SetRelatedEntities("lk_sharepointdocumentlocationbase_createdby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_sharepointdocumentlocationbase_createdonbehalfby'
        /// </summary>
		[RelationshipSchemaName("lk_sharepointdocumentlocationbase_createdonbehalfby")]
		public IEnumerable<DocumentLocation> LkSharepointdocumentlocationbaseCreatedonbehalfby
		{
			get { return GetRelatedEntities<DocumentLocation>("lk_sharepointdocumentlocationbase_createdonbehalfby", null); }
			set { SetRelatedEntities("lk_sharepointdocumentlocationbase_createdonbehalfby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_sharepointdocumentlocationbase_modifiedby'
        /// </summary>
		[RelationshipSchemaName("lk_sharepointdocumentlocationbase_modifiedby")]
		public IEnumerable<DocumentLocation> LkSharepointdocumentlocationbaseModifiedby
		{
			get { return GetRelatedEntities<DocumentLocation>("lk_sharepointdocumentlocationbase_modifiedby", null); }
			set { SetRelatedEntities("lk_sharepointdocumentlocationbase_modifiedby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_sharepointdocumentlocationbase_modifiedonbehalfby'
        /// </summary>
		[RelationshipSchemaName("lk_sharepointdocumentlocationbase_modifiedonbehalfby")]
		public IEnumerable<DocumentLocation> LkSharepointdocumentlocationbaseModifiedonbehalfby
		{
			get { return GetRelatedEntities<DocumentLocation>("lk_sharepointdocumentlocationbase_modifiedonbehalfby", null); }
			set { SetRelatedEntities("lk_sharepointdocumentlocationbase_modifiedonbehalfby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_sharepointsitebase_createdby'
        /// </summary>
		[RelationshipSchemaName("lk_sharepointsitebase_createdby")]
		public IEnumerable<SharePointSite> LkSharepointsitebaseCreatedby
		{
			get { return GetRelatedEntities<SharePointSite>("lk_sharepointsitebase_createdby", null); }
			set { SetRelatedEntities("lk_sharepointsitebase_createdby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_sharepointsitebase_createdonbehalfby'
        /// </summary>
		[RelationshipSchemaName("lk_sharepointsitebase_createdonbehalfby")]
		public IEnumerable<SharePointSite> LkSharepointsitebaseCreatedonbehalfby
		{
			get { return GetRelatedEntities<SharePointSite>("lk_sharepointsitebase_createdonbehalfby", null); }
			set { SetRelatedEntities("lk_sharepointsitebase_createdonbehalfby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_sharepointsitebase_modifiedby'
        /// </summary>
		[RelationshipSchemaName("lk_sharepointsitebase_modifiedby")]
		public IEnumerable<SharePointSite> LkSharepointsitebaseModifiedby
		{
			get { return GetRelatedEntities<SharePointSite>("lk_sharepointsitebase_modifiedby", null); }
			set { SetRelatedEntities("lk_sharepointsitebase_modifiedby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_sharepointsitebase_modifiedonbehalfby'
        /// </summary>
		[RelationshipSchemaName("lk_sharepointsitebase_modifiedonbehalfby")]
		public IEnumerable<SharePointSite> LkSharepointsitebaseModifiedonbehalfby
		{
			get { return GetRelatedEntities<SharePointSite>("lk_sharepointsitebase_modifiedonbehalfby", null); }
			set { SetRelatedEntities("lk_sharepointsitebase_modifiedonbehalfby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_site_createdonbehalfby'
        /// </summary>
		[RelationshipSchemaName("lk_site_createdonbehalfby")]
		public IEnumerable<Site> LkSiteCreatedonbehalfby
		{
			get { return GetRelatedEntities<Site>("lk_site_createdonbehalfby", null); }
			set { SetRelatedEntities("lk_site_createdonbehalfby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_site_modifiedonbehalfby'
        /// </summary>
		[RelationshipSchemaName("lk_site_modifiedonbehalfby")]
		public IEnumerable<Site> LkSiteModifiedonbehalfby
		{
			get { return GetRelatedEntities<Site>("lk_site_modifiedonbehalfby", null); }
			set { SetRelatedEntities("lk_site_modifiedonbehalfby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_sitebase_createdby'
        /// </summary>
		[RelationshipSchemaName("lk_sitebase_createdby")]
		public IEnumerable<Site> LkSitebaseCreatedby
		{
			get { return GetRelatedEntities<Site>("lk_sitebase_createdby", null); }
			set { SetRelatedEntities("lk_sitebase_createdby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_sitebase_modifiedby'
        /// </summary>
		[RelationshipSchemaName("lk_sitebase_modifiedby")]
		public IEnumerable<Site> LkSitebaseModifiedby
		{
			get { return GetRelatedEntities<Site>("lk_sitebase_modifiedby", null); }
			set { SetRelatedEntities("lk_sitebase_modifiedby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_SiteMap_createdby'
        /// </summary>
		[RelationshipSchemaName("lk_SiteMap_createdby")]
		public IEnumerable<SiteMap> LkSiteMapCreatedby
		{
			get { return GetRelatedEntities<SiteMap>("lk_SiteMap_createdby", null); }
			set { SetRelatedEntities("lk_SiteMap_createdby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_SiteMap_createdonbehalfby'
        /// </summary>
		[RelationshipSchemaName("lk_SiteMap_createdonbehalfby")]
		public IEnumerable<SiteMap> LkSiteMapCreatedonbehalfby
		{
			get { return GetRelatedEntities<SiteMap>("lk_SiteMap_createdonbehalfby", null); }
			set { SetRelatedEntities("lk_SiteMap_createdonbehalfby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_SiteMap_modifiedby'
        /// </summary>
		[RelationshipSchemaName("lk_SiteMap_modifiedby")]
		public IEnumerable<SiteMap> LkSiteMapModifiedby
		{
			get { return GetRelatedEntities<SiteMap>("lk_SiteMap_modifiedby", null); }
			set { SetRelatedEntities("lk_SiteMap_modifiedby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_SiteMap_modifiedonbehalfby'
        /// </summary>
		[RelationshipSchemaName("lk_SiteMap_modifiedonbehalfby")]
		public IEnumerable<SiteMap> LkSiteMapModifiedonbehalfby
		{
			get { return GetRelatedEntities<SiteMap>("lk_SiteMap_modifiedonbehalfby", null); }
			set { SetRelatedEntities("lk_SiteMap_modifiedonbehalfby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_slabase_createdby'
        /// </summary>
		[RelationshipSchemaName("lk_slabase_createdby")]
		public IEnumerable<SLA> LkSlabaseCreatedby
		{
			get { return GetRelatedEntities<SLA>("lk_slabase_createdby", null); }
			set { SetRelatedEntities("lk_slabase_createdby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_slabase_createdonbehalfby'
        /// </summary>
		[RelationshipSchemaName("lk_slabase_createdonbehalfby")]
		public IEnumerable<SLA> LkSlabaseCreatedonbehalfby
		{
			get { return GetRelatedEntities<SLA>("lk_slabase_createdonbehalfby", null); }
			set { SetRelatedEntities("lk_slabase_createdonbehalfby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_slabase_modifiedby'
        /// </summary>
		[RelationshipSchemaName("lk_slabase_modifiedby")]
		public IEnumerable<SLA> LkSlabaseModifiedby
		{
			get { return GetRelatedEntities<SLA>("lk_slabase_modifiedby", null); }
			set { SetRelatedEntities("lk_slabase_modifiedby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_slabase_modifiedonbehalfby'
        /// </summary>
		[RelationshipSchemaName("lk_slabase_modifiedonbehalfby")]
		public IEnumerable<SLA> LkSlabaseModifiedonbehalfby
		{
			get { return GetRelatedEntities<SLA>("lk_slabase_modifiedonbehalfby", null); }
			set { SetRelatedEntities("lk_slabase_modifiedonbehalfby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_slaitembase_createdby'
        /// </summary>
		[RelationshipSchemaName("lk_slaitembase_createdby")]
		public IEnumerable<SLAItem> LkSlaitembaseCreatedby
		{
			get { return GetRelatedEntities<SLAItem>("lk_slaitembase_createdby", null); }
			set { SetRelatedEntities("lk_slaitembase_createdby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_slaitembase_createdonbehalfby'
        /// </summary>
		[RelationshipSchemaName("lk_slaitembase_createdonbehalfby")]
		public IEnumerable<SLAItem> LkSlaitembaseCreatedonbehalfby
		{
			get { return GetRelatedEntities<SLAItem>("lk_slaitembase_createdonbehalfby", null); }
			set { SetRelatedEntities("lk_slaitembase_createdonbehalfby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_slaitembase_modifiedby'
        /// </summary>
		[RelationshipSchemaName("lk_slaitembase_modifiedby")]
		public IEnumerable<SLAItem> LkSlaitembaseModifiedby
		{
			get { return GetRelatedEntities<SLAItem>("lk_slaitembase_modifiedby", null); }
			set { SetRelatedEntities("lk_slaitembase_modifiedby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_slaitembase_modifiedonbehalfby'
        /// </summary>
		[RelationshipSchemaName("lk_slaitembase_modifiedonbehalfby")]
		public IEnumerable<SLAItem> LkSlaitembaseModifiedonbehalfby
		{
			get { return GetRelatedEntities<SLAItem>("lk_slaitembase_modifiedonbehalfby", null); }
			set { SetRelatedEntities("lk_slaitembase_modifiedonbehalfby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_slakpiinstancebase_createdby'
        /// </summary>
		[RelationshipSchemaName("lk_slakpiinstancebase_createdby")]
		public IEnumerable<SLAKPIInstance> LkSlakpiinstancebaseCreatedby
		{
			get { return GetRelatedEntities<SLAKPIInstance>("lk_slakpiinstancebase_createdby", null); }
			set { SetRelatedEntities("lk_slakpiinstancebase_createdby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_slakpiinstancebase_createdonbehalfby'
        /// </summary>
		[RelationshipSchemaName("lk_slakpiinstancebase_createdonbehalfby")]
		public IEnumerable<SLAKPIInstance> LkSlakpiinstancebaseCreatedonbehalfby
		{
			get { return GetRelatedEntities<SLAKPIInstance>("lk_slakpiinstancebase_createdonbehalfby", null); }
			set { SetRelatedEntities("lk_slakpiinstancebase_createdonbehalfby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_slakpiinstancebase_modifiedby'
        /// </summary>
		[RelationshipSchemaName("lk_slakpiinstancebase_modifiedby")]
		public IEnumerable<SLAKPIInstance> LkSlakpiinstancebaseModifiedby
		{
			get { return GetRelatedEntities<SLAKPIInstance>("lk_slakpiinstancebase_modifiedby", null); }
			set { SetRelatedEntities("lk_slakpiinstancebase_modifiedby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_slakpiinstancebase_modifiedonbehalfby'
        /// </summary>
		[RelationshipSchemaName("lk_slakpiinstancebase_modifiedonbehalfby")]
		public IEnumerable<SLAKPIInstance> LkSlakpiinstancebaseModifiedonbehalfby
		{
			get { return GetRelatedEntities<SLAKPIInstance>("lk_slakpiinstancebase_modifiedonbehalfby", null); }
			set { SetRelatedEntities("lk_slakpiinstancebase_modifiedonbehalfby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_socialactivity_createdby'
        /// </summary>
		[RelationshipSchemaName("lk_socialactivity_createdby")]
		public IEnumerable<SocialActivity> LkSocialactivityCreatedby
		{
			get { return GetRelatedEntities<SocialActivity>("lk_socialactivity_createdby", null); }
			set { SetRelatedEntities("lk_socialactivity_createdby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_socialactivity_modifiedby'
        /// </summary>
		[RelationshipSchemaName("lk_socialactivity_modifiedby")]
		public IEnumerable<SocialActivity> LkSocialactivityModifiedby
		{
			get { return GetRelatedEntities<SocialActivity>("lk_socialactivity_modifiedby", null); }
			set { SetRelatedEntities("lk_socialactivity_modifiedby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_socialactivitybase_createdonbehalfby'
        /// </summary>
		[RelationshipSchemaName("lk_socialactivitybase_createdonbehalfby")]
		public IEnumerable<SocialActivity> LkSocialactivitybaseCreatedonbehalfby
		{
			get { return GetRelatedEntities<SocialActivity>("lk_socialactivitybase_createdonbehalfby", null); }
			set { SetRelatedEntities("lk_socialactivitybase_createdonbehalfby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_socialactivitybase_modifiedonbehalfby'
        /// </summary>
		[RelationshipSchemaName("lk_socialactivitybase_modifiedonbehalfby")]
		public IEnumerable<SocialActivity> LkSocialactivitybaseModifiedonbehalfby
		{
			get { return GetRelatedEntities<SocialActivity>("lk_socialactivitybase_modifiedonbehalfby", null); }
			set { SetRelatedEntities("lk_socialactivitybase_modifiedonbehalfby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_SocialProfile_createdonbehalfby'
        /// </summary>
		[RelationshipSchemaName("lk_SocialProfile_createdonbehalfby")]
		public IEnumerable<SocialProfile> LkSocialProfileCreatedonbehalfby
		{
			get { return GetRelatedEntities<SocialProfile>("lk_SocialProfile_createdonbehalfby", null); }
			set { SetRelatedEntities("lk_SocialProfile_createdonbehalfby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_SocialProfile_modifiedonbehalfby'
        /// </summary>
		[RelationshipSchemaName("lk_SocialProfile_modifiedonbehalfby")]
		public IEnumerable<SocialProfile> LkSocialProfileModifiedonbehalfby
		{
			get { return GetRelatedEntities<SocialProfile>("lk_SocialProfile_modifiedonbehalfby", null); }
			set { SetRelatedEntities("lk_SocialProfile_modifiedonbehalfby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_solution_createdby'
        /// </summary>
		[RelationshipSchemaName("lk_solution_createdby")]
		public IEnumerable<Solution> LkSolutionCreatedby
		{
			get { return GetRelatedEntities<Solution>("lk_solution_createdby", null); }
			set { SetRelatedEntities("lk_solution_createdby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_solution_modifiedby'
        /// </summary>
		[RelationshipSchemaName("lk_solution_modifiedby")]
		public IEnumerable<Solution> LkSolutionModifiedby
		{
			get { return GetRelatedEntities<Solution>("lk_solution_modifiedby", null); }
			set { SetRelatedEntities("lk_solution_modifiedby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_solutionbase_createdonbehalfby'
        /// </summary>
		[RelationshipSchemaName("lk_solutionbase_createdonbehalfby")]
		public IEnumerable<Solution> LkSolutionbaseCreatedonbehalfby
		{
			get { return GetRelatedEntities<Solution>("lk_solutionbase_createdonbehalfby", null); }
			set { SetRelatedEntities("lk_solutionbase_createdonbehalfby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_solutionbase_modifiedonbehalfby'
        /// </summary>
		[RelationshipSchemaName("lk_solutionbase_modifiedonbehalfby")]
		public IEnumerable<Solution> LkSolutionbaseModifiedonbehalfby
		{
			get { return GetRelatedEntities<Solution>("lk_solutionbase_modifiedonbehalfby", null); }
			set { SetRelatedEntities("lk_solutionbase_modifiedonbehalfby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_solutioncomponentattributeconfiguration_createdby'
        /// </summary>
		[RelationshipSchemaName("lk_solutioncomponentattributeconfiguration_createdby")]
		public IEnumerable<SolutionComponentAttributeConfiguration> LkSolutioncomponentattributeconfigurationCreatedby
		{
			get { return GetRelatedEntities<SolutionComponentAttributeConfiguration>("lk_solutioncomponentattributeconfiguration_createdby", null); }
			set { SetRelatedEntities("lk_solutioncomponentattributeconfiguration_createdby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_solutioncomponentattributeconfiguration_createdonbehalfby'
        /// </summary>
		[RelationshipSchemaName("lk_solutioncomponentattributeconfiguration_createdonbehalfby")]
		public IEnumerable<SolutionComponentAttributeConfiguration> LkSolutioncomponentattributeconfigurationCreatedonbehalfby
		{
			get { return GetRelatedEntities<SolutionComponentAttributeConfiguration>("lk_solutioncomponentattributeconfiguration_createdonbehalfby", null); }
			set { SetRelatedEntities("lk_solutioncomponentattributeconfiguration_createdonbehalfby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_solutioncomponentattributeconfiguration_modifiedby'
        /// </summary>
		[RelationshipSchemaName("lk_solutioncomponentattributeconfiguration_modifiedby")]
		public IEnumerable<SolutionComponentAttributeConfiguration> LkSolutioncomponentattributeconfigurationModifiedby
		{
			get { return GetRelatedEntities<SolutionComponentAttributeConfiguration>("lk_solutioncomponentattributeconfiguration_modifiedby", null); }
			set { SetRelatedEntities("lk_solutioncomponentattributeconfiguration_modifiedby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_solutioncomponentattributeconfiguration_modifiedonbehalfby'
        /// </summary>
		[RelationshipSchemaName("lk_solutioncomponentattributeconfiguration_modifiedonbehalfby")]
		public IEnumerable<SolutionComponentAttributeConfiguration> LkSolutioncomponentattributeconfigurationModifiedonbehalfby
		{
			get { return GetRelatedEntities<SolutionComponentAttributeConfiguration>("lk_solutioncomponentattributeconfiguration_modifiedonbehalfby", null); }
			set { SetRelatedEntities("lk_solutioncomponentattributeconfiguration_modifiedonbehalfby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_solutioncomponentbase_createdonbehalfby'
        /// </summary>
		[RelationshipSchemaName("lk_solutioncomponentbase_createdonbehalfby")]
		public IEnumerable<SolutionComponent> LkSolutioncomponentbaseCreatedonbehalfby
		{
			get { return GetRelatedEntities<SolutionComponent>("lk_solutioncomponentbase_createdonbehalfby", null); }
			set { SetRelatedEntities("lk_solutioncomponentbase_createdonbehalfby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_solutioncomponentbase_modifiedonbehalfby'
        /// </summary>
		[RelationshipSchemaName("lk_solutioncomponentbase_modifiedonbehalfby")]
		public IEnumerable<SolutionComponent> LkSolutioncomponentbaseModifiedonbehalfby
		{
			get { return GetRelatedEntities<SolutionComponent>("lk_solutioncomponentbase_modifiedonbehalfby", null); }
			set { SetRelatedEntities("lk_solutioncomponentbase_modifiedonbehalfby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_solutioncomponentconfiguration_createdby'
        /// </summary>
		[RelationshipSchemaName("lk_solutioncomponentconfiguration_createdby")]
		public IEnumerable<SolutionComponentConfiguration> LkSolutioncomponentconfigurationCreatedby
		{
			get { return GetRelatedEntities<SolutionComponentConfiguration>("lk_solutioncomponentconfiguration_createdby", null); }
			set { SetRelatedEntities("lk_solutioncomponentconfiguration_createdby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_solutioncomponentconfiguration_createdonbehalfby'
        /// </summary>
		[RelationshipSchemaName("lk_solutioncomponentconfiguration_createdonbehalfby")]
		public IEnumerable<SolutionComponentConfiguration> LkSolutioncomponentconfigurationCreatedonbehalfby
		{
			get { return GetRelatedEntities<SolutionComponentConfiguration>("lk_solutioncomponentconfiguration_createdonbehalfby", null); }
			set { SetRelatedEntities("lk_solutioncomponentconfiguration_createdonbehalfby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_solutioncomponentconfiguration_modifiedby'
        /// </summary>
		[RelationshipSchemaName("lk_solutioncomponentconfiguration_modifiedby")]
		public IEnumerable<SolutionComponentConfiguration> LkSolutioncomponentconfigurationModifiedby
		{
			get { return GetRelatedEntities<SolutionComponentConfiguration>("lk_solutioncomponentconfiguration_modifiedby", null); }
			set { SetRelatedEntities("lk_solutioncomponentconfiguration_modifiedby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_solutioncomponentconfiguration_modifiedonbehalfby'
        /// </summary>
		[RelationshipSchemaName("lk_solutioncomponentconfiguration_modifiedonbehalfby")]
		public IEnumerable<SolutionComponentConfiguration> LkSolutioncomponentconfigurationModifiedonbehalfby
		{
			get { return GetRelatedEntities<SolutionComponentConfiguration>("lk_solutioncomponentconfiguration_modifiedonbehalfby", null); }
			set { SetRelatedEntities("lk_solutioncomponentconfiguration_modifiedonbehalfby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_solutioncomponentrelationshipconfiguration_createdby'
        /// </summary>
		[RelationshipSchemaName("lk_solutioncomponentrelationshipconfiguration_createdby")]
		public IEnumerable<SolutionComponentRelationshipConfiguration> LkSolutioncomponentrelationshipconfigurationCreatedby
		{
			get { return GetRelatedEntities<SolutionComponentRelationshipConfiguration>("lk_solutioncomponentrelationshipconfiguration_createdby", null); }
			set { SetRelatedEntities("lk_solutioncomponentrelationshipconfiguration_createdby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_solutioncomponentrelationshipconfiguration_createdonbehalfby'
        /// </summary>
		[RelationshipSchemaName("lk_solutioncomponentrelationshipconfiguration_createdonbehalfby")]
		public IEnumerable<SolutionComponentRelationshipConfiguration> LkSolutioncomponentrelationshipconfigurationCreatedonbehalfby
		{
			get { return GetRelatedEntities<SolutionComponentRelationshipConfiguration>("lk_solutioncomponentrelationshipconfiguration_createdonbehalfby", null); }
			set { SetRelatedEntities("lk_solutioncomponentrelationshipconfiguration_createdonbehalfby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_solutioncomponentrelationshipconfiguration_modifiedby'
        /// </summary>
		[RelationshipSchemaName("lk_solutioncomponentrelationshipconfiguration_modifiedby")]
		public IEnumerable<SolutionComponentRelationshipConfiguration> LkSolutioncomponentrelationshipconfigurationModifiedby
		{
			get { return GetRelatedEntities<SolutionComponentRelationshipConfiguration>("lk_solutioncomponentrelationshipconfiguration_modifiedby", null); }
			set { SetRelatedEntities("lk_solutioncomponentrelationshipconfiguration_modifiedby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_solutioncomponentrelationshipconfiguration_modifiedonbehalfby'
        /// </summary>
		[RelationshipSchemaName("lk_solutioncomponentrelationshipconfiguration_modifiedonbehalfby")]
		public IEnumerable<SolutionComponentRelationshipConfiguration> LkSolutioncomponentrelationshipconfigurationModifiedonbehalfby
		{
			get { return GetRelatedEntities<SolutionComponentRelationshipConfiguration>("lk_solutioncomponentrelationshipconfiguration_modifiedonbehalfby", null); }
			set { SetRelatedEntities("lk_solutioncomponentrelationshipconfiguration_modifiedonbehalfby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_stagesolutionupload_createdby'
        /// </summary>
		[RelationshipSchemaName("lk_stagesolutionupload_createdby")]
		public IEnumerable<StageSolutionUpload> LkStagesolutionuploadCreatedby
		{
			get { return GetRelatedEntities<StageSolutionUpload>("lk_stagesolutionupload_createdby", null); }
			set { SetRelatedEntities("lk_stagesolutionupload_createdby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_stagesolutionupload_createdonbehalfby'
        /// </summary>
		[RelationshipSchemaName("lk_stagesolutionupload_createdonbehalfby")]
		public IEnumerable<StageSolutionUpload> LkStagesolutionuploadCreatedonbehalfby
		{
			get { return GetRelatedEntities<StageSolutionUpload>("lk_stagesolutionupload_createdonbehalfby", null); }
			set { SetRelatedEntities("lk_stagesolutionupload_createdonbehalfby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_stagesolutionupload_modifiedby'
        /// </summary>
		[RelationshipSchemaName("lk_stagesolutionupload_modifiedby")]
		public IEnumerable<StageSolutionUpload> LkStagesolutionuploadModifiedby
		{
			get { return GetRelatedEntities<StageSolutionUpload>("lk_stagesolutionupload_modifiedby", null); }
			set { SetRelatedEntities("lk_stagesolutionupload_modifiedby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_stagesolutionupload_modifiedonbehalfby'
        /// </summary>
		[RelationshipSchemaName("lk_stagesolutionupload_modifiedonbehalfby")]
		public IEnumerable<StageSolutionUpload> LkStagesolutionuploadModifiedonbehalfby
		{
			get { return GetRelatedEntities<StageSolutionUpload>("lk_stagesolutionupload_modifiedonbehalfby", null); }
			set { SetRelatedEntities("lk_stagesolutionupload_modifiedonbehalfby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_subject_createdonbehalfby'
        /// </summary>
		[RelationshipSchemaName("lk_subject_createdonbehalfby")]
		public IEnumerable<Subject> LkSubjectCreatedonbehalfby
		{
			get { return GetRelatedEntities<Subject>("lk_subject_createdonbehalfby", null); }
			set { SetRelatedEntities("lk_subject_createdonbehalfby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_subject_modifiedonbehalfby'
        /// </summary>
		[RelationshipSchemaName("lk_subject_modifiedonbehalfby")]
		public IEnumerable<Subject> LkSubjectModifiedonbehalfby
		{
			get { return GetRelatedEntities<Subject>("lk_subject_modifiedonbehalfby", null); }
			set { SetRelatedEntities("lk_subject_modifiedonbehalfby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_subjectbase_createdby'
        /// </summary>
		[RelationshipSchemaName("lk_subjectbase_createdby")]
		public IEnumerable<Subject> LkSubjectbaseCreatedby
		{
			get { return GetRelatedEntities<Subject>("lk_subjectbase_createdby", null); }
			set { SetRelatedEntities("lk_subjectbase_createdby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_subjectbase_modifiedby'
        /// </summary>
		[RelationshipSchemaName("lk_subjectbase_modifiedby")]
		public IEnumerable<Subject> LkSubjectbaseModifiedby
		{
			get { return GetRelatedEntities<Subject>("lk_subjectbase_modifiedby", null); }
			set { SetRelatedEntities("lk_subjectbase_modifiedby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_syncerrorbase_createdby'
        /// </summary>
		[RelationshipSchemaName("lk_syncerrorbase_createdby")]
		public IEnumerable<SyncError> LkSyncerrorbaseCreatedby
		{
			get { return GetRelatedEntities<SyncError>("lk_syncerrorbase_createdby", null); }
			set { SetRelatedEntities("lk_syncerrorbase_createdby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_syncerrorbase_createdonbehalfby'
        /// </summary>
		[RelationshipSchemaName("lk_syncerrorbase_createdonbehalfby")]
		public IEnumerable<SyncError> LkSyncerrorbaseCreatedonbehalfby
		{
			get { return GetRelatedEntities<SyncError>("lk_syncerrorbase_createdonbehalfby", null); }
			set { SetRelatedEntities("lk_syncerrorbase_createdonbehalfby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_syncerrorbase_modifiedby'
        /// </summary>
		[RelationshipSchemaName("lk_syncerrorbase_modifiedby")]
		public IEnumerable<SyncError> LkSyncerrorbaseModifiedby
		{
			get { return GetRelatedEntities<SyncError>("lk_syncerrorbase_modifiedby", null); }
			set { SetRelatedEntities("lk_syncerrorbase_modifiedby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_syncerrorbase_modifiedonbehalfby'
        /// </summary>
		[RelationshipSchemaName("lk_syncerrorbase_modifiedonbehalfby")]
		public IEnumerable<SyncError> LkSyncerrorbaseModifiedonbehalfby
		{
			get { return GetRelatedEntities<SyncError>("lk_syncerrorbase_modifiedonbehalfby", null); }
			set { SetRelatedEntities("lk_syncerrorbase_modifiedonbehalfby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_systemuser_createdonbehalfby'
        /// </summary>
		[RelationshipSchemaName("lk_systemuser_createdonbehalfby")]
		public IEnumerable<User> LkSystemuserCreatedonbehalfby
		{
			get { return GetRelatedEntities<User>("lk_systemuser_createdonbehalfby", null); }
			set { SetRelatedEntities("lk_systemuser_createdonbehalfby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_systemuser_modifiedonbehalfby'
        /// </summary>
		[RelationshipSchemaName("lk_systemuser_modifiedonbehalfby")]
		public IEnumerable<User> LkSystemuserModifiedonbehalfby
		{
			get { return GetRelatedEntities<User>("lk_systemuser_modifiedonbehalfby", null); }
			set { SetRelatedEntities("lk_systemuser_modifiedonbehalfby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_systemuserbase_createdby'
        /// </summary>
		[RelationshipSchemaName("lk_systemuserbase_createdby")]
		public IEnumerable<User> LkSystemuserbaseCreatedby
		{
			get { return GetRelatedEntities<User>("lk_systemuserbase_createdby", null); }
			set { SetRelatedEntities("lk_systemuserbase_createdby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_systemuserbase_modifiedby'
        /// </summary>
		[RelationshipSchemaName("lk_systemuserbase_modifiedby")]
		public IEnumerable<User> LkSystemuserbaseModifiedby
		{
			get { return GetRelatedEntities<User>("lk_systemuserbase_modifiedby", null); }
			set { SetRelatedEntities("lk_systemuserbase_modifiedby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_task_createdby'
        /// </summary>
		[RelationshipSchemaName("lk_task_createdby")]
		public IEnumerable<Task> LkTaskCreatedby
		{
			get { return GetRelatedEntities<Task>("lk_task_createdby", null); }
			set { SetRelatedEntities("lk_task_createdby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_task_createdonbehalfby'
        /// </summary>
		[RelationshipSchemaName("lk_task_createdonbehalfby")]
		public IEnumerable<Task> LkTaskCreatedonbehalfby
		{
			get { return GetRelatedEntities<Task>("lk_task_createdonbehalfby", null); }
			set { SetRelatedEntities("lk_task_createdonbehalfby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_task_modifiedby'
        /// </summary>
		[RelationshipSchemaName("lk_task_modifiedby")]
		public IEnumerable<Task> LkTaskModifiedby
		{
			get { return GetRelatedEntities<Task>("lk_task_modifiedby", null); }
			set { SetRelatedEntities("lk_task_modifiedby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_task_modifiedonbehalfby'
        /// </summary>
		[RelationshipSchemaName("lk_task_modifiedonbehalfby")]
		public IEnumerable<Task> LkTaskModifiedonbehalfby
		{
			get { return GetRelatedEntities<Task>("lk_task_modifiedonbehalfby", null); }
			set { SetRelatedEntities("lk_task_modifiedonbehalfby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_team_createdonbehalfby'
        /// </summary>
		[RelationshipSchemaName("lk_team_createdonbehalfby")]
		public IEnumerable<Team> LkTeamCreatedonbehalfby
		{
			get { return GetRelatedEntities<Team>("lk_team_createdonbehalfby", null); }
			set { SetRelatedEntities("lk_team_createdonbehalfby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_team_modifiedonbehalfby'
        /// </summary>
		[RelationshipSchemaName("lk_team_modifiedonbehalfby")]
		public IEnumerable<Team> LkTeamModifiedonbehalfby
		{
			get { return GetRelatedEntities<Team>("lk_team_modifiedonbehalfby", null); }
			set { SetRelatedEntities("lk_team_modifiedonbehalfby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_teambase_administratorid'
        /// </summary>
		[RelationshipSchemaName("lk_teambase_administratorid")]
		public IEnumerable<Team> LkTeambaseAdministratorid
		{
			get { return GetRelatedEntities<Team>("lk_teambase_administratorid", null); }
			set { SetRelatedEntities("lk_teambase_administratorid", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_teambase_createdby'
        /// </summary>
		[RelationshipSchemaName("lk_teambase_createdby")]
		public IEnumerable<Team> LkTeambaseCreatedby
		{
			get { return GetRelatedEntities<Team>("lk_teambase_createdby", null); }
			set { SetRelatedEntities("lk_teambase_createdby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_teambase_modifiedby'
        /// </summary>
		[RelationshipSchemaName("lk_teambase_modifiedby")]
		public IEnumerable<Team> LkTeambaseModifiedby
		{
			get { return GetRelatedEntities<Team>("lk_teambase_modifiedby", null); }
			set { SetRelatedEntities("lk_teambase_modifiedby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_teamtemplate_createdby'
        /// </summary>
		[RelationshipSchemaName("lk_teamtemplate_createdby")]
		public IEnumerable<TeamTemplate> LkTeamtemplateCreatedby
		{
			get { return GetRelatedEntities<TeamTemplate>("lk_teamtemplate_createdby", null); }
			set { SetRelatedEntities("lk_teamtemplate_createdby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_teamtemplate_createdonbehalfby'
        /// </summary>
		[RelationshipSchemaName("lk_teamtemplate_createdonbehalfby")]
		public IEnumerable<TeamTemplate> LkTeamtemplateCreatedonbehalfby
		{
			get { return GetRelatedEntities<TeamTemplate>("lk_teamtemplate_createdonbehalfby", null); }
			set { SetRelatedEntities("lk_teamtemplate_createdonbehalfby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_teamtemplate_modifiedby'
        /// </summary>
		[RelationshipSchemaName("lk_teamtemplate_modifiedby")]
		public IEnumerable<TeamTemplate> LkTeamtemplateModifiedby
		{
			get { return GetRelatedEntities<TeamTemplate>("lk_teamtemplate_modifiedby", null); }
			set { SetRelatedEntities("lk_teamtemplate_modifiedby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_teamtemplate_modifiedonbehalfby'
        /// </summary>
		[RelationshipSchemaName("lk_teamtemplate_modifiedonbehalfby")]
		public IEnumerable<TeamTemplate> LkTeamtemplateModifiedonbehalfby
		{
			get { return GetRelatedEntities<TeamTemplate>("lk_teamtemplate_modifiedonbehalfby", null); }
			set { SetRelatedEntities("lk_teamtemplate_modifiedonbehalfby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_templatebase_createdby'
        /// </summary>
		[RelationshipSchemaName("lk_templatebase_createdby")]
		public IEnumerable<EmailTemplate> LkTemplatebaseCreatedby
		{
			get { return GetRelatedEntities<EmailTemplate>("lk_templatebase_createdby", null); }
			set { SetRelatedEntities("lk_templatebase_createdby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_templatebase_createdonbehalfby'
        /// </summary>
		[RelationshipSchemaName("lk_templatebase_createdonbehalfby")]
		public IEnumerable<EmailTemplate> LkTemplatebaseCreatedonbehalfby
		{
			get { return GetRelatedEntities<EmailTemplate>("lk_templatebase_createdonbehalfby", null); }
			set { SetRelatedEntities("lk_templatebase_createdonbehalfby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_templatebase_modifiedby'
        /// </summary>
		[RelationshipSchemaName("lk_templatebase_modifiedby")]
		public IEnumerable<EmailTemplate> LkTemplatebaseModifiedby
		{
			get { return GetRelatedEntities<EmailTemplate>("lk_templatebase_modifiedby", null); }
			set { SetRelatedEntities("lk_templatebase_modifiedby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_templatebase_modifiedonbehalfby'
        /// </summary>
		[RelationshipSchemaName("lk_templatebase_modifiedonbehalfby")]
		public IEnumerable<EmailTemplate> LkTemplatebaseModifiedonbehalfby
		{
			get { return GetRelatedEntities<EmailTemplate>("lk_templatebase_modifiedonbehalfby", null); }
			set { SetRelatedEntities("lk_templatebase_modifiedonbehalfby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_territory_createdonbehalfby'
        /// </summary>
		[RelationshipSchemaName("lk_territory_createdonbehalfby")]
		public IEnumerable<Territory> LkTerritoryCreatedonbehalfby
		{
			get { return GetRelatedEntities<Territory>("lk_territory_createdonbehalfby", null); }
			set { SetRelatedEntities("lk_territory_createdonbehalfby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_territory_modifiedonbehalfby'
        /// </summary>
		[RelationshipSchemaName("lk_territory_modifiedonbehalfby")]
		public IEnumerable<Territory> LkTerritoryModifiedonbehalfby
		{
			get { return GetRelatedEntities<Territory>("lk_territory_modifiedonbehalfby", null); }
			set { SetRelatedEntities("lk_territory_modifiedonbehalfby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_territorybase_createdby'
        /// </summary>
		[RelationshipSchemaName("lk_territorybase_createdby")]
		public IEnumerable<Territory> LkTerritorybaseCreatedby
		{
			get { return GetRelatedEntities<Territory>("lk_territorybase_createdby", null); }
			set { SetRelatedEntities("lk_territorybase_createdby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_territorybase_modifiedby'
        /// </summary>
		[RelationshipSchemaName("lk_territorybase_modifiedby")]
		public IEnumerable<Territory> LkTerritorybaseModifiedby
		{
			get { return GetRelatedEntities<Territory>("lk_territorybase_modifiedby", null); }
			set { SetRelatedEntities("lk_territorybase_modifiedby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_theme_createdby'
        /// </summary>
		[RelationshipSchemaName("lk_theme_createdby")]
		public IEnumerable<Theme> LkThemeCreatedby
		{
			get { return GetRelatedEntities<Theme>("lk_theme_createdby", null); }
			set { SetRelatedEntities("lk_theme_createdby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_theme_createdonbehalfby'
        /// </summary>
		[RelationshipSchemaName("lk_theme_createdonbehalfby")]
		public IEnumerable<Theme> LkThemeCreatedonbehalfby
		{
			get { return GetRelatedEntities<Theme>("lk_theme_createdonbehalfby", null); }
			set { SetRelatedEntities("lk_theme_createdonbehalfby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_theme_modifiedby'
        /// </summary>
		[RelationshipSchemaName("lk_theme_modifiedby")]
		public IEnumerable<Theme> LkThemeModifiedby
		{
			get { return GetRelatedEntities<Theme>("lk_theme_modifiedby", null); }
			set { SetRelatedEntities("lk_theme_modifiedby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_theme_modifiedonbehalfby'
        /// </summary>
		[RelationshipSchemaName("lk_theme_modifiedonbehalfby")]
		public IEnumerable<Theme> LkThemeModifiedonbehalfby
		{
			get { return GetRelatedEntities<Theme>("lk_theme_modifiedonbehalfby", null); }
			set { SetRelatedEntities("lk_theme_modifiedonbehalfby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_timezonedefinition_createdby'
        /// </summary>
		[RelationshipSchemaName("lk_timezonedefinition_createdby")]
		public IEnumerable<TimeZoneDefinition> LkTimezonedefinitionCreatedby
		{
			get { return GetRelatedEntities<TimeZoneDefinition>("lk_timezonedefinition_createdby", null); }
			set { SetRelatedEntities("lk_timezonedefinition_createdby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_timezonedefinition_createdonbehalfby'
        /// </summary>
		[RelationshipSchemaName("lk_timezonedefinition_createdonbehalfby")]
		public IEnumerable<TimeZoneDefinition> LkTimezonedefinitionCreatedonbehalfby
		{
			get { return GetRelatedEntities<TimeZoneDefinition>("lk_timezonedefinition_createdonbehalfby", null); }
			set { SetRelatedEntities("lk_timezonedefinition_createdonbehalfby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_timezonedefinition_modifiedby'
        /// </summary>
		[RelationshipSchemaName("lk_timezonedefinition_modifiedby")]
		public IEnumerable<TimeZoneDefinition> LkTimezonedefinitionModifiedby
		{
			get { return GetRelatedEntities<TimeZoneDefinition>("lk_timezonedefinition_modifiedby", null); }
			set { SetRelatedEntities("lk_timezonedefinition_modifiedby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_timezonedefinition_modifiedonbehalfby'
        /// </summary>
		[RelationshipSchemaName("lk_timezonedefinition_modifiedonbehalfby")]
		public IEnumerable<TimeZoneDefinition> LkTimezonedefinitionModifiedonbehalfby
		{
			get { return GetRelatedEntities<TimeZoneDefinition>("lk_timezonedefinition_modifiedonbehalfby", null); }
			set { SetRelatedEntities("lk_timezonedefinition_modifiedonbehalfby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_timezonelocalizedname_createdby'
        /// </summary>
		[RelationshipSchemaName("lk_timezonelocalizedname_createdby")]
		public IEnumerable<TimeZoneLocalizedName> LkTimezonelocalizednameCreatedby
		{
			get { return GetRelatedEntities<TimeZoneLocalizedName>("lk_timezonelocalizedname_createdby", null); }
			set { SetRelatedEntities("lk_timezonelocalizedname_createdby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_timezonelocalizedname_createdonbehalfby'
        /// </summary>
		[RelationshipSchemaName("lk_timezonelocalizedname_createdonbehalfby")]
		public IEnumerable<TimeZoneLocalizedName> LkTimezonelocalizednameCreatedonbehalfby
		{
			get { return GetRelatedEntities<TimeZoneLocalizedName>("lk_timezonelocalizedname_createdonbehalfby", null); }
			set { SetRelatedEntities("lk_timezonelocalizedname_createdonbehalfby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_timezonelocalizedname_modifiedby'
        /// </summary>
		[RelationshipSchemaName("lk_timezonelocalizedname_modifiedby")]
		public IEnumerable<TimeZoneLocalizedName> LkTimezonelocalizednameModifiedby
		{
			get { return GetRelatedEntities<TimeZoneLocalizedName>("lk_timezonelocalizedname_modifiedby", null); }
			set { SetRelatedEntities("lk_timezonelocalizedname_modifiedby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_timezonelocalizedname_modifiedonbehalfby'
        /// </summary>
		[RelationshipSchemaName("lk_timezonelocalizedname_modifiedonbehalfby")]
		public IEnumerable<TimeZoneLocalizedName> LkTimezonelocalizednameModifiedonbehalfby
		{
			get { return GetRelatedEntities<TimeZoneLocalizedName>("lk_timezonelocalizedname_modifiedonbehalfby", null); }
			set { SetRelatedEntities("lk_timezonelocalizedname_modifiedonbehalfby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_timezonerule_createdby'
        /// </summary>
		[RelationshipSchemaName("lk_timezonerule_createdby")]
		public IEnumerable<TimeZoneRule> LkTimezoneruleCreatedby
		{
			get { return GetRelatedEntities<TimeZoneRule>("lk_timezonerule_createdby", null); }
			set { SetRelatedEntities("lk_timezonerule_createdby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_timezonerule_createdonbehalfby'
        /// </summary>
		[RelationshipSchemaName("lk_timezonerule_createdonbehalfby")]
		public IEnumerable<TimeZoneRule> LkTimezoneruleCreatedonbehalfby
		{
			get { return GetRelatedEntities<TimeZoneRule>("lk_timezonerule_createdonbehalfby", null); }
			set { SetRelatedEntities("lk_timezonerule_createdonbehalfby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_timezonerule_modifiedby'
        /// </summary>
		[RelationshipSchemaName("lk_timezonerule_modifiedby")]
		public IEnumerable<TimeZoneRule> LkTimezoneruleModifiedby
		{
			get { return GetRelatedEntities<TimeZoneRule>("lk_timezonerule_modifiedby", null); }
			set { SetRelatedEntities("lk_timezonerule_modifiedby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_timezonerule_modifiedonbehalfby'
        /// </summary>
		[RelationshipSchemaName("lk_timezonerule_modifiedonbehalfby")]
		public IEnumerable<TimeZoneRule> LkTimezoneruleModifiedonbehalfby
		{
			get { return GetRelatedEntities<TimeZoneRule>("lk_timezonerule_modifiedonbehalfby", null); }
			set { SetRelatedEntities("lk_timezonerule_modifiedonbehalfby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_tracelog_createdby'
        /// </summary>
		[RelationshipSchemaName("lk_tracelog_createdby")]
		public IEnumerable<Trace> LkTracelogCreatedby
		{
			get { return GetRelatedEntities<Trace>("lk_tracelog_createdby", null); }
			set { SetRelatedEntities("lk_tracelog_createdby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_tracelog_createdonbehalfby'
        /// </summary>
		[RelationshipSchemaName("lk_tracelog_createdonbehalfby")]
		public IEnumerable<Trace> LkTracelogCreatedonbehalfby
		{
			get { return GetRelatedEntities<Trace>("lk_tracelog_createdonbehalfby", null); }
			set { SetRelatedEntities("lk_tracelog_createdonbehalfby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_tracelog_modifiedby'
        /// </summary>
		[RelationshipSchemaName("lk_tracelog_modifiedby")]
		public IEnumerable<Trace> LkTracelogModifiedby
		{
			get { return GetRelatedEntities<Trace>("lk_tracelog_modifiedby", null); }
			set { SetRelatedEntities("lk_tracelog_modifiedby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_tracelog_modifiedonbehalfby'
        /// </summary>
		[RelationshipSchemaName("lk_tracelog_modifiedonbehalfby")]
		public IEnumerable<Trace> LkTracelogModifiedonbehalfby
		{
			get { return GetRelatedEntities<Trace>("lk_tracelog_modifiedonbehalfby", null); }
			set { SetRelatedEntities("lk_tracelog_modifiedonbehalfby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_transactioncurrency_createdonbehalfby'
        /// </summary>
		[RelationshipSchemaName("lk_transactioncurrency_createdonbehalfby")]
		public IEnumerable<Currency> LkTransactioncurrencyCreatedonbehalfby
		{
			get { return GetRelatedEntities<Currency>("lk_transactioncurrency_createdonbehalfby", null); }
			set { SetRelatedEntities("lk_transactioncurrency_createdonbehalfby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_transactioncurrency_modifiedonbehalfby'
        /// </summary>
		[RelationshipSchemaName("lk_transactioncurrency_modifiedonbehalfby")]
		public IEnumerable<Currency> LkTransactioncurrencyModifiedonbehalfby
		{
			get { return GetRelatedEntities<Currency>("lk_transactioncurrency_modifiedonbehalfby", null); }
			set { SetRelatedEntities("lk_transactioncurrency_modifiedonbehalfby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_transactioncurrencybase_createdby'
        /// </summary>
		[RelationshipSchemaName("lk_transactioncurrencybase_createdby")]
		public IEnumerable<Currency> LkTransactioncurrencybaseCreatedby
		{
			get { return GetRelatedEntities<Currency>("lk_transactioncurrencybase_createdby", null); }
			set { SetRelatedEntities("lk_transactioncurrencybase_createdby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_transactioncurrencybase_modifiedby'
        /// </summary>
		[RelationshipSchemaName("lk_transactioncurrencybase_modifiedby")]
		public IEnumerable<Currency> LkTransactioncurrencybaseModifiedby
		{
			get { return GetRelatedEntities<Currency>("lk_transactioncurrencybase_modifiedby", null); }
			set { SetRelatedEntities("lk_transactioncurrencybase_modifiedby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_transformationmapping_createdby'
        /// </summary>
		[RelationshipSchemaName("lk_transformationmapping_createdby")]
		public IEnumerable<TransformationMapping> LkTransformationmappingCreatedby
		{
			get { return GetRelatedEntities<TransformationMapping>("lk_transformationmapping_createdby", null); }
			set { SetRelatedEntities("lk_transformationmapping_createdby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_transformationmapping_createdonbehalfby'
        /// </summary>
		[RelationshipSchemaName("lk_transformationmapping_createdonbehalfby")]
		public IEnumerable<TransformationMapping> LkTransformationmappingCreatedonbehalfby
		{
			get { return GetRelatedEntities<TransformationMapping>("lk_transformationmapping_createdonbehalfby", null); }
			set { SetRelatedEntities("lk_transformationmapping_createdonbehalfby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_transformationmapping_modifiedby'
        /// </summary>
		[RelationshipSchemaName("lk_transformationmapping_modifiedby")]
		public IEnumerable<TransformationMapping> LkTransformationmappingModifiedby
		{
			get { return GetRelatedEntities<TransformationMapping>("lk_transformationmapping_modifiedby", null); }
			set { SetRelatedEntities("lk_transformationmapping_modifiedby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_transformationmapping_modifiedonbehalfby'
        /// </summary>
		[RelationshipSchemaName("lk_transformationmapping_modifiedonbehalfby")]
		public IEnumerable<TransformationMapping> LkTransformationmappingModifiedonbehalfby
		{
			get { return GetRelatedEntities<TransformationMapping>("lk_transformationmapping_modifiedonbehalfby", null); }
			set { SetRelatedEntities("lk_transformationmapping_modifiedonbehalfby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_transformationparametermapping_createdby'
        /// </summary>
		[RelationshipSchemaName("lk_transformationparametermapping_createdby")]
		public IEnumerable<TransformationParameterMapping> LkTransformationparametermappingCreatedby
		{
			get { return GetRelatedEntities<TransformationParameterMapping>("lk_transformationparametermapping_createdby", null); }
			set { SetRelatedEntities("lk_transformationparametermapping_createdby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_transformationparametermapping_createdonbehalfby'
        /// </summary>
		[RelationshipSchemaName("lk_transformationparametermapping_createdonbehalfby")]
		public IEnumerable<TransformationParameterMapping> LkTransformationparametermappingCreatedonbehalfby
		{
			get { return GetRelatedEntities<TransformationParameterMapping>("lk_transformationparametermapping_createdonbehalfby", null); }
			set { SetRelatedEntities("lk_transformationparametermapping_createdonbehalfby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_transformationparametermapping_modifiedby'
        /// </summary>
		[RelationshipSchemaName("lk_transformationparametermapping_modifiedby")]
		public IEnumerable<TransformationParameterMapping> LkTransformationparametermappingModifiedby
		{
			get { return GetRelatedEntities<TransformationParameterMapping>("lk_transformationparametermapping_modifiedby", null); }
			set { SetRelatedEntities("lk_transformationparametermapping_modifiedby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_transformationparametermapping_modifiedonbehalfby'
        /// </summary>
		[RelationshipSchemaName("lk_transformationparametermapping_modifiedonbehalfby")]
		public IEnumerable<TransformationParameterMapping> LkTransformationparametermappingModifiedonbehalfby
		{
			get { return GetRelatedEntities<TransformationParameterMapping>("lk_transformationparametermapping_modifiedonbehalfby", null); }
			set { SetRelatedEntities("lk_transformationparametermapping_modifiedonbehalfby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_translationprocess_createdby'
        /// </summary>
		[RelationshipSchemaName("lk_translationprocess_createdby")]
		public IEnumerable<TranslationProcess> LkTranslationprocessCreatedby
		{
			get { return GetRelatedEntities<TranslationProcess>("lk_translationprocess_createdby", null); }
			set { SetRelatedEntities("lk_translationprocess_createdby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_translationprocess_createdonbehalfby'
        /// </summary>
		[RelationshipSchemaName("lk_translationprocess_createdonbehalfby")]
		public IEnumerable<TranslationProcess> LkTranslationprocessCreatedonbehalfby
		{
			get { return GetRelatedEntities<TranslationProcess>("lk_translationprocess_createdonbehalfby", null); }
			set { SetRelatedEntities("lk_translationprocess_createdonbehalfby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_translationprocess_modifiedby'
        /// </summary>
		[RelationshipSchemaName("lk_translationprocess_modifiedby")]
		public IEnumerable<TranslationProcess> LkTranslationprocessModifiedby
		{
			get { return GetRelatedEntities<TranslationProcess>("lk_translationprocess_modifiedby", null); }
			set { SetRelatedEntities("lk_translationprocess_modifiedby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_translationprocess_modifiedonbehalfby'
        /// </summary>
		[RelationshipSchemaName("lk_translationprocess_modifiedonbehalfby")]
		public IEnumerable<TranslationProcess> LkTranslationprocessModifiedonbehalfby
		{
			get { return GetRelatedEntities<TranslationProcess>("lk_translationprocess_modifiedonbehalfby", null); }
			set { SetRelatedEntities("lk_translationprocess_modifiedonbehalfby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_uom_createdonbehalfby'
        /// </summary>
		[RelationshipSchemaName("lk_uom_createdonbehalfby")]
		public IEnumerable<Unit> LkUomCreatedonbehalfby
		{
			get { return GetRelatedEntities<Unit>("lk_uom_createdonbehalfby", null); }
			set { SetRelatedEntities("lk_uom_createdonbehalfby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_uom_modifiedonbehalfby'
        /// </summary>
		[RelationshipSchemaName("lk_uom_modifiedonbehalfby")]
		public IEnumerable<Unit> LkUomModifiedonbehalfby
		{
			get { return GetRelatedEntities<Unit>("lk_uom_modifiedonbehalfby", null); }
			set { SetRelatedEntities("lk_uom_modifiedonbehalfby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_uombase_createdby'
        /// </summary>
		[RelationshipSchemaName("lk_uombase_createdby")]
		public IEnumerable<Unit> LkUombaseCreatedby
		{
			get { return GetRelatedEntities<Unit>("lk_uombase_createdby", null); }
			set { SetRelatedEntities("lk_uombase_createdby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_uombase_modifiedby'
        /// </summary>
		[RelationshipSchemaName("lk_uombase_modifiedby")]
		public IEnumerable<Unit> LkUombaseModifiedby
		{
			get { return GetRelatedEntities<Unit>("lk_uombase_modifiedby", null); }
			set { SetRelatedEntities("lk_uombase_modifiedby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_uomschedule_createdonbehalfby'
        /// </summary>
		[RelationshipSchemaName("lk_uomschedule_createdonbehalfby")]
		public IEnumerable<UnitGroup> LkUomscheduleCreatedonbehalfby
		{
			get { return GetRelatedEntities<UnitGroup>("lk_uomschedule_createdonbehalfby", null); }
			set { SetRelatedEntities("lk_uomschedule_createdonbehalfby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_uomschedule_modifiedonbehalfby'
        /// </summary>
		[RelationshipSchemaName("lk_uomschedule_modifiedonbehalfby")]
		public IEnumerable<UnitGroup> LkUomscheduleModifiedonbehalfby
		{
			get { return GetRelatedEntities<UnitGroup>("lk_uomschedule_modifiedonbehalfby", null); }
			set { SetRelatedEntities("lk_uomschedule_modifiedonbehalfby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_uomschedulebase_createdby'
        /// </summary>
		[RelationshipSchemaName("lk_uomschedulebase_createdby")]
		public IEnumerable<UnitGroup> LkUomschedulebaseCreatedby
		{
			get { return GetRelatedEntities<UnitGroup>("lk_uomschedulebase_createdby", null); }
			set { SetRelatedEntities("lk_uomschedulebase_createdby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_uomschedulebase_modifiedby'
        /// </summary>
		[RelationshipSchemaName("lk_uomschedulebase_modifiedby")]
		public IEnumerable<UnitGroup> LkUomschedulebaseModifiedby
		{
			get { return GetRelatedEntities<UnitGroup>("lk_uomschedulebase_modifiedby", null); }
			set { SetRelatedEntities("lk_uomschedulebase_modifiedby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_userform_createdby'
        /// </summary>
		[RelationshipSchemaName("lk_userform_createdby")]
		public IEnumerable<UserDashboard> LkUserformCreatedby
		{
			get { return GetRelatedEntities<UserDashboard>("lk_userform_createdby", null); }
			set { SetRelatedEntities("lk_userform_createdby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_userform_modifiedby'
        /// </summary>
		[RelationshipSchemaName("lk_userform_modifiedby")]
		public IEnumerable<UserDashboard> LkUserformModifiedby
		{
			get { return GetRelatedEntities<UserDashboard>("lk_userform_modifiedby", null); }
			set { SetRelatedEntities("lk_userform_modifiedby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_userformbase_createdonbehalfby'
        /// </summary>
		[RelationshipSchemaName("lk_userformbase_createdonbehalfby")]
		public IEnumerable<UserDashboard> LkUserformbaseCreatedonbehalfby
		{
			get { return GetRelatedEntities<UserDashboard>("lk_userformbase_createdonbehalfby", null); }
			set { SetRelatedEntities("lk_userformbase_createdonbehalfby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_userformbase_modifiedonbehalfby'
        /// </summary>
		[RelationshipSchemaName("lk_userformbase_modifiedonbehalfby")]
		public IEnumerable<UserDashboard> LkUserformbaseModifiedonbehalfby
		{
			get { return GetRelatedEntities<UserDashboard>("lk_userformbase_modifiedonbehalfby", null); }
			set { SetRelatedEntities("lk_userformbase_modifiedonbehalfby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_usermapping_createdby'
        /// </summary>
		[RelationshipSchemaName("lk_usermapping_createdby")]
		public IEnumerable<UserMapping> LkUsermappingCreatedby
		{
			get { return GetRelatedEntities<UserMapping>("lk_usermapping_createdby", null); }
			set { SetRelatedEntities("lk_usermapping_createdby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_usermapping_createdonbehalfby'
        /// </summary>
		[RelationshipSchemaName("lk_usermapping_createdonbehalfby")]
		public IEnumerable<UserMapping> LkUsermappingCreatedonbehalfby
		{
			get { return GetRelatedEntities<UserMapping>("lk_usermapping_createdonbehalfby", null); }
			set { SetRelatedEntities("lk_usermapping_createdonbehalfby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_usermapping_modifiedby'
        /// </summary>
		[RelationshipSchemaName("lk_usermapping_modifiedby")]
		public IEnumerable<UserMapping> LkUsermappingModifiedby
		{
			get { return GetRelatedEntities<UserMapping>("lk_usermapping_modifiedby", null); }
			set { SetRelatedEntities("lk_usermapping_modifiedby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_usermapping_modifiedonbehalfby'
        /// </summary>
		[RelationshipSchemaName("lk_usermapping_modifiedonbehalfby")]
		public IEnumerable<UserMapping> LkUsermappingModifiedonbehalfby
		{
			get { return GetRelatedEntities<UserMapping>("lk_usermapping_modifiedonbehalfby", null); }
			set { SetRelatedEntities("lk_usermapping_modifiedonbehalfby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_userquery_createdby'
        /// </summary>
		[RelationshipSchemaName("lk_userquery_createdby")]
		public IEnumerable<SavedView> LkUserqueryCreatedby
		{
			get { return GetRelatedEntities<SavedView>("lk_userquery_createdby", null); }
			set { SetRelatedEntities("lk_userquery_createdby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_userquery_createdonbehalfby'
        /// </summary>
		[RelationshipSchemaName("lk_userquery_createdonbehalfby")]
		public IEnumerable<SavedView> LkUserqueryCreatedonbehalfby
		{
			get { return GetRelatedEntities<SavedView>("lk_userquery_createdonbehalfby", null); }
			set { SetRelatedEntities("lk_userquery_createdonbehalfby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_userquery_modifiedby'
        /// </summary>
		[RelationshipSchemaName("lk_userquery_modifiedby")]
		public IEnumerable<SavedView> LkUserqueryModifiedby
		{
			get { return GetRelatedEntities<SavedView>("lk_userquery_modifiedby", null); }
			set { SetRelatedEntities("lk_userquery_modifiedby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_userquery_modifiedonbehalfby'
        /// </summary>
		[RelationshipSchemaName("lk_userquery_modifiedonbehalfby")]
		public IEnumerable<SavedView> LkUserqueryModifiedonbehalfby
		{
			get { return GetRelatedEntities<SavedView>("lk_userquery_modifiedonbehalfby", null); }
			set { SetRelatedEntities("lk_userquery_modifiedonbehalfby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_userqueryvisualization_createdby'
        /// </summary>
		[RelationshipSchemaName("lk_userqueryvisualization_createdby")]
		public IEnumerable<UserChart> LkUserqueryvisualizationCreatedby
		{
			get { return GetRelatedEntities<UserChart>("lk_userqueryvisualization_createdby", null); }
			set { SetRelatedEntities("lk_userqueryvisualization_createdby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_userqueryvisualization_modifiedby'
        /// </summary>
		[RelationshipSchemaName("lk_userqueryvisualization_modifiedby")]
		public IEnumerable<UserChart> LkUserqueryvisualizationModifiedby
		{
			get { return GetRelatedEntities<UserChart>("lk_userqueryvisualization_modifiedby", null); }
			set { SetRelatedEntities("lk_userqueryvisualization_modifiedby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_userqueryvisualizationbase_createdonbehalfby'
        /// </summary>
		[RelationshipSchemaName("lk_userqueryvisualizationbase_createdonbehalfby")]
		public IEnumerable<UserChart> LkUserqueryvisualizationbaseCreatedonbehalfby
		{
			get { return GetRelatedEntities<UserChart>("lk_userqueryvisualizationbase_createdonbehalfby", null); }
			set { SetRelatedEntities("lk_userqueryvisualizationbase_createdonbehalfby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_userqueryvisualizationbase_modifiedonbehalfby'
        /// </summary>
		[RelationshipSchemaName("lk_userqueryvisualizationbase_modifiedonbehalfby")]
		public IEnumerable<UserChart> LkUserqueryvisualizationbaseModifiedonbehalfby
		{
			get { return GetRelatedEntities<UserChart>("lk_userqueryvisualizationbase_modifiedonbehalfby", null); }
			set { SetRelatedEntities("lk_userqueryvisualizationbase_modifiedonbehalfby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_usersettings_createdonbehalfby'
        /// </summary>
		[RelationshipSchemaName("lk_usersettings_createdonbehalfby")]
		public IEnumerable<UserSettings> LkUsersettingsCreatedonbehalfby
		{
			get { return GetRelatedEntities<UserSettings>("lk_usersettings_createdonbehalfby", null); }
			set { SetRelatedEntities("lk_usersettings_createdonbehalfby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_usersettings_modifiedonbehalfby'
        /// </summary>
		[RelationshipSchemaName("lk_usersettings_modifiedonbehalfby")]
		public IEnumerable<UserSettings> LkUsersettingsModifiedonbehalfby
		{
			get { return GetRelatedEntities<UserSettings>("lk_usersettings_modifiedonbehalfby", null); }
			set { SetRelatedEntities("lk_usersettings_modifiedonbehalfby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_usersettingsbase_createdby'
        /// </summary>
		[RelationshipSchemaName("lk_usersettingsbase_createdby")]
		public IEnumerable<UserSettings> LkUsersettingsbaseCreatedby
		{
			get { return GetRelatedEntities<UserSettings>("lk_usersettingsbase_createdby", null); }
			set { SetRelatedEntities("lk_usersettingsbase_createdby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_usersettingsbase_modifiedby'
        /// </summary>
		[RelationshipSchemaName("lk_usersettingsbase_modifiedby")]
		public IEnumerable<UserSettings> LkUsersettingsbaseModifiedby
		{
			get { return GetRelatedEntities<UserSettings>("lk_usersettingsbase_modifiedby", null); }
			set { SetRelatedEntities("lk_usersettingsbase_modifiedby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_webresourcebase_createdonbehalfby'
        /// </summary>
		[RelationshipSchemaName("lk_webresourcebase_createdonbehalfby")]
		public IEnumerable<WebResource> LkWebresourcebaseCreatedonbehalfby
		{
			get { return GetRelatedEntities<WebResource>("lk_webresourcebase_createdonbehalfby", null); }
			set { SetRelatedEntities("lk_webresourcebase_createdonbehalfby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_webresourcebase_modifiedonbehalfby'
        /// </summary>
		[RelationshipSchemaName("lk_webresourcebase_modifiedonbehalfby")]
		public IEnumerable<WebResource> LkWebresourcebaseModifiedonbehalfby
		{
			get { return GetRelatedEntities<WebResource>("lk_webresourcebase_modifiedonbehalfby", null); }
			set { SetRelatedEntities("lk_webresourcebase_modifiedonbehalfby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_webwizard_createdby'
        /// </summary>
		[RelationshipSchemaName("lk_webwizard_createdby")]
		public IEnumerable<WebWizard> LkWebwizardCreatedby
		{
			get { return GetRelatedEntities<WebWizard>("lk_webwizard_createdby", null); }
			set { SetRelatedEntities("lk_webwizard_createdby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_webwizard_createdonbehalfby'
        /// </summary>
		[RelationshipSchemaName("lk_webwizard_createdonbehalfby")]
		public IEnumerable<WebWizard> LkWebwizardCreatedonbehalfby
		{
			get { return GetRelatedEntities<WebWizard>("lk_webwizard_createdonbehalfby", null); }
			set { SetRelatedEntities("lk_webwizard_createdonbehalfby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_webwizard_modifiedby'
        /// </summary>
		[RelationshipSchemaName("lk_webwizard_modifiedby")]
		public IEnumerable<WebWizard> LkWebwizardModifiedby
		{
			get { return GetRelatedEntities<WebWizard>("lk_webwizard_modifiedby", null); }
			set { SetRelatedEntities("lk_webwizard_modifiedby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_webwizard_modifiedonbehalfby'
        /// </summary>
		[RelationshipSchemaName("lk_webwizard_modifiedonbehalfby")]
		public IEnumerable<WebWizard> LkWebwizardModifiedonbehalfby
		{
			get { return GetRelatedEntities<WebWizard>("lk_webwizard_modifiedonbehalfby", null); }
			set { SetRelatedEntities("lk_webwizard_modifiedonbehalfby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_workflowbinary_createdby'
        /// </summary>
		[RelationshipSchemaName("lk_workflowbinary_createdby")]
		public IEnumerable<WorkflowBinary> LkWorkflowbinaryCreatedby
		{
			get { return GetRelatedEntities<WorkflowBinary>("lk_workflowbinary_createdby", null); }
			set { SetRelatedEntities("lk_workflowbinary_createdby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_workflowbinary_createdonbehalfby'
        /// </summary>
		[RelationshipSchemaName("lk_workflowbinary_createdonbehalfby")]
		public IEnumerable<WorkflowBinary> LkWorkflowbinaryCreatedonbehalfby
		{
			get { return GetRelatedEntities<WorkflowBinary>("lk_workflowbinary_createdonbehalfby", null); }
			set { SetRelatedEntities("lk_workflowbinary_createdonbehalfby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_workflowbinary_modifiedby'
        /// </summary>
		[RelationshipSchemaName("lk_workflowbinary_modifiedby")]
		public IEnumerable<WorkflowBinary> LkWorkflowbinaryModifiedby
		{
			get { return GetRelatedEntities<WorkflowBinary>("lk_workflowbinary_modifiedby", null); }
			set { SetRelatedEntities("lk_workflowbinary_modifiedby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_workflowbinary_modifiedonbehalfby'
        /// </summary>
		[RelationshipSchemaName("lk_workflowbinary_modifiedonbehalfby")]
		public IEnumerable<WorkflowBinary> LkWorkflowbinaryModifiedonbehalfby
		{
			get { return GetRelatedEntities<WorkflowBinary>("lk_workflowbinary_modifiedonbehalfby", null); }
			set { SetRelatedEntities("lk_workflowbinary_modifiedonbehalfby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_workflowlog_createdby'
        /// </summary>
		[RelationshipSchemaName("lk_workflowlog_createdby")]
		public IEnumerable<ProcessLog> LkWorkflowlogCreatedby
		{
			get { return GetRelatedEntities<ProcessLog>("lk_workflowlog_createdby", null); }
			set { SetRelatedEntities("lk_workflowlog_createdby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_workflowlog_createdonbehalfby'
        /// </summary>
		[RelationshipSchemaName("lk_workflowlog_createdonbehalfby")]
		public IEnumerable<ProcessLog> LkWorkflowlogCreatedonbehalfby
		{
			get { return GetRelatedEntities<ProcessLog>("lk_workflowlog_createdonbehalfby", null); }
			set { SetRelatedEntities("lk_workflowlog_createdonbehalfby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_workflowlog_modifiedby'
        /// </summary>
		[RelationshipSchemaName("lk_workflowlog_modifiedby")]
		public IEnumerable<ProcessLog> LkWorkflowlogModifiedby
		{
			get { return GetRelatedEntities<ProcessLog>("lk_workflowlog_modifiedby", null); }
			set { SetRelatedEntities("lk_workflowlog_modifiedby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_workflowlog_modifiedonbehalfby'
        /// </summary>
		[RelationshipSchemaName("lk_workflowlog_modifiedonbehalfby")]
		public IEnumerable<ProcessLog> LkWorkflowlogModifiedonbehalfby
		{
			get { return GetRelatedEntities<ProcessLog>("lk_workflowlog_modifiedonbehalfby", null); }
			set { SetRelatedEntities("lk_workflowlog_modifiedonbehalfby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'mailbox_regarding_systemuser'
        /// </summary>
		[RelationshipSchemaName("mailbox_regarding_systemuser")]
		public IEnumerable<Mailbox> MailboxRegardingSystemuser
		{
			get { return GetRelatedEntities<Mailbox>("mailbox_regarding_systemuser", null); }
			set { SetRelatedEntities("mailbox_regarding_systemuser", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'modifiedby_connection'
        /// </summary>
		[RelationshipSchemaName("modifiedby_connection")]
		public IEnumerable<Connection> ModifiedbyConnection
		{
			get { return GetRelatedEntities<Connection>("modifiedby_connection", null); }
			set { SetRelatedEntities("modifiedby_connection", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'modifiedby_connection_role'
        /// </summary>
		[RelationshipSchemaName("modifiedby_connection_role")]
		public IEnumerable<ConnectionRole> ModifiedbyConnectionRole
		{
			get { return GetRelatedEntities<ConnectionRole>("modifiedby_connection_role", null); }
			set { SetRelatedEntities("modifiedby_connection_role", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'modifiedby_pluginassembly'
        /// </summary>
		[RelationshipSchemaName("modifiedby_pluginassembly")]
		public IEnumerable<PluginAssembly> ModifiedbyPluginassembly
		{
			get { return GetRelatedEntities<PluginAssembly>("modifiedby_pluginassembly", null); }
			set { SetRelatedEntities("modifiedby_pluginassembly", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'modifiedby_plugintype'
        /// </summary>
		[RelationshipSchemaName("modifiedby_plugintype")]
		public IEnumerable<PluginType> ModifiedbyPlugintype
		{
			get { return GetRelatedEntities<PluginType>("modifiedby_plugintype", null); }
			set { SetRelatedEntities("modifiedby_plugintype", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'modifiedby_plugintypestatistic'
        /// </summary>
		[RelationshipSchemaName("modifiedby_plugintypestatistic")]
		public IEnumerable<PluginTypeStatistic> ModifiedbyPlugintypestatistic
		{
			get { return GetRelatedEntities<PluginTypeStatistic>("modifiedby_plugintypestatistic", null); }
			set { SetRelatedEntities("modifiedby_plugintypestatistic", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'modifiedby_sdkmessage'
        /// </summary>
		[RelationshipSchemaName("modifiedby_sdkmessage")]
		public IEnumerable<SdkMessage> ModifiedbySdkmessage
		{
			get { return GetRelatedEntities<SdkMessage>("modifiedby_sdkmessage", null); }
			set { SetRelatedEntities("modifiedby_sdkmessage", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'modifiedby_sdkmessagefilter'
        /// </summary>
		[RelationshipSchemaName("modifiedby_sdkmessagefilter")]
		public IEnumerable<SdkMessageFilter> ModifiedbySdkmessagefilter
		{
			get { return GetRelatedEntities<SdkMessageFilter>("modifiedby_sdkmessagefilter", null); }
			set { SetRelatedEntities("modifiedby_sdkmessagefilter", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'modifiedby_sdkmessageprocessingstep'
        /// </summary>
		[RelationshipSchemaName("modifiedby_sdkmessageprocessingstep")]
		public IEnumerable<SdkMessageProcessingStep> ModifiedbySdkmessageprocessingstep
		{
			get { return GetRelatedEntities<SdkMessageProcessingStep>("modifiedby_sdkmessageprocessingstep", null); }
			set { SetRelatedEntities("modifiedby_sdkmessageprocessingstep", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'modifiedby_sdkmessageprocessingstepimage'
        /// </summary>
		[RelationshipSchemaName("modifiedby_sdkmessageprocessingstepimage")]
		public IEnumerable<SdkMessageProcessingStepImage> ModifiedbySdkmessageprocessingstepimage
		{
			get { return GetRelatedEntities<SdkMessageProcessingStepImage>("modifiedby_sdkmessageprocessingstepimage", null); }
			set { SetRelatedEntities("modifiedby_sdkmessageprocessingstepimage", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'modifiedby_sdkmessageprocessingstepsecureconfig'
        /// </summary>
		[RelationshipSchemaName("modifiedby_sdkmessageprocessingstepsecureconfig")]
		public IEnumerable<SdkMessageProcessingStepSecureConfiguration> ModifiedbySdkmessageprocessingstepsecureconfig
		{
			get { return GetRelatedEntities<SdkMessageProcessingStepSecureConfiguration>("modifiedby_sdkmessageprocessingstepsecureconfig", null); }
			set { SetRelatedEntities("modifiedby_sdkmessageprocessingstepsecureconfig", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'modifiedby_serviceendpoint'
        /// </summary>
		[RelationshipSchemaName("modifiedby_serviceendpoint")]
		public IEnumerable<ServiceEndpoint> ModifiedbyServiceendpoint
		{
			get { return GetRelatedEntities<ServiceEndpoint>("modifiedby_serviceendpoint", null); }
			set { SetRelatedEntities("modifiedby_serviceendpoint", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'msdyn_systemuser_wallsavedqueryusersettings_userid'
        /// </summary>
		[RelationshipSchemaName("msdyn_systemuser_wallsavedqueryusersettings_userid")]
		public IEnumerable<Filter> MsdynSystemuserWallsavedqueryusersettingsUserid
		{
			get { return GetRelatedEntities<Filter>("msdyn_systemuser_wallsavedqueryusersettings_userid", null); }
			set { SetRelatedEntities("msdyn_systemuser_wallsavedqueryusersettings_userid", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'opportunity_owning_user'
        /// </summary>
		[RelationshipSchemaName("opportunity_owning_user")]
		public IEnumerable<Opportunity> OpportunityOwningUser
		{
			get { return GetRelatedEntities<Opportunity>("opportunity_owning_user", null); }
			set { SetRelatedEntities("opportunity_owning_user", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'OwnerMapping_SystemUser'
        /// </summary>
		[RelationshipSchemaName("OwnerMapping_SystemUser")]
		public IEnumerable<OwnerMapping> OwnerMappingSystemUser
		{
			get { return GetRelatedEntities<OwnerMapping>("OwnerMapping_SystemUser", null); }
			set { SetRelatedEntities("OwnerMapping_SystemUser", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'OwningUser_Dynamicpropertyinsatance'
        /// </summary>
		[RelationshipSchemaName("OwningUser_Dynamicpropertyinsatance")]
		public IEnumerable<PropertyInstance> OwningUserDynamicpropertyinsatance
		{
			get { return GetRelatedEntities<PropertyInstance>("OwningUser_Dynamicpropertyinsatance", null); }
			set { SetRelatedEntities("OwningUser_Dynamicpropertyinsatance", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'queue_primary_user'
        /// </summary>
		[RelationshipSchemaName("queue_primary_user")]
		public IEnumerable<Queue> QueuePrimaryUser
		{
			get { return GetRelatedEntities<Queue>("queue_primary_user", null); }
			set { SetRelatedEntities("queue_primary_user", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'socialProfile_owning_user'
        /// </summary>
		[RelationshipSchemaName("socialProfile_owning_user")]
		public IEnumerable<SocialProfile> SocialProfileOwningUser
		{
			get { return GetRelatedEntities<SocialProfile>("socialProfile_owning_user", null); }
			set { SetRelatedEntities("socialProfile_owning_user", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'system_user_accounts'
        /// </summary>
		[RelationshipSchemaName("system_user_accounts")]
		public IEnumerable<Account> SystemUserAccounts
		{
			get { return GetRelatedEntities<Account>("system_user_accounts", null); }
			set { SetRelatedEntities("system_user_accounts", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'system_user_activity_parties'
        /// </summary>
		[RelationshipSchemaName("system_user_activity_parties")]
		public IEnumerable<ActivityParty> SystemUserActivityParties
		{
			get { return GetRelatedEntities<ActivityParty>("system_user_activity_parties", null); }
			set { SetRelatedEntities("system_user_activity_parties", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'system_user_asyncoperation'
        /// </summary>
		[RelationshipSchemaName("system_user_asyncoperation")]
		public IEnumerable<SystemJob> SystemUserAsyncoperation
		{
			get { return GetRelatedEntities<SystemJob>("system_user_asyncoperation", null); }
			set { SetRelatedEntities("system_user_asyncoperation", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'system_user_contacts'
        /// </summary>
		[RelationshipSchemaName("system_user_contacts")]
		public IEnumerable<Contact> SystemUserContacts
		{
			get { return GetRelatedEntities<Contact>("system_user_contacts", null); }
			set { SetRelatedEntities("system_user_contacts", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'system_user_email_templates'
        /// </summary>
		[RelationshipSchemaName("system_user_email_templates")]
		public IEnumerable<EmailTemplate> SystemUserEmailTemplates
		{
			get { return GetRelatedEntities<EmailTemplate>("system_user_email_templates", null); }
			set { SetRelatedEntities("system_user_email_templates", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'system_user_incidents'
        /// </summary>
		[RelationshipSchemaName("system_user_incidents")]
		public IEnumerable<Case> SystemUserIncidents
		{
			get { return GetRelatedEntities<Case>("system_user_incidents", null); }
			set { SetRelatedEntities("system_user_incidents", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'system_user_invoicedetail'
        /// </summary>
		[RelationshipSchemaName("system_user_invoicedetail")]
		public IEnumerable<InvoiceProduct> SystemUserInvoicedetail
		{
			get { return GetRelatedEntities<InvoiceProduct>("system_user_invoicedetail", null); }
			set { SetRelatedEntities("system_user_invoicedetail", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'system_user_invoices'
        /// </summary>
		[RelationshipSchemaName("system_user_invoices")]
		public IEnumerable<Invoice> SystemUserInvoices
		{
			get { return GetRelatedEntities<Invoice>("system_user_invoices", null); }
			set { SetRelatedEntities("system_user_invoices", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'system_user_orders'
        /// </summary>
		[RelationshipSchemaName("system_user_orders")]
		public IEnumerable<Order> SystemUserOrders
		{
			get { return GetRelatedEntities<Order>("system_user_orders", null); }
			set { SetRelatedEntities("system_user_orders", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'system_user_quotedetail'
        /// </summary>
		[RelationshipSchemaName("system_user_quotedetail")]
		public IEnumerable<QuoteProduct> SystemUserQuotedetail
		{
			get { return GetRelatedEntities<QuoteProduct>("system_user_quotedetail", null); }
			set { SetRelatedEntities("system_user_quotedetail", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'system_user_quotes'
        /// </summary>
		[RelationshipSchemaName("system_user_quotes")]
		public IEnumerable<Quote> SystemUserQuotes
		{
			get { return GetRelatedEntities<Quote>("system_user_quotes", null); }
			set { SetRelatedEntities("system_user_quotes", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'system_user_sales_literature'
        /// </summary>
		[RelationshipSchemaName("system_user_sales_literature")]
		public IEnumerable<SalesLiterature> SystemUserSalesLiterature
		{
			get { return GetRelatedEntities<SalesLiterature>("system_user_sales_literature", null); }
			set { SetRelatedEntities("system_user_sales_literature", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'system_user_salesorderdetail'
        /// </summary>
		[RelationshipSchemaName("system_user_salesorderdetail")]
		public IEnumerable<OrderProduct> SystemUserSalesorderdetail
		{
			get { return GetRelatedEntities<OrderProduct>("system_user_salesorderdetail", null); }
			set { SetRelatedEntities("system_user_salesorderdetail", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'system_user_service_appointments'
        /// </summary>
		[RelationshipSchemaName("system_user_service_appointments")]
		public IEnumerable<ServiceActivity> SystemUserServiceAppointments
		{
			get { return GetRelatedEntities<ServiceActivity>("system_user_service_appointments", null); }
			set { SetRelatedEntities("system_user_service_appointments", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'system_user_service_contracts'
        /// </summary>
		[RelationshipSchemaName("system_user_service_contracts")]
		public IEnumerable<Contract> SystemUserServiceContracts
		{
			get { return GetRelatedEntities<Contract>("system_user_service_contracts", null); }
			set { SetRelatedEntities("system_user_service_contracts", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'system_user_territories'
        /// </summary>
		[RelationshipSchemaName("system_user_territories")]
		public IEnumerable<Territory> SystemUserTerritories
		{
			get { return GetRelatedEntities<Territory>("system_user_territories", null); }
			set { SetRelatedEntities("system_user_territories", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'system_user_workflow'
        /// </summary>
		[RelationshipSchemaName("system_user_workflow")]
		public IEnumerable<Process> SystemUserWorkflow
		{
			get { return GetRelatedEntities<Process>("system_user_workflow", null); }
			set { SetRelatedEntities("system_user_workflow", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'SystemUser_AsyncOperations'
        /// </summary>
		[RelationshipSchemaName("SystemUser_AsyncOperations")]
		public IEnumerable<SystemJob> SystemUserAsyncOperations
		{
			get { return GetRelatedEntities<SystemJob>("SystemUser_AsyncOperations", null); }
			set { SetRelatedEntities("SystemUser_AsyncOperations", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'systemuser_bookableresource_UserId'
        /// </summary>
		[RelationshipSchemaName("systemuser_bookableresource_UserId")]
		public IEnumerable<BookableResource> SystemuserBookableresourceUserId
		{
			get { return GetRelatedEntities<BookableResource>("systemuser_bookableresource_UserId", null); }
			set { SetRelatedEntities("systemuser_bookableresource_UserId", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'systemuser_bot_publishedby'
        /// </summary>
		[RelationshipSchemaName("systemuser_bot_publishedby")]
		public IEnumerable<Chatbot> SystemuserBotPublishedby
		{
			get { return GetRelatedEntities<Chatbot>("systemuser_bot_publishedby", null); }
			set { SetRelatedEntities("systemuser_bot_publishedby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'SystemUser_BulkDeleteFailures'
        /// </summary>
		[RelationshipSchemaName("SystemUser_BulkDeleteFailures")]
		public IEnumerable<BulkDeleteFailure> SystemUserBulkDeleteFailures
		{
			get { return GetRelatedEntities<BulkDeleteFailure>("SystemUser_BulkDeleteFailures", null); }
			set { SetRelatedEntities("SystemUser_BulkDeleteFailures", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'SystemUser_Campaigns'
        /// </summary>
		[RelationshipSchemaName("SystemUser_Campaigns")]
		public IEnumerable<Campaign> SystemUserCampaigns
		{
			get { return GetRelatedEntities<Campaign>("SystemUser_Campaigns", null); }
			set { SetRelatedEntities("SystemUser_Campaigns", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'systemuser_connections1'
        /// </summary>
		[RelationshipSchemaName("systemuser_connections1")]
		public IEnumerable<Connection> SystemuserConnections1
		{
			get { return GetRelatedEntities<Connection>("systemuser_connections1", null); }
			set { SetRelatedEntities("systemuser_connections1", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'systemuser_connections2'
        /// </summary>
		[RelationshipSchemaName("systemuser_connections2")]
		public IEnumerable<Connection> SystemuserConnections2
		{
			get { return GetRelatedEntities<Connection>("systemuser_connections2", null); }
			set { SetRelatedEntities("systemuser_connections2", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'SystemUser_DuplicateBaseRecord'
        /// </summary>
		[RelationshipSchemaName("SystemUser_DuplicateBaseRecord")]
		public IEnumerable<DuplicateRecord> SystemUserDuplicateBaseRecord
		{
			get { return GetRelatedEntities<DuplicateRecord>("SystemUser_DuplicateBaseRecord", null); }
			set { SetRelatedEntities("SystemUser_DuplicateBaseRecord", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'SystemUser_DuplicateMatchingRecord'
        /// </summary>
		[RelationshipSchemaName("SystemUser_DuplicateMatchingRecord")]
		public IEnumerable<DuplicateRecord> SystemUserDuplicateMatchingRecord
		{
			get { return GetRelatedEntities<DuplicateRecord>("SystemUser_DuplicateMatchingRecord", null); }
			set { SetRelatedEntities("SystemUser_DuplicateMatchingRecord", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'SystemUser_DuplicateRules'
        /// </summary>
		[RelationshipSchemaName("SystemUser_DuplicateRules")]
		public IEnumerable<DuplicateDetectionRule> SystemUserDuplicateRules
		{
			get { return GetRelatedEntities<DuplicateDetectionRule>("SystemUser_DuplicateRules", null); }
			set { SetRelatedEntities("SystemUser_DuplicateRules", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'SystemUser_Email_EmailSender'
        /// </summary>
		[RelationshipSchemaName("SystemUser_Email_EmailSender")]
		public IEnumerable<Email> SystemUserEmailEmailSender
		{
			get { return GetRelatedEntities<Email>("SystemUser_Email_EmailSender", null); }
			set { SetRelatedEntities("SystemUser_Email_EmailSender", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'SystemUser_ImportData'
        /// </summary>
		[RelationshipSchemaName("SystemUser_ImportData")]
		public IEnumerable<ImportData> SystemUserImportData
		{
			get { return GetRelatedEntities<ImportData>("SystemUser_ImportData", null); }
			set { SetRelatedEntities("SystemUser_ImportData", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'SystemUser_ImportFiles'
        /// </summary>
		[RelationshipSchemaName("SystemUser_ImportFiles")]
		public IEnumerable<ImportSourceFile> SystemUserImportFiles
		{
			get { return GetRelatedEntities<ImportSourceFile>("SystemUser_ImportFiles", null); }
			set { SetRelatedEntities("SystemUser_ImportFiles", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'SystemUser_ImportLogs'
        /// </summary>
		[RelationshipSchemaName("SystemUser_ImportLogs")]
		public IEnumerable<ImportLog> SystemUserImportLogs
		{
			get { return GetRelatedEntities<ImportLog>("SystemUser_ImportLogs", null); }
			set { SetRelatedEntities("SystemUser_ImportLogs", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'SystemUser_ImportMaps'
        /// </summary>
		[RelationshipSchemaName("SystemUser_ImportMaps")]
		public IEnumerable<DataMap> SystemUserImportMaps
		{
			get { return GetRelatedEntities<DataMap>("SystemUser_ImportMaps", null); }
			set { SetRelatedEntities("SystemUser_ImportMaps", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'SystemUser_Imports'
        /// </summary>
		[RelationshipSchemaName("SystemUser_Imports")]
		public IEnumerable<DataImport> SystemUserImports
		{
			get { return GetRelatedEntities<DataImport>("SystemUser_Imports", null); }
			set { SetRelatedEntities("SystemUser_Imports", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'systemuser_PostFollows'
        /// </summary>
		[RelationshipSchemaName("systemuser_PostFollows")]
		public IEnumerable<Follow> SystemuserPostFollows
		{
			get { return GetRelatedEntities<Follow>("systemuser_PostFollows", null); }
			set { SetRelatedEntities("systemuser_PostFollows", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'systemuser_principalobjectattributeaccess'
        /// </summary>
		[RelationshipSchemaName("systemuser_principalobjectattributeaccess")]
		public IEnumerable<FieldSharing> SystemuserPrincipalobjectattributeaccess
		{
			get { return GetRelatedEntities<FieldSharing>("systemuser_principalobjectattributeaccess", null); }
			set { SetRelatedEntities("systemuser_principalobjectattributeaccess", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'systemuser_principalobjectattributeaccess_principalid'
        /// </summary>
		[RelationshipSchemaName("systemuser_principalobjectattributeaccess_principalid")]
		public IEnumerable<FieldSharing> SystemuserPrincipalobjectattributeaccessPrincipalid
		{
			get { return GetRelatedEntities<FieldSharing>("systemuser_principalobjectattributeaccess_principalid", null); }
			set { SetRelatedEntities("systemuser_principalobjectattributeaccess_principalid", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'SystemUser_ProcessSessions'
        /// </summary>
		[RelationshipSchemaName("SystemUser_ProcessSessions")]
		public IEnumerable<ProcessSession> SystemUserProcessSessions
		{
			get { return GetRelatedEntities<ProcessSession>("SystemUser_ProcessSessions", null); }
			set { SetRelatedEntities("SystemUser_ProcessSessions", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'systemuser_resources'
        /// </summary>
		[RelationshipSchemaName("systemuser_resources")]
		public IEnumerable<Resource> SystemuserResources
		{
			get { return GetRelatedEntities<Resource>("systemuser_resources", null); }
			set { SetRelatedEntities("systemuser_resources", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'SystemUser_SyncError'
        /// </summary>
		[RelationshipSchemaName("SystemUser_SyncError")]
		public IEnumerable<SyncError> SystemUserSyncError
		{
			get { return GetRelatedEntities<SyncError>("SystemUser_SyncError", null); }
			set { SetRelatedEntities("SystemUser_SyncError", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'SystemUser_SyncErrors'
        /// </summary>
		[RelationshipSchemaName("SystemUser_SyncErrors")]
		public IEnumerable<SyncError> SystemUserSyncErrors
		{
			get { return GetRelatedEntities<SyncError>("SystemUser_SyncErrors", null); }
			set { SetRelatedEntities("SystemUser_SyncErrors", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'user_accounts'
        /// </summary>
		[RelationshipSchemaName("user_accounts")]
		public IEnumerable<Account> UserAccounts
		{
			get { return GetRelatedEntities<Account>("user_accounts", null); }
			set { SetRelatedEntities("user_accounts", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'user_activity'
        /// </summary>
		[RelationshipSchemaName("user_activity")]
		public IEnumerable<Activity> UserActivity
		{
			get { return GetRelatedEntities<Activity>("user_activity", null); }
			set { SetRelatedEntities("user_activity", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'user_activitymonitor'
        /// </summary>
		[RelationshipSchemaName("user_activitymonitor")]
		public IEnumerable<ActivityMonitor> UserActivitymonitor
		{
			get { return GetRelatedEntities<ActivityMonitor>("user_activitymonitor", null); }
			set { SetRelatedEntities("user_activitymonitor", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'user_adminsettingsentity'
        /// </summary>
		[RelationshipSchemaName("user_adminsettingsentity")]
		public IEnumerable<AdminSettingsEntity> UserAdminsettingsentity
		{
			get { return GetRelatedEntities<AdminSettingsEntity>("user_adminsettingsentity", null); }
			set { SetRelatedEntities("user_adminsettingsentity", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'user_appointment'
        /// </summary>
		[RelationshipSchemaName("user_appointment")]
		public IEnumerable<Appointment> UserAppointment
		{
			get { return GetRelatedEntities<Appointment>("user_appointment", null); }
			set { SetRelatedEntities("user_appointment", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'user_bookableresource'
        /// </summary>
		[RelationshipSchemaName("user_bookableresource")]
		public IEnumerable<BookableResource> UserBookableresource
		{
			get { return GetRelatedEntities<BookableResource>("user_bookableresource", null); }
			set { SetRelatedEntities("user_bookableresource", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'user_bookableresourcebooking'
        /// </summary>
		[RelationshipSchemaName("user_bookableresourcebooking")]
		public IEnumerable<BookableResourceBooking> UserBookableresourcebooking
		{
			get { return GetRelatedEntities<BookableResourceBooking>("user_bookableresourcebooking", null); }
			set { SetRelatedEntities("user_bookableresourcebooking", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'user_bookableresourcebookingheader'
        /// </summary>
		[RelationshipSchemaName("user_bookableresourcebookingheader")]
		public IEnumerable<BookableResourceBookingHeader> UserBookableresourcebookingheader
		{
			get { return GetRelatedEntities<BookableResourceBookingHeader>("user_bookableresourcebookingheader", null); }
			set { SetRelatedEntities("user_bookableresourcebookingheader", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'user_bookableresourcecategory'
        /// </summary>
		[RelationshipSchemaName("user_bookableresourcecategory")]
		public IEnumerable<BookableResourceCategory> UserBookableresourcecategory
		{
			get { return GetRelatedEntities<BookableResourceCategory>("user_bookableresourcecategory", null); }
			set { SetRelatedEntities("user_bookableresourcecategory", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'user_bookableresourcecategoryassn'
        /// </summary>
		[RelationshipSchemaName("user_bookableresourcecategoryassn")]
		public IEnumerable<BookableResourceCategoryAssn> UserBookableresourcecategoryassn
		{
			get { return GetRelatedEntities<BookableResourceCategoryAssn>("user_bookableresourcecategoryassn", null); }
			set { SetRelatedEntities("user_bookableresourcecategoryassn", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'user_bookableresourcecharacteristic'
        /// </summary>
		[RelationshipSchemaName("user_bookableresourcecharacteristic")]
		public IEnumerable<BookableResourceCharacteristic> UserBookableresourcecharacteristic
		{
			get { return GetRelatedEntities<BookableResourceCharacteristic>("user_bookableresourcecharacteristic", null); }
			set { SetRelatedEntities("user_bookableresourcecharacteristic", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'user_bookableresourcegroup'
        /// </summary>
		[RelationshipSchemaName("user_bookableresourcegroup")]
		public IEnumerable<BookableResourceGroup> UserBookableresourcegroup
		{
			get { return GetRelatedEntities<BookableResourceGroup>("user_bookableresourcegroup", null); }
			set { SetRelatedEntities("user_bookableresourcegroup", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'user_bookingstatus'
        /// </summary>
		[RelationshipSchemaName("user_bookingstatus")]
		public IEnumerable<BookingStatus> UserBookingstatus
		{
			get { return GetRelatedEntities<BookingStatus>("user_bookingstatus", null); }
			set { SetRelatedEntities("user_bookingstatus", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'user_bot'
        /// </summary>
		[RelationshipSchemaName("user_bot")]
		public IEnumerable<Chatbot> UserBot
		{
			get { return GetRelatedEntities<Chatbot>("user_bot", null); }
			set { SetRelatedEntities("user_bot", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'user_botcomponent'
        /// </summary>
		[RelationshipSchemaName("user_botcomponent")]
		public IEnumerable<ChatbotSubcomponent> UserBotcomponent
		{
			get { return GetRelatedEntities<ChatbotSubcomponent>("user_botcomponent", null); }
			set { SetRelatedEntities("user_botcomponent", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'user_BulkOperation'
        /// </summary>
		[RelationshipSchemaName("user_BulkOperation")]
		public IEnumerable<QuickCampaign> UserBulkOperation
		{
			get { return GetRelatedEntities<QuickCampaign>("user_BulkOperation", null); }
			set { SetRelatedEntities("user_BulkOperation", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'user_campaignactivity'
        /// </summary>
		[RelationshipSchemaName("user_campaignactivity")]
		public IEnumerable<CampaignActivity> UserCampaignactivity
		{
			get { return GetRelatedEntities<CampaignActivity>("user_campaignactivity", null); }
			set { SetRelatedEntities("user_campaignactivity", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'user_campaignresponse'
        /// </summary>
		[RelationshipSchemaName("user_campaignresponse")]
		public IEnumerable<CampaignResponse> UserCampaignresponse
		{
			get { return GetRelatedEntities<CampaignResponse>("user_campaignresponse", null); }
			set { SetRelatedEntities("user_campaignresponse", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'user_characteristic'
        /// </summary>
		[RelationshipSchemaName("user_characteristic")]
		public IEnumerable<Characteristic> UserCharacteristic
		{
			get { return GetRelatedEntities<Characteristic>("user_characteristic", null); }
			set { SetRelatedEntities("user_characteristic", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'user_connectionreference'
        /// </summary>
		[RelationshipSchemaName("user_connectionreference")]
		public IEnumerable<ConnectionReference> UserConnectionreference
		{
			get { return GetRelatedEntities<ConnectionReference>("user_connectionreference", null); }
			set { SetRelatedEntities("user_connectionreference", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'user_connector'
        /// </summary>
		[RelationshipSchemaName("user_connector")]
		public IEnumerable<Connector> UserConnector
		{
			get { return GetRelatedEntities<Connector>("user_connector", null); }
			set { SetRelatedEntities("user_connector", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'user_contractdetail'
        /// </summary>
		[RelationshipSchemaName("user_contractdetail")]
		public IEnumerable<ContractLine> UserContractdetail
		{
			get { return GetRelatedEntities<ContractLine>("user_contractdetail", null); }
			set { SetRelatedEntities("user_contractdetail", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'user_conversationtranscript'
        /// </summary>
		[RelationshipSchemaName("user_conversationtranscript")]
		public IEnumerable<ConversationTranscript> UserConversationtranscript
		{
			get { return GetRelatedEntities<ConversationTranscript>("user_conversationtranscript", null); }
			set { SetRelatedEntities("user_conversationtranscript", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'user_customapi'
        /// </summary>
		[RelationshipSchemaName("user_customapi")]
		public IEnumerable<CustomAPI> UserCustomapi
		{
			get { return GetRelatedEntities<CustomAPI>("user_customapi", null); }
			set { SetRelatedEntities("user_customapi", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'user_customapirequestparameter'
        /// </summary>
		[RelationshipSchemaName("user_customapirequestparameter")]
		public IEnumerable<CustomAPIRequestParameter> UserCustomapirequestparameter
		{
			get { return GetRelatedEntities<CustomAPIRequestParameter>("user_customapirequestparameter", null); }
			set { SetRelatedEntities("user_customapirequestparameter", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'user_customapiresponseproperty'
        /// </summary>
		[RelationshipSchemaName("user_customapiresponseproperty")]
		public IEnumerable<CustomAPIResponseProperty> UserCustomapiresponseproperty
		{
			get { return GetRelatedEntities<CustomAPIResponseProperty>("user_customapiresponseproperty", null); }
			set { SetRelatedEntities("user_customapiresponseproperty", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'user_datalakefolder'
        /// </summary>
		[RelationshipSchemaName("user_datalakefolder")]
		public IEnumerable<DataLakeFolder> UserDatalakefolder
		{
			get { return GetRelatedEntities<DataLakeFolder>("user_datalakefolder", null); }
			set { SetRelatedEntities("user_datalakefolder", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'user_datalakefolderpermission'
        /// </summary>
		[RelationshipSchemaName("user_datalakefolderpermission")]
		public IEnumerable<DataLakeFolderPermission> UserDatalakefolderpermission
		{
			get { return GetRelatedEntities<DataLakeFolderPermission>("user_datalakefolderpermission", null); }
			set { SetRelatedEntities("user_datalakefolderpermission", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'user_email'
        /// </summary>
		[RelationshipSchemaName("user_email")]
		public IEnumerable<Email> UserEmail
		{
			get { return GetRelatedEntities<Email>("user_email", null); }
			set { SetRelatedEntities("user_email", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'user_entitlement'
        /// </summary>
		[RelationshipSchemaName("user_entitlement")]
		public IEnumerable<Entitlement> UserEntitlement
		{
			get { return GetRelatedEntities<Entitlement>("user_entitlement", null); }
			set { SetRelatedEntities("user_entitlement", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'user_entitlementchannel'
        /// </summary>
		[RelationshipSchemaName("user_entitlementchannel")]
		public IEnumerable<EntitlementChannel> UserEntitlementchannel
		{
			get { return GetRelatedEntities<EntitlementChannel>("user_entitlementchannel", null); }
			set { SetRelatedEntities("user_entitlementchannel", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'user_entitlemententityallocationtypemapping'
        /// </summary>
		[RelationshipSchemaName("user_entitlemententityallocationtypemapping")]
		public IEnumerable<EntitlementEntityAllocationTypeMapping> UserEntitlemententityallocationtypemapping
		{
			get { return GetRelatedEntities<EntitlementEntityAllocationTypeMapping>("user_entitlemententityallocationtypemapping", null); }
			set { SetRelatedEntities("user_entitlemententityallocationtypemapping", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'user_environmentvariabledefinition'
        /// </summary>
		[RelationshipSchemaName("user_environmentvariabledefinition")]
		public IEnumerable<EnvironmentVariableDefinition> UserEnvironmentvariabledefinition
		{
			get { return GetRelatedEntities<EnvironmentVariableDefinition>("user_environmentvariabledefinition", null); }
			set { SetRelatedEntities("user_environmentvariabledefinition", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'user_environmentvariablevalue'
        /// </summary>
		[RelationshipSchemaName("user_environmentvariablevalue")]
		public IEnumerable<EnvironmentVariableValue> UserEnvironmentvariablevalue
		{
			get { return GetRelatedEntities<EnvironmentVariableValue>("user_environmentvariablevalue", null); }
			set { SetRelatedEntities("user_environmentvariablevalue", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'user_exchangesyncidmapping'
        /// </summary>
		[RelationshipSchemaName("user_exchangesyncidmapping")]
		public IEnumerable<ExchangeSyncIdMapping> UserExchangesyncidmapping
		{
			get { return GetRelatedEntities<ExchangeSyncIdMapping>("user_exchangesyncidmapping", null); }
			set { SetRelatedEntities("user_exchangesyncidmapping", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'user_exportsolutionupload'
        /// </summary>
		[RelationshipSchemaName("user_exportsolutionupload")]
		public IEnumerable<ExportSolutionUpload> UserExportsolutionupload
		{
			get { return GetRelatedEntities<ExportSolutionUpload>("user_exportsolutionupload", null); }
			set { SetRelatedEntities("user_exportsolutionupload", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'user_fax'
        /// </summary>
		[RelationshipSchemaName("user_fax")]
		public IEnumerable<Fax> UserFax
		{
			get { return GetRelatedEntities<Fax>("user_fax", null); }
			set { SetRelatedEntities("user_fax", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'user_flowsession'
        /// </summary>
		[RelationshipSchemaName("user_flowsession")]
		public IEnumerable<FlowSession> UserFlowsession
		{
			get { return GetRelatedEntities<FlowSession>("user_flowsession", null); }
			set { SetRelatedEntities("user_flowsession", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'user_goal'
        /// </summary>
		[RelationshipSchemaName("user_goal")]
		public IEnumerable<Goal> UserGoal
		{
			get { return GetRelatedEntities<Goal>("user_goal", null); }
			set { SetRelatedEntities("user_goal", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'user_goal_goalowner'
        /// </summary>
		[RelationshipSchemaName("user_goal_goalowner")]
		public IEnumerable<Goal> UserGoalGoalowner
		{
			get { return GetRelatedEntities<Goal>("user_goal_goalowner", null); }
			set { SetRelatedEntities("user_goal_goalowner", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'user_incidentresolution'
        /// </summary>
		[RelationshipSchemaName("user_incidentresolution")]
		public IEnumerable<CaseResolution> UserIncidentresolution
		{
			get { return GetRelatedEntities<CaseResolution>("user_incidentresolution", null); }
			set { SetRelatedEntities("user_incidentresolution", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'user_interactionforemail'
        /// </summary>
		[RelationshipSchemaName("user_interactionforemail")]
		public IEnumerable<InteractionForEmail> UserInteractionforemail
		{
			get { return GetRelatedEntities<InteractionForEmail>("user_interactionforemail", null); }
			set { SetRelatedEntities("user_interactionforemail", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'user_invoicedetail'
        /// </summary>
		[RelationshipSchemaName("user_invoicedetail")]
		public IEnumerable<InvoiceProduct> UserInvoicedetail
		{
			get { return GetRelatedEntities<InvoiceProduct>("user_invoicedetail", null); }
			set { SetRelatedEntities("user_invoicedetail", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'user_knowledgearticle'
        /// </summary>
		[RelationshipSchemaName("user_knowledgearticle")]
		public IEnumerable<KnowledgeArticle> UserKnowledgearticle
		{
			get { return GetRelatedEntities<KnowledgeArticle>("user_knowledgearticle", null); }
			set { SetRelatedEntities("user_knowledgearticle", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'user_knowledgearticleincident'
        /// </summary>
		[RelationshipSchemaName("user_knowledgearticleincident")]
		public IEnumerable<KnowledgeArticleIncident> UserKnowledgearticleincident
		{
			get { return GetRelatedEntities<KnowledgeArticleIncident>("user_knowledgearticleincident", null); }
			set { SetRelatedEntities("user_knowledgearticleincident", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'user_letter'
        /// </summary>
		[RelationshipSchemaName("user_letter")]
		public IEnumerable<Letter> UserLetter
		{
			get { return GetRelatedEntities<Letter>("user_letter", null); }
			set { SetRelatedEntities("user_letter", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'user_list'
        /// </summary>
		[RelationshipSchemaName("user_list")]
		public IEnumerable<MarketingList> UserList
		{
			get { return GetRelatedEntities<MarketingList>("user_list", null); }
			set { SetRelatedEntities("user_list", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'user_listoperation'
        /// </summary>
		[RelationshipSchemaName("user_listoperation")]
		public IEnumerable<ListOperation> UserListoperation
		{
			get { return GetRelatedEntities<ListOperation>("user_listoperation", null); }
			set { SetRelatedEntities("user_listoperation", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'user_mailbox'
        /// </summary>
		[RelationshipSchemaName("user_mailbox")]
		public IEnumerable<Mailbox> UserMailbox
		{
			get { return GetRelatedEntities<Mailbox>("user_mailbox", null); }
			set { SetRelatedEntities("user_mailbox", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'user_msdyn_actioncardregarding'
        /// </summary>
		[RelationshipSchemaName("user_msdyn_actioncardregarding")]
		public IEnumerable<ActionCardRegarding> UserMsdynActioncardregarding
		{
			get { return GetRelatedEntities<ActionCardRegarding>("user_msdyn_actioncardregarding", null); }
			set { SetRelatedEntities("user_msdyn_actioncardregarding", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'user_msdyn_actioncardrolesetting'
        /// </summary>
		[RelationshipSchemaName("user_msdyn_actioncardrolesetting")]
		public IEnumerable<ActionCardRoleSetting> UserMsdynActioncardrolesetting
		{
			get { return GetRelatedEntities<ActionCardRoleSetting>("user_msdyn_actioncardrolesetting", null); }
			set { SetRelatedEntities("user_msdyn_actioncardrolesetting", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'user_msdyn_aibdataset'
        /// </summary>
		[RelationshipSchemaName("user_msdyn_aibdataset")]
		public IEnumerable<AIBuilderDataset> UserMsdynAibdataset
		{
			get { return GetRelatedEntities<AIBuilderDataset>("user_msdyn_aibdataset", null); }
			set { SetRelatedEntities("user_msdyn_aibdataset", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'user_msdyn_aibdatasetfile'
        /// </summary>
		[RelationshipSchemaName("user_msdyn_aibdatasetfile")]
		public IEnumerable<AIBuilderDatasetFile> UserMsdynAibdatasetfile
		{
			get { return GetRelatedEntities<AIBuilderDatasetFile>("user_msdyn_aibdatasetfile", null); }
			set { SetRelatedEntities("user_msdyn_aibdatasetfile", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'user_msdyn_aibdatasetrecord'
        /// </summary>
		[RelationshipSchemaName("user_msdyn_aibdatasetrecord")]
		public IEnumerable<AIBuilderDatasetRecord> UserMsdynAibdatasetrecord
		{
			get { return GetRelatedEntities<AIBuilderDatasetRecord>("user_msdyn_aibdatasetrecord", null); }
			set { SetRelatedEntities("user_msdyn_aibdatasetrecord", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'user_msdyn_aibdatasetscontainer'
        /// </summary>
		[RelationshipSchemaName("user_msdyn_aibdatasetscontainer")]
		public IEnumerable<AIBuilderDatasetsContainer> UserMsdynAibdatasetscontainer
		{
			get { return GetRelatedEntities<AIBuilderDatasetsContainer>("user_msdyn_aibdatasetscontainer", null); }
			set { SetRelatedEntities("user_msdyn_aibdatasetscontainer", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'user_msdyn_aibfile'
        /// </summary>
		[RelationshipSchemaName("user_msdyn_aibfile")]
		public IEnumerable<AIBuilderFile> UserMsdynAibfile
		{
			get { return GetRelatedEntities<AIBuilderFile>("user_msdyn_aibfile", null); }
			set { SetRelatedEntities("user_msdyn_aibfile", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'user_msdyn_aibfileattacheddata'
        /// </summary>
		[RelationshipSchemaName("user_msdyn_aibfileattacheddata")]
		public IEnumerable<AIBuilderFileAttachedData> UserMsdynAibfileattacheddata
		{
			get { return GetRelatedEntities<AIBuilderFileAttachedData>("user_msdyn_aibfileattacheddata", null); }
			set { SetRelatedEntities("user_msdyn_aibfileattacheddata", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'user_msdyn_aiconfiguration'
        /// </summary>
		[RelationshipSchemaName("user_msdyn_aiconfiguration")]
		public IEnumerable<AIConfiguration> UserMsdynAiconfiguration
		{
			get { return GetRelatedEntities<AIConfiguration>("user_msdyn_aiconfiguration", null); }
			set { SetRelatedEntities("user_msdyn_aiconfiguration", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'user_msdyn_aifptrainingdocument'
        /// </summary>
		[RelationshipSchemaName("user_msdyn_aifptrainingdocument")]
		public IEnumerable<AIFormProcessingDocument> UserMsdynAifptrainingdocument
		{
			get { return GetRelatedEntities<AIFormProcessingDocument>("user_msdyn_aifptrainingdocument", null); }
			set { SetRelatedEntities("user_msdyn_aifptrainingdocument", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'user_msdyn_aimodel'
        /// </summary>
		[RelationshipSchemaName("user_msdyn_aimodel")]
		public IEnumerable<AIModel> UserMsdynAimodel
		{
			get { return GetRelatedEntities<AIModel>("user_msdyn_aimodel", null); }
			set { SetRelatedEntities("user_msdyn_aimodel", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'user_msdyn_aiodimage'
        /// </summary>
		[RelationshipSchemaName("user_msdyn_aiodimage")]
		public IEnumerable<AIObjectDetectionImage> UserMsdynAiodimage
		{
			get { return GetRelatedEntities<AIObjectDetectionImage>("user_msdyn_aiodimage", null); }
			set { SetRelatedEntities("user_msdyn_aiodimage", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'user_msdyn_aiodlabel'
        /// </summary>
		[RelationshipSchemaName("user_msdyn_aiodlabel")]
		public IEnumerable<AIObjectDetectionLabel> UserMsdynAiodlabel
		{
			get { return GetRelatedEntities<AIObjectDetectionLabel>("user_msdyn_aiodlabel", null); }
			set { SetRelatedEntities("user_msdyn_aiodlabel", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'user_msdyn_aiodtrainingboundingbox'
        /// </summary>
		[RelationshipSchemaName("user_msdyn_aiodtrainingboundingbox")]
		public IEnumerable<AIObjectDetectionBoundingBox> UserMsdynAiodtrainingboundingbox
		{
			get { return GetRelatedEntities<AIObjectDetectionBoundingBox>("user_msdyn_aiodtrainingboundingbox", null); }
			set { SetRelatedEntities("user_msdyn_aiodtrainingboundingbox", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'user_msdyn_aiodtrainingimage'
        /// </summary>
		[RelationshipSchemaName("user_msdyn_aiodtrainingimage")]
		public IEnumerable<AIObjectDetectionImageMapping> UserMsdynAiodtrainingimage
		{
			get { return GetRelatedEntities<AIObjectDetectionImageMapping>("user_msdyn_aiodtrainingimage", null); }
			set { SetRelatedEntities("user_msdyn_aiodtrainingimage", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'user_msdyn_aitemplate'
        /// </summary>
		[RelationshipSchemaName("user_msdyn_aitemplate")]
		public IEnumerable<AITemplate> UserMsdynAitemplate
		{
			get { return GetRelatedEntities<AITemplate>("user_msdyn_aitemplate", null); }
			set { SetRelatedEntities("user_msdyn_aitemplate", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'user_msdyn_autocapturerule'
        /// </summary>
		[RelationshipSchemaName("user_msdyn_autocapturerule")]
		public IEnumerable<AutoCaptureRule> UserMsdynAutocapturerule
		{
			get { return GetRelatedEntities<AutoCaptureRule>("user_msdyn_autocapturerule", null); }
			set { SetRelatedEntities("user_msdyn_autocapturerule", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'user_msdyn_autocapturesettings'
        /// </summary>
		[RelationshipSchemaName("user_msdyn_autocapturesettings")]
		public IEnumerable<AutoCaptureSettings> UserMsdynAutocapturesettings
		{
			get { return GetRelatedEntities<AutoCaptureSettings>("user_msdyn_autocapturesettings", null); }
			set { SetRelatedEntities("user_msdyn_autocapturesettings", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'user_msdyn_callablecontext'
        /// </summary>
		[RelationshipSchemaName("user_msdyn_callablecontext")]
		public IEnumerable<PlaybookCallableContext> UserMsdynCallablecontext
		{
			get { return GetRelatedEntities<PlaybookCallableContext>("user_msdyn_callablecontext", null); }
			set { SetRelatedEntities("user_msdyn_callablecontext", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'user_msdyn_entityrankingrule'
        /// </summary>
		[RelationshipSchemaName("user_msdyn_entityrankingrule")]
		public IEnumerable<EntityRankingRule> UserMsdynEntityrankingrule
		{
			get { return GetRelatedEntities<EntityRankingRule>("user_msdyn_entityrankingrule", null); }
			set { SetRelatedEntities("user_msdyn_entityrankingrule", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'user_msdyn_federatedarticle'
        /// </summary>
		[RelationshipSchemaName("user_msdyn_federatedarticle")]
		public IEnumerable<KnowledgeFederatedArticle> UserMsdynFederatedarticle
		{
			get { return GetRelatedEntities<KnowledgeFederatedArticle>("user_msdyn_federatedarticle", null); }
			set { SetRelatedEntities("user_msdyn_federatedarticle", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'user_msdyn_flowcardtype'
        /// </summary>
		[RelationshipSchemaName("user_msdyn_flowcardtype")]
		public IEnumerable<Flowcardtype> UserMsdynFlowcardtype
		{
			get { return GetRelatedEntities<Flowcardtype>("user_msdyn_flowcardtype", null); }
			set { SetRelatedEntities("user_msdyn_flowcardtype", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'user_msdyn_icebreakersconfig'
        /// </summary>
		[RelationshipSchemaName("user_msdyn_icebreakersconfig")]
		public IEnumerable<Icebreakersconfig> UserMsdynIcebreakersconfig
		{
			get { return GetRelatedEntities<Icebreakersconfig>("user_msdyn_icebreakersconfig", null); }
			set { SetRelatedEntities("user_msdyn_icebreakersconfig", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'user_msdyn_kmfederatedsearchconfig'
        /// </summary>
		[RelationshipSchemaName("user_msdyn_kmfederatedsearchconfig")]
		public IEnumerable<SearchProvider> UserMsdynKmfederatedsearchconfig
		{
			get { return GetRelatedEntities<SearchProvider>("user_msdyn_kmfederatedsearchconfig", null); }
			set { SetRelatedEntities("user_msdyn_kmfederatedsearchconfig", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'user_msdyn_knowledgearticleimage'
        /// </summary>
		[RelationshipSchemaName("user_msdyn_knowledgearticleimage")]
		public IEnumerable<KnowledgeArticleImage> UserMsdynKnowledgearticleimage
		{
			get { return GetRelatedEntities<KnowledgeArticleImage>("user_msdyn_knowledgearticleimage", null); }
			set { SetRelatedEntities("user_msdyn_knowledgearticleimage", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'user_msdyn_knowledgearticletemplate'
        /// </summary>
		[RelationshipSchemaName("user_msdyn_knowledgearticletemplate")]
		public IEnumerable<KnowledgeArticleTemplate> UserMsdynKnowledgearticletemplate
		{
			get { return GetRelatedEntities<KnowledgeArticleTemplate>("user_msdyn_knowledgearticletemplate", null); }
			set { SetRelatedEntities("user_msdyn_knowledgearticletemplate", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'user_msdyn_knowledgeinteractioninsight'
        /// </summary>
		[RelationshipSchemaName("user_msdyn_knowledgeinteractioninsight")]
		public IEnumerable<KnowledgeInteractionInsight> UserMsdynKnowledgeinteractioninsight
		{
			get { return GetRelatedEntities<KnowledgeInteractionInsight>("user_msdyn_knowledgeinteractioninsight", null); }
			set { SetRelatedEntities("user_msdyn_knowledgeinteractioninsight", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'user_msdyn_knowledgesearchinsight'
        /// </summary>
		[RelationshipSchemaName("user_msdyn_knowledgesearchinsight")]
		public IEnumerable<KnowledgeSearchInsight> UserMsdynKnowledgesearchinsight
		{
			get { return GetRelatedEntities<KnowledgeSearchInsight>("user_msdyn_knowledgesearchinsight", null); }
			set { SetRelatedEntities("user_msdyn_knowledgesearchinsight", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'user_msdyn_msteamssetting'
        /// </summary>
		[RelationshipSchemaName("user_msdyn_msteamssetting")]
		public IEnumerable<MsdynMsteamssetting> UserMsdynMsteamssetting
		{
			get { return GetRelatedEntities<MsdynMsteamssetting>("user_msdyn_msteamssetting", null); }
			set { SetRelatedEntities("user_msdyn_msteamssetting", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'user_msdyn_notesanalysisconfig'
        /// </summary>
		[RelationshipSchemaName("user_msdyn_notesanalysisconfig")]
		public IEnumerable<NotesAnalysisConfig> UserMsdynNotesanalysisconfig
		{
			get { return GetRelatedEntities<NotesAnalysisConfig>("user_msdyn_notesanalysisconfig", null); }
			set { SetRelatedEntities("user_msdyn_notesanalysisconfig", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'user_msdyn_playbookactivity'
        /// </summary>
		[RelationshipSchemaName("user_msdyn_playbookactivity")]
		public IEnumerable<PlaybookActivity> UserMsdynPlaybookactivity
		{
			get { return GetRelatedEntities<PlaybookActivity>("user_msdyn_playbookactivity", null); }
			set { SetRelatedEntities("user_msdyn_playbookactivity", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'user_msdyn_playbookactivityattribute'
        /// </summary>
		[RelationshipSchemaName("user_msdyn_playbookactivityattribute")]
		public IEnumerable<PlaybookActivityAttribute> UserMsdynPlaybookactivityattribute
		{
			get { return GetRelatedEntities<PlaybookActivityAttribute>("user_msdyn_playbookactivityattribute", null); }
			set { SetRelatedEntities("user_msdyn_playbookactivityattribute", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'user_msdyn_playbookcategory'
        /// </summary>
		[RelationshipSchemaName("user_msdyn_playbookcategory")]
		public IEnumerable<PlaybookCategory> UserMsdynPlaybookcategory
		{
			get { return GetRelatedEntities<PlaybookCategory>("user_msdyn_playbookcategory", null); }
			set { SetRelatedEntities("user_msdyn_playbookcategory", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'user_msdyn_playbookinstance'
        /// </summary>
		[RelationshipSchemaName("user_msdyn_playbookinstance")]
		public IEnumerable<Playbook> UserMsdynPlaybookinstance
		{
			get { return GetRelatedEntities<Playbook>("user_msdyn_playbookinstance", null); }
			set { SetRelatedEntities("user_msdyn_playbookinstance", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'user_msdyn_playbooktemplate'
        /// </summary>
		[RelationshipSchemaName("user_msdyn_playbooktemplate")]
		public IEnumerable<PlaybookTemplate> UserMsdynPlaybooktemplate
		{
			get { return GetRelatedEntities<PlaybookTemplate>("user_msdyn_playbooktemplate", null); }
			set { SetRelatedEntities("user_msdyn_playbooktemplate", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'user_msdyn_postalbum'
        /// </summary>
		[RelationshipSchemaName("user_msdyn_postalbum")]
		public IEnumerable<ProfileAlbum> UserMsdynPostalbum
		{
			get { return GetRelatedEntities<ProfileAlbum>("user_msdyn_postalbum", null); }
			set { SetRelatedEntities("user_msdyn_postalbum", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'user_msdyn_relationshipinsightsunifiedconfig'
        /// </summary>
		[RelationshipSchemaName("user_msdyn_relationshipinsightsunifiedconfig")]
		public IEnumerable<MsdynRelationshipinsightsunifiedconfig> UserMsdynRelationshipinsightsunifiedconfig
		{
			get { return GetRelatedEntities<MsdynRelationshipinsightsunifiedconfig>("user_msdyn_relationshipinsightsunifiedconfig", null); }
			set { SetRelatedEntities("user_msdyn_relationshipinsightsunifiedconfig", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'user_msdyn_richtextfile'
        /// </summary>
		[RelationshipSchemaName("user_msdyn_richtextfile")]
		public IEnumerable<RichTextAttachment> UserMsdynRichtextfile
		{
			get { return GetRelatedEntities<RichTextAttachment>("user_msdyn_richtextfile", null); }
			set { SetRelatedEntities("user_msdyn_richtextfile", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'user_msdyn_salesinsightssettings'
        /// </summary>
		[RelationshipSchemaName("user_msdyn_salesinsightssettings")]
		public IEnumerable<Salesinsightssettings> UserMsdynSalesinsightssettings
		{
			get { return GetRelatedEntities<Salesinsightssettings>("user_msdyn_salesinsightssettings", null); }
			set { SetRelatedEntities("user_msdyn_salesinsightssettings", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'user_msdyn_siconfig'
        /// </summary>
		[RelationshipSchemaName("user_msdyn_siconfig")]
		public IEnumerable<Siconfig> UserMsdynSiconfig
		{
			get { return GetRelatedEntities<Siconfig>("user_msdyn_siconfig", null); }
			set { SetRelatedEntities("user_msdyn_siconfig", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'user_msdyn_untrackedappointment'
        /// </summary>
		[RelationshipSchemaName("user_msdyn_untrackedappointment")]
		public IEnumerable<UntrackedAppointment> UserMsdynUntrackedappointment
		{
			get { return GetRelatedEntities<UntrackedAppointment>("user_msdyn_untrackedappointment", null); }
			set { SetRelatedEntities("user_msdyn_untrackedappointment", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'user_msdyn_wallsavedqueryusersettings'
        /// </summary>
		[RelationshipSchemaName("user_msdyn_wallsavedqueryusersettings")]
		public IEnumerable<Filter> UserMsdynWallsavedqueryusersettings
		{
			get { return GetRelatedEntities<Filter>("user_msdyn_wallsavedqueryusersettings", null); }
			set { SetRelatedEntities("user_msdyn_wallsavedqueryusersettings", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'user_msdynce_botcontent'
        /// </summary>
		[RelationshipSchemaName("user_msdynce_botcontent")]
		public IEnumerable<BotContent> UserMsdynceBotcontent
		{
			get { return GetRelatedEntities<BotContent>("user_msdynce_botcontent", null); }
			set { SetRelatedEntities("user_msdynce_botcontent", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'user_opportunityclose'
        /// </summary>
		[RelationshipSchemaName("user_opportunityclose")]
		public IEnumerable<OpportunityClose> UserOpportunityclose
		{
			get { return GetRelatedEntities<OpportunityClose>("user_opportunityclose", null); }
			set { SetRelatedEntities("user_opportunityclose", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'user_opportunityproduct'
        /// </summary>
		[RelationshipSchemaName("user_opportunityproduct")]
		public IEnumerable<OpportunityProduct> UserOpportunityproduct
		{
			get { return GetRelatedEntities<OpportunityProduct>("user_opportunityproduct", null); }
			set { SetRelatedEntities("user_opportunityproduct", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'user_orderclose'
        /// </summary>
		[RelationshipSchemaName("user_orderclose")]
		public IEnumerable<OrderClose> UserOrderclose
		{
			get { return GetRelatedEntities<OrderClose>("user_orderclose", null); }
			set { SetRelatedEntities("user_orderclose", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'user_owner_postfollows'
        /// </summary>
		[RelationshipSchemaName("user_owner_postfollows")]
		public IEnumerable<Follow> UserOwnerPostfollows
		{
			get { return GetRelatedEntities<Follow>("user_owner_postfollows", null); }
			set { SetRelatedEntities("user_owner_postfollows", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'user_parent_user'
        /// </summary>
		[RelationshipSchemaName("user_parent_user")]
		public IEnumerable<User> UserParentUser
		{
			get { return GetRelatedEntities<User>("user_parent_user", null); }
			set { SetRelatedEntities("user_parent_user", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'user_phonecall'
        /// </summary>
		[RelationshipSchemaName("user_phonecall")]
		public IEnumerable<PhoneCall> UserPhonecall
		{
			get { return GetRelatedEntities<PhoneCall>("user_phonecall", null); }
			set { SetRelatedEntities("user_phonecall", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'user_processstageparameter'
        /// </summary>
		[RelationshipSchemaName("user_processstageparameter")]
		public IEnumerable<ProcessStageParameter> UserProcessstageparameter
		{
			get { return GetRelatedEntities<ProcessStageParameter>("user_processstageparameter", null); }
			set { SetRelatedEntities("user_processstageparameter", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'user_pw_penta_schedule_run'
        /// </summary>
		[RelationshipSchemaName("user_pw_penta_schedule_run")]
		public IEnumerable<PentaScheduleRun> UserPwPentaScheduleRun
		{
			get { return GetRelatedEntities<PentaScheduleRun>("user_pw_penta_schedule_run", null); }
			set { SetRelatedEntities("user_pw_penta_schedule_run", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'user_pw_schedule'
        /// </summary>
		[RelationshipSchemaName("user_pw_schedule")]
		public IEnumerable<PentaSchedule> UserPwSchedule
		{
			get { return GetRelatedEntities<PentaSchedule>("user_pw_schedule", null); }
			set { SetRelatedEntities("user_pw_schedule", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'user_quoteclose'
        /// </summary>
		[RelationshipSchemaName("user_quoteclose")]
		public IEnumerable<QuoteClose> UserQuoteclose
		{
			get { return GetRelatedEntities<QuoteClose>("user_quoteclose", null); }
			set { SetRelatedEntities("user_quoteclose", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'user_quotedetail'
        /// </summary>
		[RelationshipSchemaName("user_quotedetail")]
		public IEnumerable<QuoteProduct> UserQuotedetail
		{
			get { return GetRelatedEntities<QuoteProduct>("user_quotedetail", null); }
			set { SetRelatedEntities("user_quotedetail", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'user_ratingmodel'
        /// </summary>
		[RelationshipSchemaName("user_ratingmodel")]
		public IEnumerable<RatingModel> UserRatingmodel
		{
			get { return GetRelatedEntities<RatingModel>("user_ratingmodel", null); }
			set { SetRelatedEntities("user_ratingmodel", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'user_ratingvalue'
        /// </summary>
		[RelationshipSchemaName("user_ratingvalue")]
		public IEnumerable<RatingValue> UserRatingvalue
		{
			get { return GetRelatedEntities<RatingValue>("user_ratingvalue", null); }
			set { SetRelatedEntities("user_ratingvalue", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'user_recurringappointmentmaster'
        /// </summary>
		[RelationshipSchemaName("user_recurringappointmentmaster")]
		public IEnumerable<RecurringAppointment> UserRecurringappointmentmaster
		{
			get { return GetRelatedEntities<RecurringAppointment>("user_recurringappointmentmaster", null); }
			set { SetRelatedEntities("user_recurringappointmentmaster", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'user_salesorderdetail'
        /// </summary>
		[RelationshipSchemaName("user_salesorderdetail")]
		public IEnumerable<OrderProduct> UserSalesorderdetail
		{
			get { return GetRelatedEntities<OrderProduct>("user_salesorderdetail", null); }
			set { SetRelatedEntities("user_salesorderdetail", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'user_settings'
        /// </summary>
		[RelationshipSchemaName("user_settings")]
		public IEnumerable<UserSettings> UserSettings
		{
			get { return GetRelatedEntities<UserSettings>("user_settings", null); }
			set { SetRelatedEntities("user_settings", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'user_sharepointdocumentlocation'
        /// </summary>
		[RelationshipSchemaName("user_sharepointdocumentlocation")]
		public IEnumerable<DocumentLocation> UserSharepointdocumentlocation
		{
			get { return GetRelatedEntities<DocumentLocation>("user_sharepointdocumentlocation", null); }
			set { SetRelatedEntities("user_sharepointdocumentlocation", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'user_sharepointsite'
        /// </summary>
		[RelationshipSchemaName("user_sharepointsite")]
		public IEnumerable<SharePointSite> UserSharepointsite
		{
			get { return GetRelatedEntities<SharePointSite>("user_sharepointsite", null); }
			set { SetRelatedEntities("user_sharepointsite", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'user_slabase'
        /// </summary>
		[RelationshipSchemaName("user_slabase")]
		public IEnumerable<SLA> UserSlabase
		{
			get { return GetRelatedEntities<SLA>("user_slabase", null); }
			set { SetRelatedEntities("user_slabase", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'user_socialactivity'
        /// </summary>
		[RelationshipSchemaName("user_socialactivity")]
		public IEnumerable<SocialActivity> UserSocialactivity
		{
			get { return GetRelatedEntities<SocialActivity>("user_socialactivity", null); }
			set { SetRelatedEntities("user_socialactivity", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'user_stagesolutionupload'
        /// </summary>
		[RelationshipSchemaName("user_stagesolutionupload")]
		public IEnumerable<StageSolutionUpload> UserStagesolutionupload
		{
			get { return GetRelatedEntities<StageSolutionUpload>("user_stagesolutionupload", null); }
			set { SetRelatedEntities("user_stagesolutionupload", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'user_task'
        /// </summary>
		[RelationshipSchemaName("user_task")]
		public IEnumerable<Task> UserTask
		{
			get { return GetRelatedEntities<Task>("user_task", null); }
			set { SetRelatedEntities("user_task", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'user_userform'
        /// </summary>
		[RelationshipSchemaName("user_userform")]
		public IEnumerable<UserDashboard> UserUserform
		{
			get { return GetRelatedEntities<UserDashboard>("user_userform", null); }
			set { SetRelatedEntities("user_userform", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'user_userquery'
        /// </summary>
		[RelationshipSchemaName("user_userquery")]
		public IEnumerable<SavedView> UserUserquery
		{
			get { return GetRelatedEntities<SavedView>("user_userquery", null); }
			set { SetRelatedEntities("user_userquery", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'user_userqueryvisualizations'
        /// </summary>
		[RelationshipSchemaName("user_userqueryvisualizations")]
		public IEnumerable<UserChart> UserUserqueryvisualizations
		{
			get { return GetRelatedEntities<UserChart>("user_userqueryvisualizations", null); }
			set { SetRelatedEntities("user_userqueryvisualizations", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'user_workflowbinary'
        /// </summary>
		[RelationshipSchemaName("user_workflowbinary")]
		public IEnumerable<WorkflowBinary> UserWorkflowbinary
		{
			get { return GetRelatedEntities<WorkflowBinary>("user_workflowbinary", null); }
			set { SetRelatedEntities("user_workflowbinary", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'webresource_createdby'
        /// </summary>
		[RelationshipSchemaName("webresource_createdby")]
		public IEnumerable<WebResource> WebresourceCreatedby
		{
			get { return GetRelatedEntities<WebResource>("webresource_createdby", null); }
			set { SetRelatedEntities("webresource_createdby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'webresource_modifiedby'
        /// </summary>
		[RelationshipSchemaName("webresource_modifiedby")]
		public IEnumerable<WebResource> WebresourceModifiedby
		{
			get { return GetRelatedEntities<WebResource>("webresource_modifiedby", null); }
			set { SetRelatedEntities("webresource_modifiedby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'workflow_createdby'
        /// </summary>
		[RelationshipSchemaName("workflow_createdby")]
		public IEnumerable<Process> WorkflowCreatedby
		{
			get { return GetRelatedEntities<Process>("workflow_createdby", null); }
			set { SetRelatedEntities("workflow_createdby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'workflow_createdonbehalfby'
        /// </summary>
		[RelationshipSchemaName("workflow_createdonbehalfby")]
		public IEnumerable<Process> WorkflowCreatedonbehalfby
		{
			get { return GetRelatedEntities<Process>("workflow_createdonbehalfby", null); }
			set { SetRelatedEntities("workflow_createdonbehalfby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'workflow_modifiedby'
        /// </summary>
		[RelationshipSchemaName("workflow_modifiedby")]
		public IEnumerable<Process> WorkflowModifiedby
		{
			get { return GetRelatedEntities<Process>("workflow_modifiedby", null); }
			set { SetRelatedEntities("workflow_modifiedby", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'workflow_modifiedonbehalfby'
        /// </summary>
		[RelationshipSchemaName("workflow_modifiedonbehalfby")]
		public IEnumerable<Process> WorkflowModifiedonbehalfby
		{
			get { return GetRelatedEntities<Process>("workflow_modifiedonbehalfby", null); }
			set { SetRelatedEntities("workflow_modifiedonbehalfby", null, value); }
		}
		/// <summary>
        /// N:N Get entities for 'Queue'
        /// </summary>
		[RelationshipSchemaName("queuemembership_association")]
		public IEnumerable<Queue> QueuemembershipAssociation
		{
			get { return GetRelatedEntities<Queue>("queuemembership_association", null); }
			set { SetRelatedEntities("queuemembership_association", null, value); }
		}
		/// <summary>
        /// N:N Get entities for 'FieldSecurityProfile'
        /// </summary>
		[RelationshipSchemaName("systemuserprofiles_association")]
		public IEnumerable<FieldSecurityProfile> SystemuserprofilesAssociation
		{
			get { return GetRelatedEntities<FieldSecurityProfile>("systemuserprofiles_association", null); }
			set { SetRelatedEntities("systemuserprofiles_association", null, value); }
		}
		/// <summary>
        /// N:N Get entities for 'SecurityRole'
        /// </summary>
		[RelationshipSchemaName("systemuserroles_association")]
		public IEnumerable<SecurityRole> SystemuserrolesAssociation
		{
			get { return GetRelatedEntities<SecurityRole>("systemuserroles_association", null); }
			set { SetRelatedEntities("systemuserroles_association", null, value); }
		}
		/// <summary>
        /// N:N Get entities for 'Team'
        /// </summary>
		[RelationshipSchemaName("teammembership_association")]
		public IEnumerable<Team> TeammembershipAssociation
		{
			get { return GetRelatedEntities<Team>("teammembership_association", null); }
			set { SetRelatedEntities("teammembership_association", null, value); }
		}
		#endregion

		#region Actions
		public OrganizationResponse ExecuteSalesInsightsGDPROptoutUser(OrganizationServiceContext serviceContext)
		{
			var orgRequest = new OrganizationRequest("msdyn_GDPROptoutUser");
			orgRequest["Target"] = ToEntityReference();
            return serviceContext.Execute(orgRequest);
		}
		#endregion

		#region OptionSetEnums
		public enum eAccessMode
		{	
		
			[Label("Read-Write")]
			[Description(@"")]
			ReadWrite = 0, 
		
			[Label("Administrative")]
			[Description(@"")]
			Administrative = 1, 
		
			[Label("Read")]
			[Description(@"")]
			Read = 2, 
		
			[Label("Support User")]
			[Description(@"")]
			SupportUser = 3, 
		
			[Label("Non-interactive")]
			[Description(@"")]
			Noninteractive = 4, 
		
			[Label("Delegated Admin")]
			[Description(@"")]
			DelegatedAdmin = 5, 
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
		
		public enum eCALTypes
		{	
		
			[Label("Professional")]
			[Description(@"")]
			Professional = 0, 
		
			[Label("Administrative")]
			[Description(@"")]
			Administrative = 1, 
		
			[Label("Basic")]
			[Description(@"")]
			Basic = 2, 
		
			[Label("Device Professional")]
			[Description(@"")]
			DeviceProfessional = 3, 
		
			[Label("Device Basic")]
			[Description(@"")]
			DeviceBasic = 4, 
		
			[Label("Essential")]
			[Description(@"")]
			Essential = 5, 
		
			[Label("Device Essential")]
			[Description(@"")]
			DeviceEssential = 6, 
		
			[Label("Enterprise")]
			[Description(@"")]
			Enterprise = 7, 
		
			[Label("Device Enterprise")]
			[Description(@"")]
			DeviceEnterprise = 8, 
		
			[Label("Sales")]
			[Description(@"")]
			Sales = 9, 
		
			[Label("Service")]
			[Description(@"")]
			Service = 10, 
		
			[Label("Field Service")]
			[Description(@"")]
			FieldService = 11, 
		
			[Label("Project Service")]
			[Description(@"")]
			ProjectService = 12, 
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
		
		public enum eInvitationStatus
		{	
		
			[Label("Invitation Not Sent")]
			[Description(@"")]
			InvitationNotSent = 0, 
		
			[Label("Invited")]
			[Description(@"")]
			Invited = 1, 
		
			[Label("Invitation Near Expired")]
			[Description(@"")]
			InvitationNearExpired = 2, 
		
			[Label("Invitation Expired")]
			[Description(@"")]
			InvitationExpired = 3, 
		
			[Label("Invitation Accepted")]
			[Description(@"")]
			InvitationAccepted = 4, 
		
			[Label("Invitation Rejected")]
			[Description(@"")]
			InvitationRejected = 5, 
		
			[Label("Invitation Revoked")]
			[Description(@"")]
			InvitationRevoked = 6, 
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
		
		public enum ePreferredAddress
		{	
		
			[Label("Mailing Address")]
			[Description(@"")]
			MailingAddress = 1, 
		
			[Label("Other Address")]
			[Description(@"")]
			OtherAddress = 2, 
		}
		
		public enum ePreferredEmail
		{	
		
			[Label("Default Value")]
			[Description(@"")]
			DefaultValue = 1, 
		}
		
		public enum ePreferredPhone
		{	
		
			[Label("Main Phone")]
			[Description(@"")]
			MainPhone = 1, 
		
			[Label("Other Phone")]
			[Description(@"")]
			OtherPhone = 2, 
		
			[Label("Home Phone")]
			[Description(@"")]
			HomePhone = 3, 
		
			[Label("Mobile Phone")]
			[Description(@"")]
			MobilePhone = 4, 
		}
		
		#endregion	

		#region Properties
		public static class Properties 
		{
			/// <summary>accessmode</summary>
			public const string AccessMode = "accessmode";

			/// <summary>activedirectoryguid</summary>
			public const string ActiveDirectoryGuId = "activedirectoryguid";

			/// <summary>address1_addressid</summary>
			public const string Address1Id = "address1_addressid";

			/// <summary>address1_addresstypecode</summary>
			public const string Address1AddressType = "address1_addresstypecode";

			/// <summary>address1_city</summary>
			public const string City = "address1_city";

			/// <summary>address1_composite</summary>
			public const string Address = "address1_composite";

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
			public const string MainPhone = "address1_telephone1";

			/// <summary>address1_telephone2</summary>
			public const string OtherPhone = "address1_telephone2";

			/// <summary>address1_telephone3</summary>
			public const string Pager = "address1_telephone3";

			/// <summary>address1_upszone</summary>
			public const string Address1UPSZone = "address1_upszone";

			/// <summary>address1_utcoffset</summary>
			public const string Address1UTCOffset = "address1_utcoffset";

			/// <summary>address2_addressid</summary>
			public const string Address2Id = "address2_addressid";

			/// <summary>address2_addresstypecode</summary>
			public const string Address2AddressType = "address2_addresstypecode";

			/// <summary>address2_city</summary>
			public const string OtherCity = "address2_city";

			/// <summary>address2_composite</summary>
			public const string OtherAddress = "address2_composite";

			/// <summary>address2_country</summary>
			public const string OtherCountryRegion = "address2_country";

			/// <summary>address2_county</summary>
			public const string Address2County = "address2_county";

			/// <summary>address2_fax</summary>
			public const string Address2Fax = "address2_fax";

			/// <summary>address2_latitude</summary>
			public const string Address2Latitude = "address2_latitude";

			/// <summary>address2_line1</summary>
			public const string OtherStreet1 = "address2_line1";

			/// <summary>address2_line2</summary>
			public const string OtherStreet2 = "address2_line2";

			/// <summary>address2_line3</summary>
			public const string OtherStreet3 = "address2_line3";

			/// <summary>address2_longitude</summary>
			public const string Address2Longitude = "address2_longitude";

			/// <summary>address2_name</summary>
			public const string Address2Name = "address2_name";

			/// <summary>address2_postalcode</summary>
			public const string OtherZIPPostalCode = "address2_postalcode";

			/// <summary>address2_postofficebox</summary>
			public const string Address2PostOfficeBox = "address2_postofficebox";

			/// <summary>address2_shippingmethodcode</summary>
			public const string Address2ShippingMethod = "address2_shippingmethodcode";

			/// <summary>address2_stateorprovince</summary>
			public const string OtherStateProvince = "address2_stateorprovince";

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

			/// <summary>applicationid</summary>
			public const string ApplicationId = "applicationid";

			/// <summary>applicationiduri</summary>
			public const string ApplicationIDURI = "applicationiduri";

			/// <summary>azureactivedirectoryobjectid</summary>
			public const string AzureADObjectId = "azureactivedirectoryobjectid";

			/// <summary>businessunitid</summary>
			public const string BusinessUnit = "businessunitid";

			/// <summary>businessunitidname</summary>
			public const string Businessunitidname = "businessunitidname";

			/// <summary>calendarid</summary>
			public const string Calendar = "calendarid";

			/// <summary>caltype</summary>
			public const string LicenseType = "caltype";

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

			/// <summary>defaultfilterspopulated</summary>
			public const string DefaultFiltersPopulated = "defaultfilterspopulated";

			/// <summary>defaultmailbox</summary>
			public const string Mailbox = "defaultmailbox";

			/// <summary>defaultmailboxname</summary>
			public const string Defaultmailboxname = "defaultmailboxname";

			/// <summary>defaultodbfoldername</summary>
			public const string DefaultOneDriveForBusinessFolderName = "defaultodbfoldername";

			/// <summary>disabledreason</summary>
			public const string DisabledReason = "disabledreason";

			/// <summary>displayinserviceviews</summary>
			public const string DisplayInServiceViews = "displayinserviceviews";

			/// <summary>domainname</summary>
			public const string UserName = "domainname";

			/// <summary>emailrouteraccessapproval</summary>
			public const string PrimaryEmailStatus = "emailrouteraccessapproval";

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

			/// <summary>firstname</summary>
			public const string FirstName = "firstname";

			/// <summary>fullname</summary>
			public const string FullName = "fullname";

			/// <summary>governmentid</summary>
			public const string Government = "governmentid";

			/// <summary>homephone</summary>
			public const string HomePhone = "homephone";

			/// <summary>identityid</summary>
			public const string UniqueUserIdentityId = "identityid";

			/// <summary>importsequencenumber</summary>
			public const string ImportSequenceNumber = "importsequencenumber";

			/// <summary>incomingemaildeliverymethod</summary>
			public const string IncomingEmailDeliveryMethod = "incomingemaildeliverymethod";

			/// <summary>internalemailaddress</summary>
			public const string PrimaryEmail = "internalemailaddress";

			/// <summary>invitestatuscode</summary>
			public const string InvitationStatus = "invitestatuscode";

			/// <summary>isactivedirectoryuser</summary>
			public const string IsActiveDirectoryUser = "isactivedirectoryuser";

			/// <summary>isdisabled</summary>
			public const string Status = "isdisabled";

			/// <summary>isemailaddressapprovedbyo365admin</summary>
			public const string EmailAddressO365AdminApprovalStatus = "isemailaddressapprovedbyo365admin";

			/// <summary>isintegrationuser</summary>
			public const string IntegrationUserMode = "isintegrationuser";

			/// <summary>islicensed</summary>
			public const string UserLicensed = "islicensed";

			/// <summary>issyncwithdirectory</summary>
			public const string UserSynced = "issyncwithdirectory";

			/// <summary>jobtitle</summary>
			public const string JobTitle = "jobtitle";

			/// <summary>lastname</summary>
			public const string LastName = "lastname";

			/// <summary>latestupdatetime</summary>
			public const string LatestUserUpdateTime = "latestupdatetime";

			/// <summary>middlename</summary>
			public const string MiddleName = "middlename";

			/// <summary>mobilealertemail</summary>
			public const string MobileAlertEmail = "mobilealertemail";

			/// <summary>mobileofflineprofileid</summary>
			public const string MobileOfflineProfile = "mobileofflineprofileid";

			/// <summary>mobileofflineprofileidname</summary>
			public const string Mobileofflineprofileidname = "mobileofflineprofileidname";

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

			/// <summary>nickname</summary>
			public const string Nickname = "nickname";

			/// <summary>organizationid</summary>
			public const string OrganizationId = "organizationid";

			/// <summary>organizationidname</summary>
			public const string Organizationidname = "organizationidname";

			/// <summary>outgoingemaildeliverymethod</summary>
			public const string OutgoingEmailDeliveryMethod = "outgoingemaildeliverymethod";

			/// <summary>overriddencreatedon</summary>
			public const string RecordCreatedOn = "overriddencreatedon";

			/// <summary>parentsystemuserid</summary>
			public const string Manager = "parentsystemuserid";

			/// <summary>parentsystemuseridname</summary>
			public const string Parentsystemuseridname = "parentsystemuseridname";

			/// <summary>parentsystemuseridyominame</summary>
			public const string Parentsystemuseridyominame = "parentsystemuseridyominame";

			/// <summary>passporthi</summary>
			public const string PassportHi = "passporthi";

			/// <summary>passportlo</summary>
			public const string PassportLo = "passportlo";

			/// <summary>personalemailaddress</summary>
			public const string Email2 = "personalemailaddress";

			/// <summary>photourl</summary>
			public const string PhotoURL = "photourl";

			/// <summary>positionid</summary>
			public const string Position = "positionid";

			/// <summary>positionidname</summary>
			public const string Positionidname = "positionidname";

			/// <summary>preferredaddresscode</summary>
			public const string PreferredAddress = "preferredaddresscode";

			/// <summary>preferredemailcode</summary>
			public const string PreferredEmail = "preferredemailcode";

			/// <summary>preferredphonecode</summary>
			public const string PreferredPhone = "preferredphonecode";

			/// <summary>processid</summary>
			public const string ProcessId = "processid";

			/// <summary>queueid</summary>
			public const string DefaultQueue = "queueid";

			/// <summary>queueidname</summary>
			public const string Queueidname = "queueidname";

			/// <summary>salutation</summary>
			public const string Salutation = "salutation";

			/// <summary>setupuser</summary>
			public const string RestrictedAccessMode = "setupuser";

			/// <summary>sharepointemailaddress</summary>
			public const string SharePointEmailAddress = "sharepointemailaddress";

			/// <summary>siteid</summary>
			public const string Site = "siteid";

			/// <summary>siteidname</summary>
			public const string Siteidname = "siteidname";

			/// <summary>skills</summary>
			public const string Skills = "skills";

			/// <summary>stageid</summary>
			public const string DeprecatedProcessStageId = "stageid";

			/// <summary>systemuserid</summary>
			public const string UserId = "systemuserid";

			/// <summary>territoryid</summary>
			public const string Territory = "territoryid";

			/// <summary>territoryidname</summary>
			public const string Territoryidname = "territoryidname";

			/// <summary>timezoneruleversionnumber</summary>
			public const string TimeZoneRuleVersionNumber = "timezoneruleversionnumber";

			/// <summary>title</summary>
			public const string Title = "title";

			/// <summary>transactioncurrencyid</summary>
			public const string Currency = "transactioncurrencyid";

			/// <summary>transactioncurrencyidname</summary>
			public const string Transactioncurrencyidname = "transactioncurrencyidname";

			/// <summary>traversedpath</summary>
			public const string DeprecatedTraversedPath = "traversedpath";

			/// <summary>userlicensetype</summary>
			public const string UserLicenseType = "userlicensetype";

			/// <summary>userpuid</summary>
			public const string UserPUID = "userpuid";

			/// <summary>utcconversiontimezonecode</summary>
			public const string UTCConversionTimeZoneCode = "utcconversiontimezonecode";

			/// <summary>versionnumber</summary>
			public const string VersionNumber = "versionnumber";

			/// <summary>windowsliveid</summary>
			public const string WindowsLiveID = "windowsliveid";

			/// <summary>yammeremailaddress</summary>
			public const string YammerEmail = "yammeremailaddress";

			/// <summary>yammeruserid</summary>
			public const string YammerUserID = "yammeruserid";

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
			/// <summary>1:N annotation_owning_user</summary>
			public const string AnnotationOwningUser = "annotation_owning_user";

			/// <summary>1:N constraintbasedgroup_systemuser</summary>
			public const string ConstraintbasedgroupSystemuser = "constraintbasedgroup_systemuser";

			/// <summary>1:N contact_owning_user</summary>
			public const string ContactOwningUser = "contact_owning_user";

			/// <summary>1:N createdby_connection</summary>
			public const string CreatedbyConnection = "createdby_connection";

			/// <summary>1:N createdby_connection_role</summary>
			public const string CreatedbyConnectionRole = "createdby_connection_role";

			/// <summary>1:N createdby_pluginassembly</summary>
			public const string CreatedbyPluginassembly = "createdby_pluginassembly";

			/// <summary>1:N createdby_plugintracelog</summary>
			public const string CreatedbyPlugintracelog = "createdby_plugintracelog";

			/// <summary>1:N createdby_plugintype</summary>
			public const string CreatedbyPlugintype = "createdby_plugintype";

			/// <summary>1:N createdby_plugintypestatistic</summary>
			public const string CreatedbyPlugintypestatistic = "createdby_plugintypestatistic";

			/// <summary>1:N createdby_sdkmessage</summary>
			public const string CreatedbySdkmessage = "createdby_sdkmessage";

			/// <summary>1:N createdby_sdkmessagefilter</summary>
			public const string CreatedbySdkmessagefilter = "createdby_sdkmessagefilter";

			/// <summary>1:N createdby_sdkmessageprocessingstep</summary>
			public const string CreatedbySdkmessageprocessingstep = "createdby_sdkmessageprocessingstep";

			/// <summary>1:N createdby_sdkmessageprocessingstepimage</summary>
			public const string CreatedbySdkmessageprocessingstepimage = "createdby_sdkmessageprocessingstepimage";

			/// <summary>1:N createdby_sdkmessageprocessingstepsecureconfig</summary>
			public const string CreatedbySdkmessageprocessingstepsecureconfig = "createdby_sdkmessageprocessingstepsecureconfig";

			/// <summary>1:N createdby_serviceendpoint</summary>
			public const string CreatedbyServiceendpoint = "createdby_serviceendpoint";

			/// <summary>1:N Dynamicpropertyinsatance_createdby</summary>
			public const string DynamicpropertyinsatanceCreatedby = "Dynamicpropertyinsatance_createdby";

			/// <summary>1:N equipment_systemuser</summary>
			public const string EquipmentSystemuser = "equipment_systemuser";

			/// <summary>1:N impersonatinguserid_sdkmessageprocessingstep</summary>
			public const string ImpersonatinguseridSdkmessageprocessingstep = "impersonatinguserid_sdkmessageprocessingstep";

			/// <summary>1:N ImportFile_SystemUser</summary>
			public const string ImportFileSystemUser = "ImportFile_SystemUser";

			/// <summary>1:N knowledgearticle_primaryauthorid</summary>
			public const string KnowledgearticlePrimaryauthorid = "knowledgearticle_primaryauthorid";

			/// <summary>1:N lead_owning_user</summary>
			public const string LeadOwningUser = "lead_owning_user";

			/// <summary>1:N lk_accountbase_createdby</summary>
			public const string LkAccountbaseCreatedby = "lk_accountbase_createdby";

			/// <summary>1:N lk_accountbase_createdonbehalfby</summary>
			public const string LkAccountbaseCreatedonbehalfby = "lk_accountbase_createdonbehalfby";

			/// <summary>1:N lk_accountbase_modifiedby</summary>
			public const string LkAccountbaseModifiedby = "lk_accountbase_modifiedby";

			/// <summary>1:N lk_accountbase_modifiedonbehalfby</summary>
			public const string LkAccountbaseModifiedonbehalfby = "lk_accountbase_modifiedonbehalfby";

			/// <summary>1:N lk_ACIViewMapper_createdby</summary>
			public const string LkACIViewMapperCreatedby = "lk_ACIViewMapper_createdby";

			/// <summary>1:N lk_ACIViewMapper_createdonbehalfby</summary>
			public const string LkACIViewMapperCreatedonbehalfby = "lk_ACIViewMapper_createdonbehalfby";

			/// <summary>1:N lk_ACIViewMapper_modifiedby</summary>
			public const string LkACIViewMapperModifiedby = "lk_ACIViewMapper_modifiedby";

			/// <summary>1:N lk_ACIViewMapper_modifiedonbehalfby</summary>
			public const string LkACIViewMapperModifiedonbehalfby = "lk_ACIViewMapper_modifiedonbehalfby";

			/// <summary>1:N lk_actioncardbase_createdby</summary>
			public const string LkActioncardbaseCreatedby = "lk_actioncardbase_createdby";

			/// <summary>1:N lk_actioncardbase_createdonbehalfby</summary>
			public const string LkActioncardbaseCreatedonbehalfby = "lk_actioncardbase_createdonbehalfby";

			/// <summary>1:N lk_actioncardbase_modifiedby</summary>
			public const string LkActioncardbaseModifiedby = "lk_actioncardbase_modifiedby";

			/// <summary>1:N lk_actioncardbase_modifiedonbehalfby</summary>
			public const string LkActioncardbaseModifiedonbehalfby = "lk_actioncardbase_modifiedonbehalfby";

			/// <summary>1:N lk_activitymonitor_createdby</summary>
			public const string LkActivitymonitorCreatedby = "lk_activitymonitor_createdby";

			/// <summary>1:N lk_activitymonitor_createdonbehalfby</summary>
			public const string LkActivitymonitorCreatedonbehalfby = "lk_activitymonitor_createdonbehalfby";

			/// <summary>1:N lk_activitymonitor_modifiedby</summary>
			public const string LkActivitymonitorModifiedby = "lk_activitymonitor_modifiedby";

			/// <summary>1:N lk_activitymonitor_modifiedonbehalfby</summary>
			public const string LkActivitymonitorModifiedonbehalfby = "lk_activitymonitor_modifiedonbehalfby";

			/// <summary>1:N lk_activitypointer_createdby</summary>
			public const string LkActivitypointerCreatedby = "lk_activitypointer_createdby";

			/// <summary>1:N lk_activitypointer_createdonbehalfby</summary>
			public const string LkActivitypointerCreatedonbehalfby = "lk_activitypointer_createdonbehalfby";

			/// <summary>1:N lk_activitypointer_modifiedby</summary>
			public const string LkActivitypointerModifiedby = "lk_activitypointer_modifiedby";

			/// <summary>1:N lk_activitypointer_modifiedonbehalfby</summary>
			public const string LkActivitypointerModifiedonbehalfby = "lk_activitypointer_modifiedonbehalfby";

			/// <summary>1:N lk_adminsettingsentity_createdby</summary>
			public const string LkAdminsettingsentityCreatedby = "lk_adminsettingsentity_createdby";

			/// <summary>1:N lk_adminsettingsentity_createdonbehalfby</summary>
			public const string LkAdminsettingsentityCreatedonbehalfby = "lk_adminsettingsentity_createdonbehalfby";

			/// <summary>1:N lk_adminsettingsentity_modifiedby</summary>
			public const string LkAdminsettingsentityModifiedby = "lk_adminsettingsentity_modifiedby";

			/// <summary>1:N lk_adminsettingsentity_modifiedonbehalfby</summary>
			public const string LkAdminsettingsentityModifiedonbehalfby = "lk_adminsettingsentity_modifiedonbehalfby";

			/// <summary>1:N lk_annotationbase_createdby</summary>
			public const string LkAnnotationbaseCreatedby = "lk_annotationbase_createdby";

			/// <summary>1:N lk_annotationbase_createdonbehalfby</summary>
			public const string LkAnnotationbaseCreatedonbehalfby = "lk_annotationbase_createdonbehalfby";

			/// <summary>1:N lk_annotationbase_modifiedby</summary>
			public const string LkAnnotationbaseModifiedby = "lk_annotationbase_modifiedby";

			/// <summary>1:N lk_annotationbase_modifiedonbehalfby</summary>
			public const string LkAnnotationbaseModifiedonbehalfby = "lk_annotationbase_modifiedonbehalfby";

			/// <summary>1:N lk_annualfiscalcalendar_createdby</summary>
			public const string LkAnnualfiscalcalendarCreatedby = "lk_annualfiscalcalendar_createdby";

			/// <summary>1:N lk_annualfiscalcalendar_createdonbehalfby</summary>
			public const string LkAnnualfiscalcalendarCreatedonbehalfby = "lk_annualfiscalcalendar_createdonbehalfby";

			/// <summary>1:N lk_annualfiscalcalendar_modifiedby</summary>
			public const string LkAnnualfiscalcalendarModifiedby = "lk_annualfiscalcalendar_modifiedby";

			/// <summary>1:N lk_annualfiscalcalendar_modifiedonbehalfby</summary>
			public const string LkAnnualfiscalcalendarModifiedonbehalfby = "lk_annualfiscalcalendar_modifiedonbehalfby";

			/// <summary>1:N lk_annualfiscalcalendar_salespersonid</summary>
			public const string LkAnnualfiscalcalendarSalespersonid = "lk_annualfiscalcalendar_salespersonid";

			/// <summary>1:N lk_appconfig_createdby</summary>
			public const string LkAppconfigCreatedby = "lk_appconfig_createdby";

			/// <summary>1:N lk_appconfig_createdonbehalfby</summary>
			public const string LkAppconfigCreatedonbehalfby = "lk_appconfig_createdonbehalfby";

			/// <summary>1:N lk_appconfig_modifiedby</summary>
			public const string LkAppconfigModifiedby = "lk_appconfig_modifiedby";

			/// <summary>1:N lk_appconfig_modifiedonbehalfby</summary>
			public const string LkAppconfigModifiedonbehalfby = "lk_appconfig_modifiedonbehalfby";

			/// <summary>1:N lk_appconfiginstance_createdby</summary>
			public const string LkAppconfiginstanceCreatedby = "lk_appconfiginstance_createdby";

			/// <summary>1:N lk_appconfiginstance_createdonbehalfby</summary>
			public const string LkAppconfiginstanceCreatedonbehalfby = "lk_appconfiginstance_createdonbehalfby";

			/// <summary>1:N lk_appconfiginstance_modifiedby</summary>
			public const string LkAppconfiginstanceModifiedby = "lk_appconfiginstance_modifiedby";

			/// <summary>1:N lk_appconfiginstance_modifiedonbehalfby</summary>
			public const string LkAppconfiginstanceModifiedonbehalfby = "lk_appconfiginstance_modifiedonbehalfby";

			/// <summary>1:N lk_appconfigmaster_createdby</summary>
			public const string LkAppconfigmasterCreatedby = "lk_appconfigmaster_createdby";

			/// <summary>1:N lk_appconfigmaster_createdonbehalfby</summary>
			public const string LkAppconfigmasterCreatedonbehalfby = "lk_appconfigmaster_createdonbehalfby";

			/// <summary>1:N lk_appconfigmaster_modifiedby</summary>
			public const string LkAppconfigmasterModifiedby = "lk_appconfigmaster_modifiedby";

			/// <summary>1:N lk_appconfigmaster_modifiedonbehalfby</summary>
			public const string LkAppconfigmasterModifiedonbehalfby = "lk_appconfigmaster_modifiedonbehalfby";

			/// <summary>1:N lk_appmodule_createdby</summary>
			public const string LkAppmoduleCreatedby = "lk_appmodule_createdby";

			/// <summary>1:N lk_appmodule_createdonbehalfby</summary>
			public const string LkAppmoduleCreatedonbehalfby = "lk_appmodule_createdonbehalfby";

			/// <summary>1:N lk_appmodule_modifiedby</summary>
			public const string LkAppmoduleModifiedby = "lk_appmodule_modifiedby";

			/// <summary>1:N lk_appmodule_modifiedonbehalfby</summary>
			public const string LkAppmoduleModifiedonbehalfby = "lk_appmodule_modifiedonbehalfby";

			/// <summary>1:N lk_appmodulecomponent_createdby</summary>
			public const string LkAppmodulecomponentCreatedby = "lk_appmodulecomponent_createdby";

			/// <summary>1:N lk_appmodulecomponent_createdonbehalfby</summary>
			public const string LkAppmodulecomponentCreatedonbehalfby = "lk_appmodulecomponent_createdonbehalfby";

			/// <summary>1:N lk_appmodulecomponent_modifiedby</summary>
			public const string LkAppmodulecomponentModifiedby = "lk_appmodulecomponent_modifiedby";

			/// <summary>1:N lk_appmodulecomponent_modifiedonbehalfby</summary>
			public const string LkAppmodulecomponentModifiedonbehalfby = "lk_appmodulecomponent_modifiedonbehalfby";

			/// <summary>1:N lk_appointment_createdby</summary>
			public const string LkAppointmentCreatedby = "lk_appointment_createdby";

			/// <summary>1:N lk_appointment_createdonbehalfby</summary>
			public const string LkAppointmentCreatedonbehalfby = "lk_appointment_createdonbehalfby";

			/// <summary>1:N lk_appointment_modifiedby</summary>
			public const string LkAppointmentModifiedby = "lk_appointment_modifiedby";

			/// <summary>1:N lk_appointment_modifiedonbehalfby</summary>
			public const string LkAppointmentModifiedonbehalfby = "lk_appointment_modifiedonbehalfby";

			/// <summary>1:N lk_asyncoperation_createdby</summary>
			public const string LkAsyncoperationCreatedby = "lk_asyncoperation_createdby";

			/// <summary>1:N lk_asyncoperation_createdonbehalfby</summary>
			public const string LkAsyncoperationCreatedonbehalfby = "lk_asyncoperation_createdonbehalfby";

			/// <summary>1:N lk_asyncoperation_modifiedby</summary>
			public const string LkAsyncoperationModifiedby = "lk_asyncoperation_modifiedby";

			/// <summary>1:N lk_asyncoperation_modifiedonbehalfby</summary>
			public const string LkAsyncoperationModifiedonbehalfby = "lk_asyncoperation_modifiedonbehalfby";

			/// <summary>1:N lk_audit_callinguserid</summary>
			public const string LkAuditCallinguserid = "lk_audit_callinguserid";

			/// <summary>1:N lk_audit_userid</summary>
			public const string LkAuditUserid = "lk_audit_userid";

			/// <summary>1:N lk_bookableresource_createdby</summary>
			public const string LkBookableresourceCreatedby = "lk_bookableresource_createdby";

			/// <summary>1:N lk_bookableresource_createdonbehalfby</summary>
			public const string LkBookableresourceCreatedonbehalfby = "lk_bookableresource_createdonbehalfby";

			/// <summary>1:N lk_bookableresource_modifiedby</summary>
			public const string LkBookableresourceModifiedby = "lk_bookableresource_modifiedby";

			/// <summary>1:N lk_bookableresource_modifiedonbehalfby</summary>
			public const string LkBookableresourceModifiedonbehalfby = "lk_bookableresource_modifiedonbehalfby";

			/// <summary>1:N lk_bookableresourcebooking_createdby</summary>
			public const string LkBookableresourcebookingCreatedby = "lk_bookableresourcebooking_createdby";

			/// <summary>1:N lk_bookableresourcebooking_createdonbehalfby</summary>
			public const string LkBookableresourcebookingCreatedonbehalfby = "lk_bookableresourcebooking_createdonbehalfby";

			/// <summary>1:N lk_bookableresourcebooking_modifiedby</summary>
			public const string LkBookableresourcebookingModifiedby = "lk_bookableresourcebooking_modifiedby";

			/// <summary>1:N lk_bookableresourcebooking_modifiedonbehalfby</summary>
			public const string LkBookableresourcebookingModifiedonbehalfby = "lk_bookableresourcebooking_modifiedonbehalfby";

			/// <summary>1:N lk_bookableresourcebookingheader_createdby</summary>
			public const string LkBookableresourcebookingheaderCreatedby = "lk_bookableresourcebookingheader_createdby";

			/// <summary>1:N lk_bookableresourcebookingheader_createdonbehalfby</summary>
			public const string LkBookableresourcebookingheaderCreatedonbehalfby = "lk_bookableresourcebookingheader_createdonbehalfby";

			/// <summary>1:N lk_bookableresourcebookingheader_modifiedby</summary>
			public const string LkBookableresourcebookingheaderModifiedby = "lk_bookableresourcebookingheader_modifiedby";

			/// <summary>1:N lk_bookableresourcebookingheader_modifiedonbehalfby</summary>
			public const string LkBookableresourcebookingheaderModifiedonbehalfby = "lk_bookableresourcebookingheader_modifiedonbehalfby";

			/// <summary>1:N lk_bookableresourcecategory_createdby</summary>
			public const string LkBookableresourcecategoryCreatedby = "lk_bookableresourcecategory_createdby";

			/// <summary>1:N lk_bookableresourcecategory_createdonbehalfby</summary>
			public const string LkBookableresourcecategoryCreatedonbehalfby = "lk_bookableresourcecategory_createdonbehalfby";

			/// <summary>1:N lk_bookableresourcecategory_modifiedby</summary>
			public const string LkBookableresourcecategoryModifiedby = "lk_bookableresourcecategory_modifiedby";

			/// <summary>1:N lk_bookableresourcecategory_modifiedonbehalfby</summary>
			public const string LkBookableresourcecategoryModifiedonbehalfby = "lk_bookableresourcecategory_modifiedonbehalfby";

			/// <summary>1:N lk_bookableresourcecategoryassn_createdby</summary>
			public const string LkBookableresourcecategoryassnCreatedby = "lk_bookableresourcecategoryassn_createdby";

			/// <summary>1:N lk_bookableresourcecategoryassn_createdonbehalfby</summary>
			public const string LkBookableresourcecategoryassnCreatedonbehalfby = "lk_bookableresourcecategoryassn_createdonbehalfby";

			/// <summary>1:N lk_bookableresourcecategoryassn_modifiedby</summary>
			public const string LkBookableresourcecategoryassnModifiedby = "lk_bookableresourcecategoryassn_modifiedby";

			/// <summary>1:N lk_bookableresourcecategoryassn_modifiedonbehalfby</summary>
			public const string LkBookableresourcecategoryassnModifiedonbehalfby = "lk_bookableresourcecategoryassn_modifiedonbehalfby";

			/// <summary>1:N lk_bookableresourcecharacteristic_createdby</summary>
			public const string LkBookableresourcecharacteristicCreatedby = "lk_bookableresourcecharacteristic_createdby";

			/// <summary>1:N lk_bookableresourcecharacteristic_createdonbehalfby</summary>
			public const string LkBookableresourcecharacteristicCreatedonbehalfby = "lk_bookableresourcecharacteristic_createdonbehalfby";

			/// <summary>1:N lk_bookableresourcecharacteristic_modifiedby</summary>
			public const string LkBookableresourcecharacteristicModifiedby = "lk_bookableresourcecharacteristic_modifiedby";

			/// <summary>1:N lk_bookableresourcecharacteristic_modifiedonbehalfby</summary>
			public const string LkBookableresourcecharacteristicModifiedonbehalfby = "lk_bookableresourcecharacteristic_modifiedonbehalfby";

			/// <summary>1:N lk_bookableresourcegroup_createdby</summary>
			public const string LkBookableresourcegroupCreatedby = "lk_bookableresourcegroup_createdby";

			/// <summary>1:N lk_bookableresourcegroup_createdonbehalfby</summary>
			public const string LkBookableresourcegroupCreatedonbehalfby = "lk_bookableresourcegroup_createdonbehalfby";

			/// <summary>1:N lk_bookableresourcegroup_modifiedby</summary>
			public const string LkBookableresourcegroupModifiedby = "lk_bookableresourcegroup_modifiedby";

			/// <summary>1:N lk_bookableresourcegroup_modifiedonbehalfby</summary>
			public const string LkBookableresourcegroupModifiedonbehalfby = "lk_bookableresourcegroup_modifiedonbehalfby";

			/// <summary>1:N lk_bookingstatus_createdby</summary>
			public const string LkBookingstatusCreatedby = "lk_bookingstatus_createdby";

			/// <summary>1:N lk_bookingstatus_createdonbehalfby</summary>
			public const string LkBookingstatusCreatedonbehalfby = "lk_bookingstatus_createdonbehalfby";

			/// <summary>1:N lk_bookingstatus_modifiedby</summary>
			public const string LkBookingstatusModifiedby = "lk_bookingstatus_modifiedby";

			/// <summary>1:N lk_bookingstatus_modifiedonbehalfby</summary>
			public const string LkBookingstatusModifiedonbehalfby = "lk_bookingstatus_modifiedonbehalfby";

			/// <summary>1:N lk_bot_createdby</summary>
			public const string LkBotCreatedby = "lk_bot_createdby";

			/// <summary>1:N lk_bot_createdonbehalfby</summary>
			public const string LkBotCreatedonbehalfby = "lk_bot_createdonbehalfby";

			/// <summary>1:N lk_bot_modifiedby</summary>
			public const string LkBotModifiedby = "lk_bot_modifiedby";

			/// <summary>1:N lk_bot_modifiedonbehalfby</summary>
			public const string LkBotModifiedonbehalfby = "lk_bot_modifiedonbehalfby";

			/// <summary>1:N lk_botcomponent_createdby</summary>
			public const string LkBotcomponentCreatedby = "lk_botcomponent_createdby";

			/// <summary>1:N lk_botcomponent_createdonbehalfby</summary>
			public const string LkBotcomponentCreatedonbehalfby = "lk_botcomponent_createdonbehalfby";

			/// <summary>1:N lk_botcomponent_modifiedby</summary>
			public const string LkBotcomponentModifiedby = "lk_botcomponent_modifiedby";

			/// <summary>1:N lk_botcomponent_modifiedonbehalfby</summary>
			public const string LkBotcomponentModifiedonbehalfby = "lk_botcomponent_modifiedonbehalfby";

			/// <summary>1:N lk_bulkdeleteoperation_createdonbehalfby</summary>
			public const string LkBulkdeleteoperationCreatedonbehalfby = "lk_bulkdeleteoperation_createdonbehalfby";

			/// <summary>1:N lk_bulkdeleteoperation_modifiedonbehalfby</summary>
			public const string LkBulkdeleteoperationModifiedonbehalfby = "lk_bulkdeleteoperation_modifiedonbehalfby";

			/// <summary>1:N lk_bulkdeleteoperationbase_createdby</summary>
			public const string LkBulkdeleteoperationbaseCreatedby = "lk_bulkdeleteoperationbase_createdby";

			/// <summary>1:N lk_bulkdeleteoperationbase_modifiedby</summary>
			public const string LkBulkdeleteoperationbaseModifiedby = "lk_bulkdeleteoperationbase_modifiedby";

			/// <summary>1:N lk_BulkOperation_createdby</summary>
			public const string LkBulkOperationCreatedby = "lk_BulkOperation_createdby";

			/// <summary>1:N lk_BulkOperation_createdonbehalfby</summary>
			public const string LkBulkOperationCreatedonbehalfby = "lk_BulkOperation_createdonbehalfby";

			/// <summary>1:N lk_BulkOperation_modifiedby</summary>
			public const string LkBulkOperationModifiedby = "lk_BulkOperation_modifiedby";

			/// <summary>1:N lk_BulkOperation_modifiedonbehalfby</summary>
			public const string LkBulkOperationModifiedonbehalfby = "lk_BulkOperation_modifiedonbehalfby";

			/// <summary>1:N lk_businessunit_createdonbehalfby</summary>
			public const string LkBusinessunitCreatedonbehalfby = "lk_businessunit_createdonbehalfby";

			/// <summary>1:N lk_businessunit_modifiedonbehalfby</summary>
			public const string LkBusinessunitModifiedonbehalfby = "lk_businessunit_modifiedonbehalfby";

			/// <summary>1:N lk_businessunitbase_createdby</summary>
			public const string LkBusinessunitbaseCreatedby = "lk_businessunitbase_createdby";

			/// <summary>1:N lk_businessunitbase_modifiedby</summary>
			public const string LkBusinessunitbaseModifiedby = "lk_businessunitbase_modifiedby";

			/// <summary>1:N lk_businessunitnewsarticle_createdonbehalfby</summary>
			public const string LkBusinessunitnewsarticleCreatedonbehalfby = "lk_businessunitnewsarticle_createdonbehalfby";

			/// <summary>1:N lk_businessunitnewsarticle_modifiedonbehalfby</summary>
			public const string LkBusinessunitnewsarticleModifiedonbehalfby = "lk_businessunitnewsarticle_modifiedonbehalfby";

			/// <summary>1:N lk_businessunitnewsarticlebase_createdby</summary>
			public const string LkBusinessunitnewsarticlebaseCreatedby = "lk_businessunitnewsarticlebase_createdby";

			/// <summary>1:N lk_businessunitnewsarticlebase_modifiedby</summary>
			public const string LkBusinessunitnewsarticlebaseModifiedby = "lk_businessunitnewsarticlebase_modifiedby";

			/// <summary>1:N lk_calendar_createdby</summary>
			public const string LkCalendarCreatedby = "lk_calendar_createdby";

			/// <summary>1:N lk_calendar_createdonbehalfby</summary>
			public const string LkCalendarCreatedonbehalfby = "lk_calendar_createdonbehalfby";

			/// <summary>1:N lk_calendar_modifiedby</summary>
			public const string LkCalendarModifiedby = "lk_calendar_modifiedby";

			/// <summary>1:N lk_calendar_modifiedonbehalfby</summary>
			public const string LkCalendarModifiedonbehalfby = "lk_calendar_modifiedonbehalfby";

			/// <summary>1:N lk_callbackregistration_createdby</summary>
			public const string LkCallbackregistrationCreatedby = "lk_callbackregistration_createdby";

			/// <summary>1:N lk_callbackregistration_createdonbehalfby</summary>
			public const string LkCallbackregistrationCreatedonbehalfby = "lk_callbackregistration_createdonbehalfby";

			/// <summary>1:N lk_callbackregistration_modifiedby</summary>
			public const string LkCallbackregistrationModifiedby = "lk_callbackregistration_modifiedby";

			/// <summary>1:N lk_callbackregistration_modifiedonbehalfby</summary>
			public const string LkCallbackregistrationModifiedonbehalfby = "lk_callbackregistration_modifiedonbehalfby";

			/// <summary>1:N lk_campaign_createdby</summary>
			public const string LkCampaignCreatedby = "lk_campaign_createdby";

			/// <summary>1:N lk_campaign_createdonbehalfby</summary>
			public const string LkCampaignCreatedonbehalfby = "lk_campaign_createdonbehalfby";

			/// <summary>1:N lk_campaign_modifiedby</summary>
			public const string LkCampaignModifiedby = "lk_campaign_modifiedby";

			/// <summary>1:N lk_campaign_modifiedonbehalfby</summary>
			public const string LkCampaignModifiedonbehalfby = "lk_campaign_modifiedonbehalfby";

			/// <summary>1:N lk_campaignactivity_createdby</summary>
			public const string LkCampaignactivityCreatedby = "lk_campaignactivity_createdby";

			/// <summary>1:N lk_campaignactivity_createdonbehalfby</summary>
			public const string LkCampaignactivityCreatedonbehalfby = "lk_campaignactivity_createdonbehalfby";

			/// <summary>1:N lk_campaignactivity_modifiedby</summary>
			public const string LkCampaignactivityModifiedby = "lk_campaignactivity_modifiedby";

			/// <summary>1:N lk_campaignactivity_modifiedonbehalfby</summary>
			public const string LkCampaignactivityModifiedonbehalfby = "lk_campaignactivity_modifiedonbehalfby";

			/// <summary>1:N lk_campaignresponse_createdby</summary>
			public const string LkCampaignresponseCreatedby = "lk_campaignresponse_createdby";

			/// <summary>1:N lk_campaignresponse_createdonbehalfby</summary>
			public const string LkCampaignresponseCreatedonbehalfby = "lk_campaignresponse_createdonbehalfby";

			/// <summary>1:N lk_campaignresponse_modifiedby</summary>
			public const string LkCampaignresponseModifiedby = "lk_campaignresponse_modifiedby";

			/// <summary>1:N lk_campaignresponse_modifiedonbehalfby</summary>
			public const string LkCampaignresponseModifiedonbehalfby = "lk_campaignresponse_modifiedonbehalfby";

			/// <summary>1:N lk_catalog_createdby</summary>
			public const string LkCatalogCreatedby = "lk_catalog_createdby";

			/// <summary>1:N lk_catalog_createdonbehalfby</summary>
			public const string LkCatalogCreatedonbehalfby = "lk_catalog_createdonbehalfby";

			/// <summary>1:N lk_catalog_modifiedby</summary>
			public const string LkCatalogModifiedby = "lk_catalog_modifiedby";

			/// <summary>1:N lk_catalog_modifiedonbehalfby</summary>
			public const string LkCatalogModifiedonbehalfby = "lk_catalog_modifiedonbehalfby";

			/// <summary>1:N lk_catalogassignment_createdby</summary>
			public const string LkCatalogassignmentCreatedby = "lk_catalogassignment_createdby";

			/// <summary>1:N lk_catalogassignment_createdonbehalfby</summary>
			public const string LkCatalogassignmentCreatedonbehalfby = "lk_catalogassignment_createdonbehalfby";

			/// <summary>1:N lk_catalogassignment_modifiedby</summary>
			public const string LkCatalogassignmentModifiedby = "lk_catalogassignment_modifiedby";

			/// <summary>1:N lk_catalogassignment_modifiedonbehalfby</summary>
			public const string LkCatalogassignmentModifiedonbehalfby = "lk_catalogassignment_modifiedonbehalfby";

			/// <summary>1:N lk_category_createdby</summary>
			public const string LkCategoryCreatedby = "lk_category_createdby";

			/// <summary>1:N lk_category_createdonbehalfby</summary>
			public const string LkCategoryCreatedonbehalfby = "lk_category_createdonbehalfby";

			/// <summary>1:N lk_category_modifiedby</summary>
			public const string LkCategoryModifiedby = "lk_category_modifiedby";

			/// <summary>1:N lk_category_modifiedonbehalfby</summary>
			public const string LkCategoryModifiedonbehalfby = "lk_category_modifiedonbehalfby";

			/// <summary>1:N lk_characteristic_createdby</summary>
			public const string LkCharacteristicCreatedby = "lk_characteristic_createdby";

			/// <summary>1:N lk_characteristic_createdonbehalfby</summary>
			public const string LkCharacteristicCreatedonbehalfby = "lk_characteristic_createdonbehalfby";

			/// <summary>1:N lk_characteristic_modifiedby</summary>
			public const string LkCharacteristicModifiedby = "lk_characteristic_modifiedby";

			/// <summary>1:N lk_characteristic_modifiedonbehalfby</summary>
			public const string LkCharacteristicModifiedonbehalfby = "lk_characteristic_modifiedonbehalfby";

			/// <summary>1:N lk_columnmapping_createdby</summary>
			public const string LkColumnmappingCreatedby = "lk_columnmapping_createdby";

			/// <summary>1:N lk_columnmapping_createdonbehalfby</summary>
			public const string LkColumnmappingCreatedonbehalfby = "lk_columnmapping_createdonbehalfby";

			/// <summary>1:N lk_columnmapping_modifiedby</summary>
			public const string LkColumnmappingModifiedby = "lk_columnmapping_modifiedby";

			/// <summary>1:N lk_columnmapping_modifiedonbehalfby</summary>
			public const string LkColumnmappingModifiedonbehalfby = "lk_columnmapping_modifiedonbehalfby";

			/// <summary>1:N lk_competitor_createdonbehalfby</summary>
			public const string LkCompetitorCreatedonbehalfby = "lk_competitor_createdonbehalfby";

			/// <summary>1:N lk_competitor_modifiedonbehalfby</summary>
			public const string LkCompetitorModifiedonbehalfby = "lk_competitor_modifiedonbehalfby";

			/// <summary>1:N lk_competitoraddress_createdonbehalfby</summary>
			public const string LkCompetitoraddressCreatedonbehalfby = "lk_competitoraddress_createdonbehalfby";

			/// <summary>1:N lk_competitoraddress_modifiedonbehalfby</summary>
			public const string LkCompetitoraddressModifiedonbehalfby = "lk_competitoraddress_modifiedonbehalfby";

			/// <summary>1:N lk_competitoraddressbase_createdby</summary>
			public const string LkCompetitoraddressbaseCreatedby = "lk_competitoraddressbase_createdby";

			/// <summary>1:N lk_competitoraddressbase_modifiedby</summary>
			public const string LkCompetitoraddressbaseModifiedby = "lk_competitoraddressbase_modifiedby";

			/// <summary>1:N lk_competitorbase_createdby</summary>
			public const string LkCompetitorbaseCreatedby = "lk_competitorbase_createdby";

			/// <summary>1:N lk_competitorbase_modifiedby</summary>
			public const string LkCompetitorbaseModifiedby = "lk_competitorbase_modifiedby";

			/// <summary>1:N lk_connectionbase_createdonbehalfby</summary>
			public const string LkConnectionbaseCreatedonbehalfby = "lk_connectionbase_createdonbehalfby";

			/// <summary>1:N lk_connectionbase_modifiedonbehalfby</summary>
			public const string LkConnectionbaseModifiedonbehalfby = "lk_connectionbase_modifiedonbehalfby";

			/// <summary>1:N lk_connectionreference_createdby</summary>
			public const string LkConnectionreferenceCreatedby = "lk_connectionreference_createdby";

			/// <summary>1:N lk_connectionreference_createdonbehalfby</summary>
			public const string LkConnectionreferenceCreatedonbehalfby = "lk_connectionreference_createdonbehalfby";

			/// <summary>1:N lk_connectionreference_modifiedby</summary>
			public const string LkConnectionreferenceModifiedby = "lk_connectionreference_modifiedby";

			/// <summary>1:N lk_connectionreference_modifiedonbehalfby</summary>
			public const string LkConnectionreferenceModifiedonbehalfby = "lk_connectionreference_modifiedonbehalfby";

			/// <summary>1:N lk_connectionrolebase_createdonbehalfby</summary>
			public const string LkConnectionrolebaseCreatedonbehalfby = "lk_connectionrolebase_createdonbehalfby";

			/// <summary>1:N lk_connectionrolebase_modifiedonbehalfby</summary>
			public const string LkConnectionrolebaseModifiedonbehalfby = "lk_connectionrolebase_modifiedonbehalfby";

			/// <summary>1:N lk_connector_createdby</summary>
			public const string LkConnectorCreatedby = "lk_connector_createdby";

			/// <summary>1:N lk_connector_createdonbehalfby</summary>
			public const string LkConnectorCreatedonbehalfby = "lk_connector_createdonbehalfby";

			/// <summary>1:N lk_connector_modifiedby</summary>
			public const string LkConnectorModifiedby = "lk_connector_modifiedby";

			/// <summary>1:N lk_connector_modifiedonbehalfby</summary>
			public const string LkConnectorModifiedonbehalfby = "lk_connector_modifiedonbehalfby";

			/// <summary>1:N lk_constraintbasedgroup_createdby</summary>
			public const string LkConstraintbasedgroupCreatedby = "lk_constraintbasedgroup_createdby";

			/// <summary>1:N lk_constraintbasedgroup_createdonbehalfby</summary>
			public const string LkConstraintbasedgroupCreatedonbehalfby = "lk_constraintbasedgroup_createdonbehalfby";

			/// <summary>1:N lk_constraintbasedgroup_modifiedby</summary>
			public const string LkConstraintbasedgroupModifiedby = "lk_constraintbasedgroup_modifiedby";

			/// <summary>1:N lk_constraintbasedgroup_modifiedonbehalfby</summary>
			public const string LkConstraintbasedgroupModifiedonbehalfby = "lk_constraintbasedgroup_modifiedonbehalfby";

			/// <summary>1:N lk_contact_createdonbehalfby</summary>
			public const string LkContactCreatedonbehalfby = "lk_contact_createdonbehalfby";

			/// <summary>1:N lk_contact_modifiedonbehalfby</summary>
			public const string LkContactModifiedonbehalfby = "lk_contact_modifiedonbehalfby";

			/// <summary>1:N lk_contactbase_createdby</summary>
			public const string LkContactbaseCreatedby = "lk_contactbase_createdby";

			/// <summary>1:N lk_contactbase_modifiedby</summary>
			public const string LkContactbaseModifiedby = "lk_contactbase_modifiedby";

			/// <summary>1:N lk_contract_createdonbehalfby</summary>
			public const string LkContractCreatedonbehalfby = "lk_contract_createdonbehalfby";

			/// <summary>1:N lk_contract_modifiedonbehalfby</summary>
			public const string LkContractModifiedonbehalfby = "lk_contract_modifiedonbehalfby";

			/// <summary>1:N lk_contractbase_createdby</summary>
			public const string LkContractbaseCreatedby = "lk_contractbase_createdby";

			/// <summary>1:N lk_contractbase_modifiedby</summary>
			public const string LkContractbaseModifiedby = "lk_contractbase_modifiedby";

			/// <summary>1:N lk_contractdetail_createdonbehalfby</summary>
			public const string LkContractdetailCreatedonbehalfby = "lk_contractdetail_createdonbehalfby";

			/// <summary>1:N lk_contractdetail_modifiedonbehalfby</summary>
			public const string LkContractdetailModifiedonbehalfby = "lk_contractdetail_modifiedonbehalfby";

			/// <summary>1:N lk_contractdetailbase_createdby</summary>
			public const string LkContractdetailbaseCreatedby = "lk_contractdetailbase_createdby";

			/// <summary>1:N lk_contractdetailbase_modifiedby</summary>
			public const string LkContractdetailbaseModifiedby = "lk_contractdetailbase_modifiedby";

			/// <summary>1:N lk_contracttemplate_createdonbehalfby</summary>
			public const string LkContracttemplateCreatedonbehalfby = "lk_contracttemplate_createdonbehalfby";

			/// <summary>1:N lk_contracttemplate_modifiedonbehalfby</summary>
			public const string LkContracttemplateModifiedonbehalfby = "lk_contracttemplate_modifiedonbehalfby";

			/// <summary>1:N lk_contracttemplatebase_createdby</summary>
			public const string LkContracttemplatebaseCreatedby = "lk_contracttemplatebase_createdby";

			/// <summary>1:N lk_contracttemplatebase_modifiedby</summary>
			public const string LkContracttemplatebaseModifiedby = "lk_contracttemplatebase_modifiedby";

			/// <summary>1:N lk_conversationtranscript_createdby</summary>
			public const string LkConversationtranscriptCreatedby = "lk_conversationtranscript_createdby";

			/// <summary>1:N lk_conversationtranscript_createdonbehalfby</summary>
			public const string LkConversationtranscriptCreatedonbehalfby = "lk_conversationtranscript_createdonbehalfby";

			/// <summary>1:N lk_conversationtranscript_modifiedby</summary>
			public const string LkConversationtranscriptModifiedby = "lk_conversationtranscript_modifiedby";

			/// <summary>1:N lk_conversationtranscript_modifiedonbehalfby</summary>
			public const string LkConversationtranscriptModifiedonbehalfby = "lk_conversationtranscript_modifiedonbehalfby";

			/// <summary>1:N lk_customapi_createdby</summary>
			public const string LkCustomapiCreatedby = "lk_customapi_createdby";

			/// <summary>1:N lk_customapi_createdonbehalfby</summary>
			public const string LkCustomapiCreatedonbehalfby = "lk_customapi_createdonbehalfby";

			/// <summary>1:N lk_customapi_modifiedby</summary>
			public const string LkCustomapiModifiedby = "lk_customapi_modifiedby";

			/// <summary>1:N lk_customapi_modifiedonbehalfby</summary>
			public const string LkCustomapiModifiedonbehalfby = "lk_customapi_modifiedonbehalfby";

			/// <summary>1:N lk_customapirequestparameter_createdby</summary>
			public const string LkCustomapirequestparameterCreatedby = "lk_customapirequestparameter_createdby";

			/// <summary>1:N lk_customapirequestparameter_createdonbehalfby</summary>
			public const string LkCustomapirequestparameterCreatedonbehalfby = "lk_customapirequestparameter_createdonbehalfby";

			/// <summary>1:N lk_customapirequestparameter_modifiedby</summary>
			public const string LkCustomapirequestparameterModifiedby = "lk_customapirequestparameter_modifiedby";

			/// <summary>1:N lk_customapirequestparameter_modifiedonbehalfby</summary>
			public const string LkCustomapirequestparameterModifiedonbehalfby = "lk_customapirequestparameter_modifiedonbehalfby";

			/// <summary>1:N lk_customapiresponseproperty_createdby</summary>
			public const string LkCustomapiresponsepropertyCreatedby = "lk_customapiresponseproperty_createdby";

			/// <summary>1:N lk_customapiresponseproperty_createdonbehalfby</summary>
			public const string LkCustomapiresponsepropertyCreatedonbehalfby = "lk_customapiresponseproperty_createdonbehalfby";

			/// <summary>1:N lk_customapiresponseproperty_modifiedby</summary>
			public const string LkCustomapiresponsepropertyModifiedby = "lk_customapiresponseproperty_modifiedby";

			/// <summary>1:N lk_customapiresponseproperty_modifiedonbehalfby</summary>
			public const string LkCustomapiresponsepropertyModifiedonbehalfby = "lk_customapiresponseproperty_modifiedonbehalfby";

			/// <summary>1:N lk_customcontrol_createdby</summary>
			public const string LkCustomcontrolCreatedby = "lk_customcontrol_createdby";

			/// <summary>1:N lk_customcontrol_createdonbehalfby</summary>
			public const string LkCustomcontrolCreatedonbehalfby = "lk_customcontrol_createdonbehalfby";

			/// <summary>1:N lk_customcontrol_modifiedby</summary>
			public const string LkCustomcontrolModifiedby = "lk_customcontrol_modifiedby";

			/// <summary>1:N lk_customcontrol_modifiedonbehalfby</summary>
			public const string LkCustomcontrolModifiedonbehalfby = "lk_customcontrol_modifiedonbehalfby";

			/// <summary>1:N lk_customcontroldefaultconfig_createdby</summary>
			public const string LkCustomcontroldefaultconfigCreatedby = "lk_customcontroldefaultconfig_createdby";

			/// <summary>1:N lk_customcontroldefaultconfig_createdonbehalfby</summary>
			public const string LkCustomcontroldefaultconfigCreatedonbehalfby = "lk_customcontroldefaultconfig_createdonbehalfby";

			/// <summary>1:N lk_customcontroldefaultconfig_modifiedby</summary>
			public const string LkCustomcontroldefaultconfigModifiedby = "lk_customcontroldefaultconfig_modifiedby";

			/// <summary>1:N lk_customcontroldefaultconfig_modifiedonbehalfby</summary>
			public const string LkCustomcontroldefaultconfigModifiedonbehalfby = "lk_customcontroldefaultconfig_modifiedonbehalfby";

			/// <summary>1:N lk_customcontrolresource_createdby</summary>
			public const string LkCustomcontrolresourceCreatedby = "lk_customcontrolresource_createdby";

			/// <summary>1:N lk_customcontrolresource_createdonbehalfby</summary>
			public const string LkCustomcontrolresourceCreatedonbehalfby = "lk_customcontrolresource_createdonbehalfby";

			/// <summary>1:N lk_customcontrolresource_modifiedby</summary>
			public const string LkCustomcontrolresourceModifiedby = "lk_customcontrolresource_modifiedby";

			/// <summary>1:N lk_customcontrolresource_modifiedonbehalfby</summary>
			public const string LkCustomcontrolresourceModifiedonbehalfby = "lk_customcontrolresource_modifiedonbehalfby";

			/// <summary>1:N lk_customeraddress_createdonbehalfby</summary>
			public const string LkCustomeraddressCreatedonbehalfby = "lk_customeraddress_createdonbehalfby";

			/// <summary>1:N lk_customeraddress_modifiedonbehalfby</summary>
			public const string LkCustomeraddressModifiedonbehalfby = "lk_customeraddress_modifiedonbehalfby";

			/// <summary>1:N lk_customeraddressbase_createdby</summary>
			public const string LkCustomeraddressbaseCreatedby = "lk_customeraddressbase_createdby";

			/// <summary>1:N lk_customeraddressbase_modifiedby</summary>
			public const string LkCustomeraddressbaseModifiedby = "lk_customeraddressbase_modifiedby";

			/// <summary>1:N lk_datalakefolder_createdby</summary>
			public const string LkDatalakefolderCreatedby = "lk_datalakefolder_createdby";

			/// <summary>1:N lk_datalakefolder_createdonbehalfby</summary>
			public const string LkDatalakefolderCreatedonbehalfby = "lk_datalakefolder_createdonbehalfby";

			/// <summary>1:N lk_datalakefolder_modifiedby</summary>
			public const string LkDatalakefolderModifiedby = "lk_datalakefolder_modifiedby";

			/// <summary>1:N lk_datalakefolder_modifiedonbehalfby</summary>
			public const string LkDatalakefolderModifiedonbehalfby = "lk_datalakefolder_modifiedonbehalfby";

			/// <summary>1:N lk_datalakefolderpermission_createdby</summary>
			public const string LkDatalakefolderpermissionCreatedby = "lk_datalakefolderpermission_createdby";

			/// <summary>1:N lk_datalakefolderpermission_createdonbehalfby</summary>
			public const string LkDatalakefolderpermissionCreatedonbehalfby = "lk_datalakefolderpermission_createdonbehalfby";

			/// <summary>1:N lk_datalakefolderpermission_modifiedby</summary>
			public const string LkDatalakefolderpermissionModifiedby = "lk_datalakefolderpermission_modifiedby";

			/// <summary>1:N lk_datalakefolderpermission_modifiedonbehalfby</summary>
			public const string LkDatalakefolderpermissionModifiedonbehalfby = "lk_datalakefolderpermission_modifiedonbehalfby";

			/// <summary>1:N lk_datalakeworkspace_createdby</summary>
			public const string LkDatalakeworkspaceCreatedby = "lk_datalakeworkspace_createdby";

			/// <summary>1:N lk_datalakeworkspace_createdonbehalfby</summary>
			public const string LkDatalakeworkspaceCreatedonbehalfby = "lk_datalakeworkspace_createdonbehalfby";

			/// <summary>1:N lk_datalakeworkspace_modifiedby</summary>
			public const string LkDatalakeworkspaceModifiedby = "lk_datalakeworkspace_modifiedby";

			/// <summary>1:N lk_datalakeworkspace_modifiedonbehalfby</summary>
			public const string LkDatalakeworkspaceModifiedonbehalfby = "lk_datalakeworkspace_modifiedonbehalfby";

			/// <summary>1:N lk_datalakeworkspacepermission_createdby</summary>
			public const string LkDatalakeworkspacepermissionCreatedby = "lk_datalakeworkspacepermission_createdby";

			/// <summary>1:N lk_datalakeworkspacepermission_createdonbehalfby</summary>
			public const string LkDatalakeworkspacepermissionCreatedonbehalfby = "lk_datalakeworkspacepermission_createdonbehalfby";

			/// <summary>1:N lk_datalakeworkspacepermission_modifiedby</summary>
			public const string LkDatalakeworkspacepermissionModifiedby = "lk_datalakeworkspacepermission_modifiedby";

			/// <summary>1:N lk_datalakeworkspacepermission_modifiedonbehalfby</summary>
			public const string LkDatalakeworkspacepermissionModifiedonbehalfby = "lk_datalakeworkspacepermission_modifiedonbehalfby";

			/// <summary>1:N lk_discount_createdonbehalfby</summary>
			public const string LkDiscountCreatedonbehalfby = "lk_discount_createdonbehalfby";

			/// <summary>1:N lk_discount_modifiedonbehalfby</summary>
			public const string LkDiscountModifiedonbehalfby = "lk_discount_modifiedonbehalfby";

			/// <summary>1:N lk_discountbase_createdby</summary>
			public const string LkDiscountbaseCreatedby = "lk_discountbase_createdby";

			/// <summary>1:N lk_discountbase_modifiedby</summary>
			public const string LkDiscountbaseModifiedby = "lk_discountbase_modifiedby";

			/// <summary>1:N lk_discounttype_createdonbehalfby</summary>
			public const string LkDiscounttypeCreatedonbehalfby = "lk_discounttype_createdonbehalfby";

			/// <summary>1:N lk_discounttype_modifiedonbehalfby</summary>
			public const string LkDiscounttypeModifiedonbehalfby = "lk_discounttype_modifiedonbehalfby";

			/// <summary>1:N lk_discounttypebase_createdby</summary>
			public const string LkDiscounttypebaseCreatedby = "lk_discounttypebase_createdby";

			/// <summary>1:N lk_discounttypebase_modifiedby</summary>
			public const string LkDiscounttypebaseModifiedby = "lk_discounttypebase_modifiedby";

			/// <summary>1:N lk_DisplayStringbase_createdby</summary>
			public const string LkDisplayStringbaseCreatedby = "lk_DisplayStringbase_createdby";

			/// <summary>1:N lk_DisplayStringbase_createdonbehalfby</summary>
			public const string LkDisplayStringbaseCreatedonbehalfby = "lk_DisplayStringbase_createdonbehalfby";

			/// <summary>1:N lk_DisplayStringbase_modifiedby</summary>
			public const string LkDisplayStringbaseModifiedby = "lk_DisplayStringbase_modifiedby";

			/// <summary>1:N lk_DisplayStringbase_modifiedonbehalfby</summary>
			public const string LkDisplayStringbaseModifiedonbehalfby = "lk_DisplayStringbase_modifiedonbehalfby";

			/// <summary>1:N lk_documenttemplatebase_createdby</summary>
			public const string LkDocumenttemplatebaseCreatedby = "lk_documenttemplatebase_createdby";

			/// <summary>1:N lk_documenttemplatebase_createdonbehalfby</summary>
			public const string LkDocumenttemplatebaseCreatedonbehalfby = "lk_documenttemplatebase_createdonbehalfby";

			/// <summary>1:N lk_documenttemplatebase_modifiedby</summary>
			public const string LkDocumenttemplatebaseModifiedby = "lk_documenttemplatebase_modifiedby";

			/// <summary>1:N lk_documenttemplatebase_modifiedonbehalfby</summary>
			public const string LkDocumenttemplatebaseModifiedonbehalfby = "lk_documenttemplatebase_modifiedonbehalfby";

			/// <summary>1:N lk_duplicaterule_createdonbehalfby</summary>
			public const string LkDuplicateruleCreatedonbehalfby = "lk_duplicaterule_createdonbehalfby";

			/// <summary>1:N lk_duplicaterule_modifiedonbehalfby</summary>
			public const string LkDuplicateruleModifiedonbehalfby = "lk_duplicaterule_modifiedonbehalfby";

			/// <summary>1:N lk_duplicaterulebase_createdby</summary>
			public const string LkDuplicaterulebaseCreatedby = "lk_duplicaterulebase_createdby";

			/// <summary>1:N lk_duplicaterulebase_modifiedby</summary>
			public const string LkDuplicaterulebaseModifiedby = "lk_duplicaterulebase_modifiedby";

			/// <summary>1:N lk_duplicaterulecondition_createdonbehalfby</summary>
			public const string LkDuplicateruleconditionCreatedonbehalfby = "lk_duplicaterulecondition_createdonbehalfby";

			/// <summary>1:N lk_duplicaterulecondition_modifiedonbehalfby</summary>
			public const string LkDuplicateruleconditionModifiedonbehalfby = "lk_duplicaterulecondition_modifiedonbehalfby";

			/// <summary>1:N lk_duplicateruleconditionbase_createdby</summary>
			public const string LkDuplicateruleconditionbaseCreatedby = "lk_duplicateruleconditionbase_createdby";

			/// <summary>1:N lk_duplicateruleconditionbase_modifiedby</summary>
			public const string LkDuplicateruleconditionbaseModifiedby = "lk_duplicateruleconditionbase_modifiedby";

			/// <summary>1:N lk_DynamicProperty_createdby</summary>
			public const string LkDynamicPropertyCreatedby = "lk_DynamicProperty_createdby";

			/// <summary>1:N lk_DynamicProperty_createdonbehalfby</summary>
			public const string LkDynamicPropertyCreatedonbehalfby = "lk_DynamicProperty_createdonbehalfby";

			/// <summary>1:N lk_DynamicProperty_modifiedby</summary>
			public const string LkDynamicPropertyModifiedby = "lk_DynamicProperty_modifiedby";

			/// <summary>1:N lk_DynamicProperty_modifiedonbehalfby</summary>
			public const string LkDynamicPropertyModifiedonbehalfby = "lk_DynamicProperty_modifiedonbehalfby";

			/// <summary>1:N lk_DynamicPropertyAssociationattribute_createdby</summary>
			public const string LkDynamicPropertyAssociationattributeCreatedby = "lk_DynamicPropertyAssociationattribute_createdby";

			/// <summary>1:N lk_DynamicPropertyAssociationattribute_CreatedOnBehalfBy</summary>
			public const string LkDynamicPropertyAssociationattributeCreatedOnBehalfBy = "lk_DynamicPropertyAssociationattribute_CreatedOnBehalfBy";

			/// <summary>1:N lk_DynamicPropertyAssociationattribute_ModifiedBy</summary>
			public const string LkDynamicPropertyAssociationattributeModifiedBy = "lk_DynamicPropertyAssociationattribute_ModifiedBy";

			/// <summary>1:N lk_DynamicPropertyAssociationattribute_ModifiedOnBehalfBy</summary>
			public const string LkDynamicPropertyAssociationattributeModifiedOnBehalfBy = "lk_DynamicPropertyAssociationattribute_ModifiedOnBehalfBy";

			/// <summary>1:N lk_Dynamicpropertyinsatanceattribute_createdonbehalfby</summary>
			public const string LkDynamicpropertyinsatanceattributeCreatedonbehalfby = "lk_Dynamicpropertyinsatanceattribute_createdonbehalfby";

			/// <summary>1:N lk_Dynamicpropertyinsatanceattribute_ModifiedBy</summary>
			public const string LkDynamicpropertyinsatanceattributeModifiedBy = "lk_Dynamicpropertyinsatanceattribute_ModifiedBy";

			/// <summary>1:N lk_Dynamicpropertyinsatanceattribute_ModifiedOnBehalfBy</summary>
			public const string LkDynamicpropertyinsatanceattributeModifiedOnBehalfBy = "lk_Dynamicpropertyinsatanceattribute_ModifiedOnBehalfBy";

			/// <summary>1:N lk_DynamicPropertyOptionSetItem_createdby</summary>
			public const string LkDynamicPropertyOptionSetItemCreatedby = "lk_DynamicPropertyOptionSetItem_createdby";

			/// <summary>1:N lk_DynamicPropertyOptionSetItem_createdonbehalfby</summary>
			public const string LkDynamicPropertyOptionSetItemCreatedonbehalfby = "lk_DynamicPropertyOptionSetItem_createdonbehalfby";

			/// <summary>1:N lk_DynamicPropertyOptionSetItem_modifiedby</summary>
			public const string LkDynamicPropertyOptionSetItemModifiedby = "lk_DynamicPropertyOptionSetItem_modifiedby";

			/// <summary>1:N lk_DynamicPropertyOptionSetItem_modifiedonbehalfby</summary>
			public const string LkDynamicPropertyOptionSetItemModifiedonbehalfby = "lk_DynamicPropertyOptionSetItem_modifiedonbehalfby";

			/// <summary>1:N lk_email_createdby</summary>
			public const string LkEmailCreatedby = "lk_email_createdby";

			/// <summary>1:N lk_email_createdonbehalfby</summary>
			public const string LkEmailCreatedonbehalfby = "lk_email_createdonbehalfby";

			/// <summary>1:N lk_email_modifiedby</summary>
			public const string LkEmailModifiedby = "lk_email_modifiedby";

			/// <summary>1:N lk_email_modifiedonbehalfby</summary>
			public const string LkEmailModifiedonbehalfby = "lk_email_modifiedonbehalfby";

			/// <summary>1:N lk_emailserverprofile_createdby</summary>
			public const string LkEmailserverprofileCreatedby = "lk_emailserverprofile_createdby";

			/// <summary>1:N lk_emailserverprofile_createdonbehalfby</summary>
			public const string LkEmailserverprofileCreatedonbehalfby = "lk_emailserverprofile_createdonbehalfby";

			/// <summary>1:N lk_emailserverprofile_modifiedby</summary>
			public const string LkEmailserverprofileModifiedby = "lk_emailserverprofile_modifiedby";

			/// <summary>1:N lk_emailserverprofile_modifiedonbehalfby</summary>
			public const string LkEmailserverprofileModifiedonbehalfby = "lk_emailserverprofile_modifiedonbehalfby";

			/// <summary>1:N lk_entitlement_createdby</summary>
			public const string LkEntitlementCreatedby = "lk_entitlement_createdby";

			/// <summary>1:N lk_entitlement_createdonbehalfby</summary>
			public const string LkEntitlementCreatedonbehalfby = "lk_entitlement_createdonbehalfby";

			/// <summary>1:N lk_entitlement_modifiedby</summary>
			public const string LkEntitlementModifiedby = "lk_entitlement_modifiedby";

			/// <summary>1:N lk_entitlement_modifiedonbehalfby</summary>
			public const string LkEntitlementModifiedonbehalfby = "lk_entitlement_modifiedonbehalfby";

			/// <summary>1:N lk_entitlementchannel_createdby</summary>
			public const string LkEntitlementchannelCreatedby = "lk_entitlementchannel_createdby";

			/// <summary>1:N lk_entitlementchannel_createdonbehalfby</summary>
			public const string LkEntitlementchannelCreatedonbehalfby = "lk_entitlementchannel_createdonbehalfby";

			/// <summary>1:N lk_entitlementchannel_modifiedby</summary>
			public const string LkEntitlementchannelModifiedby = "lk_entitlementchannel_modifiedby";

			/// <summary>1:N lk_entitlementchannel_modifiedonbehalfby</summary>
			public const string LkEntitlementchannelModifiedonbehalfby = "lk_entitlementchannel_modifiedonbehalfby";

			/// <summary>1:N lk_entitlemententityallocationtypemapping_createdby</summary>
			public const string LkEntitlemententityallocationtypemappingCreatedby = "lk_entitlemententityallocationtypemapping_createdby";

			/// <summary>1:N lk_entitlemententityallocationtypemapping_createdonbehalfby</summary>
			public const string LkEntitlemententityallocationtypemappingCreatedonbehalfby = "lk_entitlemententityallocationtypemapping_createdonbehalfby";

			/// <summary>1:N lk_entitlemententityallocationtypemapping_modifiedby</summary>
			public const string LkEntitlemententityallocationtypemappingModifiedby = "lk_entitlemententityallocationtypemapping_modifiedby";

			/// <summary>1:N lk_entitlemententityallocationtypemapping_modifiedonbehalfby</summary>
			public const string LkEntitlemententityallocationtypemappingModifiedonbehalfby = "lk_entitlemententityallocationtypemapping_modifiedonbehalfby";

			/// <summary>1:N lk_entitlementtemplate_createdby</summary>
			public const string LkEntitlementtemplateCreatedby = "lk_entitlementtemplate_createdby";

			/// <summary>1:N lk_entitlementtemplate_createdonbehalfby</summary>
			public const string LkEntitlementtemplateCreatedonbehalfby = "lk_entitlementtemplate_createdonbehalfby";

			/// <summary>1:N lk_entitlementtemplate_modifiedby</summary>
			public const string LkEntitlementtemplateModifiedby = "lk_entitlementtemplate_modifiedby";

			/// <summary>1:N lk_entitlementtemplate_modifiedonbehalfby</summary>
			public const string LkEntitlementtemplateModifiedonbehalfby = "lk_entitlementtemplate_modifiedonbehalfby";

			/// <summary>1:N lk_entitlementtemplatechannel_createdby</summary>
			public const string LkEntitlementtemplatechannelCreatedby = "lk_entitlementtemplatechannel_createdby";

			/// <summary>1:N lk_entitlementtemplatechannel_createdonbehalfby</summary>
			public const string LkEntitlementtemplatechannelCreatedonbehalfby = "lk_entitlementtemplatechannel_createdonbehalfby";

			/// <summary>1:N lk_entitlementtemplatechannel_modifiedby</summary>
			public const string LkEntitlementtemplatechannelModifiedby = "lk_entitlementtemplatechannel_modifiedby";

			/// <summary>1:N lk_entitlementtemplatechannel_modifiedonbehalfby</summary>
			public const string LkEntitlementtemplatechannelModifiedonbehalfby = "lk_entitlementtemplatechannel_modifiedonbehalfby";

			/// <summary>1:N lk_environmentvariabledefinition_createdby</summary>
			public const string LkEnvironmentvariabledefinitionCreatedby = "lk_environmentvariabledefinition_createdby";

			/// <summary>1:N lk_environmentvariabledefinition_createdonbehalfby</summary>
			public const string LkEnvironmentvariabledefinitionCreatedonbehalfby = "lk_environmentvariabledefinition_createdonbehalfby";

			/// <summary>1:N lk_environmentvariabledefinition_modifiedby</summary>
			public const string LkEnvironmentvariabledefinitionModifiedby = "lk_environmentvariabledefinition_modifiedby";

			/// <summary>1:N lk_environmentvariabledefinition_modifiedonbehalfby</summary>
			public const string LkEnvironmentvariabledefinitionModifiedonbehalfby = "lk_environmentvariabledefinition_modifiedonbehalfby";

			/// <summary>1:N lk_environmentvariablevalue_createdby</summary>
			public const string LkEnvironmentvariablevalueCreatedby = "lk_environmentvariablevalue_createdby";

			/// <summary>1:N lk_environmentvariablevalue_createdonbehalfby</summary>
			public const string LkEnvironmentvariablevalueCreatedonbehalfby = "lk_environmentvariablevalue_createdonbehalfby";

			/// <summary>1:N lk_environmentvariablevalue_modifiedby</summary>
			public const string LkEnvironmentvariablevalueModifiedby = "lk_environmentvariablevalue_modifiedby";

			/// <summary>1:N lk_environmentvariablevalue_modifiedonbehalfby</summary>
			public const string LkEnvironmentvariablevalueModifiedonbehalfby = "lk_environmentvariablevalue_modifiedonbehalfby";

			/// <summary>1:N lk_equipment_createdby</summary>
			public const string LkEquipmentCreatedby = "lk_equipment_createdby";

			/// <summary>1:N lk_equipment_createdonbehalfby</summary>
			public const string LkEquipmentCreatedonbehalfby = "lk_equipment_createdonbehalfby";

			/// <summary>1:N lk_equipment_modifiedby</summary>
			public const string LkEquipmentModifiedby = "lk_equipment_modifiedby";

			/// <summary>1:N lk_equipment_modifiedonbehalfby</summary>
			public const string LkEquipmentModifiedonbehalfby = "lk_equipment_modifiedonbehalfby";

			/// <summary>1:N lk_expiredprocess_createdby</summary>
			public const string LkExpiredprocessCreatedby = "lk_expiredprocess_createdby";

			/// <summary>1:N lk_expiredprocess_createdonbehalfby</summary>
			public const string LkExpiredprocessCreatedonbehalfby = "lk_expiredprocess_createdonbehalfby";

			/// <summary>1:N lk_expiredprocess_modifiedby</summary>
			public const string LkExpiredprocessModifiedby = "lk_expiredprocess_modifiedby";

			/// <summary>1:N lk_expiredprocess_modifiedonbehalfby</summary>
			public const string LkExpiredprocessModifiedonbehalfby = "lk_expiredprocess_modifiedonbehalfby";

			/// <summary>1:N lk_exportsolutionupload_createdby</summary>
			public const string LkExportsolutionuploadCreatedby = "lk_exportsolutionupload_createdby";

			/// <summary>1:N lk_exportsolutionupload_createdonbehalfby</summary>
			public const string LkExportsolutionuploadCreatedonbehalfby = "lk_exportsolutionupload_createdonbehalfby";

			/// <summary>1:N lk_exportsolutionupload_modifiedby</summary>
			public const string LkExportsolutionuploadModifiedby = "lk_exportsolutionupload_modifiedby";

			/// <summary>1:N lk_exportsolutionupload_modifiedonbehalfby</summary>
			public const string LkExportsolutionuploadModifiedonbehalfby = "lk_exportsolutionupload_modifiedonbehalfby";

			/// <summary>1:N lk_fax_createdby</summary>
			public const string LkFaxCreatedby = "lk_fax_createdby";

			/// <summary>1:N lk_fax_createdonbehalfby</summary>
			public const string LkFaxCreatedonbehalfby = "lk_fax_createdonbehalfby";

			/// <summary>1:N lk_fax_modifiedby</summary>
			public const string LkFaxModifiedby = "lk_fax_modifiedby";

			/// <summary>1:N lk_fax_modifiedonbehalfby</summary>
			public const string LkFaxModifiedonbehalfby = "lk_fax_modifiedonbehalfby";

			/// <summary>1:N lk_feedback_closedby</summary>
			public const string LkFeedbackClosedby = "lk_feedback_closedby";

			/// <summary>1:N lk_feedback_createdby</summary>
			public const string LkFeedbackCreatedby = "lk_feedback_createdby";

			/// <summary>1:N lk_feedback_createdonbehalfby</summary>
			public const string LkFeedbackCreatedonbehalfby = "lk_feedback_createdonbehalfby";

			/// <summary>1:N lk_feedback_modifiedby</summary>
			public const string LkFeedbackModifiedby = "lk_feedback_modifiedby";

			/// <summary>1:N lk_feedback_modifiedonbehalfby</summary>
			public const string LkFeedbackModifiedonbehalfby = "lk_feedback_modifiedonbehalfby";

			/// <summary>1:N lk_fieldsecurityprofile_createdby</summary>
			public const string LkFieldsecurityprofileCreatedby = "lk_fieldsecurityprofile_createdby";

			/// <summary>1:N lk_fieldsecurityprofile_createdonbehalfby</summary>
			public const string LkFieldsecurityprofileCreatedonbehalfby = "lk_fieldsecurityprofile_createdonbehalfby";

			/// <summary>1:N lk_fieldsecurityprofile_modifiedby</summary>
			public const string LkFieldsecurityprofileModifiedby = "lk_fieldsecurityprofile_modifiedby";

			/// <summary>1:N lk_fieldsecurityprofile_modifiedonbehalfby</summary>
			public const string LkFieldsecurityprofileModifiedonbehalfby = "lk_fieldsecurityprofile_modifiedonbehalfby";

			/// <summary>1:N lk_fixedmonthlyfiscalcalendar_createdby</summary>
			public const string LkFixedmonthlyfiscalcalendarCreatedby = "lk_fixedmonthlyfiscalcalendar_createdby";

			/// <summary>1:N lk_fixedmonthlyfiscalcalendar_createdonbehalfby</summary>
			public const string LkFixedmonthlyfiscalcalendarCreatedonbehalfby = "lk_fixedmonthlyfiscalcalendar_createdonbehalfby";

			/// <summary>1:N lk_fixedmonthlyfiscalcalendar_modifiedby</summary>
			public const string LkFixedmonthlyfiscalcalendarModifiedby = "lk_fixedmonthlyfiscalcalendar_modifiedby";

			/// <summary>1:N lk_fixedmonthlyfiscalcalendar_modifiedonbehalfby</summary>
			public const string LkFixedmonthlyfiscalcalendarModifiedonbehalfby = "lk_fixedmonthlyfiscalcalendar_modifiedonbehalfby";

			/// <summary>1:N lk_fixedmonthlyfiscalcalendar_salespersonid</summary>
			public const string LkFixedmonthlyfiscalcalendarSalespersonid = "lk_fixedmonthlyfiscalcalendar_salespersonid";

			/// <summary>1:N lk_flowsession_createdby</summary>
			public const string LkFlowsessionCreatedby = "lk_flowsession_createdby";

			/// <summary>1:N lk_flowsession_createdonbehalfby</summary>
			public const string LkFlowsessionCreatedonbehalfby = "lk_flowsession_createdonbehalfby";

			/// <summary>1:N lk_flowsession_modifiedby</summary>
			public const string LkFlowsessionModifiedby = "lk_flowsession_modifiedby";

			/// <summary>1:N lk_flowsession_modifiedonbehalfby</summary>
			public const string LkFlowsessionModifiedonbehalfby = "lk_flowsession_modifiedonbehalfby";

			/// <summary>1:N lk_goal_createdby</summary>
			public const string LkGoalCreatedby = "lk_goal_createdby";

			/// <summary>1:N lk_goal_createdonbehalfby</summary>
			public const string LkGoalCreatedonbehalfby = "lk_goal_createdonbehalfby";

			/// <summary>1:N lk_goal_modifiedby</summary>
			public const string LkGoalModifiedby = "lk_goal_modifiedby";

			/// <summary>1:N lk_goal_modifiedonbehalfby</summary>
			public const string LkGoalModifiedonbehalfby = "lk_goal_modifiedonbehalfby";

			/// <summary>1:N lk_goalrollupquery_createdby</summary>
			public const string LkGoalrollupqueryCreatedby = "lk_goalrollupquery_createdby";

			/// <summary>1:N lk_goalrollupquery_createdonbehalfby</summary>
			public const string LkGoalrollupqueryCreatedonbehalfby = "lk_goalrollupquery_createdonbehalfby";

			/// <summary>1:N lk_goalrollupquery_modifiedby</summary>
			public const string LkGoalrollupqueryModifiedby = "lk_goalrollupquery_modifiedby";

			/// <summary>1:N lk_goalrollupquery_modifiedonbehalfby</summary>
			public const string LkGoalrollupqueryModifiedonbehalfby = "lk_goalrollupquery_modifiedonbehalfby";

			/// <summary>1:N lk_import_createdonbehalfby</summary>
			public const string LkImportCreatedonbehalfby = "lk_import_createdonbehalfby";

			/// <summary>1:N lk_import_modifiedonbehalfby</summary>
			public const string LkImportModifiedonbehalfby = "lk_import_modifiedonbehalfby";

			/// <summary>1:N lk_importbase_createdby</summary>
			public const string LkImportbaseCreatedby = "lk_importbase_createdby";

			/// <summary>1:N lk_importbase_modifiedby</summary>
			public const string LkImportbaseModifiedby = "lk_importbase_modifiedby";

			/// <summary>1:N lk_importdata_createdonbehalfby</summary>
			public const string LkImportdataCreatedonbehalfby = "lk_importdata_createdonbehalfby";

			/// <summary>1:N lk_importdata_modifiedonbehalfby</summary>
			public const string LkImportdataModifiedonbehalfby = "lk_importdata_modifiedonbehalfby";

			/// <summary>1:N lk_importdatabase_createdby</summary>
			public const string LkImportdatabaseCreatedby = "lk_importdatabase_createdby";

			/// <summary>1:N lk_importdatabase_modifiedby</summary>
			public const string LkImportdatabaseModifiedby = "lk_importdatabase_modifiedby";

			/// <summary>1:N lk_importentitymapping_createdby</summary>
			public const string LkImportentitymappingCreatedby = "lk_importentitymapping_createdby";

			/// <summary>1:N lk_importentitymapping_createdonbehalfby</summary>
			public const string LkImportentitymappingCreatedonbehalfby = "lk_importentitymapping_createdonbehalfby";

			/// <summary>1:N lk_importentitymapping_modifiedby</summary>
			public const string LkImportentitymappingModifiedby = "lk_importentitymapping_modifiedby";

			/// <summary>1:N lk_importentitymapping_modifiedonbehalfby</summary>
			public const string LkImportentitymappingModifiedonbehalfby = "lk_importentitymapping_modifiedonbehalfby";

			/// <summary>1:N lk_importfilebase_createdby</summary>
			public const string LkImportfilebaseCreatedby = "lk_importfilebase_createdby";

			/// <summary>1:N lk_importfilebase_createdonbehalfby</summary>
			public const string LkImportfilebaseCreatedonbehalfby = "lk_importfilebase_createdonbehalfby";

			/// <summary>1:N lk_importfilebase_modifiedby</summary>
			public const string LkImportfilebaseModifiedby = "lk_importfilebase_modifiedby";

			/// <summary>1:N lk_importfilebase_modifiedonbehalfby</summary>
			public const string LkImportfilebaseModifiedonbehalfby = "lk_importfilebase_modifiedonbehalfby";

			/// <summary>1:N lk_importjobbase_createdby</summary>
			public const string LkImportjobbaseCreatedby = "lk_importjobbase_createdby";

			/// <summary>1:N lk_importjobbase_createdonbehalfby</summary>
			public const string LkImportjobbaseCreatedonbehalfby = "lk_importjobbase_createdonbehalfby";

			/// <summary>1:N lk_importjobbase_modifiedby</summary>
			public const string LkImportjobbaseModifiedby = "lk_importjobbase_modifiedby";

			/// <summary>1:N lk_importjobbase_modifiedonbehalfby</summary>
			public const string LkImportjobbaseModifiedonbehalfby = "lk_importjobbase_modifiedonbehalfby";

			/// <summary>1:N lk_importlog_createdonbehalfby</summary>
			public const string LkImportlogCreatedonbehalfby = "lk_importlog_createdonbehalfby";

			/// <summary>1:N lk_importlog_modifiedonbehalfby</summary>
			public const string LkImportlogModifiedonbehalfby = "lk_importlog_modifiedonbehalfby";

			/// <summary>1:N lk_importlogbase_createdby</summary>
			public const string LkImportlogbaseCreatedby = "lk_importlogbase_createdby";

			/// <summary>1:N lk_importlogbase_modifiedby</summary>
			public const string LkImportlogbaseModifiedby = "lk_importlogbase_modifiedby";

			/// <summary>1:N lk_importmap_createdonbehalfby</summary>
			public const string LkImportmapCreatedonbehalfby = "lk_importmap_createdonbehalfby";

			/// <summary>1:N lk_importmap_modifiedonbehalfby</summary>
			public const string LkImportmapModifiedonbehalfby = "lk_importmap_modifiedonbehalfby";

			/// <summary>1:N lk_importmapbase_createdby</summary>
			public const string LkImportmapbaseCreatedby = "lk_importmapbase_createdby";

			/// <summary>1:N lk_importmapbase_modifiedby</summary>
			public const string LkImportmapbaseModifiedby = "lk_importmapbase_modifiedby";

			/// <summary>1:N lk_incidentbase_createdby</summary>
			public const string LkIncidentbaseCreatedby = "lk_incidentbase_createdby";

			/// <summary>1:N lk_incidentbase_createdonbehalfby</summary>
			public const string LkIncidentbaseCreatedonbehalfby = "lk_incidentbase_createdonbehalfby";

			/// <summary>1:N lk_incidentbase_modifiedby</summary>
			public const string LkIncidentbaseModifiedby = "lk_incidentbase_modifiedby";

			/// <summary>1:N lk_incidentbase_modifiedonbehalfby</summary>
			public const string LkIncidentbaseModifiedonbehalfby = "lk_incidentbase_modifiedonbehalfby";

			/// <summary>1:N lk_incidentresolution_createdby</summary>
			public const string LkIncidentresolutionCreatedby = "lk_incidentresolution_createdby";

			/// <summary>1:N lk_incidentresolution_createdonbehalfby</summary>
			public const string LkIncidentresolutionCreatedonbehalfby = "lk_incidentresolution_createdonbehalfby";

			/// <summary>1:N lk_incidentresolution_modifiedby</summary>
			public const string LkIncidentresolutionModifiedby = "lk_incidentresolution_modifiedby";

			/// <summary>1:N lk_incidentresolution_modifiedonbehalfby</summary>
			public const string LkIncidentresolutionModifiedonbehalfby = "lk_incidentresolution_modifiedonbehalfby";

			/// <summary>1:N lk_interactionforemail_createdby</summary>
			public const string LkInteractionforemailCreatedby = "lk_interactionforemail_createdby";

			/// <summary>1:N lk_interactionforemail_createdonbehalfby</summary>
			public const string LkInteractionforemailCreatedonbehalfby = "lk_interactionforemail_createdonbehalfby";

			/// <summary>1:N lk_interactionforemail_modifiedby</summary>
			public const string LkInteractionforemailModifiedby = "lk_interactionforemail_modifiedby";

			/// <summary>1:N lk_interactionforemail_modifiedonbehalfby</summary>
			public const string LkInteractionforemailModifiedonbehalfby = "lk_interactionforemail_modifiedonbehalfby";

			/// <summary>1:N lk_invoice_createdonbehalfby</summary>
			public const string LkInvoiceCreatedonbehalfby = "lk_invoice_createdonbehalfby";

			/// <summary>1:N lk_invoice_modifiedonbehalfby</summary>
			public const string LkInvoiceModifiedonbehalfby = "lk_invoice_modifiedonbehalfby";

			/// <summary>1:N lk_invoicebase_createdby</summary>
			public const string LkInvoicebaseCreatedby = "lk_invoicebase_createdby";

			/// <summary>1:N lk_invoicebase_modifiedby</summary>
			public const string LkInvoicebaseModifiedby = "lk_invoicebase_modifiedby";

			/// <summary>1:N lk_invoicedetail_createdonbehalfby</summary>
			public const string LkInvoicedetailCreatedonbehalfby = "lk_invoicedetail_createdonbehalfby";

			/// <summary>1:N lk_invoicedetail_modifiedonbehalfby</summary>
			public const string LkInvoicedetailModifiedonbehalfby = "lk_invoicedetail_modifiedonbehalfby";

			/// <summary>1:N lk_invoicedetailbase_createdby</summary>
			public const string LkInvoicedetailbaseCreatedby = "lk_invoicedetailbase_createdby";

			/// <summary>1:N lk_invoicedetailbase_modifiedby</summary>
			public const string LkInvoicedetailbaseModifiedby = "lk_invoicedetailbase_modifiedby";

			/// <summary>1:N lk_kbarticle_createdonbehalfby</summary>
			public const string LkKbarticleCreatedonbehalfby = "lk_kbarticle_createdonbehalfby";

			/// <summary>1:N lk_kbarticle_modifiedonbehalfby</summary>
			public const string LkKbarticleModifiedonbehalfby = "lk_kbarticle_modifiedonbehalfby";

			/// <summary>1:N lk_kbarticlebase_createdby</summary>
			public const string LkKbarticlebaseCreatedby = "lk_kbarticlebase_createdby";

			/// <summary>1:N lk_kbarticlebase_modifiedby</summary>
			public const string LkKbarticlebaseModifiedby = "lk_kbarticlebase_modifiedby";

			/// <summary>1:N lk_kbarticlecomment_createdonbehalfby</summary>
			public const string LkKbarticlecommentCreatedonbehalfby = "lk_kbarticlecomment_createdonbehalfby";

			/// <summary>1:N lk_kbarticlecomment_modifiedonbehalfby</summary>
			public const string LkKbarticlecommentModifiedonbehalfby = "lk_kbarticlecomment_modifiedonbehalfby";

			/// <summary>1:N lk_kbarticlecommentbase_createdby</summary>
			public const string LkKbarticlecommentbaseCreatedby = "lk_kbarticlecommentbase_createdby";

			/// <summary>1:N lk_kbarticlecommentbase_modifiedby</summary>
			public const string LkKbarticlecommentbaseModifiedby = "lk_kbarticlecommentbase_modifiedby";

			/// <summary>1:N lk_kbarticletemplate_createdonbehalfby</summary>
			public const string LkKbarticletemplateCreatedonbehalfby = "lk_kbarticletemplate_createdonbehalfby";

			/// <summary>1:N lk_kbarticletemplate_modifiedonbehalfby</summary>
			public const string LkKbarticletemplateModifiedonbehalfby = "lk_kbarticletemplate_modifiedonbehalfby";

			/// <summary>1:N lk_kbarticletemplatebase_createdby</summary>
			public const string LkKbarticletemplatebaseCreatedby = "lk_kbarticletemplatebase_createdby";

			/// <summary>1:N lk_kbarticletemplatebase_modifiedby</summary>
			public const string LkKbarticletemplatebaseModifiedby = "lk_kbarticletemplatebase_modifiedby";

			/// <summary>1:N lk_knowledgearticle_createdby</summary>
			public const string LkKnowledgearticleCreatedby = "lk_knowledgearticle_createdby";

			/// <summary>1:N lk_knowledgearticle_createdonbehalfby</summary>
			public const string LkKnowledgearticleCreatedonbehalfby = "lk_knowledgearticle_createdonbehalfby";

			/// <summary>1:N lk_knowledgearticle_modifiedby</summary>
			public const string LkKnowledgearticleModifiedby = "lk_knowledgearticle_modifiedby";

			/// <summary>1:N lk_knowledgearticle_modifiedonbehalfby</summary>
			public const string LkKnowledgearticleModifiedonbehalfby = "lk_knowledgearticle_modifiedonbehalfby";

			/// <summary>1:N lk_knowledgearticleincident_createdby</summary>
			public const string LkKnowledgearticleincidentCreatedby = "lk_knowledgearticleincident_createdby";

			/// <summary>1:N lk_knowledgearticleincident_createdonbehalfby</summary>
			public const string LkKnowledgearticleincidentCreatedonbehalfby = "lk_knowledgearticleincident_createdonbehalfby";

			/// <summary>1:N lk_knowledgearticleincident_modifiedby</summary>
			public const string LkKnowledgearticleincidentModifiedby = "lk_knowledgearticleincident_modifiedby";

			/// <summary>1:N lk_knowledgearticleincident_modifiedonbehalfby</summary>
			public const string LkKnowledgearticleincidentModifiedonbehalfby = "lk_knowledgearticleincident_modifiedonbehalfby";

			/// <summary>1:N lk_knowledgearticleviews_createdby</summary>
			public const string LkKnowledgearticleviewsCreatedby = "lk_knowledgearticleviews_createdby";

			/// <summary>1:N lk_knowledgearticleviews_createdonbehalfby</summary>
			public const string LkKnowledgearticleviewsCreatedonbehalfby = "lk_knowledgearticleviews_createdonbehalfby";

			/// <summary>1:N lk_knowledgearticleviews_modifiedby</summary>
			public const string LkKnowledgearticleviewsModifiedby = "lk_knowledgearticleviews_modifiedby";

			/// <summary>1:N lk_knowledgearticleviews_modifiedonbehalfby</summary>
			public const string LkKnowledgearticleviewsModifiedonbehalfby = "lk_knowledgearticleviews_modifiedonbehalfby";

			/// <summary>1:N lk_KnowledgeBaseRecord_createdby</summary>
			public const string LkKnowledgeBaseRecordCreatedby = "lk_KnowledgeBaseRecord_createdby";

			/// <summary>1:N lk_KnowledgeBaseRecord_createdonbehalfby</summary>
			public const string LkKnowledgeBaseRecordCreatedonbehalfby = "lk_KnowledgeBaseRecord_createdonbehalfby";

			/// <summary>1:N lk_KnowledgeBaseRecord_modifiedby</summary>
			public const string LkKnowledgeBaseRecordModifiedby = "lk_KnowledgeBaseRecord_modifiedby";

			/// <summary>1:N lk_KnowledgeBaseRecord_modifiedonbehalfby</summary>
			public const string LkKnowledgeBaseRecordModifiedonbehalfby = "lk_KnowledgeBaseRecord_modifiedonbehalfby";

			/// <summary>1:N lk_lead_createdonbehalfby</summary>
			public const string LkLeadCreatedonbehalfby = "lk_lead_createdonbehalfby";

			/// <summary>1:N lk_lead_modifiedonbehalfby</summary>
			public const string LkLeadModifiedonbehalfby = "lk_lead_modifiedonbehalfby";

			/// <summary>1:N lk_leadaddress_createdonbehalfby</summary>
			public const string LkLeadaddressCreatedonbehalfby = "lk_leadaddress_createdonbehalfby";

			/// <summary>1:N lk_leadaddress_modifiedonbehalfby</summary>
			public const string LkLeadaddressModifiedonbehalfby = "lk_leadaddress_modifiedonbehalfby";

			/// <summary>1:N lk_leadaddressbase_createdby</summary>
			public const string LkLeadaddressbaseCreatedby = "lk_leadaddressbase_createdby";

			/// <summary>1:N lk_leadaddressbase_modifiedby</summary>
			public const string LkLeadaddressbaseModifiedby = "lk_leadaddressbase_modifiedby";

			/// <summary>1:N lk_leadbase_createdby</summary>
			public const string LkLeadbaseCreatedby = "lk_leadbase_createdby";

			/// <summary>1:N lk_leadbase_modifiedby</summary>
			public const string LkLeadbaseModifiedby = "lk_leadbase_modifiedby";

			/// <summary>1:N lk_leadtoopportunitysalesprocess_createdby</summary>
			public const string LkLeadtoopportunitysalesprocessCreatedby = "lk_leadtoopportunitysalesprocess_createdby";

			/// <summary>1:N lk_leadtoopportunitysalesprocess_createdonbehalfby</summary>
			public const string LkLeadtoopportunitysalesprocessCreatedonbehalfby = "lk_leadtoopportunitysalesprocess_createdonbehalfby";

			/// <summary>1:N lk_leadtoopportunitysalesprocess_modifiedby</summary>
			public const string LkLeadtoopportunitysalesprocessModifiedby = "lk_leadtoopportunitysalesprocess_modifiedby";

			/// <summary>1:N lk_leadtoopportunitysalesprocess_modifiedonbehalfby</summary>
			public const string LkLeadtoopportunitysalesprocessModifiedonbehalfby = "lk_leadtoopportunitysalesprocess_modifiedonbehalfby";

			/// <summary>1:N lk_letter_createdby</summary>
			public const string LkLetterCreatedby = "lk_letter_createdby";

			/// <summary>1:N lk_letter_createdonbehalfby</summary>
			public const string LkLetterCreatedonbehalfby = "lk_letter_createdonbehalfby";

			/// <summary>1:N lk_letter_modifiedby</summary>
			public const string LkLetterModifiedby = "lk_letter_modifiedby";

			/// <summary>1:N lk_letter_modifiedonbehalfby</summary>
			public const string LkLetterModifiedonbehalfby = "lk_letter_modifiedonbehalfby";

			/// <summary>1:N lk_list_createdby</summary>
			public const string LkListCreatedby = "lk_list_createdby";

			/// <summary>1:N lk_list_createdonbehalfby</summary>
			public const string LkListCreatedonbehalfby = "lk_list_createdonbehalfby";

			/// <summary>1:N lk_list_modifiedby</summary>
			public const string LkListModifiedby = "lk_list_modifiedby";

			/// <summary>1:N lk_list_modifiedonbehalfby</summary>
			public const string LkListModifiedonbehalfby = "lk_list_modifiedonbehalfby";

			/// <summary>1:N lk_listoperation_createdby</summary>
			public const string LkListoperationCreatedby = "lk_listoperation_createdby";

			/// <summary>1:N lk_listoperation_createdonbehalfby</summary>
			public const string LkListoperationCreatedonbehalfby = "lk_listoperation_createdonbehalfby";

			/// <summary>1:N lk_listoperation_modifiedby</summary>
			public const string LkListoperationModifiedby = "lk_listoperation_modifiedby";

			/// <summary>1:N lk_listoperation_modifiedonbehalfby</summary>
			public const string LkListoperationModifiedonbehalfby = "lk_listoperation_modifiedonbehalfby";

			/// <summary>1:N lk_lookupmapping_createdby</summary>
			public const string LkLookupmappingCreatedby = "lk_lookupmapping_createdby";

			/// <summary>1:N lk_lookupmapping_createdonbehalfby</summary>
			public const string LkLookupmappingCreatedonbehalfby = "lk_lookupmapping_createdonbehalfby";

			/// <summary>1:N lk_lookupmapping_modifiedby</summary>
			public const string LkLookupmappingModifiedby = "lk_lookupmapping_modifiedby";

			/// <summary>1:N lk_lookupmapping_modifiedonbehalfby</summary>
			public const string LkLookupmappingModifiedonbehalfby = "lk_lookupmapping_modifiedonbehalfby";

			/// <summary>1:N lk_mailbox_createdby</summary>
			public const string LkMailboxCreatedby = "lk_mailbox_createdby";

			/// <summary>1:N lk_mailbox_createdonbehalfby</summary>
			public const string LkMailboxCreatedonbehalfby = "lk_mailbox_createdonbehalfby";

			/// <summary>1:N lk_mailbox_modifiedby</summary>
			public const string LkMailboxModifiedby = "lk_mailbox_modifiedby";

			/// <summary>1:N lk_mailbox_modifiedonbehalfby</summary>
			public const string LkMailboxModifiedonbehalfby = "lk_mailbox_modifiedonbehalfby";

			/// <summary>1:N lk_mailboxtrackingfolder_createdby</summary>
			public const string LkMailboxtrackingfolderCreatedby = "lk_mailboxtrackingfolder_createdby";

			/// <summary>1:N lk_mailboxtrackingfolder_createdonbehalfby</summary>
			public const string LkMailboxtrackingfolderCreatedonbehalfby = "lk_mailboxtrackingfolder_createdonbehalfby";

			/// <summary>1:N lk_mailboxtrackingfolder_modifiedby</summary>
			public const string LkMailboxtrackingfolderModifiedby = "lk_mailboxtrackingfolder_modifiedby";

			/// <summary>1:N lk_mailboxtrackingfolder_modifiedonbehalfby</summary>
			public const string LkMailboxtrackingfolderModifiedonbehalfby = "lk_mailboxtrackingfolder_modifiedonbehalfby";

			/// <summary>1:N lk_mailmergetemplate_createdonbehalfby</summary>
			public const string LkMailmergetemplateCreatedonbehalfby = "lk_mailmergetemplate_createdonbehalfby";

			/// <summary>1:N lk_mailmergetemplate_modifiedonbehalfby</summary>
			public const string LkMailmergetemplateModifiedonbehalfby = "lk_mailmergetemplate_modifiedonbehalfby";

			/// <summary>1:N lk_mailmergetemplatebase_createdby</summary>
			public const string LkMailmergetemplatebaseCreatedby = "lk_mailmergetemplatebase_createdby";

			/// <summary>1:N lk_mailmergetemplatebase_modifiedby</summary>
			public const string LkMailmergetemplatebaseModifiedby = "lk_mailmergetemplatebase_modifiedby";

			/// <summary>1:N lk_marketingformdisplayattributes_createdby</summary>
			public const string LkMarketingformdisplayattributesCreatedby = "lk_marketingformdisplayattributes_createdby";

			/// <summary>1:N lk_marketingformdisplayattributes_createdonbehalfby</summary>
			public const string LkMarketingformdisplayattributesCreatedonbehalfby = "lk_marketingformdisplayattributes_createdonbehalfby";

			/// <summary>1:N lk_marketingformdisplayattributes_modifiedby</summary>
			public const string LkMarketingformdisplayattributesModifiedby = "lk_marketingformdisplayattributes_modifiedby";

			/// <summary>1:N lk_marketingformdisplayattributes_modifiedonbehalfby</summary>
			public const string LkMarketingformdisplayattributesModifiedonbehalfby = "lk_marketingformdisplayattributes_modifiedonbehalfby";

			/// <summary>1:N lk_metric_createdby</summary>
			public const string LkMetricCreatedby = "lk_metric_createdby";

			/// <summary>1:N lk_metric_createdonbehalfby</summary>
			public const string LkMetricCreatedonbehalfby = "lk_metric_createdonbehalfby";

			/// <summary>1:N lk_metric_modifiedby</summary>
			public const string LkMetricModifiedby = "lk_metric_modifiedby";

			/// <summary>1:N lk_metric_modifiedonbehalfby</summary>
			public const string LkMetricModifiedonbehalfby = "lk_metric_modifiedonbehalfby";

			/// <summary>1:N lk_MobileOfflineProfile_createdby</summary>
			public const string LkMobileOfflineProfileCreatedby = "lk_MobileOfflineProfile_createdby";

			/// <summary>1:N lk_MobileOfflineProfile_createdonbehalfby</summary>
			public const string LkMobileOfflineProfileCreatedonbehalfby = "lk_MobileOfflineProfile_createdonbehalfby";

			/// <summary>1:N lk_MobileOfflineProfile_modifiedby</summary>
			public const string LkMobileOfflineProfileModifiedby = "lk_MobileOfflineProfile_modifiedby";

			/// <summary>1:N lk_MobileOfflineProfile_modifiedonbehalfby</summary>
			public const string LkMobileOfflineProfileModifiedonbehalfby = "lk_MobileOfflineProfile_modifiedonbehalfby";

			/// <summary>1:N lk_MobileOfflineProfileItem_createdby</summary>
			public const string LkMobileOfflineProfileItemCreatedby = "lk_MobileOfflineProfileItem_createdby";

			/// <summary>1:N lk_mobileofflineprofileitem_createdonbehalfby</summary>
			public const string LkMobileofflineprofileitemCreatedonbehalfby = "lk_mobileofflineprofileitem_createdonbehalfby";

			/// <summary>1:N lk_mobileofflineprofileitem_modifiedby</summary>
			public const string LkMobileofflineprofileitemModifiedby = "lk_mobileofflineprofileitem_modifiedby";

			/// <summary>1:N lk_mobileofflineprofileitem_modifiedonbehalfby</summary>
			public const string LkMobileofflineprofileitemModifiedonbehalfby = "lk_mobileofflineprofileitem_modifiedonbehalfby";

			/// <summary>1:N lk_MobileOfflineProfileItemAssociation_createdby</summary>
			public const string LkMobileOfflineProfileItemAssociationCreatedby = "lk_MobileOfflineProfileItemAssociation_createdby";

			/// <summary>1:N lk_mobileofflineprofileitemassociation_createdonbehalfby</summary>
			public const string LkMobileofflineprofileitemassociationCreatedonbehalfby = "lk_mobileofflineprofileitemassociation_createdonbehalfby";

			/// <summary>1:N lk_mobileofflineprofileitemassociation_modifiedby</summary>
			public const string LkMobileofflineprofileitemassociationModifiedby = "lk_mobileofflineprofileitemassociation_modifiedby";

			/// <summary>1:N lk_mobileofflineprofileitemassociation_modifiedonbehalfby</summary>
			public const string LkMobileofflineprofileitemassociationModifiedonbehalfby = "lk_mobileofflineprofileitemassociation_modifiedonbehalfby";

			/// <summary>1:N lk_monthlyfiscalcalendar_createdby</summary>
			public const string LkMonthlyfiscalcalendarCreatedby = "lk_monthlyfiscalcalendar_createdby";

			/// <summary>1:N lk_monthlyfiscalcalendar_createdonbehalfby</summary>
			public const string LkMonthlyfiscalcalendarCreatedonbehalfby = "lk_monthlyfiscalcalendar_createdonbehalfby";

			/// <summary>1:N lk_monthlyfiscalcalendar_modifiedby</summary>
			public const string LkMonthlyfiscalcalendarModifiedby = "lk_monthlyfiscalcalendar_modifiedby";

			/// <summary>1:N lk_monthlyfiscalcalendar_modifiedonbehalfby</summary>
			public const string LkMonthlyfiscalcalendarModifiedonbehalfby = "lk_monthlyfiscalcalendar_modifiedonbehalfby";

			/// <summary>1:N lk_monthlyfiscalcalendar_salespersonid</summary>
			public const string LkMonthlyfiscalcalendarSalespersonid = "lk_monthlyfiscalcalendar_salespersonid";

			/// <summary>1:N lk_msdyn_actioncardregarding_createdby</summary>
			public const string LkMsdynActioncardregardingCreatedby = "lk_msdyn_actioncardregarding_createdby";

			/// <summary>1:N lk_msdyn_actioncardregarding_createdonbehalfby</summary>
			public const string LkMsdynActioncardregardingCreatedonbehalfby = "lk_msdyn_actioncardregarding_createdonbehalfby";

			/// <summary>1:N lk_msdyn_actioncardregarding_modifiedby</summary>
			public const string LkMsdynActioncardregardingModifiedby = "lk_msdyn_actioncardregarding_modifiedby";

			/// <summary>1:N lk_msdyn_actioncardregarding_modifiedonbehalfby</summary>
			public const string LkMsdynActioncardregardingModifiedonbehalfby = "lk_msdyn_actioncardregarding_modifiedonbehalfby";

			/// <summary>1:N lk_msdyn_actioncardrolesetting_createdby</summary>
			public const string LkMsdynActioncardrolesettingCreatedby = "lk_msdyn_actioncardrolesetting_createdby";

			/// <summary>1:N lk_msdyn_actioncardrolesetting_createdonbehalfby</summary>
			public const string LkMsdynActioncardrolesettingCreatedonbehalfby = "lk_msdyn_actioncardrolesetting_createdonbehalfby";

			/// <summary>1:N lk_msdyn_actioncardrolesetting_modifiedby</summary>
			public const string LkMsdynActioncardrolesettingModifiedby = "lk_msdyn_actioncardrolesetting_modifiedby";

			/// <summary>1:N lk_msdyn_actioncardrolesetting_modifiedonbehalfby</summary>
			public const string LkMsdynActioncardrolesettingModifiedonbehalfby = "lk_msdyn_actioncardrolesetting_modifiedonbehalfby";

			/// <summary>1:N lk_msdyn_aibdataset_createdby</summary>
			public const string LkMsdynAibdatasetCreatedby = "lk_msdyn_aibdataset_createdby";

			/// <summary>1:N lk_msdyn_aibdataset_createdonbehalfby</summary>
			public const string LkMsdynAibdatasetCreatedonbehalfby = "lk_msdyn_aibdataset_createdonbehalfby";

			/// <summary>1:N lk_msdyn_aibdataset_modifiedby</summary>
			public const string LkMsdynAibdatasetModifiedby = "lk_msdyn_aibdataset_modifiedby";

			/// <summary>1:N lk_msdyn_aibdataset_modifiedonbehalfby</summary>
			public const string LkMsdynAibdatasetModifiedonbehalfby = "lk_msdyn_aibdataset_modifiedonbehalfby";

			/// <summary>1:N lk_msdyn_aibdatasetfile_createdby</summary>
			public const string LkMsdynAibdatasetfileCreatedby = "lk_msdyn_aibdatasetfile_createdby";

			/// <summary>1:N lk_msdyn_aibdatasetfile_createdonbehalfby</summary>
			public const string LkMsdynAibdatasetfileCreatedonbehalfby = "lk_msdyn_aibdatasetfile_createdonbehalfby";

			/// <summary>1:N lk_msdyn_aibdatasetfile_modifiedby</summary>
			public const string LkMsdynAibdatasetfileModifiedby = "lk_msdyn_aibdatasetfile_modifiedby";

			/// <summary>1:N lk_msdyn_aibdatasetfile_modifiedonbehalfby</summary>
			public const string LkMsdynAibdatasetfileModifiedonbehalfby = "lk_msdyn_aibdatasetfile_modifiedonbehalfby";

			/// <summary>1:N lk_msdyn_aibdatasetrecord_createdby</summary>
			public const string LkMsdynAibdatasetrecordCreatedby = "lk_msdyn_aibdatasetrecord_createdby";

			/// <summary>1:N lk_msdyn_aibdatasetrecord_createdonbehalfby</summary>
			public const string LkMsdynAibdatasetrecordCreatedonbehalfby = "lk_msdyn_aibdatasetrecord_createdonbehalfby";

			/// <summary>1:N lk_msdyn_aibdatasetrecord_modifiedby</summary>
			public const string LkMsdynAibdatasetrecordModifiedby = "lk_msdyn_aibdatasetrecord_modifiedby";

			/// <summary>1:N lk_msdyn_aibdatasetrecord_modifiedonbehalfby</summary>
			public const string LkMsdynAibdatasetrecordModifiedonbehalfby = "lk_msdyn_aibdatasetrecord_modifiedonbehalfby";

			/// <summary>1:N lk_msdyn_aibdatasetscontainer_createdby</summary>
			public const string LkMsdynAibdatasetscontainerCreatedby = "lk_msdyn_aibdatasetscontainer_createdby";

			/// <summary>1:N lk_msdyn_aibdatasetscontainer_createdonbehalfby</summary>
			public const string LkMsdynAibdatasetscontainerCreatedonbehalfby = "lk_msdyn_aibdatasetscontainer_createdonbehalfby";

			/// <summary>1:N lk_msdyn_aibdatasetscontainer_modifiedby</summary>
			public const string LkMsdynAibdatasetscontainerModifiedby = "lk_msdyn_aibdatasetscontainer_modifiedby";

			/// <summary>1:N lk_msdyn_aibdatasetscontainer_modifiedonbehalfby</summary>
			public const string LkMsdynAibdatasetscontainerModifiedonbehalfby = "lk_msdyn_aibdatasetscontainer_modifiedonbehalfby";

			/// <summary>1:N lk_msdyn_aibfile_createdby</summary>
			public const string LkMsdynAibfileCreatedby = "lk_msdyn_aibfile_createdby";

			/// <summary>1:N lk_msdyn_aibfile_createdonbehalfby</summary>
			public const string LkMsdynAibfileCreatedonbehalfby = "lk_msdyn_aibfile_createdonbehalfby";

			/// <summary>1:N lk_msdyn_aibfile_modifiedby</summary>
			public const string LkMsdynAibfileModifiedby = "lk_msdyn_aibfile_modifiedby";

			/// <summary>1:N lk_msdyn_aibfile_modifiedonbehalfby</summary>
			public const string LkMsdynAibfileModifiedonbehalfby = "lk_msdyn_aibfile_modifiedonbehalfby";

			/// <summary>1:N lk_msdyn_aibfileattacheddata_createdby</summary>
			public const string LkMsdynAibfileattacheddataCreatedby = "lk_msdyn_aibfileattacheddata_createdby";

			/// <summary>1:N lk_msdyn_aibfileattacheddata_createdonbehalfby</summary>
			public const string LkMsdynAibfileattacheddataCreatedonbehalfby = "lk_msdyn_aibfileattacheddata_createdonbehalfby";

			/// <summary>1:N lk_msdyn_aibfileattacheddata_modifiedby</summary>
			public const string LkMsdynAibfileattacheddataModifiedby = "lk_msdyn_aibfileattacheddata_modifiedby";

			/// <summary>1:N lk_msdyn_aibfileattacheddata_modifiedonbehalfby</summary>
			public const string LkMsdynAibfileattacheddataModifiedonbehalfby = "lk_msdyn_aibfileattacheddata_modifiedonbehalfby";

			/// <summary>1:N lk_msdyn_aiconfiguration_createdby</summary>
			public const string LkMsdynAiconfigurationCreatedby = "lk_msdyn_aiconfiguration_createdby";

			/// <summary>1:N lk_msdyn_aiconfiguration_createdonbehalfby</summary>
			public const string LkMsdynAiconfigurationCreatedonbehalfby = "lk_msdyn_aiconfiguration_createdonbehalfby";

			/// <summary>1:N lk_msdyn_aiconfiguration_modifiedby</summary>
			public const string LkMsdynAiconfigurationModifiedby = "lk_msdyn_aiconfiguration_modifiedby";

			/// <summary>1:N lk_msdyn_aiconfiguration_modifiedonbehalfby</summary>
			public const string LkMsdynAiconfigurationModifiedonbehalfby = "lk_msdyn_aiconfiguration_modifiedonbehalfby";

			/// <summary>1:N lk_msdyn_aifptrainingdocument_createdby</summary>
			public const string LkMsdynAifptrainingdocumentCreatedby = "lk_msdyn_aifptrainingdocument_createdby";

			/// <summary>1:N lk_msdyn_aifptrainingdocument_createdonbehalfby</summary>
			public const string LkMsdynAifptrainingdocumentCreatedonbehalfby = "lk_msdyn_aifptrainingdocument_createdonbehalfby";

			/// <summary>1:N lk_msdyn_aifptrainingdocument_modifiedby</summary>
			public const string LkMsdynAifptrainingdocumentModifiedby = "lk_msdyn_aifptrainingdocument_modifiedby";

			/// <summary>1:N lk_msdyn_aifptrainingdocument_modifiedonbehalfby</summary>
			public const string LkMsdynAifptrainingdocumentModifiedonbehalfby = "lk_msdyn_aifptrainingdocument_modifiedonbehalfby";

			/// <summary>1:N lk_msdyn_aimodel_createdby</summary>
			public const string LkMsdynAimodelCreatedby = "lk_msdyn_aimodel_createdby";

			/// <summary>1:N lk_msdyn_aimodel_createdonbehalfby</summary>
			public const string LkMsdynAimodelCreatedonbehalfby = "lk_msdyn_aimodel_createdonbehalfby";

			/// <summary>1:N lk_msdyn_aimodel_modifiedby</summary>
			public const string LkMsdynAimodelModifiedby = "lk_msdyn_aimodel_modifiedby";

			/// <summary>1:N lk_msdyn_aimodel_modifiedonbehalfby</summary>
			public const string LkMsdynAimodelModifiedonbehalfby = "lk_msdyn_aimodel_modifiedonbehalfby";

			/// <summary>1:N lk_msdyn_aiodimage_createdby</summary>
			public const string LkMsdynAiodimageCreatedby = "lk_msdyn_aiodimage_createdby";

			/// <summary>1:N lk_msdyn_aiodimage_createdonbehalfby</summary>
			public const string LkMsdynAiodimageCreatedonbehalfby = "lk_msdyn_aiodimage_createdonbehalfby";

			/// <summary>1:N lk_msdyn_aiodimage_modifiedby</summary>
			public const string LkMsdynAiodimageModifiedby = "lk_msdyn_aiodimage_modifiedby";

			/// <summary>1:N lk_msdyn_aiodimage_modifiedonbehalfby</summary>
			public const string LkMsdynAiodimageModifiedonbehalfby = "lk_msdyn_aiodimage_modifiedonbehalfby";

			/// <summary>1:N lk_msdyn_aiodlabel_createdby</summary>
			public const string LkMsdynAiodlabelCreatedby = "lk_msdyn_aiodlabel_createdby";

			/// <summary>1:N lk_msdyn_aiodlabel_createdonbehalfby</summary>
			public const string LkMsdynAiodlabelCreatedonbehalfby = "lk_msdyn_aiodlabel_createdonbehalfby";

			/// <summary>1:N lk_msdyn_aiodlabel_modifiedby</summary>
			public const string LkMsdynAiodlabelModifiedby = "lk_msdyn_aiodlabel_modifiedby";

			/// <summary>1:N lk_msdyn_aiodlabel_modifiedonbehalfby</summary>
			public const string LkMsdynAiodlabelModifiedonbehalfby = "lk_msdyn_aiodlabel_modifiedonbehalfby";

			/// <summary>1:N lk_msdyn_aiodtrainingboundingbox_createdby</summary>
			public const string LkMsdynAiodtrainingboundingboxCreatedby = "lk_msdyn_aiodtrainingboundingbox_createdby";

			/// <summary>1:N lk_msdyn_aiodtrainingboundingbox_createdonbehalfby</summary>
			public const string LkMsdynAiodtrainingboundingboxCreatedonbehalfby = "lk_msdyn_aiodtrainingboundingbox_createdonbehalfby";

			/// <summary>1:N lk_msdyn_aiodtrainingboundingbox_modifiedby</summary>
			public const string LkMsdynAiodtrainingboundingboxModifiedby = "lk_msdyn_aiodtrainingboundingbox_modifiedby";

			/// <summary>1:N lk_msdyn_aiodtrainingboundingbox_modifiedonbehalfby</summary>
			public const string LkMsdynAiodtrainingboundingboxModifiedonbehalfby = "lk_msdyn_aiodtrainingboundingbox_modifiedonbehalfby";

			/// <summary>1:N lk_msdyn_aiodtrainingimage_createdby</summary>
			public const string LkMsdynAiodtrainingimageCreatedby = "lk_msdyn_aiodtrainingimage_createdby";

			/// <summary>1:N lk_msdyn_aiodtrainingimage_createdonbehalfby</summary>
			public const string LkMsdynAiodtrainingimageCreatedonbehalfby = "lk_msdyn_aiodtrainingimage_createdonbehalfby";

			/// <summary>1:N lk_msdyn_aiodtrainingimage_modifiedby</summary>
			public const string LkMsdynAiodtrainingimageModifiedby = "lk_msdyn_aiodtrainingimage_modifiedby";

			/// <summary>1:N lk_msdyn_aiodtrainingimage_modifiedonbehalfby</summary>
			public const string LkMsdynAiodtrainingimageModifiedonbehalfby = "lk_msdyn_aiodtrainingimage_modifiedonbehalfby";

			/// <summary>1:N lk_msdyn_aitemplate_createdby</summary>
			public const string LkMsdynAitemplateCreatedby = "lk_msdyn_aitemplate_createdby";

			/// <summary>1:N lk_msdyn_aitemplate_createdonbehalfby</summary>
			public const string LkMsdynAitemplateCreatedonbehalfby = "lk_msdyn_aitemplate_createdonbehalfby";

			/// <summary>1:N lk_msdyn_aitemplate_modifiedby</summary>
			public const string LkMsdynAitemplateModifiedby = "lk_msdyn_aitemplate_modifiedby";

			/// <summary>1:N lk_msdyn_aitemplate_modifiedonbehalfby</summary>
			public const string LkMsdynAitemplateModifiedonbehalfby = "lk_msdyn_aitemplate_modifiedonbehalfby";

			/// <summary>1:N lk_msdyn_autocapturerule_createdby</summary>
			public const string LkMsdynAutocaptureruleCreatedby = "lk_msdyn_autocapturerule_createdby";

			/// <summary>1:N lk_msdyn_autocapturerule_createdonbehalfby</summary>
			public const string LkMsdynAutocaptureruleCreatedonbehalfby = "lk_msdyn_autocapturerule_createdonbehalfby";

			/// <summary>1:N lk_msdyn_autocapturerule_modifiedby</summary>
			public const string LkMsdynAutocaptureruleModifiedby = "lk_msdyn_autocapturerule_modifiedby";

			/// <summary>1:N lk_msdyn_autocapturerule_modifiedonbehalfby</summary>
			public const string LkMsdynAutocaptureruleModifiedonbehalfby = "lk_msdyn_autocapturerule_modifiedonbehalfby";

			/// <summary>1:N lk_msdyn_autocapturesettings_createdby</summary>
			public const string LkMsdynAutocapturesettingsCreatedby = "lk_msdyn_autocapturesettings_createdby";

			/// <summary>1:N lk_msdyn_autocapturesettings_createdonbehalfby</summary>
			public const string LkMsdynAutocapturesettingsCreatedonbehalfby = "lk_msdyn_autocapturesettings_createdonbehalfby";

			/// <summary>1:N lk_msdyn_autocapturesettings_modifiedby</summary>
			public const string LkMsdynAutocapturesettingsModifiedby = "lk_msdyn_autocapturesettings_modifiedby";

			/// <summary>1:N lk_msdyn_autocapturesettings_modifiedonbehalfby</summary>
			public const string LkMsdynAutocapturesettingsModifiedonbehalfby = "lk_msdyn_autocapturesettings_modifiedonbehalfby";

			/// <summary>1:N lk_msdyn_callablecontext_createdby</summary>
			public const string LkMsdynCallablecontextCreatedby = "lk_msdyn_callablecontext_createdby";

			/// <summary>1:N lk_msdyn_callablecontext_createdonbehalfby</summary>
			public const string LkMsdynCallablecontextCreatedonbehalfby = "lk_msdyn_callablecontext_createdonbehalfby";

			/// <summary>1:N lk_msdyn_callablecontext_modifiedby</summary>
			public const string LkMsdynCallablecontextModifiedby = "lk_msdyn_callablecontext_modifiedby";

			/// <summary>1:N lk_msdyn_callablecontext_modifiedonbehalfby</summary>
			public const string LkMsdynCallablecontextModifiedonbehalfby = "lk_msdyn_callablecontext_modifiedonbehalfby";

			/// <summary>1:N lk_msdyn_collabgraphresource_createdby</summary>
			public const string LkMsdynCollabgraphresourceCreatedby = "lk_msdyn_collabgraphresource_createdby";

			/// <summary>1:N lk_msdyn_collabgraphresource_createdonbehalfby</summary>
			public const string LkMsdynCollabgraphresourceCreatedonbehalfby = "lk_msdyn_collabgraphresource_createdonbehalfby";

			/// <summary>1:N lk_msdyn_collabgraphresource_modifiedby</summary>
			public const string LkMsdynCollabgraphresourceModifiedby = "lk_msdyn_collabgraphresource_modifiedby";

			/// <summary>1:N lk_msdyn_collabgraphresource_modifiedonbehalfby</summary>
			public const string LkMsdynCollabgraphresourceModifiedonbehalfby = "lk_msdyn_collabgraphresource_modifiedonbehalfby";

			/// <summary>1:N lk_msdyn_databaseversion_createdby</summary>
			public const string LkMsdynDatabaseversionCreatedby = "lk_msdyn_databaseversion_createdby";

			/// <summary>1:N lk_msdyn_databaseversion_createdonbehalfby</summary>
			public const string LkMsdynDatabaseversionCreatedonbehalfby = "lk_msdyn_databaseversion_createdonbehalfby";

			/// <summary>1:N lk_msdyn_databaseversion_modifiedby</summary>
			public const string LkMsdynDatabaseversionModifiedby = "lk_msdyn_databaseversion_modifiedby";

			/// <summary>1:N lk_msdyn_databaseversion_modifiedonbehalfby</summary>
			public const string LkMsdynDatabaseversionModifiedonbehalfby = "lk_msdyn_databaseversion_modifiedonbehalfby";

			/// <summary>1:N lk_msdyn_entityrankingrule_createdby</summary>
			public const string LkMsdynEntityrankingruleCreatedby = "lk_msdyn_entityrankingrule_createdby";

			/// <summary>1:N lk_msdyn_entityrankingrule_createdonbehalfby</summary>
			public const string LkMsdynEntityrankingruleCreatedonbehalfby = "lk_msdyn_entityrankingrule_createdonbehalfby";

			/// <summary>1:N lk_msdyn_entityrankingrule_modifiedby</summary>
			public const string LkMsdynEntityrankingruleModifiedby = "lk_msdyn_entityrankingrule_modifiedby";

			/// <summary>1:N lk_msdyn_entityrankingrule_modifiedonbehalfby</summary>
			public const string LkMsdynEntityrankingruleModifiedonbehalfby = "lk_msdyn_entityrankingrule_modifiedonbehalfby";

			/// <summary>1:N lk_msdyn_federatedarticle_createdby</summary>
			public const string LkMsdynFederatedarticleCreatedby = "lk_msdyn_federatedarticle_createdby";

			/// <summary>1:N lk_msdyn_federatedarticle_createdonbehalfby</summary>
			public const string LkMsdynFederatedarticleCreatedonbehalfby = "lk_msdyn_federatedarticle_createdonbehalfby";

			/// <summary>1:N lk_msdyn_federatedarticle_modifiedby</summary>
			public const string LkMsdynFederatedarticleModifiedby = "lk_msdyn_federatedarticle_modifiedby";

			/// <summary>1:N lk_msdyn_federatedarticle_modifiedonbehalfby</summary>
			public const string LkMsdynFederatedarticleModifiedonbehalfby = "lk_msdyn_federatedarticle_modifiedonbehalfby";

			/// <summary>1:N lk_msdyn_federatedarticleincident_createdby</summary>
			public const string LkMsdynFederatedarticleincidentCreatedby = "lk_msdyn_federatedarticleincident_createdby";

			/// <summary>1:N lk_msdyn_federatedarticleincident_createdonbehalfby</summary>
			public const string LkMsdynFederatedarticleincidentCreatedonbehalfby = "lk_msdyn_federatedarticleincident_createdonbehalfby";

			/// <summary>1:N lk_msdyn_federatedarticleincident_modifiedby</summary>
			public const string LkMsdynFederatedarticleincidentModifiedby = "lk_msdyn_federatedarticleincident_modifiedby";

			/// <summary>1:N lk_msdyn_federatedarticleincident_modifiedonbehalfby</summary>
			public const string LkMsdynFederatedarticleincidentModifiedonbehalfby = "lk_msdyn_federatedarticleincident_modifiedonbehalfby";

			/// <summary>1:N lk_msdyn_flowcardtype_createdby</summary>
			public const string LkMsdynFlowcardtypeCreatedby = "lk_msdyn_flowcardtype_createdby";

			/// <summary>1:N lk_msdyn_flowcardtype_createdonbehalfby</summary>
			public const string LkMsdynFlowcardtypeCreatedonbehalfby = "lk_msdyn_flowcardtype_createdonbehalfby";

			/// <summary>1:N lk_msdyn_flowcardtype_modifiedby</summary>
			public const string LkMsdynFlowcardtypeModifiedby = "lk_msdyn_flowcardtype_modifiedby";

			/// <summary>1:N lk_msdyn_flowcardtype_modifiedonbehalfby</summary>
			public const string LkMsdynFlowcardtypeModifiedonbehalfby = "lk_msdyn_flowcardtype_modifiedonbehalfby";

			/// <summary>1:N lk_msdyn_helppage_createdby</summary>
			public const string LkMsdynHelppageCreatedby = "lk_msdyn_helppage_createdby";

			/// <summary>1:N lk_msdyn_helppage_createdonbehalfby</summary>
			public const string LkMsdynHelppageCreatedonbehalfby = "lk_msdyn_helppage_createdonbehalfby";

			/// <summary>1:N lk_msdyn_helppage_modifiedby</summary>
			public const string LkMsdynHelppageModifiedby = "lk_msdyn_helppage_modifiedby";

			/// <summary>1:N lk_msdyn_helppage_modifiedonbehalfby</summary>
			public const string LkMsdynHelppageModifiedonbehalfby = "lk_msdyn_helppage_modifiedonbehalfby";

			/// <summary>1:N lk_msdyn_icebreakersconfig_createdby</summary>
			public const string LkMsdynIcebreakersconfigCreatedby = "lk_msdyn_icebreakersconfig_createdby";

			/// <summary>1:N lk_msdyn_icebreakersconfig_createdonbehalfby</summary>
			public const string LkMsdynIcebreakersconfigCreatedonbehalfby = "lk_msdyn_icebreakersconfig_createdonbehalfby";

			/// <summary>1:N lk_msdyn_icebreakersconfig_modifiedby</summary>
			public const string LkMsdynIcebreakersconfigModifiedby = "lk_msdyn_icebreakersconfig_modifiedby";

			/// <summary>1:N lk_msdyn_icebreakersconfig_modifiedonbehalfby</summary>
			public const string LkMsdynIcebreakersconfigModifiedonbehalfby = "lk_msdyn_icebreakersconfig_modifiedonbehalfby";

			/// <summary>1:N lk_msdyn_kmfederatedsearchconfig_createdby</summary>
			public const string LkMsdynKmfederatedsearchconfigCreatedby = "lk_msdyn_kmfederatedsearchconfig_createdby";

			/// <summary>1:N lk_msdyn_kmfederatedsearchconfig_createdonbehalfby</summary>
			public const string LkMsdynKmfederatedsearchconfigCreatedonbehalfby = "lk_msdyn_kmfederatedsearchconfig_createdonbehalfby";

			/// <summary>1:N lk_msdyn_kmfederatedsearchconfig_modifiedby</summary>
			public const string LkMsdynKmfederatedsearchconfigModifiedby = "lk_msdyn_kmfederatedsearchconfig_modifiedby";

			/// <summary>1:N lk_msdyn_kmfederatedsearchconfig_modifiedonbehalfby</summary>
			public const string LkMsdynKmfederatedsearchconfigModifiedonbehalfby = "lk_msdyn_kmfederatedsearchconfig_modifiedonbehalfby";

			/// <summary>1:N lk_msdyn_knowledgearticleimage_createdby</summary>
			public const string LkMsdynKnowledgearticleimageCreatedby = "lk_msdyn_knowledgearticleimage_createdby";

			/// <summary>1:N lk_msdyn_knowledgearticleimage_createdonbehalfby</summary>
			public const string LkMsdynKnowledgearticleimageCreatedonbehalfby = "lk_msdyn_knowledgearticleimage_createdonbehalfby";

			/// <summary>1:N lk_msdyn_knowledgearticleimage_modifiedby</summary>
			public const string LkMsdynKnowledgearticleimageModifiedby = "lk_msdyn_knowledgearticleimage_modifiedby";

			/// <summary>1:N lk_msdyn_knowledgearticleimage_modifiedonbehalfby</summary>
			public const string LkMsdynKnowledgearticleimageModifiedonbehalfby = "lk_msdyn_knowledgearticleimage_modifiedonbehalfby";

			/// <summary>1:N lk_msdyn_knowledgearticletemplate_createdby</summary>
			public const string LkMsdynKnowledgearticletemplateCreatedby = "lk_msdyn_knowledgearticletemplate_createdby";

			/// <summary>1:N lk_msdyn_knowledgearticletemplate_createdonbehalfby</summary>
			public const string LkMsdynKnowledgearticletemplateCreatedonbehalfby = "lk_msdyn_knowledgearticletemplate_createdonbehalfby";

			/// <summary>1:N lk_msdyn_knowledgearticletemplate_modifiedby</summary>
			public const string LkMsdynKnowledgearticletemplateModifiedby = "lk_msdyn_knowledgearticletemplate_modifiedby";

			/// <summary>1:N lk_msdyn_knowledgearticletemplate_modifiedonbehalfby</summary>
			public const string LkMsdynKnowledgearticletemplateModifiedonbehalfby = "lk_msdyn_knowledgearticletemplate_modifiedonbehalfby";

			/// <summary>1:N lk_msdyn_knowledgeinteractioninsight_createdby</summary>
			public const string LkMsdynKnowledgeinteractioninsightCreatedby = "lk_msdyn_knowledgeinteractioninsight_createdby";

			/// <summary>1:N lk_msdyn_knowledgeinteractioninsight_createdonbehalfby</summary>
			public const string LkMsdynKnowledgeinteractioninsightCreatedonbehalfby = "lk_msdyn_knowledgeinteractioninsight_createdonbehalfby";

			/// <summary>1:N lk_msdyn_knowledgeinteractioninsight_modifiedby</summary>
			public const string LkMsdynKnowledgeinteractioninsightModifiedby = "lk_msdyn_knowledgeinteractioninsight_modifiedby";

			/// <summary>1:N lk_msdyn_knowledgeinteractioninsight_modifiedonbehalfby</summary>
			public const string LkMsdynKnowledgeinteractioninsightModifiedonbehalfby = "lk_msdyn_knowledgeinteractioninsight_modifiedonbehalfby";

			/// <summary>1:N lk_msdyn_knowledgesearchinsight_createdby</summary>
			public const string LkMsdynKnowledgesearchinsightCreatedby = "lk_msdyn_knowledgesearchinsight_createdby";

			/// <summary>1:N lk_msdyn_knowledgesearchinsight_createdonbehalfby</summary>
			public const string LkMsdynKnowledgesearchinsightCreatedonbehalfby = "lk_msdyn_knowledgesearchinsight_createdonbehalfby";

			/// <summary>1:N lk_msdyn_knowledgesearchinsight_modifiedby</summary>
			public const string LkMsdynKnowledgesearchinsightModifiedby = "lk_msdyn_knowledgesearchinsight_modifiedby";

			/// <summary>1:N lk_msdyn_knowledgesearchinsight_modifiedonbehalfby</summary>
			public const string LkMsdynKnowledgesearchinsightModifiedonbehalfby = "lk_msdyn_knowledgesearchinsight_modifiedonbehalfby";

			/// <summary>1:N lk_msdyn_msteamssetting_createdby</summary>
			public const string LkMsdynMsteamssettingCreatedby = "lk_msdyn_msteamssetting_createdby";

			/// <summary>1:N lk_msdyn_msteamssetting_createdonbehalfby</summary>
			public const string LkMsdynMsteamssettingCreatedonbehalfby = "lk_msdyn_msteamssetting_createdonbehalfby";

			/// <summary>1:N lk_msdyn_msteamssetting_modifiedby</summary>
			public const string LkMsdynMsteamssettingModifiedby = "lk_msdyn_msteamssetting_modifiedby";

			/// <summary>1:N lk_msdyn_msteamssetting_modifiedonbehalfby</summary>
			public const string LkMsdynMsteamssettingModifiedonbehalfby = "lk_msdyn_msteamssetting_modifiedonbehalfby";

			/// <summary>1:N lk_msdyn_msteamssettingsv2_createdby</summary>
			public const string LkMsdynMsteamssettingsv2Createdby = "lk_msdyn_msteamssettingsv2_createdby";

			/// <summary>1:N lk_msdyn_msteamssettingsv2_createdonbehalfby</summary>
			public const string LkMsdynMsteamssettingsv2Createdonbehalfby = "lk_msdyn_msteamssettingsv2_createdonbehalfby";

			/// <summary>1:N lk_msdyn_msteamssettingsv2_modifiedby</summary>
			public const string LkMsdynMsteamssettingsv2Modifiedby = "lk_msdyn_msteamssettingsv2_modifiedby";

			/// <summary>1:N lk_msdyn_msteamssettingsv2_modifiedonbehalfby</summary>
			public const string LkMsdynMsteamssettingsv2Modifiedonbehalfby = "lk_msdyn_msteamssettingsv2_modifiedonbehalfby";

			/// <summary>1:N lk_msdyn_notesanalysisconfig_createdby</summary>
			public const string LkMsdynNotesanalysisconfigCreatedby = "lk_msdyn_notesanalysisconfig_createdby";

			/// <summary>1:N lk_msdyn_notesanalysisconfig_createdonbehalfby</summary>
			public const string LkMsdynNotesanalysisconfigCreatedonbehalfby = "lk_msdyn_notesanalysisconfig_createdonbehalfby";

			/// <summary>1:N lk_msdyn_notesanalysisconfig_modifiedby</summary>
			public const string LkMsdynNotesanalysisconfigModifiedby = "lk_msdyn_notesanalysisconfig_modifiedby";

			/// <summary>1:N lk_msdyn_notesanalysisconfig_modifiedonbehalfby</summary>
			public const string LkMsdynNotesanalysisconfigModifiedonbehalfby = "lk_msdyn_notesanalysisconfig_modifiedonbehalfby";

			/// <summary>1:N lk_msdyn_playbookactivity_createdby</summary>
			public const string LkMsdynPlaybookactivityCreatedby = "lk_msdyn_playbookactivity_createdby";

			/// <summary>1:N lk_msdyn_playbookactivity_createdonbehalfby</summary>
			public const string LkMsdynPlaybookactivityCreatedonbehalfby = "lk_msdyn_playbookactivity_createdonbehalfby";

			/// <summary>1:N lk_msdyn_playbookactivity_modifiedby</summary>
			public const string LkMsdynPlaybookactivityModifiedby = "lk_msdyn_playbookactivity_modifiedby";

			/// <summary>1:N lk_msdyn_playbookactivity_modifiedonbehalfby</summary>
			public const string LkMsdynPlaybookactivityModifiedonbehalfby = "lk_msdyn_playbookactivity_modifiedonbehalfby";

			/// <summary>1:N lk_msdyn_playbookactivityattribute_createdby</summary>
			public const string LkMsdynPlaybookactivityattributeCreatedby = "lk_msdyn_playbookactivityattribute_createdby";

			/// <summary>1:N lk_msdyn_playbookactivityattribute_createdonbehalfby</summary>
			public const string LkMsdynPlaybookactivityattributeCreatedonbehalfby = "lk_msdyn_playbookactivityattribute_createdonbehalfby";

			/// <summary>1:N lk_msdyn_playbookactivityattribute_modifiedby</summary>
			public const string LkMsdynPlaybookactivityattributeModifiedby = "lk_msdyn_playbookactivityattribute_modifiedby";

			/// <summary>1:N lk_msdyn_playbookactivityattribute_modifiedonbehalfby</summary>
			public const string LkMsdynPlaybookactivityattributeModifiedonbehalfby = "lk_msdyn_playbookactivityattribute_modifiedonbehalfby";

			/// <summary>1:N lk_msdyn_playbookcategory_createdby</summary>
			public const string LkMsdynPlaybookcategoryCreatedby = "lk_msdyn_playbookcategory_createdby";

			/// <summary>1:N lk_msdyn_playbookcategory_createdonbehalfby</summary>
			public const string LkMsdynPlaybookcategoryCreatedonbehalfby = "lk_msdyn_playbookcategory_createdonbehalfby";

			/// <summary>1:N lk_msdyn_playbookcategory_modifiedby</summary>
			public const string LkMsdynPlaybookcategoryModifiedby = "lk_msdyn_playbookcategory_modifiedby";

			/// <summary>1:N lk_msdyn_playbookcategory_modifiedonbehalfby</summary>
			public const string LkMsdynPlaybookcategoryModifiedonbehalfby = "lk_msdyn_playbookcategory_modifiedonbehalfby";

			/// <summary>1:N lk_msdyn_playbookinstance_createdby</summary>
			public const string LkMsdynPlaybookinstanceCreatedby = "lk_msdyn_playbookinstance_createdby";

			/// <summary>1:N lk_msdyn_playbookinstance_createdonbehalfby</summary>
			public const string LkMsdynPlaybookinstanceCreatedonbehalfby = "lk_msdyn_playbookinstance_createdonbehalfby";

			/// <summary>1:N lk_msdyn_playbookinstance_modifiedby</summary>
			public const string LkMsdynPlaybookinstanceModifiedby = "lk_msdyn_playbookinstance_modifiedby";

			/// <summary>1:N lk_msdyn_playbookinstance_modifiedonbehalfby</summary>
			public const string LkMsdynPlaybookinstanceModifiedonbehalfby = "lk_msdyn_playbookinstance_modifiedonbehalfby";

			/// <summary>1:N lk_msdyn_playbooktemplate_createdby</summary>
			public const string LkMsdynPlaybooktemplateCreatedby = "lk_msdyn_playbooktemplate_createdby";

			/// <summary>1:N lk_msdyn_playbooktemplate_createdonbehalfby</summary>
			public const string LkMsdynPlaybooktemplateCreatedonbehalfby = "lk_msdyn_playbooktemplate_createdonbehalfby";

			/// <summary>1:N lk_msdyn_playbooktemplate_modifiedby</summary>
			public const string LkMsdynPlaybooktemplateModifiedby = "lk_msdyn_playbooktemplate_modifiedby";

			/// <summary>1:N lk_msdyn_playbooktemplate_modifiedonbehalfby</summary>
			public const string LkMsdynPlaybooktemplateModifiedonbehalfby = "lk_msdyn_playbooktemplate_modifiedonbehalfby";

			/// <summary>1:N lk_msdyn_postalbum_createdby</summary>
			public const string LkMsdynPostalbumCreatedby = "lk_msdyn_postalbum_createdby";

			/// <summary>1:N lk_msdyn_postalbum_createdonbehalfby</summary>
			public const string LkMsdynPostalbumCreatedonbehalfby = "lk_msdyn_postalbum_createdonbehalfby";

			/// <summary>1:N lk_msdyn_postalbum_modifiedby</summary>
			public const string LkMsdynPostalbumModifiedby = "lk_msdyn_postalbum_modifiedby";

			/// <summary>1:N lk_msdyn_postalbum_modifiedonbehalfby</summary>
			public const string LkMsdynPostalbumModifiedonbehalfby = "lk_msdyn_postalbum_modifiedonbehalfby";

			/// <summary>1:N lk_msdyn_postconfig_createdby</summary>
			public const string LkMsdynPostconfigCreatedby = "lk_msdyn_postconfig_createdby";

			/// <summary>1:N lk_msdyn_postconfig_createdonbehalfby</summary>
			public const string LkMsdynPostconfigCreatedonbehalfby = "lk_msdyn_postconfig_createdonbehalfby";

			/// <summary>1:N lk_msdyn_postconfig_modifiedby</summary>
			public const string LkMsdynPostconfigModifiedby = "lk_msdyn_postconfig_modifiedby";

			/// <summary>1:N lk_msdyn_postconfig_modifiedonbehalfby</summary>
			public const string LkMsdynPostconfigModifiedonbehalfby = "lk_msdyn_postconfig_modifiedonbehalfby";

			/// <summary>1:N lk_msdyn_postruleconfig_createdby</summary>
			public const string LkMsdynPostruleconfigCreatedby = "lk_msdyn_postruleconfig_createdby";

			/// <summary>1:N lk_msdyn_postruleconfig_createdonbehalfby</summary>
			public const string LkMsdynPostruleconfigCreatedonbehalfby = "lk_msdyn_postruleconfig_createdonbehalfby";

			/// <summary>1:N lk_msdyn_postruleconfig_modifiedby</summary>
			public const string LkMsdynPostruleconfigModifiedby = "lk_msdyn_postruleconfig_modifiedby";

			/// <summary>1:N lk_msdyn_postruleconfig_modifiedonbehalfby</summary>
			public const string LkMsdynPostruleconfigModifiedonbehalfby = "lk_msdyn_postruleconfig_modifiedonbehalfby";

			/// <summary>1:N lk_msdyn_relationshipinsightsunifiedconfig_createdby</summary>
			public const string LkMsdynRelationshipinsightsunifiedconfigCreatedby = "lk_msdyn_relationshipinsightsunifiedconfig_createdby";

			/// <summary>1:N lk_msdyn_relationshipinsightsunifiedconfig_createdonbehalfby</summary>
			public const string LkMsdynRelationshipinsightsunifiedconfigCreatedonbehalfby = "lk_msdyn_relationshipinsightsunifiedconfig_createdonbehalfby";

			/// <summary>1:N lk_msdyn_relationshipinsightsunifiedconfig_modifiedby</summary>
			public const string LkMsdynRelationshipinsightsunifiedconfigModifiedby = "lk_msdyn_relationshipinsightsunifiedconfig_modifiedby";

			/// <summary>1:N lk_msdyn_relationshipinsightsunifiedconfig_modifiedonbehalfby</summary>
			public const string LkMsdynRelationshipinsightsunifiedconfigModifiedonbehalfby = "lk_msdyn_relationshipinsightsunifiedconfig_modifiedonbehalfby";

			/// <summary>1:N lk_msdyn_richtextfile_createdby</summary>
			public const string LkMsdynRichtextfileCreatedby = "lk_msdyn_richtextfile_createdby";

			/// <summary>1:N lk_msdyn_richtextfile_createdonbehalfby</summary>
			public const string LkMsdynRichtextfileCreatedonbehalfby = "lk_msdyn_richtextfile_createdonbehalfby";

			/// <summary>1:N lk_msdyn_richtextfile_modifiedby</summary>
			public const string LkMsdynRichtextfileModifiedby = "lk_msdyn_richtextfile_modifiedby";

			/// <summary>1:N lk_msdyn_richtextfile_modifiedonbehalfby</summary>
			public const string LkMsdynRichtextfileModifiedonbehalfby = "lk_msdyn_richtextfile_modifiedonbehalfby";

			/// <summary>1:N lk_msdyn_salesinsightssettings_createdby</summary>
			public const string LkMsdynSalesinsightssettingsCreatedby = "lk_msdyn_salesinsightssettings_createdby";

			/// <summary>1:N lk_msdyn_salesinsightssettings_createdonbehalfby</summary>
			public const string LkMsdynSalesinsightssettingsCreatedonbehalfby = "lk_msdyn_salesinsightssettings_createdonbehalfby";

			/// <summary>1:N lk_msdyn_salesinsightssettings_modifiedby</summary>
			public const string LkMsdynSalesinsightssettingsModifiedby = "lk_msdyn_salesinsightssettings_modifiedby";

			/// <summary>1:N lk_msdyn_salesinsightssettings_modifiedonbehalfby</summary>
			public const string LkMsdynSalesinsightssettingsModifiedonbehalfby = "lk_msdyn_salesinsightssettings_modifiedonbehalfby";

			/// <summary>1:N lk_msdyn_siconfig_createdby</summary>
			public const string LkMsdynSiconfigCreatedby = "lk_msdyn_siconfig_createdby";

			/// <summary>1:N lk_msdyn_siconfig_createdonbehalfby</summary>
			public const string LkMsdynSiconfigCreatedonbehalfby = "lk_msdyn_siconfig_createdonbehalfby";

			/// <summary>1:N lk_msdyn_siconfig_modifiedby</summary>
			public const string LkMsdynSiconfigModifiedby = "lk_msdyn_siconfig_modifiedby";

			/// <summary>1:N lk_msdyn_siconfig_modifiedonbehalfby</summary>
			public const string LkMsdynSiconfigModifiedonbehalfby = "lk_msdyn_siconfig_modifiedonbehalfby";

			/// <summary>1:N lk_msdyn_sikeyvalueconfig_createdby</summary>
			public const string LkMsdynSikeyvalueconfigCreatedby = "lk_msdyn_sikeyvalueconfig_createdby";

			/// <summary>1:N lk_msdyn_sikeyvalueconfig_createdonbehalfby</summary>
			public const string LkMsdynSikeyvalueconfigCreatedonbehalfby = "lk_msdyn_sikeyvalueconfig_createdonbehalfby";

			/// <summary>1:N lk_msdyn_sikeyvalueconfig_modifiedby</summary>
			public const string LkMsdynSikeyvalueconfigModifiedby = "lk_msdyn_sikeyvalueconfig_modifiedby";

			/// <summary>1:N lk_msdyn_sikeyvalueconfig_modifiedonbehalfby</summary>
			public const string LkMsdynSikeyvalueconfigModifiedonbehalfby = "lk_msdyn_sikeyvalueconfig_modifiedonbehalfby";

			/// <summary>1:N lk_msdyn_teamscollaboration_createdby</summary>
			public const string LkMsdynTeamscollaborationCreatedby = "lk_msdyn_teamscollaboration_createdby";

			/// <summary>1:N lk_msdyn_teamscollaboration_createdonbehalfby</summary>
			public const string LkMsdynTeamscollaborationCreatedonbehalfby = "lk_msdyn_teamscollaboration_createdonbehalfby";

			/// <summary>1:N lk_msdyn_teamscollaboration_modifiedby</summary>
			public const string LkMsdynTeamscollaborationModifiedby = "lk_msdyn_teamscollaboration_modifiedby";

			/// <summary>1:N lk_msdyn_teamscollaboration_modifiedonbehalfby</summary>
			public const string LkMsdynTeamscollaborationModifiedonbehalfby = "lk_msdyn_teamscollaboration_modifiedonbehalfby";

			/// <summary>1:N lk_msdyn_tour_createdby</summary>
			public const string LkMsdynTourCreatedby = "lk_msdyn_tour_createdby";

			/// <summary>1:N lk_msdyn_tour_createdonbehalfby</summary>
			public const string LkMsdynTourCreatedonbehalfby = "lk_msdyn_tour_createdonbehalfby";

			/// <summary>1:N lk_msdyn_tour_modifiedby</summary>
			public const string LkMsdynTourModifiedby = "lk_msdyn_tour_modifiedby";

			/// <summary>1:N lk_msdyn_tour_modifiedonbehalfby</summary>
			public const string LkMsdynTourModifiedonbehalfby = "lk_msdyn_tour_modifiedonbehalfby";

			/// <summary>1:N lk_msdyn_untrackedappointment_createdby</summary>
			public const string LkMsdynUntrackedappointmentCreatedby = "lk_msdyn_untrackedappointment_createdby";

			/// <summary>1:N lk_msdyn_untrackedappointment_createdonbehalfby</summary>
			public const string LkMsdynUntrackedappointmentCreatedonbehalfby = "lk_msdyn_untrackedappointment_createdonbehalfby";

			/// <summary>1:N lk_msdyn_untrackedappointment_modifiedby</summary>
			public const string LkMsdynUntrackedappointmentModifiedby = "lk_msdyn_untrackedappointment_modifiedby";

			/// <summary>1:N lk_msdyn_untrackedappointment_modifiedonbehalfby</summary>
			public const string LkMsdynUntrackedappointmentModifiedonbehalfby = "lk_msdyn_untrackedappointment_modifiedonbehalfby";

			/// <summary>1:N lk_msdyn_upgraderun_createdby</summary>
			public const string LkMsdynUpgraderunCreatedby = "lk_msdyn_upgraderun_createdby";

			/// <summary>1:N lk_msdyn_upgraderun_createdonbehalfby</summary>
			public const string LkMsdynUpgraderunCreatedonbehalfby = "lk_msdyn_upgraderun_createdonbehalfby";

			/// <summary>1:N lk_msdyn_upgraderun_modifiedby</summary>
			public const string LkMsdynUpgraderunModifiedby = "lk_msdyn_upgraderun_modifiedby";

			/// <summary>1:N lk_msdyn_upgraderun_modifiedonbehalfby</summary>
			public const string LkMsdynUpgraderunModifiedonbehalfby = "lk_msdyn_upgraderun_modifiedonbehalfby";

			/// <summary>1:N lk_msdyn_upgradestep_createdby</summary>
			public const string LkMsdynUpgradestepCreatedby = "lk_msdyn_upgradestep_createdby";

			/// <summary>1:N lk_msdyn_upgradestep_createdonbehalfby</summary>
			public const string LkMsdynUpgradestepCreatedonbehalfby = "lk_msdyn_upgradestep_createdonbehalfby";

			/// <summary>1:N lk_msdyn_upgradestep_modifiedby</summary>
			public const string LkMsdynUpgradestepModifiedby = "lk_msdyn_upgradestep_modifiedby";

			/// <summary>1:N lk_msdyn_upgradestep_modifiedonbehalfby</summary>
			public const string LkMsdynUpgradestepModifiedonbehalfby = "lk_msdyn_upgradestep_modifiedonbehalfby";

			/// <summary>1:N lk_msdyn_upgradeversion_createdby</summary>
			public const string LkMsdynUpgradeversionCreatedby = "lk_msdyn_upgradeversion_createdby";

			/// <summary>1:N lk_msdyn_upgradeversion_createdonbehalfby</summary>
			public const string LkMsdynUpgradeversionCreatedonbehalfby = "lk_msdyn_upgradeversion_createdonbehalfby";

			/// <summary>1:N lk_msdyn_upgradeversion_modifiedby</summary>
			public const string LkMsdynUpgradeversionModifiedby = "lk_msdyn_upgradeversion_modifiedby";

			/// <summary>1:N lk_msdyn_upgradeversion_modifiedonbehalfby</summary>
			public const string LkMsdynUpgradeversionModifiedonbehalfby = "lk_msdyn_upgradeversion_modifiedonbehalfby";

			/// <summary>1:N lk_msdyn_wallsavedquery_createdby</summary>
			public const string LkMsdynWallsavedqueryCreatedby = "lk_msdyn_wallsavedquery_createdby";

			/// <summary>1:N lk_msdyn_wallsavedquery_createdonbehalfby</summary>
			public const string LkMsdynWallsavedqueryCreatedonbehalfby = "lk_msdyn_wallsavedquery_createdonbehalfby";

			/// <summary>1:N lk_msdyn_wallsavedquery_modifiedby</summary>
			public const string LkMsdynWallsavedqueryModifiedby = "lk_msdyn_wallsavedquery_modifiedby";

			/// <summary>1:N lk_msdyn_wallsavedquery_modifiedonbehalfby</summary>
			public const string LkMsdynWallsavedqueryModifiedonbehalfby = "lk_msdyn_wallsavedquery_modifiedonbehalfby";

			/// <summary>1:N lk_msdyn_wallsavedqueryusersettings_createdby</summary>
			public const string LkMsdynWallsavedqueryusersettingsCreatedby = "lk_msdyn_wallsavedqueryusersettings_createdby";

			/// <summary>1:N lk_msdyn_wallsavedqueryusersettings_createdonbehalfby</summary>
			public const string LkMsdynWallsavedqueryusersettingsCreatedonbehalfby = "lk_msdyn_wallsavedqueryusersettings_createdonbehalfby";

			/// <summary>1:N lk_msdyn_wallsavedqueryusersettings_modifiedby</summary>
			public const string LkMsdynWallsavedqueryusersettingsModifiedby = "lk_msdyn_wallsavedqueryusersettings_modifiedby";

			/// <summary>1:N lk_msdyn_wallsavedqueryusersettings_modifiedonbehalfby</summary>
			public const string LkMsdynWallsavedqueryusersettingsModifiedonbehalfby = "lk_msdyn_wallsavedqueryusersettings_modifiedonbehalfby";

			/// <summary>1:N lk_msdynce_botcontent_createdby</summary>
			public const string LkMsdynceBotcontentCreatedby = "lk_msdynce_botcontent_createdby";

			/// <summary>1:N lk_msdynce_botcontent_createdonbehalfby</summary>
			public const string LkMsdynceBotcontentCreatedonbehalfby = "lk_msdynce_botcontent_createdonbehalfby";

			/// <summary>1:N lk_msdynce_botcontent_modifiedby</summary>
			public const string LkMsdynceBotcontentModifiedby = "lk_msdynce_botcontent_modifiedby";

			/// <summary>1:N lk_msdynce_botcontent_modifiedonbehalfby</summary>
			public const string LkMsdynceBotcontentModifiedonbehalfby = "lk_msdynce_botcontent_modifiedonbehalfby";

			/// <summary>1:N lk_navigationsetting_createdby</summary>
			public const string LkNavigationsettingCreatedby = "lk_navigationsetting_createdby";

			/// <summary>1:N lk_navigationsetting_createdonbehalfby</summary>
			public const string LkNavigationsettingCreatedonbehalfby = "lk_navigationsetting_createdonbehalfby";

			/// <summary>1:N lk_navigationsetting_modifiedby</summary>
			public const string LkNavigationsettingModifiedby = "lk_navigationsetting_modifiedby";

			/// <summary>1:N lk_navigationsetting_modifiedonbehalfby</summary>
			public const string LkNavigationsettingModifiedonbehalfby = "lk_navigationsetting_modifiedonbehalfby";

			/// <summary>1:N lk_newprocess_createdby</summary>
			public const string LkNewprocessCreatedby = "lk_newprocess_createdby";

			/// <summary>1:N lk_newprocess_createdonbehalfby</summary>
			public const string LkNewprocessCreatedonbehalfby = "lk_newprocess_createdonbehalfby";

			/// <summary>1:N lk_newprocess_modifiedby</summary>
			public const string LkNewprocessModifiedby = "lk_newprocess_modifiedby";

			/// <summary>1:N lk_newprocess_modifiedonbehalfby</summary>
			public const string LkNewprocessModifiedonbehalfby = "lk_newprocess_modifiedonbehalfby";

			/// <summary>1:N lk_officegraphdocument_createdonbehalfby</summary>
			public const string LkOfficegraphdocumentCreatedonbehalfby = "lk_officegraphdocument_createdonbehalfby";

			/// <summary>1:N lk_officegraphdocument_modifiedonbehalfby</summary>
			public const string LkOfficegraphdocumentModifiedonbehalfby = "lk_officegraphdocument_modifiedonbehalfby";

			/// <summary>1:N lk_opportunity_createdonbehalfby</summary>
			public const string LkOpportunityCreatedonbehalfby = "lk_opportunity_createdonbehalfby";

			/// <summary>1:N lk_opportunity_modifiedonbehalfby</summary>
			public const string LkOpportunityModifiedonbehalfby = "lk_opportunity_modifiedonbehalfby";

			/// <summary>1:N lk_opportunitybase_createdby</summary>
			public const string LkOpportunitybaseCreatedby = "lk_opportunitybase_createdby";

			/// <summary>1:N lk_opportunitybase_modifiedby</summary>
			public const string LkOpportunitybaseModifiedby = "lk_opportunitybase_modifiedby";

			/// <summary>1:N lk_opportunityclose_createdby</summary>
			public const string LkOpportunitycloseCreatedby = "lk_opportunityclose_createdby";

			/// <summary>1:N lk_opportunityclose_createdonbehalfby</summary>
			public const string LkOpportunitycloseCreatedonbehalfby = "lk_opportunityclose_createdonbehalfby";

			/// <summary>1:N lk_opportunityclose_modifiedby</summary>
			public const string LkOpportunitycloseModifiedby = "lk_opportunityclose_modifiedby";

			/// <summary>1:N lk_opportunityclose_modifiedonbehalfby</summary>
			public const string LkOpportunitycloseModifiedonbehalfby = "lk_opportunityclose_modifiedonbehalfby";

			/// <summary>1:N lk_opportunityproduct_createdonbehalfby</summary>
			public const string LkOpportunityproductCreatedonbehalfby = "lk_opportunityproduct_createdonbehalfby";

			/// <summary>1:N lk_opportunityproduct_modifiedonbehalfby</summary>
			public const string LkOpportunityproductModifiedonbehalfby = "lk_opportunityproduct_modifiedonbehalfby";

			/// <summary>1:N lk_opportunityproductbase_createdby</summary>
			public const string LkOpportunityproductbaseCreatedby = "lk_opportunityproductbase_createdby";

			/// <summary>1:N lk_opportunityproductbase_modifiedby</summary>
			public const string LkOpportunityproductbaseModifiedby = "lk_opportunityproductbase_modifiedby";

			/// <summary>1:N lk_opportunitysalesprocess_createdby</summary>
			public const string LkOpportunitysalesprocessCreatedby = "lk_opportunitysalesprocess_createdby";

			/// <summary>1:N lk_opportunitysalesprocess_createdonbehalfby</summary>
			public const string LkOpportunitysalesprocessCreatedonbehalfby = "lk_opportunitysalesprocess_createdonbehalfby";

			/// <summary>1:N lk_opportunitysalesprocess_modifiedby</summary>
			public const string LkOpportunitysalesprocessModifiedby = "lk_opportunitysalesprocess_modifiedby";

			/// <summary>1:N lk_opportunitysalesprocess_modifiedonbehalfby</summary>
			public const string LkOpportunitysalesprocessModifiedonbehalfby = "lk_opportunitysalesprocess_modifiedonbehalfby";

			/// <summary>1:N lk_orderclose_createdby</summary>
			public const string LkOrdercloseCreatedby = "lk_orderclose_createdby";

			/// <summary>1:N lk_orderclose_createdonbehalfby</summary>
			public const string LkOrdercloseCreatedonbehalfby = "lk_orderclose_createdonbehalfby";

			/// <summary>1:N lk_orderclose_modifiedby</summary>
			public const string LkOrdercloseModifiedby = "lk_orderclose_modifiedby";

			/// <summary>1:N lk_orderclose_modifiedonbehalfby</summary>
			public const string LkOrdercloseModifiedonbehalfby = "lk_orderclose_modifiedonbehalfby";

			/// <summary>1:N lk_organization_createdonbehalfby</summary>
			public const string LkOrganizationCreatedonbehalfby = "lk_organization_createdonbehalfby";

			/// <summary>1:N lk_organization_modifiedonbehalfby</summary>
			public const string LkOrganizationModifiedonbehalfby = "lk_organization_modifiedonbehalfby";

			/// <summary>1:N lk_organizationbase_createdby</summary>
			public const string LkOrganizationbaseCreatedby = "lk_organizationbase_createdby";

			/// <summary>1:N lk_organizationbase_modifiedby</summary>
			public const string LkOrganizationbaseModifiedby = "lk_organizationbase_modifiedby";

			/// <summary>1:N lk_ownermapping_createdby</summary>
			public const string LkOwnermappingCreatedby = "lk_ownermapping_createdby";

			/// <summary>1:N lk_ownermapping_createdonbehalfby</summary>
			public const string LkOwnermappingCreatedonbehalfby = "lk_ownermapping_createdonbehalfby";

			/// <summary>1:N lk_ownermapping_modifiedby</summary>
			public const string LkOwnermappingModifiedby = "lk_ownermapping_modifiedby";

			/// <summary>1:N lk_ownermapping_modifiedonbehalfby</summary>
			public const string LkOwnermappingModifiedonbehalfby = "lk_ownermapping_modifiedonbehalfby";

			/// <summary>1:N lk_package_createdby</summary>
			public const string LkPackageCreatedby = "lk_package_createdby";

			/// <summary>1:N lk_package_createdonbehalfby</summary>
			public const string LkPackageCreatedonbehalfby = "lk_package_createdonbehalfby";

			/// <summary>1:N lk_package_modifiedby</summary>
			public const string LkPackageModifiedby = "lk_package_modifiedby";

			/// <summary>1:N lk_package_modifiedonbehalfby</summary>
			public const string LkPackageModifiedonbehalfby = "lk_package_modifiedonbehalfby";

			/// <summary>1:N lk_personaldocumenttemplatebase_createdby</summary>
			public const string LkPersonaldocumenttemplatebaseCreatedby = "lk_personaldocumenttemplatebase_createdby";

			/// <summary>1:N lk_personaldocumenttemplatebase_createdonbehalfby</summary>
			public const string LkPersonaldocumenttemplatebaseCreatedonbehalfby = "lk_personaldocumenttemplatebase_createdonbehalfby";

			/// <summary>1:N lk_personaldocumenttemplatebase_modifiedby</summary>
			public const string LkPersonaldocumenttemplatebaseModifiedby = "lk_personaldocumenttemplatebase_modifiedby";

			/// <summary>1:N lk_personaldocumenttemplatebase_modifiedonbehalfby</summary>
			public const string LkPersonaldocumenttemplatebaseModifiedonbehalfby = "lk_personaldocumenttemplatebase_modifiedonbehalfby";

			/// <summary>1:N lk_phonecall_createdby</summary>
			public const string LkPhonecallCreatedby = "lk_phonecall_createdby";

			/// <summary>1:N lk_phonecall_createdonbehalfby</summary>
			public const string LkPhonecallCreatedonbehalfby = "lk_phonecall_createdonbehalfby";

			/// <summary>1:N lk_phonecall_modifiedby</summary>
			public const string LkPhonecallModifiedby = "lk_phonecall_modifiedby";

			/// <summary>1:N lk_phonecall_modifiedonbehalfby</summary>
			public const string LkPhonecallModifiedonbehalfby = "lk_phonecall_modifiedonbehalfby";

			/// <summary>1:N lk_phonetocaseprocess_createdby</summary>
			public const string LkPhonetocaseprocessCreatedby = "lk_phonetocaseprocess_createdby";

			/// <summary>1:N lk_phonetocaseprocess_createdonbehalfby</summary>
			public const string LkPhonetocaseprocessCreatedonbehalfby = "lk_phonetocaseprocess_createdonbehalfby";

			/// <summary>1:N lk_phonetocaseprocess_modifiedby</summary>
			public const string LkPhonetocaseprocessModifiedby = "lk_phonetocaseprocess_modifiedby";

			/// <summary>1:N lk_phonetocaseprocess_modifiedonbehalfby</summary>
			public const string LkPhonetocaseprocessModifiedonbehalfby = "lk_phonetocaseprocess_modifiedonbehalfby";

			/// <summary>1:N lk_picklistmapping_createdby</summary>
			public const string LkPicklistmappingCreatedby = "lk_picklistmapping_createdby";

			/// <summary>1:N lk_picklistmapping_createdonbehalfby</summary>
			public const string LkPicklistmappingCreatedonbehalfby = "lk_picklistmapping_createdonbehalfby";

			/// <summary>1:N lk_picklistmapping_modifiedby</summary>
			public const string LkPicklistmappingModifiedby = "lk_picklistmapping_modifiedby";

			/// <summary>1:N lk_picklistmapping_modifiedonbehalfby</summary>
			public const string LkPicklistmappingModifiedonbehalfby = "lk_picklistmapping_modifiedonbehalfby";

			/// <summary>1:N lk_pluginassembly_createdonbehalfby</summary>
			public const string LkPluginassemblyCreatedonbehalfby = "lk_pluginassembly_createdonbehalfby";

			/// <summary>1:N lk_pluginassembly_modifiedonbehalfby</summary>
			public const string LkPluginassemblyModifiedonbehalfby = "lk_pluginassembly_modifiedonbehalfby";

			/// <summary>1:N lk_plugintracelogbase_createdonbehalfby</summary>
			public const string LkPlugintracelogbaseCreatedonbehalfby = "lk_plugintracelogbase_createdonbehalfby";

			/// <summary>1:N lk_plugintype_createdonbehalfby</summary>
			public const string LkPlugintypeCreatedonbehalfby = "lk_plugintype_createdonbehalfby";

			/// <summary>1:N lk_plugintype_modifiedonbehalfby</summary>
			public const string LkPlugintypeModifiedonbehalfby = "lk_plugintype_modifiedonbehalfby";

			/// <summary>1:N lk_plugintypestatisticbase_createdonbehalfby</summary>
			public const string LkPlugintypestatisticbaseCreatedonbehalfby = "lk_plugintypestatisticbase_createdonbehalfby";

			/// <summary>1:N lk_plugintypestatisticbase_modifiedonbehalfby</summary>
			public const string LkPlugintypestatisticbaseModifiedonbehalfby = "lk_plugintypestatisticbase_modifiedonbehalfby";

			/// <summary>1:N lk_position_createdby</summary>
			public const string LkPositionCreatedby = "lk_position_createdby";

			/// <summary>1:N lk_position_createdonbehalfby</summary>
			public const string LkPositionCreatedonbehalfby = "lk_position_createdonbehalfby";

			/// <summary>1:N lk_position_modifiedby</summary>
			public const string LkPositionModifiedby = "lk_position_modifiedby";

			/// <summary>1:N lk_position_modifiedonbehalfby</summary>
			public const string LkPositionModifiedonbehalfby = "lk_position_modifiedonbehalfby";

			/// <summary>1:N lk_post_createdby</summary>
			public const string LkPostCreatedby = "lk_post_createdby";

			/// <summary>1:N lk_post_createdonbehalfby</summary>
			public const string LkPostCreatedonbehalfby = "lk_post_createdonbehalfby";

			/// <summary>1:N lk_post_modifiedby</summary>
			public const string LkPostModifiedby = "lk_post_modifiedby";

			/// <summary>1:N lk_post_modifiedonbehalfby</summary>
			public const string LkPostModifiedonbehalfby = "lk_post_modifiedonbehalfby";

			/// <summary>1:N lk_postcomment_createdby</summary>
			public const string LkPostcommentCreatedby = "lk_postcomment_createdby";

			/// <summary>1:N lk_postcomment_createdonbehalfby</summary>
			public const string LkPostcommentCreatedonbehalfby = "lk_postcomment_createdonbehalfby";

			/// <summary>1:N lk_PostFollow_createdby</summary>
			public const string LkPostFollowCreatedby = "lk_PostFollow_createdby";

			/// <summary>1:N lk_postfollow_createdonbehalfby</summary>
			public const string LkPostfollowCreatedonbehalfby = "lk_postfollow_createdonbehalfby";

			/// <summary>1:N lk_postlike_createdby</summary>
			public const string LkPostlikeCreatedby = "lk_postlike_createdby";

			/// <summary>1:N lk_postlike_createdonbehalfby</summary>
			public const string LkPostlikeCreatedonbehalfby = "lk_postlike_createdonbehalfby";

			/// <summary>1:N lk_pricelevel_createdonbehalfby</summary>
			public const string LkPricelevelCreatedonbehalfby = "lk_pricelevel_createdonbehalfby";

			/// <summary>1:N lk_pricelevel_modifiedonbehalfby</summary>
			public const string LkPricelevelModifiedonbehalfby = "lk_pricelevel_modifiedonbehalfby";

			/// <summary>1:N lk_pricelevelbase_createdby</summary>
			public const string LkPricelevelbaseCreatedby = "lk_pricelevelbase_createdby";

			/// <summary>1:N lk_pricelevelbase_modifiedby</summary>
			public const string LkPricelevelbaseModifiedby = "lk_pricelevelbase_modifiedby";

			/// <summary>1:N lk_processsession_canceledby</summary>
			public const string LkProcesssessionCanceledby = "lk_processsession_canceledby";

			/// <summary>1:N lk_processsession_completedby</summary>
			public const string LkProcesssessionCompletedby = "lk_processsession_completedby";

			/// <summary>1:N lk_processsession_createdby</summary>
			public const string LkProcesssessionCreatedby = "lk_processsession_createdby";

			/// <summary>1:N lk_processsession_executedby</summary>
			public const string LkProcesssessionExecutedby = "lk_processsession_executedby";

			/// <summary>1:N lk_processsession_modifiedby</summary>
			public const string LkProcesssessionModifiedby = "lk_processsession_modifiedby";

			/// <summary>1:N lk_processsession_startedby</summary>
			public const string LkProcesssessionStartedby = "lk_processsession_startedby";

			/// <summary>1:N lk_processsessionbase_createdonbehalfby</summary>
			public const string LkProcesssessionbaseCreatedonbehalfby = "lk_processsessionbase_createdonbehalfby";

			/// <summary>1:N lk_processsessionbase_modifiedonbehalfby</summary>
			public const string LkProcesssessionbaseModifiedonbehalfby = "lk_processsessionbase_modifiedonbehalfby";

			/// <summary>1:N lk_processstageparameter_createdby</summary>
			public const string LkProcessstageparameterCreatedby = "lk_processstageparameter_createdby";

			/// <summary>1:N lk_processstageparameter_createdonbehalfby</summary>
			public const string LkProcessstageparameterCreatedonbehalfby = "lk_processstageparameter_createdonbehalfby";

			/// <summary>1:N lk_processstageparameter_modifiedby</summary>
			public const string LkProcessstageparameterModifiedby = "lk_processstageparameter_modifiedby";

			/// <summary>1:N lk_processstageparameter_modifiedonbehalfby</summary>
			public const string LkProcessstageparameterModifiedonbehalfby = "lk_processstageparameter_modifiedonbehalfby";

			/// <summary>1:N lk_processtriggerbase_createdby</summary>
			public const string LkProcesstriggerbaseCreatedby = "lk_processtriggerbase_createdby";

			/// <summary>1:N lk_processtriggerbase_createdonbehalfby</summary>
			public const string LkProcesstriggerbaseCreatedonbehalfby = "lk_processtriggerbase_createdonbehalfby";

			/// <summary>1:N lk_processtriggerbase_modifiedby</summary>
			public const string LkProcesstriggerbaseModifiedby = "lk_processtriggerbase_modifiedby";

			/// <summary>1:N lk_processtriggerbase_modifiedonbehalfby</summary>
			public const string LkProcesstriggerbaseModifiedonbehalfby = "lk_processtriggerbase_modifiedonbehalfby";

			/// <summary>1:N lk_product_createdonbehalfby</summary>
			public const string LkProductCreatedonbehalfby = "lk_product_createdonbehalfby";

			/// <summary>1:N lk_product_modifiedonbehalfby</summary>
			public const string LkProductModifiedonbehalfby = "lk_product_modifiedonbehalfby";

			/// <summary>1:N lk_ProductAssociate_createdby</summary>
			public const string LkProductAssociateCreatedby = "lk_ProductAssociate_createdby";

			/// <summary>1:N lk_ProductAssociation_createdonbehalfby</summary>
			public const string LkProductAssociationCreatedonbehalfby = "lk_ProductAssociation_createdonbehalfby";

			/// <summary>1:N lk_ProductAssociation_modifiedby</summary>
			public const string LkProductAssociationModifiedby = "lk_ProductAssociation_modifiedby";

			/// <summary>1:N lk_ProductAssociation_modifiedonbehalfby</summary>
			public const string LkProductAssociationModifiedonbehalfby = "lk_ProductAssociation_modifiedonbehalfby";

			/// <summary>1:N lk_productbase_createdby</summary>
			public const string LkProductbaseCreatedby = "lk_productbase_createdby";

			/// <summary>1:N lk_productbase_modifiedby</summary>
			public const string LkProductbaseModifiedby = "lk_productbase_modifiedby";

			/// <summary>1:N lk_productpricelevel_createdonbehalfby</summary>
			public const string LkProductpricelevelCreatedonbehalfby = "lk_productpricelevel_createdonbehalfby";

			/// <summary>1:N lk_productpricelevel_modifiedonbehalfby</summary>
			public const string LkProductpricelevelModifiedonbehalfby = "lk_productpricelevel_modifiedonbehalfby";

			/// <summary>1:N lk_productpricelevelbase_createdby</summary>
			public const string LkProductpricelevelbaseCreatedby = "lk_productpricelevelbase_createdby";

			/// <summary>1:N lk_productpricelevelbase_modifiedby</summary>
			public const string LkProductpricelevelbaseModifiedby = "lk_productpricelevelbase_modifiedby";

			/// <summary>1:N lk_ProductSubstitute_createdby</summary>
			public const string LkProductSubstituteCreatedby = "lk_ProductSubstitute_createdby";

			/// <summary>1:N lk_ProductSubstitute_createdonbehalfby</summary>
			public const string LkProductSubstituteCreatedonbehalfby = "lk_ProductSubstitute_createdonbehalfby";

			/// <summary>1:N lk_ProductSubstitute_modifiedby</summary>
			public const string LkProductSubstituteModifiedby = "lk_ProductSubstitute_modifiedby";

			/// <summary>1:N lk_ProductSubstitute_modifiedonbehalfby</summary>
			public const string LkProductSubstituteModifiedonbehalfby = "lk_ProductSubstitute_modifiedonbehalfby";

			/// <summary>1:N lk_publisher_createdby</summary>
			public const string LkPublisherCreatedby = "lk_publisher_createdby";

			/// <summary>1:N lk_publisher_modifiedby</summary>
			public const string LkPublisherModifiedby = "lk_publisher_modifiedby";

			/// <summary>1:N lk_publisheraddressbase_createdby</summary>
			public const string LkPublisheraddressbaseCreatedby = "lk_publisheraddressbase_createdby";

			/// <summary>1:N lk_publisheraddressbase_createdonbehalfby</summary>
			public const string LkPublisheraddressbaseCreatedonbehalfby = "lk_publisheraddressbase_createdonbehalfby";

			/// <summary>1:N lk_publisheraddressbase_modifiedby</summary>
			public const string LkPublisheraddressbaseModifiedby = "lk_publisheraddressbase_modifiedby";

			/// <summary>1:N lk_publisheraddressbase_modifiedonbehalfby</summary>
			public const string LkPublisheraddressbaseModifiedonbehalfby = "lk_publisheraddressbase_modifiedonbehalfby";

			/// <summary>1:N lk_publisherbase_createdonbehalfby</summary>
			public const string LkPublisherbaseCreatedonbehalfby = "lk_publisherbase_createdonbehalfby";

			/// <summary>1:N lk_publisherbase_modifiedonbehalfby</summary>
			public const string LkPublisherbaseModifiedonbehalfby = "lk_publisherbase_modifiedonbehalfby";

			/// <summary>1:N lk_pw_penta_schedule_run_createdby</summary>
			public const string LkPwPentaScheduleRunCreatedby = "lk_pw_penta_schedule_run_createdby";

			/// <summary>1:N lk_pw_penta_schedule_run_createdonbehalfby</summary>
			public const string LkPwPentaScheduleRunCreatedonbehalfby = "lk_pw_penta_schedule_run_createdonbehalfby";

			/// <summary>1:N lk_pw_penta_schedule_run_modifiedby</summary>
			public const string LkPwPentaScheduleRunModifiedby = "lk_pw_penta_schedule_run_modifiedby";

			/// <summary>1:N lk_pw_penta_schedule_run_modifiedonbehalfby</summary>
			public const string LkPwPentaScheduleRunModifiedonbehalfby = "lk_pw_penta_schedule_run_modifiedonbehalfby";

			/// <summary>1:N lk_pw_schedule_createdby</summary>
			public const string LkPwScheduleCreatedby = "lk_pw_schedule_createdby";

			/// <summary>1:N lk_pw_schedule_createdonbehalfby</summary>
			public const string LkPwScheduleCreatedonbehalfby = "lk_pw_schedule_createdonbehalfby";

			/// <summary>1:N lk_pw_schedule_modifiedby</summary>
			public const string LkPwScheduleModifiedby = "lk_pw_schedule_modifiedby";

			/// <summary>1:N lk_pw_schedule_modifiedonbehalfby</summary>
			public const string LkPwScheduleModifiedonbehalfby = "lk_pw_schedule_modifiedonbehalfby";

			/// <summary>1:N lk_quarterlyfiscalcalendar_createdby</summary>
			public const string LkQuarterlyfiscalcalendarCreatedby = "lk_quarterlyfiscalcalendar_createdby";

			/// <summary>1:N lk_quarterlyfiscalcalendar_createdonbehalfby</summary>
			public const string LkQuarterlyfiscalcalendarCreatedonbehalfby = "lk_quarterlyfiscalcalendar_createdonbehalfby";

			/// <summary>1:N lk_quarterlyfiscalcalendar_modifiedby</summary>
			public const string LkQuarterlyfiscalcalendarModifiedby = "lk_quarterlyfiscalcalendar_modifiedby";

			/// <summary>1:N lk_quarterlyfiscalcalendar_modifiedonbehalfby</summary>
			public const string LkQuarterlyfiscalcalendarModifiedonbehalfby = "lk_quarterlyfiscalcalendar_modifiedonbehalfby";

			/// <summary>1:N lk_quarterlyfiscalcalendar_salespersonid</summary>
			public const string LkQuarterlyfiscalcalendarSalespersonid = "lk_quarterlyfiscalcalendar_salespersonid";

			/// <summary>1:N lk_queue_createdonbehalfby</summary>
			public const string LkQueueCreatedonbehalfby = "lk_queue_createdonbehalfby";

			/// <summary>1:N lk_queue_modifiedonbehalfby</summary>
			public const string LkQueueModifiedonbehalfby = "lk_queue_modifiedonbehalfby";

			/// <summary>1:N lk_queuebase_createdby</summary>
			public const string LkQueuebaseCreatedby = "lk_queuebase_createdby";

			/// <summary>1:N lk_queuebase_modifiedby</summary>
			public const string LkQueuebaseModifiedby = "lk_queuebase_modifiedby";

			/// <summary>1:N lk_queueitem_createdonbehalfby</summary>
			public const string LkQueueitemCreatedonbehalfby = "lk_queueitem_createdonbehalfby";

			/// <summary>1:N lk_queueitem_modifiedonbehalfby</summary>
			public const string LkQueueitemModifiedonbehalfby = "lk_queueitem_modifiedonbehalfby";

			/// <summary>1:N lk_queueitembase_createdby</summary>
			public const string LkQueueitembaseCreatedby = "lk_queueitembase_createdby";

			/// <summary>1:N lk_queueitembase_modifiedby</summary>
			public const string LkQueueitembaseModifiedby = "lk_queueitembase_modifiedby";

			/// <summary>1:N lk_queueitembase_workerid</summary>
			public const string LkQueueitembaseWorkerid = "lk_queueitembase_workerid";

			/// <summary>1:N lk_quote_createdonbehalfby</summary>
			public const string LkQuoteCreatedonbehalfby = "lk_quote_createdonbehalfby";

			/// <summary>1:N lk_quote_modifiedonbehalfby</summary>
			public const string LkQuoteModifiedonbehalfby = "lk_quote_modifiedonbehalfby";

			/// <summary>1:N lk_quotebase_createdby</summary>
			public const string LkQuotebaseCreatedby = "lk_quotebase_createdby";

			/// <summary>1:N lk_quotebase_modifiedby</summary>
			public const string LkQuotebaseModifiedby = "lk_quotebase_modifiedby";

			/// <summary>1:N lk_quoteclose_createdby</summary>
			public const string LkQuotecloseCreatedby = "lk_quoteclose_createdby";

			/// <summary>1:N lk_quoteclose_createdonbehalfby</summary>
			public const string LkQuotecloseCreatedonbehalfby = "lk_quoteclose_createdonbehalfby";

			/// <summary>1:N lk_quoteclose_modifiedby</summary>
			public const string LkQuotecloseModifiedby = "lk_quoteclose_modifiedby";

			/// <summary>1:N lk_quoteclose_modifiedonbehalfby</summary>
			public const string LkQuotecloseModifiedonbehalfby = "lk_quoteclose_modifiedonbehalfby";

			/// <summary>1:N lk_quotedetail_createdonbehalfby</summary>
			public const string LkQuotedetailCreatedonbehalfby = "lk_quotedetail_createdonbehalfby";

			/// <summary>1:N lk_quotedetail_modifiedonbehalfby</summary>
			public const string LkQuotedetailModifiedonbehalfby = "lk_quotedetail_modifiedonbehalfby";

			/// <summary>1:N lk_quotedetailbase_createdby</summary>
			public const string LkQuotedetailbaseCreatedby = "lk_quotedetailbase_createdby";

			/// <summary>1:N lk_quotedetailbase_modifiedby</summary>
			public const string LkQuotedetailbaseModifiedby = "lk_quotedetailbase_modifiedby";

			/// <summary>1:N lk_ratingmodel_createdby</summary>
			public const string LkRatingmodelCreatedby = "lk_ratingmodel_createdby";

			/// <summary>1:N lk_ratingmodel_createdonbehalfby</summary>
			public const string LkRatingmodelCreatedonbehalfby = "lk_ratingmodel_createdonbehalfby";

			/// <summary>1:N lk_ratingmodel_modifiedby</summary>
			public const string LkRatingmodelModifiedby = "lk_ratingmodel_modifiedby";

			/// <summary>1:N lk_ratingmodel_modifiedonbehalfby</summary>
			public const string LkRatingmodelModifiedonbehalfby = "lk_ratingmodel_modifiedonbehalfby";

			/// <summary>1:N lk_ratingvalue_createdby</summary>
			public const string LkRatingvalueCreatedby = "lk_ratingvalue_createdby";

			/// <summary>1:N lk_ratingvalue_createdonbehalfby</summary>
			public const string LkRatingvalueCreatedonbehalfby = "lk_ratingvalue_createdonbehalfby";

			/// <summary>1:N lk_ratingvalue_modifiedby</summary>
			public const string LkRatingvalueModifiedby = "lk_ratingvalue_modifiedby";

			/// <summary>1:N lk_ratingvalue_modifiedonbehalfby</summary>
			public const string LkRatingvalueModifiedonbehalfby = "lk_ratingvalue_modifiedonbehalfby";

			/// <summary>1:N lk_recommendeddocument_createdby</summary>
			public const string LkRecommendeddocumentCreatedby = "lk_recommendeddocument_createdby";

			/// <summary>1:N lk_recommendeddocument_createdonbehalfby</summary>
			public const string LkRecommendeddocumentCreatedonbehalfby = "lk_recommendeddocument_createdonbehalfby";

			/// <summary>1:N lk_recommendeddocument_modifiedby</summary>
			public const string LkRecommendeddocumentModifiedby = "lk_recommendeddocument_modifiedby";

			/// <summary>1:N lk_recommendeddocument_modifiedonbehalfby</summary>
			public const string LkRecommendeddocumentModifiedonbehalfby = "lk_recommendeddocument_modifiedonbehalfby";

			/// <summary>1:N lk_recurrencerule_createdby</summary>
			public const string LkRecurrenceruleCreatedby = "lk_recurrencerule_createdby";

			/// <summary>1:N lk_recurrencerule_modifiedby</summary>
			public const string LkRecurrenceruleModifiedby = "lk_recurrencerule_modifiedby";

			/// <summary>1:N lk_recurrencerulebase_createdonbehalfby</summary>
			public const string LkRecurrencerulebaseCreatedonbehalfby = "lk_recurrencerulebase_createdonbehalfby";

			/// <summary>1:N lk_recurrencerulebase_modifiedonbehalfby</summary>
			public const string LkRecurrencerulebaseModifiedonbehalfby = "lk_recurrencerulebase_modifiedonbehalfby";

			/// <summary>1:N lk_recurringappointmentmaster_createdby</summary>
			public const string LkRecurringappointmentmasterCreatedby = "lk_recurringappointmentmaster_createdby";

			/// <summary>1:N lk_recurringappointmentmaster_createdonbehalfby</summary>
			public const string LkRecurringappointmentmasterCreatedonbehalfby = "lk_recurringappointmentmaster_createdonbehalfby";

			/// <summary>1:N lk_recurringappointmentmaster_modifiedby</summary>
			public const string LkRecurringappointmentmasterModifiedby = "lk_recurringappointmentmaster_modifiedby";

			/// <summary>1:N lk_recurringappointmentmaster_modifiedonbehalfby</summary>
			public const string LkRecurringappointmentmasterModifiedonbehalfby = "lk_recurringappointmentmaster_modifiedonbehalfby";

			/// <summary>1:N lk_report_createdonbehalfby</summary>
			public const string LkReportCreatedonbehalfby = "lk_report_createdonbehalfby";

			/// <summary>1:N lk_report_modifiedonbehalfby</summary>
			public const string LkReportModifiedonbehalfby = "lk_report_modifiedonbehalfby";

			/// <summary>1:N lk_reportbase_createdby</summary>
			public const string LkReportbaseCreatedby = "lk_reportbase_createdby";

			/// <summary>1:N lk_reportbase_modifiedby</summary>
			public const string LkReportbaseModifiedby = "lk_reportbase_modifiedby";

			/// <summary>1:N lk_reportcategory_createdonbehalfby</summary>
			public const string LkReportcategoryCreatedonbehalfby = "lk_reportcategory_createdonbehalfby";

			/// <summary>1:N lk_reportcategory_modifiedonbehalfby</summary>
			public const string LkReportcategoryModifiedonbehalfby = "lk_reportcategory_modifiedonbehalfby";

			/// <summary>1:N lk_reportcategorybase_createdby</summary>
			public const string LkReportcategorybaseCreatedby = "lk_reportcategorybase_createdby";

			/// <summary>1:N lk_reportcategorybase_modifiedby</summary>
			public const string LkReportcategorybaseModifiedby = "lk_reportcategorybase_modifiedby";

			/// <summary>1:N lk_resourcespec_createdby</summary>
			public const string LkResourcespecCreatedby = "lk_resourcespec_createdby";

			/// <summary>1:N lk_resourcespec_createdonbehalfby</summary>
			public const string LkResourcespecCreatedonbehalfby = "lk_resourcespec_createdonbehalfby";

			/// <summary>1:N lk_resourcespec_modifiedby</summary>
			public const string LkResourcespecModifiedby = "lk_resourcespec_modifiedby";

			/// <summary>1:N lk_resourcespec_modifiedonbehalfby</summary>
			public const string LkResourcespecModifiedonbehalfby = "lk_resourcespec_modifiedonbehalfby";

			/// <summary>1:N lk_role_createdonbehalfby</summary>
			public const string LkRoleCreatedonbehalfby = "lk_role_createdonbehalfby";

			/// <summary>1:N lk_role_modifiedonbehalfby</summary>
			public const string LkRoleModifiedonbehalfby = "lk_role_modifiedonbehalfby";

			/// <summary>1:N lk_rolebase_createdby</summary>
			public const string LkRolebaseCreatedby = "lk_rolebase_createdby";

			/// <summary>1:N lk_rolebase_modifiedby</summary>
			public const string LkRolebaseModifiedby = "lk_rolebase_modifiedby";

			/// <summary>1:N lk_rollupfield_createdby</summary>
			public const string LkRollupfieldCreatedby = "lk_rollupfield_createdby";

			/// <summary>1:N lk_rollupfield_createdonbehalfby</summary>
			public const string LkRollupfieldCreatedonbehalfby = "lk_rollupfield_createdonbehalfby";

			/// <summary>1:N lk_rollupfield_modifiedby</summary>
			public const string LkRollupfieldModifiedby = "lk_rollupfield_modifiedby";

			/// <summary>1:N lk_rollupfield_modifiedonbehalfby</summary>
			public const string LkRollupfieldModifiedonbehalfby = "lk_rollupfield_modifiedonbehalfby";

			/// <summary>1:N lk_salesliterature_createdonbehalfby</summary>
			public const string LkSalesliteratureCreatedonbehalfby = "lk_salesliterature_createdonbehalfby";

			/// <summary>1:N lk_salesliterature_modifiedonbehalfby</summary>
			public const string LkSalesliteratureModifiedonbehalfby = "lk_salesliterature_modifiedonbehalfby";

			/// <summary>1:N lk_salesliteraturebase_createdby</summary>
			public const string LkSalesliteraturebaseCreatedby = "lk_salesliteraturebase_createdby";

			/// <summary>1:N lk_salesliteraturebase_modifiedby</summary>
			public const string LkSalesliteraturebaseModifiedby = "lk_salesliteraturebase_modifiedby";

			/// <summary>1:N lk_salesliteratureitem_createdonbehalfby</summary>
			public const string LkSalesliteratureitemCreatedonbehalfby = "lk_salesliteratureitem_createdonbehalfby";

			/// <summary>1:N lk_salesliteratureitem_modifiedonbehalfby</summary>
			public const string LkSalesliteratureitemModifiedonbehalfby = "lk_salesliteratureitem_modifiedonbehalfby";

			/// <summary>1:N lk_salesliteratureitembase_createdby</summary>
			public const string LkSalesliteratureitembaseCreatedby = "lk_salesliteratureitembase_createdby";

			/// <summary>1:N lk_salesliteratureitembase_modifiedby</summary>
			public const string LkSalesliteratureitembaseModifiedby = "lk_salesliteratureitembase_modifiedby";

			/// <summary>1:N lk_salesorder_createdonbehalfby</summary>
			public const string LkSalesorderCreatedonbehalfby = "lk_salesorder_createdonbehalfby";

			/// <summary>1:N lk_salesorder_modifiedonbehalfby</summary>
			public const string LkSalesorderModifiedonbehalfby = "lk_salesorder_modifiedonbehalfby";

			/// <summary>1:N lk_salesorderbase_createdby</summary>
			public const string LkSalesorderbaseCreatedby = "lk_salesorderbase_createdby";

			/// <summary>1:N lk_salesorderbase_modifiedby</summary>
			public const string LkSalesorderbaseModifiedby = "lk_salesorderbase_modifiedby";

			/// <summary>1:N lk_salesorderdetail_createdonbehalfby</summary>
			public const string LkSalesorderdetailCreatedonbehalfby = "lk_salesorderdetail_createdonbehalfby";

			/// <summary>1:N lk_salesorderdetail_modifiedonbehalfby</summary>
			public const string LkSalesorderdetailModifiedonbehalfby = "lk_salesorderdetail_modifiedonbehalfby";

			/// <summary>1:N lk_salesorderdetailbase_createdby</summary>
			public const string LkSalesorderdetailbaseCreatedby = "lk_salesorderdetailbase_createdby";

			/// <summary>1:N lk_salesorderdetailbase_modifiedby</summary>
			public const string LkSalesorderdetailbaseModifiedby = "lk_salesorderdetailbase_modifiedby";

			/// <summary>1:N lk_savedquery_createdonbehalfby</summary>
			public const string LkSavedqueryCreatedonbehalfby = "lk_savedquery_createdonbehalfby";

			/// <summary>1:N lk_savedquery_modifiedonbehalfby</summary>
			public const string LkSavedqueryModifiedonbehalfby = "lk_savedquery_modifiedonbehalfby";

			/// <summary>1:N lk_savedquerybase_createdby</summary>
			public const string LkSavedquerybaseCreatedby = "lk_savedquerybase_createdby";

			/// <summary>1:N lk_savedquerybase_modifiedby</summary>
			public const string LkSavedquerybaseModifiedby = "lk_savedquerybase_modifiedby";

			/// <summary>1:N lk_savedqueryvisualizationbase_createdby</summary>
			public const string LkSavedqueryvisualizationbaseCreatedby = "lk_savedqueryvisualizationbase_createdby";

			/// <summary>1:N lk_savedqueryvisualizationbase_createdonbehalfby</summary>
			public const string LkSavedqueryvisualizationbaseCreatedonbehalfby = "lk_savedqueryvisualizationbase_createdonbehalfby";

			/// <summary>1:N lk_savedqueryvisualizationbase_modifiedby</summary>
			public const string LkSavedqueryvisualizationbaseModifiedby = "lk_savedqueryvisualizationbase_modifiedby";

			/// <summary>1:N lk_savedqueryvisualizationbase_modifiedonbehalfby</summary>
			public const string LkSavedqueryvisualizationbaseModifiedonbehalfby = "lk_savedqueryvisualizationbase_modifiedonbehalfby";

			/// <summary>1:N lk_sdkmessage_createdonbehalfby</summary>
			public const string LkSdkmessageCreatedonbehalfby = "lk_sdkmessage_createdonbehalfby";

			/// <summary>1:N lk_sdkmessage_modifiedonbehalfby</summary>
			public const string LkSdkmessageModifiedonbehalfby = "lk_sdkmessage_modifiedonbehalfby";

			/// <summary>1:N lk_sdkmessagefilter_createdonbehalfby</summary>
			public const string LkSdkmessagefilterCreatedonbehalfby = "lk_sdkmessagefilter_createdonbehalfby";

			/// <summary>1:N lk_sdkmessagefilter_modifiedonbehalfby</summary>
			public const string LkSdkmessagefilterModifiedonbehalfby = "lk_sdkmessagefilter_modifiedonbehalfby";

			/// <summary>1:N lk_sdkmessageprocessingstep_createdonbehalfby</summary>
			public const string LkSdkmessageprocessingstepCreatedonbehalfby = "lk_sdkmessageprocessingstep_createdonbehalfby";

			/// <summary>1:N lk_sdkmessageprocessingstep_modifiedonbehalfby</summary>
			public const string LkSdkmessageprocessingstepModifiedonbehalfby = "lk_sdkmessageprocessingstep_modifiedonbehalfby";

			/// <summary>1:N lk_sdkmessageprocessingstepimage_createdonbehalfby</summary>
			public const string LkSdkmessageprocessingstepimageCreatedonbehalfby = "lk_sdkmessageprocessingstepimage_createdonbehalfby";

			/// <summary>1:N lk_sdkmessageprocessingstepimage_modifiedonbehalfby</summary>
			public const string LkSdkmessageprocessingstepimageModifiedonbehalfby = "lk_sdkmessageprocessingstepimage_modifiedonbehalfby";

			/// <summary>1:N lk_sdkmessageprocessingstepsecureconfig_createdonbehalfby</summary>
			public const string LkSdkmessageprocessingstepsecureconfigCreatedonbehalfby = "lk_sdkmessageprocessingstepsecureconfig_createdonbehalfby";

			/// <summary>1:N lk_sdkmessageprocessingstepsecureconfig_modifiedonbehalfby</summary>
			public const string LkSdkmessageprocessingstepsecureconfigModifiedonbehalfby = "lk_sdkmessageprocessingstepsecureconfig_modifiedonbehalfby";

			/// <summary>1:N lk_semiannualfiscalcalendar_createdby</summary>
			public const string LkSemiannualfiscalcalendarCreatedby = "lk_semiannualfiscalcalendar_createdby";

			/// <summary>1:N lk_semiannualfiscalcalendar_createdonbehalfby</summary>
			public const string LkSemiannualfiscalcalendarCreatedonbehalfby = "lk_semiannualfiscalcalendar_createdonbehalfby";

			/// <summary>1:N lk_semiannualfiscalcalendar_modifiedby</summary>
			public const string LkSemiannualfiscalcalendarModifiedby = "lk_semiannualfiscalcalendar_modifiedby";

			/// <summary>1:N lk_semiannualfiscalcalendar_modifiedonbehalfby</summary>
			public const string LkSemiannualfiscalcalendarModifiedonbehalfby = "lk_semiannualfiscalcalendar_modifiedonbehalfby";

			/// <summary>1:N lk_semiannualfiscalcalendar_salespersonid</summary>
			public const string LkSemiannualfiscalcalendarSalespersonid = "lk_semiannualfiscalcalendar_salespersonid";

			/// <summary>1:N lk_service_createdby</summary>
			public const string LkServiceCreatedby = "lk_service_createdby";

			/// <summary>1:N lk_service_createdonbehalfby</summary>
			public const string LkServiceCreatedonbehalfby = "lk_service_createdonbehalfby";

			/// <summary>1:N lk_service_modifiedby</summary>
			public const string LkServiceModifiedby = "lk_service_modifiedby";

			/// <summary>1:N lk_service_modifiedonbehalfby</summary>
			public const string LkServiceModifiedonbehalfby = "lk_service_modifiedonbehalfby";

			/// <summary>1:N lk_serviceappointment_createdby</summary>
			public const string LkServiceappointmentCreatedby = "lk_serviceappointment_createdby";

			/// <summary>1:N lk_serviceappointment_createdonbehalfby</summary>
			public const string LkServiceappointmentCreatedonbehalfby = "lk_serviceappointment_createdonbehalfby";

			/// <summary>1:N lk_serviceappointment_modifiedby</summary>
			public const string LkServiceappointmentModifiedby = "lk_serviceappointment_modifiedby";

			/// <summary>1:N lk_serviceappointment_modifiedonbehalfby</summary>
			public const string LkServiceappointmentModifiedonbehalfby = "lk_serviceappointment_modifiedonbehalfby";

			/// <summary>1:N lk_serviceendpointbase_createdonbehalfby</summary>
			public const string LkServiceendpointbaseCreatedonbehalfby = "lk_serviceendpointbase_createdonbehalfby";

			/// <summary>1:N lk_serviceendpointbase_modifiedonbehalfby</summary>
			public const string LkServiceendpointbaseModifiedonbehalfby = "lk_serviceendpointbase_modifiedonbehalfby";

			/// <summary>1:N lk_serviceplan_createdby</summary>
			public const string LkServiceplanCreatedby = "lk_serviceplan_createdby";

			/// <summary>1:N lk_serviceplan_createdonbehalfby</summary>
			public const string LkServiceplanCreatedonbehalfby = "lk_serviceplan_createdonbehalfby";

			/// <summary>1:N lk_serviceplan_modifiedby</summary>
			public const string LkServiceplanModifiedby = "lk_serviceplan_modifiedby";

			/// <summary>1:N lk_serviceplan_modifiedonbehalfby</summary>
			public const string LkServiceplanModifiedonbehalfby = "lk_serviceplan_modifiedonbehalfby";

			/// <summary>1:N lk_sharepointdocumentlocationbase_createdby</summary>
			public const string LkSharepointdocumentlocationbaseCreatedby = "lk_sharepointdocumentlocationbase_createdby";

			/// <summary>1:N lk_sharepointdocumentlocationbase_createdonbehalfby</summary>
			public const string LkSharepointdocumentlocationbaseCreatedonbehalfby = "lk_sharepointdocumentlocationbase_createdonbehalfby";

			/// <summary>1:N lk_sharepointdocumentlocationbase_modifiedby</summary>
			public const string LkSharepointdocumentlocationbaseModifiedby = "lk_sharepointdocumentlocationbase_modifiedby";

			/// <summary>1:N lk_sharepointdocumentlocationbase_modifiedonbehalfby</summary>
			public const string LkSharepointdocumentlocationbaseModifiedonbehalfby = "lk_sharepointdocumentlocationbase_modifiedonbehalfby";

			/// <summary>1:N lk_sharepointsitebase_createdby</summary>
			public const string LkSharepointsitebaseCreatedby = "lk_sharepointsitebase_createdby";

			/// <summary>1:N lk_sharepointsitebase_createdonbehalfby</summary>
			public const string LkSharepointsitebaseCreatedonbehalfby = "lk_sharepointsitebase_createdonbehalfby";

			/// <summary>1:N lk_sharepointsitebase_modifiedby</summary>
			public const string LkSharepointsitebaseModifiedby = "lk_sharepointsitebase_modifiedby";

			/// <summary>1:N lk_sharepointsitebase_modifiedonbehalfby</summary>
			public const string LkSharepointsitebaseModifiedonbehalfby = "lk_sharepointsitebase_modifiedonbehalfby";

			/// <summary>1:N lk_site_createdonbehalfby</summary>
			public const string LkSiteCreatedonbehalfby = "lk_site_createdonbehalfby";

			/// <summary>1:N lk_site_modifiedonbehalfby</summary>
			public const string LkSiteModifiedonbehalfby = "lk_site_modifiedonbehalfby";

			/// <summary>1:N lk_sitebase_createdby</summary>
			public const string LkSitebaseCreatedby = "lk_sitebase_createdby";

			/// <summary>1:N lk_sitebase_modifiedby</summary>
			public const string LkSitebaseModifiedby = "lk_sitebase_modifiedby";

			/// <summary>1:N lk_SiteMap_createdby</summary>
			public const string LkSiteMapCreatedby = "lk_SiteMap_createdby";

			/// <summary>1:N lk_SiteMap_createdonbehalfby</summary>
			public const string LkSiteMapCreatedonbehalfby = "lk_SiteMap_createdonbehalfby";

			/// <summary>1:N lk_SiteMap_modifiedby</summary>
			public const string LkSiteMapModifiedby = "lk_SiteMap_modifiedby";

			/// <summary>1:N lk_SiteMap_modifiedonbehalfby</summary>
			public const string LkSiteMapModifiedonbehalfby = "lk_SiteMap_modifiedonbehalfby";

			/// <summary>1:N lk_slabase_createdby</summary>
			public const string LkSlabaseCreatedby = "lk_slabase_createdby";

			/// <summary>1:N lk_slabase_createdonbehalfby</summary>
			public const string LkSlabaseCreatedonbehalfby = "lk_slabase_createdonbehalfby";

			/// <summary>1:N lk_slabase_modifiedby</summary>
			public const string LkSlabaseModifiedby = "lk_slabase_modifiedby";

			/// <summary>1:N lk_slabase_modifiedonbehalfby</summary>
			public const string LkSlabaseModifiedonbehalfby = "lk_slabase_modifiedonbehalfby";

			/// <summary>1:N lk_slaitembase_createdby</summary>
			public const string LkSlaitembaseCreatedby = "lk_slaitembase_createdby";

			/// <summary>1:N lk_slaitembase_createdonbehalfby</summary>
			public const string LkSlaitembaseCreatedonbehalfby = "lk_slaitembase_createdonbehalfby";

			/// <summary>1:N lk_slaitembase_modifiedby</summary>
			public const string LkSlaitembaseModifiedby = "lk_slaitembase_modifiedby";

			/// <summary>1:N lk_slaitembase_modifiedonbehalfby</summary>
			public const string LkSlaitembaseModifiedonbehalfby = "lk_slaitembase_modifiedonbehalfby";

			/// <summary>1:N lk_slakpiinstancebase_createdby</summary>
			public const string LkSlakpiinstancebaseCreatedby = "lk_slakpiinstancebase_createdby";

			/// <summary>1:N lk_slakpiinstancebase_createdonbehalfby</summary>
			public const string LkSlakpiinstancebaseCreatedonbehalfby = "lk_slakpiinstancebase_createdonbehalfby";

			/// <summary>1:N lk_slakpiinstancebase_modifiedby</summary>
			public const string LkSlakpiinstancebaseModifiedby = "lk_slakpiinstancebase_modifiedby";

			/// <summary>1:N lk_slakpiinstancebase_modifiedonbehalfby</summary>
			public const string LkSlakpiinstancebaseModifiedonbehalfby = "lk_slakpiinstancebase_modifiedonbehalfby";

			/// <summary>1:N lk_socialactivity_createdby</summary>
			public const string LkSocialactivityCreatedby = "lk_socialactivity_createdby";

			/// <summary>1:N lk_socialactivity_modifiedby</summary>
			public const string LkSocialactivityModifiedby = "lk_socialactivity_modifiedby";

			/// <summary>1:N lk_socialactivitybase_createdonbehalfby</summary>
			public const string LkSocialactivitybaseCreatedonbehalfby = "lk_socialactivitybase_createdonbehalfby";

			/// <summary>1:N lk_socialactivitybase_modifiedonbehalfby</summary>
			public const string LkSocialactivitybaseModifiedonbehalfby = "lk_socialactivitybase_modifiedonbehalfby";

			/// <summary>1:N lk_SocialProfile_createdonbehalfby</summary>
			public const string LkSocialProfileCreatedonbehalfby = "lk_SocialProfile_createdonbehalfby";

			/// <summary>1:N lk_SocialProfile_modifiedonbehalfby</summary>
			public const string LkSocialProfileModifiedonbehalfby = "lk_SocialProfile_modifiedonbehalfby";

			/// <summary>1:N lk_solution_createdby</summary>
			public const string LkSolutionCreatedby = "lk_solution_createdby";

			/// <summary>1:N lk_solution_modifiedby</summary>
			public const string LkSolutionModifiedby = "lk_solution_modifiedby";

			/// <summary>1:N lk_solutionbase_createdonbehalfby</summary>
			public const string LkSolutionbaseCreatedonbehalfby = "lk_solutionbase_createdonbehalfby";

			/// <summary>1:N lk_solutionbase_modifiedonbehalfby</summary>
			public const string LkSolutionbaseModifiedonbehalfby = "lk_solutionbase_modifiedonbehalfby";

			/// <summary>1:N lk_solutioncomponentattributeconfiguration_createdby</summary>
			public const string LkSolutioncomponentattributeconfigurationCreatedby = "lk_solutioncomponentattributeconfiguration_createdby";

			/// <summary>1:N lk_solutioncomponentattributeconfiguration_createdonbehalfby</summary>
			public const string LkSolutioncomponentattributeconfigurationCreatedonbehalfby = "lk_solutioncomponentattributeconfiguration_createdonbehalfby";

			/// <summary>1:N lk_solutioncomponentattributeconfiguration_modifiedby</summary>
			public const string LkSolutioncomponentattributeconfigurationModifiedby = "lk_solutioncomponentattributeconfiguration_modifiedby";

			/// <summary>1:N lk_solutioncomponentattributeconfiguration_modifiedonbehalfby</summary>
			public const string LkSolutioncomponentattributeconfigurationModifiedonbehalfby = "lk_solutioncomponentattributeconfiguration_modifiedonbehalfby";

			/// <summary>1:N lk_solutioncomponentbase_createdonbehalfby</summary>
			public const string LkSolutioncomponentbaseCreatedonbehalfby = "lk_solutioncomponentbase_createdonbehalfby";

			/// <summary>1:N lk_solutioncomponentbase_modifiedonbehalfby</summary>
			public const string LkSolutioncomponentbaseModifiedonbehalfby = "lk_solutioncomponentbase_modifiedonbehalfby";

			/// <summary>1:N lk_solutioncomponentconfiguration_createdby</summary>
			public const string LkSolutioncomponentconfigurationCreatedby = "lk_solutioncomponentconfiguration_createdby";

			/// <summary>1:N lk_solutioncomponentconfiguration_createdonbehalfby</summary>
			public const string LkSolutioncomponentconfigurationCreatedonbehalfby = "lk_solutioncomponentconfiguration_createdonbehalfby";

			/// <summary>1:N lk_solutioncomponentconfiguration_modifiedby</summary>
			public const string LkSolutioncomponentconfigurationModifiedby = "lk_solutioncomponentconfiguration_modifiedby";

			/// <summary>1:N lk_solutioncomponentconfiguration_modifiedonbehalfby</summary>
			public const string LkSolutioncomponentconfigurationModifiedonbehalfby = "lk_solutioncomponentconfiguration_modifiedonbehalfby";

			/// <summary>1:N lk_solutioncomponentrelationshipconfiguration_createdby</summary>
			public const string LkSolutioncomponentrelationshipconfigurationCreatedby = "lk_solutioncomponentrelationshipconfiguration_createdby";

			/// <summary>1:N lk_solutioncomponentrelationshipconfiguration_createdonbehalfby</summary>
			public const string LkSolutioncomponentrelationshipconfigurationCreatedonbehalfby = "lk_solutioncomponentrelationshipconfiguration_createdonbehalfby";

			/// <summary>1:N lk_solutioncomponentrelationshipconfiguration_modifiedby</summary>
			public const string LkSolutioncomponentrelationshipconfigurationModifiedby = "lk_solutioncomponentrelationshipconfiguration_modifiedby";

			/// <summary>1:N lk_solutioncomponentrelationshipconfiguration_modifiedonbehalfby</summary>
			public const string LkSolutioncomponentrelationshipconfigurationModifiedonbehalfby = "lk_solutioncomponentrelationshipconfiguration_modifiedonbehalfby";

			/// <summary>1:N lk_stagesolutionupload_createdby</summary>
			public const string LkStagesolutionuploadCreatedby = "lk_stagesolutionupload_createdby";

			/// <summary>1:N lk_stagesolutionupload_createdonbehalfby</summary>
			public const string LkStagesolutionuploadCreatedonbehalfby = "lk_stagesolutionupload_createdonbehalfby";

			/// <summary>1:N lk_stagesolutionupload_modifiedby</summary>
			public const string LkStagesolutionuploadModifiedby = "lk_stagesolutionupload_modifiedby";

			/// <summary>1:N lk_stagesolutionupload_modifiedonbehalfby</summary>
			public const string LkStagesolutionuploadModifiedonbehalfby = "lk_stagesolutionupload_modifiedonbehalfby";

			/// <summary>1:N lk_subject_createdonbehalfby</summary>
			public const string LkSubjectCreatedonbehalfby = "lk_subject_createdonbehalfby";

			/// <summary>1:N lk_subject_modifiedonbehalfby</summary>
			public const string LkSubjectModifiedonbehalfby = "lk_subject_modifiedonbehalfby";

			/// <summary>1:N lk_subjectbase_createdby</summary>
			public const string LkSubjectbaseCreatedby = "lk_subjectbase_createdby";

			/// <summary>1:N lk_subjectbase_modifiedby</summary>
			public const string LkSubjectbaseModifiedby = "lk_subjectbase_modifiedby";

			/// <summary>1:N lk_syncerrorbase_createdby</summary>
			public const string LkSyncerrorbaseCreatedby = "lk_syncerrorbase_createdby";

			/// <summary>1:N lk_syncerrorbase_createdonbehalfby</summary>
			public const string LkSyncerrorbaseCreatedonbehalfby = "lk_syncerrorbase_createdonbehalfby";

			/// <summary>1:N lk_syncerrorbase_modifiedby</summary>
			public const string LkSyncerrorbaseModifiedby = "lk_syncerrorbase_modifiedby";

			/// <summary>1:N lk_syncerrorbase_modifiedonbehalfby</summary>
			public const string LkSyncerrorbaseModifiedonbehalfby = "lk_syncerrorbase_modifiedonbehalfby";

			/// <summary>1:N lk_systemuser_createdonbehalfby</summary>
			public const string LkSystemuserCreatedonbehalfby = "lk_systemuser_createdonbehalfby";

			/// <summary>1:N lk_systemuser_modifiedonbehalfby</summary>
			public const string LkSystemuserModifiedonbehalfby = "lk_systemuser_modifiedonbehalfby";

			/// <summary>1:N lk_systemuserbase_createdby</summary>
			public const string LkSystemuserbaseCreatedby = "lk_systemuserbase_createdby";

			/// <summary>1:N lk_systemuserbase_modifiedby</summary>
			public const string LkSystemuserbaseModifiedby = "lk_systemuserbase_modifiedby";

			/// <summary>1:N lk_task_createdby</summary>
			public const string LkTaskCreatedby = "lk_task_createdby";

			/// <summary>1:N lk_task_createdonbehalfby</summary>
			public const string LkTaskCreatedonbehalfby = "lk_task_createdonbehalfby";

			/// <summary>1:N lk_task_modifiedby</summary>
			public const string LkTaskModifiedby = "lk_task_modifiedby";

			/// <summary>1:N lk_task_modifiedonbehalfby</summary>
			public const string LkTaskModifiedonbehalfby = "lk_task_modifiedonbehalfby";

			/// <summary>1:N lk_team_createdonbehalfby</summary>
			public const string LkTeamCreatedonbehalfby = "lk_team_createdonbehalfby";

			/// <summary>1:N lk_team_modifiedonbehalfby</summary>
			public const string LkTeamModifiedonbehalfby = "lk_team_modifiedonbehalfby";

			/// <summary>1:N lk_teambase_administratorid</summary>
			public const string LkTeambaseAdministratorid = "lk_teambase_administratorid";

			/// <summary>1:N lk_teambase_createdby</summary>
			public const string LkTeambaseCreatedby = "lk_teambase_createdby";

			/// <summary>1:N lk_teambase_modifiedby</summary>
			public const string LkTeambaseModifiedby = "lk_teambase_modifiedby";

			/// <summary>1:N lk_teamtemplate_createdby</summary>
			public const string LkTeamtemplateCreatedby = "lk_teamtemplate_createdby";

			/// <summary>1:N lk_teamtemplate_createdonbehalfby</summary>
			public const string LkTeamtemplateCreatedonbehalfby = "lk_teamtemplate_createdonbehalfby";

			/// <summary>1:N lk_teamtemplate_modifiedby</summary>
			public const string LkTeamtemplateModifiedby = "lk_teamtemplate_modifiedby";

			/// <summary>1:N lk_teamtemplate_modifiedonbehalfby</summary>
			public const string LkTeamtemplateModifiedonbehalfby = "lk_teamtemplate_modifiedonbehalfby";

			/// <summary>1:N lk_templatebase_createdby</summary>
			public const string LkTemplatebaseCreatedby = "lk_templatebase_createdby";

			/// <summary>1:N lk_templatebase_createdonbehalfby</summary>
			public const string LkTemplatebaseCreatedonbehalfby = "lk_templatebase_createdonbehalfby";

			/// <summary>1:N lk_templatebase_modifiedby</summary>
			public const string LkTemplatebaseModifiedby = "lk_templatebase_modifiedby";

			/// <summary>1:N lk_templatebase_modifiedonbehalfby</summary>
			public const string LkTemplatebaseModifiedonbehalfby = "lk_templatebase_modifiedonbehalfby";

			/// <summary>1:N lk_territory_createdonbehalfby</summary>
			public const string LkTerritoryCreatedonbehalfby = "lk_territory_createdonbehalfby";

			/// <summary>1:N lk_territory_modifiedonbehalfby</summary>
			public const string LkTerritoryModifiedonbehalfby = "lk_territory_modifiedonbehalfby";

			/// <summary>1:N lk_territorybase_createdby</summary>
			public const string LkTerritorybaseCreatedby = "lk_territorybase_createdby";

			/// <summary>1:N lk_territorybase_modifiedby</summary>
			public const string LkTerritorybaseModifiedby = "lk_territorybase_modifiedby";

			/// <summary>1:N lk_theme_createdby</summary>
			public const string LkThemeCreatedby = "lk_theme_createdby";

			/// <summary>1:N lk_theme_createdonbehalfby</summary>
			public const string LkThemeCreatedonbehalfby = "lk_theme_createdonbehalfby";

			/// <summary>1:N lk_theme_modifiedby</summary>
			public const string LkThemeModifiedby = "lk_theme_modifiedby";

			/// <summary>1:N lk_theme_modifiedonbehalfby</summary>
			public const string LkThemeModifiedonbehalfby = "lk_theme_modifiedonbehalfby";

			/// <summary>1:N lk_timezonedefinition_createdby</summary>
			public const string LkTimezonedefinitionCreatedby = "lk_timezonedefinition_createdby";

			/// <summary>1:N lk_timezonedefinition_createdonbehalfby</summary>
			public const string LkTimezonedefinitionCreatedonbehalfby = "lk_timezonedefinition_createdonbehalfby";

			/// <summary>1:N lk_timezonedefinition_modifiedby</summary>
			public const string LkTimezonedefinitionModifiedby = "lk_timezonedefinition_modifiedby";

			/// <summary>1:N lk_timezonedefinition_modifiedonbehalfby</summary>
			public const string LkTimezonedefinitionModifiedonbehalfby = "lk_timezonedefinition_modifiedonbehalfby";

			/// <summary>1:N lk_timezonelocalizedname_createdby</summary>
			public const string LkTimezonelocalizednameCreatedby = "lk_timezonelocalizedname_createdby";

			/// <summary>1:N lk_timezonelocalizedname_createdonbehalfby</summary>
			public const string LkTimezonelocalizednameCreatedonbehalfby = "lk_timezonelocalizedname_createdonbehalfby";

			/// <summary>1:N lk_timezonelocalizedname_modifiedby</summary>
			public const string LkTimezonelocalizednameModifiedby = "lk_timezonelocalizedname_modifiedby";

			/// <summary>1:N lk_timezonelocalizedname_modifiedonbehalfby</summary>
			public const string LkTimezonelocalizednameModifiedonbehalfby = "lk_timezonelocalizedname_modifiedonbehalfby";

			/// <summary>1:N lk_timezonerule_createdby</summary>
			public const string LkTimezoneruleCreatedby = "lk_timezonerule_createdby";

			/// <summary>1:N lk_timezonerule_createdonbehalfby</summary>
			public const string LkTimezoneruleCreatedonbehalfby = "lk_timezonerule_createdonbehalfby";

			/// <summary>1:N lk_timezonerule_modifiedby</summary>
			public const string LkTimezoneruleModifiedby = "lk_timezonerule_modifiedby";

			/// <summary>1:N lk_timezonerule_modifiedonbehalfby</summary>
			public const string LkTimezoneruleModifiedonbehalfby = "lk_timezonerule_modifiedonbehalfby";

			/// <summary>1:N lk_tracelog_createdby</summary>
			public const string LkTracelogCreatedby = "lk_tracelog_createdby";

			/// <summary>1:N lk_tracelog_createdonbehalfby</summary>
			public const string LkTracelogCreatedonbehalfby = "lk_tracelog_createdonbehalfby";

			/// <summary>1:N lk_tracelog_modifiedby</summary>
			public const string LkTracelogModifiedby = "lk_tracelog_modifiedby";

			/// <summary>1:N lk_tracelog_modifiedonbehalfby</summary>
			public const string LkTracelogModifiedonbehalfby = "lk_tracelog_modifiedonbehalfby";

			/// <summary>1:N lk_transactioncurrency_createdonbehalfby</summary>
			public const string LkTransactioncurrencyCreatedonbehalfby = "lk_transactioncurrency_createdonbehalfby";

			/// <summary>1:N lk_transactioncurrency_modifiedonbehalfby</summary>
			public const string LkTransactioncurrencyModifiedonbehalfby = "lk_transactioncurrency_modifiedonbehalfby";

			/// <summary>1:N lk_transactioncurrencybase_createdby</summary>
			public const string LkTransactioncurrencybaseCreatedby = "lk_transactioncurrencybase_createdby";

			/// <summary>1:N lk_transactioncurrencybase_modifiedby</summary>
			public const string LkTransactioncurrencybaseModifiedby = "lk_transactioncurrencybase_modifiedby";

			/// <summary>1:N lk_transformationmapping_createdby</summary>
			public const string LkTransformationmappingCreatedby = "lk_transformationmapping_createdby";

			/// <summary>1:N lk_transformationmapping_createdonbehalfby</summary>
			public const string LkTransformationmappingCreatedonbehalfby = "lk_transformationmapping_createdonbehalfby";

			/// <summary>1:N lk_transformationmapping_modifiedby</summary>
			public const string LkTransformationmappingModifiedby = "lk_transformationmapping_modifiedby";

			/// <summary>1:N lk_transformationmapping_modifiedonbehalfby</summary>
			public const string LkTransformationmappingModifiedonbehalfby = "lk_transformationmapping_modifiedonbehalfby";

			/// <summary>1:N lk_transformationparametermapping_createdby</summary>
			public const string LkTransformationparametermappingCreatedby = "lk_transformationparametermapping_createdby";

			/// <summary>1:N lk_transformationparametermapping_createdonbehalfby</summary>
			public const string LkTransformationparametermappingCreatedonbehalfby = "lk_transformationparametermapping_createdonbehalfby";

			/// <summary>1:N lk_transformationparametermapping_modifiedby</summary>
			public const string LkTransformationparametermappingModifiedby = "lk_transformationparametermapping_modifiedby";

			/// <summary>1:N lk_transformationparametermapping_modifiedonbehalfby</summary>
			public const string LkTransformationparametermappingModifiedonbehalfby = "lk_transformationparametermapping_modifiedonbehalfby";

			/// <summary>1:N lk_translationprocess_createdby</summary>
			public const string LkTranslationprocessCreatedby = "lk_translationprocess_createdby";

			/// <summary>1:N lk_translationprocess_createdonbehalfby</summary>
			public const string LkTranslationprocessCreatedonbehalfby = "lk_translationprocess_createdonbehalfby";

			/// <summary>1:N lk_translationprocess_modifiedby</summary>
			public const string LkTranslationprocessModifiedby = "lk_translationprocess_modifiedby";

			/// <summary>1:N lk_translationprocess_modifiedonbehalfby</summary>
			public const string LkTranslationprocessModifiedonbehalfby = "lk_translationprocess_modifiedonbehalfby";

			/// <summary>1:N lk_uom_createdonbehalfby</summary>
			public const string LkUomCreatedonbehalfby = "lk_uom_createdonbehalfby";

			/// <summary>1:N lk_uom_modifiedonbehalfby</summary>
			public const string LkUomModifiedonbehalfby = "lk_uom_modifiedonbehalfby";

			/// <summary>1:N lk_uombase_createdby</summary>
			public const string LkUombaseCreatedby = "lk_uombase_createdby";

			/// <summary>1:N lk_uombase_modifiedby</summary>
			public const string LkUombaseModifiedby = "lk_uombase_modifiedby";

			/// <summary>1:N lk_uomschedule_createdonbehalfby</summary>
			public const string LkUomscheduleCreatedonbehalfby = "lk_uomschedule_createdonbehalfby";

			/// <summary>1:N lk_uomschedule_modifiedonbehalfby</summary>
			public const string LkUomscheduleModifiedonbehalfby = "lk_uomschedule_modifiedonbehalfby";

			/// <summary>1:N lk_uomschedulebase_createdby</summary>
			public const string LkUomschedulebaseCreatedby = "lk_uomschedulebase_createdby";

			/// <summary>1:N lk_uomschedulebase_modifiedby</summary>
			public const string LkUomschedulebaseModifiedby = "lk_uomschedulebase_modifiedby";

			/// <summary>1:N lk_userform_createdby</summary>
			public const string LkUserformCreatedby = "lk_userform_createdby";

			/// <summary>1:N lk_userform_modifiedby</summary>
			public const string LkUserformModifiedby = "lk_userform_modifiedby";

			/// <summary>1:N lk_userformbase_createdonbehalfby</summary>
			public const string LkUserformbaseCreatedonbehalfby = "lk_userformbase_createdonbehalfby";

			/// <summary>1:N lk_userformbase_modifiedonbehalfby</summary>
			public const string LkUserformbaseModifiedonbehalfby = "lk_userformbase_modifiedonbehalfby";

			/// <summary>1:N lk_usermapping_createdby</summary>
			public const string LkUsermappingCreatedby = "lk_usermapping_createdby";

			/// <summary>1:N lk_usermapping_createdonbehalfby</summary>
			public const string LkUsermappingCreatedonbehalfby = "lk_usermapping_createdonbehalfby";

			/// <summary>1:N lk_usermapping_modifiedby</summary>
			public const string LkUsermappingModifiedby = "lk_usermapping_modifiedby";

			/// <summary>1:N lk_usermapping_modifiedonbehalfby</summary>
			public const string LkUsermappingModifiedonbehalfby = "lk_usermapping_modifiedonbehalfby";

			/// <summary>1:N lk_userquery_createdby</summary>
			public const string LkUserqueryCreatedby = "lk_userquery_createdby";

			/// <summary>1:N lk_userquery_createdonbehalfby</summary>
			public const string LkUserqueryCreatedonbehalfby = "lk_userquery_createdonbehalfby";

			/// <summary>1:N lk_userquery_modifiedby</summary>
			public const string LkUserqueryModifiedby = "lk_userquery_modifiedby";

			/// <summary>1:N lk_userquery_modifiedonbehalfby</summary>
			public const string LkUserqueryModifiedonbehalfby = "lk_userquery_modifiedonbehalfby";

			/// <summary>1:N lk_userqueryvisualization_createdby</summary>
			public const string LkUserqueryvisualizationCreatedby = "lk_userqueryvisualization_createdby";

			/// <summary>1:N lk_userqueryvisualization_modifiedby</summary>
			public const string LkUserqueryvisualizationModifiedby = "lk_userqueryvisualization_modifiedby";

			/// <summary>1:N lk_userqueryvisualizationbase_createdonbehalfby</summary>
			public const string LkUserqueryvisualizationbaseCreatedonbehalfby = "lk_userqueryvisualizationbase_createdonbehalfby";

			/// <summary>1:N lk_userqueryvisualizationbase_modifiedonbehalfby</summary>
			public const string LkUserqueryvisualizationbaseModifiedonbehalfby = "lk_userqueryvisualizationbase_modifiedonbehalfby";

			/// <summary>1:N lk_usersettings_createdonbehalfby</summary>
			public const string LkUsersettingsCreatedonbehalfby = "lk_usersettings_createdonbehalfby";

			/// <summary>1:N lk_usersettings_modifiedonbehalfby</summary>
			public const string LkUsersettingsModifiedonbehalfby = "lk_usersettings_modifiedonbehalfby";

			/// <summary>1:N lk_usersettingsbase_createdby</summary>
			public const string LkUsersettingsbaseCreatedby = "lk_usersettingsbase_createdby";

			/// <summary>1:N lk_usersettingsbase_modifiedby</summary>
			public const string LkUsersettingsbaseModifiedby = "lk_usersettingsbase_modifiedby";

			/// <summary>1:N lk_webresourcebase_createdonbehalfby</summary>
			public const string LkWebresourcebaseCreatedonbehalfby = "lk_webresourcebase_createdonbehalfby";

			/// <summary>1:N lk_webresourcebase_modifiedonbehalfby</summary>
			public const string LkWebresourcebaseModifiedonbehalfby = "lk_webresourcebase_modifiedonbehalfby";

			/// <summary>1:N lk_webwizard_createdby</summary>
			public const string LkWebwizardCreatedby = "lk_webwizard_createdby";

			/// <summary>1:N lk_webwizard_createdonbehalfby</summary>
			public const string LkWebwizardCreatedonbehalfby = "lk_webwizard_createdonbehalfby";

			/// <summary>1:N lk_webwizard_modifiedby</summary>
			public const string LkWebwizardModifiedby = "lk_webwizard_modifiedby";

			/// <summary>1:N lk_webwizard_modifiedonbehalfby</summary>
			public const string LkWebwizardModifiedonbehalfby = "lk_webwizard_modifiedonbehalfby";

			/// <summary>1:N lk_workflowbinary_createdby</summary>
			public const string LkWorkflowbinaryCreatedby = "lk_workflowbinary_createdby";

			/// <summary>1:N lk_workflowbinary_createdonbehalfby</summary>
			public const string LkWorkflowbinaryCreatedonbehalfby = "lk_workflowbinary_createdonbehalfby";

			/// <summary>1:N lk_workflowbinary_modifiedby</summary>
			public const string LkWorkflowbinaryModifiedby = "lk_workflowbinary_modifiedby";

			/// <summary>1:N lk_workflowbinary_modifiedonbehalfby</summary>
			public const string LkWorkflowbinaryModifiedonbehalfby = "lk_workflowbinary_modifiedonbehalfby";

			/// <summary>1:N lk_workflowlog_createdby</summary>
			public const string LkWorkflowlogCreatedby = "lk_workflowlog_createdby";

			/// <summary>1:N lk_workflowlog_createdonbehalfby</summary>
			public const string LkWorkflowlogCreatedonbehalfby = "lk_workflowlog_createdonbehalfby";

			/// <summary>1:N lk_workflowlog_modifiedby</summary>
			public const string LkWorkflowlogModifiedby = "lk_workflowlog_modifiedby";

			/// <summary>1:N lk_workflowlog_modifiedonbehalfby</summary>
			public const string LkWorkflowlogModifiedonbehalfby = "lk_workflowlog_modifiedonbehalfby";

			/// <summary>1:N mailbox_regarding_systemuser</summary>
			public const string MailboxRegardingSystemuser = "mailbox_regarding_systemuser";

			/// <summary>1:N modifiedby_connection</summary>
			public const string ModifiedbyConnection = "modifiedby_connection";

			/// <summary>1:N modifiedby_connection_role</summary>
			public const string ModifiedbyConnectionRole = "modifiedby_connection_role";

			/// <summary>1:N modifiedby_pluginassembly</summary>
			public const string ModifiedbyPluginassembly = "modifiedby_pluginassembly";

			/// <summary>1:N modifiedby_plugintype</summary>
			public const string ModifiedbyPlugintype = "modifiedby_plugintype";

			/// <summary>1:N modifiedby_plugintypestatistic</summary>
			public const string ModifiedbyPlugintypestatistic = "modifiedby_plugintypestatistic";

			/// <summary>1:N modifiedby_sdkmessage</summary>
			public const string ModifiedbySdkmessage = "modifiedby_sdkmessage";

			/// <summary>1:N modifiedby_sdkmessagefilter</summary>
			public const string ModifiedbySdkmessagefilter = "modifiedby_sdkmessagefilter";

			/// <summary>1:N modifiedby_sdkmessageprocessingstep</summary>
			public const string ModifiedbySdkmessageprocessingstep = "modifiedby_sdkmessageprocessingstep";

			/// <summary>1:N modifiedby_sdkmessageprocessingstepimage</summary>
			public const string ModifiedbySdkmessageprocessingstepimage = "modifiedby_sdkmessageprocessingstepimage";

			/// <summary>1:N modifiedby_sdkmessageprocessingstepsecureconfig</summary>
			public const string ModifiedbySdkmessageprocessingstepsecureconfig = "modifiedby_sdkmessageprocessingstepsecureconfig";

			/// <summary>1:N modifiedby_serviceendpoint</summary>
			public const string ModifiedbyServiceendpoint = "modifiedby_serviceendpoint";

			/// <summary>1:N msdyn_systemuser_wallsavedqueryusersettings_userid</summary>
			public const string MsdynSystemuserWallsavedqueryusersettingsUserid = "msdyn_systemuser_wallsavedqueryusersettings_userid";

			/// <summary>1:N opportunity_owning_user</summary>
			public const string OpportunityOwningUser = "opportunity_owning_user";

			/// <summary>1:N OwnerMapping_SystemUser</summary>
			public const string OwnerMappingSystemUser = "OwnerMapping_SystemUser";

			/// <summary>1:N OwningUser_Dynamicpropertyinsatance</summary>
			public const string OwningUserDynamicpropertyinsatance = "OwningUser_Dynamicpropertyinsatance";

			/// <summary>1:N queue_primary_user</summary>
			public const string QueuePrimaryUser = "queue_primary_user";

			/// <summary>1:N socialProfile_owning_user</summary>
			public const string SocialProfileOwningUser = "socialProfile_owning_user";

			/// <summary>1:N system_user_accounts</summary>
			public const string SystemUserAccounts = "system_user_accounts";

			/// <summary>1:N system_user_activity_parties</summary>
			public const string SystemUserActivityParties = "system_user_activity_parties";

			/// <summary>1:N system_user_asyncoperation</summary>
			public const string SystemUserAsyncoperation = "system_user_asyncoperation";

			/// <summary>1:N system_user_contacts</summary>
			public const string SystemUserContacts = "system_user_contacts";

			/// <summary>1:N system_user_email_templates</summary>
			public const string SystemUserEmailTemplates = "system_user_email_templates";

			/// <summary>1:N system_user_incidents</summary>
			public const string SystemUserIncidents = "system_user_incidents";

			/// <summary>1:N system_user_invoicedetail</summary>
			public const string SystemUserInvoicedetail = "system_user_invoicedetail";

			/// <summary>1:N system_user_invoices</summary>
			public const string SystemUserInvoices = "system_user_invoices";

			/// <summary>1:N system_user_orders</summary>
			public const string SystemUserOrders = "system_user_orders";

			/// <summary>1:N system_user_quotedetail</summary>
			public const string SystemUserQuotedetail = "system_user_quotedetail";

			/// <summary>1:N system_user_quotes</summary>
			public const string SystemUserQuotes = "system_user_quotes";

			/// <summary>1:N system_user_sales_literature</summary>
			public const string SystemUserSalesLiterature = "system_user_sales_literature";

			/// <summary>1:N system_user_salesorderdetail</summary>
			public const string SystemUserSalesorderdetail = "system_user_salesorderdetail";

			/// <summary>1:N system_user_service_appointments</summary>
			public const string SystemUserServiceAppointments = "system_user_service_appointments";

			/// <summary>1:N system_user_service_contracts</summary>
			public const string SystemUserServiceContracts = "system_user_service_contracts";

			/// <summary>1:N system_user_territories</summary>
			public const string SystemUserTerritories = "system_user_territories";

			/// <summary>1:N system_user_workflow</summary>
			public const string SystemUserWorkflow = "system_user_workflow";

			/// <summary>1:N SystemUser_AsyncOperations</summary>
			public const string SystemUserAsyncOperations = "SystemUser_AsyncOperations";

			/// <summary>1:N systemuser_bookableresource_UserId</summary>
			public const string SystemuserBookableresourceUserId = "systemuser_bookableresource_UserId";

			/// <summary>1:N systemuser_bot_publishedby</summary>
			public const string SystemuserBotPublishedby = "systemuser_bot_publishedby";

			/// <summary>1:N SystemUser_BulkDeleteFailures</summary>
			public const string SystemUserBulkDeleteFailures = "SystemUser_BulkDeleteFailures";

			/// <summary>1:N SystemUser_Campaigns</summary>
			public const string SystemUserCampaigns = "SystemUser_Campaigns";

			/// <summary>1:N systemuser_connections1</summary>
			public const string SystemuserConnections1 = "systemuser_connections1";

			/// <summary>1:N systemuser_connections2</summary>
			public const string SystemuserConnections2 = "systemuser_connections2";

			/// <summary>1:N SystemUser_DuplicateBaseRecord</summary>
			public const string SystemUserDuplicateBaseRecord = "SystemUser_DuplicateBaseRecord";

			/// <summary>1:N SystemUser_DuplicateMatchingRecord</summary>
			public const string SystemUserDuplicateMatchingRecord = "SystemUser_DuplicateMatchingRecord";

			/// <summary>1:N SystemUser_DuplicateRules</summary>
			public const string SystemUserDuplicateRules = "SystemUser_DuplicateRules";

			/// <summary>1:N SystemUser_Email_EmailSender</summary>
			public const string SystemUserEmailEmailSender = "SystemUser_Email_EmailSender";

			/// <summary>1:N SystemUser_ImportData</summary>
			public const string SystemUserImportData = "SystemUser_ImportData";

			/// <summary>1:N SystemUser_ImportFiles</summary>
			public const string SystemUserImportFiles = "SystemUser_ImportFiles";

			/// <summary>1:N SystemUser_ImportLogs</summary>
			public const string SystemUserImportLogs = "SystemUser_ImportLogs";

			/// <summary>1:N SystemUser_ImportMaps</summary>
			public const string SystemUserImportMaps = "SystemUser_ImportMaps";

			/// <summary>1:N SystemUser_Imports</summary>
			public const string SystemUserImports = "SystemUser_Imports";

			/// <summary>1:N systemuser_PostFollows</summary>
			public const string SystemuserPostFollows = "systemuser_PostFollows";

			/// <summary>1:N systemuser_principalobjectattributeaccess</summary>
			public const string SystemuserPrincipalobjectattributeaccess = "systemuser_principalobjectattributeaccess";

			/// <summary>1:N systemuser_principalobjectattributeaccess_principalid</summary>
			public const string SystemuserPrincipalobjectattributeaccessPrincipalid = "systemuser_principalobjectattributeaccess_principalid";

			/// <summary>1:N SystemUser_ProcessSessions</summary>
			public const string SystemUserProcessSessions = "SystemUser_ProcessSessions";

			/// <summary>1:N systemuser_resources</summary>
			public const string SystemuserResources = "systemuser_resources";

			/// <summary>1:N SystemUser_SyncError</summary>
			public const string SystemUserSyncError = "SystemUser_SyncError";

			/// <summary>1:N SystemUser_SyncErrors</summary>
			public const string SystemUserSyncErrors = "SystemUser_SyncErrors";

			/// <summary>1:N user_accounts</summary>
			public const string UserAccounts = "user_accounts";

			/// <summary>1:N user_activity</summary>
			public const string UserActivity = "user_activity";

			/// <summary>1:N user_activitymonitor</summary>
			public const string UserActivitymonitor = "user_activitymonitor";

			/// <summary>1:N user_adminsettingsentity</summary>
			public const string UserAdminsettingsentity = "user_adminsettingsentity";

			/// <summary>1:N user_appointment</summary>
			public const string UserAppointment = "user_appointment";

			/// <summary>1:N user_bookableresource</summary>
			public const string UserBookableresource = "user_bookableresource";

			/// <summary>1:N user_bookableresourcebooking</summary>
			public const string UserBookableresourcebooking = "user_bookableresourcebooking";

			/// <summary>1:N user_bookableresourcebookingheader</summary>
			public const string UserBookableresourcebookingheader = "user_bookableresourcebookingheader";

			/// <summary>1:N user_bookableresourcecategory</summary>
			public const string UserBookableresourcecategory = "user_bookableresourcecategory";

			/// <summary>1:N user_bookableresourcecategoryassn</summary>
			public const string UserBookableresourcecategoryassn = "user_bookableresourcecategoryassn";

			/// <summary>1:N user_bookableresourcecharacteristic</summary>
			public const string UserBookableresourcecharacteristic = "user_bookableresourcecharacteristic";

			/// <summary>1:N user_bookableresourcegroup</summary>
			public const string UserBookableresourcegroup = "user_bookableresourcegroup";

			/// <summary>1:N user_bookingstatus</summary>
			public const string UserBookingstatus = "user_bookingstatus";

			/// <summary>1:N user_bot</summary>
			public const string UserBot = "user_bot";

			/// <summary>1:N user_botcomponent</summary>
			public const string UserBotcomponent = "user_botcomponent";

			/// <summary>1:N user_BulkOperation</summary>
			public const string UserBulkOperation = "user_BulkOperation";

			/// <summary>1:N user_campaignactivity</summary>
			public const string UserCampaignactivity = "user_campaignactivity";

			/// <summary>1:N user_campaignresponse</summary>
			public const string UserCampaignresponse = "user_campaignresponse";

			/// <summary>1:N user_characteristic</summary>
			public const string UserCharacteristic = "user_characteristic";

			/// <summary>1:N user_connectionreference</summary>
			public const string UserConnectionreference = "user_connectionreference";

			/// <summary>1:N user_connector</summary>
			public const string UserConnector = "user_connector";

			/// <summary>1:N user_contractdetail</summary>
			public const string UserContractdetail = "user_contractdetail";

			/// <summary>1:N user_conversationtranscript</summary>
			public const string UserConversationtranscript = "user_conversationtranscript";

			/// <summary>1:N user_customapi</summary>
			public const string UserCustomapi = "user_customapi";

			/// <summary>1:N user_customapirequestparameter</summary>
			public const string UserCustomapirequestparameter = "user_customapirequestparameter";

			/// <summary>1:N user_customapiresponseproperty</summary>
			public const string UserCustomapiresponseproperty = "user_customapiresponseproperty";

			/// <summary>1:N user_datalakefolder</summary>
			public const string UserDatalakefolder = "user_datalakefolder";

			/// <summary>1:N user_datalakefolderpermission</summary>
			public const string UserDatalakefolderpermission = "user_datalakefolderpermission";

			/// <summary>1:N user_email</summary>
			public const string UserEmail = "user_email";

			/// <summary>1:N user_entitlement</summary>
			public const string UserEntitlement = "user_entitlement";

			/// <summary>1:N user_entitlementchannel</summary>
			public const string UserEntitlementchannel = "user_entitlementchannel";

			/// <summary>1:N user_entitlemententityallocationtypemapping</summary>
			public const string UserEntitlemententityallocationtypemapping = "user_entitlemententityallocationtypemapping";

			/// <summary>1:N user_environmentvariabledefinition</summary>
			public const string UserEnvironmentvariabledefinition = "user_environmentvariabledefinition";

			/// <summary>1:N user_environmentvariablevalue</summary>
			public const string UserEnvironmentvariablevalue = "user_environmentvariablevalue";

			/// <summary>1:N user_exchangesyncidmapping</summary>
			public const string UserExchangesyncidmapping = "user_exchangesyncidmapping";

			/// <summary>1:N user_exportsolutionupload</summary>
			public const string UserExportsolutionupload = "user_exportsolutionupload";

			/// <summary>1:N user_fax</summary>
			public const string UserFax = "user_fax";

			/// <summary>1:N user_flowsession</summary>
			public const string UserFlowsession = "user_flowsession";

			/// <summary>1:N user_goal</summary>
			public const string UserGoal = "user_goal";

			/// <summary>1:N user_goal_goalowner</summary>
			public const string UserGoalGoalowner = "user_goal_goalowner";

			/// <summary>1:N user_incidentresolution</summary>
			public const string UserIncidentresolution = "user_incidentresolution";

			/// <summary>1:N user_interactionforemail</summary>
			public const string UserInteractionforemail = "user_interactionforemail";

			/// <summary>1:N user_invoicedetail</summary>
			public const string UserInvoicedetail = "user_invoicedetail";

			/// <summary>1:N user_knowledgearticle</summary>
			public const string UserKnowledgearticle = "user_knowledgearticle";

			/// <summary>1:N user_knowledgearticleincident</summary>
			public const string UserKnowledgearticleincident = "user_knowledgearticleincident";

			/// <summary>1:N user_letter</summary>
			public const string UserLetter = "user_letter";

			/// <summary>1:N user_list</summary>
			public const string UserList = "user_list";

			/// <summary>1:N user_listoperation</summary>
			public const string UserListoperation = "user_listoperation";

			/// <summary>1:N user_mailbox</summary>
			public const string UserMailbox = "user_mailbox";

			/// <summary>1:N user_msdyn_actioncardregarding</summary>
			public const string UserMsdynActioncardregarding = "user_msdyn_actioncardregarding";

			/// <summary>1:N user_msdyn_actioncardrolesetting</summary>
			public const string UserMsdynActioncardrolesetting = "user_msdyn_actioncardrolesetting";

			/// <summary>1:N user_msdyn_aibdataset</summary>
			public const string UserMsdynAibdataset = "user_msdyn_aibdataset";

			/// <summary>1:N user_msdyn_aibdatasetfile</summary>
			public const string UserMsdynAibdatasetfile = "user_msdyn_aibdatasetfile";

			/// <summary>1:N user_msdyn_aibdatasetrecord</summary>
			public const string UserMsdynAibdatasetrecord = "user_msdyn_aibdatasetrecord";

			/// <summary>1:N user_msdyn_aibdatasetscontainer</summary>
			public const string UserMsdynAibdatasetscontainer = "user_msdyn_aibdatasetscontainer";

			/// <summary>1:N user_msdyn_aibfile</summary>
			public const string UserMsdynAibfile = "user_msdyn_aibfile";

			/// <summary>1:N user_msdyn_aibfileattacheddata</summary>
			public const string UserMsdynAibfileattacheddata = "user_msdyn_aibfileattacheddata";

			/// <summary>1:N user_msdyn_aiconfiguration</summary>
			public const string UserMsdynAiconfiguration = "user_msdyn_aiconfiguration";

			/// <summary>1:N user_msdyn_aifptrainingdocument</summary>
			public const string UserMsdynAifptrainingdocument = "user_msdyn_aifptrainingdocument";

			/// <summary>1:N user_msdyn_aimodel</summary>
			public const string UserMsdynAimodel = "user_msdyn_aimodel";

			/// <summary>1:N user_msdyn_aiodimage</summary>
			public const string UserMsdynAiodimage = "user_msdyn_aiodimage";

			/// <summary>1:N user_msdyn_aiodlabel</summary>
			public const string UserMsdynAiodlabel = "user_msdyn_aiodlabel";

			/// <summary>1:N user_msdyn_aiodtrainingboundingbox</summary>
			public const string UserMsdynAiodtrainingboundingbox = "user_msdyn_aiodtrainingboundingbox";

			/// <summary>1:N user_msdyn_aiodtrainingimage</summary>
			public const string UserMsdynAiodtrainingimage = "user_msdyn_aiodtrainingimage";

			/// <summary>1:N user_msdyn_aitemplate</summary>
			public const string UserMsdynAitemplate = "user_msdyn_aitemplate";

			/// <summary>1:N user_msdyn_autocapturerule</summary>
			public const string UserMsdynAutocapturerule = "user_msdyn_autocapturerule";

			/// <summary>1:N user_msdyn_autocapturesettings</summary>
			public const string UserMsdynAutocapturesettings = "user_msdyn_autocapturesettings";

			/// <summary>1:N user_msdyn_callablecontext</summary>
			public const string UserMsdynCallablecontext = "user_msdyn_callablecontext";

			/// <summary>1:N user_msdyn_entityrankingrule</summary>
			public const string UserMsdynEntityrankingrule = "user_msdyn_entityrankingrule";

			/// <summary>1:N user_msdyn_federatedarticle</summary>
			public const string UserMsdynFederatedarticle = "user_msdyn_federatedarticle";

			/// <summary>1:N user_msdyn_flowcardtype</summary>
			public const string UserMsdynFlowcardtype = "user_msdyn_flowcardtype";

			/// <summary>1:N user_msdyn_icebreakersconfig</summary>
			public const string UserMsdynIcebreakersconfig = "user_msdyn_icebreakersconfig";

			/// <summary>1:N user_msdyn_kmfederatedsearchconfig</summary>
			public const string UserMsdynKmfederatedsearchconfig = "user_msdyn_kmfederatedsearchconfig";

			/// <summary>1:N user_msdyn_knowledgearticleimage</summary>
			public const string UserMsdynKnowledgearticleimage = "user_msdyn_knowledgearticleimage";

			/// <summary>1:N user_msdyn_knowledgearticletemplate</summary>
			public const string UserMsdynKnowledgearticletemplate = "user_msdyn_knowledgearticletemplate";

			/// <summary>1:N user_msdyn_knowledgeinteractioninsight</summary>
			public const string UserMsdynKnowledgeinteractioninsight = "user_msdyn_knowledgeinteractioninsight";

			/// <summary>1:N user_msdyn_knowledgesearchinsight</summary>
			public const string UserMsdynKnowledgesearchinsight = "user_msdyn_knowledgesearchinsight";

			/// <summary>1:N user_msdyn_msteamssetting</summary>
			public const string UserMsdynMsteamssetting = "user_msdyn_msteamssetting";

			/// <summary>1:N user_msdyn_notesanalysisconfig</summary>
			public const string UserMsdynNotesanalysisconfig = "user_msdyn_notesanalysisconfig";

			/// <summary>1:N user_msdyn_playbookactivity</summary>
			public const string UserMsdynPlaybookactivity = "user_msdyn_playbookactivity";

			/// <summary>1:N user_msdyn_playbookactivityattribute</summary>
			public const string UserMsdynPlaybookactivityattribute = "user_msdyn_playbookactivityattribute";

			/// <summary>1:N user_msdyn_playbookcategory</summary>
			public const string UserMsdynPlaybookcategory = "user_msdyn_playbookcategory";

			/// <summary>1:N user_msdyn_playbookinstance</summary>
			public const string UserMsdynPlaybookinstance = "user_msdyn_playbookinstance";

			/// <summary>1:N user_msdyn_playbooktemplate</summary>
			public const string UserMsdynPlaybooktemplate = "user_msdyn_playbooktemplate";

			/// <summary>1:N user_msdyn_postalbum</summary>
			public const string UserMsdynPostalbum = "user_msdyn_postalbum";

			/// <summary>1:N user_msdyn_relationshipinsightsunifiedconfig</summary>
			public const string UserMsdynRelationshipinsightsunifiedconfig = "user_msdyn_relationshipinsightsunifiedconfig";

			/// <summary>1:N user_msdyn_richtextfile</summary>
			public const string UserMsdynRichtextfile = "user_msdyn_richtextfile";

			/// <summary>1:N user_msdyn_salesinsightssettings</summary>
			public const string UserMsdynSalesinsightssettings = "user_msdyn_salesinsightssettings";

			/// <summary>1:N user_msdyn_siconfig</summary>
			public const string UserMsdynSiconfig = "user_msdyn_siconfig";

			/// <summary>1:N user_msdyn_untrackedappointment</summary>
			public const string UserMsdynUntrackedappointment = "user_msdyn_untrackedappointment";

			/// <summary>1:N user_msdyn_wallsavedqueryusersettings</summary>
			public const string UserMsdynWallsavedqueryusersettings = "user_msdyn_wallsavedqueryusersettings";

			/// <summary>1:N user_msdynce_botcontent</summary>
			public const string UserMsdynceBotcontent = "user_msdynce_botcontent";

			/// <summary>1:N user_opportunityclose</summary>
			public const string UserOpportunityclose = "user_opportunityclose";

			/// <summary>1:N user_opportunityproduct</summary>
			public const string UserOpportunityproduct = "user_opportunityproduct";

			/// <summary>1:N user_orderclose</summary>
			public const string UserOrderclose = "user_orderclose";

			/// <summary>1:N user_owner_postfollows</summary>
			public const string UserOwnerPostfollows = "user_owner_postfollows";

			/// <summary>1:N user_parent_user</summary>
			public const string UserParentUser = "user_parent_user";

			/// <summary>1:N user_phonecall</summary>
			public const string UserPhonecall = "user_phonecall";

			/// <summary>1:N user_processstageparameter</summary>
			public const string UserProcessstageparameter = "user_processstageparameter";

			/// <summary>1:N user_pw_penta_schedule_run</summary>
			public const string UserPwPentaScheduleRun = "user_pw_penta_schedule_run";

			/// <summary>1:N user_pw_schedule</summary>
			public const string UserPwSchedule = "user_pw_schedule";

			/// <summary>1:N user_quoteclose</summary>
			public const string UserQuoteclose = "user_quoteclose";

			/// <summary>1:N user_quotedetail</summary>
			public const string UserQuotedetail = "user_quotedetail";

			/// <summary>1:N user_ratingmodel</summary>
			public const string UserRatingmodel = "user_ratingmodel";

			/// <summary>1:N user_ratingvalue</summary>
			public const string UserRatingvalue = "user_ratingvalue";

			/// <summary>1:N user_recurringappointmentmaster</summary>
			public const string UserRecurringappointmentmaster = "user_recurringappointmentmaster";

			/// <summary>1:N user_salesorderdetail</summary>
			public const string UserSalesorderdetail = "user_salesorderdetail";

			/// <summary>1:N user_settings</summary>
			public const string UserSettings = "user_settings";

			/// <summary>1:N user_sharepointdocumentlocation</summary>
			public const string UserSharepointdocumentlocation = "user_sharepointdocumentlocation";

			/// <summary>1:N user_sharepointsite</summary>
			public const string UserSharepointsite = "user_sharepointsite";

			/// <summary>1:N user_slabase</summary>
			public const string UserSlabase = "user_slabase";

			/// <summary>1:N user_socialactivity</summary>
			public const string UserSocialactivity = "user_socialactivity";

			/// <summary>1:N user_stagesolutionupload</summary>
			public const string UserStagesolutionupload = "user_stagesolutionupload";

			/// <summary>1:N user_task</summary>
			public const string UserTask = "user_task";

			/// <summary>1:N user_userform</summary>
			public const string UserUserform = "user_userform";

			/// <summary>1:N user_userquery</summary>
			public const string UserUserquery = "user_userquery";

			/// <summary>1:N user_userqueryvisualizations</summary>
			public const string UserUserqueryvisualizations = "user_userqueryvisualizations";

			/// <summary>1:N user_workflowbinary</summary>
			public const string UserWorkflowbinary = "user_workflowbinary";

			/// <summary>1:N webresource_createdby</summary>
			public const string WebresourceCreatedby = "webresource_createdby";

			/// <summary>1:N webresource_modifiedby</summary>
			public const string WebresourceModifiedby = "webresource_modifiedby";

			/// <summary>1:N workflow_createdby</summary>
			public const string WorkflowCreatedby = "workflow_createdby";

			/// <summary>1:N workflow_createdonbehalfby</summary>
			public const string WorkflowCreatedonbehalfby = "workflow_createdonbehalfby";

			/// <summary>1:N workflow_modifiedby</summary>
			public const string WorkflowModifiedby = "workflow_modifiedby";

			/// <summary>1:N workflow_modifiedonbehalfby</summary>
			public const string WorkflowModifiedonbehalfby = "workflow_modifiedonbehalfby";

			/// <summary>N:N queuemembership_association</summary>
			public const string QueuemembershipAssociation = "queuemembership_association";

			/// <summary>N:N systemuserprofiles_association</summary>
			public const string SystemuserprofilesAssociation = "systemuserprofiles_association";

			/// <summary>N:N systemuserroles_association</summary>
			public const string SystemuserrolesAssociation = "systemuserroles_association";

			/// <summary>N:N teammembership_association</summary>
			public const string TeammembershipAssociation = "teammembership_association";

		}
		#endregion
	}
}

