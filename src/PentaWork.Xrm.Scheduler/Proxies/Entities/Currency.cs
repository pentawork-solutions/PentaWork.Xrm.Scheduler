using System;
using System.Linq;
using System.Diagnostics;
using System.ComponentModel;
using Microsoft.Xrm.Sdk; 
using Microsoft.Xrm.Sdk.Client;
using System.Collections.Generic;

namespace PentaWork.Xrm.Scheduler.Proxies.Entities
{
	[DebuggerDisplay("{CurrencyName}")] 	
	[EntityLogicalName("transactioncurrency")]
	public sealed class Currency : Entity
	{	
		public static readonly int? EntityTypeCode = 9105;
		public new const string LogicalName = "transactioncurrency";
		public const string PrimaryIdAttribute = "transactioncurrencyid";
		public const string PrimaryNameAttribute = "currencyname";
	
		public Currency() : base("transactioncurrency") { }

		#region Attributes
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
        /// currencyname
        /// </summary>
		[DisplayName("Currency Name")]
		[AttributeLogicalName("currencyname")]
		public string CurrencyName
		{	
			get { return GetAttributeValue<string>("currencyname"); }
			set
			{ 
				if(value == CurrencyName) return;
				SetAttributeValue("currencyname", value);
			}
		}	
			
		/// <summary>
        /// currencyprecision
        /// </summary>
		[DisplayName("Currency Precision")]
		[AttributeLogicalName("currencyprecision")]
		public int? CurrencyPrecision
		{	
			get { return GetAttributeValue<int?>("currencyprecision"); }
			set
			{ 
				if(value == CurrencyPrecision) return;
				SetAttributeValue("currencyprecision", value);
			}
		}	
			
