using System;
using System.Linq;
using System.Diagnostics;
using System.ComponentModel;
using Microsoft.Xrm.Sdk; 
using Microsoft.Xrm.Sdk.Client;
using System.Collections.Generic;

namespace PentaWork.Xrm.Scheduler.Proxies.Entities
{
	[DebuggerDisplay("{OwnerName}")] 	
	[EntityLogicalName("owner")]
	public sealed class Owner : Entity
	{	
		public static readonly int? EntityTypeCode = 7;
		public new const string LogicalName = "owner";
		public const string PrimaryIdAttribute = "ownerid";
		public const string PrimaryNameAttribute = "name";
	
		public Owner() : base("owner") { }

		#region Attributes
		/// <summary>
        /// name
        /// </summary>
		[DisplayName("Owner Name")]
		[AttributeLogicalName("name")]
		public string OwnerName
		{	
			get { return GetAttributeValue<string>("name"); }
			set
			{ 
				if(value == OwnerName) return;
				SetAttributeValue("name", value);
			}
		}	
			
		/// <summary>
        /// ownerid
        /// </summary>
		[DisplayName("Owner")]
		[AttributeLogicalName("ownerid")]
		public override Guid Id
		{
			get => base.Id;
			set { base.Id = value; SetAttributeValue("ownerid", value); }
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
        /// versionnumber
        /// </summary>
		[DisplayName("versionnumber")]
		[AttributeLogicalName("versionnumber")]
		public int? Versionnumber
		{	
			get { return GetAttributeValue<int?>("versionnumber"); }
			set
			{ 
				if(value == Versionnumber) return;
				SetAttributeValue("versionnumber", value);
			}
		}	
			
		/// <summary>
        /// yominame
        /// </summary>
		[DisplayName("Yomi Name")]
		[AttributeLogicalName("yominame")]
		public string YomiName
		{	
			get { return GetAttributeValue<string>("yominame"); }
			set
			{ 
				if(value == YomiName) return;
				SetAttributeValue("yominame", value);
			}
		}	
			
		#endregion	

		#region Relations
			/// <summary>
        /// 1:N Get entities for 'ActionCardUserState_Owner'
        /// </summary>
		[RelationshipSchemaName("ActionCardUserState_Owner")]
		public IEnumerable<ActionCardUserState> ActionCardUserStateOwner
		{
			get { return GetRelatedEntities<ActionCardUserState>("ActionCardUserState_Owner", null); }
			set { SetRelatedEntities("ActionCardUserState_Owner", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'bulkoperation_owner_ownerid'
        /// </summary>
		[RelationshipSchemaName("bulkoperation_owner_ownerid")]
		public IEnumerable<QuickCampaign> BulkoperationOwnerOwnerid
		{
			get { return GetRelatedEntities<QuickCampaign>("bulkoperation_owner_ownerid", null); }
			set { SetRelatedEntities("bulkoperation_owner_ownerid", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'campaignactivity_owner_ownerid'
        /// </summary>
		[RelationshipSchemaName("campaignactivity_owner_ownerid")]
		public IEnumerable<CampaignActivity> CampaignactivityOwnerOwnerid
		{
			get { return GetRelatedEntities<CampaignActivity>("campaignactivity_owner_ownerid", null); }
			set { SetRelatedEntities("campaignactivity_owner_ownerid", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'campaignresponse_owner_ownerid'
        /// </summary>
		[RelationshipSchemaName("campaignresponse_owner_ownerid")]
		public IEnumerable<CampaignResponse> CampaignresponseOwnerOwnerid
		{
			get { return GetRelatedEntities<CampaignResponse>("campaignresponse_owner_ownerid", null); }
			set { SetRelatedEntities("campaignresponse_owner_ownerid", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'incidentresolution_owner_ownerid'
        /// </summary>
		[RelationshipSchemaName("incidentresolution_owner_ownerid")]
		public IEnumerable<CaseResolution> IncidentresolutionOwnerOwnerid
		{
			get { return GetRelatedEntities<CaseResolution>("incidentresolution_owner_ownerid", null); }
			set { SetRelatedEntities("incidentresolution_owner_ownerid", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'opportunityclose_owner_ownerid'
        /// </summary>
		[RelationshipSchemaName("opportunityclose_owner_ownerid")]
		public IEnumerable<OpportunityClose> OpportunitycloseOwnerOwnerid
		{
			get { return GetRelatedEntities<OpportunityClose>("opportunityclose_owner_ownerid", null); }
			set { SetRelatedEntities("opportunityclose_owner_ownerid", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'orderclose_owner_ownerid'
        /// </summary>
		[RelationshipSchemaName("orderclose_owner_ownerid")]
		public IEnumerable<OrderClose> OrdercloseOwnerOwnerid
		{
			get { return GetRelatedEntities<OrderClose>("orderclose_owner_ownerid", null); }
			set { SetRelatedEntities("orderclose_owner_ownerid", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'owner_accounts'
        /// </summary>
		[RelationshipSchemaName("owner_accounts")]
		public IEnumerable<Account> OwnerAccounts
		{
			get { return GetRelatedEntities<Account>("owner_accounts", null); }
			set { SetRelatedEntities("owner_accounts", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'owner_actioncards'
        /// </summary>
		[RelationshipSchemaName("owner_actioncards")]
		public IEnumerable<ActionCard> OwnerActioncards
		{
			get { return GetRelatedEntities<ActionCard>("owner_actioncards", null); }
			set { SetRelatedEntities("owner_actioncards", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'owner_activitymonitor'
        /// </summary>
		[RelationshipSchemaName("owner_activitymonitor")]
		public IEnumerable<ActivityMonitor> OwnerActivitymonitor
		{
			get { return GetRelatedEntities<ActivityMonitor>("owner_activitymonitor", null); }
			set { SetRelatedEntities("owner_activitymonitor", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'owner_activitypointers'
        /// </summary>
		[RelationshipSchemaName("owner_activitypointers")]
		public IEnumerable<Activity> OwnerActivitypointers
		{
			get { return GetRelatedEntities<Activity>("owner_activitypointers", null); }
			set { SetRelatedEntities("owner_activitypointers", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'owner_adminsettingsentity'
        /// </summary>
		[RelationshipSchemaName("owner_adminsettingsentity")]
		public IEnumerable<AdminSettingsEntity> OwnerAdminsettingsentity
		{
			get { return GetRelatedEntities<AdminSettingsEntity>("owner_adminsettingsentity", null); }
			set { SetRelatedEntities("owner_adminsettingsentity", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'owner_annotations'
        /// </summary>
		[RelationshipSchemaName("owner_annotations")]
		public IEnumerable<Note> OwnerAnnotations
		{
			get { return GetRelatedEntities<Note>("owner_annotations", null); }
			set { SetRelatedEntities("owner_annotations", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'owner_appointments'
        /// </summary>
		[RelationshipSchemaName("owner_appointments")]
		public IEnumerable<Appointment> OwnerAppointments
		{
			get { return GetRelatedEntities<Appointment>("owner_appointments", null); }
			set { SetRelatedEntities("owner_appointments", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'owner_asyncoperations'
        /// </summary>
		[RelationshipSchemaName("owner_asyncoperations")]
		public IEnumerable<SystemJob> OwnerAsyncoperations
		{
			get { return GetRelatedEntities<SystemJob>("owner_asyncoperations", null); }
			set { SetRelatedEntities("owner_asyncoperations", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'owner_bookableresource'
        /// </summary>
		[RelationshipSchemaName("owner_bookableresource")]
		public IEnumerable<BookableResource> OwnerBookableresource
		{
			get { return GetRelatedEntities<BookableResource>("owner_bookableresource", null); }
			set { SetRelatedEntities("owner_bookableresource", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'owner_bookableresourcebooking'
        /// </summary>
		[RelationshipSchemaName("owner_bookableresourcebooking")]
		public IEnumerable<BookableResourceBooking> OwnerBookableresourcebooking
		{
			get { return GetRelatedEntities<BookableResourceBooking>("owner_bookableresourcebooking", null); }
			set { SetRelatedEntities("owner_bookableresourcebooking", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'owner_bookableresourcebookingheader'
        /// </summary>
		[RelationshipSchemaName("owner_bookableresourcebookingheader")]
		public IEnumerable<BookableResourceBookingHeader> OwnerBookableresourcebookingheader
		{
			get { return GetRelatedEntities<BookableResourceBookingHeader>("owner_bookableresourcebookingheader", null); }
			set { SetRelatedEntities("owner_bookableresourcebookingheader", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'owner_bookableresourcecategory'
        /// </summary>
		[RelationshipSchemaName("owner_bookableresourcecategory")]
		public IEnumerable<BookableResourceCategory> OwnerBookableresourcecategory
		{
			get { return GetRelatedEntities<BookableResourceCategory>("owner_bookableresourcecategory", null); }
			set { SetRelatedEntities("owner_bookableresourcecategory", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'owner_bookableresourcecategoryassn'
        /// </summary>
		[RelationshipSchemaName("owner_bookableresourcecategoryassn")]
		public IEnumerable<BookableResourceCategoryAssn> OwnerBookableresourcecategoryassn
		{
			get { return GetRelatedEntities<BookableResourceCategoryAssn>("owner_bookableresourcecategoryassn", null); }
			set { SetRelatedEntities("owner_bookableresourcecategoryassn", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'owner_bookableresourcecharacteristic'
        /// </summary>
		[RelationshipSchemaName("owner_bookableresourcecharacteristic")]
		public IEnumerable<BookableResourceCharacteristic> OwnerBookableresourcecharacteristic
		{
			get { return GetRelatedEntities<BookableResourceCharacteristic>("owner_bookableresourcecharacteristic", null); }
			set { SetRelatedEntities("owner_bookableresourcecharacteristic", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'owner_bookableresourcegroup'
        /// </summary>
		[RelationshipSchemaName("owner_bookableresourcegroup")]
		public IEnumerable<BookableResourceGroup> OwnerBookableresourcegroup
		{
			get { return GetRelatedEntities<BookableResourceGroup>("owner_bookableresourcegroup", null); }
			set { SetRelatedEntities("owner_bookableresourcegroup", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'owner_bookingstatus'
        /// </summary>
		[RelationshipSchemaName("owner_bookingstatus")]
		public IEnumerable<BookingStatus> OwnerBookingstatus
		{
			get { return GetRelatedEntities<BookingStatus>("owner_bookingstatus", null); }
			set { SetRelatedEntities("owner_bookingstatus", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'owner_bot'
        /// </summary>
		[RelationshipSchemaName("owner_bot")]
		public IEnumerable<Chatbot> OwnerBot
		{
			get { return GetRelatedEntities<Chatbot>("owner_bot", null); }
			set { SetRelatedEntities("owner_bot", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'owner_botcomponent'
        /// </summary>
		[RelationshipSchemaName("owner_botcomponent")]
		public IEnumerable<ChatbotSubcomponent> OwnerBotcomponent
		{
			get { return GetRelatedEntities<ChatbotSubcomponent>("owner_botcomponent", null); }
			set { SetRelatedEntities("owner_botcomponent", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'owner_callbackregistration'
        /// </summary>
		[RelationshipSchemaName("owner_callbackregistration")]
		public IEnumerable<CallbackRegistration> OwnerCallbackregistration
		{
			get { return GetRelatedEntities<CallbackRegistration>("owner_callbackregistration", null); }
			set { SetRelatedEntities("owner_callbackregistration", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'owner_campaigns'
        /// </summary>
		[RelationshipSchemaName("owner_campaigns")]
		public IEnumerable<Campaign> OwnerCampaigns
		{
			get { return GetRelatedEntities<Campaign>("owner_campaigns", null); }
			set { SetRelatedEntities("owner_campaigns", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'owner_canvasapp'
        /// </summary>
		[RelationshipSchemaName("owner_canvasapp")]
		public IEnumerable<CanvasApp> OwnerCanvasapp
		{
			get { return GetRelatedEntities<CanvasApp>("owner_canvasapp", null); }
			set { SetRelatedEntities("owner_canvasapp", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'owner_categories'
        /// </summary>
		[RelationshipSchemaName("owner_categories")]
		public IEnumerable<Category> OwnerCategories
		{
			get { return GetRelatedEntities<Category>("owner_categories", null); }
			set { SetRelatedEntities("owner_categories", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'owner_characteristic'
        /// </summary>
		[RelationshipSchemaName("owner_characteristic")]
		public IEnumerable<Characteristic> OwnerCharacteristic
		{
			get { return GetRelatedEntities<Characteristic>("owner_characteristic", null); }
			set { SetRelatedEntities("owner_characteristic", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'owner_connectionreference'
        /// </summary>
		[RelationshipSchemaName("owner_connectionreference")]
		public IEnumerable<ConnectionReference> OwnerConnectionreference
		{
			get { return GetRelatedEntities<ConnectionReference>("owner_connectionreference", null); }
			set { SetRelatedEntities("owner_connectionreference", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'owner_connections'
        /// </summary>
		[RelationshipSchemaName("owner_connections")]
		public IEnumerable<Connection> OwnerConnections
		{
			get { return GetRelatedEntities<Connection>("owner_connections", null); }
			set { SetRelatedEntities("owner_connections", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'owner_connector'
        /// </summary>
		[RelationshipSchemaName("owner_connector")]
		public IEnumerable<Connector> OwnerConnector
		{
			get { return GetRelatedEntities<Connector>("owner_connector", null); }
			set { SetRelatedEntities("owner_connector", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'owner_contacts'
        /// </summary>
		[RelationshipSchemaName("owner_contacts")]
		public IEnumerable<Contact> OwnerContacts
		{
			get { return GetRelatedEntities<Contact>("owner_contacts", null); }
			set { SetRelatedEntities("owner_contacts", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'owner_contracts'
        /// </summary>
		[RelationshipSchemaName("owner_contracts")]
		public IEnumerable<Contract> OwnerContracts
		{
			get { return GetRelatedEntities<Contract>("owner_contracts", null); }
			set { SetRelatedEntities("owner_contracts", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'owner_conversationtranscript'
        /// </summary>
		[RelationshipSchemaName("owner_conversationtranscript")]
		public IEnumerable<ConversationTranscript> OwnerConversationtranscript
		{
			get { return GetRelatedEntities<ConversationTranscript>("owner_conversationtranscript", null); }
			set { SetRelatedEntities("owner_conversationtranscript", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'owner_customapi'
        /// </summary>
		[RelationshipSchemaName("owner_customapi")]
		public IEnumerable<CustomAPI> OwnerCustomapi
		{
			get { return GetRelatedEntities<CustomAPI>("owner_customapi", null); }
			set { SetRelatedEntities("owner_customapi", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'owner_customapirequestparameter'
        /// </summary>
		[RelationshipSchemaName("owner_customapirequestparameter")]
		public IEnumerable<CustomAPIRequestParameter> OwnerCustomapirequestparameter
		{
			get { return GetRelatedEntities<CustomAPIRequestParameter>("owner_customapirequestparameter", null); }
			set { SetRelatedEntities("owner_customapirequestparameter", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'owner_customapiresponseproperty'
        /// </summary>
		[RelationshipSchemaName("owner_customapiresponseproperty")]
		public IEnumerable<CustomAPIResponseProperty> OwnerCustomapiresponseproperty
		{
			get { return GetRelatedEntities<CustomAPIResponseProperty>("owner_customapiresponseproperty", null); }
			set { SetRelatedEntities("owner_customapiresponseproperty", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'owner_datalakefolder'
        /// </summary>
		[RelationshipSchemaName("owner_datalakefolder")]
		public IEnumerable<DataLakeFolder> OwnerDatalakefolder
		{
			get { return GetRelatedEntities<DataLakeFolder>("owner_datalakefolder", null); }
			set { SetRelatedEntities("owner_datalakefolder", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'owner_datalakefolderpermission'
        /// </summary>
		[RelationshipSchemaName("owner_datalakefolderpermission")]
		public IEnumerable<DataLakeFolderPermission> OwnerDatalakefolderpermission
		{
			get { return GetRelatedEntities<DataLakeFolderPermission>("owner_datalakefolderpermission", null); }
			set { SetRelatedEntities("owner_datalakefolderpermission", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'owner_duplicaterules'
        /// </summary>
		[RelationshipSchemaName("owner_duplicaterules")]
		public IEnumerable<DuplicateDetectionRule> OwnerDuplicaterules
		{
			get { return GetRelatedEntities<DuplicateDetectionRule>("owner_duplicaterules", null); }
			set { SetRelatedEntities("owner_duplicaterules", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'Owner_dynamicproperyinstance'
        /// </summary>
		[RelationshipSchemaName("Owner_dynamicproperyinstance")]
		public IEnumerable<PropertyInstance> OwnerDynamicproperyinstance
		{
			get { return GetRelatedEntities<PropertyInstance>("Owner_dynamicproperyinstance", null); }
			set { SetRelatedEntities("Owner_dynamicproperyinstance", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'owner_emails'
        /// </summary>
		[RelationshipSchemaName("owner_emails")]
		public IEnumerable<Email> OwnerEmails
		{
			get { return GetRelatedEntities<Email>("owner_emails", null); }
			set { SetRelatedEntities("owner_emails", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'owner_emailserverprofile'
        /// </summary>
		[RelationshipSchemaName("owner_emailserverprofile")]
		public IEnumerable<EmailServerProfile> OwnerEmailserverprofile
		{
			get { return GetRelatedEntities<EmailServerProfile>("owner_emailserverprofile", null); }
			set { SetRelatedEntities("owner_emailserverprofile", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'owner_entitlement'
        /// </summary>
		[RelationshipSchemaName("owner_entitlement")]
		public IEnumerable<Entitlement> OwnerEntitlement
		{
			get { return GetRelatedEntities<Entitlement>("owner_entitlement", null); }
			set { SetRelatedEntities("owner_entitlement", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'owner_entitlemententityallocationtypemapping'
        /// </summary>
		[RelationshipSchemaName("owner_entitlemententityallocationtypemapping")]
		public IEnumerable<EntitlementEntityAllocationTypeMapping> OwnerEntitlemententityallocationtypemapping
		{
			get { return GetRelatedEntities<EntitlementEntityAllocationTypeMapping>("owner_entitlemententityallocationtypemapping", null); }
			set { SetRelatedEntities("owner_entitlemententityallocationtypemapping", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'owner_environmentvariabledefinition'
        /// </summary>
		[RelationshipSchemaName("owner_environmentvariabledefinition")]
		public IEnumerable<EnvironmentVariableDefinition> OwnerEnvironmentvariabledefinition
		{
			get { return GetRelatedEntities<EnvironmentVariableDefinition>("owner_environmentvariabledefinition", null); }
			set { SetRelatedEntities("owner_environmentvariabledefinition", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'owner_environmentvariablevalue'
        /// </summary>
		[RelationshipSchemaName("owner_environmentvariablevalue")]
		public IEnumerable<EnvironmentVariableValue> OwnerEnvironmentvariablevalue
		{
			get { return GetRelatedEntities<EnvironmentVariableValue>("owner_environmentvariablevalue", null); }
			set { SetRelatedEntities("owner_environmentvariablevalue", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'owner_exchangesyncidmapping'
        /// </summary>
		[RelationshipSchemaName("owner_exchangesyncidmapping")]
		public IEnumerable<ExchangeSyncIdMapping> OwnerExchangesyncidmapping
		{
			get { return GetRelatedEntities<ExchangeSyncIdMapping>("owner_exchangesyncidmapping", null); }
			set { SetRelatedEntities("owner_exchangesyncidmapping", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'owner_exportsolutionupload'
        /// </summary>
		[RelationshipSchemaName("owner_exportsolutionupload")]
		public IEnumerable<ExportSolutionUpload> OwnerExportsolutionupload
		{
			get { return GetRelatedEntities<ExportSolutionUpload>("owner_exportsolutionupload", null); }
			set { SetRelatedEntities("owner_exportsolutionupload", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'owner_faxes'
        /// </summary>
		[RelationshipSchemaName("owner_faxes")]
		public IEnumerable<Fax> OwnerFaxes
		{
			get { return GetRelatedEntities<Fax>("owner_faxes", null); }
			set { SetRelatedEntities("owner_faxes", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'owner_feedback'
        /// </summary>
		[RelationshipSchemaName("owner_feedback")]
		public IEnumerable<Feedback> OwnerFeedback
		{
			get { return GetRelatedEntities<Feedback>("owner_feedback", null); }
			set { SetRelatedEntities("owner_feedback", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'owner_flowsession'
        /// </summary>
		[RelationshipSchemaName("owner_flowsession")]
		public IEnumerable<FlowSession> OwnerFlowsession
		{
			get { return GetRelatedEntities<FlowSession>("owner_flowsession", null); }
			set { SetRelatedEntities("owner_flowsession", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'owner_goal'
        /// </summary>
		[RelationshipSchemaName("owner_goal")]
		public IEnumerable<Goal> OwnerGoal
		{
			get { return GetRelatedEntities<Goal>("owner_goal", null); }
			set { SetRelatedEntities("owner_goal", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'owner_goalrollupquery'
        /// </summary>
		[RelationshipSchemaName("owner_goalrollupquery")]
		public IEnumerable<RollupQuery> OwnerGoalrollupquery
		{
			get { return GetRelatedEntities<RollupQuery>("owner_goalrollupquery", null); }
			set { SetRelatedEntities("owner_goalrollupquery", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'owner_importdatas'
        /// </summary>
		[RelationshipSchemaName("owner_importdatas")]
		public IEnumerable<ImportData> OwnerImportdatas
		{
			get { return GetRelatedEntities<ImportData>("owner_importdatas", null); }
			set { SetRelatedEntities("owner_importdatas", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'owner_importfiles'
        /// </summary>
		[RelationshipSchemaName("owner_importfiles")]
		public IEnumerable<ImportSourceFile> OwnerImportfiles
		{
			get { return GetRelatedEntities<ImportSourceFile>("owner_importfiles", null); }
			set { SetRelatedEntities("owner_importfiles", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'owner_importlogs'
        /// </summary>
		[RelationshipSchemaName("owner_importlogs")]
		public IEnumerable<ImportLog> OwnerImportlogs
		{
			get { return GetRelatedEntities<ImportLog>("owner_importlogs", null); }
			set { SetRelatedEntities("owner_importlogs", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'owner_importmaps'
        /// </summary>
		[RelationshipSchemaName("owner_importmaps")]
		public IEnumerable<DataMap> OwnerImportmaps
		{
			get { return GetRelatedEntities<DataMap>("owner_importmaps", null); }
			set { SetRelatedEntities("owner_importmaps", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'owner_imports'
        /// </summary>
		[RelationshipSchemaName("owner_imports")]
		public IEnumerable<DataImport> OwnerImports
		{
			get { return GetRelatedEntities<DataImport>("owner_imports", null); }
			set { SetRelatedEntities("owner_imports", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'owner_incidents'
        /// </summary>
		[RelationshipSchemaName("owner_incidents")]
		public IEnumerable<Case> OwnerIncidents
		{
			get { return GetRelatedEntities<Case>("owner_incidents", null); }
			set { SetRelatedEntities("owner_incidents", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'owner_interactionforemail'
        /// </summary>
		[RelationshipSchemaName("owner_interactionforemail")]
		public IEnumerable<InteractionForEmail> OwnerInteractionforemail
		{
			get { return GetRelatedEntities<InteractionForEmail>("owner_interactionforemail", null); }
			set { SetRelatedEntities("owner_interactionforemail", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'owner_invoices'
        /// </summary>
		[RelationshipSchemaName("owner_invoices")]
		public IEnumerable<Invoice> OwnerInvoices
		{
			get { return GetRelatedEntities<Invoice>("owner_invoices", null); }
			set { SetRelatedEntities("owner_invoices", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'owner_knowledgearticle'
        /// </summary>
		[RelationshipSchemaName("owner_knowledgearticle")]
		public IEnumerable<KnowledgeArticle> OwnerKnowledgearticle
		{
			get { return GetRelatedEntities<KnowledgeArticle>("owner_knowledgearticle", null); }
			set { SetRelatedEntities("owner_knowledgearticle", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'owner_leads'
        /// </summary>
		[RelationshipSchemaName("owner_leads")]
		public IEnumerable<Lead> OwnerLeads
		{
			get { return GetRelatedEntities<Lead>("owner_leads", null); }
			set { SetRelatedEntities("owner_leads", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'owner_letters'
        /// </summary>
		[RelationshipSchemaName("owner_letters")]
		public IEnumerable<Letter> OwnerLetters
		{
			get { return GetRelatedEntities<Letter>("owner_letters", null); }
			set { SetRelatedEntities("owner_letters", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'owner_listoperation'
        /// </summary>
		[RelationshipSchemaName("owner_listoperation")]
		public IEnumerable<ListOperation> OwnerListoperation
		{
			get { return GetRelatedEntities<ListOperation>("owner_listoperation", null); }
			set { SetRelatedEntities("owner_listoperation", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'owner_lists'
        /// </summary>
		[RelationshipSchemaName("owner_lists")]
		public IEnumerable<MarketingList> OwnerLists
		{
			get { return GetRelatedEntities<MarketingList>("owner_lists", null); }
			set { SetRelatedEntities("owner_lists", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'owner_mailbox'
        /// </summary>
		[RelationshipSchemaName("owner_mailbox")]
		public IEnumerable<Mailbox> OwnerMailbox
		{
			get { return GetRelatedEntities<Mailbox>("owner_mailbox", null); }
			set { SetRelatedEntities("owner_mailbox", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'owner_mailboxtrackingfolder'
        /// </summary>
		[RelationshipSchemaName("owner_mailboxtrackingfolder")]
		public IEnumerable<MailboxAutoTrackingFolder> OwnerMailboxtrackingfolder
		{
			get { return GetRelatedEntities<MailboxAutoTrackingFolder>("owner_mailboxtrackingfolder", null); }
			set { SetRelatedEntities("owner_mailboxtrackingfolder", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'owner_mailmergetemplates'
        /// </summary>
		[RelationshipSchemaName("owner_mailmergetemplates")]
		public IEnumerable<MailMergeTemplate> OwnerMailmergetemplates
		{
			get { return GetRelatedEntities<MailMergeTemplate>("owner_mailmergetemplates", null); }
			set { SetRelatedEntities("owner_mailmergetemplates", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'owner_msdyn_actioncardregarding'
        /// </summary>
		[RelationshipSchemaName("owner_msdyn_actioncardregarding")]
		public IEnumerable<ActionCardRegarding> OwnerMsdynActioncardregarding
		{
			get { return GetRelatedEntities<ActionCardRegarding>("owner_msdyn_actioncardregarding", null); }
			set { SetRelatedEntities("owner_msdyn_actioncardregarding", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'owner_msdyn_actioncardrolesetting'
        /// </summary>
		[RelationshipSchemaName("owner_msdyn_actioncardrolesetting")]
		public IEnumerable<ActionCardRoleSetting> OwnerMsdynActioncardrolesetting
		{
			get { return GetRelatedEntities<ActionCardRoleSetting>("owner_msdyn_actioncardrolesetting", null); }
			set { SetRelatedEntities("owner_msdyn_actioncardrolesetting", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'owner_msdyn_aibdataset'
        /// </summary>
		[RelationshipSchemaName("owner_msdyn_aibdataset")]
		public IEnumerable<AIBuilderDataset> OwnerMsdynAibdataset
		{
			get { return GetRelatedEntities<AIBuilderDataset>("owner_msdyn_aibdataset", null); }
			set { SetRelatedEntities("owner_msdyn_aibdataset", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'owner_msdyn_aibdatasetfile'
        /// </summary>
		[RelationshipSchemaName("owner_msdyn_aibdatasetfile")]
		public IEnumerable<AIBuilderDatasetFile> OwnerMsdynAibdatasetfile
		{
			get { return GetRelatedEntities<AIBuilderDatasetFile>("owner_msdyn_aibdatasetfile", null); }
			set { SetRelatedEntities("owner_msdyn_aibdatasetfile", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'owner_msdyn_aibdatasetrecord'
        /// </summary>
		[RelationshipSchemaName("owner_msdyn_aibdatasetrecord")]
		public IEnumerable<AIBuilderDatasetRecord> OwnerMsdynAibdatasetrecord
		{
			get { return GetRelatedEntities<AIBuilderDatasetRecord>("owner_msdyn_aibdatasetrecord", null); }
			set { SetRelatedEntities("owner_msdyn_aibdatasetrecord", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'owner_msdyn_aibdatasetscontainer'
        /// </summary>
		[RelationshipSchemaName("owner_msdyn_aibdatasetscontainer")]
		public IEnumerable<AIBuilderDatasetsContainer> OwnerMsdynAibdatasetscontainer
		{
			get { return GetRelatedEntities<AIBuilderDatasetsContainer>("owner_msdyn_aibdatasetscontainer", null); }
			set { SetRelatedEntities("owner_msdyn_aibdatasetscontainer", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'owner_msdyn_aibfile'
        /// </summary>
		[RelationshipSchemaName("owner_msdyn_aibfile")]
		public IEnumerable<AIBuilderFile> OwnerMsdynAibfile
		{
			get { return GetRelatedEntities<AIBuilderFile>("owner_msdyn_aibfile", null); }
			set { SetRelatedEntities("owner_msdyn_aibfile", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'owner_msdyn_aibfileattacheddata'
        /// </summary>
		[RelationshipSchemaName("owner_msdyn_aibfileattacheddata")]
		public IEnumerable<AIBuilderFileAttachedData> OwnerMsdynAibfileattacheddata
		{
			get { return GetRelatedEntities<AIBuilderFileAttachedData>("owner_msdyn_aibfileattacheddata", null); }
			set { SetRelatedEntities("owner_msdyn_aibfileattacheddata", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'owner_msdyn_aiconfiguration'
        /// </summary>
		[RelationshipSchemaName("owner_msdyn_aiconfiguration")]
		public IEnumerable<AIConfiguration> OwnerMsdynAiconfiguration
		{
			get { return GetRelatedEntities<AIConfiguration>("owner_msdyn_aiconfiguration", null); }
			set { SetRelatedEntities("owner_msdyn_aiconfiguration", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'owner_msdyn_aifptrainingdocument'
        /// </summary>
		[RelationshipSchemaName("owner_msdyn_aifptrainingdocument")]
		public IEnumerable<AIFormProcessingDocument> OwnerMsdynAifptrainingdocument
		{
			get { return GetRelatedEntities<AIFormProcessingDocument>("owner_msdyn_aifptrainingdocument", null); }
			set { SetRelatedEntities("owner_msdyn_aifptrainingdocument", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'owner_msdyn_aimodel'
        /// </summary>
		[RelationshipSchemaName("owner_msdyn_aimodel")]
		public IEnumerable<AIModel> OwnerMsdynAimodel
		{
			get { return GetRelatedEntities<AIModel>("owner_msdyn_aimodel", null); }
			set { SetRelatedEntities("owner_msdyn_aimodel", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'owner_msdyn_aiodimage'
        /// </summary>
		[RelationshipSchemaName("owner_msdyn_aiodimage")]
		public IEnumerable<AIObjectDetectionImage> OwnerMsdynAiodimage
		{
			get { return GetRelatedEntities<AIObjectDetectionImage>("owner_msdyn_aiodimage", null); }
			set { SetRelatedEntities("owner_msdyn_aiodimage", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'owner_msdyn_aiodlabel'
        /// </summary>
		[RelationshipSchemaName("owner_msdyn_aiodlabel")]
		public IEnumerable<AIObjectDetectionLabel> OwnerMsdynAiodlabel
		{
			get { return GetRelatedEntities<AIObjectDetectionLabel>("owner_msdyn_aiodlabel", null); }
			set { SetRelatedEntities("owner_msdyn_aiodlabel", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'owner_msdyn_aiodtrainingboundingbox'
        /// </summary>
		[RelationshipSchemaName("owner_msdyn_aiodtrainingboundingbox")]
		public IEnumerable<AIObjectDetectionBoundingBox> OwnerMsdynAiodtrainingboundingbox
		{
			get { return GetRelatedEntities<AIObjectDetectionBoundingBox>("owner_msdyn_aiodtrainingboundingbox", null); }
			set { SetRelatedEntities("owner_msdyn_aiodtrainingboundingbox", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'owner_msdyn_aiodtrainingimage'
        /// </summary>
		[RelationshipSchemaName("owner_msdyn_aiodtrainingimage")]
		public IEnumerable<AIObjectDetectionImageMapping> OwnerMsdynAiodtrainingimage
		{
			get { return GetRelatedEntities<AIObjectDetectionImageMapping>("owner_msdyn_aiodtrainingimage", null); }
			set { SetRelatedEntities("owner_msdyn_aiodtrainingimage", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'owner_msdyn_aitemplate'
        /// </summary>
		[RelationshipSchemaName("owner_msdyn_aitemplate")]
		public IEnumerable<AITemplate> OwnerMsdynAitemplate
		{
			get { return GetRelatedEntities<AITemplate>("owner_msdyn_aitemplate", null); }
			set { SetRelatedEntities("owner_msdyn_aitemplate", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'owner_msdyn_autocapturerule'
        /// </summary>
		[RelationshipSchemaName("owner_msdyn_autocapturerule")]
		public IEnumerable<AutoCaptureRule> OwnerMsdynAutocapturerule
		{
			get { return GetRelatedEntities<AutoCaptureRule>("owner_msdyn_autocapturerule", null); }
			set { SetRelatedEntities("owner_msdyn_autocapturerule", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'owner_msdyn_autocapturesettings'
        /// </summary>
		[RelationshipSchemaName("owner_msdyn_autocapturesettings")]
		public IEnumerable<AutoCaptureSettings> OwnerMsdynAutocapturesettings
		{
			get { return GetRelatedEntities<AutoCaptureSettings>("owner_msdyn_autocapturesettings", null); }
			set { SetRelatedEntities("owner_msdyn_autocapturesettings", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'owner_msdyn_callablecontext'
        /// </summary>
		[RelationshipSchemaName("owner_msdyn_callablecontext")]
		public IEnumerable<PlaybookCallableContext> OwnerMsdynCallablecontext
		{
			get { return GetRelatedEntities<PlaybookCallableContext>("owner_msdyn_callablecontext", null); }
			set { SetRelatedEntities("owner_msdyn_callablecontext", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'owner_msdyn_entityrankingrule'
        /// </summary>
		[RelationshipSchemaName("owner_msdyn_entityrankingrule")]
		public IEnumerable<EntityRankingRule> OwnerMsdynEntityrankingrule
		{
			get { return GetRelatedEntities<EntityRankingRule>("owner_msdyn_entityrankingrule", null); }
			set { SetRelatedEntities("owner_msdyn_entityrankingrule", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'owner_msdyn_federatedarticle'
        /// </summary>
		[RelationshipSchemaName("owner_msdyn_federatedarticle")]
		public IEnumerable<KnowledgeFederatedArticle> OwnerMsdynFederatedarticle
		{
			get { return GetRelatedEntities<KnowledgeFederatedArticle>("owner_msdyn_federatedarticle", null); }
			set { SetRelatedEntities("owner_msdyn_federatedarticle", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'owner_msdyn_flowcardtype'
        /// </summary>
		[RelationshipSchemaName("owner_msdyn_flowcardtype")]
		public IEnumerable<Flowcardtype> OwnerMsdynFlowcardtype
		{
			get { return GetRelatedEntities<Flowcardtype>("owner_msdyn_flowcardtype", null); }
			set { SetRelatedEntities("owner_msdyn_flowcardtype", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'owner_msdyn_icebreakersconfig'
        /// </summary>
		[RelationshipSchemaName("owner_msdyn_icebreakersconfig")]
		public IEnumerable<Icebreakersconfig> OwnerMsdynIcebreakersconfig
		{
			get { return GetRelatedEntities<Icebreakersconfig>("owner_msdyn_icebreakersconfig", null); }
			set { SetRelatedEntities("owner_msdyn_icebreakersconfig", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'owner_msdyn_kmfederatedsearchconfig'
        /// </summary>
		[RelationshipSchemaName("owner_msdyn_kmfederatedsearchconfig")]
		public IEnumerable<SearchProvider> OwnerMsdynKmfederatedsearchconfig
		{
			get { return GetRelatedEntities<SearchProvider>("owner_msdyn_kmfederatedsearchconfig", null); }
			set { SetRelatedEntities("owner_msdyn_kmfederatedsearchconfig", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'owner_msdyn_knowledgearticleimage'
        /// </summary>
		[RelationshipSchemaName("owner_msdyn_knowledgearticleimage")]
		public IEnumerable<KnowledgeArticleImage> OwnerMsdynKnowledgearticleimage
		{
			get { return GetRelatedEntities<KnowledgeArticleImage>("owner_msdyn_knowledgearticleimage", null); }
			set { SetRelatedEntities("owner_msdyn_knowledgearticleimage", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'owner_msdyn_knowledgearticletemplate'
        /// </summary>
		[RelationshipSchemaName("owner_msdyn_knowledgearticletemplate")]
		public IEnumerable<KnowledgeArticleTemplate> OwnerMsdynKnowledgearticletemplate
		{
			get { return GetRelatedEntities<KnowledgeArticleTemplate>("owner_msdyn_knowledgearticletemplate", null); }
			set { SetRelatedEntities("owner_msdyn_knowledgearticletemplate", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'owner_msdyn_knowledgeinteractioninsight'
        /// </summary>
		[RelationshipSchemaName("owner_msdyn_knowledgeinteractioninsight")]
		public IEnumerable<KnowledgeInteractionInsight> OwnerMsdynKnowledgeinteractioninsight
		{
			get { return GetRelatedEntities<KnowledgeInteractionInsight>("owner_msdyn_knowledgeinteractioninsight", null); }
			set { SetRelatedEntities("owner_msdyn_knowledgeinteractioninsight", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'owner_msdyn_knowledgesearchinsight'
        /// </summary>
		[RelationshipSchemaName("owner_msdyn_knowledgesearchinsight")]
		public IEnumerable<KnowledgeSearchInsight> OwnerMsdynKnowledgesearchinsight
		{
			get { return GetRelatedEntities<KnowledgeSearchInsight>("owner_msdyn_knowledgesearchinsight", null); }
			set { SetRelatedEntities("owner_msdyn_knowledgesearchinsight", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'owner_msdyn_msteamssetting'
        /// </summary>
		[RelationshipSchemaName("owner_msdyn_msteamssetting")]
		public IEnumerable<MsdynMsteamssetting> OwnerMsdynMsteamssetting
		{
			get { return GetRelatedEntities<MsdynMsteamssetting>("owner_msdyn_msteamssetting", null); }
			set { SetRelatedEntities("owner_msdyn_msteamssetting", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'owner_msdyn_notesanalysisconfig'
        /// </summary>
		[RelationshipSchemaName("owner_msdyn_notesanalysisconfig")]
		public IEnumerable<NotesAnalysisConfig> OwnerMsdynNotesanalysisconfig
		{
			get { return GetRelatedEntities<NotesAnalysisConfig>("owner_msdyn_notesanalysisconfig", null); }
			set { SetRelatedEntities("owner_msdyn_notesanalysisconfig", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'owner_msdyn_playbookactivity'
        /// </summary>
		[RelationshipSchemaName("owner_msdyn_playbookactivity")]
		public IEnumerable<PlaybookActivity> OwnerMsdynPlaybookactivity
		{
			get { return GetRelatedEntities<PlaybookActivity>("owner_msdyn_playbookactivity", null); }
			set { SetRelatedEntities("owner_msdyn_playbookactivity", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'owner_msdyn_playbookactivityattribute'
        /// </summary>
		[RelationshipSchemaName("owner_msdyn_playbookactivityattribute")]
		public IEnumerable<PlaybookActivityAttribute> OwnerMsdynPlaybookactivityattribute
		{
			get { return GetRelatedEntities<PlaybookActivityAttribute>("owner_msdyn_playbookactivityattribute", null); }
			set { SetRelatedEntities("owner_msdyn_playbookactivityattribute", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'owner_msdyn_playbookcategory'
        /// </summary>
		[RelationshipSchemaName("owner_msdyn_playbookcategory")]
		public IEnumerable<PlaybookCategory> OwnerMsdynPlaybookcategory
		{
			get { return GetRelatedEntities<PlaybookCategory>("owner_msdyn_playbookcategory", null); }
			set { SetRelatedEntities("owner_msdyn_playbookcategory", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'owner_msdyn_playbookinstance'
        /// </summary>
		[RelationshipSchemaName("owner_msdyn_playbookinstance")]
		public IEnumerable<Playbook> OwnerMsdynPlaybookinstance
		{
			get { return GetRelatedEntities<Playbook>("owner_msdyn_playbookinstance", null); }
			set { SetRelatedEntities("owner_msdyn_playbookinstance", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'owner_msdyn_playbooktemplate'
        /// </summary>
		[RelationshipSchemaName("owner_msdyn_playbooktemplate")]
		public IEnumerable<PlaybookTemplate> OwnerMsdynPlaybooktemplate
		{
			get { return GetRelatedEntities<PlaybookTemplate>("owner_msdyn_playbooktemplate", null); }
			set { SetRelatedEntities("owner_msdyn_playbooktemplate", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'owner_msdyn_postalbum'
        /// </summary>
		[RelationshipSchemaName("owner_msdyn_postalbum")]
		public IEnumerable<ProfileAlbum> OwnerMsdynPostalbum
		{
			get { return GetRelatedEntities<ProfileAlbum>("owner_msdyn_postalbum", null); }
			set { SetRelatedEntities("owner_msdyn_postalbum", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'owner_msdyn_relationshipinsightsunifiedconfig'
        /// </summary>
		[RelationshipSchemaName("owner_msdyn_relationshipinsightsunifiedconfig")]
		public IEnumerable<MsdynRelationshipinsightsunifiedconfig> OwnerMsdynRelationshipinsightsunifiedconfig
		{
			get { return GetRelatedEntities<MsdynRelationshipinsightsunifiedconfig>("owner_msdyn_relationshipinsightsunifiedconfig", null); }
			set { SetRelatedEntities("owner_msdyn_relationshipinsightsunifiedconfig", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'owner_msdyn_richtextfile'
        /// </summary>
		[RelationshipSchemaName("owner_msdyn_richtextfile")]
		public IEnumerable<RichTextAttachment> OwnerMsdynRichtextfile
		{
			get { return GetRelatedEntities<RichTextAttachment>("owner_msdyn_richtextfile", null); }
			set { SetRelatedEntities("owner_msdyn_richtextfile", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'owner_msdyn_salesinsightssettings'
        /// </summary>
		[RelationshipSchemaName("owner_msdyn_salesinsightssettings")]
		public IEnumerable<Salesinsightssettings> OwnerMsdynSalesinsightssettings
		{
			get { return GetRelatedEntities<Salesinsightssettings>("owner_msdyn_salesinsightssettings", null); }
			set { SetRelatedEntities("owner_msdyn_salesinsightssettings", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'owner_msdyn_siconfig'
        /// </summary>
		[RelationshipSchemaName("owner_msdyn_siconfig")]
		public IEnumerable<Siconfig> OwnerMsdynSiconfig
		{
			get { return GetRelatedEntities<Siconfig>("owner_msdyn_siconfig", null); }
			set { SetRelatedEntities("owner_msdyn_siconfig", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'owner_msdyn_untrackedappointment'
        /// </summary>
		[RelationshipSchemaName("owner_msdyn_untrackedappointment")]
		public IEnumerable<UntrackedAppointment> OwnerMsdynUntrackedappointment
		{
			get { return GetRelatedEntities<UntrackedAppointment>("owner_msdyn_untrackedappointment", null); }
			set { SetRelatedEntities("owner_msdyn_untrackedappointment", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'owner_msdyn_wallsavedqueryusersettings'
        /// </summary>
		[RelationshipSchemaName("owner_msdyn_wallsavedqueryusersettings")]
		public IEnumerable<Filter> OwnerMsdynWallsavedqueryusersettings
		{
			get { return GetRelatedEntities<Filter>("owner_msdyn_wallsavedqueryusersettings", null); }
			set { SetRelatedEntities("owner_msdyn_wallsavedqueryusersettings", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'owner_msdynce_botcontent'
        /// </summary>
		[RelationshipSchemaName("owner_msdynce_botcontent")]
		public IEnumerable<BotContent> OwnerMsdynceBotcontent
		{
			get { return GetRelatedEntities<BotContent>("owner_msdynce_botcontent", null); }
			set { SetRelatedEntities("owner_msdynce_botcontent", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'owner_opportunitys'
        /// </summary>
		[RelationshipSchemaName("owner_opportunitys")]
		public IEnumerable<Opportunity> OwnerOpportunitys
		{
			get { return GetRelatedEntities<Opportunity>("owner_opportunitys", null); }
			set { SetRelatedEntities("owner_opportunitys", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'owner_personaldocumenttemplates'
        /// </summary>
		[RelationshipSchemaName("owner_personaldocumenttemplates")]
		public IEnumerable<PersonalDocumentTemplate> OwnerPersonaldocumenttemplates
		{
			get { return GetRelatedEntities<PersonalDocumentTemplate>("owner_personaldocumenttemplates", null); }
			set { SetRelatedEntities("owner_personaldocumenttemplates", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'owner_phonecalls'
        /// </summary>
		[RelationshipSchemaName("owner_phonecalls")]
		public IEnumerable<PhoneCall> OwnerPhonecalls
		{
			get { return GetRelatedEntities<PhoneCall>("owner_phonecalls", null); }
			set { SetRelatedEntities("owner_phonecalls", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'owner_postfollows'
        /// </summary>
		[RelationshipSchemaName("owner_postfollows")]
		public IEnumerable<Follow> OwnerPostfollows
		{
			get { return GetRelatedEntities<Follow>("owner_postfollows", null); }
			set { SetRelatedEntities("owner_postfollows", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'owner_processsessions'
        /// </summary>
		[RelationshipSchemaName("owner_processsessions")]
		public IEnumerable<ProcessSession> OwnerProcesssessions
		{
			get { return GetRelatedEntities<ProcessSession>("owner_processsessions", null); }
			set { SetRelatedEntities("owner_processsessions", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'owner_processstageparameter'
        /// </summary>
		[RelationshipSchemaName("owner_processstageparameter")]
		public IEnumerable<ProcessStageParameter> OwnerProcessstageparameter
		{
			get { return GetRelatedEntities<ProcessStageParameter>("owner_processstageparameter", null); }
			set { SetRelatedEntities("owner_processstageparameter", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'owner_pw_penta_schedule_run'
        /// </summary>
		[RelationshipSchemaName("owner_pw_penta_schedule_run")]
		public IEnumerable<PentaScheduleRun> OwnerPwPentaScheduleRun
		{
			get { return GetRelatedEntities<PentaScheduleRun>("owner_pw_penta_schedule_run", null); }
			set { SetRelatedEntities("owner_pw_penta_schedule_run", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'owner_pw_schedule'
        /// </summary>
		[RelationshipSchemaName("owner_pw_schedule")]
		public IEnumerable<PentaSchedule> OwnerPwSchedule
		{
			get { return GetRelatedEntities<PentaSchedule>("owner_pw_schedule", null); }
			set { SetRelatedEntities("owner_pw_schedule", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'owner_queues'
        /// </summary>
		[RelationshipSchemaName("owner_queues")]
		public IEnumerable<Queue> OwnerQueues
		{
			get { return GetRelatedEntities<Queue>("owner_queues", null); }
			set { SetRelatedEntities("owner_queues", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'owner_quotes'
        /// </summary>
		[RelationshipSchemaName("owner_quotes")]
		public IEnumerable<Quote> OwnerQuotes
		{
			get { return GetRelatedEntities<Quote>("owner_quotes", null); }
			set { SetRelatedEntities("owner_quotes", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'owner_ratingmodel'
        /// </summary>
		[RelationshipSchemaName("owner_ratingmodel")]
		public IEnumerable<RatingModel> OwnerRatingmodel
		{
			get { return GetRelatedEntities<RatingModel>("owner_ratingmodel", null); }
			set { SetRelatedEntities("owner_ratingmodel", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'owner_ratingvalue'
        /// </summary>
		[RelationshipSchemaName("owner_ratingvalue")]
		public IEnumerable<RatingValue> OwnerRatingvalue
		{
			get { return GetRelatedEntities<RatingValue>("owner_ratingvalue", null); }
			set { SetRelatedEntities("owner_ratingvalue", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'owner_recurrencerules'
        /// </summary>
		[RelationshipSchemaName("owner_recurrencerules")]
		public IEnumerable<RecurrenceRule> OwnerRecurrencerules
		{
			get { return GetRelatedEntities<RecurrenceRule>("owner_recurrencerules", null); }
			set { SetRelatedEntities("owner_recurrencerules", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'owner_recurringappointmentmasters'
        /// </summary>
		[RelationshipSchemaName("owner_recurringappointmentmasters")]
		public IEnumerable<RecurringAppointment> OwnerRecurringappointmentmasters
		{
			get { return GetRelatedEntities<RecurringAppointment>("owner_recurringappointmentmasters", null); }
			set { SetRelatedEntities("owner_recurringappointmentmasters", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'owner_reports'
        /// </summary>
		[RelationshipSchemaName("owner_reports")]
		public IEnumerable<Report> OwnerReports
		{
			get { return GetRelatedEntities<Report>("owner_reports", null); }
			set { SetRelatedEntities("owner_reports", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'owner_salesorders'
        /// </summary>
		[RelationshipSchemaName("owner_salesorders")]
		public IEnumerable<Order> OwnerSalesorders
		{
			get { return GetRelatedEntities<Order>("owner_salesorders", null); }
			set { SetRelatedEntities("owner_salesorders", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'owner_sharepointdocumentlocation'
        /// </summary>
		[RelationshipSchemaName("owner_sharepointdocumentlocation")]
		public IEnumerable<DocumentLocation> OwnerSharepointdocumentlocation
		{
			get { return GetRelatedEntities<DocumentLocation>("owner_sharepointdocumentlocation", null); }
			set { SetRelatedEntities("owner_sharepointdocumentlocation", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'owner_sharepointsite'
        /// </summary>
		[RelationshipSchemaName("owner_sharepointsite")]
		public IEnumerable<SharePointSite> OwnerSharepointsite
		{
			get { return GetRelatedEntities<SharePointSite>("owner_sharepointsite", null); }
			set { SetRelatedEntities("owner_sharepointsite", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'owner_slas'
        /// </summary>
		[RelationshipSchemaName("owner_slas")]
		public IEnumerable<SLA> OwnerSlas
		{
			get { return GetRelatedEntities<SLA>("owner_slas", null); }
			set { SetRelatedEntities("owner_slas", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'owner_socialactivities'
        /// </summary>
		[RelationshipSchemaName("owner_socialactivities")]
		public IEnumerable<SocialActivity> OwnerSocialactivities
		{
			get { return GetRelatedEntities<SocialActivity>("owner_socialactivities", null); }
			set { SetRelatedEntities("owner_socialactivities", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'owner_SocialProfile'
        /// </summary>
		[RelationshipSchemaName("owner_SocialProfile")]
		public IEnumerable<SocialProfile> OwnerSocialProfile
		{
			get { return GetRelatedEntities<SocialProfile>("owner_SocialProfile", null); }
			set { SetRelatedEntities("owner_SocialProfile", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'owner_stagesolutionupload'
        /// </summary>
		[RelationshipSchemaName("owner_stagesolutionupload")]
		public IEnumerable<StageSolutionUpload> OwnerStagesolutionupload
		{
			get { return GetRelatedEntities<StageSolutionUpload>("owner_stagesolutionupload", null); }
			set { SetRelatedEntities("owner_stagesolutionupload", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'owner_SyncError'
        /// </summary>
		[RelationshipSchemaName("owner_SyncError")]
		public IEnumerable<SyncError> OwnerSyncError
		{
			get { return GetRelatedEntities<SyncError>("owner_SyncError", null); }
			set { SetRelatedEntities("owner_SyncError", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'owner_tasks'
        /// </summary>
		[RelationshipSchemaName("owner_tasks")]
		public IEnumerable<Task> OwnerTasks
		{
			get { return GetRelatedEntities<Task>("owner_tasks", null); }
			set { SetRelatedEntities("owner_tasks", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'owner_templates'
        /// </summary>
		[RelationshipSchemaName("owner_templates")]
		public IEnumerable<EmailTemplate> OwnerTemplates
		{
			get { return GetRelatedEntities<EmailTemplate>("owner_templates", null); }
			set { SetRelatedEntities("owner_templates", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'owner_userform'
        /// </summary>
		[RelationshipSchemaName("owner_userform")]
		public IEnumerable<UserDashboard> OwnerUserform
		{
			get { return GetRelatedEntities<UserDashboard>("owner_userform", null); }
			set { SetRelatedEntities("owner_userform", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'owner_userquerys'
        /// </summary>
		[RelationshipSchemaName("owner_userquerys")]
		public IEnumerable<SavedView> OwnerUserquerys
		{
			get { return GetRelatedEntities<SavedView>("owner_userquerys", null); }
			set { SetRelatedEntities("owner_userquerys", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'owner_userqueryvisualizations'
        /// </summary>
		[RelationshipSchemaName("owner_userqueryvisualizations")]
		public IEnumerable<UserChart> OwnerUserqueryvisualizations
		{
			get { return GetRelatedEntities<UserChart>("owner_userqueryvisualizations", null); }
			set { SetRelatedEntities("owner_userqueryvisualizations", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'owner_workflowbinary'
        /// </summary>
		[RelationshipSchemaName("owner_workflowbinary")]
		public IEnumerable<WorkflowBinary> OwnerWorkflowbinary
		{
			get { return GetRelatedEntities<WorkflowBinary>("owner_workflowbinary", null); }
			set { SetRelatedEntities("owner_workflowbinary", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'owner_workflows'
        /// </summary>
		[RelationshipSchemaName("owner_workflows")]
		public IEnumerable<Process> OwnerWorkflows
		{
			get { return GetRelatedEntities<Process>("owner_workflows", null); }
			set { SetRelatedEntities("owner_workflows", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'quoteclose_owner_ownerid'
        /// </summary>
		[RelationshipSchemaName("quoteclose_owner_ownerid")]
		public IEnumerable<QuoteClose> QuotecloseOwnerOwnerid
		{
			get { return GetRelatedEntities<QuoteClose>("quoteclose_owner_ownerid", null); }
			set { SetRelatedEntities("quoteclose_owner_ownerid", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'serviceappointment_owner_ownerid'
        /// </summary>
		[RelationshipSchemaName("serviceappointment_owner_ownerid")]
		public IEnumerable<ServiceActivity> ServiceappointmentOwnerOwnerid
		{
			get { return GetRelatedEntities<ServiceActivity>("serviceappointment_owner_ownerid", null); }
			set { SetRelatedEntities("serviceappointment_owner_ownerid", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'slakpiinstance_owner'
        /// </summary>
		[RelationshipSchemaName("slakpiinstance_owner")]
		public IEnumerable<SLAKPIInstance> SlakpiinstanceOwner
		{
			get { return GetRelatedEntities<SLAKPIInstance>("slakpiinstance_owner", null); }
			set { SetRelatedEntities("slakpiinstance_owner", null, value); }
		}
		#endregion

		#region Actions
		#endregion

		#region OptionSetEnums
		#endregion	

		#region Properties
		public static class Properties 
		{
			/// <summary>name</summary>
			public const string OwnerName = "name";

			/// <summary>ownerid</summary>
			public const string OwnerId = "ownerid";

			/// <summary>owneridtype</summary>
			public const string Owneridtype = "owneridtype";

			/// <summary>versionnumber</summary>
			public const string Versionnumber = "versionnumber";

			/// <summary>yominame</summary>
			public const string YomiName = "yominame";

		}
		#endregion

		#region Schemas
		public static class Schemas 
		{
			/// <summary>1:N ActionCardUserState_Owner</summary>
			public const string ActionCardUserStateOwner = "ActionCardUserState_Owner";

			/// <summary>1:N bulkoperation_owner_ownerid</summary>
			public const string BulkoperationOwnerOwnerid = "bulkoperation_owner_ownerid";

			/// <summary>1:N campaignactivity_owner_ownerid</summary>
			public const string CampaignactivityOwnerOwnerid = "campaignactivity_owner_ownerid";

			/// <summary>1:N campaignresponse_owner_ownerid</summary>
			public const string CampaignresponseOwnerOwnerid = "campaignresponse_owner_ownerid";

			/// <summary>1:N incidentresolution_owner_ownerid</summary>
			public const string IncidentresolutionOwnerOwnerid = "incidentresolution_owner_ownerid";

			/// <summary>1:N opportunityclose_owner_ownerid</summary>
			public const string OpportunitycloseOwnerOwnerid = "opportunityclose_owner_ownerid";

			/// <summary>1:N orderclose_owner_ownerid</summary>
			public const string OrdercloseOwnerOwnerid = "orderclose_owner_ownerid";

			/// <summary>1:N owner_accounts</summary>
			public const string OwnerAccounts = "owner_accounts";

			/// <summary>1:N owner_actioncards</summary>
			public const string OwnerActioncards = "owner_actioncards";

			/// <summary>1:N owner_activitymonitor</summary>
			public const string OwnerActivitymonitor = "owner_activitymonitor";

			/// <summary>1:N owner_activitypointers</summary>
			public const string OwnerActivitypointers = "owner_activitypointers";

			/// <summary>1:N owner_adminsettingsentity</summary>
			public const string OwnerAdminsettingsentity = "owner_adminsettingsentity";

			/// <summary>1:N owner_annotations</summary>
			public const string OwnerAnnotations = "owner_annotations";

			/// <summary>1:N owner_appointments</summary>
			public const string OwnerAppointments = "owner_appointments";

			/// <summary>1:N owner_asyncoperations</summary>
			public const string OwnerAsyncoperations = "owner_asyncoperations";

			/// <summary>1:N owner_bookableresource</summary>
			public const string OwnerBookableresource = "owner_bookableresource";

			/// <summary>1:N owner_bookableresourcebooking</summary>
			public const string OwnerBookableresourcebooking = "owner_bookableresourcebooking";

			/// <summary>1:N owner_bookableresourcebookingheader</summary>
			public const string OwnerBookableresourcebookingheader = "owner_bookableresourcebookingheader";

			/// <summary>1:N owner_bookableresourcecategory</summary>
			public const string OwnerBookableresourcecategory = "owner_bookableresourcecategory";

			/// <summary>1:N owner_bookableresourcecategoryassn</summary>
			public const string OwnerBookableresourcecategoryassn = "owner_bookableresourcecategoryassn";

			/// <summary>1:N owner_bookableresourcecharacteristic</summary>
			public const string OwnerBookableresourcecharacteristic = "owner_bookableresourcecharacteristic";

			/// <summary>1:N owner_bookableresourcegroup</summary>
			public const string OwnerBookableresourcegroup = "owner_bookableresourcegroup";

			/// <summary>1:N owner_bookingstatus</summary>
			public const string OwnerBookingstatus = "owner_bookingstatus";

			/// <summary>1:N owner_bot</summary>
			public const string OwnerBot = "owner_bot";

			/// <summary>1:N owner_botcomponent</summary>
			public const string OwnerBotcomponent = "owner_botcomponent";

			/// <summary>1:N owner_callbackregistration</summary>
			public const string OwnerCallbackregistration = "owner_callbackregistration";

			/// <summary>1:N owner_campaigns</summary>
			public const string OwnerCampaigns = "owner_campaigns";

			/// <summary>1:N owner_canvasapp</summary>
			public const string OwnerCanvasapp = "owner_canvasapp";

			/// <summary>1:N owner_categories</summary>
			public const string OwnerCategories = "owner_categories";

			/// <summary>1:N owner_characteristic</summary>
			public const string OwnerCharacteristic = "owner_characteristic";

			/// <summary>1:N owner_connectionreference</summary>
			public const string OwnerConnectionreference = "owner_connectionreference";

			/// <summary>1:N owner_connections</summary>
			public const string OwnerConnections = "owner_connections";

			/// <summary>1:N owner_connector</summary>
			public const string OwnerConnector = "owner_connector";

			/// <summary>1:N owner_contacts</summary>
			public const string OwnerContacts = "owner_contacts";

			/// <summary>1:N owner_contracts</summary>
			public const string OwnerContracts = "owner_contracts";

			/// <summary>1:N owner_conversationtranscript</summary>
			public const string OwnerConversationtranscript = "owner_conversationtranscript";

			/// <summary>1:N owner_customapi</summary>
			public const string OwnerCustomapi = "owner_customapi";

			/// <summary>1:N owner_customapirequestparameter</summary>
			public const string OwnerCustomapirequestparameter = "owner_customapirequestparameter";

			/// <summary>1:N owner_customapiresponseproperty</summary>
			public const string OwnerCustomapiresponseproperty = "owner_customapiresponseproperty";

			/// <summary>1:N owner_datalakefolder</summary>
			public const string OwnerDatalakefolder = "owner_datalakefolder";

			/// <summary>1:N owner_datalakefolderpermission</summary>
			public const string OwnerDatalakefolderpermission = "owner_datalakefolderpermission";

			/// <summary>1:N owner_duplicaterules</summary>
			public const string OwnerDuplicaterules = "owner_duplicaterules";

			/// <summary>1:N Owner_dynamicproperyinstance</summary>
			public const string OwnerDynamicproperyinstance = "Owner_dynamicproperyinstance";

			/// <summary>1:N owner_emails</summary>
			public const string OwnerEmails = "owner_emails";

			/// <summary>1:N owner_emailserverprofile</summary>
			public const string OwnerEmailserverprofile = "owner_emailserverprofile";

			/// <summary>1:N owner_entitlement</summary>
			public const string OwnerEntitlement = "owner_entitlement";

			/// <summary>1:N owner_entitlemententityallocationtypemapping</summary>
			public const string OwnerEntitlemententityallocationtypemapping = "owner_entitlemententityallocationtypemapping";

			/// <summary>1:N owner_environmentvariabledefinition</summary>
			public const string OwnerEnvironmentvariabledefinition = "owner_environmentvariabledefinition";

			/// <summary>1:N owner_environmentvariablevalue</summary>
			public const string OwnerEnvironmentvariablevalue = "owner_environmentvariablevalue";

			/// <summary>1:N owner_exchangesyncidmapping</summary>
			public const string OwnerExchangesyncidmapping = "owner_exchangesyncidmapping";

			/// <summary>1:N owner_exportsolutionupload</summary>
			public const string OwnerExportsolutionupload = "owner_exportsolutionupload";

			/// <summary>1:N owner_faxes</summary>
			public const string OwnerFaxes = "owner_faxes";

			/// <summary>1:N owner_feedback</summary>
			public const string OwnerFeedback = "owner_feedback";

			/// <summary>1:N owner_flowsession</summary>
			public const string OwnerFlowsession = "owner_flowsession";

			/// <summary>1:N owner_goal</summary>
			public const string OwnerGoal = "owner_goal";

			/// <summary>1:N owner_goalrollupquery</summary>
			public const string OwnerGoalrollupquery = "owner_goalrollupquery";

			/// <summary>1:N owner_importdatas</summary>
			public const string OwnerImportdatas = "owner_importdatas";

			/// <summary>1:N owner_importfiles</summary>
			public const string OwnerImportfiles = "owner_importfiles";

			/// <summary>1:N owner_importlogs</summary>
			public const string OwnerImportlogs = "owner_importlogs";

			/// <summary>1:N owner_importmaps</summary>
			public const string OwnerImportmaps = "owner_importmaps";

			/// <summary>1:N owner_imports</summary>
			public const string OwnerImports = "owner_imports";

			/// <summary>1:N owner_incidents</summary>
			public const string OwnerIncidents = "owner_incidents";

			/// <summary>1:N owner_interactionforemail</summary>
			public const string OwnerInteractionforemail = "owner_interactionforemail";

			/// <summary>1:N owner_invoices</summary>
			public const string OwnerInvoices = "owner_invoices";

			/// <summary>1:N owner_knowledgearticle</summary>
			public const string OwnerKnowledgearticle = "owner_knowledgearticle";

			/// <summary>1:N owner_leads</summary>
			public const string OwnerLeads = "owner_leads";

			/// <summary>1:N owner_letters</summary>
			public const string OwnerLetters = "owner_letters";

			/// <summary>1:N owner_listoperation</summary>
			public const string OwnerListoperation = "owner_listoperation";

			/// <summary>1:N owner_lists</summary>
			public const string OwnerLists = "owner_lists";

			/// <summary>1:N owner_mailbox</summary>
			public const string OwnerMailbox = "owner_mailbox";

			/// <summary>1:N owner_mailboxtrackingfolder</summary>
			public const string OwnerMailboxtrackingfolder = "owner_mailboxtrackingfolder";

			/// <summary>1:N owner_mailmergetemplates</summary>
			public const string OwnerMailmergetemplates = "owner_mailmergetemplates";

			/// <summary>1:N owner_msdyn_actioncardregarding</summary>
			public const string OwnerMsdynActioncardregarding = "owner_msdyn_actioncardregarding";

			/// <summary>1:N owner_msdyn_actioncardrolesetting</summary>
			public const string OwnerMsdynActioncardrolesetting = "owner_msdyn_actioncardrolesetting";

			/// <summary>1:N owner_msdyn_aibdataset</summary>
			public const string OwnerMsdynAibdataset = "owner_msdyn_aibdataset";

			/// <summary>1:N owner_msdyn_aibdatasetfile</summary>
			public const string OwnerMsdynAibdatasetfile = "owner_msdyn_aibdatasetfile";

			/// <summary>1:N owner_msdyn_aibdatasetrecord</summary>
			public const string OwnerMsdynAibdatasetrecord = "owner_msdyn_aibdatasetrecord";

			/// <summary>1:N owner_msdyn_aibdatasetscontainer</summary>
			public const string OwnerMsdynAibdatasetscontainer = "owner_msdyn_aibdatasetscontainer";

			/// <summary>1:N owner_msdyn_aibfile</summary>
			public const string OwnerMsdynAibfile = "owner_msdyn_aibfile";

			/// <summary>1:N owner_msdyn_aibfileattacheddata</summary>
			public const string OwnerMsdynAibfileattacheddata = "owner_msdyn_aibfileattacheddata";

			/// <summary>1:N owner_msdyn_aiconfiguration</summary>
			public const string OwnerMsdynAiconfiguration = "owner_msdyn_aiconfiguration";

			/// <summary>1:N owner_msdyn_aifptrainingdocument</summary>
			public const string OwnerMsdynAifptrainingdocument = "owner_msdyn_aifptrainingdocument";

			/// <summary>1:N owner_msdyn_aimodel</summary>
			public const string OwnerMsdynAimodel = "owner_msdyn_aimodel";

			/// <summary>1:N owner_msdyn_aiodimage</summary>
			public const string OwnerMsdynAiodimage = "owner_msdyn_aiodimage";

			/// <summary>1:N owner_msdyn_aiodlabel</summary>
			public const string OwnerMsdynAiodlabel = "owner_msdyn_aiodlabel";

			/// <summary>1:N owner_msdyn_aiodtrainingboundingbox</summary>
			public const string OwnerMsdynAiodtrainingboundingbox = "owner_msdyn_aiodtrainingboundingbox";

			/// <summary>1:N owner_msdyn_aiodtrainingimage</summary>
			public const string OwnerMsdynAiodtrainingimage = "owner_msdyn_aiodtrainingimage";

			/// <summary>1:N owner_msdyn_aitemplate</summary>
			public const string OwnerMsdynAitemplate = "owner_msdyn_aitemplate";

			/// <summary>1:N owner_msdyn_autocapturerule</summary>
			public const string OwnerMsdynAutocapturerule = "owner_msdyn_autocapturerule";

			/// <summary>1:N owner_msdyn_autocapturesettings</summary>
			public const string OwnerMsdynAutocapturesettings = "owner_msdyn_autocapturesettings";

			/// <summary>1:N owner_msdyn_callablecontext</summary>
			public const string OwnerMsdynCallablecontext = "owner_msdyn_callablecontext";

			/// <summary>1:N owner_msdyn_entityrankingrule</summary>
			public const string OwnerMsdynEntityrankingrule = "owner_msdyn_entityrankingrule";

			/// <summary>1:N owner_msdyn_federatedarticle</summary>
			public const string OwnerMsdynFederatedarticle = "owner_msdyn_federatedarticle";

			/// <summary>1:N owner_msdyn_flowcardtype</summary>
			public const string OwnerMsdynFlowcardtype = "owner_msdyn_flowcardtype";

			/// <summary>1:N owner_msdyn_icebreakersconfig</summary>
			public const string OwnerMsdynIcebreakersconfig = "owner_msdyn_icebreakersconfig";

			/// <summary>1:N owner_msdyn_kmfederatedsearchconfig</summary>
			public const string OwnerMsdynKmfederatedsearchconfig = "owner_msdyn_kmfederatedsearchconfig";

			/// <summary>1:N owner_msdyn_knowledgearticleimage</summary>
			public const string OwnerMsdynKnowledgearticleimage = "owner_msdyn_knowledgearticleimage";

			/// <summary>1:N owner_msdyn_knowledgearticletemplate</summary>
			public const string OwnerMsdynKnowledgearticletemplate = "owner_msdyn_knowledgearticletemplate";

			/// <summary>1:N owner_msdyn_knowledgeinteractioninsight</summary>
			public const string OwnerMsdynKnowledgeinteractioninsight = "owner_msdyn_knowledgeinteractioninsight";

			/// <summary>1:N owner_msdyn_knowledgesearchinsight</summary>
			public const string OwnerMsdynKnowledgesearchinsight = "owner_msdyn_knowledgesearchinsight";

			/// <summary>1:N owner_msdyn_msteamssetting</summary>
			public const string OwnerMsdynMsteamssetting = "owner_msdyn_msteamssetting";

			/// <summary>1:N owner_msdyn_notesanalysisconfig</summary>
			public const string OwnerMsdynNotesanalysisconfig = "owner_msdyn_notesanalysisconfig";

			/// <summary>1:N owner_msdyn_playbookactivity</summary>
			public const string OwnerMsdynPlaybookactivity = "owner_msdyn_playbookactivity";

			/// <summary>1:N owner_msdyn_playbookactivityattribute</summary>
			public const string OwnerMsdynPlaybookactivityattribute = "owner_msdyn_playbookactivityattribute";

			/// <summary>1:N owner_msdyn_playbookcategory</summary>
			public const string OwnerMsdynPlaybookcategory = "owner_msdyn_playbookcategory";

			/// <summary>1:N owner_msdyn_playbookinstance</summary>
			public const string OwnerMsdynPlaybookinstance = "owner_msdyn_playbookinstance";

			/// <summary>1:N owner_msdyn_playbooktemplate</summary>
			public const string OwnerMsdynPlaybooktemplate = "owner_msdyn_playbooktemplate";

			/// <summary>1:N owner_msdyn_postalbum</summary>
			public const string OwnerMsdynPostalbum = "owner_msdyn_postalbum";

			/// <summary>1:N owner_msdyn_relationshipinsightsunifiedconfig</summary>
			public const string OwnerMsdynRelationshipinsightsunifiedconfig = "owner_msdyn_relationshipinsightsunifiedconfig";

			/// <summary>1:N owner_msdyn_richtextfile</summary>
			public const string OwnerMsdynRichtextfile = "owner_msdyn_richtextfile";

			/// <summary>1:N owner_msdyn_salesinsightssettings</summary>
			public const string OwnerMsdynSalesinsightssettings = "owner_msdyn_salesinsightssettings";

			/// <summary>1:N owner_msdyn_siconfig</summary>
			public const string OwnerMsdynSiconfig = "owner_msdyn_siconfig";

			/// <summary>1:N owner_msdyn_untrackedappointment</summary>
			public const string OwnerMsdynUntrackedappointment = "owner_msdyn_untrackedappointment";

			/// <summary>1:N owner_msdyn_wallsavedqueryusersettings</summary>
			public const string OwnerMsdynWallsavedqueryusersettings = "owner_msdyn_wallsavedqueryusersettings";

			/// <summary>1:N owner_msdynce_botcontent</summary>
			public const string OwnerMsdynceBotcontent = "owner_msdynce_botcontent";

			/// <summary>1:N owner_opportunitys</summary>
			public const string OwnerOpportunitys = "owner_opportunitys";

			/// <summary>1:N owner_personaldocumenttemplates</summary>
			public const string OwnerPersonaldocumenttemplates = "owner_personaldocumenttemplates";

			/// <summary>1:N owner_phonecalls</summary>
			public const string OwnerPhonecalls = "owner_phonecalls";

			/// <summary>1:N owner_postfollows</summary>
			public const string OwnerPostfollows = "owner_postfollows";

			/// <summary>1:N owner_processsessions</summary>
			public const string OwnerProcesssessions = "owner_processsessions";

			/// <summary>1:N owner_processstageparameter</summary>
			public const string OwnerProcessstageparameter = "owner_processstageparameter";

			/// <summary>1:N owner_pw_penta_schedule_run</summary>
			public const string OwnerPwPentaScheduleRun = "owner_pw_penta_schedule_run";

			/// <summary>1:N owner_pw_schedule</summary>
			public const string OwnerPwSchedule = "owner_pw_schedule";

			/// <summary>1:N owner_queues</summary>
			public const string OwnerQueues = "owner_queues";

			/// <summary>1:N owner_quotes</summary>
			public const string OwnerQuotes = "owner_quotes";

			/// <summary>1:N owner_ratingmodel</summary>
			public const string OwnerRatingmodel = "owner_ratingmodel";

			/// <summary>1:N owner_ratingvalue</summary>
			public const string OwnerRatingvalue = "owner_ratingvalue";

			/// <summary>1:N owner_recurrencerules</summary>
			public const string OwnerRecurrencerules = "owner_recurrencerules";

			/// <summary>1:N owner_recurringappointmentmasters</summary>
			public const string OwnerRecurringappointmentmasters = "owner_recurringappointmentmasters";

			/// <summary>1:N owner_reports</summary>
			public const string OwnerReports = "owner_reports";

			/// <summary>1:N owner_salesorders</summary>
			public const string OwnerSalesorders = "owner_salesorders";

			/// <summary>1:N owner_sharepointdocumentlocation</summary>
			public const string OwnerSharepointdocumentlocation = "owner_sharepointdocumentlocation";

			/// <summary>1:N owner_sharepointsite</summary>
			public const string OwnerSharepointsite = "owner_sharepointsite";

			/// <summary>1:N owner_slas</summary>
			public const string OwnerSlas = "owner_slas";

			/// <summary>1:N owner_socialactivities</summary>
			public const string OwnerSocialactivities = "owner_socialactivities";

			/// <summary>1:N owner_SocialProfile</summary>
			public const string OwnerSocialProfile = "owner_SocialProfile";

			/// <summary>1:N owner_stagesolutionupload</summary>
			public const string OwnerStagesolutionupload = "owner_stagesolutionupload";

			/// <summary>1:N owner_SyncError</summary>
			public const string OwnerSyncError = "owner_SyncError";

			/// <summary>1:N owner_tasks</summary>
			public const string OwnerTasks = "owner_tasks";

			/// <summary>1:N owner_templates</summary>
			public const string OwnerTemplates = "owner_templates";

			/// <summary>1:N owner_userform</summary>
			public const string OwnerUserform = "owner_userform";

			/// <summary>1:N owner_userquerys</summary>
			public const string OwnerUserquerys = "owner_userquerys";

			/// <summary>1:N owner_userqueryvisualizations</summary>
			public const string OwnerUserqueryvisualizations = "owner_userqueryvisualizations";

			/// <summary>1:N owner_workflowbinary</summary>
			public const string OwnerWorkflowbinary = "owner_workflowbinary";

			/// <summary>1:N owner_workflows</summary>
			public const string OwnerWorkflows = "owner_workflows";

			/// <summary>1:N quoteclose_owner_ownerid</summary>
			public const string QuotecloseOwnerOwnerid = "quoteclose_owner_ownerid";

			/// <summary>1:N serviceappointment_owner_ownerid</summary>
			public const string ServiceappointmentOwnerOwnerid = "serviceappointment_owner_ownerid";

			/// <summary>1:N slakpiinstance_owner</summary>
			public const string SlakpiinstanceOwner = "slakpiinstance_owner";

		}
		#endregion
	}
}

