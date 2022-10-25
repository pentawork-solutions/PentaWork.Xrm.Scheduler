using System;
using System.Linq;
using System.Diagnostics;
using System.ComponentModel;
using Microsoft.Xrm.Sdk; 
using Microsoft.Xrm.Sdk.Client;
using System.Collections.Generic;

namespace PentaWork.Xrm.Scheduler.Proxies.Entities
{
	[DebuggerDisplay("{Title}")] 	
	[EntityLogicalName("contractdetail")]
	public sealed class ContractLine : Entity
	{	
		public static readonly int? EntityTypeCode = 1011;
		public new const string LogicalName = "contractdetail";
		public const string PrimaryIdAttribute = "contractdetailid";
		public const string PrimaryNameAttribute = "title";
	
		public ContractLine() : base("contractdetail") { }

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
        /// activeon
        /// </summary>
		[DisplayName("Start Date")]
		[AttributeLogicalName("activeon")]
		public DateTime? StartDate
		{	
			get { return GetAttributeValue<DateTime?>("activeon"); }
			set
			{ 
				if(value == StartDate) return;
				SetAttributeValue("activeon", value);
			}
		}	
			
		/// <summary>
        /// allotmentsoverage
        /// </summary>
		[DisplayName("Allotments Overage")]
		[AttributeLogicalName("allotmentsoverage")]
		public int? AllotmentsOverage
		{	
			get { return GetAttributeValue<int?>("allotmentsoverage"); }
			set
			{ 
				if(value == AllotmentsOverage) return;
				SetAttributeValue("allotmentsoverage", value);
			}
		}	
			
		/// <summary>
        /// allotmentsremaining
        /// </summary>
		[DisplayName("Allotments Remaining")]
		[AttributeLogicalName("allotmentsremaining")]
		public int? AllotmentsRemaining
		{	
			get { return GetAttributeValue<int?>("allotmentsremaining"); }
			set
			{ 
				if(value == AllotmentsRemaining) return;
				SetAttributeValue("allotmentsremaining", value);
			}
		}	
			
