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
	[EntityLogicalName("dynamicpropertyinstance")]
	public sealed class PropertyInstance : Entity
	{	
		public static readonly int? EntityTypeCode = 1333;
		public new const string LogicalName = "dynamicpropertyinstance";
		public const string PrimaryIdAttribute = "dynamicpropertyinstanceid";
		public const string PrimaryNameAttribute = "name";
	
		public PropertyInstance() : base("dynamicpropertyinstance") { }

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
        /// dynamicpropertyinstanceid
        /// </summary>
		[DisplayName("Property Instance ID")]
		[AttributeLogicalName("dynamicpropertyinstanceid")]
		public override Guid Id
		{
			get => base.Id;
			set { base.Id = value; SetAttributeValue("dynamicpropertyinstanceid", value); }
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
		[DisplayName("name")]
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
        /// regardingobjectid
        /// </summary>
		[DisplayName("Regarding")]
		[AttributeLogicalName("regardingobjectid")]
		public EntityReference Regarding
		{	
			get { return GetAttributeValue<EntityReference>("regardingobjectid"); }
			set
			{ 
				if(value == Regarding) return;
				SetAttributeValue("regardingobjectid", value);
			}
		}	
			
		/// <summary>
        /// regardingobjectidname
        /// </summary>
		[DisplayName("regardingobjectidname")]
		[AttributeLogicalName("regardingobjectidname")]
		public string Regardingobjectidname
		{	
			get { return GetAttributeValue<string>("regardingobjectidname"); }
			set
			{ 
				if(value == Regardingobjectidname) return;
				SetAttributeValue("regardingobjectidname", value);
			}
		}	
			
		/// <summary>
        /// regardingobjectidtype
        /// </summary>
		[DisplayName("regardingobjectidtype")]
		[AttributeLogicalName("regardingobjectidtype")]
		public string Regardingobjectidtype
		{	
			get { return GetAttributeValue<string>("regardingobjectidtype"); }
			set
			{ 
				if(value == Regardingobjectidtype) return;
				SetAttributeValue("regardingobjectidtype", value);
			}
		}	
			
		/// <summary>
        /// regardingobjectidyominame
        /// </summary>
		[DisplayName("regardingobjectidyominame")]
		[AttributeLogicalName("regardingobjectidyominame")]
		public string Regardingobjectidyominame
		{	
			get { return GetAttributeValue<string>("regardingobjectidyominame"); }
			set
			{ 
				if(value == Regardingobjectidyominame) return;
				SetAttributeValue("regardingobjectidyominame", value);
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
        /// validationstatus
        /// </summary>
		[DisplayName("Is Valid")]
		[AttributeLogicalName("validationstatus")]
		public bool? IsValid
		{	
			get { return GetAttributeValue<bool?>("validationstatus"); }
			set
			{ 
				if(value == IsValid) return;
				SetAttributeValue("validationstatus", value);
			}
		}	
			
		/// <summary>
        /// valuedecimal
        /// </summary>
		[DisplayName("Decimal Value")]
		[AttributeLogicalName("valuedecimal")]
		public decimal? DecimalValue
		{	
			get { return GetAttributeValue<decimal?>("valuedecimal"); }
			set
			{ 
				if(value == DecimalValue) return;
				SetAttributeValue("valuedecimal", value);
			}
		}	
			
		/// <summary>
        /// valuedouble
        /// </summary>
		[DisplayName("Double Value")]
		[AttributeLogicalName("valuedouble")]
		public double? DoubleValue
		{	
			get { return GetAttributeValue<double?>("valuedouble"); }
			set
			{ 
				if(value == DoubleValue) return;
				SetAttributeValue("valuedouble", value);
			}
		}	
			
		/// <summary>
        /// valueinteger
        /// </summary>
		[DisplayName("Integer Value")]
		[AttributeLogicalName("valueinteger")]
		public int? IntegerValue
		{	
			get { return GetAttributeValue<int?>("valueinteger"); }
			set
			{ 
				if(value == IntegerValue) return;
				SetAttributeValue("valueinteger", value);
			}
		}	
			
		/// <summary>
        /// valuestring
        /// </summary>
		[DisplayName("String Value")]
		[AttributeLogicalName("valuestring")]
		public string StringValue
		{	
			get { return GetAttributeValue<string>("valuestring"); }
			set
			{ 
				if(value == StringValue) return;
				SetAttributeValue("valuestring", value);
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
        /// 1:N Get entities for 'dynamicpropertyinstance_AsyncOperations'
        /// </summary>
		[RelationshipSchemaName("dynamicpropertyinstance_AsyncOperations")]
		public IEnumerable<SystemJob> DynamicpropertyinstanceAsyncOperations
		{
			get { return GetRelatedEntities<SystemJob>("dynamicpropertyinstance_AsyncOperations", null); }
			set { SetRelatedEntities("dynamicpropertyinstance_AsyncOperations", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'dynamicpropertyinstance_BulkDeleteFailures'
        /// </summary>
		[RelationshipSchemaName("dynamicpropertyinstance_BulkDeleteFailures")]
		public IEnumerable<BulkDeleteFailure> DynamicpropertyinstanceBulkDeleteFailures
		{
			get { return GetRelatedEntities<BulkDeleteFailure>("dynamicpropertyinstance_BulkDeleteFailures", null); }
			set { SetRelatedEntities("dynamicpropertyinstance_BulkDeleteFailures", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'dynamicpropertyinstance_MailboxTrackingFolders'
        /// </summary>
		[RelationshipSchemaName("dynamicpropertyinstance_MailboxTrackingFolders")]
		public IEnumerable<MailboxAutoTrackingFolder> DynamicpropertyinstanceMailboxTrackingFolders
		{
			get { return GetRelatedEntities<MailboxAutoTrackingFolder>("dynamicpropertyinstance_MailboxTrackingFolders", null); }
			set { SetRelatedEntities("dynamicpropertyinstance_MailboxTrackingFolders", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'dynamicpropertyinstance_PrincipalObjectAttributeAccesses'
        /// </summary>
		[RelationshipSchemaName("dynamicpropertyinstance_PrincipalObjectAttributeAccesses")]
		public IEnumerable<FieldSharing> DynamicpropertyinstancePrincipalObjectAttributeAccesses
		{
			get { return GetRelatedEntities<FieldSharing>("dynamicpropertyinstance_PrincipalObjectAttributeAccesses", null); }
			set { SetRelatedEntities("dynamicpropertyinstance_PrincipalObjectAttributeAccesses", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'dynamicpropertyinstance_SyncErrors'
        /// </summary>
		[RelationshipSchemaName("dynamicpropertyinstance_SyncErrors")]
		public IEnumerable<SyncError> DynamicpropertyinstanceSyncErrors
		{
			get { return GetRelatedEntities<SyncError>("dynamicpropertyinstance_SyncErrors", null); }
			set { SetRelatedEntities("dynamicpropertyinstance_SyncErrors", null, value); }
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

			/// <summary>dynamicpropertyinstanceid</summary>
			public const string PropertyInstanceId = "dynamicpropertyinstanceid";

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
			public const string Name = "name";

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

			/// <summary>regardingobjectid</summary>
			public const string Regarding = "regardingobjectid";

			/// <summary>regardingobjectidname</summary>
			public const string Regardingobjectidname = "regardingobjectidname";

			/// <summary>regardingobjectidtype</summary>
			public const string Regardingobjectidtype = "regardingobjectidtype";

			/// <summary>regardingobjectidyominame</summary>
			public const string Regardingobjectidyominame = "regardingobjectidyominame";

			/// <summary>timezoneruleversionnumber</summary>
			public const string TimeZoneRuleVersionNumber = "timezoneruleversionnumber";

			/// <summary>transactioncurrencyid</summary>
			public const string Currency = "transactioncurrencyid";

			/// <summary>transactioncurrencyidname</summary>
			public const string Transactioncurrencyidname = "transactioncurrencyidname";

			/// <summary>utcconversiontimezonecode</summary>
			public const string UTCConversionTimeZoneCode = "utcconversiontimezonecode";

			/// <summary>validationstatus</summary>
			public const string IsValid = "validationstatus";

			/// <summary>valuedecimal</summary>
			public const string DecimalValue = "valuedecimal";

			/// <summary>valuedouble</summary>
			public const string DoubleValue = "valuedouble";

			/// <summary>valueinteger</summary>
			public const string IntegerValue = "valueinteger";

			/// <summary>valuestring</summary>
			public const string StringValue = "valuestring";

			/// <summary>versionnumber</summary>
			public const string VersionNumber = "versionnumber";

		}
		#endregion

		#region Schemas
		public static class Schemas 
		{
			/// <summary>1:N dynamicpropertyinstance_AsyncOperations</summary>
			public const string DynamicpropertyinstanceAsyncOperations = "dynamicpropertyinstance_AsyncOperations";

			/// <summary>1:N dynamicpropertyinstance_BulkDeleteFailures</summary>
			public const string DynamicpropertyinstanceBulkDeleteFailures = "dynamicpropertyinstance_BulkDeleteFailures";

			/// <summary>1:N dynamicpropertyinstance_MailboxTrackingFolders</summary>
			public const string DynamicpropertyinstanceMailboxTrackingFolders = "dynamicpropertyinstance_MailboxTrackingFolders";

			/// <summary>1:N dynamicpropertyinstance_PrincipalObjectAttributeAccesses</summary>
			public const string DynamicpropertyinstancePrincipalObjectAttributeAccesses = "dynamicpropertyinstance_PrincipalObjectAttributeAccesses";

			/// <summary>1:N dynamicpropertyinstance_SyncErrors</summary>
			public const string DynamicpropertyinstanceSyncErrors = "dynamicpropertyinstance_SyncErrors";

		}
		#endregion
	}
}

