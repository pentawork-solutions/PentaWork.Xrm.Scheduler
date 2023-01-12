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
	[EntityLogicalName("dynamicpropertyoptionsetitem")]
	public sealed class PropertyOptionSetItem : Entity
	{	
		public static readonly int? EntityTypeCode = 1049;
		public new const string LogicalName = "dynamicpropertyoptionsetitem";
		public const string PrimaryIdAttribute = "dynamicpropertyoptionsetvalueid";
		public const string PrimaryNameAttribute = "dynamicpropertyoptionname";
	
		public PropertyOptionSetItem() : base("dynamicpropertyoptionsetitem") { }

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
        /// dmtimportstate
        /// </summary>
		[DisplayName("Internal Use Only")]
		[AttributeLogicalName("dmtimportstate")]
		public int? InternalUseOnly
		{	
			get { return GetAttributeValue<int?>("dmtimportstate"); }
			set
			{ 
				if(value == InternalUseOnly) return;
				SetAttributeValue("dmtimportstate", value);
			}
		}	
			
		/// <summary>
        /// dynamicpropertyid
        /// </summary>
		[DisplayName("Property ID")]
		[AttributeLogicalName("dynamicpropertyid")]
		public EntityReference PropertyID
		{	
			get { return GetAttributeValue<EntityReference>("dynamicpropertyid"); }
			set
			{ 
				if(value == PropertyID) return;
				SetAttributeValue("dynamicpropertyid", value);
			}
		}	
			
		/// <summary>
        /// dynamicpropertyidname
        /// </summary>
		[DisplayName("dynamicpropertyidname")]
		[AttributeLogicalName("dynamicpropertyidname")]
		public string Dynamicpropertyidname
		{	
			get { return GetAttributeValue<string>("dynamicpropertyidname"); }
			set
			{ 
				if(value == Dynamicpropertyidname) return;
				SetAttributeValue("dynamicpropertyidname", value);
			}
		}	
			
		/// <summary>
        /// dynamicpropertyoptiondescription
        /// </summary>
		[DisplayName("Description")]
		[AttributeLogicalName("dynamicpropertyoptiondescription")]
		public string Description
		{	
			get { return GetAttributeValue<string>("dynamicpropertyoptiondescription"); }
			set
			{ 
				if(value == Description) return;
				SetAttributeValue("dynamicpropertyoptiondescription", value);
			}
		}	
			
		/// <summary>
        /// dynamicpropertyoptionname
        /// </summary>
		[DisplayName("Name")]
		[AttributeLogicalName("dynamicpropertyoptionname")]
		public string Name
		{	
			get { return GetAttributeValue<string>("dynamicpropertyoptionname"); }
			set
			{ 
				if(value == Name) return;
				SetAttributeValue("dynamicpropertyoptionname", value);
			}
		}	
			
		/// <summary>
        /// dynamicpropertyoptionsetvalueid
        /// </summary>
		[DisplayName("Property Option Set ID")]
		[AttributeLogicalName("dynamicpropertyoptionsetvalueid")]
		public override Guid Id
		{
			get => base.Id;
			set { base.Id = value; SetAttributeValue("dynamicpropertyoptionsetvalueid", value); }
		}

							/// <summary>
        /// dynamicpropertyoptionsetvaluesequencenumber
        /// </summary>
		[DisplayName("Internal Use Only")]
		[AttributeLogicalName("dynamicpropertyoptionsetvaluesequencenumber")]
		public int? InternalUseOnly2
		{	
			get { return GetAttributeValue<int?>("dynamicpropertyoptionsetvaluesequencenumber"); }
			set
			{ 
				if(value == InternalUseOnly2) return;
				SetAttributeValue("dynamicpropertyoptionsetvaluesequencenumber", value);
			}
		}	
			
		/// <summary>
        /// dynamicpropertyoptionvalue
        /// </summary>
		[DisplayName("Value")]
		[AttributeLogicalName("dynamicpropertyoptionvalue")]
		public int? Value
		{	
			get { return GetAttributeValue<int?>("dynamicpropertyoptionvalue"); }
			set
			{ 
				if(value == Value) return;
				SetAttributeValue("dynamicpropertyoptionvalue", value);
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
        /// 1:N Get entities for 'DefaultValueOptionSet_DynamicProperty'
        /// </summary>
		[RelationshipSchemaName("DefaultValueOptionSet_DynamicProperty")]
		public IEnumerable<Property> DefaultValueOptionSetDynamicProperty
		{
			get { return GetRelatedEntities<Property>("DefaultValueOptionSet_DynamicProperty", null); }
			set { SetRelatedEntities("DefaultValueOptionSet_DynamicProperty", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'dynamicpropertyoptionsetitem_AsyncOperations'
        /// </summary>
		[RelationshipSchemaName("dynamicpropertyoptionsetitem_AsyncOperations")]
		public IEnumerable<SystemJob> DynamicpropertyoptionsetitemAsyncOperations
		{
			get { return GetRelatedEntities<SystemJob>("dynamicpropertyoptionsetitem_AsyncOperations", null); }
			set { SetRelatedEntities("dynamicpropertyoptionsetitem_AsyncOperations", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'dynamicpropertyoptionsetitem_BulkDeleteFailures'
        /// </summary>
		[RelationshipSchemaName("dynamicpropertyoptionsetitem_BulkDeleteFailures")]
		public IEnumerable<BulkDeleteFailure> DynamicpropertyoptionsetitemBulkDeleteFailures
		{
			get { return GetRelatedEntities<BulkDeleteFailure>("dynamicpropertyoptionsetitem_BulkDeleteFailures", null); }
			set { SetRelatedEntities("dynamicpropertyoptionsetitem_BulkDeleteFailures", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'dynamicpropertyoptionsetitem_MailboxTrackingFolders'
        /// </summary>
		[RelationshipSchemaName("dynamicpropertyoptionsetitem_MailboxTrackingFolders")]
		public IEnumerable<MailboxAutoTrackingFolder> DynamicpropertyoptionsetitemMailboxTrackingFolders
		{
			get { return GetRelatedEntities<MailboxAutoTrackingFolder>("dynamicpropertyoptionsetitem_MailboxTrackingFolders", null); }
			set { SetRelatedEntities("dynamicpropertyoptionsetitem_MailboxTrackingFolders", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'dynamicpropertyoptionsetitem_PrincipalObjectAttributeAccesses'
        /// </summary>
		[RelationshipSchemaName("dynamicpropertyoptionsetitem_PrincipalObjectAttributeAccesses")]
		public IEnumerable<FieldSharing> DynamicpropertyoptionsetitemPrincipalObjectAttributeAccesses
		{
			get { return GetRelatedEntities<FieldSharing>("dynamicpropertyoptionsetitem_PrincipalObjectAttributeAccesses", null); }
			set { SetRelatedEntities("dynamicpropertyoptionsetitem_PrincipalObjectAttributeAccesses", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'dynamicpropertyoptionsetitem_SyncErrors'
        /// </summary>
		[RelationshipSchemaName("dynamicpropertyoptionsetitem_SyncErrors")]
		public IEnumerable<SyncError> DynamicpropertyoptionsetitemSyncErrors
		{
			get { return GetRelatedEntities<SyncError>("dynamicpropertyoptionsetitem_SyncErrors", null); }
			set { SetRelatedEntities("dynamicpropertyoptionsetitem_SyncErrors", null, value); }
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

			/// <summary>dmtimportstate</summary>
			public const string InternalUseOnly = "dmtimportstate";

			/// <summary>dynamicpropertyid</summary>
			public const string PropertyID = "dynamicpropertyid";

			/// <summary>dynamicpropertyidname</summary>
			public const string Dynamicpropertyidname = "dynamicpropertyidname";

			/// <summary>dynamicpropertyoptiondescription</summary>
			public const string Description = "dynamicpropertyoptiondescription";

			/// <summary>dynamicpropertyoptionname</summary>
			public const string Name = "dynamicpropertyoptionname";

			/// <summary>dynamicpropertyoptionsetvalueid</summary>
			public const string PropertyOptionSetId = "dynamicpropertyoptionsetvalueid";

			/// <summary>dynamicpropertyoptionsetvaluesequencenumber</summary>
			public const string InternalUseOnly2 = "dynamicpropertyoptionsetvaluesequencenumber";

			/// <summary>dynamicpropertyoptionvalue</summary>
			public const string Value = "dynamicpropertyoptionvalue";

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

			/// <summary>organizationid</summary>
			public const string OrganizationId = "organizationid";

			/// <summary>organizationidname</summary>
			public const string Organizationidname = "organizationidname";

			/// <summary>overriddencreatedon</summary>
			public const string RecordCreatedOn = "overriddencreatedon";

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
			/// <summary>1:N DefaultValueOptionSet_DynamicProperty</summary>
			public const string DefaultValueOptionSetDynamicProperty = "DefaultValueOptionSet_DynamicProperty";

			/// <summary>1:N dynamicpropertyoptionsetitem_AsyncOperations</summary>
			public const string DynamicpropertyoptionsetitemAsyncOperations = "dynamicpropertyoptionsetitem_AsyncOperations";

			/// <summary>1:N dynamicpropertyoptionsetitem_BulkDeleteFailures</summary>
			public const string DynamicpropertyoptionsetitemBulkDeleteFailures = "dynamicpropertyoptionsetitem_BulkDeleteFailures";

			/// <summary>1:N dynamicpropertyoptionsetitem_MailboxTrackingFolders</summary>
			public const string DynamicpropertyoptionsetitemMailboxTrackingFolders = "dynamicpropertyoptionsetitem_MailboxTrackingFolders";

			/// <summary>1:N dynamicpropertyoptionsetitem_PrincipalObjectAttributeAccesses</summary>
			public const string DynamicpropertyoptionsetitemPrincipalObjectAttributeAccesses = "dynamicpropertyoptionsetitem_PrincipalObjectAttributeAccesses";

			/// <summary>1:N dynamicpropertyoptionsetitem_SyncErrors</summary>
			public const string DynamicpropertyoptionsetitemSyncErrors = "dynamicpropertyoptionsetitem_SyncErrors";

		}
		#endregion
	}
}

