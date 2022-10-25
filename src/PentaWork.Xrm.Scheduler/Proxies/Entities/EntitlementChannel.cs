using System;
using System.Linq;
using System.Diagnostics;
using System.ComponentModel;
using Microsoft.Xrm.Sdk; 
using Microsoft.Xrm.Sdk.Client;
using System.Collections.Generic;

namespace PentaWork.Xrm.Scheduler.Proxies.Entities
{
	[DebuggerDisplay("{EntitlementChannelName}")] 	
	[EntityLogicalName("entitlementchannel")]
	public sealed class EntitlementChannel : Entity
	{	
		public static readonly int? EntityTypeCode = 9701;
		public new const string LogicalName = "entitlementchannel";
		public const string PrimaryIdAttribute = "entitlementchannelid";
		public const string PrimaryNameAttribute = "name";
	
		public EntitlementChannel() : base("entitlementchannel") { }

		#region Attributes
		/// <summary>
        /// channel
        /// </summary>
		[DisplayName("Name")]
		[AttributeLogicalName("channel")]
		public egCaseOrigin? Name
		{	
			get 
			{ 
				var optionSetValue = GetAttributeValue<OptionSetValue>("channel");
				if (optionSetValue != null) return (egCaseOrigin)optionSetValue.Value;
				else return null;
			}
			set 
			{ 
				if(value == Name) return;

				OptionSetValue optionSetValue = null;
				if(value != null) optionSetValue = new OptionSetValue((int)value);
				SetAttributeValue("channel", optionSetValue); 
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
        /// entitlementchannelid
        /// </summary>
		[DisplayName("Entitlement Channel")]
		[AttributeLogicalName("entitlementchannelid")]
		public override Guid Id
		{
			get => base.Id;
			set { base.Id = value; SetAttributeValue("entitlementchannelid", value); }
		}

							/// <summary>
        /// entitlementid
        /// </summary>
		[DisplayName("Entitlement")]
		[AttributeLogicalName("entitlementid")]
		public EntityReference Entitlement
		{	
			get { return GetAttributeValue<EntityReference>("entitlementid"); }
			set
			{ 
				if(value == Entitlement) return;
				SetAttributeValue("entitlementid", value);
			}
		}	
			
		/// <summary>
        /// entitlementidname
        /// </summary>
		[DisplayName("entitlementidname")]
		[AttributeLogicalName("entitlementidname")]
		public string Entitlementidname
		{	
			get { return GetAttributeValue<string>("entitlementidname"); }
			set
			{ 
				if(value == Entitlementidname) return;
				SetAttributeValue("entitlementidname", value);
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
		[DisplayName("Entitlement Channel Name")]
		[AttributeLogicalName("name")]
		public string EntitlementChannelName
		{	
			get { return GetAttributeValue<string>("name"); }
			set
			{ 
				if(value == EntitlementChannelName) return;
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
        /// owneridname
        /// </summary>
		[DisplayName("owneridname")]
		[AttributeLogicalName("owneridname")]
		public string Owneridname
		{	
			get { return GetAttributeValue<string>("owneridname"); }
			set
			{ 
				if(value == Owneridname) return;
				SetAttributeValue("owneridname", value);
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
        /// owneridyominame
        /// </summary>
		[DisplayName("owneridyominame")]
		[AttributeLogicalName("owneridyominame")]
		public string Owneridyominame
		{	
			get { return GetAttributeValue<string>("owneridyominame"); }
			set
			{ 
				if(value == Owneridyominame) return;
				SetAttributeValue("owneridyominame", value);
			}
		}	
			
		/// <summary>
        /// owningbusinessunit
        /// </summary>
		[DisplayName("Owning Business Unit")]
		[AttributeLogicalName("owningbusinessunit")]
		public EntityReference OwningBusinessUnit
		{	
			get { return GetAttributeValue<EntityReference>("owningbusinessunit"); }
			set
			{ 
				if(value == OwningBusinessUnit) return;
				SetAttributeValue("owningbusinessunit", value);
			}
		}	
			
		/// <summary>
        /// owningteam
        /// </summary>
		[DisplayName("Owning Team")]
		[AttributeLogicalName("owningteam")]
		public EntityReference OwningTeam
		{	
			get { return GetAttributeValue<EntityReference>("owningteam"); }
			set
			{ 
				if(value == OwningTeam) return;
				SetAttributeValue("owningteam", value);
			}
		}	
			
		/// <summary>
        /// owninguser
        /// </summary>
		[DisplayName("Owning User")]
		[AttributeLogicalName("owninguser")]
		public EntityReference OwningUser
		{	
			get { return GetAttributeValue<EntityReference>("owninguser"); }
			set
			{ 
				if(value == OwningUser) return;
				SetAttributeValue("owninguser", value);
			}
		}	
			
		/// <summary>
        /// remainingterms
        /// </summary>
		[DisplayName("Remaining Terms")]
		[AttributeLogicalName("remainingterms")]
		public decimal? RemainingTerms
		{	
			get { return GetAttributeValue<decimal?>("remainingterms"); }
			set
			{ 
				if(value == RemainingTerms) return;
				SetAttributeValue("remainingterms", value);
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
        /// 1:N Get entities for 'entitlementchannel_Annotations'
        /// </summary>
		[RelationshipSchemaName("entitlementchannel_Annotations")]
		public IEnumerable<Note> EntitlementchannelAnnotations
		{
			get { return GetRelatedEntities<Note>("entitlementchannel_Annotations", null); }
			set { SetRelatedEntities("entitlementchannel_Annotations", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'entitlementchannel_AsyncOperations'
        /// </summary>
		[RelationshipSchemaName("entitlementchannel_AsyncOperations")]
		public IEnumerable<SystemJob> EntitlementchannelAsyncOperations
		{
			get { return GetRelatedEntities<SystemJob>("entitlementchannel_AsyncOperations", null); }
			set { SetRelatedEntities("entitlementchannel_AsyncOperations", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'entitlementchannel_BulkDeleteFailures'
        /// </summary>
		[RelationshipSchemaName("entitlementchannel_BulkDeleteFailures")]
		public IEnumerable<BulkDeleteFailure> EntitlementchannelBulkDeleteFailures
		{
			get { return GetRelatedEntities<BulkDeleteFailure>("entitlementchannel_BulkDeleteFailures", null); }
			set { SetRelatedEntities("entitlementchannel_BulkDeleteFailures", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'entitlementchannel_connections1'
        /// </summary>
		[RelationshipSchemaName("entitlementchannel_connections1")]
		public IEnumerable<Connection> EntitlementchannelConnections1
		{
			get { return GetRelatedEntities<Connection>("entitlementchannel_connections1", null); }
			set { SetRelatedEntities("entitlementchannel_connections1", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'entitlementchannel_connections2'
        /// </summary>
		[RelationshipSchemaName("entitlementchannel_connections2")]
		public IEnumerable<Connection> EntitlementchannelConnections2
		{
			get { return GetRelatedEntities<Connection>("entitlementchannel_connections2", null); }
			set { SetRelatedEntities("entitlementchannel_connections2", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'entitlementchannel_DuplicateBaseRecord'
        /// </summary>
		[RelationshipSchemaName("entitlementchannel_DuplicateBaseRecord")]
		public IEnumerable<DuplicateRecord> EntitlementchannelDuplicateBaseRecord
		{
			get { return GetRelatedEntities<DuplicateRecord>("entitlementchannel_DuplicateBaseRecord", null); }
			set { SetRelatedEntities("entitlementchannel_DuplicateBaseRecord", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'entitlementchannel_DuplicateMatchingRecord'
        /// </summary>
		[RelationshipSchemaName("entitlementchannel_DuplicateMatchingRecord")]
		public IEnumerable<DuplicateRecord> EntitlementchannelDuplicateMatchingRecord
		{
			get { return GetRelatedEntities<DuplicateRecord>("entitlementchannel_DuplicateMatchingRecord", null); }
			set { SetRelatedEntities("entitlementchannel_DuplicateMatchingRecord", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'entitlementchannel_MailboxTrackingFolders'
        /// </summary>
		[RelationshipSchemaName("entitlementchannel_MailboxTrackingFolders")]
		public IEnumerable<MailboxAutoTrackingFolder> EntitlementchannelMailboxTrackingFolders
		{
			get { return GetRelatedEntities<MailboxAutoTrackingFolder>("entitlementchannel_MailboxTrackingFolders", null); }
			set { SetRelatedEntities("entitlementchannel_MailboxTrackingFolders", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'entitlementchannel_PrincipalObjectAttributeAccesses'
        /// </summary>
		[RelationshipSchemaName("entitlementchannel_PrincipalObjectAttributeAccesses")]
		public IEnumerable<FieldSharing> EntitlementchannelPrincipalObjectAttributeAccesses
		{
			get { return GetRelatedEntities<FieldSharing>("entitlementchannel_PrincipalObjectAttributeAccesses", null); }
			set { SetRelatedEntities("entitlementchannel_PrincipalObjectAttributeAccesses", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'entitlementchannel_ProcessSession'
        /// </summary>
		[RelationshipSchemaName("entitlementchannel_ProcessSession")]
		public IEnumerable<ProcessSession> EntitlementchannelProcessSession
		{
			get { return GetRelatedEntities<ProcessSession>("entitlementchannel_ProcessSession", null); }
			set { SetRelatedEntities("entitlementchannel_ProcessSession", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'entitlementchannel_SyncErrors'
        /// </summary>
		[RelationshipSchemaName("entitlementchannel_SyncErrors")]
		public IEnumerable<SyncError> EntitlementchannelSyncErrors
		{
			get { return GetRelatedEntities<SyncError>("entitlementchannel_SyncErrors", null); }
			set { SetRelatedEntities("entitlementchannel_SyncErrors", null, value); }
		}
		#endregion

		#region Actions
		#endregion

		#region OptionSetEnums
		public enum egCaseOrigin
		{	
		
			[Label("Phone")]
			[Description(@"")]
			Phone = 1, 
		
			[Label("Email")]
			[Description(@"")]
			Email = 2, 
		
			[Label("Web")]
			[Description(@"")]
			Web = 3, 
		
			[Label("Facebook")]
			[Description(@"")]
			Facebook = 2483, 
		
			[Label("Twitter")]
			[Description(@"")]
			Twitter = 3986, 
		}
		
		#endregion	

		#region Properties
		public static class Properties 
		{
			/// <summary>channel</summary>
			public const string Name = "channel";

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

			/// <summary>entitlementchannelid</summary>
			public const string EntitlementChannelId = "entitlementchannelid";

			/// <summary>entitlementid</summary>
			public const string Entitlement = "entitlementid";

			/// <summary>entitlementidname</summary>
			public const string Entitlementidname = "entitlementidname";

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

			/// <summary>name</summary>
			public const string EntitlementChannelName = "name";

			/// <summary>organizationid</summary>
			public const string Organization = "organizationid";

			/// <summary>organizationidname</summary>
			public const string Organizationidname = "organizationidname";

			/// <summary>overriddencreatedon</summary>
			public const string RecordCreatedOn = "overriddencreatedon";

			/// <summary>ownerid</summary>
			public const string Owner = "ownerid";

			/// <summary>owneridname</summary>
			public const string Owneridname = "owneridname";

			/// <summary>owneridtype</summary>
			public const string Owneridtype = "owneridtype";

			/// <summary>owneridyominame</summary>
			public const string Owneridyominame = "owneridyominame";

			/// <summary>owningbusinessunit</summary>
			public const string OwningBusinessUnit = "owningbusinessunit";

			/// <summary>owningteam</summary>
			public const string OwningTeam = "owningteam";

			/// <summary>owninguser</summary>
			public const string OwningUser = "owninguser";

			/// <summary>remainingterms</summary>
			public const string RemainingTerms = "remainingterms";

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
			/// <summary>1:N entitlementchannel_Annotations</summary>
			public const string EntitlementchannelAnnotations = "entitlementchannel_Annotations";

			/// <summary>1:N entitlementchannel_AsyncOperations</summary>
			public const string EntitlementchannelAsyncOperations = "entitlementchannel_AsyncOperations";

			/// <summary>1:N entitlementchannel_BulkDeleteFailures</summary>
			public const string EntitlementchannelBulkDeleteFailures = "entitlementchannel_BulkDeleteFailures";

			/// <summary>1:N entitlementchannel_connections1</summary>
			public const string EntitlementchannelConnections1 = "entitlementchannel_connections1";

			/// <summary>1:N entitlementchannel_connections2</summary>
			public const string EntitlementchannelConnections2 = "entitlementchannel_connections2";

			/// <summary>1:N entitlementchannel_DuplicateBaseRecord</summary>
			public const string EntitlementchannelDuplicateBaseRecord = "entitlementchannel_DuplicateBaseRecord";

			/// <summary>1:N entitlementchannel_DuplicateMatchingRecord</summary>
			public const string EntitlementchannelDuplicateMatchingRecord = "entitlementchannel_DuplicateMatchingRecord";

			/// <summary>1:N entitlementchannel_MailboxTrackingFolders</summary>
			public const string EntitlementchannelMailboxTrackingFolders = "entitlementchannel_MailboxTrackingFolders";

			/// <summary>1:N entitlementchannel_PrincipalObjectAttributeAccesses</summary>
			public const string EntitlementchannelPrincipalObjectAttributeAccesses = "entitlementchannel_PrincipalObjectAttributeAccesses";

			/// <summary>1:N entitlementchannel_ProcessSession</summary>
			public const string EntitlementchannelProcessSession = "entitlementchannel_ProcessSession";

			/// <summary>1:N entitlementchannel_SyncErrors</summary>
			public const string EntitlementchannelSyncErrors = "entitlementchannel_SyncErrors";

		}
		#endregion
	}
}

