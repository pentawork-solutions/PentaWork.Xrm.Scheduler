using System;
using System.Linq;
using System.Diagnostics;
using System.ComponentModel;
using Microsoft.Xrm.Sdk; 
using Microsoft.Xrm.Sdk.Client;
using System.Collections.Generic;

namespace PentaWork.Xrm.Scheduler.Proxies.Entities
{
	[DebuggerDisplay("{AddressName}")] 	
	[EntityLogicalName("customeraddress")]
	public sealed class Address : Entity
	{	
		public static readonly int? EntityTypeCode = 1071;
		public new const string LogicalName = "customeraddress";
		public const string PrimaryIdAttribute = "customeraddressid";
		public const string PrimaryNameAttribute = "name";
	
		public Address() : base("customeraddress") { }

		#region Attributes
		/// <summary>
        /// addressnumber
        /// </summary>
		[DisplayName("Address Number")]
		[AttributeLogicalName("addressnumber")]
		public int? AddressNumber
		{	
			get { return GetAttributeValue<int?>("addressnumber"); }
			set
			{ 
				if(value == AddressNumber) return;
				SetAttributeValue("addressnumber", value);
			}
		}	
			
		/// <summary>
        /// addresstypecode
        /// </summary>
		[DisplayName("Address Type")]
		[AttributeLogicalName("addresstypecode")]
		public eAddressType? AddressType
		{	
			get 
			{ 
				var optionSetValue = GetAttributeValue<OptionSetValue>("addresstypecode");
				if (optionSetValue != null) return (eAddressType)optionSetValue.Value;
				else return null;
			}
			set 
			{ 
				if(value == AddressType) return;

				OptionSetValue optionSetValue = null;
				if(value != null) optionSetValue = new OptionSetValue((int)value);
				SetAttributeValue("addresstypecode", optionSetValue); 
			}
		}

		/// <summary>
        /// city
        /// </summary>
		[DisplayName("City")]
		[AttributeLogicalName("city")]
		public string City
		{	
			get { return GetAttributeValue<string>("city"); }
			set
			{ 
				if(value == City) return;
				SetAttributeValue("city", value);
			}
		}	
			
		/// <summary>
        /// composite
        /// </summary>
		[DisplayName("Address")]
		[AttributeLogicalName("composite")]
		public string Address2
		{	
			get { return GetAttributeValue<string>("composite"); }
			set
			{ 
				if(value == Address2) return;
				SetAttributeValue("composite", value);
			}
		}	
			
		/// <summary>
        /// country
        /// </summary>
		[DisplayName("Country/Region")]
		[AttributeLogicalName("country")]
		public string CountryRegion
		{	
			get { return GetAttributeValue<string>("country"); }
			set
			{ 
				if(value == CountryRegion) return;
				SetAttributeValue("country", value);
			}
		}	
			
