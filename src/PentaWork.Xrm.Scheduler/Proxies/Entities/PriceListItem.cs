using System;
using System.Linq;
using System.Diagnostics;
using System.ComponentModel;
using Microsoft.Xrm.Sdk; 
using Microsoft.Xrm.Sdk.Client;
using System.Collections.Generic;

namespace PentaWork.Xrm.Scheduler.Proxies.Entities
{
	[DebuggerDisplay("{Productidname}")] 	
	[EntityLogicalName("productpricelevel")]
	public sealed class PriceListItem : Entity
	{	
		public static readonly int? EntityTypeCode = 1026;
		public new const string LogicalName = "productpricelevel";
		public const string PrimaryIdAttribute = "productpricelevelid";
		public const string PrimaryNameAttribute = "productidname";
	
		public PriceListItem() : base("productpricelevel") { }

		#region Attributes
		/// <summary>
        /// amount
		///
		/// Precision: 2
		/// MaxValue: 100000000000000
		/// MinValue: 0
        /// </summary>
		[DisplayName("Amount")]
		[AttributeLogicalName("amount")]
		public decimal? Amount
		{	
			get { return GetAttributeValue<Money>("amount")?.Value; }
			set 
			{
				Money moneyValue = null;
				if(value != null) 
				{
					var roundedValue = Decimal.Round(value.Value, 2);
					moneyValue = new Money(roundedValue);
				}

				if(moneyValue.Value == Amount) return;
				SetAttributeValue("amount", moneyValue);  
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
        /// discounttypeid
        /// </summary>
		[DisplayName("Discount List")]
		[AttributeLogicalName("discounttypeid")]
		public EntityReference DiscountList
		{	
			get { return GetAttributeValue<EntityReference>("discounttypeid"); }
			set
			{ 
				if(value == DiscountList) return;
				SetAttributeValue("discounttypeid", value);
			}
		}	
			
		/// <summary>
        /// discounttypeidname
        /// </summary>
		[DisplayName("discounttypeidname")]
		[AttributeLogicalName("discounttypeidname")]
		public string Discounttypeidname
		{	
			get { return GetAttributeValue<string>("discounttypeidname"); }
			set
			{ 
				if(value == Discounttypeidname) return;
				SetAttributeValue("discounttypeidname", value);
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
        /// organizationid
        /// </summary>
		[DisplayName("Organization")]
		[AttributeLogicalName("organizationid")]
		public Guid OrganizationId
		{	
			get { return GetAttributeValue<Guid>("organizationid"); }
			set
			{ 
				if(value == OrganizationId) return;
				SetAttributeValue("organizationid", value);
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
        /// percentage
		///
		/// Precision: 2
		/// MaxValue: 1000000000
		/// MinValue: 0
        /// </summary>
		[DisplayName("Percentage")]
		[AttributeLogicalName("percentage")]
		public decimal? Percentage
		{	
			get { return GetAttributeValue<decimal?>("percentage"); }
			set 
			{
				decimal? decimalValue = null;
				if(value != null) decimalValue = Decimal.Round(value.Value, 2);
				if(decimalValue == Percentage) return;
				SetAttributeValue("percentage", decimalValue);  
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
        /// pricingmethodcode
        /// </summary>
		[DisplayName("Pricing Method")]
		[AttributeLogicalName("pricingmethodcode")]
		public ePricingMethod? PricingMethod
		{	
			get 
			{ 
				var optionSetValue = GetAttributeValue<OptionSetValue>("pricingmethodcode");
				if (optionSetValue != null) return (ePricingMethod)optionSetValue.Value;
				else return null;
			}
			set 
			{ 
				if(value == PricingMethod) return;

				OptionSetValue optionSetValue = null;
				if(value != null) optionSetValue = new OptionSetValue((int)value);
				SetAttributeValue("pricingmethodcode", optionSetValue); 
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
        /// productnumber
        /// </summary>
		[DisplayName("Product ID")]
		[AttributeLogicalName("productnumber")]
		public string ProductID
		{	
			get { return GetAttributeValue<string>("productnumber"); }
			set
			{ 
				if(value == ProductID) return;
				SetAttributeValue("productnumber", value);
			}
		}	
			
		/// <summary>
        /// productpricelevelid
        /// </summary>
		[DisplayName("Product Price List")]
		[AttributeLogicalName("productpricelevelid")]
		public override Guid Id
		{
			get => base.Id;
			set { base.Id = value; SetAttributeValue("productpricelevelid", value); }
		}

							/// <summary>
        /// quantitysellingcode
        /// </summary>
		[DisplayName("Quantity Selling Option")]
		[AttributeLogicalName("quantitysellingcode")]
		public eQuantitySellingOption? QuantitySellingOption
		{	
			get 
			{ 
				var optionSetValue = GetAttributeValue<OptionSetValue>("quantitysellingcode");
				if (optionSetValue != null) return (eQuantitySellingOption)optionSetValue.Value;
				else return null;
			}
			set 
			{ 
				if(value == QuantitySellingOption) return;

				OptionSetValue optionSetValue = null;
				if(value != null) optionSetValue = new OptionSetValue((int)value);
				SetAttributeValue("quantitysellingcode", optionSetValue); 
			}
		}

		/// <summary>
        /// roundingoptionamount
		///
		/// Precision: 2
		/// MaxValue: 100000000000000
		/// MinValue: -100000000000000
        /// </summary>
		[DisplayName("Rounding Amount")]
		[AttributeLogicalName("roundingoptionamount")]
		public decimal? RoundingAmount
		{	
			get { return GetAttributeValue<Money>("roundingoptionamount")?.Value; }
			set 
			{
				Money moneyValue = null;
				if(value != null) 
				{
					var roundedValue = Decimal.Round(value.Value, 2);
					moneyValue = new Money(roundedValue);
				}

				if(moneyValue.Value == RoundingAmount) return;
				SetAttributeValue("roundingoptionamount", moneyValue);  
			}
		}

		/// <summary>
        /// roundingoptioncode
        /// </summary>
		[DisplayName("Rounding Option")]
		[AttributeLogicalName("roundingoptioncode")]
		public eRoundingOption? RoundingOption
		{	
			get 
			{ 
				var optionSetValue = GetAttributeValue<OptionSetValue>("roundingoptioncode");
				if (optionSetValue != null) return (eRoundingOption)optionSetValue.Value;
				else return null;
			}
			set 
			{ 
				if(value == RoundingOption) return;

				OptionSetValue optionSetValue = null;
				if(value != null) optionSetValue = new OptionSetValue((int)value);
				SetAttributeValue("roundingoptioncode", optionSetValue); 
			}
		}

		/// <summary>
        /// roundingpolicycode
        /// </summary>
		[DisplayName("Rounding Policy")]
		[AttributeLogicalName("roundingpolicycode")]
		public eRoundingPolicy? RoundingPolicy
		{	
			get 
			{ 
				var optionSetValue = GetAttributeValue<OptionSetValue>("roundingpolicycode");
				if (optionSetValue != null) return (eRoundingPolicy)optionSetValue.Value;
				else return null;
			}
			set 
			{ 
				if(value == RoundingPolicy) return;

				OptionSetValue optionSetValue = null;
				if(value != null) optionSetValue = new OptionSetValue((int)value);
				SetAttributeValue("roundingpolicycode", optionSetValue); 
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
		[DisplayName("Unit Schedule ID")]
		[AttributeLogicalName("uomscheduleid")]
		public EntityReference UnitScheduleID
		{	
			get { return GetAttributeValue<EntityReference>("uomscheduleid"); }
			set
			{ 
				if(value == UnitScheduleID) return;
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
        /// 1:N Get entities for 'ProductPriceLevel_AsyncOperations'
        /// </summary>
		[RelationshipSchemaName("ProductPriceLevel_AsyncOperations")]
		public IEnumerable<SystemJob> ProductPriceLevelAsyncOperations
		{
			get { return GetRelatedEntities<SystemJob>("ProductPriceLevel_AsyncOperations", null); }
			set { SetRelatedEntities("ProductPriceLevel_AsyncOperations", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'ProductPriceLevel_BulkDeleteFailures'
        /// </summary>
		[RelationshipSchemaName("ProductPriceLevel_BulkDeleteFailures")]
		public IEnumerable<BulkDeleteFailure> ProductPriceLevelBulkDeleteFailures
		{
			get { return GetRelatedEntities<BulkDeleteFailure>("ProductPriceLevel_BulkDeleteFailures", null); }
			set { SetRelatedEntities("ProductPriceLevel_BulkDeleteFailures", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'productpricelevel_MailboxTrackingFolders'
        /// </summary>
		[RelationshipSchemaName("productpricelevel_MailboxTrackingFolders")]
		public IEnumerable<MailboxAutoTrackingFolder> ProductpricelevelMailboxTrackingFolders
		{
			get { return GetRelatedEntities<MailboxAutoTrackingFolder>("productpricelevel_MailboxTrackingFolders", null); }
			set { SetRelatedEntities("productpricelevel_MailboxTrackingFolders", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'productpricelevel_PrincipalObjectAttributeAccesses'
        /// </summary>
		[RelationshipSchemaName("productpricelevel_PrincipalObjectAttributeAccesses")]
		public IEnumerable<FieldSharing> ProductpricelevelPrincipalObjectAttributeAccesses
		{
			get { return GetRelatedEntities<FieldSharing>("productpricelevel_PrincipalObjectAttributeAccesses", null); }
			set { SetRelatedEntities("productpricelevel_PrincipalObjectAttributeAccesses", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'ProductPriceLevel_ProcessSessions'
        /// </summary>
		[RelationshipSchemaName("ProductPriceLevel_ProcessSessions")]
		public IEnumerable<ProcessSession> ProductPriceLevelProcessSessions
		{
			get { return GetRelatedEntities<ProcessSession>("ProductPriceLevel_ProcessSessions", null); }
			set { SetRelatedEntities("ProductPriceLevel_ProcessSessions", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'ProductPriceLevel_SyncErrors'
        /// </summary>
		[RelationshipSchemaName("ProductPriceLevel_SyncErrors")]
		public IEnumerable<SyncError> ProductPriceLevelSyncErrors
		{
			get { return GetRelatedEntities<SyncError>("ProductPriceLevel_SyncErrors", null); }
			set { SetRelatedEntities("ProductPriceLevel_SyncErrors", null, value); }
		}
		#endregion

		#region Actions
		#endregion

		#region OptionSetEnums
		public enum ePricingMethod
		{	
		
			[Label("Currency Amount")]
			[Description(@"")]
			CurrencyAmount = 1, 
		
			[Label("Percent of List")]
			[Description(@"")]
			PercentOfList = 2, 
		
			[Label("Percent Markup - Current Cost")]
			[Description(@"")]
			PercentMarkupCurrentCost = 3, 
		
			[Label("Percent Margin - Current Cost")]
			[Description(@"")]
			PercentMarginCurrentCost = 4, 
		
			[Label("Percent Markup - Standard Cost")]
			[Description(@"")]
			PercentMarkupStandardCost = 5, 
		
			[Label("Percent Margin - Standard Cost")]
			[Description(@"")]
			PercentMarginStandardCost = 6, 
		}
		
		public enum eQuantitySellingOption
		{	
		
			[Label("No Control")]
			[Description(@"")]
			NoControl = 1, 
		
			[Label("Whole")]
			[Description(@"")]
			Whole = 2, 
		
			[Label("Whole and Fractional")]
			[Description(@"")]
			WholeAndFractional = 3, 
		}
		
		public enum eRoundingOption
		{	
		
			[Label("Ends in")]
			[Description(@"")]
			EndsIn = 1, 
		
			[Label("Multiple of")]
			[Description(@"")]
			MultipleOf = 2, 
		}
		
		public enum eRoundingPolicy
		{	
		
			[Label("None")]
			[Description(@"")]
			None = 1, 
		
			[Label("Up")]
			[Description(@"")]
			Up = 2, 
		
			[Label("Down")]
			[Description(@"")]
			Down = 3, 
		
			[Label("To Nearest")]
			[Description(@"")]
			ToNearest = 4, 
		}
		
		#endregion	

		#region Properties
		public static class Properties 
		{
			/// <summary>amount</summary>
			public const string Amount = "amount";

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

			/// <summary>discounttypeid</summary>
			public const string DiscountList = "discounttypeid";

			/// <summary>discounttypeidname</summary>
			public const string Discounttypeidname = "discounttypeidname";

			/// <summary>exchangerate</summary>
			public const string ExchangeRate = "exchangerate";

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

			/// <summary>organizationid</summary>
			public const string OrganizationId = "organizationid";

			/// <summary>overriddencreatedon</summary>
			public const string RecordCreatedOn = "overriddencreatedon";

			/// <summary>percentage</summary>
			public const string Percentage = "percentage";

			/// <summary>pricelevelid</summary>
			public const string PriceList = "pricelevelid";

			/// <summary>pricelevelidname</summary>
			public const string Pricelevelidname = "pricelevelidname";

			/// <summary>pricingmethodcode</summary>
			public const string PricingMethod = "pricingmethodcode";

			/// <summary>processid</summary>
			public const string ProcessId = "processid";

			/// <summary>productid</summary>
			public const string Product = "productid";

			/// <summary>productidname</summary>
			public const string Productidname = "productidname";

			/// <summary>productnumber</summary>
			public const string ProductID = "productnumber";

			/// <summary>productpricelevelid</summary>
			public const string ProductPriceListId = "productpricelevelid";

			/// <summary>quantitysellingcode</summary>
			public const string QuantitySellingOption = "quantitysellingcode";

			/// <summary>roundingoptionamount</summary>
			public const string RoundingAmount = "roundingoptionamount";

			/// <summary>roundingoptioncode</summary>
			public const string RoundingOption = "roundingoptioncode";

			/// <summary>roundingpolicycode</summary>
			public const string RoundingPolicy = "roundingpolicycode";

			/// <summary>stageid</summary>
			public const string DeprecatedStageId = "stageid";

			/// <summary>timezoneruleversionnumber</summary>
			public const string TimeZoneRuleVersionNumber = "timezoneruleversionnumber";

			/// <summary>transactioncurrencyid</summary>
			public const string Currency = "transactioncurrencyid";

			/// <summary>transactioncurrencyidname</summary>
			public const string Transactioncurrencyidname = "transactioncurrencyidname";

			/// <summary>traversedpath</summary>
			public const string DeprecatedTraversedPath = "traversedpath";

			/// <summary>uomid</summary>
			public const string Unit = "uomid";

			/// <summary>uomidname</summary>
			public const string Uomidname = "uomidname";

			/// <summary>uomscheduleid</summary>
			public const string UnitScheduleID = "uomscheduleid";

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
			/// <summary>1:N ProductPriceLevel_AsyncOperations</summary>
			public const string ProductPriceLevelAsyncOperations = "ProductPriceLevel_AsyncOperations";

			/// <summary>1:N ProductPriceLevel_BulkDeleteFailures</summary>
			public const string ProductPriceLevelBulkDeleteFailures = "ProductPriceLevel_BulkDeleteFailures";

			/// <summary>1:N productpricelevel_MailboxTrackingFolders</summary>
			public const string ProductpricelevelMailboxTrackingFolders = "productpricelevel_MailboxTrackingFolders";

			/// <summary>1:N productpricelevel_PrincipalObjectAttributeAccesses</summary>
			public const string ProductpricelevelPrincipalObjectAttributeAccesses = "productpricelevel_PrincipalObjectAttributeAccesses";

			/// <summary>1:N ProductPriceLevel_ProcessSessions</summary>
			public const string ProductPriceLevelProcessSessions = "ProductPriceLevel_ProcessSessions";

			/// <summary>1:N ProductPriceLevel_SyncErrors</summary>
			public const string ProductPriceLevelSyncErrors = "ProductPriceLevel_SyncErrors";

		}
		#endregion
	}
}

