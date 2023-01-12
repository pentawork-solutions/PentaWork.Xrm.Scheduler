using System;
using System.Linq;
using System.Diagnostics;
using System.ComponentModel;
using Microsoft.Xrm.Sdk; 
using Microsoft.Xrm.Sdk.Client;
using System.Collections.Generic;

namespace PentaWork.Xrm.Scheduler.Proxies.Entities
{
	[DebuggerDisplay("{ContractName}")] 	
	[EntityLogicalName("contract")]
	public sealed class Contract : Entity
	{	
		public static readonly int? EntityTypeCode = 1010;
		public new const string LogicalName = "contract";
		public const string PrimaryIdAttribute = "contractid";
		public const string PrimaryNameAttribute = "title";
	
		public Contract() : base("contract") { }

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
        /// activeon
        /// </summary>
		[DisplayName("Contract Start Date")]
		[AttributeLogicalName("activeon")]
		public DateTime? ContractStartDate
		{	
			get { return GetAttributeValue<DateTime?>("activeon"); }
			set
			{ 
				if(value == ContractStartDate) return;
				SetAttributeValue("activeon", value);
			}
		}	
			
		/// <summary>
        /// allotmenttypecode
        /// </summary>
		[DisplayName("Allotment Type")]
		[AttributeLogicalName("allotmenttypecode")]
		public eAllotmentType? AllotmentType
		{	
			get 
			{ 
				var optionSetValue = GetAttributeValue<OptionSetValue>("allotmenttypecode");
				if (optionSetValue != null) return (eAllotmentType)optionSetValue.Value;
				else return null;
			}
			set 
			{ 
				if(value == AllotmentType) return;

				OptionSetValue optionSetValue = null;
				if(value != null) optionSetValue = new OptionSetValue((int)value);
				SetAttributeValue("allotmenttypecode", optionSetValue); 
			}
		}

		/// <summary>
        /// billingaccountid
        /// </summary>
		[DisplayName("Billing Account")]
		[AttributeLogicalName("billingaccountid")]
		public EntityReference BillingAccount
		{	
			get { return GetAttributeValue<EntityReference>("billingaccountid"); }
			set
			{ 
				if(value == BillingAccount) return;
				SetAttributeValue("billingaccountid", value);
			}
		}	
			
		/// <summary>
        /// billingaccountidname
        /// </summary>
		[DisplayName("billingaccountidname")]
		[AttributeLogicalName("billingaccountidname")]
		public string Billingaccountidname
		{	
			get { return GetAttributeValue<string>("billingaccountidname"); }
			set
			{ 
				if(value == Billingaccountidname) return;
				SetAttributeValue("billingaccountidname", value);
			}
		}	
			
		/// <summary>
        /// billingaccountidyominame
        /// </summary>
		[DisplayName("billingaccountidyominame")]
		[AttributeLogicalName("billingaccountidyominame")]
		public string Billingaccountidyominame
		{	
			get { return GetAttributeValue<string>("billingaccountidyominame"); }
			set
			{ 
				if(value == Billingaccountidyominame) return;
				SetAttributeValue("billingaccountidyominame", value);
			}
		}	
			
		/// <summary>
        /// billingcontactid
        /// </summary>
		[DisplayName("Billing Contact")]
		[AttributeLogicalName("billingcontactid")]
		public EntityReference BillingContact
		{	
			get { return GetAttributeValue<EntityReference>("billingcontactid"); }
			set
			{ 
				if(value == BillingContact) return;
				SetAttributeValue("billingcontactid", value);
			}
		}	
			
		/// <summary>
        /// billingcontactidname
        /// </summary>
		[DisplayName("billingcontactidname")]
		[AttributeLogicalName("billingcontactidname")]
		public string Billingcontactidname
		{	
			get { return GetAttributeValue<string>("billingcontactidname"); }
			set
			{ 
				if(value == Billingcontactidname) return;
				SetAttributeValue("billingcontactidname", value);
			}
		}	
			
		/// <summary>
        /// billingcontactidyominame
        /// </summary>
		[DisplayName("billingcontactidyominame")]
		[AttributeLogicalName("billingcontactidyominame")]
		public string Billingcontactidyominame
		{	
			get { return GetAttributeValue<string>("billingcontactidyominame"); }
			set
			{ 
				if(value == Billingcontactidyominame) return;
				SetAttributeValue("billingcontactidyominame", value);
			}
		}	
			
