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
	[EntityLogicalName("invoice")]
	public sealed class Invoice : Entity
	{	
		public static readonly int? EntityTypeCode = 1090;
		public new const string LogicalName = "invoice";
		public const string PrimaryIdAttribute = "invoiceid";
		public const string PrimaryNameAttribute = "name";
	
		public Invoice() : base("invoice") { }

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
        /// datedelivered
        /// </summary>
		[DisplayName("Date Delivered")]
		[AttributeLogicalName("datedelivered")]
		public DateTime? DateDelivered
		{	
			get { return GetAttributeValue<DateTime?>("datedelivered"); }
			set
			{ 
				if(value == DateDelivered) return;
				SetAttributeValue("datedelivered", value);
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
		///
		/// Precision: 2
		/// MaxValue: 1000000000000
		/// MinValue: 0
        /// </summary>
		[DisplayName("Invoice Discount Amount")]
		[AttributeLogicalName("discountamount")]
		public decimal? InvoiceDiscountAmount
		{	
			get { return GetAttributeValue<Money>("discountamount")?.Value; }
			set 
			{
				Money moneyValue = null;
				if(value != null) 
				{
					var roundedValue = Decimal.Round(value.Value, 2);
					moneyValue = new Money(roundedValue);
				}

				if(moneyValue.Value == InvoiceDiscountAmount) return;
				SetAttributeValue("discountamount", moneyValue);  
			}
		}

		/// <summary>
        /// discountpercentage
		///
		/// Precision: 2
		/// MaxValue: 100
		/// MinValue: 0
        /// </summary>
		[DisplayName("Invoice Discount (%)")]
		[AttributeLogicalName("discountpercentage")]
		public decimal? InvoiceDiscount
		{	
			get { return GetAttributeValue<decimal?>("discountpercentage"); }
			set 
			{
				decimal? decimalValue = null;
				if(value != null) decimalValue = Decimal.Round(value.Value, 2);
				if(decimalValue == InvoiceDiscount) return;
				SetAttributeValue("discountpercentage", decimalValue);  
			}
		}

		/// <summary>
        /// duedate
        /// </summary>
		[DisplayName("Due Date")]
		[AttributeLogicalName("duedate")]
		public DateTime? DueDate
		{	
			get { return GetAttributeValue<DateTime?>("duedate"); }
			set
			{ 
				if(value == DueDate) return;
				SetAttributeValue("duedate", value);
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
        /// freightamount
		///
		/// Precision: 2
		/// MaxValue: 1000000000000
		/// MinValue: 0
        /// </summary>
		[DisplayName("Freight Amount")]
		[AttributeLogicalName("freightamount")]
		public decimal? FreightAmount
		{	
			get { return GetAttributeValue<Money>("freightamount")?.Value; }
			set 
			{
				Money moneyValue = null;
				if(value != null) 
				{
					var roundedValue = Decimal.Round(value.Value, 2);
					moneyValue = new Money(roundedValue);
				}

				if(moneyValue.Value == FreightAmount) return;
				SetAttributeValue("freightamount", moneyValue);  
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
        /// invoiceid
        /// </summary>
		[DisplayName("Invoice")]
		[AttributeLogicalName("invoiceid")]
		public override Guid Id
		{
			get => base.Id;
			set { base.Id = value; SetAttributeValue("invoiceid", value); }
		}

							/// <summary>
        /// invoicenumber
        /// </summary>
		[DisplayName("Invoice ID")]
		[AttributeLogicalName("invoicenumber")]
		public string InvoiceID
		{	
			get { return GetAttributeValue<string>("invoicenumber"); }
			set
			{ 
				if(value == InvoiceID) return;
				SetAttributeValue("invoicenumber", value);
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
        /// salesorderid
        /// </summary>
		[DisplayName("Order")]
		[AttributeLogicalName("salesorderid")]
		public EntityReference Order
		{	
			get { return GetAttributeValue<EntityReference>("salesorderid"); }
			set
			{ 
				if(value == Order) return;
				SetAttributeValue("salesorderid", value);
			}
		}	
			
		/// <summary>
        /// salesorderidname
        /// </summary>
		[DisplayName("salesorderidname")]
		[AttributeLogicalName("salesorderidname")]
		public string Salesorderidname
		{	
			get { return GetAttributeValue<string>("salesorderidname"); }
			set
			{ 
				if(value == Salesorderidname) return;
				SetAttributeValue("salesorderidname", value);
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
		[DisplayName("Ship To Fax")]
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
		[DisplayName("Skip Price Calculation")]
		[AttributeLogicalName("skippricecalculation")]
		public egSkipPriceCalculationOptionSet? SkipPriceCalculation
		{	
			get 
			{ 
				var optionSetValue = GetAttributeValue<OptionSetValue>("skippricecalculation");
				if (optionSetValue != null) return (egSkipPriceCalculationOptionSet)optionSetValue.Value;
				else return null;
			}
			set 
			{ 
				if(value == SkipPriceCalculation) return;

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
		///
		/// Precision: 2
		/// MaxValue: 922337203685477
		/// MinValue: -922337203685477
        /// </summary>
		[DisplayName("Total Amount")]
		[AttributeLogicalName("totalamount")]
		public decimal? TotalAmount
		{	
			get { return GetAttributeValue<Money>("totalamount")?.Value; }
			set 
			{
				Money moneyValue = null;
				if(value != null) 
				{
					var roundedValue = Decimal.Round(value.Value, 2);
					moneyValue = new Money(roundedValue);
				}

				if(moneyValue.Value == TotalAmount) return;
				SetAttributeValue("totalamount", moneyValue);  
			}
		}

		/// <summary>
        /// totalamountlessfreight
		///
		/// Precision: 2
		/// MaxValue: 922337203685477
		/// MinValue: -922337203685477
        /// </summary>
		[DisplayName("Total Pre-Freight Amount")]
		[AttributeLogicalName("totalamountlessfreight")]
		public decimal? TotalPreFreightAmount
		{	
			get { return GetAttributeValue<Money>("totalamountlessfreight")?.Value; }
			set 
			{
				Money moneyValue = null;
				if(value != null) 
				{
					var roundedValue = Decimal.Round(value.Value, 2);
					moneyValue = new Money(roundedValue);
				}

				if(moneyValue.Value == TotalPreFreightAmount) return;
				SetAttributeValue("totalamountlessfreight", moneyValue);  
			}
		}

		/// <summary>
        /// totaldiscountamount
		///
		/// Precision: 2
		/// MaxValue: 922337203685477
		/// MinValue: -922337203685477
        /// </summary>
		[DisplayName("Total Discount Amount")]
		[AttributeLogicalName("totaldiscountamount")]
		public decimal? TotalDiscountAmount
		{	
			get { return GetAttributeValue<Money>("totaldiscountamount")?.Value; }
			set 
			{
				Money moneyValue = null;
				if(value != null) 
				{
					var roundedValue = Decimal.Round(value.Value, 2);
					moneyValue = new Money(roundedValue);
				}

				if(moneyValue.Value == TotalDiscountAmount) return;
				SetAttributeValue("totaldiscountamount", moneyValue);  
			}
		}

		/// <summary>
        /// totallineitemamount
		///
		/// Precision: 2
		/// MaxValue: 922337203685477
		/// MinValue: -922337203685477
        /// </summary>
		[DisplayName("Total Detail Amount")]
		[AttributeLogicalName("totallineitemamount")]
		public decimal? TotalDetailAmount
		{	
			get { return GetAttributeValue<Money>("totallineitemamount")?.Value; }
			set 
			{
				Money moneyValue = null;
				if(value != null) 
				{
					var roundedValue = Decimal.Round(value.Value, 2);
					moneyValue = new Money(roundedValue);
				}

				if(moneyValue.Value == TotalDetailAmount) return;
				SetAttributeValue("totallineitemamount", moneyValue);  
			}
		}

		/// <summary>
        /// totallineitemdiscountamount
		///
		/// Precision: 2
		/// MaxValue: 922337203685477
		/// MinValue: -922337203685477
        /// </summary>
		[DisplayName("Total Line Item Discount Amount")]
		[AttributeLogicalName("totallineitemdiscountamount")]
		public decimal? TotalLineItemDiscountAmount
		{	
			get { return GetAttributeValue<Money>("totallineitemdiscountamount")?.Value; }
			set 
			{
				Money moneyValue = null;
				if(value != null) 
				{
					var roundedValue = Decimal.Round(value.Value, 2);
					moneyValue = new Money(roundedValue);
				}

				if(moneyValue.Value == TotalLineItemDiscountAmount) return;
				SetAttributeValue("totallineitemdiscountamount", moneyValue);  
			}
		}

		/// <summary>
        /// totaltax
		///
		/// Precision: 2
		/// MaxValue: 922337203685477
		/// MinValue: -922337203685477
        /// </summary>
		[DisplayName("Total Tax")]
		[AttributeLogicalName("totaltax")]
		public decimal? TotalTax
		{	
			get { return GetAttributeValue<Money>("totaltax")?.Value; }
			set 
			{
				Money moneyValue = null;
				if(value != null) 
				{
					var roundedValue = Decimal.Round(value.Value, 2);
					moneyValue = new Money(roundedValue);
				}

				if(moneyValue.Value == TotalTax) return;
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
        /// 1:N Get entities for 'invoice_activity_parties'
        /// </summary>
		[RelationshipSchemaName("invoice_activity_parties")]
		public IEnumerable<ActivityParty> InvoiceActivityParties
		{
			get { return GetRelatedEntities<ActivityParty>("invoice_activity_parties", null); }
			set { SetRelatedEntities("invoice_activity_parties", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'Invoice_ActivityPointers'
        /// </summary>
		[RelationshipSchemaName("Invoice_ActivityPointers")]
		public IEnumerable<Activity> InvoiceActivityPointers
		{
			get { return GetRelatedEntities<Activity>("Invoice_ActivityPointers", null); }
			set { SetRelatedEntities("Invoice_ActivityPointers", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'Invoice_Annotation'
        /// </summary>
		[RelationshipSchemaName("Invoice_Annotation")]
		public IEnumerable<Note> InvoiceAnnotation
		{
			get { return GetRelatedEntities<Note>("Invoice_Annotation", null); }
			set { SetRelatedEntities("Invoice_Annotation", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'Invoice_Appointments'
        /// </summary>
		[RelationshipSchemaName("Invoice_Appointments")]
		public IEnumerable<Appointment> InvoiceAppointments
		{
			get { return GetRelatedEntities<Appointment>("Invoice_Appointments", null); }
			set { SetRelatedEntities("Invoice_Appointments", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'Invoice_AsyncOperations'
        /// </summary>
		[RelationshipSchemaName("Invoice_AsyncOperations")]
		public IEnumerable<SystemJob> InvoiceAsyncOperations
		{
			get { return GetRelatedEntities<SystemJob>("Invoice_AsyncOperations", null); }
			set { SetRelatedEntities("Invoice_AsyncOperations", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'Invoice_BulkDeleteFailures'
        /// </summary>
		[RelationshipSchemaName("Invoice_BulkDeleteFailures")]
		public IEnumerable<BulkDeleteFailure> InvoiceBulkDeleteFailures
		{
			get { return GetRelatedEntities<BulkDeleteFailure>("Invoice_BulkDeleteFailures", null); }
			set { SetRelatedEntities("Invoice_BulkDeleteFailures", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'invoice_connections1'
        /// </summary>
		[RelationshipSchemaName("invoice_connections1")]
		public IEnumerable<Connection> InvoiceConnections1
		{
			get { return GetRelatedEntities<Connection>("invoice_connections1", null); }
			set { SetRelatedEntities("invoice_connections1", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'invoice_connections2'
        /// </summary>
		[RelationshipSchemaName("invoice_connections2")]
		public IEnumerable<Connection> InvoiceConnections2
		{
			get { return GetRelatedEntities<Connection>("invoice_connections2", null); }
			set { SetRelatedEntities("invoice_connections2", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'invoice_details'
        /// </summary>
		[RelationshipSchemaName("invoice_details")]
		public IEnumerable<InvoiceProduct> InvoiceDetails
		{
			get { return GetRelatedEntities<InvoiceProduct>("invoice_details", null); }
			set { SetRelatedEntities("invoice_details", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'Invoice_Emails'
        /// </summary>
		[RelationshipSchemaName("Invoice_Emails")]
		public IEnumerable<Email> InvoiceEmails
		{
			get { return GetRelatedEntities<Email>("Invoice_Emails", null); }
			set { SetRelatedEntities("Invoice_Emails", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'Invoice_Faxes'
        /// </summary>
		[RelationshipSchemaName("Invoice_Faxes")]
		public IEnumerable<Fax> InvoiceFaxes
		{
			get { return GetRelatedEntities<Fax>("Invoice_Faxes", null); }
			set { SetRelatedEntities("Invoice_Faxes", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'Invoice_Letters'
        /// </summary>
		[RelationshipSchemaName("Invoice_Letters")]
		public IEnumerable<Letter> InvoiceLetters
		{
			get { return GetRelatedEntities<Letter>("Invoice_Letters", null); }
			set { SetRelatedEntities("Invoice_Letters", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'Invoice_MailboxTrackingFolder'
        /// </summary>
		[RelationshipSchemaName("Invoice_MailboxTrackingFolder")]
		public IEnumerable<MailboxAutoTrackingFolder> InvoiceMailboxTrackingFolder
		{
			get { return GetRelatedEntities<MailboxAutoTrackingFolder>("Invoice_MailboxTrackingFolder", null); }
			set { SetRelatedEntities("Invoice_MailboxTrackingFolder", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'Invoice_Phonecalls'
        /// </summary>
		[RelationshipSchemaName("Invoice_Phonecalls")]
		public IEnumerable<PhoneCall> InvoicePhonecalls
		{
			get { return GetRelatedEntities<PhoneCall>("Invoice_Phonecalls", null); }
			set { SetRelatedEntities("Invoice_Phonecalls", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'invoice_principalobjectattributeaccess'
        /// </summary>
		[RelationshipSchemaName("invoice_principalobjectattributeaccess")]
		public IEnumerable<FieldSharing> InvoicePrincipalobjectattributeaccess
		{
			get { return GetRelatedEntities<FieldSharing>("invoice_principalobjectattributeaccess", null); }
			set { SetRelatedEntities("invoice_principalobjectattributeaccess", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'Invoice_ProcessSessions'
        /// </summary>
		[RelationshipSchemaName("Invoice_ProcessSessions")]
		public IEnumerable<ProcessSession> InvoiceProcessSessions
		{
			get { return GetRelatedEntities<ProcessSession>("Invoice_ProcessSessions", null); }
			set { SetRelatedEntities("Invoice_ProcessSessions", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'Invoice_RecurringAppointmentMasters'
        /// </summary>
		[RelationshipSchemaName("Invoice_RecurringAppointmentMasters")]
		public IEnumerable<RecurringAppointment> InvoiceRecurringAppointmentMasters
		{
			get { return GetRelatedEntities<RecurringAppointment>("Invoice_RecurringAppointmentMasters", null); }
			set { SetRelatedEntities("Invoice_RecurringAppointmentMasters", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'Invoice_ServiceAppointments'
        /// </summary>
		[RelationshipSchemaName("Invoice_ServiceAppointments")]
		public IEnumerable<ServiceActivity> InvoiceServiceAppointments
		{
			get { return GetRelatedEntities<ServiceActivity>("Invoice_ServiceAppointments", null); }
			set { SetRelatedEntities("Invoice_ServiceAppointments", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'Invoice_SocialActivities'
        /// </summary>
		[RelationshipSchemaName("Invoice_SocialActivities")]
		public IEnumerable<SocialActivity> InvoiceSocialActivities
		{
			get { return GetRelatedEntities<SocialActivity>("Invoice_SocialActivities", null); }
			set { SetRelatedEntities("Invoice_SocialActivities", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'Invoice_SyncErrors'
        /// </summary>
		[RelationshipSchemaName("Invoice_SyncErrors")]
		public IEnumerable<SyncError> InvoiceSyncErrors
		{
			get { return GetRelatedEntities<SyncError>("Invoice_SyncErrors", null); }
			set { SetRelatedEntities("Invoice_SyncErrors", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'Invoice_Tasks'
        /// </summary>
		[RelationshipSchemaName("Invoice_Tasks")]
		public IEnumerable<Task> InvoiceTasks
		{
			get { return GetRelatedEntities<Task>("Invoice_Tasks", null); }
			set { SetRelatedEntities("Invoice_Tasks", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'msdyn_playbookinstance_invoice'
        /// </summary>
		[RelationshipSchemaName("msdyn_playbookinstance_invoice")]
		public IEnumerable<Playbook> MsdynPlaybookinstanceInvoice
		{
			get { return GetRelatedEntities<Playbook>("msdyn_playbookinstance_invoice", null); }
			set { SetRelatedEntities("msdyn_playbookinstance_invoice", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'slakpiinstance_invoice'
        /// </summary>
		[RelationshipSchemaName("slakpiinstance_invoice")]
		public IEnumerable<SLAKPIInstance> SlakpiinstanceInvoice
		{
			get { return GetRelatedEntities<SLAKPIInstance>("slakpiinstance_invoice", null); }
			set { SetRelatedEntities("slakpiinstance_invoice", null, value); }
		}
		/// <summary>
        /// N:N Get entities for 'Contact'
        /// </summary>
		[RelationshipSchemaName("contactinvoices_association")]
		public IEnumerable<Contact> ContactinvoicesAssociation
		{
			get { return GetRelatedEntities<Contact>("contactinvoices_association", null); }
			set { SetRelatedEntities("contactinvoices_association", null, value); }
		}
		#endregion

		#region Actions
		#endregion

		#region OptionSetEnums
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
		
			[Label("Closed (deprecated)")]
			[Description(@"")]
			Closeddeprecated = 1, 
		
			[Label("Paid")]
			[Description(@"")]
			Paid = 2, 
		
			[Label("Canceled")]
			[Description(@"")]
			Canceled = 3, 
		}
		
		public enum eStatusReason
		{	
		
			[Label("New")]
			[Description(@"")]
			New_Active = 1, 
		
			[Label("Partially Shipped")]
			[Description(@"")]
			PartiallyShipped_Active = 2, 
		
			[Label("Billed")]
			[Description(@"")]
			Billed_Active = 4, 
		
			[Label("Booked (applies to services)")]
			[Description(@"")]
			BookedappliesToServices_Active = 5, 
		
			[Label("Installed (applies to services)")]
			[Description(@"")]
			InstalledappliesToServices_Active = 6, 
		
			[Label("Canceled (deprecated)")]
			[Description(@"")]
			Canceleddeprecated_Inactive = 3, 
		
			[Label("Paid in Full (deprecated)")]
			[Description(@"")]
			PaidInFulldeprecated_Inactive = 7, 
		
			[Label("Complete")]
			[Description(@"")]
			Complete = 100001, 
		
			[Label("Partial")]
			[Description(@"")]
			Partial = 100002, 
		
			[Label("Canceled")]
			[Description(@"")]
			Canceled = 100003, 
		}
		
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

			/// <summary>billto_city</summary>
			public const string BillToCity = "billto_city";

			/// <summary>billto_composite</summary>
			public const string BillToAddress = "billto_composite";

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

			/// <summary>datedelivered</summary>
			public const string DateDelivered = "datedelivered";

			/// <summary>description</summary>
			public const string Description = "description";

			/// <summary>discountamount</summary>
			public const string InvoiceDiscountAmount = "discountamount";

			/// <summary>discountpercentage</summary>
			public const string InvoiceDiscount = "discountpercentage";

			/// <summary>duedate</summary>
			public const string DueDate = "duedate";

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

			/// <summary>importsequencenumber</summary>
			public const string ImportSequenceNumber = "importsequencenumber";

			/// <summary>invoiceid</summary>
			public const string InvoiceId = "invoiceid";

			/// <summary>invoicenumber</summary>
			public const string InvoiceID = "invoicenumber";

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

			/// <summary>salesorderid</summary>
			public const string Order = "salesorderid";

			/// <summary>salesorderidname</summary>
			public const string Salesorderidname = "salesorderidname";

			/// <summary>shippingmethodcode</summary>
			public const string ShippingMethod = "shippingmethodcode";

			/// <summary>shipto_city</summary>
			public const string ShipToCity = "shipto_city";

			/// <summary>shipto_composite</summary>
			public const string ShipToAddress = "shipto_composite";

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
			public const string SkipPriceCalculation = "skippricecalculation";

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
			/// <summary>1:N invoice_activity_parties</summary>
			public const string InvoiceActivityParties = "invoice_activity_parties";

			/// <summary>1:N Invoice_ActivityPointers</summary>
			public const string InvoiceActivityPointers = "Invoice_ActivityPointers";

			/// <summary>1:N Invoice_Annotation</summary>
			public const string InvoiceAnnotation = "Invoice_Annotation";

			/// <summary>1:N Invoice_Appointments</summary>
			public const string InvoiceAppointments = "Invoice_Appointments";

			/// <summary>1:N Invoice_AsyncOperations</summary>
			public const string InvoiceAsyncOperations = "Invoice_AsyncOperations";

			/// <summary>1:N Invoice_BulkDeleteFailures</summary>
			public const string InvoiceBulkDeleteFailures = "Invoice_BulkDeleteFailures";

			/// <summary>1:N invoice_connections1</summary>
			public const string InvoiceConnections1 = "invoice_connections1";

			/// <summary>1:N invoice_connections2</summary>
			public const string InvoiceConnections2 = "invoice_connections2";

			/// <summary>1:N invoice_details</summary>
			public const string InvoiceDetails = "invoice_details";

			/// <summary>1:N Invoice_Emails</summary>
			public const string InvoiceEmails = "Invoice_Emails";

			/// <summary>1:N Invoice_Faxes</summary>
			public const string InvoiceFaxes = "Invoice_Faxes";

			/// <summary>1:N Invoice_Letters</summary>
			public const string InvoiceLetters = "Invoice_Letters";

			/// <summary>1:N Invoice_MailboxTrackingFolder</summary>
			public const string InvoiceMailboxTrackingFolder = "Invoice_MailboxTrackingFolder";

			/// <summary>1:N Invoice_Phonecalls</summary>
			public const string InvoicePhonecalls = "Invoice_Phonecalls";

			/// <summary>1:N invoice_principalobjectattributeaccess</summary>
			public const string InvoicePrincipalobjectattributeaccess = "invoice_principalobjectattributeaccess";

			/// <summary>1:N Invoice_ProcessSessions</summary>
			public const string InvoiceProcessSessions = "Invoice_ProcessSessions";

			/// <summary>1:N Invoice_RecurringAppointmentMasters</summary>
			public const string InvoiceRecurringAppointmentMasters = "Invoice_RecurringAppointmentMasters";

			/// <summary>1:N Invoice_ServiceAppointments</summary>
			public const string InvoiceServiceAppointments = "Invoice_ServiceAppointments";

			/// <summary>1:N Invoice_SocialActivities</summary>
			public const string InvoiceSocialActivities = "Invoice_SocialActivities";

			/// <summary>1:N Invoice_SyncErrors</summary>
			public const string InvoiceSyncErrors = "Invoice_SyncErrors";

			/// <summary>1:N Invoice_Tasks</summary>
			public const string InvoiceTasks = "Invoice_Tasks";

			/// <summary>1:N msdyn_playbookinstance_invoice</summary>
			public const string MsdynPlaybookinstanceInvoice = "msdyn_playbookinstance_invoice";

			/// <summary>1:N slakpiinstance_invoice</summary>
			public const string SlakpiinstanceInvoice = "slakpiinstance_invoice";

			/// <summary>N:N contactinvoices_association</summary>
			public const string ContactinvoicesAssociation = "contactinvoices_association";

		}
		#endregion
	}
}

