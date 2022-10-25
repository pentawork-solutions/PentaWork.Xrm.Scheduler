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
	[EntityLogicalName("salesorder")]
	public sealed class Order : Entity
	{	
		public static readonly int? EntityTypeCode = 1088;
		public new const string LogicalName = "salesorder";
		public const string PrimaryIdAttribute = "salesorderid";
		public const string PrimaryNameAttribute = "name";
	
		public Order() : base("salesorder") { }

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
        /// billto_addressid
        /// </summary>
		[DisplayName("Bill To Address ID")]
		[AttributeLogicalName("billto_addressid")]
		public Guid BillToAddressId
		{	
			get { return GetAttributeValue<Guid>("billto_addressid"); }
			set
			{ 
				if(value == BillToAddressId) return;
				SetAttributeValue("billto_addressid", value);
			}
		}	
			
		/// <summary>
        /// billto_city
        /// </summary>
		[DisplayName("Bill To City")]
		[AttributeLogicalName("billto_city")]
		public string BillToCity
		{	
			get { return GetAttributeValue<string>("billto_city"); }
			set
			{ 
				if(value == BillToCity) return;
				SetAttributeValue("billto_city", value);
			}
		}	
			
		/// <summary>
        /// billto_composite
        /// </summary>
		[DisplayName("Bill To Address")]
		[AttributeLogicalName("billto_composite")]
		public string BillToAddress
		{	
			get { return GetAttributeValue<string>("billto_composite"); }
			set
			{ 
				if(value == BillToAddress) return;
				SetAttributeValue("billto_composite", value);
			}
		}	
			
		/// <summary>
        /// billto_contactname
        /// </summary>
		[DisplayName("Bill To Contact Name")]
		[AttributeLogicalName("billto_contactname")]
		public string BillToContactName
		{	
			get { return GetAttributeValue<string>("billto_contactname"); }
			set
			{ 
				if(value == BillToContactName) return;
				SetAttributeValue("billto_contactname", value);
			}
		}	
			
		/// <summary>
        /// billto_country
        /// </summary>
		[DisplayName("Bill To Country/Region")]
		[AttributeLogicalName("billto_country")]
		public string BillToCountryRegion
		{	
			get { return GetAttributeValue<string>("billto_country"); }
			set
			{ 
				if(value == BillToCountryRegion) return;
				SetAttributeValue("billto_country", value);
			}
		}	
			
		/// <summary>
        /// billto_fax
        /// </summary>
		[DisplayName("Bill To Fax")]
		[AttributeLogicalName("billto_fax")]
		public string BillToFax
		{	
			get { return GetAttributeValue<string>("billto_fax"); }
			set
			{ 
				if(value == BillToFax) return;
				SetAttributeValue("billto_fax", value);
			}
		}	
			
		/// <summary>
        /// billto_line1
        /// </summary>
		[DisplayName("Bill To Street 1")]
		[AttributeLogicalName("billto_line1")]
		public string BillToStreet1
		{	
			get { return GetAttributeValue<string>("billto_line1"); }
			set
			{ 
				if(value == BillToStreet1) return;
				SetAttributeValue("billto_line1", value);
			}
		}	
			
		/// <summary>
        /// billto_line2
        /// </summary>
		[DisplayName("Bill To Street 2")]
		[AttributeLogicalName("billto_line2")]
		public string BillToStreet2
		{	
			get { return GetAttributeValue<string>("billto_line2"); }
			set
			{ 
				if(value == BillToStreet2) return;
				SetAttributeValue("billto_line2", value);
			}
		}	
			
		/// <summary>
        /// billto_line3
        /// </summary>
		[DisplayName("Bill To Street 3")]
		[AttributeLogicalName("billto_line3")]
		public string BillToStreet3
		{	
			get { return GetAttributeValue<string>("billto_line3"); }
			set
			{ 
				if(value == BillToStreet3) return;
				SetAttributeValue("billto_line3", value);
			}
		}	
			
		/// <summary>
        /// billto_name
        /// </summary>
		[DisplayName("Bill To Name")]
		[AttributeLogicalName("billto_name")]
		public string BillToName
		{	
			get { return GetAttributeValue<string>("billto_name"); }
			set
			{ 
				if(value == BillToName) return;
				SetAttributeValue("billto_name", value);
			}
		}	
			
		/// <summary>
        /// billto_postalcode
        /// </summary>
		[DisplayName("Bill To ZIP/Postal Code")]
		[AttributeLogicalName("billto_postalcode")]
		public string BillToZIPPostalCode
		{	
			get { return GetAttributeValue<string>("billto_postalcode"); }
			set
			{ 
				if(value == BillToZIPPostalCode) return;
				SetAttributeValue("billto_postalcode", value);
			}
		}	
			
		/// <summary>
        /// billto_stateorprovince
        /// </summary>
		[DisplayName("Bill To State/Province")]
		[AttributeLogicalName("billto_stateorprovince")]
		public string BillToStateProvince
		{	
			get { return GetAttributeValue<string>("billto_stateorprovince"); }
			set
			{ 
				if(value == BillToStateProvince) return;
				SetAttributeValue("billto_stateorprovince", value);
			}
		}	
			
		/// <summary>
        /// billto_telephone
        /// </summary>
		[DisplayName("Bill To Phone")]
		[AttributeLogicalName("billto_telephone")]
		public string BillToPhone
		{	
			get { return GetAttributeValue<string>("billto_telephone"); }
			set
			{ 
				if(value == BillToPhone) return;
				SetAttributeValue("billto_telephone", value);
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
        /// datefulfilled
        /// </summary>
		[DisplayName("Date Fulfilled")]
		[AttributeLogicalName("datefulfilled")]
		public DateTime? DateFulfilled
		{	
			get { return GetAttributeValue<DateTime?>("datefulfilled"); }
			set
			{ 
				if(value == DateFulfilled) return;
				SetAttributeValue("datefulfilled", value);
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
        /// discountamount
        /// </summary>
		[DisplayName("Order Discount Amount")]
		[AttributeLogicalName("discountamount")]
		public decimal? OrderDiscountAmount
		{	
			get { return GetAttributeValue<Money>("discountamount")?.Value; }
			set 
			{ 
				if(value == OrderDiscountAmount) return;

				Money moneyValue = null;
				if(value != null) moneyValue = new Money(value.Value);
				SetAttributeValue("discountamount", moneyValue);  
			}
		}

		/// <summary>
        /// discountpercentage
        /// </summary>
		[DisplayName("Order Discount (%)")]
		[AttributeLogicalName("discountpercentage")]
		public decimal? OrderDiscount
		{	
			get { return GetAttributeValue<decimal?>("discountpercentage"); }
			set
			{ 
				if(value == OrderDiscount) return;
				SetAttributeValue("discountpercentage", value);
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
        /// freightamount
        /// </summary>
		[DisplayName("Freight Amount")]
		[AttributeLogicalName("freightamount")]
		public decimal? FreightAmount
		{	
			get { return GetAttributeValue<Money>("freightamount")?.Value; }
			set 
			{ 
				if(value == FreightAmount) return;

				Money moneyValue = null;
				if(value != null) moneyValue = new Money(value.Value);
				SetAttributeValue("freightamount", moneyValue);  
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
        /// ispricelocked
        /// </summary>
		[DisplayName("Prices Locked")]
		[AttributeLogicalName("ispricelocked")]
		public bool? PricesLocked
		{	
			get { return GetAttributeValue<bool?>("ispricelocked"); }
			set
			{ 
				if(value == PricesLocked) return;
				SetAttributeValue("ispricelocked", value);
			}
		}	
			
		/// <summary>
        /// lastbackofficesubmit
        /// </summary>
		[DisplayName("Last Submitted to Back Office")]
		[AttributeLogicalName("lastbackofficesubmit")]
		public DateTime? LastSubmittedToBackOffice
		{	
			get { return GetAttributeValue<DateTime?>("lastbackofficesubmit"); }
			set
			{ 
				if(value == LastSubmittedToBackOffice) return;
				SetAttributeValue("lastbackofficesubmit", value);
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
        /// opportunityid
        /// </summary>
		[DisplayName("Opportunity")]
		[AttributeLogicalName("opportunityid")]
		public EntityReference Opportunity
		{	
			get { return GetAttributeValue<EntityReference>("opportunityid"); }
			set
			{ 
				if(value == Opportunity) return;
				SetAttributeValue("opportunityid", value);
			}
		}	
			
		/// <summary>
        /// opportunityidname
        /// </summary>
		[DisplayName("opportunityidname")]
		[AttributeLogicalName("opportunityidname")]
		public string Opportunityidname
		{	
			get { return GetAttributeValue<string>("opportunityidname"); }
			set
			{ 
				if(value == Opportunityidname) return;
				SetAttributeValue("opportunityidname", value);
			}
		}	
			
		/// <summary>
        /// ordernumber
        /// </summary>
		[DisplayName("Order ID")]
		[AttributeLogicalName("ordernumber")]
		public string OrderID
		{	
			get { return GetAttributeValue<string>("ordernumber"); }
			set
			{ 
				if(value == OrderID) return;
				SetAttributeValue("ordernumber", value);
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
        /// pricelevelid
        /// </summary>
		[DisplayName("Price List")]
		[AttributeLogicalName("pricelevelid")]
		public EntityReference PriceList
		{	
			get { return GetAttributeValue<EntityReference>("pricelevelid"); }
			set
			{ 
				if(value == PriceList) return;
				SetAttributeValue("pricelevelid", value);
			}
		}	
			
		/// <summary>
        /// pricelevelidname
        /// </summary>
		[DisplayName("pricelevelidname")]
		[AttributeLogicalName("pricelevelidname")]
		public string Pricelevelidname
		{	
			get { return GetAttributeValue<string>("pricelevelidname"); }
			set
			{ 
				if(value == Pricelevelidname) return;
				SetAttributeValue("pricelevelidname", value);
			}
		}	
			
		/// <summary>
        /// pricingerrorcode
        /// </summary>
		[DisplayName("Pricing Error")]
		[AttributeLogicalName("pricingerrorcode")]
		public egPricingError? PricingError
		{	
			get 
			{ 
				var optionSetValue = GetAttributeValue<OptionSetValue>("pricingerrorcode");
				if (optionSetValue != null) return (egPricingError)optionSetValue.Value;
				else return null;
			}
			set 
			{ 
				if(value == PricingError) return;

				OptionSetValue optionSetValue = null;
				if(value != null) optionSetValue = new OptionSetValue((int)value);
				SetAttributeValue("pricingerrorcode", optionSetValue); 
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
        /// quoteid
        /// </summary>
		[DisplayName("Quote")]
		[AttributeLogicalName("quoteid")]
		public EntityReference Quote
		{	
			get { return GetAttributeValue<EntityReference>("quoteid"); }
			set
			{ 
				if(value == Quote) return;
				SetAttributeValue("quoteid", value);
			}
		}	
			
		/// <summary>
        /// quoteidname
        /// </summary>
		[DisplayName("quoteidname")]
		[AttributeLogicalName("quoteidname")]
		public string Quoteidname
		{	
			get { return GetAttributeValue<string>("quoteidname"); }
			set
			{ 
				if(value == Quoteidname) return;
				SetAttributeValue("quoteidname", value);
			}
		}	
			
		/// <summary>
        /// requestdeliveryby
        /// </summary>
		[DisplayName("Requested Delivery Date")]
		[AttributeLogicalName("requestdeliveryby")]
		public DateTime? RequestedDeliveryDate
		{	
			get { return GetAttributeValue<DateTime?>("requestdeliveryby"); }
			set
			{ 
				if(value == RequestedDeliveryDate) return;
				SetAttributeValue("requestdeliveryby", value);
			}
		}	
			
		/// <summary>
        /// salesorderid
        /// </summary>
		[DisplayName("Order")]
		[AttributeLogicalName("salesorderid")]
		public override Guid Id
		{
			get => base.Id;
			set { base.Id = value; SetAttributeValue("salesorderid", value); }
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
        /// shipto_addressid
        /// </summary>
		[DisplayName("Ship To Address ID")]
		[AttributeLogicalName("shipto_addressid")]
		public Guid ShipToAddressId
		{	
			get { return GetAttributeValue<Guid>("shipto_addressid"); }
			set
			{ 
				if(value == ShipToAddressId) return;
				SetAttributeValue("shipto_addressid", value);
			}
		}	
			
		/// <summary>
        /// shipto_city
        /// </summary>
		[DisplayName("Ship To City")]
		[AttributeLogicalName("shipto_city")]
		public string ShipToCity
		{	
			get { return GetAttributeValue<string>("shipto_city"); }
			set
			{ 
				if(value == ShipToCity) return;
				SetAttributeValue("shipto_city", value);
			}
		}	
			
		/// <summary>
        /// shipto_composite
        /// </summary>
		[DisplayName("Ship To Address")]
		[AttributeLogicalName("shipto_composite")]
		public string ShipToAddress
		{	
			get { return GetAttributeValue<string>("shipto_composite"); }
			set
			{ 
				if(value == ShipToAddress) return;
				SetAttributeValue("shipto_composite", value);
			}
		}	
			
		/// <summary>
        /// shipto_contactname
        /// </summary>
		[DisplayName("Ship To Contact Name")]
		[AttributeLogicalName("shipto_contactname")]
		public string ShipToContactName
		{	
			get { return GetAttributeValue<string>("shipto_contactname"); }
			set
			{ 
				if(value == ShipToContactName) return;
				SetAttributeValue("shipto_contactname", value);
			}
		}	
			
		/// <summary>
        /// shipto_country
        /// </summary>
		[DisplayName("Ship To Country/Region")]
		[AttributeLogicalName("shipto_country")]
		public string ShipToCountryRegion
		{	
			get { return GetAttributeValue<string>("shipto_country"); }
			set
			{ 
				if(value == ShipToCountryRegion) return;
				SetAttributeValue("shipto_country", value);
			}
		}	
			
		/// <summary>
        /// shipto_fax
        /// </summary>
		[DisplayName("Ship to Fax")]
		[AttributeLogicalName("shipto_fax")]
		public string ShipToFax
		{	
			get { return GetAttributeValue<string>("shipto_fax"); }
			set
			{ 
				if(value == ShipToFax) return;
				SetAttributeValue("shipto_fax", value);
			}
		}	
			
		/// <summary>
        /// shipto_freighttermscode
        /// </summary>
		[DisplayName("Ship To Freight Terms")]
		[AttributeLogicalName("shipto_freighttermscode")]
		public eShipToFreightTerms? ShipToFreightTerms
		{	
			get 
			{ 
				var optionSetValue = GetAttributeValue<OptionSetValue>("shipto_freighttermscode");
				if (optionSetValue != null) return (eShipToFreightTerms)optionSetValue.Value;
				else return null;
			}
			set 
			{ 
				if(value == ShipToFreightTerms) return;

				OptionSetValue optionSetValue = null;
				if(value != null) optionSetValue = new OptionSetValue((int)value);
				SetAttributeValue("shipto_freighttermscode", optionSetValue); 
			}
		}

		/// <summary>
        /// shipto_line1
        /// </summary>
		[DisplayName("Ship To Street 1")]
		[AttributeLogicalName("shipto_line1")]
		public string ShipToStreet1
		{	
			get { return GetAttributeValue<string>("shipto_line1"); }
			set
			{ 
				if(value == ShipToStreet1) return;
				SetAttributeValue("shipto_line1", value);
			}
		}	
			
		/// <summary>
        /// shipto_line2
        /// </summary>
		[DisplayName("Ship To Street 2")]
		[AttributeLogicalName("shipto_line2")]
		public string ShipToStreet2
		{	
			get { return GetAttributeValue<string>("shipto_line2"); }
			set
			{ 
				if(value == ShipToStreet2) return;
				SetAttributeValue("shipto_line2", value);
			}
		}	
			
		/// <summary>
        /// shipto_line3
        /// </summary>
		[DisplayName("Ship To Street 3")]
		[AttributeLogicalName("shipto_line3")]
		public string ShipToStreet3
		{	
			get { return GetAttributeValue<string>("shipto_line3"); }
			set
			{ 
				if(value == ShipToStreet3) return;
				SetAttributeValue("shipto_line3", value);
			}
		}	
			
		/// <summary>
        /// shipto_name
        /// </summary>
		[DisplayName("Ship To Name")]
		[AttributeLogicalName("shipto_name")]
		public string ShipToName
		{	
			get { return GetAttributeValue<string>("shipto_name"); }
			set
			{ 
				if(value == ShipToName) return;
				SetAttributeValue("shipto_name", value);
			}
		}	
			
		/// <summary>
        /// shipto_postalcode
        /// </summary>
		[DisplayName("Ship To ZIP/Postal Code")]
		[AttributeLogicalName("shipto_postalcode")]
		public string ShipToZIPPostalCode
		{	
			get { return GetAttributeValue<string>("shipto_postalcode"); }
			set
			{ 
				if(value == ShipToZIPPostalCode) return;
				SetAttributeValue("shipto_postalcode", value);
			}
		}	
			
		/// <summary>
        /// shipto_stateorprovince
        /// </summary>
		[DisplayName("Ship To State/Province")]
		[AttributeLogicalName("shipto_stateorprovince")]
		public string ShipToStateProvince
		{	
			get { return GetAttributeValue<string>("shipto_stateorprovince"); }
			set
			{ 
				if(value == ShipToStateProvince) return;
				SetAttributeValue("shipto_stateorprovince", value);
			}
		}	
			
		/// <summary>
        /// shipto_telephone
        /// </summary>
		[DisplayName("Ship To Phone")]
		[AttributeLogicalName("shipto_telephone")]
		public string ShipToPhone
		{	
			get { return GetAttributeValue<string>("shipto_telephone"); }
			set
			{ 
				if(value == ShipToPhone) return;
				SetAttributeValue("shipto_telephone", value);
			}
		}	
			
		/// <summary>
        /// skippricecalculation
        /// </summary>
		[DisplayName("Skip Price Calculation (For Internal Use)")]
		[AttributeLogicalName("skippricecalculation")]
		public egSkipPriceCalculationOptionSet? SkipPriceCalculationForInternalUse
		{	
			get 
			{ 
				var optionSetValue = GetAttributeValue<OptionSetValue>("skippricecalculation");
				if (optionSetValue != null) return (egSkipPriceCalculationOptionSet)optionSetValue.Value;
				else return null;
			}
			set 
			{ 
				if(value == SkipPriceCalculationForInternalUse) return;

				OptionSetValue optionSetValue = null;
				if(value != null) optionSetValue = new OptionSetValue((int)value);
				SetAttributeValue("skippricecalculation", optionSetValue); 
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
        /// submitdate
        /// </summary>
		[DisplayName("Date Submitted")]
		[AttributeLogicalName("submitdate")]
		public DateTime? DateSubmitted
		{	
			get { return GetAttributeValue<DateTime?>("submitdate"); }
			set
			{ 
				if(value == DateSubmitted) return;
				SetAttributeValue("submitdate", value);
			}
		}	
			
		/// <summary>
        /// submitstatus
        /// </summary>
		[DisplayName("Submitted Status")]
		[AttributeLogicalName("submitstatus")]
		public int? SubmittedStatus
		{	
			get { return GetAttributeValue<int?>("submitstatus"); }
			set
			{ 
				if(value == SubmittedStatus) return;
				SetAttributeValue("submitstatus", value);
			}
		}	
			
		/// <summary>
        /// submitstatusdescription
        /// </summary>
		[DisplayName("Submitted Status Description")]
		[AttributeLogicalName("submitstatusdescription")]
		public string SubmittedStatusDescription
		{	
			get { return GetAttributeValue<string>("submitstatusdescription"); }
			set
			{ 
				if(value == SubmittedStatusDescription) return;
				SetAttributeValue("submitstatusdescription", value);
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
        /// totalamount
        /// </summary>
		[DisplayName("Total Amount")]
		[AttributeLogicalName("totalamount")]
		public decimal? TotalAmount
		{	
			get { return GetAttributeValue<Money>("totalamount")?.Value; }
			set 
			{ 
				if(value == TotalAmount) return;

				Money moneyValue = null;
				if(value != null) moneyValue = new Money(value.Value);
				SetAttributeValue("totalamount", moneyValue);  
			}
		}

		/// <summary>
        /// totalamountlessfreight
        /// </summary>
		[DisplayName("Total Pre-Freight Amount")]
		[AttributeLogicalName("totalamountlessfreight")]
		public decimal? TotalPreFreightAmount
		{	
			get { return GetAttributeValue<Money>("totalamountlessfreight")?.Value; }
			set 
			{ 
				if(value == TotalPreFreightAmount) return;

				Money moneyValue = null;
				if(value != null) moneyValue = new Money(value.Value);
				SetAttributeValue("totalamountlessfreight", moneyValue);  
			}
		}

		/// <summary>
        /// totaldiscountamount
        /// </summary>
		[DisplayName("Total Discount Amount")]
		[AttributeLogicalName("totaldiscountamount")]
		public decimal? TotalDiscountAmount
		{	
			get { return GetAttributeValue<Money>("totaldiscountamount")?.Value; }
			set 
			{ 
				if(value == TotalDiscountAmount) return;

				Money moneyValue = null;
				if(value != null) moneyValue = new Money(value.Value);
				SetAttributeValue("totaldiscountamount", moneyValue);  
			}
		}

		/// <summary>
        /// totallineitemamount
        /// </summary>
		[DisplayName("Total Detail Amount")]
		[AttributeLogicalName("totallineitemamount")]
		public decimal? TotalDetailAmount
		{	
			get { return GetAttributeValue<Money>("totallineitemamount")?.Value; }
			set 
			{ 
				if(value == TotalDetailAmount) return;

				Money moneyValue = null;
				if(value != null) moneyValue = new Money(value.Value);
				SetAttributeValue("totallineitemamount", moneyValue);  
			}
		}

		/// <summary>
        /// totallineitemdiscountamount
        /// </summary>
		[DisplayName("Total Line Item Discount Amount")]
		[AttributeLogicalName("totallineitemdiscountamount")]
		public decimal? TotalLineItemDiscountAmount
		{	
			get { return GetAttributeValue<Money>("totallineitemdiscountamount")?.Value; }
			set 
			{ 
				if(value == TotalLineItemDiscountAmount) return;

				Money moneyValue = null;
				if(value != null) moneyValue = new Money(value.Value);
				SetAttributeValue("totallineitemdiscountamount", moneyValue);  
			}
		}

		/// <summary>
        /// totaltax
        /// </summary>
		[DisplayName("Total Tax")]
		[AttributeLogicalName("totaltax")]
		public decimal? TotalTax
		{	
			get { return GetAttributeValue<Money>("totaltax")?.Value; }
			set 
			{ 
				if(value == TotalTax) return;

				Money moneyValue = null;
				if(value != null) moneyValue = new Money(value.Value);
				SetAttributeValue("totaltax", moneyValue);  
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
        /// willcall
        /// </summary>
		[DisplayName("Ship To")]
		[AttributeLogicalName("willcall")]
		public bool? ShipTo
		{	
			get { return GetAttributeValue<bool?>("willcall"); }
			set
			{ 
				if(value == ShipTo) return;
				SetAttributeValue("willcall", value);
			}
		}	
			
		#endregion	

		#region Relations
			/// <summary>
        /// 1:N Get entities for 'lk_opportunitysalesprocess_salesorderid'
        /// </summary>
		[RelationshipSchemaName("lk_opportunitysalesprocess_salesorderid")]
		public IEnumerable<OpportunitySalesProcess> LkOpportunitysalesprocessSalesorderid
		{
			get { return GetRelatedEntities<OpportunitySalesProcess>("lk_opportunitysalesprocess_salesorderid", null); }
			set { SetRelatedEntities("lk_opportunitysalesprocess_salesorderid", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'msdyn_playbookinstance_salesorder'
        /// </summary>
		[RelationshipSchemaName("msdyn_playbookinstance_salesorder")]
		public IEnumerable<Playbook> MsdynPlaybookinstanceSalesorder
		{
			get { return GetRelatedEntities<Playbook>("msdyn_playbookinstance_salesorder", null); }
			set { SetRelatedEntities("msdyn_playbookinstance_salesorder", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'order_details'
        /// </summary>
		[RelationshipSchemaName("order_details")]
		public IEnumerable<OrderProduct> OrderDetails
		{
			get { return GetRelatedEntities<OrderProduct>("order_details", null); }
			set { SetRelatedEntities("order_details", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'order_invoices'
        /// </summary>
		[RelationshipSchemaName("order_invoices")]
		public IEnumerable<Invoice> OrderInvoices
		{
			get { return GetRelatedEntities<Invoice>("order_invoices", null); }
			set { SetRelatedEntities("order_invoices", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'salesorder_activity_parties'
        /// </summary>
		[RelationshipSchemaName("salesorder_activity_parties")]
		public IEnumerable<ActivityParty> SalesorderActivityParties
		{
			get { return GetRelatedEntities<ActivityParty>("salesorder_activity_parties", null); }
			set { SetRelatedEntities("salesorder_activity_parties", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'SalesOrder_ActivityPointers'
        /// </summary>
		[RelationshipSchemaName("SalesOrder_ActivityPointers")]
		public IEnumerable<Activity> SalesOrderActivityPointers
		{
			get { return GetRelatedEntities<Activity>("SalesOrder_ActivityPointers", null); }
			set { SetRelatedEntities("SalesOrder_ActivityPointers", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'SalesOrder_Annotation'
        /// </summary>
		[RelationshipSchemaName("SalesOrder_Annotation")]
		public IEnumerable<Note> SalesOrderAnnotation
		{
			get { return GetRelatedEntities<Note>("SalesOrder_Annotation", null); }
			set { SetRelatedEntities("SalesOrder_Annotation", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'SalesOrder_Appointments'
        /// </summary>
		[RelationshipSchemaName("SalesOrder_Appointments")]
		public IEnumerable<Appointment> SalesOrderAppointments
		{
			get { return GetRelatedEntities<Appointment>("SalesOrder_Appointments", null); }
			set { SetRelatedEntities("SalesOrder_Appointments", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'SalesOrder_AsyncOperations'
        /// </summary>
		[RelationshipSchemaName("SalesOrder_AsyncOperations")]
		public IEnumerable<SystemJob> SalesOrderAsyncOperations
		{
			get { return GetRelatedEntities<SystemJob>("SalesOrder_AsyncOperations", null); }
			set { SetRelatedEntities("SalesOrder_AsyncOperations", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'SalesOrder_BulkDeleteFailures'
        /// </summary>
		[RelationshipSchemaName("SalesOrder_BulkDeleteFailures")]
		public IEnumerable<BulkDeleteFailure> SalesOrderBulkDeleteFailures
		{
			get { return GetRelatedEntities<BulkDeleteFailure>("SalesOrder_BulkDeleteFailures", null); }
			set { SetRelatedEntities("SalesOrder_BulkDeleteFailures", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'salesorder_connections1'
        /// </summary>
		[RelationshipSchemaName("salesorder_connections1")]
		public IEnumerable<Connection> SalesorderConnections1
		{
			get { return GetRelatedEntities<Connection>("salesorder_connections1", null); }
			set { SetRelatedEntities("salesorder_connections1", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'salesorder_connections2'
        /// </summary>
		[RelationshipSchemaName("salesorder_connections2")]
		public IEnumerable<Connection> SalesorderConnections2
		{
			get { return GetRelatedEntities<Connection>("salesorder_connections2", null); }
			set { SetRelatedEntities("salesorder_connections2", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'SalesOrder_Emails'
        /// </summary>
		[RelationshipSchemaName("SalesOrder_Emails")]
		public IEnumerable<Email> SalesOrderEmails
		{
			get { return GetRelatedEntities<Email>("SalesOrder_Emails", null); }
			set { SetRelatedEntities("SalesOrder_Emails", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'SalesOrder_Faxes'
        /// </summary>
		[RelationshipSchemaName("SalesOrder_Faxes")]
		public IEnumerable<Fax> SalesOrderFaxes
		{
			get { return GetRelatedEntities<Fax>("SalesOrder_Faxes", null); }
			set { SetRelatedEntities("SalesOrder_Faxes", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'SalesOrder_Letters'
        /// </summary>
		[RelationshipSchemaName("SalesOrder_Letters")]
		public IEnumerable<Letter> SalesOrderLetters
		{
			get { return GetRelatedEntities<Letter>("SalesOrder_Letters", null); }
			set { SetRelatedEntities("SalesOrder_Letters", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'SalesOrder_MailboxTrackingFolder'
        /// </summary>
		[RelationshipSchemaName("SalesOrder_MailboxTrackingFolder")]
		public IEnumerable<MailboxAutoTrackingFolder> SalesOrderMailboxTrackingFolder
		{
			get { return GetRelatedEntities<MailboxAutoTrackingFolder>("SalesOrder_MailboxTrackingFolder", null); }
			set { SetRelatedEntities("SalesOrder_MailboxTrackingFolder", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'SalesOrder_OrderClose'
        /// </summary>
		[RelationshipSchemaName("SalesOrder_OrderClose")]
		public IEnumerable<OrderClose> SalesOrderOrderClose
		{
			get { return GetRelatedEntities<OrderClose>("SalesOrder_OrderClose", null); }
			set { SetRelatedEntities("SalesOrder_OrderClose", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'SalesOrder_Phonecalls'
        /// </summary>
		[RelationshipSchemaName("SalesOrder_Phonecalls")]
		public IEnumerable<PhoneCall> SalesOrderPhonecalls
		{
			get { return GetRelatedEntities<PhoneCall>("SalesOrder_Phonecalls", null); }
			set { SetRelatedEntities("SalesOrder_Phonecalls", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'salesorder_principalobjectattributeaccess'
        /// </summary>
		[RelationshipSchemaName("salesorder_principalobjectattributeaccess")]
		public IEnumerable<FieldSharing> SalesorderPrincipalobjectattributeaccess
		{
			get { return GetRelatedEntities<FieldSharing>("salesorder_principalobjectattributeaccess", null); }
			set { SetRelatedEntities("salesorder_principalobjectattributeaccess", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'SalesOrder_ProcessSessions'
        /// </summary>
		[RelationshipSchemaName("SalesOrder_ProcessSessions")]
		public IEnumerable<ProcessSession> SalesOrderProcessSessions
		{
			get { return GetRelatedEntities<ProcessSession>("SalesOrder_ProcessSessions", null); }
			set { SetRelatedEntities("SalesOrder_ProcessSessions", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'SalesOrder_RecurringAppointmentMasters'
        /// </summary>
		[RelationshipSchemaName("SalesOrder_RecurringAppointmentMasters")]
		public IEnumerable<RecurringAppointment> SalesOrderRecurringAppointmentMasters
		{
			get { return GetRelatedEntities<RecurringAppointment>("SalesOrder_RecurringAppointmentMasters", null); }
			set { SetRelatedEntities("SalesOrder_RecurringAppointmentMasters", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'SalesOrder_ServiceAppointments'
        /// </summary>
		[RelationshipSchemaName("SalesOrder_ServiceAppointments")]
		public IEnumerable<ServiceActivity> SalesOrderServiceAppointments
		{
			get { return GetRelatedEntities<ServiceActivity>("SalesOrder_ServiceAppointments", null); }
			set { SetRelatedEntities("SalesOrder_ServiceAppointments", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'SalesOrder_SocialActivities'
        /// </summary>
		[RelationshipSchemaName("SalesOrder_SocialActivities")]
		public IEnumerable<SocialActivity> SalesOrderSocialActivities
		{
			get { return GetRelatedEntities<SocialActivity>("SalesOrder_SocialActivities", null); }
			set { SetRelatedEntities("SalesOrder_SocialActivities", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'SalesOrder_SyncErrors'
        /// </summary>
		[RelationshipSchemaName("SalesOrder_SyncErrors")]
		public IEnumerable<SyncError> SalesOrderSyncErrors
		{
			get { return GetRelatedEntities<SyncError>("SalesOrder_SyncErrors", null); }
			set { SetRelatedEntities("SalesOrder_SyncErrors", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'SalesOrder_Tasks'
        /// </summary>
		[RelationshipSchemaName("SalesOrder_Tasks")]
		public IEnumerable<Task> SalesOrderTasks
		{
			get { return GetRelatedEntities<Task>("SalesOrder_Tasks", null); }
			set { SetRelatedEntities("SalesOrder_Tasks", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'slakpiinstance_salesorder'
        /// </summary>
		[RelationshipSchemaName("slakpiinstance_salesorder")]
		public IEnumerable<SLAKPIInstance> SlakpiinstanceSalesorder
		{
			get { return GetRelatedEntities<SLAKPIInstance>("slakpiinstance_salesorder", null); }
			set { SetRelatedEntities("slakpiinstance_salesorder", null, value); }
		}
		/// <summary>
        /// N:N Get entities for 'Contact'
        /// </summary>
		[RelationshipSchemaName("contactorders_association")]
		public IEnumerable<Contact> ContactordersAssociation
		{
			get { return GetRelatedEntities<Contact>("contactorders_association", null); }
			set { SetRelatedEntities("contactorders_association", null, value); }
		}
		#endregion

		#region Actions
		#endregion

		#region OptionSetEnums
		public enum egPricingError
		{	
		
			[Label("None")]
			[Description(@"")]
			None = 0, 
		
			[Label("Detail Error")]
			[Description(@"")]
			DetailError = 1, 
		
			[Label("Missing Price Level")]
			[Description(@"")]
			MissingPriceLevel = 2, 
		
			[Label("Inactive Price Level")]
			[Description(@"")]
			InactivePriceLevel = 3, 
		
			[Label("Missing Quantity")]
			[Description(@"")]
			MissingQuantity = 4, 
		
			[Label("Missing Unit Price")]
			[Description(@"")]
			MissingUnitPrice = 5, 
		
			[Label("Missing Product")]
			[Description(@"")]
			MissingProduct = 6, 
		
			[Label("Invalid Product")]
			[Description(@"")]
			InvalidProduct = 7, 
		
			[Label("Missing Pricing Code")]
			[Description(@"")]
			MissingPricingCode = 8, 
		
			[Label("Invalid Pricing Code")]
			[Description(@"")]
			InvalidPricingCode = 9, 
		
			[Label("Missing UOM")]
			[Description(@"")]
			MissingUOM = 10, 
		
			[Label("Product Not In Price Level")]
			[Description(@"")]
			ProductNotInPriceLevel = 11, 
		
			[Label("Missing Price Level Amount")]
			[Description(@"")]
			MissingPriceLevelAmount = 12, 
		
			[Label("Missing Price Level Percentage")]
			[Description(@"")]
			MissingPriceLevelPercentage = 13, 
		
			[Label("Missing Price")]
			[Description(@"")]
			MissingPrice = 14, 
		
			[Label("Missing Current Cost")]
			[Description(@"")]
			MissingCurrentCost = 15, 
		
			[Label("Missing Standard Cost")]
			[Description(@"")]
			MissingStandardCost = 16, 
		
			[Label("Invalid Price Level Amount")]
			[Description(@"")]
			InvalidPriceLevelAmount = 17, 
		
			[Label("Invalid Price Level Percentage")]
			[Description(@"")]
			InvalidPriceLevelPercentage = 18, 
		
			[Label("Invalid Price")]
			[Description(@"")]
			InvalidPrice = 19, 
		
			[Label("Invalid Current Cost")]
			[Description(@"")]
			InvalidCurrentCost = 20, 
		
			[Label("Invalid Standard Cost")]
			[Description(@"")]
			InvalidStandardCost = 21, 
		
			[Label("Invalid Rounding Policy")]
			[Description(@"")]
			InvalidRoundingPolicy = 22, 
		
			[Label("Invalid Rounding Option")]
			[Description(@"")]
			InvalidRoundingOption = 23, 
		
			[Label("Invalid Rounding Amount")]
			[Description(@"")]
			InvalidRoundingAmount = 24, 
		
			[Label("Price Calculation Error")]
			[Description(@"")]
			PriceCalculationError = 25, 
		
			[Label("Invalid Discount Type")]
			[Description(@"")]
			InvalidDiscountType = 26, 
		
			[Label("Discount Type Invalid State")]
			[Description(@"")]
			DiscountTypeInvalidState = 27, 
		
			[Label("Invalid Discount")]
			[Description(@"")]
			InvalidDiscount = 28, 
		
			[Label("Invalid Quantity")]
			[Description(@"")]
			InvalidQuantity = 29, 
		
			[Label("Invalid Pricing Precision")]
			[Description(@"")]
			InvalidPricingPrecision = 30, 
		
			[Label("Missing Product Default UOM")]
			[Description(@"")]
			MissingProductDefaultUOM = 31, 
		
			[Label("Missing Product UOM Schedule")]
			[Description(@"")]
			MissingProductUOMSchedule = 32, 
		
			[Label("Inactive Discount Type")]
			[Description(@"")]
			InactiveDiscountType = 33, 
		
			[Label("Invalid Price Level Currency")]
			[Description(@"")]
			InvalidPriceLevelCurrency = 34, 
		
			[Label("Price Attribute Out Of Range")]
			[Description(@"")]
			PriceAttributeOutOfRange = 35, 
		
			[Label("Base Currency Attribute Overflow")]
			[Description(@"")]
			BaseCurrencyAttributeOverflow = 36, 
		
			[Label("Base Currency Attribute Underflow")]
			[Description(@"")]
			BaseCurrencyAttributeUnderflow = 37, 
		
			[Label("Transaction currency is not set for the product price list item")]
			[Description(@"")]
			TransactionCurrencyIsNotSetForTheProductPriceListItem = 38, 
		}
		
		public enum egSkipPriceCalculationOptionSet
		{	
		
			[Label("DoPriceCalcAlways")]
			[Description(@"")]
			DoPriceCalcAlways = 0, 
		
			[Label("SkipPriceCalcOnRetrieve")]
			[Description(@"")]
			SkipPriceCalcOnRetrieve = 1, 
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
		
		public enum ePriority
		{	
		
			[Label("Default Value")]
			[Description(@"")]
			DefaultValue = 1, 
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
		
		public enum eShipToFreightTerms
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
		
			[Label("Submitted")]
			[Description(@"")]
			Submitted = 1, 
		
			[Label("Canceled")]
			[Description(@"")]
			Canceled = 2, 
		
			[Label("Fulfilled")]
			[Description(@"")]
			Fulfilled = 3, 
		
			[Label("Invoiced")]
			[Description(@"")]
			Invoiced = 4, 
		}
		
		public enum eStatusReason
		{	
		
			[Label("In Progress")]
			[Description(@"")]
			InProgress_Inactive = 3, 
		
			[Label("No Money")]
			[Description(@"")]
			NoMoney = 4, 
		
			[Label("New")]
			[Description(@"")]
			New_Active = 1, 
		
			[Label("Pending")]
			[Description(@"")]
			Pending_Active = 2, 
		
			[Label("Complete")]
			[Description(@"")]
			Complete = 100001, 
		
			[Label("Partial")]
			[Description(@"")]
			Partial = 100002, 
		
			[Label("Invoiced")]
			[Description(@"")]
			Invoiced = 100003, 
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

			/// <summary>billto_addressid</summary>
			public const string BillToAddressId = "billto_addressid";

			/// <summary>billto_city</summary>
			public const string BillToCity = "billto_city";

			/// <summary>billto_composite</summary>
			public const string BillToAddress = "billto_composite";

			/// <summary>billto_contactname</summary>
			public const string BillToContactName = "billto_contactname";

			/// <summary>billto_country</summary>
			public const string BillToCountryRegion = "billto_country";

			/// <summary>billto_fax</summary>
			public const string BillToFax = "billto_fax";

			/// <summary>billto_line1</summary>
			public const string BillToStreet1 = "billto_line1";

			/// <summary>billto_line2</summary>
			public const string BillToStreet2 = "billto_line2";

			/// <summary>billto_line3</summary>
			public const string BillToStreet3 = "billto_line3";

			/// <summary>billto_name</summary>
			public const string BillToName = "billto_name";

			/// <summary>billto_postalcode</summary>
			public const string BillToZIPPostalCode = "billto_postalcode";

			/// <summary>billto_stateorprovince</summary>
			public const string BillToStateProvince = "billto_stateorprovince";

			/// <summary>billto_telephone</summary>
			public const string BillToPhone = "billto_telephone";

			/// <summary>campaignid</summary>
			public const string SourceCampaign = "campaignid";

			/// <summary>campaignidname</summary>
			public const string Campaignidname = "campaignidname";

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

			/// <summary>datefulfilled</summary>
			public const string DateFulfilled = "datefulfilled";

			/// <summary>description</summary>
			public const string Description = "description";

			/// <summary>discountamount</summary>
			public const string OrderDiscountAmount = "discountamount";

			/// <summary>discountpercentage</summary>
			public const string OrderDiscount = "discountpercentage";

			/// <summary>emailaddress</summary>
			public const string EmailAddress = "emailaddress";

			/// <summary>entityimage_timestamp</summary>
			public const string EntityimageTimestamp = "entityimage_timestamp";

			/// <summary>entityimage_url</summary>
			public const string EntityimageUrl = "entityimage_url";

			/// <summary>entityimageid</summary>
			public const string EntityimageId = "entityimageid";

			/// <summary>exchangerate</summary>
			public const string ExchangeRate = "exchangerate";

			/// <summary>freightamount</summary>
			public const string FreightAmount = "freightamount";

			/// <summary>freighttermscode</summary>
			public const string FreightTerms = "freighttermscode";

			/// <summary>importsequencenumber</summary>
			public const string ImportSequenceNumber = "importsequencenumber";

			/// <summary>ispricelocked</summary>
			public const string PricesLocked = "ispricelocked";

			/// <summary>lastbackofficesubmit</summary>
			public const string LastSubmittedToBackOffice = "lastbackofficesubmit";

			/// <summary>lastonholdtime</summary>
			public const string LastOnHoldTime = "lastonholdtime";

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

			/// <summary>onholdtime</summary>
			public const string OnHoldTimeMinutes = "onholdtime";

			/// <summary>opportunityid</summary>
			public const string Opportunity = "opportunityid";

			/// <summary>opportunityidname</summary>
			public const string Opportunityidname = "opportunityidname";

			/// <summary>ordernumber</summary>
			public const string OrderID = "ordernumber";

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

			/// <summary>paymenttermscode</summary>
			public const string PaymentTerms = "paymenttermscode";

			/// <summary>pricelevelid</summary>
			public const string PriceList = "pricelevelid";

			/// <summary>pricelevelidname</summary>
			public const string Pricelevelidname = "pricelevelidname";

			/// <summary>pricingerrorcode</summary>
			public const string PricingError = "pricingerrorcode";

			/// <summary>prioritycode</summary>
			public const string Priority = "prioritycode";

			/// <summary>processid</summary>
			public const string ProcessId = "processid";

			/// <summary>quoteid</summary>
			public const string Quote = "quoteid";

			/// <summary>quoteidname</summary>
			public const string Quoteidname = "quoteidname";

			/// <summary>requestdeliveryby</summary>
			public const string RequestedDeliveryDate = "requestdeliveryby";

			/// <summary>salesorderid</summary>
			public const string OrderId = "salesorderid";

			/// <summary>shippingmethodcode</summary>
			public const string ShippingMethod = "shippingmethodcode";

			/// <summary>shipto_addressid</summary>
			public const string ShipToAddressId = "shipto_addressid";

			/// <summary>shipto_city</summary>
			public const string ShipToCity = "shipto_city";

			/// <summary>shipto_composite</summary>
			public const string ShipToAddress = "shipto_composite";

			/// <summary>shipto_contactname</summary>
			public const string ShipToContactName = "shipto_contactname";

			/// <summary>shipto_country</summary>
			public const string ShipToCountryRegion = "shipto_country";

			/// <summary>shipto_fax</summary>
			public const string ShipToFax = "shipto_fax";

			/// <summary>shipto_freighttermscode</summary>
			public const string ShipToFreightTerms = "shipto_freighttermscode";

			/// <summary>shipto_line1</summary>
			public const string ShipToStreet1 = "shipto_line1";

			/// <summary>shipto_line2</summary>
			public const string ShipToStreet2 = "shipto_line2";

			/// <summary>shipto_line3</summary>
			public const string ShipToStreet3 = "shipto_line3";

			/// <summary>shipto_name</summary>
			public const string ShipToName = "shipto_name";

			/// <summary>shipto_postalcode</summary>
			public const string ShipToZIPPostalCode = "shipto_postalcode";

			/// <summary>shipto_stateorprovince</summary>
			public const string ShipToStateProvince = "shipto_stateorprovince";

			/// <summary>shipto_telephone</summary>
			public const string ShipToPhone = "shipto_telephone";

			/// <summary>skippricecalculation</summary>
			public const string SkipPriceCalculationForInternalUse = "skippricecalculation";

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

			/// <summary>submitdate</summary>
			public const string DateSubmitted = "submitdate";

			/// <summary>submitstatus</summary>
			public const string SubmittedStatus = "submitstatus";

			/// <summary>submitstatusdescription</summary>
			public const string SubmittedStatusDescription = "submitstatusdescription";

			/// <summary>timezoneruleversionnumber</summary>
			public const string TimeZoneRuleVersionNumber = "timezoneruleversionnumber";

			/// <summary>totalamount</summary>
			public const string TotalAmount = "totalamount";

			/// <summary>totalamountlessfreight</summary>
			public const string TotalPreFreightAmount = "totalamountlessfreight";

			/// <summary>totaldiscountamount</summary>
			public const string TotalDiscountAmount = "totaldiscountamount";

			/// <summary>totallineitemamount</summary>
			public const string TotalDetailAmount = "totallineitemamount";

			/// <summary>totallineitemdiscountamount</summary>
			public const string TotalLineItemDiscountAmount = "totallineitemdiscountamount";

			/// <summary>totaltax</summary>
			public const string TotalTax = "totaltax";

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

			/// <summary>willcall</summary>
			public const string ShipTo = "willcall";

		}
		#endregion

		#region Schemas
		public static class Schemas 
		{
			/// <summary>1:N lk_opportunitysalesprocess_salesorderid</summary>
			public const string LkOpportunitysalesprocessSalesorderid = "lk_opportunitysalesprocess_salesorderid";

			/// <summary>1:N msdyn_playbookinstance_salesorder</summary>
			public const string MsdynPlaybookinstanceSalesorder = "msdyn_playbookinstance_salesorder";

			/// <summary>1:N order_details</summary>
			public const string OrderDetails = "order_details";

			/// <summary>1:N order_invoices</summary>
			public const string OrderInvoices = "order_invoices";

			/// <summary>1:N salesorder_activity_parties</summary>
			public const string SalesorderActivityParties = "salesorder_activity_parties";

			/// <summary>1:N SalesOrder_ActivityPointers</summary>
			public const string SalesOrderActivityPointers = "SalesOrder_ActivityPointers";

			/// <summary>1:N SalesOrder_Annotation</summary>
			public const string SalesOrderAnnotation = "SalesOrder_Annotation";

			/// <summary>1:N SalesOrder_Appointments</summary>
			public const string SalesOrderAppointments = "SalesOrder_Appointments";

			/// <summary>1:N SalesOrder_AsyncOperations</summary>
			public const string SalesOrderAsyncOperations = "SalesOrder_AsyncOperations";

			/// <summary>1:N SalesOrder_BulkDeleteFailures</summary>
			public const string SalesOrderBulkDeleteFailures = "SalesOrder_BulkDeleteFailures";

			/// <summary>1:N salesorder_connections1</summary>
			public const string SalesorderConnections1 = "salesorder_connections1";

			/// <summary>1:N salesorder_connections2</summary>
			public const string SalesorderConnections2 = "salesorder_connections2";

			/// <summary>1:N SalesOrder_Emails</summary>
			public const string SalesOrderEmails = "SalesOrder_Emails";

			/// <summary>1:N SalesOrder_Faxes</summary>
			public const string SalesOrderFaxes = "SalesOrder_Faxes";

			/// <summary>1:N SalesOrder_Letters</summary>
			public const string SalesOrderLetters = "SalesOrder_Letters";

			/// <summary>1:N SalesOrder_MailboxTrackingFolder</summary>
			public const string SalesOrderMailboxTrackingFolder = "SalesOrder_MailboxTrackingFolder";

			/// <summary>1:N SalesOrder_OrderClose</summary>
			public const string SalesOrderOrderClose = "SalesOrder_OrderClose";

			/// <summary>1:N SalesOrder_Phonecalls</summary>
			public const string SalesOrderPhonecalls = "SalesOrder_Phonecalls";

			/// <summary>1:N salesorder_principalobjectattributeaccess</summary>
			public const string SalesorderPrincipalobjectattributeaccess = "salesorder_principalobjectattributeaccess";

			/// <summary>1:N SalesOrder_ProcessSessions</summary>
			public const string SalesOrderProcessSessions = "SalesOrder_ProcessSessions";

			/// <summary>1:N SalesOrder_RecurringAppointmentMasters</summary>
			public const string SalesOrderRecurringAppointmentMasters = "SalesOrder_RecurringAppointmentMasters";

			/// <summary>1:N SalesOrder_ServiceAppointments</summary>
			public const string SalesOrderServiceAppointments = "SalesOrder_ServiceAppointments";

			/// <summary>1:N SalesOrder_SocialActivities</summary>
			public const string SalesOrderSocialActivities = "SalesOrder_SocialActivities";

			/// <summary>1:N SalesOrder_SyncErrors</summary>
			public const string SalesOrderSyncErrors = "SalesOrder_SyncErrors";

			/// <summary>1:N SalesOrder_Tasks</summary>
			public const string SalesOrderTasks = "SalesOrder_Tasks";

			/// <summary>1:N slakpiinstance_salesorder</summary>
			public const string SlakpiinstanceSalesorder = "slakpiinstance_salesorder";

			/// <summary>N:N contactorders_association</summary>
			public const string ContactordersAssociation = "contactorders_association";

		}
		#endregion
	}
}