		/// <summary>
        /// billingcustomerid
        /// </summary>
		[DisplayName("Bill To Customer")]
		[AttributeLogicalName("billingcustomerid")]
		public EntityReference BillToCustomer
		{	
			get { return GetAttributeValue<EntityReference>("billingcustomerid"); }
			set
			{ 
				if(value == BillToCustomer) return;
				SetAttributeValue("billingcustomerid", value);
			}
		}	
			
		/// <summary>
        /// billingcustomeridname
        /// </summary>
		[DisplayName("billingcustomeridname")]
		[AttributeLogicalName("billingcustomeridname")]
		public string Billingcustomeridname
		{	
			get { return GetAttributeValue<string>("billingcustomeridname"); }
			set
			{ 
				if(value == Billingcustomeridname) return;
				SetAttributeValue("billingcustomeridname", value);
			}
		}	
			
		/// <summary>
        /// billingcustomeridtype
        /// </summary>
		[DisplayName("Bill To Customer Type")]
		[AttributeLogicalName("billingcustomeridtype")]
		public string BillToCustomerType
		{	
			get { return GetAttributeValue<string>("billingcustomeridtype"); }
			set
			{ 
				if(value == BillToCustomerType) return;
				SetAttributeValue("billingcustomeridtype", value);
			}
		}	
			
		/// <summary>
        /// billingcustomeridyominame
        /// </summary>
		[DisplayName("billingcustomeridyominame")]
		[AttributeLogicalName("billingcustomeridyominame")]
		public string Billingcustomeridyominame
		{	
			get { return GetAttributeValue<string>("billingcustomeridyominame"); }
			set
			{ 
				if(value == Billingcustomeridyominame) return;
				SetAttributeValue("billingcustomeridyominame", value);
			}
		}	
			
		/// <summary>
        /// billingendon
        /// </summary>
		[DisplayName("Billing End Date")]
		[AttributeLogicalName("billingendon")]
		public DateTime? BillingEndDate
		{	
			get { return GetAttributeValue<DateTime?>("billingendon"); }
			set
			{ 
				if(value == BillingEndDate) return;
				SetAttributeValue("billingendon", value);
			}
		}	
			
		/// <summary>
        /// billingfrequencycode
        /// </summary>
		[DisplayName("Billing Frequency")]
		[AttributeLogicalName("billingfrequencycode")]
		public eBillingFrequency? BillingFrequency
		{	
			get 
			{ 
				var optionSetValue = GetAttributeValue<OptionSetValue>("billingfrequencycode");
				if (optionSetValue != null) return (eBillingFrequency)optionSetValue.Value;
				else return null;
			}
			set 
			{ 
				if(value == BillingFrequency) return;

				OptionSetValue optionSetValue = null;
				if(value != null) optionSetValue = new OptionSetValue((int)value);
				SetAttributeValue("billingfrequencycode", optionSetValue); 
			}
		}

		/// <summary>
        /// billingstarton
        /// </summary>
		[DisplayName("Billing Start Date")]
		[AttributeLogicalName("billingstarton")]
		public DateTime? BillingStartDate
		{	
			get { return GetAttributeValue<DateTime?>("billingstarton"); }
			set
			{ 
				if(value == BillingStartDate) return;
				SetAttributeValue("billingstarton", value);
			}
		}	
			
		/// <summary>
        /// billtoaddress
        /// </summary>
		[DisplayName("Bill To Address")]
		[AttributeLogicalName("billtoaddress")]
		public EntityReference BillToAddress
		{	
			get { return GetAttributeValue<EntityReference>("billtoaddress"); }
			set
			{ 
				if(value == BillToAddress) return;
				SetAttributeValue("billtoaddress", value);
			}
		}	
			
		/// <summary>
        /// billtoaddressname
        /// </summary>
		[DisplayName("billtoaddressname")]
		[AttributeLogicalName("billtoaddressname")]
		public string Billtoaddressname
		{	
			get { return GetAttributeValue<string>("billtoaddressname"); }
			set
			{ 
				if(value == Billtoaddressname) return;
				SetAttributeValue("billtoaddressname", value);
			}
		}	
			
