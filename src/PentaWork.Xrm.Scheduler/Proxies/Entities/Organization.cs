using System;
using System.Linq;
using System.Diagnostics;
using System.ComponentModel;
using Microsoft.Xrm.Sdk; 
using Microsoft.Xrm.Sdk.Client;
using System.Collections.Generic;

namespace PentaWork.Xrm.Scheduler.Proxies.Entities
{
	[DebuggerDisplay("{OrganizationName}")] 	
	[EntityLogicalName("organization")]
	public sealed class Organization : Entity
	{	
		public static readonly int? EntityTypeCode = 1019;
		public new const string LogicalName = "organization";
		public const string PrimaryIdAttribute = "organizationid";
		public const string PrimaryNameAttribute = "name";
	
		public Organization() : base("organization") { }

		#region Attributes
		/// <summary>
        /// aciwebendpointurl
        /// </summary>
		[DisplayName("ACI Tenant URL.")]
		[AttributeLogicalName("aciwebendpointurl")]
		public string ACITenantURL
		{	
			get { return GetAttributeValue<string>("aciwebendpointurl"); }
			set
			{ 
				if(value == ACITenantURL) return;
				SetAttributeValue("aciwebendpointurl", value);
			}
		}	
			
		/// <summary>
        /// acknowledgementtemplateid
        /// </summary>
		[DisplayName("Acknowledgement Template")]
		[AttributeLogicalName("acknowledgementtemplateid")]
		public EntityReference AcknowledgementTemplate
		{	
			get { return GetAttributeValue<EntityReference>("acknowledgementtemplateid"); }
			set
			{ 
				if(value == AcknowledgementTemplate) return;
				SetAttributeValue("acknowledgementtemplateid", value);
			}
		}	
			
		/// <summary>
        /// acknowledgementtemplateidname
        /// </summary>
		[DisplayName("acknowledgementtemplateidname")]
		[AttributeLogicalName("acknowledgementtemplateidname")]
		public string Acknowledgementtemplateidname
		{	
			get { return GetAttributeValue<string>("acknowledgementtemplateidname"); }
			set
			{ 
				if(value == Acknowledgementtemplateidname) return;
				SetAttributeValue("acknowledgementtemplateidname", value);
			}
		}	
			
		/// <summary>
        /// allowaddressbooksyncs
        /// </summary>
		[DisplayName("Allow Address Book Synchronization")]
		[AttributeLogicalName("allowaddressbooksyncs")]
		public bool? AllowAddressBookSynchronization
		{	
			get { return GetAttributeValue<bool?>("allowaddressbooksyncs"); }
			set
			{ 
				if(value == AllowAddressBookSynchronization) return;
				SetAttributeValue("allowaddressbooksyncs", value);
			}
		}	
			
		/// <summary>
        /// allowautoresponsecreation
        /// </summary>
		[DisplayName("Allow Automatic Response Creation")]
		[AttributeLogicalName("allowautoresponsecreation")]
		public bool? AllowAutomaticResponseCreation
		{	
			get { return GetAttributeValue<bool?>("allowautoresponsecreation"); }
			set
			{ 
				if(value == AllowAutomaticResponseCreation) return;
				SetAttributeValue("allowautoresponsecreation", value);
			}
		}	
			
		/// <summary>
        /// allowautounsubscribe
        /// </summary>
		[DisplayName("Allow Automatic Unsubscribe")]
		[AttributeLogicalName("allowautounsubscribe")]
		public bool? AllowAutomaticUnsubscribe
		{	
			get { return GetAttributeValue<bool?>("allowautounsubscribe"); }
			set
			{ 
				if(value == AllowAutomaticUnsubscribe) return;
				SetAttributeValue("allowautounsubscribe", value);
			}
		}	
			
		/// <summary>
        /// allowautounsubscribeacknowledgement
        /// </summary>
		[DisplayName("Allow Automatic Unsubscribe Acknowledgement")]
		[AttributeLogicalName("allowautounsubscribeacknowledgement")]
		public bool? AllowAutomaticUnsubscribeAcknowledgement
		{	
			get { return GetAttributeValue<bool?>("allowautounsubscribeacknowledgement"); }
			set
			{ 
				if(value == AllowAutomaticUnsubscribeAcknowledgement) return;
				SetAttributeValue("allowautounsubscribeacknowledgement", value);
			}
		}	
			
		/// <summary>
        /// allowclientmessagebarad
        /// </summary>
		[DisplayName("Allow Outlook Client Message Bar Advertisement")]
		[AttributeLogicalName("allowclientmessagebarad")]
		public bool? AllowOutlookClientMessageBarAdvertisement
		{	
			get { return GetAttributeValue<bool?>("allowclientmessagebarad"); }
			set
			{ 
				if(value == AllowOutlookClientMessageBarAdvertisement) return;
				SetAttributeValue("allowclientmessagebarad", value);
			}
		}	
			
		/// <summary>
        /// allowentityonlyaudit
        /// </summary>
		[DisplayName("Allow Entity Level Auditing")]
		[AttributeLogicalName("allowentityonlyaudit")]
		public bool? AllowEntityLevelAuditing
		{	
			get { return GetAttributeValue<bool?>("allowentityonlyaudit"); }
			set
			{ 
				if(value == AllowEntityLevelAuditing) return;
				SetAttributeValue("allowentityonlyaudit", value);
			}
		}	
			
		/// <summary>
        /// allowlegacyclientexperience
        /// </summary>
		[DisplayName("Enable access to legacy web client UI")]
		[AttributeLogicalName("allowlegacyclientexperience")]
		public bool? EnableAccessToLegacyWebClientUI
		{	
			get { return GetAttributeValue<bool?>("allowlegacyclientexperience"); }
			set
			{ 
				if(value == EnableAccessToLegacyWebClientUI) return;
				SetAttributeValue("allowlegacyclientexperience", value);
			}
		}	
			
		/// <summary>
        /// allowlegacydialogsembedding
        /// </summary>
		[DisplayName("Enable embedding of certain legacy dialogs in Unified Interface browser client")]
		[AttributeLogicalName("allowlegacydialogsembedding")]
		public bool? EnableEmbeddingOfCertainLegacyDialogsInUnifiedInterfaceBrowserClient
		{	
			get { return GetAttributeValue<bool?>("allowlegacydialogsembedding"); }
			set
			{ 
				if(value == EnableEmbeddingOfCertainLegacyDialogsInUnifiedInterfaceBrowserClient) return;
				SetAttributeValue("allowlegacydialogsembedding", value);
			}
		}	
			
		/// <summary>
        /// allowmarketingemailexecution
        /// </summary>
		[DisplayName("Allow Marketing Email Execution")]
		[AttributeLogicalName("allowmarketingemailexecution")]
		public bool? AllowMarketingEmailExecution
		{	
			get { return GetAttributeValue<bool?>("allowmarketingemailexecution"); }
			set
			{ 
				if(value == AllowMarketingEmailExecution) return;
				SetAttributeValue("allowmarketingemailexecution", value);
			}
		}	
			
		/// <summary>
        /// allowofflinescheduledsyncs
        /// </summary>
		[DisplayName("Allow Offline Scheduled Synchronization")]
		[AttributeLogicalName("allowofflinescheduledsyncs")]
		public bool? AllowOfflineScheduledSynchronization
		{	
			get { return GetAttributeValue<bool?>("allowofflinescheduledsyncs"); }
			set
			{ 
				if(value == AllowOfflineScheduledSynchronization) return;
				SetAttributeValue("allowofflinescheduledsyncs", value);
			}
		}	
			
		/// <summary>
        /// allowoutlookscheduledsyncs
        /// </summary>
		[DisplayName("Allow Scheduled Synchronization")]
		[AttributeLogicalName("allowoutlookscheduledsyncs")]
		public bool? AllowScheduledSynchronization
		{	
			get { return GetAttributeValue<bool?>("allowoutlookscheduledsyncs"); }
			set
			{ 
				if(value == AllowScheduledSynchronization) return;
				SetAttributeValue("allowoutlookscheduledsyncs", value);
			}
		}	
			
		/// <summary>
        /// allowunresolvedpartiesonemailsend
        /// </summary>
		[DisplayName("Allow Unresolved Address Email Send")]
		[AttributeLogicalName("allowunresolvedpartiesonemailsend")]
		public bool? AllowUnresolvedAddressEmailSend
		{	
			get { return GetAttributeValue<bool?>("allowunresolvedpartiesonemailsend"); }
			set
			{ 
				if(value == AllowUnresolvedAddressEmailSend) return;
				SetAttributeValue("allowunresolvedpartiesonemailsend", value);
			}
		}	
			
		/// <summary>
        /// allowuserformmodepreference
        /// </summary>
		[DisplayName("Allow User Form Mode Preference")]
		[AttributeLogicalName("allowuserformmodepreference")]
		public bool? AllowUserFormModePreference
		{	
			get { return GetAttributeValue<bool?>("allowuserformmodepreference"); }
			set
			{ 
				if(value == AllowUserFormModePreference) return;
				SetAttributeValue("allowuserformmodepreference", value);
			}
		}	
			
		/// <summary>
        /// allowusersseeappdownloadmessage
        /// </summary>
		[DisplayName("Allow the showing tablet application notification bars in a browser.")]
		[AttributeLogicalName("allowusersseeappdownloadmessage")]
		public bool? AllowTheShowingTabletApplicationNotificationBarsInABrowser
		{	
			get { return GetAttributeValue<bool?>("allowusersseeappdownloadmessage"); }
			set
			{ 
				if(value == AllowTheShowingTabletApplicationNotificationBarsInABrowser) return;
				SetAttributeValue("allowusersseeappdownloadmessage", value);
			}
		}	
			
		/// <summary>
        /// allowwebexcelexport
        /// </summary>
		[DisplayName("Allow Export to Excel")]
		[AttributeLogicalName("allowwebexcelexport")]
		public bool? AllowExportToExcel
		{	
			get { return GetAttributeValue<bool?>("allowwebexcelexport"); }
			set
			{ 
				if(value == AllowExportToExcel) return;
				SetAttributeValue("allowwebexcelexport", value);
			}
		}	
			
		/// <summary>
        /// amdesignator
        /// </summary>
		[DisplayName("AM Designator")]
		[AttributeLogicalName("amdesignator")]
		public string AMDesignator
		{	
			get { return GetAttributeValue<string>("amdesignator"); }
			set
			{ 
				if(value == AMDesignator) return;
				SetAttributeValue("amdesignator", value);
			}
		}	
			
		/// <summary>
        /// appdesignerexperienceenabled
        /// </summary>
		[DisplayName("Enable App Designer Experience for this Organization")]
		[AttributeLogicalName("appdesignerexperienceenabled")]
		public bool? EnableAppDesignerExperienceForThisOrganization
		{	
			get { return GetAttributeValue<bool?>("appdesignerexperienceenabled"); }
			set
			{ 
				if(value == EnableAppDesignerExperienceForThisOrganization) return;
				SetAttributeValue("appdesignerexperienceenabled", value);
			}
		}	
			
		/// <summary>
        /// appointmentricheditorexperience
        /// </summary>
		[DisplayName("Enable Rich Editing Experience for Appointment")]
		[AttributeLogicalName("appointmentricheditorexperience")]
		public bool? EnableRichEditingExperienceForAppointment
		{	
			get { return GetAttributeValue<bool?>("appointmentricheditorexperience"); }
			set
			{ 
				if(value == EnableRichEditingExperienceForAppointment) return;
				SetAttributeValue("appointmentricheditorexperience", value);
			}
		}	
			
		/// <summary>
        /// auditretentionperiod
        /// </summary>
		[DisplayName("Audit Retention Period Settings")]
		[AttributeLogicalName("auditretentionperiod")]
		public int? AuditRetentionPeriodSettings
		{	
			get { return GetAttributeValue<int?>("auditretentionperiod"); }
			set
			{ 
				if(value == AuditRetentionPeriodSettings) return;
				SetAttributeValue("auditretentionperiod", value);
			}
		}	
			
		/// <summary>
        /// auditretentionperiodv2
        /// </summary>
		[DisplayName("Audit Retention Period Settings")]
		[AttributeLogicalName("auditretentionperiodv2")]
		public int? AuditRetentionPeriodSettings2
		{	
			get { return GetAttributeValue<int?>("auditretentionperiodv2"); }
			set
			{ 
				if(value == AuditRetentionPeriodSettings2) return;
				SetAttributeValue("auditretentionperiodv2", value);
			}
		}	
			
		/// <summary>
        /// autoapplydefaultoncasecreate
        /// </summary>
		[DisplayName("Auto Apply Default Entitlement on Case Create")]
		[AttributeLogicalName("autoapplydefaultoncasecreate")]
		public bool? AutoApplyDefaultEntitlementOnCaseCreate
		{	
			get { return GetAttributeValue<bool?>("autoapplydefaultoncasecreate"); }
			set
			{ 
				if(value == AutoApplyDefaultEntitlementOnCaseCreate) return;
				SetAttributeValue("autoapplydefaultoncasecreate", value);
			}
		}	
			
		/// <summary>
        /// autoapplydefaultoncaseupdate
        /// </summary>
		[DisplayName("Auto Apply Default Entitlement on Case Update")]
		[AttributeLogicalName("autoapplydefaultoncaseupdate")]
		public bool? AutoApplyDefaultEntitlementOnCaseUpdate
		{	
			get { return GetAttributeValue<bool?>("autoapplydefaultoncaseupdate"); }
			set
			{ 
				if(value == AutoApplyDefaultEntitlementOnCaseUpdate) return;
				SetAttributeValue("autoapplydefaultoncaseupdate", value);
			}
		}	
			
		/// <summary>
        /// autoapplysla
        /// </summary>
		[DisplayName("Is Auto-apply SLA After Manually Over-riding")]
		[AttributeLogicalName("autoapplysla")]
		public bool? IsAutoapplySLAAfterManuallyOverriding
		{	
			get { return GetAttributeValue<bool?>("autoapplysla"); }
			set
			{ 
				if(value == IsAutoapplySLAAfterManuallyOverriding) return;
				SetAttributeValue("autoapplysla", value);
			}
		}	
			
		/// <summary>
        /// azureschedulerjobcollectionname
        /// </summary>
		[DisplayName("For internal use only.")]
		[AttributeLogicalName("azureschedulerjobcollectionname")]
		public string ForInternalUseOnly
		{	
			get { return GetAttributeValue<string>("azureschedulerjobcollectionname"); }
			set
			{ 
				if(value == ForInternalUseOnly) return;
				SetAttributeValue("azureschedulerjobcollectionname", value);
			}
		}	
			
		/// <summary>
        /// basecurrencyid
        /// </summary>
		[DisplayName("Currency")]
		[AttributeLogicalName("basecurrencyid")]
		public EntityReference Currency
		{	
			get { return GetAttributeValue<EntityReference>("basecurrencyid"); }
			set
			{ 
				if(value == Currency) return;
				SetAttributeValue("basecurrencyid", value);
			}
		}	
			
		/// <summary>
        /// basecurrencyidname
        /// </summary>
		[DisplayName("basecurrencyidname")]
		[AttributeLogicalName("basecurrencyidname")]
		public string Basecurrencyidname
		{	
			get { return GetAttributeValue<string>("basecurrencyidname"); }
			set
			{ 
				if(value == Basecurrencyidname) return;
				SetAttributeValue("basecurrencyidname", value);
			}
		}	
			
		/// <summary>
        /// basecurrencyprecision
        /// </summary>
		[DisplayName("Base Currency Precision")]
		[AttributeLogicalName("basecurrencyprecision")]
		public int? BaseCurrencyPrecision
		{	
			get { return GetAttributeValue<int?>("basecurrencyprecision"); }
			set
			{ 
				if(value == BaseCurrencyPrecision) return;
				SetAttributeValue("basecurrencyprecision", value);
			}
		}	
			
		/// <summary>
        /// basecurrencysymbol
        /// </summary>
		[DisplayName("Base Currency Symbol")]
		[AttributeLogicalName("basecurrencysymbol")]
		public string BaseCurrencySymbol
		{	
			get { return GetAttributeValue<string>("basecurrencysymbol"); }
			set
			{ 
				if(value == BaseCurrencySymbol) return;
				SetAttributeValue("basecurrencysymbol", value);
			}
		}	
			
		/// <summary>
        /// baseisocurrencycode
        /// </summary>
		[DisplayName("Base ISO Currency Code")]
		[AttributeLogicalName("baseisocurrencycode")]
		public string BaseISOCurrencyCode
		{	
			get { return GetAttributeValue<string>("baseisocurrencycode"); }
			set
			{ 
				if(value == BaseISOCurrencyCode) return;
				SetAttributeValue("baseisocurrencycode", value);
			}
		}	
			
		/// <summary>
        /// bingmapsapikey
        /// </summary>
		[DisplayName("Bing Maps API Key")]
		[AttributeLogicalName("bingmapsapikey")]
		public string BingMapsAPIKey
		{	
			get { return GetAttributeValue<string>("bingmapsapikey"); }
			set
			{ 
				if(value == BingMapsAPIKey) return;
				SetAttributeValue("bingmapsapikey", value);
			}
		}	
			
		/// <summary>
        /// blockedattachments
        /// </summary>
		[DisplayName("Block Attachments")]
		[AttributeLogicalName("blockedattachments")]
		public string BlockAttachments
		{	
			get { return GetAttributeValue<string>("blockedattachments"); }
			set
			{ 
				if(value == BlockAttachments) return;
				SetAttributeValue("blockedattachments", value);
			}
		}	
			
		/// <summary>
        /// bounddashboarddefaultcardexpanded
        /// </summary>
		[DisplayName("Display cards in expanded state for Interactive Dashboard")]
		[AttributeLogicalName("bounddashboarddefaultcardexpanded")]
		public bool? DisplayCardsInExpandedStateForInteractiveDashboard
		{	
			get { return GetAttributeValue<bool?>("bounddashboarddefaultcardexpanded"); }
			set
			{ 
				if(value == DisplayCardsInExpandedStateForInteractiveDashboard) return;
				SetAttributeValue("bounddashboarddefaultcardexpanded", value);
			}
		}	
			
		/// <summary>
        /// bulkoperationprefix
        /// </summary>
		[DisplayName("Bulk Operation Prefix")]
		[AttributeLogicalName("bulkoperationprefix")]
		public string BulkOperationPrefix
		{	
			get { return GetAttributeValue<string>("bulkoperationprefix"); }
			set
			{ 
				if(value == BulkOperationPrefix) return;
				SetAttributeValue("bulkoperationprefix", value);
			}
		}	
			
		/// <summary>
        /// businesscardoptions
        /// </summary>
		[DisplayName("Enable New BusinessCardOptions")]
		[AttributeLogicalName("businesscardoptions")]
		public string EnableNewBusinessCardOptions
		{	
			get { return GetAttributeValue<string>("businesscardoptions"); }
			set
			{ 
				if(value == EnableNewBusinessCardOptions) return;
				SetAttributeValue("businesscardoptions", value);
			}
		}	
			
		/// <summary>
        /// businessclosurecalendarid
        /// </summary>
		[DisplayName("Business Closure Calendar")]
		[AttributeLogicalName("businessclosurecalendarid")]
		public Guid BusinessClosureCalendarId
		{	
			get { return GetAttributeValue<Guid>("businessclosurecalendarid"); }
			set
			{ 
				if(value == BusinessClosureCalendarId) return;
				SetAttributeValue("businessclosurecalendarid", value);
			}
		}	
			
		/// <summary>
        /// calendartype
        /// </summary>
		[DisplayName("Calendar Type")]
		[AttributeLogicalName("calendartype")]
		public int? CalendarType
		{	
			get { return GetAttributeValue<int?>("calendartype"); }
			set
			{ 
				if(value == CalendarType) return;
				SetAttributeValue("calendartype", value);
			}
		}	
			
		/// <summary>
        /// campaignprefix
        /// </summary>
		[DisplayName("Campaign Prefix")]
		[AttributeLogicalName("campaignprefix")]
		public string CampaignPrefix
		{	
			get { return GetAttributeValue<string>("campaignprefix"); }
			set
			{ 
				if(value == CampaignPrefix) return;
				SetAttributeValue("campaignprefix", value);
			}
		}	
			
		/// <summary>
        /// cascadestatusupdate
        /// </summary>
		[DisplayName("Cascade Status Update")]
		[AttributeLogicalName("cascadestatusupdate")]
		public bool? CascadeStatusUpdate
		{	
			get { return GetAttributeValue<bool?>("cascadestatusupdate"); }
			set
			{ 
				if(value == CascadeStatusUpdate) return;
				SetAttributeValue("cascadestatusupdate", value);
			}
		}	
			
		/// <summary>
        /// caseprefix
        /// </summary>
		[DisplayName("Case Prefix")]
		[AttributeLogicalName("caseprefix")]
		public string CasePrefix
		{	
			get { return GetAttributeValue<string>("caseprefix"); }
			set
			{ 
				if(value == CasePrefix) return;
				SetAttributeValue("caseprefix", value);
			}
		}	
			
		/// <summary>
        /// categoryprefix
        /// </summary>
		[DisplayName("Category Prefix")]
		[AttributeLogicalName("categoryprefix")]
		public string CategoryPrefix
		{	
			get { return GetAttributeValue<string>("categoryprefix"); }
			set
			{ 
				if(value == CategoryPrefix) return;
				SetAttributeValue("categoryprefix", value);
			}
		}	
			
		/// <summary>
        /// clientfeatureset
        /// </summary>
		[DisplayName("Client Feature Set")]
		[AttributeLogicalName("clientfeatureset")]
		public string ClientFeatureSet
		{	
			get { return GetAttributeValue<string>("clientfeatureset"); }
			set
			{ 
				if(value == ClientFeatureSet) return;
				SetAttributeValue("clientfeatureset", value);
			}
		}	
			
		/// <summary>
        /// contentsecuritypolicyconfiguration
        /// </summary>
		[DisplayName("Content Security Policy Configuration")]
		[AttributeLogicalName("contentsecuritypolicyconfiguration")]
		public string ContentSecurityPolicyConfiguration
		{	
			get { return GetAttributeValue<string>("contentsecuritypolicyconfiguration"); }
			set
			{ 
				if(value == ContentSecurityPolicyConfiguration) return;
				SetAttributeValue("contentsecuritypolicyconfiguration", value);
			}
		}	
			
		/// <summary>
        /// contractprefix
        /// </summary>
		[DisplayName("Contract Prefix")]
		[AttributeLogicalName("contractprefix")]
		public string ContractPrefix
		{	
			get { return GetAttributeValue<string>("contractprefix"); }
			set
			{ 
				if(value == ContractPrefix) return;
				SetAttributeValue("contractprefix", value);
			}
		}	
			
