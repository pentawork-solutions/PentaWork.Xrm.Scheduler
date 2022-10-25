using System;
using System.Linq;
using System.Diagnostics;
using System.ComponentModel;
using Microsoft.Xrm.Sdk; 
using Microsoft.Xrm.Sdk.Client;
using System.Collections.Generic;

namespace PentaWork.Xrm.Scheduler.Proxies.Entities
{
	[DebuggerDisplay("{ProcessStageName}")] 	
	[EntityLogicalName("processstage")]
	public sealed class ProcessStage : Entity
	{	
		public static readonly int? EntityTypeCode = 4724;
		public new const string LogicalName = "processstage";
		public const string PrimaryIdAttribute = "processstageid";
		public const string PrimaryNameAttribute = "stagename";
	
		public ProcessStage() : base("processstage") { }

		#region Attributes
		/// <summary>
        /// clientdata
        /// </summary>
		[DisplayName("Client Data")]
		[AttributeLogicalName("clientdata")]
		public string ClientData
		{	
			get { return GetAttributeValue<string>("clientdata"); }
			set
			{ 
				if(value == ClientData) return;
				SetAttributeValue("clientdata", value);
			}
		}	
			
		/// <summary>
        /// connector
        /// </summary>
		[DisplayName("Connector")]
		[AttributeLogicalName("connector")]
		public string Connector
		{	
			get { return GetAttributeValue<string>("connector"); }
			set
			{ 
				if(value == Connector) return;
				SetAttributeValue("connector", value);
			}
		}	
			
		/// <summary>
        /// istrigger
        /// </summary>
		[DisplayName("Is Trigger")]
		[AttributeLogicalName("istrigger")]
		public bool? IsTrigger
		{	
			get { return GetAttributeValue<bool?>("istrigger"); }
			set
			{ 
				if(value == IsTrigger) return;
				SetAttributeValue("istrigger", value);
			}
		}	
			
		/// <summary>
        /// operationid
        /// </summary>
		[DisplayName("Operation Id")]
		[AttributeLogicalName("operationid")]
		public string OperationId
		{	
			get { return GetAttributeValue<string>("operationid"); }
			set
			{ 
				if(value == OperationId) return;
				SetAttributeValue("operationid", value);
			}
		}	
			
		/// <summary>
        /// operationkind
        /// </summary>
		[DisplayName("Operation Kind")]
		[AttributeLogicalName("operationkind")]
		public eOperationKind? OperationKind
		{	
			get 
			{ 
				var optionSetValue = GetAttributeValue<OptionSetValue>("operationkind");
				if (optionSetValue != null) return (eOperationKind)optionSetValue.Value;
				else return null;
			}
			set 
			{ 
				if(value == OperationKind) return;

				OptionSetValue optionSetValue = null;
				if(value != null) optionSetValue = new OptionSetValue((int)value);
				SetAttributeValue("operationkind", optionSetValue); 
			}
		}

