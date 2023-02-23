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
	[EntityLogicalName("discount")]
	public sealed class Discount : Entity
	{	
		public static readonly int? EntityTypeCode = 1013;
		public new const string LogicalName = "discount";
		public const string PrimaryIdAttribute = "discountid";
		public const string PrimaryNameAttribute = "name";
	
		public Discount() : base("discount") { }

		#region Attributes
		/// <summary>
        /// amount
		///
		/// Precision: 4
		/// MaxValue: 1000000000000
		/// MinValue: 0
        /// </summary>
		[DisplayName("Amount")]
		[AttributeLogicalName("amount")]
		public decimal? Amount
		{	
			get { return GetAttributeValue<Money>("amount")?.Value; }
			set 
			{
				Money moneyValue = null;
				if(value != null) 
				{
					var roundedValue = Decimal.Round(value.Value, 4);
					moneyValue = new Money(roundedValue);
				}

				if(moneyValue.Value == Amount) return;
				SetAttributeValue("amount", moneyValue);  
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
        /// discountid
        /// </summary>
		[DisplayName("Discount")]
		[AttributeLogicalName("discountid")]
		public override Guid Id
		{
			get => base.Id;
			set { base.Id = value; SetAttributeValue("discountid", value); }
		}

							/// <summary>
        /// discounttypeid
        /// </summary>
		[DisplayName("Discount Type")]
		[AttributeLogicalName("discounttypeid")]
		public EntityReference DiscountType
		{	
			get { return GetAttributeValue<EntityReference>("discounttypeid"); }
			set
			{ 
				if(value == DiscountType) return;
				SetAttributeValue("discounttypeid", value);
			}
		}	
			
		/// <summary>
        /// discounttypeidname
        /// </summary>
		[DisplayName("discounttypeidname")]
		[AttributeLogicalName("discounttypeidname")]
		public string Discounttypeidname
		{	
			get { return GetAttributeValue<string>("discounttypeidname"); }
			set
			{ 
				if(value == Discounttypeidname) return;
				SetAttributeValue("discounttypeidname", value);
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
        /// highquantity
		///
		/// Precision: 5
		/// MaxValue: 100000000000
		/// MinValue: 0.00001
        /// </summary>
		[DisplayName("End Quantity")]
		[AttributeLogicalName("highquantity")]
		public decimal? EndQuantity
		{	
			get { return GetAttributeValue<decimal?>("highquantity"); }
			set 
			{
				decimal? decimalValue = null;
				if(value != null) decimalValue = Decimal.Round(value.Value, 5);
				if(decimalValue == EndQuantity) return;
				SetAttributeValue("highquantity", decimalValue);  
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
        /// isamounttype
        /// </summary>
		[DisplayName("Amount Type")]
		[AttributeLogicalName("isamounttype")]
		public bool? AmountType
		{	
			get { return GetAttributeValue<bool?>("isamounttype"); }
			set
			{ 
				if(value == AmountType) return;
				SetAttributeValue("isamounttype", value);
			}
		}	
			
		/// <summary>
        /// lowquantity
		///
		/// Precision: 5
		/// MaxValue: 100000000000
		/// MinValue: 0.00001
        /// </summary>
		[DisplayName("Begin Quantity")]
		[AttributeLogicalName("lowquantity")]
		public decimal? BeginQuantity
		{	
			get { return GetAttributeValue<decimal?>("lowquantity"); }
			set 
			{
				decimal? decimalValue = null;
				if(value != null) decimalValue = Decimal.Round(value.Value, 5);
				if(decimalValue == BeginQuantity) return;
				SetAttributeValue("lowquantity", decimalValue);  
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
        /// organizationid
        /// </summary>
		[DisplayName("Organization")]
		[AttributeLogicalName("organizationid")]
		public Guid OrganizationId
		{	
			get { return GetAttributeValue<Guid>("organizationid"); }
			set
			{ 
				if(value == OrganizationId) return;
				SetAttributeValue("organizationid", value);
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
        /// percentage
		///
		/// Precision: 5
		/// MaxValue: 1000000000
		/// MinValue: 0
        /// </summary>
		[DisplayName("Percentage")]
		[AttributeLogicalName("percentage")]
		public decimal? Percentage
		{	
			get { return GetAttributeValue<decimal?>("percentage"); }
			set 
			{
				decimal? decimalValue = null;
				if(value != null) decimalValue = Decimal.Round(value.Value, 5);
				if(decimalValue == Percentage) return;
				SetAttributeValue("percentage", decimalValue);  
			}
		}

		/// <summary>
        /// statuscode
        /// </summary>
		[DisplayName("Status Reason")]
		[AttributeLogicalName("statuscode")]
		public eStatusReason? StatusReason
		{	
			get 
			{ 
				var optionSetValue = GetAttributeValue<OptionSetValue>("statuscode");
				if (optionSetValue != null) return (eStatusReason)optionSetValue.Value;
				else return null;
			}
			set 
			{ 
				if(value == StatusReason) return;

				OptionSetValue optionSetValue = null;
				if(value != null) optionSetValue = new OptionSetValue((int)value);
				SetAttributeValue("statuscode", optionSetValue); 
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
        /// 1:N Get entities for 'Discount_AsyncOperations'
        /// </summary>
		[RelationshipSchemaName("Discount_AsyncOperations")]
		public IEnumerable<SystemJob> DiscountAsyncOperations
		{
			get { return GetRelatedEntities<SystemJob>("Discount_AsyncOperations", null); }
			set { SetRelatedEntities("Discount_AsyncOperations", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'Discount_BulkDeleteFailures'
        /// </summary>
		[RelationshipSchemaName("Discount_BulkDeleteFailures")]
		public IEnumerable<BulkDeleteFailure> DiscountBulkDeleteFailures
		{
			get { return GetRelatedEntities<BulkDeleteFailure>("Discount_BulkDeleteFailures", null); }
			set { SetRelatedEntities("Discount_BulkDeleteFailures", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'discount_MailboxTrackingFolders'
        /// </summary>
		[RelationshipSchemaName("discount_MailboxTrackingFolders")]
		public IEnumerable<MailboxAutoTrackingFolder> DiscountMailboxTrackingFolders
		{
			get { return GetRelatedEntities<MailboxAutoTrackingFolder>("discount_MailboxTrackingFolders", null); }
			set { SetRelatedEntities("discount_MailboxTrackingFolders", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'discount_PrincipalObjectAttributeAccesses'
        /// </summary>
		[RelationshipSchemaName("discount_PrincipalObjectAttributeAccesses")]
		public IEnumerable<FieldSharing> DiscountPrincipalObjectAttributeAccesses
		{
			get { return GetRelatedEntities<FieldSharing>("discount_PrincipalObjectAttributeAccesses", null); }
			set { SetRelatedEntities("discount_PrincipalObjectAttributeAccesses", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'Discount_ProcessSessions'
        /// </summary>
		[RelationshipSchemaName("Discount_ProcessSessions")]
		public IEnumerable<ProcessSession> DiscountProcessSessions
		{
			get { return GetRelatedEntities<ProcessSession>("Discount_ProcessSessions", null); }
			set { SetRelatedEntities("Discount_ProcessSessions", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'Discount_SyncErrors'
        /// </summary>
		[RelationshipSchemaName("Discount_SyncErrors")]
		public IEnumerable<SyncError> DiscountSyncErrors
		{
			get { return GetRelatedEntities<SyncError>("Discount_SyncErrors", null); }
			set { SetRelatedEntities("Discount_SyncErrors", null, value); }
		}
		#endregion

		#region Actions
		#endregion

		#region OptionSetEnums
		public enum eStatusReason
		{	
		}
		
		#endregion	

		#region Properties
		public static class Properties 
		{
			/// <summary>amount</summary>
			public const string Amount = "amount";

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

			/// <summary>discountid</summary>
			public const string DiscountId = "discountid";

			/// <summary>discounttypeid</summary>
			public const string DiscountType = "discounttypeid";

			/// <summary>discounttypeidname</summary>
			public const string Discounttypeidname = "discounttypeidname";

			/// <summary>exchangerate</summary>
			public const string ExchangeRate = "exchangerate";

			/// <summary>highquantity</summary>
			public const string EndQuantity = "highquantity";

			/// <summary>importsequencenumber</summary>
			public const string ImportSequenceNumber = "importsequencenumber";

			/// <summary>isamounttype</summary>
			public const string AmountType = "isamounttype";

			/// <summary>lowquantity</summary>
			public const string BeginQuantity = "lowquantity";

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
			public const string OrganizationId = "organizationid";

			/// <summary>overriddencreatedon</summary>
			public const string RecordCreatedOn = "overriddencreatedon";

			/// <summary>percentage</summary>
			public const string Percentage = "percentage";

			/// <summary>statuscode</summary>
			public const string StatusReason = "statuscode";

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
			/// <summary>1:N Discount_AsyncOperations</summary>
			public const string DiscountAsyncOperations = "Discount_AsyncOperations";

			/// <summary>1:N Discount_BulkDeleteFailures</summary>
			public const string DiscountBulkDeleteFailures = "Discount_BulkDeleteFailures";

			/// <summary>1:N discount_MailboxTrackingFolders</summary>
			public const string DiscountMailboxTrackingFolders = "discount_MailboxTrackingFolders";

			/// <summary>1:N discount_PrincipalObjectAttributeAccesses</summary>
			public const string DiscountPrincipalObjectAttributeAccesses = "discount_PrincipalObjectAttributeAccesses";

			/// <summary>1:N Discount_ProcessSessions</summary>
			public const string DiscountProcessSessions = "Discount_ProcessSessions";

			/// <summary>1:N Discount_SyncErrors</summary>
			public const string DiscountSyncErrors = "Discount_SyncErrors";

		}
		#endregion
	}
}

