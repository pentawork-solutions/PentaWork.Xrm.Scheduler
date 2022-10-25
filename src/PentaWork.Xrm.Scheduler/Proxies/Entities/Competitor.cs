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
	[EntityLogicalName("competitor")]
	public sealed class Competitor : Entity
	{	
		public static readonly int? EntityTypeCode = 123;
		public new const string LogicalName = "competitor";
		public const string PrimaryIdAttribute = "competitorid";
		public const string PrimaryNameAttribute = "name";
	
		public Competitor() : base("competitor") { }

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
        /// competitorid
        /// </summary>
		[DisplayName("Competitor")]
		[AttributeLogicalName("competitorid")]
		public override Guid Id
		{
			get => base.Id;
			set { base.Id = value; SetAttributeValue("competitorid", value); }
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
        /// keyproduct
        /// </summary>
		[DisplayName("Key Product")]
		[AttributeLogicalName("keyproduct")]
		public string KeyProduct
		{	
			get { return GetAttributeValue<string>("keyproduct"); }
			set
			{ 
				if(value == KeyProduct) return;
				SetAttributeValue("keyproduct", value);
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
        /// opportunities
        /// </summary>
		[DisplayName("Opportunity")]
		[AttributeLogicalName("opportunities")]
		public string Opportunity
		{	
			get { return GetAttributeValue<string>("opportunities"); }
			set
			{ 
				if(value == Opportunity) return;
				SetAttributeValue("opportunities", value);
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
        /// overview
        /// </summary>
		[DisplayName("Overview")]
		[AttributeLogicalName("overview")]
		public string Overview
		{	
			get { return GetAttributeValue<string>("overview"); }
			set
			{ 
				if(value == Overview) return;
				SetAttributeValue("overview", value);
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
        /// referenceinfourl
        /// </summary>
		[DisplayName("Reference Info URL")]
		[AttributeLogicalName("referenceinfourl")]
		public string ReferenceInfoURL
		{	
			get { return GetAttributeValue<string>("referenceinfourl"); }
			set
			{ 
				if(value == ReferenceInfoURL) return;
				SetAttributeValue("referenceinfourl", value);
			}
		}	
			
		/// <summary>
        /// reportedrevenue
        /// </summary>
		[DisplayName("Reported Revenue")]
		[AttributeLogicalName("reportedrevenue")]
		public decimal? ReportedRevenue
		{	
			get { return GetAttributeValue<Money>("reportedrevenue")?.Value; }
			set 
			{ 
				if(value == ReportedRevenue) return;

				Money moneyValue = null;
				if(value != null) moneyValue = new Money(value.Value);
				SetAttributeValue("reportedrevenue", moneyValue);  
			}
		}

		/// <summary>
        /// reportingquarter
        /// </summary>
		[DisplayName("Reporting Quarter")]
		[AttributeLogicalName("reportingquarter")]
		public int? ReportingQuarter
		{	
			get { return GetAttributeValue<int?>("reportingquarter"); }
			set
			{ 
				if(value == ReportingQuarter) return;
				SetAttributeValue("reportingquarter", value);
			}
		}	
			
		/// <summary>
        /// reportingyear
        /// </summary>
		[DisplayName("Reporting Year")]
		[AttributeLogicalName("reportingyear")]
		public int? ReportingYear
		{	
			get { return GetAttributeValue<int?>("reportingyear"); }
			set
			{ 
				if(value == ReportingYear) return;
				SetAttributeValue("reportingyear", value);
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
        /// strengths
        /// </summary>
		[DisplayName("Strength")]
		[AttributeLogicalName("strengths")]
		public string Strength
		{	
			get { return GetAttributeValue<string>("strengths"); }
			set
			{ 
				if(value == Strength) return;
				SetAttributeValue("strengths", value);
			}
		}	
			
		/// <summary>
        /// threats
        /// </summary>
		[DisplayName("Threat")]
		[AttributeLogicalName("threats")]
		public string Threat
		{	
			get { return GetAttributeValue<string>("threats"); }
			set
			{ 
				if(value == Threat) return;
				SetAttributeValue("threats", value);
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
        /// weaknesses
        /// </summary>
		[DisplayName("Weakness")]
		[AttributeLogicalName("weaknesses")]
		public string Weakness
		{	
			get { return GetAttributeValue<string>("weaknesses"); }
			set
			{ 
				if(value == Weakness) return;
				SetAttributeValue("weaknesses", value);
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
        /// winpercentage
        /// </summary>
		[DisplayName("Win Percentage")]
		[AttributeLogicalName("winpercentage")]
		public double? WinPercentage
		{	
			get { return GetAttributeValue<double?>("winpercentage"); }
			set
			{ 
				if(value == WinPercentage) return;
				SetAttributeValue("winpercentage", value);
			}
		}	
			
		/// <summary>
        /// yominame
        /// </summary>
		[DisplayName("Yomi Name")]
		[AttributeLogicalName("yominame")]
		public string YomiName
		{	
			get { return GetAttributeValue<string>("yominame"); }
			set
			{ 
				if(value == YomiName) return;
				SetAttributeValue("yominame", value);
			}
		}	
			
		#endregion	

		#region Relations
			/// <summary>
        /// 1:N Get entities for 'competitor_addresses'
        /// </summary>
		[RelationshipSchemaName("competitor_addresses")]
		public IEnumerable<CompetitorAddress> CompetitorAddresses
		{
			get { return GetRelatedEntities<CompetitorAddress>("competitor_addresses", null); }
			set { SetRelatedEntities("competitor_addresses", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'Competitor_Annotation'
        /// </summary>
		[RelationshipSchemaName("Competitor_Annotation")]
		public IEnumerable<Note> CompetitorAnnotation
		{
			get { return GetRelatedEntities<Note>("Competitor_Annotation", null); }
			set { SetRelatedEntities("Competitor_Annotation", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'Competitor_AsyncOperations'
        /// </summary>
		[RelationshipSchemaName("Competitor_AsyncOperations")]
		public IEnumerable<SystemJob> CompetitorAsyncOperations
		{
			get { return GetRelatedEntities<SystemJob>("Competitor_AsyncOperations", null); }
			set { SetRelatedEntities("Competitor_AsyncOperations", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'Competitor_BulkDeleteFailures'
        /// </summary>
		[RelationshipSchemaName("Competitor_BulkDeleteFailures")]
		public IEnumerable<BulkDeleteFailure> CompetitorBulkDeleteFailures
		{
			get { return GetRelatedEntities<BulkDeleteFailure>("Competitor_BulkDeleteFailures", null); }
			set { SetRelatedEntities("Competitor_BulkDeleteFailures", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'competitor_connections1'
        /// </summary>
		[RelationshipSchemaName("competitor_connections1")]
		public IEnumerable<Connection> CompetitorConnections1
		{
			get { return GetRelatedEntities<Connection>("competitor_connections1", null); }
			set { SetRelatedEntities("competitor_connections1", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'competitor_connections2'
        /// </summary>
		[RelationshipSchemaName("competitor_connections2")]
		public IEnumerable<Connection> CompetitorConnections2
		{
			get { return GetRelatedEntities<Connection>("competitor_connections2", null); }
			set { SetRelatedEntities("competitor_connections2", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'Competitor_DuplicateBaseRecord'
        /// </summary>
		[RelationshipSchemaName("Competitor_DuplicateBaseRecord")]
		public IEnumerable<DuplicateRecord> CompetitorDuplicateBaseRecord
		{
			get { return GetRelatedEntities<DuplicateRecord>("Competitor_DuplicateBaseRecord", null); }
			set { SetRelatedEntities("Competitor_DuplicateBaseRecord", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'Competitor_DuplicateMatchingRecord'
        /// </summary>
		[RelationshipSchemaName("Competitor_DuplicateMatchingRecord")]
		public IEnumerable<DuplicateRecord> CompetitorDuplicateMatchingRecord
		{
			get { return GetRelatedEntities<DuplicateRecord>("Competitor_DuplicateMatchingRecord", null); }
			set { SetRelatedEntities("Competitor_DuplicateMatchingRecord", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'competitor_MailboxTrackingFolders'
        /// </summary>
		[RelationshipSchemaName("competitor_MailboxTrackingFolders")]
		public IEnumerable<MailboxAutoTrackingFolder> CompetitorMailboxTrackingFolders
		{
			get { return GetRelatedEntities<MailboxAutoTrackingFolder>("competitor_MailboxTrackingFolders", null); }
			set { SetRelatedEntities("competitor_MailboxTrackingFolders", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'competitor_opportunity_activities'
        /// </summary>
		[RelationshipSchemaName("competitor_opportunity_activities")]
		public IEnumerable<OpportunityClose> CompetitorOpportunityActivities
		{
			get { return GetRelatedEntities<OpportunityClose>("competitor_opportunity_activities", null); }
			set { SetRelatedEntities("competitor_opportunity_activities", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'competitor_PostFollows'
        /// </summary>
		[RelationshipSchemaName("competitor_PostFollows")]
		public IEnumerable<Follow> CompetitorPostFollows
		{
			get { return GetRelatedEntities<Follow>("competitor_PostFollows", null); }
			set { SetRelatedEntities("competitor_PostFollows", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'competitor_principalobjectattributeaccess'
        /// </summary>
		[RelationshipSchemaName("competitor_principalobjectattributeaccess")]
		public IEnumerable<FieldSharing> CompetitorPrincipalobjectattributeaccess
		{
			get { return GetRelatedEntities<FieldSharing>("competitor_principalobjectattributeaccess", null); }
			set { SetRelatedEntities("competitor_principalobjectattributeaccess", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'Competitor_ProcessSessions'
        /// </summary>
		[RelationshipSchemaName("Competitor_ProcessSessions")]
		public IEnumerable<ProcessSession> CompetitorProcessSessions
		{
			get { return GetRelatedEntities<ProcessSession>("Competitor_ProcessSessions", null); }
			set { SetRelatedEntities("Competitor_ProcessSessions", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'Competitor_SyncErrors'
        /// </summary>
		[RelationshipSchemaName("Competitor_SyncErrors")]
		public IEnumerable<SyncError> CompetitorSyncErrors
		{
			get { return GetRelatedEntities<SyncError>("Competitor_SyncErrors", null); }
			set { SetRelatedEntities("Competitor_SyncErrors", null, value); }
		}
		/// <summary>
        /// N:N Get entities for 'Product'
        /// </summary>
		[RelationshipSchemaName("competitorproduct_association")]
		public IEnumerable<Product> CompetitorproductAssociation
		{
			get { return GetRelatedEntities<Product>("competitorproduct_association", null); }
			set { SetRelatedEntities("competitorproduct_association", null, value); }
		}
		/// <summary>
        /// N:N Get entities for 'SalesLiterature'
        /// </summary>
		[RelationshipSchemaName("competitorsalesliterature_association")]
		public IEnumerable<SalesLiterature> CompetitorsalesliteratureAssociation
		{
			get { return GetRelatedEntities<SalesLiterature>("competitorsalesliterature_association", null); }
			set { SetRelatedEntities("competitorsalesliterature_association", null, value); }
		}
		/// <summary>
        /// N:N Get entities for 'Lead'
        /// </summary>
		[RelationshipSchemaName("leadcompetitors_association")]
		public IEnumerable<Lead> LeadcompetitorsAssociation
		{
			get { return GetRelatedEntities<Lead>("leadcompetitors_association", null); }
			set { SetRelatedEntities("leadcompetitors_association", null, value); }
		}
		/// <summary>
        /// N:N Get entities for 'Opportunity'
        /// </summary>
		[RelationshipSchemaName("opportunitycompetitors_association")]
		public IEnumerable<Opportunity> OpportunitycompetitorsAssociation
		{
			get { return GetRelatedEntities<Opportunity>("opportunitycompetitors_association", null); }
			set { SetRelatedEntities("opportunitycompetitors_association", null, value); }
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

			/// <summary>competitorid</summary>
			public const string CompetitorId = "competitorid";

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

			/// <summary>entityimage_timestamp</summary>
			public const string EntityimageTimestamp = "entityimage_timestamp";

			/// <summary>entityimage_url</summary>
			public const string EntityimageUrl = "entityimage_url";

			/// <summary>entityimageid</summary>
			public const string EntityimageId = "entityimageid";

			/// <summary>exchangerate</summary>
			public const string ExchangeRate = "exchangerate";

			/// <summary>importsequencenumber</summary>
			public const string ImportSequenceNumber = "importsequencenumber";

			/// <summary>keyproduct</summary>
			public const string KeyProduct = "keyproduct";

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

			/// <summary>opportunities</summary>
			public const string Opportunity = "opportunities";

			/// <summary>organizationid</summary>
			public const string OrganizationId = "organizationid";

			/// <summary>organizationidname</summary>
			public const string Organizationidname = "organizationidname";

			/// <summary>overriddencreatedon</summary>
			public const string RecordCreatedOn = "overriddencreatedon";

			/// <summary>overview</summary>
			public const string Overview = "overview";

			/// <summary>processid</summary>
			public const string ProcessId = "processid";

			/// <summary>referenceinfourl</summary>
			public const string ReferenceInfoURL = "referenceinfourl";

			/// <summary>reportedrevenue</summary>
			public const string ReportedRevenue = "reportedrevenue";

			/// <summary>reportingquarter</summary>
			public const string ReportingQuarter = "reportingquarter";

			/// <summary>reportingyear</summary>
			public const string ReportingYear = "reportingyear";

			/// <summary>stageid</summary>
			public const string DeprecatedStageId = "stageid";

			/// <summary>stockexchange</summary>
			public const string StockExchange = "stockexchange";

			/// <summary>strengths</summary>
			public const string Strength = "strengths";

			/// <summary>threats</summary>
			public const string Threat = "threats";

			/// <summary>tickersymbol</summary>
			public const string TickerSymbol = "tickersymbol";

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

			/// <summary>weaknesses</summary>
			public const string Weakness = "weaknesses";

			/// <summary>websiteurl</summary>
			public const string Website = "websiteurl";

			/// <summary>winpercentage</summary>
			public const string WinPercentage = "winpercentage";

			/// <summary>yominame</summary>
			public const string YomiName = "yominame";

		}
		#endregion

		#region Schemas
		public static class Schemas 
		{
			/// <summary>1:N competitor_addresses</summary>
			public const string CompetitorAddresses = "competitor_addresses";

			/// <summary>1:N Competitor_Annotation</summary>
			public const string CompetitorAnnotation = "Competitor_Annotation";

			/// <summary>1:N Competitor_AsyncOperations</summary>
			public const string CompetitorAsyncOperations = "Competitor_AsyncOperations";

			/// <summary>1:N Competitor_BulkDeleteFailures</summary>
			public const string CompetitorBulkDeleteFailures = "Competitor_BulkDeleteFailures";

			/// <summary>1:N competitor_connections1</summary>
			public const string CompetitorConnections1 = "competitor_connections1";

			/// <summary>1:N competitor_connections2</summary>
			public const string CompetitorConnections2 = "competitor_connections2";

			/// <summary>1:N Competitor_DuplicateBaseRecord</summary>
			public const string CompetitorDuplicateBaseRecord = "Competitor_DuplicateBaseRecord";

			/// <summary>1:N Competitor_DuplicateMatchingRecord</summary>
			public const string CompetitorDuplicateMatchingRecord = "Competitor_DuplicateMatchingRecord";

			/// <summary>1:N competitor_MailboxTrackingFolders</summary>
			public const string CompetitorMailboxTrackingFolders = "competitor_MailboxTrackingFolders";

			/// <summary>1:N competitor_opportunity_activities</summary>
			public const string CompetitorOpportunityActivities = "competitor_opportunity_activities";

			/// <summary>1:N competitor_PostFollows</summary>
			public const string CompetitorPostFollows = "competitor_PostFollows";

			/// <summary>1:N competitor_principalobjectattributeaccess</summary>
			public const string CompetitorPrincipalobjectattributeaccess = "competitor_principalobjectattributeaccess";

			/// <summary>1:N Competitor_ProcessSessions</summary>
			public const string CompetitorProcessSessions = "Competitor_ProcessSessions";

			/// <summary>1:N Competitor_SyncErrors</summary>
			public const string CompetitorSyncErrors = "Competitor_SyncErrors";

			/// <summary>N:N competitorproduct_association</summary>
			public const string CompetitorproductAssociation = "competitorproduct_association";

			/// <summary>N:N competitorsalesliterature_association</summary>
			public const string CompetitorsalesliteratureAssociation = "competitorsalesliterature_association";

			/// <summary>N:N leadcompetitors_association</summary>
			public const string LeadcompetitorsAssociation = "leadcompetitors_association";

			/// <summary>N:N opportunitycompetitors_association</summary>
			public const string OpportunitycompetitorsAssociation = "opportunitycompetitors_association";

		}
		#endregion
	}
}