		/// <summary>
        /// allotmentsused
        /// </summary>
		[DisplayName("Allotments Used")]
		[AttributeLogicalName("allotmentsused")]
		public int? AllotmentsUsed
		{	
			get { return GetAttributeValue<int?>("allotmentsused"); }
			set
			{ 
				if(value == AllotmentsUsed) return;
				SetAttributeValue("allotmentsused", value);
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
        /// contractdetailid
        /// </summary>
		[DisplayName("Contract Line")]
		[AttributeLogicalName("contractdetailid")]
		public override Guid Id
		{
			get => base.Id;
			set { base.Id = value; SetAttributeValue("contractdetailid", value); }
		}

							/// <summary>
        /// contractid
        /// </summary>
		[DisplayName("Contract")]
		[AttributeLogicalName("contractid")]
		public EntityReference Contract
		{	
			get { return GetAttributeValue<EntityReference>("contractid"); }
			set
			{ 
				if(value == Contract) return;
				SetAttributeValue("contractid", value);
			}
		}	
			
		/// <summary>
        /// contractidname
        /// </summary>
		[DisplayName("contractidname")]
		[AttributeLogicalName("contractidname")]
		public string Contractidname
		{	
			get { return GetAttributeValue<string>("contractidname"); }
			set
			{ 
				if(value == Contractidname) return;
				SetAttributeValue("contractidname", value);
			}
		}	
			
		/// <summary>
        /// contractstatecode
        /// </summary>
		[DisplayName("Contract State")]
		[AttributeLogicalName("contractstatecode")]
		public eContractState? ContractState
		{	
			get 
			{ 
				var optionSetValue = GetAttributeValue<OptionSetValue>("contractstatecode");
				if (optionSetValue != null) return (eContractState)optionSetValue.Value;
				else return null;
			}
			set 
			{ 
				if(value == ContractState) return;

				OptionSetValue optionSetValue = null;
				if(value != null) optionSetValue = new OptionSetValue((int)value);
				SetAttributeValue("contractstatecode", optionSetValue); 
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
        /// discount
        /// </summary>
		[DisplayName("Discount")]
		[AttributeLogicalName("discount")]
		public decimal? Discount
		{	
			get { return GetAttributeValue<Money>("discount")?.Value; }
			set 
			{ 
				if(value == Discount) return;

				Money moneyValue = null;
				if(value != null) moneyValue = new Money(value.Value);
				SetAttributeValue("discount", moneyValue);  
			}
		}

		/// <summary>
        /// discountpercentage
        /// </summary>
		[DisplayName("Discount (%)")]
		[AttributeLogicalName("discountpercentage")]
		public decimal? Discount2
		{	
			get { return GetAttributeValue<decimal?>("discountpercentage"); }
			set
			{ 
				if(value == Discount2) return;
				SetAttributeValue("discountpercentage", value);
			}
		}	
			
		/// <summary>
        /// effectivitycalendar
        /// </summary>
		[DisplayName("Support Calendar")]
		[AttributeLogicalName("effectivitycalendar")]
		public string SupportCalendar
		{	
			get { return GetAttributeValue<string>("effectivitycalendar"); }
			set
			{ 
				if(value == SupportCalendar) return;
				SetAttributeValue("effectivitycalendar", value);
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
		[DisplayName("End Date")]
		[AttributeLogicalName("expireson")]
		public DateTime? EndDate
		{	
			get { return GetAttributeValue<DateTime?>("expireson"); }
			set
			{ 
				if(value == EndDate) return;
				SetAttributeValue("expireson", value);
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
        /// initialquantity
        /// </summary>
		[DisplayName("Quantity")]
		[AttributeLogicalName("initialquantity")]
		public int? Quantity
		{	
			get { return GetAttributeValue<int?>("initialquantity"); }
			set
			{ 
				if(value == Quantity) return;
				SetAttributeValue("initialquantity", value);
			}
		}	
			
		/// <summary>
        /// lineitemorder
        /// </summary>
		[DisplayName("Line Item Order")]
		[AttributeLogicalName("lineitemorder")]
		public int? LineItemOrder
		{	
			get { return GetAttributeValue<int?>("lineitemorder"); }
			set
			{ 
				if(value == LineItemOrder) return;
				SetAttributeValue("lineitemorder", value);
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
        /// net
        /// </summary>
		[DisplayName("Net")]
		[AttributeLogicalName("net")]
		public decimal? Net
		{	
			get { return GetAttributeValue<Money>("net")?.Value; }
			set 
			{ 
				if(value == Net) return;

				Money moneyValue = null;
				if(value != null) moneyValue = new Money(value.Value);
				SetAttributeValue("net", moneyValue);  
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
        /// price
        /// </summary>
		[DisplayName("Total Price")]
		[AttributeLogicalName("price")]
		public decimal? TotalPrice
		{	
			get { return GetAttributeValue<Money>("price")?.Value; }
			set 
			{ 
				if(value == TotalPrice) return;

				Money moneyValue = null;
				if(value != null) moneyValue = new Money(value.Value);
				SetAttributeValue("price", moneyValue);  
			}
		}

		/// <summary>
        /// productid
        /// </summary>
		[DisplayName("Product")]
		[AttributeLogicalName("productid")]
		public EntityReference Product
		{	
			get { return GetAttributeValue<EntityReference>("productid"); }
			set
			{ 
				if(value == Product) return;
				SetAttributeValue("productid", value);
			}
		}	
			
		/// <summary>
        /// productidname
        /// </summary>
		[DisplayName("productidname")]
		[AttributeLogicalName("productidname")]
		public string Productidname
		{	
			get { return GetAttributeValue<string>("productidname"); }
			set
			{ 
				if(value == Productidname) return;
				SetAttributeValue("productidname", value);
			}
		}	
			
		/// <summary>
        /// productserialnumber
        /// </summary>
		[DisplayName("Serial Number")]
		[AttributeLogicalName("productserialnumber")]
		public string SerialNumber
		{	
			get { return GetAttributeValue<string>("productserialnumber"); }
			set
			{ 
				if(value == SerialNumber) return;
				SetAttributeValue("productserialnumber", value);
			}
		}	
			
		/// <summary>
        /// rate
        /// </summary>
		[DisplayName("Rate")]
		[AttributeLogicalName("rate")]
		public decimal? Rate
		{	
			get { return GetAttributeValue<Money>("rate")?.Value; }
			set 
			{ 
				if(value == Rate) return;

				Money moneyValue = null;
				if(value != null) moneyValue = new Money(value.Value);
				SetAttributeValue("rate", moneyValue);  
			}
		}

		/// <summary>
        /// serviceaddress
        /// </summary>
		[DisplayName("Location")]
		[AttributeLogicalName("serviceaddress")]
		public EntityReference Location
		{	
			get { return GetAttributeValue<EntityReference>("serviceaddress"); }
			set
			{ 
				if(value == Location) return;
				SetAttributeValue("serviceaddress", value);
			}
		}	
			
		/// <summary>
        /// serviceaddressname
        /// </summary>
		[DisplayName("serviceaddressname")]
		[AttributeLogicalName("serviceaddressname")]
		public string Serviceaddressname
		{	
			get { return GetAttributeValue<string>("serviceaddressname"); }
			set
			{ 
				if(value == Serviceaddressname) return;
				SetAttributeValue("serviceaddressname", value);
			}
		}	
			
		/// <summary>
        /// servicecontractunitscode
        /// </summary>
		[DisplayName("Service Contract Units")]
		[AttributeLogicalName("servicecontractunitscode")]
		public eServiceContractUnits? ServiceContractUnits
		{	
			get 
			{ 
				var optionSetValue = GetAttributeValue<OptionSetValue>("servicecontractunitscode");
				if (optionSetValue != null) return (eServiceContractUnits)optionSetValue.Value;
				else return null;
			}
			set 
			{ 
				if(value == ServiceContractUnits) return;

				OptionSetValue optionSetValue = null;
				if(value != null) optionSetValue = new OptionSetValue((int)value);
				SetAttributeValue("servicecontractunitscode", optionSetValue); 
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
        /// totalallotments
        /// </summary>
		[DisplayName("Total Allotments")]
		[AttributeLogicalName("totalallotments")]
		public int? TotalAllotments
		{	
			get { return GetAttributeValue<int?>("totalallotments"); }
			set
			{ 
				if(value == TotalAllotments) return;
				SetAttributeValue("totalallotments", value);
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
        /// uomid
        /// </summary>
		[DisplayName("Unit")]
		[AttributeLogicalName("uomid")]
		public EntityReference Unit
		{	
			get { return GetAttributeValue<EntityReference>("uomid"); }
			set
			{ 
				if(value == Unit) return;
				SetAttributeValue("uomid", value);
			}
		}	
			
		/// <summary>
        /// uomidname
        /// </summary>
		[DisplayName("uomidname")]
		[AttributeLogicalName("uomidname")]
		public string Uomidname
		{	
			get { return GetAttributeValue<string>("uomidname"); }
			set
			{ 
				if(value == Uomidname) return;
				SetAttributeValue("uomidname", value);
			}
		}	
			
		/// <summary>
        /// uomscheduleid
        /// </summary>
		[DisplayName("Unit Schedule")]
		[AttributeLogicalName("uomscheduleid")]
		public EntityReference UnitSchedule
		{	
			get { return GetAttributeValue<EntityReference>("uomscheduleid"); }
			set
			{ 
				if(value == UnitSchedule) return;
				SetAttributeValue("uomscheduleid", value);
			}
		}	
			
		/// <summary>
        /// uomscheduleidname
        /// </summary>
		[DisplayName("uomscheduleidname")]
		[AttributeLogicalName("uomscheduleidname")]
		public string Uomscheduleidname
		{	
			get { return GetAttributeValue<string>("uomscheduleidname"); }
			set
			{ 
				if(value == Uomscheduleidname) return;
				SetAttributeValue("uomscheduleidname", value);
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
        /// 1:N Get entities for 'contract_detail_cases'
        /// </summary>
		[RelationshipSchemaName("contract_detail_cases")]
		public IEnumerable<Case> ContractDetailCases
		{
			get { return GetRelatedEntities<Case>("contract_detail_cases", null); }
			set { SetRelatedEntities("contract_detail_cases", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'ContractDetail_Annotation'
        /// </summary>
		[RelationshipSchemaName("ContractDetail_Annotation")]
		public IEnumerable<Note> ContractDetailAnnotation
		{
			get { return GetRelatedEntities<Note>("ContractDetail_Annotation", null); }
			set { SetRelatedEntities("ContractDetail_Annotation", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'ContractDetail_AsyncOperations'
        /// </summary>
		[RelationshipSchemaName("ContractDetail_AsyncOperations")]
		public IEnumerable<SystemJob> ContractDetailAsyncOperations
		{
			get { return GetRelatedEntities<SystemJob>("ContractDetail_AsyncOperations", null); }
			set { SetRelatedEntities("ContractDetail_AsyncOperations", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'ContractDetail_BulkDeleteFailures'
        /// </summary>
		[RelationshipSchemaName("ContractDetail_BulkDeleteFailures")]
		public IEnumerable<BulkDeleteFailure> ContractDetailBulkDeleteFailures
		{
			get { return GetRelatedEntities<BulkDeleteFailure>("ContractDetail_BulkDeleteFailures", null); }
			set { SetRelatedEntities("ContractDetail_BulkDeleteFailures", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'contractdetail_MailboxTrackingFolders'
        /// </summary>
		[RelationshipSchemaName("contractdetail_MailboxTrackingFolders")]
		public IEnumerable<MailboxAutoTrackingFolder> ContractdetailMailboxTrackingFolders
		{
			get { return GetRelatedEntities<MailboxAutoTrackingFolder>("contractdetail_MailboxTrackingFolders", null); }
			set { SetRelatedEntities("contractdetail_MailboxTrackingFolders", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'contractdetail_principalobjectattributeaccess'
        /// </summary>
		[RelationshipSchemaName("contractdetail_principalobjectattributeaccess")]
		public IEnumerable<FieldSharing> ContractdetailPrincipalobjectattributeaccess
		{
			get { return GetRelatedEntities<FieldSharing>("contractdetail_principalobjectattributeaccess", null); }
			set { SetRelatedEntities("contractdetail_principalobjectattributeaccess", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'ContractDetail_ProcessSessions'
        /// </summary>
		[RelationshipSchemaName("ContractDetail_ProcessSessions")]
		public IEnumerable<ProcessSession> ContractDetailProcessSessions
		{
			get { return GetRelatedEntities<ProcessSession>("ContractDetail_ProcessSessions", null); }
			set { SetRelatedEntities("ContractDetail_ProcessSessions", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'ContractDetail_SyncErrors'
        /// </summary>
		[RelationshipSchemaName("ContractDetail_SyncErrors")]
		public IEnumerable<SyncError> ContractDetailSyncErrors
		{
			get { return GetRelatedEntities<SyncError>("ContractDetail_SyncErrors", null); }
			set { SetRelatedEntities("ContractDetail_SyncErrors", null, value); }
		}
		#endregion

		#region Actions
		#endregion

		#region OptionSetEnums
		public enum eContractState
		{	
		}
		
		public enum eServiceContractUnits
		{	
		
			[Label("Default Value")]
			[Description(@"")]
			DefaultValue = 1, 
		}
		
		public enum eStatus
		{	
		
			[Label("Existing")]
			[Description(@"")]
			Existing = 0, 
		
			[Label("Renewed")]
			[Description(@"")]
			Renewed = 1, 
		
			[Label("Canceled")]
			[Description(@"")]
			Canceled = 2, 
		
			[Label("Expired")]
			[Description(@"")]
			Expired = 3, 
		}
		
		public enum eStatusReason
		{	
		
			[Label("New")]
			[Description(@"")]
			New_Active = 1, 
		
			[Label("Renewed")]
			[Description(@"")]
			Renewed_Inactive = 2, 
		
			[Label("Canceled")]
			[Description(@"")]
			Canceled = 3, 
		
			[Label("Expired")]
			[Description(@"")]
			Expired = 4, 
		}
		
		#endregion	

		#region Properties
		public static class Properties 
		{
			/// <summary>accountid</summary>
			public const string Account = "accountid";

			/// <summary>activeon</summary>
			public const string StartDate = "activeon";

			/// <summary>allotmentsoverage</summary>
			public const string AllotmentsOverage = "allotmentsoverage";

			/// <summary>allotmentsremaining</summary>
			public const string AllotmentsRemaining = "allotmentsremaining";

			/// <summary>allotmentsused</summary>
			public const string AllotmentsUsed = "allotmentsused";

			/// <summary>contactid</summary>
			public const string Contact = "contactid";

			/// <summary>contractdetailid</summary>
			public const string ContractLineId = "contractdetailid";

			/// <summary>contractid</summary>
			public const string Contract = "contractid";

			/// <summary>contractidname</summary>
			public const string Contractidname = "contractidname";

			/// <summary>contractstatecode</summary>
			public const string ContractState = "contractstatecode";

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

			/// <summary>discount</summary>
			public const string Discount = "discount";

			/// <summary>discountpercentage</summary>
			public const string Discount2 = "discountpercentage";

			/// <summary>effectivitycalendar</summary>
			public const string SupportCalendar = "effectivitycalendar";

			/// <summary>exchangerate</summary>
			public const string ExchangeRate = "exchangerate";

			/// <summary>expireson</summary>
			public const string EndDate = "expireson";

			/// <summary>importsequencenumber</summary>
			public const string ImportSequenceNumber = "importsequencenumber";

			/// <summary>initialquantity</summary>
			public const string Quantity = "initialquantity";

			/// <summary>lineitemorder</summary>
			public const string LineItemOrder = "lineitemorder";

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

			/// <summary>net</summary>
			public const string Net = "net";

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

			/// <summary>price</summary>
			public const string TotalPrice = "price";

			/// <summary>productid</summary>
			public const string Product = "productid";

			/// <summary>productidname</summary>
			public const string Productidname = "productidname";

			/// <summary>productserialnumber</summary>
			public const string SerialNumber = "productserialnumber";

			/// <summary>rate</summary>
			public const string Rate = "rate";

			/// <summary>serviceaddress</summary>
			public const string Location = "serviceaddress";

			/// <summary>serviceaddressname</summary>
			public const string Serviceaddressname = "serviceaddressname";

			/// <summary>servicecontractunitscode</summary>
			public const string ServiceContractUnits = "servicecontractunitscode";

			/// <summary>statecode</summary>
			public const string Status = "statecode";

			/// <summary>statuscode</summary>
			public const string StatusReason = "statuscode";

			/// <summary>timezoneruleversionnumber</summary>
			public const string TimeZoneRuleVersionNumber = "timezoneruleversionnumber";

			/// <summary>title</summary>
			public const string Title = "title";

			/// <summary>totalallotments</summary>
			public const string TotalAllotments = "totalallotments";

			/// <summary>transactioncurrencyid</summary>
			public const string Currency = "transactioncurrencyid";

			/// <summary>transactioncurrencyidname</summary>
			public const string Transactioncurrencyidname = "transactioncurrencyidname";

			/// <summary>uomid</summary>
			public const string Unit = "uomid";

			/// <summary>uomidname</summary>
			public const string Uomidname = "uomidname";

			/// <summary>uomscheduleid</summary>
			public const string UnitSchedule = "uomscheduleid";

			/// <summary>uomscheduleidname</summary>
			public const string Uomscheduleidname = "uomscheduleidname";

			/// <summary>utcconversiontimezonecode</summary>
			public const string UTCConversionTimeZoneCode = "utcconversiontimezonecode";

			/// <summary>versionnumber</summary>
			public const string VersionNumber = "versionnumber";

		}
		#endregion

		#region Schemas
		public static class Schemas 
		{
			/// <summary>1:N contract_detail_cases</summary>
			public const string ContractDetailCases = "contract_detail_cases";

			/// <summary>1:N ContractDetail_Annotation</summary>
			public const string ContractDetailAnnotation = "ContractDetail_Annotation";

			/// <summary>1:N ContractDetail_AsyncOperations</summary>
			public const string ContractDetailAsyncOperations = "ContractDetail_AsyncOperations";

			/// <summary>1:N ContractDetail_BulkDeleteFailures</summary>
			public const string ContractDetailBulkDeleteFailures = "ContractDetail_BulkDeleteFailures";

			/// <summary>1:N contractdetail_MailboxTrackingFolders</summary>
			public const string ContractdetailMailboxTrackingFolders = "contractdetail_MailboxTrackingFolders";

			/// <summary>1:N contractdetail_principalobjectattributeaccess</summary>
			public const string ContractdetailPrincipalobjectattributeaccess = "contractdetail_principalobjectattributeaccess";

			/// <summary>1:N ContractDetail_ProcessSessions</summary>
			public const string ContractDetailProcessSessions = "ContractDetail_ProcessSessions";

			/// <summary>1:N ContractDetail_SyncErrors</summary>
			public const string ContractDetailSyncErrors = "ContractDetail_SyncErrors";

		}
		#endregion
	}
}