		/// <summary>
        /// cancelon
        /// </summary>
		[DisplayName("Cancellation Date")]
		[AttributeLogicalName("cancelon")]
		public DateTime? CancellationDate
		{	
			get { return GetAttributeValue<DateTime?>("cancelon"); }
			set
			{ 
				if(value == CancellationDate) return;
				SetAttributeValue("cancelon", value);
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
        /// contractid
        /// </summary>
		[DisplayName("Contract")]
		[AttributeLogicalName("contractid")]
		public override Guid Id
		{
			get => base.Id;
			set { base.Id = value; SetAttributeValue("contractid", value); }
		}

							/// <summary>
        /// contractlanguage
        /// </summary>
		[DisplayName("Description")]
		[AttributeLogicalName("contractlanguage")]
		public string Description
		{	
			get { return GetAttributeValue<string>("contractlanguage"); }
			set
			{ 
				if(value == Description) return;
				SetAttributeValue("contractlanguage", value);
			}
		}	
			
		/// <summary>
        /// contractnumber
        /// </summary>
		[DisplayName("Contract ID")]
		[AttributeLogicalName("contractnumber")]
		public string ContractID
		{	
			get { return GetAttributeValue<string>("contractnumber"); }
			set
			{ 
				if(value == ContractID) return;
				SetAttributeValue("contractnumber", value);
			}
		}	
			
		/// <summary>
        /// contractservicelevelcode
        /// </summary>
		[DisplayName("Service Level")]
		[AttributeLogicalName("contractservicelevelcode")]
		public eServiceLevel? ServiceLevel
		{	
			get 
			{ 
				var optionSetValue = GetAttributeValue<OptionSetValue>("contractservicelevelcode");
				if (optionSetValue != null) return (eServiceLevel)optionSetValue.Value;
				else return null;
			}
			set 
			{ 
				if(value == ServiceLevel) return;

				OptionSetValue optionSetValue = null;
				if(value != null) optionSetValue = new OptionSetValue((int)value);
				SetAttributeValue("contractservicelevelcode", optionSetValue); 
			}
		}

		/// <summary>
        /// contracttemplateabbreviation
        /// </summary>
		[DisplayName("Template Abbreviation")]
		[AttributeLogicalName("contracttemplateabbreviation")]
		public string TemplateAbbreviation
		{	
			get { return GetAttributeValue<string>("contracttemplateabbreviation"); }
			set
			{ 
				if(value == TemplateAbbreviation) return;
				SetAttributeValue("contracttemplateabbreviation", value);
			}
		}	
			
		/// <summary>
        /// contracttemplateid
        /// </summary>
		[DisplayName("Contract Template")]
		[AttributeLogicalName("contracttemplateid")]
		public EntityReference ContractTemplate
		{	
			get { return GetAttributeValue<EntityReference>("contracttemplateid"); }
			set
			{ 
				if(value == ContractTemplate) return;
				SetAttributeValue("contracttemplateid", value);
			}
		}	
			
		/// <summary>
        /// contracttemplateidname
        /// </summary>
		[DisplayName("contracttemplateidname")]
		[AttributeLogicalName("contracttemplateidname")]
		public string Contracttemplateidname
		{	
			get { return GetAttributeValue<string>("contracttemplateidname"); }
			set
			{ 
				if(value == Contracttemplateidname) return;
				SetAttributeValue("contracttemplateidname", value);
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
        /// duration
        /// </summary>
		[DisplayName("Duration")]
		[AttributeLogicalName("duration")]
		public int? Duration
		{	
			get { return GetAttributeValue<int?>("duration"); }
			set
			{ 
				if(value == Duration) return;
				SetAttributeValue("duration", value);
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
        /// expireson
        /// </summary>
		[DisplayName("Contract End Date")]
		[AttributeLogicalName("expireson")]
		public DateTime? ContractEndDate
		{	
			get { return GetAttributeValue<DateTime?>("expireson"); }
			set
			{ 
				if(value == ContractEndDate) return;
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
        /// netprice
		///
		/// Precision: 2
		/// MaxValue: 100000000000000
		/// MinValue: 0
        /// </summary>
		[DisplayName("Net Price")]
		[AttributeLogicalName("netprice")]
		public decimal? NetPrice
		{	
			get { return GetAttributeValue<Money>("netprice")?.Value; }
			set 
			{
				Money moneyValue = null;
				if(value != null) 
				{
					var roundedValue = Decimal.Round(value.Value, 2);
					moneyValue = new Money(roundedValue);
				}

				if(moneyValue.Value == NetPrice) return;
				SetAttributeValue("netprice", moneyValue);  
			}
		}

		/// <summary>
        /// originatingcontract
        /// </summary>
		[DisplayName("Originating Contract")]
		[AttributeLogicalName("originatingcontract")]
		public EntityReference OriginatingContract
		{	
			get { return GetAttributeValue<EntityReference>("originatingcontract"); }
			set
			{ 
				if(value == OriginatingContract) return;
				SetAttributeValue("originatingcontract", value);
			}
		}	
			
		/// <summary>
        /// originatingcontractname
        /// </summary>
		[DisplayName("originatingcontractname")]
		[AttributeLogicalName("originatingcontractname")]
		public string Originatingcontractname
		{	
			get { return GetAttributeValue<string>("originatingcontractname"); }
			set
			{ 
				if(value == Originatingcontractname) return;
				SetAttributeValue("originatingcontractname", value);
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
        /// serviceaddress
        /// </summary>
		[DisplayName("Contract Address")]
		[AttributeLogicalName("serviceaddress")]
		public EntityReference ContractAddress
		{	
			get { return GetAttributeValue<EntityReference>("serviceaddress"); }
			set
			{ 
				if(value == ContractAddress) return;
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
		[DisplayName("Contract Name")]
		[AttributeLogicalName("title")]
		public string ContractName
		{	
			get { return GetAttributeValue<string>("title"); }
			set
			{ 
				if(value == ContractName) return;
				SetAttributeValue("title", value);
			}
		}	
			
		/// <summary>
        /// totaldiscount
		///
		/// Precision: 2
		/// MaxValue: 100000000000000
		/// MinValue: 0
        /// </summary>
		[DisplayName("Total Discount")]
		[AttributeLogicalName("totaldiscount")]
		public decimal? TotalDiscount
		{	
			get { return GetAttributeValue<Money>("totaldiscount")?.Value; }
			set 
			{
				Money moneyValue = null;
				if(value != null) 
				{
					var roundedValue = Decimal.Round(value.Value, 2);
					moneyValue = new Money(roundedValue);
				}

				if(moneyValue.Value == TotalDiscount) return;
				SetAttributeValue("totaldiscount", moneyValue);  
			}
		}

		/// <summary>
        /// totalprice
		///
		/// Precision: 2
		/// MaxValue: 100000000000000
		/// MinValue: 0
        /// </summary>
		[DisplayName("Total Price")]
		[AttributeLogicalName("totalprice")]
		public decimal? TotalPrice
		{	
			get { return GetAttributeValue<Money>("totalprice")?.Value; }
			set 
			{
				Money moneyValue = null;
				if(value != null) 
				{
					var roundedValue = Decimal.Round(value.Value, 2);
					moneyValue = new Money(roundedValue);
				}

				if(moneyValue.Value == TotalPrice) return;
				SetAttributeValue("totalprice", moneyValue);  
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
        /// usediscountaspercentage
        /// </summary>
		[DisplayName("Discount")]
		[AttributeLogicalName("usediscountaspercentage")]
		public bool? Discount
		{	
			get { return GetAttributeValue<bool?>("usediscountaspercentage"); }
			set
			{ 
				if(value == Discount) return;
				SetAttributeValue("usediscountaspercentage", value);
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
        /// 1:N Get entities for 'contract_activity_parties'
        /// </summary>
		[RelationshipSchemaName("contract_activity_parties")]
		public IEnumerable<ActivityParty> ContractActivityParties
		{
			get { return GetRelatedEntities<ActivityParty>("contract_activity_parties", null); }
			set { SetRelatedEntities("contract_activity_parties", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'Contract_ActivityPointers'
        /// </summary>
		[RelationshipSchemaName("Contract_ActivityPointers")]
		public IEnumerable<Activity> ContractActivityPointers
		{
			get { return GetRelatedEntities<Activity>("Contract_ActivityPointers", null); }
			set { SetRelatedEntities("Contract_ActivityPointers", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'Contract_Annotation'
        /// </summary>
		[RelationshipSchemaName("Contract_Annotation")]
		public IEnumerable<Note> ContractAnnotation
		{
			get { return GetRelatedEntities<Note>("Contract_Annotation", null); }
			set { SetRelatedEntities("Contract_Annotation", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'Contract_Appointments'
        /// </summary>
		[RelationshipSchemaName("Contract_Appointments")]
		public IEnumerable<Appointment> ContractAppointments
		{
			get { return GetRelatedEntities<Appointment>("Contract_Appointments", null); }
			set { SetRelatedEntities("Contract_Appointments", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'Contract_AsyncOperations'
        /// </summary>
		[RelationshipSchemaName("Contract_AsyncOperations")]
		public IEnumerable<SystemJob> ContractAsyncOperations
		{
			get { return GetRelatedEntities<SystemJob>("Contract_AsyncOperations", null); }
			set { SetRelatedEntities("Contract_AsyncOperations", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'Contract_BulkDeleteFailures'
        /// </summary>
		[RelationshipSchemaName("Contract_BulkDeleteFailures")]
		public IEnumerable<BulkDeleteFailure> ContractBulkDeleteFailures
		{
			get { return GetRelatedEntities<BulkDeleteFailure>("Contract_BulkDeleteFailures", null); }
			set { SetRelatedEntities("Contract_BulkDeleteFailures", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'contract_cases'
        /// </summary>
		[RelationshipSchemaName("contract_cases")]
		public IEnumerable<Case> ContractCases
		{
			get { return GetRelatedEntities<Case>("contract_cases", null); }
			set { SetRelatedEntities("contract_cases", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'contract_connections1'
        /// </summary>
		[RelationshipSchemaName("contract_connections1")]
		public IEnumerable<Connection> ContractConnections1
		{
			get { return GetRelatedEntities<Connection>("contract_connections1", null); }
			set { SetRelatedEntities("contract_connections1", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'contract_connections2'
        /// </summary>
		[RelationshipSchemaName("contract_connections2")]
		public IEnumerable<Connection> ContractConnections2
		{
			get { return GetRelatedEntities<Connection>("contract_connections2", null); }
			set { SetRelatedEntities("contract_connections2", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'Contract_DuplicateBaseRecord'
        /// </summary>
		[RelationshipSchemaName("Contract_DuplicateBaseRecord")]
		public IEnumerable<DuplicateRecord> ContractDuplicateBaseRecord
		{
			get { return GetRelatedEntities<DuplicateRecord>("Contract_DuplicateBaseRecord", null); }
			set { SetRelatedEntities("Contract_DuplicateBaseRecord", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'Contract_DuplicateMatchingRecord'
        /// </summary>
		[RelationshipSchemaName("Contract_DuplicateMatchingRecord")]
		public IEnumerable<DuplicateRecord> ContractDuplicateMatchingRecord
		{
			get { return GetRelatedEntities<DuplicateRecord>("Contract_DuplicateMatchingRecord", null); }
			set { SetRelatedEntities("Contract_DuplicateMatchingRecord", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'Contract_Emails'
        /// </summary>
		[RelationshipSchemaName("Contract_Emails")]
		public IEnumerable<Email> ContractEmails
		{
			get { return GetRelatedEntities<Email>("Contract_Emails", null); }
			set { SetRelatedEntities("Contract_Emails", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'Contract_Faxes'
        /// </summary>
		[RelationshipSchemaName("Contract_Faxes")]
		public IEnumerable<Fax> ContractFaxes
		{
			get { return GetRelatedEntities<Fax>("Contract_Faxes", null); }
			set { SetRelatedEntities("Contract_Faxes", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'Contract_Letters'
        /// </summary>
		[RelationshipSchemaName("Contract_Letters")]
		public IEnumerable<Letter> ContractLetters
		{
			get { return GetRelatedEntities<Letter>("Contract_Letters", null); }
			set { SetRelatedEntities("Contract_Letters", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'contract_line_items'
        /// </summary>
		[RelationshipSchemaName("contract_line_items")]
		public IEnumerable<ContractLine> ContractLineItems
		{
			get { return GetRelatedEntities<ContractLine>("contract_line_items", null); }
			set { SetRelatedEntities("contract_line_items", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'Contract_MailboxTrackingFolder'
        /// </summary>
		[RelationshipSchemaName("Contract_MailboxTrackingFolder")]
		public IEnumerable<MailboxAutoTrackingFolder> ContractMailboxTrackingFolder
		{
			get { return GetRelatedEntities<MailboxAutoTrackingFolder>("Contract_MailboxTrackingFolder", null); }
			set { SetRelatedEntities("Contract_MailboxTrackingFolder", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'contract_originating_contract'
        /// </summary>
		[RelationshipSchemaName("contract_originating_contract")]
		public IEnumerable<Contract> ContractOriginatingContract
		{
			get { return GetRelatedEntities<Contract>("contract_originating_contract", null); }
			set { SetRelatedEntities("contract_originating_contract", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'Contract_Phonecalls'
        /// </summary>
		[RelationshipSchemaName("Contract_Phonecalls")]
		public IEnumerable<PhoneCall> ContractPhonecalls
		{
			get { return GetRelatedEntities<PhoneCall>("Contract_Phonecalls", null); }
			set { SetRelatedEntities("Contract_Phonecalls", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'contract_principalobjectattributeaccess'
        /// </summary>
		[RelationshipSchemaName("contract_principalobjectattributeaccess")]
		public IEnumerable<FieldSharing> ContractPrincipalobjectattributeaccess
		{
			get { return GetRelatedEntities<FieldSharing>("contract_principalobjectattributeaccess", null); }
			set { SetRelatedEntities("contract_principalobjectattributeaccess", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'Contract_ProcessSessions'
        /// </summary>
		[RelationshipSchemaName("Contract_ProcessSessions")]
		public IEnumerable<ProcessSession> ContractProcessSessions
		{
			get { return GetRelatedEntities<ProcessSession>("Contract_ProcessSessions", null); }
			set { SetRelatedEntities("Contract_ProcessSessions", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'Contract_RecurringAppointmentMasters'
        /// </summary>
		[RelationshipSchemaName("Contract_RecurringAppointmentMasters")]
		public IEnumerable<RecurringAppointment> ContractRecurringAppointmentMasters
		{
			get { return GetRelatedEntities<RecurringAppointment>("Contract_RecurringAppointmentMasters", null); }
			set { SetRelatedEntities("Contract_RecurringAppointmentMasters", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'Contract_ServiceAppointments'
        /// </summary>
		[RelationshipSchemaName("Contract_ServiceAppointments")]
		public IEnumerable<ServiceActivity> ContractServiceAppointments
		{
			get { return GetRelatedEntities<ServiceActivity>("Contract_ServiceAppointments", null); }
			set { SetRelatedEntities("Contract_ServiceAppointments", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'Contract_SocialActivities'
        /// </summary>
		[RelationshipSchemaName("Contract_SocialActivities")]
		public IEnumerable<SocialActivity> ContractSocialActivities
		{
			get { return GetRelatedEntities<SocialActivity>("Contract_SocialActivities", null); }
			set { SetRelatedEntities("Contract_SocialActivities", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'Contract_SyncErrors'
        /// </summary>
		[RelationshipSchemaName("Contract_SyncErrors")]
		public IEnumerable<SyncError> ContractSyncErrors
		{
			get { return GetRelatedEntities<SyncError>("Contract_SyncErrors", null); }
			set { SetRelatedEntities("Contract_SyncErrors", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'Contract_Tasks'
        /// </summary>
		[RelationshipSchemaName("Contract_Tasks")]
		public IEnumerable<Task> ContractTasks
		{
			get { return GetRelatedEntities<Task>("Contract_Tasks", null); }
			set { SetRelatedEntities("Contract_Tasks", null, value); }
		}
		/// <summary>
        /// N:N Get entities for 'Contact'
        /// </summary>
		[RelationshipSchemaName("servicecontractcontacts_association")]
		public IEnumerable<Contact> ServicecontractcontactsAssociation
		{
			get { return GetRelatedEntities<Contact>("servicecontractcontacts_association", null); }
			set { SetRelatedEntities("servicecontractcontacts_association", null, value); }
		}
		#endregion

		#region Actions
		#endregion

		#region OptionSetEnums
		public enum eAllotmentType
		{	
		
			[Label("Number of Cases")]
			[Description(@"")]
			NumberOfCases = 1, 
		
			[Label("Time")]
			[Description(@"")]
			Time = 2, 
		
			[Label("Coverage Dates")]
			[Description(@"")]
			CoverageDates = 3, 
		}
		
		public enum eBillingFrequency
		{	
		
			[Label("Monthly")]
			[Description(@"")]
			Monthly = 1, 
		
			[Label("Bimonthly")]
			[Description(@"")]
			Bimonthly = 2, 
		
			[Label("Quarterly")]
			[Description(@"")]
			Quarterly = 3, 
		
			[Label("Semiannually")]
			[Description(@"")]
			Semiannually = 4, 
		
			[Label("Annually")]
			[Description(@"")]
			Annually = 5, 
		}
		
		public enum eServiceLevel
		{	
		
			[Label("Gold")]
			[Description(@"")]
			Gold = 1, 
		
			[Label("Silver")]
			[Description(@"")]
			Silver = 2, 
		
			[Label("Bronze")]
			[Description(@"")]
			Bronze = 3, 
		}
		
		public enum eStatus
		{	
		
			[Label("Draft")]
			[Description(@"")]
			Draft = 0, 
		
			[Label("Invoiced")]
			[Description(@"")]
			Invoiced = 1, 
		
			[Label("Active")]
			[Description(@"")]
			Active = 2, 
		
			[Label("On Hold")]
			[Description(@"")]
			OnHold = 3, 
		
			[Label("Canceled")]
			[Description(@"")]
			Canceled = 4, 
		
			[Label("Expired")]
			[Description(@"")]
			Expired = 5, 
		}
		
		public enum eStatusReason
		{	
		
			[Label("Draft")]
			[Description(@"")]
			Draft_Active = 1, 
		
			[Label("Invoiced")]
			[Description(@"")]
			Invoiced_Inactive = 2, 
		
			[Label("Active")]
			[Description(@"")]
			Active = 3, 
		
			[Label("On Hold")]
			[Description(@"")]
			OnHold = 4, 
		
			[Label("Canceled")]
			[Description(@"")]
			Canceled = 5, 
		
			[Label("Expired")]
			[Description(@"")]
			Expired = 6, 
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

			/// <summary>activeon</summary>
			public const string ContractStartDate = "activeon";

			/// <summary>allotmenttypecode</summary>
			public const string AllotmentType = "allotmenttypecode";

			/// <summary>billingaccountid</summary>
			public const string BillingAccount = "billingaccountid";

			/// <summary>billingaccountidname</summary>
			public const string Billingaccountidname = "billingaccountidname";

			/// <summary>billingaccountidyominame</summary>
			public const string Billingaccountidyominame = "billingaccountidyominame";

			/// <summary>billingcontactid</summary>
			public const string BillingContact = "billingcontactid";

			/// <summary>billingcontactidname</summary>
			public const string Billingcontactidname = "billingcontactidname";

			/// <summary>billingcontactidyominame</summary>
			public const string Billingcontactidyominame = "billingcontactidyominame";

			/// <summary>billingcustomerid</summary>
			public const string BillToCustomer = "billingcustomerid";

			/// <summary>billingcustomeridname</summary>
			public const string Billingcustomeridname = "billingcustomeridname";

			/// <summary>billingcustomeridtype</summary>
			public const string BillToCustomerType = "billingcustomeridtype";

			/// <summary>billingcustomeridyominame</summary>
			public const string Billingcustomeridyominame = "billingcustomeridyominame";

			/// <summary>billingendon</summary>
			public const string BillingEndDate = "billingendon";

			/// <summary>billingfrequencycode</summary>
			public const string BillingFrequency = "billingfrequencycode";

			/// <summary>billingstarton</summary>
			public const string BillingStartDate = "billingstarton";

			/// <summary>billtoaddress</summary>
			public const string BillToAddress = "billtoaddress";

			/// <summary>billtoaddressname</summary>
			public const string Billtoaddressname = "billtoaddressname";

			/// <summary>cancelon</summary>
			public const string CancellationDate = "cancelon";

			/// <summary>contactid</summary>
			public const string Contact = "contactid";

			/// <summary>contactidname</summary>
			public const string Contactidname = "contactidname";

			/// <summary>contactidyominame</summary>
			public const string Contactidyominame = "contactidyominame";

			/// <summary>contractid</summary>
			public const string ContractId = "contractid";

			/// <summary>contractlanguage</summary>
			public const string Description = "contractlanguage";

			/// <summary>contractnumber</summary>
			public const string ContractID = "contractnumber";

			/// <summary>contractservicelevelcode</summary>
			public const string ServiceLevel = "contractservicelevelcode";

			/// <summary>contracttemplateabbreviation</summary>
			public const string TemplateAbbreviation = "contracttemplateabbreviation";

			/// <summary>contracttemplateid</summary>
			public const string ContractTemplate = "contracttemplateid";

			/// <summary>contracttemplateidname</summary>
			public const string Contracttemplateidname = "contracttemplateidname";

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

			/// <summary>duration</summary>
			public const string Duration = "duration";

			/// <summary>effectivitycalendar</summary>
			public const string SupportCalendar = "effectivitycalendar";

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

			/// <summary>expireson</summary>
			public const string ContractEndDate = "expireson";

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

			/// <summary>netprice</summary>
			public const string NetPrice = "netprice";

			/// <summary>originatingcontract</summary>
			public const string OriginatingContract = "originatingcontract";

			/// <summary>originatingcontractname</summary>
			public const string Originatingcontractname = "originatingcontractname";

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

			/// <summary>serviceaddress</summary>
			public const string ContractAddress = "serviceaddress";

			/// <summary>serviceaddressname</summary>
			public const string Serviceaddressname = "serviceaddressname";

			/// <summary>statecode</summary>
			public const string Status = "statecode";

			/// <summary>statuscode</summary>
			public const string StatusReason = "statuscode";

			/// <summary>timezoneruleversionnumber</summary>
			public const string TimeZoneRuleVersionNumber = "timezoneruleversionnumber";

			/// <summary>title</summary>
			public const string ContractName = "title";

			/// <summary>totaldiscount</summary>
			public const string TotalDiscount = "totaldiscount";

			/// <summary>totalprice</summary>
			public const string TotalPrice = "totalprice";

			/// <summary>transactioncurrencyid</summary>
			public const string Currency = "transactioncurrencyid";

			/// <summary>transactioncurrencyidname</summary>
			public const string Transactioncurrencyidname = "transactioncurrencyidname";

			/// <summary>usediscountaspercentage</summary>
			public const string Discount = "usediscountaspercentage";

			/// <summary>utcconversiontimezonecode</summary>
			public const string UTCConversionTimeZoneCode = "utcconversiontimezonecode";

			/// <summary>versionnumber</summary>
			public const string VersionNumber = "versionnumber";

		}
		#endregion

		#region Schemas
		public static class Schemas 
		{
			/// <summary>1:N contract_activity_parties</summary>
			public const string ContractActivityParties = "contract_activity_parties";

			/// <summary>1:N Contract_ActivityPointers</summary>
			public const string ContractActivityPointers = "Contract_ActivityPointers";

			/// <summary>1:N Contract_Annotation</summary>
			public const string ContractAnnotation = "Contract_Annotation";

			/// <summary>1:N Contract_Appointments</summary>
			public const string ContractAppointments = "Contract_Appointments";

			/// <summary>1:N Contract_AsyncOperations</summary>
			public const string ContractAsyncOperations = "Contract_AsyncOperations";

			/// <summary>1:N Contract_BulkDeleteFailures</summary>
			public const string ContractBulkDeleteFailures = "Contract_BulkDeleteFailures";

			/// <summary>1:N contract_cases</summary>
			public const string ContractCases = "contract_cases";

			/// <summary>1:N contract_connections1</summary>
			public const string ContractConnections1 = "contract_connections1";

			/// <summary>1:N contract_connections2</summary>
			public const string ContractConnections2 = "contract_connections2";

			/// <summary>1:N Contract_DuplicateBaseRecord</summary>
			public const string ContractDuplicateBaseRecord = "Contract_DuplicateBaseRecord";

			/// <summary>1:N Contract_DuplicateMatchingRecord</summary>
			public const string ContractDuplicateMatchingRecord = "Contract_DuplicateMatchingRecord";

			/// <summary>1:N Contract_Emails</summary>
			public const string ContractEmails = "Contract_Emails";

			/// <summary>1:N Contract_Faxes</summary>
			public const string ContractFaxes = "Contract_Faxes";

			/// <summary>1:N Contract_Letters</summary>
			public const string ContractLetters = "Contract_Letters";

			/// <summary>1:N contract_line_items</summary>
			public const string ContractLineItems = "contract_line_items";

			/// <summary>1:N Contract_MailboxTrackingFolder</summary>
			public const string ContractMailboxTrackingFolder = "Contract_MailboxTrackingFolder";

			/// <summary>1:N contract_originating_contract</summary>
			public const string ContractOriginatingContract = "contract_originating_contract";

			/// <summary>1:N Contract_Phonecalls</summary>
			public const string ContractPhonecalls = "Contract_Phonecalls";

			/// <summary>1:N contract_principalobjectattributeaccess</summary>
			public const string ContractPrincipalobjectattributeaccess = "contract_principalobjectattributeaccess";

			/// <summary>1:N Contract_ProcessSessions</summary>
			public const string ContractProcessSessions = "Contract_ProcessSessions";

			/// <summary>1:N Contract_RecurringAppointmentMasters</summary>
			public const string ContractRecurringAppointmentMasters = "Contract_RecurringAppointmentMasters";

			/// <summary>1:N Contract_ServiceAppointments</summary>
			public const string ContractServiceAppointments = "Contract_ServiceAppointments";

			/// <summary>1:N Contract_SocialActivities</summary>
			public const string ContractSocialActivities = "Contract_SocialActivities";

			/// <summary>1:N Contract_SyncErrors</summary>
			public const string ContractSyncErrors = "Contract_SyncErrors";

			/// <summary>1:N Contract_Tasks</summary>
			public const string ContractTasks = "Contract_Tasks";

			/// <summary>N:N servicecontractcontacts_association</summary>
			public const string ServicecontractcontactsAssociation = "servicecontractcontacts_association";

		}
		#endregion
	}
}