		/// <summary>
        /// county
        /// </summary>
		[DisplayName("County")]
		[AttributeLogicalName("county")]
		public string County
		{	
			get { return GetAttributeValue<string>("county"); }
			set
			{ 
				if(value == County) return;
				SetAttributeValue("county", value);
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
        /// customeraddressid
        /// </summary>
		[DisplayName("Address")]
		[AttributeLogicalName("customeraddressid")]
		public override Guid Id
		{
			get => base.Id;
			set { base.Id = value; SetAttributeValue("customeraddressid", value); }
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
        /// freighttermscode
        /// </summary>
		[DisplayName("Freight Terms")]
		[AttributeLogicalName("freighttermscode")]
		public eFreightTerms? FreightTerms
		{	
			get 
			{ 
				var optionSetValue = GetAttributeValue<OptionSetValue>("freighttermscode");
				if (optionSetValue != null) return (eFreightTerms)optionSetValue.Value;
				else return null;
			}
			set 
			{ 
				if(value == FreightTerms) return;

				OptionSetValue optionSetValue = null;
				if(value != null) optionSetValue = new OptionSetValue((int)value);
				SetAttributeValue("freighttermscode", optionSetValue); 
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
        /// latitude
        /// </summary>
		[DisplayName("Latitude")]
		[AttributeLogicalName("latitude")]
		public double? Latitude
		{	
			get { return GetAttributeValue<double?>("latitude"); }
			set
			{ 
				if(value == Latitude) return;
				SetAttributeValue("latitude", value);
			}
		}	
			
		/// <summary>
        /// line1
        /// </summary>
		[DisplayName("Street 1")]
		[AttributeLogicalName("line1")]
		public string Street1
		{	
			get { return GetAttributeValue<string>("line1"); }
			set
			{ 
				if(value == Street1) return;
				SetAttributeValue("line1", value);
			}
		}	
			
		/// <summary>
        /// line2
        /// </summary>
		[DisplayName("Street 2")]
		[AttributeLogicalName("line2")]
		public string Street2
		{	
			get { return GetAttributeValue<string>("line2"); }
			set
			{ 
				if(value == Street2) return;
				SetAttributeValue("line2", value);
			}
		}	
			
		/// <summary>
        /// line3
        /// </summary>
		[DisplayName("Street 3")]
		[AttributeLogicalName("line3")]
		public string Street3
		{	
			get { return GetAttributeValue<string>("line3"); }
			set
			{ 
				if(value == Street3) return;
				SetAttributeValue("line3", value);
			}
		}	
			
		/// <summary>
        /// longitude
        /// </summary>
		[DisplayName("Longitude")]
		[AttributeLogicalName("longitude")]
		public double? Longitude
		{	
			get { return GetAttributeValue<double?>("longitude"); }
			set
			{ 
				if(value == Longitude) return;
				SetAttributeValue("longitude", value);
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
		[DisplayName("Address Name")]
		[AttributeLogicalName("name")]
		public string AddressName
		{	
			get { return GetAttributeValue<string>("name"); }
			set
			{ 
				if(value == AddressName) return;
				SetAttributeValue("name", value);
			}
		}	
			
		/// <summary>
        /// objecttypecode
        /// </summary>
		[DisplayName("Object Type")]
		[AttributeLogicalName("objecttypecode")]
		public string ObjectType
		{	
			get { return GetAttributeValue<string>("objecttypecode"); }
			set
			{ 
				if(value == ObjectType) return;
				SetAttributeValue("objecttypecode", value);
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
        /// owninguser
        /// </summary>
		[DisplayName("Owner")]
		[AttributeLogicalName("owninguser")]
		public EntityReference Owner2
		{	
			get { return GetAttributeValue<EntityReference>("owninguser"); }
			set
			{ 
				if(value == Owner2) return;
				SetAttributeValue("owninguser", value);
			}
		}	
			
		/// <summary>
        /// parentid
        /// </summary>
		[DisplayName("Parent")]
		[AttributeLogicalName("parentid")]
		public EntityReference Parent
		{	
			get { return GetAttributeValue<EntityReference>("parentid"); }
			set
			{ 
				if(value == Parent) return;
				SetAttributeValue("parentid", value);
			}
		}	
			
		/// <summary>
        /// parentidtypecode
        /// </summary>
		[DisplayName("Parent Object Type")]
		[AttributeLogicalName("parentidtypecode")]
		public string ParentObjectType
		{	
			get { return GetAttributeValue<string>("parentidtypecode"); }
			set
			{ 
				if(value == ParentObjectType) return;
				SetAttributeValue("parentidtypecode", value);
			}
		}	
			
		/// <summary>
        /// postalcode
        /// </summary>
		[DisplayName("ZIP/Postal Code")]
		[AttributeLogicalName("postalcode")]
		public string ZIPPostalCode
		{	
			get { return GetAttributeValue<string>("postalcode"); }
			set
			{ 
				if(value == ZIPPostalCode) return;
				SetAttributeValue("postalcode", value);
			}
		}	
			
		/// <summary>
        /// postofficebox
        /// </summary>
		[DisplayName("Post Office Box")]
		[AttributeLogicalName("postofficebox")]
		public string PostOfficeBox
		{	
			get { return GetAttributeValue<string>("postofficebox"); }
			set
			{ 
				if(value == PostOfficeBox) return;
				SetAttributeValue("postofficebox", value);
			}
		}	
			
		/// <summary>
        /// primarycontactname
        /// </summary>
		[DisplayName("Address Contact")]
		[AttributeLogicalName("primarycontactname")]
		public string AddressContact
		{	
			get { return GetAttributeValue<string>("primarycontactname"); }
			set
			{ 
				if(value == AddressContact) return;
				SetAttributeValue("primarycontactname", value);
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
        /// stateorprovince
        /// </summary>
		[DisplayName("State/Province")]
		[AttributeLogicalName("stateorprovince")]
		public string StateProvince
		{	
			get { return GetAttributeValue<string>("stateorprovince"); }
			set
			{ 
				if(value == StateProvince) return;
				SetAttributeValue("stateorprovince", value);
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
				if(value == MainPhone) return;
				SetAttributeValue("telephone1", value);
			}
		}	
			
		/// <summary>
        /// telephone2
        /// </summary>
		[DisplayName("Phone 2")]
		[AttributeLogicalName("telephone2")]
		public string Phone2
		{	
			get { return GetAttributeValue<string>("telephone2"); }
			set
			{ 
				if(value == Phone2) return;
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
        /// upszone
        /// </summary>
		[DisplayName("UPS Zone")]
		[AttributeLogicalName("upszone")]
		public string UPSZone
		{	
			get { return GetAttributeValue<string>("upszone"); }
			set
			{ 
				if(value == UPSZone) return;
				SetAttributeValue("upszone", value);
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
        /// 1:N Get entities for 'customer_address_contract_line_items'
        /// </summary>
		[RelationshipSchemaName("customer_address_contract_line_items")]
		public IEnumerable<ContractLine> CustomerAddressContractLineItems
		{
			get { return GetRelatedEntities<ContractLine>("customer_address_contract_line_items", null); }
			set { SetRelatedEntities("customer_address_contract_line_items", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'customer_address_contracts_as_billing_address'
        /// </summary>
		[RelationshipSchemaName("customer_address_contracts_as_billing_address")]
		public IEnumerable<Contract> CustomerAddressContractsAsBillingAddress
		{
			get { return GetRelatedEntities<Contract>("customer_address_contracts_as_billing_address", null); }
			set { SetRelatedEntities("customer_address_contracts_as_billing_address", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'customer_address_contracts_as_service_address'
        /// </summary>
		[RelationshipSchemaName("customer_address_contracts_as_service_address")]
		public IEnumerable<Contract> CustomerAddressContractsAsServiceAddress
		{
			get { return GetRelatedEntities<Contract>("customer_address_contracts_as_service_address", null); }
			set { SetRelatedEntities("customer_address_contracts_as_service_address", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'CustomerAddress_AsyncOperations'
        /// </summary>
		[RelationshipSchemaName("CustomerAddress_AsyncOperations")]
		public IEnumerable<SystemJob> CustomerAddressAsyncOperations
		{
			get { return GetRelatedEntities<SystemJob>("CustomerAddress_AsyncOperations", null); }
			set { SetRelatedEntities("CustomerAddress_AsyncOperations", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'CustomerAddress_BulkDeleteFailures'
        /// </summary>
		[RelationshipSchemaName("CustomerAddress_BulkDeleteFailures")]
		public IEnumerable<BulkDeleteFailure> CustomerAddressBulkDeleteFailures
		{
			get { return GetRelatedEntities<BulkDeleteFailure>("CustomerAddress_BulkDeleteFailures", null); }
			set { SetRelatedEntities("CustomerAddress_BulkDeleteFailures", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'customeraddress_principalobjectattributeaccess'
        /// </summary>
		[RelationshipSchemaName("customeraddress_principalobjectattributeaccess")]
		public IEnumerable<FieldSharing> CustomeraddressPrincipalobjectattributeaccess
		{
			get { return GetRelatedEntities<FieldSharing>("customeraddress_principalobjectattributeaccess", null); }
			set { SetRelatedEntities("customeraddress_principalobjectattributeaccess", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'CustomerAddress_ProcessSessions'
        /// </summary>
		[RelationshipSchemaName("CustomerAddress_ProcessSessions")]
		public IEnumerable<ProcessSession> CustomerAddressProcessSessions
		{
			get { return GetRelatedEntities<ProcessSession>("CustomerAddress_ProcessSessions", null); }
			set { SetRelatedEntities("CustomerAddress_ProcessSessions", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'CustomerAddress_SyncErrors'
        /// </summary>
		[RelationshipSchemaName("CustomerAddress_SyncErrors")]
		public IEnumerable<SyncError> CustomerAddressSyncErrors
		{
			get { return GetRelatedEntities<SyncError>("CustomerAddress_SyncErrors", null); }
			set { SetRelatedEntities("CustomerAddress_SyncErrors", null, value); }
		}
		#endregion

		#region Actions
		#endregion

		#region OptionSetEnums
		public enum eAddressType
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
		
		public enum eFreightTerms
		{	
		
			[Label("FOB")]
			[Description(@"")]
			FOB = 1, 
		
			[Label("No Charge")]
			[Description(@"")]
			NoCharge = 2, 
		}
		
		public enum eShippingMethod
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
		
		#endregion	

		#region Properties
		public static class Properties 
		{
			/// <summary>addressnumber</summary>
			public const string AddressNumber = "addressnumber";

			/// <summary>addresstypecode</summary>
			public const string AddressType = "addresstypecode";

			/// <summary>city</summary>
			public const string City = "city";

			/// <summary>composite</summary>
			public const string Address2 = "composite";

			/// <summary>country</summary>
			public const string CountryRegion = "country";

			/// <summary>county</summary>
			public const string County = "county";

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

			/// <summary>customeraddressid</summary>
			public const string AddressId = "customeraddressid";

			/// <summary>exchangerate</summary>
			public const string ExchangeRate = "exchangerate";

			/// <summary>fax</summary>
			public const string Fax = "fax";

			/// <summary>freighttermscode</summary>
			public const string FreightTerms = "freighttermscode";

			/// <summary>importsequencenumber</summary>
			public const string ImportSequenceNumber = "importsequencenumber";

			/// <summary>latitude</summary>
			public const string Latitude = "latitude";

			/// <summary>line1</summary>
			public const string Street1 = "line1";

			/// <summary>line2</summary>
			public const string Street2 = "line2";

			/// <summary>line3</summary>
			public const string Street3 = "line3";

			/// <summary>longitude</summary>
			public const string Longitude = "longitude";

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
			public const string AddressName = "name";

			/// <summary>objecttypecode</summary>
			public const string ObjectType = "objecttypecode";

			/// <summary>overriddencreatedon</summary>
			public const string RecordCreatedOn = "overriddencreatedon";

			/// <summary>ownerid</summary>
			public const string Owner = "ownerid";

			/// <summary>owneridtype</summary>
			public const string Owneridtype = "owneridtype";

			/// <summary>owningbusinessunit</summary>
			public const string OwningBusinessUnit = "owningbusinessunit";

			/// <summary>owninguser</summary>
			public const string Owner2 = "owninguser";

			/// <summary>parentid</summary>
			public const string Parent = "parentid";

			/// <summary>parentidtypecode</summary>
			public const string ParentObjectType = "parentidtypecode";

			/// <summary>postalcode</summary>
			public const string ZIPPostalCode = "postalcode";

			/// <summary>postofficebox</summary>
			public const string PostOfficeBox = "postofficebox";

			/// <summary>primarycontactname</summary>
			public const string AddressContact = "primarycontactname";

			/// <summary>shippingmethodcode</summary>
			public const string ShippingMethod = "shippingmethodcode";

			/// <summary>stateorprovince</summary>
			public const string StateProvince = "stateorprovince";

			/// <summary>telephone1</summary>
			public const string MainPhone = "telephone1";

			/// <summary>telephone2</summary>
			public const string Phone2 = "telephone2";

			/// <summary>telephone3</summary>
			public const string Telephone3 = "telephone3";

			/// <summary>timezoneruleversionnumber</summary>
			public const string TimeZoneRuleVersionNumber = "timezoneruleversionnumber";

			/// <summary>transactioncurrencyid</summary>
			public const string Currency = "transactioncurrencyid";

			/// <summary>transactioncurrencyidname</summary>
			public const string Transactioncurrencyidname = "transactioncurrencyidname";

			/// <summary>upszone</summary>
			public const string UPSZone = "upszone";

			/// <summary>utcconversiontimezonecode</summary>
			public const string UTCConversionTimeZoneCode = "utcconversiontimezonecode";

			/// <summary>utcoffset</summary>
			public const string UTCOffset = "utcoffset";

			/// <summary>versionnumber</summary>
			public const string VersionNumber = "versionnumber";

		}
		#endregion

		#region Schemas
		public static class Schemas 
		{
			/// <summary>1:N customer_address_contract_line_items</summary>
			public const string CustomerAddressContractLineItems = "customer_address_contract_line_items";

			/// <summary>1:N customer_address_contracts_as_billing_address</summary>
			public const string CustomerAddressContractsAsBillingAddress = "customer_address_contracts_as_billing_address";

			/// <summary>1:N customer_address_contracts_as_service_address</summary>
			public const string CustomerAddressContractsAsServiceAddress = "customer_address_contracts_as_service_address";

			/// <summary>1:N CustomerAddress_AsyncOperations</summary>
			public const string CustomerAddressAsyncOperations = "CustomerAddress_AsyncOperations";

			/// <summary>1:N CustomerAddress_BulkDeleteFailures</summary>
			public const string CustomerAddressBulkDeleteFailures = "CustomerAddress_BulkDeleteFailures";

			/// <summary>1:N customeraddress_principalobjectattributeaccess</summary>
			public const string CustomeraddressPrincipalobjectattributeaccess = "customeraddress_principalobjectattributeaccess";

			/// <summary>1:N CustomerAddress_ProcessSessions</summary>
			public const string CustomerAddressProcessSessions = "CustomerAddress_ProcessSessions";

			/// <summary>1:N CustomerAddress_SyncErrors</summary>
			public const string CustomerAddressSyncErrors = "CustomerAddress_SyncErrors";

		}
		#endregion
	}
}

