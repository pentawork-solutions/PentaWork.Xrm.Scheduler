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
	[EntityLogicalName("pricelevel")]
	public sealed class PriceList : Entity
	{	
		public static readonly int? EntityTypeCode = 1022;
		public new const string LogicalName = "pricelevel";
		public const string PrimaryIdAttribute = "pricelevelid";
		public const string PrimaryNameAttribute = "name";
	
		public PriceList() : base("pricelevel") { }

		#region Attributes
		/// <summary>
        /// begindate
        /// </summary>
		[DisplayName("Start Date")]
		[AttributeLogicalName("begindate")]
		public DateTime? StartDate
		{	
			get { return GetAttributeValue<DateTime?>("begindate"); }
			set
			{ 
				if(value == StartDate) return;
				SetAttributeValue("begindate", value);
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
        /// enddate
        /// </summary>
		[DisplayName("End Date")]
		[AttributeLogicalName("enddate")]
		public DateTime? EndDate
		{	
			get { return GetAttributeValue<DateTime?>("enddate"); }
			set
			{ 
				if(value == EndDate) return;
				SetAttributeValue("enddate", value);
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
        /// organizationid
        /// </summary>
		[DisplayName("Organization Id")]
		[AttributeLogicalName("organizationid")]
		public EntityReference OrganizationId
		{	
			get { return GetAttributeValue<EntityReference>("organizationid"); }
			set
			{ 
				if(value == OrganizationId) return;
				SetAttributeValue("organizationid", value);
			}
		}	
			
		/// <summary>
        /// organizationidname
        /// </summary>
		[DisplayName("organizationidname")]
		[AttributeLogicalName("organizationidname")]
		public string Organizationidname
		{	
			get { return GetAttributeValue<string>("organizationidname"); }
			set
			{ 
				if(value == Organizationidname) return;
				SetAttributeValue("organizationidname", value);
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
        /// paymentmethodcode
        /// </summary>
		[DisplayName("Payment Method")]
		[AttributeLogicalName("paymentmethodcode")]
		public ePaymentMethod? PaymentMethod
		{	
			get 
			{ 
				var optionSetValue = GetAttributeValue<OptionSetValue>("paymentmethodcode");
				if (optionSetValue != null) return (ePaymentMethod)optionSetValue.Value;
				else return null;
			}
			set 
			{ 
				if(value == PaymentMethod) return;

				OptionSetValue optionSetValue = null;
				if(value != null) optionSetValue = new OptionSetValue((int)value);
				SetAttributeValue("paymentmethodcode", optionSetValue); 
			}
		}

		/// <summary>
        /// pricelevelid
        /// </summary>
		[DisplayName("Price List")]
		[AttributeLogicalName("pricelevelid")]
		public override Guid Id
		{
			get => base.Id;
			set { base.Id = value; SetAttributeValue("pricelevelid", value); }
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
        /// 1:N Get entities for 'price_level_accounts'
        /// </summary>
		[RelationshipSchemaName("price_level_accounts")]
		public IEnumerable<Account> PriceLevelAccounts
		{
			get { return GetRelatedEntities<Account>("price_level_accounts", null); }
			set { SetRelatedEntities("price_level_accounts", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'price_level_contacts'
        /// </summary>
		[RelationshipSchemaName("price_level_contacts")]
		public IEnumerable<Contact> PriceLevelContacts
		{
			get { return GetRelatedEntities<Contact>("price_level_contacts", null); }
			set { SetRelatedEntities("price_level_contacts", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'price_level_invoices'
        /// </summary>
		[RelationshipSchemaName("price_level_invoices")]
		public IEnumerable<Invoice> PriceLevelInvoices
		{
			get { return GetRelatedEntities<Invoice>("price_level_invoices", null); }
			set { SetRelatedEntities("price_level_invoices", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'price_level_opportunties'
        /// </summary>
		[RelationshipSchemaName("price_level_opportunties")]
		public IEnumerable<Opportunity> PriceLevelOpportunties
		{
			get { return GetRelatedEntities<Opportunity>("price_level_opportunties", null); }
			set { SetRelatedEntities("price_level_opportunties", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'price_level_orders'
        /// </summary>
		[RelationshipSchemaName("price_level_orders")]
		public IEnumerable<Order> PriceLevelOrders
		{
			get { return GetRelatedEntities<Order>("price_level_orders", null); }
			set { SetRelatedEntities("price_level_orders", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'price_level_product_price_levels'
        /// </summary>
		[RelationshipSchemaName("price_level_product_price_levels")]
		public IEnumerable<PriceListItem> PriceLevelProductPriceLevels
		{
			get { return GetRelatedEntities<PriceListItem>("price_level_product_price_levels", null); }
			set { SetRelatedEntities("price_level_product_price_levels", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'price_level_products'
        /// </summary>
		[RelationshipSchemaName("price_level_products")]
		public IEnumerable<Product> PriceLevelProducts
		{
			get { return GetRelatedEntities<Product>("price_level_products", null); }
			set { SetRelatedEntities("price_level_products", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'price_level_quotes'
        /// </summary>
		[RelationshipSchemaName("price_level_quotes")]
		public IEnumerable<Quote> PriceLevelQuotes
		{
			get { return GetRelatedEntities<Quote>("price_level_quotes", null); }
			set { SetRelatedEntities("price_level_quotes", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'PriceLevel_AsyncOperations'
        /// </summary>
		[RelationshipSchemaName("PriceLevel_AsyncOperations")]
		public IEnumerable<SystemJob> PriceLevelAsyncOperations
		{
			get { return GetRelatedEntities<SystemJob>("PriceLevel_AsyncOperations", null); }
			set { SetRelatedEntities("PriceLevel_AsyncOperations", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'PriceLevel_BulkDeleteFailures'
        /// </summary>
		[RelationshipSchemaName("PriceLevel_BulkDeleteFailures")]
		public IEnumerable<BulkDeleteFailure> PriceLevelBulkDeleteFailures
		{
			get { return GetRelatedEntities<BulkDeleteFailure>("PriceLevel_BulkDeleteFailures", null); }
			set { SetRelatedEntities("PriceLevel_BulkDeleteFailures", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'pricelevel_connections1'
        /// </summary>
		[RelationshipSchemaName("pricelevel_connections1")]
		public IEnumerable<Connection> PricelevelConnections1
		{
			get { return GetRelatedEntities<Connection>("pricelevel_connections1", null); }
			set { SetRelatedEntities("pricelevel_connections1", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'pricelevel_connections2'
        /// </summary>
		[RelationshipSchemaName("pricelevel_connections2")]
		public IEnumerable<Connection> PricelevelConnections2
		{
			get { return GetRelatedEntities<Connection>("pricelevel_connections2", null); }
			set { SetRelatedEntities("pricelevel_connections2", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'pricelevel_MailboxTrackingFolders'
        /// </summary>
		[RelationshipSchemaName("pricelevel_MailboxTrackingFolders")]
		public IEnumerable<MailboxAutoTrackingFolder> PricelevelMailboxTrackingFolders
		{
			get { return GetRelatedEntities<MailboxAutoTrackingFolder>("pricelevel_MailboxTrackingFolders", null); }
			set { SetRelatedEntities("pricelevel_MailboxTrackingFolders", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'pricelevel_principalobjectattributeaccess'
        /// </summary>
		[RelationshipSchemaName("pricelevel_principalobjectattributeaccess")]
		public IEnumerable<FieldSharing> PricelevelPrincipalobjectattributeaccess
		{
			get { return GetRelatedEntities<FieldSharing>("pricelevel_principalobjectattributeaccess", null); }
			set { SetRelatedEntities("pricelevel_principalobjectattributeaccess", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'PriceLevel_ProcessSessions'
        /// </summary>
		[RelationshipSchemaName("PriceLevel_ProcessSessions")]
		public IEnumerable<ProcessSession> PriceLevelProcessSessions
		{
			get { return GetRelatedEntities<ProcessSession>("PriceLevel_ProcessSessions", null); }
			set { SetRelatedEntities("PriceLevel_ProcessSessions", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'PriceLevel_SyncErrors'
        /// </summary>
		[RelationshipSchemaName("PriceLevel_SyncErrors")]
		public IEnumerable<SyncError> PriceLevelSyncErrors
		{
			get { return GetRelatedEntities<SyncError>("PriceLevel_SyncErrors", null); }
			set { SetRelatedEntities("PriceLevel_SyncErrors", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'PriceList_Campaigns'
        /// </summary>
		[RelationshipSchemaName("PriceList_Campaigns")]
		public IEnumerable<Campaign> PriceListCampaigns
		{
			get { return GetRelatedEntities<Campaign>("PriceList_Campaigns", null); }
			set { SetRelatedEntities("PriceList_Campaigns", null, value); }
		}
		#endregion

		#region Actions
		#endregion

		#region OptionSetEnums
		public enum eFreightTerms
		{	
		
			[Label("Default Value")]
			[Description(@"")]
			DefaultValue = 1, 
		}
		
		public enum ePaymentMethod
		{	
		
			[Label("Default Value")]
			[Description(@"")]
			DefaultValue = 1, 
		}
		
		public enum eShippingMethod
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
		
			[Label("Inactive")]
			[Description(@"")]
			Inactive = 1, 
		}
		
		public enum eStatusReason
		{	
		
			[Label("Active")]
			[Description(@"")]
			Active_Active = 100001, 
		
			[Label("Inactive")]
			[Description(@"")]
			Inactive_Inactive = 100002, 
		}
		
		#endregion	

		#region Properties
		public static class Properties 
		{
			/// <summary>begindate</summary>
			public const string StartDate = "begindate";

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

			/// <summary>enddate</summary>
			public const string EndDate = "enddate";

			/// <summary>exchangerate</summary>
			public const string ExchangeRate = "exchangerate";

			/// <summary>freighttermscode</summary>
			public const string FreightTerms = "freighttermscode";

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

			/// <summary>name</summary>
			public const string Name = "name";

			/// <summary>organizationid</summary>
			public const string OrganizationId = "organizationid";

			/// <summary>organizationidname</summary>
			public const string Organizationidname = "organizationidname";

			/// <summary>overriddencreatedon</summary>
			public const string RecordCreatedOn = "overriddencreatedon";

			/// <summary>paymentmethodcode</summary>
			public const string PaymentMethod = "paymentmethodcode";

			/// <summary>pricelevelid</summary>
			public const string PriceListId = "pricelevelid";

			/// <summary>shippingmethodcode</summary>
			public const string ShippingMethod = "shippingmethodcode";

			/// <summary>statecode</summary>
			public const string Status = "statecode";

			/// <summary>statuscode</summary>
			public const string StatusReason = "statuscode";

			/// <summary>timezoneruleversionnumber</summary>
			public const string TimeZoneRuleVersionNumber = "timezoneruleversionnumber";

			/// <summary>transactioncurrencyid</summary>
			public const string Currency = "transactioncurrencyid";

			/// <summary>transactioncurrencyidname</summary>
			public const string Transactioncurrencyidname = "transactioncurrencyidname";

			/// <summary>utcconversiontimezonecode</summary>
			public const string UTCConversionTimeZoneCode = "utcconversiontimezonecode";

			/// <summary>versionnumber</summary>
			public const string VersionNumber = "versionnumber";

		}
		#endregion

		#region Schemas
		public static class Schemas 
		{
			/// <summary>1:N price_level_accounts</summary>
			public const string PriceLevelAccounts = "price_level_accounts";

			/// <summary>1:N price_level_contacts</summary>
			public const string PriceLevelContacts = "price_level_contacts";

			/// <summary>1:N price_level_invoices</summary>
			public const string PriceLevelInvoices = "price_level_invoices";

			/// <summary>1:N price_level_opportunties</summary>
			public const string PriceLevelOpportunties = "price_level_opportunties";

			/// <summary>1:N price_level_orders</summary>
			public const string PriceLevelOrders = "price_level_orders";

			/// <summary>1:N price_level_product_price_levels</summary>
			public const string PriceLevelProductPriceLevels = "price_level_product_price_levels";

			/// <summary>1:N price_level_products</summary>
			public const string PriceLevelProducts = "price_level_products";

			/// <summary>1:N price_level_quotes</summary>
			public const string PriceLevelQuotes = "price_level_quotes";

			/// <summary>1:N PriceLevel_AsyncOperations</summary>
			public const string PriceLevelAsyncOperations = "PriceLevel_AsyncOperations";

			/// <summary>1:N PriceLevel_BulkDeleteFailures</summary>
			public const string PriceLevelBulkDeleteFailures = "PriceLevel_BulkDeleteFailures";

			/// <summary>1:N pricelevel_connections1</summary>
			public const string PricelevelConnections1 = "pricelevel_connections1";

			/// <summary>1:N pricelevel_connections2</summary>
			public const string PricelevelConnections2 = "pricelevel_connections2";

			/// <summary>1:N pricelevel_MailboxTrackingFolders</summary>
			public const string PricelevelMailboxTrackingFolders = "pricelevel_MailboxTrackingFolders";

			/// <summary>1:N pricelevel_principalobjectattributeaccess</summary>
			public const string PricelevelPrincipalobjectattributeaccess = "pricelevel_principalobjectattributeaccess";

			/// <summary>1:N PriceLevel_ProcessSessions</summary>
			public const string PriceLevelProcessSessions = "PriceLevel_ProcessSessions";

			/// <summary>1:N PriceLevel_SyncErrors</summary>
			public const string PriceLevelSyncErrors = "PriceLevel_SyncErrors";

			/// <summary>1:N PriceList_Campaigns</summary>
			public const string PriceListCampaigns = "PriceList_Campaigns";

		}
		#endregion
	}
}

