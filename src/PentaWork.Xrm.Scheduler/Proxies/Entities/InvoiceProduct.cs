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
	[EntityLogicalName("invoicedetail")]
	public sealed class InvoiceProduct : Entity
	{	
		public static readonly int? EntityTypeCode = 1091;
		public new const string LogicalName = "invoicedetail";
		public const string PrimaryIdAttribute = "invoicedetailid";
		public const string PrimaryNameAttribute = "invoicedetailname";
	
		public InvoiceProduct() : base("invoicedetail") { }

		#region Attributes
		/// <summary>
        /// actualdeliveryon
        /// </summary>
		[DisplayName("Delivered On")]
		[AttributeLogicalName("actualdeliveryon")]
		public DateTime? DeliveredOn
		{	
			get { return GetAttributeValue<DateTime?>("actualdeliveryon"); }
			set
			{ 
				if(value == DeliveredOn) return;
				SetAttributeValue("actualdeliveryon", value);
			}
		}	
			
		/// <summary>
        /// baseamount
		///
		/// Precision: 2
		/// MaxValue: 922337203685477
		/// MinValue: -922337203685477
        /// </summary>
		[DisplayName("Amount")]
		[AttributeLogicalName("baseamount")]
		public decimal? Amount
		{	
			get { return GetAttributeValue<Money>("baseamount")?.Value; }
			set 
			{
				Money moneyValue = null;
				if(value != null) 
				{
					var roundedValue = Decimal.Round(value.Value, 2);
					moneyValue = new Money(roundedValue);
				}

				if(moneyValue.Value == Amount) return;
				SetAttributeValue("baseamount", moneyValue);  
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
        /// extendedamount
		///
		/// Precision: 2
		/// MaxValue: 922337203685477
		/// MinValue: -922337203685477
        /// </summary>
		[DisplayName("Extended Amount")]
		[AttributeLogicalName("extendedamount")]
		public decimal? ExtendedAmount
		{	
			get { return GetAttributeValue<Money>("extendedamount")?.Value; }
			set 
			{
				Money moneyValue = null;
				if(value != null) 
				{
					var roundedValue = Decimal.Round(value.Value, 2);
					moneyValue = new Money(roundedValue);
				}

				if(moneyValue.Value == ExtendedAmount) return;
				SetAttributeValue("extendedamount", moneyValue);  
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
        /// invoicedetailid
        /// </summary>
		[DisplayName("Invoice Product")]
		[AttributeLogicalName("invoicedetailid")]
		public override Guid Id
		{
			get => base.Id;
			set { base.Id = value; SetAttributeValue("invoicedetailid", value); }
		}

							/// <summary>
        /// invoicedetailname
        /// </summary>
		[DisplayName("Name")]
		[AttributeLogicalName("invoicedetailname")]
		public string Name
		{	
			get { return GetAttributeValue<string>("invoicedetailname"); }
			set
			{ 
				if(value == Name) return;
				SetAttributeValue("invoicedetailname", value);
			}
		}	
			
		/// <summary>
        /// invoiceid
        /// </summary>
		[DisplayName("Invoice ID")]
		[AttributeLogicalName("invoiceid")]
		public EntityReference InvoiceID
		{	
			get { return GetAttributeValue<EntityReference>("invoiceid"); }
			set
			{ 
				if(value == InvoiceID) return;
				SetAttributeValue("invoiceid", value);
			}
		}	
			
		/// <summary>
        /// invoiceidname
        /// </summary>
		[DisplayName("invoiceidname")]
		[AttributeLogicalName("invoiceidname")]
		public string Invoiceidname
		{	
			get { return GetAttributeValue<string>("invoiceidname"); }
			set
			{ 
				if(value == Invoiceidname) return;
				SetAttributeValue("invoiceidname", value);
			}
		}	
			
		/// <summary>
        /// invoiceispricelocked
        /// </summary>
		[DisplayName("Invoice Is Price Locked")]
		[AttributeLogicalName("invoiceispricelocked")]
		public bool? InvoiceIsPriceLocked
		{	
			get { return GetAttributeValue<bool?>("invoiceispricelocked"); }
			set
			{ 
				if(value == InvoiceIsPriceLocked) return;
				SetAttributeValue("invoiceispricelocked", value);
			}
		}	
			
		/// <summary>
        /// invoicestatecode
        /// </summary>
		[DisplayName("Invoice Status")]
		[AttributeLogicalName("invoicestatecode")]
		public eInvoiceStatus? InvoiceStatus
		{	
			get 
			{ 
				var optionSetValue = GetAttributeValue<OptionSetValue>("invoicestatecode");
				if (optionSetValue != null) return (eInvoiceStatus)optionSetValue.Value;
				else return null;
			}
			set 
			{ 
				if(value == InvoiceStatus) return;

				OptionSetValue optionSetValue = null;
				if(value != null) optionSetValue = new OptionSetValue((int)value);
				SetAttributeValue("invoicestatecode", optionSetValue); 
			}
		}

		/// <summary>
        /// iscopied
        /// </summary>
		[DisplayName("Copied")]
		[AttributeLogicalName("iscopied")]
		public bool? Copied
		{	
			get { return GetAttributeValue<bool?>("iscopied"); }
			set
			{ 
				if(value == Copied) return;
				SetAttributeValue("iscopied", value);
			}
		}	
			
		/// <summary>
        /// ispriceoverridden
        /// </summary>
		[DisplayName("Pricing")]
		[AttributeLogicalName("ispriceoverridden")]
		public bool? Pricing
		{	
			get { return GetAttributeValue<bool?>("ispriceoverridden"); }
			set
			{ 
				if(value == Pricing) return;
				SetAttributeValue("ispriceoverridden", value);
			}
		}	
			
		/// <summary>
        /// isproductoverridden
        /// </summary>
		[DisplayName("Select Product")]
		[AttributeLogicalName("isproductoverridden")]
		public bool? SelectProduct
		{	
			get { return GetAttributeValue<bool?>("isproductoverridden"); }
			set
			{ 
				if(value == SelectProduct) return;
				SetAttributeValue("isproductoverridden", value);
			}
		}	
			
		/// <summary>
        /// lineitemnumber
        /// </summary>
		[DisplayName("Line Item Number")]
		[AttributeLogicalName("lineitemnumber")]
		public int? LineItemNumber
		{	
			get { return GetAttributeValue<int?>("lineitemnumber"); }
			set
			{ 
				if(value == LineItemNumber) return;
				SetAttributeValue("lineitemnumber", value);
			}
		}	
			
		/// <summary>
        /// manualdiscountamount
		///
		/// Precision: 2
		/// MaxValue: 1000000000000
		/// MinValue: 0
        /// </summary>
		[DisplayName("Manual Discount")]
		[AttributeLogicalName("manualdiscountamount")]
		public decimal? ManualDiscount
		{	
			get { return GetAttributeValue<Money>("manualdiscountamount")?.Value; }
			set 
			{
				Money moneyValue = null;
				if(value != null) 
				{
					var roundedValue = Decimal.Round(value.Value, 2);
					moneyValue = new Money(roundedValue);
				}

				if(moneyValue.Value == ManualDiscount) return;
				SetAttributeValue("manualdiscountamount", moneyValue);  
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
        /// parentbundleid
        /// </summary>
		[DisplayName("Parent Bundle")]
		[AttributeLogicalName("parentbundleid")]
		public Guid ParentBundleId
		{	
			get { return GetAttributeValue<Guid>("parentbundleid"); }
			set
			{ 
				if(value == ParentBundleId) return;
				SetAttributeValue("parentbundleid", value);
			}
		}	
			
		/// <summary>
        /// parentbundleidref
        /// </summary>
		[DisplayName("Parent bundle product")]
		[AttributeLogicalName("parentbundleidref")]
		public EntityReference ParentBundleProduct
		{	
			get { return GetAttributeValue<EntityReference>("parentbundleidref"); }
			set
			{ 
				if(value == ParentBundleProduct) return;
				SetAttributeValue("parentbundleidref", value);
			}
		}	
			
		/// <summary>
        /// priceperunit
		///
		/// Precision: 2
		/// MaxValue: 922337203685477
		/// MinValue: -922337203685477
        /// </summary>
		[DisplayName("Price Per Unit")]
		[AttributeLogicalName("priceperunit")]
		public decimal? PricePerUnit
		{	
			get { return GetAttributeValue<Money>("priceperunit")?.Value; }
			set 
			{
				Money moneyValue = null;
				if(value != null) 
				{
					var roundedValue = Decimal.Round(value.Value, 2);
					moneyValue = new Money(roundedValue);
				}

				if(moneyValue.Value == PricePerUnit) return;
				SetAttributeValue("priceperunit", moneyValue);  
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
        /// productassociationid
        /// </summary>
		[DisplayName("Bundle Item Association")]
		[AttributeLogicalName("productassociationid")]
		public Guid BundleItemAssociationId
		{	
			get { return GetAttributeValue<Guid>("productassociationid"); }
			set
			{ 
				if(value == BundleItemAssociationId) return;
				SetAttributeValue("productassociationid", value);
			}
		}	
			
		/// <summary>
        /// productdescription
        /// </summary>
		[DisplayName("Write-In Product")]
		[AttributeLogicalName("productdescription")]
		public string WriteInProduct
		{	
			get { return GetAttributeValue<string>("productdescription"); }
			set
			{ 
				if(value == WriteInProduct) return;
				SetAttributeValue("productdescription", value);
			}
		}	
			
		/// <summary>
        /// productid
        /// </summary>
		[DisplayName("Existing Product")]
		[AttributeLogicalName("productid")]
		public EntityReference ExistingProduct
		{	
			get { return GetAttributeValue<EntityReference>("productid"); }
			set
			{ 
				if(value == ExistingProduct) return;
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
        /// productname
        /// </summary>
		[DisplayName("Product Name")]
		[AttributeLogicalName("productname")]
		public string ProductName
		{	
			get { return GetAttributeValue<string>("productname"); }
			set
			{ 
				if(value == ProductName) return;
				SetAttributeValue("productname", value);
			}
		}	
			
		/// <summary>
        /// productnumber
        /// </summary>
		[DisplayName("Product Number")]
		[AttributeLogicalName("productnumber")]
		public string ProductNumber
		{	
			get { return GetAttributeValue<string>("productnumber"); }
			set
			{ 
				if(value == ProductNumber) return;
				SetAttributeValue("productnumber", value);
			}
		}	
			
		/// <summary>
        /// producttypecode
        /// </summary>
		[DisplayName("Product type")]
		[AttributeLogicalName("producttypecode")]
		public egProductType? ProductType
		{	
			get 
			{ 
				var optionSetValue = GetAttributeValue<OptionSetValue>("producttypecode");
				if (optionSetValue != null) return (egProductType)optionSetValue.Value;
				else return null;
			}
			set 
			{ 
				if(value == ProductType) return;

				OptionSetValue optionSetValue = null;
				if(value != null) optionSetValue = new OptionSetValue((int)value);
				SetAttributeValue("producttypecode", optionSetValue); 
			}
		}

		/// <summary>
        /// propertyconfigurationstatus
        /// </summary>
		[DisplayName("Property Configuration")]
		[AttributeLogicalName("propertyconfigurationstatus")]
		public egPropertiesConfiguration? PropertyConfiguration
		{	
			get 
			{ 
				var optionSetValue = GetAttributeValue<OptionSetValue>("propertyconfigurationstatus");
				if (optionSetValue != null) return (egPropertiesConfiguration)optionSetValue.Value;
				else return null;
			}
			set 
			{ 
				if(value == PropertyConfiguration) return;

				OptionSetValue optionSetValue = null;
				if(value != null) optionSetValue = new OptionSetValue((int)value);
				SetAttributeValue("propertyconfigurationstatus", optionSetValue); 
			}
		}

		/// <summary>
        /// quantity
		///
		/// Precision: 5
		/// MaxValue: 100000000000
		/// MinValue: -100000000000
        /// </summary>
		[DisplayName("Quantity")]
		[AttributeLogicalName("quantity")]
		public decimal? Quantity
		{	
			get { return GetAttributeValue<decimal?>("quantity"); }
			set 
			{
				decimal? decimalValue = null;
				if(value != null) decimalValue = Decimal.Round(value.Value, 5);
				if(decimalValue == Quantity) return;
				SetAttributeValue("quantity", decimalValue);  
			}
		}

		/// <summary>
        /// quantitybackordered
		///
		/// Precision: 5
		/// MaxValue: 1000000000
		/// MinValue: 0
        /// </summary>
		[DisplayName("Quantity Back Ordered")]
		[AttributeLogicalName("quantitybackordered")]
		public decimal? QuantityBackOrdered
		{	
			get { return GetAttributeValue<decimal?>("quantitybackordered"); }
			set 
			{
				decimal? decimalValue = null;
				if(value != null) decimalValue = Decimal.Round(value.Value, 5);
				if(decimalValue == QuantityBackOrdered) return;
				SetAttributeValue("quantitybackordered", decimalValue);  
			}
		}

		/// <summary>
        /// quantitycancelled
		///
		/// Precision: 5
		/// MaxValue: 1000000000
		/// MinValue: 0
        /// </summary>
		[DisplayName("Quantity Canceled")]
		[AttributeLogicalName("quantitycancelled")]
		public decimal? QuantityCanceled
		{	
			get { return GetAttributeValue<decimal?>("quantitycancelled"); }
			set 
			{
				decimal? decimalValue = null;
				if(value != null) decimalValue = Decimal.Round(value.Value, 5);
				if(decimalValue == QuantityCanceled) return;
				SetAttributeValue("quantitycancelled", decimalValue);  
			}
		}

		/// <summary>
        /// quantityshipped
		///
		/// Precision: 5
		/// MaxValue: 1000000000
		/// MinValue: -1000000000
        /// </summary>
		[DisplayName("Quantity Shipped")]
		[AttributeLogicalName("quantityshipped")]
		public decimal? QuantityShipped
		{	
			get { return GetAttributeValue<decimal?>("quantityshipped"); }
			set 
			{
				decimal? decimalValue = null;
				if(value != null) decimalValue = Decimal.Round(value.Value, 5);
				if(decimalValue == QuantityShipped) return;
				SetAttributeValue("quantityshipped", decimalValue);  
			}
		}

		/// <summary>
        /// salesorderdetailid
        /// </summary>
		[DisplayName("Order Product Id")]
		[AttributeLogicalName("salesorderdetailid")]
		public EntityReference OrderProductId
		{	
			get { return GetAttributeValue<EntityReference>("salesorderdetailid"); }
			set
			{ 
				if(value == OrderProductId) return;
				SetAttributeValue("salesorderdetailid", value);
			}
		}	
			
		/// <summary>
        /// salesorderdetailidname
        /// </summary>
		[DisplayName("salesorderdetailidname")]
		[AttributeLogicalName("salesorderdetailidname")]
		public string Salesorderdetailidname
		{	
			get { return GetAttributeValue<string>("salesorderdetailidname"); }
			set
			{ 
				if(value == Salesorderdetailidname) return;
				SetAttributeValue("salesorderdetailidname", value);
			}
		}	
			
		/// <summary>
        /// salesrepid
        /// </summary>
		[DisplayName("Salesperson")]
		[AttributeLogicalName("salesrepid")]
		public EntityReference Salesperson
		{	
			get { return GetAttributeValue<EntityReference>("salesrepid"); }
			set
			{ 
				if(value == Salesperson) return;
				SetAttributeValue("salesrepid", value);
			}
		}	
			
		/// <summary>
        /// salesrepidname
        /// </summary>
		[DisplayName("salesrepidname")]
		[AttributeLogicalName("salesrepidname")]
		public string Salesrepidname
		{	
			get { return GetAttributeValue<string>("salesrepidname"); }
			set
			{ 
				if(value == Salesrepidname) return;
				SetAttributeValue("salesrepidname", value);
			}
		}	
			
		/// <summary>
        /// salesrepidyominame
        /// </summary>
		[DisplayName("salesrepidyominame")]
		[AttributeLogicalName("salesrepidyominame")]
		public string Salesrepidyominame
		{	
			get { return GetAttributeValue<string>("salesrepidyominame"); }
			set
			{ 
				if(value == Salesrepidyominame) return;
				SetAttributeValue("salesrepidyominame", value);
			}
		}	
			
		/// <summary>
        /// sequencenumber
        /// </summary>
		[DisplayName("Sequence Number")]
		[AttributeLogicalName("sequencenumber")]
		public int? SequenceNumber
		{	
			get { return GetAttributeValue<int?>("sequencenumber"); }
			set
			{ 
				if(value == SequenceNumber) return;
				SetAttributeValue("sequencenumber", value);
			}
		}	
			
		/// <summary>
        /// shippingtrackingnumber
        /// </summary>
		[DisplayName("Shipment Tracking Number")]
		[AttributeLogicalName("shippingtrackingnumber")]
		public string ShipmentTrackingNumber
		{	
			get { return GetAttributeValue<string>("shippingtrackingnumber"); }
			set
			{ 
				if(value == ShipmentTrackingNumber) return;
				SetAttributeValue("shippingtrackingnumber", value);
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
		[DisplayName("Freight Terms")]
		[AttributeLogicalName("shipto_freighttermscode")]
		public eFreightTerms? FreightTerms
		{	
			get 
			{ 
				var optionSetValue = GetAttributeValue<OptionSetValue>("shipto_freighttermscode");
				if (optionSetValue != null) return (eFreightTerms)optionSetValue.Value;
				else return null;
			}
			set 
			{ 
				if(value == FreightTerms) return;

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
        /// tax
		///
		/// Precision: 2
		/// MaxValue: 1000000000000
		/// MinValue: -1000000000000
        /// </summary>
		[DisplayName("Tax")]
		[AttributeLogicalName("tax")]
		public decimal? Tax
		{	
			get { return GetAttributeValue<Money>("tax")?.Value; }
			set 
			{
				Money moneyValue = null;
				if(value != null) 
				{
					var roundedValue = Decimal.Round(value.Value, 2);
					moneyValue = new Money(roundedValue);
				}

				if(moneyValue.Value == Tax) return;
				SetAttributeValue("tax", moneyValue);  
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
        /// volumediscountamount
		///
		/// Precision: 2
		/// MaxValue: 922337203685477
		/// MinValue: 0
        /// </summary>
		[DisplayName("Volume Discount")]
		[AttributeLogicalName("volumediscountamount")]
		public decimal? VolumeDiscount
		{	
			get { return GetAttributeValue<Money>("volumediscountamount")?.Value; }
			set 
			{
				Money moneyValue = null;
				if(value != null) 
				{
					var roundedValue = Decimal.Round(value.Value, 2);
					moneyValue = new Money(roundedValue);
				}

				if(moneyValue.Value == VolumeDiscount) return;
				SetAttributeValue("volumediscountamount", moneyValue);  
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
        /// 1:N Get entities for 'InvoiceDetail_AsyncOperations'
        /// </summary>
		[RelationshipSchemaName("InvoiceDetail_AsyncOperations")]
		public IEnumerable<SystemJob> InvoiceDetailAsyncOperations
		{
			get { return GetRelatedEntities<SystemJob>("InvoiceDetail_AsyncOperations", null); }
			set { SetRelatedEntities("InvoiceDetail_AsyncOperations", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'InvoiceDetail_BulkDeleteFailures'
        /// </summary>
		[RelationshipSchemaName("InvoiceDetail_BulkDeleteFailures")]
		public IEnumerable<BulkDeleteFailure> InvoiceDetailBulkDeleteFailures
		{
			get { return GetRelatedEntities<BulkDeleteFailure>("InvoiceDetail_BulkDeleteFailures", null); }
			set { SetRelatedEntities("InvoiceDetail_BulkDeleteFailures", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'InvoiceDetail_Dynamicpropertyinstance'
        /// </summary>
		[RelationshipSchemaName("InvoiceDetail_Dynamicpropertyinstance")]
		public IEnumerable<PropertyInstance> InvoiceDetailDynamicpropertyinstance
		{
			get { return GetRelatedEntities<PropertyInstance>("InvoiceDetail_Dynamicpropertyinstance", null); }
			set { SetRelatedEntities("InvoiceDetail_Dynamicpropertyinstance", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'invoicedetail_MailboxTrackingFolders'
        /// </summary>
		[RelationshipSchemaName("invoicedetail_MailboxTrackingFolders")]
		public IEnumerable<MailboxAutoTrackingFolder> InvoicedetailMailboxTrackingFolders
		{
			get { return GetRelatedEntities<MailboxAutoTrackingFolder>("invoicedetail_MailboxTrackingFolders", null); }
			set { SetRelatedEntities("invoicedetail_MailboxTrackingFolders", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'invoicedetail_parent_invoicedetail'
        /// </summary>
		[RelationshipSchemaName("invoicedetail_parent_invoicedetail")]
		public IEnumerable<InvoiceProduct> InvoicedetailParentInvoicedetail
		{
			get { return GetRelatedEntities<InvoiceProduct>("invoicedetail_parent_invoicedetail", null); }
			set { SetRelatedEntities("invoicedetail_parent_invoicedetail", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'invoicedetail_parentref_invoicedetail'
        /// </summary>
		[RelationshipSchemaName("invoicedetail_parentref_invoicedetail")]
		public IEnumerable<InvoiceProduct> InvoicedetailParentrefInvoicedetail
		{
			get { return GetRelatedEntities<InvoiceProduct>("invoicedetail_parentref_invoicedetail", null); }
			set { SetRelatedEntities("invoicedetail_parentref_invoicedetail", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'invoicedetail_principalobjectattributeaccess'
        /// </summary>
		[RelationshipSchemaName("invoicedetail_principalobjectattributeaccess")]
		public IEnumerable<FieldSharing> InvoicedetailPrincipalobjectattributeaccess
		{
			get { return GetRelatedEntities<FieldSharing>("invoicedetail_principalobjectattributeaccess", null); }
			set { SetRelatedEntities("invoicedetail_principalobjectattributeaccess", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'InvoiceDetail_ProcessSessions'
        /// </summary>
		[RelationshipSchemaName("InvoiceDetail_ProcessSessions")]
		public IEnumerable<ProcessSession> InvoiceDetailProcessSessions
		{
			get { return GetRelatedEntities<ProcessSession>("InvoiceDetail_ProcessSessions", null); }
			set { SetRelatedEntities("InvoiceDetail_ProcessSessions", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'InvoiceDetail_SyncErrors'
        /// </summary>
		[RelationshipSchemaName("InvoiceDetail_SyncErrors")]
		public IEnumerable<SyncError> InvoiceDetailSyncErrors
		{
			get { return GetRelatedEntities<SyncError>("InvoiceDetail_SyncErrors", null); }
			set { SetRelatedEntities("InvoiceDetail_SyncErrors", null, value); }
		}
		#endregion

		#region Actions
		#endregion

		#region OptionSetEnums
		public enum eInvoiceStatus
		{	
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
		
			[Label("SkipPriceCalcOnCreate")]
			[Description(@"")]
			SkipPriceCalcOnCreate = 1, 
		
			[Label("SkipPriceCalcOnUpdate")]
			[Description(@"")]
			SkipPriceCalcOnUpdate = 2, 
		
			[Label("SkipPriceCalcOnUpSert")]
			[Description(@"")]
			SkipPriceCalcOnUpSert = 3, 
		}
		
		public enum egProductType
		{	
		
			[Label("Product")]
			[Description(@"")]
			Product = 1, 
		
			[Label("Bundle")]
			[Description(@"")]
			Bundle = 2, 
		
			[Label("Required Bundle Product")]
			[Description(@"")]
			RequiredBundleProduct = 3, 
		
			[Label("Optional Bundle Product")]
			[Description(@"")]
			OptionalBundleProduct = 4, 
		
			[Label("Project-based Service")]
			[Description(@"")]
			ProjectbasedService = 5, 
		}
		
		public enum egPropertiesConfiguration
		{	
		
			[Label("Edit")]
			[Description(@"")]
			Edit = 0, 
		
			[Label("Rectify")]
			[Description(@"")]
			Rectify = 1, 
		
			[Label("Not Configured")]
			[Description(@"")]
			NotConfigured = 2, 
		}
		
		#endregion	

		#region Properties
		public static class Properties 
		{
			/// <summary>actualdeliveryon</summary>
			public const string DeliveredOn = "actualdeliveryon";

			/// <summary>baseamount</summary>
			public const string Amount = "baseamount";

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

			/// <summary>description</summary>
			public const string Description = "description";

			/// <summary>exchangerate</summary>
			public const string ExchangeRate = "exchangerate";

			/// <summary>extendedamount</summary>
			public const string ExtendedAmount = "extendedamount";

			/// <summary>importsequencenumber</summary>
			public const string ImportSequenceNumber = "importsequencenumber";

			/// <summary>invoicedetailid</summary>
			public const string InvoiceProductId = "invoicedetailid";

			/// <summary>invoicedetailname</summary>
			public const string Name = "invoicedetailname";

			/// <summary>invoiceid</summary>
			public const string InvoiceID = "invoiceid";

			/// <summary>invoiceidname</summary>
			public const string Invoiceidname = "invoiceidname";

			/// <summary>invoiceispricelocked</summary>
			public const string InvoiceIsPriceLocked = "invoiceispricelocked";

			/// <summary>invoicestatecode</summary>
			public const string InvoiceStatus = "invoicestatecode";

			/// <summary>iscopied</summary>
			public const string Copied = "iscopied";

			/// <summary>ispriceoverridden</summary>
			public const string Pricing = "ispriceoverridden";

			/// <summary>isproductoverridden</summary>
			public const string SelectProduct = "isproductoverridden";

			/// <summary>lineitemnumber</summary>
			public const string LineItemNumber = "lineitemnumber";

			/// <summary>manualdiscountamount</summary>
			public const string ManualDiscount = "manualdiscountamount";

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

			/// <summary>parentbundleid</summary>
			public const string ParentBundleId = "parentbundleid";

			/// <summary>parentbundleidref</summary>
			public const string ParentBundleProduct = "parentbundleidref";

			/// <summary>priceperunit</summary>
			public const string PricePerUnit = "priceperunit";

			/// <summary>pricingerrorcode</summary>
			public const string PricingError = "pricingerrorcode";

			/// <summary>productassociationid</summary>
			public const string BundleItemAssociationId = "productassociationid";

			/// <summary>productdescription</summary>
			public const string WriteInProduct = "productdescription";

			/// <summary>productid</summary>
			public const string ExistingProduct = "productid";

			/// <summary>productidname</summary>
			public const string Productidname = "productidname";

			/// <summary>productname</summary>
			public const string ProductName = "productname";

			/// <summary>productnumber</summary>
			public const string ProductNumber = "productnumber";

			/// <summary>producttypecode</summary>
			public const string ProductType = "producttypecode";

			/// <summary>propertyconfigurationstatus</summary>
			public const string PropertyConfiguration = "propertyconfigurationstatus";

			/// <summary>quantity</summary>
			public const string Quantity = "quantity";

			/// <summary>quantitybackordered</summary>
			public const string QuantityBackOrdered = "quantitybackordered";

			/// <summary>quantitycancelled</summary>
			public const string QuantityCanceled = "quantitycancelled";

			/// <summary>quantityshipped</summary>
			public const string QuantityShipped = "quantityshipped";

			/// <summary>salesorderdetailid</summary>
			public const string OrderProductId = "salesorderdetailid";

			/// <summary>salesorderdetailidname</summary>
			public const string Salesorderdetailidname = "salesorderdetailidname";

			/// <summary>salesrepid</summary>
			public const string Salesperson = "salesrepid";

			/// <summary>salesrepidname</summary>
			public const string Salesrepidname = "salesrepidname";

			/// <summary>salesrepidyominame</summary>
			public const string Salesrepidyominame = "salesrepidyominame";

			/// <summary>sequencenumber</summary>
			public const string SequenceNumber = "sequencenumber";

			/// <summary>shippingtrackingnumber</summary>
			public const string ShipmentTrackingNumber = "shippingtrackingnumber";

			/// <summary>shipto_city</summary>
			public const string ShipToCity = "shipto_city";

			/// <summary>shipto_country</summary>
			public const string ShipToCountryRegion = "shipto_country";

			/// <summary>shipto_fax</summary>
			public const string ShipToFax = "shipto_fax";

			/// <summary>shipto_freighttermscode</summary>
			public const string FreightTerms = "shipto_freighttermscode";

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

			/// <summary>tax</summary>
			public const string Tax = "tax";

			/// <summary>timezoneruleversionnumber</summary>
			public const string TimeZoneRuleVersionNumber = "timezoneruleversionnumber";

			/// <summary>transactioncurrencyid</summary>
			public const string Currency = "transactioncurrencyid";

			/// <summary>transactioncurrencyidname</summary>
			public const string Transactioncurrencyidname = "transactioncurrencyidname";

			/// <summary>uomid</summary>
			public const string Unit = "uomid";

			/// <summary>uomidname</summary>
			public const string Uomidname = "uomidname";

			/// <summary>utcconversiontimezonecode</summary>
			public const string UTCConversionTimeZoneCode = "utcconversiontimezonecode";

			/// <summary>versionnumber</summary>
			public const string VersionNumber = "versionnumber";

			/// <summary>volumediscountamount</summary>
			public const string VolumeDiscount = "volumediscountamount";

			/// <summary>willcall</summary>
			public const string ShipTo = "willcall";

		}
		#endregion

		#region Schemas
		public static class Schemas 
		{
			/// <summary>1:N InvoiceDetail_AsyncOperations</summary>
			public const string InvoiceDetailAsyncOperations = "InvoiceDetail_AsyncOperations";

			/// <summary>1:N InvoiceDetail_BulkDeleteFailures</summary>
			public const string InvoiceDetailBulkDeleteFailures = "InvoiceDetail_BulkDeleteFailures";

			/// <summary>1:N InvoiceDetail_Dynamicpropertyinstance</summary>
			public const string InvoiceDetailDynamicpropertyinstance = "InvoiceDetail_Dynamicpropertyinstance";

			/// <summary>1:N invoicedetail_MailboxTrackingFolders</summary>
			public const string InvoicedetailMailboxTrackingFolders = "invoicedetail_MailboxTrackingFolders";

			/// <summary>1:N invoicedetail_parent_invoicedetail</summary>
			public const string InvoicedetailParentInvoicedetail = "invoicedetail_parent_invoicedetail";

			/// <summary>1:N invoicedetail_parentref_invoicedetail</summary>
			public const string InvoicedetailParentrefInvoicedetail = "invoicedetail_parentref_invoicedetail";

			/// <summary>1:N invoicedetail_principalobjectattributeaccess</summary>
			public const string InvoicedetailPrincipalobjectattributeaccess = "invoicedetail_principalobjectattributeaccess";

			/// <summary>1:N InvoiceDetail_ProcessSessions</summary>
			public const string InvoiceDetailProcessSessions = "InvoiceDetail_ProcessSessions";

			/// <summary>1:N InvoiceDetail_SyncErrors</summary>
			public const string InvoiceDetailSyncErrors = "InvoiceDetail_SyncErrors";

		}
		#endregion
	}
}

