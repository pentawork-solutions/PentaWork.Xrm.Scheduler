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
	[EntityLogicalName("opportunityproduct")]
	public sealed class OpportunityProduct : Entity
	{	
		public static readonly int? EntityTypeCode = 1083;
		public new const string LogicalName = "opportunityproduct";
		public const string PrimaryIdAttribute = "opportunityproductid";
		public const string PrimaryNameAttribute = "opportunityproductname";
	
		public OpportunityProduct() : base("opportunityproduct") { }

		#region Attributes
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
        /// ispriceoverridden
        /// </summary>
		[DisplayName("Price Overridden")]
		[AttributeLogicalName("ispriceoverridden")]
		public bool? PriceOverridden
		{	
			get { return GetAttributeValue<bool?>("ispriceoverridden"); }
			set
			{ 
				if(value == PriceOverridden) return;
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
		/// MaxValue: 100000000000000
		/// MinValue: 0
        /// </summary>
		[DisplayName("Manual Discount Amount")]
		[AttributeLogicalName("manualdiscountamount")]
		public decimal? ManualDiscountAmount
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

				if(moneyValue.Value == ManualDiscountAmount) return;
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
        /// opportunityproductid
        /// </summary>
		[DisplayName("Opportunity Product")]
		[AttributeLogicalName("opportunityproductid")]
		public override Guid Id
		{
			get => base.Id;
			set { base.Id = value; SetAttributeValue("opportunityproductid", value); }
		}

							/// <summary>
        /// opportunityproductname
        /// </summary>
		[DisplayName("Name")]
		[AttributeLogicalName("opportunityproductname")]
		public string Name
		{	
			get { return GetAttributeValue<string>("opportunityproductname"); }
			set
			{ 
				if(value == Name) return;
				SetAttributeValue("opportunityproductname", value);
			}
		}	
			
		/// <summary>
        /// opportunitystatecode
        /// </summary>
		[DisplayName("Opportunity Status")]
		[AttributeLogicalName("opportunitystatecode")]
		public eOpportunityStatus? OpportunityStatus
		{	
			get 
			{ 
				var optionSetValue = GetAttributeValue<OptionSetValue>("opportunitystatecode");
				if (optionSetValue != null) return (eOpportunityStatus)optionSetValue.Value;
				else return null;
			}
			set 
			{ 
				if(value == OpportunityStatus) return;

				OptionSetValue optionSetValue = null;
				if(value != null) optionSetValue = new OptionSetValue((int)value);
				SetAttributeValue("opportunitystatecode", optionSetValue); 
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
		/// MaxValue: 100000000000000
		/// MinValue: -100000000000000
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

		#endregion	

		#region Relations
			/// <summary>
        /// 1:N Get entities for 'OpportunityProduct_AsyncOperations'
        /// </summary>
		[RelationshipSchemaName("OpportunityProduct_AsyncOperations")]
		public IEnumerable<SystemJob> OpportunityProductAsyncOperations
		{
			get { return GetRelatedEntities<SystemJob>("OpportunityProduct_AsyncOperations", null); }
			set { SetRelatedEntities("OpportunityProduct_AsyncOperations", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'OpportunityProduct_BulkDeleteFailures'
        /// </summary>
		[RelationshipSchemaName("OpportunityProduct_BulkDeleteFailures")]
		public IEnumerable<BulkDeleteFailure> OpportunityProductBulkDeleteFailures
		{
			get { return GetRelatedEntities<BulkDeleteFailure>("OpportunityProduct_BulkDeleteFailures", null); }
			set { SetRelatedEntities("OpportunityProduct_BulkDeleteFailures", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'OpportunityProduct_Dynamicpropertyinstance'
        /// </summary>
		[RelationshipSchemaName("OpportunityProduct_Dynamicpropertyinstance")]
		public IEnumerable<PropertyInstance> OpportunityProductDynamicpropertyinstance
		{
			get { return GetRelatedEntities<PropertyInstance>("OpportunityProduct_Dynamicpropertyinstance", null); }
			set { SetRelatedEntities("OpportunityProduct_Dynamicpropertyinstance", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'opportunityproduct_MailboxTrackingFolders'
        /// </summary>
		[RelationshipSchemaName("opportunityproduct_MailboxTrackingFolders")]
		public IEnumerable<MailboxAutoTrackingFolder> OpportunityproductMailboxTrackingFolders
		{
			get { return GetRelatedEntities<MailboxAutoTrackingFolder>("opportunityproduct_MailboxTrackingFolders", null); }
			set { SetRelatedEntities("opportunityproduct_MailboxTrackingFolders", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'opportunityproduct_parent_opportunityproduct'
        /// </summary>
		[RelationshipSchemaName("opportunityproduct_parent_opportunityproduct")]
		public IEnumerable<OpportunityProduct> OpportunityproductParentOpportunityproduct
		{
			get { return GetRelatedEntities<OpportunityProduct>("opportunityproduct_parent_opportunityproduct", null); }
			set { SetRelatedEntities("opportunityproduct_parent_opportunityproduct", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'opportunityproduct_parentref_opportunityproduct'
        /// </summary>
		[RelationshipSchemaName("opportunityproduct_parentref_opportunityproduct")]
		public IEnumerable<OpportunityProduct> OpportunityproductParentrefOpportunityproduct
		{
			get { return GetRelatedEntities<OpportunityProduct>("opportunityproduct_parentref_opportunityproduct", null); }
			set { SetRelatedEntities("opportunityproduct_parentref_opportunityproduct", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'opportunityproduct_principalobjectattributeaccess'
        /// </summary>
		[RelationshipSchemaName("opportunityproduct_principalobjectattributeaccess")]
		public IEnumerable<FieldSharing> OpportunityproductPrincipalobjectattributeaccess
		{
			get { return GetRelatedEntities<FieldSharing>("opportunityproduct_principalobjectattributeaccess", null); }
			set { SetRelatedEntities("opportunityproduct_principalobjectattributeaccess", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'OpportunityProduct_ProcessSessions'
        /// </summary>
		[RelationshipSchemaName("OpportunityProduct_ProcessSessions")]
		public IEnumerable<ProcessSession> OpportunityProductProcessSessions
		{
			get { return GetRelatedEntities<ProcessSession>("OpportunityProduct_ProcessSessions", null); }
			set { SetRelatedEntities("OpportunityProduct_ProcessSessions", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'OpportunityProduct_SyncErrors'
        /// </summary>
		[RelationshipSchemaName("OpportunityProduct_SyncErrors")]
		public IEnumerable<SyncError> OpportunityProductSyncErrors
		{
			get { return GetRelatedEntities<SyncError>("OpportunityProduct_SyncErrors", null); }
			set { SetRelatedEntities("OpportunityProduct_SyncErrors", null, value); }
		}
		#endregion

		#region Actions
		#endregion

		#region OptionSetEnums
		public enum eOpportunityStatus
		{	
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

			/// <summary>entityimage_timestamp</summary>
			public const string EntityimageTimestamp = "entityimage_timestamp";

			/// <summary>entityimage_url</summary>
			public const string EntityimageUrl = "entityimage_url";

			/// <summary>entityimageid</summary>
			public const string EntityimageId = "entityimageid";

			/// <summary>exchangerate</summary>
			public const string ExchangeRate = "exchangerate";

			/// <summary>extendedamount</summary>
			public const string ExtendedAmount = "extendedamount";

			/// <summary>importsequencenumber</summary>
			public const string ImportSequenceNumber = "importsequencenumber";

			/// <summary>ispriceoverridden</summary>
			public const string PriceOverridden = "ispriceoverridden";

			/// <summary>isproductoverridden</summary>
			public const string SelectProduct = "isproductoverridden";

			/// <summary>lineitemnumber</summary>
			public const string LineItemNumber = "lineitemnumber";

			/// <summary>manualdiscountamount</summary>
			public const string ManualDiscountAmount = "manualdiscountamount";

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

			/// <summary>opportunityid</summary>
			public const string Opportunity = "opportunityid";

			/// <summary>opportunityidname</summary>
			public const string Opportunityidname = "opportunityidname";

			/// <summary>opportunityproductid</summary>
			public const string OpportunityProductId = "opportunityproductid";

			/// <summary>opportunityproductname</summary>
			public const string Name = "opportunityproductname";

			/// <summary>opportunitystatecode</summary>
			public const string OpportunityStatus = "opportunitystatecode";

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

			/// <summary>producttypecode</summary>
			public const string ProductType = "producttypecode";

			/// <summary>propertyconfigurationstatus</summary>
			public const string PropertyConfiguration = "propertyconfigurationstatus";

			/// <summary>quantity</summary>
			public const string Quantity = "quantity";

			/// <summary>sequencenumber</summary>
			public const string SequenceNumber = "sequencenumber";

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

		}
		#endregion

		#region Schemas
		public static class Schemas 
		{
			/// <summary>1:N OpportunityProduct_AsyncOperations</summary>
			public const string OpportunityProductAsyncOperations = "OpportunityProduct_AsyncOperations";

			/// <summary>1:N OpportunityProduct_BulkDeleteFailures</summary>
			public const string OpportunityProductBulkDeleteFailures = "OpportunityProduct_BulkDeleteFailures";

			/// <summary>1:N OpportunityProduct_Dynamicpropertyinstance</summary>
			public const string OpportunityProductDynamicpropertyinstance = "OpportunityProduct_Dynamicpropertyinstance";

			/// <summary>1:N opportunityproduct_MailboxTrackingFolders</summary>
			public const string OpportunityproductMailboxTrackingFolders = "opportunityproduct_MailboxTrackingFolders";

			/// <summary>1:N opportunityproduct_parent_opportunityproduct</summary>
			public const string OpportunityproductParentOpportunityproduct = "opportunityproduct_parent_opportunityproduct";

			/// <summary>1:N opportunityproduct_parentref_opportunityproduct</summary>
			public const string OpportunityproductParentrefOpportunityproduct = "opportunityproduct_parentref_opportunityproduct";

			/// <summary>1:N opportunityproduct_principalobjectattributeaccess</summary>
			public const string OpportunityproductPrincipalobjectattributeaccess = "opportunityproduct_principalobjectattributeaccess";

			/// <summary>1:N OpportunityProduct_ProcessSessions</summary>
			public const string OpportunityProductProcessSessions = "OpportunityProduct_ProcessSessions";

			/// <summary>1:N OpportunityProduct_SyncErrors</summary>
			public const string OpportunityProductSyncErrors = "OpportunityProduct_SyncErrors";

		}
		#endregion
	}
}

