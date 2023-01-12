using System;
using System.Linq;
using System.Diagnostics;
using System.ComponentModel;
using Microsoft.Xrm.Sdk; 
using Microsoft.Xrm.Sdk.Client;
using System.Collections.Generic;

namespace PentaWork.Xrm.Scheduler.Proxies.Entities
{
	[DebuggerDisplay("{TerritoryName}")] 	
	[EntityLogicalName("territory")]
	public sealed class Territory : Entity
	{	
		public static readonly int? EntityTypeCode = 2013;
		public new const string LogicalName = "territory";
		public const string PrimaryIdAttribute = "territoryid";
		public const string PrimaryNameAttribute = "name";
	
		public Territory() : base("territory") { }

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
        /// managerid
        /// </summary>
		[DisplayName("Manager")]
		[AttributeLogicalName("managerid")]
		public EntityReference Manager
		{	
			get { return GetAttributeValue<EntityReference>("managerid"); }
			set
			{ 
				if(value == Manager) return;
				SetAttributeValue("managerid", value);
			}
		}	
			
		/// <summary>
        /// manageridname
        /// </summary>
		[DisplayName("manageridname")]
		[AttributeLogicalName("manageridname")]
		public string Manageridname
		{	
			get { return GetAttributeValue<string>("manageridname"); }
			set
			{ 
				if(value == Manageridname) return;
				SetAttributeValue("manageridname", value);
			}
		}	
			