		/// <summary>
        /// cortanaproactiveexperienceenabled
        /// </summary>
		[DisplayName("Enable Cortana Proactive Experience Flow processes for this Organization")]
		[AttributeLogicalName("cortanaproactiveexperienceenabled")]
		public bool? EnableCortanaProactiveExperienceFlowProcessesForThisOrganization
		{	
			get { return GetAttributeValue<bool?>("cortanaproactiveexperienceenabled"); }
			set
			{ 
				if(value == EnableCortanaProactiveExperienceFlowProcessesForThisOrganization) return;
				SetAttributeValue("cortanaproactiveexperienceenabled", value);
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
        /// createproductswithoutparentinactivestate
        /// </summary>
		[DisplayName("Enable Active Initial Product State")]
		[AttributeLogicalName("createproductswithoutparentinactivestate")]
		public bool? EnableActiveInitialProductState
		{	
			get { return GetAttributeValue<bool?>("createproductswithoutparentinactivestate"); }
			set
			{ 
				if(value == EnableActiveInitialProductState) return;
				SetAttributeValue("createproductswithoutparentinactivestate", value);
			}
		}	
			
		/// <summary>
        /// currencydecimalprecision
        /// </summary>
		[DisplayName("Currency Decimal Precision")]
		[AttributeLogicalName("currencydecimalprecision")]
		public int? CurrencyDecimalPrecision
		{	
			get { return GetAttributeValue<int?>("currencydecimalprecision"); }
			set
			{ 
				if(value == CurrencyDecimalPrecision) return;
				SetAttributeValue("currencydecimalprecision", value);
			}
		}	
			
		/// <summary>
        /// currencydisplayoption
        /// </summary>
		[DisplayName("Display Currencies Using")]
		[AttributeLogicalName("currencydisplayoption")]
		public eDisplayCurrenciesUsing? DisplayCurrenciesUsing
		{	
			get 
			{ 
				var optionSetValue = GetAttributeValue<OptionSetValue>("currencydisplayoption");
				if (optionSetValue != null) return (eDisplayCurrenciesUsing)optionSetValue.Value;
				else return null;
			}
			set 
			{ 
				if(value == DisplayCurrenciesUsing) return;

				OptionSetValue optionSetValue = null;
				if(value != null) optionSetValue = new OptionSetValue((int)value);
				SetAttributeValue("currencydisplayoption", optionSetValue); 
			}
		}

		/// <summary>
        /// currencyformatcode
        /// </summary>
		[DisplayName("Currency Format Code")]
		[AttributeLogicalName("currencyformatcode")]
		public eOrganizationCurrencyformatcode? CurrencyFormatCode
		{	
			get 
			{ 
				var optionSetValue = GetAttributeValue<OptionSetValue>("currencyformatcode");
				if (optionSetValue != null) return (eOrganizationCurrencyformatcode)optionSetValue.Value;
				else return null;
			}
			set 
			{ 
				if(value == CurrencyFormatCode) return;

				OptionSetValue optionSetValue = null;
				if(value != null) optionSetValue = new OptionSetValue((int)value);
				SetAttributeValue("currencyformatcode", optionSetValue); 
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
        /// currentbulkoperationnumber
        /// </summary>
		[DisplayName("Current Bulk Operation Number")]
		[AttributeLogicalName("currentbulkoperationnumber")]
		public int? CurrentBulkOperationNumber
		{	
			get { return GetAttributeValue<int?>("currentbulkoperationnumber"); }
			set
			{ 
				if(value == CurrentBulkOperationNumber) return;
				SetAttributeValue("currentbulkoperationnumber", value);
			}
		}	
			
		/// <summary>
        /// currentcampaignnumber
        /// </summary>
		[DisplayName("Current Campaign Number")]
		[AttributeLogicalName("currentcampaignnumber")]
		public int? CurrentCampaignNumber
		{	
			get { return GetAttributeValue<int?>("currentcampaignnumber"); }
			set
			{ 
				if(value == CurrentCampaignNumber) return;
				SetAttributeValue("currentcampaignnumber", value);
			}
		}	
			
		/// <summary>
        /// currentcasenumber
        /// </summary>
		[DisplayName("Current Case Number")]
		[AttributeLogicalName("currentcasenumber")]
		public int? CurrentCaseNumber
		{	
			get { return GetAttributeValue<int?>("currentcasenumber"); }
			set
			{ 
				if(value == CurrentCaseNumber) return;
				SetAttributeValue("currentcasenumber", value);
			}
		}	
			
		/// <summary>
        /// currentcategorynumber
        /// </summary>
		[DisplayName("Current Category Number")]
		[AttributeLogicalName("currentcategorynumber")]
		public int? CurrentCategoryNumber
		{	
			get { return GetAttributeValue<int?>("currentcategorynumber"); }
			set
			{ 
				if(value == CurrentCategoryNumber) return;
				SetAttributeValue("currentcategorynumber", value);
			}
		}	
			
		/// <summary>
        /// currentcontractnumber
        /// </summary>
		[DisplayName("Current Contract Number")]
		[AttributeLogicalName("currentcontractnumber")]
		public int? CurrentContractNumber
		{	
			get { return GetAttributeValue<int?>("currentcontractnumber"); }
			set
			{ 
				if(value == CurrentContractNumber) return;
				SetAttributeValue("currentcontractnumber", value);
			}
		}	
			
		/// <summary>
        /// currentimportsequencenumber
        /// </summary>
		[DisplayName("Current Import Sequence Number")]
		[AttributeLogicalName("currentimportsequencenumber")]
		public int? CurrentImportSequenceNumber
		{	
			get { return GetAttributeValue<int?>("currentimportsequencenumber"); }
			set
			{ 
				if(value == CurrentImportSequenceNumber) return;
				SetAttributeValue("currentimportsequencenumber", value);
			}
		}	
			
		/// <summary>
        /// currentinvoicenumber
        /// </summary>
		[DisplayName("Current Invoice Number")]
		[AttributeLogicalName("currentinvoicenumber")]
		public int? CurrentInvoiceNumber
		{	
			get { return GetAttributeValue<int?>("currentinvoicenumber"); }
			set
			{ 
				if(value == CurrentInvoiceNumber) return;
				SetAttributeValue("currentinvoicenumber", value);
			}
		}	
			
		/// <summary>
        /// currentkanumber
        /// </summary>
		[DisplayName("Current Knowledge Article Number")]
		[AttributeLogicalName("currentkanumber")]
		public int? CurrentKnowledgeArticleNumber
		{	
			get { return GetAttributeValue<int?>("currentkanumber"); }
			set
			{ 
				if(value == CurrentKnowledgeArticleNumber) return;
				SetAttributeValue("currentkanumber", value);
			}
		}	
			
		/// <summary>
        /// currentkbnumber
        /// </summary>
		[DisplayName("Current Article Number")]
		[AttributeLogicalName("currentkbnumber")]
		public int? CurrentArticleNumber
		{	
			get { return GetAttributeValue<int?>("currentkbnumber"); }
			set
			{ 
				if(value == CurrentArticleNumber) return;
				SetAttributeValue("currentkbnumber", value);
			}
		}	
			
		/// <summary>
        /// currentordernumber
        /// </summary>
		[DisplayName("Current Order Number")]
		[AttributeLogicalName("currentordernumber")]
		public int? CurrentOrderNumber
		{	
			get { return GetAttributeValue<int?>("currentordernumber"); }
			set
			{ 
				if(value == CurrentOrderNumber) return;
				SetAttributeValue("currentordernumber", value);
			}
		}	
			
		/// <summary>
        /// currentparsedtablenumber
        /// </summary>
		[DisplayName("Current Parsed Table Number")]
		[AttributeLogicalName("currentparsedtablenumber")]
		public int? CurrentParsedTableNumber
		{	
			get { return GetAttributeValue<int?>("currentparsedtablenumber"); }
			set
			{ 
				if(value == CurrentParsedTableNumber) return;
				SetAttributeValue("currentparsedtablenumber", value);
			}
		}	
			
		/// <summary>
        /// currentquotenumber
        /// </summary>
		[DisplayName("Current Quote Number")]
		[AttributeLogicalName("currentquotenumber")]
		public int? CurrentQuoteNumber
		{	
			get { return GetAttributeValue<int?>("currentquotenumber"); }
			set
			{ 
				if(value == CurrentQuoteNumber) return;
				SetAttributeValue("currentquotenumber", value);
			}
		}	
			
		/// <summary>
        /// dateformatcode
        /// </summary>
		[DisplayName("Date Format Code")]
		[AttributeLogicalName("dateformatcode")]
		public eOrganizationDateformatcode? DateFormatCode
		{	
			get 
			{ 
				var optionSetValue = GetAttributeValue<OptionSetValue>("dateformatcode");
				if (optionSetValue != null) return (eOrganizationDateformatcode)optionSetValue.Value;
				else return null;
			}
			set 
			{ 
				if(value == DateFormatCode) return;

				OptionSetValue optionSetValue = null;
				if(value != null) optionSetValue = new OptionSetValue((int)value);
				SetAttributeValue("dateformatcode", optionSetValue); 
			}
		}

		/// <summary>
        /// dateformatstring
        /// </summary>
		[DisplayName("Date Format String")]
		[AttributeLogicalName("dateformatstring")]
		public string DateFormatString
		{	
			get { return GetAttributeValue<string>("dateformatstring"); }
			set
			{ 
				if(value == DateFormatString) return;
				SetAttributeValue("dateformatstring", value);
			}
		}	
			
		/// <summary>
        /// dateseparator
        /// </summary>
		[DisplayName("Date Separator")]
		[AttributeLogicalName("dateseparator")]
		public string DateSeparator
		{	
			get { return GetAttributeValue<string>("dateseparator"); }
			set
			{ 
				if(value == DateSeparator) return;
				SetAttributeValue("dateseparator", value);
			}
		}	
			
		/// <summary>
        /// dayssincerecordlastmodifiedmaxvalue
        /// </summary>
		[DisplayName("Max value of Days since record last modified")]
		[AttributeLogicalName("dayssincerecordlastmodifiedmaxvalue")]
		public int? MaxValueOfDaysSinceRecordLastModified
		{	
			get { return GetAttributeValue<int?>("dayssincerecordlastmodifiedmaxvalue"); }
			set
			{ 
				if(value == MaxValueOfDaysSinceRecordLastModified) return;
				SetAttributeValue("dayssincerecordlastmodifiedmaxvalue", value);
			}
		}	
			
		/// <summary>
        /// decimalsymbol
        /// </summary>
		[DisplayName("Decimal Symbol")]
		[AttributeLogicalName("decimalsymbol")]
		public string DecimalSymbol
		{	
			get { return GetAttributeValue<string>("decimalsymbol"); }
			set
			{ 
				if(value == DecimalSymbol) return;
				SetAttributeValue("decimalsymbol", value);
			}
		}	
			
		/// <summary>
        /// defaultcountrycode
        /// </summary>
		[DisplayName("Default Country Code")]
		[AttributeLogicalName("defaultcountrycode")]
		public string DefaultCountryCode
		{	
			get { return GetAttributeValue<string>("defaultcountrycode"); }
			set
			{ 
				if(value == DefaultCountryCode) return;
				SetAttributeValue("defaultcountrycode", value);
			}
		}	
			
		/// <summary>
        /// defaultcrmcustomname
        /// </summary>
		[DisplayName("Name of the default app")]
		[AttributeLogicalName("defaultcrmcustomname")]
		public string NameOfTheDefaultApp
		{	
			get { return GetAttributeValue<string>("defaultcrmcustomname"); }
			set
			{ 
				if(value == NameOfTheDefaultApp) return;
				SetAttributeValue("defaultcrmcustomname", value);
			}
		}	
			
		/// <summary>
        /// defaultemailserverprofileid
        /// </summary>
		[DisplayName("Email Server Profile")]
		[AttributeLogicalName("defaultemailserverprofileid")]
		public EntityReference EmailServerProfile
		{	
			get { return GetAttributeValue<EntityReference>("defaultemailserverprofileid"); }
			set
			{ 
				if(value == EmailServerProfile) return;
				SetAttributeValue("defaultemailserverprofileid", value);
			}
		}	
			
		/// <summary>
        /// defaultemailserverprofileidname
        /// </summary>
		[DisplayName("defaultemailserverprofileidname")]
		[AttributeLogicalName("defaultemailserverprofileidname")]
		public string Defaultemailserverprofileidname
		{	
			get { return GetAttributeValue<string>("defaultemailserverprofileidname"); }
			set
			{ 
				if(value == Defaultemailserverprofileidname) return;
				SetAttributeValue("defaultemailserverprofileidname", value);
			}
		}	
			
		/// <summary>
        /// defaultemailsettings
        /// </summary>
		[DisplayName("Default Email Settings")]
		[AttributeLogicalName("defaultemailsettings")]
		public string DefaultEmailSettings
		{	
			get { return GetAttributeValue<string>("defaultemailsettings"); }
			set
			{ 
				if(value == DefaultEmailSettings) return;
				SetAttributeValue("defaultemailsettings", value);
			}
		}	
			
		/// <summary>
        /// defaultmobileofflineprofileid
        /// </summary>
		[DisplayName("Default Mobile Offline Profile")]
		[AttributeLogicalName("defaultmobileofflineprofileid")]
		public EntityReference DefaultMobileOfflineProfile
		{	
			get { return GetAttributeValue<EntityReference>("defaultmobileofflineprofileid"); }
			set
			{ 
				if(value == DefaultMobileOfflineProfile) return;
				SetAttributeValue("defaultmobileofflineprofileid", value);
			}
		}	
			
		/// <summary>
        /// defaultmobileofflineprofileidname
        /// </summary>
		[DisplayName("defaultmobileofflineprofileidname")]
		[AttributeLogicalName("defaultmobileofflineprofileidname")]
		public string Defaultmobileofflineprofileidname
		{	
			get { return GetAttributeValue<string>("defaultmobileofflineprofileidname"); }
			set
			{ 
				if(value == Defaultmobileofflineprofileidname) return;
				SetAttributeValue("defaultmobileofflineprofileidname", value);
			}
		}	
			
		/// <summary>
        /// defaultrecurrenceendrangetype
        /// </summary>
		[DisplayName("Default Recurrence End Range Type")]
		[AttributeLogicalName("defaultrecurrenceendrangetype")]
		public eDefaultRecurrenceEndRangeType? DefaultRecurrenceEndRangeType
		{	
			get 
			{ 
				var optionSetValue = GetAttributeValue<OptionSetValue>("defaultrecurrenceendrangetype");
				if (optionSetValue != null) return (eDefaultRecurrenceEndRangeType)optionSetValue.Value;
				else return null;
			}
			set 
			{ 
				if(value == DefaultRecurrenceEndRangeType) return;

				OptionSetValue optionSetValue = null;
				if(value != null) optionSetValue = new OptionSetValue((int)value);
				SetAttributeValue("defaultrecurrenceendrangetype", optionSetValue); 
			}
		}

		/// <summary>
        /// defaultthemedata
        /// </summary>
		[DisplayName("Default Theme Data")]
		[AttributeLogicalName("defaultthemedata")]
		public string DefaultThemeData
		{	
			get { return GetAttributeValue<string>("defaultthemedata"); }
			set
			{ 
				if(value == DefaultThemeData) return;
				SetAttributeValue("defaultthemedata", value);
			}
		}	
			
		/// <summary>
        /// delegatedadminuserid
        /// </summary>
		[DisplayName("Delegated Admin")]
		[AttributeLogicalName("delegatedadminuserid")]
		public Guid DelegatedAdminId
		{	
			get { return GetAttributeValue<Guid>("delegatedadminuserid"); }
			set
			{ 
				if(value == DelegatedAdminId) return;
				SetAttributeValue("delegatedadminuserid", value);
			}
		}	
			
		/// <summary>
        /// disabledreason
        /// </summary>
		[DisplayName("Disabled Reason")]
		[AttributeLogicalName("disabledreason")]
		public string DisabledReason
		{	
			get { return GetAttributeValue<string>("disabledreason"); }
			set
			{ 
				if(value == DisabledReason) return;
				SetAttributeValue("disabledreason", value);
			}
		}	
			
		/// <summary>
        /// disablesocialcare
        /// </summary>
		[DisplayName("Is Social Care disabled")]
		[AttributeLogicalName("disablesocialcare")]
		public bool? IsSocialCareDisabled
		{	
			get { return GetAttributeValue<bool?>("disablesocialcare"); }
			set
			{ 
				if(value == IsSocialCareDisabled) return;
				SetAttributeValue("disablesocialcare", value);
			}
		}	
			
		/// <summary>
        /// discountcalculationmethod
        /// </summary>
		[DisplayName("Discount calculation method")]
		[AttributeLogicalName("discountcalculationmethod")]
		public eDiscountCalculationMethod? DiscountCalculationMethod
		{	
			get 
			{ 
				var optionSetValue = GetAttributeValue<OptionSetValue>("discountcalculationmethod");
				if (optionSetValue != null) return (eDiscountCalculationMethod)optionSetValue.Value;
				else return null;
			}
			set 
			{ 
				if(value == DiscountCalculationMethod) return;

				OptionSetValue optionSetValue = null;
				if(value != null) optionSetValue = new OptionSetValue((int)value);
				SetAttributeValue("discountcalculationmethod", optionSetValue); 
			}
		}

		/// <summary>
        /// displaynavigationtour
        /// </summary>
		[DisplayName("Display Navigation Tour")]
		[AttributeLogicalName("displaynavigationtour")]
		public bool? DisplayNavigationTour
		{	
			get { return GetAttributeValue<bool?>("displaynavigationtour"); }
			set
			{ 
				if(value == DisplayNavigationTour) return;
				SetAttributeValue("displaynavigationtour", value);
			}
		}	
			
		/// <summary>
        /// emailconnectionchannel
        /// </summary>
		[DisplayName("Email Connection Channel")]
		[AttributeLogicalName("emailconnectionchannel")]
		public eOrganizationEmailconnectionchannel? EmailConnectionChannel
		{	
			get 
			{ 
				var optionSetValue = GetAttributeValue<OptionSetValue>("emailconnectionchannel");
				if (optionSetValue != null) return (eOrganizationEmailconnectionchannel)optionSetValue.Value;
				else return null;
			}
			set 
			{ 
				if(value == EmailConnectionChannel) return;

				OptionSetValue optionSetValue = null;
				if(value != null) optionSetValue = new OptionSetValue((int)value);
				SetAttributeValue("emailconnectionchannel", optionSetValue); 
			}
		}

		/// <summary>
        /// emailcorrelationenabled
        /// </summary>
		[DisplayName("Use Email Correlation")]
		[AttributeLogicalName("emailcorrelationenabled")]
		public bool? UseEmailCorrelation
		{	
			get { return GetAttributeValue<bool?>("emailcorrelationenabled"); }
			set
			{ 
				if(value == UseEmailCorrelation) return;
				SetAttributeValue("emailcorrelationenabled", value);
			}
		}	
			
		/// <summary>
        /// emailsendpollingperiod
        /// </summary>
		[DisplayName("Email Send Polling Frequency")]
		[AttributeLogicalName("emailsendpollingperiod")]
		public int? EmailSendPollingFrequency
		{	
			get { return GetAttributeValue<int?>("emailsendpollingperiod"); }
			set
			{ 
				if(value == EmailSendPollingFrequency) return;
				SetAttributeValue("emailsendpollingperiod", value);
			}
		}	
			
		/// <summary>
        /// enablebingmapsintegration
        /// </summary>
		[DisplayName("Enable Integration with Bing Maps")]
		[AttributeLogicalName("enablebingmapsintegration")]
		public bool? EnableIntegrationWithBingMaps
		{	
			get { return GetAttributeValue<bool?>("enablebingmapsintegration"); }
			set
			{ 
				if(value == EnableIntegrationWithBingMaps) return;
				SetAttributeValue("enablebingmapsintegration", value);
			}
		}	
			
		/// <summary>
        /// enableimmersiveskypeintegration
        /// </summary>
		[DisplayName("Enable Integration with Immersive Skype")]
		[AttributeLogicalName("enableimmersiveskypeintegration")]
		public bool? EnableIntegrationWithImmersiveSkype
		{	
			get { return GetAttributeValue<bool?>("enableimmersiveskypeintegration"); }
			set
			{ 
				if(value == EnableIntegrationWithImmersiveSkype) return;
				SetAttributeValue("enableimmersiveskypeintegration", value);
			}
		}	
			
		/// <summary>
        /// enablelivepersonacarduci
        /// </summary>
		[DisplayName("Indicates whether the user has enabled or disabled Live Persona Card feature in UCI.")]
		[AttributeLogicalName("enablelivepersonacarduci")]
		public bool? IndicatesWhetherTheUserHasEnabledOrDisabledLivePersonaCardFeatureInUCI
		{	
			get { return GetAttributeValue<bool?>("enablelivepersonacarduci"); }
			set
			{ 
				if(value == IndicatesWhetherTheUserHasEnabledOrDisabledLivePersonaCardFeatureInUCI) return;
				SetAttributeValue("enablelivepersonacarduci", value);
			}
		}	
			
		/// <summary>
        /// enablelivepersoncardintegrationinoffice
        /// </summary>
		[DisplayName("Indicates whether the user has enabled or disabled LivePersonCardIntegration in Office.")]
		[AttributeLogicalName("enablelivepersoncardintegrationinoffice")]
		public bool? IndicatesWhetherTheUserHasEnabledOrDisabledLivePersonCardIntegrationInOffice
		{	
			get { return GetAttributeValue<bool?>("enablelivepersoncardintegrationinoffice"); }
			set
			{ 
				if(value == IndicatesWhetherTheUserHasEnabledOrDisabledLivePersonCardIntegrationInOffice) return;
				SetAttributeValue("enablelivepersoncardintegrationinoffice", value);
			}
		}	
			
		/// <summary>
        /// enablelpauthoring
        /// </summary>
		[DisplayName("Enable Learning Path Authoring")]
		[AttributeLogicalName("enablelpauthoring")]
		public bool? EnableLearningPathAuthoring
		{	
			get { return GetAttributeValue<bool?>("enablelpauthoring"); }
			set
			{ 
				if(value == EnableLearningPathAuthoring) return;
				SetAttributeValue("enablelpauthoring", value);
			}
		}	
			
		/// <summary>
        /// enablemicrosoftflowintegration
        /// </summary>
		[DisplayName("Enable Integration with Microsoft Flow")]
		[AttributeLogicalName("enablemicrosoftflowintegration")]
		public bool? EnableIntegrationWithMicrosoftFlow
		{	
			get { return GetAttributeValue<bool?>("enablemicrosoftflowintegration"); }
			set
			{ 
				if(value == EnableIntegrationWithMicrosoftFlow) return;
				SetAttributeValue("enablemicrosoftflowintegration", value);
			}
		}	
			
		/// <summary>
        /// enablepricingoncreate
        /// </summary>
		[DisplayName("Enable Pricing On Create")]
		[AttributeLogicalName("enablepricingoncreate")]
		public bool? EnablePricingOnCreate
		{	
			get { return GetAttributeValue<bool?>("enablepricingoncreate"); }
			set
			{ 
				if(value == EnablePricingOnCreate) return;
				SetAttributeValue("enablepricingoncreate", value);
			}
		}	
			
		/// <summary>
        /// enablesmartmatching
        /// </summary>
		[DisplayName("Enable Smart Matching")]
		[AttributeLogicalName("enablesmartmatching")]
		public bool? EnableSmartMatching
		{	
			get { return GetAttributeValue<bool?>("enablesmartmatching"); }
			set
			{ 
				if(value == EnableSmartMatching) return;
				SetAttributeValue("enablesmartmatching", value);
			}
		}	
			
		/// <summary>
        /// enableunifiedinterfaceshellrefresh
        /// </summary>
		[DisplayName("Enable site map and commanding update")]
		[AttributeLogicalName("enableunifiedinterfaceshellrefresh")]
		public bool? EnableSiteMapAndCommandingUpdate
		{	
			get { return GetAttributeValue<bool?>("enableunifiedinterfaceshellrefresh"); }
			set
			{ 
				if(value == EnableSiteMapAndCommandingUpdate) return;
				SetAttributeValue("enableunifiedinterfaceshellrefresh", value);
			}
		}	
			
		/// <summary>
        /// enforcereadonlyplugins
        /// </summary>
		[DisplayName("Organization setting to enforce read only plugins.")]
		[AttributeLogicalName("enforcereadonlyplugins")]
		public bool? OrganizationSettingToEnforceReadOnlyPlugins
		{	
			get { return GetAttributeValue<bool?>("enforcereadonlyplugins"); }
			set
			{ 
				if(value == OrganizationSettingToEnforceReadOnlyPlugins) return;
				SetAttributeValue("enforcereadonlyplugins", value);
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
        /// expirechangetrackingindays
        /// </summary>
		[DisplayName("Days to Expire Change Tracking Deleted Records")]
		[AttributeLogicalName("expirechangetrackingindays")]
		public int? DaysToExpireChangeTrackingDeletedRecords
		{	
			get { return GetAttributeValue<int?>("expirechangetrackingindays"); }
			set
			{ 
				if(value == DaysToExpireChangeTrackingDeletedRecords) return;
				SetAttributeValue("expirechangetrackingindays", value);
			}
		}	
			
		/// <summary>
        /// expiresubscriptionsindays
        /// </summary>
		[DisplayName("Days to Expire Subscriptions")]
		[AttributeLogicalName("expiresubscriptionsindays")]
		public int? DaysToExpireSubscriptions
		{	
			get { return GetAttributeValue<int?>("expiresubscriptionsindays"); }
			set
			{ 
				if(value == DaysToExpireSubscriptions) return;
				SetAttributeValue("expiresubscriptionsindays", value);
			}
		}	
			
		/// <summary>
        /// externalbaseurl
        /// </summary>
		[DisplayName("External Base URL")]
		[AttributeLogicalName("externalbaseurl")]
		public string ExternalBaseURL
		{	
			get { return GetAttributeValue<string>("externalbaseurl"); }
			set
			{ 
				if(value == ExternalBaseURL) return;
				SetAttributeValue("externalbaseurl", value);
			}
		}	
			
		/// <summary>
        /// externalpartycorrelationkeys
        /// </summary>
		[DisplayName("ExternalPartyEnabled Entities correlation Keys")]
		[AttributeLogicalName("externalpartycorrelationkeys")]
		public string ExternalPartyEnabledEntitiesCorrelationKeys
		{	
			get { return GetAttributeValue<string>("externalpartycorrelationkeys"); }
			set
			{ 
				if(value == ExternalPartyEnabledEntitiesCorrelationKeys) return;
				SetAttributeValue("externalpartycorrelationkeys", value);
			}
		}	
			
		/// <summary>
        /// externalpartyentitysettings
        /// </summary>
		[DisplayName("ExternalPartyEnabled Entities Settings.For internal use only")]
		[AttributeLogicalName("externalpartyentitysettings")]
		public string ExternalPartyEnabledEntitiesSettingsForInternalUseOnly
		{	
			get { return GetAttributeValue<string>("externalpartyentitysettings"); }
			set
			{ 
				if(value == ExternalPartyEnabledEntitiesSettingsForInternalUseOnly) return;
				SetAttributeValue("externalpartyentitysettings", value);
			}
		}	
			
		/// <summary>
        /// featureset
        /// </summary>
		[DisplayName("Feature Set")]
		[AttributeLogicalName("featureset")]
		public string FeatureSet
		{	
			get { return GetAttributeValue<string>("featureset"); }
			set
			{ 
				if(value == FeatureSet) return;
				SetAttributeValue("featureset", value);
			}
		}	
			
		/// <summary>
        /// fiscalcalendarstart
        /// </summary>
		[DisplayName("Fiscal Calendar Start")]
		[AttributeLogicalName("fiscalcalendarstart")]
		public DateTime? FiscalCalendarStart
		{	
			get { return GetAttributeValue<DateTime?>("fiscalcalendarstart"); }
			set
			{ 
				if(value == FiscalCalendarStart) return;
				SetAttributeValue("fiscalcalendarstart", value);
			}
		}	
			
		/// <summary>
        /// fiscalperiodformat
        /// </summary>
		[DisplayName("Fiscal Period Format")]
		[AttributeLogicalName("fiscalperiodformat")]
		public string FiscalPeriodFormat
		{	
			get { return GetAttributeValue<string>("fiscalperiodformat"); }
			set
			{ 
				if(value == FiscalPeriodFormat) return;
				SetAttributeValue("fiscalperiodformat", value);
			}
		}	
			
		/// <summary>
        /// fiscalperiodformatperiod
        /// </summary>
		[DisplayName("Format for Fiscal Period")]
		[AttributeLogicalName("fiscalperiodformatperiod")]
		public eFiscalPeriodFormat? FormatForFiscalPeriod
		{	
			get 
			{ 
				var optionSetValue = GetAttributeValue<OptionSetValue>("fiscalperiodformatperiod");
				if (optionSetValue != null) return (eFiscalPeriodFormat)optionSetValue.Value;
				else return null;
			}
			set 
			{ 
				if(value == FormatForFiscalPeriod) return;

				OptionSetValue optionSetValue = null;
				if(value != null) optionSetValue = new OptionSetValue((int)value);
				SetAttributeValue("fiscalperiodformatperiod", optionSetValue); 
			}
		}

		/// <summary>
        /// fiscalperiodtype
        /// </summary>
		[DisplayName("Fiscal Period Type")]
		[AttributeLogicalName("fiscalperiodtype")]
		public int? FiscalPeriodType
		{	
			get { return GetAttributeValue<int?>("fiscalperiodtype"); }
			set
			{ 
				if(value == FiscalPeriodType) return;
				SetAttributeValue("fiscalperiodtype", value);
			}
		}	
			
		/// <summary>
        /// fiscalsettingsupdated
        /// </summary>
		[DisplayName("Is Fiscal Settings Updated")]
		[AttributeLogicalName("fiscalsettingsupdated")]
		public bool? IsFiscalSettingsUpdated
		{	
			get { return GetAttributeValue<bool?>("fiscalsettingsupdated"); }
			set
			{ 
				if(value == IsFiscalSettingsUpdated) return;
				SetAttributeValue("fiscalsettingsupdated", value);
			}
		}	
			
		/// <summary>
        /// fiscalyeardisplaycode
        /// </summary>
		[DisplayName("Fiscal Year Display")]
		[AttributeLogicalName("fiscalyeardisplaycode")]
		public int? FiscalYearDisplay
		{	
			get { return GetAttributeValue<int?>("fiscalyeardisplaycode"); }
			set
			{ 
				if(value == FiscalYearDisplay) return;
				SetAttributeValue("fiscalyeardisplaycode", value);
			}
		}	
			
		/// <summary>
        /// fiscalyearformat
        /// </summary>
		[DisplayName("Fiscal Year Format")]
		[AttributeLogicalName("fiscalyearformat")]
		public string FiscalYearFormat
		{	
			get { return GetAttributeValue<string>("fiscalyearformat"); }
			set
			{ 
				if(value == FiscalYearFormat) return;
				SetAttributeValue("fiscalyearformat", value);
			}
		}	
			
		/// <summary>
        /// fiscalyearformatprefix
        /// </summary>
		[DisplayName("Prefix for Fiscal Year")]
		[AttributeLogicalName("fiscalyearformatprefix")]
		public eFiscalYearFormatPrefix? PrefixForFiscalYear
		{	
			get 
			{ 
				var optionSetValue = GetAttributeValue<OptionSetValue>("fiscalyearformatprefix");
				if (optionSetValue != null) return (eFiscalYearFormatPrefix)optionSetValue.Value;
				else return null;
			}
			set 
			{ 
				if(value == PrefixForFiscalYear) return;

				OptionSetValue optionSetValue = null;
				if(value != null) optionSetValue = new OptionSetValue((int)value);
				SetAttributeValue("fiscalyearformatprefix", optionSetValue); 
			}
		}

		/// <summary>
        /// fiscalyearformatsuffix
        /// </summary>
		[DisplayName("Suffix for Fiscal Year")]
		[AttributeLogicalName("fiscalyearformatsuffix")]
		public eFiscalYearFormatSuffix? SuffixForFiscalYear
		{	
			get 
			{ 
				var optionSetValue = GetAttributeValue<OptionSetValue>("fiscalyearformatsuffix");
				if (optionSetValue != null) return (eFiscalYearFormatSuffix)optionSetValue.Value;
				else return null;
			}
			set 
			{ 
				if(value == SuffixForFiscalYear) return;

				OptionSetValue optionSetValue = null;
				if(value != null) optionSetValue = new OptionSetValue((int)value);
				SetAttributeValue("fiscalyearformatsuffix", optionSetValue); 
			}
		}

		/// <summary>
        /// fiscalyearformatyear
        /// </summary>
		[DisplayName("Fiscal Year Format Year")]
		[AttributeLogicalName("fiscalyearformatyear")]
		public eFiscalYearFormat? FiscalYearFormatYear
		{	
			get 
			{ 
				var optionSetValue = GetAttributeValue<OptionSetValue>("fiscalyearformatyear");
				if (optionSetValue != null) return (eFiscalYearFormat)optionSetValue.Value;
				else return null;
			}
			set 
			{ 
				if(value == FiscalYearFormatYear) return;

				OptionSetValue optionSetValue = null;
				if(value != null) optionSetValue = new OptionSetValue((int)value);
				SetAttributeValue("fiscalyearformatyear", optionSetValue); 
			}
		}

		/// <summary>
        /// fiscalyearperiodconnect
        /// </summary>
		[DisplayName("Fiscal Year Period Connector")]
		[AttributeLogicalName("fiscalyearperiodconnect")]
		public string FiscalYearPeriodConnector
		{	
			get { return GetAttributeValue<string>("fiscalyearperiodconnect"); }
			set
			{ 
				if(value == FiscalYearPeriodConnector) return;
				SetAttributeValue("fiscalyearperiodconnect", value);
			}
		}	
			
		/// <summary>
        /// fullnameconventioncode
        /// </summary>
		[DisplayName("Full Name Display Order")]
		[AttributeLogicalName("fullnameconventioncode")]
		public eOrganizationFullnameconventioncode? FullNameDisplayOrder
		{	
			get 
			{ 
				var optionSetValue = GetAttributeValue<OptionSetValue>("fullnameconventioncode");
				if (optionSetValue != null) return (eOrganizationFullnameconventioncode)optionSetValue.Value;
				else return null;
			}
			set 
			{ 
				if(value == FullNameDisplayOrder) return;

				OptionSetValue optionSetValue = null;
				if(value != null) optionSetValue = new OptionSetValue((int)value);
				SetAttributeValue("fullnameconventioncode", optionSetValue); 
			}
		}

		/// <summary>
        /// futureexpansionwindow
        /// </summary>
		[DisplayName("Future Expansion Window")]
		[AttributeLogicalName("futureexpansionwindow")]
		public int? FutureExpansionWindow
		{	
			get { return GetAttributeValue<int?>("futureexpansionwindow"); }
			set
			{ 
				if(value == FutureExpansionWindow) return;
				SetAttributeValue("futureexpansionwindow", value);
			}
		}	
			
		/// <summary>
        /// generatealertsforerrors
        /// </summary>
		[DisplayName("Generate Alerts For Errors")]
		[AttributeLogicalName("generatealertsforerrors")]
		public bool? GenerateAlertsForErrors
		{	
			get { return GetAttributeValue<bool?>("generatealertsforerrors"); }
			set
			{ 
				if(value == GenerateAlertsForErrors) return;
				SetAttributeValue("generatealertsforerrors", value);
			}
		}	
			
		/// <summary>
        /// generatealertsforinformation
        /// </summary>
		[DisplayName("Generate Alerts For Information")]
		[AttributeLogicalName("generatealertsforinformation")]
		public bool? GenerateAlertsForInformation
		{	
			get { return GetAttributeValue<bool?>("generatealertsforinformation"); }
			set
			{ 
				if(value == GenerateAlertsForInformation) return;
				SetAttributeValue("generatealertsforinformation", value);
			}
		}	
			
		/// <summary>
        /// generatealertsforwarnings
        /// </summary>
		[DisplayName("Generate Alerts For Warnings")]
		[AttributeLogicalName("generatealertsforwarnings")]
		public bool? GenerateAlertsForWarnings
		{	
			get { return GetAttributeValue<bool?>("generatealertsforwarnings"); }
			set
			{ 
				if(value == GenerateAlertsForWarnings) return;
				SetAttributeValue("generatealertsforwarnings", value);
			}
		}	
			
		/// <summary>
        /// getstartedpanecontentenabled
        /// </summary>
		[DisplayName("Is Get Started Pane Content Enabled")]
		[AttributeLogicalName("getstartedpanecontentenabled")]
		public bool? IsGetStartedPaneContentEnabled
		{	
			get { return GetAttributeValue<bool?>("getstartedpanecontentenabled"); }
			set
			{ 
				if(value == IsGetStartedPaneContentEnabled) return;
				SetAttributeValue("getstartedpanecontentenabled", value);
			}
		}	
			
		/// <summary>
        /// globalappendurlparametersenabled
        /// </summary>
		[DisplayName("Is AppendUrl Parameters enabled")]
		[AttributeLogicalName("globalappendurlparametersenabled")]
		public bool? IsAppendUrlParametersEnabled
		{	
			get { return GetAttributeValue<bool?>("globalappendurlparametersenabled"); }
			set
			{ 
				if(value == IsAppendUrlParametersEnabled) return;
				SetAttributeValue("globalappendurlparametersenabled", value);
			}
		}	
			
		/// <summary>
        /// globalhelpurl
        /// </summary>
		[DisplayName("Global Help URL.")]
		[AttributeLogicalName("globalhelpurl")]
		public string GlobalHelpURL
		{	
			get { return GetAttributeValue<string>("globalhelpurl"); }
			set
			{ 
				if(value == GlobalHelpURL) return;
				SetAttributeValue("globalhelpurl", value);
			}
		}	
			
		/// <summary>
        /// globalhelpurlenabled
        /// </summary>
		[DisplayName("Is Customizable Global Help enabled")]
		[AttributeLogicalName("globalhelpurlenabled")]
		public bool? IsCustomizableGlobalHelpEnabled
		{	
			get { return GetAttributeValue<bool?>("globalhelpurlenabled"); }
			set
			{ 
				if(value == IsCustomizableGlobalHelpEnabled) return;
				SetAttributeValue("globalhelpurlenabled", value);
			}
		}	
			
		/// <summary>
        /// goalrollupexpirytime
        /// </summary>
		[DisplayName("Rollup Expiration Time for Goal")]
		[AttributeLogicalName("goalrollupexpirytime")]
		public int? RollupExpirationTimeForGoal
		{	
			get { return GetAttributeValue<int?>("goalrollupexpirytime"); }
			set
			{ 
				if(value == RollupExpirationTimeForGoal) return;
				SetAttributeValue("goalrollupexpirytime", value);
			}
		}	
			
		/// <summary>
        /// goalrollupfrequency
        /// </summary>
		[DisplayName("Automatic Rollup Frequency for Goal")]
		[AttributeLogicalName("goalrollupfrequency")]
		public int? AutomaticRollupFrequencyForGoal
		{	
			get { return GetAttributeValue<int?>("goalrollupfrequency"); }
			set
			{ 
				if(value == AutomaticRollupFrequencyForGoal) return;
				SetAttributeValue("goalrollupfrequency", value);
			}
		}	
			
		/// <summary>
        /// grantaccesstonetworkservice
        /// </summary>
		[DisplayName("Grant Access To Network Service")]
		[AttributeLogicalName("grantaccesstonetworkservice")]
		public bool? GrantAccessToNetworkService
		{	
			get { return GetAttributeValue<bool?>("grantaccesstonetworkservice"); }
			set
			{ 
				if(value == GrantAccessToNetworkService) return;
				SetAttributeValue("grantaccesstonetworkservice", value);
			}
		}	
			
		/// <summary>
        /// hashdeltasubjectcount
        /// </summary>
		[DisplayName("Hash Delta Subject Count")]
		[AttributeLogicalName("hashdeltasubjectcount")]
		public int? HashDeltaSubjectCount
		{	
			get { return GetAttributeValue<int?>("hashdeltasubjectcount"); }
			set
			{ 
				if(value == HashDeltaSubjectCount) return;
				SetAttributeValue("hashdeltasubjectcount", value);
			}
		}	
			
		/// <summary>
        /// hashfilterkeywords
        /// </summary>
		[DisplayName("Hash Filter Keywords")]
		[AttributeLogicalName("hashfilterkeywords")]
		public string HashFilterKeywords
		{	
			get { return GetAttributeValue<string>("hashfilterkeywords"); }
			set
			{ 
				if(value == HashFilterKeywords) return;
				SetAttributeValue("hashfilterkeywords", value);
			}
		}	
			
		/// <summary>
        /// hashmaxcount
        /// </summary>
		[DisplayName("Hash Max Count")]
		[AttributeLogicalName("hashmaxcount")]
		public int? HashMaxCount
		{	
			get { return GetAttributeValue<int?>("hashmaxcount"); }
			set
			{ 
				if(value == HashMaxCount) return;
				SetAttributeValue("hashmaxcount", value);
			}
		}	
			
		/// <summary>
        /// hashminaddresscount
        /// </summary>
		[DisplayName("Hash Min Address Count")]
		[AttributeLogicalName("hashminaddresscount")]
		public int? HashMinAddressCount
		{	
			get { return GetAttributeValue<int?>("hashminaddresscount"); }
			set
			{ 
				if(value == HashMinAddressCount) return;
				SetAttributeValue("hashminaddresscount", value);
			}
		}	
			
		/// <summary>
        /// highcontrastthemedata
        /// </summary>
		[DisplayName("High contrast Theme Data")]
		[AttributeLogicalName("highcontrastthemedata")]
		public string HighContrastThemeData
		{	
			get { return GetAttributeValue<string>("highcontrastthemedata"); }
			set
			{ 
				if(value == HighContrastThemeData) return;
				SetAttributeValue("highcontrastthemedata", value);
			}
		}	
			
		/// <summary>
        /// ignoreinternalemail
        /// </summary>
		[DisplayName("Ignore Internal Email")]
		[AttributeLogicalName("ignoreinternalemail")]
		public bool? IgnoreInternalEmail
		{	
			get { return GetAttributeValue<bool?>("ignoreinternalemail"); }
			set
			{ 
				if(value == IgnoreInternalEmail) return;
				SetAttributeValue("ignoreinternalemail", value);
			}
		}	
			
		/// <summary>
        /// inactivitytimeoutenabled
        /// </summary>
		[DisplayName("Inactivity timeout enabled")]
		[AttributeLogicalName("inactivitytimeoutenabled")]
		public bool? InactivityTimeoutEnabled
		{	
			get { return GetAttributeValue<bool?>("inactivitytimeoutenabled"); }
			set
			{ 
				if(value == InactivityTimeoutEnabled) return;
				SetAttributeValue("inactivitytimeoutenabled", value);
			}
		}	
			
		/// <summary>
        /// inactivitytimeoutinmins
        /// </summary>
		[DisplayName("Inactivity timeout in minutes")]
		[AttributeLogicalName("inactivitytimeoutinmins")]
		public int? InactivityTimeoutInMinutes
		{	
			get { return GetAttributeValue<int?>("inactivitytimeoutinmins"); }
			set
			{ 
				if(value == InactivityTimeoutInMinutes) return;
				SetAttributeValue("inactivitytimeoutinmins", value);
			}
		}	
			
		/// <summary>
        /// inactivitytimeoutreminderinmins
        /// </summary>
		[DisplayName("Inactivity timeout reminder in minutes")]
		[AttributeLogicalName("inactivitytimeoutreminderinmins")]
		public int? InactivityTimeoutReminderInMinutes
		{	
			get { return GetAttributeValue<int?>("inactivitytimeoutreminderinmins"); }
			set
			{ 
				if(value == InactivityTimeoutReminderInMinutes) return;
				SetAttributeValue("inactivitytimeoutreminderinmins", value);
			}
		}	
			
		/// <summary>
        /// incomingemailexchangeemailretrievalbatchsize
        /// </summary>
		[DisplayName("Exchange Email Retrieval Batch Size")]
		[AttributeLogicalName("incomingemailexchangeemailretrievalbatchsize")]
		public int? ExchangeEmailRetrievalBatchSize
		{	
			get { return GetAttributeValue<int?>("incomingemailexchangeemailretrievalbatchsize"); }
			set
			{ 
				if(value == ExchangeEmailRetrievalBatchSize) return;
				SetAttributeValue("incomingemailexchangeemailretrievalbatchsize", value);
			}
		}	
			
		/// <summary>
        /// initialversion
        /// </summary>
		[DisplayName("Initial Version")]
		[AttributeLogicalName("initialversion")]
		public string InitialVersion
		{	
			get { return GetAttributeValue<string>("initialversion"); }
			set
			{ 
				if(value == InitialVersion) return;
				SetAttributeValue("initialversion", value);
			}
		}	
			
		/// <summary>
        /// integrationuserid
        /// </summary>
		[DisplayName("Integration User")]
		[AttributeLogicalName("integrationuserid")]
		public Guid IntegrationUserId
		{	
			get { return GetAttributeValue<Guid>("integrationuserid"); }
			set
			{ 
				if(value == IntegrationUserId) return;
				SetAttributeValue("integrationuserid", value);
			}
		}	
			
		/// <summary>
        /// invoiceprefix
        /// </summary>
		[DisplayName("Invoice Prefix")]
		[AttributeLogicalName("invoiceprefix")]
		public string InvoicePrefix
		{	
			get { return GetAttributeValue<string>("invoiceprefix"); }
			set
			{ 
				if(value == InvoicePrefix) return;
				SetAttributeValue("invoiceprefix", value);
			}
		}	
			
		/// <summary>
        /// isactioncardenabled
        /// </summary>
		[DisplayName("Enable Action Card for this Organization")]
		[AttributeLogicalName("isactioncardenabled")]
		public bool? EnableActionCardForThisOrganization
		{	
			get { return GetAttributeValue<bool?>("isactioncardenabled"); }
			set
			{ 
				if(value == EnableActionCardForThisOrganization) return;
				SetAttributeValue("isactioncardenabled", value);
			}
		}	
			
		/// <summary>
        /// isactionsupportfeatureenabled
        /// </summary>
		[DisplayName("Action Support Feature enabled")]
		[AttributeLogicalName("isactionsupportfeatureenabled")]
		public bool? ActionSupportFeatureEnabled
		{	
			get { return GetAttributeValue<bool?>("isactionsupportfeatureenabled"); }
			set
			{ 
				if(value == ActionSupportFeatureEnabled) return;
				SetAttributeValue("isactionsupportfeatureenabled", value);
			}
		}	
			
		/// <summary>
        /// isactivityanalysisenabled
        /// </summary>
		[DisplayName("Enable Relationship Analytics for this Organization")]
		[AttributeLogicalName("isactivityanalysisenabled")]
		public bool? EnableRelationshipAnalyticsForThisOrganization
		{	
			get { return GetAttributeValue<bool?>("isactivityanalysisenabled"); }
			set
			{ 
				if(value == EnableRelationshipAnalyticsForThisOrganization) return;
				SetAttributeValue("isactivityanalysisenabled", value);
			}
		}	
			
		/// <summary>
        /// isallmoneydecimal
        /// </summary>
		[DisplayName("Set if all money attributes are converted to decimal")]
		[AttributeLogicalName("isallmoneydecimal")]
		public bool? SetIfAllMoneyAttributesAreConvertedToDecimal
		{	
			get { return GetAttributeValue<bool?>("isallmoneydecimal"); }
			set
			{ 
				if(value == SetIfAllMoneyAttributesAreConvertedToDecimal) return;
				SetAttributeValue("isallmoneydecimal", value);
			}
		}	
			
		/// <summary>
        /// isappmode
        /// </summary>
		[DisplayName("Is Application Mode Enabled")]
		[AttributeLogicalName("isappmode")]
		public bool? IsApplicationModeEnabled
		{	
			get { return GetAttributeValue<bool?>("isappmode"); }
			set
			{ 
				if(value == IsApplicationModeEnabled) return;
				SetAttributeValue("isappmode", value);
			}
		}	
			
		/// <summary>
        /// isappointmentattachmentsyncenabled
        /// </summary>
		[DisplayName("Is Attachment Sync Enabled")]
		[AttributeLogicalName("isappointmentattachmentsyncenabled")]
		public bool? IsAttachmentSyncEnabled
		{	
			get { return GetAttributeValue<bool?>("isappointmentattachmentsyncenabled"); }
			set
			{ 
				if(value == IsAttachmentSyncEnabled) return;
				SetAttributeValue("isappointmentattachmentsyncenabled", value);
			}
		}	
			
		/// <summary>
        /// isassignedtaskssyncenabled
        /// </summary>
		[DisplayName("Is Assigned Tasks Sync Enabled")]
		[AttributeLogicalName("isassignedtaskssyncenabled")]
		public bool? IsAssignedTasksSyncEnabled
		{	
			get { return GetAttributeValue<bool?>("isassignedtaskssyncenabled"); }
			set
			{ 
				if(value == IsAssignedTasksSyncEnabled) return;
				SetAttributeValue("isassignedtaskssyncenabled", value);
			}
		}	
			
		/// <summary>
        /// isauditenabled
        /// </summary>
		[DisplayName("Is Auditing Enabled")]
		[AttributeLogicalName("isauditenabled")]
		public bool? IsAuditingEnabled
		{	
			get { return GetAttributeValue<bool?>("isauditenabled"); }
			set
			{ 
				if(value == IsAuditingEnabled) return;
				SetAttributeValue("isauditenabled", value);
			}
		}	
			
		/// <summary>
        /// isautodatacaptureenabled
        /// </summary>
		[DisplayName("Enable Auto Capture for this Organization")]
		[AttributeLogicalName("isautodatacaptureenabled")]
		public bool? EnableAutoCaptureForThisOrganization
		{	
			get { return GetAttributeValue<bool?>("isautodatacaptureenabled"); }
			set
			{ 
				if(value == EnableAutoCaptureForThisOrganization) return;
				SetAttributeValue("isautodatacaptureenabled", value);
			}
		}	
			
		/// <summary>
        /// isautodatacapturev2enabled
        /// </summary>
		[DisplayName("Enable Auto Capture V2 for this Organization")]
		[AttributeLogicalName("isautodatacapturev2enabled")]
		public bool? EnableAutoCaptureV2ForThisOrganization
		{	
			get { return GetAttributeValue<bool?>("isautodatacapturev2enabled"); }
			set
			{ 
				if(value == EnableAutoCaptureV2ForThisOrganization) return;
				SetAttributeValue("isautodatacapturev2enabled", value);
			}
		}	
			
		/// <summary>
        /// isautosaveenabled
        /// </summary>
		[DisplayName("Auto Save Enabled")]
		[AttributeLogicalName("isautosaveenabled")]
		public bool? AutoSaveEnabled
		{	
			get { return GetAttributeValue<bool?>("isautosaveenabled"); }
			set
			{ 
				if(value == AutoSaveEnabled) return;
				SetAttributeValue("isautosaveenabled", value);
			}
		}	
			
		/// <summary>
        /// isbpfentitycustomizationfeatureenabled
        /// </summary>
		[DisplayName("BPF Entity Customization Feature enabled")]
		[AttributeLogicalName("isbpfentitycustomizationfeatureenabled")]
		public bool? BPFEntityCustomizationFeatureEnabled
		{	
			get { return GetAttributeValue<bool?>("isbpfentitycustomizationfeatureenabled"); }
			set
			{ 
				if(value == BPFEntityCustomizationFeatureEnabled) return;
				SetAttributeValue("isbpfentitycustomizationfeatureenabled", value);
			}
		}	
			
		/// <summary>
        /// isconflictdetectionenabledformobileclient
        /// </summary>
		[DisplayName("Is Conflict Detection for Mobile Client enabled")]
		[AttributeLogicalName("isconflictdetectionenabledformobileclient")]
		public bool? IsConflictDetectionForMobileClientEnabled
		{	
			get { return GetAttributeValue<bool?>("isconflictdetectionenabledformobileclient"); }
			set
			{ 
				if(value == IsConflictDetectionForMobileClientEnabled) return;
				SetAttributeValue("isconflictdetectionenabledformobileclient", value);
			}
		}	
			
		/// <summary>
        /// iscontactmailingaddresssyncenabled
        /// </summary>
		[DisplayName("Is Mailing Address Sync Enabled")]
		[AttributeLogicalName("iscontactmailingaddresssyncenabled")]
		public bool? IsMailingAddressSyncEnabled
		{	
			get { return GetAttributeValue<bool?>("iscontactmailingaddresssyncenabled"); }
			set
			{ 
				if(value == IsMailingAddressSyncEnabled) return;
				SetAttributeValue("iscontactmailingaddresssyncenabled", value);
			}
		}	
			
		/// <summary>
        /// iscontentsecuritypolicyenabled
        /// </summary>
		[DisplayName("Enable Content Security Policy for this organization")]
		[AttributeLogicalName("iscontentsecuritypolicyenabled")]
		public bool? EnableContentSecurityPolicyForThisOrganization
		{	
			get { return GetAttributeValue<bool?>("iscontentsecuritypolicyenabled"); }
			set
			{ 
				if(value == EnableContentSecurityPolicyForThisOrganization) return;
				SetAttributeValue("iscontentsecuritypolicyenabled", value);
			}
		}	
			
		/// <summary>
        /// iscontextualemailenabled
        /// </summary>
		[DisplayName("Indicates whether Contextual email experience is enabled on this organization")]
		[AttributeLogicalName("iscontextualemailenabled")]
		public bool? IndicatesWhetherContextualEmailExperienceIsEnabledOnThisOrganization
		{	
			get { return GetAttributeValue<bool?>("iscontextualemailenabled"); }
			set
			{ 
				if(value == IndicatesWhetherContextualEmailExperienceIsEnabledOnThisOrganization) return;
				SetAttributeValue("iscontextualemailenabled", value);
			}
		}	
			
		/// <summary>
        /// iscontextualhelpenabled
        /// </summary>
		[DisplayName("Enables Contextual Help in UCI")]
		[AttributeLogicalName("iscontextualhelpenabled")]
		public bool? EnablesContextualHelpInUCI
		{	
			get { return GetAttributeValue<bool?>("iscontextualhelpenabled"); }
			set
			{ 
				if(value == EnablesContextualHelpInUCI) return;
				SetAttributeValue("iscontextualhelpenabled", value);
			}
		}	
			
		/// <summary>
        /// iscustomcontrolsincanvasappsenabled
        /// </summary>
		[DisplayName("Enable Custom Controls in canvas PowerApps feature for this organization")]
		[AttributeLogicalName("iscustomcontrolsincanvasappsenabled")]
		public bool? EnableCustomControlsInCanvasPowerAppsFeatureForThisOrganization
		{	
			get { return GetAttributeValue<bool?>("iscustomcontrolsincanvasappsenabled"); }
			set
			{ 
				if(value == EnableCustomControlsInCanvasPowerAppsFeatureForThisOrganization) return;
				SetAttributeValue("iscustomcontrolsincanvasappsenabled", value);
			}
		}	
			
		/// <summary>
        /// isdefaultcountrycodecheckenabled
        /// </summary>
		[DisplayName("Enable or disable country code selection")]
		[AttributeLogicalName("isdefaultcountrycodecheckenabled")]
		public bool? EnableOrDisableCountryCodeSelection
		{	
			get { return GetAttributeValue<bool?>("isdefaultcountrycodecheckenabled"); }
			set
			{ 
				if(value == EnableOrDisableCountryCodeSelection) return;
				SetAttributeValue("isdefaultcountrycodecheckenabled", value);
			}
		}	
			
		/// <summary>
        /// isdelegateaccessenabled
        /// </summary>
		[DisplayName("Is Delegation Access Enabled")]
		[AttributeLogicalName("isdelegateaccessenabled")]
		public bool? IsDelegationAccessEnabled
		{	
			get { return GetAttributeValue<bool?>("isdelegateaccessenabled"); }
			set
			{ 
				if(value == IsDelegationAccessEnabled) return;
				SetAttributeValue("isdelegateaccessenabled", value);
			}
		}	
			
		/// <summary>
        /// isdelveactionhubintegrationenabled
        /// </summary>
		[DisplayName("Enable Action Hub for this Organization")]
		[AttributeLogicalName("isdelveactionhubintegrationenabled")]
		public bool? EnableActionHubForThisOrganization
		{	
			get { return GetAttributeValue<bool?>("isdelveactionhubintegrationenabled"); }
			set
			{ 
				if(value == EnableActionHubForThisOrganization) return;
				SetAttributeValue("isdelveactionhubintegrationenabled", value);
			}
		}	
			
		/// <summary>
        /// isdisabled
        /// </summary>
		[DisplayName("Is Organization Disabled")]
		[AttributeLogicalName("isdisabled")]
		public bool? IsOrganizationDisabled
		{	
			get { return GetAttributeValue<bool?>("isdisabled"); }
			set
			{ 
				if(value == IsOrganizationDisabled) return;
				SetAttributeValue("isdisabled", value);
			}
		}	
			
		/// <summary>
        /// isduplicatedetectionenabled
        /// </summary>
		[DisplayName("Is Duplicate Detection Enabled")]
		[AttributeLogicalName("isduplicatedetectionenabled")]
		public bool? IsDuplicateDetectionEnabled
		{	
			get { return GetAttributeValue<bool?>("isduplicatedetectionenabled"); }
			set
			{ 
				if(value == IsDuplicateDetectionEnabled) return;
				SetAttributeValue("isduplicatedetectionenabled", value);
			}
		}	
			
		/// <summary>
        /// isduplicatedetectionenabledforimport
        /// </summary>
		[DisplayName("Is Duplicate Detection Enabled For Import")]
		[AttributeLogicalName("isduplicatedetectionenabledforimport")]
		public bool? IsDuplicateDetectionEnabledForImport
		{	
			get { return GetAttributeValue<bool?>("isduplicatedetectionenabledforimport"); }
			set
			{ 
				if(value == IsDuplicateDetectionEnabledForImport) return;
				SetAttributeValue("isduplicatedetectionenabledforimport", value);
			}
		}	
			
		/// <summary>
        /// isduplicatedetectionenabledforofflinesync
        /// </summary>
		[DisplayName("Is Duplicate Detection Enabled For Offline Synchronization")]
		[AttributeLogicalName("isduplicatedetectionenabledforofflinesync")]
		public bool? IsDuplicateDetectionEnabledForOfflineSynchronization
		{	
			get { return GetAttributeValue<bool?>("isduplicatedetectionenabledforofflinesync"); }
			set
			{ 
				if(value == IsDuplicateDetectionEnabledForOfflineSynchronization) return;
				SetAttributeValue("isduplicatedetectionenabledforofflinesync", value);
			}
		}	
			
		/// <summary>
        /// isduplicatedetectionenabledforonlinecreateupdate
        /// </summary>
		[DisplayName("Is Duplicate Detection Enabled for Online Create/Update")]
		[AttributeLogicalName("isduplicatedetectionenabledforonlinecreateupdate")]
		public bool? IsDuplicateDetectionEnabledForOnlineCreateUpdate
		{	
			get { return GetAttributeValue<bool?>("isduplicatedetectionenabledforonlinecreateupdate"); }
			set
			{ 
				if(value == IsDuplicateDetectionEnabledForOnlineCreateUpdate) return;
				SetAttributeValue("isduplicatedetectionenabledforonlinecreateupdate", value);
			}
		}	
			
		/// <summary>
        /// isemailmonitoringallowed
        /// </summary>
		[DisplayName("Allow tracking recipient activity on sent emails")]
		[AttributeLogicalName("isemailmonitoringallowed")]
		public bool? AllowTrackingRecipientActivityOnSentEmails
		{	
			get { return GetAttributeValue<bool?>("isemailmonitoringallowed"); }
			set
			{ 
				if(value == AllowTrackingRecipientActivityOnSentEmails) return;
				SetAttributeValue("isemailmonitoringallowed", value);
			}
		}	
			
		/// <summary>
        /// isemailserverprofilecontentfilteringenabled
        /// </summary>
		[DisplayName("Is Email Server Profile Content Filtering Enabled")]
		[AttributeLogicalName("isemailserverprofilecontentfilteringenabled")]
		public bool? IsEmailServerProfileContentFilteringEnabled
		{	
			get { return GetAttributeValue<bool?>("isemailserverprofilecontentfilteringenabled"); }
			set
			{ 
				if(value == IsEmailServerProfileContentFilteringEnabled) return;
				SetAttributeValue("isemailserverprofilecontentfilteringenabled", value);
			}
		}	
			
		/// <summary>
        /// isenabledforallroles
        /// </summary>
		[DisplayName("option set values for isenabledforallroles")]
		[AttributeLogicalName("isenabledforallroles")]
		public bool? OptionSetValuesForIsenabledforallroles
		{	
			get { return GetAttributeValue<bool?>("isenabledforallroles"); }
			set
			{ 
				if(value == OptionSetValuesForIsenabledforallroles) return;
				SetAttributeValue("isenabledforallroles", value);
			}
		}	
			
		/// <summary>
        /// isexternalfilestorageenabled
        /// </summary>
		[DisplayName("Enable external file storage")]
		[AttributeLogicalName("isexternalfilestorageenabled")]
		public bool? EnableExternalFileStorage
		{	
			get { return GetAttributeValue<bool?>("isexternalfilestorageenabled"); }
			set
			{ 
				if(value == EnableExternalFileStorage) return;
				SetAttributeValue("isexternalfilestorageenabled", value);
			}
		}	
			
		/// <summary>
        /// isexternalsearchindexenabled
        /// </summary>
		[DisplayName("Enable external search data syncing")]
		[AttributeLogicalName("isexternalsearchindexenabled")]
		public bool? EnableExternalSearchDataSyncing
		{	
			get { return GetAttributeValue<bool?>("isexternalsearchindexenabled"); }
			set
			{ 
				if(value == EnableExternalSearchDataSyncing) return;
				SetAttributeValue("isexternalsearchindexenabled", value);
			}
		}	
			
		/// <summary>
        /// isfiscalperiodmonthbased
        /// </summary>
		[DisplayName("Is Fiscal Period Monthly")]
		[AttributeLogicalName("isfiscalperiodmonthbased")]
		public bool? IsFiscalPeriodMonthly
		{	
			get { return GetAttributeValue<bool?>("isfiscalperiodmonthbased"); }
			set
			{ 
				if(value == IsFiscalPeriodMonthly) return;
				SetAttributeValue("isfiscalperiodmonthbased", value);
			}
		}	
			
		/// <summary>
        /// isfolderautocreatedonsp
        /// </summary>
		[DisplayName("Automatically create folders")]
		[AttributeLogicalName("isfolderautocreatedonsp")]
		public bool? AutomaticallyCreateFolders
		{	
			get { return GetAttributeValue<bool?>("isfolderautocreatedonsp"); }
			set
			{ 
				if(value == AutomaticallyCreateFolders) return;
				SetAttributeValue("isfolderautocreatedonsp", value);
			}
		}	
			
		/// <summary>
        /// isfolderbasedtrackingenabled
        /// </summary>
		[DisplayName("Is Folder Based Tracking Enabled")]
		[AttributeLogicalName("isfolderbasedtrackingenabled")]
		public bool? IsFolderBasedTrackingEnabled
		{	
			get { return GetAttributeValue<bool?>("isfolderbasedtrackingenabled"); }
			set
			{ 
				if(value == IsFolderBasedTrackingEnabled) return;
				SetAttributeValue("isfolderbasedtrackingenabled", value);
			}
		}	
			
		/// <summary>
        /// isfulltextsearchenabled
        /// </summary>
		[DisplayName("Enable Full-text search for Quick Find")]
		[AttributeLogicalName("isfulltextsearchenabled")]
		public bool? EnableFulltextSearchForQuickFind
		{	
			get { return GetAttributeValue<bool?>("isfulltextsearchenabled"); }
			set
			{ 
				if(value == EnableFulltextSearchForQuickFind) return;
				SetAttributeValue("isfulltextsearchenabled", value);
			}
		}	
			
		/// <summary>
        /// isgeospatialazuremapsintegrationenabled
        /// </summary>
		[DisplayName("Enable geospatial Azure Maps integration.")]
		[AttributeLogicalName("isgeospatialazuremapsintegrationenabled")]
		public bool? EnableGeospatialAzureMapsIntegration
		{	
			get { return GetAttributeValue<bool?>("isgeospatialazuremapsintegrationenabled"); }
			set
			{ 
				if(value == EnableGeospatialAzureMapsIntegration) return;
				SetAttributeValue("isgeospatialazuremapsintegrationenabled", value);
			}
		}	
			
		/// <summary>
        /// ishierarchicalsecuritymodelenabled
        /// </summary>
		[DisplayName("Enable Hierarchical Security Model")]
		[AttributeLogicalName("ishierarchicalsecuritymodelenabled")]
		public bool? EnableHierarchicalSecurityModel
		{	
			get { return GetAttributeValue<bool?>("ishierarchicalsecuritymodelenabled"); }
			set
			{ 
				if(value == EnableHierarchicalSecurityModel) return;
				SetAttributeValue("ishierarchicalsecuritymodelenabled", value);
			}
		}	
			
		/// <summary>
        /// isluisenabledford365bot
        /// </summary>
		[DisplayName("LUIS Consent for Dynamics 365 Bot")]
		[AttributeLogicalName("isluisenabledford365bot")]
		public bool? LUISConsentForDynamics365Bot
		{	
			get { return GetAttributeValue<bool?>("isluisenabledford365bot"); }
			set
			{ 
				if(value == LUISConsentForDynamics365Bot) return;
				SetAttributeValue("isluisenabledford365bot", value);
			}
		}	
			
		/// <summary>
        /// ismailboxforcedunlockingenabled
        /// </summary>
		[DisplayName("Is Mailbox Forced Unlocking Enabled")]
		[AttributeLogicalName("ismailboxforcedunlockingenabled")]
		public bool? IsMailboxForcedUnlockingEnabled
		{	
			get { return GetAttributeValue<bool?>("ismailboxforcedunlockingenabled"); }
			set
			{ 
				if(value == IsMailboxForcedUnlockingEnabled) return;
				SetAttributeValue("ismailboxforcedunlockingenabled", value);
			}
		}	
			
		/// <summary>
        /// ismailboxinactivebackoffenabled
        /// </summary>
		[DisplayName("Is Mailbox Keep Alive Enabled")]
		[AttributeLogicalName("ismailboxinactivebackoffenabled")]
		public bool? IsMailboxKeepAliveEnabled
		{	
			get { return GetAttributeValue<bool?>("ismailboxinactivebackoffenabled"); }
			set
			{ 
				if(value == IsMailboxKeepAliveEnabled) return;
				SetAttributeValue("ismailboxinactivebackoffenabled", value);
			}
		}	
			
		/// <summary>
        /// ismanualsalesforecastingenabled
        /// </summary>
		[DisplayName("Enable Manual Sales Forecasting feature for this organization")]
		[AttributeLogicalName("ismanualsalesforecastingenabled")]
		public bool? EnableManualSalesForecastingFeatureForThisOrganization
		{	
			get { return GetAttributeValue<bool?>("ismanualsalesforecastingenabled"); }
			set
			{ 
				if(value == EnableManualSalesForecastingFeatureForThisOrganization) return;
				SetAttributeValue("ismanualsalesforecastingenabled", value);
			}
		}	
			
		/// <summary>
        /// ismobileclientondemandsyncenabled
        /// </summary>
		[DisplayName("Is Mobile Client On Demand Sync enabled")]
		[AttributeLogicalName("ismobileclientondemandsyncenabled")]
		public bool? IsMobileClientOnDemandSyncEnabled
		{	
			get { return GetAttributeValue<bool?>("ismobileclientondemandsyncenabled"); }
			set
			{ 
				if(value == IsMobileClientOnDemandSyncEnabled) return;
				SetAttributeValue("ismobileclientondemandsyncenabled", value);
			}
		}	
			
		/// <summary>
        /// ismobileofflineenabled
        /// </summary>
		[DisplayName("Enable MobileOffline for this Organization")]
		[AttributeLogicalName("ismobileofflineenabled")]
		public bool? EnableMobileOfflineForThisOrganization
		{	
			get { return GetAttributeValue<bool?>("ismobileofflineenabled"); }
			set
			{ 
				if(value == EnableMobileOfflineForThisOrganization) return;
				SetAttributeValue("ismobileofflineenabled", value);
			}
		}	
			
		/// <summary>
        /// ismodeldrivenappsinmsteamsenabled
        /// </summary>
		[DisplayName("Enable embedding Model Apps in Microsoft Teams")]
		[AttributeLogicalName("ismodeldrivenappsinmsteamsenabled")]
		public bool? EnableEmbeddingModelAppsInMicrosoftTeams
		{	
			get { return GetAttributeValue<bool?>("ismodeldrivenappsinmsteamsenabled"); }
			set
			{ 
				if(value == EnableEmbeddingModelAppsInMicrosoftTeams) return;
				SetAttributeValue("ismodeldrivenappsinmsteamsenabled", value);
			}
		}	
			
		/// <summary>
        /// ismsteamscollaborationenabled
        /// </summary>
		[DisplayName("Enable Microsoft Teams Collaboration for this organization")]
		[AttributeLogicalName("ismsteamscollaborationenabled")]
		public bool? EnableMicrosoftTeamsCollaborationForThisOrganization
		{	
			get { return GetAttributeValue<bool?>("ismsteamscollaborationenabled"); }
			set
			{ 
				if(value == EnableMicrosoftTeamsCollaborationForThisOrganization) return;
				SetAttributeValue("ismsteamscollaborationenabled", value);
			}
		}	
			
		/// <summary>
        /// ismsteamsenabled
        /// </summary>
		[DisplayName("Enable Microsoft Teams integration")]
		[AttributeLogicalName("ismsteamsenabled")]
		public bool? EnableMicrosoftTeamsIntegration
		{	
			get { return GetAttributeValue<bool?>("ismsteamsenabled"); }
			set
			{ 
				if(value == EnableMicrosoftTeamsIntegration) return;
				SetAttributeValue("ismsteamsenabled", value);
			}
		}	
			
		/// <summary>
        /// ismsteamssettingchangedbyuser
        /// </summary>
		[DisplayName("Microsoft Teams integration changed by user")]
		[AttributeLogicalName("ismsteamssettingchangedbyuser")]
		public bool? MicrosoftTeamsIntegrationChangedByUser
		{	
			get { return GetAttributeValue<bool?>("ismsteamssettingchangedbyuser"); }
			set
			{ 
				if(value == MicrosoftTeamsIntegrationChangedByUser) return;
				SetAttributeValue("ismsteamssettingchangedbyuser", value);
			}
		}	
			
		/// <summary>
        /// ismsteamsusersyncenabled
        /// </summary>
		[DisplayName("Enable Microsoft Teams User Sync for this organization")]
		[AttributeLogicalName("ismsteamsusersyncenabled")]
		public bool? EnableMicrosoftTeamsUserSyncForThisOrganization
		{	
			get { return GetAttributeValue<bool?>("ismsteamsusersyncenabled"); }
			set
			{ 
				if(value == EnableMicrosoftTeamsUserSyncForThisOrganization) return;
				SetAttributeValue("ismsteamsusersyncenabled", value);
			}
		}	
			
		/// <summary>
        /// isnewaddproductexperienceenabled
        /// </summary>
		[DisplayName("Indicates whether new add product experience is enabled in opportunity form")]
		[AttributeLogicalName("isnewaddproductexperienceenabled")]
		public bool? IndicatesWhetherNewAddProductExperienceIsEnabledInOpportunityForm
		{	
			get { return GetAttributeValue<bool?>("isnewaddproductexperienceenabled"); }
			set
			{ 
				if(value == IndicatesWhetherNewAddProductExperienceIsEnabledInOpportunityForm) return;
				SetAttributeValue("isnewaddproductexperienceenabled", value);
			}
		}	
			
		/// <summary>
        /// isnotesanalysisenabled
        /// </summary>
		[DisplayName("Enable Notes Analysis for this Organization")]
		[AttributeLogicalName("isnotesanalysisenabled")]
		public bool? EnableNotesAnalysisForThisOrganization
		{	
			get { return GetAttributeValue<bool?>("isnotesanalysisenabled"); }
			set
			{ 
				if(value == EnableNotesAnalysisForThisOrganization) return;
				SetAttributeValue("isnotesanalysisenabled", value);
			}
		}	
			
		/// <summary>
        /// isofficegraphenabled
        /// </summary>
		[DisplayName("Enable OfficeGraph for this Organization")]
		[AttributeLogicalName("isofficegraphenabled")]
		public bool? EnableOfficeGraphForThisOrganization
		{	
			get { return GetAttributeValue<bool?>("isofficegraphenabled"); }
			set
			{ 
				if(value == EnableOfficeGraphForThisOrganization) return;
				SetAttributeValue("isofficegraphenabled", value);
			}
		}	
			
		/// <summary>
        /// isonedriveenabled
        /// </summary>
		[DisplayName("Enable One Drive for this Organization")]
		[AttributeLogicalName("isonedriveenabled")]
		public bool? EnableOneDriveForThisOrganization
		{	
			get { return GetAttributeValue<bool?>("isonedriveenabled"); }
			set
			{ 
				if(value == EnableOneDriveForThisOrganization) return;
				SetAttributeValue("isonedriveenabled", value);
			}
		}	
			
		/// <summary>
        /// ispaienabled
        /// </summary>
		[DisplayName("Enable PAI feature for this organization")]
		[AttributeLogicalName("ispaienabled")]
		public bool? EnablePAIFeatureForThisOrganization
		{	
			get { return GetAttributeValue<bool?>("ispaienabled"); }
			set
			{ 
				if(value == EnablePAIFeatureForThisOrganization) return;
				SetAttributeValue("ispaienabled", value);
			}
		}	
			
		/// <summary>
        /// ispdfgenerationenabled
        /// </summary>
		[DisplayName("Enable PDF Generation feature for this organization")]
		[AttributeLogicalName("ispdfgenerationenabled")]
		public string EnablePDFGenerationFeatureForThisOrganization
		{	
			get { return GetAttributeValue<string>("ispdfgenerationenabled"); }
			set
			{ 
				if(value == EnablePDFGenerationFeatureForThisOrganization) return;
				SetAttributeValue("ispdfgenerationenabled", value);
			}
		}	
			
		/// <summary>
        /// isplaybookenabled
        /// </summary>
		[DisplayName("Enable playbook feature for this organization")]
		[AttributeLogicalName("isplaybookenabled")]
		public bool? EnablePlaybookFeatureForThisOrganization
		{	
			get { return GetAttributeValue<bool?>("isplaybookenabled"); }
			set
			{ 
				if(value == EnablePlaybookFeatureForThisOrganization) return;
				SetAttributeValue("isplaybookenabled", value);
			}
		}	
			
		/// <summary>
        /// ispresenceenabled
        /// </summary>
		[DisplayName("Presence Enabled")]
		[AttributeLogicalName("ispresenceenabled")]
		public bool? PresenceEnabled
		{	
			get { return GetAttributeValue<bool?>("ispresenceenabled"); }
			set
			{ 
				if(value == PresenceEnabled) return;
				SetAttributeValue("ispresenceenabled", value);
			}
		}	
			
		/// <summary>
        /// ispreviewenabledforactioncard
        /// </summary>
		[DisplayName("Enable Preview Action Card feature for this Organization")]
		[AttributeLogicalName("ispreviewenabledforactioncard")]
		public bool? EnablePreviewActionCardFeatureForThisOrganization
		{	
			get { return GetAttributeValue<bool?>("ispreviewenabledforactioncard"); }
			set
			{ 
				if(value == EnablePreviewActionCardFeatureForThisOrganization) return;
				SetAttributeValue("ispreviewenabledforactioncard", value);
			}
		}	
			
		/// <summary>
        /// ispreviewforautocaptureenabled
        /// </summary>
		[DisplayName("Enable Auto Capture for this Organization at Preview Settings")]
		[AttributeLogicalName("ispreviewforautocaptureenabled")]
		public bool? EnableAutoCaptureForThisOrganizationAtPreviewSettings
		{	
			get { return GetAttributeValue<bool?>("ispreviewforautocaptureenabled"); }
			set
			{ 
				if(value == EnableAutoCaptureForThisOrganizationAtPreviewSettings) return;
				SetAttributeValue("ispreviewforautocaptureenabled", value);
			}
		}	
			
		/// <summary>
        /// ispreviewforemailmonitoringallowed
        /// </summary>
		[DisplayName("Allows Preview For Email Monitoring")]
		[AttributeLogicalName("ispreviewforemailmonitoringallowed")]
		public bool? AllowsPreviewForEmailMonitoring
		{	
			get { return GetAttributeValue<bool?>("ispreviewforemailmonitoringallowed"); }
			set
			{ 
				if(value == AllowsPreviewForEmailMonitoring) return;
				SetAttributeValue("ispreviewforemailmonitoringallowed", value);
			}
		}	
			
		/// <summary>
        /// ispricelistmandatory
        /// </summary>
		[DisplayName("Indicates whether PriceList is mandatory for adding existing products to sales entities")]
		[AttributeLogicalName("ispricelistmandatory")]
		public bool? IndicatesWhetherPriceListIsMandatoryForAddingExistingProductsToSalesEntities
		{	
			get { return GetAttributeValue<bool?>("ispricelistmandatory"); }
			set
			{ 
				if(value == IndicatesWhetherPriceListIsMandatoryForAddingExistingProductsToSalesEntities) return;
				SetAttributeValue("ispricelistmandatory", value);
			}
		}	
			
		/// <summary>
        /// isquickcreateenabledforopportunityclose
        /// </summary>
		[DisplayName("Enable quick create form for opportunity close feature for this organization")]
		[AttributeLogicalName("isquickcreateenabledforopportunityclose")]
		public bool? EnableQuickCreateFormForOpportunityCloseFeatureForThisOrganization
		{	
			get { return GetAttributeValue<bool?>("isquickcreateenabledforopportunityclose"); }
			set
			{ 
				if(value == EnableQuickCreateFormForOpportunityCloseFeatureForThisOrganization) return;
				SetAttributeValue("isquickcreateenabledforopportunityclose", value);
			}
		}	
			
		/// <summary>
        /// isreadauditenabled
        /// </summary>
		[DisplayName("Is Read Auditing Enabled")]
		[AttributeLogicalName("isreadauditenabled")]
		public bool? IsReadAuditingEnabled
		{	
			get { return GetAttributeValue<bool?>("isreadauditenabled"); }
			set
			{ 
				if(value == IsReadAuditingEnabled) return;
				SetAttributeValue("isreadauditenabled", value);
			}
		}	
			
		/// <summary>
        /// isrelationshipinsightsenabled
        /// </summary>
		[DisplayName("Enable Relationship Insights for this Organization")]
		[AttributeLogicalName("isrelationshipinsightsenabled")]
		public bool? EnableRelationshipInsightsForThisOrganization
		{	
			get { return GetAttributeValue<bool?>("isrelationshipinsightsenabled"); }
			set
			{ 
				if(value == EnableRelationshipInsightsForThisOrganization) return;
				SetAttributeValue("isrelationshipinsightsenabled", value);
			}
		}	
			
		/// <summary>
        /// isresourcebookingexchangesyncenabled
        /// </summary>
		[DisplayName("Resource booking synchronization enabled")]
		[AttributeLogicalName("isresourcebookingexchangesyncenabled")]
		public bool? ResourceBookingSynchronizationEnabled
		{	
			get { return GetAttributeValue<bool?>("isresourcebookingexchangesyncenabled"); }
			set
			{ 
				if(value == ResourceBookingSynchronizationEnabled) return;
				SetAttributeValue("isresourcebookingexchangesyncenabled", value);
			}
		}	
			
		/// <summary>
        /// isrichtextnotesenabled
        /// </summary>
		[DisplayName("Indicates whether rich text editor for notes experience is enabled on this organization")]
		[AttributeLogicalName("isrichtextnotesenabled")]
		public bool? IndicatesWhetherRichTextEditorForNotesExperienceIsEnabledOnThisOrganization
		{	
			get { return GetAttributeValue<bool?>("isrichtextnotesenabled"); }
			set
			{ 
				if(value == IndicatesWhetherRichTextEditorForNotesExperienceIsEnabledOnThisOrganization) return;
				SetAttributeValue("isrichtextnotesenabled", value);
			}
		}	
			
		/// <summary>
        /// issalesassistantenabled
        /// </summary>
		[DisplayName("Enable Sales Assistant mobile app")]
		[AttributeLogicalName("issalesassistantenabled")]
		public bool? EnableSalesAssistantMobileApp
		{	
			get { return GetAttributeValue<bool?>("issalesassistantenabled"); }
			set
			{ 
				if(value == EnableSalesAssistantMobileApp) return;
				SetAttributeValue("issalesassistantenabled", value);
			}
		}	
			
		/// <summary>
        /// issopintegrationenabled
        /// </summary>
		[DisplayName("Is Sales Order Integration Enabled")]
		[AttributeLogicalName("issopintegrationenabled")]
		public bool? IsSalesOrderIntegrationEnabled
		{	
			get { return GetAttributeValue<bool?>("issopintegrationenabled"); }
			set
			{ 
				if(value == IsSalesOrderIntegrationEnabled) return;
				SetAttributeValue("issopintegrationenabled", value);
			}
		}	
			
		/// <summary>
        /// istextwrapenabled
        /// </summary>
		[DisplayName("Enable Text Wrap")]
		[AttributeLogicalName("istextwrapenabled")]
		public bool? EnableTextWrap
		{	
			get { return GetAttributeValue<bool?>("istextwrapenabled"); }
			set
			{ 
				if(value == EnableTextWrap) return;
				SetAttributeValue("istextwrapenabled", value);
			}
		}	
			
		/// <summary>
        /// isuseraccessauditenabled
        /// </summary>
		[DisplayName("Is User Access Auditing Enabled")]
		[AttributeLogicalName("isuseraccessauditenabled")]
		public bool? IsUserAccessAuditingEnabled
		{	
			get { return GetAttributeValue<bool?>("isuseraccessauditenabled"); }
			set
			{ 
				if(value == IsUserAccessAuditingEnabled) return;
				SetAttributeValue("isuseraccessauditenabled", value);
			}
		}	
			
		/// <summary>
        /// isvintegrationcode
        /// </summary>
		[DisplayName("ISV Integration Mode")]
		[AttributeLogicalName("isvintegrationcode")]
		public eOrganizationIsvintegrationcode? ISVIntegrationMode
		{	
			get 
			{ 
				var optionSetValue = GetAttributeValue<OptionSetValue>("isvintegrationcode");
				if (optionSetValue != null) return (eOrganizationIsvintegrationcode)optionSetValue.Value;
				else return null;
			}
			set 
			{ 
				if(value == ISVIntegrationMode) return;

				OptionSetValue optionSetValue = null;
				if(value != null) optionSetValue = new OptionSetValue((int)value);
				SetAttributeValue("isvintegrationcode", optionSetValue); 
			}
		}

		/// <summary>
        /// iswriteinproductsallowed
        /// </summary>
		[DisplayName("Indicates whether Write-in Products can be added to Opportunity/Quote/Order/Invoice or not")]
		[AttributeLogicalName("iswriteinproductsallowed")]
		public bool? IndicatesWhetherWriteinProductsCanBeAddedToOpportunityQuoteOrderInvoiceOrNot
		{	
			get { return GetAttributeValue<bool?>("iswriteinproductsallowed"); }
			set
			{ 
				if(value == IndicatesWhetherWriteinProductsCanBeAddedToOpportunityQuoteOrderInvoiceOrNot) return;
				SetAttributeValue("iswriteinproductsallowed", value);
			}
		}	
			
		/// <summary>
        /// kaprefix
        /// </summary>
		[DisplayName("Knowledge Article Prefix")]
		[AttributeLogicalName("kaprefix")]
		public string KnowledgeArticlePrefix
		{	
			get { return GetAttributeValue<string>("kaprefix"); }
			set
			{ 
				if(value == KnowledgeArticlePrefix) return;
				SetAttributeValue("kaprefix", value);
			}
		}	
			
		/// <summary>
        /// kbprefix
        /// </summary>
		[DisplayName("Article Prefix")]
		[AttributeLogicalName("kbprefix")]
		public string ArticlePrefix
		{	
			get { return GetAttributeValue<string>("kbprefix"); }
			set
			{ 
				if(value == ArticlePrefix) return;
				SetAttributeValue("kbprefix", value);
			}
		}	
			
		/// <summary>
        /// kmsettings
        /// </summary>
		[DisplayName("Knowledge Management Settings")]
		[AttributeLogicalName("kmsettings")]
		public string KnowledgeManagementSettings
		{	
			get { return GetAttributeValue<string>("kmsettings"); }
			set
			{ 
				if(value == KnowledgeManagementSettings) return;
				SetAttributeValue("kmsettings", value);
			}
		}	
			
		/// <summary>
        /// languagecode
        /// </summary>
		[DisplayName("Language")]
		[AttributeLogicalName("languagecode")]
		public int? Language
		{	
			get { return GetAttributeValue<int?>("languagecode"); }
			set
			{ 
				if(value == Language) return;
				SetAttributeValue("languagecode", value);
			}
		}	
			
		/// <summary>
        /// localeid
        /// </summary>
		[DisplayName("Locale")]
		[AttributeLogicalName("localeid")]
		public int? Locale
		{	
			get { return GetAttributeValue<int?>("localeid"); }
			set
			{ 
				if(value == Locale) return;
				SetAttributeValue("localeid", value);
			}
		}	
			
		/// <summary>
        /// longdateformatcode
        /// </summary>
		[DisplayName("Long Date Format")]
		[AttributeLogicalName("longdateformatcode")]
		public int? LongDateFormat
		{	
			get { return GetAttributeValue<int?>("longdateformatcode"); }
			set
			{ 
				if(value == LongDateFormat) return;
				SetAttributeValue("longdateformatcode", value);
			}
		}	
			
		/// <summary>
        /// mailboxintermittentissueminrange
        /// </summary>
		[DisplayName("Lower Threshold For Mailbox Intermittent Issue")]
		[AttributeLogicalName("mailboxintermittentissueminrange")]
		public int? LowerThresholdForMailboxIntermittentIssue
		{	
			get { return GetAttributeValue<int?>("mailboxintermittentissueminrange"); }
			set
			{ 
				if(value == LowerThresholdForMailboxIntermittentIssue) return;
				SetAttributeValue("mailboxintermittentissueminrange", value);
			}
		}	
			
		/// <summary>
        /// mailboxpermanentissueminrange
        /// </summary>
		[DisplayName("Lower Threshold For Mailbox Permanent Issue.")]
		[AttributeLogicalName("mailboxpermanentissueminrange")]
		public int? LowerThresholdForMailboxPermanentIssue
		{	
			get { return GetAttributeValue<int?>("mailboxpermanentissueminrange"); }
			set
			{ 
				if(value == LowerThresholdForMailboxPermanentIssue) return;
				SetAttributeValue("mailboxpermanentissueminrange", value);
			}
		}	
			
		/// <summary>
        /// maxactionstepsinbpf
        /// </summary>
		[DisplayName("Maximum number of actionsteps allowed in a BPF")]
		[AttributeLogicalName("maxactionstepsinbpf")]
		public int? MaximumNumberOfActionstepsAllowedInABPF
		{	
			get { return GetAttributeValue<int?>("maxactionstepsinbpf"); }
			set
			{ 
				if(value == MaximumNumberOfActionstepsAllowedInABPF) return;
				SetAttributeValue("maxactionstepsinbpf", value);
			}
		}	
			
		/// <summary>
        /// maxappointmentdurationdays
        /// </summary>
		[DisplayName("Max Appointment Duration")]
		[AttributeLogicalName("maxappointmentdurationdays")]
		public int? MaxAppointmentDuration
		{	
			get { return GetAttributeValue<int?>("maxappointmentdurationdays"); }
			set
			{ 
				if(value == MaxAppointmentDuration) return;
				SetAttributeValue("maxappointmentdurationdays", value);
			}
		}	
			
		/// <summary>
        /// maxconditionsformobileofflinefilters
        /// </summary>
		[DisplayName("Maximum number of conditions allowed for mobile offline filters")]
		[AttributeLogicalName("maxconditionsformobileofflinefilters")]
		public int? MaximumNumberOfConditionsAllowedForMobileOfflineFilters
		{	
			get { return GetAttributeValue<int?>("maxconditionsformobileofflinefilters"); }
			set
			{ 
				if(value == MaximumNumberOfConditionsAllowedForMobileOfflineFilters) return;
				SetAttributeValue("maxconditionsformobileofflinefilters", value);
			}
		}	
			
		/// <summary>
        /// maxdepthforhierarchicalsecuritymodel
        /// </summary>
		[DisplayName("Maximum depth for hierarchy security propagation.")]
		[AttributeLogicalName("maxdepthforhierarchicalsecuritymodel")]
		public int? MaximumDepthForHierarchySecurityPropagation
		{	
			get { return GetAttributeValue<int?>("maxdepthforhierarchicalsecuritymodel"); }
			set
			{ 
				if(value == MaximumDepthForHierarchySecurityPropagation) return;
				SetAttributeValue("maxdepthforhierarchicalsecuritymodel", value);
			}
		}	
			
		/// <summary>
        /// maxfolderbasedtrackingmappings
        /// </summary>
		[DisplayName("Max Folder Based Tracking Mappings")]
		[AttributeLogicalName("maxfolderbasedtrackingmappings")]
		public int? MaxFolderBasedTrackingMappings
		{	
			get { return GetAttributeValue<int?>("maxfolderbasedtrackingmappings"); }
			set
			{ 
				if(value == MaxFolderBasedTrackingMappings) return;
				SetAttributeValue("maxfolderbasedtrackingmappings", value);
			}
		}	
			
		/// <summary>
        /// maximumactivebusinessprocessflowsallowedperentity
        /// </summary>
		[DisplayName("Maximum active business process flows per entity")]
		[AttributeLogicalName("maximumactivebusinessprocessflowsallowedperentity")]
		public int? MaximumActiveBusinessProcessFlowsPerEntity
		{	
			get { return GetAttributeValue<int?>("maximumactivebusinessprocessflowsallowedperentity"); }
			set
			{ 
				if(value == MaximumActiveBusinessProcessFlowsPerEntity) return;
				SetAttributeValue("maximumactivebusinessprocessflowsallowedperentity", value);
			}
		}	
			
		/// <summary>
        /// maximumdynamicpropertiesallowed
        /// </summary>
		[DisplayName("Product Properties Item Limit")]
		[AttributeLogicalName("maximumdynamicpropertiesallowed")]
		public int? ProductPropertiesItemLimit
		{	
			get { return GetAttributeValue<int?>("maximumdynamicpropertiesallowed"); }
			set
			{ 
				if(value == ProductPropertiesItemLimit) return;
				SetAttributeValue("maximumdynamicpropertiesallowed", value);
			}
		}	
			
		/// <summary>
        /// maximumentitieswithactivesla
        /// </summary>
		[DisplayName("Maximum number of active SLA allowed per entity in online")]
		[AttributeLogicalName("maximumentitieswithactivesla")]
		public int? MaximumNumberOfActiveSLAAllowedPerEntityInOnline
		{	
			get { return GetAttributeValue<int?>("maximumentitieswithactivesla"); }
			set
			{ 
				if(value == MaximumNumberOfActiveSLAAllowedPerEntityInOnline) return;
				SetAttributeValue("maximumentitieswithactivesla", value);
			}
		}	
			
		/// <summary>
        /// maximumslakpiperentitywithactivesla
        /// </summary>
		[DisplayName("Maximum number of active SLA KPI allowed per entity in online")]
		[AttributeLogicalName("maximumslakpiperentitywithactivesla")]
		public int? MaximumNumberOfActiveSLAKPIAllowedPerEntityInOnline
		{	
			get { return GetAttributeValue<int?>("maximumslakpiperentitywithactivesla"); }
			set
			{ 
				if(value == MaximumNumberOfActiveSLAKPIAllowedPerEntityInOnline) return;
				SetAttributeValue("maximumslakpiperentitywithactivesla", value);
			}
		}	
			
		/// <summary>
        /// maximumtrackingnumber
        /// </summary>
		[DisplayName("Max Tracking Number")]
		[AttributeLogicalName("maximumtrackingnumber")]
		public int? MaxTrackingNumber
		{	
			get { return GetAttributeValue<int?>("maximumtrackingnumber"); }
			set
			{ 
				if(value == MaxTrackingNumber) return;
				SetAttributeValue("maximumtrackingnumber", value);
			}
		}	
			
		/// <summary>
        /// maxproductsinbundle
        /// </summary>
		[DisplayName("Bundle Item Limit")]
		[AttributeLogicalName("maxproductsinbundle")]
		public int? BundleItemLimit
		{	
			get { return GetAttributeValue<int?>("maxproductsinbundle"); }
			set
			{ 
				if(value == BundleItemLimit) return;
				SetAttributeValue("maxproductsinbundle", value);
			}
		}	
			
		/// <summary>
        /// maxrecordsforexporttoexcel
        /// </summary>
		[DisplayName("Max Records For Excel Export")]
		[AttributeLogicalName("maxrecordsforexporttoexcel")]
		public int? MaxRecordsForExcelExport
		{	
			get { return GetAttributeValue<int?>("maxrecordsforexporttoexcel"); }
			set
			{ 
				if(value == MaxRecordsForExcelExport) return;
				SetAttributeValue("maxrecordsforexporttoexcel", value);
			}
		}	
			
		/// <summary>
        /// maxrecordsforlookupfilters
        /// </summary>
		[DisplayName("Max Records Filter Selection")]
		[AttributeLogicalName("maxrecordsforlookupfilters")]
		public int? MaxRecordsFilterSelection
		{	
			get { return GetAttributeValue<int?>("maxrecordsforlookupfilters"); }
			set
			{ 
				if(value == MaxRecordsFilterSelection) return;
				SetAttributeValue("maxrecordsforlookupfilters", value);
			}
		}	
			
		/// <summary>
        /// maxslaitemspersla
        /// </summary>
		[DisplayName("Max SLA Items Per SLA")]
		[AttributeLogicalName("maxslaitemspersla")]
		public int? MaxSLAItemsPerSLA
		{	
			get { return GetAttributeValue<int?>("maxslaitemspersla"); }
			set
			{ 
				if(value == MaxSLAItemsPerSLA) return;
				SetAttributeValue("maxslaitemspersla", value);
			}
		}	
			
		/// <summary>
        /// maxsupportedinternetexplorerversion
        /// </summary>
		[DisplayName("Max supported IE version")]
		[AttributeLogicalName("maxsupportedinternetexplorerversion")]
		public int? MaxSupportedIEVersion
		{	
			get { return GetAttributeValue<int?>("maxsupportedinternetexplorerversion"); }
			set
			{ 
				if(value == MaxSupportedIEVersion) return;
				SetAttributeValue("maxsupportedinternetexplorerversion", value);
			}
		}	
			
		/// <summary>
        /// maxuploadfilesize
        /// </summary>
		[DisplayName("Max Upload File Size")]
		[AttributeLogicalName("maxuploadfilesize")]
		public int? MaxUploadFileSize
		{	
			get { return GetAttributeValue<int?>("maxuploadfilesize"); }
			set
			{ 
				if(value == MaxUploadFileSize) return;
				SetAttributeValue("maxuploadfilesize", value);
			}
		}	
			
		/// <summary>
        /// maxverboseloggingmailbox
        /// </summary>
		[DisplayName("Max No Of Mailboxes To Enable For Verbose Logging")]
		[AttributeLogicalName("maxverboseloggingmailbox")]
		public int? MaxNoOfMailboxesToEnableForVerboseLogging
		{	
			get { return GetAttributeValue<int?>("maxverboseloggingmailbox"); }
			set
			{ 
				if(value == MaxNoOfMailboxesToEnableForVerboseLogging) return;
				SetAttributeValue("maxverboseloggingmailbox", value);
			}
		}	
			
		/// <summary>
        /// maxverboseloggingsynccycles
        /// </summary>
		[DisplayName("Maximum number of sync cycles for which verbose logging will be enabled by default")]
		[AttributeLogicalName("maxverboseloggingsynccycles")]
		public int? MaximumNumberOfSyncCyclesForWhichVerboseLoggingWillBeEnabledByDefault
		{	
			get { return GetAttributeValue<int?>("maxverboseloggingsynccycles"); }
			set
			{ 
				if(value == MaximumNumberOfSyncCyclesForWhichVerboseLoggingWillBeEnabledByDefault) return;
				SetAttributeValue("maxverboseloggingsynccycles", value);
			}
		}	
			
		/// <summary>
        /// metadatasynclasttimeofneverexpireddeletedobjects
        /// </summary>
		[DisplayName("The last date/time for never expired metadata tracking deleted objects")]
		[AttributeLogicalName("metadatasynclasttimeofneverexpireddeletedobjects")]
		public DateTime? TheLastDatetimeForNeverExpiredMetadataTrackingDeletedObjects
		{	
			get { return GetAttributeValue<DateTime?>("metadatasynclasttimeofneverexpireddeletedobjects"); }
			set
			{ 
				if(value == TheLastDatetimeForNeverExpiredMetadataTrackingDeletedObjects) return;
				SetAttributeValue("metadatasynclasttimeofneverexpireddeletedobjects", value);
			}
		}	
			
		/// <summary>
        /// metadatasynctimestamp
        /// </summary>
		[DisplayName("Metadata sync version")]
		[AttributeLogicalName("metadatasynctimestamp")]
		public int? MetadataSyncVersion
		{	
			get { return GetAttributeValue<int?>("metadatasynctimestamp"); }
			set
			{ 
				if(value == MetadataSyncVersion) return;
				SetAttributeValue("metadatasynctimestamp", value);
			}
		}	
			
		/// <summary>
        /// microsoftflowenvironment
        /// </summary>
		[DisplayName("(Deprecated) Environment selected for Integration with Microsoft Flow")]
		[AttributeLogicalName("microsoftflowenvironment")]
		public string DeprecatedEnvironmentSelectedForIntegrationWithMicrosoftFlow
		{	
			get { return GetAttributeValue<string>("microsoftflowenvironment"); }
			set
			{ 
				if(value == DeprecatedEnvironmentSelectedForIntegrationWithMicrosoftFlow) return;
				SetAttributeValue("microsoftflowenvironment", value);
			}
		}	
			
		/// <summary>
        /// minaddressbooksyncinterval
        /// </summary>
		[DisplayName("Min Address Synchronization Frequency")]
		[AttributeLogicalName("minaddressbooksyncinterval")]
		public int? MinAddressSynchronizationFrequency
		{	
			get { return GetAttributeValue<int?>("minaddressbooksyncinterval"); }
			set
			{ 
				if(value == MinAddressSynchronizationFrequency) return;
				SetAttributeValue("minaddressbooksyncinterval", value);
			}
		}	
			
		/// <summary>
        /// minofflinesyncinterval
        /// </summary>
		[DisplayName("Min Offline Synchronization Frequency")]
		[AttributeLogicalName("minofflinesyncinterval")]
		public int? MinOfflineSynchronizationFrequency
		{	
			get { return GetAttributeValue<int?>("minofflinesyncinterval"); }
			set
			{ 
				if(value == MinOfflineSynchronizationFrequency) return;
				SetAttributeValue("minofflinesyncinterval", value);
			}
		}	
			
		/// <summary>
        /// minoutlooksyncinterval
        /// </summary>
		[DisplayName("Min Synchronization Frequency")]
		[AttributeLogicalName("minoutlooksyncinterval")]
		public int? MinSynchronizationFrequency
		{	
			get { return GetAttributeValue<int?>("minoutlooksyncinterval"); }
			set
			{ 
				if(value == MinSynchronizationFrequency) return;
				SetAttributeValue("minoutlooksyncinterval", value);
			}
		}	
			
		/// <summary>
        /// mobileofflineminlicenseprod
        /// </summary>
		[DisplayName("Minimum number of user license required for mobile offline service by production/preview organization")]
		[AttributeLogicalName("mobileofflineminlicenseprod")]
		public int? MinimumNumberOfUserLicenseRequiredForMobileOfflineServiceByProductionpreviewOrganization
		{	
			get { return GetAttributeValue<int?>("mobileofflineminlicenseprod"); }
			set
			{ 
				if(value == MinimumNumberOfUserLicenseRequiredForMobileOfflineServiceByProductionpreviewOrganization) return;
				SetAttributeValue("mobileofflineminlicenseprod", value);
			}
		}	
			
		/// <summary>
        /// mobileofflineminlicensetrial
        /// </summary>
		[DisplayName("Minimum number of user license required for mobile offline service by trial organization")]
		[AttributeLogicalName("mobileofflineminlicensetrial")]
		public int? MinimumNumberOfUserLicenseRequiredForMobileOfflineServiceByTrialOrganization
		{	
			get { return GetAttributeValue<int?>("mobileofflineminlicensetrial"); }
			set
			{ 
				if(value == MinimumNumberOfUserLicenseRequiredForMobileOfflineServiceByTrialOrganization) return;
				SetAttributeValue("mobileofflineminlicensetrial", value);
			}
		}	
			
		/// <summary>
        /// mobileofflinesyncinterval
        /// </summary>
		[DisplayName("Sync interval for mobile offline.")]
		[AttributeLogicalName("mobileofflinesyncinterval")]
		public int? SyncIntervalForMobileOffline
		{	
			get { return GetAttributeValue<int?>("mobileofflinesyncinterval"); }
			set
			{ 
				if(value == SyncIntervalForMobileOffline) return;
				SetAttributeValue("mobileofflinesyncinterval", value);
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
		[DisplayName("Organization Name")]
		[AttributeLogicalName("name")]
		public string OrganizationName
		{	
			get { return GetAttributeValue<string>("name"); }
			set
			{ 
				if(value == OrganizationName) return;
				SetAttributeValue("name", value);
			}
		}	
			
		/// <summary>
        /// negativecurrencyformatcode
        /// </summary>
		[DisplayName("Negative Currency Format")]
		[AttributeLogicalName("negativecurrencyformatcode")]
		public int? NegativeCurrencyFormat
		{	
			get { return GetAttributeValue<int?>("negativecurrencyformatcode"); }
			set
			{ 
				if(value == NegativeCurrencyFormat) return;
				SetAttributeValue("negativecurrencyformatcode", value);
			}
		}	
			
		/// <summary>
        /// negativeformatcode
        /// </summary>
		[DisplayName("Negative Format")]
		[AttributeLogicalName("negativeformatcode")]
		public eOrganizationNegativeformatcode? NegativeFormat
		{	
			get 
			{ 
				var optionSetValue = GetAttributeValue<OptionSetValue>("negativeformatcode");
				if (optionSetValue != null) return (eOrganizationNegativeformatcode)optionSetValue.Value;
				else return null;
			}
			set 
			{ 
				if(value == NegativeFormat) return;

				OptionSetValue optionSetValue = null;
				if(value != null) optionSetValue = new OptionSetValue((int)value);
				SetAttributeValue("negativeformatcode", optionSetValue); 
			}
		}

		/// <summary>
        /// nextcustomobjecttypecode
        /// </summary>
		[DisplayName("Next Entity Type Code")]
		[AttributeLogicalName("nextcustomobjecttypecode")]
		public int? NextEntityTypeCode
		{	
			get { return GetAttributeValue<int?>("nextcustomobjecttypecode"); }
			set
			{ 
				if(value == NextEntityTypeCode) return;
				SetAttributeValue("nextcustomobjecttypecode", value);
			}
		}	
			
		/// <summary>
        /// nexttrackingnumber
        /// </summary>
		[DisplayName("Next Tracking Number")]
		[AttributeLogicalName("nexttrackingnumber")]
		public int? NextTrackingNumber
		{	
			get { return GetAttributeValue<int?>("nexttrackingnumber"); }
			set
			{ 
				if(value == NextTrackingNumber) return;
				SetAttributeValue("nexttrackingnumber", value);
			}
		}	
			
		/// <summary>
        /// notifymailboxownerofemailserverlevelalerts
        /// </summary>
		[DisplayName("Notify Mailbox Owner Of Email Server Level Alerts")]
		[AttributeLogicalName("notifymailboxownerofemailserverlevelalerts")]
		public bool? NotifyMailboxOwnerOfEmailServerLevelAlerts
		{	
			get { return GetAttributeValue<bool?>("notifymailboxownerofemailserverlevelalerts"); }
			set
			{ 
				if(value == NotifyMailboxOwnerOfEmailServerLevelAlerts) return;
				SetAttributeValue("notifymailboxownerofemailserverlevelalerts", value);
			}
		}	
			
		/// <summary>
        /// numberformat
        /// </summary>
		[DisplayName("Number Format")]
		[AttributeLogicalName("numberformat")]
		public string NumberFormat
		{	
			get { return GetAttributeValue<string>("numberformat"); }
			set
			{ 
				if(value == NumberFormat) return;
				SetAttributeValue("numberformat", value);
			}
		}	
			
		/// <summary>
        /// numbergroupformat
        /// </summary>
		[DisplayName("Number Grouping Format")]
		[AttributeLogicalName("numbergroupformat")]
		public string NumberGroupingFormat
		{	
			get { return GetAttributeValue<string>("numbergroupformat"); }
			set
			{ 
				if(value == NumberGroupingFormat) return;
				SetAttributeValue("numbergroupformat", value);
			}
		}	
			
		/// <summary>
        /// numberseparator
        /// </summary>
		[DisplayName("Number Separator")]
		[AttributeLogicalName("numberseparator")]
		public string NumberSeparator
		{	
			get { return GetAttributeValue<string>("numberseparator"); }
			set
			{ 
				if(value == NumberSeparator) return;
				SetAttributeValue("numberseparator", value);
			}
		}	
			
		/// <summary>
        /// officeappsautodeploymentenabled
        /// </summary>
		[DisplayName("Enable Office Apps Auto Deployment for this Organization")]
		[AttributeLogicalName("officeappsautodeploymentenabled")]
		public bool? EnableOfficeAppsAutoDeploymentForThisOrganization
		{	
			get { return GetAttributeValue<bool?>("officeappsautodeploymentenabled"); }
			set
			{ 
				if(value == EnableOfficeAppsAutoDeploymentForThisOrganization) return;
				SetAttributeValue("officeappsautodeploymentenabled", value);
			}
		}	
			
		/// <summary>
        /// officegraphdelveurl
        /// </summary>
		[DisplayName("The url to open the Delve")]
		[AttributeLogicalName("officegraphdelveurl")]
		public string TheUrlToOpenTheDelve
		{	
			get { return GetAttributeValue<string>("officegraphdelveurl"); }
			set
			{ 
				if(value == TheUrlToOpenTheDelve) return;
				SetAttributeValue("officegraphdelveurl", value);
			}
		}	
			
		/// <summary>
        /// oobpricecalculationenabled
        /// </summary>
		[DisplayName("Enable OOB Price calculation")]
		[AttributeLogicalName("oobpricecalculationenabled")]
		public bool? EnableOOBPriceCalculation
		{	
			get { return GetAttributeValue<bool?>("oobpricecalculationenabled"); }
			set
			{ 
				if(value == EnableOOBPriceCalculation) return;
				SetAttributeValue("oobpricecalculationenabled", value);
			}
		}	
			
		/// <summary>
        /// orderprefix
        /// </summary>
		[DisplayName("Order Prefix")]
		[AttributeLogicalName("orderprefix")]
		public string OrderPrefix
		{	
			get { return GetAttributeValue<string>("orderprefix"); }
			set
			{ 
				if(value == OrderPrefix) return;
				SetAttributeValue("orderprefix", value);
			}
		}	
			
		/// <summary>
        /// organizationid
        /// </summary>
		[DisplayName("Organization")]
		[AttributeLogicalName("organizationid")]
		public override Guid Id
		{
			get => base.Id;
			set { base.Id = value; SetAttributeValue("organizationid", value); }
		}

							/// <summary>
        /// organizationstate
        /// </summary>
		[DisplayName("Organization State")]
		[AttributeLogicalName("organizationstate")]
		public eOrganizationState? OrganizationState
		{	
			get 
			{ 
				var optionSetValue = GetAttributeValue<OptionSetValue>("organizationstate");
				if (optionSetValue != null) return (eOrganizationState)optionSetValue.Value;
				else return null;
			}
			set 
			{ 
				if(value == OrganizationState) return;

				OptionSetValue optionSetValue = null;
				if(value != null) optionSetValue = new OptionSetValue((int)value);
				SetAttributeValue("organizationstate", optionSetValue); 
			}
		}

		/// <summary>
        /// orgdborgsettings
        /// </summary>
		[DisplayName("Organization Database Organization Settings")]
		[AttributeLogicalName("orgdborgsettings")]
		public string OrganizationDatabaseOrganizationSettings
		{	
			get { return GetAttributeValue<string>("orgdborgsettings"); }
			set
			{ 
				if(value == OrganizationDatabaseOrganizationSettings) return;
				SetAttributeValue("orgdborgsettings", value);
			}
		}	
			
		/// <summary>
        /// orginsightsenabled
        /// </summary>
		[DisplayName("Enable OrgInsights for this Organization")]
		[AttributeLogicalName("orginsightsenabled")]
		public bool? EnableOrgInsightsForThisOrganization
		{	
			get { return GetAttributeValue<bool?>("orginsightsenabled"); }
			set
			{ 
				if(value == EnableOrgInsightsForThisOrganization) return;
				SetAttributeValue("orginsightsenabled", value);
			}
		}	
			
		/// <summary>
        /// paipreviewscenarioenabled
        /// </summary>
		[DisplayName("Display Preview Feature for this organization")]
		[AttributeLogicalName("paipreviewscenarioenabled")]
		public bool? DisplayPreviewFeatureForThisOrganization
		{	
			get { return GetAttributeValue<bool?>("paipreviewscenarioenabled"); }
			set
			{ 
				if(value == DisplayPreviewFeatureForThisOrganization) return;
				SetAttributeValue("paipreviewscenarioenabled", value);
			}
		}	
			
		/// <summary>
        /// parsedtablecolumnprefix
        /// </summary>
		[DisplayName("Parsed Table Column Prefix")]
		[AttributeLogicalName("parsedtablecolumnprefix")]
		public string ParsedTableColumnPrefix
		{	
			get { return GetAttributeValue<string>("parsedtablecolumnprefix"); }
			set
			{ 
				if(value == ParsedTableColumnPrefix) return;
				SetAttributeValue("parsedtablecolumnprefix", value);
			}
		}	
			
		/// <summary>
        /// parsedtableprefix
        /// </summary>
		[DisplayName("Parsed Table Prefix")]
		[AttributeLogicalName("parsedtableprefix")]
		public string ParsedTablePrefix
		{	
			get { return GetAttributeValue<string>("parsedtableprefix"); }
			set
			{ 
				if(value == ParsedTablePrefix) return;
				SetAttributeValue("parsedtableprefix", value);
			}
		}	
			
		/// <summary>
        /// pastexpansionwindow
        /// </summary>
		[DisplayName("Past Expansion Window")]
		[AttributeLogicalName("pastexpansionwindow")]
		public int? PastExpansionWindow
		{	
			get { return GetAttributeValue<int?>("pastexpansionwindow"); }
			set
			{ 
				if(value == PastExpansionWindow) return;
				SetAttributeValue("pastexpansionwindow", value);
			}
		}	
			
		/// <summary>
        /// picture
        /// </summary>
		[DisplayName("Picture")]
		[AttributeLogicalName("picture")]
		public string Picture
		{	
			get { return GetAttributeValue<string>("picture"); }
			set
			{ 
				if(value == Picture) return;
				SetAttributeValue("picture", value);
			}
		}	
			
		/// <summary>
        /// pinpointlanguagecode
        /// </summary>
		[DisplayName("pinpointlanguagecode")]
		[AttributeLogicalName("pinpointlanguagecode")]
		public int? Pinpointlanguagecode
		{	
			get { return GetAttributeValue<int?>("pinpointlanguagecode"); }
			set
			{ 
				if(value == Pinpointlanguagecode) return;
				SetAttributeValue("pinpointlanguagecode", value);
			}
		}	
			
		/// <summary>
        /// plugintracelogsetting
        /// </summary>
		[DisplayName("Plug-in Trace Log Setting")]
		[AttributeLogicalName("plugintracelogsetting")]
		public eOrganizationPlugintracelogsetting? PluginTraceLogSetting
		{	
			get 
			{ 
				var optionSetValue = GetAttributeValue<OptionSetValue>("plugintracelogsetting");
				if (optionSetValue != null) return (eOrganizationPlugintracelogsetting)optionSetValue.Value;
				else return null;
			}
			set 
			{ 
				if(value == PluginTraceLogSetting) return;

				OptionSetValue optionSetValue = null;
				if(value != null) optionSetValue = new OptionSetValue((int)value);
				SetAttributeValue("plugintracelogsetting", optionSetValue); 
			}
		}

		/// <summary>
        /// pmdesignator
        /// </summary>
		[DisplayName("PM Designator")]
		[AttributeLogicalName("pmdesignator")]
		public string PMDesignator
		{	
			get { return GetAttributeValue<string>("pmdesignator"); }
			set
			{ 
				if(value == PMDesignator) return;
				SetAttributeValue("pmdesignator", value);
			}
		}	
			
		/// <summary>
        /// postmessagewhitelistdomains
        /// </summary>
		[DisplayName("For internal use only.")]
		[AttributeLogicalName("postmessagewhitelistdomains")]
		public string ForInternalUseOnly2
		{	
			get { return GetAttributeValue<string>("postmessagewhitelistdomains"); }
			set
			{ 
				if(value == ForInternalUseOnly2) return;
				SetAttributeValue("postmessagewhitelistdomains", value);
			}
		}	
			
		/// <summary>
        /// powerbifeatureenabled
        /// </summary>
		[DisplayName("Enable Power BI feature for this Organization")]
		[AttributeLogicalName("powerbifeatureenabled")]
		public bool? EnablePowerBIFeatureForThisOrganization
		{	
			get { return GetAttributeValue<bool?>("powerbifeatureenabled"); }
			set
			{ 
				if(value == EnablePowerBIFeatureForThisOrganization) return;
				SetAttributeValue("powerbifeatureenabled", value);
			}
		}	
			
		/// <summary>
        /// pricingdecimalprecision
        /// </summary>
		[DisplayName("Pricing Decimal Precision")]
		[AttributeLogicalName("pricingdecimalprecision")]
		public int? PricingDecimalPrecision
		{	
			get { return GetAttributeValue<int?>("pricingdecimalprecision"); }
			set
			{ 
				if(value == PricingDecimalPrecision) return;
				SetAttributeValue("pricingdecimalprecision", value);
			}
		}	
			
		/// <summary>
        /// privacystatementurl
        /// </summary>
		[DisplayName("Privacy Statement URL")]
		[AttributeLogicalName("privacystatementurl")]
		public string PrivacyStatementURL
		{	
			get { return GetAttributeValue<string>("privacystatementurl"); }
			set
			{ 
				if(value == PrivacyStatementURL) return;
				SetAttributeValue("privacystatementurl", value);
			}
		}	
			
		/// <summary>
        /// privilegeusergroupid
        /// </summary>
		[DisplayName("Privilege User Group")]
		[AttributeLogicalName("privilegeusergroupid")]
		public Guid PrivilegeUserGroupId
		{	
			get { return GetAttributeValue<Guid>("privilegeusergroupid"); }
			set
			{ 
				if(value == PrivilegeUserGroupId) return;
				SetAttributeValue("privilegeusergroupid", value);
			}
		}	
			
		/// <summary>
        /// privreportinggroupid
        /// </summary>
		[DisplayName("Privilege Reporting Group")]
		[AttributeLogicalName("privreportinggroupid")]
		public Guid PrivilegeReportingGroupId
		{	
			get { return GetAttributeValue<Guid>("privreportinggroupid"); }
			set
			{ 
				if(value == PrivilegeReportingGroupId) return;
				SetAttributeValue("privreportinggroupid", value);
			}
		}	
			
		/// <summary>
        /// privreportinggroupname
        /// </summary>
		[DisplayName("Privilege Reporting Group Name")]
		[AttributeLogicalName("privreportinggroupname")]
		public string PrivilegeReportingGroupName
		{	
			get { return GetAttributeValue<string>("privreportinggroupname"); }
			set
			{ 
				if(value == PrivilegeReportingGroupName) return;
				SetAttributeValue("privreportinggroupname", value);
			}
		}	
			
		/// <summary>
        /// productrecommendationsenabled
        /// </summary>
		[DisplayName("Enable Product Recommendations for this Organization")]
		[AttributeLogicalName("productrecommendationsenabled")]
		public bool? EnableProductRecommendationsForThisOrganization
		{	
			get { return GetAttributeValue<bool?>("productrecommendationsenabled"); }
			set
			{ 
				if(value == EnableProductRecommendationsForThisOrganization) return;
				SetAttributeValue("productrecommendationsenabled", value);
			}
		}	
			
		/// <summary>
        /// qualifyleadadditionaloptions
        /// </summary>
		[DisplayName("Enable New Qualify Lead Experience with configuration MDD")]
		[AttributeLogicalName("qualifyleadadditionaloptions")]
		public string EnableNewQualifyLeadExperienceWithConfigurationMDD
		{	
			get { return GetAttributeValue<string>("qualifyleadadditionaloptions"); }
			set
			{ 
				if(value == EnableNewQualifyLeadExperienceWithConfigurationMDD) return;
				SetAttributeValue("qualifyleadadditionaloptions", value);
			}
		}	
			
		/// <summary>
        /// quickfindrecordlimitenabled
        /// </summary>
		[DisplayName("Quick Find Record Limit Enabled")]
		[AttributeLogicalName("quickfindrecordlimitenabled")]
		public bool? QuickFindRecordLimitEnabled
		{	
			get { return GetAttributeValue<bool?>("quickfindrecordlimitenabled"); }
			set
			{ 
				if(value == QuickFindRecordLimitEnabled) return;
				SetAttributeValue("quickfindrecordlimitenabled", value);
			}
		}	
			
		/// <summary>
        /// quoteprefix
        /// </summary>
		[DisplayName("Quote Prefix")]
		[AttributeLogicalName("quoteprefix")]
		public string QuotePrefix
		{	
			get { return GetAttributeValue<string>("quoteprefix"); }
			set
			{ 
				if(value == QuotePrefix) return;
				SetAttributeValue("quoteprefix", value);
			}
		}	
			
		/// <summary>
        /// recurrencedefaultnumberofoccurrences
        /// </summary>
		[DisplayName("Recurrence Default Number of Occurrences")]
		[AttributeLogicalName("recurrencedefaultnumberofoccurrences")]
		public int? RecurrenceDefaultNumberOfOccurrences
		{	
			get { return GetAttributeValue<int?>("recurrencedefaultnumberofoccurrences"); }
			set
			{ 
				if(value == RecurrenceDefaultNumberOfOccurrences) return;
				SetAttributeValue("recurrencedefaultnumberofoccurrences", value);
			}
		}	
			
		/// <summary>
        /// recurrenceexpansionjobbatchinterval
        /// </summary>
		[DisplayName("Recurrence Expansion Job Batch Interval")]
		[AttributeLogicalName("recurrenceexpansionjobbatchinterval")]
		public int? RecurrenceExpansionJobBatchInterval
		{	
			get { return GetAttributeValue<int?>("recurrenceexpansionjobbatchinterval"); }
			set
			{ 
				if(value == RecurrenceExpansionJobBatchInterval) return;
				SetAttributeValue("recurrenceexpansionjobbatchinterval", value);
			}
		}	
			
		/// <summary>
        /// recurrenceexpansionjobbatchsize
        /// </summary>
		[DisplayName("Recurrence Expansion On Demand Job Batch Size")]
		[AttributeLogicalName("recurrenceexpansionjobbatchsize")]
		public int? RecurrenceExpansionOnDemandJobBatchSize
		{	
			get { return GetAttributeValue<int?>("recurrenceexpansionjobbatchsize"); }
			set
			{ 
				if(value == RecurrenceExpansionOnDemandJobBatchSize) return;
				SetAttributeValue("recurrenceexpansionjobbatchsize", value);
			}
		}	
			
		/// <summary>
        /// recurrenceexpansionsynchcreatemax
        /// </summary>
		[DisplayName("Recurrence Expansion Synchronization Create Maximum")]
		[AttributeLogicalName("recurrenceexpansionsynchcreatemax")]
		public int? RecurrenceExpansionSynchronizationCreateMaximum
		{	
			get { return GetAttributeValue<int?>("recurrenceexpansionsynchcreatemax"); }
			set
			{ 
				if(value == RecurrenceExpansionSynchronizationCreateMaximum) return;
				SetAttributeValue("recurrenceexpansionsynchcreatemax", value);
			}
		}	
			
		/// <summary>
        /// referencesitemapxml
        /// </summary>
		[DisplayName("Reference SiteMap XML")]
		[AttributeLogicalName("referencesitemapxml")]
		public string ReferenceSiteMapXML
		{	
			get { return GetAttributeValue<string>("referencesitemapxml"); }
			set
			{ 
				if(value == ReferenceSiteMapXML) return;
				SetAttributeValue("referencesitemapxml", value);
			}
		}	
			
		/// <summary>
        /// rendersecureiframeforemail
        /// </summary>
		[DisplayName("Render Secure Frame For Email")]
		[AttributeLogicalName("rendersecureiframeforemail")]
		public bool? RenderSecureFrameForEmail
		{	
			get { return GetAttributeValue<bool?>("rendersecureiframeforemail"); }
			set
			{ 
				if(value == RenderSecureFrameForEmail) return;
				SetAttributeValue("rendersecureiframeforemail", value);
			}
		}	
			
		/// <summary>
        /// reportinggroupid
        /// </summary>
		[DisplayName("Reporting Group")]
		[AttributeLogicalName("reportinggroupid")]
		public Guid ReportingGroupId
		{	
			get { return GetAttributeValue<Guid>("reportinggroupid"); }
			set
			{ 
				if(value == ReportingGroupId) return;
				SetAttributeValue("reportinggroupid", value);
			}
		}	
			
		/// <summary>
        /// reportinggroupname
        /// </summary>
		[DisplayName("Reporting Group Name")]
		[AttributeLogicalName("reportinggroupname")]
		public string ReportingGroupName
		{	
			get { return GetAttributeValue<string>("reportinggroupname"); }
			set
			{ 
				if(value == ReportingGroupName) return;
				SetAttributeValue("reportinggroupname", value);
			}
		}	
			
		/// <summary>
        /// reportscripterrors
        /// </summary>
		[DisplayName("Report Script Errors")]
		[AttributeLogicalName("reportscripterrors")]
		public eReportScriptErrors? ReportScriptErrors
		{	
			get 
			{ 
				var optionSetValue = GetAttributeValue<OptionSetValue>("reportscripterrors");
				if (optionSetValue != null) return (eReportScriptErrors)optionSetValue.Value;
				else return null;
			}
			set 
			{ 
				if(value == ReportScriptErrors) return;

				OptionSetValue optionSetValue = null;
				if(value != null) optionSetValue = new OptionSetValue((int)value);
				SetAttributeValue("reportscripterrors", optionSetValue); 
			}
		}

		/// <summary>
        /// requireapprovalforqueueemail
        /// </summary>
		[DisplayName("Is Approval For Queue Email Required")]
		[AttributeLogicalName("requireapprovalforqueueemail")]
		public bool? IsApprovalForQueueEmailRequired
		{	
			get { return GetAttributeValue<bool?>("requireapprovalforqueueemail"); }
			set
			{ 
				if(value == IsApprovalForQueueEmailRequired) return;
				SetAttributeValue("requireapprovalforqueueemail", value);
			}
		}	
			
		/// <summary>
        /// requireapprovalforuseremail
        /// </summary>
		[DisplayName("Is Approval For User Email Required")]
		[AttributeLogicalName("requireapprovalforuseremail")]
		public bool? IsApprovalForUserEmailRequired
		{	
			get { return GetAttributeValue<bool?>("requireapprovalforuseremail"); }
			set
			{ 
				if(value == IsApprovalForUserEmailRequired) return;
				SetAttributeValue("requireapprovalforuseremail", value);
			}
		}	
			
		/// <summary>
        /// resolvesimilarunresolvedemailaddress
        /// </summary>
		[DisplayName("Apply same email address to all unresolved matches when you manually resolve it for one")]
		[AttributeLogicalName("resolvesimilarunresolvedemailaddress")]
		public bool? ApplySameEmailAddressToAllUnresolvedMatchesWhenYouManuallyResolveItForOne
		{	
			get { return GetAttributeValue<bool?>("resolvesimilarunresolvedemailaddress"); }
			set
			{ 
				if(value == ApplySameEmailAddressToAllUnresolvedMatchesWhenYouManuallyResolveItForOne) return;
				SetAttributeValue("resolvesimilarunresolvedemailaddress", value);
			}
		}	
			
		/// <summary>
        /// restrictstatusupdate
        /// </summary>
		[DisplayName("Restrict Status Update")]
		[AttributeLogicalName("restrictstatusupdate")]
		public bool? RestrictStatusUpdate
		{	
			get { return GetAttributeValue<bool?>("restrictstatusupdate"); }
			set
			{ 
				if(value == RestrictStatusUpdate) return;
				SetAttributeValue("restrictstatusupdate", value);
			}
		}	
			
		/// <summary>
        /// rierrorstatus
        /// </summary>
		[DisplayName("Error status of Relationship Insights provisioning.")]
		[AttributeLogicalName("rierrorstatus")]
		public int? ErrorStatusOfRelationshipInsightsProvisioning
		{	
			get { return GetAttributeValue<int?>("rierrorstatus"); }
			set
			{ 
				if(value == ErrorStatusOfRelationshipInsightsProvisioning) return;
				SetAttributeValue("rierrorstatus", value);
			}
		}	
			
		/// <summary>
        /// sampledataimportid
        /// </summary>
		[DisplayName("Sample Data Import")]
		[AttributeLogicalName("sampledataimportid")]
		public Guid SampleDataImportId
		{	
			get { return GetAttributeValue<Guid>("sampledataimportid"); }
			set
			{ 
				if(value == SampleDataImportId) return;
				SetAttributeValue("sampledataimportid", value);
			}
		}	
			
		/// <summary>
        /// schedulingengine
        /// </summary>
		[DisplayName("Scheduling engine for Appointments and Service Activities")]
		[AttributeLogicalName("schedulingengine")]
		public eSchedulingEngineForAppointmentsAndServiceActivities? SchedulingEngineForAppointmentsAndServiceActivities
		{	
			get 
			{ 
				var optionSetValue = GetAttributeValue<OptionSetValue>("schedulingengine");
				if (optionSetValue != null) return (eSchedulingEngineForAppointmentsAndServiceActivities)optionSetValue.Value;
				else return null;
			}
			set 
			{ 
				if(value == SchedulingEngineForAppointmentsAndServiceActivities) return;

				OptionSetValue optionSetValue = null;
				if(value != null) optionSetValue = new OptionSetValue((int)value);
				SetAttributeValue("schedulingengine", optionSetValue); 
			}
		}

		/// <summary>
        /// schemanameprefix
        /// </summary>
		[DisplayName("Customization Name Prefix")]
		[AttributeLogicalName("schemanameprefix")]
		public string CustomizationNamePrefix
		{	
			get { return GetAttributeValue<string>("schemanameprefix"); }
			set
			{ 
				if(value == CustomizationNamePrefix) return;
				SetAttributeValue("schemanameprefix", value);
			}
		}	
			
		/// <summary>
        /// sendbulkemailinuci
        /// </summary>
		[DisplayName("Send Bulk Email in UCI")]
		[AttributeLogicalName("sendbulkemailinuci")]
		public bool? SendBulkEmailInUCI
		{	
			get { return GetAttributeValue<bool?>("sendbulkemailinuci"); }
			set
			{ 
				if(value == SendBulkEmailInUCI) return;
				SetAttributeValue("sendbulkemailinuci", value);
			}
		}	
			
		/// <summary>
        /// servestaticresourcesfromazurecdn
        /// </summary>
		[DisplayName("Serve Static Content From CDN")]
		[AttributeLogicalName("servestaticresourcesfromazurecdn")]
		public bool? ServeStaticContentFromCDN
		{	
			get { return GetAttributeValue<bool?>("servestaticresourcesfromazurecdn"); }
			set
			{ 
				if(value == ServeStaticContentFromCDN) return;
				SetAttributeValue("servestaticresourcesfromazurecdn", value);
			}
		}	
			
		/// <summary>
        /// sessiontimeoutenabled
        /// </summary>
		[DisplayName("Session timeout enabled")]
		[AttributeLogicalName("sessiontimeoutenabled")]
		public bool? SessionTimeoutEnabled
		{	
			get { return GetAttributeValue<bool?>("sessiontimeoutenabled"); }
			set
			{ 
				if(value == SessionTimeoutEnabled) return;
				SetAttributeValue("sessiontimeoutenabled", value);
			}
		}	
			
		/// <summary>
        /// sessiontimeoutinmins
        /// </summary>
		[DisplayName("Session timeout in minutes")]
		[AttributeLogicalName("sessiontimeoutinmins")]
		public int? SessionTimeoutInMinutes
		{	
			get { return GetAttributeValue<int?>("sessiontimeoutinmins"); }
			set
			{ 
				if(value == SessionTimeoutInMinutes) return;
				SetAttributeValue("sessiontimeoutinmins", value);
			}
		}	
			
		/// <summary>
        /// sessiontimeoutreminderinmins
        /// </summary>
		[DisplayName("Session timeout reminder in minutes")]
		[AttributeLogicalName("sessiontimeoutreminderinmins")]
		public int? SessionTimeoutReminderInMinutes
		{	
			get { return GetAttributeValue<int?>("sessiontimeoutreminderinmins"); }
			set
			{ 
				if(value == SessionTimeoutReminderInMinutes) return;
				SetAttributeValue("sessiontimeoutreminderinmins", value);
			}
		}	
			
		/// <summary>
        /// sharepointdeploymenttype
        /// </summary>
		[DisplayName("Choose SharePoint Deployment Type")]
		[AttributeLogicalName("sharepointdeploymenttype")]
		public eOrganizationSharepointdeploymenttype? ChooseSharePointDeploymentType
		{	
			get 
			{ 
				var optionSetValue = GetAttributeValue<OptionSetValue>("sharepointdeploymenttype");
				if (optionSetValue != null) return (eOrganizationSharepointdeploymenttype)optionSetValue.Value;
				else return null;
			}
			set 
			{ 
				if(value == ChooseSharePointDeploymentType) return;

				OptionSetValue optionSetValue = null;
				if(value != null) optionSetValue = new OptionSetValue((int)value);
				SetAttributeValue("sharepointdeploymenttype", optionSetValue); 
			}
		}

		/// <summary>
        /// sharetopreviousowneronassign
        /// </summary>
		[DisplayName("Share To Previous Owner On Assign")]
		[AttributeLogicalName("sharetopreviousowneronassign")]
		public bool? ShareToPreviousOwnerOnAssign
		{	
			get { return GetAttributeValue<bool?>("sharetopreviousowneronassign"); }
			set
			{ 
				if(value == ShareToPreviousOwnerOnAssign) return;
				SetAttributeValue("sharetopreviousowneronassign", value);
			}
		}	
			
		/// <summary>
        /// showkbarticledeprecationnotification
        /// </summary>
		[DisplayName("Show KBArticle deprecation message to user")]
		[AttributeLogicalName("showkbarticledeprecationnotification")]
		public bool? ShowKBArticleDeprecationMessageToUser
		{	
			get { return GetAttributeValue<bool?>("showkbarticledeprecationnotification"); }
			set
			{ 
				if(value == ShowKBArticleDeprecationMessageToUser) return;
				SetAttributeValue("showkbarticledeprecationnotification", value);
			}
		}	
			
		/// <summary>
        /// showweeknumber
        /// </summary>
		[DisplayName("Show Week Number")]
		[AttributeLogicalName("showweeknumber")]
		public bool? ShowWeekNumber
		{	
			get { return GetAttributeValue<bool?>("showweeknumber"); }
			set
			{ 
				if(value == ShowWeekNumber) return;
				SetAttributeValue("showweeknumber", value);
			}
		}	
			
		/// <summary>
        /// signupoutlookdownloadfwlink
        /// </summary>
		[DisplayName("CRMForOutlookDownloadURL")]
		[AttributeLogicalName("signupoutlookdownloadfwlink")]
		public string CRMForOutlookDownloadURL
		{	
			get { return GetAttributeValue<string>("signupoutlookdownloadfwlink"); }
			set
			{ 
				if(value == CRMForOutlookDownloadURL) return;
				SetAttributeValue("signupoutlookdownloadfwlink", value);
			}
		}	
			
		/// <summary>
        /// sitemapxml
        /// </summary>
		[DisplayName("SiteMap XML")]
		[AttributeLogicalName("sitemapxml")]
		public string SiteMapXML
		{	
			get { return GetAttributeValue<string>("sitemapxml"); }
			set
			{ 
				if(value == SiteMapXML) return;
				SetAttributeValue("sitemapxml", value);
			}
		}	
			
		/// <summary>
        /// slapausestates
        /// </summary>
		[DisplayName("SLA pause states")]
		[AttributeLogicalName("slapausestates")]
		public string SLAPauseStates
		{	
			get { return GetAttributeValue<string>("slapausestates"); }
			set
			{ 
				if(value == SLAPauseStates) return;
				SetAttributeValue("slapausestates", value);
			}
		}	
			
		/// <summary>
        /// socialinsightsenabled
        /// </summary>
		[DisplayName("Social Insights Enabled")]
		[AttributeLogicalName("socialinsightsenabled")]
		public bool? SocialInsightsEnabled
		{	
			get { return GetAttributeValue<bool?>("socialinsightsenabled"); }
			set
			{ 
				if(value == SocialInsightsEnabled) return;
				SetAttributeValue("socialinsightsenabled", value);
			}
		}	
			
		/// <summary>
        /// socialinsightsinstance
        /// </summary>
		[DisplayName("Social Insights instance identifier")]
		[AttributeLogicalName("socialinsightsinstance")]
		public string SocialInsightsInstanceIdentifier
		{	
			get { return GetAttributeValue<string>("socialinsightsinstance"); }
			set
			{ 
				if(value == SocialInsightsInstanceIdentifier) return;
				SetAttributeValue("socialinsightsinstance", value);
			}
		}	
			
		/// <summary>
        /// socialinsightstermsaccepted
        /// </summary>
		[DisplayName("Social Insights Terms of Use")]
		[AttributeLogicalName("socialinsightstermsaccepted")]
		public bool? SocialInsightsTermsOfUse
		{	
			get { return GetAttributeValue<bool?>("socialinsightstermsaccepted"); }
			set
			{ 
				if(value == SocialInsightsTermsOfUse) return;
				SetAttributeValue("socialinsightstermsaccepted", value);
			}
		}	
			
		/// <summary>
        /// sortid
        /// </summary>
		[DisplayName("Sort")]
		[AttributeLogicalName("sortid")]
		public int? Sort
		{	
			get { return GetAttributeValue<int?>("sortid"); }
			set
			{ 
				if(value == Sort) return;
				SetAttributeValue("sortid", value);
			}
		}	
			
		/// <summary>
        /// sqlaccessgroupid
        /// </summary>
		[DisplayName("SQL Access Group")]
		[AttributeLogicalName("sqlaccessgroupid")]
		public Guid SQLAccessGroupId
		{	
			get { return GetAttributeValue<Guid>("sqlaccessgroupid"); }
			set
			{ 
				if(value == SQLAccessGroupId) return;
				SetAttributeValue("sqlaccessgroupid", value);
			}
		}	
			
		/// <summary>
        /// sqlaccessgroupname
        /// </summary>
		[DisplayName("SQL Access Group Name")]
		[AttributeLogicalName("sqlaccessgroupname")]
		public string SQLAccessGroupName
		{	
			get { return GetAttributeValue<string>("sqlaccessgroupname"); }
			set
			{ 
				if(value == SQLAccessGroupName) return;
				SetAttributeValue("sqlaccessgroupname", value);
			}
		}	
			
		/// <summary>
        /// sqmenabled
        /// </summary>
		[DisplayName("Is SQM Enabled")]
		[AttributeLogicalName("sqmenabled")]
		public bool? IsSQMEnabled
		{	
			get { return GetAttributeValue<bool?>("sqmenabled"); }
			set
			{ 
				if(value == IsSQMEnabled) return;
				SetAttributeValue("sqmenabled", value);
			}
		}	
			
		/// <summary>
        /// supportuserid
        /// </summary>
		[DisplayName("Support User")]
		[AttributeLogicalName("supportuserid")]
		public Guid SupportUserId
		{	
			get { return GetAttributeValue<Guid>("supportuserid"); }
			set
			{ 
				if(value == SupportUserId) return;
				SetAttributeValue("supportuserid", value);
			}
		}	
			
		/// <summary>
        /// suppresssla
        /// </summary>
		[DisplayName("Is SLA suppressed")]
		[AttributeLogicalName("suppresssla")]
		public bool? IsSLASuppressed
		{	
			get { return GetAttributeValue<bool?>("suppresssla"); }
			set
			{ 
				if(value == IsSLASuppressed) return;
				SetAttributeValue("suppresssla", value);
			}
		}	
			
		/// <summary>
        /// syncbulkoperationbatchsize
        /// </summary>
		[DisplayName("Number of records to update per operation in Sync Bulk Pause/Resume/Cancel")]
		[AttributeLogicalName("syncbulkoperationbatchsize")]
		public int? NumberOfRecordsToUpdatePerOperationInSyncBulkPauseResumeCancel
		{	
			get { return GetAttributeValue<int?>("syncbulkoperationbatchsize"); }
			set
			{ 
				if(value == NumberOfRecordsToUpdatePerOperationInSyncBulkPauseResumeCancel) return;
				SetAttributeValue("syncbulkoperationbatchsize", value);
			}
		}	
			
		/// <summary>
        /// syncbulkoperationmaxlimit
        /// </summary>
		[DisplayName("Max total number of records to update in database for Sync Bulk Pause/Resume/Cancel")]
		[AttributeLogicalName("syncbulkoperationmaxlimit")]
		public int? MaxTotalNumberOfRecordsToUpdateInDatabaseForSyncBulkPauseResumeCancel
		{	
			get { return GetAttributeValue<int?>("syncbulkoperationmaxlimit"); }
			set
			{ 
				if(value == MaxTotalNumberOfRecordsToUpdateInDatabaseForSyncBulkPauseResumeCancel) return;
				SetAttributeValue("syncbulkoperationmaxlimit", value);
			}
		}	
			
		/// <summary>
        /// syncoptinselection
        /// </summary>
		[DisplayName("Enable dynamics 365 azure sync framework for this organization.")]
		[AttributeLogicalName("syncoptinselection")]
		public bool? EnableDynamics365AzureSyncFrameworkForThisOrganization
		{	
			get { return GetAttributeValue<bool?>("syncoptinselection"); }
			set
			{ 
				if(value == EnableDynamics365AzureSyncFrameworkForThisOrganization) return;
				SetAttributeValue("syncoptinselection", value);
			}
		}	
			
		/// <summary>
        /// syncoptinselectionstatus
        /// </summary>
		[DisplayName("Status of opt-in or opt-out operation for dynamics 365 azure sync.")]
		[AttributeLogicalName("syncoptinselectionstatus")]
		public eOrganizationSyncoptinselectionstatus? StatusOfOptinOrOptoutOperationForDynamics365AzureSync
		{	
			get 
			{ 
				var optionSetValue = GetAttributeValue<OptionSetValue>("syncoptinselectionstatus");
				if (optionSetValue != null) return (eOrganizationSyncoptinselectionstatus)optionSetValue.Value;
				else return null;
			}
			set 
			{ 
				if(value == StatusOfOptinOrOptoutOperationForDynamics365AzureSync) return;

				OptionSetValue optionSetValue = null;
				if(value != null) optionSetValue = new OptionSetValue((int)value);
				SetAttributeValue("syncoptinselectionstatus", optionSetValue); 
			}
		}

		/// <summary>
        /// systemuserid
        /// </summary>
		[DisplayName("System User")]
		[AttributeLogicalName("systemuserid")]
		public Guid SystemUserId
		{	
			get { return GetAttributeValue<Guid>("systemuserid"); }
			set
			{ 
				if(value == SystemUserId) return;
				SetAttributeValue("systemuserid", value);
			}
		}	
			
		/// <summary>
        /// tagmaxaggressivecycles
        /// </summary>
		[DisplayName("Auto-Tag Max Cycles")]
		[AttributeLogicalName("tagmaxaggressivecycles")]
		public int? AutoTagMaxCycles
		{	
			get { return GetAttributeValue<int?>("tagmaxaggressivecycles"); }
			set
			{ 
				if(value == AutoTagMaxCycles) return;
				SetAttributeValue("tagmaxaggressivecycles", value);
			}
		}	
			
		/// <summary>
        /// tagpollingperiod
        /// </summary>
		[DisplayName("Auto-Tag Interval")]
		[AttributeLogicalName("tagpollingperiod")]
		public int? AutoTagInterval
		{	
			get { return GetAttributeValue<int?>("tagpollingperiod"); }
			set
			{ 
				if(value == AutoTagInterval) return;
				SetAttributeValue("tagpollingperiod", value);
			}
		}	
			
		/// <summary>
        /// taskbasedflowenabled
        /// </summary>
		[DisplayName("Enable Task Flow processes for this Organization")]
		[AttributeLogicalName("taskbasedflowenabled")]
		public bool? EnableTaskFlowProcessesForThisOrganization
		{	
			get { return GetAttributeValue<bool?>("taskbasedflowenabled"); }
			set
			{ 
				if(value == EnableTaskFlowProcessesForThisOrganization) return;
				SetAttributeValue("taskbasedflowenabled", value);
			}
		}	
			
		/// <summary>
        /// textanalyticsenabled
        /// </summary>
		[DisplayName("Enable Text Analytics for this Organization")]
		[AttributeLogicalName("textanalyticsenabled")]
		public bool? EnableTextAnalyticsForThisOrganization
		{	
			get { return GetAttributeValue<bool?>("textanalyticsenabled"); }
			set
			{ 
				if(value == EnableTextAnalyticsForThisOrganization) return;
				SetAttributeValue("textanalyticsenabled", value);
			}
		}	
			
		/// <summary>
        /// timeformatcode
        /// </summary>
		[DisplayName("Time Format Code")]
		[AttributeLogicalName("timeformatcode")]
		public eOrganizationTimeformatcode? TimeFormatCode
		{	
			get 
			{ 
				var optionSetValue = GetAttributeValue<OptionSetValue>("timeformatcode");
				if (optionSetValue != null) return (eOrganizationTimeformatcode)optionSetValue.Value;
				else return null;
			}
			set 
			{ 
				if(value == TimeFormatCode) return;

				OptionSetValue optionSetValue = null;
				if(value != null) optionSetValue = new OptionSetValue((int)value);
				SetAttributeValue("timeformatcode", optionSetValue); 
			}
		}

		/// <summary>
        /// timeformatstring
        /// </summary>
		[DisplayName("Time Format String")]
		[AttributeLogicalName("timeformatstring")]
		public string TimeFormatString
		{	
			get { return GetAttributeValue<string>("timeformatstring"); }
			set
			{ 
				if(value == TimeFormatString) return;
				SetAttributeValue("timeformatstring", value);
			}
		}	
			
		/// <summary>
        /// timeseparator
        /// </summary>
		[DisplayName("Time Separator")]
		[AttributeLogicalName("timeseparator")]
		public string TimeSeparator
		{	
			get { return GetAttributeValue<string>("timeseparator"); }
			set
			{ 
				if(value == TimeSeparator) return;
				SetAttributeValue("timeseparator", value);
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
        /// tokenexpiry
        /// </summary>
		[DisplayName("Token Expiration Duration")]
		[AttributeLogicalName("tokenexpiry")]
		public int? TokenExpirationDuration
		{	
			get { return GetAttributeValue<int?>("tokenexpiry"); }
			set
			{ 
				if(value == TokenExpirationDuration) return;
				SetAttributeValue("tokenexpiry", value);
			}
		}	
			
		/// <summary>
        /// tokenkey
        /// </summary>
		[DisplayName("Token Key")]
		[AttributeLogicalName("tokenkey")]
		public string TokenKey
		{	
			get { return GetAttributeValue<string>("tokenkey"); }
			set
			{ 
				if(value == TokenKey) return;
				SetAttributeValue("tokenkey", value);
			}
		}	
			
		/// <summary>
        /// tracelogmaximumageindays
        /// </summary>
		[DisplayName("Tracelog record maximum age in days")]
		[AttributeLogicalName("tracelogmaximumageindays")]
		public int? TracelogRecordMaximumAgeInDays
		{	
			get { return GetAttributeValue<int?>("tracelogmaximumageindays"); }
			set
			{ 
				if(value == TracelogRecordMaximumAgeInDays) return;
				SetAttributeValue("tracelogmaximumageindays", value);
			}
		}	
			
		/// <summary>
        /// trackingprefix
        /// </summary>
		[DisplayName("Tracking Prefix")]
		[AttributeLogicalName("trackingprefix")]
		public string TrackingPrefix
		{	
			get { return GetAttributeValue<string>("trackingprefix"); }
			set
			{ 
				if(value == TrackingPrefix) return;
				SetAttributeValue("trackingprefix", value);
			}
		}	
			
		/// <summary>
        /// trackingtokenidbase
        /// </summary>
		[DisplayName("Tracking Token Base")]
		[AttributeLogicalName("trackingtokenidbase")]
		public int? TrackingTokenBase
		{	
			get { return GetAttributeValue<int?>("trackingtokenidbase"); }
			set
			{ 
				if(value == TrackingTokenBase) return;
				SetAttributeValue("trackingtokenidbase", value);
			}
		}	
			
		/// <summary>
        /// trackingtokeniddigits
        /// </summary>
		[DisplayName("Tracking Token Digits")]
		[AttributeLogicalName("trackingtokeniddigits")]
		public int? TrackingTokenDigits
		{	
			get { return GetAttributeValue<int?>("trackingtokeniddigits"); }
			set
			{ 
				if(value == TrackingTokenDigits) return;
				SetAttributeValue("trackingtokeniddigits", value);
			}
		}	
			
		/// <summary>
        /// uniquespecifierlength
        /// </summary>
		[DisplayName("Unique String Length")]
		[AttributeLogicalName("uniquespecifierlength")]
		public int? UniqueStringLength
		{	
			get { return GetAttributeValue<int?>("uniquespecifierlength"); }
			set
			{ 
				if(value == UniqueStringLength) return;
				SetAttributeValue("uniquespecifierlength", value);
			}
		}	
			
		/// <summary>
        /// unresolveemailaddressifmultiplematch
        /// </summary>
		[DisplayName("Set To,cc,bcc fields as unresolved if multiple matches are found")]
		[AttributeLogicalName("unresolveemailaddressifmultiplematch")]
		public bool? SetToccbccFieldsAsUnresolvedIfMultipleMatchesAreFound
		{	
			get { return GetAttributeValue<bool?>("unresolveemailaddressifmultiplematch"); }
			set
			{ 
				if(value == SetToccbccFieldsAsUnresolvedIfMultipleMatchesAreFound) return;
				SetAttributeValue("unresolveemailaddressifmultiplematch", value);
			}
		}	
			
		/// <summary>
        /// useinbuiltrulefordefaultpricelistselection
        /// </summary>
		[DisplayName("Use Inbuilt Rule For Default Pricelist Selection")]
		[AttributeLogicalName("useinbuiltrulefordefaultpricelistselection")]
		public bool? UseInbuiltRuleForDefaultPricelistSelection
		{	
			get { return GetAttributeValue<bool?>("useinbuiltrulefordefaultpricelistselection"); }
			set
			{ 
				if(value == UseInbuiltRuleForDefaultPricelistSelection) return;
				SetAttributeValue("useinbuiltrulefordefaultpricelistselection", value);
			}
		}	
			
		/// <summary>
        /// uselegacyrendering
        /// </summary>
		[DisplayName("Legacy Form Rendering")]
		[AttributeLogicalName("uselegacyrendering")]
		public bool? LegacyFormRendering
		{	
			get { return GetAttributeValue<bool?>("uselegacyrendering"); }
			set
			{ 
				if(value == LegacyFormRendering) return;
				SetAttributeValue("uselegacyrendering", value);
			}
		}	
			
		/// <summary>
        /// usepositionhierarchy
        /// </summary>
		[DisplayName("Use position hierarchy")]
		[AttributeLogicalName("usepositionhierarchy")]
		public bool? UsePositionHierarchy
		{	
			get { return GetAttributeValue<bool?>("usepositionhierarchy"); }
			set
			{ 
				if(value == UsePositionHierarchy) return;
				SetAttributeValue("usepositionhierarchy", value);
			}
		}	
			
		/// <summary>
        /// usequickfindviewforgridsearch
        /// </summary>
		[DisplayName("Use Quick Find view when searching in grids")]
		[AttributeLogicalName("usequickfindviewforgridsearch")]
		public bool? UseQuickFindViewWhenSearchingInGrids
		{	
			get { return GetAttributeValue<bool?>("usequickfindviewforgridsearch"); }
			set
			{ 
				if(value == UseQuickFindViewWhenSearchingInGrids) return;
				SetAttributeValue("usequickfindviewforgridsearch", value);
			}
		}	
			
		/// <summary>
        /// useraccessauditinginterval
        /// </summary>
		[DisplayName("User Authentication Auditing Interval")]
		[AttributeLogicalName("useraccessauditinginterval")]
		public int? UserAuthenticationAuditingInterval
		{	
			get { return GetAttributeValue<int?>("useraccessauditinginterval"); }
			set
			{ 
				if(value == UserAuthenticationAuditingInterval) return;
				SetAttributeValue("useraccessauditinginterval", value);
			}
		}	
			
		/// <summary>
        /// usereadform
        /// </summary>
		[DisplayName("Use Read-Optimized Form")]
		[AttributeLogicalName("usereadform")]
		public bool? UseReadOptimizedForm
		{	
			get { return GetAttributeValue<bool?>("usereadform"); }
			set
			{ 
				if(value == UseReadOptimizedForm) return;
				SetAttributeValue("usereadform", value);
			}
		}	
			
		/// <summary>
        /// usergroupid
        /// </summary>
		[DisplayName("User Group")]
		[AttributeLogicalName("usergroupid")]
		public Guid UserGroupId
		{	
			get { return GetAttributeValue<Guid>("usergroupid"); }
			set
			{ 
				if(value == UserGroupId) return;
				SetAttributeValue("usergroupid", value);
			}
		}	
			
		/// <summary>
        /// useskypeprotocol
        /// </summary>
		[DisplayName("User Skype Protocol")]
		[AttributeLogicalName("useskypeprotocol")]
		public bool? UserSkypeProtocol
		{	
			get { return GetAttributeValue<bool?>("useskypeprotocol"); }
			set
			{ 
				if(value == UserSkypeProtocol) return;
				SetAttributeValue("useskypeprotocol", value);
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
        /// v3calloutconfighash
        /// </summary>
		[DisplayName("V3 Callout Hash")]
		[AttributeLogicalName("v3calloutconfighash")]
		public string V3CalloutHash
		{	
			get { return GetAttributeValue<string>("v3calloutconfighash"); }
			set
			{ 
				if(value == V3CalloutHash) return;
				SetAttributeValue("v3calloutconfighash", value);
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
        /// webresourcehash
        /// </summary>
		[DisplayName("Web resource hash")]
		[AttributeLogicalName("webresourcehash")]
		public string WebResourceHash
		{	
			get { return GetAttributeValue<string>("webresourcehash"); }
			set
			{ 
				if(value == WebResourceHash) return;
				SetAttributeValue("webresourcehash", value);
			}
		}	
			
		/// <summary>
        /// weekstartdaycode
        /// </summary>
		[DisplayName("Week Start Day Code")]
		[AttributeLogicalName("weekstartdaycode")]
		public eOrganizationWeekstartdaycode? WeekStartDayCode
		{	
			get 
			{ 
				var optionSetValue = GetAttributeValue<OptionSetValue>("weekstartdaycode");
				if (optionSetValue != null) return (eOrganizationWeekstartdaycode)optionSetValue.Value;
				else return null;
			}
			set 
			{ 
				if(value == WeekStartDayCode) return;

				OptionSetValue optionSetValue = null;
				if(value != null) optionSetValue = new OptionSetValue((int)value);
				SetAttributeValue("weekstartdaycode", optionSetValue); 
			}
		}

		/// <summary>
        /// widgetproperties
        /// </summary>
		[DisplayName("For Internal use only.")]
		[AttributeLogicalName("widgetproperties")]
		public string ForInternalUseOnly3
		{	
			get { return GetAttributeValue<string>("widgetproperties"); }
			set
			{ 
				if(value == ForInternalUseOnly3) return;
				SetAttributeValue("widgetproperties", value);
			}
		}	
			
		/// <summary>
        /// yammergroupid
        /// </summary>
		[DisplayName("Yammer Group Id")]
		[AttributeLogicalName("yammergroupid")]
		public int? YammerGroupId
		{	
			get { return GetAttributeValue<int?>("yammergroupid"); }
			set
			{ 
				if(value == YammerGroupId) return;
				SetAttributeValue("yammergroupid", value);
			}
		}	
			
		/// <summary>
        /// yammernetworkpermalink
        /// </summary>
		[DisplayName("Yammer Network Permalink")]
		[AttributeLogicalName("yammernetworkpermalink")]
		public string YammerNetworkPermalink
		{	
			get { return GetAttributeValue<string>("yammernetworkpermalink"); }
			set
			{ 
				if(value == YammerNetworkPermalink) return;
				SetAttributeValue("yammernetworkpermalink", value);
			}
		}	
			
		/// <summary>
        /// yammeroauthaccesstokenexpired
        /// </summary>
		[DisplayName("Yammer OAuth Access Token Expired")]
		[AttributeLogicalName("yammeroauthaccesstokenexpired")]
		public bool? YammerOAuthAccessTokenExpired
		{	
			get { return GetAttributeValue<bool?>("yammeroauthaccesstokenexpired"); }
			set
			{ 
				if(value == YammerOAuthAccessTokenExpired) return;
				SetAttributeValue("yammeroauthaccesstokenexpired", value);
			}
		}	
			
		/// <summary>
        /// yammerpostmethod
        /// </summary>
		[DisplayName("Internal Use Only")]
		[AttributeLogicalName("yammerpostmethod")]
		public eOrganizationYammerpostmethod? InternalUseOnly
		{	
			get 
			{ 
				var optionSetValue = GetAttributeValue<OptionSetValue>("yammerpostmethod");
				if (optionSetValue != null) return (eOrganizationYammerpostmethod)optionSetValue.Value;
				else return null;
			}
			set 
			{ 
				if(value == InternalUseOnly) return;

				OptionSetValue optionSetValue = null;
				if(value != null) optionSetValue = new OptionSetValue((int)value);
				SetAttributeValue("yammerpostmethod", optionSetValue); 
			}
		}

		/// <summary>
        /// yearstartweekcode
        /// </summary>
		[DisplayName("Year Start Week Code")]
		[AttributeLogicalName("yearstartweekcode")]
		public int? YearStartWeekCode
		{	
			get { return GetAttributeValue<int?>("yearstartweekcode"); }
			set
			{ 
				if(value == YearStartWeekCode) return;
				SetAttributeValue("yearstartweekcode", value);
			}
		}	
			
		#endregion	

		#region Relations
			/// <summary>
        /// 1:N Get entities for 'customcontrol_organization'
        /// </summary>
		[RelationshipSchemaName("customcontrol_organization")]
		public IEnumerable<CustomControl> CustomcontrolOrganization
		{
			get { return GetRelatedEntities<CustomControl>("customcontrol_organization", null); }
			set { SetRelatedEntities("customcontrol_organization", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'customcontroldefaultconfig_organization'
        /// </summary>
		[RelationshipSchemaName("customcontroldefaultconfig_organization")]
		public IEnumerable<CustomControlDefaultConfig> CustomcontroldefaultconfigOrganization
		{
			get { return GetRelatedEntities<CustomControlDefaultConfig>("customcontroldefaultconfig_organization", null); }
			set { SetRelatedEntities("customcontroldefaultconfig_organization", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'customcontrolresource_organization'
        /// </summary>
		[RelationshipSchemaName("customcontrolresource_organization")]
		public IEnumerable<CustomControlResource> CustomcontrolresourceOrganization
		{
			get { return GetRelatedEntities<CustomControlResource>("customcontrolresource_organization", null); }
			set { SetRelatedEntities("customcontrolresource_organization", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'dynamicproperty_organization'
        /// </summary>
		[RelationshipSchemaName("dynamicproperty_organization")]
		public IEnumerable<Property> DynamicpropertyOrganization
		{
			get { return GetRelatedEntities<Property>("dynamicproperty_organization", null); }
			set { SetRelatedEntities("dynamicproperty_organization", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'DynamicPropertyAssociation_organization'
        /// </summary>
		[RelationshipSchemaName("DynamicPropertyAssociation_organization")]
		public IEnumerable<PropertyAssociation> DynamicPropertyAssociationOrganization
		{
			get { return GetRelatedEntities<PropertyAssociation>("DynamicPropertyAssociation_organization", null); }
			set { SetRelatedEntities("DynamicPropertyAssociation_organization", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'DynamicPropertyOptionSetItem_organization'
        /// </summary>
		[RelationshipSchemaName("DynamicPropertyOptionSetItem_organization")]
		public IEnumerable<PropertyOptionSetItem> DynamicPropertyOptionSetItemOrganization
		{
			get { return GetRelatedEntities<PropertyOptionSetItem>("DynamicPropertyOptionSetItem_organization", null); }
			set { SetRelatedEntities("DynamicPropertyOptionSetItem_organization", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'entitlementchannel_organization'
        /// </summary>
		[RelationshipSchemaName("entitlementchannel_organization")]
		public IEnumerable<EntitlementChannel> EntitlementchannelOrganization
		{
			get { return GetRelatedEntities<EntitlementChannel>("entitlementchannel_organization", null); }
			set { SetRelatedEntities("entitlementchannel_organization", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'entitlementtemplate_organization'
        /// </summary>
		[RelationshipSchemaName("entitlementtemplate_organization")]
		public IEnumerable<EntitlementTemplate> EntitlementtemplateOrganization
		{
			get { return GetRelatedEntities<EntitlementTemplate>("entitlementtemplate_organization", null); }
			set { SetRelatedEntities("entitlementtemplate_organization", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'entitlementtemplatechannel_organization'
        /// </summary>
		[RelationshipSchemaName("entitlementtemplatechannel_organization")]
		public IEnumerable<EntitlementTemplateChannel> EntitlementtemplatechannelOrganization
		{
			get { return GetRelatedEntities<EntitlementTemplateChannel>("entitlementtemplatechannel_organization", null); }
			set { SetRelatedEntities("entitlementtemplatechannel_organization", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'languagelocale_organization'
        /// </summary>
		[RelationshipSchemaName("languagelocale_organization")]
		public IEnumerable<Language> LanguagelocaleOrganization
		{
			get { return GetRelatedEntities<Language>("languagelocale_organization", null); }
			set { SetRelatedEntities("languagelocale_organization", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_dataperformance_organizationid'
        /// </summary>
		[RelationshipSchemaName("lk_dataperformance_organizationid")]
		public IEnumerable<DataPerformanceDashboard> LkDataperformanceOrganizationid
		{
			get { return GetRelatedEntities<DataPerformanceDashboard>("lk_dataperformance_organizationid", null); }
			set { SetRelatedEntities("lk_dataperformance_organizationid", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_documenttemplatebase_organization'
        /// </summary>
		[RelationshipSchemaName("lk_documenttemplatebase_organization")]
		public IEnumerable<DocumentTemplate> LkDocumenttemplatebaseOrganization
		{
			get { return GetRelatedEntities<DocumentTemplate>("lk_documenttemplatebase_organization", null); }
			set { SetRelatedEntities("lk_documenttemplatebase_organization", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_fieldsecurityprofile_organizationid'
        /// </summary>
		[RelationshipSchemaName("lk_fieldsecurityprofile_organizationid")]
		public IEnumerable<FieldSecurityProfile> LkFieldsecurityprofileOrganizationid
		{
			get { return GetRelatedEntities<FieldSecurityProfile>("lk_fieldsecurityprofile_organizationid", null); }
			set { SetRelatedEntities("lk_fieldsecurityprofile_organizationid", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_principalobjectattributeaccess_organizationid'
        /// </summary>
		[RelationshipSchemaName("lk_principalobjectattributeaccess_organizationid")]
		public IEnumerable<FieldSharing> LkPrincipalobjectattributeaccessOrganizationid
		{
			get { return GetRelatedEntities<FieldSharing>("lk_principalobjectattributeaccess_organizationid", null); }
			set { SetRelatedEntities("lk_principalobjectattributeaccess_organizationid", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'MobileOfflineProfile_organization'
        /// </summary>
		[RelationshipSchemaName("MobileOfflineProfile_organization")]
		public IEnumerable<MobileOfflineProfile> MobileOfflineProfileOrganization
		{
			get { return GetRelatedEntities<MobileOfflineProfile>("MobileOfflineProfile_organization", null); }
			set { SetRelatedEntities("MobileOfflineProfile_organization", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'MobileOfflineProfileItem_organization'
        /// </summary>
		[RelationshipSchemaName("MobileOfflineProfileItem_organization")]
		public IEnumerable<MobileOfflineProfileItem> MobileOfflineProfileItemOrganization
		{
			get { return GetRelatedEntities<MobileOfflineProfileItem>("MobileOfflineProfileItem_organization", null); }
			set { SetRelatedEntities("MobileOfflineProfileItem_organization", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'MobileOfflineProfileItemAssociation_organization'
        /// </summary>
		[RelationshipSchemaName("MobileOfflineProfileItemAssociation_organization")]
		public IEnumerable<MobileOfflineProfileItemAssociation> MobileOfflineProfileItemAssociationOrganization
		{
			get { return GetRelatedEntities<MobileOfflineProfileItemAssociation>("MobileOfflineProfileItemAssociation_organization", null); }
			set { SetRelatedEntities("MobileOfflineProfileItemAssociation_organization", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'organization_aciviewmapper'
        /// </summary>
		[RelationshipSchemaName("organization_aciviewmapper")]
		public IEnumerable<ACIViewMapper> OrganizationAciviewmapper
		{
			get { return GetRelatedEntities<ACIViewMapper>("organization_aciviewmapper", null); }
			set { SetRelatedEntities("organization_aciviewmapper", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'organization_appconfig'
        /// </summary>
		[RelationshipSchemaName("organization_appconfig")]
		public IEnumerable<AppConfiguration> OrganizationAppconfig
		{
			get { return GetRelatedEntities<AppConfiguration>("organization_appconfig", null); }
			set { SetRelatedEntities("organization_appconfig", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'organization_appconfiginstance'
        /// </summary>
		[RelationshipSchemaName("organization_appconfiginstance")]
		public IEnumerable<AppConfigurationInstance> OrganizationAppconfiginstance
		{
			get { return GetRelatedEntities<AppConfigurationInstance>("organization_appconfiginstance", null); }
			set { SetRelatedEntities("organization_appconfiginstance", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'organization_appconfigmaster'
        /// </summary>
		[RelationshipSchemaName("organization_appconfigmaster")]
		public IEnumerable<AppConfigMaster> OrganizationAppconfigmaster
		{
			get { return GetRelatedEntities<AppConfigMaster>("organization_appconfigmaster", null); }
			set { SetRelatedEntities("organization_appconfigmaster", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'organization_appmodule'
        /// </summary>
		[RelationshipSchemaName("organization_appmodule")]
		public IEnumerable<ModeldrivenApp> OrganizationAppmodule
		{
			get { return GetRelatedEntities<ModeldrivenApp>("organization_appmodule", null); }
			set { SetRelatedEntities("organization_appmodule", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'Organization_AsyncOperations'
        /// </summary>
		[RelationshipSchemaName("Organization_AsyncOperations")]
		public IEnumerable<SystemJob> OrganizationAsyncOperations
		{
			get { return GetRelatedEntities<SystemJob>("Organization_AsyncOperations", null); }
			set { SetRelatedEntities("Organization_AsyncOperations", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'Organization_BulkDeleteFailures'
        /// </summary>
		[RelationshipSchemaName("Organization_BulkDeleteFailures")]
		public IEnumerable<BulkDeleteFailure> OrganizationBulkDeleteFailures
		{
			get { return GetRelatedEntities<BulkDeleteFailure>("Organization_BulkDeleteFailures", null); }
			set { SetRelatedEntities("Organization_BulkDeleteFailures", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'organization_business_unit_news_articles'
        /// </summary>
		[RelationshipSchemaName("organization_business_unit_news_articles")]
		public IEnumerable<Announcement> OrganizationBusinessUnitNewsArticles
		{
			get { return GetRelatedEntities<Announcement>("organization_business_unit_news_articles", null); }
			set { SetRelatedEntities("organization_business_unit_news_articles", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'organization_business_units'
        /// </summary>
		[RelationshipSchemaName("organization_business_units")]
		public IEnumerable<BusinessUnit> OrganizationBusinessUnits
		{
			get { return GetRelatedEntities<BusinessUnit>("organization_business_units", null); }
			set { SetRelatedEntities("organization_business_units", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'organization_calendars'
        /// </summary>
		[RelationshipSchemaName("organization_calendars")]
		public IEnumerable<Calendar> OrganizationCalendars
		{
			get { return GetRelatedEntities<Calendar>("organization_calendars", null); }
			set { SetRelatedEntities("organization_calendars", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'organization_catalog'
        /// </summary>
		[RelationshipSchemaName("organization_catalog")]
		public IEnumerable<Catalog> OrganizationCatalog
		{
			get { return GetRelatedEntities<Catalog>("organization_catalog", null); }
			set { SetRelatedEntities("organization_catalog", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'organization_catalogassignment'
        /// </summary>
		[RelationshipSchemaName("organization_catalogassignment")]
		public IEnumerable<CatalogAssignment> OrganizationCatalogassignment
		{
			get { return GetRelatedEntities<CatalogAssignment>("organization_catalogassignment", null); }
			set { SetRelatedEntities("organization_catalogassignment", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'organization_competitors'
        /// </summary>
		[RelationshipSchemaName("organization_competitors")]
		public IEnumerable<Competitor> OrganizationCompetitors
		{
			get { return GetRelatedEntities<Competitor>("organization_competitors", null); }
			set { SetRelatedEntities("organization_competitors", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'organization_complexcontrols'
        /// </summary>
		[RelationshipSchemaName("organization_complexcontrols")]
		public IEnumerable<ProcessConfiguration> OrganizationComplexcontrols
		{
			get { return GetRelatedEntities<ProcessConfiguration>("organization_complexcontrols", null); }
			set { SetRelatedEntities("organization_complexcontrols", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'organization_connection_roles'
        /// </summary>
		[RelationshipSchemaName("organization_connection_roles")]
		public IEnumerable<ConnectionRole> OrganizationConnectionRoles
		{
			get { return GetRelatedEntities<ConnectionRole>("organization_connection_roles", null); }
			set { SetRelatedEntities("organization_connection_roles", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'organization_constraint_based_groups'
        /// </summary>
		[RelationshipSchemaName("organization_constraint_based_groups")]
		public IEnumerable<ResourceGroup> OrganizationConstraintBasedGroups
		{
			get { return GetRelatedEntities<ResourceGroup>("organization_constraint_based_groups", null); }
			set { SetRelatedEntities("organization_constraint_based_groups", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'organization_contract_templates'
        /// </summary>
		[RelationshipSchemaName("organization_contract_templates")]
		public IEnumerable<ContractTemplate> OrganizationContractTemplates
		{
			get { return GetRelatedEntities<ContractTemplate>("organization_contract_templates", null); }
			set { SetRelatedEntities("organization_contract_templates", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'organization_custom_displaystrings'
        /// </summary>
		[RelationshipSchemaName("organization_custom_displaystrings")]
		public IEnumerable<DisplayString> OrganizationCustomDisplaystrings
		{
			get { return GetRelatedEntities<DisplayString>("organization_custom_displaystrings", null); }
			set { SetRelatedEntities("organization_custom_displaystrings", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'organization_datalakeworkspace'
        /// </summary>
		[RelationshipSchemaName("organization_datalakeworkspace")]
		public IEnumerable<DataLakeWorkspace> OrganizationDatalakeworkspace
		{
			get { return GetRelatedEntities<DataLakeWorkspace>("organization_datalakeworkspace", null); }
			set { SetRelatedEntities("organization_datalakeworkspace", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'organization_datalakeworkspacepermission'
        /// </summary>
		[RelationshipSchemaName("organization_datalakeworkspacepermission")]
		public IEnumerable<DataLakeWorkspacePermission> OrganizationDatalakeworkspacepermission
		{
			get { return GetRelatedEntities<DataLakeWorkspacePermission>("organization_datalakeworkspacepermission", null); }
			set { SetRelatedEntities("organization_datalakeworkspacepermission", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'organization_discount_types'
        /// </summary>
		[RelationshipSchemaName("organization_discount_types")]
		public IEnumerable<DiscountList> OrganizationDiscountTypes
		{
			get { return GetRelatedEntities<DiscountList>("organization_discount_types", null); }
			set { SetRelatedEntities("organization_discount_types", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'organization_emailserverprofile'
        /// </summary>
		[RelationshipSchemaName("organization_emailserverprofile")]
		public IEnumerable<EmailServerProfile> OrganizationEmailserverprofile
		{
			get { return GetRelatedEntities<EmailServerProfile>("organization_emailserverprofile", null); }
			set { SetRelatedEntities("organization_emailserverprofile", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'organization_entityanalyticsconfig'
        /// </summary>
		[RelationshipSchemaName("organization_entityanalyticsconfig")]
		public IEnumerable<EntityAnalyticsConfig> OrganizationEntityanalyticsconfig
		{
			get { return GetRelatedEntities<EntityAnalyticsConfig>("organization_entityanalyticsconfig", null); }
			set { SetRelatedEntities("organization_entityanalyticsconfig", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'organization_entitydataprovider'
        /// </summary>
		[RelationshipSchemaName("organization_entitydataprovider")]
		public IEnumerable<VirtualEntityDataProvider> OrganizationEntitydataprovider
		{
			get { return GetRelatedEntities<VirtualEntityDataProvider>("organization_entitydataprovider", null); }
			set { SetRelatedEntities("organization_entitydataprovider", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'organization_equipment'
        /// </summary>
		[RelationshipSchemaName("organization_equipment")]
		public IEnumerable<FacilityEquipment> OrganizationEquipment
		{
			get { return GetRelatedEntities<FacilityEquipment>("organization_equipment", null); }
			set { SetRelatedEntities("organization_equipment", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'organization_expiredprocess'
        /// </summary>
		[RelationshipSchemaName("organization_expiredprocess")]
		public IEnumerable<ExpiredProcess> OrganizationExpiredprocess
		{
			get { return GetRelatedEntities<ExpiredProcess>("organization_expiredprocess", null); }
			set { SetRelatedEntities("organization_expiredprocess", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'organization_importjob'
        /// </summary>
		[RelationshipSchemaName("organization_importjob")]
		public IEnumerable<ImportJob> OrganizationImportjob
		{
			get { return GetRelatedEntities<ImportJob>("organization_importjob", null); }
			set { SetRelatedEntities("organization_importjob", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'organization_kb_article_templates'
        /// </summary>
		[RelationshipSchemaName("organization_kb_article_templates")]
		public IEnumerable<ArticleTemplate> OrganizationKbArticleTemplates
		{
			get { return GetRelatedEntities<ArticleTemplate>("organization_kb_article_templates", null); }
			set { SetRelatedEntities("organization_kb_article_templates", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'organization_kb_articles'
        /// </summary>
		[RelationshipSchemaName("organization_kb_articles")]
		public IEnumerable<Article> OrganizationKbArticles
		{
			get { return GetRelatedEntities<Article>("organization_kb_articles", null); }
			set { SetRelatedEntities("organization_kb_articles", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'organization_KnowledgeBaseRecord'
        /// </summary>
		[RelationshipSchemaName("organization_KnowledgeBaseRecord")]
		public IEnumerable<KnowledgeBaseRecord> OrganizationKnowledgeBaseRecord
		{
			get { return GetRelatedEntities<KnowledgeBaseRecord>("organization_KnowledgeBaseRecord", null); }
			set { SetRelatedEntities("organization_KnowledgeBaseRecord", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'organization_leadtoopportunitysalesprocess'
        /// </summary>
		[RelationshipSchemaName("organization_leadtoopportunitysalesprocess")]
		public IEnumerable<LeadToOpportunitySalesProcess> OrganizationLeadtoopportunitysalesprocess
		{
			get { return GetRelatedEntities<LeadToOpportunitySalesProcess>("organization_leadtoopportunitysalesprocess", null); }
			set { SetRelatedEntities("organization_leadtoopportunitysalesprocess", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'organization_mailbox'
        /// </summary>
		[RelationshipSchemaName("organization_mailbox")]
		public IEnumerable<Mailbox> OrganizationMailbox
		{
			get { return GetRelatedEntities<Mailbox>("organization_mailbox", null); }
			set { SetRelatedEntities("organization_mailbox", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'Organization_MailboxTrackingFolder'
        /// </summary>
		[RelationshipSchemaName("Organization_MailboxTrackingFolder")]
		public IEnumerable<MailboxAutoTrackingFolder> OrganizationMailboxTrackingFolder
		{
			get { return GetRelatedEntities<MailboxAutoTrackingFolder>("Organization_MailboxTrackingFolder", null); }
			set { SetRelatedEntities("Organization_MailboxTrackingFolder", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'organization_marketingformdisplayattributes'
        /// </summary>
		[RelationshipSchemaName("organization_marketingformdisplayattributes")]
		public IEnumerable<MarketingFormDisplayAttributes> OrganizationMarketingformdisplayattributes
		{
			get { return GetRelatedEntities<MarketingFormDisplayAttributes>("organization_marketingformdisplayattributes", null); }
			set { SetRelatedEntities("organization_marketingformdisplayattributes", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'organization_metric'
        /// </summary>
		[RelationshipSchemaName("organization_metric")]
		public IEnumerable<GoalMetric> OrganizationMetric
		{
			get { return GetRelatedEntities<GoalMetric>("organization_metric", null); }
			set { SetRelatedEntities("organization_metric", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'organization_msdyn_databaseversion'
        /// </summary>
		[RelationshipSchemaName("organization_msdyn_databaseversion")]
		public IEnumerable<DatabaseVersion> OrganizationMsdynDatabaseversion
		{
			get { return GetRelatedEntities<DatabaseVersion>("organization_msdyn_databaseversion", null); }
			set { SetRelatedEntities("organization_msdyn_databaseversion", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'organization_msdyn_federatedarticleincident'
        /// </summary>
		[RelationshipSchemaName("organization_msdyn_federatedarticleincident")]
		public IEnumerable<KnowledgeFederatedArticleIncident> OrganizationMsdynFederatedarticleincident
		{
			get { return GetRelatedEntities<KnowledgeFederatedArticleIncident>("organization_msdyn_federatedarticleincident", null); }
			set { SetRelatedEntities("organization_msdyn_federatedarticleincident", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'organization_msdyn_helppage'
        /// </summary>
		[RelationshipSchemaName("organization_msdyn_helppage")]
		public IEnumerable<HelpPage> OrganizationMsdynHelppage
		{
			get { return GetRelatedEntities<HelpPage>("organization_msdyn_helppage", null); }
			set { SetRelatedEntities("organization_msdyn_helppage", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'organization_msdyn_postconfig'
        /// </summary>
		[RelationshipSchemaName("organization_msdyn_postconfig")]
		public IEnumerable<PostConfiguration> OrganizationMsdynPostconfig
		{
			get { return GetRelatedEntities<PostConfiguration>("organization_msdyn_postconfig", null); }
			set { SetRelatedEntities("organization_msdyn_postconfig", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'organization_msdyn_postruleconfig'
        /// </summary>
		[RelationshipSchemaName("organization_msdyn_postruleconfig")]
		public IEnumerable<PostRuleConfiguration> OrganizationMsdynPostruleconfig
		{
			get { return GetRelatedEntities<PostRuleConfiguration>("organization_msdyn_postruleconfig", null); }
			set { SetRelatedEntities("organization_msdyn_postruleconfig", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'organization_msdyn_sikeyvalueconfig'
        /// </summary>
		[RelationshipSchemaName("organization_msdyn_sikeyvalueconfig")]
		public IEnumerable<SIKeyValueConfig> OrganizationMsdynSikeyvalueconfig
		{
			get { return GetRelatedEntities<SIKeyValueConfig>("organization_msdyn_sikeyvalueconfig", null); }
			set { SetRelatedEntities("organization_msdyn_sikeyvalueconfig", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'organization_msdyn_tour'
        /// </summary>
		[RelationshipSchemaName("organization_msdyn_tour")]
		public IEnumerable<Tour> OrganizationMsdynTour
		{
			get { return GetRelatedEntities<Tour>("organization_msdyn_tour", null); }
			set { SetRelatedEntities("organization_msdyn_tour", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'organization_msdyn_upgraderun'
        /// </summary>
		[RelationshipSchemaName("organization_msdyn_upgraderun")]
		public IEnumerable<UpgradeRun> OrganizationMsdynUpgraderun
		{
			get { return GetRelatedEntities<UpgradeRun>("organization_msdyn_upgraderun", null); }
			set { SetRelatedEntities("organization_msdyn_upgraderun", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'organization_msdyn_upgradestep'
        /// </summary>
		[RelationshipSchemaName("organization_msdyn_upgradestep")]
		public IEnumerable<UpgradeStep> OrganizationMsdynUpgradestep
		{
			get { return GetRelatedEntities<UpgradeStep>("organization_msdyn_upgradestep", null); }
			set { SetRelatedEntities("organization_msdyn_upgradestep", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'organization_msdyn_upgradeversion'
        /// </summary>
		[RelationshipSchemaName("organization_msdyn_upgradeversion")]
		public IEnumerable<UpgradeVersion> OrganizationMsdynUpgradeversion
		{
			get { return GetRelatedEntities<UpgradeVersion>("organization_msdyn_upgradeversion", null); }
			set { SetRelatedEntities("organization_msdyn_upgradeversion", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'organization_msdyn_wallsavedquery'
        /// </summary>
		[RelationshipSchemaName("organization_msdyn_wallsavedquery")]
		public IEnumerable<WallView> OrganizationMsdynWallsavedquery
		{
			get { return GetRelatedEntities<WallView>("organization_msdyn_wallsavedquery", null); }
			set { SetRelatedEntities("organization_msdyn_wallsavedquery", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'organization_navigationsetting'
        /// </summary>
		[RelationshipSchemaName("organization_navigationsetting")]
		public IEnumerable<NavigationSetting> OrganizationNavigationsetting
		{
			get { return GetRelatedEntities<NavigationSetting>("organization_navigationsetting", null); }
			set { SetRelatedEntities("organization_navigationsetting", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'organization_newprocess'
        /// </summary>
		[RelationshipSchemaName("organization_newprocess")]
		public IEnumerable<NewProcess> OrganizationNewprocess
		{
			get { return GetRelatedEntities<NewProcess>("organization_newprocess", null); }
			set { SetRelatedEntities("organization_newprocess", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'organization_officegraphdocument'
        /// </summary>
		[RelationshipSchemaName("organization_officegraphdocument")]
		public IEnumerable<OfficeGraphDocument> OrganizationOfficegraphdocument
		{
			get { return GetRelatedEntities<OfficeGraphDocument>("organization_officegraphdocument", null); }
			set { SetRelatedEntities("organization_officegraphdocument", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'organization_opportunitysalesprocess'
        /// </summary>
		[RelationshipSchemaName("organization_opportunitysalesprocess")]
		public IEnumerable<OpportunitySalesProcess> OrganizationOpportunitysalesprocess
		{
			get { return GetRelatedEntities<OpportunitySalesProcess>("organization_opportunitysalesprocess", null); }
			set { SetRelatedEntities("organization_opportunitysalesprocess", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'organization_package'
        /// </summary>
		[RelationshipSchemaName("organization_package")]
		public IEnumerable<Package> OrganizationPackage
		{
			get { return GetRelatedEntities<Package>("organization_package", null); }
			set { SetRelatedEntities("organization_package", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'organization_phonetocaseprocess'
        /// </summary>
		[RelationshipSchemaName("organization_phonetocaseprocess")]
		public IEnumerable<PhoneToCaseProcess> OrganizationPhonetocaseprocess
		{
			get { return GetRelatedEntities<PhoneToCaseProcess>("organization_phonetocaseprocess", null); }
			set { SetRelatedEntities("organization_phonetocaseprocess", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'organization_pluginassembly'
        /// </summary>
		[RelationshipSchemaName("organization_pluginassembly")]
		public IEnumerable<PluginAssembly> OrganizationPluginassembly
		{
			get { return GetRelatedEntities<PluginAssembly>("organization_pluginassembly", null); }
			set { SetRelatedEntities("organization_pluginassembly", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'organization_plugintype'
        /// </summary>
		[RelationshipSchemaName("organization_plugintype")]
		public IEnumerable<PluginType> OrganizationPlugintype
		{
			get { return GetRelatedEntities<PluginType>("organization_plugintype", null); }
			set { SetRelatedEntities("organization_plugintype", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'organization_plugintypestatistic'
        /// </summary>
		[RelationshipSchemaName("organization_plugintypestatistic")]
		public IEnumerable<PluginTypeStatistic> OrganizationPlugintypestatistic
		{
			get { return GetRelatedEntities<PluginTypeStatistic>("organization_plugintypestatistic", null); }
			set { SetRelatedEntities("organization_plugintypestatistic", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'organization_position'
        /// </summary>
		[RelationshipSchemaName("organization_position")]
		public IEnumerable<Position> OrganizationPosition
		{
			get { return GetRelatedEntities<Position>("organization_position", null); }
			set { SetRelatedEntities("organization_position", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'organization_post'
        /// </summary>
		[RelationshipSchemaName("organization_post")]
		public IEnumerable<Post> OrganizationPost
		{
			get { return GetRelatedEntities<Post>("organization_post", null); }
			set { SetRelatedEntities("organization_post", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'organization_PostComment'
        /// </summary>
		[RelationshipSchemaName("organization_PostComment")]
		public IEnumerable<Comment> OrganizationPostComment
		{
			get { return GetRelatedEntities<Comment>("organization_PostComment", null); }
			set { SetRelatedEntities("organization_PostComment", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'organization_postlike'
        /// </summary>
		[RelationshipSchemaName("organization_postlike")]
		public IEnumerable<Like> OrganizationPostlike
		{
			get { return GetRelatedEntities<Like>("organization_postlike", null); }
			set { SetRelatedEntities("organization_postlike", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'organization_price_levels'
        /// </summary>
		[RelationshipSchemaName("organization_price_levels")]
		public IEnumerable<PriceList> OrganizationPriceLevels
		{
			get { return GetRelatedEntities<PriceList>("organization_price_levels", null); }
			set { SetRelatedEntities("organization_price_levels", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'organization_ProductAssociation'
        /// </summary>
		[RelationshipSchemaName("organization_ProductAssociation")]
		public IEnumerable<ProductAssociation> OrganizationProductAssociation
		{
			get { return GetRelatedEntities<ProductAssociation>("organization_ProductAssociation", null); }
			set { SetRelatedEntities("organization_ProductAssociation", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'organization_products'
        /// </summary>
		[RelationshipSchemaName("organization_products")]
		public IEnumerable<Product> OrganizationProducts
		{
			get { return GetRelatedEntities<Product>("organization_products", null); }
			set { SetRelatedEntities("organization_products", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'organization_ProductSubstitute'
        /// </summary>
		[RelationshipSchemaName("organization_ProductSubstitute")]
		public IEnumerable<ProductRelationship> OrganizationProductSubstitute
		{
			get { return GetRelatedEntities<ProductRelationship>("organization_ProductSubstitute", null); }
			set { SetRelatedEntities("organization_ProductSubstitute", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'organization_publisher'
        /// </summary>
		[RelationshipSchemaName("organization_publisher")]
		public IEnumerable<Publisher> OrganizationPublisher
		{
			get { return GetRelatedEntities<Publisher>("organization_publisher", null); }
			set { SetRelatedEntities("organization_publisher", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'organization_queueitems'
        /// </summary>
		[RelationshipSchemaName("organization_queueitems")]
		public IEnumerable<QueueItem> OrganizationQueueitems
		{
			get { return GetRelatedEntities<QueueItem>("organization_queueitems", null); }
			set { SetRelatedEntities("organization_queueitems", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'organization_queues'
        /// </summary>
		[RelationshipSchemaName("organization_queues")]
		public IEnumerable<Queue> OrganizationQueues
		{
			get { return GetRelatedEntities<Queue>("organization_queues", null); }
			set { SetRelatedEntities("organization_queues", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'organization_recommendeddocument'
        /// </summary>
		[RelationshipSchemaName("organization_recommendeddocument")]
		public IEnumerable<DocumentSuggestions> OrganizationRecommendeddocument
		{
			get { return GetRelatedEntities<DocumentSuggestions>("organization_recommendeddocument", null); }
			set { SetRelatedEntities("organization_recommendeddocument", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'organization_resource_groups'
        /// </summary>
		[RelationshipSchemaName("organization_resource_groups")]
		public IEnumerable<SchedulingGroup> OrganizationResourceGroups
		{
			get { return GetRelatedEntities<SchedulingGroup>("organization_resource_groups", null); }
			set { SetRelatedEntities("organization_resource_groups", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'organization_resource_specs'
        /// </summary>
		[RelationshipSchemaName("organization_resource_specs")]
		public IEnumerable<ResourceSpecification> OrganizationResourceSpecs
		{
			get { return GetRelatedEntities<ResourceSpecification>("organization_resource_specs", null); }
			set { SetRelatedEntities("organization_resource_specs", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'organization_resources'
        /// </summary>
		[RelationshipSchemaName("organization_resources")]
		public IEnumerable<Resource> OrganizationResources
		{
			get { return GetRelatedEntities<Resource>("organization_resources", null); }
			set { SetRelatedEntities("organization_resources", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'organization_roles'
        /// </summary>
		[RelationshipSchemaName("organization_roles")]
		public IEnumerable<SecurityRole> OrganizationRoles
		{
			get { return GetRelatedEntities<SecurityRole>("organization_roles", null); }
			set { SetRelatedEntities("organization_roles", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'organization_sales_literature'
        /// </summary>
		[RelationshipSchemaName("organization_sales_literature")]
		public IEnumerable<SalesLiterature> OrganizationSalesLiterature
		{
			get { return GetRelatedEntities<SalesLiterature>("organization_sales_literature", null); }
			set { SetRelatedEntities("organization_sales_literature", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'organization_saved_queries'
        /// </summary>
		[RelationshipSchemaName("organization_saved_queries")]
		public IEnumerable<View> OrganizationSavedQueries
		{
			get { return GetRelatedEntities<View>("organization_saved_queries", null); }
			set { SetRelatedEntities("organization_saved_queries", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'organization_saved_query_visualizations'
        /// </summary>
		[RelationshipSchemaName("organization_saved_query_visualizations")]
		public IEnumerable<SystemChart> OrganizationSavedQueryVisualizations
		{
			get { return GetRelatedEntities<SystemChart>("organization_saved_query_visualizations", null); }
			set { SetRelatedEntities("organization_saved_query_visualizations", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'organization_sdkmessage'
        /// </summary>
		[RelationshipSchemaName("organization_sdkmessage")]
		public IEnumerable<SdkMessage> OrganizationSdkmessage
		{
			get { return GetRelatedEntities<SdkMessage>("organization_sdkmessage", null); }
			set { SetRelatedEntities("organization_sdkmessage", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'organization_sdkmessagefilter'
        /// </summary>
		[RelationshipSchemaName("organization_sdkmessagefilter")]
		public IEnumerable<SdkMessageFilter> OrganizationSdkmessagefilter
		{
			get { return GetRelatedEntities<SdkMessageFilter>("organization_sdkmessagefilter", null); }
			set { SetRelatedEntities("organization_sdkmessagefilter", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'organization_sdkmessageprocessingstep'
        /// </summary>
		[RelationshipSchemaName("organization_sdkmessageprocessingstep")]
		public IEnumerable<SdkMessageProcessingStep> OrganizationSdkmessageprocessingstep
		{
			get { return GetRelatedEntities<SdkMessageProcessingStep>("organization_sdkmessageprocessingstep", null); }
			set { SetRelatedEntities("organization_sdkmessageprocessingstep", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'organization_sdkmessageprocessingstepimage'
        /// </summary>
		[RelationshipSchemaName("organization_sdkmessageprocessingstepimage")]
		public IEnumerable<SdkMessageProcessingStepImage> OrganizationSdkmessageprocessingstepimage
		{
			get { return GetRelatedEntities<SdkMessageProcessingStepImage>("organization_sdkmessageprocessingstepimage", null); }
			set { SetRelatedEntities("organization_sdkmessageprocessingstepimage", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'organization_sdkmessageprocessingstepsecureconfig'
        /// </summary>
		[RelationshipSchemaName("organization_sdkmessageprocessingstepsecureconfig")]
		public IEnumerable<SdkMessageProcessingStepSecureConfiguration> OrganizationSdkmessageprocessingstepsecureconfig
		{
			get { return GetRelatedEntities<SdkMessageProcessingStepSecureConfiguration>("organization_sdkmessageprocessingstepsecureconfig", null); }
			set { SetRelatedEntities("organization_sdkmessageprocessingstepsecureconfig", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'organization_serviceendpoint'
        /// </summary>
		[RelationshipSchemaName("organization_serviceendpoint")]
		public IEnumerable<ServiceEndpoint> OrganizationServiceendpoint
		{
			get { return GetRelatedEntities<ServiceEndpoint>("organization_serviceendpoint", null); }
			set { SetRelatedEntities("organization_serviceendpoint", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'organization_services'
        /// </summary>
		[RelationshipSchemaName("organization_services")]
		public IEnumerable<Service> OrganizationServices
		{
			get { return GetRelatedEntities<Service>("organization_services", null); }
			set { SetRelatedEntities("organization_services", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'organization_sitemap'
        /// </summary>
		[RelationshipSchemaName("organization_sitemap")]
		public IEnumerable<SiteMap> OrganizationSitemap
		{
			get { return GetRelatedEntities<SiteMap>("organization_sitemap", null); }
			set { SetRelatedEntities("organization_sitemap", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'organization_sites'
        /// </summary>
		[RelationshipSchemaName("organization_sites")]
		public IEnumerable<Site> OrganizationSites
		{
			get { return GetRelatedEntities<Site>("organization_sites", null); }
			set { SetRelatedEntities("organization_sites", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'organization_solution'
        /// </summary>
		[RelationshipSchemaName("organization_solution")]
		public IEnumerable<Solution> OrganizationSolution
		{
			get { return GetRelatedEntities<Solution>("organization_solution", null); }
			set { SetRelatedEntities("organization_solution", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'organization_solutioncomponentattributeconfiguration'
        /// </summary>
		[RelationshipSchemaName("organization_solutioncomponentattributeconfiguration")]
		public IEnumerable<SolutionComponentAttributeConfiguration> OrganizationSolutioncomponentattributeconfiguration
		{
			get { return GetRelatedEntities<SolutionComponentAttributeConfiguration>("organization_solutioncomponentattributeconfiguration", null); }
			set { SetRelatedEntities("organization_solutioncomponentattributeconfiguration", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'organization_solutioncomponentconfiguration'
        /// </summary>
		[RelationshipSchemaName("organization_solutioncomponentconfiguration")]
		public IEnumerable<SolutionComponentConfiguration> OrganizationSolutioncomponentconfiguration
		{
			get { return GetRelatedEntities<SolutionComponentConfiguration>("organization_solutioncomponentconfiguration", null); }
			set { SetRelatedEntities("organization_solutioncomponentconfiguration", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'organization_solutioncomponentrelationshipconfiguration'
        /// </summary>
		[RelationshipSchemaName("organization_solutioncomponentrelationshipconfiguration")]
		public IEnumerable<SolutionComponentRelationshipConfiguration> OrganizationSolutioncomponentrelationshipconfiguration
		{
			get { return GetRelatedEntities<SolutionComponentRelationshipConfiguration>("organization_solutioncomponentrelationshipconfiguration", null); }
			set { SetRelatedEntities("organization_solutioncomponentrelationshipconfiguration", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'organization_subjects'
        /// </summary>
		[RelationshipSchemaName("organization_subjects")]
		public IEnumerable<Subject> OrganizationSubjects
		{
			get { return GetRelatedEntities<Subject>("organization_subjects", null); }
			set { SetRelatedEntities("organization_subjects", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'Organization_SyncErrors'
        /// </summary>
		[RelationshipSchemaName("Organization_SyncErrors")]
		public IEnumerable<SyncError> OrganizationSyncErrors
		{
			get { return GetRelatedEntities<SyncError>("Organization_SyncErrors", null); }
			set { SetRelatedEntities("Organization_SyncErrors", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'organization_system_users'
        /// </summary>
		[RelationshipSchemaName("organization_system_users")]
		public IEnumerable<User> OrganizationSystemUsers
		{
			get { return GetRelatedEntities<User>("organization_system_users", null); }
			set { SetRelatedEntities("organization_system_users", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'organization_systemforms'
        /// </summary>
		[RelationshipSchemaName("organization_systemforms")]
		public IEnumerable<SystemForm> OrganizationSystemforms
		{
			get { return GetRelatedEntities<SystemForm>("organization_systemforms", null); }
			set { SetRelatedEntities("organization_systemforms", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'organization_teams'
        /// </summary>
		[RelationshipSchemaName("organization_teams")]
		public IEnumerable<Team> OrganizationTeams
		{
			get { return GetRelatedEntities<Team>("organization_teams", null); }
			set { SetRelatedEntities("organization_teams", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'organization_territories'
        /// </summary>
		[RelationshipSchemaName("organization_territories")]
		public IEnumerable<Territory> OrganizationTerritories
		{
			get { return GetRelatedEntities<Territory>("organization_territories", null); }
			set { SetRelatedEntities("organization_territories", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'organization_theme'
        /// </summary>
		[RelationshipSchemaName("organization_theme")]
		public IEnumerable<Theme> OrganizationTheme
		{
			get { return GetRelatedEntities<Theme>("organization_theme", null); }
			set { SetRelatedEntities("organization_theme", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'organization_tracelog'
        /// </summary>
		[RelationshipSchemaName("organization_tracelog")]
		public IEnumerable<Trace> OrganizationTracelog
		{
			get { return GetRelatedEntities<Trace>("organization_tracelog", null); }
			set { SetRelatedEntities("organization_tracelog", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'organization_transactioncurrencies'
        /// </summary>
		[RelationshipSchemaName("organization_transactioncurrencies")]
		public IEnumerable<Currency> OrganizationTransactioncurrencies
		{
			get { return GetRelatedEntities<Currency>("organization_transactioncurrencies", null); }
			set { SetRelatedEntities("organization_transactioncurrencies", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'organization_translationprocess'
        /// </summary>
		[RelationshipSchemaName("organization_translationprocess")]
		public IEnumerable<TranslationProcess> OrganizationTranslationprocess
		{
			get { return GetRelatedEntities<TranslationProcess>("organization_translationprocess", null); }
			set { SetRelatedEntities("organization_translationprocess", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'organization_uof_schedules'
        /// </summary>
		[RelationshipSchemaName("organization_uof_schedules")]
		public IEnumerable<UnitGroup> OrganizationUofSchedules
		{
			get { return GetRelatedEntities<UnitGroup>("organization_uof_schedules", null); }
			set { SetRelatedEntities("organization_uof_schedules", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'organization_UserMapping'
        /// </summary>
		[RelationshipSchemaName("organization_UserMapping")]
		public IEnumerable<UserMapping> OrganizationUserMapping
		{
			get { return GetRelatedEntities<UserMapping>("organization_UserMapping", null); }
			set { SetRelatedEntities("organization_UserMapping", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'organization_webwizard'
        /// </summary>
		[RelationshipSchemaName("organization_webwizard")]
		public IEnumerable<WebWizard> OrganizationWebwizard
		{
			get { return GetRelatedEntities<WebWizard>("organization_webwizard", null); }
			set { SetRelatedEntities("organization_webwizard", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'webresource_organization'
        /// </summary>
		[RelationshipSchemaName("webresource_organization")]
		public IEnumerable<WebResource> WebresourceOrganization
		{
			get { return GetRelatedEntities<WebResource>("webresource_organization", null); }
			set { SetRelatedEntities("webresource_organization", null, value); }
		}
		#endregion

		#region Actions
		#endregion

		#region OptionSetEnums
		public enum eDisplayCurrenciesUsing
		{	
		
			[Label("Currency symbol")]
			[Description(@"")]
			CurrencySymbol = 0, 
		
			[Label("Currency code")]
			[Description(@"")]
			CurrencyCode = 1, 
		}
		
		public enum eOrganizationCurrencyformatcode
		{	
		
			[Label("$123")]
			[Description(@"")]
			_123 = 0, 
		
			[Label("123$")]
			[Description(@"")]
			_1232 = 1, 
		
			[Label("$ 123")]
			[Description(@"")]
			_1233 = 2, 
		
			[Label("123 $")]
			[Description(@"")]
			_1234 = 3, 
		}
		
		public enum eOrganizationDateformatcode
		{	
		}
		
		public enum eDefaultRecurrenceEndRangeType
		{	
		
			[Label("No End Date")]
			[Description(@"")]
			NoEndDate = 1, 
		
			[Label("Number of Occurrences")]
			[Description(@"")]
			NumberOfOccurrences = 2, 
		
			[Label("End By Date")]
			[Description(@"")]
			EndByDate = 3, 
		}
		
		public enum eDiscountCalculationMethod
		{	
		
			[Label("Line item")]
			[Description(@"")]
			LineItem = 0, 
		
			[Label("Per unit")]
			[Description(@"")]
			PerUnit = 1, 
		}
		
		public enum eOrganizationEmailconnectionchannel
		{	
		
			[Label("Server-Side Synchronization")]
			[Description(@"")]
			ServerSideSynchronization = 0, 
		
			[Label("Microsoft Dynamics 365 Email Router")]
			[Description(@"")]
			MicrosoftDynamics365EmailRouter = 1, 
		}
		
		public enum eFiscalPeriodFormat
		{	
		
			[Label("Quarter {0}")]
			[Description(@"")]
			Quarter0 = 1, 
		
			[Label("Q{0}")]
			[Description(@"")]
			Q0 = 2, 
		
			[Label("P{0}")]
			[Description(@"")]
			P0 = 3, 
		
			[Label("Month {0}")]
			[Description(@"")]
			Month0 = 4, 
		
			[Label("M{0}")]
			[Description(@"")]
			M0 = 5, 
		
			[Label("Semester {0}")]
			[Description(@"")]
			Semester0 = 6, 
		
			[Label("Month Name")]
			[Description(@"")]
			MonthName = 7, 
		}
		
		public enum eFiscalYearFormatPrefix
		{	
		
			[Label("FY")]
			[Description(@"")]
			FY = 1, 
		
			[Label("")]
			[Description(@"")]
			Empty = 2, 
		}
		
		public enum eFiscalYearFormatSuffix
		{	
		
			[Label("FY")]
			[Description(@"")]
			FY = 1, 
		
			[Label("Fiscal Year")]
			[Description(@"")]
			FiscalYear = 2, 
		
			[Label("")]
			[Description(@"")]
			Empty = 3, 
		}
		
		public enum eFiscalYearFormat
		{	
		
			[Label("YYYY")]
			[Description(@"")]
			YYYY = 1, 
		
			[Label("YY")]
			[Description(@"")]
			YY = 2, 
		
			[Label("GGYY")]
			[Description(@"")]
			GGYY = 3, 
		}
		
		public enum eOrganizationFullnameconventioncode
		{	
		
			[Label("Last Name, First Name")]
			[Description(@"")]
			LastNameFirstName = 0, 
		
			[Label("First Name")]
			[Description(@"")]
			FirstName = 1, 
		
			[Label("Last Name, First Name, Middle Initial")]
			[Description(@"")]
			LastNameFirstNameMiddleInitial = 2, 
		
			[Label("First Name, Middle Initial, Last Name")]
			[Description(@"")]
			FirstNameMiddleInitialLastName = 3, 
		
			[Label("Last Name, First Name, Middle Name")]
			[Description(@"")]
			LastNameFirstNameMiddleName = 4, 
		
			[Label("First Name, Middle Name, Last Name")]
			[Description(@"")]
			FirstNameMiddleNameLastName = 5, 
		
			[Label("Last Name, space, First Name")]
			[Description(@"")]
			LastNameSpaceFirstName = 6, 
		
			[Label("Last Name, no space, First Name")]
			[Description(@"")]
			LastNameNoSpaceFirstName = 7, 
		}
		
		public enum eOrganizationIsvintegrationcode
		{	
		
			[Label("None")]
			[Description(@"")]
			None = 0, 
		
			[Label("Web")]
			[Description(@"")]
			Web = 1, 
		
			[Label("Outlook Workstation Client")]
			[Description(@"")]
			OutlookWorkstationClient = 2, 
		
			[Label("Web; Outlook Workstation Client")]
			[Description(@"")]
			WebOutlookWorkstationClient = 3, 
		
			[Label("Outlook Laptop Client")]
			[Description(@"")]
			OutlookLaptopClient = 4, 
		
			[Label("Web; Outlook Laptop Client")]
			[Description(@"")]
			WebOutlookLaptopClient = 5, 
		
			[Label("Outlook")]
			[Description(@"")]
			Outlook = 6, 
		
			[Label("All")]
			[Description(@"")]
			All = 7, 
		}
		
		public enum eOrganizationNegativeformatcode
		{	
		
			[Label("Brackets")]
			[Description(@"")]
			Brackets = 0, 
		
			[Label("Dash")]
			[Description(@"")]
			Dash = 1, 
		
			[Label("Dash plus Space")]
			[Description(@"")]
			DashPlusSpace = 2, 
		
			[Label("Trailing Dash")]
			[Description(@"")]
			TrailingDash = 3, 
		
			[Label("Space plus Trailing Dash")]
			[Description(@"")]
			SpacePlusTrailingDash = 4, 
		}
		
		public enum eOrganizationState
		{	
		
			[Label("Creating")]
			[Description(@"")]
			Creating = 0, 
		
			[Label("Upgrading")]
			[Description(@"")]
			Upgrading = 1, 
		
			[Label("Updating")]
			[Description(@"")]
			Updating = 2, 
		
			[Label("Active")]
			[Description(@"")]
			Active = 3, 
		}
		
		public enum eOrganizationPlugintracelogsetting
		{	
		
			[Label("Off")]
			[Description(@"")]
			Off = 0, 
		
			[Label("Exception")]
			[Description(@"")]
			Exception = 1, 
		
			[Label("All")]
			[Description(@"")]
			All = 2, 
		}
		
		public enum eReportScriptErrors
		{	
		
			[Label("No preference for sending an error report to Microsoft about Microsoft Dynamics 365")]
			[Description(@"")]
			NoPreferenceForSendingAnErrorReportToMicrosoftAboutMicrosoftDynamics365 = 0, 
		
			[Label("Ask me for permission to send an error report to Microsoft")]
			[Description(@"")]
			AskMeForPermissionToSendAnErrorReportToMicrosoft = 1, 
		
			[Label("Automatically send an error report to Microsoft without asking me for permission")]
			[Description(@"")]
			AutomaticallySendAnErrorReportToMicrosoftWithoutAskingMeForPermission = 2, 
		
			[Label("Never send an error report to Microsoft about Microsoft Dynamics 365")]
			[Description(@"")]
			NeverSendAnErrorReportToMicrosoftAboutMicrosoftDynamics365 = 3, 
		}
		
		public enum eSchedulingEngineForAppointmentsAndServiceActivities
		{	
		
			[Label("Legacy Scheduling Engine")]
			[Description(@"")]
			LegacySchedulingEngine = 0, 
		}
		
		public enum eOrganizationSharepointdeploymenttype
		{	
		
			[Label("Online")]
			[Description(@"")]
			Online = 0, 
		
			[Label("On-Premises")]
			[Description(@"")]
			OnPremises = 1, 
		}
		
		public enum eOrganizationSyncoptinselectionstatus
		{	
		
			[Label("Processing")]
			[Description(@"")]
			Processing = 1, 
		
			[Label("Passed")]
			[Description(@"")]
			Passed = 2, 
		
			[Label("Failed")]
			[Description(@"")]
			Failed = 3, 
		}
		
		public enum eOrganizationTimeformatcode
		{	
		}
		
		public enum eOrganizationWeekstartdaycode
		{	
		}
		
		public enum eOrganizationYammerpostmethod
		{	
		
			[Label("Public")]
			[Description(@"")]
			Public = 0, 
		
			[Label("Private")]
			[Description(@"")]
			Private = 1, 
		}
		
		#endregion	

		#region Properties
		public static class Properties 
		{
			/// <summary>aciwebendpointurl</summary>
			public const string ACITenantURL = "aciwebendpointurl";

			/// <summary>acknowledgementtemplateid</summary>
			public const string AcknowledgementTemplate = "acknowledgementtemplateid";

			/// <summary>acknowledgementtemplateidname</summary>
			public const string Acknowledgementtemplateidname = "acknowledgementtemplateidname";

			/// <summary>allowaddressbooksyncs</summary>
			public const string AllowAddressBookSynchronization = "allowaddressbooksyncs";

			/// <summary>allowautoresponsecreation</summary>
			public const string AllowAutomaticResponseCreation = "allowautoresponsecreation";

			/// <summary>allowautounsubscribe</summary>
			public const string AllowAutomaticUnsubscribe = "allowautounsubscribe";

			/// <summary>allowautounsubscribeacknowledgement</summary>
			public const string AllowAutomaticUnsubscribeAcknowledgement = "allowautounsubscribeacknowledgement";

			/// <summary>allowclientmessagebarad</summary>
			public const string AllowOutlookClientMessageBarAdvertisement = "allowclientmessagebarad";

			/// <summary>allowentityonlyaudit</summary>
			public const string AllowEntityLevelAuditing = "allowentityonlyaudit";

			/// <summary>allowlegacyclientexperience</summary>
			public const string EnableAccessToLegacyWebClientUI = "allowlegacyclientexperience";

			/// <summary>allowlegacydialogsembedding</summary>
			public const string EnableEmbeddingOfCertainLegacyDialogsInUnifiedInterfaceBrowserClient = "allowlegacydialogsembedding";

			/// <summary>allowmarketingemailexecution</summary>
			public const string AllowMarketingEmailExecution = "allowmarketingemailexecution";

			/// <summary>allowofflinescheduledsyncs</summary>
			public const string AllowOfflineScheduledSynchronization = "allowofflinescheduledsyncs";

			/// <summary>allowoutlookscheduledsyncs</summary>
			public const string AllowScheduledSynchronization = "allowoutlookscheduledsyncs";

			/// <summary>allowunresolvedpartiesonemailsend</summary>
			public const string AllowUnresolvedAddressEmailSend = "allowunresolvedpartiesonemailsend";

			/// <summary>allowuserformmodepreference</summary>
			public const string AllowUserFormModePreference = "allowuserformmodepreference";

			/// <summary>allowusersseeappdownloadmessage</summary>
			public const string AllowTheShowingTabletApplicationNotificationBarsInABrowser = "allowusersseeappdownloadmessage";

			/// <summary>allowwebexcelexport</summary>
			public const string AllowExportToExcel = "allowwebexcelexport";

			/// <summary>amdesignator</summary>
			public const string AMDesignator = "amdesignator";

			/// <summary>appdesignerexperienceenabled</summary>
			public const string EnableAppDesignerExperienceForThisOrganization = "appdesignerexperienceenabled";

			/// <summary>appointmentricheditorexperience</summary>
			public const string EnableRichEditingExperienceForAppointment = "appointmentricheditorexperience";

			/// <summary>auditretentionperiod</summary>
			public const string AuditRetentionPeriodSettings = "auditretentionperiod";

			/// <summary>auditretentionperiodv2</summary>
			public const string AuditRetentionPeriodSettings2 = "auditretentionperiodv2";

			/// <summary>autoapplydefaultoncasecreate</summary>
			public const string AutoApplyDefaultEntitlementOnCaseCreate = "autoapplydefaultoncasecreate";

			/// <summary>autoapplydefaultoncaseupdate</summary>
			public const string AutoApplyDefaultEntitlementOnCaseUpdate = "autoapplydefaultoncaseupdate";

			/// <summary>autoapplysla</summary>
			public const string IsAutoapplySLAAfterManuallyOverriding = "autoapplysla";

			/// <summary>azureschedulerjobcollectionname</summary>
			public const string ForInternalUseOnly = "azureschedulerjobcollectionname";

			/// <summary>basecurrencyid</summary>
			public const string Currency = "basecurrencyid";

			/// <summary>basecurrencyidname</summary>
			public const string Basecurrencyidname = "basecurrencyidname";

			/// <summary>basecurrencyprecision</summary>
			public const string BaseCurrencyPrecision = "basecurrencyprecision";

			/// <summary>basecurrencysymbol</summary>
			public const string BaseCurrencySymbol = "basecurrencysymbol";

			/// <summary>baseisocurrencycode</summary>
			public const string BaseISOCurrencyCode = "baseisocurrencycode";

			/// <summary>bingmapsapikey</summary>
			public const string BingMapsAPIKey = "bingmapsapikey";

			/// <summary>blockedattachments</summary>
			public const string BlockAttachments = "blockedattachments";

			/// <summary>bounddashboarddefaultcardexpanded</summary>
			public const string DisplayCardsInExpandedStateForInteractiveDashboard = "bounddashboarddefaultcardexpanded";

			/// <summary>bulkoperationprefix</summary>
			public const string BulkOperationPrefix = "bulkoperationprefix";

			/// <summary>businesscardoptions</summary>
			public const string EnableNewBusinessCardOptions = "businesscardoptions";

			/// <summary>businessclosurecalendarid</summary>
			public const string BusinessClosureCalendarId = "businessclosurecalendarid";

			/// <summary>calendartype</summary>
			public const string CalendarType = "calendartype";

			/// <summary>campaignprefix</summary>
			public const string CampaignPrefix = "campaignprefix";

			/// <summary>cascadestatusupdate</summary>
			public const string CascadeStatusUpdate = "cascadestatusupdate";

			/// <summary>caseprefix</summary>
			public const string CasePrefix = "caseprefix";

			/// <summary>categoryprefix</summary>
			public const string CategoryPrefix = "categoryprefix";

			/// <summary>clientfeatureset</summary>
			public const string ClientFeatureSet = "clientfeatureset";

			/// <summary>contentsecuritypolicyconfiguration</summary>
			public const string ContentSecurityPolicyConfiguration = "contentsecuritypolicyconfiguration";

			/// <summary>contractprefix</summary>
			public const string ContractPrefix = "contractprefix";

			/// <summary>cortanaproactiveexperienceenabled</summary>
			public const string EnableCortanaProactiveExperienceFlowProcessesForThisOrganization = "cortanaproactiveexperienceenabled";

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

			/// <summary>createproductswithoutparentinactivestate</summary>
			public const string EnableActiveInitialProductState = "createproductswithoutparentinactivestate";

			/// <summary>currencydecimalprecision</summary>
			public const string CurrencyDecimalPrecision = "currencydecimalprecision";

			/// <summary>currencydisplayoption</summary>
			public const string DisplayCurrenciesUsing = "currencydisplayoption";

			/// <summary>currencyformatcode</summary>
			public const string CurrencyFormatCode = "currencyformatcode";

			/// <summary>currencysymbol</summary>
			public const string CurrencySymbol = "currencysymbol";

			/// <summary>currentbulkoperationnumber</summary>
			public const string CurrentBulkOperationNumber = "currentbulkoperationnumber";

			/// <summary>currentcampaignnumber</summary>
			public const string CurrentCampaignNumber = "currentcampaignnumber";

			/// <summary>currentcasenumber</summary>
			public const string CurrentCaseNumber = "currentcasenumber";

			/// <summary>currentcategorynumber</summary>
			public const string CurrentCategoryNumber = "currentcategorynumber";

			/// <summary>currentcontractnumber</summary>
			public const string CurrentContractNumber = "currentcontractnumber";

			/// <summary>currentimportsequencenumber</summary>
			public const string CurrentImportSequenceNumber = "currentimportsequencenumber";

			/// <summary>currentinvoicenumber</summary>
			public const string CurrentInvoiceNumber = "currentinvoicenumber";

			/// <summary>currentkanumber</summary>
			public const string CurrentKnowledgeArticleNumber = "currentkanumber";

			/// <summary>currentkbnumber</summary>
			public const string CurrentArticleNumber = "currentkbnumber";

			/// <summary>currentordernumber</summary>
			public const string CurrentOrderNumber = "currentordernumber";

			/// <summary>currentparsedtablenumber</summary>
			public const string CurrentParsedTableNumber = "currentparsedtablenumber";

			/// <summary>currentquotenumber</summary>
			public const string CurrentQuoteNumber = "currentquotenumber";

			/// <summary>dateformatcode</summary>
			public const string DateFormatCode = "dateformatcode";

			/// <summary>dateformatstring</summary>
			public const string DateFormatString = "dateformatstring";

			/// <summary>dateseparator</summary>
			public const string DateSeparator = "dateseparator";

			/// <summary>dayssincerecordlastmodifiedmaxvalue</summary>
			public const string MaxValueOfDaysSinceRecordLastModified = "dayssincerecordlastmodifiedmaxvalue";

			/// <summary>decimalsymbol</summary>
			public const string DecimalSymbol = "decimalsymbol";

			/// <summary>defaultcountrycode</summary>
			public const string DefaultCountryCode = "defaultcountrycode";

			/// <summary>defaultcrmcustomname</summary>
			public const string NameOfTheDefaultApp = "defaultcrmcustomname";

			/// <summary>defaultemailserverprofileid</summary>
			public const string EmailServerProfile = "defaultemailserverprofileid";

			/// <summary>defaultemailserverprofileidname</summary>
			public const string Defaultemailserverprofileidname = "defaultemailserverprofileidname";

			/// <summary>defaultemailsettings</summary>
			public const string DefaultEmailSettings = "defaultemailsettings";

			/// <summary>defaultmobileofflineprofileid</summary>
			public const string DefaultMobileOfflineProfile = "defaultmobileofflineprofileid";

			/// <summary>defaultmobileofflineprofileidname</summary>
			public const string Defaultmobileofflineprofileidname = "defaultmobileofflineprofileidname";

			/// <summary>defaultrecurrenceendrangetype</summary>
			public const string DefaultRecurrenceEndRangeType = "defaultrecurrenceendrangetype";

			/// <summary>defaultthemedata</summary>
			public const string DefaultThemeData = "defaultthemedata";

			/// <summary>delegatedadminuserid</summary>
			public const string DelegatedAdminId = "delegatedadminuserid";

			/// <summary>disabledreason</summary>
			public const string DisabledReason = "disabledreason";

			/// <summary>disablesocialcare</summary>
			public const string IsSocialCareDisabled = "disablesocialcare";

			/// <summary>discountcalculationmethod</summary>
			public const string DiscountCalculationMethod = "discountcalculationmethod";

			/// <summary>displaynavigationtour</summary>
			public const string DisplayNavigationTour = "displaynavigationtour";

			/// <summary>emailconnectionchannel</summary>
			public const string EmailConnectionChannel = "emailconnectionchannel";

			/// <summary>emailcorrelationenabled</summary>
			public const string UseEmailCorrelation = "emailcorrelationenabled";

			/// <summary>emailsendpollingperiod</summary>
			public const string EmailSendPollingFrequency = "emailsendpollingperiod";

			/// <summary>enablebingmapsintegration</summary>
			public const string EnableIntegrationWithBingMaps = "enablebingmapsintegration";

			/// <summary>enableimmersiveskypeintegration</summary>
			public const string EnableIntegrationWithImmersiveSkype = "enableimmersiveskypeintegration";

			/// <summary>enablelivepersonacarduci</summary>
			public const string IndicatesWhetherTheUserHasEnabledOrDisabledLivePersonaCardFeatureInUCI = "enablelivepersonacarduci";

			/// <summary>enablelivepersoncardintegrationinoffice</summary>
			public const string IndicatesWhetherTheUserHasEnabledOrDisabledLivePersonCardIntegrationInOffice = "enablelivepersoncardintegrationinoffice";

			/// <summary>enablelpauthoring</summary>
			public const string EnableLearningPathAuthoring = "enablelpauthoring";

			/// <summary>enablemicrosoftflowintegration</summary>
			public const string EnableIntegrationWithMicrosoftFlow = "enablemicrosoftflowintegration";

			/// <summary>enablepricingoncreate</summary>
			public const string EnablePricingOnCreate = "enablepricingoncreate";

			/// <summary>enablesmartmatching</summary>
			public const string EnableSmartMatching = "enablesmartmatching";

			/// <summary>enableunifiedinterfaceshellrefresh</summary>
			public const string EnableSiteMapAndCommandingUpdate = "enableunifiedinterfaceshellrefresh";

			/// <summary>enforcereadonlyplugins</summary>
			public const string OrganizationSettingToEnforceReadOnlyPlugins = "enforcereadonlyplugins";

			/// <summary>entityimage_timestamp</summary>
			public const string EntityimageTimestamp = "entityimage_timestamp";

			/// <summary>entityimage_url</summary>
			public const string EntityimageUrl = "entityimage_url";

			/// <summary>entityimageid</summary>
			public const string EntityImageId = "entityimageid";

			/// <summary>expirechangetrackingindays</summary>
			public const string DaysToExpireChangeTrackingDeletedRecords = "expirechangetrackingindays";

			/// <summary>expiresubscriptionsindays</summary>
			public const string DaysToExpireSubscriptions = "expiresubscriptionsindays";

			/// <summary>externalbaseurl</summary>
			public const string ExternalBaseURL = "externalbaseurl";

			/// <summary>externalpartycorrelationkeys</summary>
			public const string ExternalPartyEnabledEntitiesCorrelationKeys = "externalpartycorrelationkeys";

			/// <summary>externalpartyentitysettings</summary>
			public const string ExternalPartyEnabledEntitiesSettingsForInternalUseOnly = "externalpartyentitysettings";

			/// <summary>featureset</summary>
			public const string FeatureSet = "featureset";

			/// <summary>fiscalcalendarstart</summary>
			public const string FiscalCalendarStart = "fiscalcalendarstart";

			/// <summary>fiscalperiodformat</summary>
			public const string FiscalPeriodFormat = "fiscalperiodformat";

			/// <summary>fiscalperiodformatperiod</summary>
			public const string FormatForFiscalPeriod = "fiscalperiodformatperiod";

			/// <summary>fiscalperiodtype</summary>
			public const string FiscalPeriodType = "fiscalperiodtype";

			/// <summary>fiscalsettingsupdated</summary>
			public const string IsFiscalSettingsUpdated = "fiscalsettingsupdated";

			/// <summary>fiscalyeardisplaycode</summary>
			public const string FiscalYearDisplay = "fiscalyeardisplaycode";

			/// <summary>fiscalyearformat</summary>
			public const string FiscalYearFormat = "fiscalyearformat";

			/// <summary>fiscalyearformatprefix</summary>
			public const string PrefixForFiscalYear = "fiscalyearformatprefix";

			/// <summary>fiscalyearformatsuffix</summary>
			public const string SuffixForFiscalYear = "fiscalyearformatsuffix";

			/// <summary>fiscalyearformatyear</summary>
			public const string FiscalYearFormatYear = "fiscalyearformatyear";

			/// <summary>fiscalyearperiodconnect</summary>
			public const string FiscalYearPeriodConnector = "fiscalyearperiodconnect";

			/// <summary>fullnameconventioncode</summary>
			public const string FullNameDisplayOrder = "fullnameconventioncode";

			/// <summary>futureexpansionwindow</summary>
			public const string FutureExpansionWindow = "futureexpansionwindow";

			/// <summary>generatealertsforerrors</summary>
			public const string GenerateAlertsForErrors = "generatealertsforerrors";

			/// <summary>generatealertsforinformation</summary>
			public const string GenerateAlertsForInformation = "generatealertsforinformation";

			/// <summary>generatealertsforwarnings</summary>
			public const string GenerateAlertsForWarnings = "generatealertsforwarnings";

			/// <summary>getstartedpanecontentenabled</summary>
			public const string IsGetStartedPaneContentEnabled = "getstartedpanecontentenabled";

			/// <summary>globalappendurlparametersenabled</summary>
			public const string IsAppendUrlParametersEnabled = "globalappendurlparametersenabled";

			/// <summary>globalhelpurl</summary>
			public const string GlobalHelpURL = "globalhelpurl";

			/// <summary>globalhelpurlenabled</summary>
			public const string IsCustomizableGlobalHelpEnabled = "globalhelpurlenabled";

			/// <summary>goalrollupexpirytime</summary>
			public const string RollupExpirationTimeForGoal = "goalrollupexpirytime";

			/// <summary>goalrollupfrequency</summary>
			public const string AutomaticRollupFrequencyForGoal = "goalrollupfrequency";

			/// <summary>grantaccesstonetworkservice</summary>
			public const string GrantAccessToNetworkService = "grantaccesstonetworkservice";

			/// <summary>hashdeltasubjectcount</summary>
			public const string HashDeltaSubjectCount = "hashdeltasubjectcount";

			/// <summary>hashfilterkeywords</summary>
			public const string HashFilterKeywords = "hashfilterkeywords";

			/// <summary>hashmaxcount</summary>
			public const string HashMaxCount = "hashmaxcount";

			/// <summary>hashminaddresscount</summary>
			public const string HashMinAddressCount = "hashminaddresscount";

			/// <summary>highcontrastthemedata</summary>
			public const string HighContrastThemeData = "highcontrastthemedata";

			/// <summary>ignoreinternalemail</summary>
			public const string IgnoreInternalEmail = "ignoreinternalemail";

			/// <summary>inactivitytimeoutenabled</summary>
			public const string InactivityTimeoutEnabled = "inactivitytimeoutenabled";

			/// <summary>inactivitytimeoutinmins</summary>
			public const string InactivityTimeoutInMinutes = "inactivitytimeoutinmins";

			/// <summary>inactivitytimeoutreminderinmins</summary>
			public const string InactivityTimeoutReminderInMinutes = "inactivitytimeoutreminderinmins";

			/// <summary>incomingemailexchangeemailretrievalbatchsize</summary>
			public const string ExchangeEmailRetrievalBatchSize = "incomingemailexchangeemailretrievalbatchsize";

			/// <summary>initialversion</summary>
			public const string InitialVersion = "initialversion";

			/// <summary>integrationuserid</summary>
			public const string IntegrationUserId = "integrationuserid";

			/// <summary>invoiceprefix</summary>
			public const string InvoicePrefix = "invoiceprefix";

			/// <summary>isactioncardenabled</summary>
			public const string EnableActionCardForThisOrganization = "isactioncardenabled";

			/// <summary>isactionsupportfeatureenabled</summary>
			public const string ActionSupportFeatureEnabled = "isactionsupportfeatureenabled";

			/// <summary>isactivityanalysisenabled</summary>
			public const string EnableRelationshipAnalyticsForThisOrganization = "isactivityanalysisenabled";

			/// <summary>isallmoneydecimal</summary>
			public const string SetIfAllMoneyAttributesAreConvertedToDecimal = "isallmoneydecimal";

			/// <summary>isappmode</summary>
			public const string IsApplicationModeEnabled = "isappmode";

			/// <summary>isappointmentattachmentsyncenabled</summary>
			public const string IsAttachmentSyncEnabled = "isappointmentattachmentsyncenabled";

			/// <summary>isassignedtaskssyncenabled</summary>
			public const string IsAssignedTasksSyncEnabled = "isassignedtaskssyncenabled";

			/// <summary>isauditenabled</summary>
			public const string IsAuditingEnabled = "isauditenabled";

			/// <summary>isautodatacaptureenabled</summary>
			public const string EnableAutoCaptureForThisOrganization = "isautodatacaptureenabled";

			/// <summary>isautodatacapturev2enabled</summary>
			public const string EnableAutoCaptureV2ForThisOrganization = "isautodatacapturev2enabled";

			/// <summary>isautosaveenabled</summary>
			public const string AutoSaveEnabled = "isautosaveenabled";

			/// <summary>isbpfentitycustomizationfeatureenabled</summary>
			public const string BPFEntityCustomizationFeatureEnabled = "isbpfentitycustomizationfeatureenabled";

			/// <summary>isconflictdetectionenabledformobileclient</summary>
			public const string IsConflictDetectionForMobileClientEnabled = "isconflictdetectionenabledformobileclient";

			/// <summary>iscontactmailingaddresssyncenabled</summary>
			public const string IsMailingAddressSyncEnabled = "iscontactmailingaddresssyncenabled";

			/// <summary>iscontentsecuritypolicyenabled</summary>
			public const string EnableContentSecurityPolicyForThisOrganization = "iscontentsecuritypolicyenabled";

			/// <summary>iscontextualemailenabled</summary>
			public const string IndicatesWhetherContextualEmailExperienceIsEnabledOnThisOrganization = "iscontextualemailenabled";

			/// <summary>iscontextualhelpenabled</summary>
			public const string EnablesContextualHelpInUCI = "iscontextualhelpenabled";

			/// <summary>iscustomcontrolsincanvasappsenabled</summary>
			public const string EnableCustomControlsInCanvasPowerAppsFeatureForThisOrganization = "iscustomcontrolsincanvasappsenabled";

			/// <summary>isdefaultcountrycodecheckenabled</summary>
			public const string EnableOrDisableCountryCodeSelection = "isdefaultcountrycodecheckenabled";

			/// <summary>isdelegateaccessenabled</summary>
			public const string IsDelegationAccessEnabled = "isdelegateaccessenabled";

			/// <summary>isdelveactionhubintegrationenabled</summary>
			public const string EnableActionHubForThisOrganization = "isdelveactionhubintegrationenabled";

			/// <summary>isdisabled</summary>
			public const string IsOrganizationDisabled = "isdisabled";

			/// <summary>isduplicatedetectionenabled</summary>
			public const string IsDuplicateDetectionEnabled = "isduplicatedetectionenabled";

			/// <summary>isduplicatedetectionenabledforimport</summary>
			public const string IsDuplicateDetectionEnabledForImport = "isduplicatedetectionenabledforimport";

			/// <summary>isduplicatedetectionenabledforofflinesync</summary>
			public const string IsDuplicateDetectionEnabledForOfflineSynchronization = "isduplicatedetectionenabledforofflinesync";

			/// <summary>isduplicatedetectionenabledforonlinecreateupdate</summary>
			public const string IsDuplicateDetectionEnabledForOnlineCreateUpdate = "isduplicatedetectionenabledforonlinecreateupdate";

			/// <summary>isemailmonitoringallowed</summary>
			public const string AllowTrackingRecipientActivityOnSentEmails = "isemailmonitoringallowed";

			/// <summary>isemailserverprofilecontentfilteringenabled</summary>
			public const string IsEmailServerProfileContentFilteringEnabled = "isemailserverprofilecontentfilteringenabled";

			/// <summary>isenabledforallroles</summary>
			public const string OptionSetValuesForIsenabledforallroles = "isenabledforallroles";

			/// <summary>isexternalfilestorageenabled</summary>
			public const string EnableExternalFileStorage = "isexternalfilestorageenabled";

			/// <summary>isexternalsearchindexenabled</summary>
			public const string EnableExternalSearchDataSyncing = "isexternalsearchindexenabled";

			/// <summary>isfiscalperiodmonthbased</summary>
			public const string IsFiscalPeriodMonthly = "isfiscalperiodmonthbased";

			/// <summary>isfolderautocreatedonsp</summary>
			public const string AutomaticallyCreateFolders = "isfolderautocreatedonsp";

			/// <summary>isfolderbasedtrackingenabled</summary>
			public const string IsFolderBasedTrackingEnabled = "isfolderbasedtrackingenabled";

			/// <summary>isfulltextsearchenabled</summary>
			public const string EnableFulltextSearchForQuickFind = "isfulltextsearchenabled";

			/// <summary>isgeospatialazuremapsintegrationenabled</summary>
			public const string EnableGeospatialAzureMapsIntegration = "isgeospatialazuremapsintegrationenabled";

			/// <summary>ishierarchicalsecuritymodelenabled</summary>
			public const string EnableHierarchicalSecurityModel = "ishierarchicalsecuritymodelenabled";

			/// <summary>isluisenabledford365bot</summary>
			public const string LUISConsentForDynamics365Bot = "isluisenabledford365bot";

			/// <summary>ismailboxforcedunlockingenabled</summary>
			public const string IsMailboxForcedUnlockingEnabled = "ismailboxforcedunlockingenabled";

			/// <summary>ismailboxinactivebackoffenabled</summary>
			public const string IsMailboxKeepAliveEnabled = "ismailboxinactivebackoffenabled";

			/// <summary>ismanualsalesforecastingenabled</summary>
			public const string EnableManualSalesForecastingFeatureForThisOrganization = "ismanualsalesforecastingenabled";

			/// <summary>ismobileclientondemandsyncenabled</summary>
			public const string IsMobileClientOnDemandSyncEnabled = "ismobileclientondemandsyncenabled";

			/// <summary>ismobileofflineenabled</summary>
			public const string EnableMobileOfflineForThisOrganization = "ismobileofflineenabled";

			/// <summary>ismodeldrivenappsinmsteamsenabled</summary>
			public const string EnableEmbeddingModelAppsInMicrosoftTeams = "ismodeldrivenappsinmsteamsenabled";

			/// <summary>ismsteamscollaborationenabled</summary>
			public const string EnableMicrosoftTeamsCollaborationForThisOrganization = "ismsteamscollaborationenabled";

			/// <summary>ismsteamsenabled</summary>
			public const string EnableMicrosoftTeamsIntegration = "ismsteamsenabled";

			/// <summary>ismsteamssettingchangedbyuser</summary>
			public const string MicrosoftTeamsIntegrationChangedByUser = "ismsteamssettingchangedbyuser";

			/// <summary>ismsteamsusersyncenabled</summary>
			public const string EnableMicrosoftTeamsUserSyncForThisOrganization = "ismsteamsusersyncenabled";

			/// <summary>isnewaddproductexperienceenabled</summary>
			public const string IndicatesWhetherNewAddProductExperienceIsEnabledInOpportunityForm = "isnewaddproductexperienceenabled";

			/// <summary>isnotesanalysisenabled</summary>
			public const string EnableNotesAnalysisForThisOrganization = "isnotesanalysisenabled";

			/// <summary>isofficegraphenabled</summary>
			public const string EnableOfficeGraphForThisOrganization = "isofficegraphenabled";

			/// <summary>isonedriveenabled</summary>
			public const string EnableOneDriveForThisOrganization = "isonedriveenabled";

			/// <summary>ispaienabled</summary>
			public const string EnablePAIFeatureForThisOrganization = "ispaienabled";

			/// <summary>ispdfgenerationenabled</summary>
			public const string EnablePDFGenerationFeatureForThisOrganization = "ispdfgenerationenabled";

			/// <summary>isplaybookenabled</summary>
			public const string EnablePlaybookFeatureForThisOrganization = "isplaybookenabled";

			/// <summary>ispresenceenabled</summary>
			public const string PresenceEnabled = "ispresenceenabled";

			/// <summary>ispreviewenabledforactioncard</summary>
			public const string EnablePreviewActionCardFeatureForThisOrganization = "ispreviewenabledforactioncard";

			/// <summary>ispreviewforautocaptureenabled</summary>
			public const string EnableAutoCaptureForThisOrganizationAtPreviewSettings = "ispreviewforautocaptureenabled";

			/// <summary>ispreviewforemailmonitoringallowed</summary>
			public const string AllowsPreviewForEmailMonitoring = "ispreviewforemailmonitoringallowed";

			/// <summary>ispricelistmandatory</summary>
			public const string IndicatesWhetherPriceListIsMandatoryForAddingExistingProductsToSalesEntities = "ispricelistmandatory";

			/// <summary>isquickcreateenabledforopportunityclose</summary>
			public const string EnableQuickCreateFormForOpportunityCloseFeatureForThisOrganization = "isquickcreateenabledforopportunityclose";

			/// <summary>isreadauditenabled</summary>
			public const string IsReadAuditingEnabled = "isreadauditenabled";

			/// <summary>isrelationshipinsightsenabled</summary>
			public const string EnableRelationshipInsightsForThisOrganization = "isrelationshipinsightsenabled";

			/// <summary>isresourcebookingexchangesyncenabled</summary>
			public const string ResourceBookingSynchronizationEnabled = "isresourcebookingexchangesyncenabled";

			/// <summary>isrichtextnotesenabled</summary>
			public const string IndicatesWhetherRichTextEditorForNotesExperienceIsEnabledOnThisOrganization = "isrichtextnotesenabled";

			/// <summary>issalesassistantenabled</summary>
			public const string EnableSalesAssistantMobileApp = "issalesassistantenabled";

			/// <summary>issopintegrationenabled</summary>
			public const string IsSalesOrderIntegrationEnabled = "issopintegrationenabled";

			/// <summary>istextwrapenabled</summary>
			public const string EnableTextWrap = "istextwrapenabled";

			/// <summary>isuseraccessauditenabled</summary>
			public const string IsUserAccessAuditingEnabled = "isuseraccessauditenabled";

			/// <summary>isvintegrationcode</summary>
			public const string ISVIntegrationMode = "isvintegrationcode";

			/// <summary>iswriteinproductsallowed</summary>
			public const string IndicatesWhetherWriteinProductsCanBeAddedToOpportunityQuoteOrderInvoiceOrNot = "iswriteinproductsallowed";

			/// <summary>kaprefix</summary>
			public const string KnowledgeArticlePrefix = "kaprefix";

			/// <summary>kbprefix</summary>
			public const string ArticlePrefix = "kbprefix";

			/// <summary>kmsettings</summary>
			public const string KnowledgeManagementSettings = "kmsettings";

			/// <summary>languagecode</summary>
			public const string Language = "languagecode";

			/// <summary>localeid</summary>
			public const string Locale = "localeid";

			/// <summary>longdateformatcode</summary>
			public const string LongDateFormat = "longdateformatcode";

			/// <summary>mailboxintermittentissueminrange</summary>
			public const string LowerThresholdForMailboxIntermittentIssue = "mailboxintermittentissueminrange";

			/// <summary>mailboxpermanentissueminrange</summary>
			public const string LowerThresholdForMailboxPermanentIssue = "mailboxpermanentissueminrange";

			/// <summary>maxactionstepsinbpf</summary>
			public const string MaximumNumberOfActionstepsAllowedInABPF = "maxactionstepsinbpf";

			/// <summary>maxappointmentdurationdays</summary>
			public const string MaxAppointmentDuration = "maxappointmentdurationdays";

			/// <summary>maxconditionsformobileofflinefilters</summary>
			public const string MaximumNumberOfConditionsAllowedForMobileOfflineFilters = "maxconditionsformobileofflinefilters";

			/// <summary>maxdepthforhierarchicalsecuritymodel</summary>
			public const string MaximumDepthForHierarchySecurityPropagation = "maxdepthforhierarchicalsecuritymodel";

			/// <summary>maxfolderbasedtrackingmappings</summary>
			public const string MaxFolderBasedTrackingMappings = "maxfolderbasedtrackingmappings";

			/// <summary>maximumactivebusinessprocessflowsallowedperentity</summary>
			public const string MaximumActiveBusinessProcessFlowsPerEntity = "maximumactivebusinessprocessflowsallowedperentity";

			/// <summary>maximumdynamicpropertiesallowed</summary>
			public const string ProductPropertiesItemLimit = "maximumdynamicpropertiesallowed";

			/// <summary>maximumentitieswithactivesla</summary>
			public const string MaximumNumberOfActiveSLAAllowedPerEntityInOnline = "maximumentitieswithactivesla";

			/// <summary>maximumslakpiperentitywithactivesla</summary>
			public const string MaximumNumberOfActiveSLAKPIAllowedPerEntityInOnline = "maximumslakpiperentitywithactivesla";

			/// <summary>maximumtrackingnumber</summary>
			public const string MaxTrackingNumber = "maximumtrackingnumber";

			/// <summary>maxproductsinbundle</summary>
			public const string BundleItemLimit = "maxproductsinbundle";

			/// <summary>maxrecordsforexporttoexcel</summary>
			public const string MaxRecordsForExcelExport = "maxrecordsforexporttoexcel";

			/// <summary>maxrecordsforlookupfilters</summary>
			public const string MaxRecordsFilterSelection = "maxrecordsforlookupfilters";

			/// <summary>maxslaitemspersla</summary>
			public const string MaxSLAItemsPerSLA = "maxslaitemspersla";

			/// <summary>maxsupportedinternetexplorerversion</summary>
			public const string MaxSupportedIEVersion = "maxsupportedinternetexplorerversion";

			/// <summary>maxuploadfilesize</summary>
			public const string MaxUploadFileSize = "maxuploadfilesize";

			/// <summary>maxverboseloggingmailbox</summary>
			public const string MaxNoOfMailboxesToEnableForVerboseLogging = "maxverboseloggingmailbox";

			/// <summary>maxverboseloggingsynccycles</summary>
			public const string MaximumNumberOfSyncCyclesForWhichVerboseLoggingWillBeEnabledByDefault = "maxverboseloggingsynccycles";

			/// <summary>metadatasynclasttimeofneverexpireddeletedobjects</summary>
			public const string TheLastDatetimeForNeverExpiredMetadataTrackingDeletedObjects = "metadatasynclasttimeofneverexpireddeletedobjects";

			/// <summary>metadatasynctimestamp</summary>
			public const string MetadataSyncVersion = "metadatasynctimestamp";

			/// <summary>microsoftflowenvironment</summary>
			public const string DeprecatedEnvironmentSelectedForIntegrationWithMicrosoftFlow = "microsoftflowenvironment";

			/// <summary>minaddressbooksyncinterval</summary>
			public const string MinAddressSynchronizationFrequency = "minaddressbooksyncinterval";

			/// <summary>minofflinesyncinterval</summary>
			public const string MinOfflineSynchronizationFrequency = "minofflinesyncinterval";

			/// <summary>minoutlooksyncinterval</summary>
			public const string MinSynchronizationFrequency = "minoutlooksyncinterval";

			/// <summary>mobileofflineminlicenseprod</summary>
			public const string MinimumNumberOfUserLicenseRequiredForMobileOfflineServiceByProductionpreviewOrganization = "mobileofflineminlicenseprod";

			/// <summary>mobileofflineminlicensetrial</summary>
			public const string MinimumNumberOfUserLicenseRequiredForMobileOfflineServiceByTrialOrganization = "mobileofflineminlicensetrial";

			/// <summary>mobileofflinesyncinterval</summary>
			public const string SyncIntervalForMobileOffline = "mobileofflinesyncinterval";

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
			public const string OrganizationName = "name";

			/// <summary>negativecurrencyformatcode</summary>
			public const string NegativeCurrencyFormat = "negativecurrencyformatcode";

			/// <summary>negativeformatcode</summary>
			public const string NegativeFormat = "negativeformatcode";

			/// <summary>nextcustomobjecttypecode</summary>
			public const string NextEntityTypeCode = "nextcustomobjecttypecode";

			/// <summary>nexttrackingnumber</summary>
			public const string NextTrackingNumber = "nexttrackingnumber";

			/// <summary>notifymailboxownerofemailserverlevelalerts</summary>
			public const string NotifyMailboxOwnerOfEmailServerLevelAlerts = "notifymailboxownerofemailserverlevelalerts";

			/// <summary>numberformat</summary>
			public const string NumberFormat = "numberformat";

			/// <summary>numbergroupformat</summary>
			public const string NumberGroupingFormat = "numbergroupformat";

			/// <summary>numberseparator</summary>
			public const string NumberSeparator = "numberseparator";

			/// <summary>officeappsautodeploymentenabled</summary>
			public const string EnableOfficeAppsAutoDeploymentForThisOrganization = "officeappsautodeploymentenabled";

			/// <summary>officegraphdelveurl</summary>
			public const string TheUrlToOpenTheDelve = "officegraphdelveurl";

			/// <summary>oobpricecalculationenabled</summary>
			public const string EnableOOBPriceCalculation = "oobpricecalculationenabled";

			/// <summary>orderprefix</summary>
			public const string OrderPrefix = "orderprefix";

			/// <summary>organizationid</summary>
			public const string OrganizationId = "organizationid";

			/// <summary>organizationstate</summary>
			public const string OrganizationState = "organizationstate";

			/// <summary>orgdborgsettings</summary>
			public const string OrganizationDatabaseOrganizationSettings = "orgdborgsettings";

			/// <summary>orginsightsenabled</summary>
			public const string EnableOrgInsightsForThisOrganization = "orginsightsenabled";

			/// <summary>paipreviewscenarioenabled</summary>
			public const string DisplayPreviewFeatureForThisOrganization = "paipreviewscenarioenabled";

			/// <summary>parsedtablecolumnprefix</summary>
			public const string ParsedTableColumnPrefix = "parsedtablecolumnprefix";

			/// <summary>parsedtableprefix</summary>
			public const string ParsedTablePrefix = "parsedtableprefix";

			/// <summary>pastexpansionwindow</summary>
			public const string PastExpansionWindow = "pastexpansionwindow";

			/// <summary>picture</summary>
			public const string Picture = "picture";

			/// <summary>pinpointlanguagecode</summary>
			public const string Pinpointlanguagecode = "pinpointlanguagecode";

			/// <summary>plugintracelogsetting</summary>
			public const string PluginTraceLogSetting = "plugintracelogsetting";

			/// <summary>pmdesignator</summary>
			public const string PMDesignator = "pmdesignator";

			/// <summary>postmessagewhitelistdomains</summary>
			public const string ForInternalUseOnly2 = "postmessagewhitelistdomains";

			/// <summary>powerbifeatureenabled</summary>
			public const string EnablePowerBIFeatureForThisOrganization = "powerbifeatureenabled";

			/// <summary>pricingdecimalprecision</summary>
			public const string PricingDecimalPrecision = "pricingdecimalprecision";

			/// <summary>privacystatementurl</summary>
			public const string PrivacyStatementURL = "privacystatementurl";

			/// <summary>privilegeusergroupid</summary>
			public const string PrivilegeUserGroupId = "privilegeusergroupid";

			/// <summary>privreportinggroupid</summary>
			public const string PrivilegeReportingGroupId = "privreportinggroupid";

			/// <summary>privreportinggroupname</summary>
			public const string PrivilegeReportingGroupName = "privreportinggroupname";

			/// <summary>productrecommendationsenabled</summary>
			public const string EnableProductRecommendationsForThisOrganization = "productrecommendationsenabled";

			/// <summary>qualifyleadadditionaloptions</summary>
			public const string EnableNewQualifyLeadExperienceWithConfigurationMDD = "qualifyleadadditionaloptions";

			/// <summary>quickfindrecordlimitenabled</summary>
			public const string QuickFindRecordLimitEnabled = "quickfindrecordlimitenabled";

			/// <summary>quoteprefix</summary>
			public const string QuotePrefix = "quoteprefix";

			/// <summary>recurrencedefaultnumberofoccurrences</summary>
			public const string RecurrenceDefaultNumberOfOccurrences = "recurrencedefaultnumberofoccurrences";

			/// <summary>recurrenceexpansionjobbatchinterval</summary>
			public const string RecurrenceExpansionJobBatchInterval = "recurrenceexpansionjobbatchinterval";

			/// <summary>recurrenceexpansionjobbatchsize</summary>
			public const string RecurrenceExpansionOnDemandJobBatchSize = "recurrenceexpansionjobbatchsize";

			/// <summary>recurrenceexpansionsynchcreatemax</summary>
			public const string RecurrenceExpansionSynchronizationCreateMaximum = "recurrenceexpansionsynchcreatemax";

			/// <summary>referencesitemapxml</summary>
			public const string ReferenceSiteMapXML = "referencesitemapxml";

			/// <summary>rendersecureiframeforemail</summary>
			public const string RenderSecureFrameForEmail = "rendersecureiframeforemail";

			/// <summary>reportinggroupid</summary>
			public const string ReportingGroupId = "reportinggroupid";

			/// <summary>reportinggroupname</summary>
			public const string ReportingGroupName = "reportinggroupname";

			/// <summary>reportscripterrors</summary>
			public const string ReportScriptErrors = "reportscripterrors";

			/// <summary>requireapprovalforqueueemail</summary>
			public const string IsApprovalForQueueEmailRequired = "requireapprovalforqueueemail";

			/// <summary>requireapprovalforuseremail</summary>
			public const string IsApprovalForUserEmailRequired = "requireapprovalforuseremail";

			/// <summary>resolvesimilarunresolvedemailaddress</summary>
			public const string ApplySameEmailAddressToAllUnresolvedMatchesWhenYouManuallyResolveItForOne = "resolvesimilarunresolvedemailaddress";

			/// <summary>restrictstatusupdate</summary>
			public const string RestrictStatusUpdate = "restrictstatusupdate";

			/// <summary>rierrorstatus</summary>
			public const string ErrorStatusOfRelationshipInsightsProvisioning = "rierrorstatus";

			/// <summary>sampledataimportid</summary>
			public const string SampleDataImportId = "sampledataimportid";

			/// <summary>schedulingengine</summary>
			public const string SchedulingEngineForAppointmentsAndServiceActivities = "schedulingengine";

			/// <summary>schemanameprefix</summary>
			public const string CustomizationNamePrefix = "schemanameprefix";

			/// <summary>sendbulkemailinuci</summary>
			public const string SendBulkEmailInUCI = "sendbulkemailinuci";

			/// <summary>servestaticresourcesfromazurecdn</summary>
			public const string ServeStaticContentFromCDN = "servestaticresourcesfromazurecdn";

			/// <summary>sessiontimeoutenabled</summary>
			public const string SessionTimeoutEnabled = "sessiontimeoutenabled";

			/// <summary>sessiontimeoutinmins</summary>
			public const string SessionTimeoutInMinutes = "sessiontimeoutinmins";

			/// <summary>sessiontimeoutreminderinmins</summary>
			public const string SessionTimeoutReminderInMinutes = "sessiontimeoutreminderinmins";

			/// <summary>sharepointdeploymenttype</summary>
			public const string ChooseSharePointDeploymentType = "sharepointdeploymenttype";

			/// <summary>sharetopreviousowneronassign</summary>
			public const string ShareToPreviousOwnerOnAssign = "sharetopreviousowneronassign";

			/// <summary>showkbarticledeprecationnotification</summary>
			public const string ShowKBArticleDeprecationMessageToUser = "showkbarticledeprecationnotification";

			/// <summary>showweeknumber</summary>
			public const string ShowWeekNumber = "showweeknumber";

			/// <summary>signupoutlookdownloadfwlink</summary>
			public const string CRMForOutlookDownloadURL = "signupoutlookdownloadfwlink";

			/// <summary>sitemapxml</summary>
			public const string SiteMapXML = "sitemapxml";

			/// <summary>slapausestates</summary>
			public const string SLAPauseStates = "slapausestates";

			/// <summary>socialinsightsenabled</summary>
			public const string SocialInsightsEnabled = "socialinsightsenabled";

			/// <summary>socialinsightsinstance</summary>
			public const string SocialInsightsInstanceIdentifier = "socialinsightsinstance";

			/// <summary>socialinsightstermsaccepted</summary>
			public const string SocialInsightsTermsOfUse = "socialinsightstermsaccepted";

			/// <summary>sortid</summary>
			public const string Sort = "sortid";

			/// <summary>sqlaccessgroupid</summary>
			public const string SQLAccessGroupId = "sqlaccessgroupid";

			/// <summary>sqlaccessgroupname</summary>
			public const string SQLAccessGroupName = "sqlaccessgroupname";

			/// <summary>sqmenabled</summary>
			public const string IsSQMEnabled = "sqmenabled";

			/// <summary>supportuserid</summary>
			public const string SupportUserId = "supportuserid";

			/// <summary>suppresssla</summary>
			public const string IsSLASuppressed = "suppresssla";

			/// <summary>syncbulkoperationbatchsize</summary>
			public const string NumberOfRecordsToUpdatePerOperationInSyncBulkPauseResumeCancel = "syncbulkoperationbatchsize";

			/// <summary>syncbulkoperationmaxlimit</summary>
			public const string MaxTotalNumberOfRecordsToUpdateInDatabaseForSyncBulkPauseResumeCancel = "syncbulkoperationmaxlimit";

			/// <summary>syncoptinselection</summary>
			public const string EnableDynamics365AzureSyncFrameworkForThisOrganization = "syncoptinselection";

			/// <summary>syncoptinselectionstatus</summary>
			public const string StatusOfOptinOrOptoutOperationForDynamics365AzureSync = "syncoptinselectionstatus";

			/// <summary>systemuserid</summary>
			public const string SystemUserId = "systemuserid";

			/// <summary>tagmaxaggressivecycles</summary>
			public const string AutoTagMaxCycles = "tagmaxaggressivecycles";

			/// <summary>tagpollingperiod</summary>
			public const string AutoTagInterval = "tagpollingperiod";

			/// <summary>taskbasedflowenabled</summary>
			public const string EnableTaskFlowProcessesForThisOrganization = "taskbasedflowenabled";

			/// <summary>textanalyticsenabled</summary>
			public const string EnableTextAnalyticsForThisOrganization = "textanalyticsenabled";

			/// <summary>timeformatcode</summary>
			public const string TimeFormatCode = "timeformatcode";

			/// <summary>timeformatstring</summary>
			public const string TimeFormatString = "timeformatstring";

			/// <summary>timeseparator</summary>
			public const string TimeSeparator = "timeseparator";

			/// <summary>timezoneruleversionnumber</summary>
			public const string TimeZoneRuleVersionNumber = "timezoneruleversionnumber";

			/// <summary>tokenexpiry</summary>
			public const string TokenExpirationDuration = "tokenexpiry";

			/// <summary>tokenkey</summary>
			public const string TokenKey = "tokenkey";

			/// <summary>tracelogmaximumageindays</summary>
			public const string TracelogRecordMaximumAgeInDays = "tracelogmaximumageindays";

			/// <summary>trackingprefix</summary>
			public const string TrackingPrefix = "trackingprefix";

			/// <summary>trackingtokenidbase</summary>
			public const string TrackingTokenBase = "trackingtokenidbase";

			/// <summary>trackingtokeniddigits</summary>
			public const string TrackingTokenDigits = "trackingtokeniddigits";

			/// <summary>uniquespecifierlength</summary>
			public const string UniqueStringLength = "uniquespecifierlength";

			/// <summary>unresolveemailaddressifmultiplematch</summary>
			public const string SetToccbccFieldsAsUnresolvedIfMultipleMatchesAreFound = "unresolveemailaddressifmultiplematch";

			/// <summary>useinbuiltrulefordefaultpricelistselection</summary>
			public const string UseInbuiltRuleForDefaultPricelistSelection = "useinbuiltrulefordefaultpricelistselection";

			/// <summary>uselegacyrendering</summary>
			public const string LegacyFormRendering = "uselegacyrendering";

			/// <summary>usepositionhierarchy</summary>
			public const string UsePositionHierarchy = "usepositionhierarchy";

			/// <summary>usequickfindviewforgridsearch</summary>
			public const string UseQuickFindViewWhenSearchingInGrids = "usequickfindviewforgridsearch";

			/// <summary>useraccessauditinginterval</summary>
			public const string UserAuthenticationAuditingInterval = "useraccessauditinginterval";

			/// <summary>usereadform</summary>
			public const string UseReadOptimizedForm = "usereadform";

			/// <summary>usergroupid</summary>
			public const string UserGroupId = "usergroupid";

			/// <summary>useskypeprotocol</summary>
			public const string UserSkypeProtocol = "useskypeprotocol";

			/// <summary>utcconversiontimezonecode</summary>
			public const string UTCConversionTimeZoneCode = "utcconversiontimezonecode";

			/// <summary>v3calloutconfighash</summary>
			public const string V3CalloutHash = "v3calloutconfighash";

			/// <summary>versionnumber</summary>
			public const string VersionNumber = "versionnumber";

			/// <summary>webresourcehash</summary>
			public const string WebResourceHash = "webresourcehash";

			/// <summary>weekstartdaycode</summary>
			public const string WeekStartDayCode = "weekstartdaycode";

			/// <summary>widgetproperties</summary>
			public const string ForInternalUseOnly3 = "widgetproperties";

			/// <summary>yammergroupid</summary>
			public const string YammerGroupId = "yammergroupid";

			/// <summary>yammernetworkpermalink</summary>
			public const string YammerNetworkPermalink = "yammernetworkpermalink";

			/// <summary>yammeroauthaccesstokenexpired</summary>
			public const string YammerOAuthAccessTokenExpired = "yammeroauthaccesstokenexpired";

			/// <summary>yammerpostmethod</summary>
			public const string InternalUseOnly = "yammerpostmethod";

			/// <summary>yearstartweekcode</summary>
			public const string YearStartWeekCode = "yearstartweekcode";

		}
		#endregion

		#region Schemas
		public static class Schemas 
		{
			/// <summary>1:N customcontrol_organization</summary>
			public const string CustomcontrolOrganization = "customcontrol_organization";

			/// <summary>1:N customcontroldefaultconfig_organization</summary>
			public const string CustomcontroldefaultconfigOrganization = "customcontroldefaultconfig_organization";

			/// <summary>1:N customcontrolresource_organization</summary>
			public const string CustomcontrolresourceOrganization = "customcontrolresource_organization";

			/// <summary>1:N dynamicproperty_organization</summary>
			public const string DynamicpropertyOrganization = "dynamicproperty_organization";

			/// <summary>1:N DynamicPropertyAssociation_organization</summary>
			public const string DynamicPropertyAssociationOrganization = "DynamicPropertyAssociation_organization";

			/// <summary>1:N DynamicPropertyOptionSetItem_organization</summary>
			public const string DynamicPropertyOptionSetItemOrganization = "DynamicPropertyOptionSetItem_organization";

			/// <summary>1:N entitlementchannel_organization</summary>
			public const string EntitlementchannelOrganization = "entitlementchannel_organization";

			/// <summary>1:N entitlementtemplate_organization</summary>
			public const string EntitlementtemplateOrganization = "entitlementtemplate_organization";

			/// <summary>1:N entitlementtemplatechannel_organization</summary>
			public const string EntitlementtemplatechannelOrganization = "entitlementtemplatechannel_organization";

			/// <summary>1:N languagelocale_organization</summary>
			public const string LanguagelocaleOrganization = "languagelocale_organization";

			/// <summary>1:N lk_dataperformance_organizationid</summary>
			public const string LkDataperformanceOrganizationid = "lk_dataperformance_organizationid";

			/// <summary>1:N lk_documenttemplatebase_organization</summary>
			public const string LkDocumenttemplatebaseOrganization = "lk_documenttemplatebase_organization";

			/// <summary>1:N lk_fieldsecurityprofile_organizationid</summary>
			public const string LkFieldsecurityprofileOrganizationid = "lk_fieldsecurityprofile_organizationid";

			/// <summary>1:N lk_principalobjectattributeaccess_organizationid</summary>
			public const string LkPrincipalobjectattributeaccessOrganizationid = "lk_principalobjectattributeaccess_organizationid";

			/// <summary>1:N MobileOfflineProfile_organization</summary>
			public const string MobileOfflineProfileOrganization = "MobileOfflineProfile_organization";

			/// <summary>1:N MobileOfflineProfileItem_organization</summary>
			public const string MobileOfflineProfileItemOrganization = "MobileOfflineProfileItem_organization";

			/// <summary>1:N MobileOfflineProfileItemAssociation_organization</summary>
			public const string MobileOfflineProfileItemAssociationOrganization = "MobileOfflineProfileItemAssociation_organization";

			/// <summary>1:N organization_aciviewmapper</summary>
			public const string OrganizationAciviewmapper = "organization_aciviewmapper";

			/// <summary>1:N organization_appconfig</summary>
			public const string OrganizationAppconfig = "organization_appconfig";

			/// <summary>1:N organization_appconfiginstance</summary>
			public const string OrganizationAppconfiginstance = "organization_appconfiginstance";

			/// <summary>1:N organization_appconfigmaster</summary>
			public const string OrganizationAppconfigmaster = "organization_appconfigmaster";

			/// <summary>1:N organization_appmodule</summary>
			public const string OrganizationAppmodule = "organization_appmodule";

			/// <summary>1:N Organization_AsyncOperations</summary>
			public const string OrganizationAsyncOperations = "Organization_AsyncOperations";

			/// <summary>1:N Organization_BulkDeleteFailures</summary>
			public const string OrganizationBulkDeleteFailures = "Organization_BulkDeleteFailures";

			/// <summary>1:N organization_business_unit_news_articles</summary>
			public const string OrganizationBusinessUnitNewsArticles = "organization_business_unit_news_articles";

			/// <summary>1:N organization_business_units</summary>
			public const string OrganizationBusinessUnits = "organization_business_units";

			/// <summary>1:N organization_calendars</summary>
			public const string OrganizationCalendars = "organization_calendars";

			/// <summary>1:N organization_catalog</summary>
			public const string OrganizationCatalog = "organization_catalog";

			/// <summary>1:N organization_catalogassignment</summary>
			public const string OrganizationCatalogassignment = "organization_catalogassignment";

			/// <summary>1:N organization_competitors</summary>
			public const string OrganizationCompetitors = "organization_competitors";

			/// <summary>1:N organization_complexcontrols</summary>
			public const string OrganizationComplexcontrols = "organization_complexcontrols";

			/// <summary>1:N organization_connection_roles</summary>
			public const string OrganizationConnectionRoles = "organization_connection_roles";

			/// <summary>1:N organization_constraint_based_groups</summary>
			public const string OrganizationConstraintBasedGroups = "organization_constraint_based_groups";

			/// <summary>1:N organization_contract_templates</summary>
			public const string OrganizationContractTemplates = "organization_contract_templates";

			/// <summary>1:N organization_custom_displaystrings</summary>
			public const string OrganizationCustomDisplaystrings = "organization_custom_displaystrings";

			/// <summary>1:N organization_datalakeworkspace</summary>
			public const string OrganizationDatalakeworkspace = "organization_datalakeworkspace";

			/// <summary>1:N organization_datalakeworkspacepermission</summary>
			public const string OrganizationDatalakeworkspacepermission = "organization_datalakeworkspacepermission";

			/// <summary>1:N organization_discount_types</summary>
			public const string OrganizationDiscountTypes = "organization_discount_types";

			/// <summary>1:N organization_emailserverprofile</summary>
			public const string OrganizationEmailserverprofile = "organization_emailserverprofile";

			/// <summary>1:N organization_entityanalyticsconfig</summary>
			public const string OrganizationEntityanalyticsconfig = "organization_entityanalyticsconfig";

			/// <summary>1:N organization_entitydataprovider</summary>
			public const string OrganizationEntitydataprovider = "organization_entitydataprovider";

			/// <summary>1:N organization_equipment</summary>
			public const string OrganizationEquipment = "organization_equipment";

			/// <summary>1:N organization_expiredprocess</summary>
			public const string OrganizationExpiredprocess = "organization_expiredprocess";

			/// <summary>1:N organization_importjob</summary>
			public const string OrganizationImportjob = "organization_importjob";

			/// <summary>1:N organization_kb_article_templates</summary>
			public const string OrganizationKbArticleTemplates = "organization_kb_article_templates";

			/// <summary>1:N organization_kb_articles</summary>
			public const string OrganizationKbArticles = "organization_kb_articles";

			/// <summary>1:N organization_KnowledgeBaseRecord</summary>
			public const string OrganizationKnowledgeBaseRecord = "organization_KnowledgeBaseRecord";

			/// <summary>1:N organization_leadtoopportunitysalesprocess</summary>
			public const string OrganizationLeadtoopportunitysalesprocess = "organization_leadtoopportunitysalesprocess";

			/// <summary>1:N organization_mailbox</summary>
			public const string OrganizationMailbox = "organization_mailbox";

			/// <summary>1:N Organization_MailboxTrackingFolder</summary>
			public const string OrganizationMailboxTrackingFolder = "Organization_MailboxTrackingFolder";

			/// <summary>1:N organization_marketingformdisplayattributes</summary>
			public const string OrganizationMarketingformdisplayattributes = "organization_marketingformdisplayattributes";

			/// <summary>1:N organization_metric</summary>
			public const string OrganizationMetric = "organization_metric";

			/// <summary>1:N organization_msdyn_databaseversion</summary>
			public const string OrganizationMsdynDatabaseversion = "organization_msdyn_databaseversion";

			/// <summary>1:N organization_msdyn_federatedarticleincident</summary>
			public const string OrganizationMsdynFederatedarticleincident = "organization_msdyn_federatedarticleincident";

			/// <summary>1:N organization_msdyn_helppage</summary>
			public const string OrganizationMsdynHelppage = "organization_msdyn_helppage";

			/// <summary>1:N organization_msdyn_postconfig</summary>
			public const string OrganizationMsdynPostconfig = "organization_msdyn_postconfig";

			/// <summary>1:N organization_msdyn_postruleconfig</summary>
			public const string OrganizationMsdynPostruleconfig = "organization_msdyn_postruleconfig";

			/// <summary>1:N organization_msdyn_sikeyvalueconfig</summary>
			public const string OrganizationMsdynSikeyvalueconfig = "organization_msdyn_sikeyvalueconfig";

			/// <summary>1:N organization_msdyn_tour</summary>
			public const string OrganizationMsdynTour = "organization_msdyn_tour";

			/// <summary>1:N organization_msdyn_upgraderun</summary>
			public const string OrganizationMsdynUpgraderun = "organization_msdyn_upgraderun";

			/// <summary>1:N organization_msdyn_upgradestep</summary>
			public const string OrganizationMsdynUpgradestep = "organization_msdyn_upgradestep";

			/// <summary>1:N organization_msdyn_upgradeversion</summary>
			public const string OrganizationMsdynUpgradeversion = "organization_msdyn_upgradeversion";

			/// <summary>1:N organization_msdyn_wallsavedquery</summary>
			public const string OrganizationMsdynWallsavedquery = "organization_msdyn_wallsavedquery";

			/// <summary>1:N organization_navigationsetting</summary>
			public const string OrganizationNavigationsetting = "organization_navigationsetting";

			/// <summary>1:N organization_newprocess</summary>
			public const string OrganizationNewprocess = "organization_newprocess";

			/// <summary>1:N organization_officegraphdocument</summary>
			public const string OrganizationOfficegraphdocument = "organization_officegraphdocument";

			/// <summary>1:N organization_opportunitysalesprocess</summary>
			public const string OrganizationOpportunitysalesprocess = "organization_opportunitysalesprocess";

			/// <summary>1:N organization_package</summary>
			public const string OrganizationPackage = "organization_package";

			/// <summary>1:N organization_phonetocaseprocess</summary>
			public const string OrganizationPhonetocaseprocess = "organization_phonetocaseprocess";

			/// <summary>1:N organization_pluginassembly</summary>
			public const string OrganizationPluginassembly = "organization_pluginassembly";

			/// <summary>1:N organization_plugintype</summary>
			public const string OrganizationPlugintype = "organization_plugintype";

			/// <summary>1:N organization_plugintypestatistic</summary>
			public const string OrganizationPlugintypestatistic = "organization_plugintypestatistic";

			/// <summary>1:N organization_position</summary>
			public const string OrganizationPosition = "organization_position";

			/// <summary>1:N organization_post</summary>
			public const string OrganizationPost = "organization_post";

			/// <summary>1:N organization_PostComment</summary>
			public const string OrganizationPostComment = "organization_PostComment";

			/// <summary>1:N organization_postlike</summary>
			public const string OrganizationPostlike = "organization_postlike";

			/// <summary>1:N organization_price_levels</summary>
			public const string OrganizationPriceLevels = "organization_price_levels";

			/// <summary>1:N organization_ProductAssociation</summary>
			public const string OrganizationProductAssociation = "organization_ProductAssociation";

			/// <summary>1:N organization_products</summary>
			public const string OrganizationProducts = "organization_products";

			/// <summary>1:N organization_ProductSubstitute</summary>
			public const string OrganizationProductSubstitute = "organization_ProductSubstitute";

			/// <summary>1:N organization_publisher</summary>
			public const string OrganizationPublisher = "organization_publisher";

			/// <summary>1:N organization_queueitems</summary>
			public const string OrganizationQueueitems = "organization_queueitems";

			/// <summary>1:N organization_queues</summary>
			public const string OrganizationQueues = "organization_queues";

			/// <summary>1:N organization_recommendeddocument</summary>
			public const string OrganizationRecommendeddocument = "organization_recommendeddocument";

			/// <summary>1:N organization_resource_groups</summary>
			public const string OrganizationResourceGroups = "organization_resource_groups";

			/// <summary>1:N organization_resource_specs</summary>
			public const string OrganizationResourceSpecs = "organization_resource_specs";

			/// <summary>1:N organization_resources</summary>
			public const string OrganizationResources = "organization_resources";

			/// <summary>1:N organization_roles</summary>
			public const string OrganizationRoles = "organization_roles";

			/// <summary>1:N organization_sales_literature</summary>
			public const string OrganizationSalesLiterature = "organization_sales_literature";

			/// <summary>1:N organization_saved_queries</summary>
			public const string OrganizationSavedQueries = "organization_saved_queries";

			/// <summary>1:N organization_saved_query_visualizations</summary>
			public const string OrganizationSavedQueryVisualizations = "organization_saved_query_visualizations";

			/// <summary>1:N organization_sdkmessage</summary>
			public const string OrganizationSdkmessage = "organization_sdkmessage";

			/// <summary>1:N organization_sdkmessagefilter</summary>
			public const string OrganizationSdkmessagefilter = "organization_sdkmessagefilter";

			/// <summary>1:N organization_sdkmessageprocessingstep</summary>
			public const string OrganizationSdkmessageprocessingstep = "organization_sdkmessageprocessingstep";

			/// <summary>1:N organization_sdkmessageprocessingstepimage</summary>
			public const string OrganizationSdkmessageprocessingstepimage = "organization_sdkmessageprocessingstepimage";

			/// <summary>1:N organization_sdkmessageprocessingstepsecureconfig</summary>
			public const string OrganizationSdkmessageprocessingstepsecureconfig = "organization_sdkmessageprocessingstepsecureconfig";

			/// <summary>1:N organization_serviceendpoint</summary>
			public const string OrganizationServiceendpoint = "organization_serviceendpoint";

			/// <summary>1:N organization_services</summary>
			public const string OrganizationServices = "organization_services";

			/// <summary>1:N organization_sitemap</summary>
			public const string OrganizationSitemap = "organization_sitemap";

			/// <summary>1:N organization_sites</summary>
			public const string OrganizationSites = "organization_sites";

			/// <summary>1:N organization_solution</summary>
			public const string OrganizationSolution = "organization_solution";

			/// <summary>1:N organization_solutioncomponentattributeconfiguration</summary>
			public const string OrganizationSolutioncomponentattributeconfiguration = "organization_solutioncomponentattributeconfiguration";

			/// <summary>1:N organization_solutioncomponentconfiguration</summary>
			public const string OrganizationSolutioncomponentconfiguration = "organization_solutioncomponentconfiguration";

			/// <summary>1:N organization_solutioncomponentrelationshipconfiguration</summary>
			public const string OrganizationSolutioncomponentrelationshipconfiguration = "organization_solutioncomponentrelationshipconfiguration";

			/// <summary>1:N organization_subjects</summary>
			public const string OrganizationSubjects = "organization_subjects";

			/// <summary>1:N Organization_SyncErrors</summary>
			public const string OrganizationSyncErrors = "Organization_SyncErrors";

			/// <summary>1:N organization_system_users</summary>
			public const string OrganizationSystemUsers = "organization_system_users";

			/// <summary>1:N organization_systemforms</summary>
			public const string OrganizationSystemforms = "organization_systemforms";

			/// <summary>1:N organization_teams</summary>
			public const string OrganizationTeams = "organization_teams";

			/// <summary>1:N organization_territories</summary>
			public const string OrganizationTerritories = "organization_territories";

			/// <summary>1:N organization_theme</summary>
			public const string OrganizationTheme = "organization_theme";

			/// <summary>1:N organization_tracelog</summary>
			public const string OrganizationTracelog = "organization_tracelog";

			/// <summary>1:N organization_transactioncurrencies</summary>
			public const string OrganizationTransactioncurrencies = "organization_transactioncurrencies";

			/// <summary>1:N organization_translationprocess</summary>
			public const string OrganizationTranslationprocess = "organization_translationprocess";

			/// <summary>1:N organization_uof_schedules</summary>
			public const string OrganizationUofSchedules = "organization_uof_schedules";

			/// <summary>1:N organization_UserMapping</summary>
			public const string OrganizationUserMapping = "organization_UserMapping";

			/// <summary>1:N organization_webwizard</summary>
			public const string OrganizationWebwizard = "organization_webwizard";

			/// <summary>1:N webresource_organization</summary>
			public const string WebresourceOrganization = "webresource_organization";

		}
		#endregion
	}
}

