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
	[EntityLogicalName("salesorderdetail")]
	public sealed class OrderProduct : Entity
	{	
		public static readonly int? EntityTypeCode = 1089;
		public new const string LogicalName = "salesorderdetail";
		public const string PrimaryIdAttribute = "salesorderdetailid";
		public const string PrimaryNameAttribute = "salesorderdetailname";
	
		public OrderProduct() : base("salesorderdetail") { }

		#region Attributes
		/// <summary>
        /// baseamount
        /// </summary>
		[DisplayName("Amount")]
		[AttributeLogicalName("baseamount")]
		public decimal? Amount
		{	
			get { return GetAttributeValue<Money>("baseamount")?.Value; }
			set 
			{ 
				if(value == Amount) return;

				Money moneyValue = null;
				if(value != null) moneyValue = new Money(value.Value);
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
        /// extendedamount
        /// </summary>
		[DisplayName("Extended Amount")]
		[AttributeLogicalName("extendedamount")]
		public decimal? ExtendedAmount
		{	
			get { return GetAttributeValue<Money>("extendedamount")?.Value; }
			set 
			{ 
				if(value == ExtendedAmount) return;

				Money moneyValue = null;
				if(value != null) moneyValue = new Money(value.Value);
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
        /// </summary>
		[DisplayName("Manual Discount")]
		[AttributeLogicalName("manualdiscountamount")]
		public decimal? ManualDiscount
		{	
			get { return GetAttributeValue<Money>("manualdiscountamount")?.Value; }
			set 
			{ 
				if(value == ManualDiscount) return;

				Money moneyValue = null;
				if(value != null) moneyValue = new Money(value.Value);
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
        /// </summary>
		[DisplayName("Price Per Unit")]
		[AttributeLogicalName("priceperunit")]
		public decimal? PricePerUnit
		{	
			get { return GetAttributeValue<Money>("priceperunit")?.Value; }
			set 
			{ 
				if(value == PricePerUnit) return;

				Money moneyValue = null;
				if(value != null) moneyValue = new Money(value.Value);
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
        /// </summary>
		[DisplayName("Quantity")]
		[AttributeLogicalName("quantity")]
		public decimal? Quantity
		{	
			get { return GetAttributeValue<decimal?>("quantity"); }
			set
			{ 
				if(value == Quantity) return;
				SetAttributeValue("quantity", value);
			}
		}	
			
		/// <summary>
        /// quantitybackordered
        /// </summary>
		[DisplayName("Quantity Back Ordered")]
		[AttributeLogicalName("quantitybackordered")]
		public decimal? QuantityBackOrdered
		{	
			get { return GetAttributeValue<decimal?>("quantitybackordered"); }
			set
			{ 
				if(value == QuantityBackOrdered) return;
				SetAttributeValue("quantitybackordered", value);
			}
		}	
			
		/// <summary>
        /// quantitycancelled
        /// </summary>
		[DisplayName("Quantity Canceled")]
		[AttributeLogicalName("quantitycancelled")]
		public decimal? QuantityCanceled
		{	
			get { return GetAttributeValue<decimal?>("quantitycancelled"); }
			set
			{ 
				if(value == QuantityCanceled) return;
				SetAttributeValue("quantitycancelled", value);
			}
		}	
			
		/// <summary>
        /// quantityshipped
        /// </summary>
		[DisplayName("Quantity Shipped")]
		[AttributeLogicalName("quantityshipped")]
		public decimal? QuantityShipped
		{	
			get { return GetAttributeValue<decimal?>("quantityshipped"); }
			set
			{ 
				if(value == QuantityShipped) return;
				SetAttributeValue("quantityshipped", value);
			}
		}	
			
		/// <summary>
        /// quotedetailid
        /// </summary>
		[DisplayName("Quote Product Id")]
		[AttributeLogicalName("quotedetailid")]
		public EntityReference QuoteProductId
		{	
			get { return GetAttributeValue<EntityReference>("quotedetailid"); }
			set
			{ 
				if(value == QuoteProductId) return;
				SetAttributeValue("quotedetailid", value);
			}
		}	
			
		/// <summary>
        /// quotedetailidname
        /// </summary>
		[DisplayName("quotedetailidname")]
		[AttributeLogicalName("quotedetailidname")]
		public string Quotedetailidname
		{	
			get { return GetAttributeValue<string>("quotedetailidname"); }
			set
			{ 
				if(value == Quotedetailidname) return;
				SetAttributeValue("quotedetailidname", value);
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
        /// salesorderdetailid
        /// </summary>
		[DisplayName("Order Product")]
		[AttributeLogicalName("salesorderdetailid")]
		public override Guid Id
		{
			get => base.Id;
			set { base.Id = value; SetAttributeValue("salesorderdetailid", value); }
		}

							/// <summary>
        /// salesorderdetailname
        /// </summary>
		[DisplayName("Name")]
		[AttributeLogicalName("salesorderdetailname")]
		public string Name
		{	
			get { return GetAttributeValue<string>("salesorderdetailname"); }
			set
			{ 
				if(value == Name) return;
				SetAttributeValue("salesorderdetailname", value);
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
        /// salesorderispricelocked
        /// </summary>
		[DisplayName("Order Is Price Locked")]
		[AttributeLogicalName("salesorderispricelocked")]
		public bool? OrderIsPriceLocked
		{	
			get { return GetAttributeValue<bool?>("salesorderispricelocked"); }
			set
			{ 
				if(value == OrderIsPriceLocked) return;
				SetAttributeValue("salesorderispricelocked", value);
			}
		}	
			
		/// <summary>
        /// salesorderstatecode
        /// </summary>
		[DisplayName("Order Status")]
		[AttributeLogicalName("salesorderstatecode")]
		public eOrderStatus? OrderStatus
		{	
			get 
			{ 
				var optionSetValue = GetAttributeValue<OptionSetValue>("salesorderstatecode");
				if (optionSetValue != null) return (eOrderStatus)optionSetValue.Value;
				else return null;
			}
			set 
			{ 
				if(value == OrderStatus) return;

				OptionSetValue optionSetValue = null;
				if(value != null) optionSetValue = new OptionSetValue((int)value);
				SetAttributeValue("salesorderstatecode", optionSetValue); 
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
        /// </summary>
		[DisplayName("Tax")]
		[AttributeLogicalName("tax")]
		public decimal? Tax
		{	
			get { return GetAttributeValue<Money>("tax")?.Value; }
			set 
			{ 
				if(value == Tax) return;

				Money moneyValue = null;
				if(value != null) moneyValue = new Money(value.Value);
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
        /// </summary>
		[DisplayName("Volume Discount")]
		[AttributeLogicalName("volumediscountamount")]
		public decimal? VolumeDiscount
		{	
			get { return GetAttributeValue<Money>("volumediscountamount")?.Value; }
			set 
			{ 
				if(value == VolumeDiscount) return;

				Money moneyValue = null;
				if(value != null) moneyValue = new Money(value.Value);
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
        /// 1:N Get entities for 'msdyn_salesorderdetail_invoicedetail'
        /// </summary>
		[RelationshipSchemaName("msdyn_salesorderdetail_invoicedetail")]
		public IEnumerable<InvoiceProduct> MsdynSalesorderdetailInvoicedetail
		{
			get { return GetRelatedEntities<InvoiceProduct>("msdyn_salesorderdetail_invoicedetail", null); }
			set { SetRelatedEntities("msdyn_salesorderdetail_invoicedetail", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'SalesOrderDetail_AsyncOperations'
        /// </summary>
		[RelationshipSchemaName("SalesOrderDetail_AsyncOperations")]
		public IEnumerable<SystemJob> SalesOrderDetailAsyncOperations
		{
			get { return GetRelatedEntities<SystemJob>("SalesOrderDetail_AsyncOperations", null); }
			set { SetRelatedEntities("SalesOrderDetail_AsyncOperations", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'SalesOrderDetail_BulkDeleteFailures'
        /// </summary>
		[RelationshipSchemaName("SalesOrderDetail_BulkDeleteFailures")]
		public IEnumerable<BulkDeleteFailure> SalesOrderDetailBulkDeleteFailures
		{
			get { return GetRelatedEntities<BulkDeleteFailure>("SalesOrderDetail_BulkDeleteFailures", null); }
			set { SetRelatedEntities("SalesOrderDetail_BulkDeleteFailures", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'SalesOrderDetail_Dynamicpropertyinstance'
        /// </summary>
		[RelationshipSchemaName("SalesOrderDetail_Dynamicpropertyinstance")]
		public IEnumerable<PropertyInstance> SalesOrderDetailDynamicpropertyinstance
		{
			get { return GetRelatedEntities<PropertyInstance>("SalesOrderDetail_Dynamicpropertyinstance", null); }
			set { SetRelatedEntities("SalesOrderDetail_Dynamicpropertyinstance", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'salesorderdetail_MailboxTrackingFolders'
        /// </summary>
		[RelationshipSchemaName("salesorderdetail_MailboxTrackingFolders")]
		public IEnumerable<MailboxAutoTrackingFolder> SalesorderdetailMailboxTrackingFolders
		{
			get { return GetRelatedEntities<MailboxAutoTrackingFolder>("salesorderdetail_MailboxTrackingFolders", null); }
			set { SetRelatedEntities("salesorderdetail_MailboxTrackingFolders", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'salesorderdetail_parent_salesorderdetail'
        /// </summary>
		[RelationshipSchemaName("salesorderdetail_parent_salesorderdetail")]
		public IEnumerable<OrderProduct> SalesorderdetailParentSalesorderdetail
		{
			get { return GetRelatedEntities<OrderProduct>("salesorderdetail_parent_salesorderdetail", null); }
			set { SetRelatedEntities("salesorderdetail_parent_salesorderdetail", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'salesorderdetail_parentref_salesorderdetail'
        /// </summary>
		[RelationshipSchemaName("salesorderdetail_parentref_salesorderdetail")]
		public IEnumerable<OrderProduct> SalesorderdetailParentrefSalesorderdetail
		{
			get { return GetRelatedEntities<OrderProduct>("salesorderdetail_parentref_salesorderdetail", null); }
			set { SetRelatedEntities("salesorderdetail_parentref_salesorderdetail", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'salesorderdetail_principalobjectattributeaccess'
        /// </summary>
		[RelationshipSchemaName("salesorderdetail_principalobjectattributeaccess")]
		public IEnumerable<FieldSharing> SalesorderdetailPrincipalobjectattributeaccess
		{
			get { return GetRelatedEntities<FieldSharing>("salesorderdetail_principalobjectattributeaccess", null); }
			set { SetRelatedEntities("salesorderdetail_principalobjectattributeaccess", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'SalesOrderDetail_ProcessSessions'
        /// </summary>
		[RelationshipSchemaName("SalesOrderDetail_ProcessSessions")]
		public IEnumerable<ProcessSession> SalesOrderDetailProcessSessions
		{
			get { return GetRelatedEntities<ProcessSession>("SalesOrderDetail_ProcessSessions", null); }
			set { SetRelatedEntities("SalesOrderDetail_ProcessSessions", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'SalesOrderDetail_SyncErrors'
        /// </summary>
		[RelationshipSchemaName("SalesOrderDetail_SyncErrors")]
		public IEnumerable<SyncError> SalesOrderDetailSyncErrors
		{
			get { return GetRelatedEntities<SyncError>("SalesOrderDetail_SyncErrors", null); }
			set { SetRelatedEntities("SalesOrderDetail_SyncErrors", null, value); }
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
		
		public enum eOrderStatus
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
		
		#endregion	

		#region Properties
		public static class Properties 
		{
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

			/// <summary>quotedetailid</summary>
			public const string QuoteProductId = "quotedetailid";

			/// <summary>quotedetailidname</summary>
			public const string Quotedetailidname = "quotedetailidname";

			/// <summary>requestdeliveryby</summary>
			public const string RequestedDeliveryDate = "requestdeliveryby";

			/// <summary>salesorderdetailid</summary>
			public const string OrderProductId = "salesorderdetailid";

			/// <summary>salesorderdetailname</summary>
			public const string Name = "salesorderdetailname";

			/// <summary>salesorderid</summary>
			public const string Order = "salesorderid";

			/// <summary>salesorderidname</summary>
			public const string Salesorderidname = "salesorderidname";

			/// <summary>salesorderispricelocked</summary>
			public const string OrderIsPriceLocked = "salesorderispricelocked";

			/// <summary>salesorderstatecode</summary>
			public const string OrderStatus = "salesorderstatecode";

			/// <summary>salesrepid</summary>
			public const string Salesperson = "salesrepid";

			/// <summary>salesrepidname</summary>
			public const string Salesrepidname = "salesrepidname";

			/// <summary>salesrepidyominame</summary>
			public const string Salesrepidyominame = "salesrepidyominame";

			/// <summary>sequencenumber</summary>
			public const string SequenceNumber = "sequencenumber";

			/// <summary>shipto_addressid</summary>
			public const string ShipToAddressId = "shipto_addressid";

			/// <summary>shipto_city</summary>
			public const string ShipToCity = "shipto_city";

			/// <summary>shipto_contactname</summary>
			public const string ShipToContactName = "shipto_contactname";

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
			/// <summary>1:N msdyn_salesorderdetail_invoicedetail</summary>
			public const string MsdynSalesorderdetailInvoicedetail = "msdyn_salesorderdetail_invoicedetail";

			/// <summary>1:N SalesOrderDetail_AsyncOperations</summary>
			public const string SalesOrderDetailAsyncOperations = "SalesOrderDetail_AsyncOperations";

			/// <summary>1:N SalesOrderDetail_BulkDeleteFailures</summary>
			public const string SalesOrderDetailBulkDeleteFailures = "SalesOrderDetail_BulkDeleteFailures";

			/// <summary>1:N SalesOrderDetail_Dynamicpropertyinstance</summary>
			public const string SalesOrderDetailDynamicpropertyinstance = "SalesOrderDetail_Dynamicpropertyinstance";

			/// <summary>1:N salesorderdetail_MailboxTrackingFolders</summary>
			public const string SalesorderdetailMailboxTrackingFolders = "salesorderdetail_MailboxTrackingFolders";

			/// <summary>1:N salesorderdetail_parent_salesorderdetail</summary>
			public const string SalesorderdetailParentSalesorderdetail = "salesorderdetail_parent_salesorderdetail";

			/// <summary>1:N salesorderdetail_parentref_salesorderdetail</summary>
			public const string SalesorderdetailParentrefSalesorderdetail = "salesorderdetail_parentref_salesorderdetail";

			/// <summary>1:N salesorderdetail_principalobjectattributeaccess</summary>
			public const string SalesorderdetailPrincipalobjectattributeaccess = "salesorderdetail_principalobjectattributeaccess";

			/// <summary>1:N SalesOrderDetail_ProcessSessions</summary>
			public const string SalesOrderDetailProcessSessions = "SalesOrderDetail_ProcessSessions";

			/// <summary>1:N SalesOrderDetail_SyncErrors</summary>
			public const string SalesOrderDetailSyncErrors = "SalesOrderDetail_SyncErrors";

		}
		#endregion
	}
}