		/// <summary>
        /// manageridyominame
        /// </summary>
		[DisplayName("manageridyominame")]
		[AttributeLogicalName("manageridyominame")]
		public string Manageridyominame
		{	
			get { return GetAttributeValue<string>("manageridyominame"); }
			set
			{ 
				if(value == Manageridyominame) return;
				SetAttributeValue("manageridyominame", value);
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
		[DisplayName("Territory Name")]
		[AttributeLogicalName("name")]
		public string TerritoryName
		{	
			get { return GetAttributeValue<string>("name"); }
			set
			{ 
				if(value == TerritoryName) return;
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
        /// parentterritoryid
        /// </summary>
		[DisplayName("Parent")]
		[AttributeLogicalName("parentterritoryid")]
		public EntityReference Parent
		{	
			get { return GetAttributeValue<EntityReference>("parentterritoryid"); }
			set
			{ 
				if(value == Parent) return;
				SetAttributeValue("parentterritoryid", value);
			}
		}	
			
		/// <summary>
        /// parentterritoryidname
        /// </summary>
		[DisplayName("parentterritoryidname")]
		[AttributeLogicalName("parentterritoryidname")]
		public string Parentterritoryidname
		{	
			get { return GetAttributeValue<string>("parentterritoryidname"); }
			set
			{ 
				if(value == Parentterritoryidname) return;
				SetAttributeValue("parentterritoryidname", value);
			}
		}	
			
		/// <summary>
        /// territoryid
        /// </summary>
		[DisplayName("Territory")]
		[AttributeLogicalName("territoryid")]
		public override Guid Id
		{
			get => base.Id;
			set { base.Id = value; SetAttributeValue("territoryid", value); }
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
        /// 1:N Get entities for 'territory_accounts'
        /// </summary>
		[RelationshipSchemaName("territory_accounts")]
		public IEnumerable<Account> TerritoryAccounts
		{
			get { return GetRelatedEntities<Account>("territory_accounts", null); }
			set { SetRelatedEntities("territory_accounts", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'Territory_AsyncOperations'
        /// </summary>
		[RelationshipSchemaName("Territory_AsyncOperations")]
		public IEnumerable<SystemJob> TerritoryAsyncOperations
		{
			get { return GetRelatedEntities<SystemJob>("Territory_AsyncOperations", null); }
			set { SetRelatedEntities("Territory_AsyncOperations", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'Territory_BulkDeleteFailures'
        /// </summary>
		[RelationshipSchemaName("Territory_BulkDeleteFailures")]
		public IEnumerable<BulkDeleteFailure> TerritoryBulkDeleteFailures
		{
			get { return GetRelatedEntities<BulkDeleteFailure>("Territory_BulkDeleteFailures", null); }
			set { SetRelatedEntities("Territory_BulkDeleteFailures", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'territory_connections1'
        /// </summary>
		[RelationshipSchemaName("territory_connections1")]
		public IEnumerable<Connection> TerritoryConnections1
		{
			get { return GetRelatedEntities<Connection>("territory_connections1", null); }
			set { SetRelatedEntities("territory_connections1", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'territory_connections2'
        /// </summary>
		[RelationshipSchemaName("territory_connections2")]
		public IEnumerable<Connection> TerritoryConnections2
		{
			get { return GetRelatedEntities<Connection>("territory_connections2", null); }
			set { SetRelatedEntities("territory_connections2", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'Territory_DuplicateBaseRecord'
        /// </summary>
		[RelationshipSchemaName("Territory_DuplicateBaseRecord")]
		public IEnumerable<DuplicateRecord> TerritoryDuplicateBaseRecord
		{
			get { return GetRelatedEntities<DuplicateRecord>("Territory_DuplicateBaseRecord", null); }
			set { SetRelatedEntities("Territory_DuplicateBaseRecord", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'Territory_DuplicateMatchingRecord'
        /// </summary>
		[RelationshipSchemaName("Territory_DuplicateMatchingRecord")]
		public IEnumerable<DuplicateRecord> TerritoryDuplicateMatchingRecord
		{
			get { return GetRelatedEntities<DuplicateRecord>("Territory_DuplicateMatchingRecord", null); }
			set { SetRelatedEntities("Territory_DuplicateMatchingRecord", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'territory_MailboxTrackingFolders'
        /// </summary>
		[RelationshipSchemaName("territory_MailboxTrackingFolders")]
		public IEnumerable<MailboxAutoTrackingFolder> TerritoryMailboxTrackingFolders
		{
			get { return GetRelatedEntities<MailboxAutoTrackingFolder>("territory_MailboxTrackingFolders", null); }
			set { SetRelatedEntities("territory_MailboxTrackingFolders", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'territory_parent_territory'
        /// </summary>
		[RelationshipSchemaName("territory_parent_territory")]
		public IEnumerable<Territory> TerritoryParentTerritory
		{
			get { return GetRelatedEntities<Territory>("territory_parent_territory", null); }
			set { SetRelatedEntities("territory_parent_territory", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'territory_principalobjectattributeaccess'
        /// </summary>
		[RelationshipSchemaName("territory_principalobjectattributeaccess")]
		public IEnumerable<FieldSharing> TerritoryPrincipalobjectattributeaccess
		{
			get { return GetRelatedEntities<FieldSharing>("territory_principalobjectattributeaccess", null); }
			set { SetRelatedEntities("territory_principalobjectattributeaccess", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'Territory_ProcessSessions'
        /// </summary>
		[RelationshipSchemaName("Territory_ProcessSessions")]
		public IEnumerable<ProcessSession> TerritoryProcessSessions
		{
			get { return GetRelatedEntities<ProcessSession>("Territory_ProcessSessions", null); }
			set { SetRelatedEntities("Territory_ProcessSessions", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'Territory_SyncErrors'
        /// </summary>
		[RelationshipSchemaName("Territory_SyncErrors")]
		public IEnumerable<SyncError> TerritorySyncErrors
		{
			get { return GetRelatedEntities<SyncError>("Territory_SyncErrors", null); }
			set { SetRelatedEntities("Territory_SyncErrors", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'territory_system_users'
        /// </summary>
		[RelationshipSchemaName("territory_system_users")]
		public IEnumerable<User> TerritorySystemUsers
		{
			get { return GetRelatedEntities<User>("territory_system_users", null); }
			set { SetRelatedEntities("territory_system_users", null, value); }
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

			/// <summary>importsequencenumber</summary>
			public const string ImportSequenceNumber = "importsequencenumber";

			/// <summary>managerid</summary>
			public const string Manager = "managerid";

			/// <summary>manageridname</summary>
			public const string Manageridname = "manageridname";

			/// <summary>manageridyominame</summary>
			public const string Manageridyominame = "manageridyominame";

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
			public const string TerritoryName = "name";

			/// <summary>organizationid</summary>
			public const string OrganizationId = "organizationid";

			/// <summary>organizationidname</summary>
			public const string Organizationidname = "organizationidname";

			/// <summary>overriddencreatedon</summary>
			public const string RecordCreatedOn = "overriddencreatedon";

			/// <summary>parentterritoryid</summary>
			public const string Parent = "parentterritoryid";

			/// <summary>parentterritoryidname</summary>
			public const string Parentterritoryidname = "parentterritoryidname";

			/// <summary>territoryid</summary>
			public const string TerritoryId = "territoryid";

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
			/// <summary>1:N territory_accounts</summary>
			public const string TerritoryAccounts = "territory_accounts";

			/// <summary>1:N Territory_AsyncOperations</summary>
			public const string TerritoryAsyncOperations = "Territory_AsyncOperations";

			/// <summary>1:N Territory_BulkDeleteFailures</summary>
			public const string TerritoryBulkDeleteFailures = "Territory_BulkDeleteFailures";

			/// <summary>1:N territory_connections1</summary>
			public const string TerritoryConnections1 = "territory_connections1";

			/// <summary>1:N territory_connections2</summary>
			public const string TerritoryConnections2 = "territory_connections2";

			/// <summary>1:N Territory_DuplicateBaseRecord</summary>
			public const string TerritoryDuplicateBaseRecord = "Territory_DuplicateBaseRecord";

			/// <summary>1:N Territory_DuplicateMatchingRecord</summary>
			public const string TerritoryDuplicateMatchingRecord = "Territory_DuplicateMatchingRecord";

			/// <summary>1:N territory_MailboxTrackingFolders</summary>
			public const string TerritoryMailboxTrackingFolders = "territory_MailboxTrackingFolders";

			/// <summary>1:N territory_parent_territory</summary>
			public const string TerritoryParentTerritory = "territory_parent_territory";

			/// <summary>1:N territory_principalobjectattributeaccess</summary>
			public const string TerritoryPrincipalobjectattributeaccess = "territory_principalobjectattributeaccess";

			/// <summary>1:N Territory_ProcessSessions</summary>
			public const string TerritoryProcessSessions = "Territory_ProcessSessions";

			/// <summary>1:N Territory_SyncErrors</summary>
			public const string TerritorySyncErrors = "Territory_SyncErrors";

			/// <summary>1:N territory_system_users</summary>
			public const string TerritorySystemUsers = "territory_system_users";

		}
		#endregion
	}
}

