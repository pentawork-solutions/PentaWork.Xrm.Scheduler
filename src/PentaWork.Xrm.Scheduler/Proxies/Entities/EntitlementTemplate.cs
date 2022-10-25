using System;
using System.Linq;
using System.Diagnostics;
using System.ComponentModel;
using Microsoft.Xrm.Sdk; 
using Microsoft.Xrm.Sdk.Client;
using System.Collections.Generic;

namespace PentaWork.Xrm.Scheduler.Proxies.Entities
{
	[DebuggerDisplay("{EntitlementTemplateName}")] 	
	[EntityLogicalName("entitlementtemplate")]
	public sealed class EntitlementTemplate : Entity
	{	
		public static readonly int? EntityTypeCode = 9702;
		public new const string LogicalName = "entitlementtemplate";
		public const string PrimaryIdAttribute = "entitlementtemplateid";
		public const string PrimaryNameAttribute = "name";
	
		public EntitlementTemplate() : base("entitlementtemplate") { }

		#region Attributes
		/// <summary>
        /// allocationtypecode
        /// </summary>
		[DisplayName("Allocation Type")]
		[AttributeLogicalName("allocationtypecode")]
		public eAllocationType? AllocationType
		{	
			get 
			{ 
				var optionSetValue = GetAttributeValue<OptionSetValue>("allocationtypecode");
				if (optionSetValue != null) return (eAllocationType)optionSetValue.Value;
				else return null;
			}
			set 
			{ 
				if(value == AllocationType) return;

				OptionSetValue optionSetValue = null;
				if(value != null) optionSetValue = new OptionSetValue((int)value);
				SetAttributeValue("allocationtypecode", optionSetValue); 
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
        /// decreaseremainingon
        /// </summary>
		[DisplayName("Decrease Remaining On")]
		[AttributeLogicalName("decreaseremainingon")]
		public eDecreaseRemainingOn? DecreaseRemainingOn
		{	
			get 
			{ 
				var optionSetValue = GetAttributeValue<OptionSetValue>("decreaseremainingon");
				if (optionSetValue != null) return (eDecreaseRemainingOn)optionSetValue.Value;
				else return null;
			}
			set 
			{ 
				if(value == DecreaseRemainingOn) return;

				OptionSetValue optionSetValue = null;
				if(value != null) optionSetValue = new OptionSetValue((int)value);
				SetAttributeValue("decreaseremainingon", optionSetValue); 
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
        /// entitlementtemplateid
        /// </summary>
		[DisplayName("Entitlement Template")]
		[AttributeLogicalName("entitlementtemplateid")]
		public override Guid Id
		{
			get => base.Id;
			set { base.Id = value; SetAttributeValue("entitlementtemplateid", value); }
		}

							/// <summary>
        /// entitytype
        /// </summary>
		[DisplayName("Entity Type")]
		[AttributeLogicalName("entitytype")]
		public egEntityType? EntityType
		{	
			get 
			{ 
				var optionSetValue = GetAttributeValue<OptionSetValue>("entitytype");
				if (optionSetValue != null) return (egEntityType)optionSetValue.Value;
				else return null;
			}
			set 
			{ 
				if(value == EntityType) return;

				OptionSetValue optionSetValue = null;
				if(value != null) optionSetValue = new OptionSetValue((int)value);
				SetAttributeValue("entitytype", optionSetValue); 
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
        /// kbaccesslevel
        /// </summary>
		[DisplayName("KB Access Level")]
		[AttributeLogicalName("kbaccesslevel")]
		public eKBAccessLevel? KBAccessLevel
		{	
			get 
			{ 
				var optionSetValue = GetAttributeValue<OptionSetValue>("kbaccesslevel");
				if (optionSetValue != null) return (eKBAccessLevel)optionSetValue.Value;
				else return null;
			}
			set 
			{ 
				if(value == KBAccessLevel) return;

				OptionSetValue optionSetValue = null;
				if(value != null) optionSetValue = new OptionSetValue((int)value);
				SetAttributeValue("kbaccesslevel", optionSetValue); 
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
		[DisplayName("Entitlement Template Name")]
		[AttributeLogicalName("name")]
		public string EntitlementTemplateName
		{	
			get { return GetAttributeValue<string>("name"); }
			set
			{ 
				if(value == EntitlementTemplateName) return;
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
        /// restrictcasecreation
        /// </summary>
		[DisplayName("Restrict By Entitlement Terms")]
		[AttributeLogicalName("restrictcasecreation")]
		public bool? RestrictByEntitlementTerms
		{	
			get { return GetAttributeValue<bool?>("restrictcasecreation"); }
			set
			{ 
				if(value == RestrictByEntitlementTerms) return;
				SetAttributeValue("restrictcasecreation", value);
			}
		}	
			
		/// <summary>
        /// slaid
        /// </summary>
		[DisplayName("SLA")]
		[AttributeLogicalName("slaid")]
		public EntityReference SLA
		{	
			get { return GetAttributeValue<EntityReference>("slaid"); }
			set
			{ 
				if(value == SLA) return;
				SetAttributeValue("slaid", value);
			}
		}	
			
		/// <summary>
        /// slaidname
        /// </summary>
		[DisplayName("slaidname")]
		[AttributeLogicalName("slaidname")]
		public string Slaidname
		{	
			get { return GetAttributeValue<string>("slaidname"); }
			set
			{ 
				if(value == Slaidname) return;
				SetAttributeValue("slaidname", value);
			}
		}	
			
		/// <summary>
        /// startdate
        /// </summary>
		[DisplayName("Start Date")]
		[AttributeLogicalName("startdate")]
		public DateTime? StartDate
		{	
			get { return GetAttributeValue<DateTime?>("startdate"); }
			set
			{ 
				if(value == StartDate) return;
				SetAttributeValue("startdate", value);
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
        /// totalterms
        /// </summary>
		[DisplayName("Total Terms")]
		[AttributeLogicalName("totalterms")]
		public decimal? TotalTerms
		{	
			get { return GetAttributeValue<decimal?>("totalterms"); }
			set
			{ 
				if(value == TotalTerms) return;
				SetAttributeValue("totalterms", value);
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
        /// 1:N Get entities for 'entitlementtemplate_ActivityPointers'
        /// </summary>
		[RelationshipSchemaName("entitlementtemplate_ActivityPointers")]
		public IEnumerable<Activity> EntitlementtemplateActivityPointers
		{
			get { return GetRelatedEntities<Activity>("entitlementtemplate_ActivityPointers", null); }
			set { SetRelatedEntities("entitlementtemplate_ActivityPointers", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'entitlementtemplate_Annotations'
        /// </summary>
		[RelationshipSchemaName("entitlementtemplate_Annotations")]
		public IEnumerable<Note> EntitlementtemplateAnnotations
		{
			get { return GetRelatedEntities<Note>("entitlementtemplate_Annotations", null); }
			set { SetRelatedEntities("entitlementtemplate_Annotations", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'entitlementtemplate_Appointments'
        /// </summary>
		[RelationshipSchemaName("entitlementtemplate_Appointments")]
		public IEnumerable<Appointment> EntitlementtemplateAppointments
		{
			get { return GetRelatedEntities<Appointment>("entitlementtemplate_Appointments", null); }
			set { SetRelatedEntities("entitlementtemplate_Appointments", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'entitlementtemplate_AsyncOperations'
        /// </summary>
		[RelationshipSchemaName("entitlementtemplate_AsyncOperations")]
		public IEnumerable<SystemJob> EntitlementtemplateAsyncOperations
		{
			get { return GetRelatedEntities<SystemJob>("entitlementtemplate_AsyncOperations", null); }
			set { SetRelatedEntities("entitlementtemplate_AsyncOperations", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'entitlementtemplate_BulkDeleteFailures'
        /// </summary>
		[RelationshipSchemaName("entitlementtemplate_BulkDeleteFailures")]
		public IEnumerable<BulkDeleteFailure> EntitlementtemplateBulkDeleteFailures
		{
			get { return GetRelatedEntities<BulkDeleteFailure>("entitlementtemplate_BulkDeleteFailures", null); }
			set { SetRelatedEntities("entitlementtemplate_BulkDeleteFailures", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'entitlementtemplate_DuplicateBaseRecord'
        /// </summary>
		[RelationshipSchemaName("entitlementtemplate_DuplicateBaseRecord")]
		public IEnumerable<DuplicateRecord> EntitlementtemplateDuplicateBaseRecord
		{
			get { return GetRelatedEntities<DuplicateRecord>("entitlementtemplate_DuplicateBaseRecord", null); }
			set { SetRelatedEntities("entitlementtemplate_DuplicateBaseRecord", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'entitlementtemplate_DuplicateMatchingRecord'
        /// </summary>
		[RelationshipSchemaName("entitlementtemplate_DuplicateMatchingRecord")]
		public IEnumerable<DuplicateRecord> EntitlementtemplateDuplicateMatchingRecord
		{
			get { return GetRelatedEntities<DuplicateRecord>("entitlementtemplate_DuplicateMatchingRecord", null); }
			set { SetRelatedEntities("entitlementtemplate_DuplicateMatchingRecord", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'entitlementtemplate_Emails'
        /// </summary>
		[RelationshipSchemaName("entitlementtemplate_Emails")]
		public IEnumerable<Email> EntitlementtemplateEmails
		{
			get { return GetRelatedEntities<Email>("entitlementtemplate_Emails", null); }
			set { SetRelatedEntities("entitlementtemplate_Emails", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'entitlementtemplate_entitlementchannel_entitlementtemplateid'
        /// </summary>
		[RelationshipSchemaName("entitlementtemplate_entitlementchannel_entitlementtemplateid")]
		public IEnumerable<EntitlementTemplateChannel> EntitlementtemplateEntitlementchannelEntitlementtemplateid
		{
			get { return GetRelatedEntities<EntitlementTemplateChannel>("entitlementtemplate_entitlementchannel_entitlementtemplateid", null); }
			set { SetRelatedEntities("entitlementtemplate_entitlementchannel_entitlementtemplateid", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'entitlementtemplate_Faxes'
        /// </summary>
		[RelationshipSchemaName("entitlementtemplate_Faxes")]
		public IEnumerable<Fax> EntitlementtemplateFaxes
		{
			get { return GetRelatedEntities<Fax>("entitlementtemplate_Faxes", null); }
			set { SetRelatedEntities("entitlementtemplate_Faxes", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'entitlementtemplate_IncidentResolutions'
        /// </summary>
		[RelationshipSchemaName("entitlementtemplate_IncidentResolutions")]
		public IEnumerable<CaseResolution> EntitlementtemplateIncidentResolutions
		{
			get { return GetRelatedEntities<CaseResolution>("entitlementtemplate_IncidentResolutions", null); }
			set { SetRelatedEntities("entitlementtemplate_IncidentResolutions", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'entitlementtemplate_Letters'
        /// </summary>
		[RelationshipSchemaName("entitlementtemplate_Letters")]
		public IEnumerable<Letter> EntitlementtemplateLetters
		{
			get { return GetRelatedEntities<Letter>("entitlementtemplate_Letters", null); }
			set { SetRelatedEntities("entitlementtemplate_Letters", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'EntitlementTemplate_MailboxTrackingFolder'
        /// </summary>
		[RelationshipSchemaName("EntitlementTemplate_MailboxTrackingFolder")]
		public IEnumerable<MailboxAutoTrackingFolder> EntitlementTemplateMailboxTrackingFolder
		{
			get { return GetRelatedEntities<MailboxAutoTrackingFolder>("EntitlementTemplate_MailboxTrackingFolder", null); }
			set { SetRelatedEntities("EntitlementTemplate_MailboxTrackingFolder", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'entitlementtemplate_OpportunityCloses'
        /// </summary>
		[RelationshipSchemaName("entitlementtemplate_OpportunityCloses")]
		public IEnumerable<OpportunityClose> EntitlementtemplateOpportunityCloses
		{
			get { return GetRelatedEntities<OpportunityClose>("entitlementtemplate_OpportunityCloses", null); }
			set { SetRelatedEntities("entitlementtemplate_OpportunityCloses", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'entitlementtemplate_OrderCloses'
        /// </summary>
		[RelationshipSchemaName("entitlementtemplate_OrderCloses")]
		public IEnumerable<OrderClose> EntitlementtemplateOrderCloses
		{
			get { return GetRelatedEntities<OrderClose>("entitlementtemplate_OrderCloses", null); }
			set { SetRelatedEntities("entitlementtemplate_OrderCloses", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'entitlementtemplate_PhoneCalls'
        /// </summary>
		[RelationshipSchemaName("entitlementtemplate_PhoneCalls")]
		public IEnumerable<PhoneCall> EntitlementtemplatePhoneCalls
		{
			get { return GetRelatedEntities<PhoneCall>("entitlementtemplate_PhoneCalls", null); }
			set { SetRelatedEntities("entitlementtemplate_PhoneCalls", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'entitlementtemplate_PrincipalObjectAttributeAccesses'
        /// </summary>
		[RelationshipSchemaName("entitlementtemplate_PrincipalObjectAttributeAccesses")]
		public IEnumerable<FieldSharing> EntitlementtemplatePrincipalObjectAttributeAccesses
		{
			get { return GetRelatedEntities<FieldSharing>("entitlementtemplate_PrincipalObjectAttributeAccesses", null); }
			set { SetRelatedEntities("entitlementtemplate_PrincipalObjectAttributeAccesses", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'entitlementtemplate_ProcessSession'
        /// </summary>
		[RelationshipSchemaName("entitlementtemplate_ProcessSession")]
		public IEnumerable<ProcessSession> EntitlementtemplateProcessSession
		{
			get { return GetRelatedEntities<ProcessSession>("entitlementtemplate_ProcessSession", null); }
			set { SetRelatedEntities("entitlementtemplate_ProcessSession", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'entitlementtemplate_QuoteCloses'
        /// </summary>
		[RelationshipSchemaName("entitlementtemplate_QuoteCloses")]
		public IEnumerable<QuoteClose> EntitlementtemplateQuoteCloses
		{
			get { return GetRelatedEntities<QuoteClose>("entitlementtemplate_QuoteCloses", null); }
			set { SetRelatedEntities("entitlementtemplate_QuoteCloses", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'entitlementtemplate_RecurringAppointmentMasters'
        /// </summary>
		[RelationshipSchemaName("entitlementtemplate_RecurringAppointmentMasters")]
		public IEnumerable<RecurringAppointment> EntitlementtemplateRecurringAppointmentMasters
		{
			get { return GetRelatedEntities<RecurringAppointment>("entitlementtemplate_RecurringAppointmentMasters", null); }
			set { SetRelatedEntities("entitlementtemplate_RecurringAppointmentMasters", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'entitlementtemplate_ServiceAppointments'
        /// </summary>
		[RelationshipSchemaName("entitlementtemplate_ServiceAppointments")]
		public IEnumerable<ServiceActivity> EntitlementtemplateServiceAppointments
		{
			get { return GetRelatedEntities<ServiceActivity>("entitlementtemplate_ServiceAppointments", null); }
			set { SetRelatedEntities("entitlementtemplate_ServiceAppointments", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'entitlementtemplate_SocialActivities'
        /// </summary>
		[RelationshipSchemaName("entitlementtemplate_SocialActivities")]
		public IEnumerable<SocialActivity> EntitlementtemplateSocialActivities
		{
			get { return GetRelatedEntities<SocialActivity>("entitlementtemplate_SocialActivities", null); }
			set { SetRelatedEntities("entitlementtemplate_SocialActivities", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'EntitlementTemplate_SyncErrors'
        /// </summary>
		[RelationshipSchemaName("EntitlementTemplate_SyncErrors")]
		public IEnumerable<SyncError> EntitlementTemplateSyncErrors
		{
			get { return GetRelatedEntities<SyncError>("EntitlementTemplate_SyncErrors", null); }
			set { SetRelatedEntities("EntitlementTemplate_SyncErrors", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'entitlementtemplate_Tasks'
        /// </summary>
		[RelationshipSchemaName("entitlementtemplate_Tasks")]
		public IEnumerable<Task> EntitlementtemplateTasks
		{
			get { return GetRelatedEntities<Task>("entitlementtemplate_Tasks", null); }
			set { SetRelatedEntities("entitlementtemplate_Tasks", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'entitlementtemplateid_RelationShip'
        /// </summary>
		[RelationshipSchemaName("entitlementtemplateid_RelationShip")]
		public IEnumerable<Entitlement> EntitlementtemplateidRelationShip
		{
			get { return GetRelatedEntities<Entitlement>("entitlementtemplateid_RelationShip", null); }
			set { SetRelatedEntities("entitlementtemplateid_RelationShip", null, value); }
		}
		/// <summary>
        /// N:N Get entities for 'Product'
        /// </summary>
		[RelationshipSchemaName("product_entitlementtemplate_association")]
		public IEnumerable<Product> ProductEntitlementtemplateAssociation
		{
			get { return GetRelatedEntities<Product>("product_entitlementtemplate_association", null); }
			set { SetRelatedEntities("product_entitlementtemplate_association", null, value); }
		}
		#endregion

		#region Actions
		#endregion

		#region OptionSetEnums
		public enum eAllocationType
		{	
		
			[Label("Number of cases")]
			[Description(@"Number of cases")]
			NumberOfCases = 0, 
		
			[Label("Number of hours")]
			[Description(@"Number of hours")]
			NumberOfHours = 1, 
		}
		
		public enum eDecreaseRemainingOn
		{	
		
			[Label("Case Resolution")]
			[Description(@"")]
			CaseResolution = 0, 
		
			[Label("Case Creation")]
			[Description(@"")]
			CaseCreation = 1, 
		}
		
		public enum eKBAccessLevel
		{	
		
			[Label("Standard")]
			[Description(@"Standard")]
			Standard = 0, 
		
			[Label("Premium")]
			[Description(@"Premium")]
			Premium = 1, 
		
			[Label("None")]
			[Description(@"None")]
			None = 2, 
		}
		
		public enum egEntityType
		{	
		
			[Label("Case")]
			[Description(@"")]
			Case = 0, 
		}
		
		#endregion	

		#region Properties
		public static class Properties 
		{
			/// <summary>allocationtypecode</summary>
			public const string AllocationType = "allocationtypecode";

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

			/// <summary>decreaseremainingon</summary>
			public const string DecreaseRemainingOn = "decreaseremainingon";

			/// <summary>description</summary>
			public const string Description = "description";

			/// <summary>enddate</summary>
			public const string EndDate = "enddate";

			/// <summary>entitlementtemplateid</summary>
			public const string EntitlementTemplateId = "entitlementtemplateid";

			/// <summary>entitytype</summary>
			public const string EntityType = "entitytype";

			/// <summary>exchangerate</summary>
			public const string ExchangeRate = "exchangerate";

			/// <summary>importsequencenumber</summary>
			public const string ImportSequenceNumber = "importsequencenumber";

			/// <summary>kbaccesslevel</summary>
			public const string KBAccessLevel = "kbaccesslevel";

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
			public const string EntitlementTemplateName = "name";

			/// <summary>organizationid</summary>
			public const string OrganizationId = "organizationid";

			/// <summary>organizationidname</summary>
			public const string Organizationidname = "organizationidname";

			/// <summary>overriddencreatedon</summary>
			public const string RecordCreatedOn = "overriddencreatedon";

			/// <summary>restrictcasecreation</summary>
			public const string RestrictByEntitlementTerms = "restrictcasecreation";

			/// <summary>slaid</summary>
			public const string SLA = "slaid";

			/// <summary>slaidname</summary>
			public const string Slaidname = "slaidname";

			/// <summary>startdate</summary>
			public const string StartDate = "startdate";

			/// <summary>timezoneruleversionnumber</summary>
			public const string TimeZoneRuleVersionNumber = "timezoneruleversionnumber";

			/// <summary>totalterms</summary>
			public const string TotalTerms = "totalterms";

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
			/// <summary>1:N entitlementtemplate_ActivityPointers</summary>
			public const string EntitlementtemplateActivityPointers = "entitlementtemplate_ActivityPointers";

			/// <summary>1:N entitlementtemplate_Annotations</summary>
			public const string EntitlementtemplateAnnotations = "entitlementtemplate_Annotations";

			/// <summary>1:N entitlementtemplate_Appointments</summary>
			public const string EntitlementtemplateAppointments = "entitlementtemplate_Appointments";

			/// <summary>1:N entitlementtemplate_AsyncOperations</summary>
			public const string EntitlementtemplateAsyncOperations = "entitlementtemplate_AsyncOperations";

			/// <summary>1:N entitlementtemplate_BulkDeleteFailures</summary>
			public const string EntitlementtemplateBulkDeleteFailures = "entitlementtemplate_BulkDeleteFailures";

			/// <summary>1:N entitlementtemplate_DuplicateBaseRecord</summary>
			public const string EntitlementtemplateDuplicateBaseRecord = "entitlementtemplate_DuplicateBaseRecord";

			/// <summary>1:N entitlementtemplate_DuplicateMatchingRecord</summary>
			public const string EntitlementtemplateDuplicateMatchingRecord = "entitlementtemplate_DuplicateMatchingRecord";

			/// <summary>1:N entitlementtemplate_Emails</summary>
			public const string EntitlementtemplateEmails = "entitlementtemplate_Emails";

			/// <summary>1:N entitlementtemplate_entitlementchannel_entitlementtemplateid</summary>
			public const string EntitlementtemplateEntitlementchannelEntitlementtemplateid = "entitlementtemplate_entitlementchannel_entitlementtemplateid";

			/// <summary>1:N entitlementtemplate_Faxes</summary>
			public const string EntitlementtemplateFaxes = "entitlementtemplate_Faxes";

			/// <summary>1:N entitlementtemplate_IncidentResolutions</summary>
			public const string EntitlementtemplateIncidentResolutions = "entitlementtemplate_IncidentResolutions";

			/// <summary>1:N entitlementtemplate_Letters</summary>
			public const string EntitlementtemplateLetters = "entitlementtemplate_Letters";

			/// <summary>1:N EntitlementTemplate_MailboxTrackingFolder</summary>
			public const string EntitlementTemplateMailboxTrackingFolder = "EntitlementTemplate_MailboxTrackingFolder";

			/// <summary>1:N entitlementtemplate_OpportunityCloses</summary>
			public const string EntitlementtemplateOpportunityCloses = "entitlementtemplate_OpportunityCloses";

			/// <summary>1:N entitlementtemplate_OrderCloses</summary>
			public const string EntitlementtemplateOrderCloses = "entitlementtemplate_OrderCloses";

			/// <summary>1:N entitlementtemplate_PhoneCalls</summary>
			public const string EntitlementtemplatePhoneCalls = "entitlementtemplate_PhoneCalls";

			/// <summary>1:N entitlementtemplate_PrincipalObjectAttributeAccesses</summary>
			public const string EntitlementtemplatePrincipalObjectAttributeAccesses = "entitlementtemplate_PrincipalObjectAttributeAccesses";

			/// <summary>1:N entitlementtemplate_ProcessSession</summary>
			public const string EntitlementtemplateProcessSession = "entitlementtemplate_ProcessSession";

			/// <summary>1:N entitlementtemplate_QuoteCloses</summary>
			public const string EntitlementtemplateQuoteCloses = "entitlementtemplate_QuoteCloses";

			/// <summary>1:N entitlementtemplate_RecurringAppointmentMasters</summary>
			public const string EntitlementtemplateRecurringAppointmentMasters = "entitlementtemplate_RecurringAppointmentMasters";

			/// <summary>1:N entitlementtemplate_ServiceAppointments</summary>
			public const string EntitlementtemplateServiceAppointments = "entitlementtemplate_ServiceAppointments";

			/// <summary>1:N entitlementtemplate_SocialActivities</summary>
			public const string EntitlementtemplateSocialActivities = "entitlementtemplate_SocialActivities";

			/// <summary>1:N EntitlementTemplate_SyncErrors</summary>
			public const string EntitlementTemplateSyncErrors = "EntitlementTemplate_SyncErrors";

			/// <summary>1:N entitlementtemplate_Tasks</summary>
			public const string EntitlementtemplateTasks = "entitlementtemplate_Tasks";

			/// <summary>1:N entitlementtemplateid_RelationShip</summary>
			public const string EntitlementtemplateidRelationShip = "entitlementtemplateid_RelationShip";

			/// <summary>N:N product_entitlementtemplate_association</summary>
			public const string ProductEntitlementtemplateAssociation = "product_entitlementtemplate_association";

		}
		#endregion
	}
}

