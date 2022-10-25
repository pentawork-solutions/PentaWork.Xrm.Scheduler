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
	[EntityLogicalName("site")]
	public sealed class Site : Entity
	{	
		public static readonly int? EntityTypeCode = 4009;
		public new const string LogicalName = "site";
		public const string PrimaryIdAttribute = "siteid";
		public const string PrimaryNameAttribute = "name";
	
		public Site() : base("site") { }

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
		[DisplayName("Fax")]
		[AttributeLogicalName("address1_fax")]
		public string Fax
		{	
			get { return GetAttributeValue<string>("address1_fax"); }
			set
			{ 
				if(value == Fax) return;
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
        /// siteid
        /// </summary>
		[DisplayName("Site")]
		[AttributeLogicalName("siteid")]
		public override Guid Id
		{
			get => base.Id;
			set { base.Id = value; SetAttributeValue("siteid", value); }
		}

							/// <summary>
        /// timezonecode
        /// </summary>
		[DisplayName("Time Zone")]
		[AttributeLogicalName("timezonecode")]
		public int? TimeZone
		{	
			get { return GetAttributeValue<int?>("timezonecode"); }
			set
			{ 
				if(value == TimeZone) return;
				SetAttributeValue("timezonecode", value);
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
        /// 1:N Get entities for 'site_ActivityPointers'
        /// </summary>
		[RelationshipSchemaName("site_ActivityPointers")]
		public IEnumerable<Activity> SiteActivityPointers
		{
			get { return GetRelatedEntities<Activity>("site_ActivityPointers", null); }
			set { SetRelatedEntities("site_ActivityPointers", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'site_Appointments'
        /// </summary>
		[RelationshipSchemaName("site_Appointments")]
		public IEnumerable<Appointment> SiteAppointments
		{
			get { return GetRelatedEntities<Appointment>("site_Appointments", null); }
			set { SetRelatedEntities("site_Appointments", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'Site_AsyncOperations'
        /// </summary>
		[RelationshipSchemaName("Site_AsyncOperations")]
		public IEnumerable<SystemJob> SiteAsyncOperations
		{
			get { return GetRelatedEntities<SystemJob>("Site_AsyncOperations", null); }
			set { SetRelatedEntities("Site_AsyncOperations", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'Site_BulkDeleteFailures'
        /// </summary>
		[RelationshipSchemaName("Site_BulkDeleteFailures")]
		public IEnumerable<BulkDeleteFailure> SiteBulkDeleteFailures
		{
			get { return GetRelatedEntities<BulkDeleteFailure>("Site_BulkDeleteFailures", null); }
			set { SetRelatedEntities("Site_BulkDeleteFailures", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'site_Emails'
        /// </summary>
		[RelationshipSchemaName("site_Emails")]
		public IEnumerable<Email> SiteEmails
		{
			get { return GetRelatedEntities<Email>("site_Emails", null); }
			set { SetRelatedEntities("site_Emails", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'site_equipment'
        /// </summary>
		[RelationshipSchemaName("site_equipment")]
		public IEnumerable<FacilityEquipment> SiteEquipment
		{
			get { return GetRelatedEntities<FacilityEquipment>("site_equipment", null); }
			set { SetRelatedEntities("site_equipment", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'site_Faxes'
        /// </summary>
		[RelationshipSchemaName("site_Faxes")]
		public IEnumerable<Fax> SiteFaxes
		{
			get { return GetRelatedEntities<Fax>("site_Faxes", null); }
			set { SetRelatedEntities("site_Faxes", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'site_Letters'
        /// </summary>
		[RelationshipSchemaName("site_Letters")]
		public IEnumerable<Letter> SiteLetters
		{
			get { return GetRelatedEntities<Letter>("site_Letters", null); }
			set { SetRelatedEntities("site_Letters", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'site_MailboxTrackingFolders'
        /// </summary>
		[RelationshipSchemaName("site_MailboxTrackingFolders")]
		public IEnumerable<MailboxAutoTrackingFolder> SiteMailboxTrackingFolders
		{
			get { return GetRelatedEntities<MailboxAutoTrackingFolder>("site_MailboxTrackingFolders", null); }
			set { SetRelatedEntities("site_MailboxTrackingFolders", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'site_OpportunityCloses'
        /// </summary>
		[RelationshipSchemaName("site_OpportunityCloses")]
		public IEnumerable<OpportunityClose> SiteOpportunityCloses
		{
			get { return GetRelatedEntities<OpportunityClose>("site_OpportunityCloses", null); }
			set { SetRelatedEntities("site_OpportunityCloses", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'site_OrderCloses'
        /// </summary>
		[RelationshipSchemaName("site_OrderCloses")]
		public IEnumerable<OrderClose> SiteOrderCloses
		{
			get { return GetRelatedEntities<OrderClose>("site_OrderCloses", null); }
			set { SetRelatedEntities("site_OrderCloses", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'site_PhoneCalls'
        /// </summary>
		[RelationshipSchemaName("site_PhoneCalls")]
		public IEnumerable<PhoneCall> SitePhoneCalls
		{
			get { return GetRelatedEntities<PhoneCall>("site_PhoneCalls", null); }
			set { SetRelatedEntities("site_PhoneCalls", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'site_PrincipalObjectAttributeAccesses'
        /// </summary>
		[RelationshipSchemaName("site_PrincipalObjectAttributeAccesses")]
		public IEnumerable<FieldSharing> SitePrincipalObjectAttributeAccesses
		{
			get { return GetRelatedEntities<FieldSharing>("site_PrincipalObjectAttributeAccesses", null); }
			set { SetRelatedEntities("site_PrincipalObjectAttributeAccesses", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'Site_ProcessSessions'
        /// </summary>
		[RelationshipSchemaName("Site_ProcessSessions")]
		public IEnumerable<ProcessSession> SiteProcessSessions
		{
			get { return GetRelatedEntities<ProcessSession>("Site_ProcessSessions", null); }
			set { SetRelatedEntities("Site_ProcessSessions", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'site_QuoteCloses'
        /// </summary>
		[RelationshipSchemaName("site_QuoteCloses")]
		public IEnumerable<QuoteClose> SiteQuoteCloses
		{
			get { return GetRelatedEntities<QuoteClose>("site_QuoteCloses", null); }
			set { SetRelatedEntities("site_QuoteCloses", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'site_RecurringAppointmentMasters'
        /// </summary>
		[RelationshipSchemaName("site_RecurringAppointmentMasters")]
		public IEnumerable<RecurringAppointment> SiteRecurringAppointmentMasters
		{
			get { return GetRelatedEntities<RecurringAppointment>("site_RecurringAppointmentMasters", null); }
			set { SetRelatedEntities("site_RecurringAppointmentMasters", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'site_resources'
        /// </summary>
		[RelationshipSchemaName("site_resources")]
		public IEnumerable<Resource> SiteResources
		{
			get { return GetRelatedEntities<Resource>("site_resources", null); }
			set { SetRelatedEntities("site_resources", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'site_service_appointments'
        /// </summary>
		[RelationshipSchemaName("site_service_appointments")]
		public IEnumerable<ServiceActivity> SiteServiceAppointments
		{
			get { return GetRelatedEntities<ServiceActivity>("site_service_appointments", null); }
			set { SetRelatedEntities("site_service_appointments", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'site_ServiceAppointments'
        /// </summary>
		[RelationshipSchemaName("site_ServiceAppointments")]
		public IEnumerable<ServiceActivity> SiteServiceAppointments2
		{
			get { return GetRelatedEntities<ServiceActivity>("site_ServiceAppointments", null); }
			set { SetRelatedEntities("site_ServiceAppointments", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'site_SocialActivities'
        /// </summary>
		[RelationshipSchemaName("site_SocialActivities")]
		public IEnumerable<SocialActivity> SiteSocialActivities
		{
			get { return GetRelatedEntities<SocialActivity>("site_SocialActivities", null); }
			set { SetRelatedEntities("site_SocialActivities", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'Site_SyncErrors'
        /// </summary>
		[RelationshipSchemaName("Site_SyncErrors")]
		public IEnumerable<SyncError> SiteSyncErrors
		{
			get { return GetRelatedEntities<SyncError>("Site_SyncErrors", null); }
			set { SetRelatedEntities("Site_SyncErrors", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'site_system_users'
        /// </summary>
		[RelationshipSchemaName("site_system_users")]
		public IEnumerable<User> SiteSystemUsers
		{
			get { return GetRelatedEntities<User>("site_system_users", null); }
			set { SetRelatedEntities("site_system_users", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'site_Tasks'
        /// </summary>
		[RelationshipSchemaName("site_Tasks")]
		public IEnumerable<Task> SiteTasks
		{
			get { return GetRelatedEntities<Task>("site_Tasks", null); }
			set { SetRelatedEntities("site_Tasks", null, value); }
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

			/// <summary>address1_country</summary>
			public const string CountryRegion = "address1_country";

			/// <summary>address1_county</summary>
			public const string Address1County = "address1_county";

			/// <summary>address1_fax</summary>
			public const string Fax = "address1_fax";

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

			/// <summary>emailaddress</summary>
			public const string Email = "emailaddress";

			/// <summary>importsequencenumber</summary>
			public const string ImportSequenceNumber = "importsequencenumber";

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
			public const string OrganizationId = "organizationid";

			/// <summary>organizationidname</summary>
			public const string Organizationidname = "organizationidname";

			/// <summary>overriddencreatedon</summary>
			public const string RecordCreatedOn = "overriddencreatedon";

			/// <summary>siteid</summary>
			public const string SiteId = "siteid";

			/// <summary>timezonecode</summary>
			public const string TimeZone = "timezonecode";

			/// <summary>timezoneruleversionnumber</summary>
			public const string TimeZoneRuleVersionNumber = "timezoneruleversionnumber";

			/// <summary>utcconversiontimezonecode</summary>
			public const string UTCConversionTimeZoneCode = "utcconversiontimezonecode";

			/// <summary>versionnumber</summary>
			public const string VersionNumber = "versionnumber";

		}
		#endregion

		#region Schemas
		public static class Schemas 
		{
			/// <summary>1:N site_ActivityPointers</summary>
			public const string SiteActivityPointers = "site_ActivityPointers";

			/// <summary>1:N site_Appointments</summary>
			public const string SiteAppointments = "site_Appointments";

			/// <summary>1:N Site_AsyncOperations</summary>
			public const string SiteAsyncOperations = "Site_AsyncOperations";

			/// <summary>1:N Site_BulkDeleteFailures</summary>
			public const string SiteBulkDeleteFailures = "Site_BulkDeleteFailures";

			/// <summary>1:N site_Emails</summary>
			public const string SiteEmails = "site_Emails";

			/// <summary>1:N site_equipment</summary>
			public const string SiteEquipment = "site_equipment";

			/// <summary>1:N site_Faxes</summary>
			public const string SiteFaxes = "site_Faxes";

			/// <summary>1:N site_Letters</summary>
			public const string SiteLetters = "site_Letters";

			/// <summary>1:N site_MailboxTrackingFolders</summary>
			public const string SiteMailboxTrackingFolders = "site_MailboxTrackingFolders";

			/// <summary>1:N site_OpportunityCloses</summary>
			public const string SiteOpportunityCloses = "site_OpportunityCloses";

			/// <summary>1:N site_OrderCloses</summary>
			public const string SiteOrderCloses = "site_OrderCloses";

			/// <summary>1:N site_PhoneCalls</summary>
			public const string SitePhoneCalls = "site_PhoneCalls";

			/// <summary>1:N site_PrincipalObjectAttributeAccesses</summary>
			public const string SitePrincipalObjectAttributeAccesses = "site_PrincipalObjectAttributeAccesses";

			/// <summary>1:N Site_ProcessSessions</summary>
			public const string SiteProcessSessions = "Site_ProcessSessions";

			/// <summary>1:N site_QuoteCloses</summary>
			public const string SiteQuoteCloses = "site_QuoteCloses";

			/// <summary>1:N site_RecurringAppointmentMasters</summary>
			public const string SiteRecurringAppointmentMasters = "site_RecurringAppointmentMasters";

			/// <summary>1:N site_resources</summary>
			public const string SiteResources = "site_resources";

			/// <summary>1:N site_service_appointments</summary>
			public const string SiteServiceAppointments = "site_service_appointments";

			/// <summary>1:N site_ServiceAppointments</summary>
			public const string SiteServiceAppointments2 = "site_ServiceAppointments";

			/// <summary>1:N site_SocialActivities</summary>
			public const string SiteSocialActivities = "site_SocialActivities";

			/// <summary>1:N Site_SyncErrors</summary>
			public const string SiteSyncErrors = "Site_SyncErrors";

			/// <summary>1:N site_system_users</summary>
			public const string SiteSystemUsers = "site_system_users";

			/// <summary>1:N site_Tasks</summary>
			public const string SiteTasks = "site_Tasks";

		}
		#endregion
	}
}