		/// <summary>
        /// operationtype
        /// </summary>
		[DisplayName("Operation Type")]
		[AttributeLogicalName("operationtype")]
		public eOperationType? OperationType
		{	
			get 
			{ 
				var optionSetValue = GetAttributeValue<OptionSetValue>("operationtype");
				if (optionSetValue != null) return (eOperationType)optionSetValue.Value;
				else return null;
			}
			set 
			{ 
				if(value == OperationType) return;

				OptionSetValue optionSetValue = null;
				if(value != null) optionSetValue = new OptionSetValue((int)value);
				SetAttributeValue("operationtype", optionSetValue); 
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
        /// owningbusinessunit
        /// </summary>
		[DisplayName("Owning Business Unit")]
		[AttributeLogicalName("owningbusinessunit")]
		public Guid OwningBusinessUnitId
		{	
			get { return GetAttributeValue<Guid>("owningbusinessunit"); }
			set
			{ 
				if(value == OwningBusinessUnitId) return;
				SetAttributeValue("owningbusinessunit", value);
			}
		}	
			
		/// <summary>
        /// primaryentitytypecode
        /// </summary>
		[DisplayName("Primary Entity")]
		[AttributeLogicalName("primaryentitytypecode")]
		public string PrimaryEntity
		{	
			get { return GetAttributeValue<string>("primaryentitytypecode"); }
			set
			{ 
				if(value == PrimaryEntity) return;
				SetAttributeValue("primaryentitytypecode", value);
			}
		}	
			
		/// <summary>
        /// processid
        /// </summary>
		[DisplayName("Process")]
		[AttributeLogicalName("processid")]
		public EntityReference Process
		{	
			get { return GetAttributeValue<EntityReference>("processid"); }
			set
			{ 
				if(value == Process) return;
				SetAttributeValue("processid", value);
			}
		}	
			
		/// <summary>
        /// processidname
        /// </summary>
		[DisplayName("processidname")]
		[AttributeLogicalName("processidname")]
		public string Processidname
		{	
			get { return GetAttributeValue<string>("processidname"); }
			set
			{ 
				if(value == Processidname) return;
				SetAttributeValue("processidname", value);
			}
		}	
			
		/// <summary>
        /// processstageid
        /// </summary>
		[DisplayName("Process Stage")]
		[AttributeLogicalName("processstageid")]
		public override Guid Id
		{
			get => base.Id;
			set { base.Id = value; SetAttributeValue("processstageid", value); }
		}

							/// <summary>
        /// stagecategory
        /// </summary>
		[DisplayName("Stage Category")]
		[AttributeLogicalName("stagecategory")]
		public egStageCategory? StageCategory
		{	
			get 
			{ 
				var optionSetValue = GetAttributeValue<OptionSetValue>("stagecategory");
				if (optionSetValue != null) return (egStageCategory)optionSetValue.Value;
				else return null;
			}
			set 
			{ 
				if(value == StageCategory) return;

				OptionSetValue optionSetValue = null;
				if(value != null) optionSetValue = new OptionSetValue((int)value);
				SetAttributeValue("stagecategory", optionSetValue); 
			}
		}

		/// <summary>
        /// stagename
        /// </summary>
		[DisplayName("Process Stage Name")]
		[AttributeLogicalName("stagename")]
		public string ProcessStageName
		{	
			get { return GetAttributeValue<string>("stagename"); }
			set
			{ 
				if(value == ProcessStageName) return;
				SetAttributeValue("stagename", value);
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
        /// 1:N Get entities for 'lk_expiredprocess_activestageid'
        /// </summary>
		[RelationshipSchemaName("lk_expiredprocess_activestageid")]
		public IEnumerable<ExpiredProcess> LkExpiredprocessActivestageid
		{
			get { return GetRelatedEntities<ExpiredProcess>("lk_expiredprocess_activestageid", null); }
			set { SetRelatedEntities("lk_expiredprocess_activestageid", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_leadtoopportunitysalesprocess_activestageid'
        /// </summary>
		[RelationshipSchemaName("lk_leadtoopportunitysalesprocess_activestageid")]
		public IEnumerable<LeadToOpportunitySalesProcess> LkLeadtoopportunitysalesprocessActivestageid
		{
			get { return GetRelatedEntities<LeadToOpportunitySalesProcess>("lk_leadtoopportunitysalesprocess_activestageid", null); }
			set { SetRelatedEntities("lk_leadtoopportunitysalesprocess_activestageid", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_newprocess_activestageid'
        /// </summary>
		[RelationshipSchemaName("lk_newprocess_activestageid")]
		public IEnumerable<NewProcess> LkNewprocessActivestageid
		{
			get { return GetRelatedEntities<NewProcess>("lk_newprocess_activestageid", null); }
			set { SetRelatedEntities("lk_newprocess_activestageid", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_opportunitysalesprocess_activestageid'
        /// </summary>
		[RelationshipSchemaName("lk_opportunitysalesprocess_activestageid")]
		public IEnumerable<OpportunitySalesProcess> LkOpportunitysalesprocessActivestageid
		{
			get { return GetRelatedEntities<OpportunitySalesProcess>("lk_opportunitysalesprocess_activestageid", null); }
			set { SetRelatedEntities("lk_opportunitysalesprocess_activestageid", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_phonetocaseprocess_activestageid'
        /// </summary>
		[RelationshipSchemaName("lk_phonetocaseprocess_activestageid")]
		public IEnumerable<PhoneToCaseProcess> LkPhonetocaseprocessActivestageid
		{
			get { return GetRelatedEntities<PhoneToCaseProcess>("lk_phonetocaseprocess_activestageid", null); }
			set { SetRelatedEntities("lk_phonetocaseprocess_activestageid", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_translationprocess_activestageid'
        /// </summary>
		[RelationshipSchemaName("lk_translationprocess_activestageid")]
		public IEnumerable<TranslationProcess> LkTranslationprocessActivestageid
		{
			get { return GetRelatedEntities<TranslationProcess>("lk_translationprocess_activestageid", null); }
			set { SetRelatedEntities("lk_translationprocess_activestageid", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'processstage_account'
        /// </summary>
		[RelationshipSchemaName("processstage_account")]
		public IEnumerable<Account> ProcessstageAccount
		{
			get { return GetRelatedEntities<Account>("processstage_account", null); }
			set { SetRelatedEntities("processstage_account", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'processstage_appointments'
        /// </summary>
		[RelationshipSchemaName("processstage_appointments")]
		public IEnumerable<Appointment> ProcessstageAppointments
		{
			get { return GetRelatedEntities<Appointment>("processstage_appointments", null); }
			set { SetRelatedEntities("processstage_appointments", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'processstage_BookableResource'
        /// </summary>
		[RelationshipSchemaName("processstage_BookableResource")]
		public IEnumerable<BookableResource> ProcessstageBookableResource
		{
			get { return GetRelatedEntities<BookableResource>("processstage_BookableResource", null); }
			set { SetRelatedEntities("processstage_BookableResource", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'processstage_BookableResourceBooking'
        /// </summary>
		[RelationshipSchemaName("processstage_BookableResourceBooking")]
		public IEnumerable<BookableResourceBooking> ProcessstageBookableResourceBooking
		{
			get { return GetRelatedEntities<BookableResourceBooking>("processstage_BookableResourceBooking", null); }
			set { SetRelatedEntities("processstage_BookableResourceBooking", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'processstage_BookableResourceBookingHeader'
        /// </summary>
		[RelationshipSchemaName("processstage_BookableResourceBookingHeader")]
		public IEnumerable<BookableResourceBookingHeader> ProcessstageBookableResourceBookingHeader
		{
			get { return GetRelatedEntities<BookableResourceBookingHeader>("processstage_BookableResourceBookingHeader", null); }
			set { SetRelatedEntities("processstage_BookableResourceBookingHeader", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'processstage_BookableResourceCharacteristic'
        /// </summary>
		[RelationshipSchemaName("processstage_BookableResourceCharacteristic")]
		public IEnumerable<BookableResourceCharacteristic> ProcessstageBookableResourceCharacteristic
		{
			get { return GetRelatedEntities<BookableResourceCharacteristic>("processstage_BookableResourceCharacteristic", null); }
			set { SetRelatedEntities("processstage_BookableResourceCharacteristic", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'processstage_campaignactivities'
        /// </summary>
		[RelationshipSchemaName("processstage_campaignactivities")]
		public IEnumerable<CampaignActivity> ProcessstageCampaignactivities
		{
			get { return GetRelatedEntities<CampaignActivity>("processstage_campaignactivities", null); }
			set { SetRelatedEntities("processstage_campaignactivities", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'processstage_campaignresponses'
        /// </summary>
		[RelationshipSchemaName("processstage_campaignresponses")]
		public IEnumerable<CampaignResponse> ProcessstageCampaignresponses
		{
			get { return GetRelatedEntities<CampaignResponse>("processstage_campaignresponses", null); }
			set { SetRelatedEntities("processstage_campaignresponses", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'processstage_campaigns'
        /// </summary>
		[RelationshipSchemaName("processstage_campaigns")]
		public IEnumerable<Campaign> ProcessstageCampaigns
		{
			get { return GetRelatedEntities<Campaign>("processstage_campaigns", null); }
			set { SetRelatedEntities("processstage_campaigns", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'processstage_competitors'
        /// </summary>
		[RelationshipSchemaName("processstage_competitors")]
		public IEnumerable<Competitor> ProcessstageCompetitors
		{
			get { return GetRelatedEntities<Competitor>("processstage_competitors", null); }
			set { SetRelatedEntities("processstage_competitors", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'processstage_contact'
        /// </summary>
		[RelationshipSchemaName("processstage_contact")]
		public IEnumerable<Contact> ProcessstageContact
		{
			get { return GetRelatedEntities<Contact>("processstage_contact", null); }
			set { SetRelatedEntities("processstage_contact", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'processstage_emails'
        /// </summary>
		[RelationshipSchemaName("processstage_emails")]
		public IEnumerable<Email> ProcessstageEmails
		{
			get { return GetRelatedEntities<Email>("processstage_emails", null); }
			set { SetRelatedEntities("processstage_emails", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'processstage_Entitlement'
        /// </summary>
		[RelationshipSchemaName("processstage_Entitlement")]
		public IEnumerable<Entitlement> ProcessstageEntitlement
		{
			get { return GetRelatedEntities<Entitlement>("processstage_Entitlement", null); }
			set { SetRelatedEntities("processstage_Entitlement", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'processstage_faxes'
        /// </summary>
		[RelationshipSchemaName("processstage_faxes")]
		public IEnumerable<Fax> ProcessstageFaxes
		{
			get { return GetRelatedEntities<Fax>("processstage_faxes", null); }
			set { SetRelatedEntities("processstage_faxes", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'processstage_incident'
        /// </summary>
		[RelationshipSchemaName("processstage_incident")]
		public IEnumerable<Case> ProcessstageIncident
		{
			get { return GetRelatedEntities<Case>("processstage_incident", null); }
			set { SetRelatedEntities("processstage_incident", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'processstage_invoices'
        /// </summary>
		[RelationshipSchemaName("processstage_invoices")]
		public IEnumerable<Invoice> ProcessstageInvoices
		{
			get { return GetRelatedEntities<Invoice>("processstage_invoices", null); }
			set { SetRelatedEntities("processstage_invoices", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'processstage_knowledgearticle'
        /// </summary>
		[RelationshipSchemaName("processstage_knowledgearticle")]
		public IEnumerable<KnowledgeArticle> ProcessstageKnowledgearticle
		{
			get { return GetRelatedEntities<KnowledgeArticle>("processstage_knowledgearticle", null); }
			set { SetRelatedEntities("processstage_knowledgearticle", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'processstage_lead'
        /// </summary>
		[RelationshipSchemaName("processstage_lead")]
		public IEnumerable<Lead> ProcessstageLead
		{
			get { return GetRelatedEntities<Lead>("processstage_lead", null); }
			set { SetRelatedEntities("processstage_lead", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'processstage_letters'
        /// </summary>
		[RelationshipSchemaName("processstage_letters")]
		public IEnumerable<Letter> ProcessstageLetters
		{
			get { return GetRelatedEntities<Letter>("processstage_letters", null); }
			set { SetRelatedEntities("processstage_letters", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'processstage_lists'
        /// </summary>
		[RelationshipSchemaName("processstage_lists")]
		public IEnumerable<MarketingList> ProcessstageLists
		{
			get { return GetRelatedEntities<MarketingList>("processstage_lists", null); }
			set { SetRelatedEntities("processstage_lists", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'processstage_opportunity'
        /// </summary>
		[RelationshipSchemaName("processstage_opportunity")]
		public IEnumerable<Opportunity> ProcessstageOpportunity
		{
			get { return GetRelatedEntities<Opportunity>("processstage_opportunity", null); }
			set { SetRelatedEntities("processstage_opportunity", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'processstage_phonecalls'
        /// </summary>
		[RelationshipSchemaName("processstage_phonecalls")]
		public IEnumerable<PhoneCall> ProcessstagePhonecalls
		{
			get { return GetRelatedEntities<PhoneCall>("processstage_phonecalls", null); }
			set { SetRelatedEntities("processstage_phonecalls", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'processstage_processstageparameter'
        /// </summary>
		[RelationshipSchemaName("processstage_processstageparameter")]
		public IEnumerable<ProcessStageParameter> ProcessstageProcessstageparameter
		{
			get { return GetRelatedEntities<ProcessStageParameter>("processstage_processstageparameter", null); }
			set { SetRelatedEntities("processstage_processstageparameter", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'processstage_productpricelevels'
        /// </summary>
		[RelationshipSchemaName("processstage_productpricelevels")]
		public IEnumerable<PriceListItem> ProcessstageProductpricelevels
		{
			get { return GetRelatedEntities<PriceListItem>("processstage_productpricelevels", null); }
			set { SetRelatedEntities("processstage_productpricelevels", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'processstage_products'
        /// </summary>
		[RelationshipSchemaName("processstage_products")]
		public IEnumerable<Product> ProcessstageProducts
		{
			get { return GetRelatedEntities<Product>("processstage_products", null); }
			set { SetRelatedEntities("processstage_products", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'processstage_quotes'
        /// </summary>
		[RelationshipSchemaName("processstage_quotes")]
		public IEnumerable<Quote> ProcessstageQuotes
		{
			get { return GetRelatedEntities<Quote>("processstage_quotes", null); }
			set { SetRelatedEntities("processstage_quotes", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'processstage_recurringappointmentmasters'
        /// </summary>
		[RelationshipSchemaName("processstage_recurringappointmentmasters")]
		public IEnumerable<RecurringAppointment> ProcessstageRecurringappointmentmasters
		{
			get { return GetRelatedEntities<RecurringAppointment>("processstage_recurringappointmentmasters", null); }
			set { SetRelatedEntities("processstage_recurringappointmentmasters", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'processstage_salesliteratures'
        /// </summary>
		[RelationshipSchemaName("processstage_salesliteratures")]
		public IEnumerable<SalesLiterature> ProcessstageSalesliteratures
		{
			get { return GetRelatedEntities<SalesLiterature>("processstage_salesliteratures", null); }
			set { SetRelatedEntities("processstage_salesliteratures", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'processstage_salesorders'
        /// </summary>
		[RelationshipSchemaName("processstage_salesorders")]
		public IEnumerable<Order> ProcessstageSalesorders
		{
			get { return GetRelatedEntities<Order>("processstage_salesorders", null); }
			set { SetRelatedEntities("processstage_salesorders", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'ProcessStage_SyncErrors'
        /// </summary>
		[RelationshipSchemaName("ProcessStage_SyncErrors")]
		public IEnumerable<SyncError> ProcessStageSyncErrors
		{
			get { return GetRelatedEntities<SyncError>("ProcessStage_SyncErrors", null); }
			set { SetRelatedEntities("ProcessStage_SyncErrors", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'processstage_systemusers'
        /// </summary>
		[RelationshipSchemaName("processstage_systemusers")]
		public IEnumerable<User> ProcessstageSystemusers
		{
			get { return GetRelatedEntities<User>("processstage_systemusers", null); }
			set { SetRelatedEntities("processstage_systemusers", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'processstage_tasks'
        /// </summary>
		[RelationshipSchemaName("processstage_tasks")]
		public IEnumerable<Task> ProcessstageTasks
		{
			get { return GetRelatedEntities<Task>("processstage_tasks", null); }
			set { SetRelatedEntities("processstage_tasks", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'processstage_teams'
        /// </summary>
		[RelationshipSchemaName("processstage_teams")]
		public IEnumerable<Team> ProcessstageTeams
		{
			get { return GetRelatedEntities<Team>("processstage_teams", null); }
			set { SetRelatedEntities("processstage_teams", null, value); }
		}
		#endregion

		#region Actions
		#endregion

		#region OptionSetEnums
		public enum egStageCategory
		{	
		
			[Label("Qualify")]
			[Description(@"")]
			Qualify = 0, 
		
			[Label("Develop")]
			[Description(@"")]
			Develop = 1, 
		
			[Label("Propose")]
			[Description(@"")]
			Propose = 2, 
		
			[Label("Close")]
			[Description(@"")]
			Close = 3, 
		
			[Label("Identify")]
			[Description(@"")]
			Identify = 4, 
		
			[Label("Research")]
			[Description(@"")]
			Research = 5, 
		
			[Label("Resolve")]
			[Description(@"")]
			Resolve = 6, 
		
			[Label("Approval")]
			[Description(@"")]
			Approval = 7, 
		}
		
		public enum eOperationKind
		{	
		
			[Label("Http")]
			[Description(@"")]
			Http = 473330000, 
		
			[Label("PowerApp")]
			[Description(@"")]
			PowerApp = 473330001, 
		
			[Label("PowerAppV2")]
			[Description(@"")]
			PowerAppV2 = 473330002, 
		
			[Label("Button")]
			[Description(@"")]
			Button = 473330003, 
		
			[Label("ApiConnection")]
			[Description(@"")]
			ApiConnection = 473330004, 
		
			[Label("Alert")]
			[Description(@"")]
			Alert = 473330005, 
		
			[Label("EventGrid")]
			[Description(@"")]
			EventGrid = 473330006, 
		
			[Label("CurrentTime")]
			[Description(@"")]
			CurrentTime = 473330007, 
		
			[Label("ConvertTimeZone")]
			[Description(@"")]
			ConvertTimeZone = 473330008, 
		
			[Label("GetFutureTime")]
			[Description(@"")]
			GetFutureTime = 473330009, 
		
			[Label("GetPastTime")]
			[Description(@"")]
			GetPastTime = 473330010, 
		
			[Label("AddToTime")]
			[Description(@"")]
			AddToTime = 473330011, 
		
			[Label("SubtractFromTime")]
			[Description(@"")]
			SubtractFromTime = 473330012, 
		
			[Label("AzureMonitorAlert")]
			[Description(@"")]
			AzureMonitorAlert = 473330013, 
		
			[Label("SecurityCenterAlert")]
			[Description(@"")]
			SecurityCenterAlert = 473330014, 
		
			[Label("JsonToJson")]
			[Description(@"")]
			JsonToJson = 473330015, 
		
			[Label("JsonToText")]
			[Description(@"")]
			JsonToText = 473330016, 
		
			[Label("XmlToJson")]
			[Description(@"")]
			XmlToJson = 473330017, 
		
			[Label("XmlToText")]
			[Description(@"")]
			XmlToText = 473330018, 
		
			[Label("Geofence")]
			[Description(@"")]
			Geofence = 473330019, 
		
			[Label("ODataOpenApiConnection")]
			[Description(@"")]
			ODataOpenApiConnection = 473330020, 
		
			[Label("IndexOf")]
			[Description(@"")]
			IndexOf = 473330021, 
		
			[Label("Substring")]
			[Description(@"")]
			Substring = 473330022, 
		
			[Label("VirtualAgent")]
			[Description(@"")]
			VirtualAgent = 473330023, 
		
			[Label("FormatNumber")]
			[Description(@"")]
			FormatNumber = 473330024, 
		}
		
		public enum eOperationType
		{	
		
			[Label("Http")]
			[Description(@"")]
			Http = 473330000, 
		
			[Label("ApiApp")]
			[Description(@"")]
			ApiApp = 473330001, 
		
			[Label("Recurrence")]
			[Description(@"")]
			Recurrence = 473330002, 
		
			[Label("Workflow")]
			[Description(@"")]
			Workflow = 473330003, 
		
			[Label("Flow")]
			[Description(@"")]
			Flow = 473330004, 
		
			[Label("Wait")]
			[Description(@"")]
			Wait = 473330005, 
		
			[Label("ApiConnection")]
			[Description(@"")]
			ApiConnection = 473330006, 
		
			[Label("OpenApiConnection")]
			[Description(@"")]
			OpenApiConnection = 473330007, 
		
			[Label("Manual")]
			[Description(@"")]
			Manual = 473330008, 
		
			[Label("ApiConnectionWebhook")]
			[Description(@"")]
			ApiConnectionWebhook = 473330009, 
		
			[Label("OpenApiConnectionWebhook")]
			[Description(@"")]
			OpenApiConnectionWebhook = 473330010, 
		
			[Label("Response")]
			[Description(@"")]
			Response = 473330011, 
		
			[Label("HttpWebhook")]
			[Description(@"")]
			HttpWebhook = 473330012, 
		
			[Label("Compose")]
			[Description(@"")]
			Compose = 473330013, 
		
			[Label("Query")]
			[Description(@"")]
			Query = 473330014, 
		
			[Label("Function")]
			[Description(@"")]
			Function = 473330015, 
		
			[Label("ApiManagement")]
			[Description(@"")]
			ApiManagement = 473330016, 
		
			[Label("XmlValidation")]
			[Description(@"")]
			XmlValidation = 473330017, 
		
			[Label("FlatFileEncoding")]
			[Description(@"")]
			FlatFileEncoding = 473330018, 
		
			[Label("Scope")]
			[Description(@"")]
			Scope = 473330019, 
		
			[Label("Request")]
			[Description(@"")]
			Request = 473330020, 
		
			[Label("If")]
			[Description(@"")]
			If = 473330021, 
		
			[Label("Foreach")]
			[Description(@"")]
			Foreach = 473330022, 
		
			[Label("Until")]
			[Description(@"")]
			Until = 473330023, 
		
			[Label("Xslt")]
			[Description(@"")]
			Xslt = 473330024, 
		
			[Label("FlatFileDecoding")]
			[Description(@"")]
			FlatFileDecoding = 473330025, 
		
			[Label("Terminate")]
			[Description(@"")]
			Terminate = 473330026, 
		
			[Label("IntegrationAccountArtifactLookup")]
			[Description(@"")]
			IntegrationAccountArtifactLookup = 473330027, 
		
			[Label("Switch")]
			[Description(@"")]
			Switch = 473330028, 
		
			[Label("ParseJson")]
			[Description(@"")]
			ParseJson = 473330029, 
		
			[Label("Table")]
			[Description(@"")]
			Table = 473330030, 
		
			[Label("Join")]
			[Description(@"")]
			Join = 473330031, 
		
			[Label("Select")]
			[Description(@"")]
			Select = 473330032, 
		
			[Label("InitializeVariable")]
			[Description(@"")]
			InitializeVariable = 473330033, 
		
			[Label("IncrementVariable")]
			[Description(@"")]
			IncrementVariable = 473330034, 
		
			[Label("DecrementVariable")]
			[Description(@"")]
			DecrementVariable = 473330035, 
		
			[Label("SetVariable")]
			[Description(@"")]
			SetVariable = 473330036, 
		
			[Label("AppendToArrayVariable")]
			[Description(@"")]
			AppendToArrayVariable = 473330037, 
		
			[Label("AppendToStringVariable")]
			[Description(@"")]
			AppendToStringVariable = 473330038, 
		
			[Label("Batch")]
			[Description(@"")]
			Batch = 473330039, 
		
			[Label("SendToBatch")]
			[Description(@"")]
			SendToBatch = 473330040, 
		
			[Label("SlidingWindow")]
			[Description(@"")]
			SlidingWindow = 473330041, 
		
			[Label("Expression")]
			[Description(@"")]
			Expression = 473330042, 
		
			[Label("Liquid")]
			[Description(@"")]
			Liquid = 473330043, 
		
			[Label("JavascriptCode")]
			[Description(@"")]
			JavascriptCode = 473330044, 
		
			[Label("As2Decode")]
			[Description(@"")]
			As2Decode = 473330045, 
		
			[Label("As2Encode")]
			[Description(@"")]
			As2Encode = 473330046, 
		
			[Label("RosettaNetEncode")]
			[Description(@"")]
			RosettaNetEncode = 473330047, 
		
			[Label("RosettaNetDecode")]
			[Description(@"")]
			RosettaNetDecode = 473330048, 
		
			[Label("RosettaNetWaitForResponse")]
			[Description(@"")]
			RosettaNetWaitForResponse = 473330049, 
		
			[Label("ApiConnectionNotification")]
			[Description(@"")]
			ApiConnectionNotification = 473330050, 
		
			[Label("Changeset")]
			[Description(@"")]
			Changeset = 473330051, 
		
			[Label("SwiftEncode")]
			[Description(@"")]
			SwiftEncode = 473330052, 
		}
		
		#endregion	

		#region Properties
		public static class Properties 
		{
			/// <summary>clientdata</summary>
			public const string ClientData = "clientdata";

			/// <summary>connector</summary>
			public const string Connector = "connector";

			/// <summary>istrigger</summary>
			public const string IsTrigger = "istrigger";

			/// <summary>operationid</summary>
			public const string OperationId = "operationid";

			/// <summary>operationkind</summary>
			public const string OperationKind = "operationkind";

			/// <summary>operationtype</summary>
			public const string OperationType = "operationtype";

			/// <summary>ownerid</summary>
			public const string Owner = "ownerid";

			/// <summary>owneridtype</summary>
			public const string Owneridtype = "owneridtype";

			/// <summary>owningbusinessunit</summary>
			public const string OwningBusinessUnitId = "owningbusinessunit";

			/// <summary>primaryentitytypecode</summary>
			public const string PrimaryEntity = "primaryentitytypecode";

			/// <summary>processid</summary>
			public const string Process = "processid";

			/// <summary>processidname</summary>
			public const string Processidname = "processidname";

			/// <summary>processstageid</summary>
			public const string ProcessStageId = "processstageid";

			/// <summary>stagecategory</summary>
			public const string StageCategory = "stagecategory";

			/// <summary>stagename</summary>
			public const string ProcessStageName = "stagename";

			/// <summary>versionnumber</summary>
			public const string VersionNumber = "versionnumber";

		}
		#endregion

		#region Schemas
		public static class Schemas 
		{
			/// <summary>1:N lk_expiredprocess_activestageid</summary>
			public const string LkExpiredprocessActivestageid = "lk_expiredprocess_activestageid";

			/// <summary>1:N lk_leadtoopportunitysalesprocess_activestageid</summary>
			public const string LkLeadtoopportunitysalesprocessActivestageid = "lk_leadtoopportunitysalesprocess_activestageid";

			/// <summary>1:N lk_newprocess_activestageid</summary>
			public const string LkNewprocessActivestageid = "lk_newprocess_activestageid";

			/// <summary>1:N lk_opportunitysalesprocess_activestageid</summary>
			public const string LkOpportunitysalesprocessActivestageid = "lk_opportunitysalesprocess_activestageid";

			/// <summary>1:N lk_phonetocaseprocess_activestageid</summary>
			public const string LkPhonetocaseprocessActivestageid = "lk_phonetocaseprocess_activestageid";

			/// <summary>1:N lk_translationprocess_activestageid</summary>
			public const string LkTranslationprocessActivestageid = "lk_translationprocess_activestageid";

			/// <summary>1:N processstage_account</summary>
			public const string ProcessstageAccount = "processstage_account";

			/// <summary>1:N processstage_appointments</summary>
			public const string ProcessstageAppointments = "processstage_appointments";

			/// <summary>1:N processstage_BookableResource</summary>
			public const string ProcessstageBookableResource = "processstage_BookableResource";

			/// <summary>1:N processstage_BookableResourceBooking</summary>
			public const string ProcessstageBookableResourceBooking = "processstage_BookableResourceBooking";

			/// <summary>1:N processstage_BookableResourceBookingHeader</summary>
			public const string ProcessstageBookableResourceBookingHeader = "processstage_BookableResourceBookingHeader";

			/// <summary>1:N processstage_BookableResourceCharacteristic</summary>
			public const string ProcessstageBookableResourceCharacteristic = "processstage_BookableResourceCharacteristic";

			/// <summary>1:N processstage_campaignactivities</summary>
			public const string ProcessstageCampaignactivities = "processstage_campaignactivities";

			/// <summary>1:N processstage_campaignresponses</summary>
			public const string ProcessstageCampaignresponses = "processstage_campaignresponses";

			/// <summary>1:N processstage_campaigns</summary>
			public const string ProcessstageCampaigns = "processstage_campaigns";

			/// <summary>1:N processstage_competitors</summary>
			public const string ProcessstageCompetitors = "processstage_competitors";

			/// <summary>1:N processstage_contact</summary>
			public const string ProcessstageContact = "processstage_contact";

			/// <summary>1:N processstage_emails</summary>
			public const string ProcessstageEmails = "processstage_emails";

			/// <summary>1:N processstage_Entitlement</summary>
			public const string ProcessstageEntitlement = "processstage_Entitlement";

			/// <summary>1:N processstage_faxes</summary>
			public const string ProcessstageFaxes = "processstage_faxes";

			/// <summary>1:N processstage_incident</summary>
			public const string ProcessstageIncident = "processstage_incident";

			/// <summary>1:N processstage_invoices</summary>
			public const string ProcessstageInvoices = "processstage_invoices";

			/// <summary>1:N processstage_knowledgearticle</summary>
			public const string ProcessstageKnowledgearticle = "processstage_knowledgearticle";

			/// <summary>1:N processstage_lead</summary>
			public const string ProcessstageLead = "processstage_lead";

			/// <summary>1:N processstage_letters</summary>
			public const string ProcessstageLetters = "processstage_letters";

			/// <summary>1:N processstage_lists</summary>
			public const string ProcessstageLists = "processstage_lists";

			/// <summary>1:N processstage_opportunity</summary>
			public const string ProcessstageOpportunity = "processstage_opportunity";

			/// <summary>1:N processstage_phonecalls</summary>
			public const string ProcessstagePhonecalls = "processstage_phonecalls";

			/// <summary>1:N processstage_processstageparameter</summary>
			public const string ProcessstageProcessstageparameter = "processstage_processstageparameter";

			/// <summary>1:N processstage_productpricelevels</summary>
			public const string ProcessstageProductpricelevels = "processstage_productpricelevels";

			/// <summary>1:N processstage_products</summary>
			public const string ProcessstageProducts = "processstage_products";

			/// <summary>1:N processstage_quotes</summary>
			public const string ProcessstageQuotes = "processstage_quotes";

			/// <summary>1:N processstage_recurringappointmentmasters</summary>
			public const string ProcessstageRecurringappointmentmasters = "processstage_recurringappointmentmasters";

			/// <summary>1:N processstage_salesliteratures</summary>
			public const string ProcessstageSalesliteratures = "processstage_salesliteratures";

			/// <summary>1:N processstage_salesorders</summary>
			public const string ProcessstageSalesorders = "processstage_salesorders";

			/// <summary>1:N ProcessStage_SyncErrors</summary>
			public const string ProcessStageSyncErrors = "ProcessStage_SyncErrors";

			/// <summary>1:N processstage_systemusers</summary>
			public const string ProcessstageSystemusers = "processstage_systemusers";

			/// <summary>1:N processstage_tasks</summary>
			public const string ProcessstageTasks = "processstage_tasks";

			/// <summary>1:N processstage_teams</summary>
			public const string ProcessstageTeams = "processstage_teams";

		}
		#endregion
	}
}

