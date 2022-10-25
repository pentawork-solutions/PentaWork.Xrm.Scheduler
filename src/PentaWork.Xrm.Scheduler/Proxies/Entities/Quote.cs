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
	[EntityLogicalName("quote")]
	public sealed class Quote : Entity
	{	
		public static readonly int? EntityTypeCode = 1084;
		public new const string LogicalName = "quote";
		public const string PrimaryIdAttribute = "quoteid";
		public const string PrimaryNameAttribute = "name";
	
		public Quote() : base("quote") { }

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
        /// closedon
        /// </summary>
		[DisplayName("Closed On")]
		[AttributeLogicalName("closedon")]
		public DateTime? ClosedOn
		{	
			get { return GetAttributeValue<DateTime?>("closedon"); }
			set
			{ 
				if(value == ClosedOn) return;
				SetAttributeValue("closedon", value);
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
		[DisplayName("Potential Customer")]
		[AttributeLogicalName("customerid")]
		public EntityReference PotentialCustomer
		{	
			get { return GetAttributeValue<EntityReference>("customerid"); }
			set
			{ 
				if(value == PotentialCustomer) return;
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
		[DisplayName("Potential Customer Type")]
		[AttributeLogicalName("customeridtype")]
		public string PotentialCustomerType
		{	
			get { return GetAttributeValue<string>("customeridtype"); }
			set
			{ 
				if(value == PotentialCustomerType) return;
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
		[DisplayName("Quote Discount Amount")]
		[AttributeLogicalName("discountamount")]
		public decimal? QuoteDiscountAmount
		{	
			get { return GetAttributeValue<Money>("discountamount")?.Value; }
			set 
			{ 
				if(value == QuoteDiscountAmount) return;

				Money moneyValue = null;
				if(value != null) moneyValue = new Money(value.Value);
				SetAttributeValue("discountamount", moneyValue);  
			}
		}

		/// <summary>
        /// discountpercentage
        /// </summary>
		[DisplayName("Quote Discount (%)")]
		[AttributeLogicalName("discountpercentage")]
		public decimal? QuoteDiscount
		{	
			get { return GetAttributeValue<decimal?>("discountpercentage"); }
			set
			{ 
				if(value == QuoteDiscount) return;
				SetAttributeValue("discountpercentage", value);
			}
		}	
			
		/// <summary>
        /// effectivefrom
        /// </summary>
		[DisplayName("Effective From")]
		[AttributeLogicalName("effectivefrom")]
		public DateTime? EffectiveFrom
		{	
			get { return GetAttributeValue<DateTime?>("effectivefrom"); }
			set
			{ 
				if(value == EffectiveFrom) return;
				SetAttributeValue("effectivefrom", value);
			}
		}	
			
		/// <summary>
        /// effectiveto
        /// </summary>
		[DisplayName("Effective To")]
		[AttributeLogicalName("effectiveto")]
		public DateTime? EffectiveTo
		{	
			get { return GetAttributeValue<DateTime?>("effectiveto"); }
			set
			{ 
				if(value == EffectiveTo) return;
				SetAttributeValue("effectiveto", value);
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
        /// expireson
        /// </summary>
		[DisplayName("Due By")]
		[AttributeLogicalName("expireson")]
		public DateTime? DueBy
		{	
			get { return GetAttributeValue<DateTime?>("expireson"); }
			set
			{ 
				if(value == DueBy) return;
				SetAttributeValue("expireson", value);
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
		public override Guid Id
		{
			get => base.Id;
			set { base.Id = value; SetAttributeValue("quoteid", value); }
		}

							/// <summary>
        /// quotenumber
        /// </summary>
		[DisplayName("Quote ID")]
		[AttributeLogicalName("quotenumber")]
		public string QuoteID
		{	
			get { return GetAttributeValue<string>("quotenumber"); }
			set
			{ 
				if(value == QuoteID) return;
				SetAttributeValue("quotenumber", value);
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
        /// revisionnumber
        /// </summary>
		[DisplayName("Revision ID")]
		[AttributeLogicalName("revisionnumber")]
		public int? RevisionID
		{	
			get { return GetAttributeValue<int?>("revisionnumber"); }
			set
			{ 
				if(value == RevisionID) return;
				SetAttributeValue("revisionnumber", value);
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
        /// uniquedscid
        /// </summary>
		[DisplayName("Unique Dsc ID")]
		[AttributeLogicalName("uniquedscid")]
		public Guid UniqueDscId
		{	
			get { return GetAttributeValue<Guid>("uniquedscid"); }
			set
			{ 
				if(value == UniqueDscId) return;
				SetAttributeValue("uniquedscid", value);
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
        /// 1:N Get entities for 'lk_opportunitysalesprocess_quoteid'
        /// </summary>
		[RelationshipSchemaName("lk_opportunitysalesprocess_quoteid")]
		public IEnumerable<OpportunitySalesProcess> LkOpportunitysalesprocessQuoteid
		{
			get { return GetRelatedEntities<OpportunitySalesProcess>("lk_opportunitysalesprocess_quoteid", null); }
			set { SetRelatedEntities("lk_opportunitysalesprocess_quoteid", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'msdyn_playbookinstance_quote'
        /// </summary>
		[RelationshipSchemaName("msdyn_playbookinstance_quote")]
		public IEnumerable<Playbook> MsdynPlaybookinstanceQuote
		{
			get { return GetRelatedEntities<Playbook>("msdyn_playbookinstance_quote", null); }
			set { SetRelatedEntities("msdyn_playbookinstance_quote", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'quote_activity_parties'
        /// </summary>
		[RelationshipSchemaName("quote_activity_parties")]
		public IEnumerable<ActivityParty> QuoteActivityParties
		{
			get { return GetRelatedEntities<ActivityParty>("quote_activity_parties", null); }
			set { SetRelatedEntities("quote_activity_parties", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'Quote_ActivityPointers'
        /// </summary>
		[RelationshipSchemaName("Quote_ActivityPointers")]
		public IEnumerable<Activity> QuoteActivityPointers
		{
			get { return GetRelatedEntities<Activity>("Quote_ActivityPointers", null); }
			set { SetRelatedEntities("Quote_ActivityPointers", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'Quote_Annotation'
        /// </summary>
		[RelationshipSchemaName("Quote_Annotation")]
		public IEnumerable<Note> QuoteAnnotation
		{
			get { return GetRelatedEntities<Note>("Quote_Annotation", null); }
			set { SetRelatedEntities("Quote_Annotation", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'Quote_Appointments'
        /// </summary>
		[RelationshipSchemaName("Quote_Appointments")]
		public IEnumerable<Appointment> QuoteAppointments
		{
			get { return GetRelatedEntities<Appointment>("Quote_Appointments", null); }
			set { SetRelatedEntities("Quote_Appointments", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'Quote_AsyncOperations'
        /// </summary>
		[RelationshipSchemaName("Quote_AsyncOperations")]
		public IEnumerable<SystemJob> QuoteAsyncOperations
		{
			get { return GetRelatedEntities<SystemJob>("Quote_AsyncOperations", null); }
			set { SetRelatedEntities("Quote_AsyncOperations", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'Quote_BulkDeleteFailures'
        /// </summary>
		[RelationshipSchemaName("Quote_BulkDeleteFailures")]
		public IEnumerable<BulkDeleteFailure> QuoteBulkDeleteFailures
		{
			get { return GetRelatedEntities<BulkDeleteFailure>("Quote_BulkDeleteFailures", null); }
			set { SetRelatedEntities("Quote_BulkDeleteFailures", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'quote_connections1'
        /// </summary>
		[RelationshipSchemaName("quote_connections1")]
		public IEnumerable<Connection> QuoteConnections1
		{
			get { return GetRelatedEntities<Connection>("quote_connections1", null); }
			set { SetRelatedEntities("quote_connections1", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'quote_connections2'
        /// </summary>
		[RelationshipSchemaName("quote_connections2")]
		public IEnumerable<Connection> QuoteConnections2
		{
			get { return GetRelatedEntities<Connection>("quote_connections2", null); }
			set { SetRelatedEntities("quote_connections2", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'quote_details'
        /// </summary>
		[RelationshipSchemaName("quote_details")]
		public IEnumerable<QuoteProduct> QuoteDetails
		{
			get { return GetRelatedEntities<QuoteProduct>("quote_details", null); }
			set { SetRelatedEntities("quote_details", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'Quote_DuplicateBaseRecord'
        /// </summary>
		[RelationshipSchemaName("Quote_DuplicateBaseRecord")]
		public IEnumerable<DuplicateRecord> QuoteDuplicateBaseRecord
		{
			get { return GetRelatedEntities<DuplicateRecord>("Quote_DuplicateBaseRecord", null); }
			set { SetRelatedEntities("Quote_DuplicateBaseRecord", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'Quote_DuplicateMatchingRecord'
        /// </summary>
		[RelationshipSchemaName("Quote_DuplicateMatchingRecord")]
		public IEnumerable<DuplicateRecord> QuoteDuplicateMatchingRecord
		{
			get { return GetRelatedEntities<DuplicateRecord>("Quote_DuplicateMatchingRecord", null); }
			set { SetRelatedEntities("Quote_DuplicateMatchingRecord", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'Quote_Emails'
        /// </summary>
		[RelationshipSchemaName("Quote_Emails")]
		public IEnumerable<Email> QuoteEmails
		{
			get { return GetRelatedEntities<Email>("Quote_Emails", null); }
			set { SetRelatedEntities("Quote_Emails", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'Quote_Faxes'
        /// </summary>
		[RelationshipSchemaName("Quote_Faxes")]
		public IEnumerable<Fax> QuoteFaxes
		{
			get { return GetRelatedEntities<Fax>("Quote_Faxes", null); }
			set { SetRelatedEntities("Quote_Faxes", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'Quote_Letters'
        /// </summary>
		[RelationshipSchemaName("Quote_Letters")]
		public IEnumerable<Letter> QuoteLetters
		{
			get { return GetRelatedEntities<Letter>("Quote_Letters", null); }
			set { SetRelatedEntities("Quote_Letters", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'Quote_MailboxTrackingFolder'
        /// </summary>
		[RelationshipSchemaName("Quote_MailboxTrackingFolder")]
		public IEnumerable<MailboxAutoTrackingFolder> QuoteMailboxTrackingFolder
		{
			get { return GetRelatedEntities<MailboxAutoTrackingFolder>("Quote_MailboxTrackingFolder", null); }
			set { SetRelatedEntities("Quote_MailboxTrackingFolder", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'quote_orders'
        /// </summary>
		[RelationshipSchemaName("quote_orders")]
		public IEnumerable<Order> QuoteOrders
		{
			get { return GetRelatedEntities<Order>("quote_orders", null); }
			set { SetRelatedEntities("quote_orders", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'Quote_Phonecalls'
        /// </summary>
		[RelationshipSchemaName("Quote_Phonecalls")]
		public IEnumerable<PhoneCall> QuotePhonecalls
		{
			get { return GetRelatedEntities<PhoneCall>("Quote_Phonecalls", null); }
			set { SetRelatedEntities("Quote_Phonecalls", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'quote_principalobjectattributeaccess'
        /// </summary>
		[RelationshipSchemaName("quote_principalobjectattributeaccess")]
		public IEnumerable<FieldSharing> QuotePrincipalobjectattributeaccess
		{
			get { return GetRelatedEntities<FieldSharing>("quote_principalobjectattributeaccess", null); }
			set { SetRelatedEntities("quote_principalobjectattributeaccess", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'Quote_ProcessSessions'
        /// </summary>
		[RelationshipSchemaName("Quote_ProcessSessions")]
		public IEnumerable<ProcessSession> QuoteProcessSessions
		{
			get { return GetRelatedEntities<ProcessSession>("Quote_ProcessSessions", null); }
			set { SetRelatedEntities("Quote_ProcessSessions", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'Quote_QuoteClose'
        /// </summary>
		[RelationshipSchemaName("Quote_QuoteClose")]
		public IEnumerable<QuoteClose> QuoteQuoteClose
		{
			get { return GetRelatedEntities<QuoteClose>("Quote_QuoteClose", null); }
			set { SetRelatedEntities("Quote_QuoteClose", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'quote_QuoteCloses'
        /// </summary>
		[RelationshipSchemaName("quote_QuoteCloses")]
		public IEnumerable<QuoteClose> QuoteQuoteCloses
		{
			get { return GetRelatedEntities<QuoteClose>("quote_QuoteCloses", null); }
			set { SetRelatedEntities("quote_QuoteCloses", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'Quote_RecurringAppointmentMasters'
        /// </summary>
		[RelationshipSchemaName("Quote_RecurringAppointmentMasters")]
		public IEnumerable<RecurringAppointment> QuoteRecurringAppointmentMasters
		{
			get { return GetRelatedEntities<RecurringAppointment>("Quote_RecurringAppointmentMasters", null); }
			set { SetRelatedEntities("Quote_RecurringAppointmentMasters", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'Quote_ServiceAppointments'
        /// </summary>
		[RelationshipSchemaName("Quote_ServiceAppointments")]
		public IEnumerable<ServiceActivity> QuoteServiceAppointments
		{
			get { return GetRelatedEntities<ServiceActivity>("Quote_ServiceAppointments", null); }
			set { SetRelatedEntities("Quote_ServiceAppointments", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'Quote_SharepointDocumentLocation'
        /// </summary>
		[RelationshipSchemaName("Quote_SharepointDocumentLocation")]
		public IEnumerable<DocumentLocation> QuoteSharepointDocumentLocation
		{
			get { return GetRelatedEntities<DocumentLocation>("Quote_SharepointDocumentLocation", null); }
			set { SetRelatedEntities("Quote_SharepointDocumentLocation", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'Quote_SocialActivities'
        /// </summary>
		[RelationshipSchemaName("Quote_SocialActivities")]
		public IEnumerable<SocialActivity> QuoteSocialActivities
		{
			get { return GetRelatedEntities<SocialActivity>("Quote_SocialActivities", null); }
			set { SetRelatedEntities("Quote_SocialActivities", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'Quote_SyncErrors'
        /// </summary>
		[RelationshipSchemaName("Quote_SyncErrors")]
		public IEnumerable<SyncError> QuoteSyncErrors
		{
			get { return GetRelatedEntities<SyncError>("Quote_SyncErrors", null); }
			set { SetRelatedEntities("Quote_SyncErrors", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'Quote_Tasks'
        /// </summary>
		[RelationshipSchemaName("Quote_Tasks")]
		public IEnumerable<Task> QuoteTasks
		{
			get { return GetRelatedEntities<Task>("Quote_Tasks", null); }
			set { SetRelatedEntities("Quote_Tasks", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'slakpiinstance_quote'
        /// </summary>
		[RelationshipSchemaName("slakpiinstance_quote")]
		public IEnumerable<SLAKPIInstance> SlakpiinstanceQuote
		{
			get { return GetRelatedEntities<SLAKPIInstance>("slakpiinstance_quote", null); }
			set { SetRelatedEntities("slakpiinstance_quote", null, value); }
		}
		/// <summary>
        /// N:N Get entities for 'Contact'
        /// </summary>
		[RelationshipSchemaName("contactquotes_association")]
		public IEnumerable<Contact> ContactquotesAssociation
		{
			get { return GetRelatedEntities<Contact>("contactquotes_association", null); }
			set { SetRelatedEntities("contactquotes_association", null, value); }
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
		
			[Label("Draft")]
			[Description(@"")]
			Draft = 0, 
		
			[Label("Active")]
			[Description(@"")]
			Active = 1, 
		
			[Label("Won")]
			[Description(@"")]
			Won = 2, 
		
			[Label("Closed")]
			[Description(@"")]
			Closed = 3, 
		}
		
		public enum eStatusReason
		{	
		
			[Label("In Progress")]
			[Description(@"")]
			InProgress_Inactive = 2, 
		
			[Label("Open")]
			[Description(@"")]
			Open_Inactive = 3, 
		
			[Label("Won")]
			[Description(@"")]
			Won = 4, 
		
			[Label("Lost")]
			[Description(@"")]
			Lost = 5, 
		
			[Label("Canceled")]
			[Description(@"")]
			Canceled = 6, 
		
			[Label("Revised")]
			[Description(@"")]
			Revised = 7, 
		
			[Label("In Progress")]
			[Description(@"")]
			InProgress_Active = 1, 
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

			/// <summary>closedon</summary>
			public const string ClosedOn = "closedon";

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
			public const string PotentialCustomer = "customerid";

			/// <summary>customeridname</summary>
			public const string Customeridname = "customeridname";

			/// <summary>customeridtype</summary>
			public const string PotentialCustomerType = "customeridtype";

			/// <summary>customeridyominame</summary>
			public const string Customeridyominame = "customeridyominame";

			/// <summary>description</summary>
			public const string Description = "description";

			/// <summary>discountamount</summary>
			public const string QuoteDiscountAmount = "discountamount";

			/// <summary>discountpercentage</summary>
			public const string QuoteDiscount = "discountpercentage";

			/// <summary>effectivefrom</summary>
			public const string EffectiveFrom = "effectivefrom";

			/// <summary>effectiveto</summary>
			public const string EffectiveTo = "effectiveto";

			/// <summary>emailaddress</summary>
			public const string EmailAddress = "emailaddress";

			/// <summary>exchangerate</summary>
			public const string ExchangeRate = "exchangerate";

			/// <summary>expireson</summary>
			public const string DueBy = "expireson";

			/// <summary>freightamount</summary>
			public const string FreightAmount = "freightamount";

			/// <summary>freighttermscode</summary>
			public const string FreightTerms = "freighttermscode";

			/// <summary>importsequencenumber</summary>
			public const string ImportSequenceNumber = "importsequencenumber";

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

			/// <summary>processid</summary>
			public const string ProcessId = "processid";

			/// <summary>quoteid</summary>
			public const string QuoteId = "quoteid";

			/// <summary>quotenumber</summary>
			public const string QuoteID = "quotenumber";

			/// <summary>requestdeliveryby</summary>
			public const string RequestedDeliveryDate = "requestdeliveryby";

			/// <summary>revisionnumber</summary>
			public const string RevisionID = "revisionnumber";

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

			/// <summary>uniquedscid</summary>
			public const string UniqueDscId = "uniquedscid";

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
			/// <summary>1:N lk_opportunitysalesprocess_quoteid</summary>
			public const string LkOpportunitysalesprocessQuoteid = "lk_opportunitysalesprocess_quoteid";

			/// <summary>1:N msdyn_playbookinstance_quote</summary>
			public const string MsdynPlaybookinstanceQuote = "msdyn_playbookinstance_quote";

			/// <summary>1:N quote_activity_parties</summary>
			public const string QuoteActivityParties = "quote_activity_parties";

			/// <summary>1:N Quote_ActivityPointers</summary>
			public const string QuoteActivityPointers = "Quote_ActivityPointers";

			/// <summary>1:N Quote_Annotation</summary>
			public const string QuoteAnnotation = "Quote_Annotation";

			/// <summary>1:N Quote_Appointments</summary>
			public const string QuoteAppointments = "Quote_Appointments";

			/// <summary>1:N Quote_AsyncOperations</summary>
			public const string QuoteAsyncOperations = "Quote_AsyncOperations";

			/// <summary>1:N Quote_BulkDeleteFailures</summary>
			public const string QuoteBulkDeleteFailures = "Quote_BulkDeleteFailures";

			/// <summary>1:N quote_connections1</summary>
			public const string QuoteConnections1 = "quote_connections1";

			/// <summary>1:N quote_connections2</summary>
			public const string QuoteConnections2 = "quote_connections2";

			/// <summary>1:N quote_details</summary>
			public const string QuoteDetails = "quote_details";

			/// <summary>1:N Quote_DuplicateBaseRecord</summary>
			public const string QuoteDuplicateBaseRecord = "Quote_DuplicateBaseRecord";

			/// <summary>1:N Quote_DuplicateMatchingRecord</summary>
			public const string QuoteDuplicateMatchingRecord = "Quote_DuplicateMatchingRecord";

			/// <summary>1:N Quote_Emails</summary>
			public const string QuoteEmails = "Quote_Emails";

			/// <summary>1:N Quote_Faxes</summary>
			public const string QuoteFaxes = "Quote_Faxes";

			/// <summary>1:N Quote_Letters</summary>
			public const string QuoteLetters = "Quote_Letters";

			/// <summary>1:N Quote_MailboxTrackingFolder</summary>
			public const string QuoteMailboxTrackingFolder = "Quote_MailboxTrackingFolder";

			/// <summary>1:N quote_orders</summary>
			public const string QuoteOrders = "quote_orders";

			/// <summary>1:N Quote_Phonecalls</summary>
			public const string QuotePhonecalls = "Quote_Phonecalls";

			/// <summary>1:N quote_principalobjectattributeaccess</summary>
			public const string QuotePrincipalobjectattributeaccess = "quote_principalobjectattributeaccess";

			/// <summary>1:N Quote_ProcessSessions</summary>
			public const string QuoteProcessSessions = "Quote_ProcessSessions";

			/// <summary>1:N Quote_QuoteClose</summary>
			public const string QuoteQuoteClose = "Quote_QuoteClose";

			/// <summary>1:N quote_QuoteCloses</summary>
			public const string QuoteQuoteCloses = "quote_QuoteCloses";

			/// <summary>1:N Quote_RecurringAppointmentMasters</summary>
			public const string QuoteRecurringAppointmentMasters = "Quote_RecurringAppointmentMasters";

			/// <summary>1:N Quote_ServiceAppointments</summary>
			public const string QuoteServiceAppointments = "Quote_ServiceAppointments";

			/// <summary>1:N Quote_SharepointDocumentLocation</summary>
			public const string QuoteSharepointDocumentLocation = "Quote_SharepointDocumentLocation";

			/// <summary>1:N Quote_SocialActivities</summary>
			public const string QuoteSocialActivities = "Quote_SocialActivities";

			/// <summary>1:N Quote_SyncErrors</summary>
			public const string QuoteSyncErrors = "Quote_SyncErrors";

			/// <summary>1:N Quote_Tasks</summary>
			public const string QuoteTasks = "Quote_Tasks";

			/// <summary>1:N slakpiinstance_quote</summary>
			public const string SlakpiinstanceQuote = "slakpiinstance_quote";

			/// <summary>N:N contactquotes_association</summary>
			public const string ContactquotesAssociation = "contactquotes_association";

		}
		#endregion
	}
}

