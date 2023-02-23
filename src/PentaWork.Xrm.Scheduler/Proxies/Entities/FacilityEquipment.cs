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
	[EntityLogicalName("equipment")]
	public sealed class FacilityEquipment : Entity
	{	
		public static readonly int? EntityTypeCode = 4000;
		public new const string LogicalName = "equipment";
		public const string PrimaryIdAttribute = "equipmentid";
		public const string PrimaryNameAttribute = "name";
	
		public FacilityEquipment() : base("equipment") { }

		#region Attributes
		/// <summary>
        /// businessunitid
        /// </summary>
		[DisplayName("Business Unit")]
		[AttributeLogicalName("businessunitid")]
		public EntityReference BusinessUnit
		{	
			get { return GetAttributeValue<EntityReference>("businessunitid"); }
			set
			{ 
				if(value == BusinessUnit) return;
				SetAttributeValue("businessunitid", value);
			}
		}	
			
		/// <summary>
        /// businessunitidname
        /// </summary>
		[DisplayName("businessunitidname")]
		[AttributeLogicalName("businessunitidname")]
		public string Businessunitidname
		{	
			get { return GetAttributeValue<string>("businessunitidname"); }
			set
			{ 
				if(value == Businessunitidname) return;
				SetAttributeValue("businessunitidname", value);
			}
		}	
			
		/// <summary>
        /// calendarid
        /// </summary>
		[DisplayName("Calendar")]
		[AttributeLogicalName("calendarid")]
		public EntityReference Calendar
		{	
			get { return GetAttributeValue<EntityReference>("calendarid"); }
			set
			{ 
				if(value == Calendar) return;
				SetAttributeValue("calendarid", value);
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
        /// displayinserviceviews
        /// </summary>
		[DisplayName("Display in Service Views")]
		[AttributeLogicalName("displayinserviceviews")]
		public bool? DisplayInServiceViews
		{	
			get { return GetAttributeValue<bool?>("displayinserviceviews"); }
			set
			{ 
				if(value == DisplayInServiceViews) return;
				SetAttributeValue("displayinserviceviews", value);
			}
		}	
			
		/// <summary>
        /// emailaddress
        /// </summary>
		[DisplayName("Primary Email")]
		[AttributeLogicalName("emailaddress")]
		public string PrimaryEmail
		{	
			get { return GetAttributeValue<string>("emailaddress"); }
			set
			{ 
				if(value == PrimaryEmail) return;
				SetAttributeValue("emailaddress", value);
			}
		}	
			
		/// <summary>
        /// equipmentid
        /// </summary>
		[DisplayName("Facility/Equipment")]
		[AttributeLogicalName("equipmentid")]
		public override Guid Id
		{
			get => base.Id;
			set { base.Id = value; SetAttributeValue("equipmentid", value); }
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
        /// isdisabled
        /// </summary>
		[DisplayName("Is Disabled")]
		[AttributeLogicalName("isdisabled")]
		public bool? IsDisabled
		{	
			get { return GetAttributeValue<bool?>("isdisabled"); }
			set
			{ 
				if(value == IsDisabled) return;
				SetAttributeValue("isdisabled", value);
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
        /// siteid
        /// </summary>
		[DisplayName("Site")]
		[AttributeLogicalName("siteid")]
		public EntityReference Site
		{	
			get { return GetAttributeValue<EntityReference>("siteid"); }
			set
			{ 
				if(value == Site) return;
				SetAttributeValue("siteid", value);
			}
		}	
			
		/// <summary>
        /// siteidname
        /// </summary>
		[DisplayName("siteidname")]
		[AttributeLogicalName("siteidname")]
		public string Siteidname
		{	
			get { return GetAttributeValue<string>("siteidname"); }
			set
			{ 
				if(value == Siteidname) return;
				SetAttributeValue("siteidname", value);
			}
		}	
			
		/// <summary>
        /// skills
        /// </summary>
		[DisplayName("Skills")]
		[AttributeLogicalName("skills")]
		public string Skills
		{	
			get { return GetAttributeValue<string>("skills"); }
			set
			{ 
				if(value == Skills) return;
				SetAttributeValue("skills", value);
			}
		}	
			
		/// <summary>
        /// timezonecode
        /// </summary>
		[DisplayName("Time Zone")]
		[AttributeLogicalName("timezonecode")]
		public int? TimeZone
		{	
			get { return GetAttributeValue<int?>("timezonecode"); }
			set
			{ 
				if(value == TimeZone) return;
				SetAttributeValue("timezonecode", value);
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
        /// 1:N Get entities for 'equipment_accounts'
        /// </summary>
		[RelationshipSchemaName("equipment_accounts")]
		public IEnumerable<Account> EquipmentAccounts
		{
			get { return GetRelatedEntities<Account>("equipment_accounts", null); }
			set { SetRelatedEntities("equipment_accounts", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'equipment_activity_parties'
        /// </summary>
		[RelationshipSchemaName("equipment_activity_parties")]
		public IEnumerable<ActivityParty> EquipmentActivityParties
		{
			get { return GetRelatedEntities<ActivityParty>("equipment_activity_parties", null); }
			set { SetRelatedEntities("equipment_activity_parties", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'Equipment_Annotation'
        /// </summary>
		[RelationshipSchemaName("Equipment_Annotation")]
		public IEnumerable<Note> EquipmentAnnotation
		{
			get { return GetRelatedEntities<Note>("Equipment_Annotation", null); }
			set { SetRelatedEntities("Equipment_Annotation", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'Equipment_AsyncOperations'
        /// </summary>
		[RelationshipSchemaName("Equipment_AsyncOperations")]
		public IEnumerable<SystemJob> EquipmentAsyncOperations
		{
			get { return GetRelatedEntities<SystemJob>("Equipment_AsyncOperations", null); }
			set { SetRelatedEntities("Equipment_AsyncOperations", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'Equipment_BulkDeleteFailures'
        /// </summary>
		[RelationshipSchemaName("Equipment_BulkDeleteFailures")]
		public IEnumerable<BulkDeleteFailure> EquipmentBulkDeleteFailures
		{
			get { return GetRelatedEntities<BulkDeleteFailure>("Equipment_BulkDeleteFailures", null); }
			set { SetRelatedEntities("Equipment_BulkDeleteFailures", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'equipment_connections1'
        /// </summary>
		[RelationshipSchemaName("equipment_connections1")]
		public IEnumerable<Connection> EquipmentConnections1
		{
			get { return GetRelatedEntities<Connection>("equipment_connections1", null); }
			set { SetRelatedEntities("equipment_connections1", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'equipment_connections2'
        /// </summary>
		[RelationshipSchemaName("equipment_connections2")]
		public IEnumerable<Connection> EquipmentConnections2
		{
			get { return GetRelatedEntities<Connection>("equipment_connections2", null); }
			set { SetRelatedEntities("equipment_connections2", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'equipment_contacts'
        /// </summary>
		[RelationshipSchemaName("equipment_contacts")]
		public IEnumerable<Contact> EquipmentContacts
		{
			get { return GetRelatedEntities<Contact>("equipment_contacts", null); }
			set { SetRelatedEntities("equipment_contacts", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'Equipment_DuplicateBaseRecord'
        /// </summary>
		[RelationshipSchemaName("Equipment_DuplicateBaseRecord")]
		public IEnumerable<DuplicateRecord> EquipmentDuplicateBaseRecord
		{
			get { return GetRelatedEntities<DuplicateRecord>("Equipment_DuplicateBaseRecord", null); }
			set { SetRelatedEntities("Equipment_DuplicateBaseRecord", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'Equipment_DuplicateMatchingRecord'
        /// </summary>
		[RelationshipSchemaName("Equipment_DuplicateMatchingRecord")]
		public IEnumerable<DuplicateRecord> EquipmentDuplicateMatchingRecord
		{
			get { return GetRelatedEntities<DuplicateRecord>("Equipment_DuplicateMatchingRecord", null); }
			set { SetRelatedEntities("Equipment_DuplicateMatchingRecord", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'Equipment_Email_EmailSender'
        /// </summary>
		[RelationshipSchemaName("Equipment_Email_EmailSender")]
		public IEnumerable<Email> EquipmentEmailEmailSender
		{
			get { return GetRelatedEntities<Email>("Equipment_Email_EmailSender", null); }
			set { SetRelatedEntities("Equipment_Email_EmailSender", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'equipment_MailboxTrackingFolders'
        /// </summary>
		[RelationshipSchemaName("equipment_MailboxTrackingFolders")]
		public IEnumerable<MailboxAutoTrackingFolder> EquipmentMailboxTrackingFolders
		{
			get { return GetRelatedEntities<MailboxAutoTrackingFolder>("equipment_MailboxTrackingFolders", null); }
			set { SetRelatedEntities("equipment_MailboxTrackingFolders", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'equipment_principalobjectattributeaccess'
        /// </summary>
		[RelationshipSchemaName("equipment_principalobjectattributeaccess")]
		public IEnumerable<FieldSharing> EquipmentPrincipalobjectattributeaccess
		{
			get { return GetRelatedEntities<FieldSharing>("equipment_principalobjectattributeaccess", null); }
			set { SetRelatedEntities("equipment_principalobjectattributeaccess", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'Equipment_ProcessSessions'
        /// </summary>
		[RelationshipSchemaName("Equipment_ProcessSessions")]
		public IEnumerable<ProcessSession> EquipmentProcessSessions
		{
			get { return GetRelatedEntities<ProcessSession>("Equipment_ProcessSessions", null); }
			set { SetRelatedEntities("Equipment_ProcessSessions", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'equipment_resources'
        /// </summary>
		[RelationshipSchemaName("equipment_resources")]
		public IEnumerable<Resource> EquipmentResources
		{
			get { return GetRelatedEntities<Resource>("equipment_resources", null); }
			set { SetRelatedEntities("equipment_resources", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'Equipment_SyncErrors'
        /// </summary>
		[RelationshipSchemaName("Equipment_SyncErrors")]
		public IEnumerable<SyncError> EquipmentSyncErrors
		{
			get { return GetRelatedEntities<SyncError>("Equipment_SyncErrors", null); }
			set { SetRelatedEntities("Equipment_SyncErrors", null, value); }
		}
		#endregion

		#region Actions
		#endregion

		#region OptionSetEnums
		#endregion	

		#region Properties
		public static class Properties 
		{
			/// <summary>businessunitid</summary>
			public const string BusinessUnit = "businessunitid";

			/// <summary>businessunitidname</summary>
			public const string Businessunitidname = "businessunitidname";

			/// <summary>calendarid</summary>
			public const string Calendar = "calendarid";

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

			/// <summary>displayinserviceviews</summary>
			public const string DisplayInServiceViews = "displayinserviceviews";

			/// <summary>emailaddress</summary>
			public const string PrimaryEmail = "emailaddress";

			/// <summary>equipmentid</summary>
			public const string FacilityEquipmentId = "equipmentid";

			/// <summary>exchangerate</summary>
			public const string ExchangeRate = "exchangerate";

			/// <summary>importsequencenumber</summary>
			public const string ImportSequenceNumber = "importsequencenumber";

			/// <summary>isdisabled</summary>
			public const string IsDisabled = "isdisabled";

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
			public const string Organization = "organizationid";

			/// <summary>organizationidname</summary>
			public const string Organizationidname = "organizationidname";

			/// <summary>overriddencreatedon</summary>
			public const string RecordCreatedOn = "overriddencreatedon";

			/// <summary>siteid</summary>
			public const string Site = "siteid";

			/// <summary>siteidname</summary>
			public const string Siteidname = "siteidname";

			/// <summary>skills</summary>
			public const string Skills = "skills";

			/// <summary>timezonecode</summary>
			public const string TimeZone = "timezonecode";

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
			/// <summary>1:N equipment_accounts</summary>
			public const string EquipmentAccounts = "equipment_accounts";

			/// <summary>1:N equipment_activity_parties</summary>
			public const string EquipmentActivityParties = "equipment_activity_parties";

			/// <summary>1:N Equipment_Annotation</summary>
			public const string EquipmentAnnotation = "Equipment_Annotation";

			/// <summary>1:N Equipment_AsyncOperations</summary>
			public const string EquipmentAsyncOperations = "Equipment_AsyncOperations";

			/// <summary>1:N Equipment_BulkDeleteFailures</summary>
			public const string EquipmentBulkDeleteFailures = "Equipment_BulkDeleteFailures";

			/// <summary>1:N equipment_connections1</summary>
			public const string EquipmentConnections1 = "equipment_connections1";

			/// <summary>1:N equipment_connections2</summary>
			public const string EquipmentConnections2 = "equipment_connections2";

			/// <summary>1:N equipment_contacts</summary>
			public const string EquipmentContacts = "equipment_contacts";

			/// <summary>1:N Equipment_DuplicateBaseRecord</summary>
			public const string EquipmentDuplicateBaseRecord = "Equipment_DuplicateBaseRecord";

			/// <summary>1:N Equipment_DuplicateMatchingRecord</summary>
			public const string EquipmentDuplicateMatchingRecord = "Equipment_DuplicateMatchingRecord";

			/// <summary>1:N Equipment_Email_EmailSender</summary>
			public const string EquipmentEmailEmailSender = "Equipment_Email_EmailSender";

			/// <summary>1:N equipment_MailboxTrackingFolders</summary>
			public const string EquipmentMailboxTrackingFolders = "equipment_MailboxTrackingFolders";

			/// <summary>1:N equipment_principalobjectattributeaccess</summary>
			public const string EquipmentPrincipalobjectattributeaccess = "equipment_principalobjectattributeaccess";

			/// <summary>1:N Equipment_ProcessSessions</summary>
			public const string EquipmentProcessSessions = "Equipment_ProcessSessions";

			/// <summary>1:N equipment_resources</summary>
			public const string EquipmentResources = "equipment_resources";

			/// <summary>1:N Equipment_SyncErrors</summary>
			public const string EquipmentSyncErrors = "Equipment_SyncErrors";

		}
		#endregion
	}
}