		/// <summary>
        /// currencysymbol
        /// </summary>
		[DisplayName("Currency Symbol")]
		[AttributeLogicalName("currencysymbol")]
		public string CurrencySymbol
		{	
			get { return GetAttributeValue<string>("currencysymbol"); }
			set
			{ 
				if(value == CurrencySymbol) return;
				SetAttributeValue("currencysymbol", value);
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
		[DisplayName("Entity Image Id")]
		[AttributeLogicalName("entityimageid")]
		public Guid EntityImageId
		{	
			get { return GetAttributeValue<Guid>("entityimageid"); }
			set
			{ 
				if(value == EntityImageId) return;
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
        /// isocurrencycode
        /// </summary>
		[DisplayName("Currency Code")]
		[AttributeLogicalName("isocurrencycode")]
		public string CurrencyCode
		{	
			get { return GetAttributeValue<string>("isocurrencycode"); }
			set
			{ 
				if(value == CurrencyCode) return;
				SetAttributeValue("isocurrencycode", value);
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
		public EntityReference Organization
		{	
			get { return GetAttributeValue<EntityReference>("organizationid"); }
			set
			{ 
				if(value == Organization) return;
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
        /// transactioncurrencyid
        /// </summary>
		[DisplayName("Transaction Currency")]
		[AttributeLogicalName("transactioncurrencyid")]
		public override Guid Id
		{
			get => base.Id;
			set { base.Id = value; SetAttributeValue("transactioncurrencyid", value); }
		}

							/// <summary>
        /// uniquedscid
        /// </summary>
		[DisplayName("UniqueDscId")]
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
        /// 1:N Get entities for 'basecurrency_organization'
        /// </summary>
		[RelationshipSchemaName("basecurrency_organization")]
		public IEnumerable<Organization> BasecurrencyOrganization
		{
			get { return GetRelatedEntities<Organization>("basecurrency_organization", null); }
			set { SetRelatedEntities("basecurrency_organization", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'bulkoperation_transactioncurrency_transactioncurrencyid'
        /// </summary>
		[RelationshipSchemaName("bulkoperation_transactioncurrency_transactioncurrencyid")]
		public IEnumerable<QuickCampaign> BulkoperationTransactioncurrencyTransactioncurrencyid
		{
			get { return GetRelatedEntities<QuickCampaign>("bulkoperation_transactioncurrency_transactioncurrencyid", null); }
			set { SetRelatedEntities("bulkoperation_transactioncurrency_transactioncurrencyid", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'DynamicPropertyAssociation_TransactionCurrency'
        /// </summary>
		[RelationshipSchemaName("DynamicPropertyAssociation_TransactionCurrency")]
		public IEnumerable<PropertyAssociation> DynamicPropertyAssociationTransactionCurrency
		{
			get { return GetRelatedEntities<PropertyAssociation>("DynamicPropertyAssociation_TransactionCurrency", null); }
			set { SetRelatedEntities("DynamicPropertyAssociation_TransactionCurrency", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'DynamicPropertyOptionSetItem_TransactionCurrency'
        /// </summary>
		[RelationshipSchemaName("DynamicPropertyOptionSetItem_TransactionCurrency")]
		public IEnumerable<PropertyOptionSetItem> DynamicPropertyOptionSetItemTransactionCurrency
		{
			get { return GetRelatedEntities<PropertyOptionSetItem>("DynamicPropertyOptionSetItem_TransactionCurrency", null); }
			set { SetRelatedEntities("DynamicPropertyOptionSetItem_TransactionCurrency", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'incidentresolution_transactioncurrency_transactioncurrencyid'
        /// </summary>
		[RelationshipSchemaName("incidentresolution_transactioncurrency_transactioncurrencyid")]
		public IEnumerable<CaseResolution> IncidentresolutionTransactioncurrencyTransactioncurrencyid
		{
			get { return GetRelatedEntities<CaseResolution>("incidentresolution_transactioncurrency_transactioncurrencyid", null); }
			set { SetRelatedEntities("incidentresolution_transactioncurrency_transactioncurrencyid", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'orderclose_transactioncurrency_transactioncurrencyid'
        /// </summary>
		[RelationshipSchemaName("orderclose_transactioncurrency_transactioncurrencyid")]
		public IEnumerable<OrderClose> OrdercloseTransactioncurrencyTransactioncurrencyid
		{
			get { return GetRelatedEntities<OrderClose>("orderclose_transactioncurrency_transactioncurrencyid", null); }
			set { SetRelatedEntities("orderclose_transactioncurrency_transactioncurrencyid", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'quoteclose_transactioncurrency_transactioncurrencyid'
        /// </summary>
		[RelationshipSchemaName("quoteclose_transactioncurrency_transactioncurrencyid")]
		public IEnumerable<QuoteClose> QuotecloseTransactioncurrencyTransactioncurrencyid
		{
			get { return GetRelatedEntities<QuoteClose>("quoteclose_transactioncurrency_transactioncurrencyid", null); }
			set { SetRelatedEntities("quoteclose_transactioncurrency_transactioncurrencyid", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'transactioncurrency_account'
        /// </summary>
		[RelationshipSchemaName("transactioncurrency_account")]
		public IEnumerable<Account> TransactioncurrencyAccount
		{
			get { return GetRelatedEntities<Account>("transactioncurrency_account", null); }
			set { SetRelatedEntities("transactioncurrency_account", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'transactioncurrency_actioncard'
        /// </summary>
		[RelationshipSchemaName("transactioncurrency_actioncard")]
		public IEnumerable<ActionCard> TransactioncurrencyActioncard
		{
			get { return GetRelatedEntities<ActionCard>("transactioncurrency_actioncard", null); }
			set { SetRelatedEntities("transactioncurrency_actioncard", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'TransactionCurrency_ActionCardUserState'
        /// </summary>
		[RelationshipSchemaName("TransactionCurrency_ActionCardUserState")]
		public IEnumerable<ActionCardUserState> TransactionCurrencyActionCardUserState
		{
			get { return GetRelatedEntities<ActionCardUserState>("TransactionCurrency_ActionCardUserState", null); }
			set { SetRelatedEntities("TransactionCurrency_ActionCardUserState", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'TransactionCurrency_ActivityPointer'
        /// </summary>
		[RelationshipSchemaName("TransactionCurrency_ActivityPointer")]
		public IEnumerable<Activity> TransactionCurrencyActivityPointer
		{
			get { return GetRelatedEntities<Activity>("TransactionCurrency_ActivityPointer", null); }
			set { SetRelatedEntities("TransactionCurrency_ActivityPointer", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'transactioncurrency_annualfiscalcalendar'
        /// </summary>
		[RelationshipSchemaName("transactioncurrency_annualfiscalcalendar")]
		public IEnumerable<AnnualFiscalCalendar> TransactioncurrencyAnnualfiscalcalendar
		{
			get { return GetRelatedEntities<AnnualFiscalCalendar>("transactioncurrency_annualfiscalcalendar", null); }
			set { SetRelatedEntities("transactioncurrency_annualfiscalcalendar", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'TransactionCurrency_Appointment'
        /// </summary>
		[RelationshipSchemaName("TransactionCurrency_Appointment")]
		public IEnumerable<Appointment> TransactionCurrencyAppointment
		{
			get { return GetRelatedEntities<Appointment>("TransactionCurrency_Appointment", null); }
			set { SetRelatedEntities("TransactionCurrency_Appointment", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'TransactionCurrency_AsyncOperations'
        /// </summary>
		[RelationshipSchemaName("TransactionCurrency_AsyncOperations")]
		public IEnumerable<SystemJob> TransactionCurrencyAsyncOperations
		{
			get { return GetRelatedEntities<SystemJob>("TransactionCurrency_AsyncOperations", null); }
			set { SetRelatedEntities("TransactionCurrency_AsyncOperations", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'TransactionCurrency_bookableresource'
        /// </summary>
		[RelationshipSchemaName("TransactionCurrency_bookableresource")]
		public IEnumerable<BookableResource> TransactionCurrencyBookableresource
		{
			get { return GetRelatedEntities<BookableResource>("TransactionCurrency_bookableresource", null); }
			set { SetRelatedEntities("TransactionCurrency_bookableresource", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'TransactionCurrency_bookableresourcebooking'
        /// </summary>
		[RelationshipSchemaName("TransactionCurrency_bookableresourcebooking")]
		public IEnumerable<BookableResourceBooking> TransactionCurrencyBookableresourcebooking
		{
			get { return GetRelatedEntities<BookableResourceBooking>("TransactionCurrency_bookableresourcebooking", null); }
			set { SetRelatedEntities("TransactionCurrency_bookableresourcebooking", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'TransactionCurrency_bookableresourcebookingheader'
        /// </summary>
		[RelationshipSchemaName("TransactionCurrency_bookableresourcebookingheader")]
		public IEnumerable<BookableResourceBookingHeader> TransactionCurrencyBookableresourcebookingheader
		{
			get { return GetRelatedEntities<BookableResourceBookingHeader>("TransactionCurrency_bookableresourcebookingheader", null); }
			set { SetRelatedEntities("TransactionCurrency_bookableresourcebookingheader", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'TransactionCurrency_bookableresourcecategory'
        /// </summary>
		[RelationshipSchemaName("TransactionCurrency_bookableresourcecategory")]
		public IEnumerable<BookableResourceCategory> TransactionCurrencyBookableresourcecategory
		{
			get { return GetRelatedEntities<BookableResourceCategory>("TransactionCurrency_bookableresourcecategory", null); }
			set { SetRelatedEntities("TransactionCurrency_bookableresourcecategory", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'TransactionCurrency_bookableresourcecategoryassn'
        /// </summary>
		[RelationshipSchemaName("TransactionCurrency_bookableresourcecategoryassn")]
		public IEnumerable<BookableResourceCategoryAssn> TransactionCurrencyBookableresourcecategoryassn
		{
			get { return GetRelatedEntities<BookableResourceCategoryAssn>("TransactionCurrency_bookableresourcecategoryassn", null); }
			set { SetRelatedEntities("TransactionCurrency_bookableresourcecategoryassn", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'TransactionCurrency_bookableresourcecharacteristic'
        /// </summary>
		[RelationshipSchemaName("TransactionCurrency_bookableresourcecharacteristic")]
		public IEnumerable<BookableResourceCharacteristic> TransactionCurrencyBookableresourcecharacteristic
		{
			get { return GetRelatedEntities<BookableResourceCharacteristic>("TransactionCurrency_bookableresourcecharacteristic", null); }
			set { SetRelatedEntities("TransactionCurrency_bookableresourcecharacteristic", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'TransactionCurrency_bookableresourcegroup'
        /// </summary>
		[RelationshipSchemaName("TransactionCurrency_bookableresourcegroup")]
		public IEnumerable<BookableResourceGroup> TransactionCurrencyBookableresourcegroup
		{
			get { return GetRelatedEntities<BookableResourceGroup>("TransactionCurrency_bookableresourcegroup", null); }
			set { SetRelatedEntities("TransactionCurrency_bookableresourcegroup", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'TransactionCurrency_bookingstatus'
        /// </summary>
		[RelationshipSchemaName("TransactionCurrency_bookingstatus")]
		public IEnumerable<BookingStatus> TransactionCurrencyBookingstatus
		{
			get { return GetRelatedEntities<BookingStatus>("TransactionCurrency_bookingstatus", null); }
			set { SetRelatedEntities("TransactionCurrency_bookingstatus", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'TransactionCurrency_BusinessUnit'
        /// </summary>
		[RelationshipSchemaName("TransactionCurrency_BusinessUnit")]
		public IEnumerable<BusinessUnit> TransactionCurrencyBusinessUnit
		{
			get { return GetRelatedEntities<BusinessUnit>("TransactionCurrency_BusinessUnit", null); }
			set { SetRelatedEntities("TransactionCurrency_BusinessUnit", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'transactioncurrency_campaign'
        /// </summary>
		[RelationshipSchemaName("transactioncurrency_campaign")]
		public IEnumerable<Campaign> TransactioncurrencyCampaign
		{
			get { return GetRelatedEntities<Campaign>("transactioncurrency_campaign", null); }
			set { SetRelatedEntities("transactioncurrency_campaign", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'transactioncurrency_campaignactivity'
        /// </summary>
		[RelationshipSchemaName("transactioncurrency_campaignactivity")]
		public IEnumerable<CampaignActivity> TransactioncurrencyCampaignactivity
		{
			get { return GetRelatedEntities<CampaignActivity>("transactioncurrency_campaignactivity", null); }
			set { SetRelatedEntities("transactioncurrency_campaignactivity", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'TransactionCurrency_CampaignResponse'
        /// </summary>
		[RelationshipSchemaName("TransactionCurrency_CampaignResponse")]
		public IEnumerable<CampaignResponse> TransactionCurrencyCampaignResponse
		{
			get { return GetRelatedEntities<CampaignResponse>("TransactionCurrency_CampaignResponse", null); }
			set { SetRelatedEntities("TransactionCurrency_CampaignResponse", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'transactioncurrency_category'
        /// </summary>
		[RelationshipSchemaName("transactioncurrency_category")]
		public IEnumerable<Category> TransactioncurrencyCategory
		{
			get { return GetRelatedEntities<Category>("transactioncurrency_category", null); }
			set { SetRelatedEntities("transactioncurrency_category", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'TransactionCurrency_characteristic'
        /// </summary>
		[RelationshipSchemaName("TransactionCurrency_characteristic")]
		public IEnumerable<Characteristic> TransactionCurrencyCharacteristic
		{
			get { return GetRelatedEntities<Characteristic>("TransactionCurrency_characteristic", null); }
			set { SetRelatedEntities("TransactionCurrency_characteristic", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'transactioncurrency_competitor'
        /// </summary>
		[RelationshipSchemaName("transactioncurrency_competitor")]
		public IEnumerable<Competitor> TransactioncurrencyCompetitor
		{
			get { return GetRelatedEntities<Competitor>("transactioncurrency_competitor", null); }
			set { SetRelatedEntities("transactioncurrency_competitor", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'TransactionCurrency_Connection'
        /// </summary>
		[RelationshipSchemaName("TransactionCurrency_Connection")]
		public IEnumerable<Connection> TransactionCurrencyConnection
		{
			get { return GetRelatedEntities<Connection>("TransactionCurrency_Connection", null); }
			set { SetRelatedEntities("TransactionCurrency_Connection", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'transactioncurrency_contact'
        /// </summary>
		[RelationshipSchemaName("transactioncurrency_contact")]
		public IEnumerable<Contact> TransactioncurrencyContact
		{
			get { return GetRelatedEntities<Contact>("transactioncurrency_contact", null); }
			set { SetRelatedEntities("transactioncurrency_contact", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'transactioncurrency_contract'
        /// </summary>
		[RelationshipSchemaName("transactioncurrency_contract")]
		public IEnumerable<Contract> TransactioncurrencyContract
		{
			get { return GetRelatedEntities<Contract>("transactioncurrency_contract", null); }
			set { SetRelatedEntities("transactioncurrency_contract", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'transactioncurrency_contractdetail'
        /// </summary>
		[RelationshipSchemaName("transactioncurrency_contractdetail")]
		public IEnumerable<ContractLine> TransactioncurrencyContractdetail
		{
			get { return GetRelatedEntities<ContractLine>("transactioncurrency_contractdetail", null); }
			set { SetRelatedEntities("transactioncurrency_contractdetail", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'TransactionCurrency_CustomerAddress'
        /// </summary>
		[RelationshipSchemaName("TransactionCurrency_CustomerAddress")]
		public IEnumerable<Address> TransactionCurrencyCustomerAddress
		{
			get { return GetRelatedEntities<Address>("TransactionCurrency_CustomerAddress", null); }
			set { SetRelatedEntities("TransactionCurrency_CustomerAddress", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'transactioncurrency_discount'
        /// </summary>
		[RelationshipSchemaName("transactioncurrency_discount")]
		public IEnumerable<Discount> TransactioncurrencyDiscount
		{
			get { return GetRelatedEntities<Discount>("transactioncurrency_discount", null); }
			set { SetRelatedEntities("transactioncurrency_discount", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'transactioncurrency_discounttype'
        /// </summary>
		[RelationshipSchemaName("transactioncurrency_discounttype")]
		public IEnumerable<DiscountList> TransactioncurrencyDiscounttype
		{
			get { return GetRelatedEntities<DiscountList>("transactioncurrency_discounttype", null); }
			set { SetRelatedEntities("transactioncurrency_discounttype", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'TransactionCurrency_DuplicateBaseRecord'
        /// </summary>
		[RelationshipSchemaName("TransactionCurrency_DuplicateBaseRecord")]
		public IEnumerable<DuplicateRecord> TransactionCurrencyDuplicateBaseRecord
		{
			get { return GetRelatedEntities<DuplicateRecord>("TransactionCurrency_DuplicateBaseRecord", null); }
			set { SetRelatedEntities("TransactionCurrency_DuplicateBaseRecord", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'TransactionCurrency_DuplicateMatchingRecord'
        /// </summary>
		[RelationshipSchemaName("TransactionCurrency_DuplicateMatchingRecord")]
		public IEnumerable<DuplicateRecord> TransactionCurrencyDuplicateMatchingRecord
		{
			get { return GetRelatedEntities<DuplicateRecord>("TransactionCurrency_DuplicateMatchingRecord", null); }
			set { SetRelatedEntities("TransactionCurrency_DuplicateMatchingRecord", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'TransactionCurrency_Dynamicpropertyinsatance'
        /// </summary>
		[RelationshipSchemaName("TransactionCurrency_Dynamicpropertyinsatance")]
		public IEnumerable<PropertyInstance> TransactionCurrencyDynamicpropertyinsatance
		{
			get { return GetRelatedEntities<PropertyInstance>("TransactionCurrency_Dynamicpropertyinsatance", null); }
			set { SetRelatedEntities("TransactionCurrency_Dynamicpropertyinsatance", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'TransactionCurrency_Email'
        /// </summary>
		[RelationshipSchemaName("TransactionCurrency_Email")]
		public IEnumerable<Email> TransactionCurrencyEmail
		{
			get { return GetRelatedEntities<Email>("TransactionCurrency_Email", null); }
			set { SetRelatedEntities("TransactionCurrency_Email", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'TransactionCurrency_Entitlement'
        /// </summary>
		[RelationshipSchemaName("TransactionCurrency_Entitlement")]
		public IEnumerable<Entitlement> TransactionCurrencyEntitlement
		{
			get { return GetRelatedEntities<Entitlement>("TransactionCurrency_Entitlement", null); }
			set { SetRelatedEntities("TransactionCurrency_Entitlement", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'TransactionCurrency_entitlementchannel'
        /// </summary>
		[RelationshipSchemaName("TransactionCurrency_entitlementchannel")]
		public IEnumerable<EntitlementChannel> TransactionCurrencyEntitlementchannel
		{
			get { return GetRelatedEntities<EntitlementChannel>("TransactionCurrency_entitlementchannel", null); }
			set { SetRelatedEntities("TransactionCurrency_entitlementchannel", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'TransactionCurrency_entitlementtemplate'
        /// </summary>
		[RelationshipSchemaName("TransactionCurrency_entitlementtemplate")]
		public IEnumerable<EntitlementTemplate> TransactionCurrencyEntitlementtemplate
		{
			get { return GetRelatedEntities<EntitlementTemplate>("TransactionCurrency_entitlementtemplate", null); }
			set { SetRelatedEntities("TransactionCurrency_entitlementtemplate", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'TransactionCurrency_entitlementtemplatechannel'
        /// </summary>
		[RelationshipSchemaName("TransactionCurrency_entitlementtemplatechannel")]
		public IEnumerable<EntitlementTemplateChannel> TransactionCurrencyEntitlementtemplatechannel
		{
			get { return GetRelatedEntities<EntitlementTemplateChannel>("TransactionCurrency_entitlementtemplatechannel", null); }
			set { SetRelatedEntities("TransactionCurrency_entitlementtemplatechannel", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'TransactionCurrency_Equipment'
        /// </summary>
		[RelationshipSchemaName("TransactionCurrency_Equipment")]
		public IEnumerable<FacilityEquipment> TransactionCurrencyEquipment
		{
			get { return GetRelatedEntities<FacilityEquipment>("TransactionCurrency_Equipment", null); }
			set { SetRelatedEntities("TransactionCurrency_Equipment", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'transactioncurrency_expiredprocess'
        /// </summary>
		[RelationshipSchemaName("transactioncurrency_expiredprocess")]
		public IEnumerable<ExpiredProcess> TransactioncurrencyExpiredprocess
		{
			get { return GetRelatedEntities<ExpiredProcess>("transactioncurrency_expiredprocess", null); }
			set { SetRelatedEntities("transactioncurrency_expiredprocess", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'TransactionCurrency_Fax'
        /// </summary>
		[RelationshipSchemaName("TransactionCurrency_Fax")]
		public IEnumerable<Fax> TransactionCurrencyFax
		{
			get { return GetRelatedEntities<Fax>("TransactionCurrency_Fax", null); }
			set { SetRelatedEntities("TransactionCurrency_Fax", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'transactioncurrency_feedback'
        /// </summary>
		[RelationshipSchemaName("transactioncurrency_feedback")]
		public IEnumerable<Feedback> TransactioncurrencyFeedback
		{
			get { return GetRelatedEntities<Feedback>("transactioncurrency_feedback", null); }
			set { SetRelatedEntities("transactioncurrency_feedback", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'transactioncurrency_fixedmonthlyfiscalcalendar'
        /// </summary>
		[RelationshipSchemaName("transactioncurrency_fixedmonthlyfiscalcalendar")]
		public IEnumerable<FixedMonthlyFiscalCalendar> TransactioncurrencyFixedmonthlyfiscalcalendar
		{
			get { return GetRelatedEntities<FixedMonthlyFiscalCalendar>("transactioncurrency_fixedmonthlyfiscalcalendar", null); }
			set { SetRelatedEntities("transactioncurrency_fixedmonthlyfiscalcalendar", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'TransactionCurrency_Goal'
        /// </summary>
		[RelationshipSchemaName("TransactionCurrency_Goal")]
		public IEnumerable<Goal> TransactionCurrencyGoal
		{
			get { return GetRelatedEntities<Goal>("TransactionCurrency_Goal", null); }
			set { SetRelatedEntities("TransactionCurrency_Goal", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'TransactionCurrency_Incident'
        /// </summary>
		[RelationshipSchemaName("TransactionCurrency_Incident")]
		public IEnumerable<Case> TransactionCurrencyIncident
		{
			get { return GetRelatedEntities<Case>("TransactionCurrency_Incident", null); }
			set { SetRelatedEntities("TransactionCurrency_Incident", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'TransactionCurrency_InteractionForEmail'
        /// </summary>
		[RelationshipSchemaName("TransactionCurrency_InteractionForEmail")]
		public IEnumerable<InteractionForEmail> TransactionCurrencyInteractionForEmail
		{
			get { return GetRelatedEntities<InteractionForEmail>("TransactionCurrency_InteractionForEmail", null); }
			set { SetRelatedEntities("TransactionCurrency_InteractionForEmail", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'transactioncurrency_invoice'
        /// </summary>
		[RelationshipSchemaName("transactioncurrency_invoice")]
		public IEnumerable<Invoice> TransactioncurrencyInvoice
		{
			get { return GetRelatedEntities<Invoice>("transactioncurrency_invoice", null); }
			set { SetRelatedEntities("transactioncurrency_invoice", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'transactioncurrency_invoicedetail'
        /// </summary>
		[RelationshipSchemaName("transactioncurrency_invoicedetail")]
		public IEnumerable<InvoiceProduct> TransactioncurrencyInvoicedetail
		{
			get { return GetRelatedEntities<InvoiceProduct>("transactioncurrency_invoicedetail", null); }
			set { SetRelatedEntities("transactioncurrency_invoicedetail", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'TransactionCurrency_KbArticle'
        /// </summary>
		[RelationshipSchemaName("TransactionCurrency_KbArticle")]
		public IEnumerable<Article> TransactionCurrencyKbArticle
		{
			get { return GetRelatedEntities<Article>("TransactionCurrency_KbArticle", null); }
			set { SetRelatedEntities("TransactionCurrency_KbArticle", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'TransactionCurrency_knowledgearticle'
        /// </summary>
		[RelationshipSchemaName("TransactionCurrency_knowledgearticle")]
		public IEnumerable<KnowledgeArticle> TransactionCurrencyKnowledgearticle
		{
			get { return GetRelatedEntities<KnowledgeArticle>("TransactionCurrency_knowledgearticle", null); }
			set { SetRelatedEntities("TransactionCurrency_knowledgearticle", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'transactioncurrency_knowledgearticleincident'
        /// </summary>
		[RelationshipSchemaName("transactioncurrency_knowledgearticleincident")]
		public IEnumerable<KnowledgeArticleIncident> TransactioncurrencyKnowledgearticleincident
		{
			get { return GetRelatedEntities<KnowledgeArticleIncident>("transactioncurrency_knowledgearticleincident", null); }
			set { SetRelatedEntities("transactioncurrency_knowledgearticleincident", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'transactioncurrency_knowledgearticleviews'
        /// </summary>
		[RelationshipSchemaName("transactioncurrency_knowledgearticleviews")]
		public IEnumerable<KnowledgeArticleViews> TransactioncurrencyKnowledgearticleviews
		{
			get { return GetRelatedEntities<KnowledgeArticleViews>("transactioncurrency_knowledgearticleviews", null); }
			set { SetRelatedEntities("transactioncurrency_knowledgearticleviews", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'TransactionCurrency_KnowledgeBaseRecord'
        /// </summary>
		[RelationshipSchemaName("TransactionCurrency_KnowledgeBaseRecord")]
		public IEnumerable<KnowledgeBaseRecord> TransactionCurrencyKnowledgeBaseRecord
		{
			get { return GetRelatedEntities<KnowledgeBaseRecord>("TransactionCurrency_KnowledgeBaseRecord", null); }
			set { SetRelatedEntities("TransactionCurrency_KnowledgeBaseRecord", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'transactioncurrency_lead'
        /// </summary>
		[RelationshipSchemaName("transactioncurrency_lead")]
		public IEnumerable<Lead> TransactioncurrencyLead
		{
			get { return GetRelatedEntities<Lead>("transactioncurrency_lead", null); }
			set { SetRelatedEntities("transactioncurrency_lead", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'TransactionCurrency_LeadAddress'
        /// </summary>
		[RelationshipSchemaName("TransactionCurrency_LeadAddress")]
		public IEnumerable<LeadAddress> TransactionCurrencyLeadAddress
		{
			get { return GetRelatedEntities<LeadAddress>("TransactionCurrency_LeadAddress", null); }
			set { SetRelatedEntities("TransactionCurrency_LeadAddress", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'transactioncurrency_leadtoopportunitysalesprocess'
        /// </summary>
		[RelationshipSchemaName("transactioncurrency_leadtoopportunitysalesprocess")]
		public IEnumerable<LeadToOpportunitySalesProcess> TransactioncurrencyLeadtoopportunitysalesprocess
		{
			get { return GetRelatedEntities<LeadToOpportunitySalesProcess>("transactioncurrency_leadtoopportunitysalesprocess", null); }
			set { SetRelatedEntities("transactioncurrency_leadtoopportunitysalesprocess", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'TransactionCurrency_Letter'
        /// </summary>
		[RelationshipSchemaName("TransactionCurrency_Letter")]
		public IEnumerable<Letter> TransactionCurrencyLetter
		{
			get { return GetRelatedEntities<Letter>("TransactionCurrency_Letter", null); }
			set { SetRelatedEntities("TransactionCurrency_Letter", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'transactioncurrency_list'
        /// </summary>
		[RelationshipSchemaName("transactioncurrency_list")]
		public IEnumerable<MarketingList> TransactioncurrencyList
		{
			get { return GetRelatedEntities<MarketingList>("transactioncurrency_list", null); }
			set { SetRelatedEntities("transactioncurrency_list", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'TransactionCurrency_MailMergeTemplate'
        /// </summary>
		[RelationshipSchemaName("TransactionCurrency_MailMergeTemplate")]
		public IEnumerable<MailMergeTemplate> TransactionCurrencyMailMergeTemplate
		{
			get { return GetRelatedEntities<MailMergeTemplate>("TransactionCurrency_MailMergeTemplate", null); }
			set { SetRelatedEntities("TransactionCurrency_MailMergeTemplate", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'transactioncurrency_monthlyfiscalcalendar'
        /// </summary>
		[RelationshipSchemaName("transactioncurrency_monthlyfiscalcalendar")]
		public IEnumerable<MonthlyFiscalCalendar> TransactioncurrencyMonthlyfiscalcalendar
		{
			get { return GetRelatedEntities<MonthlyFiscalCalendar>("transactioncurrency_monthlyfiscalcalendar", null); }
			set { SetRelatedEntities("transactioncurrency_monthlyfiscalcalendar", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'transactioncurrency_newprocess'
        /// </summary>
		[RelationshipSchemaName("transactioncurrency_newprocess")]
		public IEnumerable<NewProcess> TransactioncurrencyNewprocess
		{
			get { return GetRelatedEntities<NewProcess>("transactioncurrency_newprocess", null); }
			set { SetRelatedEntities("transactioncurrency_newprocess", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'TransactionCurrency_officegraphdocument'
        /// </summary>
		[RelationshipSchemaName("TransactionCurrency_officegraphdocument")]
		public IEnumerable<OfficeGraphDocument> TransactionCurrencyOfficegraphdocument
		{
			get { return GetRelatedEntities<OfficeGraphDocument>("TransactionCurrency_officegraphdocument", null); }
			set { SetRelatedEntities("TransactionCurrency_officegraphdocument", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'transactioncurrency_opportunity'
        /// </summary>
		[RelationshipSchemaName("transactioncurrency_opportunity")]
		public IEnumerable<Opportunity> TransactioncurrencyOpportunity
		{
			get { return GetRelatedEntities<Opportunity>("transactioncurrency_opportunity", null); }
			set { SetRelatedEntities("transactioncurrency_opportunity", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'transactioncurrency_opportunityclose'
        /// </summary>
		[RelationshipSchemaName("transactioncurrency_opportunityclose")]
		public IEnumerable<OpportunityClose> TransactioncurrencyOpportunityclose
		{
			get { return GetRelatedEntities<OpportunityClose>("transactioncurrency_opportunityclose", null); }
			set { SetRelatedEntities("transactioncurrency_opportunityclose", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'transactioncurrency_opportunityproduct'
        /// </summary>
		[RelationshipSchemaName("transactioncurrency_opportunityproduct")]
		public IEnumerable<OpportunityProduct> TransactioncurrencyOpportunityproduct
		{
			get { return GetRelatedEntities<OpportunityProduct>("transactioncurrency_opportunityproduct", null); }
			set { SetRelatedEntities("transactioncurrency_opportunityproduct", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'transactioncurrency_opportunitysalesprocess'
        /// </summary>
		[RelationshipSchemaName("transactioncurrency_opportunitysalesprocess")]
		public IEnumerable<OpportunitySalesProcess> TransactioncurrencyOpportunitysalesprocess
		{
			get { return GetRelatedEntities<OpportunitySalesProcess>("transactioncurrency_opportunitysalesprocess", null); }
			set { SetRelatedEntities("transactioncurrency_opportunitysalesprocess", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'TransactionCurrency_PhoneCall'
        /// </summary>
		[RelationshipSchemaName("TransactionCurrency_PhoneCall")]
		public IEnumerable<PhoneCall> TransactionCurrencyPhoneCall
		{
			get { return GetRelatedEntities<PhoneCall>("TransactionCurrency_PhoneCall", null); }
			set { SetRelatedEntities("TransactionCurrency_PhoneCall", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'transactioncurrency_phonetocaseprocess'
        /// </summary>
		[RelationshipSchemaName("transactioncurrency_phonetocaseprocess")]
		public IEnumerable<PhoneToCaseProcess> TransactioncurrencyPhonetocaseprocess
		{
			get { return GetRelatedEntities<PhoneToCaseProcess>("transactioncurrency_phonetocaseprocess", null); }
			set { SetRelatedEntities("transactioncurrency_phonetocaseprocess", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'transactioncurrency_position'
        /// </summary>
		[RelationshipSchemaName("transactioncurrency_position")]
		public IEnumerable<Position> TransactioncurrencyPosition
		{
			get { return GetRelatedEntities<Position>("transactioncurrency_position", null); }
			set { SetRelatedEntities("transactioncurrency_position", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'transactioncurrency_pricelevel'
        /// </summary>
		[RelationshipSchemaName("transactioncurrency_pricelevel")]
		public IEnumerable<PriceList> TransactioncurrencyPricelevel
		{
			get { return GetRelatedEntities<PriceList>("transactioncurrency_pricelevel", null); }
			set { SetRelatedEntities("transactioncurrency_pricelevel", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'TransactionCurrency_ProcessSessions'
        /// </summary>
		[RelationshipSchemaName("TransactionCurrency_ProcessSessions")]
		public IEnumerable<ProcessSession> TransactionCurrencyProcessSessions
		{
			get { return GetRelatedEntities<ProcessSession>("TransactionCurrency_ProcessSessions", null); }
			set { SetRelatedEntities("TransactionCurrency_ProcessSessions", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'transactioncurrency_product'
        /// </summary>
		[RelationshipSchemaName("transactioncurrency_product")]
		public IEnumerable<Product> TransactioncurrencyProduct
		{
			get { return GetRelatedEntities<Product>("transactioncurrency_product", null); }
			set { SetRelatedEntities("transactioncurrency_product", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'transactioncurrency_ProductAssociation'
        /// </summary>
		[RelationshipSchemaName("transactioncurrency_ProductAssociation")]
		public IEnumerable<ProductAssociation> TransactioncurrencyProductAssociation
		{
			get { return GetRelatedEntities<ProductAssociation>("transactioncurrency_ProductAssociation", null); }
			set { SetRelatedEntities("transactioncurrency_ProductAssociation", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'transactioncurrency_productpricelevel'
        /// </summary>
		[RelationshipSchemaName("transactioncurrency_productpricelevel")]
		public IEnumerable<PriceListItem> TransactioncurrencyProductpricelevel
		{
			get { return GetRelatedEntities<PriceListItem>("transactioncurrency_productpricelevel", null); }
			set { SetRelatedEntities("transactioncurrency_productpricelevel", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'transactioncurrency_ProductSubstitute'
        /// </summary>
		[RelationshipSchemaName("transactioncurrency_ProductSubstitute")]
		public IEnumerable<ProductRelationship> TransactioncurrencyProductSubstitute
		{
			get { return GetRelatedEntities<ProductRelationship>("transactioncurrency_ProductSubstitute", null); }
			set { SetRelatedEntities("transactioncurrency_ProductSubstitute", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'transactioncurrency_quarterlyfiscalcalendar'
        /// </summary>
		[RelationshipSchemaName("transactioncurrency_quarterlyfiscalcalendar")]
		public IEnumerable<QuarterlyFiscalCalendar> TransactioncurrencyQuarterlyfiscalcalendar
		{
			get { return GetRelatedEntities<QuarterlyFiscalCalendar>("transactioncurrency_quarterlyfiscalcalendar", null); }
			set { SetRelatedEntities("transactioncurrency_quarterlyfiscalcalendar", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'TransactionCurrency_Queue'
        /// </summary>
		[RelationshipSchemaName("TransactionCurrency_Queue")]
		public IEnumerable<Queue> TransactionCurrencyQueue
		{
			get { return GetRelatedEntities<Queue>("TransactionCurrency_Queue", null); }
			set { SetRelatedEntities("TransactionCurrency_Queue", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'TransactionCurrency_QueueItem'
        /// </summary>
		[RelationshipSchemaName("TransactionCurrency_QueueItem")]
		public IEnumerable<QueueItem> TransactionCurrencyQueueItem
		{
			get { return GetRelatedEntities<QueueItem>("TransactionCurrency_QueueItem", null); }
			set { SetRelatedEntities("TransactionCurrency_QueueItem", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'transactioncurrency_quote'
        /// </summary>
		[RelationshipSchemaName("transactioncurrency_quote")]
		public IEnumerable<Quote> TransactioncurrencyQuote
		{
			get { return GetRelatedEntities<Quote>("transactioncurrency_quote", null); }
			set { SetRelatedEntities("transactioncurrency_quote", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'transactioncurrency_quotedetail'
        /// </summary>
		[RelationshipSchemaName("transactioncurrency_quotedetail")]
		public IEnumerable<QuoteProduct> TransactioncurrencyQuotedetail
		{
			get { return GetRelatedEntities<QuoteProduct>("transactioncurrency_quotedetail", null); }
			set { SetRelatedEntities("transactioncurrency_quotedetail", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'TransactionCurrency_ratingmodel'
        /// </summary>
		[RelationshipSchemaName("TransactionCurrency_ratingmodel")]
		public IEnumerable<RatingModel> TransactionCurrencyRatingmodel
		{
			get { return GetRelatedEntities<RatingModel>("TransactionCurrency_ratingmodel", null); }
			set { SetRelatedEntities("TransactionCurrency_ratingmodel", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'TransactionCurrency_ratingvalue'
        /// </summary>
		[RelationshipSchemaName("TransactionCurrency_ratingvalue")]
		public IEnumerable<RatingValue> TransactionCurrencyRatingvalue
		{
			get { return GetRelatedEntities<RatingValue>("TransactionCurrency_ratingvalue", null); }
			set { SetRelatedEntities("TransactionCurrency_ratingvalue", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'TransactionCurrency_recommendeddocument'
        /// </summary>
		[RelationshipSchemaName("TransactionCurrency_recommendeddocument")]
		public IEnumerable<DocumentSuggestions> TransactionCurrencyRecommendeddocument
		{
			get { return GetRelatedEntities<DocumentSuggestions>("TransactionCurrency_recommendeddocument", null); }
			set { SetRelatedEntities("TransactionCurrency_recommendeddocument", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'TransactionCurrency_RecurringAppointmentMaster'
        /// </summary>
		[RelationshipSchemaName("TransactionCurrency_RecurringAppointmentMaster")]
		public IEnumerable<RecurringAppointment> TransactionCurrencyRecurringAppointmentMaster
		{
			get { return GetRelatedEntities<RecurringAppointment>("TransactionCurrency_RecurringAppointmentMaster", null); }
			set { SetRelatedEntities("TransactionCurrency_RecurringAppointmentMaster", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'TransactionCurrency_ReportCategory'
        /// </summary>
		[RelationshipSchemaName("TransactionCurrency_ReportCategory")]
		public IEnumerable<ReportRelatedCategory> TransactionCurrencyReportCategory
		{
			get { return GetRelatedEntities<ReportRelatedCategory>("TransactionCurrency_ReportCategory", null); }
			set { SetRelatedEntities("TransactionCurrency_ReportCategory", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'TransactionCurrency_SalesLiterature'
        /// </summary>
		[RelationshipSchemaName("TransactionCurrency_SalesLiterature")]
		public IEnumerable<SalesLiterature> TransactionCurrencySalesLiterature
		{
			get { return GetRelatedEntities<SalesLiterature>("TransactionCurrency_SalesLiterature", null); }
			set { SetRelatedEntities("TransactionCurrency_SalesLiterature", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'transactioncurrency_salesorder'
        /// </summary>
		[RelationshipSchemaName("transactioncurrency_salesorder")]
		public IEnumerable<Order> TransactioncurrencySalesorder
		{
			get { return GetRelatedEntities<Order>("transactioncurrency_salesorder", null); }
			set { SetRelatedEntities("transactioncurrency_salesorder", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'transactioncurrency_salesorderdetail'
        /// </summary>
		[RelationshipSchemaName("transactioncurrency_salesorderdetail")]
		public IEnumerable<OrderProduct> TransactioncurrencySalesorderdetail
		{
			get { return GetRelatedEntities<OrderProduct>("transactioncurrency_salesorderdetail", null); }
			set { SetRelatedEntities("transactioncurrency_salesorderdetail", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'transactioncurrency_semiannualfiscalcalendar'
        /// </summary>
		[RelationshipSchemaName("transactioncurrency_semiannualfiscalcalendar")]
		public IEnumerable<SemiannualFiscalCalendar> TransactioncurrencySemiannualfiscalcalendar
		{
			get { return GetRelatedEntities<SemiannualFiscalCalendar>("transactioncurrency_semiannualfiscalcalendar", null); }
			set { SetRelatedEntities("transactioncurrency_semiannualfiscalcalendar", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'TransactionCurrency_ServiceAppointment'
        /// </summary>
		[RelationshipSchemaName("TransactionCurrency_ServiceAppointment")]
		public IEnumerable<ServiceActivity> TransactionCurrencyServiceAppointment
		{
			get { return GetRelatedEntities<ServiceActivity>("TransactionCurrency_ServiceAppointment", null); }
			set { SetRelatedEntities("TransactionCurrency_ServiceAppointment", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'TransactionCurrency_SharePointDocumentLocation'
        /// </summary>
		[RelationshipSchemaName("TransactionCurrency_SharePointDocumentLocation")]
		public IEnumerable<DocumentLocation> TransactionCurrencySharePointDocumentLocation
		{
			get { return GetRelatedEntities<DocumentLocation>("TransactionCurrency_SharePointDocumentLocation", null); }
			set { SetRelatedEntities("TransactionCurrency_SharePointDocumentLocation", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'TransactionCurrency_SharePointSite'
        /// </summary>
		[RelationshipSchemaName("TransactionCurrency_SharePointSite")]
		public IEnumerable<SharePointSite> TransactionCurrencySharePointSite
		{
			get { return GetRelatedEntities<SharePointSite>("TransactionCurrency_SharePointSite", null); }
			set { SetRelatedEntities("TransactionCurrency_SharePointSite", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'TransactionCurrency_SLA'
        /// </summary>
		[RelationshipSchemaName("TransactionCurrency_SLA")]
		public IEnumerable<SLA> TransactionCurrencySLA
		{
			get { return GetRelatedEntities<SLA>("TransactionCurrency_SLA", null); }
			set { SetRelatedEntities("TransactionCurrency_SLA", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'TransactionCurrency_SLAItem'
        /// </summary>
		[RelationshipSchemaName("TransactionCurrency_SLAItem")]
		public IEnumerable<SLAItem> TransactionCurrencySLAItem
		{
			get { return GetRelatedEntities<SLAItem>("TransactionCurrency_SLAItem", null); }
			set { SetRelatedEntities("TransactionCurrency_SLAItem", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'TransactionCurrency_slakpiinstance'
        /// </summary>
		[RelationshipSchemaName("TransactionCurrency_slakpiinstance")]
		public IEnumerable<SLAKPIInstance> TransactionCurrencySlakpiinstance
		{
			get { return GetRelatedEntities<SLAKPIInstance>("TransactionCurrency_slakpiinstance", null); }
			set { SetRelatedEntities("TransactionCurrency_slakpiinstance", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'transactioncurrency_socialactivity'
        /// </summary>
		[RelationshipSchemaName("transactioncurrency_socialactivity")]
		public IEnumerable<SocialActivity> TransactioncurrencySocialactivity
		{
			get { return GetRelatedEntities<SocialActivity>("transactioncurrency_socialactivity", null); }
			set { SetRelatedEntities("transactioncurrency_socialactivity", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'transactioncurrency_SocialProfile'
        /// </summary>
		[RelationshipSchemaName("transactioncurrency_SocialProfile")]
		public IEnumerable<SocialProfile> TransactioncurrencySocialProfile
		{
			get { return GetRelatedEntities<SocialProfile>("transactioncurrency_SocialProfile", null); }
			set { SetRelatedEntities("transactioncurrency_SocialProfile", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'TransactionCurrency_SyncErrors'
        /// </summary>
		[RelationshipSchemaName("TransactionCurrency_SyncErrors")]
		public IEnumerable<SyncError> TransactionCurrencySyncErrors
		{
			get { return GetRelatedEntities<SyncError>("TransactionCurrency_SyncErrors", null); }
			set { SetRelatedEntities("TransactionCurrency_SyncErrors", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'TransactionCurrency_SystemUser'
        /// </summary>
		[RelationshipSchemaName("TransactionCurrency_SystemUser")]
		public IEnumerable<User> TransactionCurrencySystemUser
		{
			get { return GetRelatedEntities<User>("TransactionCurrency_SystemUser", null); }
			set { SetRelatedEntities("TransactionCurrency_SystemUser", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'TransactionCurrency_Task'
        /// </summary>
		[RelationshipSchemaName("TransactionCurrency_Task")]
		public IEnumerable<Task> TransactionCurrencyTask
		{
			get { return GetRelatedEntities<Task>("TransactionCurrency_Task", null); }
			set { SetRelatedEntities("TransactionCurrency_Task", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'TransactionCurrency_Team'
        /// </summary>
		[RelationshipSchemaName("TransactionCurrency_Team")]
		public IEnumerable<Team> TransactionCurrencyTeam
		{
			get { return GetRelatedEntities<Team>("TransactionCurrency_Team", null); }
			set { SetRelatedEntities("TransactionCurrency_Team", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'TransactionCurrency_Territory'
        /// </summary>
		[RelationshipSchemaName("TransactionCurrency_Territory")]
		public IEnumerable<Territory> TransactionCurrencyTerritory
		{
			get { return GetRelatedEntities<Territory>("TransactionCurrency_Territory", null); }
			set { SetRelatedEntities("TransactionCurrency_Territory", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'TransactionCurrency_Theme'
        /// </summary>
		[RelationshipSchemaName("TransactionCurrency_Theme")]
		public IEnumerable<Theme> TransactionCurrencyTheme
		{
			get { return GetRelatedEntities<Theme>("TransactionCurrency_Theme", null); }
			set { SetRelatedEntities("TransactionCurrency_Theme", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'transactioncurrency_translationprocess'
        /// </summary>
		[RelationshipSchemaName("transactioncurrency_translationprocess")]
		public IEnumerable<TranslationProcess> TransactioncurrencyTranslationprocess
		{
			get { return GetRelatedEntities<TranslationProcess>("transactioncurrency_translationprocess", null); }
			set { SetRelatedEntities("transactioncurrency_translationprocess", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'TransactionCurrency_UserMapping'
        /// </summary>
		[RelationshipSchemaName("TransactionCurrency_UserMapping")]
		public IEnumerable<UserMapping> TransactionCurrencyUserMapping
		{
			get { return GetRelatedEntities<UserMapping>("TransactionCurrency_UserMapping", null); }
			set { SetRelatedEntities("TransactionCurrency_UserMapping", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'transactioncurrency_usersettings'
        /// </summary>
		[RelationshipSchemaName("transactioncurrency_usersettings")]
		public IEnumerable<UserSettings> TransactioncurrencyUsersettings
		{
			get { return GetRelatedEntities<UserSettings>("transactioncurrency_usersettings", null); }
			set { SetRelatedEntities("transactioncurrency_usersettings", null, value); }
		}
		#endregion

		#region Actions
		#endregion

		#region OptionSetEnums
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
			Active_Active = 1, 
		
			[Label("Inactive")]
			[Description(@"")]
			Inactive_Inactive = 2, 
		}
		
		#endregion	

		#region Properties
		public static class Properties 
		{
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

			/// <summary>currencyname</summary>
			public const string CurrencyName = "currencyname";

			/// <summary>currencyprecision</summary>
			public const string CurrencyPrecision = "currencyprecision";

			/// <summary>currencysymbol</summary>
			public const string CurrencySymbol = "currencysymbol";

			/// <summary>entityimage_timestamp</summary>
			public const string EntityimageTimestamp = "entityimage_timestamp";

			/// <summary>entityimage_url</summary>
			public const string EntityimageUrl = "entityimage_url";

			/// <summary>entityimageid</summary>
			public const string EntityImageId = "entityimageid";

			/// <summary>exchangerate</summary>
			public const string ExchangeRate = "exchangerate";

			/// <summary>importsequencenumber</summary>
			public const string ImportSequenceNumber = "importsequencenumber";

			/// <summary>isocurrencycode</summary>
			public const string CurrencyCode = "isocurrencycode";

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
			public const string Organization = "organizationid";

			/// <summary>overriddencreatedon</summary>
			public const string RecordCreatedOn = "overriddencreatedon";

			/// <summary>statecode</summary>
			public const string Status = "statecode";

			/// <summary>statuscode</summary>
			public const string StatusReason = "statuscode";

			/// <summary>transactioncurrencyid</summary>
			public const string TransactionCurrencyId = "transactioncurrencyid";

			/// <summary>uniquedscid</summary>
			public const string UniqueDscId = "uniquedscid";

			/// <summary>versionnumber</summary>
			public const string VersionNumber = "versionnumber";

		}
		#endregion

		#region Schemas
		public static class Schemas 
		{
			/// <summary>1:N basecurrency_organization</summary>
			public const string BasecurrencyOrganization = "basecurrency_organization";

			/// <summary>1:N bulkoperation_transactioncurrency_transactioncurrencyid</summary>
			public const string BulkoperationTransactioncurrencyTransactioncurrencyid = "bulkoperation_transactioncurrency_transactioncurrencyid";

			/// <summary>1:N DynamicPropertyAssociation_TransactionCurrency</summary>
			public const string DynamicPropertyAssociationTransactionCurrency = "DynamicPropertyAssociation_TransactionCurrency";

			/// <summary>1:N DynamicPropertyOptionSetItem_TransactionCurrency</summary>
			public const string DynamicPropertyOptionSetItemTransactionCurrency = "DynamicPropertyOptionSetItem_TransactionCurrency";

			/// <summary>1:N incidentresolution_transactioncurrency_transactioncurrencyid</summary>
			public const string IncidentresolutionTransactioncurrencyTransactioncurrencyid = "incidentresolution_transactioncurrency_transactioncurrencyid";

			/// <summary>1:N orderclose_transactioncurrency_transactioncurrencyid</summary>
			public const string OrdercloseTransactioncurrencyTransactioncurrencyid = "orderclose_transactioncurrency_transactioncurrencyid";

			/// <summary>1:N quoteclose_transactioncurrency_transactioncurrencyid</summary>
			public const string QuotecloseTransactioncurrencyTransactioncurrencyid = "quoteclose_transactioncurrency_transactioncurrencyid";

			/// <summary>1:N transactioncurrency_account</summary>
			public const string TransactioncurrencyAccount = "transactioncurrency_account";

			/// <summary>1:N transactioncurrency_actioncard</summary>
			public const string TransactioncurrencyActioncard = "transactioncurrency_actioncard";

			/// <summary>1:N TransactionCurrency_ActionCardUserState</summary>
			public const string TransactionCurrencyActionCardUserState = "TransactionCurrency_ActionCardUserState";

			/// <summary>1:N TransactionCurrency_ActivityPointer</summary>
			public const string TransactionCurrencyActivityPointer = "TransactionCurrency_ActivityPointer";

			/// <summary>1:N transactioncurrency_annualfiscalcalendar</summary>
			public const string TransactioncurrencyAnnualfiscalcalendar = "transactioncurrency_annualfiscalcalendar";

			/// <summary>1:N TransactionCurrency_Appointment</summary>
			public const string TransactionCurrencyAppointment = "TransactionCurrency_Appointment";

			/// <summary>1:N TransactionCurrency_AsyncOperations</summary>
			public const string TransactionCurrencyAsyncOperations = "TransactionCurrency_AsyncOperations";

			/// <summary>1:N TransactionCurrency_bookableresource</summary>
			public const string TransactionCurrencyBookableresource = "TransactionCurrency_bookableresource";

			/// <summary>1:N TransactionCurrency_bookableresourcebooking</summary>
			public const string TransactionCurrencyBookableresourcebooking = "TransactionCurrency_bookableresourcebooking";

			/// <summary>1:N TransactionCurrency_bookableresourcebookingheader</summary>
			public const string TransactionCurrencyBookableresourcebookingheader = "TransactionCurrency_bookableresourcebookingheader";

			/// <summary>1:N TransactionCurrency_bookableresourcecategory</summary>
			public const string TransactionCurrencyBookableresourcecategory = "TransactionCurrency_bookableresourcecategory";

			/// <summary>1:N TransactionCurrency_bookableresourcecategoryassn</summary>
			public const string TransactionCurrencyBookableresourcecategoryassn = "TransactionCurrency_bookableresourcecategoryassn";

			/// <summary>1:N TransactionCurrency_bookableresourcecharacteristic</summary>
			public const string TransactionCurrencyBookableresourcecharacteristic = "TransactionCurrency_bookableresourcecharacteristic";

			/// <summary>1:N TransactionCurrency_bookableresourcegroup</summary>
			public const string TransactionCurrencyBookableresourcegroup = "TransactionCurrency_bookableresourcegroup";

			/// <summary>1:N TransactionCurrency_bookingstatus</summary>
			public const string TransactionCurrencyBookingstatus = "TransactionCurrency_bookingstatus";

			/// <summary>1:N TransactionCurrency_BusinessUnit</summary>
			public const string TransactionCurrencyBusinessUnit = "TransactionCurrency_BusinessUnit";

			/// <summary>1:N transactioncurrency_campaign</summary>
			public const string TransactioncurrencyCampaign = "transactioncurrency_campaign";

			/// <summary>1:N transactioncurrency_campaignactivity</summary>
			public const string TransactioncurrencyCampaignactivity = "transactioncurrency_campaignactivity";

			/// <summary>1:N TransactionCurrency_CampaignResponse</summary>
			public const string TransactionCurrencyCampaignResponse = "TransactionCurrency_CampaignResponse";

			/// <summary>1:N transactioncurrency_category</summary>
			public const string TransactioncurrencyCategory = "transactioncurrency_category";

			/// <summary>1:N TransactionCurrency_characteristic</summary>
			public const string TransactionCurrencyCharacteristic = "TransactionCurrency_characteristic";

			/// <summary>1:N transactioncurrency_competitor</summary>
			public const string TransactioncurrencyCompetitor = "transactioncurrency_competitor";

			/// <summary>1:N TransactionCurrency_Connection</summary>
			public const string TransactionCurrencyConnection = "TransactionCurrency_Connection";

			/// <summary>1:N transactioncurrency_contact</summary>
			public const string TransactioncurrencyContact = "transactioncurrency_contact";

			/// <summary>1:N transactioncurrency_contract</summary>
			public const string TransactioncurrencyContract = "transactioncurrency_contract";

			/// <summary>1:N transactioncurrency_contractdetail</summary>
			public const string TransactioncurrencyContractdetail = "transactioncurrency_contractdetail";

			/// <summary>1:N TransactionCurrency_CustomerAddress</summary>
			public const string TransactionCurrencyCustomerAddress = "TransactionCurrency_CustomerAddress";

			/// <summary>1:N transactioncurrency_discount</summary>
			public const string TransactioncurrencyDiscount = "transactioncurrency_discount";

			/// <summary>1:N transactioncurrency_discounttype</summary>
			public const string TransactioncurrencyDiscounttype = "transactioncurrency_discounttype";

			/// <summary>1:N TransactionCurrency_DuplicateBaseRecord</summary>
			public const string TransactionCurrencyDuplicateBaseRecord = "TransactionCurrency_DuplicateBaseRecord";

			/// <summary>1:N TransactionCurrency_DuplicateMatchingRecord</summary>
			public const string TransactionCurrencyDuplicateMatchingRecord = "TransactionCurrency_DuplicateMatchingRecord";

			/// <summary>1:N TransactionCurrency_Dynamicpropertyinsatance</summary>
			public const string TransactionCurrencyDynamicpropertyinsatance = "TransactionCurrency_Dynamicpropertyinsatance";

			/// <summary>1:N TransactionCurrency_Email</summary>
			public const string TransactionCurrencyEmail = "TransactionCurrency_Email";

			/// <summary>1:N TransactionCurrency_Entitlement</summary>
			public const string TransactionCurrencyEntitlement = "TransactionCurrency_Entitlement";

			/// <summary>1:N TransactionCurrency_entitlementchannel</summary>
			public const string TransactionCurrencyEntitlementchannel = "TransactionCurrency_entitlementchannel";

			/// <summary>1:N TransactionCurrency_entitlementtemplate</summary>
			public const string TransactionCurrencyEntitlementtemplate = "TransactionCurrency_entitlementtemplate";

			/// <summary>1:N TransactionCurrency_entitlementtemplatechannel</summary>
			public const string TransactionCurrencyEntitlementtemplatechannel = "TransactionCurrency_entitlementtemplatechannel";

			/// <summary>1:N TransactionCurrency_Equipment</summary>
			public const string TransactionCurrencyEquipment = "TransactionCurrency_Equipment";

			/// <summary>1:N transactioncurrency_expiredprocess</summary>
			public const string TransactioncurrencyExpiredprocess = "transactioncurrency_expiredprocess";

			/// <summary>1:N TransactionCurrency_Fax</summary>
			public const string TransactionCurrencyFax = "TransactionCurrency_Fax";

			/// <summary>1:N transactioncurrency_feedback</summary>
			public const string TransactioncurrencyFeedback = "transactioncurrency_feedback";

			/// <summary>1:N transactioncurrency_fixedmonthlyfiscalcalendar</summary>
			public const string TransactioncurrencyFixedmonthlyfiscalcalendar = "transactioncurrency_fixedmonthlyfiscalcalendar";

			/// <summary>1:N TransactionCurrency_Goal</summary>
			public const string TransactionCurrencyGoal = "TransactionCurrency_Goal";

			/// <summary>1:N TransactionCurrency_Incident</summary>
			public const string TransactionCurrencyIncident = "TransactionCurrency_Incident";

			/// <summary>1:N TransactionCurrency_InteractionForEmail</summary>
			public const string TransactionCurrencyInteractionForEmail = "TransactionCurrency_InteractionForEmail";

			/// <summary>1:N transactioncurrency_invoice</summary>
			public const string TransactioncurrencyInvoice = "transactioncurrency_invoice";

			/// <summary>1:N transactioncurrency_invoicedetail</summary>
			public const string TransactioncurrencyInvoicedetail = "transactioncurrency_invoicedetail";

			/// <summary>1:N TransactionCurrency_KbArticle</summary>
			public const string TransactionCurrencyKbArticle = "TransactionCurrency_KbArticle";

			/// <summary>1:N TransactionCurrency_knowledgearticle</summary>
			public const string TransactionCurrencyKnowledgearticle = "TransactionCurrency_knowledgearticle";

			/// <summary>1:N transactioncurrency_knowledgearticleincident</summary>
			public const string TransactioncurrencyKnowledgearticleincident = "transactioncurrency_knowledgearticleincident";

			/// <summary>1:N transactioncurrency_knowledgearticleviews</summary>
			public const string TransactioncurrencyKnowledgearticleviews = "transactioncurrency_knowledgearticleviews";

			/// <summary>1:N TransactionCurrency_KnowledgeBaseRecord</summary>
			public const string TransactionCurrencyKnowledgeBaseRecord = "TransactionCurrency_KnowledgeBaseRecord";

			/// <summary>1:N transactioncurrency_lead</summary>
			public const string TransactioncurrencyLead = "transactioncurrency_lead";

			/// <summary>1:N TransactionCurrency_LeadAddress</summary>
			public const string TransactionCurrencyLeadAddress = "TransactionCurrency_LeadAddress";

			/// <summary>1:N transactioncurrency_leadtoopportunitysalesprocess</summary>
			public const string TransactioncurrencyLeadtoopportunitysalesprocess = "transactioncurrency_leadtoopportunitysalesprocess";

			/// <summary>1:N TransactionCurrency_Letter</summary>
			public const string TransactionCurrencyLetter = "TransactionCurrency_Letter";

			/// <summary>1:N transactioncurrency_list</summary>
			public const string TransactioncurrencyList = "transactioncurrency_list";

			/// <summary>1:N TransactionCurrency_MailMergeTemplate</summary>
			public const string TransactionCurrencyMailMergeTemplate = "TransactionCurrency_MailMergeTemplate";

			/// <summary>1:N transactioncurrency_monthlyfiscalcalendar</summary>
			public const string TransactioncurrencyMonthlyfiscalcalendar = "transactioncurrency_monthlyfiscalcalendar";

			/// <summary>1:N transactioncurrency_newprocess</summary>
			public const string TransactioncurrencyNewprocess = "transactioncurrency_newprocess";

			/// <summary>1:N TransactionCurrency_officegraphdocument</summary>
			public const string TransactionCurrencyOfficegraphdocument = "TransactionCurrency_officegraphdocument";

			/// <summary>1:N transactioncurrency_opportunity</summary>
			public const string TransactioncurrencyOpportunity = "transactioncurrency_opportunity";

			/// <summary>1:N transactioncurrency_opportunityclose</summary>
			public const string TransactioncurrencyOpportunityclose = "transactioncurrency_opportunityclose";

			/// <summary>1:N transactioncurrency_opportunityproduct</summary>
			public const string TransactioncurrencyOpportunityproduct = "transactioncurrency_opportunityproduct";

			/// <summary>1:N transactioncurrency_opportunitysalesprocess</summary>
			public const string TransactioncurrencyOpportunitysalesprocess = "transactioncurrency_opportunitysalesprocess";

			/// <summary>1:N TransactionCurrency_PhoneCall</summary>
			public const string TransactionCurrencyPhoneCall = "TransactionCurrency_PhoneCall";

			/// <summary>1:N transactioncurrency_phonetocaseprocess</summary>
			public const string TransactioncurrencyPhonetocaseprocess = "transactioncurrency_phonetocaseprocess";

			/// <summary>1:N transactioncurrency_position</summary>
			public const string TransactioncurrencyPosition = "transactioncurrency_position";

			/// <summary>1:N transactioncurrency_pricelevel</summary>
			public const string TransactioncurrencyPricelevel = "transactioncurrency_pricelevel";

			/// <summary>1:N TransactionCurrency_ProcessSessions</summary>
			public const string TransactionCurrencyProcessSessions = "TransactionCurrency_ProcessSessions";

			/// <summary>1:N transactioncurrency_product</summary>
			public const string TransactioncurrencyProduct = "transactioncurrency_product";

			/// <summary>1:N transactioncurrency_ProductAssociation</summary>
			public const string TransactioncurrencyProductAssociation = "transactioncurrency_ProductAssociation";

			/// <summary>1:N transactioncurrency_productpricelevel</summary>
			public const string TransactioncurrencyProductpricelevel = "transactioncurrency_productpricelevel";

			/// <summary>1:N transactioncurrency_ProductSubstitute</summary>
			public const string TransactioncurrencyProductSubstitute = "transactioncurrency_ProductSubstitute";

			/// <summary>1:N transactioncurrency_quarterlyfiscalcalendar</summary>
			public const string TransactioncurrencyQuarterlyfiscalcalendar = "transactioncurrency_quarterlyfiscalcalendar";

			/// <summary>1:N TransactionCurrency_Queue</summary>
			public const string TransactionCurrencyQueue = "TransactionCurrency_Queue";

			/// <summary>1:N TransactionCurrency_QueueItem</summary>
			public const string TransactionCurrencyQueueItem = "TransactionCurrency_QueueItem";

			/// <summary>1:N transactioncurrency_quote</summary>
			public const string TransactioncurrencyQuote = "transactioncurrency_quote";

			/// <summary>1:N transactioncurrency_quotedetail</summary>
			public const string TransactioncurrencyQuotedetail = "transactioncurrency_quotedetail";

			/// <summary>1:N TransactionCurrency_ratingmodel</summary>
			public const string TransactionCurrencyRatingmodel = "TransactionCurrency_ratingmodel";

			/// <summary>1:N TransactionCurrency_ratingvalue</summary>
			public const string TransactionCurrencyRatingvalue = "TransactionCurrency_ratingvalue";

			/// <summary>1:N TransactionCurrency_recommendeddocument</summary>
			public const string TransactionCurrencyRecommendeddocument = "TransactionCurrency_recommendeddocument";

			/// <summary>1:N TransactionCurrency_RecurringAppointmentMaster</summary>
			public const string TransactionCurrencyRecurringAppointmentMaster = "TransactionCurrency_RecurringAppointmentMaster";

			/// <summary>1:N TransactionCurrency_ReportCategory</summary>
			public const string TransactionCurrencyReportCategory = "TransactionCurrency_ReportCategory";

			/// <summary>1:N TransactionCurrency_SalesLiterature</summary>
			public const string TransactionCurrencySalesLiterature = "TransactionCurrency_SalesLiterature";

			/// <summary>1:N transactioncurrency_salesorder</summary>
			public const string TransactioncurrencySalesorder = "transactioncurrency_salesorder";

			/// <summary>1:N transactioncurrency_salesorderdetail</summary>
			public const string TransactioncurrencySalesorderdetail = "transactioncurrency_salesorderdetail";

			/// <summary>1:N transactioncurrency_semiannualfiscalcalendar</summary>
			public const string TransactioncurrencySemiannualfiscalcalendar = "transactioncurrency_semiannualfiscalcalendar";

			/// <summary>1:N TransactionCurrency_ServiceAppointment</summary>
			public const string TransactionCurrencyServiceAppointment = "TransactionCurrency_ServiceAppointment";

			/// <summary>1:N TransactionCurrency_SharePointDocumentLocation</summary>
			public const string TransactionCurrencySharePointDocumentLocation = "TransactionCurrency_SharePointDocumentLocation";

			/// <summary>1:N TransactionCurrency_SharePointSite</summary>
			public const string TransactionCurrencySharePointSite = "TransactionCurrency_SharePointSite";

			/// <summary>1:N TransactionCurrency_SLA</summary>
			public const string TransactionCurrencySLA = "TransactionCurrency_SLA";

			/// <summary>1:N TransactionCurrency_SLAItem</summary>
			public const string TransactionCurrencySLAItem = "TransactionCurrency_SLAItem";

			/// <summary>1:N TransactionCurrency_slakpiinstance</summary>
			public const string TransactionCurrencySlakpiinstance = "TransactionCurrency_slakpiinstance";

			/// <summary>1:N transactioncurrency_socialactivity</summary>
			public const string TransactioncurrencySocialactivity = "transactioncurrency_socialactivity";

			/// <summary>1:N transactioncurrency_SocialProfile</summary>
			public const string TransactioncurrencySocialProfile = "transactioncurrency_SocialProfile";

			/// <summary>1:N TransactionCurrency_SyncErrors</summary>
			public const string TransactionCurrencySyncErrors = "TransactionCurrency_SyncErrors";

			/// <summary>1:N TransactionCurrency_SystemUser</summary>
			public const string TransactionCurrencySystemUser = "TransactionCurrency_SystemUser";

			/// <summary>1:N TransactionCurrency_Task</summary>
			public const string TransactionCurrencyTask = "TransactionCurrency_Task";

			/// <summary>1:N TransactionCurrency_Team</summary>
			public const string TransactionCurrencyTeam = "TransactionCurrency_Team";

			/// <summary>1:N TransactionCurrency_Territory</summary>
			public const string TransactionCurrencyTerritory = "TransactionCurrency_Territory";

			/// <summary>1:N TransactionCurrency_Theme</summary>
			public const string TransactionCurrencyTheme = "TransactionCurrency_Theme";

			/// <summary>1:N transactioncurrency_translationprocess</summary>
			public const string TransactioncurrencyTranslationprocess = "transactioncurrency_translationprocess";

			/// <summary>1:N TransactionCurrency_UserMapping</summary>
			public const string TransactionCurrencyUserMapping = "TransactionCurrency_UserMapping";

			/// <summary>1:N transactioncurrency_usersettings</summary>
			public const string TransactioncurrencyUsersettings = "transactioncurrency_usersettings";

		}
		#endregion
	}
}

