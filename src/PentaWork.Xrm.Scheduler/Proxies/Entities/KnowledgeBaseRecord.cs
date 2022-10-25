using System;
using System.Linq;
using System.Diagnostics;
using System.ComponentModel;
using Microsoft.Xrm.Sdk; 
using Microsoft.Xrm.Sdk.Client;
using System.Collections.Generic;

namespace PentaWork.Xrm.Scheduler.Proxies.Entities
{
	[DebuggerDisplay("{KBRecordTitle}")] 	
	[EntityLogicalName("knowledgebaserecord")]
	public sealed class KnowledgeBaseRecord : Entity
	{	
		public static readonly int? EntityTypeCode = 9930;
		public new const string LogicalName = "knowledgebaserecord";
		public const string PrimaryIdAttribute = "knowledgebaserecordid";
		public const string PrimaryNameAttribute = "title";
	
		public KnowledgeBaseRecord() : base("knowledgebaserecord") { }

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
        /// exchangerate
        /// </summary>
		[DisplayName("ExchangeRate")]
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
        /// knowledgebaserecordid
        /// </summary>
		[DisplayName("ID")]
		[AttributeLogicalName("knowledgebaserecordid")]
		public override Guid Id
		{
			get => base.Id;
			set { base.Id = value; SetAttributeValue("knowledgebaserecordid", value); }
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
        /// privateurl
        /// </summary>
		[DisplayName("Private URL")]
		[AttributeLogicalName("privateurl")]
		public string PrivateURL
		{	
			get { return GetAttributeValue<string>("privateurl"); }
			set
			{ 
				if(value == PrivateURL) return;
				SetAttributeValue("privateurl", value);
			}
		}	
			
		/// <summary>
        /// publicurl
        /// </summary>
		[DisplayName("Public URL")]
		[AttributeLogicalName("publicurl")]
		public string PublicURL
		{	
			get { return GetAttributeValue<string>("publicurl"); }
			set
			{ 
				if(value == PublicURL) return;
				SetAttributeValue("publicurl", value);
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
		[DisplayName("KB Record Title")]
		[AttributeLogicalName("title")]
		public string KBRecordTitle
		{	
			get { return GetAttributeValue<string>("title"); }
			set
			{ 
				if(value == KBRecordTitle) return;
				SetAttributeValue("title", value);
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
        /// uniqueid
        /// </summary>
		[DisplayName("Unique ID")]
		[AttributeLogicalName("uniqueid")]
		public string UniqueID
		{	
			get { return GetAttributeValue<string>("uniqueid"); }
			set
			{ 
				if(value == UniqueID) return;
				SetAttributeValue("uniqueid", value);
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
			
		#endregion	

		#region Relations
			/// <summary>
        /// 1:N Get entities for 'KnowledgeBaseRecord_ActivityPointers'
        /// </summary>
		[RelationshipSchemaName("KnowledgeBaseRecord_ActivityPointers")]
		public IEnumerable<Activity> KnowledgeBaseRecordActivityPointers
		{
			get { return GetRelatedEntities<Activity>("KnowledgeBaseRecord_ActivityPointers", null); }
			set { SetRelatedEntities("KnowledgeBaseRecord_ActivityPointers", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'KnowledgeBaseRecord_Annotations'
        /// </summary>
		[RelationshipSchemaName("KnowledgeBaseRecord_Annotations")]
		public IEnumerable<Note> KnowledgeBaseRecordAnnotations
		{
			get { return GetRelatedEntities<Note>("KnowledgeBaseRecord_Annotations", null); }
			set { SetRelatedEntities("KnowledgeBaseRecord_Annotations", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'KnowledgeBaseRecord_Appointments'
        /// </summary>
		[RelationshipSchemaName("KnowledgeBaseRecord_Appointments")]
		public IEnumerable<Appointment> KnowledgeBaseRecordAppointments
		{
			get { return GetRelatedEntities<Appointment>("KnowledgeBaseRecord_Appointments", null); }
			set { SetRelatedEntities("KnowledgeBaseRecord_Appointments", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'KnowledgeBaseRecord_AsyncOperations'
        /// </summary>
		[RelationshipSchemaName("KnowledgeBaseRecord_AsyncOperations")]
		public IEnumerable<SystemJob> KnowledgeBaseRecordAsyncOperations
		{
			get { return GetRelatedEntities<SystemJob>("KnowledgeBaseRecord_AsyncOperations", null); }
			set { SetRelatedEntities("KnowledgeBaseRecord_AsyncOperations", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'KnowledgeBaseRecord_BulkDeleteFailures'
        /// </summary>
		[RelationshipSchemaName("KnowledgeBaseRecord_BulkDeleteFailures")]
		public IEnumerable<BulkDeleteFailure> KnowledgeBaseRecordBulkDeleteFailures
		{
			get { return GetRelatedEntities<BulkDeleteFailure>("KnowledgeBaseRecord_BulkDeleteFailures", null); }
			set { SetRelatedEntities("KnowledgeBaseRecord_BulkDeleteFailures", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'knowledgebaserecord_BulkOperations'
        /// </summary>
		[RelationshipSchemaName("knowledgebaserecord_BulkOperations")]
		public IEnumerable<QuickCampaign> KnowledgebaserecordBulkOperations
		{
			get { return GetRelatedEntities<QuickCampaign>("knowledgebaserecord_BulkOperations", null); }
			set { SetRelatedEntities("knowledgebaserecord_BulkOperations", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'knowledgebaserecord_CampaignResponses'
        /// </summary>
		[RelationshipSchemaName("knowledgebaserecord_CampaignResponses")]
		public IEnumerable<CampaignResponse> KnowledgebaserecordCampaignResponses
		{
			get { return GetRelatedEntities<CampaignResponse>("knowledgebaserecord_CampaignResponses", null); }
			set { SetRelatedEntities("knowledgebaserecord_CampaignResponses", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'KnowledgeBaseRecord_connections1'
        /// </summary>
		[RelationshipSchemaName("KnowledgeBaseRecord_connections1")]
		public IEnumerable<Connection> KnowledgeBaseRecordConnections1
		{
			get { return GetRelatedEntities<Connection>("KnowledgeBaseRecord_connections1", null); }
			set { SetRelatedEntities("KnowledgeBaseRecord_connections1", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'KnowledgeBaseRecord_connections2'
        /// </summary>
		[RelationshipSchemaName("KnowledgeBaseRecord_connections2")]
		public IEnumerable<Connection> KnowledgeBaseRecordConnections2
		{
			get { return GetRelatedEntities<Connection>("KnowledgeBaseRecord_connections2", null); }
			set { SetRelatedEntities("KnowledgeBaseRecord_connections2", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'KnowledgeBaseRecord_DuplicateBaseRecord'
        /// </summary>
		[RelationshipSchemaName("KnowledgeBaseRecord_DuplicateBaseRecord")]
		public IEnumerable<DuplicateRecord> KnowledgeBaseRecordDuplicateBaseRecord
		{
			get { return GetRelatedEntities<DuplicateRecord>("KnowledgeBaseRecord_DuplicateBaseRecord", null); }
			set { SetRelatedEntities("KnowledgeBaseRecord_DuplicateBaseRecord", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'KnowledgeBaseRecord_DuplicateMatchingRecord'
        /// </summary>
		[RelationshipSchemaName("KnowledgeBaseRecord_DuplicateMatchingRecord")]
		public IEnumerable<DuplicateRecord> KnowledgeBaseRecordDuplicateMatchingRecord
		{
			get { return GetRelatedEntities<DuplicateRecord>("KnowledgeBaseRecord_DuplicateMatchingRecord", null); }
			set { SetRelatedEntities("KnowledgeBaseRecord_DuplicateMatchingRecord", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'KnowledgeBaseRecord_Emails'
        /// </summary>
		[RelationshipSchemaName("KnowledgeBaseRecord_Emails")]
		public IEnumerable<Email> KnowledgeBaseRecordEmails
		{
			get { return GetRelatedEntities<Email>("KnowledgeBaseRecord_Emails", null); }
			set { SetRelatedEntities("KnowledgeBaseRecord_Emails", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'KnowledgeBaseRecord_Faxes'
        /// </summary>
		[RelationshipSchemaName("KnowledgeBaseRecord_Faxes")]
		public IEnumerable<Fax> KnowledgeBaseRecordFaxes
		{
			get { return GetRelatedEntities<Fax>("KnowledgeBaseRecord_Faxes", null); }
			set { SetRelatedEntities("KnowledgeBaseRecord_Faxes", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'knowledgebaserecord_IncidentResolutions'
        /// </summary>
		[RelationshipSchemaName("knowledgebaserecord_IncidentResolutions")]
		public IEnumerable<CaseResolution> KnowledgebaserecordIncidentResolutions
		{
			get { return GetRelatedEntities<CaseResolution>("knowledgebaserecord_IncidentResolutions", null); }
			set { SetRelatedEntities("knowledgebaserecord_IncidentResolutions", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'KnowledgeBaseRecord_Letters'
        /// </summary>
		[RelationshipSchemaName("KnowledgeBaseRecord_Letters")]
		public IEnumerable<Letter> KnowledgeBaseRecordLetters
		{
			get { return GetRelatedEntities<Letter>("KnowledgeBaseRecord_Letters", null); }
			set { SetRelatedEntities("KnowledgeBaseRecord_Letters", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'knowledgebaserecord_OpportunityCloses'
        /// </summary>
		[RelationshipSchemaName("knowledgebaserecord_OpportunityCloses")]
		public IEnumerable<OpportunityClose> KnowledgebaserecordOpportunityCloses
		{
			get { return GetRelatedEntities<OpportunityClose>("knowledgebaserecord_OpportunityCloses", null); }
			set { SetRelatedEntities("knowledgebaserecord_OpportunityCloses", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'knowledgebaserecord_OrderCloses'
        /// </summary>
		[RelationshipSchemaName("knowledgebaserecord_OrderCloses")]
		public IEnumerable<OrderClose> KnowledgebaserecordOrderCloses
		{
			get { return GetRelatedEntities<OrderClose>("knowledgebaserecord_OrderCloses", null); }
			set { SetRelatedEntities("knowledgebaserecord_OrderCloses", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'KnowledgeBaseRecord_PhoneCalls'
        /// </summary>
		[RelationshipSchemaName("KnowledgeBaseRecord_PhoneCalls")]
		public IEnumerable<PhoneCall> KnowledgeBaseRecordPhoneCalls
		{
			get { return GetRelatedEntities<PhoneCall>("KnowledgeBaseRecord_PhoneCalls", null); }
			set { SetRelatedEntities("KnowledgeBaseRecord_PhoneCalls", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'KnowledgeBaseRecord_PrincipalObjectAttributeAccess'
        /// </summary>
		[RelationshipSchemaName("KnowledgeBaseRecord_PrincipalObjectAttributeAccess")]
		public IEnumerable<FieldSharing> KnowledgeBaseRecordPrincipalObjectAttributeAccess
		{
			get { return GetRelatedEntities<FieldSharing>("KnowledgeBaseRecord_PrincipalObjectAttributeAccess", null); }
			set { SetRelatedEntities("KnowledgeBaseRecord_PrincipalObjectAttributeAccess", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'KnowledgeBaseRecord_ProcessSession'
        /// </summary>
		[RelationshipSchemaName("KnowledgeBaseRecord_ProcessSession")]
		public IEnumerable<ProcessSession> KnowledgeBaseRecordProcessSession
		{
			get { return GetRelatedEntities<ProcessSession>("KnowledgeBaseRecord_ProcessSession", null); }
			set { SetRelatedEntities("KnowledgeBaseRecord_ProcessSession", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'knowledgebaserecord_QuoteCloses'
        /// </summary>
		[RelationshipSchemaName("knowledgebaserecord_QuoteCloses")]
		public IEnumerable<QuoteClose> KnowledgebaserecordQuoteCloses
		{
			get { return GetRelatedEntities<QuoteClose>("knowledgebaserecord_QuoteCloses", null); }
			set { SetRelatedEntities("knowledgebaserecord_QuoteCloses", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'KnowledgeBaseRecord_RecurringAppointmentMasters'
        /// </summary>
		[RelationshipSchemaName("KnowledgeBaseRecord_RecurringAppointmentMasters")]
		public IEnumerable<RecurringAppointment> KnowledgeBaseRecordRecurringAppointmentMasters
		{
			get { return GetRelatedEntities<RecurringAppointment>("KnowledgeBaseRecord_RecurringAppointmentMasters", null); }
			set { SetRelatedEntities("KnowledgeBaseRecord_RecurringAppointmentMasters", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'KnowledgeBaseRecord_ServiceAppointments'
        /// </summary>
		[RelationshipSchemaName("KnowledgeBaseRecord_ServiceAppointments")]
		public IEnumerable<ServiceActivity> KnowledgeBaseRecordServiceAppointments
		{
			get { return GetRelatedEntities<ServiceActivity>("KnowledgeBaseRecord_ServiceAppointments", null); }
			set { SetRelatedEntities("KnowledgeBaseRecord_ServiceAppointments", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'KnowledgeBaseRecord_SocialActivities'
        /// </summary>
		[RelationshipSchemaName("KnowledgeBaseRecord_SocialActivities")]
		public IEnumerable<SocialActivity> KnowledgeBaseRecordSocialActivities
		{
			get { return GetRelatedEntities<SocialActivity>("KnowledgeBaseRecord_SocialActivities", null); }
			set { SetRelatedEntities("KnowledgeBaseRecord_SocialActivities", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'KnowledgeBaseRecord_SyncErrors'
        /// </summary>
		[RelationshipSchemaName("KnowledgeBaseRecord_SyncErrors")]
		public IEnumerable<SyncError> KnowledgeBaseRecordSyncErrors
		{
			get { return GetRelatedEntities<SyncError>("KnowledgeBaseRecord_SyncErrors", null); }
			set { SetRelatedEntities("KnowledgeBaseRecord_SyncErrors", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'KnowledgeBaseRecord_Tasks'
        /// </summary>
		[RelationshipSchemaName("KnowledgeBaseRecord_Tasks")]
		public IEnumerable<Task> KnowledgeBaseRecordTasks
		{
			get { return GetRelatedEntities<Task>("KnowledgeBaseRecord_Tasks", null); }
			set { SetRelatedEntities("KnowledgeBaseRecord_Tasks", null, value); }
		}
		/// <summary>
        /// N:N Get entities for 'Case'
        /// </summary>
		[RelationshipSchemaName("KnowledgeBaseRecord_Incident")]
		public IEnumerable<Case> KnowledgeBaseRecordIncident
		{
			get { return GetRelatedEntities<Case>("KnowledgeBaseRecord_Incident", null); }
			set { SetRelatedEntities("KnowledgeBaseRecord_Incident", null, value); }
		}
		#endregion

		#region Actions
		#endregion

		#region OptionSetEnums
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

			/// <summary>exchangerate</summary>
			public const string ExchangeRate = "exchangerate";

			/// <summary>knowledgebaserecordid</summary>
			public const string Id = "knowledgebaserecordid";

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

			/// <summary>organizationidname</summary>
			public const string Organizationidname = "organizationidname";

			/// <summary>privateurl</summary>
			public const string PrivateURL = "privateurl";

			/// <summary>publicurl</summary>
			public const string PublicURL = "publicurl";

			/// <summary>timezoneruleversionnumber</summary>
			public const string TimeZoneRuleVersionNumber = "timezoneruleversionnumber";

			/// <summary>title</summary>
			public const string KBRecordTitle = "title";

			/// <summary>transactioncurrencyid</summary>
			public const string Currency = "transactioncurrencyid";

			/// <summary>transactioncurrencyidname</summary>
			public const string Transactioncurrencyidname = "transactioncurrencyidname";

			/// <summary>uniqueid</summary>
			public const string UniqueID = "uniqueid";

			/// <summary>versionnumber</summary>
			public const string Versionnumber = "versionnumber";

		}
		#endregion

		#region Schemas
		public static class Schemas 
		{
			/// <summary>1:N KnowledgeBaseRecord_ActivityPointers</summary>
			public const string KnowledgeBaseRecordActivityPointers = "KnowledgeBaseRecord_ActivityPointers";

			/// <summary>1:N KnowledgeBaseRecord_Annotations</summary>
			public const string KnowledgeBaseRecordAnnotations = "KnowledgeBaseRecord_Annotations";

			/// <summary>1:N KnowledgeBaseRecord_Appointments</summary>
			public const string KnowledgeBaseRecordAppointments = "KnowledgeBaseRecord_Appointments";

			/// <summary>1:N KnowledgeBaseRecord_AsyncOperations</summary>
			public const string KnowledgeBaseRecordAsyncOperations = "KnowledgeBaseRecord_AsyncOperations";

			/// <summary>1:N KnowledgeBaseRecord_BulkDeleteFailures</summary>
			public const string KnowledgeBaseRecordBulkDeleteFailures = "KnowledgeBaseRecord_BulkDeleteFailures";

			/// <summary>1:N knowledgebaserecord_BulkOperations</summary>
			public const string KnowledgebaserecordBulkOperations = "knowledgebaserecord_BulkOperations";

			/// <summary>1:N knowledgebaserecord_CampaignResponses</summary>
			public const string KnowledgebaserecordCampaignResponses = "knowledgebaserecord_CampaignResponses";

			/// <summary>1:N KnowledgeBaseRecord_connections1</summary>
			public const string KnowledgeBaseRecordConnections1 = "KnowledgeBaseRecord_connections1";

			/// <summary>1:N KnowledgeBaseRecord_connections2</summary>
			public const string KnowledgeBaseRecordConnections2 = "KnowledgeBaseRecord_connections2";

			/// <summary>1:N KnowledgeBaseRecord_DuplicateBaseRecord</summary>
			public const string KnowledgeBaseRecordDuplicateBaseRecord = "KnowledgeBaseRecord_DuplicateBaseRecord";

			/// <summary>1:N KnowledgeBaseRecord_DuplicateMatchingRecord</summary>
			public const string KnowledgeBaseRecordDuplicateMatchingRecord = "KnowledgeBaseRecord_DuplicateMatchingRecord";

			/// <summary>1:N KnowledgeBaseRecord_Emails</summary>
			public const string KnowledgeBaseRecordEmails = "KnowledgeBaseRecord_Emails";

			/// <summary>1:N KnowledgeBaseRecord_Faxes</summary>
			public const string KnowledgeBaseRecordFaxes = "KnowledgeBaseRecord_Faxes";

			/// <summary>1:N knowledgebaserecord_IncidentResolutions</summary>
			public const string KnowledgebaserecordIncidentResolutions = "knowledgebaserecord_IncidentResolutions";

			/// <summary>1:N KnowledgeBaseRecord_Letters</summary>
			public const string KnowledgeBaseRecordLetters = "KnowledgeBaseRecord_Letters";

			/// <summary>1:N knowledgebaserecord_OpportunityCloses</summary>
			public const string KnowledgebaserecordOpportunityCloses = "knowledgebaserecord_OpportunityCloses";

			/// <summary>1:N knowledgebaserecord_OrderCloses</summary>
			public const string KnowledgebaserecordOrderCloses = "knowledgebaserecord_OrderCloses";

			/// <summary>1:N KnowledgeBaseRecord_PhoneCalls</summary>
			public const string KnowledgeBaseRecordPhoneCalls = "KnowledgeBaseRecord_PhoneCalls";

			/// <summary>1:N KnowledgeBaseRecord_PrincipalObjectAttributeAccess</summary>
			public const string KnowledgeBaseRecordPrincipalObjectAttributeAccess = "KnowledgeBaseRecord_PrincipalObjectAttributeAccess";

			/// <summary>1:N KnowledgeBaseRecord_ProcessSession</summary>
			public const string KnowledgeBaseRecordProcessSession = "KnowledgeBaseRecord_ProcessSession";

			/// <summary>1:N knowledgebaserecord_QuoteCloses</summary>
			public const string KnowledgebaserecordQuoteCloses = "knowledgebaserecord_QuoteCloses";

			/// <summary>1:N KnowledgeBaseRecord_RecurringAppointmentMasters</summary>
			public const string KnowledgeBaseRecordRecurringAppointmentMasters = "KnowledgeBaseRecord_RecurringAppointmentMasters";

			/// <summary>1:N KnowledgeBaseRecord_ServiceAppointments</summary>
			public const string KnowledgeBaseRecordServiceAppointments = "KnowledgeBaseRecord_ServiceAppointments";

			/// <summary>1:N KnowledgeBaseRecord_SocialActivities</summary>
			public const string KnowledgeBaseRecordSocialActivities = "KnowledgeBaseRecord_SocialActivities";

			/// <summary>1:N KnowledgeBaseRecord_SyncErrors</summary>
			public const string KnowledgeBaseRecordSyncErrors = "KnowledgeBaseRecord_SyncErrors";

			/// <summary>1:N KnowledgeBaseRecord_Tasks</summary>
			public const string KnowledgeBaseRecordTasks = "KnowledgeBaseRecord_Tasks";

			/// <summary>N:N KnowledgeBaseRecord_Incident</summary>
			public const string KnowledgeBaseRecordIncident = "KnowledgeBaseRecord_Incident";

		}
		#endregion
	}
}

