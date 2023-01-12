using System;
using System.Linq;
using System.Diagnostics;
using System.ComponentModel;
using Microsoft.Xrm.Sdk; 
using Microsoft.Xrm.Sdk.Client;
using System.Collections.Generic;

namespace PentaWork.Xrm.Scheduler.Proxies.Entities
{
	[DebuggerDisplay("{EntitlementTemplateChannelName}")] 	
	[EntityLogicalName("entitlementtemplatechannel")]
	public sealed class EntitlementTemplateChannel : Entity
	{	
		public static readonly int? EntityTypeCode = 9703;
		public new const string LogicalName = "entitlementtemplatechannel";
		public const string PrimaryIdAttribute = "entitlementtemplatechannelid";
		public const string PrimaryNameAttribute = "name";
	
		public EntitlementTemplateChannel() : base("entitlementtemplatechannel") { }

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
        /// entitlementtemplatechannelid
        /// </summary>
		[DisplayName("Entitlement Template Channel")]
		[AttributeLogicalName("entitlementtemplatechannelid")]
		public override Guid Id
		{
			get => base.Id;
			set { base.Id = value; SetAttributeValue("entitlementtemplatechannelid", value); }
		}

							/// <summary>
        /// entitlementtemplateid
        /// </summary>
		[DisplayName("Entitlement Template Id")]
		[AttributeLogicalName("entitlementtemplateid")]
		public EntityReference EntitlementTemplateId
		{	
			get { return GetAttributeValue<EntityReference>("entitlementtemplateid"); }
			set
			{ 
				if(value == EntitlementTemplateId) return;
				SetAttributeValue("entitlementtemplateid", value);
			}
		}	
			
		/// <summary>
        /// entitlementtemplateidname
        /// </summary>
		[DisplayName("entitlementtemplateidname")]
		[AttributeLogicalName("entitlementtemplateidname")]
		public string Entitlementtemplateidname
		{	
			get { return GetAttributeValue<string>("entitlementtemplateidname"); }
			set
			{ 
				if(value == Entitlementtemplateidname) return;
				SetAttributeValue("entitlementtemplateidname", value);
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
		[DisplayName("Entitlement Template Channel Name")]
		[AttributeLogicalName("name")]
		public string EntitlementTemplateChannelName
		{	
			get { return GetAttributeValue<string>("name"); }
			set
			{ 
				if(value == EntitlementTemplateChannelName) return;
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
		///
		/// Precision: 2
		/// MaxValue: 100000000000
		/// MinValue: 0
        /// </summary>
		[DisplayName("Total Terms")]
		[AttributeLogicalName("totalterms")]
		public decimal? TotalTerms
		{	
			get { return GetAttributeValue<decimal?>("totalterms"); }
			set 
			{
				decimal? decimalValue = null;
				if(value != null) decimalValue = Decimal.Round(value.Value, 2);
				if(decimalValue == TotalTerms) return;
				SetAttributeValue("totalterms", decimalValue);  
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
        /// 1:N Get entities for 'entitlementtemplatechannel_AsyncOperations'
        /// </summary>
		[RelationshipSchemaName("entitlementtemplatechannel_AsyncOperations")]
		public IEnumerable<SystemJob> EntitlementtemplatechannelAsyncOperations
		{
			get { return GetRelatedEntities<SystemJob>("entitlementtemplatechannel_AsyncOperations", null); }
			set { SetRelatedEntities("entitlementtemplatechannel_AsyncOperations", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'entitlementtemplatechannel_BulkDeleteFailures'
        /// </summary>
		[RelationshipSchemaName("entitlementtemplatechannel_BulkDeleteFailures")]
		public IEnumerable<BulkDeleteFailure> EntitlementtemplatechannelBulkDeleteFailures
		{
			get { return GetRelatedEntities<BulkDeleteFailure>("entitlementtemplatechannel_BulkDeleteFailures", null); }
			set { SetRelatedEntities("entitlementtemplatechannel_BulkDeleteFailures", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'entitlementtemplatechannel_connections1'
        /// </summary>
		[RelationshipSchemaName("entitlementtemplatechannel_connections1")]
		public IEnumerable<Connection> EntitlementtemplatechannelConnections1
		{
			get { return GetRelatedEntities<Connection>("entitlementtemplatechannel_connections1", null); }
			set { SetRelatedEntities("entitlementtemplatechannel_connections1", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'entitlementtemplatechannel_connections2'
        /// </summary>
		[RelationshipSchemaName("entitlementtemplatechannel_connections2")]
		public IEnumerable<Connection> EntitlementtemplatechannelConnections2
		{
			get { return GetRelatedEntities<Connection>("entitlementtemplatechannel_connections2", null); }
			set { SetRelatedEntities("entitlementtemplatechannel_connections2", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'entitlementtemplatechannel_MailboxTrackingFolders'
        /// </summary>
		[RelationshipSchemaName("entitlementtemplatechannel_MailboxTrackingFolders")]
		public IEnumerable<MailboxAutoTrackingFolder> EntitlementtemplatechannelMailboxTrackingFolders
		{
			get { return GetRelatedEntities<MailboxAutoTrackingFolder>("entitlementtemplatechannel_MailboxTrackingFolders", null); }
			set { SetRelatedEntities("entitlementtemplatechannel_MailboxTrackingFolders", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'entitlementtemplatechannel_PrincipalObjectAttributeAccesses'
        /// </summary>
		[RelationshipSchemaName("entitlementtemplatechannel_PrincipalObjectAttributeAccesses")]
		public IEnumerable<FieldSharing> EntitlementtemplatechannelPrincipalObjectAttributeAccesses
		{
			get { return GetRelatedEntities<FieldSharing>("entitlementtemplatechannel_PrincipalObjectAttributeAccesses", null); }
			set { SetRelatedEntities("entitlementtemplatechannel_PrincipalObjectAttributeAccesses", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'entitlementtemplatechannel_SyncErrors'
        /// </summary>
		[RelationshipSchemaName("entitlementtemplatechannel_SyncErrors")]
		public IEnumerable<SyncError> EntitlementtemplatechannelSyncErrors
		{
			get { return GetRelatedEntities<SyncError>("entitlementtemplatechannel_SyncErrors", null); }
			set { SetRelatedEntities("entitlementtemplatechannel_SyncErrors", null, value); }
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

			/// <summary>entitlementtemplatechannelid</summary>
			public const string EntitlementTemplateChannelId = "entitlementtemplatechannelid";

			/// <summary>entitlementtemplateid</summary>
			public const string EntitlementTemplateId = "entitlementtemplateid";

			/// <summary>entitlementtemplateidname</summary>
			public const string Entitlementtemplateidname = "entitlementtemplateidname";

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
			public const string EntitlementTemplateChannelName = "name";

			/// <summary>organizationid</summary>
			public const string Organization = "organizationid";

			/// <summary>organizationidname</summary>
			public const string Organizationidname = "organizationidname";

			/// <summary>overriddencreatedon</summary>
			public const string RecordCreatedOn = "overriddencreatedon";

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
			/// <summary>1:N entitlementtemplatechannel_AsyncOperations</summary>
			public const string EntitlementtemplatechannelAsyncOperations = "entitlementtemplatechannel_AsyncOperations";

			/// <summary>1:N entitlementtemplatechannel_BulkDeleteFailures</summary>
			public const string EntitlementtemplatechannelBulkDeleteFailures = "entitlementtemplatechannel_BulkDeleteFailures";

			/// <summary>1:N entitlementtemplatechannel_connections1</summary>
			public const string EntitlementtemplatechannelConnections1 = "entitlementtemplatechannel_connections1";

			/// <summary>1:N entitlementtemplatechannel_connections2</summary>
			public const string EntitlementtemplatechannelConnections2 = "entitlementtemplatechannel_connections2";

			/// <summary>1:N entitlementtemplatechannel_MailboxTrackingFolders</summary>
			public const string EntitlementtemplatechannelMailboxTrackingFolders = "entitlementtemplatechannel_MailboxTrackingFolders";

			/// <summary>1:N entitlementtemplatechannel_PrincipalObjectAttributeAccesses</summary>
			public const string EntitlementtemplatechannelPrincipalObjectAttributeAccesses = "entitlementtemplatechannel_PrincipalObjectAttributeAccesses";

			/// <summary>1:N entitlementtemplatechannel_SyncErrors</summary>
			public const string EntitlementtemplatechannelSyncErrors = "entitlementtemplatechannel_SyncErrors";

		}
		#endregion
	}
}

